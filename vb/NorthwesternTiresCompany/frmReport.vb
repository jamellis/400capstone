Public Class frmReport

    
    Private Sub btnSalesReport_Click(sender As System.Object, e As System.EventArgs) Handles btnSalesReport.Click
        frmReportSales.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub
End Class