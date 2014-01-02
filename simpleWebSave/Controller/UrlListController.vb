Imports System.Threading

Public NotInheritable Class UrlListController
    Private Sub New()
    End Sub
    Private Shared Singleton As UrlListController
    Public Shared Function getSingleton() As UrlListController
        If Singleton Is Nothing Then Singleton = New UrlListController
        Return Singleton
    End Function

    Public Sub setColumns()
        Dim columnHeader1 As New ColumnHeader
        With columnHeader1
            .Text = "제목"
            .TextAlign = HorizontalAlignment.Left
            .Width = 120
        End With
        Dim columnHeader2 As New ColumnHeader
        With columnHeader2
            .Text = "URL"
            .TextAlign = HorizontalAlignment.Center
            .Width = 140
        End With
        Dim columnHeader3 As New ColumnHeader
        With columnHeader3
            .Text = "상태"
            .TextAlign = HorizontalAlignment.Center
            .Width = 100
        End With

        With Mainform.getSingleton.SourceListView.Columns
            .Add(columnHeader1)
            .Add(columnHeader2)
            .Add(columnHeader3)
        End With
    End Sub

    ' 대기 목록에 url 추가
    Public Sub addSingleUrl(ByRef SingleURL As SingleURL)
        Dim item As New ListViewItem(SingleURL.Title)
        item.Tag = SingleURL
        item.Name = "Title"

        item.SubItems.Add(
            New ListViewItem.ListViewSubItem(item, SingleURL.URL)).Name = "URL"
        item.SubItems.Add(
            New ListViewItem.ListViewSubItem(item, "대기중")).Name = "Status"

        'Mainform의 리스트에 추가한다
        SyncLock Singleton
            Mainform.getSingleton.SourceListView.Items.Add(item)
            SingleURL.setListViewItem(item)
        End SyncLock

    End Sub

    ''' <summary>
    ''' 다운로드 완료된 항목을 삭제합니다
    ''' </summary>
    ''' <remarks>멀티스레드에 안전하게 설계되지 않았습니다. 메인 스레드에서만 호출할 수 있습니다.</remarks>
    Public Sub deleteFinishUrl()
        For Each item As ListViewItem In Mainform.getSingleton.SourceListView.Items
            If item.SubItems("Status").Text = "다운로드 완료" Then
                item.Tag.dispose()
                item.Remove()
            End If
        Next
    End Sub

    Delegate Function getUrlCallback() As SingleURL

    ''' <summary>
    ''' crawling을 대기중인 url을 리턴하는 함수
    ''' </summary>
    ''' <returns>SingleUrl</returns>
    Public Function getStanbyUrl() As SingleURL

        If Mainform.getSingleton.InvokeRequired Then
            Return Mainform.getSingleton.Invoke(New getUrlCallback(AddressOf getStanbyUrl))
        End If

        Dim returnUrl As SingleURL = Nothing
        SyncLock Singleton
            For Each item As ListViewItem In Mainform.getSingleton.SourceListView.Items
                If item.SubItems("Status").Text = "대기중" Then
                    returnUrl = DirectCast(item.Tag, SingleURL)
                    Exit For
                End If
            Next

        End SyncLock
        If returnUrl IsNot Nothing Then changeStatus(returnUrl.getListViewItem, "크롤링중")

        Return returnUrl
    End Function

    Public Function getDownloadUrl() As SingleURL
        If Mainform.getSingleton.InvokeRequired Then
            Return Mainform.getSingleton.Invoke(New getUrlCallback(AddressOf getDownloadUrl))
        End If

        Dim returnUrl As SingleURL = Nothing
        SyncLock Singleton
            For Each item As ListViewItem In Mainform.getSingleton.SourceListView.Items
                If item.SubItems("Status").Text = "다운로드 대기중" Then
                    returnUrl = DirectCast(item.Tag, SingleURL)
                    Exit For
                End If
            Next

        End SyncLock
        If returnUrl IsNot Nothing Then changeStatus(returnUrl.getListViewItem, "다운로드중")

        Return returnUrl
    End Function

    Public Sub setReadyDownload(ByRef SingleURL As SingleURL)
        changeStatus(SingleURL.getListViewItem, "다운로드 대기중")
    End Sub

    Public Sub setFinishDownload(ByRef SingleURL As SingleURL)
        changeStatus(SingleURL.getListViewItem, "다운로드 완료")
    End Sub


    Delegate Sub changeStatusCallback(ByRef item As ListViewItem, Message As String)

    Private Sub changeStatus(ByRef item As ListViewItem, Message As String)
        If Mainform.getSingleton.InvokeRequired Then
            Mainform.getSingleton.Invoke(New changeStatusCallback(AddressOf changeStatus), item, Message)
            Exit Sub
        End If

        item.SubItems("Status").Text = Message
    End Sub

End Class
