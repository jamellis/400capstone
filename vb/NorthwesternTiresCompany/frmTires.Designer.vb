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
        Dim TireCodeLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim ManufacturerLabel As System.Windows.Forms.Label
        Dim ManufacturerSizeLabel As System.Windows.Forms.Label
        Dim RetailPriceLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTires))
        Dim TireCodeLabel1 As System.Windows.Forms.Label
        Dim DescriptionLabel1 As System.Windows.Forms.Label
        Dim ManufacturerLabel1 As System.Windows.Forms.Label
        Dim ManufacturerSizeLabel1 As System.Windows.Forms.Label
        Dim RetailPriceLabel1 As System.Windows.Forms.Label
        Dim DealerPriceLabel As System.Windows.Forms.Label
        Dim WholesaleCostLabel As System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.TireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TireTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.tireTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.TireBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TireBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerSizeTextBox = New System.Windows.Forms.TextBox()
        Me.RetailPriceTextBox = New System.Windows.Forms.TextBox()
        Me.TireDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dealerPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wholesaleCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TireCodeTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox1 = New System.Windows.Forms.TextBox()
        Me.ManufacturerTextBox1 = New System.Windows.Forms.TextBox()
        Me.ManufacturerSizeTextBox1 = New System.Windows.Forms.TextBox()
        Me.RetailPriceTextBox1 = New System.Windows.Forms.TextBox()
        Me.DealerPriceTextBox = New System.Windows.Forms.TextBox()
        Me.WholesaleCostTextBox = New System.Windows.Forms.TextBox()
        TireCodeLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        ManufacturerLabel = New System.Windows.Forms.Label()
        ManufacturerSizeLabel = New System.Windows.Forms.Label()
        RetailPriceLabel = New System.Windows.Forms.Label()
        TireCodeLabel1 = New System.Windows.Forms.Label()
        DescriptionLabel1 = New System.Windows.Forms.Label()
        ManufacturerLabel1 = New System.Windows.Forms.Label()
        ManufacturerSizeLabel1 = New System.Windows.Forms.Label()
        RetailPriceLabel1 = New System.Windows.Forms.Label()
        DealerPriceLabel = New System.Windows.Forms.Label()
        WholesaleCostLabel = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TireBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TireBindingNavigator.SuspendLayout()
        CType(Me.TireDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TireCodeLabel
        '
        TireCodeLabel.AutoSize = True
        TireCodeLabel.Location = New System.Drawing.Point(14, 234)
        TireCodeLabel.Name = "TireCodeLabel"
        TireCodeLabel.Size = New System.Drawing.Size(56, 13)
        TireCodeLabel.TabIndex = 22
        TireCodeLabel.Text = "Tire Code:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(14, 260)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 24
        DescriptionLabel.Text = "Description:"
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Location = New System.Drawing.Point(214, 234)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(73, 13)
        ManufacturerLabel.TabIndex = 26
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'ManufacturerSizeLabel
        '
        ManufacturerSizeLabel.AutoSize = True
        ManufacturerSizeLabel.Location = New System.Drawing.Point(275, 260)
        ManufacturerSizeLabel.Name = "ManufacturerSizeLabel"
        ManufacturerSizeLabel.Size = New System.Drawing.Size(51, 13)
        ManufacturerSizeLabel.TabIndex = 28
        ManufacturerSizeLabel.Text = "Tire Size:"
        '
        'RetailPriceLabel
        '
        RetailPriceLabel.AutoSize = True
        RetailPriceLabel.Location = New System.Drawing.Point(470, 260)
        RetailPriceLabel.Name = "RetailPriceLabel"
        RetailPriceLabel.Size = New System.Drawing.Size(64, 13)
        RetailPriceLabel.TabIndex = 32
        RetailPriceLabel.Text = "Retail Price:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(600, 481)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 21
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 481)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 30)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(301, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(60, 24)
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
        Me.TableAdapterManager.retailOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.retailOrderTableAdapter = Nothing
        Me.TableAdapterManager.storeTableAdapter = Nothing
        Me.TableAdapterManager.tireTableAdapter = Me.TireTableAdapter
        Me.TableAdapterManager.transferOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wholesaleOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'TireBindingNavigator
        '
        Me.TireBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TireBindingNavigator.BackColor = System.Drawing.SystemColors.ControlLight
        Me.TireBindingNavigator.BindingSource = Me.TireBindingSource
        Me.TireBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TireBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TireBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TireBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TireBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripSeparator2, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator3, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.TireBindingNavigatorSaveItem})
        Me.TireBindingNavigator.Location = New System.Drawing.Point(225, 163)
        Me.TireBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TireBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TireBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TireBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TireBindingNavigator.Name = "TireBindingNavigator"
        Me.TireBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TireBindingNavigator.Size = New System.Drawing.Size(348, 26)
        Me.TireBindingNavigator.TabIndex = 22
        Me.TireBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(115, 23)
        Me.BindingNavigatorAddNewItem.Text = "Add New Tire"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 23)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        Me.BindingNavigatorCountItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(94, 23)
        Me.BindingNavigatorDeleteItem.Text = "Delete Tire"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(32, 23)
        Me.BindingNavigatorMoveFirstItem.Text = "First"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(52, 23)
        Me.BindingNavigatorMovePreviousItem.Text = "Previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 26)
        Me.BindingNavigatorSeparator.Visible = False
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        Me.BindingNavigatorPositionItem.Visible = False
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 26)
        Me.BindingNavigatorSeparator1.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(34, 23)
        Me.BindingNavigatorMoveNextItem.Text = "Next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(31, 23)
        Me.BindingNavigatorMoveLastItem.Text = "Last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 26)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 26)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 26)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 26)
        '
        'TireBindingNavigatorSaveItem
        '
        Me.TireBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TireBindingNavigatorSaveItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TireBindingNavigatorSaveItem.Image = CType(resources.GetObject("TireBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TireBindingNavigatorSaveItem.Name = "TireBindingNavigatorSaveItem"
        Me.TireBindingNavigatorSaveItem.Size = New System.Drawing.Size(124, 23)
        Me.TireBindingNavigatorSaveItem.Text = "Save Changes"
        '
        'txtTireCode
        '
        Me.txtTireCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "tireCode", True))
        Me.txtTireCode.Location = New System.Drawing.Point(83, 231)
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.Size = New System.Drawing.Size(115, 20)
        Me.txtTireCode.TabIndex = 23
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "description", True))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(83, 257)
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(186, 20)
        Me.DescriptionTextBox.TabIndex = 25
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "manufacturer", True))
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(297, 231)
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(150, 20)
        Me.ManufacturerTextBox.TabIndex = 27
        Me.ManufacturerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ManufacturerSizeTextBox
        '
        Me.ManufacturerSizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "manufacturerSize", True))
        Me.ManufacturerSizeTextBox.Location = New System.Drawing.Point(361, 257)
        Me.ManufacturerSizeTextBox.Name = "ManufacturerSizeTextBox"
        Me.ManufacturerSizeTextBox.Size = New System.Drawing.Size(86, 20)
        Me.ManufacturerSizeTextBox.TabIndex = 29
        Me.ManufacturerSizeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RetailPriceTextBox
        '
        Me.RetailPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "retailPrice", True))
        Me.RetailPriceTextBox.Location = New System.Drawing.Point(556, 257)
        Me.RetailPriceTextBox.Name = "RetailPriceTextBox"
        Me.RetailPriceTextBox.Size = New System.Drawing.Size(97, 20)
        Me.RetailPriceTextBox.TabIndex = 33
        '
        'TireDataGridView
        '
        Me.TireDataGridView.AutoGenerateColumns = False
        Me.TireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TireDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.dealerPrice, Me.wholesaleCost})
        Me.TireDataGridView.DataSource = Me.TireBindingSource
        Me.TireDataGridView.Location = New System.Drawing.Point(12, 313)
        Me.TireDataGridView.Name = "TireDataGridView"
        Me.TireDataGridView.Size = New System.Drawing.Size(663, 139)
        Me.TireDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tireCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tire Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn2.FillWeight = 300.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "manufacturer"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Manufacturer"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "manufacturerSize"
        Me.DataGridViewTextBoxColumn4.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tire Size"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "retailPrice"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Retail Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 90
        '
        'dealerPrice
        '
        Me.dealerPrice.DataPropertyName = "dealerPrice"
        Me.dealerPrice.HeaderText = "Dealer Price"
        Me.dealerPrice.Name = "dealerPrice"
        Me.dealerPrice.Width = 90
        '
        'wholesaleCost
        '
        Me.wholesaleCost.DataPropertyName = "wholesaleCost"
        Me.wholesaleCost.HeaderText = "Wholesale Cost"
        Me.wholesaleCost.Name = "wholesaleCost"
        Me.wholesaleCost.Width = 90
        '
        'TireCodeLabel1
        '
        TireCodeLabel1.AutoSize = True
        TireCodeLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TireCodeLabel1.Location = New System.Drawing.Point(22, 43)
        TireCodeLabel1.Name = "TireCodeLabel1"
        TireCodeLabel1.Size = New System.Drawing.Size(70, 16)
        TireCodeLabel1.TabIndex = 33
        TireCodeLabel1.Text = "tire Code:"
        '
        'TireCodeTextBox
        '
        Me.TireCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "tireCode", True))
        Me.TireCodeTextBox.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TireCodeTextBox.Location = New System.Drawing.Point(123, 40)
        Me.TireCodeTextBox.Name = "TireCodeTextBox"
        Me.TireCodeTextBox.Size = New System.Drawing.Size(100, 23)
        Me.TireCodeTextBox.TabIndex = 34
        '
        'DescriptionLabel1
        '
        DescriptionLabel1.AutoSize = True
        DescriptionLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel1.Location = New System.Drawing.Point(22, 69)
        DescriptionLabel1.Name = "DescriptionLabel1"
        DescriptionLabel1.Size = New System.Drawing.Size(81, 16)
        DescriptionLabel1.TabIndex = 35
        DescriptionLabel1.Text = "description:"
        '
        'DescriptionTextBox1
        '
        Me.DescriptionTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "description", True))
        Me.DescriptionTextBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox1.Location = New System.Drawing.Point(123, 66)
        Me.DescriptionTextBox1.Name = "DescriptionTextBox1"
        Me.DescriptionTextBox1.Size = New System.Drawing.Size(100, 23)
        Me.DescriptionTextBox1.TabIndex = 36
        '
        'ManufacturerLabel1
        '
        ManufacturerLabel1.AutoSize = True
        ManufacturerLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ManufacturerLabel1.Location = New System.Drawing.Point(229, 43)
        ManufacturerLabel1.Name = "ManufacturerLabel1"
        ManufacturerLabel1.Size = New System.Drawing.Size(96, 16)
        ManufacturerLabel1.TabIndex = 37
        ManufacturerLabel1.Text = "manufacturer:"
        '
        'ManufacturerTextBox1
        '
        Me.ManufacturerTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "manufacturer", True))
        Me.ManufacturerTextBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerTextBox1.Location = New System.Drawing.Point(351, 40)
        Me.ManufacturerTextBox1.Name = "ManufacturerTextBox1"
        Me.ManufacturerTextBox1.Size = New System.Drawing.Size(126, 23)
        Me.ManufacturerTextBox1.TabIndex = 38
        '
        'ManufacturerSizeLabel1
        '
        ManufacturerSizeLabel1.AutoSize = True
        ManufacturerSizeLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ManufacturerSizeLabel1.Location = New System.Drawing.Point(229, 69)
        ManufacturerSizeLabel1.Name = "ManufacturerSizeLabel1"
        ManufacturerSizeLabel1.Size = New System.Drawing.Size(126, 16)
        ManufacturerSizeLabel1.TabIndex = 39
        ManufacturerSizeLabel1.Text = "manufacturer Size:"
        '
        'ManufacturerSizeTextBox1
        '
        Me.ManufacturerSizeTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "manufacturerSize", True))
        Me.ManufacturerSizeTextBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerSizeTextBox1.Location = New System.Drawing.Point(351, 66)
        Me.ManufacturerSizeTextBox1.Name = "ManufacturerSizeTextBox1"
        Me.ManufacturerSizeTextBox1.Size = New System.Drawing.Size(126, 23)
        Me.ManufacturerSizeTextBox1.TabIndex = 40
        '
        'RetailPriceLabel1
        '
        RetailPriceLabel1.AutoSize = True
        RetailPriceLabel1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RetailPriceLabel1.Location = New System.Drawing.Point(80, 103)
        RetailPriceLabel1.Name = "RetailPriceLabel1"
        RetailPriceLabel1.Size = New System.Drawing.Size(79, 16)
        RetailPriceLabel1.TabIndex = 41
        RetailPriceLabel1.Text = "retail Price:"
        '
        'RetailPriceTextBox1
        '
        Me.RetailPriceTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "retailPrice", True))
        Me.RetailPriceTextBox1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailPriceTextBox1.Location = New System.Drawing.Point(190, 100)
        Me.RetailPriceTextBox1.Name = "RetailPriceTextBox1"
        Me.RetailPriceTextBox1.Size = New System.Drawing.Size(94, 23)
        Me.RetailPriceTextBox1.TabIndex = 42
        '
        'DealerPriceLabel
        '
        DealerPriceLabel.AutoSize = True
        DealerPriceLabel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DealerPriceLabel.Location = New System.Drawing.Point(80, 129)
        DealerPriceLabel.Name = "DealerPriceLabel"
        DealerPriceLabel.Size = New System.Drawing.Size(88, 16)
        DealerPriceLabel.TabIndex = 43
        DealerPriceLabel.Text = "dealer Price:"
        '
        'DealerPriceTextBox
        '
        Me.DealerPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "dealerPrice", True))
        Me.DealerPriceTextBox.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DealerPriceTextBox.Location = New System.Drawing.Point(190, 126)
        Me.DealerPriceTextBox.Name = "DealerPriceTextBox"
        Me.DealerPriceTextBox.Size = New System.Drawing.Size(94, 23)
        Me.DealerPriceTextBox.TabIndex = 44
        '
        'WholesaleCostLabel
        '
        WholesaleCostLabel.AutoSize = True
        WholesaleCostLabel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WholesaleCostLabel.Location = New System.Drawing.Point(80, 155)
        WholesaleCostLabel.Name = "WholesaleCostLabel"
        WholesaleCostLabel.Size = New System.Drawing.Size(107, 16)
        WholesaleCostLabel.TabIndex = 45
        WholesaleCostLabel.Text = "wholesale Cost:"
        '
        'WholesaleCostTextBox
        '
        Me.WholesaleCostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "wholesaleCost", True))
        Me.WholesaleCostTextBox.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WholesaleCostTextBox.Location = New System.Drawing.Point(190, 152)
        Me.WholesaleCostTextBox.Name = "WholesaleCostTextBox"
        Me.WholesaleCostTextBox.Size = New System.Drawing.Size(94, 23)
        Me.WholesaleCostTextBox.TabIndex = 46
        '
        'frmTires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 523)
        Me.Controls.Add(TireCodeLabel1)
        Me.Controls.Add(Me.TireCodeTextBox)
        Me.Controls.Add(DescriptionLabel1)
        Me.Controls.Add(Me.DescriptionTextBox1)
        Me.Controls.Add(ManufacturerLabel1)
        Me.Controls.Add(Me.ManufacturerTextBox1)
        Me.Controls.Add(ManufacturerSizeLabel1)
        Me.Controls.Add(Me.ManufacturerSizeTextBox1)
        Me.Controls.Add(RetailPriceLabel1)
        Me.Controls.Add(Me.RetailPriceTextBox1)
        Me.Controls.Add(DealerPriceLabel)
        Me.Controls.Add(Me.DealerPriceTextBox)
        Me.Controls.Add(WholesaleCostLabel)
        Me.Controls.Add(Me.WholesaleCostTextBox)
        Me.Controls.Add(Me.TireDataGridView)
        Me.Controls.Add(TireCodeLabel)
        Me.Controls.Add(Me.txtTireCode)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(Me.DescriptionTextBox)
        Me.Controls.Add(ManufacturerLabel)
        Me.Controls.Add(Me.ManufacturerTextBox)
        Me.Controls.Add(ManufacturerSizeLabel)
        Me.Controls.Add(Me.ManufacturerSizeTextBox)
        Me.Controls.Add(RetailPriceLabel)
        Me.Controls.Add(Me.RetailPriceTextBox)
        Me.Controls.Add(Me.TireBindingNavigator)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTires"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tires"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TireBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TireBindingNavigator.ResumeLayout(False)
        Me.TireBindingNavigator.PerformLayout()
        CType(Me.TireDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TireBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TireBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManufacturerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManufacturerSizeTextBox As System.Windows.Forms.TextBox
    ' Friend WithEvents WholesalePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RetailPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TireDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dealerPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wholesaleCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TireCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ManufacturerTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ManufacturerSizeTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RetailPriceTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DealerPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WholesaleCostTextBox As System.Windows.Forms.TextBox
End Class
