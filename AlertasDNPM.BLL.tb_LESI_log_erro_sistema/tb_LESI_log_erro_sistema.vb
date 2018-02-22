Public Class tb_LESI_log_erro_sistema
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


    Public Function InsertData(ByVal dto As DTO.tb_LESI_log_erro_sistema) As Boolean

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_LESI_log_erro_sistema(ConnectionString, dto)
        Return dal.InsertData() > 0

    End Function
    Public Function UpdateData(ByVal dto As DTO.tb_LESI_log_erro_sistema) As String

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_LESI_log_erro_sistema(ConnectionString, dto)
        Return dal.UpdateData() > 0

    End Function
    Public Function DeleteData(ByVal dto As DTO.tb_LESI_log_erro_sistema) As String

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_LESI_log_erro_sistema(ConnectionString, dto)
        Return dal.DeleteData() > 0

    End Function
    Public Function GetData(ByVal dto As DTO.tb_LESI_log_erro_sistema) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_LESI_log_erro_sistema(ConnectionString, dto)
        Return dal.GetData()

    End Function

    Public Function ConsultData(ByVal dto As DTO.tb_LESI_log_erro_sistema) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_LESI_log_erro_sistema(ConnectionString, dto)
        Return dal.ConsultData

    End Function

    Public Function PagingData(ByVal dto As DTO.tb_LESI_log_erro_sistema) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_LESI_log_erro_sistema(ConnectionString, dto)
        Return dal.PagingData

    End Function


    Public Function Validate(ByVal dto As DTO.tb_LESI_log_erro_sistema, _
                             ByRef message As String, _
                             ByRef action As ValidationReturnType, _
                             ByVal mode As Mode) As Boolean


        Dim log As String = ""
        Dim obj As New Apoio.Validation
        Dim fields As New Apoio.Globalization
        Dim ret As String = ""

        If _xmlPath.Trim.Length = 0 Then
            Throw New Exception("Caminho do Arquivo XML de idioma nao foi informado")
        End If

        obj.xmlPath = _xmlPath

        Dim dt As DataTable = fields.getFormData(_xmlPath, "LESI")

        ret = obj.ValidateNumeric(fields.getValue(dt, "LESI_cd_ocorrencia"), dto.LESI_cd_ocorrencia, Apoio.Validation.numericType._integer, False, base._intPadrao, base._intPadrao, False, getAllowedValues("LESI_cd_ocorrencia"))
If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

ret = obj.ValidateString(fields.getValue(dt, "LESI_nm_source"), dto.LESI_nm_source, False, base._strPadrao, 100, True, getAllowedValues("LESI_nm_source"))
If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

ret = obj.ValidateString(fields.getValue(dt, "LESI_ds_exception"), dto.LESI_ds_exception, False, base._strPadrao, 8000, False, getAllowedValues("LESI_ds_exception"))
If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

ret = obj.ValidateString(fields.getValue(dt, "LESI_ds_inexception"), dto.LESI_ds_inexception, False, base._strPadrao, 8000, False, getAllowedValues("LESI_ds_inexception"))
If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

ret = obj.ValidateDate(fields.getValue(dt, "LESI_dt_ocorrencia"), dto.LESI_dt_ocorrencia, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True)
If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

ret = obj.ValidateDate(fields.getValue(dt, "AUDT_dt_inclusao"), dto.AUDT_dt_inclusao, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True)
If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

ret = obj.ValidateString(fields.getValue(dt, "AUDT_nm_usuario_inclusao"), dto.AUDT_nm_usuario_inclusao, False, base._strPadrao, 20, True, getAllowedValues("AUDT_nm_usuario_inclusao"))
If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret




        message = log
        action = ValidationReturnType.BlockAction
        Return message.Trim.Length = 0

    End Function

    Public Function SaveData(ByVal dto As DTO.tb_LESI_log_erro_sistema, _
                             ByRef message As String, _
                             ByRef action As ValidationReturnType, _
                             ByVal mode As Mode, _
                             Optional ByVal isValidated As Boolean = False) As Boolean

        Dim boolValidate As Boolean = False
      
        If Not isValidated Then
            boolValidate = Validate(dto, message, action, mode)
        Else
            boolValidate = True
        End If


        If boolValidate Then

            Select Case mode
                Case tb_LESI_log_erro_sistema.Mode.Insert
                    Return InsertData(dto)
                Case tb_LESI_log_erro_sistema.Mode.Update
                    Return UpdateData(dto)
            End Select

        Else
            Return False
        End If

        Return False
    End Function
    
    Private Function getAllowedValues(field as String) as String
     dim values as String=""
     dim delimallowed as String = "|"
     
     'select case field
      'Case LESI_cd_ocorrencia
 'values = ""

'Case LESI_nm_source
 'values = ""

'Case LESI_ds_exception
 'values = ""

'Case LESI_ds_inexception
 'values = ""

'Case LESI_dt_ocorrencia
 'values = ""

'Case AUDT_dt_inclusao
 'values = ""

'Case AUDT_nm_usuario_inclusao
 'values = ""


     'end select
      
     return values
    End Function
   
End Class
