Imports MySql.Data.MySqlClient
Imports System.IO
Public Class MainFrm
    Public Sub Notification_count()
        Try
            con.Open()
            Dim requestID As Integer
            Dim requestQuery As String = "SELECT COUNT(ID) FROM request "
            cmd = New MySqlCommand(requestQuery, con)
            requestID = CInt(cmd.ExecuteScalar())
            Label2.Text = requestID
            Label4.Text = requestID
            FrmDashboard.Label13.Text = requestID

            Dim claimID As Integer
            Dim claimquery As String = "SELECT COUNT(ID) FROM to_claim"
            cmd = New MySqlCommand(claimquery, con)
            claimID = CInt(cmd.ExecuteScalar())
            FrmDashboard.Label14.Text = claimID

            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        con.Close()
        With FrmRequest
            .TopLevel = False
            Mainpanel.Controls.Add(FrmRequest)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        con.Close()
        With FrmProcess
            .TopLevel = False
            Mainpanel.Controls.Add(FrmProcess)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        con.Close()
        With FrmReceive
            .TopLevel = False
            Mainpanel.Controls.Add(FrmReceive)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        con.Close()
        With FrmToclaim
            .TopLevel = False
            Mainpanel.Controls.Add(FrmToclaim)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Mainpanel_Paint(sender As Object, e As PaintEventArgs) Handles Mainpanel.Paint

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click

        con.Close()

        With FrmUsers
            .TopLevel = False
            Mainpanel.Controls.Add(FrmUsers)
            .BringToFront()
            .Show()

        End With
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        con.Close()
        With FrmDashboard
            .TopLevel = False
            Mainpanel.Controls.Add(FrmDashboard)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button9_Click(sender As Object, e As EventArgs) Handles Guna2Button9.Click
        con.Close()

        With FrmReport
            .TopLevel = False
            Mainpanel.Controls.Add(FrmReport)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2Button10_Click(sender As Object, e As EventArgs) Handles Guna2Button10.Click
        con.Close()

        With FrmNotification
            .TopLevel = False
            Mainpanel.Controls.Add(FrmNotification)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub Guna2ControlBox1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2CircleButton5_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to Exit Application?", "Question", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Dispose()
            FrmMainSigningForm.Dispose()
            FrmLoginForm.Dispose()
            FrmRegisterForm.Dispose()
        Else
            Exit Sub
        End If

    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.Close()
        With FrmDashboard
            .TopLevel = False
            Mainpanel.Controls.Add(FrmDashboard)
            .BringToFront()
            .Show()
        End With
        Notification_count()
    End Sub


    Public Sub Backup_database() 'Backup Database
        Try
            Dim backup As New SaveFileDialog
            backup.InitialDirectory = Path.Combine(My.Application.Info.DirectoryPath, "DATABASE BACKUP")
            backup.Title = "Backup Database"
            backup.CheckFileExists = False
            backup.CheckPathExists = False
            backup.DefaultExt = "sql"
            backup.Filter = "sql files (*.sql)|*.sql|ALL files (*.*)|*.*"
            backup.RestoreDirectory = True

            If backup.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim con As MySqlConnection = New MySqlConnection("Server= localhost ;Database=dtsdb1; username=root")
                Dim cmd As MySqlCommand = New MySqlCommand
                cmd.Connection = con
                con.Open()
                Dim mb As MySqlBackup = New MySqlBackup(cmd)
                mb.ExportToFile(backup.FileName)
                con.Close()
            ElseIf backup.ShowDialog = System.Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Guna2Button8_Click(sender As Object, e As EventArgs) Handles Guna2Button8.Click
        con.Close()
        Dim formodal1 As New Form
        Try
            Dim modal As New Frm_Main_RFID
            formodal1.StartPosition = FormStartPosition.Manual
            formodal1.FormBorderStyle = FormBorderStyle.None
            formodal1.Opacity = 0.5D
            formodal1.BackColor = Color.Black
            formodal1.WindowState = FormWindowState.Maximized
            formodal1.Location = Location
            formodal1.ShowInTaskbar = False
            formodal1.Show()
            modal.Owner = formodal1
            Frm_Main_RFID.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            formodal1.Dispose()
        End Try
    End Sub

    Private Sub Guna2CirclePictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox3.Click

    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Question", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Me.Close()
            con.Dispose()
            FrmDashboard.Close()
            FrmMainSigningForm.Show()
        Else
            Exit Sub
        End If
    End Sub
End Class
