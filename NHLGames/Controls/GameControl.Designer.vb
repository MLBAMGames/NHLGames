Imports System.ComponentModel
Imports MetroFramework
Imports MetroFramework.Components
Imports MetroFramework.Controls
Imports Microsoft.VisualBasic.CompilerServices
Imports NHLGames.Utilities

Namespace Controls
    <DesignerGenerated()>
    Partial Class GameControl
        Inherits UserControl
        Implements IDisposable

        'Required by the Windows Form Designer
        Private components As IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim resources As ComponentResourceManager = New ComponentResourceManager(GetType(GameControl))
            Me.tt = New MetroToolTip()
            Me.bpGameControl = New BorderPanel()
            Me.btnLiveReplay = New Button()
            Me.lblGameStatus = New MetroLabel()
            Me.lblDivider = New MetroLabel()
            Me.picAway = New PictureBox()
            Me.lblHomeScore = New MetroLabel()
            Me.lblAwayScore = New MetroLabel()
            Me.lblAwayTeam = New MetroLabel()
            Me.picHome = New PictureBox()
            Me.lblHomeTeam = New MetroLabel()
            Me.lblPeriod = New MetroLabel()
            Me.flpStreams = New FlowLayoutPanel()
            Me.lnkHome = New Button()
            Me.lnkAway = New Button()
            Me.lnkNational = New Button()
            Me.lnkFrench = New Button()
            Me.lnkThree = New Button()
            Me.lnkSix = New Button()
            Me.lnkEnd1 = New Button()
            Me.lnkEnd2 = New Button()
            Me.lnkRef = New Button()
            Me.lnkStar = New Button()
            Me.lblNotInSeason = New MetroLabel()
            Me.lblStreamStatus = New MetroLabel()
            Me.bpGameControl.SuspendLayout()
            CType(Me.picAway, ISupportInitialize).BeginInit()
            CType(Me.picHome, ISupportInitialize).BeginInit()
            Me.flpStreams.SuspendLayout()
            Me.SuspendLayout()
            '
            'tt
            '
            Me.tt.AutomaticDelay = 100
            Me.tt.Style = MetroColorStyle.[Default]
            Me.tt.StyleManager = Nothing
            Me.tt.Theme = MetroThemeStyle.Light
            '
            'bpGameControl
            '
            Me.bpGameControl.BackgroundImageLayout = ImageLayout.None
            Me.bpGameControl.BorderColour = Color.LightGray
            Me.bpGameControl.BorderStyle = BorderStyle.FixedSingle
            Me.bpGameControl.Controls.Add(Me.btnLiveReplay)
            Me.bpGameControl.Controls.Add(Me.lblGameStatus)
            Me.bpGameControl.Controls.Add(Me.lblDivider)
            Me.bpGameControl.Controls.Add(Me.picAway)
            Me.bpGameControl.Controls.Add(Me.lblHomeScore)
            Me.bpGameControl.Controls.Add(Me.lblAwayScore)
            Me.bpGameControl.Controls.Add(Me.lblAwayTeam)
            Me.bpGameControl.Controls.Add(Me.picHome)
            Me.bpGameControl.Controls.Add(Me.lblHomeTeam)
            Me.bpGameControl.Controls.Add(Me.lblPeriod)
            Me.bpGameControl.Controls.Add(Me.flpStreams)
            Me.bpGameControl.Controls.Add(Me.lblNotInSeason)
            Me.bpGameControl.Controls.Add(Me.lblStreamStatus)
            Me.bpGameControl.Dock = DockStyle.Fill
            Me.bpGameControl.Location = New Point(0, 0)
            Me.bpGameControl.Name = "bpGameControl"
            Me.bpGameControl.Size = New Size(312, 151)
            Me.bpGameControl.TabIndex = 9
            '
            'btnLiveReplay
            '
            Me.btnLiveReplay.BackColor = Color.Red
            Me.btnLiveReplay.BackgroundImageLayout = ImageLayout.Zoom
            Me.btnLiveReplay.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.btnLiveReplay.FlatAppearance.BorderSize = 0
            Me.btnLiveReplay.FlatAppearance.MouseDownBackColor = Color.White
            Me.btnLiveReplay.FlatAppearance.MouseOverBackColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.btnLiveReplay.FlatStyle = FlatStyle.Flat
            Me.btnLiveReplay.ForeColor = Color.Black
            Me.btnLiveReplay.Location = New Point(2, 1)
            Me.btnLiveReplay.Name = "btnLiveReplay"
            Me.btnLiveReplay.Size = New Size(18, 18)
            Me.btnLiveReplay.TabIndex = 32
            Me.btnLiveReplay.UseVisualStyleBackColor = False
            Me.btnLiveReplay.Visible = False
            '
            'lblGameStatus
            '
            Me.lblGameStatus.BackColor = Color.Transparent
            Me.lblGameStatus.FontWeight = MetroLabelWeight.Regular
            Me.lblGameStatus.Location = New Point(97, 35)
            Me.lblGameStatus.Name = "lblGameStatus"
            Me.lblGameStatus.Size = New Size(116, 50)
            Me.lblGameStatus.TabIndex = 25
            Me.lblGameStatus.Text = "GAME_STATUS"
            Me.lblGameStatus.TextAlign = ContentAlignment.MiddleCenter
            Me.lblGameStatus.UseCustomBackColor = True
            Me.lblGameStatus.Visible = False
            '
            'lblDivider
            '
            Me.lblDivider.BackColor = Color.Silver
            Me.lblDivider.Location = New Point(155, 35)
            Me.lblDivider.Name = "lblDivider"
            Me.lblDivider.Size = New Size(1, 50)
            Me.lblDivider.TabIndex = 29
            Me.lblDivider.UseCustomBackColor = True
            '
            'picAway
            '
            Me.picAway.BackgroundImage = CType(resources.GetObject("picAway.BackgroundImage"), Image)
            Me.picAway.BackgroundImageLayout = ImageLayout.Zoom
            Me.picAway.Location = New Point(27, 35)
            Me.picAway.Name = "picAway"
            Me.picAway.Size = New Size(65, 50)
            Me.picAway.TabIndex = 0
            Me.picAway.TabStop = False
            '
            'lblHomeScore
            '
            Me.lblHomeScore.BackColor = Color.Transparent
            Me.lblHomeScore.FontSize = MetroLabelSize.Tall
            Me.lblHomeScore.FontWeight = MetroLabelWeight.Bold
            Me.lblHomeScore.Location = New Point(160, 35)
            Me.lblHomeScore.Margin = New Padding(0)
            Me.lblHomeScore.Name = "lblHomeScore"
            Me.lblHomeScore.Size = New Size(50, 50)
            Me.lblHomeScore.TabIndex = 24
            Me.lblHomeScore.Text = "0"
            Me.lblHomeScore.TextAlign = ContentAlignment.MiddleCenter
            Me.lblHomeScore.UseCustomBackColor = True
            Me.lblHomeScore.UseCustomForeColor = True
            '
            'lblAwayScore
            '
            Me.lblAwayScore.BackColor = Color.Transparent
            Me.lblAwayScore.FontSize = MetroLabelSize.Tall
            Me.lblAwayScore.FontWeight = MetroLabelWeight.Bold
            Me.lblAwayScore.Location = New Point(100, 35)
            Me.lblAwayScore.Margin = New Padding(0)
            Me.lblAwayScore.Name = "lblAwayScore"
            Me.lblAwayScore.Size = New Size(50, 50)
            Me.lblAwayScore.TabIndex = 23
            Me.lblAwayScore.Text = "0"
            Me.lblAwayScore.TextAlign = ContentAlignment.MiddleCenter
            Me.lblAwayScore.UseCustomBackColor = True
            Me.lblAwayScore.UseCustomForeColor = True
            '
            'lblAwayTeam
            '
            Me.lblAwayTeam.BackColor = Color.Transparent
            Me.lblAwayTeam.Location = New Point(30, 88)
            Me.lblAwayTeam.Name = "lblAwayTeam"
            Me.lblAwayTeam.Size = New Size(60, 20)
            Me.lblAwayTeam.TabIndex = 4
            Me.lblAwayTeam.Text = "AWAY"
            Me.lblAwayTeam.TextAlign = ContentAlignment.MiddleCenter
            Me.lblAwayTeam.UseCustomBackColor = True
            '
            'picHome
            '
            Me.picHome.BackgroundImage = CType(resources.GetObject("picHome.BackgroundImage"), Image)
            Me.picHome.BackgroundImageLayout = ImageLayout.Zoom
            Me.picHome.Location = New Point(218, 35)
            Me.picHome.Name = "picHome"
            Me.picHome.Size = New Size(65, 50)
            Me.picHome.TabIndex = 1
            Me.picHome.TabStop = False
            '
            'lblHomeTeam
            '
            Me.lblHomeTeam.BackColor = Color.Transparent
            Me.lblHomeTeam.Location = New Point(222, 88)
            Me.lblHomeTeam.Name = "lblHomeTeam"
            Me.lblHomeTeam.Size = New Size(60, 20)
            Me.lblHomeTeam.TabIndex = 4
            Me.lblHomeTeam.Text = "HOME"
            Me.lblHomeTeam.TextAlign = ContentAlignment.MiddleCenter
            Me.lblHomeTeam.UseCustomBackColor = True
            '
            'lblPeriod
            '
            Me.lblPeriod.BackColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lblPeriod.FontSize = MetroLabelSize.Small
            Me.lblPeriod.FontWeight = MetroLabelWeight.Bold
            Me.lblPeriod.ForeColor = Color.Black
            Me.lblPeriod.Location = New Point(1, 1)
            Me.lblPeriod.Name = "lblPeriod"
            Me.lblPeriod.Size = New Size(307, 20)
            Me.lblPeriod.TabIndex = 11
            Me.lblPeriod.Text = "PERIOD_STATUS"
            Me.lblPeriod.TextAlign = ContentAlignment.MiddleCenter
            Me.lblPeriod.UseCustomBackColor = True
            Me.lblPeriod.UseCustomForeColor = True
            '
            'flpStreams
            '
            Me.flpStreams.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                Or AnchorStyles.Right), AnchorStyles)
            Me.flpStreams.BackColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.flpStreams.Controls.Add(Me.lnkHome)
            Me.flpStreams.Controls.Add(Me.lnkAway)
            Me.flpStreams.Controls.Add(Me.lnkNational)
            Me.flpStreams.Controls.Add(Me.lnkFrench)
            Me.flpStreams.Controls.Add(Me.lnkThree)
            Me.flpStreams.Controls.Add(Me.lnkSix)
            Me.flpStreams.Controls.Add(Me.lnkEnd1)
            Me.flpStreams.Controls.Add(Me.lnkEnd2)
            Me.flpStreams.Controls.Add(Me.lnkRef)
            Me.flpStreams.Controls.Add(Me.lnkStar)
            Me.flpStreams.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.flpStreams.ImeMode = ImeMode.NoControl
            Me.flpStreams.Location = New Point(1, 109)
            Me.flpStreams.Name = "flpStreams"
            Me.flpStreams.Size = New Size(307, 38)
            Me.flpStreams.TabIndex = 10
            Me.flpStreams.WrapContents = False
            '
            'lnkHome
            '
            Me.lnkHome.BackgroundImage = CType(resources.GetObject("lnkHome.BackgroundImage"), Image)
            Me.lnkHome.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkHome.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkHome.FlatAppearance.BorderSize = 0
            Me.lnkHome.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkHome.FlatStyle = FlatStyle.Flat
            Me.lnkHome.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkHome.Location = New Point(4, 6)
            Me.lnkHome.Margin = New Padding(4, 6, 4, 6)
            Me.lnkHome.Name = "lnkHome"
            Me.lnkHome.Size = New Size(26, 26)
            Me.lnkHome.TabIndex = 29
            Me.lnkHome.UseVisualStyleBackColor = False
            Me.lnkHome.Visible = False
            '
            'lnkAway
            '
            Me.lnkAway.BackgroundImage = CType(resources.GetObject("lnkAway.BackgroundImage"), Image)
            Me.lnkAway.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkAway.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkAway.FlatAppearance.BorderSize = 0
            Me.lnkAway.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkAway.FlatStyle = FlatStyle.Flat
            Me.lnkAway.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkAway.Location = New Point(38, 6)
            Me.lnkAway.Margin = New Padding(4, 6, 4, 6)
            Me.lnkAway.Name = "lnkAway"
            Me.lnkAway.Size = New Size(26, 26)
            Me.lnkAway.TabIndex = 28
            Me.lnkAway.UseVisualStyleBackColor = False
            Me.lnkAway.Visible = False
            '
            'lnkNational
            '
            Me.lnkNational.BackgroundImage = CType(resources.GetObject("lnkNational.BackgroundImage"), Image)
            Me.lnkNational.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkNational.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkNational.FlatAppearance.BorderSize = 0
            Me.lnkNational.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkNational.FlatStyle = FlatStyle.Flat
            Me.lnkNational.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkNational.Location = New Point(72, 6)
            Me.lnkNational.Margin = New Padding(4, 6, 4, 6)
            Me.lnkNational.Name = "lnkNational"
            Me.lnkNational.Size = New Size(26, 26)
            Me.lnkNational.TabIndex = 29
            Me.lnkNational.UseVisualStyleBackColor = False
            Me.lnkNational.Visible = False
            '
            'lnkFrench
            '
            Me.lnkFrench.BackgroundImage = CType(resources.GetObject("lnkFrench.BackgroundImage"), Image)
            Me.lnkFrench.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkFrench.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkFrench.FlatAppearance.BorderSize = 0
            Me.lnkFrench.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkFrench.FlatStyle = FlatStyle.Flat
            Me.lnkFrench.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkFrench.Location = New Point(106, 6)
            Me.lnkFrench.Margin = New Padding(4, 6, 4, 6)
            Me.lnkFrench.Name = "lnkFrench"
            Me.lnkFrench.Size = New Size(26, 26)
            Me.lnkFrench.TabIndex = 29
            Me.lnkFrench.UseVisualStyleBackColor = False
            Me.lnkFrench.Visible = False
            '
            'lnkThree
            '
            Me.lnkThree.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkThree.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkThree.FlatAppearance.BorderSize = 0
            Me.lnkThree.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkThree.FlatStyle = FlatStyle.Flat
            Me.lnkThree.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkThree.Location = New Point(140, 6)
            Me.lnkThree.Margin = New Padding(4, 6, 4, 6)
            Me.lnkThree.Name = "lnkThree"
            Me.lnkThree.Size = New Size(26, 26)
            Me.lnkThree.TabIndex = 29
            Me.lnkThree.UseVisualStyleBackColor = False
            Me.lnkThree.Visible = False
            '
            'lnkSix
            '
            Me.lnkSix.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkSix.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkSix.FlatAppearance.BorderSize = 0
            Me.lnkSix.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkSix.FlatStyle = FlatStyle.Flat
            Me.lnkSix.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkSix.Location = New Point(174, 6)
            Me.lnkSix.Margin = New Padding(4, 6, 4, 6)
            Me.lnkSix.Name = "lnkSix"
            Me.lnkSix.Size = New Size(26, 26)
            Me.lnkSix.TabIndex = 29
            Me.lnkSix.UseVisualStyleBackColor = False
            Me.lnkSix.Visible = False
            '
            'lnkEnd1
            '
            Me.lnkEnd1.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkEnd1.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkEnd1.FlatAppearance.BorderSize = 0
            Me.lnkEnd1.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkEnd1.FlatStyle = FlatStyle.Flat
            Me.lnkEnd1.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkEnd1.Location = New Point(208, 6)
            Me.lnkEnd1.Margin = New Padding(4, 6, 4, 6)
            Me.lnkEnd1.Name = "lnkEnd1"
            Me.lnkEnd1.Size = New Size(26, 26)
            Me.lnkEnd1.TabIndex = 29
            Me.lnkEnd1.UseVisualStyleBackColor = False
            Me.lnkEnd1.Visible = False
            '
            'lnkEnd2
            '
            Me.lnkEnd2.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkEnd2.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkEnd2.FlatAppearance.BorderSize = 0
            Me.lnkEnd2.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkEnd2.FlatStyle = FlatStyle.Flat
            Me.lnkEnd2.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkEnd2.Location = New Point(242, 6)
            Me.lnkEnd2.Margin = New Padding(4, 6, 4, 6)
            Me.lnkEnd2.Name = "lnkEnd2"
            Me.lnkEnd2.Size = New Size(26, 26)
            Me.lnkEnd2.TabIndex = 29
            Me.lnkEnd2.UseVisualStyleBackColor = False
            Me.lnkEnd2.Visible = False
            '
            'lnkRef
            '
            Me.lnkRef.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkRef.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkRef.FlatAppearance.BorderSize = 0
            Me.lnkRef.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkRef.FlatStyle = FlatStyle.Flat
            Me.lnkRef.ForeColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkRef.Location = New Point(276, 6)
            Me.lnkRef.Margin = New Padding(4, 6, 4, 6)
            Me.lnkRef.Name = "lnkRef"
            Me.lnkRef.Size = New Size(26, 26)
            Me.lnkRef.TabIndex = 29
            Me.lnkRef.UseVisualStyleBackColor = False
            Me.lnkRef.Visible = False
            '
            'lnkStar
            '
            Me.lnkStar.BackgroundImageLayout = ImageLayout.Zoom
            Me.lnkStar.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkStar.FlatAppearance.BorderSize = 0
            Me.lnkStar.FlatAppearance.MouseOverBackColor = Color.White
            Me.lnkStar.FlatStyle = FlatStyle.Flat
            Me.lnkStar.ForeColor = Color.CornflowerBlue
            Me.lnkStar.Location = New Point(310, 6)
            Me.lnkStar.Margin = New Padding(4, 6, 4, 6)
            Me.lnkStar.Name = "lnkStar"
            Me.lnkStar.Size = New Size(26, 26)
            Me.lnkStar.TabIndex = 30
            Me.lnkStar.UseVisualStyleBackColor = True
            Me.lnkStar.Visible = False
            '
            'lblNotInSeason
            '
            Me.lblNotInSeason.BackColor = Color.Transparent
            Me.lblNotInSeason.FontSize = MetroLabelSize.Small
            Me.lblNotInSeason.Location = New Point(2, 88)
            Me.lblNotInSeason.Name = "lblNotInSeason"
            Me.lblNotInSeason.Size = New Size(306, 20)
            Me.lblNotInSeason.TabIndex = 13
            Me.lblNotInSeason.Text = "NOT_IN_SEASON"
            Me.lblNotInSeason.TextAlign = ContentAlignment.MiddleCenter
            Me.lblNotInSeason.UseCustomBackColor = True
            '
            'lblStreamStatus
            '
            Me.lblStreamStatus.Anchor = CType(((AnchorStyles.Bottom Or AnchorStyles.Left) _
                Or AnchorStyles.Right), AnchorStyles)
            Me.lblStreamStatus.BackColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lblStreamStatus.FontWeight = MetroLabelWeight.Regular
            Me.lblStreamStatus.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblStreamStatus.Location = New Point(1, 109)
            Me.lblStreamStatus.Name = "lblStreamStatus"
            Me.lblStreamStatus.Size = New Size(307, 38)
            Me.lblStreamStatus.TabIndex = 27
            Me.lblStreamStatus.Text = "STREAM_STATUS"
            Me.lblStreamStatus.TextAlign = ContentAlignment.MiddleCenter
            Me.lblStreamStatus.UseCustomBackColor = True
            Me.lblStreamStatus.UseCustomForeColor = True
            '
            'GameControl
            '
            Me.AutoScaleMode = AutoScaleMode.None
            Me.BackColor = Color.White
            Me.Controls.Add(Me.bpGameControl)
            Me.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "GameControl"
            Me.Size = New Size(312, 151)
            Me.bpGameControl.ResumeLayout(False)
            Me.bpGameControl.PerformLayout()
            CType(Me.picAway, ISupportInitialize).EndInit()
            CType(Me.picHome, ISupportInitialize).EndInit()
            Me.flpStreams.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents picAway As PictureBox
        Friend WithEvents lblAwayTeam As MetroLabel
        Friend WithEvents lblHomeTeam As MetroLabel
        Friend WithEvents bpGameControl As BorderPanel
        Friend WithEvents tt As MetroToolTip
        Friend WithEvents lblPeriod As MetroLabel
        Friend WithEvents lblNotInSeason As MetroLabel
        Friend WithEvents picHome As PictureBox
        Friend WithEvents lblHomeScore As MetroLabel
        Friend WithEvents lblAwayScore As MetroLabel
        Friend WithEvents lblStreamStatus As MetroLabel
        Friend WithEvents lblGameStatus As MetroLabel
        Friend WithEvents lblDivider As MetroLabel
        Friend WithEvents btnLiveReplay As Button
        Friend WithEvents flpStreams As FlowLayoutPanel
        Friend WithEvents lnkHome As Button
        Friend WithEvents lnkAway As Button
        Friend WithEvents lnkNational As Button
        Friend WithEvents lnkFrench As Button
        Friend WithEvents lnkThree As Button
        Friend WithEvents lnkSix As Button
        Friend WithEvents lnkEnd2 As Button
        Friend WithEvents lnkRef As Button
        Friend WithEvents lnkStar As Button
        Friend WithEvents lnkEnd1 As Button
    End Class
End Namespace