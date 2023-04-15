Public Class Frm_Main_RFID
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles RFID_main_panel.Paint

    End Sub

    Private Sub Frm_Main_RFID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With FrmRFID
            .TopLevel = False
            RFID_main_panel.Controls.Add(FrmRFID)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class