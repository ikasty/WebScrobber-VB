Public Class htmlParser
    Private Sub New()
    End Sub

    Public Shared Function getHtml(ByVal singleURL As SingleURL) As String
        Return HtmlController.getHtml.getHtml(singleURL.URL, AddressOf Mainform.getSingleton.SendNotice)
    End Function

    Public Shared Function CleaningHtml(ByVal singleURL As SingleURL)
        Return CleaningHtml(singleURL, singleURL.Source)
    End Function

    Public Shared Function CleaningHtml(ByVal singleURL As SingleURL, ByVal source As String)
        ' frame으로 게시물의 핵심 부분 소스가 막혀있는 경우
        ' 해당 frame의 url을 가져온다
        '====================================
        If SingleURL.Type = UrlTypeController.UrlType.Naver Then
            'Naver용 Frame Load
            If source.Contains("mainFrame") And source.Length < 5000 Then
                SingleURL.URL = getFrameUrl(source, "mainFrame", SingleURL.URL)
                Return CleaningHtml(singleURL, getHtml(singleURL))
            End If
            If source.Contains("screenFrame") And source.Length < 5000 Then
                SingleURL.URL = getFrameUrl(source, "screenFrame", SingleURL.URL)
                Return CleaningHtml(singleURL, getHtml(singleURL))
            End If
        End If

        ' 소스 타입에 따른 트림
        ' 소스를 종류에 따라 불필요한 부분을 trim한다
        UrlTypeController.trimSource(source, SingleURL.Type)

        ' 접기 태그가 포함되어 있어 서버에서 따로 가져와야 하는 겨우
        ' 해당 접기 태크를 가져온다
        ' 이 경우 새로 긁을 필요가 없으므로 true 값을 리턴한다
        '//getMoreTag의 Source 인자는 ByRef로서 값이 변경될 수 있다
        '====================================
        UrlTypeController.getMoreTag(source, SingleURL.Type)

        ' 본문에서 처음 나오는 a태그를 소스로 사용하는지 체크
        If (SingleURL.useFirstUrl And SingleURL.useFirstUrl) Then
            SingleURL.useFirstUrl = False
            If (source.Contains("<a")) Then
                Dim StartPos As Integer = source.IndexOf("<a", 0) + "<a".Length
                StartPos = source.IndexOf("href=""", StartPos) + "href=""".Length + 1
                Dim FinishPos As Integer = source.IndexOf("""", StartPos) + 1
                SingleURL.URL = Mid(source, StartPos, FinishPos - StartPos)
                Return CleaningHtml(singleURL, getHtml(singleURL))
            End If
        End If

        Return source
    End Function

    ' 소스 후처리 프로세스에서 사용하는 function
    ' frame의 url을 구한다
    Private Shared Function getFrameUrl(ByVal Source As String, ByVal FrameName As String, ByVal URL As String) As String
        Dim StartPos As Integer = Source.LastIndexOf("<frame id=""" & FrameName & """") + ("<frame id=""" & FrameName & """").Length
        StartPos = InStr(StartPos, Source, "src=""") + "src=""".Length
        Dim FinishPos As Integer = InStr(StartPos, Source, """")

        Dim returnString = Mid(Source, StartPos, FinishPos - StartPos)
        If Not returnString.StartsWith("http://") Then
            Dim URI As New Uri(URL)
            returnString = "http://" & URI.Host.ToString & returnString
        End If

        Return returnString
    End Function

End Class
