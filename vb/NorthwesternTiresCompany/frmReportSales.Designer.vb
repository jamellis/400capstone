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
        Me.salesReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.rvReportSales = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.salesReportTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.salesReportTableAdapter()
        CType(Me.salesReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'salesReportTableBindingSource
        '
        Me.salesReportTableBindingSource.DataMember = "salesReportTable"
        Me.salesReportTableBindingSource.DataSource = Me.Comp400_2012DataSet
        '
        'Comp400_2012DataSet
        '
        Me.Comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.Comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvReportSales
        '
        ReportDataSource1.Name = "Sales"
        ReportDataSource1.Value = Me.salesReportTableBindingSource
        Me.rvReportSales.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvReportSales.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptSalesReport.rdlc"
        Me.rvReportSales.Location = New System.Drawing.Point(12, 12)
        Me.rvReportSales.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.rvReportSales.Name = "rvReportSales"
        Me.rvReportSales.Size = New System.Drawing.Size(907, 864)
        Me.rvReportSales.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(17, 895)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 37)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(764, 895)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 37)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'salesReportTableAdapter
        '
        Me.salesReportTableAdapter.ClearBeforeFill = True
        '
        'frmReportSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 955)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rvReportSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmReportSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        CType(Me.salesReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvReportSales As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents salesReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents salesReportTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.salesReportTableAdapter
End Class
