Public Class Form1
    Private Sub btnUserAccount_Click(sender As Object, e As EventArgs) Handles btnUserAccount.Click
        Register.Show()
        Me.Close()

    End Sub

    Private Sub btnProductMaster_Click(sender As Object, e As EventArgs) Handles btnProductMaster.Click
        Product_Master.Show()
        Me.Close()

    End Sub


    ' For screen size changes. 
    Dim cw As Integer ' Forms current Width.
        Dim ch As Integer ' Forms current Height.
    Dim iw As Integer = 1280 ' Forms initial width.
    Dim ih As Integer = 760 ' Forms initial height.
    ' Retrieve the working rectangle from the Screen class using the PrimaryScreen And the WorkingArea properties.  
    Dim workingRectangle As System.Drawing.Rectangle = Screen.PrimaryScreen.WorkingArea

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        ' Login_Interface.Close()
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the size of the form slightly less than size of working rectangle. 
        'Me.Size = New System.Drawing.Size(workingRectangle.Width - 5, workingRectangle.Height - 5)
        ' Set the location so the entire form is visible. 
        'Me.Location = New System.Drawing.Point(3, 3)

        Dim myHeight As Integer = My.Computer.Screen.Bounds.Size.Height
        Dim myWidth As Integer = My.Computer.Screen.Bounds.Size.Width
        Me.Size = New System.Drawing.Size(myWidth, myHeight)

        lblUserName.Text = "User Name: " & Login_Interface.lblUser.Text
        lblUserRole.Text = "User Role: " & Login_Interface.lblUserRole.Text

        pProds = Panel_Products.BackColor
        pPrchs = Panel_Purchases.BackColor
        pRvn = Panel_Revenue.BackColor
    End Sub

    Private Sub Main_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        ' Change controls size and fonts to fit screen working area..
        Dim rw As Double = (Me.Width - cw) / cw ' Ratio change of original form Width.
        Dim rh As Double = (Me.Height - ch) / ch ' Ratio change of original form Height.
        ' Change controls size to fit users screen working area.
        'For Each Ctrl As Control In Controls
        'Ctrl.Width += CInt(Ctrl.Width * rw)
        'Ctrl.Height += CInt(Ctrl.Height * rh)
        'Ctrl.Left += CInt(Ctrl.Left * rw)
        'Ctrl.Top += CInt(Ctrl.Top * rh)
        'Next
        cw = Me.Width
        ch = Me.Height
        ' Change all the forms controls font size.
        Dim nfsize As Single
        If cw > iw + 500 Then
            For Each Ctrl As Control In Controls
                ' Get the forms controls font size's property and increase it. Reset the font to the New size. 
                nfsize = Me.Font.Size + 3
                Ctrl.Font = New Font(Ctrl.Font.Name, nfsize, FontStyle.Bold, Ctrl.Font.Unit)
            Next
        Else
            Exit Sub
        End If
    End Sub
    ' create vars to get the panels color
    Dim pProds As Color
    Dim pPrchs As Color
    Dim pRvn As Color
    Private Sub Panel_Products_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Products.MouseEnter, Label_Products.MouseEnter

        Panel_Products.BackColor = Color.Red
        Label_Products.ForeColor = pProds

    End Sub

    Private Sub Panel_Products_MouseLeave(sender As Object, e As EventArgs) Handles Panel_Products.MouseLeave, Label_Products.MouseLeave

        Panel_Products.BackColor = pProds
        Label_Products.ForeColor = Color.Red

    End Sub

    Private Sub Panel_Purchases_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Purchases.MouseEnter, Label_Purchases.MouseEnter

        Panel_Purchases.BackColor = Color.Red
        Label_Purchases.ForeColor = pPrchs

    End Sub

    Private Sub Panel_Purchases_MouseLeave(sender As Object, e As EventArgs) Handles Panel_Purchases.MouseLeave, Label_Purchases.MouseLeave

        Panel_Purchases.BackColor = pPrchs
        Label_Purchases.ForeColor = Color.Red

    End Sub

    Private Sub Panel_Revenue_MouseEnter(sender As Object, e As EventArgs) Handles Panel_Revenue.MouseEnter, Label_Revenue.MouseEnter

        Panel_Revenue.BackColor = Color.Red
        Label_Revenue.ForeColor = pRvn

    End Sub

    Private Sub Panel_Revenue_MouseLeave(sender As Object, e As EventArgs) Handles Panel_Revenue.MouseLeave, Label_Revenue.MouseLeave

        Panel_Revenue.BackColor = pRvn
        Label_Revenue.ForeColor = Color.Red

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Inventory_System.Show()
        Me.Close()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Login_Interface.Show()
        Me.Close()
    End Sub
End Class
