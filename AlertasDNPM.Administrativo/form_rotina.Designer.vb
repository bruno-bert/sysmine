<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_rotina

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_rotina))
        Me.button_execute = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.button_close = New System.Windows.Forms.Button
        Me.A1Panel2 = New Owf.Controls.A1Panel
        Me.lista_main = New System.Windows.Forms.ListBox
        Me.label_desc = New System.Windows.Forms.Label
        Me.panel_command = New Owf.Controls.A1Panel
        Me.button_clear = New System.Windows.Forms.Button
        Me.A1Panel2.SuspendLayout()
        Me.panel_command.SuspendLayout()
        Me.SuspendLayout()
        '
        'button_execute
        '
        Me.button_execute.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_execute.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_execute.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_execute.ImageIndex = 4
        Me.button_execute.ImageList = Me.ImageList1
        Me.button_execute.Location = New System.Drawing.Point(14, 5)
        Me.button_execute.Name = "button_execute"
        Me.button_execute.Size = New System.Drawing.Size(111, 28)
        Me.button_execute.TabIndex = 1
        Me.button_execute.Text = "Executar"
        Me.button_execute.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_execute.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "cancel.png")
        Me.ImageList1.Images.SetKeyName(1, "confirm.png")
        Me.ImageList1.Images.SetKeyName(2, "add2.png")
        Me.ImageList1.Images.SetKeyName(3, "trash.png")
        Me.ImageList1.Images.SetKeyName(4, "confirm.ico")
        Me.ImageList1.Images.SetKeyName(5, "edit-clear.png")
        '
        'button_close
        '
        Me.button_close.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_close.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_close.ImageIndex = 0
        Me.button_close.ImageList = Me.ImageList1
        Me.button_close.Location = New System.Drawing.Point(832, 5)
        Me.button_close.Name = "button_close"
        Me.button_close.Size = New System.Drawing.Size(103, 28)
        Me.button_close.TabIndex = 2
        Me.button_close.Text = "Fechar"
        Me.button_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_close.UseVisualStyleBackColor = True
        '
        'A1Panel2
        '
        Me.A1Panel2.BorderColor = System.Drawing.Color.Silver
        Me.A1Panel2.Controls.Add(Me.lista_main)
        Me.A1Panel2.Controls.Add(Me.label_desc)
        Me.A1Panel2.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.A1Panel2.GradientStartColor = System.Drawing.Color.White
        Me.A1Panel2.Image = Nothing
        Me.A1Panel2.ImageLocation = New System.Drawing.Point(4, 4)
        Me.A1Panel2.Location = New System.Drawing.Point(16, 3)
        Me.A1Panel2.Name = "A1Panel2"
        Me.A1Panel2.Size = New System.Drawing.Size(948, 457)
        Me.A1Panel2.TabIndex = 10
        '
        'lista_main
        '
        Me.lista_main.BackColor = System.Drawing.Color.Linen
        Me.lista_main.FormattingEnabled = True
        Me.lista_main.HorizontalScrollbar = True
        Me.lista_main.Location = New System.Drawing.Point(10, 20)
        Me.lista_main.Name = "lista_main"
        Me.lista_main.Size = New System.Drawing.Size(921, 420)
        Me.lista_main.TabIndex = 21
        '
        'label_desc
        '
        Me.label_desc.AutoSize = True
        Me.label_desc.BackColor = System.Drawing.Color.Transparent
        Me.label_desc.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_desc.Location = New System.Drawing.Point(15, 4)
        Me.label_desc.Name = "label_desc"
        Me.label_desc.Size = New System.Drawing.Size(296, 13)
        Me.label_desc.TabIndex = 20
        Me.label_desc.Text = "Para executar a rotina, clique no botão EXECUTAR"
        '
        'panel_command
        '
        Me.panel_command.BorderColor = System.Drawing.Color.Silver
        Me.panel_command.Controls.Add(Me.button_clear)
        Me.panel_command.Controls.Add(Me.button_close)
        Me.panel_command.Controls.Add(Me.button_execute)
        Me.panel_command.GradientEndColor = System.Drawing.Color.LightSteelBlue
        Me.panel_command.GradientStartColor = System.Drawing.Color.White
        Me.panel_command.Image = Nothing
        Me.panel_command.ImageLocation = New System.Drawing.Point(4, 4)
        Me.panel_command.Location = New System.Drawing.Point(12, 466)
        Me.panel_command.Name = "panel_command"
        Me.panel_command.Size = New System.Drawing.Size(952, 43)
        Me.panel_command.TabIndex = 11
        '
        'button_clear
        '
        Me.button_clear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button_clear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.button_clear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button_clear.ImageIndex = 5
        Me.button_clear.ImageList = Me.ImageList1
        Me.button_clear.Location = New System.Drawing.Point(401, 5)
        Me.button_clear.Name = "button_clear"
        Me.button_clear.Size = New System.Drawing.Size(136, 28)
        Me.button_clear.TabIndex = 3
        Me.button_clear.Text = "Limpar Lista"
        Me.button_clear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.button_clear.UseVisualStyleBackColor = True
        '
        'form_rotina
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(976, 521)
        Me.Controls.Add(Me.panel_command)
        Me.Controls.Add(Me.A1Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_rotina"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Rotina de Sincronização de Dados e Geração de Alertas"
        Me.A1Panel2.ResumeLayout(False)
        Me.A1Panel2.PerformLayout()
        Me.panel_command.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents button_execute As System.Windows.Forms.Button
    Friend WithEvents button_close As System.Windows.Forms.Button
    Friend WithEvents A1Panel2 As Owf.Controls.A1Panel
    Friend WithEvents label_desc As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents panel_command As Owf.Controls.A1Panel
    Friend WithEvents lista_main As System.Windows.Forms.ListBox
    Friend WithEvents button_clear As System.Windows.Forms.Button
End Class
