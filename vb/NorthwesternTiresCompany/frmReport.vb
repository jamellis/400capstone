Public Class frmReport

    Private Sub frmReport_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'comp400_2012DataSetSalesReporting.SalesReportTableAdapter' table. You can move, or remove it, as needed.

        Me.SalesReportTableAdapterTableAdapter.Fill(Me.comp400_2012DataSetSalesReporting.SalesReportTableAdapter)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class