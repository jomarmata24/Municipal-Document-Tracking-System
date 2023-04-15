Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.IO
Public Class FrmReport
    Public Sub exportdata()
        Try
            Dim pdftable As PdfPTable = New PdfPTable(history_datagrid.ColumnCount)
            pdftable.DefaultCell.Padding = 5
            pdftable.WidthPercentage = 100
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT
            pdftable.DefaultCell.BorderWidth = 2
            For Each Column As DataGridViewColumn In history_datagrid.Columns
                Dim cell As PdfPCell = New PdfPCell(New Phrase(Column.HeaderText))
                cell.BackgroundColor = New iTextSharp.text.BaseColor(30, 144, 255)
                pdftable.AddCell(cell)
            Next
            For Each row As DataGridViewRow In history_datagrid.Rows
                For Each cell As DataGridViewCell In row.Cells
                    If cell.Value Is Nothing Then
                    Else
                        pdftable.AddCell(cell.Value.ToString)
                    End If
                Next
            Next
            Dim folderpath As String = System.IO.Path.Combine(My.Application.Info.DirectoryPath, "file")
            If IsNothing(Directory.Exists(folderpath)) Then
                Directory.CreateDirectory(folderpath)
                Dim fullPath As String = Path.Combine(folderpath)
                File.Copy(fullPath, True)
            End If
            Using Stream As FileStream = New FileStream(folderpath + "export.pdf", FileMode.Create)
                Dim document As Document = New Document(PageSize.A4)
                PdfWriter.GetInstance(document, Stream)
                document.Open()
                document.Add(pdftable)
                document.Close()
                Stream.Close()
                MessageBox.Show("successfully exported!")
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub history_loaddata()
        Try
            history_datagrid.Rows.Clear()
            connect()
            Dim sql As String = "SELECT * FROM history"
            cmd = New MySqlCommand(sql, con)
            dr = cmd.ExecuteReader
            While dr.Read
                history_datagrid.Rows.Add(dr.Item("ID").ToString, dr.Item("user_id").ToString, dr.Item("tracking_no").ToString, dr.Item("doc_type").ToString, dr.Item("address").ToString, dr.Item("purpose").ToString, dr.Item("sender").ToString, dr.Item("date").ToString, dr.Item("status").ToString, dr.Item("note").ToString)
            End While
            dr.Dispose()
            connect()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        history_loaddata()
    End Sub
    Private Sub history_datagrid_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles history_datagrid.CellContentClick
    End Sub
    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        exportdata()
    End Sub
End Class