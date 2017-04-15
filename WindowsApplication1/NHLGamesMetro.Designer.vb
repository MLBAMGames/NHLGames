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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NHLGamesMetro))
        Me.gridGames = New System.Windows.Forms.DataGridView()
        Me.dtDate = New MetroFramework.Controls.MetroDateTime()
        Me.btnRefresh = New MetroFramework.Controls.MetroButton()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabControl = New MetroFramework.Controls.MetroTabControl()
        Me.GamesTab = New MetroFramework.Controls.MetroTabPage()
        Me.btnTomorrow = New MetroFramework.Controls.MetroButton()
        Me.btnYesterday = New MetroFramework.Controls.MetroButton()
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SettingTab = New MetroFramework.Controls.MetroTabPage()
        Me.btnClean = New MetroFramework.Controls.MetroButton()
        Me.btnMpvPath = New MetroFramework.Controls.MetroButton()
        Me.txtMpvPath = New System.Windows.Forms.TextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.chkEnableStreamArgs = New MetroFramework.Controls.MetroCheckBox()
        Me.txtStreamerArgs = New System.Windows.Forms.TextBox()
        Me.chkEnablePlayerArgs = New MetroFramework.Controls.MetroCheckBox()
        Me.chkEnableOutput = New MetroFramework.Controls.MetroCheckBox()
        Me.txtPlayerArgs = New System.Windows.Forms.TextBox()
        Me.txtOutputPath = New System.Windows.Forms.TextBox()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.lnkMpvDownload = New MetroFramework.Controls.MetroLink()
        Me.rbMpv = New MetroFramework.Controls.MetroRadioButton()
        Me.lnkMPCDownload = New MetroFramework.Controls.MetroLink()
        Me.lnkVLCDownload = New MetroFramework.Controls.MetroLink()
        Me.rbMPC = New MetroFramework.Controls.MetroRadioButton()
        Me.rbVLC = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.lblNote = New MetroFramework.Controls.MetroLabel()
        Me.rbAkamai = New MetroFramework.Controls.MetroRadioButton()
        Me.rbLevel3 = New MetroFramework.Controls.MetroRadioButton()
        Me.btnLiveStreamerPath = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.rbQual6 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual5 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual4 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual3 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual2 = New MetroFramework.Controls.MetroRadioButton()
        Me.chk60 = New MetroFramework.Controls.MetroCheckBox()
        Me.rbQual1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.btnMPCPath = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnVLCPath = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.txtLiveStreamPath = New System.Windows.Forms.TextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtMPCPath = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtVLCPath = New System.Windows.Forms.TextBox()
        Me.btnOpenHostsFile = New MetroFramework.Controls.MetroButton()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.btnHosts = New MetroFramework.Controls.MetroButton()
        Me.ConsoleTab = New MetroFramework.Controls.MetroTabPage()
        Me.btnClearConsole = New MetroFramework.Controls.MetroButton()
        Me.AdDetectionSettingsTab = New MetroFramework.Controls.MetroTabPage()
        Me.AdDetectionSettingsElementHost = New System.Windows.Forms.Integration.ElementHost()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.lnkDownload = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnAddHosts = New MetroFramework.Controls.MetroButton()
        CType(Me.gridGames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.GamesTab.SuspendLayout()
        Me.SettingTab.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel5.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.ConsoleTab.SuspendLayout()
        Me.AdDetectionSettingsTab.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridGames
        '
        Me.gridGames.AllowUserToAddRows = False
        Me.gridGames.AllowUserToDeleteRows = False
        Me.gridGames.AllowUserToResizeColumns = False
        Me.gridGames.AllowUserToResizeRows = False
        Me.gridGames.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gridGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridGames.BackgroundColor = System.Drawing.Color.White
        Me.gridGames.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.gridGames.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridGames.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridGames.ColumnHeadersHeight = 30
        Me.gridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.gridGames.Location = New System.Drawing.Point(204, 12)
        Me.gridGames.MultiSelect = False
        Me.gridGames.Name = "gridGames"
        Me.gridGames.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridGames.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gridGames.RowHeadersVisible = False
        Me.gridGames.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridGames.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.gridGames.RowTemplate.DividerHeight = 1
        Me.gridGames.RowTemplate.Height = 35
        Me.gridGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridGames.Size = New System.Drawing.Size(544, 66)
        Me.gridGames.TabIndex = 0
        Me.gridGames.Visible = False
        '
        'dtDate
        '
        Me.dtDate.Checked = False
        Me.dtDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(23, 6)
        Me.dtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtDate.Size = New System.Drawing.Size(125, 29)
        Me.dtDate.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Location = New System.Drawing.Point(883, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 22)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseSelectable = True
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(728, 44)
        Me.lblVersion.MinimumSize = New System.Drawing.Size(200, 5)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(200, 13)
        Me.lblVersion.TabIndex = 17
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RichTextBox
        '
        Me.RichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RichTextBox.AutoWordSelection = True
        Me.RichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox.ForeColor = System.Drawing.Color.White
        Me.RichTextBox.Location = New System.Drawing.Point(3, 20)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ReadOnly = True
        Me.RichTextBox.Size = New System.Drawing.Size(1016, 419)
        Me.RichTextBox.TabIndex = 0
        Me.RichTextBox.Text = "Console Output..." & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.GamesTab)
        Me.TabControl.Controls.Add(Me.SettingTab)
        Me.TabControl.Controls.Add(Me.ConsoleTab)
        Me.TabControl.Controls.Add(Me.AdDetectionSettingsTab)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(10, 60)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 1
        Me.TabControl.Size = New System.Drawing.Size(1030, 540)
        Me.TabControl.TabIndex = 22
        Me.TabControl.UseSelectable = True
        '
        'GamesTab
        '
        Me.GamesTab.Controls.Add(Me.btnTomorrow)
        Me.GamesTab.Controls.Add(Me.btnYesterday)
        Me.GamesTab.Controls.Add(Me.FlowLayoutPanel)
        Me.GamesTab.Controls.Add(Me.gridGames)
        Me.GamesTab.Controls.Add(Me.btnRefresh)
        Me.GamesTab.Controls.Add(Me.dtDate)
        Me.GamesTab.HorizontalScrollbarBarColor = True
        Me.GamesTab.HorizontalScrollbarHighlightOnWheel = False
        Me.GamesTab.HorizontalScrollbarSize = 10
        Me.GamesTab.Location = New System.Drawing.Point(4, 38)
        Me.GamesTab.Name = "GamesTab"
        Me.GamesTab.Size = New System.Drawing.Size(1022, 498)
        Me.GamesTab.TabIndex = 0
        Me.GamesTab.Text = "Games      "
        Me.GamesTab.VerticalScrollbarBarColor = True
        Me.GamesTab.VerticalScrollbarHighlightOnWheel = False
        Me.GamesTab.VerticalScrollbarSize = 10
        '
        'btnTomorrow
        '
        Me.btnTomorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTomorrow.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnTomorrow.Location = New System.Drawing.Point(148, 6)
        Me.btnTomorrow.Name = "btnTomorrow"
        Me.btnTomorrow.Size = New System.Drawing.Size(20, 29)
        Me.btnTomorrow.TabIndex = 8
        Me.btnTomorrow.Text = ">"
        Me.btnTomorrow.UseSelectable = True
        '
        'btnYesterday
        '
        Me.btnYesterday.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYesterday.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnYesterday.Location = New System.Drawing.Point(2, 6)
        Me.btnYesterday.Name = "btnYesterday"
        Me.btnYesterday.Size = New System.Drawing.Size(20, 29)
        Me.btnYesterday.TabIndex = 7
        Me.btnYesterday.Text = "<"
        Me.btnYesterday.UseSelectable = True
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel.AutoScroll = True
        Me.FlowLayoutPanel.AutoSize = True
        Me.FlowLayoutPanel.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(3, 41)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(1023, 456)
        Me.FlowLayoutPanel.TabIndex = 6
        '
        'SettingTab
        '
        Me.SettingTab.Controls.Add(Me.btnAddHosts)
        Me.SettingTab.Controls.Add(Me.btnClean)
        Me.SettingTab.Controls.Add(Me.btnMpvPath)
        Me.SettingTab.Controls.Add(Me.txtMpvPath)
        Me.SettingTab.Controls.Add(Me.MetroLabel1)
        Me.SettingTab.Controls.Add(Me.MetroButton1)
        Me.SettingTab.Controls.Add(Me.chkEnableStreamArgs)
        Me.SettingTab.Controls.Add(Me.txtStreamerArgs)
        Me.SettingTab.Controls.Add(Me.chkEnablePlayerArgs)
        Me.SettingTab.Controls.Add(Me.chkEnableOutput)
        Me.SettingTab.Controls.Add(Me.txtPlayerArgs)
        Me.SettingTab.Controls.Add(Me.txtOutputPath)
        Me.SettingTab.Controls.Add(Me.MetroPanel2)
        Me.SettingTab.Controls.Add(Me.MetroPanel5)
        Me.SettingTab.Controls.Add(Me.btnLiveStreamerPath)
        Me.SettingTab.Controls.Add(Me.MetroLabel8)
        Me.SettingTab.Controls.Add(Me.MetroPanel1)
        Me.SettingTab.Controls.Add(Me.MetroLabel9)
        Me.SettingTab.Controls.Add(Me.MetroLabel10)
        Me.SettingTab.Controls.Add(Me.btnMPCPath)
        Me.SettingTab.Controls.Add(Me.MetroLabel6)
        Me.SettingTab.Controls.Add(Me.btnVLCPath)
        Me.SettingTab.Controls.Add(Me.MetroLabel4)
        Me.SettingTab.Controls.Add(Me.MetroLabel11)
        Me.SettingTab.Controls.Add(Me.txtLiveStreamPath)
        Me.SettingTab.Controls.Add(Me.MetroLabel7)
        Me.SettingTab.Controls.Add(Me.txtMPCPath)
        Me.SettingTab.Controls.Add(Me.MetroLabel3)
        Me.SettingTab.Controls.Add(Me.MetroLabel2)
        Me.SettingTab.Controls.Add(Me.txtVLCPath)
        Me.SettingTab.Controls.Add(Me.btnOpenHostsFile)
        Me.SettingTab.Controls.Add(Me.MetroCheckBox1)
        Me.SettingTab.Controls.Add(Me.btnHosts)
        Me.SettingTab.HorizontalScrollbarBarColor = True
        Me.SettingTab.HorizontalScrollbarHighlightOnWheel = False
        Me.SettingTab.HorizontalScrollbarSize = 10
        Me.SettingTab.Location = New System.Drawing.Point(4, 38)
        Me.SettingTab.Name = "SettingTab"
        Me.SettingTab.Size = New System.Drawing.Size(1022, 498)
        Me.SettingTab.TabIndex = 1
        Me.SettingTab.Text = "Settings      "
        Me.SettingTab.VerticalScrollbarBarColor = True
        Me.SettingTab.VerticalScrollbarHighlightOnWheel = False
        Me.SettingTab.VerticalScrollbarSize = 10
        '
        'btnClean
        '
        Me.btnClean.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClean.Location = New System.Drawing.Point(343, 140)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(118, 24)
        Me.btnClean.TabIndex = 55
        Me.btnClean.Text = "Remove Hosts Entry"
        Me.btnClean.UseSelectable = True
        '
        'btnMpvPath
        '
        Me.btnMpvPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMpvPath.Location = New System.Drawing.Point(629, 86)
        Me.btnMpvPath.Name = "btnMpvPath"
        Me.btnMpvPath.Size = New System.Drawing.Size(28, 20)
        Me.btnMpvPath.TabIndex = 54
        Me.btnMpvPath.Text = "..."
        Me.btnMpvPath.UseSelectable = True
        '
        'txtMpvPath
        '
        Me.txtMpvPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMpvPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMpvPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMpvPath.Location = New System.Drawing.Point(136, 84)
        Me.txtMpvPath.Name = "txtMpvPath"
        Me.txtMpvPath.ReadOnly = True
        Me.txtMpvPath.Size = New System.Drawing.Size(486, 22)
        Me.txtMpvPath.TabIndex = 53
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(17, 84)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel1.TabIndex = 52
        Me.MetroLabel1.Text = "mpv Path"
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(594, 274)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(28, 20)
        Me.MetroButton1.TabIndex = 51
        Me.MetroButton1.Text = "..."
        Me.MetroButton1.UseSelectable = True
        '
        'chkEnableStreamArgs
        '
        Me.chkEnableStreamArgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEnableStreamArgs.AutoSize = True
        Me.chkEnableStreamArgs.Location = New System.Drawing.Point(630, 333)
        Me.chkEnableStreamArgs.Name = "chkEnableStreamArgs"
        Me.chkEnableStreamArgs.Size = New System.Drawing.Size(58, 15)
        Me.chkEnableStreamArgs.TabIndex = 9
        Me.chkEnableStreamArgs.Text = "Enable"
        Me.chkEnableStreamArgs.UseSelectable = True
        '
        'txtStreamerArgs
        '
        Me.txtStreamerArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtStreamerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreamerArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreamerArgs.Location = New System.Drawing.Point(137, 328)
        Me.txtStreamerArgs.Name = "txtStreamerArgs"
        Me.txtStreamerArgs.Size = New System.Drawing.Size(486, 22)
        Me.txtStreamerArgs.TabIndex = 16
        '
        'chkEnablePlayerArgs
        '
        Me.chkEnablePlayerArgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEnablePlayerArgs.AutoSize = True
        Me.chkEnablePlayerArgs.Location = New System.Drawing.Point(630, 305)
        Me.chkEnablePlayerArgs.Name = "chkEnablePlayerArgs"
        Me.chkEnablePlayerArgs.Size = New System.Drawing.Size(58, 15)
        Me.chkEnablePlayerArgs.TabIndex = 8
        Me.chkEnablePlayerArgs.Text = "Enable"
        Me.chkEnablePlayerArgs.UseSelectable = True
        '
        'chkEnableOutput
        '
        Me.chkEnableOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkEnableOutput.AutoSize = True
        Me.chkEnableOutput.Location = New System.Drawing.Point(630, 277)
        Me.chkEnableOutput.Name = "chkEnableOutput"
        Me.chkEnableOutput.Size = New System.Drawing.Size(58, 15)
        Me.chkEnableOutput.TabIndex = 7
        Me.chkEnableOutput.Text = "Enable"
        Me.chkEnableOutput.UseSelectable = True
        '
        'txtPlayerArgs
        '
        Me.txtPlayerArgs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPlayerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlayerArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerArgs.Location = New System.Drawing.Point(137, 300)
        Me.txtPlayerArgs.Name = "txtPlayerArgs"
        Me.txtPlayerArgs.Size = New System.Drawing.Size(486, 22)
        Me.txtPlayerArgs.TabIndex = 15
        '
        'txtOutputPath
        '
        Me.txtOutputPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutputPath.Enabled = False
        Me.txtOutputPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputPath.Location = New System.Drawing.Point(137, 272)
        Me.txtOutputPath.Name = "txtOutputPath"
        Me.txtOutputPath.Size = New System.Drawing.Size(451, 22)
        Me.txtOutputPath.TabIndex = 14
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.lnkMpvDownload)
        Me.MetroPanel2.Controls.Add(Me.rbMpv)
        Me.MetroPanel2.Controls.Add(Me.lnkMPCDownload)
        Me.MetroPanel2.Controls.Add(Me.lnkVLCDownload)
        Me.MetroPanel2.Controls.Add(Me.rbMPC)
        Me.MetroPanel2.Controls.Add(Me.rbVLC)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(137, 216)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(486, 22)
        Me.MetroPanel2.TabIndex = 7
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'lnkMpvDownload
        '
        Me.lnkMpvDownload.AutoSize = True
        Me.lnkMpvDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkMpvDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMpvDownload.Location = New System.Drawing.Point(219, -1)
        Me.lnkMpvDownload.Name = "lnkMpvDownload"
        Me.lnkMpvDownload.Size = New System.Drawing.Size(23, 23)
        Me.lnkMpvDownload.TabIndex = 20
        Me.lnkMpvDownload.Text = "?"
        Me.lnkMpvDownload.UseSelectable = True
        '
        'rbMpv
        '
        Me.rbMpv.AutoSize = True
        Me.rbMpv.Checked = True
        Me.rbMpv.Location = New System.Drawing.Point(166, 3)
        Me.rbMpv.Name = "rbMpv"
        Me.rbMpv.Size = New System.Drawing.Size(47, 15)
        Me.rbMpv.TabIndex = 19
        Me.rbMpv.TabStop = True
        Me.rbMpv.Text = "mpv"
        Me.rbMpv.UseSelectable = True
        '
        'lnkMPCDownload
        '
        Me.lnkMPCDownload.AutoSize = True
        Me.lnkMPCDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkMPCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMPCDownload.Location = New System.Drawing.Point(137, -1)
        Me.lnkMPCDownload.Name = "lnkMPCDownload"
        Me.lnkMPCDownload.Size = New System.Drawing.Size(23, 23)
        Me.lnkMPCDownload.TabIndex = 18
        Me.lnkMPCDownload.Text = "?"
        Me.lnkMPCDownload.UseSelectable = True
        '
        'lnkVLCDownload
        '
        Me.lnkVLCDownload.AutoSize = True
        Me.lnkVLCDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkVLCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkVLCDownload.Location = New System.Drawing.Point(53, -1)
        Me.lnkVLCDownload.Name = "lnkVLCDownload"
        Me.lnkVLCDownload.Size = New System.Drawing.Size(23, 23)
        Me.lnkVLCDownload.TabIndex = 17
        Me.lnkVLCDownload.Text = "?"
        Me.lnkVLCDownload.UseSelectable = True
        '
        'rbMPC
        '
        Me.rbMPC.AutoSize = True
        Me.rbMPC.Location = New System.Drawing.Point(82, 3)
        Me.rbMPC.Name = "rbMPC"
        Me.rbMPC.Size = New System.Drawing.Size(49, 15)
        Me.rbMPC.TabIndex = 16
        Me.rbMPC.Text = "MPC"
        Me.rbMPC.UseSelectable = True
        '
        'rbVLC
        '
        Me.rbVLC.AutoSize = True
        Me.rbVLC.Location = New System.Drawing.Point(3, 3)
        Me.rbVLC.Name = "rbVLC"
        Me.rbVLC.Size = New System.Drawing.Size(44, 15)
        Me.rbVLC.TabIndex = 15
        Me.rbVLC.Text = "VLC"
        Me.rbVLC.UseSelectable = True
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.lblNote)
        Me.MetroPanel5.Controls.Add(Me.rbAkamai)
        Me.MetroPanel5.Controls.Add(Me.rbLevel3)
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(137, 244)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(551, 22)
        Me.MetroPanel5.TabIndex = 13
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(137, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(394, 19)
        Me.lblNote.TabIndex = 13
        Me.lblNote.Text = "Note: Refreshing games is required for CDN change to take effect"
        '
        'rbAkamai
        '
        Me.rbAkamai.AutoSize = True
        Me.rbAkamai.Checked = True
        Me.rbAkamai.Location = New System.Drawing.Point(68, 3)
        Me.rbAkamai.Name = "rbAkamai"
        Me.rbAkamai.Size = New System.Drawing.Size(63, 15)
        Me.rbAkamai.TabIndex = 12
        Me.rbAkamai.TabStop = True
        Me.rbAkamai.Text = "Akamai"
        Me.rbAkamai.UseSelectable = True
        '
        'rbLevel3
        '
        Me.rbLevel3.AutoSize = True
        Me.rbLevel3.Location = New System.Drawing.Point(3, 3)
        Me.rbLevel3.Name = "rbLevel3"
        Me.rbLevel3.Size = New System.Drawing.Size(59, 15)
        Me.rbLevel3.TabIndex = 11
        Me.rbLevel3.Text = "Level 3"
        Me.rbLevel3.UseSelectable = True
        '
        'btnLiveStreamerPath
        '
        Me.btnLiveStreamerPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLiveStreamerPath.Location = New System.Drawing.Point(629, 114)
        Me.btnLiveStreamerPath.Name = "btnLiveStreamerPath"
        Me.btnLiveStreamerPath.Size = New System.Drawing.Size(28, 20)
        Me.btnLiveStreamerPath.TabIndex = 50
        Me.btnLiveStreamerPath.Text = "..."
        Me.btnLiveStreamerPath.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(17, 328)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel8.TabIndex = 6
        Me.MetroLabel8.Text = "Streamer args"
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
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(137, 188)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(486, 22)
        Me.MetroPanel1.TabIndex = 6
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'rbQual6
        '
        Me.rbQual6.AutoSize = True
        Me.rbQual6.Checked = True
        Me.rbQual6.Location = New System.Drawing.Point(268, 4)
        Me.rbQual6.Name = "rbQual6"
        Me.rbQual6.Size = New System.Drawing.Size(48, 15)
        Me.rbQual6.TabIndex = 10
        Me.rbQual6.TabStop = True
        Me.rbQual6.Text = "720p"
        Me.rbQual6.UseSelectable = True
        '
        'rbQual5
        '
        Me.rbQual5.AutoSize = True
        Me.rbQual5.Location = New System.Drawing.Point(214, 4)
        Me.rbQual5.Name = "rbQual5"
        Me.rbQual5.Size = New System.Drawing.Size(48, 15)
        Me.rbQual5.TabIndex = 11
        Me.rbQual5.Text = "540p"
        Me.rbQual5.UseSelectable = True
        '
        'rbQual4
        '
        Me.rbQual4.AutoSize = True
        Me.rbQual4.Location = New System.Drawing.Point(160, 4)
        Me.rbQual4.Name = "rbQual4"
        Me.rbQual4.Size = New System.Drawing.Size(48, 15)
        Me.rbQual4.TabIndex = 12
        Me.rbQual4.Text = "504p"
        Me.rbQual4.UseSelectable = True
        '
        'rbQual3
        '
        Me.rbQual3.AutoSize = True
        Me.rbQual3.Location = New System.Drawing.Point(106, 4)
        Me.rbQual3.Name = "rbQual3"
        Me.rbQual3.Size = New System.Drawing.Size(48, 15)
        Me.rbQual3.TabIndex = 13
        Me.rbQual3.Text = "360p"
        Me.rbQual3.UseSelectable = True
        '
        'rbQual2
        '
        Me.rbQual2.AutoSize = True
        Me.rbQual2.Location = New System.Drawing.Point(57, 4)
        Me.rbQual2.Name = "rbQual2"
        Me.rbQual2.Size = New System.Drawing.Size(48, 15)
        Me.rbQual2.TabIndex = 14
        Me.rbQual2.Text = "228p"
        Me.rbQual2.UseSelectable = True
        '
        'chk60
        '
        Me.chk60.AutoSize = True
        Me.chk60.Checked = True
        Me.chk60.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk60.Location = New System.Drawing.Point(328, 4)
        Me.chk60.Name = "chk60"
        Me.chk60.Size = New System.Drawing.Size(54, 15)
        Me.chk60.TabIndex = 2
        Me.chk60.Text = "60 fps"
        Me.chk60.UseSelectable = True
        '
        'rbQual1
        '
        Me.rbQual1.AutoSize = True
        Me.rbQual1.Location = New System.Drawing.Point(3, 4)
        Me.rbQual1.Name = "rbQual1"
        Me.rbQual1.Size = New System.Drawing.Size(48, 15)
        Me.rbQual1.TabIndex = 9
        Me.rbQual1.Text = "224p"
        Me.rbQual1.UseSelectable = True
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(17, 300)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel9.TabIndex = 5
        Me.MetroLabel9.Text = "Player args"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(17, 272)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel10.TabIndex = 4
        Me.MetroLabel10.Text = "Output"
        '
        'btnMPCPath
        '
        Me.btnMPCPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMPCPath.Location = New System.Drawing.Point(629, 55)
        Me.btnMPCPath.Name = "btnMPCPath"
        Me.btnMPCPath.Size = New System.Drawing.Size(28, 20)
        Me.btnMPCPath.TabIndex = 49
        Me.btnMPCPath.Text = "..."
        Me.btnMPCPath.UseSelectable = True
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(17, 216)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel6.TabIndex = 3
        Me.MetroLabel6.Text = "Player"
        '
        'btnVLCPath
        '
        Me.btnVLCPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVLCPath.Location = New System.Drawing.Point(629, 28)
        Me.btnVLCPath.Name = "btnVLCPath"
        Me.btnVLCPath.Size = New System.Drawing.Size(28, 20)
        Me.btnVLCPath.TabIndex = 48
        Me.btnVLCPath.Text = "..."
        Me.btnVLCPath.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 112)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel4.TabIndex = 47
        Me.MetroLabel4.Text = "LiveStreamer Path"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(17, 243)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel11.TabIndex = 3
        Me.MetroLabel11.Text = "CDN"
        '
        'txtLiveStreamPath
        '
        Me.txtLiveStreamPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLiveStreamPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLiveStreamPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiveStreamPath.Location = New System.Drawing.Point(137, 112)
        Me.txtLiveStreamPath.Name = "txtLiveStreamPath"
        Me.txtLiveStreamPath.ReadOnly = True
        Me.txtLiveStreamPath.Size = New System.Drawing.Size(486, 22)
        Me.txtLiveStreamPath.TabIndex = 46
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(17, 188)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel7.TabIndex = 2
        Me.MetroLabel7.Text = "Resolution"
        '
        'txtMPCPath
        '
        Me.txtMPCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMPCPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMPCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMPCPath.Location = New System.Drawing.Point(137, 55)
        Me.txtMPCPath.Name = "txtMPCPath"
        Me.txtMPCPath.ReadOnly = True
        Me.txtMPCPath.Size = New System.Drawing.Size(486, 22)
        Me.txtMPCPath.TabIndex = 45
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(17, 55)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel3.TabIndex = 44
        Me.MetroLabel3.Text = "MPC Path"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 28)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel2.TabIndex = 43
        Me.MetroLabel2.Text = "VLC Path"
        '
        'txtVLCPath
        '
        Me.txtVLCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVLCPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVLCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVLCPath.Location = New System.Drawing.Point(137, 28)
        Me.txtVLCPath.Name = "txtVLCPath"
        Me.txtVLCPath.ReadOnly = True
        Me.txtVLCPath.Size = New System.Drawing.Size(486, 22)
        Me.txtVLCPath.TabIndex = 42
        '
        'btnOpenHostsFile
        '
        Me.btnOpenHostsFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenHostsFile.Location = New System.Drawing.Point(467, 140)
        Me.btnOpenHostsFile.Name = "btnOpenHostsFile"
        Me.btnOpenHostsFile.Size = New System.Drawing.Size(92, 24)
        Me.btnOpenHostsFile.TabIndex = 39
        Me.btnOpenHostsFile.Text = "Open Hosts File"
        Me.btnOpenHostsFile.UseSelectable = True
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Location = New System.Drawing.Point(137, 142)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(89, 15)
        Me.MetroCheckBox1.TabIndex = 28
        Me.MetroCheckBox1.Text = "Show Scores"
        Me.MetroCheckBox1.UseSelectable = True
        '
        'btnHosts
        '
        Me.btnHosts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHosts.Location = New System.Drawing.Point(565, 140)
        Me.btnHosts.Name = "btnHosts"
        Me.btnHosts.Size = New System.Drawing.Size(92, 24)
        Me.btnHosts.TabIndex = 27
        Me.btnHosts.Text = "Test Hosts File"
        Me.btnHosts.UseSelectable = True
        '
        'ConsoleTab
        '
        Me.ConsoleTab.Controls.Add(Me.btnClearConsole)
        Me.ConsoleTab.Controls.Add(Me.RichTextBox)
        Me.ConsoleTab.HorizontalScrollbarBarColor = True
        Me.ConsoleTab.HorizontalScrollbarHighlightOnWheel = False
        Me.ConsoleTab.HorizontalScrollbarSize = 10
        Me.ConsoleTab.Location = New System.Drawing.Point(4, 35)
        Me.ConsoleTab.Name = "ConsoleTab"
        Me.ConsoleTab.Padding = New System.Windows.Forms.Padding(0, 0, 0, 30)
        Me.ConsoleTab.Size = New System.Drawing.Size(1022, 501)
        Me.ConsoleTab.TabIndex = 2
        Me.ConsoleTab.Text = "Console      "
        Me.ConsoleTab.VerticalScrollbarBarColor = True
        Me.ConsoleTab.VerticalScrollbarHighlightOnWheel = False
        Me.ConsoleTab.VerticalScrollbarSize = 10
        '
        'btnClearConsole
        '
        Me.btnClearConsole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearConsole.Location = New System.Drawing.Point(916, 442)
        Me.btnClearConsole.Name = "btnClearConsole"
        Me.btnClearConsole.Size = New System.Drawing.Size(103, 23)
        Me.btnClearConsole.TabIndex = 2
        Me.btnClearConsole.Text = "Clear"
        Me.btnClearConsole.UseSelectable = True
        '
        'AdDetectionSettingsTab
        '
        Me.AdDetectionSettingsTab.Controls.Add(Me.AdDetectionSettingsElementHost)
        Me.AdDetectionSettingsTab.HorizontalScrollbarBarColor = True
        Me.AdDetectionSettingsTab.HorizontalScrollbarHighlightOnWheel = False
        Me.AdDetectionSettingsTab.HorizontalScrollbarSize = 6
        Me.AdDetectionSettingsTab.Location = New System.Drawing.Point(4, 35)
        Me.AdDetectionSettingsTab.Margin = New System.Windows.Forms.Padding(2)
        Me.AdDetectionSettingsTab.Name = "AdDetectionSettingsTab"
        Me.AdDetectionSettingsTab.Size = New System.Drawing.Size(1022, 501)
        Me.AdDetectionSettingsTab.TabIndex = 4
        Me.AdDetectionSettingsTab.Text = "Ad Detection Modules"
        Me.AdDetectionSettingsTab.VerticalScrollbarBarColor = True
        Me.AdDetectionSettingsTab.VerticalScrollbarHighlightOnWheel = False
        Me.AdDetectionSettingsTab.VerticalScrollbarSize = 7
        '
        'AdDetectionSettingsElementHost
        '
        Me.AdDetectionSettingsElementHost.BackColor = System.Drawing.Color.White
        Me.AdDetectionSettingsElementHost.BackColorTransparent = True
        Me.AdDetectionSettingsElementHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdDetectionSettingsElementHost.Location = New System.Drawing.Point(0, 0)
        Me.AdDetectionSettingsElementHost.Margin = New System.Windows.Forms.Padding(2)
        Me.AdDetectionSettingsElementHost.Name = "AdDetectionSettingsElementHost"
        Me.AdDetectionSettingsElementHost.Size = New System.Drawing.Size(1022, 501)
        Me.AdDetectionSettingsElementHost.TabIndex = 2
        Me.AdDetectionSettingsElementHost.Child = Nothing
        '
        'lnkDownload
        '
        Me.lnkDownload.AutoSize = True
        Me.lnkDownload.Location = New System.Drawing.Point(967, 44)
        Me.lnkDownload.Name = "lnkDownload"
        Me.lnkDownload.Size = New System.Drawing.Size(55, 13)
        Me.lnkDownload.TabIndex = 23
        Me.lnkDownload.TabStop = True
        Me.lnkDownload.Text = "Download"
        Me.lnkDownload.Visible = False
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.White
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(10, 574)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip.Size = New System.Drawing.Size(1030, 26)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 24
        Me.StatusStrip.Text = "StatusStrip"
        '
        'StatusLabel
        '
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(89, 21)
        Me.StatusLabel.Text = "StatusLabel"
        '
        'btnAddHosts
        '
        Me.btnAddHosts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddHosts.Location = New System.Drawing.Point(245, 140)
        Me.btnAddHosts.Name = "btnAddHosts"
        Me.btnAddHosts.Size = New System.Drawing.Size(92, 24)
        Me.btnAddHosts.TabIndex = 56
        Me.btnAddHosts.Text = "Add Hosts Entry"
        Me.btnAddHosts.UseSelectable = True
        '
        'NHLGamesMetro
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1050, 600)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.lnkDownload)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.lblVersion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1050, 600)
        Me.Name = "NHLGamesMetro"
        Me.Padding = New System.Windows.Forms.Padding(10, 60, 10, 0)
        Me.Resizable = False
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "NHL Games"
        CType(Me.gridGames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.GamesTab.ResumeLayout(False)
        Me.GamesTab.PerformLayout()
        Me.SettingTab.ResumeLayout(False)
        Me.SettingTab.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel5.ResumeLayout(False)
        Me.MetroPanel5.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ConsoleTab.ResumeLayout(False)
        Me.AdDetectionSettingsTab.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtDate As MetroDateTime
    Friend WithEvents btnRefresh As MetroButton
    Friend WithEvents gbPlayer As GroupBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents gbServer As GroupBox
    Friend WithEvents RichTextBox As RichTextBox
    Friend WithEvents gridGames As DataGridView
    Friend WithEvents TabControl As MetroFramework.Controls.MetroTabControl
    Friend WithEvents GamesTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents SettingTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents ConsoleTab As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnHosts As MetroFramework.Controls.MetroButton
    Friend WithEvents FlowLayoutPanel As FlowLayoutPanel
    Friend WithEvents MetroCheckBox1 As MetroCheckBox
    Friend WithEvents btnOpenHostsFile As MetroButton
    Friend WithEvents txtMPCPath As TextBox
    Friend WithEvents MetroLabel3 As MetroLabel
    Friend WithEvents MetroLabel2 As MetroLabel
    Friend WithEvents txtVLCPath As TextBox
    Friend WithEvents MetroLabel4 As MetroLabel
    Friend WithEvents txtLiveStreamPath As TextBox
    Friend WithEvents btnLiveStreamerPath As MetroButton
    Friend WithEvents btnMPCPath As MetroButton
    Friend WithEvents btnVLCPath As MetroButton
    Friend WithEvents OpenFileDialog As OpenFileDialog
    Friend WithEvents btnClearConsole As MetroButton
    Friend WithEvents MetroPanel2 As MetroPanel
    Friend WithEvents lnkMPCDownload As MetroLink
    Friend WithEvents lnkVLCDownload As MetroLink
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
    Friend WithEvents MetroLabel6 As MetroLabel
    Friend WithEvents MetroLabel7 As MetroLabel
    Friend WithEvents txtStreamerArgs As TextBox
    Friend WithEvents txtPlayerArgs As TextBox
    Friend WithEvents txtOutputPath As TextBox
    Friend WithEvents MetroPanel5 As MetroPanel
    Friend WithEvents rbAkamai As MetroRadioButton
    Friend WithEvents rbLevel3 As MetroRadioButton
    Friend WithEvents MetroLabel8 As MetroLabel
    Friend WithEvents MetroLabel9 As MetroLabel
    Friend WithEvents MetroLabel10 As MetroLabel
    Friend WithEvents MetroLabel11 As MetroLabel
    Friend WithEvents chkEnableStreamArgs As MetroCheckBox
    Friend WithEvents chkEnablePlayerArgs As MetroCheckBox
    Friend WithEvents chkEnableOutput As MetroCheckBox
    Friend WithEvents MetroButton1 As MetroButton
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents AdDetectionSettingsTab As MetroTabPage
    Friend WithEvents AdDetectionSettingsElementHost As Integration.ElementHost
    Friend WithEvents btnYesterday As MetroButton
    Friend WithEvents btnTomorrow As MetroButton
    Friend WithEvents btnClean As MetroButton
    Friend WithEvents btnMpvPath As MetroButton
    Friend WithEvents txtMpvPath As TextBox
    Friend WithEvents MetroLabel1 As MetroLabel
    Friend WithEvents rbMpv As MetroRadioButton
    Friend WithEvents lnkMpvDownload As MetroLink
    Friend WithEvents lblNote As MetroLabel
    Friend WithEvents lnkDownload As LinkLabel
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents StatusLabel As ToolStripStatusLabel
    Friend WithEvents btnAddHosts As MetroButton
End Class
