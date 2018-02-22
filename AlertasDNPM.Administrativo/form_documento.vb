Public Class form_documento

    Public orgao As Integer = -1 'orgao
    Public modo As Integer = 0 'insert ou update

    Public processo As String = "" 'no caso do update, guarda numero do processo
    Public numero As String = "" 'no caso do update, guarda numero do titulo
    Private Sub button_del_arquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_del_arquivo.Click
        Try

            clearFileInfo()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub button_sel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_sel.Click
        Try

            If file_sel.ShowDialog = Windows.Forms.DialogResult.OK Then
                If file_sel.FileName.Trim.Length > 0 Then
                    loadFileInfo()
                    'Else
                    'clearFileInfo()
                End If
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub clearFileInfo()
        text_arquivo1.Text = ""
        text_arquivo2.Text = ""
        text_arquivo3.Text = ""
        file_sel.FileName = ""
    End Sub
    Private Sub loadFileInfo()
        Dim drive As String = ""
        Dim filename As String = ""
        Dim path As String = ""
        Dim fullfile As String = file_sel.FileName
        Dim rede As String = ""
        Dim machine As String = "\\" & System.Environment.MachineName

        drive = fullfile.Substring(0, fullfile.IndexOf("\"))
        rede = Replace(fullfile, drive, machine)
        filename = fullfile.Substring(fullfile.LastIndexOf("\") + 1, fullfile.Length - fullfile.LastIndexOf("\") - 1)

        text_arquivo1.Text = fullfile
        text_arquivo2.Text = filename
        text_arquivo3.Text = rede

    End Sub
    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PDOC_processo_documento
        Dim bll As New BLL.tb_PDOC_processo_documento
        Dim message As String = ""
        Dim ret As Boolean = False
        Dim retStr As String = ""


        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        dto.AUDT_dt_inclusao = Now
        dto.AUDT_nm_usuario_inclusao = default_user
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user
        dto.PROC_cd_processo = processo
        dto.ORGA_nm_orgao = orgao
        dto.PDOC_nm_documento = text_arquivo2.Text
        dto.PDOC_ds_documento = text_descricao.Text.Trim
        dto.PDOC_ds_local_documento = text_arquivo1.Text.Trim
        dto.PDOC_ds_rede_documento = text_arquivo3.Text.Trim
        dto.PDOC_ds_path_documento = text_arquivo1.Text.Trim


        ret = bll.SaveData(dto, message, 0, modo)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If




        Return ret

    End Function
    

    

    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                sender.enabled = True
                Me.Cursor = Cursors.Arrow

                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If

            sender.enabled = True
            Me.Cursor = Cursors.Arrow


        Catch ex As Exception
            sender.enabled = True
            Me.Cursor = Cursors.Arrow

            ShowMessage(ex, 0)
        End Try
    End Sub
    
    Private Sub form_titulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If orgao = -1 Or modo = 0 Or processo.Trim.Length = 0 Then
                Exit Sub
            End If

            If modo = 2 And numero.Trim.Length = 0 Then
                Exit Sub
            End If


            MakeFormGlobal(Me)

            SelecionaTituloJanela(orgao)

            LimpaDetalhes()

            group_documento.Enabled = True

            If modo = 2 Then
                CarregaDetalhes(processo, numero, orgao)
            End If



            timer_focus.Enabled = True
            timer_focus.Start()



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub SelecionaTituloJanela(ByVal orgao As Integer)
        Select Case orgao
            Case 0 : Me.Text = String.Format(Me.Text, "DNPM")
            Case 1 : Me.Text = String.Format(Me.Text, "CETESB")
            Case 2 : Me.Text = String.Format(Me.Text, "DAEE")
            Case 3 : Me.Text = String.Format(Me.Text, "ICMBIO")
            Case 4 : Me.Text = String.Format(Me.Text, "PETROBRÁS")
            Case 5 : Me.Text = String.Format(Me.Text, "PREFEITURAS")
            Case 6 : Me.Text = String.Format(Me.Text, "PROJETOS")
        End Select
    End Sub
    Private Sub CarregaDetalhes(ByVal processo As String, _
                                ByVal numero As String, _
                                ByVal orgao As Integer)

        Dim dt As DataTable
        Dim dto As New DTO.tb_PDOC_processo_documento
        Dim bll As New BLL.tb_PDOC_processo_documento

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PDOC_nm_documento = numero
        dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            group_documento.Enabled = False
            text_descricao.Text = base.AjustaNulo(dt.Rows(0)("PDOC_ds_documento"))
            text_arquivo1.Text = base.AjustaNulo(dt.Rows(0)("PDOC_ds_local_documento"))
            text_arquivo2.Text = base.AjustaNulo(dt.Rows(0)("PDOC_nm_documento"))
            text_arquivo3.Text = base.AjustaNulo(dt.Rows(0)("PDOC_ds_rede_documento"))
            modo = 2
        Else
            group_documento.Enabled = True
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub LimpaDetalhes()
        text_descricao.Text = ""
        text_arquivo1.Text = ""
        text_arquivo2.Text = ""
        text_arquivo3.Text = ""
    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            button_sel.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class