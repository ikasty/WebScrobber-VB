﻿Public Class SingleURL : Implements IDisposable

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

    ''' <summary>
    ''' Mainform의 Listview에 보여질 ListViewItem 항목입니다
    ''' </summary>
    Private listViewItem As ListViewItem
    ''' <summary>
    ''' listViewItem을 설정합니다
    ''' </summary>
    Public Sub setListViewItem(ByRef item As ListViewItem)
        listViewItem = item
    End Sub
    ''' <summary>
    ''' listViewItem을 구합니다
    ''' </summary>
    Public Function getListViewItem() As ListViewItem
        Return listViewItem
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' 중복 호출을 검색하려면

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: 관리되는 상태(관리되는 개체)를 삭제합니다.
            End If

            ' TODO: 관리되지 않는 리소스(관리되지 않는 개체)를 해제하고 아래의 Finalize()를 재정의합니다.
            ' TODO: 큰 필드를 null로 설정합니다.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: 위의 Dispose(ByVal disposing As Boolean)에 관리되지 않는 리소스를 해제하기 위한 코드가 있는 경우에만 Finalize()를 재정의합니다.
    'Protected Overrides Sub Finalize()
    '    ' 이 코드는 변경하지 마십시오.  위의 Dispose(ByVal disposing As Boolean)에 정리 코드를 입력하십시오.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' 삭제 가능한 패턴을 올바르게 구현하기 위해 Visual Basic에서 추가한 코드입니다.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' 이 코드는 변경하지 마십시오.  위의 Dispose(disposing As Boolean)에 정리 코드를 입력하십시오.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
