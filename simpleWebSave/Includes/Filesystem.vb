Namespace FileSystem
    Module FileSystem
        Public Function CleanFileName(ByVal filename As String) As String
            filename = filename.Replace("/", "")
            filename = filename.Replace("\", "")
            filename = filename.Replace("?", "？")
            filename = filename.Replace("%", "")
            filename = filename.Replace("*", "")
            filename = filename.Replace(":", "")
            filename = filename.Replace("|", "")
            filename = filename.Replace("""", "")
            filename = filename.Replace("<", "")
            filename = filename.Replace(">", "")

            filename = filename.Trim(" ")
            filename = filename.Trim()

            Return filename
        End Function

        Public Function CleanDirectoryName(ByVal OriginalPath As String) As String
            If OriginalPath.IndexOf(":\") = -1 Then Throw New Exception("FileSystem: directory " & OriginalPath & " is not a absolute path")
            Dim PathRoot As String = OriginalPath.Split(":\")(0) & ":"
            Dim directoryList() As String = OriginalPath.Split(":\")(1).Split("\")

            For Each dir As String In directoryList
                Dim newPath As String = CleanFileName(dir)
                If newPath <> "" Then PathRoot &= "\" & newPath
            Next

            Return PathRoot
        End Function
    End Module
End Namespace