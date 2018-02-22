Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_ALER_alerta
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_ALER_alerta

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_ALER_alerta)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_ALER_alerta"
            Dim parm(0) As Parametros

            parm(0).Campo = "@ALER_nm_alerta"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.ALER_nm_alerta



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_ALER_alerta_rel"
            Dim parm(16) As Parametros

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

parm(6).Campo = "@ALER_nm_alerta"
parm(6).Tipo = SqlDbType.varchar
parm(6).Conteudo = pDTO.ALER_nm_alerta

parm(7).Campo = "@ALER_ds_alerta"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.ALER_ds_alerta

parm(8).Campo = "@ALER_fl_muda_fase"
parm(8).Tipo = SqlDbType.char
parm(8).Conteudo = pDTO.ALER_fl_muda_fase

parm(9).Campo = "@ALER_fl_muda_evento"
parm(9).Tipo = SqlDbType.char
parm(9).Conteudo = pDTO.ALER_fl_muda_evento

parm(10).Campo = "@ALER_cd_fase_anterior"
parm(10).Tipo = SqlDbType.int
parm(10).Conteudo = pDTO.ALER_cd_fase_anterior

parm(11).Campo = "@ALER_cd_fase_nova"
parm(11).Tipo = SqlDbType.int
parm(11).Conteudo = pDTO.ALER_cd_fase_nova

parm(12).Campo = "@ALER_fl_qualquer_processo"
parm(12).Tipo = SqlDbType.char
parm(12).Conteudo = pDTO.ALER_fl_qualquer_processo

parm(13).Campo = "@ALER_fl_status"
parm(13).Tipo = SqlDbType.char
parm(13).Conteudo = pDTO.ALER_fl_status

parm(14).Campo = "@ALER_fl_sistema"
parm(14).Tipo = SqlDbType.char
parm(14).Conteudo = pDTO.ALER_fl_sistema

            parm(15).Campo = "@ALER_fl_geral"
            parm(15).Tipo = SqlDbType.Char
            parm(15).Conteudo = pDTO.ALER_fl_geral

            parm(16).Campo = "@ALER_cd_evento"
            parm(16).Tipo = SqlDbType.VarChar
            parm(16).Conteudo = pDTO.ALER_cd_evento

            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_ALER_alerta"
            Dim parm(14) As Parametros

            parm(0).Campo = "@ALER_nm_alerta"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.ALER_nm_alerta

parm(1).Campo = "@ALER_ds_alerta"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ALER_ds_alerta

parm(2).Campo = "@ALER_fl_muda_fase"
parm(2).Tipo = SqlDbType.char
parm(2).Conteudo = pDTO.ALER_fl_muda_fase

parm(3).Campo = "@ALER_fl_muda_evento"
parm(3).Tipo = SqlDbType.char
parm(3).Conteudo = pDTO.ALER_fl_muda_evento

parm(4).Campo = "@ALER_cd_fase_anterior"
parm(4).Tipo = SqlDbType.int
parm(4).Conteudo = pDTO.ALER_cd_fase_anterior

parm(5).Campo = "@ALER_cd_fase_nova"
parm(5).Tipo = SqlDbType.int
parm(5).Conteudo = pDTO.ALER_cd_fase_nova

parm(6).Campo = "@ALER_fl_qualquer_processo"
parm(6).Tipo = SqlDbType.char
parm(6).Conteudo = pDTO.ALER_fl_qualquer_processo

parm(7).Campo = "@ALER_fl_status"
parm(7).Tipo = SqlDbType.char
parm(7).Conteudo = pDTO.ALER_fl_status

parm(8).Campo = "@ALER_fl_sistema"
parm(8).Tipo = SqlDbType.char
parm(8).Conteudo = pDTO.ALER_fl_sistema

parm(9).Campo = "@AUDT_dt_inclusao"
parm(9).Tipo = SqlDbType.datetime
parm(9).Conteudo = pDTO.AUDT_dt_inclusao

parm(10).Campo = "@AUDT_nm_usuario_inclusao"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(11).Campo = "@AUDT_dt_alteracao"
parm(11).Tipo = SqlDbType.datetime
parm(11).Conteudo = pDTO.AUDT_dt_alteracao

parm(12).Campo = "@AUDT_nm_usuario_alteracao"
parm(12).Tipo = SqlDbType.varchar
parm(12).Conteudo = pDTO.AUDT_nm_usuario_alteracao

            parm(13).Campo = "@ALER_fl_geral"
            parm(13).Tipo = SqlDbType.Char
            parm(13).Conteudo = pDTO.ALER_fl_geral

            parm(14).Campo = "@ALER_cd_evento"
            parm(14).Tipo = SqlDbType.VarChar
            parm(14).Conteudo = pDTO.ALER_cd_evento

            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_ALER_alerta"
            Dim parm(14) As Parametros

            parm(0).Campo = "@ALER_nm_alerta"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.ALER_nm_alerta

parm(1).Campo = "@ALER_ds_alerta"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ALER_ds_alerta

parm(2).Campo = "@ALER_fl_muda_fase"
parm(2).Tipo = SqlDbType.char
parm(2).Conteudo = pDTO.ALER_fl_muda_fase

parm(3).Campo = "@ALER_fl_muda_evento"
parm(3).Tipo = SqlDbType.char
parm(3).Conteudo = pDTO.ALER_fl_muda_evento

parm(4).Campo = "@ALER_cd_fase_anterior"
parm(4).Tipo = SqlDbType.int
parm(4).Conteudo = pDTO.ALER_cd_fase_anterior

parm(5).Campo = "@ALER_cd_fase_nova"
parm(5).Tipo = SqlDbType.int
parm(5).Conteudo = pDTO.ALER_cd_fase_nova

parm(6).Campo = "@ALER_fl_qualquer_processo"
parm(6).Tipo = SqlDbType.char
parm(6).Conteudo = pDTO.ALER_fl_qualquer_processo

parm(7).Campo = "@ALER_fl_status"
parm(7).Tipo = SqlDbType.char
parm(7).Conteudo = pDTO.ALER_fl_status

parm(8).Campo = "@ALER_fl_sistema"
parm(8).Tipo = SqlDbType.char
parm(8).Conteudo = pDTO.ALER_fl_sistema

parm(9).Campo = "@AUDT_dt_inclusao"
parm(9).Tipo = SqlDbType.datetime
parm(9).Conteudo = pDTO.AUDT_dt_inclusao

parm(10).Campo = "@AUDT_nm_usuario_inclusao"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(11).Campo = "@AUDT_dt_alteracao"
parm(11).Tipo = SqlDbType.datetime
parm(11).Conteudo = pDTO.AUDT_dt_alteracao

parm(12).Campo = "@AUDT_nm_usuario_alteracao"
parm(12).Tipo = SqlDbType.varchar
parm(12).Conteudo = pDTO.AUDT_nm_usuario_alteracao

            parm(13).Campo = "@ALER_fl_geral"
            parm(13).Tipo = SqlDbType.Char
            parm(13).Conteudo = pDTO.ALER_fl_geral

            parm(14).Campo = "@ALER_cd_evento"
            parm(14).Tipo = SqlDbType.VarChar
            parm(14).Conteudo = pDTO.ALER_cd_evento

            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_ALER_alerta"
            Dim parm(0) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@ALER_nm_alerta"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.ALER_nm_alerta



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_ALER_alerta_cons"
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