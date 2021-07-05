Imports System.Drawing
Imports System.Windows.Forms

Namespace Controls
    Public Class BorderPanel
        Inherits Panel
        Implements IDisposable

        Public Sub New()
            BorderColour = Color.FromArgb(255, 60, 60, 60)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
        End Sub

        Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
            MyBase.OnPaintBackground(e)
            e.Graphics.DrawRectangle(New Pen(BorderColour, 2), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1)
        End Sub

        Public Property BorderColour As Color

        Protected Overrides Sub Dispose(disposing As Boolean)
            Controls.Clear()
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
