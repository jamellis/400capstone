Public Class frmPOReceiveTires
    Public tireCode As String

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Dim invDestinationTable = Me.InventoryTableAdapter.GetDataByStoreNbrAndTireCode _
                                          (txtTireCode.Text, "0001")

        If CInt(txtQtyReceived.Text) > CInt(txtQtyOrdered.Text) Then
            ' Number entered is too large
            MsgBox("You cannot receive more than you ordered.", MsgBoxStyle.OkOnly)
        Else
            If CInt(txtQtyOrdered.Text) = CInt(txtQtyReceived.Text) Then
                If invDestinationTable.Rows.Count = 0 Then

                    Dim addRow As comp400_2012DataSet.inventoryRow = invDestinationTable.NewRow

                    PurchaseOrderTableAdapter.UpdateQuantity((CInt(txtQtyOrdered.Text) - CInt(txtQtyReceived.Text)), txtPONum.Text)
                    InventoryTableAdapter.InsertPOLine(txtTireCode.Text, CDec(txtQtyReceived.Text))
                    PurchaseOrderTableAdapter.ClosePO(txtPONum.Text)
                    MessageBox.Show("An inventory record has been added")
                    DialogResult = Windows.Forms.DialogResult.OK
                Else
                    PurchaseOrderTableAdapter.UpdateQuantity(0, txtPONum.Text)
                    PurchaseOrderTableAdapter.ClosePO(txtPONum.Text)
                    InventoryTableAdapter.ReceivePOTires((CInt(txtOnHand.Text) + CInt(txtQtyReceived.Text)), txtInvNum.Text)
                    DialogResult = Windows.Forms.DialogResult.OK
                End If

            Else
                If txtInvNum.Text <> "" Then

                    PurchaseOrderTableAdapter.UpdateQuantity((CInt(txtQtyOrdered.Text) - CInt(txtQtyReceived.Text)), txtPONum.Text)
                    InventoryTableAdapter.ReceivePOTires((CInt(txtOnHand.Text) + CInt(txtQtyReceived.Text)), CStr(txtInvNum.Text))
                    DialogResult = Windows.Forms.DialogResult.OK
                Else


                    If invDestinationTable.Rows.Count = 0 Then

                        Dim addRow As comp400_2012DataSet.inventoryRow = invDestinationTable.NewRow

                        PurchaseOrderTableAdapter.UpdateQuantity((CInt(txtQtyOrdered.Text) - CInt(txtQtyReceived.Text)), txtPONum.Text)
                        InventoryTableAdapter.InsertPOLine(txtTireCode.Text, CDec(txtQtyReceived.Text))
                        MessageBox.Show("An inventory record has been added")
                        DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub frmPOReceiveTires_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim invNbr As Integer
        If InventoryTableAdapter.GetInvNumber(tireCode, "0001") IsNot Nothing Then
            invNbr = InventoryTableAdapter.GetInvNumber(tireCode, "0001")
            Dim invCurQty As Integer = InventoryTableAdapter.GetCurrentQuantityByInvNbr(invNbr)
            txtInvNum.Text = invNbr
            txtOnHand.Text = invCurQty
            txtTireCode.Text = tireCode
        End If
    End Sub

    Private Sub txtQtyReceived_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQtyReceived.TextChanged
        btnOK.Enabled = True
    End Sub
End Class