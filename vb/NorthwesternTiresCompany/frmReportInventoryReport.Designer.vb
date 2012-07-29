<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportInventoryReport
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
        Me.rvInventoryReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.InventoryReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryReportTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.InventoryReportTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rvInventoryReport
        '
        ReportDataSource2.Name = "InventoryReport"
        ReportDataSource2.Value = Me.InventoryReportTableBindingSource
        Me.rvInventoryReport.LocalReport.DataSources.Add(ReportDataSource2)
        Me.rvInventoryReport.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptInventoryReport.rdlc"
        Me.rvInventoryReport.Location = New System.Drawing.Point(12, 26)
        Me.rvInventoryReport.Name = "rvInventoryReport"
        Me.rvInventoryReport.Size = New System.Drawing.Size(1483, 635)
        Me.rvInventoryReport.TabIndex = 0
        '
        'comp400_2012DataSet
        '
        Me.comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryReportTableBindingSource
        '
        Me.InventoryReportTableBindingSource.DataMember = "InventoryReportTable"
        Me.InventoryReportTableBindingSource.DataSource = Me.comp400_2012DataSet
        '
        'InventoryReportTableAdapter
        '
        Me.InventoryReportTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(45, 682)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 37)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmReportInventoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1507, 732)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rvInventoryReport)
        Me.Name = "frmReportInventoryReport"
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvInventoryReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InventoryReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents InventoryReportTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.InventoryReportTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
End Class
