Public Class tb_PGER_parametro_geral
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


    Public Function InsertData(ByVal dto As DTO.tb_PGER_parametro_geral) As Boolean

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PGER_parametro_geral(ConnectionString, dto)
        Return dal.InsertData() > 0

    End Function
    Public Function UpdateData(ByVal dto As DTO.tb_PGER_parametro_geral) As String

        If _connectionString.Trim.Length = 0 Then
           Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PGER_parametro_geral(ConnectionString, dto)
        Return dal.UpdateData() > 0

    End Function
    Public Function DeleteData(ByVal dto As DTO.tb_PGER_parametro_geral) As String

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PGER_parametro_geral(ConnectionString, dto)
        Return dal.DeleteData() > 0

    End Function
    Public Function GetData(ByVal dto As DTO.tb_PGER_parametro_geral) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PGER_parametro_geral(ConnectionString, dto)
        Return dal.GetData()

    End Function

    Public Function ConsultData(ByVal dto As DTO.tb_PGER_parametro_geral) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PGER_parametro_geral(ConnectionString, dto)
        Return dal.ConsultData

    End Function

    Public Function PagingData(ByVal dto As DTO.tb_PGER_parametro_geral) As DataTable

        If _connectionString.Trim.Length = 0 Then
            Throw New Exception("String de Conexao com Banco de Dados nao foi informada")
        End If

        Dim dal As New DAL.tb_PGER_parametro_geral(ConnectionString, dto)
        Return dal.PagingData

    End Function


    Public Function Validate(ByVal dto As DTO.tb_PGER_parametro_geral, _
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

        Dim dt As DataTable = fields.getFormData(_xmlPath, "PGER")

        ret = obj.ValidateString(fields.getValue(dt, "PGER_cd_parametro"), dto.PGER_cd_parametro, False, base._strPadrao, 10, True, getAllowedValues("PGER_cd_parametro"))
If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        If mode = tb_PGER_parametro_geral.Mode.Insert Then
            ret = obj.ValidateString(fields.getValue(dt, "PGER_ds_parametro"), dto.PGER_ds_parametro, False, base._strPadrao, 100, True, getAllowedValues("PGER_ds_parametro"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "PGER_vl_parametro"), dto.PGER_vl_parametro, False, base._strPadrao, 1000, True, getAllowedValues("PGER_vl_parametro"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "PGER_fl_tipo"), dto.PGER_fl_tipo, False, base._strPadrao, 1, True, getAllowedValues("PGER_fl_tipo"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "PGER_fl_sistema"), dto.PGER_fl_sistema, False, base._strPadrao, 1, True, getAllowedValues("PGER_fl_sistema"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateNumeric(fields.getValue(dt, "PGER_vl_range_min"), dto.PGER_vl_range_min, Apoio.Validation.numericType._integer, False, base._intPadrao, base._intPadrao, False, getAllowedValues("PGER_vl_range_min"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateNumeric(fields.getValue(dt, "PGER_vl_range_max"), dto.PGER_vl_range_max, Apoio.Validation.numericType._integer, False, base._intPadrao, base._intPadrao, False, getAllowedValues("PGER_vl_range_max"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "PGER_vl_padrao"), dto.PGER_vl_padrao, False, base._strPadrao, 1000, True, getAllowedValues("PGER_vl_padrao"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateNumeric(fields.getValue(dt, "PGER_vl_tamanho_min"), dto.PGER_vl_tamanho_min, Apoio.Validation.numericType._integer, False, base._intPadrao, base._intPadrao, False, getAllowedValues("PGER_vl_tamanho_min"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateNumeric(fields.getValue(dt, "PGER_vl_tamanho_max"), dto.PGER_vl_tamanho_max, Apoio.Validation.numericType._integer, False, base._intPadrao, base._intPadrao, False, getAllowedValues("PGER_vl_tamanho_max"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "PGER_vl_valores_permitidos"), dto.PGER_vl_valores_permitidos, False, base._strPadrao, 8000, False, getAllowedValues("PGER_vl_valores_permitidos"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateDate(fields.getValue(dt, "AUDT_dt_inclusao"), dto.AUDT_dt_inclusao, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True)
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

            ret = obj.ValidateString(fields.getValue(dt, "AUDT_nm_usuario_inclusao"), dto.AUDT_nm_usuario_inclusao, False, base._strPadrao, 20, True, getAllowedValues("AUDT_nm_usuario_inclusao"))
            If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret
        End If

        ret = obj.ValidateDate(fields.getValue(dt, "AUDT_dt_alteracao"), dto.AUDT_dt_alteracao, Apoio.Validation.dateType._datetime, False, base._datPadrao, base._datPadrao, True)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        ret = obj.ValidateString(fields.getValue(dt, "AUDT_nm_usuario_alteracao"), dto.AUDT_nm_usuario_alteracao, False, base._strPadrao, 20, True, getAllowedValues("AUDT_nm_usuario_alteracao"))
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret


        ret = CustomValidation(dto)
        If ret.Trim.Length > 0 Then log = log & IIf(log.Trim.Length > 0, base._chrPulaLinhaGen, "") & ret

        message = log
        action = ValidationReturnType.BlockAction
        Return message.Trim.Length = 0

    End Function
    Private Function CustomValidation(ByVal dto As DTO.tb_PGER_parametro_geral) As String
        Dim obj As New Apoio.Globalization
        Dim val As New Apoio.Validation

        Dim dt As DataTable = obj.getData(_xmlPath, "validate")
        Dim ret As String = ""

        Select Case dto.PGER_cd_parametro
            Case "INTERVALO"
                If Not IsNumeric(dto.PGER_vl_parametro) Then
                    ret = obj.getValue(dt, "num")
                    GoTo fim
                End If

                Dim minval As Integer = 1
                Dim maxval As Integer = 99
                If dto.PGER_vl_parametro < minval Or dto.PGER_vl_parametro > maxval Then
                    ret = obj.getValue(dt, "range")
                    ret = String.Format(ret, CStr(minval), CStr(maxval))
                    GoTo fim
                End If

            Case "URL"
                If dto.PGER_vl_parametro.ToString.Trim.Length = 0 Then
                    ret = obj.getValue(dt, "required")
                    GoTo fim
                End If

                If Not val.is_valid_url(dto.PGER_vl_parametro) Then
                    ret = obj.getValue(dt, "format")
                    GoTo fim
                End If
        End Select


fim:
        Return ret

    End Function
    

    Public Function SaveData(ByVal dto As DTO.tb_PGER_parametro_geral, _
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
                Case tb_PGER_parametro_geral.Mode.Insert
                    Return InsertData(dto)
                Case tb_PGER_parametro_geral.Mode.Update
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
      'Case PGER_cd_parametro
 'values = ""

'Case PGER_ds_parametro
 'values = ""

'Case PGER_vl_parametro
 'values = ""

'Case PGER_fl_tipo
 'values = ""

'Case PGER_fl_sistema
 'values = ""

'Case PGER_vl_range_min
 'values = ""

'Case PGER_vl_range_max
 'values = ""

'Case PGER_vl_padrao
 'values = ""

'Case PGER_vl_tamanho_min
 'values = ""

'Case PGER_vl_tamanho_max
 'values = ""

'Case PGER_vl_valores_permitidos
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
