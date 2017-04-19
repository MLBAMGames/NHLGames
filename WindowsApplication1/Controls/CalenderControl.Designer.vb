<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CalenderControl
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Sun = New System.Windows.Forms.Label()
        Me.Su1 = New System.Windows.Forms.Button()
        Me.Mo1 = New System.Windows.Forms.Button()
        Me.Tu1 = New System.Windows.Forms.Button()
        Me.We1 = New System.Windows.Forms.Button()
        Me.Th1 = New System.Windows.Forms.Button()
        Me.Fr1 = New System.Windows.Forms.Button()
        Me.Sa1 = New System.Windows.Forms.Button()
        Me.Su2 = New System.Windows.Forms.Button()
        Me.Mo2 = New System.Windows.Forms.Button()
        Me.Tu2 = New System.Windows.Forms.Button()
        Me.We2 = New System.Windows.Forms.Button()
        Me.Th2 = New System.Windows.Forms.Button()
        Me.Fr2 = New System.Windows.Forms.Button()
        Me.Sa2 = New System.Windows.Forms.Button()
        Me.Su3 = New System.Windows.Forms.Button()
        Me.Mo3 = New System.Windows.Forms.Button()
        Me.Tu3 = New System.Windows.Forms.Button()
        Me.We3 = New System.Windows.Forms.Button()
        Me.Th3 = New System.Windows.Forms.Button()
        Me.Fr3 = New System.Windows.Forms.Button()
        Me.Sa3 = New System.Windows.Forms.Button()
        Me.Su4 = New System.Windows.Forms.Button()
        Me.Mo4 = New System.Windows.Forms.Button()
        Me.Tu4 = New System.Windows.Forms.Button()
        Me.We4 = New System.Windows.Forms.Button()
        Me.Th4 = New System.Windows.Forms.Button()
        Me.Fr4 = New System.Windows.Forms.Button()
        Me.Sa4 = New System.Windows.Forms.Button()
        Me.Su5 = New System.Windows.Forms.Button()
        Me.Mo5 = New System.Windows.Forms.Button()
        Me.Tu5 = New System.Windows.Forms.Button()
        Me.We5 = New System.Windows.Forms.Button()
        Me.Th5 = New System.Windows.Forms.Button()
        Me.Fr5 = New System.Windows.Forms.Button()
        Me.Sa5 = New System.Windows.Forms.Button()
        Me.Su6 = New System.Windows.Forms.Button()
        Me.Mo6 = New System.Windows.Forms.Button()
        Me.Tu6 = New System.Windows.Forms.Button()
        Me.We6 = New System.Windows.Forms.Button()
        Me.Th6 = New System.Windows.Forms.Button()
        Me.Fr6 = New System.Windows.Forms.Button()
        Me.Sa6 = New System.Windows.Forms.Button()
        Me.Mon = New System.Windows.Forms.Label()
        Me.Tue = New System.Windows.Forms.Label()
        Me.Wed = New System.Windows.Forms.Label()
        Me.Thu = New System.Windows.Forms.Label()
        Me.Fri = New System.Windows.Forms.Label()
        Me.Sat = New System.Windows.Forms.Label()
        Me.btnNextMonth = New System.Windows.Forms.Button()
        Me.btnBeforeMonth = New System.Windows.Forms.Button()
        Me.btnBeforeYear = New System.Windows.Forms.Button()
        Me.btnNextYear = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'btnToday
        '
        Me.btnToday.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnToday.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnToday.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToday.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnToday.Location = New System.Drawing.Point(4, 244)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(313, 35)
        Me.btnToday.TabIndex = 1
        Me.btnToday.Text = "Today"
        Me.btnToday.UseVisualStyleBackColor = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.lblDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.White
        Me.lblDate.Location = New System.Drawing.Point(32, 6)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.lblDate.Size = New System.Drawing.Size(225, 26)
        Me.lblDate.TabIndex = 1
        Me.lblDate.Text = "Month Year"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sun
        '
        Me.Sun.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sun.BackColor = System.Drawing.Color.DarkGray
        Me.Sun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sun.ForeColor = System.Drawing.Color.White
        Me.Sun.Location = New System.Drawing.Point(0, 38)
        Me.Sun.Name = "Sun"
        Me.Sun.Size = New System.Drawing.Size(46, 18)
        Me.Sun.TabIndex = 2
        Me.Sun.Text = "Sun"
        Me.Sun.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Su1
        '
        Me.Su1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Su1.BackColor = System.Drawing.Color.White
        Me.Su1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Su1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Su1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Su1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Su1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Su1.Location = New System.Drawing.Point(3, 59)
        Me.Su1.Name = "Su1"
        Me.Su1.Size = New System.Drawing.Size(39, 25)
        Me.Su1.TabIndex = 9
        Me.Su1.Text = "00"
        Me.Su1.UseVisualStyleBackColor = False
        '
        'Mo1
        '
        Me.Mo1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mo1.BackColor = System.Drawing.Color.White
        Me.Mo1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Mo1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Mo1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Mo1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mo1.Location = New System.Drawing.Point(49, 59)
        Me.Mo1.Name = "Mo1"
        Me.Mo1.Size = New System.Drawing.Size(39, 25)
        Me.Mo1.TabIndex = 10
        Me.Mo1.Text = "00"
        Me.Mo1.UseVisualStyleBackColor = False
        '
        'Tu1
        '
        Me.Tu1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tu1.BackColor = System.Drawing.Color.White
        Me.Tu1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Tu1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Tu1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Tu1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tu1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tu1.Location = New System.Drawing.Point(95, 59)
        Me.Tu1.Name = "Tu1"
        Me.Tu1.Size = New System.Drawing.Size(39, 25)
        Me.Tu1.TabIndex = 11
        Me.Tu1.Text = "00"
        Me.Tu1.UseVisualStyleBackColor = False
        '
        'We1
        '
        Me.We1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.We1.BackColor = System.Drawing.Color.White
        Me.We1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.We1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.We1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.We1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.We1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.We1.Location = New System.Drawing.Point(141, 59)
        Me.We1.Name = "We1"
        Me.We1.Size = New System.Drawing.Size(39, 25)
        Me.We1.TabIndex = 12
        Me.We1.Text = "00"
        Me.We1.UseVisualStyleBackColor = False
        '
        'Th1
        '
        Me.Th1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Th1.BackColor = System.Drawing.Color.White
        Me.Th1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Th1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Th1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Th1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Th1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th1.Location = New System.Drawing.Point(187, 59)
        Me.Th1.Name = "Th1"
        Me.Th1.Size = New System.Drawing.Size(39, 25)
        Me.Th1.TabIndex = 13
        Me.Th1.Text = "00"
        Me.Th1.UseVisualStyleBackColor = False
        '
        'Fr1
        '
        Me.Fr1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fr1.BackColor = System.Drawing.Color.White
        Me.Fr1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Fr1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Fr1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Fr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fr1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fr1.Location = New System.Drawing.Point(233, 59)
        Me.Fr1.Name = "Fr1"
        Me.Fr1.Size = New System.Drawing.Size(39, 25)
        Me.Fr1.TabIndex = 14
        Me.Fr1.Text = "00"
        Me.Fr1.UseVisualStyleBackColor = False
        '
        'Sa1
        '
        Me.Sa1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sa1.BackColor = System.Drawing.Color.White
        Me.Sa1.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Sa1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Sa1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Sa1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sa1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sa1.Location = New System.Drawing.Point(277, 59)
        Me.Sa1.Name = "Sa1"
        Me.Sa1.Size = New System.Drawing.Size(39, 25)
        Me.Sa1.TabIndex = 15
        Me.Sa1.Text = "00"
        Me.Sa1.UseVisualStyleBackColor = False
        '
        'Su2
        '
        Me.Su2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Su2.BackColor = System.Drawing.Color.White
        Me.Su2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Su2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Su2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Su2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Su2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Su2.Location = New System.Drawing.Point(3, 90)
        Me.Su2.Name = "Su2"
        Me.Su2.Size = New System.Drawing.Size(39, 25)
        Me.Su2.TabIndex = 9
        Me.Su2.Text = "00"
        Me.Su2.UseVisualStyleBackColor = False
        '
        'Mo2
        '
        Me.Mo2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mo2.BackColor = System.Drawing.Color.White
        Me.Mo2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Mo2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Mo2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Mo2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mo2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mo2.Location = New System.Drawing.Point(49, 90)
        Me.Mo2.Name = "Mo2"
        Me.Mo2.Size = New System.Drawing.Size(39, 25)
        Me.Mo2.TabIndex = 10
        Me.Mo2.Text = "00"
        Me.Mo2.UseVisualStyleBackColor = False
        '
        'Tu2
        '
        Me.Tu2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tu2.BackColor = System.Drawing.Color.White
        Me.Tu2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Tu2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Tu2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Tu2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tu2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tu2.Location = New System.Drawing.Point(95, 90)
        Me.Tu2.Name = "Tu2"
        Me.Tu2.Size = New System.Drawing.Size(39, 25)
        Me.Tu2.TabIndex = 11
        Me.Tu2.Text = "00"
        Me.Tu2.UseVisualStyleBackColor = False
        '
        'We2
        '
        Me.We2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.We2.BackColor = System.Drawing.Color.White
        Me.We2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.We2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.We2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.We2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.We2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.We2.Location = New System.Drawing.Point(141, 90)
        Me.We2.Name = "We2"
        Me.We2.Size = New System.Drawing.Size(39, 25)
        Me.We2.TabIndex = 12
        Me.We2.Text = "00"
        Me.We2.UseVisualStyleBackColor = False
        '
        'Th2
        '
        Me.Th2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Th2.BackColor = System.Drawing.Color.White
        Me.Th2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Th2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Th2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Th2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Th2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th2.Location = New System.Drawing.Point(187, 90)
        Me.Th2.Name = "Th2"
        Me.Th2.Size = New System.Drawing.Size(39, 25)
        Me.Th2.TabIndex = 13
        Me.Th2.Text = "00"
        Me.Th2.UseVisualStyleBackColor = False
        '
        'Fr2
        '
        Me.Fr2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fr2.BackColor = System.Drawing.Color.White
        Me.Fr2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Fr2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Fr2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Fr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fr2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fr2.Location = New System.Drawing.Point(233, 90)
        Me.Fr2.Name = "Fr2"
        Me.Fr2.Size = New System.Drawing.Size(39, 25)
        Me.Fr2.TabIndex = 14
        Me.Fr2.Text = "00"
        Me.Fr2.UseVisualStyleBackColor = False
        '
        'Sa2
        '
        Me.Sa2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sa2.BackColor = System.Drawing.Color.White
        Me.Sa2.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Sa2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Sa2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Sa2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sa2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sa2.Location = New System.Drawing.Point(277, 90)
        Me.Sa2.Name = "Sa2"
        Me.Sa2.Size = New System.Drawing.Size(39, 25)
        Me.Sa2.TabIndex = 15
        Me.Sa2.Text = "00"
        Me.Sa2.UseVisualStyleBackColor = False
        '
        'Su3
        '
        Me.Su3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Su3.BackColor = System.Drawing.Color.White
        Me.Su3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Su3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Su3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Su3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Su3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Su3.Location = New System.Drawing.Point(3, 121)
        Me.Su3.Name = "Su3"
        Me.Su3.Size = New System.Drawing.Size(39, 25)
        Me.Su3.TabIndex = 9
        Me.Su3.Text = "00"
        Me.Su3.UseVisualStyleBackColor = False
        '
        'Mo3
        '
        Me.Mo3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mo3.BackColor = System.Drawing.Color.White
        Me.Mo3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Mo3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Mo3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Mo3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mo3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mo3.Location = New System.Drawing.Point(49, 121)
        Me.Mo3.Name = "Mo3"
        Me.Mo3.Size = New System.Drawing.Size(39, 25)
        Me.Mo3.TabIndex = 10
        Me.Mo3.Text = "00"
        Me.Mo3.UseVisualStyleBackColor = False
        '
        'Tu3
        '
        Me.Tu3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tu3.BackColor = System.Drawing.Color.White
        Me.Tu3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Tu3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Tu3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Tu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tu3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tu3.Location = New System.Drawing.Point(95, 121)
        Me.Tu3.Name = "Tu3"
        Me.Tu3.Size = New System.Drawing.Size(39, 25)
        Me.Tu3.TabIndex = 11
        Me.Tu3.Text = "00"
        Me.Tu3.UseVisualStyleBackColor = False
        '
        'We3
        '
        Me.We3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.We3.BackColor = System.Drawing.Color.White
        Me.We3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.We3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.We3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.We3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.We3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.We3.Location = New System.Drawing.Point(141, 121)
        Me.We3.Name = "We3"
        Me.We3.Size = New System.Drawing.Size(39, 25)
        Me.We3.TabIndex = 12
        Me.We3.Text = "00"
        Me.We3.UseVisualStyleBackColor = False
        '
        'Th3
        '
        Me.Th3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Th3.BackColor = System.Drawing.Color.White
        Me.Th3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Th3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Th3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Th3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Th3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th3.Location = New System.Drawing.Point(187, 121)
        Me.Th3.Name = "Th3"
        Me.Th3.Size = New System.Drawing.Size(39, 25)
        Me.Th3.TabIndex = 13
        Me.Th3.Text = "00"
        Me.Th3.UseVisualStyleBackColor = False
        '
        'Fr3
        '
        Me.Fr3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fr3.BackColor = System.Drawing.Color.White
        Me.Fr3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Fr3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Fr3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Fr3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fr3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fr3.Location = New System.Drawing.Point(233, 121)
        Me.Fr3.Name = "Fr3"
        Me.Fr3.Size = New System.Drawing.Size(39, 25)
        Me.Fr3.TabIndex = 14
        Me.Fr3.Text = "00"
        Me.Fr3.UseVisualStyleBackColor = False
        '
        'Sa3
        '
        Me.Sa3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sa3.BackColor = System.Drawing.Color.White
        Me.Sa3.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Sa3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Sa3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Sa3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sa3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sa3.Location = New System.Drawing.Point(277, 121)
        Me.Sa3.Name = "Sa3"
        Me.Sa3.Size = New System.Drawing.Size(39, 25)
        Me.Sa3.TabIndex = 15
        Me.Sa3.Text = "00"
        Me.Sa3.UseVisualStyleBackColor = False
        '
        'Su4
        '
        Me.Su4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Su4.BackColor = System.Drawing.Color.White
        Me.Su4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Su4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Su4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Su4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Su4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Su4.Location = New System.Drawing.Point(3, 152)
        Me.Su4.Name = "Su4"
        Me.Su4.Size = New System.Drawing.Size(39, 25)
        Me.Su4.TabIndex = 9
        Me.Su4.Text = "00"
        Me.Su4.UseVisualStyleBackColor = False
        '
        'Mo4
        '
        Me.Mo4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mo4.BackColor = System.Drawing.Color.White
        Me.Mo4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Mo4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Mo4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Mo4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mo4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mo4.Location = New System.Drawing.Point(49, 152)
        Me.Mo4.Name = "Mo4"
        Me.Mo4.Size = New System.Drawing.Size(39, 25)
        Me.Mo4.TabIndex = 10
        Me.Mo4.Text = "00"
        Me.Mo4.UseVisualStyleBackColor = False
        '
        'Tu4
        '
        Me.Tu4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tu4.BackColor = System.Drawing.Color.White
        Me.Tu4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Tu4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Tu4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Tu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tu4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tu4.Location = New System.Drawing.Point(95, 152)
        Me.Tu4.Name = "Tu4"
        Me.Tu4.Size = New System.Drawing.Size(39, 25)
        Me.Tu4.TabIndex = 11
        Me.Tu4.Text = "00"
        Me.Tu4.UseVisualStyleBackColor = False
        '
        'We4
        '
        Me.We4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.We4.BackColor = System.Drawing.Color.White
        Me.We4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.We4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.We4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.We4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.We4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.We4.Location = New System.Drawing.Point(141, 152)
        Me.We4.Name = "We4"
        Me.We4.Size = New System.Drawing.Size(39, 25)
        Me.We4.TabIndex = 12
        Me.We4.Text = "00"
        Me.We4.UseVisualStyleBackColor = False
        '
        'Th4
        '
        Me.Th4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Th4.BackColor = System.Drawing.Color.White
        Me.Th4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Th4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Th4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Th4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Th4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th4.Location = New System.Drawing.Point(187, 152)
        Me.Th4.Name = "Th4"
        Me.Th4.Size = New System.Drawing.Size(39, 25)
        Me.Th4.TabIndex = 14
        Me.Th4.Text = "00"
        Me.Th4.UseVisualStyleBackColor = False
        '
        'Fr4
        '
        Me.Fr4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fr4.BackColor = System.Drawing.Color.White
        Me.Fr4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Fr4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Fr4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Fr4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fr4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fr4.Location = New System.Drawing.Point(233, 152)
        Me.Fr4.Name = "Fr4"
        Me.Fr4.Size = New System.Drawing.Size(39, 25)
        Me.Fr4.TabIndex = 14
        Me.Fr4.Text = "00"
        Me.Fr4.UseVisualStyleBackColor = False
        '
        'Sa4
        '
        Me.Sa4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sa4.BackColor = System.Drawing.Color.White
        Me.Sa4.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Sa4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Sa4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Sa4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sa4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sa4.Location = New System.Drawing.Point(277, 152)
        Me.Sa4.Name = "Sa4"
        Me.Sa4.Size = New System.Drawing.Size(39, 25)
        Me.Sa4.TabIndex = 15
        Me.Sa4.Text = "00"
        Me.Sa4.UseVisualStyleBackColor = False
        '
        'Su5
        '
        Me.Su5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Su5.BackColor = System.Drawing.Color.White
        Me.Su5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Su5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Su5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Su5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Su5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Su5.Location = New System.Drawing.Point(3, 183)
        Me.Su5.Name = "Su5"
        Me.Su5.Size = New System.Drawing.Size(39, 25)
        Me.Su5.TabIndex = 9
        Me.Su5.Text = "00"
        Me.Su5.UseVisualStyleBackColor = False
        '
        'Mo5
        '
        Me.Mo5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mo5.BackColor = System.Drawing.Color.White
        Me.Mo5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Mo5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Mo5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Mo5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mo5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mo5.Location = New System.Drawing.Point(49, 183)
        Me.Mo5.Name = "Mo5"
        Me.Mo5.Size = New System.Drawing.Size(39, 25)
        Me.Mo5.TabIndex = 10
        Me.Mo5.Text = "00"
        Me.Mo5.UseVisualStyleBackColor = False
        '
        'Tu5
        '
        Me.Tu5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tu5.BackColor = System.Drawing.Color.White
        Me.Tu5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Tu5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Tu5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Tu5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tu5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tu5.Location = New System.Drawing.Point(95, 183)
        Me.Tu5.Name = "Tu5"
        Me.Tu5.Size = New System.Drawing.Size(39, 25)
        Me.Tu5.TabIndex = 11
        Me.Tu5.Text = "00"
        Me.Tu5.UseVisualStyleBackColor = False
        '
        'We5
        '
        Me.We5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.We5.BackColor = System.Drawing.Color.White
        Me.We5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.We5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.We5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.We5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.We5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.We5.Location = New System.Drawing.Point(141, 183)
        Me.We5.Name = "We5"
        Me.We5.Size = New System.Drawing.Size(39, 25)
        Me.We5.TabIndex = 12
        Me.We5.Text = "00"
        Me.We5.UseVisualStyleBackColor = False
        '
        'Th5
        '
        Me.Th5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Th5.BackColor = System.Drawing.Color.White
        Me.Th5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Th5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Th5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Th5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Th5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th5.Location = New System.Drawing.Point(187, 183)
        Me.Th5.Name = "Th5"
        Me.Th5.Size = New System.Drawing.Size(39, 25)
        Me.Th5.TabIndex = 14
        Me.Th5.Text = "00"
        Me.Th5.UseVisualStyleBackColor = False
        '
        'Fr5
        '
        Me.Fr5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fr5.BackColor = System.Drawing.Color.White
        Me.Fr5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Fr5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Fr5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Fr5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fr5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fr5.Location = New System.Drawing.Point(233, 183)
        Me.Fr5.Name = "Fr5"
        Me.Fr5.Size = New System.Drawing.Size(39, 25)
        Me.Fr5.TabIndex = 14
        Me.Fr5.Text = "00"
        Me.Fr5.UseVisualStyleBackColor = False
        '
        'Sa5
        '
        Me.Sa5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sa5.BackColor = System.Drawing.Color.White
        Me.Sa5.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Sa5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Sa5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Sa5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sa5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sa5.Location = New System.Drawing.Point(277, 183)
        Me.Sa5.Name = "Sa5"
        Me.Sa5.Size = New System.Drawing.Size(39, 25)
        Me.Sa5.TabIndex = 15
        Me.Sa5.Text = "00"
        Me.Sa5.UseVisualStyleBackColor = False
        '
        'Su6
        '
        Me.Su6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Su6.BackColor = System.Drawing.Color.White
        Me.Su6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Su6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Su6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Su6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Su6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Su6.Location = New System.Drawing.Point(3, 214)
        Me.Su6.Name = "Su6"
        Me.Su6.Size = New System.Drawing.Size(39, 25)
        Me.Su6.TabIndex = 9
        Me.Su6.Text = "00"
        Me.Su6.UseVisualStyleBackColor = False
        '
        'Mo6
        '
        Me.Mo6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mo6.BackColor = System.Drawing.Color.White
        Me.Mo6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Mo6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Mo6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Mo6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Mo6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mo6.Location = New System.Drawing.Point(49, 214)
        Me.Mo6.Name = "Mo6"
        Me.Mo6.Size = New System.Drawing.Size(39, 25)
        Me.Mo6.TabIndex = 10
        Me.Mo6.Text = "00"
        Me.Mo6.UseVisualStyleBackColor = False
        '
        'Tu6
        '
        Me.Tu6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tu6.BackColor = System.Drawing.Color.White
        Me.Tu6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Tu6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Tu6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Tu6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Tu6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tu6.Location = New System.Drawing.Point(95, 214)
        Me.Tu6.Name = "Tu6"
        Me.Tu6.Size = New System.Drawing.Size(39, 25)
        Me.Tu6.TabIndex = 11
        Me.Tu6.Text = "00"
        Me.Tu6.UseVisualStyleBackColor = False
        '
        'We6
        '
        Me.We6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.We6.BackColor = System.Drawing.Color.White
        Me.We6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.We6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.We6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.We6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.We6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.We6.Location = New System.Drawing.Point(141, 214)
        Me.We6.Name = "We6"
        Me.We6.Size = New System.Drawing.Size(39, 25)
        Me.We6.TabIndex = 12
        Me.We6.Text = "00"
        Me.We6.UseVisualStyleBackColor = False
        '
        'Th6
        '
        Me.Th6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Th6.BackColor = System.Drawing.Color.White
        Me.Th6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Th6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Th6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Th6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Th6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Th6.Location = New System.Drawing.Point(187, 214)
        Me.Th6.Name = "Th6"
        Me.Th6.Size = New System.Drawing.Size(39, 25)
        Me.Th6.TabIndex = 14
        Me.Th6.Text = "00"
        Me.Th6.UseVisualStyleBackColor = False
        '
        'Fr6
        '
        Me.Fr6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fr6.BackColor = System.Drawing.Color.White
        Me.Fr6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Fr6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Fr6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Fr6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Fr6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fr6.Location = New System.Drawing.Point(233, 214)
        Me.Fr6.Name = "Fr6"
        Me.Fr6.Size = New System.Drawing.Size(39, 25)
        Me.Fr6.TabIndex = 14
        Me.Fr6.Text = "00"
        Me.Fr6.UseVisualStyleBackColor = False
        '
        'Sa6
        '
        Me.Sa6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sa6.BackColor = System.Drawing.Color.White
        Me.Sa6.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke
        Me.Sa6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro
        Me.Sa6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro
        Me.Sa6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Sa6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sa6.Location = New System.Drawing.Point(277, 214)
        Me.Sa6.Name = "Sa6"
        Me.Sa6.Size = New System.Drawing.Size(39, 25)
        Me.Sa6.TabIndex = 15
        Me.Sa6.Text = "00"
        Me.Sa6.UseVisualStyleBackColor = False
        '
        'Mon
        '
        Me.Mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mon.BackColor = System.Drawing.Color.DarkGray
        Me.Mon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mon.ForeColor = System.Drawing.Color.White
        Me.Mon.Location = New System.Drawing.Point(46, 38)
        Me.Mon.Name = "Mon"
        Me.Mon.Size = New System.Drawing.Size(46, 18)
        Me.Mon.TabIndex = 2
        Me.Mon.Text = "Mon"
        Me.Mon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tue
        '
        Me.Tue.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tue.BackColor = System.Drawing.Color.DarkGray
        Me.Tue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tue.ForeColor = System.Drawing.Color.White
        Me.Tue.Location = New System.Drawing.Point(92, 38)
        Me.Tue.Name = "Tue"
        Me.Tue.Size = New System.Drawing.Size(46, 18)
        Me.Tue.TabIndex = 2
        Me.Tue.Text = "Tue"
        Me.Tue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Wed
        '
        Me.Wed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Wed.BackColor = System.Drawing.Color.DarkGray
        Me.Wed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Wed.ForeColor = System.Drawing.Color.White
        Me.Wed.Location = New System.Drawing.Point(138, 38)
        Me.Wed.Name = "Wed"
        Me.Wed.Size = New System.Drawing.Size(46, 18)
        Me.Wed.TabIndex = 2
        Me.Wed.Text = "Wed"
        Me.Wed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Thu
        '
        Me.Thu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Thu.BackColor = System.Drawing.Color.DarkGray
        Me.Thu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Thu.ForeColor = System.Drawing.Color.White
        Me.Thu.Location = New System.Drawing.Point(184, 38)
        Me.Thu.Name = "Thu"
        Me.Thu.Size = New System.Drawing.Size(46, 18)
        Me.Thu.TabIndex = 2
        Me.Thu.Text = "Thu"
        Me.Thu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Fri
        '
        Me.Fri.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Fri.BackColor = System.Drawing.Color.DarkGray
        Me.Fri.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fri.ForeColor = System.Drawing.Color.White
        Me.Fri.Location = New System.Drawing.Point(230, 38)
        Me.Fri.Name = "Fri"
        Me.Fri.Size = New System.Drawing.Size(46, 18)
        Me.Fri.TabIndex = 2
        Me.Fri.Text = "Fri"
        Me.Fri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Sat
        '
        Me.Sat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sat.BackColor = System.Drawing.Color.DarkGray
        Me.Sat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sat.ForeColor = System.Drawing.Color.White
        Me.Sat.Location = New System.Drawing.Point(275, 38)
        Me.Sat.Name = "Sat"
        Me.Sat.Size = New System.Drawing.Size(45, 18)
        Me.Sat.TabIndex = 2
        Me.Sat.Text = "Sat"
        Me.Sat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnNextMonth
        '
        Me.btnNextMonth.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNextMonth.BackColor = System.Drawing.Color.DarkGray
        Me.btnNextMonth.BackgroundImage = Global.NHLGames.My.Resources.Resources.bright
        Me.btnNextMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNextMonth.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNextMonth.FlatAppearance.BorderSize = 0
        Me.btnNextMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnNextMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNextMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextMonth.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnNextMonth.Location = New System.Drawing.Point(290, 6)
        Me.btnNextMonth.Name = "btnNextMonth"
        Me.btnNextMonth.Size = New System.Drawing.Size(26, 26)
        Me.btnNextMonth.TabIndex = 16
        Me.btnNextMonth.UseVisualStyleBackColor = False
        '
        'btnBeforeMonth
        '
        Me.btnBeforeMonth.BackColor = System.Drawing.Color.DarkGray
        Me.btnBeforeMonth.BackgroundImage = Global.NHLGames.My.Resources.Resources.bleft
        Me.btnBeforeMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeMonth.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBeforeMonth.FlatAppearance.BorderSize = 0
        Me.btnBeforeMonth.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnBeforeMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBeforeMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBeforeMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeforeMonth.Font = New System.Drawing.Font("Verdana", 20.0!, System.Drawing.FontStyle.Bold)
        Me.btnBeforeMonth.Location = New System.Drawing.Point(0, 6)
        Me.btnBeforeMonth.Name = "btnBeforeMonth"
        Me.btnBeforeMonth.Size = New System.Drawing.Size(26, 26)
        Me.btnBeforeMonth.TabIndex = 17
        Me.btnBeforeMonth.UseVisualStyleBackColor = False
        '
        'btnBeforeYear
        '
        Me.btnBeforeYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBeforeYear.BackColor = System.Drawing.Color.DarkGray
        Me.btnBeforeYear.BackgroundImage = Global.NHLGames.My.Resources.Resources.bup
        Me.btnBeforeYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBeforeYear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnBeforeYear.FlatAppearance.BorderSize = 0
        Me.btnBeforeYear.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnBeforeYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnBeforeYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnBeforeYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeforeYear.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.btnBeforeYear.Location = New System.Drawing.Point(254, 6)
        Me.btnBeforeYear.Name = "btnBeforeYear"
        Me.btnBeforeYear.Size = New System.Drawing.Size(22, 11)
        Me.btnBeforeYear.TabIndex = 18
        Me.btnBeforeYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBeforeYear.UseVisualStyleBackColor = False
        '
        'btnNextYear
        '
        Me.btnNextYear.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNextYear.BackColor = System.Drawing.Color.DarkGray
        Me.btnNextYear.BackgroundImage = Global.NHLGames.My.Resources.Resources.bdown
        Me.btnNextYear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNextYear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnNextYear.FlatAppearance.BorderSize = 0
        Me.btnNextYear.FlatAppearance.CheckedBackColor = System.Drawing.Color.White
        Me.btnNextYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btnNextYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btnNextYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextYear.Font = New System.Drawing.Font("Verdana", 7.0!)
        Me.btnNextYear.Location = New System.Drawing.Point(254, 20)
        Me.btnNextYear.Name = "btnNextYear"
        Me.btnNextYear.Size = New System.Drawing.Size(22, 11)
        Me.btnNextYear.TabIndex = 18
        Me.btnNextYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNextYear.UseVisualStyleBackColor = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(320, 38)
        Me.FlowLayoutPanel1.TabIndex = 19
        '
        'CalenderControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnBeforeYear)
        Me.Controls.Add(Me.btnNextYear)
        Me.Controls.Add(Me.btnBeforeMonth)
        Me.Controls.Add(Me.btnNextMonth)
        Me.Controls.Add(Me.Sa6)
        Me.Controls.Add(Me.Sa5)
        Me.Controls.Add(Me.Sa4)
        Me.Controls.Add(Me.Sa3)
        Me.Controls.Add(Me.Sa2)
        Me.Controls.Add(Me.Sa1)
        Me.Controls.Add(Me.Fr6)
        Me.Controls.Add(Me.Fr5)
        Me.Controls.Add(Me.Fr4)
        Me.Controls.Add(Me.Fr3)
        Me.Controls.Add(Me.Fr2)
        Me.Controls.Add(Me.Fr1)
        Me.Controls.Add(Me.Th6)
        Me.Controls.Add(Me.Th5)
        Me.Controls.Add(Me.Th4)
        Me.Controls.Add(Me.Th3)
        Me.Controls.Add(Me.Th2)
        Me.Controls.Add(Me.Th1)
        Me.Controls.Add(Me.We6)
        Me.Controls.Add(Me.We5)
        Me.Controls.Add(Me.We4)
        Me.Controls.Add(Me.We3)
        Me.Controls.Add(Me.We2)
        Me.Controls.Add(Me.We1)
        Me.Controls.Add(Me.Tu6)
        Me.Controls.Add(Me.Tu5)
        Me.Controls.Add(Me.Tu4)
        Me.Controls.Add(Me.Tu3)
        Me.Controls.Add(Me.Tu2)
        Me.Controls.Add(Me.Tu1)
        Me.Controls.Add(Me.Mo6)
        Me.Controls.Add(Me.Mo5)
        Me.Controls.Add(Me.Mo4)
        Me.Controls.Add(Me.Mo3)
        Me.Controls.Add(Me.Mo2)
        Me.Controls.Add(Me.Mo1)
        Me.Controls.Add(Me.Su6)
        Me.Controls.Add(Me.Su5)
        Me.Controls.Add(Me.Su4)
        Me.Controls.Add(Me.Su3)
        Me.Controls.Add(Me.Su2)
        Me.Controls.Add(Me.Su1)
        Me.Controls.Add(Me.Sat)
        Me.Controls.Add(Me.Fri)
        Me.Controls.Add(Me.Thu)
        Me.Controls.Add(Me.Wed)
        Me.Controls.Add(Me.Tue)
        Me.Controls.Add(Me.Mon)
        Me.Controls.Add(Me.Sun)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "CalenderControl"
        Me.Size = New System.Drawing.Size(320, 282)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnToday As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents Sun As Label
    Friend WithEvents Su1 As Button
    Friend WithEvents Mo1 As Button
    Friend WithEvents Tu1 As Button
    Friend WithEvents We1 As Button
    Friend WithEvents Th1 As Button
    Friend WithEvents Fr1 As Button
    Friend WithEvents Sa1 As Button
    Friend WithEvents Su2 As Button
    Friend WithEvents Mo2 As Button
    Friend WithEvents Tu2 As Button
    Friend WithEvents We2 As Button
    Friend WithEvents Th2 As Button
    Friend WithEvents Fr2 As Button
    Friend WithEvents Sa2 As Button
    Friend WithEvents Su3 As Button
    Friend WithEvents Mo3 As Button
    Friend WithEvents Tu3 As Button
    Friend WithEvents We3 As Button
    Friend WithEvents Th3 As Button
    Friend WithEvents Fr3 As Button
    Friend WithEvents Sa3 As Button
    Friend WithEvents Su4 As Button
    Friend WithEvents Mo4 As Button
    Friend WithEvents Tu4 As Button
    Friend WithEvents We4 As Button
    Friend WithEvents Th4 As Button
    Friend WithEvents Fr4 As Button
    Friend WithEvents Sa4 As Button
    Friend WithEvents Su5 As Button
    Friend WithEvents Mo5 As Button
    Friend WithEvents Tu5 As Button
    Friend WithEvents We5 As Button
    Friend WithEvents Th5 As Button
    Friend WithEvents Fr5 As Button
    Friend WithEvents Sa5 As Button
    Friend WithEvents Su6 As Button
    Friend WithEvents Mo6 As Button
    Friend WithEvents Tu6 As Button
    Friend WithEvents We6 As Button
    Friend WithEvents Th6 As Button
    Friend WithEvents Fr6 As Button
    Friend WithEvents Sa6 As Button
    Friend WithEvents Mon As Label
    Friend WithEvents Tue As Label
    Friend WithEvents Wed As Label
    Friend WithEvents Thu As Label
    Friend WithEvents Fri As Label
    Friend WithEvents Sat As Label
    Friend WithEvents btnNextMonth As Button
    Friend WithEvents btnBeforeMonth As Button
    Friend WithEvents btnBeforeYear As Button
    Friend WithEvents btnNextYear As Button
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
