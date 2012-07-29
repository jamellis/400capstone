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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.lblReports = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comp400_2012DataSetSalesReporting = New NorthwesternTiresCompany.comp400_2012DataSetSalesReporting()
        Me.SalesReportTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesReportTableAdapterTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter()
        CType(Me.comp400_2012DataSetSalesReporting, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'ReportViewer1
        '
        ReportDataSource1.Name = "salesReport"
        ReportDataSource1.Value = Me.SalesReportTableAdapterBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(24, 70)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(849, 446)
        Me.ReportViewer1.TabIndex = 1
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
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 660)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.lblReports)
        Me.Name = "frmReport"
        Me.Text = "frmReport"
        CType(Me.comp400_2012DataSetSalesReporting, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReports As System.Windows.Forms.Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SalesReportTableAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comp400_2012DataSetSalesReporting As NorthwesternTiresCompany.comp400_2012DataSetSalesReporting
    Friend WithEvents SalesReportTableAdapterTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter
End Class
