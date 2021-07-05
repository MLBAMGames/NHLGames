Imports System.Windows.Forms

Namespace Controls
    Public Class MetroComboBoxNoMW
        Inherits MetroFramework.Controls.MetroComboBox
        Protected Overrides Sub OnMouseWheel(e As MouseEventArgs)
            CType(e, HandledMouseEventArgs).Handled = True
        End Sub

        Protected Overrides Sub OnSelectedIndexChanged(e As EventArgs)
            MyBase.OnSelectedIndexChanged(e)
            MyBase.OnLostFocus(e)
        End Sub
    End Class
End Namespace
