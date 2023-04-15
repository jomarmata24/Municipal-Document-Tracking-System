<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReport
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.history_datagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tracking_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.document_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Button4 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.history_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 37)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "History"
        '
        'history_datagrid
        '
        Me.history_datagrid.AllowUserToDeleteRows = False
        Me.history_datagrid.AllowUserToResizeColumns = False
        Me.history_datagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.history_datagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.history_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.history_datagrid.BackgroundColor = System.Drawing.Color.White
        Me.history_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.history_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.history_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.history_datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.history_datagrid.ColumnHeadersHeight = 40
        Me.history_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.history_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.user_id, Me.Tracking_code, Me.document_type, Me.Column1, Me.purpose, Me.sender, Me.month, Me.status, Me.note})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.history_datagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.history_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.history_datagrid.EnableHeadersVisualStyles = False
        Me.history_datagrid.GridColor = System.Drawing.Color.White
        Me.history_datagrid.Location = New System.Drawing.Point(42, 100)
        Me.history_datagrid.MultiSelect = False
        Me.history_datagrid.Name = "history_datagrid"
        Me.history_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.history_datagrid.RowHeadersVisible = False
        Me.history_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.history_datagrid.Size = New System.Drawing.Size(1201, 616)
        Me.history_datagrid.TabIndex = 12
        Me.history_datagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.history_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.history_datagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.history_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.history_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.history_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.history_datagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.history_datagrid.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.history_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGray
        Me.history_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.history_datagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.history_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.history_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.history_datagrid.ThemeStyle.HeaderStyle.Height = 40
        Me.history_datagrid.ThemeStyle.ReadOnly = False
        Me.history_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.history_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.history_datagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.history_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.history_datagrid.ThemeStyle.RowsStyle.Height = 22
        Me.history_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.history_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'user_id
        '
        Me.user_id.HeaderText = "User ID"
        Me.user_id.Name = "user_id"
        Me.user_id.Visible = False
        '
        'Tracking_code
        '
        Me.Tracking_code.HeaderText = "Tracking Code"
        Me.Tracking_code.Name = "Tracking_code"
        '
        'document_type
        '
        Me.document_type.HeaderText = "Document Type"
        Me.document_type.Name = "document_type"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Address"
        Me.Column1.Name = "Column1"
        '
        'purpose
        '
        Me.purpose.HeaderText = "Purpose"
        Me.purpose.Name = "purpose"
        '
        'sender
        '
        Me.sender.HeaderText = "Sender"
        Me.sender.Name = "sender"
        '
        'month
        '
        Me.month.HeaderText = "Date"
        Me.month.Name = "month"
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        '
        'note
        '
        Me.note.HeaderText = "Note"
        Me.note.Name = "note"
        '
        'Guna2Button4
        '
        Me.Guna2Button4.Animated = True
        Me.Guna2Button4.BorderRadius = 10
        Me.Guna2Button4.CheckedState.Parent = Me.Guna2Button4
        Me.Guna2Button4.CustomImages.Parent = Me.Guna2Button4
        Me.Guna2Button4.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2Button4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button4.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button4.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button4.HoverState.Parent = Me.Guna2Button4
        Me.Guna2Button4.Location = New System.Drawing.Point(151, 40)
        Me.Guna2Button4.Name = "Guna2Button4"
        Me.Guna2Button4.ShadowDecoration.Parent = Me.Guna2Button4
        Me.Guna2Button4.Size = New System.Drawing.Size(140, 37)
        Me.Guna2Button4.TabIndex = 14
        Me.Guna2Button4.Text = "Export History"
        '
        'FrmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 775)
        Me.Controls.Add(Me.Guna2Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.history_datagrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReport"
        Me.Text = "FrmReport"
        CType(Me.history_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents history_datagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button4 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents user_id As DataGridViewTextBoxColumn
    Friend WithEvents Tracking_code As DataGridViewTextBoxColumn
    Friend WithEvents document_type As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents purpose As DataGridViewTextBoxColumn
    Friend WithEvents sender As DataGridViewTextBoxColumn
    Friend WithEvents month As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents note As DataGridViewTextBoxColumn
End Class
