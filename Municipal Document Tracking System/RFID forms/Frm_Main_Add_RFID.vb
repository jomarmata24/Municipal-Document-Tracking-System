Public Class Frm_Main_Add_RFID
    Private Sub RFID_mainAdd_panel_Paint(sender As Object, e As PaintEventArgs) Handles RFID_mainAdd_panel.Paint

    End Sub

    Private Sub Frm_Main_Add_RFID_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With FrmAdd_RFID
            .TopLevel = False
            RFID_mainAdd_panel.Controls.Add(FrmAdd_RFID)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class