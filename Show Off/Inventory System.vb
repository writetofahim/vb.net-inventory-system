Imports MySql.Data.MySqlClient
Imports System.Drawing.Printing
Public Class Inventory_System
#Region "declare"
    Dim mycmd As New MySqlCommand
    Dim myconnection As New DTConnection
    Dim objreader As MySqlDataReader
    'Dim Mysqlconn As MySqlConnection
    Dim conn As New MySqlConnection("server='localhost';user='root';password='';database='show off'")
#End Region

    ' For screen size changes. 
    'Dim cw As Integer ' Forms current Width.
    'Dim ch As Integer ' Forms current Height.
    'Dim iw As Integer = 1280 ' Forms initial width.
    'Dim ih As Integer = 760 ' Forms initial height.
    ' Retrieve the working rectangle from the Screen class using the PrimaryScreen And the WorkingArea properties.  
    Dim workingRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea
    Private Sub Inventory_System_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerForTime.Enabled = True
        lblDate.Text = Date.Now.ToString("MMM - dd - yyyy dddd")
        lblUserName.Text = "User Name: " & Login_Interface.lblUser.Text
        lblUserRole.Text = "User Role: " & Login_Interface.lblUserRole.Text
        DataGridView1.Width = 980
        DataGridView1.Height = 550
        ' Set the size of the form slightly less than size of working rectangle. 
        Dim myHeight As Integer = My.Computer.Screen.Bounds.Size.Height
        Dim myWidth As Integer = My.Computer.Screen.Bounds.Size.Width
        Me.Size = New System.Drawing.Size(myWidth, myHeight)
        ' Set the location so the entire form is visible. 
        'Me.Location = New System.Drawing.Point(3, 3)
        'Dim myHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        'Dim myWidth As Integer = Screen.PrimaryScreen.Bounds.Width

        ' MsgBox("Height: " & myHeight & " Width: " & myWidth)
    End Sub
    'Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    ' Change controls size and fonts to fit screen working area..
    'Dim rw As Double = (Me.Width - cw) / cw ' Ratio change of original form Width.
    'Dim rh As Double = (Me.Height - ch) / ch ' Ratio change of original form Height.
    ' Change controls size to fit users screen working area.
    'For Each Ctrl As Control In Controls
    '    Ctrl.Width += CInt(Ctrl.Width * rw)
    '    Ctrl.Height += CInt(Ctrl.Height * rh)
    '    Ctrl.Left += CInt(Ctrl.Left * rw)
    '    Ctrl.Top += CInt(Ctrl.Top * rh)
    'Next
    'cw = Me.Width
    ' ch = Me.Height
    ' Change all the forms controls font size.
    '  Dim nfsize As Single
    '   If cw > iw + 400 Then
    '        For Each Ctrl As Control In Controls
    ' Get the forms controls font size's property and increase it. Reset the font to the New size. 
    'nfsize = Me.Font.Size + 1
    ''       Ctrl.Font = New Font(Ctrl.Font.Name, nfsize, Ctrl.Font.Unit)
    '    Next
    ' Else
    '      Exit Sub
    '   End If
    'End Sub
    Private Sub TimerForTime_Tick(sender As Object, e As EventArgs) Handles TimerForTime.Tick
        lblTime.Text = Date.Now.ToString("hh:mm:ss tt")
    End Sub

    Private Sub txtBarcode_TextChanged(sender As Object, e As EventArgs) Handles txtBarcode.TextChanged
        'Dim cmd As New MySqlCommand("Select * From tblproduct Where productCode = '" & txtBarcode.Text & "' ", conn)
#Region "May delete"
        'Dim da As New MySqlDataAdapter
        'da.SelectCommand = cmd
        'Dim dt As New DataTable
        'da.Fill(dt)
        'Dim c As Integer
        'c = dt.Rows.Count
        'If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
        '    DataGridView1.Rows.Add("Product Name", "120", c)
        'DataGridView1.AutoGenerateColumns = False
        'DataGridView1.DataSource = dt
        'DataGridView1.Columns(0).DataPropertyName = "productname"
        'DataGridView1.Columns(1).DataPropertyName = "price"
        'DataGridView1.Columns(2).DataPropertyName = "tax"
        'End If
        'myconnection.close()
