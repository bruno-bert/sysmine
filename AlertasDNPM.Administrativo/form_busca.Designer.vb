<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_busca
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
        Dim HeaderStateStyle1 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim HeaderStateStyle2 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim HeaderStateStyle3 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_busca))
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.panel_command = New Owf.Controls.A1Panel
        Me.button_close = New System.Windows.Forms.Button
        Me.A1Panel2 = New Owf.Controls.A1Panel
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.label_data = New System.Windows.Forms.Label
        Me.button_down = New System.Windows.Forms.Button
        Me.label_data1 = New System.Windows.Forms.Label
        Me.list_processo = New BrightIdeasSoftware.DataListView
        Me.column_code = New BrightIdeasSoftware.OLVColumn
        Me.column_ano = New BrightIdeasSoftware.OLVColumn
        Me.column_uf = New BrightIdeasSoftware.OLVColumn
        Me.column_desc = New BrightIdeasSoftware.OLVColumn
        Me.column_fase = New BrightIdeasSoftware.OLVColumn
        Me.column_sub = New BrightIdeasSoftware.OLVColumn
        Me.column_evento = New BrightIdeasSoftware.OLVColumn
        Me.label_busca1 = New System.Windows.Forms.Label
        Me.combo_filtro = New System.Windows.Forms.ComboBox
        Me.button_busca = New System.Windows.Forms.Button
        Me.text_busca = New System.Windows.Forms.TextBox
        Me.label_busca2 = New System.Windows.Forms.Label
        Me.button_add = New System.Windows.Forms.Button
        Me.label_desc = New System.Windows.Forms.Label
        Me.panel_busca1 = New System.Windows.Forms.Panel
        Me.label_count = New System.Windows.Forms.Label
        Me.button_clear_filter = New System.Windows.Forms.Button
        Me.text_filter = New System.Windows.Forms.TextBox
        Me.label_filter = New System.Windows.Forms.Label
        Me.pic_filter = New System.Windows.Forms.PictureBox
        Me.group_base = New System.Windows.Forms.GroupBox
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.panel_command.SuspendLayout()
        Me.A1Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.list_processo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_busca1.SuspendLayout()
        CType(Me.pic_filter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.group_base.SuspendLayout()
        Me.A1Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'HeaderFormatStyle1
        '
        HeaderStateStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeaderStateStyle1.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle1.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Hot = HeaderStateStyle1
        HeaderStateStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeaderStateStyle2.ForeColor = System.Drawing.Color.Black
        HeaderStateStyle2.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle2.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Normal = HeaderStateStyle2
        HeaderStateStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeaderStateStyle3.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle3.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Pressed = HeaderStateStyle3
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
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "clear.png")
        Me.ImageList2.Images.SetKeyName(1, "database_refresh.png")
        '
        'panel_command
        '
        Me.panel_command.BorderColor = System.Drawing.Color.Silver
        Me.panel_command.Controls.Add(Me.button_close)
        Me.panel_command.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.panel_command.GradientStartColor = System.Drawing.Color.White
        Me.panel_command.Image = Nothing
        Me.panel_command.ImageLocation = New System.Drawing.Point(4, 4)
        Me.panel_command.Location = New System.Drawing.Point(7, 610)
        Me.panel_command.Name = "panel_command"
        Me.panel_command.Size = New System.Drawing.Size(1115, 42)
        Me.panel_command.TabIndex = 11
        '
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(995, 3)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(103, 28)
        Me.button_close.TabIndex = 3
        Me.button_close.Text = "Fechar"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_close.UseVisualStyleBackColor = True
        '
        'A1Panel2
        '
        Me.A1Panel2.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel2.Controls.Add(Me.Panel5)
        Me.A1Panel2.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel2.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel2.Image = Nothing
        Me.A1Panel2.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel2.Location = New System.Drawing.Point(13, 20)
        Me.A1Panel2.Name = "A1Panel2"
        Me.A1Panel2.Size = New System.Drawing.Size(1092, 88)
        Me.A1Panel2.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Info
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.label_data)
        Me.Panel5.Controls.Add(Me.button_down)
        Me.Panel5.Controls.Add(Me.label_data1)
        Me.Panel5.Location = New System.Drawing.Point(10, 16)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1071, 55)
        Me.Panel5.TabIndex = 22
        '
        'label_data
        '
        Me.label_data.BackColor = System.Drawing.Color.Transparent
        Me.label_data.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_data.ForeColor = System.Drawing.Color.RoyalBlue
        Me.label_data.Location = New System.Drawing.Point(613, 9)
        Me.label_data.Name = "label_data"
        Me.label_data.Size = New System.Drawing.Size(250, 27)
        Me.label_data.TabIndex = 24
        Me.label_data.Text = "#DATA#"
        Me.label_data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_down
        '
        Me.button_down.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_down.Image = CType(resources.GetObject("button_down.Image"), System.Drawing.Image)
        Me.button_down.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_down.Location = New System.Drawing.Point(13, 4)
        Me.button_down.Name = "button_down"
        Me.button_down.Size = New System.Drawing.Size(311, 39)
        Me.button_down.TabIndex = 23
        Me.button_down.Text = "Clique aqui para baixar dados do DNPM"
        Me.button_down.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_down.UseVisualStyleBackColor = True
        '
        'label_data1
        '
        Me.label_data1.BackColor = System.Drawing.Color.Transparent
        Me.label_data1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_data1.Location = New System.Drawing.Point(339, 10)
        Me.label_data1.Name = "label_data1"
        Me.label_data1.Size = New System.Drawing.Size(268, 27)
        Me.label_data1.TabIndex = 21
        Me.label_data1.Text = "Data da Base de Referência Disponível"
        Me.label_data1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'list_processo
        '
        Me.list_processo.AllColumns.Add(Me.column_code)
        Me.list_processo.AllColumns.Add(Me.column_ano)
        Me.list_processo.AllColumns.Add(Me.column_uf)
        Me.list_processo.AllColumns.Add(Me.column_desc)
        Me.list_processo.AllColumns.Add(Me.column_fase)
        Me.list_processo.AllColumns.Add(Me.column_sub)
        Me.list_processo.AllColumns.Add(Me.column_evento)
        Me.list_processo.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_processo.BackColor = System.Drawing.Color.White
        Me.list_processo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_processo.CheckBoxes = True
        Me.list_processo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_code, Me.column_ano, Me.column_uf, Me.column_desc, Me.column_fase, Me.column_sub, Me.column_evento})
        Me.list_processo.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_processo.DataSource = Nothing
        Me.list_processo.EmptyListMsg = "Nenhum processo minerário encontrado"
        Me.list_processo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_processo.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_processo.FullRowSelect = True
        Me.list_processo.GridLines = True
        Me.list_processo.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_processo.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_processo.HeaderUsesThemes = False
        Me.list_processo.Location = New System.Drawing.Point(8, 147)
        Me.list_processo.Name = "list_processo"
        Me.list_processo.RowHeight = 15
        Me.list_processo.ShowGroups = False
        Me.list_processo.ShowImagesOnSubItems = True
        Me.list_processo.Size = New System.Drawing.Size(1086, 313)
        Me.list_processo.TabIndex = 22
        Me.list_processo.UseAlternatingBackColors = True
        Me.list_processo.UseCompatibleStateImageBehavior = False
        Me.list_processo.UseFiltering = True
        Me.list_processo.UseHyperlinks = True
        Me.list_processo.UseTranslucentSelection = True
        Me.list_processo.View = System.Windows.Forms.View.Details
        '
        'column_code
        '
        Me.column_code.AspectName = "processo"
        Me.column_code.CheckBoxes = True
        Me.column_code.Hideable = False
        Me.column_code.Hyperlink = True
        Me.column_code.IsEditable = False
        Me.column_code.Text = "Número"
        Me.column_code.Width = 125
        '
        'column_ano
        '
        Me.column_ano.AspectName = "ano"
        Me.column_ano.Text = "Ano"
        '
        'column_uf
        '
        Me.column_uf.AspectName = "uf"
        Me.column_uf.Text = "UF"
        '
        'column_desc
        '
        Me.column_desc.AspectName = "titular"
        Me.column_desc.Hideable = False
        Me.column_desc.IsEditable = False
        Me.column_desc.Text = "Titular"
        Me.column_desc.Width = 200
        '
        'column_fase
        '
        Me.column_fase.AspectName = "fase"
        Me.column_fase.IsEditable = False
        Me.column_fase.Text = "Fase"
        Me.column_fase.Width = 130
        '
        'column_sub
        '
        Me.column_sub.AspectName = "substancia"
        Me.column_sub.Text = "Substância"
        Me.column_sub.Width = 150
        '
        'column_evento
        '
        Me.column_evento.AspectName = "evento"
        Me.column_evento.Text = "Último Evento"
        Me.column_evento.Width = 400
        '
        'label_busca1
        '
        Me.label_busca1.BackColor = System.Drawing.Color.Transparent
        Me.label_busca1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_busca1.Location = New System.Drawing.Point(18, 7)
        Me.label_busca1.Name = "label_busca1"
        Me.label_busca1.Size = New System.Drawing.Size(278, 16)
        Me.label_busca1.TabIndex = 25
        Me.label_busca1.Text = "Selecione o campo para filtrar a busca:"
        '
        'combo_filtro
        '
        Me.combo_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_filtro.FormattingEnabled = True
        Me.combo_filtro.Location = New System.Drawing.Point(22, 29)
        Me.combo_filtro.Name = "combo_filtro"
        Me.combo_filtro.Size = New System.Drawing.Size(273, 21)
        Me.combo_filtro.TabIndex = 24
        '
        'button_busca
        '
        Me.button_busca.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_busca.Image = CType(resources.GetObject("button_busca.Image"), System.Drawing.Image)
        Me.button_busca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_busca.Location = New System.Drawing.Point(912, 11)
        Me.button_busca.Name = "button_busca"
        Me.button_busca.Size = New System.Drawing.Size(182, 39)
        Me.button_busca.TabIndex = 23
        Me.button_busca.Text = "Buscar Dados"
        Me.button_busca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_busca.UseVisualStyleBackColor = True
        '
        'text_busca
        '
        Me.text_busca.BackColor = System.Drawing.SystemColors.Info
        Me.text_busca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_busca.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_busca.Location = New System.Drawing.Point(340, 28)
        Me.text_busca.MaxLength = 50
        Me.text_busca.Name = "text_busca"
        Me.text_busca.Size = New System.Drawing.Size(322, 23)
        Me.text_busca.TabIndex = 22
        '
        'label_busca2
        '
        Me.label_busca2.BackColor = System.Drawing.Color.Transparent
        Me.label_busca2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_busca2.Location = New System.Drawing.Point(337, 7)
        Me.label_busca2.Name = "label_busca2"
        Me.label_busca2.Size = New System.Drawing.Size(268, 20)
        Me.label_busca2.TabIndex = 21
        Me.label_busca2.Text = "Digite o texto para filtrar a busca:"
        '
        'button_add
        '
        Me.button_add.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_add.Image = CType(resources.GetObject("button_add.Image"), System.Drawing.Image)
        Me.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_add.Location = New System.Drawing.Point(959, 114)
        Me.button_add.Name = "button_add"
        Me.button_add.Size = New System.Drawing.Size(135, 27)
        Me.button_add.TabIndex = 27
        Me.button_add.Text = "Incluir Processos"
        Me.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_add.UseVisualStyleBackColor = True
        '
        'label_desc
        '
        Me.label_desc.BackColor = System.Drawing.Color.Transparent
        Me.label_desc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc.Location = New System.Drawing.Point(10, 127)
        Me.label_desc.Name = "label_desc"
        Me.label_desc.Size = New System.Drawing.Size(877, 20)
        Me.label_desc.TabIndex = 26
        Me.label_desc.Text = "Para incluir processos minerários ao cadastro do sistema, selecione os processos " & _
            "desejados e clique em ""INCLUIR PROCESSOS"""
        '
        'panel_busca1
        '
        Me.panel_busca1.BackColor = System.Drawing.SystemColors.Info
        Me.panel_busca1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_busca1.Controls.Add(Me.label_count)
        Me.panel_busca1.Controls.Add(Me.button_clear_filter)
        Me.panel_busca1.Controls.Add(Me.text_filter)
        Me.panel_busca1.Controls.Add(Me.label_filter)
        Me.panel_busca1.Controls.Add(Me.pic_filter)
        Me.panel_busca1.Location = New System.Drawing.Point(10, 61)
        Me.panel_busca1.Name = "panel_busca1"
        Me.panel_busca1.Size = New System.Drawing.Size(736, 59)
        Me.panel_busca1.TabIndex = 25
        '
        'label_count
        '
        Me.label_count.BackColor = System.Drawing.Color.Transparent
        Me.label_count.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_count.Location = New System.Drawing.Point(402, 12)
        Me.label_count.Name = "label_count"
        Me.label_count.Size = New System.Drawing.Size(140, 37)
        Me.label_count.TabIndex = 24
        Me.label_count.Text = "{0} Processos listados"
        Me.label_count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'button_clear_filter
        '
        Me.button_clear_filter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_clear_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_clear_filter.ImageIndex = 0
        Me.button_clear_filter.ImageList = Me.ImageList2
        Me.button_clear_filter.Location = New System.Drawing.Point(595, 10)
        Me.button_clear_filter.Name = "button_clear_filter"
        Me.button_clear_filter.Size = New System.Drawing.Size(122, 39)
        Me.button_clear_filter.TabIndex = 23
        Me.button_clear_filter.Text = "Limpar Filtro"
        Me.button_clear_filter.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_clear_filter.UseVisualStyleBackColor = True
        '
        'text_filter
        '
        Me.text_filter.BackColor = System.Drawing.SystemColors.Info
        Me.text_filter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_filter.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_filter.Location = New System.Drawing.Point(57, 21)
        Me.text_filter.MaxLength = 50
        Me.text_filter.Name = "text_filter"
        Me.text_filter.Size = New System.Drawing.Size(322, 23)
        Me.text_filter.TabIndex = 22
        '
        'label_filter
        '
        Me.label_filter.BackColor = System.Drawing.Color.Transparent
        Me.label_filter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_filter.Location = New System.Drawing.Point(54, 4)
        Me.label_filter.Name = "label_filter"
        Me.label_filter.Size = New System.Drawing.Size(425, 20)
        Me.label_filter.TabIndex = 21
        Me.label_filter.Text = "Para filtrar a lista, digite o texto no campo abaixo:"
        '
        'pic_filter
        '
        Me.pic_filter.Image = CType(resources.GetObject("pic_filter.Image"), System.Drawing.Image)
        Me.pic_filter.Location = New System.Drawing.Point(10, 10)
        Me.pic_filter.Name = "pic_filter"
        Me.pic_filter.Size = New System.Drawing.Size(40, 34)
        Me.pic_filter.TabIndex = 0
        Me.pic_filter.TabStop = False
        '
        'group_base
        '
        Me.group_base.BackColor = System.Drawing.Color.LightGray
        Me.group_base.Controls.Add(Me.A1Panel2)
        Me.group_base.Location = New System.Drawing.Point(11, 3)
        Me.group_base.Name = "group_base"
        Me.group_base.Size = New System.Drawing.Size(1111, 119)
        Me.group_base.TabIndex = 27
        Me.group_base.TabStop = False
        Me.group_base.Text = "Base de Dados de Referência - {0}"
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel1.Controls.Add(Me.button_add)
        Me.A1Panel1.Controls.Add(Me.label_busca1)
        Me.A1Panel1.Controls.Add(Me.panel_busca1)
        Me.A1Panel1.Controls.Add(Me.label_busca2)
        Me.A1Panel1.Controls.Add(Me.list_processo)
        Me.A1Panel1.Controls.Add(Me.label_desc)
        Me.A1Panel1.Controls.Add(Me.combo_filtro)
        Me.A1Panel1.Controls.Add(Me.text_busca)
        Me.A1Panel1.Controls.Add(Me.button_busca)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(11, 130)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.Size = New System.Drawing.Size(1111, 473)
        Me.A1Panel1.TabIndex = 28
        '
        'form_busca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1134, 662)
        Me.Controls.Add(Me.group_base)
        Me.Controls.Add(Me.panel_command)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_busca"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Busca de Processos Minerários na base do DNPM"
        Me.panel_command.ResumeLayout(False)
        Me.A1Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.list_processo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_busca1.ResumeLayout(False)
        Me.panel_busca1.PerformLayout()
        CType(Me.pic_filter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.group_base.ResumeLayout(False)
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents panel_command As Owf.Controls.A1Panel
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents A1Panel2 As Owf.Controls.A1Panel
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents button_down As System.Windows.Forms.Button
    Friend WithEvents label_data As System.Windows.Forms.Label
    Friend WithEvents label_data1 As System.Windows.Forms.Label
    Friend WithEvents list_processo As BrightIdeasSoftware.DataListView
    Friend WithEvents column_code As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_desc As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_fase As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_busca As System.Windows.Forms.Button
    Friend WithEvents text_busca As System.Windows.Forms.TextBox
    Friend WithEvents label_busca2 As System.Windows.Forms.Label
    Friend WithEvents label_busca1 As System.Windows.Forms.Label
    Friend WithEvents combo_filtro As System.Windows.Forms.ComboBox
    Friend WithEvents panel_busca1 As System.Windows.Forms.Panel
    Friend WithEvents button_clear_filter As System.Windows.Forms.Button
    Friend WithEvents text_filter As System.Windows.Forms.TextBox
    Friend WithEvents label_filter As System.Windows.Forms.Label
    Friend WithEvents pic_filter As System.Windows.Forms.PictureBox
    Friend WithEvents button_add As System.Windows.Forms.Button
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents label_count As System.Windows.Forms.Label
    Friend WithEvents group_base As System.Windows.Forms.GroupBox
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents column_sub As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_evento As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_uf As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_ano As BrightIdeasSoftware.OLVColumn
End Class
