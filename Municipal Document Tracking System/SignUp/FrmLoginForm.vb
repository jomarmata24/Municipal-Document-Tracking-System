Imports MySql.Data.MySqlClient
Public Class FrmLoginForm

    Public Sub login()
        Try
            If user_txt.Text = "" And pass_txt.Text = "" Then
                MessageBox.Show("Please fill out the blanks")
            Else
                Dim sql As String = "SELECT * FROM tbl_admin WHERE username = @username AND passwd = @passwd"
                Cnstr()
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@username", user_txt.Text)
                cmd.Parameters.AddWithValue("@passwd", pass_txt.Text)
                cmd.Parameters.AddWithValue("@fname", {FrmDashboard.Label3.Text, MainFrm.Label3.Text})
                con.Open()
                dr = cmd.ExecuteReader
                If dr.Read Then

                    FrmDashboard.Label3.Text = dr.Item("fname").ToString
                    MainFrm.Label3.Text = dr.Item("fname").ToString
                    FrmDashboard.Label10.Text = dr.Item("position").ToString
                    MainFrm.Label10.Text = dr.Item("position").ToString
                    FrmDashboard.Label11.Text = dr.Item("registry").ToString
                    MessageBox.Show("Login Succesfully!")
                    MainFrm.ShowDialog()
                    Me.Dispose()
                    user_txt.Clear()
                    pass_txt.Clear()
                Else
                    MessageBox.Show("Incorrect Username or Password, Please try again")
                    user_txt.Clear()
                    pass_txt.Clear()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        With FrmRegisterForm
            .TopLevel = False
            FrmMainSigningForm.Panel1.Controls.Add(FrmRegisterForm)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        Me.Dispose()
        FrmMainSigningForm.Dispose()
        con.Dispose()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles signin_btn.Click
        login()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Guna2CustomCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2CustomCheckBox1.CheckedChanged
        If Guna2CustomCheckBox1.Checked Then
            pass_txt.UseSystemPasswordChar = False
        Else
            pass_txt.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub FrmLoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cnstr()
    End Sub
End Class