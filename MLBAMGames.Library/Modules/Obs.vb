Imports System.Threading
Imports System.Windows.Forms
Imports MLBAMGames.Library.My.Resources
Imports MLBAMGames.Library.Utilities

Namespace Objects.Modules
    Public Class Obs
        Implements IAdModule
        Public ReadOnly HotkeyAd As Hotkey = New Hotkey()
        Public ReadOnly HotkeyGame As Hotkey = New Hotkey()
        Private _obsHandle As IntPtr?
        Private _obsIdProcess As Integer

        Private Function IsHotkeyAdSet() As Boolean
            Return HotkeyAd.Key <> vbNullChar
        End Function

        Private Function IsHotkeyAdHasSpecialKeys() As Boolean
            Return HotkeyAd.Ctrl OrElse HotkeyAd.Alt OrElse HotkeyAd.Shift
        End Function

        Private Function IsHotkeyGameSet() As Boolean
            Return HotkeyGame.Key <> vbNullChar
        End Function

        Private Function IsHotkeyGameHasSpecialKeys() As Boolean
            Return HotkeyGame.Ctrl OrElse HotkeyGame.Alt OrElse HotkeyGame.Shift
        End Function

        Public Sub New()
        End Sub

        Public Sub Initialize() Implements IAdModule.Initialize
        End Sub

        Public Sub DisposeIt() Implements IAdModule.DisposeIt
        End Sub

        Public ReadOnly Property Title As AdModulesEnum = AdModulesEnum.Obs Implements IAdModule.Title

        Public Sub AdEnded() Implements IAdModule.AdEnded
            Switching(HotkeyGame, IsHotkeyGameSet, IsHotkeyGameHasSpecialKeys, Lang.EnglishRmText.GetString("msgObsGameWord"))
        End Sub

        Public Sub AdStarted() Implements IAdModule.AdStarted
            Switching(HotkeyAd, IsHotkeyAdSet, IsHotkeyAdHasSpecialKeys, Lang.EnglishRmText.GetString("msgObsAdWord"))
        End Sub
        Public Sub AdPlaying() Implements IAdModule.AdPlaying

        End Sub

        Private Sub Switching(hotkey As Hotkey, isHotkeySet As Boolean, specialKey As Boolean, scene As String)
            If Not isHotkeySet Then
                Console.WriteLine(Lang.EnglishRmText.GetString("msgObsHotkeyNotSet"), scene)
                Return
            End If

            Dim toSend = String.Empty

            If hotkey.Ctrl Then
                toSend &= "^"
            End If
            If hotkey.Alt Then
                toSend &= "%"
            End If
            If hotkey.Shift Then
                toSend &= "+"
            End If

            If specialKey Then
                toSend &= "{" & hotkey.Key & "}"
            Else
                toSend &= hotkey.Key
            End If

            If Not String.IsNullOrEmpty(toSend) Then
                If _obsHandle Is Nothing Then
                    HookObs()
                Else
                    Try
                        Process.GetProcessById(_obsIdProcess)
                    Catch ex As Exception
                        InvokeElement.ModuleObsOff()
                    End Try
                End If

                Dim curr? = NativeMethods.GetForegroundWindowFromHandle()
                Console.WriteLine(English.msgObsChangingScene, scene)
                NativeMethods.SetForegroundWindowFromHandle(_obsHandle)
                Thread.Sleep(50)
                SendKeys.SendWait(toSend)
                NativeMethods.SetBackgroundWindowFromHandle(_obsHandle)
                NativeMethods.SetForegroundWindowFromHandle(curr)
            End If
        End Sub

        Private Sub HookObs()
            Dim processNames = New List(Of String) From {"obs32", "obs64"}
            Dim processes As Process()
            For i = 0 To processNames.Count - 1
                processes = Process.GetProcessesByName(processNames(i))
                If processes.Length <> 0 Then
                    _obsHandle = processes(0).MainWindowHandle
                    _obsIdProcess = processes(0).Id
                End If
            Next
        End Sub
    End Class
End Namespace