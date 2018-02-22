Public Class tb_LESI_log_erro_sistema
    
    Private _startRowIndex As Integer = 0
    Private _maximumRows As Integer = 0
    Private _sortOrder As String = Nothing
    Private _sortField As String = Nothing
    Private _whereField As String = Nothing
    Private _whereValue As String = Nothing
    Private _WhereClause As String = Nothing
    Private _OrderByClause As String = Nothing
    
    Private _LESI_cd_ocorrencia As Object
Private _LESI_nm_source As Object
Private _LESI_ds_exception As Object
Private _LESI_ds_inexception As Object
Private _LESI_dt_ocorrencia As Object
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
   

      Public Property LESI_cd_ocorrencia() As Object
        Get
            Return _LESI_cd_ocorrencia
        End Get
        Set(ByVal value As Object)
            _LESI_cd_ocorrencia = value
        End Set
    End Property

  Public Property LESI_nm_source() As Object
        Get
            Return _LESI_nm_source
        End Get
        Set(ByVal value As Object)
            _LESI_nm_source = value
        End Set
    End Property

  Public Property LESI_ds_exception() As Object
        Get
            Return _LESI_ds_exception
        End Get
        Set(ByVal value As Object)
            _LESI_ds_exception = value
        End Set
    End Property

  Public Property LESI_ds_inexception() As Object
        Get
            Return _LESI_ds_inexception
        End Get
        Set(ByVal value As Object)
            _LESI_ds_inexception = value
        End Set
    End Property

  Public Property LESI_dt_ocorrencia() As Object
        Get
            Return _LESI_dt_ocorrencia
        End Get
        Set(ByVal value As Object)
            _LESI_dt_ocorrencia = value
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