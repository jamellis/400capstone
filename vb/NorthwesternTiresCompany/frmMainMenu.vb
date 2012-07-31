Public Class frmMainMenu

    Private _clearance As String

    Public Property Clearance As String
        Get
            Return _clearance
        End Get
        Set(ByVal value As String)
            _clearance = value
        End Set
    End Property

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub btnTires_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTires.Click
        Dim TiresForm As New frmTires

        TiresForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnStores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStores.Click
        Dim StoresForm As New frmStores

        StoresForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        'frmLogin.Show()
        'Me.Close()
        If btnLogOut.Text = "&Log In" Then
            frmLogin.Show()
            Me.Close()
        Else
            Dim result = MessageBox.Show("Are you sure you want to Log Out?", "Log Out", MessageBoxButtons.YesNo)
            If result = Windows.Forms.DialogResult.Yes Then
                frmLogin.Show()
                Me.Close()
            Else
                'do nothing - stay here
            End If
        End If
    End Sub

    Private Sub btnInventorySearch_Click(sender As System.Object, e As System.EventArgs) Handles btnInventorySearch.Click
        Dim InventorySearchForm As New frmInventorySearch

        InventorySearchForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnInventoryMaintain_Click(sender As System.Object, e As System.EventArgs) Handles btnInventoryMaintain.Click
        Dim InventoryMaintainForm As New frmInventorySearchMaint

        InventoryMaintainForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSales_Click(sender As System.Object, e As System.EventArgs) Handles btnSales.Click
        Dim SalesForm As New frmSales

        SalesForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnReports_Click(sender As System.Object, e As System.EventArgs) Handles btnReports.Click
        Dim ReportForm As New frmReport

        ReportForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnEmployee_Click(sender As System.Object, e As System.EventArgs) Handles btnEmployee.Click
        Dim EmployeeForm As New frmEmployee

        EmployeeForm.Show()
        Me.Hide()
    End Sub

    Private Sub btnPO_Click(sender As System.Object, e As System.EventArgs) Handles btnPO.Click
        Dim POForm As New frmPO2

        POForm.Show()
        Me.Hide()
    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MsgBox("Incoming clearance is: " & _clearance, MsgBoxStyle.OkOnly)
        If _clearance IsNot Nothing Then

            If _clearance = "Warehouse" Then
                btnInventoryMaintain.Enabled = True
                btnLogOut.Text = "&Log Out"
            End If
            If _clearance = "Sales" Then
                btnSales.Enabled = True
                btnLogOut.Text = "&Log Out"
            End If
            If _clearance = "Manager" Then
                btnReports.Enabled = True
                btnSales.Enabled = True
                btnInventoryMaintain.Enabled = True
                btnLogOut.Text = "&Log Out"
            End If
            If _clearance = "Admin" Then
                btnEmployee.Enabled = True
                btnInventoryMaintain.Enabled = True
                btnPO.Enabled = True
                btnReports.Enabled = True
                btnSales.Enabled = True
                btnStores.Enabled = True
                btnTires.Enabled = True
                btnLogOut.Text = "&Log Out"
            End If

        End If
    End Sub
End Class