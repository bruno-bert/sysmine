Imports BrightIdeasSoftware
Public Class form_operador

    Private mode As Integer = 0
    Public code As String = ""
    Private Sub ChangeFilterMenuLanguage()
        Dim obj As New Apoio.Globalization
        FilterMenuBuilder.CLEAR_ALL_FILTERS_LABEL = obj.getListValue(dtMensagem, "CLEAR_ALL_FILTERS_LABEL", "filter")
        FilterMenuBuilder.APPLY_LABEL = obj.getListValue(dtMensagem, "APPLY_LABEL", "filter")
        FilterMenuBuilder.FILTERING_LABEL = obj.getListValue(dtMensagem, "FILTERING_LABEL", "filter")
    End Sub


    Private Sub ListaOperadores()

        Dim dto As New DTO.tb_OPER_operador
        Dim bll As New BLL.tb_OPER_operador
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        list_operator.DataSource = New BindingSource(dt, dt.TableName)

    End Sub
    Private Sub CarregaCombos()
        Dim obj As New Apoio.Globalization
        Dim dt1 As DataTable = obj.getListData(xmlpath, "question")
        Dim dt2 As DataTable = obj.getListData(xmlpath, "question")
        Dim dt3 As DataTable = obj.getListData(xmlpath, "question")

        combo_flag1.ValueMember = "name"
        combo_flag1.DisplayMember = "value"
        combo_flag1.DataSource = dt1

        combo_flag2.ValueMember = "name"
        combo_flag2.DisplayMember = "value"
        combo_flag2.DataSource = dt2

        combo_flag3.ValueMember = "name"
        combo_flag3.DisplayMember = "value"
        combo_flag3.DataSource = dt3

    End Sub
    Private Sub form_operador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)

            ChangeFilterMenuLanguage()

            ListaOperadores()
            CarregaCombos()
            LimpaDetalhes()

            panel_details.Enabled = False
            button_del.Visible = False

            If list_operator.Items.Count > 0 Then
                If code.Trim.Length = 0 Then
                    list_operator.SelectedIndex = 0
                Else

                    Dim item As ListViewItem = list_operator.FindItemWithText(code)

                    If item IsNot Nothing Then
                        list_operator.SelectedIndex = item.Index
                    Else
                        list_operator.SelectedIndex = 0
                    End If

                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub



    Private Sub LimpaDetalhes()
        text_name.Text = ""
        text_email.Text = ""
        combo_flag1.SelectedIndex = 0
        combo_flag2.SelectedIndex = 0
        combo_flag3.SelectedIndex = 0
    End Sub
    Private Sub CarregaDetalhes(ByVal code As String)

        Dim dt As DataTable
        Dim dto As New DTO.tb_OPER_operador
        Dim bll As New BLL.tb_OPER_operador

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.OPER_cd_operador = code
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then

            label_inclusao.Visible = False
            combo_flag3.Visible = False

            text_code.Text = dt.Rows(0)("OPER_cd_operador").ToString.Trim
            text_name.Text = dt.Rows(0)("OPER_nm_operador").ToString.Trim
            text_email.Text = dt.Rows(0)("OPER_ds_email").ToString.Trim

            combo_flag1.SelectedValue = dt.Rows(0)("OPER_fl_alerta")
            combo_flag2.SelectedValue = dt.Rows(0)("OPER_fl_alerta_nativo")

            mode = 2
        Else
            label_inclusao.Visible = True
            combo_flag3.Visible = True
            mode = 1
            ShowMessage(String.Format(gettext("message", 1), code), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub list_operator_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_operator.SelectedIndexChanged
        Try
            If list_operator.SelectedIndex <> -1 Then
                Dim id As String = list_operator.SelectedItem.Text
                CarregaDetalhes(id)
                panel_details.Enabled = True
                button_del.Visible = True
            Else
                LimpaDetalhes()
                button_del.Visible = False
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub button_add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_add.Click
        Try
            mode = 1
            LimpaDetalhes()
            panel_details.Enabled = True
            button_del.Visible = False
            label_inclusao.Visible = True
            combo_flag3.Visible = True
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_OPER_operador
        Dim bll As New BLL.tb_OPER_operador
        Dim message As String = ""
        Dim ret As Boolean = False
        Dim code As String = ""

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        Select Case mode
            Case 1 'insert
                code = CStr(bll.GetNextIndex(dto))
                dto.AUDT_dt_inclusao = Now
                dto.AUDT_nm_usuario_inclusao = default_user
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
            Case 2 'update
                code = text_code.Text
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
        End Select

        dto.OPER_cd_operador = code
        dto.OPER_nm_operador = text_name.Text.Trim
        dto.OPER_ds_email = text_email.Text.Trim
        dto.OPER_fl_alerta = combo_flag1.SelectedValue.ToString.Trim
        dto.OPER_fl_alerta_nativo = combo_flag2.SelectedValue.ToString.Trim



        ret = bll.SaveData(dto, message, 0, mode)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
        End If


        If mode = 1 Then
            If ret Then
                If combo_flag3.SelectedValue.ToString.Trim = "S" Then
                    incluirProcessos(code)
                End If
            End If
        End If


        Return ret

    End Function

    Private Sub incluirProcessos(ByVal codOperador As String)

        Dim dt As DataTable
        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo

        Dim dt1 As DataTable
        Dim ret As Boolean = False
        Dim dto1 As New DTO.tb_PROP_processo_operador
        Dim bll1 As New BLL.tb_PROP_processo_operador
        Dim filtro As String = ""

        bll1.ConnectionString = connection
        bll1.XMLPath = xmlpath

        dt1 = bll1.GetData(dto1)

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)
        For Each dr As DataRow In dt.Rows

            filtro = "PROC_cd_processo = '" & dr("PROC_cd_processo") & "' and OPER_cd_operador = '" & codOperador & "'"

            If dt1.Select(filtro).Length = 0 Then

                dto1.PROC_cd_processo = dr("PROC_cd_processo").ToString.Trim
                dto1.OPER_cd_operador = codOperador
                dto1.AUDT_dt_alteracao = Now
                dto1.AUDT_dt_inclusao = Now
                dto1.AUDT_nm_usuario_alteracao = default_user
                dto1.AUDT_nm_usuario_inclusao = default_user

                ret = bll1.InsertData(dto1)


            End If

        Next

    End Sub
    Private Sub button_confirm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try
            If SalvaDados() Then

                ListaOperadores()
                button_del.Visible = True
                mode = 2
                ' text_name.Enabled = False

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
        Dim dto As New DTO.tb_OPER_operador
        Dim bll As New BLL.tb_OPER_operador

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.OPER_cd_operador = code
        Return bll.DeleteData(dto)

    End Function
    Private Sub button_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_del.Click
        Try
            Dim code As String = ""

            Select Case mode
                Case 1 'insert
                    code = text_code.Text
                Case 2 'update 
                    code = text_code.Text
            End Select

            If code.Trim.Length > 0 Then

                If MsgBox(String.Format(gettext("message", 2), code), MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, gettext("title", 3)) = MsgBoxResult.Yes Then

                    If Excluir(code) Then
                        LimpaDetalhes()
                        button_del.Visible = False
                        mode = 1
                    End If

                    ListaOperadores()

                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class