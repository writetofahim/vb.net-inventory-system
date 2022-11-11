Imports System.Net
Imports MySql.Data.MySqlClient
Public Class DTConnection
    'port='3306'
    'Dim conect As New MySqlConnection("server='sql207.epizy.com';port='3306'; user='epiz_32974302'; password='8BGAyQMucq14yTI'; database='epiz_32974302_showOf' ")
    Dim conect As New MySqlConnection("server='localhost';user='root';password='';database='show off'")
    Public Function open() As MySqlConnection
        Try
            conect.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conect
    End Function

    Public Function close() As MySqlConnection
        Try
            conect.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return conect
    End Function
End Class