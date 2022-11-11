Imports System.Net
Imports MySql.Data.MySqlClient
Public Class Register
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim objreader As MySqlDataReader
    Dim Mysqlconn As MySqlConnection
#End Region
    Private Sub lblCancel_Click(sender As Object, e As EventArgs) 
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtUserName.Text = "" Or txtPass.Text = "" Or cmbUserRole.Text = "" Then
            MsgBox("All textboxs are required!")
        Else
            If MsgBox("are you sure to insert?", MsgBoxStyle.YesNo, Title:="notice") = vbYes Then
                mycmd.Connection = myconnection.open
                mycmd.CommandText = "insert into tblUser (userName, password, userRole)
            values('" & txtUserName.Text & "','" & txtPass.Text & "', '" & cmbUserRole.Text & "')"
                mycmd.ExecuteNonQuery()
                myconnection.close()
                MsgBox("saved!")
            End If
        End If
    End Sub

    Private Sub CheckShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles CheckShowPass.CheckedChanged
        If txtPass.UseSystemPasswordChar = True Then
            txtPass.UseSystemPasswordChar = False
        Else
            txtPass.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class