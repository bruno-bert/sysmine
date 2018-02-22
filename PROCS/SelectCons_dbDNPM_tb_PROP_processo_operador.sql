use dbDNPM;





 -- Tabela: tb_PROP_processo_operador - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PROP_processo_operador_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PROP_processo_operador_cons')
  DROP PROCEDURE sp_sel_tb_PROP_processo_operador_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador_cons]
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



 -- Join: dbDNPM.tb_PROP_processo_operador x dbDNPM.tb_PROC_processo

SET @whereAux = 'A.PROC_cd_processo = B.PROC_cd_processo '



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
OPER_cd_operador varchar(20) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.OPER_cd_operador as OPER_cd_operador, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.PROC_ds_titular as PROC_ds_titular, 
B.PROC_vl_ano as PROC_vl_ano, 
B.PROC_nm_processo as PROC_nm_processo, 
B.PROC_id_processo as PROC_id_processo, 
B.FASE_cd_fase as FASE_cd_fase, 
B.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
B.PROC_ds_substancia as PROC_ds_substancia, 
B.PROC_ds_area as PROC_ds_area, 
B.PROC_ds_uso as PROC_ds_uso, 
B.PROC_ds_link as PROC_ds_link, 
B.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
B.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao ' 
+ ' from 

DBDNPM..tb_PROP_processo_operador A, 
DBDNPM..tb_PROC_processo B ' 

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
grant execute on sp_sel_tb_PROP_processo_operador_cons to rl_exec_proc
GO



