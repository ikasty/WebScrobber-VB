Imports System.Threading
Imports System.IO
Imports System.Net

Public Class Mainform

    '// Notice 출력용 delegate 함수
    Private Delegate Sub DelegateSendNotice(ByVal Message As String)
    Private Notice As New DelegateSendNotice(AddressOf SendNotice)
    '// Finish 처리용 delegate 함수
    Private Delegate Sub DelegateFinishSave(ByVal KeepCount As Boolean)
    Private Finish As New DelegateFinishSave(AddressOf FinishSave)

    '//URL 관리 클래스
    Private urlDownloadController As UrlDownloadController = urlDownloadController.getSingleton()

    '// 소스 추가
    Private Sub AddSourceBtn_Click(sender As Object, e As EventArgs) Handles AddSourceBtn.Click
        Dim item As New ListViewItem
        'item.Tag = New SingleURL(GroupInput.Text, TitleInput.Text, UrlTypeController.UrlType.Unknown)
        item.Tag = New testClass("test1", "test2", item)
        item.Name = "test"
        'SourceInput.Items.Add(item)
        Log.Text = Log.Text + item.ToString
        SiteListView.Items.Add(item)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        For Each x As ListViewItem In SiteListView.Items
            DirectCast(x.Tag, testClass).testFunc()
        Next
    End Sub
    Class testClass
        Private a As String, b As String
        Private listviewItem As System.Windows.Forms.ListViewItem
        Public Sub New(_a As String, _b As String, ByRef item As ListViewItem)
            a = _a
            b = _b
            listviewItem = item
            item.Text = a
            Dim x As New ListViewItem.ListViewSubItem
            x.Name = "test"
            x.Text = b
            item.SubItems.Add(x)
            item.SubItems.Add(x)
        End Sub

        Public Sub testFunc()
            b = "newB"
            listviewItem.SubItems.Item("test").Text = b
        End Sub
    End Class

    '프로세스 시작
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        Dim newUrl As SingleURL
        '// group 텍스트 설정
        Dim Group = FileSystem.CleanFileName(Me.Group.Text)
        Dim GroupFormat As String = Group
        If (Group = "") Then Group = "단편"

        '// title 텍스트 설정
        Dim PostTitle As String = FileSystem.CleanFileName(Subchar.Text)
        Dim TitleCount As Integer = Me.TitleNumber.Value

        If (UseSourceUrl.Checked = True) Then
            For Each eachSource As String In Source.Text.Split(vbCrLf)
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

                newUrl = New SingleURL(Group, Title, eachSource)
                urlDownloadController.addSingleUrl(newUrl)
                TitleCount += 1
            Next
        Else
            newUrl = New SingleURL(Group, Group & " " & Format(TitleNumber.Value, getTitleFormat) & Subchar.Text, UrlTypeController.UrlType.Unknown)
            newUrl.Source = Source.Text
            urlDownloadController.addSingleUrl(newUrl)
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

    'Private Sub setImageSample(ByVal LastSuccessImage As String)
    '    Dim Sample As Bitmap

    '    If LastSuccessImage <> "" Then
    '        Sample = New Bitmap(LastSuccessImage)
    '        Dim width As Integer, height As Integer, rate As Single
    '        Try
    '            width = ImageSampleBox.Width
    '            height = ImageSampleBox.Height
    '            rate = Sample.Height / Sample.Width
    '            If height / width > rate Then
    '                height = rate * width
    '            Else
    '                width = height / rate
    '            End If

    '            ImageSampleBox.Image = Sample.GetThumbnailImage(width, height, Nothing, New IntPtr())
    '            Sample.Dispose()
    '        Catch ex As Exception

    '        End Try
    '    End If
    'End Sub

    '모든 처리가 완료되었을 때 외부 클래스에서 호출되는 함수
    '//Invoke가 필요한 경우 수행한다
    Public Sub FinishSave(Optional ByVal KeepCount As Boolean = False)
        If Me.InvokeRequired Then
            Me.Invoke(Finish, KeepCount)
            Exit Sub
        End If
        'If Not KeepCount Then Title.Value = Title.Value + 1

    End Sub

    '//소스 부분 더블클릭 시 데이터 리셋
    Private Sub Source_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Source.MouseDoubleClick
        Source.Text = ""
    End Sub

    '//타이틀 입력 후 엔터를 입력하는 경우 저장 버튼을 클릭시킨다
    Private Sub Title_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TitleNumber.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SaveBtn_Click(sender, e)
        End If
    End Sub

    Private Sub Value_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Group.TextChanged, TitleNumber.ValueChanged, Subchar.TextChanged, NumberCount.ValueChanged, TitleFormat.TextChanged
        Dim Format As String = ""
        For i = 1 To NumberCount.Value
            Format = Format & "0"
        Next
        Sample.Text = RenewSampleText(TitleFormat.Text, Group.Text, TitleNumber.Value, Format, Subchar.Text)
    End Sub

    Private Function RenewSampleText(ByVal TitleFormat As String, Group As String, Number As Integer, NumberFormat As String, Subchar As String) As String
        Dim Result = TitleFormat
        Result = Result.Replace("%G", Group)
        Result = Result.Replace("%n", Format(Number, NumberFormat))
        Result = Result.Replace("%s", Subchar)

        Return FileSystem.CleanFileName(Result)
    End Function

    Public ReadOnly Property getTitleFormat As String
        Get
            Dim x As String = ""
            For i = 1 To NumberCount.Value
                x = x & "0"
            Next
            Return x
        End Get
    End Property

    Private Sub Mainform_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Direction.Text = Environment.CurrentDirectory() + "\Manga"
        Deleted.Text = Environment.CurrentDirectory() + "\Deleted Manga"
    End Sub

End Class