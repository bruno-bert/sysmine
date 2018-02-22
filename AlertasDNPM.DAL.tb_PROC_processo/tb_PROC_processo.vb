Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_PROC_processo
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_PROC_processo

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_PROC_processo)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function getDocuments() As DataTable
        Try

            Dim procName As String = "sp_sel_documentos_relatorio"
            Dim parm(11) As Parametros

            parm(0).Campo = "@PROC_ls_processo"
            parm(0).Tipo = SqlDbType.VarChar
            parm(0).Conteudo = pDTO.PROC_ls_processo

            parm(1).Campo = "@PROC_ds_titular"
            parm(1).Tipo = SqlDbType.VarChar
            parm(1).Conteudo = pDTO.PROC_ds_titular

            parm(2).Campo = "@PROC_ls_documento"
            parm(2).Tipo = SqlDbType.VarChar
            parm(2).Conteudo = pDTO.PROC_ls_documento

            parm(3).Campo = "@ORGA_nm_orgao"
            parm(3).Tipo = SqlDbType.VarChar
            parm(3).Conteudo = pDTO.ORGA_nm_orgao

            parm(4).Campo = "@PROC_qt_dias_vencer"
            parm(4).Tipo = SqlDbType.Int
            parm(4).Conteudo = pDTO.PROC_qt_dias_vencer

            parm(5).Campo = "@PROC_ls_tipo"
            parm(5).Tipo = SqlDbType.VarChar
            parm(5).Conteudo = pDTO.PROC_ls_tipo

            parm(6).Campo = "@PROC_dt_publicacao_ini"
            parm(6).Tipo = SqlDbType.DateTime
            parm(6).Conteudo = pDTO.PROC_dt_publicacao_ini

            parm(7).Campo = "@PROC_dt_publicacao_fim"
            parm(7).Tipo = SqlDbType.DateTime
            parm(7).Conteudo = pDTO.PROC_dt_publicacao_fim

            parm(8).Campo = "@PROC_dt_vencimento_ini"
            parm(8).Tipo = SqlDbType.DateTime
            parm(8).Conteudo = pDTO.PROC_dt_vencimento_ini

            parm(9).Campo = "@PROC_dt_vencimento_fim"
            parm(9).Tipo = SqlDbType.DateTime
            parm(9).Conteudo = pDTO.PROC_dt_vencimento_fim

            parm(10).Campo = "@PROC_ls_titular"
            parm(10).Tipo = SqlDbType.VarChar
            parm(10).Conteudo = pDTO.PROC_ls_titular

            parm(11).Campo = "@PROC_ls_fase"
            parm(11).Tipo = SqlDbType.VarChar
            parm(11).Conteudo = pDTO.PROC_ls_fase

            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function getExpirateDocuments() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PROC_processo_documents"
            Dim parm(0) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
            parm(0).Tipo = SqlDbType.VarChar
            parm(0).Conteudo = pDTO.PROC_cd_processo



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function getEventos() As DataTable
        Try

            Dim procName As String = "sp_sel_eventos"
            Return objBanco.SelectDataTable(procName, CommandType.StoredProcedure)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PROC_processo"
            Dim parm(0) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PROC_processo_rel"
            Dim parm(14) As Parametros

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

parm(7).Campo = "@PROC_ds_titular"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.PROC_ds_titular

parm(8).Campo = "@PROC_vl_ano"
parm(8).Tipo = SqlDbType.int
parm(8).Conteudo = pDTO.PROC_vl_ano

parm(9).Campo = "@PROC_nm_processo"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PROC_nm_processo

parm(10).Campo = "@FASE_cd_fase"
parm(10).Tipo = SqlDbType.int
parm(10).Conteudo = pDTO.FASE_cd_fase

parm(11).Campo = "@PROC_ds_ultimo_evento"
parm(11).Tipo = SqlDbType.varchar
parm(11).Conteudo = pDTO.PROC_ds_ultimo_evento

parm(12).Campo = "@PROC_ds_substancia"
parm(12).Tipo = SqlDbType.varchar
parm(12).Conteudo = pDTO.PROC_ds_substancia

parm(13).Campo = "@PROC_ds_area"
parm(13).Tipo = SqlDbType.varchar
parm(13).Conteudo = pDTO.PROC_ds_area

parm(14).Campo = "@PROC_ds_uso"
parm(14).Tipo = SqlDbType.varchar
parm(14).Conteudo = pDTO.PROC_ds_uso



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

    <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function getRelatorioLista() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PROC_processo_lista"
            Dim parm(1) As Parametros

            parm(0).Campo = "@PROC_ls_titular"
            parm(0).Tipo = SqlDbType.VarChar
            parm(0).Conteudo = pDTO.PROC_ls_titular

            parm(1).Campo = "@PROC_ls_fase"
            parm(1).Tipo = SqlDbType.VarChar
            parm(1).Conteudo = pDTO.PROC_ls_fase




            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function

<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_PROC_processo"
            Dim parm(17) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@PROC_ds_titular"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.PROC_ds_titular

