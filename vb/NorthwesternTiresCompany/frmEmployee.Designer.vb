<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmployee
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
        Dim lblFirstName As System.Windows.Forms.Label
        Dim lblLastName As System.Windows.Forms.Label
        Dim lblUserID As System.Windows.Forms.Label
        Dim lblPassword As System.Windows.Forms.Label
        Dim lblStoreNbr As System.Windows.Forms.Label
        Dim lblUserSecurity As System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.employeeTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grpBoxEmpInfo = New System.Windows.Forms.GroupBox()
        Me.txtStoreNbr = New System.Windows.Forms.ComboBox()
        Me.StoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.StoreTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter()
        Me.txtUserSecurity = New System.Windows.Forms.ComboBox()
        Me.SecurityClearanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SecurityClearanceTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.securityClearanceTableAdapter()
        lblFirstName = New System.Windows.Forms.Label()
        lblLastName = New System.Windows.Forms.Label()
        lblUserID = New System.Windows.Forms.Label()
        lblPassword = New System.Windows.Forms.Label()
        lblStoreNbr = New System.Windows.Forms.Label()
        lblUserSecurity = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpBoxEmpInfo.SuspendLayout()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SecurityClearanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblFirstName
        '
        lblFirstName.AutoSize = True
        lblFirstName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblFirstName.Location = New System.Drawing.Point(28, 21)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New System.Drawing.Size(89, 18)
        lblFirstName.TabIndex = 34
        lblFirstName.Text = "First Name:"
        '
        'lblLastName
        '
        lblLastName.AutoSize = True
        lblLastName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblLastName.Location = New System.Drawing.Point(28, 54)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New System.Drawing.Size(88, 18)
        lblLastName.TabIndex = 36
        lblLastName.Text = "Last Name:"
        '
        'lblUserID
        '
        lblUserID.AutoSize = True
        lblUserID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUserID.Location = New System.Drawing.Point(308, 54)
        lblUserID.Name = "lblUserID"
        lblUserID.Size = New System.Drawing.Size(64, 18)
        lblUserID.TabIndex = 38
        lblUserID.Text = "User ID:"
        '
        'lblPassword
        '
        lblPassword.AutoSize = True
        lblPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblPassword.Location = New System.Drawing.Point(308, 86)
        lblPassword.Name = "lblPassword"
        lblPassword.Size = New System.Drawing.Size(82, 18)
        lblPassword.TabIndex = 40
        lblPassword.Text = "Password:"
        '
        'lblStoreNbr
        '
        lblStoreNbr.AutoSize = True
        lblStoreNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblStoreNbr.Location = New System.Drawing.Point(308, 21)
        lblStoreNbr.Name = "lblStoreNbr"
        lblStoreNbr.Size = New System.Drawing.Size(109, 18)
        lblStoreNbr.TabIndex = 42
        lblStoreNbr.Text = "Store Number:"
        '
        'lblUserSecurity
        '
        lblUserSecurity.AutoSize = True
        lblUserSecurity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblUserSecurity.Location = New System.Drawing.Point(28, 86)
        lblUserSecurity.Name = "lblUserSecurity"
        lblUserSecurity.Size = New System.Drawing.Size(84, 18)
        lblUserSecurity.TabIndex = 44
        lblUserSecurity.Text = "Clearance:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(592, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 30
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
        Me.btnBack.TabIndex = 29
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(285, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(124, 26)
        Me.lblTitle.TabIndex = 31
        Me.lblTitle.Text = "Employees"
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.dealerTableAdapter = Nothing
        Me.TableAdapterManager.employeeTableAdapter = Me.EmployeeTableAdapter
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
        Me.TableAdapterManager.wholesaleOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "firstName", True))
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(123, 19)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.ReadOnly = True
        Me.txtFirstName.Size = New System.Drawing.Size(157, 26)
        Me.txtFirstName.TabIndex = 2
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "lastName", True))
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(123, 51)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.ReadOnly = True
        Me.txtLastName.Size = New System.Drawing.Size(157, 26)
        Me.txtLastName.TabIndex = 3
        '
        'txtUserID
        '
        Me.txtUserID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "userID", True))
        Me.txtUserID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(423, 51)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(139, 26)
        Me.txtUserID.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "password", True))
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(423, 83)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(139, 26)
        Me.txtPassword.TabIndex = 7
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AllowUserToDeleteRows = False
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(13, 246)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.ReadOnly = True
        Me.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(669, 228)
        Me.EmployeeDataGridView.TabIndex = 45
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "employeeID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "employeeID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "firstName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "First Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lastName"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Last Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "storeNbr"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Store Number"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "userSecurityLevel"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Clearance"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "userID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "User ID"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "password"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Password"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'grpBoxEmpInfo
        '
        Me.grpBoxEmpInfo.Controls.Add(Me.txtUserSecurity)
        Me.grpBoxEmpInfo.Controls.Add(Me.txtStoreNbr)
        Me.grpBoxEmpInfo.Controls.Add(Me.txtFirstName)
        Me.grpBoxEmpInfo.Controls.Add(Me.txtLastName)
        Me.grpBoxEmpInfo.Controls.Add(lblUserID)
        Me.grpBoxEmpInfo.Controls.Add(lblFirstName)
        Me.grpBoxEmpInfo.Controls.Add(lblLastName)
        Me.grpBoxEmpInfo.Controls.Add(Me.txtUserID)
        Me.grpBoxEmpInfo.Controls.Add(lblPassword)
        Me.grpBoxEmpInfo.Controls.Add(Me.txtPassword)
        Me.grpBoxEmpInfo.Controls.Add(lblStoreNbr)
        Me.grpBoxEmpInfo.Controls.Add(lblUserSecurity)
        Me.grpBoxEmpInfo.Location = New System.Drawing.Point(48, 82)
        Me.grpBoxEmpInfo.Name = "grpBoxEmpInfo"
        Me.grpBoxEmpInfo.Size = New System.Drawing.Size(599, 122)
        Me.grpBoxEmpInfo.TabIndex = 47
        Me.grpBoxEmpInfo.TabStop = False
        '
        'txtStoreNbr
        '
        Me.txtStoreNbr.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "storeNbr", True))
        Me.txtStoreNbr.DataSource = Me.StoreBindingSource
        Me.txtStoreNbr.DisplayMember = "storeNbr"
        Me.txtStoreNbr.Enabled = False
        Me.txtStoreNbr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStoreNbr.FormattingEnabled = True
        Me.txtStoreNbr.Location = New System.Drawing.Point(423, 18)
        Me.txtStoreNbr.Name = "txtStoreNbr"
        Me.txtStoreNbr.Size = New System.Drawing.Size(139, 26)
        Me.txtStoreNbr.TabIndex = 5
        Me.txtStoreNbr.ValueMember = "storeNbr"
        '
        'StoreBindingSource
        '
        Me.StoreBindingSource.DataMember = "store"
        Me.StoreBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(485, 46)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(115, 30)
        Me.btnSearch.TabIndex = 50
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(277, 48)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(202, 26)
        Me.txtSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(94, 51)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(177, 18)
        Me.lblSearch.TabIndex = 48
        Me.lblSearch.Text = "Search for an employee:"
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(283, 210)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(128, 30)
        Me.btnDelete.TabIndex = 53
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(553, 210)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 30)
        Me.btnCancel.TabIndex = 55
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(418, 210)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 30)
        Me.btnSave.TabIndex = 54
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(148, 210)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(128, 30)
        Me.btnModify.TabIndex = 52
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 210)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 30)
        Me.btnAdd.TabIndex = 51
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'StoreTableAdapter
        '
        Me.StoreTableAdapter.ClearBeforeFill = True
        '
        'txtUserSecurity
        '
        Me.txtUserSecurity.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "userSecurityLevel", True))
        Me.txtUserSecurity.DataSource = Me.SecurityClearanceBindingSource
        Me.txtUserSecurity.DisplayMember = "Clearance"
        Me.txtUserSecurity.Enabled = False
        Me.txtUserSecurity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserSecurity.FormattingEnabled = True
        Me.txtUserSecurity.Location = New System.Drawing.Point(123, 83)
        Me.txtUserSecurity.Name = "txtUserSecurity"
        Me.txtUserSecurity.Size = New System.Drawing.Size(157, 26)
        Me.txtUserSecurity.TabIndex = 56
        Me.txtUserSecurity.ValueMember = "Clearance"
        '
        'SecurityClearanceBindingSource
        '
        Me.SecurityClearanceBindingSource.DataMember = "securityClearance"
        Me.SecurityClearanceBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'SecurityClearanceTableAdapter
        '
        Me.SecurityClearanceTableAdapter.ClearBeforeFill = True
        '
        'frmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.grpBoxEmpInfo)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employees"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpBoxEmpInfo.ResumeLayout(False)
        Me.grpBoxEmpInfo.PerformLayout()
        CType(Me.StoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SecurityClearanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents EmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.employeeTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents EmployeeDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents grpBoxEmpInfo As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtStoreNbr As System.Windows.Forms.ComboBox
    Friend WithEvents StoreBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StoreTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter
    Friend WithEvents txtUserSecurity As System.Windows.Forms.ComboBox
    Friend WithEvents SecurityClearanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SecurityClearanceTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.securityClearanceTableAdapter
End Class
