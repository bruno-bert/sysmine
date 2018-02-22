use dbDNPM;





 -- Tabela: tb_PGER_parametro_geral - Procedure: SelectRel
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
,
@PGER_cd_parametro varchar(10) = null , 
@PGER_fl_tipo char(1) = null , 
@PGER_fl_sistema char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PGER_parametro_geral table (
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
A.PGER_cd_parametro as PGER_cd_parametro, 
A.PGER_ds_parametro as PGER_ds_parametro, 
A.PGER_vl_parametro as PGER_vl_parametro, 
A.PGER_fl_tipo as PGER_fl_tipo, 
A.PGER_fl_sistema as PGER_fl_sistema, 
A.PGER_vl_range_min as PGER_vl_range_min, 
A.PGER_vl_range_max as PGER_vl_range_max, 
A.PGER_vl_padrao as PGER_vl_padrao, 
A.PGER_vl_tamanho_min as PGER_vl_tamanho_min, 
A.PGER_vl_tamanho_max as PGER_vl_tamanho_max, 
A.PGER_vl_valores_permitidos as PGER_vl_valores_permitidos, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PGER_parametro_geral A

WHERE 




(@PGER_cd_parametro is null or (@PGER_cd_parametro is not null and A.PGER_cd_parametro = @PGER_cd_parametro)) 
 AND (@PGER_fl_tipo is null or (@PGER_fl_tipo is not null and A.PGER_fl_tipo = @PGER_fl_tipo)) 
 AND (@PGER_fl_sistema is null or (@PGER_fl_sistema is not null and A.PGER_fl_sistema = @PGER_fl_sistema)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'PGER_cd_parametro' and rtrim(ltrim(A.PGER_cd_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_ds_parametro' and rtrim(ltrim(A.PGER_ds_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_parametro' and rtrim(ltrim(A.PGER_vl_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_fl_tipo' and rtrim(ltrim(A.PGER_fl_tipo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_fl_sistema' and rtrim(ltrim(A.PGER_fl_sistema)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_range_min' and rtrim(ltrim(A.PGER_vl_range_min)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_range_max' and rtrim(ltrim(A.PGER_vl_range_max)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_padrao' and rtrim(ltrim(A.PGER_vl_padrao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_tamanho_min' and rtrim(ltrim(A.PGER_vl_tamanho_min)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_tamanho_max' and rtrim(ltrim(A.PGER_vl_tamanho_max)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PGER_vl_valores_permitidos' and rtrim(ltrim(A.PGER_vl_valores_permitidos)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'PGER_cd_parametro' and  @sortOrder='ASC' then A.PGER_cd_parametro END ASC, 
 CASE when @sortField = 'PGER_cd_parametro' and  @sortOrder='DESC' then A.PGER_cd_parametro END DESC 
 ,  CASE when @sortField = 'PGER_ds_parametro' and  @sortOrder='ASC' then A.PGER_ds_parametro END ASC, 
 CASE when @sortField = 'PGER_ds_parametro' and  @sortOrder='DESC' then A.PGER_ds_parametro END DESC 
 ,  CASE when @sortField = 'PGER_vl_parametro' and  @sortOrder='ASC' then A.PGER_vl_parametro END ASC, 
 CASE when @sortField = 'PGER_vl_parametro' and  @sortOrder='DESC' then A.PGER_vl_parametro END DESC 
 ,  CASE when @sortField = 'PGER_fl_tipo' and  @sortOrder='ASC' then A.PGER_fl_tipo END ASC, 
 CASE when @sortField = 'PGER_fl_tipo' and  @sortOrder='DESC' then A.PGER_fl_tipo END DESC 
 ,  CASE when @sortField = 'PGER_fl_sistema' and  @sortOrder='ASC' then A.PGER_fl_sistema END ASC, 
 CASE when @sortField = 'PGER_fl_sistema' and  @sortOrder='DESC' then A.PGER_fl_sistema END DESC 
 ,  CASE when @sortField = 'PGER_vl_range_min' and  @sortOrder='ASC' then A.PGER_vl_range_min END ASC, 
 CASE when @sortField = 'PGER_vl_range_min' and  @sortOrder='DESC' then A.PGER_vl_range_min END DESC 
 ,  CASE when @sortField = 'PGER_vl_range_max' and  @sortOrder='ASC' then A.PGER_vl_range_max END ASC, 
 CASE when @sortField = 'PGER_vl_range_max' and  @sortOrder='DESC' then A.PGER_vl_range_max END DESC 
 ,  CASE when @sortField = 'PGER_vl_padrao' and  @sortOrder='ASC' then A.PGER_vl_padrao END ASC, 
 CASE when @sortField = 'PGER_vl_padrao' and  @sortOrder='DESC' then A.PGER_vl_padrao END DESC 
 ,  CASE when @sortField = 'PGER_vl_tamanho_min' and  @sortOrder='ASC' then A.PGER_vl_tamanho_min END ASC, 
 CASE when @sortField = 'PGER_vl_tamanho_min' and  @sortOrder='DESC' then A.PGER_vl_tamanho_min END DESC 
 ,  CASE when @sortField = 'PGER_vl_tamanho_max' and  @sortOrder='ASC' then A.PGER_vl_tamanho_max END ASC, 
 CASE when @sortField = 'PGER_vl_tamanho_max' and  @sortOrder='DESC' then A.PGER_vl_tamanho_max END DESC 
 ,  CASE when @sortField = 'PGER_vl_valores_permitidos' and  @sortOrder='ASC' then A.PGER_vl_valores_permitidos END ASC, 
 CASE when @sortField = 'PGER_vl_valores_permitidos' and  @sortOrder='DESC' then A.PGER_vl_valores_permitidos END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PGER_parametro_geral where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_PGER_parametro_geral_rel to rl_exec_proc
GO

