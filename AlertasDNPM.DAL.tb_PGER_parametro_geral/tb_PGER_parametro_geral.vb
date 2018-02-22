Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_PGER_parametro_geral
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_PGER_parametro_geral

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_PGER_parametro_geral)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PGER_parametro_geral"
            Dim parm(0) As Parametros

            parm(0).Campo = "@PGER_cd_parametro"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PGER_cd_parametro



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PGER_parametro_geral_rel"
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

parm(6).Campo = "@PGER_cd_parametro"
parm(6).Tipo = SqlDbType.varchar
parm(6).Conteudo = pDTO.PGER_cd_parametro

parm(7).Campo = "@PGER_fl_tipo"
parm(7).Tipo = SqlDbType.char
parm(7).Conteudo = pDTO.PGER_fl_tipo

parm(8).Campo = "@PGER_fl_sistema"
parm(8).Tipo = SqlDbType.char
parm(8).Conteudo = pDTO.PGER_fl_sistema



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_PGER_parametro_geral"
            Dim parm(14) As Parametros

            parm(0).Campo = "@PGER_cd_parametro"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PGER_cd_parametro

parm(1).Campo = "@PGER_ds_parametro"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.PGER_ds_parametro

parm(2).Campo = "@PGER_vl_parametro"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.PGER_vl_parametro

parm(3).Campo = "@PGER_fl_tipo"
parm(3).Tipo = SqlDbType.char
parm(3).Conteudo = pDTO.PGER_fl_tipo

parm(4).Campo = "@PGER_fl_sistema"
parm(4).Tipo = SqlDbType.char
parm(4).Conteudo = pDTO.PGER_fl_sistema

parm(5).Campo = "@PGER_vl_range_min"
parm(5).Tipo = SqlDbType.bigint
parm(5).Conteudo = pDTO.PGER_vl_range_min

parm(6).Campo = "@PGER_vl_range_max"
parm(6).Tipo = SqlDbType.bigint
parm(6).Conteudo = pDTO.PGER_vl_range_max

parm(7).Campo = "@PGER_vl_padrao"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.PGER_vl_padrao

parm(8).Campo = "@PGER_vl_tamanho_min"
parm(8).Tipo = SqlDbType.int
parm(8).Conteudo = pDTO.PGER_vl_tamanho_min

parm(9).Campo = "@PGER_vl_tamanho_max"
parm(9).Tipo = SqlDbType.int
parm(9).Conteudo = pDTO.PGER_vl_tamanho_max

parm(10).Campo = "@PGER_vl_valores_permitidos"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.PGER_vl_valores_permitidos

parm(11).Campo = "@AUDT_dt_inclusao"
parm(11).Tipo = SqlDbType.datetime
parm(11).Conteudo = pDTO.AUDT_dt_inclusao

parm(12).Campo = "@AUDT_nm_usuario_inclusao"
parm(12).Tipo = SqlDbType.varchar
parm(12).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(13).Campo = "@AUDT_dt_alteracao"
parm(13).Tipo = SqlDbType.datetime
parm(13).Conteudo = pDTO.AUDT_dt_alteracao

parm(14).Campo = "@AUDT_nm_usuario_alteracao"
parm(14).Tipo = SqlDbType.varchar
parm(14).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_PGER_parametro_geral"
            Dim parm(14) As Parametros

            parm(0).Campo = "@PGER_cd_parametro"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PGER_cd_parametro

parm(1).Campo = "@PGER_ds_parametro"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.PGER_ds_parametro

parm(2).Campo = "@PGER_vl_parametro"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.PGER_vl_parametro

parm(3).Campo = "@PGER_fl_tipo"
parm(3).Tipo = SqlDbType.char
parm(3).Conteudo = pDTO.PGER_fl_tipo

parm(4).Campo = "@PGER_fl_sistema"
parm(4).Tipo = SqlDbType.char
parm(4).Conteudo = pDTO.PGER_fl_sistema

parm(5).Campo = "@PGER_vl_range_min"
parm(5).Tipo = SqlDbType.bigint
parm(5).Conteudo = pDTO.PGER_vl_range_min

parm(6).Campo = "@PGER_vl_range_max"
parm(6).Tipo = SqlDbType.bigint
parm(6).Conteudo = pDTO.PGER_vl_range_max

parm(7).Campo = "@PGER_vl_padrao"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.PGER_vl_padrao

parm(8).Campo = "@PGER_vl_tamanho_min"
parm(8).Tipo = SqlDbType.int
parm(8).Conteudo = pDTO.PGER_vl_tamanho_min

parm(9).Campo = "@PGER_vl_tamanho_max"
parm(9).Tipo = SqlDbType.int
parm(9).Conteudo = pDTO.PGER_vl_tamanho_max

parm(10).Campo = "@PGER_vl_valores_permitidos"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.PGER_vl_valores_permitidos

parm(11).Campo = "@AUDT_dt_inclusao"
parm(11).Tipo = SqlDbType.datetime
parm(11).Conteudo = pDTO.AUDT_dt_inclusao

parm(12).Campo = "@AUDT_nm_usuario_inclusao"
parm(12).Tipo = SqlDbType.varchar
parm(12).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(13).Campo = "@AUDT_dt_alteracao"
parm(13).Tipo = SqlDbType.datetime
parm(13).Conteudo = pDTO.AUDT_dt_alteracao

parm(14).Campo = "@AUDT_nm_usuario_alteracao"
parm(14).Tipo = SqlDbType.varchar
parm(14).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_PGER_parametro_geral"
            Dim parm(0) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@PGER_cd_parametro"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PGER_cd_parametro



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PGER_parametro_geral_cons"
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