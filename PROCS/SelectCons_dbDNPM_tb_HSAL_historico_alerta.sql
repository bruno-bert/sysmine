use dbDNPM;





 -- Tabela: tb_HSAL_historico_alerta - Procedure: SelectCons
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_HSAL_historico_alerta_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_HSAL_historico_alerta_cons')
  DROP PROCEDURE sp_sel_tb_HSAL_historico_alerta_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta_cons]
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
  HSAL_id_historico int not null, 
HSAL_ds_email varchar(200) not null, 
ALER_nm_alerta varchar(50) not null, 
PROC_cd_processo varchar(50) not null, 
HSAL_ds_assunto_email varchar(200) not null, 
HSAL_ds_texto_email varchar(8000) not null, 
HSAL_dt_envio datetime null, 
HSAL_dt_tentativa_ultimo_envio datetime null, 
HSAL_ds_mensagem varchar(8000) null, 
HSAL_fl_status char(3) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
A.HSAL_id_historico as HSAL_id_historico, 
A.HSAL_ds_email as HSAL_ds_email, 
A.ALER_nm_alerta as ALER_nm_alerta, 
A.PROC_cd_processo as PROC_cd_processo, 
A.HSAL_ds_assunto_email as HSAL_ds_assunto_email, 
A.HSAL_ds_texto_email as HSAL_ds_texto_email, 
A.HSAL_dt_envio as HSAL_dt_envio, 
A.HSAL_dt_tentativa_ultimo_envio as HSAL_dt_tentativa_ultimo_envio, 
A.HSAL_ds_mensagem as HSAL_ds_mensagem, 
A.HSAL_fl_status as HSAL_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao ' 
+ ' from 

DBDNPM..tb_HSAL_historico_alerta A ' 

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
grant execute on sp_sel_tb_HSAL_historico_alerta_cons to rl_exec_proc
GO



