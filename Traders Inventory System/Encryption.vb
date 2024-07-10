Imports System.Security.Cryptography
Imports System.Text

Module Encryption
    Public Function GetMd5Hash(ByVal input As String) As String
        Using md5 As MD5 = MD5.Create()
            Dim data As Byte() = md5.ComputeHash(Encoding.UTF8.GetBytes(input))
            Dim sb As New StringBuilder()
            For i As Integer = 0 To data.Length - 1
                sb.Append(data(i).ToString("x2"))
            Next
            Return sb.ToString()
        End Using
    End Function
End Module
