<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_alerta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_alerta))
        Dim HeaderStateStyle4 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim HeaderStateStyle5 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim HeaderStateStyle6 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Me.list_alerta = New BrightIdeasSoftware.DataListView
        Me.column_name = New BrightIdeasSoftware.OLVColumn
        Me.imgListAlerta = New System.Windows.Forms.ImageList(Me.components)
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle
        Me.button_add = New System.Windows.Forms.Button
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.button_close = New System.Windows.Forms.Button
        Me.A1Panel2 = New Owf.Controls.A1Panel
        Me.label_tip1 = New System.Windows.Forms.Label
        Me.A1Panel3 = New Owf.Controls.A1Panel
        Me.tab_main = New System.Windows.Forms.TabControl
        Me.tab_dados = New System.Windows.Forms.TabPage
        Me.panel_details = New Owf.Controls.A1Panel
        Me.combo_flag_geral2 = New System.Windows.Forms.ComboBox
        Me.label_flag_geral2 = New System.Windows.Forms.Label
        Me.text_sistema = New System.Windows.Forms.TextBox
        Me.label_tip2 = New System.Windows.Forms.Label
        Me.combo_fase_nova = New System.Windows.Forms.ComboBox
        Me.label_fase_nova = New System.Windows.Forms.Label
        Me.combo_fase_anterior = New System.Windows.Forms.ComboBox
        Me.label_fase_anterior = New System.Windows.Forms.Label
        Me.combo_flag_status = New System.Windows.Forms.ComboBox
        Me.button_confirm = New System.Windows.Forms.Button
        Me.label_flag_status = New System.Windows.Forms.Label
        Me.combo_flag_geral = New System.Windows.Forms.ComboBox
        Me.label_flag_geral = New System.Windows.Forms.Label
        Me.button_del = New System.Windows.Forms.Button
        Me.combo_flag_evento = New System.Windows.Forms.ComboBox
        Me.combo_flag_fase = New System.Windows.Forms.ComboBox
        Me.label_flag_evento = New System.Windows.Forms.Label
        Me.label_flag_fase = New System.Windows.Forms.Label
        Me.label_desc = New System.Windows.Forms.Label
        Me.text_desc = New System.Windows.Forms.TextBox
        Me.label_name = New System.Windows.Forms.Label
        Me.text_name = New System.Windows.Forms.TextBox
        Me.tab_processo = New System.Windows.Forms.TabPage
        Me.A1Panel4 = New Owf.Controls.A1Panel
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.label_tip = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.button_processo_add = New System.Windows.Forms.Button
        Me.label_tip3 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.text_filter = New System.Windows.Forms.TextBox
        Me.label_filter = New System.Windows.Forms.Label
        Me.pic_filter = New System.Windows.Forms.PictureBox
        Me.button_confirm_processo = New System.Windows.Forms.Button
        Me.button_processo_refresh = New System.Windows.Forms.Button
        Me.label_processo = New System.Windows.Forms.Label
        Me.list_processo = New BrightIdeasSoftware.DataListView
        Me.column_processo_name = New BrightIdeasSoftware.OLVColumn
        Me.column_processo_titular = New BrightIdeasSoftware.OLVColumn
        Me.label_codigo_evento = New System.Windows.Forms.Label
        Me.text_codigo_evento = New System.Windows.Forms.TextBox
        CType(Me.list_alerta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.A1Panel1.SuspendLayout()
        Me.A1Panel2.SuspendLayout()
        Me.A1Panel3.SuspendLayout()
        Me.tab_main.SuspendLayout()
        Me.tab_dados.SuspendLayout()
        Me.panel_details.SuspendLayout()
        Me.tab_processo.SuspendLayout()
        Me.A1Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pic_filter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_processo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'list_alerta
        '
        Me.list_alerta.AllColumns.Add(Me.column_name)
        Me.list_alerta.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_alerta.BackColor = System.Drawing.Color.White
        Me.list_alerta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_alerta.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_name})
        Me.list_alerta.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_alerta.DataSource = Nothing
        Me.list_alerta.EmptyListMsg = "Não há alertas. Para inserir, clique no botão ""Inserir"""
        Me.list_alerta.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_alerta.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_alerta.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.list_alerta.HeaderUsesThemes = False
        Me.list_alerta.LargeImageList = Me.imgListAlerta
        Me.list_alerta.Location = New System.Drawing.Point(12, 24)
        Me.list_alerta.MultiSelect = False
        Me.list_alerta.Name = "list_alerta"
        Me.list_alerta.OwnerDraw = True
        Me.list_alerta.RowHeight = 15
        Me.list_alerta.ShowGroups = False
        Me.list_alerta.ShowHeaderInAllViews = False
        Me.list_alerta.ShowSortIndicators = False
        Me.list_alerta.Size = New System.Drawing.Size(566, 126)
        Me.list_alerta.TabIndex = 0
        Me.list_alerta.UseCompatibleStateImageBehavior = False
        Me.list_alerta.UseTranslucentSelection = True
        Me.list_alerta.View = System.Windows.Forms.View.Details
        '
        'column_name
        '
        Me.column_name.AspectName = "ALER_nm_alerta"
        Me.column_name.ShowTextInHeader = False
        Me.column_name.Text = ""
        '
        'imgListAlerta
        '
        Me.imgListAlerta.ImageStream = CType(resources.GetObject("imgListAlerta.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgListAlerta.TransparentColor = System.Drawing.Color.Transparent
        Me.imgListAlerta.Images.SetKeyName(0, "alerta")
        Me.imgListAlerta.Images.SetKeyName(1, "alerta_sys")
        Me.imgListAlerta.Images.SetKeyName(2, "database_refresh.png")
        '
        'HeaderFormatStyle1
        '
        HeaderStateStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeaderStateStyle4.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle4.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Hot = HeaderStateStyle4
        HeaderStateStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        HeaderStateStyle5.ForeColor = System.Drawing.Color.Black
        HeaderStateStyle5.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle5.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Normal = HeaderStateStyle5
        HeaderStateStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        HeaderStateStyle6.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle6.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Pressed = HeaderStateStyle6
        '
        'button_add
        '
        Me.button_add.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_add.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_add.ImageIndex = 2
        Me.button_add.ImageList = Me.ImageList2
        Me.button_add.Location = New System.Drawing.Point(9, 4)
        Me.button_add.Name = "button_add"
        Me.button_add.Size = New System.Drawing.Size(81, 28)
        Me.button_add.TabIndex = 1
        Me.button_add.Text = "Inserir"
        Me.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_add.UseVisualStyleBackColor = True
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "cancel.png")
        Me.ImageList2.Images.SetKeyName(1, "confirm.png")
        Me.ImageList2.Images.SetKeyName(2, "add2.png")
        Me.ImageList2.Images.SetKeyName(3, "trash.png")
        Me.ImageList2.Images.SetKeyName(4, "database_refresh.png")
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(14, 650)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.Size = New System.Drawing.Size(604, 43)
        Me.A1Panel1.TabIndex = 9
        '
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList2
        Me.button_close.Location = New System.Drawing.Point(501, 5)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(88, 28)
        Me.button_close.TabIndex = 2
        Me.button_close.Text = "Fechar"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_close.UseVisualStyleBackColor = True
        '
        'A1Panel2
        '
        Me.A1Panel2.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel2.Controls.Add(Me.label_tip1)
        Me.A1Panel2.Controls.Add(Me.list_alerta)
        Me.A1Panel2.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel2.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel2.Image = Nothing
        Me.A1Panel2.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel2.Location = New System.Drawing.Point(14, 3)
        Me.A1Panel2.Name = "A1Panel2"
        Me.A1Panel2.Size = New System.Drawing.Size(604, 162)
        Me.A1Panel2.TabIndex = 10
        '
        'label_tip1
        '
        Me.label_tip1.AutoSize = True
        Me.label_tip1.BackColor = System.Drawing.Color.Transparent
        Me.label_tip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip1.Location = New System.Drawing.Point(13, 4)
        Me.label_tip1.Name = "label_tip1"
        Me.label_tip1.Size = New System.Drawing.Size(327, 13)
        Me.label_tip1.TabIndex = 20
        Me.label_tip1.Text = "Para editar, selecione o alerta desejado na lista abaixo:"
        '
        'A1Panel3
        '
        Me.A1Panel3.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel3.Controls.Add(Me.button_add)
        Me.A1Panel3.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel3.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel3.Image = Nothing
        Me.A1Panel3.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel3.Location = New System.Drawing.Point(12, 171)
        Me.A1Panel3.Name = "A1Panel3"
        Me.A1Panel3.Size = New System.Drawing.Size(604, 43)
        Me.A1Panel3.TabIndex = 11
        '
        'tab_main
        '
        Me.tab_main.Controls.Add(Me.tab_dados)
        Me.tab_main.Controls.Add(Me.tab_processo)
        Me.tab_main.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_main.Location = New System.Drawing.Point(12, 223)
        Me.tab_main.Name = "tab_main"
        Me.tab_main.SelectedIndex = 0
        Me.tab_main.Size = New System.Drawing.Size(606, 426)
        Me.tab_main.TabIndex = 12
        '
        'tab_dados
        '
        Me.tab_dados.AutoScroll = True
        Me.tab_dados.Controls.Add(Me.panel_details)
        Me.tab_dados.Location = New System.Drawing.Point(4, 22)
        Me.tab_dados.Name = "tab_dados"
        Me.tab_dados.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_dados.Size = New System.Drawing.Size(598, 400)
        Me.tab_dados.TabIndex = 0
        Me.tab_dados.Text = "Principal"
        Me.tab_dados.UseVisualStyleBackColor = True
        '
        'panel_details
        '
        Me.panel_details.BorderColor = System.Drawing.Color.Silver
        Me.panel_details.Controls.Add(Me.text_codigo_evento)
        Me.panel_details.Controls.Add(Me.label_codigo_evento)
        Me.panel_details.Controls.Add(Me.combo_flag_geral2)
        Me.panel_details.Controls.Add(Me.label_flag_geral2)
        Me.panel_details.Controls.Add(Me.text_sistema)
        Me.panel_details.Controls.Add(Me.label_tip2)
        Me.panel_details.Controls.Add(Me.combo_fase_nova)
        Me.panel_details.Controls.Add(Me.label_fase_nova)
        Me.panel_details.Controls.Add(Me.combo_fase_anterior)
        Me.panel_details.Controls.Add(Me.label_fase_anterior)
        Me.panel_details.Controls.Add(Me.combo_flag_status)
        Me.panel_details.Controls.Add(Me.button_confirm)
        Me.panel_details.Controls.Add(Me.label_flag_status)
        Me.panel_details.Controls.Add(Me.combo_flag_geral)
        Me.panel_details.Controls.Add(Me.label_flag_geral)
        Me.panel_details.Controls.Add(Me.button_del)
        Me.panel_details.Controls.Add(Me.combo_flag_evento)
        Me.panel_details.Controls.Add(Me.combo_flag_fase)
        Me.panel_details.Controls.Add(Me.label_flag_evento)
        Me.panel_details.Controls.Add(Me.label_flag_fase)
        Me.panel_details.Controls.Add(Me.label_desc)
        Me.panel_details.Controls.Add(Me.text_desc)
        Me.panel_details.Controls.Add(Me.label_name)
        Me.panel_details.Controls.Add(Me.text_name)
        Me.panel_details.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.panel_details.GradientStartColor = System.Drawing.Color.White
        Me.panel_details.Image = Nothing
        Me.panel_details.ImageLocation = New System.Drawing.Point(4, 4)
        Me.panel_details.Location = New System.Drawing.Point(5, 3)
        Me.panel_details.Name = "panel_details"
        Me.panel_details.Size = New System.Drawing.Size(590, 391)
        Me.panel_details.TabIndex = 10
        '
        'combo_flag_geral2
        '
        Me.combo_flag_geral2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag_geral2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_flag_geral2.FormattingEnabled = True
        Me.combo_flag_geral2.Location = New System.Drawing.Point(390, 262)
        Me.combo_flag_geral2.Name = "combo_flag_geral2"
        Me.combo_flag_geral2.Size = New System.Drawing.Size(64, 21)
        Me.combo_flag_geral2.TabIndex = 43
        '
        'label_flag_geral2
        '
        Me.label_flag_geral2.AutoSize = True
        Me.label_flag_geral2.BackColor = System.Drawing.Color.Transparent
        Me.label_flag_geral2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_flag_geral2.Location = New System.Drawing.Point(12, 265)
        Me.label_flag_geral2.Name = "label_flag_geral2"
        Me.label_flag_geral2.Size = New System.Drawing.Size(344, 13)
        Me.label_flag_geral2.TabIndex = 42
        Me.label_flag_geral2.Text = "Alerta geral (para todos os processos existentes no DNPM)"
        '
        'text_sistema
        '
        Me.text_sistema.BackColor = System.Drawing.SystemColors.Info
        Me.text_sistema.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_sistema.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_sistema.Location = New System.Drawing.Point(522, 67)
        Me.text_sistema.MaxLength = 50
        Me.text_sistema.Name = "text_sistema"
        Me.text_sistema.Size = New System.Drawing.Size(53, 21)
        Me.text_sistema.TabIndex = 41
        Me.text_sistema.Visible = False
        '
        'label_tip2
        '
        Me.label_tip2.AutoSize = True
        Me.label_tip2.BackColor = System.Drawing.Color.Transparent
        Me.label_tip2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip2.Location = New System.Drawing.Point(289, 8)
        Me.label_tip2.Name = "label_tip2"
        Me.label_tip2.Size = New System.Drawing.Size(107, 13)
        Me.label_tip2.TabIndex = 40
        Me.label_tip2.Text = "min. 5 caracteres"
        '
        'combo_fase_nova
        '
        Me.combo_fase_nova.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_fase_nova.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_fase_nova.FormattingEnabled = True
        Me.combo_fase_nova.Location = New System.Drawing.Point(245, 156)
        Me.combo_fase_nova.Name = "combo_fase_nova"
        Me.combo_fase_nova.Size = New System.Drawing.Size(209, 21)
        Me.combo_fase_nova.TabIndex = 39
        '
        'label_fase_nova
        '
        Me.label_fase_nova.AutoSize = True
        Me.label_fase_nova.BackColor = System.Drawing.Color.Transparent
        Me.label_fase_nova.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fase_nova.Location = New System.Drawing.Point(12, 161)
        Me.label_fase_nova.Name = "label_fase_nova"
        Me.label_fase_nova.Size = New System.Drawing.Size(222, 13)
        Me.label_fase_nova.TabIndex = 38
        Me.label_fase_nova.Text = "Gerar alerta quando fase mudar para"
        '
        'combo_fase_anterior
        '
        Me.combo_fase_anterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_fase_anterior.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_fase_anterior.FormattingEnabled = True
        Me.combo_fase_anterior.Location = New System.Drawing.Point(245, 129)
        Me.combo_fase_anterior.Name = "combo_fase_anterior"
        Me.combo_fase_anterior.Size = New System.Drawing.Size(209, 21)
        Me.combo_fase_anterior.TabIndex = 37
        '
        'label_fase_anterior
        '
        Me.label_fase_anterior.AutoSize = True
        Me.label_fase_anterior.BackColor = System.Drawing.Color.Transparent
        Me.label_fase_anterior.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fase_anterior.Location = New System.Drawing.Point(12, 134)
        Me.label_fase_anterior.Name = "label_fase_anterior"
        Me.label_fase_anterior.Size = New System.Drawing.Size(214, 13)
        Me.label_fase_anterior.TabIndex = 36
        Me.label_fase_anterior.Text = "Gerar alerta quando fase mudar de "
        '
        'combo_flag_status
        '
        Me.combo_flag_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag_status.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_flag_status.FormattingEnabled = True
        Me.combo_flag_status.Location = New System.Drawing.Point(79, 296)
        Me.combo_flag_status.Name = "combo_flag_status"
        Me.combo_flag_status.Size = New System.Drawing.Size(147, 21)
        Me.combo_flag_status.TabIndex = 35
        '
        'button_confirm
        '
        Me.button_confirm.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm.ImageIndex = 1
        Me.button_confirm.ImageList = Me.ImageList2
        Me.button_confirm.Location = New System.Drawing.Point(16, 343)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(102, 27)
        Me.button_confirm.TabIndex = 15
        Me.button_confirm.Text = "Confirmar"
        Me.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm.UseVisualStyleBackColor = True
        '
        'label_flag_status
        '
        Me.label_flag_status.AutoSize = True
        Me.label_flag_status.BackColor = System.Drawing.Color.Transparent
        Me.label_flag_status.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_flag_status.Location = New System.Drawing.Point(12, 299)
        Me.label_flag_status.Name = "label_flag_status"
        Me.label_flag_status.Size = New System.Drawing.Size(56, 13)
        Me.label_flag_status.TabIndex = 34
        Me.label_flag_status.Text = "Situação"
        '
        'combo_flag_geral
        '
        Me.combo_flag_geral.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag_geral.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_flag_geral.FormattingEnabled = True
        Me.combo_flag_geral.Location = New System.Drawing.Point(390, 67)
        Me.combo_flag_geral.Name = "combo_flag_geral"
        Me.combo_flag_geral.Size = New System.Drawing.Size(64, 21)
        Me.combo_flag_geral.TabIndex = 33
        '
        'label_flag_geral
        '
        Me.label_flag_geral.AutoSize = True
        Me.label_flag_geral.BackColor = System.Drawing.Color.Transparent
        Me.label_flag_geral.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_flag_geral.Location = New System.Drawing.Point(12, 75)
        Me.label_flag_geral.Name = "label_flag_geral"
        Me.label_flag_geral.Size = New System.Drawing.Size(360, 13)
        Me.label_flag_geral.TabIndex = 32
        Me.label_flag_geral.Text = "Alerta geral (para todos os processo cadastrados no sistema)"
        '
        'button_del
        '
        Me.button_del.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_del.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_del.ImageIndex = 3
        Me.button_del.ImageList = Me.ImageList2
        Me.button_del.Location = New System.Drawing.Point(469, 343)
        Me.button_del.Name = "button_del"
        Me.button_del.Size = New System.Drawing.Size(102, 27)
        Me.button_del.TabIndex = 31
        Me.button_del.Text = "Excluir"
        Me.button_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_del.UseVisualStyleBackColor = True
        '
        'combo_flag_evento
        '
        Me.combo_flag_evento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_flag_evento.FormattingEnabled = True
        Me.combo_flag_evento.Location = New System.Drawing.Point(391, 194)
        Me.combo_flag_evento.Name = "combo_flag_evento"
        Me.combo_flag_evento.Size = New System.Drawing.Size(64, 21)
        Me.combo_flag_evento.TabIndex = 30
        '
        'combo_flag_fase
        '
        Me.combo_flag_fase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag_fase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_flag_fase.FormattingEnabled = True
        Me.combo_flag_fase.Location = New System.Drawing.Point(391, 98)
        Me.combo_flag_fase.Name = "combo_flag_fase"
        Me.combo_flag_fase.Size = New System.Drawing.Size(64, 21)
        Me.combo_flag_fase.TabIndex = 29
        '
        'label_flag_evento
        '
        Me.label_flag_evento.AutoSize = True
        Me.label_flag_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_flag_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_flag_evento.Location = New System.Drawing.Point(12, 197)
        Me.label_flag_evento.Name = "label_flag_evento"
        Me.label_flag_evento.Size = New System.Drawing.Size(317, 13)
        Me.label_flag_evento.TabIndex = 23
        Me.label_flag_evento.Text = "Gerar alerta quando ocorrer novo evento no processo"
        '
        'label_flag_fase
        '
        Me.label_flag_fase.AutoSize = True
        Me.label_flag_fase.BackColor = System.Drawing.Color.Transparent
        Me.label_flag_fase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_flag_fase.Location = New System.Drawing.Point(13, 101)
        Me.label_flag_fase.Name = "label_flag_fase"
        Me.label_flag_fase.Size = New System.Drawing.Size(324, 13)
        Me.label_flag_fase.TabIndex = 22
        Me.label_flag_fase.Text = "Gerar alerta quando processo minerário mudar de fase"
        '
        'label_desc
        '
        Me.label_desc.AutoSize = True
        Me.label_desc.BackColor = System.Drawing.Color.Transparent
        Me.label_desc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc.Location = New System.Drawing.Point(12, 37)
        Me.label_desc.Name = "label_desc"
        Me.label_desc.Size = New System.Drawing.Size(63, 13)
        Me.label_desc.TabIndex = 21
        Me.label_desc.Text = "Descrição"
        '
        'text_desc
        '
        Me.text_desc.BackColor = System.Drawing.SystemColors.Info
        Me.text_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_desc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_desc.Location = New System.Drawing.Point(79, 31)
        Me.text_desc.MaxLength = 300
        Me.text_desc.Name = "text_desc"
        Me.text_desc.Size = New System.Drawing.Size(496, 21)
        Me.text_desc.TabIndex = 20
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.BackColor = System.Drawing.Color.Transparent
        Me.label_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(12, 8)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(40, 13)
        Me.label_name.TabIndex = 19
        Me.label_name.Text = "Nome"
        '
        'text_name
        '
        Me.text_name.BackColor = System.Drawing.SystemColors.Info
        Me.text_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_name.Location = New System.Drawing.Point(79, 6)
        Me.text_name.MaxLength = 50
        Me.text_name.Name = "text_name"
        Me.text_name.Size = New System.Drawing.Size(190, 21)
        Me.text_name.TabIndex = 18
        '
        'tab_processo
        '
        Me.tab_processo.Controls.Add(Me.A1Panel4)
        Me.tab_processo.Location = New System.Drawing.Point(4, 22)
        Me.tab_processo.Name = "tab_processo"
        Me.tab_processo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_processo.Size = New System.Drawing.Size(598, 372)
        Me.tab_processo.TabIndex = 1
        Me.tab_processo.Text = "Processos"
        Me.tab_processo.UseVisualStyleBackColor = True
        '
        'A1Panel4
        '
        Me.A1Panel4.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel4.Controls.Add(Me.Panel3)
        Me.A1Panel4.Controls.Add(Me.Panel1)
        Me.A1Panel4.Controls.Add(Me.Panel2)
        Me.A1Panel4.Controls.Add(Me.button_confirm_processo)
        Me.A1Panel4.Controls.Add(Me.button_processo_refresh)
        Me.A1Panel4.Controls.Add(Me.label_processo)
        Me.A1Panel4.Controls.Add(Me.list_processo)
        Me.A1Panel4.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel4.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel4.Image = Nothing
        Me.A1Panel4.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel4.Location = New System.Drawing.Point(4, 2)
        Me.A1Panel4.Name = "A1Panel4"
        Me.A1Panel4.Size = New System.Drawing.Size(590, 364)
        Me.A1Panel4.TabIndex = 11
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Info
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.label_tip)
        Me.Panel3.Location = New System.Drawing.Point(220, 298)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 53)
        Me.Panel3.TabIndex = 52
        '
        'label_tip
        '
        Me.label_tip.BackColor = System.Drawing.Color.Transparent
        Me.label_tip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip.Location = New System.Drawing.Point(10, 6)
        Me.label_tip.Name = "label_tip"
        Me.label_tip.Size = New System.Drawing.Size(322, 42)
        Me.label_tip.TabIndex = 21
        Me.label_tip.Text = "Para selecionar mais de um processo, pressione Shift ou Ctrl+A (para selecionar t" & _
            "odos), e pressione a tecla SPACE para checar os processos selecionados"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.button_processo_add)
        Me.Panel1.Controls.Add(Me.label_tip3)
        Me.Panel1.Location = New System.Drawing.Point(10, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(183, 62)
        Me.Panel1.TabIndex = 51
        '
        'button_processo_add
        '
        Me.button_processo_add.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_processo_add.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_processo_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_processo_add.ImageIndex = 2
        Me.button_processo_add.ImageList = Me.ImageList2
        Me.button_processo_add.Location = New System.Drawing.Point(13, 23)
        Me.button_processo_add.Name = "button_processo_add"
        Me.button_processo_add.Size = New System.Drawing.Size(145, 28)
        Me.button_processo_add.TabIndex = 22
        Me.button_processo_add.Text = "Incluir Processo"
        Me.button_processo_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_processo_add.UseVisualStyleBackColor = True
        '
        'label_tip3
        '
        Me.label_tip3.BackColor = System.Drawing.Color.Transparent
        Me.label_tip3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip3.Location = New System.Drawing.Point(10, 6)
        Me.label_tip3.Name = "label_tip3"
        Me.label_tip3.Size = New System.Drawing.Size(170, 20)
        Me.label_tip3.TabIndex = 21
        Me.label_tip3.Text = "Processo não está na lista?"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.text_filter)
        Me.Panel2.Controls.Add(Me.label_filter)
        Me.Panel2.Controls.Add(Me.pic_filter)
        Me.Panel2.Location = New System.Drawing.Point(354, 11)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(218, 62)
        Me.Panel2.TabIndex = 50
        '
        'text_filter
        '
        Me.text_filter.BackColor = System.Drawing.SystemColors.Info
        Me.text_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_filter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_filter.Location = New System.Drawing.Point(49, 21)
        Me.text_filter.MaxLength = 30
        Me.text_filter.Multiline = True
        Me.text_filter.Name = "text_filter"
        Me.text_filter.Size = New System.Drawing.Size(150, 28)
        Me.text_filter.TabIndex = 22
        '
        'label_filter
        '
        Me.label_filter.BackColor = System.Drawing.Color.Transparent
        Me.label_filter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_filter.Location = New System.Drawing.Point(46, 4)
        Me.label_filter.Name = "label_filter"
        Me.label_filter.Size = New System.Drawing.Size(153, 20)
        Me.label_filter.TabIndex = 21
        Me.label_filter.Text = "Filtrar Processos:"
        '
        'pic_filter
        '
        Me.pic_filter.Image = CType(resources.GetObject("pic_filter.Image"), System.Drawing.Image)
        Me.pic_filter.Location = New System.Drawing.Point(9, 10)
        Me.pic_filter.Name = "pic_filter"
        Me.pic_filter.Size = New System.Drawing.Size(34, 34)
        Me.pic_filter.TabIndex = 0
        Me.pic_filter.TabStop = False
        '
        'button_confirm_processo
        '
        Me.button_confirm_processo.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm_processo.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm_processo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm_processo.ImageIndex = 1
        Me.button_confirm_processo.ImageList = Me.ImageList2
        Me.button_confirm_processo.Location = New System.Drawing.Point(10, 293)
        Me.button_confirm_processo.Name = "button_confirm_processo"
        Me.button_confirm_processo.Size = New System.Drawing.Size(168, 27)
        Me.button_confirm_processo.TabIndex = 49
        Me.button_confirm_processo.Text = "Aplicar Alterações"
        Me.button_confirm_processo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm_processo.UseVisualStyleBackColor = True
        '
        'button_processo_refresh
        '
        Me.button_processo_refresh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_processo_refresh.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_processo_refresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_processo_refresh.ImageIndex = 4
        Me.button_processo_refresh.ImageList = Me.ImageList2
        Me.button_processo_refresh.Location = New System.Drawing.Point(458, 81)
        Me.button_processo_refresh.Name = "button_processo_refresh"
        Me.button_processo_refresh.Size = New System.Drawing.Size(114, 25)
        Me.button_processo_refresh.TabIndex = 48
        Me.button_processo_refresh.Text = "Atualizar Lista"
        Me.button_processo_refresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_processo_refresh.UseVisualStyleBackColor = True
        '
        'label_processo
        '
        Me.label_processo.BackColor = System.Drawing.Color.Transparent
        Me.label_processo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_processo.Location = New System.Drawing.Point(7, 92)
        Me.label_processo.Name = "label_processo"
        Me.label_processo.Size = New System.Drawing.Size(327, 17)
        Me.label_processo.TabIndex = 45
        Me.label_processo.Text = "Selecione os processos que deseja associar ao alerta:"
        '
        'list_processo
        '
        Me.list_processo.AllColumns.Add(Me.column_processo_name)
        Me.list_processo.AllColumns.Add(Me.column_processo_titular)
        Me.list_processo.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_processo.BackColor = System.Drawing.Color.White
        Me.list_processo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_processo.CheckBoxes = True
        Me.list_processo.CheckedAspectName = ""
        Me.list_processo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_processo_name, Me.column_processo_titular})
        Me.list_processo.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_processo.DataSource = Nothing
        Me.list_processo.EmptyListMsg = "Nenhum processo minerário encontrado"
        Me.list_processo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_processo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_processo.FullRowSelect = True
        Me.list_processo.GridLines = True
        Me.list_processo.HeaderFont = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold)
        Me.list_processo.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_processo.HeaderUsesThemes = False
        Me.list_processo.HeaderWordWrap = True
        Me.list_processo.Location = New System.Drawing.Point(10, 109)
        Me.list_processo.Name = "list_processo"
        Me.list_processo.RowHeight = 15
        Me.list_processo.ShowGroups = False
        Me.list_processo.ShowImagesOnSubItems = True
        Me.list_processo.Size = New System.Drawing.Size(562, 178)
        Me.list_processo.TabIndex = 44
        Me.list_processo.UseAlternatingBackColors = True
        Me.list_processo.UseCompatibleStateImageBehavior = False
        Me.list_processo.UseFiltering = True
        Me.list_processo.UseTranslucentSelection = True
        Me.list_processo.View = System.Windows.Forms.View.Details
        '
        'column_processo_name
        '
        Me.column_processo_name.AspectName = "PROC_cd_processo"
        Me.column_processo_name.CheckBoxes = True
        Me.column_processo_name.FillsFreeSpace = True
        Me.column_processo_name.Hideable = False
        Me.column_processo_name.IsEditable = False
        Me.column_processo_name.Text = "Número Processo"
        '
        'column_processo_titular
        '
        Me.column_processo_titular.AspectName = "PROC_ds_titular"
        Me.column_processo_titular.FillsFreeSpace = True
        Me.column_processo_titular.Text = "Titular"
        Me.column_processo_titular.Width = 80
        Me.column_processo_titular.WordWrap = True
        '
        'label_codigo_evento
        '
        Me.label_codigo_evento.AutoSize = True
        Me.label_codigo_evento.BackColor = System.Drawing.Color.Transparent
        Me.label_codigo_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_codigo_evento.Location = New System.Drawing.Point(13, 233)
        Me.label_codigo_evento.Name = "label_codigo_evento"
        Me.label_codigo_evento.Size = New System.Drawing.Size(144, 13)
        Me.label_codigo_evento.TabIndex = 44
        Me.label_codigo_evento.Text = "Especificar Novo Evento"
        '
        'text_codigo_evento
        '
        Me.text_codigo_evento.BackColor = System.Drawing.SystemColors.Info
        Me.text_codigo_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_codigo_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_codigo_evento.Location = New System.Drawing.Point(169, 231)
        Me.text_codigo_evento.MaxLength = 5
        Me.text_codigo_evento.Name = "text_codigo_evento"
        Me.text_codigo_evento.Size = New System.Drawing.Size(85, 21)
        Me.text_codigo_evento.TabIndex = 45
        '
        'form_alerta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(630, 705)
        Me.Controls.Add(Me.tab_main)
        Me.Controls.Add(Me.A1Panel3)
        Me.Controls.Add(Me.A1Panel2)
        Me.Controls.Add(Me.A1Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_alerta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Alertas"
        CType(Me.list_alerta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel2.ResumeLayout(False)
        Me.A1Panel2.PerformLayout()
        Me.A1Panel3.ResumeLayout(False)
        Me.tab_main.ResumeLayout(False)
        Me.tab_dados.ResumeLayout(False)
        Me.panel_details.ResumeLayout(False)
        Me.panel_details.PerformLayout()
        Me.tab_processo.ResumeLayout(False)
        Me.A1Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pic_filter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_processo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list_alerta As BrightIdeasSoftware.DataListView
    Friend WithEvents button_add As System.Windows.Forms.Button
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents A1Panel2 As Owf.Controls.A1Panel
    Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
    Friend WithEvents label_tip1 As System.Windows.Forms.Label
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents A1Panel3 As Owf.Controls.A1Panel
    Friend WithEvents imgListAlerta As System.Windows.Forms.ImageList
    Friend WithEvents column_name As BrightIdeasSoftware.OLVColumn
    Friend WithEvents tab_main As System.Windows.Forms.TabControl
    Friend WithEvents tab_dados As System.Windows.Forms.TabPage
    Friend WithEvents panel_details As Owf.Controls.A1Panel
    Friend WithEvents text_sistema As System.Windows.Forms.TextBox
    Friend WithEvents label_tip2 As System.Windows.Forms.Label
    Friend WithEvents combo_fase_nova As System.Windows.Forms.ComboBox
    Friend WithEvents label_fase_nova As System.Windows.Forms.Label
    Friend WithEvents combo_fase_anterior As System.Windows.Forms.ComboBox
    Friend WithEvents label_fase_anterior As System.Windows.Forms.Label
    Friend WithEvents combo_flag_status As System.Windows.Forms.ComboBox
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents label_flag_status As System.Windows.Forms.Label
    Friend WithEvents combo_flag_geral As System.Windows.Forms.ComboBox
    Friend WithEvents label_flag_geral As System.Windows.Forms.Label
    Friend WithEvents button_del As System.Windows.Forms.Button
    Friend WithEvents combo_flag_evento As System.Windows.Forms.ComboBox
    Friend WithEvents combo_flag_fase As System.Windows.Forms.ComboBox
    Friend WithEvents label_flag_evento As System.Windows.Forms.Label
    Friend WithEvents label_flag_fase As System.Windows.Forms.Label
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents text_desc As System.Windows.Forms.TextBox
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents text_name As System.Windows.Forms.TextBox
    Friend WithEvents tab_processo As System.Windows.Forms.TabPage
    Friend WithEvents A1Panel4 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm_processo As System.Windows.Forms.Button
    Friend WithEvents button_processo_refresh As System.Windows.Forms.Button
    Friend WithEvents label_processo As System.Windows.Forms.Label
    Friend WithEvents list_processo As BrightIdeasSoftware.DataListView
    Friend WithEvents column_processo_name As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_processo_titular As BrightIdeasSoftware.OLVColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents text_filter As System.Windows.Forms.TextBox
    Friend WithEvents label_filter As System.Windows.Forms.Label
    Friend WithEvents pic_filter As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents label_tip3 As System.Windows.Forms.Label
    Friend WithEvents button_processo_add As System.Windows.Forms.Button
    Friend WithEvents combo_flag_geral2 As System.Windows.Forms.ComboBox
    Friend WithEvents label_flag_geral2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents label_tip As System.Windows.Forms.Label
    Friend WithEvents text_codigo_evento As System.Windows.Forms.TextBox
    Friend WithEvents label_codigo_evento As System.Windows.Forms.Label
End Class
