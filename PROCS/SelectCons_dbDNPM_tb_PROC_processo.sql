use dbDNPM;





 -- Tabela: tb_PROC_processo - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PROC_processo_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PROC_processo_cons')
  DROP PROCEDURE sp_sel_tb_PROC_processo_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_sel_tb_PROC_processo_cons]
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



 -- Join: dbDNPM.tb_PROC_processo x dbDNPM.tb_FASE_fase
 -- Join: dbDNPM.tb_PROC_processo x dbDNPM.tb_UNFE_unidade_federativa

SET @whereAux = '
A.FASE_cd_fase = B.FASE_cd_fase and 

A.UNFE_cd_unidade_federativa = C.UNFE_cd_unidade_federativa '



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
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
PROC_fl_tipo_inclusao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
FASE_nm_fase varchar(100) not null, 
UNFE_nm_unidade_federativa varchar(100) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.PROC_ds_titular as PROC_ds_titular, 
A.PROC_vl_ano as PROC_vl_ano, 
A.PROC_nm_processo as PROC_nm_processo, 
A.PROC_id_processo as PROC_id_processo, 
A.FASE_cd_fase as FASE_cd_fase, 
A.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
A.PROC_ds_substancia as PROC_ds_substancia, 
A.PROC_ds_area as PROC_ds_area, 
A.PROC_ds_uso as PROC_ds_uso, 
A.PROC_ds_link as PROC_ds_link, 
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.FASE_nm_fase as FASE_nm_fase, 
C.UNFE_nm_unidade_federativa as UNFE_nm_unidade_federativa ' 
+ ' from 

DBDNPM..tb_PROC_processo A, 
DBDNPM..tb_FASE_fase B, 
DBDNPM..tb_UNFE_unidade_federativa C ' 

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
grant execute on sp_sel_tb_PROC_processo_cons to rl_exec_proc
GO



