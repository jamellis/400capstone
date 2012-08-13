Public Class frmSalesInvSearch

    Public tCode As String
    Public rPrice As Decimal
    Public tQuant As Integer

    Private Sub frmSalesInvSearch_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.invSearch' table. You can move, or remove it, as needed.


        ' Use this to populate this combobox with list of Stores
        cboStore.Items.Clear()
        cboStore.Items.Add("All")

        Dim table As comp400_2012DataSet.storeDataTable = StoreTableAdapter1.GetData()

        For Each storeRow In table
            cboStore.Items.Add(storeRow.storeNbr)
        Next
        Dim storeNum As String = userInfo.StoreNumber
        cboStore.SelectedItem = storeNum
        Me.InvSearchTableAdapter.FillBySearchStoreNbr(Me.Comp400_2012DataSet.invSearch, txtSearch.Text, storeNum)
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        If cboStore.SelectedIndex < 1 Then
            Me.InvSearchTableAdapter.FillBySearch(Me.Comp400_2012DataSet.invSearch, txtSearch.Text)
        Else
            Dim storeNum = CStr(cboStore.SelectedItem)
            Me.InvSearchTableAdapter.FillBySearchStoreNbr(Me.Comp400_2012DataSet.invSearch, txtSearch.Text, storeNum)
        End If
    End Sub

    Private Sub btnUse_Click(sender As System.Object, e As System.EventArgs) Handles btnUse.Click
        Dim rowview As DataRowView = InvSearchBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.invSearchRow = rowview.Row
            If row.storeNbr = userInfo.StoreNumber Then
                tCode = row.tireCode
                rPrice = row.retailPrice
                tQuant = row.tireQty
                DialogResult = Windows.Forms.DialogResult.OK
            Else
                MsgBox("You cannot select a tire from another store." & vbNewLine & _
                       "Please select store # " & userInfo.StoreNumber & " before clicking Select this Tire")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub cboStore_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboStore.SelectedIndexChanged
        Try
            If cboStore.SelectedIndex < 1 Then
                Me.InvSearchTableAdapter.FillBySearch(Me.Comp400_2012DataSet.invSearch, txtSearch.Text)
            Else
                Dim storeNum = CStr(cboStore.SelectedItem)
                Me.InvSearchTableAdapter.FillBySearchStoreNbr(Me.Comp400_2012DataSet.invSearch, txtSearch.Text, storeNum)
            End If
            'Dim storeNum = CStr(cboStore.SelectedItem)
            'Me.InvSearchTableAdapter.FillBySearchStoreNbr(Me.Comp400_2012DataSet.invSearch, txtSearch.Text, storeNum)
        Catch ex As Exception
            MsgBox("Failed to search database. " & ex.Message)
        End Try
    End Sub
End Class