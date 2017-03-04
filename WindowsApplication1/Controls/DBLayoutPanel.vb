Imports System.ComponentModel


''' <summary>
''' Normal Table Layout panel flickers too much, need to override and allow for proper buffering
''' </summary>
Public Class DBLayoutPanel
    Inherits TableLayoutPanel

    Public Sub New()
        InitializeComponent()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
    End Sub

    Public Sub New(container As IContainer)
        container.Add(Me)
        InitializeComponent()
        SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.UserPaint, True)
    End Sub

End Class
