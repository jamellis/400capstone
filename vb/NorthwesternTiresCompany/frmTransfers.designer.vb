<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransfers
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
        Dim StoreNbrLabel As System.Windows.Forms.Label
        Dim StoreNbrLabel1 As System.Windows.Forms.Label
        Dim TireCodeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransfers))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.RecStoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecStoreTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.recStoreTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.RecStoreBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.RecStoreBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.StoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAvailableInv = New System.Windows.Forms.Button()
        Me.InvSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvSearchTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter()
        Me.gdvAvailableInv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TireBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TireTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.tireTableAdapter()
        Me.cboShipStore = New System.Windows.Forms.ComboBox()
        Me.cboRecStore = New System.Windows.Forms.ComboBox()
        Me.cboTireCode = New System.Windows.Forms.ComboBox()
        Me.btnTransferInv = New System.Windows.Forms.Button()
        Me.txtTransferQty = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.InventoryTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.inventoryTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.StoreTableAdapter1 = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        StoreNbrLabel = New System.Windows.Forms.Label()
        StoreNbrLabel1 = New System.Windows.Forms.Label()
        TireCodeLabel = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecStoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecStoreBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RecStoreBindingNavigator.SuspendLayout()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gdvAvailableInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TireBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StoreNbrLabel
        '
        StoreNbrLabel.AutoSize = True
        StoreNbrLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StoreNbrLabel.Location = New System.Drawing.Point(375, 119)
        StoreNbrLabel.Name = "StoreNbrLabel"
        StoreNbrLabel.Size = New System.Drawing.Size(88, 19)
        StoreNbrLabel.TabIndex = 2
        StoreNbrLabel.Text = "Store Nbr:"
        '
        'StoreNbrLabel1
        '
        StoreNbrLabel1.AutoSize = True
        StoreNbrLabel1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StoreNbrLabel1.Location = New System.Drawing.Point(76, 119)
        StoreNbrLabel1.Name = "StoreNbrLabel1"
        StoreNbrLabel1.Size = New System.Drawing.Size(88, 19)
        StoreNbrLabel1.TabIndex = 4
        StoreNbrLabel1.Text = "Store Nbr:"
        '
        'TireCodeLabel
        '
        TireCodeLabel.AutoSize = True
        TireCodeLabel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TireCodeLabel.Location = New System.Drawing.Point(216, 170)
        TireCodeLabel.Name = "TireCodeLabel"
        TireCodeLabel.Size = New System.Drawing.Size(89, 19)
        TireCodeLabel.TabIndex = 11
        TireCodeLabel.Text = "Tire Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(227, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Store Transfers"
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RecStoreBindingSource
        '
        Me.RecStoreBindingSource.DataMember = "recStore"
        Me.RecStoreBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'RecStoreTableAdapter
        '
        Me.RecStoreTableAdapter.ClearBeforeFill = True
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
        'RecStoreBindingNavigator
        '
        Me.RecStoreBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RecStoreBindingNavigator.BindingSource = Me.RecStoreBindingSource
        Me.RecStoreBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RecStoreBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RecStoreBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.RecStoreBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RecStoreBindingNavigatorSaveItem, Me.ToolStripButton1})
        Me.RecStoreBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RecStoreBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RecStoreBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RecStoreBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RecStoreBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RecStoreBindingNavigator.Name = "RecStoreBindingNavigator"
        Me.RecStoreBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RecStoreBindingNavigator.Size = New System.Drawing.Size(111, 25)
        Me.RecStoreBindingNavigator.TabIndex = 1
        Me.RecStoreBindingNavigator.Text = "BindingNavigator1"
        Me.RecStoreBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        Me.BindingNavigatorAddNewItem.Visible = False
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        Me.BindingNavigatorCountItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        Me.BindingNavigatorDeleteItem.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator1.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'RecStoreBindingNavigatorSaveItem
        '
        Me.RecStoreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RecStoreBindingNavigatorSaveItem.Enabled = False
        Me.RecStoreBindingNavigatorSaveItem.Image = CType(resources.GetObject("RecStoreBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RecStoreBindingNavigatorSaveItem.Name = "RecStoreBindingNavigatorSaveItem"
        Me.RecStoreBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RecStoreBindingNavigatorSaveItem.Text = "Save Data"
        Me.RecStoreBindingNavigatorSaveItem.Visible = False
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.Visible = False
        '
        'StoreBindingSource
        '
        Me.StoreBindingSource.DataMember = "store"
        Me.StoreBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'StoreTableAdapter
        '
        Me.StoreTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(77, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(236, 18)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Please select the Shipping store."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(376, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(243, 18)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Please select the Receiving store."
        '
        'btnAvailableInv
        '
        Me.btnAvailableInv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvailableInv.Location = New System.Drawing.Point(231, 215)
        Me.btnAvailableInv.Name = "btnAvailableInv"
        Me.btnAvailableInv.Size = New System.Drawing.Size(220, 30)
        Me.btnAvailableInv.TabIndex = 8
        Me.btnAvailableInv.Text = "Check Available Inventory"
        Me.btnAvailableInv.UseVisualStyleBackColor = True
        '
        'InvSearchBindingSource
        '
        Me.InvSearchBindingSource.DataMember = "invSearch"
        Me.InvSearchBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'InvSearchTableAdapter
        '
        Me.InvSearchTableAdapter.ClearBeforeFill = True
        '
        'gdvAvailableInv
        '
        Me.gdvAvailableInv.AllowUserToAddRows = False
        Me.gdvAvailableInv.AllowUserToDeleteRows = False
        Me.gdvAvailableInv.AutoGenerateColumns = False
        Me.gdvAvailableInv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gdvAvailableInv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn6})
        Me.gdvAvailableInv.DataSource = Me.InventoryBindingSource
        Me.gdvAvailableInv.Location = New System.Drawing.Point(171, 275)
        Me.gdvAvailableInv.MultiSelect = False
        Me.gdvAvailableInv.Name = "gdvAvailableInv"
        Me.gdvAvailableInv.ReadOnly = True
        Me.gdvAvailableInv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gdvAvailableInv.Size = New System.Drawing.Size(343, 103)
        Me.gdvAvailableInv.TabIndex = 9
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "storeNbr"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Store Nbr"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tireCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tire Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tireQty"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Tire Qty"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
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
        'cboShipStore
        '
        Me.cboShipStore.FormattingEnabled = True
        Me.cboShipStore.Location = New System.Drawing.Point(171, 119)
        Me.cboShipStore.Name = "cboShipStore"
        Me.cboShipStore.Size = New System.Drawing.Size(121, 26)
        Me.cboShipStore.TabIndex = 12
        '
        'cboRecStore
        '
        Me.cboRecStore.DataSource = Me.RecStoreBindingSource
        Me.cboRecStore.DisplayMember = "storeNbr"
        Me.cboRecStore.FormattingEnabled = True
        Me.cboRecStore.Location = New System.Drawing.Point(480, 119)
        Me.cboRecStore.Name = "cboRecStore"
        Me.cboRecStore.Size = New System.Drawing.Size(121, 26)
        Me.cboRecStore.TabIndex = 13
        Me.cboRecStore.ValueMember = "storeNbr"
        '
        'cboTireCode
        '
        Me.cboTireCode.DataSource = Me.TireBindingSource
        Me.cboTireCode.DisplayMember = "tireCode"
        Me.cboTireCode.FormattingEnabled = True
        Me.cboTireCode.Location = New System.Drawing.Point(312, 170)
        Me.cboTireCode.Name = "cboTireCode"
        Me.cboTireCode.Size = New System.Drawing.Size(121, 26)
        Me.cboTireCode.TabIndex = 14
        Me.cboTireCode.ValueMember = "tireCode"
        '
        'btnTransferInv
        '
        Me.btnTransferInv.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransferInv.Location = New System.Drawing.Point(314, 430)
        Me.btnTransferInv.Name = "btnTransferInv"
        Me.btnTransferInv.Size = New System.Drawing.Size(200, 30)
        Me.btnTransferInv.TabIndex = 15
        Me.btnTransferInv.Text = "Transfer Inventory"
        Me.btnTransferInv.UseVisualStyleBackColor = True
        '
        'txtTransferQty
        '
        Me.txtTransferQty.Location = New System.Drawing.Point(192, 434)
        Me.txtTransferQty.Name = "txtTransferQty"
        Me.txtTransferQty.Size = New System.Drawing.Size(100, 26)
        Me.txtTransferQty.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(192, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Transfer Qty"
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(36, 470)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(560, 470)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'StoreTableAdapter1
        '
        Me.StoreTableAdapter1.ClearBeforeFill = True
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "inventory"
        Me.InventoryBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'frmTransfers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 512)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTransferQty)
        Me.Controls.Add(Me.btnTransferInv)
        Me.Controls.Add(Me.cboTireCode)
        Me.Controls.Add(Me.cboRecStore)
        Me.Controls.Add(Me.cboShipStore)
        Me.Controls.Add(TireCodeLabel)
        Me.Controls.Add(Me.gdvAvailableInv)
        Me.Controls.Add(Me.btnAvailableInv)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(StoreNbrLabel1)
        Me.Controls.Add(StoreNbrLabel)
        Me.Controls.Add(Me.RecStoreBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTransfers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Store Transfers"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecStoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecStoreBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RecStoreBindingNavigator.ResumeLayout(False)
        Me.RecStoreBindingNavigator.PerformLayout()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gdvAvailableInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TireBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents RecStoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RecStoreTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.recStoreTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents RecStoreBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents RecStoreBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents StoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StoreTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAvailableInv As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents InvSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvSearchTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter
    Friend WithEvents gdvAvailableInv As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TireBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TireTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.tireTableAdapter
    Friend WithEvents cboShipStore As System.Windows.Forms.ComboBox
    Friend WithEvents cboRecStore As System.Windows.Forms.ComboBox
    Friend WithEvents cboTireCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnTransferInv As System.Windows.Forms.Button
    Friend WithEvents txtTransferQty As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents InventoryTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.inventoryTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents StoreTableAdapter1 As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter
    Friend WithEvents InventoryBindingSource As System.Windows.Forms.BindingSource
End Class
