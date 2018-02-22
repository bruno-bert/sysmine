use dbDNPM;





 -- Tabela: tb_LESI_log_erro_sistema - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_LESI_log_erro_sistema_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_LESI_log_erro_sistema_cons')
  DROP PROCEDURE sp_sel_tb_LESI_log_erro_sistema_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '' 
ELSE
 SET @OrderByAux = ' Order by ' + @OrderByClause



SET @whereAux = ''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  LESI_cd_ocorrencia bigint not null, 
LESI_nm_source varchar(100) not null, 
LESI_ds_exception varchar(8000) null, 
LESI_ds_inexception varchar(8000) null, 
LESI_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.LESI_cd_ocorrencia as LESI_cd_ocorrencia, 
A.LESI_nm_source as LESI_nm_source, 
A.LESI_ds_exception as LESI_ds_exception, 
A.LESI_ds_inexception as LESI_ds_inexception, 
A.LESI_dt_ocorrencia as LESI_dt_ocorrencia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao ' 
+ ' from 

DBDNPM..tb_LESI_log_erro_sistema A ' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + ' WHERE ' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql =' SELECT * FROM #Temporary_Table ' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + ' WHERE ' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + ' ' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

GO
grant execute on sp_sel_tb_LESI_log_erro_sistema_cons to rl_exec_proc
GO



