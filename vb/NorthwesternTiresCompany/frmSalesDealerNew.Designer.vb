<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesDealerNew
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
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnSaveOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtNeeded = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTotalLabel = New System.Windows.Forms.Label()
        Me.lblTireCode = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblOnHand = New System.Windows.Forms.Label()
        Me.txtDealerPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtDealerName = New System.Windows.Forms.TextBox()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.txtDealerID = New System.Windows.Forms.TextBox()
        Me.btnSelectTire = New System.Windows.Forms.Button()
        Me.btnSelectDealer = New System.Windows.Forms.Button()
        Me.lblDealerPhone = New System.Windows.Forms.Label()
        Me.lblDealerName = New System.Windows.Forms.Label()
        Me.lblDealerID = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.WholesaleOrderTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.wholesaleOrderTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.InvSearchTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelOrder.Location = New System.Drawing.Point(247, 429)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(200, 30)
        Me.btnCancelOrder.TabIndex = 31
        Me.btnCancelOrder.Text = "Cancel Order"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnSaveOrder
        '
        Me.btnSaveOrder.Enabled = False
        Me.btnSaveOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveOrder.Location = New System.Drawing.Point(247, 393)
        Me.btnSaveOrder.Name = "btnSaveOrder"
        Me.btnSaveOrder.Size = New System.Drawing.Size(200, 30)
        Me.btnSaveOrder.TabIndex = 32
        Me.btnSaveOrder.Text = "Save and Print Order"
        Me.btnSaveOrder.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(592, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 30
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
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(262, 16)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(170, 24)
        Me.lblSales.TabIndex = 28
        Me.lblSales.Text = "New Dealer Sale"
        '
        'btnUpdate
        '
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.Location = New System.Drawing.Point(488, 277)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 26)
        Me.btnUpdate.TabIndex = 48
        Me.btnUpdate.Text = "Update Total"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtNeeded
        '
        Me.txtNeeded.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNeeded.Location = New System.Drawing.Point(437, 277)
        Me.txtNeeded.Mask = "990"
        Me.txtNeeded.Name = "txtNeeded"
        Me.txtNeeded.ReadOnly = True
        Me.txtNeeded.Size = New System.Drawing.Size(45, 26)
        Me.txtNeeded.TabIndex = 47
        Me.txtNeeded.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNeeded.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(325, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 18)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Tires Needed:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(544, 329)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(83, 18)
        Me.lblTotal.TabIndex = 44
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalLabel
        '
        Me.lblTotalLabel.AutoSize = True
        Me.lblTotalLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalLabel.Location = New System.Drawing.Point(465, 329)
        Me.lblTotalLabel.Name = "lblTotalLabel"
        Me.lblTotalLabel.Size = New System.Drawing.Size(85, 18)
        Me.lblTotalLabel.TabIndex = 45
        Me.lblTotalLabel.Text = "Total Price:"
        '
        'lblTireCode
        '
        Me.lblTireCode.AutoSize = True
        Me.lblTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTireCode.Location = New System.Drawing.Point(268, 184)
        Me.lblTireCode.Name = "lblTireCode"
        Me.lblTireCode.Size = New System.Drawing.Size(81, 18)
        Me.lblTireCode.TabIndex = 41
        Me.lblTireCode.Text = "Tire Code:"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(390, 184)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(106, 18)
        Me.lblPrice.TabIndex = 42
        Me.lblPrice.Text = "Price per Tire:"
        '
        'lblOnHand
        '
        Me.lblOnHand.AutoSize = True
        Me.lblOnHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHand.Location = New System.Drawing.Point(510, 184)
        Me.lblOnHand.Name = "lblOnHand"
        Me.lblOnHand.Size = New System.Drawing.Size(130, 18)
        Me.lblOnHand.TabIndex = 43
        Me.lblOnHand.Text = "Quantity on Hand:"
        '
        'txtDealerPhone
        '
        Me.txtDealerPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerPhone.Location = New System.Drawing.Point(511, 133)
        Me.txtDealerPhone.Mask = "(000) 000-0000"
        Me.txtDealerPhone.Name = "txtDealerPhone"
        Me.txtDealerPhone.ReadOnly = True
        Me.txtDealerPhone.Size = New System.Drawing.Size(129, 26)
        Me.txtDealerPhone.TabIndex = 40
        '
        'txtDealerName
        '
        Me.txtDealerName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerName.Location = New System.Drawing.Point(335, 133)
        Me.txtDealerName.Name = "txtDealerName"
        Me.txtDealerName.ReadOnly = True
        Me.txtDealerName.Size = New System.Drawing.Size(170, 26)
        Me.txtDealerName.TabIndex = 36
        '
        'txtOnHand
        '
        Me.txtOnHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnHand.Location = New System.Drawing.Point(510, 205)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.ReadOnly = True
        Me.txtOnHand.Size = New System.Drawing.Size(129, 26)
        Me.txtOnHand.TabIndex = 35
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(375, 205)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(129, 26)
        Me.txtPrice.TabIndex = 37
        '
        'txtTireCode
        '
        Me.txtTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireCode.Location = New System.Drawing.Point(240, 205)
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.ReadOnly = True
        Me.txtTireCode.Size = New System.Drawing.Size(129, 26)
        Me.txtTireCode.TabIndex = 39
        '
        'txtDealerID
        '
        Me.txtDealerID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerID.Location = New System.Drawing.Point(241, 133)
        Me.txtDealerID.Name = "txtDealerID"
        Me.txtDealerID.ReadOnly = True
        Me.txtDealerID.Size = New System.Drawing.Size(88, 26)
        Me.txtDealerID.TabIndex = 38
        '
        'btnSelectTire
        '
        Me.btnSelectTire.Enabled = False
        Me.btnSelectTire.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectTire.Location = New System.Drawing.Point(54, 201)
        Me.btnSelectTire.Name = "btnSelectTire"
        Me.btnSelectTire.Size = New System.Drawing.Size(139, 30)
        Me.btnSelectTire.TabIndex = 33
        Me.btnSelectTire.Text = "Search for Tire"
        Me.btnSelectTire.UseVisualStyleBackColor = True
        '
        'btnSelectDealer
        '
        Me.btnSelectDealer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectDealer.Location = New System.Drawing.Point(54, 129)
        Me.btnSelectDealer.Name = "btnSelectDealer"
        Me.btnSelectDealer.Size = New System.Drawing.Size(139, 30)
        Me.btnSelectDealer.TabIndex = 34
        Me.btnSelectDealer.Text = "Select Dealer"
        Me.btnSelectDealer.UseVisualStyleBackColor = True
        '
        'lblDealerPhone
        '
        Me.lblDealerPhone.AutoSize = True
        Me.lblDealerPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerPhone.Location = New System.Drawing.Point(544, 112)
        Me.lblDealerPhone.Name = "lblDealerPhone"
        Me.lblDealerPhone.Size = New System.Drawing.Size(57, 18)
        Me.lblDealerPhone.TabIndex = 43
        Me.lblDealerPhone.Text = "Phone:"
        '
        'lblDealerName
        '
        Me.lblDealerName.AutoSize = True
        Me.lblDealerName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerName.Location = New System.Drawing.Point(385, 112)
        Me.lblDealerName.Name = "lblDealerName"
        Me.lblDealerName.Size = New System.Drawing.Size(59, 18)
        Me.lblDealerName.TabIndex = 42
        Me.lblDealerName.Text = "Dealer:"
        '
        'lblDealerID
        '
        Me.lblDealerID.AutoSize = True
        Me.lblDealerID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealerID.Location = New System.Drawing.Point(250, 112)
        Me.lblDealerID.Name = "lblDealerID"
        Me.lblDealerID.Size = New System.Drawing.Size(72, 18)
        Me.lblDealerID.TabIndex = 41
        Me.lblDealerID.Text = "Dealer #:"
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WholesaleOrderTableAdapter
        '
        Me.WholesaleOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.dealerTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.inventoryTableAdapter = Nothing
        Me.TableAdapterManager.purchaseOrderTableAdapter = Nothing
        Me.TableAdapterManager.retailOrderTableAdapter = Nothing
        Me.TableAdapterManager.securityClearanceTableAdapter = Nothing
        Me.TableAdapterManager.storeTableAdapter = Nothing
        Me.TableAdapterManager.tireTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendorTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Me.WholesaleOrderTableAdapter
        '
        'InvSearchTableAdapter
        '
        Me.InvSearchTableAdapter.ClearBeforeFill = True
        '
        'frmSalesDealerNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.txtNeeded)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTotalLabel)
        Me.Controls.Add(Me.lblDealerID)
        Me.Controls.Add(Me.lblTireCode)
        Me.Controls.Add(Me.lblDealerName)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblDealerPhone)
        Me.Controls.Add(Me.lblOnHand)
        Me.Controls.Add(Me.txtDealerPhone)
        Me.Controls.Add(Me.txtDealerName)
        Me.Controls.Add(Me.txtOnHand)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtTireCode)
        Me.Controls.Add(Me.txtDealerID)
        Me.Controls.Add(Me.btnSelectTire)
        Me.Controls.Add(Me.btnSelectDealer)
        Me.Controls.Add(Me.btnCancelOrder)
        Me.Controls.Add(Me.btnSaveOrder)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesDealerNew"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Dealer Sale"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelOrder As System.Windows.Forms.Button
    Friend WithEvents btnSaveOrder As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents txtNeeded As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalLabel As System.Windows.Forms.Label
    Friend WithEvents lblTireCode As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents lblOnHand As System.Windows.Forms.Label
    Friend WithEvents txtDealerPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDealerName As System.Windows.Forms.TextBox
    Friend WithEvents txtOnHand As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerID As System.Windows.Forms.TextBox
    Friend WithEvents btnSelectTire As System.Windows.Forms.Button
    Friend WithEvents btnSelectDealer As System.Windows.Forms.Button
    Friend WithEvents lblDealerPhone As System.Windows.Forms.Label
    Friend WithEvents lblDealerName As System.Windows.Forms.Label
    Friend WithEvents lblDealerID As System.Windows.Forms.Label
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents WholesaleOrderTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.wholesaleOrderTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvSearchTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter
End Class
