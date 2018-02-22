<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_sd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_sd))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.date_vencto = New System.Windows.Forms.DateTimePicker
        Me.label_vencto = New System.Windows.Forms.Label
        Me.label_desc3 = New System.Windows.Forms.Label
        Me.text_int = New System.Windows.Forms.TextBox
        Me.label_desc2 = New System.Windows.Forms.Label
        Me.text_ini = New System.Windows.Forms.TextBox
        Me.label_desc1 = New System.Windows.Forms.Label
        Me.label_doc = New System.Windows.Forms.Label
        Me.text_doc = New System.Windows.Forms.TextBox
        Me.date_desde = New System.Windows.Forms.DateTimePicker
        Me.date_datasd = New System.Windows.Forms.DateTimePicker
        Me.label_desde = New System.Windows.Forms.Label
        Me.label_datasd = New System.Windows.Forms.Label
        Me.combo_situacao = New System.Windows.Forms.ComboBox
        Me.label_situacao = New System.Windows.Forms.Label
        Me.label_processo = New System.Windows.Forms.Label
        Me.text_processo = New System.Windows.Forms.TextBox
        Me.combo_obj = New System.Windows.Forms.ComboBox
        Me.label_obj = New System.Windows.Forms.Label
        Me.label_numero = New System.Windows.Forms.Label
        Me.text_numero = New System.Windows.Forms.TextBox
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
        Me.A1Panel1.Controls.Add(Me.date_vencto)
        Me.A1Panel1.Controls.Add(Me.label_vencto)
        Me.A1Panel1.Controls.Add(Me.label_desc3)
        Me.A1Panel1.Controls.Add(Me.text_int)
        Me.A1Panel1.Controls.Add(Me.label_desc2)
        Me.A1Panel1.Controls.Add(Me.text_ini)
        Me.A1Panel1.Controls.Add(Me.label_desc1)
        Me.A1Panel1.Controls.Add(Me.label_doc)
        Me.A1Panel1.Controls.Add(Me.text_doc)
        Me.A1Panel1.Controls.Add(Me.date_desde)
        Me.A1Panel1.Controls.Add(Me.date_datasd)
        Me.A1Panel1.Controls.Add(Me.label_desde)
        Me.A1Panel1.Controls.Add(Me.label_datasd)
        Me.A1Panel1.Controls.Add(Me.combo_situacao)
        Me.A1Panel1.Controls.Add(Me.label_situacao)
        Me.A1Panel1.Controls.Add(Me.label_processo)
        Me.A1Panel1.Controls.Add(Me.text_processo)
        Me.A1Panel1.Controls.Add(Me.combo_obj)
        Me.A1Panel1.Controls.Add(Me.label_obj)
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
        Me.A1Panel1.Size = New System.Drawing.Size(657, 350)
        Me.A1Panel1.TabIndex = 0
        '
        'date_vencto
        '
        Me.date_vencto.Checked = False
        Me.date_vencto.CustomFormat = ""
        Me.date_vencto.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_vencto.Location = New System.Drawing.Point(130, 213)
        Me.date_vencto.Name = "date_vencto"
        Me.date_vencto.ShowCheckBox = True
        Me.date_vencto.Size = New System.Drawing.Size(114, 21)
        Me.date_vencto.TabIndex = 60
        '
        'label_vencto
        '
        Me.label_vencto.AutoSize = True
        Me.label_vencto.BackColor = System.Drawing.Color.Transparent
        Me.label_vencto.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_vencto.Location = New System.Drawing.Point(48, 219)
        Me.label_vencto.Name = "label_vencto"
        Me.label_vencto.Size = New System.Drawing.Size(77, 13)
        Me.label_vencto.TabIndex = 61
        Me.label_vencto.Text = "Data Vencto"
        '
        'label_desc3
        '
        Me.label_desc3.AutoSize = True
        Me.label_desc3.BackColor = System.Drawing.Color.Transparent
        Me.label_desc3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc3.Location = New System.Drawing.Point(563, 260)
        Me.label_desc3.Name = "label_desc3"
        Me.label_desc3.Size = New System.Drawing.Size(40, 13)
        Me.label_desc3.TabIndex = 59
        Me.label_desc3.Text = "dia(s)"
        '
        'text_int
        '
        Me.text_int.BackColor = System.Drawing.SystemColors.Info
        Me.text_int.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_int.Location = New System.Drawing.Point(496, 256)
        Me.text_int.MaxLength = 500
        Me.text_int.Name = "text_int"
        Me.text_int.Size = New System.Drawing.Size(61, 21)
        Me.text_int.TabIndex = 58
        Me.text_int.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_desc2
        '
        Me.label_desc2.AutoSize = True
        Me.label_desc2.BackColor = System.Drawing.Color.Transparent
        Me.label_desc2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc2.Location = New System.Drawing.Point(246, 260)
        Me.label_desc2.Name = "label_desc2"
        Me.label_desc2.Size = New System.Drawing.Size(244, 13)
        Me.label_desc2.TabIndex = 57
        Me.label_desc2.Text = "dia(s) para vencer e depois disso, a cada"
        '
        'text_ini
        '
        Me.text_ini.BackColor = System.Drawing.SystemColors.Info
        Me.text_ini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_ini.Location = New System.Drawing.Point(179, 256)
        Me.text_ini.MaxLength = 500
        Me.text_ini.Name = "text_ini"
        Me.text_ini.Size = New System.Drawing.Size(61, 21)
        Me.text_ini.TabIndex = 56
        Me.text_ini.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_desc1
        '
        Me.label_desc1.AutoSize = True
        Me.label_desc1.BackColor = System.Drawing.Color.Transparent
        Me.label_desc1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc1.Location = New System.Drawing.Point(18, 260)
        Me.label_desc1.Name = "label_desc1"
        Me.label_desc1.Size = New System.Drawing.Size(165, 13)
        Me.label_desc1.TabIndex = 55
        Me.label_desc1.Text = "Enviar Alerta quando faltar "
        '
        'label_doc
        '
        Me.label_doc.AutoSize = True
        Me.label_doc.BackColor = System.Drawing.Color.Transparent
        Me.label_doc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_doc.Location = New System.Drawing.Point(55, 99)
        Me.label_doc.Name = "label_doc"
        Me.label_doc.Size = New System.Drawing.Size(63, 13)
        Me.label_doc.TabIndex = 51
        Me.label_doc.Text = "Num.Doc."
        '
        'text_doc
        '
        Me.text_doc.BackColor = System.Drawing.SystemColors.Info
        Me.text_doc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_doc.Location = New System.Drawing.Point(130, 97)
        Me.text_doc.MaxLength = 30
        Me.text_doc.Name = "text_doc"
        Me.text_doc.Size = New System.Drawing.Size(360, 21)
        Me.text_doc.TabIndex = 50
        '
        'date_desde
        '
        Me.date_desde.Checked = False
        Me.date_desde.CustomFormat = ""
        Me.date_desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_desde.Location = New System.Drawing.Point(130, 186)
        Me.date_desde.Name = "date_desde"
        Me.date_desde.ShowCheckBox = True
        Me.date_desde.Size = New System.Drawing.Size(114, 21)
        Me.date_desde.TabIndex = 6
        '
        'date_datasd
        '
        Me.date_datasd.Checked = False
        Me.date_datasd.CustomFormat = ""
        Me.date_datasd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_datasd.Location = New System.Drawing.Point(130, 43)
        Me.date_datasd.Name = "date_datasd"
        Me.date_datasd.ShowCheckBox = True
        Me.date_datasd.Size = New System.Drawing.Size(114, 21)
        Me.date_datasd.TabIndex = 5
        '
        'label_desde
        '
        Me.label_desde.AutoSize = True
        Me.label_desde.BackColor = System.Drawing.Color.Transparent
        Me.label_desde.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desde.Location = New System.Drawing.Point(81, 192)
        Me.label_desde.Name = "label_desde"
        Me.label_desde.Size = New System.Drawing.Size(43, 13)
        Me.label_desde.TabIndex = 44
        Me.label_desde.Text = "Desde"
        '
        'label_datasd
        '
        Me.label_datasd.AutoSize = True
        Me.label_datasd.BackColor = System.Drawing.Color.Transparent
        Me.label_datasd.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_datasd.Location = New System.Drawing.Point(69, 49)
        Me.label_datasd.Name = "label_datasd"
        Me.label_datasd.Size = New System.Drawing.Size(55, 13)
        Me.label_datasd.TabIndex = 43
        Me.label_datasd.Text = "Data SD"
        '
        'combo_situacao
        '
        Me.combo_situacao.BackColor = System.Drawing.SystemColors.Info
        Me.combo_situacao.FormattingEnabled = True
        Me.combo_situacao.Location = New System.Drawing.Point(130, 154)
        Me.combo_situacao.Name = "combo_situacao"
        Me.combo_situacao.Size = New System.Drawing.Size(360, 21)
        Me.combo_situacao.TabIndex = 4
        '
        'label_situacao
        '
        Me.label_situacao.AutoSize = True
        Me.label_situacao.BackColor = System.Drawing.Color.Transparent
        Me.label_situacao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_situacao.Location = New System.Drawing.Point(69, 157)
        Me.label_situacao.Name = "label_situacao"
        Me.label_situacao.Size = New System.Drawing.Size(56, 13)
        Me.label_situacao.TabIndex = 42
        Me.label_situacao.Text = "Situação"
        '
        'label_processo
        '
        Me.label_processo.AutoSize = True
        Me.label_processo.BackColor = System.Drawing.Color.Transparent
        Me.label_processo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_processo.Location = New System.Drawing.Point(36, 72)
        Me.label_processo.Name = "label_processo"
        Me.label_processo.Size = New System.Drawing.Size(88, 13)
        Me.label_processo.TabIndex = 40
        Me.label_processo.Text = "Num.Processo"
        '
        'text_processo
        '
        Me.text_processo.BackColor = System.Drawing.SystemColors.Info
        Me.text_processo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_processo.Location = New System.Drawing.Point(130, 70)
        Me.text_processo.MaxLength = 30
        Me.text_processo.Name = "text_processo"
        Me.text_processo.Size = New System.Drawing.Size(360, 21)
        Me.text_processo.TabIndex = 2
        '
        'combo_obj
        '
        Me.combo_obj.BackColor = System.Drawing.SystemColors.Info
        Me.combo_obj.FormattingEnabled = True
        Me.combo_obj.Location = New System.Drawing.Point(130, 127)
        Me.combo_obj.Name = "combo_obj"
        Me.combo_obj.Size = New System.Drawing.Size(360, 21)
        Me.combo_obj.TabIndex = 3
        '
        'label_obj
        '
        Me.label_obj.BackColor = System.Drawing.Color.Transparent
        Me.label_obj.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_obj.Location = New System.Drawing.Point(55, 124)
        Me.label_obj.Name = "label_obj"
        Me.label_obj.Size = New System.Drawing.Size(69, 27)
        Me.label_obj.TabIndex = 38
        Me.label_obj.Text = "Objeto da Solicitação"
        '
        'label_numero
        '
        Me.label_numero.AutoSize = True
        Me.label_numero.BackColor = System.Drawing.Color.Transparent
        Me.label_numero.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_numero.Location = New System.Drawing.Point(51, 19)
        Me.label_numero.Name = "label_numero"
        Me.label_numero.Size = New System.Drawing.Size(73, 13)
        Me.label_numero.TabIndex = 36
        Me.label_numero.Text = "Número SD"
        '
        'text_numero
        '
        Me.text_numero.BackColor = System.Drawing.Color.MistyRose
        Me.text_numero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_numero.Location = New System.Drawing.Point(130, 17)
        Me.text_numero.MaxLength = 50
        Me.text_numero.Name = "text_numero"
        Me.text_numero.Size = New System.Drawing.Size(136, 21)
        Me.text_numero.TabIndex = 1
        '
        'button_close
        '
        Me.button_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(515, 304)
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
        Me.button_confirm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.button_confirm.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm.ImageIndex = 1
        Me.button_confirm.ImageList = Me.ImageList1
        Me.button_confirm.Location = New System.Drawing.Point(46, 305)
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
        'form_sd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(665, 356)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_sd"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de SDs"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents combo_obj As System.Windows.Forms.ComboBox
    Friend WithEvents label_obj As System.Windows.Forms.Label
    Friend WithEvents label_numero As System.Windows.Forms.Label
    Friend WithEvents text_numero As System.Windows.Forms.TextBox
    Friend WithEvents timer_focus As System.Windows.Forms.Timer
    Friend WithEvents label_processo As System.Windows.Forms.Label
    Friend WithEvents text_processo As System.Windows.Forms.TextBox
    Friend WithEvents date_desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_datasd As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_desde As System.Windows.Forms.Label
    Friend WithEvents label_datasd As System.Windows.Forms.Label
    Friend WithEvents combo_situacao As System.Windows.Forms.ComboBox
    Friend WithEvents label_situacao As System.Windows.Forms.Label
    Friend WithEvents file_sel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents label_doc As System.Windows.Forms.Label
    Friend WithEvents text_doc As System.Windows.Forms.TextBox
    Friend WithEvents date_vencto As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_vencto As System.Windows.Forms.Label
    Friend WithEvents label_desc3 As System.Windows.Forms.Label
    Friend WithEvents text_int As System.Windows.Forms.TextBox
    Friend WithEvents label_desc2 As System.Windows.Forms.Label
    Friend WithEvents text_ini As System.Windows.Forms.TextBox
    Friend WithEvents label_desc1 As System.Windows.Forms.Label
End Class
