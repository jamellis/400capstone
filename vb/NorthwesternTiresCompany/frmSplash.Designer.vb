﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pctRincon = New System.Windows.Forms.PictureBox()
        Me.txtLaw = New System.Windows.Forms.TextBox()
        Me.txtCopyright = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctRincon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSplash
        '
        Me.lblSplash.AutoSize = True
        Me.lblSplash.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSplash.Location = New System.Drawing.Point(105, 643)
        Me.lblSplash.Margin = New System.Windows.Forms.Padding(9, 0, 9, 0)
        Me.lblSplash.Name = "lblSplash"
        Me.lblSplash.Size = New System.Drawing.Size(766, 69)
        Me.lblSplash.TabIndex = 0
        Me.lblSplash.Text = "Temp text for splash screen"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 4000
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.NorthwesternTiresCompany.My.Resources.Resources.nwtires_logo
        Me.PictureBox1.Location = New System.Drawing.Point(224, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(295, 90)
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'pctRincon
        '
        Me.pctRincon.Image = Global.NorthwesternTiresCompany.My.Resources.Resources.rinconlogo2
        Me.pctRincon.Location = New System.Drawing.Point(162, 216)
        Me.pctRincon.Name = "pctRincon"
        Me.pctRincon.Size = New System.Drawing.Size(419, 122)
        Me.pctRincon.TabIndex = 4
        Me.pctRincon.TabStop = False
        '
        'txtLaw
        '
        Me.txtLaw.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLaw.Location = New System.Drawing.Point(12, 134)
        Me.txtLaw.Multiline = True
        Me.txtLaw.Name = "txtLaw"
        Me.txtLaw.Size = New System.Drawing.Size(690, 50)
        Me.txtLaw.TabIndex = 6
        Me.txtLaw.Text = "This is a secure system. You must have legal access in order to access it. All vi" & _
    "olators will be prosecuted to the fullest extent of the law."
        '
        'txtCopyright
        '
        Me.txtCopyright.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCopyright.Location = New System.Drawing.Point(12, 370)
        Me.txtCopyright.Multiline = True
        Me.txtCopyright.Name = "txtCopyright"
        Me.txtCopyright.Size = New System.Drawing.Size(690, 70)
        Me.txtCopyright.TabIndex = 7
        Me.txtCopyright.Text = "Copyright Rincon Consulting,  2012. All Rights Reserved. No parts of this applica" & _
    "tion may be reverse engineered or used in any form without permission from Rinco" & _
    "n Consulting."
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(22.0!, 43.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtCopyright)
        Me.Controls.Add(Me.txtLaw)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pctRincon)
        Me.Controls.Add(Me.lblSplash)
        Me.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctRincon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSplash As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pctRincon As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtLaw As System.Windows.Forms.TextBox
    Friend WithEvents txtCopyright As System.Windows.Forms.TextBox

End Class
