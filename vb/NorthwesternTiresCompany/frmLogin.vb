Public Class frmLogin

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString(txtUserID.Text, txtPassword.Text)

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            frmMainMenu.Show()
            Me.Hide()
        End If
    End Sub
End Class