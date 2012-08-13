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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.StoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StoreTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
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
        Me.lblSave = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtStoreNbr = New System.Windows.Forms.TextBox()
        Me.txtZip = New System.Windows.Forms.MaskedTextBox()
        Me.txtFax = New System.Windows.Forms.MaskedTextBox()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
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
        CType(Me.StoreDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxStoreInfo.SuspendLayout()
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
        lblStreetAddress.Location = New System.Drawing.Point(16, 52)
        lblStreetAddress.Name = "lblStreetAddress"
        lblStreetAddress.Size = New System.Drawing.Size(71, 18)
        lblStreetAddress.TabIndex = 24
        lblStreetAddress.Text = "Address:"
        '
        'lblCity
        '
        lblCity.AutoSize = True
        lblCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblCity.Location = New System.Drawing.Point(16, 84)
        lblCity.Name = "lblCity"
        lblCity.Size = New System.Drawing.Size(39, 18)
        lblCity.TabIndex = 26
        lblCity.Text = "City:"
        '
        'lblState
        '
        lblState.AutoSize = True
        lblState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblState.Location = New System.Drawing.Point(16, 116)
        lblState.Name = "lblState"
        lblState.Size = New System.Drawing.Size(49, 18)
        lblState.TabIndex = 28
        lblState.Text = "State:"
        '
        'lblZip
        '
        lblZip.AutoSize = True
        lblZip.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblZip.Location = New System.Drawing.Point(141, 116)
        lblZip.Name = "lblZip"
        lblZip.Size = New System.Drawing.Size(34, 18)
        lblZip.TabIndex = 30
        lblZip.Text = "Zip:"
        '
        'lblPhone
        '
        lblPhone.AutoSize = True
        lblPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPhone.Location = New System.Drawing.Point(322, 17)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New System.Drawing.Size(57, 18)
        lblPhone.TabIndex = 32
        lblPhone.Text = "Phone:"
        '
        'lblFax
        '
        lblFax.AutoSize = True
        lblFax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFax.Location = New System.Drawing.Point(322, 52)
        lblFax.Name = "lblFax"
        lblFax.Size = New System.Drawing.Size(38, 18)
        lblFax.TabIndex = 34
        lblFax.Text = "Fax:"
        '
        'lblEmail
        '
        lblEmail.AutoSize = True
        lblEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblEmail.Location = New System.Drawing.Point(322, 84)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New System.Drawing.Size(52, 18)
        lblEmail.TabIndex = 36
        lblEmail.Text = "Email:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(602, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 30)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 480)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 30)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(308, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(79, 26)
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
        Me.TableAdapterManager.retailOrderTableAdapter = Nothing
        Me.TableAdapterManager.storeTableAdapter = Me.StoreTableAdapter
        Me.TableAdapterManager.tireTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.CausesValidation = False
        Me.txtStreetAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "streetAddress", True))
        Me.txtStreetAddress.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStreetAddress.Location = New System.Drawing.Point(89, 49)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.ReadOnly = True
        Me.txtStreetAddress.Size = New System.Drawing.Size(190, 26)
        Me.txtStreetAddress.TabIndex = 2
        '
        'txtCity
        '
        Me.txtCity.CausesValidation = False
        Me.txtCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "city", True))
        Me.txtCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCity.Location = New System.Drawing.Point(89, 81)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.ReadOnly = True
        Me.txtCity.Size = New System.Drawing.Size(190, 26)
        Me.txtCity.TabIndex = 3
        '
        'txtEmail
        '
        Me.txtEmail.CausesValidation = False
        Me.txtEmail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "email", True))
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(380, 81)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(161, 26)
        Me.txtEmail.TabIndex = 8
        '
        'StoreDataGridView
        '
        Me.StoreDataGridView.AllowUserToAddRows = False
        Me.StoreDataGridView.AllowUserToDeleteRows = False
        Me.StoreDataGridView.AutoGenerateColumns = False
        Me.StoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StoreDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.StoreDataGridView.DataSource = Me.StoreBindingSource
        Me.StoreDataGridView.Location = New System.Drawing.Point(12, 234)
        Me.StoreDataGridView.Name = "StoreDataGridView"
        Me.StoreDataGridView.ReadOnly = True
        Me.StoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StoreDataGridView.Size = New System.Drawing.Size(670, 238)
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
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "state"
        Me.DataGridViewTextBoxColumn4.HeaderText = "State"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 50
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
        Me.grpBoxStoreInfo.Controls.Add(Me.lblSave)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtState)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtStoreNbr)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtZip)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtFax)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtPhone)
        Me.grpBoxStoreInfo.Controls.Add(lblStoreNbr)
        Me.grpBoxStoreInfo.Controls.Add(lblStreetAddress)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtStreetAddress)
        Me.grpBoxStoreInfo.Controls.Add(lblCity)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtCity)
        Me.grpBoxStoreInfo.Controls.Add(lblState)
        Me.grpBoxStoreInfo.Controls.Add(lblZip)
        Me.grpBoxStoreInfo.Controls.Add(lblPhone)
        Me.grpBoxStoreInfo.Controls.Add(lblFax)
        Me.grpBoxStoreInfo.Controls.Add(lblEmail)
        Me.grpBoxStoreInfo.Controls.Add(Me.txtEmail)
        Me.grpBoxStoreInfo.Location = New System.Drawing.Point(65, 38)
        Me.grpBoxStoreInfo.Name = "grpBoxStoreInfo"
        Me.grpBoxStoreInfo.Size = New System.Drawing.Size(564, 154)
        Me.grpBoxStoreInfo.TabIndex = 38
        Me.grpBoxStoreInfo.TabStop = False
        '
        'lblSave
        '
        Me.lblSave.AutoSize = True
        Me.lblSave.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSave.Location = New System.Drawing.Point(317, 109)
        Me.lblSave.Name = "lblSave"
        Me.lblSave.Size = New System.Drawing.Size(240, 36)
        Me.lblSave.TabIndex = 37
        Me.lblSave.Text = "Please fill in all information before" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "clicking save changes"
        Me.lblSave.Visible = False
        '
        'txtState
        '
        Me.txtState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "state", True))
        Me.txtState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtState.Location = New System.Drawing.Point(89, 113)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.ReadOnly = True
        Me.txtState.Size = New System.Drawing.Size(40, 26)
        Me.txtState.TabIndex = 4
        '
        'txtStoreNbr
        '
        Me.txtStoreNbr.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "storeNbr", True))
        Me.txtStoreNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoreNbr.Location = New System.Drawing.Point(89, 17)
        Me.txtStoreNbr.MaxLength = 4
        Me.txtStoreNbr.Name = "txtStoreNbr"
        Me.txtStoreNbr.ReadOnly = True
        Me.txtStoreNbr.Size = New System.Drawing.Size(190, 26)
        Me.txtStoreNbr.TabIndex = 1
        '
        'txtZip
        '
        Me.txtZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "zip", True))
        Me.txtZip.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtZip.Location = New System.Drawing.Point(181, 113)
        Me.txtZip.Mask = "00000"
        Me.txtZip.Name = "txtZip"
        Me.txtZip.ReadOnly = True
        Me.txtZip.Size = New System.Drawing.Size(98, 26)
        Me.txtZip.TabIndex = 5
        '
        'txtFax
        '
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "fax", True))
        Me.txtFax.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFax.Location = New System.Drawing.Point(381, 49)
        Me.txtFax.Mask = "000-000-0000"
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        Me.txtFax.Size = New System.Drawing.Size(160, 26)
        Me.txtFax.TabIndex = 7
        '
        'txtPhone
        '
        Me.txtPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StoreBindingSource, "phone", True))
        Me.txtPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(381, 16)
        Me.txtPhone.Mask = "000-000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(160, 26)
        Me.txtPhone.TabIndex = 6
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(147, 198)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(128, 30)
        Me.btnModify.TabIndex = 11
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(417, 198)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 30)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(282, 198)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 30)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(12, 198)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 30)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(552, 198)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 30)
        Me.btnCancel.TabIndex = 39
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmStores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.grpBoxStoreInfo)
        Me.Controls.Add(Me.StoreDataGridView)
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
        CType(Me.StoreDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxStoreInfo.ResumeLayout(False)
        Me.grpBoxStoreInfo.PerformLayout()
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
    Friend WithEvents txtStreetAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents StoreDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents grpBoxStoreInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents txtStoreNbr As System.Windows.Forms.TextBox
    Friend WithEvents txtZip As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFax As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSave As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
