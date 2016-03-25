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
        Me.FlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.ConsoleTab = New MetroFramework.Controls.MetroTabPage()
        Me.btnClearConsole = New MetroFramework.Controls.MetroButton()
        Me.SettingTab = New MetroFramework.Controls.MetroTabPage()
        Me.btnLiveStreamerPath = New MetroFramework.Controls.MetroButton()
        Me.btnMPCPath = New MetroFramework.Controls.MetroButton()
        Me.btnVLCPath = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtLiveStreamPath = New System.Windows.Forms.TextBox()
        Me.txtMPCPath = New System.Windows.Forms.TextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtVLCPath = New System.Windows.Forms.TextBox()
        Me.btnOpenHostsFile = New MetroFramework.Controls.MetroButton()
        Me.MetroCheckBox1 = New MetroFramework.Controls.MetroCheckBox()
        Me.btnHosts = New MetroFramework.Controls.MetroButton()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        CType(Me.gridGames, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl.SuspendLayout()
        Me.GamesTab.SuspendLayout()
        Me.ConsoleTab.SuspendLayout()
        Me.SettingTab.SuspendLayout()
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
        Me.gridGames.Size = New System.Drawing.Size(208, 0)
        Me.gridGames.TabIndex = 0
        Me.gridGames.Visible = False
        '
        'dtDate
        '
        Me.dtDate.Checked = False
        Me.dtDate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dtDate.CustomFormat = "yyyy-MM-dd"
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(7, 6)
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
        Me.btnRefresh.Location = New System.Drawing.Point(558, 6)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(121, 29)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseSelectable = True
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(401, 44)
        Me.lblVersion.MinimumSize = New System.Drawing.Size(200, 5)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(200, 13)
        Me.lblVersion.TabIndex = 17
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
        Me.RichTextBox.Size = New System.Drawing.Size(676, 329)
        Me.RichTextBox.TabIndex = 0
        Me.RichTextBox.Text = "Console Output..." & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.GamesTab)
        Me.TabControl.Controls.Add(Me.ConsoleTab)
        Me.TabControl.Controls.Add(Me.SettingTab)
        Me.TabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl.Location = New System.Drawing.Point(20, 60)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(690, 420)
        Me.TabControl.TabIndex = 22
        Me.TabControl.UseSelectable = True
        '
        'GamesTab
        '
        Me.GamesTab.Controls.Add(Me.FlowLayoutPanel)
        Me.GamesTab.Controls.Add(Me.gridGames)
        Me.GamesTab.Controls.Add(Me.btnRefresh)
        Me.GamesTab.Controls.Add(Me.dtDate)
        Me.GamesTab.HorizontalScrollbarBarColor = True
        Me.GamesTab.HorizontalScrollbarHighlightOnWheel = False
        Me.GamesTab.HorizontalScrollbarSize = 10
        Me.GamesTab.Location = New System.Drawing.Point(4, 38)
        Me.GamesTab.Name = "GamesTab"
        Me.GamesTab.Size = New System.Drawing.Size(682, 378)
        Me.GamesTab.TabIndex = 0
        Me.GamesTab.Text = "Games      "
        Me.GamesTab.VerticalScrollbarBarColor = True
        Me.GamesTab.VerticalScrollbarHighlightOnWheel = False
        Me.GamesTab.VerticalScrollbarSize = 10
        '
        'FlowLayoutPanel
        '
        Me.FlowLayoutPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel.AutoScroll = True
        Me.FlowLayoutPanel.BackColor = System.Drawing.Color.White
        Me.FlowLayoutPanel.Location = New System.Drawing.Point(7, 41)
        Me.FlowLayoutPanel.Name = "FlowLayoutPanel"
        Me.FlowLayoutPanel.Size = New System.Drawing.Size(672, 341)
        Me.FlowLayoutPanel.TabIndex = 6
        '
        'ConsoleTab
        '
        Me.ConsoleTab.Controls.Add(Me.btnClearConsole)
        Me.ConsoleTab.Controls.Add(Me.RichTextBox)
        Me.ConsoleTab.HorizontalScrollbarBarColor = True
        Me.ConsoleTab.HorizontalScrollbarHighlightOnWheel = False
        Me.ConsoleTab.HorizontalScrollbarSize = 10
        Me.ConsoleTab.Location = New System.Drawing.Point(4, 38)
        Me.ConsoleTab.Name = "ConsoleTab"
        Me.ConsoleTab.Size = New System.Drawing.Size(682, 378)
        Me.ConsoleTab.TabIndex = 2
        Me.ConsoleTab.Text = "Console      "
        Me.ConsoleTab.VerticalScrollbarBarColor = True
        Me.ConsoleTab.VerticalScrollbarHighlightOnWheel = False
        Me.ConsoleTab.VerticalScrollbarSize = 10
        '
        'btnClearConsole
        '
        Me.btnClearConsole.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClearConsole.Location = New System.Drawing.Point(576, 355)
        Me.btnClearConsole.Name = "btnClearConsole"
        Me.btnClearConsole.Size = New System.Drawing.Size(103, 23)
        Me.btnClearConsole.TabIndex = 2
        Me.btnClearConsole.Text = "Clear"
        Me.btnClearConsole.UseSelectable = True
        '
        'SettingTab
        '
        Me.SettingTab.Controls.Add(Me.btnLiveStreamerPath)
        Me.SettingTab.Controls.Add(Me.btnMPCPath)
        Me.SettingTab.Controls.Add(Me.btnVLCPath)
        Me.SettingTab.Controls.Add(Me.MetroLabel4)
        Me.SettingTab.Controls.Add(Me.txtLiveStreamPath)
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
        Me.SettingTab.Size = New System.Drawing.Size(682, 378)
        Me.SettingTab.TabIndex = 1
        Me.SettingTab.Text = "Settings      "
        Me.SettingTab.VerticalScrollbarBarColor = True
        Me.SettingTab.VerticalScrollbarHighlightOnWheel = False
        Me.SettingTab.VerticalScrollbarSize = 10
        '
        'btnLiveStreamerPath
        '
        Me.btnLiveStreamerPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLiveStreamerPath.Location = New System.Drawing.Point(545, 81)
        Me.btnLiveStreamerPath.Name = "btnLiveStreamerPath"
        Me.btnLiveStreamerPath.Size = New System.Drawing.Size(28, 20)
        Me.btnLiveStreamerPath.TabIndex = 50
        Me.btnLiveStreamerPath.Text = "..."
        Me.btnLiveStreamerPath.UseSelectable = True
        '
        'btnMPCPath
        '
        Me.btnMPCPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMPCPath.Location = New System.Drawing.Point(545, 54)
        Me.btnMPCPath.Name = "btnMPCPath"
        Me.btnMPCPath.Size = New System.Drawing.Size(28, 20)
        Me.btnMPCPath.TabIndex = 49
        Me.btnMPCPath.Text = "..."
        Me.btnMPCPath.UseSelectable = True
        '
        'btnVLCPath
        '
        Me.btnVLCPath.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnVLCPath.Location = New System.Drawing.Point(545, 28)
        Me.btnVLCPath.Name = "btnVLCPath"
        Me.btnVLCPath.Size = New System.Drawing.Size(28, 20)
        Me.btnVLCPath.TabIndex = 48
        Me.btnVLCPath.Text = "..."
        Me.btnVLCPath.UseSelectable = True
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(17, 82)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(114, 19)
        Me.MetroLabel4.TabIndex = 47
        Me.MetroLabel4.Text = "LiveStreamer Path"
        '
        'txtLiveStreamPath
        '
        Me.txtLiveStreamPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLiveStreamPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLiveStreamPath.Location = New System.Drawing.Point(137, 80)
        Me.txtLiveStreamPath.Name = "txtLiveStreamPath"
        Me.txtLiveStreamPath.ReadOnly = True
        Me.txtLiveStreamPath.Size = New System.Drawing.Size(402, 22)
        Me.txtLiveStreamPath.TabIndex = 46
        '
        'txtMPCPath
        '
        Me.txtMPCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMPCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMPCPath.Location = New System.Drawing.Point(137, 54)
        Me.txtMPCPath.Name = "txtMPCPath"
        Me.txtMPCPath.ReadOnly = True
        Me.txtMPCPath.Size = New System.Drawing.Size(402, 22)
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
        Me.MetroLabel2.Location = New System.Drawing.Point(17, 29)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel2.TabIndex = 43
        Me.MetroLabel2.Text = "VLC Path"
        '
        'txtVLCPath
        '
        Me.txtVLCPath.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVLCPath.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVLCPath.Location = New System.Drawing.Point(137, 28)
        Me.txtVLCPath.Name = "txtVLCPath"
        Me.txtVLCPath.ReadOnly = True
        Me.txtVLCPath.Size = New System.Drawing.Size(402, 22)
        Me.txtVLCPath.TabIndex = 42
        '
        'btnOpenHostsFile
        '
        Me.btnOpenHostsFile.Location = New System.Drawing.Point(383, 123)
        Me.btnOpenHostsFile.Name = "btnOpenHostsFile"
        Me.btnOpenHostsFile.Size = New System.Drawing.Size(92, 24)
        Me.btnOpenHostsFile.TabIndex = 39
        Me.btnOpenHostsFile.Text = "Open Hosts File"
        Me.btnOpenHostsFile.UseSelectable = True
        '
        'MetroCheckBox1
        '
        Me.MetroCheckBox1.AutoSize = True
        Me.MetroCheckBox1.Location = New System.Drawing.Point(137, 123)
        Me.MetroCheckBox1.Name = "MetroCheckBox1"
        Me.MetroCheckBox1.Size = New System.Drawing.Size(89, 15)
        Me.MetroCheckBox1.TabIndex = 28
        Me.MetroCheckBox1.Text = "Show Scores"
        Me.MetroCheckBox1.UseSelectable = True
        '
        'btnHosts
        '
        Me.btnHosts.Location = New System.Drawing.Point(481, 123)
        Me.btnHosts.Name = "btnHosts"
        Me.btnHosts.Size = New System.Drawing.Size(92, 24)
        Me.btnHosts.TabIndex = 27
        Me.btnHosts.Text = "Test Hosts File"
        Me.btnHosts.UseSelectable = True
        '
        'NHLGamesMetro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(730, 500)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.lblVersion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(730, 500)
        Me.Name = "NHLGamesMetro"
        Me.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow
        Me.Text = "NHL Games"
        CType(Me.gridGames, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl.ResumeLayout(False)
        Me.GamesTab.ResumeLayout(False)
        Me.ConsoleTab.ResumeLayout(False)
        Me.SettingTab.ResumeLayout(False)
        Me.SettingTab.PerformLayout()
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
End Class
