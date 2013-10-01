Imports System.IO
Imports System.Net

Public Class GetHtmlSource
    Private form As Mainform

    '//출력 델리게이트 함수
    '//form.SendNotice -> Notice
    Private Notice As GetImageUrl.DelegateSendNotice
    Private useFirstUrl As Boolean = False

    Public Sub New(Mainform As Mainform, ByRef Notice As GetImageUrl.DelegateSendNotice)
        Me.form = Mainform
        Me.Notice = Notice
    End Sub

    'http url 주소로부터 html 소스 구하기
    Public Function GetUrlSource(ByVal URL As DetectURL) As String
        Dim Request As HttpWebRequest, Response As HttpWebResponse, Stream As StreamReader
        Dim CurrentURL As DetectURL
        Dim imsi As New System.Text.StringBuilder
        Dim checkFirstUrl As Boolean = True

        Dim Result As String = ""

        useFirstUrl = form.useFirstUrlSource.Checked

        Try
            'URL initialize
            CurrentURL = URL
            Do
                Notice("Try to get URL: " & CurrentURL.Url)
                imsi.Clear()

                '해당 url 가져오기 시도
                Request = CType(WebRequest.Create(CurrentURL.Url), HttpWebRequest)
                Response = CType(Request.GetResponse(), HttpWebResponse)
                Stream = New StreamReader(Response.GetResponseStream())
                While (Stream.Peek <> -1)
                    imsi.Append(Stream.ReadLine)
                    imsi.AppendLine()
                    If (Stream.EndOfStream = True) Then Exit While
                End While
                Result = imsi.ToString

                'url 후처리 후 url이 변경되지 않고 처리가 끝날 때까지 반복
                '//주의: 모든 값은 ByRef로 전달됨. 처리 과정에서 값이 변경된다.
                '//      또한 다시 해당 URL로 데이터를 읽어야 하는 경우 false가 리턴된다
                If PostUrlSource(Result, CurrentURL, checkFirstUrl) Then Exit Do
            Loop

            Notice("Success to get URL")
        Catch ex As Exception
            Notice("Failed to get URL")
        End Try

        Return Result
    End Function

    ' 소스 후처리 프로세스
    ' 읽어들인 소스를 추가로 처리하며, 필요하면 다시 소스를 읽을 수 있도록 한다
    ' 리턴 값이 false인 경우, 이미 읽은 소스는 버리고 바뀐 URL로 다시 읽어야 한다
    Private Function PostUrlSource(ByRef Source As String, ByRef URL As DetectURL, ByRef checkFirstUrl As Boolean) As Boolean

        ' frame으로 게시물의 핵심 부분 소스가 막혀있는 경우
        ' 해당 frame의 url을 가져온다
        ' 이 경우 해당 url로 소스를 다시 긁어야하므로 false 값을 리턴한다
        '====================================
        If URL.GetUrlType = DetectURL.UrlType.Naver Then
            'Naver용 Frame Load
            If Source.Contains("mainFrame") And Source.Length < 5000 Then
                URL.SetUrl(getFrameUrl(Source, "mainFrame", URL.Url))
                Return False
            End If
            If Source.Contains("screenFrame") And Source.Length < 5000 Then
                URL.SetUrl(getFrameUrl(Source, "screenFrame", URL.Url))
                Return False
            End If
        End If

        ' 소스 타입에 따른 트림
        ' 소스를 종류에 따라 불필요한 부분을 trim한다
        trimSource(Source, URL)

        ' 접기 태그가 포함되어 있어 서버에서 따로 가져와야 하는 겨우
        ' 해당 접기 태크를 가져온다
        ' 이 경우 새로 긁을 필요가 없으므로 true 값을 리턴한다
        '//getMoreTag의 Source 인자는 ByRef로서 값이 변경될 수 있다
        '====================================
        If URL.GetUrlType = DetectURL.UrlType.Naver Then
            If Source.Contains("_getSummaryContent") Then getMoreTag(Source, URL.GetUrlType)
        ElseIf URL.GetUrlType = DetectURL.UrlType.FC2 Then
            If Source.Contains("#more"">") Then getMoreTag(Source, URL.GetUrlType)
        End If

        ' 본문에서 처음 나오는 a태그를 소스로 사용하는지 체크
        If (checkFirstUrl And useFirstUrl) Then
            checkFirstUrl = False
            If (Source.Contains("<a")) Then
                Dim StartPos As Integer = Source.IndexOf("<a", 0) + "<a".Length
                StartPos = Source.IndexOf("href=""", StartPos) + "href=""".Length + 1
                Dim FinishPos As Integer = Source.IndexOf("""", StartPos) + 1
                URL.SetUrl(Mid(Source, StartPos, FinishPos - StartPos))
                Return False
            End If
        End If

        Return True
    End Function

    ' 소스 후처리 프로세스에서 사용하는 function
    ' frame의 url을 구한다
    Private Function getFrameUrl(ByVal Source As String, ByVal FrameName As String, ByVal URL As String) As String
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

    Private Sub trimSource(ByRef Source As String, ByVal URL As DetectURL)
        ' 소스를 종류에 따라 불필요한 부분을 trim한다
        Select Case (URL.GetUrlType)
            Case DetectURL.UrlType.Naver
                CutoffSource(Source, "pcol2 _param")
                CutoffSource(Source, "post_footer", True)

            Case DetectURL.UrlType.Tumbler
                CutoffSource(Source, "class=""post""")
                CutoffSource(Source, "id=""footer""", True)

            Case DetectURL.UrlType.Tistory
                CutoffSource(Source, "class=""article")
                CutoffSource(Source, "entry-ccl-by", True)
                CutoffSource(Source, "article_guest", True)
                CutoffSource(Source, "id=""paging", True)

            Case DetectURL.UrlType.Wordpress
                CutoffSource(Source, "div id=""main""")
                CutoffSource(Source, "comment-form-field", True)

            Case DetectURL.UrlType.Egloos
                CutoffSource(Source, "post_content")
                CutoffSource(Source, "post_meta_area", True)
            Case DetectURL.UrlType.FC2
                CutoffSource(Source, "<div class=""body""")
                CutoffSource(Source, "<div id=""body""")
                CutoffSource(Source, "<ol class=""sub"">", True)
        End Select


    End Sub

    '//소스 자르기 프로세스
    '//주어진 시작 문자를 기준으로 Substring을 구해준다
    Private Sub CutoffSource(ByRef Source As String, ByVal Cutoff As String, Optional ByVal EndType As Boolean = False)
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
    Private Sub getMoreTag(ByRef Source As String, ByVal Type As DetectURL.UrlType)
        Dim StartPos As Integer = 0, FinishPos As Integer, InsertPos As Integer
        Dim Params() As String
        Dim reqParam As Specialized.NameValueCollection
        Dim responsebytes As Byte(), responsebody As String

        Select Case Type
            Case DetectURL.UrlType.Naver
                '//가능한 모든 접기 태그를 읽는다
                Do
                    Try
                        '//접기 태그 시작점
                        StartPos = Source.IndexOf("_getSummaryContent", StartPos) + "_getSummaryContent".Length
                        If StartPos < 20 Then Exit Do
                        Notice("Collect summary data...")
                        StartPos = InStr(StartPos, Source, "_param(") + "_param(".Length
                        FinishPos = InStr(StartPos, Source, ")")
                        InsertPos = InStr(StartPos, Source, ">")
                        Params = Mid(Source, StartPos, FinishPos - StartPos).Split("|")
                        Using client As New Net.WebClient
                            reqParam = New Specialized.NameValueCollection
                            reqParam.Add("logNo", Params(0))
                            reqParam.Add("blogId", Params(1))
                            reqParam.Add("key", Params(2))
                            responsebytes = client.UploadValues("http://blog.naver.com/SummaryContentFetch.nhn", "POST", reqParam)
                            responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)
                        End Using

                        Source = Source.Insert(InsertPos, responsebody)
                        Notice("Success collecting summary data")
                    Catch ex As Exception
                        Notice("Error collecting summary data")
                    End Try
                Loop
                '//네이버 접기 태그 처리 끝
            Case DetectURL.UrlType.FC2
                Do
                    Try
                        '//접기 태그 시작점
                        StartPos = Source.IndexOf("#more"">", StartPos) + "#more"">".Length
                        If StartPos < 20 Then Exit Do
                        Notice("Collect summary data...")
                        StartPos = Source.LastIndexOf("<a", StartPos)
                        StartPos = Source.IndexOf("href=""", StartPos) + "href=""".Length + 1
                        FinishPos = Source.IndexOf("""", StartPos) + 1

                        Using client As New Net.WebClient
                            responsebytes = client.DownloadData(Mid(Source, StartPos, FinishPos - StartPos))
                            responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)
                        End Using

                        Source = responsebody
                        Notice("Success collecting summary data")
                    Catch ex As Exception
                        Notice("Error collecting summary data")
                    End Try
                Loop
        End Select

    End Sub
End Class
