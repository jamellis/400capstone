<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPOReceiveTires
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
        Me.txtQtyReceived = New System.Windows.Forms.MaskedTextBox()
        Me.lblReceived = New System.Windows.Forms.Label()
        Me.lblPONumber = New System.Windows.Forms.Label()
        Me.lblTireCode = New System.Windows.Forms.Label()
        Me.lblVendorName = New System.Windows.Forms.Label()
        Me.lblOnHand = New System.Windows.Forms.Label()
        Me.txtVendorID = New System.Windows.Forms.TextBox()
        Me.txtOnHand = New System.Windows.Forms.TextBox()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.txtPONum = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblSales = New System.Windows.Forms.Label()
        Me.txtQtyOrdered = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.PurchaseOrderTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.purchaseOrderTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.InventoryTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.inventoryTableAdapter()
        Me.txtInvNum = New System.Windows.Forms.TextBox()
        Me.lblInvNum = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtQtyReceived
        '
        Me.txtQtyReceived.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyReceived.Location = New System.Drawing.Point(225, 245)
        Me.txtQtyReceived.Mask = "990"
        Me.txtQtyReceived.Name = "txtQtyReceived"
        Me.txtQtyReceived.Size = New System.Drawing.Size(45, 26)
        Me.txtQtyReceived.TabIndex = 1
        Me.txtQtyReceived.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtQtyReceived.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        '
        'lblReceived
        '
        Me.lblReceived.AutoSize = True
        Me.lblReceived.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReceived.Location = New System.Drawing.Point(57, 248)
        Me.lblReceived.Name = "lblReceived"
        Me.lblReceived.Size = New System.Drawing.Size(138, 18)
        Me.lblReceived.TabIndex = 92
        Me.lblReceived.Text = "Quantity Received:"
        '
        'lblPONumber
        '
        Me.lblPONumber.AutoSize = True
        Me.lblPONumber.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPONumber.Location = New System.Drawing.Point(99, 64)
        Me.lblPONumber.Name = "lblPONumber"
        Me.lblPONumber.Size = New System.Drawing.Size(48, 18)
        Me.lblPONumber.TabIndex = 86
        Me.lblPONumber.Text = "PO #:"
        '
        'lblTireCode
        '
        Me.lblTireCode.AutoSize = True
        Me.lblTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTireCode.Location = New System.Drawing.Point(57, 136)
        Me.lblTireCode.Name = "lblTireCode"
        Me.lblTireCode.Size = New System.Drawing.Size(81, 18)
        Me.lblTireCode.TabIndex = 85
        Me.lblTireCode.Text = "Tire Code:"
        '
        'lblVendorName
        '
        Me.lblVendorName.AutoSize = True
        Me.lblVendorName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVendorName.Location = New System.Drawing.Point(227, 64)
        Me.lblVendorName.Name = "lblVendorName"
        Me.lblVendorName.Size = New System.Drawing.Size(62, 18)
        Me.lblVendorName.TabIndex = 87
        Me.lblVendorName.Text = "Vendor:"
        '
        'lblOnHand
        '
        Me.lblOnHand.AutoSize = True
        Me.lblOnHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnHand.Location = New System.Drawing.Point(252, 136)
        Me.lblOnHand.Name = "lblOnHand"
        Me.lblOnHand.Size = New System.Drawing.Size(73, 18)
        Me.lblOnHand.TabIndex = 89
        Me.lblOnHand.Text = "On Hand:"
        '
        'txtVendorID
        '
        Me.txtVendorID.Enabled = False
        Me.txtVendorID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVendorID.Location = New System.Drawing.Point(192, 85)
        Me.txtVendorID.Name = "txtVendorID"
        Me.txtVendorID.ReadOnly = True
        Me.txtVendorID.Size = New System.Drawing.Size(129, 26)
        Me.txtVendorID.TabIndex = 81
        '
        'txtOnHand
        '
        Me.txtOnHand.Enabled = False
        Me.txtOnHand.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOnHand.Location = New System.Drawing.Point(253, 157)
        Me.txtOnHand.Name = "txtOnHand"
        Me.txtOnHand.ReadOnly = True
        Me.txtOnHand.Size = New System.Drawing.Size(68, 26)
        Me.txtOnHand.TabIndex = 80
        '
        'txtTireCode
        '
        Me.txtTireCode.Enabled = False
        Me.txtTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireCode.Location = New System.Drawing.Point(57, 157)
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.ReadOnly = True
        Me.txtTireCode.Size = New System.Drawing.Size(81, 26)
        Me.txtTireCode.TabIndex = 84
        '
        'txtPONum
        '
        Me.txtPONum.Enabled = False
        Me.txtPONum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPONum.Location = New System.Drawing.Point(57, 85)
        Me.txtPONum.Name = "txtPONum"
        Me.txtPONum.ReadOnly = True
        Me.txtPONum.Size = New System.Drawing.Size(129, 26)
        Me.txtPONum.TabIndex = 83
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(123, 339)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(124, 30)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Enabled = False
        Me.btnOK.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(123, 303)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(124, 30)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(110, 20)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(147, 24)
        Me.lblSales.TabIndex = 73
        Me.lblSales.Text = "Receive Tires"
        '
        'txtQtyOrdered
        '
        Me.txtQtyOrdered.Enabled = False
        Me.txtQtyOrdered.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQtyOrdered.Location = New System.Drawing.Point(225, 213)
        Me.txtQtyOrdered.Name = "txtQtyOrdered"
        Me.txtQtyOrdered.ReadOnly = True
        Me.txtQtyOrdered.Size = New System.Drawing.Size(45, 26)
        Me.txtQtyOrdered.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 18)
        Me.Label1.TabIndex = 89
        Me.Label1.Text = "Quantity Ordered:"
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PurchaseOrderTableAdapter
        '
        Me.PurchaseOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.dealerTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.inventoryTableAdapter = Nothing
        Me.TableAdapterManager.purchaseOrderTableAdapter = Me.PurchaseOrderTableAdapter
        Me.TableAdapterManager.retailOrderTableAdapter = Nothing
        Me.TableAdapterManager.securityClearanceTableAdapter = Nothing
        Me.TableAdapterManager.storeTableAdapter = Nothing
        Me.TableAdapterManager.tireTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendorTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'txtInvNum
        '
        Me.txtInvNum.Enabled = False
        Me.txtInvNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvNum.Location = New System.Drawing.Point(155, 157)
        Me.txtInvNum.Name = "txtInvNum"
        Me.txtInvNum.ReadOnly = True
        Me.txtInvNum.Size = New System.Drawing.Size(81, 26)
        Me.txtInvNum.TabIndex = 84
        '
        'lblInvNum
        '
        Me.lblInvNum.AutoSize = True
        Me.lblInvNum.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInvNum.Location = New System.Drawing.Point(156, 136)
        Me.lblInvNum.Name = "lblInvNum"
        Me.lblInvNum.Size = New System.Drawing.Size(85, 18)
        Me.lblInvNum.TabIndex = 85
        Me.lblInvNum.Text = "Inventory #:"
        '
        'frmPOReceiveTires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtQtyReceived)
        Me.Controls.Add(Me.lblReceived)
        Me.Controls.Add(Me.lblPONumber)
        Me.Controls.Add(Me.lblInvNum)
        Me.Controls.Add(Me.lblTireCode)
        Me.Controls.Add(Me.lblVendorName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblOnHand)
        Me.Controls.Add(Me.txtVendorID)
        Me.Controls.Add(Me.txtQtyOrdered)
        Me.Controls.Add(Me.txtOnHand)
        Me.Controls.Add(Me.txtInvNum)
        Me.Controls.Add(Me.txtTireCode)
        Me.Controls.Add(Me.txtPONum)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.lblSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPOReceiveTires"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Receive Tires"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQtyReceived As System.Windows.Forms.MaskedTextBox
    Friend WithEvents lblReceived As System.Windows.Forms.Label
    Friend WithEvents lblPONumber As System.Windows.Forms.Label
    Friend WithEvents lblTireCode As System.Windows.Forms.Label
    Friend WithEvents lblVendorName As System.Windows.Forms.Label
    Friend WithEvents lblOnHand As System.Windows.Forms.Label
    Friend WithEvents txtVendorID As System.Windows.Forms.TextBox
    Friend WithEvents txtOnHand As System.Windows.Forms.TextBox
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents txtPONum As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents txtQtyOrdered As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents PurchaseOrderTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.purchaseOrderTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventoryTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents txtInvNum As System.Windows.Forms.TextBox
    Friend WithEvents lblInvNum As System.Windows.Forms.Label
End Class
