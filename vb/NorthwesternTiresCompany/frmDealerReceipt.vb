Public Class frmDealerReceipt
    Public dealerOrderNbr As Integer
    Private Sub frmDealerReceipt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'comp400_2012DataSet.dealerReceiptTable' table. You can move, or remove it, as needed.
        Me.dealerReceiptTableAdapter.Fill(Me.comp400_2012DataSet.dealerReceiptTable, dealerOrderNbr)
        
        Me.rvDealerReceipt.RefreshReport()
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class