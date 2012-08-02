Public Class frmStores

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ' System locks up if a new store is started but the StoreNbr field is left blank. This lets the user undo changes.
        If txtStoreNbr.Text = "" Then
            txtStoreNbr.Text = "0000"
        End If
        Try
            StoreBindingSource.EndEdit()
            Dim curRec As DataRowView = StoreBindingSource.Current

            If curRec.Row.RowState <> DataRowState.Unchanged Then
                ' MsgBox("Yes! Current Row state is: " & curRec.Row.RowState.ToString(), MsgBoxStyle.OkOnly)
                Dim result = MessageBox.Show("Unsaved changes. Do you want to exit?", "Unsaved changes", MessageBoxButtons.YesNo)
                If result = Windows.Forms.DialogResult.Yes Then
                    Application.Exit()
                Else
                    'do nothing - stay here
                End If
            Else
                'MsgBox("No! Current Row state is: " & curRec.Row.RowState.ToString(), MsgBoxStyle.OkOnly)
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

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ' System locks up if a new store is started but the StoreNbr field is left blank. This lets the user undo changes.
        If txtStoreNbr.Text = "" Then
            txtStoreNbr.Text = "0000"
        End If
        Try
            StoreBindingSource.EndEdit()
            Dim curRec As DataRowView = StoreBindingSource.Current
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

    'Private Sub StoreBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Me.Validate()
    '    Me.StoreBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    '    StoreDataGridView.Enabled = True
    '    txtCity.ReadOnly = True
    '    txtEmail.ReadOnly = True
    '    txtFax.ReadOnly = True
    '    txtPhone.ReadOnly = True
    '    txtState.ReadOnly = True
    '    txtStoreNbr.ReadOnly = True
    '    txtStreetAddress.ReadOnly = True
    '    txtZip.ReadOnly = True
    '    'Me.StoreBindingNavigatorSaveItem.Enabled = False
    '    'Me.StoreBindingNavigator.AddNewItem.Enabled = True
    '    'Me.StoreBindingNavigator.DeleteItem.Enabled = True
    '    btnModify.Enabled = True
    'End Sub

    Private Sub frmStores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.store' table. You can move, or remove it, as needed.
        Try
            Me.StoreTableAdapter.Fill(Me.Comp400_2012DataSet.store)
        Catch ex As Exception
            MsgBox("Error loading data, please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        StoreDataGridView.Enabled = False
        lblSave.Visible = True
        txtCity.ReadOnly = False
        txtEmail.ReadOnly = False
        txtFax.ReadOnly = False
        txtPhone.ReadOnly = False
        txtState.ReadOnly = False
        txtStoreNbr.ReadOnly = False
        txtStreetAddress.ReadOnly = False
        txtZip.ReadOnly = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validator.IsPresent(txtStoreNbr, "Store Number") AndAlso _
            Validator.IsInt32(txtStoreNbr, "Store Number") AndAlso _
            Validator.IsPresent(txtStreetAddress, "Street Address") AndAlso _
            Validator.IsPresent(txtCity, "City") AndAlso _
            Validator.IsPresent(txtState, "State") AndAlso _
            Validator.IsPresent(txtZip, "Zip Code") AndAlso _
            Validator.IsPresent(txtPhone, "Phone Number") AndAlso _
            Validator.IsPresent(txtFax, "Fax Number") AndAlso _
            Validator.IsPresent(txtEmail, "Email Address") AndAlso _
            Validator.IsValidEmail(txtEmail, "Email") Then

            Try
                Me.Validate()
                Me.StoreBindingSource.EndEdit()
                Me.StoreTableAdapter.Update(Me.Comp400_2012DataSet.store)
                MsgBox("Update successful")
            Catch ex As Exception
                MsgBox("Update failed, please check that all information was entered.")
            End Try
            Try
                Me.StoreTableAdapter.Fill(Me.Comp400_2012DataSet.store)
            Catch ex As Exception
                MsgBox("Error loading data, please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
            End Try
            StoreDataGridView.Enabled = True
            lblSave.Visible = False
            txtCity.ReadOnly = True
            txtEmail.ReadOnly = True
            txtFax.ReadOnly = True
            txtPhone.ReadOnly = True
            txtState.ReadOnly = True
            txtStoreNbr.ReadOnly = True
            txtStreetAddress.ReadOnly = True
            txtZip.ReadOnly = True
            btnModify.Enabled = True
            btnSave.Enabled = False
            btnAdd.Enabled = True
            btnDelete.Enabled = True
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        StoreDataGridView.Enabled = False
        lblSave.Visible = True
        txtCity.ReadOnly = False
        txtEmail.ReadOnly = False
        txtFax.ReadOnly = False
        txtPhone.ReadOnly = False
        txtState.ReadOnly = False
        txtStoreNbr.ReadOnly = False
        txtStreetAddress.ReadOnly = False
        txtZip.ReadOnly = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        Me.StoreBindingSource.AddNew()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim result = MsgBox("Are you sure you want to delete this store?" & vbNewLine & "This cannot be undone.", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then
                Me.StoreBindingSource.RemoveCurrent()
                Me.StoreBindingSource.EndEdit()
                Me.StoreTableAdapter.Update(Comp400_2012DataSet)
                Me.StoreTableAdapter.Fill(Me.Comp400_2012DataSet.store)
            End If
        Catch ex As Exception
            MsgBox("Delete failed")
        End Try
    End Sub

End Class