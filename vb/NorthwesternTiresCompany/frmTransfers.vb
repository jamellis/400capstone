Public Class frmTransfers

    Private Sub frmTransfers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Comp400_2012DataSet.inventory)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.tire' table. You can move, or remove it, as needed.
        Me.TireTableAdapter.Fill(Me.Comp400_2012DataSet.tire)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.invSearch' table. You can move, or remove it, as needed.
        Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.store' table. You can move, or remove it, as needed.
        Me.StoreTableAdapter.Fill(Me.Comp400_2012DataSet.store)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.recStore' table. You can move, or remove it, as needed.
        Me.RecStoreTableAdapter.FillRecStore(Me.Comp400_2012DataSet.recStore)

    End Sub

    Private Sub btnAvailableInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvailableInv.Click

        Me.InvSearchTableAdapter.FillByAvailableInv(Me.Comp400_2012DataSet.invSearch, cboShipStore.SelectedValue, cboTireCode.SelectedValue)

    End Sub

    Private Sub btnTransferInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferInv.Click

        If cboShipStore.SelectedValue = cboRecStore.SelectedValue Then

            MessageBox.Show("Ship and Receive Store Cannot be the same")


            Return
        End If

        Dim transInvTable = Me.InventoryTableAdapter.GetDataByStoreNbrandTireCode _
                            (cboShipStore.SelectedValue, cboTireCode.SelectedValue)
        If transInvTable.Rows.Count > 0 Then

            Dim row As comp400_2012DataSet.inventoryRow = transInvTable.Rows(0)

            Dim availQty = row.tireQty

            Dim transQty As Integer = txtTransferQty.Text

            If availQty < transQty Then

                MessageBox.Show("Insufficient Inventory Available for Transfer")
                txtTransferQty.Clear()

            Else

                row.tireQty = row.tireQty - transQty

                Me.InventoryTableAdapter.Update(row)

                Dim invDestinationTable = Me.InventoryTableAdapter.GetDataByStoreNbrandTireCode _
                                          (cboRecStore.SelectedValue, cboTireCode.SelectedValue)
                If invDestinationTable.Rows.Count > 0 Then

                    Dim transferRow As comp400_2012DataSet.inventoryRow = invDestinationTable.Rows(0)
                    transferRow.tireQty = transferRow.tireQty + transQty

                    Me.InventoryTableAdapter.Update(transferRow)
                    MessageBox.Show("Store to Store Transfer Complete")
                    txtTransferQty.Clear()
                    
                Else
                    If invDestinationTable.Rows.Count = 0 Then

                        Dim addRow As comp400_2012DataSet.inventoryRow = invDestinationTable.NewRow


                        Me.InventoryTableAdapter.InsertTransferQuery(cboTireCode.SelectedValue, cboRecStore.SelectedValue, txtTransferQty.Text)
                        MessageBox.Show("Store to Store Transfer Complete")
                        txtTransferQty.Clear()
                    End If

                End If

            End If
        End If

        Me.Comp400_2012DataSet.invSearch.Clear()
        Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)

        gdvAvailableInv.Refresh()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmInventorySearchMaint.Show()
        Me.Close()
    End Sub
End Class