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
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.customerRow = rowview.Row
            custNum = row.customerID
            fName = row.custFirstName
            lName = row.custLastName
            cPhone = row.custPhone
            DialogResult = Windows.Forms.DialogResult.OK
        End If
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

    Private Sub btnAdd_Click(sender As System.Object, e As System.EventArgs) Handles btnAdd.Click
        CustomerDataGridView.Enabled = False
        txtSearch.ReadOnly = True
        btnSearch.Enabled = False
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtPhone.ReadOnly = False
        txtStreet.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtZip.ReadOnly = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        Me.CustomerBindingSource.AddNew()
        txtFirstName.Focus()
    End Sub

    Private Sub btnModify_Click(sender As System.Object, e As System.EventArgs) Handles btnModify.Click
        CustomerDataGridView.Enabled = False
        txtSearch.ReadOnly = True
        btnSearch.Enabled = False
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtPhone.ReadOnly = False
        txtStreet.ReadOnly = False
        txtCity.ReadOnly = False
        txtState.ReadOnly = False
        txtZip.ReadOnly = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        txtFirstName.Focus()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Try
            CustomerBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Cancel edit failed.")
        End Try
        CustomerDataGridView.Enabled = True
        txtSearch.ReadOnly = False
        btnSearch.Enabled = True
        txtFirstName.ReadOnly = True
        txtLastName.ReadOnly = True
        txtPhone.ReadOnly = True
        txtStreet.ReadOnly = True
        txtCity.ReadOnly = True
        txtState.ReadOnly = True
        txtZip.ReadOnly = True
        btnModify.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
    End Sub
End Class