use dbDNPM;





 -- Tabela: tb_EMPR_empresa - Procedure: SelectRel
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
,
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null , 
@EMPR_fl_status char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_EMPR_empresa table (
id int identity primary key, 
EMPR_nm_empresa varchar(20) not null, 
EMPR_ds_empresa varchar(300) not null, 
EMPR_fl_status char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
EMPR_ds_status varchar(100) NULL
)



insert into 
@tb_EMPR_empresa
(EMPR_nm_empresa, 
EMPR_ds_empresa, 
EMPR_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 

EMPR_ds_status) 

SELECT 
A.EMPR_nm_empresa as EMPR_nm_empresa, 
A.EMPR_ds_empresa as EMPR_ds_empresa, 
A.EMPR_fl_status as EMPR_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 

(select case when EMPR_fl_status = 'A' then 'Ativo' else 'Inativo' end) as EMPR_ds_status

FROM 

DBDNPM..tb_EMPR_empresa A

WHERE 




(@EMPR_nm_empresa is null or (@EMPR_nm_empresa is not null and A.EMPR_nm_empresa = @EMPR_nm_empresa)) 
 AND (@EMPR_ds_empresa is null or (@EMPR_ds_empresa is not null and A.EMPR_ds_empresa = @EMPR_ds_empresa)) 
 AND (@EMPR_fl_status is null or (@EMPR_fl_status is not null and A.EMPR_fl_status = @EMPR_fl_status)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'EMPR_nm_empresa' and rtrim(ltrim(A.EMPR_nm_empresa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'EMPR_ds_empresa' and rtrim(ltrim(A.EMPR_ds_empresa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'EMPR_fl_status' and rtrim(ltrim(A.EMPR_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'EMPR_nm_empresa' and  @sortOrder='ASC' then A.EMPR_nm_empresa END ASC, 
 CASE when @sortField = 'EMPR_nm_empresa' and  @sortOrder='DESC' then A.EMPR_nm_empresa END DESC 
 ,  CASE when @sortField = 'EMPR_ds_empresa' and  @sortOrder='ASC' then A.EMPR_ds_empresa END ASC, 
 CASE when @sortField = 'EMPR_ds_empresa' and  @sortOrder='DESC' then A.EMPR_ds_empresa END DESC 
 ,  CASE when @sortField = 'EMPR_fl_status' and  @sortOrder='ASC' then A.EMPR_fl_status END ASC, 
 CASE when @sortField = 'EMPR_fl_status' and  @sortOrder='DESC' then A.EMPR_fl_status END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_EMPR_empresa where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_EMPR_empresa_rel to rl_exec_proc
GO

