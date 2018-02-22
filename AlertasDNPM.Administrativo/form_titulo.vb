Public Class form_titulo

    Public orgao As Integer = -1 'orgao
    Public modo As Integer = 0 'insert ou update

    Public processo As String = "" 'no caso do update, guarda numero do processo
    Public numero As String = "" 'no caso do update, guarda numero do titulo

    Private tipo_documento As String = "TÍTULO"

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

        Dim dto As New DTO.tb_PTIT_processo_titulo
        Dim bll As New BLL.tb_PTIT_processo_titulo
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
        dto.PTIT_nm_titulo = text_numero.Text.Trim
        dto.PTIT_ds_titulo = text_descricao.Text.Trim
        dto.TTIT_ds_tipo_titulo = combo_tipo.Text.Trim
        dto.SITU_ds_situacao_titulo = combo_situacao.Text.Trim
        dto.PTIT_dt_publicacao = IIf(date_publicacao.Checked, date_publicacao.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))
        dto.PTIT_dt_vencimento = IIf(date_vencimento.Checked, date_vencimento.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))

        'If orgao <> 0 Then
        dto.PTIT_ds_local_documento = text_arquivo1.Text.Trim
        dto.PTIT_ds_nome_documento = text_arquivo2.Text
        dto.PTIT_ds_rede_documento = text_arquivo3.Text.Trim
        dto.PTIT_ds_path_documento = ""
        'End If


        '[abas]
        'If orgao <> 0 Then
        'dto.PTIT_ds_local_documento = ""
        'dto.PTIT_ds_nome_documento = ""
        'dto.PTIT_ds_path_documento = ""
        'dto.PTIT_ds_rede_documento = ""
        'End If

        ret = bll.SaveData(dto, message, 0, modo)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If



        'salva dados de controle de alertas de vencimento
        Dim dtCOVE As DataTable
        Dim dtoCOVE As New DTO.tb_COVE_controle_vencimento
        Dim BLLCOVE As New BLL.tb_COVE_controle_vencimento
        BLLCOVE.ConnectionString = connection
        BLLCOVE.XMLPath = xmlpath

        dtoCOVE.PROC_cd_processo = processo
        dtoCOVE.ORGA_nm_orgao = orgao
        dtoCOVE.COVE_nm_tipo_documento = tipo_documento
        dtoCOVE.COVE_id_documento = text_numero.Text.Trim
        dtoCOVE.AUDT_dt_alteracao = Now
        dtoCOVE.AUDT_nm_usuario_alteracao = default_user


        If IsNumeric(text_ini.Text) Then
            dtoCOVE.COVE_qt_inicio = CInt(text_ini.Text)
        Else
            dtoCOVE.COVE_qt_inicio = 0
        End If

        If IsNumeric(text_int.Text) Then
            dtoCOVE.COVE_qt_intervalo = CInt(text_int.Text)
        Else
            dtoCOVE.COVE_qt_intervalo = 0
        End If

        dtCOVE = BLLCOVE.GetData(dtoCOVE)
        If dtCOVE.Rows.Count > 0 Then
            BLLCOVE.UpdateData(dtoCOVE)
        Else
            dtoCOVE.AUDT_dt_inclusao = Now
            dtoCOVE.AUDT_nm_usuario_inclusao = default_user
            BLLCOVE.InsertData(dtoCOVE)
        End If



        Return ret

    End Function
    Private Sub salvaTipoTitulo()

        If combo_tipo.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_TTIT_tipo_titulo
        Dim bll As New BLL.tb_TTIT_tipo_titulo
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("TTIT_ds_tipo_titulo = '" & combo_tipo.Text.Trim & "'  and ORGA_nm_orgao = '" & orgao & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.ORGA_nm_orgao = orgao
            dto.TTIT_ds_tipo_titulo = combo_tipo.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub

    Private Sub salvaSituacao()

        If combo_situacao.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_SITU_situacao_titulo
        Dim bll As New BLL.tb_SITU_situacao_titulo
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("SITU_ds_situacao_titulo = '" & combo_situacao.Text.Trim & "' and ORGA_nm_orgao = '" & orgao & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.ORGA_nm_orgao = orgao
            dto.SITU_ds_situacao_titulo = combo_situacao.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub

    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                salvaTipoTitulo()
                salvaSituacao()

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
        'tipo titulo 
        Dim dt As DataTable
        Dim bll As New BLL.tb_TTIT_tipo_titulo
        Dim dto As New DTO.tb_TTIT_tipo_titulo
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        dto.ORGA_nm_orgao = orgao

        dt = bll.GetData(dto)
        combo_tipo.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_tipo.Items.Add(dr("TTIT_ds_tipo_titulo"))
        Next


        Dim bll2 As New BLL.tb_SITU_situacao_titulo
        Dim dto2 As New DTO.tb_SITU_situacao_titulo
        bll2.ConnectionString = connection
        bll2.XMLPath = xmlpath

        dto2.ORGA_nm_orgao = orgao

        dt = bll2.GetData(dto2)
        combo_situacao.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_situacao.Items.Add(dr("SITU_ds_situacao_titulo"))
        Next



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

            CarregaCombos()
            LimpaDetalhes()

            text_numero.Enabled = True

            group_documento.Enabled = True 'orgao <> 0
            

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
        Dim dto As New DTO.tb_PTIT_processo_titulo
        Dim bll As New BLL.tb_PTIT_processo_titulo

     

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PTIT_nm_titulo = numero
        dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            text_numero.Enabled = False
            text_numero.Text = dt.Rows(0)("PTIT_nm_titulo").ToString.Trim
            text_descricao.Text = dt.Rows(0)("PTIT_ds_titulo").ToString.Trim
            combo_tipo.Text = base.AjustaNulo(dt.Rows(0)("TTIT_ds_tipo_titulo"))
            combo_situacao.Text = base.AjustaNulo(dt.Rows(0)("SITU_ds_situacao_titulo"))

            If IsDate(base.AjustaNulo(dt.Rows(0)("PTIT_dt_publicacao"))) Then
                date_publicacao.Value = CDate(dt.Rows(0)("PTIT_dt_publicacao"))
                date_publicacao.Checked = True
            Else
                date_publicacao.Value = Now.Date
                date_publicacao.Checked = False
            End If

            If IsDate(base.AjustaNulo(dt.Rows(0)("PTIT_dt_vencimento"))) Then
                date_vencimento.Value = CDate(dt.Rows(0)("PTIT_dt_vencimento"))
                date_vencimento.Checked = True
            Else
                date_vencimento.Value = Now.Date
                date_vencimento.Checked = False
            End If

            'If orgao <> 0 Then
            text_arquivo1.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_local_documento"))
            text_arquivo2.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_nome_documento"))
            text_arquivo3.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_rede_documento"))
            'End If

            Dim dtoCOVE As New DTO.tb_COVE_controle_vencimento
            Dim bllCOVE As New BLL.tb_COVE_controle_vencimento
            Dim dtCOVE As DataTable
            bllCOVE.ConnectionString = connection
            bllCOVE.XMLPath = xmlpath
            dtoCOVE.PROC_cd_processo = processo
            dtoCOVE.ORGA_nm_orgao = orgao
            dtoCOVE.COVE_nm_tipo_documento = tipo_documento
            dtoCOVE.COVE_id_documento = dt.Rows(0)("PTIT_nm_titulo").ToString.Trim
            dtCOVE = bllCOVE.GetData(dtoCOVE)
            If dtCOVE.Rows.Count > 0 Then
                text_ini.Text = base.NuloParaZero(dtCOVE.Rows(0)("COVE_qt_inicio"))
                text_int.Text = base.NuloParaZero(dtCOVE.Rows(0)("COVE_qt_intervalo"))
            End If

            modo = 2
        Else
            text_numero.Enabled = True
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub text_int_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_int.KeyPress

        Try


            Dim isKey As Boolean = Char.IsDigit(e.KeyChar)
            Dim isDecimal As Boolean = e.KeyChar.ToString = "."
            If Not isKey And Not isDecimal Then
                e.Handled = True
            End If

        Catch ex As Exception
            'ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub text_ini_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_ini.KeyPress

        Try


            Dim isKey As Boolean = Char.IsDigit(e.KeyChar)
            Dim isDecimal As Boolean = e.KeyChar.ToString = "."
            If Not isKey And Not isDecimal Then
                e.Handled = True
            End If

        Catch ex As Exception
            'ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub LimpaDetalhes()
        text_numero.Text = ""
        text_descricao.Text = ""
        combo_tipo.SelectedIndex = -1
        combo_situacao.SelectedIndex = -1
        combo_situacao.Text = ""
        combo_tipo.Text = ""
        date_publicacao.Checked = False
        date_vencimento.Checked = False

        text_arquivo1.Text = ""
        text_arquivo2.Text = ""
        text_arquivo3.Text = ""

        text_ini.Text = ""
        text_int.Text = ""

        'date_publicacao.MinDate = N
        'date_publicacao.MaxDate = N
        'date_vencimento.MinDate = N
        'date_vencimento.MaxDate = N
    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            text_numero.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class