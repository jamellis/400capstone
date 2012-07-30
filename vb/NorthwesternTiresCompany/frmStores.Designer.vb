<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStores
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
        Dim lblStoreNbr As System.Windows.Forms.Label
        Dim lblStreetAddress As System.Windows.Forms.Label
        Dim lblCity As System.Windows.Forms.Label
        Dim lblState As System.Windows.Forms.Label
        Dim lblZip As System.Windows.Forms.Label
        Dim lblPhone As System.Windows.Forms.Label
        Dim lblFax As System.Windows.Forms.Label
        Dim lblEmail As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStores))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.StoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.StoreBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.StoreBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.txtStoreNbr = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.StoreDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpBoxStoreInfo = New System.Windows.Forms.GroupBox()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        lblStoreNbr = New System.Windows.Forms.Label()
        lblStreetAddress = New System.Windows.Forms.Label()
        lblCity = New System.Windows.Forms.Label()
        lblState = New System.Windows.Forms.Label()
        lblZip = New System.Windows.Forms.Label()
        lblPhone = New System.Windows.Forms.Label()
        lblFax = New System.Windows.Forms.Label()
        lblEmail = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StoreBindingNavigator.SuspendLayout()
        CType(Me.StoreDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxStoreInfo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStoreNbr
        '
        lblStoreNbr.AutoSize = True
        lblStoreNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStoreNbr.Location = New System.Drawing.Point(16, 19)
        lblStoreNbr.Name = "lblStoreNbr"
        lblStoreNbr.Size = New System.Drawing.Size(63, 18)
        lblStoreNbr.TabIndex = 22
        lblStoreNbr.Text = "Store #:"
        '
        'lblStreetAddress
        '
        lblStreetAddress.AutoSize = True
        lblStreetAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStreetAddress.Location = New System.Drawing.Point(16, 45)
        lblStreetAddress.Name = "lblStreetAddress"
        lblStreetAddress.Size = New System.Drawing.Size(71, 18)
        lblStreetAddress.TabIndex = 24
        lblStreetAddress.Text = "Address:"
        '
        'lblCity
        '
        lblCity.AutoSize = True
        lblCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCity.Location = New System.Drawing.Point(16, 71)
        lblCity.Name = "lblCity"
        lblCity.Size = New System.Drawing.Size(39, 18)
        lblCity.TabIndex = 26
        lblCity.Text = "City:"
        '
        'lblState
        '
        lblState.AutoSize = True
        lblState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblState.Location = New System.Drawing.Point(16, 97)
        lblState.Name = "lblState"
        lblState.Size = New System.Drawing.Size(49, 18)
        lblState.TabIndex = 28
        lblState.Text = "State:"
        '
        'lblZip
        '
        lblZip.AutoSize = True
        lblZip.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblZip.Location = New System.Drawing.Point(149, 97)
        lblZip.Name = "lblZip"
        lblZip.Size = New System.Drawing.Size(34, 18)
        lblZip.TabIndex = 30
        lblZip.Text = "Zip:"
        '
        'lblPhone
        '
        lblPhone.AutoSize = True
        lblPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPhone.Location = New System.Drawing.Point(323, 18)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New System.Drawing.Size(57, 18)
        lblPhone.TabIndex = 32
        lblPhone.Text = "Phone:"
        '
        'lblFax
        '
        lblFax.AutoSize = True
        lblFax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFax.Location = New System.Drawing.Point(323, 45)
        lblFax.Name = "lblFax"
        lblFax.Size = New System.Drawing.Size(38, 18)
        lblFax.TabIndex = 34
        lblFax.Text = "Fax:"
        '
        'lblEmail
        '
        lblEmail.AutoSize = True
        lblEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEmail.Location = New System.Drawing.Point(323, 71)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New System.Drawing.Size(52, 18)
        lblEmail.TabIndex = 36
        lblEmail.Text = "Email:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(602, 560)
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
        Me.btnBack.Location = New System.Drawing.Point(12, 560)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 30)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(292, 84)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(105, 34)
        Me.lblTitle.TabIndex = 18
        Me.lblTitle.Text = "Stores"
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.storeTableAdapter = Me.StoreTableAdapter
        Me.TableAdapterManager.tireTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wholesaleOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'StoreBindingNavigator
        '
        Me.StoreBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StoreBindingNavigator.BackColor = System.Drawing.SystemColors.ControlLight
        Me.StoreBindingNavigator.BindingSource = Me.StoreBindingSource
        Me.StoreBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StoreBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StoreBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.StoreBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.StoreBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.ToolStripSeparator1, Me.BindingNavigatorAddNewItem, Me.ToolStripSeparator2, Me.BindingNavigatorDeleteItem, Me.ToolStripSeparator3, Me.StoreBindingNavigatorSaveItem})
        Me.StoreBindingNavigator.Location = New System.Drawing.Point(149, 265)
        Me.StoreBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StoreBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StoreBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StoreBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StoreBindingNavigator.Name = "StoreBindingNavigator"
        Me.StoreBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StoreBindingNavigator.Size = New System.Drawing.Size(370, 28)
        Me.StoreBindingNavigator.TabIndex = 22
        Me.StoreBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorAddNewItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(128, 25)
        Me.BindingNavigatorAddNewItem.Text = "Add New Store"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 25)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        Me.BindingNavigatorCountItem.Visible = False
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorDeleteItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(108, 25)
        Me.BindingNavigatorDeleteItem.Text = "Delete Store"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(33, 25)
        Me.BindingNavigatorMoveFirstItem.Text = "First"
        Me.BindingNavigatorMoveFirstItem.Visible = False
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(56, 25)
        Me.BindingNavigatorMovePreviousItem.Text = "Previous"
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 28)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 28)
        Me.BindingNavigatorSeparator1.Visible = False
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(35, 25)
        Me.BindingNavigatorMoveNextItem.Text = "Next"
        Me.BindingNavigatorMoveNextItem.Visible = False
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(32, 25)
        Me.BindingNavigatorMoveLastItem.Text = "Last"
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 28)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 28)
        Me.ToolStripSeparator1.Visible = False
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 28)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 28)
        '
        'StoreBindingNavigatorSaveItem
        '
        Me.StoreBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.StoreBindingNavigatorSaveItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.StoreBindingNavigatorSaveItem.Image = CType(resources.GetObject("StoreBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StoreBindingNavigatorSaveItem.Name = "StoreBindingNavigatorSaveItem"
        Me.StoreBindingNavigatorSaveItem.Size = New System.Drawing.Size(119, 25)
        Me.StoreBindingNavigatorSaveItem.Text = "Save Changes"
        '
        'txtStoreNbr
        '
        Me.txtStoreNbr.CausesValidation = False
        Me.txtStoreNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "storeNbr", True))
        Me.txtStoreNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoreNbr.Location = New System.Drawing.Point(89, 16)
        Me.txtStoreNbr.Name = "txtStoreNbr"
        Me.txtStoreNbr.ReadOnly = True
        Me.txtStoreNbr.Size = New System.Drawing.Size(190, 26)
        Me.txtStoreNbr.TabIndex = 23
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.CausesValidation = False
        Me.txtStreetAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "streetAddress", True))
        Me.txtStreetAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAddress.Location = New System.Drawing.Point(89, 42)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.ReadOnly = True
        Me.txtStreetAddress.Size = New System.Drawing.Size(190, 26)
        Me.txtStreetAddress.TabIndex = 25
        '
        'txtCity
        '
        Me.txtCity.CausesValidation = False
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "city", True))
        Me.txtCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(89, 68)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(190, 26)
        Me.txtCity.TabIndex = 27
        '
        'txtState
        '
        Me.txtState.CausesValidation = False
        Me.txtState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "state", True))
        Me.txtState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(89, 95)
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(43, 26)
        Me.txtState.TabIndex = 29
        '
        'txtZip
        '
        Me.txtZip.CausesValidation = False
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "zip", True))
        Me.txtZip.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(189, 95)
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(90, 26)
        Me.txtZip.TabIndex = 31
        '
        'txtPhone
        '
        Me.txtPhone.CausesValidation = False
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "phone", True))
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(380, 16)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(161, 26)
        Me.txtPhone.TabIndex = 33
        '
        'txtFax
        '
        Me.txtFax.CausesValidation = False
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "fax", True))
        Me.txtFax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(380, 42)
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(161, 26)
        Me.txtFax.TabIndex = 35
        '
        'txtEmail
        '
        Me.txtEmail.CausesValidation = False
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(380, 68)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(161, 26)
        Me.txtEmail.TabIndex = 37
        '
        'StoreDataGridView
        '
        Me.StoreDataGridView.AllowUserToAddRows = False
        Me.StoreDataGridView.AllowUserToDeleteRows = False
        Me.StoreDataGridView.AutoGenerateColumns = False
        Me.StoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StoreDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.StoreDataGridView.DataSource = Me.StoreBindingSource
        Me.StoreDataGridView.Location = New System.Drawing.Point(12, 308)
        Me.StoreDataGridView.Name = "StoreDataGridView"
        Me.StoreDataGridView.ReadOnly = True
        Me.StoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StoreDataGridView.Size = New System.Drawing.Size(670, 246)
        Me.StoreDataGridView.TabIndex = 37
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "storeNbr"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Store #"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "streetAddress"
        Me.DataGridViewTextBoxColumn2.FillWeight = 120.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Address"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "city"
        Me.DataGridViewTextBoxColumn3.HeaderText = "City"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "state"
        Me.DataGridViewTextBoxColumn4.HeaderText = "State"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "zip"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Zip"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 40
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "phone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "fax"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Fax"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "email"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'grpBoxStoreInfo
        '
        Me.grpBoxStoreInfo.Controls.Add(Me.btnModify)
        Me.grpBoxStoreInfo.Controls.Add(lblStoreNbr)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtStoreNbr)
        Me.grpBoxStoreInfo.Controls.Add(lblStreetAddress)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtStreetAddress)
        Me.grpBoxStoreInfo.Controls.Add(lblCity)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtCity)
        Me.grpBoxStoreInfo.Controls.Add(lblState)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtState)
        Me.grpBoxStoreInfo.Controls.Add(lblZip)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtZip)
        Me.grpBoxStoreInfo.Controls.Add(lblPhone)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtPhone)
        Me.grpBoxStoreInfo.Controls.Add(lblFax)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtFax)
        Me.grpBoxStoreInfo.Controls.Add(lblEmail)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtEmail)
        Me.grpBoxStoreInfo.Location = New System.Drawing.Point(60, 121)
        Me.grpBoxStoreInfo.Name = "grpBoxStoreInfo"
        Me.grpBoxStoreInfo.Size = New System.Drawing.Size(564, 133)
        Me.grpBoxStoreInfo.TabIndex = 38
        Me.grpBoxStoreInfo.TabStop = False
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(350, 100)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(165, 30)
        Me.btnModify.TabIndex = 38
        Me.btnModify.Text = "Modify Details"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NorthwesternTiresCompany.My.Resources.Resources.nwtires_logo_sm
        Me.PictureBox1.Location = New System.Drawing.Point(226, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 76)
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'frmStores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 602)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.grpBoxStoreInfo)
        Me.Controls.Add(Me.StoreDataGridView)
        Me.Controls.Add(Me.StoreBindingNavigator)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stores"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StoreBindingNavigator.ResumeLayout(False)
        Me.StoreBindingNavigator.PerformLayout()
        CType(Me.StoreDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxStoreInfo.ResumeLayout(False)
        Me.grpBoxStoreInfo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents StoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StoreTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents StoreBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents StoreBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents txtStoreNbr As System.Windows.Forms.TextBox
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents StoreDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents grpBoxStoreInfo As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnModify As System.Windows.Forms.Button
End Class
