Public Class tb_PINF_processo_info
    
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
Private _PINF_cd_info As Object
Private _PINF_ds_info As Object
Private _TINF_nm_tipo_info As Object
Private _SINF_ds_situacao_info As Object
Private _PINF_dt_ini As Object
Private _PINF_dt_fim As Object
Private _PINF_ds_local_documento As Object
Private _PINF_ds_rede_documento As Object
Private _PINF_ds_path_documento As Object
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

  Public Property PINF_cd_info() As Object
        Get
            Return _PINF_cd_info
        End Get
        Set(ByVal value As Object)
            _PINF_cd_info = value
        End Set
    End Property

  Public Property PINF_ds_info() As Object
        Get
            Return _PINF_ds_info
        End Get
        Set(ByVal value As Object)
            _PINF_ds_info = value
        End Set
    End Property

  Public Property TINF_nm_tipo_info() As Object
        Get
            Return _TINF_nm_tipo_info
        End Get
        Set(ByVal value As Object)
            _TINF_nm_tipo_info = value
        End Set
    End Property

  Public Property SINF_ds_situacao_info() As Object
        Get
            Return _SINF_ds_situacao_info
        End Get
        Set(ByVal value As Object)
            _SINF_ds_situacao_info = value
        End Set
    End Property

  Public Property PINF_dt_ini() As Object
        Get
            Return _PINF_dt_ini
        End Get
        Set(ByVal value As Object)
            _PINF_dt_ini = value
        End Set
    End Property

  Public Property PINF_dt_fim() As Object
        Get
            Return _PINF_dt_fim
        End Get
        Set(ByVal value As Object)
            _PINF_dt_fim = value
        End Set
    End Property

  Public Property PINF_ds_local_documento() As Object
        Get
            Return _PINF_ds_local_documento
        End Get
        Set(ByVal value As Object)
            _PINF_ds_local_documento = value
        End Set
    End Property

  Public Property PINF_ds_rede_documento() As Object
        Get
            Return _PINF_ds_rede_documento
        End Get
        Set(ByVal value As Object)
            _PINF_ds_rede_documento = value
        End Set
    End Property

  Public Property PINF_ds_path_documento() As Object
        Get
            Return _PINF_ds_path_documento
        End Get
        Set(ByVal value As Object)
            _PINF_ds_path_documento = value
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