Imports System.Runtime.InteropServices
Imports System.Threading

Namespace Utilities
    Public Class NativeMethods
        <DllImport("user32.dll")>
        Private Shared Function ReleaseCapture() As Boolean
        End Function

        <DllImport("user32.dll")>
        Private Shared Function SendMessage(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) _
            As IntPtr
        End Function

        <DllImport("user32.dll")>
        Private Shared Function SetForegroundWindow(point As IntPtr) As Boolean
        End Function

        <DllImport("user32.dll")>
        Private Shared Function GetForegroundWindow() As IntPtr
        End Function

        <DllImport("user32.dll")>
        Private Shared Function ShowWindow(hWnd As IntPtr, nCmdShow As Integer) As Boolean
        End Function

        <DllImport("user32.dll")>
        Private Shared Function IsIconic(hWnd As IntPtr) As Boolean
        End Function

        <DllImport("user32.dll")>
        Private Shared Sub keybd_event(bVk As Byte, bScan As Byte, dwFlags As UInteger, dwExtraInfo As UIntPtr)
        End Sub

        Public Shared Function ReleaseCaptureOfForm() As Boolean
            Return ReleaseCapture()
        End Function

        Public Shared Function SendMessageToHandle(hWnd As IntPtr, msg As Integer, wParam As IntPtr, lParam As IntPtr) _
            As IntPtr
            Return SendMessage(hWnd, msg, wParam, lParam)
        End Function

        Public Shared Sub PressKey(keyCode As Byte)
            keybd_event(keyCode, &H45, &H1, 0)
            keybd_event(keyCode, &H45, &H2, 0)
        End Sub

        Public Shared Function SetForegroundWindowFromHandle(hWnd As IntPtr) As Boolean
            If IsIconic(hWnd) Then
                ShowWindow(hWnd, ShowWindowCode.SW_RESTORE)
                Thread.Sleep(50)
            End If
            Return SetForegroundWindow(hWnd)
        End Function

        Public Shared Function SetBackgroundWindowFromHandle(hWnd As IntPtr) As Boolean
            Dim result = False
            If Not IsIconic(hWnd) Then
                result = ShowWindow(hWnd, ShowWindowCode.SW_MINIMIZE)
            End If
            Return result
        End Function

        Public Shared Function GetForegroundWindowFromHandle() As IntPtr
            Return GetForegroundWindow()
        End Function
    End Class
End Namespace