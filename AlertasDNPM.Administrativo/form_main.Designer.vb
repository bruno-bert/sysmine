<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_main))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.BottomToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.TopToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.RightToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.LeftToolStripPanel = New System.Windows.Forms.ToolStripPanel
        Me.ContentPanel = New System.Windows.Forms.ToolStripContentPanel
        Me.tool_main = New IconToolStrip.MultipleImageToolStrip
        Me.tool_config = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_empresa = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_operador = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_busca = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_processo = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_alerta = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_relatorio = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_rotina = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_limpa = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_backup = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_sobre = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_sair = New System.Windows.Forms.ToolStripButton
        Me.tool_evento = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.tool_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "empresa.png")
        Me.ImageList1.Images.SetKeyName(1, "ico_alertas.gif")
        Me.ImageList1.Images.SetKeyName(2, "business_users.png")
        Me.ImageList1.Images.SetKeyName(3, "form.png")
        Me.ImageList1.Images.SetKeyName(4, "warning_email.png")
        '
        'BottomToolStripPanel
        '
        Me.BottomToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.BottomToolStripPanel.Name = "BottomToolStripPanel"
        Me.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.BottomToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.BottomToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'TopToolStripPanel
        '
        Me.TopToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopToolStripPanel.Name = "TopToolStripPanel"
        Me.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.TopToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.TopToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'RightToolStripPanel
        '
        Me.RightToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.RightToolStripPanel.Name = "RightToolStripPanel"
        Me.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.RightToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.RightToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'LeftToolStripPanel
        '
        Me.LeftToolStripPanel.Location = New System.Drawing.Point(0, 0)
        Me.LeftToolStripPanel.Name = "LeftToolStripPanel"
        Me.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal
        Me.LeftToolStripPanel.RowMargin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.LeftToolStripPanel.Size = New System.Drawing.Size(0, 0)
        '
        'ContentPanel
        '
        Me.ContentPanel.Size = New System.Drawing.Size(889, 398)
        '
        'tool_main
        '
        Me.tool_main.DefaultImageProvider = Me.tool_main
        Me.tool_main.ImageSize = IconToolStrip.ImageSize.Small
        Me.tool_main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tool_config, Me.ToolStripSeparator1, Me.tool_empresa, Me.ToolStripSeparator4, Me.tool_operador, Me.ToolStripSeparator5, Me.tool_busca, Me.ToolStripSeparator8, Me.tool_processo, Me.ToolStripSeparator6, Me.tool_alerta, Me.ToolStripSeparator7, Me.tool_relatorio, Me.ToolStripSeparator10, Me.tool_rotina, Me.ToolStripSeparator2, Me.tool_limpa, Me.ToolStripSeparator9, Me.tool_backup, Me.ToolStripSeparator11, Me.tool_evento, Me.ToolStripSeparator12, Me.tool_sobre, Me.ToolStripSeparator3, Me.tool_sair})
        Me.tool_main.Location = New System.Drawing.Point(0, 0)
        Me.tool_main.Name = "tool_main"
        Me.tool_main.Size = New System.Drawing.Size(1037, 38)
        Me.tool_main.TabIndex = 12
        Me.tool_main.UseUnknownImageSizeIcon = False
        '
        'tool_config
        '
        Me.tool_config.Image = CType(resources.GetObject("tool_config.Image"), System.Drawing.Image)
        Me.tool_config.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_config.Name = "tool_config"
        Me.tool_config.Size = New System.Drawing.Size(88, 35)
        Me.tool_config.Text = "Configurações"
        Me.tool_config.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 38)
        '
        'tool_empresa
        '
        Me.tool_empresa.Image = CType(resources.GetObject("tool_empresa.Image"), System.Drawing.Image)
        Me.tool_empresa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_empresa.Name = "tool_empresa"
        Me.tool_empresa.Size = New System.Drawing.Size(61, 35)
        Me.tool_empresa.Text = "Empresas"
        Me.tool_empresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 38)
        '
        'tool_operador
        '
        Me.tool_operador.Image = CType(resources.GetObject("tool_operador.Image"), System.Drawing.Image)
        Me.tool_operador.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_operador.Name = "tool_operador"
        Me.tool_operador.Size = New System.Drawing.Size(72, 35)
        Me.tool_operador.Text = "Operadores"
        Me.tool_operador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 38)
        '
        'tool_busca
        '
        Me.tool_busca.Image = CType(resources.GetObject("tool_busca.Image"), System.Drawing.Image)
        Me.tool_busca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_busca.Name = "tool_busca"
        Me.tool_busca.Size = New System.Drawing.Size(80, 35)
        Me.tool_busca.Text = "Busca DNPM"
        Me.tool_busca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 38)
        '
        'tool_processo
        '
        Me.tool_processo.Image = CType(resources.GetObject("tool_processo.Image"), System.Drawing.Image)
        Me.tool_processo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_processo.Name = "tool_processo"
        Me.tool_processo.Size = New System.Drawing.Size(122, 35)
        Me.tool_processo.Text = "Processos Minerários"
        Me.tool_processo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 38)
        '
        'tool_alerta
        '
        Me.tool_alerta.Image = CType(resources.GetObject("tool_alerta.Image"), System.Drawing.Image)
        Me.tool_alerta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_alerta.Name = "tool_alerta"
        Me.tool_alerta.Size = New System.Drawing.Size(47, 35)
        Me.tool_alerta.Text = "Alertas"
        Me.tool_alerta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 38)
        '
        'tool_relatorio
        '
        Me.tool_relatorio.Image = CType(resources.GetObject("tool_relatorio.Image"), System.Drawing.Image)
        Me.tool_relatorio.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_relatorio.Name = "tool_relatorio"
        Me.tool_relatorio.Size = New System.Drawing.Size(58, 35)
        Me.tool_relatorio.Text = "Relatório"
        Me.tool_relatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(6, 38)
        '
        'tool_rotina
        '
        Me.tool_rotina.Image = CType(resources.GetObject("tool_rotina.Image"), System.Drawing.Image)
        Me.tool_rotina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_rotina.Name = "tool_rotina"
        Me.tool_rotina.Size = New System.Drawing.Size(45, 35)
        Me.tool_rotina.Text = "Rotina"
        Me.tool_rotina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tool_rotina.ToolTipText = "Execução da Rotina de Sincronização de Dados por Demanda"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 38)
        '
        'tool_limpa
        '
        Me.tool_limpa.Image = CType(resources.GetObject("tool_limpa.Image"), System.Drawing.Image)
        Me.tool_limpa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_limpa.Name = "tool_limpa"
        Me.tool_limpa.Size = New System.Drawing.Size(85, 35)
        Me.tool_limpa.Text = "Limpeza Geral"
        Me.tool_limpa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tool_limpa.ToolTipText = "Limpeza Geral"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(6, 38)
        '
        'tool_backup
        '
        Me.tool_backup.Image = CType(resources.GetObject("tool_backup.Image"), System.Drawing.Image)
        Me.tool_backup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_backup.Name = "tool_backup"
        Me.tool_backup.Size = New System.Drawing.Size(50, 35)
        Me.tool_backup.Text = "Backup"
        Me.tool_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 38)
        '
        'tool_sobre
        '
        Me.tool_sobre.Image = CType(resources.GetObject("tool_sobre.Image"), System.Drawing.Image)
        Me.tool_sobre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_sobre.Name = "tool_sobre"
        Me.tool_sobre.Size = New System.Drawing.Size(41, 35)
        Me.tool_sobre.Text = "Sobre"
        Me.tool_sobre.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 38)
        '
        'tool_sair
        '
        Me.tool_sair.Image = CType(resources.GetObject("tool_sair.Image"), System.Drawing.Image)
        Me.tool_sair.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_sair.Name = "tool_sair"
        Me.tool_sair.Size = New System.Drawing.Size(30, 35)
        Me.tool_sair.Text = "Sair"
        Me.tool_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tool_evento
        '
        Me.tool_evento.Image = CType(resources.GetObject("tool_evento.Image"), System.Drawing.Image)
        Me.tool_evento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tool_evento.Name = "tool_evento"
        Me.tool_evento.Size = New System.Drawing.Size(90, 35)
        Me.tool_evento.Text = "Eventos DNPM"
        Me.tool_evento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tool_evento.ToolTipText = "Lista de Eventos DNPM"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(6, 38)
        '
        'form_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1037, 422)
        Me.Controls.Add(Me.tool_main)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "form_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alertas DNPM - Módulo Administrativo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tool_main.ResumeLayout(False)
        Me.tool_main.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents BottomToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents TopToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents RightToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents LeftToolStripPanel As System.Windows.Forms.ToolStripPanel
    Friend WithEvents ContentPanel As System.Windows.Forms.ToolStripContentPanel
    Friend WithEvents MultipleImageToolStrip1 As IconToolStrip.MultipleImageToolStrip
    Friend WithEvents tool_config As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_main As IconToolStrip.MultipleImageToolStrip
    Friend WithEvents tool_empresa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_operador As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_processo As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_alerta As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_sobre As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_sair As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_rotina As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_busca As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_limpa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_relatorio As System.Windows.Forms.ToolStripButton
    Friend WithEvents tool_backup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tool_evento As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator

End Class
