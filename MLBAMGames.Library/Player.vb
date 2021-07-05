Imports System.IO
Imports System.Threading
Imports MetroFramework.Controls
Imports MLBAMGames.Library.My.Resources
Imports MLBAMGames.Library.Objects

Namespace Utilities
    Public Class Player
        Private Const Http = "http"

        Public Shared Sub Watch(args As GameWatchArguments)
            Dim form As IMLBAMForm = Instance.Form

            If args.PlayerPath.Equals(String.Empty) OrElse args.StreamerPath.Equals(String.Empty) Then
                If form.txtStreamerPath.Text.Equals(String.Empty) Then
                    Console.WriteLine(English.errorStreamerExe)
                ElseIf _
                    form.txtMpvPath.Text.Equals(String.Empty) AndAlso form.txtVLCPath.Text.Equals(String.Empty) AndAlso
                    form.txtMPCPath.Text.Equals(String.Empty) Then
                    Console.WriteLine(English.errorMpvExe)
                Else
                    Console.WriteLine(English.errorPlayerPathEmpty)
                End If
                Return
            End If

            Dim taskLaunchingStream = New Task(Async Sub()
                                                   Parameters.StreamStarted = True
                                                   Parameters.SpnStreamingValue = 1
                                                   Thread.Sleep(100)
                                                   If Not Parameters.IsHostsRedirectionSet Then Await Proxy.WaitToBeReady()
                                                   LaunchingStream(args)
                                                   Thread.Sleep(100)
                                                   Parameters.StreamStarted = False
                                               End Sub)

            taskLaunchingStream.Start()
        End Sub

        Private Shared Sub LaunchingStream(args As GameWatchArguments)
            Dim lstValidLines As _
                    New List(Of String) _
                    From {"found matching plugin stream", "available streams", "opening stream", "starting player"}
            Dim lstInvalidLines As New List(Of String) From {"could not open stream", "failed to read"}
            Dim progressStep As Integer = (Parameters.SpnLoadingMaxValue) / (lstValidLines.Count + 1)


            Console.WriteLine(English.msgStreaming, args.GameTitle, args.Stream.Network, args.PlayerType.ToString())
            Console.WriteLine(English.msgStartingStreamer, args.ToString(True))

            Dim procStreaming = New Process() With {.StartInfo =
                    New ProcessStartInfo With {
                    .FileName = args.StreamerPath,
                    .Arguments = args.ToString(),
                    .UseShellExecute = False,
                    .RedirectStandardOutput = True,
                    .CreateNoWindow = Not (Instance.Form.tgOutput.Checked And args.Stream.Game IsNot Nothing)}
                    }
            procStreaming.EnableRaisingEvents = True

            Dim taskPlayerWatcher = New Task(Sub()
                                                 PlayerWatcher(args)
                                             End Sub)

            Try
                procStreaming.Start()

                If Instance.Form.tgOutput.Checked Then Return

                While (procStreaming.StandardOutput.EndOfStream = False)
                    Dim line = procStreaming.StandardOutput.ReadLine().ToLower()
                    If line.Contains(Http) Then
                        line = line.Substring(0, line.IndexOf(Http, StringComparison.Ordinal)) &
                               English.msgCensoredStream
                    End If
                    If lstValidLines.Any(Function(x) line.Contains(x)) Then
                        Parameters.SpnStreamingValue += progressStep
                    End If
                    If line.Contains(lstValidLines(3)) Then
                        taskPlayerWatcher.Start()
                    End If
                    Console.WriteLine(line)
                    If lstInvalidLines.Any(Function(x) line.Contains(x)) Then
                        Console.WriteLine(English.errorStreamFailedCantRead)
                        Throw New IOException()
                    End If
                    If line.Contains("player closed") Then Throw New IOException()
                    Thread.Sleep(50) 'to let some time for the progress bar to move
                End While
            Catch ex As IOException
            Catch ex As Exception
                Console.WriteLine(English.errorGeneral, $"Starting stream", ex.Message)
            Finally
                Parameters.StreamStarted = False
            End Try
        End Sub

        Private Shared Sub PlayerWatcher(args As GameWatchArguments)
            Dim processes As Process() = Process.GetProcesses()
            Dim i = 0
            While Not _
            processes.Any(Function(p) p.ProcessName.ToLower().Contains(args.PlayerType.ToString().ToLower()) _
            OrElse Parameters.StreamStarted = False _
            OrElse i = 30)
                processes = Process.GetProcesses()
                Thread.Sleep(500)
                i += 1
            End While
            Parameters.SpnStreamingValue = Parameters.SpnStreamingMaxValue - 1
            Thread.Sleep(1000)
            Parameters.StreamStarted = False
        End Sub

        Public Shared Function GetPlayerType(form As IMLBAMForm) As PlayerTypeEnum
            If form.rbMPV.Checked Then
                Return PlayerTypeEnum.Mpv
            ElseIf form.rbMPC.Checked Then
                Return PlayerTypeEnum.Mpc
            ElseIf form.rbVLC.Checked Then
                Return PlayerTypeEnum.Vlc
            Else
                Return PlayerTypeEnum.None
            End If
        End Function

        Private Shared Function GetPlayerPath(form As IMLBAMForm) As String
            If form.rbMPV.Checked Then
                Return form.txtMpvPath.Text
            ElseIf form.rbMPC.Checked Then
                Return form.txtMPCPath.Text
            ElseIf form.rbVLC.Checked Then
                Return form.txtVLCPath.Text
            Else
                Return String.Empty
            End If
        End Function

        Private Shared Function GetCdn(tgAlternateCdn As MetroToggle) As CdnTypeEnum
            Return If(tgAlternateCdn.Checked, CdnTypeEnum.L3C, CdnTypeEnum.Akc)
        End Function

        Public Shared Function RenewArgs(Optional forceSet As Boolean = False) As GameWatchArguments

            Dim form As IMLBAMForm = Instance.Form

            If Parameters.UILoaded OrElse forceSet Then
                Dim watchArgs As New GameWatchArguments With {
                    .Is60Fps = form.cbStreamQuality.SelectedIndex = 0,
                    .Quality = form.cbStreamQuality.SelectedIndex,
                    .StreamLiveRewind = form.tbLiveRewind.Value * 5,
                    .StreamLiveReplay = form.cbLiveReplay.SelectedIndex,
                    .StreamerPath = form.txtStreamerPath.Text,
                    .StreamerType = GetStreamerType(form.txtStreamerPath.Text),
                    .PlayerType = GetPlayerType(form),
                    .PlayerPath = GetPlayerPath(form),
                    .UseCustomPlayerArgs = form.tgPlayer.Checked,
                    .CustomPlayerArgs = form.txtPlayerArgs.Text,
                    .UseCustomStreamerArgs = form.tgStreamer.Checked,
                    .CustomStreamerArgs = form.txtStreamerArgs.Text,
                    .Cdn = GetCdn(form.tgAlternateCdn),
                    .UseOutputArgs = form.tgOutput.Checked,
                    .PlayerOutputPath = form.txtOutputArgs.Text
                }

                Instance.Form.SetSetting("DefaultWatchArgs", Serialization.SerializeObject(watchArgs))

                Return watchArgs
            End If

            Return New GameWatchArguments()
        End Function

        Private Shared Function GetStreamerType(streamerPath As String) As StreamerTypeEnum
            Dim selectedStreamerExe = Path.GetFileNameWithoutExtension(streamerPath).ToLower()
            If selectedStreamerExe = StreamerTypeEnum.LiveStreamer.ToString().ToLower() Then
                Return StreamerTypeEnum.LiveStreamer
            ElseIf selectedStreamerExe = StreamerTypeEnum.StreamLink.ToString().ToLower() Then
                Return StreamerTypeEnum.StreamLink
            Else
                Return StreamerTypeEnum.None
            End If
        End Function
    End Class
End Namespace

