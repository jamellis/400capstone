Public Class frmReportSales

    Private Sub frmReportSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.salesReportTable' table. You can move, or remove it, as needed.
        Me.salesReportTableAdapter.Fill(Me.Comp400_2012DataSet.salesReportTable)
        'TODO: This line of code loads data into the 'comp400_2012DataSetSalesReporting.SalesReportTableAdapter' table. You can move, or remove it, as needed.
        
        Me.rvReportSales.RefreshReport()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        frmReport.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

End Class