<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_substancia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_substancia))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.combo_tuso = New System.Windows.Forms.ComboBox
        Me.label_situacao = New System.Windows.Forms.Label
        Me.combo_substancia = New System.Windows.Forms.ComboBox
        Me.label_tipo = New System.Windows.Forms.Label
        Me.button_close = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button_confirm = New System.Windows.Forms.Button
        Me.timer_focus = New System.Windows.Forms.Timer(Me.components)
        Me.date_final = New System.Windows.Forms.DateTimePicker
        Me.date_inicial = New System.Windows.Forms.DateTimePicker
        Me.label_final = New System.Windows.Forms.Label
        Me.label_inicial = New System.Windows.Forms.Label
        Me.label_motivo = New System.Windows.Forms.Label
        Me.text_motivo = New System.Windows.Forms.TextBox
        Me.A1Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Gray
        Me.A1Panel1.Controls.Add(Me.label_motivo)
        Me.A1Panel1.Controls.Add(Me.text_motivo)
        Me.A1Panel1.Controls.Add(Me.date_final)
        Me.A1Panel1.Controls.Add(Me.date_inicial)
        Me.A1Panel1.Controls.Add(Me.label_final)
        Me.A1Panel1.Controls.Add(Me.label_inicial)
        Me.A1Panel1.Controls.Add(Me.combo_tuso)
        Me.A1Panel1.Controls.Add(Me.label_situacao)
        Me.A1Panel1.Controls.Add(Me.combo_substancia)
        Me.A1Panel1.Controls.Add(Me.label_tipo)
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.Controls.Add(Me.button_confirm)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(3, 6)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.RoundCornerRadius = 20
        Me.A1Panel1.Size = New System.Drawing.Size(508, 243)
        Me.A1Panel1.TabIndex = 0
        '
        'combo_tuso
        '
        Me.combo_tuso.BackColor = System.Drawing.Color.MistyRose
        Me.combo_tuso.FormattingEnabled = True
        Me.combo_tuso.Location = New System.Drawing.Point(123, 43)
        Me.combo_tuso.Name = "combo_tuso"
        Me.combo_tuso.Size = New System.Drawing.Size(360, 21)
        Me.combo_tuso.TabIndex = 4
        '
        'label_situacao
        '
        Me.label_situacao.AutoSize = True
        Me.label_situacao.BackColor = System.Drawing.Color.Transparent
        Me.label_situacao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_situacao.Location = New System.Drawing.Point(24, 46)
        Me.label_situacao.Name = "label_situacao"
        Me.label_situacao.Size = New System.Drawing.Size(74, 13)
        Me.label_situacao.TabIndex = 42
        Me.label_situacao.Text = "Tipo de Uso"
        '
        'combo_substancia
        '
        Me.combo_substancia.BackColor = System.Drawing.Color.MistyRose
        Me.combo_substancia.FormattingEnabled = True
        Me.combo_substancia.Location = New System.Drawing.Point(123, 16)
        Me.combo_substancia.Name = "combo_substancia"
        Me.combo_substancia.Size = New System.Drawing.Size(360, 21)
        Me.combo_substancia.TabIndex = 3
        '
        'label_tipo
        '
        Me.label_tipo.AutoSize = True
        Me.label_tipo.BackColor = System.Drawing.Color.Transparent
        Me.label_tipo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tipo.Location = New System.Drawing.Point(24, 19)
        Me.label_tipo.Name = "label_tipo"
        Me.label_tipo.Size = New System.Drawing.Size(69, 13)
        Me.label_tipo.TabIndex = 38
        Me.label_tipo.Text = "Substância"
        '
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(382, 192)
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
        Me.button_confirm.Location = New System.Drawing.Point(25, 193)
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
        'date_final
        '
        Me.date_final.Checked = False
        Me.date_final.CustomFormat = ""
        Me.date_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_final.Location = New System.Drawing.Point(123, 106)
        Me.date_final.Name = "date_final"
        Me.date_final.ShowCheckBox = True
        Me.date_final.Size = New System.Drawing.Size(114, 21)
        Me.date_final.TabIndex = 46
        '
        'date_inicial
        '
        Me.date_inicial.Checked = False
        Me.date_inicial.CustomFormat = ""
        Me.date_inicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_inicial.Location = New System.Drawing.Point(123, 72)
        Me.date_inicial.Name = "date_inicial"
        Me.date_inicial.ShowCheckBox = True
        Me.date_inicial.Size = New System.Drawing.Size(114, 21)
        Me.date_inicial.TabIndex = 45
        '
        'label_final
        '
        Me.label_final.AutoSize = True
        Me.label_final.BackColor = System.Drawing.Color.Transparent
        Me.label_final.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_final.Location = New System.Drawing.Point(24, 112)
        Me.label_final.Name = "label_final"
        Me.label_final.Size = New System.Drawing.Size(64, 13)
        Me.label_final.TabIndex = 48
        Me.label_final.Text = "Data Final"
        '
        'label_inicial
        '
        Me.label_inicial.AutoSize = True
        Me.label_inicial.BackColor = System.Drawing.Color.Transparent
        Me.label_inicial.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_inicial.Location = New System.Drawing.Point(24, 78)
        Me.label_inicial.Name = "label_inicial"
        Me.label_inicial.Size = New System.Drawing.Size(72, 13)
        Me.label_inicial.TabIndex = 47
        Me.label_inicial.Text = "Data Inicial"
        '
        'label_motivo
        '
        Me.label_motivo.BackColor = System.Drawing.Color.Transparent
        Me.label_motivo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_motivo.Location = New System.Drawing.Point(24, 142)
        Me.label_motivo.Name = "label_motivo"
        Me.label_motivo.Size = New System.Drawing.Size(93, 44)
        Me.label_motivo.TabIndex = 50
        Me.label_motivo.Text = "Motivo Encerramento"
        '
        'text_motivo
        '
        Me.text_motivo.BackColor = System.Drawing.SystemColors.Info
        Me.text_motivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_motivo.Location = New System.Drawing.Point(123, 140)
        Me.text_motivo.MaxLength = 300
        Me.text_motivo.Multiline = True
        Me.text_motivo.Name = "text_motivo"
        Me.text_motivo.Size = New System.Drawing.Size(360, 46)
        Me.text_motivo.TabIndex = 49
        '
        'form_substancia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(514, 251)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_substancia"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Substâncias"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents combo_substancia As System.Windows.Forms.ComboBox
    Friend WithEvents label_tipo As System.Windows.Forms.Label
    Friend WithEvents timer_focus As System.Windows.Forms.Timer
    Friend WithEvents combo_tuso As System.Windows.Forms.ComboBox
    Friend WithEvents label_situacao As System.Windows.Forms.Label
    Friend WithEvents date_final As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_inicial As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_final As System.Windows.Forms.Label
    Friend WithEvents label_inicial As System.Windows.Forms.Label
    Friend WithEvents label_motivo As System.Windows.Forms.Label
    Friend WithEvents text_motivo As System.Windows.Forms.TextBox
End Class
