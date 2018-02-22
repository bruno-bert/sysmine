Public Class tb_AVEN_alerta_vencimento
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _PROC_cd_processo As Object
Private _ORGA_nm_orgao As Object
Private _AVEN_nm_tipo_documento As Object
Private _AVEN_id_documento As Object
Private _AVEN_fl_conta_alerta As Object
Private _AVEN_dt_ultimo_alerta As Object
Private _AVEN_fl_ultimo_envio As Object
Private _AUDT_dt_inclusao As Object
Private _AUDT_nm_usuario_inclusao As Object
Private _AUDT_dt_alteracao As Object
Private _AUDT_nm_usuario_alteracao As Object

    
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
   

      Public Property PROC_cd_processo() As Object
        Get
            Return _PROC_cd_processo
        End Get
        Set(ByVal value As Object)
            _PROC_cd_processo = value
        End Set
    End Property

  Public Property ORGA_nm_orgao() As Object
        Get
            Return _ORGA_nm_orgao
        End Get
        Set(ByVal value As Object)
            _ORGA_nm_orgao = value
        End Set
    End Property

  Public Property AVEN_nm_tipo_documento() As Object
        Get
            Return _AVEN_nm_tipo_documento
        End Get
        Set(ByVal value As Object)
            _AVEN_nm_tipo_documento = value
        End Set
    End Property

  Public Property AVEN_id_documento() As Object
        Get
            Return _AVEN_id_documento
        End Get
        Set(ByVal value As Object)
            _AVEN_id_documento = value
        End Set
    End Property

  Public Property AVEN_fl_conta_alerta() As Object
        Get
            Return _AVEN_fl_conta_alerta
        End Get
        Set(ByVal value As Object)
            _AVEN_fl_conta_alerta = value
        End Set
    End Property

  Public Property AVEN_dt_ultimo_alerta() As Object
        Get
            Return _AVEN_dt_ultimo_alerta
        End Get
        Set(ByVal value As Object)
            _AVEN_dt_ultimo_alerta = value
        End Set
    End Property

  Public Property AVEN_fl_ultimo_envio() As Object
        Get
            Return _AVEN_fl_ultimo_envio
        End Get
        Set(ByVal value As Object)
            _AVEN_fl_ultimo_envio = value
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

  Public Property AUDT_dt_alteracao() As Object
        Get
            Return _AUDT_dt_alteracao
        End Get
        Set(ByVal value As Object)
            _AUDT_dt_alteracao = value
        End Set
    End Property

  Public Property AUDT_nm_usuario_alteracao() As Object
        Get
            Return _AUDT_nm_usuario_alteracao
        End Get
        Set(ByVal value As Object)
            _AUDT_nm_usuario_alteracao = value
        End Set
    End Property




End Class