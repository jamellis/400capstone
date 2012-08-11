Public Class frmCustomers
    Public custNum As Integer
    Public fName As String
    Public lName As String
    Public cPhone As String

    Private Sub CustomerBindingNavigatorSaveItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Validate()
        Me.CustomerBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    End Sub

    Private Sub frmCustomers_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.Comp400_2012DataSet.customer)

    End Sub

    Private Sub btnUse_Click(sender As System.Object, e As System.EventArgs) Handles btnUse.Click
        Dim rowview As DataRowView = CustomerBindingSource.Current
        Dim row As comp400_2012DataSet.customerRow = rowview.Row
        custNum = row.customerID
        fName = row.custFirstName
        lName = row.custLastName
        cPhone = row.custPhone
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.CustomerTableAdapter.FillBySearch(Me.Comp400_2012DataSet.customer, txtSearch.Text)
        Catch ex As Exception
            MsgBox("Search failed.")
        End Try
    End Sub
End Class