USE [dbDNPM]
GO
/****** Object:  Table [dbo].[tb_BACK_backup]    Script Date: 03/25/2018 20:36:58 ******/
INSERT [dbo].[tb_BACK_backup] ([BACK_cd_backup], [BACK_vl_intervalo], [BACK_nm_arquivo], [BACK_fl_execucao], [BACK_ds_mensagem], [BACK_dt_execucao], [BACK_dt_tentativa_Execucao], [BACK_dt_backup], [BACK_dt_sincronizacao], [BACK_fl_tipo], [AUDT_dt_inclusao], [AUDT_nm_usuario_inclusao], [AUDT_dt_alteracao], [AUDT_nm_usuario_alteracao]) VALUES (1, 60, N'dbDNPM.bak', N'N', N'', CAST(0x0000A22600E67FF6 AS DateTime), CAST(0x0000A22600E67FF6 AS DateTime), CAST(0x0000A22600E67FF6 AS DateTime), NULL, N'M', CAST(0x0000A16400FF9A32 AS DateTime), N'adm', CAST(0x0000A22600E67FF6 AS DateTime), N'adm')
