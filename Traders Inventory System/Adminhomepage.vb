Public Class AdminHomePage
    Private currentUser As String

    Public Sub SetCurrentUser(username As String)
        currentUser = username
    End Sub

    Private Sub btnRegisterUser_Click(sender As Object, e As EventArgs) Handles btnRegisterUser.Click
        Dim registerForm As New AdminForm()
        registerForm.SetCurrentUser(currentUser)
        registerForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Dim inventoryForm As New InventoryForm()
        inventoryForm.SetCurrentUser(currentUser)
        inventoryForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnAuditlogs_Click(sender As Object, e As EventArgs) Handles btnAuditlogs.Click
        Dim auditLogsForm As New AuditLogs()
        auditLogsForm.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub
End Class
