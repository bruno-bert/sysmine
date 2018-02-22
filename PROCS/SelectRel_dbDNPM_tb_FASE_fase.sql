use dbDNPM;





 -- Tabela: tb_FASE_fase - Procedure: SelectRel
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
,
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_FASE_fase table (
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
A.FASE_cd_fase as FASE_cd_fase, 
A.FASE_nm_fase as FASE_nm_fase, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_FASE_fase A

WHERE 




(@FASE_cd_fase is null or (@FASE_cd_fase is not null and A.FASE_cd_fase = @FASE_cd_fase)) 
 AND (@FASE_nm_fase is null or (@FASE_nm_fase is not null and A.FASE_nm_fase = @FASE_nm_fase)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'FASE_cd_fase' and rtrim(ltrim(A.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'FASE_nm_fase' and rtrim(ltrim(A.FASE_nm_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='ASC' then A.FASE_cd_fase END ASC, 
 CASE when @sortField = 'FASE_cd_fase' and  @sortOrder='DESC' then A.FASE_cd_fase END DESC 
 ,  CASE when @sortField = 'FASE_nm_fase' and  @sortOrder='ASC' then A.FASE_nm_fase END ASC, 
 CASE when @sortField = 'FASE_nm_fase' and  @sortOrder='DESC' then A.FASE_nm_fase END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_FASE_fase where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_FASE_fase_rel to rl_exec_proc
GO

