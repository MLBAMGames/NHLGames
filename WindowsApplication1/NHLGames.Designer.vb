Imports MetroFramework.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NHLGames
    Inherits System.Windows.Forms.Form

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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NHLGames))
        Me.gridGames = New System.Windows.Forms.DataGridView()
        Me.dtDate = New MetroFramework.Controls.MetroDateTime()
        Me.btnHosts = New System.Windows.Forms.Button()
        Me.btnWatch = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.rbQual1 = New System.Windows.Forms.RadioButton()
        Me.rbQual2 = New System.Windows.Forms.RadioButton()
        Me.rbQual3 = New System.Windows.Forms.RadioButton()
        Me.rbQual4 = New System.Windows.Forms.RadioButton()
        Me.rbQual5 = New System.Windows.Forms.RadioButton()
        Me.rbQual6 = New System.Windows.Forms.RadioButton()
        Me.chk60 = New System.Windows.Forms.CheckBox()
        Me.gbQuality = New System.Windows.Forms.GroupBox()
        Me.gbPlayer = New System.Windows.Forms.GroupBox()
        Me.lnkMPCDownload = New System.Windows.Forms.LinkLabel()
        Me.lnkVLCDownload = New System.Windows.Forms.LinkLabel()
        Me.rbMPC = New System.Windows.Forms.RadioButton()
        Me.rbVLC = New System.Windows.Forms.RadioButton()
        Me.gbCDN = New System.Windows.Forms.GroupBox()
        Me.rbLevel3 = New System.Windows.Forms.RadioButton()
        Me.rbAkamai = New System.Windows.Forms.RadioButton()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.btnURL = New System.Windows.Forms.Button()
        Me.gbServer = New System.Windows.Forms.GroupBox()
        Me.rbVOD = New System.Windows.Forms.RadioButton()
        Me.rbLive = New System.Windows.Forms.RadioButton()
        Me.SplitContainer = New System.Windows.Forms.SplitContainer()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.pnlSettings = New System.Windows.Forms.Panel()
        Me.MPCTooltip = New System.Windows.Forms.ToolTip(Me.components)
        Me.VLCTooltip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.gridGames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbQuality.SuspendLayout()
        Me.gbPlayer.SuspendLayout()
        Me.gbCDN.SuspendLayout()
        Me.gbServer.SuspendLayout()
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer.Panel1.SuspendLayout()
        Me.SplitContainer.Panel2.SuspendLayout()
        Me.SplitContainer.SuspendLayout()
        Me.pnlSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'gridGames
        '
        Me.gridGames.AllowUserToAddRows = False
        Me.gridGames.AllowUserToDeleteRows = False
        Me.gridGames.AllowUserToResizeColumns = False
        Me.gridGames.AllowUserToResizeRows = False
        Me.gridGames.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.gridGames.BackgroundColor = System.Drawing.Color.White
        Me.gridGames.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.gridGames.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(3, 5, 3, 0)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridGames.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.gridGames.ColumnHeadersHeight = 30
        Me.gridGames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.gridGames.DefaultCellStyle = DataGridViewCellStyle2
        Me.gridGames.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridGames.Location = New System.Drawing.Point(0, 0)
        Me.gridGames.MultiSelect = False
        Me.gridGames.Name = "gridGames"
        Me.gridGames.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gridGames.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.gridGames.RowHeadersVisible = False
        Me.gridGames.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.gridGames.RowTemplate.DefaultCellStyle.Padding = New System.Windows.Forms.Padding(0, 2, 0, 2)
        Me.gridGames.RowTemplate.DividerHeight = 1
        Me.gridGames.RowTemplate.Height = 35
        Me.gridGames.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gridGames.Size = New System.Drawing.Size(580, 364)
        Me.gridGames.TabIndex = 0
        '
        'dtDate
        '
        Me.dtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(5, 12)
        Me.dtDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtDate.Size = New System.Drawing.Size(96, 29)
        Me.dtDate.TabIndex = 2
        '
        'btnHosts
        '
        Me.btnHosts.Location = New System.Drawing.Point(521, 9)
        Me.btnHosts.Name = "btnHosts"
        Me.btnHosts.Size = New System.Drawing.Size(82, 23)
        Me.btnHosts.TabIndex = 3
        Me.btnHosts.Text = "Edit Hosts File"
        Me.btnHosts.UseVisualStyleBackColor = True
        '
        'btnWatch
        '
        Me.btnWatch.Enabled = False
        Me.btnWatch.Location = New System.Drawing.Point(10, 375)
        Me.btnWatch.Name = "btnWatch"
        Me.btnWatch.Size = New System.Drawing.Size(75, 23)
        Me.btnWatch.TabIndex = 4
        Me.btnWatch.Text = "Watch"
        Me.btnWatch.UseVisualStyleBackColor = True
        Me.btnWatch.Visible = False
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(107, 9)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(89, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh Games"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'rbQual1
        '
        Me.rbQual1.AutoSize = True
        Me.rbQual1.Location = New System.Drawing.Point(5, 21)
        Me.rbQual1.Name = "rbQual1"
        Me.rbQual1.Size = New System.Drawing.Size(49, 17)
        Me.rbQual1.TabIndex = 6
        Me.rbQual1.Text = "224p"
        Me.rbQual1.UseVisualStyleBackColor = True
        '
        'rbQual2
        '
        Me.rbQual2.AutoSize = True
        Me.rbQual2.Location = New System.Drawing.Point(5, 44)
        Me.rbQual2.Name = "rbQual2"
        Me.rbQual2.Size = New System.Drawing.Size(49, 17)
        Me.rbQual2.TabIndex = 7
        Me.rbQual2.Text = "288p"
        Me.rbQual2.UseVisualStyleBackColor = True
        '
        'rbQual3
        '
        Me.rbQual3.AutoSize = True
        Me.rbQual3.Location = New System.Drawing.Point(5, 67)
        Me.rbQual3.Name = "rbQual3"
        Me.rbQual3.Size = New System.Drawing.Size(49, 17)
        Me.rbQual3.TabIndex = 8
        Me.rbQual3.Text = "360p"
        Me.rbQual3.UseVisualStyleBackColor = True
        '
        'rbQual4
        '
        Me.rbQual4.AutoSize = True
        Me.rbQual4.Location = New System.Drawing.Point(5, 90)
        Me.rbQual4.Name = "rbQual4"
        Me.rbQual4.Size = New System.Drawing.Size(49, 17)
        Me.rbQual4.TabIndex = 9
        Me.rbQual4.Text = "504p"
        Me.rbQual4.UseVisualStyleBackColor = True
        '
        'rbQual5
        '
        Me.rbQual5.AutoSize = True
        Me.rbQual5.Location = New System.Drawing.Point(5, 113)
        Me.rbQual5.Name = "rbQual5"
        Me.rbQual5.Size = New System.Drawing.Size(49, 17)
        Me.rbQual5.TabIndex = 10
        Me.rbQual5.Text = "540p"
        Me.rbQual5.UseVisualStyleBackColor = True
        '
        'rbQual6
        '
        Me.rbQual6.AutoSize = True
        Me.rbQual6.Checked = True
        Me.rbQual6.Location = New System.Drawing.Point(6, 136)
        Me.rbQual6.Name = "rbQual6"
        Me.rbQual6.Size = New System.Drawing.Size(49, 17)
        Me.rbQual6.TabIndex = 11
        Me.rbQual6.TabStop = True
        Me.rbQual6.Text = "720p"
        Me.rbQual6.UseVisualStyleBackColor = True
        '
        'chk60
        '
        Me.chk60.AutoSize = True
        Me.chk60.Location = New System.Drawing.Point(6, 159)
        Me.chk60.Name = "chk60"
        Me.chk60.Size = New System.Drawing.Size(52, 17)
        Me.chk60.TabIndex = 13
        Me.chk60.Text = "60fps"
        Me.chk60.UseVisualStyleBackColor = True
        '
        'gbQuality
        '
        Me.gbQuality.Controls.Add(Me.rbQual6)
        Me.gbQuality.Controls.Add(Me.chk60)
        Me.gbQuality.Controls.Add(Me.rbQual1)
        Me.gbQuality.Controls.Add(Me.rbQual2)
        Me.gbQuality.Controls.Add(Me.rbQual3)
        Me.gbQuality.Controls.Add(Me.rbQual5)
        Me.gbQuality.Controls.Add(Me.rbQual4)
        Me.gbQuality.Location = New System.Drawing.Point(10, 3)
        Me.gbQuality.Name = "gbQuality"
        Me.gbQuality.Size = New System.Drawing.Size(75, 181)
        Me.gbQuality.TabIndex = 14
        Me.gbQuality.TabStop = False
        Me.gbQuality.Text = "Quality"
        '
        'gbPlayer
        '
        Me.gbPlayer.Controls.Add(Me.lnkMPCDownload)
        Me.gbPlayer.Controls.Add(Me.lnkVLCDownload)
        Me.gbPlayer.Controls.Add(Me.rbMPC)
        Me.gbPlayer.Controls.Add(Me.rbVLC)
        Me.gbPlayer.Location = New System.Drawing.Point(10, 185)
        Me.gbPlayer.Name = "gbPlayer"
        Me.gbPlayer.Size = New System.Drawing.Size(75, 76)
        Me.gbPlayer.TabIndex = 15
        Me.gbPlayer.TabStop = False
        Me.gbPlayer.Text = "Player"
        '
        'lnkMPCDownload
        '
        Me.lnkMPCDownload.AutoSize = True
        Me.lnkMPCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkMPCDownload.Location = New System.Drawing.Point(52, 44)
        Me.lnkMPCDownload.Name = "lnkMPCDownload"
        Me.lnkMPCDownload.Size = New System.Drawing.Size(13, 13)
        Me.lnkMPCDownload.TabIndex = 3
        Me.lnkMPCDownload.TabStop = True
        Me.lnkMPCDownload.Text = "?"
        Me.MPCTooltip.SetToolTip(Me.lnkMPCDownload, "Download MPC-HC")
        '
        'lnkVLCDownload
        '
        Me.lnkVLCDownload.AutoSize = True
        Me.lnkVLCDownload.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lnkVLCDownload.Location = New System.Drawing.Point(52, 21)
        Me.lnkVLCDownload.Name = "lnkVLCDownload"
        Me.lnkVLCDownload.Size = New System.Drawing.Size(13, 13)
        Me.lnkVLCDownload.TabIndex = 2
        Me.lnkVLCDownload.TabStop = True
        Me.lnkVLCDownload.Text = "?"
        Me.VLCTooltip.SetToolTip(Me.lnkVLCDownload, "Download VLC")
        '
        'rbMPC
        '
        Me.rbMPC.AutoSize = True
        Me.rbMPC.Location = New System.Drawing.Point(5, 42)
        Me.rbMPC.Name = "rbMPC"
        Me.rbMPC.Size = New System.Drawing.Size(48, 17)
        Me.rbMPC.TabIndex = 1
        Me.rbMPC.Text = "MPC"
        Me.rbMPC.UseVisualStyleBackColor = True
        '
        'rbVLC
        '
        Me.rbVLC.AutoSize = True
        Me.rbVLC.Checked = True
        Me.rbVLC.Location = New System.Drawing.Point(5, 19)
        Me.rbVLC.Name = "rbVLC"
        Me.rbVLC.Size = New System.Drawing.Size(45, 17)
        Me.rbVLC.TabIndex = 0
        Me.rbVLC.TabStop = True
        Me.rbVLC.Text = "VLC"
        Me.rbVLC.UseVisualStyleBackColor = True
        '
        'gbCDN
        '
        Me.gbCDN.Controls.Add(Me.rbLevel3)
        Me.gbCDN.Controls.Add(Me.rbAkamai)
        Me.gbCDN.Location = New System.Drawing.Point(10, 433)
        Me.gbCDN.Name = "gbCDN"
        Me.gbCDN.Size = New System.Drawing.Size(75, 65)
        Me.gbCDN.TabIndex = 16
        Me.gbCDN.TabStop = False
        Me.gbCDN.Text = "CDN"
        '
        'rbLevel3
        '
        Me.rbLevel3.AutoSize = True
        Me.rbLevel3.Checked = True
        Me.rbLevel3.Location = New System.Drawing.Point(5, 19)
        Me.rbLevel3.Name = "rbLevel3"
        Me.rbLevel3.Size = New System.Drawing.Size(60, 17)
        Me.rbLevel3.TabIndex = 1
        Me.rbLevel3.TabStop = True
        Me.rbLevel3.Text = "Level 3"
        Me.rbLevel3.UseVisualStyleBackColor = True
        '
        'rbAkamai
        '
        Me.rbAkamai.AutoSize = True
        Me.rbAkamai.Location = New System.Drawing.Point(5, 42)
        Me.rbAkamai.Name = "rbAkamai"
        Me.rbAkamai.Size = New System.Drawing.Size(60, 17)
        Me.rbAkamai.TabIndex = 0
        Me.rbAkamai.Text = "Akamai"
        Me.rbAkamai.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(202, 14)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(0, 13)
        Me.lblVersion.TabIndex = 17
        '
        'btnURL
        '
        Me.btnURL.Location = New System.Drawing.Point(10, 404)
        Me.btnURL.Name = "btnURL"
        Me.btnURL.Size = New System.Drawing.Size(75, 23)
        Me.btnURL.TabIndex = 18
        Me.btnURL.Text = "Get URL"
        Me.btnURL.UseVisualStyleBackColor = True
        Me.btnURL.Visible = False
        '
        'gbServer
        '
        Me.gbServer.Controls.Add(Me.rbVOD)
        Me.gbServer.Controls.Add(Me.rbLive)
        Me.gbServer.Location = New System.Drawing.Point(10, 307)
        Me.gbServer.Name = "gbServer"
        Me.gbServer.Size = New System.Drawing.Size(75, 62)
        Me.gbServer.TabIndex = 19
        Me.gbServer.TabStop = False
        Me.gbServer.Text = "Server"
        '
        'rbVOD
        '
        Me.rbVOD.AutoSize = True
        Me.rbVOD.Location = New System.Drawing.Point(5, 39)
        Me.rbVOD.Name = "rbVOD"
        Me.rbVOD.Size = New System.Drawing.Size(48, 17)
        Me.rbVOD.TabIndex = 1
        Me.rbVOD.Text = "VOD"
        Me.rbVOD.UseVisualStyleBackColor = True
        '
        'rbLive
        '
        Me.rbLive.AutoSize = True
        Me.rbLive.Checked = True
        Me.rbLive.Location = New System.Drawing.Point(5, 16)
        Me.rbLive.Name = "rbLive"
        Me.rbLive.Size = New System.Drawing.Size(45, 17)
        Me.rbLive.TabIndex = 0
        Me.rbLive.TabStop = True
        Me.rbLive.Text = "Live"
        Me.rbLive.UseVisualStyleBackColor = True
        '
        'SplitContainer
        '
        Me.SplitContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer.Location = New System.Drawing.Point(5, 38)
        Me.SplitContainer.Name = "SplitContainer"
        Me.SplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer.Panel1
        '
        Me.SplitContainer.Panel1.Controls.Add(Me.gridGames)
        '
        'SplitContainer.Panel2
        '
        Me.SplitContainer.Panel2.Controls.Add(Me.RichTextBox)
        Me.SplitContainer.Size = New System.Drawing.Size(580, 500)
        Me.SplitContainer.SplitterDistance = 364
        Me.SplitContainer.TabIndex = 20
        '
        'RichTextBox
        '
        Me.RichTextBox.AutoWordSelection = True
        Me.RichTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.RichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox.ForeColor = System.Drawing.Color.White
        Me.RichTextBox.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.ReadOnly = True
        Me.RichTextBox.Size = New System.Drawing.Size(580, 132)
        Me.RichTextBox.TabIndex = 0
        Me.RichTextBox.Text = "Console Output..." & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'pnlSettings
        '
        Me.pnlSettings.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlSettings.Controls.Add(Me.gbQuality)
        Me.pnlSettings.Controls.Add(Me.gbPlayer)
        Me.pnlSettings.Controls.Add(Me.btnURL)
        Me.pnlSettings.Controls.Add(Me.gbServer)
        Me.pnlSettings.Controls.Add(Me.btnWatch)
        Me.pnlSettings.Controls.Add(Me.gbCDN)
        Me.pnlSettings.Location = New System.Drawing.Point(591, 38)
        Me.pnlSettings.Name = "pnlSettings"
        Me.pnlSettings.Size = New System.Drawing.Size(88, 500)
        Me.pnlSettings.TabIndex = 21
        '
        'NHLGames
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 544)
        Me.Controls.Add(Me.pnlSettings)
        Me.Controls.Add(Me.SplitContainer)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnHosts)
        Me.Controls.Add(Me.dtDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(707, 583)
        Me.Name = "NHLGames"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NHL Games"
        CType(Me.gridGames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbQuality.ResumeLayout(False)
        Me.gbQuality.PerformLayout()
        Me.gbPlayer.ResumeLayout(False)
        Me.gbPlayer.PerformLayout()
        Me.gbCDN.ResumeLayout(False)
        Me.gbCDN.PerformLayout()
        Me.gbServer.ResumeLayout(False)
        Me.gbServer.PerformLayout()
        Me.SplitContainer.Panel1.ResumeLayout(False)
        Me.SplitContainer.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer.ResumeLayout(False)
        Me.pnlSettings.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtDate As MetroDateTime
    Friend WithEvents btnHosts As System.Windows.Forms.Button
    Friend WithEvents btnWatch As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents rbQual1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbQual2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbQual3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbQual4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbQual5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbQual6 As System.Windows.Forms.RadioButton
    Friend WithEvents chk60 As CheckBox
    Friend WithEvents gbQuality As GroupBox
    Friend WithEvents gbPlayer As GroupBox
    Friend WithEvents rbMPC As RadioButton
    Friend WithEvents rbVLC As RadioButton
    Friend WithEvents gbCDN As GroupBox
    Friend WithEvents rbLevel3 As RadioButton
    Friend WithEvents rbAkamai As RadioButton
    Friend WithEvents lblVersion As Label
    Friend WithEvents btnURL As Button
    Friend WithEvents gbServer As GroupBox
    Friend WithEvents SplitContainer As SplitContainer
    Friend WithEvents RichTextBox As RichTextBox
    Friend WithEvents pnlSettings As Panel
    Friend WithEvents gridGames As DataGridView
    Friend WithEvents lnkVLCDownload As LinkLabel
    Friend WithEvents lnkMPCDownload As LinkLabel
    Friend WithEvents MPCTooltip As ToolTip
    Friend WithEvents VLCTooltip As ToolTip
    Friend WithEvents rbVOD As RadioButton
    Friend WithEvents rbLive As RadioButton
End Class
