Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class FrmToclaim
    Public Sub Email_report()
        from_mail.Text = "municipaltrackingsystem2022@gmail.com"
        body_mail.Text = "Your Request Document is already claimed"
        subject_mail.Text = "Approve Release document"
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
            Dim sql As String = "SELECT email FROM registered WHERE ID = '" & Label3.Text & "'"
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
    Public Sub empty_cells()
        If Label5.Text = "." Or Label5.Text = "" Then
            Guna2Button3.Enabled = False
        Else
            Guna2Button3.Enabled = True
        End If
    End Sub
    Public Sub checker_table()
        Label5.Text = claim_datagrid.CurrentRow.Cells(0).Value

        If Label5.Text = "" Then
            Guna2Button3.Enabled = False

        Else
            Guna2Button3.Enabled = True

        End If
    End Sub
    Public Sub Completed_documents()
        Label1.Text = "Completed"
        Try
            FrmReport.history_datagrid.Rows.Clear()
            con.Open()
            Dim sql As String = " UPDATE to_claim SET status = @status WHERE ID = '" & claim_datagrid.CurrentRow.Cells(0).Value & "';  INSERT INTO history (user_id, tracking_no, doc_type, address, purpose, sender, date, status) SELECT user_id, tracking_no, doc_type, address, purpose, sender, date, status FROM to_claim WHERE ID = '" & claim_datagrid.CurrentRow.Cells(0).Value & "'; DELETE FROM to_claim where ID = '" & claim_datagrid.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@status", Label1.Text)
            dr = cmd.ExecuteReader
            While dr.Read
                FrmReport.history_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString, dr.Item("status").ToString)
            End While
            dr.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
    Public Sub To_claim_loaddata()
        Try
            claim_datagrid.Rows.Clear()
            con.Open()
            Dim sql As String = "SELECT * FROM to_claim"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                claim_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString, dr.Item("status").ToString)
            End While
            dr.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmToclaim_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empty_cells()
        To_claim_loaddata()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        email()
        Email_report()
        empty_cells()
        Completed_documents()
        FrmReport.history_loaddata()
        To_claim_loaddata()
    End Sub
    Private Sub claim_datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles claim_datagrid.SelectionChanged
        Label3.Text = claim_datagrid.CurrentRow.Cells(1).Value
        checker_table()
    End Sub
    Private Sub claim_datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles claim_datagrid.CellContentClick

    End Sub
End Class