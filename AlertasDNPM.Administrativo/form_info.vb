Public Class form_info

    Public orgao As Integer = 0 'orgao 
    Public modo As Integer = 0 'insert ou update
    Public processo As String = "" 'no caso do update, guarda numero do processo
    Public numero As String = "" 'no caso do update, guarda numero do titulo

    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PINF_processo_info
        Dim bll As New BLL.tb_PINF_processo_info
        Dim message As String = ""
        Dim ret As Boolean = False
        Dim retStr As String = ""

        'validações do arquivo
        If text_arquivo1.Text.Trim.Length > 0 Then

            'If Not System.IO.File.Exists(text_arquivo1.Text.Trim) Then
            ' ShowMessage(gettext("custom", 31), "", enErrorType.Warning)
            ' Return False
            'End If

            'If text_arquivo2.Text.Trim.Length = 0 Then
            'ShowMessage(gettext("custom", 32), "", enErrorType.Warning)
            'Return False
            'End If

        End If


        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.ORGA_nm_orgao = orgao

        Select Case modo
            Case 1 'insert
                dto.PINF_cd_info = bll.GetNextIndex(dto)
            Case 2
                dto.PINF_cd_info = numero
        End Select


        dto.AUDT_dt_inclusao = Now
        dto.AUDT_nm_usuario_inclusao = default_user
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user

        dto.TINF_nm_tipo_info = combo_nome.Text.Trim
        dto.SINF_ds_situacao_info = combo_situacao.Text.Trim
        dto.PINF_ds_info = text_descricao.Text.Trim

        dto.PINF_ds_local_documento = text_arquivo1.Text.Trim
        'dto.PINF_ds_nome_documento = text_arquivo2.Text
        dto.PINF_ds_rede_documento = text_arquivo3.Text.Trim
        dto.PINF_ds_path_documento = "null"


        ret = bll.SaveData(dto, message, 0, modo)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If




        Return ret

    End Function
    Private Sub salvaTipoInfo()

        If combo_nome.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_TINF_tipo_info
        Dim bll As New BLL.tb_TINF_tipo_info
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("TINF_nm_tipo_info = '" & combo_nome.Text.Trim & "' and ORGA_nm_orgao = '" & orgao & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.TINF_nm_tipo_info = combo_nome.Text.Trim
            dto.ORGA_nm_orgao = orgao
            ret = bll.InsertData(dto)
        End If


    End Sub
    Private Sub salvaSituacaoInfo()

        If combo_situacao.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_SINF_situacao_info
        Dim bll As New BLL.tb_SINF_situacao_info
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("SINF_ds_situacao_info = '" & combo_situacao.Text.Trim & "'  and ORGA_nm_orgao = '" & orgao & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.SINF_ds_situacao_info = combo_situacao.Text.Trim
            dto.ORGA_nm_orgao = orgao
            ret = bll.InsertData(dto)
        End If


    End Sub


    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                salvaTipoInfo()
                salvaSituacaoInfo()

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
    Private Sub CarregaCombos()

        Dim dt As DataTable
        Dim bll As New BLL.tb_TINF_tipo_info
        Dim dto As New DTO.tb_TINF_tipo_info
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)
        combo_nome.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_nome.Items.Add(dr("TINF_nm_tipo_info"))
        Next


        Dim dt1 As DataTable
        Dim bll1 As New BLL.tb_SINF_situacao_info
        Dim dto1 As New DTO.tb_SINF_situacao_info
        bll1.ConnectionString = connection
        bll1.XMLPath = xmlpath
        dto1.ORGA_nm_orgao = orgao
        dt1 = bll1.GetData(dto1)
        combo_situacao.Items.Clear()
        For Each dr As DataRow In dt1.Rows
            combo_situacao.Items.Add(dr("SINF_ds_situacao_info"))
        Next



    End Sub
    Private Sub form_info_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If orgao = -1 Or modo = 0 Or processo.Trim.Length = 0 Then
                Exit Sub
            End If

            If modo = 2 And numero.Trim.Length = 0 Then
                Exit Sub
            End If


            MakeFormGlobal(Me)

            SelecionaTituloJanela(orgao)

            CarregaCombos()
            LimpaDetalhes()

            'combo_nome.Enabled = True
            'button_confirm.Visible = True

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
        Dim dto As New DTO.tb_PINF_processo_info
        Dim bll As New BLL.tb_PINF_processo_info

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PINF_cd_info = numero
        dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            'combo_nome.Enabled = False
            combo_nome.Text = base.AjustaNulo(dt.Rows(0)("TINF_nm_tipo_info"))
            combo_situacao.Text = base.AjustaNulo(dt.Rows(0)("SINF_ds_situacao_info"))
            modo = 2
            'button_confirm.Visible = False

            text_arquivo1.Text = base.AjustaNulo(dt.Rows(0)("PINF_ds_local_documento"))
            'text_arquivo2.Text = base.AjustaNulo(dt.Rows(0)("PCON_ds_nome_documento"))
            text_arquivo3.Text = base.AjustaNulo(dt.Rows(0)("PINF_ds_rede_documento"))

            text_descricao.Text = base.AjustaNulo(dt.Rows(0)("PINF_ds_info"))

        Else
            'button_confirm.Visible = True
            'combo_nome.Enabled = True
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub LimpaDetalhes()
        combo_nome.SelectedIndex = -1
        combo_nome.Text = ""
        combo_situacao.SelectedIndex = -1
        combo_situacao.Text = ""
        text_arquivo1.Text = ""
        text_arquivo2.Text = ""
        text_arquivo3.Text = ""
        text_descricao.Text = ""
    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            combo_nome.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

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
End Class