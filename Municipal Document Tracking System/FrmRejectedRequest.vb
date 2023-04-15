Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class FrmRejectedRequest
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Close()
    End Sub
    Public Sub Success_mail()
        If Guna2ComboBox1.SelectedItem = "Other" Then
            FrmReceive.body_maileerror.Text = Guna2TextBox1.Text
        Else
            FrmReceive.body_maileerror.Text = Guna2ComboBox1.SelectedItem
        End If
        FrmReceive.subject_error_mail.Text = " Process Phase "
        FrmReceive.pass_mail.Text = " maxtiasnquztkrsu"
        FrmReceive.from_mail.Text = "municipaltrackingsystem2022@gmail.com"
        Try
            Dim mail As New MailMessage
            Dim smtpserver As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(FrmReceive.from_mail.Text)
            mail.To.Add(FrmReceive.receiver_mail.Text)
            mail.Subject = FrmReceive.subject_error_mail.Text
            mail.Body = FrmReceive.body_maileerror.Text

            smtpserver.Port = 587
            smtpserver.Credentials = New System.Net.NetworkCredential(FrmReceive.from_mail.Text, FrmReceive.pass_mail.Text)
            smtpserver.EnableSsl = True
            smtpserver.Send(mail)
            MsgBox("Mail has been sent successfully", MsgBoxStyle.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Sub Reject_Documents()
        FrmReceive.Label4.Text = "Rejected"
        Try
            FrmReport.history_datagrid.Rows.Clear()
            con.Open()
            Dim sql As String = " UPDATE received SET status = @status, note = @note WHERE ID = '" & FrmReceive.receive_datagrid.CurrentRow.Cells(0).Value & "'; INSERT INTO history (user_id, tracking_no, doc_type, address, purpose, sender, date, status, note) SELECT user_id, tracking_no, doc_type, address, purpose, sender, date, status, note FROM received WHERE ID = '" & FrmReceive.receive_datagrid.CurrentRow.Cells(0).Value & "'; DELETE FROM received where ID = '" & FrmReceive.receive_datagrid.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@status", FrmReceive.Label4.Text)
            If Guna2ComboBox1.SelectedItem = "Other" Then
                cmd.Parameters.AddWithValue("@note", Guna2TextBox1.Text)
            Else
                cmd.Parameters.AddWithValue("@note", Guna2ComboBox1.SelectedItem)
            End If

            dr = cmd.ExecuteReader
            While dr.Read
                FrmReport.history_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString, dr.Item("status").ToString, dr.Item("note").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub FrmRejectedRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        FrmReceive.email()
        Success_mail()
        Reject_Documents()
        FrmReceive.receive_loaddata()
        FrmReport.history_loaddata()
        Guna2TextBox1.Clear()
        Me.Close()


    End Sub
End Class