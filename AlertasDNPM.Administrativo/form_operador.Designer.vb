<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_operador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_operador))
        Me.list_operator = New BrightIdeasSoftware.DataListView
        Me.column_code = New BrightIdeasSoftware.OLVColumn
        Me.column_name = New BrightIdeasSoftware.OLVColumn
        Me.column_email = New BrightIdeasSoftware.OLVColumn
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle
        Me.button_add = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.panel_details = New Owf.Controls.A1Panel
        Me.button_del = New System.Windows.Forms.Button
        Me.combo_flag2 = New System.Windows.Forms.ComboBox
        Me.text_code = New System.Windows.Forms.TextBox
        Me.combo_flag1 = New System.Windows.Forms.ComboBox
        Me.label_flag2 = New System.Windows.Forms.Label
        Me.label_flag1 = New System.Windows.Forms.Label
        Me.label_email = New System.Windows.Forms.Label
        Me.text_email = New System.Windows.Forms.TextBox
        Me.label_name = New System.Windows.Forms.Label
        Me.text_name = New System.Windows.Forms.TextBox
        Me.button_confirm = New System.Windows.Forms.Button
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.button_close = New System.Windows.Forms.Button
        Me.A1Panel2 = New Owf.Controls.A1Panel
        Me.label_desc = New System.Windows.Forms.Label
        Me.A1Panel3 = New Owf.Controls.A1Panel
        Me.combo_flag3 = New System.Windows.Forms.ComboBox
        Me.label_inclusao = New System.Windows.Forms.Label
        CType(Me.list_operator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_details.SuspendLayout()
        Me.A1Panel1.SuspendLayout()
        Me.A1Panel2.SuspendLayout()
        Me.A1Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'list_operator
        '
        Me.list_operator.AllColumns.Add(Me.column_code)
        Me.list_operator.AllColumns.Add(Me.column_name)
        Me.list_operator.AllColumns.Add(Me.column_email)
        Me.list_operator.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_operator.BackColor = System.Drawing.Color.White
        Me.list_operator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_operator.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_code, Me.column_name, Me.column_email})
        Me.list_operator.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_operator.DataSource = Nothing
        Me.list_operator.EmptyListMsg = "Não há operadores. Para inserir, clique no botão ""Inserir"""
        Me.list_operator.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_operator.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_operator.FullRowSelect = True
        Me.list_operator.GridLines = True
        Me.list_operator.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_operator.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_operator.HeaderUsesThemes = False
        Me.list_operator.Location = New System.Drawing.Point(14, 24)
        Me.list_operator.MultiSelect = False
        Me.list_operator.Name = "list_operator"
        Me.list_operator.RowHeight = 15
        Me.list_operator.ShowGroups = False
        Me.list_operator.Size = New System.Drawing.Size(660, 126)
        Me.list_operator.TabIndex = 0
        Me.list_operator.UseAlternatingBackColors = True
        Me.list_operator.UseCompatibleStateImageBehavior = False
        Me.list_operator.UseFiltering = True
        Me.list_operator.UseTranslucentSelection = True
        Me.list_operator.View = System.Windows.Forms.View.Details
        '
        'column_code
        '
        Me.column_code.AspectName = "OPER_cd_operador"
        Me.column_code.Hideable = False
        Me.column_code.IsEditable = False
        Me.column_code.Text = "Código"
        '
        'column_name
        '
        Me.column_name.AspectName = "OPER_nm_operador"
        Me.column_name.FillsFreeSpace = True
        Me.column_name.Hideable = False
        Me.column_name.IsEditable = False
        Me.column_name.Text = "Nome Completo"
        '
        'column_email
        '
        Me.column_email.AspectName = "OPER_ds_email"
        Me.column_email.FillsFreeSpace = True
        Me.column_email.Hideable = False
        Me.column_email.IsEditable = False
        Me.column_email.Text = "Email"
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
        Me.button_add.Location = New System.Drawing.Point(10, 4)
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
        Me.panel_details.Controls.Add(Me.combo_flag3)
        Me.panel_details.Controls.Add(Me.label_inclusao)
        Me.panel_details.Controls.Add(Me.button_del)
        Me.panel_details.Controls.Add(Me.combo_flag2)
        Me.panel_details.Controls.Add(Me.text_code)
        Me.panel_details.Controls.Add(Me.combo_flag1)
        Me.panel_details.Controls.Add(Me.label_flag2)
        Me.panel_details.Controls.Add(Me.label_flag1)
        Me.panel_details.Controls.Add(Me.label_email)
        Me.panel_details.Controls.Add(Me.text_email)
        Me.panel_details.Controls.Add(Me.label_name)
        Me.panel_details.Controls.Add(Me.text_name)
        Me.panel_details.Controls.Add(Me.button_confirm)
        Me.panel_details.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.panel_details.GradientStartColor = System.Drawing.Color.White
        Me.panel_details.Image = Nothing
        Me.panel_details.ImageLocation = New System.Drawing.Point(4, 4)
        Me.panel_details.Location = New System.Drawing.Point(16, 216)
        Me.panel_details.Name = "panel_details"
        Me.panel_details.Size = New System.Drawing.Size(705, 219)
        Me.panel_details.TabIndex = 8
        '
        'button_del
        '
        Me.button_del.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_del.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_del.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_del.ImageIndex = 3
        Me.button_del.ImageList = Me.ImageList1
        Me.button_del.Location = New System.Drawing.Point(584, 175)
        Me.button_del.Name = "button_del"
        Me.button_del.Size = New System.Drawing.Size(103, 27)
        Me.button_del.TabIndex = 31
        Me.button_del.Text = "Excluir"
        Me.button_del.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_del.UseVisualStyleBackColor = True
        '
        'combo_flag2
        '
        Me.combo_flag2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag2.FormattingEnabled = True
        Me.combo_flag2.Location = New System.Drawing.Point(369, 108)
        Me.combo_flag2.Name = "combo_flag2"
        Me.combo_flag2.Size = New System.Drawing.Size(74, 21)
        Me.combo_flag2.TabIndex = 30
        '
        'text_code
        '
        Me.text_code.Location = New System.Drawing.Point(626, 80)
        Me.text_code.Name = "text_code"
        Me.text_code.Size = New System.Drawing.Size(51, 21)
        Me.text_code.TabIndex = 26
        Me.text_code.Visible = False
        '
        'combo_flag1
        '
        Me.combo_flag1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag1.FormattingEnabled = True
        Me.combo_flag1.Location = New System.Drawing.Point(369, 83)
        Me.combo_flag1.Name = "combo_flag1"
        Me.combo_flag1.Size = New System.Drawing.Size(74, 21)
        Me.combo_flag1.TabIndex = 29
        '
        'label_flag2
        '
        Me.label_flag2.AutoSize = True
        Me.label_flag2.BackColor = System.Drawing.Color.Transparent
        Me.label_flag2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_flag2.Location = New System.Drawing.Point(14, 116)
        Me.label_flag2.Name = "label_flag2"
        Me.label_flag2.Size = New System.Drawing.Size(208, 13)
        Me.label_flag2.TabIndex = 23
        Me.label_flag2.Text = "Receber alertas nativos do sistema"
        '
        'label_flag1
        '
        Me.label_flag1.AutoSize = True
        Me.label_flag1.BackColor = System.Drawing.Color.Transparent
        Me.label_flag1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_flag1.Location = New System.Drawing.Point(14, 86)
        Me.label_flag1.Name = "label_flag1"
        Me.label_flag1.Size = New System.Drawing.Size(174, 13)
        Me.label_flag1.TabIndex = 22
        Me.label_flag1.Text = "Receber alertas configurados"
        '
        'label_email
        '
        Me.label_email.AutoSize = True
        Me.label_email.BackColor = System.Drawing.Color.Transparent
        Me.label_email.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_email.Location = New System.Drawing.Point(14, 56)
        Me.label_email.Name = "label_email"
        Me.label_email.Size = New System.Drawing.Size(38, 13)
        Me.label_email.TabIndex = 21
        Me.label_email.Text = "Email"
        '
        'text_email
        '
        Me.text_email.BackColor = System.Drawing.SystemColors.Info
        Me.text_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_email.Location = New System.Drawing.Point(155, 54)
        Me.text_email.MaxLength = 200
        Me.text_email.Name = "text_email"
        Me.text_email.Size = New System.Drawing.Size(522, 21)
        Me.text_email.TabIndex = 20
        '
        'label_name
        '
        Me.label_name.AutoSize = True
        Me.label_name.BackColor = System.Drawing.Color.Transparent
        Me.label_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_name.Location = New System.Drawing.Point(14, 19)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(99, 13)
        Me.label_name.TabIndex = 19
        Me.label_name.Text = "Nome Completo"
        '
        'text_name
        '
        Me.text_name.BackColor = System.Drawing.SystemColors.Info
        Me.text_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_name.Location = New System.Drawing.Point(155, 17)
        Me.text_name.MaxLength = 300
        Me.text_name.Name = "text_name"
        Me.text_name.Size = New System.Drawing.Size(522, 21)
        Me.text_name.TabIndex = 18
        '
        'button_confirm
        '
        Me.button_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm.ImageIndex = 1
        Me.button_confirm.ImageList = Me.ImageList1
        Me.button_confirm.Location = New System.Drawing.Point(19, 175)
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
        Me.A1Panel1.Location = New System.Drawing.Point(16, 439)
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
        Me.button_close.Location = New System.Drawing.Point(584, 5)
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
        Me.A1Panel2.Controls.Add(Me.list_operator)
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
        Me.label_desc.Size = New System.Drawing.Size(346, 13)
        Me.label_desc.TabIndex = 20
        Me.label_desc.Text = "Para editar, selecione o operador desejado na lista abaixo:"
        '
        'A1Panel3
        '
        Me.A1Panel3.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel3.Controls.Add(Me.button_add)
        Me.A1Panel3.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel3.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel3.Image = Nothing
        Me.A1Panel3.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel3.Location = New System.Drawing.Point(14, 171)
        Me.A1Panel3.Name = "A1Panel3"
        Me.A1Panel3.Size = New System.Drawing.Size(705, 43)
        Me.A1Panel3.TabIndex = 11
        '
        'combo_flag3
        '
        Me.combo_flag3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_flag3.FormattingEnabled = True
        Me.combo_flag3.Location = New System.Drawing.Point(369, 135)
        Me.combo_flag3.Name = "combo_flag3"
        Me.combo_flag3.Size = New System.Drawing.Size(74, 21)
        Me.combo_flag3.TabIndex = 33
        '
        'label_inclusao
        '
        Me.label_inclusao.AutoSize = True
        Me.label_inclusao.BackColor = System.Drawing.Color.Transparent
        Me.label_inclusao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_inclusao.Location = New System.Drawing.Point(14, 143)
        Me.label_inclusao.Name = "label_inclusao"
        Me.label_inclusao.Size = New System.Drawing.Size(294, 13)
        Me.label_inclusao.TabIndex = 32
        Me.label_inclusao.Text = "Ao incluir operador, associar processos existentes"
        '
        'form_operador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(735, 487)
        Me.Controls.Add(Me.A1Panel3)
        Me.Controls.Add(Me.A1Panel2)
        Me.Controls.Add(Me.A1Panel1)
        Me.Controls.Add(Me.panel_details)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_operador"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Operadores"
        CType(Me.list_operator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_details.ResumeLayout(False)
        Me.panel_details.PerformLayout()
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel2.ResumeLayout(False)
        Me.A1Panel2.PerformLayout()
        Me.A1Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list_operator As BrightIdeasSoftware.DataListView
    Friend WithEvents column_code As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_name As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_add As System.Windows.Forms.Button
    Friend WithEvents panel_details As Owf.Controls.A1Panel
    Friend WithEvents label_flag2 As System.Windows.Forms.Label
    Friend WithEvents label_flag1 As System.Windows.Forms.Label
    Friend WithEvents label_email As System.Windows.Forms.Label
    Friend WithEvents text_email As System.Windows.Forms.TextBox
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents text_name As System.Windows.Forms.TextBox
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents text_code As System.Windows.Forms.TextBox
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents column_email As BrightIdeasSoftware.OLVColumn
    Friend WithEvents A1Panel2 As Owf.Controls.A1Panel
    Friend WithEvents combo_flag1 As System.Windows.Forms.ComboBox
    Friend WithEvents combo_flag2 As System.Windows.Forms.ComboBox
    Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents A1Panel3 As Owf.Controls.A1Panel
    Friend WithEvents button_del As System.Windows.Forms.Button
    Friend WithEvents combo_flag3 As System.Windows.Forms.ComboBox
    Friend WithEvents label_inclusao As System.Windows.Forms.Label
End Class
