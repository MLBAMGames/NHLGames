Imports System.ComponentModel


Public Class BufferedFlowPanel
    Inherits FlowLayoutPanel

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
