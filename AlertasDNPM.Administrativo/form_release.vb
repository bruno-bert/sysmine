Imports System.IO
Public Class form_release

    Private Sub form_release_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      
        Try

            text_release.LoadFile("release.txt", RichTextBoxStreamType.PlainText)
         
        Catch ex As Exception

            ShowMessage(ex, 0)

        End Try

    End Sub
End Class