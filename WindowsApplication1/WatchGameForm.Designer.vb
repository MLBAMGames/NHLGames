Imports MetroFramework.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class WatchGameForm
    Inherits MetroForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WatchGameForm))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlBasic = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.rbFrench = New MetroFramework.Controls.MetroRadioButton()
        Me.rbNational = New MetroFramework.Controls.MetroRadioButton()
        Me.rbAway = New MetroFramework.Controls.MetroRadioButton()
        Me.rbHome = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.rbVOD = New MetroFramework.Controls.MetroRadioButton()
        Me.rbLive = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.lnkMPCDownload = New MetroFramework.Controls.MetroLink()
        Me.lnkVLCDownload = New MetroFramework.Controls.MetroLink()
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
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.pnlAdvanced = New MetroFramework.Controls.MetroPanel()
        Me.txtStreamerArgs = New System.Windows.Forms.TextBox()
        Me.txtPlayerArgs = New System.Windows.Forms.TextBox()
        Me.txtOutputPath = New System.Windows.Forms.TextBox()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.rbAkamai = New MetroFramework.Controls.MetroRadioButton()
        Me.rbLevel3 = New MetroFramework.Controls.MetroRadioButton()
        Me.chkEnableStreamArgs = New MetroFramework.Controls.MetroCheckBox()
        Me.chkEnablePlayerArgs = New MetroFramework.Controls.MetroCheckBox()
        Me.chkEnableOutput = New MetroFramework.Controls.MetroCheckBox()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.pnlActions = New MetroFramework.Controls.MetroPanel()
        Me.lnkShowAdvanced = New MetroFramework.Controls.MetroLink()
        Me.btnWatch = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.VLCTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MPCTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.pnlBasic.SuspendLayout()
        Me.MetroPanel4.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.pnlAdvanced.SuspendLayout()
        Me.MetroPanel5.SuspendLayout()
        Me.pnlActions.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlBasic)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlAdvanced)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlActions)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(6, 25)
        Me.FlowLayoutPanel1.MaximumSize = New System.Drawing.Size(560, 1900)
        Me.FlowLayoutPanel1.MinimumSize = New System.Drawing.Size(560, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(560, 291)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'pnlBasic
        '
        Me.pnlBasic.Controls.Add(Me.MetroPanel4)
        Me.pnlBasic.Controls.Add(Me.MetroPanel3)
        Me.pnlBasic.Controls.Add(Me.MetroPanel2)
        Me.pnlBasic.Controls.Add(Me.MetroPanel1)
        Me.pnlBasic.Controls.Add(Me.MetroLabel4)
        Me.pnlBasic.Controls.Add(Me.MetroLabel3)
        Me.pnlBasic.Controls.Add(Me.MetroLabel2)
        Me.pnlBasic.Controls.Add(Me.MetroLabel1)
        Me.pnlBasic.HorizontalScrollbarBarColor = True
        Me.pnlBasic.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlBasic.HorizontalScrollbarSize = 10
        Me.pnlBasic.Location = New System.Drawing.Point(3, 3)
        Me.pnlBasic.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.pnlBasic.Name = "pnlBasic"
        Me.pnlBasic.Size = New System.Drawing.Size(547, 134)
        Me.pnlBasic.TabIndex = 55
        Me.pnlBasic.VerticalScrollbarBarColor = True
        Me.pnlBasic.VerticalScrollbarHighlightOnWheel = False
        Me.pnlBasic.VerticalScrollbarSize = 10
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.rbFrench)
        Me.MetroPanel4.Controls.Add(Me.rbNational)
        Me.MetroPanel4.Controls.Add(Me.rbAway)
        Me.MetroPanel4.Controls.Add(Me.rbHome)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(149, 101)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(395, 25)
        Me.MetroPanel4.TabIndex = 7
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'rbFrench
        '
        Me.rbFrench.AutoSize = True
        Me.rbFrench.Location = New System.Drawing.Point(196, 3)
        Me.rbFrench.Name = "rbFrench"
        Me.rbFrench.Size = New System.Drawing.Size(59, 15)
        Me.rbFrench.TabIndex = 14
        Me.rbFrench.Text = "French"
        Me.rbFrench.UseSelectable = True
        '
        'rbNational
        '
        Me.rbNational.AutoSize = True
        Me.rbNational.Location = New System.Drawing.Point(122, 3)
        Me.rbNational.Name = "rbNational"
        Me.rbNational.Size = New System.Drawing.Size(68, 15)
        Me.rbNational.TabIndex = 13
        Me.rbNational.Text = "National"
        Me.rbNational.UseSelectable = True
        '
        'rbAway
        '
        Me.rbAway.AutoSize = True
        Me.rbAway.Location = New System.Drawing.Point(65, 3)
        Me.rbAway.Name = "rbAway"
        Me.rbAway.Size = New System.Drawing.Size(52, 15)
        Me.rbAway.TabIndex = 12
        Me.rbAway.Text = "Away"
        Me.rbAway.UseSelectable = True
        '
        'rbHome
        '
        Me.rbHome.AutoSize = True
        Me.rbHome.Checked = True
        Me.rbHome.Location = New System.Drawing.Point(3, 3)
        Me.rbHome.Name = "rbHome"
        Me.rbHome.Size = New System.Drawing.Size(56, 15)
        Me.rbHome.TabIndex = 11
        Me.rbHome.TabStop = True
        Me.rbHome.Text = "Home"
        Me.rbHome.UseSelectable = True
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.rbVOD)
        Me.MetroPanel3.Controls.Add(Me.rbLive)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(149, 70)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(395, 25)
        Me.MetroPanel3.TabIndex = 8
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'rbVOD
        '
        Me.rbVOD.AutoSize = True
        Me.rbVOD.Location = New System.Drawing.Point(53, 4)
        Me.rbVOD.Name = "rbVOD"
        Me.rbVOD.Size = New System.Drawing.Size(47, 15)
        Me.rbVOD.TabIndex = 12
        Me.rbVOD.Text = "VOD"
        Me.rbVOD.UseSelectable = True
        '
        'rbLive
        '
        Me.rbLive.AutoSize = True
        Me.rbLive.Checked = True
        Me.rbLive.Location = New System.Drawing.Point(3, 3)
        Me.rbLive.Name = "rbLive"
        Me.rbLive.Size = New System.Drawing.Size(44, 15)
        Me.rbLive.TabIndex = 11
        Me.rbLive.TabStop = True
        Me.rbLive.Text = "Live"
        Me.rbLive.UseSelectable = True
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.lnkMPCDownload)
        Me.MetroPanel2.Controls.Add(Me.lnkVLCDownload)
        Me.MetroPanel2.Controls.Add(Me.rbMPC)
        Me.MetroPanel2.Controls.Add(Me.rbVLC)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(149, 39)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(395, 25)
        Me.MetroPanel2.TabIndex = 7
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'lnkMPCDownload
        '
        Me.lnkMPCDownload.AutoSize = True
        Me.lnkMPCDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkMPCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMPCDownload.Location = New System.Drawing.Point(128, 0)
        Me.lnkMPCDownload.Name = "lnkMPCDownload"
        Me.lnkMPCDownload.Size = New System.Drawing.Size(23, 23)
        Me.lnkMPCDownload.TabIndex = 18
        Me.lnkMPCDownload.Text = "?"
        Me.MPCTooltip.SetToolTip(Me.lnkMPCDownload, "Download MPC Media Player")
        Me.lnkMPCDownload.UseSelectable = True
        '
        'lnkVLCDownload
        '
        Me.lnkVLCDownload.AutoSize = True
        Me.lnkVLCDownload.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkVLCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkVLCDownload.Location = New System.Drawing.Point(47, -1)
        Me.lnkVLCDownload.Name = "lnkVLCDownload"
        Me.lnkVLCDownload.Size = New System.Drawing.Size(23, 23)
        Me.lnkVLCDownload.TabIndex = 17
        Me.lnkVLCDownload.Text = "?"
        Me.VLCTooltip.SetToolTip(Me.lnkVLCDownload, "Download VLC Media Player")
        Me.lnkVLCDownload.UseSelectable = True
        '
        'rbMPC
        '
        Me.rbMPC.AutoSize = True
        Me.rbMPC.Location = New System.Drawing.Point(80, 3)
        Me.rbMPC.Name = "rbMPC"
        Me.rbMPC.Size = New System.Drawing.Size(49, 15)
        Me.rbMPC.TabIndex = 16
        Me.rbMPC.Text = "MPC"
        Me.rbMPC.UseSelectable = True
        '
        'rbVLC
        '
        Me.rbVLC.AutoSize = True
        Me.rbVLC.Checked = True
        Me.rbVLC.Location = New System.Drawing.Point(3, 3)
        Me.rbVLC.Name = "rbVLC"
        Me.rbVLC.Size = New System.Drawing.Size(44, 15)
        Me.rbVLC.TabIndex = 15
        Me.rbVLC.TabStop = True
        Me.rbVLC.Text = "VLC"
        Me.rbVLC.UseSelectable = True
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
        Me.MetroPanel1.Location = New System.Drawing.Point(149, 8)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(395, 25)
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
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(12, 101)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(51, 19)
        Me.MetroLabel4.TabIndex = 5
        Me.MetroLabel4.Text = "Stream"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(12, 70)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel3.TabIndex = 4
        Me.MetroLabel3.Text = "Server"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(12, 38)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(45, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Player"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(12, 8)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(69, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Resolution"
        '
        'pnlAdvanced
        '
        Me.pnlAdvanced.Controls.Add(Me.txtStreamerArgs)
        Me.pnlAdvanced.Controls.Add(Me.txtPlayerArgs)
        Me.pnlAdvanced.Controls.Add(Me.txtOutputPath)
        Me.pnlAdvanced.Controls.Add(Me.MetroPanel5)
        Me.pnlAdvanced.Controls.Add(Me.chkEnableStreamArgs)
        Me.pnlAdvanced.Controls.Add(Me.chkEnablePlayerArgs)
        Me.pnlAdvanced.Controls.Add(Me.chkEnableOutput)
        Me.pnlAdvanced.Controls.Add(Me.MetroLabel8)
        Me.pnlAdvanced.Controls.Add(Me.MetroLabel7)
        Me.pnlAdvanced.Controls.Add(Me.MetroLabel6)
        Me.pnlAdvanced.Controls.Add(Me.MetroLabel5)
        Me.pnlAdvanced.HorizontalScrollbarBarColor = True
        Me.pnlAdvanced.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlAdvanced.HorizontalScrollbarSize = 10
        Me.pnlAdvanced.Location = New System.Drawing.Point(3, 137)
        Me.pnlAdvanced.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.pnlAdvanced.Name = "pnlAdvanced"
        Me.pnlAdvanced.Size = New System.Drawing.Size(547, 116)
        Me.pnlAdvanced.TabIndex = 2
        Me.pnlAdvanced.VerticalScrollbarBarColor = True
        Me.pnlAdvanced.VerticalScrollbarHighlightOnWheel = False
        Me.pnlAdvanced.VerticalScrollbarSize = 10
        '
        'txtStreamerArgs
        '
        Me.txtStreamerArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtStreamerArgs.Location = New System.Drawing.Point(149, 88)
        Me.txtStreamerArgs.Name = "txtStreamerArgs"
        Me.txtStreamerArgs.Size = New System.Drawing.Size(329, 22)
        Me.txtStreamerArgs.TabIndex = 16
        '
        'txtPlayerArgs
        '
        Me.txtPlayerArgs.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtPlayerArgs.Location = New System.Drawing.Point(149, 60)
        Me.txtPlayerArgs.Name = "txtPlayerArgs"
        Me.txtPlayerArgs.Size = New System.Drawing.Size(329, 22)
        Me.txtPlayerArgs.TabIndex = 15
        '
        'txtOutputPath
        '
        Me.txtOutputPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutputPath.Location = New System.Drawing.Point(149, 32)
        Me.txtOutputPath.Name = "txtOutputPath"
        Me.txtOutputPath.Size = New System.Drawing.Size(329, 22)
        Me.txtOutputPath.TabIndex = 14
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.rbAkamai)
        Me.MetroPanel5.Controls.Add(Me.rbLevel3)
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(149, 4)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(395, 22)
        Me.MetroPanel5.TabIndex = 13
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'rbAkamai
        '
        Me.rbAkamai.AutoSize = True
        Me.rbAkamai.Location = New System.Drawing.Point(68, 3)
        Me.rbAkamai.Name = "rbAkamai"
        Me.rbAkamai.Size = New System.Drawing.Size(63, 15)
        Me.rbAkamai.TabIndex = 12
        Me.rbAkamai.Text = "Akamai"
        Me.rbAkamai.UseSelectable = True
        '
        'rbLevel3
        '
        Me.rbLevel3.AutoSize = True
        Me.rbLevel3.Checked = True
        Me.rbLevel3.Location = New System.Drawing.Point(3, 3)
        Me.rbLevel3.Name = "rbLevel3"
        Me.rbLevel3.Size = New System.Drawing.Size(59, 15)
        Me.rbLevel3.TabIndex = 11
        Me.rbLevel3.TabStop = True
        Me.rbLevel3.Text = "Level 3"
        Me.rbLevel3.UseSelectable = True
        '
        'chkEnableStreamArgs
        '
        Me.chkEnableStreamArgs.AutoSize = True
        Me.chkEnableStreamArgs.Location = New System.Drawing.Point(484, 91)
        Me.chkEnableStreamArgs.Name = "chkEnableStreamArgs"
        Me.chkEnableStreamArgs.Size = New System.Drawing.Size(58, 15)
        Me.chkEnableStreamArgs.TabIndex = 9
        Me.chkEnableStreamArgs.Text = "Enable"
        Me.chkEnableStreamArgs.UseSelectable = True
        '
        'chkEnablePlayerArgs
        '
        Me.chkEnablePlayerArgs.AutoSize = True
        Me.chkEnablePlayerArgs.Location = New System.Drawing.Point(484, 63)
        Me.chkEnablePlayerArgs.Name = "chkEnablePlayerArgs"
        Me.chkEnablePlayerArgs.Size = New System.Drawing.Size(58, 15)
        Me.chkEnablePlayerArgs.TabIndex = 8
        Me.chkEnablePlayerArgs.Text = "Enable"
        Me.chkEnablePlayerArgs.UseSelectable = True
        '
        'chkEnableOutput
        '
        Me.chkEnableOutput.AutoSize = True
        Me.chkEnableOutput.Location = New System.Drawing.Point(484, 35)
        Me.chkEnableOutput.Name = "chkEnableOutput"
        Me.chkEnableOutput.Size = New System.Drawing.Size(58, 15)
        Me.chkEnableOutput.TabIndex = 7
        Me.chkEnableOutput.Text = "Enable"
        Me.chkEnableOutput.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(12, 87)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(92, 19)
        Me.MetroLabel8.TabIndex = 6
        Me.MetroLabel8.Text = "Streamer args"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(12, 59)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel7.TabIndex = 5
        Me.MetroLabel7.Text = "Player args"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(12, 31)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(50, 19)
        Me.MetroLabel6.TabIndex = 4
        Me.MetroLabel6.Text = "Output"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(12, 7)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(37, 19)
        Me.MetroLabel5.TabIndex = 3
        Me.MetroLabel5.Text = "CDN"
        '
        'pnlActions
        '
        Me.pnlActions.Controls.Add(Me.lnkShowAdvanced)
        Me.pnlActions.Controls.Add(Me.btnWatch)
        Me.pnlActions.Controls.Add(Me.btnCancel)
        Me.pnlActions.HorizontalScrollbarBarColor = True
        Me.pnlActions.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlActions.HorizontalScrollbarSize = 10
        Me.pnlActions.Location = New System.Drawing.Point(3, 256)
        Me.pnlActions.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.pnlActions.Name = "pnlActions"
        Me.pnlActions.Size = New System.Drawing.Size(547, 32)
        Me.pnlActions.TabIndex = 2
        Me.pnlActions.VerticalScrollbarBarColor = True
        Me.pnlActions.VerticalScrollbarHighlightOnWheel = False
        Me.pnlActions.VerticalScrollbarSize = 10
        '
        'lnkShowAdvanced
        '
        Me.lnkShowAdvanced.AutoSize = True
        Me.lnkShowAdvanced.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.lnkShowAdvanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkShowAdvanced.Location = New System.Drawing.Point(12, 3)
        Me.lnkShowAdvanced.Name = "lnkShowAdvanced"
        Me.lnkShowAdvanced.Size = New System.Drawing.Size(66, 23)
        Me.lnkShowAdvanced.TabIndex = 53
        Me.lnkShowAdvanced.Text = "Advanced"
        Me.lnkShowAdvanced.UseSelectable = True
        '
        'btnWatch
        '
        Me.btnWatch.Location = New System.Drawing.Point(436, 3)
        Me.btnWatch.Name = "btnWatch"
        Me.btnWatch.Size = New System.Drawing.Size(108, 23)
        Me.btnWatch.TabIndex = 51
        Me.btnWatch.Text = "Watch"
        Me.btnWatch.UseSelectable = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(322, 3)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(108, 23)
        Me.btnCancel.TabIndex = 52
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'WatchGameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(589, 326)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "WatchGameForm"
        Me.Resizable = False
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Watch Game"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.pnlBasic.ResumeLayout(False)
        Me.pnlBasic.PerformLayout()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.pnlAdvanced.ResumeLayout(False)
        Me.pnlAdvanced.PerformLayout()
        Me.MetroPanel5.ResumeLayout(False)
        Me.MetroPanel5.PerformLayout()
        Me.pnlActions.ResumeLayout(False)
        Me.pnlActions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WatchGameControl As WatchGameControl
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents pnlBasic As MetroFramework.Controls.MetroPanel
    Friend WithEvents pnlAdvanced As MetroFramework.Controls.MetroPanel
    Friend WithEvents pnlActions As MetroFramework.Controls.MetroPanel
    Friend WithEvents btnWatch As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents lnkShowAdvanced As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbFrench As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbNational As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbAway As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbHome As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbVOD As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbLive As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents lnkMPCDownload As MetroFramework.Controls.MetroLink
    Friend WithEvents lnkVLCDownload As MetroFramework.Controls.MetroLink
    Friend WithEvents rbMPC As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbVLC As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbQual6 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual5 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents chk60 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents rbQual1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbAkamai As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbLevel3 As MetroFramework.Controls.MetroRadioButton

    Friend WithEvents chkEnableStreamArgs As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkEnablePlayerArgs As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents chkEnableOutput As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtStreamerArgs As TextBox
    Friend WithEvents txtPlayerArgs As TextBox
    Friend WithEvents txtOutputPath As TextBox
    Friend WithEvents MPCTooltip As ToolTip
    Friend WithEvents VLCTooltip As ToolTip
End Class
