<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPO2
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
        Dim lblVendorID As System.Windows.Forms.Label
        Dim lblComments As System.Windows.Forms.Label
        Dim lblPurchaseOrderNbr As System.Windows.Forms.Label
        Dim lblTireQty As System.Windows.Forms.Label
        Dim lblPoTotal As System.Windows.Forms.Label
        Dim lblTireCode As System.Windows.Forms.Label
        Dim lblPODate As System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSalesDate = New System.Windows.Forms.TextBox()
        Me.PurchaseOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.btnSaveComments = New System.Windows.Forms.Button()
        Me.txtDealerID = New System.Windows.Forms.TextBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.txtWhlslOrderTotal = New System.Windows.Forms.TextBox()
        Me.txtWhlslOrderNbr = New System.Windows.Forms.TextBox()
        Me.txtTireQty = New System.Windows.Forms.TextBox()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.PurchaseOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.PoNbrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VendorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TireCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TireQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PoTotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCreateNewOrder = New System.Windows.Forms.Button()
        Me.PurchaseOrderTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.purchaseOrderTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnReceive = New System.Windows.Forms.Button()
        Me.btnReprint = New System.Windows.Forms.Button()
        lblVendorID = New System.Windows.Forms.Label()
        lblComments = New System.Windows.Forms.Label()
        lblPurchaseOrderNbr = New System.Windows.Forms.Label()
        lblTireQty = New System.Windows.Forms.Label()
        lblPoTotal = New System.Windows.Forms.Label()
        lblTireCode = New System.Windows.Forms.Label()
        lblPODate = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurchaseOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVendorID
        '
        lblVendorID.AutoSize = True
        lblVendorID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblVendorID.Location = New System.Drawing.Point(25, 55)
        lblVendorID.Name = "lblVendorID"
        lblVendorID.Size = New System.Drawing.Size(81, 18)
        lblVendorID.TabIndex = 65
        lblVendorID.Text = "Vendor ID:"
        '
        'lblComments
        '
        lblComments.AutoSize = True
        lblComments.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblComments.Location = New System.Drawing.Point(348, 54)
        lblComments.Name = "lblComments"
        lblComments.Size = New System.Drawing.Size(88, 18)
        lblComments.TabIndex = 79
        lblComments.Text = "Comments:"
        '
        'lblPurchaseOrderNbr
        '
        lblPurchaseOrderNbr.AutoSize = True
        lblPurchaseOrderNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPurchaseOrderNbr.Location = New System.Drawing.Point(25, 23)
        lblPurchaseOrderNbr.Name = "lblPurchaseOrderNbr"
        lblPurchaseOrderNbr.Size = New System.Drawing.Size(48, 18)
        lblPurchaseOrderNbr.TabIndex = 67
        lblPurchaseOrderNbr.Text = "PO #:"
        '
        'lblTireQty
        '
        lblTireQty.AutoSize = True
        lblTireQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTireQty.Location = New System.Drawing.Point(25, 119)
        lblTireQty.Name = "lblTireQty"
        lblTireQty.Size = New System.Drawing.Size(76, 18)
        lblTireQty.TabIndex = 75
        lblTireQty.Text = "# of Tires:"
        '
        'lblPoTotal
        '
        lblPoTotal.AutoSize = True
        lblPoTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPoTotal.Location = New System.Drawing.Point(25, 151)
        lblPoTotal.Name = "lblPoTotal"
        lblPoTotal.Size = New System.Drawing.Size(71, 18)
        lblPoTotal.TabIndex = 69
        lblPoTotal.Text = "PO Total:"
        '
        'lblTireCode
        '
        lblTireCode.AutoSize = True
        lblTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTireCode.Location = New System.Drawing.Point(25, 87)
        lblTireCode.Name = "lblTireCode"
        lblTireCode.Size = New System.Drawing.Size(81, 18)
        lblTireCode.TabIndex = 73
        lblTireCode.Text = "Tire Code:"
        '
        'lblPODate
        '
        lblPODate.AutoSize = True
        lblPODate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPODate.Location = New System.Drawing.Point(348, 23)
        lblPODate.Name = "lblPODate"
        lblPODate.Size = New System.Drawing.Size(73, 18)
        lblPODate.TabIndex = 71
        lblPODate.Text = "PO Date:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(592, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 480)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 26
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSalesDate)
        Me.GroupBox1.Controls.Add(Me.btnSaveComments)
        Me.GroupBox1.Controls.Add(Me.txtDealerID)
        Me.GroupBox1.Controls.Add(lblVendorID)
        Me.GroupBox1.Controls.Add(Me.txtComment)
        Me.GroupBox1.Controls.Add(lblComments)
        Me.GroupBox1.Controls.Add(lblPurchaseOrderNbr)
        Me.GroupBox1.Controls.Add(Me.txtWhlslOrderTotal)
        Me.GroupBox1.Controls.Add(Me.txtWhlslOrderNbr)
        Me.GroupBox1.Controls.Add(lblTireQty)
        Me.GroupBox1.Controls.Add(lblPoTotal)
        Me.GroupBox1.Controls.Add(Me.txtTireQty)
        Me.GroupBox1.Controls.Add(lblTireCode)
        Me.GroupBox1.Controls.Add(lblPODate)
        Me.GroupBox1.Controls.Add(Me.txtTireCode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 205)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        '
        'txtSalesDate
        '
        Me.txtSalesDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "poTotal", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtSalesDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesDate.Location = New System.Drawing.Point(121, 147)
        Me.txtSalesDate.Name = "txtSalesDate"
        Me.txtSalesDate.ReadOnly = True
        Me.txtSalesDate.Size = New System.Drawing.Size(199, 26)
        Me.txtSalesDate.TabIndex = 83
        '
        'PurchaseOrderBindingSource
        '
        Me.PurchaseOrderBindingSource.DataMember = "purchaseOrder"
        Me.PurchaseOrderBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSaveComments
        '
        Me.btnSaveComments.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveComments.Location = New System.Drawing.Point(470, 159)
        Me.btnSaveComments.Name = "btnSaveComments"
        Me.btnSaveComments.Size = New System.Drawing.Size(137, 30)
        Me.btnSaveComments.TabIndex = 82
        Me.btnSaveComments.Text = "Save Comments"
        Me.btnSaveComments.UseVisualStyleBackColor = True
        '
        'txtDealerID
        '
        Me.txtDealerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "poNbr", True))
        Me.txtDealerID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerID.Location = New System.Drawing.Point(120, 19)
        Me.txtDealerID.Name = "txtDealerID"
        Me.txtDealerID.ReadOnly = True
        Me.txtDealerID.Size = New System.Drawing.Size(200, 26)
        Me.txtDealerID.TabIndex = 66
        '
        'txtComment
        '
        Me.txtComment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "comments", True))
        Me.txtComment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(443, 51)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(200, 96)
        Me.txtComment.TabIndex = 80
        '
        'txtWhlslOrderTotal
        '
        Me.txtWhlslOrderTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "tireQty", True))
        Me.txtWhlslOrderTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhlslOrderTotal.Location = New System.Drawing.Point(120, 115)
        Me.txtWhlslOrderTotal.Name = "txtWhlslOrderTotal"
        Me.txtWhlslOrderTotal.ReadOnly = True
        Me.txtWhlslOrderTotal.Size = New System.Drawing.Size(200, 26)
        Me.txtWhlslOrderTotal.TabIndex = 76
        '
        'txtWhlslOrderNbr
        '
        Me.txtWhlslOrderNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "vendorID", True))
        Me.txtWhlslOrderNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhlslOrderNbr.Location = New System.Drawing.Point(120, 51)
        Me.txtWhlslOrderNbr.Name = "txtWhlslOrderNbr"
        Me.txtWhlslOrderNbr.ReadOnly = True
        Me.txtWhlslOrderNbr.Size = New System.Drawing.Size(200, 26)
        Me.txtWhlslOrderNbr.TabIndex = 68
        '
        'txtTireQty
        '
        Me.txtTireQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "tireCode", True))
        Me.txtTireQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireQty.Location = New System.Drawing.Point(120, 83)
        Me.txtTireQty.Name = "txtTireQty"
        Me.txtTireQty.ReadOnly = True
        Me.txtTireQty.Size = New System.Drawing.Size(200, 26)
        Me.txtTireQty.TabIndex = 74
        '
        'txtTireCode
        '
        Me.txtTireCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PurchaseOrderBindingSource, "poDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.txtTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireCode.Location = New System.Drawing.Point(443, 19)
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.ReadOnly = True
        Me.txtTireCode.Size = New System.Drawing.Size(200, 26)
        Me.txtTireCode.TabIndex = 72
        '
        'PurchaseOrderDataGridView
        '
        Me.PurchaseOrderDataGridView.AllowUserToAddRows = False
        Me.PurchaseOrderDataGridView.AllowUserToDeleteRows = False
        Me.PurchaseOrderDataGridView.AutoGenerateColumns = False
        Me.PurchaseOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PurchaseOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PoNbrDataGridViewTextBoxColumn, Me.VendorIDDataGridViewTextBoxColumn, Me.PoDateDataGridViewTextBoxColumn, Me.TireCodeDataGridViewTextBoxColumn, Me.TireQtyDataGridViewTextBoxColumn, Me.PoTotalDataGridViewTextBoxColumn, Me.CommentsDataGridViewTextBoxColumn})
        Me.PurchaseOrderDataGridView.DataSource = Me.PurchaseOrderBindingSource
        Me.PurchaseOrderDataGridView.Location = New System.Drawing.Point(12, 269)
        Me.PurchaseOrderDataGridView.Name = "PurchaseOrderDataGridView"
        Me.PurchaseOrderDataGridView.ReadOnly = True
        Me.PurchaseOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PurchaseOrderDataGridView.Size = New System.Drawing.Size(670, 188)
        Me.PurchaseOrderDataGridView.TabIndex = 83
        '
        'PoNbrDataGridViewTextBoxColumn
        '
        Me.PoNbrDataGridViewTextBoxColumn.DataPropertyName = "poNbr"
        Me.PoNbrDataGridViewTextBoxColumn.HeaderText = "PO #"
        Me.PoNbrDataGridViewTextBoxColumn.Name = "PoNbrDataGridViewTextBoxColumn"
        Me.PoNbrDataGridViewTextBoxColumn.ReadOnly = True
        Me.PoNbrDataGridViewTextBoxColumn.Width = 80
        '
        'VendorIDDataGridViewTextBoxColumn
        '
        Me.VendorIDDataGridViewTextBoxColumn.DataPropertyName = "vendorID"
        Me.VendorIDDataGridViewTextBoxColumn.HeaderText = "Vendor ID"
        Me.VendorIDDataGridViewTextBoxColumn.Name = "VendorIDDataGridViewTextBoxColumn"
        Me.VendorIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.VendorIDDataGridViewTextBoxColumn.Width = 80
        '
        'PoDateDataGridViewTextBoxColumn
        '
        Me.PoDateDataGridViewTextBoxColumn.DataPropertyName = "poDate"
        Me.PoDateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.PoDateDataGridViewTextBoxColumn.Name = "PoDateDataGridViewTextBoxColumn"
        Me.PoDateDataGridViewTextBoxColumn.ReadOnly = True
        Me.PoDateDataGridViewTextBoxColumn.Width = 80
        '
        'TireCodeDataGridViewTextBoxColumn
        '
        Me.TireCodeDataGridViewTextBoxColumn.DataPropertyName = "tireCode"
        Me.TireCodeDataGridViewTextBoxColumn.HeaderText = "Tire Code"
        Me.TireCodeDataGridViewTextBoxColumn.Name = "TireCodeDataGridViewTextBoxColumn"
        Me.TireCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TireCodeDataGridViewTextBoxColumn.Width = 90
        '
        'TireQtyDataGridViewTextBoxColumn
        '
        Me.TireQtyDataGridViewTextBoxColumn.DataPropertyName = "tireQty"
        Me.TireQtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.TireQtyDataGridViewTextBoxColumn.Name = "TireQtyDataGridViewTextBoxColumn"
        Me.TireQtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.TireQtyDataGridViewTextBoxColumn.Width = 80
        '
        'PoTotalDataGridViewTextBoxColumn
        '
        Me.PoTotalDataGridViewTextBoxColumn.DataPropertyName = "poTotal"
        Me.PoTotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.PoTotalDataGridViewTextBoxColumn.Name = "PoTotalDataGridViewTextBoxColumn"
        Me.PoTotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.PoTotalDataGridViewTextBoxColumn.Width = 80
        '
        'CommentsDataGridViewTextBoxColumn
        '
        Me.CommentsDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.CommentsDataGridViewTextBoxColumn.DataPropertyName = "comments"
        Me.CommentsDataGridViewTextBoxColumn.HeaderText = "Comments"
        Me.CommentsDataGridViewTextBoxColumn.Name = "CommentsDataGridViewTextBoxColumn"
        Me.CommentsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnCreateNewOrder
        '
        Me.btnCreateNewOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewOrder.Location = New System.Drawing.Point(115, 480)
        Me.btnCreateNewOrder.Name = "btnCreateNewOrder"
        Me.btnCreateNewOrder.Size = New System.Drawing.Size(150, 30)
        Me.btnCreateNewOrder.TabIndex = 84
        Me.btnCreateNewOrder.Text = "Create New Order"
        Me.btnCreateNewOrder.UseVisualStyleBackColor = True
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(180, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(335, 26)
        Me.lblTitle.TabIndex = 85
        Me.lblTitle.Text = "Purchase Orders - Open Orders"
        '
        'btnReceive
        '
        Me.btnReceive.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceive.Location = New System.Drawing.Point(272, 480)
        Me.btnReceive.Name = "btnReceive"
        Me.btnReceive.Size = New System.Drawing.Size(150, 30)
        Me.btnReceive.TabIndex = 84
        Me.btnReceive.Text = "Receive Tires"
        Me.btnReceive.UseVisualStyleBackColor = True
        '
        'btnReprint
        '
        Me.btnReprint.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReprint.Location = New System.Drawing.Point(429, 480)
        Me.btnReprint.Name = "btnReprint"
        Me.btnReprint.Size = New System.Drawing.Size(150, 30)
        Me.btnReprint.TabIndex = 86
        Me.btnReprint.Text = "Reprint Order"
        Me.btnReprint.UseVisualStyleBackColor = True
        '
        'frmPO2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReprint)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnReceive)
        Me.Controls.Add(Me.btnCreateNewOrder)
        Me.Controls.Add(Me.PurchaseOrderDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPO2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Orders"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PurchaseOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurchaseOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents PurchaseOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PurchaseOrderTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.purchaseOrderTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSalesDate As System.Windows.Forms.TextBox
    Friend WithEvents btnSaveComments As System.Windows.Forms.Button
    Friend WithEvents txtDealerID As System.Windows.Forms.TextBox
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents txtWhlslOrderTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtWhlslOrderNbr As System.Windows.Forms.TextBox
    Friend WithEvents txtTireQty As System.Windows.Forms.TextBox
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents PurchaseOrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents btnCreateNewOrder As System.Windows.Forms.Button
    Friend WithEvents PoNbrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VendorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TireCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TireQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PoTotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnReceive As System.Windows.Forms.Button
    Friend WithEvents btnReprint As System.Windows.Forms.Button
End Class
