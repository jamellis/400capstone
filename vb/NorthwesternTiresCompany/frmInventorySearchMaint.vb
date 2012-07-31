Imports System.Data.SqlClient

Public Class frmInventorySearchMaint

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        'Dim MainMenuForm As New frmMainMenu
        frmMainMenu.Show()
        Me.Close()
    End Sub

    Private Sub frmInventorySearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.inventory' table. You can move, or remove it, as needed.
        'Me.InventoryTableAdapter.Fill(Me.Comp400_2012DataSet.inventory)
        'TODO: This line of code loads data into the 'Comp400_2012DataSet.invSearch' table. You can move, or remove it, as needed.
        ' cmd.Connection = cn
        Try
            Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)
        Catch ex As Exception
            MsgBox("Database error. Please contact your systems administrator " & vbNewLine & ex.Message, MsgBoxStyle.OkOnly)
        End Try

        txtSearch.Focus()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        ' Dim SelectQry = "SELECT inventory.inventoryNbr, inventory.tireCode, tire.manufacturer, tire.description, tire.manufacturerSize, tire.retailPrice, inventory.tireQty, inventory.storeNbr FROM inventory INNER JOIN store ON inventory.storeNbr = store.storeNbr INNER JOIN tire ON inventory.tireCode = tire.tireCode WHERE (inventory.tireCode LIKE '%" & Me.txtSearch.Text & "%') OR (tire.manufacturer LIKE '%" & Me.txtSearch.Text & "%') OR (tire.description LIKE '%" & Me.txtSearch.Text & "%') OR (tire.manufacturerSize LIKE '%" & Me.txtSearch.Text & "%')"
        ' Me.InvSearchTableAdapter.Fill(SelectQry)
        If cboStore.SelectedIndex < 1 Then
            Me.InvSearchTableAdapter.FillBySearch(Me.Comp400_2012DataSet.invSearch, txtSearch.Text)
        Else
            Dim storeNum As String
            storeNum = CStr(cboStore.SelectedItem)
            Me.InvSearchTableAdapter.FillBySearchStoreNbr(Me.Comp400_2012DataSet.invSearch, txtSearch.Text, storeNum)
        End If

    End Sub

    Private Sub btnUpdateQty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateQty.Click

        If Validator.IsPresent(txtTireQty, "Quantity") AndAlso
           Validator.IsInt32(txtTireQty, "Quantity") Then
            Try
                Dim rowView As DataRowView = InvSearchBindingSource.Current
                Dim curRow As comp400_2012DataSet.invSearchRow = rowView.Row
                InvSearchTableAdapter.UpdateQuantity(txtTireQty.Text, curRow.inventoryNbr)
                Me.InvSearchTableAdapter.Fill(Me.Comp400_2012DataSet.invSearch)
            Catch ex As Exception
                MsgBox("Quantity Update error" & ex.Message, MsgBoxStyle.OkOnly, "Error")
            End Try
        End If
    End Sub
End Class