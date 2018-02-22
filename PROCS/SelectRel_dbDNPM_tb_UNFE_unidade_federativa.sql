use dbDNPM;





 -- Tabela: tb_UNFE_unidade_federativa - Procedure: SelectRel
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
,
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null , 
@UNFE_fl_status char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_UNFE_unidade_federativa table (
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
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.UNFE_nm_unidade_federativa as UNFE_nm_unidade_federativa, 
A.UNFE_fl_status as UNFE_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_UNFE_unidade_federativa A

WHERE 




(@UNFE_cd_unidade_federativa is null or (@UNFE_cd_unidade_federativa is not null and A.UNFE_cd_unidade_federativa = @UNFE_cd_unidade_federativa)) 
 AND (@UNFE_nm_unidade_federativa is null or (@UNFE_nm_unidade_federativa is not null and A.UNFE_nm_unidade_federativa = @UNFE_nm_unidade_federativa)) 
 AND (@UNFE_fl_status is null or (@UNFE_fl_status is not null and A.UNFE_fl_status = @UNFE_fl_status)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'UNFE_cd_unidade_federativa' and rtrim(ltrim(A.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_nm_unidade_federativa' and rtrim(ltrim(A.UNFE_nm_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'UNFE_fl_status' and rtrim(ltrim(A.UNFE_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='ASC' then A.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_cd_unidade_federativa' and  @sortOrder='DESC' then A.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = 'UNFE_nm_unidade_federativa' and  @sortOrder='ASC' then A.UNFE_nm_unidade_federativa END ASC, 
 CASE when @sortField = 'UNFE_nm_unidade_federativa' and  @sortOrder='DESC' then A.UNFE_nm_unidade_federativa END DESC 
 ,  CASE when @sortField = 'UNFE_fl_status' and  @sortOrder='ASC' then A.UNFE_fl_status END ASC, 
 CASE when @sortField = 'UNFE_fl_status' and  @sortOrder='DESC' then A.UNFE_fl_status END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_UNFE_unidade_federativa where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_UNFE_unidade_federativa_rel to rl_exec_proc
GO

