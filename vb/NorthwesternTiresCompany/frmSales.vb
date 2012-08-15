Public Class frmSales
    Dim cID As Integer ' get from Dialog frmCustomers
    Dim orderDate As String = Date.Now.Date
    Dim employID As Integer = userInfo.EmployeeID
    Dim storNum As String = userInfo.StoreNumber
    Dim tirCode As String ' get from Dialog frmSalesInvSearch
    Dim invNbr As Integer ' get from Dialog frmSalesInvSearch
    Dim orderTotal As Decimal = 0


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If txtNeeded.Text = "" Then
            Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Application.Exit()
            Else
                'do nothing - stay here
            End If
        Else
            Dim result = MsgBox("You have not saved this order. Changes will be lost." & vbNewLine & "Would you like to Exit?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                Application.Exit()
            End If
        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Dim MainMenuForm As New frmMainMenu
        If txtNeeded.Text = "" Then
            frmMainMenu.Show()
            Me.Close()
        Else
            Dim result = MsgBox("You have not saved this order. Would you like to Cancel?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then
                frmMainMenu.Show()
                Me.Close()
            End If
        End If

    End Sub

    Private Sub btnSelectCust_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectCust.Click
        Dim myCustForm As New frmCustomers
        Dim result = myCustForm.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            ' MessageBox.Show(myCustForm.custNum)
            cID = myCustForm.custNum
            txtFirstName.Text = myCustForm.fName
            txtLastName.Text = myCustForm.lName
            txtPhone.Text = myCustForm.cPhone
            btnSelectTire.Enabled = True
            btnSelectTire.Focus()
        End If
    End Sub

    Private Sub btnSelectTire_Click(sender As System.Object, e As System.EventArgs) Handles btnSelectTire.Click
        Dim myInvSearchForm As New frmSalesInvSearch
        Dim result = myInvSearchForm.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            tirCode = myInvSearchForm.tCode
            invNbr = myInvSearchForm.invID
            txtTireCode.Text = tirCode
            txtPrice.Text = myInvSearchForm.rPrice
            txtOnHand.Text = myInvSearchForm.tQuant
            txtNeeded.ReadOnly = False
            btnUpdate.Enabled = True
            txtNeeded.Focus()
        End If
    End Sub

    Private Sub frmSales_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lblTotal.Text = FormatCurrency(orderTotal, 2)
        Dim fname As String = Me.EmployeeTableAdapter.SalespersonFirstName(employID)
        Dim lname As String = Me.EmployeeTableAdapter.SalespersonLastName(employID)
        lblSalesperson.Text = fname & " " & lname
        btnSelectCust.Focus()
    End Sub

    Private Sub btnUpdate_Click(sender As System.Object, e As System.EventArgs) Handles btnUpdate.Click
        If txtNeeded.Text = "" Then
            MsgBox("Please type number of tires.", MsgBoxStyle.OkOnly)
        Else
            If (CDec(txtNeeded.Text) <= CDec(txtOnHand.Text)) Then
                orderTotal = (CDec(txtNeeded.Text) * CDec(txtPrice.Text))
                lblTotal.Text = FormatCurrency(orderTotal, 2)
                btnSaveOrder.Enabled = True
                txtNeeded.Focus()
            Else
                ' Needed is greater than on-hand
                MsgBox("You cannot sell more than we have in stock.")
            End If

        End If

    End Sub

    Private Sub btnCancelOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelOrder.Click
        Dim result = MsgBox("You have not saved this order. Would you like to Cancel?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtNeeded_TextChanged(sender As Object, e As System.EventArgs) Handles txtNeeded.TextChanged
        btnSaveOrder.Enabled = False
    End Sub

    Private Sub btnSaveOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOrder.Click
        Try
            RetailOrderTableAdapter.Insert(cID, storNum, employID, orderDate, orderTotal, tirCode, txtNeeded.Text)
            InvSearchTableAdapter.UpdateQuantity((CInt(txtOnHand.Text) - CInt(txtNeeded.Text)), invNbr)
            Dim mySalesReceipt As New frmSalesReceipt
            mySalesReceipt.retailOrderNbr = Me.RetailOrderTableAdapter.LastOrderNbr
            Dim result = mySalesReceipt.ShowDialog()
            If result = DialogResult.OK Then
                frmMainMenu.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("There was a problem saving this order. Please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
        End Try

    End Sub
End Class