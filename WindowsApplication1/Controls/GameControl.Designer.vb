<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameControl
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HomeTeamToolTip = New MetroFramework.Components.MetroToolTip()
        Me.AwayTeamToolTip = New MetroFramework.Components.MetroToolTip()
        Me.BorderPanel1 = New BorderPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.lblHomeStream = New System.Windows.Forms.LinkLabel()
        Me.lblAwayStream = New System.Windows.Forms.LinkLabel()
        Me.lblFrenchStream = New System.Windows.Forms.LinkLabel()
        Me.lblNationalStream = New System.Windows.Forms.LinkLabel()
        Me.picAway = New System.Windows.Forms.PictureBox()
        Me.lblTime = New MetroFramework.Controls.MetroLabel()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.lblVS = New MetroFramework.Controls.MetroLabel()
        Me.lblHomeScore = New MetroFramework.Controls.MetroLabel()
        Me.lblAwayTeam = New MetroFramework.Controls.MetroLabel()
        Me.lblAwayScore = New MetroFramework.Controls.MetroLabel()
        Me.lblHomeTeam = New MetroFramework.Controls.MetroLabel()
        Me.BorderPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.picAway, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HomeTeamToolTip
        '
        Me.HomeTeamToolTip.Style = MetroFramework.MetroColorStyle.[Default]
        Me.HomeTeamToolTip.StyleManager = Nothing
        Me.HomeTeamToolTip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'AwayTeamToolTip
        '
        Me.AwayTeamToolTip.Style = MetroFramework.MetroColorStyle.[Default]
        Me.AwayTeamToolTip.StyleManager = Nothing
        Me.AwayTeamToolTip.Theme = MetroFramework.MetroThemeStyle.Light
        '
        'BorderPanel1
        '
        Me.BorderPanel1.BorderColour = System.Drawing.Color.LightGray
        Me.BorderPanel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.BorderPanel1.Controls.Add(Me.picAway)
        Me.BorderPanel1.Controls.Add(Me.lblTime)
        Me.BorderPanel1.Controls.Add(Me.picHome)
        Me.BorderPanel1.Controls.Add(Me.lblVS)
        Me.BorderPanel1.Controls.Add(Me.lblHomeScore)
        Me.BorderPanel1.Controls.Add(Me.lblAwayTeam)
        Me.BorderPanel1.Controls.Add(Me.lblAwayScore)
        Me.BorderPanel1.Controls.Add(Me.lblHomeTeam)
        Me.BorderPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BorderPanel1.Name = "BorderPanel1"
        Me.BorderPanel1.Size = New System.Drawing.Size(313, 95)
        Me.BorderPanel1.TabIndex = 9
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.lblHomeStream)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblAwayStream)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblFrenchStream)
        Me.FlowLayoutPanel1.Controls.Add(Me.lblNationalStream)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(1, 69)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(5, 5, 5, 0)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(310, 24)
        Me.FlowLayoutPanel1.TabIndex = 10
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
        Me.lblHomeStream.Location = New System.Drawing.Point(8, 5)
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
        Me.lblAwayStream.Location = New System.Drawing.Point(54, 5)
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
        Me.lblFrenchStream.Location = New System.Drawing.Point(96, 5)
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
        Me.lblNationalStream.Location = New System.Drawing.Point(145, 5)
        Me.lblNationalStream.Name = "lblNationalStream"
        Me.lblNationalStream.Size = New System.Drawing.Size(52, 15)
        Me.lblNationalStream.TabIndex = 10
        Me.lblNationalStream.TabStop = True
        Me.lblNationalStream.Text = "National"
        Me.lblNationalStream.VisitedLinkColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        '
        'picAway
        '
        Me.picAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picAway.Location = New System.Drawing.Point(48, 13)
        Me.picAway.Name = "picAway"
        Me.picAway.Size = New System.Drawing.Size(55, 34)
        Me.picAway.TabIndex = 0
        Me.picAway.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(109, 17)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(89, 19)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "7:30 PM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picHome
        '
        Me.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picHome.Location = New System.Drawing.Point(204, 13)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(55, 34)
        Me.picHome.TabIndex = 1
        Me.picHome.TabStop = False
        '
        'lblVS
        '
        Me.lblVS.AutoSize = True
        Me.lblVS.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblVS.Location = New System.Drawing.Point(140, 36)
        Me.lblVS.Name = "lblVS"
        Me.lblVS.Size = New System.Drawing.Size(26, 19)
        Me.lblVS.TabIndex = 2
        Me.lblVS.Text = "VS"
        '
        'lblHomeScore
        '
        Me.lblHomeScore.AutoSize = True
        Me.lblHomeScore.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblHomeScore.Location = New System.Drawing.Point(172, 36)
        Me.lblHomeScore.Name = "lblHomeScore"
        Me.lblHomeScore.Size = New System.Drawing.Size(17, 19)
        Me.lblHomeScore.TabIndex = 5
        Me.lblHomeScore.Text = "0"
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblAwayTeam.Location = New System.Drawing.Point(48, 50)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(55, 19)
        Me.lblAwayTeam.TabIndex = 4
        Me.lblAwayTeam.Text = "Away"
        Me.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAwayScore
        '
        Me.lblAwayScore.AutoSize = True
        Me.lblAwayScore.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblAwayScore.Location = New System.Drawing.Point(117, 36)
        Me.lblAwayScore.Name = "lblAwayScore"
        Me.lblAwayScore.Size = New System.Drawing.Size(17, 19)
        Me.lblAwayScore.TabIndex = 5
        Me.lblAwayScore.Text = "0"
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.FontSize = MetroFramework.MetroLabelSize.Small
        Me.lblHomeTeam.Location = New System.Drawing.Point(204, 50)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(55, 19)
        Me.lblHomeTeam.TabIndex = 4
        Me.lblHomeTeam.Text = "Home"
        Me.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BorderPanel1)
        Me.Name = "GameControl"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(320, 102)
        Me.BorderPanel1.ResumeLayout(False)
        Me.BorderPanel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.picAway, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picAway As PictureBox
    Friend WithEvents picHome As PictureBox
    Friend WithEvents lblVS As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAwayTeam As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHomeTeam As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAwayScore As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHomeScore As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents BorderPanel1 As BorderPanel
    Friend WithEvents HomeTeamToolTip As MetroFramework.Components.MetroToolTip
    Private WithEvents AwayTeamToolTip As MetroFramework.Components.MetroToolTip
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents lblAwayStream As LinkLabel
    Friend WithEvents lblFrenchStream As LinkLabel
    Friend WithEvents lblNationalStream As LinkLabel
    Friend WithEvents lblHomeStream As LinkLabel
End Class
