USE [dbDNPM]
GO
/****** Object:  Table [dbo].[tb_ALER_alerta]    Script Date: 03/25/2018 20:36:58 ******/
INSERT [dbo].[tb_ALER_alerta] ([ALER_nm_alerta], [ALER_ds_alerta], [ALER_fl_muda_fase], [ALER_fl_muda_evento], [ALER_cd_fase_anterior], [ALER_cd_fase_nova], [ALER_fl_qualquer_processo], [ALER_fl_status], [ALER_fl_sistema], [AUDT_dt_inclusao], [AUDT_nm_usuario_inclusao], [AUDT_dt_alteracao], [AUDT_nm_usuario_alteracao], [ALER_fl_geral], [ALER_cd_evento], [ALER_fl_andamento], [ALER_fl_acao]) VALUES (N'Disponiveis', N'Áreas em fase de disponibilidade', N'S', N'N', 0, 12, N'N', N'A', N'N', CAST(0x0000A0B000FD26B9 AS DateTime), N'adm', CAST(0x0000A0B000FD26B9 AS DateTime), N'adm', N'S', N'', N'N', N'0')
INSERT [dbo].[tb_ALER_alerta] ([ALER_nm_alerta], [ALER_ds_alerta], [ALER_fl_muda_fase], [ALER_fl_muda_evento], [ALER_cd_fase_anterior], [ALER_cd_fase_nova], [ALER_fl_qualquer_processo], [ALER_fl_status], [ALER_fl_sistema], [AUDT_dt_inclusao], [AUDT_nm_usuario_inclusao], [AUDT_dt_alteracao], [AUDT_nm_usuario_alteracao], [ALER_fl_geral], [ALER_cd_evento], [ALER_fl_andamento], [ALER_fl_acao]) VALUES (N'Evento Alvara 01', N'Publicação Alvará de 01 ano', N'N', N'S', 0, 0, N'S', N'A', N'N', CAST(0x0000A21A008B6AD4 AS DateTime), N'adm', CAST(0x0000A22700AEA605 AS DateTime), N'adm', N'S', N'321', N'S', N'1')
INSERT [dbo].[tb_ALER_alerta] ([ALER_nm_alerta], [ALER_ds_alerta], [ALER_fl_muda_fase], [ALER_fl_muda_evento], [ALER_cd_fase_anterior], [ALER_cd_fase_nova], [ALER_fl_qualquer_processo], [ALER_fl_status], [ALER_fl_sistema], [AUDT_dt_inclusao], [AUDT_nm_usuario_inclusao], [AUDT_dt_alteracao], [AUDT_nm_usuario_alteracao], [ALER_fl_geral], [ALER_cd_evento], [ALER_fl_andamento], [ALER_fl_acao]) VALUES (N'Evento Alvara 02', N'Publicacao do Alvara de Pesquisa 02 anos', N'N', N'S', 0, 0, N'S', N'A', N'N', CAST(0x0000A17200B3FD69 AS DateTime), N'adm', CAST(0x0000A22700AEB760 AS DateTime), N'adm', N'S', N'322', N'S', N'1')
INSERT [dbo].[tb_ALER_alerta] ([ALER_nm_alerta], [ALER_ds_alerta], [ALER_fl_muda_fase], [ALER_fl_muda_evento], [ALER_cd_fase_anterior], [ALER_cd_fase_nova], [ALER_fl_qualquer_processo], [ALER_fl_status], [ALER_fl_sistema], [AUDT_dt_inclusao], [AUDT_nm_usuario_inclusao], [AUDT_dt_alteracao], [AUDT_nm_usuario_alteracao], [ALER_fl_geral], [ALER_cd_evento], [ALER_fl_andamento], [ALER_fl_acao]) VALUES (N'Evento Alvara 03', N'Publicacao do Alvara de Pesquisa para 03 anos', N'N', N'S', 0, 0, N'S', N'A', N'N', CAST(0x0000A17200B4348C AS DateTime), N'adm', CAST(0x0000A22700AEC3CE AS DateTime), N'adm', N'S', N'323', N'S', N'1')
INSERT [dbo].[tb_ALER_alerta] ([ALER_nm_alerta], [ALER_ds_alerta], [ALER_fl_muda_fase], [ALER_fl_muda_evento], [ALER_cd_fase_anterior], [ALER_cd_fase_nova], [ALER_fl_qualquer_processo], [ALER_fl_status], [ALER_fl_sistema], [AUDT_dt_inclusao], [AUDT_nm_usuario_inclusao], [AUDT_dt_alteracao], [AUDT_nm_usuario_alteracao], [ALER_fl_geral], [ALER_cd_evento], [ALER_fl_andamento], [ALER_fl_acao]) VALUES (N'Muda Fase ou Evento', N'Alerta para mudança de fase e/ou mudança de último evento', N'S', N'S', NULL, NULL, N'N', N'A', N'S', CAST(0x00009FCB00000000 AS DateTime), N'adm', CAST(0x00009FCB00000000 AS DateTime), N'adm', N'N', N'', N'N', N'0')
