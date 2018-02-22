Public Class form_rotina

    Private Delegate Sub setPanelCommandStatus(ByVal Status As Boolean)
    Private Delegate Sub addListaDelegate(ByVal Message As String)
    Private Delegate Sub editListaDelegate(ByVal Message As String)
    Private Delegate Sub clearListaDelegate()

    Private maxrows As Integer = 200
    Private log As List(Of String)
    Private InicioProcessamento As DateTime
    Private gIDProcesso As String = "Alertas DNPM"
    Private max_execucao As Integer = 1 'tempo maximo em execução em horas

    Private default_url As String = ""
    Private default_intervalo As String = ""
    Private default_email As String = ""
    Private default_smtp As String = ""
    Private default_porta As String = ""
    Private default_usuario As String = ""
    Private default_senha As String = ""

    Private default_url_dou As String = ""
    Private default_url_doe As String = ""

    Private thr As Threading.Thread




    Public Enum enErrorType
        _Error = 0
        Warning = 1
        Info = 2
    End Enum

    Public Sub objRotina_AdicionaEntradaLog(ByVal Mensagem As String, ByVal Tipo As enErrorType)
        AdicionaEntradaLog(Mensagem, Tipo)
    End Sub
    Public Sub objRotina_AtualizaEntradaLog(ByVal Mensagem As String)
        AtualizaEntradaLog(Mensagem)
    End Sub
    Public Sub objRotina_FimExecucao(ByVal nIncluidos As Integer, _
                                     ByVal nAtualizados As Integer, _
                                     ByVal nAlertas As Integer, _
                                     ByVal nEmaisOk As Integer, _
                                     ByVal nEmailsPendentes As Integer)
        Dim Mensagem As String = ""
        Dim Resumo As String = ""
        Resumo += "Resumo da execução: " & vbCrLf

        Mensagem = CStr(nIncluidos) & " novo(s) processo(s) minerário(s) incluído(s) no sistema"
        Resumo += Mensagem & vbCrLf
        AdicionaEntradaLog(Mensagem, enErrorType.Info)

        Mensagem = CStr(nAtualizados) & " processo(s) minerário(s) atualizado(s) no sistema"
        Resumo += Mensagem & vbCrLf
        AdicionaEntradaLog(Mensagem, enErrorType.Info)

        Mensagem = CStr(nAlertas) & " alerta(s) gerado(s)"
        Resumo += Mensagem & vbCrLf
        AdicionaEntradaLog(Mensagem, enErrorType.Info)

        Mensagem = CStr(nEmaisOk) & " email(s) enviado(s) com sucesso"
        Resumo += Mensagem & vbCrLf
        AdicionaEntradaLog(Mensagem, enErrorType.Info)

        Mensagem = CStr(nEmailsPendentes) & " email(s) não enviado(s)"
        Resumo += Mensagem & vbCrLf
        AdicionaEntradaLog(Mensagem, enErrorType.Info)


        ShowMessage(Resumo, "", modGeral.enErrorType.Info)
    End Sub

    Private Sub AtualizaStatusProcesso(ByVal IDProcesso As String, ByVal Flag As String)
        Dim ret As Boolean = False
        Dim dto As New DTO.tb_ROTI_rotina
        Dim bll As New BLL.tb_ROTI_rotina

        bll.XMLPath = xmlpath
        bll.ConnectionString = connection

        AdicionaEntradaLog("Atualizando status de execução do processo para " & Flag, enErrorType.Info)

        dto.ROTI_nm_rotina = IDProcesso
        dto.ROTI_fl_status_execucao = Flag
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user

        ret = bll.UpdateData(dto)

    End Sub
    Private Function VerificaStatusProcesso(ByVal IDProcesso As String) As String
        Dim dt As DataTable
        Dim dto As New DTO.tb_ROTI_rotina
        Dim bll As New BLL.tb_ROTI_rotina

        bll.XMLPath = xmlpath
        bll.ConnectionString = connection

        dto.ROTI_nm_rotina = IDProcesso

        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then


            If dt.Rows(0)("ROTI_fl_status_execucao") = "N" Then
                Return ""
            Else

                'Se processo estiver em execução
                'verifica se está assim por mais de N horas
                'se estiver, muda status para N
                'nesse caso, já libera processo pra rodar



                If Math.Abs(DateDiff(DateInterval.Hour, Now, CDate(dt.Rows(0)("ROTI_dt_inicio_execucao")))) > max_execucao Then
                    AtualizaStatusProcesso(IDProcesso, "N")
                    Return ""
                End If

                Return "Processo " & IDProcesso & " já está em andamento"


            End If

        Else

            Return "Processo " & IDProcesso & " não encontrado"

        End If

        Return True

    End Function


    Private Sub ProcessaRotina()

        Dim Retorno As String = ""
        Dim Mensagem As String = ""
        Dim IDProcesso As String = ""
        Dim EmAndamento As Boolean = False

        Dim objRotina As New BLL.Rotina(connection, xmlpath, logpath, tempdir, tempDocsDir, dirBackup, fileBackup, dtMensagem)

        AddHandler objRotina.evAdicionaEntradaLog, AddressOf objRotina_AdicionaEntradaLog
        AddHandler objRotina.evAtualizaEntradaLog, AddressOf objRotina_AtualizaEntradaLog
        AddHandler objRotina.evFimExecucao, AddressOf objRotina_FimExecucao


        Try

            getParms()
            boolExecute = True
            panelCommandStatus(False)


            log = Nothing
            log = New List(Of String)

            'a cada 30 minutos, vai verificar e enviar os emails pendentes
            objRotina.EnviaEmailsPendentes()


            AdicionaEntradaLog("Iniciando rotina", EventLogEntryType.Information)

            'If timer_main IsNot Nothing Then timer_main.Stop()


            IDProcesso = gIDProcesso

            Retorno = VerificaStatusProcesso(IDProcesso)

            If Retorno = "" Then

                'Retorno = VerificaDataUltimaExecucao(IDProcesso)
                Retorno = ""

                If Retorno = "" Then 'Or roda_completo = "S" Then
                    InicioProcessamento = Now
                    'AtualizaDataInicioProcesso(IDProcesso, InicioProcessamento)
                    AtualizaStatusProcesso(IDProcesso, "S")

                    'muda cor da lista 
                    'Me.lista_main.BackColor = Color.LightSalmon

                    'If notifica_usuario = "S" Then NotificaUsuarioInicio()

                    If objRotina.RealizaTarefas() Then
                        'AtualizaDataUltimaExecucao(IDProcesso)
                    End If


                    AtualizaStatusProcesso(IDProcesso, "N")

                    'muda cor da lista 
                    ' Me.lista_main.BackColor = Color.Linen
                    'If notifica_usuario = "S" Then NotificaUsuarioFim()


                Else
                    AdicionaEntradaLog(Retorno, enErrorType.Info)
                End If


            Else
                AdicionaEntradaLog(Retorno, enErrorType.Info)
            End If


            Mensagem = "Rotina executada com sucesso"
            AdicionaEntradaLog(Mensagem, enErrorType.Info)
            'AdicionaEntradaLog("Aguardando nova execução de rotina de verificação de horário", enErrorType.Info)

            'If timer_main IsNot Nothing Then timer_main.Start()

            GravaLog()
            'LimpaLog()

            boolExecute = False
            panelCommandStatus(True)


            ' thr.Abort()


        Catch ex As Exception

            'muda cor da lista 
            'Me.lista_main.BackColor = Color.Linen
            'If notifica_usuario = "S" Then NotificaUsuarioFim()

            'AtualizaDataUltimaTentativa(IDProcesso)
            AtualizaStatusProcesso(IDProcesso, "N")

            Mensagem = "Erro: " & ex.Message
            AdicionaEntradaLog(Mensagem, EventLogEntryType.Error)
            'AdicionaEntradaLog("Aguardando nova execução de rotina de verificação de horário", enErrorType.Info)

            ' timer_main.Start()

            boolExecute = False
            panelCommandStatus(True)

            thr.Abort()




        End Try

    End Sub
    Private Sub panelCommandStatus(ByVal Status As Boolean)

        If Me.InvokeRequired Then
            Dim del As New setPanelCommandStatus(AddressOf panelCommandStatus)
            Me.Invoke(del, Status)
        Else
            panel_command.Enabled = Status
        End If
    End Sub

    Private Sub addlista(ByVal mensagem As String)

        If Me.InvokeRequired Then
            Dim del As New addListaDelegate(AddressOf addlista)
            Me.Invoke(del, mensagem)
        Else

            lista_main.Items.Add(mensagem)
            'If lista_main.Items.Count > maxrows Then lista_main.Items.RemoveAt(0)
            lista_main.SelectedIndex = lista_main.Items.Count - 1
        End If
    End Sub
    Private Sub editlista(ByVal mensagem As String)

        If Me.InvokeRequired Then
            Dim del As New editListaDelegate(AddressOf editlista)
            Me.Invoke(del, mensagem)
        Else

            lista_main.Items(lista_main.Items.Count - 1) = mensagem

            'If lista_main.Items.Count > maxrows Then lista_main.Items.RemoveAt(0)
            'lista_main.SelectedIndex = lista_main.Items.Count - 1
        End If
    End Sub

    Private Sub clearlista()

        If Me.InvokeRequired Then
            Dim del As New clearListaDelegate(AddressOf clearlista)
            Me.Invoke(del)
        Else

            lista_main.Items.Clear()

        End If
    End Sub
    Private Sub AdicionaEntradaLog(ByVal Mensagem As String, ByVal Tipo As enErrorType)
        Mensagem = Format(Now, "dd/MM/yyyy HH:mm:ss") & " - " & Mensagem
        addlista(Mensagem)
        If log Is Nothing Then log = New List(Of String)
        log.Add(Mensagem)
        If Tipo = enErrorType._Error Then SaveError("Servico", Mensagem, "")
    End Sub
    Private Sub AtualizaEntradaLog(ByVal Mensagem As String)
        Mensagem = Format(Now, "dd/MM/yyyy HH:mm:ss") & " - " & Mensagem
        editlista(Mensagem)
        'If log Is Nothing Then log = New List(Of String)
        'log.Add(Mensagem)
        'If Tipo = enErrorType._Error Then SaveError("Servico", Mensagem, "")
    End Sub

    Private Sub form_rotina_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If boolExecute Then
                ShowMessage("Rotina em execução. Aguarde até a execução da rotina terminar para fechar esta janela", "", modGeral.enErrorType.Info)
                e.Cancel = True
            End If
        Catch ex As Exception

        End Try
    End Sub
    Private Sub form_rotina_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            MakeFormGlobal(Me)

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
    

    

    Private Sub GravaLog()

        Dim writer As System.IO.StreamWriter
        Dim fs As System.IO.FileStream
        Dim filename As String = "log_" & Format(Now, "ddMMyyyy_HHmmss") & ".txt"



        Try

            If log IsNot Nothing Then
                fs = New System.IO.FileStream(logpath & "\" & filename, IO.FileMode.Create)
                writer = New System.IO.StreamWriter(fs)

                For Each linha As String In log
                    writer.WriteLine(linha)
                Next

                writer.Close()
                writer.Dispose()
                fs.Close()
                fs.Dispose()
            End If




        Catch ex As Exception
            'erro ao tentar gravar log 
            Try
                writer.Close()
                writer.Dispose()
            Catch ex2 As Exception

            End Try
        End Try
    End Sub
    Private Sub button_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_clear.Click
        Try
            clearlista()
        Catch ex As Exception

        End Try
    End Sub
    Private Function getParmValue(ByVal dt As DataTable, ByVal id As String, ByVal default_value As String) As String
        Dim value As String = ""

        If dt.Rows.Count > 0 Then
            If dt.Select("PGER_cd_parametro = '" & id & "'").Length > 0 Then
                Return base.AjustaNulo(dt.Select("PGER_cd_parametro = '" & id & "'")(0)("PGER_vl_parametro"))
            Else
                Return default_value
            End If
        Else
            Return default_value
        End If

        Return value
    End Function
    Private Sub getParms()
        Dim dt As DataTable
        Dim dto As New DTO.tb_PGER_parametro_geral
        Dim bll As New BLL.tb_PGER_parametro_geral

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        dt = bll.GetData(dto)


        default_url = gettext("parm", 0)
        default_intervalo = gettext("parm", 1)
        default_email = gettext("parm", 2)
        default_smtp = gettext("parm", 3)
        default_porta = gettext("parm", 4)
        default_usuario = gettext("parm", 5)
        default_senha = gettext("parm", 6)

        default_url_dou = gettext("parm", 9)
        default_url_doe = gettext("parm", 10)

        If dt.Rows.Count > 0 Then
            default_url = getParmValue(dt, "URL", default_url)
            default_intervalo = getParmValue(dt, "INTERVALO", default_intervalo)
            default_email = getParmValue(dt, "MAIL", default_email)
            default_smtp = getParmValue(dt, "SMTP", default_smtp)
            default_porta = getParmValue(dt, "PORT", default_porta)
            default_usuario = getParmValue(dt, "USER", default_usuario)
            default_senha = getParmValue(dt, "PASS", default_senha)

            default_url_dou = getParmValue(dt, "URL_DOU", default_url_dou)
            default_url_doe = getParmValue(dt, "URL_DOE", default_url_doe)
        End If



    End Sub
    Private Sub button_execute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button_execute.Click
        Try


            'boolExecute = True
            'panel_command.Enabled = False

            clearlista()

            thr = New Threading.Thread(AddressOf ProcessaRotina)
            thr.Start()

            'ProcessaRotina()

            'panel_command.Enabled = True
            'boolExecute = False

        Catch ex As Exception
            'boolExecute = False
            'panel_command.Enabled = True
            ShowMessage(ex, 0)
        End Try
    End Sub
End Class