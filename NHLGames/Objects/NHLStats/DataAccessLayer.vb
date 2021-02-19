Imports System
Imports System.Collections.Generic
Imports System.Text
Imports Newtonsoft.Json
Imports System.Net.Http
Imports Newtonsoft.Json.Linq
Imports System.Linq
Imports System.Net

Namespace NHLStats
    Module DataAccessLayer
        Function ExecuteAPICall(Of T)(ByVal apiUrl As String) As T
            Dim client = New HttpClient()
            Dim stopwatch As Stopwatch = New System.Diagnostics.Stopwatch()
            Dim response = client.GetAsync(apiUrl).Result
            Dim responseSuccessful As Boolean = response.IsSuccessStatusCode

            While (Not responseSuccessful) AndAlso (response.StatusCode <> HttpStatusCode.NotFound)
                response = client.GetAsync(apiUrl).Result
                responseSuccessful = response.IsSuccessStatusCode
            End While

            Dim stringResult = response.Content.ReadAsStringAsync().Result
            Return JsonConvert.DeserializeObject(Of T)(stringResult)
        End Function
    End Module
End Namespace
