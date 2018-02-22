Public Class form_condicao

    Public orgao As Integer = 0 'orgao 
    Public modo As Integer = 0 'insert ou update
    Public processo As String = "" 'no caso do update, guarda numero do processo
    Public numero As String = "" 'no caso do update, guarda numero do titulo
    Private tipo_documento As String = "CONDIÇÕES"
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
    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PCON_processo_condicao
        Dim bll As New BLL.tb_PCON_processo_condicao
        Dim message As String = ""
        Dim ret As Boolean = False
        Dim retStr As String = ""

        'validações do arquivo
        If text_arquivo1.Text.Trim.Length > 0 Then

            'If Not System.IO.File.Exists(text_arquivo1.Text.Trim) Then
            'ShowMessage(gettext("custom", 31), "", enErrorType.Warning)
            'Return False
            'End If

            If text_arquivo2.Text.Trim.Length = 0 Then
                ShowMessage(gettext("custom", 32), "", enErrorType.Warning)
                Return False
            End If

        End If


        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo

        Select Case modo
            Case 1 'insert
                dto.PCON_cd_condicao = bll.GetNextIndex(dto, "PCON_cd_condicao")
            Case 2
                dto.PCON_cd_condicao = numero
        End Select


        dto.AUDT_dt_inclusao = Now
        dto.AUDT_nm_usuario_inclusao = default_user
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user
        'dto.ORGA_nm_orgao = orgao
        dto.COND_nm_condicao = combo_nome.Text.Trim

        dto.PCON_ds_condicao = text_descricao.Text.Trim
        dto.PCON_dt_ini = IIf(date_inicial.Checked, date_inicial.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))
        dto.PCON_dt_fim = IIf(date_final.Checked, date_final.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))
        dto.SCON_ds_situacao_condicao = combo_situacao.Text.Trim

        dto.PCON_ds_local_documento = text_arquivo1.Text.Trim
        dto.PCON_ds_nome_documento = text_arquivo2.Text
        dto.PCON_ds_rede_documento = text_arquivo3.Text.Trim
        dto.PCON_ds_path_documento = ""


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
        dtoCOVE.COVE_id_documento = combo_nome.Text.Trim
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
    Private Sub salvaCondicao()

        If combo_nome.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_COND_condicao
        Dim bll As New BLL.tb_COND_condicao
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("COND_nm_condicao = '" & combo_nome.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.COND_nm_condicao = combo_nome.Text.Trim
            'dto.ORGA_nm_orgao = orgao
            ret = bll.InsertData(dto)
        End If


    End Sub
    Private Sub salvaSituacao()

        If combo_situacao.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_SCON_situacao_condicao
        Dim bll As New BLL.tb_SCON_situacao_condicao
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("SCON_ds_situacao_condicao = '" & combo_situacao.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.SCON_ds_situacao_condicao = combo_situacao.Text.Trim
            dto.ORGA_nm_orgao = orgao
            ret = bll.InsertData(dto)
        End If


    End Sub



    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                salvaCondicao()
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

        Dim dt As DataTable
        Dim bll As New BLL.tb_COND_condicao
        Dim dto As New DTO.tb_COND_condicao
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)
        combo_nome.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_nome.Items.Add(dr("COND_nm_condicao"))
        Next


        Dim dt1 As DataTable
        Dim bll1 As New BLL.tb_SCON_situacao_condicao
        Dim dto1 As New DTO.tb_SCON_situacao_condicao
        bll1.ConnectionString = connection
        bll1.XMLPath = xmlpath

        dt1 = bll1.GetData(dto1)
        combo_situacao.Items.Clear()
        For Each dr As DataRow In dt1.Rows
            combo_situacao.Items.Add(dr("SCON_ds_situacao_condicao"))
        Next


    End Sub
    Private Sub form_condicao_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If orgao = -1 Or modo = 0 Or processo.Trim.Length = 0 Then
                Exit Sub
            End If

            If modo = 2 And numero.Trim.Length = 0 Then
                Exit Sub
            End If


            MakeFormGlobal(Me)

            'SelecionaTituloJanela(orgao)

            CarregaCombos()
            LimpaDetalhes()

            combo_nome.Enabled = True
            button_confirm.Visible = True

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
        Dim dto As New DTO.tb_PCON_processo_condicao
        Dim bll As New BLL.tb_PCON_processo_condicao

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PCON_cd_condicao = numero
        'dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            'combo_nome.Enabled = False
            combo_nome.Text = base.AjustaNulo(dt.Rows(0)("COND_nm_condicao"))
            combo_situacao.Text = base.AjustaNulo(dt.Rows(0)("SCON_ds_situacao_condicao"))
            text_descricao.Text = base.AjustaNulo(dt.Rows(0)("PCON_ds_condicao"))
            modo = 2
            'button_confirm.Visible = False

            text_arquivo1.Text = base.AjustaNulo(dt.Rows(0)("PCON_ds_local_documento"))
            text_arquivo2.Text = base.AjustaNulo(dt.Rows(0)("PCON_ds_nome_documento"))
            text_arquivo3.Text = base.AjustaNulo(dt.Rows(0)("PCON_ds_rede_documento"))

            If IsDate(base.AjustaNulo(dt.Rows(0)("PCON_dt_ini"))) Then
                date_inicial.Value = CDate(dt.Rows(0)("PCON_dt_ini"))
                date_inicial.Checked = True
            Else
                date_inicial.Value = Now.Date
                date_inicial.Checked = False
            End If

            If IsDate(base.AjustaNulo(dt.Rows(0)("PCON_dt_fim"))) Then
                date_final.Value = CDate(dt.Rows(0)("PCON_dt_fim"))
                date_final.Checked = True
            Else
                date_final.Value = Now.Date
                date_final.Checked = False

            End If


            Dim dtoCOVE As New DTO.tb_COVE_controle_vencimento
            Dim bllCOVE As New BLL.tb_COVE_controle_vencimento
            Dim dtCOVE As DataTable
            bllCOVE.ConnectionString = connection
            bllCOVE.XMLPath = xmlpath
            dtoCOVE.PROC_cd_processo = processo
            dtoCOVE.ORGA_nm_orgao = orgao
            dtoCOVE.COVE_nm_tipo_documento = tipo_documento
            dtoCOVE.COVE_id_documento = dt.Rows(0)("COND_nm_condicao").ToString.Trim
            dtCOVE = bllCOVE.GetData(dtoCOVE)
            If dtCOVE.Rows.Count > 0 Then
                text_ini.Text = base.NuloParaZero(dtCOVE.Rows(0)("COVE_qt_inicio"))
                text_int.Text = base.NuloParaZero(dtCOVE.Rows(0)("COVE_qt_intervalo"))
            End If


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
        date_inicial.Checked = False
        date_final.Checked = False
        text_ini.Text = ""
        text_int.Text = ""
        'date_inicial.MinDate = N
        'date_inicial.MaxDate = N
        'date_final.MinDate = N
        'date_final.MaxDate = N
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

    Private Sub text_ini_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_ini.TextChanged

    End Sub
End Class