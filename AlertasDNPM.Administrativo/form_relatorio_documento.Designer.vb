<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_relatorio_documento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_relatorio_documento))
        Me.A1Panel1 = New Owf.Controls.A1Panel
        Me.button_report = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button_close = New System.Windows.Forms.Button
        Me.A1Panel2 = New Owf.Controls.A1Panel
        Me.label_relatorio = New System.Windows.Forms.Label
        Me.tab_main = New System.Windows.Forms.TabControl
        Me.tab_rel1 = New System.Windows.Forms.TabPage
        Me.button_lista_processos = New System.Windows.Forms.Button
        Me.check_titular = New System.Windows.Forms.CheckBox
        Me.label_fase = New System.Windows.Forms.Label
        Me.list_fase = New System.Windows.Forms.CheckedListBox
        Me.label_titular = New System.Windows.Forms.Label
        Me.list_titular = New System.Windows.Forms.CheckedListBox
        Me.check_fase = New System.Windows.Forms.CheckBox
        Me.check_tudo_processo = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.check_tudo_tipo_documento = New System.Windows.Forms.CheckBox
        Me.label_periodo_ate2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.date_vencimento_ate = New System.Windows.Forms.DateTimePicker
        Me.label_periodo_de2 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.date_vencimento_de = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.label_periodo2 = New System.Windows.Forms.Label
        Me.label_periodo_ate1 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.date_publicacao_ate = New System.Windows.Forms.DateTimePicker
        Me.label_periodo_de1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.date_publicacao_de = New System.Windows.Forms.DateTimePicker
        Me.label_periodo1 = New System.Windows.Forms.Label
        Me.label_dias = New System.Windows.Forms.Label
        Me.text_dias = New System.Windows.Forms.TextBox
        Me.label_tipo_documento = New System.Windows.Forms.Label
        Me.list_tipo_documento = New System.Windows.Forms.CheckedListBox
        Me.label_orgao = New System.Windows.Forms.Label
        Me.list_orgao = New System.Windows.Forms.CheckedListBox
        Me.label_processo = New System.Windows.Forms.Label
        Me.list_processo = New System.Windows.Forms.CheckedListBox
        Me.label_tipo = New System.Windows.Forms.Label
        Me.combo_tipo = New System.Windows.Forms.ComboBox
        Me.check_tudo_orgao = New System.Windows.Forms.CheckBox
        Me.tab_rel2 = New System.Windows.Forms.TabPage
        Me.check_titular2 = New System.Windows.Forms.CheckBox
        Me.label_fase2 = New System.Windows.Forms.Label
        Me.list_fase2 = New System.Windows.Forms.CheckedListBox
        Me.label_titular2 = New System.Windows.Forms.Label
        Me.list_titular2 = New System.Windows.Forms.CheckedListBox
        Me.check_fase2 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.A1Panel1.SuspendLayout()
        Me.A1Panel2.SuspendLayout()
        Me.tab_main.SuspendLayout()
        Me.tab_rel1.SuspendLayout()
        Me.tab_rel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'A1Panel1
        '
        Me.A1Panel1.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel1.Controls.Add(Me.button_report)
        Me.A1Panel1.Controls.Add(Me.button_close)
        Me.A1Panel1.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel1.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel1.Image = Nothing
        Me.A1Panel1.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel1.Location = New System.Drawing.Point(14, 648)
        Me.A1Panel1.Name = "A1Panel1"
        Me.A1Panel1.Size = New System.Drawing.Size(788, 43)
        Me.A1Panel1.TabIndex = 9
        '
        'button_report
        '
        Me.button_report.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_report.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_report.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_report.ImageIndex = 1
        Me.button_report.ImageList = Me.ImageList1
        Me.button_report.Location = New System.Drawing.Point(13, 5)
        Me.button_report.Name = "button_report"
        Me.button_report.Size = New System.Drawing.Size(144, 28)
        Me.button_report.TabIndex = 11
        Me.button_report.Text = "Gerar Relatório"
        Me.button_report.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_report.UseVisualStyleBackColor = True
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
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(685, 5)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(88, 28)
        Me.button_close.TabIndex = 12
        Me.button_close.Text = "Fechar"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_close.UseVisualStyleBackColor = True
        '
        'A1Panel2
        '
        Me.A1Panel2.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel2.Controls.Add(Me.label_relatorio)
        Me.A1Panel2.Controls.Add(Me.tab_main)
        Me.A1Panel2.Controls.Add(Me.Label1)
        Me.A1Panel2.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel2.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel2.Image = Nothing
        Me.A1Panel2.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel2.Location = New System.Drawing.Point(14, 12)
        Me.A1Panel2.Name = "A1Panel2"
        Me.A1Panel2.Size = New System.Drawing.Size(788, 630)
        Me.A1Panel2.TabIndex = 10
        '
        'label_relatorio
        '
        Me.label_relatorio.AutoSize = True
        Me.label_relatorio.BackColor = System.Drawing.Color.Transparent
        Me.label_relatorio.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_relatorio.Location = New System.Drawing.Point(14, 49)
        Me.label_relatorio.Name = "label_relatorio"
        Me.label_relatorio.Size = New System.Drawing.Size(189, 13)
        Me.label_relatorio.TabIndex = 97
        Me.label_relatorio.Text = "Selecione o Relatório desejado:"
        '
        'tab_main
        '
        Me.tab_main.Appearance = System.Windows.Forms.TabAppearance.Buttons
        Me.tab_main.Controls.Add(Me.tab_rel1)
        Me.tab_main.Controls.Add(Me.tab_rel2)
        Me.tab_main.Location = New System.Drawing.Point(13, 77)
        Me.tab_main.Name = "tab_main"
        Me.tab_main.SelectedIndex = 0
        Me.tab_main.Size = New System.Drawing.Size(760, 540)
        Me.tab_main.TabIndex = 74
        '
        'tab_rel1
        '
        Me.tab_rel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tab_rel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tab_rel1.Controls.Add(Me.button_lista_processos)
        Me.tab_rel1.Controls.Add(Me.check_titular)
        Me.tab_rel1.Controls.Add(Me.label_fase)
        Me.tab_rel1.Controls.Add(Me.list_fase)
        Me.tab_rel1.Controls.Add(Me.label_titular)
        Me.tab_rel1.Controls.Add(Me.list_titular)
        Me.tab_rel1.Controls.Add(Me.check_fase)
        Me.tab_rel1.Controls.Add(Me.check_tudo_processo)
        Me.tab_rel1.Controls.Add(Me.Label13)
        Me.tab_rel1.Controls.Add(Me.check_tudo_tipo_documento)
        Me.tab_rel1.Controls.Add(Me.label_periodo_ate2)
        Me.tab_rel1.Controls.Add(Me.Label12)
        Me.tab_rel1.Controls.Add(Me.date_vencimento_ate)
        Me.tab_rel1.Controls.Add(Me.label_periodo_de2)
        Me.tab_rel1.Controls.Add(Me.Label11)
        Me.tab_rel1.Controls.Add(Me.date_vencimento_de)
        Me.tab_rel1.Controls.Add(Me.Label10)
        Me.tab_rel1.Controls.Add(Me.label_periodo2)
        Me.tab_rel1.Controls.Add(Me.label_periodo_ate1)
        Me.tab_rel1.Controls.Add(Me.Label9)
        Me.tab_rel1.Controls.Add(Me.date_publicacao_ate)
        Me.tab_rel1.Controls.Add(Me.label_periodo_de1)
        Me.tab_rel1.Controls.Add(Me.Label8)
        Me.tab_rel1.Controls.Add(Me.date_publicacao_de)
        Me.tab_rel1.Controls.Add(Me.label_periodo1)
        Me.tab_rel1.Controls.Add(Me.label_dias)
        Me.tab_rel1.Controls.Add(Me.text_dias)
        Me.tab_rel1.Controls.Add(Me.label_tipo_documento)
        Me.tab_rel1.Controls.Add(Me.list_tipo_documento)
        Me.tab_rel1.Controls.Add(Me.label_orgao)
        Me.tab_rel1.Controls.Add(Me.list_orgao)
        Me.tab_rel1.Controls.Add(Me.label_processo)
        Me.tab_rel1.Controls.Add(Me.list_processo)
        Me.tab_rel1.Controls.Add(Me.label_tipo)
        Me.tab_rel1.Controls.Add(Me.combo_tipo)
        Me.tab_rel1.Controls.Add(Me.check_tudo_orgao)
        Me.tab_rel1.Location = New System.Drawing.Point(4, 25)
        Me.tab_rel1.Name = "tab_rel1"
        Me.tab_rel1.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_rel1.Size = New System.Drawing.Size(752, 511)
        Me.tab_rel1.TabIndex = 1
        Me.tab_rel1.Text = "Relatório de Documentos - Vencimentos"
        Me.tab_rel1.UseVisualStyleBackColor = True
        '
        'button_lista_processos
        '
        Me.button_lista_processos.Location = New System.Drawing.Point(22, 469)
        Me.button_lista_processos.Name = "button_lista_processos"
        Me.button_lista_processos.Size = New System.Drawing.Size(120, 23)
        Me.button_lista_processos.TabIndex = 135
        Me.button_lista_processos.Text = "Listar Processos"
        Me.button_lista_processos.UseVisualStyleBackColor = True
        '
        'check_titular
        '
        Me.check_titular.AutoSize = True
        Me.check_titular.BackColor = System.Drawing.Color.Transparent
        Me.check_titular.Location = New System.Drawing.Point(330, 47)
        Me.check_titular.Name = "check_titular"
        Me.check_titular.Size = New System.Drawing.Size(56, 17)
        Me.check_titular.TabIndex = 134
        Me.check_titular.Text = "Todos"
        Me.check_titular.UseVisualStyleBackColor = False
        '
        'label_fase
        '
        Me.label_fase.AutoSize = True
        Me.label_fase.BackColor = System.Drawing.Color.Transparent
        Me.label_fase.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fase.Location = New System.Drawing.Point(423, 51)
        Me.label_fase.Name = "label_fase"
        Me.label_fase.Size = New System.Drawing.Size(49, 13)
        Me.label_fase.TabIndex = 132
        Me.label_fase.Text = "Fase(s)"
        '
        'list_fase
        '
        Me.list_fase.FormattingEnabled = True
        Me.list_fase.Location = New System.Drawing.Point(426, 67)
        Me.list_fase.Name = "list_fase"
        Me.list_fase.Size = New System.Drawing.Size(309, 124)
        Me.list_fase.TabIndex = 130
        '
        'label_titular
        '
        Me.label_titular.AutoSize = True
        Me.label_titular.BackColor = System.Drawing.Color.Transparent
        Me.label_titular.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_titular.Location = New System.Drawing.Point(19, 51)
        Me.label_titular.Name = "label_titular"
        Me.label_titular.Size = New System.Drawing.Size(43, 13)
        Me.label_titular.TabIndex = 131
        Me.label_titular.Text = "Titular"
        '
        'list_titular
        '
        Me.list_titular.FormattingEnabled = True
        Me.list_titular.Location = New System.Drawing.Point(22, 67)
        Me.list_titular.Name = "list_titular"
        Me.list_titular.Size = New System.Drawing.Size(364, 184)
        Me.list_titular.TabIndex = 129
        '
        'check_fase
        '
        Me.check_fase.AutoSize = True
        Me.check_fase.BackColor = System.Drawing.Color.Transparent
        Me.check_fase.Location = New System.Drawing.Point(679, 51)
        Me.check_fase.Name = "check_fase"
        Me.check_fase.Size = New System.Drawing.Size(56, 17)
        Me.check_fase.TabIndex = 133
        Me.check_fase.Text = "Todas"
        Me.check_fase.UseVisualStyleBackColor = False
        '
        'check_tudo_processo
        '
        Me.check_tudo_processo.AutoSize = True
        Me.check_tudo_processo.BackColor = System.Drawing.Color.Transparent
        Me.check_tudo_processo.Location = New System.Drawing.Point(142, 276)
        Me.check_tudo_processo.Name = "check_tudo_processo"
        Me.check_tudo_processo.Size = New System.Drawing.Size(56, 17)
        Me.check_tudo_processo.TabIndex = 122
        Me.check_tudo_processo.Text = "Todos"
        Me.check_tudo_processo.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(592, 419)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 116
        Me.Label13.Text = "Até"
        '
        'check_tudo_tipo_documento
        '
        Me.check_tudo_tipo_documento.AutoSize = True
        Me.check_tudo_tipo_documento.BackColor = System.Drawing.Color.Transparent
        Me.check_tudo_tipo_documento.Location = New System.Drawing.Point(349, 411)
        Me.check_tudo_tipo_documento.Name = "check_tudo_tipo_documento"
        Me.check_tudo_tipo_documento.Size = New System.Drawing.Size(56, 17)
        Me.check_tudo_tipo_documento.TabIndex = 120
        Me.check_tudo_tipo_documento.Text = "Todos"
        Me.check_tudo_tipo_documento.UseVisualStyleBackColor = False
        '
        'label_periodo_ate2
        '
        Me.label_periodo_ate2.AutoSize = True
        Me.label_periodo_ate2.BackColor = System.Drawing.Color.Transparent
        Me.label_periodo_ate2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_periodo_ate2.Location = New System.Drawing.Point(592, 419)
        Me.label_periodo_ate2.Name = "label_periodo_ate2"
        Me.label_periodo_ate2.Size = New System.Drawing.Size(26, 13)
        Me.label_periodo_ate2.TabIndex = 115
        Me.label_periodo_ate2.Text = "Até"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(433, 420)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 13)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "De"
        '
        'date_vencimento_ate
        '
        Me.date_vencimento_ate.Checked = False
        Me.date_vencimento_ate.CustomFormat = ""
        Me.date_vencimento_ate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_vencimento_ate.Location = New System.Drawing.Point(621, 414)
        Me.date_vencimento_ate.Name = "date_vencimento_ate"
        Me.date_vencimento_ate.ShowCheckBox = True
        Me.date_vencimento_ate.Size = New System.Drawing.Size(114, 20)
        Me.date_vencimento_ate.TabIndex = 91
        '
        'label_periodo_de2
        '
        Me.label_periodo_de2.AutoSize = True
        Me.label_periodo_de2.BackColor = System.Drawing.Color.Transparent
        Me.label_periodo_de2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_periodo_de2.Location = New System.Drawing.Point(433, 420)
        Me.label_periodo_de2.Name = "label_periodo_de2"
        Me.label_periodo_de2.Size = New System.Drawing.Size(23, 13)
        Me.label_periodo_de2.TabIndex = 113
        Me.label_periodo_de2.Text = "De"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(433, 398)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 13)
        Me.Label11.TabIndex = 112
        Me.Label11.Text = "Período Vencimento"
        '
        'date_vencimento_de
        '
        Me.date_vencimento_de.Checked = False
        Me.date_vencimento_de.CustomFormat = ""
        Me.date_vencimento_de.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_vencimento_de.Location = New System.Drawing.Point(462, 414)
        Me.date_vencimento_de.Name = "date_vencimento_de"
        Me.date_vencimento_de.ShowCheckBox = True
        Me.date_vencimento_de.Size = New System.Drawing.Size(114, 20)
        Me.date_vencimento_de.TabIndex = 90
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(592, 356)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 110
        Me.Label10.Text = "Até"
        '
        'label_periodo2
        '
        Me.label_periodo2.AutoSize = True
        Me.label_periodo2.BackColor = System.Drawing.Color.Transparent
        Me.label_periodo2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_periodo2.Location = New System.Drawing.Point(433, 398)
        Me.label_periodo2.Name = "label_periodo2"
        Me.label_periodo2.Size = New System.Drawing.Size(121, 13)
        Me.label_periodo2.TabIndex = 111
        Me.label_periodo2.Text = "Período Vencimento"
        '
        'label_periodo_ate1
        '
        Me.label_periodo_ate1.AutoSize = True
        Me.label_periodo_ate1.BackColor = System.Drawing.Color.Transparent
        Me.label_periodo_ate1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_periodo_ate1.Location = New System.Drawing.Point(592, 356)
        Me.label_periodo_ate1.Name = "label_periodo_ate1"
        Me.label_periodo_ate1.Size = New System.Drawing.Size(26, 13)
        Me.label_periodo_ate1.TabIndex = 109
        Me.label_periodo_ate1.Text = "Até"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(433, 357)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 13)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "De"
        '
        'date_publicacao_ate
        '
        Me.date_publicacao_ate.Checked = False
        Me.date_publicacao_ate.CustomFormat = ""
        Me.date_publicacao_ate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_publicacao_ate.Location = New System.Drawing.Point(621, 350)
        Me.date_publicacao_ate.Name = "date_publicacao_ate"
        Me.date_publicacao_ate.ShowCheckBox = True
        Me.date_publicacao_ate.Size = New System.Drawing.Size(114, 20)
        Me.date_publicacao_ate.TabIndex = 88
        '
        'label_periodo_de1
        '
        Me.label_periodo_de1.AutoSize = True
        Me.label_periodo_de1.BackColor = System.Drawing.Color.Transparent
        Me.label_periodo_de1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_periodo_de1.Location = New System.Drawing.Point(433, 357)
        Me.label_periodo_de1.Name = "label_periodo_de1"
        Me.label_periodo_de1.Size = New System.Drawing.Size(23, 13)
        Me.label_periodo_de1.TabIndex = 107
        Me.label_periodo_de1.Text = "De"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(433, 335)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 13)
        Me.Label8.TabIndex = 105
        Me.Label8.Text = "Período Publicação"
        '
        'date_publicacao_de
        '
        Me.date_publicacao_de.Checked = False
        Me.date_publicacao_de.CustomFormat = ""
        Me.date_publicacao_de.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_publicacao_de.Location = New System.Drawing.Point(462, 351)
        Me.date_publicacao_de.Name = "date_publicacao_de"
        Me.date_publicacao_de.ShowCheckBox = True
        Me.date_publicacao_de.Size = New System.Drawing.Size(114, 20)
        Me.date_publicacao_de.TabIndex = 86
        '
        'label_periodo1
        '
        Me.label_periodo1.AutoSize = True
        Me.label_periodo1.BackColor = System.Drawing.Color.Transparent
        Me.label_periodo1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_periodo1.Location = New System.Drawing.Point(433, 335)
        Me.label_periodo1.Name = "label_periodo1"
        Me.label_periodo1.Size = New System.Drawing.Size(114, 13)
        Me.label_periodo1.TabIndex = 106
        Me.label_periodo1.Text = "Período Publicação"
        '
        'label_dias
        '
        Me.label_dias.AutoSize = True
        Me.label_dias.BackColor = System.Drawing.Color.Transparent
        Me.label_dias.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_dias.Location = New System.Drawing.Point(433, 293)
        Me.label_dias.Name = "label_dias"
        Me.label_dias.Size = New System.Drawing.Size(180, 13)
        Me.label_dias.TabIndex = 104
        Me.label_dias.Text = "Dias para Vencer (a partir de)"
        '
        'text_dias
        '
        Me.text_dias.BackColor = System.Drawing.SystemColors.Info
        Me.text_dias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_dias.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.text_dias.Location = New System.Drawing.Point(621, 285)
        Me.text_dias.MaxLength = 4
        Me.text_dias.Name = "text_dias"
        Me.text_dias.Size = New System.Drawing.Size(51, 21)
        Me.text_dias.TabIndex = 84
        '
        'label_tipo_documento
        '
        Me.label_tipo_documento.AutoSize = True
        Me.label_tipo_documento.BackColor = System.Drawing.Color.Transparent
        Me.label_tipo_documento.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tipo_documento.Location = New System.Drawing.Point(218, 412)
        Me.label_tipo_documento.Name = "label_tipo_documento"
        Me.label_tipo_documento.Size = New System.Drawing.Size(116, 13)
        Me.label_tipo_documento.TabIndex = 101
        Me.label_tipo_documento.Text = "Tipo Documento(s)"
        '
        'list_tipo_documento
        '
        Me.list_tipo_documento.FormattingEnabled = True
        Me.list_tipo_documento.Location = New System.Drawing.Point(221, 428)
        Me.list_tipo_documento.Name = "list_tipo_documento"
        Me.list_tipo_documento.Size = New System.Drawing.Size(179, 64)
        Me.list_tipo_documento.TabIndex = 81
        '
        'label_orgao
        '
        Me.label_orgao.AutoSize = True
        Me.label_orgao.BackColor = System.Drawing.Color.Transparent
        Me.label_orgao.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_orgao.Location = New System.Drawing.Point(218, 277)
        Me.label_orgao.Name = "label_orgao"
        Me.label_orgao.Size = New System.Drawing.Size(58, 13)
        Me.label_orgao.TabIndex = 100
        Me.label_orgao.Text = "Orgão(s)"
        '
        'list_orgao
        '
        Me.list_orgao.FormattingEnabled = True
        Me.list_orgao.Location = New System.Drawing.Point(221, 293)
        Me.list_orgao.Name = "list_orgao"
        Me.list_orgao.Size = New System.Drawing.Size(179, 109)
        Me.list_orgao.TabIndex = 80
        '
        'label_processo
        '
        Me.label_processo.AutoSize = True
        Me.label_processo.BackColor = System.Drawing.Color.Transparent
        Me.label_processo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_processo.Location = New System.Drawing.Point(15, 277)
        Me.label_processo.Name = "label_processo"
        Me.label_processo.Size = New System.Drawing.Size(74, 13)
        Me.label_processo.TabIndex = 98
        Me.label_processo.Text = "Processo(s)"
        '
        'list_processo
        '
        Me.list_processo.FormattingEnabled = True
        Me.list_processo.Location = New System.Drawing.Point(18, 293)
        Me.list_processo.Name = "list_processo"
        Me.list_processo.Size = New System.Drawing.Size(179, 169)
        Me.list_processo.TabIndex = 77
        '
        'label_tipo
        '
        Me.label_tipo.AutoSize = True
        Me.label_tipo.BackColor = System.Drawing.Color.Transparent
        Me.label_tipo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_tipo.Location = New System.Drawing.Point(19, 14)
        Me.label_tipo.Name = "label_tipo"
        Me.label_tipo.Size = New System.Drawing.Size(123, 13)
        Me.label_tipo.TabIndex = 95
        Me.label_tipo.Text = "Tipo de Visualização"
        '
        'combo_tipo
        '
        Me.combo_tipo.BackColor = System.Drawing.SystemColors.Info
        Me.combo_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_tipo.FormattingEnabled = True
        Me.combo_tipo.Location = New System.Drawing.Point(148, 6)
        Me.combo_tipo.Name = "combo_tipo"
        Me.combo_tipo.Size = New System.Drawing.Size(234, 21)
        Me.combo_tipo.TabIndex = 74
        '
        'check_tudo_orgao
        '
        Me.check_tudo_orgao.AutoSize = True
        Me.check_tudo_orgao.BackColor = System.Drawing.Color.Transparent
        Me.check_tudo_orgao.Location = New System.Drawing.Point(344, 277)
        Me.check_tudo_orgao.Name = "check_tudo_orgao"
        Me.check_tudo_orgao.Size = New System.Drawing.Size(56, 17)
        Me.check_tudo_orgao.TabIndex = 118
        Me.check_tudo_orgao.Text = "Todos"
        Me.check_tudo_orgao.UseVisualStyleBackColor = False
        '
        'tab_rel2
        '
        Me.tab_rel2.Controls.Add(Me.check_titular2)
        Me.tab_rel2.Controls.Add(Me.label_fase2)
        Me.tab_rel2.Controls.Add(Me.list_fase2)
        Me.tab_rel2.Controls.Add(Me.label_titular2)
        Me.tab_rel2.Controls.Add(Me.list_titular2)
        Me.tab_rel2.Controls.Add(Me.check_fase2)
        Me.tab_rel2.Location = New System.Drawing.Point(4, 25)
        Me.tab_rel2.Name = "tab_rel2"
        Me.tab_rel2.Size = New System.Drawing.Size(752, 511)
        Me.tab_rel2.TabIndex = 2
        Me.tab_rel2.Text = "Lista de Processos Minerários"
        Me.tab_rel2.UseVisualStyleBackColor = True
        '
        'check_titular2
        '
        Me.check_titular2.AutoSize = True
        Me.check_titular2.BackColor = System.Drawing.Color.Transparent
        Me.check_titular2.Location = New System.Drawing.Point(327, 9)
        Me.check_titular2.Name = "check_titular2"
        Me.check_titular2.Size = New System.Drawing.Size(56, 17)
        Me.check_titular2.TabIndex = 128
        Me.check_titular2.Text = "Todos"
        Me.check_titular2.UseVisualStyleBackColor = False
        '
        'label_fase2
        '
        Me.label_fase2.AutoSize = True
        Me.label_fase2.BackColor = System.Drawing.Color.Transparent
        Me.label_fase2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_fase2.Location = New System.Drawing.Point(412, 13)
        Me.label_fase2.Name = "label_fase2"
        Me.label_fase2.Size = New System.Drawing.Size(49, 13)
        Me.label_fase2.TabIndex = 126
        Me.label_fase2.Text = "Fase(s)"
        '
        'list_fase2
        '
        Me.list_fase2.FormattingEnabled = True
        Me.list_fase2.Location = New System.Drawing.Point(415, 29)
        Me.list_fase2.Name = "list_fase2"
        Me.list_fase2.Size = New System.Drawing.Size(309, 229)
        Me.list_fase2.TabIndex = 124
        '
        'label_titular2
        '
        Me.label_titular2.AutoSize = True
        Me.label_titular2.BackColor = System.Drawing.Color.Transparent
        Me.label_titular2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_titular2.Location = New System.Drawing.Point(16, 13)
        Me.label_titular2.Name = "label_titular2"
        Me.label_titular2.Size = New System.Drawing.Size(43, 13)
        Me.label_titular2.TabIndex = 125
        Me.label_titular2.Text = "Titular"
        '
        'list_titular2
        '
        Me.list_titular2.FormattingEnabled = True
        Me.list_titular2.Location = New System.Drawing.Point(19, 29)
        Me.list_titular2.Name = "list_titular2"
        Me.list_titular2.Size = New System.Drawing.Size(364, 454)
        Me.list_titular2.TabIndex = 123
        '
        'check_fase2
        '
        Me.check_fase2.AutoSize = True
        Me.check_fase2.BackColor = System.Drawing.Color.Transparent
        Me.check_fase2.Location = New System.Drawing.Point(538, 13)
        Me.check_fase2.Name = "check_fase2"
        Me.check_fase2.Size = New System.Drawing.Size(56, 17)
        Me.check_fase2.TabIndex = 127
        Me.check_fase2.Text = "Todos"
        Me.check_fase2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(386, 13)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "Selecione os filtros desejados e clique em Gerar Relatório"
        '
        'form_relatorio_documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(808, 703)
        Me.Controls.Add(Me.A1Panel2)
        Me.Controls.Add(Me.A1Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_relatorio_documento"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Relatórios"
        Me.A1Panel1.ResumeLayout(False)
        Me.A1Panel2.ResumeLayout(False)
        Me.A1Panel2.PerformLayout()
        Me.tab_main.ResumeLayout(False)
        Me.tab_rel1.ResumeLayout(False)
        Me.tab_rel1.PerformLayout()
        Me.tab_rel2.ResumeLayout(False)
        Me.tab_rel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents A1Panel1 As Owf.Controls.A1Panel
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents A1Panel2 As Owf.Controls.A1Panel
    Friend WithEvents button_report As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tab_main As System.Windows.Forms.TabControl
    Friend WithEvents tab_rel1 As System.Windows.Forms.TabPage
    Friend WithEvents check_tudo_processo As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents check_tudo_tipo_documento As System.Windows.Forms.CheckBox
    Friend WithEvents label_periodo_ate2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents date_vencimento_ate As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_periodo_de2 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents date_vencimento_de As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents label_periodo2 As System.Windows.Forms.Label
    Friend WithEvents label_periodo_ate1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents date_publicacao_ate As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_periodo_de1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents date_publicacao_de As System.Windows.Forms.DateTimePicker
    Friend WithEvents label_periodo1 As System.Windows.Forms.Label
    Friend WithEvents label_dias As System.Windows.Forms.Label
    Friend WithEvents text_dias As System.Windows.Forms.TextBox
    Friend WithEvents label_tipo_documento As System.Windows.Forms.Label
    Friend WithEvents list_tipo_documento As System.Windows.Forms.CheckedListBox
    Friend WithEvents label_orgao As System.Windows.Forms.Label
    Friend WithEvents list_orgao As System.Windows.Forms.CheckedListBox
    Friend WithEvents label_processo As System.Windows.Forms.Label
    Friend WithEvents list_processo As System.Windows.Forms.CheckedListBox
    Friend WithEvents check_tudo_orgao As System.Windows.Forms.CheckBox
    Friend WithEvents label_relatorio As System.Windows.Forms.Label
    Friend WithEvents label_tipo As System.Windows.Forms.Label
    Friend WithEvents combo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents tab_rel2 As System.Windows.Forms.TabPage
    Friend WithEvents check_titular2 As System.Windows.Forms.CheckBox
    Friend WithEvents label_fase2 As System.Windows.Forms.Label
    Friend WithEvents list_fase2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents label_titular2 As System.Windows.Forms.Label
    Friend WithEvents list_titular2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents check_fase2 As System.Windows.Forms.CheckBox
    Friend WithEvents check_titular As System.Windows.Forms.CheckBox
    Friend WithEvents label_fase As System.Windows.Forms.Label
    Friend WithEvents list_fase As System.Windows.Forms.CheckedListBox
    Friend WithEvents label_titular As System.Windows.Forms.Label
    Friend WithEvents list_titular As System.Windows.Forms.CheckedListBox
    Friend WithEvents check_fase As System.Windows.Forms.CheckBox
    Friend WithEvents button_lista_processos As System.Windows.Forms.Button
End Class
