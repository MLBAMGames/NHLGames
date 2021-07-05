Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports MLBAMGames.Library.My.Resources

Namespace Utilities
    Public Class ConsoleRedirectStreamWriter
        Inherits TextWriter
        Private ReadOnly _output As RichTextBox = Nothing

        Public Sub New(output As RichTextBox)
            _output = output
        End Sub

        Public Overrides ReadOnly Property Encoding As Encoding
            Get
                Return Encoding.UTF8
            End Get
        End Property

        Public Overrides Sub WriteLine(value As String)
            Dim lastError As String = Nothing
            Dim regex As New Regex($"\[cli\](\[(.*?)\])?")
            MyBase.WriteLine(value)

            _output.BeginInvoke(
                New Action(
                    Function()
                        Dim startIndex As Integer = -1
                        Dim length As Integer = -1
                        Dim type = OutputTypeEnum.Normal
                        Dim timestamp As String = String.Format(English.msgDateTimeNow, Now.ToString("HH:mm:ss"))

                        If value.ToLower().IndexOf(English.errorDetection, StringComparison.Ordinal) = 0 OrElse
                           value.ToLower().IndexOf(English.errorExceptionDetection, StringComparison.Ordinal) = 0 Then
                            type = OutputTypeEnum.Error
                            startIndex = _output.TextLength
                            length = value.IndexOf(English.errorDoubleDot, StringComparison.Ordinal) + 2
                            _output.AppendText(vbCr)
                        ElseIf value.ToLower().IndexOf(English.errorCliStreamer, StringComparison.Ordinal) = 0 Then
                            value = English.msgStreamer & regex.Replace(value, String.Empty)
                            type = OutputTypeEnum.Cli
                            startIndex = _output.TextLength
                            length = value.IndexOf(English.errorDoubleDot, StringComparison.Ordinal) + 2
                            _output.AppendText(vbCr)
                        ElseIf value.ToLower().IndexOf(English.errorWarning, StringComparison.Ordinal) = 0 Then
                            type = OutputTypeEnum.Warning
                            startIndex = _output.TextLength
                            length = value.IndexOf(English.errorDoubleDot, StringComparison.Ordinal) + 2
                            _output.AppendText(vbCr)
                        ElseIf value.IndexOf(":", StringComparison.Ordinal) > -1 Then
                            type = OutputTypeEnum.Status
                            startIndex = _output.TextLength
                            length = value.IndexOf(English.errorDoubleDot, StringComparison.Ordinal) + 2
                            _output.AppendText(vbCr)
                        End If

                        If type = OutputTypeEnum.Error Then
                            lastError = value
                        End If

                        value = timestamp & value
                        startIndex += timestamp.Length
                        _output.AppendText(value.ToString() & vbCr)

                        If startIndex > -1 Then
                            _output.Select(startIndex, length)

                            If type = OutputTypeEnum.Error Then
                                _output.SelectionColor = Color.Red
                            ElseIf type = OutputTypeEnum.Status Then
                                _output.SelectionColor = Color.Lime
                            ElseIf type = OutputTypeEnum.Warning Then
                                _output.SelectionColor = Color.Yellow
                            ElseIf type = OutputTypeEnum.Cli Then
                                _output.SelectionColor = Color.DeepSkyBlue
                            End If

                            _output.Select(startIndex, length)
                            _output.SelectionFont = New Font(_output.Font, FontStyle.Bold)
                        End If

                        If lastError <> Nothing Then
                            InvokeElement.MsgBoxRed(
                                String.Format(Lang.RmText.GetString("msgErrorGeneralText"), vbCrLf, lastError),
                                Lang.RmText.GetString("msgFailure"),
                                MessageBoxButtons.OK)
                        End If

                        Return Nothing
                    End Function))
        End Sub
    End Class
End Namespace
