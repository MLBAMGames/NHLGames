<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GameControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.TeamToolTip = New MetroFramework.Components.MetroToolTip()
        Me.BorderPanel1 = New BorderPanel()
        Me.lblAwayTeam = New MetroFramework.Controls.MetroLabel()
        Me.picAway = New System.Windows.Forms.PictureBox()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.lblHomeTeam = New MetroFramework.Controls.MetroLabel()
        Me.lblLive = New System.Windows.Forms.Label()
        Me.lblPeriod = New MetroFramework.Controls.MetroLabel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblNoStream = New System.Windows.Forms.Label()
        Me.lblHomeStream = New System.Windows.Forms.LinkLabel()
        Me.lblAwayStream = New System.Windows.Forms.LinkLabel()
        Me.lblFrenchStream = New System.Windows.Forms.LinkLabel()
        Me.lblNationalStream = New System.Windows.Forms.LinkLabel()
        Me.lblMultiCam1 = New System.Windows.Forms.LinkLabel()
        Me.lblMultiCam2 = New System.Windows.Forms.LinkLabel()
        Me.lblRefCam = New System.Windows.Forms.LinkLabel()
        Me.lblEndzoneCam1 = New System.Windows.Forms.LinkLabel()
        Me.lblEndzoneCam2 = New System.Windows.Forms.LinkLabel()
        Me.lblHomeScore = New MetroFramework.Controls.MetroLabel()
        Me.lblAwayScore = New MetroFramework.Controls.MetroLabel()
        Me.lblVS = New MetroFramework.Controls.MetroLabel()
        Me.lblTime = New MetroFramework.Controls.MetroLabel()
        Me.lblNotInSeason = New MetroFramework.Controls.MetroLabel()
        Me.FeedToolTip = New MetroFramework.Components.MetroToolTip()
        Me.BorderPanel1.SuspendLayout()
        CType(Me.picAway, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TeamToolTip
        '
        Me.TeamToolTip.Style = MetroFramework.MetroColorStyle.[Default]
        Me.TeamToolTip.StyleManager = Nothing
        Me.TeamToolTip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'BorderPanel1
        '
        Me.BorderPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderPanel1.BorderColour = System.Drawing.Color.LightGray
        Me.BorderPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.BorderPanel1.Controls.Add(Me.lblAwayTeam)
        Me.BorderPanel1.Controls.Add(Me.picAway)
        Me.BorderPanel1.Controls.Add(Me.picHome)
        Me.BorderPanel1.Controls.Add(Me.lblHomeTeam)
        Me.BorderPanel1.Controls.Add(Me.lblLive)
        Me.BorderPanel1.Controls.Add(Me.lblPeriod)
        Me.BorderPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.BorderPanel1.Controls.Add(Me.lblHomeScore)
        Me.BorderPanel1.Controls.Add(Me.lblAwayScore)
        Me.BorderPanel1.Controls.Add(Me.lblVS)
        Me.BorderPanel1.Controls.Add(Me.lblTime)
        Me.BorderPanel1.Controls.Add(Me.lblNotInSeason)
        Me.BorderPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BorderPanel1.Location = New System.Drawing.Point(10, 10)
        Me.BorderPanel1.Name = "BorderPanel1"
        Me.BorderPanel1.Size = New System.Drawing.Size(310, 160)
        Me.BorderPanel1.TabIndex = 9
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.Location = New System.Drawing.Point(28, 53)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(55, 19)
        Me.lblAwayTeam.TabIndex = 4
        Me.lblAwayTeam.Text = "Away"
        Me.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picAway
        '
        Me.picAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picAway.Location = New System.Drawing.Point(28, 16)
        Me.picAway.Name = "picAway"
        Me.picAway.Size = New System.Drawing.Size(55, 34)
        Me.picAway.TabIndex = 0
        Me.picAway.TabStop = False
        '
        'picHome
        '
        Me.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picHome.Location = New System.Drawing.Point(220, 16)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(55, 34)
        Me.picHome.TabIndex = 1
        Me.picHome.TabStop = False
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.Location = New System.Drawing.Point(220, 53)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(55, 19)
        Me.lblHomeTeam.TabIndex = 4
        Me.lblHomeTeam.Text = "Home"
        Me.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLive
        '
        Me.lblLive.BackColor = System.Drawing.Color.Transparent
        Me.lblLive.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLive.ForeColor = System.Drawing.Color.Red
        Me.lblLive.Location = New System.Drawing.Point(280, -6)
        Me.lblLive.Name = "lblLive"
        Me.lblLive.Size = New System.Drawing.Size(30, 30)
        Me.lblLive.TabIndex = 12
        Me.lblLive.Text = "•"
        Me.lblLive.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblLive.Visible = False
        '
        'lblPeriod
        '
        Me.lblPeriod.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblPeriod.Location = New System.Drawing.Point(2, 5)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(303, 24)
        Me.lblPeriod.TabIndex = 11
        Me.lblPeriod.Text = "Period"
        Me.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.FlowLayoutPanel1.Controls.Add(Me.lblNoStream)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblHomeStream)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblAwayStream)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblFrenchStream)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblNationalStream)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblMultiCam1)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblMultiCam2)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblRefCam)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblEndzoneCam1)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblEndzoneCam2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(2, 85)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(303, 70)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'lblNoStream
        '
        Me.lblNoStream.AutoSize = True
        Me.lblNoStream.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!)
        Me.lblNoStream.ForeColor = System.Drawing.Color.Black
        Me.lblNoStream.Location = New System.Drawing.Point(8, 5)
        Me.lblNoStream.Name = "lblNoStream"
        Me.lblNoStream.Size = New System.Drawing.Size(111, 15)
        Me.lblNoStream.TabIndex = 17
        Me.lblNoStream.Text = "No stream available"
        '
        'lblHomeStream
        '
        Me.lblHomeStream.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHomeStream.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblHomeStream.AutoSize = True
        Me.lblHomeStream.BackColor = System.Drawing.Color.Transparent
        Me.lblHomeStream.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblHomeStream.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomeStream.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblHomeStream.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblHomeStream.LinkColor = System.Drawing.Color.Black
        Me.lblHomeStream.Location = New System.Drawing.Point(125, 5)
        Me.lblHomeStream.Name = "lblHomeStream"
        Me.lblHomeStream.Size = New System.Drawing.Size(40, 15)
        Me.lblHomeStream.TabIndex = 11
        Me.lblHomeStream.TabStop = True
        Me.lblHomeStream.Text = "Home"
        Me.lblHomeStream.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblAwayStream
        '
        Me.lblAwayStream.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAwayStream.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAwayStream.AutoSize = True
        Me.lblAwayStream.BackColor = System.Drawing.Color.Transparent
        Me.lblAwayStream.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAwayStream.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAwayStream.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblAwayStream.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblAwayStream.LinkColor = System.Drawing.Color.Black
        Me.lblAwayStream.Location = New System.Drawing.Point(171, 5)
        Me.lblAwayStream.Name = "lblAwayStream"
        Me.lblAwayStream.Size = New System.Drawing.Size(36, 15)
        Me.lblAwayStream.TabIndex = 8
        Me.lblAwayStream.TabStop = True
        Me.lblAwayStream.Text = "Away"
        Me.lblAwayStream.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblFrenchStream
        '
        Me.lblFrenchStream.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFrenchStream.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFrenchStream.AutoSize = True
        Me.lblFrenchStream.BackColor = System.Drawing.Color.Transparent
        Me.lblFrenchStream.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblFrenchStream.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrenchStream.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblFrenchStream.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblFrenchStream.LinkColor = System.Drawing.Color.Black
        Me.lblFrenchStream.Location = New System.Drawing.Point(213, 5)
        Me.lblFrenchStream.Name = "lblFrenchStream"
        Me.lblFrenchStream.Size = New System.Drawing.Size(43, 15)
        Me.lblFrenchStream.TabIndex = 9
        Me.lblFrenchStream.TabStop = True
        Me.lblFrenchStream.Text = "French"
        Me.lblFrenchStream.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblNationalStream
        '
        Me.lblNationalStream.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNationalStream.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNationalStream.AutoSize = True
        Me.lblNationalStream.BackColor = System.Drawing.Color.Transparent
        Me.lblNationalStream.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblNationalStream.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNationalStream.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblNationalStream.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblNationalStream.LinkColor = System.Drawing.Color.Black
        Me.lblNationalStream.Location = New System.Drawing.Point(8, 20)
        Me.lblNationalStream.Name = "lblNationalStream"
        Me.lblNationalStream.Size = New System.Drawing.Size(52, 15)
        Me.lblNationalStream.TabIndex = 10
        Me.lblNationalStream.TabStop = True
        Me.lblNationalStream.Text = "National"
        Me.lblNationalStream.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblMultiCam1
        '
        Me.lblMultiCam1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMultiCam1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMultiCam1.AutoSize = True
        Me.lblMultiCam1.BackColor = System.Drawing.Color.Transparent
        Me.lblMultiCam1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMultiCam1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiCam1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMultiCam1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblMultiCam1.LinkColor = System.Drawing.Color.Black
        Me.lblMultiCam1.Location = New System.Drawing.Point(66, 20)
        Me.lblMultiCam1.Name = "lblMultiCam1"
        Me.lblMultiCam1.Size = New System.Drawing.Size(85, 15)
        Me.lblMultiCam1.TabIndex = 12
        Me.lblMultiCam1.TabStop = True
        Me.lblMultiCam1.Text = "3 Camera View"
        Me.lblMultiCam1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblMultiCam2
        '
        Me.lblMultiCam2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMultiCam2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMultiCam2.AutoSize = True
        Me.lblMultiCam2.BackColor = System.Drawing.Color.Transparent
        Me.lblMultiCam2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblMultiCam2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMultiCam2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblMultiCam2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblMultiCam2.LinkColor = System.Drawing.Color.Black
        Me.lblMultiCam2.Location = New System.Drawing.Point(157, 20)
        Me.lblMultiCam2.Name = "lblMultiCam2"
        Me.lblMultiCam2.Size = New System.Drawing.Size(85, 15)
        Me.lblMultiCam2.TabIndex = 13
        Me.lblMultiCam2.TabStop = True
        Me.lblMultiCam2.Text = "6 Camera View"
        Me.lblMultiCam2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblRefCam
        '
        Me.lblRefCam.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRefCam.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRefCam.AutoSize = True
        Me.lblRefCam.BackColor = System.Drawing.Color.Transparent
        Me.lblRefCam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblRefCam.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRefCam.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblRefCam.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblRefCam.LinkColor = System.Drawing.Color.Black
        Me.lblRefCam.Location = New System.Drawing.Point(8, 35)
        Me.lblRefCam.Name = "lblRefCam"
        Me.lblRefCam.Size = New System.Drawing.Size(52, 15)
        Me.lblRefCam.TabIndex = 14
        Me.lblRefCam.TabStop = True
        Me.lblRefCam.Text = "Ref Cam"
        Me.lblRefCam.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblEndzoneCam1
        '
        Me.lblEndzoneCam1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEndzoneCam1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEndzoneCam1.AutoSize = True
        Me.lblEndzoneCam1.BackColor = System.Drawing.Color.Transparent
        Me.lblEndzoneCam1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEndzoneCam1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndzoneCam1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEndzoneCam1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblEndzoneCam1.LinkColor = System.Drawing.Color.Black
        Me.lblEndzoneCam1.Location = New System.Drawing.Point(66, 35)
        Me.lblEndzoneCam1.Name = "lblEndzoneCam1"
        Me.lblEndzoneCam1.Size = New System.Drawing.Size(89, 15)
        Me.lblEndzoneCam1.TabIndex = 15
        Me.lblEndzoneCam1.TabStop = True
        Me.lblEndzoneCam1.Text = "Endzone Cam 1"
        Me.lblEndzoneCam1.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblEndzoneCam2
        '
        Me.lblEndzoneCam2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEndzoneCam2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEndzoneCam2.AutoSize = True
        Me.lblEndzoneCam2.BackColor = System.Drawing.Color.Transparent
        Me.lblEndzoneCam2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEndzoneCam2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndzoneCam2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblEndzoneCam2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lblEndzoneCam2.LinkColor = System.Drawing.Color.Black
        Me.lblEndzoneCam2.Location = New System.Drawing.Point(161, 35)
        Me.lblEndzoneCam2.Name = "lblEndzoneCam2"
        Me.lblEndzoneCam2.Size = New System.Drawing.Size(89, 15)
        Me.lblEndzoneCam2.TabIndex = 16
        Me.lblEndzoneCam2.TabStop = True
        Me.lblEndzoneCam2.Text = "Endzone Cam 2"
        Me.lblEndzoneCam2.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'lblHomeScore
        '
        Me.lblHomeScore.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblHomeScore.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblHomeScore.Location = New System.Drawing.Point(179, 36)
        Me.lblHomeScore.Name = "lblHomeScore"
        Me.lblHomeScore.Size = New System.Drawing.Size(126, 25)
        Me.lblHomeScore.TabIndex = 5
        Me.lblHomeScore.Text = "0"
        '
        'lblAwayScore
        '
        Me.lblAwayScore.FontSize = MetroFramework.MetroLabelSize.Tall
        Me.lblAwayScore.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblAwayScore.Location = New System.Drawing.Point(2, 36)
        Me.lblAwayScore.Margin = New System.Windows.Forms.Padding(0)
        Me.lblAwayScore.Name = "lblAwayScore"
        Me.lblAwayScore.Size = New System.Drawing.Size(126, 25)
        Me.lblAwayScore.TabIndex = 5
        Me.lblAwayScore.Text = "0"
        Me.lblAwayScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVS
        '
        Me.lblVS.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblVS.Location = New System.Drawing.Point(2, 40)
        Me.lblVS.Name = "lblVS"
        Me.lblVS.Size = New System.Drawing.Size(303, 19)
        Me.lblVS.TabIndex = 2
        Me.lblVS.Text = "VS"
        Me.lblVS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTime
        '
        Me.lblTime.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblTime.Location = New System.Drawing.Point(2, 24)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(303, 18)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "7:30 PM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNotInSeason
        '
        Me.lblNotInSeason.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblNotInSeason.Location = New System.Drawing.Point(2, 56)
        Me.lblNotInSeason.Name = "lblNotInSeason"
        Me.lblNotInSeason.Size = New System.Drawing.Size(303, 19)
        Me.lblNotInSeason.TabIndex = 13
        Me.lblNotInSeason.Text = "NotInSeason"
        Me.lblNotInSeason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FeedToolTip
        '
        Me.FeedToolTip.Style = MetroFramework.MetroColorStyle.[Default]
        Me.FeedToolTip.StyleManager = Nothing
        Me.FeedToolTip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'GameControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BorderPanel1)
        Me.Name = "GameControl"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(330, 180)
        Me.BorderPanel1.ResumeLayout(False)
        CType(Me.picAway, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picAway As PictureBox
    Friend WithEvents lblVS As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAwayTeam As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHomeTeam As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAwayScore As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHomeScore As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents BorderPanel1 As BorderPanel
    Friend WithEvents TeamToolTip As MetroFramework.Components.MetroToolTip
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblAwayStream As LinkLabel
    Friend WithEvents lblFrenchStream As LinkLabel
    Friend WithEvents lblNationalStream As LinkLabel
    Friend WithEvents lblHomeStream As LinkLabel
    Friend WithEvents lblMultiCam1 As LinkLabel
    Friend WithEvents lblMultiCam2 As LinkLabel
    Friend WithEvents lblRefCam As LinkLabel
    Friend WithEvents lblEndzoneCam1 As LinkLabel
    Friend WithEvents lblEndzoneCam2 As LinkLabel
    Friend WithEvents lblLive As Label
    Friend WithEvents lblPeriod As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblNoStream As Label
    Friend WithEvents lblNotInSeason As MetroFramework.Controls.MetroLabel
    Friend WithEvents picHome As PictureBox
    Friend WithEvents FeedToolTip As MetroFramework.Components.MetroToolTip
End Class
