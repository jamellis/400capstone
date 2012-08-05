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
        Dim lblDescription As System.Windows.Forms.Label
        Dim lblManufacturer As System.Windows.Forms.Label
        Dim lblTireSize As System.Windows.Forms.Label
        Dim lblRetailPrice As System.Windows.Forms.Label
        Dim lblDealerPrice As System.Windows.Forms.Label
        Dim lblWholesaleCost As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTires))
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
        Me.TireDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dealerPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.wholesaleCost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTireCode = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.txtManufacturer = New System.Windows.Forms.TextBox()
        Me.txtTireSize = New System.Windows.Forms.TextBox()
        Me.txtRetailPrice = New System.Windows.Forms.TextBox()
        Me.txtDealerPrice = New System.Windows.Forms.TextBox()
        Me.txtWholesaleCost = New System.Windows.Forms.TextBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.grpBoxTireInfo = New System.Windows.Forms.GroupBox()
        Me.picBoxLogo = New System.Windows.Forms.PictureBox()
        lblTireCode = New System.Windows.Forms.Label()
        lblDescription = New System.Windows.Forms.Label()
        lblManufacturer = New System.Windows.Forms.Label()
        lblTireSize = New System.Windows.Forms.Label()
        lblRetailPrice = New System.Windows.Forms.Label()
        lblDealerPrice = New System.Windows.Forms.Label()
        lblWholesaleCost = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TireBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TireBindingNavigator.SuspendLayout()
        CType(Me.TireDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxTireInfo.SuspendLayout()
        CType(Me.picBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTireCode
        '
        lblTireCode.AutoSize = True
        lblTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTireCode.Location = New System.Drawing.Point(5, 17)
        lblTireCode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblTireCode.Name = "lblTireCode"
        lblTireCode.Size = New System.Drawing.Size(102, 23)
        lblTireCode.TabIndex = 33
        lblTireCode.Text = "Tire Code:"
        '
        'lblDescription
        '
        lblDescription.AutoSize = True
        lblDescription.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDescription.Location = New System.Drawing.Point(3, 49)
        lblDescription.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDescription.Name = "lblDescription"
        lblDescription.Size = New System.Drawing.Size(114, 23)
        lblDescription.TabIndex = 35
        lblDescription.Text = "Description:"
        '
        'lblManufacturer
        '
        lblManufacturer.AutoSize = True
        lblManufacturer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblManufacturer.Location = New System.Drawing.Point(321, 17)
        lblManufacturer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblManufacturer.Name = "lblManufacturer"
        lblManufacturer.Size = New System.Drawing.Size(132, 23)
        lblManufacturer.TabIndex = 37
        lblManufacturer.Text = "Manufacturer:"
        '
        'lblTireSize
        '
        lblTireSize.AutoSize = True
        lblTireSize.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblTireSize.Location = New System.Drawing.Point(321, 49)
        lblTireSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblTireSize.Name = "lblTireSize"
        lblTireSize.Size = New System.Drawing.Size(92, 23)
        lblTireSize.TabIndex = 39
        lblTireSize.Text = "Tire Size:"
        '
        'lblRetailPrice
        '
        lblRetailPrice.AutoSize = True
        lblRetailPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblRetailPrice.Location = New System.Drawing.Point(641, 20)
        lblRetailPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblRetailPrice.Name = "lblRetailPrice"
        lblRetailPrice.Size = New System.Drawing.Size(117, 23)
        lblRetailPrice.TabIndex = 41
        lblRetailPrice.Text = "Retail Price:"
        '
        'lblDealerPrice
        '
        lblDealerPrice.AutoSize = True
        lblDealerPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerPrice.Location = New System.Drawing.Point(641, 52)
        lblDealerPrice.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblDealerPrice.Name = "lblDealerPrice"
        lblDealerPrice.Size = New System.Drawing.Size(125, 23)
        lblDealerPrice.TabIndex = 43
        lblDealerPrice.Text = "Dealer Price:"
        '
        'lblWholesaleCost
        '
        lblWholesaleCost.AutoSize = True
        lblWholesaleCost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblWholesaleCost.Location = New System.Drawing.Point(641, 84)
        lblWholesaleCost.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        lblWholesaleCost.Name = "lblWholesaleCost"
        lblWholesaleCost.Size = New System.Drawing.Size(154, 23)
        lblWholesaleCost.TabIndex = 45
        lblWholesaleCost.Text = "Wholesale Cost:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(829, 742)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
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
        Me.btnBack.Location = New System.Drawing.Point(16, 742)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 37)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(421, 95)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(108, 44)
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
        Me.TireBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripSeparator2, Me.ToolStripSeparator3, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator1, Me.TireBindingNavigatorSaveItem})
        Me.TireBindingNavigator.Location = New System.Drawing.Point(208, 150)
        Me.TireBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TireBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TireBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TireBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TireBindingNavigator.Name = "TireBindingNavigator"
        Me.TireBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TireBindingNavigator.Size = New System.Drawing.Size(420, 31)
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
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(140, 28)
        Me.BindingNavigatorAddNewItem.Text = "Add New Tire"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 28)
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
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(116, 28)
        Me.BindingNavigatorDeleteItem.Text = "Delete Tire"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(40, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "First"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(68, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
        Me.BindingNavigatorSeparator.Visible = False
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        Me.BindingNavigatorPositionItem.Visible = False
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        Me.BindingNavigatorSeparator1.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(44, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(39, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'TireBindingNavigatorSaveItem
        '
        Me.TireBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TireBindingNavigatorSaveItem.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.TireBindingNavigatorSaveItem.Image = CType(resources.GetObject("TireBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TireBindingNavigatorSaveItem.Name = "TireBindingNavigatorSaveItem"
        Me.TireBindingNavigatorSaveItem.Size = New System.Drawing.Size(149, 28)
        Me.TireBindingNavigatorSaveItem.Text = "Save Changes"
        '
        'TireDataGridView
        '
        Me.TireDataGridView.AllowUserToAddRows = False
        Me.TireDataGridView.AllowUserToDeleteRows = False
        Me.TireDataGridView.AutoGenerateColumns = False
        Me.TireDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TireDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.dealerPrice, Me.wholesaleCost})
        Me.TireDataGridView.DataSource = Me.TireBindingSource
        Me.TireDataGridView.Location = New System.Drawing.Point(6, 405)
        Me.TireDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TireDataGridView.Name = "TireDataGridView"
        Me.TireDataGridView.ReadOnly = True
        Me.TireDataGridView.RowTemplate.Height = 24
        Me.TireDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TireDataGridView.Size = New System.Drawing.Size(941, 318)
        Me.TireDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tireCode"
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tire Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn2.FillWeight = 300.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "manufacturerSize"
        Me.DataGridViewTextBoxColumn4.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tire Size"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
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
        'txtTireCode
        '
        Me.txtTireCode.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "tireCode", True))
        Me.txtTireCode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireCode.Location = New System.Drawing.Point(133, 16)
        Me.txtTireCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTireCode.Name = "txtTireCode"
        Me.txtTireCode.Size = New System.Drawing.Size(171, 30)
        Me.txtTireCode.TabIndex = 34
        '
        'txtDescription
        '
        Me.txtDescription.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "description", True))
        Me.txtDescription.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(133, 54)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(171, 88)
        Me.txtDescription.TabIndex = 36
        '
        'txtManufacturer
        '
        Me.txtManufacturer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "manufacturer", True))
        Me.txtManufacturer.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtManufacturer.Location = New System.Drawing.Point(465, 14)
        Me.txtManufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.txtManufacturer.Name = "txtManufacturer"
        Me.txtManufacturer.Size = New System.Drawing.Size(167, 30)
        Me.txtManufacturer.TabIndex = 38
        '
        'txtTireSize
        '
        Me.txtTireSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "manufacturerSize", True))
        Me.txtTireSize.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTireSize.Location = New System.Drawing.Point(465, 46)
        Me.txtTireSize.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTireSize.Name = "txtTireSize"
        Me.txtTireSize.Size = New System.Drawing.Size(167, 30)
        Me.txtTireSize.TabIndex = 40
        '
        'txtRetailPrice
        '
        Me.txtRetailPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "retailPrice", True))
        Me.txtRetailPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRetailPrice.Location = New System.Drawing.Point(812, 14)
        Me.txtRetailPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetailPrice.Name = "txtRetailPrice"
        Me.txtRetailPrice.Size = New System.Drawing.Size(117, 30)
        Me.txtRetailPrice.TabIndex = 42
        '
        'txtDealerPrice
        '
        Me.txtDealerPrice.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "dealerPrice", True))
        Me.txtDealerPrice.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerPrice.Location = New System.Drawing.Point(812, 46)
        Me.txtDealerPrice.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDealerPrice.Name = "txtDealerPrice"
        Me.txtDealerPrice.Size = New System.Drawing.Size(117, 30)
        Me.txtDealerPrice.TabIndex = 44
        '
        'txtWholesaleCost
        '
        Me.txtWholesaleCost.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TireBindingSource, "wholesaleCost", True))
        Me.txtWholesaleCost.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWholesaleCost.Location = New System.Drawing.Point(812, 78)
        Me.txtWholesaleCost.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWholesaleCost.Name = "txtWholesaleCost"
        Me.txtWholesaleCost.Size = New System.Drawing.Size(117, 30)
        Me.txtWholesaleCost.TabIndex = 46
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.ForeColor = System.Drawing.Color.Blue
        Me.lblInstructions.Location = New System.Drawing.Point(23, 137)
        Me.lblInstructions.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(882, 44)
        Me.lblInstructions.TabIndex = 47
        Me.lblInstructions.Text = "Select a tire from the list. To edit details, make the changes in the boxes below" & _
    " then click ""Save" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Changes"". To add a new tire, click the ""Add New Tire"" button " & _
    "then enter the details."
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpBoxTireInfo
        '
        Me.grpBoxTireInfo.Controls.Add(lblTireCode)
        Me.grpBoxTireInfo.Controls.Add(Me.txtTireCode)
        Me.grpBoxTireInfo.Controls.Add(lblDescription)
        Me.grpBoxTireInfo.Controls.Add(Me.txtDescription)
        Me.grpBoxTireInfo.Controls.Add(Me.TireBindingNavigator)
        Me.grpBoxTireInfo.Controls.Add(lblManufacturer)
        Me.grpBoxTireInfo.Controls.Add(Me.txtManufacturer)
        Me.grpBoxTireInfo.Controls.Add(lblTireSize)
        Me.grpBoxTireInfo.Controls.Add(Me.txtTireSize)
        Me.grpBoxTireInfo.Controls.Add(lblRetailPrice)
        Me.grpBoxTireInfo.Controls.Add(Me.txtRetailPrice)
        Me.grpBoxTireInfo.Controls.Add(lblDealerPrice)
        Me.grpBoxTireInfo.Controls.Add(Me.txtDealerPrice)
        Me.grpBoxTireInfo.Controls.Add(lblWholesaleCost)
        Me.grpBoxTireInfo.Controls.Add(Me.txtWholesaleCost)
        Me.grpBoxTireInfo.Location = New System.Drawing.Point(6, 185)
        Me.grpBoxTireInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.grpBoxTireInfo.Name = "grpBoxTireInfo"
        Me.grpBoxTireInfo.Padding = New System.Windows.Forms.Padding(4)
        Me.grpBoxTireInfo.Size = New System.Drawing.Size(941, 185)
        Me.grpBoxTireInfo.TabIndex = 48
        Me.grpBoxTireInfo.TabStop = False
        '
        'picBoxLogo
        '
        Me.picBoxLogo.Image = Global.NorthwesternTiresCompany.My.Resources.Resources.nwtires_logo_sm
        Me.picBoxLogo.InitialImage = Nothing
        Me.picBoxLogo.Location = New System.Drawing.Point(321, 1)
        Me.picBoxLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.picBoxLogo.Name = "picBoxLogo"
        Me.picBoxLogo.Size = New System.Drawing.Size(309, 92)
        Me.picBoxLogo.TabIndex = 49
        Me.picBoxLogo.TabStop = False
        '
        'frmTires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.picBoxLogo)
        Me.Controls.Add(Me.grpBoxTireInfo)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.TireDataGridView)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmTires"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tires"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TireBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TireBindingNavigator.ResumeLayout(False)
        Me.TireBindingNavigator.PerformLayout()
        CType(Me.TireDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxTireInfo.ResumeLayout(False)
        Me.grpBoxTireInfo.PerformLayout()
        CType(Me.picBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TireBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    ' Friend WithEvents WholesalePriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TireDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTireCode As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtManufacturer As System.Windows.Forms.TextBox
    Friend WithEvents txtTireSize As System.Windows.Forms.TextBox
    Friend WithEvents txtRetailPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtWholesaleCost As System.Windows.Forms.TextBox
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dealerPrice As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents wholesaleCost As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpBoxTireInfo As System.Windows.Forms.GroupBox
    Friend WithEvents picBoxLogo As System.Windows.Forms.PictureBox
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
End Class
