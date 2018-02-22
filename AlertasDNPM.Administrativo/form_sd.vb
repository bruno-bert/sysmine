Public Class form_sd

    Public orgao As Integer = -1 'orgao
    Public modo As Integer = 0 'insert ou update

    Public processo As String = "" 'no caso do update, guarda numero do processo
    Public numero As String = "" 'no caso do update, guarda numero do titulo

    Private tipo_documento As String = "SD"
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
    'Private Sub button_del_arquivo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        clearFileInfo()

    '    Catch ex As Exception
    '        ShowMessage(ex, 0)
    '    End Try
    'End Sub
    'Private Sub button_sel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        If file_sel.ShowDialog = Windows.Forms.DialogResult.OK Then
    '            If file_sel.FileName.Trim.Length > 0 Then
    '                loadFileInfo()
    '                'Else
    '                'clearFileInfo()
    '            End If
    '        End If

    '    Catch ex As Exception
    '        ShowMessage(ex, 0)
    '    End Try
    'End Sub
    'Private Sub clearFileInfo()
    '    text_arquivo1.Text = ""
    '    text_arquivo2.Text = ""
    '    text_arquivo3.Text = ""
    '    file_sel.FileName = ""
    'End Sub
    'Private Sub loadFileInfo()
    '    Dim drive As String = ""
    '    Dim filename As String = ""
    '    Dim path As String = ""
    '    Dim fullfile As String = file_sel.FileName
    '    Dim rede As String = ""
    '    Dim machine As String = "\\" & System.Environment.MachineName

    '    drive = fullfile.Substring(0, fullfile.IndexOf("\"))
    '    rede = Replace(fullfile, drive, machine)
    '    filename = fullfile.Substring(fullfile.LastIndexOf("\") + 1, fullfile.Length - fullfile.LastIndexOf("\") - 1)

    '    text_arquivo1.Text = fullfile
    '    text_arquivo2.Text = filename
    '    text_arquivo3.Text = rede

    'End Sub
    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PRSD_processo_sd
        Dim bll As New BLL.tb_PRSD_processo_sd
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
        dto.PRSD_nm_doc = text_doc.Text.Trim
        dto.PRSD_nm_prc = text_processo.Text.Trim
        dto.PRSD_nm_sd = text_numero.Text.Trim
        dto.SISD_nm_situacao_sd = combo_situacao.Text.Trim
        dto.OSSD_nm_objeto = combo_obj.Text.Trim
        dto.PRSD_dt_sd = IIf(date_datasd.Checked, date_datasd.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))
        dto.PRSD_dt_ini = IIf(date_desde.Checked, date_desde.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))
        dto.PRSD_dt_fim  = IIf(date_vencto.Checked, date_vencto.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))

        'If orgao <> 0 Then
        '    dto.PTIT_ds_local_documento = text_arquivo1.Text.Trim
        '    dto.PTIT_ds_nome_documento = text_arquivo2.Text
        '    dto.PTIT_ds_rede_documento = text_arquivo3.Text.Trim
        '    dto.PTIT_ds_path_documento = ""
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
    Private Sub salvaObjetoSolicitacao()

        If combo_obj.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_OSSD_objeto_sd
        Dim bll As New BLL.tb_OSSD_objeto_sd
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        'and ORGA_nm_orgao = '" & orgao & "'
        If dt.Select("OSSD_nm_objeto = '" & combo_obj.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.ORGA_nm_orgao = orgao
            dto.OSSD_nm_objeto = combo_obj.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub

    Private Sub salvaSituacao()

        If combo_situacao.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_SISD_situacao_sd
        Dim bll As New BLL.tb_SISD_situacao_sd
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        'and ORGA_nm_orgao = '" & orgao & "'
        If dt.Select("SISD_nm_situacao_sd = '" & combo_situacao.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.ORGA_nm_orgao = orgao
            dto.SISD_nm_situacao_sd = combo_situacao.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub

    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                salvaObjetoSolicitacao()
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
        Dim bll As New BLL.tb_OSSD_objeto_sd
        Dim dto As New DTO.tb_OSSD_objeto_sd
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        dto.ORGA_nm_orgao = orgao

        dt = bll.GetData(dto)
        combo_obj.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_obj.Items.Add(dr("OSSD_nm_objeto"))
        Next


        Dim bll2 As New BLL.tb_SISD_situacao_sd
        Dim dto2 As New DTO.tb_SISD_situacao_sd
        bll2.ConnectionString = connection
        bll2.XMLPath = xmlpath

        dto2.ORGA_nm_orgao = orgao

        dt = bll2.GetData(dto2)
        combo_situacao.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_situacao.Items.Add(dr("SISD_nm_situacao_sd"))
        Next



    End Sub
    Private Sub form_sd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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

            text_numero.Enabled = True

            'group_documento.Enabled = orgao <> 0


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
        Dim dto As New DTO.tb_PRSD_processo_sd
        Dim bll As New BLL.tb_PRSD_processo_sd

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PRSD_nm_sd = numero
        dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            text_numero.Enabled = False
            text_numero.Text = dt.Rows(0)("PRSD_nm_sd").ToString.Trim
            text_processo.Text = dt.Rows(0)("PRSD_nm_prc").ToString.Trim
            text_doc.Text = dt.Rows(0)("PRSD_nm_doc").ToString.Trim

            combo_obj.Text = base.AjustaNulo(dt.Rows(0)("OSSD_nm_objeto"))
            combo_situacao.Text = base.AjustaNulo(dt.Rows(0)("SISD_nm_situacao_sd"))

            If IsDate(base.AjustaNulo(dt.Rows(0)("PRSD_dt_sd"))) Then
                date_datasd.Value = CDate(dt.Rows(0)("PRSD_dt_sd"))
                date_datasd.Checked = True
            Else
                date_datasd.Value = Now.Date
                date_datasd.Checked = False
            End If

            If IsDate(base.AjustaNulo(dt.Rows(0)("PRSD_dt_ini"))) Then
                date_desde.Value = CDate(dt.Rows(0)("PRSD_dt_ini"))
                date_desde.Checked = True
            Else
                date_desde.Value = Now.Date
                date_desde.Checked = False
            End If

            If IsDate(base.AjustaNulo(dt.Rows(0)("PRSD_dt_fim"))) Then
                date_vencto.Value = CDate(dt.Rows(0)("PRSD_dt_fim"))
                date_vencto.Checked = True
            Else
                date_vencto.Value = Now.Date
                date_vencto.Checked = False
            End If


            'If orgao <> 0 Then
            '    text_arquivo1.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_local_documento"))
            '    text_arquivo2.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_nome_documento"))
            '    text_arquivo3.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_rede_documento"))
            'End If

            Dim dtoCOVE As New DTO.tb_COVE_controle_vencimento
            Dim bllCOVE As New BLL.tb_COVE_controle_vencimento
            Dim dtCOVE As DataTable
            bllCOVE.ConnectionString = connection
            bllCOVE.XMLPath = xmlpath
            dtoCOVE.PROC_cd_processo = processo
            dtoCOVE.ORGA_nm_orgao = orgao
            dtoCOVE.COVE_nm_tipo_documento = tipo_documento
            dtoCOVE.COVE_id_documento = dt.Rows(0)("PRSD_nm_sd").ToString.Trim
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
    Private Sub LimpaDetalhes()
        text_numero.Text = ""
        text_processo.Text = ""
        text_doc.Text = ""


        combo_obj.SelectedIndex = -1
        combo_situacao.SelectedIndex = -1
        combo_situacao.Text = ""
        combo_obj.Text = ""

        date_datasd.Checked = False
        date_desde.Checked = False
        date_vencto.Checked = False


        text_ini.Text = ""
        text_int.Text = ""

        'text_arquivo1.Text = ""
        'text_arquivo2.Text = ""
        'text_arquivo3.Text = ""

        'date_datasd.MinDate = N
        'date_datasd.MaxDate = N
        'date_desde.MinDate = N
        'date_desde.MaxDate = N
        'date_vecto.MinDate = N
        'date_vecto.MaxDate = N
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