use dbDNPM;





 -- Tabela: tb_ALER_alerta - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_ALER_alerta_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ALER_alerta_cons')
  DROP PROCEDURE sp_sel_tb_ALER_alerta_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_ALER_alerta_cons]
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
  ALER_nm_alerta varchar(50) not null, 
ALER_ds_alerta varchar(300) null, 
ALER_fl_muda_fase char(1) not null, 
ALER_fl_muda_evento char(1) not null, 
ALER_cd_fase_anterior int null, 
ALER_cd_fase_nova int null, 
ALER_fl_qualquer_processo char(1) not null, 
ALER_fl_status char(1) not null, 
ALER_fl_sistema char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
ALER_ds_status varchar(3) NULL, 
ALER_ds_sistema varchar(3) NULL, 
ALER_ds_muda_fase varchar(3) NULL, 
ALER_ds_muda_evento varchar(3) NULL, 
ALER_ds_qualquer_processo varchar(3) NULL, 
ALER_nm_fase_anterior varchar(100) NULL, 
ALER_ds_fase_nova varchar(100) NULL
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.ALER_nm_alerta as ALER_nm_alerta, 
A.ALER_ds_alerta as ALER_ds_alerta, 
A.ALER_fl_muda_fase as ALER_fl_muda_fase, 
A.ALER_fl_muda_evento as ALER_fl_muda_evento, 
A.ALER_cd_fase_anterior as ALER_cd_fase_anterior, 
A.ALER_cd_fase_nova as ALER_cd_fase_nova, 
A.ALER_fl_qualquer_processo as ALER_fl_qualquer_processo, 
A.ALER_fl_status as ALER_fl_status, 
A.ALER_fl_sistema as ALER_fl_sistema, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 

(select case when ALER_fl_status = 'S' then 'Sim' else 'Não' end) as ALER_ds_status, 

(select case when ALER_fl_sistema = 'S' then 'Sim' else 'Não' end) as ALER_ds_sistema, 

(select case when ALER_fl_muda_fase = 'S' then 'Sim' else 'Não' end) as ALER_ds_muda_fase, 

(select case when ALER_fl_muda_evento = 'S' then 'Sim' else 'Não' end) as ALER_ds_muda_evento, 

(select case when ALER_fl_qualquer_processo = 'S' then 'Sim' else 'Não' end) as ALER_ds_qualquer_processo, 

(select FASE_nm_fase from tb_FASE_fase x where a.ALER_cd_fase_anterior = x.FASE_cd_fase) as ALER_nm_fase_anterior, 

(select FASE_nm_fase from tb_FASE_fase x where a.ALER_cd_fase_nova = x.FASE_cd_fase) as ALER_ds_fase_nova ' 
+ ' from 

DBDNPM..tb_ALER_alerta A ' 

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
grant execute on sp_sel_tb_ALER_alerta_cons to rl_exec_proc
GO



