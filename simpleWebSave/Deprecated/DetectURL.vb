Public Class DetectURL
    Private FullURL As String
    Private Type As UrlType
    Private ID As String, Category As String
    Private form As Mainform
    Private FullURI As Uri

    Public Enum UrlType
        Unknown
        Naver
        Tumbler
        Tistory
        Wordpress
        Egloos
        FC2
    End Enum
    Public Sub New(ByRef forms As Mainform)
        form = forms
        Type = UrlType.Unknown
    End Sub

    Public ReadOnly Property Url As String
        Get
            Return FullURL
        End Get
    End Property

    Public ReadOnly Property URI As Uri
        Get
            Return FullURI
        End Get
    End Property

    Public Sub SetUrl(ByVal urlString As String)
        FullURL = urlString
        FullURI = New Uri(FullURL)
        DetectUrlType()
    End Sub

    Public ReadOnly Property GetUrlType As UrlType
        Get
            Return Type
        End Get
    End Property

    '//form에 기본으로 설정된 값을 불러온다
    Public Sub DetectDefaultUrlType()
        Type = UrlType.Unknown
        If (form.SourceNaver.Checked = True) Then Type = UrlType.Naver
        If (form.SourceTumbler.Checked = True) Then Type = UrlType.Tumbler
        If (form.SourceTistory.Checked = True) Then Type = UrlType.Tistory
        If (form.SourceWordpress.Checked = True) Then Type = UrlType.Wordpress
        If (form.SourceEgloos.Checked = True) Then Type = UrlType.Egloos
        If (form.SourceFC2.Checked = True) Then Type = UrlType.FC2
    End Sub

    '//URL로부터 설정값을 불러온다
    Private Sub DetectUrlType()
        If (FullURL = "") Then Exit Sub

        '//우선 form에서 기본으로 설정된 값이 있는지 체크해본 다음
        DetectDefaultUrlType()
        '//설정된 값이 있으면 자동 타입이 아님
        If (Type <> UrlType.Unknown) Then Exit Sub

        '//이제 자동으로 디텍트
        Dim uri As New Uri(FullURL)
        If (uri.Host.ToLower.Contains(".naver.")) Then Type = UrlType.Naver
        If (uri.Host.ToLower.Contains(".blog.me")) Then Type = UrlType.Naver

        If (uri.Host.ToLower.Contains(".tumblr.")) Then Type = UrlType.Tumbler
        If (uri.Host.ToLower.Contains(".tistory.")) Then Type = UrlType.Tistory
        If (uri.Host.ToLower.Contains(".wordpress.")) Then Type = UrlType.Wordpress
        If (uri.Host.ToLower.Contains(".egloos.")) Then Type = UrlType.Egloos
        If (uri.Host.ToLower.Contains(".fc2.")) Then Type = UrlType.FC2


    End Sub
End Class
