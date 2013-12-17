Imports System.IO
Imports System.Net

Namespace HtmlController
    Public Class getHtml
        Public Delegate Sub DelegateSendNotice(ByVal Message As String)

        Private Sub New()
        End Sub

        Public Shared Function getHtml(ByVal URL As String, Notice As DelegateSendNotice) As String
            Dim Request As HttpWebRequest, Response As HttpWebResponse, Stream As StreamReader
            Dim Result As New System.Text.StringBuilder

            Try
                Notice("getHtml: Try to get URL " & URL)

                '해당 url 가져오기 시도
                Request = CType(WebRequest.Create(URL), HttpWebRequest)
                Response = CType(Request.GetResponse(), HttpWebResponse)
                Stream = New StreamReader(Response.GetResponseStream())
                While (Stream.Peek <> -1)
                    Result.Append(Stream.ReadLine)
                    Result.AppendLine()
                    If (Stream.EndOfStream = True) Then Exit While
                End While

                Notice("getHtml: Success to get URL")
            Catch ex As Exception
                Notice("getHtml: Failed to get URL: " & ex.ToString())
            End Try

            Return Result.ToString
        End Function

    End Class
End Namespace