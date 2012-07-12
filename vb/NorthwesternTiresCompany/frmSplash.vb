Public Class frmSplash

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        frmMainMenu.Show()
        Me.Hide()
    End Sub

End Class
