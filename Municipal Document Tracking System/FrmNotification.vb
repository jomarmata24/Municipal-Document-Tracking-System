Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class FrmNotification
    Public Sub Notification_data()
        Try
            con.Open()
            Dim sql As String = "SELECT * FROM request WHERE ID > 0 LIMIT 7"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            Dim labels(6) As Label
            labels(0) = Label4
            labels(1) = Label3
            labels(2) = Label6
            labels(3) = Label1
            labels(4) = Label7
            labels(5) = Label8
            labels(6) = Label9
            Dim panel(6) As Panel
            panel(0) = Guna2Panel1
            panel(1) = Guna2Panel2
            panel(2) = Guna2Panel3
            panel(3) = Guna2Panel4
            panel(4) = Guna2Panel5
            panel(5) = Guna2Panel8
            panel(6) = Guna2Panel7
            Dim i As Integer = 0
            While dr.Read And i < labels.Length
                labels(i).Text = dr("sender").ToString + " " + "Request a" + " " + dr("doc_type").ToString + " " + "for" + " " + dr("purpose").ToString
                i = i + 1
            End While
            If dr.Read = False And i < labels.Length And i < panel.Length Then
                For j As Integer = i To labels.Length - 1 And panel.Length - 1
                    labels(j).Hide()
                    panel(j).Hide()
                Next
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub FrmNotification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Notification_data()
    End Sub
End Class