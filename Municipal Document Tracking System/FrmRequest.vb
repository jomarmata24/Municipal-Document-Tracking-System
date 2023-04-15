Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class FrmRequest
    Public Sub Email_report()
        Label4.Text = "municipaltrackingsystem2022@gmail.com"
        Label6.Text = "Your Request are now confirm by the admin"
        Label7.Text = "Approve Request"
        Label8.Text = "maxtiasnquztkrsu"
        Try
            Dim mail As New MailMessage
            Dim smtpserver As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(Label4.Text)
            mail.To.Add(Label3.Text)
            mail.Subject = Label7.Text
            mail.Body = Label6.Text
            smtpserver.Port = 587
            smtpserver.Credentials = New System.Net.NetworkCredential(Label4.Text, Label8.Text)
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
                Label3.Text = dr.Item("email").ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
    Public Sub empty_cells()
        If Label5.Text = "." Or Label5.Text = "" Then
            Guna2Button3.Enabled = False
        Else
            Guna2Button3.Enabled = True
        End If
    End Sub
    Public Sub check_table()
        Label5.Text = request_datagrid.CurrentRow.Cells(0).Value
        If Label5.Text = "" Then
            Guna2Button3.Enabled = False
        Else
            Guna2Button3.Enabled = True
        End If
    End Sub
    Public Sub receivedata()
        Try
            FrmReceive.receive_datagrid.Rows.Clear()
            con.Open()
            Dim sql As String = "INSERT INTO received (user_id, tracking_no, doc_type, address, purpose, sender, date) SELECT user_id, tracking_no, doc_type, address, purpose, sender, date FROM request WHERE ID = '" & request_datagrid.CurrentRow.Cells(0).Value & "'; DELETE FROM request where ID = '" & request_datagrid.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                FrmReceive.receive_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub request_loaddata()
        Try
            request_datagrid.Rows.Clear()
            con.Open()
            Dim sql As String = "SELECT * FROM request"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                request_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub FrmRequest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        empty_cells()
        request_loaddata()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        email()
        Email_report()
        receivedata()
        empty_cells()
        request_loaddata()
        FrmReceive.receive_loaddata()
        FrmNotification.Notification_data()
        MainFrm.Notification_count()

    End Sub
    Private Sub request_datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles request_datagrid.SelectionChanged
        Label1.Text = request_datagrid.CurrentRow.Cells(1).Value
        check_table()
    End Sub
    Private Sub request_datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles request_datagrid.CellContentClick
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
    End Sub
End Class