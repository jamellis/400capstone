Public Class frmCustomers
    Public custNum As Integer
    Public fName As String
    Public lName As String
    Public cPhone As String

    Private Sub frmCustomers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.customer' table. You can move, or remove it, as needed.
        Try
            Me.CustomerTableAdapter.Fill(Me.Comp400_2012DataSet.customer)
        Catch ex As Exception
            MsgBox("There was a problem loading data. Contact your systems administrator." & vbNewLine & ex.Message)
        End Try
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

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
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
        btnAdd.Enabled = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnUse.Enabled = False
        btnExit.Enabled = False
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
        btnAdd.Enabled = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnUse.Enabled = False
        btnExit.Enabled = False
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
        btnAdd.Enabled = True
        btnModify.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnUse.Enabled = True
        btnExit.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validator.IsPresent(txtFirstName, "First Name") AndAlso _
            Validator.IsPresent(txtLastName, "Last Name") AndAlso _
            Validator.IsPresent(txtPhone, "Phone Number") AndAlso _
            Validator.IsPresent(txtStreet, "Street Address") AndAlso _
            Validator.IsPresent(txtCity, "City") AndAlso _
            Validator.IsPresent(txtState, "State") AndAlso _
            Validator.IsPresent(txtZip, "Zip") Then
            Try
                Me.Validate()
                Me.CustomerBindingSource.EndEdit()
                Me.CustomerTableAdapter.Update(Me.Comp400_2012DataSet.customer)
                MsgBox("Update successful")
            Catch ex As Exception
                MsgBox("Update failed, please check that all information was entered.")
            End Try
            Try
                Me.CustomerTableAdapter.Fill(Me.Comp400_2012DataSet.customer)
            Catch ex As Exception
                MsgBox("Error loading data, please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
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
            btnAdd.Enabled = True
            btnModify.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnUse.Enabled = True
            btnExit.Enabled = True
        End If
    End Sub
End Class