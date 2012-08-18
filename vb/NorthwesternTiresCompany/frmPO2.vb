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

    Private Sub PurchaseOrderBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.PurchaseOrderBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    End Sub

    Private Sub frmPO2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet1.dealer' table. You can move, or remove it, as needed.
        Me.PurchaseOrderTableAdapter.Fill(Me.Comp400_2012DataSet.purchaseOrder)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.wholesaleOrder' table. You can move, or remove it, as needed.
        'Me.WholesaleOrderTableAdapter.FillByOpenOrders(Me.Comp400_2012DataSet.wholesaleOrder)

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

    Private Sub btnCloseOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnCloseOrder.Click
        Dim rowview As DataRowView = PurchaseOrderBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.wholesaleOrderRow = rowview.Row
            Try
                PurchaseOrderTableAdapter.CloseDealerOrder(True, row.whlslOrderNbr)
                Me.PurchaseOrderTableAdapter.FillByOpenOrders(Comp400_2012DataSet.wholesaleOrder)
            Catch ex As Exception
                MsgBox("Could not close Order.", MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub

    Private Sub btnCreateNewOrder_Click(sender As System.Object, e As System.EventArgs) Handles btnCreateNewOrder.Click
        Dim myPurchaseOrderForm As New frmPO2
        myPurchaseOrderForm.Show()
        Me.Close()
    End Sub

End Class