Public Class frmSalesDealer

    Private Sub frmSalesDealer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet1.dealer' table. You can move, or remove it, as needed.
        Me.DealerTableAdapter.Fill(Me.Comp400_2012DataSet1.dealer)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.wholesaleOrder' table. You can move, or remove it, as needed.
        Me.WholesaleOrderTableAdapter.FillByOpenOrders(Me.Comp400_2012DataSet.wholesaleOrder)

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub btnCloseOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseOrder.Click
        Dim rowview As DataRowView = WholesaleOrderBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.wholesaleOrderRow = rowview.Row
            Try
                WholesaleOrderTableAdapter.CloseDealerOrder(row.whlslOrderNbr)
                Me.WholesaleOrderTableAdapter.FillByOpenOrders(Comp400_2012DataSet.wholesaleOrder)
            Catch ex As Exception
                MsgBox("Could not close Order.", MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub

    Private Sub btnSaveComments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveComments.Click
        Dim rowview As DataRowView = WholesaleOrderBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.wholesaleOrderRow = rowview.Row
            Try
                WholesaleOrderTableAdapter.UpdateComments(txtComment.Text, row.whlslOrderNbr)
                Me.WholesaleOrderTableAdapter.FillByOpenOrders(Comp400_2012DataSet.wholesaleOrder)
            Catch ex As Exception
                MsgBox("Could not close Order.", MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub

    Private Sub btnCreateNewOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreateNewOrder.Click
        Dim myNewDealerSaleForm As New frmSalesDealerNew
        myNewDealerSaleForm.Show()
        Me.Close()
    End Sub

    Private Sub btnReprint_Click(sender As System.Object, e As System.EventArgs) Handles btnReprint.Click
        Dim rowview As DataRowView = WholesaleOrderBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.wholesaleOrderRow = rowview.Row
            Try
                ' Dealer Receipt Report code goes here
                'Dim myPOReport As New frmReportMfgPO
                'myPOReport.poNumber = row.poNbr
                'myPOReport.ShowDialog()
            Catch ex As Exception
                MsgBox("Could print order. Contact your systems administrator." & _
                       vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
            End Try
        End If
    End Sub
End Class