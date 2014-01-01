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
        Me.ErrorDirectory = New System.Windows.Forms.TextBox()
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
        Me.Directory = New System.Windows.Forms.TextBox()
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
        Me.ConsoleBox = New System.Windows.Forms.GroupBox()
        Me.FixedAreaPanel = New System.Windows.Forms.Panel()
        Me.ExecuteAreaPanel = New System.Windows.Forms.Panel()
        Me.StartCrawling = New System.Windows.Forms.Button()
        Me.StartDownload = New System.Windows.Forms.Button()
        Me.GrowAreaPanel = New System.Windows.Forms.Panel()
        Me.SettingBox.SuspendLayout()
        CType(Me.NumberCount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TitleNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SourceSettingBox.SuspendLayout()
        Me.InfoBox.SuspendLayout()
        Me.LogBox.SuspendLayout()
        Me.SiteListBox.SuspendLayout()
        Me.ConsoleBox.SuspendLayout()
        Me.FixedAreaPanel.SuspendLayout()
        Me.ExecuteAreaPanel.SuspendLayout()
        Me.GrowAreaPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'Source
        '
        Me.Source.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Source.Location = New System.Drawing.Point(2, 18)
        Me.Source.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Source.MaxLength = 1024768
        Me.Source.Multiline = True
        Me.Source.Name = "Source"
        Me.Source.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Source.Size = New System.Drawing.Size(381, 110)
        Me.Source.TabIndex = 0
        '
        'SaveBtn
        '
        Me.SaveBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SaveBtn.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SaveBtn.Location = New System.Drawing.Point(2, 128)
        Me.SaveBtn.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(381, 34)
        Me.SaveBtn.TabIndex = 1
        Me.SaveBtn.Text = "콘솔 실행"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'Log
        '
        Me.Log.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Log.Location = New System.Drawing.Point(2, 18)
        Me.Log.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Log.MaxLength = 1024768
        Me.Log.Multiline = True
        Me.Log.Name = "Log"
        Me.Log.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.Log.Size = New System.Drawing.Size(310, 188)
        Me.Log.TabIndex = 0
        '
        'SettingBox
        '
        Me.SettingBox.Controls.Add(Me.Url)
        Me.SettingBox.Controls.Add(Me.URLLabel)
        Me.SettingBox.Controls.Add(Me.TitleFormat)
        Me.SettingBox.Controls.Add(Me.AddSourceBtn)
        Me.SettingBox.Controls.Add(Me.TitleFormatLabel)
        Me.SettingBox.Controls.Add(Me.ErrorDirectory)
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
        Me.SettingBox.Controls.Add(Me.Directory)
        Me.SettingBox.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.SettingBox.Location = New System.Drawing.Point(2, 3)
        Me.SettingBox.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SettingBox.Name = "SettingBox"
        Me.SettingBox.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.SettingBox.Size = New System.Drawing.Size(385, 213)
        Me.SettingBox.TabIndex = 0
        Me.SettingBox.TabStop = False
        Me.SettingBox.Text = "소스 설정"
        '
        'Url
        '
        Me.Url.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Url.BackColor = System.Drawing.SystemColors.Info
        Me.Url.ForeColor = System.Drawing.Color.Black
        Me.Url.Location = New System.Drawing.Point(68, 71)
        Me.Url.Margin = New System.Windows.Forms.Padding(2)
        Me.Url.Name = "Url"
        Me.Url.Size = New System.Drawing.Size(315, 23)
        Me.Url.TabIndex = 2
        '
        'URLLabel
        '
        Me.URLLabel.AutoSize = True
        Me.URLLabel.Location = New System.Drawing.Point(41, 73)
        Me.URLLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.URLLabel.Name = "URLLabel"
        Me.URLLabel.Size = New System.Drawing.Size(22, 15)
        Me.URLLabel.TabIndex = 31
        Me.URLLabel.Text = "Url"
        '
        'TitleFormat
        '
        Me.TitleFormat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleFormat.Location = New System.Drawing.Point(68, 122)
        Me.TitleFormat.Margin = New System.Windows.Forms.Padding(2)
        Me.TitleFormat.Name = "TitleFormat"
        Me.TitleFormat.Size = New System.Drawing.Size(71, 23)
        Me.TitleFormat.TabIndex = 5
        Me.TitleFormat.Text = "%G %n%s"
        '
        'AddSourceBtn
        '
        Me.AddSourceBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AddSourceBtn.Location = New System.Drawing.Point(4, 181)
        Me.AddSourceBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddSourceBtn.Name = "AddSourceBtn"
        Me.AddSourceBtn.Size = New System.Drawing.Size(119, 27)
        Me.AddSourceBtn.TabIndex = 10
        Me.AddSourceBtn.Text = "추가"
        Me.AddSourceBtn.UseVisualStyleBackColor = True
        '
        'TitleFormatLabel
        '
        Me.TitleFormatLabel.AutoSize = True
        Me.TitleFormatLabel.Location = New System.Drawing.Point(32, 125)
        Me.TitleFormatLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleFormatLabel.Name = "TitleFormatLabel"
        Me.TitleFormatLabel.Size = New System.Drawing.Size(31, 15)
        Me.TitleFormatLabel.TabIndex = 29
        Me.TitleFormatLabel.Text = "포맷"
        '
        'ErrorDirectory
        '
        Me.ErrorDirectory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ErrorDirectory.Location = New System.Drawing.Point(68, 47)
        Me.ErrorDirectory.Margin = New System.Windows.Forms.Padding(2)
        Me.ErrorDirectory.Name = "ErrorDirectory"
        Me.ErrorDirectory.Size = New System.Drawing.Size(315, 23)
        Me.ErrorDirectory.TabIndex = 1
        '
        'DeletedLabel
        '
        Me.DeletedLabel.AutoSize = True
        Me.DeletedLabel.Location = New System.Drawing.Point(4, 49)
        Me.DeletedLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DeletedLabel.Name = "DeletedLabel"
        Me.DeletedLabel.Size = New System.Drawing.Size(59, 15)
        Me.DeletedLabel.TabIndex = 27
        Me.DeletedLabel.Text = "삭제 폴더"
        '
        'NumberCountLabel
        '
        Me.NumberCountLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberCountLabel.AutoSize = True
        Me.NumberCountLabel.Location = New System.Drawing.Point(217, 125)
        Me.NumberCountLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NumberCountLabel.Name = "NumberCountLabel"
        Me.NumberCountLabel.Size = New System.Drawing.Size(43, 15)
        Me.NumberCountLabel.TabIndex = 26
        Me.NumberCountLabel.Text = "자리수"
        '
        'NumberCount
        '
        Me.NumberCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NumberCount.Location = New System.Drawing.Point(265, 123)
        Me.NumberCount.Margin = New System.Windows.Forms.Padding(2)
        Me.NumberCount.Maximum = New Decimal(New Integer() {4, 0, 0, 0})
        Me.NumberCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumberCount.Name = "NumberCount"
        Me.NumberCount.Size = New System.Drawing.Size(35, 23)
        Me.NumberCount.TabIndex = 7
        Me.NumberCount.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'SampleLabel
        '
        Me.SampleLabel.AutoSize = True
        Me.SampleLabel.Location = New System.Drawing.Point(8, 151)
        Me.SampleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SampleLabel.Name = "SampleLabel"
        Me.SampleLabel.Size = New System.Drawing.Size(55, 15)
        Me.SampleLabel.TabIndex = 24
        Me.SampleLabel.Text = "미리보기"
        '
        'Sample
        '
        Me.Sample.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sample.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Sample.Location = New System.Drawing.Point(68, 149)
        Me.Sample.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Sample.Name = "Sample"
        Me.Sample.ReadOnly = True
        Me.Sample.Size = New System.Drawing.Size(314, 23)
        Me.Sample.TabIndex = 9
        '
        'KeepCount
        '
        Me.KeepCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.KeepCount.AutoSize = True
        Me.KeepCount.Location = New System.Drawing.Point(303, 124)
        Me.KeepCount.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.KeepCount.Name = "KeepCount"
        Me.KeepCount.Size = New System.Drawing.Size(78, 19)
        Me.KeepCount.TabIndex = 8
        Me.KeepCount.Text = "화수 유지"
        Me.KeepCount.UseVisualStyleBackColor = True
        '
        'Subchar
        '
        Me.Subchar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Subchar.Location = New System.Drawing.Point(353, 97)
        Me.Subchar.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Subchar.Name = "Subchar"
        Me.Subchar.Size = New System.Drawing.Size(29, 23)
        Me.Subchar.TabIndex = 21
        Me.Subchar.Text = "화"
        '
        'SubcharLabel
        '
        Me.SubcharLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SubcharLabel.AutoSize = True
        Me.SubcharLabel.Location = New System.Drawing.Point(317, 99)
        Me.SubcharLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.SubcharLabel.Name = "SubcharLabel"
        Me.SubcharLabel.Size = New System.Drawing.Size(31, 15)
        Me.SubcharLabel.TabIndex = 4
        Me.SubcharLabel.Text = "단위"
        '
        'TitleNumber
        '
        Me.TitleNumber.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleNumber.Location = New System.Drawing.Point(178, 123)
        Me.TitleNumber.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.TitleNumber.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.TitleNumber.Name = "TitleNumber"
        Me.TitleNumber.Size = New System.Drawing.Size(35, 23)
        Me.TitleNumber.TabIndex = 6
        '
        'DirectionLabel
        '
        Me.DirectionLabel.AutoSize = True
        Me.DirectionLabel.Location = New System.Drawing.Point(4, 23)
        Me.DirectionLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DirectionLabel.Name = "DirectionLabel"
        Me.DirectionLabel.Size = New System.Drawing.Size(59, 15)
        Me.DirectionLabel.TabIndex = 18
        Me.DirectionLabel.Text = "작업 폴더"
        '
        'TitleLabel
        '
        Me.TitleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Location = New System.Drawing.Point(142, 125)
        Me.TitleLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(31, 15)
        Me.TitleLabel.TabIndex = 16
        Me.TitleLabel.Text = "화수"
        '
        'GroupLabel
        '
        Me.GroupLabel.AutoSize = True
        Me.GroupLabel.Location = New System.Drawing.Point(20, 99)
        Me.GroupLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GroupLabel.Name = "GroupLabel"
        Me.GroupLabel.Size = New System.Drawing.Size(43, 15)
        Me.GroupLabel.TabIndex = 15
        Me.GroupLabel.Text = "그룹명"
        '
        'Group
        '
        Me.Group.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group.Location = New System.Drawing.Point(68, 97)
        Me.Group.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(247, 23)
        Me.Group.TabIndex = 3
        '
        'Directory
        '
        Me.Directory.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Directory.Location = New System.Drawing.Point(68, 21)
        Me.Directory.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.Directory.Name = "Directory"
        Me.Directory.Size = New System.Drawing.Size(315, 23)
        Me.Directory.TabIndex = 0
        Me.Directory.Text = "F:\Manga Scraps"
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
        Me.SourceSettingBox.Location = New System.Drawing.Point(391, 2)
        Me.SourceSettingBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceSettingBox.Name = "SourceSettingBox"
        Me.SourceSettingBox.Padding = New System.Windows.Forms.Padding(2)
        Me.SourceSettingBox.Size = New System.Drawing.Size(233, 140)
        Me.SourceSettingBox.TabIndex = 16
        Me.SourceSettingBox.TabStop = False
        Me.SourceSettingBox.Text = "소스 타입"
        '
        'useFirstUrlSource
        '
        Me.useFirstUrlSource.AutoSize = True
        Me.useFirstUrlSource.Location = New System.Drawing.Point(10, 113)
        Me.useFirstUrlSource.Margin = New System.Windows.Forms.Padding(2)
        Me.useFirstUrlSource.Name = "useFirstUrlSource"
        Me.useFirstUrlSource.Size = New System.Drawing.Size(183, 19)
        Me.useFirstUrlSource.TabIndex = 27
        Me.useFirstUrlSource.Text = "본문의 첫 URL을 소스로 사용"
        Me.useFirstUrlSource.UseVisualStyleBackColor = True
        '
        'SourceFC2
        '
        Me.SourceFC2.AutoSize = True
        Me.SourceFC2.Location = New System.Drawing.Point(63, 20)
        Me.SourceFC2.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceFC2.Name = "SourceFC2"
        Me.SourceFC2.Size = New System.Drawing.Size(46, 19)
        Me.SourceFC2.TabIndex = 26
        Me.SourceFC2.Text = "FC2"
        Me.SourceFC2.UseVisualStyleBackColor = True
        '
        'UseSourceUrl
        '
        Me.UseSourceUrl.AutoSize = True
        Me.UseSourceUrl.Checked = True
        Me.UseSourceUrl.CheckState = System.Windows.Forms.CheckState.Checked
        Me.UseSourceUrl.Location = New System.Drawing.Point(10, 90)
        Me.UseSourceUrl.Margin = New System.Windows.Forms.Padding(2)
        Me.UseSourceUrl.Name = "UseSourceUrl"
        Me.UseSourceUrl.Size = New System.Drawing.Size(210, 19)
        Me.UseSourceUrl.TabIndex = 25
        Me.UseSourceUrl.Text = "소스 코드를 웹사이트 주소로 사용"
        Me.UseSourceUrl.UseVisualStyleBackColor = True
        '
        'SourceEgloos
        '
        Me.SourceEgloos.AutoSize = True
        Me.SourceEgloos.Location = New System.Drawing.Point(10, 67)
        Me.SourceEgloos.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceEgloos.Name = "SourceEgloos"
        Me.SourceEgloos.Size = New System.Drawing.Size(73, 19)
        Me.SourceEgloos.TabIndex = 24
        Me.SourceEgloos.Text = "이글루스"
        Me.SourceEgloos.UseVisualStyleBackColor = True
        '
        'SourceWordpress
        '
        Me.SourceWordpress.AutoSize = True
        Me.SourceWordpress.Location = New System.Drawing.Point(87, 67)
        Me.SourceWordpress.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceWordpress.Name = "SourceWordpress"
        Me.SourceWordpress.Size = New System.Drawing.Size(85, 19)
        Me.SourceWordpress.TabIndex = 23
        Me.SourceWordpress.Text = "워드프레스"
        Me.SourceWordpress.UseVisualStyleBackColor = True
        '
        'SourceTistory
        '
        Me.SourceTistory.AutoSize = True
        Me.SourceTistory.Location = New System.Drawing.Point(135, 43)
        Me.SourceTistory.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceTistory.Name = "SourceTistory"
        Me.SourceTistory.Size = New System.Drawing.Size(73, 19)
        Me.SourceTistory.TabIndex = 22
        Me.SourceTistory.Text = "티스토리"
        Me.SourceTistory.UseVisualStyleBackColor = True
        '
        'SourceTumbler
        '
        Me.SourceTumbler.AutoSize = True
        Me.SourceTumbler.Location = New System.Drawing.Point(75, 43)
        Me.SourceTumbler.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceTumbler.Name = "SourceTumbler"
        Me.SourceTumbler.Size = New System.Drawing.Size(61, 19)
        Me.SourceTumbler.TabIndex = 21
        Me.SourceTumbler.Text = "텀블러"
        Me.SourceTumbler.UseVisualStyleBackColor = True
        '
        'SourceDefault
        '
        Me.SourceDefault.AutoSize = True
        Me.SourceDefault.Checked = True
        Me.SourceDefault.Location = New System.Drawing.Point(10, 20)
        Me.SourceDefault.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceDefault.Name = "SourceDefault"
        Me.SourceDefault.Size = New System.Drawing.Size(49, 19)
        Me.SourceDefault.TabIndex = 1
        Me.SourceDefault.TabStop = True
        Me.SourceDefault.Text = "자동"
        Me.SourceDefault.UseVisualStyleBackColor = True
        '
        'SourceNaver
        '
        Me.SourceNaver.AutoSize = True
        Me.SourceNaver.Location = New System.Drawing.Point(10, 43)
        Me.SourceNaver.Margin = New System.Windows.Forms.Padding(2)
        Me.SourceNaver.Name = "SourceNaver"
        Me.SourceNaver.Size = New System.Drawing.Size(61, 19)
        Me.SourceNaver.TabIndex = 0
        Me.SourceNaver.Text = "네이버"
        Me.SourceNaver.UseVisualStyleBackColor = True
        '
        'InfoBox
        '
        Me.InfoBox.Controls.Add(Me.Info)
        Me.InfoBox.Location = New System.Drawing.Point(391, 146)
        Me.InfoBox.Margin = New System.Windows.Forms.Padding(2)
        Me.InfoBox.Name = "InfoBox"
        Me.InfoBox.Padding = New System.Windows.Forms.Padding(2)
        Me.InfoBox.Size = New System.Drawing.Size(235, 129)
        Me.InfoBox.TabIndex = 19
        Me.InfoBox.TabStop = False
        Me.InfoBox.Text = "정보"
        '
        'Info
        '
        Me.Info.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Info.Location = New System.Drawing.Point(2, 18)
        Me.Info.Margin = New System.Windows.Forms.Padding(2)
        Me.Info.Multiline = True
        Me.Info.Name = "Info"
        Me.Info.ReadOnly = True
        Me.Info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Info.Size = New System.Drawing.Size(231, 109)
        Me.Info.TabIndex = 0
        Me.Info.Text = "이 프로그램의 사용상의 법적 책임은 사용자에게 있습니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "웹 상의 이미지를 쉽게 저장해 정리해주는 프로그램입니다. 만화 등을 긁어올 때 유용" & _
    "하게 사용됩니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "사이트의 주소를 한 줄에 하나씩 입력하거나, 또는 HTML 소스를 복사해 붙여넣으면 됩니다." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "버전 5.0"
        '
        'LogBox
        '
        Me.LogBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LogBox.Controls.Add(Me.Log)
        Me.LogBox.Location = New System.Drawing.Point(2, 172)
        Me.LogBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LogBox.Name = "LogBox"
        Me.LogBox.Padding = New System.Windows.Forms.Padding(2)
        Me.LogBox.Size = New System.Drawing.Size(314, 208)
        Me.LogBox.TabIndex = 1
        Me.LogBox.TabStop = False
        Me.LogBox.Text = "로그"
        '
        'SiteListBox
        '
        Me.SiteListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SiteListBox.Controls.Add(Me.SiteListView)
        Me.SiteListBox.Location = New System.Drawing.Point(2, 2)
        Me.SiteListBox.Margin = New System.Windows.Forms.Padding(2)
        Me.SiteListBox.Name = "SiteListBox"
        Me.SiteListBox.Padding = New System.Windows.Forms.Padding(2)
        Me.SiteListBox.Size = New System.Drawing.Size(314, 166)
        Me.SiteListBox.TabIndex = 0
        Me.SiteListBox.TabStop = False
        Me.SiteListBox.Text = "소스 목록"
        '
        'SiteListView
        '
        Me.SiteListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SiteListView.Location = New System.Drawing.Point(2, 18)
        Me.SiteListView.Margin = New System.Windows.Forms.Padding(2)
        Me.SiteListView.MultiSelect = False
        Me.SiteListView.Name = "SiteListView"
        Me.SiteListView.Size = New System.Drawing.Size(310, 146)
        Me.SiteListView.TabIndex = 0
        Me.SiteListView.UseCompatibleStateImageBehavior = False
        Me.SiteListView.View = System.Windows.Forms.View.Details
        '
        'ConsoleBox
        '
        Me.ConsoleBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ConsoleBox.Controls.Add(Me.Source)
        Me.ConsoleBox.Controls.Add(Me.SaveBtn)
        Me.ConsoleBox.Location = New System.Drawing.Point(2, 220)
        Me.ConsoleBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ConsoleBox.Name = "ConsoleBox"
        Me.ConsoleBox.Padding = New System.Windows.Forms.Padding(2)
        Me.ConsoleBox.Size = New System.Drawing.Size(385, 164)
        Me.ConsoleBox.TabIndex = 2
        Me.ConsoleBox.TabStop = False
        Me.ConsoleBox.Text = "콘솔"
        '
        'FixedAreaPanel
        '
        Me.FixedAreaPanel.Controls.Add(Me.ExecuteAreaPanel)
        Me.FixedAreaPanel.Controls.Add(Me.SettingBox)
        Me.FixedAreaPanel.Controls.Add(Me.ConsoleBox)
        Me.FixedAreaPanel.Controls.Add(Me.SourceSettingBox)
        Me.FixedAreaPanel.Controls.Add(Me.InfoBox)
        Me.FixedAreaPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.FixedAreaPanel.Location = New System.Drawing.Point(318, 0)
        Me.FixedAreaPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.FixedAreaPanel.Name = "FixedAreaPanel"
        Me.FixedAreaPanel.Size = New System.Drawing.Size(628, 387)
        Me.FixedAreaPanel.TabIndex = 0
        '
        'ExecuteAreaPanel
        '
        Me.ExecuteAreaPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ExecuteAreaPanel.Controls.Add(Me.StartCrawling)
        Me.ExecuteAreaPanel.Controls.Add(Me.StartDownload)
        Me.ExecuteAreaPanel.Location = New System.Drawing.Point(392, 299)
        Me.ExecuteAreaPanel.Name = "ExecuteAreaPanel"
        Me.ExecuteAreaPanel.Size = New System.Drawing.Size(231, 82)
        Me.ExecuteAreaPanel.TabIndex = 20
        '
        'StartCrawling
        '
        Me.StartCrawling.Dock = System.Windows.Forms.DockStyle.Left
        Me.StartCrawling.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.StartCrawling.Location = New System.Drawing.Point(0, 0)
        Me.StartCrawling.Name = "StartCrawling"
        Me.StartCrawling.Size = New System.Drawing.Size(112, 82)
        Me.StartCrawling.TabIndex = 2
        Me.StartCrawling.Text = "크롤링 실행"
        Me.StartCrawling.UseVisualStyleBackColor = True
        '
        'StartDownload
        '
        Me.StartDownload.Dock = System.Windows.Forms.DockStyle.Right
        Me.StartDownload.Font = New System.Drawing.Font("맑은 고딕", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.StartDownload.Location = New System.Drawing.Point(118, 0)
        Me.StartDownload.Name = "StartDownload"
        Me.StartDownload.Size = New System.Drawing.Size(113, 82)
        Me.StartDownload.TabIndex = 1
        Me.StartDownload.Text = "다운로드 실행"
        Me.StartDownload.UseVisualStyleBackColor = True
        '
        'GrowAreaPanel
        '
        Me.GrowAreaPanel.Controls.Add(Me.LogBox)
        Me.GrowAreaPanel.Controls.Add(Me.SiteListBox)
        Me.GrowAreaPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrowAreaPanel.Location = New System.Drawing.Point(0, 0)
        Me.GrowAreaPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.GrowAreaPanel.Name = "GrowAreaPanel"
        Me.GrowAreaPanel.Size = New System.Drawing.Size(318, 387)
        Me.GrowAreaPanel.TabIndex = 1
        '
        'Mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(946, 387)
        Me.Controls.Add(Me.GrowAreaPanel)
        Me.Controls.Add(Me.FixedAreaPanel)
        Me.Font = New System.Drawing.Font("맑은 고딕", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MinimumSize = New System.Drawing.Size(960, 423)
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
        Me.FixedAreaPanel.ResumeLayout(False)
        Me.ExecuteAreaPanel.ResumeLayout(False)
        Me.GrowAreaPanel.ResumeLayout(False)
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
    Friend WithEvents Directory As System.Windows.Forms.TextBox
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
    Friend WithEvents ErrorDirectory As System.Windows.Forms.TextBox
    Friend WithEvents DeletedLabel As System.Windows.Forms.Label
    Friend WithEvents AddSourceBtn As System.Windows.Forms.Button
    Friend WithEvents SiteListBox As System.Windows.Forms.GroupBox
    Friend WithEvents SiteListView As System.Windows.Forms.ListView
    Friend WithEvents URLLabel As System.Windows.Forms.Label
    Friend WithEvents TitleFormat As System.Windows.Forms.TextBox
    Friend WithEvents TitleFormatLabel As System.Windows.Forms.Label
    Friend WithEvents Url As System.Windows.Forms.TextBox
    Friend WithEvents ConsoleBox As System.Windows.Forms.GroupBox
    Friend WithEvents FixedAreaPanel As System.Windows.Forms.Panel
    Friend WithEvents GrowAreaPanel As System.Windows.Forms.Panel
    Friend WithEvents StartDownload As System.Windows.Forms.Button
    Friend WithEvents ExecuteAreaPanel As System.Windows.Forms.Panel
    Friend WithEvents StartCrawling As System.Windows.Forms.Button

End Class
