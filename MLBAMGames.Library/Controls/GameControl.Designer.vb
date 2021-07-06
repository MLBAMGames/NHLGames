Imports System.ComponentModel
Imports System.Windows.Forms
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GameControl))
            Me.tt = New MetroFramework.Components.MetroToolTip()
            Me.bpGameControl = New MLBAMGames.Library.Controls.BorderPanel()
            Me.btnRecap = New System.Windows.Forms.Button()
            Me.btnLiveReplay = New System.Windows.Forms.Button()
            Me.lblGameStatus = New MetroFramework.Controls.MetroLabel()
            Me.lblDivider = New MetroFramework.Controls.MetroLabel()
            Me.picAway = New System.Windows.Forms.PictureBox()
            Me.lblHomeScore = New MetroFramework.Controls.MetroLabel()
            Me.lblAwayScore = New MetroFramework.Controls.MetroLabel()
            Me.lblAwayTeam = New MetroFramework.Controls.MetroLabel()
            Me.picHome = New System.Windows.Forms.PictureBox()
            Me.lblHomeTeam = New MetroFramework.Controls.MetroLabel()
            Me.lblPeriod = New MetroFramework.Controls.MetroLabel()
            Me.flpStreams = New System.Windows.Forms.FlowLayoutPanel()
            Me.lnkHome = New System.Windows.Forms.Button()
            Me.lnkAway = New System.Windows.Forms.Button()
            Me.lnkNational = New System.Windows.Forms.Button()
            Me.lnkFrench = New System.Windows.Forms.Button()
            Me.lnkThree = New System.Windows.Forms.Button()
            Me.lnkSix = New System.Windows.Forms.Button()
            Me.lnkEnd1 = New System.Windows.Forms.Button()
            Me.lnkEnd2 = New System.Windows.Forms.Button()
            Me.lnkRef = New System.Windows.Forms.Button()
            Me.lnkStar = New System.Windows.Forms.Button()
            Me.lblNotInSeason = New MetroFramework.Controls.MetroLabel()
            Me.lblStreamStatus = New MetroFramework.Controls.MetroLabel()
            Me.bpGameControl.SuspendLayout()
            CType(Me.picAway, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flpStreams.SuspendLayout()
            Me.SuspendLayout()
            '
            'tt
            '
            Me.tt.AutomaticDelay = 100
            Me.tt.Style = MetroFramework.MetroColorStyle.[Default]
            Me.tt.StyleManager = Nothing
            Me.tt.Theme = MetroFramework.MetroThemeStyle.Light
            '
            'bpGameControl
            '
            Me.bpGameControl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
            Me.bpGameControl.BorderColour = System.Drawing.Color.LightGray
            Me.bpGameControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.bpGameControl.Controls.Add(Me.btnRecap)
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
            Me.bpGameControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.bpGameControl.Location = New System.Drawing.Point(0, 0)
            Me.bpGameControl.Name = "bpGameControl"
            Me.bpGameControl.Size = New System.Drawing.Size(312, 151)
            Me.bpGameControl.TabIndex = 9
            '
            'btnRecap
            '
            Me.btnRecap.BackColor = System.Drawing.Color.Gray
            Me.btnRecap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnRecap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.btnRecap.FlatAppearance.BorderSize = 0
            Me.btnRecap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray
            Me.btnRecap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.btnRecap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRecap.ForeColor = System.Drawing.Color.Black
            Me.btnRecap.Location = New System.Drawing.Point(286, 2)
            Me.btnRecap.Name = "btnRecap"
            Me.btnRecap.Size = New System.Drawing.Size(18, 18)
            Me.btnRecap.TabIndex = 33
            Me.btnRecap.UseVisualStyleBackColor = False
            Me.btnRecap.Visible = False
            '
            'btnLiveReplay
            '
            Me.btnLiveReplay.BackColor = System.Drawing.Color.Red
            Me.btnLiveReplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.btnLiveReplay.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.btnLiveReplay.FlatAppearance.BorderSize = 0
            Me.btnLiveReplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
            Me.btnLiveReplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.btnLiveReplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnLiveReplay.ForeColor = System.Drawing.Color.Black
            Me.btnLiveReplay.Location = New System.Drawing.Point(2, 1)
            Me.btnLiveReplay.Name = "btnLiveReplay"
            Me.btnLiveReplay.Size = New System.Drawing.Size(18, 18)
            Me.btnLiveReplay.TabIndex = 32
            Me.btnLiveReplay.UseVisualStyleBackColor = False
            Me.btnLiveReplay.Visible = False
            '
            'lblGameStatus
            '
            Me.lblGameStatus.BackColor = System.Drawing.Color.Transparent
            Me.lblGameStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular
            Me.lblGameStatus.Location = New System.Drawing.Point(97, 35)
            Me.lblGameStatus.Name = "lblGameStatus"
            Me.lblGameStatus.Size = New System.Drawing.Size(116, 50)
            Me.lblGameStatus.TabIndex = 25
            Me.lblGameStatus.Text = "GAME_STATUS"
            Me.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblGameStatus.UseCustomBackColor = True
            Me.lblGameStatus.Visible = False
            '
            'lblDivider
            '
            Me.lblDivider.BackColor = System.Drawing.Color.Silver
            Me.lblDivider.Location = New System.Drawing.Point(155, 35)
            Me.lblDivider.Name = "lblDivider"
            Me.lblDivider.Size = New System.Drawing.Size(1, 50)
            Me.lblDivider.TabIndex = 29
            Me.lblDivider.UseCustomBackColor = True
            '
            'picAway
            '
            Me.picAway.BackgroundImage = CType(resources.GetObject("picAway.BackgroundImage"), System.Drawing.Image)
            Me.picAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.picAway.Location = New System.Drawing.Point(27, 35)
            Me.picAway.Name = "picAway"
            Me.picAway.Size = New System.Drawing.Size(65, 50)
            Me.picAway.TabIndex = 0
            Me.picAway.TabStop = False
            '
            'lblHomeScore
            '
            Me.lblHomeScore.BackColor = System.Drawing.Color.Transparent
            Me.lblHomeScore.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.lblHomeScore.FontWeight = MetroFramework.MetroLabelWeight.Bold
            Me.lblHomeScore.Location = New System.Drawing.Point(160, 35)
            Me.lblHomeScore.Margin = New System.Windows.Forms.Padding(0)
            Me.lblHomeScore.Name = "lblHomeScore"
            Me.lblHomeScore.Size = New System.Drawing.Size(50, 50)
            Me.lblHomeScore.TabIndex = 24
            Me.lblHomeScore.Text = "0"
            Me.lblHomeScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblHomeScore.UseCustomBackColor = True
            Me.lblHomeScore.UseCustomForeColor = True
            '
            'lblAwayScore
            '
            Me.lblAwayScore.BackColor = System.Drawing.Color.Transparent
            Me.lblAwayScore.FontSize = MetroFramework.MetroLabelSize.Tall
            Me.lblAwayScore.FontWeight = MetroFramework.MetroLabelWeight.Bold
            Me.lblAwayScore.Location = New System.Drawing.Point(100, 35)
            Me.lblAwayScore.Margin = New System.Windows.Forms.Padding(0)
            Me.lblAwayScore.Name = "lblAwayScore"
            Me.lblAwayScore.Size = New System.Drawing.Size(50, 50)
            Me.lblAwayScore.TabIndex = 23
            Me.lblAwayScore.Text = "0"
            Me.lblAwayScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblAwayScore.UseCustomBackColor = True
            Me.lblAwayScore.UseCustomForeColor = True
            '
            'lblAwayTeam
            '
            Me.lblAwayTeam.BackColor = System.Drawing.Color.Transparent
            Me.lblAwayTeam.Location = New System.Drawing.Point(30, 88)
            Me.lblAwayTeam.Name = "lblAwayTeam"
            Me.lblAwayTeam.Size = New System.Drawing.Size(60, 20)
            Me.lblAwayTeam.TabIndex = 4
            Me.lblAwayTeam.Text = "AWAY"
            Me.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblAwayTeam.UseCustomBackColor = True
            '
            'picHome
            '
            Me.picHome.BackgroundImage = CType(resources.GetObject("picHome.BackgroundImage"), System.Drawing.Image)
            Me.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.picHome.Location = New System.Drawing.Point(218, 35)
            Me.picHome.Name = "picHome"
            Me.picHome.Size = New System.Drawing.Size(65, 50)
            Me.picHome.TabIndex = 1
            Me.picHome.TabStop = False
            '
            'lblHomeTeam
            '
            Me.lblHomeTeam.BackColor = System.Drawing.Color.Transparent
            Me.lblHomeTeam.Location = New System.Drawing.Point(222, 88)
            Me.lblHomeTeam.Name = "lblHomeTeam"
            Me.lblHomeTeam.Size = New System.Drawing.Size(60, 20)
            Me.lblHomeTeam.TabIndex = 4
            Me.lblHomeTeam.Text = "HOME"
            Me.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblHomeTeam.UseCustomBackColor = True
            '
            'lblPeriod
            '
            Me.lblPeriod.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lblPeriod.FontSize = MetroFramework.MetroLabelSize.Small
            Me.lblPeriod.FontWeight = MetroFramework.MetroLabelWeight.Bold
            Me.lblPeriod.ForeColor = System.Drawing.Color.Black
            Me.lblPeriod.Location = New System.Drawing.Point(1, 1)
            Me.lblPeriod.Name = "lblPeriod"
            Me.lblPeriod.Size = New System.Drawing.Size(307, 20)
            Me.lblPeriod.TabIndex = 11
            Me.lblPeriod.Text = "PERIOD_STATUS"
            Me.lblPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblPeriod.UseCustomBackColor = True
            Me.lblPeriod.UseCustomForeColor = True
            '
            'flpStreams
            '
            Me.flpStreams.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.flpStreams.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
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
            Me.flpStreams.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.flpStreams.ImeMode = System.Windows.Forms.ImeMode.NoControl
            Me.flpStreams.Location = New System.Drawing.Point(1, 109)
            Me.flpStreams.Name = "flpStreams"
            Me.flpStreams.Size = New System.Drawing.Size(307, 38)
            Me.flpStreams.TabIndex = 10
            Me.flpStreams.WrapContents = False
            '
            'lnkHome
            '
            Me.lnkHome.BackgroundImage = CType(resources.GetObject("lnkHome.BackgroundImage"), System.Drawing.Image)
            Me.lnkHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkHome.FlatAppearance.BorderSize = 0
            Me.lnkHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkHome.Location = New System.Drawing.Point(4, 6)
            Me.lnkHome.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkHome.Name = "lnkHome"
            Me.lnkHome.Size = New System.Drawing.Size(26, 26)
            Me.lnkHome.TabIndex = 29
            Me.lnkHome.UseVisualStyleBackColor = False
            Me.lnkHome.Visible = False
            '
            'lnkAway
            '
            Me.lnkAway.BackgroundImage = CType(resources.GetObject("lnkAway.BackgroundImage"), System.Drawing.Image)
            Me.lnkAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkAway.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkAway.FlatAppearance.BorderSize = 0
            Me.lnkAway.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkAway.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkAway.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkAway.Location = New System.Drawing.Point(38, 6)
            Me.lnkAway.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkAway.Name = "lnkAway"
            Me.lnkAway.Size = New System.Drawing.Size(26, 26)
            Me.lnkAway.TabIndex = 28
            Me.lnkAway.UseVisualStyleBackColor = False
            Me.lnkAway.Visible = False
            '
            'lnkNational
            '
            Me.lnkNational.BackgroundImage = CType(resources.GetObject("lnkNational.BackgroundImage"), System.Drawing.Image)
            Me.lnkNational.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkNational.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkNational.FlatAppearance.BorderSize = 0
            Me.lnkNational.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkNational.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkNational.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkNational.Location = New System.Drawing.Point(72, 6)
            Me.lnkNational.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkNational.Name = "lnkNational"
            Me.lnkNational.Size = New System.Drawing.Size(26, 26)
            Me.lnkNational.TabIndex = 29
            Me.lnkNational.UseVisualStyleBackColor = False
            Me.lnkNational.Visible = False
            '
            'lnkFrench
            '
            Me.lnkFrench.BackgroundImage = CType(resources.GetObject("lnkFrench.BackgroundImage"), System.Drawing.Image)
            Me.lnkFrench.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkFrench.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkFrench.FlatAppearance.BorderSize = 0
            Me.lnkFrench.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkFrench.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkFrench.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkFrench.Location = New System.Drawing.Point(106, 6)
            Me.lnkFrench.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkFrench.Name = "lnkFrench"
            Me.lnkFrench.Size = New System.Drawing.Size(26, 26)
            Me.lnkFrench.TabIndex = 29
            Me.lnkFrench.UseVisualStyleBackColor = False
            Me.lnkFrench.Visible = False
            '
            'lnkThree
            '
            Me.lnkThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkThree.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkThree.FlatAppearance.BorderSize = 0
            Me.lnkThree.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkThree.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkThree.Location = New System.Drawing.Point(140, 6)
            Me.lnkThree.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkThree.Name = "lnkThree"
            Me.lnkThree.Size = New System.Drawing.Size(26, 26)
            Me.lnkThree.TabIndex = 29
            Me.lnkThree.UseVisualStyleBackColor = False
            Me.lnkThree.Visible = False
            '
            'lnkSix
            '
            Me.lnkSix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkSix.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkSix.FlatAppearance.BorderSize = 0
            Me.lnkSix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkSix.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkSix.Location = New System.Drawing.Point(174, 6)
            Me.lnkSix.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkSix.Name = "lnkSix"
            Me.lnkSix.Size = New System.Drawing.Size(26, 26)
            Me.lnkSix.TabIndex = 29
            Me.lnkSix.UseVisualStyleBackColor = False
            Me.lnkSix.Visible = False
            '
            'lnkEnd1
            '
            Me.lnkEnd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkEnd1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkEnd1.FlatAppearance.BorderSize = 0
            Me.lnkEnd1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkEnd1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkEnd1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkEnd1.Location = New System.Drawing.Point(208, 6)
            Me.lnkEnd1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkEnd1.Name = "lnkEnd1"
            Me.lnkEnd1.Size = New System.Drawing.Size(26, 26)
            Me.lnkEnd1.TabIndex = 29
            Me.lnkEnd1.UseVisualStyleBackColor = False
            Me.lnkEnd1.Visible = False
            '
            'lnkEnd2
            '
            Me.lnkEnd2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkEnd2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkEnd2.FlatAppearance.BorderSize = 0
            Me.lnkEnd2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkEnd2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkEnd2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkEnd2.Location = New System.Drawing.Point(242, 6)
            Me.lnkEnd2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkEnd2.Name = "lnkEnd2"
            Me.lnkEnd2.Size = New System.Drawing.Size(26, 26)
            Me.lnkEnd2.TabIndex = 29
            Me.lnkEnd2.UseVisualStyleBackColor = False
            Me.lnkEnd2.Visible = False
            '
            'lnkRef
            '
            Me.lnkRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkRef.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkRef.FlatAppearance.BorderSize = 0
            Me.lnkRef.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkRef.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkRef.Location = New System.Drawing.Point(276, 6)
            Me.lnkRef.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkRef.Name = "lnkRef"
            Me.lnkRef.Size = New System.Drawing.Size(26, 26)
            Me.lnkRef.TabIndex = 29
            Me.lnkRef.UseVisualStyleBackColor = False
            Me.lnkRef.Visible = False
            '
            'lnkStar
            '
            Me.lnkStar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
            Me.lnkStar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lnkStar.FlatAppearance.BorderSize = 0
            Me.lnkStar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
            Me.lnkStar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.lnkStar.ForeColor = System.Drawing.Color.CornflowerBlue
            Me.lnkStar.Location = New System.Drawing.Point(310, 6)
            Me.lnkStar.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
            Me.lnkStar.Name = "lnkStar"
            Me.lnkStar.Size = New System.Drawing.Size(26, 26)
            Me.lnkStar.TabIndex = 30
            Me.lnkStar.UseVisualStyleBackColor = True
            Me.lnkStar.Visible = False
            '
            'lblNotInSeason
            '
            Me.lblNotInSeason.BackColor = System.Drawing.Color.Transparent
            Me.lblNotInSeason.FontSize = MetroFramework.MetroLabelSize.Small
            Me.lblNotInSeason.Location = New System.Drawing.Point(2, 88)
            Me.lblNotInSeason.Name = "lblNotInSeason"
            Me.lblNotInSeason.Size = New System.Drawing.Size(306, 20)
            Me.lblNotInSeason.TabIndex = 13
            Me.lblNotInSeason.Text = "NOT_IN_SEASON"
            Me.lblNotInSeason.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblNotInSeason.UseCustomBackColor = True
            '
            'lblStreamStatus
            '
            Me.lblStreamStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.lblStreamStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lblStreamStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular
            Me.lblStreamStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.lblStreamStatus.Location = New System.Drawing.Point(1, 109)
            Me.lblStreamStatus.Name = "lblStreamStatus"
            Me.lblStreamStatus.Size = New System.Drawing.Size(307, 38)
            Me.lblStreamStatus.TabIndex = 27
            Me.lblStreamStatus.Text = "STREAM_STATUS"
            Me.lblStreamStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            Me.lblStreamStatus.UseCustomBackColor = True
            Me.lblStreamStatus.UseCustomForeColor = True
            '
            'GameControl
            '
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
            Me.BackColor = System.Drawing.Color.White
            Me.Controls.Add(Me.bpGameControl)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "GameControl"
            Me.Size = New System.Drawing.Size(312, 151)
            Me.bpGameControl.ResumeLayout(False)
            CType(Me.picAway, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
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
        Friend WithEvents btnRecap As Button
    End Class
End Namespace