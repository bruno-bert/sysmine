use dbDNPM;





 -- Tabela: tb_PROC_processo - Procedure: SelectRel
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
,
@PROC_cd_processo varchar(50) = null , 
@PROC_ds_titular varchar(300) = null , 
@PROC_vl_ano int = null , 
@PROC_nm_processo varchar(50) = null , 
@FASE_cd_fase int = null , 
@PROC_ds_ultimo_evento varchar(3000) = null , 
@PROC_ds_substancia varchar(100) = null , 
@PROC_ds_area varchar(30) = null , 
@PROC_ds_uso varchar(200) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PROC_processo table (
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
AUDT_nm_usuario_alteracao varchar(20) not null, 
FASE_nm_fase varchar(100) not null, 
UNFE_nm_unidade_federativa varchar(100) not null
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
AUDT_nm_usuario_alteracao, 
FASE_nm_fase, 
UNFE_nm_unidade_federativa) 

SELECT 
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
C.UNFE_nm_unidade_federativa as UNFE_nm_unidade_federativa

FROM 

DBDNPM..tb_PROC_processo A, 
DBDNPM..tb_FASE_fase B, 
DBDNPM..tb_UNFE_unidade_federativa C

WHERE 


 -- Join: dbDNPM.tb_PROC_processo x dbDNPM.tb_FASE_fase
 -- Join: dbDNPM.tb_PROC_processo x dbDNPM.tb_UNFE_unidade_federativa


A.FASE_cd_fase = B.FASE_cd_fase and 

A.UNFE_cd_unidade_federativa = C.UNFE_cd_unidade_federativa  AND 

(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@PROC_ds_titular is null or (@PROC_ds_titular is not null and A.PROC_ds_titular = @PROC_ds_titular)) 
 AND (@PROC_vl_ano is null or (@PROC_vl_ano is not null and A.PROC_vl_ano = @PROC_vl_ano)) 
 AND (@PROC_nm_processo is null or (@PROC_nm_processo is not null and A.PROC_nm_processo = @PROC_nm_processo)) 
 AND (@FASE_cd_fase is null or (@FASE_cd_fase is not null and A.FASE_cd_fase = @FASE_cd_fase)) 
 AND (@PROC_ds_ultimo_evento is null or (@PROC_ds_ultimo_evento is not null and A.PROC_ds_ultimo_evento = @PROC_ds_ultimo_evento)) 
 AND (@PROC_ds_substancia is null or (@PROC_ds_substancia is not null and A.PROC_ds_substancia = @PROC_ds_substancia)) 
 AND (@PROC_ds_area is null or (@PROC_ds_area is not null and A.PROC_ds_area = @PROC_ds_area)) 
 AND (@PROC_ds_uso is null or (@PROC_ds_uso is not null and A.PROC_ds_uso = @PROC_ds_uso)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'PROC_cd_processo' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_titular' and rtrim(ltrim(A.PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_vl_ano' and rtrim(ltrim(A.PROC_vl_ano)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_nm_processo' and rtrim(ltrim(A.PROC_nm_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_id_processo' and rtrim(ltrim(A.PROC_id_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'FASE_cd_fase' and rtrim(ltrim(A.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_ultimo_evento' and rtrim(ltrim(A.PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_substancia' and rtrim(ltrim(A.PROC_ds_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_area' and rtrim(ltrim(A.PROC_ds_area)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_uso' and rtrim(ltrim(A.PROC_ds_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_link' and rtrim(ltrim(A.PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_cd_unidade_federativa' and rtrim(ltrim(A.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_fl_tipo_inclusao' and rtrim(ltrim(A.PROC_fl_tipo_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'FASE_nm_fase' and rtrim(ltrim(B.FASE_nm_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_nm_unidade_federativa' and rtrim(ltrim(C.UNFE_nm_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'PROC_ds_titular' and  @sortOrder='ASC' then A.PROC_ds_titular END ASC, 
 CASE when @sortField = 'PROC_ds_titular' and  @sortOrder='DESC' then A.PROC_ds_titular END DESC 
 ,  CASE when @sortField = 'PROC_vl_ano' and  @sortOrder='ASC' then A.PROC_vl_ano END ASC, 
 CASE when @sortField = 'PROC_vl_ano' and  @sortOrder='DESC' then A.PROC_vl_ano END DESC 
 ,  CASE when @sortField = 'PROC_nm_processo' and  @sortOrder='ASC' then A.PROC_nm_processo END ASC, 
 CASE when @sortField = 'PROC_nm_processo' and  @sortOrder='DESC' then A.PROC_nm_processo END DESC 
 ,  CASE when @sortField = 'PROC_id_processo' and  @sortOrder='ASC' then A.PROC_id_processo END ASC, 
 CASE when @sortField = 'PROC_id_processo' and  @sortOrder='DESC' then A.PROC_id_processo END DESC 
 ,  CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='ASC' then A.FASE_cd_fase END ASC, 
 CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='DESC' then A.FASE_cd_fase END DESC 
 ,  CASE when @sortField = 'PROC_ds_ultimo_evento' and  @sortOrder='ASC' then A.PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = 'PROC_ds_ultimo_evento' and  @sortOrder='DESC' then A.PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = 'PROC_ds_substancia' and  @sortOrder='ASC' then A.PROC_ds_substancia END ASC, 
 CASE when @sortField = 'PROC_ds_substancia' and  @sortOrder='DESC' then A.PROC_ds_substancia END DESC 
 ,  CASE when @sortField = 'PROC_ds_area' and  @sortOrder='ASC' then A.PROC_ds_area END ASC, 
 CASE when @sortField = 'PROC_ds_area' and  @sortOrder='DESC' then A.PROC_ds_area END DESC 
 ,  CASE when @sortField = 'PROC_ds_uso' and  @sortOrder='ASC' then A.PROC_ds_uso END ASC, 
 CASE when @sortField = 'PROC_ds_uso' and  @sortOrder='DESC' then A.PROC_ds_uso END DESC 
 ,  CASE when @sortField = 'PROC_ds_link' and  @sortOrder='ASC' then A.PROC_ds_link END ASC, 
 CASE when @sortField = 'PROC_ds_link' and  @sortOrder='DESC' then A.PROC_ds_link END DESC 
 ,  CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='ASC' then A.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='DESC' then A.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = 'PROC_fl_tipo_inclusao' and  @sortOrder='ASC' then A.PROC_fl_tipo_inclusao END ASC, 
 CASE when @sortField = 'PROC_fl_tipo_inclusao' and  @sortOrder='DESC' then A.PROC_fl_tipo_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 
 ,  CASE when @sortField = 'FASE_nm_fase' and  @sortOrder='ASC' then B.FASE_nm_fase END ASC, 
 CASE when @sortField = 'FASE_nm_fase' and  @sortOrder='DESC' then B.FASE_nm_fase END DESC 
 ,  CASE when @sortField = 'UNFE_nm_unidade_federativa' and  @sortOrder='ASC' then C.UNFE_nm_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_nm_unidade_federativa' and  @sortOrder='DESC' then C.UNFE_nm_unidade_federativa END DESC 

 
SELECT * FROM 
@tb_PROC_processo where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PROC_processo_rel to rl_exec_proc
GO

