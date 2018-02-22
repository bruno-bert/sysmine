Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_HSAL_historico_alerta
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_HSAL_historico_alerta

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_HSAL_historico_alerta)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_HSAL_historico_alerta"
            Dim parm(0) As Parametros

            parm(0).Campo = "@HSAL_id_historico"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.HSAL_id_historico



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_HSAL_historico_alerta_rel"
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

parm(6).Campo = "@HSAL_id_historico"
parm(6).Tipo = SqlDbType.int
parm(6).Conteudo = pDTO.HSAL_id_historico

parm(7).Campo = "@HSAL_ds_email"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.HSAL_ds_email

parm(8).Campo = "@ALER_nm_alerta"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.ALER_nm_alerta

parm(9).Campo = "@PROC_cd_processo"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PROC_cd_processo

parm(10).Campo = "@HSAL_dt_envio"
parm(10).Tipo = SqlDbType.datetime
parm(10).Conteudo = pDTO.HSAL_dt_envio

parm(11).Campo = "@HSAL_dt_tentativa_ultimo_envio"
parm(11).Tipo = SqlDbType.datetime
parm(11).Conteudo = pDTO.HSAL_dt_tentativa_ultimo_envio

parm(12).Campo = "@HSAL_fl_status"
parm(12).Tipo = SqlDbType.char
parm(12).Conteudo = pDTO.HSAL_fl_status



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_HSAL_historico_alerta"
            Dim parm(11) As Parametros

            parm(0).Campo = "@HSAL_id_historico"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.HSAL_id_historico

parm(1).Campo = "@HSAL_ds_email"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.HSAL_ds_email

parm(2).Campo = "@ALER_nm_alerta"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.ALER_nm_alerta

parm(3).Campo = "@PROC_cd_processo"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.PROC_cd_processo

parm(4).Campo = "@HSAL_ds_assunto_email"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.HSAL_ds_assunto_email

parm(5).Campo = "@HSAL_ds_texto_email"
parm(5).Tipo = SqlDbType.varchar
parm(5).Conteudo = pDTO.HSAL_ds_texto_email

parm(6).Campo = "@HSAL_dt_envio"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.HSAL_dt_envio

parm(7).Campo = "@HSAL_dt_tentativa_ultimo_envio"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.HSAL_dt_tentativa_ultimo_envio

parm(8).Campo = "@HSAL_ds_mensagem"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.HSAL_ds_mensagem

parm(9).Campo = "@HSAL_fl_status"
parm(9).Tipo = SqlDbType.char
parm(9).Conteudo = pDTO.HSAL_fl_status

parm(10).Campo = "@AUDT_dt_inclusao"
parm(10).Tipo = SqlDbType.datetime
parm(10).Conteudo = pDTO.AUDT_dt_inclusao

parm(11).Campo = "@AUDT_nm_usuario_inclusao"
parm(11).Tipo = SqlDbType.varchar
parm(11).Conteudo = pDTO.AUDT_nm_usuario_inclusao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_HSAL_historico_alerta"
            Dim parm(11) As Parametros

            parm(0).Campo = "@HSAL_id_historico"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.HSAL_id_historico

parm(1).Campo = "@HSAL_ds_email"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.HSAL_ds_email

parm(2).Campo = "@ALER_nm_alerta"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.ALER_nm_alerta

parm(3).Campo = "@PROC_cd_processo"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.PROC_cd_processo

parm(4).Campo = "@HSAL_ds_assunto_email"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.HSAL_ds_assunto_email

parm(5).Campo = "@HSAL_ds_texto_email"
parm(5).Tipo = SqlDbType.varchar
parm(5).Conteudo = pDTO.HSAL_ds_texto_email

parm(6).Campo = "@HSAL_dt_envio"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.HSAL_dt_envio

parm(7).Campo = "@HSAL_dt_tentativa_ultimo_envio"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.HSAL_dt_tentativa_ultimo_envio

parm(8).Campo = "@HSAL_ds_mensagem"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.HSAL_ds_mensagem

parm(9).Campo = "@HSAL_fl_status"
parm(9).Tipo = SqlDbType.char
parm(9).Conteudo = pDTO.HSAL_fl_status

parm(10).Campo = "@AUDT_dt_inclusao"
parm(10).Tipo = SqlDbType.datetime
parm(10).Conteudo = pDTO.AUDT_dt_inclusao

parm(11).Campo = "@AUDT_nm_usuario_inclusao"
parm(11).Tipo = SqlDbType.varchar
parm(11).Conteudo = pDTO.AUDT_nm_usuario_inclusao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_HSAL_historico_alerta"
            Dim parm(0) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@HSAL_id_historico"
parm(0).Tipo = SqlDbType.int
parm(0).Conteudo = pDTO.HSAL_id_historico



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_HSAL_historico_alerta_cons"
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