﻿Namespace Controls
    <System.ComponentModel.DesignerCategory("Code")>
    Public Class BorderPanel
        Inherits Panel
        Public Sub New()
            SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.DoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
            BorderColour = Color.Black
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
        End Sub

        Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
            MyBase.OnPaintBackground(e)
            e.Graphics.DrawRectangle(New Pen(BorderColour, 2), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1)
        End Sub

        Public Property BorderColour As Color

    End Class
End Namespace
