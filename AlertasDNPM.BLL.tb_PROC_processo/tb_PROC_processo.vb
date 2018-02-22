Public Class tb_PROC_processo
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
    Public Function getExpirateDocuments(ByVal dto As DTO.tb_PROC_processo) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.getExpirateDocuments()


    End Function
    Public Function getEventos(ByVal dto As DTO.tb_PROC_processo) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.getEventos()


    End Function
    Public Function getDocuments(ByVal dto As DTO.tb_PROC_processo) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.getDocuments()


    End Function
    Public Function getRelatorioLista(ByVal dto As DTO.tb_PROC_processo) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.getRelatorioLista()


    End Function
    Public Function InsertData(ByVal dto As DTO.tb_PROC_processo) As Boolean

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.InsertData() > 0

    End Function
    Public Function UpdateData(ByVal dto As DTO.tb_PROC_processo) As String

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.UpdateData() > 0

    End Function
    Public Function DeleteData(ByVal dto As DTO.tb_PROC_processo) As String

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.DeleteData() > 0

    End Function
    Public Function GetData(ByVal dto As DTO.tb_PROC_processo) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.GetData()

    End Function

    Public Function ConsultData(ByVal dto As DTO.tb_PROC_processo) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.ConsultData

    End Function

    Public Function PagingData(ByVal dto As DTO.tb_PROC_processo) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PROC_processo(ConnectionString, dto)
        Return dal.PagingData

    End Function


    Public Function Validate(ByVal dto As DTO.tb_PROC_processo, _
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

        Dim dt As DataTable = fields.getFormData(_xmlPath, "PROC")

        ret = obj.ValidateString(fields.getValue(dt, "PROC_cd_processo"), dto.PROC_cd_processo, True, 5, 50, True, getAllowedValues("PROC_cd_processo"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PROC_ds_titular"), dto.PROC_ds_titular, True, 5, 300, True, getAllowedValues("PROC_ds_titular"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateNumeric(fields.getValue(dt, "PROC_vl_ano"), dto.PROC_vl_ano, Apoio.Validation.numericType._integer, True, 1800, base._intPadrao, False, getAllowedValues("PROC_vl_ano"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PROC_nm_processo"), dto.PROC_nm_processo, False, base._strPadrao, 50, False, getAllowedValues("PROC_nm_processo"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PROC_id_processo"), dto.PROC_id_processo, False, base._strPadrao, 300, False, getAllowedValues("PROC_id_processo"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateNumeric(fields.getValue(dt, "FASE_cd_fase"), dto.FASE_cd_fase, Apoio.Validation.numericType._integer, False, base._intPadrao, base._intPadrao, False, getAllowedValues("FASE_cd_fase"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PROC_cd_prioridade"), dto.PROC_cd_prioridade, False, base._intPadrao, base._intPadrao, True, getAllowedValues("PROC_cd_prioridade"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret


        ret = obj.ValidateString(fields.getValue(dt, "PROC_ds_ultimo_evento"), dto.PROC_ds_ultimo_evento, False, base._strPadrao, 3000, False, getAllowedValues("PROC_ds_ultimo_evento"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PROC_ds_substancia"), dto.PROC_ds_substancia, False, base._strPadrao, 100, False, getAllowedValues("PROC_ds_substancia"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PROC_ds_area"), dto.PROC_ds_area, False, base._strPadrao, 30, False, getAllowedValues("PROC_ds_area"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PROC_ds_uso"), dto.PROC_ds_uso, False, base._strPadrao, 200, False, getAllowedValues("PROC_ds_uso"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "PROC_ds_link"), dto.PROC_ds_link, False, base._strPadrao, 150, False, getAllowedValues("PROC_ds_link"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "UNFE_cd_unidade_federativa"), dto.UNFE_cd_unidade_federativa, False, base._strPadrao, 2, False, getAllowedValues("UNFE_cd_unidade_federativa"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

      

        If mode = tb_PROC_processo.Mode.Insert Then
            ret = obj.ValidateString(fields.getValue(dt, "PROC_fl_tipo_inclusao"), dto.PROC_fl_tipo_inclusao, False, base._strPadrao, 1, True, getAllowedValues("PROC_fl_tipo_inclusao"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateDate(fields.getValue(dt, "AUDT_dt_inclusao"), dto.AUDT_dt_inclusao, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True, forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "AUDT_nm_usuario_inclusao"), dto.AUDT_nm_usuario_inclusao, False, base._strPadrao, 20, True, getAllowedValues("AUDT_nm_usuario_inclusao"), forceInvalidation, addFieldNameToMessage)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret
        End If

        ret = obj.ValidateDate(fields.getValue(dt, "AUDT_dt_alteracao"), dto.AUDT_dt_alteracao, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True, forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "AUDT_nm_usuario_alteracao"), dto.AUDT_nm_usuario_alteracao, False, base._strPadrao, 20, True, getAllowedValues("AUDT_nm_usuario_alteracao"), forceInvalidation, addFieldNameToMessage)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = customValidation(dto)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret



        message = log
        action = ValidationReturnType.BlockAction
        Return message.Trim.Length = 0

    End Function
    Private Function CustomValidation(ByVal dto As DTO.tb_PROC_processo) As String
        Dim obj As New Apoio.Globalization
        Dim val As New Apoio.Validation
        Dim dtFields As DataTable = obj.getFormData(_xmlPath, "PROC")
        Dim dt As DataTable = obj.getData(_xmlPath, "validate")
        Dim ret As String = ""
        Dim size As Integer = 4


        If base.AjustaNulo(dto.PROC_ds_link).Length > 0 Then
            If Not val.is_valid_url(dto.PROC_ds_link) Then
                ret = obj.getValue(dtFields, "PROC_ds_link") & ": " & obj.getValue(dt, "format")
                GoTo fim
            End If
        End If

        If dto.PROC_vl_ano.ToString.Trim.Length > 0 Then
            If dto.PROC_vl_ano.ToString.Trim.Length <> size Then
                ret = obj.getValue(dtFields, "PROC_vl_ano") & ": " & String.Format(obj.getValue(dt, "len"), size)
                GoTo fim
            End If
        End If

        ret = ValidaNumeroProcesso(dto.PROC_cd_processo)


fim:
        Return ret

    End Function
    Public Function ValidaNumeroProcesso(ByVal numero As String) As String

        Dim obj As New Apoio.Globalization
        Dim val As New Apoio.Validation
        Dim dtFields As DataTable = obj.getFormData(_xmlPath, "PROC")
        Dim dt As DataTable = obj.getData(_xmlPath, "validate")
        Dim dtCustom As DataTable = obj.getData(_xmlPath, "customvalidate")
        Dim ret As String = ""

        'formato do processo deve ser xxxx.../xxxx
        If numero.ToString.Trim.Length > 0 Then
            If Not numero.ToString.Trim.Contains("/") Then
                ret = obj.getValue(dtFields, "PROC_cd_processo") & ": " & obj.getValue(dt, "format")

            Else
                Dim vetor() As String = Split(numero.ToString.Trim, "/")
                If vetor.Length < 2 Then
                    ret = String.Format(obj.getValue(dt, "spec_format"), obj.getValue(dtCustom, "num_processo1"))

                Else
                    If Not IsNumeric(vetor(1).Trim) Then
                        ret = String.Format(obj.getValue(dt, "spec_format"), obj.getValue(dtCustom, "num_processo2"))

                    Else
                        If vetor(1).Trim.Length <> 4 Then
                            ret = String.Format(obj.getValue(dt, "spec_format"), obj.getValue(dtCustom, "num_processo2"))

                        End If
                    End If
                End If
            End If

        End If

        Return ret

    End Function
    Public Function SaveData(ByVal dto As DTO.tb_PROC_processo, _
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
                    Case tb_PROC_processo.Mode.Insert
                        Return InsertData(dto)
                    Case tb_PROC_processo.Mode.Update
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

'Case PROC_ds_titular
 'values = ""

'Case PROC_vl_ano
 'values = ""

'Case PROC_nm_processo
 'values = ""

'Case PROC_id_processo
 'values = ""

'Case FASE_cd_fase
 'values = ""

'Case PROC_ds_ultimo_evento
 'values = ""

'Case PROC_ds_substancia
 'values = ""

'Case PROC_ds_area
 'values = ""

'Case PROC_ds_uso
 'values = ""

'Case PROC_ds_link
 'values = ""

'Case UNFE_cd_unidade_federativa
 'values = ""

'Case PROC_fl_tipo_inclusao
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
