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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.salesReceiptTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.rvSaleReceipt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SalesReceiptTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.SalesReceiptTableAdapter()
        CType(Me.salesReceiptTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salesReceiptTableAdapterBindingSource
        '
        Me.salesReceiptTableAdapterBindingSource.DataMember = "salesReceiptTableAdapter"
        Me.salesReceiptTableAdapterBindingSource.DataSource = Me.comp400_2012DataSet
        '
        'comp400_2012DataSet
        '
        Me.comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(280, 734)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 30)
        Me.btnOk.TabIndex = 17
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'rvSaleReceipt
        '
        ReportDataSource2.Name = "Customer"
        ReportDataSource2.Value = Me.salesReceiptTableAdapterBindingSource
        Me.rvSaleReceipt.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvSaleReceipt.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptSalesReceipt.rdlc"
        Me.rvSaleReceipt.Location = New System.Drawing.Point(10, 10)
        Me.rvSaleReceipt.Margin = New System.Windows.Forms.Padding(2)
        Me.rvSaleReceipt.Name = "rvSaleReceipt"
        Me.rvSaleReceipt.Size = New System.Drawing.Size(632, 668)
        Me.rvSaleReceipt.TabIndex = 19
        '
        'SalesReceiptTableAdapter
        '
        Me.SalesReceiptTableAdapter.ClearBeforeFill = True
        '
        'frmSalesReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(651, 776)
        Me.ControlBox = False
        Me.Controls.Add(Me.rvSaleReceipt)
        Me.Controls.Add(Me.btnOk)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSalesReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Receipt"
        CType(Me.salesReceiptTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents rvSaleReceipt As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents salesReceiptTableAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents SalesReceiptTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.SalesReceiptTableAdapter
End Class
