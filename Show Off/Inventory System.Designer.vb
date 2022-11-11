<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inventory_System
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TimerForTime = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.txtBarcode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.cmbPaymentMode = New System.Windows.Forms.ComboBox()
        Me.txtPaymentReceived = New System.Windows.Forms.TextBox()
        Me.lblGrandTotal = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.lblNoOfItems = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblTotalTop = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserRole = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TimerForTime
        '
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(606, 39)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 44)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Show Off"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 104)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Bill No:"
        '
        'txtBillNo
        '
        Me.txtBillNo.Location = New System.Drawing.Point(59, 101)
        Me.txtBillNo.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.ReadOnly = True
        Me.txtBillNo.Size = New System.Drawing.Size(125, 20)
        Me.txtBillNo.TabIndex = 7
        '
        'txtBarcode
        '
        Me.txtBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.Location = New System.Drawing.Point(194, 143)
        Me.txtBarcode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.Size = New System.Drawing.Size(224, 21)
        Me.txtBarcode.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Barcode / Product Code"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column2, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(24, 184)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(755, 448)
        Me.DataGridView1.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Name"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 450
        '
        'Column3
        '
        Me.Column3.HeaderText = "Price"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column4
        '
        Me.Column4.HeaderText = "VAT"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = "Sub Total"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Qty"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 60
        '
        'Column6
        '
        Me.Column6.HeaderText = "Total"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 125
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(429, 143)
        Me.btnEnter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(56, 20)
        Me.btnEnter.TabIndex = 4
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'btnPay
        '
        Me.btnPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.Location = New System.Drawing.Point(982, 567)
        Me.btnPay.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(194, 65)
        Me.btnPay.TabIndex = 3
        Me.btnPay.Text = "Pay"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'lblChange
        '
        Me.lblChange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.ForeColor = System.Drawing.Color.Blue
        Me.lblChange.Location = New System.Drawing.Point(1095, 511)
        Me.lblChange.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(89, 15)
        Me.lblChange.TabIndex = 53
        Me.lblChange.Text = "0"
        Me.lblChange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(979, 511)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 17)
        Me.Label19.TabIndex = 52
        Me.Label19.Text = "Change"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbPaymentMode
        '
        Me.cmbPaymentMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbPaymentMode.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmbPaymentMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentMode.FormattingEnabled = True
        Me.cmbPaymentMode.Items.AddRange(New Object() {"CASH", "CRIDET_CARD", "BKASH", "NAGAD"})
        Me.cmbPaymentMode.Location = New System.Drawing.Point(1085, 441)
        Me.cmbPaymentMode.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbPaymentMode.Name = "cmbPaymentMode"
        Me.cmbPaymentMode.Size = New System.Drawing.Size(100, 23)
        Me.cmbPaymentMode.TabIndex = 1
        '
        'txtPaymentReceived
        '
        Me.txtPaymentReceived.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPaymentReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaymentReceived.Location = New System.Drawing.Point(1085, 474)
        Me.txtPaymentReceived.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPaymentReceived.Name = "txtPaymentReceived"
        Me.txtPaymentReceived.Size = New System.Drawing.Size(100, 21)
        Me.txtPaymentReceived.TabIndex = 2
        '
        'lblGrandTotal
        '
        Me.lblGrandTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGrandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrandTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblGrandTotal.Location = New System.Drawing.Point(1095, 406)
        Me.lblGrandTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGrandTotal.Name = "lblGrandTotal"
        Me.lblGrandTotal.Size = New System.Drawing.Size(89, 15)
        Me.lblGrandTotal.TabIndex = 49
        Me.lblGrandTotal.Text = "0.00"
        Me.lblGrandTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(1095, 380)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(89, 15)
        Me.Label16.TabIndex = 48
        Me.Label16.Text = "0.00"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Blue
        Me.lblTotal.Location = New System.Drawing.Point(1095, 352)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(89, 15)
        Me.lblTotal.TabIndex = 47
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVat
        '
        Me.lblVat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.ForeColor = System.Drawing.Color.Blue
        Me.lblVat.Location = New System.Drawing.Point(1095, 320)
        Me.lblVat.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(89, 15)
        Me.lblVat.TabIndex = 46
        Me.lblVat.Text = "0.00"
        Me.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblNoOfItems
        '
        Me.lblNoOfItems.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNoOfItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNoOfItems.ForeColor = System.Drawing.Color.Blue
        Me.lblNoOfItems.Location = New System.Drawing.Point(1095, 256)
        Me.lblNoOfItems.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNoOfItems.Name = "lblNoOfItems"
        Me.lblNoOfItems.Size = New System.Drawing.Size(89, 15)
        Me.lblNoOfItems.TabIndex = 45
        Me.lblNoOfItems.Text = "0"
        Me.lblNoOfItems.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.ForeColor = System.Drawing.Color.Blue
        Me.lblPrice.Location = New System.Drawing.Point(1095, 290)
        Me.lblPrice.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(89, 15)
        Me.lblPrice.TabIndex = 44
        Me.lblPrice.Text = "0.00"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(927, 474)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 17)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Payment Received"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(945, 442)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 17)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Payment Mode"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(956, 408)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 17)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Grand Total "
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(974, 377)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 17)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Discount"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(988, 350)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 17)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Total "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(968, 323)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Total VAT"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(964, 291)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Total Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(962, 256)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "No of items"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalTop
        '
        Me.lblTotalTop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalTop.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTop.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTotalTop.Location = New System.Drawing.Point(965, 181)
        Me.lblTotalTop.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTotalTop.Name = "lblTotalTop"
        Me.lblTotalTop.Size = New System.Drawing.Size(219, 25)
        Me.lblTotalTop.TabIndex = 35
        Me.lblTotalTop.Text = "Tk:- 0000.00"
        Me.lblTotalTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDate.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(1088, 58)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(244, 25)
        Me.lblDate.TabIndex = 34
        Me.lblDate.Text = "Nov - 4 - 2022 Friday"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTime
        '
        Me.lblTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Britannic Bold", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(1198, 31)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(138, 25)
        Me.lblTime.TabIndex = 33
        Me.lblTime.Text = "12:00:00 PM"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1341, 24)
        Me.MenuStrip1.TabIndex = 55
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(9, 31)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(45, 13)
        Me.lblUserName.TabIndex = 56
        Me.lblUserName.Text = "Label12"
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Location = New System.Drawing.Point(9, 58)
        Me.lblUserRole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(45, 13)
        Me.lblUserRole.TabIndex = 57
        Me.lblUserRole.Text = "Label13"
        '
        'Inventory_System
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1341, 735)
        Me.Controls.Add(Me.lblUserRole)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.lblChange)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.cmbPaymentMode)
        Me.Controls.Add(Me.txtPaymentReceived)
        Me.Controls.Add(Me.lblGrandTotal)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblVat)
        Me.Controls.Add(Me.lblNoOfItems)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblTotalTop)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBillNo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Inventory_System"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Inventory_System"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TimerForTime As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBillNo As TextBox
    Friend WithEvents txtBarcode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEnter As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents btnPay As Button
    Friend WithEvents lblChange As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cmbPaymentMode As ComboBox
    Friend WithEvents txtPaymentReceived As TextBox
    Friend WithEvents lblGrandTotal As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents lblNoOfItems As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblTotalTop As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserRole As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
