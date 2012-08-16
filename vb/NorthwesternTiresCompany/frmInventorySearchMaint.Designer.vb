<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventorySearchMaint
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
        Dim TireCodeLabel As System.Windows.Forms.Label
        Dim ManufacturerLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim ManufacturerSizeLabel As System.Windows.Forms.Label
        Dim RetailPriceLabel As System.Windows.Forms.Label
        Dim TireQtyLabel As System.Windows.Forms.Label
        Dim StoreNbrLabel As System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblStep1 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TireCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManufacturerSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RetailPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TireQtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StoreNbrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InventoryNbrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.Comp4002012DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblStep2 = New System.Windows.Forms.Label()
        Me.InvSearchTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtManufacturerSize = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.txtTireQty = New System.Windows.Forms.TextBox()
        Me.txtStoreNbr = New System.Windows.Forms.TextBox()
        Me.cboStore = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateQty = New System.Windows.Forms.Button()
        Me.InventoryTableAdapter1 = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.inventoryTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StoreTableAdapter1 = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter()
        Me.btnStoreTransfer = New System.Windows.Forms.Button()
        TireCodeLabel = New System.Windows.Forms.Label()
        ManufacturerLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        ManufacturerSizeLabel = New System.Windows.Forms.Label()
        RetailPriceLabel = New System.Windows.Forms.Label()
        TireQtyLabel = New System.Windows.Forms.Label()
        StoreNbrLabel = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comp4002012DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TireCodeLabel
        '
        TireCodeLabel.AutoSize = True
        TireCodeLabel.Location = New System.Drawing.Point(418, 307)
        TireCodeLabel.Name = "TireCodeLabel"
        TireCodeLabel.Size = New System.Drawing.Size(56, 13)
        TireCodeLabel.TabIndex = 28
        TireCodeLabel.Text = "Tire Code:"
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Location = New System.Drawing.Point(50, 307)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(73, 13)
        ManufacturerLabel.TabIndex = 30
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(50, 359)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 32
        DescriptionLabel.Text = "Description:"
        '
        'ManufacturerSizeLabel
        '
        ManufacturerSizeLabel.AutoSize = True
        ManufacturerSizeLabel.Location = New System.Drawing.Point(50, 333)
        ManufacturerSizeLabel.Name = "ManufacturerSizeLabel"
        ManufacturerSizeLabel.Size = New System.Drawing.Size(51, 13)
        ManufacturerSizeLabel.TabIndex = 34
        ManufacturerSizeLabel.Text = "Tire Size:"
        '
        'RetailPriceLabel
        '
        RetailPriceLabel.AutoSize = True
        RetailPriceLabel.Location = New System.Drawing.Point(418, 333)
        RetailPriceLabel.Name = "RetailPriceLabel"
        RetailPriceLabel.Size = New System.Drawing.Size(34, 13)
        RetailPriceLabel.TabIndex = 36
        RetailPriceLabel.Text = "Price:"
        '
        'TireQtyLabel
        '
        TireQtyLabel.AutoSize = True
        TireQtyLabel.Location = New System.Drawing.Point(418, 359)
        TireQtyLabel.Name = "TireQtyLabel"
        TireQtyLabel.Size = New System.Drawing.Size(49, 13)
        TireQtyLabel.TabIndex = 38
        TireQtyLabel.Text = "Quantity:"
        '
        'StoreNbrLabel
        '
        StoreNbrLabel.AutoSize = True
        StoreNbrLabel.Location = New System.Drawing.Point(418, 385)
        StoreNbrLabel.Name = "StoreNbrLabel"
        StoreNbrLabel.Size = New System.Drawing.Size(75, 13)
        StoreNbrLabel.TabIndex = 40
        StoreNbrLabel.Text = "Store Number:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(245, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(195, 24)
        Me.lblTitle.TabIndex = 19
        Me.lblTitle.Text = "Inventory Maintain"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(579, 470)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 470)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 64)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(261, 26)
        Me.txtSearch.TabIndex = 1
        '
        'lblStep1
        '
        Me.lblStep1.AutoSize = True
        Me.lblStep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep1.Location = New System.Drawing.Point(40, 42)
        Me.lblStep1.Name = "lblStep1"
        Me.lblStep1.Size = New System.Drawing.Size(303, 17)
        Me.lblStep1.TabIndex = 25
        Me.lblStep1.Text = "Step 1: Type keyword or tire size to get started"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(279, 62)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TireCodeDataGridViewTextBoxColumn, Me.ManufacturerDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.ManufacturerSizeDataGridViewTextBoxColumn, Me.RetailPriceDataGridViewTextBoxColumn, Me.TireQtyDataGridViewTextBoxColumn, Me.StoreNbrDataGridViewTextBoxColumn, Me.InventoryNbrDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.InvSearchBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 126)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(660, 172)
        Me.DataGridView1.TabIndex = 3
        '
        'TireCodeDataGridViewTextBoxColumn
        '
        Me.TireCodeDataGridViewTextBoxColumn.DataPropertyName = "tireCode"
        Me.TireCodeDataGridViewTextBoxColumn.HeaderText = "Tire Code"
        Me.TireCodeDataGridViewTextBoxColumn.Name = "TireCodeDataGridViewTextBoxColumn"
        Me.TireCodeDataGridViewTextBoxColumn.ReadOnly = True
        Me.TireCodeDataGridViewTextBoxColumn.Width = 80
        '
        'ManufacturerDataGridViewTextBoxColumn
        '
        Me.ManufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.HeaderText = "Manufacturer"
        Me.ManufacturerDataGridViewTextBoxColumn.Name = "ManufacturerDataGridViewTextBoxColumn"
        Me.ManufacturerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 162
        '
        'ManufacturerSizeDataGridViewTextBoxColumn
        '
        Me.ManufacturerSizeDataGridViewTextBoxColumn.DataPropertyName = "manufacturerSize"
        Me.ManufacturerSizeDataGridViewTextBoxColumn.HeaderText = "Tire Size"
        Me.ManufacturerSizeDataGridViewTextBoxColumn.Name = "ManufacturerSizeDataGridViewTextBoxColumn"
        Me.ManufacturerSizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.ManufacturerSizeDataGridViewTextBoxColumn.Width = 75
        '
        'RetailPriceDataGridViewTextBoxColumn
        '
        Me.RetailPriceDataGridViewTextBoxColumn.DataPropertyName = "retailPrice"
        Me.RetailPriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.RetailPriceDataGridViewTextBoxColumn.Name = "RetailPriceDataGridViewTextBoxColumn"
        Me.RetailPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.RetailPriceDataGridViewTextBoxColumn.Width = 70
        '
        'TireQtyDataGridViewTextBoxColumn
        '
        Me.TireQtyDataGridViewTextBoxColumn.DataPropertyName = "tireQty"
        Me.TireQtyDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.TireQtyDataGridViewTextBoxColumn.Name = "TireQtyDataGridViewTextBoxColumn"
        Me.TireQtyDataGridViewTextBoxColumn.ReadOnly = True
        Me.TireQtyDataGridViewTextBoxColumn.Width = 70
        '
        'StoreNbrDataGridViewTextBoxColumn
        '
        Me.StoreNbrDataGridViewTextBoxColumn.DataPropertyName = "storeNbr"
        Me.StoreNbrDataGridViewTextBoxColumn.HeaderText = "Store"
        Me.StoreNbrDataGridViewTextBoxColumn.Name = "StoreNbrDataGridViewTextBoxColumn"
        Me.StoreNbrDataGridViewTextBoxColumn.ReadOnly = True
        Me.StoreNbrDataGridViewTextBoxColumn.Width = 60
        '
        'InventoryNbrDataGridViewTextBoxColumn
        '
        Me.InventoryNbrDataGridViewTextBoxColumn.DataPropertyName = "inventoryNbr"
        Me.InventoryNbrDataGridViewTextBoxColumn.HeaderText = "inventoryNbr"
        Me.InventoryNbrDataGridViewTextBoxColumn.Name = "InventoryNbrDataGridViewTextBoxColumn"
        Me.InventoryNbrDataGridViewTextBoxColumn.ReadOnly = True
        Me.InventoryNbrDataGridViewTextBoxColumn.Visible = False
        '
        'InvSearchBindingSource
        '
        Me.InvSearchBindingSource.DataMember = "invSearch"
        Me.InvSearchBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Comp4002012DataSetBindingSource
        '
        Me.Comp4002012DataSetBindingSource.DataSource = Me.Comp400_2012DataSet
        Me.Comp4002012DataSetBindingSource.Position = 0
        '
        'lblStep2
        '
        Me.lblStep2.AutoSize = True
        Me.lblStep2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStep2.Location = New System.Drawing.Point(246, 106)
        Me.lblStep2.Name = "lblStep2"
        Me.lblStep2.Size = New System.Drawing.Size(193, 17)
        Me.lblStep2.TabIndex = 28
        Me.lblStep2.Text = "Step 2: Click line to select tire"
        '
        'InvSearchTableAdapter
        '
        Me.InvSearchTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'txtTireCode
        '
        Me.txtTireCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "tireCode", True))
        Me.txtTireCode.Location = New System.Drawing.Point(519, 304)
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.ReadOnly = True
        Me.txtTireCode.Size = New System.Drawing.Size(100, 20)
        Me.txtTireCode.TabIndex = 4
        '
        'txtManufacturer
        '
        Me.txtManufacturer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "manufacturer", True))
        Me.txtManufacturer.Location = New System.Drawing.Point(151, 304)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.ReadOnly = True
        Me.txtManufacturer.Size = New System.Drawing.Size(192, 20)
        Me.txtManufacturer.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "description", True))
        Me.txtDescription.Location = New System.Drawing.Point(151, 356)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(192, 67)
        Me.txtDescription.TabIndex = 7
        '
        'txtManufacturerSize
        '
        Me.txtManufacturerSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "manufacturerSize", True))
        Me.txtManufacturerSize.Location = New System.Drawing.Point(151, 330)
        Me.txtManufacturerSize.Name = "txtManufacturerSize"
        Me.txtManufacturerSize.ReadOnly = True
        Me.txtManufacturerSize.Size = New System.Drawing.Size(192, 20)
        Me.txtManufacturerSize.TabIndex = 6
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "retailPrice", True))
        Me.txtRetailPrice.Location = New System.Drawing.Point(519, 330)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.ReadOnly = True
        Me.txtRetailPrice.Size = New System.Drawing.Size(100, 20)
        Me.txtRetailPrice.TabIndex = 8
        '
        'txtTireQty
        '
        Me.txtTireQty.CausesValidation = False
        Me.txtTireQty.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "tireQty", True))
        Me.txtTireQty.Location = New System.Drawing.Point(519, 356)
        Me.txtTireQty.Name = "txtTireQty"
        Me.txtTireQty.Size = New System.Drawing.Size(74, 20)
        Me.txtTireQty.TabIndex = 9
        '
        'txtStoreNbr
        '
        Me.txtStoreNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "storeNbr", True))
        Me.txtStoreNbr.Location = New System.Drawing.Point(519, 382)
        Me.txtStoreNbr.Name = "txtStoreNbr"
        Me.txtStoreNbr.ReadOnly = True
        Me.txtStoreNbr.Size = New System.Drawing.Size(100, 20)
        Me.txtStoreNbr.TabIndex = 10
        '
        'cboStore
        '
        Me.cboStore.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStore.FormattingEnabled = True
        Me.cboStore.Location = New System.Drawing.Point(508, 69)
        Me.cboStore.Name = "cboStore"
        Me.cboStore.Size = New System.Drawing.Size(161, 24)
        Me.cboStore.TabIndex = 43
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Store Number:"
        '
        'btnUpdateQty
        '
        Me.btnUpdateQty.Location = New System.Drawing.Point(605, 354)
        Me.btnUpdateQty.Name = "btnUpdateQty"
        Me.btnUpdateQty.Size = New System.Drawing.Size(64, 23)
        Me.btnUpdateQty.TabIndex = 45
        Me.btnUpdateQty.Text = "Update"
        Me.btnUpdateQty.UseVisualStyleBackColor = True
        '
        'InventoryTableAdapter1
        '
        Me.InventoryTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(397, 417)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 17)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Step 3: Change Quantity and click Update"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(426, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(235, 17)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "(Optional) Choose the store number"
        '
        'StoreTableAdapter1
        '
        Me.StoreTableAdapter1.ClearBeforeFill = True
        '
        'btnStoreTransfer
        '
        Me.btnStoreTransfer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStoreTransfer.Location = New System.Drawing.Point(262, 470)
        Me.btnStoreTransfer.Name = "btnStoreTransfer"
        Me.btnStoreTransfer.Size = New System.Drawing.Size(150, 30)
        Me.btnStoreTransfer.TabIndex = 48
        Me.btnStoreTransfer.Text = "Store Transfer"
        Me.btnStoreTransfer.UseVisualStyleBackColor = True
        '
        'frmInventorySearchMaint
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 512)
        Me.Controls.Add(Me.btnStoreTransfer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnUpdateQty)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboStore)
        Me.Controls.Add(TireCodeLabel)
        Me.Controls.Add(Me.txtTireCode)
        Me.Controls.Add(ManufacturerLabel)
        Me.Controls.Add(Me.txtManufacturer)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(ManufacturerSizeLabel)
        Me.Controls.Add(Me.txtManufacturerSize)
        Me.Controls.Add(RetailPriceLabel)
        Me.Controls.Add(Me.txtRetailPrice)
        Me.Controls.Add(TireQtyLabel)
        Me.Controls.Add(Me.txtTireQty)
        Me.Controls.Add(StoreNbrLabel)
        Me.Controls.Add(Me.txtStoreNbr)
        Me.Controls.Add(Me.lblStep2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblStep1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmInventorySearchMaint"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Maintain"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comp4002012DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblStep1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Comp4002012DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents InvSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvSearchTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter
    Friend WithEvents lblStep2 As System.Windows.Forms.Label
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents TireCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManufacturerSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RetailPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TireQtyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StoreNbrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InventoryNbrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvSearchBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturerSize As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtTireQty As System.Windows.Forms.TextBox
    Friend WithEvents txtStoreNbr As System.Windows.Forms.TextBox
    Friend WithEvents cboStore As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnUpdateQty As System.Windows.Forms.Button
    Friend WithEvents InventoryTableAdapter1 As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents StoreTableAdapter1 As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter
    Friend WithEvents btnStoreTransfer As System.Windows.Forms.Button
End Class
