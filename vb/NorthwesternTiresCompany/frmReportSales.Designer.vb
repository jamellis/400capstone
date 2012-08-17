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
        Me.lblBeginDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.DateTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.btnCreateReport = New System.Windows.Forms.Button()
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
        Me.rvReportSales.Location = New System.Drawing.Point(9, 52)
        Me.rvReportSales.Margin = New System.Windows.Forms.Padding(2)
        Me.rvReportSales.Name = "rvReportSales"
        Me.rvReportSales.Size = New System.Drawing.Size(760, 559)
        Me.rvReportSales.TabIndex = 0
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 626)
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
        Me.btnExit.Location = New System.Drawing.Point(675, 626)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'salesReportTableAdapter
        '
        Me.salesReportTableAdapter.ClearBeforeFill = True
        '
        'lblBeginDate
        '
        Me.lblBeginDate.AutoSize = True
        Me.lblBeginDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBeginDate.Location = New System.Drawing.Point(75, 15)
        Me.lblBeginDate.Name = "lblBeginDate"
        Me.lblBeginDate.Size = New System.Drawing.Size(120, 18)
        Me.lblBeginDate.TabIndex = 18
        Me.lblBeginDate.Text = "Beginning Date:"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndDate.Location = New System.Drawing.Point(334, 15)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(99, 18)
        Me.lblEndDate.TabIndex = 18
        Me.lblEndDate.Text = "Ending Date:"
        '
        'DateTimeBegin
        '
        Me.DateTimeBegin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeBegin.Location = New System.Drawing.Point(201, 9)
        Me.DateTimeBegin.Name = "DateTimeBegin"
        Me.DateTimeBegin.Size = New System.Drawing.Size(127, 26)
        Me.DateTimeBegin.TabIndex = 19
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimeEnd.Location = New System.Drawing.Point(439, 9)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(127, 26)
        Me.DateTimeEnd.TabIndex = 19
        '
        'btnCreateReport
        '
        Me.btnCreateReport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateReport.Location = New System.Drawing.Point(572, 7)
        Me.btnCreateReport.Name = "btnCreateReport"
        Me.btnCreateReport.Size = New System.Drawing.Size(130, 30)
        Me.btnCreateReport.TabIndex = 20
        Me.btnCreateReport.Text = "Create Report"
        Me.btnCreateReport.UseVisualStyleBackColor = True
        '
        'frmReportSales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 665)
        Me.Controls.Add(Me.btnCreateReport)
        Me.Controls.Add(Me.DateTimeEnd)
        Me.Controls.Add(Me.DateTimeBegin)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblBeginDate)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rvReportSales)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmReportSales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Report"
        CType(Me.salesReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rvReportSales As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents salesReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents salesReportTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.salesReportTableAdapter
    Friend WithEvents lblBeginDate As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents DateTimeBegin As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimeEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCreateReport As System.Windows.Forms.Button
End Class
