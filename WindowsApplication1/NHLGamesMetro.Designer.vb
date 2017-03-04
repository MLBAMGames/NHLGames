Imports MetroFramework.Controls
Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NHLGamesMetro
    Inherits Windows.Forms.Form

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
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.btnRefresh = New MetroFramework.Controls.MetroButton()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.GamesTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel5 = New DBLayoutPanel(Me.components)
        Me.TableLayoutPanel4 = New DBLayoutPanel(Me.components)
        Me.FlowLayoutPanel3 = New BufferedFlowPanel(Me.components)
        Me.btnYesterday = New MetroFramework.Controls.MetroButton()
        Me.btnTomorrow = New MetroFramework.Controls.MetroButton()
        Me.FlowLayoutPanel = New BufferedFlowPanel(Me.components)
        Me.SettingTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New DBLayoutPanel(Me.components)
        Me.TableLayoutPanel1 = New DBLayoutPanel(Me.components)
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel1 = New BufferedFlowPanel(Me.components)
        Me.btnHosts = New MetroFramework.Controls.MetroButton()
        Me.btnOpenHostsFile = New MetroFramework.Controls.MetroButton()
        Me.btnClean = New MetroFramework.Controls.MetroButton()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtVLCPath = New System.Windows.Forms.TextBox()
        Me.btnMpvPath = New MetroFramework.Controls.MetroButton()
        Me.btnVLCPath = New MetroFramework.Controls.MetroButton()
        Me.txtMpvPath = New System.Windows.Forms.TextBox()
        Me.txtMPCPath = New System.Windows.Forms.TextBox()
        Me.txtLiveStreamPath = New System.Windows.Forms.TextBox()
        Me.btnMPCPath = New MetroFramework.Controls.MetroButton()
        Me.btnLiveStreamerPath = New MetroFramework.Controls.MetroButton()
        Me.TableLayoutPanel2 = New DBLayoutPanel(Me.components)
        Me.FlowLayoutPanel2 = New BufferedFlowPanel(Me.components)
        Me.txtOutputPath = New System.Windows.Forms.TextBox()
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.chkEnablePlayerArgs = New MetroFramework.Controls.MetroCheckBox()
        Me.chkEnableStreamArgs = New MetroFramework.Controls.MetroCheckBox()
        Me.chkEnableOutput = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New BufferedFlowPanel(Me.components)
        Me.rbQual1 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual2 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual3 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual4 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual5 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual6 = New MetroFramework.Controls.MetroRadioButton()
        Me.chk60 = New MetroFramework.Controls.MetroCheckBox()
        Me.txtStreamerArgs = New System.Windows.Forms.TextBox()
        Me.MetroPanel2 = New BufferedFlowPanel(Me.components)
        Me.rbVLC = New MetroFramework.Controls.MetroRadioButton()
        Me.lnkVLCDownload = New MetroFramework.Controls.MetroLink()
        Me.rbMPC = New MetroFramework.Controls.MetroRadioButton()
        Me.lnkMPCDownload = New MetroFramework.Controls.MetroLink()
        Me.rbMpv = New MetroFramework.Controls.MetroRadioButton()
        Me.lnkMpvDownload = New MetroFramework.Controls.MetroLink()
        Me.MetroPanel5 = New BufferedFlowPanel(Me.components)
        Me.lblNote = New MetroFramework.Controls.MetroLabel()
        Me.rbAkamai = New MetroFramework.Controls.MetroRadioButton()
        Me.rbLevel3 = New MetroFramework.Controls.MetroRadioButton()
        Me.txtPlayerArgs = New System.Windows.Forms.TextBox()
        Me.ConsoleTab = New System.Windows.Forms.TabPage()
        Me.btnClearConsole = New MetroFramework.Controls.MetroButton()
        Me.AdDetectionSettingsTab = New System.Windows.Forms.TabPage()
        Me.AdDetectionSettingsElementHost = New System.Windows.Forms.Integration.ElementHost()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.lnkDownload = New System.Windows.Forms.LinkLabel()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.StatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl.SuspendLayout()
        Me.GamesTab.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.FlowLayoutPanel3.SuspendLayout()
        Me.SettingTab.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel5.SuspendLayout()
        Me.ConsoleTab.SuspendLayout()
        Me.AdDetectionSettingsTab.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtDate
        '
        Me.dtDate.Checked = False
        Me.dtDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(32, 3)
        Me.dtDate.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.dtDate.MinimumSize = New System.Drawing.Size(4, 28)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtDate.Size = New System.Drawing.Size(125, 28)
        Me.dtDate.TabIndex = 2
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnRefresh.AutoSize = True
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Location = New System.Drawing.Point(198, 3)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseSelectable = True
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(718, 14)
        Me.lblVersion.MinimumSize = New System.Drawing.Size(200, 5)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(200, 13)
        Me.lblVersion.TabIndex = 17
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'RichTextBox
        '
        Me.RichTextBox.AutoWordSelection = True
        Me.RichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox.ForeColor = System.Drawing.Color.White
        Me.RichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ReadOnly = True
        Me.RichTextBox.Size = New System.Drawing.Size(1022, 471)
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
        Me.TabControl.ItemSize = New System.Drawing.Size(190, 34)
        Me.TabControl.Location = New System.Drawing.Point(0, 0)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(3, 3, 3, 10)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 3
        Me.TabControl.Size = New System.Drawing.Size(1030, 513)
        Me.TabControl.TabIndex = 22
        '
        'GamesTab
        '
        Me.GamesTab.BackColor = System.Drawing.Color.White
        Me.GamesTab.Controls.Add(Me.TableLayoutPanel5)
        Me.GamesTab.Location = New System.Drawing.Point(4, 38)
        Me.GamesTab.Name = "GamesTab"
        Me.GamesTab.Size = New System.Drawing.Size(1022, 471)
        Me.GamesTab.TabIndex = 0
        Me.GamesTab.Text = "Games      "
        Me.GamesTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel4, 0, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.FlowLayoutPanel, 0, 1)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(1022, 471)
        Me.TableLayoutPanel5.TabIndex = 7
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel4.ColumnCount = 3
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.FlowLayoutPanel3, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.btnRefresh, 1, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1006, 34)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'FlowLayoutPanel3
        '
        Me.FlowLayoutPanel3.AutoSize = True
        Me.FlowLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel3.Controls.Add(Me.btnYesterday)
        Me.FlowLayoutPanel3.Controls.Add(Me.dtDate)
        Me.FlowLayoutPanel3.Controls.Add(Me.btnTomorrow)
        Me.FlowLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel3.Name = "FlowLayoutPanel3"
        Me.FlowLayoutPanel3.Size = New System.Drawing.Size(189, 41)
        Me.FlowLayoutPanel3.TabIndex = 0
        '
        'btnYesterday
        '
        Me.btnYesterday.AutoSize = True
        Me.btnYesterday.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnYesterday.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYesterday.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnYesterday.Location = New System.Drawing.Point(3, 3)
        Me.btnYesterday.Name = "btnYesterday"
        Me.btnYesterday.Size = New System.Drawing.Size(23, 23)
        Me.btnYesterday.TabIndex = 7
        Me.btnYesterday.Text = "<"
        Me.btnYesterday.UseSelectable = True
        '
        'btnTomorrow
        '
        Me.btnTomorrow.AutoSize = True
        Me.btnTomorrow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnTomorrow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTomorrow.FontSize = MetroFramework.MetroButtonSize.Medium
        Me.btnTomorrow.Location = New System.Drawing.Point(163, 3)
        Me.btnTomorrow.Name = "btnTomorrow"
        Me.btnTomorrow.Size = New System.Drawing.Size(23, 23)
        Me.btnTomorrow.TabIndex = 8
        Me.btnTomorrow.Text = ">"
        Me.btnTomorrow.UseSelectable = True
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.AutoScroll = True
        Me.FlowLayoutPanel.AutoSize = True
        Me.FlowLayoutPanel.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(3, 43)
        Me.FlowLayoutPanel.Margin = New System.Windows.Forms.Padding(3, 3, 3, 30)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(1016, 398)
        Me.FlowLayoutPanel.TabIndex = 6
        '
        'SettingTab
        '
        Me.SettingTab.BackColor = System.Drawing.Color.White
        Me.SettingTab.Controls.Add(Me.TableLayoutPanel3)
        Me.SettingTab.Location = New System.Drawing.Point(4, 38)
        Me.SettingTab.Name = "SettingTab"
        Me.SettingTab.Size = New System.Drawing.Size(1022, 471)
        Me.SettingTab.TabIndex = 1
        Me.SettingTab.Text = "Settings      "
        Me.SettingTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoSize = True
        Me.TableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1022, 471)
        Me.TableLayoutPanel3.TabIndex = 59
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.MetroLabel4, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtVLCPath, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMpvPath, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnVLCPath, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMpvPath, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtMPCPath, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.txtLiveStreamPath, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMPCPath, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnLiveStreamerPath, 2, 3)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 28)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 5
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(644, 152)
        Me.TableLayoutPanel1.TabIndex = 57
        '
        'MetroLabel2
        '
        Me.MetroLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 5)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel2.TabIndex = 43
        Me.MetroLabel2.Text = "VLC Path"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(3, 34)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel3.TabIndex = 44
        Me.MetroLabel3.Text = "MPC Path"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.btnHosts)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnOpenHostsFile)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnClean)
        Me.FlowLayoutPanel1.Controls.Add(Me.MetroCheckBox1)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(123, 119)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(385, 30)
        Me.FlowLayoutPanel1.TabIndex = 56
        '
        'btnHosts
        '
        Me.btnHosts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHosts.AutoSize = True
        Me.btnHosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHosts.Location = New System.Drawing.Point(295, 3)
        Me.btnHosts.Name = "btnHosts"
        Me.btnHosts.Size = New System.Drawing.Size(87, 23)
        Me.btnHosts.TabIndex = 27
        Me.btnHosts.Text = "Test Hosts File"
        Me.btnHosts.UseSelectable = True
        '
        'btnOpenHostsFile
        '
        Me.btnOpenHostsFile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpenHostsFile.AutoSize = True
        Me.btnOpenHostsFile.Location = New System.Drawing.Point(197, 3)
        Me.btnOpenHostsFile.Name = "btnOpenHostsFile"
        Me.btnOpenHostsFile.Size = New System.Drawing.Size(92, 24)
        Me.btnOpenHostsFile.TabIndex = 39
        Me.btnOpenHostsFile.Text = "Open Hosts File"
        Me.btnOpenHostsFile.UseSelectable = True
        '
        'btnClean
        '
        Me.btnClean.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClean.AutoSize = True
        Me.btnClean.Location = New System.Drawing.Point(98, 3)
        Me.btnClean.Name = "btnClean"
        Me.btnClean.Size = New System.Drawing.Size(93, 24)
        Me.btnClean.TabIndex = 55
        Me.btnClean.Text = "Clean Hosts File"
        Me.btnClean.UseSelectable = True
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Location = New System.Drawing.Point(3, 12)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(89, 15)
        Me.MetroCheckBox1.TabIndex = 28
        Me.MetroCheckBox1.Text = "Show Scores"
        Me.MetroCheckBox1.UseSelectable = True
        '
        'MetroLabel1
        '
        Me.MetroLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 63)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel1.TabIndex = 52
        Me.MetroLabel1.Text = "mpv Path"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 92)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel4.TabIndex = 47
        Me.MetroLabel4.Text = "LiveStreamer Path"
        '
        'txtVLCPath
        '
        Me.txtVLCPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVLCPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtVLCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVLCPath.Location = New System.Drawing.Point(123, 3)
        Me.txtVLCPath.Name = "txtVLCPath"
        Me.txtVLCPath.ReadOnly = True
        Me.txtVLCPath.Size = New System.Drawing.Size(486, 22)
        Me.txtVLCPath.TabIndex = 42
        '
        'btnMpvPath
        '
        Me.btnMpvPath.AutoSize = True
        Me.btnMpvPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMpvPath.Location = New System.Drawing.Point(615, 61)
        Me.btnMpvPath.Name = "btnMpvPath"
        Me.btnMpvPath.Size = New System.Drawing.Size(26, 23)
        Me.btnMpvPath.TabIndex = 54
        Me.btnMpvPath.Text = "..."
        Me.btnMpvPath.UseSelectable = True
        '
        'btnVLCPath
        '
        Me.btnVLCPath.AutoSize = True
        Me.btnVLCPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVLCPath.Location = New System.Drawing.Point(615, 3)
        Me.btnVLCPath.Name = "btnVLCPath"
        Me.btnVLCPath.Size = New System.Drawing.Size(26, 23)
        Me.btnVLCPath.TabIndex = 48
        Me.btnVLCPath.Text = "..."
        Me.btnVLCPath.UseSelectable = True
        '
        'txtMpvPath
        '
        Me.txtMpvPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMpvPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMpvPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMpvPath.Location = New System.Drawing.Point(123, 61)
        Me.txtMpvPath.Name = "txtMpvPath"
        Me.txtMpvPath.ReadOnly = True
        Me.txtMpvPath.Size = New System.Drawing.Size(486, 22)
        Me.txtMpvPath.TabIndex = 53
        '
        'txtMPCPath
        '
        Me.txtMPCPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMPCPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMPCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMPCPath.Location = New System.Drawing.Point(123, 32)
        Me.txtMPCPath.Name = "txtMPCPath"
        Me.txtMPCPath.ReadOnly = True
        Me.txtMPCPath.Size = New System.Drawing.Size(486, 22)
        Me.txtMPCPath.TabIndex = 45
        '
        'txtLiveStreamPath
        '
        Me.txtLiveStreamPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLiveStreamPath.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLiveStreamPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiveStreamPath.Location = New System.Drawing.Point(123, 90)
        Me.txtLiveStreamPath.Name = "txtLiveStreamPath"
        Me.txtLiveStreamPath.ReadOnly = True
        Me.txtLiveStreamPath.Size = New System.Drawing.Size(486, 22)
        Me.txtLiveStreamPath.TabIndex = 46
        '
        'btnMPCPath
        '
        Me.btnMPCPath.AutoSize = True
        Me.btnMPCPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnMPCPath.Location = New System.Drawing.Point(615, 32)
        Me.btnMPCPath.Name = "btnMPCPath"
        Me.btnMPCPath.Size = New System.Drawing.Size(26, 23)
        Me.btnMPCPath.TabIndex = 49
        Me.btnMPCPath.Text = "..."
        Me.btnMPCPath.UseSelectable = True
        '
        'btnLiveStreamerPath
        '
        Me.btnLiveStreamerPath.AutoSize = True
        Me.btnLiveStreamerPath.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnLiveStreamerPath.Location = New System.Drawing.Point(615, 90)
        Me.btnLiveStreamerPath.Name = "btnLiveStreamerPath"
        Me.btnLiveStreamerPath.Size = New System.Drawing.Size(26, 23)
        Me.btnLiveStreamerPath.TabIndex = 50
        Me.btnLiveStreamerPath.Text = "..."
        Me.btnLiveStreamerPath.UseSelectable = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoSize = True
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel7, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel6, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel11, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.chkEnablePlayerArgs, 2, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.chkEnableStreamArgs, 2, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.chkEnableOutput, 2, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel10, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel9, 0, 4)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroLabel8, 0, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroPanel1, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.txtStreamerArgs, 1, 5)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroPanel2, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.MetroPanel5, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtPlayerArgs, 1, 4)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 186)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 6
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(765, 177)
        Me.TableLayoutPanel2.TabIndex = 58
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel2.AutoSize = True
        Me.FlowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel2.Controls.Add(Me.txtOutputPath)
        Me.FlowLayoutPanel2.Controls.Add(Me.MetroButton1)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(101, 92)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(597, 26)
        Me.FlowLayoutPanel2.TabIndex = 59
        '
        'txtOutputPath
        '
        Me.txtOutputPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOutputPath.Enabled = False
        Me.txtOutputPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputPath.Location = New System.Drawing.Point(0, 1)
        Me.txtOutputPath.Margin = New System.Windows.Forms.Padding(0, 0, 3, 3)
        Me.txtOutputPath.Name = "txtOutputPath"
        Me.txtOutputPath.Size = New System.Drawing.Size(560, 22)
        Me.txtOutputPath.TabIndex = 14
        '
        'MetroButton1
        '
        Me.MetroButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MetroButton1.Location = New System.Drawing.Point(566, 3)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(28, 20)
        Me.MetroButton1.TabIndex = 51
        Me.MetroButton1.Text = "..."
        Me.MetroButton1.UseSelectable = True
        '
        'MetroLabel7
        '
        Me.MetroLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(3, 3)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel7.TabIndex = 2
        Me.MetroLabel7.Text = "Resolution"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 38)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel6.TabIndex = 3
        Me.MetroLabel6.Text = "Player"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(3, 65)
        Me.MetroLabel11.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel11.TabIndex = 3
        Me.MetroLabel11.Text = "CDN"
        '
        'chkEnablePlayerArgs
        '
        Me.chkEnablePlayerArgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkEnablePlayerArgs.AutoSize = True
        Me.chkEnablePlayerArgs.Location = New System.Drawing.Point(704, 129)
        Me.chkEnablePlayerArgs.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.chkEnablePlayerArgs.Name = "chkEnablePlayerArgs"
        Me.chkEnablePlayerArgs.Size = New System.Drawing.Size(58, 15)
        Me.chkEnablePlayerArgs.TabIndex = 8
        Me.chkEnablePlayerArgs.Text = "Enable"
        Me.chkEnablePlayerArgs.UseSelectable = True
        '
        'chkEnableStreamArgs
        '
        Me.chkEnableStreamArgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkEnableStreamArgs.AutoSize = True
        Me.chkEnableStreamArgs.Location = New System.Drawing.Point(704, 159)
        Me.chkEnableStreamArgs.Name = "chkEnableStreamArgs"
        Me.chkEnableStreamArgs.Size = New System.Drawing.Size(58, 15)
        Me.chkEnableStreamArgs.TabIndex = 9
        Me.chkEnableStreamArgs.Text = "Enable"
        Me.chkEnableStreamArgs.UseSelectable = True
        '
        'chkEnableOutput
        '
        Me.chkEnableOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkEnableOutput.AutoSize = True
        Me.chkEnableOutput.Location = New System.Drawing.Point(704, 101)
        Me.chkEnableOutput.Margin = New System.Windows.Forms.Padding(3, 3, 3, 5)
        Me.chkEnableOutput.Name = "chkEnableOutput"
        Me.chkEnableOutput.Size = New System.Drawing.Size(58, 15)
        Me.chkEnableOutput.TabIndex = 7
        Me.chkEnableOutput.Text = "Enable"
        Me.chkEnableOutput.UseSelectable = True
        '
        'MetroLabel10
        '
        Me.MetroLabel10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(3, 97)
        Me.MetroLabel10.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel10.TabIndex = 4
        Me.MetroLabel10.Text = "Output"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(3, 125)
        Me.MetroLabel9.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel9.TabIndex = 5
        Me.MetroLabel9.Text = "Player args"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 153)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(3, 0, 3, 5)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel8.TabIndex = 6
        Me.MetroLabel8.Text = "Streamer args"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.AutoSize = True
        Me.MetroPanel1.BackColor = System.Drawing.Color.White
        Me.MetroPanel1.Controls.Add(Me.rbQual1)
        Me.MetroPanel1.Controls.Add(Me.rbQual2)
        Me.MetroPanel1.Controls.Add(Me.rbQual3)
        Me.MetroPanel1.Controls.Add(Me.rbQual4)
        Me.MetroPanel1.Controls.Add(Me.rbQual5)
        Me.MetroPanel1.Controls.Add(Me.rbQual6)
        Me.MetroPanel1.Controls.Add(Me.chk60)
        Me.MetroPanel1.Location = New System.Drawing.Point(101, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(384, 21)
        Me.MetroPanel1.TabIndex = 6
        '
        'rbQual1
        '
        Me.rbQual1.AutoSize = True
        Me.rbQual1.Location = New System.Drawing.Point(3, 3)
        Me.rbQual1.Name = "rbQual1"
        Me.rbQual1.Size = New System.Drawing.Size(48, 15)
        Me.rbQual1.TabIndex = 9
        Me.rbQual1.Text = "224p"
        Me.rbQual1.UseSelectable = True
        '
        'rbQual2
        '
        Me.rbQual2.AutoSize = True
        Me.rbQual2.Location = New System.Drawing.Point(57, 3)
        Me.rbQual2.Name = "rbQual2"
        Me.rbQual2.Size = New System.Drawing.Size(48, 15)
        Me.rbQual2.TabIndex = 14
        Me.rbQual2.Text = "228p"
        Me.rbQual2.UseSelectable = True
        '
        'rbQual3
        '
        Me.rbQual3.AutoSize = True
        Me.rbQual3.Location = New System.Drawing.Point(111, 3)
        Me.rbQual3.Name = "rbQual3"
        Me.rbQual3.Size = New System.Drawing.Size(48, 15)
        Me.rbQual3.TabIndex = 13
        Me.rbQual3.Text = "360p"
        Me.rbQual3.UseSelectable = True
        '
        'rbQual4
        '
        Me.rbQual4.AutoSize = True
        Me.rbQual4.Location = New System.Drawing.Point(165, 3)
        Me.rbQual4.Name = "rbQual4"
        Me.rbQual4.Size = New System.Drawing.Size(48, 15)
        Me.rbQual4.TabIndex = 12
        Me.rbQual4.Text = "504p"
        Me.rbQual4.UseSelectable = True
        '
        'rbQual5
        '
        Me.rbQual5.AutoSize = True
        Me.rbQual5.Location = New System.Drawing.Point(219, 3)
        Me.rbQual5.Name = "rbQual5"
        Me.rbQual5.Size = New System.Drawing.Size(48, 15)
        Me.rbQual5.TabIndex = 11
        Me.rbQual5.Text = "540p"
        Me.rbQual5.UseSelectable = True
        '
        'rbQual6
        '
        Me.rbQual6.AutoSize = True
        Me.rbQual6.Checked = True
        Me.rbQual6.Location = New System.Drawing.Point(273, 3)
        Me.rbQual6.Name = "rbQual6"
        Me.rbQual6.Size = New System.Drawing.Size(48, 15)
        Me.rbQual6.TabIndex = 10
        Me.rbQual6.TabStop = True
        Me.rbQual6.Text = "720p"
        Me.rbQual6.UseSelectable = True
        '
        'chk60
        '
        Me.chk60.AutoSize = True
        Me.chk60.Checked = True
        Me.chk60.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk60.Location = New System.Drawing.Point(327, 3)
        Me.chk60.Name = "chk60"
        Me.chk60.Size = New System.Drawing.Size(54, 15)
        Me.chk60.TabIndex = 2
        Me.chk60.Text = "60 fps"
        Me.chk60.UseSelectable = True
        '
        'txtStreamerArgs
        '
        Me.txtStreamerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtStreamerArgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtStreamerArgs.Enabled = False
        Me.txtStreamerArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreamerArgs.Location = New System.Drawing.Point(101, 152)
        Me.txtStreamerArgs.Name = "txtStreamerArgs"
        Me.txtStreamerArgs.Size = New System.Drawing.Size(597, 22)
        Me.txtStreamerArgs.TabIndex = 16
        '
        'MetroPanel2
        '
        Me.MetroPanel2.AutoSize = True
        Me.MetroPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MetroPanel2.Controls.Add(Me.rbVLC)
        Me.MetroPanel2.Controls.Add(Me.lnkVLCDownload)
        Me.MetroPanel2.Controls.Add(Me.rbMPC)
        Me.MetroPanel2.Controls.Add(Me.lnkMPCDownload)
        Me.MetroPanel2.Controls.Add(Me.rbMpv)
        Me.MetroPanel2.Controls.Add(Me.lnkMpvDownload)
        Me.MetroPanel2.Location = New System.Drawing.Point(101, 30)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(245, 29)
        Me.MetroPanel2.TabIndex = 7
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
        'lnkVLCDownload
        '
        Me.lnkVLCDownload.AutoSize = True
        Me.lnkVLCDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkVLCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkVLCDownload.Location = New System.Drawing.Point(53, 3)
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
        'lnkMPCDownload
        '
        Me.lnkMPCDownload.AutoSize = True
        Me.lnkMPCDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkMPCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMPCDownload.Location = New System.Drawing.Point(137, 3)
        Me.lnkMPCDownload.Name = "lnkMPCDownload"
        Me.lnkMPCDownload.Size = New System.Drawing.Size(23, 23)
        Me.lnkMPCDownload.TabIndex = 18
        Me.lnkMPCDownload.Text = "?"
        Me.lnkMPCDownload.UseSelectable = True
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
        'lnkMpvDownload
        '
        Me.lnkMpvDownload.AutoSize = True
        Me.lnkMpvDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkMpvDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMpvDownload.Location = New System.Drawing.Point(219, 3)
        Me.lnkMpvDownload.Name = "lnkMpvDownload"
        Me.lnkMpvDownload.Size = New System.Drawing.Size(23, 23)
        Me.lnkMpvDownload.TabIndex = 20
        Me.lnkMpvDownload.Text = "?"
        Me.lnkMpvDownload.UseSelectable = True
        '
        'MetroPanel5
        '
        Me.MetroPanel5.AutoSize = True
        Me.MetroPanel5.Controls.Add(Me.lblNote)
        Me.MetroPanel5.Controls.Add(Me.rbAkamai)
        Me.MetroPanel5.Controls.Add(Me.rbLevel3)
        Me.MetroPanel5.Location = New System.Drawing.Point(101, 65)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(534, 21)
        Me.MetroPanel5.TabIndex = 13
        '
        'lblNote
        '
        Me.lblNote.AutoSize = True
        Me.lblNote.Location = New System.Drawing.Point(3, 0)
        Me.lblNote.Name = "lblNote"
        Me.lblNote.Size = New System.Drawing.Size(394, 19)
        Me.lblNote.TabIndex = 13
        Me.lblNote.Text = "Note: Refreshing games is required for CDN change to take effect"
        '
        'rbAkamai
        '
        Me.rbAkamai.AutoSize = True
        Me.rbAkamai.Checked = True
        Me.rbAkamai.Location = New System.Drawing.Point(403, 3)
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
        Me.rbLevel3.Location = New System.Drawing.Point(472, 3)
        Me.rbLevel3.Name = "rbLevel3"
        Me.rbLevel3.Size = New System.Drawing.Size(59, 15)
        Me.rbLevel3.TabIndex = 11
        Me.rbLevel3.Text = "Level 3"
        Me.rbLevel3.UseSelectable = True
        '
        'txtPlayerArgs
        '
        Me.txtPlayerArgs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPlayerArgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPlayerArgs.Enabled = False
        Me.txtPlayerArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlayerArgs.Location = New System.Drawing.Point(101, 124)
        Me.txtPlayerArgs.Name = "txtPlayerArgs"
        Me.txtPlayerArgs.Size = New System.Drawing.Size(597, 22)
        Me.txtPlayerArgs.TabIndex = 15
        '
        'ConsoleTab
        '
        Me.ConsoleTab.BackColor = System.Drawing.Color.White
        Me.ConsoleTab.Controls.Add(Me.btnClearConsole)
        Me.ConsoleTab.Controls.Add(Me.RichTextBox)
        Me.ConsoleTab.Location = New System.Drawing.Point(4, 38)
        Me.ConsoleTab.Name = "ConsoleTab"
        Me.ConsoleTab.Size = New System.Drawing.Size(1022, 471)
        Me.ConsoleTab.TabIndex = 2
        Me.ConsoleTab.Text = "Console      "
        Me.ConsoleTab.UseVisualStyleBackColor = True
        '
        'btnClearConsole
        '
        Me.btnClearConsole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearConsole.Location = New System.Drawing.Point(916, 526)
        Me.btnClearConsole.Name = "btnClearConsole"
        Me.btnClearConsole.Size = New System.Drawing.Size(103, 23)
        Me.btnClearConsole.TabIndex = 2
        Me.btnClearConsole.Text = "Clear"
        Me.btnClearConsole.UseSelectable = True
        '
        'AdDetectionSettingsTab
        '
        Me.AdDetectionSettingsTab.BackColor = System.Drawing.Color.White
        Me.AdDetectionSettingsTab.Controls.Add(Me.AdDetectionSettingsElementHost)
        Me.AdDetectionSettingsTab.Location = New System.Drawing.Point(4, 38)
        Me.AdDetectionSettingsTab.Margin = New System.Windows.Forms.Padding(2)
        Me.AdDetectionSettingsTab.Name = "AdDetectionSettingsTab"
        Me.AdDetectionSettingsTab.Size = New System.Drawing.Size(1022, 471)
        Me.AdDetectionSettingsTab.TabIndex = 4
        Me.AdDetectionSettingsTab.Text = "Ad Detection Modules"
        Me.AdDetectionSettingsTab.UseVisualStyleBackColor = True
        '
        'AdDetectionSettingsElementHost
        '
        Me.AdDetectionSettingsElementHost.BackColor = System.Drawing.Color.White
        Me.AdDetectionSettingsElementHost.BackColorTransparent = True
        Me.AdDetectionSettingsElementHost.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AdDetectionSettingsElementHost.Location = New System.Drawing.Point(0, 0)
        Me.AdDetectionSettingsElementHost.Margin = New System.Windows.Forms.Padding(2)
        Me.AdDetectionSettingsElementHost.Name = "AdDetectionSettingsElementHost"
        Me.AdDetectionSettingsElementHost.Size = New System.Drawing.Size(1022, 471)
        Me.AdDetectionSettingsElementHost.TabIndex = 2
        Me.AdDetectionSettingsElementHost.Child = Nothing
        '
        'lnkDownload
        '
        Me.lnkDownload.AutoSize = True
        Me.lnkDownload.Location = New System.Drawing.Point(977, 14)
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
        Me.StatusStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 0)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip.Size = New System.Drawing.Size(1030, 22)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 24
        Me.StatusStrip.Text = "StatusStrip"
        '
        'StatusLabel
        '
        Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(74, 17)
        Me.StatusLabel.Text = "StatusLabel"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.BottomToolStripPanel
        '
        Me.ToolStripContainer1.BottomToolStripPanel.Controls.Add(Me.StatusStrip)
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1030, 513)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(10, 30)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1030, 560)
        Me.ToolStripContainer1.TabIndex = 25
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'NHLGamesMetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1050, 600)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Controls.Add(Me.lnkDownload)
        Me.Controls.Add(Me.lblVersion)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1050, 600)
        Me.Name = "NHLGamesMetro"
        Me.Padding = New System.Windows.Forms.Padding(10, 30, 10, 10)
        Me.Text = "NHL Games"
        Me.TabControl.ResumeLayout(False)
        Me.GamesTab.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.FlowLayoutPanel3.ResumeLayout(False)
        Me.FlowLayoutPanel3.PerformLayout()
        Me.SettingTab.ResumeLayout(False)
        Me.SettingTab.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel5.ResumeLayout(False)
        Me.MetroPanel5.PerformLayout()
        Me.ConsoleTab.ResumeLayout(False)
        Me.AdDetectionSettingsTab.ResumeLayout(False)
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ToolStripContainer1.BottomToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.BottomToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtDate As Windows.Forms.DateTimePicker
    Friend WithEvents btnRefresh As MetroButton
    Friend WithEvents gbPlayer As GroupBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents gbServer As GroupBox
    Friend WithEvents RichTextBox As RichTextBox
    Friend WithEvents GamesTab As Windows.Forms.TabPage
    Friend WithEvents btnHosts As MetroFramework.Controls.MetroButton
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
    Friend WithEvents lnkMPCDownload As MetroLink
    Friend WithEvents lnkVLCDownload As MetroLink
    Friend WithEvents rbMPC As MetroRadioButton
    Friend WithEvents rbVLC As MetroRadioButton
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
    Friend WithEvents AdDetectionSettingsTab As Windows.Forms.TabPage
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
    Friend WithEvents TableLayoutPanel1 As DBLayoutPanel
    Friend WithEvents TableLayoutPanel3 As DBLayoutPanel
    Friend WithEvents TableLayoutPanel2 As DBLayoutPanel
    Friend WithEvents TableLayoutPanel4 As DBLayoutPanel
    Friend WithEvents TableLayoutPanel5 As DBLayoutPanel
    Friend WithEvents TabControl As Windows.Forms.TabControl
    Friend WithEvents SettingTab As Windows.Forms.TabPage
    Friend WithEvents ConsoleTab As Windows.Forms.TabPage
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents FlowLayoutPanel As BufferedFlowPanel
    Friend WithEvents MetroPanel2 As BufferedFlowPanel
    Friend WithEvents MetroPanel1 As BufferedFlowPanel
    Friend WithEvents MetroPanel5 As BufferedFlowPanel
    Friend WithEvents FlowLayoutPanel1 As BufferedFlowPanel
    Friend WithEvents FlowLayoutPanel2 As BufferedFlowPanel
    Friend WithEvents FlowLayoutPanel3 As BufferedFlowPanel
End Class
