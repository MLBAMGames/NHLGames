Imports System.Configuration

Public Class ApplicationSettings

    Public Enum Settings
        Version = 1
        DefaultWatchArgs = 2
        VLCPath = 3
        MPCPath = 4
        mpvPath = 5
        LiveStreamerPath = 6
        ServiioPath = 7
        ShowScores = 8
        RefreshIntervalInMin = 9
        ShowAdvancedWatchPanel = 10
        ShowLiveScores = 11
    End Enum

    Public Shared Function Read(Of T)(key As Settings, Optional defaultReturnValue As Object = Nothing) As T
        Try
            Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim settings = configFile.AppSettings.Settings
            Dim result As Object = settings(key.ToString()).Value
            If String.IsNullOrEmpty(result) OrElse IsNothing(result) Then
                Return defaultReturnValue
            End If

            If TypeOf result Is T Then
                result = DirectCast(result, T)
                Return result
            End If

            Dim boolReturn As Boolean
            If Boolean.TryParse(result, boolReturn) Then
                Return CType(result, T)
            End If

            Try
                Return Serialization.DeserializeObject(Of T)(result)
            Catch ex As Exception
                Console.WriteLine("Failed to deserialize setting value of " & key.ToString() & " to type: " & GetType(T).ToString())
                Return defaultReturnValue
            End Try

        Catch e As ConfigurationErrorsException
            Console.WriteLine("Error reading app setting: " & key)
            Return defaultReturnValue
        End Try
    End Function


    Public Shared Sub SetValue(key As Settings, value As String)
        Try
            Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim settings = configFile.AppSettings.Settings
            If IsNothing(settings(key.ToString())) Then
                settings.Add(key.ToString(), value)
            Else
                settings(key.ToString()).Value = value
            End If

            If value.Length > 200 Then
                value = "[Value too large for display]"
            End If
            Console.WriteLine("Status: Setting updated for """ & key.ToString() & """ to """ & value & """")
            configFile.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        Catch e As ConfigurationErrorsException
            Console.WriteLine("Error writing app settings")
        End Try
    End Sub

End Class
