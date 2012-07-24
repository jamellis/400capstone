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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.btnStores.Location = New System.Drawing.Point(489, 277)
        Me.btnStores.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStores.Name = "btnStores"
        Me.btnStores.Size = New System.Drawing.Size(187, 37)
        Me.btnStores.TabIndex = 6
        Me.btnStores.Text = "St&ores"
        Me.btnStores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(489, 551)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 37)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTires
        '
        Me.btnTires.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTires.Location = New System.Drawing.Point(489, 191)
        Me.btnTires.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTires.Name = "btnTires"
        Me.btnTires.Size = New System.Drawing.Size(187, 37)
        Me.btnTires.TabIndex = 5
        Me.btnTires.Text = "&Tires"
        Me.btnTires.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(377, 14)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(154, 32)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Main Menu"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(304, 554)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 34)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnInventorySearch
        '
        Me.btnInventorySearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventorySearch.Location = New System.Drawing.Point(237, 191)
        Me.btnInventorySearch.Name = "btnInventorySearch"
        Me.btnInventorySearch.Size = New System.Drawing.Size(187, 37)
        Me.btnInventorySearch.TabIndex = 1
        Me.btnInventorySearch.Text = "&Inventory Search"
        Me.btnInventorySearch.UseVisualStyleBackColor = True
        '
        'btnInventoryMaintain
        '
        Me.btnInventoryMaintain.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryMaintain.Location = New System.Drawing.Point(237, 277)
        Me.btnInventoryMaintain.Name = "btnInventoryMaintain"
        Me.btnInventoryMaintain.Size = New System.Drawing.Size(187, 37)
        Me.btnInventoryMaintain.TabIndex = 2
        Me.btnInventoryMaintain.Text = "Inventory &Maintain"
        Me.btnInventoryMaintain.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSales.Location = New System.Drawing.Point(237, 363)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(187, 37)
        Me.btnSales.TabIndex = 3
        Me.btnSales.Text = "&Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnEmployee
        '
        Me.btnEmployee.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmployee.Location = New System.Drawing.Point(489, 363)
        Me.btnEmployee.Name = "btnEmployee"
        Me.btnEmployee.Size = New System.Drawing.Size(187, 37)
        Me.btnEmployee.TabIndex = 7
        Me.btnEmployee.Text = "&Employee"
        Me.btnEmployee.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Location = New System.Drawing.Point(237, 449)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(187, 37)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "&Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnPO
        '
        Me.btnPO.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPO.Location = New System.Drawing.Point(489, 449)
        Me.btnPO.Name = "btnPO"
        Me.btnPO.Size = New System.Drawing.Size(187, 37)
        Me.btnPO.TabIndex = 8
        Me.btnPO.Text = "&PO"
        Me.btnPO.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NorthwesternTiresCompany.My.Resources.Resources.nwtires_logo
        Me.PictureBox1.Location = New System.Drawing.Point(309, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(294, 90)
        Me.PictureBox1.TabIndex = 26
        Me.PictureBox1.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 630)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnPO)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnEmployee)
        Me.Controls.Add(Me.btnSales)
        Me.Controls.Add(Me.btnInventoryMaintain)
        Me.Controls.Add(Me.btnInventorySearch)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStores)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTires)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnInventorySearch As System.Windows.Forms.Button
    Friend WithEvents btnInventoryMaintain As System.Windows.Forms.Button
    Friend WithEvents btnSales As System.Windows.Forms.Button
    Friend WithEvents btnEmployee As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnPO As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
