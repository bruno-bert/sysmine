Imports System.Data
Imports System.Data.SqlClient
Imports Apoio
Imports Apoio.DALBase

<System.ComponentModel.DataObject()> _
Public Class tb_PNOT_processo_nota
    
    Private objBanco As DALBase
    Private pDTO As DTO.tb_PNOT_processo_nota

    Public Sub New(ByVal ConnectionString As String, ByVal entity As DTO.tb_PNOT_processo_nota)
        objBanco = New DALBase(ConnectionString)
        pDTO = entity
    End Sub

    
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, True)> _
    Public Function GetData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PNOT_processo_nota"
            Dim parm(2) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@PNOT_cd_nota"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PNOT_cd_nota



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function PagingData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PNOT_processo_nota_rel"
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

parm(7).Campo = "@ORGA_nm_orgao"
parm(7).Tipo = SqlDbType.varchar
parm(7).Conteudo = pDTO.ORGA_nm_orgao

parm(8).Campo = "@PNOT_cd_nota"
parm(8).Tipo = SqlDbType.int
parm(8).Conteudo = pDTO.PNOT_cd_nota

parm(9).Campo = "@PNOT_dt_ocorrencia"
parm(9).Tipo = SqlDbType.datetime
parm(9).Conteudo = pDTO.PNOT_dt_ocorrencia



            Return objBanco.SelectDataTable(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Update, True)> _
    Public Function UpdateData() As Integer
        Try

            Dim procName As String = "sp_upd_tb_PNOT_processo_nota"
            Dim parm(8) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@PNOT_cd_nota"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PNOT_cd_nota

parm(3).Campo = "@PNOT_ds_nota"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.PNOT_ds_nota

parm(4).Campo = "@PNOT_dt_ocorrencia"
parm(4).Tipo = SqlDbType.datetime
parm(4).Conteudo = pDTO.PNOT_dt_ocorrencia

parm(5).Campo = "@AUDT_dt_inclusao"
parm(5).Tipo = SqlDbType.datetime
parm(5).Conteudo = pDTO.AUDT_dt_inclusao

parm(6).Campo = "@AUDT_nm_usuario_inclusao"
parm(6).Tipo = SqlDbType.varchar
parm(6).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(7).Campo = "@AUDT_dt_alteracao"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.AUDT_dt_alteracao

parm(8).Campo = "@AUDT_nm_usuario_alteracao"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Insert, True)> _
   Public Function InsertData() As Integer
        Try

            Dim procName As String = "sp_ins_tb_PNOT_processo_nota"
            Dim parm(8) As Parametros

            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@PNOT_cd_nota"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PNOT_cd_nota

parm(3).Campo = "@PNOT_ds_nota"
parm(3).Tipo = SqlDbType.varchar
parm(3).Conteudo = pDTO.PNOT_ds_nota

parm(4).Campo = "@PNOT_dt_ocorrencia"
parm(4).Tipo = SqlDbType.datetime
parm(4).Conteudo = pDTO.PNOT_dt_ocorrencia

parm(5).Campo = "@AUDT_dt_inclusao"
parm(5).Tipo = SqlDbType.datetime
parm(5).Conteudo = pDTO.AUDT_dt_inclusao

parm(6).Campo = "@AUDT_nm_usuario_inclusao"
parm(6).Tipo = SqlDbType.varchar
parm(6).Conteudo = pDTO.AUDT_nm_usuario_inclusao

parm(7).Campo = "@AUDT_dt_alteracao"
parm(7).Tipo = SqlDbType.datetime
parm(7).Conteudo = pDTO.AUDT_dt_alteracao

parm(8).Campo = "@AUDT_nm_usuario_alteracao"
parm(8).Tipo = SqlDbType.varchar
parm(8).Conteudo = pDTO.AUDT_nm_usuario_alteracao



            Return objBanco.ExecuteNonQuery(procName, parm)

        Catch ex As Exception
            Throw ex
        End Try
    End Function
<System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Delete, True)> _
   Public Function DeleteData() As Integer
        Try

            Dim procName As String = "sp_del_tb_PNOT_processo_nota"
            Dim parm(2) As Parametros
			Dim rowsAffected as Integer = 0
			
            parm(0).Campo = "@PROC_cd_processo"
parm(0).Tipo = SqlDbType.varchar
parm(0).Conteudo = pDTO.PROC_cd_processo

parm(1).Campo = "@ORGA_nm_orgao"
parm(1).Tipo = SqlDbType.varchar
parm(1).Conteudo = pDTO.ORGA_nm_orgao

parm(2).Campo = "@PNOT_cd_nota"
parm(2).Tipo = SqlDbType.int
parm(2).Conteudo = pDTO.PNOT_cd_nota



            rowsAffected = objBanco.ExecuteNonQuery(procName, parm)

			

			return rowsAffected

        Catch ex As Exception
            Throw ex
        End Try
    End Function

 <System.ComponentModel.DataObjectMethodAttribute(System.ComponentModel.DataObjectMethodType.Select, False)> _
    Public Function ConsultData() As DataTable
        Try

            Dim procName As String = "sp_sel_tb_PNOT_processo_nota_cons"
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