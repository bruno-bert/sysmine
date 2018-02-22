use dbDNPM;





 -- Tabela: tb_HSAL_historico_alerta - Procedure: SelectRel
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta_rel]     ******/

-- SE A STORED PROCEDURE sp_sel_tb_HSAL_historico_alerta_rel EXISTIR, DELETA-LA
IF EXISTS(SELECT id FROM sysobjects WHERE type = 'P' and name = 'sp_sel_tb_HSAL_historico_alerta_rel')
  DROP PROCEDURE sp_sel_tb_HSAL_historico_alerta_rel
GO


 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= 'ASC',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@HSAL_id_historico int = null , 
@HSAL_ds_email varchar(200) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PROC_cd_processo varchar(50) = null , 
@HSAL_dt_envio datetime = null , 
@HSAL_dt_tentativa_ultimo_envio datetime = null , 
@HSAL_fl_status char(3) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_HSAL_historico_alerta table (
id int identity primary key, 
HSAL_id_historico int not null, 
HSAL_ds_email varchar(200) not null, 
ALER_nm_alerta varchar(50) not null, 
PROC_cd_processo varchar(50) not null, 
HSAL_ds_assunto_email varchar(200) not null, 
HSAL_ds_texto_email varchar(8000) not null, 
HSAL_dt_envio datetime null, 
HSAL_dt_tentativa_ultimo_envio datetime null, 
HSAL_ds_mensagem varchar(8000) null, 
HSAL_fl_status char(3) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null
)



insert into 
@tb_HSAL_historico_alerta
(HSAL_id_historico, 
HSAL_ds_email, 
ALER_nm_alerta, 
PROC_cd_processo, 
HSAL_ds_assunto_email, 
HSAL_ds_texto_email, 
HSAL_dt_envio, 
HSAL_dt_tentativa_ultimo_envio, 
HSAL_ds_mensagem, 
HSAL_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao) 

SELECT 
A.HSAL_id_historico as HSAL_id_historico, 
A.HSAL_ds_email as HSAL_ds_email, 
A.ALER_nm_alerta as ALER_nm_alerta, 
A.PROC_cd_processo as PROC_cd_processo, 
A.HSAL_ds_assunto_email as HSAL_ds_assunto_email, 
A.HSAL_ds_texto_email as HSAL_ds_texto_email, 
A.HSAL_dt_envio as HSAL_dt_envio, 
A.HSAL_dt_tentativa_ultimo_envio as HSAL_dt_tentativa_ultimo_envio, 
A.HSAL_ds_mensagem as HSAL_ds_mensagem, 
A.HSAL_fl_status as HSAL_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao

FROM 

DBDNPM..tb_HSAL_historico_alerta A

WHERE 




(@HSAL_id_historico is null or (@HSAL_id_historico is not null and A.HSAL_id_historico = @HSAL_id_historico)) 
 AND (@HSAL_ds_email is null or (@HSAL_ds_email is not null and A.HSAL_ds_email = @HSAL_ds_email)) 
 AND (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and A.ALER_nm_alerta = @ALER_nm_alerta)) 
 AND (@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@HSAL_dt_envio is null or (@HSAL_dt_envio is not null and A.HSAL_dt_envio = @HSAL_dt_envio)) 
 AND (@HSAL_dt_tentativa_ultimo_envio is null or (@HSAL_dt_tentativa_ultimo_envio is not null and A.HSAL_dt_tentativa_ultimo_envio = @HSAL_dt_tentativa_ultimo_envio)) 
 AND (@HSAL_fl_status is null or (@HSAL_fl_status is not null and A.HSAL_fl_status = @HSAL_fl_status)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = 'HSAL_id_historico' and rtrim(ltrim(A.HSAL_id_historico)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_ds_email' and rtrim(ltrim(A.HSAL_ds_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'ALER_nm_alerta' and rtrim(ltrim(A.ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'PROC_cd_processo' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_ds_assunto_email' and rtrim(ltrim(A.HSAL_ds_assunto_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_ds_texto_email' and rtrim(ltrim(A.HSAL_ds_texto_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_dt_envio' and rtrim(ltrim(A.HSAL_dt_envio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_dt_tentativa_ultimo_envio' and rtrim(ltrim(A.HSAL_dt_tentativa_ultimo_envio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_ds_mensagem' and rtrim(ltrim(A.HSAL_ds_mensagem)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'HSAL_fl_status' and rtrim(ltrim(A.HSAL_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_dt_inclusao' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = 'AUDT_nm_usuario_inclusao' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = 'HSAL_id_historico' and  @sortOrder='ASC' then A.HSAL_id_historico END ASC, 
 CASE when @sortField = 'HSAL_id_historico' and  @sortOrder='DESC' then A.HSAL_id_historico END DESC 
 ,  CASE when @sortField = 'HSAL_ds_email' and  @sortOrder='ASC' then A.HSAL_ds_email END ASC, 
 CASE when @sortField = 'HSAL_ds_email' and  @sortOrder='DESC' then A.HSAL_ds_email END DESC 
 ,  CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='ASC' then A.ALER_nm_alerta END ASC, 
 CASE when @sortField = 'ALER_nm_alerta' and  @sortOrder='DESC' then A.ALER_nm_alerta END DESC 
 ,  CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='ASC' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = 'PROC_cd_processo' and  @sortOrder='DESC' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = 'HSAL_ds_assunto_email' and  @sortOrder='ASC' then A.HSAL_ds_assunto_email END ASC, 
 CASE when @sortField = 'HSAL_ds_assunto_email' and  @sortOrder='DESC' then A.HSAL_ds_assunto_email END DESC 
 ,  CASE when @sortField = 'HSAL_ds_texto_email' and  @sortOrder='ASC' then A.HSAL_ds_texto_email END ASC, 
 CASE when @sortField = 'HSAL_ds_texto_email' and  @sortOrder='DESC' then A.HSAL_ds_texto_email END DESC 
 ,  CASE when @sortField = 'HSAL_dt_envio' and  @sortOrder='ASC' then A.HSAL_dt_envio END ASC, 
 CASE when @sortField = 'HSAL_dt_envio' and  @sortOrder='DESC' then A.HSAL_dt_envio END DESC 
 ,  CASE when @sortField = 'HSAL_dt_tentativa_ultimo_envio' and  @sortOrder='ASC' then A.HSAL_dt_tentativa_ultimo_envio END ASC, 
 CASE when @sortField = 'HSAL_dt_tentativa_ultimo_envio' and  @sortOrder='DESC' then A.HSAL_dt_tentativa_ultimo_envio END DESC 
 ,  CASE when @sortField = 'HSAL_ds_mensagem' and  @sortOrder='ASC' then A.HSAL_ds_mensagem END ASC, 
 CASE when @sortField = 'HSAL_ds_mensagem' and  @sortOrder='DESC' then A.HSAL_ds_mensagem END DESC 
 ,  CASE when @sortField = 'HSAL_fl_status' and  @sortOrder='ASC' then A.HSAL_fl_status END ASC, 
 CASE when @sortField = 'HSAL_fl_status' and  @sortOrder='DESC' then A.HSAL_fl_status END DESC 
 ,  CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='ASC' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = 'AUDT_dt_inclusao' and  @sortOrder='DESC' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='ASC' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = 'AUDT_nm_usuario_inclusao' and  @sortOrder='DESC' then A.AUDT_nm_usuario_inclusao END DESC 

 
SELECT * FROM 
@tb_HSAL_historico_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


GO
grant execute on sp_sel_tb_HSAL_historico_alerta_rel to rl_exec_proc
GO

