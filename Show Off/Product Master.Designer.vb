<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Product_Master
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.picBarcode = New System.Windows.Forms.PictureBox()
        Me.cmbTax = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbProductCatefory = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.clmnSlNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmnProductCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnLoadData = New System.Windows.Forms.Button()
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(34, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Code"
        '
        'txtProductCode
        '
        Me.txtProductCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductCode.Location = New System.Drawing.Point(33, 67)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(230, 23)
        Me.txtProductCode.TabIndex = 0
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductName.Location = New System.Drawing.Point(33, 121)
        Me.txtProductName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(230, 23)
        Me.txtProductName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(34, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(33, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product Category"
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(33, 230)
        Me.txtPrice.Margin = New System.Windows.Forms.Padding(2)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(230, 23)
        Me.txtPrice.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(34, 211)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(34, 325)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Tax/Vat %"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(34, 388)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Barcode"
        '
        'picBarcode
        '
        Me.picBarcode.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.picBarcode.Location = New System.Drawing.Point(33, 406)
        Me.picBarcode.Margin = New System.Windows.Forms.Padding(2)
        Me.picBarcode.Name = "picBarcode"
        Me.picBarcode.Size = New System.Drawing.Size(229, 62)
        Me.picBarcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBarcode.TabIndex = 11
        Me.picBarcode.TabStop = False
        '
        'cmbTax
        '
        Me.cmbTax.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTax.FormattingEnabled = True
        Me.cmbTax.Location = New System.Drawing.Point(36, 344)
        Me.cmbTax.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbTax.Name = "cmbTax"
        Me.cmbTax.Size = New System.Drawing.Size(103, 25)
        Me.cmbTax.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Location = New System.Drawing.Point(33, 483)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(72, 40)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(112, 483)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(72, 40)
        Me.btnUpdate.TabIndex = 18
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnDelete.Location = New System.Drawing.Point(190, 483)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(72, 40)
        Me.btnDelete.TabIndex = 19
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(298, 63)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(230, 23)
        Me.txtSearch.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(297, 44)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 17)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Search"
        '
        'cmbProductCatefory
        '
        Me.cmbProductCatefory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductCatefory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProductCatefory.FormattingEnabled = True
        Me.cmbProductCatefory.Items.AddRange(New Object() {"Casula Shirt", "Formal Shirt", "T- Shirt", "Polo T- Shirt", "Panjabi", "Sherwani", "Pajama"})
        Me.cmbProductCatefory.Location = New System.Drawing.Point(34, 177)
        Me.cmbProductCatefory.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbProductCatefory.Name = "cmbProductCatefory"
        Me.cmbProductCatefory.Size = New System.Drawing.Size(197, 25)
        Me.cmbProductCatefory.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.SystemColors.Highlight
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label10.Location = New System.Drawing.Point(236, 177)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 23)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "+"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmnSlNo, Me.clmnProductCode, Me.Column5, Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4})
        Me.DataGridView1.Location = New System.Drawing.Point(298, 90)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(764, 493)
        Me.DataGridView1.TabIndex = 26
        '
        'clmnSlNo
        '
        Me.clmnSlNo.HeaderText = "ID"
        Me.clmnSlNo.MinimumWidth = 6
        Me.clmnSlNo.Name = "clmnSlNo"
        Me.clmnSlNo.Width = 90
        '
        'clmnProductCode
        '
        Me.clmnProductCode.HeaderText = "Product Code"
        Me.clmnProductCode.MinimumWidth = 6
        Me.clmnProductCode.Name = "clmnProductCode"
        Me.clmnProductCode.Width = 125
        '
        'Column5
        '
        Me.Column5.HeaderText = "Product Name"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 450
        '
        'Column1
        '
        Me.Column1.HeaderText = "Product Category"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Price"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Tax%"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'Column6
        '
        Me.Column6.HeaderText = "Qty"
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Status"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 125
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1072, 24)
        Me.MenuStrip1.TabIndex = 27
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
        Me.lblUserName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserName.Location = New System.Drawing.Point(986, 28)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(77, 19)
        Me.lblUserName.TabIndex = 28
        Me.lblUserName.Text = "Label8"
        Me.lblUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblUserRole
        '
        Me.lblUserRole.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblUserRole.Location = New System.Drawing.Point(986, 48)
        Me.lblUserRole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(77, 14)
        Me.lblUserRole.TabIndex = 29
        Me.lblUserRole.Text = "Label11"
        Me.lblUserRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(35, 288)
        Me.txtQuantity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(226, 23)
        Me.txtQuantity.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(33, 270)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Quantity"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = ""
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(148, 344)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(115, 23)
        Me.DateTimePicker1.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(150, 325)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 17)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Date"
        '
        'btnLoadData
        '
        Me.btnLoadData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLoadData.Location = New System.Drawing.Point(112, 543)
        Me.btnLoadData.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLoadData.Name = "btnLoadData"
        Me.btnLoadData.Size = New System.Drawing.Size(72, 40)
        Me.btnLoadData.TabIndex = 34
        Me.btnLoadData.Text = "Load Data"
        Me.btnLoadData.UseVisualStyleBackColor = True
        '
        'Product_Master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1072, 691)
        Me.Controls.Add(Me.btnLoadData)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblUserRole)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbProductCatefory)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cmbTax)
        Me.Controls.Add(Me.picBarcode)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Product_Master"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Product_Master"
        CType(Me.picBarcode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtProductCode As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents picBarcode As PictureBox
    Friend WithEvents cmbTax As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbProductCatefory As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserRole As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents clmnSlNo As DataGridViewTextBoxColumn
    Friend WithEvents clmnProductCode As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnLoadData As Button
End Class
