Public Class FrmMainSigningForm
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        With FrmLoginForm
            .TopLevel = False
            Panel1.Controls.Add(FrmLoginForm)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class