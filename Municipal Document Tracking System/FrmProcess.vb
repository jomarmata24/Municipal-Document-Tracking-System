Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class FrmProcess
    Public Sub Email_report()
        from_mail.Text = "municipaltrackingsystem2022@gmail.com"
        body_mail.Text = "Your Request Document is ready to release"
        subject_mail.Text = "Approve Request document"
        password_mail.Text = "maxtiasnquztkrsu"
        Try
            Dim mail As New MailMessage
            Dim smtpserver As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(from_mail.Text)
            mail.To.Add(to_mail.Text)
            mail.Subject = subject_mail.Text
            mail.Body = body_mail.Text
            smtpserver.Port = 587
            smtpserver.Credentials = New System.Net.NetworkCredential(from_mail.Text, password_mail.Text)
            smtpserver.EnableSsl = True
            smtpserver.Send(mail)
            MsgBox("Mail has been sent successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub email()
        Try
            con.Open()
            Dim sql As String = "SELECT email FROM registered WHERE ID = '" & Label1.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                to_mail.Text = dr.Item("email").ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
    Public Sub checker()
        Label5.Text = process_datagrid.CurrentRow.Cells(0).Value
        If Label5.Text = "." Or Label5.Text = "" Then
            Guna2Button3.Enabled = False
        Else
            Guna2Button3.Enabled = True
        End If
    End Sub
    Public Sub empty_cells()
        If Label5.Text = "." Or Label5.Text = "" Then
            Guna2Button3.Enabled = False
        Else
            Guna2Button3.Enabled = True
        End If
    End Sub
    Public Sub process_loaddata()
        Try
            process_datagrid.Rows.Clear()
            con.Open()
            Dim sql As String = "SELECT * FROM processing"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                process_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString)
            End While
            dr.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empty_cells()
        process_loaddata()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        empty_cells()
        Dim formodal As New Form
        Try
            Dim modal As New FrmInProcess
            formodal.StartPosition = FormStartPosition.Manual
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            formodal.Show()
            modal.Owner = formodal
            FrmInProcess.ShowDialog()
        Catch ex As Exception
        Finally
            formodal.Dispose()
        End Try
    End Sub
    Private Sub process_datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles process_datagrid.SelectionChanged
        Label1.Text = process_datagrid.CurrentRow.Cells(1).Value
        checker()
        With FrmInProcess
            .user_txt.Text = process_datagrid.CurrentRow.Cells(0).Value
            .Guna2TextBox1.Text = process_datagrid.CurrentRow.Cells(1).Value
            .Guna2TextBox2.Text = process_datagrid.CurrentRow.Cells(2).Value
            .Guna2TextBox3.Text = process_datagrid.CurrentRow.Cells(3).Value
            .Guna2TextBox4.Text = process_datagrid.CurrentRow.Cells(4).Value
            .Guna2TextBox5.Text = process_datagrid.CurrentRow.Cells(5).Value
            .Guna2TextBox6.Text = process_datagrid.CurrentRow.Cells(6).Value
            .Guna2TextBox7.Text = process_datagrid.CurrentRow.Cells(7).Value
        End With
    End Sub
    Private Sub process_datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles process_datagrid.CellContentClick
    End Sub
End Class