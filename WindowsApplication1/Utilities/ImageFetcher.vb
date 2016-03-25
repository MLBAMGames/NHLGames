Imports System.IO

Public Class ImageFetcher

    Public Shared Function GetEmbeddedImage(fileName As String) As Image
        Dim myAssembly As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim myStream As Stream = myAssembly.GetManifestResourceStream("NHLGames." & fileName)
        If myStream IsNot Nothing Then
            Return Image.FromStream(myStream)
        Else
            Return Nothing
        End If

    End Function

End Class
