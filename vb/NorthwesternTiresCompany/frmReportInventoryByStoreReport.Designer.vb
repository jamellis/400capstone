﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportInventoryByStoreReport
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
        Me.InventoryReportTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.rvInventoryReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.InventoryReportTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.InventoryReportTableAdapter()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.InventoryReportTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InventoryReportTableBindingSource
        '
        Me.InventoryReportTableBindingSource.DataMember = "InventoryReportTable"
        Me.InventoryReportTableBindingSource.DataSource = Me.comp400_2012DataSet
        '
        'comp400_2012DataSet
        '
        Me.comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvInventoryReport
        '
        ReportDataSource1.Name = "Inventory"
        ReportDataSource1.Value = Me.InventoryReportTableBindingSource
        Me.rvInventoryReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvInventoryReport.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptInventoryByStoreReport.rdlc"
        Me.rvInventoryReport.Location = New System.Drawing.Point(9, 21)
        Me.rvInventoryReport.Margin = New System.Windows.Forms.Padding(2)
        Me.rvInventoryReport.Name = "rvInventoryReport"
        Me.rvInventoryReport.Size = New System.Drawing.Size(642, 554)
        Me.rvInventoryReport.TabIndex = 0
        '
        'InventoryReportTableAdapter
        '
        Me.InventoryReportTableAdapter.ClearBeforeFill = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 608)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(547, 608)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmReportInventoryByStoreReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 654)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.rvInventoryReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReportInventoryByStoreReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventory Report"
        CType(Me.InventoryReportTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvInventoryReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents InventoryReportTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents InventoryReportTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.InventoryReportTableAdapter
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
