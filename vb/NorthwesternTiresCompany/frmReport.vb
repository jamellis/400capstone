Public Class frmReport

    
    Private Sub btnSalesReport_Click(sender As System.Object, e As System.EventArgs) Handles btnSalesReport.Click
        frmReportSales.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnInventoryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventoryReportByStore.Click
        frmReportInventoryByStoreReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnSalesReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGlobalInventoryReport.Click
        frmSalesReceipt.Show()
        Me.Hide()
    End Sub
End Class