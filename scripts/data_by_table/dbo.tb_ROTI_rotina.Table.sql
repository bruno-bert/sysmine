USE [dbDNPM]
GO
/****** Object:  Table [dbo].[tb_ROTI_rotina]    Script Date: 03/25/2018 20:36:58 ******/
INSERT [dbo].[tb_ROTI_rotina] ([ROTI_nm_rotina], [ROTI_ds_rotina], [ROTI_dt_inicio_execucao], [ROTI_dt_ultima_execucao], [ROTI_dt_ultima_tentativa_execucao], [ROTI_fl_status_execucao], [ROTI_ds_mensagem], [ROTI_vl_tempo_medio], [AUDT_dt_inclusao], [AUDT_nm_usuario_inclusao], [AUDT_dt_alteracao], [AUDT_nm_usuario_alteracao]) VALUES (N'Alertas DNPM', N'Rotina de sincronização de processos e envio de alertas', CAST(0x0000A23B012B28DA AS DateTime), CAST(0x0000A22F00CF123E AS DateTime), CAST(0x0000A23A0112C5BE AS DateTime), N'S', N'', CAST(208.00 AS Decimal(13, 2)), CAST(0x00009FCB00000000 AS DateTime), N'adm', CAST(0x0000A8A201646E19 AS DateTime), N'adm')
