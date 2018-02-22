Public Class tb_HSAL_historico_alerta
    Private _connectionString As String = ""

    Private _xmlPath As String = ""
    Private base As New Apoio.Base
    
    Public Enum ValidationReturnType
        BlockAction = 0
        AskConfirmation = 1
    End Enum
    
    Public Enum Mode
        Insert = 1
        Update = 2
    End Enum
    
    Public Property ConnectionString() As String
        Get
            Return _connectionString
        End Get
        Set(ByVal value As String)
            _connectionString = value
        End Set
    End Property
    
    Public Property XMLPath() As String
        Get
            Return _xmlPath
        End Get
        Set(ByVal value As String)
            _xmlPath = value
        End Set
    End Property
    Public Function GetNextIndex(ByVal dto As DTO.tb_HSAL_historico_alerta) As Long

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dt As DataTable
        Dim dr() As DataRow
        Dim filter As String = ""
        Dim sorter As String = ""
        Dim field As String = "HSAL_id_historico"
        Dim dal As New DAL.tb_HSAL_historico_alerta(ConnectionString, dto)

        dt = dal.GetData()
        sorter = field & " DESC"

        dr = dt.Select(filter, sorter)

        If dr.Length > 0 Then
            Return dr(0)(field) + 1
        Else
            Return 1
        End If

    End Function

    Public Function InsertData(ByVal dto As DTO.tb_HSAL_historico_alerta) As Boolean

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_HSAL_historico_alerta(ConnectionString, dto)
        Return dal.InsertData() > 0

    End Function
    Public Function UpdateData(ByVal dto As DTO.tb_HSAL_historico_alerta) As String

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_HSAL_historico_alerta(ConnectionString, dto)
        Return dal.UpdateData() > 0

    End Function
    Public Function DeleteData(ByVal dto As DTO.tb_HSAL_historico_alerta) As String

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_HSAL_historico_alerta(ConnectionString, dto)
        Return dal.DeleteData() > 0

    End Function
    Public Function GetData(ByVal dto As DTO.tb_HSAL_historico_alerta) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_HSAL_historico_alerta(ConnectionString, dto)
        Return dal.GetData()

    End Function

    Public Function ConsultData(ByVal dto As DTO.tb_HSAL_historico_alerta) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_HSAL_historico_alerta(ConnectionString, dto)
        Return dal.ConsultData

    End Function

    Public Function PagingData(ByVal dto As DTO.tb_HSAL_historico_alerta) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_HSAL_historico_alerta(ConnectionString, dto)
        Return dal.PagingData

    End Function


    Public Function Validate(ByVal dto As DTO.tb_HSAL_historico_alerta, _
                             ByRef message As String, _
                             ByRef action As ValidationReturnType, _
                             ByVal mode As Mode, _
                             ByVal forceInvalidation As Boolean, _
                             ByVal addFieldNameToMessage As Boolean) As Boolean


        Dim log As String = ""
        Dim obj As New Apoio.Validation
        Dim fields As New Apoio.Globalization
        Dim ret As String = ""

        If _xmlPath.Trim.Length = 0 Then
            Throw New Exception("Caminho do Arquivo XML de idioma nao foi informado")
        End If

        obj.xmlPath = _xmlPath

        Dim dt As DataTable = fields.getFormData(_xmlPath, "HSAL")

        ret = obj.ValidateNumeric(fields.getValue(dt, "HSAL_id_historico"), dto.HSAL_id_historico, Apoio.Validation.numericType._integer, False, base._intPadrao, base._intPadrao, True, getAllowedValues("HSAL_id_historico"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        If mode = tb_HSAL_historico_alerta.Mode.Insert Then

            ret = obj.ValidateString(fields.getValue(dt, "HSAL_ds_email"), dto.HSAL_ds_email, False, base._strPadrao, 200, True, getAllowedValues("HSAL_ds_email"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "ALER_nm_alerta"), dto.ALER_nm_alerta, False, base._strPadrao, 50, True, getAllowedValues("ALER_nm_alerta"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "PROC_cd_processo"), dto.PROC_cd_processo, False, base._strPadrao, 50, True, getAllowedValues("PROC_cd_processo"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "HSAL_ds_assunto_email"), dto.HSAL_ds_assunto_email, False, base._strPadrao, 200, True, getAllowedValues("HSAL_ds_assunto_email"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "HSAL_ds_texto_email"), dto.HSAL_ds_texto_email, False, base._strPadrao, 8000, True, getAllowedValues("HSAL_ds_texto_email"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateDate(fields.getValue(dt, "HSAL_dt_tentativa_ultimo_envio"), dto.HSAL_dt_tentativa_ultimo_envio, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, False, forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateDate(fields.getValue(dt, "AUDT_dt_inclusao"), dto.AUDT_dt_inclusao, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True, forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "AUDT_nm_usuario_inclusao"), dto.AUDT_nm_usuario_inclusao, False, base._strPadrao, 20, True, getAllowedValues("AUDT_nm_usuario_inclusao"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret


        End If

        ret = obj.ValidateDate(fields.getValue(dt, "HSAL_dt_envio"), dto.HSAL_dt_envio, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, False, forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

       
        ret = obj.ValidateString(fields.getValue(dt, "HSAL_ds_mensagem"), dto.HSAL_ds_mensagem, False, base._strPadrao, 8000, False, getAllowedValues("HSAL_ds_mensagem"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "HSAL_fl_status"), dto.HSAL_fl_status, False, base._strPadrao, 3, True, getAllowedValues("HSAL_fl_status"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        'ret = customValidation(dto)
        'If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret




        message = log
        action = ValidationReturnType.BlockAction
        Return message.Trim.Length = 0

    End Function
    Public Function customValidation(ByVal dto As DTO.tb_HSAL_historico_alerta) As String
        Dim ret As String = ""
        Dim val As New Apoio.Validation
        Dim obj As New Apoio.Globalization
        Dim dt As DataTable = obj.getData(_xmlPath, "validate")
        Dim dtFields As DataTable = obj.getFormData(_xmlPath, "HSAL")


fim:
        Return ret
    End Function
    Public Function SaveData(ByVal dto As DTO.tb_HSAL_historico_alerta, _
                             ByRef message As String, _
                             ByRef action As ValidationReturnType, _
                             ByVal mode As Mode, _
                             Optional ByVal isValidated As Boolean = False) As Boolean

        Dim boolValidate As Boolean = False
      
        If Not isValidated Then
            boolValidate = Validate(dto, message, action, mode, False, True)
        Else
            boolValidate = True
        End If


        If boolValidate Then

            Try
                Select Case mode
                    Case tb_HSAL_historico_alerta.Mode.Insert
                        Return InsertData(dto)
                    Case tb_HSAL_historico_alerta.Mode.Update
                        Return UpdateData(dto)
                End Select
            Catch ex As Exception
                Throw base.TreatDuplicatedDataException(_xmlPath, ex)
            End Try

        Else
            Return False
        End If

        Return False
    End Function
    
    Private Function getAllowedValues(field as String) as String
     dim values as String=""
     dim delimallowed as String = "|"
     
     'select case field
      'Case HSAL_id_historico
 'values = ""

'Case HSAL_ds_email
 'values = ""

'Case ALER_nm_alerta
 'values = ""

'Case PROC_cd_processo
 'values = ""

'Case HSAL_ds_assunto_email
 'values = ""

'Case HSAL_ds_texto_email
 'values = ""

'Case HSAL_dt_envio
 'values = ""

'Case HSAL_dt_tentativa_ultimo_envio
 'values = ""

'Case HSAL_ds_mensagem
 'values = ""

'Case HSAL_fl_status
 'values = ""

'Case AUDT_dt_inclusao
 'values = ""

'Case AUDT_nm_usuario_inclusao
 'values = ""


     'end select
      
     return values
    End Function
   
End Class
