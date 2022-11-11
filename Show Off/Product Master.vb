Imports ZXing
Imports MySql.Data.MySqlClient

Public Class Product_Master
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim objreader As MySqlDataReader
    'Dim Mysqlconn As MySqlConnection
    Dim conn As New MySqlConnection("server='localhost';user='root';password='';database='show off'")

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
#End Region
    Public Sub LoadDataInDatagridView()
        Dim cmd As New MySqlCommand("SELECT * FROM tblproduct ORDER BY productId DESC", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).DataPropertyName = "productId"
            DataGridView1.Columns(1).DataPropertyName = "productCode"
            DataGridView1.Columns(2).DataPropertyName = "productName"
            DataGridView1.Columns(3).DataPropertyName = "productCategory"
            DataGridView1.Columns(4).DataPropertyName = "price"
            DataGridView1.Columns(5).DataPropertyName = "tax"
            DataGridView1.Columns(6).DataPropertyName = "qty"
        End If
        myconnection.close()
    End Sub
    Private Sub txtProductCode_TextChanged(sender As Object, e As EventArgs) Handles txtProductCode.TextChanged
        Dim writer As New BarcodeWriter
        writer.Format = BarcodeFormat.CODE_128
        Try
            picBarcode.Image = writer.Write(txtProductCode.Text)
        Catch ex As Exception
            MsgBox("Enter a number")
            picBarcode.Image = Nothing
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtProductCode.Text = "" Or txtProductName.Text = "" Or cmbProductCatefory.Text = "" Or txtPrice.Text = "" Or cmbTax.Text = "" Then
            MsgBox("All textboxs are required!")
        Else
            Try
                If MsgBox("are you sure to insert?", MsgBoxStyle.YesNo, Title:="notice") = vbYes Then
                    mycmd.Connection = myconnection.open
                    mycmd.CommandText = "insert into tblProduct (productCode, productName, productCategory, price, tax, qty)
            values('" & txtProductCode.Text & "','" & txtProductName.Text & "', '" & cmbProductCatefory.Text & "', '" & txtPrice.Text & "', '" & cmbTax.Text & "', '" & txtQuantity.Text & "')"
                    mycmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("saved!")
                    Dim a As Control
                    For Each a In Me.Controls
                        If TypeOf a Is TextBox Then
                            a.Text = Nothing
                            cmbProductCatefory.Text = Nothing
                            cmbTax.Text = Nothing
                        End If
                    Next
                    txtProductCode.Select()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            LoadDataInDatagridView()
        End If
    End Sub

    '    Private Sub btnedit_click(sender As Object, e As EventArgs) Handles btnUpdate.Click
    '#Region "listview"
    '        'dim lv as listviewitem

    '        'listview.items.clear()
    '        'mycmd.connection = myconnection.open
    '        'mycmd.commandtext = "select * from tblproduct"
    '        'objreader = mycmd.executereader
    '        'while objreader.read
    '        '    lv = listview.items.add(objreader.item("productid").tostring)
    '        '    lv.subitems.add(objreader.item("productcode").tostring)
    '        '    lv.subitems.add(objreader.item("productname").tostring)
    '        '    lv.subitems.add(objreader.item("productcategory").tostring)
    '        '    lv.subitems.add(objreader.item("price").tostring)
    '        '    lv.subitems.add(objreader.item("tax").tostring)
    '        '    lv.subitems.add(objreader.item("picbarcode").tostring)

    '        'end while
    '        'myconnection.close()
    '#End Region
    '        'datagridview1.rows.add("hello", "orld")

    '        'DataGridView1.AutoGenerateColumns = False
    '        'Dim cmd As New MySqlCommand("select * from tblproduct", conn)
    '        'Dim da As New MySqlDataAdapter
    '        'da.SelectCommand = cmd
    '        'Dim dt As New DataTable
    '        'da.Fill(dt)
    '        'DataGridView1.DataSource = dt
    '    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtProductCode.Text = Nothing Then
            MsgBox("Nothing selected to delete")
        Else
            If MsgBox("Are you sure to delete?", MsgBoxStyle.YesNo, Title:="Notice") = vbYes Then
                mycmd.Connection = myconnection.open
                mycmd.CommandText = "DELETE From tblproduct Where productCode = '" & txtProductCode.Text & "'"
                objreader = mycmd.ExecuteReader
                myconnection.close()
                MsgBox("Success!")
            End If
        End If
        LoadDataInDatagridView()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Select Case* From tblproduct Where productCode Like '%3%'
        Dim cmd As New MySqlCommand("Select * From tblproduct Where productCode Like '%' '" & txtSearch.Text & "' '%'", conn)
        Dim da As New MySqlDataAdapter
        da.SelectCommand = cmd
        Dim dt As New DataTable
        da.Fill(dt)
        If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = False
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).DataPropertyName = "productId"
            DataGridView1.Columns(1).DataPropertyName = "productCode"
            DataGridView1.Columns(2).DataPropertyName = "productName"
            DataGridView1.Columns(3).DataPropertyName = "productCategory"
            DataGridView1.Columns(4).DataPropertyName = "price"
            DataGridView1.Columns(5).DataPropertyName = "tax"
            DataGridView1.Columns(6).DataPropertyName = "qty"

        End If
        myconnection.close()
    End Sub

    Private Sub Product_Master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUserName.Text = "User Name: " & Login_Interface.lblUser.Text
        lblUserRole.Text = "User Role: " & Login_Interface.lblUserRole.Text
        DataGridView1.Width = 1265
        DataGridView1.Height = 650
        Dim myHeight As Integer = My.Computer.Screen.Bounds.Size.Height
        Dim myWidth As Integer = My.Computer.Screen.Bounds.Size.Width
        Me.Size = New System.Drawing.Size(myWidth, myHeight)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtProductCode.Text = "" Or txtProductName.Text = "" Or cmbProductCatefory.Text = "" Or txtPrice.Text = "" Or cmbTax.Text = "" Then
            MsgBox("All textboxs are required!")
        Else
            Try
                If MsgBox("are you sure to Update?", MsgBoxStyle.YesNo, Title:="notice") = vbYes Then
                    mycmd.Connection = myconnection.open
                    mycmd.CommandText = "UPDATE tblproduct SET productName = '" & txtProductName.Text & "', productCategory ='" & cmbProductCatefory.Text & "', price = '" & txtPrice.Text & "', qty = '" & txtQuantity.Text & "', tax = '" & cmbTax.Text & "' WHERE productCode = '" & txtProductCode.Text & "'"
                    mycmd.ExecuteNonQuery()
                    myconnection.close()
                    MsgBox("saved!")
                    Dim a As Control
                    For Each a In Me.Controls
                        If TypeOf a Is TextBox Then
                            a.Text = Nothing
                            cmbProductCatefory.Text = Nothing
                            cmbTax.Text = Nothing
                        End If
                    Next
                    txtProductCode.Select()

                End If
            Catch ex As Exception
                MsgBox("Try Unique Product Code")
            End Try
        End If
        LoadDataInDatagridView()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Dim cell0Value As Integer = DataGridView1.CurrentRow.Cells(0).Value
        'Dim cell1Value As String = DataGridView1.CurrentRow.Cells(1).Value
        'Dim cell2Value As String = DataGridView1.CurrentRow.Cells(2).Value
        'Dim cell3Value As String = DataGridView1.CurrentRow.Cells(3).Value
        'Dim cell4Value As String = DataGridView1.CurrentRow.Cells(4).Value

        Dim i As Integer
        Dim stringCellValue As String
        For i = 1 To 6
            stringCellValue = DataGridView1.CurrentRow.Cells(i).Value
            Select Case i
                Case 1
                    Dim cell1Value As Integer = DataGridView1.CurrentRow.Cells(i).Value
                    txtProductCode.Text = cell1Value
                Case 2
                    txtProductName.Text = stringCellValue
                Case 3
                    cmbProductCatefory.Text = stringCellValue
                Case 4
                    txtPrice.Text = stringCellValue
                Case 5
                    cmbTax.Text = stringCellValue
                Case 6
                    txtQuantity.Text = stringCellValue

            End Select
        Next
        'MsgBox(DateTimePicker1.Value.Date)


        Dim mySelectedIndex = DataGridView1.CurrentRow.Index
        DataGridView1.ClearSelection()
        DataGridView1.Rows(mySelectedIndex).Selected = True

    End Sub

    Private Sub btnLoadData_Click(sender As Object, e As EventArgs) Handles btnLoadData.Click
        LoadDataInDatagridView()
    End Sub
End Class