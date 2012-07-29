Public Class frmReportSales

    Private Sub frmReportSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'comp400_2012DataSetSalesReporting.SalesReportTableAdapter' table. You can move, or remove it, as needed.
        Me.SalesReportTableAdapterTableAdapter.Fill(Me.comp400_2012DataSetSalesReporting.SalesReportTableAdapter)

        Me.rvReportSales.RefreshReport()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        frmReport.Show()
        Me.Close()
    End Sub
End Class