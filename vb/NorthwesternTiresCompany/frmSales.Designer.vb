<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSales
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
        Me.lblSales = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSelectCust = New System.Windows.Forms.Button()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.btnSelectTire = New System.Windows.Forms.Button()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblOnHand = New System.Windows.Forms.Label()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblTireCode = New System.Windows.Forms.Label()
        Me.txtNeeded = New System.Windows.Forms.MaskedTextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.RetailOrderTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.retailOrderTableAdapter()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.InvSearchTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter()
        Me.EmployeeTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.employeeTableAdapter()
        Me.lblSalespersonLabel = New System.Windows.Forms.Label()
        Me.lblSalesperson = New System.Windows.Forms.Label()
        Me.btnDealerOrders = New System.Windows.Forms.Button()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(315, 9)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(65, 24)
        Me.lblSales.TabIndex = 0
        Me.lblSales.Text = "Sales"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(592, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 480)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 16
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnSelectCust
        '
        Me.btnSelectCust.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectCust.Location = New System.Drawing.Point(54, 135)
        Me.btnSelectCust.Name = "btnSelectCust"
        Me.btnSelectCust.Size = New System.Drawing.Size(139, 30)
        Me.btnSelectCust.TabIndex = 19
        Me.btnSelectCust.Text = "Select customer"
        Me.btnSelectCust.UseVisualStyleBackColor = True
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(241, 139)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(129, 26)
        Me.txtFirstName.TabIndex = 20
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(376, 139)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(129, 26)
        Me.txtLastName.TabIndex = 20
        '
        'txtPhone
        '
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(511, 139)
        Me.txtPhone.Mask = "(000) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(129, 26)
        Me.txtPhone.TabIndex = 21
        '
        'btnSelectTire
        '
        Me.btnSelectTire.Enabled = False
        Me.btnSelectTire.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTire.Location = New System.Drawing.Point(54, 207)
        Me.btnSelectTire.Name = "btnSelectTire"
        Me.btnSelectTire.Size = New System.Drawing.Size(139, 30)
        Me.btnSelectTire.TabIndex = 19
        Me.btnSelectTire.Text = "Search for Tire"
        Me.btnSelectTire.UseVisualStyleBackColor = True
        '
        'txtTireCode
        '
        Me.txtTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireCode.Location = New System.Drawing.Point(240, 211)
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.ReadOnly = True
        Me.txtTireCode.Size = New System.Drawing.Size(129, 26)
        Me.txtTireCode.TabIndex = 20
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(375, 211)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(129, 26)
        Me.txtPrice.TabIndex = 20
        '
        'lblOnHand
        '
        Me.lblOnHand.AutoSize = True
        Me.lblOnHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHand.Location = New System.Drawing.Point(510, 190)
        Me.lblOnHand.Name = "lblOnHand"
        Me.lblOnHand.Size = New System.Drawing.Size(130, 18)
        Me.lblOnHand.TabIndex = 22
        Me.lblOnHand.Text = "Quantity on Hand:"
        '
        'txtOnHand
        '
        Me.txtOnHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnHand.Location = New System.Drawing.Point(510, 211)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.ReadOnly = True
        Me.txtOnHand.Size = New System.Drawing.Size(129, 26)
        Me.txtOnHand.TabIndex = 20
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(465, 335)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(85, 18)
        Me.lblTotalLabel.TabIndex = 23
        Me.lblTotalLabel.Text = "Total Price:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(544, 335)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 18)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tires Needed:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(390, 190)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(106, 18)
        Me.lblPrice.TabIndex = 22
        Me.lblPrice.Text = "Price per Tire:"
        '
        'lblTireCode
        '
        Me.lblTireCode.AutoSize = True
        Me.lblTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTireCode.Location = New System.Drawing.Point(268, 190)
        Me.lblTireCode.Name = "lblTireCode"
        Me.lblTireCode.Size = New System.Drawing.Size(81, 18)
        Me.lblTireCode.TabIndex = 22
        Me.lblTireCode.Text = "Tire Code:"
        '
        'txtNeeded
        '
        Me.txtNeeded.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeeded.Location = New System.Drawing.Point(437, 283)
        Me.txtNeeded.Mask = "990"
        Me.txtNeeded.Name = "txtNeeded"
        Me.txtNeeded.ReadOnly = True
        Me.txtNeeded.Size = New System.Drawing.Size(45, 26)
        Me.txtNeeded.TabIndex = 25
        Me.txtNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNeeded.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(488, 283)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 26)
        Me.btnUpdate.TabIndex = 26
        Me.btnUpdate.Text = "Update Total"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Enabled = False
        Me.btnSaveOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOrder.Location = New System.Drawing.Point(247, 396)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(200, 30)
        Me.btnSaveOrder.TabIndex = 27
        Me.btnSaveOrder.Text = "Check Out"
        Me.btnSaveOrder.UseVisualStyleBackColor = True
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelOrder.Location = New System.Drawing.Point(247, 432)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(200, 30)
        Me.btnCancelOrder.TabIndex = 27
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'RetailOrderTableAdapter
        '
        Me.RetailOrderTableAdapter.ClearBeforeFill = True
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.dealerTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.inventoryTableAdapter = Nothing
        Me.TableAdapterManager.purchaseOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.purchaseOrderTableAdapter = Nothing
        Me.TableAdapterManager.retailOrderTableAdapter = Me.RetailOrderTableAdapter
        Me.TableAdapterManager.securityClearanceTableAdapter = Nothing
        Me.TableAdapterManager.storeTableAdapter = Nothing
        Me.TableAdapterManager.tireTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendorTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'InvSearchTableAdapter
        '
        Me.InvSearchTableAdapter.ClearBeforeFill = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'lblSalespersonLabel
        '
        Me.lblSalespersonLabel.AutoSize = True
        Me.lblSalespersonLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalespersonLabel.Location = New System.Drawing.Point(207, 64)
        Me.lblSalespersonLabel.Name = "lblSalespersonLabel"
        Me.lblSalespersonLabel.Size = New System.Drawing.Size(100, 18)
        Me.lblSalespersonLabel.TabIndex = 28
        Me.lblSalespersonLabel.Text = "Salesperson:"
        '
        'lblSalesperson
        '
        Me.lblSalesperson.AutoSize = True
        Me.lblSalesperson.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesperson.Location = New System.Drawing.Point(313, 64)
        Me.lblSalesperson.Name = "lblSalesperson"
        Me.lblSalesperson.Size = New System.Drawing.Size(19, 18)
        Me.lblSalesperson.TabIndex = 28
        Me.lblSalesperson.Text = "S"
        '
        'btnDealerOrders
        '
        Me.btnDealerOrders.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDealerOrders.Location = New System.Drawing.Point(247, 480)
        Me.btnDealerOrders.Name = "btnDealerOrders"
        Me.btnDealerOrders.Size = New System.Drawing.Size(200, 30)
        Me.btnDealerOrders.TabIndex = 27
        Me.btnDealerOrders.Text = "Dealer Orders"
        Me.btnDealerOrders.UseVisualStyleBackColor = True
        Me.btnDealerOrders.Visible = False
        '
        'frmSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblSalesperson)
        Me.Controls.Add(Me.lblSalespersonLabel)
        Me.Controls.Add(Me.btnDealerOrders)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNeeded)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblTireCode)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblOnHand)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtOnHand)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtTireCode)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.btnSelectTire)
        Me.Controls.Add(Me.btnSelectCust)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnSelectCust As System.Windows.Forms.Button
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnSelectTire As System.Windows.Forms.Button
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents lblOnHand As System.Windows.Forms.Label
    Friend WithEvents txtOnHand As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblTireCode As System.Windows.Forms.Label
    Friend WithEvents txtNeeded As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnSaveOrder As System.Windows.Forms.Button
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button
    Friend WithEvents RetailOrderTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.retailOrderTableAdapter
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvSearchTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter
    Friend WithEvents EmployeeTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.employeeTableAdapter
    Friend WithEvents lblSalespersonLabel As System.Windows.Forms.Label
    Friend WithEvents lblSalesperson As System.Windows.Forms.Label
    Friend WithEvents btnDealerOrders As System.Windows.Forms.Button
End Class
