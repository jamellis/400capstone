Public Class frmInventorySearch

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim MainMenuForm As New frmMainMenu
        MainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub frmInventorySearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.invSearch' table. You can move, or remove it, as needed.
        Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim SelectQry = "SELECT inventory.inventoryNbr, inventory.tireCode, tire.manufacturer, tire.description, tire.manufacturerSize, tire.retailPrice, inventory.tireQty, inventory.storeNbr FROM inventory INNER JOIN store ON inventory.storeNbr = store.storeNbr INNER JOIN tire ON inventory.tireCode = tire.tireCode WHERE (inventory.tireCode LIKE '%" & Me.txtSearch.Text & "%') OR (tire.manufacturer LIKE '%" & Me.txtSearch.Text & "%') OR (tire.description LIKE '%" & Me.txtSearch.Text & "%') OR (tire.manufacturerSize LIKE '%" & Me.txtSearch.Text & "%')"
        ' Me.InvSearchTableAdapter.Fill(SelectQry)

    End Sub

End Class