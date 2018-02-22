use dbDNPM;
GO

 -- Lista de Tabelas: 

 -- tb_ALER_alerta
 -- tb_EMPR_empresa
 -- tb_FASE_fase
 -- tb_HSAL_historico_alerta
 -- tb_LESI_log_erro_sistema
 -- tb_OPER_operador
 -- tb_PGER_parametro_geral
 -- tb_PRAL_processo_alerta
 -- tb_PREV_processo_evento
 -- tb_PROC_processo
 -- tb_PROP_processo_operador
 -- tb_ROTI_rotina
 -- tb_UNFE_unidade_federativa






 -- Tabela: tb_ALER_alerta - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_ALER_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ALER_alerta')
  DROP PROCEDURE sp_sel_tb_ALER_alerta
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_ALER_alerta]
@ALER_nm_alerta varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_ALER_alerta
 where (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))   


GO
grant execute on sp_sel_tb_ALER_alerta to rl_exec_proc
GO




 -- Tabela: tb_ALER_alerta - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_ALER_alerta_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ALER_alerta_rel')
  DROP PROCEDURE sp_sel_tb_ALER_alerta_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_ALER_alerta_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_ALER_alerta table(
id int identity primary key, 
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
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_ALER_alerta
(ALER_nm_alerta, 
ALER_ds_alerta, 
ALER_fl_muda_fase, 
ALER_fl_muda_evento, 
ALER_cd_fase_anterior, 
ALER_cd_fase_nova, 
ALER_fl_qualquer_processo, 
ALER_fl_status, 
ALER_fl_sistema, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
ALER_nm_alerta, 
ALER_ds_alerta, 
ALER_fl_muda_fase, 
ALER_fl_muda_evento, 
ALER_cd_fase_anterior, 
ALER_cd_fase_nova, 
ALER_fl_qualquer_processo, 
ALER_fl_status, 
ALER_fl_sistema, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_ALER_alerta

WHERE 

(@whereField is null OR 

 (@whereField = 'ALER_nm_alerta' and rtrim(ltrim(ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_ds_alerta' and rtrim(ltrim(ALER_ds_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_muda_fase' and rtrim(ltrim(ALER_fl_muda_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_muda_evento' and rtrim(ltrim(ALER_fl_muda_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_cd_fase_anterior' and rtrim(ltrim(ALER_cd_fase_anterior)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_cd_fase_nova' and rtrim(ltrim(ALER_cd_fase_nova)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_qualquer_processo' and rtrim(ltrim(ALER_fl_qualquer_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_status' and rtrim(ltrim(ALER_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_sistema' and rtrim(ltrim(ALER_fl_sistema)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='ASC' then ALER_nm_alerta END ASC, 
 CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='DESC' then ALER_nm_alerta END DESC 
 ,  CASE when @sortField = 'ALER_ds_alerta' and  @sortOrder='ASC' then ALER_ds_alerta END ASC, 
 CASE when @sortField = 'ALER_ds_alerta' and  @sortOrder='DESC' then ALER_ds_alerta END DESC 
 ,  CASE when @sortField = 'ALER_fl_muda_fase' and  @sortOrder='ASC' then ALER_fl_muda_fase END ASC, 
 CASE when @sortField = 'ALER_fl_muda_fase' and  @sortOrder='DESC' then ALER_fl_muda_fase END DESC 
 ,  CASE when @sortField = 'ALER_fl_muda_evento' and  @sortOrder='ASC' then ALER_fl_muda_evento END ASC, 
 CASE when @sortField = 'ALER_fl_muda_evento' and  @sortOrder='DESC' then ALER_fl_muda_evento END DESC 
 ,  CASE when @sortField = 'ALER_cd_fase_anterior' and  @sortOrder='ASC' then ALER_cd_fase_anterior END ASC, 
 CASE when @sortField = 'ALER_cd_fase_anterior' and  @sortOrder='DESC' then ALER_cd_fase_anterior END DESC 
 ,  CASE when @sortField = 'ALER_cd_fase_nova' and  @sortOrder='ASC' then ALER_cd_fase_nova END ASC, 
 CASE when @sortField = 'ALER_cd_fase_nova' and  @sortOrder='DESC' then ALER_cd_fase_nova END DESC 
 ,  CASE when @sortField = 'ALER_fl_qualquer_processo' and  @sortOrder='ASC' then ALER_fl_qualquer_processo END ASC, 
 CASE when @sortField = 'ALER_fl_qualquer_processo' and  @sortOrder='DESC' then ALER_fl_qualquer_processo END DESC 
 ,  CASE when @sortField = 'ALER_fl_status' and  @sortOrder='ASC' then ALER_fl_status END ASC, 
 CASE when @sortField = 'ALER_fl_status' and  @sortOrder='DESC' then ALER_fl_status END DESC 
 ,  CASE when @sortField = 'ALER_fl_sistema' and  @sortOrder='ASC' then ALER_fl_sistema END ASC, 
 CASE when @sortField = 'ALER_fl_sistema' and  @sortOrder='DESC' then ALER_fl_sistema END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_ALER_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_ALER_alerta_rel to rl_exec_proc
GO




 -- Tabela: tb_ALER_alerta - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_ALER_alerta]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_ALER_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_ALER_alerta')
  DROP PROCEDURE sp_upd_tb_ALER_alerta
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_ALER_alerta
CREATE PROCEDURE sp_upd_tb_ALER_alerta
@ALER_nm_alerta varchar(50) = null , 
@ALER_ds_alerta varchar(300) = null , 
@ALER_fl_muda_fase char(1) = null , 
@ALER_fl_muda_evento char(1) = null , 
@ALER_cd_fase_anterior int = null , 
@ALER_cd_fase_nova int = null , 
@ALER_fl_qualquer_processo char(1) = null , 
@ALER_fl_status char(1) = null , 
@ALER_fl_sistema char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_ALER_alerta 
SET 
ALER_ds_alerta = case when @ALER_ds_alerta is not null then @ALER_ds_alerta else ALER_ds_alerta end , 
ALER_fl_muda_fase = case when @ALER_fl_muda_fase is not null then @ALER_fl_muda_fase else ALER_fl_muda_fase end , 
ALER_fl_muda_evento = case when @ALER_fl_muda_evento is not null then @ALER_fl_muda_evento else ALER_fl_muda_evento end , 
ALER_cd_fase_anterior = case when @ALER_cd_fase_anterior is not null then @ALER_cd_fase_anterior else ALER_cd_fase_anterior end , 
ALER_cd_fase_nova = case when @ALER_cd_fase_nova is not null then @ALER_cd_fase_nova else ALER_cd_fase_nova end , 
ALER_fl_qualquer_processo = case when @ALER_fl_qualquer_processo is not null then @ALER_fl_qualquer_processo else ALER_fl_qualquer_processo end , 
ALER_fl_status = case when @ALER_fl_status is not null then @ALER_fl_status else ALER_fl_status end , 
ALER_fl_sistema = case when @ALER_fl_sistema is not null then @ALER_fl_sistema else ALER_fl_sistema end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))  
 
GO
grant execute on sp_upd_tb_ALER_alerta to rl_exec_proc
go



 -- Tabela: tb_ALER_alerta - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_ALER_alerta]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_ALER_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_ALER_alerta')
  DROP PROCEDURE sp_ins_tb_ALER_alerta
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_ALER_alerta
CREATE PROCEDURE sp_ins_tb_ALER_alerta
@ALER_nm_alerta varchar(50) = null , 
@ALER_ds_alerta varchar(300) = null , 
@ALER_fl_muda_fase char(1) = null , 
@ALER_fl_muda_evento char(1) = null , 
@ALER_cd_fase_anterior int = null , 
@ALER_cd_fase_nova int = null , 
@ALER_fl_qualquer_processo char(1) = null , 
@ALER_fl_status char(1) = null , 
@ALER_fl_sistema char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_ALER_alerta
  (ALER_nm_alerta, 
ALER_ds_alerta, 
ALER_fl_muda_fase, 
ALER_fl_muda_evento, 
ALER_cd_fase_anterior, 
ALER_cd_fase_nova, 
ALER_fl_qualquer_processo, 
ALER_fl_status, 
ALER_fl_sistema, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ALER_nm_alerta, 
@ALER_ds_alerta, 
@ALER_fl_muda_fase, 
@ALER_fl_muda_evento, 
@ALER_cd_fase_anterior, 
@ALER_cd_fase_nova, 
@ALER_fl_qualquer_processo, 
@ALER_fl_status, 
@ALER_fl_sistema, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_ALER_alerta to rl_exec_proc
go



 -- Tabela: tb_ALER_alerta - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_ALER_alerta]    ******/

-- SE A STORED PROCEDURE sp_del_tb_ALER_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_ALER_alerta')
  DROP PROCEDURE sp_del_tb_ALER_alerta
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_del_tb_ALER_alerta]
@ALER_nm_alerta varchar(50) = null 
 
AS
 
DELETE FROM 
tb_ALER_alerta
 where (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))   

GO
grant execute on sp_del_tb_ALER_alerta to rl_exec_proc
GO




 -- Tabela: tb_ALER_alerta - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_ALER_alerta_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ALER_alerta_cons')
  DROP PROCEDURE sp_sel_tb_ALER_alerta_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_ALER_alerta_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

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
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
ALER_nm_alerta, 
ALER_ds_alerta, 
ALER_fl_muda_fase, 
ALER_fl_muda_evento, 
ALER_cd_fase_anterior, 
ALER_cd_fase_nova, 
ALER_fl_qualquer_processo, 
ALER_fl_status, 
ALER_fl_sistema, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_ALER_alerta ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_ALER_alerta_cons to rl_exec_proc
GO








 -- Tabela: tb_EMPR_empresa - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_EMPR_empresa EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_EMPR_empresa')
  DROP PROCEDURE sp_sel_tb_EMPR_empresa
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa]
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null 
 
AS
 
SELECT * FROM 
tb_EMPR_empresa
 where (@EMPR_nm_empresa is null or (@EMPR_nm_empresa is not null and EMPR_nm_empresa = @EMPR_nm_empresa))  AND 
(@EMPR_ds_empresa is null or (@EMPR_ds_empresa is not null and EMPR_ds_empresa = @EMPR_ds_empresa))   


GO
grant execute on sp_sel_tb_EMPR_empresa to rl_exec_proc
GO




 -- Tabela: tb_EMPR_empresa - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_EMPR_empresa_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_EMPR_empresa_rel')
  DROP PROCEDURE sp_sel_tb_EMPR_empresa_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_EMPR_empresa table(
id int identity primary key, 
EMPR_nm_empresa varchar(20) not null, 
EMPR_ds_empresa varchar(300) not null, 
EMPR_fl_status char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_EMPR_empresa
(EMPR_nm_empresa, 
EMPR_ds_empresa, 
EMPR_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
EMPR_nm_empresa, 
EMPR_ds_empresa, 
EMPR_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_EMPR_empresa

WHERE 

(@whereField is null OR 

 (@whereField = 'EMPR_nm_empresa' and rtrim(ltrim(EMPR_nm_empresa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'EMPR_ds_empresa' and rtrim(ltrim(EMPR_ds_empresa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'EMPR_fl_status' and rtrim(ltrim(EMPR_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'EMPR_nm_empresa' and  @sortOrder='ASC' then EMPR_nm_empresa END ASC, 
 CASE when @sortField = 'EMPR_nm_empresa' and  @sortOrder='DESC' then EMPR_nm_empresa END DESC 
 ,  CASE when @sortField = 'EMPR_ds_empresa' and  @sortOrder='ASC' then EMPR_ds_empresa END ASC, 
 CASE when @sortField = 'EMPR_ds_empresa' and  @sortOrder='DESC' then EMPR_ds_empresa END DESC 
 ,  CASE when @sortField = 'EMPR_fl_status' and  @sortOrder='ASC' then EMPR_fl_status END ASC, 
 CASE when @sortField = 'EMPR_fl_status' and  @sortOrder='DESC' then EMPR_fl_status END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_EMPR_empresa where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_EMPR_empresa_rel to rl_exec_proc
GO




 -- Tabela: tb_EMPR_empresa - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_EMPR_empresa]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_EMPR_empresa EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_EMPR_empresa')
  DROP PROCEDURE sp_upd_tb_EMPR_empresa
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_EMPR_empresa
CREATE PROCEDURE sp_upd_tb_EMPR_empresa
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null , 
@EMPR_fl_status char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_EMPR_empresa 
SET 
EMPR_ds_empresa = case when @EMPR_ds_empresa is not null then @EMPR_ds_empresa else EMPR_ds_empresa end , 
EMPR_fl_status = case when @EMPR_fl_status is not null then @EMPR_fl_status else EMPR_fl_status end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@EMPR_nm_empresa is null or (@EMPR_nm_empresa is not null and EMPR_nm_empresa = @EMPR_nm_empresa))  
 
GO
grant execute on sp_upd_tb_EMPR_empresa to rl_exec_proc
go



 -- Tabela: tb_EMPR_empresa - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_EMPR_empresa]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_EMPR_empresa EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_EMPR_empresa')
  DROP PROCEDURE sp_ins_tb_EMPR_empresa
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_EMPR_empresa
CREATE PROCEDURE sp_ins_tb_EMPR_empresa
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null , 
@EMPR_fl_status char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_EMPR_empresa
  (EMPR_nm_empresa, 
EMPR_ds_empresa, 
EMPR_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@EMPR_nm_empresa, 
@EMPR_ds_empresa, 
@EMPR_fl_status, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_EMPR_empresa to rl_exec_proc
go



 -- Tabela: tb_EMPR_empresa - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_EMPR_empresa]    ******/

-- SE A STORED PROCEDURE sp_del_tb_EMPR_empresa EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_EMPR_empresa')
  DROP PROCEDURE sp_del_tb_EMPR_empresa
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_del_tb_EMPR_empresa]
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null 
 
AS
 
DELETE FROM 
tb_EMPR_empresa
 where (@EMPR_nm_empresa is null or (@EMPR_nm_empresa is not null and EMPR_nm_empresa = @EMPR_nm_empresa))  AND 
(@EMPR_ds_empresa is null or (@EMPR_ds_empresa is not null and EMPR_ds_empresa = @EMPR_ds_empresa))   

GO
grant execute on sp_del_tb_EMPR_empresa to rl_exec_proc
GO




 -- Tabela: tb_EMPR_empresa - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_EMPR_empresa_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_EMPR_empresa_cons')
  DROP PROCEDURE sp_sel_tb_EMPR_empresa_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  EMPR_nm_empresa varchar(20) not null, 
EMPR_ds_empresa varchar(300) not null, 
EMPR_fl_status char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
EMPR_nm_empresa, 
EMPR_ds_empresa, 
EMPR_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_EMPR_empresa ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_EMPR_empresa_cons to rl_exec_proc
GO








 -- Tabela: tb_FASE_fase - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_FASE_fase EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_FASE_fase')
  DROP PROCEDURE sp_sel_tb_FASE_fase
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_sel_tb_FASE_fase]
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_FASE_fase
 where (@FASE_cd_fase is null or (@FASE_cd_fase is not null and FASE_cd_fase = @FASE_cd_fase))  AND 
(@FASE_nm_fase is null or (@FASE_nm_fase is not null and FASE_nm_fase = @FASE_nm_fase))   


GO
grant execute on sp_sel_tb_FASE_fase to rl_exec_proc
GO




 -- Tabela: tb_FASE_fase - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_FASE_fase_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_FASE_fase_rel')
  DROP PROCEDURE sp_sel_tb_FASE_fase_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_sel_tb_FASE_fase_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_FASE_fase table(
id int identity primary key, 
FASE_cd_fase int not null, 
FASE_nm_fase varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_FASE_fase
(FASE_cd_fase, 
FASE_nm_fase, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
FASE_cd_fase, 
FASE_nm_fase, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_FASE_fase

WHERE 

(@whereField is null OR 

 (@whereField = 'FASE_cd_fase' and rtrim(ltrim(FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'FASE_nm_fase' and rtrim(ltrim(FASE_nm_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='ASC' then FASE_cd_fase END ASC, 
 CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='DESC' then FASE_cd_fase END DESC 
 ,  CASE when @sortField = 'FASE_nm_fase' and  @sortOrder='ASC' then FASE_nm_fase END ASC, 
 CASE when @sortField = 'FASE_nm_fase' and  @sortOrder='DESC' then FASE_nm_fase END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_FASE_fase where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_FASE_fase_rel to rl_exec_proc
GO




 -- Tabela: tb_FASE_fase - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_FASE_fase]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_FASE_fase EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_FASE_fase')
  DROP PROCEDURE sp_upd_tb_FASE_fase
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_FASE_fase
CREATE PROCEDURE sp_upd_tb_FASE_fase
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_FASE_fase 
SET 
FASE_nm_fase = case when @FASE_nm_fase is not null then @FASE_nm_fase else FASE_nm_fase end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@FASE_cd_fase is null or (@FASE_cd_fase is not null and FASE_cd_fase = @FASE_cd_fase))  
 
GO
grant execute on sp_upd_tb_FASE_fase to rl_exec_proc
go



 -- Tabela: tb_FASE_fase - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_FASE_fase]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_FASE_fase EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_FASE_fase')
  DROP PROCEDURE sp_ins_tb_FASE_fase
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_FASE_fase
CREATE PROCEDURE sp_ins_tb_FASE_fase
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_FASE_fase
  (FASE_cd_fase, 
FASE_nm_fase, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@FASE_cd_fase, 
@FASE_nm_fase, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_FASE_fase to rl_exec_proc
go



 -- Tabela: tb_FASE_fase - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_FASE_fase]    ******/

-- SE A STORED PROCEDURE sp_del_tb_FASE_fase EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_FASE_fase')
  DROP PROCEDURE sp_del_tb_FASE_fase
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_del_tb_FASE_fase]
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null 
 
AS
 
DELETE FROM 
tb_FASE_fase
 where (@FASE_cd_fase is null or (@FASE_cd_fase is not null and FASE_cd_fase = @FASE_cd_fase))  AND 
(@FASE_nm_fase is null or (@FASE_nm_fase is not null and FASE_nm_fase = @FASE_nm_fase))   

GO
grant execute on sp_del_tb_FASE_fase to rl_exec_proc
GO




 -- Tabela: tb_FASE_fase - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_FASE_fase_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_FASE_fase_cons')
  DROP PROCEDURE sp_sel_tb_FASE_fase_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_sel_tb_FASE_fase_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  FASE_cd_fase int not null, 
FASE_nm_fase varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
FASE_cd_fase, 
FASE_nm_fase, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_FASE_fase ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_FASE_fase_cons to rl_exec_proc
GO








 -- Tabela: tb_HSAL_historico_alerta - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_HSAL_historico_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_HSAL_historico_alerta')
  DROP PROCEDURE sp_sel_tb_HSAL_historico_alerta
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta]
@HSAL_id_historico int = null 
 
AS
 
SELECT * FROM 
tb_HSAL_historico_alerta
 where (@HSAL_id_historico is null or (@HSAL_id_historico is not null and HSAL_id_historico = @HSAL_id_historico))   


GO
grant execute on sp_sel_tb_HSAL_historico_alerta to rl_exec_proc
GO




 -- Tabela: tb_HSAL_historico_alerta - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_HSAL_historico_alerta_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_HSAL_historico_alerta_rel')
  DROP PROCEDURE sp_sel_tb_HSAL_historico_alerta_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_HSAL_historico_alerta table(
id int identity primary key, 
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



insert into 
@tb_HSAL_historico_alerta
(HSAL_id_historico, 
HSAL_ds_email, 
ALER_nm_alerta, 
PROC_cd_processo, 
HSAL_ds_assunto_email, 
HSAL_ds_texto_email, 
HSAL_dt_envio, 
HSAL_dt_tentativa_ultimo_envio, 
HSAL_ds_mensagem, 
HSAL_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao) 

SELECT 
HSAL_id_historico, 
HSAL_ds_email, 
ALER_nm_alerta, 
PROC_cd_processo, 
HSAL_ds_assunto_email, 
HSAL_ds_texto_email, 
HSAL_dt_envio, 
HSAL_dt_tentativa_ultimo_envio, 
HSAL_ds_mensagem, 
HSAL_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao

FROM 
tb_HSAL_historico_alerta

WHERE 

(@whereField is null OR 

 (@whereField = 'HSAL_id_historico' and rtrim(ltrim(HSAL_id_historico)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_ds_email' and rtrim(ltrim(HSAL_ds_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_nm_alerta' and rtrim(ltrim(ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_cd_processo' and rtrim(ltrim(PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_ds_assunto_email' and rtrim(ltrim(HSAL_ds_assunto_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_ds_texto_email' and rtrim(ltrim(HSAL_ds_texto_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_dt_envio' and rtrim(ltrim(HSAL_dt_envio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_dt_tentativa_ultimo_envio' and rtrim(ltrim(HSAL_dt_tentativa_ultimo_envio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_ds_mensagem' and rtrim(ltrim(HSAL_ds_mensagem)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_fl_status' and rtrim(ltrim(HSAL_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'HSAL_id_historico' and  @sortOrder='ASC' then HSAL_id_historico END ASC, 
 CASE when @sortField = 'HSAL_id_historico' and  @sortOrder='DESC' then HSAL_id_historico END DESC 
 ,  CASE when @sortField = 'HSAL_ds_email' and  @sortOrder='ASC' then HSAL_ds_email END ASC, 
 CASE when @sortField = 'HSAL_ds_email' and  @sortOrder='DESC' then HSAL_ds_email END DESC 
 ,  CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='ASC' then ALER_nm_alerta END ASC, 
 CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='DESC' then ALER_nm_alerta END DESC 
 ,  CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'HSAL_ds_assunto_email' and  @sortOrder='ASC' then HSAL_ds_assunto_email END ASC, 
 CASE when @sortField = 'HSAL_ds_assunto_email' and  @sortOrder='DESC' then HSAL_ds_assunto_email END DESC 
 ,  CASE when @sortField = 'HSAL_ds_texto_email' and  @sortOrder='ASC' then HSAL_ds_texto_email END ASC, 
 CASE when @sortField = 'HSAL_ds_texto_email' and  @sortOrder='DESC' then HSAL_ds_texto_email END DESC 
 ,  CASE when @sortField = 'HSAL_dt_envio' and  @sortOrder='ASC' then HSAL_dt_envio END ASC, 
 CASE when @sortField = 'HSAL_dt_envio' and  @sortOrder='DESC' then HSAL_dt_envio END DESC 
 ,  CASE when @sortField = 'HSAL_dt_tentativa_ultimo_envio' and  @sortOrder='ASC' then HSAL_dt_tentativa_ultimo_envio END ASC, 
 CASE when @sortField = 'HSAL_dt_tentativa_ultimo_envio' and  @sortOrder='DESC' then HSAL_dt_tentativa_ultimo_envio END DESC 
 ,  CASE when @sortField = 'HSAL_ds_mensagem' and  @sortOrder='ASC' then HSAL_ds_mensagem END ASC, 
 CASE when @sortField = 'HSAL_ds_mensagem' and  @sortOrder='DESC' then HSAL_ds_mensagem END DESC 
 ,  CASE when @sortField = 'HSAL_fl_status' and  @sortOrder='ASC' then HSAL_fl_status END ASC, 
 CASE when @sortField = 'HSAL_fl_status' and  @sortOrder='DESC' then HSAL_fl_status END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 

 
SELECT * FROM 
@tb_HSAL_historico_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_HSAL_historico_alerta_rel to rl_exec_proc
GO




 -- Tabela: tb_HSAL_historico_alerta - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_HSAL_historico_alerta]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_HSAL_historico_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_HSAL_historico_alerta')
  DROP PROCEDURE sp_upd_tb_HSAL_historico_alerta
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE sp_upd_tb_HSAL_historico_alerta
@HSAL_id_historico int = null , 
@HSAL_ds_email varchar(200) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PROC_cd_processo varchar(50) = null , 
@HSAL_ds_assunto_email varchar(200) = null , 
@HSAL_ds_texto_email varchar(8000) = null , 
@HSAL_dt_envio datetime = null , 
@HSAL_dt_tentativa_ultimo_envio datetime = null , 
@HSAL_ds_mensagem varchar(8000) = null , 
@HSAL_fl_status char(3) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null 
 
AS
 
UPDATE 
tb_HSAL_historico_alerta 
SET 
HSAL_ds_email = case when @HSAL_ds_email is not null then @HSAL_ds_email else HSAL_ds_email end , 
ALER_nm_alerta = case when @ALER_nm_alerta is not null then @ALER_nm_alerta else ALER_nm_alerta end , 
PROC_cd_processo = case when @PROC_cd_processo is not null then @PROC_cd_processo else PROC_cd_processo end , 
HSAL_ds_assunto_email = case when @HSAL_ds_assunto_email is not null then @HSAL_ds_assunto_email else HSAL_ds_assunto_email end , 
HSAL_ds_texto_email = case when @HSAL_ds_texto_email is not null then @HSAL_ds_texto_email else HSAL_ds_texto_email end , 
HSAL_dt_envio = case when @HSAL_dt_envio is not null then (case when @HSAL_dt_envio <> '00:00:01' then @HSAL_dt_envio else null end) else HSAL_dt_envio end , 
HSAL_dt_tentativa_ultimo_envio = case when @HSAL_dt_tentativa_ultimo_envio is not null then (case when @HSAL_dt_tentativa_ultimo_envio <> '00:00:01' then @HSAL_dt_tentativa_ultimo_envio else null end) else HSAL_dt_tentativa_ultimo_envio end , 
HSAL_ds_mensagem = case when @HSAL_ds_mensagem is not null then @HSAL_ds_mensagem else HSAL_ds_mensagem end , 
HSAL_fl_status = case when @HSAL_fl_status is not null then @HSAL_fl_status else HSAL_fl_status end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end  
 where (@HSAL_id_historico is null or (@HSAL_id_historico is not null and HSAL_id_historico = @HSAL_id_historico))  
 
GO
grant execute on sp_upd_tb_HSAL_historico_alerta to rl_exec_proc
go



 -- Tabela: tb_HSAL_historico_alerta - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_HSAL_historico_alerta]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_HSAL_historico_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_HSAL_historico_alerta')
  DROP PROCEDURE sp_ins_tb_HSAL_historico_alerta
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE sp_ins_tb_HSAL_historico_alerta
@HSAL_id_historico int = null , 
@HSAL_ds_email varchar(200) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PROC_cd_processo varchar(50) = null , 
@HSAL_ds_assunto_email varchar(200) = null , 
@HSAL_ds_texto_email varchar(8000) = null , 
@HSAL_dt_envio datetime = null , 
@HSAL_dt_tentativa_ultimo_envio datetime = null , 
@HSAL_ds_mensagem varchar(8000) = null , 
@HSAL_fl_status char(3) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_HSAL_historico_alerta
  (HSAL_id_historico, 
HSAL_ds_email, 
ALER_nm_alerta, 
PROC_cd_processo, 
HSAL_ds_assunto_email, 
HSAL_ds_texto_email, 
HSAL_dt_envio, 
HSAL_dt_tentativa_ultimo_envio, 
HSAL_ds_mensagem, 
HSAL_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao)
  VALUES 
  (@HSAL_id_historico, 
@HSAL_ds_email, 
@ALER_nm_alerta, 
@PROC_cd_processo, 
@HSAL_ds_assunto_email, 
@HSAL_ds_texto_email, 
@HSAL_dt_envio, 
@HSAL_dt_tentativa_ultimo_envio, 
@HSAL_ds_mensagem, 
@HSAL_fl_status, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao)
 
GO
grant execute on sp_ins_tb_HSAL_historico_alerta to rl_exec_proc
go



 -- Tabela: tb_HSAL_historico_alerta - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_HSAL_historico_alerta]    ******/

-- SE A STORED PROCEDURE sp_del_tb_HSAL_historico_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_HSAL_historico_alerta')
  DROP PROCEDURE sp_del_tb_HSAL_historico_alerta
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_del_tb_HSAL_historico_alerta]
@HSAL_id_historico int = null 
 
AS
 
DELETE FROM 
tb_HSAL_historico_alerta
 where (@HSAL_id_historico is null or (@HSAL_id_historico is not null and HSAL_id_historico = @HSAL_id_historico))   

GO
grant execute on sp_del_tb_HSAL_historico_alerta to rl_exec_proc
GO




 -- Tabela: tb_HSAL_historico_alerta - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_HSAL_historico_alerta_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_HSAL_historico_alerta_cons')
  DROP PROCEDURE sp_sel_tb_HSAL_historico_alerta_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

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
HSAL_id_historico, 
HSAL_ds_email, 
ALER_nm_alerta, 
PROC_cd_processo, 
HSAL_ds_assunto_email, 
HSAL_ds_texto_email, 
HSAL_dt_envio, 
HSAL_dt_tentativa_ultimo_envio, 
HSAL_ds_mensagem, 
HSAL_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao ' 
+ ' from 
tb_HSAL_historico_alerta ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_HSAL_historico_alerta_cons to rl_exec_proc
GO








 -- Tabela: tb_LESI_log_erro_sistema - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_LESI_log_erro_sistema EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_LESI_log_erro_sistema')
  DROP PROCEDURE sp_sel_tb_LESI_log_erro_sistema
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema]
@LESI_cd_ocorrencia bigint = null 
 
AS
 
SELECT * FROM 
tb_LESI_log_erro_sistema
 where (@LESI_cd_ocorrencia is null or (@LESI_cd_ocorrencia is not null and LESI_cd_ocorrencia = @LESI_cd_ocorrencia))   


GO
grant execute on sp_sel_tb_LESI_log_erro_sistema to rl_exec_proc
GO




 -- Tabela: tb_LESI_log_erro_sistema - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_LESI_log_erro_sistema_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_LESI_log_erro_sistema_rel')
  DROP PROCEDURE sp_sel_tb_LESI_log_erro_sistema_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_LESI_log_erro_sistema table(
id int identity primary key, 
LESI_cd_ocorrencia bigint not null, 
LESI_nm_source varchar(100) not null, 
LESI_ds_exception varchar(8000) null, 
LESI_ds_inexception varchar(8000) null, 
LESI_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null
)



insert into 
@tb_LESI_log_erro_sistema
(LESI_cd_ocorrencia, 
LESI_nm_source, 
LESI_ds_exception, 
LESI_ds_inexception, 
LESI_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao) 

SELECT 
LESI_cd_ocorrencia, 
LESI_nm_source, 
LESI_ds_exception, 
LESI_ds_inexception, 
LESI_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao

FROM 
tb_LESI_log_erro_sistema

WHERE 

(@whereField is null OR 

 (@whereField = 'LESI_cd_ocorrencia' and rtrim(ltrim(LESI_cd_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'LESI_nm_source' and rtrim(ltrim(LESI_nm_source)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'LESI_ds_exception' and rtrim(ltrim(LESI_ds_exception)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'LESI_ds_inexception' and rtrim(ltrim(LESI_ds_inexception)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'LESI_dt_ocorrencia' and rtrim(ltrim(LESI_dt_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'LESI_cd_ocorrencia' and  @sortOrder='ASC' then LESI_cd_ocorrencia END ASC, 
 CASE when @sortField = 'LESI_cd_ocorrencia' and  @sortOrder='DESC' then LESI_cd_ocorrencia END DESC 
 ,  CASE when @sortField = 'LESI_nm_source' and  @sortOrder='ASC' then LESI_nm_source END ASC, 
 CASE when @sortField = 'LESI_nm_source' and  @sortOrder='DESC' then LESI_nm_source END DESC 
 ,  CASE when @sortField = 'LESI_ds_exception' and  @sortOrder='ASC' then LESI_ds_exception END ASC, 
 CASE when @sortField = 'LESI_ds_exception' and  @sortOrder='DESC' then LESI_ds_exception END DESC 
 ,  CASE when @sortField = 'LESI_ds_inexception' and  @sortOrder='ASC' then LESI_ds_inexception END ASC, 
 CASE when @sortField = 'LESI_ds_inexception' and  @sortOrder='DESC' then LESI_ds_inexception END DESC 
 ,  CASE when @sortField = 'LESI_dt_ocorrencia' and  @sortOrder='ASC' then LESI_dt_ocorrencia END ASC, 
 CASE when @sortField = 'LESI_dt_ocorrencia' and  @sortOrder='DESC' then LESI_dt_ocorrencia END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 

 
SELECT * FROM 
@tb_LESI_log_erro_sistema where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_LESI_log_erro_sistema_rel to rl_exec_proc
GO




 -- Tabela: tb_LESI_log_erro_sistema - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_LESI_log_erro_sistema]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_LESI_log_erro_sistema EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_LESI_log_erro_sistema')
  DROP PROCEDURE sp_upd_tb_LESI_log_erro_sistema
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE sp_upd_tb_LESI_log_erro_sistema
@LESI_cd_ocorrencia bigint = null , 
@LESI_nm_source varchar(100) = null , 
@LESI_ds_exception varchar(8000) = null , 
@LESI_ds_inexception varchar(8000) = null , 
@LESI_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null 
 
AS
 
UPDATE 
tb_LESI_log_erro_sistema 
SET 
LESI_nm_source = case when @LESI_nm_source is not null then @LESI_nm_source else LESI_nm_source end , 
LESI_ds_exception = case when @LESI_ds_exception is not null then @LESI_ds_exception else LESI_ds_exception end , 
LESI_ds_inexception = case when @LESI_ds_inexception is not null then @LESI_ds_inexception else LESI_ds_inexception end , 
LESI_dt_ocorrencia = case when @LESI_dt_ocorrencia is not null then (case when @LESI_dt_ocorrencia <> '00:00:01' then @LESI_dt_ocorrencia else null end) else LESI_dt_ocorrencia end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end  
 where (@LESI_cd_ocorrencia is null or (@LESI_cd_ocorrencia is not null and LESI_cd_ocorrencia = @LESI_cd_ocorrencia))  
 
GO
grant execute on sp_upd_tb_LESI_log_erro_sistema to rl_exec_proc
go



 -- Tabela: tb_LESI_log_erro_sistema - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_LESI_log_erro_sistema]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_LESI_log_erro_sistema EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_LESI_log_erro_sistema')
  DROP PROCEDURE sp_ins_tb_LESI_log_erro_sistema
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE sp_ins_tb_LESI_log_erro_sistema
@LESI_cd_ocorrencia bigint = null , 
@LESI_nm_source varchar(100) = null , 
@LESI_ds_exception varchar(8000) = null , 
@LESI_ds_inexception varchar(8000) = null , 
@LESI_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_LESI_log_erro_sistema
  (LESI_cd_ocorrencia, 
LESI_nm_source, 
LESI_ds_exception, 
LESI_ds_inexception, 
LESI_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao)
  VALUES 
  (@LESI_cd_ocorrencia, 
@LESI_nm_source, 
@LESI_ds_exception, 
@LESI_ds_inexception, 
@LESI_dt_ocorrencia, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao)
 
GO
grant execute on sp_ins_tb_LESI_log_erro_sistema to rl_exec_proc
go



 -- Tabela: tb_LESI_log_erro_sistema - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_LESI_log_erro_sistema]    ******/

-- SE A STORED PROCEDURE sp_del_tb_LESI_log_erro_sistema EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_LESI_log_erro_sistema')
  DROP PROCEDURE sp_del_tb_LESI_log_erro_sistema
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_del_tb_LESI_log_erro_sistema]
@LESI_cd_ocorrencia bigint = null 
 
AS
 
DELETE FROM 
tb_LESI_log_erro_sistema
 where (@LESI_cd_ocorrencia is null or (@LESI_cd_ocorrencia is not null and LESI_cd_ocorrencia = @LESI_cd_ocorrencia))   

GO
grant execute on sp_del_tb_LESI_log_erro_sistema to rl_exec_proc
GO




 -- Tabela: tb_LESI_log_erro_sistema - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_LESI_log_erro_sistema_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_LESI_log_erro_sistema_cons')
  DROP PROCEDURE sp_sel_tb_LESI_log_erro_sistema_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  LESI_cd_ocorrencia bigint not null, 
LESI_nm_source varchar(100) not null, 
LESI_ds_exception varchar(8000) null, 
LESI_ds_inexception varchar(8000) null, 
LESI_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
LESI_cd_ocorrencia, 
LESI_nm_source, 
LESI_ds_exception, 
LESI_ds_inexception, 
LESI_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao ' 
+ ' from 
tb_LESI_log_erro_sistema ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_LESI_log_erro_sistema_cons to rl_exec_proc
GO








 -- Tabela: tb_OPER_operador - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_OPER_operador EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_OPER_operador')
  DROP PROCEDURE sp_sel_tb_OPER_operador
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_OPER_operador]
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null 
 
AS
 
SELECT * FROM 
tb_OPER_operador
 where (@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  AND 
(@OPER_nm_operador is null or (@OPER_nm_operador is not null and OPER_nm_operador = @OPER_nm_operador))  AND 
(@OPER_ds_email is null or (@OPER_ds_email is not null and OPER_ds_email = @OPER_ds_email))   


GO
grant execute on sp_sel_tb_OPER_operador to rl_exec_proc
GO




 -- Tabela: tb_OPER_operador - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_OPER_operador_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_OPER_operador_rel')
  DROP PROCEDURE sp_sel_tb_OPER_operador_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_OPER_operador_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_OPER_operador table(
id int identity primary key, 
OPER_cd_operador varchar(20) not null, 
OPER_nm_operador varchar(1000) not null, 
OPER_ds_email varchar(200) not null, 
OPER_fl_alerta char(1) not null, 
OPER_fl_alerta_nativo char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_OPER_operador
(OPER_cd_operador, 
OPER_nm_operador, 
OPER_ds_email, 
OPER_fl_alerta, 
OPER_fl_alerta_nativo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
OPER_cd_operador, 
OPER_nm_operador, 
OPER_ds_email, 
OPER_fl_alerta, 
OPER_fl_alerta_nativo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_OPER_operador

WHERE 

(@whereField is null OR 

 (@whereField = 'OPER_cd_operador' and rtrim(ltrim(OPER_cd_operador)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_nm_operador' and rtrim(ltrim(OPER_nm_operador)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_ds_email' and rtrim(ltrim(OPER_ds_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_fl_alerta' and rtrim(ltrim(OPER_fl_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_fl_alerta_nativo' and rtrim(ltrim(OPER_fl_alerta_nativo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'OPER_cd_operador' and  @sortOrder='ASC' then OPER_cd_operador END ASC, 
 CASE when @sortField = 'OPER_cd_operador' and  @sortOrder='DESC' then OPER_cd_operador END DESC 
 ,  CASE when @sortField = 'OPER_nm_operador' and  @sortOrder='ASC' then OPER_nm_operador END ASC, 
 CASE when @sortField = 'OPER_nm_operador' and  @sortOrder='DESC' then OPER_nm_operador END DESC 
 ,  CASE when @sortField = 'OPER_ds_email' and  @sortOrder='ASC' then OPER_ds_email END ASC, 
 CASE when @sortField = 'OPER_ds_email' and  @sortOrder='DESC' then OPER_ds_email END DESC 
 ,  CASE when @sortField = 'OPER_fl_alerta' and  @sortOrder='ASC' then OPER_fl_alerta END ASC, 
 CASE when @sortField = 'OPER_fl_alerta' and  @sortOrder='DESC' then OPER_fl_alerta END DESC 
 ,  CASE when @sortField = 'OPER_fl_alerta_nativo' and  @sortOrder='ASC' then OPER_fl_alerta_nativo END ASC, 
 CASE when @sortField = 'OPER_fl_alerta_nativo' and  @sortOrder='DESC' then OPER_fl_alerta_nativo END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_OPER_operador where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_OPER_operador_rel to rl_exec_proc
GO




 -- Tabela: tb_OPER_operador - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_OPER_operador]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_OPER_operador EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_OPER_operador')
  DROP PROCEDURE sp_upd_tb_OPER_operador
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_OPER_operador
CREATE PROCEDURE sp_upd_tb_OPER_operador
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null , 
@OPER_fl_alerta char(1) = null , 
@OPER_fl_alerta_nativo char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_OPER_operador 
SET 
OPER_nm_operador = case when @OPER_nm_operador is not null then @OPER_nm_operador else OPER_nm_operador end , 
OPER_ds_email = case when @OPER_ds_email is not null then @OPER_ds_email else OPER_ds_email end , 
OPER_fl_alerta = case when @OPER_fl_alerta is not null then @OPER_fl_alerta else OPER_fl_alerta end , 
OPER_fl_alerta_nativo = case when @OPER_fl_alerta_nativo is not null then @OPER_fl_alerta_nativo else OPER_fl_alerta_nativo end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  
 
GO
grant execute on sp_upd_tb_OPER_operador to rl_exec_proc
go



 -- Tabela: tb_OPER_operador - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_OPER_operador]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_OPER_operador EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_OPER_operador')
  DROP PROCEDURE sp_ins_tb_OPER_operador
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_OPER_operador
CREATE PROCEDURE sp_ins_tb_OPER_operador
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null , 
@OPER_fl_alerta char(1) = null , 
@OPER_fl_alerta_nativo char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_OPER_operador
  (OPER_cd_operador, 
OPER_nm_operador, 
OPER_ds_email, 
OPER_fl_alerta, 
OPER_fl_alerta_nativo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@OPER_cd_operador, 
@OPER_nm_operador, 
@OPER_ds_email, 
@OPER_fl_alerta, 
@OPER_fl_alerta_nativo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_OPER_operador to rl_exec_proc
go



 -- Tabela: tb_OPER_operador - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_OPER_operador]    ******/

-- SE A STORED PROCEDURE sp_del_tb_OPER_operador EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_OPER_operador')
  DROP PROCEDURE sp_del_tb_OPER_operador
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_del_tb_OPER_operador]
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null 
 
AS
 
DELETE FROM 
tb_OPER_operador
 where (@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  AND 
(@OPER_nm_operador is null or (@OPER_nm_operador is not null and OPER_nm_operador = @OPER_nm_operador))  AND 
(@OPER_ds_email is null or (@OPER_ds_email is not null and OPER_ds_email = @OPER_ds_email))   

GO
grant execute on sp_del_tb_OPER_operador to rl_exec_proc
GO




 -- Tabela: tb_OPER_operador - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_OPER_operador_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_OPER_operador_cons')
  DROP PROCEDURE sp_sel_tb_OPER_operador_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_OPER_operador_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

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
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
OPER_cd_operador, 
OPER_nm_operador, 
OPER_ds_email, 
OPER_fl_alerta, 
OPER_fl_alerta_nativo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_OPER_operador ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_OPER_operador_cons to rl_exec_proc
GO








 -- Tabela: tb_PGER_parametro_geral - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_PGER_parametro_geral EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PGER_parametro_geral')
  DROP PROCEDURE sp_sel_tb_PGER_parametro_geral
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral]
@PGER_cd_parametro varchar(10) = null 
 
AS
 
SELECT * FROM 
tb_PGER_parametro_geral
 where (@PGER_cd_parametro is null or (@PGER_cd_parametro is not null and PGER_cd_parametro = @PGER_cd_parametro))   


GO
grant execute on sp_sel_tb_PGER_parametro_geral to rl_exec_proc
GO




 -- Tabela: tb_PGER_parametro_geral - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PGER_parametro_geral_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PGER_parametro_geral_rel')
  DROP PROCEDURE sp_sel_tb_PGER_parametro_geral_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PGER_parametro_geral table(
id int identity primary key, 
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



insert into 
@tb_PGER_parametro_geral
(PGER_cd_parametro, 
PGER_ds_parametro, 
PGER_vl_parametro, 
PGER_fl_tipo, 
PGER_fl_sistema, 
PGER_vl_range_min, 
PGER_vl_range_max, 
PGER_vl_padrao, 
PGER_vl_tamanho_min, 
PGER_vl_tamanho_max, 
PGER_vl_valores_permitidos, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
PGER_cd_parametro, 
PGER_ds_parametro, 
PGER_vl_parametro, 
PGER_fl_tipo, 
PGER_fl_sistema, 
PGER_vl_range_min, 
PGER_vl_range_max, 
PGER_vl_padrao, 
PGER_vl_tamanho_min, 
PGER_vl_tamanho_max, 
PGER_vl_valores_permitidos, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_PGER_parametro_geral

WHERE 

(@whereField is null OR 

 (@whereField = 'PGER_cd_parametro' and rtrim(ltrim(PGER_cd_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_ds_parametro' and rtrim(ltrim(PGER_ds_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_parametro' and rtrim(ltrim(PGER_vl_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_fl_tipo' and rtrim(ltrim(PGER_fl_tipo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_fl_sistema' and rtrim(ltrim(PGER_fl_sistema)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_range_min' and rtrim(ltrim(PGER_vl_range_min)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_range_max' and rtrim(ltrim(PGER_vl_range_max)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_padrao' and rtrim(ltrim(PGER_vl_padrao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_tamanho_min' and rtrim(ltrim(PGER_vl_tamanho_min)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_tamanho_max' and rtrim(ltrim(PGER_vl_tamanho_max)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_valores_permitidos' and rtrim(ltrim(PGER_vl_valores_permitidos)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PGER_cd_parametro' and  @sortOrder='ASC' then PGER_cd_parametro END ASC, 
 CASE when @sortField = 'PGER_cd_parametro' and  @sortOrder='DESC' then PGER_cd_parametro END DESC 
 ,  CASE when @sortField = 'PGER_ds_parametro' and  @sortOrder='ASC' then PGER_ds_parametro END ASC, 
 CASE when @sortField = 'PGER_ds_parametro' and  @sortOrder='DESC' then PGER_ds_parametro END DESC 
 ,  CASE when @sortField = 'PGER_vl_parametro' and  @sortOrder='ASC' then PGER_vl_parametro END ASC, 
 CASE when @sortField = 'PGER_vl_parametro' and  @sortOrder='DESC' then PGER_vl_parametro END DESC 
 ,  CASE when @sortField = 'PGER_fl_tipo' and  @sortOrder='ASC' then PGER_fl_tipo END ASC, 
 CASE when @sortField = 'PGER_fl_tipo' and  @sortOrder='DESC' then PGER_fl_tipo END DESC 
 ,  CASE when @sortField = 'PGER_fl_sistema' and  @sortOrder='ASC' then PGER_fl_sistema END ASC, 
 CASE when @sortField = 'PGER_fl_sistema' and  @sortOrder='DESC' then PGER_fl_sistema END DESC 
 ,  CASE when @sortField = 'PGER_vl_range_min' and  @sortOrder='ASC' then PGER_vl_range_min END ASC, 
 CASE when @sortField = 'PGER_vl_range_min' and  @sortOrder='DESC' then PGER_vl_range_min END DESC 
 ,  CASE when @sortField = 'PGER_vl_range_max' and  @sortOrder='ASC' then PGER_vl_range_max END ASC, 
 CASE when @sortField = 'PGER_vl_range_max' and  @sortOrder='DESC' then PGER_vl_range_max END DESC 
 ,  CASE when @sortField = 'PGER_vl_padrao' and  @sortOrder='ASC' then PGER_vl_padrao END ASC, 
 CASE when @sortField = 'PGER_vl_padrao' and  @sortOrder='DESC' then PGER_vl_padrao END DESC 
 ,  CASE when @sortField = 'PGER_vl_tamanho_min' and  @sortOrder='ASC' then PGER_vl_tamanho_min END ASC, 
 CASE when @sortField = 'PGER_vl_tamanho_min' and  @sortOrder='DESC' then PGER_vl_tamanho_min END DESC 
 ,  CASE when @sortField = 'PGER_vl_tamanho_max' and  @sortOrder='ASC' then PGER_vl_tamanho_max END ASC, 
 CASE when @sortField = 'PGER_vl_tamanho_max' and  @sortOrder='DESC' then PGER_vl_tamanho_max END DESC 
 ,  CASE when @sortField = 'PGER_vl_valores_permitidos' and  @sortOrder='ASC' then PGER_vl_valores_permitidos END ASC, 
 CASE when @sortField = 'PGER_vl_valores_permitidos' and  @sortOrder='DESC' then PGER_vl_valores_permitidos END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PGER_parametro_geral where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PGER_parametro_geral_rel to rl_exec_proc
GO




 -- Tabela: tb_PGER_parametro_geral - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PGER_parametro_geral]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_PGER_parametro_geral EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_PGER_parametro_geral')
  DROP PROCEDURE sp_upd_tb_PGER_parametro_geral
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE sp_upd_tb_PGER_parametro_geral
@PGER_cd_parametro varchar(10) = null , 
@PGER_ds_parametro varchar(100) = null , 
@PGER_vl_parametro varchar(1000) = null , 
@PGER_fl_tipo char(1) = null , 
@PGER_fl_sistema char(1) = null , 
@PGER_vl_range_min bigint = null , 
@PGER_vl_range_max bigint = null , 
@PGER_vl_padrao varchar(1000) = null , 
@PGER_vl_tamanho_min int = null , 
@PGER_vl_tamanho_max int = null , 
@PGER_vl_valores_permitidos varchar(8000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PGER_parametro_geral 
SET 
PGER_ds_parametro = case when @PGER_ds_parametro is not null then @PGER_ds_parametro else PGER_ds_parametro end , 
PGER_vl_parametro = case when @PGER_vl_parametro is not null then @PGER_vl_parametro else PGER_vl_parametro end , 
PGER_fl_tipo = case when @PGER_fl_tipo is not null then @PGER_fl_tipo else PGER_fl_tipo end , 
PGER_fl_sistema = case when @PGER_fl_sistema is not null then @PGER_fl_sistema else PGER_fl_sistema end , 
PGER_vl_range_min = case when @PGER_vl_range_min is not null then @PGER_vl_range_min else PGER_vl_range_min end , 
PGER_vl_range_max = case when @PGER_vl_range_max is not null then @PGER_vl_range_max else PGER_vl_range_max end , 
PGER_vl_padrao = case when @PGER_vl_padrao is not null then @PGER_vl_padrao else PGER_vl_padrao end , 
PGER_vl_tamanho_min = case when @PGER_vl_tamanho_min is not null then @PGER_vl_tamanho_min else PGER_vl_tamanho_min end , 
PGER_vl_tamanho_max = case when @PGER_vl_tamanho_max is not null then @PGER_vl_tamanho_max else PGER_vl_tamanho_max end , 
PGER_vl_valores_permitidos = case when @PGER_vl_valores_permitidos is not null then @PGER_vl_valores_permitidos else PGER_vl_valores_permitidos end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PGER_cd_parametro is null or (@PGER_cd_parametro is not null and PGER_cd_parametro = @PGER_cd_parametro))  
 
GO
grant execute on sp_upd_tb_PGER_parametro_geral to rl_exec_proc
go



 -- Tabela: tb_PGER_parametro_geral - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PGER_parametro_geral]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_PGER_parametro_geral EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_PGER_parametro_geral')
  DROP PROCEDURE sp_ins_tb_PGER_parametro_geral
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE sp_ins_tb_PGER_parametro_geral
@PGER_cd_parametro varchar(10) = null , 
@PGER_ds_parametro varchar(100) = null , 
@PGER_vl_parametro varchar(1000) = null , 
@PGER_fl_tipo char(1) = null , 
@PGER_fl_sistema char(1) = null , 
@PGER_vl_range_min bigint = null , 
@PGER_vl_range_max bigint = null , 
@PGER_vl_padrao varchar(1000) = null , 
@PGER_vl_tamanho_min int = null , 
@PGER_vl_tamanho_max int = null , 
@PGER_vl_valores_permitidos varchar(8000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PGER_parametro_geral
  (PGER_cd_parametro, 
PGER_ds_parametro, 
PGER_vl_parametro, 
PGER_fl_tipo, 
PGER_fl_sistema, 
PGER_vl_range_min, 
PGER_vl_range_max, 
PGER_vl_padrao, 
PGER_vl_tamanho_min, 
PGER_vl_tamanho_max, 
PGER_vl_valores_permitidos, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PGER_cd_parametro, 
@PGER_ds_parametro, 
@PGER_vl_parametro, 
@PGER_fl_tipo, 
@PGER_fl_sistema, 
@PGER_vl_range_min, 
@PGER_vl_range_max, 
@PGER_vl_padrao, 
@PGER_vl_tamanho_min, 
@PGER_vl_tamanho_max, 
@PGER_vl_valores_permitidos, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_PGER_parametro_geral to rl_exec_proc
go



 -- Tabela: tb_PGER_parametro_geral - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PGER_parametro_geral]    ******/

-- SE A STORED PROCEDURE sp_del_tb_PGER_parametro_geral EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_PGER_parametro_geral')
  DROP PROCEDURE sp_del_tb_PGER_parametro_geral
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_del_tb_PGER_parametro_geral]
@PGER_cd_parametro varchar(10) = null 
 
AS
 
DELETE FROM 
tb_PGER_parametro_geral
 where (@PGER_cd_parametro is null or (@PGER_cd_parametro is not null and PGER_cd_parametro = @PGER_cd_parametro))   

GO
grant execute on sp_del_tb_PGER_parametro_geral to rl_exec_proc
GO




 -- Tabela: tb_PGER_parametro_geral - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PGER_parametro_geral_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PGER_parametro_geral_cons')
  DROP PROCEDURE sp_sel_tb_PGER_parametro_geral_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

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
PGER_cd_parametro, 
PGER_ds_parametro, 
PGER_vl_parametro, 
PGER_fl_tipo, 
PGER_fl_sistema, 
PGER_vl_range_min, 
PGER_vl_range_max, 
PGER_vl_padrao, 
PGER_vl_tamanho_min, 
PGER_vl_tamanho_max, 
PGER_vl_valores_permitidos, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_PGER_parametro_geral ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_PGER_parametro_geral_cons to rl_exec_proc
GO








 -- Tabela: tb_PRAL_processo_alerta - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_PRAL_processo_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PRAL_processo_alerta')
  DROP PROCEDURE sp_sel_tb_PRAL_processo_alerta
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta]
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_PRAL_processo_alerta
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))   


GO
grant execute on sp_sel_tb_PRAL_processo_alerta to rl_exec_proc
GO




 -- Tabela: tb_PRAL_processo_alerta - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PRAL_processo_alerta_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PRAL_processo_alerta_rel')
  DROP PROCEDURE sp_sel_tb_PRAL_processo_alerta_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PRAL_processo_alerta table(
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ALER_nm_alerta varchar(50) not null, 
PRAL_fl_manutencao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PRAL_processo_alerta
(PROC_cd_processo, 
ALER_nm_alerta, 
PRAL_fl_manutencao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
PROC_cd_processo, 
ALER_nm_alerta, 
PRAL_fl_manutencao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_PRAL_processo_alerta

WHERE 

(@whereField is null OR 

 (@whereField = 'PROC_cd_processo' and rtrim(ltrim(PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_nm_alerta' and rtrim(ltrim(ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PRAL_fl_manutencao' and rtrim(ltrim(PRAL_fl_manutencao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='ASC' then ALER_nm_alerta END ASC, 
 CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='DESC' then ALER_nm_alerta END DESC 
 ,  CASE when @sortField = 'PRAL_fl_manutencao' and  @sortOrder='ASC' then PRAL_fl_manutencao END ASC, 
 CASE when @sortField = 'PRAL_fl_manutencao' and  @sortOrder='DESC' then PRAL_fl_manutencao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PRAL_processo_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PRAL_processo_alerta_rel to rl_exec_proc
GO




 -- Tabela: tb_PRAL_processo_alerta - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRAL_processo_alerta]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_PRAL_processo_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_PRAL_processo_alerta')
  DROP PROCEDURE sp_upd_tb_PRAL_processo_alerta
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE sp_upd_tb_PRAL_processo_alerta
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PRAL_fl_manutencao char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PRAL_processo_alerta 
SET 
PRAL_fl_manutencao = case when @PRAL_fl_manutencao is not null then @PRAL_fl_manutencao else PRAL_fl_manutencao end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))  
 
GO
grant execute on sp_upd_tb_PRAL_processo_alerta to rl_exec_proc
go



 -- Tabela: tb_PRAL_processo_alerta - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRAL_processo_alerta]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_PRAL_processo_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_PRAL_processo_alerta')
  DROP PROCEDURE sp_ins_tb_PRAL_processo_alerta
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE sp_ins_tb_PRAL_processo_alerta
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PRAL_fl_manutencao char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PRAL_processo_alerta
  (PROC_cd_processo, 
ALER_nm_alerta, 
PRAL_fl_manutencao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ALER_nm_alerta, 
@PRAL_fl_manutencao, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_PRAL_processo_alerta to rl_exec_proc
go



 -- Tabela: tb_PRAL_processo_alerta - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRAL_processo_alerta]    ******/

-- SE A STORED PROCEDURE sp_del_tb_PRAL_processo_alerta EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_PRAL_processo_alerta')
  DROP PROCEDURE sp_del_tb_PRAL_processo_alerta
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_del_tb_PRAL_processo_alerta]
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null 
 
AS
 
DELETE FROM 
tb_PRAL_processo_alerta
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))   

GO
grant execute on sp_del_tb_PRAL_processo_alerta to rl_exec_proc
GO




 -- Tabela: tb_PRAL_processo_alerta - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PRAL_processo_alerta_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PRAL_processo_alerta_cons')
  DROP PROCEDURE sp_sel_tb_PRAL_processo_alerta_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ALER_nm_alerta varchar(50) not null, 
PRAL_fl_manutencao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
PROC_cd_processo, 
ALER_nm_alerta, 
PRAL_fl_manutencao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_PRAL_processo_alerta ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_PRAL_processo_alerta_cons to rl_exec_proc
GO








 -- Tabela: tb_PREV_processo_evento - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_PREV_processo_evento EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PREV_processo_evento')
  DROP PROCEDURE sp_sel_tb_PREV_processo_evento
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento]
@PROC_cd_processo varchar(50) = null , 
@PREV_cd_evento varchar(20) = null 
 
AS
 
SELECT * FROM 
tb_PREV_processo_evento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PREV_cd_evento is null or (@PREV_cd_evento is not null and PREV_cd_evento = @PREV_cd_evento))   


GO
grant execute on sp_sel_tb_PREV_processo_evento to rl_exec_proc
GO




 -- Tabela: tb_PREV_processo_evento - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PREV_processo_evento_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PREV_processo_evento_rel')
  DROP PROCEDURE sp_sel_tb_PREV_processo_evento_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PREV_processo_evento table(
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
PREV_cd_evento varchar(20) not null, 
PREV_ds_evento varchar(3000) null, 
PREV_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PREV_processo_evento
(PROC_cd_processo, 
PREV_cd_evento, 
PREV_ds_evento, 
PREV_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
PROC_cd_processo, 
PREV_cd_evento, 
PREV_ds_evento, 
PREV_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_PREV_processo_evento

WHERE 

(@whereField is null OR 

 (@whereField = 'PROC_cd_processo' and rtrim(ltrim(PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PREV_cd_evento' and rtrim(ltrim(PREV_cd_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PREV_ds_evento' and rtrim(ltrim(PREV_ds_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PREV_dt_ocorrencia' and rtrim(ltrim(PREV_dt_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'PREV_cd_evento' and  @sortOrder='ASC' then PREV_cd_evento END ASC, 
 CASE when @sortField = 'PREV_cd_evento' and  @sortOrder='DESC' then PREV_cd_evento END DESC 
 ,  CASE when @sortField = 'PREV_ds_evento' and  @sortOrder='ASC' then PREV_ds_evento END ASC, 
 CASE when @sortField = 'PREV_ds_evento' and  @sortOrder='DESC' then PREV_ds_evento END DESC 
 ,  CASE when @sortField = 'PREV_dt_ocorrencia' and  @sortOrder='ASC' then PREV_dt_ocorrencia END ASC, 
 CASE when @sortField = 'PREV_dt_ocorrencia' and  @sortOrder='DESC' then PREV_dt_ocorrencia END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PREV_processo_evento where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PREV_processo_evento_rel to rl_exec_proc
GO




 -- Tabela: tb_PREV_processo_evento - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PREV_processo_evento]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_PREV_processo_evento EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_PREV_processo_evento')
  DROP PROCEDURE sp_upd_tb_PREV_processo_evento
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PREV_processo_evento
CREATE PROCEDURE sp_upd_tb_PREV_processo_evento
@PROC_cd_processo varchar(50) = null , 
@PREV_cd_evento varchar(20) = null , 
@PREV_ds_evento varchar(3000) = null , 
@PREV_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PREV_processo_evento 
SET 
PREV_ds_evento = case when @PREV_ds_evento is not null then @PREV_ds_evento else PREV_ds_evento end , 
PREV_dt_ocorrencia = case when @PREV_dt_ocorrencia is not null then (case when @PREV_dt_ocorrencia <> '00:00:01' then @PREV_dt_ocorrencia else null end) else PREV_dt_ocorrencia end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PREV_cd_evento is null or (@PREV_cd_evento is not null and PREV_cd_evento = @PREV_cd_evento))  
 
GO
grant execute on sp_upd_tb_PREV_processo_evento to rl_exec_proc
go



 -- Tabela: tb_PREV_processo_evento - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PREV_processo_evento]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_PREV_processo_evento EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_PREV_processo_evento')
  DROP PROCEDURE sp_ins_tb_PREV_processo_evento
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PREV_processo_evento
CREATE PROCEDURE sp_ins_tb_PREV_processo_evento
@PROC_cd_processo varchar(50) = null , 
@PREV_cd_evento varchar(20) = null , 
@PREV_ds_evento varchar(3000) = null , 
@PREV_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PREV_processo_evento
  (PROC_cd_processo, 
PREV_cd_evento, 
PREV_ds_evento, 
PREV_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@PREV_cd_evento, 
@PREV_ds_evento, 
@PREV_dt_ocorrencia, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_PREV_processo_evento to rl_exec_proc
go



 -- Tabela: tb_PREV_processo_evento - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PREV_processo_evento]    ******/

-- SE A STORED PROCEDURE sp_del_tb_PREV_processo_evento EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_PREV_processo_evento')
  DROP PROCEDURE sp_del_tb_PREV_processo_evento
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_del_tb_PREV_processo_evento]
@PROC_cd_processo varchar(50) = null , 
@PREV_cd_evento varchar(20) = null 
 
AS
 
DELETE FROM 
tb_PREV_processo_evento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PREV_cd_evento is null or (@PREV_cd_evento is not null and PREV_cd_evento = @PREV_cd_evento))   

GO
grant execute on sp_del_tb_PREV_processo_evento to rl_exec_proc
GO




 -- Tabela: tb_PREV_processo_evento - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PREV_processo_evento_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PREV_processo_evento_cons')
  DROP PROCEDURE sp_sel_tb_PREV_processo_evento_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
PREV_cd_evento varchar(20) not null, 
PREV_ds_evento varchar(3000) null, 
PREV_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
PROC_cd_processo, 
PREV_cd_evento, 
PREV_ds_evento, 
PREV_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_PREV_processo_evento ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_PREV_processo_evento_cons to rl_exec_proc
GO








 -- Tabela: tb_PROC_processo - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_PROC_processo EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PROC_processo')
  DROP PROCEDURE sp_sel_tb_PROC_processo
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_sel_tb_PROC_processo]
@PROC_cd_processo varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_PROC_processo
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   


GO
grant execute on sp_sel_tb_PROC_processo to rl_exec_proc
GO




 -- Tabela: tb_PROC_processo - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PROC_processo_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PROC_processo_rel')
  DROP PROCEDURE sp_sel_tb_PROC_processo_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_sel_tb_PROC_processo_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PROC_processo table(
id int identity primary key, 
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
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PROC_processo
(PROC_cd_processo, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
PROC_cd_processo, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_PROC_processo

WHERE 

(@whereField is null OR 

 (@whereField = 'PROC_cd_processo' and rtrim(ltrim(PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_titular' and rtrim(ltrim(PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_vl_ano' and rtrim(ltrim(PROC_vl_ano)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_nm_processo' and rtrim(ltrim(PROC_nm_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_id_processo' and rtrim(ltrim(PROC_id_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'FASE_cd_fase' and rtrim(ltrim(FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_ultimo_evento' and rtrim(ltrim(PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_substancia' and rtrim(ltrim(PROC_ds_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_area' and rtrim(ltrim(PROC_ds_area)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_uso' and rtrim(ltrim(PROC_ds_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_link' and rtrim(ltrim(PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_cd_unidade_federativa' and rtrim(ltrim(UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_fl_tipo_inclusao' and rtrim(ltrim(PROC_fl_tipo_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'PROC_ds_titular' and  @sortOrder='ASC' then PROC_ds_titular END ASC, 
 CASE when @sortField = 'PROC_ds_titular' and  @sortOrder='DESC' then PROC_ds_titular END DESC 
 ,  CASE when @sortField = 'PROC_vl_ano' and  @sortOrder='ASC' then PROC_vl_ano END ASC, 
 CASE when @sortField = 'PROC_vl_ano' and  @sortOrder='DESC' then PROC_vl_ano END DESC 
 ,  CASE when @sortField = 'PROC_nm_processo' and  @sortOrder='ASC' then PROC_nm_processo END ASC, 
 CASE when @sortField = 'PROC_nm_processo' and  @sortOrder='DESC' then PROC_nm_processo END DESC 
 ,  CASE when @sortField = 'PROC_id_processo' and  @sortOrder='ASC' then PROC_id_processo END ASC, 
 CASE when @sortField = 'PROC_id_processo' and  @sortOrder='DESC' then PROC_id_processo END DESC 
 ,  CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='ASC' then FASE_cd_fase END ASC, 
 CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='DESC' then FASE_cd_fase END DESC 
 ,  CASE when @sortField = 'PROC_ds_ultimo_evento' and  @sortOrder='ASC' then PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = 'PROC_ds_ultimo_evento' and  @sortOrder='DESC' then PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = 'PROC_ds_substancia' and  @sortOrder='ASC' then PROC_ds_substancia END ASC, 
 CASE when @sortField = 'PROC_ds_substancia' and  @sortOrder='DESC' then PROC_ds_substancia END DESC 
 ,  CASE when @sortField = 'PROC_ds_area' and  @sortOrder='ASC' then PROC_ds_area END ASC, 
 CASE when @sortField = 'PROC_ds_area' and  @sortOrder='DESC' then PROC_ds_area END DESC 
 ,  CASE when @sortField = 'PROC_ds_uso' and  @sortOrder='ASC' then PROC_ds_uso END ASC, 
 CASE when @sortField = 'PROC_ds_uso' and  @sortOrder='DESC' then PROC_ds_uso END DESC 
 ,  CASE when @sortField = 'PROC_ds_link' and  @sortOrder='ASC' then PROC_ds_link END ASC, 
 CASE when @sortField = 'PROC_ds_link' and  @sortOrder='DESC' then PROC_ds_link END DESC 
 ,  CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='ASC' then UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='DESC' then UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = 'PROC_fl_tipo_inclusao' and  @sortOrder='ASC' then PROC_fl_tipo_inclusao END ASC, 
 CASE when @sortField = 'PROC_fl_tipo_inclusao' and  @sortOrder='DESC' then PROC_fl_tipo_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PROC_processo where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PROC_processo_rel to rl_exec_proc
GO




 -- Tabela: tb_PROC_processo - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PROC_processo]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_PROC_processo EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_PROC_processo')
  DROP PROCEDURE sp_upd_tb_PROC_processo
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PROC_processo
CREATE PROCEDURE sp_upd_tb_PROC_processo
@PROC_cd_processo varchar(50) = null , 
@PROC_ds_titular varchar(300) = null , 
@PROC_vl_ano int = null , 
@PROC_nm_processo varchar(50) = null , 
@PROC_id_processo varchar(300) = null , 
@FASE_cd_fase int = null , 
@PROC_ds_ultimo_evento varchar(3000) = null , 
@PROC_ds_substancia varchar(100) = null , 
@PROC_ds_area varchar(30) = null , 
@PROC_ds_uso varchar(200) = null , 
@PROC_ds_link varchar(150) = null , 
@UNFE_cd_unidade_federativa char(2) = null , 
@PROC_fl_tipo_inclusao char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PROC_processo 
SET 
PROC_ds_titular = case when @PROC_ds_titular is not null then @PROC_ds_titular else PROC_ds_titular end , 
PROC_vl_ano = case when @PROC_vl_ano is not null then @PROC_vl_ano else PROC_vl_ano end , 
PROC_nm_processo = case when @PROC_nm_processo is not null then @PROC_nm_processo else PROC_nm_processo end , 
PROC_id_processo = case when @PROC_id_processo is not null then @PROC_id_processo else PROC_id_processo end , 
FASE_cd_fase = case when @FASE_cd_fase is not null then @FASE_cd_fase else FASE_cd_fase end , 
PROC_ds_ultimo_evento = case when @PROC_ds_ultimo_evento is not null then @PROC_ds_ultimo_evento else PROC_ds_ultimo_evento end , 
PROC_ds_substancia = case when @PROC_ds_substancia is not null then @PROC_ds_substancia else PROC_ds_substancia end , 
PROC_ds_area = case when @PROC_ds_area is not null then @PROC_ds_area else PROC_ds_area end , 
PROC_ds_uso = case when @PROC_ds_uso is not null then @PROC_ds_uso else PROC_ds_uso end , 
PROC_ds_link = case when @PROC_ds_link is not null then @PROC_ds_link else PROC_ds_link end , 
UNFE_cd_unidade_federativa = case when @UNFE_cd_unidade_federativa is not null then @UNFE_cd_unidade_federativa else UNFE_cd_unidade_federativa end , 
PROC_fl_tipo_inclusao = case when @PROC_fl_tipo_inclusao is not null then @PROC_fl_tipo_inclusao else PROC_fl_tipo_inclusao end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  
 
GO
grant execute on sp_upd_tb_PROC_processo to rl_exec_proc
go



 -- Tabela: tb_PROC_processo - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PROC_processo]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_PROC_processo EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_PROC_processo')
  DROP PROCEDURE sp_ins_tb_PROC_processo
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PROC_processo
CREATE PROCEDURE sp_ins_tb_PROC_processo
@PROC_cd_processo varchar(50) = null , 
@PROC_ds_titular varchar(300) = null , 
@PROC_vl_ano int = null , 
@PROC_nm_processo varchar(50) = null , 
@PROC_id_processo varchar(300) = null , 
@FASE_cd_fase int = null , 
@PROC_ds_ultimo_evento varchar(3000) = null , 
@PROC_ds_substancia varchar(100) = null , 
@PROC_ds_area varchar(30) = null , 
@PROC_ds_uso varchar(200) = null , 
@PROC_ds_link varchar(150) = null , 
@UNFE_cd_unidade_federativa char(2) = null , 
@PROC_fl_tipo_inclusao char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PROC_processo
  (PROC_cd_processo, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@PROC_ds_titular, 
@PROC_vl_ano, 
@PROC_nm_processo, 
@PROC_id_processo, 
@FASE_cd_fase, 
@PROC_ds_ultimo_evento, 
@PROC_ds_substancia, 
@PROC_ds_area, 
@PROC_ds_uso, 
@PROC_ds_link, 
@UNFE_cd_unidade_federativa, 
@PROC_fl_tipo_inclusao, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_PROC_processo to rl_exec_proc
go



 -- Tabela: tb_PROC_processo - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PROC_processo]    ******/

-- SE A STORED PROCEDURE sp_del_tb_PROC_processo EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_PROC_processo')
  DROP PROCEDURE sp_del_tb_PROC_processo
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_del_tb_PROC_processo]
@PROC_cd_processo varchar(50) = null 
 
AS
 
DELETE FROM 
tb_PROC_processo
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   

GO
grant execute on sp_del_tb_PROC_processo to rl_exec_proc
GO




 -- Tabela: tb_PROC_processo - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PROC_processo_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PROC_processo_cons')
  DROP PROCEDURE sp_sel_tb_PROC_processo_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_sel_tb_PROC_processo_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

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
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
PROC_cd_processo, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_PROC_processo ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_PROC_processo_cons to rl_exec_proc
GO








 -- Tabela: tb_PROP_processo_operador - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_PROP_processo_operador EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PROP_processo_operador')
  DROP PROCEDURE sp_sel_tb_PROP_processo_operador
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador]
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null 
 
AS
 
SELECT * FROM 
tb_PROP_processo_operador
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))   


GO
grant execute on sp_sel_tb_PROP_processo_operador to rl_exec_proc
GO




 -- Tabela: tb_PROP_processo_operador - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PROP_processo_operador_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PROP_processo_operador_rel')
  DROP PROCEDURE sp_sel_tb_PROP_processo_operador_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PROP_processo_operador table(
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
OPER_cd_operador varchar(20) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PROP_processo_operador
(PROC_cd_processo, 
OPER_cd_operador, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
PROC_cd_processo, 
OPER_cd_operador, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_PROP_processo_operador

WHERE 

(@whereField is null OR 

 (@whereField = 'PROC_cd_processo' and rtrim(ltrim(PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_cd_operador' and rtrim(ltrim(OPER_cd_operador)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'OPER_cd_operador' and  @sortOrder='ASC' then OPER_cd_operador END ASC, 
 CASE when @sortField = 'OPER_cd_operador' and  @sortOrder='DESC' then OPER_cd_operador END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PROP_processo_operador where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PROP_processo_operador_rel to rl_exec_proc
GO




 -- Tabela: tb_PROP_processo_operador - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PROP_processo_operador]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_PROP_processo_operador EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_PROP_processo_operador')
  DROP PROCEDURE sp_upd_tb_PROP_processo_operador
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PROP_processo_operador
CREATE PROCEDURE sp_upd_tb_PROP_processo_operador
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PROP_processo_operador 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  
 
GO
grant execute on sp_upd_tb_PROP_processo_operador to rl_exec_proc
go



 -- Tabela: tb_PROP_processo_operador - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PROP_processo_operador]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_PROP_processo_operador EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_PROP_processo_operador')
  DROP PROCEDURE sp_ins_tb_PROP_processo_operador
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PROP_processo_operador
CREATE PROCEDURE sp_ins_tb_PROP_processo_operador
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PROP_processo_operador
  (PROC_cd_processo, 
OPER_cd_operador, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@OPER_cd_operador, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_PROP_processo_operador to rl_exec_proc
go



 -- Tabela: tb_PROP_processo_operador - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PROP_processo_operador]    ******/

-- SE A STORED PROCEDURE sp_del_tb_PROP_processo_operador EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_PROP_processo_operador')
  DROP PROCEDURE sp_del_tb_PROP_processo_operador
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_del_tb_PROP_processo_operador]
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null 
 
AS
 
DELETE FROM 
tb_PROP_processo_operador
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))   

GO
grant execute on sp_del_tb_PROP_processo_operador to rl_exec_proc
GO




 -- Tabela: tb_PROP_processo_operador - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_PROP_processo_operador_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_PROP_processo_operador_cons')
  DROP PROCEDURE sp_sel_tb_PROP_processo_operador_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
OPER_cd_operador varchar(20) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
'insert into 
#Temporary_Table 
select  
PROC_cd_processo, 
OPER_cd_operador, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_PROP_processo_operador ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_PROP_processo_operador_cons to rl_exec_proc
GO








 -- Tabela: tb_ROTI_rotina - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_ROTI_rotina EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ROTI_rotina')
  DROP PROCEDURE sp_sel_tb_ROTI_rotina
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina]
@ROTI_nm_rotina varchar(30) = null 
 
AS
 
SELECT * FROM 
tb_ROTI_rotina
 where (@ROTI_nm_rotina is null or (@ROTI_nm_rotina is not null and ROTI_nm_rotina = @ROTI_nm_rotina))   


GO
grant execute on sp_sel_tb_ROTI_rotina to rl_exec_proc
GO




 -- Tabela: tb_ROTI_rotina - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_ROTI_rotina_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ROTI_rotina_rel')
  DROP PROCEDURE sp_sel_tb_ROTI_rotina_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_ROTI_rotina table(
id int identity primary key, 
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



insert into 
@tb_ROTI_rotina
(ROTI_nm_rotina, 
ROTI_ds_rotina, 
ROTI_dt_ultima_execucao, 
ROTI_dt_ultima_tentativa_execucao, 
ROTI_fl_status_execucao, 
ROTI_ds_mensagem, 
ROTI_vl_tempo_medio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
ROTI_nm_rotina, 
ROTI_ds_rotina, 
ROTI_dt_ultima_execucao, 
ROTI_dt_ultima_tentativa_execucao, 
ROTI_fl_status_execucao, 
ROTI_ds_mensagem, 
ROTI_vl_tempo_medio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_ROTI_rotina

WHERE 

(@whereField is null OR 

 (@whereField = 'ROTI_nm_rotina' and rtrim(ltrim(ROTI_nm_rotina)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_ds_rotina' and rtrim(ltrim(ROTI_ds_rotina)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_dt_ultima_execucao' and rtrim(ltrim(ROTI_dt_ultima_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_dt_ultima_tentativa_execucao' and rtrim(ltrim(ROTI_dt_ultima_tentativa_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_fl_status_execucao' and rtrim(ltrim(ROTI_fl_status_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_ds_mensagem' and rtrim(ltrim(ROTI_ds_mensagem)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_vl_tempo_medio' and rtrim(ltrim(ROTI_vl_tempo_medio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'ROTI_nm_rotina' and  @sortOrder='ASC' then ROTI_nm_rotina END ASC, 
 CASE when @sortField = 'ROTI_nm_rotina' and  @sortOrder='DESC' then ROTI_nm_rotina END DESC 
 ,  CASE when @sortField = 'ROTI_ds_rotina' and  @sortOrder='ASC' then ROTI_ds_rotina END ASC, 
 CASE when @sortField = 'ROTI_ds_rotina' and  @sortOrder='DESC' then ROTI_ds_rotina END DESC 
 ,  CASE when @sortField = 'ROTI_dt_ultima_execucao' and  @sortOrder='ASC' then ROTI_dt_ultima_execucao END ASC, 
 CASE when @sortField = 'ROTI_dt_ultima_execucao' and  @sortOrder='DESC' then ROTI_dt_ultima_execucao END DESC 
 ,  CASE when @sortField = 'ROTI_dt_ultima_tentativa_execucao' and  @sortOrder='ASC' then ROTI_dt_ultima_tentativa_execucao END ASC, 
 CASE when @sortField = 'ROTI_dt_ultima_tentativa_execucao' and  @sortOrder='DESC' then ROTI_dt_ultima_tentativa_execucao END DESC 
 ,  CASE when @sortField = 'ROTI_fl_status_execucao' and  @sortOrder='ASC' then ROTI_fl_status_execucao END ASC, 
 CASE when @sortField = 'ROTI_fl_status_execucao' and  @sortOrder='DESC' then ROTI_fl_status_execucao END DESC 
 ,  CASE when @sortField = 'ROTI_ds_mensagem' and  @sortOrder='ASC' then ROTI_ds_mensagem END ASC, 
 CASE when @sortField = 'ROTI_ds_mensagem' and  @sortOrder='DESC' then ROTI_ds_mensagem END DESC 
 ,  CASE when @sortField = 'ROTI_vl_tempo_medio' and  @sortOrder='ASC' then ROTI_vl_tempo_medio END ASC, 
 CASE when @sortField = 'ROTI_vl_tempo_medio' and  @sortOrder='DESC' then ROTI_vl_tempo_medio END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_ROTI_rotina where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_ROTI_rotina_rel to rl_exec_proc
GO




 -- Tabela: tb_ROTI_rotina - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_ROTI_rotina]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_ROTI_rotina EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_ROTI_rotina')
  DROP PROCEDURE sp_upd_tb_ROTI_rotina
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_ROTI_rotina
CREATE PROCEDURE sp_upd_tb_ROTI_rotina
@ROTI_nm_rotina varchar(30) = null , 
@ROTI_ds_rotina varchar(300) = null , 
@ROTI_dt_ultima_execucao datetime = null , 
@ROTI_dt_ultima_tentativa_execucao datetime = null , 
@ROTI_fl_status_execucao char(1) = null , 
@ROTI_ds_mensagem varchar(1000) = null , 
@ROTI_vl_tempo_medio decimal(13, 2) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_ROTI_rotina 
SET 
ROTI_ds_rotina = case when @ROTI_ds_rotina is not null then @ROTI_ds_rotina else ROTI_ds_rotina end , 
ROTI_dt_ultima_execucao = case when @ROTI_dt_ultima_execucao is not null then (case when @ROTI_dt_ultima_execucao <> '00:00:01' then @ROTI_dt_ultima_execucao else null end) else ROTI_dt_ultima_execucao end , 
ROTI_dt_ultima_tentativa_execucao = case when @ROTI_dt_ultima_tentativa_execucao is not null then (case when @ROTI_dt_ultima_tentativa_execucao <> '00:00:01' then @ROTI_dt_ultima_tentativa_execucao else null end) else ROTI_dt_ultima_tentativa_execucao end , 
ROTI_fl_status_execucao = case when @ROTI_fl_status_execucao is not null then @ROTI_fl_status_execucao else ROTI_fl_status_execucao end , 
ROTI_ds_mensagem = case when @ROTI_ds_mensagem is not null then @ROTI_ds_mensagem else ROTI_ds_mensagem end , 
ROTI_vl_tempo_medio = case when @ROTI_vl_tempo_medio is not null then @ROTI_vl_tempo_medio else ROTI_vl_tempo_medio end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ROTI_nm_rotina is null or (@ROTI_nm_rotina is not null and ROTI_nm_rotina = @ROTI_nm_rotina))  
 
GO
grant execute on sp_upd_tb_ROTI_rotina to rl_exec_proc
go



 -- Tabela: tb_ROTI_rotina - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_ROTI_rotina]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_ROTI_rotina EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_ROTI_rotina')
  DROP PROCEDURE sp_ins_tb_ROTI_rotina
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_ROTI_rotina
CREATE PROCEDURE sp_ins_tb_ROTI_rotina
@ROTI_nm_rotina varchar(30) = null , 
@ROTI_ds_rotina varchar(300) = null , 
@ROTI_dt_ultima_execucao datetime = null , 
@ROTI_dt_ultima_tentativa_execucao datetime = null , 
@ROTI_fl_status_execucao char(1) = null , 
@ROTI_ds_mensagem varchar(1000) = null , 
@ROTI_vl_tempo_medio decimal(13, 2) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_ROTI_rotina
  (ROTI_nm_rotina, 
ROTI_ds_rotina, 
ROTI_dt_ultima_execucao, 
ROTI_dt_ultima_tentativa_execucao, 
ROTI_fl_status_execucao, 
ROTI_ds_mensagem, 
ROTI_vl_tempo_medio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ROTI_nm_rotina, 
@ROTI_ds_rotina, 
@ROTI_dt_ultima_execucao, 
@ROTI_dt_ultima_tentativa_execucao, 
@ROTI_fl_status_execucao, 
@ROTI_ds_mensagem, 
@ROTI_vl_tempo_medio, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_ROTI_rotina to rl_exec_proc
go



 -- Tabela: tb_ROTI_rotina - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_ROTI_rotina]    ******/

-- SE A STORED PROCEDURE sp_del_tb_ROTI_rotina EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_ROTI_rotina')
  DROP PROCEDURE sp_del_tb_ROTI_rotina
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_del_tb_ROTI_rotina]
@ROTI_nm_rotina varchar(30) = null 
 
AS
 
DELETE FROM 
tb_ROTI_rotina
 where (@ROTI_nm_rotina is null or (@ROTI_nm_rotina is not null and ROTI_nm_rotina = @ROTI_nm_rotina))   

GO
grant execute on sp_del_tb_ROTI_rotina to rl_exec_proc
GO




 -- Tabela: tb_ROTI_rotina - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_ROTI_rotina_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ROTI_rotina_cons')
  DROP PROCEDURE sp_sel_tb_ROTI_rotina_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

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
ROTI_nm_rotina, 
ROTI_ds_rotina, 
ROTI_dt_ultima_execucao, 
ROTI_dt_ultima_tentativa_execucao, 
ROTI_fl_status_execucao, 
ROTI_ds_mensagem, 
ROTI_vl_tempo_medio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_ROTI_rotina ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_ROTI_rotina_cons to rl_exec_proc
GO








 -- Tabela: tb_UNFE_unidade_federativa - Procedure: Select
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa]    ******/

-- SE A STORED PROCEDURE sp_sel_tb_UNFE_unidade_federativa EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_UNFE_unidade_federativa')
  DROP PROCEDURE sp_sel_tb_UNFE_unidade_federativa
GO

 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa]
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_UNFE_unidade_federativa
 where (@UNFE_cd_unidade_federativa is null or (@UNFE_cd_unidade_federativa is not null and UNFE_cd_unidade_federativa = @UNFE_cd_unidade_federativa))  AND 
(@UNFE_nm_unidade_federativa is null or (@UNFE_nm_unidade_federativa is not null and UNFE_nm_unidade_federativa = @UNFE_nm_unidade_federativa))   


GO
grant execute on sp_sel_tb_UNFE_unidade_federativa to rl_exec_proc
GO




 -- Tabela: tb_UNFE_unidade_federativa - Procedure: SelectGrid
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_UNFE_unidade_federativa_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_UNFE_unidade_federativa_rel')
  DROP PROCEDURE sp_sel_tb_UNFE_unidade_federativa_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_UNFE_unidade_federativa table(
id int identity primary key, 
UNFE_cd_unidade_federativa char(2) not null, 
UNFE_nm_unidade_federativa varchar(100) not null, 
UNFE_fl_status char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_UNFE_unidade_federativa
(UNFE_cd_unidade_federativa, 
UNFE_nm_unidade_federativa, 
UNFE_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
UNFE_cd_unidade_federativa, 
UNFE_nm_unidade_federativa, 
UNFE_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao

FROM 
tb_UNFE_unidade_federativa

WHERE 

(@whereField is null OR 

 (@whereField = 'UNFE_cd_unidade_federativa' and rtrim(ltrim(UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_nm_unidade_federativa' and rtrim(ltrim(UNFE_nm_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_fl_status' and rtrim(ltrim(UNFE_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='ASC' then UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='DESC' then UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = 'UNFE_nm_unidade_federativa' and  @sortOrder='ASC' then UNFE_nm_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_nm_unidade_federativa' and  @sortOrder='DESC' then UNFE_nm_unidade_federativa END DESC 
 ,  CASE when @sortField = 'UNFE_fl_status' and  @sortOrder='ASC' then UNFE_fl_status END ASC, 
 CASE when @sortField = 'UNFE_fl_status' and  @sortOrder='DESC' then UNFE_fl_status END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_UNFE_unidade_federativa where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_UNFE_unidade_federativa_rel to rl_exec_proc
GO




 -- Tabela: tb_UNFE_unidade_federativa - Procedure: Update
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_UNFE_unidade_federativa]    ******/

-- SE A STORED PROCEDURE sp_upd_tb_UNFE_unidade_federativa EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_upd_tb_UNFE_unidade_federativa')
  DROP PROCEDURE sp_upd_tb_UNFE_unidade_federativa
GO
 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE sp_upd_tb_UNFE_unidade_federativa
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null , 
@UNFE_fl_status char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_UNFE_unidade_federativa 
SET 
UNFE_nm_unidade_federativa = case when @UNFE_nm_unidade_federativa is not null then @UNFE_nm_unidade_federativa else UNFE_nm_unidade_federativa end , 
UNFE_fl_status = case when @UNFE_fl_status is not null then @UNFE_fl_status else UNFE_fl_status end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> '00:00:01' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> '00:00:01' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@UNFE_cd_unidade_federativa is null or (@UNFE_cd_unidade_federativa is not null and UNFE_cd_unidade_federativa = @UNFE_cd_unidade_federativa))  
 
GO
grant execute on sp_upd_tb_UNFE_unidade_federativa to rl_exec_proc
go



 -- Tabela: tb_UNFE_unidade_federativa - Procedure: Insert
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_UNFE_unidade_federativa]    ******/

-- SE A STORED PROCEDURE sp_ins_tb_UNFE_unidade_federativa EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_ins_tb_UNFE_unidade_federativa')
  DROP PROCEDURE sp_ins_tb_UNFE_unidade_federativa
GO
 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE sp_ins_tb_UNFE_unidade_federativa
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null , 
@UNFE_fl_status char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_UNFE_unidade_federativa
  (UNFE_cd_unidade_federativa, 
UNFE_nm_unidade_federativa, 
UNFE_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@UNFE_cd_unidade_federativa, 
@UNFE_nm_unidade_federativa, 
@UNFE_fl_status, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
GO
grant execute on sp_ins_tb_UNFE_unidade_federativa to rl_exec_proc
go



 -- Tabela: tb_UNFE_unidade_federativa - Procedure: Delete
/****** Object:  StoredProcedure [dbo].[sp_del_tb_UNFE_unidade_federativa]    ******/

-- SE A STORED PROCEDURE sp_del_tb_UNFE_unidade_federativa EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_del_tb_UNFE_unidade_federativa')
  DROP PROCEDURE sp_del_tb_UNFE_unidade_federativa
GO

 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_del_tb_UNFE_unidade_federativa]
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null 
 
AS
 
DELETE FROM 
tb_UNFE_unidade_federativa
 where (@UNFE_cd_unidade_federativa is null or (@UNFE_cd_unidade_federativa is not null and UNFE_cd_unidade_federativa = @UNFE_cd_unidade_federativa))  AND 
(@UNFE_nm_unidade_federativa is null or (@UNFE_nm_unidade_federativa is not null and UNFE_nm_unidade_federativa = @UNFE_nm_unidade_federativa))   

GO
grant execute on sp_del_tb_UNFE_unidade_federativa to rl_exec_proc
GO




 -- Tabela: tb_UNFE_unidade_federativa - Procedure: SelectConsulta
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_UNFE_unidade_federativa_cons EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_UNFE_unidade_federativa_cons')
  DROP PROCEDURE sp_sel_tb_UNFE_unidade_federativa_cons
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]
@startRowIndex int,
@maximumRows int,
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



SET @whereAux = '  '

-- Verificar se o whereClause veio preenchido
IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux + ' and ' + @WhereClause
 else
  SET @whereAux = ' WHERE ' + @WhereClause
 
end 

ELSE

begin

 IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
  SET @whereAux = ' WHERE ' + @WhereAux

end

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
UNFE_cd_unidade_federativa, 
UNFE_nm_unidade_federativa, 
UNFE_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao ' 
+ ' from 
tb_UNFE_unidade_federativa ' + @whereAux + ' ' + @OrderByAux

raiserror(@sql,-1,-1)

exec(@sql)

 SELECT * FROM 
#Temporary_Table where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0)



GO
grant execute on sp_sel_tb_UNFE_unidade_federativa_cons to rl_exec_proc
GO






