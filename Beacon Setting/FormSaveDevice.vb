Option Strict On

''' <summary>
''' Form for saving device settings
''' </summary>
Public Class FormSaveDevice
    ''' <summary>
    ''' Close this form without change
    ''' </summary>
    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    Private Sub BtUseDeviceEUI_Click(sender As Object, e As EventArgs) Handles btUseDeviceEUI.Click
        txtbDeviceName.Text = FormMain.txtbEUI.Text
    End Sub

End Class