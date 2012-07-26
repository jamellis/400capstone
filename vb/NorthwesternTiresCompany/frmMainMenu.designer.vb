<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnStores = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTires = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnInventorySearch = New System.Windows.Forms.Button()
        Me.btnInventoryMaintain = New System.Windows.Forms.Button()
        Me.btnSales = New System.Windows.Forms.Button()
        Me.btnEmployee = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnPO = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStores
        '
        Me.btnStores.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStores.Location = New System.Drawing.Point(367, 225)
        Me.btnStores.Name = "btnStores"
        Me.btnStores.Size = New System.Drawing.Size(140, 30)
        Me.btnStores.TabIndex = 6
        Me.btnStores.Text = "St&ores"
        Me.btnStores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(367, 448)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTires
        '
        Me.btnTires.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTires.Location = New System.Drawing.Point(367, 155)
        Me.btnTires.Name = "btnTires"
        Me.btnTires.Size = New System.Drawing.Size(140, 30)
        Me.btnTires.TabIndex = 5
        Me.btnTires.Text = "&Tires"
        Me.btnTires.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(283, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(118, 24)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Main Menu"
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(228, 448)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(90, 30)
        Me.btnLogOut.TabIndex = 9
        Me.btnLogOut.Text = "&Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnInventorySearch
        '
        Me.btnInventorySearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventorySearch.Location = New System.Drawing.Point(178, 155)
        Me.btnInventorySearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventorySearch.Name = "btnInventorySearch"
        Me.btnInventorySearch.Size = New System.Drawing.Size(140, 30)
        Me.btnInventorySearch.TabIndex = 1
        Me.btnInventorySearch.Text = "&Inventory Search"
        Me.btnInventorySearch.UseVisualStyleBackColor = True
        '
        'btnInventoryMaintain
        '
        Me.btnInventoryMaintain.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryMaintain.Location = New System.Drawing.Point(178, 225)
        Me.btnInventoryMaintain.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInventoryMaintain.Name = "btnInventoryMaintain"
        Me.btnInventoryMaintain.Size = New System.Drawing.Size(140, 30)
        Me.btnInventoryMaintain.TabIndex = 2
        Me.btnInventoryMaintain.Text = "Inventory &Maintain"
        Me.btnInventoryMaintain.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.Location = New System.Drawing.Point(178, 295)
        Me.btnSales.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(140, 30)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "&Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Location = New System.Drawing.Point(367, 295)
        Me.btnEmployee.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(140, 30)
        Me.btnEmployee.TabIndex = 7
        Me.btnEmployee.Text = "&Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(178, 365)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(140, 30)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "&Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnPO
        '
        Me.btnPO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPO.Location = New System.Drawing.Point(367, 365)
        Me.btnPO.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPO.Name = "btnPO"
        Me.btnPO.Size = New System.Drawing.Size(140, 30)
        Me.btnPO.TabIndex = 8
        Me.btnPO.Text = "&PO"
        Me.btnPO.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NorthwesternTiresCompany.My.Resources.Resources.nwtires_logo_sm
        Me.PictureBox1.Location = New System.Drawing.Point(226, 47)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(232, 73)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 512)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPO)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnInventoryMaintain)
        Me.Controls.Add(Me.btnInventorySearch)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnStores)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTires)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStores As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTires As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnInventorySearch As System.Windows.Forms.Button
    Friend WithEvents btnInventoryMaintain As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnPO As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
