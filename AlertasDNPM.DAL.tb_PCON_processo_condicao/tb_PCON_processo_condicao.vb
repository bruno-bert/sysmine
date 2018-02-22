Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_PCON_processo_condicao
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_PCON_processo_condicao

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_PCON_processo_condicao)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PCON_processo_condicao"
            Dim parm(2) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@PCON_cd_condicao"
parm(1).Tipo = SqlDbType.int
parm(1).Conteudo = pDTO.PCON_cd_condicao

parm(2).Campo = "@COND_nm_condicao"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.COND_nm_condicao



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PCON_processo_condicao_rel"
            Dim parm(9) As Parametros

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

parm(7).Campo = "@PCON_cd_condicao"
parm(7).Tipo = SqlDbType.int
parm(7).Conteudo = pDTO.PCON_cd_condicao

parm(8).Campo = "@COND_nm_condicao"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.COND_nm_condicao

parm(9).Campo = "@SCON_ds_situacao_condicao"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.SCON_ds_situacao_condicao



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_PCON_processo_condicao"
            Dim parm(14) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@PCON_cd_condicao"
parm(1).Tipo = SqlDbType.int
parm(1).Conteudo = pDTO.PCON_cd_condicao

parm(2).Campo = "@COND_nm_condicao"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.COND_nm_condicao

parm(3).Campo = "@SCON_ds_situacao_condicao"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.SCON_ds_situacao_condicao

parm(4).Campo = "@PCON_ds_condicao"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.PCON_ds_condicao

parm(5).Campo = "@PCON_dt_ini"
parm(5).Tipo = SqlDbType.datetime
parm(5).Conteudo = pDTO.PCON_dt_ini

parm(6).Campo = "@PCON_dt_fim"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.PCON_dt_fim

parm(7).Campo = "@PCON_ds_nome_documento"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.PCON_ds_nome_documento

parm(8).Campo = "@PCON_ds_local_documento"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.PCON_ds_local_documento

parm(9).Campo = "@PCON_ds_rede_documento"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PCON_ds_rede_documento

parm(10).Campo = "@PCON_ds_path_documento"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.PCON_ds_path_documento

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

            Dim procName As String = "sp_ins_tb_PCON_processo_condicao"
            Dim parm(14) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@PCON_cd_condicao"
parm(1).Tipo = SqlDbType.int
parm(1).Conteudo = pDTO.PCON_cd_condicao

parm(2).Campo = "@COND_nm_condicao"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.COND_nm_condicao

parm(3).Campo = "@SCON_ds_situacao_condicao"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.SCON_ds_situacao_condicao

parm(4).Campo = "@PCON_ds_condicao"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.PCON_ds_condicao

parm(5).Campo = "@PCON_dt_ini"
parm(5).Tipo = SqlDbType.datetime
parm(5).Conteudo = pDTO.PCON_dt_ini

parm(6).Campo = "@PCON_dt_fim"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.PCON_dt_fim

parm(7).Campo = "@PCON_ds_nome_documento"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.PCON_ds_nome_documento

parm(8).Campo = "@PCON_ds_local_documento"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.PCON_ds_local_documento

parm(9).Campo = "@PCON_ds_rede_documento"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PCON_ds_rede_documento

parm(10).Campo = "@PCON_ds_path_documento"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.PCON_ds_path_documento

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

            Dim procName As String = "sp_del_tb_PCON_processo_condicao"
            Dim parm(2) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@PCON_cd_condicao"
parm(1).Tipo = SqlDbType.int
parm(1).Conteudo = pDTO.PCON_cd_condicao

parm(2).Campo = "@COND_nm_condicao"
parm(2).Tipo = SqlDbType.varchar
parm(2).Conteudo = pDTO.COND_nm_condicao



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PCON_processo_condicao_cons"
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