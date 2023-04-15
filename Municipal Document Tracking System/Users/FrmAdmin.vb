Imports MySql.Data.MySqlClient
Public Class FrmAdmin

    Public Sub user_loaddata()
        Try
            admin_table.Rows.Clear()
            con.Open()
            Dim sql As String = "SELECT * FROM tbl_admin"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                admin_table.Rows.Add(dr.Item("ID").ToString, dr.Item("fname").ToString, dr.Item("username").ToString, dr.Item("passwd").ToString, dr.Item("position").ToString, dr.Item("registry").ToString, dr.Item("rfid").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Close()

        With FrmMembers
            .TopLevel = False
            FrmUsers.Panel1.Controls.Add(FrmMembers)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub FrmAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        user_loaddata()

    End Sub

    Private Sub admin_table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles admin_table.CellContentClick


        If admin_table.Columns(e.ColumnIndex).Name = "edit" Then

            Dim formodal As New Form
            Try
                Dim modal As New Frm_Main_Update_Admin
                formodal.StartPosition = FormStartPosition.Manual
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5D
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.Location = Location
                formodal.ShowInTaskbar = False
                formodal.Show()
                modal.Owner = formodal
                Frm_Main_Update_Admin.ShowDialog()
            Catch ex As Exception
            Finally
                formodal.Dispose()
            End Try
            'updated form to update data
        End If

        If admin_table.Columns(e.ColumnIndex).Name = "delete" Then
            Dim formodal As New Form
            Try
                Dim modal As New Frm_Delete_RFID_admin
                formodal.StartPosition = FormStartPosition.Manual
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5D
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.Location = Location
                formodal.ShowInTaskbar = False
                formodal.Show()
                modal.Owner = formodal
                Frm_Delete_RFID_admin.ShowDialog()

            Catch ex As Exception

            Finally
                formodal.Dispose()
            End Try

            'insert delete function

        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Dim formodal1 As New Form
        Try
            Dim modal As New Frm_Main_Add_RFID
            formodal1.StartPosition = FormStartPosition.Manual
            formodal1.FormBorderStyle = FormBorderStyle.None
            formodal1.Opacity = 0.5D
            formodal1.BackColor = Color.Black
            formodal1.WindowState = FormWindowState.Maximized
            formodal1.Location = Location
            formodal1.ShowInTaskbar = False
            formodal1.Show()
            modal.Owner = formodal1
            Frm_Main_Add_RFID.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            formodal1.Dispose()
        End Try
    End Sub

    Private Sub admin_table_SelectionChanged(sender As Object, e As EventArgs) Handles admin_table.SelectionChanged
        With FrmUpdateAdmin
            .Guna2TextBox4.Text = admin_table.CurrentRow.Cells(0).Value
            .Guna2TextBox6.Text = admin_table.CurrentRow.Cells(1).Value
            .Guna2TextBox1.Text = admin_table.CurrentRow.Cells(2).Value
            .Guna2TextBox2.Text = admin_table.CurrentRow.Cells(3).Value
            .position_txt.Text = admin_table.CurrentRow.Cells(4).Value
            .Guna2TextBox3.Text = admin_table.CurrentRow.Cells(5).Value
            .Guna2TextBox5.Text = admin_table.CurrentRow.Cells(6).Value

        End With
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        con.Close()
    End Sub
End Class