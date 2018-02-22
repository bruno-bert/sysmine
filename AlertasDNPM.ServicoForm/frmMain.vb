Imports System.Net
Imports Ionic.Zip
Imports HtmlAgilityPack


Public Class frmMain

    Private thr As Threading.Thread
    Private thrBackup As Threading.Thread


    Private Delegate Sub addListaDelegate(ByVal Message As String)
    Private Delegate Sub editListaDelegate(ByVal Message As String)
    Private Delegate Sub clearListaDelegate()

    Private dbStatusOK As Boolean = False

    Private maxrows As Integer = 200
    Private log As List(Of String)
  

    Private InicioProcessamento As DateTime
    Private gIDProcesso As String = "Alertas DNPM"

    Private timer_main As Timers.Timer
    Private timer_inicio As Timers.Timer

    Public dtMensagem As DataTable
    Public default_user As String = ""
    Private base As New Apoio.Base
    Private connection As String = base.Setting("connection", 0)
    Private xmlpath As String = base.Setting("xmlpath", 0)
    Private logpath As String = base.Setting("logpath", 0)
    Private tempDir As String = base.Setting("temppath", 0)
    Private tempDocsDir As String = base.Setting("tempdoc", 0)
    Private dirBackup As String = base.Setting("dirBackup", 0)
    Private fileBackup As String = base.Setting("fileBackup", 0)
    Private notifica_usuario As String = base.Setting("notifica_usuario", 0)

    Private default_url As String = ""
    Private default_intervalo As String = ""
    Private default_email As String = ""
    Private default_smtp As String = ""
    Private default_porta As String = ""
    Private default_usuario As String = ""
    Private default_senha As String = ""

    Private default_url_dou As String = ""
    Private default_url_doe As String = ""

    'Private default_tablename As String = "Placemark"
    'Private default_escape_first_row As Boolean = True
    'Private default_column_name As String = "name"
    'Private default_column_description As String = "description"

    Private max_execucao As Integer = 1 'tempo maximo em execução em horas
    Private intervalo_inicio As Integer = 1000 '1 segundo depois que entra, a rotina é executada (pra nao travar a tela no começo)
    Private intervalo_verifica As Integer = base.Setting("tempo_verificacao", 0) ' padrao 30 minutos -> tempo para verificar se é hora de rodar a rotina
    Private roda_completo As String = base.Setting("roda_completo", 0) ' se igual a S, roda rotina completa, a cada verificacao, sem checar horario

    Private maxdbCheckIntent As Integer = 20


    Private NotifyIcon As System.Windows.Forms.NotifyIcon
    Private myIcon As New System.Drawing.Icon("icone.ico")
    'Private Const CP_NOCLOSE_BUTTON As Integer = &H200
    'Protected Overrides ReadOnly Property CreateParams() As CreateParams
    '    Get
    '        Dim myCp As CreateParams = MyBase.CreateParams
    '        myCp.ClassStyle = myCp.ClassStyle Or CP_NOCLOSE_BUTTON
    '        Return myCp
    '    End Get
    'End Property

    Public Enum enErrorType
        _Error = 0
        Warning = 1
        Info = 2
    End Enum
    Public Sub objRotina_AtualizaEntradaLog(ByVal Mensagem As String)
        AtualizaEntradaLog(Mensagem)
    End Sub
    Private Sub AtualizaEntradaLog(ByVal Mensagem As String)
        Mensagem = Format(Now, "dd/MM/yyyy HH:mm:ss") & " - " & Mensagem
        editlista(Mensagem)
        'If log Is Nothing Then log = New List(Of String)
        'log.Add(Mensagem)
        'If Tipo = enErrorType._Error Then SaveError("Servico", Mensagem, "")
    End Sub
    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            e.Cancel = True
            Me.WindowState = FormWindowState.Minimized
            Me.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main()
    End Sub
    Private Sub addlista(ByVal mensagem)

        If Me.InvokeRequired Then
            Dim del As New addListaDelegate(AddressOf addlista)
            Me.Invoke(del, mensagem)
        Else

            lista_main.Items.Add(mensagem)
            'If lista_main.Items.Count > maxrows Then lista_main.Items.RemoveAt(0)
            lista_main.SelectedIndex = lista_main.Items.Count - 1
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

    Private Function ConvertType(ByVal type As enErrorType) As MsgBoxStyle
        Select Case type
            Case enErrorType._Error
                Return MsgBoxStyle.Critical
            Case enErrorType.Info
                Return MsgBoxStyle.Information
            Case enErrorType.Warning
                Return MsgBoxStyle.Exclamation
        End Select
    End Function
    Private Function getTitleMessage(ByVal type As enErrorType) As String
        Select Case type
            Case enErrorType._Error
                Return gettext("title", 0)
            Case enErrorType.Warning
                Return gettext("title", 1)
            Case enErrorType.Info
                Return gettext("title", 2)
        End Select
        Return ""
    End Function


    Public Sub SaveError(ByVal source As String, ByVal message As String, ByVal innermessage As String)
        Dim dto As New DTO.tb_LESI_log_erro_sistema
        Dim bll As New BLL.tb_LESI_log_erro_sistema
        Dim ret As String = ""

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        'dto.LESI_cd_ocorrencia = 0
        dto.LESI_ds_exception = message
        dto.LESI_ds_inexception = innermessage
        dto.LESI_dt_ocorrencia = Now
        dto.LESI_nm_source = IIf(source.Trim.Length > 0, source, gettext("other", 0))
        dto.AUDT_dt_inclusao = Now
        dto.AUDT_nm_usuario_inclusao = default_user
        bll.SaveData(dto, ret, 0, Global.BLL.tb_LESI_log_erro_sistema.Mode.Insert)

        If ret.Trim.Length > 0 Then AdicionaEntradaLog(gettext("message", 0) & ":" & ret, enErrorType.Warning)

    End Sub
    Public Function gettext(ByVal type As String, ByVal id As Integer) As String
        Dim value As String = ""
        Dim obj As New Apoio.Globalization
        value = obj.getListValue(dtMensagem, id, type)
        Return value
    End Function

    Public Function getInner(ByVal inner As Exception)
        If inner.InnerException Is Nothing Then
            Return ""
        Else
            Return inner.InnerException.Message.ToString.Trim
        End If
    End Function

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

        If dt.Rows.Count > 0 Then
            default_url = getParmValue(dt, "URL", default_url)
            default_intervalo = getParmValue(dt, "INTERVALO", default_intervalo)
            default_email = getParmValue(dt, "MAIL", default_email)
            default_smtp = getParmValue(dt, "SMTP", default_smtp)
            default_porta = getParmValue(dt, "PORT", default_porta)
            default_usuario = getParmValue(dt, "USER", default_usuario)
            default_senha = getParmValue(dt, "PASS", default_senha)
        End If



    End Sub
    Private Sub getMessages()
        Dim obj As New Apoio.Globalization
        dtMensagem = obj.getData(xmlpath, "list")
    End Sub


    Private Sub NotifyIcon_DoubleClick()
        Try

            Me.Show()


            If Me.WindowState = FormWindowState.Minimized Then

                Me.WindowState = FormWindowState.Normal

            End If


        Catch ex As Exception

        End Try
    End Sub
   
    Private Sub Inicializacao()


        NotifyIcon = New System.Windows.Forms.NotifyIcon
        NotifyIcon.Icon = myIcon
        NotifyIcon.Text = "Dê duplo clique para exibir o terminal"
        NotifyIcon.Visible = True

        AddHandler NotifyIcon.DoubleClick, AddressOf NotifyIcon_DoubleClick

        Me.Text = "Serviço de Alertas DNPM"
        Me.Hide()
        AdicionaEntradaLog("Iniciando Serviço", enErrorType.Info)

        getMessages()

        default_user = gettext("other", 1)

        thr = New Threading.Thread(AddressOf checkDatabase)
        thr.Start()

    End Sub
    Private Sub checkDatabase()

        'espera sql server entrar
        Dim intent As Integer = 1
        Dim erroBanco As String = ""
        Dim dal As New Apoio.DALBase(connection)
        Do
            System.Threading.Thread.Sleep(5000)
            AdicionaEntradaLog("Tentando realizar conexão com banco de dados...Tentativa " & CStr(intent), enErrorType.Info)
            intent += 1

            If intent > maxdbCheckIntent Then
                AdicionaEntradaLog("Não foi possível realizar conexão com o banco de dados. Na última tentativa, o erro retornado foi: " & erroBanco, enErrorType._Error)
                AdicionaEntradaLog("Aguardando 1 minuto para realizar nova tentativa", enErrorType.Info)
                intent = 1
                System.Threading.Thread.Sleep(60000)
            End If

        Loop While Not dal.checkdbStatus(erroBanco)


        timer_inicio = New Timers.Timer()
        timer_inicio.Interval = intervalo_inicio
        AddHandler timer_inicio.Elapsed, AddressOf timer_inicio_elapsed
        timer_inicio.Enabled = True
        timer_inicio.Start()

        thr.Abort()


    End Sub
    Sub Main()

        Try
            Inicializacao()
        Catch ex As Exception
            AdicionaEntradaLog("Erro na inicialização: " & ex.Message, enErrorType._Error)
        End Try

    End Sub


    Private Sub timer_main_elapsed()
        Try

            AdicionaEntradaLog("Verificando parâmetros do sistema", enErrorType.Info)
            getParms()
            AdicionaEntradaLog("Parâmetros do sistema atualizados com sucesso", enErrorType.Info)

            ProcessaRotina()


        Catch ex As Exception
            AdicionaEntradaLog("Erro em timer_main_elapsed: " & ex.Message, enErrorType._Error)
        End Try
    End Sub

    Private Sub timer_inicio_elapsed()
        Try

            timer_inicio.Enabled = False
            timer_inicio.Stop()

            getParms()

            ProcessaRotina()

            timer_main = New Timers.Timer()

            timer_main.Interval = intervalo_verifica

            AddHandler timer_main.Elapsed, AddressOf timer_main_elapsed

            timer_main.Enabled = True
            timer_main.Start()



        Catch ex As Exception
            AdicionaEntradaLog("Erro em timer_inicio_elapsed: " & ex.Message, enErrorType._Error)
        End Try
    End Sub
    Private Sub AtualizaDataInicioProcesso(ByVal IDProcesso As String, ByVal inicio As DateTime)

        Dim ret As Boolean = False
        Dim dto As New DTO.tb_ROTI_rotina
        Dim bll As New BLL.tb_ROTI_rotina

        bll.XMLPath = xmlpath
        bll.ConnectionString = connection

        AdicionaEntradaLog("Atualizando data de início de execução do processo para " & Format(Now, "dd/MM/yyyy HH:mm:ss"), enErrorType.Info)

        dto.ROTI_nm_rotina = IDProcesso
        dto.ROTI_dt_inicio_execucao = inicio
        dto.AUDT_dt_alteracao = Now
        dto.AUDT_nm_usuario_alteracao = default_user

        ret = bll.UpdateData(dto)

    End Sub
    Private Sub AtualizaDataUltimaTentativa(ByVal IDProcesso As String)
        Dim ret As Boolean = False
        Dim dto As New DTO.tb_ROTI_rotina
        Dim bll As New BLL.tb_ROTI_rotina
        Dim TempoMedio As Integer = 0
        Dim TempoProcessamento As Integer = 0
        Dim dt As DataTable

        bll.XMLPath = xmlpath
        bll.ConnectionString = connection

        dto.ROTI_nm_rotina = IDProcesso

        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then

            'TempoProcessamento = Math.Abs(DateDiff(DateInterval.Second, InicioProcessamento, Now))
            'TempoMedio = (TempoProcessamento + CInt(dt.Rows(0)("ROTI_vl_tempo_medio"))) / 2

            dto.ROTI_nm_rotina = IDProcesso
            'dto.ROTI_dt_ultima_execucao = Now
            'dto.ROTI_vl_tempo_medio = TempoMedio
            dto.ROTI_dt_ultima_tentativa_execucao = Now
            dto.AUDT_nm_usuario_alteracao = Now
            dto.AUDT_nm_usuario_alteracao = default_user

            ret = bll.UpdateData(dto)

        End If

    End Sub
    Private Sub AtualizaDataUltimaExecucao(ByVal IDProcesso As String)
        Dim ret As Boolean = False
        Dim dto As New DTO.tb_ROTI_rotina
        Dim bll As New BLL.tb_ROTI_rotina
        Dim TempoMedio As Integer = 0
        Dim TempoProcessamento As Integer = 0
        Dim dt As DataTable

        bll.XMLPath = xmlpath
        bll.ConnectionString = connection

        dto.ROTI_nm_rotina = IDProcesso

        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then

            TempoProcessamento = Math.Abs(DateDiff(DateInterval.Second, InicioProcessamento, Now))
            TempoMedio = (TempoProcessamento + CInt(dt.Rows(0)("ROTI_vl_tempo_medio"))) / 2

            dto.ROTI_nm_rotina = IDProcesso
            dto.ROTI_dt_ultima_execucao = Now
            dto.ROTI_vl_tempo_medio = TempoMedio
            dto.ROTI_dt_ultima_tentativa_execucao = Now
            dto.AUDT_nm_usuario_alteracao = Now
            dto.AUDT_nm_usuario_alteracao = default_user

            ret = bll.UpdateData(dto)

        End If

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

    Private Function VerificaDataUltimaExecucao(ByVal IDProcesso As String) As String



        Dim dt As DataTable
        Dim dto As New DTO.tb_ROTI_rotina
        Dim bll As New BLL.tb_ROTI_rotina
        Dim DataAtual As DateTime = Now
        Dim DataUltimaExecucao As DateTime
        Dim horas As Integer = 0

        bll.XMLPath = xmlpath
        bll.ConnectionString = connection

        dto.ROTI_nm_rotina = IDProcesso

        dt = bll.GetData(dto)

        If dt.Rows.Count > 0 Then

            If IsDate(dt.Rows(0)("ROTI_dt_ultima_execucao")) Then
                DataUltimaExecucao = CDate(dt.Rows(0)("ROTI_dt_ultima_execucao"))
            Else
                DataUltimaExecucao = "1900-01-01"
            End If


            AdicionaEntradaLog("Data da Última Execução: " & DataUltimaExecucao, enErrorType.Info)

            horas = Math.Abs(DateDiff(DateInterval.Hour, DataAtual, DataUltimaExecucao))
            If horas < default_intervalo Then
                Return "Rotina executada a " & horas & " horas atrás. Não é necessário executar a rotina nesse momento."
            Else
                Return ""
            End If


        Else

            Return "Processo " & IDProcesso & " não encontrado"

        End If



    End Function
    Private Sub AdicionaEntradaLog(ByVal Mensagem As String, ByVal Tipo As enErrorType)
        Mensagem = Format(Now, "dd/MM/yyyy HH:mm:ss") & " - " & Mensagem
        addlista(Mensagem)
        If log Is Nothing Then log = New List(Of String)
        log.Add(Mensagem)
        If Tipo = enErrorType._Error Then SaveError("Servico", Mensagem, "")
    End Sub
    Public Sub objRotina_AdicionaEntradaLog(ByVal Mensagem As String, ByVal Tipo As enErrorType)
        AdicionaEntradaLog(Mensagem, Tipo)
    End Sub
    Private Sub NotificaUsuarioInicio()

        NotifyIcon.BalloonTipText = "Rotina em execução...Não deslique o computador durante a execução da rotina. Caso contrário, dados do sistema poderão ser corrompidos."
        NotifyIcon.BalloonTipTitle = "Aviso"
        NotifyIcon.ShowBalloonTip(10000)

    End Sub
    Private Sub NotificaUsuarioFim()

        NotifyIcon.BalloonTipText = "Execução da rotina finalizada"
        NotifyIcon.BalloonTipTitle = "Aviso"
        NotifyIcon.ShowBalloonTip(10000)

    End Sub
    Private Sub Finaliza()



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

    Private Sub ProcessaRotina()
        Dim Retorno As String = ""
        Dim Mensagem As String = ""
        Dim IDProcesso As String = ""
        Dim EmAndamento As Boolean = False

        Dim objRotina As New BLL.Rotina(connection, xmlpath, logpath, tempDir, tempDocsDir, dirBackup, fileBackup, dtMensagem)

        AddHandler objRotina.evAdicionaEntradaLog, AddressOf objRotina_AdicionaEntradaLog
        AddHandler objRotina.evAtualizaEntradaLog, AddressOf objRotina_AtualizaEntradaLog

        Try

            log = Nothing
            log = New List(Of String)

            '07-05-13
            'backup retirado temporariamente para analisar se erro 
            'está na rotina de backup
            'thrBackup = New Threading.Thread(AddressOf objRotina.Backup)
            'thrBackup.Start()

            'a cada 30 minutos, vai verificar e enviar os emails pendentes
            objRotina.EnviaEmailsPendentes()


            AdicionaEntradaLog("Iniciando rotina de verificação de horário", EventLogEntryType.Information)

            If timer_main IsNot Nothing Then timer_main.Stop()


            IDProcesso = gIDProcesso

            Retorno = VerificaStatusProcesso(IDProcesso)

            If Retorno = "" Then

                Retorno = VerificaDataUltimaExecucao(IDProcesso)

                If Retorno = "" Or roda_completo = "S" Then
                    InicioProcessamento = Now
                    AtualizaDataInicioProcesso(IDProcesso, InicioProcessamento)
                    AtualizaStatusProcesso(IDProcesso, "S")

                    'muda cor da lista 
                    Me.lista_main.BackColor = Color.LightSalmon

                    If notifica_usuario = "S" Then NotificaUsuarioInicio()

                    If objRotina.RealizaTarefas() Then
                        AtualizaDataUltimaExecucao(IDProcesso)
                    End If


                    AtualizaStatusProcesso(IDProcesso, "N")

                    'muda cor da lista 
                    Me.lista_main.BackColor = Color.Linen
                    If notifica_usuario = "S" Then NotificaUsuarioFim()


                Else
                    AdicionaEntradaLog(Retorno, enErrorType.Info)
                End If


            Else
                AdicionaEntradaLog(Retorno, enErrorType.Info)
            End If


            Mensagem = "Rotina executada com sucesso"
            AdicionaEntradaLog(Mensagem, enErrorType.Info)
            AdicionaEntradaLog("Aguardando nova execução de rotina de verificação de horário", enErrorType.Info)

            If timer_main IsNot Nothing Then timer_main.Start()

            GravaLog()
            LimpaLog()

        Catch ex As Exception

            'muda cor da lista 
            Me.lista_main.BackColor = Color.Linen
            If notifica_usuario = "S" Then NotificaUsuarioFim()

            AtualizaDataUltimaTentativa(IDProcesso)
            AtualizaStatusProcesso(IDProcesso, "N")

            Mensagem = "Erro: " & ex.Message
            AdicionaEntradaLog(Mensagem, EventLogEntryType.Error)
            AdicionaEntradaLog("Aguardando nova execução de rotina de verificação de horário", enErrorType.Info)

            timer_main.Start()
        End Try

    End Sub


    Private Sub LimpaLog()
        Try

            'essa rotina limpa os arquivos de log maiores que 5 dias

            Dim info As System.IO.FileInfo
            Dim filesToCheck() As String
            Dim daysToKeep As Integer = 5

            filesToCheck = System.IO.Directory.GetFiles(logpath)

            For Each arquivo As String In filesToCheck
                info = New System.IO.FileInfo(arquivo)
                If Math.Abs(DateDiff(DateInterval.Day, info.CreationTime, Now.Date)) > daysToKeep Then

                    Try
                        System.IO.File.Delete(arquivo)
                    Catch ex As Exception
                        'se der erro nao faz nada
                    End Try

                End If
            Next

        Catch ex As Exception
            'erro ao tentar limpar arquivos de log
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
End Class
