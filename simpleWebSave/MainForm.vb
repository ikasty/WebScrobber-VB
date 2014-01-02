Imports System.Threading
Imports System.IO
Imports System.Net

Public Class Mainform

    '// Notice 출력용 delegate 함수
    Private Delegate Sub SendNoticeCallback(ByVal Message As String)
    Private Notice As New SendNoticeCallback(AddressOf SendNotice)
    '// Finish 처리용 delegate 함수
    Private Delegate Sub FinishSaveCallback(ByVal KeepCount As Boolean)
    Private Finish As New FinishSaveCallback(AddressOf FinishSave)

    '// 소스 추가
    Private Sub AddSourceBtn_Click(sender As Object, e As EventArgs) Handles AddSourceBtn.Click
        Dim NewSingleUrl As SingleURL

        Dim Format As String = ""
        For i = 1 To NumberCount.Value
            Format = Format & "0"
        Next

        Dim Title As String = getTitleText(TitleFormat.Text, Group.Text, TitleNumber.Value, Format, Subchar.Text)
        NewSingleUrl = New SingleURL(Group.Text, Title, Url.Text, Directory.Text, ErrorDirectory.Text, useFirstUrlSource.Checked)
        UrlListController.getSingleton.addSingleUrl(NewSingleUrl)

        ' 입력 폼 초기화
        Url.Text = ""
        If KeepCount.Checked = False Then TitleNumber.Value += 1

    End Sub

    Private Sub ResetSourceBtn_Click(sender As Object, e As EventArgs) Handles ResetSourceBtn.Click
        Url.Text = ""
    End Sub

    '커맨드로 소스 추가
    Private Sub ExecuteBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteBtn.Click
        Dim newUrl As SingleURL
        '// group 텍스트 설정
        Dim Group = FileSystem.CleanFileName(Me.Group.Text)
        Dim GroupFormat As String = Group
        If (Group = "") Then Group = "단편"

        '// title 텍스트 설정
        Dim PostTitle As String = FileSystem.CleanFileName(Subchar.Text)
        Dim TitleCount As Integer = Me.TitleNumber.Value

        If (UseSourceUrl.Checked = True) Then
            For Each eachSource As String In Command.Text.Split(vbCrLf)
                '// 타이틀 특수지정(///)기호 처리
                Dim titleReplace As String = ""
                If eachSource.Contains("///") Then
                    titleReplace = Strings.Right(eachSource, eachSource.Length - eachSource.LastIndexOf("///") - 3)
                    eachSource = Strings.Left(eachSource, eachSource.LastIndexOf("///")).Trim()
                    TitleCount -= 1
                End If

                '// 타이틀 구하기
                Dim Title As String = ""
                '// 타이틀 재설정이 존재하면
                If (titleReplace <> "") Then
                    Try
                        '// 숫자로 시도
                        If (titleReplace.Contains(".")) Then
                            Title = GroupFormat & " " & Format(CDbl(titleReplace), getTitleFormat + ".0") & PostTitle
                        Else
                            Title = GroupFormat & " " & Format(CInt(titleReplace), getTitleFormat) & PostTitle
                        End If
                    Catch ex As Exception
                        '// 문자 처리
                        Title = GroupFormat & " " & titleReplace
                    End Try
                Else
                    '// 일반적인 숫자로 처리
                    Title = GroupFormat & " " & Format(TitleCount, getTitleFormat) & Subchar.Text
                End If

                newUrl = New SingleURL(Group, Title, eachSource, Directory.Text, ErrorDirectory.Text)
                UrlListController.getSingleton.addSingleUrl(newUrl)
                TitleCount += 1
            Next
        Else
            newUrl = New SingleURL(Group, Group & " " & Format(TitleNumber.Value, getTitleFormat) & Subchar.Text, Directory.Text, ErrorDirectory.Text, UrlTypeController.UrlType.Unknown)
            newUrl.Source = Command.Text
            UrlListController.getSingleton.addSingleUrl(newUrl)
        End If

        ''//DEPRECATED
        'GetImageUrl.Start(UseSourceUrl.Checked)
    End Sub

    'Notice 출력
    '//Invoke가 필요할 경우 수행한다
    Public Sub SendNotice(ByVal Message As String)
        If Me.InvokeRequired Then
            Me.Invoke(Notice, Message)
            Exit Sub
        End If

        Me.Log.AppendText(getTimeStamp & Message & vbCrLf)
    End Sub

    '//Notice 함수에서 사용하는 타임스탬프 프로퍼티
    Private ReadOnly Property getTimeStamp() As String
        Get
            Return "[" & Now.Hour.ToString("00") & ":" & Now.Minute.ToString("00") & ":" & Now.Second.ToString("00") & "] "
        End Get
    End Property

    '모든 처리가 완료되었을 때 외부 클래스에서 호출되는 함수
    '//Invoke가 필요한 경우 수행한다
    Public Sub FinishSave(Optional ByVal KeepCount As Boolean = False)
        If Me.InvokeRequired Then
            Me.Invoke(Finish, KeepCount)
            Exit Sub
        End If
        'If Not KeepCount Then Title.Value = Title.Value + 1

    End Sub

    '//타이틀 입력 후 엔터를 입력하는 경우 저장 버튼을 클릭시킨다
    Private Sub Source_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TitleNumber.KeyPress, Url.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            AddSourceBtn_Click(sender, e)
        End If
    End Sub

    Private Sub Value_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Group.TextChanged, TitleNumber.ValueChanged, Subchar.TextChanged, NumberCount.ValueChanged, TitleFormat.TextChanged
        Dim Format As String = ""
        For i = 1 To NumberCount.Value
            Format = Format & "0"
        Next
        Sample.Text = getTitleText(TitleFormat.Text, Group.Text, TitleNumber.Value, Format, Subchar.Text)
    End Sub

    Private Function getTitleText(ByVal TitleFormat As String, Group As String, Number As Integer, NumberFormat As String, Subchar As String) As String
        Dim Result = TitleFormat
        Result = Result.Replace("%G", Group)
        Result = Result.Replace("%n", Format(Number, NumberFormat))
        Result = Result.Replace("%s", Subchar)

        Return FileSystem.CleanFileName(Result)
    End Function

    ''' <summary>
    ''' Deprecated
    ''' </summary>
    Public ReadOnly Property getTitleFormat As String
        Get
            Dim x As String = ""
            For i = 1 To NumberCount.Value
                x = x & "0"
            Next
            Return x
        End Get
    End Property

    Private Sub StartCrawling_Click(sender As Object, e As EventArgs) Handles StartCrawling.Click
        UrlDownloadController.getSingleton.startTagThreads()
    End Sub

    '다운로드 실행
    Private Sub StartDownload_Click(sender As Object, e As EventArgs) Handles StartDownload.Click
        UrlDownloadController.getSingleton.startFileThread()
    End Sub

    ''' <summary>
    ''' Mainform의 SIngleton 객체입니다.
    ''' </summary>
    Private Shared singleton As Mainform
    ''' <summary>
    ''' Mainform의 Singleton 객체를 리턴합니다.
    ''' </summary>
    Public Shared Function getSingleton() As Mainform
        If singleton IsNot Nothing Then : Return singleton
        Else : Return Nothing
        End If
    End Function

    Public Sub New()
        InitializeComponent()

        'singleton 설정
        singleton = Me
    End Sub

    Private Sub Mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Directory.Text = Environment.CurrentDirectory() + "\Manga"
        ErrorDirectory.Text = Environment.CurrentDirectory() + "\Deleted Manga"

        UrlListController.getSingleton.setColumns()
    End Sub

    Private Sub SourceDeleteBtn_Click(sender As Object, e As EventArgs) Handles SourceDeleteBtn.Click
        SourceListView.SelectedItems(0).Tag.dispose()
        SourceListView.SelectedItems(0).Remove()
    End Sub

    Private Sub FinishedSourceDeleteBtn_Click(sender As Object, e As EventArgs) Handles FinishedSourceDeleteBtn.Click
        UrlListController.getSingleton.deleteFinishUrl()
    End Sub
End Class