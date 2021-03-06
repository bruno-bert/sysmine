USE [dbDNPM]
GO
/****** Object:  Table [dbo].[tb_ALER_alerta]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__tb_ALER_a__ALER___66603565]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tb_ALER_alerta] DROP CONSTRAINT [DF__tb_ALER_a__ALER___66603565]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__tb_ALER_a__ALER___0EC32C7A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tb_ALER_alerta] DROP CONSTRAINT [DF__tb_ALER_a__ALER___0EC32C7A]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__tb_ALER_a__ALER___0FB750B3]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tb_ALER_alerta] DROP CONSTRAINT [DF__tb_ALER_a__ALER___0FB750B3]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_ALER_alerta]') AND type in (N'U'))
DROP TABLE [dbo].[tb_ALER_alerta]
GO
/****** Object:  Table [dbo].[tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__tb_AVEN_a__AVEN___7C1A6C5A]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tb_AVEN_alerta_vencimento] DROP CONSTRAINT [DF__tb_AVEN_a__AVEN___7C1A6C5A]
END
GO
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__tb_AVEN_a__AVEN___7D0E9093]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tb_AVEN_alerta_vencimento] DROP CONSTRAINT [DF__tb_AVEN_a__AVEN___7D0E9093]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_AVEN_alerta_vencimento]') AND type in (N'U'))
DROP TABLE [dbo].[tb_AVEN_alerta_vencimento]
GO
/****** Object:  Table [dbo].[tb_BACK_backup]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_BACK_backup]') AND type in (N'U'))
DROP TABLE [dbo].[tb_BACK_backup]
GO
/****** Object:  Table [dbo].[tb_COND_condicao]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_COND_condicao]') AND type in (N'U'))
DROP TABLE [dbo].[tb_COND_condicao]
GO
/****** Object:  Table [dbo].[tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_COVE_controle_vencimento]') AND type in (N'U'))
DROP TABLE [dbo].[tb_COVE_controle_vencimento]
GO
/****** Object:  Table [dbo].[tb_EMPR_empresa]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__tb_EMPR_e__EMPR___1920BF5C]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tb_EMPR_empresa] DROP CONSTRAINT [DF__tb_EMPR_e__EMPR___1920BF5C]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_EMPR_empresa]') AND type in (N'U'))
DROP TABLE [dbo].[tb_EMPR_empresa]
GO
/****** Object:  Table [dbo].[tb_FASE_fase]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_FASE_fase]') AND type in (N'U'))
DROP TABLE [dbo].[tb_FASE_fase]
GO
/****** Object:  Table [dbo].[tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_HSAL_historico_alerta]') AND type in (N'U'))
DROP TABLE [dbo].[tb_HSAL_historico_alerta]
GO
/****** Object:  Table [dbo].[tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_LESI_log_erro_sistema]') AND type in (N'U'))
DROP TABLE [dbo].[tb_LESI_log_erro_sistema]
GO
/****** Object:  Table [dbo].[tb_MPRI_mprima]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_MPRI_mprima]') AND type in (N'U'))
DROP TABLE [dbo].[tb_MPRI_mprima]
GO
/****** Object:  Table [dbo].[tb_MUNI_municipio]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_MUNI_municipio]') AND type in (N'U'))
DROP TABLE [dbo].[tb_MUNI_municipio]
GO
/****** Object:  Table [dbo].[tb_OPER_operador]    Script Date: 03/25/2018 20:34:45 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_OPER_operador]') AND type in (N'U'))
DROP TABLE [dbo].[tb_OPER_operador]
GO
/****** Object:  Table [dbo].[tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_OSSD_objeto_sd]') AND type in (N'U'))
DROP TABLE [dbo].[tb_OSSD_objeto_sd]
GO
/****** Object:  Table [dbo].[tb_PASO_processo_associado]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PASO_processo_associado]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PASO_processo_associado]
GO
/****** Object:  Table [dbo].[tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PAUX_processo_auxiliar]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PAUX_processo_auxiliar]
GO
/****** Object:  Table [dbo].[tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PCON_processo_condicao]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PCON_processo_condicao]
GO
/****** Object:  Table [dbo].[tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PDOC_processo_documento]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PDOC_processo_documento]
GO
/****** Object:  Table [dbo].[tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PGER_parametro_geral]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PGER_parametro_geral]
GO
/****** Object:  Table [dbo].[tb_PINF_processo_info]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PINF_processo_info]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PINF_processo_info]
GO
/****** Object:  Table [dbo].[tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PMUN_processo_municipio]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PMUN_processo_municipio]
GO
/****** Object:  Table [dbo].[tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PNOT_processo_nota]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PNOT_processo_nota]
GO
/****** Object:  Table [dbo].[tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PORG_processo_orgao]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PORG_processo_orgao]
GO
/****** Object:  Table [dbo].[tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRAL_processo_alerta]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PRAL_processo_alerta]
GO
/****** Object:  Table [dbo].[tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRAN_processo_andamento]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PRAN_processo_andamento]
GO
/****** Object:  Table [dbo].[tb_PREV_processo_evento]    Script Date: 03/25/2018 20:34:46 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PREV_processo_evento]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PREV_processo_evento]
GO
/****** Object:  Table [dbo].[tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRMP_processo_mprima]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PRMP_processo_mprima]
GO
/****** Object:  Table [dbo].[tb_PROC_processo]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[DF__tb_PROC_p__PROC___0AF29B96]') AND type = 'D')
BEGIN
ALTER TABLE [dbo].[tb_PROC_processo] DROP CONSTRAINT [DF__tb_PROC_p__PROC___0AF29B96]
END
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PROC_processo]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PROC_processo]
GO
/****** Object:  Table [dbo].[tb_PROD_produto]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PROD_produto]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PROD_produto]
GO
/****** Object:  Table [dbo].[tb_PROP_processo_operador]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PROP_processo_operador]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PROP_processo_operador]
GO
/****** Object:  Table [dbo].[tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRPD_processo_produto]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PRPD_processo_produto]
GO
/****** Object:  Table [dbo].[tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRSD_processo_sd]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PRSD_processo_sd]
GO
/****** Object:  Table [dbo].[tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PSUB_processo_substancia]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PSUB_processo_substancia]
GO
/****** Object:  Table [dbo].[tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PTIT_processo_titulo]') AND type in (N'U'))
DROP TABLE [dbo].[tb_PTIT_processo_titulo]
GO
/****** Object:  Table [dbo].[tb_ROTI_rotina]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_ROTI_rotina]') AND type in (N'U'))
DROP TABLE [dbo].[tb_ROTI_rotina]
GO
/****** Object:  Table [dbo].[tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SCON_situacao_condicao]') AND type in (N'U'))
DROP TABLE [dbo].[tb_SCON_situacao_condicao]
GO
/****** Object:  Table [dbo].[tb_SINF_situacao_info]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SINF_situacao_info]') AND type in (N'U'))
DROP TABLE [dbo].[tb_SINF_situacao_info]
GO
/****** Object:  Table [dbo].[tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SISD_situacao_sd]') AND type in (N'U'))
DROP TABLE [dbo].[tb_SISD_situacao_sd]
GO
/****** Object:  Table [dbo].[tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:34:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SITU_situacao_titulo]') AND type in (N'U'))
DROP TABLE [dbo].[tb_SITU_situacao_titulo]
GO
/****** Object:  Table [dbo].[tb_SUBS_substancia]    Script Date: 03/25/2018 20:34:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SUBS_substancia]') AND type in (N'U'))
DROP TABLE [dbo].[tb_SUBS_substancia]
GO
/****** Object:  Table [dbo].[tb_TABE_tabela]    Script Date: 03/25/2018 20:34:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_TABE_tabela]') AND type in (N'U'))
DROP TABLE [dbo].[tb_TABE_tabela]
GO
/****** Object:  Table [dbo].[tb_TINF_tipo_info]    Script Date: 03/25/2018 20:34:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_TINF_tipo_info]') AND type in (N'U'))
DROP TABLE [dbo].[tb_TINF_tipo_info]
GO
/****** Object:  Table [dbo].[tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:34:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_TTIT_tipo_titulo]') AND type in (N'U'))
DROP TABLE [dbo].[tb_TTIT_tipo_titulo]
GO
/****** Object:  Table [dbo].[tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:34:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_TUSO_tipo_uso]') AND type in (N'U'))
DROP TABLE [dbo].[tb_TUSO_tipo_uso]
GO
/****** Object:  Table [dbo].[tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:34:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_UNFE_unidade_federativa]') AND type in (N'U'))
DROP TABLE [dbo].[tb_UNFE_unidade_federativa]
GO
/****** Object:  Table [dbo].[tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:34:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_UNME_unidade_medida]') AND type in (N'U'))
DROP TABLE [dbo].[tb_UNME_unidade_medida]
GO
/****** Object:  Table [dbo].[tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:34:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_UPRD_uso_produto]') AND type in (N'U'))
DROP TABLE [dbo].[tb_UPRD_uso_produto]
GO
/****** Object:  Table [dbo].[tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_UPRD_uso_produto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_UPRD_uso_produto](
	[UPRD_nm_uso] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_UPRD_01] PRIMARY KEY CLUSTERED 
(
	[UPRD_nm_uso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_UNME_unidade_medida]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_UNME_unidade_medida](
	[UNME_nm_unidade] [varchar](10) NOT NULL,
	[UNME_ds_unidade] [varchar](100) NOT NULL,
	[UNME_nm_tipo] [char](2) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_UNME_01] PRIMARY KEY CLUSTERED 
(
	[UNME_nm_unidade] ASC,
	[UNME_nm_tipo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_UNFE_unidade_federativa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_UNFE_unidade_federativa](
	[UNFE_cd_unidade_federativa] [char](2) NOT NULL,
	[UNFE_nm_unidade_federativa] [varchar](100) NOT NULL,
	[UNFE_fl_status] [char](1) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_UNFE_01] PRIMARY KEY CLUSTERED 
(
	[UNFE_cd_unidade_federativa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY],
 CONSTRAINT [un_UNFE_02] UNIQUE NONCLUSTERED 
(
	[UNFE_nm_unidade_federativa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_TUSO_tipo_uso]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_TUSO_tipo_uso](
	[TUSO_nm_uso] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_TUSO_01] PRIMARY KEY CLUSTERED 
(
	[TUSO_nm_uso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_TTIT_tipo_titulo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_TTIT_tipo_titulo](
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[TTIT_ds_tipo_titulo] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_TTIT_01] PRIMARY KEY CLUSTERED 
(
	[ORGA_nm_orgao] ASC,
	[TTIT_ds_tipo_titulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_TINF_tipo_info]    Script Date: 03/25/2018 20:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_TINF_tipo_info]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_TINF_tipo_info](
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[TINF_nm_tipo_info] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_TINF_01] PRIMARY KEY CLUSTERED 
(
	[ORGA_nm_orgao] ASC,
	[TINF_nm_tipo_info] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_TABE_tabela]    Script Date: 03/25/2018 20:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_TABE_tabela]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_TABE_tabela](
	[TABE_nm_tabela] [varchar](50) NOT NULL,
	[TABE_ds_tabela] [varchar](200) NOT NULL,
	[TABE_ds_selectall] [varchar](1000) NOT NULL,
	[TABE_ds_selectcheck] [varchar](1000) NOT NULL,
	[TABE_ds_deleleone] [varchar](1000) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_TABE_01] PRIMARY KEY CLUSTERED 
(
	[TABE_nm_tabela] ASC,
	[TABE_ds_tabela] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY],
 CONSTRAINT [un_TABE_02] UNIQUE NONCLUSTERED 
(
	[TABE_ds_tabela] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_SUBS_substancia]    Script Date: 03/25/2018 20:34:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SUBS_substancia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_SUBS_substancia](
	[SUBS_nm_substancia] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_SUBS_01] PRIMARY KEY CLUSTERED 
(
	[SUBS_nm_substancia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SITU_situacao_titulo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_SITU_situacao_titulo](
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[SITU_ds_situacao_titulo] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_SITU_01] PRIMARY KEY CLUSTERED 
(
	[ORGA_nm_orgao] ASC,
	[SITU_ds_situacao_titulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SISD_situacao_sd]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_SISD_situacao_sd](
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[SISD_nm_situacao_sd] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_SISD_01] PRIMARY KEY CLUSTERED 
(
	[ORGA_nm_orgao] ASC,
	[SISD_nm_situacao_sd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_SINF_situacao_info]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SINF_situacao_info]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_SINF_situacao_info](
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[SINF_ds_situacao_info] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_SINF_01] PRIMARY KEY CLUSTERED 
(
	[ORGA_nm_orgao] ASC,
	[SINF_ds_situacao_info] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_SCON_situacao_condicao]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_SCON_situacao_condicao](
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[SCON_ds_situacao_condicao] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_SCON_01] PRIMARY KEY CLUSTERED 
(
	[ORGA_nm_orgao] ASC,
	[SCON_ds_situacao_condicao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_ROTI_rotina]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_ROTI_rotina]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_ROTI_rotina](
	[ROTI_nm_rotina] [varchar](30) NOT NULL,
	[ROTI_ds_rotina] [varchar](300) NULL,
	[ROTI_dt_inicio_execucao] [datetime] NULL,
	[ROTI_dt_ultima_execucao] [datetime] NULL,
	[ROTI_dt_ultima_tentativa_execucao] [datetime] NULL,
	[ROTI_fl_status_execucao] [char](1) NOT NULL,
	[ROTI_ds_mensagem] [varchar](1000) NULL,
	[ROTI_vl_tempo_medio] [decimal](13, 2) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_ROTI_01] PRIMARY KEY CLUSTERED 
(
	[ROTI_nm_rotina] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PTIT_processo_titulo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PTIT_processo_titulo](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[PTIT_nm_titulo] [varchar](50) NOT NULL,
	[PTIT_ds_titulo] [varchar](300) NOT NULL,
	[TTIT_ds_tipo_titulo] [varchar](100) NOT NULL,
	[SITU_ds_situacao_titulo] [varchar](100) NULL,
	[PTIT_dt_publicacao] [datetime] NULL,
	[PTIT_dt_vencimento] [datetime] NULL,
	[PTIT_ds_nome_documento] [varchar](1000) NULL,
	[PTIT_ds_local_documento] [varchar](1000) NULL,
	[PTIT_ds_rede_documento] [varchar](1000) NULL,
	[PTIT_ds_path_documento] [varchar](1000) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PTIT_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[PTIT_nm_titulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PSUB_processo_substancia]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PSUB_processo_substancia](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[SUBS_nm_substancia] [varchar](100) NOT NULL,
	[TUSO_nm_uso] [varchar](100) NOT NULL,
	[PSUB_dt_inicio] [date] NULL,
	[PSUB_dt_fim] [date] NULL,
	[PSUB_ds_motivo] [varchar](500) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PSUB_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[SUBS_nm_substancia] ASC,
	[TUSO_nm_uso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRSD_processo_sd]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PRSD_processo_sd](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[PRSD_nm_sd] [varchar](30) NOT NULL,
	[PRSD_dt_sd] [datetime] NULL,
	[PRSD_nm_prc] [varchar](30) NULL,
	[PRSD_nm_doc] [varchar](30) NULL,
	[PRSD_dt_ini] [datetime] NULL,
	[PRSD_dt_fim] [datetime] NULL,
	[SISD_nm_situacao_sd] [varchar](100) NULL,
	[OSSD_nm_objeto] [varchar](100) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PRSD_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[PRSD_nm_sd] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRPD_processo_produto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PRPD_processo_produto](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[MPRI_nm_mprima] [varchar](100) NOT NULL,
	[PROD_nm_produto] [varchar](100) NOT NULL,
	[PRPD_vl_produto] [decimal](15, 3) NULL,
	[PRPD_un_produto] [varchar](10) NULL,
	[UPRD_nm_uso] [varchar](100) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PRPD_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[MPRI_nm_mprima] ASC,
	[PROD_nm_produto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PROP_processo_operador]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PROP_processo_operador]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PROP_processo_operador](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[OPER_cd_operador] [varchar](20) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PROP_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[OPER_cd_operador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PROD_produto]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PROD_produto]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PROD_produto](
	[PROD_nm_produto] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PROD_01] PRIMARY KEY CLUSTERED 
(
	[PROD_nm_produto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PROC_processo]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PROC_processo]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PROC_processo](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[PROC_ds_titular] [varchar](300) NOT NULL,
	[PROC_vl_ano] [int] NULL,
	[PROC_nm_processo] [varchar](50) NULL,
	[PROC_id_processo] [varchar](300) NULL,
	[FASE_cd_fase] [int] NULL,
	[PROC_ds_ultimo_evento] [varchar](3000) NULL,
	[PROC_ds_substancia] [varchar](100) NULL,
	[PROC_ds_area] [varchar](30) NULL,
	[PROC_ds_uso] [varchar](200) NULL,
	[PROC_ds_link] [varchar](150) NULL,
	[UNFE_cd_unidade_federativa] [char](2) NULL,
	[PROC_fl_tipo_inclusao] [char](1) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
	[PROC_cd_prioridade] [varchar](3) NOT NULL DEFAULT ('1'),
 CONSTRAINT [pk_PROC_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:34:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRMP_processo_mprima]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PRMP_processo_mprima](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[MPRI_nm_mprima] [varchar](100) NOT NULL,
	[PRMP_vl_mprima] [decimal](15, 3) NULL,
	[PRMP_un_mprima] [varchar](10) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PRMP_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[MPRI_nm_mprima] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PREV_processo_evento]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PREV_processo_evento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PREV_processo_evento](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[PREV_id_evento] [int] NOT NULL,
	[PREV_cd_evento] [varchar](20) NOT NULL,
	[PREV_ds_evento] [varchar](3000) NULL,
	[PREV_dt_ocorrencia] [datetime] NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PREV_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[PREV_id_evento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRAN_processo_andamento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PRAN_processo_andamento](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[PROC_ds_titular] [varchar](300) NOT NULL,
	[PROC_cd_ultimo_evento] [varchar](20) NULL,
	[PROC_ds_ultimo_evento] [varchar](1000) NULL,
	[PROC_ds_link] [varchar](150) NULL,
	[PROC_cd_evento_andamento] [varchar](20) NULL,
	[PROC_ds_evento_andamento] [varchar](1000) NULL,
	[PROC_dt_vencimento] [datetime] NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PRAN_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PRAL_processo_alerta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PRAL_processo_alerta](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ALER_nm_alerta] [varchar](50) NOT NULL,
	[PRAL_fl_manutencao] [char](1) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PRAL_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ALER_nm_alerta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PORG_processo_orgao]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PORG_processo_orgao](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[PORG_nm_cadastro] [varchar](30) NULL,
	[PORG_ds_atividade] [varchar](500) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PORG_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PNOT_processo_nota]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PNOT_processo_nota](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[PNOT_cd_nota] [int] NOT NULL,
	[PNOT_ds_nota] [varchar](1000) NOT NULL,
	[PNOT_dt_ocorrencia] [datetime] NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PNOT_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[PNOT_cd_nota] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PMUN_processo_municipio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PMUN_processo_municipio](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[MUNI_nm_municipio] [varchar](150) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PMUN_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[MUNI_nm_municipio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PINF_processo_info]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PINF_processo_info]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PINF_processo_info](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[PINF_cd_info] [int] NOT NULL,
	[PINF_ds_info] [varchar](500) NULL,
	[TINF_nm_tipo_info] [varchar](100) NULL,
	[SINF_ds_situacao_info] [varchar](100) NULL,
	[PINF_dt_ini] [datetime] NULL,
	[PINF_dt_fim] [datetime] NULL,
	[PINF_ds_local_documento] [varchar](500) NOT NULL,
	[PINF_ds_rede_documento] [varchar](500) NOT NULL,
	[PINF_ds_path_documento] [varchar](500) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PINF_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[PINF_cd_info] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PGER_parametro_geral]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PGER_parametro_geral](
	[PGER_cd_parametro] [varchar](10) NOT NULL,
	[PGER_ds_parametro] [varchar](100) NOT NULL,
	[PGER_vl_parametro] [varchar](1000) NOT NULL,
	[PGER_fl_tipo] [char](1) NOT NULL,
	[PGER_fl_sistema] [char](1) NOT NULL,
	[PGER_vl_range_min] [bigint] NULL,
	[PGER_vl_range_max] [bigint] NULL,
	[PGER_vl_padrao] [varchar](1000) NOT NULL,
	[PGER_vl_tamanho_min] [int] NULL,
	[PGER_vl_tamanho_max] [int] NULL,
	[PGER_vl_valores_permitidos] [varchar](8000) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PGER_01] PRIMARY KEY CLUSTERED 
(
	[PGER_cd_parametro] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PDOC_processo_documento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PDOC_processo_documento](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[PDOC_nm_documento] [varchar](100) NOT NULL,
	[PDOC_ds_documento] [varchar](1000) NULL,
	[PDOC_ds_local_documento] [varchar](1000) NULL,
	[PDOC_ds_rede_documento] [varchar](1000) NULL,
	[PDOC_ds_path_documento] [varchar](1000) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PDOC_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[PDOC_nm_documento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PCON_processo_condicao]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PCON_processo_condicao](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[PCON_cd_condicao] [int] NOT NULL,
	[COND_nm_condicao] [varchar](500) NOT NULL,
	[SCON_ds_situacao_condicao] [varchar](100) NULL,
	[PCON_ds_condicao] [varchar](500) NULL,
	[PCON_dt_ini] [datetime] NULL,
	[PCON_dt_fim] [datetime] NULL,
	[PCON_ds_nome_documento] [varchar](1000) NULL,
	[PCON_ds_local_documento] [varchar](1000) NULL,
	[PCON_ds_rede_documento] [varchar](1000) NULL,
	[PCON_ds_path_documento] [varchar](1000) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PCON_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[PCON_cd_condicao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PAUX_processo_auxiliar]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PAUX_processo_auxiliar](
	[PAUX_cd_processo] [varchar](50) NOT NULL,
	[PAUX_ds_titular] [varchar](300) NOT NULL,
	[FASE_cd_fase] [int] NULL,
	[PAUX_ds_ultimo_evento] [varchar](3000) NULL,
	[UNFE_cd_unidade_federativa] [char](2) NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PAUX_01] PRIMARY KEY CLUSTERED 
(
	[PAUX_cd_processo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_PASO_processo_associado]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_PASO_processo_associado]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_PASO_processo_associado](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[PASO_cd_processo] [varchar](50) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_PASO_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[PASO_cd_processo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:34:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_OSSD_objeto_sd]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_OSSD_objeto_sd](
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[OSSD_nm_objeto] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_OSSD_01] PRIMARY KEY CLUSTERED 
(
	[ORGA_nm_orgao] ASC,
	[OSSD_nm_objeto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_OPER_operador]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_OPER_operador]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_OPER_operador](
	[OPER_cd_operador] [varchar](20) NOT NULL,
	[OPER_nm_operador] [varchar](1000) NOT NULL,
	[OPER_ds_email] [varchar](200) NOT NULL,
	[OPER_fl_alerta] [char](1) NOT NULL,
	[OPER_fl_alerta_nativo] [char](1) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_OPER_01] PRIMARY KEY CLUSTERED 
(
	[OPER_cd_operador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY],
 CONSTRAINT [un_OPER_02] UNIQUE NONCLUSTERED 
(
	[OPER_nm_operador] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY],
 CONSTRAINT [un_OPER_03] UNIQUE NONCLUSTERED 
(
	[OPER_ds_email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_MUNI_municipio]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_MUNI_municipio]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_MUNI_municipio](
	[MUNI_nm_municipio] [varchar](150) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_MUNI_01] PRIMARY KEY CLUSTERED 
(
	[MUNI_nm_municipio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_MPRI_mprima]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_MPRI_mprima]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_MPRI_mprima](
	[MPRI_nm_mprima] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_MPRI_01] PRIMARY KEY CLUSTERED 
(
	[MPRI_nm_mprima] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_LESI_log_erro_sistema]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_LESI_log_erro_sistema](
	[LESI_cd_ocorrencia] [bigint] IDENTITY(1,1) NOT NULL,
	[LESI_nm_source] [varchar](100) NOT NULL,
	[LESI_ds_exception] [varchar](8000) NULL,
	[LESI_ds_inexception] [varchar](8000) NULL,
	[LESI_dt_ocorrencia] [datetime] NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_LESI_01] PRIMARY KEY CLUSTERED 
(
	[LESI_cd_ocorrencia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_HSAL_historico_alerta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_HSAL_historico_alerta](
	[HSAL_id_historico] [int] NOT NULL,
	[HSAL_ds_email] [varchar](200) NOT NULL,
	[ALER_nm_alerta] [varchar](50) NOT NULL,
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[HSAL_ds_assunto_email] [varchar](200) NOT NULL,
	[HSAL_ds_texto_email] [varchar](8000) NOT NULL,
	[HSAL_dt_envio] [datetime] NULL,
	[HSAL_dt_tentativa_ultimo_envio] [datetime] NULL,
	[HSAL_ds_mensagem] [varchar](8000) NULL,
	[HSAL_fl_status] [char](3) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_HSAL_01] PRIMARY KEY CLUSTERED 
(
	[HSAL_id_historico] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_FASE_fase]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_FASE_fase]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_FASE_fase](
	[FASE_cd_fase] [int] NOT NULL,
	[FASE_nm_fase] [varchar](100) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_FASE_01] PRIMARY KEY CLUSTERED 
(
	[FASE_cd_fase] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY],
 CONSTRAINT [un_FASE_02] UNIQUE NONCLUSTERED 
(
	[FASE_nm_fase] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_EMPR_empresa]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_EMPR_empresa]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_EMPR_empresa](
	[EMPR_nm_empresa] [varchar](20) NOT NULL,
	[EMPR_ds_empresa] [varchar](300) NOT NULL,
	[EMPR_fl_status] [char](1) NOT NULL DEFAULT ('A'),
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
	[EMPR_ds_dou] [varchar](500) NULL,
 CONSTRAINT [pk_EMPR_01] PRIMARY KEY CLUSTERED 
(
	[EMPR_nm_empresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY],
 CONSTRAINT [un_EMPR_02] UNIQUE NONCLUSTERED 
(
	[EMPR_ds_empresa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_COVE_controle_vencimento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_COVE_controle_vencimento](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[COVE_nm_tipo_documento] [varchar](10) NOT NULL,
	[COVE_id_documento] [varchar](20) NOT NULL,
	[COVE_qt_inicio] [int] NOT NULL,
	[COVE_qt_intervalo] [int] NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_COVE_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[COVE_nm_tipo_documento] ASC,
	[COVE_id_documento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_COND_condicao]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_COND_condicao]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_COND_condicao](
	[COND_nm_condicao] [varchar](500) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_COND_01] PRIMARY KEY CLUSTERED 
(
	[COND_nm_condicao] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_BACK_backup]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_BACK_backup]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_BACK_backup](
	[BACK_cd_backup] [int] NOT NULL,
	[BACK_vl_intervalo] [int] NOT NULL,
	[BACK_nm_arquivo] [varchar](30) NULL,
	[BACK_fl_execucao] [char](1) NULL,
	[BACK_ds_mensagem] [varchar](500) NULL,
	[BACK_dt_execucao] [datetime] NULL,
	[BACK_dt_tentativa_Execucao] [datetime] NULL,
	[BACK_dt_backup] [datetime] NOT NULL,
	[BACK_dt_sincronizacao] [datetime] NULL,
	[BACK_fl_tipo] [char](1) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_BACK_01] PRIMARY KEY CLUSTERED 
(
	[BACK_cd_backup] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_AVEN_alerta_vencimento]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_AVEN_alerta_vencimento](
	[PROC_cd_processo] [varchar](50) NOT NULL,
	[ORGA_nm_orgao] [varchar](10) NOT NULL,
	[AVEN_nm_tipo_documento] [varchar](40) NOT NULL,
	[AVEN_id_documento] [varchar](20) NOT NULL,
	[AVEN_fl_conta_alerta] [int] NOT NULL,
	[AVEN_dt_ultimo_alerta] [datetime] NOT NULL CONSTRAINT [DF__tb_AVEN_a__AVEN___7C1A6C5A]  DEFAULT ('1900-01-01'),
	[AVEN_fl_ultimo_envio] [char](1) NOT NULL CONSTRAINT [DF__tb_AVEN_a__AVEN___7D0E9093]  DEFAULT ('N'),
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
 CONSTRAINT [pk_AVEN_01] PRIMARY KEY CLUSTERED 
(
	[PROC_cd_processo] ASC,
	[ORGA_nm_orgao] ASC,
	[AVEN_nm_tipo_documento] ASC,
	[AVEN_id_documento] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_ALER_alerta]    Script Date: 03/25/2018 20:34:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[tb_ALER_alerta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[tb_ALER_alerta](
	[ALER_nm_alerta] [varchar](50) NOT NULL,
	[ALER_ds_alerta] [varchar](300) NULL,
	[ALER_fl_muda_fase] [char](1) NOT NULL,
	[ALER_fl_muda_evento] [char](1) NOT NULL,
	[ALER_cd_fase_anterior] [int] NULL,
	[ALER_cd_fase_nova] [int] NULL,
	[ALER_fl_qualquer_processo] [char](1) NOT NULL,
	[ALER_fl_status] [char](1) NOT NULL,
	[ALER_fl_sistema] [char](1) NOT NULL,
	[AUDT_dt_inclusao] [datetime] NOT NULL,
	[AUDT_nm_usuario_inclusao] [varchar](20) NOT NULL,
	[AUDT_dt_alteracao] [datetime] NOT NULL,
	[AUDT_nm_usuario_alteracao] [varchar](20) NOT NULL,
	[ALER_fl_geral] [char](1) NOT NULL DEFAULT ('N'),
	[ALER_cd_evento] [varchar](5) NULL,
	[ALER_fl_andamento] [char](1) NOT NULL DEFAULT ('N'),
	[ALER_fl_acao] [char](1) NOT NULL DEFAULT ('0'),
 CONSTRAINT [pk_ALER_01] PRIMARY KEY CLUSTERED 
(
	[ALER_nm_alerta] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
