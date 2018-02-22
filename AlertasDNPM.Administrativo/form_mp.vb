Imports BrightIdeasSoftware

Public Class form_mp

    Public orgao As Integer = -1 'orgao
    Public modo As Integer = 0 'insert ou update
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
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PRMP_processo_mprima
        Dim bll As New BLL.tb_PRMP_processo_mprima
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

        If IsNumeric(text_volume.Text) Then
            dto.PRMP_vl_mprima = CDbl(text_volume.Text)
        Else
            dto.PRMP_vl_mprima = 0
        End If


        dto.PRMP_un_mprima = combo_unidade.Text.Trim
        dto.MPRI_nm_mprima = combo_mp.Text.Trim
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
    Private Sub salvaMateriaPrima()

        If combo_mp.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_MPRI_mprima
        Dim bll As New BLL.tb_MPRI_mprima
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)


        If dt.Select("MPRI_nm_mprima = '" & combo_mp.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.MPRI_nm_mprima = combo_mp.Text.Trim
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

        If dt.Select("UNME_nm_unidade = '" & combo_unidade.Text.Trim & "' and UNME_nm_tipo = 'MP'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.UNME_nm_unidade = combo_unidade.Text.Trim
            dto.UNME_nm_tipo = "MP"
            dto.UNME_ds_unidade = combo_unidade.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub

    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                salvaMateriaPrima()
                salvaUnidadeMedida()

                sender.enabled = True
                Me.Cursor = Cursors.Arrow



                If modo = 2 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    numero = combo_mp.Text.Trim
                    modo = 2
                    ShowMessage(gettext("custom", 37), "", enErrorType.Info)
                End If

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
        Dim bll As New BLL.tb_MPRI_mprima
        Dim dto As New DTO.tb_MPRI_mprima
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        dt = bll.GetData(dto)
        combo_mp.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_mp.Items.Add(dr("MPRI_nm_mprima"))
        Next


        Dim bll2 As New BLL.tb_UNME_unidade_medida
        Dim dto2 As New DTO.tb_UNME_unidade_medida
        bll2.ConnectionString = connection
        bll2.XMLPath = xmlpath

        dto2.UNME_nm_tipo = "MP"
        dt = bll2.GetData(dto2)
        combo_unidade.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_unidade.Items.Add(dr("UNME_nm_unidade"))
        Next



    End Sub
    Private Sub form_mp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If orgao = -1 Or modo = 0 Or processo.Trim.Length = 0 Then
                Exit Sub
            End If

            If modo = 2 And numero.Trim.Length = 0 Then
                Exit Sub
            End If


            list_produto.Tag = 1 'cetesb

            MakeFormGlobal(Me)

            'SelecionaTituloJanela(orgao)

            CarregaCombos()
            LimpaDetalhes()

            combo_mp.Enabled = True

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
        Dim dto As New DTO.tb_PRMP_processo_mprima
        Dim bll As New BLL.tb_PRMP_processo_mprima

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.MPRI_nm_mprima = numero
        dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            combo_mp.Enabled = False
            text_volume.Text = dt.Rows(0)("PRMP_vl_mprima").ToString.Trim
            combo_mp.Text = base.AjustaNulo(dt.Rows(0)("MPRI_nm_mprima"))
            combo_unidade.Text = base.AjustaNulo(dt.Rows(0)("PRMP_un_mprima"))

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

            ListaProduto(CInt(list_produto.Tag), processo, numero, list_produto)


            modo = 2
        Else
            combo_mp.Enabled = True
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub LimpaDetalhes()
        text_volume.Text = ""
        combo_mp.SelectedIndex = -1
        combo_unidade.SelectedIndex = -1
        combo_unidade.Text = ""
        combo_mp.Text = ""

        'date_datasd.Checked = False
        'date_desde.Checked = False

        'text_arquivo1.Text = ""
        'text_arquivo2.Text = ""
        'text_arquivo3.Text = ""

        'date_datasd.MinDate = N
        'date_datasd.MaxDate = N
        'date_desde.MinDate = N
        'date_desde.MaxDate = N


        list_produto.Items.Clear()

    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            combo_mp.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub button_add_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_add.LinkClicked
        modoAddProduto(list_produto)
    End Sub
    Private Sub list_produto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_produto.KeyDown
        modoDelProduto(sender, e)
    End Sub
    Private Sub list_produto_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_produto.DoubleClick
        modoEditProduto(sender)
    End Sub
    Private Sub modoEditProduto(ByVal sender As Object)
        Try

            Dim code As String = ""

            If sender.SelectedIndex <> -1 And modo = 2 Then

                code = sender.SelectedItem.Text.Trim()

                form_produto.processo = processo
                form_produto.orgao = CInt(sender.Tag)
                form_produto.mp = numero
                form_produto.numero = code
                form_produto.modo = 2 'update
              

                If form_produto.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaProduto(CInt(sender.Tag), processo, numero, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub modoAddProduto(ByVal sender As Object)

        Try

            If modo = 1 Then
                ShowMessage(gettext("custom", 36), "", enErrorType.Warning)
                Exit Sub
            End If



            form_produto.processo = processo
            form_produto.mp = numero
            form_produto.numero = ""
            form_produto.orgao = CInt(sender.tag)
            form_produto.modo = 1 'insert

            If form_produto.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaProduto(CInt(sender.tag), processo, numero, sender)

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub
    Private Sub ListaProduto(ByVal Tipo As Integer, ByVal processo As String, ByVal mp As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PRPD_processo_produto
        Dim bll As New BLL.tb_PRPD_processo_produto
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = processo
        dto.MPRI_nm_mprima = mp
        dto.ORGA_nm_orgao = Tipo
        dt = bll.PagingData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ExcluirProdutosSelecionados(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As OLVListItem In sender.SelectedItems

            Dim code As String = item.Text.Trim

            If Not ExcluirProduto(processo, numero, CInt(sender.tag), code) Then
                If log.Trim.Length = 0 Then log += vbCrLf
                log += numero
                count += 1
            End If

        Next

        If count > 10 Then log = ""
        If log.Trim.Length > 0 Then
            log = gettext("custom", 9) & vbCrLf & log
        End If




    End Sub
    Private Function ExcluirProduto(ByVal processo As String, ByVal mp As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PRPD_processo_produto
        Dim bll As New BLL.tb_PRPD_processo_produto

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.MPRI_nm_mprima = mp
        dto.PROD_nm_produto = numero
        dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function
    Private Sub modoDelProduto(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try


            If e.KeyCode = Keys.Delete Then

                If modo = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirProdutosSelecionados(log, sender)
                    ListaProduto(CInt(sender.tag), processo, numero, sender)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try


    End Sub
End Class