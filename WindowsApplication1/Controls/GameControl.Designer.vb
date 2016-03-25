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
        Me.BorderPanel1 = New BorderPanel()
        Me.picHome = New System.Windows.Forms.PictureBox()
        Me.lblTime = New MetroFramework.Controls.MetroLabel()
        Me.picAway = New System.Windows.Forms.PictureBox()
        Me.btnWatch = New MetroFramework.Controls.MetroButton()
        Me.lblVS = New MetroFramework.Controls.MetroLabel()
        Me.lblAwayScore = New MetroFramework.Controls.MetroLabel()
        Me.lblHomeTeam = New MetroFramework.Controls.MetroLabel()
        Me.lblHomeScore = New MetroFramework.Controls.MetroLabel()
        Me.lblAwayTeam = New MetroFramework.Controls.MetroLabel()
        Me.BorderPanel1.SuspendLayout()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAway, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BorderPanel1
        '
        Me.BorderPanel1.BorderColour = System.Drawing.Color.LightGray
        Me.BorderPanel1.Controls.Add(Me.picHome)
        Me.BorderPanel1.Controls.Add(Me.lblTime)
        Me.BorderPanel1.Controls.Add(Me.picAway)
        Me.BorderPanel1.Controls.Add(Me.btnWatch)
        Me.BorderPanel1.Controls.Add(Me.lblVS)
        Me.BorderPanel1.Controls.Add(Me.lblAwayScore)
        Me.BorderPanel1.Controls.Add(Me.lblHomeTeam)
        Me.BorderPanel1.Controls.Add(Me.lblHomeScore)
        Me.BorderPanel1.Controls.Add(Me.lblAwayTeam)
        Me.BorderPanel1.Location = New System.Drawing.Point(0, 0)
        Me.BorderPanel1.Name = "BorderPanel1"
        Me.BorderPanel1.Size = New System.Drawing.Size(300, 95)
        Me.BorderPanel1.TabIndex = 9
        '
        'picHome
        '
        Me.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picHome.Location = New System.Drawing.Point(7, 13)
        Me.picHome.Name = "picHome"
        Me.picHome.Size = New System.Drawing.Size(75, 50)
        Me.picHome.TabIndex = 0
        Me.picHome.TabStop = False
        '
        'lblTime
        '
        Me.lblTime.Location = New System.Drawing.Point(89, 5)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(121, 19)
        Me.lblTime.TabIndex = 8
        Me.lblTime.Text = "7:30 PM"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picAway
        '
        Me.picAway.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picAway.Location = New System.Drawing.Point(216, 13)
        Me.picAway.Name = "picAway"
        Me.picAway.Size = New System.Drawing.Size(75, 50)
        Me.picAway.TabIndex = 1
        Me.picAway.TabStop = False
        '
        'btnWatch
        '
        Me.btnWatch.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWatch.FontWeight = MetroFramework.MetroButtonWeight.Regular
        Me.btnWatch.Location = New System.Drawing.Point(108, 61)
        Me.btnWatch.Name = "btnWatch"
        Me.btnWatch.Size = New System.Drawing.Size(80, 23)
        Me.btnWatch.TabIndex = 7
        Me.btnWatch.Text = "Watch"
        Me.btnWatch.UseSelectable = True
        '
        'lblVS
        '
        Me.lblVS.AutoSize = True
        Me.lblVS.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblVS.Location = New System.Drawing.Point(137, 31)
        Me.lblVS.Name = "lblVS"
        Me.lblVS.Size = New System.Drawing.Size(26, 19)
        Me.lblVS.TabIndex = 2
        Me.lblVS.Text = "VS"
        '
        'lblAwayScore
        '
        Me.lblAwayScore.AutoSize = True
        Me.lblAwayScore.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblAwayScore.Location = New System.Drawing.Point(171, 31)
        Me.lblAwayScore.Name = "lblAwayScore"
        Me.lblAwayScore.Size = New System.Drawing.Size(17, 19)
        Me.lblAwayScore.TabIndex = 6
        Me.lblAwayScore.Text = "0"
        '
        'lblHomeTeam
        '
        Me.lblHomeTeam.Location = New System.Drawing.Point(7, 66)
        Me.lblHomeTeam.Name = "lblHomeTeam"
        Me.lblHomeTeam.Size = New System.Drawing.Size(80, 19)
        Me.lblHomeTeam.TabIndex = 3
        Me.lblHomeTeam.Text = "Home Team"
        Me.lblHomeTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHomeScore
        '
        Me.lblHomeScore.AutoSize = True
        Me.lblHomeScore.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblHomeScore.Location = New System.Drawing.Point(108, 31)
        Me.lblHomeScore.Name = "lblHomeScore"
        Me.lblHomeScore.Size = New System.Drawing.Size(17, 19)
        Me.lblHomeScore.TabIndex = 5
        Me.lblHomeScore.Text = "0"
        '
        'lblAwayTeam
        '
        Me.lblAwayTeam.Location = New System.Drawing.Point(216, 66)
        Me.lblAwayTeam.Name = "lblAwayTeam"
        Me.lblAwayTeam.Size = New System.Drawing.Size(75, 19)
        Me.lblAwayTeam.TabIndex = 4
        Me.lblAwayTeam.Text = "Away Team"
        Me.lblAwayTeam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BorderPanel1)
        Me.Name = "GameControl"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.Size = New System.Drawing.Size(301, 97)
        Me.BorderPanel1.ResumeLayout(False)
        Me.BorderPanel1.PerformLayout()
        CType(Me.picHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAway, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picHome As PictureBox
    Friend WithEvents picAway As PictureBox
    Friend WithEvents lblVS As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHomeTeam As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAwayTeam As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblHomeScore As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblAwayScore As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnWatch As MetroFramework.Controls.MetroButton
    Friend WithEvents lblTime As MetroFramework.Controls.MetroLabel
    Friend WithEvents BorderPanel1 As BorderPanel
End Class
