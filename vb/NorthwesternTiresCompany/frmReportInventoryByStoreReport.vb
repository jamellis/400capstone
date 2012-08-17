Public Class frmReportInventoryByStoreReport
    Dim StoreNumber = userInfo.StoreNumber

    Private Sub frmReportInventoryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'comp400_2012DataSet.InventoryReportTable' table. You can move, or remove it, as needed.
        Me.InventoryReportTableAdapter.FillByStoreNumber(Me.comp400_2012DataSet.InventoryReportTable, StoreNumber)

        Me.rvInventoryReport.RefreshReport()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
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