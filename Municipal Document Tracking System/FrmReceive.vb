Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class FrmReceive
    Public Sub Success_mail()
        subject_error_mail.Text = " Process Phase "
        body_maileerror.Text = FrmRejectedRequest.Guna2ComboBox1.Text
        subject_mail.Text = "In Process phase  "
        body_mail.Text = "Your Request are already in process status"
        pass_mail.Text = " maxtiasnquztkrsu"
        from_mail.Text = "municipaltrackingsystem2022@gmail.com"
        Try
            Dim mail As New MailMessage
            Dim smtpserver As New SmtpClient("smtp.gmail.com")
            mail.From = New MailAddress(from_mail.Text)
            mail.To.Add(receiver_mail.Text)
            mail.Subject = subject_mail.Text
            mail.Body = body_mail.Text

            smtpserver.Port = 587
            smtpserver.Credentials = New System.Net.NetworkCredential(from_mail.Text, pass_mail.Text)
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
            Dim sql As String = "SELECT email FROM registered WHERE ID = '" & Label6.Text & "'"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            If dr.Read Then
                receiver_mail.Text = dr.Item("email").ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
    Public Sub checker_table()
        Label5.Text = receive_datagrid.CurrentRow.Cells(0).Value
        If Label5.Text = "" Then
            Guna2Button3.Enabled = False
            Guna2Button1.Enabled = False
        Else
            Guna2Button3.Enabled = True
            Guna2Button1.Enabled = True
        End If
    End Sub
    Public Sub empty_cells()
        If Label5.Text = "." Or Label5.Text = "" Then
            Guna2Button3.Enabled = False
            Guna2Button1.Enabled = False
        Else
            Guna2Button3.Enabled = True
            Guna2Button1.Enabled = True
        End If
    End Sub
    Public Sub receive_data_to_Process()
        Label1.Text = "Completed"
        Label3.Text = "Inprogress"
        Label4.Text = "Rejected"
        Try
            FrmProcess.process_datagrid.Rows.Clear()
            con.Open()
            Dim sql As String = "UPDATE received SET status = @status, note = @note WHERE ID = '" & receive_datagrid.CurrentRow.Cells(0).Value & "' ; INSERT INTO processing (user_id, tracking_no, doc_type, address, purpose, sender, date) SELECT user_id, tracking_no, doc_type, address, purpose, sender, date FROM received WHERE ID = '" & receive_datagrid.CurrentRow.Cells(0).Value & "'; DELETE FROM received where ID = '" & receive_datagrid.CurrentRow.Cells(0).Value & "'"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@status", Label1.Text)
            cmd.Parameters.AddWithValue("@note", Label3.Text)
            dr = cmd.ExecuteReader
            While dr.Read
                FrmProcess.process_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub receive_loaddata()
        Try
            receive_datagrid.Rows.Clear()
            con.Open()
            Dim sql As String = "SELECT * FROM received"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                receive_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString, dr.Item("status").ToString, dr.Item("note").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub FrmReceive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empty_cells()
        receive_loaddata()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        email()
        Success_mail()
        empty_cells()
        receive_data_to_Process()
        FrmProcess.process_loaddata()
        receive_loaddata()
    End Sub
    Public Sub checker()
        Try
            If receive_datagrid.CurrentRow.Cells(8).Value = 0 And receive_datagrid.CurrentRow.Cells(9).Value = "" Then
                Guna2Button3.Enabled = True
            Else
                con.Open()
                Dim sql As String = "SELECT status,note FROM received WHERE status = @status AND note = @note"
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@status", receive_datagrid.CurrentRow.Cells(8).Value)
                cmd.Parameters.AddWithValue("@note", receive_datagrid.CurrentRow.Cells(9).Value)
                dr = cmd.ExecuteReader
                While dr.Read
                    Guna2Button3.Enabled = False
                End While
                dr.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub receive_datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles receive_datagrid.CellContentClick
    End Sub
    Private Sub receive_datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles receive_datagrid.SelectionChanged
        Label6.Text = receive_datagrid.CurrentRow.Cells(1).Value
        checker_table()
    End Sub
    Private Sub receive_datagrid_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles receive_datagrid.CellValueChanged

    End Sub
    Private Sub receive_datagrid_CellValueNeeded(sender As Object, e As DataGridViewCellValueEventArgs) Handles receive_datagrid.CellValueNeeded

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim formodal As New Form
        Try
            Dim modal As New FrmRejectedRequest
            formodal.StartPosition = FormStartPosition.Manual
            formodal.FormBorderStyle = FormBorderStyle.None
            formodal.Opacity = 0.5D
            formodal.BackColor = Color.Black
            formodal.WindowState = FormWindowState.Maximized
            formodal.Location = Location
            formodal.ShowInTaskbar = False
            formodal.Show()
            modal.Owner = formodal
            FrmRejectedRequest.ShowDialog()
        Catch ex As Exception

        Finally
            formodal.Dispose()
        End Try
    End Sub
End Class