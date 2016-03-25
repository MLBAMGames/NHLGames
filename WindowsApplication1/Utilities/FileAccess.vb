Imports System.IO

Public Class FileAccess

    ''' <summary>
    ''' DirectoryInfo.GetFiles can cause AuthorizationException Errors, hence this function
    ''' </summary>
    ''' <param name="root">Root folder to search (eg. "C:\Program Files")</param>
    ''' <param name="searchPattern">Pattern to search for (eg. "vlc.exe" or "*.exe")</param>
    ''' <returns>List of paths</returns>
    Public Shared Function GetFiles(root As String, searchPattern As String) As List(Of String)
        Dim result As New List(Of String)()

        Dim pending As New Stack(Of String)()
        pending.Push(root)
        While pending.Count <> 0
            Dim path = pending.Pop()
            Dim [next] As String() = Nothing
            Try
                [next] = Directory.GetFiles(path, searchPattern)
            Catch
            End Try
            If [next] IsNot Nothing AndAlso [next].Length <> 0 Then
                For Each file As String In [next]
                    result.Add(file)
                Next
            End If
            Try
                [next] = Directory.GetDirectories(path)
                For Each subdir As String In [next]
                    pending.Push(subdir)
                Next
            Catch
            End Try
        End While

        Return result
    End Function


    Private Shared Function SearchDirectories(directories As List(Of DirectoryInfo), filename As String, Optional suggestedFolderName As String = "") As String

        If String.IsNullOrEmpty(suggestedFolderName) = False Then

            For Each dir As DirectoryInfo In directories
                If Directory.Exists(dir.FullName & suggestedFolderName) Then
                    Dim result As String = SearchDirectories(New List(Of DirectoryInfo) From {New DirectoryInfo(dir.FullName & suggestedFolderName)}, filename)
                    If result <> "" Then
                        Return result
                    End If
                End If
            Next

        End If

        For Each dir As DirectoryInfo In directories
            Dim files As List(Of String) = GetFiles(dir.FullName, filename)
            If files.Count > 0 Then
                Return files(0)
            End If
        Next

        Return ""
    End Function

    Private Shared Function SearchPathsForExe(filename As String) As String
        Dim path As [String] = Environment.GetEnvironmentVariable("path")
        Dim folders As [String]() = path.Split(";"c)
        For Each folder As [String] In folders
            If File.Exists(folder & filename) Then
                Return folder & filename
            ElseIf File.Exists(Convert.ToString(folder + "\") & filename) Then
                Return Convert.ToString(folder + "\") & filename
            End If
        Next

        Return String.Empty
    End Function
    Public Shared Function LocateEXE(filename As [String], Optional suggestedFolderName As String = "") As String

        Console.WriteLine("Status: Locating " & filename)

        Dim searchResult As String = SearchPathsForExe(filename)
        If String.IsNullOrEmpty(searchResult) = False Then
            Console.WriteLine("Status: Located at " & searchResult)
            Return searchResult
        End If

        Dim DirectoriesToSearch As New List(Of DirectoryInfo) From {New DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles))}

        If (DirectoriesToSearch(0).FullName.IndexOf("x86") > -1) Then
            DirectoriesToSearch.Add(New DirectoryInfo(DirectoriesToSearch(0).FullName.Replace(" (x86)", "")))
        End If

        searchResult = SearchDirectories(DirectoriesToSearch, filename, suggestedFolderName)

        If String.IsNullOrEmpty(searchResult) = False Then
            Console.WriteLine("Status: Located at " & searchResult)
            Return searchResult
        End If

        Console.WriteLine("Error: Unable to locate " & filename)
        Return [String].Empty
    End Function


    Public Shared Function IsFileReadonly(path As String) As Boolean

        Dim returnValue As Boolean = False
        Dim attributes As FileAttributes = File.GetAttributes(path)
        Return (attributes And FileAttributes.[ReadOnly]) = FileAttributes.[ReadOnly]

    End Function


    Public Shared Sub RemoveReadOnly(path As String)

        Dim attributes As FileAttributes = File.GetAttributes(path)

        If (attributes And FileAttributes.[ReadOnly]) = FileAttributes.[ReadOnly] Then
            ' Make the file RW
            attributes = RemoveAttribute(attributes, FileAttributes.[ReadOnly])
            File.SetAttributes(path, attributes)
            Console.WriteLine("The {0} file is no longer Read Only", path)
        End If

    End Sub

    Public Shared Sub AddReadonly(path As String)
        File.SetAttributes(path, File.GetAttributes(path) Or FileAttributes.ReadOnly)
        Console.WriteLine("The {0} file is now set back to Read Only", path)
    End Sub

    Public Shared Function RemoveAttribute(attributes As FileAttributes, attributesToRemove As FileAttributes) As FileAttributes
        Return attributes And Not attributesToRemove
    End Function





End Class
