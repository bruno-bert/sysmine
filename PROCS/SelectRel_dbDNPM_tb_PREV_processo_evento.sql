use dbDNPM;





 -- Tabela: tb_PREV_processo_evento - Procedure: SelectRel
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
,
@PROC_cd_processo varchar(50) = null , 
@PREV_cd_evento varchar(20) = null , 
@PREV_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PREV_processo_evento table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
PREV_cd_evento varchar(20) not null, 
PREV_ds_evento varchar(3000) null, 
PREV_dt_ocorrencia datetime not null, 
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



insert into 
@tb_PREV_processo_evento
(PROC_cd_processo, 
PREV_cd_evento, 
PREV_ds_evento, 
PREV_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 
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
A.PREV_cd_evento as PREV_cd_evento, 
A.PREV_ds_evento as PREV_ds_evento, 
A.PREV_dt_ocorrencia as PREV_dt_ocorrencia, 
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
B.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao

FROM 

DBDNPM..tb_PREV_processo_evento A, 
DBDNPM..tb_PROC_processo B

WHERE 


 -- Join: dbDNPM.tb_PREV_processo_evento x dbDNPM.tb_PROC_processo

A.PROC_cd_processo = B.PROC_cd_processo  AND 

(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@PREV_cd_evento is null or (@PREV_cd_evento is not null and A.PREV_cd_evento = @PREV_cd_evento)) 
 AND (@PREV_dt_ocorrencia is null or (@PREV_dt_ocorrencia is not null and A.PREV_dt_ocorrencia = @PREV_dt_ocorrencia)) 
 AND (@AUDT_dt_inclusao is null or (@AUDT_dt_inclusao is not null and A.AUDT_dt_inclusao = @AUDT_dt_inclusao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'PROC_cd_processo' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PREV_cd_evento' and rtrim(ltrim(A.PREV_cd_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PREV_ds_evento' and rtrim(ltrim(A.PREV_ds_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PREV_dt_ocorrencia' and rtrim(ltrim(A.PREV_dt_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_titular' and rtrim(ltrim(B.PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_vl_ano' and rtrim(ltrim(B.PROC_vl_ano)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_nm_processo' and rtrim(ltrim(B.PROC_nm_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_id_processo' and rtrim(ltrim(B.PROC_id_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'FASE_cd_fase' and rtrim(ltrim(B.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_ultimo_evento' and rtrim(ltrim(B.PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_substancia' and rtrim(ltrim(B.PROC_ds_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_area' and rtrim(ltrim(B.PROC_ds_area)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_uso' and rtrim(ltrim(B.PROC_ds_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_ds_link' and rtrim(ltrim(B.PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_cd_unidade_federativa' and rtrim(ltrim(B.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_fl_tipo_inclusao' and rtrim(ltrim(B.PROC_fl_tipo_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'PREV_cd_evento' and  @sortOrder='ASC' then A.PREV_cd_evento END ASC, 
 CASE when @sortField = 'PREV_cd_evento' and  @sortOrder='DESC' then A.PREV_cd_evento END DESC 
 ,  CASE when @sortField = 'PREV_ds_evento' and  @sortOrder='ASC' then A.PREV_ds_evento END ASC, 
 CASE when @sortField = 'PREV_ds_evento' and  @sortOrder='DESC' then A.PREV_ds_evento END DESC 
 ,  CASE when @sortField = 'PREV_dt_ocorrencia' and  @sortOrder='ASC' then A.PREV_dt_ocorrencia END ASC, 
 CASE when @sortField = 'PREV_dt_ocorrencia' and  @sortOrder='DESC' then A.PREV_dt_ocorrencia END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 
 ,  CASE when @sortField = 'PROC_ds_titular' and  @sortOrder='ASC' then B.PROC_ds_titular END ASC, 
 CASE when @sortField = 'PROC_ds_titular' and  @sortOrder='DESC' then B.PROC_ds_titular END DESC 
 ,  CASE when @sortField = 'PROC_vl_ano' and  @sortOrder='ASC' then B.PROC_vl_ano END ASC, 
 CASE when @sortField = 'PROC_vl_ano' and  @sortOrder='DESC' then B.PROC_vl_ano END DESC 
 ,  CASE when @sortField = 'PROC_nm_processo' and  @sortOrder='ASC' then B.PROC_nm_processo END ASC, 
 CASE when @sortField = 'PROC_nm_processo' and  @sortOrder='DESC' then B.PROC_nm_processo END DESC 
 ,  CASE when @sortField = 'PROC_id_processo' and  @sortOrder='ASC' then B.PROC_id_processo END ASC, 
 CASE when @sortField = 'PROC_id_processo' and  @sortOrder='DESC' then B.PROC_id_processo END DESC 
 ,  CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='ASC' then B.FASE_cd_fase END ASC, 
 CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='DESC' then B.FASE_cd_fase END DESC 
 ,  CASE when @sortField = 'PROC_ds_ultimo_evento' and  @sortOrder='ASC' then B.PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = 'PROC_ds_ultimo_evento' and  @sortOrder='DESC' then B.PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = 'PROC_ds_substancia' and  @sortOrder='ASC' then B.PROC_ds_substancia END ASC, 
 CASE when @sortField = 'PROC_ds_substancia' and  @sortOrder='DESC' then B.PROC_ds_substancia END DESC 
 ,  CASE when @sortField = 'PROC_ds_area' and  @sortOrder='ASC' then B.PROC_ds_area END ASC, 
 CASE when @sortField = 'PROC_ds_area' and  @sortOrder='DESC' then B.PROC_ds_area END DESC 
 ,  CASE when @sortField = 'PROC_ds_uso' and  @sortOrder='ASC' then B.PROC_ds_uso END ASC, 
 CASE when @sortField = 'PROC_ds_uso' and  @sortOrder='DESC' then B.PROC_ds_uso END DESC 
 ,  CASE when @sortField = 'PROC_ds_link' and  @sortOrder='ASC' then B.PROC_ds_link END ASC, 
 CASE when @sortField = 'PROC_ds_link' and  @sortOrder='DESC' then B.PROC_ds_link END DESC 
 ,  CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='ASC' then B.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='DESC' then B.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = 'PROC_fl_tipo_inclusao' and  @sortOrder='ASC' then B.PROC_fl_tipo_inclusao END ASC, 
 CASE when @sortField = 'PROC_fl_tipo_inclusao' and  @sortOrder='DESC' then B.PROC_fl_tipo_inclusao END DESC 

 
SELECT * FROM 
@tb_PREV_processo_evento where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PREV_processo_evento_rel to rl_exec_proc
GO

