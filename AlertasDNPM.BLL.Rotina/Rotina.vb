Imports System.Net
Imports Ionic.Zip
Imports HtmlAgilityPack
Imports System.Threading
Public Class Rotina

    Private thr As Thread

    Private numIncluidos As Integer = 0
    Private numAtualizados As Integer = 0
    Private numAlertas As Integer = 0
    Private numEmailsOk As Integer = 0
    Private numEmailsPendentes As Integer = 0

    Private baseAlertaGeral As DataTable
    Private baseAlerta As DataTable
    Private baseLocal As DataTable

    Private dtMensagem As DataTable
    Private default_user As String = ""
    Private base As New Apoio.Base
    Private connection As String = ""
    Private xmlpath As String = ""
    Private logpath As String = ""
    Private tempDir As String = ""
    Private tempDocsDir As String = ""
    Private dirBackup As String = ""
    Private filebackup As String = ""

    Private default_url As String = ""
    Private default_intervalo As String = ""
    Private default_email As String = ""
    Private default_smtp As String = ""
    Private default_porta As String = ""
    Private default_usuario As String = ""
    Private default_senha As String = ""

    Private default_url_dou As String = ""
    Private default_url_doe As String = ""
    Private default_sec_dou As String = ""
    Private default_sec_doe As String = ""
    Private default_url_dou_frame As String = ""
    Private default_url_doe_frame As String = ""

    'parametros para alertas de vencimento
    Private default_int As String = "" 'intervalo de envio em dias a partir do primeiro envio
    Private default_ini As String = "" 'dias para primeiro envio

    Private default_tablename As String = "Placemark"
    Private default_escape_first_row As Boolean = True
    Private default_column_name As String = "name"
    Private default_column_description As String = "description"


    Public Enum enErrorType
        _Error = 0
        Warning = 1
        Info = 2
    End Enum
    Public Event evAdicionaEntradaLog(ByVal Message As String, ByVal Tipo As enErrorType)
    Public Event evAtualizaEntradaLog(ByVal Message As String)
    'Public Event evDownloadProgress(ByVal percent As Integer)
    Public Event evFimExecucao(ByVal nIncluidos As Integer, ByVal nAtualizados As Integer, ByVal nAlertas As Integer, ByVal nEmaisOk As Integer, ByVal nEmailsPendentes As Integer)
    Public Sub New(ByVal lxmlpath As String)
        xmlpath = lxmlpath
    End Sub
    Public Sub New(ByVal lconnection As String, _
                   ByVal lxmlpath As String, _
                   ByVal llogPath As String, _
                   ByVal ltempDir As String, _
                   ByVal ltempDocsDir As String, _
                   ByVal ldirbackup As String, _
                   ByVal lfileBackup As String, _
                   ByVal ldtMensagem As DataTable)

        connection = lconnection
        xmlpath = lxmlpath
        logpath = llogPath
        tempDir = ltempDir
        tempDocsDir = ltempDocsDir
        dirbackup = ldirbackup
        fileBackup = lfileBackup
        dtMensagem = ldtMensagem

        default_user = gettext("other", 1)

        getParms()

    End Sub
    
  
  
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

        default_ini = gettext("parm", 7)
        default_int = gettext("parm", 8)

        default_url_dou = gettext("parm", 9)
        default_url_doe = gettext("parm", 10)

        default_sec_dou = gettext("parm", 11)
        default_url_dou_frame = gettext("parm", 12)
        default_url_doe_frame = gettext("parm", 13)

        default_sec_doe = gettext("parm", 14)

        If dt.Rows.Count > 0 Then

            default_url = getParmValue(dt, "URL", default_url)
            default_intervalo = getParmValue(dt, "INTERVALO", default_intervalo)
            default_email = getParmValue(dt, "MAIL", default_email)
            default_smtp = getParmValue(dt, "SMTP", default_smtp)
            default_porta = getParmValue(dt, "PORT", default_porta)
            default_usuario = getParmValue(dt, "USER", default_usuario)
            default_senha = getParmValue(dt, "PASS", default_senha)
            default_ini = getParmValue(dt, "INI", default_ini)
            default_int = getParmValue(dt, "INT", default_int)

            default_url_dou = getParmValue(dt, "URL_DOU", default_url_dou)
            default_url_doe = getParmValue(dt, "URL_DOE", default_url_doe)

            default_sec_dou = getParmValue(dt, "SEC_DOU", default_sec_dou)
            default_sec_doe = getParmValue(dt, "SEC_DOE", default_sec_doe)

            default_url_dou_frame = getParmValue(dt, "URLDOUMAIN", default_url_dou_frame)
            default_url_doe_frame = getParmValue(dt, "URLDOEMAIN", default_url_doe_frame)

        End If



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
    Private Function gettext(ByVal type As String, ByVal id As Integer) As String
        Dim value As String = ""
        Dim obj As New Apoio.Globalization
        value = obj.getListValue(dtMensagem, id, type)
        Return value
    End Function
    Public Sub Backup()

        

        Dim dt As DataTable
        Dim bll As New BLL.tb_BACK_backup
        Dim dto As New DTO.tb_BACK_backup
        Dim obj As New Apoio.DALBase(connection)

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        Try

       

            dto.BACK_cd_backup = 1

            dt = bll.GetData(dto)
            If dt.Rows.Count = 0 Then
                'insere 
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_dt_inclusao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
                dto.AUDT_nm_usuario_inclusao = default_user
                dto.BACK_cd_backup = 1
                dto.BACK_ds_mensagem = ""
                dto.BACK_fl_execucao = "S"
                dto.BACK_fl_tipo = "A"
                dto.BACK_nm_arquivo = ""
                dto.BACK_dt_backup = CDate("1900-01-01")
                dto.BACK_vl_intervalo = 60 'minutos
                bll.InsertData(dto)
            End If

