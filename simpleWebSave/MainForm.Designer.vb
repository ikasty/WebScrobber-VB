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
        Me.Url = New System.Windows.Forms.TextBox()
        Me.URLLabel = New System.Windows.Forms.Label()
        Me.TitleFormat = New System.Windows.Forms.TextBox()
        Me.AddSourceBtn = New System.Windows.Forms.Button()
        Me.TitleFormatLabel = New System.Windows.Forms.Label()
        Me.Deleted = New System.Windows.Forms.TextBox()
        Me.DeletedLabel = New System.Windows.Forms.Label()
        Me.NumberCountLabel = New System.Windows.Forms.Label()
        Me.NumberCount = New System.Windows.Forms.NumericUpDown()
        Me.SampleLabel = New System.Windows.Forms.Label()
        Me.Sample = New System.Windows.Forms.TextBox()
        Me.KeepCount = New System.Windows.Forms.CheckBox()
        Me.Subchar = New System.Windows.Forms.TextBox()
        Me.SubcharLabel = New System.Windows.Forms.Label()
        Me.TitleNumber = New System.Windows.Forms.NumericUpDown()
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
        Me.InfoBox = New System.Windows.Forms.GroupBox()
        Me.Info = New System.Windows.Forms.TextBox()
        Me.LogBox = New System.Windows.Forms.GroupBox()
        Me.SiteListBox = New System.Windows.Forms.GroupBox()
        Me.SiteListView = New System.Windows.Forms.ListView()
        Me.UrlHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.StatusHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ConsoleBox = New System.Windows.Forms.GroupBox()
        Me.SettingBox.SuspendLayout()
        CType(Me.NumberCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SourceSettingBox.SuspendLayout()
        Me.InfoBox.SuspendLayout()
        Me.LogBox.SuspendLayout()
        Me.SiteListBox.SuspendLayout()
        Me.ConsoleBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Source
        '
        Me.Source.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Source.Location = New System.Drawing.Point(3, 27)
        Me.Source.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Source.MaxLength = 1024768
        Me.Source.Multiline = True
        Me.Source.Name = "Source"
        Me.Source.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Source.Size = New System.Drawing.Size(572, 172)
        Me.Source.TabIndex = 0
        '
        'SaveBtn
        '
        Me.SaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SaveBtn.Font = New System.Drawing.Font("맑은 고딕", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(3, 199)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(572, 51)
        Me.SaveBtn.TabIndex = 1
        Me.SaveBtn.Text = "실행"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Log.Location = New System.Drawing.Point(3, 27)
        Me.Log.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Log.MaxLength = 1024768
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Log.Size = New System.Drawing.Size(392, 297)
        Me.Log.TabIndex = 7
        '
        'SettingBox
        '
        Me.SettingBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingBox.Controls.Add(Me.Url)
        Me.SettingBox.Controls.Add(Me.URLLabel)
        Me.SettingBox.Controls.Add(Me.TitleFormat)
        Me.SettingBox.Controls.Add(Me.AddSourceBtn)
        Me.SettingBox.Controls.Add(Me.TitleFormatLabel)
        Me.SettingBox.Controls.Add(Me.Deleted)
        Me.SettingBox.Controls.Add(Me.DeletedLabel)
        Me.SettingBox.Controls.Add(Me.NumberCountLabel)
        Me.SettingBox.Controls.Add(Me.NumberCount)
        Me.SettingBox.Controls.Add(Me.SampleLabel)
        Me.SettingBox.Controls.Add(Me.Sample)
        Me.SettingBox.Controls.Add(Me.KeepCount)
        Me.SettingBox.Controls.Add(Me.Subchar)
        Me.SettingBox.Controls.Add(Me.SubcharLabel)
        Me.SettingBox.Controls.Add(Me.TitleNumber)
        Me.SettingBox.Controls.Add(Me.DirectionLabel)
        Me.SettingBox.Controls.Add(Me.TitleLabel)
        Me.SettingBox.Controls.Add(Me.GroupLabel)
        Me.SettingBox.Controls.Add(Me.Group)
        Me.SettingBox.Controls.Add(Me.Direction)
        Me.SettingBox.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SettingBox.Location = New System.Drawing.Point(416, 13)
        Me.SettingBox.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SettingBox.Name = "SettingBox"
        Me.SettingBox.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SettingBox.Size = New System.Drawing.Size(578, 319)
        Me.SettingBox.TabIndex = 14
        Me.SettingBox.TabStop = False
        Me.SettingBox.Text = "소스 설정"
        '
        'Url
        '
        Me.Url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Url.BackColor = System.Drawing.SystemColors.Info
        Me.Url.ForeColor = System.Drawing.Color.Black
        Me.Url.Location = New System.Drawing.Point(102, 107)
        Me.Url.Name = "Url"
        Me.Url.Size = New System.Drawing.Size(470, 31)
        Me.Url.TabIndex = 32
        '
        'URLLabel
        '
        Me.URLLabel.AutoSize = True
        Me.URLLabel.Location = New System.Drawing.Point(61, 110)
        Me.URLLabel.Name = "URLLabel"
        Me.URLLabel.Size = New System.Drawing.Size(35, 25)
        Me.URLLabel.TabIndex = 31
        Me.URLLabel.Text = "Url"
        '
        'TitleFormat
        '
        Me.TitleFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleFormat.Location = New System.Drawing.Point(102, 183)
        Me.TitleFormat.Name = "TitleFormat"
        Me.TitleFormat.Size = New System.Drawing.Size(105, 31)
        Me.TitleFormat.TabIndex = 30
        Me.TitleFormat.Text = "%G %n%s"
        '
        'AddSourceBtn
        '
        Me.AddSourceBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddSourceBtn.Location = New System.Drawing.Point(6, 271)
        Me.AddSourceBtn.Name = "AddSourceBtn"
        Me.AddSourceBtn.Size = New System.Drawing.Size(179, 41)
        Me.AddSourceBtn.TabIndex = 1
        Me.AddSourceBtn.Text = "추가"
        Me.AddSourceBtn.UseVisualStyleBackColor = True
        '
        'TitleFormatLabel
        '
        Me.TitleFormatLabel.AutoSize = True
        Me.TitleFormatLabel.Location = New System.Drawing.Point(48, 187)
        Me.TitleFormatLabel.Name = "TitleFormatLabel"
        Me.TitleFormatLabel.Size = New System.Drawing.Size(48, 25)
        Me.TitleFormatLabel.TabIndex = 29
        Me.TitleFormatLabel.Text = "포맷"
        '
        'Deleted
        '
        Me.Deleted.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Deleted.Location = New System.Drawing.Point(102, 70)
        Me.Deleted.Name = "Deleted"
        Me.Deleted.Size = New System.Drawing.Size(470, 31)
        Me.Deleted.TabIndex = 28
        '
        'DeletedLabel
        '
        Me.DeletedLabel.AutoSize = True
        Me.DeletedLabel.Location = New System.Drawing.Point(6, 73)
        Me.DeletedLabel.Name = "DeletedLabel"
        Me.DeletedLabel.Size = New System.Drawing.Size(90, 25)
        Me.DeletedLabel.TabIndex = 27
        Me.DeletedLabel.Text = "삭제 폴더"
        '
        'NumberCountLabel
        '
        Me.NumberCountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberCountLabel.AutoSize = True
        Me.NumberCountLabel.Location = New System.Drawing.Point(325, 187)
        Me.NumberCountLabel.Name = "NumberCountLabel"
        Me.NumberCountLabel.Size = New System.Drawing.Size(66, 25)
        Me.NumberCountLabel.TabIndex = 26
        Me.NumberCountLabel.Text = "자리수"
        '
        'NumberCount
        '
        Me.NumberCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberCount.Location = New System.Drawing.Point(397, 185)
        Me.NumberCount.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumberCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberCount.Name = "NumberCount"
        Me.NumberCount.Size = New System.Drawing.Size(52, 31)
        Me.NumberCount.TabIndex = 25
        Me.NumberCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'SampleLabel
        '
        Me.SampleLabel.AutoSize = True
        Me.SampleLabel.Location = New System.Drawing.Point(12, 226)
        Me.SampleLabel.Name = "SampleLabel"
        Me.SampleLabel.Size = New System.Drawing.Size(84, 25)
        Me.SampleLabel.TabIndex = 24
        Me.SampleLabel.Text = "미리보기"
        '
        'Sample
        '
        Me.Sample.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sample.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Sample.Location = New System.Drawing.Point(102, 223)
        Me.Sample.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Sample.Name = "Sample"
        Me.Sample.ReadOnly = True
        Me.Sample.Size = New System.Drawing.Size(469, 31)
        Me.Sample.TabIndex = 23
        '
        'KeepCount
        '
        Me.KeepCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeepCount.AutoSize = True
        Me.KeepCount.Location = New System.Drawing.Point(455, 186)
        Me.KeepCount.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KeepCount.Name = "KeepCount"
        Me.KeepCount.Size = New System.Drawing.Size(116, 29)
        Me.KeepCount.TabIndex = 22
        Me.KeepCount.Text = "화수 유지"
        Me.KeepCount.UseVisualStyleBackColor = True
        '
        'Subchar
        '
        Me.Subchar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Subchar.Location = New System.Drawing.Point(530, 145)
        Me.Subchar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Subchar.Name = "Subchar"
        Me.Subchar.Size = New System.Drawing.Size(42, 31)
        Me.Subchar.TabIndex = 21
        Me.Subchar.Text = "화"
        '
        'SubcharLabel
        '
        Me.SubcharLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubcharLabel.AutoSize = True
        Me.SubcharLabel.Location = New System.Drawing.Point(476, 148)
        Me.SubcharLabel.Name = "SubcharLabel"
        Me.SubcharLabel.Size = New System.Drawing.Size(48, 25)
        Me.SubcharLabel.TabIndex = 20
        Me.SubcharLabel.Text = "단위"
        '
        'TitleNumber
        '
        Me.TitleNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleNumber.Location = New System.Drawing.Point(267, 185)
        Me.TitleNumber.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TitleNumber.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TitleNumber.Name = "TitleNumber"
        Me.TitleNumber.Size = New System.Drawing.Size(52, 31)
        Me.TitleNumber.TabIndex = 19
        '
        'DirectionLabel
        '
        Me.DirectionLabel.AutoSize = True
        Me.DirectionLabel.Location = New System.Drawing.Point(6, 35)
        Me.DirectionLabel.Name = "DirectionLabel"
        Me.DirectionLabel.Size = New System.Drawing.Size(90, 25)
        Me.DirectionLabel.TabIndex = 18
        Me.DirectionLabel.Text = "작업 폴더"
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(213, 187)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(48, 25)
        Me.TitleLabel.TabIndex = 16
        Me.TitleLabel.Text = "화수"
        '
        'GroupLabel
        '
        Me.GroupLabel.AutoSize = True
        Me.GroupLabel.Location = New System.Drawing.Point(30, 148)
        Me.GroupLabel.Name = "GroupLabel"
        Me.GroupLabel.Size = New System.Drawing.Size(66, 25)
        Me.GroupLabel.TabIndex = 15
        Me.GroupLabel.Text = "그룹명"
        '
        'Group
        '
        Me.Group.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group.Location = New System.Drawing.Point(102, 145)
        Me.Group.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(368, 31)
        Me.Group.TabIndex = 17
        '
        'Direction
        '
        Me.Direction.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Direction.Location = New System.Drawing.Point(102, 32)
        Me.Direction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Direction.Name = "Direction"
        Me.Direction.Size = New System.Drawing.Size(470, 31)
        Me.Direction.TabIndex = 14
        Me.Direction.Text = "F:\Manga Scraps"
        '
        'SourceSettingBox
        '
        Me.SourceSettingBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SourceSettingBox.Controls.Add(Me.useFirstUrlSource)
        Me.SourceSettingBox.Controls.Add(Me.SourceFC2)
        Me.SourceSettingBox.Controls.Add(Me.UseSourceUrl)
        Me.SourceSettingBox.Controls.Add(Me.SourceEgloos)
        Me.SourceSettingBox.Controls.Add(Me.SourceWordpress)
        Me.SourceSettingBox.Controls.Add(Me.SourceTistory)
        Me.SourceSettingBox.Controls.Add(Me.SourceTumbler)
        Me.SourceSettingBox.Controls.Add(Me.SourceDefault)
        Me.SourceSettingBox.Controls.Add(Me.SourceNaver)
        Me.SourceSettingBox.Location = New System.Drawing.Point(1000, 12)
        Me.SourceSettingBox.Name = "SourceSettingBox"
        Me.SourceSettingBox.Size = New System.Drawing.Size(336, 210)
        Me.SourceSettingBox.TabIndex = 16
        Me.SourceSettingBox.TabStop = False
        Me.SourceSettingBox.Text = "소스 설정"
        '
        'useFirstUrlSource
        '
        Me.useFirstUrlSource.AutoSize = True
        Me.useFirstUrlSource.Location = New System.Drawing.Point(15, 170)
        Me.useFirstUrlSource.Name = "useFirstUrlSource"
        Me.useFirstUrlSource.Size = New System.Drawing.Size(275, 29)
        Me.useFirstUrlSource.TabIndex = 27
        Me.useFirstUrlSource.Text = "본문의 첫 URL을 소스로 사용"
        Me.useFirstUrlSource.UseVisualStyleBackColor = True
        '
        'SourceFC2
        '
        Me.SourceFC2.AutoSize = True
        Me.SourceFC2.Location = New System.Drawing.Point(94, 30)
        Me.SourceFC2.Name = "SourceFC2"
        Me.SourceFC2.Size = New System.Drawing.Size(67, 29)
        Me.SourceFC2.TabIndex = 26
        Me.SourceFC2.Text = "FC2"
        Me.SourceFC2.UseVisualStyleBackColor = True
        '
        'UseSourceUrl
        '
        Me.UseSourceUrl.AutoSize = True
        Me.UseSourceUrl.Checked = True
        Me.UseSourceUrl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UseSourceUrl.Location = New System.Drawing.Point(15, 135)
        Me.UseSourceUrl.Name = "UseSourceUrl"
        Me.UseSourceUrl.Size = New System.Drawing.Size(314, 29)
        Me.UseSourceUrl.TabIndex = 25
        Me.UseSourceUrl.Text = "소스 코드를 웹사이트 주소로 사용"
        Me.UseSourceUrl.UseVisualStyleBackColor = True
        '
        'SourceEgloos
        '
        Me.SourceEgloos.AutoSize = True
        Me.SourceEgloos.Location = New System.Drawing.Point(15, 100)
        Me.SourceEgloos.Name = "SourceEgloos"
        Me.SourceEgloos.Size = New System.Drawing.Size(109, 29)
        Me.SourceEgloos.TabIndex = 24
        Me.SourceEgloos.Text = "이글루스"
        Me.SourceEgloos.UseVisualStyleBackColor = True
        '
        'SourceWordpress
        '
        Me.SourceWordpress.AutoSize = True
        Me.SourceWordpress.Location = New System.Drawing.Point(130, 100)
        Me.SourceWordpress.Name = "SourceWordpress"
        Me.SourceWordpress.Size = New System.Drawing.Size(127, 29)
        Me.SourceWordpress.TabIndex = 23
        Me.SourceWordpress.Text = "워드프레스"
        Me.SourceWordpress.UseVisualStyleBackColor = True
        '
        'SourceTistory
        '
        Me.SourceTistory.AutoSize = True
        Me.SourceTistory.Location = New System.Drawing.Point(203, 65)
        Me.SourceTistory.Name = "SourceTistory"
        Me.SourceTistory.Size = New System.Drawing.Size(109, 29)
        Me.SourceTistory.TabIndex = 22
        Me.SourceTistory.Text = "티스토리"
        Me.SourceTistory.UseVisualStyleBackColor = True
        '
        'SourceTumbler
        '
        Me.SourceTumbler.AutoSize = True
        Me.SourceTumbler.Location = New System.Drawing.Point(112, 65)
        Me.SourceTumbler.Name = "SourceTumbler"
        Me.SourceTumbler.Size = New System.Drawing.Size(91, 29)
        Me.SourceTumbler.TabIndex = 21
        Me.SourceTumbler.Text = "텀블러"
        Me.SourceTumbler.UseVisualStyleBackColor = True
        '
        'SourceDefault
        '
        Me.SourceDefault.AutoSize = True
        Me.SourceDefault.Checked = True
        Me.SourceDefault.Location = New System.Drawing.Point(15, 30)
        Me.SourceDefault.Name = "SourceDefault"
        Me.SourceDefault.Size = New System.Drawing.Size(73, 29)
        Me.SourceDefault.TabIndex = 1
        Me.SourceDefault.TabStop = True
        Me.SourceDefault.Text = "자동"
        Me.SourceDefault.UseVisualStyleBackColor = True
        '
        'SourceNaver
        '
        Me.SourceNaver.AutoSize = True
        Me.SourceNaver.Location = New System.Drawing.Point(15, 65)
        Me.SourceNaver.Name = "SourceNaver"
        Me.SourceNaver.Size = New System.Drawing.Size(91, 29)
        Me.SourceNaver.TabIndex = 0
        Me.SourceNaver.Text = "네이버"
        Me.SourceNaver.UseVisualStyleBackColor = True
        '
        'InfoBox
        '
        Me.InfoBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.InfoBox.Controls.Add(Me.Info)
        Me.InfoBox.Location = New System.Drawing.Point(1000, 228)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Size = New System.Drawing.Size(336, 194)
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
        Me.Info.Location = New System.Drawing.Point(6, 30)
        Me.Info.Multiline = True
        Me.Info.Name = "Info"
        Me.Info.ReadOnly = True
        Me.Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Info.Size = New System.Drawing.Size(324, 158)
        Me.Info.TabIndex = 0
        Me.Info.Text = "이 프로그램의 사용상의 법적 책임은 사용자에게 있습니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "웹 상의 이미지를 쉽게 저장해 정리해주는 프로그램입니다. 만화 등을 긁어올 때 유용" & _
    "하게 사용됩니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "사이트의 주소를 한 줄에 하나씩 입력하거나, 또는 HTML 소스를 복사해 붙여넣으면 됩니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "버전 5.0"
        '
        'LogBox
        '
        Me.LogBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogBox.Controls.Add(Me.Log)
        Me.LogBox.Location = New System.Drawing.Point(12, 265)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Size = New System.Drawing.Size(398, 327)
        Me.LogBox.TabIndex = 1
        Me.LogBox.TabStop = False
        Me.LogBox.Text = "로그"
        '
        'SiteListBox
        '
        Me.SiteListBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiteListBox.Controls.Add(Me.SiteListView)
        Me.SiteListBox.Location = New System.Drawing.Point(12, 12)
        Me.SiteListBox.Name = "SiteListBox"
        Me.SiteListBox.Size = New System.Drawing.Size(398, 248)
        Me.SiteListBox.TabIndex = 22
        Me.SiteListBox.TabStop = False
        Me.SiteListBox.Text = "소스 목록"
        '
        'SiteListView
        '
        Me.SiteListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.UrlHeader, Me.StatusHeader})
        Me.SiteListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiteListView.Location = New System.Drawing.Point(3, 27)
        Me.SiteListView.Name = "SiteListView"
        Me.SiteListView.Size = New System.Drawing.Size(392, 218)
        Me.SiteListView.TabIndex = 0
        Me.SiteListView.UseCompatibleStateImageBehavior = False
        Me.SiteListView.View = System.Windows.Forms.View.Details
        '
        'UrlHeader
        '
        Me.UrlHeader.Text = "URL"
        '
        'StatusHeader
        '
        Me.StatusHeader.Text = "상태"
        '
        'ConsoleBox
        '
        Me.ConsoleBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsoleBox.Controls.Add(Me.Source)
        Me.ConsoleBox.Controls.Add(Me.SaveBtn)
        Me.ConsoleBox.Location = New System.Drawing.Point(416, 339)
        Me.ConsoleBox.Name = "ConsoleBox"
        Me.ConsoleBox.Size = New System.Drawing.Size(578, 253)
        Me.ConsoleBox.TabIndex = 1
        Me.ConsoleBox.TabStop = False
        Me.ConsoleBox.Text = "콘솔"
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1348, 599)
        Me.Controls.Add(Me.ConsoleBox)
        Me.Controls.Add(Me.SiteListBox)
        Me.Controls.Add(Me.LogBox)
        Me.Controls.Add(Me.InfoBox)
        Me.Controls.Add(Me.SourceSettingBox)
        Me.Controls.Add(Me.SettingBox)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(938, 617)
        Me.Name = "Mainform"
        Me.Text = "사이트 이미지 수집기 Ver.5.0"
        Me.SettingBox.ResumeLayout(False)
        Me.SettingBox.PerformLayout()
        CType(Me.NumberCount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TitleNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SourceSettingBox.ResumeLayout(False)
        Me.SourceSettingBox.PerformLayout()
        Me.InfoBox.ResumeLayout(False)
        Me.InfoBox.PerformLayout()
        Me.LogBox.ResumeLayout(False)
        Me.LogBox.PerformLayout()
        Me.SiteListBox.ResumeLayout(False)
        Me.ConsoleBox.ResumeLayout(False)
        Me.ConsoleBox.PerformLayout()
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
    Friend WithEvents TitleNumber As System.Windows.Forms.NumericUpDown
    Friend WithEvents DirectionLabel As System.Windows.Forms.Label
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents GroupLabel As System.Windows.Forms.Label
    Friend WithEvents Group As System.Windows.Forms.TextBox
    Friend WithEvents Direction As System.Windows.Forms.TextBox
    Friend WithEvents SampleLabel As System.Windows.Forms.Label
    Friend WithEvents SourceSettingBox As System.Windows.Forms.GroupBox
    Friend WithEvents SourceDefault As System.Windows.Forms.RadioButton
    Friend WithEvents SourceNaver As System.Windows.Forms.RadioButton
    Friend WithEvents InfoBox As System.Windows.Forms.GroupBox
    Friend WithEvents Info As System.Windows.Forms.TextBox
    Friend WithEvents SourceTumbler As System.Windows.Forms.RadioButton
    Friend WithEvents SourceTistory As System.Windows.Forms.RadioButton
    Friend WithEvents NumberCountLabel As System.Windows.Forms.Label
    Friend WithEvents NumberCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents LogBox As System.Windows.Forms.GroupBox
    Friend WithEvents SourceWordpress As System.Windows.Forms.RadioButton
    Friend WithEvents SourceEgloos As System.Windows.Forms.RadioButton
    Friend WithEvents UseSourceUrl As System.Windows.Forms.CheckBox
    Friend WithEvents SourceFC2 As System.Windows.Forms.RadioButton
    Friend WithEvents useFirstUrlSource As System.Windows.Forms.CheckBox
    Friend WithEvents Deleted As System.Windows.Forms.TextBox
    Friend WithEvents DeletedLabel As System.Windows.Forms.Label
    Friend WithEvents AddSourceBtn As System.Windows.Forms.Button
    Friend WithEvents SiteListBox As System.Windows.Forms.GroupBox
    Friend WithEvents SiteListView As System.Windows.Forms.ListView
    Friend WithEvents UrlHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusHeader As System.Windows.Forms.ColumnHeader
    Friend WithEvents URLLabel As System.Windows.Forms.Label
    Friend WithEvents TitleFormat As System.Windows.Forms.TextBox
    Friend WithEvents TitleFormatLabel As System.Windows.Forms.Label
    Friend WithEvents Url As System.Windows.Forms.TextBox
    Friend WithEvents ConsoleBox As System.Windows.Forms.GroupBox

End Class
