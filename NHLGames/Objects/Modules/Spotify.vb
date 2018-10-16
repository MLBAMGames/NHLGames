Imports System.IO
Imports System.Threading
Imports NHLGames.My.Resources
Imports NHLGames.Utilities

Namespace Objects.Modules
    Public Class Spotify
        Inherits AdDetection
        Implements IAdModule
        
        Private Const _numberOfSamples As Integer = 3

        Private ReadOnly _connectSleep As TimeSpan = TimeSpan.FromSeconds(5)
        Private _initialized As Boolean
        Private _stopIt As Boolean = False

        Private _spotifyId As Integer = 0
        Private Const KeyVkNextSong = 176
        Private Const KeyVkPlayPause = 179
        Private Const KeyNextSong = "^{RIGHT}"
        Private Const KeyTab = "{TAB}"
        Private Const KeyPlayPause = " "

        Private ReadOnly _spotifyPossiblePaths() = New String() {
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),"spotify\\spotify.exe"),
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),"Microsoft\\WindowsApps\\Spotify.exe")
        }

        Private Shared _spotifyPath As String

        Public Property ForceToOpen As Boolean
        Public Property PlayNextSong As Boolean
        Public Property AnyMediaPlayer As Boolean

        Public ReadOnly Property Title As AdModulesEnum = AdModulesEnum.Spotify Implements IAdModule.Title

        Public Sub New()
            For Each path As String In _spotifyPossiblePaths
                If File.Exists(path) Then
                    _spotifyPath = path
                End If
            Next
        End Sub

        Private Function SpotifyIsRunning() As Boolean
            Return Process.GetProcessesByName("spotify").Length > 0
        End Function

        Private Sub RunSpotify()
            Process.Start(_spotifyPath)
        End Sub

        Private Function SpotifyIsInstalled() As Boolean
            Return File.Exists(_spotifyPath)
        End Function

        Private Function IsSpotifyPlaying As Boolean
            Dim spotifyAudioSession = GetAudioSession(_spotifyId)
            Return GetCurrentVolume(spotifyAudioSession) > 0.0
        End Function

        Private Sub NextSong()
            If Not AnyMediaPlayer Then
                SendActionKey(KeyNextSong)
            Else
                NativeMethods.PressKey(KeyVkNextSong)
                Thread.Sleep(100)
            End If
        End Sub

        Private Sub SendActionKey(Key As String)
            Dim curr? = NativeMethods.GetForegroundWindowFromHandle()
            Dim spotifyHandle? = Process.GetProcessById(_spotifyId).MainWindowHandle
            NativeMethods.SetForegroundWindowFromHandle(spotifyHandle)
            Thread.Sleep(100)
            SendKeys.SendWait(KeyTab) 'to unfocus any current field on spotify
            SendKeys.SendWait(Key)
            NativeMethods.SetBackgroundWindowFromHandle(spotifyHandle)
            NativeMethods.SetForegroundWindowFromHandle(curr)
        End Sub

        Private Sub Play()
            If IsSpotifyPlaying() Then Return
            If Not AnyMediaPlayer Then
                SendActionKey(KeyPlayPause)
            Else
                NativeMethods.PressKey(KeyVkPlayPause)
            End If
        End Sub

        Private Sub Pause()
            If Not IsSpotifyPlaying() Then Return
            If Not AnyMediaPlayer Then
                SendActionKey(KeyPlayPause)
            Else
                NativeMethods.PressKey(KeyVkPlayPause)
            End If
        End Sub

        Private Function IsItInitialized() As Boolean
            If Not AnyMediaPlayer Then
                Try
                    Process.GetProcessById(_spotifyId)
                Catch ex As Exception
                    InvokeElement.ModuleSpotifyOff()
                    _initialized = False
                End Try
            End If
            Return _initialized
        End Function

        Public Sub AdEnded() Implements IAdModule.AdEnded
            If Not IsItInitialized() Then Return
            If PlayNextSong Then NextSong()
            Pause()
        End Sub

        Public Sub AdStarted() Implements IAdModule.AdStarted
            If Not IsItInitialized() Then Return
            Play()
        End Sub

        Public Sub Initialize() Implements IAdModule.Initialize
            If AnyMediaPlayer Then
                _initialized = True
                Return
            End If
            If Not SpotifyIsInstalled() Then
                _stopIt = True
                InvokeElement.ModuleSpotifyOff()
                Console.WriteLine(English.msgSpotifyIsntInstalled)
            End If

            ConnectLoop()

            If _spotifyId = 0 AndAlso Not _stopIt Then
                InvokeElement.ModuleSpotifyOff()
                Console.WriteLine(English.msgSpotifyNotConnected)
            End If

            _initialized = True
        End Sub

        Public Sub Dispose() Implements IAdModule.Dispose
            _stopIt = True
        End Sub

        Private Sub ConnectLoop()
            While Not _stopIt
                Try
                    If ConnectInternal() Then Return
                Catch ex As Exception
                    _stopIt = True
                    InvokeElement.ModuleSpotifyOff()
                    Console.WriteLine(English.msgSpotifyException, ex.Message)
                End Try
                Task.Delay(_connectSleep)
            End While
        End Sub

        Private Function ConnectInternal() As Boolean
            If Not SpotifyIsRunning() Then
                If ForceToOpen Then
                    Console.WriteLine(English.msgSpotifyNotRunning)
                    Try
                        RunSpotify()
                    Catch ex As Exception
                        Console.WriteLine(English.msgSpotifyCantStart, ex.Message)
                    End Try
                    ForceToOpen = False
                End If
                Return False
            End If
            Dim proc = Process.GetProcessesByName("spotify")

            For i = 0 To proc.Count() - 1
                If proc(i).MainWindowTitle = "" Then Continue For
                _spotifyId = proc(i).Id
                Return True
            Next

            Return False
        End Function

    End Class

End Namespace