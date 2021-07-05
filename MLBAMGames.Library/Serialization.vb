Imports System.IO
Imports System.Xml.Serialization

Namespace Utilities
    Public Class Serialization
        Public Shared Function SerializeObject(Of T)(toSerialize As T) As String
            Dim xmlSerializer As New XmlSerializer(toSerialize.[GetType]())
            Using textWriter As New StringWriter()
                xmlSerializer.Serialize(textWriter, toSerialize)
                Return textWriter.ToString()
            End Using
        End Function

        Public Shared Function DeserializeObject(Of T)(value As String) As T
            Dim xmlSerializer As New XmlSerializer(GetType(T))
            Dim returnValue As T = xmlSerializer.Deserialize(New StringReader(value))
            Return returnValue
        End Function
    End Class
End Namespace