#End Region
        'mycmd.Connection = myconnection.open
        'mycmd.CommandText = "Select * From tblproduct Where productCode = '" & txtBarcode.Text & "'"
        'objreader = mycmd.ExecuteReader
        'While objreader.Read
        '    Dim productName As String = objreader.GetString("productName")
        '    DataGridView1.Rows.Add(productName, "Hello BD")
        'End While
        'myconnection.close()
    End Sub
    Dim vatOf As Double = 0
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        mycmd.Connection = myconnection.open
        mycmd.CommandText = "Select * From tblproduct Where productCode = '" & txtBarcode.Text & "'"
        objreader = mycmd.ExecuteReader

        While objreader.Read
            Dim productCode As String = objreader.GetString("productCode")
            Dim productName As String = objreader.GetString("productName")
            Dim price As Double = objreader.GetString("price")
            Dim vat As Integer = objreader.GetString("tax")
            vatOf = (price * vat) / 100
            Dim subTotal As Double = price + vatOf
            Dim qty As Integer = 1
            Dim total As Double = subTotal * qty

            DataGridView1.Rows.Add(productName, price, vat, subTotal, qty, total)
        End While
        myconnection.close()
        lblNoOfItems.Text = DataGridView1.Rows.Count
        Dim subTotal1 As Double
        Dim total1 As Double
        Dim grandTotal As Double
        'Dim vat1 As Double
        For i = 0 To DataGridView1.Rows.Count - 1
            subTotal1 += DataGridView1.Rows(i).Cells(1).Value
            total1 += DataGridView1.Rows(i).Cells(3).Value
            grandTotal += DataGridView1.Rows(i).Cells(5).Value
        Next
        lblPrice.Text = subTotal1
        lblVat.Text += vatOf
        lblTotal.Text = total1
        lblGrandTotal.Text = grandTotal
        lblTotalTop.Text = "Tk:- " & grandTotal
        txtBarcode.Text = Nothing
    End Sub

    Private Sub txtBarcode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBarcode.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnEnter_Click(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True 'It does make any sound
    End Sub

    Private Sub txtPaymentReceived_TextChanged(sender As Object, e As EventArgs)

        lblChange.Text = txtPaymentReceived.Text - lblGrandTotal.Text
    End Sub
    Dim WithEvents PD As New PrintDocument
    Dim PPD As New PrintPreviewDialog
    Dim longpaper As Integer
    Sub changelongpaper()
        Dim rowcount As Integer
        longpaper = 0
        rowcount = DataGridView1.Rows.Count
        longpaper = rowcount * 15
        longpaper = longpaper + 500
    End Sub
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        changelongpaper()
        PPD.Document = PD
        PPD.ShowDialog()

#Region "may delete"
        'PrintDialog1.Document = PrintDocument1
        'PrintDialog1.PrinterSettings = PrintDocument1.PrinterSettings
        'PrintDialog1.AllowSomePages = True

        'If PrintDialog1.ShowDialog = DialogResult.OK Then
        '    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        '    PrintDocument1.Print()
        'End If


        'Dim numbers As String = "1234567890"

        'Dim characters As String = numbers
        'Dim length As Integer = 10
        'Dim id As String = String.Empty
        'For i As Integer = 0 To length - 1
        '    Dim character As String = String.Empty
        '    Do
        '        Dim index As Integer = New Random().Next(0, characters.Length)
        '        character = characters.ToCharArray()(Index).ToString()
        '    Loop While id.IndexOf(character) <> -1
        '    id += character
        'Next
        'txtBillNo.Text = "FF" + id

        'Dim id_tmp As String
        'Query = "select top 1 InoviceNo from Invoice order by InoviceNo desc"
        'cmd = New OleDbCommand(query, cn)
        'dr = cmd.ExecuteReader
        'If dr.HasRows = False Then
        '    dr.Close()
        '    id_tmp = "E000001"
        'Else
        '    dr.Read()
        '    id_tmp = Format(Mid(dr("InoviceNo"), 2, 6) + 1, "E00000#")
        'End If
        'dr.Close()
        'txtInvoice.Text = id_tmp
#End Region

    End Sub
    Private Sub PD_BeginPrint(sender As Object, e As PrintEventArgs) Handles PD.BeginPrint
        Dim pagesetup As New PageSettings
        pagesetup.PaperSize = New PaperSize("Custom", 250, longpaper)
        PD.DefaultPageSettings = pagesetup
    End Sub
    Private Sub PD_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PD.PrintPage
        Dim f8 As New Font("Calibri", 8, FontStyle.Regular)
        Dim f8b As New Font("Calibri", 8, FontStyle.Bold)
        Dim f10 As New Font("Calibri", 10, FontStyle.Regular)
        Dim f10b As New Font("Calibri", 10, FontStyle.Bold)
        Dim f14b As New Font("Calibri", 14, FontStyle.Bold)
        Dim leftmargin As Integer = PD.DefaultPageSettings.Margins.Left
        Dim centermargin As Integer = PD.DefaultPageSettings.PaperSize.Width / 2
        Dim rightmargin As Integer = PD.DefaultPageSettings.PaperSize.Width

        Dim right As New StringFormat
        Dim center As New StringFormat
        right.Alignment = StringAlignment.Far
        center.Alignment = StringAlignment.Center
        Dim line As String
        line = "-------------------------------------------------------------------------"

        e.Graphics.DrawString("Show Off”, f14b, Brushes.Black, centermargin, 5, center)
        e.Graphics.DrawString("A line for Show Off", f10, Brushes.Black, centermargin, 25, center)
        e.Graphics.DrawString("Tel: +880171111111", f10, Brushes.Black, centermargin, 40, center)
        e.Graphics.DrawString("Address: Dhaka, Bangladesh", f10, Brushes.Black, centermargin, 55, center)

        e.Graphics.DrawString("Invoice #", f8, Brushes.Black, 0, 80)
        e.Graphics.DrawString("Date: " & lblDate.Text, f8, Brushes.Black, rightmargin, 80, right)

        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 90)
        e.Graphics.DrawString("Product Name", f8b, Brushes.Black, 0, 100)
        e.Graphics.DrawString("Price", f8b, Brushes.Black, 105, 100)
        e.Graphics.DrawString("Vat", f8b, Brushes.Black, 140, 100)
        e.Graphics.DrawString("S.Total", f8b, Brushes.Black, 160, 100)
        e.Graphics.DrawString("Qty", f8b, Brushes.Black, 200, 100)
        e.Graphics.DrawString("Total", f8b, Brushes.Black, rightmargin, 100, right)



        Dim height As Integer
        'Dim i As Long

        DataGridView1.AllowUserToAddRows = False

        For row As Integer = 0 To DataGridView1.RowCount - 1
            height += 15
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(0).Value.ToString, f8, Brushes.Black, 0, 105 + height)
            'i = DataGridView1.Rows(row).Cells(1).Value
            'DataGridView1.Rows(row).Cells(1).Value = Format(i, "##,###")
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(1).Value.ToString, f8, Brushes.Black, 105, 105 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(2).Value.ToString & "%", f8, Brushes.Black, 140, 105 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(3).Value.ToString, f8, Brushes.Black, 160, 105 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(4).Value.ToString, f8, Brushes.Black, 200, 105 + height)
            e.Graphics.DrawString(DataGridView1.Rows(row).Cells(5).Value.ToString, f8, Brushes.Black, rightmargin, 105 + height, right)
        Next
        e.Graphics.DrawString(line, f8, Brushes.Black, 0, 115 + height)
        e.Graphics.DrawString("Thanks for Shopping with US!", f8, Brushes.Black, centermargin, 145 + height, center)

    End Sub

    Private Sub btnPay_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        If lblUserRole.Text = "User Role: ADMIN" Then
            Form1.Show()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub

    Private Sub txtPaymentReceived_TextChanged_1(sender As Object, e As EventArgs) Handles txtPaymentReceived.TextChanged
        lblChange.Text = CDbl(Val(txtPaymentReceived.Text)) - lblTotal.Text
    End Sub
End Class