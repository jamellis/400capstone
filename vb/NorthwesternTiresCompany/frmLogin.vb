﻿Public Class frmLogin

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString(txtUserID.Text, txtPassword.Text)

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString("sharris", "sh1234")

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub
End Class