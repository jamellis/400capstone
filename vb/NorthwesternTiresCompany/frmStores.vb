Public Class frmStores

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim curRec As DataRowView = StoreBindingSource.Current

        'Dim curRec As DataRowView = StoreBindingSource.Current
        If curRec.Row.RowState <> DataRowState.Unchanged Then
            MsgBox("Yes! Current Row state is: " & curRec.Row.RowState.ToString(), MsgBoxStyle.OkOnly)
            'Dim result = MessageBox.Show("Unsaved changes. Do you want to exit?", "Unsaved changes", MessageBoxButtons.YesNo)
            'If result = Windows.Forms.DialogResult.Yes Then
            '    Application.Exit()
            'Else
            '    'do nothing - stay here
            'End If
        Else
            MsgBox("No! Current Row state is: " & curRec.Row.RowState.ToString(), MsgBoxStyle.OkOnly)
            'Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
            'If result = Windows.Forms.DialogResult.Yes Then
            '    Application.Exit()
            'Else
            '    'do nothing - stay here
            'End If

        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim curRec As DataRowView = StoreBindingSource.Current
        If curRec.Row.RowState <> DataRowState.Unchanged Then
            Dim result = MessageBox.Show("Changes will be lost. Do you want to go back to the Main Menu?", "Unsaved changes", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Dim MainMenuForm As New frmMainMenu

                MainMenuForm.Show()
                Me.Close()
            Else
                'do nothing - stay here
            End If
        Else
            'Dim result = MessageBox.Show("Are you sure you want to go to the Main Menu?", "Main Menu", MessageBoxButtons.YesNo)
            'If result = Windows.Forms.DialogResult.Yes Then
            Dim MainMenuForm As New frmMainMenu

            MainMenuForm.Show()
            Me.Close()
            'Else
            'do nothing - stay here
            'End If

        End If
        'Dim MainMenuForm As New frmMainMenu

        'MainMenuForm.Show()
        'Me.Close()
    End Sub

    Private Sub StoreBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StoreBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StoreBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

        StoreDataGridView.Enabled = True
        txtCity.ReadOnly = True
        txtEmail.ReadOnly = True
        txtFax.ReadOnly = True
        txtPhone.ReadOnly = True
        txtState.ReadOnly = True
        txtStoreNbr.ReadOnly = True
        txtStreetAddress.ReadOnly = True
        txtZip.ReadOnly = True
        Me.StoreBindingNavigatorSaveItem.Enabled = False
        Me.StoreBindingNavigator.AddNewItem.Enabled = True
        Me.StoreBindingNavigator.DeleteItem.Enabled = True
        btnModify.Enabled = True
    End Sub

    Private Sub frmStores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.store' table. You can move, or remove it, as needed.
        Try
            Me.StoreTableAdapter.Fill(Me.Comp400_2012DataSet.store)
        Catch ex As Exception
            MsgBox("Error loading data, please contact your systems administrator." & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
        End Try
        Me.StoreBindingNavigatorSaveItem.Enabled = False
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        StoreDataGridView.Enabled = False
        txtCity.ReadOnly = False
        txtEmail.ReadOnly = False
        txtFax.ReadOnly = False
        txtPhone.ReadOnly = False
        txtState.ReadOnly = False
        txtStoreNbr.ReadOnly = False
        txtStreetAddress.ReadOnly = False
        txtZip.ReadOnly = False
        Me.StoreBindingNavigatorSaveItem.Enabled = True
        Me.StoreBindingNavigator.AddNewItem.Enabled = False
        Me.StoreBindingNavigator.DeleteItem.Enabled = False
        btnModify.Enabled = False

    End Sub

End Class