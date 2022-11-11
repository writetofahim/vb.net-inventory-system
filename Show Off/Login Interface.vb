Imports System.Net
Imports MySql.Data.MySqlClient
Public Class Login_Interface
    '#Region "declare"
    '    Dim myconn As MySqlConnection
    '    Dim mycmd As New MySqlCommand
    '    Dim myconnection As New DTConnection
    '    Dim objreader As MySqlDataReader
    '    Dim dtable As DataTable
    '#End Region
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim objreader As MySqlDataReader
    Dim Mysqlconn As MySqlConnection
#End Region
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Mysqlconn = myconnection.open
        Dim query As String
        query = "select userName, password, userRole from tblUser where userName = '" & txtUsername.Text & "' and password = '" & txtPass.Text & "'"
        mycmd = New MySqlCommand(query, Mysqlconn)
        objreader = mycmd.ExecuteReader
        Dim count As Integer
        Dim userRole As String = ""
        Dim user As String = ""
        count = 0
        While objreader.Read
            userRole = objreader.GetString("userRole")
            user = objreader.GetString("userName")
            count = count + 1
        End While
        If count = 1 Then
            lblUser.Text = user
            lblUserRole.Text = userRole
            If lblUserRole.Text = "ADMIN" Then
                Form1.Show()
                Me.Hide()
            Else
                Inventory_System.Show()
                Me.Hide()
            End If

        Else
            Dim msg As String = MsgBox("Username and Password are not correct" & vbNewLine & "Do you want to retry?
            ", MessageBoxButtons.YesNo)
            If msg = Windows.Forms.DialogResult.Yes Then
                myconnection.close()
                Exit Sub
            Else
                Me.Close()
            End If
        End If
        '        mycmd.Connection = myconnection.open
        '        Dim query As String
        '        query = ("")
        '        mycmd = New MySqlCommand(query, myconn)
        '        objreader = mycmd.ExecuteReader
        '        Dim count As Integer
        '        count = 0
        '        While objreader.Read
        '            count = count + 1
        '        End While
        '        If count = 1 Then
        '            Form1.Show()
        '        End If
        'objDdataAdapter = New MySqlDataAdapter("select userName, password from tblUser where userName = '" & txtUsername.Text & "' and password = '" & txtPass.Text & "'", myconnection.open)
        'dtable.Clear()
        'objDdataAdapter.Fill(dtable)
        'If dtable.Rows.Count = Nothing Then
        '    MsgBox("Wrong Username or Password!")
        'Else
        '    Form1.Show()
        '    Me.Hide()
        'End If
        myconnection.close()
        txtPass.Text = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class