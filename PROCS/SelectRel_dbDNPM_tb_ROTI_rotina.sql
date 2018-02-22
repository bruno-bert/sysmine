use dbDNPM;





 -- Tabela: tb_ROTI_rotina - Procedure: SelectRel
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_ROTI_rotina_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_ROTI_rotina_rel')
  DROP PROCEDURE sp_sel_tb_ROTI_rotina_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ROTI_nm_rotina varchar(30) = null , 
@ROTI_ds_rotina varchar(300) = null , 
@ROTI_dt_ultima_execucao datetime = null , 
@ROTI_dt_ultima_tentativa_execucao datetime = null , 
@ROTI_fl_status_execucao char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_ROTI_rotina table (
id int identity primary key, 
ROTI_nm_rotina varchar(30) not null, 
ROTI_ds_rotina varchar(300) null, 
ROTI_dt_ultima_execucao datetime null, 
ROTI_dt_ultima_tentativa_execucao datetime null, 
ROTI_fl_status_execucao char(1) not null, 
ROTI_ds_mensagem varchar(1000) null, 
ROTI_vl_tempo_medio decimal(13, 2) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_ROTI_rotina
(ROTI_nm_rotina, 
ROTI_ds_rotina, 
ROTI_dt_ultima_execucao, 
ROTI_dt_ultima_tentativa_execucao, 
ROTI_fl_status_execucao, 
ROTI_ds_mensagem, 
ROTI_vl_tempo_medio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.ROTI_nm_rotina as ROTI_nm_rotina, 
A.ROTI_ds_rotina as ROTI_ds_rotina, 
A.ROTI_dt_ultima_execucao as ROTI_dt_ultima_execucao, 
A.ROTI_dt_ultima_tentativa_execucao as ROTI_dt_ultima_tentativa_execucao, 
A.ROTI_fl_status_execucao as ROTI_fl_status_execucao, 
A.ROTI_ds_mensagem as ROTI_ds_mensagem, 
A.ROTI_vl_tempo_medio as ROTI_vl_tempo_medio, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_ROTI_rotina A

WHERE 




(@ROTI_nm_rotina is null or (@ROTI_nm_rotina is not null and A.ROTI_nm_rotina = @ROTI_nm_rotina)) 
 AND (@ROTI_ds_rotina is null or (@ROTI_ds_rotina is not null and A.ROTI_ds_rotina = @ROTI_ds_rotina)) 
 AND (@ROTI_dt_ultima_execucao is null or (@ROTI_dt_ultima_execucao is not null and A.ROTI_dt_ultima_execucao = @ROTI_dt_ultima_execucao)) 
 AND (@ROTI_dt_ultima_tentativa_execucao is null or (@ROTI_dt_ultima_tentativa_execucao is not null and A.ROTI_dt_ultima_tentativa_execucao = @ROTI_dt_ultima_tentativa_execucao)) 
 AND (@ROTI_fl_status_execucao is null or (@ROTI_fl_status_execucao is not null and A.ROTI_fl_status_execucao = @ROTI_fl_status_execucao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'ROTI_nm_rotina' and rtrim(ltrim(A.ROTI_nm_rotina)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_ds_rotina' and rtrim(ltrim(A.ROTI_ds_rotina)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_dt_ultima_execucao' and rtrim(ltrim(A.ROTI_dt_ultima_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_dt_ultima_tentativa_execucao' and rtrim(ltrim(A.ROTI_dt_ultima_tentativa_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_fl_status_execucao' and rtrim(ltrim(A.ROTI_fl_status_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_ds_mensagem' and rtrim(ltrim(A.ROTI_ds_mensagem)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ROTI_vl_tempo_medio' and rtrim(ltrim(A.ROTI_vl_tempo_medio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_alteracao' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_alteracao' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'ROTI_nm_rotina' and  @sortOrder='ASC' then A.ROTI_nm_rotina END ASC, 
 CASE when @sortField = 'ROTI_nm_rotina' and  @sortOrder='DESC' then A.ROTI_nm_rotina END DESC 
 ,  CASE when @sortField = 'ROTI_ds_rotina' and  @sortOrder='ASC' then A.ROTI_ds_rotina END ASC, 
 CASE when @sortField = 'ROTI_ds_rotina' and  @sortOrder='DESC' then A.ROTI_ds_rotina END DESC 
 ,  CASE when @sortField = 'ROTI_dt_ultima_execucao' and  @sortOrder='ASC' then A.ROTI_dt_ultima_execucao END ASC, 
 CASE when @sortField = 'ROTI_dt_ultima_execucao' and  @sortOrder='DESC' then A.ROTI_dt_ultima_execucao END DESC 
 ,  CASE when @sortField = 'ROTI_dt_ultima_tentativa_execucao' and  @sortOrder='ASC' then A.ROTI_dt_ultima_tentativa_execucao END ASC, 
 CASE when @sortField = 'ROTI_dt_ultima_tentativa_execucao' and  @sortOrder='DESC' then A.ROTI_dt_ultima_tentativa_execucao END DESC 
 ,  CASE when @sortField = 'ROTI_fl_status_execucao' and  @sortOrder='ASC' then A.ROTI_fl_status_execucao END ASC, 
 CASE when @sortField = 'ROTI_fl_status_execucao' and  @sortOrder='DESC' then A.ROTI_fl_status_execucao END DESC 
 ,  CASE when @sortField = 'ROTI_ds_mensagem' and  @sortOrder='ASC' then A.ROTI_ds_mensagem END ASC, 
 CASE when @sortField = 'ROTI_ds_mensagem' and  @sortOrder='DESC' then A.ROTI_ds_mensagem END DESC 
 ,  CASE when @sortField = 'ROTI_vl_tempo_medio' and  @sortOrder='ASC' then A.ROTI_vl_tempo_medio END ASC, 
 CASE when @sortField = 'ROTI_vl_tempo_medio' and  @sortOrder='DESC' then A.ROTI_vl_tempo_medio END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='ASC' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = 'AUDT_dt_alteracao' and  @sortOrder='DESC' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_alteracao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_ROTI_rotina where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_ROTI_rotina_rel to rl_exec_proc
GO

