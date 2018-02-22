Public NotInheritable Class form_sobre

    Private Sub form_sobre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)

            label_version.Text = String.Format(label_version.Text, My.Application.Info.Version.ToString)

        Catch ex As Exception

            ShowMessage(ex, 0)
        End Try

    End Sub

    Private Sub button_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_ok.Click
        Try
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub

End Class
