Public Class frmDealerReceipt

    Private Sub frmDealerReceipt_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.rvDealerReceipt.RefreshReport()
    End Sub

    Private Sub btnOk_Click(sender As System.Object, e As System.EventArgs) Handles btnOk.Click
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
End Class