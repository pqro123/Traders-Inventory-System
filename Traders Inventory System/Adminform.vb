Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient

Public Class AdminForm
    Private currentUser As String ' Store the current user for logging
    Private conn As MySqlConnection

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

    Private Sub AdminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize ComboBox
        cmbRole.Items.AddRange(New Object() {"Admin", "Staff"})
        cmbRole.SelectedIndex = 0 ' Select the first item by default
    End Sub

    Public Sub SetCurrentUser(username As String)
        currentUser = username
    End Sub

    Private Sub btnAddUser_Click(sender As Object, e As EventArgs) Handles btnAddUser.Click
        If Not Connect() Then Exit Sub

        Dim newUsername As String = txtNewUsername.Text
        Dim plainPassword As String = txtNewPassword.Text
        Dim hashedPassword As String = GetMd5Hash(plainPassword)

        ' Check if an item is selected in ComboBox
        If cmbRole.SelectedItem IsNot Nothing Then
            Dim role As String = cmbRole.SelectedItem.ToString().ToLower()

            ' Validate password complexity
            If ValidatePassword(plainPassword) Then
                Dim query As String = "INSERT INTO users (username, password, role) VALUES (@username, @password, @role)"
                Dim cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", newUsername)
                cmd.Parameters.AddWithValue("@password", hashedPassword)
                cmd.Parameters.AddWithValue("@role", role)

                Try
                    cmd.ExecuteNonQuery()
                    LogAction(currentUser, $"Added user: {newUsername} with role: {role}")
                    MessageBox.Show("User added successfully.")
                Catch ex As MySqlException
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            Else
                MessageBox.Show("Password must be at least 8 characters long, contain at least one special character, one number, one lowercase letter, and one uppercase letter.")
            End If
        Else
            MessageBox.Show("Please select a role (Admin or Staff).")
        End If

        conn.Close()
    End Sub

    Private Function ValidatePassword(password As String) As Boolean
        If password.Length < 8 Then Return False
        If Not password.Any(AddressOf Char.IsUpper) Then Return False
        If Not password.Any(AddressOf Char.IsLower) Then Return False
        If Not password.Any(AddressOf Char.IsDigit) Then Return False
        Dim specialCharacters As String = "!@#$%^&*()_-+=|\{}[]:;""'<>,.?/"
        If Not password.Any(Function(c) specialCharacters.Contains(c)) Then Return False
        Return True
    End Function

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Close() ' Close the current form (AdminForm)
        LoginForm.Show() ' Show the login form
    End Sub

    ' Function to convert a string to an MD5 hash
    Private Function GetMd5Hash(input As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim data As Byte() = md5.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim sb As New StringBuilder()
            For Each b As Byte In data
                sb.Append(b.ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function

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
End Class
