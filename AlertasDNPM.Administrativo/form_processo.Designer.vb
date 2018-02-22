<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_processo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim HeaderStateStyle4 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim HeaderStateStyle5 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim HeaderStateStyle6 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_processo))
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.tab_main = New System.Windows.Forms.TabControl
        Me.tab_principal = New System.Windows.Forms.TabPage
        Me.panel_details = New Owf.Controls.A1Panel
        Me.button_mapa = New System.Windows.Forms.Button
        Me.panel_main = New System.Windows.Forms.Panel
        Me.button_cancel = New System.Windows.Forms.Button
        Me.label_progresso = New System.Windows.Forms.Label
        Me.pbar_down = New System.Windows.Forms.ProgressBar
        Me.button_report = New System.Windows.Forms.Button
        Me.button_del = New System.Windows.Forms.Button
        Me.combo_titular = New System.Windows.Forms.ComboBox
        Me.label_num = New System.Windows.Forms.Label
        Me.button_confirm = New System.Windows.Forms.Button
        Me.text_num = New System.Windows.Forms.TextBox
        Me.link_processo = New System.Windows.Forms.LinkLabel
        Me.combo_uf = New System.Windows.Forms.ComboBox
        Me.label_uf = New System.Windows.Forms.Label
        Me.text_link = New System.Windows.Forms.TextBox
        Me.label_link = New System.Windows.Forms.Label
        Me.label_id = New System.Windows.Forms.Label
        Me.text_id = New System.Windows.Forms.TextBox
        Me.text_uso = New System.Windows.Forms.TextBox
        Me.label_uso = New System.Windows.Forms.Label
        Me.text_area = New System.Windows.Forms.TextBox
        Me.label_area = New System.Windows.Forms.Label
        Me.text_substancia = New System.Windows.Forms.TextBox
        Me.label_substancia = New System.Windows.Forms.Label
        Me.label_ultimo_evento = New System.Windows.Forms.Label
        Me.text_ultimo_evento = New System.Windows.Forms.TextBox
        Me.combo_fase = New System.Windows.Forms.ComboBox
        Me.text_ano = New System.Windows.Forms.TextBox
        Me.label_fase = New System.Windows.Forms.Label
        Me.label_ano = New System.Windows.Forms.Label
        Me.label_titular = New System.Windows.Forms.Label
        Me.label_name = New System.Windows.Forms.Label
        Me.text_name = New System.Windows.Forms.TextBox
        Me.tab_alerta = New System.Windows.Forms.TabPage
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.button_alerta_refresh = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.label_tip_alerta1 = New System.Windows.Forms.Label
        Me.label_tip_alerta2 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.button_alerta_confirm = New System.Windows.Forms.Button
        Me.label_alerta = New System.Windows.Forms.Label
        Me.list_alerta = New BrightIdeasSoftware.DataListView
        Me.column_alerta_name = New BrightIdeasSoftware.OLVColumn
        Me.column_alerta_fase = New BrightIdeasSoftware.OLVColumn
        Me.column_alerta_evento = New BrightIdeasSoftware.OLVColumn
        Me.column_alerta_status = New BrightIdeasSoftware.OLVColumn
        Me.tab_operador = New System.Windows.Forms.TabPage
        Me.A1Panel3 = New Owf.Controls.A1Panel
        Me.button_operador_refresh = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.label_tip_operador1 = New System.Windows.Forms.Label
        Me.label_tip_operador2 = New System.Windows.Forms.Label
        Me.pic_tip = New System.Windows.Forms.PictureBox
        Me.button_operador_confirm = New System.Windows.Forms.Button
        Me.label_operador = New System.Windows.Forms.Label
        Me.list_operador = New BrightIdeasSoftware.DataListView
        Me.column_operador_code = New BrightIdeasSoftware.OLVColumn
        Me.column_operador_name = New BrightIdeasSoftware.OLVColumn
        Me.column_operador_email = New BrightIdeasSoftware.OLVColumn
        Me.column_operador_flag1 = New BrightIdeasSoftware.OLVColumn
        Me.column_operador_flag2 = New BrightIdeasSoftware.OLVColumn
        Me.tab_evento = New System.Windows.Forms.TabPage
        Me.A1Panel4 = New Owf.Controls.A1Panel
        Me.button_add_evento = New System.Windows.Forms.LinkLabel
        Me.button_evento_refresh = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.label_evento_tip1 = New System.Windows.Forms.Label
        Me.label_evento_tip2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.button_evento_confirm = New System.Windows.Forms.Button
        Me.label_evento = New System.Windows.Forms.Label
        Me.list_evento = New BrightIdeasSoftware.DataListView
        Me.column_evento_code = New BrightIdeasSoftware.OLVColumn
        Me.column_evento_desc = New BrightIdeasSoftware.OLVColumn
        Me.column_evento_date = New BrightIdeasSoftware.OLVColumn
        Me.tab_dnpm = New System.Windows.Forms.TabPage
        Me.A1Panel5 = New Owf.Controls.A1Panel
        Me.button_dnpm_add_documento = New System.Windows.Forms.LinkLabel
        Me.labl_dnpm_documento = New System.Windows.Forms.Label
        Me.list_dnpm_documento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn107 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn108 = New BrightIdeasSoftware.OLVColumn
        Me.button_dnpm_add_condicao = New System.Windows.Forms.LinkLabel
        Me.label_condicao = New System.Windows.Forms.Label
        Me.list_dnpm_condicao = New BrightIdeasSoftware.DataListView
        Me.OlvColumn14 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn15 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn97 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn98 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn99 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn100 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn16 = New BrightIdeasSoftware.OLVColumn
        Me.button_dnpm_add_associado = New System.Windows.Forms.LinkLabel
        Me.label_associado = New System.Windows.Forms.Label
        Me.list_dnpm_associado = New BrightIdeasSoftware.DataListView
        Me.OlvColumn10 = New BrightIdeasSoftware.OLVColumn
        Me.button_dnpm_add_municipio = New System.Windows.Forms.LinkLabel
        Me.label_dnpm_municipio = New System.Windows.Forms.Label
        Me.list_dnpm_municipio = New BrightIdeasSoftware.DataListView
        Me.OlvColumn9 = New BrightIdeasSoftware.OLVColumn
        Me.button_dnpm_add_substancia = New System.Windows.Forms.LinkLabel
        Me.label_dnpm_substancia = New System.Windows.Forms.Label
        Me.list_dnpm_substancia = New BrightIdeasSoftware.DataListView
        Me.OlvColumn7 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn8 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn11 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn12 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn13 = New BrightIdeasSoftware.OLVColumn
        Me.button_dnpm_add_titulo = New System.Windows.Forms.LinkLabel
        Me.label_dnpm_titulo = New System.Windows.Forms.Label
        Me.list_dnpm_titulo = New BrightIdeasSoftware.DataListView
        Me.OlvColumn1 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn2 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn3 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn4 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn5 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn6 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn106 = New BrightIdeasSoftware.OLVColumn
        Me.tab_cetesb = New System.Windows.Forms.TabPage
        Me.A1Panel6 = New Owf.Controls.A1Panel
        Me.button_cetesb_add_mp = New System.Windows.Forms.LinkLabel
        Me.label_cetesb_mp = New System.Windows.Forms.Label
        Me.list_cetesb_mp = New BrightIdeasSoftware.DataListView
        Me.OlvColumn101 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn103 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn104 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn105 = New BrightIdeasSoftware.OLVColumn
        Me.button_cetesb_confirm = New System.Windows.Forms.LinkLabel
        Me.text_cetesb_atividade = New System.Windows.Forms.TextBox
        Me.text_cetesb_cadastro = New System.Windows.Forms.TextBox
        Me.label_cetesb_atividade = New System.Windows.Forms.Label
        Me.label_cetesb_cadastro = New System.Windows.Forms.Label
        Me.button_cetesb_add_evento = New System.Windows.Forms.LinkLabel
        Me.label_cetesb_evento = New System.Windows.Forms.Label
        Me.list_cetesb_evento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn19 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn21 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn22 = New BrightIdeasSoftware.OLVColumn
        Me.button_cetesb_add_documento = New System.Windows.Forms.LinkLabel
        Me.label_cetesb_documento = New System.Windows.Forms.Label
        Me.list_cetesb_documento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn17 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn18 = New BrightIdeasSoftware.OLVColumn
        Me.button_cetesb_add_titulo = New System.Windows.Forms.LinkLabel
        Me.label_cetesb_titulo = New System.Windows.Forms.Label
        Me.list_cetesb_titulo = New BrightIdeasSoftware.DataListView
        Me.OlvColumn27 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn28 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn29 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn30 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn31 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn20 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn32 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn102 = New BrightIdeasSoftware.OLVColumn
        Me.tab_daee = New System.Windows.Forms.TabPage
        Me.A1Panel7 = New Owf.Controls.A1Panel
        Me.button_daee_add_info = New System.Windows.Forms.LinkLabel
        Me.label_daee_info = New System.Windows.Forms.Label
        Me.list_daee_info = New BrightIdeasSoftware.DataListView
        Me.OlvColumn81 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn79 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn80 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn78 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn77 = New BrightIdeasSoftware.OLVColumn
        Me.button_daee_add_evento = New System.Windows.Forms.LinkLabel
        Me.label_daee_evento = New System.Windows.Forms.Label
        Me.list_daee_evento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn23 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn24 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn25 = New BrightIdeasSoftware.OLVColumn
        Me.button_daee_add_documento = New System.Windows.Forms.LinkLabel
        Me.label_daee_documento = New System.Windows.Forms.Label
        Me.list_daee_documento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn26 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn33 = New BrightIdeasSoftware.OLVColumn
        Me.button_daee_add_titulo = New System.Windows.Forms.LinkLabel
        Me.label_daee_titulo = New System.Windows.Forms.Label
        Me.list_daee_titulo = New BrightIdeasSoftware.DataListView
        Me.OlvColumn34 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn35 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn36 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn37 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn38 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn39 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn40 = New BrightIdeasSoftware.OLVColumn
        Me.tab_icmbio = New System.Windows.Forms.TabPage
        Me.A1Panel8 = New Owf.Controls.A1Panel
        Me.button_icmbio_add_info = New System.Windows.Forms.LinkLabel
        Me.label_icmbio_info = New System.Windows.Forms.Label
        Me.list_icmbio_info = New BrightIdeasSoftware.DataListView
        Me.OlvColumn82 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn83 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn84 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn85 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn86 = New BrightIdeasSoftware.OLVColumn
        Me.button_icmbio_add_evento = New System.Windows.Forms.LinkLabel
        Me.label_icmbio_evento = New System.Windows.Forms.Label
        Me.list_icmbio_evento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn41 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn42 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn43 = New BrightIdeasSoftware.OLVColumn
        Me.button_icmbio_add_documento = New System.Windows.Forms.LinkLabel
        Me.label_icmbio_documento = New System.Windows.Forms.Label
        Me.list_icmbio_documento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn44 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn45 = New BrightIdeasSoftware.OLVColumn
        Me.button_icmbio_add_titulo = New System.Windows.Forms.LinkLabel
        Me.label_icmbio_titulo = New System.Windows.Forms.Label
        Me.list_icmbio_titulo = New BrightIdeasSoftware.DataListView
        Me.OlvColumn46 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn47 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn48 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn49 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn50 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn51 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn52 = New BrightIdeasSoftware.OLVColumn
        Me.tab_petrobras = New System.Windows.Forms.TabPage
        Me.A1Panel9 = New Owf.Controls.A1Panel
        Me.button_petrobras_add_info = New System.Windows.Forms.LinkLabel
        Me.label_petrobras_info = New System.Windows.Forms.Label
        Me.list_petrobras_info = New BrightIdeasSoftware.DataListView
        Me.OlvColumn87 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn88 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn89 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn90 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn91 = New BrightIdeasSoftware.OLVColumn
        Me.button_petrobras_add_evento = New System.Windows.Forms.LinkLabel
        Me.label_petrobras_evento = New System.Windows.Forms.Label
        Me.list_petrobras_evento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn53 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn54 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn55 = New BrightIdeasSoftware.OLVColumn
        Me.button_petrobras_add_documento = New System.Windows.Forms.LinkLabel
        Me.label_petrobras_documento = New System.Windows.Forms.Label
        Me.list_petrobras_documento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn56 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn57 = New BrightIdeasSoftware.OLVColumn
        Me.button_petrobras_add_titulo = New System.Windows.Forms.LinkLabel
        Me.label_petrobras_titulo = New System.Windows.Forms.Label
        Me.list_petrobras_titulo = New BrightIdeasSoftware.DataListView
        Me.OlvColumn58 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn59 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn60 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn61 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn62 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn63 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn64 = New BrightIdeasSoftware.OLVColumn
        Me.tab_prefeitura = New System.Windows.Forms.TabPage
        Me.A1Panel10 = New Owf.Controls.A1Panel
        Me.button_prefeitura_add_info = New System.Windows.Forms.LinkLabel
        Me.label_prefeitura_info = New System.Windows.Forms.Label
        Me.list_prefeitura_info = New BrightIdeasSoftware.DataListView
        Me.OlvColumn92 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn93 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn94 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn95 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn96 = New BrightIdeasSoftware.OLVColumn
        Me.button_prefeitura_add_evento = New System.Windows.Forms.LinkLabel
        Me.label_prefeitura_evento = New System.Windows.Forms.Label
        Me.list_prefeitura_evento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn65 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn66 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn67 = New BrightIdeasSoftware.OLVColumn
        Me.button_prefeitura_add_documento = New System.Windows.Forms.LinkLabel
        Me.label_prefeitura_documento = New System.Windows.Forms.Label
        Me.list_prefeitura_documento = New BrightIdeasSoftware.DataListView
        Me.OlvColumn68 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn69 = New BrightIdeasSoftware.OLVColumn
        Me.button_prefeitura_add_titulo = New System.Windows.Forms.LinkLabel
        Me.label_prefeitura_titulo = New System.Windows.Forms.Label
        Me.list_prefeitura_titulo = New BrightIdeasSoftware.DataListView
        Me.OlvColumn70 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn71 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn72 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn73 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn74 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn75 = New BrightIdeasSoftware.OLVColumn
        Me.OlvColumn76 = New BrightIdeasSoftware.OLVColumn
        Me.panel_command = New Owf.Controls.A1Panel
        Me.button_close = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.combo_prioridade = New System.Windows.Forms.ComboBox
        Me.label_prioridade = New System.Windows.Forms.Label
        Me.tab_main.SuspendLayout()
        Me.tab_principal.SuspendLayout()
        Me.panel_details.SuspendLayout()
        Me.panel_main.SuspendLayout()
        Me.tab_alerta.SuspendLayout()
        Me.A1Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_operador.SuspendLayout()
        Me.A1Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_tip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_operador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_evento.SuspendLayout()
        Me.A1Panel4.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_evento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_dnpm.SuspendLayout()
        Me.A1Panel5.SuspendLayout()
        CType(Me.list_dnpm_documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_dnpm_condicao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_dnpm_associado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_dnpm_municipio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_dnpm_substancia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_dnpm_titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_cetesb.SuspendLayout()
        Me.A1Panel6.SuspendLayout()
        CType(Me.list_cetesb_mp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_cetesb_evento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_cetesb_documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_cetesb_titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_daee.SuspendLayout()
        Me.A1Panel7.SuspendLayout()
        CType(Me.list_daee_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_daee_evento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_daee_documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_daee_titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_icmbio.SuspendLayout()
        Me.A1Panel8.SuspendLayout()
        CType(Me.list_icmbio_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_icmbio_evento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_icmbio_documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_icmbio_titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_petrobras.SuspendLayout()
        Me.A1Panel9.SuspendLayout()
        CType(Me.list_petrobras_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_petrobras_evento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_petrobras_documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_petrobras_titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_prefeitura.SuspendLayout()
        Me.A1Panel10.SuspendLayout()
        CType(Me.list_prefeitura_info, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_prefeitura_evento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_prefeitura_documento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_prefeitura_titulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_command.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderFormatStyle1
        '
        HeaderStateStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeaderStateStyle4.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle4.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Hot = HeaderStateStyle4
        HeaderStateStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeaderStateStyle5.ForeColor = System.Drawing.Color.Black
        HeaderStateStyle5.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle5.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Normal = HeaderStateStyle5
        HeaderStateStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeaderStateStyle6.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle6.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Pressed = HeaderStateStyle6
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cancel.png")
        Me.ImageList1.Images.SetKeyName(1, "confirm.png")
        Me.ImageList1.Images.SetKeyName(2, "add2.png")
        Me.ImageList1.Images.SetKeyName(3, "trash.png")
        Me.ImageList1.Images.SetKeyName(4, "clear.png")
        Me.ImageList1.Images.SetKeyName(5, "database_refresh.png")
        Me.ImageList1.Images.SetKeyName(6, "report.png")
        Me.ImageList1.Images.SetKeyName(7, "mapa.png")
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "clear.png")
        Me.ImageList2.Images.SetKeyName(1, "database_refresh.png")
        '
        'tab_main
        '
        Me.tab_main.Controls.Add(Me.tab_principal)
        Me.tab_main.Controls.Add(Me.tab_alerta)
        Me.tab_main.Controls.Add(Me.tab_operador)
        Me.tab_main.Controls.Add(Me.tab_evento)
        Me.tab_main.Controls.Add(Me.tab_dnpm)
        Me.tab_main.Controls.Add(Me.tab_cetesb)
        Me.tab_main.Controls.Add(Me.tab_daee)
        Me.tab_main.Controls.Add(Me.tab_icmbio)
        Me.tab_main.Controls.Add(Me.tab_petrobras)
        Me.tab_main.Controls.Add(Me.tab_prefeitura)
        Me.tab_main.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_main.Location = New System.Drawing.Point(12, 12)
        Me.tab_main.Name = "tab_main"
        Me.tab_main.SelectedIndex = 0
        Me.tab_main.Size = New System.Drawing.Size(918, 320)
        Me.tab_main.TabIndex = 14
        '
        'tab_principal
        '
        Me.tab_principal.AutoScroll = True
        Me.tab_principal.BackColor = System.Drawing.Color.Transparent
        Me.tab_principal.Controls.Add(Me.panel_details)
        Me.tab_principal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_principal.Location = New System.Drawing.Point(4, 22)
        Me.tab_principal.Name = "tab_principal"
        Me.tab_principal.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_principal.Size = New System.Drawing.Size(910, 294)
        Me.tab_principal.TabIndex = 0
        Me.tab_principal.Text = "Dados Principais"
        Me.tab_principal.UseVisualStyleBackColor = True
        '
        'panel_details
        '
        Me.panel_details.BorderColor = System.Drawing.Color.Silver
        Me.panel_details.Controls.Add(Me.combo_prioridade)
        Me.panel_details.Controls.Add(Me.label_prioridade)
        Me.panel_details.Controls.Add(Me.button_mapa)
        Me.panel_details.Controls.Add(Me.panel_main)
        Me.panel_details.Controls.Add(Me.button_report)
        Me.panel_details.Controls.Add(Me.button_del)
        Me.panel_details.Controls.Add(Me.combo_titular)
        Me.panel_details.Controls.Add(Me.label_num)
        Me.panel_details.Controls.Add(Me.button_confirm)
        Me.panel_details.Controls.Add(Me.text_num)
        Me.panel_details.Controls.Add(Me.link_processo)
        Me.panel_details.Controls.Add(Me.combo_uf)
        Me.panel_details.Controls.Add(Me.label_uf)
        Me.panel_details.Controls.Add(Me.text_link)
        Me.panel_details.Controls.Add(Me.label_link)
        Me.panel_details.Controls.Add(Me.label_id)
        Me.panel_details.Controls.Add(Me.text_id)
        Me.panel_details.Controls.Add(Me.text_uso)
        Me.panel_details.Controls.Add(Me.label_uso)
        Me.panel_details.Controls.Add(Me.text_area)
        Me.panel_details.Controls.Add(Me.label_area)
        Me.panel_details.Controls.Add(Me.text_substancia)
        Me.panel_details.Controls.Add(Me.label_substancia)
        Me.panel_details.Controls.Add(Me.label_ultimo_evento)
        Me.panel_details.Controls.Add(Me.text_ultimo_evento)
        Me.panel_details.Controls.Add(Me.combo_fase)
        Me.panel_details.Controls.Add(Me.text_ano)
        Me.panel_details.Controls.Add(Me.label_fase)
        Me.panel_details.Controls.Add(Me.label_ano)
        Me.panel_details.Controls.Add(Me.label_titular)
        Me.panel_details.Controls.Add(Me.label_name)
        Me.panel_details.Controls.Add(Me.text_name)
        Me.panel_details.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.panel_details.GradientStartColor = System.Drawing.Color.White
        Me.panel_details.Image = Nothing
        Me.panel_details.ImageLocation = New System.Drawing.Point(4, 4)
        Me.panel_details.Location = New System.Drawing.Point(-1, 6)
        Me.panel_details.Name = "panel_details"
        Me.panel_details.Size = New System.Drawing.Size(903, 288)
        Me.panel_details.TabIndex = 12
        '
        'button_mapa
        '
        Me.button_mapa.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_mapa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_mapa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_mapa.ImageIndex = 7
        Me.button_mapa.ImageList = Me.ImageList1
        Me.button_mapa.Location = New System.Drawing.Point(772, 246)
        Me.button_mapa.Name = "button_mapa"
        Me.button_mapa.Size = New System.Drawing.Size(85, 27)
        Me.button_mapa.TabIndex = 54
        Me.button_mapa.Text = "Mapa"
        Me.button_mapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_mapa.UseVisualStyleBackColor = True
        '
        'panel_main
        '
        Me.panel_main.BackColor = System.Drawing.Color.LightGray
        Me.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_main.Controls.Add(Me.button_cancel)
        Me.panel_main.Controls.Add(Me.label_progresso)
        Me.panel_main.Controls.Add(Me.pbar_down)
        Me.panel_main.Location = New System.Drawing.Point(140, 77)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(623, 134)
        Me.panel_main.TabIndex = 53
        Me.panel_main.Visible = False
        '
        'button_cancel
        '
        Me.button_cancel.Location = New System.Drawing.Point(475, 93)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(122, 23)
        Me.button_cancel.TabIndex = 29
        Me.button_cancel.Text = "Cancelar"
        Me.button_cancel.UseVisualStyleBackColor = True
        Me.button_cancel.Visible = False
        '
        'label_progresso
        '
        Me.label_progresso.BackColor = System.Drawing.Color.Transparent
        Me.label_progresso.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_progresso.Location = New System.Drawing.Point(21, 25)
        Me.label_progresso.Name = "label_progresso"
        Me.label_progresso.Size = New System.Drawing.Size(492, 20)
        Me.label_progresso.TabIndex = 28
        Me.label_progresso.Text = "status"
        '
        'pbar_down
        '
        Me.pbar_down.Location = New System.Drawing.Point(24, 48)
        Me.pbar_down.Name = "pbar_down"
        Me.pbar_down.Size = New System.Drawing.Size(573, 39)
        Me.pbar_down.TabIndex = 27
        '
        'button_report
        '
        Me.button_report.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_report.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_report.ImageIndex = 6
        Me.button_report.ImageList = Me.ImageList1
        Me.button_report.Location = New System.Drawing.Point(541, 246)
        Me.button_report.Name = "button_report"
        Me.button_report.Size = New System.Drawing.Size(161, 27)
        Me.button_report.TabIndex = 52
        Me.button_report.Text = "Gerar Relatório"
        Me.button_report.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_report.UseVisualStyleBackColor = True
        '
        'button_del
        '
        Me.button_del.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_del.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_del.ImageIndex = 3
        Me.button_del.ImageList = Me.ImageList1
        Me.button_del.Location = New System.Drawing.Point(348, 246)
        Me.button_del.Name = "button_del"
        Me.button_del.Size = New System.Drawing.Size(166, 27)
        Me.button_del.TabIndex = 33
        Me.button_del.Text = "Excluir Processo"
        Me.button_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_del.UseVisualStyleBackColor = True
        '
        'combo_titular
        '
        Me.combo_titular.FormattingEnabled = True
        Me.combo_titular.Location = New System.Drawing.Point(187, 30)
        Me.combo_titular.Name = "combo_titular"
        Me.combo_titular.Size = New System.Drawing.Size(670, 21)
        Me.combo_titular.TabIndex = 20
        '
        'label_num
        '
        Me.label_num.AutoSize = True
        Me.label_num.BackColor = System.Drawing.Color.Transparent
        Me.label_num.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_num.Location = New System.Drawing.Point(411, 11)
        Me.label_num.Name = "label_num"
        Me.label_num.Size = New System.Drawing.Size(52, 13)
        Me.label_num.TabIndex = 51
        Me.label_num.Text = "Número"
        '
        'button_confirm
        '
        Me.button_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm.ImageIndex = 1
        Me.button_confirm.ImageList = Me.ImageList1
        Me.button_confirm.Location = New System.Drawing.Point(187, 246)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(129, 27)
        Me.button_confirm.TabIndex = 32
        Me.button_confirm.Text = "Confirmar"
        Me.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm.UseVisualStyleBackColor = True
        '
        'text_num
        '
        Me.text_num.BackColor = System.Drawing.SystemColors.Info
        Me.text_num.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_num.Location = New System.Drawing.Point(478, 6)
        Me.text_num.MaxLength = 50
        Me.text_num.Name = "text_num"
        Me.text_num.Size = New System.Drawing.Size(171, 21)
        Me.text_num.TabIndex = 19
        '
        'link_processo
        '
        Me.link_processo.AutoSize = True
        Me.link_processo.Location = New System.Drawing.Point(700, 11)
        Me.link_processo.Name = "link_processo"
        Me.link_processo.Size = New System.Drawing.Size(135, 13)
        Me.link_processo.TabIndex = 49
        Me.link_processo.TabStop = True
        Me.link_processo.Text = "Acessar dados na web"
        '
        'combo_uf
        '
        Me.combo_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_uf.FormattingEnabled = True
        Me.combo_uf.Location = New System.Drawing.Point(187, 153)
        Me.combo_uf.Name = "combo_uf"
        Me.combo_uf.Size = New System.Drawing.Size(270, 21)
        Me.combo_uf.TabIndex = 26
        '
        'label_uf
        '
        Me.label_uf.AutoSize = True
        Me.label_uf.BackColor = System.Drawing.Color.Transparent
        Me.label_uf.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_uf.Location = New System.Drawing.Point(135, 156)
        Me.label_uf.Name = "label_uf"
        Me.label_uf.Size = New System.Drawing.Size(21, 13)
        Me.label_uf.TabIndex = 47
        Me.label_uf.Text = "UF"
        '
        'text_link
        '
        Me.text_link.BackColor = System.Drawing.SystemColors.Info
        Me.text_link.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_link.Location = New System.Drawing.Point(187, 177)
        Me.text_link.MaxLength = 100
        Me.text_link.Name = "text_link"
        Me.text_link.Size = New System.Drawing.Size(673, 21)
        Me.text_link.TabIndex = 28
        '
        'label_link
        '
        Me.label_link.AutoSize = True
        Me.label_link.BackColor = System.Drawing.Color.Transparent
        Me.label_link.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_link.Location = New System.Drawing.Point(89, 186)
        Me.label_link.Name = "label_link"
        Me.label_link.Size = New System.Drawing.Size(61, 13)
        Me.label_link.TabIndex = 45
        Me.label_link.Text = "Hyperlink"
        '
        'label_id
        '
        Me.label_id.AutoSize = True
        Me.label_id.BackColor = System.Drawing.Color.Transparent
        Me.label_id.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_id.Location = New System.Drawing.Point(135, 202)
        Me.label_id.Name = "label_id"
        Me.label_id.Size = New System.Drawing.Size(21, 13)
        Me.label_id.TabIndex = 44
        Me.label_id.Text = "ID"
        '
        'text_id
        '
        Me.text_id.BackColor = System.Drawing.SystemColors.Info
        Me.text_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_id.Location = New System.Drawing.Point(187, 202)
        Me.text_id.MaxLength = 300
        Me.text_id.Multiline = True
        Me.text_id.Name = "text_id"
        Me.text_id.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.text_id.Size = New System.Drawing.Size(377, 32)
        Me.text_id.TabIndex = 29
        '
        'text_uso
        '
        Me.text_uso.BackColor = System.Drawing.SystemColors.Info
        Me.text_uso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_uso.Location = New System.Drawing.Point(560, 153)
        Me.text_uso.MaxLength = 30
        Me.text_uso.Name = "text_uso"
        Me.text_uso.Size = New System.Drawing.Size(300, 21)
        Me.text_uso.TabIndex = 27
        '
        'label_uso
        '
        Me.label_uso.AutoSize = True
        Me.label_uso.BackColor = System.Drawing.Color.Transparent
        Me.label_uso.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_uso.Location = New System.Drawing.Point(520, 160)
        Me.label_uso.Name = "label_uso"
        Me.label_uso.Size = New System.Drawing.Size(28, 13)
        Me.label_uso.TabIndex = 41
        Me.label_uso.Text = "Uso"
        '
        'text_area
        '
        Me.text_area.BackColor = System.Drawing.SystemColors.Info
        Me.text_area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_area.Location = New System.Drawing.Point(560, 127)
        Me.text_area.MaxLength = 30
        Me.text_area.Name = "text_area"
        Me.text_area.Size = New System.Drawing.Size(102, 21)
        Me.text_area.TabIndex = 25
        '
        'label_area
        '
        Me.label_area.AutoSize = True
        Me.label_area.BackColor = System.Drawing.Color.Transparent
        Me.label_area.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_area.Location = New System.Drawing.Point(479, 134)
        Me.label_area.Name = "label_area"
        Me.label_area.Size = New System.Drawing.Size(62, 13)
        Me.label_area.TabIndex = 39
        Me.label_area.Text = "Área (ha)"
        '
        'text_substancia
        '
        Me.text_substancia.BackColor = System.Drawing.SystemColors.Info
        Me.text_substancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_substancia.Location = New System.Drawing.Point(187, 127)
        Me.text_substancia.MaxLength = 100
        Me.text_substancia.Name = "text_substancia"
        Me.text_substancia.Size = New System.Drawing.Size(270, 21)
        Me.text_substancia.TabIndex = 24
        '
        'label_substancia
        '
        Me.label_substancia.AutoSize = True
        Me.label_substancia.BackColor = System.Drawing.Color.Transparent
        Me.label_substancia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_substancia.Location = New System.Drawing.Point(79, 134)
        Me.label_substancia.Name = "label_substancia"
        Me.label_substancia.Size = New System.Drawing.Size(69, 13)
        Me.label_substancia.TabIndex = 37
        Me.label_substancia.Text = "Substância"
        '
        'label_ultimo_evento
        '
        Me.label_ultimo_evento.AutoSize = True
        Me.label_ultimo_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_ultimo_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ultimo_evento.Location = New System.Drawing.Point(59, 81)
        Me.label_ultimo_evento.Name = "label_ultimo_evento"
        Me.label_ultimo_evento.Size = New System.Drawing.Size(86, 13)
        Me.label_ultimo_evento.TabIndex = 36
        Me.label_ultimo_evento.Text = "Último Evento"
        '
        'text_ultimo_evento
        '
        Me.text_ultimo_evento.BackColor = System.Drawing.SystemColors.Info
        Me.text_ultimo_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_ultimo_evento.Enabled = False
        Me.text_ultimo_evento.Location = New System.Drawing.Point(187, 79)
        Me.text_ultimo_evento.MaxLength = 3000
        Me.text_ultimo_evento.Multiline = True
        Me.text_ultimo_evento.Name = "text_ultimo_evento"
        Me.text_ultimo_evento.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.text_ultimo_evento.Size = New System.Drawing.Size(673, 46)
        Me.text_ultimo_evento.TabIndex = 23
        '
        'combo_fase
        '
        Me.combo_fase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_fase.FormattingEnabled = True
        Me.combo_fase.Location = New System.Drawing.Point(369, 54)
        Me.combo_fase.Name = "combo_fase"
        Me.combo_fase.Size = New System.Drawing.Size(315, 21)
        Me.combo_fase.TabIndex = 22
        '
        'text_ano
        '
        Me.text_ano.BackColor = System.Drawing.SystemColors.Info
        Me.text_ano.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_ano.Location = New System.Drawing.Point(187, 55)
        Me.text_ano.MaxLength = 4
        Me.text_ano.Name = "text_ano"
        Me.text_ano.Size = New System.Drawing.Size(66, 21)
        Me.text_ano.TabIndex = 21
        '
        'label_fase
        '
        Me.label_fase.AutoSize = True
        Me.label_fase.BackColor = System.Drawing.Color.Transparent
        Me.label_fase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fase.Location = New System.Drawing.Point(303, 62)
        Me.label_fase.Name = "label_fase"
        Me.label_fase.Size = New System.Drawing.Size(33, 13)
        Me.label_fase.TabIndex = 32
        Me.label_fase.Text = "Fase"
        '
        'label_ano
        '
        Me.label_ano.AutoSize = True
        Me.label_ano.BackColor = System.Drawing.Color.Transparent
        Me.label_ano.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ano.Location = New System.Drawing.Point(126, 62)
        Me.label_ano.Name = "label_ano"
        Me.label_ano.Size = New System.Drawing.Size(29, 13)
        Me.label_ano.TabIndex = 31
        Me.label_ano.Text = "Ano"
        '
        'label_titular
        '
        Me.label_titular.AutoSize = True
        Me.label_titular.BackColor = System.Drawing.Color.Transparent
        Me.label_titular.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_titular.Location = New System.Drawing.Point(110, 33)
        Me.label_titular.Name = "label_titular"
        Me.label_titular.Size = New System.Drawing.Size(43, 13)
        Me.label_titular.TabIndex = 21
        Me.label_titular.Text = "Titular"
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.BackColor = System.Drawing.Color.Transparent
        Me.label_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(92, 11)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(58, 13)
        Me.label_name.TabIndex = 19
        Me.label_name.Text = "Processo"
        '
        'text_name
        '
        Me.text_name.BackColor = System.Drawing.SystemColors.Info
        Me.text_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_name.Location = New System.Drawing.Point(187, 8)
        Me.text_name.MaxLength = 50
        Me.text_name.Name = "text_name"
        Me.text_name.Size = New System.Drawing.Size(171, 21)
        Me.text_name.TabIndex = 18
        '
        'tab_alerta
        '
        Me.tab_alerta.AutoScroll = True
        Me.tab_alerta.Controls.Add(Me.A1Panel1)
        Me.tab_alerta.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.tab_alerta.Location = New System.Drawing.Point(4, 22)
        Me.tab_alerta.Name = "tab_alerta"
        Me.tab_alerta.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_alerta.Size = New System.Drawing.Size(910, 294)
        Me.tab_alerta.TabIndex = 1
        Me.tab_alerta.Text = "Alertas"
        Me.tab_alerta.UseVisualStyleBackColor = True
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Gray
        Me.A1Panel1.Controls.Add(Me.button_alerta_refresh)
        Me.A1Panel1.Controls.Add(Me.Panel3)
        Me.A1Panel1.Controls.Add(Me.button_alerta_confirm)
        Me.A1Panel1.Controls.Add(Me.label_alerta)
        Me.A1Panel1.Controls.Add(Me.list_alerta)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(3, 3)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.Size = New System.Drawing.Size(902, 288)
        Me.A1Panel1.TabIndex = 0
        '
        'button_alerta_refresh
        '
        Me.button_alerta_refresh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_alerta_refresh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_alerta_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_alerta_refresh.ImageIndex = 5
        Me.button_alerta_refresh.ImageList = Me.ImageList1
        Me.button_alerta_refresh.Location = New System.Drawing.Point(749, 2)
        Me.button_alerta_refresh.Name = "button_alerta_refresh"
        Me.button_alerta_refresh.Size = New System.Drawing.Size(133, 25)
        Me.button_alerta_refresh.TabIndex = 43
        Me.button_alerta_refresh.Text = "Atualizar Lista"
        Me.button_alerta_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_alerta_refresh.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Info
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.label_tip_alerta1)
        Me.Panel3.Controls.Add(Me.label_tip_alerta2)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(437, 187)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(445, 51)
        Me.Panel3.TabIndex = 42
        '
        'label_tip_alerta1
        '
        Me.label_tip_alerta1.AutoSize = True
        Me.label_tip_alerta1.BackColor = System.Drawing.Color.Transparent
        Me.label_tip_alerta1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip_alerta1.Location = New System.Drawing.Point(78, 3)
        Me.label_tip_alerta1.Name = "label_tip_alerta1"
        Me.label_tip_alerta1.Size = New System.Drawing.Size(40, 16)
        Me.label_tip_alerta1.TabIndex = 23
        Me.label_tip_alerta1.Text = "Dica"
        '
        'label_tip_alerta2
        '
        Me.label_tip_alerta2.BackColor = System.Drawing.Color.Transparent
        Me.label_tip_alerta2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip_alerta2.Location = New System.Drawing.Point(80, 19)
        Me.label_tip_alerta2.Name = "label_tip_alerta2"
        Me.label_tip_alerta2.Size = New System.Drawing.Size(364, 23)
        Me.label_tip_alerta2.TabIndex = 22
        Me.label_tip_alerta2.Text = "Para editar, dê duplo clique na lista sobre o alerta desejado."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 35)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'button_alerta_confirm
        '
        Me.button_alerta_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_alerta_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_alerta_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_alerta_confirm.ImageIndex = 1
        Me.button_alerta_confirm.ImageList = Me.ImageList1
        Me.button_alerta_confirm.Location = New System.Drawing.Point(9, 187)
        Me.button_alerta_confirm.Name = "button_alerta_confirm"
        Me.button_alerta_confirm.Size = New System.Drawing.Size(190, 27)
        Me.button_alerta_confirm.TabIndex = 33
        Me.button_alerta_confirm.Text = "Aplicar Alterações"
        Me.button_alerta_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_alerta_confirm.UseVisualStyleBackColor = True
        '
        'label_alerta
        '
        Me.label_alerta.BackColor = System.Drawing.Color.Transparent
        Me.label_alerta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_alerta.Location = New System.Drawing.Point(14, 11)
        Me.label_alerta.Name = "label_alerta"
        Me.label_alerta.Size = New System.Drawing.Size(659, 17)
        Me.label_alerta.TabIndex = 21
        Me.label_alerta.Text = "Selecione os alertas que deseja associar ao processo:"
        '
        'list_alerta
        '
        Me.list_alerta.AllColumns.Add(Me.column_alerta_name)
        Me.list_alerta.AllColumns.Add(Me.column_alerta_fase)
        Me.list_alerta.AllColumns.Add(Me.column_alerta_evento)
        Me.list_alerta.AllColumns.Add(Me.column_alerta_status)
        Me.list_alerta.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_alerta.BackColor = System.Drawing.Color.White
        Me.list_alerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_alerta.CheckBoxes = True
        Me.list_alerta.CheckedAspectName = ""
        Me.list_alerta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_alerta_name, Me.column_alerta_fase, Me.column_alerta_evento, Me.column_alerta_status})
        Me.list_alerta.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_alerta.DataSource = Nothing
        Me.list_alerta.EmptyListMsg = "Não há alertas cadastrados."
        Me.list_alerta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_alerta.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_alerta.FullRowSelect = True
        Me.list_alerta.GridLines = True
        Me.list_alerta.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_alerta.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_alerta.HeaderUsesThemes = False
        Me.list_alerta.HeaderWordWrap = True
        Me.list_alerta.Location = New System.Drawing.Point(9, 28)
        Me.list_alerta.Name = "list_alerta"
        Me.list_alerta.RowHeight = 15
        Me.list_alerta.ShowGroups = False
        Me.list_alerta.ShowImagesOnSubItems = True
        Me.list_alerta.Size = New System.Drawing.Size(872, 153)
        Me.list_alerta.TabIndex = 1
        Me.list_alerta.UseAlternatingBackColors = True
        Me.list_alerta.UseCompatibleStateImageBehavior = False
        Me.list_alerta.UseFiltering = True
        Me.list_alerta.UseTranslucentSelection = True
        Me.list_alerta.View = System.Windows.Forms.View.Details
        '
        'column_alerta_name
        '
        Me.column_alerta_name.AspectName = "ALER_nm_alerta"
        Me.column_alerta_name.CheckBoxes = True
        Me.column_alerta_name.FillsFreeSpace = True
        Me.column_alerta_name.Hideable = False
        Me.column_alerta_name.IsEditable = False
        Me.column_alerta_name.Text = "Alerta"
        '
        'column_alerta_fase
        '
        Me.column_alerta_fase.AspectName = "ALER_ds_muda_fase"
        Me.column_alerta_fase.Text = "Mudança Fase"
        Me.column_alerta_fase.Width = 80
        Me.column_alerta_fase.WordWrap = True
        '
        'column_alerta_evento
        '
        Me.column_alerta_evento.AspectName = "ALER_ds_muda_evento"
        Me.column_alerta_evento.Text = "Mudança Evento"
        Me.column_alerta_evento.Width = 80
        Me.column_alerta_evento.WordWrap = True
        '
        'column_alerta_status
        '
        Me.column_alerta_status.AspectName = "ALER_ds_status"
        Me.column_alerta_status.FillsFreeSpace = True
        Me.column_alerta_status.IsEditable = False
        Me.column_alerta_status.Text = "Status"
        '
        'tab_operador
        '
        Me.tab_operador.AutoScroll = True
        Me.tab_operador.Controls.Add(Me.A1Panel3)
        Me.tab_operador.Location = New System.Drawing.Point(4, 22)
        Me.tab_operador.Name = "tab_operador"
        Me.tab_operador.Size = New System.Drawing.Size(910, 294)
        Me.tab_operador.TabIndex = 4
        Me.tab_operador.Text = "Operadores"
        Me.tab_operador.UseVisualStyleBackColor = True
        '
        'A1Panel3
        '
        Me.A1Panel3.BorderColor = System.Drawing.Color.Gray
        Me.A1Panel3.Controls.Add(Me.button_operador_refresh)
        Me.A1Panel3.Controls.Add(Me.Panel1)
        Me.A1Panel3.Controls.Add(Me.button_operador_confirm)
        Me.A1Panel3.Controls.Add(Me.label_operador)
        Me.A1Panel3.Controls.Add(Me.list_operador)
        Me.A1Panel3.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel3.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel3.Image = Nothing
        Me.A1Panel3.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel3.Location = New System.Drawing.Point(3, 3)
        Me.A1Panel3.Name = "A1Panel3"
        Me.A1Panel3.Size = New System.Drawing.Size(902, 288)
        Me.A1Panel3.TabIndex = 38
        '
        'button_operador_refresh
        '
        Me.button_operador_refresh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_operador_refresh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_operador_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_operador_refresh.ImageIndex = 5
        Me.button_operador_refresh.ImageList = Me.ImageList1
        Me.button_operador_refresh.Location = New System.Drawing.Point(749, 2)
        Me.button_operador_refresh.Name = "button_operador_refresh"
        Me.button_operador_refresh.Size = New System.Drawing.Size(133, 25)
        Me.button_operador_refresh.TabIndex = 42
        Me.button_operador_refresh.Text = "Atualizar Lista"
        Me.button_operador_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_operador_refresh.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.label_tip_operador1)
        Me.Panel1.Controls.Add(Me.label_tip_operador2)
        Me.Panel1.Controls.Add(Me.pic_tip)
        Me.Panel1.Location = New System.Drawing.Point(436, 187)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(445, 51)
        Me.Panel1.TabIndex = 41
        '
        'label_tip_operador1
        '
        Me.label_tip_operador1.AutoSize = True
        Me.label_tip_operador1.BackColor = System.Drawing.Color.Transparent
        Me.label_tip_operador1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip_operador1.Location = New System.Drawing.Point(78, 3)
        Me.label_tip_operador1.Name = "label_tip_operador1"
        Me.label_tip_operador1.Size = New System.Drawing.Size(40, 16)
        Me.label_tip_operador1.TabIndex = 23
        Me.label_tip_operador1.Text = "Dica"
        '
        'label_tip_operador2
        '
        Me.label_tip_operador2.BackColor = System.Drawing.Color.Transparent
        Me.label_tip_operador2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip_operador2.Location = New System.Drawing.Point(80, 19)
        Me.label_tip_operador2.Name = "label_tip_operador2"
        Me.label_tip_operador2.Size = New System.Drawing.Size(364, 23)
        Me.label_tip_operador2.TabIndex = 22
        Me.label_tip_operador2.Text = "Para editar, dê duplo clique na lista sobre o operador desejado."
        '
        'pic_tip
        '
        Me.pic_tip.Image = CType(resources.GetObject("pic_tip.Image"), System.Drawing.Image)
        Me.pic_tip.Location = New System.Drawing.Point(7, 7)
        Me.pic_tip.Name = "pic_tip"
        Me.pic_tip.Size = New System.Drawing.Size(40, 35)
        Me.pic_tip.TabIndex = 0
        Me.pic_tip.TabStop = False
        '
        'button_operador_confirm
        '
        Me.button_operador_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_operador_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_operador_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_operador_confirm.ImageIndex = 1
        Me.button_operador_confirm.ImageList = Me.ImageList1
        Me.button_operador_confirm.Location = New System.Drawing.Point(9, 187)
        Me.button_operador_confirm.Name = "button_operador_confirm"
        Me.button_operador_confirm.Size = New System.Drawing.Size(190, 27)
        Me.button_operador_confirm.TabIndex = 40
        Me.button_operador_confirm.Text = "Aplicar Alterações"
        Me.button_operador_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_operador_confirm.UseVisualStyleBackColor = True
        '
        'label_operador
        '
        Me.label_operador.BackColor = System.Drawing.Color.Transparent
        Me.label_operador.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_operador.Location = New System.Drawing.Point(14, 6)
        Me.label_operador.Name = "label_operador"
        Me.label_operador.Size = New System.Drawing.Size(470, 14)
        Me.label_operador.TabIndex = 39
        Me.label_operador.Text = "Selecione os operadores que devem receber alertas do processo:"
        '
        'list_operador
        '
        Me.list_operador.AllColumns.Add(Me.column_operador_code)
        Me.list_operador.AllColumns.Add(Me.column_operador_name)
        Me.list_operador.AllColumns.Add(Me.column_operador_email)
        Me.list_operador.AllColumns.Add(Me.column_operador_flag1)
        Me.list_operador.AllColumns.Add(Me.column_operador_flag2)
        Me.list_operador.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_operador.BackColor = System.Drawing.Color.White
        Me.list_operador.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_operador.CheckBoxes = True
        Me.list_operador.CheckedAspectName = ""
        Me.list_operador.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_operador_code, Me.column_operador_name, Me.column_operador_email, Me.column_operador_flag1, Me.column_operador_flag2})
        Me.list_operador.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_operador.DataSource = Nothing
        Me.list_operador.EmptyListMsg = "Não há operadores cadastrados"
        Me.list_operador.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_operador.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_operador.FullRowSelect = True
        Me.list_operador.GridLines = True
        Me.list_operador.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_operador.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_operador.HeaderUsesThemes = False
        Me.list_operador.HeaderWordWrap = True
        Me.list_operador.Location = New System.Drawing.Point(9, 28)
        Me.list_operador.Name = "list_operador"
        Me.list_operador.RowHeight = 15
        Me.list_operador.ShowGroups = False
        Me.list_operador.Size = New System.Drawing.Size(872, 153)
        Me.list_operador.TabIndex = 38
        Me.list_operador.UseAlternatingBackColors = True
        Me.list_operador.UseCompatibleStateImageBehavior = False
        Me.list_operador.UseFiltering = True
        Me.list_operador.UseTranslucentSelection = True
        Me.list_operador.View = System.Windows.Forms.View.Details
        '
        'column_operador_code
        '
        Me.column_operador_code.AspectName = "OPER_cd_operador"
        Me.column_operador_code.IsEditable = False
        Me.column_operador_code.Text = "Código"
        '
        'column_operador_name
        '
        Me.column_operador_name.AspectName = "OPER_nm_operador"
        Me.column_operador_name.FillsFreeSpace = True
        Me.column_operador_name.Hideable = False
        Me.column_operador_name.IsEditable = False
        Me.column_operador_name.Text = "Nome"
        '
        'column_operador_email
        '
        Me.column_operador_email.AspectName = "OPER_ds_email"
        Me.column_operador_email.FillsFreeSpace = True
        Me.column_operador_email.IsEditable = False
        Me.column_operador_email.Text = "Email"
        '
        'column_operador_flag1
        '
        Me.column_operador_flag1.AspectName = "OPER_ds_alerta"
        Me.column_operador_flag1.IsEditable = False
        Me.column_operador_flag1.Text = "Receber Alertas"
        Me.column_operador_flag1.Width = 100
        '
        'column_operador_flag2
        '
        Me.column_operador_flag2.AspectName = "OPER_ds_alerta_nativo"
        Me.column_operador_flag2.IsEditable = False
        Me.column_operador_flag2.Text = "Receber Alertas Nativos"
        Me.column_operador_flag2.Width = 100
        Me.column_operador_flag2.WordWrap = True
        '
        'tab_evento
        '
        Me.tab_evento.AutoScroll = True
        Me.tab_evento.Controls.Add(Me.A1Panel4)
        Me.tab_evento.Location = New System.Drawing.Point(4, 22)
        Me.tab_evento.Name = "tab_evento"
        Me.tab_evento.Size = New System.Drawing.Size(910, 294)
        Me.tab_evento.TabIndex = 3
        Me.tab_evento.Text = "Histórico de Eventos"
        Me.tab_evento.UseVisualStyleBackColor = True
        '
        'A1Panel4
        '
        Me.A1Panel4.BorderColor = System.Drawing.Color.Gray
        Me.A1Panel4.Controls.Add(Me.button_add_evento)
        Me.A1Panel4.Controls.Add(Me.button_evento_refresh)
        Me.A1Panel4.Controls.Add(Me.Panel4)
        Me.A1Panel4.Controls.Add(Me.button_evento_confirm)
        Me.A1Panel4.Controls.Add(Me.label_evento)
        Me.A1Panel4.Controls.Add(Me.list_evento)
        Me.A1Panel4.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel4.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel4.Image = Nothing
        Me.A1Panel4.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel4.Location = New System.Drawing.Point(3, 3)
        Me.A1Panel4.Name = "A1Panel4"
        Me.A1Panel4.Size = New System.Drawing.Size(902, 288)
        Me.A1Panel4.TabIndex = 39
        '
        'button_add_evento
        '
        Me.button_add_evento.AutoSize = True
        Me.button_add_evento.Location = New System.Drawing.Point(14, 222)
        Me.button_add_evento.Name = "button_add_evento"
        Me.button_add_evento.Size = New System.Drawing.Size(103, 13)
        Me.button_add_evento.TabIndex = 43
        Me.button_add_evento.TabStop = True
        Me.button_add_evento.Text = "Adicionar Evento"
        '
        'button_evento_refresh
        '
        Me.button_evento_refresh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_evento_refresh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_evento_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_evento_refresh.ImageIndex = 5
        Me.button_evento_refresh.ImageList = Me.ImageList1
        Me.button_evento_refresh.Location = New System.Drawing.Point(749, 2)
        Me.button_evento_refresh.Name = "button_evento_refresh"
        Me.button_evento_refresh.Size = New System.Drawing.Size(133, 25)
        Me.button_evento_refresh.TabIndex = 42
        Me.button_evento_refresh.Text = "Atualizar Lista"
        Me.button_evento_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_evento_refresh.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Info
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.label_evento_tip1)
        Me.Panel4.Controls.Add(Me.label_evento_tip2)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(436, 225)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(445, 51)
        Me.Panel4.TabIndex = 41
        '
        'label_evento_tip1
        '
        Me.label_evento_tip1.AutoSize = True
        Me.label_evento_tip1.BackColor = System.Drawing.Color.Transparent
        Me.label_evento_tip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_evento_tip1.Location = New System.Drawing.Point(78, 3)
        Me.label_evento_tip1.Name = "label_evento_tip1"
        Me.label_evento_tip1.Size = New System.Drawing.Size(40, 16)
        Me.label_evento_tip1.TabIndex = 23
        Me.label_evento_tip1.Text = "Dica"
        '
        'label_evento_tip2
        '
        Me.label_evento_tip2.BackColor = System.Drawing.Color.Transparent
        Me.label_evento_tip2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_evento_tip2.Location = New System.Drawing.Point(80, 19)
        Me.label_evento_tip2.Name = "label_evento_tip2"
        Me.label_evento_tip2.Size = New System.Drawing.Size(364, 30)
        Me.label_evento_tip2.TabIndex = 22
        Me.label_evento_tip2.Text = "Passe o mouse sobre a coluna DESCRIÇÃO para ver a descrição completo do evento"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(7, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 35)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'button_evento_confirm
        '
        Me.button_evento_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_evento_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_evento_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_evento_confirm.ImageIndex = 1
        Me.button_evento_confirm.ImageList = Me.ImageList1
        Me.button_evento_confirm.Location = New System.Drawing.Point(239, 224)
        Me.button_evento_confirm.Name = "button_evento_confirm"
        Me.button_evento_confirm.Size = New System.Drawing.Size(190, 27)
        Me.button_evento_confirm.TabIndex = 40
        Me.button_evento_confirm.Text = "Aplicar Alterações"
        Me.button_evento_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_evento_confirm.UseVisualStyleBackColor = True
        Me.button_evento_confirm.Visible = False
        '
        'label_evento
        '
        Me.label_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_evento.Location = New System.Drawing.Point(14, 6)
        Me.label_evento.Name = "label_evento"
        Me.label_evento.Size = New System.Drawing.Size(470, 14)
        Me.label_evento.TabIndex = 39
        Me.label_evento.Text = "Histórico de Eventos ocorridos durante o processo:"
        '
        'list_evento
        '
        Me.list_evento.AllColumns.Add(Me.column_evento_code)
        Me.list_evento.AllColumns.Add(Me.column_evento_desc)
        Me.list_evento.AllColumns.Add(Me.column_evento_date)
        Me.list_evento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_evento.BackColor = System.Drawing.Color.White
        Me.list_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_evento.CheckedAspectName = ""
        Me.list_evento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_evento_code, Me.column_evento_desc, Me.column_evento_date})
        Me.list_evento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_evento.DataSource = Nothing
        Me.list_evento.EmptyListMsg = "Nenhum evento encontrado"
        Me.list_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_evento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_evento.FullRowSelect = True
        Me.list_evento.GridLines = True
        Me.list_evento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_evento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_evento.HeaderUsesThemes = False
        Me.list_evento.HeaderWordWrap = True
        Me.list_evento.Location = New System.Drawing.Point(9, 28)
        Me.list_evento.Name = "list_evento"
        Me.list_evento.RowHeight = 50
        Me.list_evento.ShowGroups = False
        Me.list_evento.Size = New System.Drawing.Size(872, 191)
        Me.list_evento.TabIndex = 38
        Me.list_evento.UseAlternatingBackColors = True
        Me.list_evento.UseCompatibleStateImageBehavior = False
        Me.list_evento.UseFiltering = True
        Me.list_evento.UseTranslucentSelection = True
        Me.list_evento.View = System.Windows.Forms.View.Details
        '
        'column_evento_code
        '
        Me.column_evento_code.AspectName = "PREV_cd_evento"
        Me.column_evento_code.IsEditable = False
        Me.column_evento_code.Text = "ID"
        '
        'column_evento_desc
        '
        Me.column_evento_desc.AspectName = "PREV_ds_evento"
        Me.column_evento_desc.Hideable = False
        Me.column_evento_desc.IsEditable = False
        Me.column_evento_desc.Text = "Descrição"
        Me.column_evento_desc.Width = 550
        Me.column_evento_desc.WordWrap = True
        '
        'column_evento_date
        '
        Me.column_evento_date.AspectName = "PREV_dt_ocorrencia"
        Me.column_evento_date.AspectToStringFormat = "{0:d}"
        Me.column_evento_date.Hideable = False
        Me.column_evento_date.IsEditable = False
        Me.column_evento_date.Text = "Data Ocorrência"
        Me.column_evento_date.Width = 135
        Me.column_evento_date.WordWrap = True
        '
        'tab_dnpm
        '
        Me.tab_dnpm.AutoScroll = True
        Me.tab_dnpm.Controls.Add(Me.A1Panel5)
        Me.tab_dnpm.Location = New System.Drawing.Point(4, 22)
        Me.tab_dnpm.Name = "tab_dnpm"
        Me.tab_dnpm.Size = New System.Drawing.Size(910, 294)
        Me.tab_dnpm.TabIndex = 5
        Me.tab_dnpm.Text = "DNPM"
        Me.tab_dnpm.UseVisualStyleBackColor = True
        '
        'A1Panel5
        '
        Me.A1Panel5.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel5.Controls.Add(Me.button_dnpm_add_documento)
        Me.A1Panel5.Controls.Add(Me.labl_dnpm_documento)
        Me.A1Panel5.Controls.Add(Me.list_dnpm_documento)
        Me.A1Panel5.Controls.Add(Me.button_dnpm_add_condicao)
        Me.A1Panel5.Controls.Add(Me.label_condicao)
        Me.A1Panel5.Controls.Add(Me.list_dnpm_condicao)
        Me.A1Panel5.Controls.Add(Me.button_dnpm_add_associado)
        Me.A1Panel5.Controls.Add(Me.label_associado)
        Me.A1Panel5.Controls.Add(Me.list_dnpm_associado)
        Me.A1Panel5.Controls.Add(Me.button_dnpm_add_municipio)
        Me.A1Panel5.Controls.Add(Me.label_dnpm_municipio)
        Me.A1Panel5.Controls.Add(Me.list_dnpm_municipio)
        Me.A1Panel5.Controls.Add(Me.button_dnpm_add_substancia)
        Me.A1Panel5.Controls.Add(Me.label_dnpm_substancia)
        Me.A1Panel5.Controls.Add(Me.list_dnpm_substancia)
        Me.A1Panel5.Controls.Add(Me.button_dnpm_add_titulo)
        Me.A1Panel5.Controls.Add(Me.label_dnpm_titulo)
        Me.A1Panel5.Controls.Add(Me.list_dnpm_titulo)
        Me.A1Panel5.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel5.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel5.Image = Nothing
        Me.A1Panel5.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel5.Location = New System.Drawing.Point(2, 3)
        Me.A1Panel5.Name = "A1Panel5"
        Me.A1Panel5.Size = New System.Drawing.Size(905, 528)
        Me.A1Panel5.TabIndex = 13
        '
        'button_dnpm_add_documento
        '
        Me.button_dnpm_add_documento.AutoSize = True
        Me.button_dnpm_add_documento.Location = New System.Drawing.Point(786, 403)
        Me.button_dnpm_add_documento.Name = "button_dnpm_add_documento"
        Me.button_dnpm_add_documento.Size = New System.Drawing.Size(92, 13)
        Me.button_dnpm_add_documento.TabIndex = 39
        Me.button_dnpm_add_documento.TabStop = True
        Me.button_dnpm_add_documento.Text = "Adicionar novo"
        '
        'labl_dnpm_documento
        '
        Me.labl_dnpm_documento.AutoSize = True
        Me.labl_dnpm_documento.BackColor = System.Drawing.Color.Transparent
        Me.labl_dnpm_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labl_dnpm_documento.Location = New System.Drawing.Point(9, 403)
        Me.labl_dnpm_documento.Name = "labl_dnpm_documento"
        Me.labl_dnpm_documento.Size = New System.Drawing.Size(120, 13)
        Me.labl_dnpm_documento.TabIndex = 38
        Me.labl_dnpm_documento.Text = "Outros Documentos"
        '
        'list_dnpm_documento
        '
        Me.list_dnpm_documento.AllColumns.Add(Me.OlvColumn107)
        Me.list_dnpm_documento.AllColumns.Add(Me.OlvColumn108)
        Me.list_dnpm_documento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_dnpm_documento.BackColor = System.Drawing.Color.White
        Me.list_dnpm_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_dnpm_documento.CheckedAspectName = ""
        Me.list_dnpm_documento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn107, Me.OlvColumn108})
        Me.list_dnpm_documento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_dnpm_documento.DataSource = Nothing
        Me.list_dnpm_documento.EmptyListMsg = "Nenhum documento anexado"
        Me.list_dnpm_documento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_documento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_dnpm_documento.FullRowSelect = True
        Me.list_dnpm_documento.GridLines = True
        Me.list_dnpm_documento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_documento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_dnpm_documento.HeaderUsesThemes = False
        Me.list_dnpm_documento.HeaderWordWrap = True
        Me.list_dnpm_documento.Location = New System.Drawing.Point(6, 420)
        Me.list_dnpm_documento.Name = "list_dnpm_documento"
        Me.list_dnpm_documento.RowHeight = 15
        Me.list_dnpm_documento.ShowGroups = False
        Me.list_dnpm_documento.ShowImagesOnSubItems = True
        Me.list_dnpm_documento.Size = New System.Drawing.Size(872, 96)
        Me.list_dnpm_documento.TabIndex = 37
        Me.list_dnpm_documento.UseAlternatingBackColors = True
        Me.list_dnpm_documento.UseCompatibleStateImageBehavior = False
        Me.list_dnpm_documento.UseFiltering = True
        Me.list_dnpm_documento.UseHyperlinks = True
        Me.list_dnpm_documento.UseTranslucentSelection = True
        Me.list_dnpm_documento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn107
        '
        Me.OlvColumn107.AspectName = "PDOC_nm_documento"
        Me.OlvColumn107.Hideable = False
        Me.OlvColumn107.Hyperlink = True
        Me.OlvColumn107.IsEditable = False
        Me.OlvColumn107.Text = "Nome"
        Me.OlvColumn107.Width = 300
        '
        'OlvColumn108
        '
        Me.OlvColumn108.AspectName = "PDOC_ds_documento"
        Me.OlvColumn108.Text = "Descrição"
        Me.OlvColumn108.Width = 600
        '
        'button_dnpm_add_condicao
        '
        Me.button_dnpm_add_condicao.AutoSize = True
        Me.button_dnpm_add_condicao.Location = New System.Drawing.Point(789, 308)
        Me.button_dnpm_add_condicao.Name = "button_dnpm_add_condicao"
        Me.button_dnpm_add_condicao.Size = New System.Drawing.Size(92, 13)
        Me.button_dnpm_add_condicao.TabIndex = 36
        Me.button_dnpm_add_condicao.TabStop = True
        Me.button_dnpm_add_condicao.Text = "Adicionar novo"
        '
        'label_condicao
        '
        Me.label_condicao.AutoSize = True
        Me.label_condicao.BackColor = System.Drawing.Color.Transparent
        Me.label_condicao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_condicao.Location = New System.Drawing.Point(12, 308)
        Me.label_condicao.Name = "label_condicao"
        Me.label_condicao.Size = New System.Drawing.Size(250, 13)
        Me.label_condicao.TabIndex = 35
        Me.label_condicao.Text = "Lista de Condições de propriedade do solo"
        '
        'list_dnpm_condicao
        '
        Me.list_dnpm_condicao.AllColumns.Add(Me.OlvColumn14)
        Me.list_dnpm_condicao.AllColumns.Add(Me.OlvColumn15)
        Me.list_dnpm_condicao.AllColumns.Add(Me.OlvColumn97)
        Me.list_dnpm_condicao.AllColumns.Add(Me.OlvColumn98)
        Me.list_dnpm_condicao.AllColumns.Add(Me.OlvColumn99)
        Me.list_dnpm_condicao.AllColumns.Add(Me.OlvColumn100)
        Me.list_dnpm_condicao.AllColumns.Add(Me.OlvColumn16)
        Me.list_dnpm_condicao.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_dnpm_condicao.BackColor = System.Drawing.Color.White
        Me.list_dnpm_condicao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_dnpm_condicao.CheckedAspectName = ""
        Me.list_dnpm_condicao.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn14, Me.OlvColumn15, Me.OlvColumn97, Me.OlvColumn98, Me.OlvColumn99, Me.OlvColumn100, Me.OlvColumn16})
        Me.list_dnpm_condicao.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_dnpm_condicao.DataSource = Nothing
        Me.list_dnpm_condicao.EmptyListMsg = "Nenhuma condição informada"
        Me.list_dnpm_condicao.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_condicao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_condicao.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_dnpm_condicao.FullRowSelect = True
        Me.list_dnpm_condicao.GridLines = True
        Me.list_dnpm_condicao.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_condicao.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_dnpm_condicao.HeaderUsesThemes = False
        Me.list_dnpm_condicao.HeaderWordWrap = True
        Me.list_dnpm_condicao.Location = New System.Drawing.Point(9, 325)
        Me.list_dnpm_condicao.Name = "list_dnpm_condicao"
        Me.list_dnpm_condicao.RowHeight = 15
        Me.list_dnpm_condicao.ShowGroups = False
        Me.list_dnpm_condicao.ShowImagesOnSubItems = True
        Me.list_dnpm_condicao.Size = New System.Drawing.Size(872, 72)
        Me.list_dnpm_condicao.TabIndex = 34
        Me.list_dnpm_condicao.UseAlternatingBackColors = True
        Me.list_dnpm_condicao.UseCompatibleStateImageBehavior = False
        Me.list_dnpm_condicao.UseFiltering = True
        Me.list_dnpm_condicao.UseHyperlinks = True
        Me.list_dnpm_condicao.UseTranslucentSelection = True
        Me.list_dnpm_condicao.View = System.Windows.Forms.View.Details
        '
        'OlvColumn14
        '
        Me.OlvColumn14.AspectName = "PCON_cd_condicao"
        Me.OlvColumn14.Hideable = False
        Me.OlvColumn14.IsEditable = False
        Me.OlvColumn14.Text = "Id"
        Me.OlvColumn14.Width = 30
        '
        'OlvColumn15
        '
        Me.OlvColumn15.AspectName = "COND_nm_condicao"
        Me.OlvColumn15.Text = "Tipo"
        Me.OlvColumn15.Width = 150
        Me.OlvColumn15.WordWrap = True
        '
        'OlvColumn97
        '
        Me.OlvColumn97.AspectName = "SCON_ds_situacao_condicao"
        Me.OlvColumn97.Text = "Situação"
        Me.OlvColumn97.Width = 130
        '
        'OlvColumn98
        '
        Me.OlvColumn98.AspectName = "PCON_ds_condicao"
        Me.OlvColumn98.Text = "Descrição"
        Me.OlvColumn98.Width = 250
        '
        'OlvColumn99
        '
        Me.OlvColumn99.AspectName = "PCON_dt_ini"
        Me.OlvColumn99.AspectToStringFormat = "{0:d}"
        Me.OlvColumn99.Text = "Data Inicial"
        Me.OlvColumn99.Width = 100
        '
        'OlvColumn100
        '
        Me.OlvColumn100.AspectName = "PCON_dt_fim"
        Me.OlvColumn100.AspectToStringFormat = "{0:d}"
        Me.OlvColumn100.Text = "Data Vencto"
        Me.OlvColumn100.Width = 100
        '
        'OlvColumn16
        '
        Me.OlvColumn16.AspectName = "PCON_ds_nome_documento"
        Me.OlvColumn16.AspectToStringFormat = ""
        Me.OlvColumn16.FillsFreeSpace = True
        Me.OlvColumn16.Hyperlink = True
        Me.OlvColumn16.Text = "Documento Anexo"
        '
        'button_dnpm_add_associado
        '
        Me.button_dnpm_add_associado.AutoSize = True
        Me.button_dnpm_add_associado.Location = New System.Drawing.Point(789, 210)
        Me.button_dnpm_add_associado.Name = "button_dnpm_add_associado"
        Me.button_dnpm_add_associado.Size = New System.Drawing.Size(92, 13)
        Me.button_dnpm_add_associado.TabIndex = 33
        Me.button_dnpm_add_associado.TabStop = True
        Me.button_dnpm_add_associado.Text = "Adicionar novo"
        '
        'label_associado
        '
        Me.label_associado.AutoSize = True
        Me.label_associado.BackColor = System.Drawing.Color.Transparent
        Me.label_associado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_associado.Location = New System.Drawing.Point(453, 213)
        Me.label_associado.Name = "label_associado"
        Me.label_associado.Size = New System.Drawing.Size(179, 13)
        Me.label_associado.TabIndex = 32
        Me.label_associado.Text = "Lista de Processos Associados"
        '
        'list_dnpm_associado
        '
        Me.list_dnpm_associado.AllColumns.Add(Me.OlvColumn10)
        Me.list_dnpm_associado.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_dnpm_associado.BackColor = System.Drawing.Color.White
        Me.list_dnpm_associado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_dnpm_associado.CheckedAspectName = ""
        Me.list_dnpm_associado.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn10})
        Me.list_dnpm_associado.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_dnpm_associado.DataSource = Nothing
        Me.list_dnpm_associado.EmptyListMsg = "Nenhum processo associado"
        Me.list_dnpm_associado.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_associado.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_associado.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_dnpm_associado.FullRowSelect = True
        Me.list_dnpm_associado.GridLines = True
        Me.list_dnpm_associado.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_associado.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_dnpm_associado.HeaderUsesThemes = False
        Me.list_dnpm_associado.HeaderWordWrap = True
        Me.list_dnpm_associado.Location = New System.Drawing.Point(456, 226)
        Me.list_dnpm_associado.Name = "list_dnpm_associado"
        Me.list_dnpm_associado.RowHeight = 15
        Me.list_dnpm_associado.ShowGroups = False
        Me.list_dnpm_associado.ShowImagesOnSubItems = True
        Me.list_dnpm_associado.Size = New System.Drawing.Size(425, 75)
        Me.list_dnpm_associado.TabIndex = 31
        Me.list_dnpm_associado.UseAlternatingBackColors = True
        Me.list_dnpm_associado.UseCompatibleStateImageBehavior = False
        Me.list_dnpm_associado.UseFiltering = True
        Me.list_dnpm_associado.UseTranslucentSelection = True
        Me.list_dnpm_associado.View = System.Windows.Forms.View.Details
        '
        'OlvColumn10
        '
        Me.OlvColumn10.AspectName = "PASO_cd_processo"
        Me.OlvColumn10.FillsFreeSpace = True
        Me.OlvColumn10.Hideable = False
        Me.OlvColumn10.IsEditable = False
        Me.OlvColumn10.Text = "Processo Associado"
        '
        'button_dnpm_add_municipio
        '
        Me.button_dnpm_add_municipio.AutoSize = True
        Me.button_dnpm_add_municipio.Location = New System.Drawing.Point(331, 213)
        Me.button_dnpm_add_municipio.Name = "button_dnpm_add_municipio"
        Me.button_dnpm_add_municipio.Size = New System.Drawing.Size(92, 13)
        Me.button_dnpm_add_municipio.TabIndex = 30
        Me.button_dnpm_add_municipio.TabStop = True
        Me.button_dnpm_add_municipio.Text = "Adicionar novo"
        '
        'label_dnpm_municipio
        '
        Me.label_dnpm_municipio.AutoSize = True
        Me.label_dnpm_municipio.BackColor = System.Drawing.Color.Transparent
        Me.label_dnpm_municipio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_dnpm_municipio.Location = New System.Drawing.Point(7, 213)
        Me.label_dnpm_municipio.Name = "label_dnpm_municipio"
        Me.label_dnpm_municipio.Size = New System.Drawing.Size(113, 13)
        Me.label_dnpm_municipio.TabIndex = 29
        Me.label_dnpm_municipio.Text = "Lista de Municípios"
        '
        'list_dnpm_municipio
        '
        Me.list_dnpm_municipio.AllColumns.Add(Me.OlvColumn9)
        Me.list_dnpm_municipio.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_dnpm_municipio.BackColor = System.Drawing.Color.White
        Me.list_dnpm_municipio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_dnpm_municipio.CheckedAspectName = ""
        Me.list_dnpm_municipio.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn9})
        Me.list_dnpm_municipio.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_dnpm_municipio.DataSource = Nothing
        Me.list_dnpm_municipio.EmptyListMsg = "Nenhum município informado"
        Me.list_dnpm_municipio.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_municipio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_municipio.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_dnpm_municipio.FullRowSelect = True
        Me.list_dnpm_municipio.GridLines = True
        Me.list_dnpm_municipio.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_municipio.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_dnpm_municipio.HeaderUsesThemes = False
        Me.list_dnpm_municipio.HeaderWordWrap = True
        Me.list_dnpm_municipio.Location = New System.Drawing.Point(6, 229)
        Me.list_dnpm_municipio.Name = "list_dnpm_municipio"
        Me.list_dnpm_municipio.RowHeight = 15
        Me.list_dnpm_municipio.ShowGroups = False
        Me.list_dnpm_municipio.ShowImagesOnSubItems = True
        Me.list_dnpm_municipio.Size = New System.Drawing.Size(417, 72)
        Me.list_dnpm_municipio.TabIndex = 28
        Me.list_dnpm_municipio.UseAlternatingBackColors = True
        Me.list_dnpm_municipio.UseCompatibleStateImageBehavior = False
        Me.list_dnpm_municipio.UseFiltering = True
        Me.list_dnpm_municipio.UseTranslucentSelection = True
        Me.list_dnpm_municipio.View = System.Windows.Forms.View.Details
        '
        'OlvColumn9
        '
        Me.OlvColumn9.AspectName = "MUNI_nm_municipio"
        Me.OlvColumn9.FillsFreeSpace = True
        Me.OlvColumn9.Hideable = False
        Me.OlvColumn9.IsEditable = False
        Me.OlvColumn9.Text = "Município"
        '
        'button_dnpm_add_substancia
        '
        Me.button_dnpm_add_substancia.AutoSize = True
        Me.button_dnpm_add_substancia.Location = New System.Drawing.Point(730, 119)
        Me.button_dnpm_add_substancia.Name = "button_dnpm_add_substancia"
        Me.button_dnpm_add_substancia.Size = New System.Drawing.Size(156, 13)
        Me.button_dnpm_add_substancia.TabIndex = 27
        Me.button_dnpm_add_substancia.TabStop = True
        Me.button_dnpm_add_substancia.Text = "Adicionar nova substância"
        '
        'label_dnpm_substancia
        '
        Me.label_dnpm_substancia.AutoSize = True
        Me.label_dnpm_substancia.BackColor = System.Drawing.Color.Transparent
        Me.label_dnpm_substancia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_dnpm_substancia.Location = New System.Drawing.Point(13, 118)
        Me.label_dnpm_substancia.Name = "label_dnpm_substancia"
        Me.label_dnpm_substancia.Size = New System.Drawing.Size(189, 13)
        Me.label_dnpm_substancia.TabIndex = 26
        Me.label_dnpm_substancia.Text = "Lista de substâncias informadas"
        '
        'list_dnpm_substancia
        '
        Me.list_dnpm_substancia.AllColumns.Add(Me.OlvColumn7)
        Me.list_dnpm_substancia.AllColumns.Add(Me.OlvColumn8)
        Me.list_dnpm_substancia.AllColumns.Add(Me.OlvColumn11)
        Me.list_dnpm_substancia.AllColumns.Add(Me.OlvColumn12)
        Me.list_dnpm_substancia.AllColumns.Add(Me.OlvColumn13)
        Me.list_dnpm_substancia.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_dnpm_substancia.BackColor = System.Drawing.Color.White
        Me.list_dnpm_substancia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_dnpm_substancia.CheckedAspectName = ""
        Me.list_dnpm_substancia.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn7, Me.OlvColumn8, Me.OlvColumn11, Me.OlvColumn12, Me.OlvColumn13})
        Me.list_dnpm_substancia.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_dnpm_substancia.DataSource = Nothing
        Me.list_dnpm_substancia.EmptyListMsg = "Nenhuma substância informada"
        Me.list_dnpm_substancia.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_substancia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_substancia.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_dnpm_substancia.FullRowSelect = True
        Me.list_dnpm_substancia.GridLines = True
        Me.list_dnpm_substancia.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_substancia.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_dnpm_substancia.HeaderUsesThemes = False
        Me.list_dnpm_substancia.HeaderWordWrap = True
        Me.list_dnpm_substancia.Location = New System.Drawing.Point(10, 135)
        Me.list_dnpm_substancia.Name = "list_dnpm_substancia"
        Me.list_dnpm_substancia.RowHeight = 15
        Me.list_dnpm_substancia.ShowGroups = False
        Me.list_dnpm_substancia.ShowImagesOnSubItems = True
        Me.list_dnpm_substancia.Size = New System.Drawing.Size(872, 72)
        Me.list_dnpm_substancia.TabIndex = 25
        Me.list_dnpm_substancia.UseAlternatingBackColors = True
        Me.list_dnpm_substancia.UseCompatibleStateImageBehavior = False
        Me.list_dnpm_substancia.UseFiltering = True
        Me.list_dnpm_substancia.UseTranslucentSelection = True
        Me.list_dnpm_substancia.View = System.Windows.Forms.View.Details
        '
        'OlvColumn7
        '
        Me.OlvColumn7.AspectName = "SUBS_nm_substancia"
        Me.OlvColumn7.Hideable = False
        Me.OlvColumn7.IsEditable = False
        Me.OlvColumn7.Text = "Substância"
        Me.OlvColumn7.Width = 200
        '
        'OlvColumn8
        '
        Me.OlvColumn8.AspectName = "TUSO_nm_uso"
        Me.OlvColumn8.Text = "Tipo de Uso"
        Me.OlvColumn8.Width = 200
        Me.OlvColumn8.WordWrap = True
        '
        'OlvColumn11
        '
        Me.OlvColumn11.AspectName = "PSUB_dt_inicio"
        Me.OlvColumn11.AspectToStringFormat = "{0:d}"
        Me.OlvColumn11.Text = "Início"
        Me.OlvColumn11.Width = 100
        Me.OlvColumn11.WordWrap = True
        '
        'OlvColumn12
        '
        Me.OlvColumn12.AspectName = "PSUB_dt_fim"
        Me.OlvColumn12.AspectToStringFormat = "{0:d}"
        Me.OlvColumn12.Text = "Final"
        Me.OlvColumn12.Width = 100
        Me.OlvColumn12.WordWrap = True
        '
        'OlvColumn13
        '
        Me.OlvColumn13.AspectName = "PSUB_ds_motivo"
        Me.OlvColumn13.FillsFreeSpace = True
        Me.OlvColumn13.Text = "Motivo Encerramento"
        '
        'button_dnpm_add_titulo
        '
        Me.button_dnpm_add_titulo.AutoSize = True
        Me.button_dnpm_add_titulo.Location = New System.Drawing.Point(760, 7)
        Me.button_dnpm_add_titulo.Name = "button_dnpm_add_titulo"
        Me.button_dnpm_add_titulo.Size = New System.Drawing.Size(124, 13)
        Me.button_dnpm_add_titulo.TabIndex = 24
        Me.button_dnpm_add_titulo.TabStop = True
        Me.button_dnpm_add_titulo.Text = "Adicionar novo título"
        '
        'label_dnpm_titulo
        '
        Me.label_dnpm_titulo.AutoSize = True
        Me.label_dnpm_titulo.BackColor = System.Drawing.Color.Transparent
        Me.label_dnpm_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_dnpm_titulo.Location = New System.Drawing.Point(13, 6)
        Me.label_dnpm_titulo.Name = "label_dnpm_titulo"
        Me.label_dnpm_titulo.Size = New System.Drawing.Size(160, 13)
        Me.label_dnpm_titulo.TabIndex = 23
        Me.label_dnpm_titulo.Text = "Lista de Títulos informados"
        '
        'list_dnpm_titulo
        '
        Me.list_dnpm_titulo.AllColumns.Add(Me.OlvColumn1)
        Me.list_dnpm_titulo.AllColumns.Add(Me.OlvColumn2)
        Me.list_dnpm_titulo.AllColumns.Add(Me.OlvColumn3)
        Me.list_dnpm_titulo.AllColumns.Add(Me.OlvColumn4)
        Me.list_dnpm_titulo.AllColumns.Add(Me.OlvColumn5)
        Me.list_dnpm_titulo.AllColumns.Add(Me.OlvColumn6)
        Me.list_dnpm_titulo.AllColumns.Add(Me.OlvColumn106)
        Me.list_dnpm_titulo.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_dnpm_titulo.BackColor = System.Drawing.Color.White
        Me.list_dnpm_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_dnpm_titulo.CheckedAspectName = ""
        Me.list_dnpm_titulo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn1, Me.OlvColumn2, Me.OlvColumn3, Me.OlvColumn4, Me.OlvColumn5, Me.OlvColumn6, Me.OlvColumn106})
        Me.list_dnpm_titulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_dnpm_titulo.DataSource = Nothing
        Me.list_dnpm_titulo.EmptyListMsg = "Nenhm título registrado"
        Me.list_dnpm_titulo.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!)
        Me.list_dnpm_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_titulo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_dnpm_titulo.FullRowSelect = True
        Me.list_dnpm_titulo.GridLines = True
        Me.list_dnpm_titulo.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dnpm_titulo.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_dnpm_titulo.HeaderUsesThemes = False
        Me.list_dnpm_titulo.HeaderWordWrap = True
        Me.list_dnpm_titulo.Location = New System.Drawing.Point(10, 23)
        Me.list_dnpm_titulo.Name = "list_dnpm_titulo"
        Me.list_dnpm_titulo.RowHeight = 15
        Me.list_dnpm_titulo.ShowGroups = False
        Me.list_dnpm_titulo.ShowImagesOnSubItems = True
        Me.list_dnpm_titulo.Size = New System.Drawing.Size(872, 89)
        Me.list_dnpm_titulo.TabIndex = 22
        Me.list_dnpm_titulo.UseAlternatingBackColors = True
        Me.list_dnpm_titulo.UseCompatibleStateImageBehavior = False
        Me.list_dnpm_titulo.UseFiltering = True
        Me.list_dnpm_titulo.UseHyperlinks = True
        Me.list_dnpm_titulo.UseTranslucentSelection = True
        Me.list_dnpm_titulo.View = System.Windows.Forms.View.Details
        '
        'OlvColumn1
        '
        Me.OlvColumn1.AspectName = "PTIT_nm_titulo"
        Me.OlvColumn1.Hideable = False
        Me.OlvColumn1.IsEditable = False
        Me.OlvColumn1.Text = "Número"
        Me.OlvColumn1.Width = 80
        '
        'OlvColumn2
        '
        Me.OlvColumn2.AspectName = "PTIT_ds_titulo"
        Me.OlvColumn2.FillsFreeSpace = True
        Me.OlvColumn2.Text = "Descrição"
        Me.OlvColumn2.Width = 240
        Me.OlvColumn2.WordWrap = True
        '
        'OlvColumn3
        '
        Me.OlvColumn3.AspectName = "TTIT_ds_tipo_titulo"
        Me.OlvColumn3.Text = "Tipo"
        Me.OlvColumn3.Width = 130
        Me.OlvColumn3.WordWrap = True
        '
        'OlvColumn4
        '
        Me.OlvColumn4.AspectName = "SITU_ds_situacao_titulo"
        Me.OlvColumn4.IsEditable = False
        Me.OlvColumn4.Text = "Situação"
        Me.OlvColumn4.Width = 130
        '
        'OlvColumn5
        '
        Me.OlvColumn5.AspectName = "PTIT_dt_publicacao"
        Me.OlvColumn5.AspectToStringFormat = "{0:d}"
        Me.OlvColumn5.Text = "Data Publicação"
        Me.OlvColumn5.Width = 100
        Me.OlvColumn5.WordWrap = True
        '
        'OlvColumn6
        '
        Me.OlvColumn6.AspectName = "PTIT_dt_vencimento"
        Me.OlvColumn6.AspectToStringFormat = "{0:d}"
        Me.OlvColumn6.Text = "Data Vencimento"
        Me.OlvColumn6.Width = 100
        Me.OlvColumn6.WordWrap = True
        '
        'OlvColumn106
        '
        Me.OlvColumn106.AspectName = "PTIT_ds_nome_documento"
        Me.OlvColumn106.FillsFreeSpace = True
        Me.OlvColumn106.Hyperlink = True
        Me.OlvColumn106.Text = "Doc.Principal"
        '
        'tab_cetesb
        '
        Me.tab_cetesb.AutoScroll = True
        Me.tab_cetesb.Controls.Add(Me.A1Panel6)
        Me.tab_cetesb.Location = New System.Drawing.Point(4, 22)
        Me.tab_cetesb.Name = "tab_cetesb"
        Me.tab_cetesb.Size = New System.Drawing.Size(910, 294)
        Me.tab_cetesb.TabIndex = 6
        Me.tab_cetesb.Text = "CETESB"
        Me.tab_cetesb.UseVisualStyleBackColor = True
        '
        'A1Panel6
        '
        Me.A1Panel6.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel6.Controls.Add(Me.button_cetesb_add_mp)
        Me.A1Panel6.Controls.Add(Me.label_cetesb_mp)
        Me.A1Panel6.Controls.Add(Me.list_cetesb_mp)
        Me.A1Panel6.Controls.Add(Me.button_cetesb_confirm)
        Me.A1Panel6.Controls.Add(Me.text_cetesb_atividade)
        Me.A1Panel6.Controls.Add(Me.text_cetesb_cadastro)
        Me.A1Panel6.Controls.Add(Me.label_cetesb_atividade)
        Me.A1Panel6.Controls.Add(Me.label_cetesb_cadastro)
        Me.A1Panel6.Controls.Add(Me.button_cetesb_add_evento)
        Me.A1Panel6.Controls.Add(Me.label_cetesb_evento)
        Me.A1Panel6.Controls.Add(Me.list_cetesb_evento)
        Me.A1Panel6.Controls.Add(Me.button_cetesb_add_documento)
        Me.A1Panel6.Controls.Add(Me.label_cetesb_documento)
        Me.A1Panel6.Controls.Add(Me.list_cetesb_documento)
        Me.A1Panel6.Controls.Add(Me.button_cetesb_add_titulo)
        Me.A1Panel6.Controls.Add(Me.label_cetesb_titulo)
        Me.A1Panel6.Controls.Add(Me.list_cetesb_titulo)
        Me.A1Panel6.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel6.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel6.Image = Nothing
        Me.A1Panel6.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel6.Location = New System.Drawing.Point(2, 3)
        Me.A1Panel6.Name = "A1Panel6"
        Me.A1Panel6.Size = New System.Drawing.Size(905, 522)
        Me.A1Panel6.TabIndex = 14
        '
        'button_cetesb_add_mp
        '
        Me.button_cetesb_add_mp.AutoSize = True
        Me.button_cetesb_add_mp.Location = New System.Drawing.Point(738, 134)
        Me.button_cetesb_add_mp.Name = "button_cetesb_add_mp"
        Me.button_cetesb_add_mp.Size = New System.Drawing.Size(144, 13)
        Me.button_cetesb_add_mp.TabIndex = 47
        Me.button_cetesb_add_mp.TabStop = True
        Me.button_cetesb_add_mp.Text = "Adicionar Matéria-Prima"
        '
        'label_cetesb_mp
        '
        Me.label_cetesb_mp.AutoSize = True
        Me.label_cetesb_mp.BackColor = System.Drawing.Color.Transparent
        Me.label_cetesb_mp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cetesb_mp.Location = New System.Drawing.Point(13, 134)
        Me.label_cetesb_mp.Name = "label_cetesb_mp"
        Me.label_cetesb_mp.Size = New System.Drawing.Size(164, 13)
        Me.label_cetesb_mp.TabIndex = 46
        Me.label_cetesb_mp.Text = "Matérias-Primas x Produtos"
        '
        'list_cetesb_mp
        '
        Me.list_cetesb_mp.AllColumns.Add(Me.OlvColumn101)
        Me.list_cetesb_mp.AllColumns.Add(Me.OlvColumn103)
        Me.list_cetesb_mp.AllColumns.Add(Me.OlvColumn104)
        Me.list_cetesb_mp.AllColumns.Add(Me.OlvColumn105)
        Me.list_cetesb_mp.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_cetesb_mp.BackColor = System.Drawing.Color.White
        Me.list_cetesb_mp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_cetesb_mp.CheckedAspectName = ""
        Me.list_cetesb_mp.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn101, Me.OlvColumn103, Me.OlvColumn104, Me.OlvColumn105})
        Me.list_cetesb_mp.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_cetesb_mp.DataSource = Nothing
        Me.list_cetesb_mp.EmptyListMsg = "Nenhuma Matéria-Prima informada"
        Me.list_cetesb_mp.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_mp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_mp.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_cetesb_mp.FullRowSelect = True
        Me.list_cetesb_mp.GridLines = True
        Me.list_cetesb_mp.GroupWithItemCountFormat = "{0} ({1} produtos)"
        Me.list_cetesb_mp.GroupWithItemCountSingularFormat = "{0} ({1} produto)"
        Me.list_cetesb_mp.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_mp.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_cetesb_mp.HeaderUsesThemes = False
        Me.list_cetesb_mp.HeaderWordWrap = True
        Me.list_cetesb_mp.Location = New System.Drawing.Point(10, 151)
        Me.list_cetesb_mp.Name = "list_cetesb_mp"
        Me.list_cetesb_mp.RowHeight = 15
        Me.list_cetesb_mp.ShowImagesOnSubItems = True
        Me.list_cetesb_mp.ShowItemCountOnGroups = True
        Me.list_cetesb_mp.Size = New System.Drawing.Size(872, 149)
        Me.list_cetesb_mp.TabIndex = 45
        Me.list_cetesb_mp.UseAlternatingBackColors = True
        Me.list_cetesb_mp.UseCompatibleStateImageBehavior = False
        Me.list_cetesb_mp.UseFiltering = True
        Me.list_cetesb_mp.UseHyperlinks = True
        Me.list_cetesb_mp.UseTranslucentSelection = True
        Me.list_cetesb_mp.View = System.Windows.Forms.View.Details
        '
        'OlvColumn101
        '
        Me.OlvColumn101.AspectName = "PRMP_ds_mprima"
        Me.OlvColumn101.Hideable = False
        Me.OlvColumn101.IsEditable = False
        Me.OlvColumn101.IsVisible = False
        Me.OlvColumn101.Text = "Matéria-Prima"
        Me.OlvColumn101.Width = 300
        '
        'OlvColumn103
        '
        Me.OlvColumn103.AspectName = "PROD_nm_produto"
        Me.OlvColumn103.Text = "Produto"
        Me.OlvColumn103.Width = 270
        '
        'OlvColumn104
        '
        Me.OlvColumn104.AspectName = "PRPD_qt_produto"
        Me.OlvColumn104.Text = "Volume"
        Me.OlvColumn104.Width = 100
        '
        'OlvColumn105
        '
        Me.OlvColumn105.AspectName = "UPRD_nm_uso"
        Me.OlvColumn105.Text = "Tipo de Uso"
        Me.OlvColumn105.Width = 130
        '
        'button_cetesb_confirm
        '
        Me.button_cetesb_confirm.AutoSize = True
        Me.button_cetesb_confirm.Location = New System.Drawing.Point(829, 12)
        Me.button_cetesb_confirm.Name = "button_cetesb_confirm"
        Me.button_cetesb_confirm.Size = New System.Drawing.Size(44, 13)
        Me.button_cetesb_confirm.TabIndex = 44
        Me.button_cetesb_confirm.TabStop = True
        Me.button_cetesb_confirm.Text = "Salvar"
        '
        'text_cetesb_atividade
        '
        Me.text_cetesb_atividade.BackColor = System.Drawing.SystemColors.Info
        Me.text_cetesb_atividade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_cetesb_atividade.Location = New System.Drawing.Point(337, 10)
        Me.text_cetesb_atividade.MaxLength = 50
        Me.text_cetesb_atividade.Name = "text_cetesb_atividade"
        Me.text_cetesb_atividade.Size = New System.Drawing.Size(486, 21)
        Me.text_cetesb_atividade.TabIndex = 43
        '
        'text_cetesb_cadastro
        '
        Me.text_cetesb_cadastro.BackColor = System.Drawing.SystemColors.Info
        Me.text_cetesb_cadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_cetesb_cadastro.Location = New System.Drawing.Point(151, 10)
        Me.text_cetesb_cadastro.MaxLength = 50
        Me.text_cetesb_cadastro.Name = "text_cetesb_cadastro"
        Me.text_cetesb_cadastro.Size = New System.Drawing.Size(98, 21)
        Me.text_cetesb_cadastro.TabIndex = 42
        '
        'label_cetesb_atividade
        '
        Me.label_cetesb_atividade.BackColor = System.Drawing.Color.Transparent
        Me.label_cetesb_atividade.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cetesb_atividade.Location = New System.Drawing.Point(255, 10)
        Me.label_cetesb_atividade.Name = "label_cetesb_atividade"
        Me.label_cetesb_atividade.Size = New System.Drawing.Size(85, 26)
        Me.label_cetesb_atividade.TabIndex = 41
        Me.label_cetesb_atividade.Text = "Descrição da Atividade:"
        '
        'label_cetesb_cadastro
        '
        Me.label_cetesb_cadastro.AutoSize = True
        Me.label_cetesb_cadastro.BackColor = System.Drawing.Color.Transparent
        Me.label_cetesb_cadastro.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cetesb_cadastro.Location = New System.Drawing.Point(13, 12)
        Me.label_cetesb_cadastro.Name = "label_cetesb_cadastro"
        Me.label_cetesb_cadastro.Size = New System.Drawing.Size(132, 13)
        Me.label_cetesb_cadastro.TabIndex = 40
        Me.label_cetesb_cadastro.Text = "Nº Cadastro CETESB:"
        '
        'button_cetesb_add_evento
        '
        Me.button_cetesb_add_evento.AutoSize = True
        Me.button_cetesb_add_evento.Location = New System.Drawing.Point(790, 419)
        Me.button_cetesb_add_evento.Name = "button_cetesb_add_evento"
        Me.button_cetesb_add_evento.Size = New System.Drawing.Size(92, 13)
        Me.button_cetesb_add_evento.TabIndex = 39
        Me.button_cetesb_add_evento.TabStop = True
        Me.button_cetesb_add_evento.Text = "Adicionar novo"
        '
        'label_cetesb_evento
        '
        Me.label_cetesb_evento.AutoSize = True
        Me.label_cetesb_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_cetesb_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cetesb_evento.Location = New System.Drawing.Point(13, 419)
        Me.label_cetesb_evento.Name = "label_cetesb_evento"
        Me.label_cetesb_evento.Size = New System.Drawing.Size(52, 13)
        Me.label_cetesb_evento.TabIndex = 38
        Me.label_cetesb_evento.Text = "Eventos"
        '
        'list_cetesb_evento
        '
        Me.list_cetesb_evento.AllColumns.Add(Me.OlvColumn19)
        Me.list_cetesb_evento.AllColumns.Add(Me.OlvColumn21)
        Me.list_cetesb_evento.AllColumns.Add(Me.OlvColumn22)
        Me.list_cetesb_evento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_cetesb_evento.BackColor = System.Drawing.Color.White
        Me.list_cetesb_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_cetesb_evento.CheckedAspectName = ""
        Me.list_cetesb_evento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn19, Me.OlvColumn21, Me.OlvColumn22})
        Me.list_cetesb_evento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_cetesb_evento.DataSource = Nothing
        Me.list_cetesb_evento.EmptyListMsg = "Nenhum evento informado"
        Me.list_cetesb_evento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_evento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_cetesb_evento.FullRowSelect = True
        Me.list_cetesb_evento.GridLines = True
        Me.list_cetesb_evento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_evento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_cetesb_evento.HeaderUsesThemes = False
        Me.list_cetesb_evento.HeaderWordWrap = True
        Me.list_cetesb_evento.Location = New System.Drawing.Point(10, 435)
        Me.list_cetesb_evento.Name = "list_cetesb_evento"
        Me.list_cetesb_evento.RowHeight = 15
        Me.list_cetesb_evento.ShowGroups = False
        Me.list_cetesb_evento.ShowImagesOnSubItems = True
        Me.list_cetesb_evento.Size = New System.Drawing.Size(872, 74)
        Me.list_cetesb_evento.TabIndex = 37
        Me.list_cetesb_evento.UseAlternatingBackColors = True
        Me.list_cetesb_evento.UseCompatibleStateImageBehavior = False
        Me.list_cetesb_evento.UseFiltering = True
        Me.list_cetesb_evento.UseHyperlinks = True
        Me.list_cetesb_evento.UseTranslucentSelection = True
        Me.list_cetesb_evento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn19
        '
        Me.OlvColumn19.AspectName = "PNOT_cd_nota"
        Me.OlvColumn19.Hideable = False
        Me.OlvColumn19.Hyperlink = True
        Me.OlvColumn19.IsEditable = False
        Me.OlvColumn19.Text = "Id"
        Me.OlvColumn19.Width = 40
        '
        'OlvColumn21
        '
        Me.OlvColumn21.AspectName = "PNOT_ds_nota"
        Me.OlvColumn21.FillsFreeSpace = True
        Me.OlvColumn21.Text = "Descrição"
        Me.OlvColumn21.Width = 600
        '
        'OlvColumn22
        '
        Me.OlvColumn22.AspectName = "PNOT_dt_ocorrencia"
        Me.OlvColumn22.AspectToStringFormat = "{0:d}"
        Me.OlvColumn22.FillsFreeSpace = True
        Me.OlvColumn22.Text = "Data Ocorrência"
        '
        'button_cetesb_add_documento
        '
        Me.button_cetesb_add_documento.AutoSize = True
        Me.button_cetesb_add_documento.Location = New System.Drawing.Point(790, 303)
        Me.button_cetesb_add_documento.Name = "button_cetesb_add_documento"
        Me.button_cetesb_add_documento.Size = New System.Drawing.Size(92, 13)
        Me.button_cetesb_add_documento.TabIndex = 36
        Me.button_cetesb_add_documento.TabStop = True
        Me.button_cetesb_add_documento.Text = "Adicionar novo"
        '
        'label_cetesb_documento
        '
        Me.label_cetesb_documento.AutoSize = True
        Me.label_cetesb_documento.BackColor = System.Drawing.Color.Transparent
        Me.label_cetesb_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cetesb_documento.Location = New System.Drawing.Point(13, 303)
        Me.label_cetesb_documento.Name = "label_cetesb_documento"
        Me.label_cetesb_documento.Size = New System.Drawing.Size(120, 13)
        Me.label_cetesb_documento.TabIndex = 35
        Me.label_cetesb_documento.Text = "Outros Documentos"
        '
        'list_cetesb_documento
        '
        Me.list_cetesb_documento.AllColumns.Add(Me.OlvColumn17)
        Me.list_cetesb_documento.AllColumns.Add(Me.OlvColumn18)
        Me.list_cetesb_documento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_cetesb_documento.BackColor = System.Drawing.Color.White
        Me.list_cetesb_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_cetesb_documento.CheckedAspectName = ""
        Me.list_cetesb_documento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn17, Me.OlvColumn18})
        Me.list_cetesb_documento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_cetesb_documento.DataSource = Nothing
        Me.list_cetesb_documento.EmptyListMsg = "Nenhum documento anexado"
        Me.list_cetesb_documento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_documento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_cetesb_documento.FullRowSelect = True
        Me.list_cetesb_documento.GridLines = True
        Me.list_cetesb_documento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_documento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_cetesb_documento.HeaderUsesThemes = False
        Me.list_cetesb_documento.HeaderWordWrap = True
        Me.list_cetesb_documento.Location = New System.Drawing.Point(10, 320)
        Me.list_cetesb_documento.Name = "list_cetesb_documento"
        Me.list_cetesb_documento.RowHeight = 15
        Me.list_cetesb_documento.ShowGroups = False
        Me.list_cetesb_documento.ShowImagesOnSubItems = True
        Me.list_cetesb_documento.Size = New System.Drawing.Size(872, 96)
        Me.list_cetesb_documento.TabIndex = 34
        Me.list_cetesb_documento.UseAlternatingBackColors = True
        Me.list_cetesb_documento.UseCompatibleStateImageBehavior = False
        Me.list_cetesb_documento.UseFiltering = True
        Me.list_cetesb_documento.UseHyperlinks = True
        Me.list_cetesb_documento.UseTranslucentSelection = True
        Me.list_cetesb_documento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn17
        '
        Me.OlvColumn17.AspectName = "PDOC_nm_documento"
        Me.OlvColumn17.Hideable = False
        Me.OlvColumn17.Hyperlink = True
        Me.OlvColumn17.IsEditable = False
        Me.OlvColumn17.Text = "Nome"
        Me.OlvColumn17.Width = 300
        '
        'OlvColumn18
        '
        Me.OlvColumn18.AspectName = "PDOC_ds_documento"
        Me.OlvColumn18.Text = "Descrição"
        Me.OlvColumn18.Width = 600
        '
        'button_cetesb_add_titulo
        '
        Me.button_cetesb_add_titulo.AutoSize = True
        Me.button_cetesb_add_titulo.Location = New System.Drawing.Point(760, 37)
        Me.button_cetesb_add_titulo.Name = "button_cetesb_add_titulo"
        Me.button_cetesb_add_titulo.Size = New System.Drawing.Size(113, 13)
        Me.button_cetesb_add_titulo.TabIndex = 24
        Me.button_cetesb_add_titulo.TabStop = True
        Me.button_cetesb_add_titulo.Text = "Adicionar nova SD"
        '
        'label_cetesb_titulo
        '
        Me.label_cetesb_titulo.AutoSize = True
        Me.label_cetesb_titulo.BackColor = System.Drawing.Color.Transparent
        Me.label_cetesb_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_cetesb_titulo.Location = New System.Drawing.Point(13, 38)
        Me.label_cetesb_titulo.Name = "label_cetesb_titulo"
        Me.label_cetesb_titulo.Size = New System.Drawing.Size(72, 13)
        Me.label_cetesb_titulo.TabIndex = 23
        Me.label_cetesb_titulo.Text = "Lista de SD"
        '
        'list_cetesb_titulo
        '
        Me.list_cetesb_titulo.AllColumns.Add(Me.OlvColumn27)
        Me.list_cetesb_titulo.AllColumns.Add(Me.OlvColumn28)
        Me.list_cetesb_titulo.AllColumns.Add(Me.OlvColumn29)
        Me.list_cetesb_titulo.AllColumns.Add(Me.OlvColumn30)
        Me.list_cetesb_titulo.AllColumns.Add(Me.OlvColumn31)
        Me.list_cetesb_titulo.AllColumns.Add(Me.OlvColumn20)
        Me.list_cetesb_titulo.AllColumns.Add(Me.OlvColumn32)
        Me.list_cetesb_titulo.AllColumns.Add(Me.OlvColumn102)
        Me.list_cetesb_titulo.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_cetesb_titulo.BackColor = System.Drawing.Color.White
        Me.list_cetesb_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_cetesb_titulo.CheckedAspectName = ""
        Me.list_cetesb_titulo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn27, Me.OlvColumn28, Me.OlvColumn29, Me.OlvColumn30, Me.OlvColumn31, Me.OlvColumn20, Me.OlvColumn32, Me.OlvColumn102})
        Me.list_cetesb_titulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_cetesb_titulo.DataSource = Nothing
        Me.list_cetesb_titulo.EmptyListMsg = "Nenhuma SD registrada"
        Me.list_cetesb_titulo.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!)
        Me.list_cetesb_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_titulo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_cetesb_titulo.FullRowSelect = True
        Me.list_cetesb_titulo.GridLines = True
        Me.list_cetesb_titulo.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_cetesb_titulo.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_cetesb_titulo.HeaderUsesThemes = False
        Me.list_cetesb_titulo.HeaderWordWrap = True
        Me.list_cetesb_titulo.Location = New System.Drawing.Point(10, 53)
        Me.list_cetesb_titulo.Name = "list_cetesb_titulo"
        Me.list_cetesb_titulo.RowHeight = 15
        Me.list_cetesb_titulo.ShowGroups = False
        Me.list_cetesb_titulo.ShowImagesOnSubItems = True
        Me.list_cetesb_titulo.Size = New System.Drawing.Size(872, 75)
        Me.list_cetesb_titulo.TabIndex = 22
        Me.list_cetesb_titulo.UseAlternatingBackColors = True
        Me.list_cetesb_titulo.UseCompatibleStateImageBehavior = False
        Me.list_cetesb_titulo.UseFiltering = True
        Me.list_cetesb_titulo.UseHyperlinks = True
        Me.list_cetesb_titulo.UseTranslucentSelection = True
        Me.list_cetesb_titulo.View = System.Windows.Forms.View.Details
        '
        'OlvColumn27
        '
        Me.OlvColumn27.AspectName = "PRSD_nm_sd"
        Me.OlvColumn27.Hideable = False
        Me.OlvColumn27.IsEditable = False
        Me.OlvColumn27.Text = "Número SD"
        Me.OlvColumn27.Width = 80
        '
        'OlvColumn28
        '
        Me.OlvColumn28.AspectName = "PRSD_dt_sd"
        Me.OlvColumn28.AspectToStringFormat = "{0:d}"
        Me.OlvColumn28.FillsFreeSpace = True
        Me.OlvColumn28.Text = "Data SD"
        Me.OlvColumn28.Width = 100
        '
        'OlvColumn29
        '
        Me.OlvColumn29.AspectName = "PRSD_nm_prc"
        Me.OlvColumn29.Text = "N.Processo"
        Me.OlvColumn29.Width = 130
        '
        'OlvColumn30
        '
        Me.OlvColumn30.AspectName = "OSSD_nm_objeto"
        Me.OlvColumn30.IsEditable = False
        Me.OlvColumn30.Text = "Objeto da Solicitação"
        Me.OlvColumn30.Width = 130
        Me.OlvColumn30.WordWrap = True
        '
        'OlvColumn31
        '
        Me.OlvColumn31.AspectName = "PRSD_nm_doc"
        Me.OlvColumn31.AspectToStringFormat = "{0:d}"
        Me.OlvColumn31.Text = "N.Documento"
        Me.OlvColumn31.Width = 120
        '
        'OlvColumn20
        '
        Me.OlvColumn20.AspectName = "SISD_nm_situacao_sd"
        Me.OlvColumn20.Text = "Situação"
        Me.OlvColumn20.Width = 130
        '
        'OlvColumn32
        '
        Me.OlvColumn32.AspectName = "PRSD_dt_ini"
        Me.OlvColumn32.AspectToStringFormat = "{0:d}"
        Me.OlvColumn32.Text = "Desde"
        Me.OlvColumn32.Width = 100
        '
        'OlvColumn102
        '
        Me.OlvColumn102.AspectName = "PRSD_dt_fim"
        Me.OlvColumn102.AspectToStringFormat = "{0:d}"
        Me.OlvColumn102.Text = "Data Vencto."
        Me.OlvColumn102.Width = 100
        '
        'tab_daee
        '
        Me.tab_daee.AutoScroll = True
        Me.tab_daee.Controls.Add(Me.A1Panel7)
        Me.tab_daee.Location = New System.Drawing.Point(4, 22)
        Me.tab_daee.Name = "tab_daee"
        Me.tab_daee.Size = New System.Drawing.Size(910, 294)
        Me.tab_daee.TabIndex = 7
        Me.tab_daee.Text = "DAEE"
        Me.tab_daee.UseVisualStyleBackColor = True
        '
        'A1Panel7
        '
        Me.A1Panel7.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel7.Controls.Add(Me.button_daee_add_info)
        Me.A1Panel7.Controls.Add(Me.label_daee_info)
        Me.A1Panel7.Controls.Add(Me.list_daee_info)
        Me.A1Panel7.Controls.Add(Me.button_daee_add_evento)
        Me.A1Panel7.Controls.Add(Me.label_daee_evento)
        Me.A1Panel7.Controls.Add(Me.list_daee_evento)
        Me.A1Panel7.Controls.Add(Me.button_daee_add_documento)
        Me.A1Panel7.Controls.Add(Me.label_daee_documento)
        Me.A1Panel7.Controls.Add(Me.list_daee_documento)
        Me.A1Panel7.Controls.Add(Me.button_daee_add_titulo)
        Me.A1Panel7.Controls.Add(Me.label_daee_titulo)
        Me.A1Panel7.Controls.Add(Me.list_daee_titulo)
        Me.A1Panel7.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel7.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel7.Image = Nothing
        Me.A1Panel7.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel7.Location = New System.Drawing.Point(2, 3)
        Me.A1Panel7.Name = "A1Panel7"
        Me.A1Panel7.Size = New System.Drawing.Size(903, 522)
        Me.A1Panel7.TabIndex = 15
        '
        'button_daee_add_info
        '
        Me.button_daee_add_info.AutoSize = True
        Me.button_daee_add_info.Location = New System.Drawing.Point(790, 117)
        Me.button_daee_add_info.Name = "button_daee_add_info"
        Me.button_daee_add_info.Size = New System.Drawing.Size(92, 13)
        Me.button_daee_add_info.TabIndex = 42
        Me.button_daee_add_info.TabStop = True
        Me.button_daee_add_info.Text = "Adicionar novo"
        '
        'label_daee_info
        '
        Me.label_daee_info.AutoSize = True
        Me.label_daee_info.BackColor = System.Drawing.Color.Transparent
        Me.label_daee_info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_daee_info.Location = New System.Drawing.Point(13, 117)
        Me.label_daee_info.Name = "label_daee_info"
        Me.label_daee_info.Size = New System.Drawing.Size(181, 13)
        Me.label_daee_info.TabIndex = 41
        Me.label_daee_info.Text = "Informações Complementares"
        '
        'list_daee_info
        '
        Me.list_daee_info.AllColumns.Add(Me.OlvColumn81)
        Me.list_daee_info.AllColumns.Add(Me.OlvColumn79)
        Me.list_daee_info.AllColumns.Add(Me.OlvColumn80)
        Me.list_daee_info.AllColumns.Add(Me.OlvColumn78)
        Me.list_daee_info.AllColumns.Add(Me.OlvColumn77)
        Me.list_daee_info.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_daee_info.BackColor = System.Drawing.Color.White
        Me.list_daee_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_daee_info.CheckedAspectName = ""
        Me.list_daee_info.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn81, Me.OlvColumn79, Me.OlvColumn80, Me.OlvColumn78, Me.OlvColumn77})
        Me.list_daee_info.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_daee_info.DataSource = Nothing
        Me.list_daee_info.EmptyListMsg = "Nenhuma informação adicionada"
        Me.list_daee_info.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_info.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_daee_info.FullRowSelect = True
        Me.list_daee_info.GridLines = True
        Me.list_daee_info.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_info.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_daee_info.HeaderUsesThemes = False
        Me.list_daee_info.HeaderWordWrap = True
        Me.list_daee_info.Location = New System.Drawing.Point(10, 134)
        Me.list_daee_info.Name = "list_daee_info"
        Me.list_daee_info.RowHeight = 15
        Me.list_daee_info.ShowGroups = False
        Me.list_daee_info.ShowImagesOnSubItems = True
        Me.list_daee_info.Size = New System.Drawing.Size(872, 130)
        Me.list_daee_info.TabIndex = 40
        Me.list_daee_info.UseAlternatingBackColors = True
        Me.list_daee_info.UseCompatibleStateImageBehavior = False
        Me.list_daee_info.UseFiltering = True
        Me.list_daee_info.UseHyperlinks = True
        Me.list_daee_info.UseTranslucentSelection = True
        Me.list_daee_info.View = System.Windows.Forms.View.Details
        '
        'OlvColumn81
        '
        Me.OlvColumn81.AspectName = "PINF_cd_info"
        Me.OlvColumn81.Text = "Id"
        Me.OlvColumn81.Width = 30
        '
        'OlvColumn79
        '
        Me.OlvColumn79.AspectName = "TINF_nm_tipo_info"
        Me.OlvColumn79.Text = "Tipo"
        Me.OlvColumn79.Width = 100
        '
        'OlvColumn80
        '
        Me.OlvColumn80.AspectName = "PINF_ds_info"
        Me.OlvColumn80.Text = "Descrição"
        Me.OlvColumn80.Width = 300
        '
        'OlvColumn78
        '
        Me.OlvColumn78.AspectName = "SINF_ds_situacao_info"
        Me.OlvColumn78.Text = "Situação"
        Me.OlvColumn78.Width = 200
        '
        'OlvColumn77
        '
        Me.OlvColumn77.AspectName = "PINF_ds_local_documento"
        Me.OlvColumn77.FillsFreeSpace = True
        Me.OlvColumn77.Hideable = False
        Me.OlvColumn77.Hyperlink = True
        Me.OlvColumn77.IsEditable = False
        Me.OlvColumn77.Text = "Documento Anexo"
        '
        'button_daee_add_evento
        '
        Me.button_daee_add_evento.AutoSize = True
        Me.button_daee_add_evento.Location = New System.Drawing.Point(790, 388)
        Me.button_daee_add_evento.Name = "button_daee_add_evento"
        Me.button_daee_add_evento.Size = New System.Drawing.Size(92, 13)
        Me.button_daee_add_evento.TabIndex = 39
        Me.button_daee_add_evento.TabStop = True
        Me.button_daee_add_evento.Text = "Adicionar novo"
        '
        'label_daee_evento
        '
        Me.label_daee_evento.AutoSize = True
        Me.label_daee_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_daee_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_daee_evento.Location = New System.Drawing.Point(13, 388)
        Me.label_daee_evento.Name = "label_daee_evento"
        Me.label_daee_evento.Size = New System.Drawing.Size(52, 13)
        Me.label_daee_evento.TabIndex = 38
        Me.label_daee_evento.Text = "Eventos"
        '
        'list_daee_evento
        '
        Me.list_daee_evento.AllColumns.Add(Me.OlvColumn23)
        Me.list_daee_evento.AllColumns.Add(Me.OlvColumn24)
        Me.list_daee_evento.AllColumns.Add(Me.OlvColumn25)
        Me.list_daee_evento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_daee_evento.BackColor = System.Drawing.Color.White
        Me.list_daee_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_daee_evento.CheckedAspectName = ""
        Me.list_daee_evento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn23, Me.OlvColumn24, Me.OlvColumn25})
        Me.list_daee_evento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_daee_evento.DataSource = Nothing
        Me.list_daee_evento.EmptyListMsg = "Nenhum evento informado"
        Me.list_daee_evento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_evento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_daee_evento.FullRowSelect = True
        Me.list_daee_evento.GridLines = True
        Me.list_daee_evento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_evento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_daee_evento.HeaderUsesThemes = False
        Me.list_daee_evento.HeaderWordWrap = True
        Me.list_daee_evento.Location = New System.Drawing.Point(10, 405)
        Me.list_daee_evento.Name = "list_daee_evento"
        Me.list_daee_evento.RowHeight = 15
        Me.list_daee_evento.ShowGroups = False
        Me.list_daee_evento.ShowImagesOnSubItems = True
        Me.list_daee_evento.Size = New System.Drawing.Size(872, 87)
        Me.list_daee_evento.TabIndex = 37
        Me.list_daee_evento.UseAlternatingBackColors = True
        Me.list_daee_evento.UseCompatibleStateImageBehavior = False
        Me.list_daee_evento.UseFiltering = True
        Me.list_daee_evento.UseHyperlinks = True
        Me.list_daee_evento.UseTranslucentSelection = True
        Me.list_daee_evento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn23
        '
        Me.OlvColumn23.AspectName = "PNOT_cd_nota"
        Me.OlvColumn23.Hideable = False
        Me.OlvColumn23.Hyperlink = True
        Me.OlvColumn23.IsEditable = False
        Me.OlvColumn23.Text = "Id"
        Me.OlvColumn23.Width = 40
        '
        'OlvColumn24
        '
        Me.OlvColumn24.AspectName = "PNOT_ds_nota"
        Me.OlvColumn24.FillsFreeSpace = True
        Me.OlvColumn24.Text = "Descrição"
        Me.OlvColumn24.Width = 600
        '
        'OlvColumn25
        '
        Me.OlvColumn25.AspectName = "PNOT_dt_ocorrencia"
        Me.OlvColumn25.AspectToStringFormat = "{0:d}"
        Me.OlvColumn25.FillsFreeSpace = True
        Me.OlvColumn25.Text = "Data Ocorrência"
        '
        'button_daee_add_documento
        '
        Me.button_daee_add_documento.AutoSize = True
        Me.button_daee_add_documento.Location = New System.Drawing.Point(790, 269)
        Me.button_daee_add_documento.Name = "button_daee_add_documento"
        Me.button_daee_add_documento.Size = New System.Drawing.Size(92, 13)
        Me.button_daee_add_documento.TabIndex = 36
        Me.button_daee_add_documento.TabStop = True
        Me.button_daee_add_documento.Text = "Adicionar novo"
        '
        'label_daee_documento
        '
        Me.label_daee_documento.AutoSize = True
        Me.label_daee_documento.BackColor = System.Drawing.Color.Transparent
        Me.label_daee_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_daee_documento.Location = New System.Drawing.Point(13, 269)
        Me.label_daee_documento.Name = "label_daee_documento"
        Me.label_daee_documento.Size = New System.Drawing.Size(120, 13)
        Me.label_daee_documento.TabIndex = 35
        Me.label_daee_documento.Text = "Outros Documentos"
        '
        'list_daee_documento
        '
        Me.list_daee_documento.AllColumns.Add(Me.OlvColumn26)
        Me.list_daee_documento.AllColumns.Add(Me.OlvColumn33)
        Me.list_daee_documento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_daee_documento.BackColor = System.Drawing.Color.White
        Me.list_daee_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_daee_documento.CheckedAspectName = ""
        Me.list_daee_documento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn26, Me.OlvColumn33})
        Me.list_daee_documento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_daee_documento.DataSource = Nothing
        Me.list_daee_documento.EmptyListMsg = "Nenhum documento anexado"
        Me.list_daee_documento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_documento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_daee_documento.FullRowSelect = True
        Me.list_daee_documento.GridLines = True
        Me.list_daee_documento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_documento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_daee_documento.HeaderUsesThemes = False
        Me.list_daee_documento.HeaderWordWrap = True
        Me.list_daee_documento.Location = New System.Drawing.Point(10, 286)
        Me.list_daee_documento.Name = "list_daee_documento"
        Me.list_daee_documento.RowHeight = 15
        Me.list_daee_documento.ShowGroups = False
        Me.list_daee_documento.ShowImagesOnSubItems = True
        Me.list_daee_documento.Size = New System.Drawing.Size(872, 96)
        Me.list_daee_documento.TabIndex = 34
        Me.list_daee_documento.UseAlternatingBackColors = True
        Me.list_daee_documento.UseCompatibleStateImageBehavior = False
        Me.list_daee_documento.UseFiltering = True
        Me.list_daee_documento.UseHyperlinks = True
        Me.list_daee_documento.UseTranslucentSelection = True
        Me.list_daee_documento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn26
        '
        Me.OlvColumn26.AspectName = "PDOC_nm_documento"
        Me.OlvColumn26.Hideable = False
        Me.OlvColumn26.Hyperlink = True
        Me.OlvColumn26.IsEditable = False
        Me.OlvColumn26.Text = "Nome"
        Me.OlvColumn26.Width = 300
        '
        'OlvColumn33
        '
        Me.OlvColumn33.AspectName = "PDOC_ds_documento"
        Me.OlvColumn33.Text = "Descrição"
        Me.OlvColumn33.Width = 600
        '
        'button_daee_add_titulo
        '
        Me.button_daee_add_titulo.AutoSize = True
        Me.button_daee_add_titulo.Location = New System.Drawing.Point(760, 7)
        Me.button_daee_add_titulo.Name = "button_daee_add_titulo"
        Me.button_daee_add_titulo.Size = New System.Drawing.Size(124, 13)
        Me.button_daee_add_titulo.TabIndex = 24
        Me.button_daee_add_titulo.TabStop = True
        Me.button_daee_add_titulo.Text = "Adicionar novo título"
        '
        'label_daee_titulo
        '
        Me.label_daee_titulo.AutoSize = True
        Me.label_daee_titulo.BackColor = System.Drawing.Color.Transparent
        Me.label_daee_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_daee_titulo.Location = New System.Drawing.Point(13, 6)
        Me.label_daee_titulo.Name = "label_daee_titulo"
        Me.label_daee_titulo.Size = New System.Drawing.Size(160, 13)
        Me.label_daee_titulo.TabIndex = 23
        Me.label_daee_titulo.Text = "Lista de Títulos informados"
        '
        'list_daee_titulo
        '
        Me.list_daee_titulo.AllColumns.Add(Me.OlvColumn34)
        Me.list_daee_titulo.AllColumns.Add(Me.OlvColumn35)
        Me.list_daee_titulo.AllColumns.Add(Me.OlvColumn36)
        Me.list_daee_titulo.AllColumns.Add(Me.OlvColumn37)
        Me.list_daee_titulo.AllColumns.Add(Me.OlvColumn38)
        Me.list_daee_titulo.AllColumns.Add(Me.OlvColumn39)
        Me.list_daee_titulo.AllColumns.Add(Me.OlvColumn40)
        Me.list_daee_titulo.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_daee_titulo.BackColor = System.Drawing.Color.White
        Me.list_daee_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_daee_titulo.CheckedAspectName = ""
        Me.list_daee_titulo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn34, Me.OlvColumn35, Me.OlvColumn36, Me.OlvColumn37, Me.OlvColumn38, Me.OlvColumn39, Me.OlvColumn40})
        Me.list_daee_titulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_daee_titulo.DataSource = Nothing
        Me.list_daee_titulo.EmptyListMsg = "Nenhm título registrado"
        Me.list_daee_titulo.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!)
        Me.list_daee_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_titulo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_daee_titulo.FullRowSelect = True
        Me.list_daee_titulo.GridLines = True
        Me.list_daee_titulo.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_daee_titulo.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_daee_titulo.HeaderUsesThemes = False
        Me.list_daee_titulo.HeaderWordWrap = True
        Me.list_daee_titulo.Location = New System.Drawing.Point(10, 23)
        Me.list_daee_titulo.Name = "list_daee_titulo"
        Me.list_daee_titulo.RowHeight = 15
        Me.list_daee_titulo.ShowGroups = False
        Me.list_daee_titulo.ShowImagesOnSubItems = True
        Me.list_daee_titulo.Size = New System.Drawing.Size(872, 89)
        Me.list_daee_titulo.TabIndex = 22
        Me.list_daee_titulo.UseAlternatingBackColors = True
        Me.list_daee_titulo.UseCompatibleStateImageBehavior = False
        Me.list_daee_titulo.UseFiltering = True
        Me.list_daee_titulo.UseHyperlinks = True
        Me.list_daee_titulo.UseTranslucentSelection = True
        Me.list_daee_titulo.View = System.Windows.Forms.View.Details
        '
        'OlvColumn34
        '
        Me.OlvColumn34.AspectName = "PTIT_nm_titulo"
        Me.OlvColumn34.Hideable = False
        Me.OlvColumn34.IsEditable = False
        Me.OlvColumn34.Text = "Número"
        Me.OlvColumn34.Width = 80
        '
        'OlvColumn35
        '
        Me.OlvColumn35.AspectName = "PTIT_ds_titulo"
        Me.OlvColumn35.FillsFreeSpace = True
        Me.OlvColumn35.Text = "Descrição"
        Me.OlvColumn35.Width = 240
        Me.OlvColumn35.WordWrap = True
        '
        'OlvColumn36
        '
        Me.OlvColumn36.AspectName = "TTIT_ds_tipo_titulo"
        Me.OlvColumn36.Text = "Tipo"
        Me.OlvColumn36.Width = 130
        Me.OlvColumn36.WordWrap = True
        '
        'OlvColumn37
        '
        Me.OlvColumn37.AspectName = "SITU_ds_situacao_titulo"
        Me.OlvColumn37.IsEditable = False
        Me.OlvColumn37.Text = "Situação"
        Me.OlvColumn37.Width = 130
        '
        'OlvColumn38
        '
        Me.OlvColumn38.AspectName = "PTIT_dt_publicacao"
        Me.OlvColumn38.AspectToStringFormat = "{0:d}"
        Me.OlvColumn38.Text = "Data Publicação"
        Me.OlvColumn38.Width = 100
        Me.OlvColumn38.WordWrap = True
        '
        'OlvColumn39
        '
        Me.OlvColumn39.AspectName = "PTIT_dt_vencimento"
        Me.OlvColumn39.AspectToStringFormat = "{0:d}"
        Me.OlvColumn39.Text = "Data Vencimento"
        Me.OlvColumn39.Width = 100
        Me.OlvColumn39.WordWrap = True
        '
        'OlvColumn40
        '
        Me.OlvColumn40.AspectName = "PTIT_ds_nome_documento"
        Me.OlvColumn40.FillsFreeSpace = True
        Me.OlvColumn40.Hyperlink = True
        Me.OlvColumn40.Text = "Doc.Principal"
        '
        'tab_icmbio
        '
        Me.tab_icmbio.AutoScroll = True
        Me.tab_icmbio.Controls.Add(Me.A1Panel8)
        Me.tab_icmbio.Location = New System.Drawing.Point(4, 22)
        Me.tab_icmbio.Name = "tab_icmbio"
        Me.tab_icmbio.Size = New System.Drawing.Size(910, 294)
        Me.tab_icmbio.TabIndex = 8
        Me.tab_icmbio.Text = "ICMBIO"
        Me.tab_icmbio.UseVisualStyleBackColor = True
        '
        'A1Panel8
        '
        Me.A1Panel8.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel8.Controls.Add(Me.button_icmbio_add_info)
        Me.A1Panel8.Controls.Add(Me.label_icmbio_info)
        Me.A1Panel8.Controls.Add(Me.list_icmbio_info)
        Me.A1Panel8.Controls.Add(Me.button_icmbio_add_evento)
        Me.A1Panel8.Controls.Add(Me.label_icmbio_evento)
        Me.A1Panel8.Controls.Add(Me.list_icmbio_evento)
        Me.A1Panel8.Controls.Add(Me.button_icmbio_add_documento)
        Me.A1Panel8.Controls.Add(Me.label_icmbio_documento)
        Me.A1Panel8.Controls.Add(Me.list_icmbio_documento)
        Me.A1Panel8.Controls.Add(Me.button_icmbio_add_titulo)
        Me.A1Panel8.Controls.Add(Me.label_icmbio_titulo)
        Me.A1Panel8.Controls.Add(Me.list_icmbio_titulo)
        Me.A1Panel8.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel8.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel8.Image = Nothing
        Me.A1Panel8.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel8.Location = New System.Drawing.Point(2, 3)
        Me.A1Panel8.Name = "A1Panel8"
        Me.A1Panel8.Size = New System.Drawing.Size(905, 501)
        Me.A1Panel8.TabIndex = 16
        '
        'button_icmbio_add_info
        '
        Me.button_icmbio_add_info.AutoSize = True
        Me.button_icmbio_add_info.Location = New System.Drawing.Point(784, 115)
        Me.button_icmbio_add_info.Name = "button_icmbio_add_info"
        Me.button_icmbio_add_info.Size = New System.Drawing.Size(92, 13)
        Me.button_icmbio_add_info.TabIndex = 45
        Me.button_icmbio_add_info.TabStop = True
        Me.button_icmbio_add_info.Text = "Adicionar novo"
        '
        'label_icmbio_info
        '
        Me.label_icmbio_info.AutoSize = True
        Me.label_icmbio_info.BackColor = System.Drawing.Color.Transparent
        Me.label_icmbio_info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_icmbio_info.Location = New System.Drawing.Point(12, 115)
        Me.label_icmbio_info.Name = "label_icmbio_info"
        Me.label_icmbio_info.Size = New System.Drawing.Size(181, 13)
        Me.label_icmbio_info.TabIndex = 44
        Me.label_icmbio_info.Text = "Informações Complementares"
        '
        'list_icmbio_info
        '
        Me.list_icmbio_info.AllColumns.Add(Me.OlvColumn82)
        Me.list_icmbio_info.AllColumns.Add(Me.OlvColumn83)
        Me.list_icmbio_info.AllColumns.Add(Me.OlvColumn84)
        Me.list_icmbio_info.AllColumns.Add(Me.OlvColumn85)
        Me.list_icmbio_info.AllColumns.Add(Me.OlvColumn86)
        Me.list_icmbio_info.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_icmbio_info.BackColor = System.Drawing.Color.White
        Me.list_icmbio_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_icmbio_info.CheckedAspectName = ""
        Me.list_icmbio_info.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn82, Me.OlvColumn83, Me.OlvColumn84, Me.OlvColumn85, Me.OlvColumn86})
        Me.list_icmbio_info.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_icmbio_info.DataSource = Nothing
        Me.list_icmbio_info.EmptyListMsg = "Nenhuma informação adicionada"
        Me.list_icmbio_info.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_info.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_icmbio_info.FullRowSelect = True
        Me.list_icmbio_info.GridLines = True
        Me.list_icmbio_info.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_info.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_icmbio_info.HeaderUsesThemes = False
        Me.list_icmbio_info.HeaderWordWrap = True
        Me.list_icmbio_info.Location = New System.Drawing.Point(13, 134)
        Me.list_icmbio_info.Name = "list_icmbio_info"
        Me.list_icmbio_info.RowHeight = 15
        Me.list_icmbio_info.ShowGroups = False
        Me.list_icmbio_info.ShowImagesOnSubItems = True
        Me.list_icmbio_info.Size = New System.Drawing.Size(872, 130)
        Me.list_icmbio_info.TabIndex = 43
        Me.list_icmbio_info.UseAlternatingBackColors = True
        Me.list_icmbio_info.UseCompatibleStateImageBehavior = False
        Me.list_icmbio_info.UseFiltering = True
        Me.list_icmbio_info.UseHyperlinks = True
        Me.list_icmbio_info.UseTranslucentSelection = True
        Me.list_icmbio_info.View = System.Windows.Forms.View.Details
        '
        'OlvColumn82
        '
        Me.OlvColumn82.AspectName = "PINF_cd_info"
        Me.OlvColumn82.Text = "Id"
        Me.OlvColumn82.Width = 30
        '
        'OlvColumn83
        '
        Me.OlvColumn83.AspectName = "TINF_nm_tipo_info"
        Me.OlvColumn83.Text = "Tipo"
        Me.OlvColumn83.Width = 100
        '
        'OlvColumn84
        '
        Me.OlvColumn84.AspectName = "PINF_ds_info"
        Me.OlvColumn84.Text = "Descrição"
        Me.OlvColumn84.Width = 300
        '
        'OlvColumn85
        '
        Me.OlvColumn85.AspectName = "SINF_ds_situacao_info"
        Me.OlvColumn85.Text = "Situação"
        Me.OlvColumn85.Width = 200
        '
        'OlvColumn86
        '
        Me.OlvColumn86.AspectName = "PINF_ds_local_documento"
        Me.OlvColumn86.FillsFreeSpace = True
        Me.OlvColumn86.Hideable = False
        Me.OlvColumn86.Hyperlink = True
        Me.OlvColumn86.IsEditable = False
        Me.OlvColumn86.Text = "Documento Anexo"
        '
        'button_icmbio_add_evento
        '
        Me.button_icmbio_add_evento.AutoSize = True
        Me.button_icmbio_add_evento.Location = New System.Drawing.Point(790, 383)
        Me.button_icmbio_add_evento.Name = "button_icmbio_add_evento"
        Me.button_icmbio_add_evento.Size = New System.Drawing.Size(92, 13)
        Me.button_icmbio_add_evento.TabIndex = 39
        Me.button_icmbio_add_evento.TabStop = True
        Me.button_icmbio_add_evento.Text = "Adicionar novo"
        '
        'label_icmbio_evento
        '
        Me.label_icmbio_evento.AutoSize = True
        Me.label_icmbio_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_icmbio_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_icmbio_evento.Location = New System.Drawing.Point(13, 383)
        Me.label_icmbio_evento.Name = "label_icmbio_evento"
        Me.label_icmbio_evento.Size = New System.Drawing.Size(52, 13)
        Me.label_icmbio_evento.TabIndex = 38
        Me.label_icmbio_evento.Text = "Eventos"
        '
        'list_icmbio_evento
        '
        Me.list_icmbio_evento.AllColumns.Add(Me.OlvColumn41)
        Me.list_icmbio_evento.AllColumns.Add(Me.OlvColumn42)
        Me.list_icmbio_evento.AllColumns.Add(Me.OlvColumn43)
        Me.list_icmbio_evento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_icmbio_evento.BackColor = System.Drawing.Color.White
        Me.list_icmbio_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_icmbio_evento.CheckedAspectName = ""
        Me.list_icmbio_evento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn41, Me.OlvColumn42, Me.OlvColumn43})
        Me.list_icmbio_evento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_icmbio_evento.DataSource = Nothing
        Me.list_icmbio_evento.EmptyListMsg = "Nenhum evento informado"
        Me.list_icmbio_evento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_evento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_icmbio_evento.FullRowSelect = True
        Me.list_icmbio_evento.GridLines = True
        Me.list_icmbio_evento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_evento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_icmbio_evento.HeaderUsesThemes = False
        Me.list_icmbio_evento.HeaderWordWrap = True
        Me.list_icmbio_evento.Location = New System.Drawing.Point(10, 399)
        Me.list_icmbio_evento.Name = "list_icmbio_evento"
        Me.list_icmbio_evento.RowHeight = 15
        Me.list_icmbio_evento.ShowGroups = False
        Me.list_icmbio_evento.ShowImagesOnSubItems = True
        Me.list_icmbio_evento.Size = New System.Drawing.Size(872, 87)
        Me.list_icmbio_evento.TabIndex = 37
        Me.list_icmbio_evento.UseAlternatingBackColors = True
        Me.list_icmbio_evento.UseCompatibleStateImageBehavior = False
        Me.list_icmbio_evento.UseFiltering = True
        Me.list_icmbio_evento.UseHyperlinks = True
        Me.list_icmbio_evento.UseTranslucentSelection = True
        Me.list_icmbio_evento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn41
        '
        Me.OlvColumn41.AspectName = "PNOT_cd_nota"
        Me.OlvColumn41.Hideable = False
        Me.OlvColumn41.Hyperlink = True
        Me.OlvColumn41.IsEditable = False
        Me.OlvColumn41.Text = "Id"
        Me.OlvColumn41.Width = 40
        '
        'OlvColumn42
        '
        Me.OlvColumn42.AspectName = "PNOT_ds_nota"
        Me.OlvColumn42.FillsFreeSpace = True
        Me.OlvColumn42.Text = "Descrição"
        Me.OlvColumn42.Width = 600
        '
        'OlvColumn43
        '
        Me.OlvColumn43.AspectName = "PNOT_dt_ocorrencia"
        Me.OlvColumn43.AspectToStringFormat = "{0:d}"
        Me.OlvColumn43.FillsFreeSpace = True
        Me.OlvColumn43.Text = "Data Ocorrência"
        '
        'button_icmbio_add_documento
        '
        Me.button_icmbio_add_documento.AutoSize = True
        Me.button_icmbio_add_documento.Location = New System.Drawing.Point(784, 268)
        Me.button_icmbio_add_documento.Name = "button_icmbio_add_documento"
        Me.button_icmbio_add_documento.Size = New System.Drawing.Size(92, 13)
        Me.button_icmbio_add_documento.TabIndex = 36
        Me.button_icmbio_add_documento.TabStop = True
        Me.button_icmbio_add_documento.Text = "Adicionar novo"
        '
        'label_icmbio_documento
        '
        Me.label_icmbio_documento.AutoSize = True
        Me.label_icmbio_documento.BackColor = System.Drawing.Color.Transparent
        Me.label_icmbio_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_icmbio_documento.Location = New System.Drawing.Point(12, 268)
        Me.label_icmbio_documento.Name = "label_icmbio_documento"
        Me.label_icmbio_documento.Size = New System.Drawing.Size(120, 13)
        Me.label_icmbio_documento.TabIndex = 35
        Me.label_icmbio_documento.Text = "Outros Documentos"
        '
        'list_icmbio_documento
        '
        Me.list_icmbio_documento.AllColumns.Add(Me.OlvColumn44)
        Me.list_icmbio_documento.AllColumns.Add(Me.OlvColumn45)
        Me.list_icmbio_documento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_icmbio_documento.BackColor = System.Drawing.Color.White
        Me.list_icmbio_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_icmbio_documento.CheckedAspectName = ""
        Me.list_icmbio_documento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn44, Me.OlvColumn45})
        Me.list_icmbio_documento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_icmbio_documento.DataSource = Nothing
        Me.list_icmbio_documento.EmptyListMsg = "Nenhum documento anexado"
        Me.list_icmbio_documento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_documento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_icmbio_documento.FullRowSelect = True
        Me.list_icmbio_documento.GridLines = True
        Me.list_icmbio_documento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_documento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_icmbio_documento.HeaderUsesThemes = False
        Me.list_icmbio_documento.HeaderWordWrap = True
        Me.list_icmbio_documento.Location = New System.Drawing.Point(12, 284)
        Me.list_icmbio_documento.Name = "list_icmbio_documento"
        Me.list_icmbio_documento.RowHeight = 15
        Me.list_icmbio_documento.ShowGroups = False
        Me.list_icmbio_documento.ShowImagesOnSubItems = True
        Me.list_icmbio_documento.Size = New System.Drawing.Size(872, 96)
        Me.list_icmbio_documento.TabIndex = 34
        Me.list_icmbio_documento.UseAlternatingBackColors = True
        Me.list_icmbio_documento.UseCompatibleStateImageBehavior = False
        Me.list_icmbio_documento.UseFiltering = True
        Me.list_icmbio_documento.UseHyperlinks = True
        Me.list_icmbio_documento.UseTranslucentSelection = True
        Me.list_icmbio_documento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn44
        '
        Me.OlvColumn44.AspectName = "PDOC_nm_documento"
        Me.OlvColumn44.Hideable = False
        Me.OlvColumn44.Hyperlink = True
        Me.OlvColumn44.IsEditable = False
        Me.OlvColumn44.Text = "Nome"
        Me.OlvColumn44.Width = 300
        '
        'OlvColumn45
        '
        Me.OlvColumn45.AspectName = "PDOC_ds_documento"
        Me.OlvColumn45.Text = "Descrição"
        Me.OlvColumn45.Width = 600
        '
        'button_icmbio_add_titulo
        '
        Me.button_icmbio_add_titulo.AutoSize = True
        Me.button_icmbio_add_titulo.Location = New System.Drawing.Point(760, 7)
        Me.button_icmbio_add_titulo.Name = "button_icmbio_add_titulo"
        Me.button_icmbio_add_titulo.Size = New System.Drawing.Size(124, 13)
        Me.button_icmbio_add_titulo.TabIndex = 24
        Me.button_icmbio_add_titulo.TabStop = True
        Me.button_icmbio_add_titulo.Text = "Adicionar novo título"
        '
        'label_icmbio_titulo
        '
        Me.label_icmbio_titulo.AutoSize = True
        Me.label_icmbio_titulo.BackColor = System.Drawing.Color.Transparent
        Me.label_icmbio_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_icmbio_titulo.Location = New System.Drawing.Point(13, 6)
        Me.label_icmbio_titulo.Name = "label_icmbio_titulo"
        Me.label_icmbio_titulo.Size = New System.Drawing.Size(160, 13)
        Me.label_icmbio_titulo.TabIndex = 23
        Me.label_icmbio_titulo.Text = "Lista de Títulos informados"
        '
        'list_icmbio_titulo
        '
        Me.list_icmbio_titulo.AllColumns.Add(Me.OlvColumn46)
        Me.list_icmbio_titulo.AllColumns.Add(Me.OlvColumn47)
        Me.list_icmbio_titulo.AllColumns.Add(Me.OlvColumn48)
        Me.list_icmbio_titulo.AllColumns.Add(Me.OlvColumn49)
        Me.list_icmbio_titulo.AllColumns.Add(Me.OlvColumn50)
        Me.list_icmbio_titulo.AllColumns.Add(Me.OlvColumn51)
        Me.list_icmbio_titulo.AllColumns.Add(Me.OlvColumn52)
        Me.list_icmbio_titulo.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_icmbio_titulo.BackColor = System.Drawing.Color.White
        Me.list_icmbio_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_icmbio_titulo.CheckedAspectName = ""
        Me.list_icmbio_titulo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn46, Me.OlvColumn47, Me.OlvColumn48, Me.OlvColumn49, Me.OlvColumn50, Me.OlvColumn51, Me.OlvColumn52})
        Me.list_icmbio_titulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_icmbio_titulo.DataSource = Nothing
        Me.list_icmbio_titulo.EmptyListMsg = "Nenhm título registrado"
        Me.list_icmbio_titulo.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!)
        Me.list_icmbio_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_titulo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_icmbio_titulo.FullRowSelect = True
        Me.list_icmbio_titulo.GridLines = True
        Me.list_icmbio_titulo.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_icmbio_titulo.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_icmbio_titulo.HeaderUsesThemes = False
        Me.list_icmbio_titulo.HeaderWordWrap = True
        Me.list_icmbio_titulo.Location = New System.Drawing.Point(10, 23)
        Me.list_icmbio_titulo.Name = "list_icmbio_titulo"
        Me.list_icmbio_titulo.RowHeight = 15
        Me.list_icmbio_titulo.ShowGroups = False
        Me.list_icmbio_titulo.ShowImagesOnSubItems = True
        Me.list_icmbio_titulo.Size = New System.Drawing.Size(872, 89)
        Me.list_icmbio_titulo.TabIndex = 22
        Me.list_icmbio_titulo.UseAlternatingBackColors = True
        Me.list_icmbio_titulo.UseCompatibleStateImageBehavior = False
        Me.list_icmbio_titulo.UseFiltering = True
        Me.list_icmbio_titulo.UseHyperlinks = True
        Me.list_icmbio_titulo.UseTranslucentSelection = True
        Me.list_icmbio_titulo.View = System.Windows.Forms.View.Details
        '
        'OlvColumn46
        '
        Me.OlvColumn46.AspectName = "PTIT_nm_titulo"
        Me.OlvColumn46.Hideable = False
        Me.OlvColumn46.IsEditable = False
        Me.OlvColumn46.Text = "Número"
        Me.OlvColumn46.Width = 80
        '
        'OlvColumn47
        '
        Me.OlvColumn47.AspectName = "PTIT_ds_titulo"
        Me.OlvColumn47.FillsFreeSpace = True
        Me.OlvColumn47.Text = "Descrição"
        Me.OlvColumn47.Width = 240
        Me.OlvColumn47.WordWrap = True
        '
        'OlvColumn48
        '
        Me.OlvColumn48.AspectName = "TTIT_ds_tipo_titulo"
        Me.OlvColumn48.Text = "Tipo"
        Me.OlvColumn48.Width = 130
        Me.OlvColumn48.WordWrap = True
        '
        'OlvColumn49
        '
        Me.OlvColumn49.AspectName = "SITU_ds_situacao_titulo"
        Me.OlvColumn49.IsEditable = False
        Me.OlvColumn49.Text = "Situação"
        Me.OlvColumn49.Width = 130
        '
        'OlvColumn50
        '
        Me.OlvColumn50.AspectName = "PTIT_dt_publicacao"
        Me.OlvColumn50.AspectToStringFormat = "{0:d}"
        Me.OlvColumn50.Text = "Data Publicação"
        Me.OlvColumn50.Width = 100
        Me.OlvColumn50.WordWrap = True
        '
        'OlvColumn51
        '
        Me.OlvColumn51.AspectName = "PTIT_dt_vencimento"
        Me.OlvColumn51.AspectToStringFormat = "{0:d}"
        Me.OlvColumn51.Text = "Data Vencimento"
        Me.OlvColumn51.Width = 100
        Me.OlvColumn51.WordWrap = True
        '
        'OlvColumn52
        '
        Me.OlvColumn52.AspectName = "PTIT_ds_nome_documento"
        Me.OlvColumn52.FillsFreeSpace = True
        Me.OlvColumn52.Hyperlink = True
        Me.OlvColumn52.Text = "Doc.Principal"
        '
        'tab_petrobras
        '
        Me.tab_petrobras.AutoScroll = True
        Me.tab_petrobras.Controls.Add(Me.A1Panel9)
        Me.tab_petrobras.Location = New System.Drawing.Point(4, 22)
        Me.tab_petrobras.Name = "tab_petrobras"
        Me.tab_petrobras.Size = New System.Drawing.Size(910, 294)
        Me.tab_petrobras.TabIndex = 9
        Me.tab_petrobras.Text = "Petrobrás"
        Me.tab_petrobras.UseVisualStyleBackColor = True
        '
        'A1Panel9
        '
        Me.A1Panel9.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel9.Controls.Add(Me.button_petrobras_add_info)
        Me.A1Panel9.Controls.Add(Me.label_petrobras_info)
        Me.A1Panel9.Controls.Add(Me.list_petrobras_info)
        Me.A1Panel9.Controls.Add(Me.button_petrobras_add_evento)
        Me.A1Panel9.Controls.Add(Me.label_petrobras_evento)
        Me.A1Panel9.Controls.Add(Me.list_petrobras_evento)
        Me.A1Panel9.Controls.Add(Me.button_petrobras_add_documento)
        Me.A1Panel9.Controls.Add(Me.label_petrobras_documento)
        Me.A1Panel9.Controls.Add(Me.list_petrobras_documento)
        Me.A1Panel9.Controls.Add(Me.button_petrobras_add_titulo)
        Me.A1Panel9.Controls.Add(Me.label_petrobras_titulo)
        Me.A1Panel9.Controls.Add(Me.list_petrobras_titulo)
        Me.A1Panel9.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel9.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel9.Image = Nothing
        Me.A1Panel9.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel9.Location = New System.Drawing.Point(2, 3)
        Me.A1Panel9.Name = "A1Panel9"
        Me.A1Panel9.Size = New System.Drawing.Size(903, 522)
        Me.A1Panel9.TabIndex = 17
        '
        'button_petrobras_add_info
        '
        Me.button_petrobras_add_info.AutoSize = True
        Me.button_petrobras_add_info.Location = New System.Drawing.Point(790, 118)
        Me.button_petrobras_add_info.Name = "button_petrobras_add_info"
        Me.button_petrobras_add_info.Size = New System.Drawing.Size(92, 13)
        Me.button_petrobras_add_info.TabIndex = 48
        Me.button_petrobras_add_info.TabStop = True
        Me.button_petrobras_add_info.Text = "Adicionar novo"
        '
        'label_petrobras_info
        '
        Me.label_petrobras_info.AutoSize = True
        Me.label_petrobras_info.BackColor = System.Drawing.Color.Transparent
        Me.label_petrobras_info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_petrobras_info.Location = New System.Drawing.Point(12, 118)
        Me.label_petrobras_info.Name = "label_petrobras_info"
        Me.label_petrobras_info.Size = New System.Drawing.Size(181, 13)
        Me.label_petrobras_info.TabIndex = 47
        Me.label_petrobras_info.Text = "Informações Complementares"
        '
        'list_petrobras_info
        '
        Me.list_petrobras_info.AllColumns.Add(Me.OlvColumn87)
        Me.list_petrobras_info.AllColumns.Add(Me.OlvColumn88)
        Me.list_petrobras_info.AllColumns.Add(Me.OlvColumn89)
        Me.list_petrobras_info.AllColumns.Add(Me.OlvColumn90)
        Me.list_petrobras_info.AllColumns.Add(Me.OlvColumn91)
        Me.list_petrobras_info.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_petrobras_info.BackColor = System.Drawing.Color.White
        Me.list_petrobras_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_petrobras_info.CheckedAspectName = ""
        Me.list_petrobras_info.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn87, Me.OlvColumn88, Me.OlvColumn89, Me.OlvColumn90, Me.OlvColumn91})
        Me.list_petrobras_info.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_petrobras_info.DataSource = Nothing
        Me.list_petrobras_info.EmptyListMsg = "Nenhuma informação adicionada"
        Me.list_petrobras_info.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_info.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_petrobras_info.FullRowSelect = True
        Me.list_petrobras_info.GridLines = True
        Me.list_petrobras_info.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_info.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_petrobras_info.HeaderUsesThemes = False
        Me.list_petrobras_info.HeaderWordWrap = True
        Me.list_petrobras_info.Location = New System.Drawing.Point(15, 134)
        Me.list_petrobras_info.Name = "list_petrobras_info"
        Me.list_petrobras_info.RowHeight = 15
        Me.list_petrobras_info.ShowGroups = False
        Me.list_petrobras_info.ShowImagesOnSubItems = True
        Me.list_petrobras_info.Size = New System.Drawing.Size(872, 137)
        Me.list_petrobras_info.TabIndex = 46
        Me.list_petrobras_info.UseAlternatingBackColors = True
        Me.list_petrobras_info.UseCompatibleStateImageBehavior = False
        Me.list_petrobras_info.UseFiltering = True
        Me.list_petrobras_info.UseHyperlinks = True
        Me.list_petrobras_info.UseTranslucentSelection = True
        Me.list_petrobras_info.View = System.Windows.Forms.View.Details
        '
        'OlvColumn87
        '
        Me.OlvColumn87.AspectName = "PINF_cd_info"
        Me.OlvColumn87.Text = "Id"
        Me.OlvColumn87.Width = 30
        '
        'OlvColumn88
        '
        Me.OlvColumn88.AspectName = "TINF_nm_tipo_info"
        Me.OlvColumn88.Text = "Tipo"
        Me.OlvColumn88.Width = 100
        '
        'OlvColumn89
        '
        Me.OlvColumn89.AspectName = "PINF_ds_info"
        Me.OlvColumn89.Text = "Descrição"
        Me.OlvColumn89.Width = 300
        '
        'OlvColumn90
        '
        Me.OlvColumn90.AspectName = "SINF_ds_situacao_info"
        Me.OlvColumn90.Text = "Situação"
        Me.OlvColumn90.Width = 200
        '
        'OlvColumn91
        '
        Me.OlvColumn91.AspectName = "PINF_ds_local_documento"
        Me.OlvColumn91.FillsFreeSpace = True
        Me.OlvColumn91.Hideable = False
        Me.OlvColumn91.Hyperlink = True
        Me.OlvColumn91.IsEditable = False
        Me.OlvColumn91.Text = "Documento Anexo"
        '
        'button_petrobras_add_evento
        '
        Me.button_petrobras_add_evento.AutoSize = True
        Me.button_petrobras_add_evento.Location = New System.Drawing.Point(790, 404)
        Me.button_petrobras_add_evento.Name = "button_petrobras_add_evento"
        Me.button_petrobras_add_evento.Size = New System.Drawing.Size(92, 13)
        Me.button_petrobras_add_evento.TabIndex = 39
        Me.button_petrobras_add_evento.TabStop = True
        Me.button_petrobras_add_evento.Text = "Adicionar novo"
        '
        'label_petrobras_evento
        '
        Me.label_petrobras_evento.AutoSize = True
        Me.label_petrobras_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_petrobras_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_petrobras_evento.Location = New System.Drawing.Point(13, 404)
        Me.label_petrobras_evento.Name = "label_petrobras_evento"
        Me.label_petrobras_evento.Size = New System.Drawing.Size(52, 13)
        Me.label_petrobras_evento.TabIndex = 38
        Me.label_petrobras_evento.Text = "Eventos"
        '
        'list_petrobras_evento
        '
        Me.list_petrobras_evento.AllColumns.Add(Me.OlvColumn53)
        Me.list_petrobras_evento.AllColumns.Add(Me.OlvColumn54)
        Me.list_petrobras_evento.AllColumns.Add(Me.OlvColumn55)
        Me.list_petrobras_evento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_petrobras_evento.BackColor = System.Drawing.Color.White
        Me.list_petrobras_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_petrobras_evento.CheckedAspectName = ""
        Me.list_petrobras_evento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn53, Me.OlvColumn54, Me.OlvColumn55})
        Me.list_petrobras_evento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_petrobras_evento.DataSource = Nothing
        Me.list_petrobras_evento.EmptyListMsg = "Nenhum evento informado"
        Me.list_petrobras_evento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_evento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_petrobras_evento.FullRowSelect = True
        Me.list_petrobras_evento.GridLines = True
        Me.list_petrobras_evento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_evento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_petrobras_evento.HeaderUsesThemes = False
        Me.list_petrobras_evento.HeaderWordWrap = True
        Me.list_petrobras_evento.Location = New System.Drawing.Point(10, 421)
        Me.list_petrobras_evento.Name = "list_petrobras_evento"
        Me.list_petrobras_evento.RowHeight = 15
        Me.list_petrobras_evento.ShowGroups = False
        Me.list_petrobras_evento.ShowImagesOnSubItems = True
        Me.list_petrobras_evento.Size = New System.Drawing.Size(872, 87)
        Me.list_petrobras_evento.TabIndex = 37
        Me.list_petrobras_evento.UseAlternatingBackColors = True
        Me.list_petrobras_evento.UseCompatibleStateImageBehavior = False
        Me.list_petrobras_evento.UseFiltering = True
        Me.list_petrobras_evento.UseHyperlinks = True
        Me.list_petrobras_evento.UseTranslucentSelection = True
        Me.list_petrobras_evento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn53
        '
        Me.OlvColumn53.AspectName = "PNOT_cd_nota"
        Me.OlvColumn53.Hideable = False
        Me.OlvColumn53.Hyperlink = True
        Me.OlvColumn53.IsEditable = False
        Me.OlvColumn53.Text = "Id"
        Me.OlvColumn53.Width = 40
        '
        'OlvColumn54
        '
        Me.OlvColumn54.AspectName = "PNOT_ds_nota"
        Me.OlvColumn54.FillsFreeSpace = True
        Me.OlvColumn54.Text = "Descrição"
        Me.OlvColumn54.Width = 600
        '
        'OlvColumn55
        '
        Me.OlvColumn55.AspectName = "PNOT_dt_ocorrencia"
        Me.OlvColumn55.AspectToStringFormat = "{0:d}"
        Me.OlvColumn55.FillsFreeSpace = True
        Me.OlvColumn55.Text = "Data Ocorrência"
        '
        'button_petrobras_add_documento
        '
        Me.button_petrobras_add_documento.AutoSize = True
        Me.button_petrobras_add_documento.Location = New System.Drawing.Point(790, 288)
        Me.button_petrobras_add_documento.Name = "button_petrobras_add_documento"
        Me.button_petrobras_add_documento.Size = New System.Drawing.Size(92, 13)
        Me.button_petrobras_add_documento.TabIndex = 36
        Me.button_petrobras_add_documento.TabStop = True
        Me.button_petrobras_add_documento.Text = "Adicionar novo"
        '
        'label_petrobras_documento
        '
        Me.label_petrobras_documento.AutoSize = True
        Me.label_petrobras_documento.BackColor = System.Drawing.Color.Transparent
        Me.label_petrobras_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_petrobras_documento.Location = New System.Drawing.Point(13, 288)
        Me.label_petrobras_documento.Name = "label_petrobras_documento"
        Me.label_petrobras_documento.Size = New System.Drawing.Size(120, 13)
        Me.label_petrobras_documento.TabIndex = 35
        Me.label_petrobras_documento.Text = "Outros Documentos"
        '
        'list_petrobras_documento
        '
        Me.list_petrobras_documento.AllColumns.Add(Me.OlvColumn56)
        Me.list_petrobras_documento.AllColumns.Add(Me.OlvColumn57)
        Me.list_petrobras_documento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_petrobras_documento.BackColor = System.Drawing.Color.White
        Me.list_petrobras_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_petrobras_documento.CheckedAspectName = ""
        Me.list_petrobras_documento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn56, Me.OlvColumn57})
        Me.list_petrobras_documento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_petrobras_documento.DataSource = Nothing
        Me.list_petrobras_documento.EmptyListMsg = "Nenhum documento anexado"
        Me.list_petrobras_documento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_documento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_petrobras_documento.FullRowSelect = True
        Me.list_petrobras_documento.GridLines = True
        Me.list_petrobras_documento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_documento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_petrobras_documento.HeaderUsesThemes = False
        Me.list_petrobras_documento.HeaderWordWrap = True
        Me.list_petrobras_documento.Location = New System.Drawing.Point(10, 305)
        Me.list_petrobras_documento.Name = "list_petrobras_documento"
        Me.list_petrobras_documento.RowHeight = 15
        Me.list_petrobras_documento.ShowGroups = False
        Me.list_petrobras_documento.ShowImagesOnSubItems = True
        Me.list_petrobras_documento.Size = New System.Drawing.Size(872, 96)
        Me.list_petrobras_documento.TabIndex = 34
        Me.list_petrobras_documento.UseAlternatingBackColors = True
        Me.list_petrobras_documento.UseCompatibleStateImageBehavior = False
        Me.list_petrobras_documento.UseFiltering = True
        Me.list_petrobras_documento.UseHyperlinks = True
        Me.list_petrobras_documento.UseTranslucentSelection = True
        Me.list_petrobras_documento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn56
        '
        Me.OlvColumn56.AspectName = "PDOC_nm_documento"
        Me.OlvColumn56.Hideable = False
        Me.OlvColumn56.Hyperlink = True
        Me.OlvColumn56.IsEditable = False
        Me.OlvColumn56.Text = "Nome"
        Me.OlvColumn56.Width = 300
        '
        'OlvColumn57
        '
        Me.OlvColumn57.AspectName = "PDOC_ds_documento"
        Me.OlvColumn57.Text = "Descrição"
        Me.OlvColumn57.Width = 600
        '
        'button_petrobras_add_titulo
        '
        Me.button_petrobras_add_titulo.AutoSize = True
        Me.button_petrobras_add_titulo.Location = New System.Drawing.Point(760, 7)
        Me.button_petrobras_add_titulo.Name = "button_petrobras_add_titulo"
        Me.button_petrobras_add_titulo.Size = New System.Drawing.Size(124, 13)
        Me.button_petrobras_add_titulo.TabIndex = 24
        Me.button_petrobras_add_titulo.TabStop = True
        Me.button_petrobras_add_titulo.Text = "Adicionar novo título"
        '
        'label_petrobras_titulo
        '
        Me.label_petrobras_titulo.AutoSize = True
        Me.label_petrobras_titulo.BackColor = System.Drawing.Color.Transparent
        Me.label_petrobras_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_petrobras_titulo.Location = New System.Drawing.Point(13, 6)
        Me.label_petrobras_titulo.Name = "label_petrobras_titulo"
        Me.label_petrobras_titulo.Size = New System.Drawing.Size(160, 13)
        Me.label_petrobras_titulo.TabIndex = 23
        Me.label_petrobras_titulo.Text = "Lista de Títulos informados"
        '
        'list_petrobras_titulo
        '
        Me.list_petrobras_titulo.AllColumns.Add(Me.OlvColumn58)
        Me.list_petrobras_titulo.AllColumns.Add(Me.OlvColumn59)
        Me.list_petrobras_titulo.AllColumns.Add(Me.OlvColumn60)
        Me.list_petrobras_titulo.AllColumns.Add(Me.OlvColumn61)
        Me.list_petrobras_titulo.AllColumns.Add(Me.OlvColumn62)
        Me.list_petrobras_titulo.AllColumns.Add(Me.OlvColumn63)
        Me.list_petrobras_titulo.AllColumns.Add(Me.OlvColumn64)
        Me.list_petrobras_titulo.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_petrobras_titulo.BackColor = System.Drawing.Color.White
        Me.list_petrobras_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_petrobras_titulo.CheckedAspectName = ""
        Me.list_petrobras_titulo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn58, Me.OlvColumn59, Me.OlvColumn60, Me.OlvColumn61, Me.OlvColumn62, Me.OlvColumn63, Me.OlvColumn64})
        Me.list_petrobras_titulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_petrobras_titulo.DataSource = Nothing
        Me.list_petrobras_titulo.EmptyListMsg = "Nenhm título registrado"
        Me.list_petrobras_titulo.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!)
        Me.list_petrobras_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_titulo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_petrobras_titulo.FullRowSelect = True
        Me.list_petrobras_titulo.GridLines = True
        Me.list_petrobras_titulo.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_petrobras_titulo.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_petrobras_titulo.HeaderUsesThemes = False
        Me.list_petrobras_titulo.HeaderWordWrap = True
        Me.list_petrobras_titulo.Location = New System.Drawing.Point(10, 23)
        Me.list_petrobras_titulo.Name = "list_petrobras_titulo"
        Me.list_petrobras_titulo.RowHeight = 15
        Me.list_petrobras_titulo.ShowGroups = False
        Me.list_petrobras_titulo.ShowImagesOnSubItems = True
        Me.list_petrobras_titulo.Size = New System.Drawing.Size(872, 89)
        Me.list_petrobras_titulo.TabIndex = 22
        Me.list_petrobras_titulo.UseAlternatingBackColors = True
        Me.list_petrobras_titulo.UseCompatibleStateImageBehavior = False
        Me.list_petrobras_titulo.UseFiltering = True
        Me.list_petrobras_titulo.UseHyperlinks = True
        Me.list_petrobras_titulo.UseTranslucentSelection = True
        Me.list_petrobras_titulo.View = System.Windows.Forms.View.Details
        '
        'OlvColumn58
        '
        Me.OlvColumn58.AspectName = "PTIT_nm_titulo"
        Me.OlvColumn58.Hideable = False
        Me.OlvColumn58.IsEditable = False
        Me.OlvColumn58.Text = "Número"
        Me.OlvColumn58.Width = 80
        '
        'OlvColumn59
        '
        Me.OlvColumn59.AspectName = "PTIT_ds_titulo"
        Me.OlvColumn59.FillsFreeSpace = True
        Me.OlvColumn59.Text = "Descrição"
        Me.OlvColumn59.Width = 240
        Me.OlvColumn59.WordWrap = True
        '
        'OlvColumn60
        '
        Me.OlvColumn60.AspectName = "TTIT_ds_tipo_titulo"
        Me.OlvColumn60.Text = "Tipo"
        Me.OlvColumn60.Width = 130
        Me.OlvColumn60.WordWrap = True
        '
        'OlvColumn61
        '
        Me.OlvColumn61.AspectName = "SITU_ds_situacao_titulo"
        Me.OlvColumn61.IsEditable = False
        Me.OlvColumn61.Text = "Situação"
        Me.OlvColumn61.Width = 130
        '
        'OlvColumn62
        '
        Me.OlvColumn62.AspectName = "PTIT_dt_publicacao"
        Me.OlvColumn62.AspectToStringFormat = "{0:d}"
        Me.OlvColumn62.Text = "Data Publicação"
        Me.OlvColumn62.Width = 100
        Me.OlvColumn62.WordWrap = True
        '
        'OlvColumn63
        '
        Me.OlvColumn63.AspectName = "PTIT_dt_vencimento"
        Me.OlvColumn63.AspectToStringFormat = "{0:d}"
        Me.OlvColumn63.Text = "Data Vencimento"
        Me.OlvColumn63.Width = 100
        Me.OlvColumn63.WordWrap = True
        '
        'OlvColumn64
        '
        Me.OlvColumn64.AspectName = "PTIT_ds_nome_documento"
        Me.OlvColumn64.FillsFreeSpace = True
        Me.OlvColumn64.Hyperlink = True
        Me.OlvColumn64.Text = "Doc.Principal"
        '
        'tab_prefeitura
        '
        Me.tab_prefeitura.AutoScroll = True
        Me.tab_prefeitura.Controls.Add(Me.A1Panel10)
        Me.tab_prefeitura.Location = New System.Drawing.Point(4, 22)
        Me.tab_prefeitura.Name = "tab_prefeitura"
        Me.tab_prefeitura.Size = New System.Drawing.Size(910, 294)
        Me.tab_prefeitura.TabIndex = 10
        Me.tab_prefeitura.Text = "Prefeituras"
        Me.tab_prefeitura.UseVisualStyleBackColor = True
        '
        'A1Panel10
        '
        Me.A1Panel10.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel10.Controls.Add(Me.button_prefeitura_add_info)
        Me.A1Panel10.Controls.Add(Me.label_prefeitura_info)
        Me.A1Panel10.Controls.Add(Me.list_prefeitura_info)
        Me.A1Panel10.Controls.Add(Me.button_prefeitura_add_evento)
        Me.A1Panel10.Controls.Add(Me.label_prefeitura_evento)
        Me.A1Panel10.Controls.Add(Me.list_prefeitura_evento)
        Me.A1Panel10.Controls.Add(Me.button_prefeitura_add_documento)
        Me.A1Panel10.Controls.Add(Me.label_prefeitura_documento)
        Me.A1Panel10.Controls.Add(Me.list_prefeitura_documento)
        Me.A1Panel10.Controls.Add(Me.button_prefeitura_add_titulo)
        Me.A1Panel10.Controls.Add(Me.label_prefeitura_titulo)
        Me.A1Panel10.Controls.Add(Me.list_prefeitura_titulo)
        Me.A1Panel10.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel10.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel10.Image = Nothing
        Me.A1Panel10.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel10.Location = New System.Drawing.Point(2, 3)
        Me.A1Panel10.Name = "A1Panel10"
        Me.A1Panel10.Size = New System.Drawing.Size(903, 522)
        Me.A1Panel10.TabIndex = 18
        '
        'button_prefeitura_add_info
        '
        Me.button_prefeitura_add_info.AutoSize = True
        Me.button_prefeitura_add_info.Location = New System.Drawing.Point(785, 123)
        Me.button_prefeitura_add_info.Name = "button_prefeitura_add_info"
        Me.button_prefeitura_add_info.Size = New System.Drawing.Size(92, 13)
        Me.button_prefeitura_add_info.TabIndex = 51
        Me.button_prefeitura_add_info.TabStop = True
        Me.button_prefeitura_add_info.Text = "Adicionar novo"
        '
        'label_prefeitura_info
        '
        Me.label_prefeitura_info.AutoSize = True
        Me.label_prefeitura_info.BackColor = System.Drawing.Color.Transparent
        Me.label_prefeitura_info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_prefeitura_info.Location = New System.Drawing.Point(7, 123)
        Me.label_prefeitura_info.Name = "label_prefeitura_info"
        Me.label_prefeitura_info.Size = New System.Drawing.Size(181, 13)
        Me.label_prefeitura_info.TabIndex = 50
        Me.label_prefeitura_info.Text = "Informações Complementares"
        '
        'list_prefeitura_info
        '
        Me.list_prefeitura_info.AllColumns.Add(Me.OlvColumn92)
        Me.list_prefeitura_info.AllColumns.Add(Me.OlvColumn93)
        Me.list_prefeitura_info.AllColumns.Add(Me.OlvColumn94)
        Me.list_prefeitura_info.AllColumns.Add(Me.OlvColumn95)
        Me.list_prefeitura_info.AllColumns.Add(Me.OlvColumn96)
        Me.list_prefeitura_info.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_prefeitura_info.BackColor = System.Drawing.Color.White
        Me.list_prefeitura_info.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_prefeitura_info.CheckedAspectName = ""
        Me.list_prefeitura_info.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn92, Me.OlvColumn93, Me.OlvColumn94, Me.OlvColumn95, Me.OlvColumn96})
        Me.list_prefeitura_info.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_prefeitura_info.DataSource = Nothing
        Me.list_prefeitura_info.EmptyListMsg = "Nenhuma informação adicionada"
        Me.list_prefeitura_info.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_info.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_info.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_prefeitura_info.FullRowSelect = True
        Me.list_prefeitura_info.GridLines = True
        Me.list_prefeitura_info.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_info.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_prefeitura_info.HeaderUsesThemes = False
        Me.list_prefeitura_info.HeaderWordWrap = True
        Me.list_prefeitura_info.Location = New System.Drawing.Point(10, 139)
        Me.list_prefeitura_info.Name = "list_prefeitura_info"
        Me.list_prefeitura_info.RowHeight = 15
        Me.list_prefeitura_info.ShowGroups = False
        Me.list_prefeitura_info.ShowImagesOnSubItems = True
        Me.list_prefeitura_info.Size = New System.Drawing.Size(872, 137)
        Me.list_prefeitura_info.TabIndex = 49
        Me.list_prefeitura_info.UseAlternatingBackColors = True
        Me.list_prefeitura_info.UseCompatibleStateImageBehavior = False
        Me.list_prefeitura_info.UseFiltering = True
        Me.list_prefeitura_info.UseHyperlinks = True
        Me.list_prefeitura_info.UseTranslucentSelection = True
        Me.list_prefeitura_info.View = System.Windows.Forms.View.Details
        '
        'OlvColumn92
        '
        Me.OlvColumn92.AspectName = "PINF_cd_info"
        Me.OlvColumn92.Text = "Id"
        Me.OlvColumn92.Width = 30
        '
        'OlvColumn93
        '
        Me.OlvColumn93.AspectName = "TINF_nm_tipo_info"
        Me.OlvColumn93.Text = "Tipo"
        Me.OlvColumn93.Width = 100
        '
        'OlvColumn94
        '
        Me.OlvColumn94.AspectName = "PINF_ds_info"
        Me.OlvColumn94.Text = "Descrição"
        Me.OlvColumn94.Width = 300
        '
        'OlvColumn95
        '
        Me.OlvColumn95.AspectName = "SINF_ds_situacao_info"
        Me.OlvColumn95.Text = "Situação"
        Me.OlvColumn95.Width = 200
        '
        'OlvColumn96
        '
        Me.OlvColumn96.AspectName = "PINF_ds_local_documento"
        Me.OlvColumn96.FillsFreeSpace = True
        Me.OlvColumn96.Hideable = False
        Me.OlvColumn96.Hyperlink = True
        Me.OlvColumn96.IsEditable = False
        Me.OlvColumn96.Text = "Documento Anexo"
        '
        'button_prefeitura_add_evento
        '
        Me.button_prefeitura_add_evento.AutoSize = True
        Me.button_prefeitura_add_evento.Location = New System.Drawing.Point(790, 404)
        Me.button_prefeitura_add_evento.Name = "button_prefeitura_add_evento"
        Me.button_prefeitura_add_evento.Size = New System.Drawing.Size(92, 13)
        Me.button_prefeitura_add_evento.TabIndex = 39
        Me.button_prefeitura_add_evento.TabStop = True
        Me.button_prefeitura_add_evento.Text = "Adicionar novo"
        '
        'label_prefeitura_evento
        '
        Me.label_prefeitura_evento.AutoSize = True
        Me.label_prefeitura_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_prefeitura_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_prefeitura_evento.Location = New System.Drawing.Point(13, 404)
        Me.label_prefeitura_evento.Name = "label_prefeitura_evento"
        Me.label_prefeitura_evento.Size = New System.Drawing.Size(52, 13)
        Me.label_prefeitura_evento.TabIndex = 38
        Me.label_prefeitura_evento.Text = "Eventos"
        '
        'list_prefeitura_evento
        '
        Me.list_prefeitura_evento.AllColumns.Add(Me.OlvColumn65)
        Me.list_prefeitura_evento.AllColumns.Add(Me.OlvColumn66)
        Me.list_prefeitura_evento.AllColumns.Add(Me.OlvColumn67)
        Me.list_prefeitura_evento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_prefeitura_evento.BackColor = System.Drawing.Color.White
        Me.list_prefeitura_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_prefeitura_evento.CheckedAspectName = ""
        Me.list_prefeitura_evento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn65, Me.OlvColumn66, Me.OlvColumn67})
        Me.list_prefeitura_evento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_prefeitura_evento.DataSource = Nothing
        Me.list_prefeitura_evento.EmptyListMsg = "Nenhum evento informado"
        Me.list_prefeitura_evento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_evento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_prefeitura_evento.FullRowSelect = True
        Me.list_prefeitura_evento.GridLines = True
        Me.list_prefeitura_evento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_evento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_prefeitura_evento.HeaderUsesThemes = False
        Me.list_prefeitura_evento.HeaderWordWrap = True
        Me.list_prefeitura_evento.Location = New System.Drawing.Point(10, 421)
        Me.list_prefeitura_evento.Name = "list_prefeitura_evento"
        Me.list_prefeitura_evento.RowHeight = 15
        Me.list_prefeitura_evento.ShowGroups = False
        Me.list_prefeitura_evento.ShowImagesOnSubItems = True
        Me.list_prefeitura_evento.Size = New System.Drawing.Size(872, 87)
        Me.list_prefeitura_evento.TabIndex = 37
        Me.list_prefeitura_evento.UseAlternatingBackColors = True
        Me.list_prefeitura_evento.UseCompatibleStateImageBehavior = False
        Me.list_prefeitura_evento.UseFiltering = True
        Me.list_prefeitura_evento.UseHyperlinks = True
        Me.list_prefeitura_evento.UseTranslucentSelection = True
        Me.list_prefeitura_evento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn65
        '
        Me.OlvColumn65.AspectName = "PNOT_cd_nota"
        Me.OlvColumn65.Hideable = False
        Me.OlvColumn65.Hyperlink = True
        Me.OlvColumn65.IsEditable = False
        Me.OlvColumn65.Text = "Id"
        Me.OlvColumn65.Width = 40
        '
        'OlvColumn66
        '
        Me.OlvColumn66.AspectName = "PNOT_ds_nota"
        Me.OlvColumn66.FillsFreeSpace = True
        Me.OlvColumn66.Text = "Descrição"
        Me.OlvColumn66.Width = 600
        '
        'OlvColumn67
        '
        Me.OlvColumn67.AspectName = "PNOT_dt_ocorrencia"
        Me.OlvColumn67.AspectToStringFormat = "{0:d}"
        Me.OlvColumn67.FillsFreeSpace = True
        Me.OlvColumn67.Text = "Data Ocorrência"
        '
        'button_prefeitura_add_documento
        '
        Me.button_prefeitura_add_documento.AutoSize = True
        Me.button_prefeitura_add_documento.Location = New System.Drawing.Point(790, 288)
        Me.button_prefeitura_add_documento.Name = "button_prefeitura_add_documento"
        Me.button_prefeitura_add_documento.Size = New System.Drawing.Size(92, 13)
        Me.button_prefeitura_add_documento.TabIndex = 36
        Me.button_prefeitura_add_documento.TabStop = True
        Me.button_prefeitura_add_documento.Text = "Adicionar novo"
        '
        'label_prefeitura_documento
        '
        Me.label_prefeitura_documento.AutoSize = True
        Me.label_prefeitura_documento.BackColor = System.Drawing.Color.Transparent
        Me.label_prefeitura_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_prefeitura_documento.Location = New System.Drawing.Point(13, 288)
        Me.label_prefeitura_documento.Name = "label_prefeitura_documento"
        Me.label_prefeitura_documento.Size = New System.Drawing.Size(120, 13)
        Me.label_prefeitura_documento.TabIndex = 35
        Me.label_prefeitura_documento.Text = "Outros Documentos"
        '
        'list_prefeitura_documento
        '
        Me.list_prefeitura_documento.AllColumns.Add(Me.OlvColumn68)
        Me.list_prefeitura_documento.AllColumns.Add(Me.OlvColumn69)
        Me.list_prefeitura_documento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_prefeitura_documento.BackColor = System.Drawing.Color.White
        Me.list_prefeitura_documento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_prefeitura_documento.CheckedAspectName = ""
        Me.list_prefeitura_documento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn68, Me.OlvColumn69})
        Me.list_prefeitura_documento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_prefeitura_documento.DataSource = Nothing
        Me.list_prefeitura_documento.EmptyListMsg = "Nenhum documento anexado"
        Me.list_prefeitura_documento.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_documento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_prefeitura_documento.FullRowSelect = True
        Me.list_prefeitura_documento.GridLines = True
        Me.list_prefeitura_documento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_documento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_prefeitura_documento.HeaderUsesThemes = False
        Me.list_prefeitura_documento.HeaderWordWrap = True
        Me.list_prefeitura_documento.Location = New System.Drawing.Point(10, 305)
        Me.list_prefeitura_documento.Name = "list_prefeitura_documento"
        Me.list_prefeitura_documento.RowHeight = 15
        Me.list_prefeitura_documento.ShowGroups = False
        Me.list_prefeitura_documento.ShowImagesOnSubItems = True
        Me.list_prefeitura_documento.Size = New System.Drawing.Size(872, 96)
        Me.list_prefeitura_documento.TabIndex = 34
        Me.list_prefeitura_documento.UseAlternatingBackColors = True
        Me.list_prefeitura_documento.UseCompatibleStateImageBehavior = False
        Me.list_prefeitura_documento.UseFiltering = True
        Me.list_prefeitura_documento.UseHyperlinks = True
        Me.list_prefeitura_documento.UseTranslucentSelection = True
        Me.list_prefeitura_documento.View = System.Windows.Forms.View.Details
        '
        'OlvColumn68
        '
        Me.OlvColumn68.AspectName = "PDOC_nm_documento"
        Me.OlvColumn68.Hideable = False
        Me.OlvColumn68.Hyperlink = True
        Me.OlvColumn68.IsEditable = False
        Me.OlvColumn68.Text = "Nome"
        Me.OlvColumn68.Width = 300
        '
        'OlvColumn69
        '
        Me.OlvColumn69.AspectName = "PDOC_ds_documento"
        Me.OlvColumn69.Text = "Descrição"
        Me.OlvColumn69.Width = 600
        '
        'button_prefeitura_add_titulo
        '
        Me.button_prefeitura_add_titulo.AutoSize = True
        Me.button_prefeitura_add_titulo.Location = New System.Drawing.Point(760, 7)
        Me.button_prefeitura_add_titulo.Name = "button_prefeitura_add_titulo"
        Me.button_prefeitura_add_titulo.Size = New System.Drawing.Size(124, 13)
        Me.button_prefeitura_add_titulo.TabIndex = 24
        Me.button_prefeitura_add_titulo.TabStop = True
        Me.button_prefeitura_add_titulo.Text = "Adicionar novo título"
        '
        'label_prefeitura_titulo
        '
        Me.label_prefeitura_titulo.AutoSize = True
        Me.label_prefeitura_titulo.BackColor = System.Drawing.Color.Transparent
        Me.label_prefeitura_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_prefeitura_titulo.Location = New System.Drawing.Point(13, 6)
        Me.label_prefeitura_titulo.Name = "label_prefeitura_titulo"
        Me.label_prefeitura_titulo.Size = New System.Drawing.Size(160, 13)
        Me.label_prefeitura_titulo.TabIndex = 23
        Me.label_prefeitura_titulo.Text = "Lista de Títulos informados"
        '
        'list_prefeitura_titulo
        '
        Me.list_prefeitura_titulo.AllColumns.Add(Me.OlvColumn70)
        Me.list_prefeitura_titulo.AllColumns.Add(Me.OlvColumn71)
        Me.list_prefeitura_titulo.AllColumns.Add(Me.OlvColumn72)
        Me.list_prefeitura_titulo.AllColumns.Add(Me.OlvColumn73)
        Me.list_prefeitura_titulo.AllColumns.Add(Me.OlvColumn74)
        Me.list_prefeitura_titulo.AllColumns.Add(Me.OlvColumn75)
        Me.list_prefeitura_titulo.AllColumns.Add(Me.OlvColumn76)
        Me.list_prefeitura_titulo.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_prefeitura_titulo.BackColor = System.Drawing.Color.White
        Me.list_prefeitura_titulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_prefeitura_titulo.CheckedAspectName = ""
        Me.list_prefeitura_titulo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.OlvColumn70, Me.OlvColumn71, Me.OlvColumn72, Me.OlvColumn73, Me.OlvColumn74, Me.OlvColumn75, Me.OlvColumn76})
        Me.list_prefeitura_titulo.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_prefeitura_titulo.DataSource = Nothing
        Me.list_prefeitura_titulo.EmptyListMsg = "Nenhm título registrado"
        Me.list_prefeitura_titulo.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!)
        Me.list_prefeitura_titulo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_titulo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_prefeitura_titulo.FullRowSelect = True
        Me.list_prefeitura_titulo.GridLines = True
        Me.list_prefeitura_titulo.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_prefeitura_titulo.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_prefeitura_titulo.HeaderUsesThemes = False
        Me.list_prefeitura_titulo.HeaderWordWrap = True
        Me.list_prefeitura_titulo.Location = New System.Drawing.Point(10, 23)
        Me.list_prefeitura_titulo.Name = "list_prefeitura_titulo"
        Me.list_prefeitura_titulo.RowHeight = 15
        Me.list_prefeitura_titulo.ShowGroups = False
        Me.list_prefeitura_titulo.ShowImagesOnSubItems = True
        Me.list_prefeitura_titulo.Size = New System.Drawing.Size(872, 89)
        Me.list_prefeitura_titulo.TabIndex = 22
        Me.list_prefeitura_titulo.UseAlternatingBackColors = True
        Me.list_prefeitura_titulo.UseCompatibleStateImageBehavior = False
        Me.list_prefeitura_titulo.UseFiltering = True
        Me.list_prefeitura_titulo.UseHyperlinks = True
        Me.list_prefeitura_titulo.UseTranslucentSelection = True
        Me.list_prefeitura_titulo.View = System.Windows.Forms.View.Details
        '
        'OlvColumn70
        '
        Me.OlvColumn70.AspectName = "PTIT_nm_titulo"
        Me.OlvColumn70.Hideable = False
        Me.OlvColumn70.IsEditable = False
        Me.OlvColumn70.Text = "Número"
        Me.OlvColumn70.Width = 80
        '
        'OlvColumn71
        '
        Me.OlvColumn71.AspectName = "PTIT_ds_titulo"
        Me.OlvColumn71.FillsFreeSpace = True
        Me.OlvColumn71.Text = "Descrição"
        Me.OlvColumn71.Width = 240
        Me.OlvColumn71.WordWrap = True
        '
        'OlvColumn72
        '
        Me.OlvColumn72.AspectName = "TTIT_ds_tipo_titulo"
        Me.OlvColumn72.Text = "Tipo"
        Me.OlvColumn72.Width = 130
        Me.OlvColumn72.WordWrap = True
        '
        'OlvColumn73
        '
        Me.OlvColumn73.AspectName = "SITU_ds_situacao_titulo"
        Me.OlvColumn73.IsEditable = False
        Me.OlvColumn73.Text = "Situação"
        Me.OlvColumn73.Width = 130
        '
        'OlvColumn74
        '
        Me.OlvColumn74.AspectName = "PTIT_dt_publicacao"
        Me.OlvColumn74.AspectToStringFormat = "{0:d}"
        Me.OlvColumn74.Text = "Data Publicação"
        Me.OlvColumn74.Width = 100
        Me.OlvColumn74.WordWrap = True
        '
        'OlvColumn75
        '
        Me.OlvColumn75.AspectName = "PTIT_dt_vencimento"
        Me.OlvColumn75.AspectToStringFormat = "{0:d}"
        Me.OlvColumn75.Text = "Data Vencimento"
        Me.OlvColumn75.Width = 100
        Me.OlvColumn75.WordWrap = True
        '
        'OlvColumn76
        '
        Me.OlvColumn76.AspectName = "PTIT_ds_nome_documento"
        Me.OlvColumn76.FillsFreeSpace = True
        Me.OlvColumn76.Hyperlink = True
        Me.OlvColumn76.Text = "Doc.Principal"
        '
        'panel_command
        '
        Me.panel_command.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.panel_command.BorderColor = System.Drawing.Color.Silver
        Me.panel_command.Controls.Add(Me.button_close)
        Me.panel_command.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.panel_command.GradientStartColor = System.Drawing.Color.White
        Me.panel_command.Image = Nothing
        Me.panel_command.ImageLocation = New System.Drawing.Point(4, 4)
        Me.panel_command.Location = New System.Drawing.Point(12, 340)
        Me.panel_command.Name = "panel_command"
        Me.panel_command.Size = New System.Drawing.Size(912, 41)
        Me.panel_command.TabIndex = 15
        '
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(786, 5)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(103, 28)
        Me.button_close.TabIndex = 3
        Me.button_close.Text = "Fechar"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_close.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'combo_prioridade
        '
        Me.combo_prioridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_prioridade.FormattingEnabled = True
        Me.combo_prioridade.Location = New System.Drawing.Point(670, 213)
        Me.combo_prioridade.Name = "combo_prioridade"
        Me.combo_prioridade.Size = New System.Drawing.Size(190, 21)
        Me.combo_prioridade.TabIndex = 55
        '
        'label_prioridade
        '
        Me.label_prioridade.AutoSize = True
        Me.label_prioridade.BackColor = System.Drawing.Color.Transparent
        Me.label_prioridade.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_prioridade.Location = New System.Drawing.Point(599, 214)
        Me.label_prioridade.Name = "label_prioridade"
        Me.label_prioridade.Size = New System.Drawing.Size(65, 13)
        Me.label_prioridade.TabIndex = 56
        Me.label_prioridade.Text = "Prioridade"
        '
        'form_processo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(940, 386)
        Me.Controls.Add(Me.panel_command)
        Me.Controls.Add(Me.tab_main)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_processo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Processos Minerários"
        Me.tab_main.ResumeLayout(False)
        Me.tab_principal.ResumeLayout(False)
        Me.panel_details.ResumeLayout(False)
        Me.panel_details.PerformLayout()
        Me.panel_main.ResumeLayout(False)
        Me.tab_alerta.ResumeLayout(False)
        Me.A1Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_operador.ResumeLayout(False)
        Me.A1Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_tip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_operador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_evento.ResumeLayout(False)
        Me.A1Panel4.ResumeLayout(False)
        Me.A1Panel4.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_evento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_dnpm.ResumeLayout(False)
        Me.A1Panel5.ResumeLayout(False)
        Me.A1Panel5.PerformLayout()
        CType(Me.list_dnpm_documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_dnpm_condicao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_dnpm_associado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_dnpm_municipio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_dnpm_substancia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_dnpm_titulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_cetesb.ResumeLayout(False)
        Me.A1Panel6.ResumeLayout(False)
        Me.A1Panel6.PerformLayout()
        CType(Me.list_cetesb_mp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_cetesb_evento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_cetesb_documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_cetesb_titulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_daee.ResumeLayout(False)
        Me.A1Panel7.ResumeLayout(False)
        Me.A1Panel7.PerformLayout()
        CType(Me.list_daee_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_daee_evento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_daee_documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_daee_titulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_icmbio.ResumeLayout(False)
        Me.A1Panel8.ResumeLayout(False)
        Me.A1Panel8.PerformLayout()
        CType(Me.list_icmbio_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_icmbio_evento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_icmbio_documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_icmbio_titulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_petrobras.ResumeLayout(False)
        Me.A1Panel9.ResumeLayout(False)
        Me.A1Panel9.PerformLayout()
        CType(Me.list_petrobras_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_petrobras_evento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_petrobras_documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_petrobras_titulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_prefeitura.ResumeLayout(False)
        Me.A1Panel10.ResumeLayout(False)
        Me.A1Panel10.PerformLayout()
        CType(Me.list_prefeitura_info, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_prefeitura_evento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_prefeitura_documento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_prefeitura_titulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_command.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents tab_main As System.Windows.Forms.TabControl
    Friend WithEvents tab_principal As System.Windows.Forms.TabPage
    Friend WithEvents tab_alerta As System.Windows.Forms.TabPage
    Friend WithEvents tab_evento As System.Windows.Forms.TabPage
    Friend WithEvents panel_details As Owf.Controls.A1Panel
    Friend WithEvents link_processo As System.Windows.Forms.LinkLabel
    Friend WithEvents combo_uf As System.Windows.Forms.ComboBox
    Friend WithEvents label_uf As System.Windows.Forms.Label
    Friend WithEvents text_link As System.Windows.Forms.TextBox
    Friend WithEvents label_link As System.Windows.Forms.Label
    Friend WithEvents label_id As System.Windows.Forms.Label
    Friend WithEvents text_id As System.Windows.Forms.TextBox
    Friend WithEvents text_uso As System.Windows.Forms.TextBox
    Friend WithEvents label_uso As System.Windows.Forms.Label
    Friend WithEvents text_area As System.Windows.Forms.TextBox
    Friend WithEvents label_area As System.Windows.Forms.Label
    Friend WithEvents text_substancia As System.Windows.Forms.TextBox
    Friend WithEvents label_substancia As System.Windows.Forms.Label
    Friend WithEvents label_ultimo_evento As System.Windows.Forms.Label
    Friend WithEvents text_ultimo_evento As System.Windows.Forms.TextBox
    Friend WithEvents combo_fase As System.Windows.Forms.ComboBox
    Friend WithEvents text_ano As System.Windows.Forms.TextBox
    Friend WithEvents label_fase As System.Windows.Forms.Label
    Friend WithEvents label_ano As System.Windows.Forms.Label
    Friend WithEvents label_titular As System.Windows.Forms.Label
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents text_name As System.Windows.Forms.TextBox
    Friend WithEvents text_num As System.Windows.Forms.TextBox
    Friend WithEvents label_num As System.Windows.Forms.Label
    Friend WithEvents combo_titular As System.Windows.Forms.ComboBox
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents label_alerta As System.Windows.Forms.Label
    Friend WithEvents list_alerta As BrightIdeasSoftware.DataListView
    Friend WithEvents column_alerta_name As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_alerta_status As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_del As System.Windows.Forms.Button
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents button_alerta_confirm As System.Windows.Forms.Button
    Friend WithEvents tab_operador As System.Windows.Forms.TabPage
    Friend WithEvents A1Panel3 As Owf.Controls.A1Panel
    Friend WithEvents button_operador_confirm As System.Windows.Forms.Button
    Friend WithEvents label_operador As System.Windows.Forms.Label
    Friend WithEvents list_operador As BrightIdeasSoftware.DataListView
    Friend WithEvents column_operador_name As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_operador_email As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_operador_flag1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_operador_flag2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_operador_code As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_alerta_fase As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_alerta_evento As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents label_tip_alerta1 As System.Windows.Forms.Label
    Friend WithEvents label_tip_alerta2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents label_tip_operador1 As System.Windows.Forms.Label
    Friend WithEvents label_tip_operador2 As System.Windows.Forms.Label
    Friend WithEvents pic_tip As System.Windows.Forms.PictureBox
    Friend WithEvents button_operador_refresh As System.Windows.Forms.Button
    Friend WithEvents button_alerta_refresh As System.Windows.Forms.Button
    Friend WithEvents A1Panel4 As Owf.Controls.A1Panel
    Friend WithEvents button_evento_refresh As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents label_evento_tip1 As System.Windows.Forms.Label
    Friend WithEvents label_evento_tip2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents button_evento_confirm As System.Windows.Forms.Button
    Friend WithEvents label_evento As System.Windows.Forms.Label
    Friend WithEvents list_evento As BrightIdeasSoftware.DataListView
    Friend WithEvents column_evento_code As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_evento_desc As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_evento_date As BrightIdeasSoftware.OLVColumn
    Friend WithEvents tab_dnpm As System.Windows.Forms.TabPage
    Friend WithEvents tab_cetesb As System.Windows.Forms.TabPage
    Friend WithEvents tab_daee As System.Windows.Forms.TabPage
    Friend WithEvents tab_icmbio As System.Windows.Forms.TabPage
    Friend WithEvents tab_petrobras As System.Windows.Forms.TabPage
    Friend WithEvents tab_prefeitura As System.Windows.Forms.TabPage
    Friend WithEvents A1Panel5 As Owf.Controls.A1Panel
    Friend WithEvents label_dnpm_titulo As System.Windows.Forms.Label
    Friend WithEvents list_dnpm_titulo As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn1 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn2 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn3 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn4 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn5 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn6 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_dnpm_add_titulo As System.Windows.Forms.LinkLabel
    Friend WithEvents button_dnpm_add_substancia As System.Windows.Forms.LinkLabel
    Friend WithEvents label_dnpm_substancia As System.Windows.Forms.Label
    Friend WithEvents list_dnpm_substancia As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn7 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn8 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn11 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn12 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn13 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_dnpm_add_municipio As System.Windows.Forms.LinkLabel
    Friend WithEvents label_dnpm_municipio As System.Windows.Forms.Label
    Friend WithEvents list_dnpm_municipio As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn9 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_dnpm_add_associado As System.Windows.Forms.LinkLabel
    Friend WithEvents label_associado As System.Windows.Forms.Label
    Friend WithEvents list_dnpm_associado As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn10 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_dnpm_add_condicao As System.Windows.Forms.LinkLabel
    Friend WithEvents label_condicao As System.Windows.Forms.Label
    Friend WithEvents list_dnpm_condicao As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn14 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn15 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn16 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents A1Panel6 As Owf.Controls.A1Panel
    Friend WithEvents button_cetesb_add_documento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_cetesb_documento As System.Windows.Forms.Label
    Friend WithEvents list_cetesb_documento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn17 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn18 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_cetesb_add_titulo As System.Windows.Forms.LinkLabel
    Friend WithEvents label_cetesb_titulo As System.Windows.Forms.Label
    Friend WithEvents list_cetesb_titulo As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn27 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn28 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn29 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn30 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn31 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn32 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn20 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_cetesb_add_evento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_cetesb_evento As System.Windows.Forms.Label
    Friend WithEvents list_cetesb_evento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn19 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn21 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn22 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents A1Panel7 As Owf.Controls.A1Panel
    Friend WithEvents button_daee_add_evento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_daee_evento As System.Windows.Forms.Label
    Friend WithEvents list_daee_evento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn23 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn24 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn25 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_daee_add_documento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_daee_documento As System.Windows.Forms.Label
    Friend WithEvents list_daee_documento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn26 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn33 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_daee_add_titulo As System.Windows.Forms.LinkLabel
    Friend WithEvents label_daee_titulo As System.Windows.Forms.Label
    Friend WithEvents list_daee_titulo As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn34 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn35 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn36 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn37 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn38 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn39 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn40 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents A1Panel8 As Owf.Controls.A1Panel
    Friend WithEvents button_icmbio_add_evento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_icmbio_evento As System.Windows.Forms.Label
    Friend WithEvents list_icmbio_evento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn41 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn42 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn43 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_icmbio_add_documento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_icmbio_documento As System.Windows.Forms.Label
    Friend WithEvents list_icmbio_documento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn44 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn45 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_icmbio_add_titulo As System.Windows.Forms.LinkLabel
    Friend WithEvents label_icmbio_titulo As System.Windows.Forms.Label
    Friend WithEvents list_icmbio_titulo As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn46 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn47 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn48 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn49 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn50 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn51 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn52 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents A1Panel9 As Owf.Controls.A1Panel
    Friend WithEvents button_petrobras_add_evento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_petrobras_evento As System.Windows.Forms.Label
    Friend WithEvents list_petrobras_evento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn53 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn54 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn55 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_petrobras_add_documento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_petrobras_documento As System.Windows.Forms.Label
    Friend WithEvents list_petrobras_documento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn56 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn57 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_petrobras_add_titulo As System.Windows.Forms.LinkLabel
    Friend WithEvents label_petrobras_titulo As System.Windows.Forms.Label
    Friend WithEvents list_petrobras_titulo As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn58 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn59 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn60 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn61 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn62 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn63 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn64 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents A1Panel10 As Owf.Controls.A1Panel
    Friend WithEvents button_prefeitura_add_evento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_prefeitura_evento As System.Windows.Forms.Label
    Friend WithEvents list_prefeitura_evento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn65 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn66 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn67 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_prefeitura_add_documento As System.Windows.Forms.LinkLabel
    Friend WithEvents label_prefeitura_documento As System.Windows.Forms.Label
    Friend WithEvents list_prefeitura_documento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn68 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn69 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_prefeitura_add_titulo As System.Windows.Forms.LinkLabel
    Friend WithEvents label_prefeitura_titulo As System.Windows.Forms.Label
    Friend WithEvents list_prefeitura_titulo As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn70 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn71 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn72 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn73 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn74 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn75 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn76 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_daee_add_info As System.Windows.Forms.LinkLabel
    Friend WithEvents label_daee_info As System.Windows.Forms.Label
    Friend WithEvents list_daee_info As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn77 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn78 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn79 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn80 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn81 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_icmbio_add_info As System.Windows.Forms.LinkLabel
    Friend WithEvents label_icmbio_info As System.Windows.Forms.Label
    Friend WithEvents list_icmbio_info As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn82 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn83 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn84 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn85 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn86 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_petrobras_add_info As System.Windows.Forms.LinkLabel
    Friend WithEvents label_petrobras_info As System.Windows.Forms.Label
    Friend WithEvents list_petrobras_info As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn87 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn88 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn89 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn90 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn91 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_prefeitura_add_info As System.Windows.Forms.LinkLabel
    Friend WithEvents label_prefeitura_info As System.Windows.Forms.Label
    Friend WithEvents list_prefeitura_info As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn92 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn93 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn94 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn95 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn96 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn97 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn98 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn99 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn100 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents label_cetesb_atividade As System.Windows.Forms.Label
    Friend WithEvents label_cetesb_cadastro As System.Windows.Forms.Label
    Friend WithEvents text_cetesb_atividade As System.Windows.Forms.TextBox
    Friend WithEvents text_cetesb_cadastro As System.Windows.Forms.TextBox
    Friend WithEvents button_cetesb_confirm As System.Windows.Forms.LinkLabel
    Friend WithEvents button_cetesb_add_mp As System.Windows.Forms.LinkLabel
    Friend WithEvents label_cetesb_mp As System.Windows.Forms.Label
    Friend WithEvents list_cetesb_mp As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn101 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn103 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn104 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn105 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_report As System.Windows.Forms.Button
    Friend WithEvents OlvColumn102 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn106 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_dnpm_add_documento As System.Windows.Forms.LinkLabel
    Friend WithEvents labl_dnpm_documento As System.Windows.Forms.Label
    Friend WithEvents list_dnpm_documento As BrightIdeasSoftware.DataListView
    Friend WithEvents OlvColumn107 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents OlvColumn108 As BrightIdeasSoftware.OLVColumn
    Friend WithEvents panel_main As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents label_progresso As System.Windows.Forms.Label
    Friend WithEvents pbar_down As System.Windows.Forms.ProgressBar
    Friend WithEvents panel_command As Owf.Controls.A1Panel
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents button_mapa As System.Windows.Forms.Button
    Friend WithEvents button_add_evento As System.Windows.Forms.LinkLabel
    Friend WithEvents combo_prioridade As System.Windows.Forms.ComboBox
    Friend WithEvents label_prioridade As System.Windows.Forms.Label
End Class
