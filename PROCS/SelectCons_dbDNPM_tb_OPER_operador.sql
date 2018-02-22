use dbDNPM;





 -- Tabela: tb_OPER_operador - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_OPER_operador_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_OPER_operador_cons')
  DROP PROCEDURE sp_sel_tb_OPER_operador_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_OPER_operador_cons]
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
  OPER_cd_operador varchar(20) not null, 
OPER_nm_operador varchar(1000) not null, 
OPER_ds_email varchar(200) not null, 
OPER_fl_alerta char(1) not null, 
OPER_fl_alerta_nativo char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
OPER_ds_alerta varchar(3) NULL
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.OPER_cd_operador as OPER_cd_operador, 
A.OPER_nm_operador as OPER_nm_operador, 
A.OPER_ds_email as OPER_ds_email, 
A.OPER_fl_alerta as OPER_fl_alerta, 
A.OPER_fl_alerta_nativo as OPER_fl_alerta_nativo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 

(select case when OPER_fl_alerta = 'S' then 'Sim' else 'Não' end) as OPER_ds_alerta ' 
+ ' from 

DBDNPM..tb_OPER_operador A ' 

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
grant execute on sp_sel_tb_OPER_operador_cons to rl_exec_proc
GO



