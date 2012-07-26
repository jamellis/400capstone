Public Class frmInventoryMaintain

    Private Sub InventoryBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    End Sub

    Private Sub frmInventoryMaintain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.store' table. You can move, or remove it, as needed.
        Me.StoreTableAdapter.Fill(Me.Comp400_2012DataSet.store)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.tire' table. You can move, or remove it, as needed.
        Me.TireTableAdapter.Fill(Me.Comp400_2012DataSet.tire)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Comp400_2012DataSet.inventory)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.Comp400_2012DataSet.inventory)

    End Sub

    Private Sub InventoryBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub cboTireCode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTireCode.SelectedIndexChanged

    End Sub
End Class