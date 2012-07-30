<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportSales
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SalesReportTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comp400_2012DataSetSalesReporting = New NorthwesternTiresCompany.comp400_2012DataSetSalesReporting()
        Me.rvReportSales = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SalesReportTableAdapterTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
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
        'rvReportSales
        '
        ReportDataSource3.Name = "SalesReport"
        ReportDataSource3.Value = Me.SalesReportTableAdapterBindingSource
        Me.rvReportSales.LocalReport.DataSources.Add(ReportDataSource3)
        Me.rvReportSales.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptSalesReport.rdlc"
        Me.rvReportSales.Location = New System.Drawing.Point(9, 10)
        Me.rvReportSales.Margin = New System.Windows.Forms.Padding(2)
        Me.rvReportSales.Name = "rvReportSales"
        Me.rvReportSales.Size = New System.Drawing.Size(995, 372)
        Me.rvReportSales.TabIndex = 0
        '
        'SalesReportTableAdapterTableAdapter
        '
        Me.SalesReportTableAdapterTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 473)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(911, 473)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmReportSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 515)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rvReportSales)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmReportSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comp400_2012DataSetSalesReporting, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvReportSales As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalesReportTableAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comp400_2012DataSetSalesReporting As NorthwesternTiresCompany.comp400_2012DataSetSalesReporting
    Friend WithEvents SalesReportTableAdapterTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
