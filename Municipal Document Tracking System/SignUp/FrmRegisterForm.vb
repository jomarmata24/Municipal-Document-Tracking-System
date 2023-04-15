Imports MySql.Data.MySqlClient
Public Class FrmRegisterForm
    Public Sub insert_admin()
        Try
            con.Open()
            position_txt.Text = "Administrator"
            Guna2TextBox3.Text = Date.Now.ToString("MMM dd yyyy")
            Dim sql As String = "INSERT INTO tbl_admin (username,passwd, fname, position, registry)VALUES(@username, @passwd, @fname, @position, @registry)"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@username", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@passwd", Guna2TextBox2.Text)
            cmd.Parameters.AddWithValue("@fname", Guna2TextBox6.Text)
            cmd.Parameters.AddWithValue("@position", position_txt.Text)
            cmd.Parameters.AddWithValue("@registry", Guna2TextBox3.Text)

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
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With FrmLoginForm
            .TopLevel = False
            FrmMainSigningForm.Panel1.Controls.Add(FrmLoginForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        Me.Dispose()
    End Sub

    Private Sub FrmRegisterForm_Load(sender As Object, e As EventArgs)
        Timer1.Start()

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        insert_admin()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub FrmRegisterForm_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Cnstr()
    End Sub
End Class