Public Class ConsolParseController
    Private Shared SIngleton As ConsolParseController = Nothing
    Public Shared Function getSingleton() As ConsolParseController
        If SIngleton Is Nothing Then SIngleton = New ConsolParseController
        Return SIngleton
    End Function

    Public Function Interprete(ByVal Console As String) As Boolean




        Return True
    End Function
End Class
