Public Class frmSalesReceipt

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        frmReport.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub frmSalesReceipt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'comp400_2012DataSet.salesReceiptTableAdapter' table. You can move, or remove it, as needed.
        Me.SalesReceiptTableAdapter.Fill(Me.comp400_2012DataSet.salesReceiptTableAdapter)

        Me.rvSaleReceipt.RefreshReport()
    End Sub
End Class