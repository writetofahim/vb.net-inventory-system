<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnProductMaster = New System.Windows.Forms.Button()
        Me.btnUserAccount = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel_Products = New System.Windows.Forms.Panel()
        Me.lblTodaySales = New System.Windows.Forms.Label()
        Me.Label_Products = New System.Windows.Forms.Label()
        Me.Panel_Purchases = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label_Purchases = New System.Windows.Forms.Label()
        Me.Panel_Revenue = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_Revenue = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel_Products.SuspendLayout()
        Me.Panel_Purchases.SuspendLayout()
        Me.Panel_Revenue.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnProductMaster
        '
        Me.btnProductMaster.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnProductMaster.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnProductMaster.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProductMaster.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnProductMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductMaster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnProductMaster.Location = New System.Drawing.Point(773, 40)
        Me.btnProductMaster.Name = "btnProductMaster"
        Me.btnProductMaster.Size = New System.Drawing.Size(126, 67)
        Me.btnProductMaster.TabIndex = 4
        Me.btnProductMaster.Text = "Product Master"
        Me.btnProductMaster.UseVisualStyleBackColor = False
        '
        'btnUserAccount
        '
        Me.btnUserAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUserAccount.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUserAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUserAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUserAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserAccount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUserAccount.Location = New System.Drawing.Point(905, 40)
        Me.btnUserAccount.Name = "btnUserAccount"
        Me.btnUserAccount.Size = New System.Drawing.Size(126, 67)
        Me.btnUserAccount.TabIndex = 3
        Me.btnUserAccount.Text = "User Account"
        Me.btnUserAccount.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(1037, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(126, 67)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Report"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'btnLogout
        '
        Me.btnLogout.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLogout.Location = New System.Drawing.Point(1169, 40)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(126, 67)
        Me.btnLogout.TabIndex = 1
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'Panel_Products
        '
        Me.Panel_Products.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Products.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Products.Controls.Add(Me.lblTodaySales)
        Me.Panel_Products.Controls.Add(Me.Label_Products)
        Me.Panel_Products.Location = New System.Drawing.Point(224, 268)
        Me.Panel_Products.Name = "Panel_Products"
        Me.Panel_Products.Size = New System.Drawing.Size(259, 128)
        Me.Panel_Products.TabIndex = 0
        '
        'lblTodaySales
        '
        Me.lblTodaySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTodaySales.ForeColor = System.Drawing.Color.White
        Me.lblTodaySales.Location = New System.Drawing.Point(54, 59)
        Me.lblTodaySales.Name = "lblTodaySales"
        Me.lblTodaySales.Size = New System.Drawing.Size(148, 39)
        Me.lblTodaySales.TabIndex = 0
        Me.lblTodaySales.Text = "Label4"
        Me.lblTodaySales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Products
        '
        Me.Label_Products.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_Products.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Products.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_Products.Location = New System.Drawing.Point(-3, 0)
        Me.Label_Products.Name = "Label_Products"
        Me.Label_Products.Size = New System.Drawing.Size(262, 36)
        Me.Label_Products.TabIndex = 0
        Me.Label_Products.Text = "Today Sales"
        Me.Label_Products.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Purchases
        '
        Me.Panel_Purchases.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Purchases.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Purchases.Controls.Add(Me.Label4)
        Me.Panel_Purchases.Controls.Add(Me.Label_Purchases)
        Me.Panel_Purchases.Location = New System.Drawing.Point(532, 268)
        Me.Panel_Purchases.Name = "Panel_Purchases"
        Me.Panel_Purchases.Size = New System.Drawing.Size(259, 128)
        Me.Panel_Purchases.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(61, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 39)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Purchases
        '
        Me.Label_Purchases.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_Purchases.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Purchases.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_Purchases.Location = New System.Drawing.Point(-3, 0)
        Me.Label_Purchases.Name = "Label_Purchases"
        Me.Label_Purchases.Size = New System.Drawing.Size(262, 36)
        Me.Label_Purchases.TabIndex = 0
        Me.Label_Purchases.Text = "Monthly Sales"
        Me.Label_Purchases.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel_Revenue
        '
        Me.Panel_Revenue.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel_Revenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel_Revenue.Controls.Add(Me.Label5)
        Me.Panel_Revenue.Controls.Add(Me.Label_Revenue)
        Me.Panel_Revenue.Location = New System.Drawing.Point(836, 268)
        Me.Panel_Revenue.Name = "Panel_Revenue"
        Me.Panel_Revenue.Size = New System.Drawing.Size(259, 128)
        Me.Panel_Revenue.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(64, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 39)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Label4"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_Revenue
        '
        Me.Label_Revenue.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label_Revenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Revenue.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label_Revenue.Location = New System.Drawing.Point(-3, 0)
        Me.Label_Revenue.Name = "Label_Revenue"
        Me.Label_Revenue.Size = New System.Drawing.Size(262, 36)
        Me.Label_Revenue.TabIndex = 0
        Me.Label_Revenue.Text = "No of Product"
        Me.Label_Revenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(836, 445)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 128)
        Me.Panel1.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(64, 62)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 39)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Label4"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(-3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No of Users"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(532, 445)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(259, 128)
        Me.Panel2.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(61, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 39)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Label4"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(-3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 36)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "No of Monthly Sales"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(224, 445)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(259, 128)
        Me.Panel3.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(45, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 39)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Label4"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(-3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(262, 36)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "No of Today Sales"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnInventory
        '
        Me.btnInventory.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInventory.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInventory.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInventory.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventory.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnInventory.Location = New System.Drawing.Point(641, 40)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(126, 67)
        Me.btnInventory.TabIndex = 5
        Me.btnInventory.Text = "Inventory "
        Me.btnInventory.UseVisualStyleBackColor = False
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Location = New System.Drawing.Point(12, 40)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(79, 17)
        Me.lblUserName.TabIndex = 6
        Me.lblUserName.Text = "User Name"
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Location = New System.Drawing.Point(12, 65)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(59, 17)
        Me.lblUserRole.TabIndex = 7
        Me.lblUserRole.Text = "Label10"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1309, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1309, 773)
        Me.Controls.Add(Me.lblUserRole)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel_Revenue)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel_Purchases)
        Me.Controls.Add(Me.Panel_Products)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnUserAccount)
        Me.Controls.Add(Me.btnProductMaster)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Form1"
        Me.Panel_Products.ResumeLayout(False)
        Me.Panel_Purchases.ResumeLayout(False)
        Me.Panel_Revenue.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnProductMaster As Button
    Friend WithEvents btnUserAccount As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents btnLogout As Button
    Friend WithEvents Panel_Products As Panel
    Friend WithEvents Panel_Purchases As Panel
    Friend WithEvents Panel_Revenue As Panel
    Friend WithEvents Label_Products As Label
    Friend WithEvents Label_Purchases As Label
    Friend WithEvents Label_Revenue As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents btnInventory As Button
    Friend WithEvents lblTodaySales As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblUserRole As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
End Class
