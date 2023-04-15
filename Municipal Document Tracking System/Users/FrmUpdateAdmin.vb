Imports MySql.Data.MySqlClient
Public Class FrmUpdateAdmin

    Public Sub Update_admin()
        Try
            con.Open()
            Dim sql As String = "UPDATE tbl_admin SET fname = @fname, username = @username, passwd = @pass, rfid = @rfid WHERE ID = '" & Guna2TextBox4.Text & "' "
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@fname", Guna2TextBox6.Text)
            cmd.Parameters.AddWithValue("@username", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@pass", Guna2TextBox2.Text)
            cmd.Parameters.AddWithValue("@rfid", Guna2TextBox5.Text)
            cmd.ExecuteNonQuery()
            Dim i As Integer = cmd.ExecuteNonQuery
            If i > 0 Then
                MessageBox.Show("Information Update Succesfully", "Success", MessageBoxButtons.OK)
                Guna2TextBox6.Clear()
                Guna2TextBox1.Clear()
                Guna2TextBox2.Clear()
                position_txt.Clear()
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        Me.Close()
        Frm_Main_Update_Admin.Close()
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Update_admin()
        FrmAdmin.user_loaddata()
        Frm_Main_Update_Admin.Close()
    End Sub

    Private Sub FrmUpdateAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class