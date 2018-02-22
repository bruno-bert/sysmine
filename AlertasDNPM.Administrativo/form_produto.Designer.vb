<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_produto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_produto))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.combo_uso = New System.Windows.Forms.ComboBox
        Me.label_uso = New System.Windows.Forms.Label
        Me.label_volume = New System.Windows.Forms.Label
        Me.text_volume = New System.Windows.Forms.TextBox
        Me.combo_unidade = New System.Windows.Forms.ComboBox
        Me.combo_produto = New System.Windows.Forms.ComboBox
        Me.label_produto = New System.Windows.Forms.Label
        Me.button_close = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button_confirm = New System.Windows.Forms.Button
        Me.timer_focus = New System.Windows.Forms.Timer(Me.components)
        Me.file_sel = New System.Windows.Forms.OpenFileDialog
        Me.A1Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Gray
        Me.A1Panel1.Controls.Add(Me.combo_uso)
        Me.A1Panel1.Controls.Add(Me.label_uso)
        Me.A1Panel1.Controls.Add(Me.label_volume)
        Me.A1Panel1.Controls.Add(Me.text_volume)
        Me.A1Panel1.Controls.Add(Me.combo_unidade)
        Me.A1Panel1.Controls.Add(Me.combo_produto)
        Me.A1Panel1.Controls.Add(Me.label_produto)
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.Controls.Add(Me.button_confirm)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(3, 6)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.RoundCornerRadius = 20
        Me.A1Panel1.Size = New System.Drawing.Size(335, 176)
        Me.A1Panel1.TabIndex = 0
        '
        'combo_uso
        '
        Me.combo_uso.BackColor = System.Drawing.SystemColors.Info
        Me.combo_uso.FormattingEnabled = True
        Me.combo_uso.Location = New System.Drawing.Point(97, 81)
        Me.combo_uso.Name = "combo_uso"
        Me.combo_uso.Size = New System.Drawing.Size(186, 21)
        Me.combo_uso.TabIndex = 3
        '
        'label_uso
        '
        Me.label_uso.AutoSize = True
        Me.label_uso.BackColor = System.Drawing.Color.Transparent
        Me.label_uso.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_uso.Location = New System.Drawing.Point(17, 84)
        Me.label_uso.Name = "label_uso"
        Me.label_uso.Size = New System.Drawing.Size(74, 13)
        Me.label_uso.TabIndex = 53
        Me.label_uso.Text = "Tipo de Uso"
        '
        'label_volume
        '
        Me.label_volume.AutoSize = True
        Me.label_volume.BackColor = System.Drawing.Color.Transparent
        Me.label_volume.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_volume.Location = New System.Drawing.Point(34, 57)
        Me.label_volume.Name = "label_volume"
        Me.label_volume.Size = New System.Drawing.Size(50, 13)
        Me.label_volume.TabIndex = 51
        Me.label_volume.Text = "Volume"
        '
        'text_volume
        '
        Me.text_volume.BackColor = System.Drawing.SystemColors.Info
        Me.text_volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_volume.Location = New System.Drawing.Point(96, 49)
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
        Me.combo_unidade.Location = New System.Drawing.Point(215, 49)
        Me.combo_unidade.Name = "combo_unidade"
        Me.combo_unidade.Size = New System.Drawing.Size(69, 21)
        Me.combo_unidade.TabIndex = 2
        '
        'combo_produto
        '
        Me.combo_produto.BackColor = System.Drawing.SystemColors.Info
        Me.combo_produto.FormattingEnabled = True
        Me.combo_produto.Location = New System.Drawing.Point(95, 17)
        Me.combo_produto.Name = "combo_produto"
        Me.combo_produto.Size = New System.Drawing.Size(188, 21)
        Me.combo_produto.TabIndex = 0
        '
        'label_produto
        '
        Me.label_produto.AutoSize = True
        Me.label_produto.BackColor = System.Drawing.Color.Transparent
        Me.label_produto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_produto.Location = New System.Drawing.Point(32, 20)
        Me.label_produto.Name = "label_produto"
        Me.label_produto.Size = New System.Drawing.Size(51, 13)
        Me.label_produto.TabIndex = 38
        Me.label_produto.Text = "Produto"
        '
        'button_close
        '
        Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(214, 127)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(101, 28)
        Me.button_close.TabIndex = 5
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
        Me.button_confirm.Location = New System.Drawing.Point(20, 128)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(111, 27)
        Me.button_confirm.TabIndex = 4
        Me.button_confirm.Text = "Confirmar"
        Me.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm.UseVisualStyleBackColor = True
        '
        'timer_focus
        '
        Me.timer_focus.Enabled = True
        '
        'form_produto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(340, 181)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_produto"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Produto"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents combo_produto As System.Windows.Forms.ComboBox
    Friend WithEvents label_produto As System.Windows.Forms.Label
    Friend WithEvents timer_focus As System.Windows.Forms.Timer
    Friend WithEvents combo_unidade As System.Windows.Forms.ComboBox
    Friend WithEvents file_sel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents label_volume As System.Windows.Forms.Label
    Friend WithEvents text_volume As System.Windows.Forms.TextBox
    Friend WithEvents combo_uso As System.Windows.Forms.ComboBox
    Friend WithEvents label_uso As System.Windows.Forms.Label
End Class
