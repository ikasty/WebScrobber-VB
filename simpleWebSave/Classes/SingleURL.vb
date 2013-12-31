Public Class SingleURL

    '//소스의 첫 url 가져올 지 여부
    Public useFirstUrl As Boolean = False
    '//소스의 그룹과 타이틀
    Public ReadOnly Group As String
    Public ReadOnly Title As String
    Public ReadOnly Directory As String
    Public ReadOnly ErrDir As String


    ' Constructor
    Public Sub New _
        (ByVal GROUP As String, ByVal TITLE As String, Directory As String, ErrDir As String, _
         Optional ByVal TYPE As UrlTypeController.UrlType = UrlTypeController.UrlType.Unknown, _
         Optional ByVal useFirstUrl As Boolean = False)

        Me.Group = FileSystem.CleanFileName(GROUP)
        Me.Title = FileSystem.CleanFileName(TITLE)
        Me.Type = TYPE
        Me.useFirstUrl = useFirstUrl
        Me.Directory = FileSystem.CleanDirectoryName(Directory)
        Me.ErrDir = FileSystem.CleanDirectoryName(ErrDir)
    End Sub
    Public Sub New _
        (ByVal GROUP As String, ByVal TITLE As String, ByVal URL As String, Directory As String, ErrDir As String, _
         Optional ByVal useFirstUrl As Boolean = False)

        Me.New(GROUP, TITLE, Directory, ErrDir, , useFirstUrl)
        Me.URL = URL
        Me.Type = UrlTypeController.getUrlTypeFromURL(URL)

    End Sub


    '//소스의 url
    Private _url As String
    Public Property URL As String
        Get
            Return Me._url
        End Get
        Set(ByVal value As String)
            Me._url = value
            Me.Type = UrlTypeController.getUrlTypeFromURL(Me.URL)
        End Set
    End Property

    '//소스의 url 타입
    Private _Type As UrlTypeController.UrlType = UrlTypeController.UrlType.Unknown
    Public Property Type As UrlTypeController.UrlType
        Get
            Return Me._Type
        End Get
        Private Set(ByVal value As UrlTypeController.UrlType)
            Me._Type = value
        End Set
    End Property

    '//raw 소스데이터
    Public _source As String
    Public Property Source As String
        Get
            If (_source = "") Then
                '그리고 raw 데이터를 받는다
                Me.Source = htmlParser.getHtml(Me)
            End If

            Return _source
        End Get
        Set(ByVal value As String)
            _source = value
            _source = htmlParser.CleaningHtml(Me)
        End Set
    End Property
    Public ReadOnly Property lowerSource As String
        Get
            Return Me.Source.ToLower()
        End Get
    End Property

    Public Function isReady() As Boolean
        Return (Me.Source <> "") And (Me.Title <> "")
    End Function

    Public Shadows Function toString() As String
        Dim returnStr As String = """"
        returnStr += Me.Title
        If (Me.Title = "") Then returnStr += "설정되지 않은 제목"
        returnStr += """: "

        If Me.URL <> "" Then returnStr += "( " + Me.URL + " )"

        Return returnStr
    End Function

    ' 개별 이미지를 저장하는 큐
    Private imageList As New List(Of String)
    Private index As Integer = 0
    Public Sub addImageLink(ByVal imageUrl As String)
        imageList.Add(imageUrl)
    End Sub
    Public Function getNextImage() As String
        index = index + 1
        Return imageList(index - 1)
    End Function
    Public Sub resetImageIndex()
        index = 0
    End Sub
    Public Function isEmptyImage() As Boolean
        Return imageList.Count = index
    End Function


    Public Class ErrorImage
        Public url As String, name As String
        Public Sub New(url As String, name As String)
            Me.url = url
            Me.name = name
        End Sub
    End Class
    Private errorImageList As New List(Of ErrorImage)
    Public Sub addErrorImage(ByVal ErrorImage As ErrorImage)
        errorImageList.Add(ErrorImage)
    End Sub

End Class
