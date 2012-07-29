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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rvReportSales = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comp400_2012DataSetSalesReporting = New NorthwesternTiresCompany.comp400_2012DataSetSalesReporting()
        Me.SalesReportTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesReportTableAdapterTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.comp400_2012DataSetSalesReporting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvReportSales
        '
        ReportDataSource1.Name = "SalesReport"
        ReportDataSource1.Value = Me.SalesReportTableAdapterBindingSource
        Me.rvReportSales.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvReportSales.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptSalesReport.rdlc"
        Me.rvReportSales.Location = New System.Drawing.Point(12, 12)
        Me.rvReportSales.Name = "rvReportSales"
        Me.rvReportSales.Size = New System.Drawing.Size(1326, 457)
        Me.rvReportSales.TabIndex = 0
        '
        'comp400_2012DataSetSalesReporting
        '
        Me.comp400_2012DataSetSalesReporting.DataSetName = "comp400_2012DataSetSalesReporting"
        Me.comp400_2012DataSetSalesReporting.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SalesReportTableAdapterBindingSource
        '
        Me.SalesReportTableAdapterBindingSource.DataMember = "SalesReportTableAdapter"
        Me.SalesReportTableAdapterBindingSource.DataSource = Me.comp400_2012DataSetSalesReporting
        '
        'SalesReportTableAdapterTableAdapter
        '
        Me.SalesReportTableAdapterTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(109, 566)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 37)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmReportSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 634)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rvReportSales)
        Me.Name = "frmReportSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportSales"
        CType(Me.comp400_2012DataSetSalesReporting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvReportSales As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalesReportTableAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comp400_2012DataSetSalesReporting As NorthwesternTiresCompany.comp400_2012DataSetSalesReporting
    Friend WithEvents SalesReportTableAdapterTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
