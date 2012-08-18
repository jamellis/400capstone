Public Class frmPO2

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

    Private Sub frmPO2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet1.dealer' table. You can move, or remove it, as needed.
        Me.PurchaseOrderTableAdapter.FillByOpenOrders(Me.Comp400_2012DataSet.purchaseOrder)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.wholesaleOrder' table. You can move, or remove it, as needed.
    End Sub

    Private Sub btnSaveComments_Click(sender As System.Object, e As System.EventArgs) Handles btnSaveComments.Click
        Dim rowview As DataRowView = PurchaseOrderBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.purchaseOrderRow = rowview.Row
            Try
                PurchaseOrderTableAdapter.UpdateComments(txtComment.Text, row.poNbr)
                Me.PurchaseOrderTableAdapter.Fill(Comp400_2012DataSet.purchaseOrder)
            Catch ex As Exception
                MsgBox("Could not close Order.", MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub

    Private Sub btnCloseOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rowview As DataRowView = PurchaseOrderBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.purchaseOrderRow = rowview.Row
            Try
                PurchaseOrderTableAdapter.ClosePO(row.poNbr)
                Me.PurchaseOrderTableAdapter.FillByOpenOrders(Comp400_2012DataSet.purchaseOrder)
            Catch ex As Exception
                MsgBox("Could not close Order.", MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub

    Private Sub btnCreateNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNewOrder.Click
        Dim myPurchaseOrderForm As New frmPONew
        myPurchaseOrderForm.Show()
        Me.Close()
    End Sub

    Private Sub btnReceive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReceive.Click
        Dim rowview As DataRowView = PurchaseOrderBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.purchaseOrderRow = rowview.Row
            Dim myReceivePOTiresForm As New frmPOReceiveTires
            myReceivePOTiresForm.txtPONum.Text = row.poNbr
            myReceivePOTiresForm.txtQtyOrdered.Text = row.tireQty
            myReceivePOTiresForm.txtVendorID.Text = row.vendorID
            ' myReceivePOTiresForm.txtTireCode.Text = row.tireCode
            myReceivePOTiresForm.tireCode = row.tireCode
            myReceivePOTiresForm.ShowDialog()
            If Windows.Forms.DialogResult.OK Then
                Try
                    Me.PurchaseOrderTableAdapter.FillByOpenOrders(Me.Comp400_2012DataSet.purchaseOrder)
                    ' PurchaseOrderDataGridView.Update()
                Catch ex As Exception
                    MsgBox("Could not update file. Please contact your systems administrator.", MsgBoxStyle.OkOnly)
                End Try
            End If

        End If
    End Sub
End Class