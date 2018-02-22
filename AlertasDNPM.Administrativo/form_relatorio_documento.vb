Imports BrightIdeasSoftware
Public Class form_relatorio_documento

   



    Private Sub CarregaCombos()

        Dim obj As New Apoio.Globalization
        'Dim dt0 As DataTable = obj.getListData(xmlpath, "tipo_relatorio")
        Dim dt1 As DataTable = obj.getListData(xmlpath, "tipo_visual")
        Dim dt2 As DataTable = obj.getListData(xmlpath, "orgao")
        Dim dt3 As DataTable = obj.getListData(xmlpath, "tipo_documento")
        Dim dt4 As DataTable = obj.getListData(xmlpath, "fase")

        'combo_relatorio.ValueMember = "name"
        'combo_relatorio.DisplayMember = "value"
        'combo_relatorio.DataSource = dt0

        combo_tipo.ValueMember = "name"
        combo_tipo.DisplayMember = "value"
        combo_tipo.DataSource = dt1

        list_orgao.DataSource = dt2
        list_orgao.DisplayMember = "value"

        list_tipo_documento.DataSource = dt3
        list_tipo_documento.DisplayMember = "value"

        list_fase.DataSource = dt4
        list_fase.DisplayMember = "value"

        list_fase2.DataSource = dt4
        list_fase2.DisplayMember = "value"

        'seleciona tudo
        check_tudo_orgao.Checked = True
        check_tudo_tipo_documento.Checked = True

        '

        

        check_fase.Checked = True
        check_fase2.Checked = True

        'SelecionaItensLista(list_orgao, True)
        'SelecionaItensLista(list_tipo_documento, True)
       

    End Sub
    Private Sub SelecionaItensLista(ByVal lista As CheckedListBox, ByVal Status As Boolean)

        For i As Integer = 0 To lista.Items.Count - 1
            lista.SetItemChecked(i, Status)
        Next

    End Sub

    Private Sub form_operador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)


            LimpaCampos()

            CarregaCombos()

            CarregaTitular(list_titular, check_titular)
            CarregaTitular(list_titular2, check_titular2)

            CarregaProcessos()

            'combo_relatorio.Enabled = False


        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub LimpaCampos()
        text_dias.Text = ""
        date_publicacao_de.Checked = False
        date_publicacao_ate.Checked = False
        date_vencimento_de.Checked = False
        date_vencimento_ate.Checked = False
        list_titular.Items.Clear()
        list_titular2.Items.Clear()
        list_fase.Items.Clear()
        list_fase2.Items.Clear()
        list_processo.Items.Clear()
        list_orgao.Items.Clear()
        list_tipo_documento.Items.Clear()
        combo_tipo.Items.Clear()
    End Sub




    Private Sub LimpaDetalhes()

    End Sub



    Private Function validaSelecao() As String

        If tab_main.SelectedIndex = 0 Then

            'dias a vencer
            If text_dias.Text.Trim.Length > 0 Then
                If Not IsNumeric(text_dias.Text) Then
                    Return "Número de Dias a vencer deve ser numérico, inteiro e positivo"
                Else
                    If CInt(text_dias.Text) < 0 Then
                        Return "Número de Dias a vencer deve ser numérico, inteiro e positivo"
                    End If
                End If
            End If

            'data publicação
            If date_publicacao_de.Checked Then
                If date_publicacao_ate.Checked Then
                    If date_publicacao_de.Value > date_publicacao_ate.Value Then
                        Return "Data de Publicação DE deve ser anterior a Data de Publicação ATÉ"
                    End If
                End If
            End If

            'data vencimento
            If date_vencimento_de.Checked Then
                If date_vencimento_ate.Checked Then
                    If date_vencimento_de.Value > date_vencimento_ate.Value Then
                        Return "Data de Vencimento DE deve ser anterior a Data de Vencimento ATÉ"
                    End If
                End If
            End If

        End If
        Return ""
    End Function

    Private Sub button_confirm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_report.Click
        Try

            Dim ret As String = validaSelecao()


            If ret.Trim.Length > 0 Then
                ShowMessage(ret, "", enErrorType.Warning)
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
    Private Function pegaLista(ByVal lista As CheckedListBox, ByVal key As String, _
                               Optional ByVal quotes As String = "") As String

        Dim strLista As String = ""

        If lista.CheckedItems.Count = lista.Items.Count Then
            Return base._strPadrao
        End If

        For Each item As Object In lista.CheckedItems
            If CType(item, DataRowView).Row(key).ToString.Trim.Length > 0 Then
                strLista += quotes & CType(item, DataRowView).Row(key).ToString.Trim & quotes & ","
            End If
        Next

        'tira ultima vírgula
        If strLista.Trim.Length > 0 Then strLista = strLista.Substring(0, strLista.Trim.Length - 1)

        If strLista.Trim.Length = 0 Then strLista = base._strPadrao

        Return strLista
    End Function
    Private Sub GerarRelatorio()
        Select Case tab_main.SelectedIndex
            Case 0
                Select Case combo_tipo.SelectedValue
                    Case "1"
                        GerarRelatorioDocumentos()
                    Case "2"
                        GerarGraficoDocumentos()
                End Select
            Case 1
                GerarRelatorioListagemProcessos()
            Case Else
                ShowMessage("Relatório não implementado..Aguarde próximas versões", "", enErrorType.Info)
        End Select
    End Sub
    Private Sub GerarRelatorioListagemProcessos()


        Dim Path As String = ""
        Dim parameters() As clsReport.parameter
        Dim TableName As String = "TABELA_PROC"
        Dim ds As New DataSet
        Dim myReport1 As New clsReport
        Dim retRel As String = ""
        Dim dt As DataTable
        Dim bll As BLL.tb_PROC_processo
        Dim dto As DTO.tb_PROC_processo
        Dim arquivoReport As String = ""
        Dim logErro As String = ""
        Dim i As Integer = 0
        Dim objGeral As New Apoio.Base

        
        Dim listaTitular As String = pegaLista(list_titular2, "EMPR_nm_empresa")
        Dim listaDesTitular As String = pegaLista(list_titular2, "EMPR_ds_empresa")
        Dim listaFase As String = pegaLista(list_fase2, "name")
        Dim listaDesFase As String = pegaLista(list_fase2, "value")

        Path = "TABELA_PROC.rdlc"

        'pbar_down.Minimum = 0
        'pbar_down.Maximum = list_processo.SelectedItems.Count - 1
        'pbar_down.Value = 0

        'If list_processo.SelectedItems.Count > 1 Then
        '    panel_main.Visible = True
        'Else
        '    label_progresso.Text = ""
        '    panel_main.Visible = False
        'End If

        Me.Refresh()
        Application.DoEvents()


        ds.Tables.Clear()

        'label_progresso.Text = "Coletando dados...Processo " & numeroProcesso

        ' Try


        'busca dados e preenche dataset
        bll = New BLL.tb_PROC_processo
        dto = New DTO.tb_PROC_processo
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        'seta filtros
        dto.PROC_ls_titular = listaDesTitular
        dto.PROC_ls_fase = listaFase

        'chama procedure
        dt = bll.getRelatorioLista(dto)
        dt.TableName = TableName
        ds.Tables.Add(dt)


        'Catch ex As Exception
        '    If logErro.Trim.Length > 0 Then logErro += vbCrLf
        '    logErro += "Processo " & numeroProcesso & ": Erro ao tentar selecionar dados para geração do relatório: " & ex.Message & vbCrLf
        '    GoTo prox
        'End Try


        Dim arrayNome() As String = {"Titular(es)", _
                                     "Fase(s)"}

        Dim arrayValor() As String = {listaDesTitular, _
                                      listaDesFase}

        Dim dtFiltro As DataTable = objGeral.InsereDataFiltro(arrayNome, arrayValor)
        dtFiltro.TableName = "TabelaFiltro"
        ds.Tables.Add(dtFiltro)


        'add parametros
        ReDim Preserve parameters(0)
        parameters(0).name = "Parm"
        parameters(0).value = 0

        'configura report
        myReport1.AddParameters(parameters)
        myReport1.ReportID = "LIstagem"
        myReport1.PrintMode = clsReport.ReportMode.File
        myReport1.OutputFormat = clsReport.ReportFormat.PDF
        myReport1.TemporaryDirectory = "tmp/Report"
        myReport1.IncludeDateTimeOnReportFileName = False

        'Gera Relatório Com Dados
        retRel = myReport1.GenerateReport(Path, ds, TableName, True, arquivoReport)
        If retRel = "OK" Then retRel = ""
        If retRel.Trim.Length > 0 Then
            ShowMessage(retRel, "", enErrorType._Error)
            'If logErro.Trim.Length > 0 Then logErro += vbCrLf
            'logErro += "Processo " & numeroProcesso & ":" & retRel
        Else

            If arquivoReport.Trim.Length > 0 Then
                'mostra PDF na tela
                Dim sInfo As New ProcessStartInfo(arquivoReport)
                Process.Start(sInfo)
            End If

        End If


        'prox:
        'i += 1
        Try
            'pbar_down.Value = i
            Me.Refresh()
            Application.DoEvents()
        Catch ex As Exception

        End Try


        'If logErro.Trim.Length > 0 Then
        'ShowMessage("Lista de Problemas encontrados" & vbCrLf & vbCrLf & logErro, "", enErrorType.Warning)
        ' End If



    End Sub
    Private Sub GerarRelatorioDocumentos()


        Dim Path As String = ""
        Dim parameters() As clsReport.parameter
        Dim TableName As String = "TABELA_DOC"
        Dim ds As New DataSet
        Dim myReport1 As New clsReport
        Dim retRel As String = ""
        Dim dt As DataTable
        Dim bll As BLL.tb_PROC_processo
        Dim dto As DTO.tb_PROC_processo
        Dim arquivoReport As String = ""
        Dim logErro As String = ""
        Dim i As Integer = 0
        Dim objGeral As New Apoio.Base

        Dim TipoVisual As String = combo_tipo.SelectedValue.trim
        Dim DiasCritico As Integer = 30

        Dim listaProc As String = pegaLista(list_processo, "PROC_cd_processo")
        'Dim listaDoc As String = pegaLista(list_documento)
        Dim listaOrgao As String = pegaLista(list_orgao, "name")
        Dim listaTipo As String = pegaLista(list_tipo_documento, "name")
        Dim listaTitular As String = pegaLista(list_titular, "EMPR_nm_empresa")
        Dim listaDesTitular As String = pegaLista(list_titular, "EMPR_ds_empresa", "'")
        Dim listaFase As String = pegaLista(list_fase, "name")
        Dim listaDesFase As String = pegaLista(list_fase, "value")

        Path = "TABELA_DOC.rdlc"
          
        'pbar_down.Minimum = 0
        'pbar_down.Maximum = list_processo.SelectedItems.Count - 1
        'pbar_down.Value = 0

        'If list_processo.SelectedItems.Count > 1 Then
        '    panel_main.Visible = True
        'Else
        '    label_progresso.Text = ""
        '    panel_main.Visible = False
        'End If

        Me.Refresh()
        Application.DoEvents()


        ds.Tables.Clear()

        'label_progresso.Text = "Coletando dados...Processo " & numeroProcesso

        ' Try


        'busca dados e preenche dataset
        bll = New BLL.tb_PROC_processo
        dto = New DTO.tb_PROC_processo
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        'seta filtros
        dto.PROC_ls_processo = listaProc
        dto.PROC_ls_documento = base._strPadrao 'listaDoc
        dto.PROC_ls_tipo = listaTipo
        dto.ORGA_nm_orgao = listaOrgao

        dto.PROC_dt_vencimento_ini = IIf(Not date_vencimento_de.Checked, base._datPadrao, date_vencimento_de.Value)
        dto.PROC_dt_vencimento_fim = IIf(Not date_vencimento_ate.Checked, base._datPadrao, date_vencimento_ate.Value)
        dto.PROC_dt_publicacao_ini = IIf(Not date_publicacao_de.Checked, base._datPadrao, date_publicacao_de.Value)
        dto.PROC_dt_publicacao_fim = IIf(Not date_publicacao_ate.Checked, base._datPadrao, date_publicacao_ate.Value)
        dto.PROC_qt_dias_vencer = IIf(Not IsNumeric(text_dias.Text), base._intPadrao, text_dias.Text)
        dto.PROC_ls_titular = listaDesTitular
        dto.PROC_ls_fase = listaFase

        'chama procedure
        dt = bll.getDocuments(dto)
        dt.TableName = TableName
        ds.Tables.Add(dt)


        'Catch ex As Exception
        '    If logErro.Trim.Length > 0 Then logErro += vbCrLf
        '    logErro += "Processo " & numeroProcesso & ": Erro ao tentar selecionar dados para geração do relatório: " & ex.Message & vbCrLf
        '    GoTo prox
        'End Try


        Dim arrayNome() As String = {"Titular(es)", _
                                     "Fase(s)", _
                                     "Processo(s)", _
                                     "Orgão(s)", _
                                     "Tipo(s) Documento", _
                                     "Dias a Vencer", _
                                     "Data Publicação (DE)", "Data Publicação (ATÉ)", _
                                     "Data Vencimento (DE)", "Data Vencimento (ATÉ)"}

        Dim arrayValor() As String = {listaDesTitular, _
                                      listaDesFase, _
                                      listaProc, listaOrgao, listaTipo, _
                                      IIf(Not IsNumeric(text_dias.Text), "", text_dias.Text), _
                                      IIf(Not date_publicacao_de.Checked, "", date_publicacao_de.Value), _
                                      IIf(Not date_publicacao_ate.Checked, "", date_publicacao_ate.Value), _
                                      IIf(Not date_vencimento_de.Checked, "", date_vencimento_de.Value), _
                                      IIf(Not date_vencimento_ate.Checked, "", date_vencimento_ate.Value)}

        Dim dtFiltro As DataTable = objGeral.InsereDataFiltro(arrayNome, arrayValor)
        dtFiltro.TableName = "TabelaFiltro"
        ds.Tables.Add(dtFiltro)


        'add parametros
        ReDim Preserve parameters(1)
        parameters(0).name = "TipoVisual"
        parameters(0).value = TipoVisual

        parameters(1).name = "DiasCritico"
        parameters(1).value = DiasCritico


        'configura report
        myReport1.AddParameters(parameters)
        myReport1.ReportID = "Vencimentos"
        myReport1.PrintMode = clsReport.ReportMode.File
        myReport1.OutputFormat = clsReport.ReportFormat.PDF
        myReport1.TemporaryDirectory = "tmp/Report"
        myReport1.IncludeDateTimeOnReportFileName = False

        'Gera Relatório Com Dados
        retRel = myReport1.GenerateReport(Path, ds, TableName, True, arquivoReport)
        If retRel = "OK" Then retRel = ""
        If retRel.Trim.Length > 0 Then
            ShowMessage(retRel, "", enErrorType._Error)
            'If logErro.Trim.Length > 0 Then logErro += vbCrLf
            'logErro += "Processo " & numeroProcesso & ":" & retRel
        Else

            If arquivoReport.Trim.Length > 0 Then
                'mostra PDF na tela
                Dim sInfo As New ProcessStartInfo(arquivoReport)
                Process.Start(sInfo)
            End If

        End If


        'prox:
        'i += 1
        Try
            'pbar_down.Value = i
            Me.Refresh()
            Application.DoEvents()
        Catch ex As Exception

        End Try


        'If logErro.Trim.Length > 0 Then
        'ShowMessage("Lista de Problemas encontrados" & vbCrLf & vbCrLf & logErro, "", enErrorType.Warning)
        ' End If



    End Sub
    Private Sub GerarGraficoDocumentos()


        Dim Path As String = ""
        Dim parameters() As clsReport.parameter
        Dim TableName As String = "GRAFICO_DOC"
        Dim ds As New DataSet
        Dim myReport1 As New clsReport
        Dim retRel As String = ""
        Dim dt As DataTable
        Dim bll As BLL.tb_PROC_processo
        Dim dto As DTO.tb_PROC_processo
        Dim arquivoReport As String = ""
        Dim logErro As String = ""
        Dim i As Integer = 0
        Dim objGeral As New Apoio.Base

        Dim TipoVisual As String = combo_tipo.SelectedValue.trim
        Dim DiasCritico As Integer = 30

        Dim listaProc As String = pegaLista(list_processo, "PROC_cd_processo")
        'Dim listaDoc As String = pegaLista(list_documento)
        Dim listaOrgao As String = pegaLista(list_orgao, "name")
        Dim listaTipo As String = pegaLista(list_tipo_documento, "name")
        Dim listaTitular As String = pegaLista(list_titular, "EMPR_nm_empresa")
        Dim listaDesTitular As String = pegaLista(list_titular, "EMPR_ds_empresa", "'")
        Dim listaFase As String = pegaLista(list_fase, "name")
        Dim listaDesFase As String = pegaLista(list_fase, "value")

        Path = "GRAFICO_DOC.rdlc"


        Dim MostrarFiltros As Boolean = False

        Me.Refresh()
        Application.DoEvents()


        ds.Tables.Clear()

    
        'busca dados e preenche dataset
        bll = New BLL.tb_PROC_processo
        dto = New DTO.tb_PROC_processo
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        'seta filtros
        dto.PROC_ls_processo = listaProc
        dto.PROC_ls_documento = base._strPadrao 'listaDoc
        dto.PROC_ls_tipo = listaTipo
        dto.ORGA_nm_orgao = listaOrgao

        dto.PROC_dt_vencimento_ini = IIf(Not date_vencimento_de.Checked, base._datPadrao, date_vencimento_de.Value)
        dto.PROC_dt_vencimento_fim = IIf(Not date_vencimento_ate.Checked, base._datPadrao, date_vencimento_ate.Value)
        dto.PROC_dt_publicacao_ini = IIf(Not date_publicacao_de.Checked, base._datPadrao, date_publicacao_de.Value)
        dto.PROC_dt_publicacao_fim = IIf(Not date_publicacao_ate.Checked, base._datPadrao, date_publicacao_ate.Value)
        dto.PROC_qt_dias_vencer = IIf(Not IsNumeric(text_dias.Text), base._intPadrao, text_dias.Text)
        dto.PROC_ls_titular = listaDesTitular
        dto.PROC_ls_fase = listaFase

        'chama procedure
        dt = bll.getDocuments(dto)
        dt.TableName = TableName
        ds.Tables.Add(dt)



        Dim arrayNome() As String = {"Titular(es)", _
                                     "Fase(s)", _
                                     "Processo(s)", _
                                     "Orgão(s)", _
                                     "Tipo(s) Documento", _
                                     "Dias a Vencer", _
                                     "Data Publicação (DE)", "Data Publicação (ATÉ)", _
                                     "Data Vencimento (DE)", "Data Vencimento (ATÉ)"}

        Dim arrayValor() As String = {listaDesTitular, _
                                      listaDesFase, _
                                      listaProc, listaOrgao, listaTipo, _
                                      IIf(Not IsNumeric(text_dias.Text), "", text_dias.Text), _
                                      IIf(Not date_publicacao_de.Checked, "", date_publicacao_de.Value), _
                                      IIf(Not date_publicacao_ate.Checked, "", date_publicacao_ate.Value), _
                                      IIf(Not date_vencimento_de.Checked, "", date_vencimento_de.Value), _
                                      IIf(Not date_vencimento_ate.Checked, "", date_vencimento_ate.Value)}

        Dim dtFiltro As DataTable = objGeral.InsereDataFiltro(arrayNome, arrayValor)
        dtFiltro.TableName = "TabelaFiltro"
        ds.Tables.Add(dtFiltro)


        'add parametros
        ReDim Preserve parameters(2)
        parameters(0).name = "TipoVisual"
        parameters(0).value = TipoVisual

        parameters(1).name = "DiasCritico"
        parameters(1).value = DiasCritico

        parameters(2).name = "MostrarFiltros"
        parameters(2).value = MostrarFiltros


        'configura report
        myReport1.AddParameters(parameters)
        myReport1.ReportID = "GraficoVenctos"
        myReport1.PrintMode = clsReport.ReportMode.File
        myReport1.OutputFormat = clsReport.ReportFormat.PDF
        myReport1.TemporaryDirectory = "tmp/Report"
        myReport1.IncludeDateTimeOnReportFileName = False

        'Gera Relatório Com Dados
        retRel = myReport1.GenerateReport(Path, ds, TableName, True, arquivoReport)
        If retRel = "OK" Then retRel = ""
        If retRel.Trim.Length > 0 Then
            ShowMessage(retRel, "", enErrorType._Error)
        Else

            If arquivoReport.Trim.Length > 0 Then
                'mostra PDF na tela
                Dim sInfo As New ProcessStartInfo(arquivoReport)
                Process.Start(sInfo)
            End If

        End If


      
        Try
            Me.Refresh()
            Application.DoEvents()
        Catch ex As Exception

        End Try


    End Sub
    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

  
    Private Sub CarregaTitular(ByVal list As CheckedListBox, ByVal check As CheckBox)

        Dim obj As New BLL.tb_EMPR_empresa
        Dim dto As New DTO.tb_EMPR_empresa
        Dim dt As DataTable
        Dim dr() As DataRow
        Dim filtro As String = ""

        obj.ConnectionString = connection
        obj.XMLPath = xmlpath

        dt = obj.GetDataDistinct(dto)

        list.DataSource = dt
        list.DisplayMember = "EMPR_ds_empresa"

        check.Checked = True

    End Sub



    Private Sub CarregaProcessos()

        Dim obj As New BLL.tb_PROC_processo
        Dim dto As New DTO.tb_PROC_processo
        Dim dt As DataTable
        Dim dr() As DataRow
        Dim filtro As String = ""
        Dim listaTitular As String = pegaLista(list_titular, "EMPR_ds_empresa", "'")
        Dim listaFase As String = pegaLista(list_fase, "name", "'")

        obj.ConnectionString = connection
        obj.XMLPath = xmlpath

        dt = obj.GetData(dto)

        'filtra a lista de processos por titular (caso informado)
        If listaTitular <> base._strPadrao Then
            If filtro.Trim.Length > 0 Then filtro += " and "
            filtro += "PROC_ds_titular in (" & listaTitular & ")"
        End If

        If listaFase <> base._strPadrao Then
            If filtro.Trim.Length > 0 Then filtro += " and "
            filtro += "FASE_cd_fase in (" & listaFase & ")"
        End If

        dr = dt.Select(filtro)
        If dr.Length > 0 Then
            dt = dr.CopyToDataTable
        Else
            dt.Rows.Clear()
        End If



        list_processo.DataSource = dt
        list_processo.DisplayMember = "PROC_cd_processo"

        check_tudo_processo.Checked = True
        'SelecionaItensLista(list_processo, True)

    End Sub


  

    Private Sub text_dias_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_dias.KeyPress
        Try


            Dim isKey As Boolean = Char.IsDigit(e.KeyChar) Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(Keys.Delete)
            'Dim isDecimal As Boolean = e.KeyChar.ToString = "."
            If Not isKey Then 'And Not isDecimal Then
                e.Handled = True
            End If

        Catch ex As Exception
            'ShowMessage(ex, 0)
        End Try
    End Sub


    Private Sub check_tudo_processo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_tudo_processo.CheckedChanged
        Try
            SelecionaItensLista(list_processo, CType(sender, CheckBox).Checked)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub check_tudo_orgao_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_tudo_orgao.CheckedChanged
        Try
            SelecionaItensLista(list_orgao, CType(sender, CheckBox).Checked)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub check_tudo_tipo_documento_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles check_tudo_tipo_documento.CheckedChanged
        Try
            SelecionaItensLista(list_tipo_documento, CType(sender, CheckBox).Checked)
        Catch ex As Exception

        End Try
    End Sub

   
   
   
    Private Sub check_titular_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_titular.CheckedChanged
        SelecionaItensLista(list_titular, CType(sender, CheckBox).Checked)
    End Sub
    Private Sub check_titular2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_titular2.CheckedChanged
        SelecionaItensLista(list_titular2, CType(sender, CheckBox).Checked)
    End Sub

    Private Sub check_fase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_fase.CheckedChanged
        SelecionaItensLista(list_fase, CType(sender, CheckBox).Checked)
    End Sub
    Private Sub check_fase2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles check_fase2.CheckedChanged
        SelecionaItensLista(list_fase2, CType(sender, CheckBox).Checked)
    End Sub

   
   
    Private Sub list_titular_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_titular.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                CarregaProcessos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub list_titular_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_titular.LostFocus
        Try
            CarregaProcessos()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub list_fase_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles list_fase.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                CarregaProcessos()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub list_fase_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles list_fase.LostFocus
        Try
            CarregaProcessos()
        Catch ex As Exception

        End Try
    End Sub
    
    Private Sub button_lista_processos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_lista_processos.Click
        Try
            CarregaProcessos()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub list_titular_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_titular.SelectedIndexChanged

    End Sub
End Class