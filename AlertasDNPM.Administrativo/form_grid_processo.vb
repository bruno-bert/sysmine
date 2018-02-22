Imports BrightIdeasSoftware
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports System.Xml
Imports GMap.NET
Imports System.Globalization

Public Class form_grid_processo

    Private mode As Integer = 0
    Private loaded As Boolean = False
    Private panel_height As Integer
    Private isexpanded As Boolean = False
    Private sizeToExpand As Integer = 220
    Private Sub ChangeFilterMenuLanguage()
        Dim obj As New Apoio.Globalization
        FilterMenuBuilder.CLEAR_ALL_FILTERS_LABEL = obj.getListValue(dtMensagem, "CLEAR_ALL_FILTERS_LABEL", "filter")
        FilterMenuBuilder.APPLY_LABEL = obj.getListValue(dtMensagem, "APPLY_LABEL", "filter")
        FilterMenuBuilder.FILTERING_LABEL = obj.getListValue(dtMensagem, "FILTERING_LABEL", "filter")
    End Sub


    Public Sub ListaProcessos()

        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        dt.Columns.Add("FASE_nm_fase")
        dt.Columns.Add("PROC_cd_ds_prioridade")
        Dim objXml As New Apoio.Globalization
        Dim dtXml As DataTable = objXml.getListData(xmlpath, "fase")
        For Each dr As DataRow In dt.Rows
            If dr("FASE_cd_fase") Is DBNull.Value Then dr("FASE_cd_fase") = "0"
            dr("FASE_nm_fase") = dtXml.Select("name = '" & dr("FASE_cd_fase") & "'")(0)("value").ToString.Trim
        Next

        Dim dtXml2 As DataTable = objXml.getListData(xmlpath, "prioridade")
        For Each dr As DataRow In dt.Rows
            If dr("PROC_cd_prioridade") Is DBNull.Value Then dr("PROC_cd_prioridade") = "1"
            dr("PROC_cd_ds_prioridade") = dr("PROC_cd_prioridade") & " - " & dtXml2.Select("name = '" & dr("PROC_cd_prioridade") & "'")(0)("value").ToString.Trim
        Next

        list_processo.DataSource = New BindingSource(dt, dt.TableName)

    End Sub


    Private Sub form_grid_processo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)

            ChangeFilterMenuLanguage()


            ListaProcessos()

            If list_processo.Items.Count > 0 Then
                list_processo.SelectedIndex = 0
            End If

            'panel_height = expanel_lista.Height
            loaded = True

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub


    Private Sub ExcluirProcessosSelecionados(ByRef log As String)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In list_processo.SelectedItems

            Dim code As String = item.Text.Trim

            If Not Excluir(code) Then
                If log.Trim.Length = 0 Then log += vbCrLf
                log += code
                count += 1
            End If

        Next

        If count > 10 Then log = ""
        If log.Trim.Length > 0 Then
            log = gettext("custom", 9) & vbCrLf & log
        End If



    End Sub

    Private Sub list_processo_CellEditStarting(ByVal sender As Object, ByVal e As BrightIdeasSoftware.CellEditEventArgs) Handles list_processo.CellEditStarting
        'If (e.Value Is Color) Then
        Dim a As Integer = 0
        '    Dim cce As ColorCellEditor = New ColorCellEditor()
        '    cce.Bounds = e.CellBounds
        '    cce.Value = e.Value
        '    e.Control = cce
        'End If


    End Sub

    Private Sub list_processo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_processo.KeyDown
        Try


            If e.KeyCode = Keys.Delete Then

                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirProcessosSelecionados(log)
                    ListaProcessos()

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub list_processo_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles list_processo.MouseDoubleClick
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then

                If list_processo.SelectedIndex <> -1 Then

                    Dim id As String = list_processo.SelectedItem.Text

                    Me.Text = String.Format(gettext("custom", 35), gettext("custom", 33) & ": " & id)

                    Me.Cursor = Cursors.WaitCursor
                    form_processo.processo = id
                    form_processo.mode = 2
                    form_processo.MdiParent = form_main
                    form_processo.Show()
                    Me.Cursor = Cursors.Arrow

                Else
                    Me.Cursor = Cursors.Arrow
                    Me.Text = String.Format(gettext("custom", 35), gettext("custom", 34))

                End If

            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ShowMessage(ex, 0)
        End Try
    End Sub



    Private Sub list_processo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_processo.SelectedIndexChanged
        Try
            If list_processo.SelectedIndex <> -1 Then

                Dim id As String = list_processo.SelectedItem.Text

                Me.Text = String.Format(gettext("custom", 35), gettext("custom", 33) & ": " & id)

                'form_processo.processo = id

            Else

                Me.Text = String.Format(gettext("custom", 35), gettext("custom", 34))

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub button_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_add.Click
        Try
            mode = 1
            form_processo.processo = ""
            form_processo.mode = mode
            form_processo.MdiParent = form_main
            form_processo.Show()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub


    Private Function empresaCadastrada(ByVal empresa As String) As Boolean
        Dim dt As DataTable
        Dim bll As New BLL.tb_EMPR_empresa
        Dim dto As New DTO.tb_EMPR_empresa

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.EMPR_ds_empresa = empresa
        dt = bll.PagingData(dto)
        Return dt.Rows.Count


    End Function
    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function Excluir(ByVal code As String) As Boolean
        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = code
        Return bll.DeleteData(dto)

    End Function

   
    Private Sub text_filter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles text_filter.TextChanged
        Me.TimedFilter(Me.list_processo, text_filter.Text.Trim)
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

        'Dim objects As IList = TryCast(olv.Objects, IList)
        'If objects Is Nothing Then
        '    Me.toolStripStatusLabel1.Text = [String].Format("Filtered in {0}ms", stopWatch.ElapsedMilliseconds)
        'Else
        '    Me.toolStripStatusLabel1.Text = [String].Format("Filtered {0} items down to {1} items in {2}ms", objects.Count, olv.Items.Count, stopWatch.ElapsedMilliseconds)
        'End If
    End Sub




    Private Sub button_clear_filter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_clear_filter.Click
        Try

            text_filter.Text = ""

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub center_form(ByVal frm As Form)
        Application.DoEvents()
        frm.Location = New Point(Me.Width / 2 - frm.Width / 2, (Me.Height) / 2 - frm.Height / 2)
    End Sub

    Private Sub pegaCamposUrl(ByVal orgao As Integer, ByVal name As String, ByRef field_local As String, ByRef field_rede As String)

        field_local = ""
        field_rede = ""

        Select Case orgao
            Case 0
                If name.Contains("condicao") Then
                    field_local = "PCON_ds_local_documento"
                    field_rede = "PCON_ds_rede_documento"
                Else

                    If name.Contains("titulo") Then
                        field_local = "PTIT_ds_local_documento"
                        field_rede = "PTIT_ds_rede_documento"
                    Else
                        field_local = "PDOC_ds_local_documento"
                        field_rede = "PDOC_ds_rede_documento"
                    End If
                End If

            Case 1
                If name.Contains("titulo") Then
                    field_local = "PTIT_ds_local_documento"
                    field_rede = "PTIT_ds_rede_documento"
                Else
                    field_local = "PDOC_ds_local_documento"
                    field_rede = "PDOC_ds_rede_documento"
                End If
            Case 2
                If name.Contains("titulo") Then
                    field_local = "PTIT_ds_local_documento"
                    field_rede = "PTIT_ds_rede_documento"
                Else

                    If name.Contains("info") Then
                        field_local = "PINF_ds_local_documento"
                        field_rede = "PINF_ds_rede_documento"
                    Else
                        field_local = "PDOC_ds_local_documento"
                        field_rede = "PDOC_ds_rede_documento"
                    End If

                End If
            Case 3
                If name.Contains("titulo") Then
                    field_local = "PTIT_ds_local_documento"
                    field_rede = "PTIT_ds_rede_documento"
                Else
                    If name.Contains("info") Then
                        field_local = "PINF_ds_local_documento"
                        field_rede = "PINF_ds_rede_documento"
                    Else
                        field_local = "PDOC_ds_local_documento"
                        field_rede = "PDOC_ds_rede_documento"
                    End If
                End If
            Case 4
                If name.Contains("titulo") Then
                    field_local = "PTIT_ds_local_documento"
                    field_rede = "PTIT_ds_rede_documento"
                Else
                    If name.Contains("info") Then
                        field_local = "PINF_ds_local_documento"
                        field_rede = "PINF_ds_rede_documento"
                    Else
                        field_local = "PDOC_ds_local_documento"
                        field_rede = "PDOC_ds_rede_documento"
                    End If
                End If
            Case 5
                If name.Contains("titulo") Then
                    field_local = "PTIT_ds_local_documento"
                    field_rede = "PTIT_ds_rede_documento"
                Else
                    If name.Contains("info") Then
                        field_local = "PINF_ds_local_documento"
                        field_rede = "PINF_ds_rede_documento"
                    Else
                        field_local = "PDOC_ds_local_documento"
                        field_rede = "PDOC_ds_rede_documento"
                    End If
                End If
            Case 6
                If name.Contains("titulo") Then
                    field_local = "PTIT_ds_local_documento"
                    field_rede = "PTIT_ds_rede_documento"
                Else
                    If name.Contains("info") Then
                        field_local = "PINF_ds_local_documento"
                        field_rede = "PINF_ds_rede_documento"
                    Else
                        field_local = "PDOC_ds_local_documento"
                        field_rede = "PDOC_ds_rede_documento"
                    End If
                End If
        End Select



    End Sub
    Private Sub tratarHyperlink(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs)

        Try

            Dim url As String = ""
            Dim sInfo As ProcessStartInfo
            Dim field_local As String = ""
            Dim field_rede As String = ""

            pegaCamposUrl(CInt(sender.tag), sender.name, field_local, field_rede)

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
                    'se der erro, tenta o caminho na rede
                    Try
                        url = CType(e.Item.RowObject, DataRowView).Row(field_rede).ToString.Trim
                        sInfo = New ProcessStartInfo(url)
                        Process.Start(sInfo)
                    Catch ex2 As Exception
                        'se der erro, exibe erro
                        Me.Cursor = Cursors.Arrow
                        ShowMessage(ex2, 0)
                    End Try
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


    Private Sub resizeform(ByVal expand As Boolean, Optional ByVal add As Boolean = False)



        Select Case expand

            Case False
                If isexpanded Then
                    isexpanded = False
                    ' tab_main.Height = tab_main.Height - sizeToExpand
                    Me.Height = Me.Height - sizeToExpand
                End If
            Case True

                If Not isexpanded Then
                    isexpanded = True
                    ' tab_main.Height = tab_main.Height + sizeToExpand
                    Me.Height = Me.Height + sizeToExpand
                End If

        End Select

    End Sub





    'Private Sub expanel_lista_PanelExpanded()
    '    Try
    '        If Not expanel_lista.IsExpanded Then
    '            expanel_lista.IsExpanded = True
    '        End If

    '    Catch ex As Exception

    '    End Try
    'End Sub

    Private Sub button_report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_report.Click
        Try



            'If text_name.Text.Trim.Length = 0 Or 
            If list_processo.SelectedItems.Count = 0 Or mode = 1 Then
                ShowMessage(gettext("custom", 40), "", enErrorType.Info)
                Exit Sub
            End If

            Me.Cursor = Cursors.WaitCursor
            button_report.Enabled = False
            button_report.Text = "Aguarde..."
            Me.Refresh()

            GerarRelatorio()

            Me.Cursor = Cursors.Arrow
            button_report.Enabled = True
            button_report.Text = "Gerar Relatório"
            Me.Refresh()

        Catch ex As Exception
            button_report.Text = "Gerar Relatório"
            button_report.Enabled = True
            Me.Cursor = Cursors.Arrow
            Me.Refresh()
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function PegaPontos(ByVal node As XmlNode, _
                              ByVal nsmgr As XmlNamespaceManager) As List(Of PointLatLng)


        'encontra placemark do processo
        Dim nodeCoord As XmlNode = node.SelectSingleNode(".//p:Polygon//p:outerBoundaryIs//p:LinearRing//p:coordinates", nsmgr)
        If nodeCoord Is Nothing Then Return Nothing
        Dim strCoordinates As String = nodeCoord.InnerText

        Dim delim As String = " "
        Dim vetCoord As String() = strCoordinates.Split(delim)
        Dim strLat As String = ""
        Dim strLon As String = ""
        Dim gpoints = New List(Of PointLatLng)()

        Dim j As Integer = 0
        For i As Integer = 0 To vetCoord.Count - 1
            If vetCoord(i).Contains(",") Then
                strLon = Split(vetCoord(i), ",")(0) 'strLon.ToString().Replace(",", ".")
                strLat = Split(vetCoord(i), ",")(1) 'strLat.ToString().Replace(",", ".")
                Dim lat = Double.Parse(strLat, CultureInfo.InvariantCulture)
                Dim lng = Double.Parse(strLon, CultureInfo.InvariantCulture)
                gpoints.Add(New PointLatLng(lat, lng))
            End If
        Next

        Return gpoints

    End Function
    Private Sub GerarRelatorio()


        Dim Path As String = "PROCESSO.rdlc"
        Dim parameters() As clsReport.parameter
        Dim TableName As String = "GERAL_PROCESSO"
        Dim ds As New DataSet
        Dim myReport1 As New clsReport
        Dim numeroProcesso As String = ""
        Dim retRel As String = ""
        Dim dt As DataTable
        Dim bll As Object
        Dim dto As Object
        Dim arquivoReport As String = ""
        Dim TemDadosCetesb As Boolean = False
        Dim logErro As String = ""

        Dim drPDF As DataRow
        Dim dtPDF As DataTable
        Dim nomeArquivoUnico As String = ""
        Dim exibirTela As Boolean = False 'muda se for pra exibir na tela um a um
        Dim TemPagina As Boolean = list_processo.SelectedItems.Count = 1

        Dim ImagemMapa As String = ""
        Dim caminhoImagens As String = "tmp\Images"
        Dim arquivoMapa As String = ""

        Dim i As Integer = 0

        pbar_down.Minimum = 0
        pbar_down.Maximum = list_processo.SelectedItems.Count - 1
        pbar_down.Value = 0



        If list_processo.SelectedItems.Count > 1 Then
            panel_main.Visible = True
        Else
            label_progresso.Text = ""
            panel_main.Visible = False
        End If

        Me.Refresh()
        Application.DoEvents()


        For Each item As OLVListItem In list_processo.SelectedItems

            numeroProcesso = item.Text.Trim
            TemDadosCetesb = False
            ds.Tables.Clear()

            label_progresso.Text = "Coletando dados...Processo " & numeroProcesso

            Try


                'busca dados e preenche dataset
                'principal
                bll = New BLL.tb_PROC_processo
                dto = New DTO.tb_PROC_processo
                bll.connectionstring = connection
                bll.xmlpath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dt = bll.PagingData(dto)
                dt.TableName = "GERAL_PROCESSO"
                ds.Tables.Add(dt)

                'historico eventos
                bll = New BLL.tb_PREV_processo_evento
                dto = New DTO.tb_PREV_processo_evento
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.sortField = "PREV_dt_ocorrencia"
                dto.sortOrder = "DESC"
                dt = bll.PagingData(dto)
                dt.TableName = "GERAL_EVENTOS"
                ds.Tables.Add(dt)

                'dnpm-titulos
                bll = New BLL.tb_PTIT_processo_titulo
                dto = New DTO.tb_PTIT_processo_titulo
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 0
                dt = bll.PagingData(dto)
                dt.TableName = "DNPM_TITULO"
                ds.Tables.Add(dt)

                'substancias
                bll = New BLL.tb_PSUB_processo_substancia
                dto = New DTO.tb_PSUB_processo_substancia
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dt = bll.PagingData(dto)
                dt.TableName = "DNPM_SUBSTANCIA"
                ds.Tables.Add(dt)

                'associados
                bll = New BLL.tb_PASO_processo_associado
                dto = New DTO.tb_PASO_processo_associado
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dt = bll.PagingData(dto)
                dt.TableName = "DNPM_ASSOCIADOS"
                ds.Tables.Add(dt)

                'condicao
                bll = New BLL.tb_PCON_processo_condicao
                dto = New DTO.tb_PCON_processo_condicao
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.PCON_cd_condicao = base._intPadrao
                dt = bll.PagingData(dto)
                dt.TableName = "DNPM_CONDICAO"
                ds.Tables.Add(dt)

                'municipio
                bll = New BLL.tb_PMUN_processo_municipio
                dto = New DTO.tb_PMUN_processo_municipio
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dt = bll.PagingData(dto)
                dt.TableName = "DNPM_MUNICIPIO"
                ds.Tables.Add(dt)

                'dnpm-outros documentos
                bll = New BLL.tb_PDOC_processo_documento
                dto = New DTO.tb_PDOC_processo_documento
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 0
                dt = bll.PagingData(dto)
                dt.TableName = "DNPM_DOC"
                ds.Tables.Add(dt)

                'info-daee
                bll = New BLL.tb_PINF_processo_info
                dto = New DTO.tb_PINF_processo_info
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 2
                dto.PINF_cd_info = base._intPadrao
                dt = bll.PagingData(dto)
                dt.TableName = "INFO_DAEE"
                ds.Tables.Add(dt)

                'info-icmbio
                bll = New BLL.tb_PINF_processo_info
                dto = New DTO.tb_PINF_processo_info
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 3
                dto.PINF_cd_info = base._intPadrao
                dt = bll.PagingData(dto)
                dt.TableName = "INFO_ICMBIO"
                ds.Tables.Add(dt)

                'info-petrobras
                bll = New BLL.tb_PINF_processo_info
                dto = New DTO.tb_PINF_processo_info
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 4
                dto.PINF_cd_info = base._intPadrao
                dt = bll.PagingData(dto)
                dt.TableName = "INFO_PETROBRAS"
                ds.Tables.Add(dt)

                'info-prefeitura
                bll = New BLL.tb_PINF_processo_info
                dto = New DTO.tb_PINF_processo_info
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 5
                dto.PINF_cd_info = base._intPadrao
                dt = bll.PagingData(dto)
                dt.TableName = "INFO_PREFEITURA"
                ds.Tables.Add(dt)



                'cetesb-geral
                bll = New BLL.tb_PORG_processo_orgao
                dto = New DTO.tb_PORG_processo_orgao
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 1
                dt = bll.PagingData(dto)
                dt.TableName = "CETESB_GERAL"
                ds.Tables.Add(dt)

                If dt.Rows.Count > 0 Then
                    TemDadosCetesb = base.AjustaNulo(dt.Rows(0)("PORG_nm_cadastro")).Length > 0 Or base.AjustaNulo(dt.Rows(0)("PORG_ds_atividade")).Length > 0
                Else
                    TemDadosCetesb = False
                End If



                'cetesb-sd
                bll = New BLL.tb_PRSD_processo_sd
                dto = New DTO.tb_PRSD_processo_sd
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 1
                dt = bll.PagingData(dto)
                dt.TableName = "CETESB_SD"
                ds.Tables.Add(dt)

                'cetesb-mpxprod
                bll = New BLL.tb_PRMP_processo_mprima
                dto = New DTO.tb_PRMP_processo_mprima
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 1
                dt = bll.PagingDataProd(dto)
                dt.TableName = "CETESB_MPRIMA_PRODUTO"
                ds.Tables.Add(dt)

                'cetesb-outros documentos
                bll = New BLL.tb_PDOC_processo_documento
                dto = New DTO.tb_PDOC_processo_documento
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 1
                dt = bll.PagingData(dto)
                dt.TableName = "CETESB_DOC"
                ds.Tables.Add(dt)

                'cetesb-eventos
                bll = New BLL.tb_PNOT_processo_nota
                dto = New DTO.tb_PNOT_processo_nota
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 1
                dt = bll.PagingData(dto)
                dt.TableName = "CETESB_NOTA"
                ds.Tables.Add(dt)

                'daee-titulos
                bll = New BLL.tb_PTIT_processo_titulo
                dto = New DTO.tb_PTIT_processo_titulo
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 2
                dt = bll.PagingData(dto)
                dt.TableName = "DAEE_TITULO"
                ds.Tables.Add(dt)

                'daee-outros documentos
                bll = New BLL.tb_PDOC_processo_documento
                dto = New DTO.tb_PDOC_processo_documento
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 2
                dt = bll.PagingData(dto)
                dt.TableName = "DAEE_DOC"
                ds.Tables.Add(dt)

                'daee-eventos
                bll = New BLL.tb_PNOT_processo_nota
                dto = New DTO.tb_PNOT_processo_nota
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 2
                dt = bll.PagingData(dto)
                dt.TableName = "DAEE_NOTA"
                ds.Tables.Add(dt)


                'icmbio-titulos
                bll = New BLL.tb_PTIT_processo_titulo
                dto = New DTO.tb_PTIT_processo_titulo
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 3
                dt = bll.PagingData(dto)
                dt.TableName = "ICMBIO_TITULO"
                ds.Tables.Add(dt)

                'icmbio-outros documentos
                bll = New BLL.tb_PDOC_processo_documento
                dto = New DTO.tb_PDOC_processo_documento
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 3
                dt = bll.PagingData(dto)
                dt.TableName = "ICMBIO_DOC"
                ds.Tables.Add(dt)

                'icmbio-eventos
                bll = New BLL.tb_PNOT_processo_nota
                dto = New DTO.tb_PNOT_processo_nota
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 3
                dt = bll.PagingData(dto)
                dt.TableName = "ICMBIO_NOTA"
                ds.Tables.Add(dt)


                'petrobras-titulos
                bll = New BLL.tb_PTIT_processo_titulo
                dto = New DTO.tb_PTIT_processo_titulo
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 4
                dt = bll.PagingData(dto)
                dt.TableName = "PETROBRAS_TITULO"
                ds.Tables.Add(dt)

                'petrobras-outros documentos
                bll = New BLL.tb_PDOC_processo_documento
                dto = New DTO.tb_PDOC_processo_documento
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 4
                dt = bll.PagingData(dto)
                dt.TableName = "PETROBRAS_DOC"
                ds.Tables.Add(dt)

                'petrobras-eventos
                bll = New BLL.tb_PNOT_processo_nota
                dto = New DTO.tb_PNOT_processo_nota
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 4
                dt = bll.PagingData(dto)
                dt.TableName = "PETROBRAS_NOTA"
                ds.Tables.Add(dt)


                'prefeituras-titulos
                bll = New BLL.tb_PTIT_processo_titulo
                dto = New DTO.tb_PTIT_processo_titulo
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 5
                dt = bll.PagingData(dto)
                dt.TableName = "PREFEITURA_TITULO"
                ds.Tables.Add(dt)

                'prefeitura-outros documentos
                bll = New BLL.tb_PDOC_processo_documento
                dto = New DTO.tb_PDOC_processo_documento
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 5
                dt = bll.PagingData(dto)
                dt.TableName = "PREFEITURA_DOC"
                ds.Tables.Add(dt)

                'prefeitura-eventos
                bll = New BLL.tb_PNOT_processo_nota
                dto = New DTO.tb_PNOT_processo_nota
                bll.ConnectionString = connection
                bll.XMLPath = xmlpath
                dto.PROC_cd_processo = numeroProcesso
                dto.ORGA_nm_orgao = 5
                dt = bll.PagingData(dto)
                dt.TableName = "PREFEITURA_NOTA"
                ds.Tables.Add(dt)

            Catch ex As Exception
                If logErro.Trim.Length > 0 Then logErro += vbCrLf
                logErro += "Processo " & numeroProcesso & ": Erro ao tentar selecionar dados para geração do relatório: " & ex.Message & vbCrLf
                GoTo prox
            End Try

            'processa imagem do processo no mapa
            'abre kml
            ImagemMapa = ""
            Dim pathKMLDir As String = System.Configuration.ConfigurationManager.AppSettings("kmlDirToMap")
            Dim doc As XmlDocument = New XmlDocument
            doc.Load(pathKMLDir & "\SP.kml")
            Dim nsmgr As XmlNamespaceManager = New XmlNamespaceManager(doc.NameTable)
            nsmgr.AddNamespace("p", "http://www.opengis.net/kml/2.2")
            'encontra placemark do processo
            Dim xpath As String = "//p:kml//p:Document//p:Placemark[p:name='" + numeroProcesso + "']"
            Dim placeMark As XmlNode = doc.SelectSingleNode(xpath, nsmgr)
            If placeMark Is Nothing Then GoTo addparms

            'encontra pontos do polígono irregular ref. ao placemark
            Dim lpo As List(Of PointLatLng) = PegaPontos(placeMark, nsmgr)
            Dim arquivo As String = Application.StartupPath & "\tmp\Images\" & Replace(Replace(numeroProcesso, "\", ""), "/", "") & "_" & Format(Now, "ddMMyyyyHHmmss") & ".png"
            Dim result As String = ""
            Dim img As New ImageMap
            result = img.CreateImage(arquivo, lpo)
            ImagemMapa = arquivo

