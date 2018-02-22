use dbDNPM;





 -- Tabela: tb_OPER_operador - Procedure: SelectRel
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
,
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_OPER_operador table (
id int identity primary key, 
OPER_cd_operador varchar(20) not null, 
OPER_nm_operador varchar(1000) not null, 
OPER_ds_email varchar(200) not null, 
OPER_fl_alerta char(1) not null, 
OPER_fl_alerta_nativo char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
OPER_ds_alerta varchar(3) NULL
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
AUDT_nm_usuario_alteracao, 

OPER_ds_alerta) 

SELECT 
A.OPER_cd_operador as OPER_cd_operador, 
A.OPER_nm_operador as OPER_nm_operador, 
A.OPER_ds_email as OPER_ds_email, 
A.OPER_fl_alerta as OPER_fl_alerta, 
A.OPER_fl_alerta_nativo as OPER_fl_alerta_nativo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 

(select case when OPER_fl_alerta = 'S' then 'Sim' else 'Não' end) as OPER_ds_alerta

FROM 

DBDNPM..tb_OPER_operador A

WHERE 




(@OPER_cd_operador is null or (@OPER_cd_operador is not null and A.OPER_cd_operador = @OPER_cd_operador)) 
 AND (@OPER_nm_operador is null or (@OPER_nm_operador is not null and A.OPER_nm_operador = @OPER_nm_operador)) 
 AND (@OPER_ds_email is null or (@OPER_ds_email is not null and A.OPER_ds_email = @OPER_ds_email)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'OPER_cd_operador' and rtrim(ltrim(A.OPER_cd_operador)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_nm_operador' and rtrim(ltrim(A.OPER_nm_operador)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_ds_email' and rtrim(ltrim(A.OPER_ds_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_fl_alerta' and rtrim(ltrim(A.OPER_fl_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'OPER_fl_alerta_nativo' and rtrim(ltrim(A.OPER_fl_alerta_nativo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'OPER_cd_operador' and  @sortOrder='ASC' then A.OPER_cd_operador END ASC, 
 CASE when @sortField = 'OPER_cd_operador' and  @sortOrder='DESC' then A.OPER_cd_operador END DESC 
 ,  CASE when @sortField = 'OPER_nm_operador' and  @sortOrder='ASC' then A.OPER_nm_operador END ASC, 
 CASE when @sortField = 'OPER_nm_operador' and  @sortOrder='DESC' then A.OPER_nm_operador END DESC 
 ,  CASE when @sortField = 'OPER_ds_email' and  @sortOrder='ASC' then A.OPER_ds_email END ASC, 
 CASE when @sortField = 'OPER_ds_email' and  @sortOrder='DESC' then A.OPER_ds_email END DESC 
 ,  CASE when @sortField = 'OPER_fl_alerta' and  @sortOrder='ASC' then A.OPER_fl_alerta END ASC, 
 CASE when @sortField = 'OPER_fl_alerta' and  @sortOrder='DESC' then A.OPER_fl_alerta END DESC 
 ,  CASE when @sortField = 'OPER_fl_alerta_nativo' and  @sortOrder='ASC' then A.OPER_fl_alerta_nativo END ASC, 
 CASE when @sortField = 'OPER_fl_alerta_nativo' and  @sortOrder='DESC' then A.OPER_fl_alerta_nativo END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_OPER_operador where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_OPER_operador_rel to rl_exec_proc
GO

