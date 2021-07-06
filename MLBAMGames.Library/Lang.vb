Imports System.Resources
Imports MLBAMGames.Library.My.Resources

Public Class Lang
    Public Shared RmText As ResourceManager = Nothing
    Public Shared EnglishRmText As ResourceManager = Nothing
    Public Shared FrenchhRmText As ResourceManager = Nothing

    Public Shared Sub GetLanguage()
        Dim language = If(Instance.Form.GetSetting("SelectedLanguage"), "English")
        If language = Lang.RmText.GetString("cbEnglish") Then
            Lang.RmText = EnglishRmText
        ElseIf language = Lang.RmText.GetString("cbFrench") Then
            Lang.RmText = FrenchhRmText
        End If
    End Sub
End Class
