use dbDNPM;





 -- Tabela: tb_ALER_alerta - Procedure: SelectRel
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
,
@ALER_nm_alerta varchar(50) = null , 
@ALER_ds_alerta varchar(300) = null , 
@ALER_fl_muda_fase char(1) = null , 
@ALER_fl_muda_evento char(1) = null , 
@ALER_cd_fase_anterior int = null , 
@ALER_cd_fase_nova int = null , 
@ALER_fl_qualquer_processo char(1) = null , 
@ALER_fl_status char(1) = null , 
@ALER_fl_sistema char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_ALER_alerta table (
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
AUDT_nm_usuario_alteracao varchar(20) not null, 
ALER_ds_status varchar(3) NULL, 
ALER_ds_sistema varchar(3) NULL, 
ALER_ds_muda_fase varchar(3) NULL, 
ALER_ds_muda_evento varchar(3) NULL, 
ALER_ds_qualquer_processo varchar(3) NULL, 
ALER_nm_fase_anterior varchar(100) NULL, 
ALER_ds_fase_nova varchar(100) NULL
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
AUDT_nm_usuario_alteracao, 

ALER_ds_status, 

ALER_ds_sistema, 

ALER_ds_muda_fase, 

ALER_ds_muda_evento, 

ALER_ds_qualquer_processo, 

ALER_nm_fase_anterior, 

ALER_ds_fase_nova) 

SELECT 
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

(select FASE_nm_fase from tb_FASE_fase x where a.ALER_cd_fase_nova = x.FASE_cd_fase) as ALER_ds_fase_nova

FROM 

DBDNPM..tb_ALER_alerta A

WHERE 




(@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and A.ALER_nm_alerta = @ALER_nm_alerta)) 
 AND (@ALER_ds_alerta is null or (@ALER_ds_alerta is not null and A.ALER_ds_alerta = @ALER_ds_alerta)) 
 AND (@ALER_fl_muda_fase is null or (@ALER_fl_muda_fase is not null and A.ALER_fl_muda_fase = @ALER_fl_muda_fase)) 
 AND (@ALER_fl_muda_evento is null or (@ALER_fl_muda_evento is not null and A.ALER_fl_muda_evento = @ALER_fl_muda_evento)) 
 AND (@ALER_cd_fase_anterior is null or (@ALER_cd_fase_anterior is not null and A.ALER_cd_fase_anterior = @ALER_cd_fase_anterior)) 
 AND (@ALER_cd_fase_nova is null or (@ALER_cd_fase_nova is not null and A.ALER_cd_fase_nova = @ALER_cd_fase_nova)) 
 AND (@ALER_fl_qualquer_processo is null or (@ALER_fl_qualquer_processo is not null and A.ALER_fl_qualquer_processo = @ALER_fl_qualquer_processo)) 
 AND (@ALER_fl_status is null or (@ALER_fl_status is not null and A.ALER_fl_status = @ALER_fl_status)) 
 AND (@ALER_fl_sistema is null or (@ALER_fl_sistema is not null and A.ALER_fl_sistema = @ALER_fl_sistema)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'ALER_nm_alerta' and rtrim(ltrim(A.ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_ds_alerta' and rtrim(ltrim(A.ALER_ds_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_muda_fase' and rtrim(ltrim(A.ALER_fl_muda_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_muda_evento' and rtrim(ltrim(A.ALER_fl_muda_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_cd_fase_anterior' and rtrim(ltrim(A.ALER_cd_fase_anterior)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_cd_fase_nova' and rtrim(ltrim(A.ALER_cd_fase_nova)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_qualquer_processo' and rtrim(ltrim(A.ALER_fl_qualquer_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_status' and rtrim(ltrim(A.ALER_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_sistema' and rtrim(ltrim(A.ALER_fl_sistema)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='ASC' then A.ALER_nm_alerta END ASC, 
 CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='DESC' then A.ALER_nm_alerta END DESC 
 ,  CASE when @sortField = 'ALER_ds_alerta' and  @sortOrder='ASC' then A.ALER_ds_alerta END ASC, 
 CASE when @sortField = 'ALER_ds_alerta' and  @sortOrder='DESC' then A.ALER_ds_alerta END DESC 
 ,  CASE when @sortField = 'ALER_fl_muda_fase' and  @sortOrder='ASC' then A.ALER_fl_muda_fase END ASC, 
 CASE when @sortField = 'ALER_fl_muda_fase' and  @sortOrder='DESC' then A.ALER_fl_muda_fase END DESC 
 ,  CASE when @sortField = 'ALER_fl_muda_evento' and  @sortOrder='ASC' then A.ALER_fl_muda_evento END ASC, 
 CASE when @sortField = 'ALER_fl_muda_evento' and  @sortOrder='DESC' then A.ALER_fl_muda_evento END DESC 
 ,  CASE when @sortField = 'ALER_cd_fase_anterior' and  @sortOrder='ASC' then A.ALER_cd_fase_anterior END ASC, 
 CASE when @sortField = 'ALER_cd_fase_anterior' and  @sortOrder='DESC' then A.ALER_cd_fase_anterior END DESC 
 ,  CASE when @sortField = 'ALER_cd_fase_nova' and  @sortOrder='ASC' then A.ALER_cd_fase_nova END ASC, 
 CASE when @sortField = 'ALER_cd_fase_nova' and  @sortOrder='DESC' then A.ALER_cd_fase_nova END DESC 
 ,  CASE when @sortField = 'ALER_fl_qualquer_processo' and  @sortOrder='ASC' then A.ALER_fl_qualquer_processo END ASC, 
 CASE when @sortField = 'ALER_fl_qualquer_processo' and  @sortOrder='DESC' then A.ALER_fl_qualquer_processo END DESC 
 ,  CASE when @sortField = 'ALER_fl_status' and  @sortOrder='ASC' then A.ALER_fl_status END ASC, 
 CASE when @sortField = 'ALER_fl_status' and  @sortOrder='DESC' then A.ALER_fl_status END DESC 
 ,  CASE when @sortField = 'ALER_fl_sistema' and  @sortOrder='ASC' then A.ALER_fl_sistema END ASC, 
 CASE when @sortField = 'ALER_fl_sistema' and  @sortOrder='DESC' then A.ALER_fl_sistema END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_ALER_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_ALER_alerta_rel to rl_exec_proc
GO

