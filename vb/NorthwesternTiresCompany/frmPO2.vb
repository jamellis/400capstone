﻿Public Class frmPO2

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim MainMenuForm As New frmMainMenu
        MainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub PurchaseOrderBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PurchaseOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    End Sub

    Private Sub frmPO2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.PurchaseOrderTableAdapter.Fill(Me.Comp400_2012DataSet.purchaseOrder)

    End Sub

    Private Sub PurchaseOrderDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PODataGridView.DoubleClick
        Dim selectedRowView As DataRowView = CType(PODataGridView.SelectedRows(0).DataBoundItem, DataRowView)
        Dim selectedRow As comp400_2012DataSet.purchaseOrderRow = CType(selectedRowView.Row, comp400_2012DataSet.purchaseOrderRow)

        Me.PurchaseOrderDetailTableAdapter.FillByPONbr(Me.Comp400_2012DataSet.purchaseOrderDetail, selectedRow.poNbr)

        PODetailDataGridView.ClearSelection()

    End Sub
End Class