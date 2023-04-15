<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProcess
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.process_datagrid = New Guna.UI2.WinForms.Guna2DataGridView()
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
        Me.to_mail = New System.Windows.Forms.Label()
        Me.from_mail = New System.Windows.Forms.Label()
        Me.subject_mail = New System.Windows.Forms.Label()
        Me.body_mail = New System.Windows.Forms.Label()
        Me.password_mail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.process_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 37)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Process"
        '
        'process_datagrid
        '
        Me.process_datagrid.AllowUserToDeleteRows = False
        Me.process_datagrid.AllowUserToResizeColumns = False
        Me.process_datagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.process_datagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.process_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.process_datagrid.BackgroundColor = System.Drawing.Color.White
        Me.process_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.process_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.process_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.process_datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.process_datagrid.ColumnHeadersHeight = 40
        Me.process_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.process_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.user_id, Me.Tracking_code, Me.document_type, Me.Column1, Me.purpose, Me.sender, Me.month})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.process_datagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.process_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.process_datagrid.EnableHeadersVisualStyles = False
        Me.process_datagrid.GridColor = System.Drawing.Color.White
        Me.process_datagrid.Location = New System.Drawing.Point(42, 100)
        Me.process_datagrid.MultiSelect = False
        Me.process_datagrid.Name = "process_datagrid"
        Me.process_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.process_datagrid.RowHeadersVisible = False
        Me.process_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.process_datagrid.Size = New System.Drawing.Size(1201, 616)
        Me.process_datagrid.TabIndex = 8
        Me.process_datagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.process_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.process_datagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.process_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.process_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.process_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.process_datagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.process_datagrid.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.process_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGray
        Me.process_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.process_datagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.process_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.process_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.process_datagrid.ThemeStyle.HeaderStyle.Height = 40
        Me.process_datagrid.ThemeStyle.ReadOnly = False
        Me.process_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.process_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.process_datagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.process_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.process_datagrid.ThemeStyle.RowsStyle.Height = 22
        Me.process_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.process_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.Guna2Button3.TabIndex = 19
        Me.Guna2Button3.Text = "Approve"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1220, 719)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 37)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "."
        Me.Label5.Visible = False
        '
        'to_mail
        '
        Me.to_mail.AutoSize = True
        Me.to_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.to_mail.Location = New System.Drawing.Point(1191, 719)
        Me.to_mail.Name = "to_mail"
        Me.to_mail.Size = New System.Drawing.Size(23, 37)
        Me.to_mail.TabIndex = 27
        Me.to_mail.Text = "."
        Me.to_mail.Visible = False
        '
        'from_mail
        '
        Me.from_mail.AutoSize = True
        Me.from_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_mail.Location = New System.Drawing.Point(1162, 719)
        Me.from_mail.Name = "from_mail"
        Me.from_mail.Size = New System.Drawing.Size(23, 37)
        Me.from_mail.TabIndex = 28
        Me.from_mail.Text = "."
        Me.from_mail.Visible = False
        '
        'subject_mail
        '
        Me.subject_mail.AutoSize = True
        Me.subject_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject_mail.Location = New System.Drawing.Point(1133, 719)
        Me.subject_mail.Name = "subject_mail"
        Me.subject_mail.Size = New System.Drawing.Size(23, 37)
        Me.subject_mail.TabIndex = 29
        Me.subject_mail.Text = "."
        Me.subject_mail.Visible = False
        '
        'body_mail
        '
        Me.body_mail.AutoSize = True
        Me.body_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.body_mail.Location = New System.Drawing.Point(1104, 719)
        Me.body_mail.Name = "body_mail"
        Me.body_mail.Size = New System.Drawing.Size(23, 37)
        Me.body_mail.TabIndex = 30
        Me.body_mail.Text = "."
        Me.body_mail.Visible = False
        '
        'password_mail
        '
        Me.password_mail.AutoSize = True
        Me.password_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password_mail.Location = New System.Drawing.Point(1075, 719)
        Me.password_mail.Name = "password_mail"
        Me.password_mail.Size = New System.Drawing.Size(23, 37)
        Me.password_mail.TabIndex = 31
        Me.password_mail.Text = "."
        Me.password_mail.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1046, 719)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 37)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "."
        Me.Label1.Visible = False
        '
        'FrmProcess
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 775)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.password_mail)
        Me.Controls.Add(Me.body_mail)
        Me.Controls.Add(Me.subject_mail)
        Me.Controls.Add(Me.from_mail)
        Me.Controls.Add(Me.to_mail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.process_datagrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProcess"
        Me.Text = "FrmProcess"
        CType(Me.process_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents process_datagrid As Guna.UI2.WinForms.Guna2DataGridView
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
    Friend WithEvents to_mail As Label
    Friend WithEvents from_mail As Label
    Friend WithEvents subject_mail As Label
    Friend WithEvents body_mail As Label
    Friend WithEvents password_mail As Label
    Friend WithEvents Label1 As Label
End Class
