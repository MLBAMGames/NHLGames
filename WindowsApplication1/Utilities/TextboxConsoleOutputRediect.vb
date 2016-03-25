Imports System.IO
Imports System.Text

Public Class TextboxConsoleOutputRediect


    Public Class TextBoxStreamWriter
        Inherits TextWriter
        Private _output As RichTextBox = Nothing

        Public Sub New(output As RichTextBox)
            _output = output
        End Sub

        Enum OutputType
            Normal = 0
            Status = 1
            [Error] = 2
            CLI = 3

        End Enum
        Public Overrides Sub WriteLine(value As String)

            MyBase.WriteLine(value)

            _output.BeginInvoke(New Action(Function()
                                               Dim startIndex As Integer = -1
                                               Dim length As Integer = -1
                                               Dim type As OutputType = OutputType.Normal
                                               Dim timestamp As String = "[" & DateTime.Now.ToString("HH:mm:ss") & "] "


                                               If value.ToLower().IndexOf("error:") > -1 OrElse value.ToLower().IndexOf("exception:") > -1 Then
                                                   type = OutputType.Error
                                                   startIndex = _output.TextLength
                                                   length = value.IndexOf(":") + 2
                                                   _output.AppendText(vbCr)
                                               ElseIf value.IndexOf("[cli]") > -1 Then
                                                   type = OutputType.CLI
                                                   startIndex = _output.TextLength
                                                   length = 6
                                                   _output.AppendText(vbCr)
                                               ElseIf value.IndexOf(":") > -1 Then
                                                   type = OutputType.Status
                                                   startIndex = _output.TextLength
                                                   length = value.IndexOf(":") + 2
                                                   _output.AppendText(vbCr)
                                               End If

                                               value = timestamp & value
                                               startIndex += timestamp.Length

                                               _output.AppendText(value.ToString() & vbCr)

                                               If startIndex > -1 Then
                                                   _output.Select(startIndex, length)

                                                   If type = OutputType.Error Then
                                                       _output.SelectionColor = Color.Red
                                                   ElseIf type = OutputType.Status
                                                       _output.SelectionColor = Color.Green
                                                   ElseIf type = OutputType.CLI
                                                       _output.SelectionColor = Color.SkyBlue
                                                   End If

                                                   _output.Select(startIndex, length)
                                                   _output.SelectionFont = New Font(_output.Font, FontStyle.Bold)

                                               End If


                                               Return ""
                                           End Function))

        End Sub
        'Public Overrides Sub Write(value As Char)
        '    MyBase.Write(value)

        '    If (value <> vbLf) Then
        '        _output.BeginInvoke(New Action(Function()
        '                                           _output.AppendText(value.ToString())
        '                                       End Function))
        '    End If

        'End Sub

        Public Overrides ReadOnly Property Encoding() As Encoding
            Get
                Return System.Text.Encoding.UTF8
            End Get
        End Property
    End Class




End Class