parm(2).Campo = "@PROC_vl_ano"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PROC_vl_ano

parm(3).Campo = "@PROC_nm_processo"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.PROC_nm_processo

parm(4).Campo = "@PROC_id_processo"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.PROC_id_processo

parm(5).Campo = "@FASE_cd_fase"
parm(5).Tipo = SqlDbType.int
parm(5).Conteudo = pDTO.FASE_cd_fase

parm(6).Campo = "@PROC_ds_ultimo_evento"
parm(6).Tipo = SqlDbType.varchar
parm(6).Conteudo = pDTO.PROC_ds_ultimo_evento

parm(7).Campo = "@PROC_ds_substancia"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.PROC_ds_substancia

parm(8).Campo = "@PROC_ds_area"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.PROC_ds_area

parm(9).Campo = "@PROC_ds_uso"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PROC_ds_uso

parm(10).Campo = "@PROC_ds_link"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.PROC_ds_link

parm(11).Campo = "@UNFE_cd_unidade_federativa"
parm(11).Tipo = SqlDbType.char
parm(11).Conteudo = pDTO.UNFE_cd_unidade_federativa

parm(12).Campo = "@PROC_fl_tipo_inclusao"
parm(12).Tipo = SqlDbType.char
parm(12).Conteudo = pDTO.PROC_fl_tipo_inclusao

parm(13).Campo = "@AUDT_dt_inclusao"
parm(13).Tipo = SqlDbType.datetime
parm(13).Conteudo = pDTO.AUDT_dt_inclusao

parm(14).Campo = "@AUDT_nm_usuario_inclusao"
parm(14).Tipo = SqlDbType.varchar
parm(14).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(15).Campo = "@AUDT_dt_alteracao"
parm(15).Tipo = SqlDbType.datetime
parm(15).Conteudo = pDTO.AUDT_dt_alteracao

parm(16).Campo = "@AUDT_nm_usuario_alteracao"
parm(16).Tipo = SqlDbType.varchar
parm(16).Conteudo = pDTO.AUDT_nm_usuario_alteracao


            parm(17).Campo = "@PROC_cd_prioridade"
            parm(17).Tipo = SqlDbType.VarChar
            parm(17).Conteudo = pDTO.PROC_cd_prioridade

            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_PROC_processo"
            Dim parm(17) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@PROC_ds_titular"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.PROC_ds_titular

parm(2).Campo = "@PROC_vl_ano"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PROC_vl_ano

parm(3).Campo = "@PROC_nm_processo"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.PROC_nm_processo

parm(4).Campo = "@PROC_id_processo"
parm(4).Tipo = SqlDbType.varchar
parm(4).Conteudo = pDTO.PROC_id_processo

parm(5).Campo = "@FASE_cd_fase"
parm(5).Tipo = SqlDbType.int
parm(5).Conteudo = pDTO.FASE_cd_fase

parm(6).Campo = "@PROC_ds_ultimo_evento"
parm(6).Tipo = SqlDbType.varchar
parm(6).Conteudo = pDTO.PROC_ds_ultimo_evento

parm(7).Campo = "@PROC_ds_substancia"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.PROC_ds_substancia

parm(8).Campo = "@PROC_ds_area"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.PROC_ds_area

parm(9).Campo = "@PROC_ds_uso"
parm(9).Tipo = SqlDbType.varchar
parm(9).Conteudo = pDTO.PROC_ds_uso

parm(10).Campo = "@PROC_ds_link"
parm(10).Tipo = SqlDbType.varchar
parm(10).Conteudo = pDTO.PROC_ds_link

parm(11).Campo = "@UNFE_cd_unidade_federativa"
parm(11).Tipo = SqlDbType.char
parm(11).Conteudo = pDTO.UNFE_cd_unidade_federativa

parm(12).Campo = "@PROC_fl_tipo_inclusao"
parm(12).Tipo = SqlDbType.char
parm(12).Conteudo = pDTO.PROC_fl_tipo_inclusao

parm(13).Campo = "@AUDT_dt_inclusao"
parm(13).Tipo = SqlDbType.datetime
parm(13).Conteudo = pDTO.AUDT_dt_inclusao

parm(14).Campo = "@AUDT_nm_usuario_inclusao"
parm(14).Tipo = SqlDbType.varchar
parm(14).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(15).Campo = "@AUDT_dt_alteracao"
parm(15).Tipo = SqlDbType.datetime
parm(15).Conteudo = pDTO.AUDT_dt_alteracao

parm(16).Campo = "@AUDT_nm_usuario_alteracao"
parm(16).Tipo = SqlDbType.varchar
parm(16).Conteudo = pDTO.AUDT_nm_usuario_alteracao

            parm(17).Campo = "@PROC_cd_prioridade"
            parm(17).Tipo = SqlDbType.VarChar
            parm(17).Conteudo = pDTO.PROC_cd_prioridade

            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_PROC_processo"
            Dim parm(0) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PROC_processo_cons"
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