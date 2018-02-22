Imports BrightIdeasSoftware
Public Class form_empresa

    Private mode As Integer = 0
    Private Sub ChangeFilterMenuLanguage()
        Dim obj As New Apoio.Globalization
        FilterMenuBuilder.CLEAR_ALL_FILTERS_LABEL = obj.getListValue(dtMensagem, "CLEAR_ALL_FILTERS_LABEL", "filter")
        FilterMenuBuilder.APPLY_LABEL = obj.getListValue(dtMensagem, "APPLY_LABEL", "filter")
        FilterMenuBuilder.FILTERING_LABEL = obj.getListValue(dtMensagem, "FILTERING_LABEL", "filter")
    End Sub


    Private Sub ListaEmpresas()

        Dim dto As New DTO.tb_EMPR_empresa
        Dim bll As New BLL.tb_EMPR_empresa
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)

        list_empresa.DataSource = New BindingSource(dt, dt.TableName)

    End Sub
    Private Sub CarregaCombos()

        Dim obj As New Apoio.Globalization
        Dim dt1 As DataTable = obj.getListData(xmlpath, "status")
       
        combo_flag.ValueMember = "name"
        combo_flag.DisplayMember = "value"
        combo_flag.DataSource = dt1

        'If combo_flag.Items.Count > 0 Then combo_flag.SelectedItem = "S"
      

    End Sub
    Private Sub form_empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)

            ChangeFilterMenuLanguage()

            ListaEmpresas()
            CarregaCombos()
            LimpaDetalhes()
            text_name.Enabled = True
            panel_details.Enabled = False
            button_del.Visible = False

            If list_empresa.Items.Count > 0 Then
                list_empresa.SelectedIndex = 0
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub



    Private Sub LimpaDetalhes()
        text_name.Text = ""
        text_desc.Text = ""
        text_dou.Text = ""
        combo_flag.SelectedIndex = 0
    End Sub
    Private Sub CarregaDetalhes(ByVal code As String)

        Dim dt As DataTable
        Dim dto As New DTO.tb_EMPR_empresa
        Dim bll As New BLL.tb_EMPR_empresa

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.EMPR_nm_empresa = code
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then


            text_name.Text = dt.Rows(0)("EMPR_nm_empresa").ToString.Trim
            text_desc.Text = dt.Rows(0)("EMPR_ds_empresa").ToString.Trim
            text_dou.Text = dt.Rows(0)("EMPR_ds_dou").ToString.Trim
            combo_flag.SelectedValue = dt.Rows(0)("EMPR_fl_status")
            mode = 2
        Else
            mode = 1
            ShowMessage(String.Format(gettext("message", 1), code), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub list_empresa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles list_empresa.SelectedIndexChanged
        Try
            If list_empresa.SelectedIndex <> -1 Then
                Dim id As String = list_empresa.SelectedItem.Text
                CarregaDetalhes(id)
                text_name.Enabled = False
                panel_details.Enabled = True
                button_del.Visible = True
            Else
                text_name.Enabled = True
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
            text_name.Enabled = True
            panel_details.Enabled = True
            button_del.Visible = False
            text_name.Focus()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_EMPR_empresa
        Dim bll As New BLL.tb_EMPR_empresa
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

        dto.EMPR_nm_empresa = text_name.Text.Trim
        dto.EMPR_ds_empresa = text_desc.Text.Trim
        dto.EMPR_ds_dou = text_dou.Text.Trim
        dto.EMPR_fl_status = combo_flag.SelectedValue.ToString.Trim


        ret = bll.SaveData(dto, message, 0, mode)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
        End If

        Return ret

    End Function


    Private Sub button_confirm_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try
            If SalvaDados() Then
                ListaEmpresas()
                button_del.Visible = True
                text_name.Enabled = False
                mode = 2
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
        Dim dto As New DTO.tb_EMPR_empresa
        Dim bll As New BLL.tb_EMPR_empresa

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.EMPR_nm_empresa = code
        Return bll.DeleteData(dto)

    End Function

    Private Sub button_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_del.Click
        Try
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
                        LimpaDetalhes()
                        button_del.Visible = False
                        mode = 1
                    End If

                    ListaEmpresas()

                End If

            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class