Public Class tb_PASO_processo_associado
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


    Public Function InsertData(ByVal dto As DTO.tb_PASO_processo_associado) As Boolean

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PASO_processo_associado(ConnectionString, dto)
        Return dal.InsertData() > 0

    End Function
    Public Function UpdateData(ByVal dto As DTO.tb_PASO_processo_associado) As String

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PASO_processo_associado(ConnectionString, dto)
        Return dal.UpdateData() > 0

    End Function
    Public Function DeleteData(ByVal dto As DTO.tb_PASO_processo_associado) As String

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PASO_processo_associado(ConnectionString, dto)
        Return dal.DeleteData() > 0

    End Function
    Public Function GetData(ByVal dto As DTO.tb_PASO_processo_associado) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PASO_processo_associado(ConnectionString, dto)
        Return dal.GetData()

    End Function

    Public Function ConsultData(ByVal dto As DTO.tb_PASO_processo_associado) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PASO_processo_associado(ConnectionString, dto)
        Return dal.ConsultData

    End Function

    Public Function PagingData(ByVal dto As DTO.tb_PASO_processo_associado) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PASO_processo_associado(ConnectionString, dto)
        Return dal.PagingData

    End Function


    Public Function Validate(ByVal dto As DTO.tb_PASO_processo_associado, _
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

        Dim dt As DataTable = fields.getFormData(_xmlPath, "PASO")

        ret = obj.ValidateString(fields.getValue(dt, "PROC_cd_processo"), dto.PROC_cd_processo, False, base._strPadrao, 50, True, getAllowedValues("PROC_cd_processo"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PASO_cd_processo"), dto.PASO_cd_processo, False, base._strPadrao, 50, True, getAllowedValues("PASO_cd_processo"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        If mode = tb_PASO_processo_associado.Mode.Insert Then
            ret = obj.ValidateDate(fields.getValue(dt, "AUDT_dt_inclusao"), dto.AUDT_dt_inclusao, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True, forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "AUDT_nm_usuario_inclusao"), dto.AUDT_nm_usuario_inclusao, False, base._strPadrao, 20, True, getAllowedValues("AUDT_nm_usuario_inclusao"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret
        End If

        ret = obj.ValidateDate(fields.getValue(dt, "AUDT_dt_alteracao"), dto.AUDT_dt_alteracao, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True, forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "AUDT_nm_usuario_alteracao"), dto.AUDT_nm_usuario_alteracao, False, base._strPadrao, 20, True, getAllowedValues("AUDT_nm_usuario_alteracao"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        'ret = customValidation(dto)
        'If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret




        message = log
        action = ValidationReturnType.BlockAction
        Return message.Trim.Length = 0

    End Function
    Public Function customValidation(ByVal dto As DTO.tb_PASO_processo_associado) As String
        Dim ret As String = ""
        Dim val As New Apoio.Validation
        Dim obj As New Apoio.Globalization
        Dim dt As DataTable = obj.getData(_xmlPath, "customvalidate")
        'Dim dtFields As DataTable = obj.getFormData(_xmlPath, "ALER")





fim:
        Return ret
    End Function
    Public Function SaveData(ByVal dto As DTO.tb_PASO_processo_associado, _
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
                    Case tb_PASO_processo_associado.Mode.Insert
                        Return InsertData(dto)
                    Case tb_PASO_processo_associado.Mode.Update
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
      'Case PROC_cd_processo
 'values = ""

'Case PASO_cd_processo
 'values = ""

'Case AUDT_dt_inclusao
 'values = ""

'Case AUDT_nm_usuario_inclusao
 'values = ""

'Case AUDT_dt_alteracao
 'values = ""

'Case AUDT_nm_usuario_alteracao
 'values = ""


     'end select
      
     return values
    End Function
   
End Class
