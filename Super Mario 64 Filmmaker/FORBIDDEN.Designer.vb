﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FORBIDDEN
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
        Me.sinLB = New System.Windows.Forms.Label()
        Me.Close64FM = New System.Windows.Forms.Button()
        Me.sinBTN = New System.Windows.Forms.Button()
        Me.Restart64FM = New System.Windows.Forms.Button()
        Me.sinPB = New System.Windows.Forms.PictureBox()
        CType(Me.sinPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sinLB
        '
        Me.sinLB.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sinLB.Location = New System.Drawing.Point(12, 148)
        Me.sinLB.Name = "sinLB"
        Me.sinLB.Size = New System.Drawing.Size(532, 58)
        Me.sinLB.TabIndex = 1
        Me.sinLB.Text = "64FM 'sss nothing fur you."
        Me.sinLB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Close64FM
        '
        Me.Close64FM.Location = New System.Drawing.Point(448, 209)
        Me.Close64FM.Name = "Close64FM"
        Me.Close64FM.Size = New System.Drawing.Size(97, 30)
        Me.Close64FM.TabIndex = 2
        Me.Close64FM.Text = "Close 64FM"
        Me.Close64FM.UseVisualStyleBackColor = True
        '
        'sinBTN
        '
        Me.sinBTN.Enabled = False
        Me.sinBTN.Location = New System.Drawing.Point(116, 209)
        Me.sinBTN.Name = "sinBTN"
        Me.sinBTN.Size = New System.Drawing.Size(326, 30)
        Me.sinBTN.TabIndex = 2
        Me.sinBTN.Text = "Take the program seriously (Enable use of this BETA version.)"
        Me.sinBTN.UseVisualStyleBackColor = True
        '
        'Restart64FM
        '
        Me.Restart64FM.Location = New System.Drawing.Point(13, 209)
        Me.Restart64FM.Name = "Restart64FM"
        Me.Restart64FM.Size = New System.Drawing.Size(97, 30)
        Me.Restart64FM.TabIndex = 2
        Me.Restart64FM.Text = "Restart 64FM"
        Me.Restart64FM.UseVisualStyleBackColor = True
        '
        'sinPB
        '
        Me.sinPB.Image = Global.Filmmaker.My.Resources.Resources.zenonbye
        Me.sinPB.Location = New System.Drawing.Point(188, 21)
        Me.sinPB.Name = "sinPB"
        Me.sinPB.Size = New System.Drawing.Size(177, 124)
        Me.sinPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.sinPB.TabIndex = 0
        Me.sinPB.TabStop = False
        '
        'FORBIDDEN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 253)
        Me.ControlBox = False
        Me.Controls.Add(Me.Restart64FM)
        Me.Controls.Add(Me.sinBTN)
        Me.Controls.Add(Me.Close64FM)
        Me.Controls.Add(Me.sinLB)
        Me.Controls.Add(Me.sinPB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FORBIDDEN"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FORBIDDEN / 403 / ACCESS DENIED / BANEADO / DENEGADO"
        CType(Me.sinPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents sinPB As PictureBox
    Friend WithEvents sinLB As Label
    Friend WithEvents Close64FM As Button
    Friend WithEvents sinBTN As Button
    Friend WithEvents Restart64FM As Button
End Class
