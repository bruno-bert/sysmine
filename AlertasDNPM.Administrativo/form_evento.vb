Public Class form_evento


    Public orgao As Integer = -1 'orgao
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

        Dim dto As New DTO.tb_PNOT_processo_nota
        Dim bll As New BLL.tb_PNOT_processo_nota
        Dim message As String = ""
        Dim ret As Boolean = False
        Dim retStr As String = ""


        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

       
        dto.PROC_cd_processo = processo
        dto.ORGA_nm_orgao = orgao

        Select Case modo
            Case 1
                dto.PNOT_cd_nota = bll.GetNextIndex(dto)
            Case 2
                dto.PNOT_cd_nota = text_numero.Text.Trim
        End Select

        dto.AUDT_dt_inclusao = Now
        dto.AUDT_nm_usuario_inclusao = default_user
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user
        dto.PNOT_ds_nota = text_descricao.Text.Trim
        dto.PNOT_dt_ocorrencia = IIf(date_ocorrencia.Checked, date_ocorrencia.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))


        ret = bll.SaveData(dto, message, 0, modo)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If




        Return ret

    End Function
    Private Function SalvaHistoricoEvento() As Boolean

        Dim dto As New DTO.tb_PREV_processo_evento
        Dim bll As New BLL.tb_PREV_processo_evento
        Dim message As String = ""
        Dim ret As Boolean = False
        Dim retStr As String = ""


        bll.ConnectionString = connection
        bll.XMLPath = xmlpath


        dto.PROC_cd_processo = processo
        dto.PREV_cd_evento = text_numero.Text.Trim
        dto.AUDT_dt_inclusao = Now
        dto.AUDT_nm_usuario_inclusao = default_user
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user
        dto.PREV_ds_evento = text_numero.Text.Trim & " - " & text_descricao.Text.Trim
        dto.PREV_dt_ocorrencia = IIf(date_ocorrencia.Checked, date_ocorrencia.Value.Date, IIf(modo = 1, base._datPadrao, base._datNull))


        ret = bll.SaveData(dto, message, 0, modo)
        If message.Trim.Length > 0 Then
            message = Replace(message, base._chrPulaLinhaGen, base._chrPulaLinhaApp)
            ShowMessage(message, "", 1)
            Return ret
        End If




        Return ret

    End Function

    

    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            sender.enabled = False
            Me.Cursor = Cursors.WaitCursor
            Dim save As Boolean = False

            Select Case orgao
                Case -2
                    save = SalvaHistoricoEvento()
                Case Else
                    save = SalvaDados()
            End Select

            If save Then

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
    
    Private Sub form_titulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If orgao = -1 Or modo = 0 Or processo.Trim.Length = 0 Then
                Exit Sub
            End If

            If modo = 2 And numero.Trim.Length = 0 Then
                Exit Sub
            End If


            MakeFormGlobal(Me)

            SelecionaTituloJanela(orgao)


            LimpaDetalhes()

            


            If modo = 2 Then
                text_numero.Enabled = False
                Select Case orgao
                    Case -2
                        CarregaDetalheshistorico(processo, numero)
                    Case Else
                        CarregaDetalhes(processo, numero, orgao)
                End Select
            Else
                text_numero.Enabled = True
            End If



            timer_focus.Enabled = True
            timer_focus.Start()



        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    Private Sub SelecionaTituloJanela(ByVal orgao As Integer)
        Select Case orgao
            Case -2 : Me.Text = String.Format(Me.Text, "Histórico")
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
        Dim dto As New DTO.tb_PNOT_processo_nota
        Dim bll As New BLL.tb_PNOT_processo_nota

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dto.ORGA_nm_orgao = orgao
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            text_numero.Enabled = False
            text_numero.Text = dt.Rows(0)("PNOT_cd_nota").ToString.Trim
            text_descricao.Text = dt.Rows(0)("PNOT_ds_nota").ToString.Trim
            
            If IsDate(base.AjustaNulo(dt.Rows(0)("PNOT_dt_ocorrencia"))) Then
                date_ocorrencia.Value = CDate(dt.Rows(0)("PNOT_dt_ocorrencia"))
                date_ocorrencia.Checked = True
            Else
                date_ocorrencia.Value = Now.Date
                date_ocorrencia.Checked = False
            End If

            'If orgao <> 0 Then
            '    text_arquivo1.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_local_documento"))
            '    text_arquivo2.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_nome_documento"))
            '    text_arquivo3.Text = base.AjustaNulo(dt.Rows(0)("PTIT_ds_rede_documento"))
            'End If


            modo = 2
        Else
            text_numero.Enabled = False
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub
    Private Sub CarregaDetalheshistorico(ByVal processo As String, _
                                    ByVal numero As String)

        Dim dt As DataTable
        Dim dto As New DTO.tb_PREV_processo_evento
        Dim bll As New BLL.tb_PREV_processo_evento

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.PROC_cd_processo = processo
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then
            text_numero.Enabled = False
            text_numero.Text = dt.Rows(0)("PREV_cd_evento").ToString.Trim
            text_descricao.Text = dt.Rows(0)("PREV_ds_evento").ToString.Trim

            If IsDate(base.AjustaNulo(dt.Rows(0)("PREV_dt_ocorrencia"))) Then
                date_ocorrencia.Value = CDate(dt.Rows(0)("PREV_dt_ocorrencia"))
                date_ocorrencia.Checked = True
            Else
                date_ocorrencia.Value = Now.Date
                date_ocorrencia.Checked = False
            End If

       

            modo = 2
        Else
            text_numero.Enabled = False
            modo = 1
            ShowMessage(String.Format(gettext("message", 1), numero), "", enErrorType.Warning)
            LimpaDetalhes()
        End If


    End Sub

    Private Sub LimpaDetalhes()
        text_numero.Text = ""
        text_descricao.Text = ""
        date_ocorrencia.Checked = False
     
        'text_arquivo1.Text = ""
        'text_arquivo2.Text = ""
        'text_arquivo3.Text = ""

        'date_ocorrencia.MinDate = N
        'date_ocorrencia.MaxDate = N
        
    End Sub

    Private Sub timer_focus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timer_focus.Tick
        Try

            timer_focus.Enabled = False
            timer_focus.Stop()

            text_numero.Focus()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class