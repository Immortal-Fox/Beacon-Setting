<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSaveDevice
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.txtbDeviceName = New System.Windows.Forms.TextBox()
        Me.labDeviceName = New System.Windows.Forms.Label()
        Me.btUseDeviceEUI = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.Color.Navy
        Me.btSave.FlatAppearance.BorderSize = 0
        Me.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSave.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.ForeColor = System.Drawing.Color.White
        Me.btSave.Location = New System.Drawing.Point(175, 114)
        Me.btSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(81, 31)
        Me.btSave.TabIndex = 10
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.Navy
        Me.btCancel.FlatAppearance.BorderSize = 0
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.ForeColor = System.Drawing.Color.White
        Me.btCancel.Location = New System.Drawing.Point(11, 114)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(81, 31)
        Me.btCancel.TabIndex = 11
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'txtbDeviceName
        '
        Me.txtbDeviceName.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbDeviceName.Location = New System.Drawing.Point(11, 37)
        Me.txtbDeviceName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbDeviceName.Name = "txtbDeviceName"
        Me.txtbDeviceName.Size = New System.Drawing.Size(245, 22)
        Me.txtbDeviceName.TabIndex = 12
        Me.txtbDeviceName.Text = "Device0"
        '
        'labDeviceName
        '
        Me.labDeviceName.AutoSize = True
        Me.labDeviceName.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDeviceName.Location = New System.Drawing.Point(10, 12)
        Me.labDeviceName.Name = "labDeviceName"
        Me.labDeviceName.Size = New System.Drawing.Size(84, 14)
        Me.labDeviceName.TabIndex = 13
        Me.labDeviceName.Text = "Device name"
        '
        'btUseDeviceEUI
        '
        Me.btUseDeviceEUI.BackColor = System.Drawing.Color.Navy
        Me.btUseDeviceEUI.FlatAppearance.BorderSize = 0
        Me.btUseDeviceEUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btUseDeviceEUI.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUseDeviceEUI.ForeColor = System.Drawing.Color.White
        Me.btUseDeviceEUI.Location = New System.Drawing.Point(11, 66)
        Me.btUseDeviceEUI.Margin = New System.Windows.Forms.Padding(2)
        Me.btUseDeviceEUI.Name = "btUseDeviceEUI"
        Me.btUseDeviceEUI.Size = New System.Drawing.Size(136, 25)
        Me.btUseDeviceEUI.TabIndex = 14
        Me.btUseDeviceEUI.Text = "Use Device EUI"
        Me.btUseDeviceEUI.UseVisualStyleBackColor = False
        '
        'FormSaveDevice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(272, 156)
        Me.Controls.Add(Me.btUseDeviceEUI)
        Me.Controls.Add(Me.labDeviceName)
        Me.Controls.Add(Me.txtbDeviceName)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormSaveDevice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Save your device settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btSave As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents txtbDeviceName As TextBox
    Friend WithEvents labDeviceName As Label
    Friend WithEvents btUseDeviceEUI As Button
End Class
