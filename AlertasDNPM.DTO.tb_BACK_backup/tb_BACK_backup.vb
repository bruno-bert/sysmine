Public Class tb_BACK_backup
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _BACK_cd_backup As Object
Private _BACK_vl_intervalo As Object
Private _BACK_nm_arquivo As Object
Private _BACK_fl_execucao As Object
Private _BACK_ds_mensagem As Object
Private _BACK_dt_execucao As Object
Private _BACK_dt_tentativa_Execucao As Object
Private _BACK_dt_backup As Object
Private _BACK_dt_sincronizacao As Object
Private _BACK_fl_tipo As Object
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
   

      Public Property BACK_cd_backup() As Object
        Get
            Return _BACK_cd_backup
        End Get
        Set(ByVal value As Object)
            _BACK_cd_backup = value
        End Set
    End Property

  Public Property BACK_vl_intervalo() As Object
        Get
            Return _BACK_vl_intervalo
        End Get
        Set(ByVal value As Object)
            _BACK_vl_intervalo = value
        End Set
    End Property

  Public Property BACK_nm_arquivo() As Object
        Get
            Return _BACK_nm_arquivo
        End Get
        Set(ByVal value As Object)
            _BACK_nm_arquivo = value
        End Set
    End Property

  Public Property BACK_fl_execucao() As Object
        Get
            Return _BACK_fl_execucao
        End Get
        Set(ByVal value As Object)
            _BACK_fl_execucao = value
        End Set
    End Property

  Public Property BACK_ds_mensagem() As Object
        Get
            Return _BACK_ds_mensagem
        End Get
        Set(ByVal value As Object)
            _BACK_ds_mensagem = value
        End Set
    End Property

  Public Property BACK_dt_execucao() As Object
        Get
            Return _BACK_dt_execucao
        End Get
        Set(ByVal value As Object)
            _BACK_dt_execucao = value
        End Set
    End Property

  Public Property BACK_dt_tentativa_Execucao() As Object
        Get
            Return _BACK_dt_tentativa_Execucao
        End Get
        Set(ByVal value As Object)
            _BACK_dt_tentativa_Execucao = value
        End Set
    End Property

  Public Property BACK_dt_backup() As Object
        Get
            Return _BACK_dt_backup
        End Get
        Set(ByVal value As Object)
            _BACK_dt_backup = value
        End Set
    End Property

  Public Property BACK_dt_sincronizacao() As Object
        Get
            Return _BACK_dt_sincronizacao
        End Get
        Set(ByVal value As Object)
            _BACK_dt_sincronizacao = value
        End Set
    End Property

  Public Property BACK_fl_tipo() As Object
        Get
            Return _BACK_fl_tipo
        End Get
        Set(ByVal value As Object)
            _BACK_fl_tipo = value
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