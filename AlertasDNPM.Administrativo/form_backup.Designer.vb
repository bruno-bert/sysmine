<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_backup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_backup))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.text_status = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.text_erro = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.text_data_tentativa = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.text_data_backup = New System.Windows.Forms.TextBox
        Me.text_nome = New System.Windows.Forms.TextBox
        Me.button_backup = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.label_dataexecucao = New System.Windows.Forms.Label
        Me.label_nome = New System.Windows.Forms.Label
        Me.label_int = New System.Windows.Forms.Label
        Me.text_intervalo = New System.Windows.Forms.TextBox
        Me.button_close = New System.Windows.Forms.Button
        Me.button_confirm = New System.Windows.Forms.Button
        Me.timer_focus = New System.Windows.Forms.Timer(Me.components)
        Me.file_sel = New System.Windows.Forms.OpenFileDialog
        Me.A1Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Gray
        Me.A1Panel1.Controls.Add(Me.text_status)
        Me.A1Panel1.Controls.Add(Me.Label3)
        Me.A1Panel1.Controls.Add(Me.text_erro)
        Me.A1Panel1.Controls.Add(Me.Label2)
        Me.A1Panel1.Controls.Add(Me.text_data_tentativa)
        Me.A1Panel1.Controls.Add(Me.Label1)
        Me.A1Panel1.Controls.Add(Me.text_data_backup)
        Me.A1Panel1.Controls.Add(Me.text_nome)
        Me.A1Panel1.Controls.Add(Me.button_backup)
        Me.A1Panel1.Controls.Add(Me.label_dataexecucao)
        Me.A1Panel1.Controls.Add(Me.label_nome)
        Me.A1Panel1.Controls.Add(Me.label_int)
        Me.A1Panel1.Controls.Add(Me.text_intervalo)
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.Controls.Add(Me.button_confirm)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(3, 6)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.RoundCornerRadius = 20
        Me.A1Panel1.Size = New System.Drawing.Size(657, 326)
        Me.A1Panel1.TabIndex = 0
        '
        'text_status
        '
        Me.text_status.BackColor = System.Drawing.Color.Bisque
        Me.text_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_status.Enabled = False
        Me.text_status.Location = New System.Drawing.Point(182, 82)
        Me.text_status.MaxLength = 50
        Me.text_status.Name = "text_status"
        Me.text_status.ReadOnly = True
        Me.text_status.Size = New System.Drawing.Size(180, 21)
        Me.text_status.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(47, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 13)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Status Atual: "
        '
        'text_erro
        '
        Me.text_erro.BackColor = System.Drawing.Color.Bisque
        Me.text_erro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_erro.Enabled = False
        Me.text_erro.Location = New System.Drawing.Point(182, 208)
        Me.text_erro.MaxLength = 300
        Me.text_erro.Multiline = True
        Me.text_erro.Name = "text_erro"
        Me.text_erro.ReadOnly = True
        Me.text_erro.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.text_erro.Size = New System.Drawing.Size(392, 41)
        Me.text_erro.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Mensagem de Erro:"
        '
        'text_data_tentativa
        '
        Me.text_data_tentativa.BackColor = System.Drawing.Color.Bisque
        Me.text_data_tentativa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_data_tentativa.Enabled = False
        Me.text_data_tentativa.Location = New System.Drawing.Point(300, 161)
        Me.text_data_tentativa.MaxLength = 50
        Me.text_data_tentativa.Name = "text_data_tentativa"
        Me.text_data_tentativa.ReadOnly = True
        Me.text_data_tentativa.Size = New System.Drawing.Size(170, 21)
        Me.text_data_tentativa.TabIndex = 48
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Data da Última Tentativa de execução: "
        '
        'text_data_backup
        '
        Me.text_data_backup.BackColor = System.Drawing.Color.Bisque
        Me.text_data_backup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_data_backup.Enabled = False
        Me.text_data_backup.Location = New System.Drawing.Point(300, 127)
        Me.text_data_backup.MaxLength = 50
        Me.text_data_backup.Name = "text_data_backup"
        Me.text_data_backup.ReadOnly = True
        Me.text_data_backup.Size = New System.Drawing.Size(170, 21)
        Me.text_data_backup.TabIndex = 46
        '
        'text_nome
        '
        Me.text_nome.BackColor = System.Drawing.Color.Bisque
        Me.text_nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_nome.Enabled = False
        Me.text_nome.Location = New System.Drawing.Point(182, 44)
        Me.text_nome.MaxLength = 50
        Me.text_nome.Name = "text_nome"
        Me.text_nome.ReadOnly = True
        Me.text_nome.Size = New System.Drawing.Size(180, 21)
        Me.text_nome.TabIndex = 45
        '
        'button_backup
        '
        Me.button_backup.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_backup.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_backup.ImageIndex = 6
        Me.button_backup.ImageList = Me.ImageList1
        Me.button_backup.Location = New System.Drawing.Point(56, 266)
        Me.button_backup.Name = "button_backup"
        Me.button_backup.Size = New System.Drawing.Size(207, 34)
        Me.button_backup.TabIndex = 44
        Me.button_backup.Text = "Realizar Backup Agora"
        Me.button_backup.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_backup.UseVisualStyleBackColor = True
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
        Me.ImageList1.Images.SetKeyName(6, "backup1.png")
        '
        'label_dataexecucao
        '
        Me.label_dataexecucao.AutoSize = True
        Me.label_dataexecucao.BackColor = System.Drawing.Color.Transparent
        Me.label_dataexecucao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_dataexecucao.Location = New System.Drawing.Point(47, 135)
        Me.label_dataexecucao.Name = "label_dataexecucao"
        Me.label_dataexecucao.Size = New System.Drawing.Size(143, 13)
        Me.label_dataexecucao.TabIndex = 43
        Me.label_dataexecucao.Text = "Data do Último Backup:"
        '
        'label_nome
        '
        Me.label_nome.AutoSize = True
        Me.label_nome.BackColor = System.Drawing.Color.Transparent
        Me.label_nome.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_nome.Location = New System.Drawing.Point(43, 46)
        Me.label_nome.Name = "label_nome"
        Me.label_nome.Size = New System.Drawing.Size(115, 13)
        Me.label_nome.TabIndex = 40
        Me.label_nome.Text = "Nome do Arquivo: "
        '
        'label_int
        '
        Me.label_int.AutoSize = True
        Me.label_int.BackColor = System.Drawing.Color.Transparent
        Me.label_int.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_int.Location = New System.Drawing.Point(43, 19)
        Me.label_int.Name = "label_int"
        Me.label_int.Size = New System.Drawing.Size(238, 13)
        Me.label_int.TabIndex = 36
        Me.label_int.Text = "Intervalo entre backups ( em minutos): "
        '
        'text_intervalo
        '
        Me.text_intervalo.BackColor = System.Drawing.Color.Bisque
        Me.text_intervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_intervalo.Location = New System.Drawing.Point(287, 17)
        Me.text_intervalo.MaxLength = 4
        Me.text_intervalo.Name = "text_intervalo"
        Me.text_intervalo.Size = New System.Drawing.Size(75, 21)
        Me.text_intervalo.TabIndex = 1
        Me.text_intervalo.Text = "60"
        '
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(524, 272)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(101, 28)
        Me.button_close.TabIndex = 8
        Me.button_close.Text = "Fechar"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_close.UseVisualStyleBackColor = True
        '
        'button_confirm
        '
        Me.button_confirm.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_confirm.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_confirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_confirm.ImageIndex = 1
        Me.button_confirm.ImageList = Me.ImageList1
        Me.button_confirm.Location = New System.Drawing.Point(377, 16)
        Me.button_confirm.Name = "button_confirm"
        Me.button_confirm.Size = New System.Drawing.Size(149, 22)
        Me.button_confirm.TabIndex = 7
        Me.button_confirm.Text = "Alterar Intervalo"
        Me.button_confirm.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_confirm.UseVisualStyleBackColor = True
        '
        'timer_focus
        '
        Me.timer_focus.Enabled = True
        '
        'form_backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(665, 343)
        Me.Controls.Add(Me.A1Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_backup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Backup da Base de Dados"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_confirm As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents label_int As System.Windows.Forms.Label
    Friend WithEvents text_intervalo As System.Windows.Forms.TextBox
    Friend WithEvents timer_focus As System.Windows.Forms.Timer
    Friend WithEvents label_nome As System.Windows.Forms.Label
    Friend WithEvents label_dataexecucao As System.Windows.Forms.Label
    Friend WithEvents file_sel As System.Windows.Forms.OpenFileDialog
    Friend WithEvents button_backup As System.Windows.Forms.Button
    Friend WithEvents text_nome As System.Windows.Forms.TextBox
    Friend WithEvents text_erro As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents text_data_tentativa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents text_data_backup As System.Windows.Forms.TextBox
    Friend WithEvents text_status As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents button_close As System.Windows.Forms.Button
End Class
