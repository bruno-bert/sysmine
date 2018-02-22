<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_release
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
        Me.text_release = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'text_release
        '
        Me.text_release.BackColor = System.Drawing.SystemColors.Info
        Me.text_release.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.text_release.Location = New System.Drawing.Point(12, 12)
        Me.text_release.Name = "text_release"
        Me.text_release.ReadOnly = True
        Me.text_release.Size = New System.Drawing.Size(717, 350)
        Me.text_release.TabIndex = 0
        Me.text_release.Text = ""
        '
        'form_release
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(741, 374)
        Me.Controls.Add(Me.text_release)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "form_release"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Últimas Atualizações"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents text_release As System.Windows.Forms.RichTextBox
End Class
