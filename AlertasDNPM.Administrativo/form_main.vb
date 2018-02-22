Public Class form_main


    Private Sub menuSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_sair.Click
        End
    End Sub

    Private Sub menuSobre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_sobre.Click
        form_sobre.ShowDialog()
    End Sub

    Private Sub menuEmpresa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_empresa.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_empresa.MdiParent = Me
        form_empresa.StartPosition = FormStartPosition.CenterParent
        form_empresa.Show()
        center_form(form_empresa)
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub menuEvento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_evento.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_lista_evento.MdiParent = Me
        form_lista_evento.StartPosition = FormStartPosition.CenterParent
        form_lista_evento.Show()
        center_form(form_lista_evento)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub menuConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_config.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_config.MdiParent = Me
        form_config.Show()
        center_form(form_config)
        Me.Cursor = Cursors.Arrow
    End Sub


    Private Sub menuOperador_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_operador.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_operador.code = ""
        form_operador.MdiParent = Me
        form_operador.Show()
        center_form(form_operador)
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub menuBusca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_busca.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_busca.MdiParent = Me
        form_busca.Show()
        center_form(form_busca)
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub center_form(ByVal frm As Form)
        Application.DoEvents()
        frm.Location = New Point(Me.Width / 2 - frm.Width / 2, (Me.Height - Me.tool_main.Height) / 2 - frm.Height / 2)
    End Sub
    Private Sub menu_processo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_processo.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_grid_processo.MdiParent = Me
        form_grid_processo.Show()
        center_form(form_grid_processo)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub menu_alerta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_alerta.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_alerta.code = ""
        form_alerta.MdiParent = Me
        form_alerta.Show()
        center_form(form_alerta)
        Me.Cursor = Cursors.Arrow
    End Sub
    Private Sub menu_relatorio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_relatorio.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_relatorio_documento.MdiParent = Me
        form_relatorio_documento.Show()
        center_form(form_relatorio_documento)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub PreparaMenuPrincipal()

        Dim tool_icon As Icon
        Dim dt As DataTable

        Dim obj As New Apoio.Globalization
        dt = obj.getFormData(xmlpath, Me.Name)

        tool_main.BeginUpdateImages()

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_config", "image", tool_config.Text))
        tool_main.AssignImage(tool_config, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_empresa", "image", tool_empresa.Text))
        tool_main.AssignImage(tool_empresa, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_operador", "image", tool_operador.Text))
        tool_main.AssignImage(tool_operador, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_processo", "image", tool_processo.Text))
        tool_main.AssignImage(tool_processo, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_alerta", "image", tool_alerta.Text))
        tool_main.AssignImage(tool_alerta, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_sobre", "image", tool_sobre.Text))
        tool_main.AssignImage(tool_sobre, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_sair", "image", tool_sair.Text))
        tool_main.AssignImage(tool_sair, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_rotina", "image", tool_rotina.Text))
        tool_main.AssignImage(tool_rotina, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_busca", "image", tool_busca.Text))
        tool_main.AssignImage(tool_busca, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_limpa", "image", tool_limpa.Text))
        tool_main.AssignImage(tool_limpa, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_relatorio", "image", tool_relatorio.Text))
        tool_main.AssignImage(tool_relatorio, tool_icon)


        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_backup", "image", tool_backup.Text))
        tool_main.AssignImage(tool_backup, tool_icon)

        tool_icon = New Icon(obj.getValue(dt, "tool_main", "tool_evento", "image", tool_evento.Text))
        tool_main.AssignImage(tool_evento, tool_icon)


        tool_main.EndUpdateImages()

        tool_main.ImageSize = Global.IconToolStrip.ImageSize.Large
    End Sub

  
    Private Sub form_main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If boolExecute Then
                ShowMessage("Rotina em execução. Aguarde até a execução da rotina terminar para fechar o aplicativo", "", modGeral.enErrorType.Info)
                e.Cancel = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub form_main_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            Inicializacao()

            MakeFormGlobal(Me)

            PreparaMenuPrincipal()

            form_release.MdiParent = Me
            form_release.Show()
            center_form(form_release)


        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

   
    Private Sub tool_rotina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_rotina.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_rotina.MdiParent = Me
        form_rotina.Show()
        center_form(form_rotina)
        Me.Cursor = Cursors.Arrow
    End Sub


    Private Sub tool_limpa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_limpa.Click
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_limpa.MdiParent = Me
        form_limpa.Show()
        center_form(form_limpa)
        Me.Cursor = Cursors.Arrow
    End Sub

    Private Sub tool_backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_backup.Click
        'If form_release.Visible = True Then form_release.Close()
        'Dim sInfo As New ProcessStartInfo(backupFile)
        'Process.Start(sInfo)
        If form_release.Visible = True Then form_release.Close()
        Me.Cursor = Cursors.WaitCursor
        form_backup.MdiParent = Me
        form_backup.Show()
        center_form(form_backup)
        Me.Cursor = Cursors.Arrow
    End Sub


End Class
