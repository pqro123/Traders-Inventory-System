Imports MySql.Data.MySqlClient

Public Class AuditLogs
    Private conn As MySqlConnection

    ' Function to connect to the database
    Private Function Connect() As Boolean
        Dim connectionString As String = "server=localhost;user id=admin;password=adminpass;database=inventory_db"
        Try
            conn = New MySqlConnection(connectionString)
            conn.Open()
            Return True
        Catch ex As MySqlException
            MessageBox.Show("Database connection error: " & ex.Message)
            Return False
        End Try
    End Function

    Private Sub AuditLogsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAuditLogs()
    End Sub

    Private Sub LoadAuditLogs()
        If Not Connect() Then Exit Sub

        Dim query As String = "SELECT * FROM audit_log ORDER BY timestamp DESC"
        Dim cmd As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvAuditLogs.DataSource = table

        conn.Close()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        Me.Hide()
    End Sub
End Class
