﻿Imports MySql.Data.MySqlClient
Imports Guna.UI2.WinForms
Imports System.IO
Public Class Frm_UpdateAdmin_RFID

    Private direction As Integer = 1

    Public Sub Authentication()
        Try
            RFID_txtbox.Focus()
            If RFID_txtbox.Text = "" Then
                Return
            Else
                Dim sql As String = " SELECT rfid, fname FROM tbl_admin WHERE rfid = @rfid and fname = @fname"
                con.Open()
                cmd = New MySqlCommand(sql, con)
                cmd.Parameters.AddWithValue("@rfid", RFID_txtbox.Text)
                cmd.Parameters.AddWithValue("@fname", MainFrm.Label3.Text)
                dr = cmd.ExecuteReader
                If dr.Read() Then
                    MessageBox.Show("Authentication Success")
                    Dim result As DialogResult = MessageBox.Show("Authentication Success", "Success", MessageBoxButtons.OK)
                    If result = DialogResult.OK Then

                        RFID_txtbox.Clear()


                        With FrmUpdateAdmin
                            .TopLevel = False
                            Frm_Main_Update_Admin.RFID_main_update_panel.Controls.Add(FrmUpdateAdmin)
                            .BringToFront()
                            .Show()

                        End With
                    End If
                End If
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RFID_txtbox_TextChanged(sender As Object, e As EventArgs) Handles RFID_txtbox.TextChanged
        Authentication()
        RFID_txtbox.Focus()
    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        Timer1.Stop()
        Me.Close()
        con.Dispose()
        RFID_txtbox.Clear()
        Frm_Main_Update_Admin.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Guna2Separator1.Top += direction
        If Guna2Separator1.Top <= 60 Then
            direction = 1
        ElseIf Guna2Separator1.Top + Guna2Separator1.Height >= Me.ClientSize.Height - 230 Then
            direction = -1
        End If

        If Not Guna2Separator1.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            Guna2Separator1.BringToFront()
        End If
    End Sub

    Private Sub Frm_UpdateAdmin_RFID_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        RFID_txtbox.Focus()
        Guna2Separator1.Top = 0
        Me.Controls.Add(Guna2Separator1)
        Timer1.Interval = 3
        Timer1.Start()
    End Sub
End Class