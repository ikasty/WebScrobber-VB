Namespace FileSystem
    Module Files
        Public Function CleanFileName(ByVal x As String) As String
            x = x.Replace("/", "")
            x = x.Replace("\", "")
            x = x.Replace("?", "？")
            x = x.Replace("%", "")
            x = x.Replace("*", "")
            x = x.Replace(":", "")
            x = x.Replace("|", "")
            x = x.Replace("""", "")
            x = x.Replace("<", "")
            x = x.Replace(">", "")

            x = x.Trim(" ")
            x = x.Trim()

            Return x
        End Function
    End Module
End Namespace