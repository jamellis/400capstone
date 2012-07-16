<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.components = New System.ComponentModel.Container()
        Me.lblSplash = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTop = New System.Windows.Forms.Label()
        Me.lblBottom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblSplash
        '
        Me.lblSplash.AutoSize = True
        Me.lblSplash.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplash.Location = New System.Drawing.Point(105, 643)
        Me.lblSplash.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblSplash.Name = "lblSplash"
        Me.lblSplash.Size = New System.Drawing.Size(616, 55)
        Me.lblSplash.TabIndex = 0
        Me.lblSplash.Text = "Temp text for splash screen"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 3000
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.BackColor = System.Drawing.Color.Transparent
        Me.lblTop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblTop.Location = New System.Drawing.Point(108, 27)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(407, 34)
        Me.lblTop.TabIndex = 1
        Me.lblTop.Text = "NorthWestern Tire Company"
        Me.lblTop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBottom
        '
        Me.lblBottom.AutoSize = True
        Me.lblBottom.BackColor = System.Drawing.Color.Transparent
        Me.lblBottom.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblBottom.Location = New System.Drawing.Point(97, 300)
        Me.lblBottom.Name = "lblBottom"
        Me.lblBottom.Size = New System.Drawing.Size(429, 68)
        Me.lblBottom.TabIndex = 2
        Me.lblBottom.Text = "We have the Tires and Wheels" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "your looking for"
        Me.lblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(18.0!, 34.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.NorthwesternTiresCompany.My.Resources.Resources.Wheel___Tire
        Me.ClientSize = New System.Drawing.Size(623, 402)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblBottom)
        Me.Controls.Add(Me.lblTop)
        Me.Controls.Add(Me.lblSplash)
        Me.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSplash As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblTop As System.Windows.Forms.Label
    Friend WithEvents lblBottom As System.Windows.Forms.Label

End Class
