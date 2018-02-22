<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_down
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
        Me.label_progresso = New System.Windows.Forms.Label
        Me.pbar_down = New System.Windows.Forms.ProgressBar
        Me.panel_main = New System.Windows.Forms.Panel
        Me.button_cancel = New System.Windows.Forms.Button
        Me.panel_main.SuspendLayout()
        Me.SuspendLayout()
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
        'panel_main
        '
        Me.panel_main.BackColor = System.Drawing.Color.LightGray
        Me.panel_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_main.Controls.Add(Me.button_cancel)
        Me.panel_main.Controls.Add(Me.label_progresso)
        Me.panel_main.Controls.Add(Me.pbar_down)
        Me.panel_main.Location = New System.Drawing.Point(378, 317)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(623, 134)
        Me.panel_main.TabIndex = 29
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
        'form_down
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 764)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_main)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_down"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Download do Arquivo"
        Me.panel_main.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label_progresso As System.Windows.Forms.Label
    Friend WithEvents pbar_down As System.Windows.Forms.ProgressBar
    Friend WithEvents panel_main As System.Windows.Forms.Panel
    Friend WithEvents button_cancel As System.Windows.Forms.Button
End Class
