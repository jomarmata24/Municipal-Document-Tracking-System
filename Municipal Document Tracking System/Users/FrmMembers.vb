Imports MySql.Data.MySqlClient
Public Class FrmMembers

    Public Sub delete_admin()
        Try
            con.Close()
            con.Open()
            Dim sql As String = "DELETE FROM registered WHERE ID = @id"
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@id", members_datagrid.CurrentRow.Cells(0).Value)

            Dim result As DialogResult = MessageBox.Show("Do you want to delete?", "Question", MessageBoxButtons.OKCancel)
            If result = DialogResult.OK Then
                Dim i As Integer = cmd.ExecuteNonQuery
                If i > 0 Then
                    MessageBox.Show("Deleted Succesfully", "Success")

                End If
            Else
                ' Exit the sub if the user clicked Cancel
                Exit Sub
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Sub
    Public Sub members_loaddata()
        Try
            members_datagrid.Rows.Clear()
            Dim sql As String = "SELECT * FROM registered "
            cmd = New MySqlCommand(sql, con)
            con.Open()
            dr = cmd.ExecuteReader
            While dr.Read
                members_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("name").ToString, dr.Item("email").ToString, dr.Item("contact_no").ToString, dr.Item("username").ToString, dr.Item("passwd").ToString)
            End While
            dr.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.Close()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        con.Close()

        With FrmAdmin
            .TopLevel = False
            FrmUsers.Panel1.Controls.Add(FrmAdmin)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub FrmMembers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
        members_loaddata()
    End Sub

    Private Sub members_datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles members_datagrid.CellContentClick

        If members_datagrid.Columns(e.ColumnIndex).Name = "edit" Then


            Dim formodal As New Form
            Try
                Dim modal As New Frm_Main_Update_Member
                formodal.StartPosition = FormStartPosition.Manual
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5D
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.Location = Location
                formodal.ShowInTaskbar = False
                formodal.Show()
                modal.Owner = formodal
                Frm_Main_Update_Member.ShowDialog()
            Catch ex As Exception
            Finally
                formodal.Dispose()
            End Try
        End If

        'updated form to update data


        If members_datagrid.Columns(e.ColumnIndex).Name = "delete" Then
            Dim formodal As New Form
            Try
                Dim modal As New Frm_Delete_RFID_member
                formodal.StartPosition = FormStartPosition.Manual
                formodal.FormBorderStyle = FormBorderStyle.None
                formodal.Opacity = 0.5D
                formodal.BackColor = Color.Black
                formodal.WindowState = FormWindowState.Maximized
                formodal.Location = Location
                formodal.ShowInTaskbar = False
                formodal.Show()
                modal.Owner = formodal
                Frm_Delete_RFID_member.ShowDialog()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                formodal.Dispose()
            End Try
            'insert delete function

        End If

    End Sub

    Private Sub members_datagrid_SelectionChanged(sender As Object, e As EventArgs) Handles members_datagrid.SelectionChanged
        With FrmUpdateMember
            .Guna2TextBox4.Text = members_datagrid.CurrentRow.Cells(0).Value
            .Guna2TextBox6.Text = members_datagrid.CurrentRow.Cells(1).Value
            .Guna2TextBox1.Text = members_datagrid.CurrentRow.Cells(2).Value
            .Guna2TextBox5.Text = members_datagrid.CurrentRow.Cells(3).Value
            .username_txt.Text = members_datagrid.CurrentRow.Cells(4).Value
            .Guna2TextBox2.Text = members_datagrid.CurrentRow.Cells(5).Value
        End With
    End Sub
End Class