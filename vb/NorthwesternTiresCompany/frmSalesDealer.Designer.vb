<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesDealer
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
        Dim lblDealerID As System.Windows.Forms.Label
        Dim lblWhlslOrderNbr As System.Windows.Forms.Label
        Dim lblSalesDate As System.Windows.Forms.Label
        Dim lblTireCode As System.Windows.Forms.Label
        Dim lblTireQty As System.Windows.Forms.Label
        Dim lblWhlslOrderTotal As System.Windows.Forms.Label
        Dim lblComments As System.Windows.Forms.Label
        Me.lblDealers = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.WholesaleOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WholesaleOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WholesaleOrderTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.wholesaleOrderTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtDealerID = New System.Windows.Forms.TextBox()
        Me.DealerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comp400_2012DataSet1 = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.txtWhlslOrderNbr = New System.Windows.Forms.TextBox()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.txtTireQty = New System.Windows.Forms.TextBox()
        Me.txtWhlslOrderTotal = New System.Windows.Forms.TextBox()
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSalesDate = New System.Windows.Forms.TextBox()
        Me.btnSaveComments = New System.Windows.Forms.Button()
        Me.btnCloseOrder = New System.Windows.Forms.Button()
        Me.btnCreateNewOrder = New System.Windows.Forms.Button()
        Me.DealerTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.dealerTableAdapter()
        lblDealerID = New System.Windows.Forms.Label()
        lblWhlslOrderNbr = New System.Windows.Forms.Label()
        lblSalesDate = New System.Windows.Forms.Label()
        lblTireCode = New System.Windows.Forms.Label()
        lblTireQty = New System.Windows.Forms.Label()
        lblWhlslOrderTotal = New System.Windows.Forms.Label()
        lblComments = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WholesaleOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WholesaleOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comp400_2012DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDealerID
        '
        lblDealerID.AutoSize = True
        lblDealerID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerID.Location = New System.Drawing.Point(26, 22)
        lblDealerID.Name = "lblDealerID"
        lblDealerID.Size = New System.Drawing.Size(78, 18)
        lblDealerID.TabIndex = 65
        lblDealerID.Text = "Dealer ID:"
        '
        'lblWhlslOrderNbr
        '
        lblWhlslOrderNbr.AutoSize = True
        lblWhlslOrderNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWhlslOrderNbr.Location = New System.Drawing.Point(26, 54)
        lblWhlslOrderNbr.Name = "lblWhlslOrderNbr"
        lblWhlslOrderNbr.Size = New System.Drawing.Size(65, 18)
        lblWhlslOrderNbr.TabIndex = 67
        lblWhlslOrderNbr.Text = "Order #:"
        '
        'lblSalesDate
        '
        lblSalesDate.AutoSize = True
        lblSalesDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblSalesDate.Location = New System.Drawing.Point(348, 23)
        lblSalesDate.Name = "lblSalesDate"
        lblSalesDate.Size = New System.Drawing.Size(90, 18)
        lblSalesDate.TabIndex = 69
        lblSalesDate.Text = "Sales Date:"
        '
        'lblTireCode
        '
        lblTireCode.AutoSize = True
        lblTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTireCode.Location = New System.Drawing.Point(26, 86)
        lblTireCode.Name = "lblTireCode"
        lblTireCode.Size = New System.Drawing.Size(81, 18)
        lblTireCode.TabIndex = 71
        lblTireCode.Text = "Tire Code:"
        '
        'lblTireQty
        '
        lblTireQty.AutoSize = True
        lblTireQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTireQty.Location = New System.Drawing.Point(26, 118)
        lblTireQty.Name = "lblTireQty"
        lblTireQty.Size = New System.Drawing.Size(68, 18)
        lblTireQty.TabIndex = 73
        lblTireQty.Text = "Quantity:"
        '
        'lblWhlslOrderTotal
        '
        lblWhlslOrderTotal.AutoSize = True
        lblWhlslOrderTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWhlslOrderTotal.Location = New System.Drawing.Point(26, 150)
        lblWhlslOrderTotal.Name = "lblWhlslOrderTotal"
        lblWhlslOrderTotal.Size = New System.Drawing.Size(88, 18)
        lblWhlslOrderTotal.TabIndex = 75
        lblWhlslOrderTotal.Text = "Order Total:"
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
        'lblDealers
        '
        Me.lblDealers.AutoSize = True
        Me.lblDealers.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDealers.Location = New System.Drawing.Point(286, 9)
        Me.lblDealers.Name = "lblDealers"
        Me.lblDealers.Size = New System.Drawing.Size(123, 24)
        Me.lblDealers.TabIndex = 18
        Me.lblDealers.Text = "Dealer Sale"
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WholesaleOrderDataGridView
        '
        Me.WholesaleOrderDataGridView.AllowUserToAddRows = False
        Me.WholesaleOrderDataGridView.AllowUserToDeleteRows = False
        Me.WholesaleOrderDataGridView.AutoGenerateColumns = False
        Me.WholesaleOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WholesaleOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn7})
        Me.WholesaleOrderDataGridView.DataSource = Me.WholesaleOrderBindingSource
        Me.WholesaleOrderDataGridView.Location = New System.Drawing.Point(12, 251)
        Me.WholesaleOrderDataGridView.Name = "WholesaleOrderDataGridView"
        Me.WholesaleOrderDataGridView.ReadOnly = True
        Me.WholesaleOrderDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.WholesaleOrderDataGridView.Size = New System.Drawing.Size(670, 206)
        Me.WholesaleOrderDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "whlslOrderNbr"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Order #"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "dealerID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Dealer ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "salesDate"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tireCode"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tire Code"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tireQty"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "whlslOrderTotal"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Order Total"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 85
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "isClosed"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Closed"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.ReadOnly = True
        Me.DataGridViewCheckBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "comments"
        Me.DataGridViewTextBoxColumn7.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Comments"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'WholesaleOrderBindingSource
        '
        Me.WholesaleOrderBindingSource.DataMember = "wholesaleOrder"
        Me.WholesaleOrderBindingSource.DataSource = Me.Comp400_2012DataSet
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
        Me.TableAdapterManager.purchaseOrderDetailTableAdapter = Nothing
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
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(203, 11)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(289, 26)
        Me.lblTitle.TabIndex = 63
        Me.lblTitle.Text = "Dealer Sales - Open Orders"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(592, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 65
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
        Me.btnBack.TabIndex = 64
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtDealerID
        '
        Me.txtDealerID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WholesaleOrderBindingSource, "dealerID", True))
        Me.txtDealerID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerID.Location = New System.Drawing.Point(120, 19)
        Me.txtDealerID.Name = "txtDealerID"
        Me.txtDealerID.ReadOnly = True
        Me.txtDealerID.Size = New System.Drawing.Size(200, 26)
        Me.txtDealerID.TabIndex = 66
        '
        'DealerBindingSource
        '
        Me.DealerBindingSource.DataMember = "dealer"
        Me.DealerBindingSource.DataSource = Me.Comp400_2012DataSet1
        '
        'Comp400_2012DataSet1
        '
        Me.Comp400_2012DataSet1.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtWhlslOrderNbr
        '
        Me.txtWhlslOrderNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WholesaleOrderBindingSource, "whlslOrderNbr", True))
        Me.txtWhlslOrderNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhlslOrderNbr.Location = New System.Drawing.Point(120, 51)
        Me.txtWhlslOrderNbr.Name = "txtWhlslOrderNbr"
        Me.txtWhlslOrderNbr.ReadOnly = True
        Me.txtWhlslOrderNbr.Size = New System.Drawing.Size(200, 26)
        Me.txtWhlslOrderNbr.TabIndex = 68
        '
        'txtTireCode
        '
        Me.txtTireCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WholesaleOrderBindingSource, "tireCode", True))
        Me.txtTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireCode.Location = New System.Drawing.Point(120, 83)
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.ReadOnly = True
        Me.txtTireCode.Size = New System.Drawing.Size(200, 26)
        Me.txtTireCode.TabIndex = 72
        '
        'txtTireQty
        '
        Me.txtTireQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WholesaleOrderBindingSource, "tireQty", True))
        Me.txtTireQty.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireQty.Location = New System.Drawing.Point(120, 115)
        Me.txtTireQty.Name = "txtTireQty"
        Me.txtTireQty.ReadOnly = True
        Me.txtTireQty.Size = New System.Drawing.Size(200, 26)
        Me.txtTireQty.TabIndex = 74
        '
        'txtWhlslOrderTotal
        '
        Me.txtWhlslOrderTotal.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WholesaleOrderBindingSource, "whlslOrderTotal", True))
        Me.txtWhlslOrderTotal.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWhlslOrderTotal.Location = New System.Drawing.Point(120, 147)
        Me.txtWhlslOrderTotal.Name = "txtWhlslOrderTotal"
        Me.txtWhlslOrderTotal.ReadOnly = True
        Me.txtWhlslOrderTotal.Size = New System.Drawing.Size(200, 26)
        Me.txtWhlslOrderTotal.TabIndex = 76
        '
        'txtComment
        '
        Me.txtComment.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WholesaleOrderBindingSource, "comments", True))
        Me.txtComment.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComment.Location = New System.Drawing.Point(443, 51)
        Me.txtComment.Multiline = True
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(200, 96)
        Me.txtComment.TabIndex = 80
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSalesDate)
        Me.GroupBox1.Controls.Add(Me.btnSaveComments)
        Me.GroupBox1.Controls.Add(Me.btnCloseOrder)
        Me.GroupBox1.Controls.Add(Me.txtDealerID)
        Me.GroupBox1.Controls.Add(lblDealerID)
        Me.GroupBox1.Controls.Add(Me.txtComment)
        Me.GroupBox1.Controls.Add(lblComments)
        Me.GroupBox1.Controls.Add(lblWhlslOrderNbr)
        Me.GroupBox1.Controls.Add(Me.txtWhlslOrderTotal)
        Me.GroupBox1.Controls.Add(Me.txtWhlslOrderNbr)
        Me.GroupBox1.Controls.Add(lblWhlslOrderTotal)
        Me.GroupBox1.Controls.Add(lblSalesDate)
        Me.GroupBox1.Controls.Add(Me.txtTireQty)
        Me.GroupBox1.Controls.Add(lblTireQty)
        Me.GroupBox1.Controls.Add(lblTireCode)
        Me.GroupBox1.Controls.Add(Me.txtTireCode)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(670, 205)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'txtSalesDate
        '
        Me.txtSalesDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WholesaleOrderBindingSource, "salesDate", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "d"))
        Me.txtSalesDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSalesDate.Location = New System.Drawing.Point(444, 19)
        Me.txtSalesDate.Name = "txtSalesDate"
        Me.txtSalesDate.ReadOnly = True
        Me.txtSalesDate.Size = New System.Drawing.Size(199, 26)
        Me.txtSalesDate.TabIndex = 83
        '
        'btnSaveComments
        '
        Me.btnSaveComments.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveComments.Location = New System.Drawing.Point(506, 161)
        Me.btnSaveComments.Name = "btnSaveComments"
        Me.btnSaveComments.Size = New System.Drawing.Size(137, 30)
        Me.btnSaveComments.TabIndex = 82
        Me.btnSaveComments.Text = "Save Comments"
        Me.btnSaveComments.UseVisualStyleBackColor = True
        '
        'btnCloseOrder
        '
        Me.btnCloseOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseOrder.Location = New System.Drawing.Point(343, 161)
        Me.btnCloseOrder.Name = "btnCloseOrder"
        Me.btnCloseOrder.Size = New System.Drawing.Size(137, 30)
        Me.btnCloseOrder.TabIndex = 82
        Me.btnCloseOrder.Text = "Close This Order"
        Me.btnCloseOrder.UseVisualStyleBackColor = True
        '
        'btnCreateNewOrder
        '
        Me.btnCreateNewOrder.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateNewOrder.Location = New System.Drawing.Point(255, 480)
        Me.btnCreateNewOrder.Name = "btnCreateNewOrder"
        Me.btnCreateNewOrder.Size = New System.Drawing.Size(184, 30)
        Me.btnCreateNewOrder.TabIndex = 82
        Me.btnCreateNewOrder.Text = "Create New Order"
        Me.btnCreateNewOrder.UseVisualStyleBackColor = True
        '
        'DealerTableAdapter
        '
        Me.DealerTableAdapter.ClearBeforeFill = True
        '
        'frmSalesDealer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCreateNewOrder)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.WholesaleOrderDataGridView)
        Me.Controls.Add(Me.lblDealers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesDealer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dealer Sale"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WholesaleOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WholesaleOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comp400_2012DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDealers As System.Windows.Forms.Label
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents WholesaleOrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WholesaleOrderTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.wholesaleOrderTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents WholesaleOrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtDealerID As System.Windows.Forms.TextBox
    Friend WithEvents txtWhlslOrderNbr As System.Windows.Forms.TextBox
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents txtTireQty As System.Windows.Forms.TextBox
    Friend WithEvents txtWhlslOrderTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtComment As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreateNewOrder As System.Windows.Forms.Button
    Friend WithEvents btnCloseOrder As System.Windows.Forms.Button
    Friend WithEvents btnSaveComments As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtSalesDate As System.Windows.Forms.TextBox
    Friend WithEvents Comp400_2012DataSet1 As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents DealerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DealerTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.dealerTableAdapter
End Class
