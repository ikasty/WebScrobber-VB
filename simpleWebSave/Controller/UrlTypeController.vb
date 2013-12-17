Public NotInheritable Class UrlTypeController

    Public Enum UrlType
        Unknown
        Naver
        Tumbler
        Tistory
        Wordpress
        Egloos
        FC2
    End Enum

    Private Shared Form As Mainform = Mainform
    Private Shared getHtml As New getHtmlWithParse

    Private Shared Singleton As New UrlTypeController

    Private Sub New()
    End Sub

    Public Shared Function getSingleton() As UrlTypeController
        Return Singleton
    End Function

    Public Shared Function getUrlTypeFromURL(ByVal URL As String) As UrlType
        Dim Type As UrlType
        If (URL = "") Then Return UrlType.Unknown

        '//우선 form에서 기본으로 설정된 값이 있는지 체크해본 다음
        Type = DetectDefaultUrlType()
        '//설정된 값이 있으면 자동 타입이 아님
        If (Type <> UrlType.Unknown) Then Return Type

        '//이제 자동으로 디텍트
        Dim uri As New Uri(URL)
        If (uri.Host.ToLower.Contains(".naver.")) Then Type = UrlType.Naver
        If (uri.Host.ToLower.Contains(".blog.me")) Then Type = UrlType.Naver
        If (uri.Host.ToLower.Contains(".tumblr.")) Then Type = UrlType.Tumbler
        If (uri.Host.ToLower.Contains(".tistory.")) Then Type = UrlType.Tistory
        If (uri.Host.ToLower.Contains(".wordpress.")) Then Type = UrlType.Wordpress
        If (uri.Host.ToLower.Contains(".egloos.")) Then Type = UrlType.Egloos
        If (uri.Host.ToLower.Contains(".fc2.")) Then Type = UrlType.FC2

        Return Type
    End Function

    Private Shared Function DetectDefaultUrlType() As UrlType
        Dim Type As UrlType = UrlType.Unknown
        If (Form.SourceNaver.Checked = True) Then Type = UrlType.Naver
        If (Form.SourceTumbler.Checked = True) Then Type = UrlType.Tumbler
        If (Form.SourceTistory.Checked = True) Then Type = UrlType.Tistory
        If (Form.SourceWordpress.Checked = True) Then Type = UrlType.Wordpress
        If (Form.SourceEgloos.Checked = True) Then Type = UrlType.Egloos
        If (Form.SourceFC2.Checked = True) Then Type = UrlType.FC2

        Return Type
    End Function


    Public Shared Sub trimSource(ByRef Source As String, ByVal URL As UrlType)
        ' 소스를 종류에 따라 불필요한 부분을 trim한다
        Select Case (URL)
            Case UrlType.Naver
                CutoffSource(Source, "pcol2 _param")
                CutoffSource(Source, "post_footer", True)

            Case UrlType.Tumbler
                CutoffSource(Source, "class=""post""")
                CutoffSource(Source, "id=""footer""", True)

            Case UrlType.Tistory
                CutoffSource(Source, "class=""article")
                CutoffSource(Source, "entry-ccl-by", True)
                CutoffSource(Source, "article_guest", True)
                CutoffSource(Source, "id=""paging", True)

            Case UrlType.Wordpress
                CutoffSource(Source, "div id=""main""")
                CutoffSource(Source, "comment-form-field", True)

            Case UrlType.Egloos
                CutoffSource(Source, "post_content")
                CutoffSource(Source, "post_meta_area", True)

            Case UrlType.FC2
                CutoffSource(Source, "<div class=""body""")
                CutoffSource(Source, "<div id=""body""")
                CutoffSource(Source, "<ol class=""sub"">", True)
        End Select

    End Sub

    '//소스 자르기 프로세스
    '//주어진 시작 문자를 기준으로 Substring을 구해준다
    Private Shared Sub CutoffSource(ByRef Source As String, ByVal Cutoff As String, Optional ByVal EndType As Boolean = False)
        If Source.Contains(Cutoff) Then
            If Not EndType Then
                Source = Source.Substring(Source.IndexOf(Cutoff))
            Else
                Source = Source.Substring(0, Source.IndexOf(Cutoff))
            End If
        End If
    End Sub

    ' 접기 태그 가져오기
    '//source 값이 ByRef으로, 값이 변경될 수 있다
    Public Shared Sub getMoreTag(ByRef Source As String, ByVal Type As DetectURL.UrlType)
        Dim StartPos As Integer = 0, FinishPos As Integer, InsertPos As Integer
        Dim Params() As String
        Dim reqParam As Specialized.NameValueCollection
        Dim responsebytes As Byte(), responsebody As String

        '현재 함수 넘어오는 조건
        'If urlSource.getUrlType = UrlTypeController.UrlType.Naver Then
        '    If Source.Contains("_getSummaryContent") Then UrlTypeController.getMoreTag(Source, urlSource.getUrlType)
        'ElseIf urlSource.getUrlType = UrlTypeController.UrlType.FC2 Then
        '    If Source.Contains("#more"">") Then UrlTypeController.getMoreTag(Source, urlSource.getUrlType)
        'End If


        Select Case Type
            Case UrlType.Naver
                '//가능한 모든 접기 태그를 읽는다
                Do
                    Try
                        '//접기 태그 시작점
                        StartPos = Source.IndexOf("_getSummaryContent", StartPos) + "_getSummaryContent".Length
                        If StartPos < 20 Then Exit Do
                        Form.SendNotice("Collect summary data...")
                        StartPos = InStr(StartPos, Source, "_param(") + "_param(".Length
                        FinishPos = InStr(StartPos, Source, ")")
                        InsertPos = InStr(StartPos, Source, ">")
                        Params = Mid(Source, StartPos, FinishPos - StartPos).Split("|")
                        Using client As New Net.WebClient
                            reqParam = New Specialized.NameValueCollection
                            reqParam.Add("logNo", Params(0))
                            reqParam.Add("blogId", Params(1)) '//TODO: getHtmlWithParse 클래스로 옮길 것
                            reqParam.Add("key", Params(2))
                            responsebytes = client.UploadValues("http://blog.naver.com/SummaryContentFetch.nhn", "POST", reqParam)
                            responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)
                        End Using

                        Source = Source.Insert(InsertPos, responsebody)
                        Form.SendNotice("Success collecting summary data")
                    Catch ex As Exception
                        Form.SendNotice("Error collecting summary data")
                    End Try
                Loop
                '//네이버 접기 태그 처리 끝
            Case DetectURL.UrlType.FC2
                Do
                    Try
                        '//접기 태그 시작점
                        StartPos = Source.IndexOf("#more"">", StartPos) + "#more"">".Length
                        If StartPos < 20 Then Exit Do
                        Form.SendNotice("Collect summary data...")
                        StartPos = Source.LastIndexOf("<a", StartPos)
                        StartPos = Source.IndexOf("href=""", StartPos) + "href=""".Length + 1
                        FinishPos = Source.IndexOf("""", StartPos) + 1

                        Using client As New Net.WebClient
                            responsebytes = client.DownloadData(Mid(Source, StartPos, FinishPos - StartPos))
                            responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)
                        End Using

                        Source = responsebody
                        Form.SendNotice("Success collecting summary data")
                    Catch ex As Exception
                        Form.SendNotice("Error collecting summary data")
                    End Try
                Loop
        End Select
    End Sub

End Class
