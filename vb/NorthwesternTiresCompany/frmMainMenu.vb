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
End Class