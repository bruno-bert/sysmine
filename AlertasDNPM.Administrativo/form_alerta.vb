Imports BrightIdeasSoftware
Public Class form_alerta

    Private mode As Integer = 0
    Public code As String = ""
    Private Sub ChangeFilterMenuLanguage()
        Dim obj As New Apoio.Globalization
        FilterMenuBuilder.CLEAR_ALL_FILTERS_LABEL = obj.getListValue(dtMensagem, "CLEAR_ALL_FILTERS_LABEL", "filter")
        FilterMenuBuilder.APPLY_LABEL = obj.getListValue(dtMensagem, "APPLY_LABEL", "filter")
        FilterMenuBuilder.FILTERING_LABEL = obj.getListValue(dtMensagem, "FILTERING_LABEL", "filter")
    End Sub


    Private Sub ListaAlertas()

        Dim dto As New DTO.tb_ALER_alerta
        Dim bll As New BLL.tb_ALER_alerta
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        'dto.ALER_fl_sistema = "N"

        dt = bll.PagingData(dto)

        list_alerta.DataSource = New BindingSource(dt, dt.TableName)

        Me.column_name.ImageGetter = AddressOf getImage

        list_alerta.View = View.LargeIcon

    End Sub
    Private Function getImage(ByVal row As Object) As String
        Dim ret As String = ""
        Select Case DirectCast(row, DataRowView).Item("ALER_fl_sistema")
            Case "S" : ret = "alerta_sys"
            Case "N" : ret = "alerta"
        End Select
        Return ret
    End Function


    Private Sub CarregaCombos()

        Dim obj As New Apoio.Globalization
        Dim dt1 As DataTable = obj.getListData(xmlpath, "question")
        Dim dt2 As DataTable = obj.getListData(xmlpath, "question")
        Dim dt3 As DataTable = obj.getListData(xmlpath, "question")
        Dim dt4 As DataTable = obj.getListData(xmlpath, "status")
        Dim dt5 As DataTable = obj.getListData(xmlpath, "question")

        Dim dtfase1 As DataTable = obj.getListData(xmlpath, "fase")
        Dim dtfase2 As DataTable = obj.getListData(xmlpath, "fase")


        combo_flag_fase.ValueMember = "name"
        combo_flag_fase.DisplayMember = "value"
        combo_flag_fase.DataSource = dt1

        combo_flag_evento.ValueMember = "name"
        combo_flag_evento.DisplayMember = "value"
        combo_flag_evento.DataSource = dt2

        combo_flag_geral.ValueMember = "name"
        combo_flag_geral.DisplayMember = "value"
        combo_flag_geral.DataSource = dt3

        combo_flag_status.ValueMember = "name"
        combo_flag_status.DisplayMember = "value"
        combo_flag_status.DataSource = dt4

        combo_fase_anterior.ValueMember = "name"
        combo_fase_anterior.DisplayMember = "value"
        combo_fase_anterior.DataSource = dtfase1

        combo_fase_nova.ValueMember = "name"
        combo_fase_nova.DisplayMember = "value"
        combo_fase_nova.DataSource = dtfase2

        combo_flag_geral2.ValueMember = "name"
        combo_flag_geral2.DisplayMember = "value"
        combo_flag_geral2.DataSource = dt5

    End Sub
    Private Sub form_operador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)

            ChangeFilterMenuLanguage()

            ListaAlertas()
            CarregaCombos()
            LimpaDetalhes()
            ListaProcessos()

            panel_details.Enabled = False
            button_del.Visible = False
            text_name.Enabled = True


            If list_alerta.Items.Count > 0 Then
                If code.Trim.Length = 0 Then
                    list_alerta.SelectedIndex = 0
                Else

                    Dim item As ListViewItem = list_alerta.FindItemWithText(code)

                    If item IsNot Nothing Then
                        list_alerta.SelectedIndex = item.Index
                    Else
                        list_alerta.SelectedIndex = 0
                    End If

                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub



    Private Sub LimpaDetalhes()
        text_sistema.Text = ""
        text_name.Text = ""
        text_desc.Text = ""
        text_codigo_evento.Text = ""

        combo_fase_anterior.SelectedValue = "0"
        combo_fase_nova.SelectedValue = "0"
        combo_flag_geral.SelectedIndex = 0
        combo_flag_geral2.SelectedIndex = 1
        combo_flag_status.SelectedIndex = 0
        combo_flag_fase.SelectedIndex = 0
        combo_flag_evento.SelectedIndex = 0

        For Each item As OLVListItem In list_processo.Items
            item.Checked = False
        Next

    End Sub
    Private Sub CarregaDetalhes(ByVal code As String)

        Dim dt As DataTable
        Dim dto As New DTO.tb_ALER_alerta
        Dim bll As New BLL.tb_ALER_alerta
        Dim fase As Integer = 0

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.ALER_nm_alerta = code
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then

            text_name.Text = dt.Rows(0)("ALER_nm_alerta").ToString.Trim
            text_desc.Text = base.AjustaNulo(dt.Rows(0)("ALER_ds_alerta"))
            text_codigo_evento.Text = base.AjustaNulo(dt.Rows(0)("ALER_cd_evento"))

            combo_flag_geral.SelectedValue = dt.Rows(0)("ALER_fl_qualquer_processo")
            combo_flag_geral2.SelectedValue = dt.Rows(0)("ALER_fl_geral")
            combo_flag_status.SelectedValue = dt.Rows(0)("ALER_fl_status")
            combo_flag_fase.SelectedValue = dt.Rows(0)("ALER_fl_muda_fase")
            combo_flag_evento.SelectedValue = dt.Rows(0)("ALER_fl_muda_evento")

            text_sistema.Text = dt.Rows(0)("ALER_fl_sistema").ToString.Trim

            fase = 0
            If IsNumeric(dt.Rows(0)("ALER_cd_fase_anterior")) Then fase = dt.Rows(0)("ALER_cd_fase_anterior")
            combo_fase_anterior.SelectedValue = fase

            fase = 0
            If IsNumeric(dt.Rows(0)("ALER_cd_fase_nova")) Then fase = dt.Rows(0)("ALER_cd_fase_nova")
            combo_fase_nova.SelectedValue = fase

            mode = 2

            SelecionaProcessosAssociados(code)

        Else
            mode = 1
            ShowMessage(String.Format(gettext("message", 1), code), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub list_alerta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_alerta.SelectedIndexChanged
        Try
            If list_alerta.SelectedIndex <> -1 Then
                Dim id As String = list_alerta.SelectedItem.Text
                If id.Trim.Length > 0 Then
                    tab_main.SelectedIndex = 0
                    CarregaDetalhes(id)
                    panel_details.Enabled = True
                    button_del.Visible = text_sistema.Text.Trim = "N"
                    text_name.Enabled = False

                Else
                    tab_main.SelectedIndex = 0
                    LimpaDetalhes()
                    button_del.Visible = False
                    text_name.Enabled = True
                End If
            Else
                tab_main.SelectedIndex = 0
                LimpaDetalhes()
                button_del.Visible = False
                text_name.Enabled = True
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub button_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_add.Click
        Try
            mode = 1
            LimpaDetalhes()
            text_name.Enabled = True
            panel_details.Enabled = True
            button_del.Visible = False
            text_name.Focus()
            text_sistema.Text = "N"
            tab_main.SelectedIndex = 0
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_ALER_alerta
        Dim bll As New BLL.tb_ALER_alerta
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
            Case 2 'update
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
        End Select

        dto.ALER_nm_alerta = text_name.Text
        dto.ALER_ds_alerta = text_desc.Text
        dto.ALER_cd_evento = text_codigo_evento.Text.Trim
        dto.ALER_fl_muda_fase = combo_flag_fase.SelectedValue.ToString.Trim
        dto.ALER_fl_muda_evento = combo_flag_evento.SelectedValue.ToString.Trim
        dto.ALER_fl_qualquer_processo = combo_flag_geral.SelectedValue.ToString.Trim
        dto.ALER_cd_fase_anterior = combo_fase_anterior.SelectedValue.ToString.Trim
        dto.ALER_cd_fase_nova = combo_fase_nova.SelectedValue.ToString.Trim
        dto.ALER_fl_status = combo_flag_status.SelectedValue.ToString.Trim
        dto.ALER_fl_sistema = "N"
        dto.ALER_fl_geral = combo_flag_geral2.SelectedValue.ToString.Trim


        ret = bll.SaveData(dto, message, 0, mode)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
        End If

        If Not combo_flag_geral.SelectedValue = "S" And Not combo_flag_geral2.SelectedValue = "S" Then
            incluirProcessos()
        Else
            excluirProcessos()
        End If


        Return ret

    End Function
    Private Sub incluirProcessos()
        Dim dto As New DTO.tb_PRAL_processo_alerta
        Dim bll As New BLL.tb_PRAL_processo_alerta

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        If text_name.Text.Trim.Length = 0 Then
            ShowMessage(gettext("custom", 5), "", enErrorType.Warning)
            Exit Sub
        End If


        'inclui alertas selecionados na lista 
        For Each item As ListViewItem In list_processo.Items
            Try
                Select Case item.Checked
                    Case True
                        dto.ALER_nm_alerta = text_name.Text.Trim
                        dto.PROC_cd_processo = item.Text.Trim
                        dto.PRAL_fl_manutencao = "S"
                        dto.AUDT_dt_alteracao = Now
                        dto.AUDT_nm_usuario_alteracao = default_user
                        dto.AUDT_dt_inclusao = Now
                        dto.AUDT_nm_usuario_inclusao = default_user
                        bll.InsertData(dto)
                    Case False
                        dto.ALER_nm_alerta = text_name.Text.Trim
                        dto.PROC_cd_processo = item.Text.Trim
                        bll.DeleteData(dto)
                End Select
            Catch ex As Exception
                Dim a As Integer = 0
            End Try
        Next
    End Sub
    Private Sub excluirProcessos()
        Dim dto As New DTO.tb_PRAL_processo_alerta
        Dim bll As New BLL.tb_PRAL_processo_alerta

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        If text_name.Text.Trim.Length = 0 Then
            ShowMessage(gettext("custom", 6), "", enErrorType.Warning)
            Exit Sub
        End If


        dto.ALER_nm_alerta = text_name.Text.Trim
        'dto.PROC_cd_processo = item.Text.Trim
        bll.DeleteData(dto)

    End Sub

    Private Sub button_confirm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            If text_sistema.Text.Trim = "S" Then
                ShowMessage(gettext("message", 4), "", enErrorType.Warning)
                Exit Sub
            End If


            If SalvaDados() Then

                ListaAlertas()
                CarregaDetalhes(text_name.Text.Trim)

                button_del.Visible = text_sistema.Text.Trim = "N"
                mode = 2
                text_name.Enabled = False

                If code.Trim.Length > 0 Then
                    Me.Close()
                End If

            End If

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


    Private Function Excluir(ByVal code As String) As Boolean
        Dim dto As New DTO.tb_ALER_alerta
        Dim bll As New BLL.tb_ALER_alerta

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.ALER_nm_alerta = code
        Return bll.DeleteData(dto)

    End Function
    Private Sub button_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_del.Click
        Try

            If text_sistema.Text.Trim = "S" Then
                ShowMessage(gettext("message", 4), "", enErrorType.Warning)
                Exit Sub
            End If


            Dim code As String = ""

            Select Case mode
                Case 1 'insert
                    code = text_name.Text.Trim
                Case 2 'update 
                    code = text_name.Text.Trim
            End Select

            If code.Trim.Length > 0 Then

                If MsgBox(String.Format(gettext("message", 2), code), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then

                    If Excluir(code) Then
                        text_name.Enabled = True
                        LimpaDetalhes()
                        button_del.Visible = False
                        mode = 1
                    End If

                    ListaAlertas()

                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub combo_flag_fase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_flag_fase.SelectedIndexChanged
        Try

            Select Case combo_flag_fase.SelectedValue.trim
                Case "S"
                    combo_fase_anterior.Enabled = True
                    combo_fase_nova.Enabled = True
                Case "N"

                    combo_fase_anterior.SelectedIndex = 0
                    combo_fase_anterior.Enabled = False

                    combo_fase_nova.SelectedIndex = 0
                    combo_fase_nova.Enabled = False

            End Select


        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub


    Private Sub SelecionaProcessosAssociados(ByVal code As String)

        Dim dtoPRAL As New DTO.tb_PRAL_processo_alerta
        Dim bllPRAL As New BLL.tb_PRAL_processo_alerta
        Dim dt As DataTable

        bllPRAL.ConnectionString = connection
        bllPRAL.XMLPath = xmlpath

        dtoPRAL.ALER_nm_alerta = code

        dt = bllPRAL.GetData(dtoPRAL)


        For Each item As OLVListItem In list_processo.Items
            item.Checked = dt.Select("PROC_cd_processo = '" & item.Text.Trim & "'").Length > 0
        Next


    End Sub
    Private Sub button_processo_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_processo_add.Click
        Try

            form_processo_resumido.ShowDialog()

            'na volta, atualiza lista de processos
            ListaProcessos()
            If text_name.Text.Trim.Length > 0 Then
                SelecionaProcessosAssociados(text_name.Text.Trim)
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub


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

        'Dim objects As IList = TryCast(olv.Objects, IList)
        'If objects Is Nothing Then
        '    Me.toolStripStatusLabel1.Text = [String].Format("Filtered in {0}ms", stopWatch.ElapsedMilliseconds)
        'Else
        '    Me.toolStripStatusLabel1.Text = [String].Format("Filtered {0} items down to {1} items in {2}ms", objects.Count, olv.Items.Count, stopWatch.ElapsedMilliseconds)
        'End If
    End Sub
    Private Sub ListaProcessos()

        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        list_processo.DataSource = New BindingSource(dt, dt.TableName)

    End Sub
    Private Sub button_processo_refresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_processo_refresh.Click
        Try

            ListaProcessos()
            If text_name.Text.Trim.Length > 0 Then
                SelecionaProcessosAssociados(text_name.Text.Trim)
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub button_confirm_processo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_confirm_processo.Click
        Try

            If Not combo_flag_geral.SelectedValue = "S" And Not combo_flag_geral2.SelectedValue = "S" Then
                incluirProcessos()
            Else
                ShowMessage(gettext("custom", 7), "", enErrorType.Info)
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub


End Class