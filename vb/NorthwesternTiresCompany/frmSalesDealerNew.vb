Public Class frmSalesDealerNew
    Dim dID As Integer ' get from Dialog frmDealers
    Dim dName As String ' get from Dialog frmDealers
    Dim dPhone As Integer ' get from Dialog frmDealers
    Dim orderDate As String = Date.Now.Date
    Dim storNum As String = "0001"
    Dim tirCode As String ' get from Dialog frmSalesInvSearch
    Dim invNbr As Integer ' get from Dialog frmSalesInvSearch
    Dim orderTotal As Decimal = 0

    Private Sub frmSalesDealerNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTotal.Text = FormatCurrency(orderTotal, 2)
        btnSelectDealer.Focus()
    End Sub

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
        If txtNeeded.Text = "" Then
            frmSalesDealer.Show()
            Me.Close()
        Else
            Dim result = MsgBox("You have not saved this order. Would you like to Cancel?", MsgBoxStyle.YesNo)
            If result = MsgBoxResult.Yes Then

                frmSalesDealer.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub btnSelectDealer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectDealer.Click
        Dim myDealerForm As New frmDealers
        Dim result = myDealerForm.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            ' MessageBox.Show(myCustForm.custNum)
            dID = myDealerForm.dealerNum
            dName = myDealerForm.dName
            txtDealerID.Text = dID
            txtDealerName.Text = dName
            txtDealerPhone.Text = myDealerForm.dPhone
            btnSelectTire.Enabled = True
            btnSelectTire.Focus()
        End If
    End Sub

    Private Sub btnSelectTire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectTire.Click
        Dim myInvSearchForm As New frmSalesInvSearch
        Dim result = myInvSearchForm.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            tirCode = myInvSearchForm.tCode
            invNbr = myInvSearchForm.invID
            txtTireCode.Text = tirCode
            txtPrice.Text = myInvSearchForm.dPrice
            txtOnHand.Text = myInvSearchForm.tQuant
            txtNeeded.ReadOnly = False
            btnUpdate.Enabled = True
            txtNeeded.Focus()
        End If
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
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

    Private Sub btnCancelOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOrder.Click
        Dim result = MsgBox("You have not saved this order. Would you like to Cancel?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            frmMainMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtNeeded_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNeeded.TextChanged
        btnSaveOrder.Enabled = False
    End Sub

    Private Sub btnSaveOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOrder.Click
        Try
            WholesaleOrderTableAdapter.Insert(dID, "", False, orderDate, tirCode, txtNeeded.Text, orderTotal)
            InvSearchTableAdapter.UpdateQuantity((CInt(txtOnHand.Text) - CInt(txtNeeded.Text)), invNbr)
            ' Dim myDealerReceipt As New frmDealerReceipt
            ' Dim result = myDealerReceipt.ShowDialog()
            ' If result = DialogResult.OK Then
            frmMainMenu.Show()
            Me.Close()
            ' End If
        Catch ex As Exception
            MsgBox("There was a problem saving this order. Please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class