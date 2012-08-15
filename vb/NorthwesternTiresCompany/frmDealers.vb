Public Class frmDealers
    Public dealerNum As Integer
    Public dName As String
    Public dPhone As String

    Private Sub frmDealers_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.dealer' table. You can move, or remove it, as needed.
        Try
            Me.DealerTableAdapter.Fill(Me.Comp400_2012DataSet.dealer)
        Catch ex As Exception
            MsgBox("There was a problem loading data. Contact your systems administrator." & vbNewLine & ex.Message)
        End Try
    End Sub

    Private Sub btnUse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUse.Click
        Dim rowview As DataRowView = DealerBindingSource.Current
        If rowview IsNot Nothing Then
            Dim row As comp400_2012DataSet.dealerRow = rowview.Row
            dealerNum = row.dealerId
            dName = row.dealerName
            dPhone = row.dealerPhone
            DialogResult = Windows.Forms.DialogResult.OK
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.DealerTableAdapter.FillBySearch(Me.Comp400_2012DataSet.dealer, txtSearch.Text)
        Catch ex As Exception
            MsgBox("Search failed.")
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        DealerDataGridView.Enabled = False
        txtSearch.ReadOnly = True
        btnSearch.Enabled = False
        txtDealerName.ReadOnly = False
        txtDealerPhone.ReadOnly = False
        txtDealerStreet.ReadOnly = False
        txtDealerCity.ReadOnly = False
        txtDealerState.ReadOnly = False
        txtDealerZip.ReadOnly = False
        btnAdd.Enabled = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnUse.Enabled = False
        btnExit.Enabled = False
        Me.DealerBindingSource.AddNew()
        txtDealerName.Focus()
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        DealerDataGridView.Enabled = False
        txtSearch.ReadOnly = True
        btnSearch.Enabled = False
        txtDealerName.ReadOnly = False
        txtDealerPhone.ReadOnly = False
        txtDealerStreet.ReadOnly = False
        txtDealerCity.ReadOnly = False
        txtDealerState.ReadOnly = False
        txtDealerZip.ReadOnly = False
        btnAdd.Enabled = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnUse.Enabled = False
        btnExit.Enabled = False
        txtDealerName.Focus()
    End Sub

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validator.IsPresent(txtDealerName, "Dealer Name") AndAlso _
    Validator.IsPresent(txtDealerPhone, "Phone Number") AndAlso _
    Validator.IsPresent(txtDealerStreet, "Street Address") AndAlso _
    Validator.IsPresent(txtDealerCity, "City") AndAlso _
    Validator.IsPresent(txtDealerState, "State") AndAlso _
    Validator.IsPresent(txtDealerZip, "Zip") Then
            Try
                Me.Validate()
                Me.DealerBindingSource.EndEdit()
                Me.DealerTableAdapter.Update(Me.Comp400_2012DataSet.dealer)
                MsgBox("Update successful")
            Catch ex As Exception
                MsgBox("Update failed, please check that all information was entered.")
            End Try
            Try
                Me.DealerTableAdapter.Fill(Me.Comp400_2012DataSet.dealer)
            Catch ex As Exception
                MsgBox("Error loading data, please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
            End Try
            DealerDataGridView.Enabled = True
            txtSearch.ReadOnly = False
            btnSearch.Enabled = True
            txtDealerName.ReadOnly = True
            txtDealerPhone.ReadOnly = True
            txtDealerStreet.ReadOnly = True
            txtDealerCity.ReadOnly = True
            txtDealerState.ReadOnly = True
            txtDealerZip.ReadOnly = True
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
            DealerBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Cancel edit failed.")
        End Try
        DealerDataGridView.Enabled = True
        txtSearch.ReadOnly = False
        btnSearch.Enabled = True
        txtDealerName.ReadOnly = True
        txtDealerPhone.ReadOnly = True
        txtDealerStreet.ReadOnly = True
        txtDealerCity.ReadOnly = True
        txtDealerState.ReadOnly = True
        txtDealerZip.ReadOnly = True
        btnAdd.Enabled = True
        btnModify.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnUse.Enabled = True
        btnExit.Enabled = True
    End Sub
End Class