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
        Me.lblReports = New System.Windows.Forms.Label()
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnInventoryReportByStore = New System.Windows.Forms.Button()
        Me.btnGlobalInventoryReport = New System.Windows.Forms.Button()
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesReportTableAdapterBindingSource
        '
        Me.SalesReportTableAdapterBindingSource.DataMember = "SalesReportTableAdapter"
        '
        'lblReports
        '
        Me.lblReports.AutoSize = True
        Me.lblReports.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReports.Location = New System.Drawing.Point(180, 16)
        Me.lblReports.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReports.Name = "lblReports"
        Me.lblReports.Size = New System.Drawing.Size(93, 26)
        Me.lblReports.TabIndex = 0
        Me.lblReports.Text = "Reports"
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalesReport.Location = New System.Drawing.Point(144, 71)
        Me.btnSalesReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(160, 46)
        Me.btnSalesReport.TabIndex = 1
        Me.btnSalesReport.Text = "Sales Report"
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(321, 275)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(36, 275)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnInventoryReportByStore
        '
        Me.btnInventoryReportByStore.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInventoryReportByStore.Location = New System.Drawing.Point(144, 138)
        Me.btnInventoryReportByStore.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnInventoryReportByStore.Name = "btnInventoryReportByStore"
        Me.btnInventoryReportByStore.Size = New System.Drawing.Size(160, 46)
        Me.btnInventoryReportByStore.TabIndex = 16
        Me.btnInventoryReportByStore.Text = "Inventory Report By Store"
        Me.btnInventoryReportByStore.UseVisualStyleBackColor = True
        '
        'btnGlobalInventoryReport
        '
        Me.btnGlobalInventoryReport.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGlobalInventoryReport.Location = New System.Drawing.Point(144, 205)
        Me.btnGlobalInventoryReport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGlobalInventoryReport.Name = "btnGlobalInventoryReport"
        Me.btnGlobalInventoryReport.Size = New System.Drawing.Size(160, 46)
        Me.btnGlobalInventoryReport.TabIndex = 17
        Me.btnGlobalInventoryReport.Text = "Global Inventory Report"
        Me.btnGlobalInventoryReport.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 333)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnGlobalInventoryReport)
        Me.Controls.Add(Me.btnInventoryReportByStore)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSalesReport)
        Me.Controls.Add(Me.lblReports)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reports"
        CType(Me.SalesReportTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblReports As System.Windows.Forms.Label
    Friend WithEvents SalesReportTableAdapterBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents comp400_2012DataSetSalesReporting As NorthwesternTiresCompany.comp400_2012DataSetSalesReporting
    'Friend WithEvents SalesReportTableAdapterTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetSalesReportingTableAdapters.SalesReportTableAdapterTableAdapter
    Friend WithEvents btnSalesReport As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnInventoryReportByStore As System.Windows.Forms.Button
    Friend WithEvents btnGlobalInventoryReport As System.Windows.Forms.Button
End Class
