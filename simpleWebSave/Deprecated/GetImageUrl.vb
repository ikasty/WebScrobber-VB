Imports System.Threading

Public Class GetImageUrl
    Private Mainform As Mainform

    '//출력 델리게이트 함수
    '//form.SendNotice -> SendNotice
    Public Delegate Sub DelegateSendNotice(ByVal Message As String)
    Private SendNotice As DelegateSendNotice

    '//스레드
    Private MainThread As Thread

    '//메인 폼에 저장되어 있던 소스 텍스트
    Private FormSource As String

    '//저장 폴더 루트
    Private Root As String, Deleted As String
    '//저장 그룹과 타이틀, 타이틀 포맷, 타이틀 후첨자 설정
    Private Groupname As String, Title As Integer, TitleFormat As String, PostTitle As String
    '//게시물 카운트 유지 관련 설정들
    Private KeepCount As Boolean, SavedGroup As String, SavedPage As Integer

    '//이미지 저장 컨트롤러
    Private ImageController As SaveImageController


    '//각 URL에서 소스를 구하는 클래스
    Private GetSource As GetHtmlSource

    Public Sub New(ByRef Mainform As Mainform)
        Me.Mainform = Mainform

        '//출력 델리게이트 함수 설정
        SendNotice = New DelegateSendNotice(AddressOf Mainform.SendNotice)

        '//URL으로부터 소스를 구하는 클래스 설정
        GetSource = New GetHtmlSource(Mainform, SendNotice)

        '//이미지 저장 컨트롤러 클래스 설정
        ImageController = New SaveImageController(Mainform)
    End Sub

    '//스레드를 시작시킴
    Public Sub Start(Optional ByVal isUseUrl As Boolean = True)
        If (MainThread IsNot Nothing) Then
            If (MainThread.IsAlive) Then SendNotice("Warning: 아직 실행중입니다. 현재 실행에 대한 제어권을 잃습니다.")
        End If

        '//메인 스레드 설정
        MainThread = New Thread(AddressOf ThreadStart)

        '//form에서 필요한 텍스트들을 구한다
        FormSource = Mainform.Source.Text

        Root = Mainform.Direction.Text
        Deleted = Mainform.Deleted.Text
        Groupname = DelChar(Mainform.Group.Text)
        Title = Mainform.Title.Value
        PostTitle = DelChar(Mainform.Subchar.Text)
        TitleFormat = Mainform.TitleFormat

        If (Mainform.KeepCount.Checked = True) Then KeepCount = True Else KeepCount = False

        '루트 폴더명 체크
        If Root = "" Then
            SendNotice("Error: Directory is missing")
            Exit Sub
        End If
        If Not Root.EndsWith("\") Then
            Root = Root & "\"
        End If
        If Deleted = "" Then
            SendNotice("Error: Directory is missing")
            Exit Sub
        End If
        If Not Deleted.EndsWith("\") Then
            Deleted = Deleted & "\"
        End If

        '그룹명/타이틀명 체크
        'If Groupname = "" Then
        '    SendNotice("Error: Group is missing")
        '    Exit Sub
        'End If

        '//스레드 시작
        MainThread.Start(isUseUrl)
    End Sub

    '//스레드 본편
    '//html 주소를 분리하고, 소스를 얻는다
    Private Sub ThreadStart(ByVal isUseUrl As Boolean)
        Dim Name As String = "", TargetFolder As String, Directory As String
        Dim listSource(0) As String
        Dim titleReplace As String
        Dim URL As New DetectURL(Mainform)

        '소스가 주소라면 줄마다 배열에 추가
        If isUseUrl Then
            listSource = FormSource.Trim.Split(vbCrLf)
        Else    '소스가 html 소스라면 해당 소스를 0번째에 추가
            listSource(0) = FormSource
        End If

        '//이제 각 소스마다 이미지 url을 구한다
        For Each eachSource As String In listSource
            titleReplace = ""
            '//만약 빈 줄이라면 다음 줄로 넘어감
            If eachSource = "" Then Continue For

            If isUseUrl Then
                '//Url이면 우선 혹시 있는 주석을 제거한 뒤
                If eachSource.Contains("///") Then
                    titleReplace = Right(eachSource, eachSource.Length - eachSource.LastIndexOf("///") - 3)
                    eachSource = Left(eachSource, eachSource.LastIndexOf("///")).Trim()
                End If

                '// 타입을 Detect한 다음 해당 Url로부터 소스를 가져온다
                URL.SetUrl(eachSource)
                eachSource = GetSource.GetUrlSource(URL)
            Else
                '//일반 소스이면 기본 설정된 타입을 사용한다
                URL.DetectDefaultUrlType()
            End If

            '타겟 폴더 이름과 전체 디렉토리 경로 구하기
            Dim preDirectory = ""
            If (Groupname = "") Then preDirectory = "단편"
            TargetFolder = Groupname & " " & Format(Title, TitleFormat) & PostTitle
            If (titleReplace <> "") Then
                Try
                    If (titleReplace.Contains(".")) Then
                        TargetFolder = Groupname & " " & Format(CDbl(titleReplace), TitleFormat + ".0") & PostTitle
                    Else
                        TargetFolder = Groupname & " " & Format(CInt(titleReplace), TitleFormat) & PostTitle
                    End If
                Catch ex As Exception
                    TargetFolder = Groupname & " " & titleReplace
                End Try
                Title = Title - 1
            End If
            Directory = Groupname & preDirectory & "\" & TargetFolder & "\"

            SendNotice("Start Scan: " & TargetFolder)

            GetImageLink(TargetFolder, Directory, eachSource)

            '//form에 완료했음을 알림
            Mainform.FinishSave()
            SendNotice("----------------Scan Finish: " & TargetFolder & "---------------")
            '//타이틀 증가
            Title = Title + 1
        Next

    End Sub

    '//이미지 링크를 실제로 구하는 프로세스
    '//주어진 소스에 있는 모든 이미지 링크를 주어진 타겟 폴더의 파일과 일대일로 매칭시킨다
    Private Sub GetImageLink(ByVal TargetFolder As String, ByVal Directory As String, ByVal OriginalSource As String)
        Dim StartPos As Integer, FinishPos As Integer
        Dim MinimumSource As String
        Dim Link As String = ""

        Dim Page As Integer = 1

        Dim queue As New Queue(Of String)

        '시작 페이지 설정
        If KeepCount Then
            If SavedGroup = "" Then
                SavedGroup = Groupname
                Page = SavedPage
            ElseIf SavedGroup = Groupname Then
                Page = SavedPage
            Else
                SavedGroup = Groupname
                SavedPage = 0
            End If
        Else
            SavedGroup = ""
            SavedPage = 0
        End If

        '//초기화
        StartPos = 1
        FinishPos = 1
        MinimumSource = OriginalSource.ToLower

        '//모든 <img>태그를 찾아서, src 옵션 값을 읽는다
        Do
            StartPos = InStr(StartPos, MinimumSource, "<img") + "<img".Length
            If StartPos < 5 Then Exit Do
            StartPos = InStr(StartPos, MinimumSource, "src=""") + "src=""".Length
            If StartPos < 6 Then Exit Do

            FinishPos = InStr(StartPos, MinimumSource, """")

            Link = Mid(OriginalSource, StartPos, FinishPos - StartPos)
            queue.Enqueue(Link)
        Loop

        '//이제 구한 링크들을 이미지 저장 컨트롤러에 전달한다
        ImageController.SetController(Root, Deleted, Directory, queue, 3)
        ImageController.StartSave(Page)

        While Not ImageController.isFinished
            Thread.Sleep(100)
        End While

        If KeepCount Then SavedPage = Page

        SendNotice("""" & TargetFolder & """ success: " & ImageController.getSuccessCount & " page(s) save success.")
        If ImageController.getMoveCount > 0 Then SendNotice("MOVE " & ImageController.getMoveCount & " page(s).")
        If ImageController.getErrorCount > 0 Then SendNotice("ERROR: " & ImageController.getErrorCount & " page(s).")

    End Sub

    '=====================================
    '//기타 작은 서브루틴들

    '//문자열에서 폴더에 사용할 수 없는 문자를 제거하거나 대체한다
    Public Function DelChar(ByVal x As String) As String
        x = x.Replace("/", "")
        x = x.Replace("\", "")
        x = x.Replace("?", "？")
        x = x.Replace("%", "")
        x = x.Replace("*", "")
        x = x.Replace(":", "")
        x = x.Replace("|", "")
        x = x.Replace("""", "")
        x = x.Replace("<", "")
        x = x.Replace(">", "")

        x = x.Trim(" ")
        x = x.Trim()

        Return x
    End Function

End Class
