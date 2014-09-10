Public Class SingleToken
    Public Enum TokenTypes
        Code
        Bool
        Data
        LineEnd
    End Enum

    Public ReadOnly type As TokenTypes
    Public ReadOnly rawdata As String

    Public Shared Codeset As HashSet(Of String)
    Shared Sub New()
        ' /code/
        Codeset.Add("quit")
        Codeset.Add("startcrawl")
        Codeset.Add("startdownload")
        Codeset.Add("deletefinished")

        ' /code/ /bool/
        Codeset.Add("autostartcrawl")
        Codeset.Add("autostartdownload")
        Codeset.Add("autoquit")
        Codeset.Add("autocountincr")

        ' set /code/ /data/
        Codeset.Add("set")

        Codeset.Add("group")
        Codeset.Add("format")
        Codeset.Add("count")
        Codeset.Add("workdirectory")
        Codeset.Add("errordirectory")

        ' add (url|html) /data/
        Codeset.Add("add")

        Codeset.Add("url")
        Codeset.Add("html")

    End Sub


    Public Sub New(token As String)
        Me.rawdata = token

        'TODO: 토큰을 구분해서 생성해야 함
        If Codeset.Contains(token.ToLower) Then
            type = TokenTypes.Code
        ElseIf token.ToLower = "on" Or token.ToLower = "off" Then
            type = TokenTypes.Bool
        ElseIf token = vbCrLf Then
            type = TokenTypes.LineEnd
        Else
            type = TokenTypes.Data
        End If
    End Sub

End Class