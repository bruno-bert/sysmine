Public Class tb_ALER_alerta
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _ALER_nm_alerta As Object
Private _ALER_ds_alerta As Object
Private _ALER_fl_muda_fase As Object
Private _ALER_fl_muda_evento As Object
Private _ALER_cd_fase_anterior As Object
Private _ALER_cd_fase_nova As Object
Private _ALER_fl_qualquer_processo As Object
Private _ALER_fl_status As Object
Private _ALER_fl_sistema As Object
Private _AUDT_dt_inclusao As Object
Private _AUDT_nm_usuario_inclusao As Object
Private _AUDT_dt_alteracao As Object
Private _AUDT_nm_usuario_alteracao As Object
    Private _ALER_fl_geral As Object
    Private _ALER_cd_evento As Object
    
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
   

      Public Property ALER_nm_alerta() As Object
        Get
            Return _ALER_nm_alerta
        End Get
        Set(ByVal value As Object)
            _ALER_nm_alerta = value
        End Set
    End Property

  Public Property ALER_ds_alerta() As Object
        Get
            Return _ALER_ds_alerta
        End Get
        Set(ByVal value As Object)
            _ALER_ds_alerta = value
        End Set
    End Property

  Public Property ALER_fl_muda_fase() As Object
        Get
            Return _ALER_fl_muda_fase
        End Get
        Set(ByVal value As Object)
            _ALER_fl_muda_fase = value
        End Set
    End Property

  Public Property ALER_fl_muda_evento() As Object
        Get
            Return _ALER_fl_muda_evento
        End Get
        Set(ByVal value As Object)
            _ALER_fl_muda_evento = value
        End Set
    End Property

  Public Property ALER_cd_fase_anterior() As Object
        Get
            Return _ALER_cd_fase_anterior
        End Get
        Set(ByVal value As Object)
            _ALER_cd_fase_anterior = value
        End Set
    End Property

  Public Property ALER_cd_fase_nova() As Object
        Get
            Return _ALER_cd_fase_nova
        End Get
        Set(ByVal value As Object)
            _ALER_cd_fase_nova = value
        End Set
    End Property

  Public Property ALER_fl_qualquer_processo() As Object
        Get
            Return _ALER_fl_qualquer_processo
        End Get
        Set(ByVal value As Object)
            _ALER_fl_qualquer_processo = value
        End Set
    End Property

  Public Property ALER_fl_status() As Object
        Get
            Return _ALER_fl_status
        End Get
        Set(ByVal value As Object)
            _ALER_fl_status = value
        End Set
    End Property

  Public Property ALER_fl_sistema() As Object
        Get
            Return _ALER_fl_sistema
        End Get
        Set(ByVal value As Object)
            _ALER_fl_sistema = value
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

    Public Property ALER_fl_geral() As Object
        Get
            Return _ALER_fl_geral
        End Get
        Set(ByVal value As Object)
            _ALER_fl_geral = value
        End Set
    End Property

    Public Property ALER_cd_evento() As Object
        Get
            Return _ALER_cd_evento
        End Get
        Set(ByVal value As Object)
            _ALER_cd_evento = value
        End Set
    End Property




End Class