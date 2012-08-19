<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportMfgPO
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
        Me.MFPOTableAdapterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.comp400_2012DataSet = New NorthwesternTiresCompany.comp400_2012DataSet()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.rvReportMfgPO = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MFPOTableAdapter = New NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.MFPOTableAdapter()
        CType(Me.MFPOTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MFPOTableAdapterBindingSource
        '
        Me.MFPOTableAdapterBindingSource.DataMember = "MFPOTableAdapter"
        Me.MFPOTableAdapterBindingSource.DataSource = Me.comp400_2012DataSet
        '
        'comp400_2012DataSet
        '
        Me.comp400_2012DataSet.DataSetName = "comp400_2012DataSet"
        Me.comp400_2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(436, 501)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(90, 30)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnBack.Location = New System.Drawing.Point(12, 501)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 30)
        Me.btnBack.TabIndex = 18
        Me.btnBack.Text = "&Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'rvReportMfgPO
        '
        ReportDataSource1.Name = "MFPO"
        ReportDataSource1.Value = Me.MFPOTableAdapterBindingSource
        Me.rvReportMfgPO.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rvReportMfgPO.LocalReport.ReportEmbeddedResource = "NorthwesternTiresCompany.rptMFPO.rdlc"
        Me.rvReportMfgPO.Location = New System.Drawing.Point(12, 12)
        Me.rvReportMfgPO.Name = "rvReportMfgPO"
        Me.rvReportMfgPO.Size = New System.Drawing.Size(520, 465)
        Me.rvReportMfgPO.TabIndex = 20
        '
        'MFPOTableAdapter
        '
        Me.MFPOTableAdapter.ClearBeforeFill = True
        '
        'frmReportMfgPO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 539)
        Me.Controls.Add(Me.rvReportMfgPO)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmReportMfgPO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReportMfgPO"
        CType(Me.MFPOTableAdapterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comp400_2012DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents rvReportMfgPO As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents comp400_2012DataSet As NorthwesternTiresCompany.comp400_2012DataSet
    Friend WithEvents MFPOTableAdapterBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MFPOTableAdapter As NorthwesternTiresCompany.comp400_2012DataSetTableAdapters.MFPOTableAdapter
End Class
