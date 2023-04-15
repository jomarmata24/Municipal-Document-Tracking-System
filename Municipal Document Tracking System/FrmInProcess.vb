Imports MySql.Data.MySqlClient
Imports Microsoft.Office.Interop.Word
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Public Class FrmInProcess
    Public Sub claim_document()
        Try
            con.Open()
            Dim sql As String = "INSERT INTO to_claim (user_id, tracking_no, doc_type, address, purpose, sender, date) VALUES (@user_id, @tracking, @doctype, @address, @purpose, @sender, @date); SELECT * FROM processing WHERE ID = '" & FrmProcess.process_datagrid.CurrentRow.Cells(0).Value & "'; DELETE FROM processing WHERE ID = '" & FrmProcess.process_datagrid.CurrentRow.Cells(0).Value & "'  "
            cmd = New MySqlCommand(sql, con)
            cmd.Parameters.AddWithValue("@user_id", Guna2TextBox1.Text)
            cmd.Parameters.AddWithValue("@tracking", Guna2TextBox2.Text)
            cmd.Parameters.AddWithValue("@doctype", System.IO.Path.GetFileName(Guna2TextBox3.Text))
            cmd.Parameters.AddWithValue("@address", Guna2TextBox4.Text)
            cmd.Parameters.AddWithValue("@purpose", Guna2TextBox5.Text)
            cmd.Parameters.AddWithValue("@sender", Guna2TextBox6.Text)
            cmd.Parameters.AddWithValue("@date", Guna2TextBox7.Text)
            cmd.ExecuteNonQuery()
            If Guna2TextBox3.Text <> "" Then
                Dim targetPath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "file")
                If Not Directory.Exists(targetPath) Then
                    Directory.CreateDirectory(targetPath)
                End If
                Dim fileName As String = System.IO.Path.GetFileName(Guna2TextBox3.Text)
                Dim fullPath As String = Path.Combine(targetPath, fileName)
                File.Copy(Guna2TextBox3.Text, fullPath, True)
            End If
            MessageBox.Show("Successfully uploaded and saved")
            Me.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Public Sub clear()
        user_txt.Clear()
        Guna2TextBox1.Clear()
        Guna2TextBox2.Clear()
        Guna2TextBox3.Clear()
        Guna2TextBox4.Clear()
        Guna2TextBox5.Clear()
        Guna2TextBox6.Clear()
        Guna2TextBox7.Clear()

    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        clear()
        Me.Close()
    End Sub
    Private Sub FrmInProcess_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Try
            OpenFileDialog1.Filter = "PDF Files |*.pdf|Word Documents |*.docx|Excel Files |*.xlsx"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Guna2TextBox3.Text = OpenFileDialog1.FileName
                Dim fileExtension As String = System.IO.Path.GetExtension(OpenFileDialog1.FileName)
                Select Case fileExtension
                    Case ".docx"
                        Dim wordApp As New Microsoft.Office.Interop.Word.Application
                        Dim wordDoc As Microsoft.Office.Interop.Word.Document = wordApp.Documents.Open(OpenFileDialog1.FileName)
                        wordDoc.Close()
                        wordApp.Quit()
                    Case ".xlsx"
                        Dim excelApp As New Microsoft.Office.Interop.Excel.Application
                        Dim excelWorkbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Open(OpenFileDialog1.FileName)
                        excelWorkbook.Close()
                        excelApp.Quit()
                End Select
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        FrmProcess.email()
        FrmProcess.Email_report()
        claim_document()
        FrmToclaim.To_claim_loaddata()
        FrmProcess.process_loaddata()

    End Sub
End Class