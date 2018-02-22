Imports BrightIdeasSoftware


Public Class form_busca

    'Private panel_height As Integer = 0
    'Private panel_height2 As Integer = 0
    Public code As String = ""
    Private mode As Integer = 0
    'Private loaded As Boolean = False
    'Private loaded2 As Boolean = False
    Private cancelarbusca As Boolean = False
    Private xmlFile As String = ""

    Private Sub ChangeFilterMenuLanguage()
        Dim obj As New Apoio.Globalization
        FilterMenuBuilder.CLEAR_ALL_FILTERS_LABEL = obj.getListValue(dtMensagem, "CLEAR_ALL_FILTERS_LABEL", "filter")
        FilterMenuBuilder.APPLY_LABEL = obj.getListValue(dtMensagem, "APPLY_LABEL", "filter")
        FilterMenuBuilder.FILTERING_LABEL = obj.getListValue(dtMensagem, "FILTERING_LABEL", "filter")
    End Sub


    Private Sub ListaProcessos()

        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        dt.Columns.Add("FASE_nm_fase")
        Dim objXml As New Apoio.Globalization
        Dim dtXml As DataTable = objXml.getListData(xmlpath, "fase")
        For Each dr As DataRow In dt.Rows
            If dr("FASE_cd_fase") Is DBNull.Value Then dr("FASE_cd_fase") = "0"
            dr("FASE_nm_fase") = dtXml.Select("name = '" & dr("FASE_cd_fase") & "'")(0)("value").ToString.Trim
        Next

        list_processo.DataSource = New BindingSource(dt, dt.TableName)

    End Sub
    


    Private Sub button_down_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_down.Click
        Try
            If form_down.ShowDialog = Windows.Forms.DialogResult.OK Then
                label_data.Text = base.getFileDate(kmlDir & "\" & form_down.xmlFile)
            Else

                'Dim obj As New Apoio.Globalization
                'Dim dtUF As DataTable = obj.getListData(xmlpath, "uf")
                'Dim kmlFile As String = ""
                'Dim drUF() As DataRow = dtUF.Select("name <> '00'")

                'If drUF.Length > 0 Then
                '    'pega o primeiro arquivo que encontrar
                '    kmlFile = drUF(0)("name") & ".kml"
                '    label_data.Text = base.getFileDate(kmlDir & "\" & kmlFile)
                'End If


            End If
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    

    Private Sub CarregaCombos()
        Dim obj As New Apoio.Globalization
        Dim dt1 As DataTable = obj.getListData(xmlpath, "filtro")

 
        combo_filtro.ValueMember = "name"
        combo_filtro.DisplayMember = "value"
        combo_filtro.DataSource = dt1


    End Sub

    Private Sub customizaTooltipGrid(ByVal lista As DataListView)

        lista.CellToolTip.Font = New Font("Verdana", 8, FontStyle.Bold)
        lista.CellToolTip.BackColor = Color.LightYellow
        lista.CellToolTip.IsBalloon = False
        lista.CellToolTip.StandardIcon = ToolTipControl.StandardIcons.Info
        'lista.CellToolTip.Title = gettext("custom", 3)
        lista.CellToolTip.HasBorder = True
        lista.CellToolTip.ForeColor = Color.Black

    End Sub
    Private Sub form_busca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)

            ChangeFilterMenuLanguage()

            customizaTooltipGrid(list_processo)


            Dim obj As New Apoio.Globalization
            Dim dtUF As DataTable = obj.getListData(xmlpath, "uf")
            Dim drUF() As DataRow = dtUF.Select("name <> '00'")

            If drUF.Length > 0 Then
                'pega o primeiro arquivo que encontrar
                xmlFile = drUF(0)("name") & ".xml"
                label_data.Text = base.getFileDate(kmlDir & "\" & xmlFile)
                If label_data.Text.Trim.Length = 0 Then label_data.Text = gettext("custom", 20)
                group_base.Text = String.Format(gettext("custom", 22), label_data.Text.Trim)
            End If

            cancelarbusca = False

            CarregaCombos()
            If combo_filtro.Items.Count > 0 Then combo_filtro.SelectedIndex = 0
            text_busca.Text = ""
            'expanel_busca.IsExpanded = False
            'expanel_busca.Enabled = False
            'expanel_busca.TextCaption = gettext("custom", 10)

            text_busca.Focus()

            'panel_height = expanel_base.Height
            'panel_height2 = 338

            'loaded = True
            'loaded2 = True

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub



    
    
    
    

    
    

    



    

    

    
    

    
    
    
    

    

    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    

    

    



    
    
    'Private Sub AjustaForm1()
    '    Select Case expanel_base.IsExpanded
    '        Case True
    '            Me.Height = Me.Height + panel_height - 25
    '            Me.panel_command.Top = Me.panel_command.Top + panel_height - 25
    '            Me.panel_busca.Top = Me.panel_busca.Top + panel_height - 25
    '            Me.expanel_busca.Top = Me.expanel_busca.Top + panel_height - 25
    '        Case False
    '            Me.Height = Me.Height - panel_height + 25
    '            Me.panel_command.Top = Me.panel_command.Top - panel_height + 25
    '            Me.panel_busca.Top = Me.panel_busca.Top - panel_height + 25
    '            Me.expanel_busca.Top = Me.expanel_busca.Top - panel_height + 25
    '    End Select

    'End Sub

    'Private Sub AjustaForm2()
    '    Select Case expanel_busca.IsExpanded
    '        Case True
    '            Me.Height = Me.Height + panel_height2 - 25
    '            Me.panel_command.Top = Me.panel_command.Top + panel_height2 - 25
    '            'Me.panel_busca.Top = Me.panel_busca.Top + panel_height2 - 25
    '        Case False
    '            Me.Height = Me.Height - panel_height2 + 25
    '            Me.panel_command.Top = Me.panel_command.Top - panel_height2 + 25
    '            'Me.panel_busca.Top = Me.panel_busca.Top - panel_height2 + 25
    '    End Select

    'End Sub
    'Private Sub expanel_lista_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If loaded Then AjustaForm1()
    '    Catch ex As Exception
    '        ShowMessage(ex, 0)
    '    End Try
    'End Sub
    'Private Sub expanel_busca_ClientSizeChanged(ByVal sender As Object, ByVal e As System.EventArgs)
    '    Try
    '        If loaded2 Then AjustaForm2()
    '    Catch ex As Exception
    '        ShowMessage(ex, 0)
    '    End Try
    'End Sub


   
    Private Sub text_filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_filter.TextChanged
        Me.TimedFilter(Me.list_processo, text_filter.Text)
    End Sub

    Private Sub TimedFilter(ByVal olv As DataListView, ByVal txt As String)
        Me.TimedFilter(olv, txt, 0)
    End Sub
    Private Sub TimedFilter(ByVal olv As ObjectListView, ByVal txt As String, ByVal matchKind As Integer)
        Dim filter As TextMatchFilter = Nothing

        If Not [String].IsNullOrEmpty(txt) Then

            If matchKind < 0 Or matchKind > 2 Then matchKind = 0

            Select Case matchKind
                Case 0
                    filter = TextMatchFilter.Contains(olv, txt)
                    Exit Select
                Case 1
                    filter = TextMatchFilter.Prefix(olv, txt)
                    Exit Select
                Case 2
                    filter = TextMatchFilter.Regex(olv, txt)
                    Exit Select
            End Select
        End If


        ' Setup a default renderer to draw the filter matches
        If filter Is Nothing Then
            olv.DefaultRenderer = Nothing
        Else

            ' Uncomment this line to see how the GDI+ rendering looks
            'olv.DefaultRenderer = new HighlightTextRenderer { Filter = filter, UseGdiTextRendering = false };
            olv.DefaultRenderer = New HighlightTextRenderer(filter)
        End If

        ' Some lists have renderers already installed
        Dim highlightingRenderer As HighlightTextRenderer = TryCast(olv.GetColumn(0).Renderer, HighlightTextRenderer)
        If highlightingRenderer IsNot Nothing Then
            highlightingRenderer.Filter = filter
        End If

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()
        olv.AdditionalFilter = filter
        'olv.Invalidate();
        stopWatch.[Stop]()

        Dim objects As IList = TryCast(olv.Objects, IList)
        'If objects Is Nothing Then
        '    Me.toolStripStatusLabel1.Text = [String].Format("Filtered in {0}ms", stopWatch.ElapsedMilliseconds)
        'Else
        '    Me.toolStripStatusLabel1.Text = [String].Format("Filtered {0} items down to {1} items in {2}ms", objects.Count, olv.Items.Count, stopWatch.ElapsedMilliseconds)
        'End If

        Me.label_count.Text = [String].Format("{0} processos listados", olv.Items.Count)

    End Sub




    Private Sub button_clear_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_clear_filter.Click
        Try

            text_filter.Text = ""

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub





    

    


    

   
  
    
    Private Function criaTabelaDados() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add("processo")
        dt.Columns.Add("id")
        dt.Columns.Add("numero")
        dt.Columns.Add("ano")
        dt.Columns.Add("area")
        dt.Columns.Add("fase")
        dt.Columns.Add("evento")
        dt.Columns.Add("titular")
        dt.Columns.Add("substancia")
        dt.Columns.Add("uso")
        dt.Columns.Add("uf")
        dt.Columns.Add("link")
        dt.Columns.Add("codigo_fase")

        Return dt
    End Function
    Private Sub statusNormal()
        'nenhum processo encontrado
        'pbar.Value = 0
        'pbar.Minimum = 0
        'pbar.Maximum = 0
        Me.label_count.Text = ""
        cancelarbusca = False
        button_busca.Enabled = True
        Me.Cursor = Cursors.Arrow
        ' button_cancel.Visible = False
        'expanel_busca.IsExpanded = False
        'expanel_busca.Enabled = False
        'expanel_busca.TextCaption = gettext("custom", 12)
        button_busca.Text = gettext("custom", 15)
        ShowMessage(gettext("custom", 12), "", enErrorType.Warning)
    End Sub

    Private Sub button_busca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_busca.Click
        Try


            If text_busca.Text.Trim.Length = 0 Or combo_filtro.SelectedIndex = -1 Or combo_filtro.Items.Count = 0 Then
                ShowMessage(gettext("custom", 11), "", enErrorType.Warning)
                Exit Sub
            End If

            If Not System.IO.File.Exists(kmlDir & "\" & xmlFile) Then
                ShowMessage(gettext("custom", 19), "", enErrorType.Warning)
                Exit Sub
            End If

            button_busca.Enabled = False
            button_busca.Text = gettext("custom", 14)
            Me.Cursor = Cursors.WaitCursor
            Application.DoEvents()
            Me.Refresh()

            Dim obj As New BLL.Rotina(xmlpath)
            Dim campo As String = combo_filtro.SelectedItem.ToString.Trim
            Dim valor As String = text_busca.Text.Trim
            Dim objFase As New Apoio.Globalization
            Dim dtFase As DataTable = objFase.getListData(xmlpath, "fase")

            Dim ds As New DataSet
            Dim dt As DataTable
            Me.Cursor = Cursors.Arrow

            'busca processos existentes no sistema
            Dim dto As New DTO.tb_PROC_processo
            Dim dtProc As DataTable
            Dim bll As New BLL.tb_PROC_processo
            bll.ConnectionString = connection
            bll.XMLPath = xmlpath
            dtProc = bll.GetData(dto)



            ds.ReadXml(kmlDir & "\" & xmlFile)
            If ds.Tables.Count = 0 Then
                statusNormal()
                Exit Sub
            End If

            dt = ds.Tables(0)

            'pbar.Value = 0
            'pbar.Minimum = 0
            'pbar.Maximum = dt.Rows.Count
            'button_cancel.Visible = True

            If dt Is Nothing Then
                statusNormal()
                Exit Sub
            End If

            If dt.Rows.Count = 0 Then
                statusNormal()
                Exit Sub
            End If

            Dim dtFiltro As DataTable
            Dim drFiltro() As DataRow
            Dim filtro As String = ""

            Select Case combo_filtro.SelectedIndex
                Case 0 : filtro = "fase like '%" & text_busca.Text.Trim & "%'"
                Case 1 : filtro = "titular like '%" & text_busca.Text.Trim & "%'"
                Case 2 : filtro = "processo like '%" & text_busca.Text.Trim & "%'"
                Case 3 : filtro = "ano like '%" & text_busca.Text.Trim & "%'"
                Case 4 : filtro = "substancia like '%" & text_busca.Text.Trim & "%'"
                Case 5 : filtro = "evento like '%" & text_busca.Text.Trim & "%'"
                Case 6 : filtro = "uf like '%" & text_busca.Text.Trim & "%'"
            End Select

            'remove processos existentes no sistema
            Dim lista As String = ""
            If dtProc.Rows.Count > 0 Then
                For Each dr As DataRow In dtProc.Rows
                    lista += "'" & dr("PROC_cd_processo") & "',"
                Next

                If lista.Trim.Length > 0 Then
                    lista = lista.Substring(0, lista.Trim.Length - 1)
                    filtro += " and processo not in (" & lista & ")"
                End If

            End If

            drFiltro = dt.Select(filtro)

            If drFiltro.Length = 0 Then
                statusNormal()
                list_processo.DataSource = New BindingSource(drFiltro, "")
                Exit Sub
            End If

            dtFiltro = drFiltro.CopyToDataTable

            list_processo.DataSource = New BindingSource(dtFiltro, dtFiltro.TableName)
            'expanel_busca.IsExpanded = True
            'expanel_busca.Enabled = True
            'expanel_busca.TextCaption = String.Format(gettext("custom", 13), dtFiltro.Rows.Count)

            'pbar.Value = 0
            'pbar.Minimum = 0
            'pbar.Maximum = 0



            cancelarbusca = False
            button_busca.Enabled = True
            Me.Cursor = Cursors.Arrow
            'button_cancel.Visible = False
            button_busca.Text = gettext("custom", 15)
            Me.label_count.Text = [String].Format("{0} processos listados", dtFiltro.Rows.Count)





        Catch ex As Exception
            ' pbar.Value = 0
            ' pbar.Minimum = 0
            ' pbar.Maximum = 0
            ' button_cancel.Visible = False
            button_busca.Enabled = True
            Me.Cursor = Cursors.Arrow
            button_busca.Text = gettext("custom", 15)
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub tratarHyperlink(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs)

        Try

            Dim url As String = ""
            Dim sInfo As ProcessStartInfo
            Dim field_local As String = ""
            'Dim field_rede As String = ""

            'pegaCamposUrl(CInt(sender.tag), sender.name, field_local, field_rede)

            field_local = "link"

            'cancela o disparo evento padrão (dentro do datalistview)
            e.Handled = True

            Me.Cursor = Cursors.WaitCursor

            If e.Url.Trim.Length > 0 Then

                'tenta o caminho local
                Try
                    url = CType(e.Item.RowObject, DataRowView).Row(field_local).ToString.Trim
                    sInfo = New ProcessStartInfo(url)
                    Process.Start(sInfo)
                Catch ex As Exception
                    ShowMessage(ex, 0)
                    ''se der erro, tenta o caminho na rede
                    'Try
                    '    url = CType(e.Item.RowObject, DataRowView).Row(field_rede).ToString.Trim
                    '    sInfo = New ProcessStartInfo(url)
                    '    Process.Start(sInfo)
                    'Catch ex2 As Exception
                    '    'se der erro, exibe erro
                    '    Me.Cursor = Cursors.Arrow
                    '    ShowMessage(ex2, 0)
                    'End Try
                End Try

                Me.Cursor = Cursors.Arrow

            Else
                Me.Cursor = Cursors.Arrow
                ShowMessage(gettext("message", 3), "", enErrorType.Warning)
            End If


        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ShowMessage(ex, 0)
        End Try

    End Sub
    Private Sub list_processo_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_processo.HyperlinkClicked
        Try
            tratarHyperlink(sender, e)
        Catch ex As Exception

        End Try
    End Sub

   


   

  

   

   

    
    

    'Private Sub button_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try

    '        cancelarbusca = True

    '    Catch ex As Exception
    '        ShowMessage(ex, 0)
    '    End Try
    'End Sub

  

    Private Sub list_processo_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_processo.SelectionChanged
        Dim maxSel As Integer = 500

        If list_processo.SelectedItems.Count > maxSel Then
            list_processo.MultiSelect = False
            ShowMessage(String.Format(gettext("custom", 21), maxSel), "", enErrorType.Warning)

            For Each item As OLVListItem In list_processo.Items
                If item.Selected Then item.Selected = False
            Next

        Else

            list_processo.MultiSelect = True

        End If

    End Sub

   
    'Private Sub center_form(ByVal frm As Form)
    '    Application.DoEvents()
    '    frm.Location = New Point(form_main.Width / 2 - frm.Width / 2, (form_main.Height - form_main.tool_main.Height - 10) / 2 - frm.Height / 2)
    'End Sub
    'Private Sub expanel_busca_PanelExpanded() Handles expanel_busca.PanelExpanded
    '    If loaded2 Then
    '        AjustaForm2()
    '        expanel_busca.Refresh()
    '        center_form(Me)
    '    End If

    'End Sub
    'Private Sub expanel_busca_PanelContracted() Handles expanel_busca.PanelContracted
    '    If loaded2 Then
    '        AjustaForm2()
    '        expanel_busca.Refresh()
    '        center_form(Me)
    '    End If

    'End Sub

    Private Sub button_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_add.Click
        Try

            If list_processo.CheckedItems.Count = 0 Then
                ShowMessage(gettext("custom", 23), "", enErrorType.Warning)
                Exit Sub
            End If


            Dim dto As New DTO.tb_PROC_processo
            Dim bll As New BLL.tb_PROC_processo
            Dim dt As DataTable
            Dim dr() As DataRow
            Dim filtro As String = ""
            Dim ret As Boolean = False
            'Dim dtLista As DataTable = CType(list_processo.DataSource, BindingSource).DataSource
            Dim drLista As DataRow
            Dim log As String = ""
            Dim erroLog As Boolean = False

            'If dtLista Is Nothing Then Exit Sub
            'If dtLista.Rows.Count = 0 Then Exit Sub

            bll.ConnectionString = connection
            bll.XMLPath = xmlpath
            dt = bll.GetData(dto)

            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user

            button_add.Enabled = False
            button_add.Text = gettext("custom", 26)

            For Each item As OLVListItem In list_processo.CheckedItems

                Try

                    filtro = "PROC_cd_processo = '" & item.Text.Trim & "'"
                    dr = dt.Select(filtro)

                    'If dtLista.Select("processo = '" & item.Text.Trim & "'").Length = 0 Then
                    'GoTo prox
                    'End If

                    'drLista = dtLista.Select("processo = '" & item.Text.Trim & "'")(0)

                    drLista = CType(item.RowObject, DataRowView).Row

                    If dr.Length = 0 Then

                        dto.FASE_cd_fase = drLista("codigo_fase")
                        dto.PROC_cd_processo = drLista("processo")
                        dto.PROC_ds_area = drLista("area")
                        dto.PROC_ds_link = drLista("link")
                        dto.PROC_ds_substancia = drLista("substancia")
                        dto.PROC_ds_titular = drLista("titular")
                        dto.PROC_ds_ultimo_evento = drLista("evento")
                        dto.PROC_ds_uso = drLista("uso")
                        dto.PROC_fl_tipo_inclusao = "B"
                        dto.PROC_id_processo = drLista("id")
                        dto.PROC_nm_processo = drLista("numero")
                        dto.PROC_vl_ano = drLista("ano")
                        dto.PROC_cd_prioridade = 1

                        ret = bll.InsertData(dto)
                        log += item.Text.Trim & " - " & gettext("custom", 28) & vbCrLf

                        If ret Then
                            'associa alertas nativos
                            incluirAlertas(item.Text.Trim)

                            'associa operadores nativos
                            incluirOperadores(item.Text.Trim)
                        End If



                    End If

                Catch ex As Exception
                    erroLog = True
                    log += item.Text.Trim & " - " & ex.Message & vbCrLf
                End Try

prox:
            Next


            button_add.Enabled = True
            button_add.Text = gettext("custom", 25)

            If Not erroLog Then
                ShowMessage(gettext("custom", 24), "", enErrorType.Info)
            Else
                ShowMessage(gettext("custom", 27) & vbCrLf & log, "", enErrorType.Warning)
            End If

           


        Catch ex As Exception
            button_add.Enabled = True
            button_add.Text = gettext("custom", 25)
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub incluirAlertas(ByVal processo As String)

        Dim dto As New DTO.tb_PRAL_processo_alerta
        Dim bll As New BLL.tb_PRAL_processo_alerta
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        Dim dtAler As DataTable
        Dim dtoAler As New DTO.tb_ALER_alerta
        Dim bllAler As New BLL.tb_ALER_alerta
        bllAler.ConnectionString = connection
        bllAler.XMLPath = xmlpath
        dtAler = bllAler.GetData(dtoAler)


        'inclui alertas selecionados na lista 
        For Each drAler As DataRow In dtAler.Rows
            Try
                Select Case drAler("ALER_fl_sistema")
                    Case "S"
                        dto.ALER_nm_alerta = drAler("ALER_nm_alerta")
                        dto.PROC_cd_processo = processo
                        dto.PRAL_fl_manutencao = "S"
                        dto.AUDT_dt_alteracao = Now
                        dto.AUDT_nm_usuario_alteracao = default_user
                        dto.AUDT_dt_inclusao = Now
                        dto.AUDT_nm_usuario_inclusao = default_user
                        bll.InsertData(dto)
                    Case "N"
                        dto.ALER_nm_alerta = drAler("ALER_nm_alerta")
                        dto.PROC_cd_processo = processo
                        bll.DeleteData(dto)
                End Select
            Catch ex As Exception
                Dim a As Integer = 0
            End Try
        Next
    End Sub

    Private Sub incluirOperadores(ByVal processo As String)
        Dim dto As New DTO.tb_PROP_processo_operador
        Dim bll As New BLL.tb_PROP_processo_operador
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        Dim dtOper As DataTable
        Dim dtoOper As New DTO.tb_OPER_operador
        Dim bllOper As New BLL.tb_OPER_operador
        bllOper.ConnectionString = connection
        bllOper.XMLPath = xmlpath
        dtOper = bllOper.GetData(dtoOper)


        'inclui operador(es) selecionado(s) na lista 
        For Each drOper As DataRow In dtOper.Rows
            Try
                Select Case drOper("OPER_fl_alerta_nativo")
                    Case "S"
                        dto.OPER_cd_operador = drOper("OPER_cd_operador")
                        dto.PROC_cd_processo = processo
                        dto.AUDT_dt_alteracao = Now
                        dto.AUDT_nm_usuario_alteracao = default_user
                        dto.AUDT_dt_inclusao = Now
                        dto.AUDT_nm_usuario_inclusao = default_user
                        bll.InsertData(dto)
                    Case "N"
                        dto.OPER_cd_operador = drOper("OPER_cd_operador")
                        dto.PROC_cd_processo = processo
                        bll.DeleteData(dto)
                End Select
            Catch ex As Exception
                Dim a As Integer = 0
            End Try
        Next
    End Sub

    Private Sub text_busca_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text_busca.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                button_busca_Click(sender, e)
            End If
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

   
    Private Sub list_processo_CellToolTipShowing(ByVal sender As Object, ByVal e As BrightIdeasSoftware.ToolTipShowingEventArgs) Handles list_processo.CellToolTipShowing
        Try

            Dim descricao As String = ""
            Dim chars As Integer = 120

            If e.ColumnIndex = 1 Or e.ColumnIndex = 2 Or e.ColumnIndex = 3 Or e.ColumnIndex = 4 Then
                descricao = base.PulaLinhaACadaNCaracteres(e.SubItem.Text.Trim(), chars, vbCrLf)
            End If


            e.Text = descricao

        Catch ex As Exception

        End Try

    End Sub

    Private Sub text_busca_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_busca.TextChanged

    End Sub
End Class