Public Class form_backup


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
    Private Sub text_intervalo_keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles text_intervalo.KeyPress

        Try


            Dim isKey As Boolean = Char.IsDigit(e.KeyChar)
            ' Dim isDecimal As Boolean = e.KeyChar.ToString = "."
            If Not isKey Then
                e.Handled = True
            End If

        Catch ex As Exception
            'ShowMessage(ex, 0)
        End Try
    End Sub


    Private Sub button_confirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_confirm.Click
        Try

            Dim dt As DataTable
            Dim bll As New BLL.tb_BACK_backup
            Dim dto As New DTO.tb_BACK_backup

            bll.ConnectionString = connection
            bll.XMLPath = xmlpath
            dto.BACK_cd_backup = 1


            dt = bll.GetData(dto)
            If dt.Rows.Count > 0 Then
                dto.BACK_vl_intervalo = CInt(text_intervalo.Text)
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
                bll.UpdateData(dto)
            Else
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_dt_inclusao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
                dto.AUDT_nm_usuario_inclusao = default_user
                dto.BACK_cd_backup = 1
                dto.BACK_ds_mensagem = ""
                dto.BACK_fl_execucao = "N"
                dto.BACK_fl_tipo = "A"
                dto.BACK_dt_backup = CDate("1900-01-01")
                dto.BACK_nm_arquivo = ""
                dto.BACK_vl_intervalo = CInt(text_intervalo.Text)
                bll.InsertData(dto)
            End If

            CarregaDetalhes()

            ShowMessage("Intervalo entre backups atualizado com sucesso", "", enErrorType.Info)

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub

    Private Sub form_titulo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            MakeFormGlobal(Me)

            CarregaDetalhes()

        Catch ex As Exception
            ShowMessage(ex, 0)
        End Try
    End Sub
    
    Private Sub CarregaDetalhes()

        Dim dt As DataTable
        Dim dto As New DTO.tb_BACK_backup
        Dim bll As New BLL.tb_BACK_backup

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dto.BACK_cd_backup = 1
        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then

            text_intervalo.Text = dt.Rows(0)("BACK_vl_intervalo")
            text_nome.Text = base.AjustaNulo(dt.Rows(0)("BACK_nm_arquivo"))
            text_erro.Text = base.AjustaNulo(dt.Rows(0)("BACK_ds_mensagem"))
            text_status.Text = converteStatus(base.AjustaNulo(dt.Rows(0)("BACK_fl_execucao")))
            text_data_backup.Text = base.AjustaNulo(dt.Rows(0)("BACK_dt_backup"))
            'text_data_sinc.Text = toDate(dt.Rows(0)("BACK_dt_sincronizacao"))
            text_data_tentativa.Text = toDate(dt.Rows(0)("BACK_dt_tentativa_execucao"))
        Else
            limpadetalhes()

        End If


    End Sub
    Private Sub limpadetalhes()
        text_intervalo.Text = ""
        text_nome.Text = ""
        text_erro.Text = ""
        text_status.Text = ""
        text_data_backup.Text = ""
        'text_data_sinc.Text = ""
        text_data_tentativa.Text = ""
    End Sub
    Private Function converteStatus(ByVal status As String) As String
        Select Case status
            Case "" : Return "Nunca executado"
            Case "S" : Return "Em andamento"
            Case "N" : Return "Aguardando execução"
        End Select
        Return ""
    End Function
    Private Function toDate(ByVal _date As Object) As String
        If IsDate(_date) Then
            Return Format(CDate(_date), "dd/MM/yyyy HH:mm:ss")
        Else
            Return ""
        End If
    End Function

    


    Private Sub button_backup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_backup.Click
        Try

            Dim obj As New Apoio.DALBase(connection)
            Dim dt As DataTable
            Dim bll As New BLL.tb_BACK_backup
            Dim dto As New DTO.tb_BACK_backup

            bll.ConnectionString = connection
            bll.XMLPath = xmlpath


            dto.BACK_cd_backup = 1

          
            button_backup.Enabled = False
           Me.Cursor = Cursors.WaitCursor

            dt = bll.GetData(dto)
            If dt.Rows.Count > 0 Then
                If dt.Rows(0)("BACK_fl_execucao") = "N" Then
                    dto.BACK_fl_execucao = "S"
                    dto.BACK_fl_tipo = "M"
                    dto.AUDT_dt_alteracao = Now
                    dto.AUDT_nm_usuario_alteracao = default_user
                    bll.UpdateData(dto)
                Else

                    button_backup.Enabled = True
                    Application.DoEvents()
                    Me.Refresh()
                    Me.Cursor = Cursors.Arrow

                    'já está em execucao
                    ShowMessage("Backup já está em andamento...Aguarde", "", enErrorType.Info)
                End If
            Else

                dto.AUDT_dt_alteracao = Now
                dto.AUDT_dt_inclusao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
                dto.AUDT_nm_usuario_inclusao = default_user
                dto.BACK_cd_backup = 1
                dto.BACK_ds_mensagem = ""
                dto.BACK_fl_execucao = "S"
                dto.BACK_fl_tipo = "M"
                dto.BACK_nm_arquivo = ""
                dto.BACK_dt_backup = CDate("1900-01-01")
                If Not IsNumeric(text_intervalo.Text) Then
                    dto.BACK_vl_intervalo = 60 'minutos
                Else
                    dto.BACK_vl_intervalo = CInt(text_intervalo.Text)
                End If


                bll.InsertData(dto)
            End If



            Dim result As String = obj.BackupDatabase("dbDNPM", dirBackup & "\" & fileBackup)

            dto.BACK_vl_intervalo = base._intPadrao

            If result.Trim.Length > 0 Then
                'erro
                dto.BACK_fl_execucao = "N"
                dto.BACK_dt_tentativa_Execucao = Now
                dto.BACK_nm_arquivo = fileBackup
                dto.BACK_ds_mensagem = result
                dto.AUDT_dt_alteracao = Now
                dto.BACK_fl_tipo = "M"
                dto.AUDT_nm_usuario_alteracao = default_user
            Else
                'sucesso
                dto.BACK_fl_execucao = "N"
                dto.BACK_dt_tentativa_Execucao = Now
                dto.BACK_dt_execucao = Now
                dto.BACK_dt_backup = Now
                dto.BACK_nm_arquivo = fileBackup
                dto.BACK_ds_mensagem = ""
                dto.AUDT_dt_alteracao = Now
                dto.BACK_fl_tipo = "M"
                dto.AUDT_nm_usuario_alteracao = default_user
            End If

            bll.UpdateData(dto)

            button_backup.Enabled = True
            Me.Cursor = Cursors.Arrow
            CarregaDetalhes()

            If result.Trim.Length = 0 Then
                ShowMessage("Backup realizado com sucesso", "", enErrorType.Info)
            Else
                ShowMessage(result, "", enErrorType.Warning)
            End If

        Catch ex As Exception

            button_backup.Enabled = True
            Me.Cursor = Cursors.Arrow

            ShowMessage(ex, 0)
        End Try
    End Sub
End Class