Imports System.Data.SqlClient

Public Class frmInventorySearchMaint

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmInventorySearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboStore.Items.Clear()
        cboStore.Items.Add("All")

        Dim table As comp400_2012DataSet.storeDataTable = StoreTableAdapter1.GetData()

        For Each storeRow In table
            cboStore.Items.Add(storeRow.storeNbr)
        Next

        Try
            Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)
        Catch ex As Exception
            MsgBox("Database error. Please contact your systems administrator " & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
        End Try
        txtSearch.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If cboStore.SelectedIndex < 1 Then
            Me.InvSearchTableAdapter.FillBySearch(Me.Comp400_2012DataSet.invSearch, txtSearch.Text)
        Else
            Dim storeNum As String
            storeNum = CStr(cboStore.SelectedItem)
            Me.InvSearchTableAdapter.FillBySearchStoreNbr(Me.Comp400_2012DataSet.invSearch, txtSearch.Text, storeNum)
        End If

    End Sub

    Private Sub btnUpdateQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateQty.Click
        Dim rowView As DataRowView = InvSearchBindingSource.Current
        Dim curRow As comp400_2012DataSet.invSearchRow = rowView.Row
        If Validator.IsPresent(txtTireQty, "Quantity") AndAlso
           Validator.IsInt32(txtTireQty, "Quantity") Then
            If txtTireQty.Text = 0 Then
                Dim result = MsgBox("Are you sure you want to delete this inventory?" & vbNewLine & "This cannot be undone.", MsgBoxStyle.YesNo)
                If result = MsgBoxResult.Yes Then
                    Try
                        Me.InvSearchBindingSource.EndEdit()
                        InvSearchTableAdapter.DeleteInventory(curRow.inventoryNbr)
                        Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)
                    Catch ex As Exception
                        MsgBox("Delete failed.")
                    End Try
                End If
            Else
                Try
                    InvSearchBindingSource.EndEdit()
                    InvSearchTableAdapter.UpdateQuantity(txtTireQty.Text, curRow.inventoryNbr)
                    Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)
                Catch ex As Exception
                    MsgBox("Quantity Update error" & ex.Message, MsgBoxStyle.OkOnly, "Error")
                End Try
            End If

        End If
    End Sub

    Private Sub cboStore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboStore.SelectedIndexChanged
        Try
            If cboStore.SelectedIndex < 1 Then
                Me.InvSearchTableAdapter.FillBySearch(Me.Comp400_2012DataSet.invSearch, txtSearch.Text)
            Else
                Dim storeNum = CStr(cboStore.SelectedItem)
                Me.InvSearchTableAdapter.FillBySearchStoreNbr(Me.Comp400_2012DataSet.invSearch, txtSearch.Text, storeNum)
            End If
        Catch ex As Exception
            MsgBox("Failed to search database. " & ex.Message)
        End Try
    End Sub

    Private Sub btnStoreTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStoreTransfer.Click
        frmTransfers.Show()
        Me.Close()
    End Sub
End Class