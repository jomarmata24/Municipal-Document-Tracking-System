<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceive
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
        Me.receive_datagrid = New Guna.UI2.WinForms.Guna2DataGridView()
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
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.receiver_mail = New System.Windows.Forms.Label()
        Me.from_mail = New System.Windows.Forms.Label()
        Me.pass_mail = New System.Windows.Forms.Label()
        Me.body_mail = New System.Windows.Forms.Label()
        Me.subject_mail = New System.Windows.Forms.Label()
        Me.subject_error_mail = New System.Windows.Forms.Label()
        Me.body_maileerror = New System.Windows.Forms.Label()
        CType(Me.receive_datagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(35, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 37)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Received"
        '
        'receive_datagrid
        '
        Me.receive_datagrid.AllowUserToDeleteRows = False
        Me.receive_datagrid.AllowUserToResizeColumns = False
        Me.receive_datagrid.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.receive_datagrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.receive_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.receive_datagrid.BackgroundColor = System.Drawing.Color.White
        Me.receive_datagrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.receive_datagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.receive_datagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.receive_datagrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.receive_datagrid.ColumnHeadersHeight = 40
        Me.receive_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.receive_datagrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.user_id, Me.Tracking_code, Me.document_type, Me.Column1, Me.purpose, Me.sender, Me.month, Me.status, Me.note})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.receive_datagrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.receive_datagrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.receive_datagrid.EnableHeadersVisualStyles = False
        Me.receive_datagrid.GridColor = System.Drawing.Color.White
        Me.receive_datagrid.Location = New System.Drawing.Point(42, 100)
        Me.receive_datagrid.MultiSelect = False
        Me.receive_datagrid.Name = "receive_datagrid"
        Me.receive_datagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.receive_datagrid.RowHeadersVisible = False
        Me.receive_datagrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.receive_datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.receive_datagrid.Size = New System.Drawing.Size(1201, 616)
        Me.receive_datagrid.TabIndex = 10
        Me.receive_datagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.receive_datagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.receive_datagrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.receive_datagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.receive_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.receive_datagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.receive_datagrid.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.receive_datagrid.ThemeStyle.GridColor = System.Drawing.Color.White
        Me.receive_datagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.DarkGray
        Me.receive_datagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.receive_datagrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receive_datagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.receive_datagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.receive_datagrid.ThemeStyle.HeaderStyle.Height = 40
        Me.receive_datagrid.ThemeStyle.ReadOnly = False
        Me.receive_datagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.receive_datagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.receive_datagrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.receive_datagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.receive_datagrid.ThemeStyle.RowsStyle.Height = 22
        Me.receive_datagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.receive_datagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
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
        Me.status.Visible = False
        '
        'note
        '
        Me.note.HeaderText = "Note"
        Me.note.Name = "note"
        Me.note.Visible = False
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
        Me.Guna2Button3.TabIndex = 20
        Me.Guna2Button3.Text = "Approve"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Black
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(300, 40)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(107, 37)
        Me.Guna2Button1.TabIndex = 21
        Me.Guna2Button1.Text = "Reject"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1160, 729)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "."
        Me.Label1.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1189, 729)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 37)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "."
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1220, 729)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 37)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "."
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1131, 729)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 37)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "."
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1102, 729)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 37)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "."
        Me.Label6.Visible = False
        '
        'receiver_mail
        '
        Me.receiver_mail.AutoSize = True
        Me.receiver_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.receiver_mail.Location = New System.Drawing.Point(1071, 729)
        Me.receiver_mail.Name = "receiver_mail"
        Me.receiver_mail.Size = New System.Drawing.Size(23, 37)
        Me.receiver_mail.TabIndex = 27
        Me.receiver_mail.Text = "."
        Me.receiver_mail.Visible = False
        '
        'from_mail
        '
        Me.from_mail.AutoSize = True
        Me.from_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.from_mail.Location = New System.Drawing.Point(1042, 729)
        Me.from_mail.Name = "from_mail"
        Me.from_mail.Size = New System.Drawing.Size(23, 37)
        Me.from_mail.TabIndex = 28
        Me.from_mail.Text = "."
        Me.from_mail.Visible = False
        '
        'pass_mail
        '
        Me.pass_mail.AutoSize = True
        Me.pass_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_mail.Location = New System.Drawing.Point(1013, 729)
        Me.pass_mail.Name = "pass_mail"
        Me.pass_mail.Size = New System.Drawing.Size(23, 37)
        Me.pass_mail.TabIndex = 29
        Me.pass_mail.Text = "."
        Me.pass_mail.Visible = False
        '
        'body_mail
        '
        Me.body_mail.AutoSize = True
        Me.body_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.body_mail.Location = New System.Drawing.Point(984, 729)
        Me.body_mail.Name = "body_mail"
        Me.body_mail.Size = New System.Drawing.Size(23, 37)
        Me.body_mail.TabIndex = 30
        Me.body_mail.Text = "."
        Me.body_mail.Visible = False
        '
        'subject_mail
        '
        Me.subject_mail.AutoSize = True
        Me.subject_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject_mail.Location = New System.Drawing.Point(955, 729)
        Me.subject_mail.Name = "subject_mail"
        Me.subject_mail.Size = New System.Drawing.Size(23, 37)
        Me.subject_mail.TabIndex = 31
        Me.subject_mail.Text = "."
        Me.subject_mail.Visible = False
        '
        'subject_error_mail
        '
        Me.subject_error_mail.AutoSize = True
        Me.subject_error_mail.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subject_error_mail.Location = New System.Drawing.Point(926, 729)
        Me.subject_error_mail.Name = "subject_error_mail"
        Me.subject_error_mail.Size = New System.Drawing.Size(23, 37)
        Me.subject_error_mail.TabIndex = 32
        Me.subject_error_mail.Text = "."
        Me.subject_error_mail.Visible = False
        '
        'body_maileerror
        '
        Me.body_maileerror.AutoSize = True
        Me.body_maileerror.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.body_maileerror.Location = New System.Drawing.Point(866, 729)
        Me.body_maileerror.Name = "body_maileerror"
        Me.body_maileerror.Size = New System.Drawing.Size(23, 37)
        Me.body_maileerror.TabIndex = 33
        Me.body_maileerror.Text = "."
        Me.body_maileerror.Visible = False
        '
        'FrmReceive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 775)
        Me.Controls.Add(Me.body_maileerror)
        Me.Controls.Add(Me.subject_error_mail)
        Me.Controls.Add(Me.subject_mail)
        Me.Controls.Add(Me.body_mail)
        Me.Controls.Add(Me.pass_mail)
        Me.Controls.Add(Me.from_mail)
        Me.Controls.Add(Me.receiver_mail)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.receive_datagrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmReceive"
        Me.Text = "FrmReceive"
        CType(Me.receive_datagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents receive_datagrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
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
    Friend WithEvents receiver_mail As Label
    Friend WithEvents from_mail As Label
    Friend WithEvents pass_mail As Label
    Friend WithEvents body_mail As Label
    Friend WithEvents subject_mail As Label
    Friend WithEvents subject_error_mail As Label
    Friend WithEvents body_maileerror As Label
End Class
