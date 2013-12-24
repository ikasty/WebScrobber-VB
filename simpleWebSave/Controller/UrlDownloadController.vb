Imports System.Threading

' 다운받을 Url 목록을 관리하는 클래스
' Singleton 패턴을 사용하여 UrlDownloadController.getSingleton()으로 객체를 얻어와야 한다.
Public NotInheritable Class UrlDownloadController
    ' 생성자
    Private Sub New()
    End Sub

    ' 이 클래스의 Singleton
    Private Shared Singleton As New UrlDownloadController()

    ' Singleton을 리턴해주는 함수
    ' @return UrlDownloadController
    Public Shared Function getSingleton() As UrlDownloadController
        Return Singleton
    End Function

    ' 수집을 기다리는 url
    Private Shared urlList As New Queue(Of SingleURL)

    ' 대기 목록에 url 추가
    Public Sub addSingleUrl(ByRef URL As SingleURL)
        Monitor.Enter(urlList)
        urlList.Enqueue(URL)
        Monitor.Exit(urlList)
    End Sub

    ' url을 리턴하는 함수
    ' @return SingleUrl
    Private Shared Function getSingleUrl() As SingleURL
        Dim returnUrl As SingleURL
        SyncLock urlList
            If urlList.Count = 0 Then
                returnUrl = Nothing
            Else
                returnUrl = urlList.Dequeue()
            End If
        End SyncLock

        Return returnUrl
    End Function


    ' url로부터 이미지를 받아옴
    Private Shared getImageThreads() As Thread
    Private Shared ReadOnly totalThreadsCount As Integer
    Private Shared liveThreadsCount As Integer = 0
    Private Shared runningThreads As Boolean = True

    Shared Sub New()
        totalThreadsCount = Environment.ProcessorCount
        If totalThreadsCount > 6 Then totalThreadsCount = 6
        
        ReDim getImageThreads(totalThreadsCount)
        For Each getImageThread As Thread In getImageThreads
            getImageThread = New Thread(AddressOf getImageFromSource)
        Next
    End Sub

    ' ImageDownloader 객체
    'Private Shared ImageDownloadController As ImageDownloadController = ImageDownloadController.getSingleton()
    Private Shared Sub getImageFromSource()
        Dim StartPos As Integer, FinishPos As Integer
        Dim Link As String = ""

        liveThreadsCount += 1
        While (runningThreads)
            Dim singleUrl As SingleURL = getSingleUrl()
            If (singleUrl Is Nothing) Then
                Exit While
            End If
            Dim Page As Integer = 1

            '//초기화
            StartPos = 1
            FinishPos = 1

            '//모든 <img>태그를 찾아서, src 옵션 값을 읽는다
            Do
                StartPos = InStr(StartPos, singleUrl.lowerSource, "<img") + "<img".Length
                If StartPos < 5 Then Exit Do
                StartPos = InStr(StartPos, singleUrl.lowerSource, "src=""") + "src=""".Length
                If StartPos < 6 Then Exit Do

                FinishPos = InStr(StartPos, singleUrl.lowerSource, """")

                Link = Mid(singleUrl.Source, StartPos, FinishPos - StartPos)
                singleUrl.addImageLink(Link)
            Loop

            'ImageDownloadController.push(singleUrl)
        End While
        liveThreadsCount -= 1
    End Sub

    Private Shared Sub Notice(ByVal Message As String)
        Mainform.SendNotice("UrlDownloadController: " & Message)
    End Sub
End Class
