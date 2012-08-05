Public Class frmTires

    'Private Sub TireBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.TireBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    'End Sub

    Private Sub frmTires_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.tire' table. You can move, or remove it, as needed.
        Me.TireTableAdapter.Fill(Me.Comp400_2012DataSet.tire)
        btnSave.Enabled = False
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ' System locks up if a new store is started but the StoreNbr field is left blank. This lets the user undo changes.
        If txtTireCode.Text = "" Then
            txtTireCode.Text = "0000"
        End If
        Try
            TireBindingSource.EndEdit()
            Dim curRec As DataRowView = TireBindingSource.Current
            If curRec.Row.RowState <> DataRowState.Unchanged Then
                Dim result = MessageBox.Show("Changes will be lost. Do you want to go back to the Main Menu?", "Unsaved changes", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    frmMainMenu.Show()
                    Me.Close()
                Else
                    'do nothing - stay here
                End If
            Else
                frmMainMenu.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Please contact your systems administrator" & ex.Message)
        End Try

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' System locks up if a new store is started but the StoreNbr field is left blank. This lets the user undo changes.
        If txtTireCode.Text = "" Then
            txtTireCode.Text = "0000"
        End If
        Try
            TireBindingSource.EndEdit()
            Dim curRec As DataRowView = TireBindingSource.Current

            If curRec.Row.RowState <> DataRowState.Unchanged Then
                Dim result = MessageBox.Show("Unsaved changes. Do you want to exit?", "Unsaved changes", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    Application.Exit()
                Else
                    'do nothing - stay here
                End If
            Else
                Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    Application.Exit()
                Else
                    'do nothing - stay here
                End If

            End If
        Catch ex As Exception
            MsgBox("Please contact your systems administrator" & ex.Message)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        TireDataGridView.Enabled = False
        txtTireCode.ReadOnly = False
        txtManufacturer.ReadOnly = False
        txtTireSize.ReadOnly = False
        txtDescription.ReadOnly = False
        txtRetailPrice.ReadOnly = False
        txtDealerPrice.ReadOnly = False
        txtWholesaleCost.ReadOnly = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        txtSearch.Enabled = False
        btnSearch.Enabled = False
        txtRetailPrice.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validator.IsPresent(txtTireCode, "Tire Code") AndAlso _
            Validator.IsPresent(txtManufacturer, "Manufacturer") AndAlso _
            Validator.IsPresent(txtTireSize, "Tire Size") AndAlso _
            Validator.IsPresent(txtDescription, "Description") AndAlso _
            Validator.IsPresent(txtRetailPrice, "Retail Price") AndAlso _
            Validator.IsPresent(txtDealerPrice, "Dealer Price") AndAlso _
            Validator.IsPresent(txtWholesaleCost, "Wholesale Cost") Then
            Try
                Me.Validate()
                Me.TireBindingSource.EndEdit()
                Me.TireTableAdapter.Update(Me.Comp400_2012DataSet.tire)
                MsgBox("Update successful")
            Catch ex As Exception
                MsgBox("Update failed, please check that all information was entered.")
            End Try
            Try
                Me.TireTableAdapter.Fill(Me.Comp400_2012DataSet.tire)
            Catch ex As Exception
                MsgBox("Error loading data, please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
            End Try
            TireDataGridView.Enabled = True
            txtTireCode.ReadOnly = True
            txtManufacturer.ReadOnly = True
            txtTireSize.ReadOnly = True
            txtDescription.ReadOnly = True
            txtRetailPrice.ReadOnly = True
            txtDealerPrice.ReadOnly = True
            txtWholesaleCost.ReadOnly = True
            btnModify.Enabled = True
            btnSave.Enabled = False
            btnCancel.Enabled = False
            btnAdd.Enabled = True
            btnDelete.Enabled = True
            txtSearch.Enabled = True
            btnSearch.Enabled = True
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        TireDataGridView.Enabled = False
        txtTireCode.ReadOnly = False
        txtManufacturer.ReadOnly = False
        txtTireSize.ReadOnly = False
        txtDescription.ReadOnly = False
        txtRetailPrice.ReadOnly = False
        txtDealerPrice.ReadOnly = False
        txtWholesaleCost.ReadOnly = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        txtSearch.Enabled = False
        btnSearch.Enabled = False
        Me.TireBindingSource.AddNew()
        txtTireCode.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim result = MsgBox("Are you sure you want to delete this tire?" & vbNewLine & "This cannot be undone.", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then
                Me.TireBindingSource.RemoveCurrent()
                Me.TireBindingSource.EndEdit()
                Me.TireTableAdapter.Update(Comp400_2012DataSet)
                Me.TireTableAdapter.Fill(Me.Comp400_2012DataSet.tire)
                MsgBox("Tire deleted.")
            End If
        Catch ex As Exception
            MsgBox("Delete failed.")
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.TireTableAdapter.FillBySearch(Me.Comp400_2012DataSet.tire, txtSearch.Text)
        Catch ex As Exception
            MsgBox("Search failed.")
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.TireBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Cancel Edit failed.")
        End Try
        TireDataGridView.Enabled = True
        txtTireCode.ReadOnly = True
        txtManufacturer.ReadOnly = True
        txtTireSize.ReadOnly = True
        txtDescription.ReadOnly = True
        txtRetailPrice.ReadOnly = True
        txtDealerPrice.ReadOnly = True
        txtWholesaleCost.ReadOnly = True
        btnModify.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = True
        txtSearch.Enabled = True
        btnSearch.Enabled = True
    End Sub
End Class