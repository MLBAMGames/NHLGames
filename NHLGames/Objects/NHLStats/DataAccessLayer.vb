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
        Function ExecuteAPICall(ByVal apiUrl As String) As JObject
            Dim client = New System.Net.Http.HttpClient()
            Dim stopwatch As System.Diagnostics.Stopwatch = New System.Diagnostics.Stopwatch()
            Dim response = client.GetAsync(apiUrl).Result
            Dim responseSuccessful As Boolean = response.IsSuccessStatusCode

            While (Not responseSuccessful) AndAlso (response.StatusCode <> HttpStatusCode.NotFound)
                response = client.GetAsync(apiUrl).Result
                responseSuccessful = response.IsSuccessStatusCode
            End While

            Dim stringResult = response.Content.ReadAsStringAsync().Result
            Dim json = JObject.Parse(stringResult)
            Return json
        End Function
    End Module
End Namespace
