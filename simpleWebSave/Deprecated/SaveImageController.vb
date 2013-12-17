Imports System.Threading
Imports System.IO
Imports System.Net

Public Class SaveImageController
    Private Mainform As Mainform

    '//이미지 링크를 포함하는 큐
    Private Queue As Queue(Of String)

    '//저장할 디렉토리
    Private Root As String, MovedRoot As String
    Private Directory As String

    '//저장 스레드 관련 변수
    Private DownThread() As Thread, ThreadCount As Integer

    '//현재 저장할 이미지 번호
    Private Page As Integer

    '//저장 결과 카운트
    Private SuccessCount As Integer, MoveCount As Integer, ErrorCount As Integer

    Public Sub New(ByRef Mainform As Mainform)
        Me.Mainform = Mainform
    End Sub

    '//컨트롤러의 기본 설정을 진행한다
    '//StartSave를 호출하기 전에 반드시 호출되어야 한다
    Public Sub SetController(ByVal Root As String, ByVal Deleted As String, ByVal Directory As String, ByRef Queue As Queue(Of String), ByVal ThreadCount As Integer)
        Me.Root = Root
        Me.MovedRoot = Deleted
        Me.Queue = Queue
        Me.Directory = Directory

        '//thread 설정
        Me.ThreadCount = ThreadCount
        ReDim DownThread(ThreadCount)
    End Sub

    '//저장 시작
    Public Sub StartSave(ByVal StartPage)
        Page = StartPage - 1

        '//스레드 시작
        For i As Integer = 1 To ThreadCount
            DownThread(i) = New Thread(AddressOf doSave)
            DownThread(i).Start()
        Next
    End Sub

    Private Function TryGetPage(ByRef Link As String, ByRef Name As String) As Boolean
        If Queue.Count = 0 Then Return False

        Monitor.Enter(Queue)
        Page += 1
        Link = Queue.Dequeue
        Name = Format(Page, "000") & ".jpg"
        Monitor.Exit(Queue)

        Return True
    End Function

    Private Sub doSave(ByVal i As Integer)
        Dim link As String = "", name As String = ""
        Dim xtest As FileInfo = Nothing, bmp As Bitmap = Nothing, ext As String, delete As Boolean = False
        Dim xDirectory As DirectoryInfo = Nothing

        Do
            If Not TryGetPage(link, name) Then Exit Do

            Try
                My.Computer.Network.DownloadFile(link, Root & Directory & name)
                xtest = New FileInfo(Root & Directory & name)
                bmp = New Bitmap(xtest.FullName)
                delete = False
                If bmp.Width < 150 Or bmp.Height < 200 Then
                    bmp.Dispose()
                    delete = True
                    '삭제 디렉토리가 존재하는지 체크
                    xDirectory = New DirectoryInfo(MovedRoot & Directory)
                    If (Not xDirectory.Exists()) Then
                        xDirectory.Create()
                    End If
                    xtest.MoveTo(MovedRoot & Directory & name)
                    bmp = New Bitmap(xtest.FullName)
                    MoveCount += 1
                End If

                ext = GetImageExt(bmp)
                If ext <> xtest.Extension Then
                    bmp.Dispose()
                    name = name.Replace(xtest.Extension, ext)
                    xtest.MoveTo(xtest.FullName.Replace(xtest.Extension, ext))
                    If ext = ".error" Then Throw New Exception(xtest.Name & " is not image")
                End If
                'status(i) = downStatus.success
                SuccessCount += 1

            Catch ex As System.Net.WebException
                Mainform.SendNotice("WebException Error " & name & ": " & link & " doesn't exists")
                'status(i) = downStatus.geterror
                ErrorCount += 1
            Catch ex As System.IO.IOException When delete = True
                Mainform.SendNotice("IOException Error " & MovedRoot & Directory & name & ": " & " exists")
                'status(i) = downStatus.geterror
                ErrorCount += 1
            Catch ex As System.IO.IOException
                Mainform.SendNotice("IOExeption Error " & name & ": file already exists")
                'status(i) = downStatus.geterror
                ErrorCount += 1
            Catch ex As Exception
                Mainform.SendNotice("Unknown Error " & name & ": " & ex.Message)
                'status(i) = downStatus.geterror
                ErrorCount += 1
            Finally
                '                FinishCount += 1
                If Not bmp Is Nothing Then
                    bmp.Dispose()
                End If
            End Try

        Loop

    End Sub

    Public ReadOnly Property isFinished As Boolean
        Get
            For i As Integer = 1 To ThreadCount
                If DownThread(i).IsAlive Then Return False
            Next
            Return True
        End Get
    End Property

    Public Sub clearCount()
        SuccessCount = 0
        ErrorCount = 0
        MoveCount = 0
    End Sub

    Private Sub ErrorControl(ByVal errorType As ErrObject, ByVal url As String, ByVal targetFilename As String)
        Dim xDirectory As DirectoryInfo

        xDirectory = New DirectoryInfo(MovedRoot & Directory)
        If (Not xDirectory.Exists()) Then
            xDirectory.Create()
        End If

        Dim xFile As New StreamWriter(MovedRoot & Directory & targetFilename & ".error.txt")

        xFile.WriteLine("Sorry for error! We cannot resolve this error.")
        xFile.WriteLine("URL: " & url)
        xFile.WriteLine("Error Information: " & vbCrLf)
        xFile.Write(errorType.ToString())

        xFile.Close()

        ErrorCount += 1
    End Sub
    'Public ReadOnly Property getLastSuccessImage As String
    '    Get
    '        For i As Integer = Index To 1 Step -1
    '            If status(i) = downStatus.success Then
    '                Return Directory & Name(i)
    '            End If
    '        Next
    '        Return ""
    '    End Get
    'End Property

    ' 저장한 이미지의 확장자를 구한다
    Private Function GetImageExt(ByVal Image As System.Drawing.Image) As String

        If Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg) Then
            Return ".jpg"
        ElseIf Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif) Then
            Return ".gif"
        ElseIf Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp) Then
            Return ".bmp"
        ElseIf Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff) Then
            Return ".tiff"
        ElseIf Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png) Then
            Return ".png"
        Else
            Return ".error"
        End If
    End Function

    Public ReadOnly Property getSuccessCount As Integer
        Get
            Return SuccessCount
        End Get
    End Property
    Public ReadOnly Property getMoveCount As Integer
        Get
            Return MoveCount
        End Get
    End Property
    Public ReadOnly Property getErrorCount As Integer
        Get
            Return ErrorCount
        End Get
    End Property

End Class