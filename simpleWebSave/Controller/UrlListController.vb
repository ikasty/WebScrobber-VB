Imports System.Threading

Public NotInheritable Class UrlListController
    Private Sub New()
    End Sub
    Private Shared Singleton As UrlListController
    Public Shared Function getSingleton() As UrlListController
        If Singleton Is Nothing Then Singleton = New UrlListController
        Return Singleton
    End Function

    ' 수집을 기다리는 url
    Private Shared urlList As New List(Of SingleURL)
    Private Shared index As Integer = 0

    ' 대기 목록에 url 추가
    Public Sub addSingleUrl(ByRef URL As SingleURL)
        SyncLock urlList
            urlList.Add(URL)
        End SyncLock
    End Sub

    ' url을 리턴하는 함수
    ' @return SingleUrl
    Public Function getSingleUrl() As SingleURL
        Dim returnUrl As SingleURL
        SyncLock urlList
            If urlList.Count = index Then
                returnUrl = Nothing
            Else
                returnUrl = urlList(index)
                index = index + 1
            End If
        End SyncLock

        Return returnUrl
    End Function

End Class
