<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WatchGameControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()

        Me.btnWatch = New MetroFramework.Controls.MetroButton()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.rbMPC = New MetroFramework.Controls.MetroRadioButton()
        Me.lnkMPCDownload = New MetroFramework.Controls.MetroLink()
        Me.rbVLC = New MetroFramework.Controls.MetroRadioButton()
        Me.lnkVLCDownload = New MetroFramework.Controls.MetroLink()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.rbVOD = New MetroFramework.Controls.MetroRadioButton()
        Me.rbLive = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.rbAkamai = New MetroFramework.Controls.MetroRadioButton()
        Me.rbLevel3 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.chk60 = New MetroFramework.Controls.MetroCheckBox()
        Me.rbQual6 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual5 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual4 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual2 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual3 = New MetroFramework.Controls.MetroRadioButton()
        Me.rbQual1 = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel5 = New MetroFramework.Controls.MetroPanel()
        Me.rbFrench = New MetroFramework.Controls.MetroRadioButton()
        Me.rbAway = New MetroFramework.Controls.MetroRadioButton()
        Me.rbNational = New MetroFramework.Controls.MetroRadioButton()
        Me.rbHome = New MetroFramework.Controls.MetroRadioButton()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtStreamerArgs = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtOutputPath = New MetroFramework.Controls.MetroTextBox()
        Me.chkEnableOutput = New MetroFramework.Controls.MetroCheckBox()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.chkEnableStreamArgs = New MetroFramework.Controls.MetroCheckBox()
        Me.chkEnablePlayerArgs = New MetroFramework.Controls.MetroCheckBox()
        Me.txtPlayerArgs = New MetroFramework.Controls.MetroTextBox()
        Me.lnkShowAdvanced = New MetroFramework.Controls.MetroLink()
        Me.pnlBasic = New MetroFramework.Controls.MetroPanel()
        Me.pnlAdvanced = New MetroFramework.Controls.MetroPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.MetroPanel6 = New MetroFramework.Controls.MetroPanel()
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.MetroPanel4.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel5.SuspendLayout()
        Me.pnlBasic.SuspendLayout()
        Me.pnlAdvanced.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MetroPanel6.SuspendLayout()
        Me.SuspendLayout()
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
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel5.Location = New System.Drawing.Point(4, 3)
        Me.MetroLabel5.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(38, 19)
        Me.MetroLabel5.TabIndex = 48
        Me.MetroLabel5.Text = "CDN"
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.rbMPC)
        Me.MetroPanel3.Controls.Add(Me.lnkMPCDownload)
        Me.MetroPanel3.Controls.Add(Me.rbVLC)
        Me.MetroPanel3.Controls.Add(Me.lnkVLCDownload)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(129, 30)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(172, 20)
        Me.MetroPanel3.TabIndex = 46
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'rbMPC
        '
        Me.rbMPC.AutoSize = True
        Me.rbMPC.Location = New System.Drawing.Point(75, 3)
        Me.rbMPC.Name = "rbMPC"
        Me.rbMPC.Size = New System.Drawing.Size(49, 15)
        Me.rbMPC.TabIndex = 1
        Me.rbMPC.Text = "MPC"
        Me.rbMPC.UseSelectable = True
        '
        'lnkMPCDownload
        '
        Me.lnkMPCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMPCDownload.Location = New System.Drawing.Point(119, 1)
        Me.lnkMPCDownload.Name = "lnkMPCDownload"
        Me.lnkMPCDownload.Size = New System.Drawing.Size(18, 18)
        Me.lnkMPCDownload.TabIndex = 3
        Me.lnkMPCDownload.Text = "?"
        Me.lnkMPCDownload.UseSelectable = True
        '
        'rbVLC
        '
        Me.rbVLC.AutoSize = True
        Me.rbVLC.Checked = True
        Me.rbVLC.Location = New System.Drawing.Point(3, 3)
        Me.rbVLC.Name = "rbVLC"
        Me.rbVLC.Size = New System.Drawing.Size(44, 15)
        Me.rbVLC.TabIndex = 0
        Me.rbVLC.TabStop = True
        Me.rbVLC.Text = "VLC"
        Me.rbVLC.UseSelectable = True
        '
        'lnkVLCDownload
        '
        Me.lnkVLCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkVLCDownload.Location = New System.Drawing.Point(42, 1)
        Me.lnkVLCDownload.Name = "lnkVLCDownload"
        Me.lnkVLCDownload.Size = New System.Drawing.Size(18, 18)
        Me.lnkVLCDownload.TabIndex = 2
        Me.lnkVLCDownload.Text = "?"
        Me.lnkVLCDownload.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.rbVOD)
        Me.MetroPanel1.Controls.Add(Me.rbLive)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(129, 56)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(113, 20)
        Me.MetroPanel1.TabIndex = 42
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'rbVOD
        '
        Me.rbVOD.AutoSize = True
        Me.rbVOD.Location = New System.Drawing.Point(53, 3)
        Me.rbVOD.Name = "rbVOD"
        Me.rbVOD.Size = New System.Drawing.Size(47, 15)
        Me.rbVOD.TabIndex = 1
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
        Me.rbLive.TabIndex = 0
        Me.rbLive.TabStop = True
        Me.rbLive.Text = "Live"
        Me.rbLive.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel4.Location = New System.Drawing.Point(3, 57)
        Me.MetroLabel4.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(47, 19)
        Me.MetroLabel4.TabIndex = 47
        Me.MetroLabel4.Text = "Server"
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.rbAkamai)
        Me.MetroPanel4.Controls.Add(Me.rbLevel3)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(129, 0)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(180, 20)
        Me.MetroPanel4.TabIndex = 49
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'rbAkamai
        '
        Me.rbAkamai.AutoSize = True
        Me.rbAkamai.Checked = True
        Me.rbAkamai.Location = New System.Drawing.Point(68, 3)
        Me.rbAkamai.Name = "rbAkamai"
        Me.rbAkamai.Size = New System.Drawing.Size(63, 15)
        Me.rbAkamai.TabIndex = 0
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
        Me.rbLevel3.TabIndex = 1
        Me.rbLevel3.Text = "Level 3"
        Me.rbLevel3.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel3.Location = New System.Drawing.Point(4, 31)
        Me.MetroLabel3.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(46, 19)
        Me.MetroLabel3.TabIndex = 45
        Me.MetroLabel3.Text = "Player"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.chk60)
        Me.MetroPanel2.Controls.Add(Me.rbQual6)
        Me.MetroPanel2.Controls.Add(Me.rbQual5)
        Me.MetroPanel2.Controls.Add(Me.rbQual4)
        Me.MetroPanel2.Controls.Add(Me.rbQual2)
        Me.MetroPanel2.Controls.Add(Me.rbQual3)
        Me.MetroPanel2.Controls.Add(Me.rbQual1)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(129, 5)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(399, 20)
        Me.MetroPanel2.TabIndex = 43
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'chk60
        '
        Me.chk60.AutoSize = True
        Me.chk60.Location = New System.Drawing.Point(324, 3)
        Me.chk60.Name = "chk60"
        Me.chk60.Size = New System.Drawing.Size(54, 15)
        Me.chk60.TabIndex = 41
        Me.chk60.Text = "60 fps"
        Me.chk60.UseSelectable = True
        '
        'rbQual6
        '
        Me.rbQual6.AutoSize = True
        Me.rbQual6.Checked = True
        Me.rbQual6.Location = New System.Drawing.Point(270, 3)
        Me.rbQual6.Name = "rbQual6"
        Me.rbQual6.Size = New System.Drawing.Size(48, 15)
        Me.rbQual6.TabIndex = 25
        Me.rbQual6.TabStop = True
        Me.rbQual6.Text = "720p"
        Me.rbQual6.UseSelectable = True
        '
        'rbQual5
        '
        Me.rbQual5.AutoSize = True
        Me.rbQual5.Location = New System.Drawing.Point(216, 3)
        Me.rbQual5.Name = "rbQual5"
        Me.rbQual5.Size = New System.Drawing.Size(48, 15)
        Me.rbQual5.TabIndex = 24
        Me.rbQual5.TabStop = True
        Me.rbQual5.Text = "540p"
        Me.rbQual5.UseSelectable = True
        '
        'rbQual4
        '
        Me.rbQual4.AutoSize = True
        Me.rbQual4.Location = New System.Drawing.Point(162, 3)
        Me.rbQual4.Name = "rbQual4"
        Me.rbQual4.Size = New System.Drawing.Size(48, 15)
        Me.rbQual4.TabIndex = 23
        Me.rbQual4.TabStop = True
        Me.rbQual4.Text = "504p"
        Me.rbQual4.UseSelectable = True
        '
        'rbQual2
        '
        Me.rbQual2.AutoSize = True
        Me.rbQual2.Location = New System.Drawing.Point(57, 3)
        Me.rbQual2.Name = "rbQual2"
        Me.rbQual2.Size = New System.Drawing.Size(48, 15)
        Me.rbQual2.TabIndex = 21
        Me.rbQual2.TabStop = True
        Me.rbQual2.Text = "288p"
        Me.rbQual2.UseSelectable = True
        '
        'rbQual3
        '
        Me.rbQual3.AutoSize = True
        Me.rbQual3.Location = New System.Drawing.Point(111, 3)
        Me.rbQual3.Name = "rbQual3"
        Me.rbQual3.Size = New System.Drawing.Size(48, 15)
        Me.rbQual3.TabIndex = 22
        Me.rbQual3.TabStop = True
        Me.rbQual3.Text = "360p"
        Me.rbQual3.UseSelectable = True
        '
        'rbQual1
        '
        Me.rbQual1.AutoSize = True
        Me.rbQual1.Location = New System.Drawing.Point(3, 3)
        Me.rbQual1.Name = "rbQual1"
        Me.rbQual1.Size = New System.Drawing.Size(48, 15)
        Me.rbQual1.TabIndex = 20
        Me.rbQual1.TabStop = True
        Me.rbQual1.Text = "224p"
        Me.rbQual1.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel2.Location = New System.Drawing.Point(3, 6)
        Me.MetroLabel2.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(73, 19)
        Me.MetroLabel2.TabIndex = 44
        Me.MetroLabel2.Text = "Resolution"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel1.Location = New System.Drawing.Point(3, 83)
        Me.MetroLabel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(52, 19)
        Me.MetroLabel1.TabIndex = 50
        Me.MetroLabel1.Text = "Stream"
        '
        'MetroPanel5
        '
        Me.MetroPanel5.Controls.Add(Me.rbFrench)
        Me.MetroPanel5.Controls.Add(Me.rbAway)
        Me.MetroPanel5.Controls.Add(Me.rbNational)
        Me.MetroPanel5.Controls.Add(Me.rbHome)
        Me.MetroPanel5.HorizontalScrollbarBarColor = True
        Me.MetroPanel5.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.HorizontalScrollbarSize = 10
        Me.MetroPanel5.Location = New System.Drawing.Point(129, 82)
        Me.MetroPanel5.Name = "MetroPanel5"
        Me.MetroPanel5.Size = New System.Drawing.Size(385, 20)
        Me.MetroPanel5.TabIndex = 44
        Me.MetroPanel5.VerticalScrollbarBarColor = True
        Me.MetroPanel5.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel5.VerticalScrollbarSize = 10
        '
        'rbFrench
        '
        Me.rbFrench.AutoSize = True
        Me.rbFrench.Location = New System.Drawing.Point(197, 3)
        Me.rbFrench.Name = "rbFrench"
        Me.rbFrench.Size = New System.Drawing.Size(59, 15)
        Me.rbFrench.TabIndex = 23
        Me.rbFrench.TabStop = True
        Me.rbFrench.Text = "French"
        Me.rbFrench.UseSelectable = True
        '
        'rbAway
        '
        Me.rbAway.AutoSize = True
        Me.rbAway.Location = New System.Drawing.Point(65, 3)
        Me.rbAway.Name = "rbAway"
        Me.rbAway.Size = New System.Drawing.Size(52, 15)
        Me.rbAway.TabIndex = 21
        Me.rbAway.TabStop = True
        Me.rbAway.Text = "Away"
        Me.rbAway.UseSelectable = True
        '
        'rbNational
        '
        Me.rbNational.AutoSize = True
        Me.rbNational.Location = New System.Drawing.Point(123, 3)
        Me.rbNational.Name = "rbNational"
        Me.rbNational.Size = New System.Drawing.Size(68, 15)
        Me.rbNational.TabIndex = 22
        Me.rbNational.TabStop = True
        Me.rbNational.Text = "National"
        Me.rbNational.UseSelectable = True
        '
        'rbHome
        '
        Me.rbHome.AutoSize = True
        Me.rbHome.Checked = True
        Me.rbHome.Location = New System.Drawing.Point(3, 3)
        Me.rbHome.Name = "rbHome"
        Me.rbHome.Size = New System.Drawing.Size(56, 15)
        Me.rbHome.TabIndex = 20
        Me.rbHome.TabStop = True
        Me.rbHome.Text = "Home"
        Me.rbHome.UseSelectable = True
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel8.Location = New System.Drawing.Point(3, 77)
        Me.MetroLabel8.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(118, 19)
        Me.MetroLabel8.TabIndex = 54
        Me.MetroLabel8.Text = "LiveStreamer args"
        '
        'txtStreamerArgs
        '
        '
        '
        '
        Me.txtStreamerArgs.CustomButton.Image = Nothing
        Me.txtStreamerArgs.CustomButton.Location = New System.Drawing.Point(297, 2)
        Me.txtStreamerArgs.CustomButton.Name = ""
        Me.txtStreamerArgs.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtStreamerArgs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtStreamerArgs.CustomButton.TabIndex = 1
        Me.txtStreamerArgs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtStreamerArgs.CustomButton.UseSelectable = True
        Me.txtStreamerArgs.CustomButton.Visible = False
        Me.txtStreamerArgs.Lines = New String(-1) {}
        Me.txtStreamerArgs.Location = New System.Drawing.Point(129, 76)
        Me.txtStreamerArgs.MaxLength = 32767
        Me.txtStreamerArgs.Name = "txtStreamerArgs"
        Me.txtStreamerArgs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStreamerArgs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtStreamerArgs.SelectedText = ""
        Me.txtStreamerArgs.SelectionLength = 0
        Me.txtStreamerArgs.SelectionStart = 0
        Me.txtStreamerArgs.Size = New System.Drawing.Size(315, 20)
        Me.txtStreamerArgs.TabIndex = 4
        Me.txtStreamerArgs.UseSelectable = True
        Me.txtStreamerArgs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtStreamerArgs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel7.Location = New System.Drawing.Point(4, 50)
        Me.MetroLabel7.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(76, 19)
        Me.MetroLabel7.TabIndex = 53
        Me.MetroLabel7.Text = "Player args"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Regular
        Me.MetroLabel6.Location = New System.Drawing.Point(4, 25)
        Me.MetroLabel6.Margin = New System.Windows.Forms.Padding(3, 3, 3, 0)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(54, 19)
        Me.MetroLabel6.TabIndex = 51
        Me.MetroLabel6.Text = "Output"
        '
        'txtOutputPath
        '
        '
        '
        '
        Me.txtOutputPath.CustomButton.Image = Nothing
        Me.txtOutputPath.CustomButton.Location = New System.Drawing.Point(297, 2)
        Me.txtOutputPath.CustomButton.Name = ""
        Me.txtOutputPath.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtOutputPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtOutputPath.CustomButton.TabIndex = 1
        Me.txtOutputPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtOutputPath.CustomButton.UseSelectable = True
        Me.txtOutputPath.CustomButton.Visible = False
        Me.txtOutputPath.Lines = New String(-1) {}
        Me.txtOutputPath.Location = New System.Drawing.Point(129, 24)
        Me.txtOutputPath.MaxLength = 32767
        Me.txtOutputPath.Name = "txtOutputPath"
        Me.txtOutputPath.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOutputPath.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtOutputPath.SelectedText = ""
        Me.txtOutputPath.SelectionLength = 0
        Me.txtOutputPath.SelectionStart = 0
        Me.txtOutputPath.Size = New System.Drawing.Size(315, 20)
        Me.txtOutputPath.TabIndex = 3
        Me.txtOutputPath.UseSelectable = True
        Me.txtOutputPath.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtOutputPath.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'chkEnableOutput
        '
        Me.chkEnableOutput.AutoSize = True
        Me.chkEnableOutput.Location = New System.Drawing.Point(449, 26)
        Me.chkEnableOutput.Name = "chkEnableOutput"
        Me.chkEnableOutput.Size = New System.Drawing.Size(58, 15)
        Me.chkEnableOutput.TabIndex = 2
        Me.chkEnableOutput.Text = "Enable"
        Me.chkEnableOutput.UseSelectable = True
        '
        'chkEnableStreamArgs
        '
        Me.chkEnableStreamArgs.AutoSize = True
        Me.chkEnableStreamArgs.Location = New System.Drawing.Point(449, 80)
        Me.chkEnableStreamArgs.Name = "chkEnableStreamArgs"
        Me.chkEnableStreamArgs.Size = New System.Drawing.Size(58, 15)
        Me.chkEnableStreamArgs.TabIndex = 4
        Me.chkEnableStreamArgs.Text = "Enable"
        Me.chkEnableStreamArgs.UseSelectable = True
        '
        'chkEnablePlayerArgs
        '
        Me.chkEnablePlayerArgs.AutoSize = True
        Me.chkEnablePlayerArgs.Location = New System.Drawing.Point(449, 54)
        Me.chkEnablePlayerArgs.Name = "chkEnablePlayerArgs"
        Me.chkEnablePlayerArgs.Size = New System.Drawing.Size(58, 15)
        Me.chkEnablePlayerArgs.TabIndex = 4
        Me.chkEnablePlayerArgs.Text = "Enable"
        Me.chkEnablePlayerArgs.UseSelectable = True
        '
        'txtPlayerArgs
        '
        '
        '
        '
        Me.txtPlayerArgs.CustomButton.Image = Nothing
        Me.txtPlayerArgs.CustomButton.Location = New System.Drawing.Point(297, 2)
        Me.txtPlayerArgs.CustomButton.Name = ""
        Me.txtPlayerArgs.CustomButton.Size = New System.Drawing.Size(15, 15)
        Me.txtPlayerArgs.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPlayerArgs.CustomButton.TabIndex = 1
        Me.txtPlayerArgs.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPlayerArgs.CustomButton.UseSelectable = True
        Me.txtPlayerArgs.CustomButton.Visible = False
        Me.txtPlayerArgs.Lines = New String(-1) {}
        Me.txtPlayerArgs.Location = New System.Drawing.Point(129, 50)
        Me.txtPlayerArgs.MaxLength = 32767
        Me.txtPlayerArgs.Name = "txtPlayerArgs"
        Me.txtPlayerArgs.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPlayerArgs.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPlayerArgs.SelectedText = ""
        Me.txtPlayerArgs.SelectionLength = 0
        Me.txtPlayerArgs.SelectionStart = 0
        Me.txtPlayerArgs.Size = New System.Drawing.Size(315, 20)
        Me.txtPlayerArgs.TabIndex = 4
        Me.txtPlayerArgs.UseSelectable = True
        Me.txtPlayerArgs.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPlayerArgs.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'lnkShowAdvanced
        '
        Me.lnkShowAdvanced.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkShowAdvanced.Location = New System.Drawing.Point(4, 3)
        Me.lnkShowAdvanced.Name = "lnkShowAdvanced"
        Me.lnkShowAdvanced.Size = New System.Drawing.Size(100, 23)
        Me.lnkShowAdvanced.TabIndex = 53
        Me.lnkShowAdvanced.Text = "Show Advanced"
        Me.lnkShowAdvanced.UseSelectable = True
        '
        'pnlBasic
        '
        Me.pnlBasic.Controls.Add(Me.MetroLabel2)
        Me.pnlBasic.Controls.Add(Me.MetroLabel3)
        Me.pnlBasic.Controls.Add(Me.MetroLabel4)
        Me.pnlBasic.Controls.Add(Me.MetroLabel1)
        Me.pnlBasic.Controls.Add(Me.MetroPanel2)
        Me.pnlBasic.Controls.Add(Me.MetroPanel1)
        Me.pnlBasic.Controls.Add(Me.MetroPanel5)
        Me.pnlBasic.Controls.Add(Me.MetroPanel3)
        Me.pnlBasic.HorizontalScrollbarBarColor = True
        Me.pnlBasic.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlBasic.HorizontalScrollbarSize = 10
        Me.pnlBasic.Location = New System.Drawing.Point(3, 3)
        Me.pnlBasic.Name = "pnlBasic"
        Me.pnlBasic.Size = New System.Drawing.Size(547, 106)
        Me.pnlBasic.TabIndex = 54
        Me.pnlBasic.VerticalScrollbarBarColor = True
        Me.pnlBasic.VerticalScrollbarHighlightOnWheel = False
        Me.pnlBasic.VerticalScrollbarSize = 10
        '
        'pnlAdvanced
        '
        Me.pnlAdvanced.Controls.Add(Me.chkEnableStreamArgs)
        Me.pnlAdvanced.Controls.Add(Me.txtOutputPath)
        Me.pnlAdvanced.Controls.Add(Me.MetroLabel8)
        Me.pnlAdvanced.Controls.Add(Me.chkEnableOutput)
        Me.pnlAdvanced.Controls.Add(Me.MetroLabel7)
        Me.pnlAdvanced.Controls.Add(Me.chkEnablePlayerArgs)
        Me.pnlAdvanced.Controls.Add(Me.txtStreamerArgs)
        Me.pnlAdvanced.Controls.Add(Me.txtPlayerArgs)
        Me.pnlAdvanced.Controls.Add(Me.MetroLabel5)
        Me.pnlAdvanced.Controls.Add(Me.MetroLabel6)
        Me.pnlAdvanced.Controls.Add(Me.MetroPanel4)
        Me.pnlAdvanced.HorizontalScrollbarBarColor = True
        Me.pnlAdvanced.HorizontalScrollbarHighlightOnWheel = False
        Me.pnlAdvanced.HorizontalScrollbarSize = 10
        Me.pnlAdvanced.Location = New System.Drawing.Point(3, 115)
        Me.pnlAdvanced.Name = "pnlAdvanced"
        Me.pnlAdvanced.Size = New System.Drawing.Size(547, 100)
        Me.pnlAdvanced.TabIndex = 55
        Me.pnlAdvanced.VerticalScrollbarBarColor = True
        Me.pnlAdvanced.VerticalScrollbarHighlightOnWheel = False
        Me.pnlAdvanced.VerticalScrollbarSize = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlBasic)
        Me.FlowLayoutPanel1.Controls.Add(Me.pnlAdvanced)
        Me.FlowLayoutPanel1.Controls.Add(Me.MetroPanel6)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 3)
        Me.FlowLayoutPanel1.MaximumSize = New System.Drawing.Size(700, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(553, 255)
        Me.FlowLayoutPanel1.TabIndex = 56
        '
        'MetroPanel6
        '
        Me.MetroPanel6.Controls.Add(Me.lnkShowAdvanced)
        Me.MetroPanel6.Controls.Add(Me.btnWatch)
        Me.MetroPanel6.Controls.Add(Me.btnCancel)
        Me.MetroPanel6.HorizontalScrollbarBarColor = True
        Me.MetroPanel6.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.HorizontalScrollbarSize = 10
        Me.MetroPanel6.Location = New System.Drawing.Point(3, 221)
        Me.MetroPanel6.Name = "MetroPanel6"
        Me.MetroPanel6.Size = New System.Drawing.Size(547, 31)
        Me.MetroPanel6.TabIndex = 57
        Me.MetroPanel6.VerticalScrollbarBarColor = True
        Me.MetroPanel6.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel6.VerticalScrollbarSize = 10
        '
        'WatchGameControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "WatchGameControl"
        Me.Size = New System.Drawing.Size(581, 291)
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.MetroPanel5.ResumeLayout(False)
        Me.MetroPanel5.PerformLayout()
        Me.pnlBasic.ResumeLayout(False)
        Me.pnlBasic.PerformLayout()
        Me.pnlAdvanced.ResumeLayout(False)
        Me.pnlAdvanced.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.MetroPanel6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnWatch As MetroFramework.Controls.MetroButton
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbMPC As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents lnkMPCDownload As MetroFramework.Controls.MetroLink
    Friend WithEvents rbVLC As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents lnkVLCDownload As MetroFramework.Controls.MetroLink
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbVOD As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbLive As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbAkamai As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbLevel3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents chk60 As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents rbQual6 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual5 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual4 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual2 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual3 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbQual1 As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel5 As MetroFramework.Controls.MetroPanel
    Friend WithEvents rbFrench As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbAway As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbNational As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents rbHome As MetroFramework.Controls.MetroRadioButton
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtOutputPath As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkEnableOutput As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents SaveFileDialog As SaveFileDialog
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtStreamerArgs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents chkEnablePlayerArgs As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents txtPlayerArgs As MetroFramework.Controls.MetroTextBox
    Friend WithEvents chkEnableStreamArgs As MetroFramework.Controls.MetroCheckBox
    Friend WithEvents lnkShowAdvanced As MetroFramework.Controls.MetroLink
    Friend WithEvents pnlBasic As MetroFramework.Controls.MetroPanel
    Friend WithEvents pnlAdvanced As MetroFramework.Controls.MetroPanel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents MetroPanel6 As MetroFramework.Controls.MetroPanel
End Class
