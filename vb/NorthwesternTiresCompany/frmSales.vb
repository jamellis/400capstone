Public Class frmSales

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Dim MainMenuForm As New frmMainMenu
        frmMainMenu.Show()
        Me.Close()
    End Sub
End Class