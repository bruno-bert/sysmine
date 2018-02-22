<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_limpa
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
        Dim HeaderStateStyle7 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim HeaderStateStyle8 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim HeaderStateStyle9 As BrightIdeasSoftware.HeaderStateStyle = New BrightIdeasSoftware.HeaderStateStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_limpa))
        Me.list_dados = New BrightIdeasSoftware.DataListView
        Me.column_name = New BrightIdeasSoftware.OLVColumn
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.button_close = New System.Windows.Forms.Button
        Me.A1Panel2 = New Owf.Controls.A1Panel
        Me.combo_tabela = New System.Windows.Forms.ComboBox
        Me.label_desc = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.label_tip1 = New System.Windows.Forms.Label
        Me.label_tip2 = New System.Windows.Forms.Label
        Me.pic_tip = New System.Windows.Forms.PictureBox
        CType(Me.list_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.A1Panel1.SuspendLayout()
        Me.A1Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pic_tip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'list_dados
        '
        Me.list_dados.AllColumns.Add(Me.column_name)
        Me.list_dados.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_dados.BackColor = System.Drawing.Color.White
        Me.list_dados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_dados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_name})
        Me.list_dados.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_dados.DataSource = Nothing
        Me.list_dados.EmptyListMsg = "Nenhum registro encontrado"
        Me.list_dados.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_dados.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_dados.FullRowSelect = True
        Me.list_dados.GridLines = True
        Me.list_dados.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.list_dados.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_dados.HeaderUsesThemes = False
        Me.list_dados.Location = New System.Drawing.Point(18, 36)
        Me.list_dados.Name = "list_dados"
        Me.list_dados.RowHeight = 15
        Me.list_dados.ShowGroups = False
        Me.list_dados.Size = New System.Drawing.Size(670, 320)
        Me.list_dados.TabIndex = 0
        Me.list_dados.UseAlternatingBackColors = True
        Me.list_dados.UseCompatibleStateImageBehavior = False
        Me.list_dados.UseFiltering = True
        Me.list_dados.UseTranslucentSelection = True
        Me.list_dados.View = System.Windows.Forms.View.Details
        '
        'column_name
        '
        Me.column_name.AspectName = "REG_nm_registro"
        Me.column_name.FillsFreeSpace = True
        Me.column_name.Hideable = False
        Me.column_name.IsEditable = False
        Me.column_name.Text = "Registro"
        Me.column_name.Width = 662
        '
        'HeaderFormatStyle1
        '
        HeaderStateStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HeaderStateStyle7.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle7.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Hot = HeaderStateStyle7
        HeaderStateStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        HeaderStateStyle8.ForeColor = System.Drawing.Color.Black
        HeaderStateStyle8.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle8.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Normal = HeaderStateStyle8
        HeaderStateStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        HeaderStateStyle9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        HeaderStateStyle9.FrameColor = System.Drawing.Color.Silver
        HeaderStateStyle9.FrameWidth = 1.0!
        Me.HeaderFormatStyle1.Pressed = HeaderStateStyle9
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
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(16, 440)
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
        Me.button_close.Location = New System.Drawing.Point(589, 5)
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
        Me.A1Panel2.Controls.Add(Me.combo_tabela)
        Me.A1Panel2.Controls.Add(Me.label_desc)
        Me.A1Panel2.Controls.Add(Me.list_dados)
        Me.A1Panel2.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel2.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel2.Image = Nothing
        Me.A1Panel2.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel2.Location = New System.Drawing.Point(16, 3)
        Me.A1Panel2.Name = "A1Panel2"
        Me.A1Panel2.Size = New System.Drawing.Size(705, 374)
        Me.A1Panel2.TabIndex = 10
        '
        'combo_tabela
        '
        Me.combo_tabela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_tabela.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.combo_tabela.FormattingEnabled = True
        Me.combo_tabela.Location = New System.Drawing.Point(184, 9)
        Me.combo_tabela.Name = "combo_tabela"
        Me.combo_tabela.Size = New System.Drawing.Size(504, 21)
        Me.combo_tabela.TabIndex = 34
        '
        'label_desc
        '
        Me.label_desc.AutoSize = True
        Me.label_desc.BackColor = System.Drawing.Color.Transparent
        Me.label_desc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc.Location = New System.Drawing.Point(15, 12)
        Me.label_desc.Name = "label_desc"
        Me.label_desc.Size = New System.Drawing.Size(163, 13)
        Me.label_desc.TabIndex = 20
        Me.label_desc.Text = "Selecione a tabela auxiliar:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Info
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.label_tip1)
        Me.Panel1.Controls.Add(Me.label_tip2)
        Me.Panel1.Controls.Add(Me.pic_tip)
        Me.Panel1.Location = New System.Drawing.Point(16, 383)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(701, 51)
        Me.Panel1.TabIndex = 28
        '
        'label_tip1
        '
        Me.label_tip1.AutoSize = True
        Me.label_tip1.BackColor = System.Drawing.Color.Transparent
        Me.label_tip1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip1.Location = New System.Drawing.Point(78, 3)
        Me.label_tip1.Name = "label_tip1"
        Me.label_tip1.Size = New System.Drawing.Size(35, 13)
        Me.label_tip1.TabIndex = 23
        Me.label_tip1.Text = "Dica"
        '
        'label_tip2
        '
        Me.label_tip2.BackColor = System.Drawing.Color.Transparent
        Me.label_tip2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tip2.Location = New System.Drawing.Point(80, 19)
        Me.label_tip2.Name = "label_tip2"
        Me.label_tip2.Size = New System.Drawing.Size(552, 23)
        Me.label_tip2.TabIndex = 22
        Me.label_tip2.Text = "Para excluir, selecione o(s) registro(s) na lista acima e pressione a tecla DEL"
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
        'form_limpa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(735, 491)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.A1Panel2)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_limpa"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Limpeza Geral - Cadastros auxiliares"
        CType(Me.list_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel2.ResumeLayout(False)
        Me.A1Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pic_tip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list_dados As BrightIdeasSoftware.DataListView
    Friend WithEvents column_name As BrightIdeasSoftware.OLVColumn
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents A1Panel2 As Owf.Controls.A1Panel
    Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents combo_tabela As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents label_tip1 As System.Windows.Forms.Label
    Friend WithEvents label_tip2 As System.Windows.Forms.Label
    Friend WithEvents pic_tip As System.Windows.Forms.PictureBox
End Class
