Imports BrightIdeasSoftware
Imports Microsoft.Reporting.WinForms
Imports System.IO
Imports GMap.NET.WindowsForms
Imports GMap.NET
Imports System.Reflection
Imports System.Globalization
Imports System.Xml
Imports GMap.NET.MapProviders
Imports System.Drawing.Imaging

Public Class form_processo

   
    Public processo As String = ""
   

    Public mode As Integer = 0
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



    Private Sub CarregaCombos()
        Dim obj As New Apoio.Globalization
        Dim dt1 As DataTable = obj.getListData(xmlpath, "fase")
        Dim dt2 As DataTable = obj.getListData(xmlpath, "uf")
        Dim dt4 As DataTable = obj.getListData(xmlpath, "prioridade")

        combo_fase.ValueMember = "name"
        combo_fase.DisplayMember = "value"
        combo_fase.DataSource = dt1

        combo_uf.ValueMember = "name"
        combo_uf.DisplayMember = "value"
        combo_uf.DataSource = dt2

        combo_prioridade.ValueMember = "name"
        combo_prioridade.DisplayMember = "value"
        combo_prioridade.DataSource = dt4

        'empresa
        Dim dt3 As DataTable
        Dim objEmpresa As New BLL.tb_EMPR_empresa
        Dim dto As New DTO.tb_EMPR_empresa

        objEmpresa.ConnectionString = connection
        objEmpresa.XMLPath = xmlpath

        dt3 = objEmpresa.GetData(dto)
        combo_titular.Items.Clear()
        For Each dr As DataRow In dt3.Rows
            combo_titular.Items.Add(dr("EMPR_ds_empresa"))
        Next
     

    End Sub
    Private Sub ListaAlertas()
        Dim dto As New DTO.tb_ALER_alerta
        Dim bll As New BLL.tb_ALER_alerta
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.ALER_fl_qualquer_processo = "N"

        dt = bll.PagingData(dto)

        dt.Columns.Add("ALER_ds_status")
        dt.Columns.Add("ALER_ds_muda_fase")
        dt.Columns.Add("ALER_ds_muda_evento")

        Dim objXml As New Apoio.Globalization
        Dim dtXml1 As DataTable = objXml.getListData(xmlpath, "status")
        Dim dtXml2 As DataTable = objXml.getListData(xmlpath, "question")

        For Each dr As DataRow In dt.Rows

            dr("ALER_ds_status") = dtXml1.Select("name = '" & dr("ALER_fl_status") & "'")(0)("value").ToString.Trim

            dr("ALER_ds_muda_fase") = dtXml2.Select("name = '" & dr("ALER_fl_muda_fase") & "'")(0)("value").ToString.Trim
            dr("ALER_ds_muda_evento") = dtXml2.Select("name = '" & dr("ALER_fl_muda_evento") & "'")(0)("value").ToString.Trim

        Next

        list_alerta.DataSource = New BindingSource(dt, dt.TableName)

    End Sub
    Private Sub ListaOperadores()
        Dim dto As New DTO.tb_OPER_operador
        Dim bll As New BLL.tb_OPER_operador
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        dt.Columns.Add("OPER_ds_alerta")
        dt.Columns.Add("OPER_ds_alerta_nativo")
        Dim objXml As New Apoio.Globalization
        Dim dtXml As DataTable = objXml.getListData(xmlpath, "question")
        For Each dr As DataRow In dt.Rows
            dr("OPER_ds_alerta") = dtXml.Select("name = '" & dr("OPER_fl_alerta") & "'")(0)("value").ToString.Trim
            dr("OPER_ds_alerta_nativo") = dtXml.Select("name = '" & dr("OPER_fl_alerta_nativo") & "'")(0)("value").ToString.Trim
        Next

        list_operador.DataSource = New BindingSource(dt, dt.TableName)


    End Sub

    Private Sub ListaEventos(ByVal code As String)
        Dim dto As New DTO.tb_PREV_processo_evento
        Dim bll As New BLL.tb_PREV_processo_evento
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = code

        dt = bll.GetData(dto)

        list_evento.DataSource = New BindingSource(dt, dt.TableName)



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
    
    Private Sub form_processo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try


            MakeFormGlobal(Me)

            ChangeFilterMenuLanguage()

            'tags dos lists

            list_evento.Tag = -2


            list_dnpm_titulo.Tag = 0
            list_dnpm_documento.Tag = 0


            list_cetesb_titulo.Tag = 1
            list_cetesb_documento.Tag = 1
            list_cetesb_evento.Tag = 1
            list_cetesb_mp.Tag = 1

            list_daee_titulo.Tag = 2
            list_daee_documento.Tag = 2
            list_daee_evento.Tag = 2
            list_daee_info.Tag = 2

            list_icmbio_titulo.Tag = 3
            list_icmbio_documento.Tag = 3
            list_icmbio_evento.Tag = 3
            list_icmbio_info.Tag = 3

            list_petrobras_titulo.Tag = 4
            list_petrobras_documento.Tag = 4
            list_petrobras_evento.Tag = 4
            list_petrobras_info.Tag = 4

            list_prefeitura_titulo.Tag = 5
            list_prefeitura_documento.Tag = 5
            list_prefeitura_evento.Tag = 5
            list_prefeitura_info.Tag = 5

            'list_projeto_titulo.Tag = 6
            'list_projeto_documento.Tag = 6
            'list_projeto_evento.Tag = 6

            customizaTooltipGrid(list_cetesb_evento)
            customizaTooltipGrid(list_daee_evento)
            customizaTooltipGrid(list_icmbio_evento)
            customizaTooltipGrid(list_petrobras_evento)
            customizaTooltipGrid(list_prefeitura_evento)

            customizaTooltipGrid(list_evento)


            ListaAlertas()
            ListaOperadores()

            Application.DoEvents()
            Me.Refresh()

            CarregaCombos()
            LimpaDetalhes()

            text_name.Enabled = True
            combo_titular.Enabled = True
            text_ano.Enabled = True
            text_num.Enabled = True

            panel_details.Enabled = False
            button_del.Visible = False
            button_mapa.Visible = False
            button_alerta_confirm.Visible = False
            button_operador_confirm.Visible = False


            Application.DoEvents()
            Me.Refresh()

            Timer1.Enabled = True
            Timer1.Start()

           

            loaded = True

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub modoInclusao()

        LimpaDetalhes()

        text_name.Enabled = True
        combo_titular.Enabled = True
        text_ano.Enabled = True
        text_num.Enabled = True
        tab_main.SelectedIndex = 0

        panel_details.Enabled = True
        button_del.Visible = False
        button_mapa.Visible = False
        button_alerta_confirm.Visible = False
        button_operador_confirm.Visible = False
        text_name.Focus()


    End Sub
    Private Sub ListaTitulos(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PTIT_processo_titulo
        Dim bll As New BLL.tb_PTIT_processo_titulo
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaSD(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PRSD_processo_sd
        Dim bll As New BLL.tb_PRSD_processo_sd
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaMP(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PRMP_processo_mprima
        Dim bll As New BLL.tb_PRMP_processo_mprima
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        dto.ORGA_nm_orgao = Tipo
        dt = bll.PagingDataProd(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaNotas(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PNOT_processo_nota
        Dim bll As New BLL.tb_PNOT_processo_nota
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaDocumentos(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PDOC_processo_documento
        Dim bll As New BLL.tb_PDOC_processo_documento
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaInfo(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PINF_processo_info
        Dim bll As New BLL.tb_PINF_processo_info
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaSubstancias(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PSUB_processo_substancia
        Dim bll As New BLL.tb_PSUB_processo_substancia
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        'dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaMunicipios(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PMUN_processo_municipio
        Dim bll As New BLL.tb_PMUN_processo_municipio
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        'dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaAssociados(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PASO_processo_associado
        Dim bll As New BLL.tb_PASO_processo_associado
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        'dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub ListaCondicoes(ByVal Tipo As Integer, ByVal code As String, ByVal lista As DataListView)
        Dim dto As New DTO.tb_PCON_processo_condicao
        Dim bll As New BLL.tb_PCON_processo_condicao
        Dim dt As DataTable
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dto.PROC_cd_processo = code
        'dto.ORGA_nm_orgao = Tipo
        dt = bll.GetData(dto)
        lista.DataSource = New BindingSource(dt, dt.TableName)
    End Sub
    Private Sub LimpaDetalhes()

        text_name.Text = ""
        text_ano.Text = ""
        text_ultimo_evento.Text = ""
        text_substancia.Text = ""
        text_area.Text = ""
        text_uso.Text = ""
        text_link.Text = ""
        text_id.Text = ""
        text_num.Text = ""
        combo_fase.SelectedValue = "0"
        combo_prioridade.SelectedValue = "0"
        combo_uf.SelectedValue = "00"
        combo_titular.Text = ""
        link_processo.Links.Clear()

        For Each item As OLVListItem In list_alerta.Items
            item.Checked = False
        Next

        For Each item As OLVListItem In list_operador.Items
            item.Checked = False
        Next

        list_evento.Items.Clear()

        '[abas]
        list_dnpm_titulo.Items.Clear()
        list_dnpm_documento.Items.Clear()
        list_dnpm_substancia.Items.Clear()
        list_dnpm_municipio.Items.Clear()
        list_dnpm_associado.Items.Clear()
        list_dnpm_condicao.Items.Clear()

        list_cetesb_titulo.Items.Clear()
        list_cetesb_documento.Items.Clear()
        list_cetesb_evento.Items.Clear()

        list_daee_titulo.Items.Clear()
        list_daee_documento.Items.Clear()
        list_daee_evento.Items.Clear()

        list_icmbio_titulo.Items.Clear()
        list_icmbio_documento.Items.Clear()
        list_icmbio_evento.Items.Clear()

        list_petrobras_titulo.Items.Clear()
        list_petrobras_documento.Items.Clear()
        list_petrobras_evento.Items.Clear()

        list_prefeitura_titulo.Items.Clear()
        list_prefeitura_documento.Items.Clear()
        list_prefeitura_evento.Items.Clear()

        text_cetesb_atividade.Text = ""
        text_cetesb_cadastro.Text = ""


    End Sub
    Private Sub CarregaDetalhes(ByVal code As String)

        Dim dt As DataTable
        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo


        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = code
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then

            text_name.Text = dt.Rows(0)("PROC_cd_processo").ToString.Trim
            text_ano.Text = base.AjustaNulo(dt.Rows(0)("PROC_vl_ano"))
            text_ultimo_evento.Text = base.AjustaNulo(dt.Rows(0)("PROC_ds_ultimo_evento"))
            text_substancia.Text = base.AjustaNulo(dt.Rows(0)("PROC_ds_substancia"))
            text_area.Text = base.AjustaNulo(dt.Rows(0)("PROC_ds_area"))
            text_uso.Text = base.AjustaNulo(dt.Rows(0)("PROC_ds_uso"))
            text_link.Text = base.AjustaNulo(dt.Rows(0)("PROC_ds_link"))
            text_id.Text = base.AjustaNulo(dt.Rows(0)("PROC_id_processo"))
            text_num.Text = base.AjustaNulo(dt.Rows(0)("PROC_nm_processo"))

            Dim index As Integer = combo_titular.FindString(dt.Rows(0)("PROC_ds_titular").ToString.Trim)
            Dim value As String = ""
            If index = -1 Then
                combo_titular.Items.Add(dt.Rows(0)("PROC_ds_titular").ToString.Trim)
                index = combo_titular.FindString(dt.Rows(0)("PROC_ds_titular").ToString.Trim)
            End If

            value = combo_titular.Items(index).ToString.Trim
            combo_titular.Enabled = True
            combo_titular.Text = value
            combo_titular.SelectedIndex = index
            combo_titular.Enabled = False

            Dim fase As String = base.AjustaNulo(dt.Rows(0)("FASE_cd_fase"))
            If fase.Trim.Length = 0 Then fase = "0"

            Dim uf As String = base.AjustaNulo(dt.Rows(0)("UNFE_cd_unidade_federativa"))
            If uf.Trim.Length = 0 Then uf = "00"

            Dim prioridade As String = base.AjustaNulo(dt.Rows(0)("PROC_cd_prioridade"))
            If prioridade.Trim.Length = 0 Then prioridade = "0"

            combo_fase.SelectedValue = fase
            combo_uf.SelectedValue = uf
            combo_prioridade.SelectedValue = prioridade

            link_processo.Links.Clear()
            If base.AjustaNulo(dt.Rows(0)("PROC_ds_link")).Trim.Length > 0 Then
                link_processo.Links.Add(0, link_processo.Text.Length, base.AjustaNulo(dt.Rows(0)("PROC_ds_link")))
            End If


            text_cetesb_atividade.Text = base.AjustaNulo(dt.Rows(0)("PORG_nm_cadastro"))
            text_cetesb_cadastro.Text = base.AjustaNulo(dt.Rows(0)("PORG_ds_atividade"))


            SelecionaAlertasAssociados(code)
            SelecionaOperadoresAssociados(code)

            ListaEventos(code)



            'dnpm
            ListaTitulos(enOrgao.DNPM, code, list_dnpm_titulo)
            ListaDocumentos(enOrgao.DNPM, code, list_dnpm_documento)
            ListaSubstancias(enOrgao.DNPM, code, list_dnpm_substancia)
            ListaMunicipios(enOrgao.DNPM, code, list_dnpm_municipio)
            ListaAssociados(enOrgao.DNPM, code, list_dnpm_associado)
            ListaCondicoes(enOrgao.DNPM, code, list_dnpm_condicao)

            'cetesb
            ListaTitulos(enOrgao.CETESB, code, list_cetesb_titulo)
            ListaDocumentos(enOrgao.CETESB, code, list_cetesb_documento)
            ListaNotas(enOrgao.CETESB, code, list_cetesb_evento)
            ListaMP(enOrgao.CETESB, code, list_cetesb_mp)



            mode = 2

        Else
            mode = 1
            ShowMessage(String.Format(gettext("message", 1), code), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub SelecionaAlertasAssociados(ByVal code As String)

        Dim dtoPRAL As New DTO.tb_PRAL_processo_alerta
        Dim bllPRAL As New BLL.tb_PRAL_processo_alerta
        Dim dt As DataTable

        bllPRAL.ConnectionString = connection
        bllPRAL.XMLPath = xmlpath

        dtoPRAL.PROC_cd_processo = code

        dt = bllPRAL.GetData(dtoPRAL)


        For Each item As OLVListItem In list_alerta.Items
            item.Checked = dt.Select("ALER_nm_alerta = '" & item.Text.Trim & "'").Length > 0
        Next


    End Sub
    Private Sub SelecionaOperadoresAssociados(ByVal code As String)

        Dim dto As New DTO.tb_PROP_processo_operador
        Dim bll As New BLL.tb_PROP_processo_operador
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = code

        dt = bll.GetData(dto)


        For Each item As OLVListItem In list_operador.Items
            item.Checked = dt.Select("OPER_cd_operador = '" & item.Text.Trim & "'").Length > 0
        Next


    End Sub







    Private Sub modoEdicao()

        If processo.Trim.Length > 0 Then
            tab_main.SelectedIndex = 0
            Dim id As String = processo

            CarregaDetalhes(id)

            text_name.Enabled = False
            combo_titular.Enabled = False
            text_ano.Enabled = False
            text_num.Enabled = False

            panel_details.Enabled = True
            button_del.Visible = True
            button_mapa.Visible = True
            button_alerta_confirm.Visible = True
            button_operador_confirm.Visible = True

            Me.Text = String.Format(gettext("custom", 35), gettext("custom", 33) & ": " & id)
        Else

            text_name.Enabled = True
            combo_titular.Enabled = True
            text_ano.Enabled = True
            text_num.Enabled = True

            LimpaDetalhes()
            button_del.Visible = False
            button_mapa.Visible = False
            button_alerta_confirm.Visible = False
            button_operador_confirm.Visible = False

            Me.Text = String.Format(gettext("custom", 35), gettext("custom", 34))

        End If
    End Sub




    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo
        Dim message As String = ""
        Dim ret As Boolean = False

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        Select Case mode
            Case 1 'insert
                dto.AUDT_dt_inclusao = Now
                dto.AUDT_nm_usuario_inclusao = default_user
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
                dto.PROC_fl_tipo_inclusao = "M"
            Case 2 'update
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
        End Select

        dto.PROC_cd_processo = text_name.Text.Trim
        dto.PROC_ds_titular = combo_titular.Text.Trim
        dto.PROC_id_processo = text_id.Text.Trim
        dto.PROC_ds_area = text_area.Text.Trim
        dto.PROC_ds_uso = text_uso.Text.Trim
        dto.PROC_ds_link = text_link.Text.Trim
        dto.PROC_ds_substancia = text_substancia.Text.Trim
        dto.PROC_ds_ultimo_evento = text_ultimo_evento.Text.Trim
        dto.PROC_nm_processo = text_num.Text.Trim
        dto.FASE_cd_fase = combo_fase.SelectedValue.trim

        If combo_uf.SelectedValue IsNot Nothing Then
            dto.UNFE_cd_unidade_federativa = combo_uf.SelectedValue.trim
        End If


        dto.PROC_cd_prioridade = IIf(combo_prioridade.SelectedValue IsNot Nothing, combo_prioridade.SelectedValue, "1")
        dto.PROC_vl_ano = text_ano.Text.Trim

        ret = bll.SaveData(dto, message, 0, mode)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If


        'se for inclusao, 
        'se a empresa for cadastrada, seleciona na lista o alerta padrão 
        'seleciona operador(es) padrão
        If mode = 1 Then
            If empresaCadastrada(dto.PROC_ds_titular) Then SelecionarAlertasPadrao()
            SelecionarOperadoresPadrao()
        End If

        incluirAlertas()
        incluirOperadores()

        Dim parms(1) As String
        parms(0) = text_cetesb_cadastro.Text.Trim
        parms(1) = text_cetesb_atividade.Text.Trim
        SalvaDadosPorOrgao(text_name.Text.Trim, 1, parms) 'cetesb


        Return ret

    End Function
    Private Sub incluirAlertas()
        Dim dto As New DTO.tb_PRAL_processo_alerta
        Dim bll As New BLL.tb_PRAL_processo_alerta

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        If text_name.Text.Trim.Length = 0 Then
            ShowMessage(gettext("custom", 1), "", enErrorType.Warning)
            Exit Sub
        End If


        'inclui alertas selecionados na lista 
        For Each item As ListViewItem In list_alerta.Items
            Try
                Select Case item.Checked
                    Case True
                        dto.ALER_nm_alerta = item.Text.Trim
                        dto.PROC_cd_processo = text_name.Text.Trim
                        dto.PRAL_fl_manutencao = "S"
                        dto.AUDT_dt_alteracao = Now
                        dto.AUDT_nm_usuario_alteracao = default_user
                        dto.AUDT_dt_inclusao = Now
                        dto.AUDT_nm_usuario_inclusao = default_user
                        bll.InsertData(dto)
                    Case False
                        dto.ALER_nm_alerta = item.Text.Trim
                        dto.PROC_cd_processo = text_name.Text.Trim
                        bll.DeleteData(dto)
                End Select
            Catch ex As Exception
                Dim a As Integer = 0
            End Try
        Next
    End Sub

    Private Sub incluirOperadores()
        Dim dto As New DTO.tb_PROP_processo_operador
        Dim bll As New BLL.tb_PROP_processo_operador

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        If text_name.Text.Trim.Length = 0 Then
            ShowMessage(gettext("custom", 2), "", enErrorType.Warning)
            Exit Sub
        End If


        'inclui operador(es) selecionado(s) na lista 
        For Each item As ListViewItem In list_operador.Items
            Try
                Select Case item.Checked
                    Case True
                        dto.OPER_cd_operador = item.Text.Trim
                        dto.PROC_cd_processo = text_name.Text.Trim
                        dto.AUDT_dt_alteracao = Now
                        dto.AUDT_nm_usuario_alteracao = default_user
                        dto.AUDT_dt_inclusao = Now
                        dto.AUDT_nm_usuario_inclusao = default_user
                        bll.InsertData(dto)
                    Case False
                        dto.OPER_cd_operador = item.Text.Trim
                        dto.PROC_cd_processo = text_name.Text.Trim
                        bll.DeleteData(dto)
                End Select
            Catch ex As Exception
                Dim a As Integer = 0
            End Try
        Next
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
    Private Sub SelecionarAlertasPadrao()
        Dim dt As DataTable
        Dim dto As New DTO.tb_ALER_alerta
        Dim bll As New BLL.tb_ALER_alerta
        Dim dr() As DataRow
        Dim filtro As String = ""

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        dt = bll.GetData(dto)

        For Each item As OLVListItem In list_alerta.Items
            filtro = "ALER_nm_alerta = '" & item.Text.Trim & "'"
            dr = dt.Select(filtro)
            If dr(0)("ALER_fl_sistema") = "S" Then
                item.Checked = True
            Else
                item.Checked = False
            End If
        Next


    End Sub
    Private Sub SelecionarOperadoresPadrao()
        Dim dt As DataTable
        Dim dto As New DTO.tb_OPER_operador
        Dim bll As New BLL.tb_OPER_operador
        Dim dr() As DataRow
        Dim filtro As String = ""

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        dt = bll.GetData(dto)

        For Each item As OLVListItem In list_operador.Items
            filtro = "OPER_cd_operador = '" & item.Text.Trim & "'"
            dr = dt.Select(filtro)
            If dr(0)("OPER_fl_alerta_nativo") = "S" Then
                item.Checked = True
            Else
                item.Checked = False
            End If
        Next


    End Sub

    Private Sub button_confirm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                Try
                    ' If form_grid_processo.IsAccessible Then
                    form_grid_processo.ListaProcessos()
                    ' End If
                Catch ex As Exception

                End Try


                CarregaDetalhes(text_name.Text.Trim)
                button_del.Visible = True
                button_mapa.Visible = True
                button_alerta_confirm.Visible = True
                button_operador_confirm.Visible = True
                text_name.Enabled = False
                processo = text_name.Text.Trim
                mode = 2
            End If

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
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
    Private Function Excluir(ByVal code As String) As Boolean
        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = code
        Return bll.DeleteData(dto)

    End Function




    Private Sub button_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_del.Click
        Try
            Dim code As String = ""

            Select Case mode
                Case 1 'insert
                    code = text_name.Text
                Case 2 'update 
                    code = text_name.Text
            End Select

            If code.Trim.Length > 0 Then

                If MsgBox(String.Format(gettext("custom", 0), code), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then

                    If Excluir(code) Then
                        LimpaDetalhes()

                        text_name.Enabled = True
                        text_num.Enabled = True
                        text_ano.Enabled = True
                        combo_titular.Enabled = True

                        button_del.Visible = False
                        button_mapa.Visible = False
                        button_alerta_confirm.Visible = False
                        button_operador_confirm.Visible = False
                        mode = 1
                    End If

                    Try
                        ' If form_grid_processo.IsAccessible Then
                        form_grid_processo.ListaProcessos()
                        ' End If
                    Catch ex As Exception

                    End Try

                    Me.Close()

                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub text_name_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles text_name.Enter
        Try

            PreencheCamposAnoNumero()


        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub



    Private Sub text_name_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles text_name.LostFocus
        Try

            PreencheCamposAnoNumero()


        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub PreencheCamposAnoNumero()

        Dim obj As New BLL.tb_PROC_processo
        Dim retorno As String = ""

        obj.ConnectionString = connection
        obj.XMLPath = xmlpath

        retorno = obj.ValidaNumeroProcesso(text_name.Text)

        If retorno.Trim.Length = 0 Then

            Try
                text_num.Text = Split(text_name.Text.Trim, "/")(0)
                text_ano.Text = Split(text_name.Text.Trim, "/")(1)
            Catch ex As Exception

            End Try

        Else

            text_num.Text = ""
            text_ano.Text = ""

            ShowMessage(retorno, "", enErrorType.Warning)
            text_name.Text = ""

        End If

    End Sub





    Private Sub link_processo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_processo.LinkClicked

        If e.Link.LinkData.ToString().Trim.Length > 0 Then
            Dim sInfo As New ProcessStartInfo(e.Link.LinkData.ToString)
            Process.Start(sInfo)
        Else
            ShowMessage(gettext("message", 3), "", enErrorType.Warning)
        End If

    End Sub








    Private Sub button_alerta_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_alerta_confirm.Click
        Try

            incluirAlertas()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub button_operador_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_operador_confirm.Click
        Try


            incluirOperadores()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub list_alerta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_alerta.DoubleClick
        Try

            Dim code As String = ""

            If list_alerta.SelectedIndex <> -1 Then

                code = list_alerta.SelectedItem.Text.Trim()
                form_alerta.code = code
                form_alerta.ShowDialog()

                ListaAlertas()
                If text_name.Text.Trim.Length > 0 Then
                    SelecionaAlertasAssociados(text_name.Text.Trim)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub list_operador_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_operador.DoubleClick
        Try

            Dim code As String = ""

            If list_operador.SelectedIndex <> -1 Then

                code = list_operador.SelectedItem.Text.Trim()
                form_operador.code = code
                form_operador.ShowDialog()

                ListaOperadores()
                If text_name.Text.Trim.Length > 0 Then
                    SelecionaOperadoresAssociados(text_name.Text.Trim)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub modoEditTitulo(ByVal sender As Object)
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                form_titulo.numero = numero
                form_titulo.modo = 2 'update
                form_titulo.processo = text_name.Text.Trim
                form_titulo.orgao = CInt(sender.Tag)

                If form_titulo.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaTitulos(CInt(sender.Tag), text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub modoEditSD(ByVal sender As Object)
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                form_sd.numero = numero
                form_sd.modo = 2 'update
                form_sd.processo = text_name.Text.Trim
                form_sd.orgao = CInt(sender.Tag)

                If form_sd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaSD(CInt(sender.Tag), text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub modoEditMP(ByVal sender As Object)
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = CType(sender.SelectedItem.RowObject, DataRowView).Row("MPRI_nm_mprima").ToString.Trim 'sender.SelectedItem.Text.Trim()
                form_mp.numero = numero
                form_mp.modo = 2 'update
                form_mp.processo = text_name.Text.Trim
                form_mp.orgao = CInt(sender.Tag)

                If form_mp.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaMP(CInt(sender.Tag), text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub modoEditEvento(ByVal sender As Object)
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                form_evento.numero = numero
                form_evento.modo = 2 'update
                form_evento.processo = text_name.Text.Trim
                form_evento.orgao = CInt(sender.Tag)

                If form_evento.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    Select Case CInt(sender.Tag)
                        Case -2
                            ListaEventos(text_name.Text.Trim)
                        Case Else
                            ListaNotas(CInt(sender.Tag), text_name.Text.Trim, sender)
                    End Select

                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub modoEditDocumento(ByVal sender As Object)
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                form_documento.numero = numero
                form_documento.modo = 2 'update
                form_documento.processo = text_name.Text.Trim
                form_documento.orgao = CInt(sender.Tag)

                If form_documento.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaDocumentos(CInt(sender.Tag), text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub modoEditInfo(ByVal sender As Object)
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                form_info.numero = numero
                form_info.modo = 2 'update
                form_info.processo = text_name.Text.Trim
                form_info.orgao = CInt(sender.Tag)

                If form_info.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaInfo(CInt(sender.Tag), text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub list_cetesb_mp_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_cetesb_mp.DoubleClick
        modoEditMP(sender)
    End Sub
    Private Sub list_dnpm_titulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_dnpm_titulo.DoubleClick
        modoEditTitulo(sender)
    End Sub
    Private Sub list_cetesb_titulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_cetesb_titulo.DoubleClick
        modoEditSD(sender)
    End Sub
    Private Sub list_daee_titulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_daee_titulo.DoubleClick
        modoEditTitulo(sender)
    End Sub
    Private Sub list_daee_info_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_daee_info.DoubleClick
        modoEditInfo(sender)
    End Sub

    Private Sub list_icmbio_info_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_icmbio_info.DoubleClick
        modoEditInfo(sender)
    End Sub
    Private Sub list_petrobras_info_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_petrobras_info.DoubleClick
        modoEditInfo(sender)
    End Sub
    Private Sub list_prefeitura_info_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_prefeitura_info.DoubleClick
        modoEditInfo(sender)
    End Sub

    Private Sub list_icmbio_titulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_icmbio_titulo.DoubleClick
        modoEditTitulo(sender)
    End Sub
    Private Sub list_petrobras_titulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_petrobras_titulo.DoubleClick
        modoEditTitulo(sender)
    End Sub
    Private Sub list_prefeitura_titulo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_prefeitura_titulo.DoubleClick
        modoEditTitulo(sender)
    End Sub
    Private Sub list_dnpm_documento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_dnpm_documento.DoubleClick
        modoEditDocumento(sender)
    End Sub
    Private Sub list_cetesb_documento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_cetesb_documento.DoubleClick
        modoEditDocumento(sender)
    End Sub
    Private Sub list_cetesb_evento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_cetesb_evento.DoubleClick
        modoEditEvento(sender)
    End Sub
    Private Sub list_evento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_evento.DoubleClick
        modoEditEvento(sender)
    End Sub

    Private Sub list_daee_documento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_daee_documento.DoubleClick
        modoEditDocumento(sender)
    End Sub
    Private Sub list_daee_evento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_daee_evento.DoubleClick
        modoEditEvento(sender)
    End Sub

    Private Sub list_icmbio_documento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_icmbio_documento.DoubleClick
        modoEditDocumento(sender)
    End Sub
    Private Sub list_icmbio_evento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_icmbio_evento.DoubleClick
        modoEditEvento(sender)
    End Sub

    Private Sub list_petrobras_documento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_petrobras_documento.DoubleClick
        modoEditDocumento(sender)
    End Sub
    Private Sub list_petrobras_evento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_petrobras_evento.DoubleClick
        modoEditEvento(sender)
    End Sub

    Private Sub list_prefeitura_documento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_prefeitura_documento.DoubleClick
        modoEditDocumento(sender)
    End Sub
    Private Sub list_prefeitura_evento_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_prefeitura_evento.DoubleClick
        modoEditEvento(sender)
    End Sub


    Private Sub list_dnpm_substancia_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_dnpm_substancia.DoubleClick
        Try

            Dim numero As String = "" 'substancia
            Dim numero2 As String = "" 'tipo de uso

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                numero2 = CType(list_dnpm_substancia.SelectedItem.RowObject, DataRowView).Row("TUSO_nm_uso").ToString.Trim

                form_substancia.numero = numero
                form_substancia.numero2 = numero2
                form_substancia.modo = 2 'update
                form_substancia.processo = text_name.Text.Trim
                form_substancia.orgao = 0 'dnpm

                If form_substancia.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaSubstancias(0, text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub list_dnpm_municipio_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_dnpm_municipio.DoubleClick
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                form_municipio.numero = numero
                form_municipio.modo = 2 'update
                form_municipio.processo = text_name.Text.Trim
                form_municipio.orgao = 0 'dnpm

                If form_municipio.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaMunicipios(0, text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub list_dnpm_associado_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_dnpm_associado.DoubleClick
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                form_associado.numero = numero
                form_associado.modo = 2 'update
                form_associado.processo = text_name.Text.Trim
                form_associado.orgao = 0 'dnpm

                If form_associado.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaAssociados(0, text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub

    Private Sub list_dnpm_condicao_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_dnpm_condicao.DoubleClick
        Try

            Dim numero As String = ""

            If sender.SelectedIndex <> -1 And mode = 2 Then

                numero = sender.SelectedItem.Text.Trim()
                form_condicao.numero = numero
                form_condicao.modo = 2 'update
                form_condicao.processo = text_name.Text.Trim
                form_condicao.orgao = 0 'dnpm

                If form_condicao.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    ListaCondicoes(0, text_name.Text.Trim, sender)
                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub

    Private Sub button_operador_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_operador_refresh.Click
        Try


            ListaOperadores()
            If text_name.Text.Trim.Length > 0 Then
                SelecionaOperadoresAssociados(text_name.Text.Trim)
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub button_alerta_refresh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_alerta_refresh.Click
        Try


            ListaAlertas()
            If text_name.Text.Trim.Length > 0 Then
                SelecionaAlertasAssociados(text_name.Text.Trim)
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub



    Private Sub button_evento_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_evento_refresh.Click
        Try



            If text_name.Text.Trim.Length > 0 Then
                ListaEventos(text_name.Text.Trim)
            Else
                list_evento.Items.Clear()
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub


    Private Sub list_evento_CellToolTipShowing(ByVal sender As Object, ByVal e As BrightIdeasSoftware.ToolTipShowingEventArgs) Handles list_evento.CellToolTipShowing
        modoToolTip(sender, e)
    End Sub

    Private Sub customizaTooltipGrid(ByVal lista As DataListView)

        lista.CellToolTip.Font = New Font("Verdana", 10)
        lista.CellToolTip.BackColor = Color.LightYellow
        lista.CellToolTip.IsBalloon = False
        lista.CellToolTip.StandardIcon = ToolTipControl.StandardIcons.Info
        lista.CellToolTip.Title = gettext("custom", 3)
        lista.CellToolTip.HasBorder = True
        lista.CellToolTip.ForeColor = Color.Black

    End Sub

    Private Sub modoToolTip(ByVal sender As Object, ByVal e As BrightIdeasSoftware.ToolTipShowingEventArgs)

        Try

            Dim descricao As String = ""
            Dim chars As Integer = 120

            If e.ColumnIndex = 1 Then descricao = vbCrLf & base.PulaLinhaACadaNCaracteres(e.SubItem.Text.Trim(), chars, vbCrLf)

            e.Text = descricao

        Catch ex As Exception

        End Try

    End Sub
    Private Sub list_cetesb_evento_CellToolTipShowing(ByVal sender As Object, ByVal e As BrightIdeasSoftware.ToolTipShowingEventArgs) Handles list_cetesb_evento.CellToolTipShowing
        modoToolTip(sender, e)
    End Sub
    Private Sub list_daee_evento_CellToolTipShowing(ByVal sender As Object, ByVal e As BrightIdeasSoftware.ToolTipShowingEventArgs) Handles list_daee_evento.CellToolTipShowing
        modoToolTip(sender, e)
    End Sub
    Private Sub list_icmbio_evento_CellToolTipShowing(ByVal sender As Object, ByVal e As BrightIdeasSoftware.ToolTipShowingEventArgs) Handles list_icmbio_evento.CellToolTipShowing
        modoToolTip(sender, e)
    End Sub
    Private Sub list_petrobras_evento_CellToolTipShowing(ByVal sender As Object, ByVal e As BrightIdeasSoftware.ToolTipShowingEventArgs) Handles list_petrobras_evento.CellToolTipShowing
        modoToolTip(sender, e)
    End Sub
    Private Sub list_prefeitura_evento_CellToolTipShowing(ByVal sender As Object, ByVal e As BrightIdeasSoftware.ToolTipShowingEventArgs) Handles list_prefeitura_evento.CellToolTipShowing
        modoToolTip(sender, e)
    End Sub


    Private Sub center_form(ByVal frm As Form)
        Application.DoEvents()
        frm.Location = New Point(Me.Width / 2 - frm.Width / 2, (Me.Height) / 2 - frm.Height / 2)
    End Sub
    Private Sub list_dnpm_associado_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_dnpm_associado.KeyDown
        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirAssociadosSelecionados(log)
                    ListaAssociados(0, text_name.Text.Trim, list_dnpm_associado)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub list_dnpm_municipio_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_dnpm_municipio.KeyDown
        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirMunicipiosSelecionados(log)
                    ListaMunicipios(0, text_name.Text.Trim, list_dnpm_municipio)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub list_dnpm_substancia_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_dnpm_substancia.KeyDown
        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirSubstanciasSelecionadas(log)
                    ListaSubstancias(0, text_name.Text.Trim, list_dnpm_substancia)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub list_cetesb_mp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_cetesb_mp.KeyDown
        modoDelMP(sender, e)
    End Sub

    Private Sub list_dnpm_titulo_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_dnpm_titulo.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_dnpm_titulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_dnpm_titulo.KeyDown
        modoDelTitulo(sender, e)
    End Sub
    Private Sub list_cetesb_titulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_cetesb_titulo.KeyDown
        modoDelSD(sender, e)
    End Sub

    Private Sub list_cetesb_documento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_cetesb_documento.KeyDown
        modoDelDocumento(sender, e)
    End Sub

    Private Sub list_cetesb_evento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_cetesb_evento.KeyDown
        modoDelEvento(sender, e)
    End Sub
    Private Sub list_evento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_evento.KeyDown
        modoDelEvento(sender, e)
    End Sub

    Private Sub list_dnpm_documento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_dnpm_documento.KeyDown
        modoDelDocumento(sender, e)
    End Sub
    Private Sub list_daee_documento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_daee_documento.KeyDown
        modoDelDocumento(sender, e)
    End Sub
    Private Sub list_daee_evento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_daee_evento.KeyDown
        modoDelEvento(sender, e)
    End Sub
    Private Sub list_icmbio_titulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_icmbio_titulo.KeyDown
        modoDelTitulo(sender, e)
    End Sub
    Private Sub list_daee_titulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_daee_titulo.KeyDown
        modoDelTitulo(sender, e)
    End Sub
    Private Sub list_daee_info_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_daee_info.KeyDown
        modoDelInfo(sender, e)
    End Sub

    Private Sub list_icmbio_info_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_icmbio_info.KeyDown
        modoDelInfo(sender, e)
    End Sub
    Private Sub list_petrobras_info_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_petrobras_info.KeyDown
        modoDelInfo(sender, e)
    End Sub
    Private Sub list_prefeitura_info_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_prefeitura_info.KeyDown
        modoDelInfo(sender, e)
    End Sub


    Private Sub list_petrobras_titulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_petrobras_titulo.KeyDown
        modoDelTitulo(sender, e)
    End Sub
    Private Sub list_prefeitura_titulo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_prefeitura_titulo.KeyDown
        modoDelTitulo(sender, e)
    End Sub

    Private Sub list_icmbio_documento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_icmbio_documento.KeyDown
        modoDelDocumento(sender, e)
    End Sub
    Private Sub list_icmbio_evento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_icmbio_evento.KeyDown
        modoDelEvento(sender, e)
    End Sub

    Private Sub list_petrobras_documento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_petrobras_documento.KeyDown
        modoDelDocumento(sender, e)
    End Sub
    Private Sub list_petrobras_evento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_petrobras_evento.KeyDown
        modoDelEvento(sender, e)
    End Sub

    Private Sub list_prefeitura_documento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_prefeitura_documento.KeyDown
        modoDelDocumento(sender, e)
    End Sub
    Private Sub list_prefeitura_evento_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_prefeitura_evento.KeyDown
        modoDelEvento(sender, e)
    End Sub



    Private Sub modoDelTitulo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirTitulosSelecionados(log, sender)
                    ListaTitulos(CInt(sender.tag), text_name.Text.Trim, sender)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub

    Private Sub modoDelSD(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirSDSelecionados(log, sender)
                    ListaSD(CInt(sender.tag), text_name.Text.Trim, sender)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub

    Private Sub modoDelMP(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirMPSelecionados(log, sender)
                    ListaMP(CInt(sender.tag), text_name.Text.Trim, sender)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try


    End Sub


    Private Sub modoDelEvento(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""

                    Select Case CInt(sender.tag)
                        Case -2
                            ExcluirEventosSelecionadas(log, sender)
                            ListaEventos( text_name.Text.Trim)
                        Case Else
                            ExcluirNotasSelecionadas(log, sender)
                            ListaNotas(CInt(sender.tag), text_name.Text.Trim, sender)
                    End Select

                  
                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try


    End Sub

    Private Sub modoDelDocumento(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirDocumentosSelecionados(log, sender)
                    ListaDocumentos(CInt(sender.tag), text_name.Text.Trim, sender)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try


    End Sub

    Private Sub modoDelInfo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)

        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirInfoSelecionados(log, sender)
                    ListaInfo(CInt(sender.tag), text_name.Text.Trim, sender)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try


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
    Private Sub list_dnpm_condicao_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_dnpm_condicao.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub

    Private Sub list_cetesb_titulo_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_cetesb_titulo.HyperlinkClicked
        'tratarHyperlink(sender, e)
    End Sub
    Private Sub list_cetesb_mp_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_cetesb_mp.HyperlinkClicked
        'tratarHyperlink(sender, e)
    End Sub
    Private Sub list_cetesb_documento_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_cetesb_documento.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_dnpm_documento_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_dnpm_documento.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_daee_titulo_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_daee_titulo.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_daee_documento_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_daee_documento.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_daee_info_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_daee_info.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub

    Private Sub list_icmbio_info_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_icmbio_info.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_petrobras_info_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_petrobras_info.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_prefeitura_info_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_prefeitura_info.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub

    Private Sub list_icmbio_titulo_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_icmbio_titulo.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_icmbio_documento_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_icmbio_documento.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub


    Private Sub list_petrobras_titulo_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_petrobras_titulo.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_petrobras_documento_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_petrobras_documento.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub


    Private Sub list_prefeitura_titulo_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_prefeitura_titulo.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub
    Private Sub list_prefeitura_documento_HyperlinkClicked(ByVal sender As Object, ByVal e As BrightIdeasSoftware.HyperlinkClickedEventArgs) Handles list_prefeitura_documento.HyperlinkClicked
        tratarHyperlink(sender, e)
    End Sub



    Private Sub list_dnpm_condicao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_dnpm_condicao.KeyDown
        Try


            If e.KeyCode = Keys.Delete Then

                If mode = 1 Then
                    ShowMessage(gettext("custom", 30), "", enErrorType.Warning)
                    Exit Sub
                End If


                If MsgBox(gettext("custom", 8), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then
                    Dim log As String = ""
                    ExcluirCondicoesSelecionados(log)
                    ListaCondicoes(0, text_name.Text.Trim, list_dnpm_condicao)

                    If log.Trim.Length > 0 Then
                        ShowMessage(log, "", enErrorType.Warning)
                    End If

                End If

            End If



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub ExcluirTitulosSelecionados(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In sender.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirTitulo(text_name.Text.Trim, CInt(sender.tag), numero) Then
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

    Private Sub ExcluirSDSelecionados(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In sender.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirSD(text_name.Text.Trim, CInt(sender.tag), numero) Then
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

    Private Sub ExcluirMPSelecionados(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As OLVListItem In sender.SelectedItems

            Dim numero As String = CType(item.RowObject, DataRowView).Row("MPRI_nm_mprima").ToString.Trim  'item.Text.Trim

            'If Not ExcluirMP(text_name.Text.Trim, CInt(sender.tag), numero) Then
            'If log.Trim.Length = 0 Then log += vbCrLf
            'log += numero
            'count += 1
            'End If

            ExcluirMP(text_name.Text.Trim, CInt(sender.tag), numero)

        Next

        If count > 10 Then log = ""
        If log.Trim.Length > 0 Then
            log = gettext("custom", 9) & vbCrLf & log
        End If




    End Sub
    Private Sub ExcluirEventosSelecionadas(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In sender.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirEvento(text_name.Text.Trim, numero) Then
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

    Private Sub ExcluirNotasSelecionadas(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In sender.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirNota(text_name.Text.Trim, CInt(sender.tag), numero) Then
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


    Private Sub ExcluirDocumentosSelecionados(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In sender.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirDocumento(text_name.Text.Trim, CInt(sender.tag), numero) Then
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
    Private Sub ExcluirInfoSelecionados(ByRef log As String, ByVal sender As Object)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In sender.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirInfo(text_name.Text.Trim, CInt(sender.tag), numero) Then
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

    Private Sub ExcluirSubstanciasSelecionadas(ByRef log As String)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As OLVListItem In list_dnpm_substancia.SelectedItems

            Dim numero As String = item.Text.Trim
            Dim numero2 As String = CType(item.RowObject, DataRowView).Row("TUSO_nm_uso").ToString.Trim

            If Not ExcluirSubstancia(text_name.Text.Trim, 0, numero, numero2) Then
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
    Private Sub ExcluirMunicipiosSelecionados(ByRef log As String)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In list_dnpm_municipio.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirMunicipio(text_name.Text.Trim, 0, numero) Then
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
    Private Sub ExcluirAssociadosSelecionados(ByRef log As String)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In list_dnpm_associado.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirAssociado(text_name.Text.Trim, 0, numero) Then
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
    Private Sub ExcluirCondicoesSelecionados(ByRef log As String)
        Dim count As Integer = 0
        Dim erro As Boolean = False

        For Each item As ListViewItem In list_dnpm_condicao.SelectedItems

            Dim numero As String = item.Text.Trim

            If Not ExcluirCondicao(text_name.Text.Trim, 0, numero) Then
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

    Private Function ExcluirTitulo(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PTIT_processo_titulo
        Dim bll As New BLL.tb_PTIT_processo_titulo

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PTIT_nm_titulo = numero
        dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function
    Private Function ExcluirSD(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PRSD_processo_sd
        Dim bll As New BLL.tb_PRSD_processo_sd

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PRSD_nm_sd = numero
        dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function
    Private Function ExcluirMP(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PRMP_processo_mprima
        Dim bll As New BLL.tb_PRMP_processo_mprima

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.MPRI_nm_mprima = numero
        dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function
    Private Function ExcluirNota(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PNOT_processo_nota
        Dim bll As New BLL.tb_PNOT_processo_nota

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PNOT_cd_nota = numero
        dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function

    Private Function ExcluirEvento(ByVal processo As String, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PREV_processo_evento
        Dim bll As New BLL.tb_PREV_processo_evento

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PREV_cd_evento = numero
        Return bll.DeleteData(dto)

    End Function
    Private Function ExcluirDocumento(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PDOC_processo_documento
        Dim bll As New BLL.tb_PDOC_processo_documento

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PDOC_nm_documento = numero
        dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function
    Private Function ExcluirInfo(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PINF_processo_info
        Dim bll As New BLL.tb_PINF_processo_info

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PINF_cd_info = numero
        dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function

    Private Function ExcluirSubstancia(ByVal processo As String, ByVal orgao As Integer, _
                                       ByVal numero As String, ByVal numero2 As String) As Boolean

        Dim dto As New DTO.tb_PSUB_processo_substancia
        Dim bll As New BLL.tb_PSUB_processo_substancia

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.SUBS_nm_substancia = numero
        dto.TUSO_nm_uso = numero2
        'dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function

    Private Function ExcluirMunicipio(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PMUN_processo_municipio
        Dim bll As New BLL.tb_PMUN_processo_municipio

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.MUNI_nm_municipio = numero
        'dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function
    Private Function ExcluirAssociado(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PASO_processo_associado
        Dim bll As New BLL.tb_PASO_processo_associado

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PASO_cd_processo = numero
        'dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function
    Private Function ExcluirCondicao(ByVal processo As String, ByVal orgao As Integer, ByVal numero As String) As Boolean
        Dim dto As New DTO.tb_PCON_processo_condicao
        Dim bll As New BLL.tb_PCON_processo_condicao

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.PCON_cd_condicao = numero
        'dto.ORGA_nm_orgao = orgao
        Return bll.DeleteData(dto)

    End Function

    Private Sub button_dnpm_add_titulo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_dnpm_add_titulo.LinkClicked
        modoAddTitulo(list_dnpm_titulo)
    End Sub
    Private Sub button_cetesb_add_titulo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_cetesb_add_titulo.LinkClicked
        modoAddSD(list_cetesb_titulo)
    End Sub
    Private Sub button_cetesb_add_mp_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_cetesb_add_mp.LinkClicked
        modoAddMP(list_cetesb_mp)
    End Sub
    Private Sub button_cetesb_add_documento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_cetesb_add_documento.LinkClicked
        modoAddDocumento(list_cetesb_documento)
    End Sub
    Private Sub button_cetesb_add_evento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_cetesb_add_evento.LinkClicked
        modoAddEvento(list_cetesb_evento)
    End Sub

    Private Sub button_daee_add_titulo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_daee_add_titulo.LinkClicked
        modoAddTitulo(list_daee_titulo)
    End Sub
    Private Sub button_daee_add_documento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_daee_add_documento.LinkClicked
        modoAddDocumento(list_daee_documento)
    End Sub
    Private Sub button_daee_add_info_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_daee_add_info.LinkClicked
        modoAddInfo(list_daee_info)
    End Sub

    Private Sub button_icmbio_add_info_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_icmbio_add_info.LinkClicked
        modoAddInfo(list_icmbio_info)
    End Sub
    Private Sub button_petrobras_add_info_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_petrobras_add_info.LinkClicked
        modoAddInfo(list_petrobras_info)
    End Sub
    Private Sub button_prefeitura_add_info_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_prefeitura_add_info.LinkClicked
        modoAddInfo(list_prefeitura_info)
    End Sub

    Private Sub button_daee_add_evento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_daee_add_evento.LinkClicked
        modoAddEvento(list_daee_evento)
    End Sub

    Private Sub button_icmbio_add_titulo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_icmbio_add_titulo.LinkClicked
        modoAddTitulo(list_icmbio_titulo)
    End Sub
    Private Sub button_icmbio_add_documento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_icmbio_add_documento.LinkClicked
        modoAddDocumento(list_icmbio_documento)
    End Sub
    Private Sub button_icmbio_add_evento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_icmbio_add_evento.LinkClicked
        modoAddEvento(list_icmbio_evento)
    End Sub
    Private Sub button_add_evento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_add_evento.LinkClicked
        modoAddEvento(list_evento)
    End Sub

    Private Sub button_petrobras_add_titulo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_petrobras_add_titulo.LinkClicked
        modoAddTitulo(list_petrobras_titulo)
    End Sub
    Private Sub button_petrobras_add_documento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_petrobras_add_documento.LinkClicked
        modoAddDocumento(list_petrobras_documento)
    End Sub
    Private Sub button_petrobras_add_evento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_petrobras_add_evento.LinkClicked
        modoAddEvento(list_petrobras_evento)
    End Sub

    Private Sub button_prefeitura_add_titulo_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_prefeitura_add_titulo.LinkClicked
        modoAddTitulo(list_prefeitura_titulo)
    End Sub
    Private Sub button_prefeitura_add_documento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_prefeitura_add_documento.LinkClicked
        modoAddDocumento(list_prefeitura_documento)
    End Sub
    Private Sub button_prefeitura_add_evento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_prefeitura_add_evento.LinkClicked
        modoAddEvento(list_prefeitura_evento)
    End Sub

    Private Sub modoAddTitulo(ByVal sender As Object)

        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_titulo.numero = ""
            form_titulo.modo = 1 'insert
            form_titulo.processo = text_name.Text.Trim
            form_titulo.orgao = CInt(sender.tag)
            If form_titulo.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaTitulos(CInt(sender.tag), text_name.Text.Trim, sender)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub
    Private Sub modoAddSD(ByVal sender As Object)

        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_sd.numero = ""
            form_sd.modo = 1 'insert
            form_sd.processo = text_name.Text.Trim
            form_sd.orgao = CInt(sender.tag)
            If form_sd.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaSD(CInt(sender.tag), text_name.Text.Trim, sender)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub
    Private Sub modoAddMP(ByVal sender As Object)

        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_mp.numero = ""
            form_mp.modo = 1 'insert
            form_mp.processo = text_name.Text.Trim
            form_mp.orgao = CInt(sender.tag)
            If form_mp.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaMP(CInt(sender.tag), text_name.Text.Trim, sender)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub
    
    Private Sub modoAddEvento(ByVal sender As Object)

        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If


            form_evento.numero = ""
            form_evento.modo = 1 'insert
            form_evento.processo = text_name.Text.Trim
            form_evento.orgao = CInt(sender.tag)
            If form_evento.ShowDialog() = Windows.Forms.DialogResult.OK Then
                Select Case CInt(sender.tag)
                    Case -2
                        ListaEventos(text_name.Text.Trim)
                    Case Else
                        ListaNotas(CInt(sender.tag), text_name.Text.Trim, sender)
                End Select

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub


    Private Sub modoAddDocumento(ByVal sender As Object)

        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_documento.numero = ""
            form_documento.modo = 1 'insert
            form_documento.processo = text_name.Text.Trim
            form_documento.orgao = CInt(sender.tag)
            If form_documento.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaDocumentos(CInt(sender.tag), text_name.Text.Trim, sender)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub
    Private Sub modoAddInfo(ByVal sender As Object)

        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_info.numero = ""
            form_info.modo = 1 'insert
            form_info.processo = text_name.Text.Trim
            form_info.orgao = CInt(sender.tag)
            If form_info.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaInfo(CInt(sender.tag), text_name.Text.Trim, sender)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try

    End Sub
    Private Sub button_dnpm_add_substancia_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_dnpm_add_substancia.LinkClicked
        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_substancia.numero = ""
            form_substancia.numero2 = ""
            form_substancia.modo = 1 'insert
            form_substancia.processo = text_name.Text.Trim
            form_substancia.orgao = 0
            If form_substancia.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaSubstancias(0, text_name.Text.Trim, list_dnpm_substancia)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub button_dnpm_add_municipio_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_dnpm_add_municipio.LinkClicked
        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_municipio.numero = ""
            form_municipio.modo = 1 'insert
            form_municipio.processo = text_name.Text.Trim
            form_municipio.orgao = 0
            If form_municipio.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaMunicipios(0, text_name.Text.Trim, list_dnpm_municipio)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub button_dnpm_add_associado_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_dnpm_add_associado.LinkClicked
        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_associado.numero = ""
            form_associado.modo = 1 'insert
            form_associado.processo = text_name.Text.Trim
            form_associado.orgao = 0
            If form_associado.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaAssociados(0, text_name.Text.Trim, list_dnpm_associado)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub button_dnpm_add_condicao_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_dnpm_add_condicao.LinkClicked
        Try

            If mode = 1 Then
                ShowMessage(gettext("custom", 29), "", enErrorType.Warning)
                Exit Sub
            End If

            form_condicao.numero = ""
            form_condicao.modo = 1 'insert
            form_condicao.processo = text_name.Text.Trim
            form_condicao.orgao = 0
            If form_condicao.ShowDialog() = Windows.Forms.DialogResult.OK Then ListaCondicoes(0, text_name.Text.Trim, list_dnpm_condicao)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub resizeform(ByVal expand As Boolean, Optional ByVal add As Boolean = False)



        Select Case expand

            Case False
                If isexpanded Then
                    isexpanded = False
                    tab_main.Height = tab_main.Height - sizeToExpand
                    Me.Height = Me.Height - sizeToExpand
                End If
            Case True

                If Not isexpanded Then
                    isexpanded = True
                    tab_main.Height = tab_main.Height + sizeToExpand
                    Me.Height = Me.Height + sizeToExpand
                    center_form(Me)
                End If

        End Select

    End Sub
    Private Sub listaDados(ByVal code As String, ByVal index As Integer)

        Select Case index
            Case 5 'cetesb
                ListaSD(enOrgao.CETESB, code, list_cetesb_titulo)
                ListaDocumentos(enOrgao.CETESB, code, list_cetesb_documento)
                ListaNotas(enOrgao.CETESB, code, list_cetesb_evento)
                ListaMP(enOrgao.CETESB, code, list_cetesb_mp)
            Case 6 'daee
                ListaTitulos(enOrgao.DAEE, code, list_daee_titulo)
                ListaDocumentos(enOrgao.DAEE, code, list_daee_documento)
                ListaNotas(enOrgao.DAEE, code, list_daee_evento)
                ListaInfo(enOrgao.DAEE, code, list_daee_info)
            Case 7 'icmbio
                ListaTitulos(enOrgao.ICMBIO, code, list_icmbio_titulo)
                ListaDocumentos(enOrgao.ICMBIO, code, list_icmbio_documento)
                ListaNotas(enOrgao.ICMBIO, code, list_icmbio_evento)
                ListaInfo(enOrgao.ICMBIO, code, list_icmbio_info)
            Case 8 'petrobras
                ListaTitulos(enOrgao.PETROBRAS, code, list_petrobras_titulo)
                ListaDocumentos(enOrgao.PETROBRAS, code, list_petrobras_documento)
                ListaNotas(enOrgao.PETROBRAS, code, list_petrobras_evento)
                ListaInfo(enOrgao.PETROBRAS, code, list_petrobras_info)
            Case 9 'prefeitura
                ListaTitulos(enOrgao.PREFEITURA, code, list_prefeitura_titulo)
                ListaDocumentos(enOrgao.PREFEITURA, code, list_prefeitura_documento)
                ListaNotas(enOrgao.PREFEITURA, code, list_prefeitura_evento)
                ListaInfo(enOrgao.PREFEITURA, code, list_prefeitura_info)
        End Select

    End Sub

    Private Sub tab_main_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tab_main.SelectedIndexChanged
        Try

            Me.Cursor = Cursors.WaitCursor

            Select Case tab_main.SelectedIndex
                Case 0, 1, 2, 3
                    resizeform(False)
                Case 4, 5, 6, 7, 8, 9

                    'If expanel_lista.IsExpanded Then expanel_lista.IsExpanded = False
                    resizeform(True)





            End Select


            If text_name.Text.Trim.Length > 0 Then
                Dim code As String = text_name.Text.Trim  'numero processo
                listaDados(code, tab_main.SelectedIndex)
            End If

            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ShowMessage(ex, 0)
        End Try
    End Sub


    Private Function SalvaDadosPorOrgao(ByVal processo As String, ByVal orgao As Integer, ByVal parms() As String) As Boolean

        Dim dto As New DTO.tb_PORG_processo_orgao
        Dim bll As New BLL.tb_PORG_processo_orgao
        Dim ret As Boolean = False
        Dim dt As DataTable

        dto.PROC_cd_processo = processo
        dto.ORGA_nm_orgao = orgao
        dto.PORG_nm_cadastro = parms(0) 'text_cetesb_cadastro.Text.Trim
        dto.PORG_ds_atividade = parms(1) 'text_cetesb_atividade.Text.Trim
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            ret = bll.UpdateData(dto)
        Else
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_inclusao = default_user
            ret = bll.InsertData(dto)
        End If


    End Function
    Private Sub button_cetesb_confirm_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_cetesb_confirm.LinkClicked
        Try
            Dim orgao As Integer = 1 'cetesb
            Dim parms(1) As String
            parms(0) = text_cetesb_cadastro.Text.Trim
            parms(1) = text_cetesb_atividade.Text.Trim
            Dim ret As Boolean = SalvaDadosPorOrgao(text_name.Text, orgao, parms)
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub button_report_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_report.Click
        Try



            'If text_name.Text.Trim.Length = 0 Or 
            If processo.Trim.Length = 0 Or mode = 1 Then
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
        Dim TemPagina As Boolean = True 'list_processo.SelectedItems.Count = 1

        Dim i As Integer = 0

        Dim ImagemMapa As String = ""
        Dim caminhoImagens As String = "tmp\Images"
        Dim arquivoMapa As String = ""

        pbar_down.Minimum = 0
        pbar_down.Maximum = 0 'list_processo.SelectedItems.Count - 1
        pbar_down.Value = 0



        'If list_processo.SelectedItems.Count > 1 Then
        'panel_main.Visible = True
        'Else
        label_progresso.Text = ""
        panel_main.Visible = False
        'End If

        Me.Refresh()
        Application.DoEvents()

        Dim processos(0) As String
        processos(0) = processo

        For Each item As String In processos 'list_processo.SelectedItems

            numeroProcesso = item 'item.Text.Trim
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



                        If processos.Length = 1 Then


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



    Private Sub button_dnpm_add_documento_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles button_dnpm_add_documento.LinkClicked
        modoAddDocumento(list_dnpm_documento)
    End Sub

    Private Sub list_daee_documento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_daee_documento.SelectedIndexChanged

    End Sub


    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Stop()
        Timer1.Enabled = False

        If processo.Trim.Length > 0 Then
            modoEdicao()
        Else
            modoInclusao()
        End If
    End Sub


    Private Sub button_mapa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_mapa.Click
        Try
            'form_mapa.MdiParent = form_main
            If processo.Trim.Length > 0 And mode = 2 Then
                form_mapa.processo = processo
                form_mapa.Show()
            End If

        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub list_cetesb_evento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_cetesb_evento.SelectedIndexChanged

    End Sub
End Class