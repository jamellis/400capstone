Public Class frmMainMenu

    
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnTires_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTires.Click
        frmTires.Show()
        Me.Hide()
    End Sub

    Private Sub btnStores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStores.Click
        frmStores.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmLogin.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventorySearch_Click(sender As System.Object, e As System.EventArgs) Handles btnInventorySearch.Click
        frmInventorySearch.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventoryMaintain_Click(sender As System.Object, e As System.EventArgs) Handles btnInventoryMaintain.Click
        frmInventoryMaintain.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click(sender As System.Object, e As System.EventArgs) Handles btnSales.Click
        frmSales.Show()
        Me.Hide()
    End Sub

    Private Sub btnReports_Click(sender As System.Object, e As System.EventArgs) Handles btnReports.Click
        frmReport.Show()
        Me.Hide()
    End Sub

    Private Sub btnEmployee_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployee.Click
        frmEmployee.Show()
        Me.Hide()
    End Sub

    Private Sub btnPO_Click(sender As System.Object, e As System.EventArgs) Handles btnPO.Click
        frmPo.Show()
        Me.Hide()
    End Sub
End Class