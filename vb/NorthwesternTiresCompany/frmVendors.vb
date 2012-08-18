Public Class frmVendors
    Public vendorNum As Integer
    Public vName As String

    Private Sub frmVendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.vendor' table. You can move, or remove it, as needed.
        Try
            Me.VendorTableAdapter.Fill(Me.Comp400_2012DataSet.vendor)
        Catch ex As Exception
            MsgBox("There was a problem loading data. Contact your systems administrator." & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub btnUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUse.Click
        Dim rowview As DataRowView = VendorBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.vendorRow = rowview.Row
            vendorNum = row.vendorID
            vName = row.vendorName
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.VendorTableAdapter.FillBySearch(Me.Comp400_2012DataSet.vendor, txtSearch.Text)
        Catch ex As Exception
            MsgBox("Search failed.")
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        VendorDataGridView.Enabled = False
        txtSearch.ReadOnly = True
        btnSearch.Enabled = False
        txtVendorName.ReadOnly = False
        btnAdd.Enabled = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnUse.Enabled = False
        btnExit.Enabled = False
        Me.VendorBindingSource.AddNew()
        txtVendorName.Focus()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        VendorDataGridView.Enabled = False
        txtSearch.ReadOnly = True
        btnSearch.Enabled = False
        txtVendorName.ReadOnly = False
        btnAdd.Enabled = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnUse.Enabled = False
        btnExit.Enabled = False
        txtVendorName.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validator.IsPresent(txtVendorName, "Vendor Name") Then
            Try
                Me.Validate()
                Me.VendorBindingSource.EndEdit()
                Me.VendorTableAdapter.Update(Me.Comp400_2012DataSet.vendor)
                MsgBox("Update successful")
            Catch ex As Exception
                MsgBox("Update failed, please check that all information was entered.")
            End Try
            Try
                Me.VendorTableAdapter.Fill(Me.Comp400_2012DataSet.vendor)
            Catch ex As Exception
                MsgBox("Error loading data, please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
            End Try
            VendorDataGridView.Enabled = True
            txtSearch.ReadOnly = False
            btnSearch.Enabled = True
            txtVendorName.ReadOnly = True
            btnAdd.Enabled = True
            btnModify.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnUse.Enabled = True
            btnExit.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            VendorBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Cancel edit failed.")
        End Try
        VendorDataGridView.Enabled = True
        txtSearch.ReadOnly = False
        btnSearch.Enabled = True
        txtVendorName.ReadOnly = True
        btnAdd.Enabled = True
        btnModify.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnUse.Enabled = True
        btnExit.Enabled = True
    End Sub
End Class