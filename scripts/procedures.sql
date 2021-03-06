USE [dbDNPM]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_ALER_alerta]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_ALER_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_ALER_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_AVEN_alerta_vencimento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_AVEN_alerta_vencimento]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_BACK_backup]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_BACK_backup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_BACK_backup]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_COND_condicao]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_COND_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_COND_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_COVE_controle_vencimento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_COVE_controle_vencimento]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_EMPR_empresa]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_EMPR_empresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_EMPR_empresa]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_FASE_fase]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_FASE_fase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_FASE_fase]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_HSAL_historico_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_HSAL_historico_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_LESI_log_erro_sistema]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_LESI_log_erro_sistema]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_MPRI_mprima]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_MPRI_mprima]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_MPRI_mprima]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_MUNI_municipio]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_MUNI_municipio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_MUNI_municipio]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_OPER_operador]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_OPER_operador]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_OPER_operador]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_OSSD_objeto_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_OSSD_objeto_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PASO_processo_associado]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PASO_processo_associado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PASO_processo_associado]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PAUX_processo_auxiliar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PAUX_processo_auxiliar]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PCON_processo_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PCON_processo_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PDOC_processo_documento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PDOC_processo_documento]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PGER_parametro_geral]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PGER_parametro_geral]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PINF_processo_info]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PINF_processo_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PINF_processo_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PMUN_processo_municipio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PMUN_processo_municipio]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PNOT_processo_nota]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PNOT_processo_nota]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PORG_processo_orgao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PORG_processo_orgao]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRAL_processo_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PRAL_processo_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRAN_processo_andamento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PRAN_processo_andamento]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PREV_processo_evento]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PREV_processo_evento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PREV_processo_evento]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRMP_processo_mprima]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PRMP_processo_mprima]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PROC_processo]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PROC_processo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PROC_processo]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PROD_produto]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PROD_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PROD_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PROP_processo_operador]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PROP_processo_operador]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PROP_processo_operador]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRPD_processo_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PRPD_processo_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRSD_processo_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PRSD_processo_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PSUB_processo_substancia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PSUB_processo_substancia]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PTIT_processo_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_PTIT_processo_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_ROTI_rotina]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_ROTI_rotina]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_ROTI_rotina]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SCON_situacao_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_SCON_situacao_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SINF_situacao_info]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SINF_situacao_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_SINF_situacao_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SISD_situacao_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_SISD_situacao_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SITU_situacao_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_SITU_situacao_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SUBS_substancia]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SUBS_substancia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_SUBS_substancia]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_TABE_tabela]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_TABE_tabela]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_TABE_tabela]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_TINF_tipo_info]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_TINF_tipo_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_TINF_tipo_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_TTIT_tipo_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_TTIT_tipo_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_TUSO_tipo_uso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_TUSO_tipo_uso]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_UNFE_unidade_federativa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_UNFE_unidade_federativa]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_UNME_unidade_medida]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_UNME_unidade_medida]
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_UPRD_uso_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_upd_tb_UPRD_uso_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_ALER_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_ALER_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_ALER_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_AVEN_alerta_vencimento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_AVEN_alerta_vencimento]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_BACK_backup]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_BACK_backup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_BACK_backup]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_COND_condicao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_COND_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_COND_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_COVE_controle_vencimento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_COVE_controle_vencimento]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_EMPR_empresa]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_EMPR_empresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_EMPR_empresa]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_FASE_fase]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_FASE_fase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_FASE_fase]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_HSAL_historico_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_HSAL_historico_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_LESI_log_erro_sistema]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_LESI_log_erro_sistema]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_MPRI_mprima]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_MPRI_mprima]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_MPRI_mprima]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_MUNI_municipio]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_MUNI_municipio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_MUNI_municipio]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_OPER_operador]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_OPER_operador]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_OPER_operador]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_OSSD_objeto_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_OSSD_objeto_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PASO_processo_associado]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PASO_processo_associado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PASO_processo_associado]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PAUX_processo_auxiliar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PAUX_processo_auxiliar]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PCON_processo_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PCON_processo_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PDOC_processo_documento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PDOC_processo_documento]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PGER_parametro_geral]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PGER_parametro_geral]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PINF_processo_info]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PINF_processo_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PINF_processo_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PMUN_processo_municipio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PMUN_processo_municipio]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PNOT_processo_nota]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PNOT_processo_nota]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PORG_processo_orgao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PORG_processo_orgao]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRAL_processo_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PRAL_processo_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRAN_processo_andamento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PRAN_processo_andamento]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PREV_processo_evento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PREV_processo_evento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PREV_processo_evento]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRMP_processo_mprima]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PRMP_processo_mprima]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PROC_processo]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PROC_processo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PROC_processo]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PROD_produto]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PROD_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PROD_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PROP_processo_operador]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PROP_processo_operador]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PROP_processo_operador]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRPD_processo_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PRPD_processo_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRSD_processo_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PRSD_processo_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PSUB_processo_substancia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PSUB_processo_substancia]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PTIT_processo_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_PTIT_processo_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_ROTI_rotina]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_ROTI_rotina]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_ROTI_rotina]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SCON_situacao_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_SCON_situacao_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SINF_situacao_info]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SINF_situacao_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_SINF_situacao_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SISD_situacao_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_SISD_situacao_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SITU_situacao_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_SITU_situacao_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SUBS_substancia]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SUBS_substancia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_SUBS_substancia]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_TABE_tabela]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_TABE_tabela]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_TABE_tabela]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_TINF_tipo_info]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_TINF_tipo_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_TINF_tipo_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_TTIT_tipo_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_TTIT_tipo_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_TUSO_tipo_uso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_TUSO_tipo_uso]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_UNFE_unidade_federativa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_UNFE_unidade_federativa]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_UNME_unidade_medida]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_UNME_unidade_medida]
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_UPRD_uso_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_del_tb_UPRD_uso_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_ALER_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_ALER_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_ALER_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_AVEN_alerta_vencimento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_AVEN_alerta_vencimento]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_BACK_backup]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_BACK_backup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_BACK_backup]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_COND_condicao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_COND_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_COND_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_COVE_controle_vencimento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_COVE_controle_vencimento]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_EMPR_empresa]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_EMPR_empresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_EMPR_empresa]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_FASE_fase]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_FASE_fase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_FASE_fase]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_HSAL_historico_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_HSAL_historico_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_LESI_log_erro_sistema]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_LESI_log_erro_sistema]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_MPRI_mprima]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_MPRI_mprima]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_MPRI_mprima]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_MUNI_municipio]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_MUNI_municipio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_MUNI_municipio]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_OPER_operador]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_OPER_operador]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_OPER_operador]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_OSSD_objeto_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_OSSD_objeto_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PASO_processo_associado]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PASO_processo_associado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PASO_processo_associado]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PAUX_processo_auxiliar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PAUX_processo_auxiliar]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PCON_processo_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PCON_processo_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PDOC_processo_documento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PDOC_processo_documento]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PGER_parametro_geral]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PGER_parametro_geral]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PINF_processo_info]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PINF_processo_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PINF_processo_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PMUN_processo_municipio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PMUN_processo_municipio]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PNOT_processo_nota]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PNOT_processo_nota]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PORG_processo_orgao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PORG_processo_orgao]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRAL_processo_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PRAL_processo_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRAN_processo_andamento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PRAN_processo_andamento]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PREV_processo_evento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PREV_processo_evento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PREV_processo_evento]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRMP_processo_mprima]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PRMP_processo_mprima]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PROC_processo]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PROC_processo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PROC_processo]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PROD_produto]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PROD_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PROD_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PROP_processo_operador]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PROP_processo_operador]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PROP_processo_operador]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRPD_processo_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PRPD_processo_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRSD_processo_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PRSD_processo_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PSUB_processo_substancia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PSUB_processo_substancia]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PTIT_processo_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_PTIT_processo_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_ROTI_rotina]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_ROTI_rotina]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_ROTI_rotina]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SCON_situacao_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_SCON_situacao_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SINF_situacao_info]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SINF_situacao_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_SINF_situacao_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SISD_situacao_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_SISD_situacao_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SITU_situacao_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_SITU_situacao_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SUBS_substancia]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SUBS_substancia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_SUBS_substancia]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_TABE_tabela]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_TABE_tabela]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_TABE_tabela]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_TINF_tipo_info]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_TINF_tipo_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_TINF_tipo_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_TTIT_tipo_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_TTIT_tipo_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_TUSO_tipo_uso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_TUSO_tipo_uso]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_UNFE_unidade_federativa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_UNFE_unidade_federativa]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_UNME_unidade_medida]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_UNME_unidade_medida]
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_UPRD_uso_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_ins_tb_UPRD_uso_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_documentos_relatorio]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_documentos_relatorio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_documentos_relatorio]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_eventos]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_eventos]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_eventos]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ALER_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_ALER_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ALER_alerta_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_ALER_alerta_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_AVEN_alerta_vencimento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_AVEN_alerta_vencimento]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_BACK_backup]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_BACK_backup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_BACK_backup]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COND_condicao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COND_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_COND_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COVE_controle_vencimento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_COVE_controle_vencimento]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_EMPR_empresa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_distinct]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_EMPR_empresa_distinct]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_distinct]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_FASE_fase]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_FASE_fase]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_HSAL_historico_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_LESI_log_erro_sistema]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MPRI_mprima]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MPRI_mprima]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_MPRI_mprima]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MUNI_municipio]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MUNI_municipio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_MUNI_municipio]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OPER_operador]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_OPER_operador]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OSSD_objeto_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_OSSD_objeto_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PASO_processo_associado]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PASO_processo_associado]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PASO_processo_associado]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PAUX_processo_auxiliar]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PAUX_processo_auxiliar]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PCON_processo_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PCON_processo_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PDOC_processo_documento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PDOC_processo_documento]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PGER_parametro_geral]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PINF_processo_info]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PINF_processo_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PINF_processo_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PMUN_processo_municipio]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PMUN_processo_municipio]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PNOT_processo_nota]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PNOT_processo_nota]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PORG_processo_orgao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PORG_processo_orgao]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAL_processo_alerta]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAN_processo_andamento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRAN_processo_andamento]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PREV_processo_evento]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRMP_processo_mprima]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRMP_processo_mprima]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_documents]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo_documents]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROC_processo_documents]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_lista]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo_lista]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROC_processo_lista]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROC_processo_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROD_produto]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROD_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROD_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROC_processo]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROP_processo_operador]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRPD_processo_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRPD_processo_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRSD_processo_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRSD_processo_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PSUB_processo_substancia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PSUB_processo_substancia]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PTIT_processo_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PTIT_processo_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ROTI_rotina]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SCON_situacao_condicao]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SCON_situacao_condicao]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SINF_situacao_info]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SINF_situacao_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SINF_situacao_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SISD_situacao_sd]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SISD_situacao_sd]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SITU_situacao_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SITU_situacao_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SUBS_substancia]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SUBS_substancia]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SUBS_substancia]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TABE_tabela]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TABE_tabela]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TABE_tabela]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TINF_tipo_info]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TINF_tipo_info]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TINF_tipo_info]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TTIT_tipo_titulo]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TTIT_tipo_titulo]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TUSO_tipo_uso]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TUSO_tipo_uso]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNFE_unidade_federativa]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNME_unidade_medida]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UNME_unidade_medida]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UPRD_uso_produto]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UPRD_uso_produto]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UPRD_uso_produto_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UPRD_uso_produto_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UPRD_uso_produto_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UPRD_uso_produto_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UPRD_uso_produto_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UPRD_uso_produto_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNME_unidade_medida_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNME_unidade_medida_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UNME_unidade_medida_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNME_unidade_medida_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNME_unidade_medida_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UNME_unidade_medida_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNFE_unidade_federativa_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TUSO_tipo_uso_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TUSO_tipo_uso_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TUSO_tipo_uso_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TUSO_tipo_uso_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TUSO_tipo_uso_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TUSO_tipo_uso_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TTIT_tipo_titulo_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TTIT_tipo_titulo_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TTIT_tipo_titulo_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TTIT_tipo_titulo_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TTIT_tipo_titulo_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TTIT_tipo_titulo_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TINF_tipo_info_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TINF_tipo_info_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TINF_tipo_info_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TINF_tipo_info_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TINF_tipo_info_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TINF_tipo_info_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TABE_tabela_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TABE_tabela_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TABE_tabela_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TABE_tabela_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TABE_tabela_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_TABE_tabela_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SUBS_substancia_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SUBS_substancia_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SUBS_substancia_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SUBS_substancia_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SUBS_substancia_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SUBS_substancia_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SITU_situacao_titulo_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SITU_situacao_titulo_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SITU_situacao_titulo_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SITU_situacao_titulo_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SITU_situacao_titulo_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SITU_situacao_titulo_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SISD_situacao_sd_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SISD_situacao_sd_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SISD_situacao_sd_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SISD_situacao_sd_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SISD_situacao_sd_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SISD_situacao_sd_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SINF_situacao_info_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SINF_situacao_info_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SINF_situacao_info_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SINF_situacao_info_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SINF_situacao_info_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SINF_situacao_info_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SCON_situacao_condicao_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SCON_situacao_condicao_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SCON_situacao_condicao_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SCON_situacao_condicao_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SCON_situacao_condicao_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_SCON_situacao_condicao_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ROTI_rotina_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ROTI_rotina_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PTIT_processo_titulo_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PTIT_processo_titulo_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PTIT_processo_titulo_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PTIT_processo_titulo_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PTIT_processo_titulo_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PTIT_processo_titulo_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PSUB_processo_substancia_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PSUB_processo_substancia_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PSUB_processo_substancia_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PSUB_processo_substancia_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PSUB_processo_substancia_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PSUB_processo_substancia_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRSD_processo_sd_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRSD_processo_sd_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRSD_processo_sd_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRSD_processo_sd_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRSD_processo_sd_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRSD_processo_sd_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRPD_processo_produto_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRPD_processo_produto_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRPD_processo_produto_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRPD_processo_produto_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRPD_processo_produto_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRPD_processo_produto_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROP_processo_operador_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROP_processo_operador_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROC_processo_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROD_produto_cons]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROD_produto_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROD_produto_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROD_produto_rel]    Script Date: 03/25/2018 20:38:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROD_produto_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PROD_produto_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRMP_processo_mprima_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRMP_processo_mprima_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRMP_processo_mprima_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRMP_processo_mprima_produto_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRMP_processo_mprima_produto_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRMP_processo_mprima_produto_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRMP_processo_mprima_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRMP_processo_mprima_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRMP_processo_mprima_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PREV_processo_evento_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PREV_processo_evento_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAN_processo_andamento_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAN_processo_andamento_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRAN_processo_andamento_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAN_processo_andamento_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAN_processo_andamento_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRAN_processo_andamento_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAL_processo_alerta_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAL_processo_alerta_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PORG_processo_orgao_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PORG_processo_orgao_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PORG_processo_orgao_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PORG_processo_orgao_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PORG_processo_orgao_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PORG_processo_orgao_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PNOT_processo_nota_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PNOT_processo_nota_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PNOT_processo_nota_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PNOT_processo_nota_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PNOT_processo_nota_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PNOT_processo_nota_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PMUN_processo_municipio_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PMUN_processo_municipio_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PMUN_processo_municipio_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PMUN_processo_municipio_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PMUN_processo_municipio_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PMUN_processo_municipio_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PINF_processo_info_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PINF_processo_info_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PINF_processo_info_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PINF_processo_info_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PINF_processo_info_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PINF_processo_info_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PGER_parametro_geral_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PGER_parametro_geral_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PDOC_processo_documento_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PDOC_processo_documento_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PDOC_processo_documento_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PDOC_processo_documento_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PDOC_processo_documento_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PDOC_processo_documento_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PCON_processo_condicao_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PCON_processo_condicao_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PCON_processo_condicao_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PCON_processo_condicao_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PCON_processo_condicao_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PCON_processo_condicao_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PAUX_processo_auxiliar_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PAUX_processo_auxiliar_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PAUX_processo_auxiliar_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PAUX_processo_auxiliar_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PAUX_processo_auxiliar_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PAUX_processo_auxiliar_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PASO_processo_associado_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PASO_processo_associado_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PASO_processo_associado_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PASO_processo_associado_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PASO_processo_associado_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_PASO_processo_associado_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OSSD_objeto_sd_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OSSD_objeto_sd_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_OSSD_objeto_sd_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OSSD_objeto_sd_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OSSD_objeto_sd_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_OSSD_objeto_sd_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OPER_operador_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_OPER_operador_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OPER_operador_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_OPER_operador_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MUNI_municipio_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MUNI_municipio_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_MUNI_municipio_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MUNI_municipio_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MUNI_municipio_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_MUNI_municipio_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MPRI_mprima_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MPRI_mprima_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_MPRI_mprima_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MPRI_mprima_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MPRI_mprima_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_MPRI_mprima_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_LESI_log_erro_sistema_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_HSAL_historico_alerta_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_HSAL_historico_alerta_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_FASE_fase_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_FASE_fase_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_FASE_fase_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_FASE_fase_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_EMPR_empresa_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_EMPR_empresa_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COVE_controle_vencimento_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COVE_controle_vencimento_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_COVE_controle_vencimento_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COVE_controle_vencimento_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COVE_controle_vencimento_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_COVE_controle_vencimento_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COND_condicao_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COND_condicao_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_COND_condicao_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COND_condicao_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COND_condicao_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_COND_condicao_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_BACK_backup_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_BACK_backup_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_BACK_backup_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_BACK_backup_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_BACK_backup_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_BACK_backup_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_AVEN_alerta_vencimento_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_AVEN_alerta_vencimento_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_AVEN_alerta_vencimento_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_AVEN_alerta_vencimento_rel]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_AVEN_alerta_vencimento_rel]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_AVEN_alerta_vencimento_rel]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta_cons]    Script Date: 03/25/2018 20:38:47 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ALER_alerta_cons]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[sp_sel_tb_ALER_alerta_cons]
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ALER_alerta_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_ALER_alerta_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  ALER_nm_alerta varchar(50) not null, 
ALER_ds_alerta varchar(300) null, 
ALER_fl_muda_fase char(1) not null, 
ALER_fl_muda_evento char(1) not null, 
ALER_cd_fase_anterior int null, 
ALER_cd_fase_nova int null, 
ALER_fl_qualquer_processo char(1) not null, 
ALER_fl_status char(1) not null, 
ALER_fl_sistema char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
ALER_ds_status varchar(3) NULL, 
ALER_ds_sistema varchar(3) NULL, 
ALER_ds_muda_fase varchar(3) NULL, 
ALER_ds_muda_evento varchar(3) NULL, 
ALER_ds_qualquer_processo varchar(3) NULL, 
ALER_nm_fase_anterior varchar(100) NULL, 
ALER_ds_fase_nova varchar(100) NULL,
ALER_fl_geral char(1) NULL,
ALER_cd_evento varchar(5) null,
ALER_fl_andamento char(1) null,
ALER_fl_acao char(1) null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.ALER_nm_alerta as ALER_nm_alerta, 
A.ALER_ds_alerta as ALER_ds_alerta, 
A.ALER_fl_muda_fase as ALER_fl_muda_fase, 
A.ALER_fl_muda_evento as ALER_fl_muda_evento, 
A.ALER_cd_fase_anterior as ALER_cd_fase_anterior, 
A.ALER_cd_fase_nova as ALER_cd_fase_nova, 
A.ALER_fl_qualquer_processo as ALER_fl_qualquer_processo, 
A.ALER_fl_status as ALER_fl_status, 
A.ALER_fl_sistema as ALER_fl_sistema, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
A.ALER_fl_geral as ALER_fl_geral,

(select case when ALER_fl_status = ''''S'''' then ''''Sim'''' else ''''Não'''' end) as ALER_ds_status, 

(select case when ALER_fl_sistema = ''''S'''' then ''''Sim'''' else ''''Não'''' end) as ALER_ds_sistema, 

(select case when ALER_fl_muda_fase = ''''S'''' then ''''Sim'''' else ''''Não'''' end) as ALER_ds_muda_fase, 

(select case when ALER_fl_muda_evento = ''''S'''' then ''''Sim'''' else ''''Não'''' end) as ALER_ds_muda_evento, 

(select case when ALER_fl_qualquer_processo = ''''S'''' then ''''Sim'''' else ''''Não'''' end) as ALER_ds_qualquer_processo, 

(select FASE_nm_fase from tb_FASE_fase x where a.ALER_cd_fase_anterior = x.FASE_cd_fase) as ALER_nm_fase_anterior, 

(select FASE_nm_fase from tb_FASE_fase x where a.ALER_cd_fase_nova = x.FASE_cd_fase) as ALER_ds_fase_nova,

A.ALER_cd_evento as ALER_cd_evento,

A.ALER_fl_andamento as ALER_fl_andamento, 
A.ALER_fl_acao as ALER_fl_acao '' 

+ '' from 

DBDNPM..tb_ALER_alerta A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_AVEN_alerta_vencimento_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_AVEN_alerta_vencimento_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_AVEN_alerta_vencimento
CREATE PROCEDURE [dbo].[sp_sel_tb_AVEN_alerta_vencimento_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@AVEN_nm_tipo_documento varchar(40) = null , 
@AVEN_id_documento varchar(20) = null , 
@AVEN_fl_conta_alerta int = null , 
@AVEN_dt_ultimo_alerta datetime = null , 
@AVEN_fl_ultimo_envio char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_AVEN_alerta_vencimento table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
AVEN_nm_tipo_documento varchar(40) not null, 
AVEN_id_documento varchar(20) not null, 
AVEN_fl_conta_alerta int not null, 
AVEN_dt_ultimo_alerta datetime not null, 
AVEN_fl_ultimo_envio char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_AVEN_alerta_vencimento
(PROC_cd_processo, 
ORGA_nm_orgao, 
AVEN_nm_tipo_documento, 
AVEN_id_documento, 
AVEN_fl_conta_alerta, 
AVEN_dt_ultimo_alerta, 
AVEN_fl_ultimo_envio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.AVEN_nm_tipo_documento as AVEN_nm_tipo_documento, 
A.AVEN_id_documento as AVEN_id_documento, 
A.AVEN_fl_conta_alerta as AVEN_fl_conta_alerta, 
A.AVEN_dt_ultimo_alerta as AVEN_dt_ultimo_alerta, 
A.AVEN_fl_ultimo_envio as AVEN_fl_ultimo_envio, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_AVEN_alerta_vencimento A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@AVEN_nm_tipo_documento is null or (@AVEN_nm_tipo_documento is not null and A.AVEN_nm_tipo_documento = @AVEN_nm_tipo_documento)) 
 AND (@AVEN_id_documento is null or (@AVEN_id_documento is not null and A.AVEN_id_documento = @AVEN_id_documento)) 
 AND (@AVEN_fl_conta_alerta is null or (@AVEN_fl_conta_alerta is not null and A.AVEN_fl_conta_alerta = @AVEN_fl_conta_alerta)) 
 AND (@AVEN_dt_ultimo_alerta is null or (@AVEN_dt_ultimo_alerta is not null and A.AVEN_dt_ultimo_alerta = @AVEN_dt_ultimo_alerta)) 
 AND (@AVEN_fl_ultimo_envio is null or (@AVEN_fl_ultimo_envio is not null and A.AVEN_fl_ultimo_envio = @AVEN_fl_ultimo_envio)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AVEN_nm_tipo_documento'' and rtrim(ltrim(A.AVEN_nm_tipo_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AVEN_id_documento'' and rtrim(ltrim(A.AVEN_id_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AVEN_fl_conta_alerta'' and rtrim(ltrim(A.AVEN_fl_conta_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AVEN_dt_ultimo_alerta'' and rtrim(ltrim(A.AVEN_dt_ultimo_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AVEN_fl_ultimo_envio'' and rtrim(ltrim(A.AVEN_fl_ultimo_envio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''AVEN_nm_tipo_documento'' and  @sortOrder=''ASC'' then A.AVEN_nm_tipo_documento END ASC, 
 CASE when @sortField = ''AVEN_nm_tipo_documento'' and  @sortOrder=''DESC'' then A.AVEN_nm_tipo_documento END DESC 
 ,  CASE when @sortField = ''AVEN_id_documento'' and  @sortOrder=''ASC'' then A.AVEN_id_documento END ASC, 
 CASE when @sortField = ''AVEN_id_documento'' and  @sortOrder=''DESC'' then A.AVEN_id_documento END DESC 
 ,  CASE when @sortField = ''AVEN_fl_conta_alerta'' and  @sortOrder=''ASC'' then A.AVEN_fl_conta_alerta END ASC, 
 CASE when @sortField = ''AVEN_fl_conta_alerta'' and  @sortOrder=''DESC'' then A.AVEN_fl_conta_alerta END DESC 
 ,  CASE when @sortField = ''AVEN_dt_ultimo_alerta'' and  @sortOrder=''ASC'' then A.AVEN_dt_ultimo_alerta END ASC, 
 CASE when @sortField = ''AVEN_dt_ultimo_alerta'' and  @sortOrder=''DESC'' then A.AVEN_dt_ultimo_alerta END DESC 
 ,  CASE when @sortField = ''AVEN_fl_ultimo_envio'' and  @sortOrder=''ASC'' then A.AVEN_fl_ultimo_envio END ASC, 
 CASE when @sortField = ''AVEN_fl_ultimo_envio'' and  @sortOrder=''DESC'' then A.AVEN_fl_ultimo_envio END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_AVEN_alerta_vencimento where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_AVEN_alerta_vencimento_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_AVEN_alerta_vencimento_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_AVEN_alerta_vencimento
CREATE PROCEDURE [dbo].[sp_sel_tb_AVEN_alerta_vencimento_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
AVEN_nm_tipo_documento varchar(10) not null, 
AVEN_id_documento varchar(20) not null, 
AVEN_fl_conta_alerta int not null, 
AVEN_dt_ultimo_alerta datetime not null, 
AVEN_fl_ultimo_envio char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.AVEN_nm_tipo_documento as AVEN_nm_tipo_documento, 
A.AVEN_id_documento as AVEN_id_documento, 
A.AVEN_fl_conta_alerta as AVEN_fl_conta_alerta, 
A.AVEN_dt_ultimo_alerta as AVEN_dt_ultimo_alerta, 
A.AVEN_fl_ultimo_envio as AVEN_fl_ultimo_envio, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_AVEN_alerta_vencimento A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_BACK_backup_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_BACK_backup_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_BACK_backup
CREATE PROCEDURE [dbo].[sp_sel_tb_BACK_backup_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@BACK_cd_backup int = null , 
@BACK_vl_intervalo int = null , 
@BACK_nm_arquivo varchar(30) = null , 
@BACK_fl_execucao char(1) = null , 
@BACK_ds_mensagem varchar(500) = null , 
@BACK_dt_execucao datetime = null , 
@BACK_dt_tentativa_Execucao datetime = null , 
@BACK_dt_backup datetime = null , 
@BACK_dt_sincronizacao datetime = null , 
@BACK_fl_tipo char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_BACK_backup table (
id int identity primary key, 
BACK_cd_backup int not null, 
BACK_vl_intervalo int not null, 
BACK_nm_arquivo varchar(30) null, 
BACK_fl_execucao char(1) null, 
BACK_ds_mensagem varchar(500) null, 
BACK_dt_execucao datetime null, 
BACK_dt_tentativa_Execucao datetime null, 
BACK_dt_backup datetime not null, 
BACK_dt_sincronizacao datetime null, 
BACK_fl_tipo char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_BACK_backup
(BACK_cd_backup, 
BACK_vl_intervalo, 
BACK_nm_arquivo, 
BACK_fl_execucao, 
BACK_ds_mensagem, 
BACK_dt_execucao, 
BACK_dt_tentativa_Execucao, 
BACK_dt_backup, 
BACK_dt_sincronizacao, 
BACK_fl_tipo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.BACK_cd_backup as BACK_cd_backup, 
A.BACK_vl_intervalo as BACK_vl_intervalo, 
A.BACK_nm_arquivo as BACK_nm_arquivo, 
A.BACK_fl_execucao as BACK_fl_execucao, 
A.BACK_ds_mensagem as BACK_ds_mensagem, 
A.BACK_dt_execucao as BACK_dt_execucao, 
A.BACK_dt_tentativa_Execucao as BACK_dt_tentativa_Execucao, 
A.BACK_dt_backup as BACK_dt_backup, 
A.BACK_dt_sincronizacao as BACK_dt_sincronizacao, 
A.BACK_fl_tipo as BACK_fl_tipo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_BACK_backup A

WHERE 




(@BACK_cd_backup is null or (@BACK_cd_backup is not null and A.BACK_cd_backup = @BACK_cd_backup)) 
 AND (@BACK_vl_intervalo is null or (@BACK_vl_intervalo is not null and A.BACK_vl_intervalo = @BACK_vl_intervalo)) 
 AND (@BACK_nm_arquivo is null or (@BACK_nm_arquivo is not null and A.BACK_nm_arquivo = @BACK_nm_arquivo)) 
 AND (@BACK_fl_execucao is null or (@BACK_fl_execucao is not null and A.BACK_fl_execucao = @BACK_fl_execucao)) 
 AND (@BACK_ds_mensagem is null or (@BACK_ds_mensagem is not null and A.BACK_ds_mensagem = @BACK_ds_mensagem)) 
 AND (@BACK_dt_execucao is null or (@BACK_dt_execucao is not null and A.BACK_dt_execucao = @BACK_dt_execucao)) 
 AND (@BACK_dt_tentativa_Execucao is null or (@BACK_dt_tentativa_Execucao is not null and A.BACK_dt_tentativa_Execucao = @BACK_dt_tentativa_Execucao)) 
 AND (@BACK_dt_backup is null or (@BACK_dt_backup is not null and A.BACK_dt_backup = @BACK_dt_backup)) 
 AND (@BACK_dt_sincronizacao is null or (@BACK_dt_sincronizacao is not null and A.BACK_dt_sincronizacao = @BACK_dt_sincronizacao)) 
 AND (@BACK_fl_tipo is null or (@BACK_fl_tipo is not null and A.BACK_fl_tipo = @BACK_fl_tipo)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''BACK_cd_backup'' and rtrim(ltrim(A.BACK_cd_backup)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_vl_intervalo'' and rtrim(ltrim(A.BACK_vl_intervalo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_nm_arquivo'' and rtrim(ltrim(A.BACK_nm_arquivo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_fl_execucao'' and rtrim(ltrim(A.BACK_fl_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_ds_mensagem'' and rtrim(ltrim(A.BACK_ds_mensagem)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_dt_execucao'' and rtrim(ltrim(A.BACK_dt_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_dt_tentativa_Execucao'' and rtrim(ltrim(A.BACK_dt_tentativa_Execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_dt_backup'' and rtrim(ltrim(A.BACK_dt_backup)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_dt_sincronizacao'' and rtrim(ltrim(A.BACK_dt_sincronizacao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''BACK_fl_tipo'' and rtrim(ltrim(A.BACK_fl_tipo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''BACK_cd_backup'' and  @sortOrder=''ASC'' then A.BACK_cd_backup END ASC, 
 CASE when @sortField = ''BACK_cd_backup'' and  @sortOrder=''DESC'' then A.BACK_cd_backup END DESC 
 ,  CASE when @sortField = ''BACK_vl_intervalo'' and  @sortOrder=''ASC'' then A.BACK_vl_intervalo END ASC, 
 CASE when @sortField = ''BACK_vl_intervalo'' and  @sortOrder=''DESC'' then A.BACK_vl_intervalo END DESC 
 ,  CASE when @sortField = ''BACK_nm_arquivo'' and  @sortOrder=''ASC'' then A.BACK_nm_arquivo END ASC, 
 CASE when @sortField = ''BACK_nm_arquivo'' and  @sortOrder=''DESC'' then A.BACK_nm_arquivo END DESC 
 ,  CASE when @sortField = ''BACK_fl_execucao'' and  @sortOrder=''ASC'' then A.BACK_fl_execucao END ASC, 
 CASE when @sortField = ''BACK_fl_execucao'' and  @sortOrder=''DESC'' then A.BACK_fl_execucao END DESC 
 ,  CASE when @sortField = ''BACK_ds_mensagem'' and  @sortOrder=''ASC'' then A.BACK_ds_mensagem END ASC, 
 CASE when @sortField = ''BACK_ds_mensagem'' and  @sortOrder=''DESC'' then A.BACK_ds_mensagem END DESC 
 ,  CASE when @sortField = ''BACK_dt_execucao'' and  @sortOrder=''ASC'' then A.BACK_dt_execucao END ASC, 
 CASE when @sortField = ''BACK_dt_execucao'' and  @sortOrder=''DESC'' then A.BACK_dt_execucao END DESC 
 ,  CASE when @sortField = ''BACK_dt_tentativa_Execucao'' and  @sortOrder=''ASC'' then A.BACK_dt_tentativa_Execucao END ASC, 
 CASE when @sortField = ''BACK_dt_tentativa_Execucao'' and  @sortOrder=''DESC'' then A.BACK_dt_tentativa_Execucao END DESC 
 ,  CASE when @sortField = ''BACK_dt_backup'' and  @sortOrder=''ASC'' then A.BACK_dt_backup END ASC, 
 CASE when @sortField = ''BACK_dt_backup'' and  @sortOrder=''DESC'' then A.BACK_dt_backup END DESC 
 ,  CASE when @sortField = ''BACK_dt_sincronizacao'' and  @sortOrder=''ASC'' then A.BACK_dt_sincronizacao END ASC, 
 CASE when @sortField = ''BACK_dt_sincronizacao'' and  @sortOrder=''DESC'' then A.BACK_dt_sincronizacao END DESC 
 ,  CASE when @sortField = ''BACK_fl_tipo'' and  @sortOrder=''ASC'' then A.BACK_fl_tipo END ASC, 
 CASE when @sortField = ''BACK_fl_tipo'' and  @sortOrder=''DESC'' then A.BACK_fl_tipo END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_BACK_backup where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_BACK_backup_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_BACK_backup_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_BACK_backup
CREATE PROCEDURE [dbo].[sp_sel_tb_BACK_backup_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  BACK_cd_backup int not null, 
BACK_vl_intervalo int not null, 
BACK_nm_arquivo varchar(30) null, 
BACK_fl_execucao char(1) null, 
BACK_ds_mensagem varchar(500) null, 
BACK_dt_execucao datetime null, 
BACK_dt_tentativa_Execucao datetime null, 
BACK_dt_backup datetime not null, 
BACK_dt_sincronizacao datetime null, 
BACK_fl_tipo char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.BACK_cd_backup as BACK_cd_backup, 
A.BACK_vl_intervalo as BACK_vl_intervalo, 
A.BACK_nm_arquivo as BACK_nm_arquivo, 
A.BACK_fl_execucao as BACK_fl_execucao, 
A.BACK_ds_mensagem as BACK_ds_mensagem, 
A.BACK_dt_execucao as BACK_dt_execucao, 
A.BACK_dt_tentativa_Execucao as BACK_dt_tentativa_Execucao, 
A.BACK_dt_backup as BACK_dt_backup, 
A.BACK_dt_sincronizacao as BACK_dt_sincronizacao, 
A.BACK_fl_tipo as BACK_fl_tipo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_BACK_backup A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COND_condicao_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COND_condicao_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_COND_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_COND_condicao_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@COND_nm_condicao varchar(500) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_COND_condicao table (
id int identity primary key, 
COND_nm_condicao varchar(500) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_COND_condicao
(COND_nm_condicao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.COND_nm_condicao as COND_nm_condicao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_COND_condicao A

WHERE 




(@COND_nm_condicao is null or (@COND_nm_condicao is not null and A.COND_nm_condicao = @COND_nm_condicao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''COND_nm_condicao'' and rtrim(ltrim(A.COND_nm_condicao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''COND_nm_condicao'' and  @sortOrder=''ASC'' then A.COND_nm_condicao END ASC, 
 CASE when @sortField = ''COND_nm_condicao'' and  @sortOrder=''DESC'' then A.COND_nm_condicao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_COND_condicao where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COND_condicao_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COND_condicao_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_COND_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_COND_condicao_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  COND_nm_condicao varchar(500) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.COND_nm_condicao as COND_nm_condicao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_COND_condicao A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COVE_controle_vencimento_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COVE_controle_vencimento_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_COVE_controle_vencimento
CREATE PROCEDURE [dbo].[sp_sel_tb_COVE_controle_vencimento_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@COVE_nm_tipo_documento varchar(10) = null , 
@COVE_id_documento varchar(20) = null , 
@COVE_qt_inicio int = null , 
@COVE_qt_intervalo int = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_COVE_controle_vencimento table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
COVE_nm_tipo_documento varchar(10) not null, 
COVE_id_documento varchar(20) not null, 
COVE_qt_inicio int not null, 
COVE_qt_intervalo int not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_COVE_controle_vencimento
(PROC_cd_processo, 
ORGA_nm_orgao, 
COVE_nm_tipo_documento, 
COVE_id_documento, 
COVE_qt_inicio, 
COVE_qt_intervalo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.COVE_nm_tipo_documento as COVE_nm_tipo_documento, 
A.COVE_id_documento as COVE_id_documento, 
A.COVE_qt_inicio as COVE_qt_inicio, 
A.COVE_qt_intervalo as COVE_qt_intervalo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_COVE_controle_vencimento A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@COVE_nm_tipo_documento is null or (@COVE_nm_tipo_documento is not null and A.COVE_nm_tipo_documento = @COVE_nm_tipo_documento)) 
 AND (@COVE_id_documento is null or (@COVE_id_documento is not null and A.COVE_id_documento = @COVE_id_documento)) 
 AND (@COVE_qt_inicio is null or (@COVE_qt_inicio is not null and A.COVE_qt_inicio = @COVE_qt_inicio)) 
 AND (@COVE_qt_intervalo is null or (@COVE_qt_intervalo is not null and A.COVE_qt_intervalo = @COVE_qt_intervalo)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''COVE_nm_tipo_documento'' and rtrim(ltrim(A.COVE_nm_tipo_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''COVE_id_documento'' and rtrim(ltrim(A.COVE_id_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''COVE_qt_inicio'' and rtrim(ltrim(A.COVE_qt_inicio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''COVE_qt_intervalo'' and rtrim(ltrim(A.COVE_qt_intervalo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''COVE_nm_tipo_documento'' and  @sortOrder=''ASC'' then A.COVE_nm_tipo_documento END ASC, 
 CASE when @sortField = ''COVE_nm_tipo_documento'' and  @sortOrder=''DESC'' then A.COVE_nm_tipo_documento END DESC 
 ,  CASE when @sortField = ''COVE_id_documento'' and  @sortOrder=''ASC'' then A.COVE_id_documento END ASC, 
 CASE when @sortField = ''COVE_id_documento'' and  @sortOrder=''DESC'' then A.COVE_id_documento END DESC 
 ,  CASE when @sortField = ''COVE_qt_inicio'' and  @sortOrder=''ASC'' then A.COVE_qt_inicio END ASC, 
 CASE when @sortField = ''COVE_qt_inicio'' and  @sortOrder=''DESC'' then A.COVE_qt_inicio END DESC 
 ,  CASE when @sortField = ''COVE_qt_intervalo'' and  @sortOrder=''ASC'' then A.COVE_qt_intervalo END ASC, 
 CASE when @sortField = ''COVE_qt_intervalo'' and  @sortOrder=''DESC'' then A.COVE_qt_intervalo END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_COVE_controle_vencimento where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COVE_controle_vencimento_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COVE_controle_vencimento_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_COVE_controle_vencimento
CREATE PROCEDURE [dbo].[sp_sel_tb_COVE_controle_vencimento_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
COVE_nm_tipo_documento varchar(10) not null, 
COVE_id_documento varchar(20) not null, 
COVE_qt_inicio int not null, 
COVE_qt_intervalo int not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.COVE_nm_tipo_documento as COVE_nm_tipo_documento, 
A.COVE_id_documento as COVE_id_documento, 
A.COVE_qt_inicio as COVE_qt_inicio, 
A.COVE_qt_intervalo as COVE_qt_intervalo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_COVE_controle_vencimento A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_EMPR_empresa_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  EMPR_nm_empresa varchar(20) not null, 
EMPR_ds_empresa varchar(300) not null, 
EMPR_fl_status char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
EMPR_ds_status varchar(100) NULL
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.EMPR_nm_empresa as EMPR_nm_empresa, 
A.EMPR_ds_empresa as EMPR_ds_empresa, 
A.EMPR_fl_status as EMPR_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 

(select case when EMPR_fl_status = ''''A'''' then ''''Ativo'''' else ''''Inativo'''' end) as EMPR_ds_status '' 
+ '' from 

DBDNPM..tb_EMPR_empresa A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_EMPR_empresa_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
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
EMPR_ds_dou varchar(500) null,
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
EMPR_ds_dou,
EMPR_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 

EMPR_ds_status) 

SELECT 
A.EMPR_nm_empresa as EMPR_nm_empresa, 
A.EMPR_ds_empresa as EMPR_ds_empresa, 
A.EMPR_ds_dou as EMPR_ds_dou,
A.EMPR_fl_status as EMPR_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 

(select case when EMPR_fl_status = ''A'' then ''Ativo'' else ''Inativo'' end) as EMPR_ds_status

FROM 

DBDNPM..tb_EMPR_empresa A

WHERE 




(@EMPR_nm_empresa is null or (@EMPR_nm_empresa is not null and A.EMPR_nm_empresa = @EMPR_nm_empresa)) 
 AND (@EMPR_ds_empresa is null or (@EMPR_ds_empresa is not null and A.EMPR_ds_empresa = @EMPR_ds_empresa)) 
 AND (@EMPR_fl_status is null or (@EMPR_fl_status is not null and A.EMPR_fl_status = @EMPR_fl_status)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''EMPR_nm_empresa'' and rtrim(ltrim(A.EMPR_nm_empresa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''EMPR_ds_empresa'' and rtrim(ltrim(A.EMPR_ds_empresa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''EMPR_ds_dou'' and rtrim(ltrim(A.EMPR_ds_dou)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''EMPR_fl_status'' and rtrim(ltrim(A.EMPR_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''EMPR_nm_empresa'' and  @sortOrder=''ASC'' then A.EMPR_nm_empresa END ASC, 
 CASE when @sortField = ''EMPR_nm_empresa'' and  @sortOrder=''DESC'' then A.EMPR_nm_empresa END DESC 
 ,  CASE when @sortField = ''EMPR_ds_empresa'' and  @sortOrder=''ASC'' then A.EMPR_ds_empresa END ASC, 
 CASE when @sortField = ''EMPR_ds_empresa'' and  @sortOrder=''DESC'' then A.EMPR_ds_empresa END DESC 
  ,  CASE when @sortField = ''EMPR_ds_dou'' and  @sortOrder=''ASC'' then A.EMPR_ds_dou END ASC, 
 CASE when @sortField = ''EMPR_ds_dou'' and  @sortOrder=''DESC'' then A.EMPR_ds_dou END DESC 
 ,  CASE when @sortField = ''EMPR_fl_status'' and  @sortOrder=''ASC'' then A.EMPR_fl_status END ASC, 
 CASE when @sortField = ''EMPR_fl_status'' and  @sortOrder=''DESC'' then A.EMPR_fl_status END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_EMPR_empresa where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_FASE_fase_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_sel_tb_FASE_fase_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
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

 (@whereField = ''FASE_cd_fase'' and rtrim(ltrim(A.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''FASE_nm_fase'' and rtrim(ltrim(A.FASE_nm_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''ASC'' then A.FASE_cd_fase END ASC, 
 CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''DESC'' then A.FASE_cd_fase END DESC 
 ,  CASE when @sortField = ''FASE_nm_fase'' and  @sortOrder=''ASC'' then A.FASE_nm_fase END ASC, 
 CASE when @sortField = ''FASE_nm_fase'' and  @sortOrder=''DESC'' then A.FASE_nm_fase END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_FASE_fase where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_FASE_fase_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_sel_tb_FASE_fase_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  FASE_cd_fase int not null, 
FASE_nm_fase varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.FASE_cd_fase as FASE_cd_fase, 
A.FASE_nm_fase as FASE_nm_fase, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_FASE_fase A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_HSAL_historico_alerta_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
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

 (@whereField = ''HSAL_id_historico'' and rtrim(ltrim(A.HSAL_id_historico)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''HSAL_ds_email'' and rtrim(ltrim(A.HSAL_ds_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_nm_alerta'' and rtrim(ltrim(A.ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''HSAL_ds_assunto_email'' and rtrim(ltrim(A.HSAL_ds_assunto_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''HSAL_ds_texto_email'' and rtrim(ltrim(A.HSAL_ds_texto_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''HSAL_dt_envio'' and rtrim(ltrim(A.HSAL_dt_envio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''HSAL_dt_tentativa_ultimo_envio'' and rtrim(ltrim(A.HSAL_dt_tentativa_ultimo_envio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''HSAL_ds_mensagem'' and rtrim(ltrim(A.HSAL_ds_mensagem)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''HSAL_fl_status'' and rtrim(ltrim(A.HSAL_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''HSAL_id_historico'' and  @sortOrder=''ASC'' then A.HSAL_id_historico END ASC, 
 CASE when @sortField = ''HSAL_id_historico'' and  @sortOrder=''DESC'' then A.HSAL_id_historico END DESC 
 ,  CASE when @sortField = ''HSAL_ds_email'' and  @sortOrder=''ASC'' then A.HSAL_ds_email END ASC, 
 CASE when @sortField = ''HSAL_ds_email'' and  @sortOrder=''DESC'' then A.HSAL_ds_email END DESC 
 ,  CASE when @sortField = ''ALER_nm_alerta'' and  @sortOrder=''ASC'' then A.ALER_nm_alerta END ASC, 
 CASE when @sortField = ''ALER_nm_alerta'' and  @sortOrder=''DESC'' then A.ALER_nm_alerta END DESC 
 ,  CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''HSAL_ds_assunto_email'' and  @sortOrder=''ASC'' then A.HSAL_ds_assunto_email END ASC, 
 CASE when @sortField = ''HSAL_ds_assunto_email'' and  @sortOrder=''DESC'' then A.HSAL_ds_assunto_email END DESC 
 ,  CASE when @sortField = ''HSAL_ds_texto_email'' and  @sortOrder=''ASC'' then A.HSAL_ds_texto_email END ASC, 
 CASE when @sortField = ''HSAL_ds_texto_email'' and  @sortOrder=''DESC'' then A.HSAL_ds_texto_email END DESC 
 ,  CASE when @sortField = ''HSAL_dt_envio'' and  @sortOrder=''ASC'' then A.HSAL_dt_envio END ASC, 
 CASE when @sortField = ''HSAL_dt_envio'' and  @sortOrder=''DESC'' then A.HSAL_dt_envio END DESC 
 ,  CASE when @sortField = ''HSAL_dt_tentativa_ultimo_envio'' and  @sortOrder=''ASC'' then A.HSAL_dt_tentativa_ultimo_envio END ASC, 
 CASE when @sortField = ''HSAL_dt_tentativa_ultimo_envio'' and  @sortOrder=''DESC'' then A.HSAL_dt_tentativa_ultimo_envio END DESC 
 ,  CASE when @sortField = ''HSAL_ds_mensagem'' and  @sortOrder=''ASC'' then A.HSAL_ds_mensagem END ASC, 
 CASE when @sortField = ''HSAL_ds_mensagem'' and  @sortOrder=''DESC'' then A.HSAL_ds_mensagem END DESC 
 ,  CASE when @sortField = ''HSAL_fl_status'' and  @sortOrder=''ASC'' then A.HSAL_fl_status END ASC, 
 CASE when @sortField = ''HSAL_fl_status'' and  @sortOrder=''DESC'' then A.HSAL_fl_status END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 

 
SELECT * FROM 
@tb_HSAL_historico_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_HSAL_historico_alerta_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
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


SET @sql = 
''insert into 
#Temporary_Table 
select  
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
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao '' 
+ '' from 

DBDNPM..tb_HSAL_historico_alerta A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_LESI_log_erro_sistema_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@LESI_cd_ocorrencia bigint = null , 
@LESI_nm_source varchar(100) = null , 
@LESI_dt_ocorrencia datetime = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_LESI_log_erro_sistema table (
id int identity primary key, 
LESI_cd_ocorrencia bigint not null, 
LESI_nm_source varchar(100) not null, 
LESI_ds_exception varchar(8000) null, 
LESI_ds_inexception varchar(8000) null, 
LESI_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null
)



insert into 
@tb_LESI_log_erro_sistema
(LESI_cd_ocorrencia, 
LESI_nm_source, 
LESI_ds_exception, 
LESI_ds_inexception, 
LESI_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao) 

SELECT 
A.LESI_cd_ocorrencia as LESI_cd_ocorrencia, 
A.LESI_nm_source as LESI_nm_source, 
A.LESI_ds_exception as LESI_ds_exception, 
A.LESI_ds_inexception as LESI_ds_inexception, 
A.LESI_dt_ocorrencia as LESI_dt_ocorrencia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao

FROM 

DBDNPM..tb_LESI_log_erro_sistema A

WHERE 




(@LESI_cd_ocorrencia is null or (@LESI_cd_ocorrencia is not null and A.LESI_cd_ocorrencia = @LESI_cd_ocorrencia)) 
 AND (@LESI_nm_source is null or (@LESI_nm_source is not null and A.LESI_nm_source = @LESI_nm_source)) 
 AND (@LESI_dt_ocorrencia is null or (@LESI_dt_ocorrencia is not null and A.LESI_dt_ocorrencia = @LESI_dt_ocorrencia)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''LESI_cd_ocorrencia'' and rtrim(ltrim(A.LESI_cd_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''LESI_nm_source'' and rtrim(ltrim(A.LESI_nm_source)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''LESI_ds_exception'' and rtrim(ltrim(A.LESI_ds_exception)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''LESI_ds_inexception'' and rtrim(ltrim(A.LESI_ds_inexception)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''LESI_dt_ocorrencia'' and rtrim(ltrim(A.LESI_dt_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''LESI_cd_ocorrencia'' and  @sortOrder=''ASC'' then A.LESI_cd_ocorrencia END ASC, 
 CASE when @sortField = ''LESI_cd_ocorrencia'' and  @sortOrder=''DESC'' then A.LESI_cd_ocorrencia END DESC 
 ,  CASE when @sortField = ''LESI_nm_source'' and  @sortOrder=''ASC'' then A.LESI_nm_source END ASC, 
 CASE when @sortField = ''LESI_nm_source'' and  @sortOrder=''DESC'' then A.LESI_nm_source END DESC 
 ,  CASE when @sortField = ''LESI_ds_exception'' and  @sortOrder=''ASC'' then A.LESI_ds_exception END ASC, 
 CASE when @sortField = ''LESI_ds_exception'' and  @sortOrder=''DESC'' then A.LESI_ds_exception END DESC 
 ,  CASE when @sortField = ''LESI_ds_inexception'' and  @sortOrder=''ASC'' then A.LESI_ds_inexception END ASC, 
 CASE when @sortField = ''LESI_ds_inexception'' and  @sortOrder=''DESC'' then A.LESI_ds_inexception END DESC 
 ,  CASE when @sortField = ''LESI_dt_ocorrencia'' and  @sortOrder=''ASC'' then A.LESI_dt_ocorrencia END ASC, 
 CASE when @sortField = ''LESI_dt_ocorrencia'' and  @sortOrder=''DESC'' then A.LESI_dt_ocorrencia END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 

 
SELECT * FROM 
@tb_LESI_log_erro_sistema where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  LESI_cd_ocorrencia bigint not null, 
LESI_nm_source varchar(100) not null, 
LESI_ds_exception varchar(8000) null, 
LESI_ds_inexception varchar(8000) null, 
LESI_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.LESI_cd_ocorrencia as LESI_cd_ocorrencia, 
A.LESI_nm_source as LESI_nm_source, 
A.LESI_ds_exception as LESI_ds_exception, 
A.LESI_ds_inexception as LESI_ds_inexception, 
A.LESI_dt_ocorrencia as LESI_dt_ocorrencia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao '' 
+ '' from 

DBDNPM..tb_LESI_log_erro_sistema A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MPRI_mprima_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MPRI_mprima_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_MPRI_mprima
CREATE PROCEDURE [dbo].[sp_sel_tb_MPRI_mprima_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@MPRI_nm_mprima varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_MPRI_mprima table (
id int identity primary key, 
MPRI_nm_mprima varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_MPRI_mprima
(MPRI_nm_mprima, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.MPRI_nm_mprima as MPRI_nm_mprima, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_MPRI_mprima A

WHERE 




(@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and A.MPRI_nm_mprima = @MPRI_nm_mprima)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''MPRI_nm_mprima'' and rtrim(ltrim(A.MPRI_nm_mprima)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''MPRI_nm_mprima'' and  @sortOrder=''ASC'' then A.MPRI_nm_mprima END ASC, 
 CASE when @sortField = ''MPRI_nm_mprima'' and  @sortOrder=''DESC'' then A.MPRI_nm_mprima END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_MPRI_mprima where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MPRI_mprima_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MPRI_mprima_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_MPRI_mprima
CREATE PROCEDURE [dbo].[sp_sel_tb_MPRI_mprima_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  MPRI_nm_mprima varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.MPRI_nm_mprima as MPRI_nm_mprima, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_MPRI_mprima A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MUNI_municipio_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MUNI_municipio_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_MUNI_municipio
CREATE PROCEDURE [dbo].[sp_sel_tb_MUNI_municipio_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@MUNI_nm_municipio varchar(150) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_MUNI_municipio table (
id int identity primary key, 
MUNI_nm_municipio varchar(150) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_MUNI_municipio
(MUNI_nm_municipio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.MUNI_nm_municipio as MUNI_nm_municipio, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_MUNI_municipio A

WHERE 




(@MUNI_nm_municipio is null or (@MUNI_nm_municipio is not null and A.MUNI_nm_municipio = @MUNI_nm_municipio)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''MUNI_nm_municipio'' and rtrim(ltrim(A.MUNI_nm_municipio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''MUNI_nm_municipio'' and  @sortOrder=''ASC'' then A.MUNI_nm_municipio END ASC, 
 CASE when @sortField = ''MUNI_nm_municipio'' and  @sortOrder=''DESC'' then A.MUNI_nm_municipio END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_MUNI_municipio where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MUNI_municipio_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MUNI_municipio_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_MUNI_municipio
CREATE PROCEDURE [dbo].[sp_sel_tb_MUNI_municipio_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  MUNI_nm_municipio varchar(150) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.MUNI_nm_municipio as MUNI_nm_municipio, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_MUNI_municipio A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OPER_operador_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_OPER_operador_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
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
OPER_ds_alerta varchar(3) NULL,
OPER_ds_alerta_nativo varchar(3) NULL
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

OPER_ds_alerta,
OPER_ds_alerta_nativo) 

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

(select case when OPER_fl_alerta = ''S'' then ''Sim'' else ''Não'' end) as OPER_ds_alerta,
(select case when OPER_fl_alerta_nativo = ''S'' then ''Sim'' else ''Não'' end) as OPER_ds_alerta_nativo

FROM 

DBDNPM..tb_OPER_operador A

WHERE 




(@OPER_cd_operador is null or (@OPER_cd_operador is not null and A.OPER_cd_operador = @OPER_cd_operador)) 
 AND (@OPER_nm_operador is null or (@OPER_nm_operador is not null and A.OPER_nm_operador = @OPER_nm_operador)) 
 AND (@OPER_ds_email is null or (@OPER_ds_email is not null and A.OPER_ds_email = @OPER_ds_email)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''OPER_cd_operador'' and rtrim(ltrim(A.OPER_cd_operador)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''OPER_nm_operador'' and rtrim(ltrim(A.OPER_nm_operador)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''OPER_ds_email'' and rtrim(ltrim(A.OPER_ds_email)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''OPER_fl_alerta'' and rtrim(ltrim(A.OPER_fl_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''OPER_fl_alerta_nativo'' and rtrim(ltrim(A.OPER_fl_alerta_nativo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''OPER_cd_operador'' and  @sortOrder=''ASC'' then A.OPER_cd_operador END ASC, 
 CASE when @sortField = ''OPER_cd_operador'' and  @sortOrder=''DESC'' then A.OPER_cd_operador END DESC 
 ,  CASE when @sortField = ''OPER_nm_operador'' and  @sortOrder=''ASC'' then A.OPER_nm_operador END ASC, 
 CASE when @sortField = ''OPER_nm_operador'' and  @sortOrder=''DESC'' then A.OPER_nm_operador END DESC 
 ,  CASE when @sortField = ''OPER_ds_email'' and  @sortOrder=''ASC'' then A.OPER_ds_email END ASC, 
 CASE when @sortField = ''OPER_ds_email'' and  @sortOrder=''DESC'' then A.OPER_ds_email END DESC 
 ,  CASE when @sortField = ''OPER_fl_alerta'' and  @sortOrder=''ASC'' then A.OPER_fl_alerta END ASC, 
 CASE when @sortField = ''OPER_fl_alerta'' and  @sortOrder=''DESC'' then A.OPER_fl_alerta END DESC 
 ,  CASE when @sortField = ''OPER_fl_alerta_nativo'' and  @sortOrder=''ASC'' then A.OPER_fl_alerta_nativo END ASC, 
 CASE when @sortField = ''OPER_fl_alerta_nativo'' and  @sortOrder=''DESC'' then A.OPER_fl_alerta_nativo END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_OPER_operador where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OPER_operador_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_OPER_operador_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  OPER_cd_operador varchar(20) not null, 
OPER_nm_operador varchar(1000) not null, 
OPER_ds_email varchar(200) not null, 
OPER_fl_alerta char(1) not null, 
OPER_fl_alerta_nativo char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
OPER_ds_alerta varchar(3) NULL,
OPER_ds_alerta_nativo varchar(3) NULL
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.OPER_cd_operador as OPER_cd_operador, 
A.OPER_nm_operador as OPER_nm_operador, 
A.OPER_ds_email as OPER_ds_email, 
A.OPER_fl_alerta as OPER_fl_alerta, 
A.OPER_fl_alerta_nativo as OPER_fl_alerta_nativo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 

(select case when OPER_fl_alerta = ''''S'''' then ''''Sim'''' else ''''Não'''' end) as OPER_ds_alerta, 
(select case when OPER_ds_alerta_nativo = ''''S'''' then ''''Sim'''' else ''''Não'''' end) as OPER_ds_alerta_nativo '' 
+ '' from 

DBDNPM..tb_OPER_operador A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OSSD_objeto_sd_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OSSD_objeto_sd_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_OSSD_objeto_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_OSSD_objeto_sd_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ORGA_nm_orgao varchar(10) = null , 
@OSSD_nm_objeto varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_OSSD_objeto_sd table (
id int identity primary key, 
ORGA_nm_orgao varchar(10) not null, 
OSSD_nm_objeto varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_OSSD_objeto_sd
(ORGA_nm_orgao, 
OSSD_nm_objeto, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.OSSD_nm_objeto as OSSD_nm_objeto, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_OSSD_objeto_sd A

WHERE 




(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@OSSD_nm_objeto is null or (@OSSD_nm_objeto is not null and A.OSSD_nm_objeto = @OSSD_nm_objeto)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''OSSD_nm_objeto'' and rtrim(ltrim(A.OSSD_nm_objeto)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''OSSD_nm_objeto'' and  @sortOrder=''ASC'' then A.OSSD_nm_objeto END ASC, 
 CASE when @sortField = ''OSSD_nm_objeto'' and  @sortOrder=''DESC'' then A.OSSD_nm_objeto END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_OSSD_objeto_sd where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OSSD_objeto_sd_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OSSD_objeto_sd_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_OSSD_objeto_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_OSSD_objeto_sd_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  ORGA_nm_orgao varchar(10) not null, 
OSSD_nm_objeto varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.OSSD_nm_objeto as OSSD_nm_objeto, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_OSSD_objeto_sd A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PASO_processo_associado_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PASO_processo_associado_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PASO_processo_associado
CREATE PROCEDURE [dbo].[sp_sel_tb_PASO_processo_associado_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@PASO_cd_processo varchar(50) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PASO_processo_associado table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
PASO_cd_processo varchar(50) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PASO_processo_associado
(PROC_cd_processo, 
PASO_cd_processo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.PASO_cd_processo as PASO_cd_processo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PASO_processo_associado A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@PASO_cd_processo is null or (@PASO_cd_processo is not null and A.PASO_cd_processo = @PASO_cd_processo)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PASO_cd_processo'' and rtrim(ltrim(A.PASO_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''PASO_cd_processo'' and  @sortOrder=''ASC'' then A.PASO_cd_processo END ASC, 
 CASE when @sortField = ''PASO_cd_processo'' and  @sortOrder=''DESC'' then A.PASO_cd_processo END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PASO_processo_associado where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PASO_processo_associado_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PASO_processo_associado_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PASO_processo_associado
CREATE PROCEDURE [dbo].[sp_sel_tb_PASO_processo_associado_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
PASO_cd_processo varchar(50) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.PASO_cd_processo as PASO_cd_processo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PASO_processo_associado A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PAUX_processo_auxiliar_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PAUX_processo_auxiliar_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PAUX_processo_auxiliar
CREATE PROCEDURE [dbo].[sp_sel_tb_PAUX_processo_auxiliar_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PAUX_cd_processo varchar(50) = null , 
@PAUX_ds_titular varchar(300) = null , 
@FASE_cd_fase int = null , 
@UNFE_cd_unidade_federativa char(2) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PAUX_processo_auxiliar table (
id int identity primary key, 
PAUX_cd_processo varchar(50) not null, 
PAUX_ds_titular varchar(300) not null, 
FASE_cd_fase int null, 
PAUX_ds_ultimo_evento varchar(3000) null, 
UNFE_cd_unidade_federativa char(2) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PAUX_processo_auxiliar
(PAUX_cd_processo, 
PAUX_ds_titular, 
FASE_cd_fase, 
PAUX_ds_ultimo_evento, 
UNFE_cd_unidade_federativa, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PAUX_cd_processo as PAUX_cd_processo, 
A.PAUX_ds_titular as PAUX_ds_titular, 
A.FASE_cd_fase as FASE_cd_fase, 
A.PAUX_ds_ultimo_evento as PAUX_ds_ultimo_evento, 
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PAUX_processo_auxiliar A

WHERE 




(@PAUX_cd_processo is null or (@PAUX_cd_processo is not null and A.PAUX_cd_processo = @PAUX_cd_processo)) 
 AND (@PAUX_ds_titular is null or (@PAUX_ds_titular is not null and A.PAUX_ds_titular = @PAUX_ds_titular)) 
 AND (@FASE_cd_fase is null or (@FASE_cd_fase is not null and A.FASE_cd_fase = @FASE_cd_fase)) 
 AND (@UNFE_cd_unidade_federativa is null or (@UNFE_cd_unidade_federativa is not null and A.UNFE_cd_unidade_federativa = @UNFE_cd_unidade_federativa)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PAUX_cd_processo'' and rtrim(ltrim(A.PAUX_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PAUX_ds_titular'' and rtrim(ltrim(A.PAUX_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''FASE_cd_fase'' and rtrim(ltrim(A.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PAUX_ds_ultimo_evento'' and rtrim(ltrim(A.PAUX_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNFE_cd_unidade_federativa'' and rtrim(ltrim(A.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PAUX_cd_processo'' and  @sortOrder=''ASC'' then A.PAUX_cd_processo END ASC, 
 CASE when @sortField = ''PAUX_cd_processo'' and  @sortOrder=''DESC'' then A.PAUX_cd_processo END DESC 
 ,  CASE when @sortField = ''PAUX_ds_titular'' and  @sortOrder=''ASC'' then A.PAUX_ds_titular END ASC, 
 CASE when @sortField = ''PAUX_ds_titular'' and  @sortOrder=''DESC'' then A.PAUX_ds_titular END DESC 
 ,  CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''ASC'' then A.FASE_cd_fase END ASC, 
 CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''DESC'' then A.FASE_cd_fase END DESC 
 ,  CASE when @sortField = ''PAUX_ds_ultimo_evento'' and  @sortOrder=''ASC'' then A.PAUX_ds_ultimo_evento END ASC, 
 CASE when @sortField = ''PAUX_ds_ultimo_evento'' and  @sortOrder=''DESC'' then A.PAUX_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''ASC'' then A.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''DESC'' then A.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PAUX_processo_auxiliar where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PAUX_processo_auxiliar_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PAUX_processo_auxiliar_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PAUX_processo_auxiliar
CREATE PROCEDURE [dbo].[sp_sel_tb_PAUX_processo_auxiliar_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PAUX_cd_processo varchar(50) not null, 
PAUX_ds_titular varchar(300) not null, 
FASE_cd_fase int null, 
PAUX_ds_ultimo_evento varchar(3000) null, 
UNFE_cd_unidade_federativa char(2) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PAUX_cd_processo as PAUX_cd_processo, 
A.PAUX_ds_titular as PAUX_ds_titular, 
A.FASE_cd_fase as FASE_cd_fase, 
A.PAUX_ds_ultimo_evento as PAUX_ds_ultimo_evento, 
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PAUX_processo_auxiliar A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PCON_processo_condicao_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PCON_processo_condicao_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PCON_processo_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_PCON_processo_condicao_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@PCON_cd_condicao int = null , 
@COND_nm_condicao varchar(500) = null , 
@SCON_ds_situacao_condicao varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PCON_processo_condicao table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
PCON_cd_condicao int not null, 
COND_nm_condicao varchar(500) not null, 
SCON_ds_situacao_condicao varchar(100) null, 
PCON_ds_condicao varchar(500) null, 
PCON_dt_ini datetime null, 
PCON_dt_fim datetime null, 
PCON_ds_nome_documento varchar(1000) null, 
PCON_ds_local_documento varchar(1000) null, 
PCON_ds_rede_documento varchar(1000) null, 
PCON_ds_path_documento varchar(1000) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PCON_processo_condicao
(PROC_cd_processo, 
PCON_cd_condicao, 
COND_nm_condicao, 
SCON_ds_situacao_condicao, 
PCON_ds_condicao, 
PCON_dt_ini, 
PCON_dt_fim, 
PCON_ds_nome_documento, 
PCON_ds_local_documento, 
PCON_ds_rede_documento, 
PCON_ds_path_documento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.PCON_cd_condicao as PCON_cd_condicao, 
A.COND_nm_condicao as COND_nm_condicao, 
A.SCON_ds_situacao_condicao as SCON_ds_situacao_condicao, 
A.PCON_ds_condicao as PCON_ds_condicao, 
A.PCON_dt_ini as PCON_dt_ini, 
A.PCON_dt_fim as PCON_dt_fim, 
A.PCON_ds_nome_documento as PCON_ds_nome_documento, 
A.PCON_ds_local_documento as PCON_ds_local_documento, 
A.PCON_ds_rede_documento as PCON_ds_rede_documento, 
A.PCON_ds_path_documento as PCON_ds_path_documento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PCON_processo_condicao A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@PCON_cd_condicao is null or (@PCON_cd_condicao is not null and A.PCON_cd_condicao = @PCON_cd_condicao)) 
 AND (@COND_nm_condicao is null or (@COND_nm_condicao is not null and A.COND_nm_condicao = @COND_nm_condicao)) 
 AND (@SCON_ds_situacao_condicao is null or (@SCON_ds_situacao_condicao is not null and A.SCON_ds_situacao_condicao = @SCON_ds_situacao_condicao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PCON_cd_condicao'' and rtrim(ltrim(A.PCON_cd_condicao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''COND_nm_condicao'' and rtrim(ltrim(A.COND_nm_condicao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SCON_ds_situacao_condicao'' and rtrim(ltrim(A.SCON_ds_situacao_condicao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PCON_ds_condicao'' and rtrim(ltrim(A.PCON_ds_condicao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PCON_dt_ini'' and rtrim(ltrim(A.PCON_dt_ini)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PCON_dt_fim'' and rtrim(ltrim(A.PCON_dt_fim)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PCON_ds_nome_documento'' and rtrim(ltrim(A.PCON_ds_nome_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PCON_ds_local_documento'' and rtrim(ltrim(A.PCON_ds_local_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PCON_ds_rede_documento'' and rtrim(ltrim(A.PCON_ds_rede_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PCON_ds_path_documento'' and rtrim(ltrim(A.PCON_ds_path_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''PCON_cd_condicao'' and  @sortOrder=''ASC'' then A.PCON_cd_condicao END ASC, 
 CASE when @sortField = ''PCON_cd_condicao'' and  @sortOrder=''DESC'' then A.PCON_cd_condicao END DESC 
 ,  CASE when @sortField = ''COND_nm_condicao'' and  @sortOrder=''ASC'' then A.COND_nm_condicao END ASC, 
 CASE when @sortField = ''COND_nm_condicao'' and  @sortOrder=''DESC'' then A.COND_nm_condicao END DESC 
 ,  CASE when @sortField = ''SCON_ds_situacao_condicao'' and  @sortOrder=''ASC'' then A.SCON_ds_situacao_condicao END ASC, 
 CASE when @sortField = ''SCON_ds_situacao_condicao'' and  @sortOrder=''DESC'' then A.SCON_ds_situacao_condicao END DESC 
 ,  CASE when @sortField = ''PCON_ds_condicao'' and  @sortOrder=''ASC'' then A.PCON_ds_condicao END ASC, 
 CASE when @sortField = ''PCON_ds_condicao'' and  @sortOrder=''DESC'' then A.PCON_ds_condicao END DESC 
 ,  CASE when @sortField = ''PCON_dt_ini'' and  @sortOrder=''ASC'' then A.PCON_dt_ini END ASC, 
 CASE when @sortField = ''PCON_dt_ini'' and  @sortOrder=''DESC'' then A.PCON_dt_ini END DESC 
 ,  CASE when @sortField = ''PCON_dt_fim'' and  @sortOrder=''ASC'' then A.PCON_dt_fim END ASC, 
 CASE when @sortField = ''PCON_dt_fim'' and  @sortOrder=''DESC'' then A.PCON_dt_fim END DESC 
 ,  CASE when @sortField = ''PCON_ds_nome_documento'' and  @sortOrder=''ASC'' then A.PCON_ds_nome_documento END ASC, 
 CASE when @sortField = ''PCON_ds_nome_documento'' and  @sortOrder=''DESC'' then A.PCON_ds_nome_documento END DESC 
 ,  CASE when @sortField = ''PCON_ds_local_documento'' and  @sortOrder=''ASC'' then A.PCON_ds_local_documento END ASC, 
 CASE when @sortField = ''PCON_ds_local_documento'' and  @sortOrder=''DESC'' then A.PCON_ds_local_documento END DESC 
 ,  CASE when @sortField = ''PCON_ds_rede_documento'' and  @sortOrder=''ASC'' then A.PCON_ds_rede_documento END ASC, 
 CASE when @sortField = ''PCON_ds_rede_documento'' and  @sortOrder=''DESC'' then A.PCON_ds_rede_documento END DESC 
 ,  CASE when @sortField = ''PCON_ds_path_documento'' and  @sortOrder=''ASC'' then A.PCON_ds_path_documento END ASC, 
 CASE when @sortField = ''PCON_ds_path_documento'' and  @sortOrder=''DESC'' then A.PCON_ds_path_documento END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PCON_processo_condicao where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PCON_processo_condicao_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PCON_processo_condicao_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PCON_processo_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_PCON_processo_condicao_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
PCON_cd_condicao int not null, 
COND_nm_condicao varchar(500) not null, 
SCON_ds_situacao_condicao varchar(100) null, 
PCON_ds_condicao varchar(500) null, 
PCON_dt_ini datetime null, 
PCON_dt_fim datetime null, 
PCON_ds_nome_documento varchar(100) null, 
PCON_ds_local_documento varchar(500) null, 
PCON_ds_rede_documento varchar(500) null, 
PCON_ds_path_documento varchar(500) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.PCON_cd_condicao as PCON_cd_condicao, 
A.COND_nm_condicao as COND_nm_condicao, 
A.SCON_ds_situacao_condicao as SCON_ds_situacao_condicao, 
A.PCON_ds_condicao as PCON_ds_condicao, 
A.PCON_dt_ini as PCON_dt_ini, 
A.PCON_dt_fim as PCON_dt_fim, 
A.PCON_ds_nome_documento as PCON_ds_nome_documento, 
A.PCON_ds_local_documento as PCON_ds_local_documento, 
A.PCON_ds_rede_documento as PCON_ds_rede_documento, 
A.PCON_ds_path_documento as PCON_ds_path_documento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PCON_processo_condicao A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PDOC_processo_documento_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PDOC_processo_documento_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PDOC_processo_documento
CREATE PROCEDURE [dbo].[sp_sel_tb_PDOC_processo_documento_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PDOC_nm_documento varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PDOC_processo_documento table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PDOC_nm_documento varchar(100) not null, 
PDOC_ds_documento varchar(1000) null, 
PDOC_ds_local_documento varchar(1000) not null, 
PDOC_ds_rede_documento varchar(1000) not null, 
PDOC_ds_path_documento varchar(1000) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PDOC_processo_documento
(PROC_cd_processo, 
ORGA_nm_orgao, 
PDOC_nm_documento, 
PDOC_ds_documento, 
PDOC_ds_local_documento, 
PDOC_ds_rede_documento, 
PDOC_ds_path_documento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PDOC_nm_documento as PDOC_nm_documento, 
A.PDOC_ds_documento as PDOC_ds_documento, 
A.PDOC_ds_local_documento as PDOC_ds_local_documento, 
A.PDOC_ds_rede_documento as PDOC_ds_rede_documento, 
A.PDOC_ds_path_documento as PDOC_ds_path_documento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PDOC_processo_documento A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@PDOC_nm_documento is null or (@PDOC_nm_documento is not null and A.PDOC_nm_documento = @PDOC_nm_documento)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PDOC_nm_documento'' and rtrim(ltrim(A.PDOC_nm_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PDOC_ds_documento'' and rtrim(ltrim(A.PDOC_ds_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PDOC_ds_local_documento'' and rtrim(ltrim(A.PDOC_ds_local_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PDOC_ds_rede_documento'' and rtrim(ltrim(A.PDOC_ds_rede_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PDOC_ds_path_documento'' and rtrim(ltrim(A.PDOC_ds_path_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''PDOC_nm_documento'' and  @sortOrder=''ASC'' then A.PDOC_nm_documento END ASC, 
 CASE when @sortField = ''PDOC_nm_documento'' and  @sortOrder=''DESC'' then A.PDOC_nm_documento END DESC 
 ,  CASE when @sortField = ''PDOC_ds_documento'' and  @sortOrder=''ASC'' then A.PDOC_ds_documento END ASC, 
 CASE when @sortField = ''PDOC_ds_documento'' and  @sortOrder=''DESC'' then A.PDOC_ds_documento END DESC 
 ,  CASE when @sortField = ''PDOC_ds_local_documento'' and  @sortOrder=''ASC'' then A.PDOC_ds_local_documento END ASC, 
 CASE when @sortField = ''PDOC_ds_local_documento'' and  @sortOrder=''DESC'' then A.PDOC_ds_local_documento END DESC 
 ,  CASE when @sortField = ''PDOC_ds_rede_documento'' and  @sortOrder=''ASC'' then A.PDOC_ds_rede_documento END ASC, 
 CASE when @sortField = ''PDOC_ds_rede_documento'' and  @sortOrder=''DESC'' then A.PDOC_ds_rede_documento END DESC 
 ,  CASE when @sortField = ''PDOC_ds_path_documento'' and  @sortOrder=''ASC'' then A.PDOC_ds_path_documento END ASC, 
 CASE when @sortField = ''PDOC_ds_path_documento'' and  @sortOrder=''DESC'' then A.PDOC_ds_path_documento END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PDOC_processo_documento where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PDOC_processo_documento_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PDOC_processo_documento_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PDOC_processo_documento
CREATE PROCEDURE [dbo].[sp_sel_tb_PDOC_processo_documento_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PDOC_nm_documento varchar(100) not null, 
PDOC_ds_documento varchar(100) null, 
PDOC_ds_local_documento varchar(100) not null, 
PDOC_ds_rede_documento varchar(100) not null, 
PDOC_ds_path_documento varchar(500) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PDOC_nm_documento as PDOC_nm_documento, 
A.PDOC_ds_documento as PDOC_ds_documento, 
A.PDOC_ds_local_documento as PDOC_ds_local_documento, 
A.PDOC_ds_rede_documento as PDOC_ds_rede_documento, 
A.PDOC_ds_path_documento as PDOC_ds_path_documento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PDOC_processo_documento A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PGER_parametro_geral_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PGER_cd_parametro varchar(10) = null , 
@PGER_fl_tipo char(1) = null , 
@PGER_fl_sistema char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PGER_parametro_geral table (
id int identity primary key, 
PGER_cd_parametro varchar(10) not null, 
PGER_ds_parametro varchar(100) not null, 
PGER_vl_parametro varchar(1000) not null, 
PGER_fl_tipo char(1) not null, 
PGER_fl_sistema char(1) not null, 
PGER_vl_range_min bigint null, 
PGER_vl_range_max bigint null, 
PGER_vl_padrao varchar(1000) not null, 
PGER_vl_tamanho_min int null, 
PGER_vl_tamanho_max int null, 
PGER_vl_valores_permitidos varchar(8000) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PGER_parametro_geral
(PGER_cd_parametro, 
PGER_ds_parametro, 
PGER_vl_parametro, 
PGER_fl_tipo, 
PGER_fl_sistema, 
PGER_vl_range_min, 
PGER_vl_range_max, 
PGER_vl_padrao, 
PGER_vl_tamanho_min, 
PGER_vl_tamanho_max, 
PGER_vl_valores_permitidos, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PGER_cd_parametro as PGER_cd_parametro, 
A.PGER_ds_parametro as PGER_ds_parametro, 
A.PGER_vl_parametro as PGER_vl_parametro, 
A.PGER_fl_tipo as PGER_fl_tipo, 
A.PGER_fl_sistema as PGER_fl_sistema, 
A.PGER_vl_range_min as PGER_vl_range_min, 
A.PGER_vl_range_max as PGER_vl_range_max, 
A.PGER_vl_padrao as PGER_vl_padrao, 
A.PGER_vl_tamanho_min as PGER_vl_tamanho_min, 
A.PGER_vl_tamanho_max as PGER_vl_tamanho_max, 
A.PGER_vl_valores_permitidos as PGER_vl_valores_permitidos, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PGER_parametro_geral A

WHERE 




(@PGER_cd_parametro is null or (@PGER_cd_parametro is not null and A.PGER_cd_parametro = @PGER_cd_parametro)) 
 AND (@PGER_fl_tipo is null or (@PGER_fl_tipo is not null and A.PGER_fl_tipo = @PGER_fl_tipo)) 
 AND (@PGER_fl_sistema is null or (@PGER_fl_sistema is not null and A.PGER_fl_sistema = @PGER_fl_sistema)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PGER_cd_parametro'' and rtrim(ltrim(A.PGER_cd_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_ds_parametro'' and rtrim(ltrim(A.PGER_ds_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_vl_parametro'' and rtrim(ltrim(A.PGER_vl_parametro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_fl_tipo'' and rtrim(ltrim(A.PGER_fl_tipo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_fl_sistema'' and rtrim(ltrim(A.PGER_fl_sistema)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_vl_range_min'' and rtrim(ltrim(A.PGER_vl_range_min)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_vl_range_max'' and rtrim(ltrim(A.PGER_vl_range_max)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_vl_padrao'' and rtrim(ltrim(A.PGER_vl_padrao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_vl_tamanho_min'' and rtrim(ltrim(A.PGER_vl_tamanho_min)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_vl_tamanho_max'' and rtrim(ltrim(A.PGER_vl_tamanho_max)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PGER_vl_valores_permitidos'' and rtrim(ltrim(A.PGER_vl_valores_permitidos)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PGER_cd_parametro'' and  @sortOrder=''ASC'' then A.PGER_cd_parametro END ASC, 
 CASE when @sortField = ''PGER_cd_parametro'' and  @sortOrder=''DESC'' then A.PGER_cd_parametro END DESC 
 ,  CASE when @sortField = ''PGER_ds_parametro'' and  @sortOrder=''ASC'' then A.PGER_ds_parametro END ASC, 
 CASE when @sortField = ''PGER_ds_parametro'' and  @sortOrder=''DESC'' then A.PGER_ds_parametro END DESC 
 ,  CASE when @sortField = ''PGER_vl_parametro'' and  @sortOrder=''ASC'' then A.PGER_vl_parametro END ASC, 
 CASE when @sortField = ''PGER_vl_parametro'' and  @sortOrder=''DESC'' then A.PGER_vl_parametro END DESC 
 ,  CASE when @sortField = ''PGER_fl_tipo'' and  @sortOrder=''ASC'' then A.PGER_fl_tipo END ASC, 
 CASE when @sortField = ''PGER_fl_tipo'' and  @sortOrder=''DESC'' then A.PGER_fl_tipo END DESC 
 ,  CASE when @sortField = ''PGER_fl_sistema'' and  @sortOrder=''ASC'' then A.PGER_fl_sistema END ASC, 
 CASE when @sortField = ''PGER_fl_sistema'' and  @sortOrder=''DESC'' then A.PGER_fl_sistema END DESC 
 ,  CASE when @sortField = ''PGER_vl_range_min'' and  @sortOrder=''ASC'' then A.PGER_vl_range_min END ASC, 
 CASE when @sortField = ''PGER_vl_range_min'' and  @sortOrder=''DESC'' then A.PGER_vl_range_min END DESC 
 ,  CASE when @sortField = ''PGER_vl_range_max'' and  @sortOrder=''ASC'' then A.PGER_vl_range_max END ASC, 
 CASE when @sortField = ''PGER_vl_range_max'' and  @sortOrder=''DESC'' then A.PGER_vl_range_max END DESC 
 ,  CASE when @sortField = ''PGER_vl_padrao'' and  @sortOrder=''ASC'' then A.PGER_vl_padrao END ASC, 
 CASE when @sortField = ''PGER_vl_padrao'' and  @sortOrder=''DESC'' then A.PGER_vl_padrao END DESC 
 ,  CASE when @sortField = ''PGER_vl_tamanho_min'' and  @sortOrder=''ASC'' then A.PGER_vl_tamanho_min END ASC, 
 CASE when @sortField = ''PGER_vl_tamanho_min'' and  @sortOrder=''DESC'' then A.PGER_vl_tamanho_min END DESC 
 ,  CASE when @sortField = ''PGER_vl_tamanho_max'' and  @sortOrder=''ASC'' then A.PGER_vl_tamanho_max END ASC, 
 CASE when @sortField = ''PGER_vl_tamanho_max'' and  @sortOrder=''DESC'' then A.PGER_vl_tamanho_max END DESC 
 ,  CASE when @sortField = ''PGER_vl_valores_permitidos'' and  @sortOrder=''ASC'' then A.PGER_vl_valores_permitidos END ASC, 
 CASE when @sortField = ''PGER_vl_valores_permitidos'' and  @sortOrder=''DESC'' then A.PGER_vl_valores_permitidos END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PGER_parametro_geral where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PGER_parametro_geral_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PGER_cd_parametro varchar(10) not null, 
PGER_ds_parametro varchar(100) not null, 
PGER_vl_parametro varchar(1000) not null, 
PGER_fl_tipo char(1) not null, 
PGER_fl_sistema char(1) not null, 
PGER_vl_range_min bigint null, 
PGER_vl_range_max bigint null, 
PGER_vl_padrao varchar(1000) not null, 
PGER_vl_tamanho_min int null, 
PGER_vl_tamanho_max int null, 
PGER_vl_valores_permitidos varchar(8000) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PGER_cd_parametro as PGER_cd_parametro, 
A.PGER_ds_parametro as PGER_ds_parametro, 
A.PGER_vl_parametro as PGER_vl_parametro, 
A.PGER_fl_tipo as PGER_fl_tipo, 
A.PGER_fl_sistema as PGER_fl_sistema, 
A.PGER_vl_range_min as PGER_vl_range_min, 
A.PGER_vl_range_max as PGER_vl_range_max, 
A.PGER_vl_padrao as PGER_vl_padrao, 
A.PGER_vl_tamanho_min as PGER_vl_tamanho_min, 
A.PGER_vl_tamanho_max as PGER_vl_tamanho_max, 
A.PGER_vl_valores_permitidos as PGER_vl_valores_permitidos, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PGER_parametro_geral A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PINF_processo_info_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PINF_processo_info_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PINF_processo_info
CREATE PROCEDURE [dbo].[sp_sel_tb_PINF_processo_info_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PINF_cd_info int = null , 
@PINF_ds_info varchar(500) = null , 
@TINF_nm_tipo_info varchar(100) = null , 
@SINF_ds_situacao_info varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PINF_processo_info table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PINF_cd_info int not null, 
PINF_ds_info varchar(500) null, 
TINF_nm_tipo_info varchar(100) null, 
SINF_ds_situacao_info varchar(100) null, 
PINF_dt_ini datetime null, 
PINF_dt_fim datetime null, 
PINF_ds_local_documento varchar(500) not null, 
PINF_ds_rede_documento varchar(500) not null, 
PINF_ds_path_documento varchar(500) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PINF_processo_info
(PROC_cd_processo, 
ORGA_nm_orgao, 
PINF_cd_info, 
PINF_ds_info, 
TINF_nm_tipo_info, 
SINF_ds_situacao_info, 
PINF_dt_ini, 
PINF_dt_fim, 
PINF_ds_local_documento, 
PINF_ds_rede_documento, 
PINF_ds_path_documento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PINF_cd_info as PINF_cd_info, 
A.PINF_ds_info as PINF_ds_info, 
A.TINF_nm_tipo_info as TINF_nm_tipo_info, 
A.SINF_ds_situacao_info as SINF_ds_situacao_info, 
A.PINF_dt_ini as PINF_dt_ini, 
A.PINF_dt_fim as PINF_dt_fim, 
A.PINF_ds_local_documento as PINF_ds_local_documento, 
A.PINF_ds_rede_documento as PINF_ds_rede_documento, 
A.PINF_ds_path_documento as PINF_ds_path_documento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PINF_processo_info A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@PINF_cd_info is null or (@PINF_cd_info is not null and A.PINF_cd_info = @PINF_cd_info)) 
 AND (@PINF_ds_info is null or (@PINF_ds_info is not null and A.PINF_ds_info = @PINF_ds_info)) 
 AND (@TINF_nm_tipo_info is null or (@TINF_nm_tipo_info is not null and A.TINF_nm_tipo_info = @TINF_nm_tipo_info)) 
 AND (@SINF_ds_situacao_info is null or (@SINF_ds_situacao_info is not null and A.SINF_ds_situacao_info = @SINF_ds_situacao_info)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PINF_cd_info'' and rtrim(ltrim(A.PINF_cd_info)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PINF_ds_info'' and rtrim(ltrim(A.PINF_ds_info)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TINF_nm_tipo_info'' and rtrim(ltrim(A.TINF_nm_tipo_info)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SINF_ds_situacao_info'' and rtrim(ltrim(A.SINF_ds_situacao_info)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PINF_dt_ini'' and rtrim(ltrim(A.PINF_dt_ini)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PINF_dt_fim'' and rtrim(ltrim(A.PINF_dt_fim)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PINF_ds_local_documento'' and rtrim(ltrim(A.PINF_ds_local_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PINF_ds_rede_documento'' and rtrim(ltrim(A.PINF_ds_rede_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PINF_ds_path_documento'' and rtrim(ltrim(A.PINF_ds_path_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''PINF_cd_info'' and  @sortOrder=''ASC'' then A.PINF_cd_info END ASC, 
 CASE when @sortField = ''PINF_cd_info'' and  @sortOrder=''DESC'' then A.PINF_cd_info END DESC 
 ,  CASE when @sortField = ''PINF_ds_info'' and  @sortOrder=''ASC'' then A.PINF_ds_info END ASC, 
 CASE when @sortField = ''PINF_ds_info'' and  @sortOrder=''DESC'' then A.PINF_ds_info END DESC 
 ,  CASE when @sortField = ''TINF_nm_tipo_info'' and  @sortOrder=''ASC'' then A.TINF_nm_tipo_info END ASC, 
 CASE when @sortField = ''TINF_nm_tipo_info'' and  @sortOrder=''DESC'' then A.TINF_nm_tipo_info END DESC 
 ,  CASE when @sortField = ''SINF_ds_situacao_info'' and  @sortOrder=''ASC'' then A.SINF_ds_situacao_info END ASC, 
 CASE when @sortField = ''SINF_ds_situacao_info'' and  @sortOrder=''DESC'' then A.SINF_ds_situacao_info END DESC 
 ,  CASE when @sortField = ''PINF_dt_ini'' and  @sortOrder=''ASC'' then A.PINF_dt_ini END ASC, 
 CASE when @sortField = ''PINF_dt_ini'' and  @sortOrder=''DESC'' then A.PINF_dt_ini END DESC 
 ,  CASE when @sortField = ''PINF_dt_fim'' and  @sortOrder=''ASC'' then A.PINF_dt_fim END ASC, 
 CASE when @sortField = ''PINF_dt_fim'' and  @sortOrder=''DESC'' then A.PINF_dt_fim END DESC 
 ,  CASE when @sortField = ''PINF_ds_local_documento'' and  @sortOrder=''ASC'' then A.PINF_ds_local_documento END ASC, 
 CASE when @sortField = ''PINF_ds_local_documento'' and  @sortOrder=''DESC'' then A.PINF_ds_local_documento END DESC 
 ,  CASE when @sortField = ''PINF_ds_rede_documento'' and  @sortOrder=''ASC'' then A.PINF_ds_rede_documento END ASC, 
 CASE when @sortField = ''PINF_ds_rede_documento'' and  @sortOrder=''DESC'' then A.PINF_ds_rede_documento END DESC 
 ,  CASE when @sortField = ''PINF_ds_path_documento'' and  @sortOrder=''ASC'' then A.PINF_ds_path_documento END ASC, 
 CASE when @sortField = ''PINF_ds_path_documento'' and  @sortOrder=''DESC'' then A.PINF_ds_path_documento END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PINF_processo_info where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PINF_processo_info_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PINF_processo_info_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PINF_processo_info
CREATE PROCEDURE [dbo].[sp_sel_tb_PINF_processo_info_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PINF_cd_info int not null, 
PINF_ds_info varchar(500) null, 
TINF_nm_tipo_info varchar(100) null, 
SINF_ds_situacao_info varchar(100) null, 
PINF_dt_ini datetime null, 
PINF_dt_fim datetime null, 
PINF_ds_local_documento varchar(500) not null, 
PINF_ds_rede_documento varchar(500) not null, 
PINF_ds_path_documento varchar(500) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PINF_cd_info as PINF_cd_info, 
A.PINF_ds_info as PINF_ds_info, 
A.TINF_nm_tipo_info as TINF_nm_tipo_info, 
A.SINF_ds_situacao_info as SINF_ds_situacao_info, 
A.PINF_dt_ini as PINF_dt_ini, 
A.PINF_dt_fim as PINF_dt_fim, 
A.PINF_ds_local_documento as PINF_ds_local_documento, 
A.PINF_ds_rede_documento as PINF_ds_rede_documento, 
A.PINF_ds_path_documento as PINF_ds_path_documento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PINF_processo_info A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PMUN_processo_municipio_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PMUN_processo_municipio_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PMUN_processo_municipio
CREATE PROCEDURE [dbo].[sp_sel_tb_PMUN_processo_municipio_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@MUNI_nm_municipio varchar(150) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PMUN_processo_municipio table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
MUNI_nm_municipio varchar(150) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PMUN_processo_municipio
(PROC_cd_processo, 
MUNI_nm_municipio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.MUNI_nm_municipio as MUNI_nm_municipio, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PMUN_processo_municipio A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@MUNI_nm_municipio is null or (@MUNI_nm_municipio is not null and A.MUNI_nm_municipio = @MUNI_nm_municipio)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''MUNI_nm_municipio'' and rtrim(ltrim(A.MUNI_nm_municipio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''MUNI_nm_municipio'' and  @sortOrder=''ASC'' then A.MUNI_nm_municipio END ASC, 
 CASE when @sortField = ''MUNI_nm_municipio'' and  @sortOrder=''DESC'' then A.MUNI_nm_municipio END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PMUN_processo_municipio where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PMUN_processo_municipio_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PMUN_processo_municipio_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PMUN_processo_municipio
CREATE PROCEDURE [dbo].[sp_sel_tb_PMUN_processo_municipio_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
MUNI_nm_municipio varchar(150) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.MUNI_nm_municipio as MUNI_nm_municipio, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PMUN_processo_municipio A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PNOT_processo_nota_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PNOT_processo_nota_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PNOT_processo_nota
CREATE PROCEDURE [dbo].[sp_sel_tb_PNOT_processo_nota_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PNOT_cd_nota int = null , 
@PNOT_dt_ocorrencia datetime = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PNOT_processo_nota table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PNOT_cd_nota int not null, 
PNOT_ds_nota varchar(1000) not null, 
PNOT_dt_ocorrencia datetime null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PNOT_processo_nota
(PROC_cd_processo, 
ORGA_nm_orgao, 
PNOT_cd_nota, 
PNOT_ds_nota, 
PNOT_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PNOT_cd_nota as PNOT_cd_nota, 
A.PNOT_ds_nota as PNOT_ds_nota, 
A.PNOT_dt_ocorrencia as PNOT_dt_ocorrencia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PNOT_processo_nota A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@PNOT_cd_nota is null or (@PNOT_cd_nota is not null and A.PNOT_cd_nota = @PNOT_cd_nota)) 
 AND (@PNOT_dt_ocorrencia is null or (@PNOT_dt_ocorrencia is not null and A.PNOT_dt_ocorrencia = @PNOT_dt_ocorrencia)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PNOT_cd_nota'' and rtrim(ltrim(A.PNOT_cd_nota)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PNOT_ds_nota'' and rtrim(ltrim(A.PNOT_ds_nota)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PNOT_dt_ocorrencia'' and rtrim(ltrim(A.PNOT_dt_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''PNOT_cd_nota'' and  @sortOrder=''ASC'' then A.PNOT_cd_nota END ASC, 
 CASE when @sortField = ''PNOT_cd_nota'' and  @sortOrder=''DESC'' then A.PNOT_cd_nota END DESC 
 ,  CASE when @sortField = ''PNOT_ds_nota'' and  @sortOrder=''ASC'' then A.PNOT_ds_nota END ASC, 
 CASE when @sortField = ''PNOT_ds_nota'' and  @sortOrder=''DESC'' then A.PNOT_ds_nota END DESC 
 ,  CASE when @sortField = ''PNOT_dt_ocorrencia'' and  @sortOrder=''ASC'' then A.PNOT_dt_ocorrencia END ASC, 
 CASE when @sortField = ''PNOT_dt_ocorrencia'' and  @sortOrder=''DESC'' then A.PNOT_dt_ocorrencia END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PNOT_processo_nota where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PNOT_processo_nota_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PNOT_processo_nota_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PNOT_processo_nota
CREATE PROCEDURE [dbo].[sp_sel_tb_PNOT_processo_nota_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PNOT_cd_nota int not null, 
PNOT_ds_nota varchar(1000) not null, 
PNOT_dt_ocorrencia datetime null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PNOT_cd_nota as PNOT_cd_nota, 
A.PNOT_ds_nota as PNOT_ds_nota, 
A.PNOT_dt_ocorrencia as PNOT_dt_ocorrencia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PNOT_processo_nota A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PORG_processo_orgao_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PORG_processo_orgao_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PORG_processo_orgao
CREATE PROCEDURE [dbo].[sp_sel_tb_PORG_processo_orgao_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PORG_nm_cadastro varchar(30) = null , 
@PORG_ds_atividade varchar(500) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PORG_processo_orgao table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PORG_nm_cadastro varchar(30) null, 
PORG_ds_atividade varchar(500) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PORG_processo_orgao
(PROC_cd_processo, 
ORGA_nm_orgao, 
PORG_nm_cadastro, 
PORG_ds_atividade, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PORG_nm_cadastro as PORG_nm_cadastro, 
A.PORG_ds_atividade as PORG_ds_atividade, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PORG_processo_orgao A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@PORG_nm_cadastro is null or (@PORG_nm_cadastro is not null and A.PORG_nm_cadastro = @PORG_nm_cadastro)) 
 AND (@PORG_ds_atividade is null or (@PORG_ds_atividade is not null and A.PORG_ds_atividade = @PORG_ds_atividade)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PORG_nm_cadastro'' and rtrim(ltrim(A.PORG_nm_cadastro)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PORG_ds_atividade'' and rtrim(ltrim(A.PORG_ds_atividade)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''PORG_nm_cadastro'' and  @sortOrder=''ASC'' then A.PORG_nm_cadastro END ASC, 
 CASE when @sortField = ''PORG_nm_cadastro'' and  @sortOrder=''DESC'' then A.PORG_nm_cadastro END DESC 
 ,  CASE when @sortField = ''PORG_ds_atividade'' and  @sortOrder=''ASC'' then A.PORG_ds_atividade END ASC, 
 CASE when @sortField = ''PORG_ds_atividade'' and  @sortOrder=''DESC'' then A.PORG_ds_atividade END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PORG_processo_orgao where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PORG_processo_orgao_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PORG_processo_orgao_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PORG_processo_orgao
CREATE PROCEDURE [dbo].[sp_sel_tb_PORG_processo_orgao_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PORG_nm_cadastro varchar(30) null, 
PORG_ds_atividade varchar(500) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PORG_nm_cadastro as PORG_nm_cadastro, 
A.PORG_ds_atividade as PORG_ds_atividade, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PORG_processo_orgao A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAL_processo_alerta_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PRAL_fl_manutencao char(1) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PRAL_processo_alerta table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ALER_nm_alerta varchar(50) not null, 
PRAL_fl_manutencao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
ALER_ds_alerta varchar(300) null, 
ALER_fl_muda_fase char(1) not null, 
ALER_fl_muda_evento char(1) not null, 
ALER_cd_fase_anterior int null, 
ALER_cd_fase_nova int null, 
ALER_fl_qualquer_processo char(1) not null, 
ALER_fl_status char(1) not null, 
ALER_fl_sistema char(1) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null
)



insert into 
@tb_PRAL_processo_alerta
(PROC_cd_processo, 
ALER_nm_alerta, 
PRAL_fl_manutencao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 
ALER_ds_alerta, 
ALER_fl_muda_fase, 
ALER_fl_muda_evento, 
ALER_cd_fase_anterior, 
ALER_cd_fase_nova, 
ALER_fl_qualquer_processo, 
ALER_fl_status, 
ALER_fl_sistema, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ALER_nm_alerta as ALER_nm_alerta, 
A.PRAL_fl_manutencao as PRAL_fl_manutencao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.ALER_ds_alerta as ALER_ds_alerta, 
B.ALER_fl_muda_fase as ALER_fl_muda_fase, 
B.ALER_fl_muda_evento as ALER_fl_muda_evento, 
B.ALER_cd_fase_anterior as ALER_cd_fase_anterior, 
B.ALER_cd_fase_nova as ALER_cd_fase_nova, 
B.ALER_fl_qualquer_processo as ALER_fl_qualquer_processo, 
B.ALER_fl_status as ALER_fl_status, 
B.ALER_fl_sistema as ALER_fl_sistema, 
C.PROC_ds_titular as PROC_ds_titular, 
C.PROC_vl_ano as PROC_vl_ano, 
C.PROC_nm_processo as PROC_nm_processo, 
C.PROC_id_processo as PROC_id_processo, 
C.FASE_cd_fase as FASE_cd_fase, 
C.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
C.PROC_ds_substancia as PROC_ds_substancia, 
C.PROC_ds_area as PROC_ds_area, 
C.PROC_ds_uso as PROC_ds_uso, 
C.PROC_ds_link as PROC_ds_link, 
C.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
C.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao

FROM 

DBDNPM..tb_PRAL_processo_alerta A, 
DBDNPM..tb_ALER_alerta B, 
DBDNPM..tb_PROC_processo C

WHERE 


 -- Join: dbDNPM.tb_PRAL_processo_alerta x dbDNPM.tb_ALER_alerta
 -- Join: dbDNPM.tb_PRAL_processo_alerta x dbDNPM.tb_PROC_processo


A.ALER_nm_alerta = B.ALER_nm_alerta and 

A.PROC_cd_processo = C.PROC_cd_processo  AND 

(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and A.ALER_nm_alerta = @ALER_nm_alerta)) 
 AND (@PRAL_fl_manutencao is null or (@PRAL_fl_manutencao is not null and A.PRAL_fl_manutencao = @PRAL_fl_manutencao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_nm_alerta'' and rtrim(ltrim(A.ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRAL_fl_manutencao'' and rtrim(ltrim(A.PRAL_fl_manutencao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_ds_alerta'' and rtrim(ltrim(B.ALER_ds_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_muda_fase'' and rtrim(ltrim(B.ALER_fl_muda_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_muda_evento'' and rtrim(ltrim(B.ALER_fl_muda_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_cd_fase_anterior'' and rtrim(ltrim(B.ALER_cd_fase_anterior)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_cd_fase_nova'' and rtrim(ltrim(B.ALER_cd_fase_nova)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_qualquer_processo'' and rtrim(ltrim(B.ALER_fl_qualquer_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_status'' and rtrim(ltrim(B.ALER_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_sistema'' and rtrim(ltrim(B.ALER_fl_sistema)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_titular'' and rtrim(ltrim(C.PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_vl_ano'' and rtrim(ltrim(C.PROC_vl_ano)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_nm_processo'' and rtrim(ltrim(C.PROC_nm_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_id_processo'' and rtrim(ltrim(C.PROC_id_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''FASE_cd_fase'' and rtrim(ltrim(C.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_ultimo_evento'' and rtrim(ltrim(C.PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_substancia'' and rtrim(ltrim(C.PROC_ds_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_area'' and rtrim(ltrim(C.PROC_ds_area)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_uso'' and rtrim(ltrim(C.PROC_ds_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_link'' and rtrim(ltrim(C.PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNFE_cd_unidade_federativa'' and rtrim(ltrim(C.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_fl_tipo_inclusao'' and rtrim(ltrim(C.PROC_fl_tipo_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ALER_nm_alerta'' and  @sortOrder=''ASC'' then A.ALER_nm_alerta END ASC, 
 CASE when @sortField = ''ALER_nm_alerta'' and  @sortOrder=''DESC'' then A.ALER_nm_alerta END DESC 
 ,  CASE when @sortField = ''PRAL_fl_manutencao'' and  @sortOrder=''ASC'' then A.PRAL_fl_manutencao END ASC, 
 CASE when @sortField = ''PRAL_fl_manutencao'' and  @sortOrder=''DESC'' then A.PRAL_fl_manutencao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 
 ,  CASE when @sortField = ''ALER_ds_alerta'' and  @sortOrder=''ASC'' then B.ALER_ds_alerta END ASC, 
 CASE when @sortField = ''ALER_ds_alerta'' and  @sortOrder=''DESC'' then B.ALER_ds_alerta END DESC 
 ,  CASE when @sortField = ''ALER_fl_muda_fase'' and  @sortOrder=''ASC'' then B.ALER_fl_muda_fase END ASC, 
 CASE when @sortField = ''ALER_fl_muda_fase'' and  @sortOrder=''DESC'' then B.ALER_fl_muda_fase END DESC 
 ,  CASE when @sortField = ''ALER_fl_muda_evento'' and  @sortOrder=''ASC'' then B.ALER_fl_muda_evento END ASC, 
 CASE when @sortField = ''ALER_fl_muda_evento'' and  @sortOrder=''DESC'' then B.ALER_fl_muda_evento END DESC 
 ,  CASE when @sortField = ''ALER_cd_fase_anterior'' and  @sortOrder=''ASC'' then B.ALER_cd_fase_anterior END ASC, 
 CASE when @sortField = ''ALER_cd_fase_anterior'' and  @sortOrder=''DESC'' then B.ALER_cd_fase_anterior END DESC 
 ,  CASE when @sortField = ''ALER_cd_fase_nova'' and  @sortOrder=''ASC'' then B.ALER_cd_fase_nova END ASC, 
 CASE when @sortField = ''ALER_cd_fase_nova'' and  @sortOrder=''DESC'' then B.ALER_cd_fase_nova END DESC 
 ,  CASE when @sortField = ''ALER_fl_qualquer_processo'' and  @sortOrder=''ASC'' then B.ALER_fl_qualquer_processo END ASC, 
 CASE when @sortField = ''ALER_fl_qualquer_processo'' and  @sortOrder=''DESC'' then B.ALER_fl_qualquer_processo END DESC 
 ,  CASE when @sortField = ''ALER_fl_status'' and  @sortOrder=''ASC'' then B.ALER_fl_status END ASC, 
 CASE when @sortField = ''ALER_fl_status'' and  @sortOrder=''DESC'' then B.ALER_fl_status END DESC 
 ,  CASE when @sortField = ''ALER_fl_sistema'' and  @sortOrder=''ASC'' then B.ALER_fl_sistema END ASC, 
 CASE when @sortField = ''ALER_fl_sistema'' and  @sortOrder=''DESC'' then B.ALER_fl_sistema END DESC 
 ,  CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''ASC'' then C.PROC_ds_titular END ASC, 
 CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''DESC'' then C.PROC_ds_titular END DESC 
 ,  CASE when @sortField = ''PROC_vl_ano'' and  @sortOrder=''ASC'' then C.PROC_vl_ano END ASC, 
 CASE when @sortField = ''PROC_vl_ano'' and  @sortOrder=''DESC'' then C.PROC_vl_ano END DESC 
 ,  CASE when @sortField = ''PROC_nm_processo'' and  @sortOrder=''ASC'' then C.PROC_nm_processo END ASC, 
 CASE when @sortField = ''PROC_nm_processo'' and  @sortOrder=''DESC'' then C.PROC_nm_processo END DESC 
 ,  CASE when @sortField = ''PROC_id_processo'' and  @sortOrder=''ASC'' then C.PROC_id_processo END ASC, 
 CASE when @sortField = ''PROC_id_processo'' and  @sortOrder=''DESC'' then C.PROC_id_processo END DESC 
 ,  CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''ASC'' then C.FASE_cd_fase END ASC, 
 CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''DESC'' then C.FASE_cd_fase END DESC 
 ,  CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''ASC'' then C.PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''DESC'' then C.PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = ''PROC_ds_substancia'' and  @sortOrder=''ASC'' then C.PROC_ds_substancia END ASC, 
 CASE when @sortField = ''PROC_ds_substancia'' and  @sortOrder=''DESC'' then C.PROC_ds_substancia END DESC 
 ,  CASE when @sortField = ''PROC_ds_area'' and  @sortOrder=''ASC'' then C.PROC_ds_area END ASC, 
 CASE when @sortField = ''PROC_ds_area'' and  @sortOrder=''DESC'' then C.PROC_ds_area END DESC 
 ,  CASE when @sortField = ''PROC_ds_uso'' and  @sortOrder=''ASC'' then C.PROC_ds_uso END ASC, 
 CASE when @sortField = ''PROC_ds_uso'' and  @sortOrder=''DESC'' then C.PROC_ds_uso END DESC 
 ,  CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''ASC'' then C.PROC_ds_link END ASC, 
 CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''DESC'' then C.PROC_ds_link END DESC 
 ,  CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''ASC'' then C.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''DESC'' then C.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = ''PROC_fl_tipo_inclusao'' and  @sortOrder=''ASC'' then C.PROC_fl_tipo_inclusao END ASC, 
 CASE when @sortField = ''PROC_fl_tipo_inclusao'' and  @sortOrder=''DESC'' then C.PROC_fl_tipo_inclusao END DESC 

 
SELECT * FROM 
@tb_PRAL_processo_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAL_processo_alerta_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



 -- Join: dbDNPM.tb_PRAL_processo_alerta x dbDNPM.tb_ALER_alerta
 -- Join: dbDNPM.tb_PRAL_processo_alerta x dbDNPM.tb_PROC_processo

SET @whereAux = ''
A.ALER_nm_alerta = B.ALER_nm_alerta and 

A.PROC_cd_processo = C.PROC_cd_processo ''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ALER_nm_alerta varchar(50) not null, 
PRAL_fl_manutencao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
ALER_ds_alerta varchar(300) null, 
ALER_fl_muda_fase char(1) not null, 
ALER_fl_muda_evento char(1) not null, 
ALER_cd_fase_anterior int null, 
ALER_cd_fase_nova int null, 
ALER_fl_qualquer_processo char(1) not null, 
ALER_fl_status char(1) not null, 
ALER_fl_sistema char(1) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ALER_nm_alerta as ALER_nm_alerta, 
A.PRAL_fl_manutencao as PRAL_fl_manutencao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.ALER_ds_alerta as ALER_ds_alerta, 
B.ALER_fl_muda_fase as ALER_fl_muda_fase, 
B.ALER_fl_muda_evento as ALER_fl_muda_evento, 
B.ALER_cd_fase_anterior as ALER_cd_fase_anterior, 
B.ALER_cd_fase_nova as ALER_cd_fase_nova, 
B.ALER_fl_qualquer_processo as ALER_fl_qualquer_processo, 
B.ALER_fl_status as ALER_fl_status, 
B.ALER_fl_sistema as ALER_fl_sistema, 
C.PROC_ds_titular as PROC_ds_titular, 
C.PROC_vl_ano as PROC_vl_ano, 
C.PROC_nm_processo as PROC_nm_processo, 
C.PROC_id_processo as PROC_id_processo, 
C.FASE_cd_fase as FASE_cd_fase, 
C.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
C.PROC_ds_substancia as PROC_ds_substancia, 
C.PROC_ds_area as PROC_ds_area, 
C.PROC_ds_uso as PROC_ds_uso, 
C.PROC_ds_link as PROC_ds_link, 
C.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
C.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao '' 
+ '' from 

DBDNPM..tb_PRAL_processo_alerta A, 
DBDNPM..tb_ALER_alerta B, 
DBDNPM..tb_PROC_processo C '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAN_processo_andamento_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAN_processo_andamento_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRAN_processo_andamento
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAN_processo_andamento_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@PROC_cd_ultimo_evento varchar(20) = null , 
@PROC_ds_ultimo_evento varchar(1000) = null , 
@PROC_cd_evento_andamento varchar(20) = null , 
@PROC_dt_vencimento datetime = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PRAN_processo_andamento table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_cd_ultimo_evento varchar(20) null, 
PROC_ds_ultimo_evento varchar(1000) null, 
PROC_ds_link varchar(150) null, 
PROC_cd_evento_andamento varchar(20) not null, 
PROC_ds_evento_andamento varchar(1000) null, 
PROC_dt_vencimento datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PRAN_processo_andamento
(PROC_cd_processo, 
PROC_ds_titular, 
PROC_cd_ultimo_evento, 
PROC_ds_ultimo_evento, 
PROC_ds_link, 
PROC_cd_evento_andamento, 
PROC_ds_evento_andamento, 
PROC_dt_vencimento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.PROC_ds_titular as PROC_ds_titular, 
A.PROC_cd_ultimo_evento as PROC_cd_ultimo_evento, 
A.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
A.PROC_ds_link as PROC_ds_link, 
A.PROC_cd_evento_andamento as PROC_cd_evento_andamento, 
A.PROC_ds_evento_andamento as PROC_ds_evento_andamento, 
A.PROC_dt_vencimento as PROC_dt_vencimento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PRAN_processo_andamento A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@PROC_cd_ultimo_evento is null or (@PROC_cd_ultimo_evento is not null and A.PROC_cd_ultimo_evento = @PROC_cd_ultimo_evento)) 
 AND (@PROC_ds_ultimo_evento is null or (@PROC_ds_ultimo_evento is not null and A.PROC_ds_ultimo_evento = @PROC_ds_ultimo_evento)) 
 AND (@PROC_cd_evento_andamento is null or (@PROC_cd_evento_andamento is not null and A.PROC_cd_evento_andamento = @PROC_cd_evento_andamento)) 
 AND (@PROC_dt_vencimento is null or (@PROC_dt_vencimento is not null and A.PROC_dt_vencimento = @PROC_dt_vencimento)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_titular'' and rtrim(ltrim(A.PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_cd_ultimo_evento'' and rtrim(ltrim(A.PROC_cd_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_ultimo_evento'' and rtrim(ltrim(A.PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_link'' and rtrim(ltrim(A.PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_cd_evento_andamento'' and rtrim(ltrim(A.PROC_cd_evento_andamento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_evento_andamento'' and rtrim(ltrim(A.PROC_ds_evento_andamento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_dt_vencimento'' and rtrim(ltrim(A.PROC_dt_vencimento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''ASC'' then A.PROC_ds_titular END ASC, 
 CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''DESC'' then A.PROC_ds_titular END DESC 
 ,  CASE when @sortField = ''PROC_cd_ultimo_evento'' and  @sortOrder=''ASC'' then A.PROC_cd_ultimo_evento END ASC, 
 CASE when @sortField = ''PROC_cd_ultimo_evento'' and  @sortOrder=''DESC'' then A.PROC_cd_ultimo_evento END DESC 
 ,  CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''ASC'' then A.PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''DESC'' then A.PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''ASC'' then A.PROC_ds_link END ASC, 
 CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''DESC'' then A.PROC_ds_link END DESC 
 ,  CASE when @sortField = ''PROC_cd_evento_andamento'' and  @sortOrder=''ASC'' then A.PROC_cd_evento_andamento END ASC, 
 CASE when @sortField = ''PROC_cd_evento_andamento'' and  @sortOrder=''DESC'' then A.PROC_cd_evento_andamento END DESC 
 ,  CASE when @sortField = ''PROC_ds_evento_andamento'' and  @sortOrder=''ASC'' then A.PROC_ds_evento_andamento END ASC, 
 CASE when @sortField = ''PROC_ds_evento_andamento'' and  @sortOrder=''DESC'' then A.PROC_ds_evento_andamento END DESC 
 ,  CASE when @sortField = ''PROC_dt_vencimento'' and  @sortOrder=''ASC'' then A.PROC_dt_vencimento END ASC, 
 CASE when @sortField = ''PROC_dt_vencimento'' and  @sortOrder=''DESC'' then A.PROC_dt_vencimento END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PRAN_processo_andamento where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAN_processo_andamento_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAN_processo_andamento_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRAN_processo_andamento
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAN_processo_andamento_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_cd_ultimo_evento varchar(20) null, 
PROC_ds_ultimo_evento varchar(1000) null, 
PROC_ds_link varchar(150) null, 
PROC_cd_evento_andamento varchar(20) not null, 
PROC_ds_evento_andamento varchar(1000) null, 
PROC_dt_vencimento datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.PROC_ds_titular as PROC_ds_titular, 
A.PROC_cd_ultimo_evento as PROC_cd_ultimo_evento, 
A.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
A.PROC_ds_link as PROC_ds_link, 
A.PROC_cd_evento_andamento as PROC_cd_evento_andamento, 
A.PROC_ds_evento_andamento as PROC_ds_evento_andamento, 
A.PROC_dt_vencimento as PROC_dt_vencimento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PRAN_processo_andamento A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PREV_processo_evento_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@PREV_cd_evento varchar(20) = null , 
@PREV_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PREV_processo_evento table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
PREV_id_evento int not null,
PREV_cd_evento varchar(20) not null, 
PREV_ds_evento varchar(3000) null, 
PREV_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null
)



insert into 
@tb_PREV_processo_evento
(PROC_cd_processo, 
PREV_id_evento,
PREV_cd_evento, 
PREV_ds_evento, 
PREV_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.PREV_id_evento as PREV_id_evento,
A.PREV_cd_evento as PREV_cd_evento, 
A.PREV_ds_evento as PREV_ds_evento, 
A.PREV_dt_ocorrencia as PREV_dt_ocorrencia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.PROC_ds_titular as PROC_ds_titular, 
B.PROC_vl_ano as PROC_vl_ano, 
B.PROC_nm_processo as PROC_nm_processo, 
B.PROC_id_processo as PROC_id_processo, 
B.FASE_cd_fase as FASE_cd_fase, 
B.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
B.PROC_ds_substancia as PROC_ds_substancia, 
B.PROC_ds_area as PROC_ds_area, 
B.PROC_ds_uso as PROC_ds_uso, 
B.PROC_ds_link as PROC_ds_link, 
B.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
B.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao

FROM 

DBDNPM..tb_PREV_processo_evento A, 
DBDNPM..tb_PROC_processo B

WHERE 


 -- Join: dbDNPM.tb_PREV_processo_evento x dbDNPM.tb_PROC_processo

A.PROC_cd_processo = B.PROC_cd_processo  AND 

(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@PREV_cd_evento is null or (@PREV_cd_evento is not null and A.PREV_cd_evento = @PREV_cd_evento)) 
 AND (@PREV_dt_ocorrencia is null or (@PREV_dt_ocorrencia is not null and A.PREV_dt_ocorrencia = @PREV_dt_ocorrencia)) 
 AND (@AUDT_dt_inclusao is null or (@AUDT_dt_inclusao is not null and A.AUDT_dt_inclusao = @AUDT_dt_inclusao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PREV_cd_evento'' and rtrim(ltrim(A.PREV_cd_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PREV_ds_evento'' and rtrim(ltrim(A.PREV_ds_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PREV_dt_ocorrencia'' and rtrim(ltrim(A.PREV_dt_ocorrencia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_titular'' and rtrim(ltrim(B.PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_vl_ano'' and rtrim(ltrim(B.PROC_vl_ano)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_nm_processo'' and rtrim(ltrim(B.PROC_nm_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_id_processo'' and rtrim(ltrim(B.PROC_id_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''FASE_cd_fase'' and rtrim(ltrim(B.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_ultimo_evento'' and rtrim(ltrim(B.PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_substancia'' and rtrim(ltrim(B.PROC_ds_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_area'' and rtrim(ltrim(B.PROC_ds_area)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_uso'' and rtrim(ltrim(B.PROC_ds_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_link'' and rtrim(ltrim(B.PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNFE_cd_unidade_federativa'' and rtrim(ltrim(B.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_fl_tipo_inclusao'' and rtrim(ltrim(B.PROC_fl_tipo_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''PREV_cd_evento'' and  @sortOrder=''ASC'' then A.PREV_cd_evento END ASC, 
 CASE when @sortField = ''PREV_cd_evento'' and  @sortOrder=''DESC'' then A.PREV_cd_evento END DESC 
 ,  CASE when @sortField = ''PREV_ds_evento'' and  @sortOrder=''ASC'' then A.PREV_ds_evento END ASC, 
 CASE when @sortField = ''PREV_ds_evento'' and  @sortOrder=''DESC'' then A.PREV_ds_evento END DESC 
 ,  CASE when @sortField = ''PREV_dt_ocorrencia'' and  @sortOrder=''ASC'' then A.PREV_dt_ocorrencia END ASC, 
 CASE when @sortField = ''PREV_dt_ocorrencia'' and  @sortOrder=''DESC'' then A.PREV_dt_ocorrencia END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 
 ,  CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''ASC'' then B.PROC_ds_titular END ASC, 
 CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''DESC'' then B.PROC_ds_titular END DESC 
 ,  CASE when @sortField = ''PROC_vl_ano'' and  @sortOrder=''ASC'' then B.PROC_vl_ano END ASC, 
 CASE when @sortField = ''PROC_vl_ano'' and  @sortOrder=''DESC'' then B.PROC_vl_ano END DESC 
 ,  CASE when @sortField = ''PROC_nm_processo'' and  @sortOrder=''ASC'' then B.PROC_nm_processo END ASC, 
 CASE when @sortField = ''PROC_nm_processo'' and  @sortOrder=''DESC'' then B.PROC_nm_processo END DESC 
 ,  CASE when @sortField = ''PROC_id_processo'' and  @sortOrder=''ASC'' then B.PROC_id_processo END ASC, 
 CASE when @sortField = ''PROC_id_processo'' and  @sortOrder=''DESC'' then B.PROC_id_processo END DESC 
 ,  CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''ASC'' then B.FASE_cd_fase END ASC, 
 CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''DESC'' then B.FASE_cd_fase END DESC 
 ,  CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''ASC'' then B.PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''DESC'' then B.PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = ''PROC_ds_substancia'' and  @sortOrder=''ASC'' then B.PROC_ds_substancia END ASC, 
 CASE when @sortField = ''PROC_ds_substancia'' and  @sortOrder=''DESC'' then B.PROC_ds_substancia END DESC 
 ,  CASE when @sortField = ''PROC_ds_area'' and  @sortOrder=''ASC'' then B.PROC_ds_area END ASC, 
 CASE when @sortField = ''PROC_ds_area'' and  @sortOrder=''DESC'' then B.PROC_ds_area END DESC 
 ,  CASE when @sortField = ''PROC_ds_uso'' and  @sortOrder=''ASC'' then B.PROC_ds_uso END ASC, 
 CASE when @sortField = ''PROC_ds_uso'' and  @sortOrder=''DESC'' then B.PROC_ds_uso END DESC 
 ,  CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''ASC'' then B.PROC_ds_link END ASC, 
 CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''DESC'' then B.PROC_ds_link END DESC 
 ,  CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''ASC'' then B.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''DESC'' then B.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = ''PROC_fl_tipo_inclusao'' and  @sortOrder=''ASC'' then B.PROC_fl_tipo_inclusao END ASC, 
 CASE when @sortField = ''PROC_fl_tipo_inclusao'' and  @sortOrder=''DESC'' then B.PROC_fl_tipo_inclusao END DESC 

 
SELECT * FROM 
@tb_PREV_processo_evento where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PREV_processo_evento_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



 -- Join: dbDNPM.tb_PREV_processo_evento x dbDNPM.tb_PROC_processo

SET @whereAux = ''A.PROC_cd_processo = B.PROC_cd_processo ''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
  PREV_id_evento int not null,
PREV_cd_evento varchar(20) not null, 
PREV_ds_evento varchar(3000) null, 
PREV_dt_ocorrencia datetime not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.PREV_id_evento as PREV_id_evento,
A.PREV_cd_evento as PREV_cd_evento, 
A.PREV_ds_evento as PREV_ds_evento, 
A.PREV_dt_ocorrencia as PREV_dt_ocorrencia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.PROC_ds_titular as PROC_ds_titular, 
B.PROC_vl_ano as PROC_vl_ano, 
B.PROC_nm_processo as PROC_nm_processo, 
B.PROC_id_processo as PROC_id_processo, 
B.FASE_cd_fase as FASE_cd_fase, 
B.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
B.PROC_ds_substancia as PROC_ds_substancia, 
B.PROC_ds_area as PROC_ds_area, 
B.PROC_ds_uso as PROC_ds_uso, 
B.PROC_ds_link as PROC_ds_link, 
B.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
B.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao '' 
+ '' from 

DBDNPM..tb_PREV_processo_evento A, 
DBDNPM..tb_PROC_processo B '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRMP_processo_mprima_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRMP_processo_mprima_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRMP_processo_mprima
CREATE PROCEDURE [dbo].[sp_sel_tb_PRMP_processo_mprima_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PRMP_processo_mprima table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
MPRI_nm_mprima varchar(100) not null, 
PRMP_vl_mprima decimal(15, 3) null, 
PRMP_un_mprima varchar(10) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PRMP_processo_mprima
(PROC_cd_processo, 
ORGA_nm_orgao, 
MPRI_nm_mprima, 
PRMP_vl_mprima, 
PRMP_un_mprima, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.MPRI_nm_mprima as MPRI_nm_mprima, 
A.PRMP_vl_mprima as PRMP_vl_mprima, 
A.PRMP_un_mprima as PRMP_un_mprima, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PRMP_processo_mprima A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and A.MPRI_nm_mprima = @MPRI_nm_mprima)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''MPRI_nm_mprima'' and rtrim(ltrim(A.MPRI_nm_mprima)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRMP_vl_mprima'' and rtrim(ltrim(A.PRMP_vl_mprima)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRMP_un_mprima'' and rtrim(ltrim(A.PRMP_un_mprima)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''MPRI_nm_mprima'' and  @sortOrder=''ASC'' then A.MPRI_nm_mprima END ASC, 
 CASE when @sortField = ''MPRI_nm_mprima'' and  @sortOrder=''DESC'' then A.MPRI_nm_mprima END DESC 
 ,  CASE when @sortField = ''PRMP_vl_mprima'' and  @sortOrder=''ASC'' then A.PRMP_vl_mprima END ASC, 
 CASE when @sortField = ''PRMP_vl_mprima'' and  @sortOrder=''DESC'' then A.PRMP_vl_mprima END DESC 
 ,  CASE when @sortField = ''PRMP_un_mprima'' and  @sortOrder=''ASC'' then A.PRMP_un_mprima END ASC, 
 CASE when @sortField = ''PRMP_un_mprima'' and  @sortOrder=''DESC'' then A.PRMP_un_mprima END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PRMP_processo_mprima where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRMP_processo_mprima_produto_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRMP_processo_mprima_produto_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRMP_processo_mprima
CREATE PROCEDURE [dbo].[sp_sel_tb_PRMP_processo_mprima_produto_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PRMP_processo_mprima table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
MPRI_nm_mprima varchar(100) not null, 
PRMP_vl_mprima decimal(15, 3) null, 
PRMP_un_mprima varchar(10) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null,
PROD_nm_produto varchar(100)  null, 
PRPD_vl_produto decimal(15, 3) null, 
PRPD_un_produto varchar(10) null, 
PRPD_qt_produto varchar(50) null,
UPRD_nm_uso varchar(100) null, 
PRMP_qt_mprima varchar(50) null,
PRMP_ds_mprima varchar(200) null
)



insert into 
@tb_PRMP_processo_mprima
(PROC_cd_processo, 
ORGA_nm_orgao, 
MPRI_nm_mprima, 
PRMP_vl_mprima, 
PRMP_un_mprima, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao,
PROD_nm_produto,
PRPD_vl_produto,
PRPD_un_produto,
PRPD_qt_produto,
UPRD_nm_uso,
PRMP_qt_mprima,
PRMP_ds_mprima) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.MPRI_nm_mprima as MPRI_nm_mprima, 
A.PRMP_vl_mprima as PRMP_vl_mprima, 
A.PRMP_un_mprima as PRMP_un_mprima, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao,
isnull(B.PROD_nm_produto,''Nenhum produto informado'') as PROD_nm_produto, 
B.PRPD_vl_produto as PRPD_vl_produto, 
B.PRPD_un_produto as PRPD_un_produto, 
ltrim(rtrim(convert(varchar(20),isnull(B.PRPD_vl_produto,0)) + '' '' + ISNULL(B.PRPD_un_produto,''''))) as PRPD_qt_produto,
B.UPRD_nm_uso as UPRD_nm_uso, 
ltrim(rtrim(convert(varchar(20),isnull(A.PRMP_vl_mprima,0)) + '' '' + ISNULL(A.PRMP_un_mprima,''''))) as PRMP_qt_mprima,

A.MPRI_nm_mprima + '' ('' +
ltrim(rtrim(convert(varchar(20),isnull(A.PRMP_vl_mprima,0)) + '' '' + ISNULL(A.PRMP_un_mprima,'''')))
+ '') ''
 as PRMP_ds_mprima
 
FROM 

DBDNPM..tb_PRMP_processo_mprima A
left outer join 
DBDNPM..tb_PRPD_processo_produto B

on (A.PROC_cd_processo = B.PROC_cd_processo AND A.ORGA_nm_orgao = B.ORGA_nm_orgao AND
A.MPRI_nm_mprima = B.MPRI_nm_mprima)

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and A.MPRI_nm_mprima = @MPRI_nm_mprima)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''MPRI_nm_mprima'' and rtrim(ltrim(A.MPRI_nm_mprima)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRMP_vl_mprima'' and rtrim(ltrim(A.PRMP_vl_mprima)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRMP_un_mprima'' and rtrim(ltrim(A.PRMP_un_mprima)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''MPRI_nm_mprima'' and  @sortOrder=''ASC'' then A.MPRI_nm_mprima END ASC, 
 CASE when @sortField = ''MPRI_nm_mprima'' and  @sortOrder=''DESC'' then A.MPRI_nm_mprima END DESC 
 ,  CASE when @sortField = ''PRMP_vl_mprima'' and  @sortOrder=''ASC'' then A.PRMP_vl_mprima END ASC, 
 CASE when @sortField = ''PRMP_vl_mprima'' and  @sortOrder=''DESC'' then A.PRMP_vl_mprima END DESC 
 ,  CASE when @sortField = ''PRMP_un_mprima'' and  @sortOrder=''ASC'' then A.PRMP_un_mprima END ASC, 
 CASE when @sortField = ''PRMP_un_mprima'' and  @sortOrder=''DESC'' then A.PRMP_un_mprima END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PRMP_processo_mprima where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRMP_processo_mprima_cons]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRMP_processo_mprima_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRMP_processo_mprima
CREATE PROCEDURE [dbo].[sp_sel_tb_PRMP_processo_mprima_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
MPRI_nm_mprima varchar(100) not null, 
PRMP_vl_mprima decimal(15, 3) null, 
PRMP_un_mprima varchar(10) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.MPRI_nm_mprima as MPRI_nm_mprima, 
A.PRMP_vl_mprima as PRMP_vl_mprima, 
A.PRMP_un_mprima as PRMP_un_mprima, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PRMP_processo_mprima A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROD_produto_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROD_produto_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROD_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_PROD_produto_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROD_nm_produto varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PROD_produto table (
id int identity primary key, 
PROD_nm_produto varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PROD_produto
(PROD_nm_produto, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROD_nm_produto as PROD_nm_produto, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PROD_produto A

WHERE 




(@PROD_nm_produto is null or (@PROD_nm_produto is not null and A.PROD_nm_produto = @PROD_nm_produto)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROD_nm_produto'' and rtrim(ltrim(A.PROD_nm_produto)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROD_nm_produto'' and  @sortOrder=''ASC'' then A.PROD_nm_produto END ASC, 
 CASE when @sortField = ''PROD_nm_produto'' and  @sortOrder=''DESC'' then A.PROD_nm_produto END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PROD_produto where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROD_produto_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROD_produto_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROD_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_PROD_produto_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROD_nm_produto varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROD_nm_produto as PROD_nm_produto, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PROD_produto A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_sel_tb_PROC_processo_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



 -- Join: dbDNPM.tb_PROC_processo x dbDNPM.tb_FASE_fase
 -- Join: dbDNPM.tb_PROC_processo x dbDNPM.tb_UNFE_unidade_federativa

SET @whereAux = ''
A.FASE_cd_fase = B.FASE_cd_fase and 

A.UNFE_cd_unidade_federativa = C.UNFE_cd_unidade_federativa ''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
FASE_nm_fase varchar(100) not null, 
UNFE_nm_unidade_federativa varchar(100) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.PROC_ds_titular as PROC_ds_titular, 
A.PROC_vl_ano as PROC_vl_ano, 
A.PROC_nm_processo as PROC_nm_processo, 
A.PROC_id_processo as PROC_id_processo, 
A.FASE_cd_fase as FASE_cd_fase, 
A.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
A.PROC_ds_substancia as PROC_ds_substancia, 
A.PROC_ds_area as PROC_ds_area, 
A.PROC_ds_uso as PROC_ds_uso, 
A.PROC_ds_link as PROC_ds_link, 
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.FASE_nm_fase as FASE_nm_fase, 
C.UNFE_nm_unidade_federativa as UNFE_nm_unidade_federativa '' 
+ '' from 

DBDNPM..tb_PROC_processo A, 
DBDNPM..tb_FASE_fase B, 
DBDNPM..tb_UNFE_unidade_federativa C '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROP_processo_operador_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
-- exec sp_sel_tb_PROP_processo_operador_rel 0,0,null,null,null,null
 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PROP_processo_operador table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
OPER_cd_operador varchar(20) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null,
OPER_ds_email varchar(200) null,
OPER_fl_alerta char(1) null
)



insert into 
@tb_PROP_processo_operador
(PROC_cd_processo, 
OPER_cd_operador, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao,
OPER_ds_email,
OPER_fl_alerta) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.OPER_cd_operador as OPER_cd_operador, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.PROC_ds_titular as PROC_ds_titular, 
B.PROC_vl_ano as PROC_vl_ano, 
B.PROC_nm_processo as PROC_nm_processo, 
B.PROC_id_processo as PROC_id_processo, 
B.FASE_cd_fase as FASE_cd_fase, 
B.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
B.PROC_ds_substancia as PROC_ds_substancia, 
B.PROC_ds_area as PROC_ds_area, 
B.PROC_ds_uso as PROC_ds_uso, 
B.PROC_ds_link as PROC_ds_link, 
B.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
B.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao,
C.OPER_ds_email, 
C.OPER_fl_alerta


FROM 

DBDNPM..tb_PROP_processo_operador A, 
DBDNPM..tb_PROC_processo B,
DBDNPM..tb_OPER_operador C

WHERE 


 -- Join: dbDNPM.tb_PROP_processo_operador x dbDNPM.tb_PROC_processo

A.PROC_cd_processo = B.PROC_cd_processo  AND 

A.OPER_cd_operador = C.OPER_cd_operador  AND 

(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@OPER_cd_operador is null or (@OPER_cd_operador is not null and A.OPER_cd_operador = @OPER_cd_operador)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''OPER_cd_operador'' and rtrim(ltrim(A.OPER_cd_operador)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_titular'' and rtrim(ltrim(B.PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_vl_ano'' and rtrim(ltrim(B.PROC_vl_ano)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_nm_processo'' and rtrim(ltrim(B.PROC_nm_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_id_processo'' and rtrim(ltrim(B.PROC_id_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''FASE_cd_fase'' and rtrim(ltrim(B.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_ultimo_evento'' and rtrim(ltrim(B.PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_substancia'' and rtrim(ltrim(B.PROC_ds_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_area'' and rtrim(ltrim(B.PROC_ds_area)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_uso'' and rtrim(ltrim(B.PROC_ds_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_link'' and rtrim(ltrim(B.PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNFE_cd_unidade_federativa'' and rtrim(ltrim(B.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_fl_tipo_inclusao'' and rtrim(ltrim(B.PROC_fl_tipo_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''OPER_cd_operador'' and  @sortOrder=''ASC'' then A.OPER_cd_operador END ASC, 
 CASE when @sortField = ''OPER_cd_operador'' and  @sortOrder=''DESC'' then A.OPER_cd_operador END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 
 ,  CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''ASC'' then B.PROC_ds_titular END ASC, 
 CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''DESC'' then B.PROC_ds_titular END DESC 
 ,  CASE when @sortField = ''PROC_vl_ano'' and  @sortOrder=''ASC'' then B.PROC_vl_ano END ASC, 
 CASE when @sortField = ''PROC_vl_ano'' and  @sortOrder=''DESC'' then B.PROC_vl_ano END DESC 
 ,  CASE when @sortField = ''PROC_nm_processo'' and  @sortOrder=''ASC'' then B.PROC_nm_processo END ASC, 
 CASE when @sortField = ''PROC_nm_processo'' and  @sortOrder=''DESC'' then B.PROC_nm_processo END DESC 
 ,  CASE when @sortField = ''PROC_id_processo'' and  @sortOrder=''ASC'' then B.PROC_id_processo END ASC, 
 CASE when @sortField = ''PROC_id_processo'' and  @sortOrder=''DESC'' then B.PROC_id_processo END DESC 
 ,  CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''ASC'' then B.FASE_cd_fase END ASC, 
 CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''DESC'' then B.FASE_cd_fase END DESC 
 ,  CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''ASC'' then B.PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''DESC'' then B.PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = ''PROC_ds_substancia'' and  @sortOrder=''ASC'' then B.PROC_ds_substancia END ASC, 
 CASE when @sortField = ''PROC_ds_substancia'' and  @sortOrder=''DESC'' then B.PROC_ds_substancia END DESC 
 ,  CASE when @sortField = ''PROC_ds_area'' and  @sortOrder=''ASC'' then B.PROC_ds_area END ASC, 
 CASE when @sortField = ''PROC_ds_area'' and  @sortOrder=''DESC'' then B.PROC_ds_area END DESC 
 ,  CASE when @sortField = ''PROC_ds_uso'' and  @sortOrder=''ASC'' then B.PROC_ds_uso END ASC, 
 CASE when @sortField = ''PROC_ds_uso'' and  @sortOrder=''DESC'' then B.PROC_ds_uso END DESC 
 ,  CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''ASC'' then B.PROC_ds_link END ASC, 
 CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''DESC'' then B.PROC_ds_link END DESC 
 ,  CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''ASC'' then B.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''DESC'' then B.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = ''PROC_fl_tipo_inclusao'' and  @sortOrder=''ASC'' then B.PROC_fl_tipo_inclusao END ASC, 
 CASE when @sortField = ''PROC_fl_tipo_inclusao'' and  @sortOrder=''DESC'' then B.PROC_fl_tipo_inclusao END DESC 

 
SELECT * FROM 
@tb_PROP_processo_operador where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROP_processo_operador_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



 -- Join: dbDNPM.tb_PROP_processo_operador x dbDNPM.tb_PROC_processo

SET @whereAux = ''A.PROC_cd_processo = B.PROC_cd_processo ''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
OPER_cd_operador varchar(20) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.OPER_cd_operador as OPER_cd_operador, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.PROC_ds_titular as PROC_ds_titular, 
B.PROC_vl_ano as PROC_vl_ano, 
B.PROC_nm_processo as PROC_nm_processo, 
B.PROC_id_processo as PROC_id_processo, 
B.FASE_cd_fase as FASE_cd_fase, 
B.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
B.PROC_ds_substancia as PROC_ds_substancia, 
B.PROC_ds_area as PROC_ds_area, 
B.PROC_ds_uso as PROC_ds_uso, 
B.PROC_ds_link as PROC_ds_link, 
B.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
B.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao '' 
+ '' from 

DBDNPM..tb_PROP_processo_operador A, 
DBDNPM..tb_PROC_processo B '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRPD_processo_produto_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRPD_processo_produto_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRPD_processo_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_PRPD_processo_produto_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null , 
@PROD_nm_produto varchar(100) = null , 
@UPRD_nm_uso varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PRPD_processo_produto table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
MPRI_nm_mprima varchar(100) not null, 
PRMP_vl_mprima decimal(15,2) null,
PRMP_un_mprima varchar(10) null,
PRMP_qt_mprima varchar(50) null,
PROD_nm_produto varchar(100) not null, 
PRPD_vl_produto decimal(15, 3) null, 
PRPD_un_produto varchar(10) null, 
PRPD_qt_produto varchar(50) null,
UPRD_nm_uso varchar(100) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null,
PRMP_ds_mprima varchar(200) null
)



insert into 
@tb_PRPD_processo_produto
(PROC_cd_processo, 
ORGA_nm_orgao, 
MPRI_nm_mprima, 
PRMP_vl_mprima,
PRMP_un_mprima,
PRMP_qt_mprima,
PROD_nm_produto, 
PRPD_vl_produto, 
PRPD_un_produto, 
PRPD_qt_produto,
UPRD_nm_uso, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao,
PRMP_ds_mprima) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.MPRI_nm_mprima as MPRI_nm_mprima, 
B.PRMP_vl_mprima as PRMP_vl_mprima,
B.PRMP_un_mprima as PRMP_un_mprima,
ltrim(rtrim(convert(varchar(20),isnull(B.PRMP_vl_mprima,0)) + '' '' + ISNULL(B.PRMP_un_mprima,''''))) as PRMP_qt_mprima,
A.PROD_nm_produto as PROD_nm_produto, 
A.PRPD_vl_produto as PRPD_vl_produto, 
A.PRPD_un_produto as PRPD_un_produto, 
ltrim(rtrim(convert(varchar(20),isnull(A.PRPD_vl_produto,0)) + '' '' + ISNULL(A.PRPD_un_produto,''''))) as PRPD_qt_produto,
A.UPRD_nm_uso as UPRD_nm_uso, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao,

A.MPRI_nm_mprima + '' ('' +
ltrim(rtrim(convert(varchar(20),isnull(B.PRMP_vl_mprima,0)) + '' '' + ISNULL(B.PRMP_un_mprima,'''')))
+ '') ''
 as PRMP_ds_mprima


FROM 

DBDNPM..tb_PRPD_processo_produto A,
DBDNPM..tb_PRMP_processo_mprima B

WHERE 

A.PROC_cd_processo = B.PROC_cd_processo AND
A.ORGA_nm_orgao = B.ORGA_nm_orgao AND
A.MPRI_nm_mprima = B.MPRI_nm_mprima AND

(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and A.MPRI_nm_mprima = @MPRI_nm_mprima)) 
 AND (@PROD_nm_produto is null or (@PROD_nm_produto is not null and A.PROD_nm_produto = @PROD_nm_produto)) 
 AND (@UPRD_nm_uso is null or (@UPRD_nm_uso is not null and A.UPRD_nm_uso = @UPRD_nm_uso)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''MPRI_nm_mprima'' and rtrim(ltrim(A.MPRI_nm_mprima)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROD_nm_produto'' and rtrim(ltrim(A.PROD_nm_produto)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRPD_vl_produto'' and rtrim(ltrim(A.PRPD_vl_produto)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRPD_un_produto'' and rtrim(ltrim(A.PRPD_un_produto)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UPRD_nm_uso'' and rtrim(ltrim(A.UPRD_nm_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''MPRI_nm_mprima'' and  @sortOrder=''ASC'' then A.MPRI_nm_mprima END ASC, 
 CASE when @sortField = ''MPRI_nm_mprima'' and  @sortOrder=''DESC'' then A.MPRI_nm_mprima END DESC 
 ,  CASE when @sortField = ''PROD_nm_produto'' and  @sortOrder=''ASC'' then A.PROD_nm_produto END ASC, 
 CASE when @sortField = ''PROD_nm_produto'' and  @sortOrder=''DESC'' then A.PROD_nm_produto END DESC 
 ,  CASE when @sortField = ''PRPD_vl_produto'' and  @sortOrder=''ASC'' then A.PRPD_vl_produto END ASC, 
 CASE when @sortField = ''PRPD_vl_produto'' and  @sortOrder=''DESC'' then A.PRPD_vl_produto END DESC 
 ,  CASE when @sortField = ''PRPD_un_produto'' and  @sortOrder=''ASC'' then A.PRPD_un_produto END ASC, 
 CASE when @sortField = ''PRPD_un_produto'' and  @sortOrder=''DESC'' then A.PRPD_un_produto END DESC 
 ,  CASE when @sortField = ''UPRD_nm_uso'' and  @sortOrder=''ASC'' then A.UPRD_nm_uso END ASC, 
 CASE when @sortField = ''UPRD_nm_uso'' and  @sortOrder=''DESC'' then A.UPRD_nm_uso END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PRPD_processo_produto where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRPD_processo_produto_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRPD_processo_produto_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRPD_processo_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_PRPD_processo_produto_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
MPRI_nm_mprima varchar(100) not null, 
PROD_nm_produto varchar(100) not null, 
PRPD_vl_produto decimal(15, 3) null, 
PRPD_un_produto varchar(10) null, 
UPRD_nm_uso varchar(100) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.MPRI_nm_mprima as MPRI_nm_mprima, 
A.PROD_nm_produto as PROD_nm_produto, 
A.PRPD_vl_produto as PRPD_vl_produto, 
A.PRPD_un_produto as PRPD_un_produto, 
A.UPRD_nm_uso as UPRD_nm_uso, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PRPD_processo_produto A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRSD_processo_sd_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRSD_processo_sd_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRSD_processo_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_PRSD_processo_sd_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PRSD_nm_sd varchar(30) = null , 
@PRSD_dt_sd datetime = null , 
@PRSD_nm_prc varchar(30) = null , 
@PRSD_nm_doc varchar(30) = null , 
@PRSD_dt_ini datetime = null , 
@SISD_nm_situacao_sd varchar(100) = null , 
@OSSD_nm_objeto varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PRSD_processo_sd table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PRSD_nm_sd varchar(30) not null, 
PRSD_dt_sd datetime null, 
PRSD_nm_prc varchar(30) null, 
PRSD_nm_doc varchar(30) null, 
PRSD_dt_ini datetime null, 
SISD_nm_situacao_sd varchar(100) null, 
OSSD_nm_objeto varchar(100) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null,
PRSD_dt_fim datetime null
)



insert into 
@tb_PRSD_processo_sd
(PROC_cd_processo, 
ORGA_nm_orgao, 
PRSD_nm_sd, 
PRSD_dt_sd, 
PRSD_nm_prc, 
PRSD_nm_doc, 
PRSD_dt_ini, 
SISD_nm_situacao_sd, 
OSSD_nm_objeto, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao,
PRSD_dt_fim) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PRSD_nm_sd as PRSD_nm_sd, 
A.PRSD_dt_sd as PRSD_dt_sd, 
A.PRSD_nm_prc as PRSD_nm_prc, 
A.PRSD_nm_doc as PRSD_nm_doc, 
A.PRSD_dt_ini as PRSD_dt_ini, 
A.SISD_nm_situacao_sd as SISD_nm_situacao_sd, 
A.OSSD_nm_objeto as OSSD_nm_objeto, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao,
A.PRSD_dt_fim as PRSD_dt_fim

FROM 

DBDNPM..tb_PRSD_processo_sd A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@PRSD_nm_sd is null or (@PRSD_nm_sd is not null and A.PRSD_nm_sd = @PRSD_nm_sd)) 
 AND (@PRSD_dt_sd is null or (@PRSD_dt_sd is not null and A.PRSD_dt_sd = @PRSD_dt_sd)) 
 AND (@PRSD_nm_prc is null or (@PRSD_nm_prc is not null and A.PRSD_nm_prc = @PRSD_nm_prc)) 
 AND (@PRSD_nm_doc is null or (@PRSD_nm_doc is not null and A.PRSD_nm_doc = @PRSD_nm_doc)) 
 AND (@PRSD_dt_ini is null or (@PRSD_dt_ini is not null and A.PRSD_dt_ini = @PRSD_dt_ini)) 
 AND (@SISD_nm_situacao_sd is null or (@SISD_nm_situacao_sd is not null and A.SISD_nm_situacao_sd = @SISD_nm_situacao_sd)) 
 AND (@OSSD_nm_objeto is null or (@OSSD_nm_objeto is not null and A.OSSD_nm_objeto = @OSSD_nm_objeto)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRSD_nm_sd'' and rtrim(ltrim(A.PRSD_nm_sd)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRSD_dt_sd'' and rtrim(ltrim(A.PRSD_dt_sd)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRSD_nm_prc'' and rtrim(ltrim(A.PRSD_nm_prc)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRSD_nm_doc'' and rtrim(ltrim(A.PRSD_nm_doc)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRSD_dt_ini'' and rtrim(ltrim(A.PRSD_dt_ini)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SISD_nm_situacao_sd'' and rtrim(ltrim(A.SISD_nm_situacao_sd)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''OSSD_nm_objeto'' and rtrim(ltrim(A.OSSD_nm_objeto)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PRSD_dt_fim'' and rtrim(ltrim(A.PRSD_dt_fim)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''PRSD_nm_sd'' and  @sortOrder=''ASC'' then A.PRSD_nm_sd END ASC, 
 CASE when @sortField = ''PRSD_nm_sd'' and  @sortOrder=''DESC'' then A.PRSD_nm_sd END DESC 
 ,  CASE when @sortField = ''PRSD_dt_sd'' and  @sortOrder=''ASC'' then A.PRSD_dt_sd END ASC, 
 CASE when @sortField = ''PRSD_dt_sd'' and  @sortOrder=''DESC'' then A.PRSD_dt_sd END DESC 
 ,  CASE when @sortField = ''PRSD_nm_prc'' and  @sortOrder=''ASC'' then A.PRSD_nm_prc END ASC, 
 CASE when @sortField = ''PRSD_nm_prc'' and  @sortOrder=''DESC'' then A.PRSD_nm_prc END DESC 
 ,  CASE when @sortField = ''PRSD_nm_doc'' and  @sortOrder=''ASC'' then A.PRSD_nm_doc END ASC, 
 CASE when @sortField = ''PRSD_nm_doc'' and  @sortOrder=''DESC'' then A.PRSD_nm_doc END DESC 
 ,  CASE when @sortField = ''PRSD_dt_ini'' and  @sortOrder=''ASC'' then A.PRSD_dt_ini END ASC, 
 CASE when @sortField = ''PRSD_dt_ini'' and  @sortOrder=''DESC'' then A.PRSD_dt_ini END DESC 
 ,  CASE when @sortField = ''SISD_nm_situacao_sd'' and  @sortOrder=''ASC'' then A.SISD_nm_situacao_sd END ASC, 
 CASE when @sortField = ''SISD_nm_situacao_sd'' and  @sortOrder=''DESC'' then A.SISD_nm_situacao_sd END DESC 
 ,  CASE when @sortField = ''OSSD_nm_objeto'' and  @sortOrder=''ASC'' then A.OSSD_nm_objeto END ASC, 
 CASE when @sortField = ''OSSD_nm_objeto'' and  @sortOrder=''DESC'' then A.OSSD_nm_objeto END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 
  ,  CASE when @sortField = ''PRSD_dt_fim'' and  @sortOrder=''ASC'' then A.PRSD_dt_fim END ASC, 
 CASE when @sortField = ''PRSD_dt_fim'' and  @sortOrder=''DESC'' then A.PRSD_dt_fim END DESC 

 
SELECT * FROM 
@tb_PRSD_processo_sd where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRSD_processo_sd_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRSD_processo_sd_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PRSD_processo_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_PRSD_processo_sd_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PRSD_nm_sd varchar(30) not null, 
PRSD_dt_sd datetime null, 
PRSD_nm_prc varchar(30) null, 
PRSD_nm_doc varchar(30) null, 
PRSD_dt_ini datetime null, 
SISD_nm_situacao_sd varchar(100) null, 
OSSD_nm_objeto varchar(100) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null,
PRSD_dt_fim datetime null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PRSD_nm_sd as PRSD_nm_sd, 
A.PRSD_dt_sd as PRSD_dt_sd, 
A.PRSD_nm_prc as PRSD_nm_prc, 
A.PRSD_nm_doc as PRSD_nm_doc, 
A.PRSD_dt_ini as PRSD_dt_ini, 
A.SISD_nm_situacao_sd as SISD_nm_situacao_sd, 
A.OSSD_nm_objeto as OSSD_nm_objeto, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao,
A.PRSD_dt_fim as PRSD_dt_fim '' 
+ '' from 

DBDNPM..tb_PRSD_processo_sd A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PSUB_processo_substancia_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PSUB_processo_substancia_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PSUB_processo_substancia
CREATE PROCEDURE [dbo].[sp_sel_tb_PSUB_processo_substancia_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@SUBS_nm_substancia varchar(100) = null , 
@TUSO_nm_uso varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PSUB_processo_substancia table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
SUBS_nm_substancia varchar(100) not null, 
TUSO_nm_uso varchar(100) not null, 
PSUB_dt_inicio date null, 
PSUB_dt_fim date null, 
PSUB_ds_motivo varchar(500) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PSUB_processo_substancia
(PROC_cd_processo, 
SUBS_nm_substancia, 
TUSO_nm_uso, 
PSUB_dt_inicio, 
PSUB_dt_fim, 
PSUB_ds_motivo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.SUBS_nm_substancia as SUBS_nm_substancia, 
A.TUSO_nm_uso as TUSO_nm_uso, 
A.PSUB_dt_inicio as PSUB_dt_inicio, 
A.PSUB_dt_fim as PSUB_dt_fim, 
A.PSUB_ds_motivo as PSUB_ds_motivo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PSUB_processo_substancia A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@SUBS_nm_substancia is null or (@SUBS_nm_substancia is not null and A.SUBS_nm_substancia = @SUBS_nm_substancia)) 
 AND (@TUSO_nm_uso is null or (@TUSO_nm_uso is not null and A.TUSO_nm_uso = @TUSO_nm_uso)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SUBS_nm_substancia'' and rtrim(ltrim(A.SUBS_nm_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TUSO_nm_uso'' and rtrim(ltrim(A.TUSO_nm_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PSUB_dt_inicio'' and rtrim(ltrim(A.PSUB_dt_inicio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PSUB_dt_fim'' and rtrim(ltrim(A.PSUB_dt_fim)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PSUB_ds_motivo'' and rtrim(ltrim(A.PSUB_ds_motivo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''SUBS_nm_substancia'' and  @sortOrder=''ASC'' then A.SUBS_nm_substancia END ASC, 
 CASE when @sortField = ''SUBS_nm_substancia'' and  @sortOrder=''DESC'' then A.SUBS_nm_substancia END DESC 
 ,  CASE when @sortField = ''TUSO_nm_uso'' and  @sortOrder=''ASC'' then A.TUSO_nm_uso END ASC, 
 CASE when @sortField = ''TUSO_nm_uso'' and  @sortOrder=''DESC'' then A.TUSO_nm_uso END DESC 
 ,  CASE when @sortField = ''PSUB_dt_inicio'' and  @sortOrder=''ASC'' then A.PSUB_dt_inicio END ASC, 
 CASE when @sortField = ''PSUB_dt_inicio'' and  @sortOrder=''DESC'' then A.PSUB_dt_inicio END DESC 
 ,  CASE when @sortField = ''PSUB_dt_fim'' and  @sortOrder=''ASC'' then A.PSUB_dt_fim END ASC, 
 CASE when @sortField = ''PSUB_dt_fim'' and  @sortOrder=''DESC'' then A.PSUB_dt_fim END DESC 
 ,  CASE when @sortField = ''PSUB_ds_motivo'' and  @sortOrder=''ASC'' then A.PSUB_ds_motivo END ASC, 
 CASE when @sortField = ''PSUB_ds_motivo'' and  @sortOrder=''DESC'' then A.PSUB_ds_motivo END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PSUB_processo_substancia where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PSUB_processo_substancia_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PSUB_processo_substancia_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PSUB_processo_substancia
CREATE PROCEDURE [dbo].[sp_sel_tb_PSUB_processo_substancia_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
SUBS_nm_substancia varchar(100) not null, 
TUSO_nm_uso varchar(100) not null, 
PSUB_dt_inicio date null, 
PSUB_dt_fim date null, 
PSUB_ds_motivo varchar(500) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.SUBS_nm_substancia as SUBS_nm_substancia, 
A.TUSO_nm_uso as TUSO_nm_uso, 
A.PSUB_dt_inicio as PSUB_dt_inicio, 
A.PSUB_dt_fim as PSUB_dt_fim, 
A.PSUB_ds_motivo as PSUB_ds_motivo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PSUB_processo_substancia A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PTIT_processo_titulo_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PTIT_processo_titulo_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PTIT_processo_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_PTIT_processo_titulo_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PTIT_nm_titulo varchar(50) = null , 
@TTIT_ds_tipo_titulo varchar(100) = null , 
@SITU_ds_situacao_titulo varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PTIT_processo_titulo table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PTIT_nm_titulo varchar(50) not null, 
PTIT_ds_titulo varchar(300) not null, 
TTIT_ds_tipo_titulo varchar(100) not null, 
SITU_ds_situacao_titulo varchar(100) null, 
PTIT_dt_publicacao datetime null, 
PTIT_dt_vencimento datetime null, 
PTIT_ds_nome_documento varchar(1000) null, 
PTIT_ds_local_documento varchar(1000) null, 
PTIT_ds_rede_documento varchar(1000) null, 
PTIT_ds_path_documento varchar(1000) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_PTIT_processo_titulo
(PROC_cd_processo, 
ORGA_nm_orgao, 
PTIT_nm_titulo, 
PTIT_ds_titulo, 
TTIT_ds_tipo_titulo, 
SITU_ds_situacao_titulo, 
PTIT_dt_publicacao, 
PTIT_dt_vencimento, 
PTIT_ds_nome_documento, 
PTIT_ds_local_documento, 
PTIT_ds_rede_documento, 
PTIT_ds_path_documento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PTIT_nm_titulo as PTIT_nm_titulo, 
A.PTIT_ds_titulo as PTIT_ds_titulo, 
A.TTIT_ds_tipo_titulo as TTIT_ds_tipo_titulo, 
A.SITU_ds_situacao_titulo as SITU_ds_situacao_titulo, 
A.PTIT_dt_publicacao as PTIT_dt_publicacao, 
A.PTIT_dt_vencimento as PTIT_dt_vencimento, 
A.PTIT_ds_nome_documento as PTIT_ds_nome_documento, 
A.PTIT_ds_local_documento as PTIT_ds_local_documento, 
A.PTIT_ds_rede_documento as PTIT_ds_rede_documento, 
A.PTIT_ds_path_documento as PTIT_ds_path_documento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_PTIT_processo_titulo A

WHERE 




(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@PTIT_nm_titulo is null or (@PTIT_nm_titulo is not null and A.PTIT_nm_titulo = @PTIT_nm_titulo)) 
 AND (@TTIT_ds_tipo_titulo is null or (@TTIT_ds_tipo_titulo is not null and A.TTIT_ds_tipo_titulo = @TTIT_ds_tipo_titulo)) 
 AND (@SITU_ds_situacao_titulo is null or (@SITU_ds_situacao_titulo is not null and A.SITU_ds_situacao_titulo = @SITU_ds_situacao_titulo)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PTIT_nm_titulo'' and rtrim(ltrim(A.PTIT_nm_titulo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PTIT_ds_titulo'' and rtrim(ltrim(A.PTIT_ds_titulo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TTIT_ds_tipo_titulo'' and rtrim(ltrim(A.TTIT_ds_tipo_titulo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SITU_ds_situacao_titulo'' and rtrim(ltrim(A.SITU_ds_situacao_titulo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PTIT_dt_publicacao'' and rtrim(ltrim(A.PTIT_dt_publicacao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PTIT_dt_vencimento'' and rtrim(ltrim(A.PTIT_dt_vencimento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PTIT_ds_nome_documento'' and rtrim(ltrim(A.PTIT_ds_nome_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PTIT_ds_local_documento'' and rtrim(ltrim(A.PTIT_ds_local_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PTIT_ds_rede_documento'' and rtrim(ltrim(A.PTIT_ds_rede_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PTIT_ds_path_documento'' and rtrim(ltrim(A.PTIT_ds_path_documento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''PTIT_nm_titulo'' and  @sortOrder=''ASC'' then A.PTIT_nm_titulo END ASC, 
 CASE when @sortField = ''PTIT_nm_titulo'' and  @sortOrder=''DESC'' then A.PTIT_nm_titulo END DESC 
 ,  CASE when @sortField = ''PTIT_ds_titulo'' and  @sortOrder=''ASC'' then A.PTIT_ds_titulo END ASC, 
 CASE when @sortField = ''PTIT_ds_titulo'' and  @sortOrder=''DESC'' then A.PTIT_ds_titulo END DESC 
 ,  CASE when @sortField = ''TTIT_ds_tipo_titulo'' and  @sortOrder=''ASC'' then A.TTIT_ds_tipo_titulo END ASC, 
 CASE when @sortField = ''TTIT_ds_tipo_titulo'' and  @sortOrder=''DESC'' then A.TTIT_ds_tipo_titulo END DESC 
 ,  CASE when @sortField = ''SITU_ds_situacao_titulo'' and  @sortOrder=''ASC'' then A.SITU_ds_situacao_titulo END ASC, 
 CASE when @sortField = ''SITU_ds_situacao_titulo'' and  @sortOrder=''DESC'' then A.SITU_ds_situacao_titulo END DESC 
 ,  CASE when @sortField = ''PTIT_dt_publicacao'' and  @sortOrder=''ASC'' then A.PTIT_dt_publicacao END ASC, 
 CASE when @sortField = ''PTIT_dt_publicacao'' and  @sortOrder=''DESC'' then A.PTIT_dt_publicacao END DESC 
 ,  CASE when @sortField = ''PTIT_dt_vencimento'' and  @sortOrder=''ASC'' then A.PTIT_dt_vencimento END ASC, 
 CASE when @sortField = ''PTIT_dt_vencimento'' and  @sortOrder=''DESC'' then A.PTIT_dt_vencimento END DESC 
 ,  CASE when @sortField = ''PTIT_ds_nome_documento'' and  @sortOrder=''ASC'' then A.PTIT_ds_nome_documento END ASC, 
 CASE when @sortField = ''PTIT_ds_nome_documento'' and  @sortOrder=''DESC'' then A.PTIT_ds_nome_documento END DESC 
 ,  CASE when @sortField = ''PTIT_ds_local_documento'' and  @sortOrder=''ASC'' then A.PTIT_ds_local_documento END ASC, 
 CASE when @sortField = ''PTIT_ds_local_documento'' and  @sortOrder=''DESC'' then A.PTIT_ds_local_documento END DESC 
 ,  CASE when @sortField = ''PTIT_ds_rede_documento'' and  @sortOrder=''ASC'' then A.PTIT_ds_rede_documento END ASC, 
 CASE when @sortField = ''PTIT_ds_rede_documento'' and  @sortOrder=''DESC'' then A.PTIT_ds_rede_documento END DESC 
 ,  CASE when @sortField = ''PTIT_ds_path_documento'' and  @sortOrder=''ASC'' then A.PTIT_ds_path_documento END ASC, 
 CASE when @sortField = ''PTIT_ds_path_documento'' and  @sortOrder=''DESC'' then A.PTIT_ds_path_documento END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_PTIT_processo_titulo where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PTIT_processo_titulo_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PTIT_processo_titulo_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PTIT_processo_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_PTIT_processo_titulo_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(10) not null, 
PTIT_nm_titulo varchar(50) not null, 
PTIT_ds_titulo varchar(300) not null, 
TTIT_ds_tipo_titulo varchar(100) not null, 
SITU_ds_situacao_titulo varchar(100) null, 
PTIT_dt_publicacao datetime null, 
PTIT_dt_vencimento datetime null, 
PTIT_ds_nome_documento varchar(100) null, 
PTIT_ds_local_documento varchar(500) null, 
PTIT_ds_rede_documento varchar(500) null, 
PTIT_ds_path_documento varchar(500) null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.PROC_cd_processo as PROC_cd_processo, 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.PTIT_nm_titulo as PTIT_nm_titulo, 
A.PTIT_ds_titulo as PTIT_ds_titulo, 
A.TTIT_ds_tipo_titulo as TTIT_ds_tipo_titulo, 
A.SITU_ds_situacao_titulo as SITU_ds_situacao_titulo, 
A.PTIT_dt_publicacao as PTIT_dt_publicacao, 
A.PTIT_dt_vencimento as PTIT_dt_vencimento, 
A.PTIT_ds_nome_documento as PTIT_ds_nome_documento, 
A.PTIT_ds_local_documento as PTIT_ds_local_documento, 
A.PTIT_ds_rede_documento as PTIT_ds_rede_documento, 
A.PTIT_ds_path_documento as PTIT_ds_path_documento, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_PTIT_processo_titulo A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ROTI_rotina_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
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
AUDT_nm_usuario_alteracao varchar(20) not null,
ROTI_dt_inicio_execucao datetime null
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
AUDT_nm_usuario_alteracao,
ROTI_dt_inicio_execucao) 

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
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao,
A.ROTI_dt_inicio_execucao as ROTI_dt_inicio_execucao

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

 (@whereField = ''ROTI_nm_rotina'' and rtrim(ltrim(A.ROTI_nm_rotina)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ROTI_ds_rotina'' and rtrim(ltrim(A.ROTI_ds_rotina)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ROTI_dt_ultima_execucao'' and rtrim(ltrim(A.ROTI_dt_ultima_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ROTI_dt_ultima_tentativa_execucao'' and rtrim(ltrim(A.ROTI_dt_ultima_tentativa_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ROTI_fl_status_execucao'' and rtrim(ltrim(A.ROTI_fl_status_execucao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ROTI_ds_mensagem'' and rtrim(ltrim(A.ROTI_ds_mensagem)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ROTI_vl_tempo_medio'' and rtrim(ltrim(A.ROTI_vl_tempo_medio)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ROTI_nm_rotina'' and  @sortOrder=''ASC'' then A.ROTI_nm_rotina END ASC, 
 CASE when @sortField = ''ROTI_nm_rotina'' and  @sortOrder=''DESC'' then A.ROTI_nm_rotina END DESC 
 ,  CASE when @sortField = ''ROTI_ds_rotina'' and  @sortOrder=''ASC'' then A.ROTI_ds_rotina END ASC, 
 CASE when @sortField = ''ROTI_ds_rotina'' and  @sortOrder=''DESC'' then A.ROTI_ds_rotina END DESC 
 ,  CASE when @sortField = ''ROTI_dt_ultima_execucao'' and  @sortOrder=''ASC'' then A.ROTI_dt_ultima_execucao END ASC, 
 CASE when @sortField = ''ROTI_dt_ultima_execucao'' and  @sortOrder=''DESC'' then A.ROTI_dt_ultima_execucao END DESC 
 ,  CASE when @sortField = ''ROTI_dt_ultima_tentativa_execucao'' and  @sortOrder=''ASC'' then A.ROTI_dt_ultima_tentativa_execucao END ASC, 
 CASE when @sortField = ''ROTI_dt_ultima_tentativa_execucao'' and  @sortOrder=''DESC'' then A.ROTI_dt_ultima_tentativa_execucao END DESC 
 ,  CASE when @sortField = ''ROTI_fl_status_execucao'' and  @sortOrder=''ASC'' then A.ROTI_fl_status_execucao END ASC, 
 CASE when @sortField = ''ROTI_fl_status_execucao'' and  @sortOrder=''DESC'' then A.ROTI_fl_status_execucao END DESC 
 ,  CASE when @sortField = ''ROTI_ds_mensagem'' and  @sortOrder=''ASC'' then A.ROTI_ds_mensagem END ASC, 
 CASE when @sortField = ''ROTI_ds_mensagem'' and  @sortOrder=''DESC'' then A.ROTI_ds_mensagem END DESC 
 ,  CASE when @sortField = ''ROTI_vl_tempo_medio'' and  @sortOrder=''ASC'' then A.ROTI_vl_tempo_medio END ASC, 
 CASE when @sortField = ''ROTI_vl_tempo_medio'' and  @sortOrder=''DESC'' then A.ROTI_vl_tempo_medio END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_ROTI_rotina where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ROTI_rotina_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
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


SET @sql = 
''insert into 
#Temporary_Table 
select  
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
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_ROTI_rotina A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SCON_situacao_condicao_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SCON_situacao_condicao_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SCON_situacao_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_SCON_situacao_condicao_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ORGA_nm_orgao varchar(10) = null , 
@SCON_ds_situacao_condicao varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_SCON_situacao_condicao table (
id int identity primary key, 
ORGA_nm_orgao varchar(10) not null, 
SCON_ds_situacao_condicao varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_SCON_situacao_condicao
(ORGA_nm_orgao, 
SCON_ds_situacao_condicao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.SCON_ds_situacao_condicao as SCON_ds_situacao_condicao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_SCON_situacao_condicao A

WHERE 




(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@SCON_ds_situacao_condicao is null or (@SCON_ds_situacao_condicao is not null and A.SCON_ds_situacao_condicao = @SCON_ds_situacao_condicao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SCON_ds_situacao_condicao'' and rtrim(ltrim(A.SCON_ds_situacao_condicao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''SCON_ds_situacao_condicao'' and  @sortOrder=''ASC'' then A.SCON_ds_situacao_condicao END ASC, 
 CASE when @sortField = ''SCON_ds_situacao_condicao'' and  @sortOrder=''DESC'' then A.SCON_ds_situacao_condicao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_SCON_situacao_condicao where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SCON_situacao_condicao_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SCON_situacao_condicao_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SCON_situacao_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_SCON_situacao_condicao_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  ORGA_nm_orgao varchar(10) not null, 
SCON_ds_situacao_condicao varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.SCON_ds_situacao_condicao as SCON_ds_situacao_condicao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_SCON_situacao_condicao A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SINF_situacao_info_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SINF_situacao_info_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SINF_situacao_info
CREATE PROCEDURE [dbo].[sp_sel_tb_SINF_situacao_info_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ORGA_nm_orgao varchar(10) = null , 
@SINF_ds_situacao_info varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_SINF_situacao_info table (
id int identity primary key, 
ORGA_nm_orgao varchar(10) not null, 
SINF_ds_situacao_info varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_SINF_situacao_info
(ORGA_nm_orgao, 
SINF_ds_situacao_info, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.SINF_ds_situacao_info as SINF_ds_situacao_info, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_SINF_situacao_info A

WHERE 




(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@SINF_ds_situacao_info is null or (@SINF_ds_situacao_info is not null and A.SINF_ds_situacao_info = @SINF_ds_situacao_info)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SINF_ds_situacao_info'' and rtrim(ltrim(A.SINF_ds_situacao_info)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''SINF_ds_situacao_info'' and  @sortOrder=''ASC'' then A.SINF_ds_situacao_info END ASC, 
 CASE when @sortField = ''SINF_ds_situacao_info'' and  @sortOrder=''DESC'' then A.SINF_ds_situacao_info END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_SINF_situacao_info where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SINF_situacao_info_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SINF_situacao_info_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SINF_situacao_info
CREATE PROCEDURE [dbo].[sp_sel_tb_SINF_situacao_info_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  ORGA_nm_orgao varchar(10) not null, 
SINF_ds_situacao_info varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.SINF_ds_situacao_info as SINF_ds_situacao_info, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_SINF_situacao_info A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SISD_situacao_sd_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SISD_situacao_sd_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SISD_situacao_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_SISD_situacao_sd_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ORGA_nm_orgao varchar(10) = null , 
@SISD_nm_situacao_sd varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_SISD_situacao_sd table (
id int identity primary key, 
ORGA_nm_orgao varchar(10) not null, 
SISD_nm_situacao_sd varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_SISD_situacao_sd
(ORGA_nm_orgao, 
SISD_nm_situacao_sd, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.SISD_nm_situacao_sd as SISD_nm_situacao_sd, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_SISD_situacao_sd A

WHERE 




(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@SISD_nm_situacao_sd is null or (@SISD_nm_situacao_sd is not null and A.SISD_nm_situacao_sd = @SISD_nm_situacao_sd)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SISD_nm_situacao_sd'' and rtrim(ltrim(A.SISD_nm_situacao_sd)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''SISD_nm_situacao_sd'' and  @sortOrder=''ASC'' then A.SISD_nm_situacao_sd END ASC, 
 CASE when @sortField = ''SISD_nm_situacao_sd'' and  @sortOrder=''DESC'' then A.SISD_nm_situacao_sd END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_SISD_situacao_sd where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SISD_situacao_sd_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SISD_situacao_sd_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SISD_situacao_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_SISD_situacao_sd_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  ORGA_nm_orgao varchar(10) not null, 
SISD_nm_situacao_sd varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.SISD_nm_situacao_sd as SISD_nm_situacao_sd, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_SISD_situacao_sd A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SITU_situacao_titulo_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SITU_situacao_titulo_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SITU_situacao_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_SITU_situacao_titulo_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ORGA_nm_orgao varchar(10) = null , 
@SITU_ds_situacao_titulo varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_SITU_situacao_titulo table (
id int identity primary key, 
ORGA_nm_orgao varchar(10) not null, 
SITU_ds_situacao_titulo varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_SITU_situacao_titulo
(ORGA_nm_orgao, 
SITU_ds_situacao_titulo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.SITU_ds_situacao_titulo as SITU_ds_situacao_titulo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_SITU_situacao_titulo A

WHERE 




(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@SITU_ds_situacao_titulo is null or (@SITU_ds_situacao_titulo is not null and A.SITU_ds_situacao_titulo = @SITU_ds_situacao_titulo)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''SITU_ds_situacao_titulo'' and rtrim(ltrim(A.SITU_ds_situacao_titulo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''SITU_ds_situacao_titulo'' and  @sortOrder=''ASC'' then A.SITU_ds_situacao_titulo END ASC, 
 CASE when @sortField = ''SITU_ds_situacao_titulo'' and  @sortOrder=''DESC'' then A.SITU_ds_situacao_titulo END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_SITU_situacao_titulo where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SITU_situacao_titulo_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SITU_situacao_titulo_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SITU_situacao_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_SITU_situacao_titulo_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  ORGA_nm_orgao varchar(10) not null, 
SITU_ds_situacao_titulo varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.SITU_ds_situacao_titulo as SITU_ds_situacao_titulo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_SITU_situacao_titulo A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SUBS_substancia_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SUBS_substancia_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SUBS_substancia
CREATE PROCEDURE [dbo].[sp_sel_tb_SUBS_substancia_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@SUBS_nm_substancia varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_SUBS_substancia table (
id int identity primary key, 
SUBS_nm_substancia varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_SUBS_substancia
(SUBS_nm_substancia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.SUBS_nm_substancia as SUBS_nm_substancia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_SUBS_substancia A

WHERE 




(@SUBS_nm_substancia is null or (@SUBS_nm_substancia is not null and A.SUBS_nm_substancia = @SUBS_nm_substancia)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''SUBS_nm_substancia'' and rtrim(ltrim(A.SUBS_nm_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''SUBS_nm_substancia'' and  @sortOrder=''ASC'' then A.SUBS_nm_substancia END ASC, 
 CASE when @sortField = ''SUBS_nm_substancia'' and  @sortOrder=''DESC'' then A.SUBS_nm_substancia END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_SUBS_substancia where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SUBS_substancia_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SUBS_substancia_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_SUBS_substancia
CREATE PROCEDURE [dbo].[sp_sel_tb_SUBS_substancia_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  SUBS_nm_substancia varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.SUBS_nm_substancia as SUBS_nm_substancia, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_SUBS_substancia A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TABE_tabela_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TABE_tabela_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_TABE_tabela
CREATE PROCEDURE [dbo].[sp_sel_tb_TABE_tabela_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@TABE_nm_tabela varchar(50) = null , 
@TABE_ds_tabela varchar(200) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_TABE_tabela table (
id int identity primary key, 
TABE_nm_tabela varchar(50) not null, 
TABE_ds_tabela varchar(200) not null, 
TABE_ds_selectall varchar(1000) not null, 
TABE_ds_selectcheck varchar(1000) not null, 
TABE_ds_deleleone varchar(1000) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_TABE_tabela
(TABE_nm_tabela, 
TABE_ds_tabela, 
TABE_ds_selectall, 
TABE_ds_selectcheck, 
TABE_ds_deleleone, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.TABE_nm_tabela as TABE_nm_tabela, 
A.TABE_ds_tabela as TABE_ds_tabela, 
A.TABE_ds_selectall as TABE_ds_selectall, 
A.TABE_ds_selectcheck as TABE_ds_selectcheck, 
A.TABE_ds_deleleone as TABE_ds_deleleone, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_TABE_tabela A

WHERE 




(@TABE_nm_tabela is null or (@TABE_nm_tabela is not null and A.TABE_nm_tabela = @TABE_nm_tabela)) 
 AND (@TABE_ds_tabela is null or (@TABE_ds_tabela is not null and A.TABE_ds_tabela = @TABE_ds_tabela)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''TABE_nm_tabela'' and rtrim(ltrim(A.TABE_nm_tabela)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TABE_ds_tabela'' and rtrim(ltrim(A.TABE_ds_tabela)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TABE_ds_selectall'' and rtrim(ltrim(A.TABE_ds_selectall)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TABE_ds_selectcheck'' and rtrim(ltrim(A.TABE_ds_selectcheck)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TABE_ds_deleleone'' and rtrim(ltrim(A.TABE_ds_deleleone)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''TABE_nm_tabela'' and  @sortOrder=''ASC'' then A.TABE_nm_tabela END ASC, 
 CASE when @sortField = ''TABE_nm_tabela'' and  @sortOrder=''DESC'' then A.TABE_nm_tabela END DESC 
 ,  CASE when @sortField = ''TABE_ds_tabela'' and  @sortOrder=''ASC'' then A.TABE_ds_tabela END ASC, 
 CASE when @sortField = ''TABE_ds_tabela'' and  @sortOrder=''DESC'' then A.TABE_ds_tabela END DESC 
 ,  CASE when @sortField = ''TABE_ds_selectall'' and  @sortOrder=''ASC'' then A.TABE_ds_selectall END ASC, 
 CASE when @sortField = ''TABE_ds_selectall'' and  @sortOrder=''DESC'' then A.TABE_ds_selectall END DESC 
 ,  CASE when @sortField = ''TABE_ds_selectcheck'' and  @sortOrder=''ASC'' then A.TABE_ds_selectcheck END ASC, 
 CASE when @sortField = ''TABE_ds_selectcheck'' and  @sortOrder=''DESC'' then A.TABE_ds_selectcheck END DESC 
 ,  CASE when @sortField = ''TABE_ds_deleleone'' and  @sortOrder=''ASC'' then A.TABE_ds_deleleone END ASC, 
 CASE when @sortField = ''TABE_ds_deleleone'' and  @sortOrder=''DESC'' then A.TABE_ds_deleleone END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_TABE_tabela where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TABE_tabela_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TABE_tabela_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_TABE_tabela
CREATE PROCEDURE [dbo].[sp_sel_tb_TABE_tabela_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  TABE_nm_tabela varchar(50) not null, 
TABE_ds_tabela varchar(200) not null, 
TABE_ds_selectall varchar(1000) not null, 
TABE_ds_selectcheck varchar(1000) not null, 
TABE_ds_deleleone varchar(1000) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.TABE_nm_tabela as TABE_nm_tabela, 
A.TABE_ds_tabela as TABE_ds_tabela, 
A.TABE_ds_selectall as TABE_ds_selectall, 
A.TABE_ds_selectcheck as TABE_ds_selectcheck, 
A.TABE_ds_deleleone as TABE_ds_deleleone, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_TABE_tabela A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TINF_tipo_info_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TINF_tipo_info_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_TINF_tipo_info
CREATE PROCEDURE [dbo].[sp_sel_tb_TINF_tipo_info_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ORGA_nm_orgao varchar(10) = null , 
@TINF_nm_tipo_info varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_TINF_tipo_info table (
id int identity primary key, 
ORGA_nm_orgao varchar(10) not null, 
TINF_nm_tipo_info varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_TINF_tipo_info
(ORGA_nm_orgao, 
TINF_nm_tipo_info, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.TINF_nm_tipo_info as TINF_nm_tipo_info, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_TINF_tipo_info A

WHERE 




(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@TINF_nm_tipo_info is null or (@TINF_nm_tipo_info is not null and A.TINF_nm_tipo_info = @TINF_nm_tipo_info)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TINF_nm_tipo_info'' and rtrim(ltrim(A.TINF_nm_tipo_info)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''TINF_nm_tipo_info'' and  @sortOrder=''ASC'' then A.TINF_nm_tipo_info END ASC, 
 CASE when @sortField = ''TINF_nm_tipo_info'' and  @sortOrder=''DESC'' then A.TINF_nm_tipo_info END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_TINF_tipo_info where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TINF_tipo_info_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TINF_tipo_info_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_TINF_tipo_info
CREATE PROCEDURE [dbo].[sp_sel_tb_TINF_tipo_info_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  ORGA_nm_orgao varchar(10) not null, 
TINF_nm_tipo_info varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.TINF_nm_tipo_info as TINF_nm_tipo_info, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_TINF_tipo_info A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TTIT_tipo_titulo_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TTIT_tipo_titulo_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_TTIT_tipo_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_TTIT_tipo_titulo_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ORGA_nm_orgao varchar(10) = null , 
@TTIT_ds_tipo_titulo varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_TTIT_tipo_titulo table (
id int identity primary key, 
ORGA_nm_orgao varchar(10) not null, 
TTIT_ds_tipo_titulo varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_TTIT_tipo_titulo
(ORGA_nm_orgao, 
TTIT_ds_tipo_titulo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.TTIT_ds_tipo_titulo as TTIT_ds_tipo_titulo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_TTIT_tipo_titulo A

WHERE 




(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and A.ORGA_nm_orgao = @ORGA_nm_orgao)) 
 AND (@TTIT_ds_tipo_titulo is null or (@TTIT_ds_tipo_titulo is not null and A.TTIT_ds_tipo_titulo = @TTIT_ds_tipo_titulo)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''ORGA_nm_orgao'' and rtrim(ltrim(A.ORGA_nm_orgao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''TTIT_ds_tipo_titulo'' and rtrim(ltrim(A.TTIT_ds_tipo_titulo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''ASC'' then A.ORGA_nm_orgao END ASC, 
 CASE when @sortField = ''ORGA_nm_orgao'' and  @sortOrder=''DESC'' then A.ORGA_nm_orgao END DESC 
 ,  CASE when @sortField = ''TTIT_ds_tipo_titulo'' and  @sortOrder=''ASC'' then A.TTIT_ds_tipo_titulo END ASC, 
 CASE when @sortField = ''TTIT_ds_tipo_titulo'' and  @sortOrder=''DESC'' then A.TTIT_ds_tipo_titulo END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_TTIT_tipo_titulo where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TTIT_tipo_titulo_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TTIT_tipo_titulo_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_TTIT_tipo_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_TTIT_tipo_titulo_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  ORGA_nm_orgao varchar(10) not null, 
TTIT_ds_tipo_titulo varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.ORGA_nm_orgao as ORGA_nm_orgao, 
A.TTIT_ds_tipo_titulo as TTIT_ds_tipo_titulo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_TTIT_tipo_titulo A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TUSO_tipo_uso_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TUSO_tipo_uso_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_TUSO_tipo_uso
CREATE PROCEDURE [dbo].[sp_sel_tb_TUSO_tipo_uso_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@TUSO_nm_uso varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_TUSO_tipo_uso table (
id int identity primary key, 
TUSO_nm_uso varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_TUSO_tipo_uso
(TUSO_nm_uso, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.TUSO_nm_uso as TUSO_nm_uso, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_TUSO_tipo_uso A

WHERE 




(@TUSO_nm_uso is null or (@TUSO_nm_uso is not null and A.TUSO_nm_uso = @TUSO_nm_uso)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''TUSO_nm_uso'' and rtrim(ltrim(A.TUSO_nm_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''TUSO_nm_uso'' and  @sortOrder=''ASC'' then A.TUSO_nm_uso END ASC, 
 CASE when @sortField = ''TUSO_nm_uso'' and  @sortOrder=''DESC'' then A.TUSO_nm_uso END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_TUSO_tipo_uso where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TUSO_tipo_uso_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TUSO_tipo_uso_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_TUSO_tipo_uso
CREATE PROCEDURE [dbo].[sp_sel_tb_TUSO_tipo_uso_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  TUSO_nm_uso varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.TUSO_nm_uso as TUSO_nm_uso, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_TUSO_tipo_uso A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNFE_unidade_federativa_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
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

 (@whereField = ''UNFE_cd_unidade_federativa'' and rtrim(ltrim(A.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNFE_nm_unidade_federativa'' and rtrim(ltrim(A.UNFE_nm_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNFE_fl_status'' and rtrim(ltrim(A.UNFE_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''ASC'' then A.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''DESC'' then A.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = ''UNFE_nm_unidade_federativa'' and  @sortOrder=''ASC'' then A.UNFE_nm_unidade_federativa END ASC, 
 CASE when @sortField = ''UNFE_nm_unidade_federativa'' and  @sortOrder=''DESC'' then A.UNFE_nm_unidade_federativa END DESC 
 ,  CASE when @sortField = ''UNFE_fl_status'' and  @sortOrder=''ASC'' then A.UNFE_fl_status END ASC, 
 CASE when @sortField = ''UNFE_fl_status'' and  @sortOrder=''DESC'' then A.UNFE_fl_status END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_UNFE_unidade_federativa where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  UNFE_cd_unidade_federativa char(2) not null, 
UNFE_nm_unidade_federativa varchar(100) not null, 
UNFE_fl_status char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.UNFE_nm_unidade_federativa as UNFE_nm_unidade_federativa, 
A.UNFE_fl_status as UNFE_fl_status, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_UNFE_unidade_federativa A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNME_unidade_medida_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNME_unidade_medida_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UNME_unidade_medida
CREATE PROCEDURE [dbo].[sp_sel_tb_UNME_unidade_medida_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@UNME_nm_unidade varchar(10) = null , 
@UNME_ds_unidade varchar(100) = null , 
@UNME_nm_tipo char(2) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_UNME_unidade_medida table (
id int identity primary key, 
UNME_nm_unidade varchar(10) not null, 
UNME_ds_unidade varchar(100) not null, 
UNME_nm_tipo char(2) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_UNME_unidade_medida
(UNME_nm_unidade, 
UNME_ds_unidade, 
UNME_nm_tipo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.UNME_nm_unidade as UNME_nm_unidade, 
A.UNME_ds_unidade as UNME_ds_unidade, 
A.UNME_nm_tipo as UNME_nm_tipo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_UNME_unidade_medida A

WHERE 




(@UNME_nm_unidade is null or (@UNME_nm_unidade is not null and A.UNME_nm_unidade = @UNME_nm_unidade)) 
 AND (@UNME_ds_unidade is null or (@UNME_ds_unidade is not null and A.UNME_ds_unidade = @UNME_ds_unidade)) 
 AND (@UNME_nm_tipo is null or (@UNME_nm_tipo is not null and A.UNME_nm_tipo = @UNME_nm_tipo)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''UNME_nm_unidade'' and rtrim(ltrim(A.UNME_nm_unidade)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNME_ds_unidade'' and rtrim(ltrim(A.UNME_ds_unidade)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNME_nm_tipo'' and rtrim(ltrim(A.UNME_nm_tipo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''UNME_nm_unidade'' and  @sortOrder=''ASC'' then A.UNME_nm_unidade END ASC, 
 CASE when @sortField = ''UNME_nm_unidade'' and  @sortOrder=''DESC'' then A.UNME_nm_unidade END DESC 
 ,  CASE when @sortField = ''UNME_ds_unidade'' and  @sortOrder=''ASC'' then A.UNME_ds_unidade END ASC, 
 CASE when @sortField = ''UNME_ds_unidade'' and  @sortOrder=''DESC'' then A.UNME_ds_unidade END DESC 
 ,  CASE when @sortField = ''UNME_nm_tipo'' and  @sortOrder=''ASC'' then A.UNME_nm_tipo END ASC, 
 CASE when @sortField = ''UNME_nm_tipo'' and  @sortOrder=''DESC'' then A.UNME_nm_tipo END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_UNME_unidade_medida where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNME_unidade_medida_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNME_unidade_medida_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UNME_unidade_medida
CREATE PROCEDURE [dbo].[sp_sel_tb_UNME_unidade_medida_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  UNME_nm_unidade varchar(10) not null, 
UNME_ds_unidade varchar(100) not null, 
UNME_nm_tipo char(2) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.UNME_nm_unidade as UNME_nm_unidade, 
A.UNME_ds_unidade as UNME_ds_unidade, 
A.UNME_nm_tipo as UNME_nm_tipo, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_UNME_unidade_medida A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UPRD_uso_produto_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UPRD_uso_produto_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UPRD_uso_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_UPRD_uso_produto_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@UPRD_nm_uso varchar(100) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_UPRD_uso_produto table (
id int identity primary key, 
UPRD_nm_uso varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)



insert into 
@tb_UPRD_uso_produto
(UPRD_nm_uso, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao) 

SELECT 
A.UPRD_nm_uso as UPRD_nm_uso, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao

FROM 

DBDNPM..tb_UPRD_uso_produto A

WHERE 




(@UPRD_nm_uso is null or (@UPRD_nm_uso is not null and A.UPRD_nm_uso = @UPRD_nm_uso)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''UPRD_nm_uso'' and rtrim(ltrim(A.UPRD_nm_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''UPRD_nm_uso'' and  @sortOrder=''ASC'' then A.UPRD_nm_uso END ASC, 
 CASE when @sortField = ''UPRD_nm_uso'' and  @sortOrder=''DESC'' then A.UPRD_nm_uso END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 

 
SELECT * FROM 
@tb_UPRD_uso_produto where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UPRD_uso_produto_cons]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UPRD_uso_produto_cons]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_UPRD_uso_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_UPRD_uso_produto_cons]
@WhereClause varchar(8000),
@OrderByClause varchar(8000)

AS

DECLARE @whereAux VARCHAR(8000)
DECLARE @OrderByAux VARCHAR(8000)
DECLARE @sql varchar(8000)

IF @OrderByClause is null or len(ltrim(rtrim(@OrderByClause))) = 0 
 SET @OrderByAux = '''' 
ELSE
 SET @OrderByAux = '' Order by '' + @OrderByClause



SET @whereAux = ''''



CREATE TABLE #Temporary_Table 
 ( id int identity primary key, 
  UPRD_nm_uso varchar(100) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null
)


SET @sql = 
''insert into 
#Temporary_Table 
select  
A.UPRD_nm_uso as UPRD_nm_uso, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao '' 
+ '' from 

DBDNPM..tb_UPRD_uso_produto A '' 

IF @WhereAux is not null and len(ltrim(rtrim(@WhereAux))) > 0  
 SET @sql = @sql + '' WHERE '' + @WhereAux 
 
raiserror(@sql,-1,-1)
exec(@sql)


SET @sql ='' SELECT * FROM #Temporary_Table '' 

IF @WhereClause is not null and len(ltrim(rtrim(@WhereClause))) > 0  
 set @sql = @sql + '' WHERE '' + @WhereClause

IF @OrderByAux is not null and len(ltrim(rtrim(@OrderByAux))) > 0  
 set @sql = @sql + '' '' + @OrderByAux 
 

raiserror(@sql,-1,-1)
exec(@sql)

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UPRD_uso_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_UPRD_uso_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_UPRD_uso_produto]
@UPRD_nm_uso varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_UPRD_uso_produto
 where (@UPRD_nm_uso is null or (@UPRD_nm_uso is not null and UPRD_nm_uso = @UPRD_nm_uso))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNME_unidade_medida]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_UNME_unidade_medida
CREATE PROCEDURE [dbo].[sp_sel_tb_UNME_unidade_medida]
@UNME_nm_unidade varchar(10) = null , 
@UNME_nm_tipo char(2) = null 
 
AS
 
SELECT * FROM 
tb_UNME_unidade_medida
 where (@UNME_nm_unidade is null or (@UNME_nm_unidade is not null and UNME_nm_unidade = @UNME_nm_unidade))  AND 
(@UNME_nm_tipo is null or (@UNME_nm_tipo is not null and UNME_nm_tipo = @UNME_nm_tipo))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_UNFE_unidade_federativa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_sel_tb_UNFE_unidade_federativa]
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_UNFE_unidade_federativa
 where (@UNFE_cd_unidade_federativa is null or (@UNFE_cd_unidade_federativa is not null and UNFE_cd_unidade_federativa = @UNFE_cd_unidade_federativa))  AND 
(@UNFE_nm_unidade_federativa is null or (@UNFE_nm_unidade_federativa is not null and UNFE_nm_unidade_federativa = @UNFE_nm_unidade_federativa))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TUSO_tipo_uso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_TUSO_tipo_uso
CREATE PROCEDURE [dbo].[sp_sel_tb_TUSO_tipo_uso]
@TUSO_nm_uso varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_TUSO_tipo_uso
 where (@TUSO_nm_uso is null or (@TUSO_nm_uso is not null and TUSO_nm_uso = @TUSO_nm_uso))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TTIT_tipo_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_TTIT_tipo_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_TTIT_tipo_titulo]
@ORGA_nm_orgao varchar(10) = null , 
@TTIT_ds_tipo_titulo varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_TTIT_tipo_titulo
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@TTIT_ds_tipo_titulo is null or (@TTIT_ds_tipo_titulo is not null and TTIT_ds_tipo_titulo = @TTIT_ds_tipo_titulo))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TINF_tipo_info]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TINF_tipo_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_TINF_tipo_info
CREATE PROCEDURE [dbo].[sp_sel_tb_TINF_tipo_info]
@ORGA_nm_orgao varchar(10) = null , 
@TINF_nm_tipo_info varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_TINF_tipo_info
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@TINF_nm_tipo_info is null or (@TINF_nm_tipo_info is not null and TINF_nm_tipo_info = @TINF_nm_tipo_info))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_TABE_tabela]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_TABE_tabela]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_TABE_tabela
CREATE PROCEDURE [dbo].[sp_sel_tb_TABE_tabela]
@TABE_nm_tabela varchar(50) = null , 
@TABE_ds_tabela varchar(200) = null 
 
AS
 
SELECT * FROM 
tb_TABE_tabela
 where (@TABE_nm_tabela is null or (@TABE_nm_tabela is not null and TABE_nm_tabela = @TABE_nm_tabela))  AND 
(@TABE_ds_tabela is null or (@TABE_ds_tabela is not null and TABE_ds_tabela = @TABE_ds_tabela))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SUBS_substancia]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SUBS_substancia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_SUBS_substancia
CREATE PROCEDURE [dbo].[sp_sel_tb_SUBS_substancia]
@SUBS_nm_substancia varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_SUBS_substancia
 where (@SUBS_nm_substancia is null or (@SUBS_nm_substancia is not null and SUBS_nm_substancia = @SUBS_nm_substancia))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SITU_situacao_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_SITU_situacao_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_SITU_situacao_titulo]
@ORGA_nm_orgao varchar(10) = null , 
@SITU_ds_situacao_titulo varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_SITU_situacao_titulo
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SITU_ds_situacao_titulo is null or (@SITU_ds_situacao_titulo is not null and SITU_ds_situacao_titulo = @SITU_ds_situacao_titulo))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SISD_situacao_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_SISD_situacao_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_SISD_situacao_sd]
@ORGA_nm_orgao varchar(10) = null , 
@SISD_nm_situacao_sd varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_SISD_situacao_sd
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SISD_nm_situacao_sd is null or (@SISD_nm_situacao_sd is not null and SISD_nm_situacao_sd = @SISD_nm_situacao_sd))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SINF_situacao_info]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SINF_situacao_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_SINF_situacao_info
CREATE PROCEDURE [dbo].[sp_sel_tb_SINF_situacao_info]
@ORGA_nm_orgao varchar(10) = null , 
@SINF_ds_situacao_info varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_SINF_situacao_info
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SINF_ds_situacao_info is null or (@SINF_ds_situacao_info is not null and SINF_ds_situacao_info = @SINF_ds_situacao_info))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_SCON_situacao_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_SCON_situacao_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_SCON_situacao_condicao]
@ORGA_nm_orgao varchar(10) = null , 
@SCON_ds_situacao_condicao varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_SCON_situacao_condicao
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SCON_ds_situacao_condicao is null or (@SCON_ds_situacao_condicao is not null and SCON_ds_situacao_condicao = @SCON_ds_situacao_condicao))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ROTI_rotina]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ROTI_rotina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_sel_tb_ROTI_rotina]
@ROTI_nm_rotina varchar(30) = null 
 
AS
 
SELECT * FROM 
tb_ROTI_rotina
 where (@ROTI_nm_rotina is null or (@ROTI_nm_rotina is not null and ROTI_nm_rotina = @ROTI_nm_rotina))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PTIT_processo_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PTIT_processo_titulo
CREATE PROCEDURE [dbo].[sp_sel_tb_PTIT_processo_titulo]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PTIT_nm_titulo varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_PTIT_processo_titulo
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PTIT_nm_titulo is null or (@PTIT_nm_titulo is not null and PTIT_nm_titulo = @PTIT_nm_titulo))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PSUB_processo_substancia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PSUB_processo_substancia
CREATE PROCEDURE [dbo].[sp_sel_tb_PSUB_processo_substancia]
@PROC_cd_processo varchar(50) = null , 
@SUBS_nm_substancia varchar(100) = null ,
@TUSO_nm_uso varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_PSUB_processo_substancia
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@SUBS_nm_substancia is null or (@SUBS_nm_substancia is not null and SUBS_nm_substancia = @SUBS_nm_substancia))    AND
(@TUSO_nm_uso is null or (@TUSO_nm_uso is not null and TUSO_nm_uso = @TUSO_nm_uso))   



' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRSD_processo_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PRSD_processo_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_PRSD_processo_sd]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PRSD_nm_sd varchar(30) = null 
 
AS
 
SELECT * FROM 
tb_PRSD_processo_sd
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PRSD_nm_sd is null or (@PRSD_nm_sd is not null and PRSD_nm_sd = @PRSD_nm_sd))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRPD_processo_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PRPD_processo_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_PRPD_processo_produto]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null , 
@PROD_nm_produto varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_PRPD_processo_produto
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))  AND 
(@PROD_nm_produto is null or (@PROD_nm_produto is not null and PROD_nm_produto = @PROD_nm_produto))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROP_processo_operador]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROP_processo_operador]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_PROP_processo_operador]
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null 
 
AS
 
SELECT * FROM 
tb_PROP_processo_operador
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_sel_tb_PROC_processo]
@PROC_cd_processo varchar(50) = null 
 
AS
 
SELECT *,
(select PORG_nm_cadastro from tb_porg_processo_orgao B where A.PROC_cd_processo = B.PROC_cd_processo and B.ORGA_nm_orgao = 1 ) as PORG_nm_cadastro,
(select PORG_ds_atividade from tb_porg_processo_orgao B where A.PROC_cd_processo = B.PROC_cd_processo and B.ORGA_nm_orgao = 1 ) as PORG_ds_atividade,

isnull((select top 1 MUNI_nm_municipio from tb_PMUN_processo_municipio X where A.PROC_cd_processo = X.PROC_cd_processo),''Não Informado'') as MUNI_nm_municipio

 FROM 
tb_PROC_processo A
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROD_produto]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROD_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PROD_produto
CREATE PROCEDURE [dbo].[sp_sel_tb_PROD_produto]
@PROD_nm_produto varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_PROD_produto
 where (@PROD_nm_produto is null or (@PROD_nm_produto is not null and PROD_nm_produto = @PROD_nm_produto))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_rel]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_sel_tb_PROC_processo_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@PROC_cd_processo varchar(50) = null , 
@PROC_ds_titular varchar(300) = null , 
@PROC_vl_ano int = null , 
@PROC_nm_processo varchar(50) = null , 
@FASE_cd_fase int = null , 
@PROC_ds_ultimo_evento varchar(3000) = null , 
@PROC_ds_substancia varchar(100) = null , 
@PROC_ds_area varchar(30) = null , 
@PROC_ds_uso varchar(200) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PROC_processo table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
FASE_nm_fase varchar(100) not null, 
UNFE_nm_unidade_federativa varchar(100) not null,
PROC_cd_prioridade varchar(3) not null,
PROC_ds_prioridade varchar(50) not null,
PROC_cd_ds_prioridade varchar(53) not null,
MUNI_nm_municipio varchar(200) null
)



insert into 
@tb_PROC_processo
(PROC_cd_processo, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 
FASE_nm_fase, 
UNFE_nm_unidade_federativa,
PROC_cd_prioridade,
PROC_ds_prioridade,
PROC_cd_ds_prioridade,
MUNI_nm_municipio
) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.PROC_ds_titular as PROC_ds_titular, 
A.PROC_vl_ano as PROC_vl_ano, 
A.PROC_nm_processo as PROC_nm_processo, 
A.PROC_id_processo as PROC_id_processo, 
A.FASE_cd_fase as FASE_cd_fase, 
A.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
A.PROC_ds_substancia as PROC_ds_substancia, 
A.PROC_ds_area as PROC_ds_area, 
A.PROC_ds_uso as PROC_ds_uso, 
A.PROC_ds_link as PROC_ds_link, 
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.FASE_nm_fase as FASE_nm_fase, 
--C.UNFE_nm_unidade_federativa 
isnull((select UNFE_nm_unidade_federativa from tb_UNFE_unidade_federativa X where A.UNFE_cd_unidade_federativa = X.UNFE_cd_unidade_federativa),''00'') as UNFE_nm_unidade_federativa,

PROC_cd_prioridade,

case 
when PROC_cd_prioridade = ''1'' then ''Muito Baixa''
when PROC_cd_prioridade = ''2'' then ''Baixa''
when PROC_cd_prioridade = ''3'' then ''Média''
when PROC_cd_prioridade = ''4'' then ''Alta''
when PROC_cd_prioridade = ''5'' then ''Muito Alta'' end
as
PROC_ds_prioridade,

case 
when PROC_cd_prioridade = ''1'' then ''1 - Muito Baixa''
when PROC_cd_prioridade = ''2'' then ''2 - Baixa''
when PROC_cd_prioridade = ''3'' then ''3 - Média''
when PROC_cd_prioridade = ''4'' then ''4 - Alta''
when PROC_cd_prioridade = ''5'' then ''5 - Muito Alta'' end
as PROC_cd_ds_prioridade,

isnull((select top 1 MUNI_nm_municipio from tb_PMUN_processo_municipio X where A.PROC_cd_processo = X.PROC_cd_processo),''Não Informado'') as MUNI_nm_municipio

FROM 

DBDNPM..tb_PROC_processo A, 
DBDNPM..tb_FASE_fase B
--, 
--DBDNPM..tb_UNFE_unidade_federativa C

WHERE 


 -- Join: dbDNPM.tb_PROC_processo x dbDNPM.tb_FASE_fase
 -- Join: dbDNPM.tb_PROC_processo x dbDNPM.tb_UNFE_unidade_federativa


A.FASE_cd_fase = B.FASE_cd_fase and 

--A.UNFE_cd_unidade_federativa = C.UNFE_cd_unidade_federativa  AND 

(@PROC_cd_processo is null or (@PROC_cd_processo is not null and A.PROC_cd_processo = @PROC_cd_processo)) 
 AND (@PROC_ds_titular is null or (@PROC_ds_titular is not null and A.PROC_ds_titular = @PROC_ds_titular)) 
 AND (@PROC_vl_ano is null or (@PROC_vl_ano is not null and A.PROC_vl_ano = @PROC_vl_ano)) 
 AND (@PROC_nm_processo is null or (@PROC_nm_processo is not null and A.PROC_nm_processo = @PROC_nm_processo)) 
 AND (@FASE_cd_fase is null or (@FASE_cd_fase is not null and A.FASE_cd_fase = @FASE_cd_fase)) 
 AND (@PROC_ds_ultimo_evento is null or (@PROC_ds_ultimo_evento is not null and A.PROC_ds_ultimo_evento = @PROC_ds_ultimo_evento)) 
 AND (@PROC_ds_substancia is null or (@PROC_ds_substancia is not null and A.PROC_ds_substancia = @PROC_ds_substancia)) 
 AND (@PROC_ds_area is null or (@PROC_ds_area is not null and A.PROC_ds_area = @PROC_ds_area)) 
 AND (@PROC_ds_uso is null or (@PROC_ds_uso is not null and A.PROC_ds_uso = @PROC_ds_uso)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''PROC_cd_processo'' and rtrim(ltrim(A.PROC_cd_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_titular'' and rtrim(ltrim(A.PROC_ds_titular)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_vl_ano'' and rtrim(ltrim(A.PROC_vl_ano)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_nm_processo'' and rtrim(ltrim(A.PROC_nm_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_id_processo'' and rtrim(ltrim(A.PROC_id_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''FASE_cd_fase'' and rtrim(ltrim(A.FASE_cd_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_ultimo_evento'' and rtrim(ltrim(A.PROC_ds_ultimo_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_substancia'' and rtrim(ltrim(A.PROC_ds_substancia)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_area'' and rtrim(ltrim(A.PROC_ds_area)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_uso'' and rtrim(ltrim(A.PROC_ds_uso)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_ds_link'' and rtrim(ltrim(A.PROC_ds_link)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''UNFE_cd_unidade_federativa'' and rtrim(ltrim(A.UNFE_cd_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''PROC_fl_tipo_inclusao'' and rtrim(ltrim(A.PROC_fl_tipo_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''FASE_nm_fase'' and rtrim(ltrim(B.FASE_nm_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 --OR  (@whereField = ''UNFE_nm_unidade_federativa'' and rtrim(ltrim(C.UNFE_nm_unidade_federativa)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''ASC'' then A.PROC_cd_processo END ASC, 
 CASE when @sortField = ''PROC_cd_processo'' and  @sortOrder=''DESC'' then A.PROC_cd_processo END DESC 
 ,  CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''ASC'' then A.PROC_ds_titular END ASC, 
 CASE when @sortField = ''PROC_ds_titular'' and  @sortOrder=''DESC'' then A.PROC_ds_titular END DESC 
 ,  CASE when @sortField = ''PROC_vl_ano'' and  @sortOrder=''ASC'' then A.PROC_vl_ano END ASC, 
 CASE when @sortField = ''PROC_vl_ano'' and  @sortOrder=''DESC'' then A.PROC_vl_ano END DESC 
 ,  CASE when @sortField = ''PROC_nm_processo'' and  @sortOrder=''ASC'' then A.PROC_nm_processo END ASC, 
 CASE when @sortField = ''PROC_nm_processo'' and  @sortOrder=''DESC'' then A.PROC_nm_processo END DESC 
 ,  CASE when @sortField = ''PROC_id_processo'' and  @sortOrder=''ASC'' then A.PROC_id_processo END ASC, 
 CASE when @sortField = ''PROC_id_processo'' and  @sortOrder=''DESC'' then A.PROC_id_processo END DESC 
 ,  CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''ASC'' then A.FASE_cd_fase END ASC, 
 CASE when @sortField = ''FASE_cd_fase'' and  @sortOrder=''DESC'' then A.FASE_cd_fase END DESC 
 ,  CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''ASC'' then A.PROC_ds_ultimo_evento END ASC, 
 CASE when @sortField = ''PROC_ds_ultimo_evento'' and  @sortOrder=''DESC'' then A.PROC_ds_ultimo_evento END DESC 
 ,  CASE when @sortField = ''PROC_ds_substancia'' and  @sortOrder=''ASC'' then A.PROC_ds_substancia END ASC, 
 CASE when @sortField = ''PROC_ds_substancia'' and  @sortOrder=''DESC'' then A.PROC_ds_substancia END DESC 
 ,  CASE when @sortField = ''PROC_ds_area'' and  @sortOrder=''ASC'' then A.PROC_ds_area END ASC, 
 CASE when @sortField = ''PROC_ds_area'' and  @sortOrder=''DESC'' then A.PROC_ds_area END DESC 
 ,  CASE when @sortField = ''PROC_ds_uso'' and  @sortOrder=''ASC'' then A.PROC_ds_uso END ASC, 
 CASE when @sortField = ''PROC_ds_uso'' and  @sortOrder=''DESC'' then A.PROC_ds_uso END DESC 
 ,  CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''ASC'' then A.PROC_ds_link END ASC, 
 CASE when @sortField = ''PROC_ds_link'' and  @sortOrder=''DESC'' then A.PROC_ds_link END DESC 
 ,  CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''ASC'' then A.UNFE_cd_unidade_federativa END ASC, 
 CASE when @sortField = ''UNFE_cd_unidade_federativa'' and  @sortOrder=''DESC'' then A.UNFE_cd_unidade_federativa END DESC 
 ,  CASE when @sortField = ''PROC_fl_tipo_inclusao'' and  @sortOrder=''ASC'' then A.PROC_fl_tipo_inclusao END ASC, 
 CASE when @sortField = ''PROC_fl_tipo_inclusao'' and  @sortOrder=''DESC'' then A.PROC_fl_tipo_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 
 ,  CASE when @sortField = ''FASE_nm_fase'' and  @sortOrder=''ASC'' then B.FASE_nm_fase END ASC, 
 CASE when @sortField = ''FASE_nm_fase'' and  @sortOrder=''DESC'' then B.FASE_nm_fase END DESC 
 --,  CASE when @sortField = ''UNFE_nm_unidade_federativa'' and  @sortOrder=''ASC'' then C.UNFE_nm_unidade_federativa END ASC, 
 --CASE when @sortField = ''UNFE_nm_unidade_federativa'' and  @sortOrder=''DESC'' then C.UNFE_nm_unidade_federativa END DESC 

 
SELECT * FROM 
@tb_PROC_processo where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_lista]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo_lista]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_PROC_processo
create PROCEDURE [dbo].[sp_sel_tb_PROC_processo_lista]
@PROC_ls_titular varchar(8000) = null , 
@PROC_ls_fase varchar(1000) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_PROC_processo table (
id int identity primary key, 
PROC_cd_processo varchar(50) not null, 
PROC_ds_titular varchar(300) not null, 
PROC_vl_ano int null, 
PROC_nm_processo varchar(50) null, 
PROC_id_processo varchar(300) null, 
FASE_cd_fase int null, 
PROC_ds_ultimo_evento varchar(3000) null, 
PROC_ds_substancia varchar(100) null, 
PROC_ds_area varchar(30) null, 
PROC_ds_uso varchar(200) null, 
PROC_ds_link varchar(150) null, 
UNFE_cd_unidade_federativa char(2) null, 
PROC_fl_tipo_inclusao char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
FASE_nm_fase varchar(100) not null, 
UNFE_nm_unidade_federativa varchar(100) not null,
MUNI_nm_municipio varchar(150) null,
PROC_cd_prioridade varchar(3) not null,
PROC_ds_prioridade varchar(50) not null,
PROC_cd_ds_prioridade varchar(53) not null
)



insert into 
@tb_PROC_processo
(PROC_cd_processo, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 
FASE_nm_fase, 
UNFE_nm_unidade_federativa,
MUNI_nm_municipio,
PROC_cd_prioridade,
PROC_ds_prioridade,
PROC_cd_ds_prioridade) 

SELECT 
A.PROC_cd_processo as PROC_cd_processo, 
A.PROC_ds_titular as PROC_ds_titular, 
A.PROC_vl_ano as PROC_vl_ano, 
A.PROC_nm_processo as PROC_nm_processo, 
A.PROC_id_processo as PROC_id_processo, 
A.FASE_cd_fase as FASE_cd_fase, 
A.PROC_ds_ultimo_evento as PROC_ds_ultimo_evento, 
A.PROC_ds_substancia as PROC_ds_substancia, 
A.PROC_ds_area as PROC_ds_area, 
A.PROC_ds_uso as PROC_ds_uso, 
A.PROC_ds_link as PROC_ds_link, 
A.UNFE_cd_unidade_federativa as UNFE_cd_unidade_federativa, 
A.PROC_fl_tipo_inclusao as PROC_fl_tipo_inclusao, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 
B.FASE_nm_fase as FASE_nm_fase,
isnull((select UNFE_nm_unidade_federativa from tb_UNFE_unidade_federativa X where A.UNFE_cd_unidade_federativa = X.UNFE_cd_unidade_federativa),''00'') as UNFE_nm_unidade_federativa,
isnull((select top 1 MUNI_nm_municipio from tb_PMUN_processo_municipio X where A.PROC_cd_processo = X.PROC_cd_processo),''Não Informado'') as MUNI_nm_municipio,


PROC_cd_prioridade,

case 
when PROC_cd_prioridade = ''1'' then ''Muito Baixa''
when PROC_cd_prioridade = ''2'' then ''Baixa''
when PROC_cd_prioridade = ''3'' then ''Média''
when PROC_cd_prioridade = ''4'' then ''Alta''
when PROC_cd_prioridade = ''5'' then ''Muito Alta'' end
as
PROC_ds_prioridade,

case 
when PROC_cd_prioridade = ''1'' then ''1 - Muito Baixa''
when PROC_cd_prioridade = ''2'' then ''2 - Baixa''
when PROC_cd_prioridade = ''3'' then ''3 - Média''
when PROC_cd_prioridade = ''4'' then ''4 - Alta''
when PROC_cd_prioridade = ''5'' then ''5 - Muito Alta'' end
as PROC_cd_ds_prioridade

FROM 
DBDNPM..tb_PROC_processo A, 
DBDNPM..tb_FASE_fase B

WHERE 
A.FASE_cd_fase = B.FASE_cd_fase and 
(@PROC_ls_titular is null or (@PROC_ls_titular is not null and A.PROC_ds_titular in (select * from dbo.Split(@PROC_ls_titular,'','')) )) AND
(@PROC_ls_fase is null or (@PROC_ls_fase is not null and A.FASE_cd_fase in (select * from dbo.Split(@PROC_ls_fase,'','')) )) 
  
 ORDER BY PROC_ds_titular,PROC_cd_prioridade DESC
 
SELECT * FROM @tb_PROC_processo 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PROC_processo_documents]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PROC_processo_documents]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
--exec sp_sel_tb_PROC_processo_documents null
 

CREATE PROCEDURE [dbo].[sp_sel_tb_PROC_processo_documents]
@PROC_cd_processo varchar(50) = null 
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
declare @SQL varchar(1000)
declare @PARM_INI int 
declare @TIPO_DOC varchar(50)
declare @CAMPO_ID varchar(50)
declare @TABELA_DOC varchar(50)
declare @CAMPO_VENCTO varchar(50)
declare @CAMPO_INI varchar(50)
declare @ORGAO varchar(20)
declare @CAMPO_TIPO varchar(100)
 
create table #tb_DOCU_document (
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(20) not null,
PROC_nm_tipo_documento varchar(50) not null,
PROC_id_documento varchar(30) not null,
PROC_ds_titular varchar(300) not null, 
PROC_ds_link varchar(150) null, 
PROC_dt_vencimento datetime not null,
PROC_dt_publicacao datetime null,
PROC_qt_dias int not null,
PROC_qt_inicio int not null,
PROC_qt_intervalo int not null
)

-- pega parâmetro de inicio de envio
select @PARM_INI = PGER_vl_parametro from tb_PGER_parametro_geral where PGER_cd_parametro = ''INI''
if @PARM_INI is null or LEN(LTRIM(RTRIM(@PARM_INI))) = 0
 set @PARM_INI = 730  -- 2 anos



-- DNPM -> TÍTULOS
set @ORGAO = ''0'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',A.'' + @CAMPO_INI + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' AND A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''
raiserror(@sql,-1,-1)
exec(@sql)


-- DNPM -> CONDICOES PROP SOLO
set @ORGAO = ''0''
set @TIPO_DOC = ''CONDIÇÕES''
set @CAMPO_ID = ''COND_nm_condicao''
set @TABELA_DOC = ''tb_PCOn_processo_condicao''
set @CAMPO_VENCTO = ''PCON_dt_fim''
set @CAMPO_INI = ''PCON_dt_ini''
set @CAMPO_TIPO = ''PCON_ds_condicao''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,0, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',A.'' + @CAMPO_INI + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND C.ORGA_nm_orgao = ''''0'''' AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND C.ORGA_nm_orgao = ''''0'''' AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' AND A.'' + @CAMPO_VENCTO + '' is not null ''
raiserror(@sql,-1,-1)
exec(@sql)



-- CETESB -> SD
set @ORGAO = ''1''
set @TIPO_DOC = ''SD''
set @CAMPO_ID = ''PRSD_nm_sd''
set @TABELA_DOC = ''tb_PRSD_processo_sd''
set @CAMPO_VENCTO = ''PRSD_dt_fim''
set @CAMPO_INI = ''PRSD_dt_ini''
set @CAMPO_TIPO = ''OSSD_nm_objeto''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,1, '' + 
'' A.'' + @CAMPO_TIPO + '',  A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',A.'' + @CAMPO_INI + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' AND A.'' + @CAMPO_VENCTO + '' is not null ''
raiserror(@sql,-1,-1)
exec(@sql)



-- DAEE -> TÍTULOS
set @ORGAO = ''2'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '',  A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',A.'' + @CAMPO_INI + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' AND A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''
raiserror(@sql,-1,-1)
exec(@sql)


-- ICMBIO -> TÍTULOS
set @ORGAO = ''3'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '',  A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',A.'' + @CAMPO_INI + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' AND A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''
raiserror(@sql,-1,-1)
exec(@sql)


-- PETROBRÁS -> TÍTULOS
set @ORGAO = ''4'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '',  A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',A.'' + @CAMPO_INI + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' AND A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''
raiserror(@sql,-1,-1)
exec(@sql)


-- PFREFEITURAS -> TÍTULOS
set @ORGAO = ''5'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '',  A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',A.'' + @CAMPO_INI + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' AND A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''
raiserror(@sql,-1,-1)
exec(@sql)


select * from #tb_DOCU_document' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRMP_processo_mprima]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PRMP_processo_mprima
CREATE PROCEDURE [dbo].[sp_sel_tb_PRMP_processo_mprima]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_PRMP_processo_mprima
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PREV_processo_evento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PREV_processo_evento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_sel_tb_PREV_processo_evento]
@PROC_cd_processo varchar(50) = null , 
@PREV_id_evento varchar(20) = null 
 
AS
 
SELECT * FROM 
tb_PREV_processo_evento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PREV_id_evento is null or (@PREV_id_evento is not null and PREV_id_evento = @PREV_id_evento))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAN_processo_andamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PRAN_processo_andamento
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAN_processo_andamento]
@PROC_cd_processo varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_PRAN_processo_andamento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PRAL_processo_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_PRAL_processo_alerta]
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_PRAL_processo_alerta
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PORG_processo_orgao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PORG_processo_orgao
CREATE PROCEDURE [dbo].[sp_sel_tb_PORG_processo_orgao]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null 
 
AS
 
SELECT * FROM 
tb_PORG_processo_orgao
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PNOT_processo_nota]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PNOT_processo_nota
CREATE PROCEDURE [dbo].[sp_sel_tb_PNOT_processo_nota]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PNOT_cd_nota int = null 
 
AS
 
SELECT * FROM 
tb_PNOT_processo_nota
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PNOT_cd_nota is null or (@PNOT_cd_nota is not null and PNOT_cd_nota = @PNOT_cd_nota))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PMUN_processo_municipio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PMUN_processo_municipio
CREATE PROCEDURE [dbo].[sp_sel_tb_PMUN_processo_municipio]
@PROC_cd_processo varchar(50) = null , 
@MUNI_nm_municipio varchar(150) = null 
 
AS
 
SELECT * FROM 
tb_PMUN_processo_municipio
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@MUNI_nm_municipio is null or (@MUNI_nm_municipio is not null and MUNI_nm_municipio = @MUNI_nm_municipio))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PINF_processo_info]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PINF_processo_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PINF_processo_info
CREATE PROCEDURE [dbo].[sp_sel_tb_PINF_processo_info]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PINF_cd_info int = null 
 
AS
 
SELECT * FROM 
tb_PINF_processo_info
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PINF_cd_info is null or (@PINF_cd_info is not null and PINF_cd_info = @PINF_cd_info))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PGER_parametro_geral]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_sel_tb_PGER_parametro_geral]
@PGER_cd_parametro varchar(10) = null 
 
AS
 
SELECT * FROM 
tb_PGER_parametro_geral
 where (@PGER_cd_parametro is null or (@PGER_cd_parametro is not null and PGER_cd_parametro = @PGER_cd_parametro))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PDOC_processo_documento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PDOC_processo_documento
CREATE PROCEDURE [dbo].[sp_sel_tb_PDOC_processo_documento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PDOC_nm_documento varchar(100) = null , 
@PDOC_ds_path_documento varchar(500) = null 
 
AS
 
SELECT * FROM 
tb_PDOC_processo_documento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PDOC_nm_documento is null or (@PDOC_nm_documento is not null and PDOC_nm_documento = @PDOC_nm_documento))  AND 
(@PDOC_ds_path_documento is null or (@PDOC_ds_path_documento is not null and PDOC_ds_path_documento = @PDOC_ds_path_documento))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PCON_processo_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PCON_processo_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_PCON_processo_condicao]
@PROC_cd_processo varchar(50) = null , 
@PCON_cd_condicao int = null , 
@COND_nm_condicao varchar(500) = null 
 
AS
 
SELECT * FROM 
tb_PCON_processo_condicao
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PCON_cd_condicao is null or (@PCON_cd_condicao is not null and PCON_cd_condicao = @PCON_cd_condicao))  AND 
(@COND_nm_condicao is null or (@COND_nm_condicao is not null and COND_nm_condicao = @COND_nm_condicao))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PAUX_processo_auxiliar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PAUX_processo_auxiliar
CREATE PROCEDURE [dbo].[sp_sel_tb_PAUX_processo_auxiliar]
@PAUX_cd_processo varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_PAUX_processo_auxiliar
 where (@PAUX_cd_processo is null or (@PAUX_cd_processo is not null and PAUX_cd_processo = @PAUX_cd_processo))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_PASO_processo_associado]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_PASO_processo_associado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PASO_processo_associado
CREATE PROCEDURE [dbo].[sp_sel_tb_PASO_processo_associado]
@PROC_cd_processo varchar(50) = null , 
@PASO_cd_processo varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_PASO_processo_associado
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PASO_cd_processo is null or (@PASO_cd_processo is not null and PASO_cd_processo = @PASO_cd_processo))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OSSD_objeto_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_OSSD_objeto_sd
CREATE PROCEDURE [dbo].[sp_sel_tb_OSSD_objeto_sd]
@ORGA_nm_orgao varchar(10) = null , 
@OSSD_nm_objeto varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_OSSD_objeto_sd
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@OSSD_nm_objeto is null or (@OSSD_nm_objeto is not null and OSSD_nm_objeto = @OSSD_nm_objeto))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_OPER_operador]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_OPER_operador]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_sel_tb_OPER_operador]
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null 
 
AS
 
SELECT * FROM 
tb_OPER_operador
 where (@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  AND 
(@OPER_nm_operador is null or (@OPER_nm_operador is not null and OPER_nm_operador = @OPER_nm_operador))  AND 
(@OPER_ds_email is null or (@OPER_ds_email is not null and OPER_ds_email = @OPER_ds_email))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MUNI_municipio]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MUNI_municipio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_MUNI_municipio
CREATE PROCEDURE [dbo].[sp_sel_tb_MUNI_municipio]
@MUNI_nm_municipio varchar(150) = null 
 
AS
 
SELECT * FROM 
tb_MUNI_municipio
 where (@MUNI_nm_municipio is null or (@MUNI_nm_municipio is not null and MUNI_nm_municipio = @MUNI_nm_municipio))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_MPRI_mprima]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_MPRI_mprima]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_MPRI_mprima
CREATE PROCEDURE [dbo].[sp_sel_tb_MPRI_mprima]
@MPRI_nm_mprima varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_MPRI_mprima
 where (@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_LESI_log_erro_sistema]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_sel_tb_LESI_log_erro_sistema]
@LESI_cd_ocorrencia bigint = null 
 
AS
 
SELECT * FROM 
tb_LESI_log_erro_sistema
 where (@LESI_cd_ocorrencia is null or (@LESI_cd_ocorrencia is not null and LESI_cd_ocorrencia = @LESI_cd_ocorrencia))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_HSAL_historico_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_HSAL_historico_alerta]
@HSAL_id_historico int = null 
 
AS
 
SELECT * FROM 
tb_HSAL_historico_alerta
 where (@HSAL_id_historico is null or (@HSAL_id_historico is not null and HSAL_id_historico = @HSAL_id_historico))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_FASE_fase]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_FASE_fase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_sel_tb_FASE_fase]
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null 
 
AS
 
SELECT * FROM 
tb_FASE_fase
 where (@FASE_cd_fase is null or (@FASE_cd_fase is not null and FASE_cd_fase = @FASE_cd_fase))  AND 
(@FASE_nm_fase is null or (@FASE_nm_fase is not null and FASE_nm_fase = @FASE_nm_fase))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa_distinct]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_EMPR_empresa_distinct]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa_distinct]
 
AS
 
SELECT distinct upper(left(PROC_ds_titular,10)) as EMPR_nm_empresa, PROC_ds_titular as  EMPR_ds_empresa FROM 
tb_PROC_processo 

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_EMPR_empresa]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_EMPR_empresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_sel_tb_EMPR_empresa]
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null 
 
AS
 
SELECT * FROM 
tb_EMPR_empresa
 where (@EMPR_nm_empresa is null or (@EMPR_nm_empresa is not null and EMPR_nm_empresa = @EMPR_nm_empresa))  AND 
(@EMPR_ds_empresa is null or (@EMPR_ds_empresa is not null and EMPR_ds_empresa = @EMPR_ds_empresa))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COVE_controle_vencimento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_COVE_controle_vencimento
CREATE PROCEDURE [dbo].[sp_sel_tb_COVE_controle_vencimento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@COVE_nm_tipo_documento varchar(10) = null , 
@COVE_id_documento varchar(20) = null 
 
AS
 
SELECT * FROM 
tb_COVE_controle_vencimento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@COVE_nm_tipo_documento is null or (@COVE_nm_tipo_documento is not null and COVE_nm_tipo_documento = @COVE_nm_tipo_documento))  AND 
(@COVE_id_documento is null or (@COVE_id_documento is not null and COVE_id_documento = @COVE_id_documento))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_COND_condicao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_COND_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_COND_condicao
CREATE PROCEDURE [dbo].[sp_sel_tb_COND_condicao]
@COND_nm_condicao varchar(500) = null 
 
AS
 
SELECT * FROM 
tb_COND_condicao
 where (@COND_nm_condicao is null or (@COND_nm_condicao is not null and COND_nm_condicao = @COND_nm_condicao))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_BACK_backup]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_BACK_backup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_BACK_backup
CREATE PROCEDURE [dbo].[sp_sel_tb_BACK_backup]
@BACK_cd_backup int = null 
 
AS
 
SELECT * FROM 
tb_BACK_backup
 where (@BACK_cd_backup is null or (@BACK_cd_backup is not null and BACK_cd_backup = @BACK_cd_backup))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_AVEN_alerta_vencimento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_AVEN_alerta_vencimento
CREATE PROCEDURE [dbo].[sp_sel_tb_AVEN_alerta_vencimento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@AVEN_nm_tipo_documento varchar(40) = null , 
@AVEN_id_documento varchar(20) = null 
 
AS
 
SELECT * FROM 
tb_AVEN_alerta_vencimento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@AVEN_nm_tipo_documento is null or (@AVEN_nm_tipo_documento is not null and AVEN_nm_tipo_documento = @AVEN_nm_tipo_documento))  AND 
(@AVEN_id_documento is null or (@AVEN_id_documento is not null and AVEN_id_documento = @AVEN_id_documento))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta_rel]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ALER_alerta_rel]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 
--STORED PROCEDURE PARA CONSULTAR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_ALER_alerta_rel]
@startRowIndex int=null,
@maximumRows int=null,
@sortField nvarchar(100)= null,
@sortOrder nvarchar(4)= ''ASC'',
@whereField nvarchar(1000) = null,
@whereValue nvarchar(1000) = null
,
@ALER_nm_alerta varchar(50) = null , 
@ALER_ds_alerta varchar(300) = null , 
@ALER_fl_muda_fase char(1) = null , 
@ALER_fl_muda_evento char(1) = null , 
@ALER_cd_fase_anterior int = null , 
@ALER_cd_fase_nova int = null , 
@ALER_fl_qualquer_processo char(1) = null , 
@ALER_fl_status char(1) = null , 
@ALER_fl_sistema char(1) = null ,
@ALER_fl_geral char(1)= null,
@ALER_cd_evento varchar(5) = null,
@ALER_fl_andamento char(1) = null,
@ALER_fl_acao char(1) = null
 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
DECLARE @tb_ALER_alerta table (
id int identity primary key, 
ALER_nm_alerta varchar(50) not null, 
ALER_ds_alerta varchar(300) null, 
ALER_fl_muda_fase char(1) not null, 
ALER_fl_muda_evento char(1) not null, 
ALER_cd_fase_anterior int null, 
ALER_cd_fase_nova int null, 
ALER_fl_qualquer_processo char(1) not null, 
ALER_fl_status char(1) not null, 
ALER_fl_sistema char(1) not null, 
AUDT_dt_inclusao datetime not null, 
AUDT_nm_usuario_inclusao varchar(20) not null, 
AUDT_dt_alteracao datetime not null, 
AUDT_nm_usuario_alteracao varchar(20) not null, 
ALER_ds_fase_anterior varchar(100) NULL, 
ALER_ds_fase_nova varchar(100) NULL,
ALER_fl_geral char(1) NULL,
ALER_cd_evento varchar(5) null,
ALER_fl_andamento char(1) null,
ALER_fl_acao char(1) null
)



insert into 
@tb_ALER_alerta
(ALER_nm_alerta, 
ALER_ds_alerta, 
ALER_fl_muda_fase, 
ALER_fl_muda_evento, 
ALER_cd_fase_anterior, 
ALER_cd_fase_nova, 
ALER_fl_qualquer_processo, 
ALER_fl_status, 
ALER_fl_sistema, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao, 


ALER_ds_fase_anterior, 

ALER_ds_fase_nova,

ALER_fl_geral,

ALER_cd_evento,
ALER_fl_andamento,
ALER_fl_acao) 

SELECT 
A.ALER_nm_alerta as ALER_nm_alerta, 
A.ALER_ds_alerta as ALER_ds_alerta, 
A.ALER_fl_muda_fase as ALER_fl_muda_fase, 
A.ALER_fl_muda_evento as ALER_fl_muda_evento, 
A.ALER_cd_fase_anterior as ALER_cd_fase_anterior, 
A.ALER_cd_fase_nova as ALER_cd_fase_nova, 
A.ALER_fl_qualquer_processo as ALER_fl_qualquer_processo, 
A.ALER_fl_status as ALER_fl_status, 
A.ALER_fl_sistema as ALER_fl_sistema, 
A.AUDT_dt_inclusao as AUDT_dt_inclusao, 
A.AUDT_nm_usuario_inclusao as AUDT_nm_usuario_inclusao, 
A.AUDT_dt_alteracao as AUDT_dt_alteracao, 
A.AUDT_nm_usuario_alteracao as AUDT_nm_usuario_alteracao, 


(select FASE_nm_fase from tb_FASE_fase x where a.ALER_cd_fase_anterior = x.FASE_cd_fase) as ALER_ds_fase_anterior, 

(select FASE_nm_fase from tb_FASE_fase x where a.ALER_cd_fase_nova = x.FASE_cd_fase) as ALER_ds_fase_nova,

A.ALER_fl_geral as ALER_fl_geral,

A.ALER_cd_evento as ALER_cd_evento,

A.ALER_fl_andamento as ALER_fl_andamento, 
A.ALER_fl_acao as ALER_fl_acao

FROM 

DBDNPM..tb_ALER_alerta A

WHERE 




(@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and A.ALER_nm_alerta = @ALER_nm_alerta)) 
 AND (@ALER_ds_alerta is null or (@ALER_ds_alerta is not null and A.ALER_ds_alerta = @ALER_ds_alerta)) 
 AND (@ALER_fl_muda_fase is null or (@ALER_fl_muda_fase is not null and A.ALER_fl_muda_fase = @ALER_fl_muda_fase)) 
 AND (@ALER_fl_muda_evento is null or (@ALER_fl_muda_evento is not null and A.ALER_fl_muda_evento = @ALER_fl_muda_evento)) 
 AND (@ALER_cd_fase_anterior is null or (@ALER_cd_fase_anterior is not null and A.ALER_cd_fase_anterior = @ALER_cd_fase_anterior)) 
 AND (@ALER_cd_fase_nova is null or (@ALER_cd_fase_nova is not null and A.ALER_cd_fase_nova = @ALER_cd_fase_nova)) 
 AND (@ALER_fl_qualquer_processo is null or (@ALER_fl_qualquer_processo is not null and A.ALER_fl_qualquer_processo = @ALER_fl_qualquer_processo)) 
 AND (@ALER_fl_status is null or (@ALER_fl_status is not null and A.ALER_fl_status = @ALER_fl_status)) 
 AND (@ALER_fl_sistema is null or (@ALER_fl_sistema is not null and A.ALER_fl_sistema = @ALER_fl_sistema)) 
 AND (@ALER_fl_geral is null or (@ALER_fl_geral is not null and A.ALER_fl_geral = @ALER_fl_geral)) 
 AND (@ALER_fl_andamento is null or (@ALER_fl_andamento is not null and A.ALER_fl_andamento = @ALER_fl_andamento)) 
 AND (@ALER_fl_acao is null or (@ALER_fl_acao is not null and A.ALER_fl_acao = @ALER_fl_acao)) 
  AND 

(@whereField IS NULL OR 

 (@whereField = ''ALER_nm_alerta'' and rtrim(ltrim(A.ALER_nm_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_ds_alerta'' and rtrim(ltrim(A.ALER_ds_alerta)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_muda_fase'' and rtrim(ltrim(A.ALER_fl_muda_fase)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_muda_evento'' and rtrim(ltrim(A.ALER_fl_muda_evento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_cd_fase_anterior'' and rtrim(ltrim(A.ALER_cd_fase_anterior)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_cd_fase_nova'' and rtrim(ltrim(A.ALER_cd_fase_nova)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_qualquer_processo'' and rtrim(ltrim(A.ALER_fl_qualquer_processo)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_status'' and rtrim(ltrim(A.ALER_fl_status)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_sistema'' and rtrim(ltrim(A.ALER_fl_sistema)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_inclusao'' and rtrim(ltrim(A.AUDT_dt_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_inclusao'' and rtrim(ltrim(A.AUDT_nm_usuario_inclusao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_dt_alteracao'' and rtrim(ltrim(A.AUDT_dt_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''AUDT_nm_usuario_alteracao'' and rtrim(ltrim(A.AUDT_nm_usuario_alteracao)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_geral'' and rtrim(ltrim(A.ALER_fl_geral)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_andamento'' and rtrim(ltrim(A.ALER_fl_andamento)) LIKE  rtrim(ltrim(@whereValue)) )  
 OR  (@whereField = ''ALER_fl_acao'' and rtrim(ltrim(A.ALER_fl_acao)) LIKE  rtrim(ltrim(@whereValue)) )  
 )  


 
 ORDER BY  
 CASE when @sortField = ''ALER_nm_alerta'' and  @sortOrder=''ASC'' then A.ALER_nm_alerta END ASC, 
 CASE when @sortField = ''ALER_nm_alerta'' and  @sortOrder=''DESC'' then A.ALER_nm_alerta END DESC 
 ,  CASE when @sortField = ''ALER_ds_alerta'' and  @sortOrder=''ASC'' then A.ALER_ds_alerta END ASC, 
 CASE when @sortField = ''ALER_ds_alerta'' and  @sortOrder=''DESC'' then A.ALER_ds_alerta END DESC 
 ,  CASE when @sortField = ''ALER_fl_muda_fase'' and  @sortOrder=''ASC'' then A.ALER_fl_muda_fase END ASC, 
 CASE when @sortField = ''ALER_fl_muda_fase'' and  @sortOrder=''DESC'' then A.ALER_fl_muda_fase END DESC 
 ,  CASE when @sortField = ''ALER_fl_muda_evento'' and  @sortOrder=''ASC'' then A.ALER_fl_muda_evento END ASC, 
 CASE when @sortField = ''ALER_fl_muda_evento'' and  @sortOrder=''DESC'' then A.ALER_fl_muda_evento END DESC 
 ,  CASE when @sortField = ''ALER_cd_fase_anterior'' and  @sortOrder=''ASC'' then A.ALER_cd_fase_anterior END ASC, 
 CASE when @sortField = ''ALER_cd_fase_anterior'' and  @sortOrder=''DESC'' then A.ALER_cd_fase_anterior END DESC 
 ,  CASE when @sortField = ''ALER_cd_fase_nova'' and  @sortOrder=''ASC'' then A.ALER_cd_fase_nova END ASC, 
 CASE when @sortField = ''ALER_cd_fase_nova'' and  @sortOrder=''DESC'' then A.ALER_cd_fase_nova END DESC 
 ,  CASE when @sortField = ''ALER_fl_qualquer_processo'' and  @sortOrder=''ASC'' then A.ALER_fl_qualquer_processo END ASC, 
 CASE when @sortField = ''ALER_fl_qualquer_processo'' and  @sortOrder=''DESC'' then A.ALER_fl_qualquer_processo END DESC 
 ,  CASE when @sortField = ''ALER_fl_status'' and  @sortOrder=''ASC'' then A.ALER_fl_status END ASC, 
 CASE when @sortField = ''ALER_fl_status'' and  @sortOrder=''DESC'' then A.ALER_fl_status END DESC 
 ,  CASE when @sortField = ''ALER_fl_sistema'' and  @sortOrder=''ASC'' then A.ALER_fl_sistema END ASC, 
 CASE when @sortField = ''ALER_fl_sistema'' and  @sortOrder=''DESC'' then A.ALER_fl_sistema END DESC 
 ,  CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_dt_inclusao END ASC, 
 CASE when @sortField = ''AUDT_dt_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_dt_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_inclusao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_inclusao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_inclusao END DESC 
 ,  CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_dt_alteracao END ASC, 
 CASE when @sortField = ''AUDT_dt_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_dt_alteracao END DESC 
 ,  CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''AUDT_nm_usuario_alteracao'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 
 ,  CASE when @sortField = ''ALER_fl_geral'' and  @sortOrder=''ASC'' then A.AUDT_nm_usuario_alteracao END ASC, 
 CASE when @sortField = ''ALER_fl_geral'' and  @sortOrder=''DESC'' then A.AUDT_nm_usuario_alteracao END DESC 
 
 ,  CASE when @sortField = ''ALER_fl_andamento'' and  @sortOrder=''ASC'' then A.ALER_fl_andamento END ASC, 
 CASE when @sortField = ''ALER_fl_andamento'' and  @sortOrder=''DESC'' then A.ALER_fl_andamento END DESC 
 ,  CASE when @sortField = ''ALER_fl_acao'' and  @sortOrder=''ASC'' then A.ALER_fl_acao END ASC, 
 CASE when @sortField = ''ALER_fl_acao'' and  @sortOrder=''DESC'' then A.ALER_fl_acao END DESC 
 

 
SELECT * FROM 
@tb_ALER_alerta where
((@maximumRows > 0 and
id > @startRowIndex and 
id <= (@startRowIndex + @maximumRows)) or
@maximumRows <= 0) 


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_tb_ALER_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_tb_ALER_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_sel_tb_ALER_alerta]
@ALER_nm_alerta varchar(50) = null 
 
AS
 
SELECT * FROM 
tb_ALER_alerta
 where (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))   


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_eventos]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_eventos]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

--exec sp_sel_eventos
 
-- STORED PROCEDURE PARA SELECIONAR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_sel_eventos]

 
AS
 
declare @temp table(
 codigo varchar(20) not null,
 descricao varchar(200) not null
)

insert @temp
select distinct LEFT(PROC_ds_ultimo_evento,CHARINDEX('' - '',PROC_ds_ultimo_evento,0)) as Codigo, 
left(PROC_ds_ultimo_evento,LEN(PROC_ds_ultimo_evento)-13) as Evento 
from tb_PROC_processo 
union
select distinct LEFT(PAUX_ds_ultimo_evento,CHARINDEX('' - '',PAUX_ds_ultimo_evento,0)) as Codigo, 
left(PAUX_ds_ultimo_evento,LEN(PAUX_ds_ultimo_evento)-13) as Evento 
from tb_PAUX_processo_auxiliar

select distinct codigo,descricao as evento from @temp


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_sel_documentos_relatorio]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_sel_documentos_relatorio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

 

CREATE PROCEDURE [dbo].[sp_sel_documentos_relatorio]
@PROC_ls_processo varchar(8000) = null ,
@PROC_ds_titular varchar(500) = null,
@PROC_ls_documento varchar(1000) = null,
@ORGA_nm_orgao varchar(50) = null,
@PROC_qt_dias_vencer int = null,
@PROC_ls_tipo varchar(50) = null,
@PROC_dt_publicacao_ini datetime = null,
@PROC_dt_publicacao_fim datetime = null,
@PROC_dt_vencimento_ini datetime = null,
@PROC_dt_vencimento_fim datetime = null,
@PROC_ls_titular varchar(8000) = null,
@PROC_ls_fase varchar(1000) = null

 
AS
 
 SET DATEFORMAT DMY 
 set nocount on 
 
declare @SQL varchar(8000)
declare @PARM_INI int 
declare @TIPO_DOC varchar(50)
declare @CAMPO_ID varchar(50)
declare @TABELA_DOC varchar(50)
declare @CAMPO_VENCTO varchar(50)
declare @CAMPO_INI varchar(50)
declare @ORGAO varchar(20)
declare @CAMPO_TIPO varchar(100)

 
create table #tb_DOCU_document (
PROC_cd_processo varchar(50) not null, 
ORGA_nm_orgao varchar(20) not null,
PROC_nm_tipo_documento varchar(100) not null,
PROC_id_documento varchar(30) not null,
PROC_ds_titular varchar(300) not null, 
PROC_ds_link varchar(150) null, 
PROC_dt_vencimento datetime not null,
PROC_dt_publicacao datetime null,
PROC_qt_dias int not null,
PROC_qt_inicio int not null,
PROC_qt_intervalo int not null,
PROC_fl_publicacao char(1) not null
)

-- pega parâmetro de inicio de envio
select @PARM_INI = PGER_vl_parametro from tb_PGER_parametro_geral where PGER_cd_parametro = ''INI''
if @PARM_INI is null or LEN(LTRIM(RTRIM(@PARM_INI))) = 0
 set @PARM_INI = 730  -- 2 anos



-- DNPM -> TÍTULOS
set @ORGAO = ''0'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',isnull(A.'' + @CAMPO_INI + '',getdate())'' + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',case when '' + @CAMPO_INI + '' is not null then ''''S'''' else ''''N'''' end '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE ltrim(rtrim(A.PROC_cd_processo)) = ltrim(rtrim(B.PROC_cd_processo)) AND '' + 
--''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''


-- filtro do processo 
if @PROC_ls_processo is not null
begin
 SET @SQL = @SQL + '' and A.PROC_cd_processo in (select * from dbo.Split('''''' + @PROC_ls_processo + '''''','''','''' ) ) ''
end

if @PROC_ls_titular is not null
begin
 SET @SQL = @SQL + '' and B.PROC_ds_titular in ('' + @PROC_ls_titular + '') ''
end

if @PROC_ls_fase is not null
begin
 SET @SQL = @SQL + '' and B.FASE_cd_fase in ('' + @PROC_ls_fase + '') ''
end

raiserror(@sql,-1,-1)
exec(@sql)


-- DNPM -> CONDICOES PROP SOLO
set @ORGAO = ''0''
set @TIPO_DOC = ''CONDIÇÕES''
set @CAMPO_ID = ''COND_nm_condicao''
set @TABELA_DOC = ''tb_PCOn_processo_condicao''
set @CAMPO_VENCTO = ''PCON_dt_fim''
set @CAMPO_INI = ''PCON_dt_ini''
set @CAMPO_TIPO = ''PCON_ds_condicao''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,0, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',isnull(A.'' + @CAMPO_INI + '',getdate())'' + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND C.ORGA_nm_orgao = ''''0'''' AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND C.ORGA_nm_orgao = ''''0'''' AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',case when '' + @CAMPO_INI + '' is not null then ''''S'''' else ''''N'''' end '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
--''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' A.'' + @CAMPO_VENCTO + '' is not null ''

-- filtro do processo 
if @PROC_ls_processo is not null
begin
 SET @SQL = @SQL + '' and A.PROC_cd_processo in (select * from dbo.Split('''''' + @PROC_ls_processo + '''''','''','''' ) ) ''
end


if @PROC_ls_titular is not null
begin
 SET @SQL = @SQL + '' and B.PROC_ds_titular in ('' + @PROC_ls_titular + '') ''
end

if @PROC_ls_fase is not null
begin
 SET @SQL = @SQL + '' and B.FASE_cd_fase in ('' + @PROC_ls_fase + '') ''
end

raiserror(@sql,-1,-1)
exec(@sql)



-- CETESB -> SD
set @ORGAO = ''1''
set @TIPO_DOC = ''SD''
set @CAMPO_ID = ''PRSD_nm_sd''
set @TABELA_DOC = ''tb_PRSD_processo_sd''
set @CAMPO_VENCTO = ''PRSD_dt_fim''
set @CAMPO_INI = ''PRSD_dt_ini''
set @CAMPO_TIPO = ''OSSD_nm_objeto''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,1, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',isnull(A.'' + @CAMPO_INI + '',getdate())'' + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',case when '' + @CAMPO_INI + '' is not null then ''''S'''' else ''''N'''' end '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
--''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ ''  A.'' + @CAMPO_VENCTO + '' is not null ''

-- filtro do processo 
if @PROC_ls_processo is not null
begin
 SET @SQL = @SQL + '' and A.PROC_cd_processo in (select * from dbo.Split('''''' + @PROC_ls_processo + '''''','''','''' ) ) ''
end

if @PROC_ls_titular is not null
begin
 SET @SQL = @SQL + '' and B.PROC_ds_titular in ('' + @PROC_ls_titular + '') ''
end

if @PROC_ls_fase is not null
begin
 SET @SQL = @SQL + '' and B.FASE_cd_fase in ('' + @PROC_ls_fase + '') ''
end

raiserror(@sql,-1,-1)
exec(@sql)



-- DAEE -> TÍTULOS
set @ORGAO = ''2'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',isnull(A.'' + @CAMPO_INI + '',getdate())'' + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',case when '' + @CAMPO_INI + '' is not null then ''''S'''' else ''''N'''' end '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
--''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''

-- filtro do processo 
if @PROC_ls_processo is not null
begin
 SET @SQL = @SQL + '' and A.PROC_cd_processo in (select * from dbo.Split('''''' + @PROC_ls_processo + '''''','''','''' ) ) ''
end

if @PROC_ls_titular is not null
begin
 SET @SQL = @SQL + '' and B.PROC_ds_titular in ('' + @PROC_ls_titular + '') ''
end

if @PROC_ls_fase is not null
begin
 SET @SQL = @SQL + '' and B.FASE_cd_fase in ('' + @PROC_ls_fase + '') ''
end

raiserror(@sql,-1,-1)
exec(@sql)


-- ICMBIO -> TÍTULOS
set @ORGAO = ''3'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',isnull(A.'' + @CAMPO_INI + '',getdate())'' + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',case when '' + @CAMPO_INI + '' is not null then ''''S'''' else ''''N'''' end '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
--''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''

-- filtro do processo 
if @PROC_ls_processo is not null
begin
 SET @SQL = @SQL + '' and A.PROC_cd_processo in (select * from dbo.Split('''''' + @PROC_ls_processo + '''''','''','''' ) ) ''
end

if @PROC_ls_titular is not null
begin
 SET @SQL = @SQL + '' and B.PROC_ds_titular in ('' + @PROC_ls_titular + '') ''
end

if @PROC_ls_fase is not null
begin
 SET @SQL = @SQL + '' and B.FASE_cd_fase in ('' + @PROC_ls_fase + '') ''
end

raiserror(@sql,-1,-1)
exec(@sql)


-- PETROBRÁS -> TÍTULOS
set @ORGAO = ''4'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',isnull(A.'' + @CAMPO_INI + '',getdate())'' + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',case when '' + @CAMPO_INI + '' is not null then ''''S'''' else ''''N'''' end '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
--''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''

-- filtro do processo 
if @PROC_ls_processo is not null
begin
 SET @SQL = @SQL + '' and A.PROC_cd_processo in (select * from dbo.Split('''''' + @PROC_ls_processo + '''''','''','''' ) ) ''
end

if @PROC_ls_titular is not null
begin
 SET @SQL = @SQL + '' and B.PROC_ds_titular in ('' + @PROC_ls_titular + '') ''
end

if @PROC_ls_fase is not null
begin
 SET @SQL = @SQL + '' and B.FASE_cd_fase in ('' + @PROC_ls_fase + '') ''
end

raiserror(@sql,-1,-1)
exec(@sql)


-- PFREFEITURAS -> TÍTULOS
set @ORGAO = ''5'' 
set @TIPO_DOC = ''TÍTULO''
set @CAMPO_ID = ''PTIT_nm_titulo''
set @TABELA_DOC = ''tb_PTIT_processo_titulo''
set @CAMPO_VENCTO = ''PTIT_dt_vencimento''
set @CAMPO_INI = ''PTIT_dt_publicacao''
set @CAMPO_TIPO = ''TTIT_ds_tipo_titulo''
SET @SQL = ''insert into #tb_DOCU_document select A.PROC_cd_processo,A.ORGA_nm_orgao, '' + 
'' A.'' + @CAMPO_TIPO + '', A.'' + @CAMPO_ID + '', B.PROC_ds_titular, B.PROC_ds_link, A.'' + @CAMPO_VENCTO + 
'',isnull(A.'' + @CAMPO_INI + '',getdate())'' + 
'',DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') '' + 
'',isnull((select COVE_qt_inicio from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',isnull((select COVE_qt_intervalo from TB_COVE_controle_vencimento C where A.PROC_cd_processo = C.PROC_cd_processo AND A.ORGA_nm_orgao = C.ORGA_nm_orgao AND A.'' + @CAMPO_ID  + '' = C.COVE_id_documento),0) '' +
'',case when '' + @CAMPO_INI + '' is not null then ''''S'''' else ''''N'''' end '' +
'' FROM '' + @TABELA_DOC + '' A, tb_PROC_processo B WHERE A.PROC_cd_processo = B.PROC_cd_processo AND '' + 
--''DATEDIFF(day,getdate(),A.'' + @CAMPO_VENCTO + '') <= '' + convert(varchar(3),@PARM_INI)
+ '' A.ORGA_nm_orgao = '' + @ORGAO + '' AND A.'' + @CAMPO_VENCTO + '' is not null ''

-- filtro do processo 
if @PROC_ls_processo is not null
begin
 SET @SQL = @SQL + '' and A.PROC_cd_processo in (select * from dbo.Split('''''' + @PROC_ls_processo + '''''','''','''' ) ) ''
end


if @PROC_ls_titular is not null
begin
 SET @SQL = @SQL + '' and B.PROC_ds_titular in ('' + @PROC_ls_titular + '') ''
end

if @PROC_ls_fase is not null
begin
 SET @SQL = @SQL + '' and B.FASE_cd_fase in ('' + @PROC_ls_fase + '') ''
end

raiserror(@sql,-1,-1)
exec(@sql)

--select * from #tb_DOCU_document
--return

select PROC_cd_processo,
case 
when ORGA_nm_orgao = 0 then ''DNPM''
when ORGA_nm_orgao = 1 then ''CETES''
when ORGA_nm_orgao = 2 then ''DAEE''
when ORGA_nm_orgao = 3 then ''ICMBIO''
when ORGA_nm_orgao = 4 then ''PETROBRÁS''
when ORGA_nm_orgao = 5 then ''PREFEITURAS'' end as ORGA_nm_orgao,
PROC_nm_tipo_documento,
PROC_id_documento,
PROC_ds_titular,
PROC_ds_link,
PROC_dt_vencimento,
PROC_dt_publicacao,

PROC_cd_processo + ''<br />'' + 
case 
when ORGA_nm_orgao = 0 then ''DNPM''
when ORGA_nm_orgao = 1 then ''CETES''
when ORGA_nm_orgao = 2 then ''DAEE''
when ORGA_nm_orgao = 3 then ''ICMBIO''
when ORGA_nm_orgao = 4 then ''PETROBRÁS''
when ORGA_nm_orgao = 5 then ''PREFEITURAS'' end + ''<br />'' +
PROC_id_documento as PROC_ds_documento,

PROC_qt_inicio,
PROC_qt_intervalo,

PROC_qt_dias,
DATEDIFF(DAY,PROC_dt_publicacao,GETDATE()) as PROC_qt_dias_passados,
DATEDIFF(DAY,PROC_dt_publicacao,PROC_dt_vencimento) as PROC_qt_dias_total,

case when DATEDIFF(DAY,PROC_dt_publicacao,PROC_dt_vencimento)<>0 then
((convert(decimal(6,2),DATEDIFF(DAY,PROC_dt_publicacao,getdate()))/
convert(decimal(6,2),DATEDIFF(DAY,PROC_dt_publicacao,PROC_dt_vencimento))) * 100.00) else
100.00 end
as PROC_pc_vencto,


case when DATEDIFF(DAY,PROC_dt_publicacao,dateadd(day,-PROC_qt_inicio,PROC_dt_vencimento)) > 0 then
((convert(decimal(6,2),DATEDIFF(DAY,PROC_dt_publicacao,getdate()))/
convert(decimal(6,2),DATEDIFF(DAY,PROC_dt_publicacao,dateadd(day,-PROC_qt_inicio,PROC_dt_vencimento)))) * 100.00) 
else 100.00 end as PROC_pc_limite,

100.00 as PROC_pc_total,

''de '' + case when PROC_fl_publicacao  = ''S'' then 
CONVERT(char(10),PROC_dt_publicacao,105) else ''Não Informada'' end +
'' a '' + convert(char(10),PROC_dt_vencimento,105)
as PROC_ds_data



from #tb_DOCU_document
where
PROC_qt_dias>=0 AND --nao vencidos
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao in (select * from dbo.Split(@ORGA_nm_orgao,'','')) )) AND
(@PROC_ls_documento is null or (@PROC_ls_documento is not null and PROC_id_documento in (select * from dbo.Split(@PROC_ls_documento,'','')) )) AND
(@PROC_ls_tipo is null or (@PROC_ls_tipo is not null and ltrim(rtrim(PROC_nm_tipo_documento)) in (select * from dbo.Split(@PROC_ls_tipo,'','')) )) AND

(@PROC_dt_publicacao_ini is null or (@PROC_dt_publicacao_ini is not null and PROC_dt_publicacao >= @PROC_dt_publicacao_ini )) AND
(@PROC_dt_publicacao_fim is null or (@PROC_dt_publicacao_fim is not null and PROC_dt_publicacao <= @PROC_dt_publicacao_fim )) AND

(@PROC_dt_vencimento_ini is null or (@PROC_dt_vencimento_ini is not null and PROC_dt_vencimento >= @PROC_dt_vencimento_ini )) AND
(@PROC_dt_vencimento_fim is null or (@PROC_dt_vencimento_fim is not null and PROC_dt_vencimento <= @PROC_dt_vencimento_fim )) AND

(@PROC_qt_dias_vencer is null or (@PROC_qt_dias_vencer is not null and PROC_qt_dias <= @PROC_qt_dias_vencer )) AND

(@PROC_ds_titular is null or (@PROC_ds_titular is not null and PROC_ds_titular like ''%'' + @PROC_ds_titular + ''%'' )) 


order by PROC_qt_dias desc


' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_UPRD_uso_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_UPRD_uso_produto
CREATE PROCEDURE [dbo].[sp_ins_tb_UPRD_uso_produto]
@UPRD_nm_uso varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_UPRD_uso_produto
  (UPRD_nm_uso, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@UPRD_nm_uso, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_UNME_unidade_medida]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_UNME_unidade_medida
CREATE PROCEDURE [dbo].[sp_ins_tb_UNME_unidade_medida]
@UNME_nm_unidade varchar(10) = null , 
@UNME_ds_unidade varchar(100) = null , 
@UNME_nm_tipo char(2) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_UNME_unidade_medida
  (UNME_nm_unidade, 
UNME_ds_unidade, 
UNME_nm_tipo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@UNME_nm_unidade, 
@UNME_ds_unidade, 
@UNME_nm_tipo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_UNFE_unidade_federativa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_ins_tb_UNFE_unidade_federativa]
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null , 
@UNFE_fl_status char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_UNFE_unidade_federativa
  (UNFE_cd_unidade_federativa, 
UNFE_nm_unidade_federativa, 
UNFE_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@UNFE_cd_unidade_federativa, 
@UNFE_nm_unidade_federativa, 
@UNFE_fl_status, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_TUSO_tipo_uso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_TUSO_tipo_uso
CREATE PROCEDURE [dbo].[sp_ins_tb_TUSO_tipo_uso]
@TUSO_nm_uso varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_TUSO_tipo_uso
  (TUSO_nm_uso, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@TUSO_nm_uso, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_TTIT_tipo_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_TTIT_tipo_titulo
CREATE PROCEDURE [dbo].[sp_ins_tb_TTIT_tipo_titulo]
@ORGA_nm_orgao varchar(10) = null , 
@TTIT_ds_tipo_titulo varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_TTIT_tipo_titulo
  (ORGA_nm_orgao, 
TTIT_ds_tipo_titulo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ORGA_nm_orgao, 
@TTIT_ds_tipo_titulo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_TINF_tipo_info]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_TINF_tipo_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_TINF_tipo_info
CREATE PROCEDURE [dbo].[sp_ins_tb_TINF_tipo_info]
@ORGA_nm_orgao varchar(10) = null , 
@TINF_nm_tipo_info varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_TINF_tipo_info
  (ORGA_nm_orgao, 
TINF_nm_tipo_info, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ORGA_nm_orgao, 
@TINF_nm_tipo_info, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_TABE_tabela]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_TABE_tabela]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_TABE_tabela
CREATE PROCEDURE [dbo].[sp_ins_tb_TABE_tabela]
@TABE_nm_tabela varchar(50) = null , 
@TABE_ds_tabela varchar(200) = null , 
@TABE_ds_selectall varchar(1000) = null , 
@TABE_ds_selectcheck varchar(1000) = null , 
@TABE_ds_deleleone varchar(1000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_TABE_tabela
  (TABE_nm_tabela, 
TABE_ds_tabela, 
TABE_ds_selectall, 
TABE_ds_selectcheck, 
TABE_ds_deleleone, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@TABE_nm_tabela, 
@TABE_ds_tabela, 
@TABE_ds_selectall, 
@TABE_ds_selectcheck, 
@TABE_ds_deleleone, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SUBS_substancia]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SUBS_substancia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_SUBS_substancia
CREATE PROCEDURE [dbo].[sp_ins_tb_SUBS_substancia]
@SUBS_nm_substancia varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_SUBS_substancia
  (SUBS_nm_substancia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@SUBS_nm_substancia, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SITU_situacao_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_SITU_situacao_titulo
CREATE PROCEDURE [dbo].[sp_ins_tb_SITU_situacao_titulo]
@ORGA_nm_orgao varchar(10) = null , 
@SITU_ds_situacao_titulo varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_SITU_situacao_titulo
  (ORGA_nm_orgao, 
SITU_ds_situacao_titulo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ORGA_nm_orgao, 
@SITU_ds_situacao_titulo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SISD_situacao_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_SISD_situacao_sd
CREATE PROCEDURE [dbo].[sp_ins_tb_SISD_situacao_sd]
@ORGA_nm_orgao varchar(10) = null , 
@SISD_nm_situacao_sd varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_SISD_situacao_sd
  (ORGA_nm_orgao, 
SISD_nm_situacao_sd, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ORGA_nm_orgao, 
@SISD_nm_situacao_sd, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SINF_situacao_info]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SINF_situacao_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_SINF_situacao_info
CREATE PROCEDURE [dbo].[sp_ins_tb_SINF_situacao_info]
@ORGA_nm_orgao varchar(10) = null , 
@SINF_ds_situacao_info varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_SINF_situacao_info
  (ORGA_nm_orgao, 
SINF_ds_situacao_info, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ORGA_nm_orgao, 
@SINF_ds_situacao_info, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_SCON_situacao_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_SCON_situacao_condicao
CREATE PROCEDURE [dbo].[sp_ins_tb_SCON_situacao_condicao]
@ORGA_nm_orgao varchar(10) = null , 
@SCON_ds_situacao_condicao varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_SCON_situacao_condicao
  (ORGA_nm_orgao, 
SCON_ds_situacao_condicao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ORGA_nm_orgao, 
@SCON_ds_situacao_condicao, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_ROTI_rotina]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_ROTI_rotina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_ins_tb_ROTI_rotina]
@ROTI_nm_rotina varchar(30) = null , 
@ROTI_ds_rotina varchar(300) = null , 
@ROTI_dt_ultima_execucao datetime = null , 
@ROTI_dt_ultima_tentativa_execucao datetime = null , 
@ROTI_fl_status_execucao char(1) = null , 
@ROTI_ds_mensagem varchar(1000) = null , 
@ROTI_vl_tempo_medio decimal(13, 2) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@ROTI_dt_inicio_execucao datetime = null  
AS
 
 
  INSERT 
  tb_ROTI_rotina
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
AUDT_nm_usuario_alteracao,
ROTI_dt_inicio_execucao)
  VALUES 
  (@ROTI_nm_rotina, 
@ROTI_ds_rotina, 
@ROTI_dt_ultima_execucao, 
@ROTI_dt_ultima_tentativa_execucao, 
@ROTI_fl_status_execucao, 
@ROTI_ds_mensagem, 
@ROTI_vl_tempo_medio, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao,
@ROTI_dt_inicio_execucao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PTIT_processo_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PTIT_processo_titulo
CREATE PROCEDURE [dbo].[sp_ins_tb_PTIT_processo_titulo]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PTIT_nm_titulo varchar(50) = null , 
@PTIT_ds_titulo varchar(300) = null , 
@TTIT_ds_tipo_titulo varchar(100) = null , 
@SITU_ds_situacao_titulo varchar(100) = null , 
@PTIT_dt_publicacao datetime = null , 
@PTIT_dt_vencimento datetime = null , 
@PTIT_ds_nome_documento varchar(1000) = null , 
@PTIT_ds_local_documento varchar(1000) = null , 
@PTIT_ds_rede_documento varchar(1000) = null , 
@PTIT_ds_path_documento varchar(1000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PTIT_processo_titulo
  (PROC_cd_processo, 
ORGA_nm_orgao, 
PTIT_nm_titulo, 
PTIT_ds_titulo, 
TTIT_ds_tipo_titulo, 
SITU_ds_situacao_titulo, 
PTIT_dt_publicacao, 
PTIT_dt_vencimento, 
PTIT_ds_nome_documento, 
PTIT_ds_local_documento, 
PTIT_ds_rede_documento, 
PTIT_ds_path_documento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@PTIT_nm_titulo, 
@PTIT_ds_titulo, 
@TTIT_ds_tipo_titulo, 
@SITU_ds_situacao_titulo, 
@PTIT_dt_publicacao, 
@PTIT_dt_vencimento, 
@PTIT_ds_nome_documento, 
@PTIT_ds_local_documento, 
@PTIT_ds_rede_documento, 
@PTIT_ds_path_documento, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PSUB_processo_substancia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PSUB_processo_substancia
CREATE PROCEDURE [dbo].[sp_ins_tb_PSUB_processo_substancia]
@PROC_cd_processo varchar(50) = null , 
@SUBS_nm_substancia varchar(100) = null , 
@TUSO_nm_uso varchar(100) = null , 
@PSUB_dt_inicio date = null , 
@PSUB_dt_fim date = null , 
@PSUB_ds_motivo varchar(500) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PSUB_processo_substancia
  (PROC_cd_processo, 
SUBS_nm_substancia, 
TUSO_nm_uso, 
PSUB_dt_inicio, 
PSUB_dt_fim, 
PSUB_ds_motivo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@SUBS_nm_substancia, 
@TUSO_nm_uso, 
@PSUB_dt_inicio, 
@PSUB_dt_fim, 
@PSUB_ds_motivo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRSD_processo_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PRSD_processo_sd
CREATE PROCEDURE [dbo].[sp_ins_tb_PRSD_processo_sd]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PRSD_nm_sd varchar(30) = null , 
@PRSD_dt_sd datetime = null , 
@PRSD_nm_prc varchar(30) = null , 
@PRSD_nm_doc varchar(30) = null , 
@PRSD_dt_ini datetime = null , 
@SISD_nm_situacao_sd varchar(100) = null , 
@OSSD_nm_objeto varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@PRSD_dt_fim datetime = null
 
AS
 
 
  INSERT 
  tb_PRSD_processo_sd
  (PROC_cd_processo, 
ORGA_nm_orgao, 
PRSD_nm_sd, 
PRSD_dt_sd, 
PRSD_nm_prc, 
PRSD_nm_doc, 
PRSD_dt_ini, 
SISD_nm_situacao_sd, 
OSSD_nm_objeto, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao,
PRSD_dt_fim)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@PRSD_nm_sd, 
@PRSD_dt_sd, 
@PRSD_nm_prc, 
@PRSD_nm_doc, 
@PRSD_dt_ini, 
@SISD_nm_situacao_sd, 
@OSSD_nm_objeto, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao,
@PRSD_dt_fim)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRPD_processo_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PRPD_processo_produto
CREATE PROCEDURE [dbo].[sp_ins_tb_PRPD_processo_produto]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null , 
@PROD_nm_produto varchar(100) = null , 
@PRPD_vl_produto decimal(15, 3) = null , 
@PRPD_un_produto varchar(10) = null , 
@UPRD_nm_uso varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PRPD_processo_produto
  (PROC_cd_processo, 
ORGA_nm_orgao, 
MPRI_nm_mprima, 
PROD_nm_produto, 
PRPD_vl_produto, 
PRPD_un_produto, 
UPRD_nm_uso, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@MPRI_nm_mprima, 
@PROD_nm_produto, 
@PRPD_vl_produto, 
@PRPD_un_produto, 
@UPRD_nm_uso, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PROP_processo_operador]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PROP_processo_operador]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_ins_tb_PROP_processo_operador]
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PROP_processo_operador
  (PROC_cd_processo, 
OPER_cd_operador, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@OPER_cd_operador, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PROD_produto]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PROD_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PROD_produto
CREATE PROCEDURE [dbo].[sp_ins_tb_PROD_produto]
@PROD_nm_produto varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PROD_produto
  (PROD_nm_produto, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROD_nm_produto, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PROC_processo]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PROC_processo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_ins_tb_PROC_processo]
@PROC_cd_processo varchar(50) = null , 
@PROC_ds_titular varchar(300) = null , 
@PROC_vl_ano int = null , 
@PROC_nm_processo varchar(50) = null , 
@PROC_id_processo varchar(300) = null , 
@FASE_cd_fase int = null , 
@PROC_ds_ultimo_evento varchar(3000) = null , 
@PROC_ds_substancia varchar(100) = null , 
@PROC_ds_area varchar(30) = null , 
@PROC_ds_uso varchar(200) = null , 
@PROC_ds_link varchar(150) = null , 
@UNFE_cd_unidade_federativa char(2) = null , 
@PROC_fl_tipo_inclusao char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@PROC_cd_prioridade varchar(3) = null
 
AS
 
 
  INSERT 
  tb_PROC_processo
  (PROC_cd_processo, 
PROC_ds_titular, 
PROC_vl_ano, 
PROC_nm_processo, 
PROC_id_processo, 
FASE_cd_fase, 
PROC_ds_ultimo_evento, 
PROC_ds_substancia, 
PROC_ds_area, 
PROC_ds_uso, 
PROC_ds_link, 
UNFE_cd_unidade_federativa, 
PROC_fl_tipo_inclusao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao,
PROC_cd_prioridade)
  VALUES 
  (@PROC_cd_processo, 
@PROC_ds_titular, 
@PROC_vl_ano, 
@PROC_nm_processo, 
@PROC_id_processo, 
@FASE_cd_fase, 
@PROC_ds_ultimo_evento, 
@PROC_ds_substancia, 
@PROC_ds_area, 
@PROC_ds_uso, 
@PROC_ds_link, 
@UNFE_cd_unidade_federativa, 
@PROC_fl_tipo_inclusao, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao,
@PROC_cd_prioridade)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRMP_processo_mprima]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PRMP_processo_mprima
CREATE PROCEDURE [dbo].[sp_ins_tb_PRMP_processo_mprima]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null , 
@PRMP_vl_mprima decimal(15, 3) = null , 
@PRMP_un_mprima varchar(10) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PRMP_processo_mprima
  (PROC_cd_processo, 
ORGA_nm_orgao, 
MPRI_nm_mprima, 
PRMP_vl_mprima, 
PRMP_un_mprima, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@MPRI_nm_mprima, 
@PRMP_vl_mprima, 
@PRMP_un_mprima, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PREV_processo_evento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PREV_processo_evento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_ins_tb_PREV_processo_evento]
@PROC_cd_processo varchar(50) = null , 
@PREV_id_evento int = null,
@PREV_cd_evento varchar(20) = null , 
@PREV_ds_evento varchar(3000) = null , 
@PREV_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PREV_processo_evento
  (PROC_cd_processo, 
  PREV_id_evento,
PREV_cd_evento, 
PREV_ds_evento, 
PREV_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
  @PREV_id_evento,
@PREV_cd_evento, 
@PREV_ds_evento, 
@PREV_dt_ocorrencia, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRAN_processo_andamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PRAN_processo_andamento
CREATE PROCEDURE [dbo].[sp_ins_tb_PRAN_processo_andamento]
@PROC_cd_processo varchar(50) = null , 
@PROC_ds_titular varchar(300) = null , 
@PROC_cd_ultimo_evento varchar(20) = null , 
@PROC_ds_ultimo_evento varchar(1000) = null , 
@PROC_ds_link varchar(150) = null , 
@PROC_cd_evento_andamento varchar(20) = null , 
@PROC_ds_evento_andamento varchar(1000) = null , 
@PROC_dt_vencimento datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PRAN_processo_andamento
  (PROC_cd_processo, 
PROC_ds_titular, 
PROC_cd_ultimo_evento, 
PROC_ds_ultimo_evento, 
PROC_ds_link, 
PROC_cd_evento_andamento, 
PROC_ds_evento_andamento, 
PROC_dt_vencimento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@PROC_ds_titular, 
@PROC_cd_ultimo_evento, 
@PROC_ds_ultimo_evento, 
@PROC_ds_link, 
@PROC_cd_evento_andamento, 
@PROC_ds_evento_andamento, 
@PROC_dt_vencimento, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PRAL_processo_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_ins_tb_PRAL_processo_alerta]
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PRAL_fl_manutencao char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PRAL_processo_alerta
  (PROC_cd_processo, 
ALER_nm_alerta, 
PRAL_fl_manutencao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ALER_nm_alerta, 
@PRAL_fl_manutencao, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PORG_processo_orgao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PORG_processo_orgao
CREATE PROCEDURE [dbo].[sp_ins_tb_PORG_processo_orgao]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PORG_nm_cadastro varchar(30) = null , 
@PORG_ds_atividade varchar(500) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PORG_processo_orgao
  (PROC_cd_processo, 
ORGA_nm_orgao, 
PORG_nm_cadastro, 
PORG_ds_atividade, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@PORG_nm_cadastro, 
@PORG_ds_atividade, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PNOT_processo_nota]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PNOT_processo_nota
CREATE PROCEDURE [dbo].[sp_ins_tb_PNOT_processo_nota]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PNOT_cd_nota int = null , 
@PNOT_ds_nota varchar(1000) = null , 
@PNOT_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PNOT_processo_nota
  (PROC_cd_processo, 
ORGA_nm_orgao, 
PNOT_cd_nota, 
PNOT_ds_nota, 
PNOT_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@PNOT_cd_nota, 
@PNOT_ds_nota, 
@PNOT_dt_ocorrencia, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PMUN_processo_municipio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PMUN_processo_municipio
CREATE PROCEDURE [dbo].[sp_ins_tb_PMUN_processo_municipio]
@PROC_cd_processo varchar(50) = null , 
@MUNI_nm_municipio varchar(150) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PMUN_processo_municipio
  (PROC_cd_processo, 
MUNI_nm_municipio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@MUNI_nm_municipio, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PINF_processo_info]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PINF_processo_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PINF_processo_info
CREATE PROCEDURE [dbo].[sp_ins_tb_PINF_processo_info]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PINF_cd_info int = null , 
@PINF_ds_info varchar(500) = null , 
@TINF_nm_tipo_info varchar(100) = null , 
@SINF_ds_situacao_info varchar(100) = null , 
@PINF_dt_ini datetime = null , 
@PINF_dt_fim datetime = null , 
@PINF_ds_local_documento varchar(500) = null , 
@PINF_ds_rede_documento varchar(500) = null , 
@PINF_ds_path_documento varchar(500) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PINF_processo_info
  (PROC_cd_processo, 
ORGA_nm_orgao, 
PINF_cd_info, 
PINF_ds_info, 
TINF_nm_tipo_info, 
SINF_ds_situacao_info, 
PINF_dt_ini, 
PINF_dt_fim, 
PINF_ds_local_documento, 
PINF_ds_rede_documento, 
PINF_ds_path_documento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@PINF_cd_info, 
@PINF_ds_info, 
@TINF_nm_tipo_info, 
@SINF_ds_situacao_info, 
@PINF_dt_ini, 
@PINF_dt_fim, 
@PINF_ds_local_documento, 
@PINF_ds_rede_documento, 
@PINF_ds_path_documento, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PGER_parametro_geral]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_ins_tb_PGER_parametro_geral]
@PGER_cd_parametro varchar(10) = null , 
@PGER_ds_parametro varchar(100) = null , 
@PGER_vl_parametro varchar(1000) = null , 
@PGER_fl_tipo char(1) = null , 
@PGER_fl_sistema char(1) = null , 
@PGER_vl_range_min bigint = null , 
@PGER_vl_range_max bigint = null , 
@PGER_vl_padrao varchar(1000) = null , 
@PGER_vl_tamanho_min int = null , 
@PGER_vl_tamanho_max int = null , 
@PGER_vl_valores_permitidos varchar(8000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PGER_parametro_geral
  (PGER_cd_parametro, 
PGER_ds_parametro, 
PGER_vl_parametro, 
PGER_fl_tipo, 
PGER_fl_sistema, 
PGER_vl_range_min, 
PGER_vl_range_max, 
PGER_vl_padrao, 
PGER_vl_tamanho_min, 
PGER_vl_tamanho_max, 
PGER_vl_valores_permitidos, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PGER_cd_parametro, 
@PGER_ds_parametro, 
@PGER_vl_parametro, 
@PGER_fl_tipo, 
@PGER_fl_sistema, 
@PGER_vl_range_min, 
@PGER_vl_range_max, 
@PGER_vl_padrao, 
@PGER_vl_tamanho_min, 
@PGER_vl_tamanho_max, 
@PGER_vl_valores_permitidos, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PDOC_processo_documento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PDOC_processo_documento
CREATE PROCEDURE [dbo].[sp_ins_tb_PDOC_processo_documento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PDOC_nm_documento varchar(100) = null , 
@PDOC_ds_documento varchar(1000) = null , 
@PDOC_ds_local_documento varchar(1000) = null , 
@PDOC_ds_rede_documento varchar(1000) = null , 
@PDOC_ds_path_documento varchar(1000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PDOC_processo_documento
  (PROC_cd_processo, 
ORGA_nm_orgao, 
PDOC_nm_documento, 
PDOC_ds_documento, 
PDOC_ds_local_documento, 
PDOC_ds_rede_documento, 
PDOC_ds_path_documento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@PDOC_nm_documento, 
@PDOC_ds_documento, 
@PDOC_ds_local_documento, 
@PDOC_ds_rede_documento, 
@PDOC_ds_path_documento, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PCON_processo_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PCON_processo_condicao
CREATE PROCEDURE [dbo].[sp_ins_tb_PCON_processo_condicao]
@PROC_cd_processo varchar(50) = null , 
@PCON_cd_condicao int = null , 
@COND_nm_condicao varchar(500) = null , 
@SCON_ds_situacao_condicao varchar(100) = null , 
@PCON_ds_condicao varchar(500) = null , 
@PCON_dt_ini datetime = null , 
@PCON_dt_fim datetime = null , 
@PCON_ds_nome_documento varchar(1000) = null , 
@PCON_ds_local_documento varchar(1000) = null , 
@PCON_ds_rede_documento varchar(1000) = null , 
@PCON_ds_path_documento varchar(1000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PCON_processo_condicao
  (PROC_cd_processo, 
PCON_cd_condicao, 
COND_nm_condicao, 
SCON_ds_situacao_condicao, 
PCON_ds_condicao, 
PCON_dt_ini, 
PCON_dt_fim, 
PCON_ds_nome_documento, 
PCON_ds_local_documento, 
PCON_ds_rede_documento, 
PCON_ds_path_documento, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@PCON_cd_condicao, 
@COND_nm_condicao, 
@SCON_ds_situacao_condicao, 
@PCON_ds_condicao, 
@PCON_dt_ini, 
@PCON_dt_fim, 
@PCON_ds_nome_documento, 
@PCON_ds_local_documento, 
@PCON_ds_rede_documento, 
@PCON_ds_path_documento, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PAUX_processo_auxiliar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PAUX_processo_auxiliar
CREATE PROCEDURE [dbo].[sp_ins_tb_PAUX_processo_auxiliar]
@PAUX_cd_processo varchar(50) = null , 
@PAUX_ds_titular varchar(300) = null , 
@FASE_cd_fase int = null , 
@PAUX_ds_ultimo_evento varchar(3000) = null , 
@UNFE_cd_unidade_federativa char(2) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PAUX_processo_auxiliar
  (PAUX_cd_processo, 
PAUX_ds_titular, 
FASE_cd_fase, 
PAUX_ds_ultimo_evento, 
UNFE_cd_unidade_federativa, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PAUX_cd_processo, 
@PAUX_ds_titular, 
@FASE_cd_fase, 
@PAUX_ds_ultimo_evento, 
@UNFE_cd_unidade_federativa, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_PASO_processo_associado]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_PASO_processo_associado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_PASO_processo_associado
CREATE PROCEDURE [dbo].[sp_ins_tb_PASO_processo_associado]
@PROC_cd_processo varchar(50) = null , 
@PASO_cd_processo varchar(50) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_PASO_processo_associado
  (PROC_cd_processo, 
PASO_cd_processo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@PASO_cd_processo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_OSSD_objeto_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_OSSD_objeto_sd
CREATE PROCEDURE [dbo].[sp_ins_tb_OSSD_objeto_sd]
@ORGA_nm_orgao varchar(10) = null , 
@OSSD_nm_objeto varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_OSSD_objeto_sd
  (ORGA_nm_orgao, 
OSSD_nm_objeto, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@ORGA_nm_orgao, 
@OSSD_nm_objeto, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_OPER_operador]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_OPER_operador]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_ins_tb_OPER_operador]
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null , 
@OPER_fl_alerta char(1) = null , 
@OPER_fl_alerta_nativo char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_OPER_operador
  (OPER_cd_operador, 
OPER_nm_operador, 
OPER_ds_email, 
OPER_fl_alerta, 
OPER_fl_alerta_nativo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@OPER_cd_operador, 
@OPER_nm_operador, 
@OPER_ds_email, 
@OPER_fl_alerta, 
@OPER_fl_alerta_nativo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_MUNI_municipio]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_MUNI_municipio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_MUNI_municipio
CREATE PROCEDURE [dbo].[sp_ins_tb_MUNI_municipio]
@MUNI_nm_municipio varchar(150) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_MUNI_municipio
  (MUNI_nm_municipio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@MUNI_nm_municipio, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_MPRI_mprima]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_MPRI_mprima]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_MPRI_mprima
CREATE PROCEDURE [dbo].[sp_ins_tb_MPRI_mprima]
@MPRI_nm_mprima varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_MPRI_mprima
  (MPRI_nm_mprima, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@MPRI_nm_mprima, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_LESI_log_erro_sistema]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_ins_tb_LESI_log_erro_sistema]
@LESI_cd_ocorrencia bigint = null , 
@LESI_nm_source varchar(100) = null , 
@LESI_ds_exception varchar(8000) = null , 
@LESI_ds_inexception varchar(8000) = null , 
@LESI_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_LESI_log_erro_sistema
  ( 
LESI_nm_source, 
LESI_ds_exception, 
LESI_ds_inexception, 
LESI_dt_ocorrencia, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao)
  VALUES 
  ( 
@LESI_nm_source, 
@LESI_ds_exception, 
@LESI_ds_inexception, 
@LESI_dt_ocorrencia, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_HSAL_historico_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_ins_tb_HSAL_historico_alerta]
@HSAL_id_historico int = null , 
@HSAL_ds_email varchar(200) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PROC_cd_processo varchar(50) = null , 
@HSAL_ds_assunto_email varchar(200) = null , 
@HSAL_ds_texto_email varchar(8000) = null , 
@HSAL_dt_envio datetime = null , 
@HSAL_dt_tentativa_ultimo_envio datetime = null , 
@HSAL_ds_mensagem varchar(8000) = null , 
@HSAL_fl_status char(3) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_HSAL_historico_alerta
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
  VALUES 
  (@HSAL_id_historico, 
@HSAL_ds_email, 
@ALER_nm_alerta, 
@PROC_cd_processo, 
@HSAL_ds_assunto_email, 
@HSAL_ds_texto_email, 
@HSAL_dt_envio, 
@HSAL_dt_tentativa_ultimo_envio, 
@HSAL_ds_mensagem, 
@HSAL_fl_status, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_FASE_fase]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_FASE_fase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_ins_tb_FASE_fase]
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_FASE_fase
  (FASE_cd_fase, 
FASE_nm_fase, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@FASE_cd_fase, 
@FASE_nm_fase, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_EMPR_empresa]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_EMPR_empresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_ins_tb_EMPR_empresa]
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null , 
@EMPR_fl_status char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@EMPR_ds_dou varchar(500) = null
 
AS
 
 
  INSERT 
  tb_EMPR_empresa
  (EMPR_nm_empresa, 
EMPR_ds_empresa, 
EMPR_fl_status, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao,
EMPR_ds_dou)
  VALUES 
  (@EMPR_nm_empresa, 
@EMPR_ds_empresa, 
@EMPR_fl_status, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao,
@EMPR_ds_dou)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_COVE_controle_vencimento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_COVE_controle_vencimento
CREATE PROCEDURE [dbo].[sp_ins_tb_COVE_controle_vencimento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@COVE_nm_tipo_documento varchar(10) = null , 
@COVE_id_documento varchar(20) = null , 
@COVE_qt_inicio int = null , 
@COVE_qt_intervalo int = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_COVE_controle_vencimento
  (PROC_cd_processo, 
ORGA_nm_orgao, 
COVE_nm_tipo_documento, 
COVE_id_documento, 
COVE_qt_inicio, 
COVE_qt_intervalo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@COVE_nm_tipo_documento, 
@COVE_id_documento, 
@COVE_qt_inicio, 
@COVE_qt_intervalo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_COND_condicao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_COND_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_COND_condicao
CREATE PROCEDURE [dbo].[sp_ins_tb_COND_condicao]
@COND_nm_condicao varchar(500) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_COND_condicao
  (COND_nm_condicao, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@COND_nm_condicao, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_BACK_backup]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_BACK_backup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_BACK_backup
CREATE PROCEDURE [dbo].[sp_ins_tb_BACK_backup]
@BACK_cd_backup int = null , 
@BACK_vl_intervalo int = null , 
@BACK_nm_arquivo varchar(30) = null , 
@BACK_fl_execucao char(1) = null , 
@BACK_ds_mensagem varchar(500) = null , 
@BACK_dt_execucao datetime = null , 
@BACK_dt_tentativa_Execucao datetime = null , 
@BACK_dt_backup datetime = null , 
@BACK_dt_sincronizacao datetime = null , 
@BACK_fl_tipo char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_BACK_backup
  (BACK_cd_backup, 
BACK_vl_intervalo, 
BACK_nm_arquivo, 
BACK_fl_execucao, 
BACK_ds_mensagem, 
BACK_dt_execucao, 
BACK_dt_tentativa_Execucao, 
BACK_dt_backup, 
BACK_dt_sincronizacao, 
BACK_fl_tipo, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@BACK_cd_backup, 
@BACK_vl_intervalo, 
@BACK_nm_arquivo, 
@BACK_fl_execucao, 
@BACK_ds_mensagem, 
@BACK_dt_execucao, 
@BACK_dt_tentativa_Execucao, 
@BACK_dt_backup, 
@BACK_dt_sincronizacao, 
@BACK_fl_tipo, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_AVEN_alerta_vencimento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_AVEN_alerta_vencimento
CREATE PROCEDURE [dbo].[sp_ins_tb_AVEN_alerta_vencimento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@AVEN_nm_tipo_documento varchar(40) = null , 
@AVEN_id_documento varchar(20) = null , 
@AVEN_fl_conta_alerta int = null , 
@AVEN_dt_ultimo_alerta datetime = null , 
@AVEN_fl_ultimo_envio char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
 
  INSERT 
  tb_AVEN_alerta_vencimento
  (PROC_cd_processo, 
ORGA_nm_orgao, 
AVEN_nm_tipo_documento, 
AVEN_id_documento, 
AVEN_fl_conta_alerta, 
AVEN_dt_ultimo_alerta, 
AVEN_fl_ultimo_envio, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao)
  VALUES 
  (@PROC_cd_processo, 
@ORGA_nm_orgao, 
@AVEN_nm_tipo_documento, 
@AVEN_id_documento, 
@AVEN_fl_conta_alerta, 
@AVEN_dt_ultimo_alerta, 
@AVEN_fl_ultimo_envio, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_ins_tb_ALER_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_ins_tb_ALER_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA INCLUIR REGISTROS NA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_ins_tb_ALER_alerta]
@ALER_nm_alerta varchar(50) = null , 
@ALER_ds_alerta varchar(300) = null , 
@ALER_fl_muda_fase char(1) = null , 
@ALER_fl_muda_evento char(1) = null , 
@ALER_cd_fase_anterior int = null , 
@ALER_cd_fase_nova int = null , 
@ALER_fl_qualquer_processo char(1) = null , 
@ALER_fl_status char(1) = null , 
@ALER_fl_sistema char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@ALER_fl_geral char(1) = null,
@ALER_cd_evento varchar(5) = null,
@ALER_fl_andamento char(1) = null,
@ALER_fl_acao char(1) = null
 
AS
 
 
  INSERT 
  tb_ALER_alerta
  (ALER_nm_alerta, 
ALER_ds_alerta, 
ALER_fl_muda_fase, 
ALER_fl_muda_evento, 
ALER_cd_fase_anterior, 
ALER_cd_fase_nova, 
ALER_fl_qualquer_processo, 
ALER_fl_status, 
ALER_fl_sistema, 
AUDT_dt_inclusao, 
AUDT_nm_usuario_inclusao, 
AUDT_dt_alteracao, 
AUDT_nm_usuario_alteracao,
ALER_fl_geral,
ALER_cd_evento,
ALER_fl_andamento,
ALER_fl_acao)
  VALUES 
  (@ALER_nm_alerta, 
@ALER_ds_alerta, 
@ALER_fl_muda_fase, 
@ALER_fl_muda_evento, 
@ALER_cd_fase_anterior, 
@ALER_cd_fase_nova, 
@ALER_fl_qualquer_processo, 
@ALER_fl_status, 
@ALER_fl_sistema, 
@AUDT_dt_inclusao, 
@AUDT_nm_usuario_inclusao, 
@AUDT_dt_alteracao, 
@AUDT_nm_usuario_alteracao,
@ALER_fl_geral,
@ALER_cd_evento,
@ALER_fl_andamento,
@ALER_fl_acao)
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_UPRD_uso_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_UPRD_uso_produto
CREATE PROCEDURE [dbo].[sp_del_tb_UPRD_uso_produto]
@UPRD_nm_uso varchar(100) = null 
 
AS
 
DELETE FROM 
tb_UPRD_uso_produto
 where (@UPRD_nm_uso is null or (@UPRD_nm_uso is not null and UPRD_nm_uso = @UPRD_nm_uso))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_UNME_unidade_medida]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_UNME_unidade_medida
CREATE PROCEDURE [dbo].[sp_del_tb_UNME_unidade_medida]
@UNME_nm_unidade varchar(10) = null , 
@UNME_nm_tipo char(2) = null 
 
AS
 
DELETE FROM 
tb_UNME_unidade_medida
 where (@UNME_nm_unidade is null or (@UNME_nm_unidade is not null and UNME_nm_unidade = @UNME_nm_unidade))  AND 
(@UNME_nm_tipo is null or (@UNME_nm_tipo is not null and UNME_nm_tipo = @UNME_nm_tipo))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_UNFE_unidade_federativa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_del_tb_UNFE_unidade_federativa]
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null 
 
AS
 
DELETE FROM 
tb_UNFE_unidade_federativa
 where (@UNFE_cd_unidade_federativa is null or (@UNFE_cd_unidade_federativa is not null and UNFE_cd_unidade_federativa = @UNFE_cd_unidade_federativa))  AND 
(@UNFE_nm_unidade_federativa is null or (@UNFE_nm_unidade_federativa is not null and UNFE_nm_unidade_federativa = @UNFE_nm_unidade_federativa))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_TUSO_tipo_uso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_TUSO_tipo_uso
CREATE PROCEDURE [dbo].[sp_del_tb_TUSO_tipo_uso]
@TUSO_nm_uso varchar(100) = null 
 
AS
 
DELETE FROM 
tb_TUSO_tipo_uso
 where (@TUSO_nm_uso is null or (@TUSO_nm_uso is not null and TUSO_nm_uso = @TUSO_nm_uso))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_TTIT_tipo_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_TTIT_tipo_titulo
CREATE PROCEDURE [dbo].[sp_del_tb_TTIT_tipo_titulo]
@ORGA_nm_orgao varchar(10) = null , 
@TTIT_ds_tipo_titulo varchar(100) = null 
 
AS
 
DELETE FROM 
tb_TTIT_tipo_titulo
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@TTIT_ds_tipo_titulo is null or (@TTIT_ds_tipo_titulo is not null and TTIT_ds_tipo_titulo = @TTIT_ds_tipo_titulo))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_TINF_tipo_info]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_TINF_tipo_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_TINF_tipo_info
CREATE PROCEDURE [dbo].[sp_del_tb_TINF_tipo_info]
@ORGA_nm_orgao varchar(10) = null , 
@TINF_nm_tipo_info varchar(100) = null 
 
AS
 
DELETE FROM 
tb_TINF_tipo_info
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@TINF_nm_tipo_info is null or (@TINF_nm_tipo_info is not null and TINF_nm_tipo_info = @TINF_nm_tipo_info))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_TABE_tabela]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_TABE_tabela]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_TABE_tabela
CREATE PROCEDURE [dbo].[sp_del_tb_TABE_tabela]
@TABE_nm_tabela varchar(50) = null , 
@TABE_ds_tabela varchar(200) = null 
 
AS
 
DELETE FROM 
tb_TABE_tabela
 where (@TABE_nm_tabela is null or (@TABE_nm_tabela is not null and TABE_nm_tabela = @TABE_nm_tabela))  AND 
(@TABE_ds_tabela is null or (@TABE_ds_tabela is not null and TABE_ds_tabela = @TABE_ds_tabela))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SUBS_substancia]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SUBS_substancia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_SUBS_substancia
CREATE PROCEDURE [dbo].[sp_del_tb_SUBS_substancia]
@SUBS_nm_substancia varchar(100) = null 
 
AS
 
DELETE FROM 
tb_SUBS_substancia
 where (@SUBS_nm_substancia is null or (@SUBS_nm_substancia is not null and SUBS_nm_substancia = @SUBS_nm_substancia))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SITU_situacao_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_SITU_situacao_titulo
CREATE PROCEDURE [dbo].[sp_del_tb_SITU_situacao_titulo]
@ORGA_nm_orgao varchar(10) = null , 
@SITU_ds_situacao_titulo varchar(100) = null 
 
AS
 
DELETE FROM 
tb_SITU_situacao_titulo
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SITU_ds_situacao_titulo is null or (@SITU_ds_situacao_titulo is not null and SITU_ds_situacao_titulo = @SITU_ds_situacao_titulo))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SISD_situacao_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_SISD_situacao_sd
CREATE PROCEDURE [dbo].[sp_del_tb_SISD_situacao_sd]
@ORGA_nm_orgao varchar(10) = null , 
@SISD_nm_situacao_sd varchar(100) = null 
 
AS
 
DELETE FROM 
tb_SISD_situacao_sd
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SISD_nm_situacao_sd is null or (@SISD_nm_situacao_sd is not null and SISD_nm_situacao_sd = @SISD_nm_situacao_sd))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SINF_situacao_info]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SINF_situacao_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_SINF_situacao_info
CREATE PROCEDURE [dbo].[sp_del_tb_SINF_situacao_info]
@ORGA_nm_orgao varchar(10) = null , 
@SINF_ds_situacao_info varchar(100) = null 
 
AS
 
DELETE FROM 
tb_SINF_situacao_info
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SINF_ds_situacao_info is null or (@SINF_ds_situacao_info is not null and SINF_ds_situacao_info = @SINF_ds_situacao_info))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_SCON_situacao_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_SCON_situacao_condicao
CREATE PROCEDURE [dbo].[sp_del_tb_SCON_situacao_condicao]
@ORGA_nm_orgao varchar(10) = null , 
@SCON_ds_situacao_condicao varchar(100) = null 
 
AS
 
DELETE FROM 
tb_SCON_situacao_condicao
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SCON_ds_situacao_condicao is null or (@SCON_ds_situacao_condicao is not null and SCON_ds_situacao_condicao = @SCON_ds_situacao_condicao))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_ROTI_rotina]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_ROTI_rotina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_del_tb_ROTI_rotina]
@ROTI_nm_rotina varchar(30) = null 
 
AS
 
DELETE FROM 
tb_ROTI_rotina
 where (@ROTI_nm_rotina is null or (@ROTI_nm_rotina is not null and ROTI_nm_rotina = @ROTI_nm_rotina))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PTIT_processo_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PTIT_processo_titulo
CREATE PROCEDURE [dbo].[sp_del_tb_PTIT_processo_titulo]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PTIT_nm_titulo varchar(50) = null 
 
AS
 
DELETE FROM 
tb_PTIT_processo_titulo
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PTIT_nm_titulo is null or (@PTIT_nm_titulo is not null and PTIT_nm_titulo = @PTIT_nm_titulo))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PSUB_processo_substancia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PSUB_processo_substancia
CREATE PROCEDURE [dbo].[sp_del_tb_PSUB_processo_substancia]
@PROC_cd_processo varchar(50) = null , 
@SUBS_nm_substancia varchar(100) = null ,
@TUSO_nm_uso varchar(100) = null
 
AS
 
DELETE FROM 
tb_PSUB_processo_substancia
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@SUBS_nm_substancia is null or (@SUBS_nm_substancia is not null and SUBS_nm_substancia = @SUBS_nm_substancia))   AND
(@TUSO_nm_uso is null or (@TUSO_nm_uso is not null and TUSO_nm_uso = @TUSO_nm_uso))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRSD_processo_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PRSD_processo_sd
CREATE PROCEDURE [dbo].[sp_del_tb_PRSD_processo_sd]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PRSD_nm_sd varchar(30) = null 
 
AS
 
DELETE FROM 
tb_PRSD_processo_sd
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PRSD_nm_sd is null or (@PRSD_nm_sd is not null and PRSD_nm_sd = @PRSD_nm_sd))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRPD_processo_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PRPD_processo_produto
CREATE PROCEDURE [dbo].[sp_del_tb_PRPD_processo_produto]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null , 
@PROD_nm_produto varchar(100) = null 
 
AS
 
DELETE FROM 
tb_PRPD_processo_produto
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))  AND 
(@PROD_nm_produto is null or (@PROD_nm_produto is not null and PROD_nm_produto = @PROD_nm_produto))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PROP_processo_operador]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PROP_processo_operador]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_del_tb_PROP_processo_operador]
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null 
 
AS
 
DELETE FROM 
tb_PROP_processo_operador
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PROD_produto]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PROD_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PROD_produto
CREATE PROCEDURE [dbo].[sp_del_tb_PROD_produto]
@PROD_nm_produto varchar(100) = null 
 
AS
 
DELETE FROM 
tb_PROD_produto
 where (@PROD_nm_produto is null or (@PROD_nm_produto is not null and PROD_nm_produto = @PROD_nm_produto))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PROC_processo]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PROC_processo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_del_tb_PROC_processo]
@PROC_cd_processo varchar(50) = null 
 
AS
 
 begin tran
 
 
 if @PROC_cd_processo is null or len(ltrim(rtrim(@PROC_cd_processo))) = 0 
 begin
  raiserror(''Número do Processo é obrigatório'',16,-1)
  rollback transaction
  return
 end
 
 
 -- exclui alertas relacionados ao processo
 
 
 DELETE FROM 
tb_PRAL_processo_alerta  
where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
 	if @@error <> 0 
	begin
		rollback transaction
		return
	end 
	
	
	
	
	-- exclui operadores relacionados ao processo
	
	DELETE FROM 
tb_PROP_processo_operador   
where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
	if @@error <> 0 
	begin
		rollback transaction
		return
	end
	
	
	
	-- exclui eventos relacionados ao processo
	DELETE FROM 
tb_PREV_processo_evento   
where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
	if @@error <> 0 
	begin
		rollback transaction
		return
	end
	
	
	-- exclui outros dados
DELETE FROM tb_PASO_processo_associado  where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PCON_processo_condicao   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PDOC_processo_documento   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PMUN_processo_municipio   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PNOT_processo_nota   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PSUB_processo_substancia   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PTIT_processo_titulo   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   

DELETE FROM tb_PRPD_processo_produto   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PRMP_processo_mprima   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PRSD_processo_sd   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PORG_processo_orgao   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
DELETE FROM tb_PINF_processo_info   where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   


if @@error <> 0 
begin
rollback transaction
return
end
	
	
	
	
DELETE FROM 
tb_PROC_processo
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   
 
 	if @@error <> 0 
	begin
		rollback transaction
		return
	end 
	


commit tran


return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRMP_processo_mprima]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PRMP_processo_mprima
CREATE PROCEDURE [dbo].[sp_del_tb_PRMP_processo_mprima]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null 
 
AS



begin tran
 
 
 if @PROC_cd_processo is null or len(ltrim(rtrim(@PROC_cd_processo))) = 0 
 begin
  raiserror(''Número do Processo é obrigatório'',16,-1)
  rollback transaction
  return
   end
  
   if @MPRI_nm_mprima is null or len(ltrim(rtrim(@MPRI_nm_mprima))) = 0 
 begin
  raiserror(''Matéria-Prima é obrigatória'',16,-1)
  rollback transaction
  return
  end 
  
-- exclui produtos

DELETE FROM 
tb_PRPD_processo_produto
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))   
if @@error <> 0 
	begin
		rollback transaction
		return
	end 

 
DELETE FROM 
tb_PRMP_processo_mprima
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))   
 	if @@error <> 0 
	begin
		rollback transaction
		return
	end 

commit tran


return' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PREV_processo_evento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PREV_processo_evento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_del_tb_PREV_processo_evento]
@PROC_cd_processo varchar(50) = null , 
@PREV_id_evento int = null 
 
AS
 
DELETE FROM 
tb_PREV_processo_evento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PREV_id_evento is null or (@PREV_id_evento is not null and PREV_id_evento = @PREV_id_evento))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRAN_processo_andamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PRAN_processo_andamento
CREATE PROCEDURE [dbo].[sp_del_tb_PRAN_processo_andamento]
@PROC_cd_processo varchar(50) = null 
 
AS
 
DELETE FROM 
tb_PRAN_processo_andamento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PRAL_processo_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_del_tb_PRAL_processo_alerta]
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null 
 
AS
 
DELETE FROM 
tb_PRAL_processo_alerta
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PORG_processo_orgao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PORG_processo_orgao
CREATE PROCEDURE [dbo].[sp_del_tb_PORG_processo_orgao]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null 
 
AS
 
DELETE FROM 
tb_PORG_processo_orgao
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PNOT_processo_nota]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PNOT_processo_nota
CREATE PROCEDURE [dbo].[sp_del_tb_PNOT_processo_nota]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PNOT_cd_nota int = null 
 
AS
 
DELETE FROM 
tb_PNOT_processo_nota
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PNOT_cd_nota is null or (@PNOT_cd_nota is not null and PNOT_cd_nota = @PNOT_cd_nota))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PMUN_processo_municipio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PMUN_processo_municipio
CREATE PROCEDURE [dbo].[sp_del_tb_PMUN_processo_municipio]
@PROC_cd_processo varchar(50) = null , 
@MUNI_nm_municipio varchar(150) = null 
 
AS
 
DELETE FROM 
tb_PMUN_processo_municipio
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@MUNI_nm_municipio is null or (@MUNI_nm_municipio is not null and MUNI_nm_municipio = @MUNI_nm_municipio))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PINF_processo_info]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PINF_processo_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PINF_processo_info
CREATE PROCEDURE [dbo].[sp_del_tb_PINF_processo_info]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PINF_cd_info int = null 
 
AS
 
DELETE FROM 
tb_PINF_processo_info
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PINF_cd_info is null or (@PINF_cd_info is not null and PINF_cd_info = @PINF_cd_info))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PGER_parametro_geral]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_del_tb_PGER_parametro_geral]
@PGER_cd_parametro varchar(10) = null 
 
AS
 
DELETE FROM 
tb_PGER_parametro_geral
 where (@PGER_cd_parametro is null or (@PGER_cd_parametro is not null and PGER_cd_parametro = @PGER_cd_parametro))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PDOC_processo_documento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PDOC_processo_documento
CREATE PROCEDURE [dbo].[sp_del_tb_PDOC_processo_documento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PDOC_nm_documento varchar(100) = null , 
@PDOC_ds_path_documento varchar(500) = null 
 
AS
 
DELETE FROM 
tb_PDOC_processo_documento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PDOC_nm_documento is null or (@PDOC_nm_documento is not null and PDOC_nm_documento = @PDOC_nm_documento))  AND 
(@PDOC_ds_path_documento is null or (@PDOC_ds_path_documento is not null and PDOC_ds_path_documento = @PDOC_ds_path_documento))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PCON_processo_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PCON_processo_condicao
CREATE PROCEDURE [dbo].[sp_del_tb_PCON_processo_condicao]
@PROC_cd_processo varchar(50) = null , 
@PCON_cd_condicao int = null , 
@COND_nm_condicao varchar(500) = null 
 
AS
 
DELETE FROM 
tb_PCON_processo_condicao
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PCON_cd_condicao is null or (@PCON_cd_condicao is not null and PCON_cd_condicao = @PCON_cd_condicao))  AND 
(@COND_nm_condicao is null or (@COND_nm_condicao is not null and COND_nm_condicao = @COND_nm_condicao))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PAUX_processo_auxiliar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PAUX_processo_auxiliar
CREATE PROCEDURE [dbo].[sp_del_tb_PAUX_processo_auxiliar]
@PAUX_cd_processo varchar(50) = null 
 
AS
 
DELETE FROM 
tb_PAUX_processo_auxiliar
 where (@PAUX_cd_processo is null or (@PAUX_cd_processo is not null and PAUX_cd_processo = @PAUX_cd_processo))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_PASO_processo_associado]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_PASO_processo_associado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_PASO_processo_associado
CREATE PROCEDURE [dbo].[sp_del_tb_PASO_processo_associado]
@PROC_cd_processo varchar(50) = null , 
@PASO_cd_processo varchar(50) = null 
 
AS
 
DELETE FROM 
tb_PASO_processo_associado
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PASO_cd_processo is null or (@PASO_cd_processo is not null and PASO_cd_processo = @PASO_cd_processo))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_OSSD_objeto_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_OSSD_objeto_sd
CREATE PROCEDURE [dbo].[sp_del_tb_OSSD_objeto_sd]
@ORGA_nm_orgao varchar(10) = null , 
@OSSD_nm_objeto varchar(100) = null 
 
AS
 
DELETE FROM 
tb_OSSD_objeto_sd
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@OSSD_nm_objeto is null or (@OSSD_nm_objeto is not null and OSSD_nm_objeto = @OSSD_nm_objeto))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_OPER_operador]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_OPER_operador]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_del_tb_OPER_operador]
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null 
 
AS
 
 begin tran
 
  if @OPER_cd_operador is null or len(ltrim(rtrim(@OPER_cd_operador))) = 0 
 begin
  raiserror(''Código do Operador é obrigatório'',16,-1)
  rollback transaction
  return
 end
 
 
 --exclui operador nos processo que estiver relacionado
DELETE FROM 
tb_PROP_processo_operador 
 where (@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  
 if @@error <> 0 
	begin
		rollback transaction
		return
	end
 
DELETE FROM 
tb_OPER_operador
 where (@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  AND 
(@OPER_nm_operador is null or (@OPER_nm_operador is not null and OPER_nm_operador = @OPER_nm_operador))  AND 
(@OPER_ds_email is null or (@OPER_ds_email is not null and OPER_ds_email = @OPER_ds_email))   
if @@error <> 0 
	begin
		rollback transaction
		return
	end
	
	commit tran
	
	return
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_MUNI_municipio]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_MUNI_municipio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_MUNI_municipio
CREATE PROCEDURE [dbo].[sp_del_tb_MUNI_municipio]
@MUNI_nm_municipio varchar(150) = null 
 
AS
 
DELETE FROM 
tb_MUNI_municipio
 where (@MUNI_nm_municipio is null or (@MUNI_nm_municipio is not null and MUNI_nm_municipio = @MUNI_nm_municipio))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_MPRI_mprima]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_MPRI_mprima]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_MPRI_mprima
CREATE PROCEDURE [dbo].[sp_del_tb_MPRI_mprima]
@MPRI_nm_mprima varchar(100) = null 
 
AS
 
DELETE FROM 
tb_MPRI_mprima
 where (@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_LESI_log_erro_sistema]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_del_tb_LESI_log_erro_sistema]
@LESI_cd_ocorrencia bigint = null 
 
AS
 
DELETE FROM 
tb_LESI_log_erro_sistema
 where (@LESI_cd_ocorrencia is null or (@LESI_cd_ocorrencia is not null and LESI_cd_ocorrencia = @LESI_cd_ocorrencia))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_HSAL_historico_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_del_tb_HSAL_historico_alerta]
@HSAL_id_historico int = null 
 
AS
 
DELETE FROM 
tb_HSAL_historico_alerta
 where (@HSAL_id_historico is null or (@HSAL_id_historico is not null and HSAL_id_historico = @HSAL_id_historico))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_FASE_fase]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_FASE_fase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_del_tb_FASE_fase]
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null 
 
AS
 
DELETE FROM 
tb_FASE_fase
 where (@FASE_cd_fase is null or (@FASE_cd_fase is not null and FASE_cd_fase = @FASE_cd_fase))  AND 
(@FASE_nm_fase is null or (@FASE_nm_fase is not null and FASE_nm_fase = @FASE_nm_fase))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_EMPR_empresa]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_EMPR_empresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_del_tb_EMPR_empresa]
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null 
 
AS
 
DELETE FROM 
tb_EMPR_empresa
 where (@EMPR_nm_empresa is null or (@EMPR_nm_empresa is not null and ltrim(rtrim(EMPR_nm_empresa)) = @EMPR_nm_empresa))  AND 
(@EMPR_ds_empresa is null or (@EMPR_ds_empresa is not null and EMPR_ds_empresa = @EMPR_ds_empresa))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_COVE_controle_vencimento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_COVE_controle_vencimento
CREATE PROCEDURE [dbo].[sp_del_tb_COVE_controle_vencimento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@COVE_nm_tipo_documento varchar(10) = null , 
@COVE_id_documento varchar(20) = null 
 
AS
 
DELETE FROM 
tb_COVE_controle_vencimento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@COVE_nm_tipo_documento is null or (@COVE_nm_tipo_documento is not null and COVE_nm_tipo_documento = @COVE_nm_tipo_documento))  AND 
(@COVE_id_documento is null or (@COVE_id_documento is not null and COVE_id_documento = @COVE_id_documento))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_COND_condicao]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_COND_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_COND_condicao
CREATE PROCEDURE [dbo].[sp_del_tb_COND_condicao]
@COND_nm_condicao varchar(500) = null 
 
AS
 
DELETE FROM 
tb_COND_condicao
 where (@COND_nm_condicao is null or (@COND_nm_condicao is not null and COND_nm_condicao = @COND_nm_condicao))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_BACK_backup]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_BACK_backup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_BACK_backup
CREATE PROCEDURE [dbo].[sp_del_tb_BACK_backup]
@BACK_cd_backup int = null 
 
AS
 
DELETE FROM 
tb_BACK_backup
 where (@BACK_cd_backup is null or (@BACK_cd_backup is not null and BACK_cd_backup = @BACK_cd_backup))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_AVEN_alerta_vencimento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_AVEN_alerta_vencimento
CREATE PROCEDURE [dbo].[sp_del_tb_AVEN_alerta_vencimento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@AVEN_nm_tipo_documento varchar(40) = null , 
@AVEN_id_documento varchar(20) = null 
 
AS
 
DELETE FROM 
tb_AVEN_alerta_vencimento
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@AVEN_nm_tipo_documento is null or (@AVEN_nm_tipo_documento is not null and AVEN_nm_tipo_documento = @AVEN_nm_tipo_documento))  AND 
(@AVEN_id_documento is null or (@AVEN_id_documento is not null and AVEN_id_documento = @AVEN_id_documento))   

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_del_tb_ALER_alerta]    Script Date: 03/25/2018 20:38:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_del_tb_ALER_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
 
-- STORED PROCEDURE PARA EXCLUIR REGISTROS DA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_del_tb_ALER_alerta]
@ALER_nm_alerta varchar(50) = null 
 
AS
 
 begin tran
 
 if @ALER_nm_alerta is null or len(ltrim(rtrim(@ALER_nm_alerta))) = 0 
 begin
  raiserror(''Identificador do Alerta é obrigatório'',16,-1)
  rollback transaction
  return
 end
 
 
 
  --exclui alerta nos processo que estiver relacionado
DELETE FROM 
tb_PRAL_processo_alerta  
 where (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))  
 if @@error <> 0 
	begin
		rollback transaction
		return
	end
 
 
DELETE FROM 
tb_ALER_alerta
 where (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))   
  if @@error <> 0 
	begin
		rollback transaction
		return
	end
	
	
 
 commit tran
 
 return

' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_UPRD_uso_produto]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_UPRD_uso_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_UPRD_uso_produto
CREATE PROCEDURE [dbo].[sp_upd_tb_UPRD_uso_produto]
@UPRD_nm_uso varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_UPRD_uso_produto 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@UPRD_nm_uso is null or (@UPRD_nm_uso is not null and UPRD_nm_uso = @UPRD_nm_uso))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_UNME_unidade_medida]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_UNME_unidade_medida]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_UNME_unidade_medida
CREATE PROCEDURE [dbo].[sp_upd_tb_UNME_unidade_medida]
@UNME_nm_unidade varchar(10) = null , 
@UNME_ds_unidade varchar(100) = null , 
@UNME_nm_tipo char(2) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_UNME_unidade_medida 
SET 
UNME_ds_unidade = case when @UNME_ds_unidade is not null then @UNME_ds_unidade else UNME_ds_unidade end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@UNME_nm_unidade is null or (@UNME_nm_unidade is not null and UNME_nm_unidade = @UNME_nm_unidade))  AND 
(@UNME_nm_tipo is null or (@UNME_nm_tipo is not null and UNME_nm_tipo = @UNME_nm_tipo))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_UNFE_unidade_federativa]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_UNFE_unidade_federativa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_UNFE_unidade_federativa
CREATE PROCEDURE [dbo].[sp_upd_tb_UNFE_unidade_federativa]
@UNFE_cd_unidade_federativa char(2) = null , 
@UNFE_nm_unidade_federativa varchar(100) = null , 
@UNFE_fl_status char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_UNFE_unidade_federativa 
SET 
UNFE_nm_unidade_federativa = case when @UNFE_nm_unidade_federativa is not null then @UNFE_nm_unidade_federativa else UNFE_nm_unidade_federativa end , 
UNFE_fl_status = case when @UNFE_fl_status is not null then @UNFE_fl_status else UNFE_fl_status end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@UNFE_cd_unidade_federativa is null or (@UNFE_cd_unidade_federativa is not null and UNFE_cd_unidade_federativa = @UNFE_cd_unidade_federativa))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_TUSO_tipo_uso]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_TUSO_tipo_uso]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_TUSO_tipo_uso
CREATE PROCEDURE [dbo].[sp_upd_tb_TUSO_tipo_uso]
@TUSO_nm_uso varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_TUSO_tipo_uso 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@TUSO_nm_uso is null or (@TUSO_nm_uso is not null and TUSO_nm_uso = @TUSO_nm_uso))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_TTIT_tipo_titulo]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_TTIT_tipo_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_TTIT_tipo_titulo
CREATE PROCEDURE [dbo].[sp_upd_tb_TTIT_tipo_titulo]
@ORGA_nm_orgao varchar(10) = null , 
@TTIT_ds_tipo_titulo varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_TTIT_tipo_titulo 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@TTIT_ds_tipo_titulo is null or (@TTIT_ds_tipo_titulo is not null and TTIT_ds_tipo_titulo = @TTIT_ds_tipo_titulo))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_TINF_tipo_info]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_TINF_tipo_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_TINF_tipo_info
CREATE PROCEDURE [dbo].[sp_upd_tb_TINF_tipo_info]
@ORGA_nm_orgao varchar(10) = null , 
@TINF_nm_tipo_info varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_TINF_tipo_info 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@TINF_nm_tipo_info is null or (@TINF_nm_tipo_info is not null and TINF_nm_tipo_info = @TINF_nm_tipo_info))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_TABE_tabela]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_TABE_tabela]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_TABE_tabela
CREATE PROCEDURE [dbo].[sp_upd_tb_TABE_tabela]
@TABE_nm_tabela varchar(50) = null , 
@TABE_ds_tabela varchar(200) = null , 
@TABE_ds_selectall varchar(1000) = null , 
@TABE_ds_selectcheck varchar(1000) = null , 
@TABE_ds_deleleone varchar(1000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_TABE_tabela 
SET 
TABE_ds_selectall = case when @TABE_ds_selectall is not null then @TABE_ds_selectall else TABE_ds_selectall end , 
TABE_ds_selectcheck = case when @TABE_ds_selectcheck is not null then @TABE_ds_selectcheck else TABE_ds_selectcheck end , 
TABE_ds_deleleone = case when @TABE_ds_deleleone is not null then @TABE_ds_deleleone else TABE_ds_deleleone end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@TABE_nm_tabela is null or (@TABE_nm_tabela is not null and TABE_nm_tabela = @TABE_nm_tabela))  AND 
(@TABE_ds_tabela is null or (@TABE_ds_tabela is not null and TABE_ds_tabela = @TABE_ds_tabela))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SUBS_substancia]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SUBS_substancia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_SUBS_substancia
CREATE PROCEDURE [dbo].[sp_upd_tb_SUBS_substancia]
@SUBS_nm_substancia varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_SUBS_substancia 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@SUBS_nm_substancia is null or (@SUBS_nm_substancia is not null and SUBS_nm_substancia = @SUBS_nm_substancia))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SITU_situacao_titulo]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SITU_situacao_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_SITU_situacao_titulo
CREATE PROCEDURE [dbo].[sp_upd_tb_SITU_situacao_titulo]
@ORGA_nm_orgao varchar(10) = null , 
@SITU_ds_situacao_titulo varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_SITU_situacao_titulo 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SITU_ds_situacao_titulo is null or (@SITU_ds_situacao_titulo is not null and SITU_ds_situacao_titulo = @SITU_ds_situacao_titulo))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SISD_situacao_sd]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SISD_situacao_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_SISD_situacao_sd
CREATE PROCEDURE [dbo].[sp_upd_tb_SISD_situacao_sd]
@ORGA_nm_orgao varchar(10) = null , 
@SISD_nm_situacao_sd varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_SISD_situacao_sd 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SISD_nm_situacao_sd is null or (@SISD_nm_situacao_sd is not null and SISD_nm_situacao_sd = @SISD_nm_situacao_sd))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SINF_situacao_info]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SINF_situacao_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_SINF_situacao_info
CREATE PROCEDURE [dbo].[sp_upd_tb_SINF_situacao_info]
@ORGA_nm_orgao varchar(10) = null , 
@SINF_ds_situacao_info varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_SINF_situacao_info 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SINF_ds_situacao_info is null or (@SINF_ds_situacao_info is not null and SINF_ds_situacao_info = @SINF_ds_situacao_info))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_SCON_situacao_condicao]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_SCON_situacao_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_SCON_situacao_condicao
CREATE PROCEDURE [dbo].[sp_upd_tb_SCON_situacao_condicao]
@ORGA_nm_orgao varchar(10) = null , 
@SCON_ds_situacao_condicao varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_SCON_situacao_condicao 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@SCON_ds_situacao_condicao is null or (@SCON_ds_situacao_condicao is not null and SCON_ds_situacao_condicao = @SCON_ds_situacao_condicao))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_ROTI_rotina]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_ROTI_rotina]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_ROTI_rotina
CREATE PROCEDURE [dbo].[sp_upd_tb_ROTI_rotina]
@ROTI_nm_rotina varchar(30) = null , 
@ROTI_ds_rotina varchar(300) = null , 
@ROTI_dt_ultima_execucao datetime = null , 
@ROTI_dt_ultima_tentativa_execucao datetime = null , 
@ROTI_fl_status_execucao char(1) = null , 
@ROTI_ds_mensagem varchar(1000) = null , 
@ROTI_vl_tempo_medio decimal(13, 2) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@ROTI_dt_inicio_execucao datetime = null 
 
AS
 
UPDATE 
tb_ROTI_rotina 
SET 
ROTI_ds_rotina = case when @ROTI_ds_rotina is not null then @ROTI_ds_rotina else ROTI_ds_rotina end , 
ROTI_dt_ultima_execucao = case when @ROTI_dt_ultima_execucao is not null then (case when @ROTI_dt_ultima_execucao <> ''00:00:01'' then @ROTI_dt_ultima_execucao else null end) else ROTI_dt_ultima_execucao end , 
ROTI_dt_inicio_execucao = case when @ROTI_dt_inicio_execucao is not null then (case when @ROTI_dt_inicio_execucao <> ''00:00:01'' then @ROTI_dt_inicio_execucao else null end) else ROTI_dt_inicio_execucao end , 

ROTI_dt_ultima_tentativa_execucao = case when @ROTI_dt_ultima_tentativa_execucao is not null then (case when @ROTI_dt_ultima_tentativa_execucao <> ''00:00:01'' then @ROTI_dt_ultima_tentativa_execucao else null end) else ROTI_dt_ultima_tentativa_execucao end , 
ROTI_fl_status_execucao = case when @ROTI_fl_status_execucao is not null then @ROTI_fl_status_execucao else ROTI_fl_status_execucao end , 
ROTI_ds_mensagem = case when @ROTI_ds_mensagem is not null then @ROTI_ds_mensagem else ROTI_ds_mensagem end , 
ROTI_vl_tempo_medio = case when @ROTI_vl_tempo_medio is not null then @ROTI_vl_tempo_medio else ROTI_vl_tempo_medio end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ROTI_nm_rotina is null or (@ROTI_nm_rotina is not null and ROTI_nm_rotina = @ROTI_nm_rotina))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PTIT_processo_titulo]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PTIT_processo_titulo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PTIT_processo_titulo
CREATE PROCEDURE [dbo].[sp_upd_tb_PTIT_processo_titulo]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PTIT_nm_titulo varchar(50) = null , 
@PTIT_ds_titulo varchar(300) = null , 
@TTIT_ds_tipo_titulo varchar(100) = null , 
@SITU_ds_situacao_titulo varchar(100) = null , 
@PTIT_dt_publicacao datetime = null , 
@PTIT_dt_vencimento datetime = null , 
@PTIT_ds_nome_documento varchar(1000) = null , 
@PTIT_ds_local_documento varchar(1000) = null , 
@PTIT_ds_rede_documento varchar(1000) = null , 
@PTIT_ds_path_documento varchar(1000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PTIT_processo_titulo 
SET 
PTIT_ds_titulo = case when @PTIT_ds_titulo is not null then @PTIT_ds_titulo else PTIT_ds_titulo end , 
TTIT_ds_tipo_titulo = case when @TTIT_ds_tipo_titulo is not null then @TTIT_ds_tipo_titulo else TTIT_ds_tipo_titulo end , 
SITU_ds_situacao_titulo = case when @SITU_ds_situacao_titulo is not null then @SITU_ds_situacao_titulo else SITU_ds_situacao_titulo end , 
PTIT_dt_publicacao = case when @PTIT_dt_publicacao is not null then (case when @PTIT_dt_publicacao <> ''00:00:01'' then @PTIT_dt_publicacao else null end) else PTIT_dt_publicacao end , 
PTIT_dt_vencimento = case when @PTIT_dt_vencimento is not null then (case when @PTIT_dt_vencimento <> ''00:00:01'' then @PTIT_dt_vencimento else null end) else PTIT_dt_vencimento end , 
PTIT_ds_nome_documento = case when @PTIT_ds_nome_documento is not null then @PTIT_ds_nome_documento else PTIT_ds_nome_documento end , 
PTIT_ds_local_documento = case when @PTIT_ds_local_documento is not null then @PTIT_ds_local_documento else PTIT_ds_local_documento end , 
PTIT_ds_rede_documento = case when @PTIT_ds_rede_documento is not null then @PTIT_ds_rede_documento else PTIT_ds_rede_documento end , 
PTIT_ds_path_documento = case when @PTIT_ds_path_documento is not null then @PTIT_ds_path_documento else PTIT_ds_path_documento end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PTIT_nm_titulo is null or (@PTIT_nm_titulo is not null and PTIT_nm_titulo = @PTIT_nm_titulo))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PSUB_processo_substancia]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PSUB_processo_substancia]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PSUB_processo_substancia
CREATE PROCEDURE [dbo].[sp_upd_tb_PSUB_processo_substancia]
@PROC_cd_processo varchar(50) = null , 
@SUBS_nm_substancia varchar(100) = null , 
@TUSO_nm_uso varchar(100) = null , 
@PSUB_dt_inicio date = null , 
@PSUB_dt_fim date = null , 
@PSUB_ds_motivo varchar(500) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PSUB_processo_substancia 
SET 
PSUB_dt_inicio = case when @PSUB_dt_inicio is not null then (case when @PSUB_dt_inicio <> ''00:00:01'' then @PSUB_dt_inicio else null end) else PSUB_dt_inicio end , 
PSUB_dt_fim = case when @PSUB_dt_fim is not null then (case when @PSUB_dt_fim <> ''00:00:01'' then @PSUB_dt_fim else null end) else PSUB_dt_fim end , 
PSUB_ds_motivo = case when @PSUB_ds_motivo is not null then @PSUB_ds_motivo else PSUB_ds_motivo end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@SUBS_nm_substancia is null or (@SUBS_nm_substancia is not null and SUBS_nm_substancia = @SUBS_nm_substancia))   AND
(@TUSO_nm_uso is null or (@TUSO_nm_uso is not null and TUSO_nm_uso = @TUSO_nm_uso))   
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRSD_processo_sd]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRSD_processo_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PRSD_processo_sd
CREATE PROCEDURE [dbo].[sp_upd_tb_PRSD_processo_sd]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PRSD_nm_sd varchar(30) = null , 
@PRSD_dt_sd datetime = null , 
@PRSD_nm_prc varchar(30) = null , 
@PRSD_nm_doc varchar(30) = null , 
@PRSD_dt_ini datetime = null , 
@SISD_nm_situacao_sd varchar(100) = null , 
@OSSD_nm_objeto varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@PRSD_dt_fim datetime = null
 
AS
 
UPDATE 
tb_PRSD_processo_sd 
SET 
PRSD_dt_sd = case when @PRSD_dt_sd is not null then (case when @PRSD_dt_sd <> ''00:00:01'' then @PRSD_dt_sd else null end) else PRSD_dt_sd end , 
PRSD_nm_prc = case when @PRSD_nm_prc is not null then @PRSD_nm_prc else PRSD_nm_prc end , 
PRSD_nm_doc = case when @PRSD_nm_doc is not null then @PRSD_nm_doc else PRSD_nm_doc end , 
PRSD_dt_ini = case when @PRSD_dt_ini is not null then (case when @PRSD_dt_ini <> ''00:00:01'' then @PRSD_dt_ini else null end) else PRSD_dt_ini end , 
SISD_nm_situacao_sd = case when @SISD_nm_situacao_sd is not null then @SISD_nm_situacao_sd else SISD_nm_situacao_sd end , 
OSSD_nm_objeto = case when @OSSD_nm_objeto is not null then @OSSD_nm_objeto else OSSD_nm_objeto end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  ,
PRSD_dt_fim = case when @PRSD_dt_fim is not null then (case when @PRSD_dt_fim <> ''00:00:01'' then @PRSD_dt_fim else null end) else PRSD_dt_fim end 
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PRSD_nm_sd is null or (@PRSD_nm_sd is not null and PRSD_nm_sd = @PRSD_nm_sd))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRPD_processo_produto]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRPD_processo_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PRPD_processo_produto
CREATE PROCEDURE [dbo].[sp_upd_tb_PRPD_processo_produto]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null , 
@PROD_nm_produto varchar(100) = null , 
@PRPD_vl_produto decimal(15, 3) = null , 
@PRPD_un_produto varchar(10) = null , 
@UPRD_nm_uso varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PRPD_processo_produto 
SET 
PRPD_vl_produto = case when @PRPD_vl_produto is not null then @PRPD_vl_produto else PRPD_vl_produto end , 
PRPD_un_produto = case when @PRPD_un_produto is not null then @PRPD_un_produto else PRPD_un_produto end , 
UPRD_nm_uso = case when @UPRD_nm_uso is not null then @UPRD_nm_uso else UPRD_nm_uso end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))  AND 
(@PROD_nm_produto is null or (@PROD_nm_produto is not null and PROD_nm_produto = @PROD_nm_produto))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PROP_processo_operador]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PROP_processo_operador]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PROP_processo_operador
CREATE PROCEDURE [dbo].[sp_upd_tb_PROP_processo_operador]
@PROC_cd_processo varchar(50) = null , 
@OPER_cd_operador varchar(20) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PROP_processo_operador 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PROD_produto]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PROD_produto]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PROD_produto
CREATE PROCEDURE [dbo].[sp_upd_tb_PROD_produto]
@PROD_nm_produto varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PROD_produto 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROD_nm_produto is null or (@PROD_nm_produto is not null and PROD_nm_produto = @PROD_nm_produto))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PROC_processo]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PROC_processo]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PROC_processo
CREATE PROCEDURE [dbo].[sp_upd_tb_PROC_processo]
@PROC_cd_processo varchar(50) = null , 
@PROC_ds_titular varchar(300) = null , 
@PROC_vl_ano int = null , 
@PROC_nm_processo varchar(50) = null , 
@PROC_id_processo varchar(300) = null , 
@FASE_cd_fase int = null , 
@PROC_ds_ultimo_evento varchar(3000) = null , 
@PROC_ds_substancia varchar(100) = null , 
@PROC_ds_area varchar(30) = null , 
@PROC_ds_uso varchar(200) = null , 
@PROC_ds_link varchar(150) = null , 
@UNFE_cd_unidade_federativa char(2) = null , 
@PROC_fl_tipo_inclusao char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@PROC_cd_prioridade varchar(3) = null
 
AS


if @PROC_cd_processo is null or len(ltrim(rtrim(@PROC_cd_processo))) = 0 
 begin
  raiserror(''Número do Processo é obrigatório'',16,-1)
  --rollback transaction
  return
 end
  
UPDATE 
tb_PROC_processo 
SET 
PROC_ds_titular = case when @PROC_ds_titular is not null then @PROC_ds_titular else PROC_ds_titular end , 
PROC_vl_ano = case when @PROC_vl_ano is not null then @PROC_vl_ano else PROC_vl_ano end , 
PROC_nm_processo = case when @PROC_nm_processo is not null then @PROC_nm_processo else PROC_nm_processo end , 
PROC_id_processo = case when @PROC_id_processo is not null then @PROC_id_processo else PROC_id_processo end , 
FASE_cd_fase = case when @FASE_cd_fase is not null then @FASE_cd_fase else FASE_cd_fase end , 
PROC_cd_prioridade = case when @PROC_cd_prioridade is not null then @PROC_cd_prioridade else PROC_cd_prioridade end , 
PROC_ds_ultimo_evento = case when @PROC_ds_ultimo_evento is not null then @PROC_ds_ultimo_evento else PROC_ds_ultimo_evento end , 
PROC_ds_substancia = case when @PROC_ds_substancia is not null then @PROC_ds_substancia else PROC_ds_substancia end , 
PROC_ds_area = case when @PROC_ds_area is not null then @PROC_ds_area else PROC_ds_area end , 
PROC_ds_uso = case when @PROC_ds_uso is not null then @PROC_ds_uso else PROC_ds_uso end , 
PROC_ds_link = case when @PROC_ds_link is not null then @PROC_ds_link else PROC_ds_link end , 
UNFE_cd_unidade_federativa = case when @UNFE_cd_unidade_federativa is not null then @UNFE_cd_unidade_federativa else UNFE_cd_unidade_federativa end , 
PROC_fl_tipo_inclusao = case when @PROC_fl_tipo_inclusao is not null then @PROC_fl_tipo_inclusao else PROC_fl_tipo_inclusao end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRMP_processo_mprima]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRMP_processo_mprima]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PRMP_processo_mprima
CREATE PROCEDURE [dbo].[sp_upd_tb_PRMP_processo_mprima]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@MPRI_nm_mprima varchar(100) = null , 
@PRMP_vl_mprima decimal(15, 3) = null , 
@PRMP_un_mprima varchar(10) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PRMP_processo_mprima 
SET 
PRMP_vl_mprima = case when @PRMP_vl_mprima is not null then @PRMP_vl_mprima else PRMP_vl_mprima end , 
PRMP_un_mprima = case when @PRMP_un_mprima is not null then @PRMP_un_mprima else PRMP_un_mprima end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PREV_processo_evento]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PREV_processo_evento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PREV_processo_evento
CREATE PROCEDURE [dbo].[sp_upd_tb_PREV_processo_evento]
@PROC_cd_processo varchar(50) = null , 
@PREV_id_evento int = null,
@PREV_cd_evento varchar(20) = null , 
@PREV_ds_evento varchar(3000) = null , 
@PREV_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PREV_processo_evento 
SET 
PREV_cd_evento = case when @PREV_cd_evento is not null then @PREV_cd_evento else PREV_cd_evento end , 
PREV_ds_evento = case when @PREV_ds_evento is not null then @PREV_ds_evento else PREV_ds_evento end , 
PREV_dt_ocorrencia = case when @PREV_dt_ocorrencia is not null then (case when @PREV_dt_ocorrencia <> ''00:00:01'' then @PREV_dt_ocorrencia else null end) else PREV_dt_ocorrencia end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PREV_id_evento is null or (@PREV_id_evento is not null and PREV_id_evento = @PREV_id_evento))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRAN_processo_andamento]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRAN_processo_andamento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PRAN_processo_andamento
CREATE PROCEDURE [dbo].[sp_upd_tb_PRAN_processo_andamento]
@PROC_cd_processo varchar(50) = null , 
@PROC_ds_titular varchar(300) = null , 
@PROC_cd_ultimo_evento varchar(20) = null , 
@PROC_ds_ultimo_evento varchar(1000) = null , 
@PROC_ds_link varchar(150) = null , 
@PROC_cd_evento_andamento varchar(20) = null , 
@PROC_ds_evento_andamento varchar(1000) = null , 
@PROC_dt_vencimento datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PRAN_processo_andamento 
SET 
PROC_ds_titular = case when @PROC_ds_titular is not null then @PROC_ds_titular else PROC_ds_titular end , 
PROC_cd_ultimo_evento = case when @PROC_cd_ultimo_evento is not null then @PROC_cd_ultimo_evento else PROC_cd_ultimo_evento end , 
PROC_ds_ultimo_evento = case when @PROC_ds_ultimo_evento is not null then @PROC_ds_ultimo_evento else PROC_ds_ultimo_evento end , 
PROC_ds_link = case when @PROC_ds_link is not null then @PROC_ds_link else PROC_ds_link end , 
PROC_cd_evento_andamento = case when @PROC_cd_evento_andamento is not null then @PROC_cd_evento_andamento else PROC_cd_evento_andamento end , 
PROC_ds_evento_andamento = case when @PROC_ds_evento_andamento is not null then @PROC_ds_evento_andamento else PROC_ds_evento_andamento end , 
PROC_dt_vencimento = case when @PROC_dt_vencimento is not null then (case when @PROC_dt_vencimento <> ''00:00:01'' then @PROC_dt_vencimento else null end) else PROC_dt_vencimento end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PRAL_processo_alerta]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PRAL_processo_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PRAL_processo_alerta
CREATE PROCEDURE [dbo].[sp_upd_tb_PRAL_processo_alerta]
@PROC_cd_processo varchar(50) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PRAL_fl_manutencao char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PRAL_processo_alerta 
SET 
PRAL_fl_manutencao = case when @PRAL_fl_manutencao is not null then @PRAL_fl_manutencao else PRAL_fl_manutencao end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PORG_processo_orgao]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PORG_processo_orgao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PORG_processo_orgao
CREATE PROCEDURE [dbo].[sp_upd_tb_PORG_processo_orgao]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PORG_nm_cadastro varchar(30) = null , 
@PORG_ds_atividade varchar(500) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PORG_processo_orgao 
SET 
PORG_nm_cadastro = case when @PORG_nm_cadastro is not null then @PORG_nm_cadastro else PORG_nm_cadastro end , 
PORG_ds_atividade = case when @PORG_ds_atividade is not null then @PORG_ds_atividade else PORG_ds_atividade end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PNOT_processo_nota]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PNOT_processo_nota]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PNOT_processo_nota
CREATE PROCEDURE [dbo].[sp_upd_tb_PNOT_processo_nota]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PNOT_cd_nota int = null , 
@PNOT_ds_nota varchar(1000) = null , 
@PNOT_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PNOT_processo_nota 
SET 
PNOT_ds_nota = case when @PNOT_ds_nota is not null then @PNOT_ds_nota else PNOT_ds_nota end , 
PNOT_dt_ocorrencia = case when @PNOT_dt_ocorrencia is not null then (case when @PNOT_dt_ocorrencia <> ''00:00:01'' then @PNOT_dt_ocorrencia else null end) else PNOT_dt_ocorrencia end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PNOT_cd_nota is null or (@PNOT_cd_nota is not null and PNOT_cd_nota = @PNOT_cd_nota))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PMUN_processo_municipio]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PMUN_processo_municipio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PMUN_processo_municipio
CREATE PROCEDURE [dbo].[sp_upd_tb_PMUN_processo_municipio]
@PROC_cd_processo varchar(50) = null , 
@MUNI_nm_municipio varchar(150) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PMUN_processo_municipio 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@MUNI_nm_municipio is null or (@MUNI_nm_municipio is not null and MUNI_nm_municipio = @MUNI_nm_municipio))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PINF_processo_info]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PINF_processo_info]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PINF_processo_info
CREATE PROCEDURE [dbo].[sp_upd_tb_PINF_processo_info]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PINF_cd_info int = null , 
@PINF_ds_info varchar(500) = null , 
@TINF_nm_tipo_info varchar(100) = null , 
@SINF_ds_situacao_info varchar(100) = null , 
@PINF_dt_ini datetime = null , 
@PINF_dt_fim datetime = null , 
@PINF_ds_local_documento varchar(500) = null , 
@PINF_ds_rede_documento varchar(500) = null , 
@PINF_ds_path_documento varchar(500) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PINF_processo_info 
SET 
PINF_ds_info = case when @PINF_ds_info is not null then @PINF_ds_info else PINF_ds_info end , 
TINF_nm_tipo_info = case when @TINF_nm_tipo_info is not null then @TINF_nm_tipo_info else TINF_nm_tipo_info end , 
SINF_ds_situacao_info = case when @SINF_ds_situacao_info is not null then @SINF_ds_situacao_info else SINF_ds_situacao_info end , 
PINF_dt_ini = case when @PINF_dt_ini is not null then (case when @PINF_dt_ini <> ''00:00:01'' then @PINF_dt_ini else null end) else PINF_dt_ini end , 
PINF_dt_fim = case when @PINF_dt_fim is not null then (case when @PINF_dt_fim <> ''00:00:01'' then @PINF_dt_fim else null end) else PINF_dt_fim end , 
PINF_ds_local_documento = case when @PINF_ds_local_documento is not null then @PINF_ds_local_documento else PINF_ds_local_documento end , 
PINF_ds_rede_documento = case when @PINF_ds_rede_documento is not null then @PINF_ds_rede_documento else PINF_ds_rede_documento end , 
PINF_ds_path_documento = case when @PINF_ds_path_documento is not null then @PINF_ds_path_documento else PINF_ds_path_documento end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PINF_cd_info is null or (@PINF_cd_info is not null and PINF_cd_info = @PINF_cd_info))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PGER_parametro_geral]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PGER_parametro_geral]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PGER_parametro_geral
CREATE PROCEDURE [dbo].[sp_upd_tb_PGER_parametro_geral]
@PGER_cd_parametro varchar(10) = null , 
@PGER_ds_parametro varchar(100) = null , 
@PGER_vl_parametro varchar(1000) = null , 
@PGER_fl_tipo char(1) = null , 
@PGER_fl_sistema char(1) = null , 
@PGER_vl_range_min bigint = null , 
@PGER_vl_range_max bigint = null , 
@PGER_vl_padrao varchar(1000) = null , 
@PGER_vl_tamanho_min int = null , 
@PGER_vl_tamanho_max int = null , 
@PGER_vl_valores_permitidos varchar(8000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PGER_parametro_geral 
SET 
PGER_ds_parametro = case when @PGER_ds_parametro is not null then @PGER_ds_parametro else PGER_ds_parametro end , 
PGER_vl_parametro = case when @PGER_vl_parametro is not null then @PGER_vl_parametro else PGER_vl_parametro end , 
PGER_fl_tipo = case when @PGER_fl_tipo is not null then @PGER_fl_tipo else PGER_fl_tipo end , 
PGER_fl_sistema = case when @PGER_fl_sistema is not null then @PGER_fl_sistema else PGER_fl_sistema end , 
PGER_vl_range_min = case when @PGER_vl_range_min is not null then @PGER_vl_range_min else PGER_vl_range_min end , 
PGER_vl_range_max = case when @PGER_vl_range_max is not null then @PGER_vl_range_max else PGER_vl_range_max end , 
PGER_vl_padrao = case when @PGER_vl_padrao is not null then @PGER_vl_padrao else PGER_vl_padrao end , 
PGER_vl_tamanho_min = case when @PGER_vl_tamanho_min is not null then @PGER_vl_tamanho_min else PGER_vl_tamanho_min end , 
PGER_vl_tamanho_max = case when @PGER_vl_tamanho_max is not null then @PGER_vl_tamanho_max else PGER_vl_tamanho_max end , 
PGER_vl_valores_permitidos = case when @PGER_vl_valores_permitidos is not null then @PGER_vl_valores_permitidos else PGER_vl_valores_permitidos end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PGER_cd_parametro is null or (@PGER_cd_parametro is not null and PGER_cd_parametro = @PGER_cd_parametro))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PDOC_processo_documento]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PDOC_processo_documento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PDOC_processo_documento
CREATE PROCEDURE [dbo].[sp_upd_tb_PDOC_processo_documento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@PDOC_nm_documento varchar(100) = null , 
@PDOC_ds_documento varchar(1000) = null , 
@PDOC_ds_local_documento varchar(1000) = null , 
@PDOC_ds_rede_documento varchar(1000) = null , 
@PDOC_ds_path_documento varchar(1000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PDOC_processo_documento 
SET 
PDOC_ds_documento = case when @PDOC_ds_documento is not null then @PDOC_ds_documento else PDOC_ds_documento end , 
PDOC_ds_local_documento = case when @PDOC_ds_local_documento is not null then @PDOC_ds_local_documento else PDOC_ds_local_documento end , 
PDOC_ds_rede_documento = case when @PDOC_ds_rede_documento is not null then @PDOC_ds_rede_documento else PDOC_ds_rede_documento end , 
PDOC_ds_path_documento = case when @PDOC_ds_path_documento is not null then @PDOC_ds_path_documento else PDOC_ds_path_documento end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@PDOC_nm_documento is null or (@PDOC_nm_documento is not null and PDOC_nm_documento = @PDOC_nm_documento))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PCON_processo_condicao]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PCON_processo_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PCON_processo_condicao
CREATE PROCEDURE [dbo].[sp_upd_tb_PCON_processo_condicao]
@PROC_cd_processo varchar(50) = null , 
@PCON_cd_condicao int = null , 
@COND_nm_condicao varchar(500) = null , 
@SCON_ds_situacao_condicao varchar(100) = null , 
@PCON_ds_condicao varchar(500) = null , 
@PCON_dt_ini datetime = null , 
@PCON_dt_fim datetime = null , 
@PCON_ds_nome_documento varchar(1000) = null , 
@PCON_ds_local_documento varchar(1000) = null , 
@PCON_ds_rede_documento varchar(1000) = null , 
@PCON_ds_path_documento varchar(1000) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PCON_processo_condicao 
SET 
COND_nm_condicao = case when @COND_nm_condicao is not null then @COND_nm_condicao else COND_nm_condicao end , 
SCON_ds_situacao_condicao = case when @SCON_ds_situacao_condicao is not null then @SCON_ds_situacao_condicao else SCON_ds_situacao_condicao end , 
PCON_ds_condicao = case when @PCON_ds_condicao is not null then @PCON_ds_condicao else PCON_ds_condicao end , 
PCON_dt_ini = case when @PCON_dt_ini is not null then (case when @PCON_dt_ini <> ''00:00:01'' then @PCON_dt_ini else null end) else PCON_dt_ini end , 
PCON_dt_fim = case when @PCON_dt_fim is not null then (case when @PCON_dt_fim <> ''00:00:01'' then @PCON_dt_fim else null end) else PCON_dt_fim end , 
PCON_ds_nome_documento = case when @PCON_ds_nome_documento is not null then @PCON_ds_nome_documento else PCON_ds_nome_documento end , 
PCON_ds_local_documento = case when @PCON_ds_local_documento is not null then @PCON_ds_local_documento else PCON_ds_local_documento end , 
PCON_ds_rede_documento = case when @PCON_ds_rede_documento is not null then @PCON_ds_rede_documento else PCON_ds_rede_documento end , 
PCON_ds_path_documento = case when @PCON_ds_path_documento is not null then @PCON_ds_path_documento else PCON_ds_path_documento end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PCON_cd_condicao is null or (@PCON_cd_condicao is not null and PCON_cd_condicao = @PCON_cd_condicao))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PAUX_processo_auxiliar]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PAUX_processo_auxiliar]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PAUX_processo_auxiliar
CREATE PROCEDURE [dbo].[sp_upd_tb_PAUX_processo_auxiliar]
@PAUX_cd_processo varchar(50) = null , 
@PAUX_ds_titular varchar(300) = null , 
@FASE_cd_fase int = null , 
@PAUX_ds_ultimo_evento varchar(3000) = null , 
@UNFE_cd_unidade_federativa char(2) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PAUX_processo_auxiliar 
SET 
PAUX_ds_titular = case when @PAUX_ds_titular is not null then @PAUX_ds_titular else PAUX_ds_titular end , 
FASE_cd_fase = case when @FASE_cd_fase is not null then @FASE_cd_fase else FASE_cd_fase end , 
PAUX_ds_ultimo_evento = case when @PAUX_ds_ultimo_evento is not null then @PAUX_ds_ultimo_evento else PAUX_ds_ultimo_evento end , 
UNFE_cd_unidade_federativa = case when @UNFE_cd_unidade_federativa is not null then @UNFE_cd_unidade_federativa else UNFE_cd_unidade_federativa end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PAUX_cd_processo is null or (@PAUX_cd_processo is not null and PAUX_cd_processo = @PAUX_cd_processo))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_PASO_processo_associado]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_PASO_processo_associado]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_PASO_processo_associado
CREATE PROCEDURE [dbo].[sp_upd_tb_PASO_processo_associado]
@PROC_cd_processo varchar(50) = null , 
@PASO_cd_processo varchar(50) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_PASO_processo_associado 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@PASO_cd_processo is null or (@PASO_cd_processo is not null and PASO_cd_processo = @PASO_cd_processo))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_OSSD_objeto_sd]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_OSSD_objeto_sd]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_OSSD_objeto_sd
CREATE PROCEDURE [dbo].[sp_upd_tb_OSSD_objeto_sd]
@ORGA_nm_orgao varchar(10) = null , 
@OSSD_nm_objeto varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_OSSD_objeto_sd 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@OSSD_nm_objeto is null or (@OSSD_nm_objeto is not null and OSSD_nm_objeto = @OSSD_nm_objeto))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_OPER_operador]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_OPER_operador]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_OPER_operador
CREATE PROCEDURE [dbo].[sp_upd_tb_OPER_operador]
@OPER_cd_operador varchar(20) = null , 
@OPER_nm_operador varchar(1000) = null , 
@OPER_ds_email varchar(200) = null , 
@OPER_fl_alerta char(1) = null , 
@OPER_fl_alerta_nativo char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_OPER_operador 
SET 
OPER_nm_operador = case when @OPER_nm_operador is not null then @OPER_nm_operador else OPER_nm_operador end , 
OPER_ds_email = case when @OPER_ds_email is not null then @OPER_ds_email else OPER_ds_email end , 
OPER_fl_alerta = case when @OPER_fl_alerta is not null then @OPER_fl_alerta else OPER_fl_alerta end , 
OPER_fl_alerta_nativo = case when @OPER_fl_alerta_nativo is not null then @OPER_fl_alerta_nativo else OPER_fl_alerta_nativo end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@OPER_cd_operador is null or (@OPER_cd_operador is not null and OPER_cd_operador = @OPER_cd_operador))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_MUNI_municipio]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_MUNI_municipio]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_MUNI_municipio
CREATE PROCEDURE [dbo].[sp_upd_tb_MUNI_municipio]
@MUNI_nm_municipio varchar(150) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_MUNI_municipio 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@MUNI_nm_municipio is null or (@MUNI_nm_municipio is not null and MUNI_nm_municipio = @MUNI_nm_municipio))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_MPRI_mprima]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_MPRI_mprima]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_MPRI_mprima
CREATE PROCEDURE [dbo].[sp_upd_tb_MPRI_mprima]
@MPRI_nm_mprima varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_MPRI_mprima 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@MPRI_nm_mprima is null or (@MPRI_nm_mprima is not null and MPRI_nm_mprima = @MPRI_nm_mprima))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_LESI_log_erro_sistema]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_LESI_log_erro_sistema]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_LESI_log_erro_sistema
CREATE PROCEDURE [dbo].[sp_upd_tb_LESI_log_erro_sistema]
@LESI_cd_ocorrencia bigint = null , 
@LESI_nm_source varchar(100) = null , 
@LESI_ds_exception varchar(8000) = null , 
@LESI_ds_inexception varchar(8000) = null , 
@LESI_dt_ocorrencia datetime = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null 
 
AS
 
UPDATE 
tb_LESI_log_erro_sistema 
SET 
LESI_nm_source = case when @LESI_nm_source is not null then @LESI_nm_source else LESI_nm_source end , 
LESI_ds_exception = case when @LESI_ds_exception is not null then @LESI_ds_exception else LESI_ds_exception end , 
LESI_ds_inexception = case when @LESI_ds_inexception is not null then @LESI_ds_inexception else LESI_ds_inexception end , 
LESI_dt_ocorrencia = case when @LESI_dt_ocorrencia is not null then (case when @LESI_dt_ocorrencia <> ''00:00:01'' then @LESI_dt_ocorrencia else null end) else LESI_dt_ocorrencia end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end  
 where (@LESI_cd_ocorrencia is null or (@LESI_cd_ocorrencia is not null and LESI_cd_ocorrencia = @LESI_cd_ocorrencia))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_HSAL_historico_alerta]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_HSAL_historico_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_HSAL_historico_alerta
CREATE PROCEDURE [dbo].[sp_upd_tb_HSAL_historico_alerta]
@HSAL_id_historico int = null , 
@HSAL_ds_email varchar(200) = null , 
@ALER_nm_alerta varchar(50) = null , 
@PROC_cd_processo varchar(50) = null , 
@HSAL_ds_assunto_email varchar(200) = null , 
@HSAL_ds_texto_email varchar(8000) = null , 
@HSAL_dt_envio datetime = null , 
@HSAL_dt_tentativa_ultimo_envio datetime = null , 
@HSAL_ds_mensagem varchar(8000) = null , 
@HSAL_fl_status char(3) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null 
 
AS
 
UPDATE 
tb_HSAL_historico_alerta 
SET 
HSAL_ds_email = case when @HSAL_ds_email is not null then @HSAL_ds_email else HSAL_ds_email end , 
ALER_nm_alerta = case when @ALER_nm_alerta is not null then @ALER_nm_alerta else ALER_nm_alerta end , 
PROC_cd_processo = case when @PROC_cd_processo is not null then @PROC_cd_processo else PROC_cd_processo end , 
HSAL_ds_assunto_email = case when @HSAL_ds_assunto_email is not null then @HSAL_ds_assunto_email else HSAL_ds_assunto_email end , 
HSAL_ds_texto_email = case when @HSAL_ds_texto_email is not null then @HSAL_ds_texto_email else HSAL_ds_texto_email end , 
HSAL_dt_envio = case when @HSAL_dt_envio is not null then (case when @HSAL_dt_envio <> ''00:00:01'' then @HSAL_dt_envio else null end) else HSAL_dt_envio end , 
HSAL_dt_tentativa_ultimo_envio = case when @HSAL_dt_tentativa_ultimo_envio is not null then (case when @HSAL_dt_tentativa_ultimo_envio <> ''00:00:01'' then @HSAL_dt_tentativa_ultimo_envio else null end) else HSAL_dt_tentativa_ultimo_envio end , 
HSAL_ds_mensagem = case when @HSAL_ds_mensagem is not null then @HSAL_ds_mensagem else HSAL_ds_mensagem end , 
HSAL_fl_status = case when @HSAL_fl_status is not null then @HSAL_fl_status else HSAL_fl_status end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end  
 where (@HSAL_id_historico is null or (@HSAL_id_historico is not null and HSAL_id_historico = @HSAL_id_historico))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_FASE_fase]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_FASE_fase]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_FASE_fase
CREATE PROCEDURE [dbo].[sp_upd_tb_FASE_fase]
@FASE_cd_fase int = null , 
@FASE_nm_fase varchar(100) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_FASE_fase 
SET 
FASE_nm_fase = case when @FASE_nm_fase is not null then @FASE_nm_fase else FASE_nm_fase end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@FASE_cd_fase is null or (@FASE_cd_fase is not null and FASE_cd_fase = @FASE_cd_fase))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_EMPR_empresa]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_EMPR_empresa]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_EMPR_empresa
CREATE PROCEDURE [dbo].[sp_upd_tb_EMPR_empresa]
@EMPR_nm_empresa varchar(20) = null , 
@EMPR_ds_empresa varchar(300) = null , 
@EMPR_fl_status char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@EMPR_ds_dou varchar(500) = null
 
AS
 
UPDATE 
tb_EMPR_empresa 
SET 
EMPR_ds_empresa = case when @EMPR_ds_empresa is not null then @EMPR_ds_empresa else EMPR_ds_empresa end , 
EMPR_fl_status = case when @EMPR_fl_status is not null then @EMPR_fl_status else EMPR_fl_status end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  ,
EMPR_ds_dou = case when @EMPR_ds_dou is not null then @EMPR_ds_dou else EMPR_ds_dou end  
 where (@EMPR_nm_empresa is null or (@EMPR_nm_empresa is not null and EMPR_nm_empresa = @EMPR_nm_empresa))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_COVE_controle_vencimento]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_COVE_controle_vencimento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_COVE_controle_vencimento
CREATE PROCEDURE [dbo].[sp_upd_tb_COVE_controle_vencimento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@COVE_nm_tipo_documento varchar(10) = null , 
@COVE_id_documento varchar(20) = null , 
@COVE_qt_inicio int = null , 
@COVE_qt_intervalo int = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_COVE_controle_vencimento 
SET 
COVE_qt_inicio = case when @COVE_qt_inicio is not null then @COVE_qt_inicio else COVE_qt_inicio end , 
COVE_qt_intervalo = case when @COVE_qt_intervalo is not null then @COVE_qt_intervalo else COVE_qt_intervalo end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@COVE_nm_tipo_documento is null or (@COVE_nm_tipo_documento is not null and COVE_nm_tipo_documento = @COVE_nm_tipo_documento))  AND 
(@COVE_id_documento is null or (@COVE_id_documento is not null and COVE_id_documento = @COVE_id_documento))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_COND_condicao]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_COND_condicao]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_COND_condicao
CREATE PROCEDURE [dbo].[sp_upd_tb_COND_condicao]
@COND_nm_condicao varchar(500) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_COND_condicao 
SET 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@COND_nm_condicao is null or (@COND_nm_condicao is not null and COND_nm_condicao = @COND_nm_condicao))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_BACK_backup]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_BACK_backup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_BACK_backup
CREATE PROCEDURE [dbo].[sp_upd_tb_BACK_backup]
@BACK_cd_backup int = null , 
@BACK_vl_intervalo int = null , 
@BACK_nm_arquivo varchar(30) = null , 
@BACK_fl_execucao char(1) = null , 
@BACK_ds_mensagem varchar(500) = null , 
@BACK_dt_execucao datetime = null , 
@BACK_dt_tentativa_Execucao datetime = null , 
@BACK_dt_backup datetime = null , 
@BACK_dt_sincronizacao datetime = null , 
@BACK_fl_tipo char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_BACK_backup 
SET 
BACK_vl_intervalo = case when @BACK_vl_intervalo is not null then @BACK_vl_intervalo else BACK_vl_intervalo end , 
BACK_nm_arquivo = case when @BACK_nm_arquivo is not null then @BACK_nm_arquivo else BACK_nm_arquivo end , 
BACK_fl_execucao = case when @BACK_fl_execucao is not null then @BACK_fl_execucao else BACK_fl_execucao end , 
BACK_ds_mensagem = case when @BACK_ds_mensagem is not null then @BACK_ds_mensagem else BACK_ds_mensagem end , 
BACK_dt_execucao = case when @BACK_dt_execucao is not null then (case when @BACK_dt_execucao <> ''00:00:01'' then @BACK_dt_execucao else null end) else BACK_dt_execucao end , 
BACK_dt_tentativa_Execucao = case when @BACK_dt_tentativa_Execucao is not null then (case when @BACK_dt_tentativa_Execucao <> ''00:00:01'' then @BACK_dt_tentativa_Execucao else null end) else BACK_dt_tentativa_Execucao end , 
BACK_dt_backup = case when @BACK_dt_backup is not null then (case when @BACK_dt_backup <> ''00:00:01'' then @BACK_dt_backup else null end) else BACK_dt_backup end , 
BACK_dt_sincronizacao = case when @BACK_dt_sincronizacao is not null then (case when @BACK_dt_sincronizacao <> ''00:00:01'' then @BACK_dt_sincronizacao else null end) else BACK_dt_sincronizacao end , 
BACK_fl_tipo = case when @BACK_fl_tipo is not null then @BACK_fl_tipo else BACK_fl_tipo end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@BACK_cd_backup is null or (@BACK_cd_backup is not null and BACK_cd_backup = @BACK_cd_backup))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_AVEN_alerta_vencimento]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_AVEN_alerta_vencimento]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_AVEN_alerta_vencimento
CREATE PROCEDURE [dbo].[sp_upd_tb_AVEN_alerta_vencimento]
@PROC_cd_processo varchar(50) = null , 
@ORGA_nm_orgao varchar(10) = null , 
@AVEN_nm_tipo_documento varchar(40) = null , 
@AVEN_id_documento varchar(20) = null , 
@AVEN_fl_conta_alerta int = null , 
@AVEN_dt_ultimo_alerta datetime = null , 
@AVEN_fl_ultimo_envio char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null 
 
AS
 
UPDATE 
tb_AVEN_alerta_vencimento 
SET 
AVEN_fl_conta_alerta = case when @AVEN_fl_conta_alerta is not null then @AVEN_fl_conta_alerta else AVEN_fl_conta_alerta end , 
AVEN_dt_ultimo_alerta = case when @AVEN_dt_ultimo_alerta is not null then (case when @AVEN_dt_ultimo_alerta <> ''00:00:01'' then @AVEN_dt_ultimo_alerta else null end) else AVEN_dt_ultimo_alerta end , 
AVEN_fl_ultimo_envio = case when @AVEN_fl_ultimo_envio is not null then @AVEN_fl_ultimo_envio else AVEN_fl_ultimo_envio end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  
 where (@PROC_cd_processo is null or (@PROC_cd_processo is not null and PROC_cd_processo = @PROC_cd_processo))  AND 
(@ORGA_nm_orgao is null or (@ORGA_nm_orgao is not null and ORGA_nm_orgao = @ORGA_nm_orgao))  AND 
(@AVEN_nm_tipo_documento is null or (@AVEN_nm_tipo_documento is not null and AVEN_nm_tipo_documento = @AVEN_nm_tipo_documento))  AND 
(@AVEN_id_documento is null or (@AVEN_id_documento is not null and AVEN_id_documento = @AVEN_id_documento))  
 
' 
END
GO
/****** Object:  StoredProcedure [dbo].[sp_upd_tb_ALER_alerta]    Script Date: 03/25/2018 20:38:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[sp_upd_tb_ALER_alerta]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N' 
-- STORED PROCEDURE PARA ALTERAR REGISTROS NA TABELA tb_ALER_alerta
CREATE PROCEDURE [dbo].[sp_upd_tb_ALER_alerta]
@ALER_nm_alerta varchar(50) = null , 
@ALER_ds_alerta varchar(300) = null , 
@ALER_fl_muda_fase char(1) = null , 
@ALER_fl_muda_evento char(1) = null , 
@ALER_cd_fase_anterior int = null , 
@ALER_cd_fase_nova int = null , 
@ALER_fl_qualquer_processo char(1) = null , 
@ALER_fl_status char(1) = null , 
@ALER_fl_sistema char(1) = null , 
@AUDT_dt_inclusao datetime = null , 
@AUDT_nm_usuario_inclusao varchar(20) = null , 
@AUDT_dt_alteracao datetime = null , 
@AUDT_nm_usuario_alteracao varchar(20) = null ,
@ALER_fl_geral char(1) = null,
@ALER_cd_evento varchar(5) = null,
@ALER_fl_andamento char(1) = null,
@ALER_fl_acao char(1) = null
 
AS
 
 
 if @ALER_nm_alerta is null or len(ltrim(rtrim(@ALER_nm_alerta))) = 0 
 begin
  raiserror(''Identificador do Alerta é obrigatório'',16,-1)
  --rollback transaction
  return
 end
 
UPDATE 
tb_ALER_alerta 
SET 
ALER_ds_alerta = case when @ALER_ds_alerta is not null then @ALER_ds_alerta else ALER_ds_alerta end , 
ALER_fl_muda_fase = case when @ALER_fl_muda_fase is not null then @ALER_fl_muda_fase else ALER_fl_muda_fase end , 
ALER_fl_muda_evento = case when @ALER_fl_muda_evento is not null then @ALER_fl_muda_evento else ALER_fl_muda_evento end , 
ALER_cd_fase_anterior = case when @ALER_cd_fase_anterior is not null then @ALER_cd_fase_anterior else ALER_cd_fase_anterior end , 
ALER_cd_fase_nova = case when @ALER_cd_fase_nova is not null then @ALER_cd_fase_nova else ALER_cd_fase_nova end , 
ALER_fl_qualquer_processo = case when @ALER_fl_qualquer_processo is not null then @ALER_fl_qualquer_processo else ALER_fl_qualquer_processo end , 
ALER_fl_status = case when @ALER_fl_status is not null then @ALER_fl_status else ALER_fl_status end , 
ALER_fl_sistema = case when @ALER_fl_sistema is not null then @ALER_fl_sistema else ALER_fl_sistema end , 
AUDT_dt_inclusao = case when @AUDT_dt_inclusao is not null then (case when @AUDT_dt_inclusao <> ''00:00:01'' then @AUDT_dt_inclusao else null end) else AUDT_dt_inclusao end , 
AUDT_nm_usuario_inclusao = case when @AUDT_nm_usuario_inclusao is not null then @AUDT_nm_usuario_inclusao else AUDT_nm_usuario_inclusao end , 
AUDT_dt_alteracao = case when @AUDT_dt_alteracao is not null then (case when @AUDT_dt_alteracao <> ''00:00:01'' then @AUDT_dt_alteracao else null end) else AUDT_dt_alteracao end , 
AUDT_nm_usuario_alteracao = case when @AUDT_nm_usuario_alteracao is not null then @AUDT_nm_usuario_alteracao else AUDT_nm_usuario_alteracao end  ,
ALER_fl_geral = case when @ALER_fl_geral is not null then @ALER_fl_geral else ALER_fl_geral end  ,
ALER_cd_evento = case when @ALER_cd_evento is not null then @ALER_cd_evento else ALER_cd_evento end ,
ALER_fl_andamento = case when @ALER_fl_andamento is not null then @ALER_fl_andamento else ALER_fl_andamento end  ,
ALER_fl_acao = case when @ALER_fl_acao is not null then @ALER_fl_acao else ALER_fl_acao end  
 where (@ALER_nm_alerta is null or (@ALER_nm_alerta is not null and ALER_nm_alerta = @ALER_nm_alerta))  
 
' 
END
GO
