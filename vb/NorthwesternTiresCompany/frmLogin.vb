Public Class frmLogin

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        'If result = Windows.Forms.DialogResult.Yes Then
        '    Application.Exit()
        'Else
        '    'do nothing - stay here
        'End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click

        If txtUserID.Text.Trim = Nothing And txtPassword.Text.Trim = Nothing Then
            'Dim MainMenuForm As New frmMainMenu
            frmMainMenu.Show()
            Me.Close()
        Else
            Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString(txtUserID.Text, txtPassword.Text)
            If Login Is Nothing Then
                MsgBox("Incorrect UserID or Password")
            Else
                userInfo.Clearance = Me.EmployeeTableAdapter1.ClearanceString(txtUserID.Text)
                userInfo.EmployeeID = Me.EmployeeTableAdapter1.EmployeeNumber(txtUserID.Text)
                userInfo.StoreNumber = Me.EmployeeTableAdapter1.StoreNumber(txtUserID.Text)
                frmMainMenu.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub AdminLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdminLogin.Click
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString("arankin", "ar1234")

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            Dim ClearanceString = Me.EmployeeTableAdapter1.ClearanceString("arankin")
            userInfo.Clearance = ClearanceString
            userInfo.EmployeeID = Me.EmployeeTableAdapter1.EmployeeNumber("arankin")
            userInfo.StoreNumber = Me.EmployeeTableAdapter1.StoreNumber("arankin")
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Dim MainMenuForm As New frmMainMenu
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub GeneralLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString("sharris", "sh1234")

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            Dim ClearanceString = Me.EmployeeTableAdapter1.ClearanceString("sharris")
            userInfo.Clearance = ClearanceString
            userInfo.EmployeeID = Me.EmployeeTableAdapter1.EmployeeNumber("sharris")
            userInfo.StoreNumber = Me.EmployeeTableAdapter1.StoreNumber("sharris")
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub SalesLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesLogin.Click
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString("abarnes", "sb1234")

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            Dim ClearanceString = Me.EmployeeTableAdapter1.ClearanceString("abarnes")
            userInfo.Clearance = ClearanceString
            userInfo.EmployeeID = Me.EmployeeTableAdapter1.EmployeeNumber("abarnes")
            userInfo.StoreNumber = Me.EmployeeTableAdapter1.StoreNumber("abarnes")
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub ManagerLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ManagerLogin.Click
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString("hnewton", "hn1234")

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            Dim ClearanceString = Me.EmployeeTableAdapter1.ClearanceString("hnewton")
            userInfo.Clearance = ClearanceString
            userInfo.EmployeeID = Me.EmployeeTableAdapter1.EmployeeNumber("hnewton")
            userInfo.StoreNumber = Me.EmployeeTableAdapter1.StoreNumber("hnewton")
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub WarehouseLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WarehouseLogin.Click
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString("bmason", "bm1234")

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            Dim ClearanceString = Me.EmployeeTableAdapter1.ClearanceString("bmason")
            userInfo.Clearance = ClearanceString
            userInfo.EmployeeID = Me.EmployeeTableAdapter1.EmployeeNumber("bmason")
            userInfo.StoreNumber = Me.EmployeeTableAdapter1.StoreNumber("bmason")
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub WarehouseManagerLogin_Click(sender As System.Object, e As System.EventArgs) Handles WarehouseManagerLogin.Click
        Dim Login = Me.EmployeeTableAdapter1.UserIDPasswordString("fsmith", "fs1234")

        If Login Is Nothing Then
            MsgBox("Incorrect Username or Password")
        Else
            Dim ClearanceString = Me.EmployeeTableAdapter1.ClearanceString("fsmith")
            userInfo.Clearance = ClearanceString
            userInfo.EmployeeID = Me.EmployeeTableAdapter1.EmployeeNumber("fsmith")
            userInfo.StoreNumber = Me.EmployeeTableAdapter1.StoreNumber("fsmith")
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub
End Class