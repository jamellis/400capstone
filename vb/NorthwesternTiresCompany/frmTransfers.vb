Public Class frmTransfers

    Private Sub frmTransfers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Comp400_2012DataSet.inventory)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.tire' table. You can move, or remove it, as needed.
        Me.TireTableAdapter.Fill(Me.Comp400_2012DataSet.tire)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.invSearch' table. You can move, or remove it, as needed.
        Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.store' table. You can move, or remove it, as needed.
        ' Me.StoreTableAdapter.Fill(Me.Comp400_2012DataSet.store)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.recStore' table. You can move, or remove it, as needed.
        Me.RecStoreTableAdapter.FillRecStore(Me.Comp400_2012DataSet.recStore)

        ' Use this to populate this combobox with list of Stores
        cboShipStore.Items.Clear()
        cboShipStore.Items.Add("All")

        Dim table As comp400_2012DataSet.storeDataTable = StoreTableAdapter1.GetData()

        For Each storeRow In table
            cboShipStore.Items.Add(storeRow.storeNbr)
        Next

    End Sub

    Private Sub btnAvailableInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAvailableInv.Click
        If cboShipStore.SelectedIndex < 1 Then
            Me.InventoryTableAdapter.FillBySearchForTire(Me.Comp400_2012DataSet.inventory, cboTireCode.SelectedValue)
        Else
            Dim storeNum As String
            storeNum = CStr(cboShipStore.SelectedItem)
            Me.InventoryTableAdapter.FillByStoreNbrTireCode(Me.Comp400_2012DataSet.inventory, cboTireCode.SelectedValue, storeNum)

        End If
       
    End Sub

    Private Sub btnTransferInv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransferInv.Click
        Dim shpStore = "0001"
        Dim rowview As DataRowView = InventoryBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.inventoryRow = rowview.Row
            shpStore = row.storeNbr
        End If
        If shpStore = cboRecStore.SelectedValue Then

            MessageBox.Show("Ship and Receive Store Cannot be the same")

            Return
        End If

        ' Dim transInvTable = Me.InventoryTableAdapter.GetDataByStoreNbrAndTireCode _
        '                     (shpStore, cboTireCode.SelectedValue)
        If gdvAvailableInv.SelectedRows.Count > 0 Then
            Dim grdRow = gdvAvailableInv.SelectedRows(0)
            Dim tranRowView As DataRowView = grdRow.DataBoundItem
            Dim row As comp400_2012DataSet.inventoryRow = tranRowView.Row
            Dim availQty = row.tireQty

            Dim transQty As Integer = txtTransferQty.Text

            If availQty < transQty Then

                MessageBox.Show("Insufficient Inventory Available for Transfer")
                txtTransferQty.Clear()

            Else

                row.tireQty = row.tireQty - transQty

                Dim affectedRows = Me.InventoryTableAdapter.Update(row)

                Dim invDestinationTable = Me.InventoryTableAdapter.GetDataByStoreNbrAndTireCode _
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

        Me.Comp400_2012DataSet.inventory.Clear()
        Me.InventoryTableAdapter.Fill(Me.Comp400_2012DataSet.inventory)

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