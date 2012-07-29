<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReport
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
        Me.SalesReportTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comp400_2012DataSetSalesReporting = New NorthwesternTiresCompany.comp400_2012DataSetSalesReporting()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.SalesReportTableAdapterTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter()
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnInventoryReport = New System.Windows.Forms.Button()
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comp400_2012DataSetSalesReporting, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesReportTableAdapterBindingSource
        '
        Me.SalesReportTableAdapterBindingSource.DataMember = "SalesReportTableAdapter"
        Me.SalesReportTableAdapterBindingSource.DataSource = Me.comp400_2012DataSetSalesReporting
        '
        'comp400_2012DataSetSalesReporting
        '
        Me.comp400_2012DataSetSalesReporting.DataSetName = "comp400_2012DataSetSalesReporting"
        Me.comp400_2012DataSetSalesReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReports.Location = New System.Drawing.Point(395, 20)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(120, 33)
        Me.lblReports.TabIndex = 0
        Me.lblReports.Text = "Reports"
        '
        'SalesReportTableAdapterTableAdapter
        '
        Me.SalesReportTableAdapterTableAdapter.ClearBeforeFill = True
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReport.Location = New System.Drawing.Point(151, 127)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(214, 47)
        Me.btnSalesReport.TabIndex = 1
        Me.btnSalesReport.Text = "Sales Report"
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(868, 610)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 37)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(112, 610)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 37)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnInventoryReport
        '
        Me.btnInventoryReport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryReport.Location = New System.Drawing.Point(151, 199)
        Me.btnInventoryReport.Name = "btnInventoryReport"
        Me.btnInventoryReport.Size = New System.Drawing.Size(214, 51)
        Me.btnInventoryReport.TabIndex = 16
        Me.btnInventoryReport.Text = "Inventory Report"
        Me.btnInventoryReport.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 660)
        Me.Controls.Add(Me.btnInventoryReport)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSalesReport)
        Me.Controls.Add(Me.lblReports)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReport"
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comp400_2012DataSetSalesReporting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReports As System.Windows.Forms.Label
    Friend WithEvents SalesReportTableAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comp400_2012DataSetSalesReporting As NorthwesternTiresCompany.comp400_2012DataSetSalesReporting
    Friend WithEvents SalesReportTableAdapterTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter
    Friend WithEvents btnSalesReport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnInventoryReport As System.Windows.Forms.Button
End Class
