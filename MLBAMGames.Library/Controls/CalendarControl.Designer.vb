Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports MetroFramework
Imports MetroFramework.Components
Imports MetroFramework.Controls
Imports Microsoft.VisualBasic.CompilerServices

Namespace Controls
    <DesignerGenerated()>
    Partial Class CalendarControl
        Inherits UserControl

        'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
        <DebuggerNonUserCode()>
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
        Private components As IContainer

        'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
        'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
        'Ne la modifiez pas à l'aide de l'éditeur de code.
        <DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.lnkToday = New Button()
            Me.Su1 = New Button()
            Me.Mo1 = New Button()
            Me.Tu1 = New Button()
            Me.We1 = New Button()
            Me.Th1 = New Button()
            Me.Fr1 = New Button()
            Me.Sa1 = New Button()
            Me.Su2 = New Button()
            Me.Mo2 = New Button()
            Me.Tu2 = New Button()
            Me.We2 = New Button()
            Me.Th2 = New Button()
            Me.Fr2 = New Button()
            Me.Sa2 = New Button()
            Me.Su3 = New Button()
            Me.Mo3 = New Button()
            Me.Tu3 = New Button()
            Me.We3 = New Button()
            Me.Th3 = New Button()
            Me.Fr3 = New Button()
            Me.Sa3 = New Button()
            Me.Su4 = New Button()
            Me.Mo4 = New Button()
            Me.Tu4 = New Button()
            Me.We4 = New Button()
            Me.Th4 = New Button()
            Me.Fr4 = New Button()
            Me.Sa4 = New Button()
            Me.Su5 = New Button()
            Me.Mo5 = New Button()
            Me.Tu5 = New Button()
            Me.We5 = New Button()
            Me.Th5 = New Button()
            Me.Fr5 = New Button()
            Me.Sa5 = New Button()
            Me.Su6 = New Button()
            Me.Mo6 = New Button()
            Me.Tu6 = New Button()
            Me.We6 = New Button()
            Me.Th6 = New Button()
            Me.Fr6 = New Button()
            Me.Sa6 = New Button()
            Me.lblWeeksBackground = New Label()
            Me.lblDate = New MetroLabel()
            Me.Sun = New MetroLabel()
            Me.Mon = New MetroLabel()
            Me.Tue = New MetroLabel()
            Me.Wed = New MetroLabel()
            Me.Thu = New MetroLabel()
            Me.Fri = New MetroLabel()
            Me.Sat = New MetroLabel()
            Me.btnBeforeMonth = New Button()
            Me.btnBeforeYear = New Button()
            Me.btnNextMonth = New Button()
            Me.btnNextYear = New Button()
            Me.tt = New MetroToolTip()
            Me.SuspendLayout()
            '
            'lnkToday
            '
            Me.lnkToday.Anchor = CType(((AnchorStyles.Bottom Or AnchorStyles.Left) _
                Or AnchorStyles.Right), AnchorStyles)
            Me.lnkToday.BackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.lnkToday.FlatAppearance.BorderSize = 0
            Me.lnkToday.FlatAppearance.MouseOverBackColor = Color.DarkGray
            Me.lnkToday.FlatStyle = FlatStyle.Flat
            Me.lnkToday.Font = New Font("Segoe UI", 9.75!, FontStyle.Bold, GraphicsUnit.Point, CType(0, Byte))
            Me.lnkToday.ForeColor = Color.White
            Me.lnkToday.Location = New Point(3, 265)
            Me.lnkToday.Name = "lnkToday"
            Me.lnkToday.Size = New Size(272, 40)
            Me.lnkToday.TabIndex = 1
            Me.lnkToday.Text = "TODAY"
            Me.lnkToday.UseVisualStyleBackColor = False
            '
            'Su1
            '
            Me.Su1.BackColor = Color.White
            Me.Su1.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Su1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Su1.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Su1.FlatStyle = FlatStyle.Flat
            Me.Su1.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Su1.Location = New Point(2, 75)
            Me.Su1.Name = "Su1"
            Me.Su1.Size = New Size(34, 26)
            Me.Su1.TabIndex = 9
            Me.Su1.UseVisualStyleBackColor = False
            '
            'Mo1
            '
            Me.Mo1.BackColor = Color.White
            Me.Mo1.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Mo1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Mo1.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Mo1.FlatStyle = FlatStyle.Flat
            Me.Mo1.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Mo1.Location = New Point(42, 75)
            Me.Mo1.Name = "Mo1"
            Me.Mo1.Size = New Size(34, 26)
            Me.Mo1.TabIndex = 10
            Me.Mo1.UseVisualStyleBackColor = False
            '
            'Tu1
            '
            Me.Tu1.BackColor = Color.White
            Me.Tu1.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Tu1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Tu1.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Tu1.FlatStyle = FlatStyle.Flat
            Me.Tu1.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Tu1.Location = New Point(82, 75)
            Me.Tu1.Name = "Tu1"
            Me.Tu1.Size = New Size(34, 26)
            Me.Tu1.TabIndex = 11
            Me.Tu1.UseVisualStyleBackColor = False
            '
            'We1
            '
            Me.We1.BackColor = Color.White
            Me.We1.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.We1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.We1.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.We1.FlatStyle = FlatStyle.Flat
            Me.We1.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.We1.Location = New Point(122, 75)
            Me.We1.Name = "We1"
            Me.We1.Size = New Size(34, 26)
            Me.We1.TabIndex = 12
            Me.We1.UseVisualStyleBackColor = False
            '
            'Th1
            '
            Me.Th1.BackColor = Color.White
            Me.Th1.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Th1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Th1.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Th1.FlatStyle = FlatStyle.Flat
            Me.Th1.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Th1.Location = New Point(162, 75)
            Me.Th1.Name = "Th1"
            Me.Th1.Size = New Size(34, 26)
            Me.Th1.TabIndex = 13
            Me.Th1.UseVisualStyleBackColor = False
            '
            'Fr1
            '
            Me.Fr1.BackColor = Color.White
            Me.Fr1.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Fr1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Fr1.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Fr1.FlatStyle = FlatStyle.Flat
            Me.Fr1.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Fr1.Location = New Point(202, 75)
            Me.Fr1.Name = "Fr1"
            Me.Fr1.Size = New Size(34, 26)
            Me.Fr1.TabIndex = 14
            Me.Fr1.UseVisualStyleBackColor = False
            '
            'Sa1
            '
            Me.Sa1.BackColor = Color.White
            Me.Sa1.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Sa1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Sa1.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Sa1.FlatStyle = FlatStyle.Flat
            Me.Sa1.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Sa1.Location = New Point(242, 75)
            Me.Sa1.Name = "Sa1"
            Me.Sa1.Size = New Size(34, 26)
            Me.Sa1.TabIndex = 15
            Me.Sa1.UseVisualStyleBackColor = False
            '
            'Su2
            '
            Me.Su2.BackColor = Color.White
            Me.Su2.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Su2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Su2.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Su2.FlatStyle = FlatStyle.Flat
            Me.Su2.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Su2.Location = New Point(2, 107)
            Me.Su2.Name = "Su2"
            Me.Su2.Size = New Size(34, 26)
            Me.Su2.TabIndex = 9
            Me.Su2.UseVisualStyleBackColor = False
            '
            'Mo2
            '
            Me.Mo2.BackColor = Color.White
            Me.Mo2.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Mo2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Mo2.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Mo2.FlatStyle = FlatStyle.Flat
            Me.Mo2.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Mo2.Location = New Point(42, 107)
            Me.Mo2.Name = "Mo2"
            Me.Mo2.Size = New Size(34, 26)
            Me.Mo2.TabIndex = 10
            Me.Mo2.UseVisualStyleBackColor = False
            '
            'Tu2
            '
            Me.Tu2.BackColor = Color.White
            Me.Tu2.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Tu2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Tu2.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Tu2.FlatStyle = FlatStyle.Flat
            Me.Tu2.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Tu2.Location = New Point(82, 107)
            Me.Tu2.Name = "Tu2"
            Me.Tu2.Size = New Size(34, 26)
            Me.Tu2.TabIndex = 11
            Me.Tu2.UseVisualStyleBackColor = False
            '
            'We2
            '
            Me.We2.BackColor = Color.White
            Me.We2.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.We2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.We2.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.We2.FlatStyle = FlatStyle.Flat
            Me.We2.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.We2.Location = New Point(122, 107)
            Me.We2.Name = "We2"
            Me.We2.Size = New Size(34, 26)
            Me.We2.TabIndex = 12
            Me.We2.UseVisualStyleBackColor = False
            '
            'Th2
            '
            Me.Th2.BackColor = Color.White
            Me.Th2.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Th2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Th2.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Th2.FlatStyle = FlatStyle.Flat
            Me.Th2.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Th2.Location = New Point(162, 107)
            Me.Th2.Name = "Th2"
            Me.Th2.Size = New Size(34, 26)
            Me.Th2.TabIndex = 13
            Me.Th2.UseVisualStyleBackColor = False
            '
            'Fr2
            '
            Me.Fr2.BackColor = Color.White
            Me.Fr2.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Fr2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Fr2.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Fr2.FlatStyle = FlatStyle.Flat
            Me.Fr2.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Fr2.Location = New Point(202, 107)
            Me.Fr2.Name = "Fr2"
            Me.Fr2.Size = New Size(34, 26)
            Me.Fr2.TabIndex = 14
            Me.Fr2.UseVisualStyleBackColor = False
            '
            'Sa2
            '
            Me.Sa2.BackColor = Color.White
            Me.Sa2.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Sa2.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Sa2.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Sa2.FlatStyle = FlatStyle.Flat
            Me.Sa2.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Sa2.Location = New Point(242, 107)
            Me.Sa2.Name = "Sa2"
            Me.Sa2.Size = New Size(34, 26)
            Me.Sa2.TabIndex = 15
            Me.Sa2.UseVisualStyleBackColor = False
            '
            'Su3
            '
            Me.Su3.BackColor = Color.White
            Me.Su3.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Su3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Su3.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Su3.FlatStyle = FlatStyle.Flat
            Me.Su3.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Su3.Location = New Point(2, 139)
            Me.Su3.Name = "Su3"
            Me.Su3.Size = New Size(34, 26)
            Me.Su3.TabIndex = 9
            Me.Su3.UseVisualStyleBackColor = False
            '
            'Mo3
            '
            Me.Mo3.BackColor = Color.White
            Me.Mo3.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Mo3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Mo3.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Mo3.FlatStyle = FlatStyle.Flat
            Me.Mo3.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Mo3.Location = New Point(42, 139)
            Me.Mo3.Name = "Mo3"
            Me.Mo3.Size = New Size(34, 26)
            Me.Mo3.TabIndex = 10
            Me.Mo3.UseVisualStyleBackColor = False
            '
            'Tu3
            '
            Me.Tu3.BackColor = Color.White
            Me.Tu3.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Tu3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Tu3.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Tu3.FlatStyle = FlatStyle.Flat
            Me.Tu3.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Tu3.Location = New Point(82, 139)
            Me.Tu3.Name = "Tu3"
            Me.Tu3.Size = New Size(34, 26)
            Me.Tu3.TabIndex = 11
            Me.Tu3.UseVisualStyleBackColor = False
            '
            'We3
            '
            Me.We3.BackColor = Color.White
            Me.We3.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.We3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.We3.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.We3.FlatStyle = FlatStyle.Flat
            Me.We3.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.We3.Location = New Point(122, 139)
            Me.We3.Name = "We3"
            Me.We3.Size = New Size(34, 26)
            Me.We3.TabIndex = 12
            Me.We3.UseVisualStyleBackColor = False
            '
            'Th3
            '
            Me.Th3.BackColor = Color.White
            Me.Th3.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Th3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Th3.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Th3.FlatStyle = FlatStyle.Flat
            Me.Th3.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Th3.Location = New Point(162, 139)
            Me.Th3.Name = "Th3"
            Me.Th3.Size = New Size(34, 26)
            Me.Th3.TabIndex = 13
            Me.Th3.UseVisualStyleBackColor = False
            '
            'Fr3
            '
            Me.Fr3.BackColor = Color.White
            Me.Fr3.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Fr3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Fr3.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Fr3.FlatStyle = FlatStyle.Flat
            Me.Fr3.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Fr3.Location = New Point(202, 139)
            Me.Fr3.Name = "Fr3"
            Me.Fr3.Size = New Size(34, 26)
            Me.Fr3.TabIndex = 14
            Me.Fr3.UseVisualStyleBackColor = False
            '
            'Sa3
            '
            Me.Sa3.BackColor = Color.White
            Me.Sa3.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Sa3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Sa3.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Sa3.FlatStyle = FlatStyle.Flat
            Me.Sa3.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Sa3.Location = New Point(242, 139)
            Me.Sa3.Name = "Sa3"
            Me.Sa3.Size = New Size(34, 26)
            Me.Sa3.TabIndex = 15
            Me.Sa3.UseVisualStyleBackColor = False
            '
            'Su4
            '
            Me.Su4.BackColor = Color.White
            Me.Su4.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Su4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Su4.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Su4.FlatStyle = FlatStyle.Flat
            Me.Su4.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Su4.Location = New Point(2, 171)
            Me.Su4.Name = "Su4"
            Me.Su4.Size = New Size(34, 26)
            Me.Su4.TabIndex = 9
            Me.Su4.UseVisualStyleBackColor = False
            '
            'Mo4
            '
            Me.Mo4.BackColor = Color.White
            Me.Mo4.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Mo4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Mo4.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Mo4.FlatStyle = FlatStyle.Flat
            Me.Mo4.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Mo4.Location = New Point(42, 171)
            Me.Mo4.Name = "Mo4"
            Me.Mo4.Size = New Size(34, 26)
            Me.Mo4.TabIndex = 10
            Me.Mo4.UseVisualStyleBackColor = False
            '
            'Tu4
            '
            Me.Tu4.BackColor = Color.White
            Me.Tu4.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Tu4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Tu4.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Tu4.FlatStyle = FlatStyle.Flat
            Me.Tu4.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Tu4.Location = New Point(82, 171)
            Me.Tu4.Name = "Tu4"
            Me.Tu4.Size = New Size(34, 26)
            Me.Tu4.TabIndex = 11
            Me.Tu4.UseVisualStyleBackColor = False
            '
            'We4
            '
            Me.We4.BackColor = Color.White
            Me.We4.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.We4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.We4.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.We4.FlatStyle = FlatStyle.Flat
            Me.We4.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.We4.Location = New Point(122, 171)
            Me.We4.Name = "We4"
            Me.We4.Size = New Size(34, 26)
            Me.We4.TabIndex = 12
            Me.We4.UseVisualStyleBackColor = False
            '
            'Th4
            '
            Me.Th4.BackColor = Color.White
            Me.Th4.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Th4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Th4.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Th4.FlatStyle = FlatStyle.Flat
            Me.Th4.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Th4.Location = New Point(162, 171)
            Me.Th4.Name = "Th4"
            Me.Th4.Size = New Size(34, 26)
            Me.Th4.TabIndex = 14
            Me.Th4.UseVisualStyleBackColor = False
            '
            'Fr4
            '
            Me.Fr4.BackColor = Color.White
            Me.Fr4.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Fr4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Fr4.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Fr4.FlatStyle = FlatStyle.Flat
            Me.Fr4.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Fr4.Location = New Point(202, 171)
            Me.Fr4.Name = "Fr4"
            Me.Fr4.Size = New Size(34, 26)
            Me.Fr4.TabIndex = 14
            Me.Fr4.UseVisualStyleBackColor = False
            '
            'Sa4
            '
            Me.Sa4.BackColor = Color.White
            Me.Sa4.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Sa4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Sa4.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Sa4.FlatStyle = FlatStyle.Flat
            Me.Sa4.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Sa4.Location = New Point(242, 171)
            Me.Sa4.Name = "Sa4"
            Me.Sa4.Size = New Size(34, 26)
            Me.Sa4.TabIndex = 15
            Me.Sa4.UseVisualStyleBackColor = False
            '
            'Su5
            '
            Me.Su5.BackColor = Color.White
            Me.Su5.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Su5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Su5.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Su5.FlatStyle = FlatStyle.Flat
            Me.Su5.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Su5.Location = New Point(2, 203)
            Me.Su5.Name = "Su5"
            Me.Su5.Size = New Size(34, 26)
            Me.Su5.TabIndex = 9
            Me.Su5.UseVisualStyleBackColor = False
            '
            'Mo5
            '
            Me.Mo5.BackColor = Color.White
            Me.Mo5.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Mo5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Mo5.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Mo5.FlatStyle = FlatStyle.Flat
            Me.Mo5.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Mo5.Location = New Point(42, 203)
            Me.Mo5.Name = "Mo5"
            Me.Mo5.Size = New Size(34, 26)
            Me.Mo5.TabIndex = 10
            Me.Mo5.UseVisualStyleBackColor = False
            '
            'Tu5
            '
            Me.Tu5.BackColor = Color.White
            Me.Tu5.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Tu5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Tu5.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Tu5.FlatStyle = FlatStyle.Flat
            Me.Tu5.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Tu5.Location = New Point(82, 203)
            Me.Tu5.Name = "Tu5"
            Me.Tu5.Size = New Size(34, 26)
            Me.Tu5.TabIndex = 11
            Me.Tu5.UseVisualStyleBackColor = False
            '
            'We5
            '
            Me.We5.BackColor = Color.White
            Me.We5.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.We5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.We5.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.We5.FlatStyle = FlatStyle.Flat
            Me.We5.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.We5.Location = New Point(122, 203)
            Me.We5.Name = "We5"
            Me.We5.Size = New Size(34, 26)
            Me.We5.TabIndex = 12
            Me.We5.UseVisualStyleBackColor = False
            '
            'Th5
            '
            Me.Th5.BackColor = Color.White
            Me.Th5.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Th5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Th5.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Th5.FlatStyle = FlatStyle.Flat
            Me.Th5.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Th5.Location = New Point(162, 203)
            Me.Th5.Name = "Th5"
            Me.Th5.Size = New Size(34, 26)
            Me.Th5.TabIndex = 14
            Me.Th5.UseVisualStyleBackColor = False
            '
            'Fr5
            '
            Me.Fr5.BackColor = Color.White
            Me.Fr5.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Fr5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Fr5.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Fr5.FlatStyle = FlatStyle.Flat
            Me.Fr5.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Fr5.Location = New Point(202, 203)
            Me.Fr5.Name = "Fr5"
            Me.Fr5.Size = New Size(34, 26)
            Me.Fr5.TabIndex = 14
            Me.Fr5.UseVisualStyleBackColor = False
            '
            'Sa5
            '
            Me.Sa5.BackColor = Color.White
            Me.Sa5.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Sa5.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Sa5.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Sa5.FlatStyle = FlatStyle.Flat
            Me.Sa5.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Sa5.Location = New Point(242, 203)
            Me.Sa5.Name = "Sa5"
            Me.Sa5.Size = New Size(34, 26)
            Me.Sa5.TabIndex = 15
            Me.Sa5.UseVisualStyleBackColor = False
            '
            'Su6
            '
            Me.Su6.BackColor = Color.White
            Me.Su6.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Su6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Su6.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Su6.FlatStyle = FlatStyle.Flat
            Me.Su6.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Su6.Location = New Point(2, 235)
            Me.Su6.Name = "Su6"
            Me.Su6.Size = New Size(34, 26)
            Me.Su6.TabIndex = 9
            Me.Su6.UseVisualStyleBackColor = False
            '
            'Mo6
            '
            Me.Mo6.BackColor = Color.White
            Me.Mo6.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Mo6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Mo6.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Mo6.FlatStyle = FlatStyle.Flat
            Me.Mo6.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Mo6.Location = New Point(42, 235)
            Me.Mo6.Name = "Mo6"
            Me.Mo6.Size = New Size(34, 26)
            Me.Mo6.TabIndex = 10
            Me.Mo6.UseVisualStyleBackColor = False
            '
            'Tu6
            '
            Me.Tu6.BackColor = Color.White
            Me.Tu6.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Tu6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Tu6.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Tu6.FlatStyle = FlatStyle.Flat
            Me.Tu6.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Tu6.Location = New Point(82, 235)
            Me.Tu6.Name = "Tu6"
            Me.Tu6.Size = New Size(34, 26)
            Me.Tu6.TabIndex = 11
            Me.Tu6.UseVisualStyleBackColor = False
            '
            'We6
            '
            Me.We6.BackColor = Color.White
            Me.We6.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.We6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.We6.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.We6.FlatStyle = FlatStyle.Flat
            Me.We6.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.We6.Location = New Point(122, 235)
            Me.We6.Name = "We6"
            Me.We6.Size = New Size(34, 26)
            Me.We6.TabIndex = 12
            Me.We6.UseVisualStyleBackColor = False
            '
            'Th6
            '
            Me.Th6.BackColor = Color.White
            Me.Th6.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Th6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Th6.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Th6.FlatStyle = FlatStyle.Flat
            Me.Th6.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Th6.Location = New Point(162, 235)
            Me.Th6.Name = "Th6"
            Me.Th6.Size = New Size(34, 26)
            Me.Th6.TabIndex = 14
            Me.Th6.UseVisualStyleBackColor = False
            '
            'Fr6
            '
            Me.Fr6.BackColor = Color.White
            Me.Fr6.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Fr6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Fr6.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Fr6.FlatStyle = FlatStyle.Flat
            Me.Fr6.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Fr6.Location = New Point(202, 235)
            Me.Fr6.Name = "Fr6"
            Me.Fr6.Size = New Size(34, 26)
            Me.Fr6.TabIndex = 14
            Me.Fr6.UseVisualStyleBackColor = False
            '
            'Sa6
            '
            Me.Sa6.BackColor = Color.White
            Me.Sa6.FlatAppearance.BorderColor = Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
            Me.Sa6.FlatAppearance.MouseDownBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(220, Byte), Integer))
            Me.Sa6.FlatAppearance.MouseOverBackColor = Color.Silver
            Me.Sa6.FlatStyle = FlatStyle.Flat
            Me.Sa6.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Sa6.Location = New Point(242, 235)
            Me.Sa6.Name = "Sa6"
            Me.Sa6.Size = New Size(34, 26)
            Me.Sa6.TabIndex = 15
            Me.Sa6.UseVisualStyleBackColor = False
            '
            'lblWeeksBackground
            '
            Me.lblWeeksBackground.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                Or AnchorStyles.Right), AnchorStyles)
            Me.lblWeeksBackground.BackColor = Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.lblWeeksBackground.Font = New Font("Segoe UI", 8.25!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.lblWeeksBackground.ForeColor = Color.White
            Me.lblWeeksBackground.Location = New Point(-3, 51)
            Me.lblWeeksBackground.Name = "lblWeeksBackground"
            Me.lblWeeksBackground.Size = New Size(281, 21)
            Me.lblWeeksBackground.TabIndex = 20
            Me.lblWeeksBackground.TextAlign = ContentAlignment.MiddleCenter
            '
            'lblDate
            '
            Me.lblDate.BackColor = Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.lblDate.FontSize = MetroLabelSize.Tall
            Me.lblDate.FontWeight = MetroLabelWeight.Bold
            Me.lblDate.ForeColor = Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.lblDate.Location = New Point(0, 0)
            Me.lblDate.Name = "lblDate"
            Me.lblDate.Size = New Size(278, 51)
            Me.lblDate.TabIndex = 21
            Me.lblDate.Text = "MONTH_YEAR"
            Me.lblDate.TextAlign = ContentAlignment.MiddleCenter
            Me.lblDate.UseCustomBackColor = True
            Me.lblDate.UseCustomForeColor = True
            '
            'Sun
            '
            Me.Sun.BackColor = Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.Sun.FontSize = MetroLabelSize.Small
            Me.Sun.FontWeight = MetroLabelWeight.Regular
            Me.Sun.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Sun.Location = New Point(6, 51)
            Me.Sun.Name = "Sun"
            Me.Sun.Size = New Size(30, 21)
            Me.Sun.TabIndex = 22
            Me.Sun.Text = "Su"
            Me.Sun.TextAlign = ContentAlignment.MiddleCenter
            Me.Sun.UseCustomBackColor = True
            Me.Sun.UseCustomForeColor = True
            '
            'Mon
            '
            Me.Mon.BackColor = Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.Mon.FontSize = MetroLabelSize.Small
            Me.Mon.FontWeight = MetroLabelWeight.Regular
            Me.Mon.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Mon.Location = New Point(42, 51)
            Me.Mon.Name = "Mon"
            Me.Mon.Size = New Size(34, 21)
            Me.Mon.TabIndex = 23
            Me.Mon.Text = "Mo"
            Me.Mon.TextAlign = ContentAlignment.MiddleCenter
            Me.Mon.UseCustomBackColor = True
            Me.Mon.UseCustomForeColor = True
            '
            'Tue
            '
            Me.Tue.BackColor = Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.Tue.FontSize = MetroLabelSize.Small
            Me.Tue.FontWeight = MetroLabelWeight.Regular
            Me.Tue.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Tue.Location = New Point(82, 51)
            Me.Tue.Name = "Tue"
            Me.Tue.Size = New Size(34, 21)
            Me.Tue.TabIndex = 24
            Me.Tue.Text = "Tu"
            Me.Tue.TextAlign = ContentAlignment.MiddleCenter
            Me.Tue.UseCustomBackColor = True
            Me.Tue.UseCustomForeColor = True
            '
            'Wed
            '
            Me.Wed.BackColor = Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.Wed.FontSize = MetroLabelSize.Small
            Me.Wed.FontWeight = MetroLabelWeight.Regular
            Me.Wed.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Wed.Location = New Point(122, 51)
            Me.Wed.Name = "Wed"
            Me.Wed.Size = New Size(34, 21)
            Me.Wed.TabIndex = 25
            Me.Wed.Text = "We"
            Me.Wed.TextAlign = ContentAlignment.MiddleCenter
            Me.Wed.UseCustomBackColor = True
            Me.Wed.UseCustomForeColor = True
            '
            'Thu
            '
            Me.Thu.BackColor = Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.Thu.FontSize = MetroLabelSize.Small
            Me.Thu.FontWeight = MetroLabelWeight.Regular
            Me.Thu.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Thu.Location = New Point(162, 51)
            Me.Thu.Name = "Thu"
            Me.Thu.Size = New Size(34, 21)
            Me.Thu.TabIndex = 26
            Me.Thu.Text = "Th"
            Me.Thu.TextAlign = ContentAlignment.MiddleCenter
            Me.Thu.UseCustomBackColor = True
            Me.Thu.UseCustomForeColor = True
            '
            'Fri
            '
            Me.Fri.BackColor = Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.Fri.FontSize = MetroLabelSize.Small
            Me.Fri.FontWeight = MetroLabelWeight.Regular
            Me.Fri.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Fri.Location = New Point(202, 51)
            Me.Fri.Name = "Fri"
            Me.Fri.Size = New Size(34, 21)
            Me.Fri.TabIndex = 27
            Me.Fri.Text = "Fr"
            Me.Fri.TextAlign = ContentAlignment.MiddleCenter
            Me.Fri.UseCustomBackColor = True
            Me.Fri.UseCustomForeColor = True
            '
            'Sat
            '
            Me.Sat.BackColor = Color.FromArgb(CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
            Me.Sat.FontSize = MetroLabelSize.Small
            Me.Sat.FontWeight = MetroLabelWeight.Regular
            Me.Sat.ForeColor = Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Sat.Location = New Point(242, 51)
            Me.Sat.Name = "Sat"
            Me.Sat.Size = New Size(34, 21)
            Me.Sat.TabIndex = 28
            Me.Sat.Text = "Sa"
            Me.Sat.TextAlign = ContentAlignment.MiddleCenter
            Me.Sat.UseCustomBackColor = True
            Me.Sat.UseCustomForeColor = True
            '
            'btnBeforeMonth
            '
            Me.btnBeforeMonth.BackColor = Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.btnBeforeMonth.BackgroundImageLayout = ImageLayout.Stretch
            Me.btnBeforeMonth.FlatAppearance.BorderColor = Color.White
            Me.btnBeforeMonth.FlatAppearance.BorderSize = 0
            Me.btnBeforeMonth.FlatAppearance.CheckedBackColor = Color.White
            Me.btnBeforeMonth.FlatAppearance.MouseDownBackColor = Color.Gray
            Me.btnBeforeMonth.FlatAppearance.MouseOverBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.btnBeforeMonth.FlatStyle = FlatStyle.Flat
            Me.btnBeforeMonth.Font = New Font("Verdana", 20.0!, FontStyle.Bold)
            Me.btnBeforeMonth.Location = New Point(3, 16)
            Me.btnBeforeMonth.Name = "btnBeforeMonth"
            Me.btnBeforeMonth.Size = New Size(20, 20)
            Me.btnBeforeMonth.TabIndex = 17
            Me.btnBeforeMonth.UseVisualStyleBackColor = False
            '
            'btnBeforeYear
            '
            Me.btnBeforeYear.BackColor = Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.btnBeforeYear.BackgroundImageLayout = ImageLayout.Stretch
            Me.btnBeforeYear.FlatAppearance.BorderColor = Color.White
            Me.btnBeforeYear.FlatAppearance.BorderSize = 0
            Me.btnBeforeYear.FlatAppearance.CheckedBackColor = Color.White
            Me.btnBeforeYear.FlatAppearance.MouseDownBackColor = Color.Gray
            Me.btnBeforeYear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.btnBeforeYear.FlatStyle = FlatStyle.Flat
            Me.btnBeforeYear.Font = New Font("Verdana", 7.0!)
            Me.btnBeforeYear.Location = New Point(232, 12)
            Me.btnBeforeYear.Name = "btnBeforeYear"
            Me.btnBeforeYear.Size = New Size(12, 12)
            Me.btnBeforeYear.TabIndex = 18
            Me.btnBeforeYear.TextAlign = ContentAlignment.MiddleLeft
            Me.btnBeforeYear.UseVisualStyleBackColor = False
            '
            'btnNextMonth
            '
            Me.btnNextMonth.Anchor = CType(((AnchorStyles.Top Or AnchorStyles.Left) _
                Or AnchorStyles.Right), AnchorStyles)
            Me.btnNextMonth.BackColor = Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.btnNextMonth.BackgroundImageLayout = ImageLayout.Stretch
            Me.btnNextMonth.FlatAppearance.BorderColor = Color.White
            Me.btnNextMonth.FlatAppearance.BorderSize = 0
            Me.btnNextMonth.FlatAppearance.CheckedBackColor = Color.White
            Me.btnNextMonth.FlatAppearance.MouseDownBackColor = Color.Gray
            Me.btnNextMonth.FlatAppearance.MouseOverBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.btnNextMonth.FlatStyle = FlatStyle.Flat
            Me.btnNextMonth.Font = New Font("Verdana", 20.0!, FontStyle.Bold)
            Me.btnNextMonth.Location = New Point(255, 16)
            Me.btnNextMonth.Name = "btnNextMonth"
            Me.btnNextMonth.Size = New Size(20, 20)
            Me.btnNextMonth.TabIndex = 16
            Me.btnNextMonth.UseVisualStyleBackColor = False
            '
            'btnNextYear
            '
            Me.btnNextYear.BackColor = Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
            Me.btnNextYear.BackgroundImageLayout = ImageLayout.Stretch
            Me.btnNextYear.FlatAppearance.BorderColor = Color.White
            Me.btnNextYear.FlatAppearance.BorderSize = 0
            Me.btnNextYear.FlatAppearance.CheckedBackColor = Color.White
            Me.btnNextYear.FlatAppearance.MouseDownBackColor = Color.Gray
            Me.btnNextYear.FlatAppearance.MouseOverBackColor = Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(210, Byte), Integer))
            Me.btnNextYear.FlatStyle = FlatStyle.Flat
            Me.btnNextYear.Font = New Font("Verdana", 7.0!)
            Me.btnNextYear.Location = New Point(232, 26)
            Me.btnNextYear.Name = "btnNextYear"
            Me.btnNextYear.Size = New Size(12, 12)
            Me.btnNextYear.TabIndex = 18
            Me.btnNextYear.TextAlign = ContentAlignment.MiddleLeft
            Me.btnNextYear.UseVisualStyleBackColor = False
            '
            'tt
            '
            Me.tt.Style = MetroColorStyle.Blue
            Me.tt.StyleManager = Nothing
            Me.tt.Theme = MetroThemeStyle.Light
            '
            'CalendarControl
            '
            Me.AutoScaleMode = AutoScaleMode.None
            Me.BackColor = SystemColors.ControlLightLight
            Me.Controls.Add(Me.Sat)
            Me.Controls.Add(Me.Fri)
            Me.Controls.Add(Me.Thu)
            Me.Controls.Add(Me.Wed)
            Me.Controls.Add(Me.Tue)
            Me.Controls.Add(Me.Mon)
            Me.Controls.Add(Me.Sun)
            Me.Controls.Add(Me.btnBeforeMonth)
            Me.Controls.Add(Me.btnBeforeYear)
            Me.Controls.Add(Me.btnNextMonth)
            Me.Controls.Add(Me.btnNextYear)
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
            Me.Controls.Add(Me.lnkToday)
            Me.Controls.Add(Me.lblWeeksBackground)
            Me.Controls.Add(Me.lblDate)
            Me.Font = New Font("Segoe UI", 9.0!, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New Padding(1)
            Me.Name = "CalendarControl"
            Me.Size = New Size(278, 308)
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents lnkToday As Button
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
        Friend WithEvents btnBeforeYear As Button
        Friend WithEvents btnNextYear As Button
        Friend WithEvents lblWeeksBackground As Label
        Friend WithEvents btnNextMonth As Button
        Friend WithEvents btnBeforeMonth As Button
        Friend WithEvents lblDate As MetroLabel
        Friend WithEvents Sun As MetroLabel
        Friend WithEvents Mon As MetroLabel
        Friend WithEvents Tue As MetroLabel
        Friend WithEvents Wed As MetroLabel
        Friend WithEvents Thu As MetroLabel
        Friend WithEvents Fri As MetroLabel
        Friend WithEvents Sat As MetroLabel
        Friend WithEvents tt As MetroToolTip
    End Class
End Namespace