inicio:
            dt = bll.GetData(dto)
            If dt.Rows.Count > 0 Then

                Dim intervalo As Integer = CInt(dt.Rows(0)("BACK_vl_intervalo")) * 60000

                If dt.Rows(0)("BACK_fl_execucao") = "N" Then

                    Dim result As String = obj.BackupDatabase("dbDNPM", dirBackup & "\" & filebackup)

                    dto.BACK_vl_intervalo = base._intPadrao

                    If result.Trim.Length > 0 Then
                        'erro
                        dto.BACK_fl_execucao = "N"
                        dto.BACK_dt_tentativa_Execucao = Now
                        dto.BACK_nm_arquivo = filebackup
                        dto.BACK_ds_mensagem = result
                        dto.AUDT_dt_alteracao = Now
                        dto.BACK_fl_tipo = "A"
                        dto.AUDT_nm_usuario_alteracao = default_user
                    Else
                        'sucesso
                        dto.BACK_fl_execucao = "N"
                        dto.BACK_dt_tentativa_Execucao = Now
                        dto.BACK_dt_execucao = Now
                        dto.BACK_dt_backup = Now
                        dto.BACK_nm_arquivo = filebackup
                        dto.BACK_ds_mensagem = ""
                        dto.AUDT_dt_alteracao = Now
                        dto.BACK_fl_tipo = "A"
                        dto.AUDT_nm_usuario_alteracao = default_user
                    End If

                    bll.UpdateData(dto)

                End If

                Thread.Sleep(intervalo)
                GoTo inicio

            End If

        Catch ex As Exception
            Thread.Sleep(60000)
        End Try



    End Sub
    Public Function RealizaTarefas() As Boolean

        Dim parte0 As Boolean = False
        Dim parte1 As Boolean = False
        Dim parte2 As Boolean = False
        Dim parte3 As Boolean = False

      


        numIncluidos = 0
        numAtualizados = 0
        numAlertas = 0
        numEmailsOk = 0
        numEmailsPendentes = 0




        If DownloadArquivoDNPM(tempDir, default_url, True, False, "") Then

            SincronizaProcessos()

            If baseAlerta IsNot Nothing Then TratamentoAlertas()

            parte1 = True

        End If

        'parte1 = True


        parte2 = AlertasVencimento()

        'parte2 = True


        If VerificaAlertaDO() Then
            parte3 = TratamentoAlertasDO()
        Else
            parte3 = True
        End If

        'parte3 = True

        RaiseEvent evFimExecucao(numIncluidos, numAtualizados, numAlertas, numEmailsOk, numEmailsPendentes)


        If parte1 And parte2 And parte3 Then
            Return True
        Else
            Return False
        End If


    End Function
    Private Function VerificaAlertaDO() As Boolean

        Dim dto As New DTO.tb_HSAL_historico_alerta
        Dim bll As New BLL.tb_HSAL_historico_alerta
        Dim dt As DataTable
        Dim dr() As DataRow
        Dim filtro As String = "HSAL_fl_status = 'S' and HSAL_dt_envio >= '" & Format(Now.Date, "yyyy-MM-dd") & "'"

        bll.XMLPath = xmlpath
        bll.ConnectionString = connection

        dto.ALER_nm_alerta = "DO"
        dto.PROC_cd_processo = "DO"
        dt = bll.PagingData(dto)
        dr = dt.Select(filtro, "HSAL_id_historico desc")

        If dr.Length > 0 Then
            If IsDate(dr(0)("HSAL_dt_envio")) Then
                If Format(CDate(dr(0)("HSAL_dt_envio")), "dd-MM-yyyy") = Format(Now, "dd-MM-yyyy") And CDate(dr(0)("HSAL_dt_envio")).Hour > 6 Then
                    AdicionaEntradaLog("Rotina de geração de alertas do Diário Oficial já foi executada hoje", enErrorType.Info)
                    Return False
                End If
            End If
        End If

        Return True

    End Function
    Private Sub SendMessage(ByVal message As String, ByVal type As Integer)
        AdicionaEntradaLog(message, type)
    End Sub
    Private Function TratamentoAlertasDO() As Boolean

        Dim dto As New DTO.tb_HSAL_historico_alerta
        Dim bll As New BLL.tb_HSAL_historico_alerta
        Dim id As Integer


        Dim parte1 As Boolean = False
        Dim parte2 As Boolean = False
        Dim parte3 As Boolean = False
        Dim parte4 As Boolean = False
        Dim parte5 As Boolean = False
        Dim parte6 As Boolean = False

        Dim myDOUFiles As String()
        Dim myDOEFile As String = ""
        Dim myMainDOUFile As String = ""
        Dim secoes() As Integer = {1}
        Dim totalPagSec(secoes.Length - 1) As Integer
        Dim i As Integer = 0
        Dim obj As New JornaisOnline.DiarioOficial
        AddHandler obj.sendMessage, AddressOf SendMessage

        Try


            Try

                id = pega_id_historico()
                bll.XMLPath = xmlpath
                bll.ConnectionString = connection

                dto.ALER_nm_alerta = "DO"
                dto.PROC_cd_processo = "DO"
                dto.HSAL_id_historico = id
                dto.HSAL_dt_tentativa_ultimo_envio = Now
                dto.HSAL_ds_email = ""
                dto.HSAL_ds_mensagem = ""
                dto.HSAL_ds_assunto_email = ""
                dto.HSAL_ds_texto_email = ""
                dto.HSAL_fl_status = "N"
                dto.AUDT_dt_inclusao = Now
                dto.AUDT_nm_usuario_inclusao = default_user

                bll.InsertData(dto)

            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar gravar log histórico de execução de Alertas DO: " & ex.Message, enErrorType._Error)
            End Try



            'faz download do arquivo principal do diário oficial da união
            'por esse arquivo , consigo pegar o total de páginas de cada seção

            For Each secao As Integer In secoes

                obj.DownloadArquivoPrincipal(tempDocsDir, False, myMainDOUFile, default_url_dou_frame, secao)
                If IO.File.Exists(myMainDOUFile) Then
                    totalPagSec(i) = obj.PegaTotalPaginas(myMainDOUFile)
                    IO.File.Delete(myMainDOUFile)
                End If

                myMainDOUFile = ""

                'se não conseguiu encontrar o total de páginas
                'significa que não encontrou o diário oficial no dia
                'isso ocorre por exemplo, em feriados ou fins de semana
                'nesse caso, não segue em frente
                If totalPagSec(i) = -1 Then
                    AdicionaEntradaLog("Total de páginas não identificado para DOU seção " & secao & ". Possivelmente é fim de semana ou feriado", enErrorType.Info)
                    GoTo prox
                End If

                i += 1

            Next





            parte2 = obj.DownloadPaginas(tempDocsDir, _
                                            default_url_dou, _
                                            True, myDOUFiles, _
                                            secoes, default_sec_dou, _
                                            totalPagSec)

            If myDOUFiles IsNot Nothing Then
                If myDOUFiles.Length > 0 Then
                    parte3 = AlertasDOU(myDOUFiles)
                End If
            End If







prox:
            obj.ExcluiTudoDirTemp(tempDocsDir, "")


            'faz download do arquivo do diário do estado
            Dim obj1 As New JornaisOnline.DiarioOficialSP
            AddHandler obj1.sendMessage, AddressOf SendMessage
            Dim myMainDOEfile As String = ""
            Dim myDOEFiles() As String
            Dim totalPaginas As Integer = 0
            Dim Cadernos() As Integer = {3, 4}
            Dim totalPagCad(Cadernos.Length - 1) As Integer
            Dim j As Integer = 0
            Dim sec_doe As String = ""

            For Each caderno As Integer In Cadernos
                obj1.DownloadArquivoPrincipal(tempDocsDir, True, myMainDOEfile, default_url_doe_frame, caderno)
                If IO.File.Exists(myMainDOEfile) Then
                    totalPagCad(j) = obj1.PegaTotalPaginas(myMainDOEfile)
                    IO.File.Delete(myMainDOEfile)
                End If

                'se não conseguiu encontrar o total de páginas
                'significa que não encontrou o diário oficial no dia
                'isso ocorre por exemplo, em feriados ou fins de semana
                'nesse caso, não segue em frente
                If totalPagCad(j) = -1 Then
                    AdicionaEntradaLog("Total de páginas não identificado para Diário Oficial do Estado caderno " & caderno & ". Possivelmente é fim de semana ou feriado", enErrorType.Info)
                    GoTo final
                End If

                j += 1

            Next



            'baixa paginas 
            i = 0
            j = 0
            For Each caderno As Integer In Cadernos

                Select Case caderno
                    'para empresarial, como são poucas páginas, baixa todas
                    'então, manda a subsecao como vazio ""
                    Case 3 : sec_doe = "" 'empresarial
                    Case 4 : sec_doe = default_sec_doe 'executivo 1
                End Select

                parte5 = obj1.DownloadPaginas(tempDocsDir, _
                                           default_url_doe_frame, _
                                           default_url_doe, _
                                           True, myDOEFiles, _
                                           i, _
                                           caderno, _
                                           sec_doe, _
                                           totalPagCad(j))

                j += 1
            Next


            If myDOEFiles IsNot Nothing Then
                If myDOEFiles.Length > 0 Then
                    parte6 = AlertasDOE(myDOEFiles)
                End If
            End If

            dto = New DTO.tb_HSAL_historico_alerta
            dto.ALER_nm_alerta = "DO"
            dto.PROC_cd_processo = "DO"
            dto.HSAL_ds_mensagem = ""
            dto.HSAL_id_historico = id
            dto.HSAL_fl_status = "S"
            dto.HSAL_dt_envio = Now
            bll.UpdateData(dto)




final:
            obj.ExcluiTudoDirTemp(tempDocsDir, "")


           

            Return True


        Catch ex As Exception


            Try

                dto = New DTO.tb_HSAL_historico_alerta
                dto.ALER_nm_alerta = "DO"
                dto.PROC_cd_processo = "DO"
                dto.HSAL_ds_mensagem = ex.Message
                dto.HSAL_id_historico = id
                dto.HSAL_fl_status = "N"
                dto.HSAL_dt_envio = Now
                bll.UpdateData(dto)

            Catch ex2 As Exception

            End Try


            AdicionaEntradaLog("Erro em TratamentoAlertasDO: " & ex.Message, enErrorType._Error)
            Return False
        End Try

    End Function
    
    Private Function CriaTabelaAlertaVencimento() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add("operador")
        dt.Columns.Add("processo")
        dt.Columns.Add("titular")
        dt.Columns.Add("orgao")
        dt.Columns.Add("tipo_documento")
        dt.Columns.Add("data_vencimento")
        dt.Columns.Add("data_publicacao")
        dt.Columns.Add("dias_para_vencer")
        dt.Columns.Add("link")
        dt.Columns.Add("id_documento")
        dt.Columns.Add("tipo_envio")

        dt.TableName = "AlertasVencimento"

        Return dt
    End Function
    Private Function CriaTabelaAlertaDOU() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add("Operador")
        dt.Columns.Add("Processo")
        dt.Columns.Add("Titular")
        dt.Columns.Add("Documento")
        dt.Columns.Add("Arquivos")
        dt.Columns.Add("Link")
        dt.TableName = "AlertasDO"

        Return dt
    End Function
    Private Function CriaTabelaAlertaDOE() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add("Operador")
        dt.Columns.Add("Empresa")
        dt.Columns.Add("Documento")
        dt.Columns.Add("Arquivos")
        dt.TableName = "AlertasDO"

        Return dt
    End Function

    Private Function converteOrgao(ByVal orgao As String) As String
        Select Case orgao
            Case "0" : Return "DNPM"
            Case "1" : Return "CETESB"
            Case "2" : Return "DAEE"
            Case "3" : Return "ICMBIO"
            Case "4" : Return "PETROBRÁS"
            Case "5" : Return "PREFEITURAS"
        End Select
        Return orgao
    End Function
    Private Function CalculaDiasVencimento(ByVal dt1 As Date, ByVal dt2 As Date) As Integer
        Return DateDiff(DateInterval.Day, dt1, dt2)
    End Function
    Private Function DescricaoTipoEnvio(ByVal codigo As Integer) As String
        Select Case codigo
            Case 1 : Return "Primeiro Aviso"
            Case 2 : Return "Aviso Periódico"
            Case 3 : Return "Último Aviso - Documento Venceu"
        End Select
        Return codigo
    End Function
    Private Function ColToRow(ByVal dr As DataRow) As DataTable
        Dim dt As New DataTable
        Dim drNew As DataRow
        dt.Columns.Add("descricao")
        dt.Columns.Add("Valor")

        For Each col As DataColumn In dr.Table.Columns

            drNew = dt.NewRow

            drNew("descricao") = col.ColumnName
            drNew("Valor") = dr(col).ToString.Trim

            dt.Rows.Add(drNew)

        Next

        Return dt

    End Function
    Public Function AlertasDOU(ByVal myDOUFiles() As String) As Boolean
        Try

            Dim dt As DataTable
            Dim bll As New tb_PROC_processo
            Dim dto As New DTO.tb_PROC_processo



            Dim bllHIST As New BLL.tb_HSAL_historico_alerta
            Dim dtoHIST As New DTO.tb_HSAL_historico_alerta
            Dim dtHIST As DataTable
            Dim filtroHIST As String = ""
            Dim drHIST() As DataRow

            Dim dtAlerta As DataTable
            Dim drAlerta As DataRow
            Dim drCheck() As DataRow

            Dim processo As String = ""
            Dim titular As String = ""
            Dim link As String = ""

            Dim email As New Apoio.EmailAlertaDOU
            Dim emailGeral As New Apoio.EmailGeral
            Dim nomeAlerta As String = "Diário Oficial da União"
            Dim assuntoEmail As String = ""
            Dim textoEmail As String = ""

            Dim dtoProp As New DTO.tb_PROP_processo_operador
            Dim bllProp As New BLL.tb_PROP_processo_operador
            Dim dtProp As DataTable
            Dim filtroProp As String = ""
            Dim drProp() As DataRow
            Dim operador As String = ""

            Dim objDOU As New JornaisOnline.DiarioOficial
            Dim douText As String = ""
            Dim processo_dou As String = ""

            dtAlerta = CriaTabelaAlertaDOU()


            bllProp.ConnectionString = connection
            bllProp.XMLPath = xmlpath
            dtProp = bllProp.PagingData(dtoProp)

            bll.ConnectionString = connection
            bll.XMLPath = xmlpath

            bllHIST.ConnectionString = connection
            bllHIST.XMLPath = xmlpath



            dt = bll.GetData(dto)

            dtHIST = bllHIST.GetData(dtoHIST)

            For Each douFile As String In myDOUFiles


                douText = objDOU.PDFToText(douFile, 1)


                For Each dr As DataRow In dt.Rows

                   

                    processo = dr("PROC_cd_processo")
                    titular = dr("PROC_ds_titular")
                    link = dr("PROC_ds_link")

                    processo_dou = Left(dr("PROC_nm_processo"), 3) & "." & Right(dr("PROC_nm_processo"), 3) & "/" & dr("PROC_vl_ano")

                 

                    filtroProp = "PROC_cd_processo = '{0}' and OPER_fl_alerta = 'S'"
                    filtroProp = String.Format(filtroProp, processo)
                    drProp = dtProp.Select(filtroProp)

                    'se nao tem nenhum operador relacionado ao processo
                    'não tem pra quem mandar email, 
                    'então segue para proximo processo
                    If drProp.Length = 0 Then GoTo proxProcesso


                    If douText.Contains(processo_dou) Then
                        For Each rProp As DataRow In drProp

                            drCheck = dtAlerta.Select("processo = '" & processo & "' and operador = '" & rProp("OPER_ds_email") & "'")
                            If drCheck.Length = 0 Then
                                drAlerta = dtAlerta.NewRow
                                drAlerta("processo") = processo
                                drAlerta("titular") = titular
                                drAlerta("link") = link
                                drAlerta("operador") = rProp("OPER_ds_email")
                                drAlerta("documento") = "DOU" 'Left(douFile.Substring(douFile.LastIndexOf("\") + 1, douFile.Length - douFile.LastIndexOf("\") - 1), 3)
                                drAlerta("arquivos") = douFile
                                dtAlerta.Rows.Add(drAlerta)
                            Else
                                drAlerta = drCheck(0)
                                drAlerta.BeginEdit()
                                drAlerta("arquivos") = drAlerta("arquivos") & "|" & douFile
                                drAlerta.EndEdit()
                            End If
                        Next
                       
                    End If

proxProcesso:
                Next
            Next


           


            If dtAlerta.Rows.Count > 0 Then


                'Dim dtDistinctOper As DataTable = base.SelectDistinct(dtAlerta.TableName, dtAlerta, "operador")
                Dim emailOperador As String = ""
                Dim id_historico As Integer = 0
                Dim dtoHSAL As New DTO.tb_HSAL_historico_alerta
                Dim bllHSAL As New BLL.tb_HSAL_historico_alerta
                bllHSAL.ConnectionString = connection
                bllHSAL.XMLPath = xmlpath



                For Each dr As DataRow In dtAlerta.Rows

                    emailOperador = dr("operador")
                    processo = dr("processo")

                    'verifica se para o processo/operador/tipo alerta
                    'já foi enviado email no dia atual
                    'se sim, não manda denovo
                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                    dtoHSAL.ALER_nm_alerta = nomeAlerta
                    dtoHSAL.PROC_cd_processo = dr("processo")
                    dtoHSAL.HSAL_ds_email = dr("operador")
                    'dtoHSAL.HSAL_fl_status = "S"
                    Dim dtHistCheck As DataTable = _
                    bllHSAL.PagingData(dtoHSAL)

                    If dtHistCheck.Rows.Count > 0 Then
                        If IsDate(dtHistCheck.Rows(0)("HSAL_dt_envio")) Then
                            If Format(CDate(dtHistCheck.Rows(0)("HSAL_dt_envio")), "dd-MM-yyyy") = Format(Now, "dd-MM-yyyy") Then
                                AdicionaEntradaLog("Alerta DOU já enviado hoje para Processo " & processo & " - Email: " & emailOperador, enErrorType.Info)
                                GoTo proxAlerta
                            End If
                        End If
                    End If

                    numAlertas += 1

                    assuntoEmail = email.MontaAssuntoEmail(nomeAlerta, dr("processo"))


                    textoEmail = email.MontaTextoEmail(ColToRow(dr).Rows, dr("processo"), dr("documento"))

                    'inclui HSAL
                    AdicionaEntradaLog("Gravando histórico de alertas DOU para Processo " & processo & " - Email: " & emailOperador, enErrorType.Info)

                    'grava email na tabela de historico de alertas
                    'caso este fique pendente de envio
                    'essa tabela historica será lida numa proxima execucao
                    'e o(s) email(s) pendente(s) serão enviados
                    dtoHSAL = New DTO.tb_HSAL_historico_alerta

                    Try
                        AdicionaEntradaLog("Buscando próximo ID de histórico", enErrorType.Info)
                        id_historico = pega_id_historico()
                        AdicionaEntradaLog("Próximo ID de histórico selecionado com sucesso [" & CStr(id_historico) & "]", enErrorType.Info)
                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar buscar próximo ID de histórico: " & ex.Message, enErrorType._Error)
                    End Try


                    dtoHSAL.AUDT_dt_inclusao = Now
                    dtoHSAL.AUDT_nm_usuario_inclusao = default_user
                    dtoHSAL.ALER_nm_alerta = nomeAlerta
                    dtoHSAL.HSAL_ds_assunto_email = assuntoEmail
                    dtoHSAL.HSAL_ds_email = emailOperador
                    dtoHSAL.HSAL_ds_mensagem = ""
                    dtoHSAL.HSAL_ds_texto_email = textoEmail
                    dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                    dtoHSAL.HSAL_fl_status = "N"
                    dtoHSAL.PROC_cd_processo = dr("processo")
                    dtoHSAL.HSAL_id_historico = id_historico


                    bllHSAL.ConnectionString = connection
                    bllHSAL.XMLPath = xmlpath

                    If bllHSAL.InsertData(dtoHSAL) Then
                        AdicionaEntradaLog("Histórico de alertas gravado com sucesso para Processo " & processo & " - Email: " & emailOperador, enErrorType.Info)
                    Else
                        AdicionaEntradaLog("Não foi possível gravar o histórico de alerta para Processo " & processo & " - Email: " & emailOperador, enErrorType._Error)
                    End If

                    Try

                        Dim attaches() As String = Split(dr("arquivos"), "|")

                        emailGeral.EnviaEmail(default_smtp, default_porta, default_email, emailOperador, default_usuario, default_senha, assuntoEmail, textoEmail, attaches, True, Nothing)

                        numEmailsOk += 1

                        'atualiza HSAL - nao pendente
                        AdicionaEntradaLog("Atualizando histórico de alerta para não pendente - Processo " & processo & " - Email: " & emailOperador, enErrorType.Info)

                        dtoHSAL = New DTO.tb_HSAL_historico_alerta
                        dtoHSAL.HSAL_ds_mensagem = ""
                        dtoHSAL.HSAL_dt_envio = Now
                        dtoHSAL.HSAL_fl_status = "S"
                        dtoHSAL.HSAL_id_historico = id_historico

                        If bllHSAL.UpdateData(dtoHSAL) Then
                            AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para não pendente para Processo " & processo & " - Email: " & emailOperador, enErrorType.Info)
                        Else
                            AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para não pendente para Processo " & processo & " - Email: " & emailOperador, enErrorType._Error)
                        End If


                    Catch ex As Exception

                        numEmailsPendentes += 1

                        'atualiza HSAL - pendente
                        AdicionaEntradaLog("Atualizando histórico de alerta para pendente no Processo " & processo & " - Email: " & emailOperador, enErrorType.Info)

                        dtoHSAL = New DTO.tb_HSAL_historico_alerta
                        dtoHSAL.HSAL_ds_mensagem = ex.Message
                        dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                        dtoHSAL.HSAL_fl_status = "N"
                        dtoHSAL.HSAL_id_historico = id_historico

                        If bllHSAL.UpdateData(dtoHSAL) Then
                            AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente no Processo " & processo & " - Email: " & emailOperador, enErrorType.Info)
                        Else
                            AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente no Processo " & processo & " - Email: " & emailOperador, enErrorType._Error)
                        End If


                    End Try



proxAlerta:
                Next


            Else
                AdicionaEntradaLog("Não há alertas DOU", enErrorType.Info)
            End If




            Return True

        Catch ex As Exception
            AdicionaEntradaLog("Erro na rotina AlertasDOU: " & ex.Message, enErrorType._Error)
            Return False
        End Try
    End Function
    Public Function AlertasDOE(ByVal myDOEFiles() As String) As Boolean
        Try

            Dim dt As DataTable
            Dim bll As New BLL.tb_EMPR_empresa
            Dim dto As New DTO.tb_EMPR_empresa



            Dim bllHIST As New BLL.tb_HSAL_historico_alerta
            Dim dtoHIST As New DTO.tb_HSAL_historico_alerta
            Dim dtHIST As DataTable
            Dim filtroHIST As String = ""
            Dim drHIST() As DataRow

            Dim dtAlerta As DataTable
            Dim drAlerta As DataRow
            Dim drCheck() As DataRow

            Dim processo As String = ""
            Dim titular As String = ""
            Dim link As String = ""

            Dim email As New Apoio.EmailAlertaDOE
            Dim emailGeral As New Apoio.EmailGeral
            Dim nomeAlerta As String = "Diário Oficial do Estado de São Paulo"
            Dim assuntoEmail As String = ""
            Dim textoEmail As String = ""

            Dim dtoProp As New DTO.tb_OPER_operador
            Dim bllProp As New BLL.tb_OPER_operador
            Dim dtProp As DataTable
            Dim filtroProp As String = ""
            Dim drProp() As DataRow
            Dim operador As String = ""

            Dim objDO As New JornaisOnline.DiarioOficialSP
            Dim douText As String = ""
            Dim processo_dou As String = ""

            dtAlerta = CriaTabelaAlertaDOE()


            bllProp.ConnectionString = connection
            bllProp.XMLPath = xmlpath
            dtProp = bllProp.PagingData(dtoProp)

            bll.ConnectionString = connection
            bll.XMLPath = xmlpath

            bllHIST.ConnectionString = connection
            bllHIST.XMLPath = xmlpath

            'pega empresas cadastradas
            dt = bll.GetData(dto)

            'pega histórico de emails enviados
            dtHIST = bllHIST.GetData(dtoHIST)

            'pega operadores
            filtroProp = "OPER_fl_alerta = 'S'"
            drProp = dtProp.Select(filtroProp)

            If drProp.Length = 0 Then
                AdicionaEntradaLog("Não há operadores ativos cadastrados", enErrorType.Info)
                Return True
            End If

            For Each douFile As String In myDOEFiles


                douText = objDO.PDFToText(douFile, 1)


                For Each dr As DataRow In dt.Rows


                    titular = dr("EMPR_ds_dou")


                    If douText.IndexOf(titular, StringComparison.OrdinalIgnoreCase) <> -1 Then
                        For Each rProp As DataRow In drProp

                            drCheck = dtAlerta.Select("Empresa = '" & titular & "' and operador = '" & rProp("OPER_ds_email") & "'")
                            If drCheck.Length = 0 Then
                                drAlerta = dtAlerta.NewRow
                                drAlerta("Empresa") = titular
                                drAlerta("operador") = rProp("OPER_ds_email")
                                drAlerta("documento") = "DOE" 'Left(douFile.Substring(douFile.LastIndexOf("\") + 1, douFile.Length - douFile.LastIndexOf("\") - 1), 3)
                                drAlerta("arquivos") = douFile
                                dtAlerta.Rows.Add(drAlerta)
                            Else
                                drAlerta = drCheck(0)
                                drAlerta.BeginEdit()
                                drAlerta("arquivos") = drAlerta("arquivos") & "|" & douFile
                                drAlerta.EndEdit()
                            End If
                        Next

                    End If

proxEmpresa:
                Next
            Next





            If dtAlerta.Rows.Count > 0 Then


                Dim emailOperador As String = ""
                Dim id_historico As Integer = 0
                Dim dtoHSAL As New DTO.tb_HSAL_historico_alerta
                Dim bllHSAL As New BLL.tb_HSAL_historico_alerta
                bllHSAL.ConnectionString = connection
                bllHSAL.XMLPath = xmlpath



                For Each dr As DataRow In dtAlerta.Rows

                    emailOperador = dr("operador")
                    titular = dr("Empresa").ToString.Trim

                    'verifica se para o processo/operador/tipo alerta
                    'já foi enviado email no dia atual
                    'se sim, não manda denovo
                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                    dtoHSAL.ALER_nm_alerta = nomeAlerta

                    If titular.Length > 50 Then
                        dtoHSAL.PROC_cd_processo = titular.Substring(0, 50)
                    Else
                        dtoHSAL.PROC_cd_processo = titular
                    End If

                    dtoHSAL.HSAL_ds_email = dr("operador")

                    'dtoHSAL.HSAL_fl_status = "S"


                    Dim dtHistCheck As DataTable = _
                    bllHSAL.PagingData(dtoHSAL)

                    If dtHistCheck.Rows.Count > 0 Then
                        If IsDate(dtHistCheck.Rows(0)("HSAL_dt_envio")) Then
                            If Format(CDate(dtHistCheck.Rows(0)("HSAL_dt_envio")), "dd-MM-yyyy") = Format(Now, "dd-MM-yyyy") Then
                                AdicionaEntradaLog("Alerta DOE já enviado hoje para Empresa " & titular & " - Email: " & emailOperador, enErrorType.Info)
                                GoTo proxAlerta
                            End If
                        End If
                    End If

                    numAlertas += 1

                    assuntoEmail = email.MontaAssuntoEmail(nomeAlerta, titular)


                    textoEmail = email.MontaTextoEmail(ColToRow(dr).Rows, titular, dr("documento"))

                    'inclui HSAL
                    AdicionaEntradaLog("Gravando histórico de alertas DOE para Empresa " & titular & " - Email: " & emailOperador, enErrorType.Info)

                    'grava email na tabela de historico de alertas
                    'caso este fique pendente de envio
                    'essa tabela historica será lida numa proxima execucao
                    'e o(s) email(s) pendente(s) serão enviados
                    dtoHSAL = New DTO.tb_HSAL_historico_alerta

                    Try
                        AdicionaEntradaLog("Buscando próximo ID de histórico", enErrorType.Info)
                        id_historico = pega_id_historico()
                        AdicionaEntradaLog("Próximo ID de histórico selecionado com sucesso [" & CStr(id_historico) & "]", enErrorType.Info)
                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar buscar próximo ID de histórico: " & ex.Message, enErrorType._Error)
                    End Try


                    dtoHSAL.AUDT_dt_inclusao = Now
                    dtoHSAL.AUDT_nm_usuario_inclusao = default_user
                    dtoHSAL.ALER_nm_alerta = nomeAlerta
                    dtoHSAL.HSAL_ds_assunto_email = assuntoEmail
                    dtoHSAL.HSAL_ds_email = emailOperador
                    dtoHSAL.HSAL_ds_mensagem = ""
                    dtoHSAL.HSAL_ds_texto_email = textoEmail
                    dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                    dtoHSAL.HSAL_fl_status = "N"

                    If titular.Length > 50 Then
                        dtoHSAL.PROC_cd_processo = titular.Substring(0, 50)
                    Else
                        dtoHSAL.PROC_cd_processo = titular
                    End If

                    dtoHSAL.HSAL_id_historico = id_historico


                    bllHSAL.ConnectionString = connection
                    bllHSAL.XMLPath = xmlpath

                    If bllHSAL.InsertData(dtoHSAL) Then
                        AdicionaEntradaLog("Histórico de alertas gravado com sucesso para Empresa " & titular & " - Email: " & emailOperador, enErrorType.Info)
                    Else
                        AdicionaEntradaLog("Não foi possível gravar o histórico de alerta para Empresa " & titular & " - Email: " & emailOperador, enErrorType._Error)
                    End If

                    Try

                        Dim attaches() As String = Split(dr("arquivos"), "|")

                        emailGeral.EnviaEmail(default_smtp, default_porta, default_email, emailOperador, default_usuario, default_senha, assuntoEmail, textoEmail, attaches, True, Nothing)

                        numEmailsOk += 1

                        'atualiza HSAL - nao pendente
                        AdicionaEntradaLog("Atualizando histórico de alerta para não pendente - Empresa " & titular & " - Email: " & emailOperador, enErrorType.Info)

                        dtoHSAL = New DTO.tb_HSAL_historico_alerta
                        dtoHSAL.HSAL_ds_mensagem = ""
                        dtoHSAL.HSAL_dt_envio = Now
                        dtoHSAL.HSAL_fl_status = "S"
                        dtoHSAL.HSAL_id_historico = id_historico

                        If bllHSAL.UpdateData(dtoHSAL) Then
                            AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para não pendente para Empresa " & titular & " - Email: " & emailOperador, enErrorType.Info)
                        Else
                            AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para não pendente para Empresa " & titular & " - Email: " & emailOperador, enErrorType._Error)
                        End If


                    Catch ex As Exception

                        numEmailsPendentes += 1

                        'atualiza HSAL - pendente
                        AdicionaEntradaLog("Atualizando histórico de alerta para pendente no Empresa " & titular & " - Email: " & emailOperador, enErrorType.Info)

                        dtoHSAL = New DTO.tb_HSAL_historico_alerta
                        dtoHSAL.HSAL_ds_mensagem = ex.Message
                        dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                        dtoHSAL.HSAL_fl_status = "N"
                        dtoHSAL.HSAL_id_historico = id_historico

                        If bllHSAL.UpdateData(dtoHSAL) Then
                            AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente no Empresa " & titular & " - Email: " & emailOperador, enErrorType.Info)
                        Else
                            AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente no Empresa " & titular & " - Email: " & emailOperador, enErrorType._Error)
                        End If


                    End Try



proxAlerta:
                Next


            Else
                AdicionaEntradaLog("Não há alertas DOE", enErrorType.Info)
            End If




            Return True

        Catch ex As Exception
            AdicionaEntradaLog("Erro na rotina AlertasDOE: " & ex.Message, enErrorType._Error)
            Return False
        End Try
    End Function
    Public Function AlertasVencimento() As Boolean


        Try


            Dim dt As DataTable
            Dim bll As New tb_PROC_processo
            Dim dto As New DTO.tb_PROC_processo

            Dim dtAlerta As DataTable

            Dim bllHIST As New BLL.tb_AVEN_alerta_vencimento
            Dim dtoHIST As New DTO.tb_AVEN_alerta_vencimento
            Dim dtHIST As DataTable
            Dim filtroHIST As String = ""
            Dim drHIST() As DataRow

            Dim processo As String = ""
            Dim titular As String = ""
            Dim link As String = ""
            Dim orgao As String = ""
            Dim tipo_documento As String = ""
            Dim id_documento As String = ""
            Dim data_ultimo_alerta As String = ""
            Dim flag_conta_alerta As Integer = -1
            Dim dias_para_vencer As Integer = 0
            Dim tipo_envio As String = ""
            Dim dt_vencimento As Date
            Dim dt_publicacao As String = ""
            Dim flag_ultimo_envio As String = "N"

            Dim email As New Apoio.EmailAlertaVencimento
            Dim emailGeral As New Apoio.EmailGeral
            Dim nomeAlerta As String = "Vencimento de Documento"
            Dim assuntoEmail As String = ""
            Dim textoEmail As String = ""

            Dim dtoProp As New DTO.tb_PROP_processo_operador
            Dim bllProp As New BLL.tb_PROP_processo_operador
            Dim dtProp As DataTable
            Dim filtroProp As String = ""
            Dim drProp() As DataRow
            Dim operador As String = ""
            bllProp.ConnectionString = connection
            bllProp.XMLPath = xmlpath
            dtProp = bllProp.PagingData(dtoProp)


            bll.ConnectionString = connection
            bll.XMLPath = xmlpath

            bllHIST.ConnectionString = connection
            bllHIST.XMLPath = xmlpath

            dtHIST = bllHIST.GetData(dtoHIST)

            dt = bll.getExpirateDocuments(dto)

            dtAlerta = CriaTabelaAlertaVencimento()
            Dim drAlerta As DataRow

            Dim dtoNewHist As DTO.tb_AVEN_alerta_vencimento
            Dim bllNewHist As New BLL.tb_AVEN_alerta_vencimento
            Dim retNewHist As Boolean = False
            bllNewHist.ConnectionString = connection
            bllNewHist.XMLPath = xmlpath

            Dim inicio As Integer = 0
            Dim intervalo As Integer = 0

            For Each dr As DataRow In dt.Rows

                processo = dr("PROC_cd_processo")
                titular = dr("PROC_ds_titular")
                link = dr("PROC_ds_link")


                filtroProp = "PROC_cd_processo = '{0}' and OPER_fl_alerta = 'S'"
                filtroProp = String.Format(filtroProp, processo)
                drProp = dtProp.Select(filtroProp)

                'se nao tem nenhum operador relacionado ao processo
                'não tem pra quem mandar email, então segue para proximo processo
                If drProp.Length = 0 Then GoTo proxProcesso



                orgao = dr("ORGA_nm_orgao")
                tipo_documento = dr("PROC_nm_tipo_documento")
                id_documento = dr("PROC_id_documento")
                dt_vencimento = dr("PROC_dt_vencimento")
                dt_publicacao = base.AjustaNulo(dr("PROC_dt_publicacao"))
                inicio = base.NuloParaZero(dr("PROC_qt_inicio"))
                intervalo = base.NuloParaZero(dr("PROC_qt_intervalo"))


                filtroHIST = "PROC_cd_processo = '{0}' and ORGA_nm_orgao = '{1}' and AVEN_nm_tipo_documento = '{2}' and AVEN_id_documento = '{3}'"
                filtroHIST = String.Format(filtroHIST, processo, orgao, tipo_documento, id_documento)
                drHIST = dtHIST.Select(filtroHIST)

                If drHIST.Length > 0 Then

                    data_ultimo_alerta = drHIST(0)("AVEN_dt_ultimo_alerta")
                    flag_conta_alerta = drHIST(0)("AVEN_fl_conta_alerta")
                    flag_ultimo_envio = drHIST(0)("AVEN_fl_ultimo_envio")

                    ' se existe historico, verifica valor do flag de envio
                    If flag_conta_alerta = 0 Then
                        'se flag = 0, verifica se é o momento de enviar a primeira vez
                        If DateDiff(DateInterval.Day, Now.Date, dt_vencimento) <= inicio And inicio > 0 Then


                            For Each rProp As DataRow In drProp
                                drAlerta = dtAlerta.NewRow
                                operador = rProp("OPER_ds_email")
                                drAlerta("operador") = operador
                                drAlerta("processo") = processo
                                drAlerta("titular") = titular
                                drAlerta("link") = link
                                drAlerta("orgao") = converteOrgao(orgao)
                                drAlerta("tipo_documento") = tipo_documento
                                drAlerta("id_documento") = id_documento
                                drAlerta("data_vencimento") = Format(dt_vencimento, "dd/MM/yyyy")

                                If IsDate(dt_publicacao) Then
                                    drAlerta("data_publicacao") = Format(CDate(dt_publicacao), "dd/MM/yyyy")
                                Else
                                    drAlerta("data_publicacao") = "Não informado"
                                End If

                                dias_para_vencer = CalculaDiasVencimento(Now.Date, dt_vencimento)
                                drAlerta("dias_para_vencer") = dias_para_vencer
                                tipo_envio = DescricaoTipoEnvio(1)
                                drAlerta("tipo_envio") = tipo_envio
                                dtAlerta.Rows.Add(drAlerta)
                            Next


                            'atualiza AVEN com data do ultimo alerta e flag para 1 (enviado primeira vez)
                            dtoNewHist = New DTO.tb_AVEN_alerta_vencimento
                            dtoNewHist.PROC_cd_processo = processo
                            dtoNewHist.ORGA_nm_orgao = orgao
                            dtoNewHist.AVEN_nm_tipo_documento = tipo_documento
                            dtoNewHist.AVEN_id_documento = id_documento
                            dtoNewHist.AUDT_nm_usuario_alteracao = default_user
                            dtoNewHist.AUDT_dt_alteracao = Now
                            dtoNewHist.AVEN_fl_ultimo_envio = "N"
                            dtoNewHist.AVEN_dt_ultimo_alerta = Now.Date
                            dtoNewHist.AVEN_fl_conta_alerta = CInt(flag_conta_alerta) + 1
                            retNewHist = bllNewHist.UpdateData(dtoNewHist)

                        End If

                    Else

                        'se flag > 0 , é porque já enviou a primeira vez
                        'então, verifica se ja venceu

                        If Now.Date > CDate(dt_vencimento) Then
                            'se já venceu, verifica se já foi enviado a ultima vez
                            'se já foi, não faz nada
                            'se não foi, envia a ultima vez
                            If flag_ultimo_envio = "N" Then


                                For Each rProp As DataRow In drProp
                                    drAlerta = dtAlerta.NewRow
                                    operador = rProp("OPER_ds_email")
                                    drAlerta("operador") = operador
                                    drAlerta("processo") = processo
                                    drAlerta("titular") = titular
                                    drAlerta("link") = link
                                    drAlerta("orgao") = converteOrgao(orgao)
                                    drAlerta("tipo_documento") = tipo_documento
                                    drAlerta("id_documento") = id_documento
                                    drAlerta("data_vencimento") = Format(dt_vencimento, "dd/MM/yyyy")

                                    If IsDate(dt_publicacao) Then
                                        drAlerta("data_publicacao") = Format(CDate(dt_publicacao), "dd/MM/yyyy")
                                    Else
                                        drAlerta("data_publicacao") = "Não informado"
                                    End If

                                    dias_para_vencer = CalculaDiasVencimento(Now.Date, dt_vencimento)
                                    drAlerta("dias_para_vencer") = dias_para_vencer
                                    tipo_envio = DescricaoTipoEnvio(3)
                                    drAlerta("tipo_envio") = tipo_envio
                                    dtAlerta.Rows.Add(drAlerta)
                                Next


                                'atualiza AVEN com data do ultimo alerta,flag para VALOr_ATUAL + 1 
                                'atualiza AVEN com flag de ultimo envio para "S"
                                dtoNewHist = New DTO.tb_AVEN_alerta_vencimento
                                dtoNewHist.PROC_cd_processo = processo
                                dtoNewHist.ORGA_nm_orgao = orgao
                                dtoNewHist.AVEN_nm_tipo_documento = tipo_documento
                                dtoNewHist.AVEN_id_documento = id_documento
                                dtoNewHist.AUDT_nm_usuario_alteracao = default_user
                                dtoNewHist.AUDT_dt_alteracao = Now
                                dtoNewHist.AVEN_fl_ultimo_envio = "S"
                                dtoNewHist.AVEN_dt_ultimo_alerta = Now.Date
                                dtoNewHist.AVEN_fl_conta_alerta = CInt(flag_conta_alerta) + 1
                                retNewHist = bllNewHist.UpdateData(dtoNewHist)




                            End If

                        Else

                            'se não venceu ainda, 
                            'verifica pela data do último envio se é o momento de enviar 
                            '(envio a cada N dias)
                            If DateDiff(DateInterval.Day, CDate(data_ultimo_alerta), Now.Date) >= intervalo And intervalo > 0 Then


                                For Each rProp As DataRow In drProp
                                    drAlerta = dtAlerta.NewRow
                                    operador = rProp("OPER_ds_email")
                                    drAlerta("operador") = operador
                                    drAlerta("processo") = processo
                                    drAlerta("titular") = titular
                                    drAlerta("link") = link
                                    drAlerta("orgao") = converteOrgao(orgao)
                                    drAlerta("tipo_documento") = tipo_documento
                                    drAlerta("id_documento") = id_documento
                                    drAlerta("data_vencimento") = Format(dt_vencimento, "dd/MM/yyyy")

                                    If IsDate(dt_publicacao) Then
                                        drAlerta("data_publicacao") = Format(CDate(dt_publicacao), "dd/MM/yyyy")
                                    Else
                                        drAlerta("data_publicacao") = "Não informado"
                                    End If

                                    dias_para_vencer = CalculaDiasVencimento(Now.Date, dt_vencimento)
                                    drAlerta("dias_para_vencer") = dias_para_vencer
                                    tipo_envio = DescricaoTipoEnvio(2)
                                    drAlerta("tipo_envio") = tipo_envio
                                    dtAlerta.Rows.Add(drAlerta)
                                Next

                                'atualiza AVEN com data do ultimo alerta e flag para VALOR_ATUAL + 1 
                                dtoNewHist = New DTO.tb_AVEN_alerta_vencimento
                                dtoNewHist.PROC_cd_processo = processo
                                dtoNewHist.ORGA_nm_orgao = orgao
                                dtoNewHist.AVEN_nm_tipo_documento = tipo_documento
                                dtoNewHist.AVEN_id_documento = id_documento
                                dtoNewHist.AUDT_nm_usuario_alteracao = default_user
                                dtoNewHist.AUDT_dt_alteracao = Now
                                dtoNewHist.AVEN_fl_ultimo_envio = "N"
                                dtoNewHist.AVEN_dt_ultimo_alerta = Now.Date
                                dtoNewHist.AVEN_fl_conta_alerta = CInt(flag_conta_alerta) + 1
                                retNewHist = bllNewHist.UpdateData(dtoNewHist)


                            End If

                        End If

                    End If


                Else

                    'se não tem histórico, é porque nunca enviou
                    'então, verifica se é o momento de enviar a primeira vez
                    If DateDiff(DateInterval.Day, Now.Date, dt_vencimento) <= inicio And inicio > 0 Then

                        Dim ultimo_envio As String = "N"
                        Dim desTipoEnvio As Integer = 1

                        If DateDiff(DateInterval.Day, Now.Date, dt_vencimento) < 0 Then
                            'ja venceu
                            ultimo_envio = "S"
                            desTipoEnvio = 3
                        Else
                            ultimo_envio = "N"
                            desTipoEnvio = 1
                        End If


                        For Each rProp As DataRow In drProp
                            drAlerta = dtAlerta.NewRow
                            operador = rProp("OPER_ds_email")
                            drAlerta("operador") = operador
                            drAlerta("processo") = processo
                            drAlerta("titular") = titular
                            drAlerta("link") = link
                            drAlerta("orgao") = converteOrgao(orgao)
                            drAlerta("tipo_documento") = tipo_documento
                            drAlerta("id_documento") = id_documento
                            drAlerta("data_vencimento") = Format(dt_vencimento, "dd/MM/yyyy")

                            If IsDate(dt_publicacao) Then
                                drAlerta("data_publicacao") = Format(CDate(dt_publicacao), "dd/MM/yyyy")
                            Else
                                drAlerta("data_publicacao") = "Não informado"
                            End If

                            dias_para_vencer = CalculaDiasVencimento(Now.Date, dt_vencimento)
                            drAlerta("dias_para_vencer") = dias_para_vencer
                            tipo_envio = DescricaoTipoEnvio(desTipoEnvio)
                            drAlerta("tipo_envio") = tipo_envio
                            dtAlerta.Rows.Add(drAlerta)
                        Next

                        'grava dados na tabela AVEN                
                        dtoNewHist = New DTO.tb_AVEN_alerta_vencimento
                        dtoNewHist.PROC_cd_processo = processo
                        dtoNewHist.ORGA_nm_orgao = orgao
                        dtoNewHist.AVEN_nm_tipo_documento = tipo_documento
                        dtoNewHist.AVEN_id_documento = id_documento
                        dtoNewHist.AUDT_nm_usuario_inclusao = default_user
                        dtoNewHist.AUDT_nm_usuario_alteracao = default_user
                        dtoNewHist.AUDT_dt_alteracao = Now
                        dtoNewHist.AUDT_dt_inclusao = Now
                        'atualiza AVEN com data do ultimo alerta e flag para 1 (enviado primeira vez)
                        dtoNewHist.AVEN_fl_ultimo_envio = ultimo_envio
                        dtoNewHist.AVEN_dt_ultimo_alerta = Now.Date
                        dtoNewHist.AVEN_fl_conta_alerta = 1
                        retNewHist = bllNewHist.InsertData(dtoNewHist)









                    End If

                End If


proxProcesso:
            Next

            If dtAlerta.Rows.Count > 0 Then numAlertas += 1


            Dim dtDistinctOper As DataTable = base.SelectDistinct(dtAlerta.TableName, dtAlerta, "operador")
            Dim emailOperador As String = ""
            Dim id_historico As Integer = 0
            Dim dtoHSAL As New DTO.tb_HSAL_historico_alerta
            Dim bllHSAL As New BLL.tb_HSAL_historico_alerta
            bllHSAL.ConnectionString = connection
            bllHSAL.XMLPath = xmlpath

            assuntoEmail = email.MontaAssuntoEmail(nomeAlerta)

            For Each drDis As DataRow In dtDistinctOper.Rows

                emailOperador = drDis("operador")
                textoEmail = email.MontaTextoEmail(dtAlerta.Select("operador = '" & emailOperador & "'").CopyToDataTable.Rows)

                'inclui HSAL
                AdicionaEntradaLog("Gravando histórico de alertas de vencimento para " & emailOperador, enErrorType.Info)

                'grava email na tabela de historico de alertas
                'caso este fique pendente de envio
                'essa tabela historica será lida numa proxima execucao
                'e o(s) email(s) pendente(s) serão enviados
                dtoHSAL = New DTO.tb_HSAL_historico_alerta

                Try
                    AdicionaEntradaLog("Buscando próximo ID de histórico", enErrorType.Info)
                    id_historico = pega_id_historico()
                    AdicionaEntradaLog("Próximo ID de histórico selecionado com sucesso [" & CStr(id_historico) & "]", enErrorType.Info)
                Catch ex As Exception
                    AdicionaEntradaLog("Erro ao tentar buscar próximo ID de histórico: " & ex.Message, enErrorType._Error)
                End Try


                dtoHSAL.AUDT_dt_inclusao = Now
                dtoHSAL.AUDT_nm_usuario_inclusao = default_user
                dtoHSAL.ALER_nm_alerta = nomeAlerta
                dtoHSAL.HSAL_ds_assunto_email = assuntoEmail
                dtoHSAL.HSAL_ds_email = emailOperador
                dtoHSAL.HSAL_ds_mensagem = ""
                dtoHSAL.HSAL_ds_texto_email = textoEmail
                dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                dtoHSAL.HSAL_fl_status = "N"
                dtoHSAL.PROC_cd_processo = "Vários"
                dtoHSAL.HSAL_id_historico = id_historico


                bllHSAL.ConnectionString = connection
                bllHSAL.XMLPath = xmlpath

                If bllHSAL.InsertData(dtoHSAL) Then
                    AdicionaEntradaLog("Histórico de alertas gravado com sucesso para " & emailOperador, enErrorType.Info)
                Else
                    AdicionaEntradaLog("Não foi possível gravar o histórico de alerta para " & emailOperador, enErrorType._Error)
                End If

                Try


                    emailGeral.EnviaEmail(default_smtp, default_porta, default_email, emailOperador, default_usuario, default_senha, assuntoEmail, textoEmail, Nothing, True, Nothing)

                    numEmailsOk += 1

                    'atualiza HSAL - nao pendente
                    AdicionaEntradaLog("Atualizando histórico de alerta para não pendente: " & emailOperador, enErrorType.Info)

                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                    dtoHSAL.HSAL_ds_mensagem = ""
                    dtoHSAL.HSAL_dt_envio = Now
                    dtoHSAL.HSAL_fl_status = "S"
                    dtoHSAL.HSAL_id_historico = id_historico

                    If bllHSAL.UpdateData(dtoHSAL) Then
                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para não pendente: " & emailOperador, enErrorType.Info)
                    Else
                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para não pendente: " & emailOperador, enErrorType._Error)
                    End If


                Catch ex As Exception

                    numEmailsPendentes += 1

                    'atualiza HSAL - pendente
                    AdicionaEntradaLog("Atualizando histórico de alerta para pendente: " & emailOperador, enErrorType.Info)

                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                    dtoHSAL.HSAL_ds_mensagem = ex.Message
                    dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                    dtoHSAL.HSAL_fl_status = "N"
                    dtoHSAL.HSAL_id_historico = id_historico

                    If bllHSAL.UpdateData(dtoHSAL) Then
                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente: " & emailOperador, enErrorType.Info)
                    Else
                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente: " & emailOperador, enErrorType._Error)
                    End If


                End Try




            Next



            Return True

        Catch ex As Exception
            AdicionaEntradaLog("Erro na rotina AlertasVencimento: " & ex.Message, enErrorType._Error)
            Return False
        End Try

    End Function

    Public Function converteHTMLParaDatarow(ByVal dtFase As DataTable, ByVal html As String) As DataRow


        Dim doc As HtmlDocument = New HtmlDocument
        doc.LoadHtml(html)

        Dim processo As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[3]/td[2]")(0).InnerText
        Dim id As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[4]/td[2]")(0).InnerText
        Dim numero As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[5]/td[2]")(0).InnerText
        Dim ano As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[6]/td[2]")(0).InnerText
        Dim area As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[7]/td[2]")(0).InnerText
        Dim fase As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[8]/td[2]")(0).InnerText
        Dim evento As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[9]/td[2]")(0).InnerText
        Dim titular As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[10]/td[2]")(0).InnerText
        Dim substancia As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[11]/td[2]")(0).InnerText
        Dim uso As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[12]/td[2]")(0).InnerText
        Dim uf As String = doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[13]/td[2]")(0).InnerText
        Dim link As String = Replace(doc.DocumentNode.SelectNodes("/html[1]/body[1]/table[1]/tr[3]/td[2]/a[1]/@href[1]")(0).Attributes(1).Value.ToString.Trim, "&#38;amp;", "&")


        Dim dt As New DataTable

        dt.Columns.Add("processo")
        dt.Columns.Add("id")
        dt.Columns.Add("numero")
        dt.Columns.Add("ano")
        dt.Columns.Add("area")
        dt.Columns.Add("fase")
        dt.Columns.Add("evento")
        dt.Columns.Add("titular")
        dt.Columns.Add("substancia")
        dt.Columns.Add("uso")
        dt.Columns.Add("uf")
        dt.Columns.Add("link")
        dt.Columns.Add("codigo_fase")

        Dim dr As DataRow = dt.NewRow

        dr("processo") = processo
        dr("id") = id
        dr("numero") = numero
        dr("ano") = ano
        dr("area") = area
        dr("fase") = fase
        dr("evento") = evento
        dr("titular") = titular
        dr("substancia") = substancia
        dr("uso") = uso
        dr("uf") = uf
        dr("link") = link
        dr("codigo_fase") = pega_codigo_fase(dtFase, fase)

        Return dr

    End Function
    Public Function SincronizaProcessos() As Boolean

        'verifica se a base local está preenchida


        Try
            Dim dtEmpr As DataTable
            Dim dtoEmpr As New DTO.tb_EMPR_empresa
            Dim bllEmpr As New BLL.tb_EMPR_empresa
            Dim dtoALER As New DTO.tb_ALER_alerta
            Dim bllALER As New BLL.tb_ALER_alerta
            Dim dtALER As DataTable
            Dim dtoOPER As New DTO.tb_OPER_operador
            Dim bllOPER As New BLL.tb_OPER_operador
            Dim dtOPER As DataTable
            Dim drProcEmpr() As DataRow
            Dim filtroProcEmpr As String = ""
            Dim dtoProc As New DTO.tb_PROC_processo
            Dim bllProc As New BLL.tb_PROC_processo
            Dim dtProc As DataTable
            Dim drDados As DataRow
            Dim dtoPRAL As New DTO.tb_PRAL_processo_alerta
            Dim bllPRAL As New BLL.tb_PRAL_processo_alerta
            Dim dtPRAL As DataTable
            Dim dtoPROP As New DTO.tb_PROP_processo_operador
            Dim bllPROP As New BLL.tb_PROP_processo_operador
            Dim dtPROP As DataTable
            Dim dtoHSAL As New DTO.tb_HSAL_historico_alerta
            Dim bllHSAL As New BLL.tb_HSAL_historico_alerta
            Dim dtProcINS As New DataTable
            Dim drProcIns As DataRow
            Dim id_historico As Integer = 0
            Dim dtFase As DataTable
            Dim dtoPREV As New DTO.tb_PREV_processo_evento
            Dim bllPREV As New BLL.tb_PREV_processo_evento
            Dim dtEmprTodas As DataTable
            Dim obj As New Apoio.Globalization
            dtFase = obj.getListData(xmlpath, "fase")

            bllPREV.ConnectionString = connection
            bllPREV.XMLPath = xmlpath

            dtProcINS.Columns.Add("processo")
            dtProcINS.Columns.Add("titular")
            dtProcINS.Columns.Add("fase")
            dtProcINS.Columns.Add("link")


            Try
                'pega cada empresa cadastrada no sistema
                AdicionaEntradaLog("Buscando empresas cadastradas", enErrorType.Info)
                bllEmpr.ConnectionString = connection
                bllEmpr.XMLPath = xmlpath
                'dtoEmpr.EMPR_fl_status = "A"
                dtEmpr = bllEmpr.GetData(dtoEmpr)
                dtEmprTodas = bllEmpr.GetData(dtoEmpr)
                dtEmpr = dtEmpr.Select("EMPR_fl_status = 'A'").CopyToDataTable
                AdicionaEntradaLog("Empresas selecionadas com sucesso", enErrorType.Info)
            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar buscar empresas cadastradas: " & ex.Message, enErrorType._Error)
                Return False
            End Try

            Try
                'pega dados de alertas nativos cadastrados no sistema
                AdicionaEntradaLog("Buscando alertas nativos do sistema", enErrorType.Info)
                bllALER.ConnectionString = connection
                bllALER.XMLPath = xmlpath
                dtoALER.ALER_fl_sistema = "S"
                dtoALER.ALER_fl_qualquer_processo = "N"
                dtALER = bllALER.PagingData(dtoALER)
                AdicionaEntradaLog("Alertas nativos selecionados com sucesso", enErrorType.Info)
            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar buscar alertas nativos: " & ex.Message, enErrorType._Error)
                Return False
            End Try


            Try
                'pega dados de operadores nativos cadastrados no sistema
                AdicionaEntradaLog("Buscando operadores", enErrorType.Info)
                bllOPER.ConnectionString = connection
                bllOPER.XMLPath = xmlpath
                dtOPER = bllOPER.GetData(dtoOPER)
                'filtra apenas operadores onde flag de alerta nativo do sistema = 'S'
                dtOPER = dtOPER.Select("OPER_fl_alerta_nativo = 'S'").CopyToDataTable
                AdicionaEntradaLog("Operadores selecionados com sucesso", enErrorType.Info)
            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar buscar operadores: " & ex.Message, enErrorType._Error)
            End Try



            'para cada empresa, busca processos da empresa na base local
            For Each drEmpr As DataRow In dtEmpr.Rows

                filtroProcEmpr = "description like '%" & drEmpr("EMPR_ds_empresa") & "%'"
                drProcEmpr = baseLocal.Select(filtroProcEmpr)

                'para cada processo, verifica se o mesmo já existe no sistema
                For Each drProc As DataRow In drProcEmpr

                    dtoProc = New DTO.tb_PROC_processo
                    bllProc.ConnectionString = connection
                    bllProc.XMLPath = xmlpath
                    dtoProc.PROC_cd_processo = drProc("name").ToString.Trim

                    Try
                        AdicionaEntradaLog("Convertendo HTML em DATAROW para o processo [" & drProc("name") & "]", enErrorType.Info)
                        drDados = converteHTMLParaDatarow(dtFase, drProc("description"))
                        AdicionaEntradaLog("Dados do processo convertidos com sucesso", enErrorType.Info)
                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar converter HTML em DATAROW para o processo [" & drProc("name") & "]: " & ex.Message, enErrorType._Error)
                        GoTo proxProcesso
                    End Try


                    'verifica apenas o campo Titular (pro caso de DADO NAO CADASTRADO)
                    If drDados("titular") <> drEmpr("EMPR_ds_empresa") Then
                        GoTo proxProcesso
                    End If



                    AdicionaEntradaLog("Verificando se processo [" & drDados("processo") & "] é novo", enErrorType.Info)

                    dtProc = bllProc.GetData(dtoProc)

                    If dtProc.Rows.Count > 0 Then
                        AdicionaEntradaLog("Processo [" & drDados("processo") & "] já existe no sistema", enErrorType.Info)
                    End If

                    'se processo já existe no sistema, nao faz nada
                    If dtProc.Rows.Count = 0 Then
                        Dim Inserido As Boolean = False

                        Try


                            AdicionaEntradaLog("Incluindo novo processo [" & drDados("processo") & "] no sistema", enErrorType.Info)

                            'se processo ainda não existe no sistema, 
                            'inclui processo, associa alerta padrão e associa operador(es) com flag de alerta nativo
                            'se incluiu, manda email de alerta (um email por processo inserido)

                            dtoProc.PROC_cd_processo = drDados("processo")
                            dtoProc.AUDT_dt_alteracao = Now
                            dtoProc.AUDT_dt_inclusao = Now
                            dtoProc.AUDT_nm_usuario_alteracao = default_user
                            dtoProc.AUDT_nm_usuario_inclusao = default_user
                            dtoProc.FASE_cd_fase = drDados("codigo_fase")
                            dtoProc.PROC_ds_area = drDados("area")
                            dtoProc.PROC_ds_link = drDados("link")
                            dtoProc.PROC_ds_substancia = drDados("substancia")
                            dtoProc.PROC_ds_titular = drDados("titular")
                            dtoProc.PROC_ds_ultimo_evento = drDados("evento")
                            dtoProc.PROC_ds_uso = drDados("uso")
                            dtoProc.PROC_fl_tipo_inclusao = "A"
                            dtoProc.PROC_id_processo = drDados("id")
                            dtoProc.PROC_nm_processo = drDados("numero")
                            dtoProc.PROC_vl_ano = drDados("ano")
                            dtoProc.UNFE_cd_unidade_federativa = drDados("uf")
                            dtoProc.PROC_cd_prioridade = 1
                            Inserido = bllProc.InsertData(dtoProc)

                            If Inserido Then
                                AdicionaEntradaLog("Novo processo [" & drDados("processo") & "] incluído com sucesso", enErrorType.Info)
                            Else
                                AdicionaEntradaLog("Não foi possível incluir novo processo [" & drDados("processo") & "] no sistema", enErrorType._Error)
                            End If

                        Catch ex As Exception
                            AdicionaEntradaLog("Erro ao tentar incluir novo processo [" & drDados("processo") & "] no sistema: " & ex.Message, enErrorType._Error)
                        End Try

                        If Inserido Then

                            Try
                                AdicionaEntradaLog("Marcando processo [" & drDados("processo") & "] como incluído", enErrorType.Info)
                                drProcIns = dtProcINS.NewRow
                                drProcIns("processo") = drDados("processo")
                                drProcIns("titular") = drDados("titular")
                                drProcIns("fase") = drDados("fase")
                                drProcIns("link") = drDados("link")
                                dtProcINS.Rows.Add(drProcIns)
                                AdicionaEntradaLog("Processo [" & drDados("processo") & "] marcado como incluído com sucesso", enErrorType.Info)
                            Catch ex As Exception
                                AdicionaEntradaLog("Erro ao tentar marcar Processo [" & drDados("processo") & "] como incluído: " & ex.Message, enErrorType._Error)
                            End Try


                            Try

                                'esse trecho insere o evento do processo na tabela processos x eventos
                                AdicionaEntradaLog("Incluindo evento no processo [" & drDados("processo") & "]", enErrorType.Info)


                                dtoPREV.AUDT_dt_alteracao = Now
                                dtoPREV.AUDT_dt_inclusao = Now
                                dtoPREV.AUDT_nm_usuario_alteracao = default_user
                                dtoPREV.AUDT_nm_usuario_inclusao = default_user
                                dtoPREV.PREV_cd_evento = pega_codigo_evento(drDados("evento"))
                                dtoPREV.PREV_dt_ocorrencia = pega_data_evento(drDados("evento"))
                                dtoPREV.PREV_ds_evento = drDados("evento")
                                dtoPREV.PROC_cd_processo = drDados("processo")

                                If bllPREV.InsertData(dtoPREV) Then
                                    AdicionaEntradaLog("Evento incluído com sucesso no processo [" & drDados("processo") & "]", enErrorType.Info)
                                Else
                                    AdicionaEntradaLog("Não foi possível incluir o evento no processo [" & drDados("processo") & "]", enErrorType._Error)
                                End If



                            Catch ex As Exception
                                AdicionaEntradaLog("Erro ao tentar incluir evento no processo [" & drDados("processo") & "]: " & ex.Message, enErrorType.Info)
                            End Try



                            Try

                                'esse trecho associa os alertas nativos do sistema 
                                'ao processo que acaba de ser inserido
                                AdicionaEntradaLog("Associando alertas nativo ao processo [" & drDados("processo") & "]", enErrorType.Info)

                                dtoPRAL = New DTO.tb_PRAL_processo_alerta
                                bllPRAL.ConnectionString = connection
                                bllPRAL.XMLPath = xmlpath


                                For Each drALER As DataRow In dtALER.Rows

                                    AdicionaEntradaLog("Associando alerta nativo [" & drALER("ALER_nm_alerta") & "]", enErrorType.Info)

                                    dtoPRAL.ALER_nm_alerta = drALER("ALER_nm_alerta")
                                    dtoPRAL.PROC_cd_processo = drDados("processo")
                                    dtoPRAL.PRAL_fl_manutencao = "S"
                                    dtoPRAL.AUDT_dt_alteracao = Now
                                    dtoPRAL.AUDT_dt_inclusao = Now
                                    dtoPRAL.AUDT_nm_usuario_alteracao = default_user
                                    dtoPRAL.AUDT_nm_usuario_inclusao = default_user
                                    dtPRAL = bllPRAL.GetData(dtoPRAL)
                                    If dtPRAL.Rows.Count = 0 Then

                                        If bllPRAL.InsertData(dtoPRAL) Then
                                            AdicionaEntradaLog("Alerta nativo [" & drALER("ALER_nm_alerta") & "] associado ao processo com sucesso", enErrorType.Info)
                                        Else
                                            AdicionaEntradaLog("Não foi possível associar o alerta nativo [" & drALER("ALER_nm_alerta") & "]", enErrorType.Info)
                                        End If
                                    End If

                                Next


                                AdicionaEntradaLog("Todos os alertas nativos foram associados ao processo [" & drDados("processo") & "]", enErrorType.Info)

                            Catch ex As Exception
                                AdicionaEntradaLog("Ocorreu um erro ao tentar associar alertas nativos ao processo [" & drDados("processo") & "]: " & ex.Message, enErrorType._Error)
                            End Try







                            Try

                                'esse trecho associa os operadores  
                                'ao processo que acaba de ser inserido
                                AdicionaEntradaLog("Associando operadores ao processo [" & drDados("processo") & "]", enErrorType.Info)

                                dtoPROP = New DTO.tb_PROP_processo_operador
                                bllPROP.ConnectionString = connection
                                bllPROP.XMLPath = xmlpath


                                For Each drOPER As DataRow In dtOPER.Rows

                                    AdicionaEntradaLog("Associando operador [" & drOPER("OPER_nm_operador") & "]", enErrorType.Info)

                                    dtoPROP.OPER_cd_operador = drOPER("OPER_cd_operador")
                                    dtoPROP.PROC_cd_processo = drDados("processo")
                                    dtoPROP.AUDT_dt_alteracao = Now
                                    dtoPROP.AUDT_dt_inclusao = Now
                                    dtoPROP.AUDT_nm_usuario_alteracao = default_user
                                    dtoPROP.AUDT_nm_usuario_inclusao = default_user
                                    dtPROP = bllPROP.GetData(dtoPROP)

                                    If dtPROP.Rows.Count = 0 Then

                                        If bllPROP.InsertData(dtoPROP) Then
                                            AdicionaEntradaLog("Operador [" & drOPER("OPER_nm_operador") & "] associado ao processo com sucesso", enErrorType.Info)
                                        Else
                                            AdicionaEntradaLog("Não foi possível associar o operador [" & drOPER("OPER_nm_operador") & "]", enErrorType.Info)
                                        End If
                                    End If

                                Next


                                AdicionaEntradaLog("Todos os operadores foram associados ao processo [" & drDados("processo") & "]", enErrorType.Info)

                            Catch ex As Exception
                                AdicionaEntradaLog("Ocorreu um erro ao tentar associar operadores ao processo [" & drDados("processo") & "]: " & ex.Message, enErrorType._Error)
                            End Try





                        End If

                    End If


proxProcesso:
                Next


proxEmpresa:
            Next

            numIncluidos = dtProcINS.Rows.Count
            If numIncluidos > 0 Then numAlertas = 1

            If dtProcINS.Rows.Count > 0 Then
                Try

                    AdicionaEntradaLog("Iniciando envio de alertas de Inclusão de Novos Processos", enErrorType.Info)

                    'envia um email de alerta para os operadores 
                    'onde o flag de alertas nativos = 'S'
                    'esse email vai ter uma tabela em html
                    'com todos os novos processos inseridos no sistema
                    'durante o processamento corrente
                    Dim mailNew As New Apoio.EmailNovoProcesso
                    Dim mail As New Apoio.EmailGeral

                    Dim dtoOPER1 As New DTO.tb_OPER_operador
                    Dim dtOper1 As DataTable
                    Dim val As New Apoio.Validation
                    Dim Assunto As String = ""
                    Dim Texto As String = ""

                    Try
                        AdicionaEntradaLog("Montando assunto e texto do email", enErrorType.Info)
                        Assunto = mailNew.MontaAssuntoEmail()
                        Texto = mailNew.MontaTextoEmail(dtProcINS.Rows)
                        AdicionaEntradaLog("Assunto e texto do email montados som sucesso", enErrorType.Info)
                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar montar assunto e texto do email: " & ex.Message, enErrorType._Error)
                        GoTo fim
                    End Try



                    Try
                        AdicionaEntradaLog("Selecionando operadores para envio de emails", enErrorType.Info)
                        dtoOPER1.OPER_fl_alerta_nativo = "S"
                        dtoOPER1.OPER_fl_alerta = "S"
                        dtOper1 = bllOPER.GetData(dtoOPER1)
                        AdicionaEntradaLog("Operadores selecionados com sucesso", enErrorType.Info)
                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar selecionar operadores: " & ex.Message, enErrorType._Error)
                        GoTo fim
                    End Try



                    For Each drOper1 As DataRow In dtOper1.Rows

                        If val.is_valid_email(drOper1("OPER_ds_email")) Then

                            Try

                                AdicionaEntradaLog("Gravando histórico de alertas para " & drOper1("OPER_ds_email"), enErrorType.Info)

                                'grava email na tabela de historico de alertas
                                'caso este fique pendente de envio
                                'essa tabela historica será lida numa proxima execucao
                                'e o(s) email(s) pendente(s) serão enviados
                                dtoHSAL = New DTO.tb_HSAL_historico_alerta

                                Try
                                    AdicionaEntradaLog("Buscando próximo ID de histórico", enErrorType.Info)
                                    id_historico = pega_id_historico()
                                    AdicionaEntradaLog("Próximo ID de histórico selecionado com sucesso [" & CStr(id_historico) & "]", enErrorType.Info)
                                Catch ex As Exception
                                    AdicionaEntradaLog("Erro ao tentar buscar próximo ID de histórico: " & ex.Message, enErrorType._Error)
                                End Try


                                dtoHSAL.AUDT_dt_inclusao = Now
                                dtoHSAL.AUDT_nm_usuario_inclusao = default_user
                                dtoHSAL.ALER_nm_alerta = "Novo Processo"
                                dtoHSAL.HSAL_ds_assunto_email = Assunto
                                dtoHSAL.HSAL_ds_email = drOper1("OPER_ds_email")
                                dtoHSAL.HSAL_ds_mensagem = ""
                                dtoHSAL.HSAL_ds_texto_email = Texto
                                dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                                dtoHSAL.HSAL_fl_status = "N"
                                dtoHSAL.PROC_cd_processo = "Vários"
                                dtoHSAL.HSAL_id_historico = id_historico


                                bllHSAL.ConnectionString = connection
                                bllHSAL.XMLPath = xmlpath

                                If bllHSAL.InsertData(dtoHSAL) Then
                                    AdicionaEntradaLog("Histórico de alertas gravado com sucesso para " & drOper1("OPER_ds_email"), enErrorType.Info)
                                Else
                                    AdicionaEntradaLog("Não foi possível gravar o histórico de alerta para " & drOper1("OPER_ds_email"), enErrorType._Error)
                                End If


                            Catch ex As Exception
                                AdicionaEntradaLog("Erro ao tentar gravar histórico de alerta para " & drOper1("OPER_ds_email") & ": " & ex.Message, enErrorType._Error)
                            End Try


                            Try



                                AdicionaEntradaLog("Enviando email para " & drOper1("OPER_ds_email"), enErrorType.Info)

                                mail.EnviaEmail(default_smtp, _
                                                default_porta, _
                                                default_email, _
                                                drOper1("OPER_ds_email"), _
                                                default_usuario, _
                                                default_senha, _
                                                Assunto, Texto, _
                                                Nothing, True, Nothing)

                                AdicionaEntradaLog("Email enviado com sucesso para " & drOper1("OPER_ds_email"), enErrorType.Info)
                                numEmailsOk += 1

                                Try
                                    'se enviou email, grava histórico do alerta 
                                    'como nao mais pendente

                                    AdicionaEntradaLog("Atualizando histórico de alerta para não pendente: " & drOper1("OPER_ds_email"), enErrorType.Info)

                                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                                    dtoHSAL.HSAL_ds_mensagem = ""
                                    dtoHSAL.HSAL_dt_envio = Now
                                    dtoHSAL.HSAL_fl_status = "S"
                                    dtoHSAL.HSAL_id_historico = id_historico

                                    If bllHSAL.UpdateData(dtoHSAL) Then
                                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para não pendente: " & drOper1("OPER_ds_email"), enErrorType.Info)
                                    Else
                                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para não pendente: " & drOper1("OPER_ds_email"), enErrorType._Error)
                                    End If

                                Catch ex As Exception
                                    AdicionaEntradaLog("Erro ao tentar atualizar histórico de alerta para não pendente para " & drOper1("OPER_ds_email") & ": " & ex.Message, enErrorType._Error)
                                End Try


                            Catch ex As Exception

                                Try
                                    'se enviou email, grava histórico do alerta 
                                    'como nao mais pendente

                                    AdicionaEntradaLog("Atualizando histórico de alerta para pendente: " & drOper1("OPER_ds_email"), enErrorType.Info)

                                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                                    dtoHSAL.HSAL_ds_mensagem = ex.Message
                                    dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                                    dtoHSAL.HSAL_fl_status = "N"
                                    dtoHSAL.HSAL_id_historico = id_historico

                                    If bllHSAL.UpdateData(dtoHSAL) Then
                                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente: " & drOper1("OPER_ds_email"), enErrorType.Info)
                                    Else
                                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente: " & drOper1("OPER_ds_email"), enErrorType._Error)
                                    End If

                                Catch ex2 As Exception
                                    AdicionaEntradaLog("Erro ao tentar atualizar histórico de alerta para pendente para " & drOper1("OPER_ds_email") & ": " & ex2.Message, enErrorType._Error)
                                End Try

                                numEmailsPendentes += 1
                                AdicionaEntradaLog("Erro ao tentar enviar email para " & drOper1("OPER_ds_email") & ": " & ex.Message, enErrorType._Error)
                            End Try

                        Else
                            'endereco de email invalido
                            AdicionaEntradaLog("Endereço de email cadastrado não é válido: " & drOper1("OPER_ds_email"), enErrorType._Error)
                        End If

                    Next


                    AdicionaEntradaLog("Envio de Alertas realizado com sucesso", enErrorType.Info)


                Catch ex As Exception
                    AdicionaEntradaLog("Erro ao tentar realizar envio de alertas: " & ex.Message, enErrorType._Error)
                End Try
            Else
                AdicionaEntradaLog("Nenhum novo processo foi incluído no sistema", enErrorType.Info)
            End If
fim:











            'SEGUNDA PARTE - atualiza dados e prepara base para envio de alertas

            baseAlerta = Nothing
            baseAlerta = New DataTable
            baseAlerta.Columns.Add("empresa")
            baseAlerta.Columns.Add("empresa_cadastrada")
            baseAlerta.Columns.Add("fase_anterior")
            baseAlerta.Columns.Add("fase_nova")
            baseAlerta.Columns.Add("codigo_fase_anterior")
            baseAlerta.Columns.Add("codigo_fase_nova")
            baseAlerta.Columns.Add("evento_anterior")
            baseAlerta.Columns.Add("evento_novo")
            baseAlerta.Columns.Add("mudou_fase")
            baseAlerta.Columns.Add("mudou_evento")
            baseAlerta.Columns.Add("processo")
            baseAlerta.Columns.Add("link")
            baseAlerta.Columns.Add("alertas")
            baseAlerta.Columns.Add("operadores")

            Dim linhaAlerta As DataRow
            Dim drDNPM As DataRow

            'busca todos os processos existentes no sistema (empresas cadastradas ou nao)
            Try
                dtoProc = New DTO.tb_PROC_processo
                dtProc = bllProc.GetData(dtoProc)
            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar buscas processos existentes no sistema: " & ex.Message, enErrorType._Error)
                Return False
            End Try

            'busca todos os operadores do sistema (pra poupar conexao no looping)
            Try
                dtoOPER = New DTO.tb_OPER_operador
                dtOPER = bllOPER.GetData(dtoOPER)
            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar buscas operadores existentes no sistema: " & ex.Message, enErrorType._Error)
                Return False
            End Try

            'busca todos os alertas do sistema (pra poupar conexao no looping)
            Try
                dtoALER = New DTO.tb_ALER_alerta
                dtALER = bllALER.GetData(dtoALER)
            Catch ex As Exception
                AdicionaEntradaLog("", enErrorType._Error)
                Return False
            End Try

            'busca todos os alertas x processos do sistema (pra poupar conexao no looping)
            Try
                dtoPRAL = New DTO.tb_PRAL_processo_alerta
                bllPRAL.ConnectionString = connection
                bllPRAL.XMLPath = xmlpath
                dtPRAL = bllPRAL.GetData(dtoPRAL)
            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar buscas alertas x processos existentes no sistema: " & ex.Message, enErrorType._Error)
                Return False
            End Try


            'busca todos os operadores x processos do sistema (pra poupar conexao no looping)
            Try
                dtoPROP = New DTO.tb_PROP_processo_operador
                bllPROP.ConnectionString = connection
                bllPROP.XMLPath = xmlpath
                dtPROP = bllPROP.GetData(dtoPROP)
            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar buscas operadores x processos existentes no sistema: " & ex.Message, enErrorType._Error)
                Return False
            End Try


            'PATCH_16082012 - Geração de Alerta Geral

            'filtra alertas gerais (alertas para todos os processos do kml)
            Dim dtAlerGeral As DataTable = dtALER.Select("ALER_fl_geral = 'S'").CopyToDataTable
            If dtAlerGeral.Rows.Count = 0 Then GoTo proxEtapa

            AdicionaEntradaLog("Iniciando tratamento de alertas gerais", enErrorType.Info)

            AdicionaEntradaLog("Foram encontrados " & baseLocal.Rows.Count - 1 & " processos minerários no arquivo kml", enErrorType.Info)
            AdicionaEntradaLog("Aguarde, pois esse processamento pode levar alguns minutos", enErrorType.Info)


            Dim dtoAux As DTO.tb_PAUX_processo_auxiliar
            Dim dtAux As DataTable
            Dim bllAux As New BLL.tb_PAUX_processo_auxiliar
            bllAux.ConnectionString = connection
            bllAux.XMLPath = xmlpath
            Dim linhaAlertaGeral As DataRow


            baseAlertaGeral = Nothing
            baseAlertaGeral = New DataTable
            baseAlertaGeral.Columns.Add("empresa")
            baseAlertaGeral.Columns.Add("fase_anterior")
            baseAlertaGeral.Columns.Add("fase_nova")
            baseAlertaGeral.Columns.Add("codigo_fase_anterior")
            baseAlertaGeral.Columns.Add("codigo_fase_nova")
            baseAlertaGeral.Columns.Add("evento_anterior")
            baseAlertaGeral.Columns.Add("evento_novo")
            baseAlertaGeral.Columns.Add("mudou_fase")
            baseAlertaGeral.Columns.Add("mudou_evento")
            baseAlertaGeral.Columns.Add("processo")
            baseAlertaGeral.Columns.Add("link")
            baseAlertaGeral.Columns.Add("novo")
            baseAlertaGeral.Columns.Add("enviar")
            baseAlertaGeral.Columns.Add("uf")



            'busca todos os processos na tabela de processos auxiliar
            Try
                dtoAux = New DTO.tb_PAUX_processo_auxiliar
                dtAux = bllAux.GetData(dtoAux)
            Catch ex As Exception
                AdicionaEntradaLog("Erro ao tentar buscas processos existentes na base auxiliar do sistema: " & ex.Message, enErrorType._Error)
                Return False
            End Try




            Dim contProc As Integer = 0
            AdicionaEntradaLog(contProc & " Processos verificados", enErrorType.Info)

            'para cada processos da base local (todos os processos do arquivo kml)
            For Each drProcKml As DataRow In baseLocal.Rows



                Dim drProcKML1 As DataRow

                If drProcKml("description") Is DBNull.Value Or drProcKml("name") = "None" Then GoTo proxProcesso3

                drProcKML1 = converteHTMLParaDatarow(dtFase, drProcKml("description"))

                If contProc Mod 100 = 0 Then
                    AtualizaEntradaLog(contProc & " de " & baseLocal.Rows.Count - 1 & "  Processos verificados")
                End If


                'verifica se o mesmo existe no sistema, na base auxiliar
                If dtAux.Select("PAUX_cd_processo = '" & drProcKml("name") & "'").Length > 0 Then

                    Dim drAux As DataRow = dtAux.Select("PAUX_cd_processo = '" & drProcKml("name") & "'")(0)

                    'se mudou de fase ou de evento, insere na tabela de alertas geral
                    If base.NuloParaZero(drAux("FASE_cd_fase")) <> drProcKML1("codigo_fase") Or _
                    base.AjustaNulo(drAux("PAUX_ds_ultimo_evento")) <> drProcKML1("evento") Then

                        linhaAlertaGeral = baseAlertaGeral.NewRow
                        linhaAlertaGeral("processo") = drProcKML1("processo")
                        linhaAlertaGeral("link") = drProcKML1("link")
                        linhaAlertaGeral("empresa") = drProcKML1("titular")
                        linhaAlertaGeral("mudou_evento") = IIf(base.AjustaNulo(drAux("PAUX_ds_ultimo_evento")) <> drProcKML1("evento"), "S", "N")
                        linhaAlertaGeral("mudou_fase") = IIf(base.NuloParaZero(drAux("FASE_cd_fase")) <> drProcKML1("codigo_fase"), "S", "N")
                        linhaAlertaGeral("codigo_fase_anterior") = base.NuloParaZero(drAux("FASE_cd_fase"))
                        linhaAlertaGeral("codigo_fase_nova") = drProcKML1("codigo_fase")
                        linhaAlertaGeral("fase_anterior") = obj.getValue(dtFase, base.NuloParaZero(drAux("FASE_cd_fase")))
                        linhaAlertaGeral("fase_nova") = drProcKML1("fase")
                        linhaAlertaGeral("evento_anterior") = base.AjustaNulo(drAux("PAUX_ds_ultimo_evento"))
                        linhaAlertaGeral("evento_novo") = drProcKML1("evento")
                        linhaAlertaGeral("novo") = "N"
                        linhaAlertaGeral("enviar") = "N"
                        linhaAlertaGeral("uf") = drProcKML1("uf")
                        baseAlertaGeral.Rows.Add(linhaAlertaGeral)
                    End If

                Else


                    'se processo não existe na base auxiliar, vai gerar alerta
                    'pois o sistema não terá referencia da situação anterior
                    linhaAlertaGeral = baseAlertaGeral.NewRow
                    linhaAlertaGeral("processo") = drProcKML1("processo")
                    linhaAlertaGeral("link") = drProcKML1("link")
                    linhaAlertaGeral("empresa") = drProcKML1("titular")
                    linhaAlertaGeral("mudou_evento") = "S"
                    linhaAlertaGeral("mudou_fase") = "S"
                    linhaAlertaGeral("codigo_fase_anterior") = ""
                    linhaAlertaGeral("codigo_fase_nova") = drProcKML1("codigo_fase")
                    linhaAlertaGeral("fase_anterior") = ""
                    linhaAlertaGeral("fase_nova") = drProcKML1("fase")
                    linhaAlertaGeral("evento_anterior") = ""
                    linhaAlertaGeral("evento_novo") = drProcKML1("evento")
                    linhaAlertaGeral("novo") = "S"
                    linhaAlertaGeral("enviar") = "N"
                    linhaAlertaGeral("uf") = drProcKML1("uf")
                    baseAlertaGeral.Rows.Add(linhaAlertaGeral)
                End If

proxProcesso3:
                contProc += 1
            Next


            AtualizaEntradaLog(contProc - 1 & " de " & baseLocal.Rows.Count - 1 & " Processos verificados")


            Dim dtOperGeral As DataTable = bllOPER.GetData(dtoOPER).Select("OPER_fl_alerta_nativo = 'S'").CopyToDataTable
            Dim mudanca_fase As String = ""
            Dim mudanca_evento As String = ""
            Dim fase_anterior As String = ""
            Dim fase_nova As String = ""
            Dim codigo_evento As String = ""
            Dim nome_alerta As String = ""

            Dim dtGen As New DataTable
            Dim drGen As DataRow

            dtGen.Columns.Add("processo")
            dtGen.Columns.Add("alerta")
            dtGen.Columns.Add("titular")
            dtGen.Columns.Add("fase_anterior")
            dtGen.Columns.Add("fase_atual")
            dtGen.Columns.Add("evento_anterior")
            dtGen.Columns.Add("ultimo_evento")
            dtGen.Columns.Add("mudou_fase")
            dtGen.Columns.Add("mudou_evento")
            dtGen.Columns.Add("link")
            dtGen.Columns.Add("novo")



            'inicia verificacao de  envio de alertas gerais
            'para cada alerta geral do sistema verifica se o 
            For Each drAlertaGeral As DataRow In dtAlerGeral.Rows

                For Each drBase As DataRow In baseAlertaGeral.Rows

                    drGen = Nothing

                    nome_alerta = drAlertaGeral("ALER_nm_alerta")
                    fase_anterior = drAlertaGeral("ALER_cd_fase_anterior")
                    fase_nova = drAlertaGeral("ALER_cd_fase_nova")
                    mudanca_fase = drAlertaGeral("ALER_fl_muda_fase").ToString.Trim
                    mudanca_evento = drAlertaGeral("ALER_fl_muda_evento").ToString.Trim
                    codigo_evento = base.AjustaNulo(drAlertaGeral("ALER_cd_evento"))

                    If mudanca_fase = "S" Then

                        If drBase("mudou_fase") = "S" Then

                            If fase_anterior = "0" And fase_nova = "0" Then

                                'se nao especifica fases na config. do alerta
                                If drGen Is Nothing Then
                                    drGen = dtGen.NewRow
                                    drGen("processo") = drBase("processo")
                                    drGen("alerta") = nome_alerta
                                    drGen("titular") = drBase("empresa")
                                    drGen("link") = drBase("link")
                                    drGen("novo") = IIf(drBase("novo") = "S", "Sim", "Não")

                                    gravaProcessoTabelaAuxiliar(drBase("processo"), drBase("uf"), drBase("empresa"), drBase("codigo_fase_nova"), drBase("evento_novo"), dtAux)

                                End If

                                drGen("fase_anterior") = drBase("fase_anterior")
                                drGen("fase_atual") = drBase("fase_atual")
                                drGen("mudou_fase") = IIf(drBase("mudou_fase") = "S", "Sim", "Não")



                            Else

                                If fase_anterior <> "0" Then

                                    'especificou fase anterior na config. do alerta
                                    'entao, verifica se a fase anterior do processo é igual
                                    If fase_anterior = drBase("codigo_fase_anterior") Then

                                        'se fase anterior é igual, 
                                        'verifica se espeficifou a fase nova
                                        If fase_nova <> "0" Then

                                            'se especificou a fase nova,
                                            'verifica se fase nova é igual
                                            'If drBase("codigo_fase_nova") = "12" Then
                                            '    Dim a As Integer = 0
                                            'End If

                                            If fase_nova = drBase("codigo_fase_nova") Then

                                                If drGen Is Nothing Then
                                                    drGen = dtGen.NewRow
                                                    drGen("processo") = drBase("processo")
                                                    drGen("alerta") = nome_alerta
                                                    drGen("titular") = drBase("empresa")
                                                    drGen("link") = drBase("link")
                                                    drGen("novo") = IIf(drBase("novo") = "S", "Sim", "Não")
                                                    gravaProcessoTabelaAuxiliar(drBase("processo"), drBase("uf"), drBase("empresa"), drBase("codigo_fase_nova"), drBase("evento_novo"), dtAux)

                                                End If

                                                drGen("fase_anterior") = drBase("fase_anterior")
                                                drGen("fase_atual") = drBase("fase_nova")
                                                drGen("mudou_fase") = IIf(drBase("mudou_fase") = "S", "Sim", "Não")


                                            Else
                                                'se nao, nao faz nada
                                            End If

                                        Else

                                            If drGen Is Nothing Then
                                                drGen = dtGen.NewRow
                                                drGen("processo") = drBase("processo")
                                                drGen("alerta") = nome_alerta
                                                drGen("titular") = drBase("empresa")
                                                drGen("link") = drBase("link")
                                                drGen("novo") = IIf(drBase("novo") = "S", "Sim", "Não")
                                                gravaProcessoTabelaAuxiliar(drBase("processo"), drBase("uf"), drBase("empresa"), drBase("codigo_fase_nova"), drBase("evento_novo"), dtAux)

                                            End If

                                            drGen("fase_anterior") = drBase("fase_anterior")
                                            drGen("fase_atual") = drBase("fase_nova")
                                            drGen("mudou_fase") = IIf(drBase("mudou_fase") = "S", "Sim", "Não")



                                        End If

                                    Else
                                        'se nao é igual, nao grava nada
                                    End If

                                Else

                                    'não especificou fase anterior na config. do alerta
                                    'verifica se especificou a fase nova
                                    If fase_nova <> "0" Then

                                        If fase_nova = drBase("codigo_fase_nova") Then

                                            If drGen Is Nothing Then
                                                drGen = dtGen.NewRow
                                                drGen("processo") = drBase("processo")
                                                drGen("alerta") = nome_alerta
                                                drGen("titular") = drBase("empresa")
                                                drGen("link") = drBase("link")
                                                drGen("novo") = IIf(drBase("novo") = "S", "Sim", "Não")
                                                gravaProcessoTabelaAuxiliar(drBase("processo"), drBase("uf"), drBase("empresa"), drBase("codigo_fase_nova"), drBase("evento_novo"), dtAux)

                                            End If

                                            drGen("fase_anterior") = drBase("fase_anterior")
                                            drGen("fase_atual") = drBase("fase_nova")
                                            drGen("mudou_fase") = IIf(drBase("mudou_fase") = "S", "Sim", "Não")



                                        End If
                                    End If


                                End If

                            End If


                        Else
                            'nao faz nada
                        End If

                    End If





                    If mudanca_evento = "S" Then

                        If drBase("mudou_evento") = "S" And eventoOK(codigo_evento, drBase("evento_novo")) Then

                            'se evento anterior é vazio, ou seja, não tinha referencia no sistema,
                            'não considera que mudou de evento

                            '07-05-2013
                            'COM EXCEÇÃO DE QUANDO O EVENTO ESTIVER ESPECIFICADO
                            'NA CONFIGURACAO DO ALERTA

                            If drBase("evento_anterior").ToString.Trim.Length = 0 And codigo_evento.Trim.Length = 0 Then

                                If drGen IsNot Nothing Then
                                    drGen("ultimo_evento") = drBase("evento_novo")
                                End If

                                GoTo prox1
                            End If


                            If drGen Is Nothing Then

                                drGen = dtGen.NewRow
                                drGen("processo") = drBase("processo")
                                drGen("alerta") = nome_alerta
                                drGen("titular") = drBase("empresa")
                                drGen("novo") = IIf(drBase("novo") = "S", "Sim", "Não")
                                drGen("link") = drBase("link")
                                drGen("fase_anterior") = drBase("fase_anterior")
                                drGen("fase_atual") = drBase("fase_nova")
                                drGen("mudou_fase") = IIf(drBase("mudou_fase") = "S", "Sim", "Não")
                                gravaProcessoTabelaAuxiliar(drBase("processo"), drBase("uf"), drBase("empresa"), drBase("codigo_fase_nova"), drBase("evento_novo"), dtAux)


                            End If



                            drGen("evento_anterior") = drBase("evento_anterior")
                            drGen("ultimo_evento") = drBase("evento_novo")
                            drGen("mudou_evento") = IIf(drBase("mudou_evento") = "S", "Sim", "Não")

                        Else

                            If drGen IsNot Nothing Then
                                drGen("evento_anterior") = drBase("evento_anterior")
                                drGen("ultimo_evento") = drBase("evento_novo")
                                drGen("mudou_evento") = IIf(drBase("mudou_evento") = "S", "Sim", "Não")
                            End If

                        End If

                    Else

                        If drGen IsNot Nothing Then
                            drGen("evento_anterior") = drBase("evento_anterior")
                            drGen("ultimo_evento") = drBase("evento_novo")
                            drGen("mudou_evento") = IIf(drBase("mudou_evento") = "S", "Sim", "Não")
                        End If

                    End If


prox1:

                    If drGen IsNot Nothing Then dtGen.Rows.Add(drGen)

                Next


            Next




            If dtGen.Rows.Count > 0 Then



                Dim codigo_operador As String = ""
                Dim nome_operador As String = ""
                Dim email_operador As String = ""
                Dim assunto As String = ""
                Dim texto As String = ""
                Dim mail1 As New Apoio.EmailAlertaGeral
                Dim mail As New Apoio.EmailGeral
                Dim dtAlertaDist As DataTable
                Dim curAlerta As DataTable

                dtAlertaDist = base.SelectDistinct(dtGen.TableName, dtGen, "alerta")

                For Each drAlerta As DataRow In dtAlertaDist.Rows

                    numAlertas += 1

                    nome_alerta = drAlerta("alerta")

                    curAlerta = dtGen.Select("alerta = '" & nome_alerta & "'").CopyToDataTable

                    AdicionaEntradaLog("Montando assunto e texto do email", enErrorType.Info)

                    If dtOperGeral.Rows.Count > 0 Then
                        assunto = mail1.MontaAssuntoEmail(nome_alerta)
                        texto = mail1.MontaTextoEmail(curAlerta.Rows)
                    End If

                    For Each drOperGeral As DataRow In dtOperGeral.Rows
                        codigo_operador = drOperGeral("OPER_cd_operador")
                        nome_operador = drOperGeral("OPER_nm_operador")
                        email_operador = drOperGeral("OPER_ds_email")
                        If email_operador.Trim.Length > 0 Then


                            Try
                                AdicionaEntradaLog("Gravando histórico de alertas para " & email_operador, enErrorType.Info)

                                'grava email na tabela de historico de alertas
                                'caso este fique pendente de envio
                                'essa tabela historica será lida numa proxima execucao
                                'e o(s) email(s) pendente(s) serão enviados
                                dtoHSAL = New DTO.tb_HSAL_historico_alerta

                                Try
                                    AdicionaEntradaLog("Buscando próximo ID de histórico", enErrorType.Info)
                                    id_historico = pega_id_historico()
                                    AdicionaEntradaLog("Próximo ID de histórico selecionado com sucesso [" & CStr(id_historico) & "]", enErrorType.Info)
                                Catch ex As Exception
                                    AdicionaEntradaLog("Erro ao tentar buscar próximo ID de histórico: " & ex.Message, enErrorType._Error)
                                End Try


                                dtoHSAL.AUDT_dt_inclusao = Now
                                dtoHSAL.AUDT_nm_usuario_inclusao = default_user
                                dtoHSAL.ALER_nm_alerta = nome_alerta
                                dtoHSAL.HSAL_ds_assunto_email = assunto
                                dtoHSAL.HSAL_ds_email = email_operador
                                dtoHSAL.HSAL_ds_mensagem = ""
                                dtoHSAL.HSAL_ds_texto_email = texto
                                dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                                dtoHSAL.HSAL_fl_status = "N"
                                dtoHSAL.PROC_cd_processo = "Vários"
                                dtoHSAL.HSAL_id_historico = id_historico


                                bllHSAL.ConnectionString = connection
                                bllHSAL.XMLPath = xmlpath

                                If bllHSAL.InsertData(dtoHSAL) Then
                                    AdicionaEntradaLog("Histórico de alertas gravado com sucesso para " & email_operador, enErrorType.Info)
                                Else
                                    AdicionaEntradaLog("Não foi possível gravar o histórico de alerta para " & email_operador, enErrorType._Error)
                                End If


                            Catch ex As Exception
                                AdicionaEntradaLog("Erro ao tentar gravar histórico de alerta para " & email_operador & ": " & ex.Message, enErrorType._Error)
                            End Try



                            Try

                                AdicionaEntradaLog("Enviando email para " & email_operador, enErrorType.Info)

                                mail.EnviaEmail(default_smtp, default_porta, default_email, email_operador, default_usuario, _
                                                default_senha, assunto, texto, Nothing, True, Nothing)

                                AdicionaEntradaLog("Email enviado com sucesso para " & email_operador, enErrorType.Info)
                                numEmailsOk += 1

                                Try
                                    'se enviou email, grava histórico do alerta 
                                    'como nao mais pendente

                                    AdicionaEntradaLog("Atualizando histórico de alerta para não pendente: " & email_operador, enErrorType.Info)

                                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                                    dtoHSAL.HSAL_ds_mensagem = ""
                                    dtoHSAL.HSAL_dt_envio = Now
                                    dtoHSAL.HSAL_fl_status = "S"
                                    dtoHSAL.HSAL_id_historico = id_historico

                                    If bllHSAL.UpdateData(dtoHSAL) Then
                                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para não pendente: " & email_operador, enErrorType.Info)
                                    Else
                                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para não pendente: " & email_operador, enErrorType._Error)
                                    End If

                                Catch ex As Exception
                                    AdicionaEntradaLog("Erro ao tentar atualizar histórico de alerta para não pendente para " & email_operador & ": " & ex.Message, enErrorType._Error)
                                End Try



                            Catch ex As Exception

                                AdicionaEntradaLog("Erro ao tentar enviar email para " & email_operador, enErrorType._Error)
                                numEmailsPendentes += 1

                                Try
                                    'se enviou email, grava histórico do alerta 
                                    'como nao mais pendente

                                    AdicionaEntradaLog("Atualizando histórico de alerta para pendente: " & email_operador, enErrorType.Info)

                                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                                    dtoHSAL.HSAL_ds_mensagem = ex.Message
                                    dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                                    dtoHSAL.HSAL_fl_status = "N"
                                    dtoHSAL.HSAL_id_historico = id_historico

                                    If bllHSAL.UpdateData(dtoHSAL) Then
                                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente: " & email_operador, enErrorType.Info)
                                    Else
                                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente: " & email_operador, enErrorType._Error)
                                    End If

                                Catch ex2 As Exception
                                    AdicionaEntradaLog("Erro ao tentar atualizar histórico de alerta para pendente para " & email_operador & ": " & ex2.Message, enErrorType._Error)
                                End Try

                            End Try

                        End If
                    Next


                Next
            End If
            AdicionaEntradaLog("Fim da verificação de alertas gerais", enErrorType.Info)



            'FIMPATCH_16082012 - Geração de Alerta Geral
















            AdicionaEntradaLog("Iniciando atualização de processos minerários...", enErrorType.Info)


proxEtapa:
            'para cada processo, busca dados na base do sistema
            For Each drProc As DataRow In dtProc.Rows

                'atualiza dados da base do sistema com os dados da base local 

                If baseLocal.Select("name = '" & drProc("PROC_cd_processo") & "'").Length = 0 Then
                    AdicionaEntradaLog("Processo [" & drProc("PROC_cd_processo") & "] existe no sistema, porém não foi encontrado nos dados do DNPM", enErrorType._Error)
                    GoTo proxProcesso2
                End If


                drDNPM = baseLocal.Select("name = '" & drProc("PROC_cd_processo") & "'")(0)

                Try
                    AdicionaEntradaLog("Convertendo HTML em DATAROW para o processo [" & drProc("PROC_cd_processo") & "]", enErrorType.Info)
                    drDados = converteHTMLParaDatarow(dtFase, drDNPM("description"))
                    AdicionaEntradaLog("Dados do processo convertidos com sucesso", enErrorType.Info)
                Catch ex As Exception
                    AdicionaEntradaLog("Erro ao tentar converter HTML em DATAROW para o processo [" & drProc("PROC_cd_processo") & "]: " & ex.Message, enErrorType._Error)
                    GoTo proxProcesso2
                End Try

                Try


                    dtoProc = New DTO.tb_PROC_processo
                    dtoProc.PROC_cd_processo = drDados("processo")
                    dtoProc.PROC_nm_processo = drDados("numero")
                    dtoProc.PROC_ds_area = drDados("area")
                    dtoProc.PROC_ds_link = drDados("link")
                    dtoProc.PROC_ds_substancia = drDados("substancia")
                    dtoProc.PROC_ds_titular = drDados("titular")
                    dtoProc.PROC_ds_ultimo_evento = drDados("evento")
                    dtoProc.PROC_ds_uso = drDados("uso")
                    dtoProc.PROC_id_processo = drDados("id")
                    dtoProc.PROC_vl_ano = drDados("ano")
                    dtoProc.UNFE_cd_unidade_federativa = drDados("uf")
                    dtoProc.AUDT_dt_alteracao = Now
                    dtoProc.AUDT_nm_usuario_alteracao = default_user
                    dtoProc.FASE_cd_fase = drDados("codigo_fase")


                    If bllProc.UpdateData(dtoProc) Then
                        numAtualizados += 1
                        AdicionaEntradaLog("Dados do processo [" & drProc("PROC_cd_processo") & "] atualizados com sucesso", enErrorType.Info)
                    Else
                        AdicionaEntradaLog("Não foi possível atualizar os dados do processo [" & drProc("PROC_cd_processo") & "]", enErrorType._Error)
                    End If

                Catch ex As Exception
                    AdicionaEntradaLog("Erro ao tentar atualizar dados do processo [" & drProc("PROC_cd_processo") & "]: " & ex.Message, enErrorType._Error)
                End Try


                'se mudou de fase ou de evento, insere na tabela de alertas a enviar
                If base.NuloParaZero(drProc("FASE_cd_fase")) <> drDados("codigo_fase") Or _
                base.AjustaNulo(drProc("PROC_ds_ultimo_evento")) <> drDados("evento") Then

                    Try


                        AdicionaEntradaLog("Identificado mudança de fase/evento para o processo [" & drProc("PROC_cd_processo") & "]", enErrorType.Info)

                        linhaAlerta = baseAlerta.NewRow

                        linhaAlerta("processo") = drDados("processo")
                        linhaAlerta("link") = drDados("link")
                        linhaAlerta("empresa") = drDados("titular")
                        linhaAlerta("empresa_cadastrada") = empresa_cadastrada(drDados("titular"), dtEmprTodas)
                        linhaAlerta("alertas") = pega_alertas_associados(dtPRAL, dtALER, drProc("PROC_cd_processo"))
                        linhaAlerta("operadores") = pega_operadores_associados(dtPROP, dtOPER, drProc("PROC_cd_processo"))
                        linhaAlerta("mudou_evento") = IIf(base.AjustaNulo(drProc("PROC_ds_ultimo_evento")) <> drDados("evento"), "S", "N")
                        linhaAlerta("mudou_fase") = IIf(base.NuloParaZero(drProc("FASE_cd_fase")) <> drDados("codigo_fase"), "S", "N")
                        linhaAlerta("codigo_fase_anterior") = base.NuloParaZero(drProc("FASE_cd_fase"))
                        linhaAlerta("codigo_fase_nova") = drDados("codigo_fase")
                        linhaAlerta("fase_anterior") = obj.getValue(dtFase, base.NuloParaZero(drProc("FASE_cd_fase")))
                        linhaAlerta("fase_nova") = drDados("fase")
                        linhaAlerta("evento_anterior") = base.AjustaNulo(drProc("PROC_ds_ultimo_evento"))
                        linhaAlerta("evento_novo") = drDados("evento")





                        'se mudou o evento, inclui na tabela historica de eventos do processo
                        If linhaAlerta("mudou_evento") = "S" Then

                            Try

                                AdicionaEntradaLog("Registrando novo evento para o processo [" & drProc("PROC_cd_processo") & "]", enErrorType.Info)

                                dtoPREV.AUDT_dt_alteracao = Now
                                dtoPREV.AUDT_dt_inclusao = Now
                                dtoPREV.AUDT_nm_usuario_alteracao = default_user
                                dtoPREV.AUDT_nm_usuario_inclusao = default_user
                                dtoPREV.PREV_cd_evento = pega_codigo_evento(drDados("evento"))
                                dtoPREV.PREV_dt_ocorrencia = pega_data_evento(drDados("evento"))
                                dtoPREV.PREV_ds_evento = drDados("evento")
                                dtoPREV.PROC_cd_processo = drDados("processo")

                                If bllPREV.InsertData(dtoPREV) Then
                                    AdicionaEntradaLog("Novo evento registrado para o processo [" & drProc("PROC_cd_processo") & "] com sucesso", enErrorType.Info)
                                Else
                                    AdicionaEntradaLog("Não foi possível registrar novo evento para o processo [" & drProc("PROC_cd_processo") & "]", enErrorType._Error)
                                End If

                            Catch ex As Exception
                                AdicionaEntradaLog("Erro ao tentar registrar novo evento para o processo [" & drProc("PROC_cd_processo") & "]: " & ex.Message, enErrorType._Error)
                            End Try

                        End If




                        baseAlerta.Rows.Add(linhaAlerta)

                        AdicionaEntradaLog("Dado de mudança de fase/evento para o processo [" & drProc("PROC_cd_processo") & "] gravado com sucesso", enErrorType.Info)

                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar gravar dado de mudança de fase/evento para o processo [" & drProc("PROC_cd_processo") & "]", enErrorType._Error)
                    End Try

                End If



proxProcesso2:
            Next



final:
            Return True


        Catch ex As Exception
            AdicionaEntradaLog("Erro na rotina SincronizaProcessos: " & ex.Message, enErrorType._Error)
            Return False
        End Try




    End Function
    Private Function eventoOK(ByVal codigo_evento As String, ByVal evento_novo As String) As Boolean

        If evento_novo.Contains("-") Then
            evento_novo = Split(evento_novo, "-")(0).Trim
        End If

        If codigo_evento = "0" Or codigo_evento.Trim.Length = 0 Then
            Return True
        Else
            Return codigo_evento.Trim = evento_novo.Trim
        End If
    End Function

    Private Function pega_codigo_evento(ByVal descricao As String) As String
        Dim valor As String = ""

        For Each c As String In descricao.ToCharArray
            If IsNumeric(c) Then
                valor += c
            Else
                Exit For
            End If
        Next

        If valor.Trim.Length = 0 Then

            'pega codigo do evento com simples incremento ao valor maior
            'esse codigo é chave no banco
            'talvez dê problema pois não sei como isso é tratado do lado do dnpm

            Dim bllPREV As New BLL.tb_PREV_processo_evento
            Dim dtoPrev As New DTO.tb_PREV_processo_evento
            bllPREV.ConnectionString = connection
            bllPREV.XMLPath = xmlpath
            Return bllPREV.GetNextIndex(dtoPrev)

        End If

        Return valor
    End Function
    Private Function pega_data_evento(ByVal descricao As String) As Date
        Dim valor As Date
        Dim ok As Boolean = False

        If descricao.Trim.Length > 10 Then
            If IsDate(Microsoft.VisualBasic.Right(descricao, 10)) Then
                valor = CDate(Microsoft.VisualBasic.Right(descricao, 10))
                ok = True
            End If
        End If



        If Not ok Then

            'se nao conseguir pegar a data pela descricao do evento,
            'coloca a data atual
            valor = Now.Date

        End If

        Return valor
    End Function
    Private Function pega_alertas_associados(ByVal dtPRAL As DataTable, ByVal dtALER As DataTable, ByVal processo As String) As String
        Dim lista As String = ""
        Dim drPRAL() As DataRow
        Dim filtro As String = "PROC_cd_processo = '" & processo & "' "
        Dim muda_fase As String = ""
        Dim muda_evento As String = ""
        Dim fase_anterior As String = ""
        Dim fase_nova As String = ""
        Dim drAler() As DataRow
        Dim filtroAler As String = ""

        drPRAL = dtPRAL.Select(filtro)

        For Each rPRAL As DataRow In drPRAL

            'pega os dados do alerta
            filtroAler = "ALER_nm_alerta = '" & rPRAL("ALER_nm_alerta").ToString.Trim & "' "
            drAler = dtALER.Select(filtroAler)

            If drAler.Length > 0 Then

                If drAler(0)("ALER_fl_status") = "A" And drAler(0)("ALER_fl_qualquer_processo") = "N" Then
                    If lista.Trim.Length > 0 Then lista += vbCrLf
                    lista += drAler(0)("ALER_nm_alerta")
                    lista += "|"
                    lista += drAler(0)("ALER_fl_muda_fase")
                    lista += "|"
                    lista += drAler(0)("ALER_fl_muda_evento")
                    lista += "|"
                    lista += base.NuloParaZero(drAler(0)("ALER_cd_fase_anterior"))
                    lista += "|"
                    lista += base.NuloParaZero(drAler(0)("ALER_cd_fase_nova"))
                    lista += "|"
                    lista += base.NuloParaZero(drAler(0)("ALER_cd_evento"))
                End If

            End If

        Next


        'pega os alertas habilitados e com flag TODOS PROCESSOS = 'S'
        filtroAler = "ALER_fl_qualquer_processo = 'S' and ALER_fl_status = 'A' "
        drAler = dtALER.Select(filtroAler)

        For Each rAler As DataRow In drAler
            If lista.Trim.Length > 0 Then lista += vbCrLf
            lista += rAler("ALER_nm_alerta")
            lista += "|"
            lista += rAler("ALER_fl_muda_fase")
            lista += "|"
            lista += rAler("ALER_fl_muda_evento")
            lista += "|"
            lista += base.NuloParaZero(rAler("ALER_cd_fase_anterior"))
            lista += "|"
            lista += base.NuloParaZero(rAler("ALER_cd_fase_nova"))
            lista += "|"
            lista += base.NuloParaZero(rAler("ALER_cd_evento"))
        Next


        Return lista
    End Function
    Private Function pega_operadores_associados(ByVal dtPROP As DataTable, ByVal dtOPER As DataTable, ByVal processo As String) As String
        Dim lista As String = ""
        Dim drPROP() As DataRow
        Dim filtro As String = "PROC_cd_processo = '" & processo & "' "
        Dim drOper() As DataRow
        Dim filtroOper As String = ""

        drPROP = dtPROP.Select(filtro)

        For Each rPROP As DataRow In drPROP

            'pega os dados do operador
            filtroOper = "OPER_cd_operador = '" & rPROP("OPER_cd_operador").ToString.Trim & "' "
            drOper = dtOPER.Select(filtroOper)

            If drOper.Length > 0 Then

                If drOper(0)("OPER_fl_alerta") = "S" Then
                    If lista.Trim.Length > 0 Then lista += vbCrLf
                    lista += drOper(0)("OPER_cd_operador")
                    lista += "|"
                    lista += drOper(0)("OPER_nm_operador")
                    lista += "|"
                    lista += drOper(0)("OPER_ds_email")
                End If

            End If

        Next



        Return lista
    End Function

    Private Function empresa_cadastrada(ByVal descricao As String, ByVal dtEmpr As DataTable) As String
        Dim val As String = "N"
        If dtEmpr.Select("EMPR_ds_empresa like '%" & descricao & "%'").Length > 0 Then
            val = "S"
        Else
            val = "N"
        End If
        Return val
    End Function

    Public Sub TratamentoAlertas()

        If baseAlerta.Rows.Count = 0 Then
            AdicionaEntradaLog("Não foi detectada nenhuma alteração de fase ou evento dos processos minerários cadastrados no sistema", enErrorType.Info)
            Exit Sub
        End If

        Dim mail As New Apoio.EmailGeral
        Dim mail1 As New Apoio.EmailMeuProcesso
        Dim mail2 As New Apoio.EmailOutroProcesso
        Dim Meusprocessos() As DataRow
        Dim OutrosProcessos() As DataRow
        Dim filtro As String = ""
        Dim linhasAlerta() As String
        Dim linhasOperador() As String
        Dim dadosAlerta() As String
        Dim dadosOperador() As String
        Dim nome_alerta As String = ""
        Dim mudanca_fase As String = ""
        Dim mudanca_evento As String = ""
        Dim codigo_evento As String = ""
        Dim fase_anterior As String = ""
        Dim fase_nova As String = ""
        Dim codigo_operador As String = ""
        Dim nome_operador As String = ""
        Dim email_operador As String = ""
        Dim assunto As String = ""
        Dim texto As String = ""
        Dim dtGen As New DataTable
        Dim drGen As DataRow

        Dim dtHSAL As DataTable
        Dim bllHSAL As New BLL.tb_HSAL_historico_alerta
        Dim dtoHSAL As DTO.tb_HSAL_historico_alerta
        Dim id_historico As Integer = 0

        bllHSAL.ConnectionString = connection
        bllHSAL.XMLPath = xmlpath

        dtGen.Columns.Add("descricao")
        dtGen.Columns.Add("valor")


        Try

            AdicionaEntradaLog("Iniciando envio de alertas para processos de empresas cadastradas", enErrorType.Info)

            'busca meus processos
            filtro = "empresa_cadastrada = 'S'"
            Meusprocessos = baseAlerta.Select(filtro)

            For Each proc As DataRow In Meusprocessos

                dtGen.Rows.Clear()

                linhasAlerta = Split(proc("alertas"), vbCrLf)
                For Each linhaAlerta As String In linhasAlerta

                    dtGen.Rows.Clear()

                    If linhaAlerta.Trim.Length > 0 Then

                        dadosAlerta = Split(linhaAlerta, "|")

                        If dadosAlerta.Length > 0 Then

                            nome_alerta = dadosAlerta(0)
                            mudanca_fase = dadosAlerta(1)
                            mudanca_evento = dadosAlerta(2)
                            fase_anterior = dadosAlerta(3)
                            fase_nova = dadosAlerta(4)
                            codigo_evento = dadosAlerta(5)

                            If mudanca_fase = "S" Then

                                If proc("mudou_fase") = "S" Then

                                    If fase_anterior = "0" And _
                                       fase_nova = "0" Then

                                        'se nao especifica fases na config. do alerta
                                        drGen = dtGen.NewRow
                                        drGen("descricao") = "Mudou Fase?"
                                        drGen("valor") = "SIM"
                                        dtGen.Rows.Add(drGen)

                                        numAlertas += 1

                                        drGen = dtGen.NewRow
                                        drGen("descricao") = "Fase Anterior"
                                        drGen("valor") = proc("fase_anterior")
                                        dtGen.Rows.Add(drGen)

                                        drGen = dtGen.NewRow
                                        drGen("descricao") = "Fase Atual"
                                        drGen("valor") = proc("fase_nova")
                                        dtGen.Rows.Add(drGen)

                                    Else

                                        If fase_anterior <> "0" Then

                                            'especificou fase anterior na config. do alerta
                                            'entao, verifica se a fase anterior do processo é igual
                                            If fase_anterior = proc("codigo_fase_anterior") Then

                                                'se fase anterior é igual, 
                                                'verifica se espeficifou a fase nova
                                                If fase_nova <> "0" Then

                                                    'se especificou a fase nova,
                                                    'verifica se fase nova é igual


                                                    If fase_nova = proc("codigo_fase_nova") Then
                                                        'se sim, grava linha
                                                        drGen = dtGen.NewRow
                                                        drGen("descricao") = "Mudou Fase?"
                                                        drGen("valor") = "SIM"
                                                        dtGen.Rows.Add(drGen)

                                                        numAlertas += 1

                                                        drGen = dtGen.NewRow
                                                        drGen("descricao") = "Fase Anterior"
                                                        drGen("valor") = proc("fase_anterior")
                                                        dtGen.Rows.Add(drGen)

                                                        drGen = dtGen.NewRow
                                                        drGen("descricao") = "Fase Atual"
                                                        drGen("valor") = proc("fase_nova")
                                                        dtGen.Rows.Add(drGen)
                                                    Else
                                                        'se nao, nao faz nada
                                                    End If

                                                Else

                                                    'se nao especificou a fase nova, 
                                                    'e a fase anterior é igual
                                                    'grava linha
                                                    drGen = dtGen.NewRow
                                                    drGen("descricao") = "Mudou Fase?"
                                                    drGen("valor") = "SIM"
                                                    dtGen.Rows.Add(drGen)

                                                    numAlertas += 1

                                                    drGen = dtGen.NewRow
                                                    drGen("descricao") = "Fase Anterior"
                                                    drGen("valor") = proc("fase_anterior")
                                                    dtGen.Rows.Add(drGen)

                                                    drGen = dtGen.NewRow
                                                    drGen("descricao") = "Fase Atual"
                                                    drGen("valor") = proc("fase_nova")
                                                    dtGen.Rows.Add(drGen)



                                                End If

                                            Else
                                                'se nao é igual, nao grava nada
                                            End If

                                        Else

                                            'não especificou fase anterior na config. do alerta
                                            'verifica se especificou a fase nova
                                            If fase_nova <> "0" Then

                                                If fase_nova = proc("codigo_fase_nova") Then

                                                    drGen = dtGen.NewRow
                                                    drGen("descricao") = "Mudou Fase?"
                                                    drGen("valor") = "SIM"
                                                    dtGen.Rows.Add(drGen)

                                                    drGen = dtGen.NewRow
                                                    drGen("descricao") = "Fase Anterior"
                                                    drGen("valor") = proc("fase_anterior")
                                                    dtGen.Rows.Add(drGen)

                                                    drGen = dtGen.NewRow
                                                    drGen("descricao") = "Fase Atual"
                                                    drGen("valor") = proc("fase_nova")
                                                    dtGen.Rows.Add(drGen)

                                                    numAlertas += 1


                                                End If
                                            End If


                                        End If

                                    End If


                                Else
                                    drGen = dtGen.NewRow
                                    drGen("descricao") = "Mudou Fase?"
                                    drGen("valor") = "NÃO"
                                    dtGen.Rows.Add(drGen)
                                End If

                            End If





                            If mudanca_evento = "S" And eventoOK(codigo_evento, proc("evento_novo")) Then

                                drGen = dtGen.NewRow
                                drGen("descricao") = "Mudou Evento?"
                                drGen("valor") = IIf(proc("mudou_evento") = "S", "SIM", "NÃO")
                                dtGen.Rows.Add(drGen)

                                drGen = dtGen.NewRow
                                drGen("descricao") = "Último Evento"
                                drGen("valor") = proc("evento_novo")
                                dtGen.Rows.Add(drGen)

                                If proc("mudou_evento") = "S" And eventoOK(codigo_evento, proc("evento_novo")) Then
                                    drGen = dtGen.NewRow
                                    drGen("descricao") = "Evento Anterior"
                                    drGen("valor") = proc("evento_anterior")
                                    dtGen.Rows.Add(drGen)
                                    numAlertas += 1
                                End If



                            End If




                            If dtGen.Rows.Count > 0 Then


                                linhasOperador = Split(proc("operadores"), vbCrLf)

                                For Each linhaOperador As String In linhasOperador

                                    dadosOperador = Split(linhaOperador, "|")

                                    If dadosOperador.Length > 0 Then



                                        codigo_operador = dadosOperador(0)
                                        nome_operador = dadosOperador(1)
                                        email_operador = dadosOperador(2)

                                        assunto = mail1.MontaAssuntoEmail(proc("processo"), nome_alerta, proc("empresa"))
                                        texto = mail1.MontaTextoEmail(proc("processo"), proc("link"), proc("empresa"), dtGen.Rows)



                                        'grava historico do alerta a ser enviado
                                        dtoHSAL = New DTO.tb_HSAL_historico_alerta

                                        Try
                                            AdicionaEntradaLog("Buscando próximo ID de histórico", enErrorType.Info)
                                            id_historico = pega_id_historico()
                                            AdicionaEntradaLog("Próximo ID de histórico selecionado com sucesso [" & CStr(id_historico) & "]", enErrorType.Info)
                                        Catch ex As Exception
                                            AdicionaEntradaLog("Erro ao tentar buscar próximo ID de histórico: " & ex.Message, enErrorType._Error)
                                        End Try


                                        dtoHSAL.AUDT_dt_inclusao = Now
                                        dtoHSAL.AUDT_nm_usuario_inclusao = default_user
                                        dtoHSAL.ALER_nm_alerta = nome_alerta
                                        dtoHSAL.HSAL_ds_assunto_email = assunto
                                        dtoHSAL.HSAL_ds_email = email_operador
                                        dtoHSAL.HSAL_ds_mensagem = ""
                                        dtoHSAL.HSAL_ds_texto_email = texto
                                        dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                                        dtoHSAL.HSAL_fl_status = "N"
                                        dtoHSAL.PROC_cd_processo = proc("processo")
                                        dtoHSAL.HSAL_id_historico = id_historico


                                        bllHSAL.ConnectionString = connection
                                        bllHSAL.XMLPath = xmlpath

                                        If bllHSAL.InsertData(dtoHSAL) Then
                                            AdicionaEntradaLog("Histórico de alertas gravado com sucesso para " & email_operador, enErrorType.Info)
                                        Else
                                            AdicionaEntradaLog("Não foi possível gravar o histórico de alerta para " & email_operador, enErrorType._Error)
                                        End If



                                        Try

                                            AdicionaEntradaLog("Enviando email de alerta para " & email_operador, enErrorType.Info)

                                            mail.EnviaEmail(default_smtp, default_porta, _
                                                            default_email, email_operador, _
                                                            default_usuario, default_senha, _
                                                            assunto, texto, Nothing, True, Nothing)

                                            numEmailsOk += 1
                                            AdicionaEntradaLog("Email de alerta enviado com sucesso para " & email_operador, enErrorType.Info)


                                            'se enviou email, grava histórico do alerta 
                                            'como nao mais pendente

                                            AdicionaEntradaLog("Atualizando histórico de alerta para não pendente: " & email_operador, enErrorType.Info)
                                            dtoHSAL = New DTO.tb_HSAL_historico_alerta
                                            dtoHSAL.HSAL_ds_mensagem = ""
                                            dtoHSAL.HSAL_dt_envio = Now
                                            dtoHSAL.HSAL_fl_status = "S"
                                            dtoHSAL.HSAL_id_historico = id_historico
                                            If bllHSAL.UpdateData(dtoHSAL) Then
                                                AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para não pendente: " & email_operador, enErrorType.Info)
                                            Else
                                                AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para não pendente: " & email_operador, enErrorType._Error)
                                            End If


                                        Catch ex As Exception
                                            numEmailsPendentes += 1
                                            AdicionaEntradaLog("Erro ao tentar enviar email de alerta para " & email_operador, enErrorType._Error)

                                            'se enviou email, grava histórico do alerta 
                                            'como nao mais pendente

                                            AdicionaEntradaLog("Atualizando histórico de alerta para pendente: " & email_operador, enErrorType.Info)
                                            dtoHSAL = New DTO.tb_HSAL_historico_alerta
                                            dtoHSAL.HSAL_ds_mensagem = ex.Message
                                            dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                                            dtoHSAL.HSAL_fl_status = "N"
                                            dtoHSAL.HSAL_id_historico = id_historico
                                            If bllHSAL.UpdateData(dtoHSAL) Then
                                                AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente: " & email_operador, enErrorType.Info)
                                            Else
                                                AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente: " & email_operador, enErrorType._Error)
                                            End If

                                        End Try

                                    End If

                                Next





                            End If


                        End If
                    End If
                Next





            Next


            AdicionaEntradaLog("Envio de Alertas (Empresas Cadastradas) realizado com sucesso", enErrorType.Info)

        Catch ex As Exception
            AdicionaEntradaLog("Erro ao tentar enviar alertas de processos das empresas cadastradas: " & ex.Message, enErrorType._Error)
        End Try








        Try

            AdicionaEntradaLog("Iniciando envio de alertas para processos de outras empresas", enErrorType.Info)
            'busca outros processos (de empresas não cadastradas)

            'pega processos x operadores
            Dim dtoPROP As New DTO.tb_PROP_processo_operador
            Dim bllPROP As New BLL.tb_PROP_processo_operador
            Dim dtPROP As DataTable
            bllPROP.ConnectionString = connection
            bllPROP.XMLPath = xmlpath
            dtPROP = bllPROP.GetData(dtoPROP)

            Dim dtGen2 As New DataTable
            Dim drGen2 As DataRow
            dtGen2.Columns.Add("processo")
            dtGen2.Columns.Add("alerta")
            dtGen2.Columns.Add("titular")
            dtGen2.Columns.Add("fase_anterior")
            dtGen2.Columns.Add("fase_atual")
            dtGen2.Columns.Add("evento_anterior")
            dtGen2.Columns.Add("ultimo_evento")
            dtGen2.Columns.Add("mudou_fase")
            dtGen2.Columns.Add("mudou_evento")
            dtGen2.Columns.Add("link")

            Dim dtOper1 As New DataTable
            Dim drOper1 As DataRow
            dtOper1.Columns.Add("codigo")
            dtOper1.Columns.Add("nome")
            dtOper1.Columns.Add("email")



            filtro = "empresa_cadastrada = 'N'"
            OutrosProcessos = baseAlerta.Select(filtro)

            'pega os operadores envolvidos
            For Each proc As DataRow In OutrosProcessos
                Dim linhasOper() As String = Split(proc("operadores"), vbCrLf)
                For Each linhaOper As String In linhasOper

                    Dim dadosOper() As String = Split(linhaOper, "|")

                    If dadosOper.Length > 0 Then

                        If dtOper1.Select("codigo = '" & dadosOper(0) & "'").Length = 0 Then
                            drOper1 = dtOper1.NewRow
                            drOper1("codigo") = dadosOper(0)
                            drOper1("nome") = dadosOper(1)
                            drOper1("email") = dadosOper(2)
                            dtOper1.Rows.Add(drOper1)
                        End If

                    End If

                Next
            Next



            For Each proc As DataRow In OutrosProcessos


                linhasAlerta = Split(proc("alertas"), vbCrLf)
                For Each linhaAlerta As String In linhasAlerta

                    drGen2 = Nothing

                    If linhaAlerta.Trim.Length > 0 Then

                        drGen2 = Nothing

                        dadosAlerta = Split(linhaAlerta, "|")

                        If dadosAlerta.Length > 0 Then

                            nome_alerta = dadosAlerta(0)
                            mudanca_fase = dadosAlerta(1)
                            mudanca_evento = dadosAlerta(2)
                            fase_anterior = dadosAlerta(3)
                            fase_nova = dadosAlerta(4)
                            codigo_evento = dadosAlerta(5)

                            If mudanca_fase = "S" Then

                                If proc("mudou_fase") = "S" Then

                                    If fase_anterior = "0" And _
                                       fase_nova = "0" Then

                                        'se nao especifica fases na config. do alerta
                                        If drGen2 Is Nothing Then
                                            drGen2 = dtGen2.NewRow
                                            drGen2("processo") = proc("processo")
                                            drGen2("titular") = proc("empresa")
                                            drGen2("alerta") = nome_alerta
                                            drGen2("link") = proc("link")
                                        End If

                                        drGen2("mudou_fase") = "SIM"
                                        drGen2("fase_anterior") = proc("fase_anterior")
                                        drGen2("fase_atual") = proc("fase_nova")




                                    Else

                                        If fase_anterior <> "0" Then

                                            'especificou fase anterior na config. do alerta
                                            'entao, verifica se a fase anterior do processo é igual
                                            If fase_anterior = proc("codigo_fase_anterior") Then

                                                'se fase anterior é igual, 
                                                'verifica se espeficifou a fase nova
                                                If fase_nova <> "0" Then

                                                    'se especificou a fase nova,
                                                    'verifica se fase nova é igual


                                                    If fase_nova = proc("codigo_fase_nova") Then
                                                        'se sim, grava linha

                                                        If drGen2 Is Nothing Then
                                                            drGen2 = dtGen2.NewRow
                                                            drGen2("processo") = proc("processo")
                                                            drGen2("titular") = proc("empresa")
                                                            drGen2("alerta") = nome_alerta
                                                            drGen2("link") = proc("link")
                                                        End If

                                                        drGen2("mudou_fase") = "SIM"
                                                        drGen2("fase_anterior") = proc("fase_anterior")
                                                        drGen2("fase_atual") = proc("fase_nova")

                                                    Else
                                                        'se nao, nao faz nada
                                                    End If

                                                Else

                                                    'se nao especificou a fase nova, grava linha

                                                    If drGen2 Is Nothing Then
                                                        drGen2 = dtGen2.NewRow
                                                        drGen2("processo") = proc("processo")
                                                        drGen2("alerta") = nome_alerta
                                                        drGen2("titular") = proc("empresa")
                                                        drGen2("link") = proc("link")
                                                    End If

                                                    drGen2("mudou_fase") = "SIM"
                                                    drGen2("fase_anterior") = proc("fase_anterior")
                                                    drGen2("fase_atual") = proc("fase_nova")


                                                End If

                                            Else
                                                'se nao é igual, nao grava nada
                                            End If

                                        Else

                                            'não especificou fase anterior na config. do alerta
                                            'verifica se especificou a fase nova
                                            If fase_nova <> "0" Then

                                                If fase_nova = proc("codigo_fase_nova") Then

                                                    If drGen2 Is Nothing Then
                                                        drGen2 = dtGen2.NewRow
                                                        drGen2("processo") = proc("processo")
                                                        drGen2("titular") = proc("empresa")
                                                        drGen2("alerta") = nome_alerta
                                                        drGen2("link") = proc("link")
                                                    End If

                                                    drGen2("mudou_fase") = "SIM"
                                                    drGen2("fase_anterior") = proc("fase_anterior")
                                                    drGen2("fase_atual") = proc("fase_nova")



                                                End If
                                            End If


                                        End If

                                    End If


                                Else


                                    If drGen2 Is Nothing Then
                                        drGen2 = dtGen2.NewRow
                                        drGen2("processo") = proc("processo")
                                        drGen2("titular") = proc("empresa")
                                        drGen2("alerta") = nome_alerta
                                        drGen2("link") = proc("link")
                                    End If

                                    drGen2("mudou_fase") = "NÃO"
                                    drGen2("fase_anterior") = proc("fase_anterior")
                                    drGen2("fase_atual") = proc("fase_nova")



                                End If

                            End If





                            If mudanca_evento = "S" Then

                                If proc("mudou_evento") = "S" And eventoOK(codigo_evento, proc("evento_novo")) Then

                                    If drGen2 Is Nothing Then
                                        drGen2 = dtGen2.NewRow
                                        drGen2("processo") = proc("processo")
                                        drGen2("titular") = proc("empresa")
                                        drGen2("alerta") = nome_alerta
                                        drGen2("link") = proc("link")
                                    End If


                                    drGen2("mudou_evento") = IIf(proc("mudou_evento") = "S", "SIM", "NÃO")
                                    drGen2("ultimo_evento") = proc("evento_novo")

                                    If proc("mudou_evento") = "S" And eventoOK(codigo_evento, proc("evento_novo")) Then
                                        drGen2("evento_anterior") = proc("evento_anterior")
                                    End If
                                End If
                            End If



                            If drGen2 IsNot Nothing Then dtGen2.Rows.Add(drGen2)


                        End If
                    End If
                Next

            Next


            If dtGen2.Rows.Count > 0 Then

                dtGen2.TableName = "AlertasOutrasEmpresas"
                Dim dtDistinct As DataTable = base.SelectDistinct(dtGen2.TableName, dtGen2, "alerta")

                If dtDistinct.Rows.Count > 0 Then

                    numAlertas += dtDistinct.Rows.Count

                    For Each drAlerta As DataRow In dtDistinct.Rows


                        Dim drProc() As DataRow = dtGen2.Select("alerta = '" & drAlerta("alerta") & "'")

                        For Each drOper As DataRow In dtOper1.Rows

                            Dim dtProcOper As DataTable = dtGen2.Clone
                            Dim drProcOper As DataRow


                            'pega apenas os processos relacionados ao operador
                            For Each rProc As DataRow In drProc
                                If dtPROP.Select("PROC_cd_processo = '" & rProc("processo") & "' and OPER_cd_operador = '" & drOper("codigo") & "' ").Length > 0 Then
                                    drProcOper = dtProcOper.NewRow
                                    drProcOper("processo") = rProc("processo")
                                    drProcOper("alerta") = drAlerta("alerta")
                                    drProcOper("titular") = rProc("titular")
                                    drProcOper("mudou_fase") = rProc("mudou_fase")
                                    drProcOper("mudou_evento") = rProc("mudou_evento")
                                    drProcOper("evento_anterior") = rProc("evento_anterior")
                                    drProcOper("ultimo_evento") = rProc("ultimo_evento")
                                    drProcOper("fase_anterior") = rProc("fase_anterior")
                                    drProcOper("fase_atual") = rProc("fase_atual")
                                    drProcOper("link") = rProc("link")
                                    dtProcOper.Rows.Add(drProcOper)
                                End If
                            Next

                            If dtProcOper.Rows.Count > 0 Then

                                assunto = mail2.MontaAssuntoEmail(drAlerta("alerta"))
                                texto = mail2.MontaTextoEmail(dtProcOper.Rows)


                                'grava historico do alerta a ser enviado
                                dtoHSAL = New DTO.tb_HSAL_historico_alerta

                                Try
                                    AdicionaEntradaLog("Buscando próximo ID de histórico", enErrorType.Info)
                                    id_historico = pega_id_historico()
                                    AdicionaEntradaLog("Próximo ID de histórico selecionado com sucesso [" & CStr(id_historico) & "]", enErrorType.Info)
                                Catch ex As Exception
                                    AdicionaEntradaLog("Erro ao tentar buscar próximo ID de histórico: " & ex.Message, enErrorType._Error)
                                End Try


                                dtoHSAL.AUDT_dt_inclusao = Now
                                dtoHSAL.AUDT_nm_usuario_inclusao = default_user
                                dtoHSAL.ALER_nm_alerta = nome_alerta
                                dtoHSAL.HSAL_ds_assunto_email = assunto
                                dtoHSAL.HSAL_ds_email = drOper("email")
                                dtoHSAL.HSAL_ds_mensagem = ""
                                dtoHSAL.HSAL_ds_texto_email = texto
                                dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                                dtoHSAL.HSAL_fl_status = "N"
                                dtoHSAL.PROC_cd_processo = "Vários"
                                dtoHSAL.HSAL_id_historico = id_historico


                                bllHSAL.ConnectionString = connection
                                bllHSAL.XMLPath = xmlpath

                                If bllHSAL.InsertData(dtoHSAL) Then
                                    AdicionaEntradaLog("Histórico de alertas gravado com sucesso para " & email_operador, enErrorType.Info)
                                Else
                                    AdicionaEntradaLog("Não foi possível gravar o histórico de alerta para " & email_operador, enErrorType._Error)
                                End If


                                Try

                                    AdicionaEntradaLog("Enviando email de alerta para " & drOper("email"), enErrorType.Info)


                                    mail.EnviaEmail(default_smtp, default_porta, _
                                                default_email, drOper("email"), _
                                                default_usuario, default_senha, _
                                                assunto, texto, Nothing, True, Nothing)

                                    AdicionaEntradaLog("Email de alerta enviado com sucesso para " & drOper("email"), enErrorType.Info)
                                    numEmailsOk += 1

                                    AdicionaEntradaLog("Atualizando histórico de alerta para pendente: " & drOper("email"), enErrorType.Info)
                                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                                    dtoHSAL.HSAL_ds_mensagem = ""
                                    dtoHSAL.HSAL_dt_envio = Now
                                    dtoHSAL.HSAL_fl_status = "S"
                                    dtoHSAL.HSAL_id_historico = id_historico
                                    If bllHSAL.UpdateData(dtoHSAL) Then
                                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente: " & drOper("email"), enErrorType.Info)
                                    Else
                                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente: " & drOper("email"), enErrorType._Error)
                                    End If

                                Catch ex As Exception

                                    numEmailsPendentes += 1
                                    AdicionaEntradaLog("Erro ao tentar enviar email de alerta para " & drOper("email"), enErrorType._Error)


                                    AdicionaEntradaLog("Atualizando histórico de alerta para pendente: " & drOper("email"), enErrorType.Info)
                                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                                    dtoHSAL.HSAL_ds_mensagem = ex.Message
                                    dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                                    dtoHSAL.HSAL_fl_status = "N"
                                    dtoHSAL.HSAL_id_historico = id_historico
                                    If bllHSAL.UpdateData(dtoHSAL) Then
                                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente: " & drOper("email"), enErrorType.Info)
                                    Else
                                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente: " & drOper("email"), enErrorType._Error)
                                    End If

                                End Try

                            End If

                        Next



                    Next




                End If

            End If


            AdicionaEntradaLog("Envio de alertas de processos de outras empresas realizado com sucesso", enErrorType.Info)

        Catch ex As Exception
            AdicionaEntradaLog("Erro ao tentar enviar alertas de processos de outras empresas: " & ex.Message, enErrorType._Error)
        End Try



    End Sub

    Public Sub EnviaEmailsPendentes()

        Dim dto As New DTO.tb_HSAL_historico_alerta
        Dim bll As New BLL.tb_HSAL_historico_alerta
        Dim dtoHSAL As DTO.tb_HSAL_historico_alerta
        Dim bllHSAL As New BLL.tb_HSAL_historico_alerta

        Dim dt As DataTable
        Dim mail As New Apoio.EmailGeral

        bllHSAL.ConnectionString = connection
        bllHSAL.XMLPath = xmlpath
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        Try


            AdicionaEntradaLog("Iniciando envio de emails pendentes", enErrorType.Info)

            'pega emails pendentes
            dto.HSAL_fl_status = "N"
            dt = bll.PagingData(dto)


            For Each dr As DataRow In dt.Rows

                If dr("ALER_nm_alerta").ToString.Trim = "DO" Then GoTo prox

                AdicionaEntradaLog("Enviando email pendente [" & dr("HSAL_ds_email") & "]", enErrorType.Info)

                Try


                    mail.EnviaEmail(default_smtp, _
                                                    default_porta, _
                                                    default_email, _
                                                    dr("HSAL_ds_email"), _
                                                    default_usuario, _
                                                    default_senha, _
                                                    dr("HSAL_ds_assunto_email"), _
                                                    dr("HSAL_ds_texto_email"), _
                                                    Nothing, True, Nothing)

                    AdicionaEntradaLog("Email pendente enviando com sucesso [" & dr("HSAL_ds_email") & "]", enErrorType.Info)


                    'se enviou email, grava histórico do alerta 
                    'como nao mais pendente

                    AdicionaEntradaLog("Atualizando histórico de alerta para não pendente: " & dr("HSAL_ds_email"), enErrorType.Info)

                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                    dtoHSAL.HSAL_ds_mensagem = ""
                    dtoHSAL.HSAL_dt_envio = Now
                    dtoHSAL.HSAL_fl_status = "S"
                    dtoHSAL.HSAL_id_historico = dr("HSAL_id_historico")

                    If bllHSAL.UpdateData(dtoHSAL) Then
                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para não pendente: " & dr("HSAL_ds_email"), enErrorType.Info)
                    Else
                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para não pendente: " & dr("HSAL_ds_email"), enErrorType._Error)
                    End If



                Catch ex As Exception

                    AdicionaEntradaLog("Erro ao tentar enviar email pendente [" & dr("HSAL_ds_email") & "]: " & ex.Message, enErrorType._Error)


                    'se nao enviou email, grava histórico do alerta 
                    'como  pendente

                    AdicionaEntradaLog("Atualizando histórico de alerta para pendente: " & dr("HSAL_ds_email"), enErrorType.Info)

                    dtoHSAL = New DTO.tb_HSAL_historico_alerta
                    dtoHSAL.HSAL_ds_mensagem = ex.Message
                    dtoHSAL.HSAL_dt_tentativa_ultimo_envio = Now
                    dtoHSAL.HSAL_fl_status = "N"
                    dtoHSAL.HSAL_id_historico = dr("HSAL_id_historico")

                    If bllHSAL.UpdateData(dtoHSAL) Then
                        AdicionaEntradaLog("Histórico de alerta atualizado com sucesso para pendente: " & dr("HSAL_ds_email"), enErrorType.Info)
                    Else
                        AdicionaEntradaLog("Não foi possível atualizar histórico de alerta para pendente: " & dr("HSAL_ds_email"), enErrorType._Error)
                    End If

                End Try



prox:
            Next

        Catch ex As Exception
            AdicionaEntradaLog("Erro ao tentar enviar emails pendentes: " & ex.Message, enErrorType.Info)
        End Try




    End Sub
    ' Private Sub kmlFileDownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs)
    ' RaiseEvent evDownloadProgress(e.ProgressPercentage)
    'End Sub
    Public Function DownloadArquivoDNPM(ByVal myDir As String, _
                                        ByVal url As String, _
                                        ByVal sendToDatatable As Boolean, _
                                        ByVal keepFile As Boolean, _
                                        ByRef myKMLFile As String) As Boolean

        Try


            Dim dtUF As DataTable
            Dim obj As New Apoio.Globalization

            Dim remoteUri As String = ""
            Dim fileName As String = ""
            Dim myStringWebResource As String = Nothing
            Dim myWebClient As New WebClient()
            Dim kmlFile As String = ""

            'AddHandler myWebClient.DownloadProgressChanged, AddressOf kmlFileDownloadProgressChanged

            dtUF = obj.getListData(xmlpath, "uf")

            'zera base local
            baseLocal = Nothing

            For Each dr As DataRow In dtUF.Rows

                If dr("name") <> "00" Then

                    remoteUri = String.Format(url, dr("name"))
                    fileName = dr("name") & ".kmz"

                    'xxx 
                    'como ja tenho o arquivo vou retirar esse trecho,
                    'pro desenvolvimento ir mais rapido
                    Try
                        AdicionaEntradaLog("Baixando arquivo KMZ em " & remoteUri, enErrorType.Info)
                        myWebClient.DownloadFile(remoteUri, myDir & "\" & fileName)
                        AdicionaEntradaLog("Arquivo KMZ baixado com sucesso " & remoteUri, enErrorType.Info)
                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar fazer download do arquivo " & fileName & ": " & ex.Message, enErrorType._Error)
                    End Try

                    'converte arquivo kmz em kml e joga para datatable
                    Try

                        Dim zipfile As Ionic.Zip.ZipFile = zipfile.Read(myDir & "\" & fileName)
                        kmlFile = Replace(fileName, ".kmz", ".kml")

                        AdicionaEntradaLog("Extraindo arquivo KML do arquivo " & fileName, enErrorType.Info)
                        zipfile.ExtractSelectedEntries("name = *.kml", "", myDir, ExtractExistingFileAction.OverwriteSilently)
                        zipfile.Dispose()
                        AdicionaEntradaLog("Arquivo " & fileName & " extraído com sucesso", enErrorType.Info)

                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar extrair arquivo kml do arquivo kmz: " & ex.Message, enErrorType._Error)
                    End Try


                    'renomeia arquivo kml (doc.kml) extraído para UF.kml
                    Try
                        AdicionaEntradaLog("Renomeando arquivo doc.kml para " & kmlFile, enErrorType.Info)
                        If System.IO.File.Exists(myDir & "\" & kmlFile) Then System.IO.File.Delete(myDir & "\" & kmlFile)
                        FileSystem.Rename(myDir & "\doc.kml", myDir & "\" & kmlFile)
                        AdicionaEntradaLog("Arquivo renomeado para " & kmlFile, enErrorType.Info)
                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar renomear arquivo: " & ex.Message, enErrorType._Error)
                    End Try

                    'xxx - tirando exclusao temporariamente
                    'exclui arquivo kmz baixado
                    Try
                        AdicionaEntradaLog("Excluindo arquivo KMZ: " & fileName, enErrorType.Info)
                        System.IO.File.Delete(myDir & "\" & fileName)
                        AdicionaEntradaLog("Arquivo KMZ excluído", enErrorType.Info)
                    Catch ex As Exception
                        AdicionaEntradaLog("Erro ao tentar excluir arquivo KMZ: " & ex.Message, enErrorType._Error)
                    End Try

                    If sendToDatatable Then
                        baseLocal = KMLToDatatable(myDir & "\" & kmlFile)
                    End If


                    If Not keepFile Then
                        'excluindo arquivo kml
                        Try
                            AdicionaEntradaLog("Excluindo arquivo KML: " & kmlFile, enErrorType.Info)
                            System.IO.File.Delete(myDir & "\" & kmlFile)
                            AdicionaEntradaLog("Arquivo KML excluído", enErrorType.Info)
                        Catch ex As Exception
                            AdicionaEntradaLog("Erro ao tentar excluir arquivo KML: " & ex.Message, enErrorType._Error)
                        End Try
                    End If




                End If

            Next


            myKMLFile = myDir & "\" & kmlFile

            Return True


        Catch ex As Exception
            myKMLFile = ""
            AdicionaEntradaLog("Erro em DownloadArquivoDNPM: " & ex.Message, enErrorType._Error)
            Return False
        End Try

    End Function
    Public Function KMLToDatatable(ByVal kmlFile As String, Optional ByVal excludeLines As Boolean = False) As DataTable
        Dim base As DataTable

        'transferindo arquivo kml para datatable
        Try
            AdicionaEntradaLog("Transferindo dados do arquivo KML para a base local", enErrorType.Info)

            Dim ds As New DataSet
            ds.ReadXml(kmlFile)

            'como estou deixando preparado pra mais de uma UF,
            'então precisa fazer o append de linhas na base local
            If base Is Nothing Then
                base = ds.Tables(default_tablename).Copy
            Else
                base.Merge(ds.Tables(default_tablename))
            End If

            If excludeLines Then
                For Each dr As DataRow In base.Rows
                    If dr("description") IsNot DBNull.Value Then
                        dr("description") = Replace(Replace(dr("description"), vbCrLf, ""), Chr(13), "")
                    End If
                Next
            End If

            AdicionaEntradaLog("Dados armazenados na base local", enErrorType.Info)

            Return base

        Catch ex As Exception
            AdicionaEntradaLog("Erro ao tentar transferir dados do arquivo KML para a base local: " & ex.Message, enErrorType._Error)
            Return Nothing
        End Try


    End Function
    Private Sub AdicionaEntradaLog(ByVal Mensagem As String, ByVal Tipo As enErrorType)
        RaiseEvent evAdicionaEntradaLog(Mensagem, Tipo)
    End Sub
    Private Sub AtualizaEntradaLog(ByVal Mensagem As String)
        RaiseEvent evAtualizaEntradaLog(Mensagem)
    End Sub
    Private Function pega_id_historico() As Integer
        Dim dto As New DTO.tb_HSAL_historico_alerta
        Dim bll As New BLL.tb_HSAL_historico_alerta
        bll.ConnectionString = connection
        bll.XMLPath = xmlpath
        Return bll.GetNextIndex(dto)
    End Function
    Private Function gravaProcessoTabelaAuxiliar(ByVal processo As String, ByVal uf As String, ByVal titular As String, _
                                                 ByVal fase As String, ByVal evento As String, _
                                                 ByVal dtAux As DataTable) As Boolean

        Dim dto As New DTO.tb_PAUX_processo_auxiliar
        Dim bll As New BLL.tb_PAUX_processo_auxiliar
        Dim message As String = ""
        Dim ret As Boolean = False
        Dim dt As DataTable

        bll.ConnectionString = connection
        bll.XMLPath = xmlpath

        Try

            If dtAux.Select("PAUX_cd_processo = '" & processo & "'").Length > 0 Then
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
                dto.FASE_cd_fase = fase
                dto.PAUX_cd_processo = processo
                dto.PAUX_ds_titular = titular
                dto.PAUX_ds_ultimo_evento = evento
                dto.UNFE_cd_unidade_federativa = uf
                ret = bll.UpdateData(dto)
            Else
                dto.AUDT_dt_alteracao = Now
                dto.AUDT_dt_inclusao = Now
                dto.AUDT_nm_usuario_alteracao = default_user
                dto.AUDT_nm_usuario_inclusao = default_user
                dto.FASE_cd_fase = fase
                dto.PAUX_cd_processo = processo
                dto.PAUX_ds_titular = titular
                dto.PAUX_ds_ultimo_evento = evento
                dto.UNFE_cd_unidade_federativa = uf
                ret = bll.InsertData(dto)
            End If




        Catch ex As Exception
            'nao trata erro
        End Try

    End Function
    Private Function pega_codigo_fase(ByVal dt As DataTable, ByVal descricao As String) As String

        If dt.Rows.Count > 0 Then

            If dt.Select("value like '%" & descricao & "%'").Length > 0 Then
                Return dt.Select("value like '%" & descricao & "%'")(0)("name")
            Else
                Return "0"
            End If

        Else
            Return "0"
        End If


    End Function


End Class
