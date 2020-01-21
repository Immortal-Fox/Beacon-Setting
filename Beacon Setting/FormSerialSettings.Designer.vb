<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSerialSettings
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
        Me.labBaudRate = New System.Windows.Forms.Label()
        Me.cboxBaudRate = New System.Windows.Forms.ComboBox()
        Me.labStopBits = New System.Windows.Forms.Label()
        Me.cboxStopBits = New System.Windows.Forms.ComboBox()
        Me.labDataBits = New System.Windows.Forms.Label()
        Me.cboxDataBits = New System.Windows.Forms.ComboBox()
        Me.cboxParity = New System.Windows.Forms.ComboBox()
        Me.labParity = New System.Windows.Forms.Label()
        Me.btApply = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.cboxRTS = New System.Windows.Forms.CheckBox()
        Me.cboxDTR = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'labBaudRate
        '
        Me.labBaudRate.AutoSize = True
        Me.labBaudRate.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labBaudRate.Location = New System.Drawing.Point(16, 21)
        Me.labBaudRate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labBaudRate.Name = "labBaudRate"
        Me.labBaudRate.Size = New System.Drawing.Size(63, 14)
        Me.labBaudRate.TabIndex = 6
        Me.labBaudRate.Text = "BaudRate"
        '
        'cboxBaudRate
        '
        Me.cboxBaudRate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboxBaudRate.DropDownHeight = 170
        Me.cboxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboxBaudRate.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxBaudRate.FormattingEnabled = True
        Me.cboxBaudRate.IntegralHeight = False
        Me.cboxBaudRate.ItemHeight = 13
        Me.cboxBaudRate.Location = New System.Drawing.Point(90, 19)
        Me.cboxBaudRate.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxBaudRate.Name = "cboxBaudRate"
        Me.cboxBaudRate.Size = New System.Drawing.Size(102, 21)
        Me.cboxBaudRate.TabIndex = 11
        '
        'labStopBits
        '
        Me.labStopBits.AutoSize = True
        Me.labStopBits.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labStopBits.Location = New System.Drawing.Point(16, 56)
        Me.labStopBits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labStopBits.Name = "labStopBits"
        Me.labStopBits.Size = New System.Drawing.Size(63, 14)
        Me.labStopBits.TabIndex = 12
        Me.labStopBits.Text = "StopBits"
        '
        'cboxStopBits
        '
        Me.cboxStopBits.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboxStopBits.DropDownHeight = 170
        Me.cboxStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxStopBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboxStopBits.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxStopBits.FormattingEnabled = True
        Me.cboxStopBits.IntegralHeight = False
        Me.cboxStopBits.ItemHeight = 13
        Me.cboxStopBits.Location = New System.Drawing.Point(90, 54)
        Me.cboxStopBits.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxStopBits.Name = "cboxStopBits"
        Me.cboxStopBits.Size = New System.Drawing.Size(102, 21)
        Me.cboxStopBits.TabIndex = 13
        '
        'labDataBits
        '
        Me.labDataBits.AutoSize = True
        Me.labDataBits.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labDataBits.Location = New System.Drawing.Point(16, 91)
        Me.labDataBits.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labDataBits.Name = "labDataBits"
        Me.labDataBits.Size = New System.Drawing.Size(63, 14)
        Me.labDataBits.TabIndex = 14
        Me.labDataBits.Text = "DataBits"
        '
        'cboxDataBits
        '
        Me.cboxDataBits.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboxDataBits.DropDownHeight = 170
        Me.cboxDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxDataBits.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboxDataBits.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxDataBits.FormattingEnabled = True
        Me.cboxDataBits.IntegralHeight = False
        Me.cboxDataBits.ItemHeight = 13
        Me.cboxDataBits.Location = New System.Drawing.Point(90, 89)
        Me.cboxDataBits.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxDataBits.Name = "cboxDataBits"
        Me.cboxDataBits.Size = New System.Drawing.Size(102, 21)
        Me.cboxDataBits.TabIndex = 15
        '
        'cboxParity
        '
        Me.cboxParity.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboxParity.DropDownHeight = 170
        Me.cboxParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxParity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboxParity.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxParity.FormattingEnabled = True
        Me.cboxParity.IntegralHeight = False
        Me.cboxParity.ItemHeight = 13
        Me.cboxParity.Location = New System.Drawing.Point(90, 124)
        Me.cboxParity.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxParity.Name = "cboxParity"
        Me.cboxParity.Size = New System.Drawing.Size(102, 21)
        Me.cboxParity.TabIndex = 17
        '
        'labParity
        '
        Me.labParity.AutoSize = True
        Me.labParity.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labParity.Location = New System.Drawing.Point(16, 126)
        Me.labParity.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labParity.Name = "labParity"
        Me.labParity.Size = New System.Drawing.Size(49, 14)
        Me.labParity.TabIndex = 16
        Me.labParity.Text = "Parity"
        '
        'btApply
        '
        Me.btApply.BackColor = System.Drawing.Color.MidnightBlue
        Me.btApply.FlatAppearance.BorderSize = 0
        Me.btApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btApply.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btApply.ForeColor = System.Drawing.Color.White
        Me.btApply.Location = New System.Drawing.Point(116, 225)
        Me.btApply.Margin = New System.Windows.Forms.Padding(2)
        Me.btApply.Name = "btApply"
        Me.btApply.Size = New System.Drawing.Size(83, 26)
        Me.btApply.TabIndex = 18
        Me.btApply.Text = "Apply"
        Me.btApply.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.MidnightBlue
        Me.btCancel.FlatAppearance.BorderSize = 0
        Me.btCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCancel.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.ForeColor = System.Drawing.Color.White
        Me.btCancel.Location = New System.Drawing.Point(14, 225)
        Me.btCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(83, 26)
        Me.btCancel.TabIndex = 19
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'cboxRTS
        '
        Me.cboxRTS.AutoSize = True
        Me.cboxRTS.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxRTS.Location = New System.Drawing.Point(18, 160)
        Me.cboxRTS.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxRTS.Name = "cboxRTS"
        Me.cboxRTS.Size = New System.Drawing.Size(173, 18)
        Me.cboxRTS.TabIndex = 20
        Me.cboxRTS.Text = "Request to Send (RTS)"
        Me.cboxRTS.UseVisualStyleBackColor = True
        '
        'cboxDTR
        '
        Me.cboxDTR.AutoSize = True
        Me.cboxDTR.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxDTR.Location = New System.Drawing.Point(18, 189)
        Me.cboxDTR.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxDTR.Name = "cboxDTR"
        Me.cboxDTR.Size = New System.Drawing.Size(159, 18)
        Me.cboxDTR.TabIndex = 21
        Me.cboxDTR.Text = "Data Terminal Ready"
        Me.cboxDTR.UseVisualStyleBackColor = True
        '
        'FormSerialSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(211, 266)
        Me.Controls.Add(Me.cboxDTR)
        Me.Controls.Add(Me.cboxRTS)
        Me.Controls.Add(Me.btCancel)
        Me.Controls.Add(Me.btApply)
        Me.Controls.Add(Me.cboxParity)
        Me.Controls.Add(Me.labParity)
        Me.Controls.Add(Me.cboxDataBits)
        Me.Controls.Add(Me.labDataBits)
        Me.Controls.Add(Me.cboxStopBits)
        Me.Controls.Add(Me.labStopBits)
        Me.Controls.Add(Me.cboxBaudRate)
        Me.Controls.Add(Me.labBaudRate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormSerialSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Serial Configuration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents labBaudRate As Label
    Friend WithEvents cboxBaudRate As ComboBox
    Friend WithEvents labStopBits As Label
    Friend WithEvents cboxStopBits As ComboBox
    Friend WithEvents labDataBits As Label
    Friend WithEvents cboxDataBits As ComboBox
    Friend WithEvents cboxParity As ComboBox
    Friend WithEvents labParity As Label
    Friend WithEvents btApply As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents cboxRTS As CheckBox
    Friend WithEvents cboxDTR As CheckBox
End Class
