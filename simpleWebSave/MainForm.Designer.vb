<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mainform
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Source = New System.Windows.Forms.TextBox()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.Log = New System.Windows.Forms.TextBox()
        Me.SettingBox = New System.Windows.Forms.GroupBox()
        Me.Deleted = New System.Windows.Forms.TextBox()
        Me.DeletedLabel = New System.Windows.Forms.Label()
        Me.NumberCountLabel = New System.Windows.Forms.Label()
        Me.NumberCount = New System.Windows.Forms.NumericUpDown()
        Me.SampleLabel = New System.Windows.Forms.Label()
        Me.Sample = New System.Windows.Forms.TextBox()
        Me.KeepCount = New System.Windows.Forms.CheckBox()
        Me.Subchar = New System.Windows.Forms.TextBox()
        Me.SubcharLabel = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.NumericUpDown()
        Me.DirectionLabel = New System.Windows.Forms.Label()
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GroupLabel = New System.Windows.Forms.Label()
        Me.Group = New System.Windows.Forms.TextBox()
        Me.Direction = New System.Windows.Forms.TextBox()
        Me.SourceSettingBox = New System.Windows.Forms.GroupBox()
        Me.useFirstUrlSource = New System.Windows.Forms.CheckBox()
        Me.SourceFC2 = New System.Windows.Forms.RadioButton()
        Me.UseSourceUrl = New System.Windows.Forms.CheckBox()
        Me.SourceEgloos = New System.Windows.Forms.RadioButton()
        Me.SourceWordpress = New System.Windows.Forms.RadioButton()
        Me.SourceTistory = New System.Windows.Forms.RadioButton()
        Me.SourceTumbler = New System.Windows.Forms.RadioButton()
        Me.SourceDefault = New System.Windows.Forms.RadioButton()
        Me.SourceNaver = New System.Windows.Forms.RadioButton()
        Me.ImageSampleBox = New System.Windows.Forms.PictureBox()
        Me.InfoBox = New System.Windows.Forms.GroupBox()
        Me.Info = New System.Windows.Forms.TextBox()
        Me.OptionBox = New System.Windows.Forms.GroupBox()
        Me.AutoSourceBox = New System.Windows.Forms.GroupBox()
        Me.AutoSourceUseLabel = New System.Windows.Forms.CheckBox()
        Me.AutoSourceCountLabel = New System.Windows.Forms.Label()
        Me.AutoSourceCount = New System.Windows.Forms.NumericUpDown()
        Me.AutoSourceTimeReverse = New System.Windows.Forms.CheckBox()
        Me.GetAutoSourceUrl = New System.Windows.Forms.Button()
        Me.AutoSourceUrlLabel = New System.Windows.Forms.Label()
        Me.AutoSourceUrl = New System.Windows.Forms.TextBox()
        Me.LoginBox = New System.Windows.Forms.GroupBox()
        Me.LoginList = New System.Windows.Forms.ListView()
        Me.Sites = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PWD = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.URL = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SourceBox = New System.Windows.Forms.GroupBox()
        Me.ResultBox = New System.Windows.Forms.GroupBox()
        Me.SettingBox.SuspendLayout()
        CType(Me.NumberCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SourceSettingBox.SuspendLayout()
        CType(Me.ImageSampleBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InfoBox.SuspendLayout()
        Me.OptionBox.SuspendLayout()
        Me.AutoSourceBox.SuspendLayout()
        CType(Me.AutoSourceCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LoginBox.SuspendLayout()
        Me.SourceBox.SuspendLayout()
        Me.ResultBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Source
        '
        Me.Source.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Source.Location = New System.Drawing.Point(6, 23)
        Me.Source.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Source.MaxLength = 1024768
        Me.Source.Multiline = True
        Me.Source.Name = "Source"
        Me.Source.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Source.Size = New System.Drawing.Size(510, 124)
        Me.Source.TabIndex = 0
        '
        'SaveBtn
        '
        Me.SaveBtn.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(774, 13)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(134, 153)
        Me.SaveBtn.TabIndex = 1
        Me.SaveBtn.Text = "실행"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Log.Location = New System.Drawing.Point(6, 23)
        Me.Log.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Log.MaxLength = 1024768
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Log.Size = New System.Drawing.Size(510, 251)
        Me.Log.TabIndex = 7
        '
        'SettingBox
        '
        Me.SettingBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SettingBox.Controls.Add(Me.Deleted)
        Me.SettingBox.Controls.Add(Me.DeletedLabel)
        Me.SettingBox.Controls.Add(Me.NumberCountLabel)
        Me.SettingBox.Controls.Add(Me.NumberCount)
        Me.SettingBox.Controls.Add(Me.SampleLabel)
        Me.SettingBox.Controls.Add(Me.Sample)
        Me.SettingBox.Controls.Add(Me.KeepCount)
        Me.SettingBox.Controls.Add(Me.Subchar)
        Me.SettingBox.Controls.Add(Me.SubcharLabel)
        Me.SettingBox.Controls.Add(Me.Title)
        Me.SettingBox.Controls.Add(Me.DirectionLabel)
        Me.SettingBox.Controls.Add(Me.TitleLabel)
        Me.SettingBox.Controls.Add(Me.GroupLabel)
        Me.SettingBox.Controls.Add(Me.Group)
        Me.SettingBox.Controls.Add(Me.Direction)
        Me.SettingBox.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SettingBox.Location = New System.Drawing.Point(12, 460)
        Me.SettingBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SettingBox.Name = "SettingBox"
        Me.SettingBox.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SettingBox.Size = New System.Drawing.Size(522, 167)
        Me.SettingBox.TabIndex = 14
        Me.SettingBox.TabStop = False
        Me.SettingBox.Text = "기본 설정"
        '
        'Deleted
        '
        Me.Deleted.Location = New System.Drawing.Point(69, 123)
        Me.Deleted.Name = "Deleted"
        Me.Deleted.Size = New System.Drawing.Size(396, 27)
        Me.Deleted.TabIndex = 28
        '
        'DeletedLabel
        '
        Me.DeletedLabel.AutoSize = True
        Me.DeletedLabel.Location = New System.Drawing.Point(6, 123)
        Me.DeletedLabel.Name = "DeletedLabel"
        Me.DeletedLabel.Size = New System.Drawing.Size(74, 20)
        Me.DeletedLabel.TabIndex = 27
        Me.DeletedLabel.Text = "삭제 폴더"
        '
        'NumberCountLabel
        '
        Me.NumberCountLabel.AutoSize = True
        Me.NumberCountLabel.Location = New System.Drawing.Point(422, 64)
        Me.NumberCountLabel.Name = "NumberCountLabel"
        Me.NumberCountLabel.Size = New System.Drawing.Size(54, 20)
        Me.NumberCountLabel.TabIndex = 26
        Me.NumberCountLabel.Text = "자리수"
        '
        'NumberCount
        '
        Me.NumberCount.Location = New System.Drawing.Point(471, 63)
        Me.NumberCount.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumberCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberCount.Name = "NumberCount"
        Me.NumberCount.Size = New System.Drawing.Size(35, 27)
        Me.NumberCount.TabIndex = 25
        Me.NumberCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'SampleLabel
        '
        Me.SampleLabel.AutoSize = True
        Me.SampleLabel.Location = New System.Drawing.Point(8, 95)
        Me.SampleLabel.Name = "SampleLabel"
        Me.SampleLabel.Size = New System.Drawing.Size(69, 20)
        Me.SampleLabel.TabIndex = 24
        Me.SampleLabel.Text = "미리보기"
        '
        'Sample
        '
        Me.Sample.Location = New System.Drawing.Point(69, 92)
        Me.Sample.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sample.Name = "Sample"
        Me.Sample.ReadOnly = True
        Me.Sample.Size = New System.Drawing.Size(347, 27)
        Me.Sample.TabIndex = 23
        '
        'KeepCount
        '
        Me.KeepCount.AutoSize = True
        Me.KeepCount.Location = New System.Drawing.Point(422, 94)
        Me.KeepCount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeepCount.Name = "KeepCount"
        Me.KeepCount.Size = New System.Drawing.Size(96, 24)
        Me.KeepCount.TabIndex = 22
        Me.KeepCount.Text = "화수 유지"
        Me.KeepCount.UseVisualStyleBackColor = True
        '
        'Subchar
        '
        Me.Subchar.Location = New System.Drawing.Point(374, 61)
        Me.Subchar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Subchar.Name = "Subchar"
        Me.Subchar.Size = New System.Drawing.Size(42, 27)
        Me.Subchar.TabIndex = 21
        Me.Subchar.Text = "화"
        '
        'SubcharLabel
        '
        Me.SubcharLabel.AutoSize = True
        Me.SubcharLabel.Location = New System.Drawing.Point(337, 65)
        Me.SubcharLabel.Name = "SubcharLabel"
        Me.SubcharLabel.Size = New System.Drawing.Size(39, 20)
        Me.SubcharLabel.TabIndex = 20
        Me.SubcharLabel.Text = "단위"
        '
        'Title
        '
        Me.Title.Location = New System.Drawing.Point(279, 61)
        Me.Title.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Title.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(52, 27)
        Me.Title.TabIndex = 19
        '
        'DirectionLabel
        '
        Me.DirectionLabel.AutoSize = True
        Me.DirectionLabel.Location = New System.Drawing.Point(6, 29)
        Me.DirectionLabel.Name = "DirectionLabel"
        Me.DirectionLabel.Size = New System.Drawing.Size(74, 20)
        Me.DirectionLabel.TabIndex = 18
        Me.DirectionLabel.Text = "메인 폴더"
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(242, 65)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(39, 20)
        Me.TitleLabel.TabIndex = 16
        Me.TitleLabel.Text = "화수"
        '
        'GroupLabel
        '
        Me.GroupLabel.AutoSize = True
        Me.GroupLabel.Location = New System.Drawing.Point(20, 65)
        Me.GroupLabel.Name = "GroupLabel"
        Me.GroupLabel.Size = New System.Drawing.Size(54, 20)
        Me.GroupLabel.TabIndex = 15
        Me.GroupLabel.Text = "폴더명"
        '
        'Group
        '
        Me.Group.Location = New System.Drawing.Point(69, 61)
        Me.Group.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(167, 27)
        Me.Group.TabIndex = 17
        '
        'Direction
        '
        Me.Direction.Location = New System.Drawing.Point(69, 25)
        Me.Direction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Direction.Name = "Direction"
        Me.Direction.Size = New System.Drawing.Size(396, 27)
        Me.Direction.TabIndex = 14
        Me.Direction.Text = "F:\Manga Scraps"
        '
        'SourceSettingBox
        '
        Me.SourceSettingBox.Controls.Add(Me.useFirstUrlSource)
        Me.SourceSettingBox.Controls.Add(Me.SourceFC2)
        Me.SourceSettingBox.Controls.Add(Me.UseSourceUrl)
        Me.SourceSettingBox.Controls.Add(Me.SourceEgloos)
        Me.SourceSettingBox.Controls.Add(Me.SourceWordpress)
        Me.SourceSettingBox.Controls.Add(Me.SourceTistory)
        Me.SourceSettingBox.Controls.Add(Me.SourceTumbler)
        Me.SourceSettingBox.Controls.Add(Me.SourceDefault)
        Me.SourceSettingBox.Controls.Add(Me.SourceNaver)
        Me.SourceSettingBox.Location = New System.Drawing.Point(540, 12)
        Me.SourceSettingBox.Name = "SourceSettingBox"
        Me.SourceSettingBox.Size = New System.Drawing.Size(228, 154)
        Me.SourceSettingBox.TabIndex = 16
        Me.SourceSettingBox.TabStop = False
        Me.SourceSettingBox.Text = "소스 설정"
        '
        'useFirstUrlSource
        '
        Me.useFirstUrlSource.AutoSize = True
        Me.useFirstUrlSource.Location = New System.Drawing.Point(6, 122)
        Me.useFirstUrlSource.Name = "useFirstUrlSource"
        Me.useFirstUrlSource.Size = New System.Drawing.Size(228, 24)
        Me.useFirstUrlSource.TabIndex = 27
        Me.useFirstUrlSource.Text = "본문의 첫 URL을 소스로 사용"
        Me.useFirstUrlSource.UseVisualStyleBackColor = True
        '
        'SourceFC2
        '
        Me.SourceFC2.AutoSize = True
        Me.SourceFC2.Location = New System.Drawing.Point(61, 22)
        Me.SourceFC2.Name = "SourceFC2"
        Me.SourceFC2.Size = New System.Drawing.Size(55, 24)
        Me.SourceFC2.TabIndex = 26
        Me.SourceFC2.Text = "FC2"
        Me.SourceFC2.UseVisualStyleBackColor = True
        '
        'UseSourceUrl
        '
        Me.UseSourceUrl.AutoSize = True
        Me.UseSourceUrl.Checked = True
        Me.UseSourceUrl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UseSourceUrl.Location = New System.Drawing.Point(6, 97)
        Me.UseSourceUrl.Name = "UseSourceUrl"
        Me.UseSourceUrl.Size = New System.Drawing.Size(261, 24)
        Me.UseSourceUrl.TabIndex = 25
        Me.UseSourceUrl.Text = "소스 코드를 웹사이트 주소로 사용"
        Me.UseSourceUrl.UseVisualStyleBackColor = True
        '
        'SourceEgloos
        '
        Me.SourceEgloos.AutoSize = True
        Me.SourceEgloos.Location = New System.Drawing.Point(6, 72)
        Me.SourceEgloos.Name = "SourceEgloos"
        Me.SourceEgloos.Size = New System.Drawing.Size(90, 24)
        Me.SourceEgloos.TabIndex = 24
        Me.SourceEgloos.Text = "이글루스"
        Me.SourceEgloos.UseVisualStyleBackColor = True
        '
        'SourceWordpress
        '
        Me.SourceWordpress.AutoSize = True
        Me.SourceWordpress.Location = New System.Drawing.Point(85, 72)
        Me.SourceWordpress.Name = "SourceWordpress"
        Me.SourceWordpress.Size = New System.Drawing.Size(105, 24)
        Me.SourceWordpress.TabIndex = 23
        Me.SourceWordpress.Text = "워드프레스"
        Me.SourceWordpress.UseVisualStyleBackColor = True
        '
        'SourceTistory
        '
        Me.SourceTistory.AutoSize = True
        Me.SourceTistory.Location = New System.Drawing.Point(140, 47)
        Me.SourceTistory.Name = "SourceTistory"
        Me.SourceTistory.Size = New System.Drawing.Size(90, 24)
        Me.SourceTistory.TabIndex = 22
        Me.SourceTistory.Text = "티스토리"
        Me.SourceTistory.UseVisualStyleBackColor = True
        '
        'SourceTumbler
        '
        Me.SourceTumbler.AutoSize = True
        Me.SourceTumbler.Location = New System.Drawing.Point(73, 47)
        Me.SourceTumbler.Name = "SourceTumbler"
        Me.SourceTumbler.Size = New System.Drawing.Size(75, 24)
        Me.SourceTumbler.TabIndex = 21
        Me.SourceTumbler.Text = "텀블러"
        Me.SourceTumbler.UseVisualStyleBackColor = True
        '
        'SourceDefault
        '
        Me.SourceDefault.AutoSize = True
        Me.SourceDefault.Checked = True
        Me.SourceDefault.Location = New System.Drawing.Point(6, 22)
        Me.SourceDefault.Name = "SourceDefault"
        Me.SourceDefault.Size = New System.Drawing.Size(60, 24)
        Me.SourceDefault.TabIndex = 1
        Me.SourceDefault.TabStop = True
        Me.SourceDefault.Text = "자동"
        Me.SourceDefault.UseVisualStyleBackColor = True
        '
        'SourceNaver
        '
        Me.SourceNaver.AutoSize = True
        Me.SourceNaver.Location = New System.Drawing.Point(6, 47)
        Me.SourceNaver.Name = "SourceNaver"
        Me.SourceNaver.Size = New System.Drawing.Size(75, 24)
        Me.SourceNaver.TabIndex = 0
        Me.SourceNaver.Text = "네이버"
        Me.SourceNaver.UseVisualStyleBackColor = True
        '
        'ImageSampleBox
        '
        Me.ImageSampleBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ImageSampleBox.Location = New System.Drawing.Point(543, 172)
        Me.ImageSampleBox.Name = "ImageSampleBox"
        Me.ImageSampleBox.Size = New System.Drawing.Size(365, 281)
        Me.ImageSampleBox.TabIndex = 17
        Me.ImageSampleBox.TabStop = False
        '
        'InfoBox
        '
        Me.InfoBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InfoBox.Controls.Add(Me.Info)
        Me.InfoBox.Location = New System.Drawing.Point(540, 460)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(368, 167)
        Me.InfoBox.TabIndex = 19
        Me.InfoBox.TabStop = False
        Me.InfoBox.Text = "정보"
        '
        'Info
        '
        Me.Info.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Info.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Info.Location = New System.Drawing.Point(6, 22)
        Me.Info.Multiline = True
        Me.Info.Name = "Info"
        Me.Info.ReadOnly = True
        Me.Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Info.Size = New System.Drawing.Size(356, 139)
        Me.Info.TabIndex = 0
        Me.Info.Text = "이 프로그램의 사용상의 법적 책임은 사용자에게 있습니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "웹 상의 이미지를 쉽게 저장해 정리해주는 프로그램입니다. 만화 등을 긁어올 때 유용" & _
            "하게 사용됩니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "사이트의 주소를 한 줄에 하나씩 입력하거나, 또는 HTML 소스를 복사해 붙여넣으면 됩니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "버전 4.3"
        '
        'OptionBox
        '
        Me.OptionBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OptionBox.Controls.Add(Me.AutoSourceBox)
        Me.OptionBox.Controls.Add(Me.LoginBox)
        Me.OptionBox.Location = New System.Drawing.Point(914, 12)
        Me.OptionBox.Name = "OptionBox"
        Me.OptionBox.Size = New System.Drawing.Size(358, 324)
        Me.OptionBox.TabIndex = 20
        Me.OptionBox.TabStop = False
        Me.OptionBox.Text = "특수 기능"
        '
        'AutoSourceBox
        '
        Me.AutoSourceBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AutoSourceBox.Controls.Add(Me.AutoSourceUseLabel)
        Me.AutoSourceBox.Controls.Add(Me.AutoSourceCountLabel)
        Me.AutoSourceBox.Controls.Add(Me.AutoSourceCount)
        Me.AutoSourceBox.Controls.Add(Me.AutoSourceTimeReverse)
        Me.AutoSourceBox.Controls.Add(Me.GetAutoSourceUrl)
        Me.AutoSourceBox.Controls.Add(Me.AutoSourceUrlLabel)
        Me.AutoSourceBox.Controls.Add(Me.AutoSourceUrl)
        Me.AutoSourceBox.Location = New System.Drawing.Point(9, 181)
        Me.AutoSourceBox.Name = "AutoSourceBox"
        Me.AutoSourceBox.Size = New System.Drawing.Size(343, 115)
        Me.AutoSourceBox.TabIndex = 23
        Me.AutoSourceBox.TabStop = False
        Me.AutoSourceBox.Text = "소스 자동 채우기"
        '
        'AutoSourceUseLabel
        '
        Me.AutoSourceUseLabel.AutoSize = True
        Me.AutoSourceUseLabel.Checked = True
        Me.AutoSourceUseLabel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoSourceUseLabel.Location = New System.Drawing.Point(194, 81)
        Me.AutoSourceUseLabel.Name = "AutoSourceUseLabel"
        Me.AutoSourceUseLabel.Size = New System.Drawing.Size(96, 24)
        Me.AutoSourceUseLabel.TabIndex = 22
        Me.AutoSourceUseLabel.Text = "주석 사용"
        Me.AutoSourceUseLabel.UseVisualStyleBackColor = True
        '
        'AutoSourceCountLabel
        '
        Me.AutoSourceCountLabel.AutoSize = True
        Me.AutoSourceCountLabel.Location = New System.Drawing.Point(6, 82)
        Me.AutoSourceCountLabel.Name = "AutoSourceCountLabel"
        Me.AutoSourceCountLabel.Size = New System.Drawing.Size(106, 20)
        Me.AutoSourceCountLabel.TabIndex = 5
        Me.AutoSourceCountLabel.Text = "가져올 URL 수"
        '
        'AutoSourceCount
        '
        Me.AutoSourceCount.Location = New System.Drawing.Point(96, 80)
        Me.AutoSourceCount.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.AutoSourceCount.Name = "AutoSourceCount"
        Me.AutoSourceCount.Size = New System.Drawing.Size(92, 27)
        Me.AutoSourceCount.TabIndex = 4
        '
        'AutoSourceTimeReverse
        '
        Me.AutoSourceTimeReverse.AutoSize = True
        Me.AutoSourceTimeReverse.Location = New System.Drawing.Point(139, 54)
        Me.AutoSourceTimeReverse.Name = "AutoSourceTimeReverse"
        Me.AutoSourceTimeReverse.Size = New System.Drawing.Size(161, 24)
        Me.AutoSourceTimeReverse.TabIndex = 3
        Me.AutoSourceTimeReverse.Text = "과거 글부터 카운트"
        Me.AutoSourceTimeReverse.UseVisualStyleBackColor = True
        '
        'GetAutoSourceUrl
        '
        Me.GetAutoSourceUrl.Location = New System.Drawing.Point(6, 51)
        Me.GetAutoSourceUrl.Name = "GetAutoSourceUrl"
        Me.GetAutoSourceUrl.Size = New System.Drawing.Size(127, 23)
        Me.GetAutoSourceUrl.TabIndex = 2
        Me.GetAutoSourceUrl.Text = "관련 글 가져오기"
        Me.GetAutoSourceUrl.UseVisualStyleBackColor = True
        '
        'AutoSourceUrlLabel
        '
        Me.AutoSourceUrlLabel.AutoSize = True
        Me.AutoSourceUrlLabel.Location = New System.Drawing.Point(6, 25)
        Me.AutoSourceUrlLabel.Name = "AutoSourceUrlLabel"
        Me.AutoSourceUrlLabel.Size = New System.Drawing.Size(29, 20)
        Me.AutoSourceUrlLabel.TabIndex = 1
        Me.AutoSourceUrlLabel.Text = "Url"
        '
        'AutoSourceUrl
        '
        Me.AutoSourceUrl.Location = New System.Drawing.Point(34, 22)
        Me.AutoSourceUrl.Name = "AutoSourceUrl"
        Me.AutoSourceUrl.Size = New System.Drawing.Size(303, 27)
        Me.AutoSourceUrl.TabIndex = 0
        '
        'LoginBox
        '
        Me.LoginBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginBox.Controls.Add(Me.LoginList)
        Me.LoginBox.Location = New System.Drawing.Point(6, 22)
        Me.LoginBox.Name = "LoginBox"
        Me.LoginBox.Size = New System.Drawing.Size(346, 153)
        Me.LoginBox.TabIndex = 22
        Me.LoginBox.TabStop = False
        Me.LoginBox.Text = "로그인 세션"
        '
        'LoginList
        '
        Me.LoginList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginList.CheckBoxes = True
        Me.LoginList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Sites, Me.ID, Me.PWD, Me.URL})
        Me.LoginList.Location = New System.Drawing.Point(3, 19)
        Me.LoginList.Name = "LoginList"
        Me.LoginList.Size = New System.Drawing.Size(337, 97)
        Me.LoginList.TabIndex = 0
        Me.LoginList.UseCompatibleStateImageBehavior = False
        Me.LoginList.View = System.Windows.Forms.View.Details
        '
        'Sites
        '
        Me.Sites.Text = "사이트"
        '
        'ID
        '
        Me.ID.Text = "아이디"
        '
        'PWD
        '
        Me.PWD.Text = "패스워드"
        '
        'URL
        '
        Me.URL.Text = "주소"
        '
        'SourceBox
        '
        Me.SourceBox.Controls.Add(Me.Source)
        Me.SourceBox.Location = New System.Drawing.Point(12, 12)
        Me.SourceBox.Name = "SourceBox"
        Me.SourceBox.Size = New System.Drawing.Size(522, 154)
        Me.SourceBox.TabIndex = 21
        Me.SourceBox.TabStop = False
        Me.SourceBox.Text = "소스"
        '
        'ResultBox
        '
        Me.ResultBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ResultBox.Controls.Add(Me.Log)
        Me.ResultBox.Location = New System.Drawing.Point(12, 172)
        Me.ResultBox.Name = "ResultBox"
        Me.ResultBox.Size = New System.Drawing.Size(522, 281)
        Me.ResultBox.TabIndex = 1
        Me.ResultBox.TabStop = False
        Me.ResultBox.Text = "수집 결과"
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 639)
        Me.Controls.Add(Me.ResultBox)
        Me.Controls.Add(Me.ImageSampleBox)
        Me.Controls.Add(Me.SourceBox)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.OptionBox)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.SourceSettingBox)
        Me.Controls.Add(Me.SettingBox)
        Me.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(938, 617)
        Me.Name = "Mainform"
        Me.Text = "사이트 이미지 수집기 Ver.4.3"
        Me.SettingBox.ResumeLayout(False)
        Me.SettingBox.PerformLayout()
        CType(Me.NumberCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Title, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SourceSettingBox.ResumeLayout(False)
        Me.SourceSettingBox.PerformLayout()
        CType(Me.ImageSampleBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InfoBox.ResumeLayout(False)
        Me.InfoBox.PerformLayout()
        Me.OptionBox.ResumeLayout(False)
        Me.AutoSourceBox.ResumeLayout(False)
        Me.AutoSourceBox.PerformLayout()
        CType(Me.AutoSourceCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LoginBox.ResumeLayout(False)
        Me.SourceBox.ResumeLayout(False)
        Me.SourceBox.PerformLayout()
        Me.ResultBox.ResumeLayout(False)
        Me.ResultBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Source As System.Windows.Forms.TextBox
    Friend WithEvents SaveBtn As System.Windows.Forms.Button
    Friend WithEvents Log As System.Windows.Forms.TextBox
    Friend WithEvents SettingBox As System.Windows.Forms.GroupBox
    Friend WithEvents Sample As System.Windows.Forms.TextBox
    Friend WithEvents KeepCount As System.Windows.Forms.CheckBox
    Friend WithEvents Subchar As System.Windows.Forms.TextBox
    Friend WithEvents SubcharLabel As System.Windows.Forms.Label
    Friend WithEvents Title As System.Windows.Forms.NumericUpDown
    Friend WithEvents DirectionLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents GroupLabel As System.Windows.Forms.Label
    Friend WithEvents Group As System.Windows.Forms.TextBox
    Friend WithEvents Direction As System.Windows.Forms.TextBox
    Friend WithEvents SampleLabel As System.Windows.Forms.Label
    Friend WithEvents SourceSettingBox As System.Windows.Forms.GroupBox
    Friend WithEvents ImageSampleBox As System.Windows.Forms.PictureBox
    Friend WithEvents SourceDefault As System.Windows.Forms.RadioButton
    Friend WithEvents SourceNaver As System.Windows.Forms.RadioButton
    Friend WithEvents InfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents Info As System.Windows.Forms.TextBox
    Friend WithEvents SourceTumbler As System.Windows.Forms.RadioButton
    Friend WithEvents SourceTistory As System.Windows.Forms.RadioButton
    Friend WithEvents NumberCountLabel As System.Windows.Forms.Label
    Friend WithEvents NumberCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents OptionBox As System.Windows.Forms.GroupBox
    Friend WithEvents SourceBox As System.Windows.Forms.GroupBox
    Friend WithEvents ResultBox As System.Windows.Forms.GroupBox
    Friend WithEvents LoginBox As System.Windows.Forms.GroupBox
    Friend WithEvents LoginList As System.Windows.Forms.ListView
    Friend WithEvents Sites As System.Windows.Forms.ColumnHeader
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents PWD As System.Windows.Forms.ColumnHeader
    Friend WithEvents URL As System.Windows.Forms.ColumnHeader
    Friend WithEvents SourceWordpress As System.Windows.Forms.RadioButton
    Friend WithEvents SourceEgloos As System.Windows.Forms.RadioButton
    Friend WithEvents UseSourceUrl As System.Windows.Forms.CheckBox
    Friend WithEvents AutoSourceBox As System.Windows.Forms.GroupBox
    Friend WithEvents AutoSourceUseLabel As System.Windows.Forms.CheckBox
    Friend WithEvents AutoSourceCountLabel As System.Windows.Forms.Label
    Friend WithEvents AutoSourceCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents AutoSourceTimeReverse As System.Windows.Forms.CheckBox
    Friend WithEvents GetAutoSourceUrl As System.Windows.Forms.Button
    Friend WithEvents AutoSourceUrlLabel As System.Windows.Forms.Label
    Friend WithEvents AutoSourceUrl As System.Windows.Forms.TextBox
    Friend WithEvents SourceFC2 As System.Windows.Forms.RadioButton
    Friend WithEvents useFirstUrlSource As System.Windows.Forms.CheckBox
    Friend WithEvents Deleted As System.Windows.Forms.TextBox
    Friend WithEvents DeletedLabel As System.Windows.Forms.Label

End Class
