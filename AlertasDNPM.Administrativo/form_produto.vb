Public Class form_produto

    Public orgao As Integer = -1 'orgao
    Public modo As Integer = 0 'insert ou update
    Public mp As String = ""  'no caso do update, guarda numero da mp
    Public processo As String = "" 'no caso do update, guarda numero do processo
    Public numero As String = "" 'no caso do update, guarda numero do titulo
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

        Dim dto As New DTO.tb_PRPD_processo_produto
        Dim bll As New BLL.tb_PRPD_processo_produto
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
        dto.MPRI_nm_mprima = mp

        If IsNumeric(text_volume.Text) Then
            dto.PRPD_vl_produto = CDbl(text_volume.Text)
        Else
            dto.PRPD_vl_produto = 0
        End If

       
        dto.PRPD_un_produto = combo_unidade.Text.Trim
        dto.PROD_nm_produto = combo_produto.Text.Trim
        dto.UPRD_nm_uso = combo_uso.Text.Trim

        'dto.PRSD_dt_sd = IIf(date_datasd.Checked, date_datasd.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))
        'dto.PRSD_dt_ini = IIf(date_desde.Checked, date_desde.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))

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




        Return ret

    End Function
    Private Sub salvaProduto()

        If combo_produto.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_PROD_produto
        Dim bll As New BLL.tb_PROD_produto
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)


        If dt.Select("PROD_nm_produto = '" & combo_produto.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.PROD_nm_produto = combo_produto.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub
    Private Sub salvaTipoUso()

        If combo_uso.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_UPRD_uso_produto
        Dim bll As New BLL.tb_UPRD_uso_produto
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)


        If dt.Select("UPRD_nm_uso = '" & combo_uso.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.UPRD_nm_uso = combo_uso.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub
    Private Sub salvaUnidadeMedida()

        If combo_unidade.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_UNME_unidade_medida
        Dim bll As New BLL.tb_UNME_unidade_medida
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("UNME_nm_unidade = '" & combo_unidade.Text.Trim & "' and UNME_nm_tipo = 'PR'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.UNME_nm_unidade = combo_unidade.Text.Trim
            dto.UNME_nm_tipo = "PR"
            dto.UNME_ds_unidade = combo_unidade.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub

    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                salvaProduto()
                salvaUnidadeMedida()
                salvaTipoUso()

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
        Dim bll As New BLL.tb_PROD_produto
        Dim dto As New DTO.tb_PROD_produto
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        dt = bll.GetData(dto)
        combo_produto.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_produto.Items.Add(dr("PROD_nm_produto"))
        Next


        Dim bll2 As New BLL.tb_UNME_unidade_medida
        Dim dto2 As New DTO.tb_UNME_unidade_medida
        bll2.ConnectionString = connection
        bll2.XMLPath = xmlpath

        dto2.UNME_nm_tipo = "PR"
        dt = bll2.GetData(dto2)
        combo_unidade.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_unidade.Items.Add(dr("UNME_nm_unidade"))
        Next


        Dim bll3 As New BLL.tb_UPRD_uso_produto
        Dim dto3 As New DTO.tb_UPRD_uso_produto
        bll3.ConnectionString = connection
        bll3.XMLPath = xmlpath

        dt = bll3.GetData(dto3)
        combo_uso.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_uso.Items.Add(dr("UPRD_nm_uso"))
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

            combo_produto.Enabled = True

            'group_documento.Enabled = orgao <> 0


            If modo = 2 Then
                CarregaDetalhes(processo, mp, numero, orgao)
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
                                ByVal mp As String, _
                                ByVal numero As String, _
                                ByVal orgao As Integer)

        Dim dt As DataTable
        Dim dto As New DTO.tb_PRPD_processo_produto
        Dim bll As New BLL.tb_PRPD_processo_produto

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.MPRI_nm_mprima = mp
        dto.PROD_nm_produto = numero
        dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            combo_produto.Enabled = False
            text_volume.Text = dt.Rows(0)("PRPD_vl_produto").ToString.Trim
            combo_produto.Text = base.AjustaNulo(dt.Rows(0)("PROD_nm_produto"))
            combo_unidade.Text = base.AjustaNulo(dt.Rows(0)("PRPD_un_produto"))
            combo_uso.Text = base.AjustaNulo(dt.Rows(0)("UPRD_nm_uso"))

            'If IsDate(base.AjustaNulo(dt.Rows(0)("PRSD_dt_sd"))) Then
            '    date_datasd.Value = CDate(dt.Rows(0)("PRSD_dt_sd"))
            '    date_datasd.Checked = True
            'Else
            '    date_datasd.Value = Now.Date
            '    date_datasd.Checked = False
            'End If

            'If IsDate(base.AjustaNulo(dt.Rows(0)("PRSD_dt_ini"))) Then
            '    date_desde.Value = CDate(dt.Rows(0)("PRSD_dt_ini"))
            '    date_desde.Checked = True
            'Else
            '    date_desde.Value = Now.Date
            '    date_desde.Checked = False
            'End If

            'If orgao <> 0 Then
            '    text_arquivo1.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_local_documento"))
            '    text_arquivo2.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_nome_documento"))
            '    text_arquivo3.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_rede_documento"))
            'End If


            modo = 2
        Else
            combo_produto.Enabled = True
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub LimpaDetalhes()
        text_volume.Text = ""
        combo_produto.SelectedIndex = -1
        combo_unidade.SelectedIndex = -1
        combo_uso.SelectedIndex = -1
        combo_unidade.Text = ""
        combo_produto.Text = ""
        combo_uso.Text = ""

        'date_datasd.Checked = False
        'date_desde.Checked = False

        'text_arquivo1.Text = ""
        'text_arquivo2.Text = ""
        'text_arquivo3.Text = ""

        'date_datasd.MinDate = N
        'date_datasd.MaxDate = N
        'date_desde.MinDate = N
        'date_desde.MaxDate = N
    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            combo_produto.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

   
End Class