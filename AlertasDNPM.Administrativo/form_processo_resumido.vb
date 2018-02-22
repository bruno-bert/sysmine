Public Class form_processo_resumido

    
    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PROC_processo
        Dim bll As New BLL.tb_PROC_processo
        Dim message As String = ""
        Dim ret As Boolean = False
        Dim retStr As String = ""
        Dim numero As String = ""
        Dim ano As Integer = 0


        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        If text_name.Text.Trim.Length > 0 Then
            retStr = bll.ValidaNumeroProcesso(text_name.Text.Trim)
            If retStr.Trim.Length > 0 Then
                ShowMessage(retStr, "", enErrorType.Warning)
                Return False
            End If

            Try
                numero = Split(text_name.Text.Trim, "/")(0)
                ano = Split(text_name.Text.Trim, "/")(1)
            Catch ex As Exception

            End Try
        Else
            ShowMessage(gettext("custom", 4), "", enErrorType.Warning)
            Return False
        End If


        dto.AUDT_dt_inclusao = Now
        dto.AUDT_nm_usuario_inclusao = default_user
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user
        dto.PROC_fl_tipo_inclusao = "M"
        dto.PROC_cd_processo = text_name.Text.Trim
        dto.PROC_ds_titular = combo_titular.Text.Trim
        dto.PROC_nm_processo = numero
        dto.PROC_vl_ano = ano

        ret = bll.SaveData(dto, message, 0, 1)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If



        incluirOperadores()

        Return ret

    End Function
    Private Sub incluirOperadores()
        Dim dto As New DTO.tb_PROP_processo_operador
        Dim bll As New BLL.tb_PROP_processo_operador
        Dim dtoOPER As New DTO.tb_OPER_operador
        Dim bllOper As New BLL.tb_OPER_operador
        Dim dtOPER As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        bllOper.ConnectionString = connection
        bllOper.XMLPath = xmlpath

        If text_name.Text.Trim.Length = 0 Then
            ShowMessage(gettext("custom", 2), "", enErrorType.Warning)
            Exit Sub
        End If

        dtoOPER.OPER_fl_alerta_nativo = "S"
        dtOPER = bllOper.PagingData(dtoOPER)

        'inclui operador(es) com flag de alertas nativos = 'S'
        For Each dr As DataRow In dtOPER.Rows
            Try
               
                dto.OPER_cd_operador = dr("OPER_cd_operador")
                dto.PROC_cd_processo = text_name.Text.Trim
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
                dto.AUDT_dt_inclusao = Now
                dto.AUDT_nm_usuario_inclusao = default_user
                bll.InsertData(dto)

            Catch ex As Exception
                'Dim a As Integer = 0
            End Try
        Next
    End Sub
    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try
            If SalvaDados() Then
                Me.Close()
            End If

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub CarregaCombos()
        'empresa
        Dim dt As DataTable
        Dim bll As New BLL.tb_EMPR_empresa
        Dim dto As New DTO.tb_EMPR_empresa

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)
        combo_titular.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_titular.Items.Add(dr("EMPR_ds_empresa"))
        Next

    End Sub
    Private Sub form_processo_resumido_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            MakeFormGlobal(Me)
            CarregaCombos()
            LimpaDetalhes()

            timer_focus.Enabled = True
            timer_focus.Start()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub LimpaDetalhes()
        text_name.Text = ""
        combo_titular.SelectedIndex = 0
    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            text_name.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class