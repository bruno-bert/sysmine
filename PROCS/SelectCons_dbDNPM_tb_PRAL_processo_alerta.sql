use dbDNPM;





 -- Tabela: tb_PRAL_processo_alerta - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PRAL_processo_alerta_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PRAL_processo_alerta_cons')
  DROP PROCEDURE sp_sel_tb_PRAL_processo_alerta_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta_cons]
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



 -- Join: dbDNPM.tb_PRAL_processo_alerta x dbDNPM.tb_ALER_alerta
 -- Join: dbDNPM.tb_PRAL_processo_alerta x dbDNPM.tb_PROC_processo

SET @whereAux = '
A.ALER_nm_alerta = B.ALER_nm_alerta and 

A.PROC_cd_processo = C.PROC_cd_processo '



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ALER_nm_alerta varchar(50) not null, 
PRAL_fl_manutencao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
ALER_ds_alerta varchar(300) null, 
ALER_fl_muda_fase char(1) not null, 
ALER_fl_muda_evento char(1) not null, 
ALER_cd_fase_anterior int null, 
ALER_cd_fase_nova int null, 
ALER_fl_qualquer_processo char(1) not null, 
ALER_fl_status char(1) not null, 
ALER_fl_sistema char(1) not null, 
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
A.ALER_nm_alerta as ALER_nm_alerta, 
A.PRAL_fl_manutencao as PRAL_fl_manutencao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.ALER_ds_alerta as ALER_ds_alerta, 
B.ALER_fl_muda_fase as ALER_fl_muda_fase, 
B.ALER_fl_muda_evento as ALER_fl_muda_evento, 
B.ALER_cd_fase_anterior as ALER_cd_fase_anterior, 
B.ALER_cd_fase_nova as ALER_cd_fase_nova, 
B.ALER_fl_qualquer_processo as ALER_fl_qualquer_processo, 
B.ALER_fl_status as ALER_fl_status, 
B.ALER_fl_sistema as ALER_fl_sistema, 
C.PROC_ds_titular as PROC_ds_titular, 
C.PROC_vl_ano as PROC_vl_ano, 
C.PROC_nm_processo as PROC_nm_processo, 
C.PROC_id_processo as PROC_id_processo, 
C.FASE_cd_fase as FASE_cd_fase, 
C.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
C.PROC_ds_substancia as PROC_ds_substancia, 
C.PROC_ds_area as PROC_ds_area, 
C.PROC_ds_uso as PROC_ds_uso, 
C.PROC_ds_link as PROC_ds_link, 
C.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
C.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao ' 
+ ' from 

DBDNPM..tb_PRAL_processo_alerta A, 
DBDNPM..tb_ALER_alerta B, 
DBDNPM..tb_PROC_processo C ' 

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
grant execute on sp_sel_tb_PRAL_processo_alerta_cons to rl_exec_proc
GO



