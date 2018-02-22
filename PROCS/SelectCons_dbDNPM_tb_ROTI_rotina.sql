use dbDNPM;





 -- Tabela: tb_ROTI_rotina - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_ROTI_rotina_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ROTI_rotina_cons')
  DROP PROCEDURE sp_sel_tb_ROTI_rotina_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina_cons]
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
  ROTI_nm_rotina varchar(30) not null, 
ROTI_ds_rotina varchar(300) null, 
ROTI_dt_ultima_execucao datetime null, 
ROTI_dt_ultima_tentativa_execucao datetime null, 
ROTI_fl_status_execucao char(1) not null, 
ROTI_ds_mensagem varchar(1000) null, 
ROTI_vl_tempo_medio decimal(13, 2) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.ROTI_nm_rotina as ROTI_nm_rotina, 
A.ROTI_ds_rotina as ROTI_ds_rotina, 
A.ROTI_dt_ultima_execucao as ROTI_dt_ultima_execucao, 
A.ROTI_dt_ultima_tentativa_execucao as ROTI_dt_ultima_tentativa_execucao, 
A.ROTI_fl_status_execucao as ROTI_fl_status_execucao, 
A.ROTI_ds_mensagem as ROTI_ds_mensagem, 
A.ROTI_vl_tempo_medio as ROTI_vl_tempo_medio, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao ' 
+ ' from 

DBDNPM..tb_ROTI_rotina A ' 

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
grant execute on sp_sel_tb_ROTI_rotina_cons to rl_exec_proc
GO



