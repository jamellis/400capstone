Public Class frmTires

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Dim MainMenuForm As New frmMainMenu

        MainMenuForm.Show()
        Me.Close()
    End Sub

    Private Sub TireBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TireBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TireBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Comp400_2012DataSet)

    End Sub

    Private Sub frmTires_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.tire' table. You can move, or remove it, as needed.
        Me.TireTableAdapter.Fill(Me.Comp400_2012DataSet.tire)

    End Sub
End Class