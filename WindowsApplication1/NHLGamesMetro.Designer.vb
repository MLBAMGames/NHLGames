Imports MetroFramework.Controls
Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NHLGamesMetro
    Inherits MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NHLGamesMetro))
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.tabMenu = New MetroFramework.Controls.MetroTabControl()
        Me.tabGames = New MetroFramework.Controls.MetroTabPage()
        Me.spnLoading = New MetroFramework.Controls.MetroProgressSpinner()
        Me.lblDate = New MetroFramework.Controls.MetroLabel()
        Me.lblNoGames = New System.Windows.Forms.Label()
        Me.flpCalender = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnYesterday = New System.Windows.Forms.Button()
        Me.btnTomorrow = New System.Windows.Forms.Button()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.flpGames = New System.Windows.Forms.FlowLayoutPanel()
        Me.tabSettings = New MetroFramework.Controls.MetroTabPage()
        Me.tlpSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.chkShowFinalScores = New MetroFramework.Controls.MetroCheckBox()
        Me.chkShowLiveScores = New MetroFramework.Controls.MetroCheckBox()
        Me.chkShowSeriesRecord = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.rbMpv = New MetroFramework.Controls.MetroRadioButton()
        Me.rbMPC = New MetroFramework.Controls.MetroRadioButton()
        Me.rbVLC = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.rbQual6 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual5 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual4 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual3 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual2 = New MetroFramework.Controls.MetroRadioButton()
        Me.chk60 = New MetroFramework.Controls.MetroCheckBox()
        Me.rbQual1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.lblNoteCdn = New MetroFramework.Controls.MetroLabel()
        Me.rbAkamai = New MetroFramework.Controls.MetroRadioButton()
        Me.rbLevel3 = New MetroFramework.Controls.MetroRadioButton()
        Me.lblStreamerArgs = New MetroFramework.Controls.MetroLabel()
        Me.lblPlayerArgs = New MetroFramework.Controls.MetroLabel()
        Me.lblOutput = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel9 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtStreamerArgs = New System.Windows.Forms.TextBox()
        Me.tgStreamer = New MetroFramework.Controls.MetroToggle()
        Me.FlowLayoutPanel8 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtPlayerArgs = New System.Windows.Forms.TextBox()
        Me.tgPlayer = New MetroFramework.Controls.MetroToggle()
        Me.FlowLayoutPanel7 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtOutputArgs = New System.Windows.Forms.TextBox()
        Me.btnOuput = New MetroFramework.Controls.MetroButton()
        Me.tgOutput = New MetroFramework.Controls.MetroToggle()
        Me.FlowLayoutPanel6 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtStreamlinkPath = New System.Windows.Forms.TextBox()
        Me.btnstreamlinkPath = New MetroFramework.Controls.MetroButton()
        Me.FlowLayoutPanel5 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtMpvPath = New System.Windows.Forms.TextBox()
        Me.btnMpvPath = New MetroFramework.Controls.MetroButton()
        Me.FlowLayoutPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtMPCPath = New System.Windows.Forms.TextBox()
        Me.btnMPCPath = New MetroFramework.Controls.MetroButton()
        Me.lnkGetMpc = New MetroFramework.Controls.MetroLink()
        Me.FlowLayoutPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtVLCPath = New System.Windows.Forms.TextBox()
        Me.btnVLCPath = New MetroFramework.Controls.MetroButton()
        Me.lnkGetVlc = New MetroFramework.Controls.MetroLink()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnTestHosts = New MetroFramework.Controls.MetroButton()
        Me.btnOpenHostsFile = New MetroFramework.Controls.MetroButton()
        Me.btnAddHosts = New MetroFramework.Controls.MetroButton()
        Me.btnCleanHosts = New MetroFramework.Controls.MetroButton()
        Me.lnkDiySteps = New MetroFramework.Controls.MetroLink()
        Me.FlowLayoutPanel10 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbServers = New MetroFramework.Controls.MetroComboBox()
        Me.lblLanguage = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel11 = New System.Windows.Forms.FlowLayoutPanel()
        Me.cbLanguage = New MetroFramework.Controls.MetroComboBox()
        Me.lblSlPath = New MetroFramework.Controls.MetroLabel()
        Me.lblMpvPath = New MetroFramework.Controls.MetroLabel()
        Me.lblMpcPath = New MetroFramework.Controls.MetroLabel()
        Me.lblVlcPath = New MetroFramework.Controls.MetroLabel()
        Me.lblHostname = New MetroFramework.Controls.MetroLabel()
        Me.lblQuality = New MetroFramework.Controls.MetroLabel()
        Me.lblCdn = New MetroFramework.Controls.MetroLabel()
        Me.lblPlayer = New MetroFramework.Controls.MetroLabel()
        Me.lblShowScores = New MetroFramework.Controls.MetroLabel()
        Me.lblHosts = New MetroFramework.Controls.MetroLabel()
        Me.tabConsole = New MetroFramework.Controls.MetroTabPage()
        Me.btnCopyConsole = New MetroFramework.Controls.MetroButton()
        Me.btnClearConsole = New MetroFramework.Controls.MetroButton()
        Me.tabAdDetectionModules = New MetroFramework.Controls.MetroTabPage()
        Me.flpAdDetector = New System.Windows.Forms.FlowLayoutPanel()
        Me.AdDetectionSettingsElementHost = New System.Windows.Forms.Integration.ElementHost()
        Me.tabModules = New MetroFramework.Controls.MetroTabPage()
        Me.tlpModules = New System.Windows.Forms.TableLayoutPanel()
        Me.lblModules = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel12 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgModules = New MetroFramework.Controls.MetroToggle()
        Me.FlowLayoutPanel13 = New System.Windows.Forms.FlowLayoutPanel()
        Me.rbVolumeDetection = New MetroFramework.Controls.MetroRadioButton()
        Me.rbFullscreenDetection = New MetroFramework.Controls.MetroRadioButton()
        Me.FlowLayoutPanel15 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgSpotify = New MetroFramework.Controls.MetroToggle()
        Me.lblSpotifyDesc = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel16 = New System.Windows.Forms.FlowLayoutPanel()
        Me.tgOBS = New MetroFramework.Controls.MetroToggle()
        Me.lblOBSDesc = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel18 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblDetectionType = New MetroFramework.Controls.MetroLabel()
        Me.lblSpotify = New MetroFramework.Controls.MetroLabel()
        Me.lblOBS = New MetroFramework.Controls.MetroLabel()
        Me.tlpOBSSettings = New System.Windows.Forms.TableLayoutPanel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel14 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtGameKey = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.chkGameCtrl = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.cbGameAlt = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.cbGameShift = New MetroFramework.Controls.MetroCheckBox()
        Me.FlowLayoutPanel17 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtAdKey = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.cbAdCtrl = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.cbAdAlt = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.cbAdShift = New MetroFramework.Controls.MetroCheckBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.tmrAnimate = New System.Windows.Forms.Timer(Me.components)
        Me.SettingsToolTip = New MetroFramework.Components.MetroToolTip()
        Me.pnlBottom = New MetroFramework.Controls.MetroPanel()
        Me.lnkDownload = New MetroFramework.Controls.MetroLink()
        Me.lblStatus = New MetroFramework.Controls.MetroLabel()
        Me.lblVersion = New MetroFramework.Controls.MetroLabel()
        Me.spnStreaming = New MetroFramework.Controls.MetroProgressSpinner()
        Me.btnHelp = New MetroFramework.Controls.MetroLink()
        Me.btnMinimize = New MetroFramework.Controls.MetroLink()
        Me.btnMaximize = New MetroFramework.Controls.MetroLink()
        Me.btnClose = New MetroFramework.Controls.MetroLink()
        Me.btnNormal = New MetroFramework.Controls.MetroLink()
        Me.tabMenu.SuspendLayout
        Me.tabGames.SuspendLayout
        Me.tabSettings.SuspendLayout
        Me.tlpSettings.SuspendLayout
        Me.FlowLayoutPanel1.SuspendLayout
        Me.MetroPanel2.SuspendLayout
        Me.MetroPanel1.SuspendLayout
        Me.MetroPanel5.SuspendLayout
        Me.FlowLayoutPanel9.SuspendLayout
        Me.FlowLayoutPanel8.SuspendLayout
        Me.FlowLayoutPanel7.SuspendLayout
        Me.FlowLayoutPanel6.SuspendLayout
        Me.FlowLayoutPanel5.SuspendLayout
        Me.FlowLayoutPanel4.SuspendLayout
        Me.FlowLayoutPanel3.SuspendLayout
        Me.FlowLayoutPanel2.SuspendLayout
        Me.FlowLayoutPanel10.SuspendLayout
        Me.FlowLayoutPanel11.SuspendLayout
        Me.tabConsole.SuspendLayout
        Me.tabAdDetectionModules.SuspendLayout
        Me.flpAdDetector.SuspendLayout
        Me.tabModules.SuspendLayout
        Me.tlpModules.SuspendLayout
        Me.FlowLayoutPanel12.SuspendLayout
        Me.FlowLayoutPanel13.SuspendLayout
        Me.FlowLayoutPanel15.SuspendLayout
        Me.FlowLayoutPanel16.SuspendLayout
        Me.tlpOBSSettings.SuspendLayout
        Me.FlowLayoutPanel14.SuspendLayout
        Me.FlowLayoutPanel17.SuspendLayout
        Me.pnlBottom.SuspendLayout
        Me.SuspendLayout
        '
        'RichTextBox
        '
        Me.RichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.RichTextBox.AutoWordSelection = true
        Me.RichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(42,Byte),Integer), CType(CType(42,Byte),Integer), CType(CType(42,Byte),Integer))
        Me.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.RichTextBox.ForeColor = System.Drawing.Color.White
        Me.RichTextBox.Location = New System.Drawing.Point(6, 12)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ReadOnly = true
        Me.RichTextBox.Size = New System.Drawing.Size(970, 409)
        Me.RichTextBox.TabIndex = 110
        Me.RichTextBox.Text = ""
        '
        'tabMenu
        '
        Me.tabMenu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tabMenu.Controls.Add(Me.tabGames)
        Me.tabMenu.Controls.Add(Me.tabSettings)
        Me.tabMenu.Controls.Add(Me.tabConsole)
        Me.tabMenu.Controls.Add(Me.tabAdDetectionModules)
        Me.tabMenu.Controls.Add(Me.tabModules)
        Me.tabMenu.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabMenu.HotTrack = true
        Me.tabMenu.ItemSize = New System.Drawing.Size(90, 34)
        Me.tabMenu.Location = New System.Drawing.Point(3, 60)
        Me.tabMenu.Name = "tabMenu"
        Me.tabMenu.SelectedIndex = 1
        Me.tabMenu.Size = New System.Drawing.Size(994, 495)
        Me.tabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tabMenu.Style = MetroFramework.MetroColorStyle.Blue
        Me.tabMenu.TabIndex = 10
        Me.tabMenu.UseSelectable = true
        '
        'tabGames
        '
        Me.tabGames.Controls.Add(Me.spnLoading)
        Me.tabGames.Controls.Add(Me.lblDate)
        Me.tabGames.Controls.Add(Me.lblNoGames)
        Me.tabGames.Controls.Add(Me.flpCalender)
        Me.tabGames.Controls.Add(Me.btnRefresh)
        Me.tabGames.Controls.Add(Me.btnYesterday)
        Me.tabGames.Controls.Add(Me.btnTomorrow)
        Me.tabGames.Controls.Add(Me.btnDate)
        Me.tabGames.Controls.Add(Me.flpGames)
        Me.tabGames.Cursor = System.Windows.Forms.Cursors.Default
        Me.tabGames.HorizontalScrollbarBarColor = false
        Me.tabGames.HorizontalScrollbarHighlightOnWheel = false
        Me.tabGames.HorizontalScrollbarSize = 10
        Me.tabGames.Location = New System.Drawing.Point(4, 38)
        Me.tabGames.Name = "tabGames"
        Me.tabGames.Size = New System.Drawing.Size(986, 453)
        Me.tabGames.TabIndex = 0
        Me.tabGames.Text = "Games      "
        Me.tabGames.VerticalScrollbarBarColor = false
        Me.tabGames.VerticalScrollbarHighlightOnWheel = false
        Me.tabGames.VerticalScrollbarSize = 10
        '
        'spnLoading
        '
        Me.spnLoading.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.spnLoading.Backwards = true
        Me.spnLoading.Location = New System.Drawing.Point(292, 461)
        Me.spnLoading.Maximum = 1000
        Me.spnLoading.Name = "spnLoading"
        Me.spnLoading.Size = New System.Drawing.Size(80, 80)
        Me.spnLoading.Speed = 2!
        Me.spnLoading.TabIndex = 0
        Me.spnLoading.UseSelectable = true
        Me.spnLoading.Value = 1
        '
        'lblDate
        '
        Me.lblDate.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblDate.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblDate.ForeColor = System.Drawing.Color.DimGray
        Me.lblDate.Location = New System.Drawing.Point(41, 10)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(215, 37)
        Me.lblDate.TabIndex = 28
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDate.UseCustomForeColor = true
        '
        'lblNoGames
        '
        Me.lblNoGames.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblNoGames.AutoSize = true
        Me.lblNoGames.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblNoGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblNoGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblNoGames.ForeColor = System.Drawing.Color.DimGray
        Me.lblNoGames.Location = New System.Drawing.Point(172, 465)
        Me.lblNoGames.Margin = New System.Windows.Forms.Padding(3)
        Me.lblNoGames.Name = "lblNoGames"
        Me.lblNoGames.Padding = New System.Windows.Forms.Padding(20, 6, 20, 6)
        Me.lblNoGames.Size = New System.Drawing.Size(156, 30)
        Me.lblNoGames.TabIndex = 25
        Me.lblNoGames.Text = "No Games Found"
        Me.lblNoGames.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNoGames.Visible = false
        '
        'flpCalender
        '
        Me.flpCalender.AutoSize = true
        Me.flpCalender.BackColor = System.Drawing.Color.Silver
        Me.flpCalender.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flpCalender.Location = New System.Drawing.Point(34, 53)
        Me.flpCalender.Margin = New System.Windows.Forms.Padding(0)
        Me.flpCalender.Name = "flpCalender"
        Me.flpCalender.Size = New System.Drawing.Size(34, 30)
        Me.flpCalender.TabIndex = 10
        Me.flpCalender.Visible = false
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.BackColor = System.Drawing.Color.DimGray
        Me.btnRefresh.BackgroundImage = Global.NHLGames.My.Resources.Resources.wrefresh
        Me.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(230,Byte),Integer))
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.Location = New System.Drawing.Point(944, 15)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(24, 24)
        Me.btnRefresh.TabIndex = 140
        Me.btnRefresh.UseVisualStyleBackColor = false
        '
        'btnYesterday
        '
        Me.btnYesterday.BackColor = System.Drawing.Color.DimGray
        Me.btnYesterday.BackgroundImage = Global.NHLGames.My.Resources.Resources.wleft
        Me.btnYesterday.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnYesterday.FlatAppearance.BorderSize = 0
        Me.btnYesterday.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnYesterday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnYesterday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(230,Byte),Integer))
        Me.btnYesterday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnYesterday.Location = New System.Drawing.Point(15, 18)
        Me.btnYesterday.Name = "btnYesterday"
        Me.btnYesterday.Size = New System.Drawing.Size(20, 20)
        Me.btnYesterday.TabIndex = 110
        Me.btnYesterday.UseVisualStyleBackColor = false
        '
        'btnTomorrow
        '
        Me.btnTomorrow.BackColor = System.Drawing.Color.DimGray
        Me.btnTomorrow.BackgroundImage = Global.NHLGames.My.Resources.Resources.wright
        Me.btnTomorrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTomorrow.FlatAppearance.BorderSize = 0
        Me.btnTomorrow.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnTomorrow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnTomorrow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(230,Byte),Integer))
        Me.btnTomorrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTomorrow.Location = New System.Drawing.Point(308, 18)
        Me.btnTomorrow.Name = "btnTomorrow"
        Me.btnTomorrow.Size = New System.Drawing.Size(20, 20)
        Me.btnTomorrow.TabIndex = 130
        Me.btnTomorrow.UseVisualStyleBackColor = false
        '
        'btnDate
        '
        Me.btnDate.BackColor = System.Drawing.Color.DimGray
        Me.btnDate.BackgroundImage = Global.NHLGames.My.Resources.Resources.wdate
        Me.btnDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDate.FlatAppearance.BorderSize = 0
        Me.btnDate.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnDate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnDate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(170,Byte),Integer), CType(CType(230,Byte),Integer))
        Me.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.btnDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDate.Location = New System.Drawing.Point(262, 15)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(24, 24)
        Me.btnDate.TabIndex = 120
        Me.btnDate.UseVisualStyleBackColor = false
        '
        'flpGames
        '
        Me.flpGames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.flpGames.AutoScroll = true
        Me.flpGames.BackColor = System.Drawing.Color.White
        Me.flpGames.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.flpGames.Location = New System.Drawing.Point(3, 50)
        Me.flpGames.Name = "flpGames"
        Me.flpGames.Size = New System.Drawing.Size(980, 400)
        Me.flpGames.TabIndex = 1
        '
        'tabSettings
        '
        Me.tabSettings.Controls.Add(Me.tlpSettings)
        Me.tabSettings.HorizontalScrollbarBarColor = false
        Me.tabSettings.HorizontalScrollbarHighlightOnWheel = false
        Me.tabSettings.HorizontalScrollbarSize = 10
        Me.tabSettings.Location = New System.Drawing.Point(4, 38)
        Me.tabSettings.Name = "tabSettings"
        Me.tabSettings.Size = New System.Drawing.Size(986, 453)
        Me.tabSettings.TabIndex = 1
        Me.tabSettings.Text = "Settings      "
        Me.tabSettings.VerticalScrollbarBarColor = false
        Me.tabSettings.VerticalScrollbarHighlightOnWheel = false
        Me.tabSettings.VerticalScrollbarSize = 10
        '
        'tlpSettings
        '
        Me.tlpSettings.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tlpSettings.AutoScroll = true
        Me.tlpSettings.BackColor = System.Drawing.Color.White
        Me.tlpSettings.ColumnCount = 3
        Me.tlpSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel1, 2, 1)
        Me.tlpSettings.Controls.Add(Me.MetroPanel2, 2, 2)
        Me.tlpSettings.Controls.Add(Me.MetroPanel1, 2, 3)
        Me.tlpSettings.Controls.Add(Me.MetroPanel5, 2, 4)
        Me.tlpSettings.Controls.Add(Me.lblStreamerArgs, 0, 16)
        Me.tlpSettings.Controls.Add(Me.lblPlayerArgs, 0, 15)
        Me.tlpSettings.Controls.Add(Me.lblOutput, 0, 14)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel9, 2, 16)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel8, 2, 15)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel7, 2, 14)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel6, 2, 12)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel5, 2, 11)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel4, 2, 10)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel3, 2, 9)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel2, 2, 7)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel10, 2, 6)
        Me.tlpSettings.Controls.Add(Me.lblLanguage, 0, 18)
        Me.tlpSettings.Controls.Add(Me.FlowLayoutPanel11, 2, 18)
        Me.tlpSettings.Controls.Add(Me.lblSlPath, 0, 12)
        Me.tlpSettings.Controls.Add(Me.lblMpvPath, 0, 11)
        Me.tlpSettings.Controls.Add(Me.lblMpcPath, 0, 10)
        Me.tlpSettings.Controls.Add(Me.lblVlcPath, 0, 9)
        Me.tlpSettings.Controls.Add(Me.lblHostname, 0, 6)
        Me.tlpSettings.Controls.Add(Me.lblQuality, 0, 3)
        Me.tlpSettings.Controls.Add(Me.lblCdn, 0, 4)
        Me.tlpSettings.Controls.Add(Me.lblPlayer, 0, 2)
        Me.tlpSettings.Controls.Add(Me.lblShowScores, 0, 1)
        Me.tlpSettings.Controls.Add(Me.lblHosts, 0, 7)
        Me.tlpSettings.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize
        Me.tlpSettings.Location = New System.Drawing.Point(3, 3)
        Me.tlpSettings.Name = "tlpSettings"
        Me.tlpSettings.Padding = New System.Windows.Forms.Padding(3, 3, 15, 3)
        Me.tlpSettings.RowCount = 20
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpSettings.Size = New System.Drawing.Size(980, 450)
        Me.tlpSettings.TabIndex = 64
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowFinalScores)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowLiveScores)
        Me.FlowLayoutPanel1.Controls.Add(Me.chkShowSeriesRecord)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(182, 13)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel1.TabIndex = 64
        '
        'chkShowFinalScores
        '
        Me.chkShowFinalScores.Location = New System.Drawing.Point(3, 3)
        Me.chkShowFinalScores.Name = "chkShowFinalScores"
        Me.chkShowFinalScores.Size = New System.Drawing.Size(150, 15)
        Me.chkShowFinalScores.TabIndex = 110
        Me.chkShowFinalScores.Text = "Final Scores"
        Me.chkShowFinalScores.UseSelectable = true
        '
        'chkShowLiveScores
        '
        Me.chkShowLiveScores.Location = New System.Drawing.Point(159, 3)
        Me.chkShowLiveScores.Name = "chkShowLiveScores"
        Me.chkShowLiveScores.Size = New System.Drawing.Size(150, 15)
        Me.chkShowLiveScores.TabIndex = 120
        Me.chkShowLiveScores.Text = "Live Scores"
        Me.chkShowLiveScores.UseSelectable = true
        '
        'chkShowSeriesRecord
        '
        Me.chkShowSeriesRecord.Checked = true
        Me.chkShowSeriesRecord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkShowSeriesRecord.Location = New System.Drawing.Point(315, 3)
        Me.chkShowSeriesRecord.Name = "chkShowSeriesRecord"
        Me.chkShowSeriesRecord.Size = New System.Drawing.Size(170, 15)
        Me.chkShowSeriesRecord.TabIndex = 130
        Me.chkShowSeriesRecord.Text = "Series record"
        Me.chkShowSeriesRecord.UseSelectable = true
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.rbMpv)
        Me.MetroPanel2.Controls.Add(Me.rbMPC)
        Me.MetroPanel2.Controls.Add(Me.rbVLC)
        Me.MetroPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel2.HorizontalScrollbarBarColor = true
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(182, 43)
        Me.MetroPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(766, 30)
        Me.MetroPanel2.TabIndex = 7
        Me.MetroPanel2.VerticalScrollbarBarColor = true
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = false
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'rbMpv
        '
        Me.rbMpv.AutoSize = true
        Me.rbMpv.Checked = true
        Me.rbMpv.Location = New System.Drawing.Point(111, 4)
        Me.rbMpv.Name = "rbMpv"
        Me.rbMpv.Size = New System.Drawing.Size(48, 15)
        Me.rbMpv.TabIndex = 230
        Me.rbMpv.TabStop = true
        Me.rbMpv.Text = "MPV"
        Me.rbMpv.UseSelectable = true
        '
        'rbMPC
        '
        Me.rbMPC.AutoSize = true
        Me.rbMPC.Location = New System.Drawing.Point(57, 3)
        Me.rbMPC.Name = "rbMPC"
        Me.rbMPC.Size = New System.Drawing.Size(49, 15)
        Me.rbMPC.TabIndex = 220
        Me.rbMPC.Text = "MPC"
        Me.rbMPC.UseSelectable = true
        '
        'rbVLC
        '
        Me.rbVLC.AutoSize = true
        Me.rbVLC.Location = New System.Drawing.Point(3, 3)
        Me.rbVLC.Name = "rbVLC"
        Me.rbVLC.Size = New System.Drawing.Size(44, 15)
        Me.rbVLC.TabIndex = 210
        Me.rbVLC.Text = "VLC"
        Me.rbVLC.UseSelectable = true
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.rbQual6)
        Me.MetroPanel1.Controls.Add(Me.rbQual5)
        Me.MetroPanel1.Controls.Add(Me.rbQual4)
        Me.MetroPanel1.Controls.Add(Me.rbQual3)
        Me.MetroPanel1.Controls.Add(Me.rbQual2)
        Me.MetroPanel1.Controls.Add(Me.chk60)
        Me.MetroPanel1.Controls.Add(Me.rbQual1)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = true
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(182, 73)
        Me.MetroPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(766, 30)
        Me.MetroPanel1.TabIndex = 6
        Me.MetroPanel1.VerticalScrollbarBarColor = true
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = false
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'rbQual6
        '
        Me.rbQual6.AutoSize = true
        Me.rbQual6.Checked = true
        Me.rbQual6.Location = New System.Drawing.Point(273, 4)
        Me.rbQual6.Name = "rbQual6"
        Me.rbQual6.Size = New System.Drawing.Size(48, 15)
        Me.rbQual6.TabIndex = 360
        Me.rbQual6.TabStop = true
        Me.rbQual6.Text = "720p"
        Me.rbQual6.UseSelectable = true
        '
        'rbQual5
        '
        Me.rbQual5.AutoSize = true
        Me.rbQual5.Location = New System.Drawing.Point(219, 4)
        Me.rbQual5.Name = "rbQual5"
        Me.rbQual5.Size = New System.Drawing.Size(48, 15)
        Me.rbQual5.TabIndex = 350
        Me.rbQual5.Text = "540p"
        Me.rbQual5.UseSelectable = true
        '
        'rbQual4
        '
        Me.rbQual4.AutoSize = true
        Me.rbQual4.Location = New System.Drawing.Point(165, 4)
        Me.rbQual4.Name = "rbQual4"
        Me.rbQual4.Size = New System.Drawing.Size(48, 15)
        Me.rbQual4.TabIndex = 340
        Me.rbQual4.Text = "504p"
        Me.rbQual4.UseSelectable = true
        '
        'rbQual3
        '
        Me.rbQual3.AutoSize = true
        Me.rbQual3.Location = New System.Drawing.Point(111, 4)
        Me.rbQual3.Name = "rbQual3"
        Me.rbQual3.Size = New System.Drawing.Size(48, 15)
        Me.rbQual3.TabIndex = 330
        Me.rbQual3.Text = "360p"
        Me.rbQual3.UseSelectable = true
        '
        'rbQual2
        '
        Me.rbQual2.AutoSize = true
        Me.rbQual2.Location = New System.Drawing.Point(57, 4)
        Me.rbQual2.Name = "rbQual2"
        Me.rbQual2.Size = New System.Drawing.Size(48, 15)
        Me.rbQual2.TabIndex = 320
        Me.rbQual2.Text = "228p"
        Me.rbQual2.UseSelectable = true
        '
        'chk60
        '
        Me.chk60.AutoSize = true
        Me.chk60.Checked = true
        Me.chk60.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk60.Location = New System.Drawing.Point(327, 4)
        Me.chk60.Name = "chk60"
        Me.chk60.Size = New System.Drawing.Size(54, 15)
        Me.chk60.TabIndex = 370
        Me.chk60.Text = "60 fps"
        Me.chk60.UseSelectable = true
        '
        'rbQual1
        '
        Me.rbQual1.AutoSize = true
        Me.rbQual1.Location = New System.Drawing.Point(3, 4)
        Me.rbQual1.Name = "rbQual1"
        Me.rbQual1.Size = New System.Drawing.Size(48, 15)
        Me.rbQual1.TabIndex = 310
        Me.rbQual1.Text = "224p"
        Me.rbQual1.UseSelectable = true
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.lblNoteCdn)
        Me.MetroPanel5.Controls.Add(Me.rbAkamai)
        Me.MetroPanel5.Controls.Add(Me.rbLevel3)
        Me.MetroPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel5.HorizontalScrollbarBarColor = true
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = false
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(182, 103)
        Me.MetroPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(766, 30)
        Me.MetroPanel5.TabIndex = 13
        Me.MetroPanel5.VerticalScrollbarBarColor = true
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = false
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'lblNoteCdn
        '
        Me.lblNoteCdn.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblNoteCdn.Location = New System.Drawing.Point(134, 3)
        Me.lblNoteCdn.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNoteCdn.Name = "lblNoteCdn"
        Me.lblNoteCdn.Size = New System.Drawing.Size(693, 15)
        Me.lblNoteCdn.TabIndex = 13
        Me.lblNoteCdn.Text = "Note: Refreshing games is required for CDN change to take effect"
        '
        'rbAkamai
        '
        Me.rbAkamai.AutoSize = true
        Me.rbAkamai.Checked = true
        Me.rbAkamai.Location = New System.Drawing.Point(68, 3)
        Me.rbAkamai.Name = "rbAkamai"
        Me.rbAkamai.Size = New System.Drawing.Size(63, 15)
        Me.rbAkamai.TabIndex = 420
        Me.rbAkamai.TabStop = true
        Me.rbAkamai.Text = "Akamai"
        Me.rbAkamai.UseSelectable = true
        '
        'rbLevel3
        '
        Me.rbLevel3.AutoSize = true
        Me.rbLevel3.Location = New System.Drawing.Point(3, 3)
        Me.rbLevel3.Name = "rbLevel3"
        Me.rbLevel3.Size = New System.Drawing.Size(59, 15)
        Me.rbLevel3.TabIndex = 410
        Me.rbLevel3.Text = "Level 3"
        Me.rbLevel3.UseSelectable = true
        '
        'lblStreamerArgs
        '
        Me.lblStreamerArgs.AutoSize = true
        Me.lblStreamerArgs.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblStreamerArgs.Location = New System.Drawing.Point(70, 463)
        Me.lblStreamerArgs.Margin = New System.Windows.Forms.Padding(0)
        Me.lblStreamerArgs.Name = "lblStreamerArgs"
        Me.lblStreamerArgs.Size = New System.Drawing.Size(92, 30)
        Me.lblStreamerArgs.TabIndex = 6
        Me.lblStreamerArgs.Text = "Streamer args"
        '
        'lblPlayerArgs
        '
        Me.lblPlayerArgs.AutoSize = true
        Me.lblPlayerArgs.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPlayerArgs.Location = New System.Drawing.Point(88, 433)
        Me.lblPlayerArgs.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPlayerArgs.Name = "lblPlayerArgs"
        Me.lblPlayerArgs.Size = New System.Drawing.Size(74, 30)
        Me.lblPlayerArgs.TabIndex = 5
        Me.lblPlayerArgs.Text = "Player args"
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = true
        Me.lblOutput.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblOutput.Location = New System.Drawing.Point(112, 403)
        Me.lblOutput.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(50, 30)
        Me.lblOutput.TabIndex = 4
        Me.lblOutput.Text = "Output"
        '
        'FlowLayoutPanel9
        '
        Me.FlowLayoutPanel9.Controls.Add(Me.txtStreamerArgs)
        Me.FlowLayoutPanel9.Controls.Add(Me.tgStreamer)
        Me.FlowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel9.Location = New System.Drawing.Point(182, 463)
        Me.FlowLayoutPanel9.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel9.Name = "FlowLayoutPanel9"
        Me.FlowLayoutPanel9.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel9.TabIndex = 64
        '
        'txtStreamerArgs
        '
        Me.txtStreamerArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtStreamerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreamerArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtStreamerArgs.Location = New System.Drawing.Point(3, 3)
        Me.txtStreamerArgs.Name = "txtStreamerArgs"
        Me.txtStreamerArgs.Size = New System.Drawing.Size(486, 22)
        Me.txtStreamerArgs.TabIndex = 1310
        '
        'tgStreamer
        '
        Me.tgStreamer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tgStreamer.AutoSize = true
        Me.tgStreamer.Location = New System.Drawing.Point(495, 3)
        Me.tgStreamer.Name = "tgStreamer"
        Me.tgStreamer.Size = New System.Drawing.Size(80, 19)
        Me.tgStreamer.TabIndex = 1320
        Me.tgStreamer.Text = "Off"
        Me.tgStreamer.UseSelectable = true
        '
        'FlowLayoutPanel8
        '
        Me.FlowLayoutPanel8.Controls.Add(Me.txtPlayerArgs)
        Me.FlowLayoutPanel8.Controls.Add(Me.tgPlayer)
        Me.FlowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel8.Location = New System.Drawing.Point(182, 433)
        Me.FlowLayoutPanel8.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel8.Name = "FlowLayoutPanel8"
        Me.FlowLayoutPanel8.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel8.TabIndex = 64
        '
        'txtPlayerArgs
        '
        Me.txtPlayerArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtPlayerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlayerArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtPlayerArgs.Location = New System.Drawing.Point(3, 3)
        Me.txtPlayerArgs.Name = "txtPlayerArgs"
        Me.txtPlayerArgs.Size = New System.Drawing.Size(486, 22)
        Me.txtPlayerArgs.TabIndex = 1210
        '
        'tgPlayer
        '
        Me.tgPlayer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tgPlayer.AutoSize = true
        Me.tgPlayer.Location = New System.Drawing.Point(495, 3)
        Me.tgPlayer.Name = "tgPlayer"
        Me.tgPlayer.Size = New System.Drawing.Size(80, 19)
        Me.tgPlayer.TabIndex = 1220
        Me.tgPlayer.Text = "Off"
        Me.tgPlayer.UseSelectable = true
        '
        'FlowLayoutPanel7
        '
        Me.FlowLayoutPanel7.Controls.Add(Me.txtOutputArgs)
        Me.FlowLayoutPanel7.Controls.Add(Me.btnOuput)
        Me.FlowLayoutPanel7.Controls.Add(Me.tgOutput)
        Me.FlowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel7.Location = New System.Drawing.Point(182, 403)
        Me.FlowLayoutPanel7.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel7.Name = "FlowLayoutPanel7"
        Me.FlowLayoutPanel7.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel7.TabIndex = 64
        '
        'txtOutputArgs
        '
        Me.txtOutputArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOutputArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutputArgs.Enabled = false
        Me.txtOutputArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtOutputArgs.Location = New System.Drawing.Point(3, 3)
        Me.txtOutputArgs.Name = "txtOutputArgs"
        Me.txtOutputArgs.Size = New System.Drawing.Size(451, 22)
        Me.txtOutputArgs.TabIndex = 1110
        '
        'btnOuput
        '
        Me.btnOuput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnOuput.Location = New System.Drawing.Point(460, 3)
        Me.btnOuput.Name = "btnOuput"
        Me.btnOuput.Size = New System.Drawing.Size(28, 20)
        Me.btnOuput.TabIndex = 1120
        Me.btnOuput.Text = "..."
        Me.btnOuput.UseSelectable = true
        '
        'tgOutput
        '
        Me.tgOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tgOutput.AutoSize = true
        Me.tgOutput.Location = New System.Drawing.Point(494, 3)
        Me.tgOutput.Name = "tgOutput"
        Me.tgOutput.Size = New System.Drawing.Size(80, 19)
        Me.tgOutput.TabIndex = 1130
        Me.tgOutput.Text = "Off"
        Me.tgOutput.UseSelectable = true
        '
        'FlowLayoutPanel6
        '
        Me.FlowLayoutPanel6.Controls.Add(Me.txtStreamlinkPath)
        Me.FlowLayoutPanel6.Controls.Add(Me.btnstreamlinkPath)
        Me.FlowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel6.Location = New System.Drawing.Point(182, 343)
        Me.FlowLayoutPanel6.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel6.Name = "FlowLayoutPanel6"
        Me.FlowLayoutPanel6.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel6.TabIndex = 64
        '
        'txtStreamlinkPath
        '
        Me.txtStreamlinkPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtStreamlinkPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreamlinkPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtStreamlinkPath.Location = New System.Drawing.Point(3, 3)
        Me.txtStreamlinkPath.Name = "txtStreamlinkPath"
        Me.txtStreamlinkPath.ReadOnly = true
        Me.txtStreamlinkPath.Size = New System.Drawing.Size(486, 22)
        Me.txtStreamlinkPath.TabIndex = 1010
        '
        'btnstreamlinkPath
        '
        Me.btnstreamlinkPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnstreamlinkPath.Location = New System.Drawing.Point(495, 3)
        Me.btnstreamlinkPath.Name = "btnstreamlinkPath"
        Me.btnstreamlinkPath.Size = New System.Drawing.Size(28, 22)
        Me.btnstreamlinkPath.TabIndex = 1020
        Me.btnstreamlinkPath.Text = "..."
        Me.btnstreamlinkPath.UseSelectable = true
        '
        'FlowLayoutPanel5
        '
        Me.FlowLayoutPanel5.Controls.Add(Me.txtMpvPath)
        Me.FlowLayoutPanel5.Controls.Add(Me.btnMpvPath)
        Me.FlowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel5.Location = New System.Drawing.Point(182, 313)
        Me.FlowLayoutPanel5.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel5.Name = "FlowLayoutPanel5"
        Me.FlowLayoutPanel5.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel5.TabIndex = 64
        '
        'txtMpvPath
        '
        Me.txtMpvPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtMpvPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMpvPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMpvPath.Location = New System.Drawing.Point(3, 3)
        Me.txtMpvPath.Name = "txtMpvPath"
        Me.txtMpvPath.ReadOnly = true
        Me.txtMpvPath.Size = New System.Drawing.Size(486, 22)
        Me.txtMpvPath.TabIndex = 910
        '
        'btnMpvPath
        '
        Me.btnMpvPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMpvPath.Location = New System.Drawing.Point(495, 3)
        Me.btnMpvPath.Name = "btnMpvPath"
        Me.btnMpvPath.Size = New System.Drawing.Size(28, 22)
        Me.btnMpvPath.TabIndex = 920
        Me.btnMpvPath.Text = "..."
        Me.btnMpvPath.UseSelectable = true
        '
        'FlowLayoutPanel4
        '
        Me.FlowLayoutPanel4.Controls.Add(Me.txtMPCPath)
        Me.FlowLayoutPanel4.Controls.Add(Me.btnMPCPath)
        Me.FlowLayoutPanel4.Controls.Add(Me.lnkGetMpc)
        Me.FlowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel4.Location = New System.Drawing.Point(182, 283)
        Me.FlowLayoutPanel4.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel4.Name = "FlowLayoutPanel4"
        Me.FlowLayoutPanel4.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel4.TabIndex = 64
        '
        'txtMPCPath
        '
        Me.txtMPCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtMPCPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMPCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtMPCPath.Location = New System.Drawing.Point(3, 3)
        Me.txtMPCPath.Name = "txtMPCPath"
        Me.txtMPCPath.ReadOnly = true
        Me.txtMPCPath.Size = New System.Drawing.Size(486, 22)
        Me.txtMPCPath.TabIndex = 810
        '
        'btnMPCPath
        '
        Me.btnMPCPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMPCPath.Location = New System.Drawing.Point(495, 3)
        Me.btnMPCPath.Name = "btnMPCPath"
        Me.btnMPCPath.Size = New System.Drawing.Size(28, 22)
        Me.btnMPCPath.TabIndex = 820
        Me.btnMPCPath.Text = "..."
        Me.btnMPCPath.UseSelectable = true
        '
        'lnkGetMpc
        '
        Me.lnkGetMpc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lnkGetMpc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkGetMpc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkGetMpc.ForeColor = System.Drawing.Color.Black
        Me.lnkGetMpc.Image = Global.NHLGames.My.Resources.Resources.download
        Me.lnkGetMpc.Location = New System.Drawing.Point(529, 3)
        Me.lnkGetMpc.Name = "lnkGetMpc"
        Me.lnkGetMpc.Size = New System.Drawing.Size(25, 25)
        Me.lnkGetMpc.TabIndex = 830
        Me.SettingsToolTip.SetToolTip(Me.lnkGetMpc, "Download MPC")
        Me.lnkGetMpc.UseSelectable = true
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.Controls.Add(Me.txtVLCPath)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnVLCPath)
        Me.FlowLayoutPanel3.Controls.Add(Me.lnkGetVlc)
        Me.FlowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(182, 253)
        Me.FlowLayoutPanel3.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel3.TabIndex = 64
        '
        'txtVLCPath
        '
        Me.txtVLCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtVLCPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVLCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtVLCPath.Location = New System.Drawing.Point(3, 3)
        Me.txtVLCPath.Name = "txtVLCPath"
        Me.txtVLCPath.ReadOnly = true
        Me.txtVLCPath.Size = New System.Drawing.Size(486, 22)
        Me.txtVLCPath.TabIndex = 710
        '
        'btnVLCPath
        '
        Me.btnVLCPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnVLCPath.Location = New System.Drawing.Point(495, 3)
        Me.btnVLCPath.Name = "btnVLCPath"
        Me.btnVLCPath.Size = New System.Drawing.Size(28, 22)
        Me.btnVLCPath.TabIndex = 720
        Me.btnVLCPath.Text = "..."
        Me.btnVLCPath.UseSelectable = true
        '
        'lnkGetVlc
        '
        Me.lnkGetVlc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lnkGetVlc.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkGetVlc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkGetVlc.ForeColor = System.Drawing.Color.Black
        Me.lnkGetVlc.Image = Global.NHLGames.My.Resources.Resources.download
        Me.lnkGetVlc.Location = New System.Drawing.Point(529, 3)
        Me.lnkGetVlc.Name = "lnkGetVlc"
        Me.lnkGetVlc.Size = New System.Drawing.Size(25, 25)
        Me.lnkGetVlc.TabIndex = 730
        Me.lnkGetVlc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsToolTip.SetToolTip(Me.lnkGetVlc, "Download VLC")
        Me.lnkGetVlc.UseSelectable = true
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.btnTestHosts)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnOpenHostsFile)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnAddHosts)
        Me.FlowLayoutPanel2.Controls.Add(Me.btnCleanHosts)
        Me.FlowLayoutPanel2.Controls.Add(Me.lnkDiySteps)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(182, 193)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel2.TabIndex = 64
        '
        'btnTestHosts
        '
        Me.btnTestHosts.Location = New System.Drawing.Point(3, 3)
        Me.btnTestHosts.Name = "btnTestHosts"
        Me.btnTestHosts.Size = New System.Drawing.Size(110, 24)
        Me.btnTestHosts.TabIndex = 610
        Me.btnTestHosts.Text = "1) Test"
        Me.SettingsToolTip.SetToolTip(Me.btnTestHosts, "Test the hosts file")
        Me.btnTestHosts.UseSelectable = true
        '
        'btnOpenHostsFile
        '
        Me.btnOpenHostsFile.Location = New System.Drawing.Point(119, 3)
        Me.btnOpenHostsFile.Name = "btnOpenHostsFile"
        Me.btnOpenHostsFile.Size = New System.Drawing.Size(120, 24)
        Me.btnOpenHostsFile.TabIndex = 620
        Me.btnOpenHostsFile.Text = "2) View"
        Me.SettingsToolTip.SetToolTip(Me.btnOpenHostsFile, "View your hosts file")
        Me.btnOpenHostsFile.UseSelectable = true
        '
        'btnAddHosts
        '
        Me.btnAddHosts.Location = New System.Drawing.Point(245, 3)
        Me.btnAddHosts.Name = "btnAddHosts"
        Me.btnAddHosts.Size = New System.Drawing.Size(120, 24)
        Me.btnAddHosts.TabIndex = 630
        Me.btnAddHosts.Text = "3) Add"
        Me.SettingsToolTip.SetToolTip(Me.btnAddHosts, "Add our server to your hosts file")
        Me.btnAddHosts.UseSelectable = true
        '
        'btnCleanHosts
        '
        Me.btnCleanHosts.Location = New System.Drawing.Point(371, 3)
        Me.btnCleanHosts.Name = "btnCleanHosts"
        Me.btnCleanHosts.Size = New System.Drawing.Size(120, 24)
        Me.btnCleanHosts.TabIndex = 640
        Me.btnCleanHosts.Text = "4) Clean"
        Me.SettingsToolTip.SetToolTip(Me.btnCleanHosts, "Remove our server from your hosts file")
        Me.btnCleanHosts.UseSelectable = true
        '
        'lnkDiySteps
        '
        Me.lnkDiySteps.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkDiySteps.ForeColor = System.Drawing.Color.Black
        Me.lnkDiySteps.Image = Global.NHLGames.My.Resources.Resources.helpgit
        Me.lnkDiySteps.Location = New System.Drawing.Point(497, 3)
        Me.lnkDiySteps.Name = "lnkDiySteps"
        Me.lnkDiySteps.Size = New System.Drawing.Size(20, 20)
        Me.lnkDiySteps.TabIndex = 61
        Me.lnkDiySteps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SettingsToolTip.SetToolTip(Me.lnkDiySteps, "DIY Steps")
        Me.lnkDiySteps.UseSelectable = true
        '
        'FlowLayoutPanel10
        '
        Me.FlowLayoutPanel10.Controls.Add(Me.cbServers)
        Me.FlowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel10.Location = New System.Drawing.Point(182, 163)
        Me.FlowLayoutPanel10.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel10.Name = "FlowLayoutPanel10"
        Me.FlowLayoutPanel10.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel10.TabIndex = 68
        '
        'cbServers
        '
        Me.cbServers.BackColor = System.Drawing.SystemColors.Window
        Me.cbServers.DropDownHeight = 80
        Me.cbServers.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbServers.FormattingEnabled = true
        Me.cbServers.IntegralHeight = false
        Me.cbServers.ItemHeight = 19
        Me.cbServers.Location = New System.Drawing.Point(3, 3)
        Me.cbServers.Name = "cbServers"
        Me.cbServers.Size = New System.Drawing.Size(486, 25)
        Me.cbServers.TabIndex = 510
        Me.cbServers.UseSelectable = true
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = true
        Me.lblLanguage.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblLanguage.Location = New System.Drawing.Point(96, 523)
        Me.lblLanguage.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(66, 30)
        Me.lblLanguage.TabIndex = 69
        Me.lblLanguage.Text = "Language"
        '
        'FlowLayoutPanel11
        '
        Me.FlowLayoutPanel11.Controls.Add(Me.cbLanguage)
        Me.FlowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel11.Location = New System.Drawing.Point(182, 523)
        Me.FlowLayoutPanel11.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel11.Name = "FlowLayoutPanel11"
        Me.FlowLayoutPanel11.Size = New System.Drawing.Size(766, 30)
        Me.FlowLayoutPanel11.TabIndex = 70
        '
        'cbLanguage
        '
        Me.cbLanguage.BackColor = System.Drawing.SystemColors.Window
        Me.cbLanguage.DropDownHeight = 80
        Me.cbLanguage.FontSize = MetroFramework.MetroComboBoxSize.Small
        Me.cbLanguage.FormattingEnabled = true
        Me.cbLanguage.IntegralHeight = false
        Me.cbLanguage.ItemHeight = 19
        Me.cbLanguage.Location = New System.Drawing.Point(3, 3)
        Me.cbLanguage.Name = "cbLanguage"
        Me.cbLanguage.Size = New System.Drawing.Size(486, 25)
        Me.cbLanguage.TabIndex = 1410
        Me.cbLanguage.UseSelectable = true
        '
        'lblSlPath
        '
        Me.lblSlPath.AutoSize = true
        Me.lblSlPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSlPath.Location = New System.Drawing.Point(63, 343)
        Me.lblSlPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSlPath.Name = "lblSlPath"
        Me.lblSlPath.Size = New System.Drawing.Size(99, 30)
        Me.lblSlPath.TabIndex = 47
        Me.lblSlPath.Text = "Streamlink Path"
        '
        'lblMpvPath
        '
        Me.lblMpvPath.AutoSize = true
        Me.lblMpvPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMpvPath.Location = New System.Drawing.Point(96, 313)
        Me.lblMpvPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMpvPath.Name = "lblMpvPath"
        Me.lblMpvPath.Size = New System.Drawing.Size(66, 30)
        Me.lblMpvPath.TabIndex = 52
        Me.lblMpvPath.Text = "MPV Path"
        '
        'lblMpcPath
        '
        Me.lblMpcPath.AutoSize = true
        Me.lblMpcPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblMpcPath.Location = New System.Drawing.Point(95, 283)
        Me.lblMpcPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblMpcPath.Name = "lblMpcPath"
        Me.lblMpcPath.Size = New System.Drawing.Size(67, 30)
        Me.lblMpcPath.TabIndex = 44
        Me.lblMpcPath.Text = "MPC Path"
        '
        'lblVlcPath
        '
        Me.lblVlcPath.AutoSize = true
        Me.lblVlcPath.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblVlcPath.Location = New System.Drawing.Point(102, 253)
        Me.lblVlcPath.Margin = New System.Windows.Forms.Padding(0)
        Me.lblVlcPath.Name = "lblVlcPath"
        Me.lblVlcPath.Size = New System.Drawing.Size(60, 30)
        Me.lblVlcPath.TabIndex = 43
        Me.lblVlcPath.Text = "VLC Path"
        '
        'lblHostname
        '
        Me.lblHostname.AutoSize = true
        Me.lblHostname.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblHostname.Location = New System.Drawing.Point(45, 163)
        Me.lblHostname.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHostname.Name = "lblHostname"
        Me.lblHostname.Size = New System.Drawing.Size(117, 30)
        Me.lblHostname.TabIndex = 68
        Me.lblHostname.Text = "Server's Hostname"
        '
        'lblQuality
        '
        Me.lblQuality.AutoSize = true
        Me.lblQuality.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblQuality.Location = New System.Drawing.Point(66, 73)
        Me.lblQuality.Margin = New System.Windows.Forms.Padding(0)
        Me.lblQuality.Name = "lblQuality"
        Me.lblQuality.Size = New System.Drawing.Size(96, 30)
        Me.lblQuality.TabIndex = 2
        Me.lblQuality.Text = "Stream Quality"
        '
        'lblCdn
        '
        Me.lblCdn.AutoSize = true
        Me.lblCdn.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblCdn.Location = New System.Drawing.Point(3, 103)
        Me.lblCdn.Margin = New System.Windows.Forms.Padding(0)
        Me.lblCdn.Name = "lblCdn"
        Me.lblCdn.Size = New System.Drawing.Size(159, 30)
        Me.lblCdn.TabIndex = 3
        Me.lblCdn.Text = "Content Delivery Network"
        '
        'lblPlayer
        '
        Me.lblPlayer.AutoSize = true
        Me.lblPlayer.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblPlayer.Location = New System.Drawing.Point(72, 43)
        Me.lblPlayer.Margin = New System.Windows.Forms.Padding(0)
        Me.lblPlayer.Name = "lblPlayer"
        Me.lblPlayer.Size = New System.Drawing.Size(90, 30)
        Me.lblPlayer.TabIndex = 3
        Me.lblPlayer.Text = "Default Player"
        '
        'lblShowScores
        '
        Me.lblShowScores.AutoSize = true
        Me.lblShowScores.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblShowScores.Location = New System.Drawing.Point(80, 13)
        Me.lblShowScores.Margin = New System.Windows.Forms.Padding(0)
        Me.lblShowScores.Name = "lblShowScores"
        Me.lblShowScores.Size = New System.Drawing.Size(82, 30)
        Me.lblShowScores.TabIndex = 57
        Me.lblShowScores.Text = "Show Scores"
        '
        'lblHosts
        '
        Me.lblHosts.AutoSize = true
        Me.lblHosts.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblHosts.Location = New System.Drawing.Point(46, 193)
        Me.lblHosts.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHosts.Name = "lblHosts"
        Me.lblHosts.Size = New System.Drawing.Size(116, 30)
        Me.lblHosts.TabIndex = 66
        Me.lblHosts.Text = "Server Hosts Entry"
        '
        'tabConsole
        '
        Me.tabConsole.Controls.Add(Me.btnCopyConsole)
        Me.tabConsole.Controls.Add(Me.btnClearConsole)
        Me.tabConsole.Controls.Add(Me.RichTextBox)
        Me.tabConsole.HorizontalScrollbarBarColor = false
        Me.tabConsole.HorizontalScrollbarHighlightOnWheel = false
        Me.tabConsole.HorizontalScrollbarSize = 10
        Me.tabConsole.Location = New System.Drawing.Point(4, 38)
        Me.tabConsole.Name = "tabConsole"
        Me.tabConsole.Size = New System.Drawing.Size(986, 453)
        Me.tabConsole.TabIndex = 2
        Me.tabConsole.Text = "Console      "
        Me.tabConsole.VerticalScrollbarBarColor = false
        Me.tabConsole.VerticalScrollbarHighlightOnWheel = false
        Me.tabConsole.VerticalScrollbarSize = 10
        '
        'btnCopyConsole
        '
        Me.btnCopyConsole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnCopyConsole.Location = New System.Drawing.Point(641, 427)
        Me.btnCopyConsole.Name = "btnCopyConsole"
        Me.btnCopyConsole.Size = New System.Drawing.Size(200, 23)
        Me.btnCopyConsole.TabIndex = 120
        Me.btnCopyConsole.Text = "Copy to clipboard"
        Me.btnCopyConsole.UseSelectable = true
        '
        'btnClearConsole
        '
        Me.btnClearConsole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnClearConsole.Location = New System.Drawing.Point(847, 427)
        Me.btnClearConsole.Name = "btnClearConsole"
        Me.btnClearConsole.Size = New System.Drawing.Size(129, 23)
        Me.btnClearConsole.TabIndex = 130
        Me.btnClearConsole.Text = "Clear"
        Me.btnClearConsole.UseSelectable = true
        '
        'tabAdDetectionModules
        '
        Me.tabAdDetectionModules.Controls.Add(Me.flpAdDetector)
        Me.tabAdDetectionModules.HorizontalScrollbarBarColor = false
        Me.tabAdDetectionModules.HorizontalScrollbarHighlightOnWheel = false
        Me.tabAdDetectionModules.HorizontalScrollbarSize = 10
        Me.tabAdDetectionModules.Location = New System.Drawing.Point(4, 38)
        Me.tabAdDetectionModules.Name = "tabAdDetectionModules"
        Me.tabAdDetectionModules.Size = New System.Drawing.Size(986, 453)
        Me.tabAdDetectionModules.TabIndex = 4
        Me.tabAdDetectionModules.Text = "Modules"
        Me.tabAdDetectionModules.VerticalScrollbarBarColor = false
        Me.tabAdDetectionModules.VerticalScrollbarHighlightOnWheel = false
        Me.tabAdDetectionModules.VerticalScrollbarSize = 10
        '
        'flpAdDetector
        '
        Me.flpAdDetector.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.flpAdDetector.BackColor = System.Drawing.Color.White
        Me.flpAdDetector.Controls.Add(Me.AdDetectionSettingsElementHost)
        Me.flpAdDetector.Location = New System.Drawing.Point(3, 3)
        Me.flpAdDetector.Margin = New System.Windows.Forms.Padding(0)
        Me.flpAdDetector.Name = "flpAdDetector"
        Me.flpAdDetector.Size = New System.Drawing.Size(980, 450)
        Me.flpAdDetector.TabIndex = 3
        '
        'AdDetectionSettingsElementHost
        '
        Me.AdDetectionSettingsElementHost.AutoSize = true
        Me.AdDetectionSettingsElementHost.BackColor = System.Drawing.Color.White
        Me.AdDetectionSettingsElementHost.BackColorTransparent = true
        Me.AdDetectionSettingsElementHost.Location = New System.Drawing.Point(2, 2)
        Me.AdDetectionSettingsElementHost.Margin = New System.Windows.Forms.Padding(2)
        Me.AdDetectionSettingsElementHost.Name = "AdDetectionSettingsElementHost"
        Me.AdDetectionSettingsElementHost.Size = New System.Drawing.Size(1, 1)
        Me.AdDetectionSettingsElementHost.TabIndex = 2
        Me.AdDetectionSettingsElementHost.Child = Nothing
        '
        'tabModules
        '
        Me.tabModules.Controls.Add(Me.tlpModules)
        Me.tabModules.HorizontalScrollbarBarColor = false
        Me.tabModules.HorizontalScrollbarHighlightOnWheel = false
        Me.tabModules.HorizontalScrollbarSize = 10
        Me.tabModules.Location = New System.Drawing.Point(4, 38)
        Me.tabModules.Name = "tabModules"
        Me.tabModules.Size = New System.Drawing.Size(986, 453)
        Me.tabModules.TabIndex = 5
        Me.tabModules.Text = "Modules"
        Me.tabModules.VerticalScrollbarBarColor = false
        Me.tabModules.VerticalScrollbarHighlightOnWheel = false
        Me.tabModules.VerticalScrollbarSize = 10
        '
        'tlpModules
        '
        Me.tlpModules.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tlpModules.AutoScroll = true
        Me.tlpModules.BackColor = System.Drawing.Color.White
        Me.tlpModules.ColumnCount = 3
        Me.tlpModules.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpModules.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpModules.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpModules.Controls.Add(Me.lblModules, 0, 1)
        Me.tlpModules.Controls.Add(Me.FlowLayoutPanel12, 2, 1)
        Me.tlpModules.Controls.Add(Me.FlowLayoutPanel13, 2, 2)
        Me.tlpModules.Controls.Add(Me.FlowLayoutPanel15, 2, 5)
        Me.tlpModules.Controls.Add(Me.FlowLayoutPanel16, 2, 6)
        Me.tlpModules.Controls.Add(Me.FlowLayoutPanel18, 2, 8)
        Me.tlpModules.Controls.Add(Me.lblDetectionType, 0, 2)
        Me.tlpModules.Controls.Add(Me.lblSpotify, 0, 5)
        Me.tlpModules.Controls.Add(Me.lblOBS, 0, 6)
        Me.tlpModules.Controls.Add(Me.tlpOBSSettings, 2, 7)
        Me.tlpModules.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tlpModules.Location = New System.Drawing.Point(3, 3)
        Me.tlpModules.Name = "tlpModules"
        Me.tlpModules.RowCount = 9
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10!))
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpModules.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80!))
        Me.tlpModules.Size = New System.Drawing.Size(980, 450)
        Me.tlpModules.TabIndex = 2
        '
        'lblModules
        '
        Me.lblModules.AutoSize = true
        Me.lblModules.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblModules.Location = New System.Drawing.Point(3, 13)
        Me.lblModules.Margin = New System.Windows.Forms.Padding(3)
        Me.lblModules.Name = "lblModules"
        Me.lblModules.Size = New System.Drawing.Size(139, 24)
        Me.lblModules.TabIndex = 58
        Me.lblModules.Text = "Ad Detection Modules"
        '
        'FlowLayoutPanel12
        '
        Me.FlowLayoutPanel12.Controls.Add(Me.tgModules)
        Me.FlowLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel12.Location = New System.Drawing.Point(165, 10)
        Me.FlowLayoutPanel12.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel12.Name = "FlowLayoutPanel12"
        Me.FlowLayoutPanel12.Size = New System.Drawing.Size(815, 30)
        Me.FlowLayoutPanel12.TabIndex = 59
        '
        'tgModules
        '
        Me.tgModules.AutoSize = true
        Me.tgModules.Location = New System.Drawing.Point(3, 3)
        Me.tgModules.Name = "tgModules"
        Me.tgModules.Size = New System.Drawing.Size(80, 19)
        Me.tgModules.TabIndex = 0
        Me.tgModules.Text = "Off"
        Me.tgModules.UseSelectable = true
        '
        'FlowLayoutPanel13
        '
        Me.FlowLayoutPanel13.AutoSize = true
        Me.FlowLayoutPanel13.Controls.Add(Me.rbVolumeDetection)
        Me.FlowLayoutPanel13.Controls.Add(Me.rbFullscreenDetection)
        Me.FlowLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel13.Location = New System.Drawing.Point(165, 40)
        Me.FlowLayoutPanel13.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel13.Name = "FlowLayoutPanel13"
        Me.FlowLayoutPanel13.Size = New System.Drawing.Size(815, 42)
        Me.FlowLayoutPanel13.TabIndex = 60
        '
        'rbVolumeDetection
        '
        Me.rbVolumeDetection.AutoSize = true
        Me.rbVolumeDetection.Checked = true
        Me.FlowLayoutPanel13.SetFlowBreak(Me.rbVolumeDetection, true)
        Me.rbVolumeDetection.Location = New System.Drawing.Point(3, 3)
        Me.rbVolumeDetection.Name = "rbVolumeDetection"
        Me.rbVolumeDetection.Size = New System.Drawing.Size(493, 15)
        Me.rbVolumeDetection.TabIndex = 0
        Me.rbVolumeDetection.TabStop = true
        Me.rbVolumeDetection.Text = "Volume : Detects ads based on the volume of your media player instances playing g"& _ 
    "ames."
        Me.rbVolumeDetection.UseSelectable = true
        '
        'rbFullscreenDetection
        '
        Me.rbFullscreenDetection.AutoSize = true
        Me.rbFullscreenDetection.Location = New System.Drawing.Point(3, 24)
        Me.rbFullscreenDetection.Name = "rbFullscreenDetection"
        Me.rbFullscreenDetection.Size = New System.Drawing.Size(447, 15)
        Me.rbFullscreenDetection.TabIndex = 1
        Me.rbFullscreenDetection.Text = "Fullscreen : Detects ads based on ''NHL GameCenter'' frames while in fullscreen. "& _ 
    ""
        Me.rbFullscreenDetection.UseSelectable = true
        '
        'FlowLayoutPanel15
        '
        Me.FlowLayoutPanel15.Controls.Add(Me.tgSpotify)
        Me.FlowLayoutPanel15.Controls.Add(Me.lblSpotifyDesc)
        Me.FlowLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel15.Location = New System.Drawing.Point(165, 142)
        Me.FlowLayoutPanel15.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel15.Name = "FlowLayoutPanel15"
        Me.FlowLayoutPanel15.Size = New System.Drawing.Size(815, 30)
        Me.FlowLayoutPanel15.TabIndex = 62
        '
        'tgSpotify
        '
        Me.tgSpotify.AutoSize = true
        Me.tgSpotify.Location = New System.Drawing.Point(3, 3)
        Me.tgSpotify.Name = "tgSpotify"
        Me.tgSpotify.Size = New System.Drawing.Size(80, 19)
        Me.tgSpotify.TabIndex = 0
        Me.tgSpotify.Text = "Off"
        Me.tgSpotify.UseSelectable = true
        '
        'lblSpotifyDesc
        '
        Me.lblSpotifyDesc.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblSpotifyDesc.Location = New System.Drawing.Point(86, 0)
        Me.lblSpotifyDesc.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSpotifyDesc.Name = "lblSpotifyDesc"
        Me.lblSpotifyDesc.Size = New System.Drawing.Size(706, 27)
        Me.lblSpotifyDesc.TabIndex = 1
        Me.lblSpotifyDesc.Text = "Play/Pause your Spotify playlist when an Ad is detected."
        Me.lblSpotifyDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel16
        '
        Me.FlowLayoutPanel16.Controls.Add(Me.tgOBS)
        Me.FlowLayoutPanel16.Controls.Add(Me.lblOBSDesc)
        Me.FlowLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel16.Location = New System.Drawing.Point(165, 172)
        Me.FlowLayoutPanel16.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel16.Name = "FlowLayoutPanel16"
        Me.FlowLayoutPanel16.Size = New System.Drawing.Size(815, 30)
        Me.FlowLayoutPanel16.TabIndex = 63
        '
        'tgOBS
        '
        Me.tgOBS.AutoSize = true
        Me.tgOBS.Location = New System.Drawing.Point(3, 3)
        Me.tgOBS.Name = "tgOBS"
        Me.tgOBS.Size = New System.Drawing.Size(80, 19)
        Me.tgOBS.TabIndex = 0
        Me.tgOBS.Text = "Off"
        Me.tgOBS.UseSelectable = true
        '
        'lblOBSDesc
        '
        Me.lblOBSDesc.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblOBSDesc.Location = New System.Drawing.Point(86, 0)
        Me.lblOBSDesc.Margin = New System.Windows.Forms.Padding(0)
        Me.lblOBSDesc.Name = "lblOBSDesc"
        Me.lblOBSDesc.Size = New System.Drawing.Size(706, 27)
        Me.lblOBSDesc.TabIndex = 1
        Me.lblOBSDesc.Text = "Emulates pressing the keys you configured to switch between scenes when an Ad is "& _ 
    "detected. "
        Me.lblOBSDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FlowLayoutPanel18
        '
        Me.FlowLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel18.Location = New System.Drawing.Point(165, 262)
        Me.FlowLayoutPanel18.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel18.Name = "FlowLayoutPanel18"
        Me.FlowLayoutPanel18.Size = New System.Drawing.Size(815, 188)
        Me.FlowLayoutPanel18.TabIndex = 65
        '
        'lblDetectionType
        '
        Me.lblDetectionType.AutoSize = true
        Me.lblDetectionType.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDetectionType.Location = New System.Drawing.Point(47, 43)
        Me.lblDetectionType.Margin = New System.Windows.Forms.Padding(3)
        Me.lblDetectionType.Name = "lblDetectionType"
        Me.lblDetectionType.Size = New System.Drawing.Size(95, 36)
        Me.lblDetectionType.TabIndex = 69
        Me.lblDetectionType.Text = "Detection Type"
        '
        'lblSpotify
        '
        Me.lblSpotify.AutoSize = true
        Me.lblSpotify.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblSpotify.Location = New System.Drawing.Point(64, 145)
        Me.lblSpotify.Margin = New System.Windows.Forms.Padding(3)
        Me.lblSpotify.Name = "lblSpotify"
        Me.lblSpotify.Size = New System.Drawing.Size(78, 24)
        Me.lblSpotify.TabIndex = 71
        Me.lblSpotify.Text = "Spotify App"
        '
        'lblOBS
        '
        Me.lblOBS.AutoSize = true
        Me.lblOBS.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblOBS.Location = New System.Drawing.Point(15, 175)
        Me.lblOBS.Margin = New System.Windows.Forms.Padding(3)
        Me.lblOBS.Name = "lblOBS"
        Me.lblOBS.Size = New System.Drawing.Size(127, 24)
        Me.lblOBS.TabIndex = 72
        Me.lblOBS.Text = "OBS Scene Changer"
        '
        'tlpOBSSettings
        '
        Me.tlpOBSSettings.AutoSize = true
        Me.tlpOBSSettings.ColumnCount = 2
        Me.tlpOBSSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpOBSSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100!))
        Me.tlpOBSSettings.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20!))
        Me.tlpOBSSettings.Controls.Add(Me.MetroLabel1, 0, 0)
        Me.tlpOBSSettings.Controls.Add(Me.MetroLabel2, 0, 1)
        Me.tlpOBSSettings.Controls.Add(Me.FlowLayoutPanel14, 1, 0)
        Me.tlpOBSSettings.Controls.Add(Me.FlowLayoutPanel17, 1, 1)
        Me.tlpOBSSettings.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpOBSSettings.Location = New System.Drawing.Point(165, 202)
        Me.tlpOBSSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.tlpOBSSettings.Name = "tlpOBSSettings"
        Me.tlpOBSSettings.RowCount = 2
        Me.tlpOBSSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpOBSSettings.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30!))
        Me.tlpOBSSettings.Size = New System.Drawing.Size(815, 60)
        Me.tlpOBSSettings.TabIndex = 73
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = true
        Me.MetroLabel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 3)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(3)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(124, 24)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Game Scene hotkey"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = true
        Me.MetroLabel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.MetroLabel2.Location = New System.Drawing.Point(21, 33)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(3)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(106, 24)
        Me.MetroLabel2.TabIndex = 1
        Me.MetroLabel2.Text = "Ad Scene hotkey"
        '
        'FlowLayoutPanel14
        '
        Me.FlowLayoutPanel14.Controls.Add(Me.txtGameKey)
        Me.FlowLayoutPanel14.Controls.Add(Me.MetroLabel6)
        Me.FlowLayoutPanel14.Controls.Add(Me.chkGameCtrl)
        Me.FlowLayoutPanel14.Controls.Add(Me.MetroLabel5)
        Me.FlowLayoutPanel14.Controls.Add(Me.cbGameAlt)
        Me.FlowLayoutPanel14.Controls.Add(Me.MetroLabel7)
        Me.FlowLayoutPanel14.Controls.Add(Me.cbGameShift)
        Me.FlowLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel14.Location = New System.Drawing.Point(130, 0)
        Me.FlowLayoutPanel14.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel14.Name = "FlowLayoutPanel14"
        Me.FlowLayoutPanel14.Size = New System.Drawing.Size(685, 30)
        Me.FlowLayoutPanel14.TabIndex = 2
        '
        'txtGameKey
        '
        '
        '
        '
        Me.txtGameKey.CustomButton.Image = Nothing
        Me.txtGameKey.CustomButton.Location = New System.Drawing.Point(1, 1)
        Me.txtGameKey.CustomButton.Name = ""
        Me.txtGameKey.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGameKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGameKey.CustomButton.TabIndex = 1
        Me.txtGameKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGameKey.CustomButton.UseSelectable = true
        Me.txtGameKey.CustomButton.Visible = false
        Me.txtGameKey.Enabled = false
        Me.txtGameKey.Lines = New String(-1) {}
        Me.txtGameKey.Location = New System.Drawing.Point(3, 3)
        Me.txtGameKey.MaxLength = 1
        Me.txtGameKey.Name = "txtGameKey"
        Me.txtGameKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGameKey.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGameKey.SelectedText = ""
        Me.txtGameKey.SelectionLength = 0
        Me.txtGameKey.SelectionStart = 0
        Me.txtGameKey.ShortcutsEnabled = true
        Me.txtGameKey.Size = New System.Drawing.Size(23, 23)
        Me.txtGameKey.TabIndex = 2
        Me.txtGameKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtGameKey.UseSelectable = true
        Me.txtGameKey.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtGameKey.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = true
        Me.MetroLabel6.Location = New System.Drawing.Point(32, 3)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(3)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel6.TabIndex = 3
        Me.MetroLabel6.Text = "+"
        '
        'chkGameCtrl
        '
        Me.chkGameCtrl.AutoSize = true
        Me.chkGameCtrl.Enabled = false
        Me.chkGameCtrl.Location = New System.Drawing.Point(56, 6)
        Me.chkGameCtrl.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.chkGameCtrl.Name = "chkGameCtrl"
        Me.chkGameCtrl.Size = New System.Drawing.Size(51, 15)
        Me.chkGameCtrl.TabIndex = 4
        Me.chkGameCtrl.Text = "CTRL"
        Me.chkGameCtrl.UseSelectable = true
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = true
        Me.MetroLabel5.Location = New System.Drawing.Point(113, 3)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(3)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel5.TabIndex = 5
        Me.MetroLabel5.Text = "+"
        '
        'cbGameAlt
        '
        Me.cbGameAlt.AutoSize = true
        Me.cbGameAlt.Enabled = false
        Me.cbGameAlt.Location = New System.Drawing.Point(137, 6)
        Me.cbGameAlt.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.cbGameAlt.Name = "cbGameAlt"
        Me.cbGameAlt.Size = New System.Drawing.Size(43, 15)
        Me.cbGameAlt.TabIndex = 6
        Me.cbGameAlt.Text = "ALT"
        Me.cbGameAlt.UseSelectable = true
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = true
        Me.MetroLabel7.Location = New System.Drawing.Point(186, 3)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(3)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel7.TabIndex = 7
        Me.MetroLabel7.Text = "+"
        '
        'cbGameShift
        '
        Me.cbGameShift.AutoSize = true
        Me.cbGameShift.Enabled = false
        Me.cbGameShift.Location = New System.Drawing.Point(210, 6)
        Me.cbGameShift.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.cbGameShift.Name = "cbGameShift"
        Me.cbGameShift.Size = New System.Drawing.Size(54, 15)
        Me.cbGameShift.TabIndex = 8
        Me.cbGameShift.Text = "SHIFT"
        Me.cbGameShift.UseSelectable = true
        '
        'FlowLayoutPanel17
        '
        Me.FlowLayoutPanel17.Controls.Add(Me.txtAdKey)
        Me.FlowLayoutPanel17.Controls.Add(Me.MetroLabel3)
        Me.FlowLayoutPanel17.Controls.Add(Me.cbAdCtrl)
        Me.FlowLayoutPanel17.Controls.Add(Me.MetroLabel4)
        Me.FlowLayoutPanel17.Controls.Add(Me.cbAdAlt)
        Me.FlowLayoutPanel17.Controls.Add(Me.MetroLabel8)
        Me.FlowLayoutPanel17.Controls.Add(Me.cbAdShift)
        Me.FlowLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel17.Location = New System.Drawing.Point(130, 30)
        Me.FlowLayoutPanel17.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel17.Name = "FlowLayoutPanel17"
        Me.FlowLayoutPanel17.Size = New System.Drawing.Size(685, 30)
        Me.FlowLayoutPanel17.TabIndex = 3
        '
        'txtAdKey
        '
        '
        '
        '
        Me.txtAdKey.CustomButton.Image = Nothing
        Me.txtAdKey.CustomButton.Location = New System.Drawing.Point(1, 1)
        Me.txtAdKey.CustomButton.Name = ""
        Me.txtAdKey.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtAdKey.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAdKey.CustomButton.TabIndex = 1
        Me.txtAdKey.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAdKey.CustomButton.UseSelectable = true
        Me.txtAdKey.CustomButton.Visible = false
        Me.txtAdKey.Enabled = false
        Me.txtAdKey.Lines = New String(-1) {}
        Me.txtAdKey.Location = New System.Drawing.Point(3, 3)
        Me.txtAdKey.MaxLength = 1
        Me.txtAdKey.Name = "txtAdKey"
        Me.txtAdKey.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAdKey.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAdKey.SelectedText = ""
        Me.txtAdKey.SelectionLength = 0
        Me.txtAdKey.SelectionStart = 0
        Me.txtAdKey.ShortcutsEnabled = true
        Me.txtAdKey.Size = New System.Drawing.Size(23, 23)
        Me.txtAdKey.TabIndex = 3
        Me.txtAdKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAdKey.UseSelectable = true
        Me.txtAdKey.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer), CType(CType(109,Byte),Integer))
        Me.txtAdKey.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = true
        Me.MetroLabel3.Location = New System.Drawing.Point(32, 3)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(3)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "+"
        '
        'cbAdCtrl
        '
        Me.cbAdCtrl.AutoSize = true
        Me.cbAdCtrl.Enabled = false
        Me.cbAdCtrl.Location = New System.Drawing.Point(56, 6)
        Me.cbAdCtrl.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.cbAdCtrl.Name = "cbAdCtrl"
        Me.cbAdCtrl.Size = New System.Drawing.Size(51, 15)
        Me.cbAdCtrl.TabIndex = 5
        Me.cbAdCtrl.Text = "CTRL"
        Me.cbAdCtrl.UseSelectable = true
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = true
        Me.MetroLabel4.Location = New System.Drawing.Point(113, 3)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(3)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel4.TabIndex = 6
        Me.MetroLabel4.Text = "+"
        '
        'cbAdAlt
        '
        Me.cbAdAlt.AutoSize = true
        Me.cbAdAlt.Enabled = false
        Me.cbAdAlt.Location = New System.Drawing.Point(137, 6)
        Me.cbAdAlt.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.cbAdAlt.Name = "cbAdAlt"
        Me.cbAdAlt.Size = New System.Drawing.Size(43, 15)
        Me.cbAdAlt.TabIndex = 7
        Me.cbAdAlt.Text = "ALT"
        Me.cbAdAlt.UseSelectable = true
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = true
        Me.MetroLabel8.Location = New System.Drawing.Point(186, 3)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(3)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(18, 19)
        Me.MetroLabel8.TabIndex = 8
        Me.MetroLabel8.Text = "+"
        '
        'cbAdShift
        '
        Me.cbAdShift.AutoSize = true
        Me.cbAdShift.Enabled = false
        Me.cbAdShift.Location = New System.Drawing.Point(210, 6)
        Me.cbAdShift.Margin = New System.Windows.Forms.Padding(3, 6, 3, 3)
        Me.cbAdShift.Name = "cbAdShift"
        Me.cbAdShift.Size = New System.Drawing.Size(54, 15)
        Me.cbAdShift.TabIndex = 9
        Me.cbAdShift.Text = "SHIFT"
        Me.cbAdShift.UseSelectable = true
        '
        'tmrAnimate
        '
        Me.tmrAnimate.Enabled = true
        '
        'SettingsToolTip
        '
        Me.SettingsToolTip.Style = MetroFramework.MetroColorStyle.Blue
        Me.SettingsToolTip.StyleManager = Nothing
        Me.SettingsToolTip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'pnlBottom
        '
        Me.pnlBottom.BackColor = System.Drawing.Color.LightGray
        Me.pnlBottom.Controls.Add(Me.lnkDownload)
        Me.pnlBottom.Controls.Add(Me.lblStatus)
        Me.pnlBottom.Controls.Add(Me.lblVersion)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.HorizontalScrollbarBarColor = true
        Me.pnlBottom.HorizontalScrollbarHighlightOnWheel = false
        Me.pnlBottom.HorizontalScrollbarSize = 10
        Me.pnlBottom.Location = New System.Drawing.Point(3, 554)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(994, 43)
        Me.pnlBottom.TabIndex = 27
        Me.pnlBottom.UseCustomBackColor = true
        Me.pnlBottom.VerticalScrollbarBarColor = true
        Me.pnlBottom.VerticalScrollbarHighlightOnWheel = false
        Me.pnlBottom.VerticalScrollbarSize = 10
        '
        'lnkDownload
        '
        Me.lnkDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkDownload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(155,Byte),Integer), CType(CType(255,Byte),Integer))
        Me.lnkDownload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkDownload.Location = New System.Drawing.Point(65, 3)
        Me.lnkDownload.Name = "lnkDownload"
        Me.lnkDownload.Size = New System.Drawing.Size(148, 35)
        Me.lnkDownload.TabIndex = 20
        Me.lnkDownload.Text = "/r/nhl_games"
        Me.lnkDownload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkDownload.UseCustomBackColor = true
        Me.lnkDownload.UseSelectable = true
        '
        'lblStatus
        '
        Me.lblStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblStatus.BackColor = System.Drawing.Color.LightGray
        Me.lblStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblStatus.ForeColor = System.Drawing.Color.Black
        Me.lblStatus.Location = New System.Drawing.Point(784, 3)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(194, 35)
        Me.lblStatus.TabIndex = 26
        Me.lblStatus.Text = "Status"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblStatus.UseCustomBackColor = true
        Me.lblStatus.UseCustomForeColor = true
        '
        'lblVersion
        '
        Me.lblVersion.BackColor = System.Drawing.Color.LightGray
        Me.lblVersion.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblVersion.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.lblVersion.Location = New System.Drawing.Point(10, 3)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(62, 35)
        Me.lblVersion.TabIndex = 62
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVersion.UseCustomBackColor = true
        Me.lblVersion.UseCustomForeColor = true
        '
        'spnStreaming
        '
        Me.spnStreaming.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.spnStreaming.Backwards = true
        Me.spnStreaming.Location = New System.Drawing.Point(925, 36)
        Me.spnStreaming.Maximum = 1000
        Me.spnStreaming.Name = "spnStreaming"
        Me.spnStreaming.Size = New System.Drawing.Size(50, 50)
        Me.spnStreaming.Speed = 2!
        Me.spnStreaming.TabIndex = 4
        Me.spnStreaming.UseSelectable = true
        Me.spnStreaming.Value = 1000
        Me.spnStreaming.Visible = false
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Image = Global.NHLGames.My.Resources.Resources.helpgit
        Me.btnHelp.ImageSize = 12
        Me.btnHelp.Location = New System.Drawing.Point(887, 5)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(28, 24)
        Me.btnHelp.TabIndex = 9999
        Me.btnHelp.UseSelectable = true
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.Image = Global.NHLGames.My.Resources.Resources.minimize
        Me.btnMinimize.ImageSize = 12
        Me.btnMinimize.Location = New System.Drawing.Point(915, 5)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.Size = New System.Drawing.Size(28, 24)
        Me.btnMinimize.TabIndex = 9999
        Me.btnMinimize.UseCustomBackColor = true
        Me.btnMinimize.UseSelectable = true
        '
        'btnMaximize
        '
        Me.btnMaximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMaximize.Image = Global.NHLGames.My.Resources.Resources.maximize
        Me.btnMaximize.ImageSize = 12
        Me.btnMaximize.Location = New System.Drawing.Point(941, 5)
        Me.btnMaximize.Margin = New System.Windows.Forms.Padding(6)
        Me.btnMaximize.Name = "btnMaximize"
        Me.btnMaximize.Size = New System.Drawing.Size(28, 24)
        Me.btnMaximize.TabIndex = 9999
        Me.btnMaximize.UseSelectable = true
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnClose.Image = Global.NHLGames.My.Resources.Resources.close
        Me.btnClose.ImageSize = 12
        Me.btnClose.Location = New System.Drawing.Point(967, 5)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(30, 24)
        Me.btnClose.TabIndex = 9999
        Me.btnClose.UseSelectable = true
        '
        'btnNormal
        '
        Me.btnNormal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnNormal.Image = Global.NHLGames.My.Resources.Resources.normal
        Me.btnNormal.ImageSize = 12
        Me.btnNormal.Location = New System.Drawing.Point(942, 5)
        Me.btnNormal.Name = "btnNormal"
        Me.btnNormal.Size = New System.Drawing.Size(25, 25)
        Me.btnNormal.TabIndex = 69
        Me.btnNormal.UseSelectable = true
        Me.btnNormal.Visible = false
        '
        'NHLGamesMetro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackImage = Global.NHLGames.My.Resources.Resources.bg
        Me.BackImagePadding = New System.Windows.Forms.Padding(12, 12, 0, 0)
        Me.BackMaxSize = 150
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.spnStreaming)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnMaximize)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.tabMenu)
        Me.Controls.Add(Me.btnNormal)
        Me.Font = New System.Drawing.Font("Segoe UI", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Close
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.MinimumSize = New System.Drawing.Size(800, 500)
        Me.Name = "NHLGamesMetro"
        Me.Padding = New System.Windows.Forms.Padding(3, 60, 3, 3)
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.tabMenu.ResumeLayout(false)
        Me.tabGames.ResumeLayout(false)
        Me.tabGames.PerformLayout
        Me.tabSettings.ResumeLayout(false)
        Me.tlpSettings.ResumeLayout(false)
        Me.tlpSettings.PerformLayout
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.MetroPanel2.ResumeLayout(false)
        Me.MetroPanel2.PerformLayout
        Me.MetroPanel1.ResumeLayout(false)
        Me.MetroPanel1.PerformLayout
        Me.MetroPanel5.ResumeLayout(false)
        Me.MetroPanel5.PerformLayout
        Me.FlowLayoutPanel9.ResumeLayout(false)
        Me.FlowLayoutPanel9.PerformLayout
        Me.FlowLayoutPanel8.ResumeLayout(false)
        Me.FlowLayoutPanel8.PerformLayout
        Me.FlowLayoutPanel7.ResumeLayout(false)
        Me.FlowLayoutPanel7.PerformLayout
        Me.FlowLayoutPanel6.ResumeLayout(false)
        Me.FlowLayoutPanel6.PerformLayout
        Me.FlowLayoutPanel5.ResumeLayout(false)
        Me.FlowLayoutPanel5.PerformLayout
        Me.FlowLayoutPanel4.ResumeLayout(false)
        Me.FlowLayoutPanel4.PerformLayout
        Me.FlowLayoutPanel3.ResumeLayout(false)
        Me.FlowLayoutPanel3.PerformLayout
        Me.FlowLayoutPanel2.ResumeLayout(false)
        Me.FlowLayoutPanel10.ResumeLayout(false)
        Me.FlowLayoutPanel11.ResumeLayout(false)
        Me.tabConsole.ResumeLayout(false)
        Me.tabAdDetectionModules.ResumeLayout(false)
        Me.flpAdDetector.ResumeLayout(false)
        Me.flpAdDetector.PerformLayout
        Me.tabModules.ResumeLayout(false)
        Me.tlpModules.ResumeLayout(false)
        Me.tlpModules.PerformLayout
        Me.FlowLayoutPanel12.ResumeLayout(false)
        Me.FlowLayoutPanel12.PerformLayout
        Me.FlowLayoutPanel13.ResumeLayout(false)
        Me.FlowLayoutPanel13.PerformLayout
        Me.FlowLayoutPanel15.ResumeLayout(false)
        Me.FlowLayoutPanel15.PerformLayout
        Me.FlowLayoutPanel16.ResumeLayout(false)
        Me.FlowLayoutPanel16.PerformLayout
        Me.tlpOBSSettings.ResumeLayout(false)
        Me.tlpOBSSettings.PerformLayout
        Me.FlowLayoutPanel14.ResumeLayout(false)
        Me.FlowLayoutPanel14.PerformLayout
        Me.FlowLayoutPanel17.ResumeLayout(false)
        Me.FlowLayoutPanel17.PerformLayout
        Me.pnlBottom.ResumeLayout(false)
        Me.ResumeLayout(false)

End Sub
    Friend WithEvents RichTextBox As RichTextBox
    Friend WithEvents tabMenu As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabGames As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabSettings As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabConsole As MetroFramework.Controls.MetroTabPage
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btnClearConsole As MetroButton
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents tabAdDetectionModules As MetroTabPage
    Friend WithEvents AdDetectionSettingsElementHost As Integration.ElementHost
    Friend WithEvents btnDate As Button
    Friend WithEvents btnTomorrow As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents tmrAnimate As Timer
    Friend WithEvents flpGames As FlowLayoutPanel
    Friend WithEvents flpCalender As FlowLayoutPanel
    Friend WithEvents lblNoGames As Label
    Friend WithEvents SettingsToolTip As MetroFramework.Components.MetroToolTip
    Friend WithEvents btnClose As MetroLink
    Friend WithEvents btnMaximize As MetroLink
    Friend WithEvents btnMinimize As MetroLink
    Friend WithEvents btnHelp As MetroLink
    Friend WithEvents btnNormal As MetroLink
    Friend WithEvents btnYesterday As Button
    Friend WithEvents lblDate As MetroLabel
    Friend WithEvents pnlBottom As MetroPanel
    Friend WithEvents lnkDownload As MetroLink
    Friend WithEvents lblStatus As MetroLabel
    Friend WithEvents lblVersion As MetroLabel
    Friend WithEvents flpAdDetector As FlowLayoutPanel
    Friend WithEvents btnCopyConsole As MetroButton
    Friend WithEvents spnStreaming As MetroProgressSpinner
    Friend WithEvents spnLoading As MetroProgressSpinner
    Friend WithEvents tlpSettings As TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents chkShowFinalScores As MetroCheckBox
    Friend WithEvents chkShowLiveScores As MetroCheckBox
    Friend WithEvents chkShowSeriesRecord As MetroCheckBox
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents rbMpv As MetroRadioButton
    Friend WithEvents rbMPC As MetroRadioButton
    Friend WithEvents rbVLC As MetroRadioButton
    Friend WithEvents MetroPanel1 As MetroPanel
    Friend WithEvents rbQual6 As MetroRadioButton
    Friend WithEvents rbQual5 As MetroRadioButton
    Friend WithEvents rbQual4 As MetroRadioButton
    Friend WithEvents rbQual3 As MetroRadioButton
    Friend WithEvents rbQual2 As MetroRadioButton
    Friend WithEvents chk60 As MetroCheckBox
    Friend WithEvents rbQual1 As MetroRadioButton
    Friend WithEvents MetroPanel5 As MetroPanel
    Friend WithEvents lblNoteCdn As MetroLabel
    Friend WithEvents rbAkamai As MetroRadioButton
    Friend WithEvents rbLevel3 As MetroRadioButton
    Friend WithEvents lblStreamerArgs As MetroLabel
    Friend WithEvents lblPlayerArgs As MetroLabel
    Friend WithEvents lblOutput As MetroLabel
    Friend WithEvents FlowLayoutPanel9 As FlowLayoutPanel
    Friend WithEvents txtStreamerArgs As TextBox
    Friend WithEvents tgStreamer As MetroToggle
    Friend WithEvents FlowLayoutPanel8 As FlowLayoutPanel
    Friend WithEvents txtPlayerArgs As TextBox
    Friend WithEvents tgPlayer As MetroToggle
    Friend WithEvents FlowLayoutPanel7 As FlowLayoutPanel
    Friend WithEvents txtOutputArgs As TextBox
    Friend WithEvents btnOuput As MetroButton
    Friend WithEvents tgOutput As MetroToggle
    Friend WithEvents FlowLayoutPanel6 As FlowLayoutPanel
    Friend WithEvents txtStreamlinkPath As TextBox
    Friend WithEvents btnstreamlinkPath As MetroButton
    Friend WithEvents FlowLayoutPanel5 As FlowLayoutPanel
    Friend WithEvents txtMpvPath As TextBox
    Friend WithEvents btnMpvPath As MetroButton
    Friend WithEvents FlowLayoutPanel4 As FlowLayoutPanel
    Friend WithEvents txtMPCPath As TextBox
    Friend WithEvents btnMPCPath As MetroButton
    Friend WithEvents lnkGetMpc As MetroLink
    Friend WithEvents FlowLayoutPanel3 As FlowLayoutPanel
    Friend WithEvents txtVLCPath As TextBox
    Friend WithEvents btnVLCPath As MetroButton
    Friend WithEvents lnkGetVlc As MetroLink
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents btnTestHosts As MetroButton
    Friend WithEvents btnOpenHostsFile As MetroButton
    Friend WithEvents btnAddHosts As MetroButton
    Friend WithEvents btnCleanHosts As MetroButton
    Friend WithEvents lnkDiySteps As MetroLink
    Friend WithEvents FlowLayoutPanel10 As FlowLayoutPanel
    Friend WithEvents cbServers As MetroComboBox
    Friend WithEvents lblLanguage As MetroLabel
    Friend WithEvents FlowLayoutPanel11 As FlowLayoutPanel
    Friend WithEvents cbLanguage As MetroComboBox
    Friend WithEvents lblSlPath As MetroLabel
    Friend WithEvents lblMpvPath As MetroLabel
    Friend WithEvents lblMpcPath As MetroLabel
    Friend WithEvents lblVlcPath As MetroLabel
    Friend WithEvents lblHosts As MetroLabel
    Friend WithEvents lblHostname As MetroLabel
    Friend WithEvents lblQuality As MetroLabel
    Friend WithEvents lblCdn As MetroLabel
    Friend WithEvents lblPlayer As MetroLabel
    Friend WithEvents lblShowScores As MetroLabel
    Friend WithEvents tabModules As MetroTabPage
    Friend WithEvents tlpModules As TableLayoutPanel
    Friend WithEvents lblModules As MetroLabel
    Friend WithEvents FlowLayoutPanel12 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel13 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel15 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel16 As FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel18 As FlowLayoutPanel
    Friend WithEvents tgModules As MetroToggle
    Friend WithEvents rbVolumeDetection As MetroRadioButton
    Friend WithEvents rbFullscreenDetection As MetroRadioButton
    Friend WithEvents lblDetectionType As MetroLabel
    Friend WithEvents tgSpotify As MetroToggle
    Friend WithEvents lblSpotifyDesc As MetroLabel
    Friend WithEvents tgOBS As MetroToggle
    Friend WithEvents lblOBSDesc As MetroLabel
    Friend WithEvents lblSpotify As MetroLabel
    Friend WithEvents lblOBS As MetroLabel
    Friend WithEvents tlpOBSSettings As TableLayoutPanel
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents FlowLayoutPanel14 As FlowLayoutPanel
    Friend WithEvents txtGameKey As MetroTextBox
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents chkGameCtrl As MetroCheckBox
    Friend WithEvents MetroLabel5 As MetroLabel
    Friend WithEvents cbGameAlt As MetroCheckBox
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents cbGameShift As MetroCheckBox
    Friend WithEvents FlowLayoutPanel17 As FlowLayoutPanel
    Friend WithEvents txtAdKey As MetroTextBox
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents cbAdCtrl As MetroCheckBox
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents cbAdAlt As MetroCheckBox
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents cbAdShift As MetroCheckBox
End Class
