Option Strict On
Imports System.Globalization

''' <summary>
''' Form for serial communication settings
''' </summary>
Public Class FormSerialSettings

    ''' <summary>
    ''' Clear and reset all fields for communication setting
    ''' </summary>
    Private Sub FormSerialSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Clear Baudrate ComboBox
        cboxBaudRate.Items.Clear()
        cboxBaudRate.Items.Add("300")
        cboxBaudRate.Items.Add("600")
        cboxBaudRate.Items.Add("1200")
        cboxBaudRate.Items.Add("2400")
        cboxBaudRate.Items.Add("4800")
        cboxBaudRate.Items.Add("9600")
        cboxBaudRate.Items.Add("19200")
        cboxBaudRate.Items.Add("38400")
        cboxBaudRate.Items.Add("57600")
        cboxBaudRate.Items.Add("115200")
        cboxBaudRate.Items.Add("230400")
        cboxBaudRate.Items.Add("460800")
        cboxBaudRate.Items.Add("921600")
        cboxBaudRate.SelectedItem = FormMain.SerialComm.BaudRate.ToString("G", CultureInfo.CurrentCulture)

        ' Clear StopBits
        cboxStopBits.Items.Clear()
        cboxStopBits.Items.Add("None")
        cboxStopBits.Items.Add("One")
        cboxStopBits.Items.Add("Two")
        cboxStopBits.Items.Add("OnePointFive")
        cboxStopBits.SelectedItem = FormMain.SerialComm.StopBits.ToString

        ' Clear DataBits
        cboxDataBits.Items.Clear()
        cboxDataBits.Items.Add(7)
        cboxDataBits.Items.Add(8)
        cboxDataBits.SelectedItem = FormMain.SerialComm.DataBits

        ' Clear Parity
        cboxParity.Items.Clear()
        cboxParity.Items.Add("None")
        cboxParity.Items.Add("Odd")
        cboxParity.Items.Add("Even")
        cboxParity.Items.Add("Mark")
        cboxParity.Items.Add("Space")
        cboxParity.SelectedItem = FormMain.SerialComm.Parity.ToString

        ' Clear RTS
        cboxRTS.Checked = FormMain.SerialComm.RtsEnable

    End Sub

    ''' <summary>
    ''' Close this form without change settings
    ''' </summary>
    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles btCancel.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Apply settings to the FormMain SerialPort
    ''' </summary>
    Private Sub BtApply_Click(sender As Object, e As EventArgs) Handles btApply.Click

        ' Apply Baudrate
        FormMain.SerialComm.BaudRate = CInt(cboxBaudRate.SelectedItem)

        ' Apply StopBits
        FormMain.SerialComm.StopBits = CType(CInt(cboxStopBits.SelectedIndex), IO.Ports.StopBits)

        ' Apply DataBits
        FormMain.SerialComm.DataBits = CInt(cboxDataBits.SelectedItem)

        ' Apply Parity
        FormMain.SerialComm.Parity = CType(cboxParity.SelectedIndex, IO.Ports.Parity)

        ' Apply RTS
        FormMain.SerialComm.RtsEnable = cboxRTS.Checked

        ' Close this form
        Me.Close()
    End Sub
End Class