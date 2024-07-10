Imports MySql.Data.MySqlClient

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        AttemptLogin()
        Me.Hide()
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        ' Check if Enter key is pressed
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True ' Handle the key press event
            AttemptLogin() ' Call login method
        End If
    End Sub

    Private Sub AttemptLogin()
        If Not Connect() Then Exit Sub

        Dim username As String = txtUsername.Text
        Dim password As String = GetMd5Hash(txtPassword.Text)

        Dim query As String = "SELECT * FROM users WHERE username=@username AND password=@password"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@username", username)
        cmd.Parameters.AddWithValue("@password", password)

        Dim reader As MySqlDataReader = cmd.ExecuteReader()
        If reader.HasRows Then
            reader.Read()
            Dim role As String = reader("role").ToString()
            LogAction(username, "Logged in")
            If role = "admin" Then
                Dim adminHomePage As New AdminHomePage()
                adminHomePage.SetCurrentUser(username)
                adminHomePage.Show()
                Me.Hide()
            Else
                Dim inventoryForm As New InventoryForm()
                inventoryForm.SetCurrentUser(username)
                inventoryForm.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Invalid username or password.")
        End If
        reader.Close()

        ' Clear the password textbox for security
        txtPassword.Clear()

        conn.Close()
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set PasswordChar property to '*' to obscure password input
        txtPassword.PasswordChar = "*"
    End Sub
End Class
