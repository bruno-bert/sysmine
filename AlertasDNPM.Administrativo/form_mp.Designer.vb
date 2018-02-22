<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_mp))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.button_add = New System.Windows.Forms.LinkLabel
        Me.list_produto = New BrightIdeasSoftware.DataListView
        Me.column_produto = New BrightIdeasSoftware.OLVColumn
        Me.column_volume = New BrightIdeasSoftware.OLVColumn
        Me.column_uso = New BrightIdeasSoftware.OLVColumn
        Me.label_produto = New System.Windows.Forms.Label
        Me.label_volume = New System.Windows.Forms.Label
        Me.text_volume = New System.Windows.Forms.TextBox
        Me.combo_unidade = New System.Windows.Forms.ComboBox
        Me.combo_mp = New System.Windows.Forms.ComboBox
        Me.label_mp = New System.Windows.Forms.Label
        Me.button_close = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button_confirm = New System.Windows.Forms.Button
        Me.timer_focus = New System.Windows.Forms.Timer(Me.components)
        Me.file_sel = New System.Windows.Forms.OpenFileDialog
        Me.A1Panel1.SuspendLayout()
        CType(Me.list_produto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Gray
        Me.A1Panel1.Controls.Add(Me.button_add)
        Me.A1Panel1.Controls.Add(Me.list_produto)
        Me.A1Panel1.Controls.Add(Me.label_produto)
        Me.A1Panel1.Controls.Add(Me.label_volume)
        Me.A1Panel1.Controls.Add(Me.text_volume)
        Me.A1Panel1.Controls.Add(Me.combo_unidade)
        Me.A1Panel1.Controls.Add(Me.combo_mp)
        Me.A1Panel1.Controls.Add(Me.label_mp)
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.Controls.Add(Me.button_confirm)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(3, 6)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.RoundCornerRadius = 20
        Me.A1Panel1.Size = New System.Drawing.Size(425, 283)
        Me.A1Panel1.TabIndex = 0
        '
        'button_add
        '
        Me.button_add.AutoSize = True
        Me.button_add.BackColor = System.Drawing.Color.Transparent
        Me.button_add.Location = New System.Drawing.Point(308, 83)
        Me.button_add.Name = "button_add"
        Me.button_add.Size = New System.Drawing.Size(93, 13)
        Me.button_add.TabIndex = 3
        Me.button_add.TabStop = True
        Me.button_add.Text = "Adicionar Novo"
        '
        'list_produto
        '
        Me.list_produto.AllColumns.Add(Me.column_produto)
        Me.list_produto.AllColumns.Add(Me.column_volume)
        Me.list_produto.AllColumns.Add(Me.column_uso)
        Me.list_produto.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_produto.BackColor = System.Drawing.Color.White
        Me.list_produto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_produto.CheckedAspectName = ""
        Me.list_produto.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_produto, Me.column_volume, Me.column_uso})
        Me.list_produto.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_produto.DataSource = Nothing
        Me.list_produto.EmptyListMsg = "Nenhum produto informado"
        Me.list_produto.EmptyListMsgFont = New System.Drawing.Font("Verdana", 8.25!)
        Me.list_produto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_produto.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_produto.FullRowSelect = True
        Me.list_produto.GridLines = True
        Me.list_produto.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_produto.HeaderUsesThemes = False
        Me.list_produto.HeaderWordWrap = True
        Me.list_produto.Location = New System.Drawing.Point(9, 99)
        Me.list_produto.Name = "list_produto"
        Me.list_produto.RowHeight = 15
        Me.list_produto.ShowGroups = False
        Me.list_produto.ShowImagesOnSubItems = True
        Me.list_produto.Size = New System.Drawing.Size(392, 119)
        Me.list_produto.TabIndex = 4
        Me.list_produto.UseAlternatingBackColors = True
        Me.list_produto.UseCompatibleStateImageBehavior = False
        Me.list_produto.UseFiltering = True
        Me.list_produto.UseHyperlinks = True
        Me.list_produto.UseTranslucentSelection = True
        Me.list_produto.View = System.Windows.Forms.View.Details
        '
        'column_produto
        '
        Me.column_produto.AspectName = "PROD_nm_produto"
        Me.column_produto.AspectToStringFormat = ""
        Me.column_produto.Text = "Produto"
        Me.column_produto.Width = 150
        '
        'column_volume
        '
        Me.column_volume.AspectName = "PRPD_qt_produto"
        Me.column_volume.Text = "Volume"
        Me.column_volume.Width = 100
        '
        'column_uso
        '
        Me.column_uso.AspectName = "UPRD_nm_uso"
        Me.column_uso.Text = "Tipo Uso"
        Me.column_uso.Width = 120
        '
        'label_produto
        '
        Me.label_produto.AutoSize = True
        Me.label_produto.BackColor = System.Drawing.Color.Transparent
        Me.label_produto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_produto.Location = New System.Drawing.Point(9, 83)
        Me.label_produto.Name = "label_produto"
        Me.label_produto.Size = New System.Drawing.Size(67, 13)
        Me.label_produto.TabIndex = 52
        Me.label_produto.Text = "Produto(s)"
        '
        'label_volume
        '
        Me.label_volume.AutoSize = True
        Me.label_volume.BackColor = System.Drawing.Color.Transparent
        Me.label_volume.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_volume.Location = New System.Drawing.Point(65, 52)
        Me.label_volume.Name = "label_volume"
        Me.label_volume.Size = New System.Drawing.Size(50, 13)
        Me.label_volume.TabIndex = 51
        Me.label_volume.Text = "Volume"
        '
        'text_volume
        '
        Me.text_volume.BackColor = System.Drawing.SystemColors.Info
        Me.text_volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_volume.Location = New System.Drawing.Point(127, 44)
        Me.text_volume.MaxLength = 30
        Me.text_volume.Name = "text_volume"
        Me.text_volume.Size = New System.Drawing.Size(113, 21)
        Me.text_volume.TabIndex = 1
        Me.text_volume.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'combo_unidade
        '
        Me.combo_unidade.BackColor = System.Drawing.SystemColors.Info
        Me.combo_unidade.FormattingEnabled = True
        Me.combo_unidade.Location = New System.Drawing.Point(246, 44)
        Me.combo_unidade.Name = "combo_unidade"
        Me.combo_unidade.Size = New System.Drawing.Size(69, 21)
        Me.combo_unidade.TabIndex = 2
        '
        'combo_mp
        '
        Me.combo_mp.BackColor = System.Drawing.SystemColors.Info
        Me.combo_mp.FormattingEnabled = True
        Me.combo_mp.Location = New System.Drawing.Point(127, 17)
        Me.combo_mp.Name = "combo_mp"
        Me.combo_mp.Size = New System.Drawing.Size(188, 21)
        Me.combo_mp.TabIndex = 0
        '
        'label_mp
        '
        Me.label_mp.AutoSize = True
        Me.label_mp.BackColor = System.Drawing.Color.Transparent
        Me.label_mp.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_mp.Location = New System.Drawing.Point(28, 20)
        Me.label_mp.Name = "label_mp"
        Me.label_mp.Size = New System.Drawing.Size(87, 13)
        Me.label_mp.TabIndex = 38
        Me.label_mp.Text = "Matéria-Prima"
        '
        'button_close
        '
        Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(300, 237)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(101, 28)
        Me.button_close.TabIndex = 6
        Me.button_close.Text = "Cancelar"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_close.UseVisualStyleBackColor = True
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
        'button_confirm
        '
        Me.button_confirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.button_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm.ImageIndex = 1
        Me.button_confirm.ImageList = Me.ImageList1
        Me.button_confirm.Location = New System.Drawing.Point(12, 237)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(111, 27)
        Me.button_confirm.TabIndex = 5
        Me.button_confirm.Text = "Confirmar"
        Me.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm.UseVisualStyleBackColor = True
        '
        'timer_focus
        '
        Me.timer_focus.Enabled = True
        '
        'form_mp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(429, 297)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_mp"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Matéria-Prima"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        CType(Me.list_produto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents combo_mp As System.Windows.Forms.ComboBox
    Friend WithEvents label_mp As System.Windows.Forms.Label
    Friend WithEvents timer_focus As System.Windows.Forms.Timer
    Friend WithEvents combo_unidade As System.Windows.Forms.ComboBox
    Friend WithEvents file_sel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents label_volume As System.Windows.Forms.Label
    Friend WithEvents text_volume As System.Windows.Forms.TextBox
    Friend WithEvents label_produto As System.Windows.Forms.Label
    Friend WithEvents list_produto As BrightIdeasSoftware.DataListView
    Friend WithEvents column_produto As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_volume As BrightIdeasSoftware.OLVColumn
    Friend WithEvents column_uso As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_add As System.Windows.Forms.LinkLabel
End Class
