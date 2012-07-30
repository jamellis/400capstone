Public Class frmEmployee

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim curRec As DataRowView = EmployeeBindingSource.Current
        If curRec.Row.RowState <> DataRowState.Unchanged Then
            Dim result = MessageBox.Show("Unsaved changes. Do you want to exit?", "Unsaved changes", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                Application.Exit()
            Else
                'do nothing - stay here
            End If
        Else
            Application.Exit()

        End If

    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim MainMenuForm As New frmMainMenu
        MainMenuForm.Show()
        Me.Close()
    End Sub


    Private Sub EmployeeBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    End Sub

    Private Sub frmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.employee' table. You can move, or remove it, as needed.

        Me.EmployeeTableAdapter.Fill(Me.Comp400_2012DataSet.employee)

    End Sub

    'Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
    '    EmployeeBindingSource.AddNew()
    'End Sub
End Class