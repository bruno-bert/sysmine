Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_PINF_processo_info
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_PINF_processo_info

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_PINF_processo_info)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PINF_processo_info"
            Dim parm(2) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@PINF_cd_info"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PINF_cd_info



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PINF_processo_info_rel"
            Dim parm(11) As Parametros

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

parm(8).Campo = "@PINF_cd_info"
parm(8).Tipo = SqlDbType.int
parm(8).Conteudo = pDTO.PINF_cd_info

parm(9).Campo = "@PINF_ds_info"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PINF_ds_info

parm(10).Campo = "@TINF_nm_tipo_info"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.TINF_nm_tipo_info

parm(11).Campo = "@SINF_ds_situacao_info"
parm(11).Tipo = SqlDbType.varchar
parm(11).Conteudo = pDTO.SINF_ds_situacao_info



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_PINF_processo_info"
            Dim parm(14) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@PINF_cd_info"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PINF_cd_info

parm(3).Campo = "@PINF_ds_info"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.PINF_ds_info

parm(4).Campo = "@TINF_nm_tipo_info"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.TINF_nm_tipo_info

parm(5).Campo = "@SINF_ds_situacao_info"
parm(5).Tipo = SqlDbType.varchar
parm(5).Conteudo = pDTO.SINF_ds_situacao_info

parm(6).Campo = "@PINF_dt_ini"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.PINF_dt_ini

parm(7).Campo = "@PINF_dt_fim"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.PINF_dt_fim

parm(8).Campo = "@PINF_ds_local_documento"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.PINF_ds_local_documento

parm(9).Campo = "@PINF_ds_rede_documento"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PINF_ds_rede_documento

parm(10).Campo = "@PINF_ds_path_documento"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.PINF_ds_path_documento

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

            Dim procName As String = "sp_ins_tb_PINF_processo_info"
            Dim parm(14) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@PINF_cd_info"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PINF_cd_info

parm(3).Campo = "@PINF_ds_info"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.PINF_ds_info

parm(4).Campo = "@TINF_nm_tipo_info"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.TINF_nm_tipo_info

parm(5).Campo = "@SINF_ds_situacao_info"
parm(5).Tipo = SqlDbType.varchar
parm(5).Conteudo = pDTO.SINF_ds_situacao_info

parm(6).Campo = "@PINF_dt_ini"
parm(6).Tipo = SqlDbType.datetime
parm(6).Conteudo = pDTO.PINF_dt_ini

parm(7).Campo = "@PINF_dt_fim"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.PINF_dt_fim

parm(8).Campo = "@PINF_ds_local_documento"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.PINF_ds_local_documento

parm(9).Campo = "@PINF_ds_rede_documento"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PINF_ds_rede_documento

parm(10).Campo = "@PINF_ds_path_documento"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.PINF_ds_path_documento

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

            Dim procName As String = "sp_del_tb_PINF_processo_info"
            Dim parm(2) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@PINF_cd_info"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PINF_cd_info



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PINF_processo_info_cons"
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