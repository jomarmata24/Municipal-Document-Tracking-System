
Public Class FrmDashboard
    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Date.Now.ToString("MMM dd yyyy     hh:mm:ss")
    End Sub
End Class