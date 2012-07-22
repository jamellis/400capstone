<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.btnStores = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnTires = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pctMainMenu = New System.Windows.Forms.PictureBox()
        CType(Me.pctMainMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStores
        '
        Me.btnStores.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStores.Location = New System.Drawing.Point(609, 206)
        Me.btnStores.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStores.Name = "btnStores"
        Me.btnStores.Size = New System.Drawing.Size(187, 37)
        Me.btnStores.TabIndex = 17
        Me.btnStores.Text = "&Stores"
        Me.btnStores.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(789, 578)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(107, 37)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnTires
        '
        Me.btnTires.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTires.Location = New System.Drawing.Point(609, 132)
        Me.btnTires.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTires.Name = "btnTires"
        Me.btnTires.Size = New System.Drawing.Size(187, 37)
        Me.btnTires.TabIndex = 15
        Me.btnTires.Text = "&Tires"
        Me.btnTires.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(377, 14)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(154, 32)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Main Menu"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(523, 580)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Log Out"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pctMainMenu
        '
        Me.pctMainMenu.Image = Global.NorthwesternTiresCompany.My.Resources.Resources.tires
        Me.pctMainMenu.Location = New System.Drawing.Point(55, 103)
        Me.pctMainMenu.Name = "pctMainMenu"
        Me.pctMainMenu.Size = New System.Drawing.Size(323, 362)
        Me.pctMainMenu.TabIndex = 20
        Me.pctMainMenu.TabStop = False
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 630)
        Me.Controls.Add(Me.pctMainMenu)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnStores)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnTires)
        Me.Controls.Add(Me.lblTitle)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.pctMainMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStores As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnTires As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents pctMainMenu As System.Windows.Forms.PictureBox
End Class
