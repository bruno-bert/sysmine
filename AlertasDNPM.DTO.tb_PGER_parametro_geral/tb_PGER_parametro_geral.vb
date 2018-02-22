Public Class tb_PGER_parametro_geral
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _PGER_cd_parametro As Object
Private _PGER_ds_parametro As Object
Private _PGER_vl_parametro As Object
Private _PGER_fl_tipo As Object
Private _PGER_fl_sistema As Object
Private _PGER_vl_range_min As Object
Private _PGER_vl_range_max As Object
Private _PGER_vl_padrao As Object
Private _PGER_vl_tamanho_min As Object
Private _PGER_vl_tamanho_max As Object
Private _PGER_vl_valores_permitidos As Object
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
   

      Public Property PGER_cd_parametro() As Object
        Get
            Return _PGER_cd_parametro
        End Get
        Set(ByVal value As Object)
            _PGER_cd_parametro = value
        End Set
    End Property

  Public Property PGER_ds_parametro() As Object
        Get
            Return _PGER_ds_parametro
        End Get
        Set(ByVal value As Object)
            _PGER_ds_parametro = value
        End Set
    End Property

  Public Property PGER_vl_parametro() As Object
        Get
            Return _PGER_vl_parametro
        End Get
        Set(ByVal value As Object)
            _PGER_vl_parametro = value
        End Set
    End Property

  Public Property PGER_fl_tipo() As Object
        Get
            Return _PGER_fl_tipo
        End Get
        Set(ByVal value As Object)
            _PGER_fl_tipo = value
        End Set
    End Property

  Public Property PGER_fl_sistema() As Object
        Get
            Return _PGER_fl_sistema
        End Get
        Set(ByVal value As Object)
            _PGER_fl_sistema = value
        End Set
    End Property

  Public Property PGER_vl_range_min() As Object
        Get
            Return _PGER_vl_range_min
        End Get
        Set(ByVal value As Object)
            _PGER_vl_range_min = value
        End Set
    End Property

  Public Property PGER_vl_range_max() As Object
        Get
            Return _PGER_vl_range_max
        End Get
        Set(ByVal value As Object)
            _PGER_vl_range_max = value
        End Set
    End Property

  Public Property PGER_vl_padrao() As Object
        Get
            Return _PGER_vl_padrao
        End Get
        Set(ByVal value As Object)
            _PGER_vl_padrao = value
        End Set
    End Property

  Public Property PGER_vl_tamanho_min() As Object
        Get
            Return _PGER_vl_tamanho_min
        End Get
        Set(ByVal value As Object)
            _PGER_vl_tamanho_min = value
        End Set
    End Property

  Public Property PGER_vl_tamanho_max() As Object
        Get
            Return _PGER_vl_tamanho_max
        End Get
        Set(ByVal value As Object)
            _PGER_vl_tamanho_max = value
        End Set
    End Property

  Public Property PGER_vl_valores_permitidos() As Object
        Get
            Return _PGER_vl_valores_permitidos
        End Get
        Set(ByVal value As Object)
            _PGER_vl_valores_permitidos = value
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