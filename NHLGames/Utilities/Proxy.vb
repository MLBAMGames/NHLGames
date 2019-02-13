﻿Imports System.IO
Imports NHLGames.My.Resources

Namespace Utilities
    Public Class Proxy
        Private _proxy As Process
        Private _proxyVersion As Process
        Private const _stringToFind = "[MLBAMProxy] "
        Private const _exeName = "mlbamproxy.exe"
        Public ReadOnly port As String = ApplicationSettings.Read(Of String)(SettingsEnum.ProxyPort, "17070")
        Private ReadOnly _folderPath As String = Path.Combine(Application.StartupPath, "mlbamproxy")

        Private _pathToProxy As String = String.Empty

        Private Sub StartProxy()
            _proxyVersion = New Process() With {
                .StartInfo = New ProcessStartInfo With {
                    .FileName = _pathToProxy,
                    .Arguments = $"-v",
                    .UseShellExecute = False,
                    .RedirectStandardOutput = True,
                    .CreateNoWindow = True
                },
                .EnableRaisingEvents = True
            }

            Try
                _proxyVersion.Start()

                While (_proxyVersion.StandardOutput.EndOfStream = False)
                    Console.WriteLine(English.msgProxyStarting, _proxyVersion.StandardOutput.ReadLine())
                End While
            Catch ex As Exception
                Console.WriteLine(English.errorGeneral, $"Starting proxy", ex.Message)
                Return
            End Try

            _proxy = New Process() With {
                .StartInfo = New ProcessStartInfo With {
                    .FileName = _pathToProxy,
                    .Arguments = $"-p {port} -d {NHLGamesMetro.HostName} -s {NHLGamesMetro.DomainName}",
                    .UseShellExecute = False,
                    .RedirectStandardOutput = True,
                    .CreateNoWindow = True
                },
                .EnableRaisingEvents = True
            }

            InvokeElement.SetFormStatusLabel(NHLGamesMetro.RmText.GetString("msgProxyGettingReady"))

            If Not IsProxyFileFound() Then
                Console.WriteLine(English.errorMitmProxyNotFound)
                Return
            End If

            Try
                _proxy.Start()

                While (_proxy.StandardOutput.EndOfStream = False)
                    Dim line = _proxy.StandardOutput.ReadLine()
                    Dim indexAfterMatch = line.IndexOf(_stringToFind)
                    Dim log = If(indexAfterMatch <> -1, line.Substring(indexAfterMatch + _stringToFind.Length), Nothing)
                    If log <> Nothing Then Console.WriteLine("MLBAMProxy: " & log)
                    If line.ToLower().Contains("proxy server listening") Then
                        NHLGamesMetro.FormInstance.ProxyListening = Task.Run(Function()
                                                                                 Return True
                                                                             End Function)
                    End If
                End While

            Catch ex As Exception
                Console.WriteLine(English.errorGeneral, $"Starting proxy", ex.Message)
            End Try
        End Sub

        Public Sub New()
            SetEnvironmentVariableForMpv()
            SetPath()

            Dim taskLaunchProxy = New Task(Sub()
                                               StartProxy()
                                           End Sub)
            taskLaunchProxy.Start()

            ' For proxy debug purpose, uncomment below, comment above

            'NHLGamesMetro.FormInstance.ProxyListening = Task.Run(Function()
            'Return True
            'End Function)
        End Sub

        Private Sub SetPath()
            _pathToProxy = $"{_folderPath}\{If (Environment.Is64BitOperatingSystem, "x64", "x86")}\{_exeName}"
        End Sub

        Public Function IsProxyFileFound() As Boolean
            Return File.Exists(_pathToProxy)
        End Function

        Public Shared Sub StopProxy()
            Dim psi As ProcessStartInfo = New ProcessStartInfo With {
                .Arguments = $"/im {_exeName} /f",
                .FileName = "taskkill",
                .UseShellExecute = False
            }
            Dim p As Process = New Process With {
                .StartInfo = psi
            }
            p.Start()
        End Sub

        Public Shared Async Function WaitToBeReady() As Task(Of Boolean)
            If Await Ready() Then Return True
            InvokeElement.SetFormStatusLabel(NHLGamesMetro.RmText.GetString("msgProxyGettingReady"))

            While Not Await Ready()
                Await Task.Delay(200)
            End While

            InvokeElement.SetFormStatusLabel(String.Format(NHLGamesMetro.RmText.GetString("msgGamesFound"),
                                                               NHLGamesMetro.GamesDict.Values.Count.ToString()))
            Return True
        End Function

        Public Shared Async Function Ready() As Task(Of Boolean)
            Return Not (NHLGamesMetro.FormInstance.ProxyListening Is Nothing OrElse Not Await NHLGamesMetro.FormInstance.ProxyListening)
        End Function

        Public Sub SetEnvironmentVariableForMpv()
            Environment.SetEnvironmentVariable("http_proxy", $"http://127.0.0.1:{port}/", EnvironmentVariableTarget.Process)
        End Sub

    End Class
End Namespace