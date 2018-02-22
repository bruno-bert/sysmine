use dbDNPM;





 -- Tabela: tb_PRAL_processo_alerta - Procedure: SelectRel
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
,
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PRAL_fl_manutencao char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PRAL_processo_alerta table (
id int identity primary key, 
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



insert into 
@tb_PRAL_processo_alerta
(PROC_cd_processo, 
ALER_nm_alerta, 
PRAL_fl_manutencao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 
ALER_ds_alerta, 
ALER_fl_muda_fase, 
ALER_fl_muda_evento, 
ALER_cd_fase_anterior, 
ALER_cd_fase_nova, 
ALER_fl_qualquer_processo, 
ALER_fl_status, 
ALER_fl_sistema, 
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
PROC_fl_tipo_inclusao) 

SELECT 
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
C.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao

FROM 

DBDNPM..tb_PRAL_processo_alerta A, 
DBDNPM..tb_ALER_alerta B, 
DBDNPM..tb_PROC_processo C

WHERE 


 -- Join: dbDNPM.tb_PRAL_processo_alerta x dbDNPM.tb_ALER_alerta
 -- Join: dbDNPM.tb_PRAL_processo_alerta x dbDNPM.tb_PROC_processo


A.ALER_nm_alerta = B.ALER_nm_alerta and 

A.PROC_cd_processo = C.PROC_cd_processo  AND 

(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and A.ALER_nm_alerta = @ALER_nm_alerta)) 
 AND (@PRAL_fl_manutencao is null or (@PRAL_fl_manutencao is not null and A.PRAL_fl_manutencao = @PRAL_fl_manutencao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'PROC_cd_processo' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_nm_alerta' and rtrim(ltrim(A.ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PRAL_fl_manutencao' and rtrim(ltrim(A.PRAL_fl_manutencao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_ds_alerta' and rtrim(ltrim(B.ALER_ds_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_muda_fase' and rtrim(ltrim(B.ALER_fl_muda_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_muda_evento' and rtrim(ltrim(B.ALER_fl_muda_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_cd_fase_anterior' and rtrim(ltrim(B.ALER_cd_fase_anterior)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_cd_fase_nova' and rtrim(ltrim(B.ALER_cd_fase_nova)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_qualquer_processo' and rtrim(ltrim(B.ALER_fl_qualquer_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_status' and rtrim(ltrim(B.ALER_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_fl_sistema' and rtrim(ltrim(B.ALER_fl_sistema)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_titular' and rtrim(ltrim(C.PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_vl_ano' and rtrim(ltrim(C.PROC_vl_ano)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_nm_processo' and rtrim(ltrim(C.PROC_nm_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_id_processo' and rtrim(ltrim(C.PROC_id_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'FASE_cd_fase' and rtrim(ltrim(C.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_ultimo_evento' and rtrim(ltrim(C.PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_substancia' and rtrim(ltrim(C.PROC_ds_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_area' and rtrim(ltrim(C.PROC_ds_area)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_uso' and rtrim(ltrim(C.PROC_ds_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_link' and rtrim(ltrim(C.PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_cd_unidade_federativa' and rtrim(ltrim(C.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_fl_tipo_inclusao' and rtrim(ltrim(C.PROC_fl_tipo_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='ASC' then A.ALER_nm_alerta END ASC, 
 CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='DESC' then A.ALER_nm_alerta END DESC 
 ,  CASE when @sortField = 'PRAL_fl_manutencao' and  @sortOrder='ASC' then A.PRAL_fl_manutencao END ASC, 
 CASE when @sortField = 'PRAL_fl_manutencao' and  @sortOrder='DESC' then A.PRAL_fl_manutencao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 
 ,  CASE when @sortField = 'ALER_ds_alerta' and  @sortOrder='ASC' then B.ALER_ds_alerta END ASC, 
 CASE when @sortField = 'ALER_ds_alerta' and  @sortOrder='DESC' then B.ALER_ds_alerta END DESC 
 ,  CASE when @sortField = 'ALER_fl_muda_fase' and  @sortOrder='ASC' then B.ALER_fl_muda_fase END ASC, 
 CASE when @sortField = 'ALER_fl_muda_fase' and  @sortOrder='DESC' then B.ALER_fl_muda_fase END DESC 
 ,  CASE when @sortField = 'ALER_fl_muda_evento' and  @sortOrder='ASC' then B.ALER_fl_muda_evento END ASC, 
 CASE when @sortField = 'ALER_fl_muda_evento' and  @sortOrder='DESC' then B.ALER_fl_muda_evento END DESC 
 ,  CASE when @sortField = 'ALER_cd_fase_anterior' and  @sortOrder='ASC' then B.ALER_cd_fase_anterior END ASC, 
 CASE when @sortField = 'ALER_cd_fase_anterior' and  @sortOrder='DESC' then B.ALER_cd_fase_anterior END DESC 
 ,  CASE when @sortField = 'ALER_cd_fase_nova' and  @sortOrder='ASC' then B.ALER_cd_fase_nova END ASC, 
 CASE when @sortField = 'ALER_cd_fase_nova' and  @sortOrder='DESC' then B.ALER_cd_fase_nova END DESC 
 ,  CASE when @sortField = 'ALER_fl_qualquer_processo' and  @sortOrder='ASC' then B.ALER_fl_qualquer_processo END ASC, 
 CASE when @sortField = 'ALER_fl_qualquer_processo' and  @sortOrder='DESC' then B.ALER_fl_qualquer_processo END DESC 
 ,  CASE when @sortField = 'ALER_fl_status' and  @sortOrder='ASC' then B.ALER_fl_status END ASC, 
 CASE when @sortField = 'ALER_fl_status' and  @sortOrder='DESC' then B.ALER_fl_status END DESC 
 ,  CASE when @sortField = 'ALER_fl_sistema' and  @sortOrder='ASC' then B.ALER_fl_sistema END ASC, 
 CASE when @sortField = 'ALER_fl_sistema' and  @sortOrder='DESC' then B.ALER_fl_sistema END DESC 
 ,  CASE when @sortField = 'PROC_ds_titular' and  @sortOrder='ASC' then C.PROC_ds_titular END ASC, 
 CASE when @sortField = 'PROC_ds_titular' and  @sortOrder='DESC' then C.PROC_ds_titular END DESC 
 ,  CASE when @sortField = 'PROC_vl_ano' and  @sortOrder='ASC' then C.PROC_vl_ano END ASC, 
 CASE when @sortField = 'PROC_vl_ano' and  @sortOrder='DESC' then C.PROC_vl_ano END DESC 
 ,  CASE when @sortField = 'PROC_nm_processo' and  @sortOrder='ASC' then C.PROC_nm_processo END ASC, 
 CASE when @sortField = 'PROC_nm_processo' and  @sortOrder='DESC' then C.PROC_nm_processo END DESC 
 ,  CASE when @sortField = 'PROC_id_processo' and  @sortOrder='ASC' then C.PROC_id_processo END ASC, 
 CASE when @sortField = 'PROC_id_processo' and  @sortOrder='DESC' then C.PROC_id_processo END DESC 
 ,  CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='ASC' then C.FASE_cd_fase END ASC, 
 CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='DESC' then C.FASE_cd_fase END DESC 
 ,  CASE when @sortField = 'PROC_ds_ultimo_evento' and  @sortOrder='ASC' then C.PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = 'PROC_ds_ultimo_evento' and  @sortOrder='DESC' then C.PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = 'PROC_ds_substancia' and  @sortOrder='ASC' then C.PROC_ds_substancia END ASC, 
 CASE when @sortField = 'PROC_ds_substancia' and  @sortOrder='DESC' then C.PROC_ds_substancia END DESC 
 ,  CASE when @sortField = 'PROC_ds_area' and  @sortOrder='ASC' then C.PROC_ds_area END ASC, 
 CASE when @sortField = 'PROC_ds_area' and  @sortOrder='DESC' then C.PROC_ds_area END DESC 
 ,  CASE when @sortField = 'PROC_ds_uso' and  @sortOrder='ASC' then C.PROC_ds_uso END ASC, 
 CASE when @sortField = 'PROC_ds_uso' and  @sortOrder='DESC' then C.PROC_ds_uso END DESC 
 ,  CASE when @sortField = 'PROC_ds_link' and  @sortOrder='ASC' then C.PROC_ds_link END ASC, 
 CASE when @sortField = 'PROC_ds_link' and  @sortOrder='DESC' then C.PROC_ds_link END DESC 
 ,  CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='ASC' then C.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='DESC' then C.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = 'PROC_fl_tipo_inclusao' and  @sortOrder='ASC' then C.PROC_fl_tipo_inclusao END ASC, 
 CASE when @sortField = 'PROC_fl_tipo_inclusao' and  @sortOrder='DESC' then C.PROC_fl_tipo_inclusao END DESC 

 
SELECT * FROM 
@tb_PRAL_processo_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PRAL_processo_alerta_rel to rl_exec_proc
GO

