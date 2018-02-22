use dbDNPM;





 -- Tabela: tb_UNFE_unidade_federativa - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_UNFE_unidade_federativa_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_UNFE_unidade_federativa_cons')
  DROP PROCEDURE sp_sel_tb_UNFE_unidade_federativa_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]
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
  UNFE_cd_unidade_federativa char(2) not null, 
UNFE_nm_unidade_federativa varchar(100) not null, 
UNFE_fl_status char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.UNFE_nm_unidade_federativa as UNFE_nm_unidade_federativa, 
A.UNFE_fl_status as UNFE_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao ' 
+ ' from 

DBDNPM..tb_UNFE_unidade_federativa A ' 

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
grant execute on sp_sel_tb_UNFE_unidade_federativa_cons to rl_exec_proc
GO



