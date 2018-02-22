Public Class tb_HSAL_historico_alerta
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _HSAL_id_historico As Object
Private _HSAL_ds_email As Object
Private _ALER_nm_alerta As Object
Private _PROC_cd_processo As Object
Private _HSAL_ds_assunto_email As Object
Private _HSAL_ds_texto_email As Object
Private _HSAL_dt_envio As Object
Private _HSAL_dt_tentativa_ultimo_envio As Object
Private _HSAL_ds_mensagem As Object
Private _HSAL_fl_status As Object
Private _AUDT_dt_inclusao As Object
Private _AUDT_nm_usuario_inclusao As Object

    
    Public Property startRowIndex() As Integer
        Get
            Return _startRowIndex
        End Get
        Set(ByVal value As Integer)
            _startRowIndex = value
        End Set
    End Property

    Public Property maximumRows() As Integer
        Get
            Return _maximumRows
        End Get
        Set(ByVal value As Integer)
            _maximumRows = value
        End Set
    End Property

    Public Property sortField() As String
        Get
            Return _sortField
        End Get
        Set(ByVal value As String)
            _sortField = value
        End Set
    End Property

    Public Property sortOrder() As String
        Get
            Return _sortOrder
        End Get
        Set(ByVal value As String)
            _sortOrder = value
        End Set
    End Property

    Public Property whereField() As String
        Get
            Return _whereField
        End Get
        Set(ByVal value As String)
            _whereField = value
        End Set
    End Property

    Public Property whereValue() As String
        Get
            Return _whereValue
        End Get
        Set(ByVal value As String)
            _whereValue = value
        End Set
    End Property

    Public Property WhereClause() As String
        Get
            Return _WhereClause
        End Get
        Set(ByVal value As String)
            _WhereClause = value
        End Set
    End Property

    Public Property OrderByClause() As String
        Get
            Return _OrderByClause
        End Get
        Set(ByVal value As String)
            _OrderByClause = value
        End Set
    End Property
   

      Public Property HSAL_id_historico() As Object
        Get
            Return _HSAL_id_historico
        End Get
        Set(ByVal value As Object)
            _HSAL_id_historico = value
        End Set
    End Property

  Public Property HSAL_ds_email() As Object
        Get
            Return _HSAL_ds_email
        End Get
        Set(ByVal value As Object)
            _HSAL_ds_email = value
        End Set
    End Property

  Public Property ALER_nm_alerta() As Object
        Get
            Return _ALER_nm_alerta
        End Get
        Set(ByVal value As Object)
            _ALER_nm_alerta = value
        End Set
    End Property

  Public Property PROC_cd_processo() As Object
        Get
            Return _PROC_cd_processo
        End Get
        Set(ByVal value As Object)
            _PROC_cd_processo = value
        End Set
    End Property

  Public Property HSAL_ds_assunto_email() As Object
        Get
            Return _HSAL_ds_assunto_email
        End Get
        Set(ByVal value As Object)
            _HSAL_ds_assunto_email = value
        End Set
    End Property

  Public Property HSAL_ds_texto_email() As Object
        Get
            Return _HSAL_ds_texto_email
        End Get
        Set(ByVal value As Object)
            _HSAL_ds_texto_email = value
        End Set
    End Property

  Public Property HSAL_dt_envio() As Object
        Get
            Return _HSAL_dt_envio
        End Get
        Set(ByVal value As Object)
            _HSAL_dt_envio = value
        End Set
    End Property

  Public Property HSAL_dt_tentativa_ultimo_envio() As Object
        Get
            Return _HSAL_dt_tentativa_ultimo_envio
        End Get
        Set(ByVal value As Object)
            _HSAL_dt_tentativa_ultimo_envio = value
        End Set
    End Property

  Public Property HSAL_ds_mensagem() As Object
        Get
            Return _HSAL_ds_mensagem
        End Get
        Set(ByVal value As Object)
            _HSAL_ds_mensagem = value
        End Set
    End Property

  Public Property HSAL_fl_status() As Object
        Get
            Return _HSAL_fl_status
        End Get
        Set(ByVal value As Object)
            _HSAL_fl_status = value
        End Set
    End Property

  Public Property AUDT_dt_inclusao() As Object
        Get
            Return _AUDT_dt_inclusao
        End Get
        Set(ByVal value As Object)
            _AUDT_dt_inclusao = value
        End Set
    End Property

  Public Property AUDT_nm_usuario_inclusao() As Object
        Get
            Return _AUDT_nm_usuario_inclusao
        End Get
        Set(ByVal value As Object)
            _AUDT_nm_usuario_inclusao = value
        End Set
    End Property




End Class