addparms:
            'add parametros
            ReDim Preserve parameters(3)
            parameters(0).name = "Processo"
            parameters(0).value = numeroProcesso

            parameters(1).name = "TemDadosCetesb"
            parameters(1).value = TemDadosCetesb

            parameters(2).name = "TemPagina"
            parameters(2).value = TemPagina

            parameters(3).name = "ImagemMapa"
            parameters(3).value = ImagemMapa

            'configura report
            myReport1.AddParameters(parameters)
            myReport1.ReportID = "Processo_" & numeroProcesso
            myReport1.PrintMode = clsReport.ReportMode.File
            myReport1.OutputFormat = clsReport.ReportFormat.PDF
            myReport1.TemporaryDirectory = "tmp/Report"
            myReport1.IncludeDateTimeOnReportFileName = False

            'Gera Relatório Com Dados
            retRel = myReport1.GenerateReport(Path, ds, TableName, True, arquivoReport)
            If retRel = "OK" Then retRel = ""
            If retRel.Trim.Length > 0 Then
                'ShowMessage(retRel, "", enErrorType._Error)
                If logErro.Trim.Length > 0 Then logErro += vbCrLf
                logErro += "Processo " & numeroProcesso & ":" & retRel
            Else

                Select Case exibirTela
                    Case True

                        If arquivoReport.Trim.Length > 0 Then
                            'mostra PDF na tela
                            Dim sInfo As New ProcessStartInfo(arquivoReport)
                            Process.Start(sInfo)
                            ' Else
                            '
                        End If

                    Case False



                        If list_processo.SelectedItems.Count = 1 Then


                            'se for apenas um processo selecionado, 
                            'apenas exibe na tela
                            If arquivoReport.Trim.Length > 0 Then
                                'mostra PDF na tela
                                'e sai da rotina
                                Dim sInfo As New ProcessStartInfo(arquivoReport)
                                Process.Start(sInfo)
                                Exit Sub
                                ' Else
                                '
                            End If
                        Else

                            'se for mais de um processo selecionado
                            'junta os PDFs em um unico arquivo
                            If dtPDF Is Nothing Then
                                dtPDF = New DataTable
                                dtPDF.Columns.Add("path")
                            End If


                            drPDF = dtPDF.NewRow
                            drPDF("path") = arquivoReport
                            dtPDF.Rows.Add(drPDF)


                        End If

                End Select

            End If


