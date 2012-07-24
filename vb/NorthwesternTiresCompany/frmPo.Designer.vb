<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblPO = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblPO
        '
        Me.lblPO.AutoSize = True
        Me.lblPO.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPO.Location = New System.Drawing.Point(93, 35)
        Me.lblPO.Name = "lblPO"
        Me.lblPO.Size = New System.Drawing.Size(56, 32)
        Me.lblPO.TabIndex = 0
        Me.lblPO.Text = "PO"
        '
        'frmPo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.lblPO)
        Me.Name = "frmPo"
        Me.Text = "frmPo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblPO As System.Windows.Forms.Label
End Class
