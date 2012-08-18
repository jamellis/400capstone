Public Class frmPOReceiveTires
    Public tireCode As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If CInt(txtQtyReceived.Text) > CInt(txtQtyOrdered.Text) Then
            ' Number entered is too large
            MsgBox("You cannot receive more than you ordered.", MsgBoxStyle.OkOnly)
        Else
            If CInt(txtQtyOrdered.Text) = CInt(txtQtyReceived.Text) Then
                PurchaseOrderTableAdapter.UpdateQuantity(0, txtPONum.Text)
                PurchaseOrderTableAdapter.ClosePO(txtPONum.Text)
                InventoryTableAdapter.ReceivePOTires((CInt(txtOnHand.Text) + CInt(txtQtyReceived.Text)), txtInvNum.Text)
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                PurchaseOrderTableAdapter.UpdateQuantity((CInt(txtQtyOrdered.Text) - CInt(txtQtyReceived.Text)), txtPONum.Text)
                InventoryTableAdapter.ReceivePOTires((CInt(txtOnHand.Text) + CInt(txtQtyReceived.Text)), txtInvNum.Text)
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub frmPOReceiveTires_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim invNbr As Integer = InventoryTableAdapter.GetInvNumber(tireCode, "0001")
        Dim invCurQty As Integer = InventoryTableAdapter.GetCurrentQuantityByInvNbr(invNbr)
        txtInvNum.Text = invNbr
        txtOnHand.Text = invCurQty
        txtTireCode.Text = tireCode
        txtOnHand.Text = invCurQty
    End Sub

    Private Sub txtQtyReceived_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtyReceived.TextChanged
        btnOK.Enabled = True
    End Sub
End Class