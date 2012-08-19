<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDealerReceipt
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
        Me.dealerReceiptTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.rvDealerReceipt = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.dealerReceiptTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.dealerReceiptTableAdapter()
        CType(Me.dealerReceiptTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dealerReceiptTableBindingSource
        '
        Me.dealerReceiptTableBindingSource.DataMember = "dealerReceiptTable"
        Me.dealerReceiptTableBindingSource.DataSource = Me.comp400_2012DataSet
        '
        'comp400_2012DataSet
        '
        Me.comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rvDealerReceipt
        '
        ReportDataSource1.Name = "DealerReceipt"
        ReportDataSource1.Value = Me.dealerReceiptTableBindingSource
        Me.rvDealerReceipt.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvDealerReceipt.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptDealerReceipt.rdlc"
        Me.rvDealerReceipt.Location = New System.Drawing.Point(12, 12)
        Me.rvDealerReceipt.Name = "rvDealerReceipt"
        Me.rvDealerReceipt.Size = New System.Drawing.Size(637, 550)
        Me.rvDealerReceipt.TabIndex = 0
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnOk.Location = New System.Drawing.Point(285, 587)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(90, 30)
        Me.btnOk.TabIndex = 1
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'dealerReceiptTableAdapter
        '
        Me.dealerReceiptTableAdapter.ClearBeforeFill = True
        '
        'frmDealerReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(661, 627)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.rvDealerReceipt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmDealerReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportDealerSales"
        CType(Me.dealerReceiptTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rvDealerReceipt As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents dealerReceiptTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dealerReceiptTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.dealerReceiptTableAdapter
End Class
