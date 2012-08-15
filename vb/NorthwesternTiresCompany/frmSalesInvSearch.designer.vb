<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesInvSearch
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStore = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.StoreTableAdapter1 = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter()
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.InvSearchBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InvSearchTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter()
        Me.TableAdapterManager = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager()
        Me.InvSearchDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUse = New System.Windows.Forms.Button()
        Me.TireCodeTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.ManufacturerSizeTextBox = New System.Windows.Forms.TextBox()
        Me.RetailPriceTextBox = New System.Windows.Forms.TextBox()
        Me.TireQtyTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        TireCodeLabel = New System.Windows.Forms.Label()
        ManufacturerLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        ManufacturerSizeLabel = New System.Windows.Forms.Label()
        RetailPriceLabel = New System.Windows.Forms.Label()
        TireQtyLabel = New System.Windows.Forms.Label()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvSearchBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InvSearchDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TireCodeLabel
        '
        TireCodeLabel.AutoSize = True
        TireCodeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TireCodeLabel.Location = New System.Drawing.Point(381, 28)
        TireCodeLabel.Name = "TireCodeLabel"
        TireCodeLabel.Size = New System.Drawing.Size(81, 20)
        TireCodeLabel.TabIndex = 64
        TireCodeLabel.Text = "Tire Code:"
        '
        'ManufacturerLabel
        '
        ManufacturerLabel.AutoSize = True
        ManufacturerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ManufacturerLabel.Location = New System.Drawing.Point(29, 28)
        ManufacturerLabel.Name = "ManufacturerLabel"
        ManufacturerLabel.Size = New System.Drawing.Size(108, 20)
        ManufacturerLabel.TabIndex = 66
        ManufacturerLabel.Text = "Manufacturer:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DescriptionLabel.Location = New System.Drawing.Point(29, 95)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(93, 20)
        DescriptionLabel.TabIndex = 68
        DescriptionLabel.Text = "Description:"
        '
        'ManufacturerSizeLabel
        '
        ManufacturerSizeLabel.AutoSize = True
        ManufacturerSizeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ManufacturerSizeLabel.Location = New System.Drawing.Point(29, 63)
        ManufacturerSizeLabel.Name = "ManufacturerSizeLabel"
        ManufacturerSizeLabel.Size = New System.Drawing.Size(74, 20)
        ManufacturerSizeLabel.TabIndex = 70
        ManufacturerSizeLabel.Text = "Tire Size:"
        '
        'RetailPriceLabel
        '
        RetailPriceLabel.AutoSize = True
        RetailPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RetailPriceLabel.Location = New System.Drawing.Point(381, 60)
        RetailPriceLabel.Name = "RetailPriceLabel"
        RetailPriceLabel.Size = New System.Drawing.Size(48, 20)
        RetailPriceLabel.TabIndex = 72
        RetailPriceLabel.Text = "Price:"
        '
        'TireQtyLabel
        '
        TireQtyLabel.AutoSize = True
        TireQtyLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TireQtyLabel.Location = New System.Drawing.Point(381, 92)
        TireQtyLabel.Name = "TireQtyLabel"
        TireQtyLabel.Size = New System.Drawing.Size(77, 20)
        TireQtyLabel.TabIndex = 74
        TireQtyLabel.Text = "On Hand:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(229, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(226, 24)
        Me.lblTitle.TabIndex = 20
        Me.lblTitle.Text = "Tire Inventory Search"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(400, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Store Number:"
        '
        'cboStore
        '
        Me.cboStore.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStore.FormattingEnabled = True
        Me.cboStore.Items.AddRange(New Object() {"All", "0001", "0002", "0003", "0004", "0005", "0006", "0007", "0008", "0009", "0010"})
        Me.cboStore.Location = New System.Drawing.Point(508, 54)
        Me.cboStore.Name = "cboStore"
        Me.cboStore.Size = New System.Drawing.Size(161, 24)
        Me.cboStore.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(279, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(80, 30)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(12, 49)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(261, 26)
        Me.txtSearch.TabIndex = 1
        '
        'StoreTableAdapter1
        '
        Me.StoreTableAdapter1.ClearBeforeFill = True
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.storeTableAdapter = Me.StoreTableAdapter1
        Me.TableAdapterManager.tireTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderDetailTableAdapter = Nothing
        Me.TableAdapterManager.transferOrderTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendorTableAdapter = Nothing
        Me.TableAdapterManager.wholesaleOrderTableAdapter = Nothing
        '
        'InvSearchDataGridView
        '
        Me.InvSearchDataGridView.AllowUserToAddRows = False
        Me.InvSearchDataGridView.AllowUserToDeleteRows = False
        Me.InvSearchDataGridView.AutoGenerateColumns = False
        Me.InvSearchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvSearchDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.InvSearchDataGridView.DataSource = Me.InvSearchBindingSource
        Me.InvSearchDataGridView.Location = New System.Drawing.Point(12, 104)
        Me.InvSearchDataGridView.Name = "InvSearchDataGridView"
        Me.InvSearchDataGridView.ReadOnly = True
        Me.InvSearchDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.InvSearchDataGridView.Size = New System.Drawing.Size(668, 194)
        Me.InvSearchDataGridView.TabIndex = 49
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tireCode"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Tire Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "manufacturer"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Manufacturer"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn3.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "manufacturerSize"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Size"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "retailPrice"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 80
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "tireQty"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 80
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "storeNbr"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Store"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(532, 481)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(150, 30)
        Me.btnCancel.TabIndex = 64
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUse
        '
        Me.btnUse.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUse.Location = New System.Drawing.Point(12, 481)
        Me.btnUse.Name = "btnUse"
        Me.btnUse.Size = New System.Drawing.Size(200, 30)
        Me.btnUse.TabIndex = 63
        Me.btnUse.Text = "Select this Tire"
        Me.btnUse.UseVisualStyleBackColor = True
        '
        'TireCodeTextBox
        '
        Me.TireCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "tireCode", True))
        Me.TireCodeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TireCodeTextBox.Location = New System.Drawing.Point(468, 25)
        Me.TireCodeTextBox.Name = "TireCodeTextBox"
        Me.TireCodeTextBox.ReadOnly = True
        Me.TireCodeTextBox.Size = New System.Drawing.Size(138, 26)
        Me.TireCodeTextBox.TabIndex = 7
        '
        'ManufacturerTextBox
        '
        Me.ManufacturerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "manufacturer", True))
        Me.ManufacturerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerTextBox.Location = New System.Drawing.Point(143, 25)
        Me.ManufacturerTextBox.Name = "ManufacturerTextBox"
        Me.ManufacturerTextBox.ReadOnly = True
        Me.ManufacturerTextBox.Size = New System.Drawing.Size(153, 26)
        Me.ManufacturerTextBox.TabIndex = 4
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "description", True))
        Me.DescriptionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescriptionTextBox.Location = New System.Drawing.Point(143, 92)
        Me.DescriptionTextBox.Multiline = True
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.ReadOnly = True
        Me.DescriptionTextBox.Size = New System.Drawing.Size(232, 60)
        Me.DescriptionTextBox.TabIndex = 6
        '
        'ManufacturerSizeTextBox
        '
        Me.ManufacturerSizeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "manufacturerSize", True))
        Me.ManufacturerSizeTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ManufacturerSizeTextBox.Location = New System.Drawing.Point(143, 60)
        Me.ManufacturerSizeTextBox.Name = "ManufacturerSizeTextBox"
        Me.ManufacturerSizeTextBox.ReadOnly = True
        Me.ManufacturerSizeTextBox.Size = New System.Drawing.Size(153, 26)
        Me.ManufacturerSizeTextBox.TabIndex = 5
        '
        'RetailPriceTextBox
        '
        Me.RetailPriceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "retailPrice", True))
        Me.RetailPriceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RetailPriceTextBox.Location = New System.Drawing.Point(468, 57)
        Me.RetailPriceTextBox.Name = "RetailPriceTextBox"
        Me.RetailPriceTextBox.ReadOnly = True
        Me.RetailPriceTextBox.Size = New System.Drawing.Size(138, 26)
        Me.RetailPriceTextBox.TabIndex = 8
        '
        'TireQtyTextBox
        '
        Me.TireQtyTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InvSearchBindingSource, "tireQty", True))
        Me.TireQtyTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TireQtyTextBox.Location = New System.Drawing.Point(468, 89)
        Me.TireQtyTextBox.Name = "TireQtyTextBox"
        Me.TireQtyTextBox.ReadOnly = True
        Me.TireQtyTextBox.Size = New System.Drawing.Size(138, 26)
        Me.TireQtyTextBox.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(TireCodeLabel)
        Me.GroupBox1.Controls.Add(Me.TireCodeTextBox)
        Me.GroupBox1.Controls.Add(ManufacturerLabel)
        Me.GroupBox1.Controls.Add(Me.ManufacturerTextBox)
        Me.GroupBox1.Controls.Add(DescriptionLabel)
        Me.GroupBox1.Controls.Add(Me.DescriptionTextBox)
        Me.GroupBox1.Controls.Add(ManufacturerSizeLabel)
        Me.GroupBox1.Controls.Add(Me.ManufacturerSizeTextBox)
        Me.GroupBox1.Controls.Add(RetailPriceLabel)
        Me.GroupBox1.Controls.Add(Me.RetailPriceTextBox)
        Me.GroupBox1.Controls.Add(TireQtyLabel)
        Me.GroupBox1.Controls.Add(Me.TireQtyTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 317)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(650, 158)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        '
        'frmSalesInvSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(692, 523)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUse)
        Me.Controls.Add(Me.InvSearchDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboStore)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmSalesInvSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tire Inventory Search"
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvSearchBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InvSearchDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStore As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents StoreTableAdapter1 As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.storeTableAdapter
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents InvSearchBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InvSearchTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.invSearchTableAdapter
    Friend WithEvents TableAdapterManager As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.TableAdapterManager
    Friend WithEvents InvSearchDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnUse As System.Windows.Forms.Button
    Friend WithEvents TireCodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManufacturerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ManufacturerSizeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RetailPriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TireQtyTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
