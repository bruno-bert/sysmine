Public Class tb_ROTI_rotina
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _ROTI_nm_rotina As Object
Private _ROTI_ds_rotina As Object
Private _ROTI_dt_ultima_execucao As Object
Private _ROTI_dt_ultima_tentativa_execucao As Object
Private _ROTI_fl_status_execucao As Object
Private _ROTI_ds_mensagem As Object
Private _ROTI_vl_tempo_medio As Object
Private _AUDT_dt_inclusao As Object
Private _AUDT_nm_usuario_inclusao As Object
Private _AUDT_dt_alteracao As Object
    Private _AUDT_nm_usuario_alteracao As Object
    Private _ROTI_dt_inicio_execucao As Object

    
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
   

      Public Property ROTI_nm_rotina() As Object
        Get
            Return _ROTI_nm_rotina
        End Get
        Set(ByVal value As Object)
            _ROTI_nm_rotina = value
        End Set
    End Property

  Public Property ROTI_ds_rotina() As Object
        Get
            Return _ROTI_ds_rotina
        End Get
        Set(ByVal value As Object)
            _ROTI_ds_rotina = value
        End Set
    End Property

  Public Property ROTI_dt_ultima_execucao() As Object
        Get
            Return _ROTI_dt_ultima_execucao
        End Get
        Set(ByVal value As Object)
            _ROTI_dt_ultima_execucao = value
        End Set
    End Property
    Public Property ROTI_dt_inicio_execucao() As Object
        Get
            Return _ROTI_dt_inicio_execucao
        End Get
        Set(ByVal value As Object)
            _ROTI_dt_inicio_execucao = value
        End Set
    End Property

  Public Property ROTI_dt_ultima_tentativa_execucao() As Object
        Get
            Return _ROTI_dt_ultima_tentativa_execucao
        End Get
        Set(ByVal value As Object)
            _ROTI_dt_ultima_tentativa_execucao = value
        End Set
    End Property

  Public Property ROTI_fl_status_execucao() As Object
        Get
            Return _ROTI_fl_status_execucao
        End Get
        Set(ByVal value As Object)
            _ROTI_fl_status_execucao = value
        End Set
    End Property

  Public Property ROTI_ds_mensagem() As Object
        Get
            Return _ROTI_ds_mensagem
        End Get
        Set(ByVal value As Object)
            _ROTI_ds_mensagem = value
        End Set
    End Property

  Public Property ROTI_vl_tempo_medio() As Object
        Get
            Return _ROTI_vl_tempo_medio
        End Get
        Set(ByVal value As Object)
            _ROTI_vl_tempo_medio = value
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