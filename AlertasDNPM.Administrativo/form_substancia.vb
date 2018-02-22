Public Class form_substancia

    Public orgao As Integer = 0 'orgao 
    Public modo As Integer = 0 'insert ou update
    Public processo As String = "" 'no caso do update, guarda numero do processo
    Public numero As String = "" 'no caso do update, guarda numero do titulo
    Public numero2 As String = "" 'no caso do update, guarda numero do titulo


    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PSUB_processo_substancia
        Dim bll As New BLL.tb_PSUB_processo_substancia
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
        'dto.ORGA_nm_orgao = orgao
        dto.SUBS_nm_substancia = combo_substancia.Text.Trim
        dto.TUSO_nm_uso = combo_tuso.Text.Trim
        dto.PSUB_dt_inicio = IIf(date_inicial.Checked, date_inicial.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))
        dto.PSUB_dt_fim = IIf(date_final.Checked, date_final.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))
        dto.PSUB_ds_motivo = text_motivo.Text.Trim
      
        ret = bll.SaveData(dto, message, 0, modo)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If




        Return ret

    End Function
    Private Sub salvaSubstancia()

        If combo_substancia.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_SUBS_substancia
        Dim bll As New BLL.tb_SUBS_substancia
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("SUBS_nm_substancia = '" & combo_substancia.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.SUBS_nm_substancia = combo_substancia.Text.Trim
            'dto.ORGA_nm_orgao = orgao
            ret = bll.InsertData(dto)
        End If


    End Sub

    Private Sub salvaTipoUso()

        If combo_tuso.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_TUSO_tipo_uso
        Dim bll As New BLL.tb_TUSO_tipo_uso
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("TUSO_nm_uso = '" & combo_tuso.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            'dto.ORGA_nm_orgao = orgao
            dto.TUSO_nm_uso = combo_tuso.Text.Trim
            ret = bll.InsertData(dto)
        End If


    End Sub

    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                salvaSubstancia()
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
        'tipo titulo 
        Dim dt As DataTable
        Dim bll As New BLL.tb_SUBS_substancia
        Dim dto As New DTO.tb_SUBS_substancia
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)
        combo_substancia.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_substancia.Items.Add(dr("SUBS_nm_substancia"))
        Next


        Dim bll2 As New BLL.tb_TUSO_tipo_uso
        Dim dto2 As New DTO.tb_TUSO_tipo_uso
        bll2.ConnectionString = connection
        bll2.XMLPath = xmlpath

        dt = bll2.GetData(dto2)
        combo_tuso.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_tuso.Items.Add(dr("TUSO_nm_uso"))
        Next



    End Sub
    Private Sub form_titulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If orgao = -1 Or modo = 0 Or processo.Trim.Length = 0 Then
                Exit Sub
            End If

            If modo = 2 And (numero.Trim.Length = 0 Or numero2.Trim.Length = 0) Then
                Exit Sub
            End If


            MakeFormGlobal(Me)

            'SelecionaTituloJanela(orgao)

            CarregaCombos()
            LimpaDetalhes()

            combo_substancia.Enabled = True
            combo_tuso.Enabled = True

            If modo = 2 Then
                CarregaDetalhes(processo, numero, numero2, orgao)
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
                                ByVal numero2 As String, _
                                ByVal orgao As Integer)

        Dim dt As DataTable
        Dim dto As New DTO.tb_PSUB_processo_substancia
        Dim bll As New BLL.tb_PSUB_processo_substancia

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.SUBS_nm_substancia = numero
        dto.TUSO_nm_uso = numero2
        'dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            combo_substancia.Enabled = False
            combo_tuso.Enabled = False
            combo_substancia.Text = base.AjustaNulo(dt.Rows(0)("SUBS_nm_substancia"))
            combo_tuso.Text = base.AjustaNulo(dt.Rows(0)("TUSO_nm_uso"))

            If IsDate(base.AjustaNulo(dt.Rows(0)("PSUB_dt_inicio"))) Then
                date_inicial.Value = CDate(dt.Rows(0)("PSUB_dt_inicio"))
                date_inicial.Checked = True
            Else
                date_inicial.Value = Now.Date
                date_inicial.Checked = False
            End If

            If IsDate(base.AjustaNulo(dt.Rows(0)("PSUB_dt_fim"))) Then
                date_final.Value = CDate(dt.Rows(0)("PSUB_dt_fim"))
                date_final.Checked = True
            Else
                date_final.Value = Now.Date
                date_final.Checked = False
            End If


            text_motivo.Text = base.AjustaNulo(dt.Rows(0)("PSUB_ds_motivo"))

            modo = 2
        Else
            combo_tuso.Enabled = True
            combo_substancia.Enabled = True
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero & "/" & numero2), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub LimpaDetalhes()
        combo_substancia.SelectedIndex = -1
        combo_tuso.SelectedIndex = -1
        combo_tuso.Text = ""
        combo_substancia.Text = ""
        text_motivo.Text = ""
        date_inicial.Checked = False
        date_final.Checked = False
        'date_inicial.MinDate = N
        'date_inicial.MaxDate = N
        'date_final.MinDate = N
        'date_final.MaxDate = N
    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            combo_substancia.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class