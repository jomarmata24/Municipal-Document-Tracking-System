Public Class FrmUsers
    Private Sub FrmUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With FrmMembers
            .TopLevel = False
            Panel1.Controls.Add(FrmMembers)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)
        With FrmMembers
            .TopLevel = False
            Panel1.Controls.Add(FrmMembers)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

        With FrmAdmin
            .TopLevel = False
            Panel1.Controls.Add(FrmAdmin)
            .BringToFront()
            .Show()

        End With
    End Sub
End Class