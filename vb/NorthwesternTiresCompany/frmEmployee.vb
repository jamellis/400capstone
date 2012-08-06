Public Class frmEmployee

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Try
            EmployeeBindingSource.EndEdit()
            Dim curRec As DataRowView = EmployeeBindingSource.Current
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

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        ' System locks up if a new store is started but the StoreNbr field is left blank. This lets the user undo changes.
        Try
            EmployeeBindingSource.EndEdit()
            Dim curRec As DataRowView = EmployeeBindingSource.Current
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

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.store' table. You can move, or remove it, as needed.
        Me.StoreTableAdapter.Fill(Me.Comp400_2012DataSet.store)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.employee' table. You can move, or remove it, as needed.

        Me.EmployeeTableAdapter.Fill(Me.Comp400_2012DataSet.employee)

    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        EmployeeDataGridView.Enabled = False
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtUserSecurity.ReadOnly = False
        txtStoreNbr.Enabled = True
        txtUserID.ReadOnly = False
        txtPassword.ReadOnly = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        txtSearch.Enabled = False
        btnSearch.Enabled = False
        txtFirstName.Focus()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Validator.IsPresent(txtFirstName, "First Name") AndAlso _
            Validator.IsPresent(txtLastName, "Last Name") AndAlso _
            Validator.IsPresent(txtUserSecurity, "Security Clearance") AndAlso _
            Validator.IsPresent(txtStoreNbr, "Store Number") AndAlso _
            Validator.IsPresent(txtUserID, "User ID") AndAlso _
            Validator.IsPresent(txtPassword, "Password") Then
            Try
                Me.Validate()
                Me.EmployeeBindingSource.EndEdit()
                Me.EmployeeTableAdapter.Update(Me.Comp400_2012DataSet.employee)
                MsgBox("Update successful.")
            Catch ex As Exception
                MsgBox("Update failed, please check that all information was entered.")
            End Try
            Try
                Me.EmployeeTableAdapter.Fill(Me.Comp400_2012DataSet.employee)
            Catch ex As Exception
                MsgBox("Error loading data, please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
            End Try
            EmployeeDataGridView.Enabled = True
            txtFirstName.ReadOnly = True
            txtLastName.ReadOnly = True
            txtUserSecurity.ReadOnly = True
            txtStoreNbr.Enabled = False
            txtUserID.ReadOnly = True
            txtPassword.ReadOnly = True
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
        EmployeeDataGridView.Enabled = False
        txtFirstName.ReadOnly = False
        txtLastName.ReadOnly = False
        txtUserSecurity.ReadOnly = False
        txtStoreNbr.Enabled = True
        txtUserID.ReadOnly = False
        txtPassword.ReadOnly = False
        btnModify.Enabled = False
        btnSave.Enabled = True
        btnCancel.Enabled = True
        btnAdd.Enabled = False
        btnDelete.Enabled = False
        txtSearch.Enabled = False
        btnSearch.Enabled = False
        Me.EmployeeBindingSource.AddNew()
        txtFirstName.Focus()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim result = MsgBox("Are you sure you want to delete this employee?" & vbNewLine & "This cannot be undone.", MsgBoxStyle.YesNo)
            If result = DialogResult.Yes Then
                Me.EmployeeBindingSource.RemoveCurrent()
                Me.EmployeeBindingSource.EndEdit()
                Me.EmployeeTableAdapter.Update(Comp400_2012DataSet)
                Me.EmployeeTableAdapter.Fill(Me.Comp400_2012DataSet.employee)
                MsgBox("Employee deleted.")
            End If
        Catch ex As Exception
            MsgBox("Delete failed.")
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.EmployeeTableAdapter.FillBySearch(Me.Comp400_2012DataSet.employee, txtSearch.Text)
        Catch ex As Exception
            MsgBox("Search failed.")
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.EmployeeBindingSource.CancelEdit()
        Catch ex As Exception
            MsgBox("Cancel edit failed.")
        End Try
        EmployeeDataGridView.Enabled = True
        txtFirstName.ReadOnly = True
        txtLastName.ReadOnly = True
        txtUserSecurity.ReadOnly = True
        txtStoreNbr.Enabled = False
        txtUserID.ReadOnly = True
        txtPassword.ReadOnly = True
        btnModify.Enabled = True
        btnSave.Enabled = False
        btnCancel.Enabled = False
        btnAdd.Enabled = True
        btnDelete.Enabled = True
        txtSearch.Enabled = True
        btnSearch.Enabled = True
    End Sub
End Class