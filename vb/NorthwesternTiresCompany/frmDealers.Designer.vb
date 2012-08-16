<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDealers
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
        Dim lblDealerId As System.Windows.Forms.Label
        Dim lblDealerName As System.Windows.Forms.Label
        Dim lblDealerPhone As System.Windows.Forms.Label
        Dim lblDealerStreet As System.Windows.Forms.Label
        Dim lblDealerCity As System.Windows.Forms.Label
        Dim lblDealerState As System.Windows.Forms.Label
        Dim lblDealerZip As System.Windows.Forms.Label
        Me.lblSales = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblSearch = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUse = New System.Windows.Forms.Button()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.DealerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DealerTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.dealerTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.DealerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDealerZip = New System.Windows.Forms.MaskedTextBox()
        Me.txtDealerPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtDealerState = New System.Windows.Forms.TextBox()
        Me.txtDealerCity = New System.Windows.Forms.TextBox()
        Me.txtDealerStreet = New System.Windows.Forms.TextBox()
        Me.txtDealerName = New System.Windows.Forms.TextBox()
        Me.txtDealerId = New System.Windows.Forms.TextBox()
        lblDealerId = New System.Windows.Forms.Label()
        lblDealerName = New System.Windows.Forms.Label()
        lblDealerPhone = New System.Windows.Forms.Label()
        lblDealerStreet = New System.Windows.Forms.Label()
        lblDealerCity = New System.Windows.Forms.Label()
        lblDealerState = New System.Windows.Forms.Label()
        lblDealerZip = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DealerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDealerId
        '
        lblDealerId.AutoSize = True
        lblDealerId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerId.Location = New System.Drawing.Point(38, 16)
        lblDealerId.Name = "lblDealerId"
        lblDealerId.Size = New System.Drawing.Size(78, 18)
        lblDealerId.TabIndex = 0
        lblDealerId.Text = "Dealer ID:"
        '
        'lblDealerName
        '
        lblDealerName.AutoSize = True
        lblDealerName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerName.Location = New System.Drawing.Point(38, 51)
        lblDealerName.Name = "lblDealerName"
        lblDealerName.Size = New System.Drawing.Size(54, 18)
        lblDealerName.TabIndex = 2
        lblDealerName.Text = "Name:"
        '
        'lblDealerPhone
        '
        lblDealerPhone.AutoSize = True
        lblDealerPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerPhone.Location = New System.Drawing.Point(38, 83)
        lblDealerPhone.Name = "lblDealerPhone"
        lblDealerPhone.Size = New System.Drawing.Size(57, 18)
        lblDealerPhone.TabIndex = 4
        lblDealerPhone.Text = "Phone:"
        '
        'lblDealerStreet
        '
        lblDealerStreet.AutoSize = True
        lblDealerStreet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerStreet.Location = New System.Drawing.Point(306, 16)
        lblDealerStreet.Name = "lblDealerStreet"
        lblDealerStreet.Size = New System.Drawing.Size(71, 18)
        lblDealerStreet.TabIndex = 6
        lblDealerStreet.Text = "Address:"
        '
        'lblDealerCity
        '
        lblDealerCity.AutoSize = True
        lblDealerCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerCity.Location = New System.Drawing.Point(306, 51)
        lblDealerCity.Name = "lblDealerCity"
        lblDealerCity.Size = New System.Drawing.Size(39, 18)
        lblDealerCity.TabIndex = 8
        lblDealerCity.Text = "City:"
        '
        'lblDealerState
        '
        lblDealerState.AutoSize = True
        lblDealerState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerState.Location = New System.Drawing.Point(306, 83)
        lblDealerState.Name = "lblDealerState"
        lblDealerState.Size = New System.Drawing.Size(49, 18)
        lblDealerState.TabIndex = 10
        lblDealerState.Text = "State:"
        '
        'lblDealerZip
        '
        lblDealerZip.AutoSize = True
        lblDealerZip.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lblDealerZip.Location = New System.Drawing.Point(426, 83)
        lblDealerZip.Name = "lblDealerZip"
        lblDealerZip.Size = New System.Drawing.Size(34, 18)
        lblDealerZip.TabIndex = 12
        lblDealerZip.Text = "Zip:"
        '
        'lblSales
        '
        Me.lblSales.AutoSize = True
        Me.lblSales.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSales.Location = New System.Drawing.Point(304, 12)
        Me.lblSales.Name = "lblSales"
        Me.lblSales.Size = New System.Drawing.Size(86, 24)
        Me.lblSales.TabIndex = 21
        Me.lblSales.Text = "Dealers"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(469, 46)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(115, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(261, 48)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(202, 26)
        Me.txtSearch.TabIndex = 1
        '
        'lblSearch
        '
        Me.lblSearch.AutoSize = True
        Me.lblSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearch.Location = New System.Drawing.Point(110, 51)
        Me.lblSearch.Name = "lblSearch"
        Me.lblSearch.Size = New System.Drawing.Size(145, 18)
        Me.lblSearch.TabIndex = 58
        Me.lblSearch.Text = "Search for a dealer:"
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(532, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 30)
        Me.btnExit.TabIndex = 64
        Me.btnExit.Text = "Cancel"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnUse
        '
        Me.btnUse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUse.Location = New System.Drawing.Point(12, 480)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(200, 30)
        Me.btnUse.TabIndex = 63
        Me.btnUse.Text = "Use this Dealer"
        Me.btnUse.UseVisualStyleBackColor = True
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DealerBindingSource
        '
        Me.DealerBindingSource.DataMember = "dealer"
        Me.DealerBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'DealerTableAdapter
        '
        Me.DealerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.customerTableAdapter = Nothing
        Me.TableAdapterManager.dealerTableAdapter = Me.DealerTableAdapter
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
        'DealerDataGridView
        '
        Me.DealerDataGridView.AllowUserToAddRows = False
        Me.DealerDataGridView.AllowUserToDeleteRows = False
        Me.DealerDataGridView.AutoGenerateColumns = False
        Me.DealerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DealerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DealerDataGridView.DataSource = Me.DealerBindingSource
        Me.DealerDataGridView.Location = New System.Drawing.Point(12, 241)
        Me.DealerDataGridView.Name = "DealerDataGridView"
        Me.DealerDataGridView.ReadOnly = True
        Me.DealerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DealerDataGridView.Size = New System.Drawing.Size(669, 233)
        Me.DealerDataGridView.TabIndex = 65
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "dealerId"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Dealer ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "dealerName"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "dealerStreet"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Street"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "dealerCity"
        Me.DataGridViewTextBoxColumn3.HeaderText = "City"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "dealerState"
        Me.DataGridViewTextBoxColumn4.HeaderText = "State"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 70
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "dealerZip"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Zip"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 70
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "dealerPhone"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Phone"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'btnCancel
        '
        Me.btnCancel.Enabled = False
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(553, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(128, 30)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel Changes"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(373, 205)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 30)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save Changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnModify
        '
        Me.btnModify.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModify.Location = New System.Drawing.Point(193, 205)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(128, 30)
        Me.btnModify.TabIndex = 11
        Me.btnModify.Text = "Modify"
        Me.btnModify.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(13, 205)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(128, 30)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDealerZip)
        Me.GroupBox1.Controls.Add(Me.txtDealerPhone)
        Me.GroupBox1.Controls.Add(lblDealerZip)
        Me.GroupBox1.Controls.Add(lblDealerState)
        Me.GroupBox1.Controls.Add(Me.txtDealerState)
        Me.GroupBox1.Controls.Add(lblDealerCity)
        Me.GroupBox1.Controls.Add(Me.txtDealerCity)
        Me.GroupBox1.Controls.Add(lblDealerStreet)
        Me.GroupBox1.Controls.Add(Me.txtDealerStreet)
        Me.GroupBox1.Controls.Add(lblDealerPhone)
        Me.GroupBox1.Controls.Add(lblDealerName)
        Me.GroupBox1.Controls.Add(Me.txtDealerName)
        Me.GroupBox1.Controls.Add(lblDealerId)
        Me.GroupBox1.Controls.Add(Me.txtDealerId)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(605, 114)
        Me.GroupBox1.TabIndex = 70
        Me.GroupBox1.TabStop = False
        '
        'txtDealerZip
        '
        Me.txtDealerZip.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DealerBindingSource, "dealerZip", True))
        Me.txtDealerZip.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerZip.Location = New System.Drawing.Point(466, 80)
        Me.txtDealerZip.Mask = "00000"
        Me.txtDealerZip.Name = "txtDealerZip"
        Me.txtDealerZip.ReadOnly = True
        Me.txtDealerZip.Size = New System.Drawing.Size(100, 26)
        Me.txtDealerZip.TabIndex = 9
        '
        'txtDealerPhone
        '
        Me.txtDealerPhone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DealerBindingSource, "dealerPhone", True))
        Me.txtDealerPhone.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerPhone.Location = New System.Drawing.Point(122, 80)
        Me.txtDealerPhone.Mask = "000-000-0000"
        Me.txtDealerPhone.Name = "txtDealerPhone"
        Me.txtDealerPhone.ReadOnly = True
        Me.txtDealerPhone.Size = New System.Drawing.Size(152, 26)
        Me.txtDealerPhone.TabIndex = 5
        '
        'txtDealerState
        '
        Me.txtDealerState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DealerBindingSource, "dealerState", True))
        Me.txtDealerState.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerState.Location = New System.Drawing.Point(382, 80)
        Me.txtDealerState.MaxLength = 2
        Me.txtDealerState.Name = "txtDealerState"
        Me.txtDealerState.ReadOnly = True
        Me.txtDealerState.Size = New System.Drawing.Size(36, 26)
        Me.txtDealerState.TabIndex = 8
        '
        'txtDealerCity
        '
        Me.txtDealerCity.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DealerBindingSource, "dealerCity", True))
        Me.txtDealerCity.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerCity.Location = New System.Drawing.Point(382, 45)
        Me.txtDealerCity.Name = "txtDealerCity"
        Me.txtDealerCity.ReadOnly = True
        Me.txtDealerCity.Size = New System.Drawing.Size(184, 26)
        Me.txtDealerCity.TabIndex = 7
        '
        'txtDealerStreet
        '
        Me.txtDealerStreet.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DealerBindingSource, "dealerStreet", True))
        Me.txtDealerStreet.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerStreet.Location = New System.Drawing.Point(382, 13)
        Me.txtDealerStreet.Name = "txtDealerStreet"
        Me.txtDealerStreet.ReadOnly = True
        Me.txtDealerStreet.Size = New System.Drawing.Size(184, 26)
        Me.txtDealerStreet.TabIndex = 6
        '
        'txtDealerName
        '
        Me.txtDealerName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DealerBindingSource, "dealerName", True))
        Me.txtDealerName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerName.Location = New System.Drawing.Point(122, 48)
        Me.txtDealerName.Name = "txtDealerName"
        Me.txtDealerName.ReadOnly = True
        Me.txtDealerName.Size = New System.Drawing.Size(152, 26)
        Me.txtDealerName.TabIndex = 4
        '
        'txtDealerId
        '
        Me.txtDealerId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DealerBindingSource, "dealerId", True))
        Me.txtDealerId.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDealerId.Location = New System.Drawing.Point(122, 13)
        Me.txtDealerId.Name = "txtDealerId"
        Me.txtDealerId.ReadOnly = True
        Me.txtDealerId.Size = New System.Drawing.Size(152, 26)
        Me.txtDealerId.TabIndex = 3
        '
        'frmDealers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 522)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.DealerDataGridView)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnUse)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearch)
        Me.Controls.Add(Me.lblSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDealers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dealers"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DealerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSales As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents lblSearch As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnUse As System.Windows.Forms.Button
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents DealerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DealerTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.dealerTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents DealerDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDealerState As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerCity As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerStreet As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerName As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerId As System.Windows.Forms.TextBox
    Friend WithEvents txtDealerPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDealerZip As System.Windows.Forms.MaskedTextBox
End Class
