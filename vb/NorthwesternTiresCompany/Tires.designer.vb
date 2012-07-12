<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTires
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
        Me.lblTires = New System.Windows.Forms.Label()
        Me.tbTireID = New System.Windows.Forms.TextBox()
        Me.tbLocation = New System.Windows.Forms.TextBox()
        Me.lblTireID = New System.Windows.Forms.Label()
        Me.lblLocation = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTires
        '
        Me.lblTires.AutoSize = True
        Me.lblTires.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTires.Location = New System.Drawing.Point(12, 9)
        Me.lblTires.Name = "lblTires"
        Me.lblTires.Size = New System.Drawing.Size(60, 24)
        Me.lblTires.TabIndex = 0
        Me.lblTires.Text = "Tires"
        '
        'tbTireID
        '
        Me.tbTireID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTireID.Location = New System.Drawing.Point(195, 74)
        Me.tbTireID.Name = "tbTireID"
        Me.tbTireID.Size = New System.Drawing.Size(100, 26)
        Me.tbTireID.TabIndex = 1
        '
        'tbLocation
        '
        Me.tbLocation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLocation.Location = New System.Drawing.Point(195, 130)
        Me.tbLocation.Name = "tbLocation"
        Me.tbLocation.Size = New System.Drawing.Size(100, 26)
        Me.tbLocation.TabIndex = 2
        '
        'lblTireID
        '
        Me.lblTireID.AutoSize = True
        Me.lblTireID.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTireID.Location = New System.Drawing.Point(136, 82)
        Me.lblTireID.Name = "lblTireID"
        Me.lblTireID.Size = New System.Drawing.Size(53, 18)
        Me.lblTireID.TabIndex = 3
        Me.lblTireID.Text = "Tire ID"
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(121, 138)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(68, 18)
        Me.lblLocation.TabIndex = 4
        Me.lblLocation.Text = "Location"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.Red
        Me.btnBack.Location = New System.Drawing.Point(13, 195)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(329, 195)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmTires
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 230)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.lblTireID)
        Me.Controls.Add(Me.tbLocation)
        Me.Controls.Add(Me.tbTireID)
        Me.Controls.Add(Me.lblTires)
        Me.Name = "frmTires"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTires As System.Windows.Forms.Label
    Friend WithEvents tbTireID As System.Windows.Forms.TextBox
    Friend WithEvents tbLocation As System.Windows.Forms.TextBox
    Friend WithEvents lblTireID As System.Windows.Forms.Label
    Friend WithEvents lblLocation As System.Windows.Forms.Label
    Friend WithEvents btnBack As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
