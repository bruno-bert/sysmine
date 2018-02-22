<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lista_main = New System.Windows.Forms.ListBox
        Me.button_clear = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lista_main
        '
        Me.lista_main.BackColor = System.Drawing.Color.Linen
        Me.lista_main.FormattingEnabled = True
        Me.lista_main.HorizontalScrollbar = True
        Me.lista_main.Location = New System.Drawing.Point(1, 3)
        Me.lista_main.Name = "lista_main"
        Me.lista_main.Size = New System.Drawing.Size(832, 329)
        Me.lista_main.TabIndex = 0
        '
        'button_clear
        '
        Me.button_clear.Location = New System.Drawing.Point(724, 309)
        Me.button_clear.Name = "button_clear"
        Me.button_clear.Size = New System.Drawing.Size(109, 23)
        Me.button_clear.TabIndex = 1
        Me.button_clear.Text = "Limpar Lista"
        Me.button_clear.UseVisualStyleBackColor = True
        Me.button_clear.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(833, 339)
        Me.Controls.Add(Me.lista_main)
        Me.Controls.Add(Me.button_clear)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Serviço de Alertas DNPM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lista_main As System.Windows.Forms.ListBox
    Friend WithEvents button_clear As System.Windows.Forms.Button

End Class
