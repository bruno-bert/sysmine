<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_lista_evento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_lista_evento))
        Me.HeaderFormatStyle1 = New BrightIdeasSoftware.HeaderFormatStyle
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.panel_command = New Owf.Controls.A1Panel
        Me.button_close = New System.Windows.Forms.Button
        Me.A1Panel2 = New Owf.Controls.A1Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.button_clear_filter = New System.Windows.Forms.Button
        Me.text_filter = New System.Windows.Forms.TextBox
        Me.label_filter = New System.Windows.Forms.Label
        Me.pic_filter = New System.Windows.Forms.PictureBox
        Me.list_evento = New BrightIdeasSoftware.DataListView
        Me.column_desc = New BrightIdeasSoftware.OLVColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.panel_command.SuspendLayout()
        Me.A1Panel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pic_filter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.list_evento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.ImageList1.Images.SetKeyName(6, "report.png")
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
        Me.panel_command.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panel_command.BorderColor = System.Drawing.Color.Silver
        Me.panel_command.Controls.Add(Me.button_close)
        Me.panel_command.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.panel_command.GradientStartColor = System.Drawing.Color.White
        Me.panel_command.Image = Nothing
        Me.panel_command.ImageLocation = New System.Drawing.Point(4, 4)
        Me.panel_command.Location = New System.Drawing.Point(10, 626)
        Me.panel_command.Name = "panel_command"
        Me.panel_command.Size = New System.Drawing.Size(912, 42)
        Me.panel_command.TabIndex = 11
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
        'A1Panel2
        '
        Me.A1Panel2.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel2.Controls.Add(Me.Panel2)
        Me.A1Panel2.Controls.Add(Me.list_evento)
        Me.A1Panel2.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel2.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel2.Image = Nothing
        Me.A1Panel2.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel2.Location = New System.Drawing.Point(6, 19)
        Me.A1Panel2.Name = "A1Panel2"
        Me.A1Panel2.Size = New System.Drawing.Size(909, 588)
        Me.A1Panel2.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Info
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.button_clear_filter)
        Me.Panel2.Controls.Add(Me.text_filter)
        Me.Panel2.Controls.Add(Me.label_filter)
        Me.Panel2.Controls.Add(Me.pic_filter)
        Me.Panel2.Location = New System.Drawing.Point(16, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(659, 59)
        Me.Panel2.TabIndex = 21
        '
        'button_clear_filter
        '
        Me.button_clear_filter.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_clear_filter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_clear_filter.ImageIndex = 0
        Me.button_clear_filter.ImageList = Me.ImageList2
        Me.button_clear_filter.Location = New System.Drawing.Point(485, 10)
        Me.button_clear_filter.Name = "button_clear_filter"
        Me.button_clear_filter.Size = New System.Drawing.Size(147, 39)
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
        Me.text_filter.MaxLength = 30
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
        'list_evento
        '
        Me.list_evento.AllColumns.Add(Me.column_desc)
        Me.list_evento.AlternateRowBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.list_evento.BackColor = System.Drawing.Color.White
        Me.list_evento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.list_evento.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.column_desc})
        Me.list_evento.Cursor = System.Windows.Forms.Cursors.Default
        Me.list_evento.DataSource = Nothing
        Me.list_evento.EmptyListMsg = "Não há processos minerários. Para inserir, clique no botão ""Inserir"""
        Me.list_evento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_evento.ForeColor = System.Drawing.SystemColors.InfoText
        Me.list_evento.FullRowSelect = True
        Me.list_evento.GridLines = True
        Me.list_evento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_evento.HeaderFormatStyle = Me.HeaderFormatStyle1
        Me.list_evento.HeaderUsesThemes = False
        Me.list_evento.Location = New System.Drawing.Point(8, 98)
        Me.list_evento.Name = "list_evento"
        Me.list_evento.RowHeight = 15
        Me.list_evento.ShowGroups = False
        Me.list_evento.Size = New System.Drawing.Size(877, 477)
        Me.list_evento.TabIndex = 0
        Me.list_evento.UseAlternatingBackColors = True
        Me.list_evento.UseCellFormatEvents = True
        Me.list_evento.UseCompatibleStateImageBehavior = False
        Me.list_evento.UseFiltering = True
        Me.list_evento.UseHyperlinks = True
        Me.list_evento.UseTranslucentSelection = True
        Me.list_evento.View = System.Windows.Forms.View.Details
        '
        'column_desc
        '
        Me.column_desc.AspectName = "Evento"
        Me.column_desc.FillsFreeSpace = True
        Me.column_desc.Hideable = False
        Me.column_desc.IsEditable = False
        Me.column_desc.Text = "Descrição"
        Me.column_desc.Width = 800
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.A1Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(914, 613)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de Eventos DNPM"
        '
        'form_lista_evento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(922, 671)
        Me.Controls.Add(Me.panel_command)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_lista_evento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Lista de Eventos DNPM"
        Me.panel_command.ResumeLayout(False)
        Me.A1Panel2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.pic_filter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.list_evento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents HeaderFormatStyle1 As BrightIdeasSoftware.HeaderFormatStyle
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents panel_command As Owf.Controls.A1Panel
    Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
    Friend WithEvents A1Panel2 As Owf.Controls.A1Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents button_clear_filter As System.Windows.Forms.Button
    Friend WithEvents text_filter As System.Windows.Forms.TextBox
    Friend WithEvents label_filter As System.Windows.Forms.Label
    Friend WithEvents pic_filter As System.Windows.Forms.PictureBox
    Friend WithEvents list_evento As BrightIdeasSoftware.DataListView
    Friend WithEvents column_desc As BrightIdeasSoftware.OLVColumn
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
