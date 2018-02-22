Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_PSUB_processo_substancia
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_PSUB_processo_substancia

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_PSUB_processo_substancia)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PSUB_processo_substancia"
            Dim parm(2) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@SUBS_nm_substancia"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.SUBS_nm_substancia

            parm(2).Campo = "@TUSO_nm_uso"
            parm(2).Tipo = SqlDbType.VarChar
            parm(2).Conteudo = pDTO.TUSO_nm_uso

            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PSUB_processo_substancia_rel"
            Dim parm(8) As Parametros

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

parm(7).Campo = "@SUBS_nm_substancia"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.SUBS_nm_substancia

parm(8).Campo = "@TUSO_nm_uso"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.TUSO_nm_uso



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_PSUB_processo_substancia"
            Dim parm(9) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@SUBS_nm_substancia"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.SUBS_nm_substancia

parm(2).Campo = "@TUSO_nm_uso"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.TUSO_nm_uso

parm(3).Campo = "@PSUB_dt_inicio"
parm(3).Tipo = SqlDbType.date
parm(3).Conteudo = pDTO.PSUB_dt_inicio

parm(4).Campo = "@PSUB_dt_fim"
parm(4).Tipo = SqlDbType.date
parm(4).Conteudo = pDTO.PSUB_dt_fim

parm(5).Campo = "@PSUB_ds_motivo"
parm(5).Tipo = SqlDbType.varchar
parm(5).Conteudo = pDTO.PSUB_ds_motivo

parm(6).Campo = "@AUDT_dt_inclusao"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.AUDT_dt_inclusao

parm(7).Campo = "@AUDT_nm_usuario_inclusao"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(8).Campo = "@AUDT_dt_alteracao"
parm(8).Tipo = SqlDbType.datetime
parm(8).Conteudo = pDTO.AUDT_dt_alteracao

parm(9).Campo = "@AUDT_nm_usuario_alteracao"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_PSUB_processo_substancia"
            Dim parm(9) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@SUBS_nm_substancia"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.SUBS_nm_substancia

parm(2).Campo = "@TUSO_nm_uso"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.TUSO_nm_uso

parm(3).Campo = "@PSUB_dt_inicio"
parm(3).Tipo = SqlDbType.date
parm(3).Conteudo = pDTO.PSUB_dt_inicio

parm(4).Campo = "@PSUB_dt_fim"
parm(4).Tipo = SqlDbType.date
parm(4).Conteudo = pDTO.PSUB_dt_fim

parm(5).Campo = "@PSUB_ds_motivo"
parm(5).Tipo = SqlDbType.varchar
parm(5).Conteudo = pDTO.PSUB_ds_motivo

parm(6).Campo = "@AUDT_dt_inclusao"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.AUDT_dt_inclusao

parm(7).Campo = "@AUDT_nm_usuario_inclusao"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(8).Campo = "@AUDT_dt_alteracao"
parm(8).Tipo = SqlDbType.datetime
parm(8).Conteudo = pDTO.AUDT_dt_alteracao

parm(9).Campo = "@AUDT_nm_usuario_alteracao"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_PSUB_processo_substancia"
            Dim parm(2) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@SUBS_nm_substancia"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.SUBS_nm_substancia

            parm(2).Campo = "@TUSO_nm_uso"
            parm(2).Tipo = SqlDbType.VarChar
            parm(2).Conteudo = pDTO.TUSO_nm_uso

            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PSUB_processo_substancia_cons"
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