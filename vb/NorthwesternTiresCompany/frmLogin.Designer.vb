<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.AdminLogin = New System.Windows.Forms.Button()
        Me.WarehouseLogin = New System.Windows.Forms.Button()
        Me.ManagerLogin = New System.Windows.Forms.Button()
        Me.SalesLogin = New System.Windows.Forms.Button()
        Me.EmployeeTableAdapter1 = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.employeeTableAdapter()
        Me.SuspendLayout()
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.Blue
        Me.lblInstructions.Location = New System.Drawing.Point(31, 24)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(310, 38)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Please type your User ID and Password" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and click Login. Or click Cancel to Quit."
        '
        'txtUserID
        '
        Me.txtUserID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(147, 90)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(170, 26)
        Me.txtUserID.TabIndex = 1
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(147, 121)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(170, 26)
        Me.txtPassword.TabIndex = 2
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUserID.Location = New System.Drawing.Point(77, 94)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(64, 18)
        Me.lblUserID.TabIndex = 3
        Me.lblUserID.Text = "User ID:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(59, 125)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(82, 18)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password:"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(44, 227)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(80, 30)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "&Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(249, 227)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 30)
        Me.btnCancel.TabIndex = 6
        Me.btnCancel.Text = "&Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'AdminLogin
        '
        Me.AdminLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.AdminLogin.Location = New System.Drawing.Point(130, 252)
        Me.AdminLogin.Name = "AdminLogin"
        Me.AdminLogin.Size = New System.Drawing.Size(113, 23)
        Me.AdminLogin.TabIndex = 7
        Me.AdminLogin.Text = "Admin login"
        Me.AdminLogin.UseVisualStyleBackColor = True
        '
        'WarehouseLogin
        '
        Me.WarehouseLogin.Location = New System.Drawing.Point(130, 227)
        Me.WarehouseLogin.Name = "WarehouseLogin"
        Me.WarehouseLogin.Size = New System.Drawing.Size(113, 23)
        Me.WarehouseLogin.TabIndex = 8
        Me.WarehouseLogin.Text = "Warehouse Login"
        Me.WarehouseLogin.UseVisualStyleBackColor = True
        '
        'ManagerLogin
        '
        Me.ManagerLogin.Location = New System.Drawing.Point(130, 202)
        Me.ManagerLogin.Name = "ManagerLogin"
        Me.ManagerLogin.Size = New System.Drawing.Size(113, 23)
        Me.ManagerLogin.TabIndex = 8
        Me.ManagerLogin.Text = "Manager Login"
        Me.ManagerLogin.UseVisualStyleBackColor = True
        '
        'SalesLogin
        '
        Me.SalesLogin.Location = New System.Drawing.Point(130, 178)
        Me.SalesLogin.Name = "SalesLogin"
        Me.SalesLogin.Size = New System.Drawing.Size(113, 23)
        Me.SalesLogin.TabIndex = 8
        Me.SalesLogin.Text = "Sales Login"
        Me.SalesLogin.UseVisualStyleBackColor = True
        '
        'EmployeeTableAdapter1
        '
        Me.EmployeeTableAdapter1.ClearBeforeFill = True
        '
        'frmLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(373, 287)
        Me.ControlBox = False
        Me.Controls.Add(Me.SalesLogin)
        Me.Controls.Add(Me.ManagerLogin)
        Me.Controls.Add(Me.WarehouseLogin)
        Me.Controls.Add(Me.AdminLogin)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblInstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents EmployeeTableAdapter1 As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.employeeTableAdapter
    Friend WithEvents AdminLogin As System.Windows.Forms.Button
    Friend WithEvents WarehouseLogin As System.Windows.Forms.Button
    Friend WithEvents ManagerLogin As System.Windows.Forms.Button
    Friend WithEvents SalesLogin As System.Windows.Forms.Button
End Class
