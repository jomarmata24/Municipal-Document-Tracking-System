Public Class Frm_Main_Update_Member
    Private Sub Frm_Main_Update_Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Frm_Update_RFID
            .TopLevel = False
            RFID_main_update_panel.Controls.Add(Frm_Update_RFID)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub RFID_main_update_panel_Paint(sender As Object, e As PaintEventArgs) Handles RFID_main_update_panel.Paint

    End Sub
End Class