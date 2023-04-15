<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Main_Update_Admin
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.RFID_main_update_panel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 10
        Me.Guna2Elipse1.TargetControl = Me
        '
        'RFID_main_update_panel
        '
        Me.RFID_main_update_panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RFID_main_update_panel.Location = New System.Drawing.Point(0, 0)
        Me.RFID_main_update_panel.Name = "RFID_main_update_panel"
        Me.RFID_main_update_panel.Size = New System.Drawing.Size(519, 608)
        Me.RFID_main_update_panel.TabIndex = 2
        '
        'Frm_Main_Update_Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(519, 608)
        Me.Controls.Add(Me.RFID_main_update_panel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_Main_Update_Admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Main_Update_Admin"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents RFID_main_update_panel As Panel
End Class
