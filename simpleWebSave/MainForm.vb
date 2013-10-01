Imports System.Threading
Imports System.IO
Imports System.Net

Public Class Mainform

    Private Delegate Sub DelegateSendNotice(ByVal Message As String)
    Private Notice As New DelegateSendNotice(AddressOf SendNotice)

    Private Delegate Sub DelegateImageSample(ByVal LastSuccessImage As String)
    Private ImageSample As New DelegateImageSample(AddressOf setImageSample)

    Private Delegate Sub DelegateFinishSave(ByVal KeepCount As Boolean)
    Private Finish As New DelegateFinishSave(AddressOf FinishSave)

    Private LastSuccessImage As String

    '//이미지 URL을 구하는 클래스. 실질적으로 모든 작업을 처리한다
    Private GetImageUrl As New GetImageUrl(Me)


    '프로세스 시작
    Private Sub SaveBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBtn.Click
        GetImageUrl.Start(UseSourceUrl.Checked)
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

    Private Sub setImageSample(ByVal LastSuccessImage As String)
        Dim Sample As Bitmap

        If LastSuccessImage <> "" Then
            Sample = New Bitmap(LastSuccessImage)
            Dim width As Integer, height As Integer, rate As Single
            Try
                width = ImageSampleBox.Width
                height = ImageSampleBox.Height
                rate = Sample.Height / Sample.Width
                If height / width > rate Then
                    height = rate * width
                Else
                    width = height / rate
                End If

                ImageSampleBox.Image = Sample.GetThumbnailImage(width, height, Nothing, New IntPtr())
                Sample.Dispose()
            Catch ex As Exception

            End Try
        End If
    End Sub

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
    Private Sub Title_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Title.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            SaveBtn_Click(sender, e)
        End If
    End Sub

    Private Sub Group_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Group.TextChanged, Title.ValueChanged, Subchar.TextChanged
        Dim GroupText = Group.Text
        If GroupText = "" Then GroupText = "단편"
        Sample.Text = GroupText & " " & Format(Title.Value, TitleFormat) & Subchar.Text

    End Sub

    Public ReadOnly Property TitleFormat As String
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