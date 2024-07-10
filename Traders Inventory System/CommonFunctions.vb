Imports MySql.Data.MySqlClient

Module CommonFunctions
    Public Sub LogAction(username As String, action As String)
        If Not Connect() Then Exit Sub

        Dim query As String = "INSERT INTO audit_log (username, action) VALUES (@username, @action)"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@action", action)

        Try
            cmd.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show("Error logging action: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' Other common functions like Connect can also be placed here
End Module
