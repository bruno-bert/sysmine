<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_info
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_info))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.label_motivo = New System.Windows.Forms.Label
        Me.text_descricao = New System.Windows.Forms.TextBox
        Me.combo_situacao = New System.Windows.Forms.ComboBox
        Me.label_situacao = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.button_del_arquivo = New System.Windows.Forms.Button
        Me.text_arquivo1 = New System.Windows.Forms.TextBox
        Me.button_sel = New System.Windows.Forms.Button
        Me.label_arquivo1 = New System.Windows.Forms.Label
        Me.label_arquivo2 = New System.Windows.Forms.Label
        Me.text_arquivo2 = New System.Windows.Forms.TextBox
        Me.text_arquivo3 = New System.Windows.Forms.TextBox
        Me.label_arquivo3 = New System.Windows.Forms.Label
        Me.combo_nome = New System.Windows.Forms.ComboBox
        Me.label_nome = New System.Windows.Forms.Label
        Me.button_close = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button_confirm = New System.Windows.Forms.Button
        Me.timer_focus = New System.Windows.Forms.Timer(Me.components)
        Me.file_sel = New System.Windows.Forms.OpenFileDialog
        Me.A1Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Gray
        Me.A1Panel1.Controls.Add(Me.label_motivo)
        Me.A1Panel1.Controls.Add(Me.text_descricao)
        Me.A1Panel1.Controls.Add(Me.combo_situacao)
        Me.A1Panel1.Controls.Add(Me.label_situacao)
        Me.A1Panel1.Controls.Add(Me.GroupBox1)
        Me.A1Panel1.Controls.Add(Me.combo_nome)
        Me.A1Panel1.Controls.Add(Me.label_nome)
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.Controls.Add(Me.button_confirm)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(3, 6)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.RoundCornerRadius = 20
        Me.A1Panel1.Size = New System.Drawing.Size(688, 312)
        Me.A1Panel1.TabIndex = 0
        '
        'label_motivo
        '
        Me.label_motivo.AutoSize = True
        Me.label_motivo.BackColor = System.Drawing.Color.Transparent
        Me.label_motivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_motivo.Location = New System.Drawing.Point(17, 57)
        Me.label_motivo.Name = "label_motivo"
        Me.label_motivo.Size = New System.Drawing.Size(63, 13)
        Me.label_motivo.TabIndex = 52
        Me.label_motivo.Text = "Descrição"
        '
        'text_descricao
        '
        Me.text_descricao.BackColor = System.Drawing.SystemColors.Info
        Me.text_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_descricao.Location = New System.Drawing.Point(86, 55)
        Me.text_descricao.MaxLength = 500
        Me.text_descricao.Name = "text_descricao"
        Me.text_descricao.Size = New System.Drawing.Size(571, 21)
        Me.text_descricao.TabIndex = 1
        '
        'combo_situacao
        '
        Me.combo_situacao.BackColor = System.Drawing.SystemColors.Info
        Me.combo_situacao.FormattingEnabled = True
        Me.combo_situacao.Location = New System.Drawing.Point(86, 97)
        Me.combo_situacao.Name = "combo_situacao"
        Me.combo_situacao.Size = New System.Drawing.Size(266, 21)
        Me.combo_situacao.TabIndex = 2
        '
        'label_situacao
        '
        Me.label_situacao.AutoSize = True
        Me.label_situacao.BackColor = System.Drawing.Color.Transparent
        Me.label_situacao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_situacao.Location = New System.Drawing.Point(24, 100)
        Me.label_situacao.Name = "label_situacao"
        Me.label_situacao.Size = New System.Drawing.Size(56, 13)
        Me.label_situacao.TabIndex = 50
        Me.label_situacao.Text = "Situação"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.button_del_arquivo)
        Me.GroupBox1.Controls.Add(Me.text_arquivo1)
        Me.GroupBox1.Controls.Add(Me.button_sel)
        Me.GroupBox1.Controls.Add(Me.label_arquivo1)
        Me.GroupBox1.Controls.Add(Me.label_arquivo2)
        Me.GroupBox1.Controls.Add(Me.text_arquivo2)
        Me.GroupBox1.Controls.Add(Me.text_arquivo3)
        Me.GroupBox1.Controls.Add(Me.label_arquivo3)
        Me.GroupBox1.Location = New System.Drawing.Point(27, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 106)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Anexar Arquivo"
        '
        'button_del_arquivo
        '
        Me.button_del_arquivo.Location = New System.Drawing.Point(390, 74)
        Me.button_del_arquivo.Name = "button_del_arquivo"
        Me.button_del_arquivo.Size = New System.Drawing.Size(133, 23)
        Me.button_del_arquivo.TabIndex = 6
        Me.button_del_arquivo.Text = "Desanexar arquivo"
        Me.button_del_arquivo.UseVisualStyleBackColor = True
        '
        'text_arquivo1
        '
        Me.text_arquivo1.BackColor = System.Drawing.SystemColors.Info
        Me.text_arquivo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_arquivo1.Location = New System.Drawing.Point(82, 20)
        Me.text_arquivo1.MaxLength = 500
        Me.text_arquivo1.Name = "text_arquivo1"
        Me.text_arquivo1.Size = New System.Drawing.Size(441, 21)
        Me.text_arquivo1.TabIndex = 7
        '
        'button_sel
        '
        Me.button_sel.Location = New System.Drawing.Point(529, 20)
        Me.button_sel.Name = "button_sel"
        Me.button_sel.Size = New System.Drawing.Size(75, 23)
        Me.button_sel.TabIndex = 3
        Me.button_sel.Text = "Selecionar"
        Me.button_sel.UseVisualStyleBackColor = True
        '
        'label_arquivo1
        '
        Me.label_arquivo1.AutoSize = True
        Me.label_arquivo1.BackColor = System.Drawing.Color.Transparent
        Me.label_arquivo1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_arquivo1.Location = New System.Drawing.Point(25, 22)
        Me.label_arquivo1.Name = "label_arquivo1"
        Me.label_arquivo1.Size = New System.Drawing.Size(51, 13)
        Me.label_arquivo1.TabIndex = 39
        Me.label_arquivo1.Text = "Arquivo"
        '
        'label_arquivo2
        '
        Me.label_arquivo2.AutoSize = True
        Me.label_arquivo2.BackColor = System.Drawing.Color.Transparent
        Me.label_arquivo2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_arquivo2.Location = New System.Drawing.Point(36, 111)
        Me.label_arquivo2.Name = "label_arquivo2"
        Me.label_arquivo2.Size = New System.Drawing.Size(40, 13)
        Me.label_arquivo2.TabIndex = 41
        Me.label_arquivo2.Text = "Nome"
        Me.label_arquivo2.Visible = False
        '
        'text_arquivo2
        '
        Me.text_arquivo2.BackColor = System.Drawing.SystemColors.Info
        Me.text_arquivo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_arquivo2.Location = New System.Drawing.Point(82, 108)
        Me.text_arquivo2.MaxLength = 500
        Me.text_arquivo2.Name = "text_arquivo2"
        Me.text_arquivo2.Size = New System.Drawing.Size(441, 21)
        Me.text_arquivo2.TabIndex = 42
        Me.text_arquivo2.Visible = False
        '
        'text_arquivo3
        '
        Me.text_arquivo3.BackColor = System.Drawing.SystemColors.Info
        Me.text_arquivo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_arquivo3.Location = New System.Drawing.Point(82, 47)
        Me.text_arquivo3.MaxLength = 500
        Me.text_arquivo3.Name = "text_arquivo3"
        Me.text_arquivo3.Size = New System.Drawing.Size(441, 21)
        Me.text_arquivo3.TabIndex = 8
        '
        'label_arquivo3
        '
        Me.label_arquivo3.AutoSize = True
        Me.label_arquivo3.BackColor = System.Drawing.Color.Transparent
        Me.label_arquivo3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_arquivo3.Location = New System.Drawing.Point(33, 49)
        Me.label_arquivo3.Name = "label_arquivo3"
        Me.label_arquivo3.Size = New System.Drawing.Size(36, 13)
        Me.label_arquivo3.TabIndex = 43
        Me.label_arquivo3.Text = "Rede"
        '
        'combo_nome
        '
        Me.combo_nome.BackColor = System.Drawing.Color.MistyRose
        Me.combo_nome.FormattingEnabled = True
        Me.combo_nome.Location = New System.Drawing.Point(86, 18)
        Me.combo_nome.Name = "combo_nome"
        Me.combo_nome.Size = New System.Drawing.Size(266, 21)
        Me.combo_nome.TabIndex = 0
        '
        'label_nome
        '
        Me.label_nome.AutoSize = True
        Me.label_nome.BackColor = System.Drawing.Color.Transparent
        Me.label_nome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nome.Location = New System.Drawing.Point(46, 21)
        Me.label_nome.Name = "label_nome"
        Me.label_nome.Size = New System.Drawing.Size(31, 13)
        Me.label_nome.TabIndex = 38
        Me.label_nome.Text = "Tipo"
        '
        'button_close
        '
        Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(556, 265)
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
        Me.button_confirm.Location = New System.Drawing.Point(27, 266)
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
        'form_info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(697, 321)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_info"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Informações Complementares"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents combo_nome As System.Windows.Forms.ComboBox
    Friend WithEvents label_nome As System.Windows.Forms.Label
    Friend WithEvents timer_focus As System.Windows.Forms.Timer
    Friend WithEvents label_arquivo1 As System.Windows.Forms.Label
    Friend WithEvents button_sel As System.Windows.Forms.Button
    Friend WithEvents text_arquivo3 As System.Windows.Forms.TextBox
    Friend WithEvents label_arquivo3 As System.Windows.Forms.Label
    Friend WithEvents text_arquivo2 As System.Windows.Forms.TextBox
    Friend WithEvents label_arquivo2 As System.Windows.Forms.Label
    Friend WithEvents text_arquivo1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents button_del_arquivo As System.Windows.Forms.Button
    Friend WithEvents file_sel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents combo_situacao As System.Windows.Forms.ComboBox
    Friend WithEvents label_situacao As System.Windows.Forms.Label
    Friend WithEvents label_motivo As System.Windows.Forms.Label
    Friend WithEvents text_descricao As System.Windows.Forms.TextBox
End Class
