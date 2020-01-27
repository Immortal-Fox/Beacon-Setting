<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLightProfils
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
        Me.labLightProfils = New System.Windows.Forms.Label()
        Me.panelLightProfils = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'labLightProfils
        '
        Me.labLightProfils.BackColor = System.Drawing.Color.DimGray
        Me.labLightProfils.Dock = System.Windows.Forms.DockStyle.Top
        Me.labLightProfils.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLightProfils.ForeColor = System.Drawing.Color.White
        Me.labLightProfils.Location = New System.Drawing.Point(0, 0)
        Me.labLightProfils.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labLightProfils.Name = "labLightProfils"
        Me.labLightProfils.Size = New System.Drawing.Size(145, 20)
        Me.labLightProfils.TabIndex = 1
        Me.labLightProfils.Text = "Light profils"
        Me.labLightProfils.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panelLightProfils
        '
        Me.panelLightProfils.AutoScroll = True
        Me.panelLightProfils.BackColor = System.Drawing.Color.Silver
        Me.panelLightProfils.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelLightProfils.Location = New System.Drawing.Point(0, 20)
        Me.panelLightProfils.Name = "panelLightProfils"
        Me.panelLightProfils.Size = New System.Drawing.Size(145, 341)
        Me.panelLightProfils.TabIndex = 2
        '
        'FormLightProfils
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(145, 361)
        Me.Controls.Add(Me.panelLightProfils)
        Me.Controls.Add(Me.labLightProfils)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormLightProfils"
        Me.Text = "FormLightProfils"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents labLightProfils As Label
    Friend WithEvents panelLightProfils As FlowLayoutPanel
End Class
