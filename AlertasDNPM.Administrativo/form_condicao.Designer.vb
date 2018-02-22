<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_condicao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_condicao))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.label_desc3 = New System.Windows.Forms.Label
        Me.text_int = New System.Windows.Forms.TextBox
        Me.label_desc2 = New System.Windows.Forms.Label
        Me.text_ini = New System.Windows.Forms.TextBox
        Me.label_desc1 = New System.Windows.Forms.Label
        Me.date_final = New System.Windows.Forms.DateTimePicker
        Me.date_inicial = New System.Windows.Forms.DateTimePicker
        Me.label_final = New System.Windows.Forms.Label
        Me.label_inicial = New System.Windows.Forms.Label
        Me.label_descricao = New System.Windows.Forms.Label
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
        Me.A1Panel1.Controls.Add(Me.label_desc3)
        Me.A1Panel1.Controls.Add(Me.text_int)
        Me.A1Panel1.Controls.Add(Me.label_desc2)
        Me.A1Panel1.Controls.Add(Me.text_ini)
        Me.A1Panel1.Controls.Add(Me.label_desc1)
        Me.A1Panel1.Controls.Add(Me.date_final)
        Me.A1Panel1.Controls.Add(Me.date_inicial)
        Me.A1Panel1.Controls.Add(Me.label_final)
        Me.A1Panel1.Controls.Add(Me.label_inicial)
        Me.A1Panel1.Controls.Add(Me.label_descricao)
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
        Me.A1Panel1.Size = New System.Drawing.Size(688, 460)
        Me.A1Panel1.TabIndex = 0
        '
        'label_desc3
        '
        Me.label_desc3.AutoSize = True
        Me.label_desc3.BackColor = System.Drawing.Color.Transparent
        Me.label_desc3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc3.Location = New System.Drawing.Point(579, 209)
        Me.label_desc3.Name = "label_desc3"
        Me.label_desc3.Size = New System.Drawing.Size(40, 13)
        Me.label_desc3.TabIndex = 65
        Me.label_desc3.Text = "dia(s)"
        '
        'text_int
        '
        Me.text_int.BackColor = System.Drawing.SystemColors.Info
        Me.text_int.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_int.Location = New System.Drawing.Point(512, 205)
        Me.text_int.MaxLength = 500
        Me.text_int.Name = "text_int"
        Me.text_int.Size = New System.Drawing.Size(61, 21)
        Me.text_int.TabIndex = 64
        Me.text_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_desc2
        '
        Me.label_desc2.AutoSize = True
        Me.label_desc2.BackColor = System.Drawing.Color.Transparent
        Me.label_desc2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc2.Location = New System.Drawing.Point(262, 209)
        Me.label_desc2.Name = "label_desc2"
        Me.label_desc2.Size = New System.Drawing.Size(244, 13)
        Me.label_desc2.TabIndex = 63
        Me.label_desc2.Text = "dia(s) para vencer e depois disso, a cada"
        '
        'text_ini
        '
        Me.text_ini.BackColor = System.Drawing.SystemColors.Info
        Me.text_ini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_ini.Location = New System.Drawing.Point(195, 205)
        Me.text_ini.MaxLength = 500
        Me.text_ini.Name = "text_ini"
        Me.text_ini.Size = New System.Drawing.Size(61, 21)
        Me.text_ini.TabIndex = 62
        Me.text_ini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_desc1
        '
        Me.label_desc1.AutoSize = True
        Me.label_desc1.BackColor = System.Drawing.Color.Transparent
        Me.label_desc1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc1.Location = New System.Drawing.Point(34, 209)
        Me.label_desc1.Name = "label_desc1"
        Me.label_desc1.Size = New System.Drawing.Size(165, 13)
        Me.label_desc1.TabIndex = 61
        Me.label_desc1.Text = "Enviar Alerta quando faltar "
        '
        'date_final
        '
        Me.date_final.Checked = False
        Me.date_final.CustomFormat = ""
        Me.date_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_final.Location = New System.Drawing.Point(98, 163)
        Me.date_final.Name = "date_final"
        Me.date_final.ShowCheckBox = True
        Me.date_final.Size = New System.Drawing.Size(114, 21)
        Me.date_final.TabIndex = 4
        '
        'date_inicial
        '
        Me.date_inicial.Checked = False
        Me.date_inicial.CustomFormat = ""
        Me.date_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_inicial.Location = New System.Drawing.Point(98, 129)
        Me.date_inicial.Name = "date_inicial"
        Me.date_inicial.ShowCheckBox = True
        Me.date_inicial.Size = New System.Drawing.Size(114, 21)
        Me.date_inicial.TabIndex = 3
        '
        'label_final
        '
        Me.label_final.AutoSize = True
        Me.label_final.BackColor = System.Drawing.Color.Transparent
        Me.label_final.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_final.Location = New System.Drawing.Point(11, 169)
        Me.label_final.Name = "label_final"
        Me.label_final.Size = New System.Drawing.Size(77, 13)
        Me.label_final.TabIndex = 60
        Me.label_final.Text = "Data Vencto"
        '
        'label_inicial
        '
        Me.label_inicial.AutoSize = True
        Me.label_inicial.BackColor = System.Drawing.Color.Transparent
        Me.label_inicial.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_inicial.Location = New System.Drawing.Point(11, 135)
        Me.label_inicial.Name = "label_inicial"
        Me.label_inicial.Size = New System.Drawing.Size(72, 13)
        Me.label_inicial.TabIndex = 59
        Me.label_inicial.Text = "Data Inicial"
        '
        'label_descricao
        '
        Me.label_descricao.AutoSize = True
        Me.label_descricao.BackColor = System.Drawing.Color.Transparent
        Me.label_descricao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_descricao.Location = New System.Drawing.Point(17, 61)
        Me.label_descricao.Name = "label_descricao"
        Me.label_descricao.Size = New System.Drawing.Size(63, 13)
        Me.label_descricao.TabIndex = 56
        Me.label_descricao.Text = "Descrição"
        '
        'text_descricao
        '
        Me.text_descricao.BackColor = System.Drawing.SystemColors.Info
        Me.text_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_descricao.Location = New System.Drawing.Point(98, 59)
        Me.text_descricao.MaxLength = 500
        Me.text_descricao.Name = "text_descricao"
        Me.text_descricao.Size = New System.Drawing.Size(559, 21)
        Me.text_descricao.TabIndex = 1
        '
        'combo_situacao
        '
        Me.combo_situacao.BackColor = System.Drawing.SystemColors.Info
        Me.combo_situacao.FormattingEnabled = True
        Me.combo_situacao.Location = New System.Drawing.Point(98, 94)
        Me.combo_situacao.Name = "combo_situacao"
        Me.combo_situacao.Size = New System.Drawing.Size(266, 21)
        Me.combo_situacao.TabIndex = 2
        '
        'label_situacao
        '
        Me.label_situacao.AutoSize = True
        Me.label_situacao.BackColor = System.Drawing.Color.Transparent
        Me.label_situacao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_situacao.Location = New System.Drawing.Point(24, 97)
        Me.label_situacao.Name = "label_situacao"
        Me.label_situacao.Size = New System.Drawing.Size(56, 13)
        Me.label_situacao.TabIndex = 55
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
        Me.GroupBox1.Location = New System.Drawing.Point(37, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(630, 138)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Anexar Arquivo"
        '
        'button_del_arquivo
        '
        Me.button_del_arquivo.Location = New System.Drawing.Point(397, 101)
        Me.button_del_arquivo.Name = "button_del_arquivo"
        Me.button_del_arquivo.Size = New System.Drawing.Size(133, 23)
        Me.button_del_arquivo.TabIndex = 11
        Me.button_del_arquivo.Text = "Desanexar arquivo"
        Me.button_del_arquivo.UseVisualStyleBackColor = True
        '
        'text_arquivo1
        '
        Me.text_arquivo1.BackColor = System.Drawing.SystemColors.Info
        Me.text_arquivo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_arquivo1.Location = New System.Drawing.Point(89, 46)
        Me.text_arquivo1.MaxLength = 500
        Me.text_arquivo1.Name = "text_arquivo1"
        Me.text_arquivo1.Size = New System.Drawing.Size(441, 21)
        Me.text_arquivo1.TabIndex = 9
        '
        'button_sel
        '
        Me.button_sel.Location = New System.Drawing.Point(536, 17)
        Me.button_sel.Name = "button_sel"
        Me.button_sel.Size = New System.Drawing.Size(75, 23)
        Me.button_sel.TabIndex = 5
        Me.button_sel.Text = "Selecionar"
        Me.button_sel.UseVisualStyleBackColor = True
        '
        'label_arquivo1
        '
        Me.label_arquivo1.AutoSize = True
        Me.label_arquivo1.BackColor = System.Drawing.Color.Transparent
        Me.label_arquivo1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_arquivo1.Location = New System.Drawing.Point(32, 48)
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
        Me.label_arquivo2.Location = New System.Drawing.Point(43, 22)
        Me.label_arquivo2.Name = "label_arquivo2"
        Me.label_arquivo2.Size = New System.Drawing.Size(40, 13)
        Me.label_arquivo2.TabIndex = 41
        Me.label_arquivo2.Text = "Nome"
        '
        'text_arquivo2
        '
        Me.text_arquivo2.BackColor = System.Drawing.SystemColors.Info
        Me.text_arquivo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_arquivo2.Location = New System.Drawing.Point(89, 19)
        Me.text_arquivo2.MaxLength = 500
        Me.text_arquivo2.Name = "text_arquivo2"
        Me.text_arquivo2.Size = New System.Drawing.Size(441, 21)
        Me.text_arquivo2.TabIndex = 8
        '
        'text_arquivo3
        '
        Me.text_arquivo3.BackColor = System.Drawing.SystemColors.Info
        Me.text_arquivo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_arquivo3.Location = New System.Drawing.Point(89, 73)
        Me.text_arquivo3.MaxLength = 500
        Me.text_arquivo3.Name = "text_arquivo3"
        Me.text_arquivo3.Size = New System.Drawing.Size(441, 21)
        Me.text_arquivo3.TabIndex = 10
        '
        'label_arquivo3
        '
        Me.label_arquivo3.AutoSize = True
        Me.label_arquivo3.BackColor = System.Drawing.Color.Transparent
        Me.label_arquivo3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_arquivo3.Location = New System.Drawing.Point(40, 75)
        Me.label_arquivo3.Name = "label_arquivo3"
        Me.label_arquivo3.Size = New System.Drawing.Size(36, 13)
        Me.label_arquivo3.TabIndex = 43
        Me.label_arquivo3.Text = "Rede"
        '
        'combo_nome
        '
        Me.combo_nome.BackColor = System.Drawing.Color.MistyRose
        Me.combo_nome.FormattingEnabled = True
        Me.combo_nome.Location = New System.Drawing.Point(98, 21)
        Me.combo_nome.Name = "combo_nome"
        Me.combo_nome.Size = New System.Drawing.Size(266, 21)
        Me.combo_nome.TabIndex = 0
        '
        'label_nome
        '
        Me.label_nome.AutoSize = True
        Me.label_nome.BackColor = System.Drawing.Color.Transparent
        Me.label_nome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nome.Location = New System.Drawing.Point(44, 21)
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
        Me.button_close.Location = New System.Drawing.Point(556, 413)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(101, 28)
        Me.button_close.TabIndex = 7
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
        Me.button_confirm.Location = New System.Drawing.Point(28, 413)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(111, 27)
        Me.button_confirm.TabIndex = 6
        Me.button_confirm.Text = "Confirmar"
        Me.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm.UseVisualStyleBackColor = True
        '
        'timer_focus
        '
        Me.timer_focus.Enabled = True
        '
        'form_condicao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(697, 463)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_condicao"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Condições de propriedade do solo"
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
    Friend WithEvents label_descricao As System.Windows.Forms.Label
    Friend WithEvents text_descricao As System.Windows.Forms.TextBox
    Friend WithEvents combo_situacao As System.Windows.Forms.ComboBox
    Friend WithEvents label_situacao As System.Windows.Forms.Label
    Friend WithEvents date_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_final As System.Windows.Forms.Label
    Friend WithEvents label_inicial As System.Windows.Forms.Label
    Friend WithEvents label_desc3 As System.Windows.Forms.Label
    Friend WithEvents text_int As System.Windows.Forms.TextBox
    Friend WithEvents label_desc2 As System.Windows.Forms.Label
    Friend WithEvents text_ini As System.Windows.Forms.TextBox
    Friend WithEvents label_desc1 As System.Windows.Forms.Label
End Class
