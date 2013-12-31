Imports System.Threading

' 다운받을 Url 목록을 관리하는 클래스
' Singleton 패턴을 사용하여 UrlDownloadController.getSingleton()으로 객체를 얻어와야 한다.
Public NotInheritable Class UrlDownloadController

    ' 이 클래스의 Singleton
    Private Shared Singleton As UrlDownloadController
    ' Singleton을 리턴해주는 함수
    ' @return UrlDownloadController
    Public Shared Function getSingleton() As UrlDownloadController
        If Singleton Is Nothing Then Singleton = New UrlDownloadController
        Return Singleton
    End Function

    ' url로부터 이미지 태그를 받아옴
    Private getTagThreads() As Thread
    ' 이미지 태그로부터 파일을 받아옴
    Private getImageThread As Thread

    ' 태그 수집 사용여부
    Private runningTagThreads As Boolean = False
    ' 이미지 다운로드 사용여부
    Private runningImageThread As Boolean = False

    ' 생성자
    Private Sub New()
    End Sub

    ' URL로부터 이미지 태그를 인식해옴
    Private Sub getTagFromUrl()
        Dim StartPos As Integer, FinishPos As Integer
        Dim Link As String = ""

        While (runningTagThreads)
            Dim singleUrl As SingleURL = UrlListController.getSingleton.getSingleUrl()
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

            ' 인식 완료. 다운로드 리스트에 추가함
            addUrl(singleUrl)

        End While
    End Sub

    Private Shared urlDownloadList As New Queue(Of SingleURL)
    Private Shared Sub addUrl(ByRef singleUrl As SingleURL)
        SyncLock urlDownloadList
            urlDownloadList.Enqueue(singleUrl)
        End SyncLock
    End Sub
    Private Shared Function getUrl() As SingleURL
        Dim ReturnUrl As SingleURL
        SyncLock urlDownloadList
            If urlDownloadList.Count = 0 Then
                ReturnUrl = Nothing
            Else
                ReturnUrl = urlDownloadList.Dequeue()
            End If
        End SyncLock

        Return ReturnUrl
    End Function

    ' 준비된 이미지 리스트를 다운받음
    Private Sub getImageFileFromSource()
        While (runningImageThread)
            Dim TargetUrl As SingleURL = getUrl()
            If TargetUrl Is Nothing Then Exit While

            Dim index As Integer = 0
            Dim directory As String = TargetUrl.Directory & "\" & TargetUrl.Group & "\" & TargetUrl.Title
            Dim errdirectory As String = TargetUrl.ErrDir & "\" & TargetUrl.Group & "\" & TargetUrl.Title

            While Not TargetUrl.isEmptyImage And runningImageThread
                Dim URL As String = TargetUrl.getNextImage
                Dim Filename As String = Format(index, "000\.dummy")
                index += 1

                If (Not HtmlController.getFile.getImage(URL, directory & "\" & Filename, HtmlController.getFile.Options.AUTO_CREATE_DIR, AddressOf Mainform.SendNotice)) Then
                    TargetUrl.addErrorImage(New SingleURL.ErrorImage(URL, Filename))
                End If
            End While

        End While

    End Sub

    Public Sub startTagThreads()
        runningTagThreads = True
        Dim totalImageTagThreads As Integer

        totalImageTagThreads = Environment.ProcessorCount - 1
        If totalImageTagThreads > 5 Then totalImageTagThreads = 5

        ReDim getTagThreads(totalImageTagThreads)
        For i As Integer = 0 To totalImageTagThreads
            getTagThreads(i) = New Thread(AddressOf getTagFromUrl)
            getTagThreads(i).Name = "TagFromUrl_#" & i
            getTagThreads(i).Start()
        Next
    End Sub

    Public Sub startFileThread()
        runningImageThread = True
        getImageThread = New Thread(AddressOf getImageFileFromSource)
        getImageThread.Start()
    End Sub

    Private Shared Sub Notice(ByVal Message As String)
        Mainform.SendNotice("UrlDownloadController: " & Message)
    End Sub
End Class
