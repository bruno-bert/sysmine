Public Class tb_PAUX_processo_auxiliar
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _PAUX_cd_processo As Object
Private _PAUX_ds_titular As Object
Private _FASE_cd_fase As Object
Private _PAUX_ds_ultimo_evento As Object
Private _UNFE_cd_unidade_federativa As Object
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
   

      Public Property PAUX_cd_processo() As Object
        Get
            Return _PAUX_cd_processo
        End Get
        Set(ByVal value As Object)
            _PAUX_cd_processo = value
        End Set
    End Property

  Public Property PAUX_ds_titular() As Object
        Get
            Return _PAUX_ds_titular
        End Get
        Set(ByVal value As Object)
            _PAUX_ds_titular = value
        End Set
    End Property

  Public Property FASE_cd_fase() As Object
        Get
            Return _FASE_cd_fase
        End Get
        Set(ByVal value As Object)
            _FASE_cd_fase = value
        End Set
    End Property

  Public Property PAUX_ds_ultimo_evento() As Object
        Get
            Return _PAUX_ds_ultimo_evento
        End Get
        Set(ByVal value As Object)
            _PAUX_ds_ultimo_evento = value
        End Set
    End Property

  Public Property UNFE_cd_unidade_federativa() As Object
        Get
            Return _UNFE_cd_unidade_federativa
        End Get
        Set(ByVal value As Object)
            _UNFE_cd_unidade_federativa = value
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