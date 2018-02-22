Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_ROTI_rotina
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_ROTI_rotina

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_ROTI_rotina)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_ROTI_rotina"
            Dim parm(0) As Parametros

            parm(0).Campo = "@ROTI_nm_rotina"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.ROTI_nm_rotina



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_ROTI_rotina_rel"
            Dim parm(10) As Parametros

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

parm(6).Campo = "@ROTI_nm_rotina"
parm(6).Tipo = SqlDbType.varchar
parm(6).Conteudo = pDTO.ROTI_nm_rotina

parm(7).Campo = "@ROTI_ds_rotina"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.ROTI_ds_rotina

parm(8).Campo = "@ROTI_dt_ultima_execucao"
parm(8).Tipo = SqlDbType.datetime
parm(8).Conteudo = pDTO.ROTI_dt_ultima_execucao

parm(9).Campo = "@ROTI_dt_ultima_tentativa_execucao"
parm(9).Tipo = SqlDbType.datetime
parm(9).Conteudo = pDTO.ROTI_dt_ultima_tentativa_execucao

parm(10).Campo = "@ROTI_fl_status_execucao"
parm(10).Tipo = SqlDbType.char
parm(10).Conteudo = pDTO.ROTI_fl_status_execucao



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_ROTI_rotina"
            Dim parm(11) As Parametros

            parm(0).Campo = "@ROTI_nm_rotina"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.ROTI_nm_rotina

parm(1).Campo = "@ROTI_ds_rotina"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ROTI_ds_rotina

parm(2).Campo = "@ROTI_dt_ultima_execucao"
parm(2).Tipo = SqlDbType.datetime
parm(2).Conteudo = pDTO.ROTI_dt_ultima_execucao

parm(3).Campo = "@ROTI_dt_ultima_tentativa_execucao"
parm(3).Tipo = SqlDbType.datetime
parm(3).Conteudo = pDTO.ROTI_dt_ultima_tentativa_execucao

parm(4).Campo = "@ROTI_fl_status_execucao"
parm(4).Tipo = SqlDbType.char
parm(4).Conteudo = pDTO.ROTI_fl_status_execucao

parm(5).Campo = "@ROTI_ds_mensagem"
parm(5).Tipo = SqlDbType.varchar
parm(5).Conteudo = pDTO.ROTI_ds_mensagem

parm(6).Campo = "@ROTI_vl_tempo_medio"
parm(6).Tipo = SqlDbType.decimal
parm(6).Conteudo = pDTO.ROTI_vl_tempo_medio

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

            parm(11).Campo = "@ROTI_dt_inicio_execucao"
            parm(11).Tipo = SqlDbType.DateTime
            parm(11).Conteudo = pDTO.ROTI_dt_inicio_execucao

            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_ROTI_rotina"
            Dim parm(11) As Parametros

            parm(0).Campo = "@ROTI_nm_rotina"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.ROTI_nm_rotina

parm(1).Campo = "@ROTI_ds_rotina"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ROTI_ds_rotina

parm(2).Campo = "@ROTI_dt_ultima_execucao"
parm(2).Tipo = SqlDbType.datetime
parm(2).Conteudo = pDTO.ROTI_dt_ultima_execucao

parm(3).Campo = "@ROTI_dt_ultima_tentativa_execucao"
parm(3).Tipo = SqlDbType.datetime
parm(3).Conteudo = pDTO.ROTI_dt_ultima_tentativa_execucao

parm(4).Campo = "@ROTI_fl_status_execucao"
parm(4).Tipo = SqlDbType.char
parm(4).Conteudo = pDTO.ROTI_fl_status_execucao

parm(5).Campo = "@ROTI_ds_mensagem"
parm(5).Tipo = SqlDbType.varchar
parm(5).Conteudo = pDTO.ROTI_ds_mensagem

parm(6).Campo = "@ROTI_vl_tempo_medio"
parm(6).Tipo = SqlDbType.decimal
parm(6).Conteudo = pDTO.ROTI_vl_tempo_medio

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

            parm(11).Campo = "@ROTI_dt_inicio_execucao"
            parm(11).Tipo = SqlDbType.VarChar
            parm(11).Conteudo = pDTO.ROTI_dt_inicio_execucao


            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_ROTI_rotina"
            Dim parm(0) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@ROTI_nm_rotina"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.ROTI_nm_rotina



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_ROTI_rotina_cons"
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