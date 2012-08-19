Public Class frmReportMfgPO
    Public poMFGnumber As Integer

    Private Sub btnBack_Click(sender As System.Object, e As System.EventArgs) Handles btnBack.Click
        frmReport.Show()
        Me.Close()
    End Sub
    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result = MessageBox.Show("Are you sure you want to exit?", "Exit Application", MessageBoxButtons.YesNo)
        If result = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        Else
            'do nothing - stay here
        End If
    End Sub

    Private Sub frmReportMfgPO_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'comp400_2012DataSet.MFPOTableAdapter' table. You can move, or remove it, as needed.
        Me.MFPOTableAdapter.Fill(Me.comp400_2012DataSet.MFPOTableAdapter)
        

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class