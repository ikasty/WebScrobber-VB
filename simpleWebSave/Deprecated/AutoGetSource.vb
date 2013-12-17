Public Class AutoGetSource
    Private URL As DetectURL
    Private reqParam As Specialized.NameValueCollection
    Private client As Net.WebClient

    Private Class UrlNameClass
        Public URL As String, Title As String
        Public Sub New(ByVal url As String)
            Me.URL = url
        End Sub
        Public Sub New(ByVal url As String, ByVal title As String)
            Me.URL = url : Me.Title = title
        End Sub
    End Class

    Public Sub New(ByVal URL As DetectURL)
        Me.URL = URL
    End Sub

    Public Sub GetSource(ByRef Textbox As TextBox)
        reqParam = New Specialized.NameValueCollection

        '//우선 url로부터 정보를 읽어온다
        GetInformation()

        Dim responsebytes As Byte(), responsebody As String
        Dim URLs As New Stack(Of UrlNameClass), Temp As UrlNameClass
        Dim tryCount As Integer

        Dim startPos As Integer = 1, finishPos As Integer
        client = New Net.WebClient

        '//URL 타입별로 데이터 로드 시도
        Select Case URL.GetUrlType
            Case DetectURL.UrlType.Naver
                responsebytes = client.UploadValues("http://blog.naver.com/PostTitleListAsync.nhn?", "POST", reqParam)
                responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)

                responsebody = responsebody.Substring(responsebody.IndexOf("["), responsebody.IndexOf("]") - responsebody.IndexOf("["))
                Do
                    startPos = InStr(startPos, responsebody, "logNo") + "logno".Length
                    If startPos < 6 Then Exit Do
                    startPos = InStr(startPos, responsebody, """:""") + """:""".Length
                    finishPos = InStr(startPos, responsebody, """")
                    Temp = New UrlNameClass("http://blog.naver.com/" & reqParam.Get("blogId") & "/" & Mid(responsebody, startPos, finishPos - startPos))

                    URLs.Push(Temp)
                Loop
            Case DetectURL.UrlType.Wordpress
                For tryCount = 1 To 3
                    If GetInformation(tryCount) Then Exit For
                Next

                Do
                    Select Case tryCount
                        Case 1
                        Case 2
                            responsebytes = client.UploadValues(URL.URI.Host, "POST", reqParam)
                            responsebody = (New System.Text.UTF8Encoding).GetString(responsebytes)

                            startPos = InStr(startPos, responsebody, "<article") + "<article".Length
                            If startPos < 8 Then Exit Do
                            startPos = InStr(startPos, responsebody, "href=""") + "href=""".Length
                            finishPos = InStr(startPos, responsebody, """")
                            Temp = New UrlNameClass(Mid(responsebody, startPos, finishPos - startPos))
                            startPos = InStr(startPos, responsebody, "title=""") + "title=""".Length
                            finishPos = InStr(startPos, responsebody, """")
                            Temp.Title = Mid(responsebody, startPos, finishPos - startPos)

                            URLs.Push(Temp)

                    End Select

                Loop

        End Select

        '//불러온 url이 전혀 없다면 종료
        If URLs.Count = 0 Then Exit Sub

        '//텍스트박스를 초기화한 후 한줄에 하나씩 입력
        Textbox.Text = ""
        Do
            If URLs.Count = 0 Then Exit Do
            Textbox.Text &= URLs.Peek().URL
            If URLs.Peek().Title <> "" Then Textbox.Text &= ";" & URLs.Peek().Title
            Textbox.Text &= vbCrLf
            URLs.Pop()
        Loop

    End Sub

    Private Function GetInformation(Optional ByVal tryCount As Integer = 1)
        reqParam = System.Web.HttpUtility.ParseQueryString(URL.URI.Query())
        Dim imsi() As String, param As String

        Select Case URL.GetUrlType
            Case DetectURL.UrlType.Naver
                reqParam.Add("categoryNo", "9")
                'reqParam.Add("blogId", BlogId)
                reqParam.Add("countPerPage", 30)
                'reqParam.Add("curerntPage", NumericUpDown1.Value)
            Case DetectURL.UrlType.Wordpress
                '사이트마다 여러가지 방법이 있으므로 모두 활용

                Select Case tryCount
                    Case 2 '검색어로 활용
                        imsi = URL.Url.Split("/")
                        param = imsi(imsi.Length)
                        If param = "" Then param = imsi(imsi.Length - 1)

                        If reqParam.Item("s") = "" Then
                            reqParam.Set("s", param)
                        End If
                End Select

        End Select

        Return True

    End Function

End Class
