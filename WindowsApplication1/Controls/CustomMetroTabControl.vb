Imports MetroFramework.Controls

Public Class CustomMetroTabControl
    Inherits MetroTabControl


    Protected Overrides Sub OnHandleCreated(e As EventArgs)
        MyBase.OnHandleCreated(e)
        ' Send TCM_SETMINTABWIDTH
        SendMessage(Me.Handle, &H1300 + 49, IntPtr.Zero, New IntPtr(10))
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wp As IntPtr, lp As IntPtr) As IntPtr
    End Function

End Class
