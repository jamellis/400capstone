<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTires
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
        Dim lblTireCode As System.Windows.Forms.Label
        Dim lblManufacturer As System.Windows.Forms.Label
        Dim lblWholesaleCost As System.Windows.Forms.Label
        Dim lblDealerPrice As System.Windows.Forms.Label
        Dim lblRetailPrice As System.Windows.Forms.Label
        Dim lblDescription As System.Windows.Forms.Label
        Dim lblTireSize As System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.TireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TireTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.tireTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.TireDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dealerPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wholesaleCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.grpTireDetails = New System.Windows.Forms.GroupBox()
        Me.txtTireSize = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtWholesaleCost = New System.Windows.Forms.TextBox()
        Me.txtDealerPrice = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        lblTireCode = New System.Windows.Forms.Label()
        lblManufacturer = New System.Windows.Forms.Label()
        lblWholesaleCost = New System.Windows.Forms.Label()
        lblDealerPrice = New System.Windows.Forms.Label()
        lblRetailPrice = New System.Windows.Forms.Label()
        lblDescription = New System.Windows.Forms.Label()
        lblTireSize = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TireDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTireDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTireCode
        '
        lblTireCode.AutoSize = True
        lblTireCode.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTireCode.Location = New System.Drawing.Point(19, 27)
        lblTireCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblTireCode.Name = "lblTireCode"
        lblTireCode.Size = New System.Drawing.Size(85, 19)
        lblTireCode.TabIndex = 2
        lblTireCode.Text = "Tire Code:"
        '
        'lblManufacturer
        '
        lblManufacturer.AutoSize = True
        lblManufacturer.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblManufacturer.Location = New System.Drawing.Point(17, 63)
        lblManufacturer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblManufacturer.Name = "lblManufacturer"
        lblManufacturer.Size = New System.Drawing.Size(111, 19)
        lblManufacturer.TabIndex = 15
        lblManufacturer.Text = "Manufacturer:"
        '
        'lblWholesaleCost
        '
        lblWholesaleCost.AutoSize = True
        lblWholesaleCost.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWholesaleCost.Location = New System.Drawing.Point(395, 97)
        lblWholesaleCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblWholesaleCost.Name = "lblWholesaleCost"
        lblWholesaleCost.Size = New System.Drawing.Size(128, 19)
        lblWholesaleCost.TabIndex = 22
        lblWholesaleCost.Text = "Wholesale Cost:"
        '
        'lblDealerPrice
        '
        lblDealerPrice.AutoSize = True
        lblDealerPrice.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerPrice.Location = New System.Drawing.Point(395, 63)
        lblDealerPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDealerPrice.Name = "lblDealerPrice"
        lblDealerPrice.Size = New System.Drawing.Size(106, 19)
        lblDealerPrice.TabIndex = 21
        lblDealerPrice.Text = "Dealer Price:"
        '
        'lblRetailPrice
        '
        lblRetailPrice.AutoSize = True
        lblRetailPrice.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblRetailPrice.Location = New System.Drawing.Point(395, 27)
        lblRetailPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblRetailPrice.Name = "lblRetailPrice"
        lblRetailPrice.Size = New System.Drawing.Size(98, 19)
        lblRetailPrice.TabIndex = 20
        lblRetailPrice.Text = "Retail Price:"
        '
        'lblDescription
        '
        lblDescription.AutoSize = True
        lblDescription.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDescription.Location = New System.Drawing.Point(19, 134)
        lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New System.Drawing.Size(97, 19)
        lblDescription.TabIndex = 24
        lblDescription.Text = "Description:"
        '
        'lblTireSize
        '
        lblTireSize.AutoSize = True
        lblTireSize.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTireSize.Location = New System.Drawing.Point(19, 97)
        lblTireSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblTireSize.Name = "lblTireSize"
        lblTireSize.Size = New System.Drawing.Size(78, 19)
        lblTireSize.TabIndex = 23
        lblTireSize.Text = "Tire Size:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(803, 591)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 37)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(16, 591)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 37)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(420, 11)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(82, 32)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "Tires"
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TireBindingSource
        '
        Me.TireBindingSource.DataMember = "tire"
        Me.TireBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'TireTableAdapter
        '
        Me.TireTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.tireTableAdapter = Me.TireTableAdapter
        Me.TableAdapterManager.transferOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendorTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'TireDataGridView
        '
        Me.TireDataGridView.AllowUserToAddRows = False
        Me.TireDataGridView.AllowUserToDeleteRows = False
        Me.TireDataGridView.AutoGenerateColumns = False
        Me.TireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TireDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn6, Me.dealerPrice, Me.wholesaleCost})
        Me.TireDataGridView.DataSource = Me.TireBindingSource
        Me.TireDataGridView.Location = New System.Drawing.Point(16, 325)
        Me.TireDataGridView.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TireDataGridView.Name = "TireDataGridView"
        Me.TireDataGridView.ReadOnly = True
        Me.TireDataGridView.RowTemplate.Height = 24
        Me.TireDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TireDataGridView.Size = New System.Drawing.Size(893, 258)
        Me.TireDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tireCode"
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tire Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "manufacturer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Manufacturer"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "manufacturerSize"
        Me.DataGridViewTextBoxColumn4.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tire Size"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn2.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "retailPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Retail Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'dealerPrice
        '
        Me.dealerPrice.DataPropertyName = "dealerPrice"
        Me.dealerPrice.HeaderText = "Dealer Price"
        Me.dealerPrice.Name = "dealerPrice"
        Me.dealerPrice.ReadOnly = True
        Me.dealerPrice.Width = 80
        '
        'wholesaleCost
        '
        Me.wholesaleCost.DataPropertyName = "wholesaleCost"
        Me.wholesaleCost.HeaderText = "Wholesale Cost"
        Me.wholesaleCost.Name = "wholesaleCost"
        Me.wholesaleCost.ReadOnly = True
        Me.wholesaleCost.Width = 80
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(377, 279)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(171, 37)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(735, 279)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(171, 37)
        Me.btnCancel.TabIndex = 38
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(556, 279)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(171, 37)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(199, 279)
        Me.btnModify.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(171, 37)
        Me.btnModify.TabIndex = 35
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(20, 279)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(171, 37)
        Me.btnAdd.TabIndex = 34
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'grpTireDetails
        '
        Me.grpTireDetails.Controls.Add(Me.txtTireSize)
        Me.grpTireDetails.Controls.Add(Me.txtDescription)
        Me.grpTireDetails.Controls.Add(lblDescription)
        Me.grpTireDetails.Controls.Add(lblTireSize)
        Me.grpTireDetails.Controls.Add(Me.txtWholesaleCost)
        Me.grpTireDetails.Controls.Add(Me.txtDealerPrice)
        Me.grpTireDetails.Controls.Add(Me.txtRetailPrice)
        Me.grpTireDetails.Controls.Add(lblWholesaleCost)
        Me.grpTireDetails.Controls.Add(lblDealerPrice)
        Me.grpTireDetails.Controls.Add(lblRetailPrice)
        Me.grpTireDetails.Controls.Add(lblManufacturer)
        Me.grpTireDetails.Controls.Add(Me.txtManufacturer)
        Me.grpTireDetails.Controls.Add(lblTireCode)
        Me.grpTireDetails.Controls.Add(Me.txtTireCode)
        Me.grpTireDetails.Location = New System.Drawing.Point(88, 98)
        Me.grpTireDetails.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTireDetails.Name = "grpTireDetails"
        Me.grpTireDetails.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTireDetails.Size = New System.Drawing.Size(749, 174)
        Me.grpTireDetails.TabIndex = 39
        Me.grpTireDetails.TabStop = False
        '
        'txtTireSize
        '
        Me.txtTireSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "manufacturerSize", True))
        Me.txtTireSize.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireSize.Location = New System.Drawing.Point(155, 95)
        Me.txtTireSize.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTireSize.Name = "txtTireSize"
        Me.txtTireSize.ReadOnly = True
        Me.txtTireSize.Size = New System.Drawing.Size(185, 27)
        Me.txtTireSize.TabIndex = 5
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "description", True))
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(155, 130)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ReadOnly = True
        Me.txtDescription.Size = New System.Drawing.Size(567, 27)
        Me.txtDescription.TabIndex = 6
        '
        'txtWholesaleCost
        '
        Me.txtWholesaleCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "wholesaleCost", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtWholesaleCost.Location = New System.Drawing.Point(553, 96)
        Me.txtWholesaleCost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtWholesaleCost.MaxLength = 9
        Me.txtWholesaleCost.Name = "txtWholesaleCost"
        Me.txtWholesaleCost.ReadOnly = True
        Me.txtWholesaleCost.Size = New System.Drawing.Size(168, 22)
        Me.txtWholesaleCost.TabIndex = 9
        '
        'txtDealerPrice
        '
        Me.txtDealerPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "dealerPrice", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtDealerPrice.Location = New System.Drawing.Point(553, 62)
        Me.txtDealerPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDealerPrice.MaxLength = 9
        Me.txtDealerPrice.Name = "txtDealerPrice"
        Me.txtDealerPrice.ReadOnly = True
        Me.txtDealerPrice.Size = New System.Drawing.Size(168, 22)
        Me.txtDealerPrice.TabIndex = 8
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "retailPrice", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.txtRetailPrice.Location = New System.Drawing.Point(553, 26)
        Me.txtRetailPrice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtRetailPrice.MaxLength = 9
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.ReadOnly = True
        Me.txtRetailPrice.Size = New System.Drawing.Size(168, 22)
        Me.txtRetailPrice.TabIndex = 7
        '
        'txtManufacturer
        '
        Me.txtManufacturer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "manufacturer", True))
        Me.txtManufacturer.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(155, 59)
        Me.txtManufacturer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.ReadOnly = True
        Me.txtManufacturer.Size = New System.Drawing.Size(185, 27)
        Me.txtManufacturer.TabIndex = 4
        '
        'txtTireCode
        '
        Me.txtTireCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "tireCode", True))
        Me.txtTireCode.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireCode.Location = New System.Drawing.Point(155, 23)
        Me.txtTireCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTireCode.MaxLength = 4
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.ReadOnly = True
        Me.txtTireCode.Size = New System.Drawing.Size(185, 27)
        Me.txtTireCode.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(611, 57)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(153, 37)
        Me.btnSearch.TabIndex = 47
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(333, 59)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(268, 30)
        Me.txtSearch.TabIndex = 46
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(161, 63)
        Me.lblSearch.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(159, 23)
        Me.lblSearch.TabIndex = 45
        Me.lblSearch.Text = "Search for a tire:"
        '
        'frmTires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(925, 642)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.grpTireDetails)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.TireDataGridView)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTires"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tires"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TireDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTireDetails.ResumeLayout(False)
        Me.grpTireDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents TireBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TireTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.tireTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    ' Friend WithEvents WholesalePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TireDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dealerPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wholesaleCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents grpTireDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents txtWholesaleCost As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtTireSize As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
End Class
