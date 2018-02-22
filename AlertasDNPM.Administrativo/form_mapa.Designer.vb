<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_mapa
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_mapa))
        Me.panel_mapa = New System.Windows.Forms.Panel
        Me.label_mapa = New System.Windows.Forms.Label
        Me.image_mapa = New System.Windows.Forms.PictureBox
        Me.mapa = New GMap.NET.WindowsForms.GMapControl
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdHibrido = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdMapa = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdSatelite = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.cmdCopiarImagemMapa = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.lblKML = New System.Windows.Forms.ToolStripLabel
        Me.cmdKML = New System.Windows.Forms.ToolStripButton
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.panel_main = New System.Windows.Forms.Panel
        Me.button_cancel = New System.Windows.Forms.Button
        Me.label_progresso = New System.Windows.Forms.Label
        Me.pbar_down = New System.Windows.Forms.ProgressBar
        Me.panel_mapa.SuspendLayout()
        CType(Me.image_mapa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.panel_main.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_mapa
        '
        Me.panel_mapa.BackColor = System.Drawing.Color.LightGray
        Me.panel_mapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_mapa.Controls.Add(Me.label_mapa)
        Me.panel_mapa.Controls.Add(Me.image_mapa)
        Me.panel_mapa.Location = New System.Drawing.Point(23, 40)
        Me.panel_mapa.Name = "panel_mapa"
        Me.panel_mapa.Size = New System.Drawing.Size(196, 53)
        Me.panel_mapa.TabIndex = 56
        Me.panel_mapa.Visible = False
        '
        'label_mapa
        '
        Me.label_mapa.BackColor = System.Drawing.Color.Transparent
        Me.label_mapa.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_mapa.Location = New System.Drawing.Point(3, 30)
        Me.label_mapa.Name = "label_mapa"
        Me.label_mapa.Size = New System.Drawing.Size(188, 20)
        Me.label_mapa.TabIndex = 28
        Me.label_mapa.Text = "Aguarde...carregando mapa..."
        '
        'image_mapa
        '
        Me.image_mapa.Image = CType(resources.GetObject("image_mapa.Image"), System.Drawing.Image)
        Me.image_mapa.ImageLocation = ""
        Me.image_mapa.InitialImage = Nothing
        Me.image_mapa.Location = New System.Drawing.Point(77, 9)
        Me.image_mapa.Name = "image_mapa"
        Me.image_mapa.Size = New System.Drawing.Size(38, 13)
        Me.image_mapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.image_mapa.TabIndex = 29
        Me.image_mapa.TabStop = False
        '
        'mapa
        '
        Me.mapa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mapa.Bearing = 0.0!
        Me.mapa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mapa.CanDragMap = True
        Me.mapa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mapa.GrayScaleMode = False
        Me.mapa.LevelsKeepInMemmory = 5
        Me.mapa.Location = New System.Drawing.Point(12, 31)
        Me.mapa.MarkersEnabled = True
        Me.mapa.MaxZoom = 2
        Me.mapa.MinZoom = 2
        Me.mapa.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.ViewCenter
        Me.mapa.Name = "mapa"
        Me.mapa.NegativeMode = False
        Me.mapa.PolygonsEnabled = True
        Me.mapa.RetryLoadTile = 0
        Me.mapa.RoutesEnabled = True
        Me.mapa.ShowTileGridLines = False
        Me.mapa.Size = New System.Drawing.Size(1063, 680)
        Me.mapa.TabIndex = 55
        Me.mapa.Visible = False
        Me.mapa.Zoom = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.cmdHibrido, Me.ToolStripSeparator2, Me.cmdMapa, Me.ToolStripSeparator3, Me.cmdSatelite, Me.ToolStripSeparator4, Me.cmdCopiarImagemMapa, Me.ToolStripSeparator5, Me.lblKML, Me.cmdKML})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1087, 25)
        Me.ToolStrip1.TabIndex = 57
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'cmdHibrido
        '
        Me.cmdHibrido.BackColor = System.Drawing.Color.Transparent
        Me.cmdHibrido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdHibrido.Image = CType(resources.GetObject("cmdHibrido.Image"), System.Drawing.Image)
        Me.cmdHibrido.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdHibrido.Name = "cmdHibrido"
        Me.cmdHibrido.Size = New System.Drawing.Size(51, 22)
        Me.cmdHibrido.Text = "Híbrido"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'cmdMapa
        '
        Me.cmdMapa.BackColor = System.Drawing.Color.Transparent
        Me.cmdMapa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdMapa.Image = CType(resources.GetObject("cmdMapa.Image"), System.Drawing.Image)
        Me.cmdMapa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdMapa.Name = "cmdMapa"
        Me.cmdMapa.Size = New System.Drawing.Size(41, 22)
        Me.cmdMapa.Text = "Mapa"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'cmdSatelite
        '
        Me.cmdSatelite.BackColor = System.Drawing.Color.Transparent
        Me.cmdSatelite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdSatelite.Image = CType(resources.GetObject("cmdSatelite.Image"), System.Drawing.Image)
        Me.cmdSatelite.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSatelite.Name = "cmdSatelite"
        Me.cmdSatelite.Size = New System.Drawing.Size(49, 22)
        Me.cmdSatelite.Text = "Satélite"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'cmdCopiarImagemMapa
        '
        Me.cmdCopiarImagemMapa.BackColor = System.Drawing.Color.Transparent
        Me.cmdCopiarImagemMapa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdCopiarImagemMapa.Image = CType(resources.GetObject("cmdCopiarImagemMapa.Image"), System.Drawing.Image)
        Me.cmdCopiarImagemMapa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCopiarImagemMapa.Name = "cmdCopiarImagemMapa"
        Me.cmdCopiarImagemMapa.Size = New System.Drawing.Size(93, 22)
        Me.cmdCopiarImagemMapa.Text = "Copiar Imagem"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'lblKML
        '
        Me.lblKML.BackColor = System.Drawing.Color.Transparent
        Me.lblKML.Name = "lblKML"
        Me.lblKML.Size = New System.Drawing.Size(177, 22)
        Me.lblKML.Text = "Base de Dados de Referência: {0}"
        '
        'cmdKML
        '
        Me.cmdKML.BackColor = System.Drawing.Color.Transparent
        Me.cmdKML.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.cmdKML.Image = CType(resources.GetObject("cmdKML.Image"), System.Drawing.Image)
        Me.cmdKML.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdKML.Name = "cmdKML"
        Me.cmdKML.Size = New System.Drawing.Size(129, 22)
        Me.cmdKML.Text = "Atualizar Arquivo KML"
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'panel_main
        '
        Me.panel_main.BackColor = System.Drawing.Color.LightGray
        Me.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_main.Controls.Add(Me.button_cancel)
        Me.panel_main.Controls.Add(Me.pbar_down)
        Me.panel_main.Controls.Add(Me.label_progresso)
        Me.panel_main.Location = New System.Drawing.Point(278, 269)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(623, 134)
        Me.panel_main.TabIndex = 58
        Me.panel_main.Visible = False
        '
        'button_cancel
        '
        Me.button_cancel.Location = New System.Drawing.Point(475, 93)
        Me.button_cancel.Name = "button_cancel"
        Me.button_cancel.Size = New System.Drawing.Size(122, 23)
        Me.button_cancel.TabIndex = 29
        Me.button_cancel.Text = "Cancelar"
        Me.button_cancel.UseVisualStyleBackColor = True
        Me.button_cancel.Visible = False
        '
        'label_progresso
        '
        Me.label_progresso.BackColor = System.Drawing.Color.Transparent
        Me.label_progresso.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_progresso.Location = New System.Drawing.Point(21, 25)
        Me.label_progresso.Name = "label_progresso"
        Me.label_progresso.Size = New System.Drawing.Size(492, 20)
        Me.label_progresso.TabIndex = 28
        Me.label_progresso.Text = "status"
        '
        'pbar_down
        '
        Me.pbar_down.Location = New System.Drawing.Point(24, 48)
        Me.pbar_down.Name = "pbar_down"
        Me.pbar_down.Size = New System.Drawing.Size(573, 39)
        Me.pbar_down.TabIndex = 27
        '
        'form_mapa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1087, 723)
        Me.Controls.Add(Me.panel_main)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.panel_mapa)
        Me.Controls.Add(Me.mapa)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "form_mapa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mapa - {0}"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.panel_mapa.ResumeLayout(False)
        Me.panel_mapa.PerformLayout()
        CType(Me.image_mapa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.panel_main.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents panel_mapa As System.Windows.Forms.Panel
    Friend WithEvents label_mapa As System.Windows.Forms.Label
    Friend WithEvents image_mapa As System.Windows.Forms.PictureBox
    Friend WithEvents mapa As GMap.NET.WindowsForms.GMapControl
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdCopiarImagemMapa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents cmdHibrido As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdMapa As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmdSatelite As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents lblKML As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdKML As System.Windows.Forms.ToolStripButton
    Friend WithEvents panel_main As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
    Friend WithEvents label_progresso As System.Windows.Forms.Label
    Friend WithEvents pbar_down As System.Windows.Forms.ProgressBar
End Class
