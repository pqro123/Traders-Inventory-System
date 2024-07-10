Imports MySql.Data.MySqlClient

Public Class InventoryForm
    Private currentUser As String

    Public Sub SetCurrentUser(username As String)
        currentUser = username
    End Sub

    Private Sub InventoryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInventory()
    End Sub

    Private Sub LoadInventory()
        If Not Connect() Then Exit Sub

        Dim query As String = "SELECT * FROM items"
        Dim cmd As New MySqlCommand(query, conn)
        Dim adapter As New MySqlDataAdapter(cmd)
        Dim table As New DataTable()
        adapter.Fill(table)
        dgvInventory.DataSource = table

        conn.Close()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If Not Connect() Then Exit Sub

        Dim name As String = txtItemName.Text
        Dim quantity As Integer = Convert.ToInt32(txtQuantity.Text)
        Dim price As Decimal = Convert.ToDecimal(txtPrice.Text)

        Dim query As String = "INSERT INTO items (name, quantity, price) VALUES (@name, @quantity, @price)"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", name)
        cmd.Parameters.AddWithValue("@quantity", quantity)
        cmd.Parameters.AddWithValue("@price", price)

        Try
            cmd.ExecuteNonQuery()
            LogAction(currentUser, $"Added item: {name}")
            MessageBox.Show("Item added successfully.")
            LoadInventory()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If Not Connect() Then Exit Sub

        Dim selectedItemID As Integer = GetSelectedItemId()
        If selectedItemID = -1 Then
            MessageBox.Show("Please select an item to update.")
            Exit Sub
        End If

        Dim newName As String = txtItemName.Text
        Dim newQuantity As Integer = Convert.ToInt32(txtQuantity.Text)
        Dim newPrice As Decimal = Convert.ToDecimal(txtPrice.Text)

        Dim query As String = "UPDATE items SET name=@name, quantity=@quantity, price=@price WHERE id=@id"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@name", newName)
        cmd.Parameters.AddWithValue("@quantity", newQuantity)
        cmd.Parameters.AddWithValue("@price", newPrice)
        cmd.Parameters.AddWithValue("@id", selectedItemID)

        Try
            cmd.ExecuteNonQuery()
            LogAction(currentUser, $"Updated item ID: {selectedItemID}")
            MessageBox.Show("Item updated successfully.")
            LoadInventory()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If Not Connect() Then Exit Sub

        Dim selectedItemID As Integer = GetSelectedItemId()
        If selectedItemID = -1 Then
            MessageBox.Show("Please select an item to delete.")
            Exit Sub
        End If

        Dim query As String = "DELETE FROM items WHERE id=@id"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@id", selectedItemID)

        Try
            cmd.ExecuteNonQuery()
            LogAction(currentUser, $"Deleted item ID: {selectedItemID}")
            MessageBox.Show("Item deleted successfully.")
            LoadInventory()
        Catch ex As MySqlException
            MessageBox.Show("Error: " & ex.Message)
        End Try

        conn.Close()
    End Sub

    Private Function GetSelectedItemId() As Integer
        If dgvInventory.SelectedRows.Count > 0 Then
            Return Convert.ToInt32(dgvInventory.SelectedRows(0).Cells("id").Value)
        End If
        Return -1
    End Function

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub LogAction(username As String, action As String)
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

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub
End Class
