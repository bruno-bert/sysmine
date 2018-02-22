Public Class tb_PTIT_processo_titulo
    
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
Private _PTIT_nm_titulo As Object
Private _PTIT_ds_titulo As Object
Private _TTIT_ds_tipo_titulo As Object
Private _SITU_ds_situacao_titulo As Object
Private _PTIT_dt_publicacao As Object
Private _PTIT_dt_vencimento As Object
Private _PTIT_ds_nome_documento As Object
Private _PTIT_ds_local_documento As Object
Private _PTIT_ds_rede_documento As Object
Private _PTIT_ds_path_documento As Object
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

  Public Property PTIT_nm_titulo() As Object
        Get
            Return _PTIT_nm_titulo
        End Get
        Set(ByVal value As Object)
            _PTIT_nm_titulo = value
        End Set
    End Property

  Public Property PTIT_ds_titulo() As Object
        Get
            Return _PTIT_ds_titulo
        End Get
        Set(ByVal value As Object)
            _PTIT_ds_titulo = value
        End Set
    End Property

  Public Property TTIT_ds_tipo_titulo() As Object
        Get
            Return _TTIT_ds_tipo_titulo
        End Get
        Set(ByVal value As Object)
            _TTIT_ds_tipo_titulo = value
        End Set
    End Property

  Public Property SITU_ds_situacao_titulo() As Object
        Get
            Return _SITU_ds_situacao_titulo
        End Get
        Set(ByVal value As Object)
            _SITU_ds_situacao_titulo = value
        End Set
    End Property

  Public Property PTIT_dt_publicacao() As Object
        Get
            Return _PTIT_dt_publicacao
        End Get
        Set(ByVal value As Object)
            _PTIT_dt_publicacao = value
        End Set
    End Property

  Public Property PTIT_dt_vencimento() As Object
        Get
            Return _PTIT_dt_vencimento
        End Get
        Set(ByVal value As Object)
            _PTIT_dt_vencimento = value
        End Set
    End Property

  Public Property PTIT_ds_nome_documento() As Object
        Get
            Return _PTIT_ds_nome_documento
        End Get
        Set(ByVal value As Object)
            _PTIT_ds_nome_documento = value
        End Set
    End Property

  Public Property PTIT_ds_local_documento() As Object
        Get
            Return _PTIT_ds_local_documento
        End Get
        Set(ByVal value As Object)
            _PTIT_ds_local_documento = value
        End Set
    End Property

  Public Property PTIT_ds_rede_documento() As Object
        Get
            Return _PTIT_ds_rede_documento
        End Get
        Set(ByVal value As Object)
            _PTIT_ds_rede_documento = value
        End Set
    End Property

  Public Property PTIT_ds_path_documento() As Object
        Get
            Return _PTIT_ds_path_documento
        End Get
        Set(ByVal value As Object)
            _PTIT_ds_path_documento = value
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