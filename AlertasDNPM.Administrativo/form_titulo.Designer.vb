<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_titulo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_titulo))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.group_documento = New System.Windows.Forms.GroupBox
        Me.button_del_arquivo = New System.Windows.Forms.Button
        Me.text_arquivo1 = New System.Windows.Forms.TextBox
        Me.button_sel = New System.Windows.Forms.Button
        Me.label_arquivo1 = New System.Windows.Forms.Label
        Me.label_arquivo2 = New System.Windows.Forms.Label
        Me.text_arquivo2 = New System.Windows.Forms.TextBox
        Me.text_arquivo3 = New System.Windows.Forms.TextBox
        Me.label_arquivo3 = New System.Windows.Forms.Label
        Me.date_vencimento = New System.Windows.Forms.DateTimePicker
        Me.date_publicacao = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.label_publicacao = New System.Windows.Forms.Label
        Me.combo_situacao = New System.Windows.Forms.ComboBox
        Me.label_situacao = New System.Windows.Forms.Label
        Me.label_descricao = New System.Windows.Forms.Label
        Me.text_descricao = New System.Windows.Forms.TextBox
        Me.combo_tipo = New System.Windows.Forms.ComboBox
        Me.label_tipo = New System.Windows.Forms.Label
        Me.label_numero = New System.Windows.Forms.Label
        Me.text_numero = New System.Windows.Forms.TextBox
        Me.button_close = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button_confirm = New System.Windows.Forms.Button
        Me.timer_focus = New System.Windows.Forms.Timer(Me.components)
        Me.file_sel = New System.Windows.Forms.OpenFileDialog
        Me.label_desc1 = New System.Windows.Forms.Label
        Me.text_ini = New System.Windows.Forms.TextBox
        Me.label_desc2 = New System.Windows.Forms.Label
        Me.text_int = New System.Windows.Forms.TextBox
        Me.label_desc3 = New System.Windows.Forms.Label
        Me.A1Panel1.SuspendLayout()
        Me.group_documento.SuspendLayout()
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
        Me.A1Panel1.Controls.Add(Me.group_documento)
        Me.A1Panel1.Controls.Add(Me.date_vencimento)
        Me.A1Panel1.Controls.Add(Me.date_publicacao)
        Me.A1Panel1.Controls.Add(Me.Label1)
        Me.A1Panel1.Controls.Add(Me.label_publicacao)
        Me.A1Panel1.Controls.Add(Me.combo_situacao)
        Me.A1Panel1.Controls.Add(Me.label_situacao)
        Me.A1Panel1.Controls.Add(Me.label_descricao)
        Me.A1Panel1.Controls.Add(Me.text_descricao)
        Me.A1Panel1.Controls.Add(Me.combo_tipo)
        Me.A1Panel1.Controls.Add(Me.label_tipo)
        Me.A1Panel1.Controls.Add(Me.label_numero)
        Me.A1Panel1.Controls.Add(Me.text_numero)
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.Controls.Add(Me.button_confirm)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(3, 6)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.RoundCornerRadius = 20
        Me.A1Panel1.Size = New System.Drawing.Size(657, 474)
        Me.A1Panel1.TabIndex = 0
        '
        'group_documento
        '
        Me.group_documento.BackColor = System.Drawing.Color.Transparent
        Me.group_documento.Controls.Add(Me.button_del_arquivo)
        Me.group_documento.Controls.Add(Me.text_arquivo1)
        Me.group_documento.Controls.Add(Me.button_sel)
        Me.group_documento.Controls.Add(Me.label_arquivo1)
        Me.group_documento.Controls.Add(Me.label_arquivo2)
        Me.group_documento.Controls.Add(Me.text_arquivo2)
        Me.group_documento.Controls.Add(Me.text_arquivo3)
        Me.group_documento.Controls.Add(Me.label_arquivo3)
        Me.group_documento.Location = New System.Drawing.Point(12, 280)
        Me.group_documento.Name = "group_documento"
        Me.group_documento.Size = New System.Drawing.Size(630, 138)
        Me.group_documento.TabIndex = 49
        Me.group_documento.TabStop = False
        Me.group_documento.Text = "Anexar Documento Principal"
        '
        'button_del_arquivo
        '
        Me.button_del_arquivo.Location = New System.Drawing.Point(397, 101)
        Me.button_del_arquivo.Name = "button_del_arquivo"
        Me.button_del_arquivo.Size = New System.Drawing.Size(133, 23)
        Me.button_del_arquivo.TabIndex = 48
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
        Me.text_arquivo1.TabIndex = 40
        '
        'button_sel
        '
        Me.button_sel.Location = New System.Drawing.Point(536, 17)
        Me.button_sel.Name = "button_sel"
        Me.button_sel.Size = New System.Drawing.Size(75, 23)
        Me.button_sel.TabIndex = 47
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
        Me.text_arquivo2.TabIndex = 42
        '
        'text_arquivo3
        '
        Me.text_arquivo3.BackColor = System.Drawing.SystemColors.Info
        Me.text_arquivo3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_arquivo3.Location = New System.Drawing.Point(89, 73)
        Me.text_arquivo3.MaxLength = 500
        Me.text_arquivo3.Name = "text_arquivo3"
        Me.text_arquivo3.Size = New System.Drawing.Size(441, 21)
        Me.text_arquivo3.TabIndex = 44
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
        'date_vencimento
        '
        Me.date_vencimento.Checked = False
        Me.date_vencimento.CustomFormat = ""
        Me.date_vencimento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_vencimento.Location = New System.Drawing.Point(123, 186)
        Me.date_vencimento.Name = "date_vencimento"
        Me.date_vencimento.ShowCheckBox = True
        Me.date_vencimento.Size = New System.Drawing.Size(114, 21)
        Me.date_vencimento.TabIndex = 6
        '
        'date_publicacao
        '
        Me.date_publicacao.Checked = False
        Me.date_publicacao.CustomFormat = ""
        Me.date_publicacao.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_publicacao.Location = New System.Drawing.Point(123, 154)
        Me.date_publicacao.Name = "date_publicacao"
        Me.date_publicacao.ShowCheckBox = True
        Me.date_publicacao.Size = New System.Drawing.Size(114, 21)
        Me.date_publicacao.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 194)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Data Vencimento"
        '
        'label_publicacao
        '
        Me.label_publicacao.AutoSize = True
        Me.label_publicacao.BackColor = System.Drawing.Color.Transparent
        Me.label_publicacao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_publicacao.Location = New System.Drawing.Point(9, 160)
        Me.label_publicacao.Name = "label_publicacao"
        Me.label_publicacao.Size = New System.Drawing.Size(98, 13)
        Me.label_publicacao.TabIndex = 43
        Me.label_publicacao.Text = "Data Publicação"
        '
        'combo_situacao
        '
        Me.combo_situacao.BackColor = System.Drawing.SystemColors.Info
        Me.combo_situacao.FormattingEnabled = True
        Me.combo_situacao.Location = New System.Drawing.Point(123, 125)
        Me.combo_situacao.Name = "combo_situacao"
        Me.combo_situacao.Size = New System.Drawing.Size(360, 21)
        Me.combo_situacao.TabIndex = 4
        '
        'label_situacao
        '
        Me.label_situacao.AutoSize = True
        Me.label_situacao.BackColor = System.Drawing.Color.Transparent
        Me.label_situacao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_situacao.Location = New System.Drawing.Point(51, 128)
        Me.label_situacao.Name = "label_situacao"
        Me.label_situacao.Size = New System.Drawing.Size(56, 13)
        Me.label_situacao.TabIndex = 42
        Me.label_situacao.Text = "Situação"
        '
        'label_descricao
        '
        Me.label_descricao.AutoSize = True
        Me.label_descricao.BackColor = System.Drawing.Color.Transparent
        Me.label_descricao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_descricao.Location = New System.Drawing.Point(43, 46)
        Me.label_descricao.Name = "label_descricao"
        Me.label_descricao.Size = New System.Drawing.Size(63, 13)
        Me.label_descricao.TabIndex = 40
        Me.label_descricao.Text = "Descrição"
        '
        'text_descricao
        '
        Me.text_descricao.BackColor = System.Drawing.Color.MistyRose
        Me.text_descricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_descricao.Location = New System.Drawing.Point(123, 44)
        Me.text_descricao.MaxLength = 300
        Me.text_descricao.Multiline = True
        Me.text_descricao.Name = "text_descricao"
        Me.text_descricao.Size = New System.Drawing.Size(360, 46)
        Me.text_descricao.TabIndex = 2
        '
        'combo_tipo
        '
        Me.combo_tipo.BackColor = System.Drawing.Color.MistyRose
        Me.combo_tipo.FormattingEnabled = True
        Me.combo_tipo.Location = New System.Drawing.Point(123, 97)
        Me.combo_tipo.Name = "combo_tipo"
        Me.combo_tipo.Size = New System.Drawing.Size(360, 21)
        Me.combo_tipo.TabIndex = 3
        '
        'label_tipo
        '
        Me.label_tipo.AutoSize = True
        Me.label_tipo.BackColor = System.Drawing.Color.Transparent
        Me.label_tipo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tipo.Location = New System.Drawing.Point(22, 100)
        Me.label_tipo.Name = "label_tipo"
        Me.label_tipo.Size = New System.Drawing.Size(84, 13)
        Me.label_tipo.TabIndex = 38
        Me.label_tipo.Text = "Tipo de Título"
        '
        'label_numero
        '
        Me.label_numero.AutoSize = True
        Me.label_numero.BackColor = System.Drawing.Color.Transparent
        Me.label_numero.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_numero.Location = New System.Drawing.Point(51, 19)
        Me.label_numero.Name = "label_numero"
        Me.label_numero.Size = New System.Drawing.Size(52, 13)
        Me.label_numero.TabIndex = 36
        Me.label_numero.Text = "Número"
        '
        'text_numero
        '
        Me.text_numero.BackColor = System.Drawing.Color.MistyRose
        Me.text_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_numero.Location = New System.Drawing.Point(123, 17)
        Me.text_numero.MaxLength = 50
        Me.text_numero.Name = "text_numero"
        Me.text_numero.Size = New System.Drawing.Size(136, 21)
        Me.text_numero.TabIndex = 1
        '
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(515, 434)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(101, 28)
        Me.button_close.TabIndex = 8
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
        Me.button_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm.ImageIndex = 1
        Me.button_confirm.ImageList = Me.ImageList1
        Me.button_confirm.Location = New System.Drawing.Point(46, 435)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(111, 27)
        Me.button_confirm.TabIndex = 7
        Me.button_confirm.Text = "Confirmar"
        Me.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm.UseVisualStyleBackColor = True
        '
        'timer_focus
        '
        Me.timer_focus.Enabled = True
        '
        'label_desc1
        '
        Me.label_desc1.AutoSize = True
        Me.label_desc1.BackColor = System.Drawing.Color.Transparent
        Me.label_desc1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc1.Location = New System.Drawing.Point(15, 229)
        Me.label_desc1.Name = "label_desc1"
        Me.label_desc1.Size = New System.Drawing.Size(165, 13)
        Me.label_desc1.TabIndex = 50
        Me.label_desc1.Text = "Enviar Alerta quando faltar "
        '
        'text_ini
        '
        Me.text_ini.BackColor = System.Drawing.SystemColors.Info
        Me.text_ini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_ini.Location = New System.Drawing.Point(176, 225)
        Me.text_ini.MaxLength = 500
        Me.text_ini.Name = "text_ini"
        Me.text_ini.Size = New System.Drawing.Size(61, 21)
        Me.text_ini.TabIndex = 51
        Me.text_ini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_desc2
        '
        Me.label_desc2.AutoSize = True
        Me.label_desc2.BackColor = System.Drawing.Color.Transparent
        Me.label_desc2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc2.Location = New System.Drawing.Point(243, 229)
        Me.label_desc2.Name = "label_desc2"
        Me.label_desc2.Size = New System.Drawing.Size(244, 13)
        Me.label_desc2.TabIndex = 52
        Me.label_desc2.Text = "dia(s) para vencer e depois disso, a cada"
        '
        'text_int
        '
        Me.text_int.BackColor = System.Drawing.SystemColors.Info
        Me.text_int.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_int.Location = New System.Drawing.Point(493, 225)
        Me.text_int.MaxLength = 500
        Me.text_int.Name = "text_int"
        Me.text_int.Size = New System.Drawing.Size(61, 21)
        Me.text_int.TabIndex = 53
        Me.text_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_desc3
        '
        Me.label_desc3.AutoSize = True
        Me.label_desc3.BackColor = System.Drawing.Color.Transparent
        Me.label_desc3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc3.Location = New System.Drawing.Point(560, 229)
        Me.label_desc3.Name = "label_desc3"
        Me.label_desc3.Size = New System.Drawing.Size(40, 13)
        Me.label_desc3.TabIndex = 54
        Me.label_desc3.Text = "dia(s)"
        '
        'form_titulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(665, 480)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_titulo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Títulos - {0}"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        Me.group_documento.ResumeLayout(False)
        Me.group_documento.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents combo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents label_tipo As System.Windows.Forms.Label
    Friend WithEvents label_numero As System.Windows.Forms.Label
    Friend WithEvents text_numero As System.Windows.Forms.TextBox
    Friend WithEvents timer_focus As System.Windows.Forms.Timer
    Friend WithEvents label_descricao As System.Windows.Forms.Label
    Friend WithEvents text_descricao As System.Windows.Forms.TextBox
    Friend WithEvents date_vencimento As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_publicacao As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents label_publicacao As System.Windows.Forms.Label
    Friend WithEvents combo_situacao As System.Windows.Forms.ComboBox
    Friend WithEvents label_situacao As System.Windows.Forms.Label
    Friend WithEvents group_documento As System.Windows.Forms.GroupBox
    Friend WithEvents button_del_arquivo As System.Windows.Forms.Button
    Friend WithEvents text_arquivo1 As System.Windows.Forms.TextBox
    Friend WithEvents button_sel As System.Windows.Forms.Button
    Friend WithEvents label_arquivo1 As System.Windows.Forms.Label
    Friend WithEvents label_arquivo2 As System.Windows.Forms.Label
    Friend WithEvents text_arquivo2 As System.Windows.Forms.TextBox
    Friend WithEvents text_arquivo3 As System.Windows.Forms.TextBox
    Friend WithEvents label_arquivo3 As System.Windows.Forms.Label
    Friend WithEvents file_sel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents label_desc3 As System.Windows.Forms.Label
    Friend WithEvents text_int As System.Windows.Forms.TextBox
    Friend WithEvents label_desc2 As System.Windows.Forms.Label
    Friend WithEvents text_ini As System.Windows.Forms.TextBox
    Friend WithEvents label_desc1 As System.Windows.Forms.Label
End Class
