use dbDNPM;





 -- Tabela: tb_LESI_log_erro_sistema - Procedure: SelectRel
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
,
@LESI_cd_ocorrencia bigint = null , 
@LESI_nm_source varchar(100) = null , 
@LESI_dt_ocorrencia datetime = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_LESI_log_erro_sistema table (
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
A.LESI_cd_ocorrencia as LESI_cd_ocorrencia, 
A.LESI_nm_source as LESI_nm_source, 
A.LESI_ds_exception as LESI_ds_exception, 
A.LESI_ds_inexception as LESI_ds_inexception, 
A.LESI_dt_ocorrencia as LESI_dt_ocorrencia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao

FROM 

DBDNPM..tb_LESI_log_erro_sistema A

WHERE 




(@LESI_cd_ocorrencia is null or (@LESI_cd_ocorrencia is not null and A.LESI_cd_ocorrencia = @LESI_cd_ocorrencia)) 
 AND (@LESI_nm_source is null or (@LESI_nm_source is not null and A.LESI_nm_source = @LESI_nm_source)) 
 AND (@LESI_dt_ocorrencia is null or (@LESI_dt_ocorrencia is not null and A.LESI_dt_ocorrencia = @LESI_dt_ocorrencia)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'LESI_cd_ocorrencia' and rtrim(ltrim(A.LESI_cd_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'LESI_nm_source' and rtrim(ltrim(A.LESI_nm_source)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'LESI_ds_exception' and rtrim(ltrim(A.LESI_ds_exception)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'LESI_ds_inexception' and rtrim(ltrim(A.LESI_ds_inexception)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'LESI_dt_ocorrencia' and rtrim(ltrim(A.LESI_dt_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'LESI_cd_ocorrencia' and  @sortOrder='ASC' then A.LESI_cd_ocorrencia END ASC, 
 CASE when @sortField = 'LESI_cd_ocorrencia' and  @sortOrder='DESC' then A.LESI_cd_ocorrencia END DESC 
 ,  CASE when @sortField = 'LESI_nm_source' and  @sortOrder='ASC' then A.LESI_nm_source END ASC, 
 CASE when @sortField = 'LESI_nm_source' and  @sortOrder='DESC' then A.LESI_nm_source END DESC 
 ,  CASE when @sortField = 'LESI_ds_exception' and  @sortOrder='ASC' then A.LESI_ds_exception END ASC, 
 CASE when @sortField = 'LESI_ds_exception' and  @sortOrder='DESC' then A.LESI_ds_exception END DESC 
 ,  CASE when @sortField = 'LESI_ds_inexception' and  @sortOrder='ASC' then A.LESI_ds_inexception END ASC, 
 CASE when @sortField = 'LESI_ds_inexception' and  @sortOrder='DESC' then A.LESI_ds_inexception END DESC 
 ,  CASE when @sortField = 'LESI_dt_ocorrencia' and  @sortOrder='ASC' then A.LESI_dt_ocorrencia END ASC, 
 CASE when @sortField = 'LESI_dt_ocorrencia' and  @sortOrder='DESC' then A.LESI_dt_ocorrencia END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 

 
SELECT * FROM 
@tb_LESI_log_erro_sistema where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_LESI_log_erro_sistema_rel to rl_exec_proc
GO

