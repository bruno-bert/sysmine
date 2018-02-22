use dbDNPM;





 -- Tabela: tb_EMPR_empresa - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_EMPR_empresa_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_EMPR_empresa_cons')
  DROP PROCEDURE sp_sel_tb_EMPR_empresa_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_cons]
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
  EMPR_nm_empresa varchar(20) not null, 
EMPR_ds_empresa varchar(300) not null, 
EMPR_fl_status char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
EMPR_ds_status varchar(100) NULL
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.EMPR_nm_empresa as EMPR_nm_empresa, 
A.EMPR_ds_empresa as EMPR_ds_empresa, 
A.EMPR_fl_status as EMPR_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 

(select case when EMPR_fl_status = 'A' then 'Ativo' else 'Inativo' end) as EMPR_ds_status ' 
+ ' from 

DBDNPM..tb_EMPR_empresa A ' 

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
grant execute on sp_sel_tb_EMPR_empresa_cons to rl_exec_proc
GO



