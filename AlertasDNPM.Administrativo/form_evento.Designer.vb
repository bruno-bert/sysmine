<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_evento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_evento))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.date_ocorrencia = New System.Windows.Forms.DateTimePicker
        Me.label_ocorrencia = New System.Windows.Forms.Label
        Me.label_descricao = New System.Windows.Forms.Label
        Me.text_descricao = New System.Windows.Forms.TextBox
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
        Me.A1Panel1.Controls.Add(Me.date_ocorrencia)
        Me.A1Panel1.Controls.Add(Me.label_ocorrencia)
        Me.A1Panel1.Controls.Add(Me.label_descricao)
        Me.A1Panel1.Controls.Add(Me.text_descricao)
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
        Me.A1Panel1.Size = New System.Drawing.Size(657, 262)
        Me.A1Panel1.TabIndex = 0
        '
        'date_ocorrencia
        '
        Me.date_ocorrencia.Checked = False
        Me.date_ocorrencia.CustomFormat = ""
        Me.date_ocorrencia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_ocorrencia.Location = New System.Drawing.Point(123, 162)
        Me.date_ocorrencia.Name = "date_ocorrencia"
        Me.date_ocorrencia.ShowCheckBox = True
        Me.date_ocorrencia.Size = New System.Drawing.Size(114, 21)
        Me.date_ocorrencia.TabIndex = 5
        '
        'label_ocorrencia
        '
        Me.label_ocorrencia.AutoSize = True
        Me.label_ocorrencia.BackColor = System.Drawing.Color.Transparent
        Me.label_ocorrencia.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_ocorrencia.Location = New System.Drawing.Point(9, 168)
        Me.label_ocorrencia.Name = "label_ocorrencia"
        Me.label_ocorrencia.Size = New System.Drawing.Size(100, 13)
        Me.label_ocorrencia.TabIndex = 43
        Me.label_ocorrencia.Text = "Data Ocorrência"
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
        Me.text_descricao.MaxLength = 1000
        Me.text_descricao.Multiline = True
        Me.text_descricao.Name = "text_descricao"
        Me.text_descricao.Size = New System.Drawing.Size(480, 112)
        Me.text_descricao.TabIndex = 2
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
        Me.button_close.Location = New System.Drawing.Point(502, 214)
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
        Me.button_confirm.Location = New System.Drawing.Point(33, 215)
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
        'form_evento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(665, 273)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_evento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Manutenção de Eventos - {0}"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents label_numero As System.Windows.Forms.Label
    Friend WithEvents text_numero As System.Windows.Forms.TextBox
    Friend WithEvents timer_focus As System.Windows.Forms.Timer
    Friend WithEvents label_descricao As System.Windows.Forms.Label
    Friend WithEvents text_descricao As System.Windows.Forms.TextBox
    Friend WithEvents date_ocorrencia As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_ocorrencia As System.Windows.Forms.Label
    Friend WithEvents file_sel As System.Windows.Forms.OpenFileDialog
End Class
