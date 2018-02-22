<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_empresa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_empresa))
        Me.list_empresa = New BrightIdeasSoftware.DataListView
        Me.column_name = New BrightIdeasSoftware.OLVColumn
        Me.column_desc = New BrightIdeasSoftware.OLVColumn
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle
        Me.button_add = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.panel_details = New Owf.Controls.A1Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.label_dou = New System.Windows.Forms.Label
        Me.text_dou = New System.Windows.Forms.TextBox
        Me.combo_flag = New System.Windows.Forms.ComboBox
        Me.label_flag = New System.Windows.Forms.Label
        Me.button_del = New System.Windows.Forms.Button
        Me.label_tip3 = New System.Windows.Forms.Label
        Me.label_tip4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.label_tip1 = New System.Windows.Forms.Label
        Me.label_tip2 = New System.Windows.Forms.Label
        Me.pic_tip = New System.Windows.Forms.PictureBox
        Me.label_email = New System.Windows.Forms.Label
        Me.text_desc = New System.Windows.Forms.TextBox
        Me.label_name = New System.Windows.Forms.Label
        Me.text_name = New System.Windows.Forms.TextBox
        Me.button_confirm = New System.Windows.Forms.Button
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.button_close = New System.Windows.Forms.Button
        Me.A1Panel2 = New Owf.Controls.A1Panel
        Me.label_desc = New System.Windows.Forms.Label
        Me.A1Panel3 = New Owf.Controls.A1Panel
        CType(Me.list_empresa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_details.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_tip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.A1Panel1.SuspendLayout()
        Me.A1Panel2.SuspendLayout()
        Me.A1Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'list_empresa
        '
        Me.list_empresa.AllColumns.Add(Me.column_name)
        Me.list_empresa.AllColumns.Add(Me.column_desc)
        Me.list_empresa.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_empresa.BackColor = System.Drawing.Color.White
        Me.list_empresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_empresa.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_name, Me.column_desc})
        Me.list_empresa.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_empresa.DataSource = Nothing
        Me.list_empresa.EmptyListMsg = "Não há operadores. Para inserir, clique no botão ""Inserir"""
        Me.list_empresa.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_empresa.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_empresa.FullRowSelect = True
        Me.list_empresa.GridLines = True
        Me.list_empresa.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_empresa.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_empresa.HeaderUsesThemes = False
        Me.list_empresa.Location = New System.Drawing.Point(14, 24)
        Me.list_empresa.MultiSelect = False
        Me.list_empresa.Name = "list_empresa"
        Me.list_empresa.RowHeight = 15
        Me.list_empresa.ShowGroups = False
        Me.list_empresa.Size = New System.Drawing.Size(660, 126)
        Me.list_empresa.TabIndex = 0
        Me.list_empresa.UseAlternatingBackColors = True
        Me.list_empresa.UseCompatibleStateImageBehavior = False
        Me.list_empresa.UseFiltering = True
        Me.list_empresa.UseTranslucentSelection = True
        Me.list_empresa.View = System.Windows.Forms.View.Details
        '
        'column_name
        '
        Me.column_name.AspectName = "EMPR_nm_empresa"
        Me.column_name.FillsFreeSpace = True
        Me.column_name.Hideable = False
        Me.column_name.IsEditable = False
        Me.column_name.Text = "Nome"
        '
        'column_desc
        '
        Me.column_desc.AspectName = "EMPR_ds_empresa"
        Me.column_desc.FillsFreeSpace = True
        Me.column_desc.Hideable = False
        Me.column_desc.IsEditable = False
        Me.column_desc.Text = "Descrição Titular"
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
        'button_add
        '
        Me.button_add.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_add.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_add.ImageIndex = 2
        Me.button_add.ImageList = Me.ImageList1
        Me.button_add.Location = New System.Drawing.Point(14, 5)
        Me.button_add.Name = "button_add"
        Me.button_add.Size = New System.Drawing.Size(94, 28)
        Me.button_add.TabIndex = 1
        Me.button_add.Text = "Inserir"
        Me.button_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_add.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cancel.png")
        Me.ImageList1.Images.SetKeyName(1, "confirm.png")
        Me.ImageList1.Images.SetKeyName(2, "add2.png")
        Me.ImageList1.Images.SetKeyName(3, "trash.png")
        '
        'panel_details
        '
        Me.panel_details.BorderColor = System.Drawing.Color.Silver
        Me.panel_details.Controls.Add(Me.Label1)
        Me.panel_details.Controls.Add(Me.label_dou)
        Me.panel_details.Controls.Add(Me.text_dou)
        Me.panel_details.Controls.Add(Me.combo_flag)
        Me.panel_details.Controls.Add(Me.label_flag)
        Me.panel_details.Controls.Add(Me.button_del)
        Me.panel_details.Controls.Add(Me.label_tip3)
        Me.panel_details.Controls.Add(Me.label_tip4)
        Me.panel_details.Controls.Add(Me.Panel1)
        Me.panel_details.Controls.Add(Me.label_email)
        Me.panel_details.Controls.Add(Me.text_desc)
        Me.panel_details.Controls.Add(Me.label_name)
        Me.panel_details.Controls.Add(Me.text_name)
        Me.panel_details.Controls.Add(Me.button_confirm)
        Me.panel_details.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.panel_details.GradientStartColor = System.Drawing.Color.White
        Me.panel_details.Image = Nothing
        Me.panel_details.ImageLocation = New System.Drawing.Point(4, 4)
        Me.panel_details.Location = New System.Drawing.Point(16, 217)
        Me.panel_details.Name = "panel_details"
        Me.panel_details.Size = New System.Drawing.Size(705, 350)
        Me.panel_details.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(532, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "max. 300 caracteres"
        '
        'label_dou
        '
        Me.label_dou.AutoSize = True
        Me.label_dou.BackColor = System.Drawing.Color.Transparent
        Me.label_dou.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_dou.Location = New System.Drawing.Point(14, 109)
        Me.label_dou.Name = "label_dou"
        Me.label_dou.Size = New System.Drawing.Size(92, 13)
        Me.label_dou.TabIndex = 34
        Me.label_dou.Text = "Descrição DOE"
        '
        'text_dou
        '
        Me.text_dou.BackColor = System.Drawing.SystemColors.Info
        Me.text_dou.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_dou.Location = New System.Drawing.Point(155, 107)
        Me.text_dou.MaxLength = 300
        Me.text_dou.Multiline = True
        Me.text_dou.Name = "text_dou"
        Me.text_dou.Size = New System.Drawing.Size(369, 47)
        Me.text_dou.TabIndex = 33
        '
        'combo_flag
        '
        Me.combo_flag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_flag.FormattingEnabled = True
        Me.combo_flag.Location = New System.Drawing.Point(155, 179)
        Me.combo_flag.Name = "combo_flag"
        Me.combo_flag.Size = New System.Drawing.Size(106, 21)
        Me.combo_flag.TabIndex = 32
        '
        'label_flag
        '
        Me.label_flag.AutoSize = True
        Me.label_flag.BackColor = System.Drawing.Color.Transparent
        Me.label_flag.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_flag.Location = New System.Drawing.Point(19, 179)
        Me.label_flag.Name = "label_flag"
        Me.label_flag.Size = New System.Drawing.Size(118, 13)
        Me.label_flag.TabIndex = 31
        Me.label_flag.Text = "Atualizar Processos"
        '
        'button_del
        '
        Me.button_del.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_del.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_del.ImageIndex = 3
        Me.button_del.ImageList = Me.ImageList1
        Me.button_del.Location = New System.Drawing.Point(571, 300)
        Me.button_del.Name = "button_del"
        Me.button_del.Size = New System.Drawing.Size(103, 27)
        Me.button_del.TabIndex = 30
        Me.button_del.Text = "Excluir"
        Me.button_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_del.UseVisualStyleBackColor = True
        '
        'label_tip3
        '
        Me.label_tip3.AutoSize = True
        Me.label_tip3.BackColor = System.Drawing.Color.Transparent
        Me.label_tip3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip3.Location = New System.Drawing.Point(532, 56)
        Me.label_tip3.Name = "label_tip3"
        Me.label_tip3.Size = New System.Drawing.Size(125, 13)
        Me.label_tip3.TabIndex = 29
        Me.label_tip3.Text = "max. 300 caracteres"
        '
        'label_tip4
        '
        Me.label_tip4.AutoSize = True
        Me.label_tip4.BackColor = System.Drawing.Color.Transparent
        Me.label_tip4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip4.Location = New System.Drawing.Point(339, 19)
        Me.label_tip4.Name = "label_tip4"
        Me.label_tip4.Size = New System.Drawing.Size(118, 13)
        Me.label_tip4.TabIndex = 28
        Me.label_tip4.Text = "max. 20 caracteres"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.label_tip1)
        Me.Panel1.Controls.Add(Me.label_tip2)
        Me.Panel1.Controls.Add(Me.pic_tip)
        Me.Panel1.Location = New System.Drawing.Point(15, 224)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 74)
        Me.Panel1.TabIndex = 27
        '
        'label_tip1
        '
        Me.label_tip1.AutoSize = True
        Me.label_tip1.BackColor = System.Drawing.Color.Transparent
        Me.label_tip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip1.Location = New System.Drawing.Point(78, 3)
        Me.label_tip1.Name = "label_tip1"
        Me.label_tip1.Size = New System.Drawing.Size(81, 13)
        Me.label_tip1.TabIndex = 23
        Me.label_tip1.Text = "Importante"
        '
        'label_tip2
        '
        Me.label_tip2.BackColor = System.Drawing.Color.Transparent
        Me.label_tip2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip2.Location = New System.Drawing.Point(80, 19)
        Me.label_tip2.Name = "label_tip2"
        Me.label_tip2.Size = New System.Drawing.Size(552, 83)
        Me.label_tip2.TabIndex = 22
        Me.label_tip2.Text = "Dica"
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
        'label_email
        '
        Me.label_email.AutoSize = True
        Me.label_email.BackColor = System.Drawing.Color.Transparent
        Me.label_email.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_email.Location = New System.Drawing.Point(14, 56)
        Me.label_email.Name = "label_email"
        Me.label_email.Size = New System.Drawing.Size(103, 13)
        Me.label_email.TabIndex = 21
        Me.label_email.Text = "Descrição Titular"
        '
        'text_desc
        '
        Me.text_desc.BackColor = System.Drawing.SystemColors.Info
        Me.text_desc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_desc.Location = New System.Drawing.Point(155, 54)
        Me.text_desc.MaxLength = 300
        Me.text_desc.Multiline = True
        Me.text_desc.Name = "text_desc"
        Me.text_desc.Size = New System.Drawing.Size(369, 47)
        Me.text_desc.TabIndex = 20
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.BackColor = System.Drawing.Color.Transparent
        Me.label_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(14, 19)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(40, 13)
        Me.label_name.TabIndex = 19
        Me.label_name.Text = "Nome"
        '
        'text_name
        '
        Me.text_name.BackColor = System.Drawing.SystemColors.Info
        Me.text_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_name.Location = New System.Drawing.Point(155, 17)
        Me.text_name.MaxLength = 20
        Me.text_name.Name = "text_name"
        Me.text_name.Size = New System.Drawing.Size(171, 21)
        Me.text_name.TabIndex = 18
        '
        'button_confirm
        '
        Me.button_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm.ImageIndex = 1
        Me.button_confirm.ImageList = Me.ImageList1
        Me.button_confirm.Location = New System.Drawing.Point(19, 300)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(119, 27)
        Me.button_confirm.TabIndex = 15
        Me.button_confirm.Text = "Confirmar"
        Me.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm.UseVisualStyleBackColor = True
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(12, 573)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.Size = New System.Drawing.Size(705, 43)
        Me.A1Panel1.TabIndex = 9
        '
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(575, 3)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(103, 28)
        Me.button_close.TabIndex = 2
        Me.button_close.Text = "Fechar"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_close.UseVisualStyleBackColor = True
        '
        'A1Panel2
        '
        Me.A1Panel2.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel2.Controls.Add(Me.label_desc)
        Me.A1Panel2.Controls.Add(Me.list_empresa)
        Me.A1Panel2.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel2.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel2.Image = Nothing
        Me.A1Panel2.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel2.Location = New System.Drawing.Point(16, 3)
        Me.A1Panel2.Name = "A1Panel2"
        Me.A1Panel2.Size = New System.Drawing.Size(705, 162)
        Me.A1Panel2.TabIndex = 10
        '
        'label_desc
        '
        Me.label_desc.AutoSize = True
        Me.label_desc.BackColor = System.Drawing.Color.Transparent
        Me.label_desc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc.Location = New System.Drawing.Point(15, 4)
        Me.label_desc.Name = "label_desc"
        Me.label_desc.Size = New System.Drawing.Size(344, 13)
        Me.label_desc.TabIndex = 20
        Me.label_desc.Text = "Para editar, selecione a empresa desejada na lista abaixo:"
        '
        'A1Panel3
        '
        Me.A1Panel3.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel3.Controls.Add(Me.button_add)
        Me.A1Panel3.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel3.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel3.Image = Nothing
        Me.A1Panel3.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel3.Location = New System.Drawing.Point(16, 171)
        Me.A1Panel3.Name = "A1Panel3"
        Me.A1Panel3.Size = New System.Drawing.Size(705, 43)
        Me.A1Panel3.TabIndex = 11
        '
        'form_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(735, 628)
        Me.Controls.Add(Me.A1Panel3)
        Me.Controls.Add(Me.A1Panel2)
        Me.Controls.Add(Me.A1Panel1)
        Me.Controls.Add(Me.panel_details)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_empresa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Empresas"
        CType(Me.list_empresa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_details.ResumeLayout(False)
        Me.panel_details.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_tip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel2.ResumeLayout(False)
        Me.A1Panel2.PerformLayout()
        Me.A1Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list_empresa As BrightIdeasSoftware.DataListView
    Friend WithEvents column_name As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_add As System.Windows.Forms.Button
    Friend WithEvents panel_details As Owf.Controls.A1Panel
    Friend WithEvents label_email As System.Windows.Forms.Label
    Friend WithEvents text_desc As System.Windows.Forms.TextBox
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents text_name As System.Windows.Forms.TextBox
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents column_desc As BrightIdeasSoftware.OLVColumn
    Friend WithEvents A1Panel2 As Owf.Controls.A1Panel
    Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents label_tip2 As System.Windows.Forms.Label
    Friend WithEvents pic_tip As System.Windows.Forms.PictureBox
    Friend WithEvents label_tip1 As System.Windows.Forms.Label
    Friend WithEvents label_tip4 As System.Windows.Forms.Label
    Friend WithEvents label_tip3 As System.Windows.Forms.Label
    Friend WithEvents button_del As System.Windows.Forms.Button
    Friend WithEvents A1Panel3 As Owf.Controls.A1Panel
    Friend WithEvents label_flag As System.Windows.Forms.Label
    Friend WithEvents combo_flag As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label_dou As System.Windows.Forms.Label
    Friend WithEvents text_dou As System.Windows.Forms.TextBox
End Class
