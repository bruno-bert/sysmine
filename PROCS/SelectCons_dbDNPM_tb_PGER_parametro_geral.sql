use dbDNPM;





 -- Tabela: tb_PGER_parametro_geral - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PGER_parametro_geral_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PGER_parametro_geral_cons')
  DROP PROCEDURE sp_sel_tb_PGER_parametro_geral_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral_cons]
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
  PGER_cd_parametro varchar(10) not null, 
PGER_ds_parametro varchar(100) not null, 
PGER_vl_parametro varchar(1000) not null, 
PGER_fl_tipo char(1) not null, 
PGER_fl_sistema char(1) not null, 
PGER_vl_range_min bigint null, 
PGER_vl_range_max bigint null, 
PGER_vl_padrao varchar(1000) not null, 
PGER_vl_tamanho_min int null, 
PGER_vl_tamanho_max int null, 
PGER_vl_valores_permitidos varchar(8000) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.PGER_cd_parametro as PGER_cd_parametro, 
A.PGER_ds_parametro as PGER_ds_parametro, 
A.PGER_vl_parametro as PGER_vl_parametro, 
A.PGER_fl_tipo as PGER_fl_tipo, 
A.PGER_fl_sistema as PGER_fl_sistema, 
A.PGER_vl_range_min as PGER_vl_range_min, 
A.PGER_vl_range_max as PGER_vl_range_max, 
A.PGER_vl_padrao as PGER_vl_padrao, 
A.PGER_vl_tamanho_min as PGER_vl_tamanho_min, 
A.PGER_vl_tamanho_max as PGER_vl_tamanho_max, 
A.PGER_vl_valores_permitidos as PGER_vl_valores_permitidos, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao ' 
+ ' from 

DBDNPM..tb_PGER_parametro_geral A ' 

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
grant execute on sp_sel_tb_PGER_parametro_geral_cons to rl_exec_proc
GO



