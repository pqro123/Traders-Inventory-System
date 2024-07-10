Imports MySql.Data.MySqlClient

Module DBConnection
    Public conn As MySqlConnection
    Public Function Connect() As Boolean
        conn = New MySqlConnection("server=localhost;user id=root;password=;database=inventory_db")
        Try
            conn.Open()
            Return True
        Catch ex As MySqlException
            MessageBox.Show("Connection failed: " & ex.Message)
            Return False
        End Try
    End Function
End Module
