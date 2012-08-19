Public Class frmSalesReceipt
    Public retailOrderNbr As Integer

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmReport.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub frmSalesReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'comp400_2012DataSet.salesReceiptTableAdapter' table. You can move, or remove it, as needed.
        Me.SalesReceiptTableAdapter.FillbyRetailOrderNbr(Me.comp400_2012DataSet.salesReceiptTableAdapter, retailOrderNbr)

        'Me.rvSaleReceipt.RefreshReport()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class