prox:
            i += 1
            Try
                pbar_down.Value = i
                Me.Refresh()
                Application.DoEvents()
            Catch ex As Exception

            End Try


        Next



        If dtPDF Is Nothing Then
            GoTo fim
        End If

        'junta pdfs em um só
        If dtPDF.Rows.Count > 0 Then

            'pbar_down.Minimum = 0
            'pbar_down.Maximum = dtPDF.Rows.Count - 1
            'pbar_down.Value = 0
            label_progresso.Text = "Gerando Arquivo PDF"
            Me.Refresh()
            Application.DoEvents()

            Dim objPDF As New PdfManipulation
            nomeArquivoUnico = "tmp\Report\temp_RelatorioProcessos_" & Format(Now, "ddMMyyyy_HHmmss") & ".pdf"
            objPDF.MergePDFs(dtPDF, nomeArquivoUnico)
            objPDF.AddPageNumberToPDFPages(nomeArquivoUnico)

            panel_main.Visible = False
            label_progresso.Text = ""
            pbar_down.Minimum = 0
            pbar_down.Maximum = 0
            pbar_down.Value = 0

            'excluir pdf temp (sem numero de paginas)
            Try
                File.Delete(nomeArquivoUnico)
            Catch ex As Exception
            End Try

            nomeArquivoUnico = Replace(nomeArquivoUnico, "temp_", "")

            'exclui pdfs usados
            For Each dr As DataRow In dtPDF.Rows
                Try
                    File.Delete(dr("path"))
                Catch ex As Exception
                End Try
            Next



            'mostra pdf na tela
            If nomeArquivoUnico.Trim.Length > 0 Then
                'mostra PDF na tela
                Dim sInfo As New ProcessStartInfo(nomeArquivoUnico)
                Process.Start(sInfo)
                ' Else
                '
            End If
        End If


fim:
        If logErro.Trim.Length > 0 Then
            ShowMessage("Lista de Problemas encontrados" & vbCrLf & vbCrLf & logErro, "", enErrorType.Warning)
        End If



    End Sub
   


    Private Sub picLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picLogo.Click
        Me.text_filter.Text = "Resitec"
    End Sub

   

    Private Sub list_processo_FormatCell(ByVal sender As Object, ByVal e As BrightIdeasSoftware.FormatCellEventArgs) Handles list_processo.FormatCell
        If (e.ColumnIndex = Me.column_prioridade.Index) Then
            Dim prioridade As Integer = DirectCast(DirectCast(e.Model, System.Object), System.Data.DataRowView).Row("PROC_cd_prioridade")
            Select Case prioridade
                'Case 1 : e.SubItem.ForeColor = Color.Red
                'Case 2 : e.SubItem.ForeColor = Color.Red
                'Case 3 : e.SubItem.ForeColor = Color.Red
                'Case 4 : e.SubItem.ForeColor = Color.Red
                Case 5 : e.SubItem.BackColor = Color.Red
                Case Else
            End Select

        End If
    End Sub
End Class