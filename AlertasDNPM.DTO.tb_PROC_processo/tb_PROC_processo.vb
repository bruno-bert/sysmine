Public Class tb_PROC_processo
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _PROC_cd_processo As Object
Private _PROC_ds_titular As Object
Private _PROC_vl_ano As Object
Private _PROC_nm_processo As Object
Private _PROC_id_processo As Object
Private _FASE_cd_fase As Object
Private _PROC_ds_ultimo_evento As Object
Private _PROC_ds_substancia As Object
Private _PROC_ds_area As Object
Private _PROC_ds_uso As Object
Private _PROC_ds_link As Object
Private _UNFE_cd_unidade_federativa As Object
Private _PROC_fl_tipo_inclusao As Object
Private _AUDT_dt_inclusao As Object
Private _AUDT_nm_usuario_inclusao As Object
Private _AUDT_dt_alteracao As Object
    Private _AUDT_nm_usuario_alteracao As Object

    Private _PROC_ls_processo As Object
    Private _PROC_ls_documento As Object
    Private _PROC_ls_tipo As Object
    Private _ORGA_nm_orgao As Object
    Private _PROC_dt_publicacao_ini As Object
    Private _PROC_dt_publicacao_fim As Object
    Private _PROC_dt_vencimento_ini As Object
    Private _PROC_dt_vencimento_fim As Object
    Private _PROC_qt_dias_vencer As Object

    Private _PROC_ls_titular As Object
    Private _PROC_ls_fase As Object

    Private _PROC_cd_prioridade As Object


    Public Property PROC_cd_prioridade() As Object
        Get
            Return _PROC_cd_prioridade
        End Get
        Set(ByVal value As Object)
            _PROC_cd_prioridade = value
        End Set
    End Property

    
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
    Public Property PROC_ls_processo() As Object
        Get
            Return _PROC_ls_processo
        End Get
        Set(ByVal value As Object)
            _PROC_ls_processo = value
        End Set
    End Property

    Public Property PROC_ls_documento() As Object
        Get
            Return _PROC_ls_documento
        End Get
        Set(ByVal value As Object)
            _PROC_ls_documento = value
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
    Public Property PROC_qt_dias_vencer() As Object
        Get
            Return _PROC_qt_dias_vencer
        End Get
        Set(ByVal value As Object)
            _PROC_qt_dias_vencer = value
        End Set
    End Property

    Public Property PROC_ls_tipo() As Object
        Get
            Return _PROC_ls_tipo
        End Get
        Set(ByVal value As Object)
            _PROC_ls_tipo = value
        End Set
    End Property

    Public Property PROC_dt_publicacao_ini() As Object
        Get
            Return _PROC_dt_publicacao_ini
        End Get
        Set(ByVal value As Object)
            _PROC_dt_publicacao_ini = value
        End Set
    End Property
    Public Property PROC_dt_publicacao_fim() As Object
        Get
            Return _PROC_dt_publicacao_fim
        End Get
        Set(ByVal value As Object)
            _PROC_dt_publicacao_fim = value
        End Set
    End Property

    Public Property PROC_dt_vencimento_ini() As Object
        Get
            Return _PROC_dt_vencimento_ini
        End Get
        Set(ByVal value As Object)
            _PROC_dt_vencimento_ini = value
        End Set
    End Property
    Public Property PROC_dt_vencimento_fim() As Object
        Get
            Return _PROC_dt_vencimento_fim
        End Get
        Set(ByVal value As Object)
            _PROC_dt_vencimento_fim = value
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

  Public Property PROC_ds_titular() As Object
        Get
            Return _PROC_ds_titular
        End Get
        Set(ByVal value As Object)
            _PROC_ds_titular = value
        End Set
    End Property

  Public Property PROC_vl_ano() As Object
        Get
            Return _PROC_vl_ano
        End Get
        Set(ByVal value As Object)
            _PROC_vl_ano = value
        End Set
    End Property

  Public Property PROC_nm_processo() As Object
        Get
            Return _PROC_nm_processo
        End Get
        Set(ByVal value As Object)
            _PROC_nm_processo = value
        End Set
    End Property

  Public Property PROC_id_processo() As Object
        Get
            Return _PROC_id_processo
        End Get
        Set(ByVal value As Object)
            _PROC_id_processo = value
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

  Public Property PROC_ds_ultimo_evento() As Object
        Get
            Return _PROC_ds_ultimo_evento
        End Get
        Set(ByVal value As Object)
            _PROC_ds_ultimo_evento = value
        End Set
    End Property

  Public Property PROC_ds_substancia() As Object
        Get
            Return _PROC_ds_substancia
        End Get
        Set(ByVal value As Object)
            _PROC_ds_substancia = value
        End Set
    End Property

  Public Property PROC_ds_area() As Object
        Get
            Return _PROC_ds_area
        End Get
        Set(ByVal value As Object)
            _PROC_ds_area = value
        End Set
    End Property

  Public Property PROC_ds_uso() As Object
        Get
            Return _PROC_ds_uso
        End Get
        Set(ByVal value As Object)
            _PROC_ds_uso = value
        End Set
    End Property

  Public Property PROC_ds_link() As Object
        Get
            Return _PROC_ds_link
        End Get
        Set(ByVal value As Object)
            _PROC_ds_link = value
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

  Public Property PROC_fl_tipo_inclusao() As Object
        Get
            Return _PROC_fl_tipo_inclusao
        End Get
        Set(ByVal value As Object)
            _PROC_fl_tipo_inclusao = value
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


    Public Property PROC_ls_titular() As Object
        Get
            Return _PROC_ls_titular
        End Get
        Set(ByVal value As Object)
            _PROC_ls_titular = value
        End Set
    End Property

    Public Property PROC_ls_fase() As Object
        Get
            Return _PROC_ls_fase
        End Get
        Set(ByVal value As Object)
            _PROC_ls_fase = value
        End Set
    End Property

End Class