<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_config
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_config))
        Me.tab_main = New SGPM.TabControlEx
        Me.tab_servico = New System.Windows.Forms.TabPage
        Me.group_vencto = New System.Windows.Forms.GroupBox
        Me.text_intervalo = New System.Windows.Forms.TextBox
        Me.label_intervalo_vencto = New System.Windows.Forms.Label
        Me.text_inicio = New System.Windows.Forms.TextBox
        Me.label_inicio_vencto = New System.Windows.Forms.Label
        Me.group_geral = New System.Windows.Forms.GroupBox
        Me.txturl = New System.Windows.Forms.TextBox
        Me.label_url = New System.Windows.Forms.Label
        Me.txtintervalo = New System.Windows.Forms.TextBox
        Me.label_intervalo = New System.Windows.Forms.Label
        Me.group_email = New System.Windows.Forms.GroupBox
        Me.text_senha = New System.Windows.Forms.TextBox
        Me.label_senha = New System.Windows.Forms.Label
        Me.text_usuario = New System.Windows.Forms.TextBox
        Me.label_usuario = New System.Windows.Forms.Label
        Me.text_porta = New System.Windows.Forms.TextBox
        Me.label_porta = New System.Windows.Forms.Label
        Me.text_smtp = New System.Windows.Forms.TextBox
        Me.label_smtp = New System.Windows.Forms.Label
        Me.text_email = New System.Windows.Forms.TextBox
        Me.label_email = New System.Windows.Forms.Label
        Me.button_close = New System.Windows.Forms.Button
        Me.button_apply = New System.Windows.Forms.Button
        Me.button_ok = New System.Windows.Forms.Button
        Me.label_title = New System.Windows.Forms.Label
        Me.tab_main.SuspendLayout()
        Me.tab_servico.SuspendLayout()
        Me.group_vencto.SuspendLayout()
        Me.group_geral.SuspendLayout()
        Me.group_email.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab_main
        '
        Me.tab_main.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.tab_main.BackColor = System.Drawing.Color.LightGray
        Me.tab_main.Controls.Add(Me.tab_servico)
        Me.tab_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_main.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed
        Me.tab_main.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_main.HeaderAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.tab_main.HeaderBackColor = System.Drawing.Color.DarkGray
        Me.tab_main.HeaderBorderColor = System.Drawing.Color.DimGray
        Me.tab_main.HeaderFont = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_main.HeaderForeColor = System.Drawing.Color.DimGray
        Me.tab_main.HeaderSelectedBackColor = System.Drawing.Color.LightSteelBlue
        Me.tab_main.HeaderWidth = 120
        Me.tab_main.ItemSize = New System.Drawing.Size(32, 120)
        Me.tab_main.Location = New System.Drawing.Point(0, 0)
        Me.tab_main.Multiline = True
        Me.tab_main.Name = "tab_main"
        Me.tab_main.SelectedIndex = 0
        Me.tab_main.Size = New System.Drawing.Size(544, 444)
        Me.tab_main.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.tab_main.TabIndex = 0
        '
        'tab_servico
        '
        Me.tab_servico.BackColor = System.Drawing.Color.LightSteelBlue
        Me.tab_servico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tab_servico.Controls.Add(Me.group_vencto)
        Me.tab_servico.Controls.Add(Me.group_geral)
        Me.tab_servico.Controls.Add(Me.group_email)
        Me.tab_servico.Controls.Add(Me.button_close)
        Me.tab_servico.Controls.Add(Me.button_apply)
        Me.tab_servico.Controls.Add(Me.button_ok)
        Me.tab_servico.Controls.Add(Me.label_title)
        Me.tab_servico.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_servico.Location = New System.Drawing.Point(124, 4)
        Me.tab_servico.Name = "tab_servico"
        Me.tab_servico.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_servico.Size = New System.Drawing.Size(416, 436)
        Me.tab_servico.TabIndex = 1
        Me.tab_servico.Text = "Serviço"
        '
        'group_vencto
        '
        Me.group_vencto.Controls.Add(Me.text_intervalo)
        Me.group_vencto.Controls.Add(Me.label_intervalo_vencto)
        Me.group_vencto.Controls.Add(Me.text_inicio)
        Me.group_vencto.Controls.Add(Me.label_inicio_vencto)
        Me.group_vencto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.group_vencto.Location = New System.Drawing.Point(401, 333)
        Me.group_vencto.Name = "group_vencto"
        Me.group_vencto.Size = New System.Drawing.Size(374, 95)
        Me.group_vencto.TabIndex = 12
        Me.group_vencto.TabStop = False
        Me.group_vencto.Text = "Alertas de Vencimento"
        Me.group_vencto.Visible = False
        '
        'text_intervalo
        '
        Me.text_intervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_intervalo.Location = New System.Drawing.Point(266, 52)
        Me.text_intervalo.MaxLength = 4
        Me.text_intervalo.Name = "text_intervalo"
        Me.text_intervalo.Size = New System.Drawing.Size(69, 21)
        Me.text_intervalo.TabIndex = 10
        Me.text_intervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_intervalo_vencto
        '
        Me.label_intervalo_vencto.AutoSize = True
        Me.label_intervalo_vencto.Location = New System.Drawing.Point(17, 59)
        Me.label_intervalo_vencto.Name = "label_intervalo_vencto"
        Me.label_intervalo_vencto.Size = New System.Drawing.Size(243, 13)
        Me.label_intervalo_vencto.TabIndex = 9
        Me.label_intervalo_vencto.Text = "Intervalo para envio de alerta (em dias):"
        '
        'text_inicio
        '
        Me.text_inicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_inicio.Location = New System.Drawing.Point(266, 25)
        Me.text_inicio.MaxLength = 4
        Me.text_inicio.Name = "text_inicio"
        Me.text_inicio.Size = New System.Drawing.Size(69, 21)
        Me.text_inicio.TabIndex = 8
        Me.text_inicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_inicio_vencto
        '
        Me.label_inicio_vencto.AutoSize = True
        Me.label_inicio_vencto.Location = New System.Drawing.Point(15, 31)
        Me.label_inicio_vencto.Name = "label_inicio_vencto"
        Me.label_inicio_vencto.Size = New System.Drawing.Size(208, 13)
        Me.label_inicio_vencto.TabIndex = 7
        Me.label_inicio_vencto.Text = "Dias para início do envio de alerta:"
        '
        'group_geral
        '
        Me.group_geral.Controls.Add(Me.txturl)
        Me.group_geral.Controls.Add(Me.label_url)
        Me.group_geral.Controls.Add(Me.txtintervalo)
        Me.group_geral.Controls.Add(Me.label_intervalo)
        Me.group_geral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.group_geral.Location = New System.Drawing.Point(21, 61)
        Me.group_geral.Name = "group_geral"
        Me.group_geral.Size = New System.Drawing.Size(374, 145)
        Me.group_geral.TabIndex = 11
        Me.group_geral.TabStop = False
        Me.group_geral.Text = "Geral"
        '
        'txturl
        '
        Me.txturl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txturl.Location = New System.Drawing.Point(18, 86)
        Me.txturl.MaxLength = 100
        Me.txturl.Name = "txturl"
        Me.txturl.Size = New System.Drawing.Size(344, 21)
        Me.txturl.TabIndex = 10
        '
        'label_url
        '
        Me.label_url.AutoSize = True
        Me.label_url.Location = New System.Drawing.Point(15, 70)
        Me.label_url.Name = "label_url"
        Me.label_url.Size = New System.Drawing.Size(269, 13)
        Me.label_url.TabIndex = 9
        Me.label_url.Text = "Url para download de dados do site do DNPM:"
        '
        'txtintervalo
        '
        Me.txtintervalo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtintervalo.Location = New System.Drawing.Point(229, 25)
        Me.txtintervalo.MaxLength = 2
        Me.txtintervalo.Name = "txtintervalo"
        Me.txtintervalo.Size = New System.Drawing.Size(69, 21)
        Me.txtintervalo.TabIndex = 8
        Me.txtintervalo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_intervalo
        '
        Me.label_intervalo.AutoSize = True
        Me.label_intervalo.Location = New System.Drawing.Point(15, 31)
        Me.label_intervalo.Name = "label_intervalo"
        Me.label_intervalo.Size = New System.Drawing.Size(208, 13)
        Me.label_intervalo.TabIndex = 7
        Me.label_intervalo.Text = "Intervalo de execução (em horas):"
        '
        'group_email
        '
        Me.group_email.Controls.Add(Me.text_senha)
        Me.group_email.Controls.Add(Me.label_senha)
        Me.group_email.Controls.Add(Me.text_usuario)
        Me.group_email.Controls.Add(Me.label_usuario)
        Me.group_email.Controls.Add(Me.text_porta)
        Me.group_email.Controls.Add(Me.label_porta)
        Me.group_email.Controls.Add(Me.text_smtp)
        Me.group_email.Controls.Add(Me.label_smtp)
        Me.group_email.Controls.Add(Me.text_email)
        Me.group_email.Controls.Add(Me.label_email)
        Me.group_email.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.group_email.Location = New System.Drawing.Point(20, 212)
        Me.group_email.Name = "group_email"
        Me.group_email.Size = New System.Drawing.Size(375, 172)
        Me.group_email.TabIndex = 10
        Me.group_email.TabStop = False
        Me.group_email.Text = "Dados de email padrão"
        '
        'text_senha
        '
        Me.text_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_senha.Location = New System.Drawing.Point(120, 134)
        Me.text_senha.MaxLength = 30
        Me.text_senha.Name = "text_senha"
        Me.text_senha.Size = New System.Drawing.Size(161, 21)
        Me.text_senha.TabIndex = 18
        Me.text_senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_senha
        '
        Me.label_senha.AutoSize = True
        Me.label_senha.Location = New System.Drawing.Point(66, 136)
        Me.label_senha.Name = "label_senha"
        Me.label_senha.Size = New System.Drawing.Size(48, 13)
        Me.label_senha.TabIndex = 17
        Me.label_senha.Text = "Senha:"
        '
        'text_usuario
        '
        Me.text_usuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_usuario.Location = New System.Drawing.Point(120, 107)
        Me.text_usuario.MaxLength = 30
        Me.text_usuario.Name = "text_usuario"
        Me.text_usuario.Size = New System.Drawing.Size(161, 21)
        Me.text_usuario.TabIndex = 16
        Me.text_usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_usuario
        '
        Me.label_usuario.AutoSize = True
        Me.label_usuario.Location = New System.Drawing.Point(59, 109)
        Me.label_usuario.Name = "label_usuario"
        Me.label_usuario.Size = New System.Drawing.Size(55, 13)
        Me.label_usuario.TabIndex = 15
        Me.label_usuario.Text = "Usuário:"
        '
        'text_porta
        '
        Me.text_porta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_porta.Location = New System.Drawing.Point(120, 80)
        Me.text_porta.MaxLength = 5
        Me.text_porta.Name = "text_porta"
        Me.text_porta.Size = New System.Drawing.Size(63, 21)
        Me.text_porta.TabIndex = 14
        Me.text_porta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_porta
        '
        Me.label_porta.AutoSize = True
        Me.label_porta.Location = New System.Drawing.Point(72, 82)
        Me.label_porta.Name = "label_porta"
        Me.label_porta.Size = New System.Drawing.Size(42, 13)
        Me.label_porta.TabIndex = 13
        Me.label_porta.Text = "Porta:"
        '
        'text_smtp
        '
        Me.text_smtp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_smtp.Location = New System.Drawing.Point(120, 53)
        Me.text_smtp.MaxLength = 100
        Me.text_smtp.Name = "text_smtp"
        Me.text_smtp.Size = New System.Drawing.Size(237, 21)
        Me.text_smtp.TabIndex = 12
        Me.text_smtp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_smtp
        '
        Me.label_smtp.AutoSize = True
        Me.label_smtp.Location = New System.Drawing.Point(18, 57)
        Me.label_smtp.Name = "label_smtp"
        Me.label_smtp.Size = New System.Drawing.Size(96, 13)
        Me.label_smtp.TabIndex = 11
        Me.label_smtp.Text = "Servidor SMTP:"
        '
        'text_email
        '
        Me.text_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_email.Location = New System.Drawing.Point(120, 26)
        Me.text_email.MaxLength = 50
        Me.text_email.Name = "text_email"
        Me.text_email.Size = New System.Drawing.Size(237, 21)
        Me.text_email.TabIndex = 10
        Me.text_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'label_email
        '
        Me.label_email.AutoSize = True
        Me.label_email.Location = New System.Drawing.Point(49, 28)
        Me.label_email.Name = "label_email"
        Me.label_email.Size = New System.Drawing.Size(65, 13)
        Me.label_email.TabIndex = 9
        Me.label_email.Text = "Endereço:"
        '
        'button_close
        '
        Me.button_close.Location = New System.Drawing.Point(312, 402)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(75, 23)
        Me.button_close.TabIndex = 9
        Me.button_close.Text = "&Fechar"
        Me.button_close.UseVisualStyleBackColor = True
        '
        'button_apply
        '
        Me.button_apply.Location = New System.Drawing.Point(169, 402)
        Me.button_apply.Name = "button_apply"
        Me.button_apply.Size = New System.Drawing.Size(75, 23)
        Me.button_apply.TabIndex = 8
        Me.button_apply.Text = "&Aplicar"
        Me.button_apply.UseVisualStyleBackColor = True
        '
        'button_ok
        '
        Me.button_ok.Location = New System.Drawing.Point(31, 402)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(75, 23)
        Me.button_ok.TabIndex = 7
        Me.button_ok.Text = "&OK"
        Me.button_ok.UseVisualStyleBackColor = True
        '
        'label_title
        '
        Me.label_title.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_title.Location = New System.Drawing.Point(16, 16)
        Me.label_title.Name = "label_title"
        Me.label_title.Size = New System.Drawing.Size(349, 56)
        Me.label_title.TabIndex = 1
        Me.label_title.Text = "Serviço de Sincronização de dados e Envio de Alertas"
        '
        'form_config
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(544, 444)
        Me.Controls.Add(Me.tab_main)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_config"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Opções de Configuração"
        Me.tab_main.ResumeLayout(False)
        Me.tab_servico.ResumeLayout(False)
        Me.group_vencto.ResumeLayout(False)
        Me.group_vencto.PerformLayout()
        Me.group_geral.ResumeLayout(False)
        Me.group_geral.PerformLayout()
        Me.group_email.ResumeLayout(False)
        Me.group_email.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tab_main As TabControlEx
    Friend WithEvents tab_servico As System.Windows.Forms.TabPage
    Friend WithEvents label_title As System.Windows.Forms.Label
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents button_apply As System.Windows.Forms.Button
    Friend WithEvents button_ok As System.Windows.Forms.Button
    Friend WithEvents group_email As System.Windows.Forms.GroupBox
    Friend WithEvents group_geral As System.Windows.Forms.GroupBox
    Friend WithEvents txturl As System.Windows.Forms.TextBox
    Friend WithEvents label_url As System.Windows.Forms.Label
    Friend WithEvents txtintervalo As System.Windows.Forms.TextBox
    Friend WithEvents label_intervalo As System.Windows.Forms.Label
    Friend WithEvents text_senha As System.Windows.Forms.TextBox
    Friend WithEvents label_senha As System.Windows.Forms.Label
    Friend WithEvents text_usuario As System.Windows.Forms.TextBox
    Friend WithEvents label_usuario As System.Windows.Forms.Label
    Friend WithEvents text_porta As System.Windows.Forms.TextBox
    Friend WithEvents label_porta As System.Windows.Forms.Label
    Friend WithEvents text_smtp As System.Windows.Forms.TextBox
    Friend WithEvents label_smtp As System.Windows.Forms.Label
    Friend WithEvents text_email As System.Windows.Forms.TextBox
    Friend WithEvents label_email As System.Windows.Forms.Label
    Friend WithEvents group_vencto As System.Windows.Forms.GroupBox
    Friend WithEvents text_intervalo As System.Windows.Forms.TextBox
    Friend WithEvents label_intervalo_vencto As System.Windows.Forms.Label
    Friend WithEvents text_inicio As System.Windows.Forms.TextBox
    Friend WithEvents label_inicio_vencto As System.Windows.Forms.Label
End Class
