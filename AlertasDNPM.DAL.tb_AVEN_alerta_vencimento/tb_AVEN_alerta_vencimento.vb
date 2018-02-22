Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_AVEN_alerta_vencimento
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_AVEN_alerta_vencimento

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_AVEN_alerta_vencimento)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_AVEN_alerta_vencimento"
            Dim parm(3) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@AVEN_nm_tipo_documento"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.AVEN_nm_tipo_documento

parm(3).Campo = "@AVEN_id_documento"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.AVEN_id_documento



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_AVEN_alerta_vencimento_rel"
            Dim parm(12) As Parametros

            parm(0).Campo = "@startRowIndex"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.startRowIndex

parm(1).Campo = "@maximumRows"
parm(1).Tipo = SqlDbType.int
parm(1).Conteudo = pDTO.maximumRows

parm(2).Campo = "@sortField"
parm(2).Tipo = SqlDbType.nvarchar
parm(2).Conteudo = pDTO.sortField

parm(3).Campo = "@sortOrder"
parm(3).Tipo = SqlDbType.nvarchar
parm(3).Conteudo = pDTO.sortOrder

parm(4).Campo = "@whereField"
parm(4).Tipo = SqlDbType.nvarchar
parm(4).Conteudo = pDTO.whereField

parm(5).Campo = "@whereValue"
parm(5).Tipo = SqlDbType.nvarchar
parm(5).Conteudo = pDTO.whereValue

parm(6).Campo = "@PROC_cd_processo"
parm(6).Tipo = SqlDbType.varchar
parm(6).Conteudo = pDTO.PROC_cd_processo

parm(7).Campo = "@ORGA_nm_orgao"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.ORGA_nm_orgao

parm(8).Campo = "@AVEN_nm_tipo_documento"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.AVEN_nm_tipo_documento

parm(9).Campo = "@AVEN_id_documento"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.AVEN_id_documento

parm(10).Campo = "@AVEN_fl_conta_alerta"
parm(10).Tipo = SqlDbType.int
parm(10).Conteudo = pDTO.AVEN_fl_conta_alerta

parm(11).Campo = "@AVEN_dt_ultimo_alerta"
parm(11).Tipo = SqlDbType.datetime
parm(11).Conteudo = pDTO.AVEN_dt_ultimo_alerta

parm(12).Campo = "@AVEN_fl_ultimo_envio"
parm(12).Tipo = SqlDbType.char
parm(12).Conteudo = pDTO.AVEN_fl_ultimo_envio



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_AVEN_alerta_vencimento"
            Dim parm(10) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@AVEN_nm_tipo_documento"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.AVEN_nm_tipo_documento

parm(3).Campo = "@AVEN_id_documento"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.AVEN_id_documento

parm(4).Campo = "@AVEN_fl_conta_alerta"
parm(4).Tipo = SqlDbType.int
parm(4).Conteudo = pDTO.AVEN_fl_conta_alerta

parm(5).Campo = "@AVEN_dt_ultimo_alerta"
parm(5).Tipo = SqlDbType.datetime
parm(5).Conteudo = pDTO.AVEN_dt_ultimo_alerta

parm(6).Campo = "@AVEN_fl_ultimo_envio"
parm(6).Tipo = SqlDbType.char
parm(6).Conteudo = pDTO.AVEN_fl_ultimo_envio

parm(7).Campo = "@AUDT_dt_inclusao"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.AUDT_dt_inclusao

parm(8).Campo = "@AUDT_nm_usuario_inclusao"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(9).Campo = "@AUDT_dt_alteracao"
parm(9).Tipo = SqlDbType.datetime
parm(9).Conteudo = pDTO.AUDT_dt_alteracao

parm(10).Campo = "@AUDT_nm_usuario_alteracao"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_AVEN_alerta_vencimento"
            Dim parm(10) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@AVEN_nm_tipo_documento"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.AVEN_nm_tipo_documento

parm(3).Campo = "@AVEN_id_documento"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.AVEN_id_documento

parm(4).Campo = "@AVEN_fl_conta_alerta"
parm(4).Tipo = SqlDbType.int
parm(4).Conteudo = pDTO.AVEN_fl_conta_alerta

parm(5).Campo = "@AVEN_dt_ultimo_alerta"
parm(5).Tipo = SqlDbType.datetime
parm(5).Conteudo = pDTO.AVEN_dt_ultimo_alerta

parm(6).Campo = "@AVEN_fl_ultimo_envio"
parm(6).Tipo = SqlDbType.char
parm(6).Conteudo = pDTO.AVEN_fl_ultimo_envio

parm(7).Campo = "@AUDT_dt_inclusao"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.AUDT_dt_inclusao

parm(8).Campo = "@AUDT_nm_usuario_inclusao"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(9).Campo = "@AUDT_dt_alteracao"
parm(9).Tipo = SqlDbType.datetime
parm(9).Conteudo = pDTO.AUDT_dt_alteracao

parm(10).Campo = "@AUDT_nm_usuario_alteracao"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_AVEN_alerta_vencimento"
            Dim parm(3) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@AVEN_nm_tipo_documento"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.AVEN_nm_tipo_documento

parm(3).Campo = "@AVEN_id_documento"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.AVEN_id_documento



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_AVEN_alerta_vencimento_cons"
            Dim parm(1) As Parametros

            parm(0).Campo = "@WhereClause"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.WhereClause

parm(1).Campo = "@OrderByClause"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.OrderByClause



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function


End Class