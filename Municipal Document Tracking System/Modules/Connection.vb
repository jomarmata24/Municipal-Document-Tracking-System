Imports MySql.Data.MySqlClient
Module Connection
    Public con As MySqlConnection = New MySqlConnection
    Public ds As New DataSet
    Public cmd As MySqlCommand = New MySqlCommand
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public sql As String
    Public user As String
    Public da As New MySqlDataAdapter

    Public Sub connect()
        If con.State = ConnectionState.Closed Then
            con.Open()
        Else
            con.Close()
        End If
    End Sub
    ' smtp server
    'municipaltrackingsystem2022@gmail.com
    'maxtiasnquztkrsu
    Public Sub Cnstr()

        With con
            .ConnectionString = "server=fastdeal002.mysql.guardedhost.com; username = fastdeal002_municipalDTS ;password = @dmin2022; database = fastdeal002_dtsdb1"
        End With
        'Public Sub  Cnstr()
        'With con
        '.ConnectionString = "server=localhost; username = root ; database = dtsdb1"
        'End With
    End Sub
End Module
