<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRequest
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
        Me.request_datagrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.user_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tracking_code = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.document_type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.month = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.request_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 37)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Request"
        '
        'request_datagrid
        '
        Me.request_datagrid.AllowUserToDeleteRows = False
        Me.request_datagrid.AllowUserToResizeColumns = False
        Me.request_datagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.request_datagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.request_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.request_datagrid.BackgroundColor = System.Drawing.Color.White
        Me.request_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.request_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.request_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.request_datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.request_datagrid.ColumnHeadersHeight = 40
        Me.request_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.request_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.user_id, Me.Tracking_code, Me.document_type, Me.Column1, Me.purpose, Me.sender, Me.month})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.request_datagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.request_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.request_datagrid.EnableHeadersVisualStyles = False
        Me.request_datagrid.GridColor = System.Drawing.Color.White
        Me.request_datagrid.Location = New System.Drawing.Point(42, 100)
        Me.request_datagrid.MultiSelect = False
        Me.request_datagrid.Name = "request_datagrid"
        Me.request_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.request_datagrid.RowHeadersVisible = False
        Me.request_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.request_datagrid.Size = New System.Drawing.Size(1201, 616)
        Me.request_datagrid.TabIndex = 6
        Me.request_datagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.request_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.request_datagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.request_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.request_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.request_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.request_datagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.request_datagrid.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.request_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGray
        Me.request_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.request_datagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.request_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.request_datagrid.ThemeStyle.HeaderStyle.Height = 40
        Me.request_datagrid.ThemeStyle.ReadOnly = False
        Me.request_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.request_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.request_datagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.request_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.request_datagrid.ThemeStyle.RowsStyle.Height = 22
        Me.request_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.request_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        'Guna2Button3
        '
        Me.Guna2Button3.Animated = True
        Me.Guna2Button3.BorderRadius = 10
        Me.Guna2Button3.CheckedState.Parent = Me.Guna2Button3
        Me.Guna2Button3.CustomImages.Parent = Me.Guna2Button3
        Me.Guna2Button3.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Guna2Button3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button3.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button3.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button3.HoverState.Parent = Me.Guna2Button3
        Me.Guna2Button3.Location = New System.Drawing.Point(173, 40)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.ShadowDecoration.Parent = Me.Guna2Button3
        Me.Guna2Button3.Size = New System.Drawing.Size(107, 37)
        Me.Guna2Button3.TabIndex = 18
        Me.Guna2Button3.Text = "Receive"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1220, 729)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 37)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "."
        Me.Label5.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1130, 729)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 37)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "."
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1159, 729)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 37)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "."
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1101, 729)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 37)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "."
        Me.Label4.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1072, 729)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 37)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "."
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1043, 729)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 37)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "."
        Me.Label7.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(1014, 729)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 37)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "."
        Me.Label8.Visible = False
        '
        'FrmRequest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 775)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.request_datagrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmRequest"
        Me.Text = "FrmRequest"
        CType(Me.request_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents request_datagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents user_id As DataGridViewTextBoxColumn
    Friend WithEvents Tracking_code As DataGridViewTextBoxColumn
    Friend WithEvents document_type As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents purpose As DataGridViewTextBoxColumn
    Friend WithEvents sender As DataGridViewTextBoxColumn
    Friend WithEvents month As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
