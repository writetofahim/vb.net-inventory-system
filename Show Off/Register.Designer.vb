<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Register
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblUserName = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUserRole = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.cmbUserRole = New System.Windows.Forms.ComboBox()
        Me.CheckShowPass = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(154, 229)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(74, 38)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(239, 229)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(74, 38)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblUserName
        '
        Me.lblUserName.AutoSize = True
        Me.lblUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserName.Location = New System.Drawing.Point(52, 60)
        Me.lblUserName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserName.Name = "lblUserName"
        Me.lblUserName.Size = New System.Drawing.Size(73, 17)
        Me.lblUserName.TabIndex = 2
        Me.lblUserName.Text = "Username"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(52, 160)
        Me.lblPassword.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(69, 17)
        Me.lblPassword.TabIndex = 3
        Me.lblPassword.Text = "Password"
        '
        'lblUserRole
        '
        Me.lblUserRole.AutoSize = True
        Me.lblUserRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserRole.Location = New System.Drawing.Point(52, 107)
        Me.lblUserRole.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUserRole.Name = "lblUserRole"
        Me.lblUserRole.Size = New System.Drawing.Size(71, 17)
        Me.lblUserRole.TabIndex = 4
        Me.lblUserRole.Text = "User Role"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 254)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Register"
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(154, 58)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(268, 23)
        Me.txtUserName.TabIndex = 0
        '
        'txtPass
        '
        Me.txtPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(154, 158)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(268, 23)
        Me.txtPass.TabIndex = 2
        Me.txtPass.UseSystemPasswordChar = True
        '
        'cmbUserRole
        '
        Me.cmbUserRole.AutoCompleteCustomSource.AddRange(New String() {"ADMIN", "SALES_MAN", "CASHIER"})
        Me.cmbUserRole.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbUserRole.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbUserRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserRole.FormattingEnabled = True
        Me.cmbUserRole.Items.AddRange(New Object() {"ADMIN", "SALES_MAN", "CASHIER"})
        Me.cmbUserRole.Location = New System.Drawing.Point(154, 107)
        Me.cmbUserRole.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbUserRole.Name = "cmbUserRole"
        Me.cmbUserRole.Size = New System.Drawing.Size(268, 25)
        Me.cmbUserRole.TabIndex = 1
        '
        'CheckShowPass
        '
        Me.CheckShowPass.AutoSize = True
        Me.CheckShowPass.Location = New System.Drawing.Point(154, 192)
        Me.CheckShowPass.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.CheckShowPass.Name = "CheckShowPass"
        Me.CheckShowPass.Size = New System.Drawing.Size(102, 17)
        Me.CheckShowPass.TabIndex = 11
        Me.CheckShowPass.Text = "Show Password"
        Me.CheckShowPass.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(470, 24)
        Me.MenuStrip1.TabIndex = 12
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 310)
        Me.Controls.Add(Me.CheckShowPass)
        Me.Controls.Add(Me.cmbUserRole)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblUserRole)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblUserName As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUserRole As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtUserName As TextBox
    Friend WithEvents txtPass As TextBox
    Friend WithEvents cmbUserRole As ComboBox
    Friend WithEvents CheckShowPass As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
End Class
