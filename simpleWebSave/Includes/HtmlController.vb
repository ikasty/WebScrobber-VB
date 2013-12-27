Imports System.IO
Imports System.Net

Namespace HtmlController
    Public Class getHtml
        Public Delegate Sub DelegateSendNotice(ByVal Message As String)

        Private Sub New()
        End Sub

        Public Shared Function getHtml(ByVal URL As String, Optional Notice As DelegateSendNotice = Nothing) As String
            Dim Request As HttpWebRequest, Response As HttpWebResponse, Stream As StreamReader
            Dim Result As New System.Text.StringBuilder

            Try
                If Notice IsNot Nothing Then Notice("getHtml: Try to get URL: " & URL)

                '해당 url 가져오기 시도
                Request = CType(WebRequest.Create(URL), HttpWebRequest)
                Response = CType(Request.GetResponse(), HttpWebResponse)
                Stream = New StreamReader(Response.GetResponseStream())
                While (Stream.Peek <> -1)
                    Result.Append(Stream.ReadLine)
                    Result.AppendLine()
                    If (Stream.EndOfStream = True) Then Exit While
                End While

                If Notice IsNot Nothing Then Notice("getHtml: Success to get URL")
            Catch ex As Exception
                If Notice IsNot Nothing Then Notice("getHtml: Failed to get URL: " & ex.ToString())
            End Try

            Return Result.ToString
        End Function

    End Class

    Public Class getFile
        Public Delegate Sub DelegateSendNotice(ByVal Message As String)
        Public Enum Options
            AUTO_CREATE_DIR = 1
        End Enum
        Public Shared Sub getImage _
            (ByVal URL As String, ByVal Directory As String, ByVal FileName As String, _
             Optional ByVal Options As Integer = 0, Optional Notice As DelegateSendNotice = Nothing)

            If (Options & getFile.Options.AUTO_CREATE_DIR <> 0) Then
                Dim Dir As New DirectoryInfo(Directory)
                If (Dir.Exists) Then Dir.Create()
                If Notice IsNot Nothing Then Notice("getImage: Automatically create " & Directory)
            Else
                If Notice IsNot Nothing Then Notice("getImage: Not exists " & Directory)
                Exit Sub
            End If

            Try
                My.Computer.Network.DownloadFile(URL, Directory & FileName)
            Catch ex As Exception
                If Notice IsNot Nothing Then Notice("getImage: Catch exception during Network download: " & ex.ToString)
                Exit Sub
            End Try

            Dim imageFile As New FileInfo(Directory & FileName)
            Dim imageBmp As New Bitmap(imageFile.FullName)
            Dim imageExt As String = GetImageExt(imageBmp)

            If imageExt <> imageFile.Extension Then
                imageBmp.Dispose()
                FileName = FileName.Replace(imageFile.Extension, imageExt)
                If imageExt = ".error" And Notice IsNot Nothing Then Notice("getImage: " & imageFile.Name & ": Is not supported image.")
                imageFile.MoveTo(imageFile.FullName.Replace(imageFile.Extension, imageExt))
            End If

        End Sub

        Public Shared Sub getImage _
            (ByVal URL As String, ByVal AbsPath As String, _
             Optional ByVal Options As Integer = 0, Optional Notice As DelegateSendNotice = Nothing)
            Dim splitter As Integer = AbsPath.LastIndexOf("\")
            Dim Directory As String = AbsPath.Substring(0, splitter)
            Dim Filename As String = AbsPath.Substring(splitter + 1, AbsPath.Length - splitter - 1)
            getImage(URL, Directory, Filename, Options, Notice)
        End Sub

        Private Shared Function GetImageExt(ByVal Image As System.Drawing.Image) As String

            If Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Jpeg) Then
                Return ".jpg"
            ElseIf Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Gif) Then
                Return ".gif"
            ElseIf Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Bmp) Then
                Return ".bmp"
            ElseIf Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Tiff) Then
                Return ".tiff"
            ElseIf Image.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png) Then
                Return ".png"
            Else
                Return ".error"
            End If
        End Function

    End Class
End Namespace