Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_BACK_backup
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_BACK_backup

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_BACK_backup)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_BACK_backup"
            Dim parm(0) As Parametros

            parm(0).Campo = "@BACK_cd_backup"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.BACK_cd_backup



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_BACK_backup_rel"
            Dim parm(15) As Parametros

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

parm(6).Campo = "@BACK_cd_backup"
parm(6).Tipo = SqlDbType.int
parm(6).Conteudo = pDTO.BACK_cd_backup

parm(7).Campo = "@BACK_vl_intervalo"
parm(7).Tipo = SqlDbType.int
parm(7).Conteudo = pDTO.BACK_vl_intervalo

parm(8).Campo = "@BACK_nm_arquivo"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.BACK_nm_arquivo

parm(9).Campo = "@BACK_fl_execucao"
parm(9).Tipo = SqlDbType.char
parm(9).Conteudo = pDTO.BACK_fl_execucao

parm(10).Campo = "@BACK_ds_mensagem"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.BACK_ds_mensagem

parm(11).Campo = "@BACK_dt_execucao"
parm(11).Tipo = SqlDbType.datetime
parm(11).Conteudo = pDTO.BACK_dt_execucao

parm(12).Campo = "@BACK_dt_tentativa_Execucao"
parm(12).Tipo = SqlDbType.datetime
parm(12).Conteudo = pDTO.BACK_dt_tentativa_Execucao

parm(13).Campo = "@BACK_dt_backup"
parm(13).Tipo = SqlDbType.datetime
parm(13).Conteudo = pDTO.BACK_dt_backup

parm(14).Campo = "@BACK_dt_sincronizacao"
parm(14).Tipo = SqlDbType.datetime
parm(14).Conteudo = pDTO.BACK_dt_sincronizacao

parm(15).Campo = "@BACK_fl_tipo"
parm(15).Tipo = SqlDbType.char
parm(15).Conteudo = pDTO.BACK_fl_tipo



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_BACK_backup"
            Dim parm(13) As Parametros

            parm(0).Campo = "@BACK_cd_backup"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.BACK_cd_backup

parm(1).Campo = "@BACK_vl_intervalo"
parm(1).Tipo = SqlDbType.int
parm(1).Conteudo = pDTO.BACK_vl_intervalo

parm(2).Campo = "@BACK_nm_arquivo"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.BACK_nm_arquivo

parm(3).Campo = "@BACK_fl_execucao"
parm(3).Tipo = SqlDbType.char
parm(3).Conteudo = pDTO.BACK_fl_execucao

parm(4).Campo = "@BACK_ds_mensagem"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.BACK_ds_mensagem

parm(5).Campo = "@BACK_dt_execucao"
parm(5).Tipo = SqlDbType.datetime
parm(5).Conteudo = pDTO.BACK_dt_execucao

parm(6).Campo = "@BACK_dt_tentativa_Execucao"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.BACK_dt_tentativa_Execucao

parm(7).Campo = "@BACK_dt_backup"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.BACK_dt_backup

parm(8).Campo = "@BACK_dt_sincronizacao"
parm(8).Tipo = SqlDbType.datetime
parm(8).Conteudo = pDTO.BACK_dt_sincronizacao

parm(9).Campo = "@BACK_fl_tipo"
parm(9).Tipo = SqlDbType.char
parm(9).Conteudo = pDTO.BACK_fl_tipo

parm(10).Campo = "@AUDT_dt_inclusao"
parm(10).Tipo = SqlDbType.datetime
parm(10).Conteudo = pDTO.AUDT_dt_inclusao

parm(11).Campo = "@AUDT_nm_usuario_inclusao"
parm(11).Tipo = SqlDbType.varchar
parm(11).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(12).Campo = "@AUDT_dt_alteracao"
parm(12).Tipo = SqlDbType.datetime
parm(12).Conteudo = pDTO.AUDT_dt_alteracao

parm(13).Campo = "@AUDT_nm_usuario_alteracao"
parm(13).Tipo = SqlDbType.varchar
parm(13).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_BACK_backup"
            Dim parm(13) As Parametros

            parm(0).Campo = "@BACK_cd_backup"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.BACK_cd_backup

parm(1).Campo = "@BACK_vl_intervalo"
parm(1).Tipo = SqlDbType.int
parm(1).Conteudo = pDTO.BACK_vl_intervalo

parm(2).Campo = "@BACK_nm_arquivo"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.BACK_nm_arquivo

parm(3).Campo = "@BACK_fl_execucao"
parm(3).Tipo = SqlDbType.char
parm(3).Conteudo = pDTO.BACK_fl_execucao

parm(4).Campo = "@BACK_ds_mensagem"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.BACK_ds_mensagem

parm(5).Campo = "@BACK_dt_execucao"
parm(5).Tipo = SqlDbType.datetime
parm(5).Conteudo = pDTO.BACK_dt_execucao

parm(6).Campo = "@BACK_dt_tentativa_Execucao"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.BACK_dt_tentativa_Execucao

parm(7).Campo = "@BACK_dt_backup"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.BACK_dt_backup

parm(8).Campo = "@BACK_dt_sincronizacao"
parm(8).Tipo = SqlDbType.datetime
parm(8).Conteudo = pDTO.BACK_dt_sincronizacao

parm(9).Campo = "@BACK_fl_tipo"
parm(9).Tipo = SqlDbType.char
parm(9).Conteudo = pDTO.BACK_fl_tipo

parm(10).Campo = "@AUDT_dt_inclusao"
parm(10).Tipo = SqlDbType.datetime
parm(10).Conteudo = pDTO.AUDT_dt_inclusao

parm(11).Campo = "@AUDT_nm_usuario_inclusao"
parm(11).Tipo = SqlDbType.varchar
parm(11).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(12).Campo = "@AUDT_dt_alteracao"
parm(12).Tipo = SqlDbType.datetime
parm(12).Conteudo = pDTO.AUDT_dt_alteracao

parm(13).Campo = "@AUDT_nm_usuario_alteracao"
parm(13).Tipo = SqlDbType.varchar
parm(13).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_BACK_backup"
            Dim parm(0) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@BACK_cd_backup"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.BACK_cd_backup



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_BACK_backup_cons"
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