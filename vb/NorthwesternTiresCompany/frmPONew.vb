Public Class frmPONew
    Dim vID As Integer ' get from Dialog frmVendors
    Dim vName As String ' get from Dialog frmVendors
    Dim orderDate As String = Date.Now.Date
    Dim storNum As String = "0001"
    ' Dim invNbr As Integer ' get from Dialog frmSalesInvSearch
    Dim orderTotal As Decimal = 0


    Private Sub frmPONew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblTotal.Text = FormatCurrency(orderTotal, 2)
        btnSelectVendor.Focus()
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

    Private Sub btnSelectVendor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectVendor.Click
        Dim myVendorForm As New frmVendors
        Dim result = myVendorForm.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            vID = myVendorForm.vendorNum
            vName = myVendorForm.vName
            txtVendorID.Text = vID
            txtVendorName.Text = vName
            btnSelectTire.Enabled = True
            txtTireCode.ReadOnly = False
            txtTireCode.Focus()
        End If
    End Sub

    Private Sub btnSelectTire_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectTire.Click
        'Dim myInvSearchForm As New frmSalesInvSearch
        'Dim result = myInvSearchForm.ShowDialog()
        'If result = Windows.Forms.DialogResult.OK Then
        '    tirCode = myInvSearchForm.tCode
        '    invNbr = myInvSearchForm.invID
        '    txtTireCode.Text = tirCode
        '    txtPrice.Text = myInvSearchForm.vPrice
        '    txtOnHand.Text = myInvSearchForm.tQuant
        'End If
        Dim wCost As Decimal = Me.TireTableAdapter.GetWholesaleCostByTireCode(txtTireCode.Text)
        If wCost <> Nothing Then
            txtPrice.Text = wCost
            Dim invNumberTable = Me.InventoryTableAdapter.GetDataByStoreNbrAndTireCode("0001", txtTireCode.Text)
            If invNumberTable.Rows.Count > 0 Then
                Dim invNumberTableRow = invNumberTable.Rows(0)
                Dim onHandQty = invNumberTableRow.Item("tireQty")
                txtOnHand.Text = onHandQty
            Else
                txtOnHand.Text = "0"
            End If
            txtNeeded.ReadOnly = False
            btnUpdate.Enabled = True
            txtNeeded.Focus()
        End If
        End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If txtNeeded.Text = "" Then
            MsgBox("Please type number of tires.", MsgBoxStyle.OkOnly)
        Else
            orderTotal = (CDec(txtNeeded.Text) * CDec(txtPrice.Text))
            lblTotal.Text = FormatCurrency(orderTotal, 2)
            btnSaveOrder.Enabled = True
            txtNeeded.Focus()
        End If
    End Sub

    Private Sub btnCancelOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelOrder.Click
        Dim result = MsgBox("You have not saved this order. Would you like to Cancel?", MsgBoxStyle.YesNo)
        If result = MsgBoxResult.Yes Then
            Dim myPOForm As New frmPO2
            myPOForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub txtNeeded_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNeeded.TextChanged
        btnSaveOrder.Enabled = False
    End Sub

    Private Sub btnSaveOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveOrder.Click
        Try
            PurchaseOrderTableAdapter.Insert(orderDate, vID, "", False, orderTotal, txtTireCode.Text, txtNeeded.Text)
            MsgBox("Purchase Order entered.", MsgBoxStyle.OkOnly)

            ' enter code for print report
            Dim myPOMFG As New frmReportMfgPO
            myPOMFG.poNumber = Me.PurchaseOrderTableAdapter.LastPOnbr
            Dim result = myPOMFG.ShowDialog()

            Dim myPOForm As New frmPO2
            myPOForm.Show()
            Me.Close()
        Catch ex As Exception
            MsgBox("There was a problem saving this order. Please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class