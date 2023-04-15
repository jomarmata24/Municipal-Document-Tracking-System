Imports MySql.Data.MySqlClient
Public Class FrmAddAdmin

    Public Sub add_administrator()
        Try
            con.Open()
            position_txt.Text = "Administrator"
            Guna2TextBox4.Text = "0123456789"

            Guna2TextBox3.Text = Date.Now.ToString("MMM dd yyyy")
            Dim sql As String = "INSERT INTO tbl_admin (username,passwd, fname, position, registry, rfid)VALUES(@username, @passwd, @fname, @position, @registry, @rfid)"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@username", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@passwd", Guna2TextBox2.Text)
            cmd.Parameters.AddWithValue("@fname", Guna2TextBox6.Text)
            cmd.Parameters.AddWithValue("@position", position_txt.Text)
            cmd.Parameters.AddWithValue("@registry", Guna2TextBox3.Text)
            cmd.Parameters.AddWithValue("@rfid", Guna2TextBox4.Text)
            Dim i As Integer = cmd.ExecuteNonQuery

            If i > 0 Then
                MessageBox.Show("New user added Succesfully!")
                Me.Close()

            Else
                MessageBox.Show("New user added failed!")

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        con.Close()
    End Sub
    Private Sub FrmAddAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        add_administrator()
        FrmAdmin.user_loaddata()
        Me.Close()
        Frm_Main_Add_RFID.Close()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Dispose()
        Me.Close()
        Frm_Main_Add_RFID.Close()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class