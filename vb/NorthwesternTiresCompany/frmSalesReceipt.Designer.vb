<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSalesReceipt
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.rvSaleReceipt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.salesReceiptTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesReceiptTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.SalesReceiptTableAdapter()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.salesReceiptTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(735, 895)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 37)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(13, 895)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 37)
        Me.btnBack.TabIndex = 17
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'rvSaleReceipt
        '
        ReportDataSource1.Name = "Customer"
        ReportDataSource1.Value = Me.salesReceiptTableAdapterBindingSource
        Me.rvSaleReceipt.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvSaleReceipt.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptSalesReceipt.rdlc"
        Me.rvSaleReceipt.Location = New System.Drawing.Point(13, 12)
        Me.rvSaleReceipt.Name = "rvSaleReceipt"
        Me.rvSaleReceipt.Size = New System.Drawing.Size(842, 822)
        Me.rvSaleReceipt.TabIndex = 19
        '
        'comp400_2012DataSet
        '
        Me.comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'salesReceiptTableAdapterBindingSource
        '
        Me.salesReceiptTableAdapterBindingSource.DataMember = "salesReceiptTableAdapter"
        Me.salesReceiptTableAdapterBindingSource.DataSource = Me.comp400_2012DataSet
        '
        'SalesReceiptTableAdapter
        '
        Me.SalesReceiptTableAdapter.ClearBeforeFill = True
        '
        'frmSalesReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 955)
        Me.Controls.Add(Me.rvSaleReceipt)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmSalesReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmSalesReceipt"
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.salesReceiptTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents rvSaleReceipt As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents salesReceiptTableAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents SalesReceiptTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.SalesReceiptTableAdapter
End Class
