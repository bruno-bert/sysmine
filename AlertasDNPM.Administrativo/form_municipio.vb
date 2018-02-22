Public Class form_municipio

    Public orgao As Integer = 0 'orgao 
    Public modo As Integer = 0 'insert ou update
    Public processo As String = "" 'no caso do update, guarda numero do processo
    Public numero As String = "" 'no caso do update, guarda numero do titulo

    Private Sub button_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_close.Click
        Try
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Function SalvaDados() As Boolean

        Dim dto As New DTO.tb_PMUN_processo_municipio
        Dim bll As New BLL.tb_PMUN_processo_municipio
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
        dto.MUNI_nm_municipio = combo_nome.Text.Trim
     
        ret = bll.SaveData(dto, message, 0, modo)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If




        Return ret

    End Function
    Private Sub salvaMunicipio()

        If combo_nome.Text.Trim.Length = 0 Then
            Exit Sub
        End If

        Dim dt As DataTable
        Dim dto As New DTO.tb_MUNI_municipio
        Dim bll As New BLL.tb_MUNI_municipio
        Dim ret As Boolean = False
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        dt = bll.GetData(dto)

        If dt.Select("MUNI_nm_municipio = '" & combo_nome.Text.Trim & "'").Length = 0 Then
            dto.AUDT_dt_alteracao = Now
            dto.AUDT_dt_inclusao = Now
            dto.AUDT_nm_usuario_alteracao = default_user
            dto.AUDT_nm_usuario_inclusao = default_user
            dto.MUNI_nm_municipio = combo_nome.Text.Trim
            'dto.ORGA_nm_orgao = orgao
            ret = bll.InsertData(dto)
        End If


    End Sub

    

    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor

            If SalvaDados() Then

                salvaMunicipio()

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

        Dim dt As DataTable
        Dim bll As New BLL.tb_MUNI_municipio
        Dim dto As New DTO.tb_MUNI_municipio
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)
        combo_nome.Items.Clear()
        For Each dr As DataRow In dt.Rows
            combo_nome.Items.Add(dr("MUNI_nm_municipio"))
        Next


      


    End Sub
    Private Sub form_municipio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If orgao = -1 Or modo = 0 Or processo.Trim.Length = 0 Then
                Exit Sub
            End If

            If modo = 2 And numero.Trim.Length = 0 Then
                Exit Sub
            End If


            MakeFormGlobal(Me)

            'SelecionaTituloJanela(orgao)

            CarregaCombos()
            LimpaDetalhes()

            combo_nome.Enabled = True
            button_confirm.Visible = True

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
        Dim dto As New DTO.tb_PMUN_processo_municipio
        Dim bll As New BLL.tb_PMUN_processo_municipio

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.MUNI_nm_municipio = numero
        'dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            combo_nome.Enabled = False
            combo_nome.Text = base.AjustaNulo(dt.Rows(0)("MUNI_nm_municipio"))
            modo = 2
            button_confirm.Visible = False
        Else
            button_confirm.Visible = True
            combo_nome.Enabled = True
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub LimpaDetalhes()
        combo_nome.SelectedIndex = -1
        combo_nome.Text = ""
    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            combo_nome.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class