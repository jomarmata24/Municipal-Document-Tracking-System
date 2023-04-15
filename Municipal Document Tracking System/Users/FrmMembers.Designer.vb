<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMembers
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.members_datagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.passwd = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.members_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'members_datagrid
        '
        Me.members_datagrid.AllowUserToAddRows = False
        Me.members_datagrid.AllowUserToDeleteRows = False
        Me.members_datagrid.AllowUserToResizeColumns = False
        Me.members_datagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.members_datagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.members_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.members_datagrid.BackgroundColor = System.Drawing.Color.White
        Me.members_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.members_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.members_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.members_datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.members_datagrid.ColumnHeadersHeight = 40
        Me.members_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.members_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.fname, Me.mail, Me.contact, Me.Column1, Me.passwd, Me.edit, Me.delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.members_datagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.members_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.members_datagrid.EnableHeadersVisualStyles = False
        Me.members_datagrid.GridColor = System.Drawing.Color.White
        Me.members_datagrid.Location = New System.Drawing.Point(42, 168)
        Me.members_datagrid.MultiSelect = False
        Me.members_datagrid.Name = "members_datagrid"
        Me.members_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.members_datagrid.RowHeadersVisible = False
        Me.members_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.members_datagrid.Size = New System.Drawing.Size(1206, 554)
        Me.members_datagrid.TabIndex = 16
        Me.members_datagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.members_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.members_datagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.members_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.members_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.members_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.members_datagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.members_datagrid.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.members_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGray
        Me.members_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.members_datagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.members_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.members_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.members_datagrid.ThemeStyle.HeaderStyle.Height = 40
        Me.members_datagrid.ThemeStyle.ReadOnly = False
        Me.members_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.members_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.members_datagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.members_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.members_datagrid.ThemeStyle.RowsStyle.Height = 22
        Me.members_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.members_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'fname
        '
        Me.fname.HeaderText = "Name"
        Me.fname.Name = "fname"
        '
        'mail
        '
        Me.mail.FillWeight = 101.7259!
        Me.mail.HeaderText = "E-mail"
        Me.mail.Name = "mail"
        '
        'contact
        '
        Me.contact.FillWeight = 101.7259!
        Me.contact.HeaderText = "Contact number"
        Me.contact.Name = "contact"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Username"
        Me.Column1.Name = "Column1"
        '
        'passwd
        '
        Me.passwd.FillWeight = 101.7259!
        Me.passwd.HeaderText = "Password"
        Me.passwd.Name = "passwd"
        Me.passwd.Visible = False
        '
        'edit
        '
        Me.edit.FillWeight = 10.0!
        Me.edit.HeaderText = ""
        Me.edit.Image = Global.Municipal_Document_Tracking_System.My.Resources.Resources.edit
        Me.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.edit.Name = "edit"
        Me.edit.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'delete
        '
        Me.delete.FillWeight = 10.0!
        Me.delete.HeaderText = ""
        Me.delete.Image = Global.Municipal_Document_Tracking_System.My.Resources.Resources.user
        Me.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.delete.Name = "delete"
        Me.delete.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 37)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Members"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 10
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Button2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(42, 32)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(233, 47)
        Me.Guna2Panel1.TabIndex = 20
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderColor = System.Drawing.Color.Gray
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Guna2Button1.FillColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(117, 47)
        Me.Guna2Button1.TabIndex = 0
        Me.Guna2Button1.Text = "Members"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.BorderRadius = 10
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Guna2Button2.FillColor = System.Drawing.SystemColors.ControlLight
        Me.Guna2Button2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(115, 0)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(118, 47)
        Me.Guna2Button2.TabIndex = 1
        Me.Guna2Button2.Text = "Admin"
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.FillWeight = 10.0!
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.Municipal_Document_Tracking_System.My.Resources.Resources.edit
        Me.DataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn1.Width = 163
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.FillWeight = 10.0!
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.Municipal_Document_Tracking_System.My.Resources.Resources.user
        Me.DataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewImageColumn2.Width = 184
        '
        'FrmMembers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 775)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.members_datagrid)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMembers"
        Me.Text = "FrmMembers"
        CType(Me.members_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents members_datagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents fname As DataGridViewTextBoxColumn
    Friend WithEvents mail As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents passwd As DataGridViewTextBoxColumn
    Friend WithEvents edit As DataGridViewImageColumn
    Friend WithEvents delete As DataGridViewImageColumn
End Class
