<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_sobre
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

    Friend WithEvents TableLayoutPanel As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents image_main As System.Windows.Forms.PictureBox
    Friend WithEvents label_name As System.Windows.Forms.Label
    Friend WithEvents label_version As System.Windows.Forms.Label
    Friend WithEvents label_company As System.Windows.Forms.Label
    Friend WithEvents text_desc As System.Windows.Forms.TextBox
    Friend WithEvents button_ok As System.Windows.Forms.Button
    Friend WithEvents label_copyright As System.Windows.Forms.Label

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_sobre))
        Me.TableLayoutPanel = New System.Windows.Forms.TableLayoutPanel
        Me.image_main = New System.Windows.Forms.PictureBox
        Me.label_name = New System.Windows.Forms.Label
        Me.label_version = New System.Windows.Forms.Label
        Me.label_copyright = New System.Windows.Forms.Label
        Me.label_company = New System.Windows.Forms.Label
        Me.text_desc = New System.Windows.Forms.TextBox
        Me.button_ok = New System.Windows.Forms.Button
        Me.TableLayoutPanel.SuspendLayout()
        CType(Me.image_main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel
        '
        Me.TableLayoutPanel.ColumnCount = 2
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel.Controls.Add(Me.image_main, 0, 0)
        Me.TableLayoutPanel.Controls.Add(Me.label_name, 1, 0)
        Me.TableLayoutPanel.Controls.Add(Me.label_version, 1, 1)
        Me.TableLayoutPanel.Controls.Add(Me.label_copyright, 1, 2)
        Me.TableLayoutPanel.Controls.Add(Me.label_company, 1, 3)
        Me.TableLayoutPanel.Controls.Add(Me.text_desc, 1, 4)
        Me.TableLayoutPanel.Controls.Add(Me.button_ok, 1, 5)
        Me.TableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel.Location = New System.Drawing.Point(10, 9)
        Me.TableLayoutPanel.Name = "TableLayoutPanel"
        Me.TableLayoutPanel.RowCount = 6
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
        Me.TableLayoutPanel.Size = New System.Drawing.Size(668, 239)
        Me.TableLayoutPanel.TabIndex = 0
        '
        'image_main
        '
        Me.image_main.BackColor = System.Drawing.Color.LightGray
        Me.image_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.image_main.Image = CType(resources.GetObject("image_main.Image"), System.Drawing.Image)
        Me.image_main.Location = New System.Drawing.Point(3, 3)
        Me.image_main.Name = "image_main"
        Me.TableLayoutPanel.SetRowSpan(Me.image_main, 6)
        Me.image_main.Size = New System.Drawing.Size(261, 233)
        Me.image_main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.image_main.TabIndex = 0
        Me.image_main.TabStop = False
        '
        'label_name
        '
        Me.label_name.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_name.Location = New System.Drawing.Point(274, 0)
        Me.label_name.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.label_name.MaximumSize = New System.Drawing.Size(0, 17)
        Me.label_name.Name = "label_name"
        Me.label_name.Size = New System.Drawing.Size(391, 17)
        Me.label_name.TabIndex = 0
        Me.label_name.Text = "Product Name"
        Me.label_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_version
        '
        Me.label_version.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_version.Location = New System.Drawing.Point(274, 23)
        Me.label_version.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.label_version.MaximumSize = New System.Drawing.Size(0, 17)
        Me.label_version.Name = "label_version"
        Me.label_version.Size = New System.Drawing.Size(391, 17)
        Me.label_version.TabIndex = 0
        Me.label_version.Text = "Version"
        Me.label_version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_copyright
        '
        Me.label_copyright.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_copyright.Location = New System.Drawing.Point(274, 46)
        Me.label_copyright.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.label_copyright.MaximumSize = New System.Drawing.Size(0, 17)
        Me.label_copyright.Name = "label_copyright"
        Me.label_copyright.Size = New System.Drawing.Size(391, 17)
        Me.label_copyright.TabIndex = 0
        Me.label_copyright.Text = "Copyright"
        Me.label_copyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'label_company
        '
        Me.label_company.Dock = System.Windows.Forms.DockStyle.Fill
        Me.label_company.Location = New System.Drawing.Point(274, 69)
        Me.label_company.Margin = New System.Windows.Forms.Padding(7, 0, 3, 0)
        Me.label_company.MaximumSize = New System.Drawing.Size(0, 17)
        Me.label_company.Name = "label_company"
        Me.label_company.Size = New System.Drawing.Size(391, 17)
        Me.label_company.TabIndex = 0
        Me.label_company.Text = "Company Name"
        Me.label_company.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text_desc
        '
        Me.text_desc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.text_desc.Location = New System.Drawing.Point(274, 95)
        Me.text_desc.Margin = New System.Windows.Forms.Padding(7, 3, 3, 3)
        Me.text_desc.Multiline = True
        Me.text_desc.Name = "text_desc"
        Me.text_desc.ReadOnly = True
        Me.text_desc.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.text_desc.Size = New System.Drawing.Size(391, 113)
        Me.text_desc.TabIndex = 0
        Me.text_desc.TabStop = False
        '
        'button_ok
        '
        Me.button_ok.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.button_ok.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.button_ok.Location = New System.Drawing.Point(578, 214)
        Me.button_ok.Name = "button_ok"
        Me.button_ok.Size = New System.Drawing.Size(87, 22)
        Me.button_ok.TabIndex = 0
        Me.button_ok.Text = "&OK"
        '
        'form_sobre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.button_ok
        Me.ClientSize = New System.Drawing.Size(688, 257)
        Me.Controls.Add(Me.TableLayoutPanel)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "form_sobre"
        Me.Padding = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "form_sobre"
        Me.TableLayoutPanel.ResumeLayout(False)
        Me.TableLayoutPanel.PerformLayout()
        CType(Me.image_main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

End Class
