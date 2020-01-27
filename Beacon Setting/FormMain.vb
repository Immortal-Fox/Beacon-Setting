Option Explicit On
Option Strict On
' Auteur :      Charmillot Ludovic
'
' Software for smart beacon's settings
'
' Version 1

' Libs import
Imports System.ComponentModel
Imports System.Globalization
' IO Lib
Imports System.IO
Imports System.IO.Ports
' Text Lib
Imports System.Text
Imports System.Text.RegularExpressions
' Json Lib
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

''' <summary>
''' Main form
''' </summary>
Public Class FormMain
    ''' <summary>
    ''' Name of the program
    ''' </summary>
    Private ReadOnly programName As String = "Beacon's Settings"
    ''' <summary>
    ''' current version
    ''' </summary>
    Private ReadOnly version As String = "0.2"

    ''' <summary>
    ''' Selected beacon for settings
    ''' </summary>
    Private selectedBeacon As Button

    ' Default color for beacons
    Private ReadOnly colorGreen As Color = Color.GreenYellow    ' Green
    Private ReadOnly colorOrange As Color = Color.Orange        ' Orange
    Private ReadOnly colorRed As Color = Color.Red              ' Red
    Private ReadOnly colorBlue As Color = Color.Blue            ' Blue
    Private ReadOnly colorWhite As Color = Color.White          ' White

    ' Images for windows forms design
    Private ReadOnly imageConnected As Image = My.Resources.connected
    Private ReadOnly imageDisconnected As Image = My.Resources.disconnected

    ' URL
    Private Const URL_GITHUB As String = "https://github.com/Immortal-Fox/Beacon-Setting"

    ' String constants for Json building
    Private Const JSN_TYPE As String = "Type"
    Private Const JSN_TYPE_LIGHTS As String = "LIGHTS"
    Private Const JSN_TYPE_LORA As String = "LORA"
    Private Const JSN_INFOS As String = "Infos"
    Private Const JSN_DEVEUI As String = "DevEUI"
    Private Const JSN_APPKEY As String = "AppKey"
    Private Const JSN_APPEUI As String = "AppEUI"
    Private Const JSN_COLOR As String = "Color"
    Private Const JSN_COLOR_GREEN As String = "Green"
    Private Const JSN_COLOR_RED As String = "Red"
    Private Const JSN_COLOR_ORANGE As String = "Orange"
    Private Const JSN_COLOR_BLUE As String = "Blue"
    Private Const JSN_COLOR_WHITE As String = "White"
    Private Const JSN_POSITION As String = "Position"

    ' Const for cache parameters
    Private Const PRM_DEVICE_EUI As String = "param_eui"
    Private Const PRM_APPKEY As String = "param_appkey"
    Private Const PRM_APPEUI As String = "param_appeui"
    Private Const PRM_NBRBEACONS As String = "param_nbrbeacons"
    Private Const PRM_COLORBEACON1 As String = "param_colorbeacon1"
    Private Const PRM_COLORBEACON2 As String = "param_colorbeacon2"
    Private Const PRM_COLORBEACON3 As String = "param_colorbeacon3"
    Private Const PRM_COLORBEACON4 As String = "param_colorbeacon4"
    Private Const PRM_COLORBEACON5 As String = "param_colorbeacon5"
    Private Const PRM_SELECTEDCOM As String = "param_selectedcom"

    ' Const for string ressources
    Private Const STR_CONNECTED As String = "Connected"
    Private Const STR_DISCONNECTED As String = "Disconnected"
    Private Const STR_NOTCONNECTED As String = "Not connected..."
    Private Const STR_SENDING As String = "Sending : "
    Private Const STR_RECEIVING As String = "Receiving : "
    Private Const STR_BTLIGHTPROFIL1 As String = "Light profils >"
    Private Const STR_BTLIGHTPROFIL2 As String = "Light profils <"

    ' Success messages
    Private Const SUC_SENDINGOK As String = "Sending data success"

    ' Const for error message
    Private Const ERR_NOTCONNECTED As String = "Error : Not connected to serial port..."
    Private Const ERR_DISCONNECTED As String = "Error : Disconnected..."
    Private Const ERR_BEACONSCOLOR As String = "Error : No more than one different color per beacon or check if all beacons have a color..."
    Private Const ERR_INCORRECTAPPKEY As String = "Error : Incorrect AppKey..."
    Private Const ERR_INCORRECTAPPEUI As String = "Error : Incorrect AppEUI..."
    Private Const ERR_LOADCACHE As String = "Error : While loading cache parameters..."
    Private Const ERR_WRITECACHE As String = "Error : While writting cache parameters..."
    Private Const ERR_OPENCOMMUNICATION As String = "Error : While opening serial communication port..."
    Private Const ERR_CLOSECOMMUNICATION As String = "Error : While closing serial communication port..."
    Private Const ERR_WRITELORAWAN As String = "Error : While writting LoRaWAN settings..."
    Private Const ERR_WRITELIGHTS As String = "Error : While writting lights settings..."
    Private Const ERR_NOMATCHINGDATA As String = "Error : While writting data on the device"
    Private Const ERR_JSONKEYMISSING As String = "Error : Json key property missing"
    Private Const ERR_RECEIVINGDEVICEINFO As String = "Error : while receiving device information"
    Private Const ERR_NULLARGUMENT As String = "Error : Argument Null Exception"

    ' Regular Expressions for validating fields
    Private Const REG_DEVICEEUI As String = "^([a-fA-F0-9]{16})$"    ' Validate HEX 32 Bytes (8 chars)
    Private Const REG_APPKEY As String = "^([a-fA-F0-9]{32})$"      ' Validate HEX 64 Bytes (16 chars)
    Private Const REG_APPEUI As String = "^([a-fA-F0-9]{16})$"       ' Validate HEX 32 Bytes (8 chars)

    ' Color for Fields validation
    Private ReadOnly colorOk As Color = Color.GreenYellow
    Private ReadOnly colorError As Color = Color.IndianRed

    ' Directories's path
    Private dirAppData As String          ' AppData
    Private dirAppDataRoot As String      ' AppData/"ProgramName"
    Private dirSavedDevices As String     ' AppData/"ProgramName"/Saved Devices
    Private dirCache As String            ' AppData/"ProgramName"/Cache
    '    Private dirLightsProfils As String    ' AppData/"ProgramName"/Lights Profils

    ' Cache file manager
    Private parameterFile As ParameterFileReader

    ' Serial variables
    Private isWaitingResponseFromDevice As Boolean = False
    Private lastSendingString As String

    ' Events of the MainFrom
#Region "Form Events"

    ''' <summary>
    ''' First instructions of the program
    ''' </summary>
    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Show name and version
        Me.Text = programName & " v" & version
        Me.Size = New Size(500, 400)

        'Default config for Serial comm
        SerialComm.BaudRate = 115200

        ' Ordering Panel
        panelHardware.Dock = DockStyle.Fill
        panelSerial.Dock = DockStyle.Fill
        panelLoraWAN.Dock = DockStyle.Fill
        panelAbout.Dock = DockStyle.Fill

        ' bt communication
        btMenuCommunication.BackColor = Color.DarkGray

        ' Setting Directories's path
        dirAppData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        dirAppDataRoot = dirAppData & "/" & programName
        dirSavedDevices = dirAppDataRoot & "/Saved Devices"
        dirCache = dirAppDataRoot & "/Cache"

        ' Create directories if they didn't exist
        If Not Directory.Exists(dirAppDataRoot) Then
            Directory.CreateDirectory(dirAppDataRoot)
        End If
        If Not Directory.Exists(dirSavedDevices) Then
            Directory.CreateDirectory(dirSavedDevices)
        End If
        If Not Directory.Exists(dirCache) Then
            Directory.CreateDirectory(dirCache)
        End If

        ' Get all available COM Ports on the computer
        cboxSerialPort.Items.Clear()
        For Each _sp As String In My.Computer.Ports.SerialPortNames
            cboxSerialPort.Items.Add(_sp)
            cboxSerialPort.SelectedIndex = 0
        Next

        btBeacon1.BackColor = colorWhite
        btBeacon2.BackColor = colorWhite
        btBeacon3.BackColor = colorWhite
        btBeacon4.BackColor = colorWhite
        btBeacon5.BackColor = colorWhite
        btBeacon1.FlatAppearance.BorderSize = 3
        selectedBeacon = btBeacon1
        cboxColor.SelectedIndex = 4
        BackColor = Color.FromArgb(255, 0, 0)
        TimerEffect.Start()

        ' Load parameters
        parameterFile = New ParameterFileReader()
        parameterFile.ReadFile(dirCache & "/cache.txt")

        LoadCache()
    End Sub

    ''' <summary>
    ''' Keydown event
    ''' </summary>
    Private Sub FormMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' serial command validation with CR key
        If e.KeyCode = Keys.Return Then
            If txtbSendMessage.Focused Then
                SendMessage(txtbSendMessage.Text)
                txtbSendMessage.Clear()
            End If
        End If
        ' Function keys to change menu and closing form
        Select Case e.KeyCode
            Case Keys.F1    ' Hardware settings
                btMenuHardware.PerformClick()
            Case Keys.F2    ' LoRaWAN settings
                btMenuLora.PerformClick()
            Case Keys.F3    ' Communication Setting
                btMenuCommunication.PerformClick()
            Case Keys.F4    ' About
                btMenuAbout.PerformClick()
            Case Keys.Escape ' Close application
                Me.Close()
        End Select
    End Sub

    ''' <summary>
    ''' When the program is closing
    ''' </summary>
    Private Sub FormMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' Stop the effect timer
        TimerEffect.Stop()

        ' if the communication is still opened
        If SerialComm.IsOpen Then
            ' Close this communication
            SerialComm.Close()
        End If

        ' Destroy the serialport object
        SerialComm.Dispose()

        ' Save cache
        SaveCache()

        ' Delete Image
        imageConnected.Dispose()
        imageDisconnected.Dispose()
    End Sub

    ''' <summary>
    ''' Change the location of the FormLightProfils
    ''' </summary>
    Private Sub FormMain_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        FormLightProfils.Location = New Point(Me.Location.X + Me.Size.Width - 7, Me.Location.Y + 31)
    End Sub

#End Region

    ' Group of functions for cache management
#Region "Cache functions"

    ''' <summary>
    ''' Load stored parameters in cache file
    ''' </summary>
    Public Sub LoadCache()
        Try
            ' LoRaWAN data
            txtbEUI.Text = CStr(parameterFile.GetParameter(PRM_DEVICE_EUI))
            txtbAppKey.Text = CStr(parameterFile.GetParameter(PRM_APPKEY))
            txtbAppEUI.Text = CStr(parameterFile.GetParameter(PRM_APPEUI))
            ' Number of beacons
            If CBool(parameterFile.Exist(PRM_NBRBEACONS)) Then
                Dim nbrBeacon As Integer = CInt(parameterFile.GetParameter(PRM_NBRBEACONS))
                If nbrBeacon > 0 And nbrBeacon <= 5 Then
                    numNbrBeacons.Value = nbrBeacon
                End If
            End If
            ' Beacon's color
            btBeacon1.BackColor = ColorTranslator.FromHtml(CStr(parameterFile.GetParameter(PRM_COLORBEACON1)))
            btBeacon2.BackColor = ColorTranslator.FromHtml(CStr(parameterFile.GetParameter(PRM_COLORBEACON2)))
            btBeacon3.BackColor = ColorTranslator.FromHtml(CStr(parameterFile.GetParameter(PRM_COLORBEACON3)))
            btBeacon4.BackColor = ColorTranslator.FromHtml(CStr(parameterFile.GetParameter(PRM_COLORBEACON4)))
            btBeacon5.BackColor = ColorTranslator.FromHtml(CStr(parameterFile.GetParameter(PRM_COLORBEACON5)))
            ' Selected COM port
            cboxSerialPort.SelectedItem = CStr(parameterFile.GetParameter(PRM_SELECTEDCOM))
        Catch ex As Exception
            MsgBox(ERR_LOADCACHE)
        End Try

    End Sub

    ''' <summary>
    ''' Save values of the form in the cache file
    ''' </summary>
    Public Sub SaveCache()
        Try
            parameterFile.ResetParameter()
            ' LoRaWAN data
            parameterFile.AddParameter(PRM_DEVICE_EUI, txtbEUI.Text)
            parameterFile.AddParameter(PRM_APPKEY, txtbAppKey.Text)
            parameterFile.AddParameter(PRM_APPEUI, txtbAppEUI.Text)
            ' Beacon's color
            parameterFile.AddParameter(PRM_NBRBEACONS, CStr(numNbrBeacons.Value))
            parameterFile.AddParameter(PRM_COLORBEACON1, ColorTranslator.ToHtml(btBeacon1.BackColor))
            parameterFile.AddParameter(PRM_COLORBEACON2, ColorTranslator.ToHtml(btBeacon2.BackColor))
            parameterFile.AddParameter(PRM_COLORBEACON3, ColorTranslator.ToHtml(btBeacon3.BackColor))
            parameterFile.AddParameter(PRM_COLORBEACON4, ColorTranslator.ToHtml(btBeacon4.BackColor))
            parameterFile.AddParameter(PRM_COLORBEACON5, ColorTranslator.ToHtml(btBeacon5.BackColor))
            If Not IsNothing(cboxSerialPort.SelectedItem) Then
                parameterFile.AddParameter(PRM_SELECTEDCOM, cboxSerialPort.SelectedItem.ToString)
            End If
            ' Write cache file
            parameterFile.WriteFile(dirCache & "/Cache.txt")
        Catch ex As Exception
            MsgBox(ERR_WRITECACHE)
        End Try
    End Sub

#End Region

    ' Group of functions for building and validating json
#Region "Json building and validating"

    ''' <summary>
    ''' Build Json string for LoRaWAN configuration
    ''' </summary>
    ''' <returns>Json string to send</returns>
    Private Function JsonBuilderLoRa() As String
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)

        Using writer = New JsonTextWriter(sw)
            writer.WriteStartObject()
            writer.WritePropertyName(JSN_TYPE)
            writer.WriteValue(JSN_TYPE_LORA)
            writer.WritePropertyName(JSN_INFOS)
            writer.WriteStartArray()
            writer.WriteStartObject()
            writer.WritePropertyName(JSN_DEVEUI)
            writer.WriteValue(txtbEUI.Text)
            writer.WritePropertyName(JSN_APPKEY)
            writer.WriteValue(txtbAppKey.Text)
            writer.WritePropertyName(JSN_APPEUI)
            writer.WriteValue(txtbAppEUI.Text)
            writer.WriteEndObject()
            writer.WriteEnd()
            writer.WriteEndObject()
        End Using

        Return sb.ToString

    End Function

    ''' <summary>
    ''' Build Json string for Lights configuration
    ''' </summary>
    ''' <returns>Json string to send through serial comm</returns>
    Private Function JsonBuilderLights() As String
        Dim sb As New StringBuilder
        Dim sw As New StringWriter(sb)

        Using writer = New JsonTextWriter(sw)
            writer.WriteStartObject()
            writer.WritePropertyName(JSN_TYPE)
            writer.WriteValue(JSN_TYPE_LIGHTS)
            writer.WritePropertyName(JSN_INFOS)
            writer.WriteStartArray()
            ' Beacon on position 1
            writer.WriteStartObject()
            writer.WritePropertyName(JSN_COLOR)
            writer.WriteValue(GetStringColor(btBeacon1))
            writer.WritePropertyName(JSN_POSITION)
            writer.WriteValue(1)
            writer.WriteEndObject()
            ' Beacon on position 2
            If numNbrBeacons.Value > 1 Then
                writer.WriteStartObject()
                writer.WritePropertyName(JSN_COLOR)
                writer.WriteValue(GetStringColor(btBeacon2))
                writer.WritePropertyName(JSN_POSITION)
                writer.WriteValue(2)
                writer.WriteEndObject()
            End If
            ' Beacon on position 3
            If numNbrBeacons.Value > 2 Then
                writer.WriteStartObject()
                writer.WritePropertyName(JSN_COLOR)
                writer.WriteValue(GetStringColor(btBeacon3))
                writer.WritePropertyName(JSN_POSITION)
                writer.WriteValue(3)
                writer.WriteEndObject()
            End If
            ' Beacon on position 4
            If numNbrBeacons.Value > 3 Then
                writer.WriteStartObject()
                writer.WritePropertyName(JSN_COLOR)
                writer.WriteValue(GetStringColor(btBeacon4))
                writer.WritePropertyName(JSN_POSITION)
                writer.WriteValue(4)
                writer.WriteEndObject()
            End If
            ' Beacon on position 5
            If numNbrBeacons.Value > 4 Then
                writer.WriteStartObject()
                writer.WritePropertyName(JSN_COLOR)
                writer.WriteValue(GetStringColor(btBeacon5))
                writer.WritePropertyName(JSN_POSITION)
                writer.WriteValue(5)
                writer.WriteEndObject()
            End If
            writer.WriteEnd()
            writer.WriteEndObject()
        End Using

        Return sb.ToString
    End Function

    ''' <summary>
    ''' Get string color from button.backcolor
    ''' </summary>
    ''' <param name="_bt">Button for beacon settings</param>
    ''' <returns>String color for json string</returns>
    Private Function GetStringColor(ByVal _bt As Button) As String
        If _bt.BackColor = colorRed Then
            Return JSN_COLOR_RED
        ElseIf _bt.BackColor = colorBlue Then
            Return JSN_COLOR_BLUE
        ElseIf _bt.BackColor = colorOrange Then
            Return JSN_COLOR_ORANGE
        ElseIf _bt.BackColor = colorGreen Then
            Return JSN_COLOR_GREEN
        ElseIf _bt.BackColor = colorWhite Then
            Return JSN_COLOR_WHITE
        End If
        Return Nothing
    End Function

    ''' <summary>
    ''' Check if it's a valide Json raw string
    ''' </summary>
    ''' <param name="_rawJson">Raw json string</param>
    ''' <returns></returns>
    Private Function IsValideJson(ByVal _rawJson As String) As Boolean
        Try
            JObject.Parse(_rawJson)
        Catch ex As JsonReaderException
            Return False
        End Try
        Return True
    End Function

#End Region

    ' Group of functions for the serial port communication
#Region "Serial Communication Interactions"

    Delegate Sub DWriteResponse(ByVal response As String)
    ''' <summary>
    ''' Delegate method for serialcomm thread
    ''' Write log in the serial console
    ''' </summary>
    ''' <param name="response">Response to write</param>
    Public Sub WriteResponse(ByVal response As String)
        listMessages.Items.Add(response)
    End Sub

    ''' <summary> 
    ''' Send data through serial communication
    ''' </summary>
    ''' <param name="message">message data</param>
    Public Sub SendMessage(ByVal message As String)
        If SerialComm.IsOpen Then
            lastSendingString = message
            SerialComm.WriteLine(message)
            listMessages.Items.Add(STR_SENDING & " : " & message)
            Debug.Print(message)
        Else
            listMessages.Items.Add(STR_NOTCONNECTED)
        End If
    End Sub

    ''' <summary>
    ''' On data receive
    ''' </summary>
    Private Sub SerialComm_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialComm.DataReceived
        Try
            ' Read serial buffer
            Dim readedLine As String = SerialComm.ReadLine()

            ' If we don't wait for a response from the device after a writting operation
            If Not isWaitingResponseFromDevice Then

                ' If it's a valide json raw string
                If IsValideJson(readedLine) Then

                    ' First we have to parse the raw json string
                    Dim parsedJson As JObject = JObject.Parse(readedLine)

                    ' If this json contain a "Type" key
                    If parsedJson.ContainsKey(JSN_TYPE) Then

                        ' IF it's a Json for LoRa Hardware
                        If parsedJson.GetValue(JSN_TYPE, StringComparison.CurrentCulture).ToString = JSN_TYPE_LORA Then

                            Dim data As List(Of JToken) = parsedJson.Children().ToList

                            For Each item As JProperty In data
                                item.CreateReader()
                                Select Case item.Name
                                    Case JSN_INFOS
                                        For Each msg As JObject In item.Values
                                            If msg.ContainsKey(JSN_DEVEUI) Then txtbEUI.Text = msg(JSN_DEVEUI).ToString Else MsgBox(ERR_JSONKEYMISSING & " : " & JSN_DEVEUI)
                                            If msg.ContainsKey(JSN_APPKEY) Then txtbAppKey.Text = msg(JSN_APPKEY).ToString Else MsgBox(ERR_JSONKEYMISSING & " : " & JSN_APPKEY)
                                            If msg.ContainsKey(JSN_APPEUI) Then txtbAppEUI.Text = msg(JSN_APPEUI).ToString Else MsgBox(ERR_JSONKEYMISSING & " : " & JSN_APPEUI)
                                        Next
                                End Select
                            Next

                            ' if it's a json for lights settings
                        ElseIf parsedJson.GetValue(JSN_TYPE, StringComparison.CurrentCulture).ToString = JSN_TYPE_LIGHTS Then

                            Dim data As List(Of JToken) = parsedJson.Children().ToList
                            ' Make beacon's button invisible
                            btBeacon2.Visible = False
                            btBeacon3.Visible = False
                            btBeacon4.Visible = False
                            btBeacon5.Visible = False

                            For Each item As JProperty In data
                                item.CreateReader()
                                Select Case item.Name
                                    Case JSN_INFOS ' "Infos"
                                        For Each msg As JObject In item.Values
                                            If msg.ContainsKey(JSN_COLOR) And msg.ContainsKey(JSN_POSITION) Then
                                                Select Case CDbl(msg(JSN_POSITION)) ' "Position"
                                                    Case 1  ' Position 1
                                                        btBeacon1.BackColor = GetBeaconColorJSON(msg(JSN_COLOR).ToString)
                                                    Case 2  ' Position 2
                                                        btBeacon2.BackColor = GetBeaconColorJSON(msg(JSN_COLOR).ToString)
                                                        btBeacon2.Visible = True
                                                    Case 3  ' Position 3
                                                        btBeacon3.BackColor = GetBeaconColorJSON(msg(JSN_COLOR).ToString)
                                                        btBeacon3.Visible = True
                                                    Case 4  ' Position 4
                                                        btBeacon4.BackColor = GetBeaconColorJSON(msg(JSN_COLOR).ToString)
                                                        btBeacon4.Visible = True
                                                    Case 5  ' Position 5
                                                        btBeacon5.BackColor = GetBeaconColorJSON(msg(JSN_COLOR).ToString)
                                                        btBeacon5.Visible = True
                                                End Select
                                            End If
                                        Next
                                End Select
                            Next
                        End If
                    End If
                End If
            Else
                Debug.Print(readedLine)
                If lastSendingString & vbCr = readedLine Then
                    MsgBox(SUC_SENDINGOK)
                Else
                    MsgBox(ERR_NOMATCHINGDATA)
                End If
                ' Clear variables
                isWaitingResponseFromDevice = False
                lastSendingString = Nothing
            End If

            ' Print the received message in the serial console
            Me.Invoke(New DWriteResponse(AddressOf Me.WriteResponse), STR_RECEIVING & readedLine)
        Catch ex As TimeoutException
            MsgBox(ERR_RECEIVINGDEVICEINFO)
        Catch ex As InvalidOperationException
            MsgBox(ERR_RECEIVINGDEVICEINFO)
        Catch ex As JsonReaderException
            MsgBox(ERR_RECEIVINGDEVICEINFO)
        Catch ex As ArgumentNullException
            MsgBox(ERR_RECEIVINGDEVICEINFO)
        End Try
    End Sub

    ''' <summary>
    ''' Try to write device information on the device through the COM Port
    ''' </summary>
    Private Sub BtWrite_Click(sender As Object, e As EventArgs) Handles btWrite.Click
        Try
            If SerialComm.IsOpen Then

                ' AppKey

                If Not IsAppKey(txtbAppKey.Text) Then
                    txtbAppKey.BackColor = colorError
                    MsgBox(ERR_INCORRECTAPPKEY)
                    Exit Sub
                Else
                    txtbAppKey.BackColor = colorOk
                End If

                ' AppEUI

                If Not IsAppEUI(txtbAppEUI.Text) Then
                    txtbAppEUI.BackColor = colorError
                    MsgBox(ERR_INCORRECTAPPEUI)
                    Exit Sub
                Else
                    txtbAppEUI.BackColor = colorOk
                End If

                ' Send message through serial comm
                isWaitingResponseFromDevice = True

                SendMessage(JsonBuilderLoRa())
            Else
                MsgBox(ERR_NOTCONNECTED)
            End If
        Catch ex As ArgumentNullException
            MsgBox(ERR_NULLARGUMENT & " : " & ex.ToString)
        Catch ex As TimeoutException
            MsgBox(ERR_WRITELORAWAN)
        Catch ex As ArgumentException
            MsgBox(ERR_WRITELORAWAN)
        Catch ex As InvalidOperationException
            MsgBox(ERR_WRITELORAWAN)
        End Try
    End Sub

    ''' <summary>
    ''' Write lights configuration through serial communication in Json format
    ''' </summary>
    Private Sub BtHardwareWrite_Click(sender As Object, e As EventArgs) Handles btHardwareWrite.Click
        Try
            If CheckBeaconsSettings() Then
                If SerialComm.IsOpen Then
                    isWaitingResponseFromDevice = True
                    SendMessage(JsonBuilderLights())
                Else
                    MsgBox(ERR_NOTCONNECTED)
                End If
            Else
                MsgBox(ERR_BEACONSCOLOR)
            End If
        Catch ex As ArgumentNullException
            MsgBox(ERR_WRITELIGHTS & vbCrLf & System.Reflection.MethodBase.GetCurrentMethod().Name)
        Catch ex As ArgumentException
            MsgBox(ERR_WRITELIGHTS & vbCrLf & System.Reflection.MethodBase.GetCurrentMethod().Name)
        End Try
    End Sub

    ''' <summary>
    ''' Event called when there's an error with the serial communication
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SerialComm_ErrorReceived(sender As Object, e As SerialErrorReceivedEventArgs) Handles SerialComm.ErrorReceived
        MsgBox(ERR_DISCONNECTED)
    End Sub

#End Region

    ' Group of functions for the Communication's panel
#Region "Panel Communication Interactions"
    ''' <summary>
    ''' Open the serial port settings Form
    ''' </summary>
    Private Sub BtSerialConf_Click(sender As Object, e As EventArgs) Handles btSerialConf.Click
        FormSerialSettings.ShowDialog()
    End Sub

    ''' <summary>
    ''' Button to clear serial log
    ''' </summary>
    Private Sub BtClearMessages_Click(sender As Object, e As EventArgs) Handles btClearMessages.Click
        listMessages.Items.Clear()
    End Sub

    ''' <summary>
    ''' Event when double clicking on the listMessages
    ''' </summary>
    Private Sub ListMessages_DoubleClick(sender As Object, e As EventArgs) Handles listMessages.DoubleClick
        If Not IsNothing(listMessages.SelectedItem) Then
            MsgBox(listMessages.SelectedItem.ToString)
        End If
    End Sub

    ''' <summary>
    ''' Refresh the COM Port list
    ''' </summary>
    Private Sub BtRefresh_Click(sender As Object, e As EventArgs) Handles btRefresh.Click
        cboxSerialPort.Items.Clear()
        For Each _sp As String In My.Computer.Ports.SerialPortNames
            cboxSerialPort.Items.Add(_sp)
            cboxSerialPort.SelectedIndex = 0
        Next
    End Sub

    ''' <summary>
    ''' Try to open a serial communication
    ''' </summary>
    Private Sub BtConnexion_Click(sender As Object, e As EventArgs) Handles btConnexion.Click
        ' If communication isn't open
        If Not SerialComm.IsOpen Then
            Try
                ' Affect the selected COM Port
                If Not IsNothing(cboxSerialPort.SelectedItem) Then
                    SerialComm.PortName = cboxSerialPort.SelectedItem.ToString
                Else
                    MsgBox("You have to select one COM port !")
                    Exit Sub
                End If
                ' Try to open a new communication
                SerialComm.Open()

            Catch ex As ArgumentNullException
                MsgBox(ERR_OPENCOMMUNICATION)
                Exit Sub
            Catch ex As ArgumentOutOfRangeException
                MsgBox(ERR_OPENCOMMUNICATION)
                Exit Sub
            Catch ex As ArgumentException
                MsgBox(ERR_OPENCOMMUNICATION)
                Exit Sub
            Catch ex As InvalidOperationException
                MsgBox(ERR_OPENCOMMUNICATION)
                Exit Sub
            Catch ex As UnauthorizedAccessException
                MsgBox(ERR_OPENCOMMUNICATION)
                Exit Sub
            Catch ex As IOException
                MsgBox(ERR_OPENCOMMUNICATION)
                Exit Sub
            End Try

            ' If communication is open
            If SerialComm.IsOpen Then
                WriteResponse("Connected to " & SerialComm.PortName)
                labIsConnected.Text = STR_CONNECTED.ToString(CultureInfo.CurrentCulture)
                labIsConnected.ForeColor = Color.YellowGreen
                btConnexion.Text = STR_DISCONNECTED.ToString(CultureInfo.CurrentCulture)
                ' Modify buttons
                btSerialConf.Enabled = False
                btCopyDeviceEUI.Enabled = True
                btWrite.Enabled = True
                pboxConnected.Image = imageConnected
            End If

        Else ' If serial communication is open
            Try
                WriteResponse(STR_DISCONNECTED)
                SerialComm.Close()
                labIsConnected.Text = STR_DISCONNECTED.ToString(CultureInfo.CurrentCulture)
                labIsConnected.ForeColor = Color.Red
                btConnexion.Text = STR_CONNECTED.ToString(CultureInfo.CurrentCulture)
                pboxConnected.Image = imageDisconnected
                ' Modifiy buttons
                btSerialConf.Enabled = True
                btCopyDeviceEUI.Enabled = False
                btWrite.Enabled = False
            Catch ex As IOException
                MsgBox(ERR_CLOSECOMMUNICATION)
            End Try
        End If
    End Sub

#End Region

    ' Group of functions for the LoRaWAN settings's panel
#Region "Panel LoRaWAN Settings Interactions"

    ''' <summary>
    ''' Open the save device form
    ''' </summary>
    Private Sub BtSaveDevice_Click(sender As Object, e As EventArgs) Handles btSaveDevice.Click
        FormSaveDevice.ShowDialog()
    End Sub

    ''' <summary>
    ''' Copy the device EUI in the clipboard
    ''' </summary>
    Private Sub BtCopyDeviceEUI_Click(sender As Object, e As EventArgs) Handles btCopyDeviceEUI.Click
        Clipboard.SetText(txtbEUI.Text)
    End Sub

    ''' <summary>
    ''' Check string format of device eui when the text changed 
    ''' </summary>
    Private Sub TxtbEUI_TextChanged(sender As Object, e As EventArgs) Handles txtbEUI.TextChanged
        If Not IsDeviceEUI(txtbEUI.Text) Then
            txtbEUI.BackColor = colorError
            Exit Sub
        Else
            txtbEUI.BackColor = colorOk
        End If
    End Sub

    ''' <summary>
    ''' Check string format of Appkey when the text changed 
    ''' </summary>
    Private Sub TxtbAppKey_TextChanged(sender As Object, e As EventArgs) Handles txtbAppKey.TextChanged
        If Not IsAppKey(txtbAppKey.Text) Then
            txtbAppKey.BackColor = colorError
            Exit Sub
        Else
            txtbAppKey.BackColor = colorOk
        End If
    End Sub

    ''' <summary>
    ''' Check string format of App eui when the text changed 
    ''' </summary>
    Private Sub TxtbAppEUI_TextChanged(sender As Object, e As EventArgs) Handles txtbAppEUI.TextChanged
        If Not IsAppEUI(txtbAppEUI.Text) Then
            txtbAppEUI.BackColor = colorError
            Exit Sub
        Else
            txtbAppEUI.BackColor = colorOk
        End If
    End Sub

    ''' <summary>
    ''' Check if it's a correct Device EUI
    ''' Regex Operation
    ''' </summary>
    ''' <param name="text">Device EUI</param>
    ''' <returns></returns>
    Public Shared Function IsDeviceEUI(ByVal text As String) As Boolean
        Dim textControl As New Regex(REG_DEVICEEUI)
        Return textControl.IsMatch(text)
    End Function

    ''' <summary>
    ''' Check if it's a correct AppKey
    ''' Regex Operation
    ''' </summary>
    ''' <param name="text">AppKey</param>
    ''' <returns></returns>
    Public Shared Function IsAppKey(ByVal text As String) As Boolean
        Dim textControl As New Regex(REG_APPKEY)
        Return textControl.IsMatch(text)
    End Function

    ''' <summary>
    ''' Check if it's a correct AppEUI
    ''' Regex Operation
    ''' </summary>
    ''' <param name="text">AppEUI</param>
    ''' <returns></returns>
    Public Shared Function IsAppEUI(ByVal text As String) As Boolean
        Dim textControl As New Regex(REG_APPEUI)
        Return textControl.IsMatch(text)
    End Function
#End Region

    ' Group of functions for the Hardware settings's panel
#Region "Panel Hardware Settings Interactions"

    ''' <summary>
    ''' Check if all beacons have a different color assigned
    ''' </summary>
    ''' <returns>true if all colors are differents else return false</returns>
    Private Function CheckBeaconsSettings() As Boolean
        Dim listCheck As New List(Of Color) From {
            btBeacon1.BackColor
        }

        If numNbrBeacons.Value > 1 Then
            If listCheck.Contains(btBeacon2.BackColor) Then
                Return False
            Else
                listCheck.Add(btBeacon2.BackColor)
            End If
        End If
        If numNbrBeacons.Value > 2 Then
            If listCheck.Contains(btBeacon3.BackColor) Then
                Return False
            Else
                listCheck.Add(btBeacon3.BackColor)
            End If
        End If
        If numNbrBeacons.Value > 3 Then
            If listCheck.Contains(btBeacon4.BackColor) Then
                Return False
            Else
                listCheck.Add(btBeacon4.BackColor)
            End If
        End If
        If numNbrBeacons.Value > 4 Then
            If listCheck.Contains(btBeacon5.BackColor) Then
                Return False
            End If
        End If
        If listCheck.Contains(Color.Transparent) Then
            Return False
        End If

        Return True
    End Function

    ''' <summary>
    ''' Apply light profil
    ''' </summary>
    ''' <param name="light1">String color for light 1</param>
    ''' <param name="light2">String color for light 2</param>
    ''' <param name="light3">String color for light 3</param>
    ''' <param name="light4">String color for light 4</param>
    ''' <param name="light5">String color for light 5</param>
    Public Sub SetLightsButton(ByVal nbrBeacon As Byte, Optional light1 As String = Nothing, Optional light2 As String = Nothing, Optional light3 As String = Nothing, Optional light4 As String = Nothing, Optional light5 As String = Nothing)
        ' Light 1
        numNbrBeacons.Value = nbrBeacon
        If Not IsNothing(light1) Then
            btBeacon1.Visible = True
            btBeacon1.BackColor = GetBeaconColorJSON(light1)
        End If
        ' Light 2
        If Not IsNothing(light2) Then
            btBeacon2.Visible = True
            btBeacon2.BackColor = GetBeaconColorJSON(light2)
        Else
            btBeacon2.Visible = False
        End If
        ' Light 3
        If Not IsNothing(light3) Then
            btBeacon3.Visible = True
            btBeacon3.BackColor = GetBeaconColorJSON(light3)
        Else
            btBeacon3.Visible = False
        End If
        ' Light 4
        If Not IsNothing(light4) Then
            btBeacon4.Visible = True
            btBeacon4.BackColor = GetBeaconColorJSON(light4)
        Else
            btBeacon4.Visible = False
        End If
        ' Light 5
        If Not IsNothing(light5) Then
            btBeacon5.Visible = True
            btBeacon5.BackColor = GetBeaconColorJSON(light5)
        Else
            btBeacon5.Visible = False
        End If
    End Sub

    ''' <summary>
    ''' Change the color of the current selected beacon
    ''' </summary>
    Private Sub CboxColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxColor.SelectedIndexChanged
        If Not IsNothing(selectedBeacon) Then
            Select Case cboxColor.SelectedIndex
                Case 0
                    selectedBeacon.BackColor = colorGreen
                Case 1
                    selectedBeacon.BackColor = colorOrange
                Case 2
                    selectedBeacon.BackColor = colorRed
                Case 3
                    selectedBeacon.BackColor = colorBlue
                Case 4
                    selectedBeacon.BackColor = colorWhite
                Case Else
                    selectedBeacon.BackColor = Color.Transparent
            End Select
        End If
    End Sub

    ''' <summary>
    ''' Change the current selected beacon
    ''' Event : On click on the beacon button
    ''' </summary>
    Private Sub BeaconSelectionChange(sender As Object, e As EventArgs) Handles btBeacon1.Click, btBeacon2.Click, btBeacon3.Click, btBeacon4.Click, btBeacon5.Click
        ResetBeacon()
        Dim bt As Button = CType(sender, Button)
        bt.FlatAppearance.BorderSize = 3
        selectedBeacon = bt
        If bt.BackColor = colorGreen Then
            cboxColor.SelectedIndex = 0
        ElseIf bt.BackColor = colorOrange Then
            cboxColor.SelectedIndex = 1
        ElseIf bt.BackColor = colorRed Then
            cboxColor.SelectedIndex = 2
        ElseIf bt.BackColor = colorBlue Then
            cboxColor.SelectedIndex = 3
        ElseIf bt.BackColor = colorWhite Then
            cboxColor.SelectedIndex = 4
        End If
        cboxColor.Visible = True
        cboxColor.Location = New Point(cboxColor.Location.X, bt.Location.Y)
    End Sub

    ''' <summary>
    ''' Reset all border from beacons
    ''' </summary>
    Private Sub ResetBeacon()
        btBeacon1.FlatAppearance.BorderSize = 1
        btBeacon2.FlatAppearance.BorderSize = 1
        btBeacon3.FlatAppearance.BorderSize = 1
        btBeacon4.FlatAppearance.BorderSize = 1
        btBeacon5.FlatAppearance.BorderSize = 1
    End Sub

    ''' <summary>
    ''' Change the available number of beacons
    ''' </summary>
    Private Sub NumNbrBeacons_ValueChanged(sender As Object, e As EventArgs) Handles numNbrBeacons.ValueChanged
        btBeacon5.Visible = CBool(IIf(numNbrBeacons.Value >= 5, True, False))
        If Not btBeacon5.Visible Then btBeacon5.BackColor = Color.Transparent
        btBeacon4.Visible = CBool(IIf(numNbrBeacons.Value >= 4, True, False))
        If Not btBeacon4.Visible Then btBeacon4.BackColor = Color.Transparent
        btBeacon3.Visible = CBool(IIf(numNbrBeacons.Value >= 3, True, False))
        If Not btBeacon3.Visible Then btBeacon3.BackColor = Color.Transparent
        btBeacon2.Visible = CBool(IIf(numNbrBeacons.Value >= 2, True, False))
        If Not btBeacon2.Visible Then btBeacon2.BackColor = Color.Transparent
    End Sub

    ''' <summary>
    ''' Return the color object for a string value
    ''' </summary>
    ''' <param name="textColorValue">Name of the color used for beacon</param>
    ''' <returns>Color object</returns>
    Public Function GetBeaconColorJSON(ByVal textColorValue As String) As Color
        If textColorValue = JSN_COLOR_BLUE Then
            Return colorBlue
        ElseIf textColorValue = JSN_COLOR_GREEN Then
            Return colorGreen
        ElseIf textColorValue = JSN_COLOR_ORANGE Then
            Return colorOrange
        ElseIf textColorValue = JSN_COLOR_RED Then
            Return colorRed
        ElseIf textColorValue = JSN_COLOR_WHITE Then
            Return colorWhite
        End If
        Return Color.Transparent
    End Function

    ''' <summary>
    ''' Show the light profils form
    ''' </summary>
    Private Sub BtLightProfil_Click(sender As Object, e As EventArgs) Handles btLightProfil.Click
        If FormLightProfils.Visible Then
            FormLightProfils.Visible = False
        Else
            FormLightProfils.Visible = True
            FormLightProfils.Location = New Point(Me.Location.X + Me.Size.Width - 7, Me.Location.Y + 31)
        End If
    End Sub

#End Region

    ' Group of functions for the left Menu
#Region "Left Menu Interactions"

    ''' <summary>
    ''' User clicked on Hardware Settings's button
    ''' </summary>
    Private Sub BtMenuHardware_Click(sender As Object, e As EventArgs) Handles btMenuHardware.Click
        If Not panelHardware.Visible Then
            ShowPanelInFront(panelHardware, CType(sender, Button))
        End If
    End Sub

    ''' <summary>
    ''' User clicked on LoraWAN Settings's button
    ''' </summary>
    Private Sub BtMenuLora_Click(sender As Object, e As EventArgs) Handles btMenuLora.Click
        If Not panelLoraWAN.Visible Then
            ShowPanelInFront(panelLoraWAN, CType(sender, Button))
        End If
    End Sub

    ''' <summary>
    ''' User clicked on Communication's button
    ''' </summary>
    Private Sub BtMenuCommunication_Click(sender As Object, e As EventArgs) Handles btMenuCommunication.Click
        If Not panelSerial.Visible Then
            ShowPanelInFront(panelSerial, CType(sender, Button))
        End If
    End Sub

    ''' <summary>
    ''' User clicked on About's button
    ''' </summary>
    Private Sub BtMenuAbout_Click(sender As Object, e As EventArgs) Handles btMenuAbout.Click
        If Not panelAbout.Visible Then
            ShowPanelInFront(panelAbout, CType(sender, Button))
        End If
    End Sub

    ''' <summary>
    ''' User clicked on Exit's button
    ''' Close this application
    ''' </summary>
    Private Sub BtMenuExit_Click(sender As Object, e As EventArgs) Handles btMenuExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Change the front panel
    ''' </summary>
    ''' <param name="panelToChange">Panel to send to front</param>
    ''' <param name="btToChange">Button to change color</param>
    Public Sub ShowPanelInFront(ByVal panelToChange As Panel, ByVal btToChange As Button)
        Debug.Assert(Not IsNothing(panelToChange))
        Debug.Assert(Not IsNothing(btToChange))
        If FormLightProfils.Visible Then
            FormLightProfils.Close()
        End If
        panelLoraWAN.Visible = False
        panelSerial.Visible = False
        panelHardware.Visible = False
        panelAbout.Visible = False
        btMenuHardware.BackColor = Color.Gainsboro
        btMenuLora.BackColor = Color.Gainsboro
        btMenuCommunication.BackColor = Color.Gainsboro
        btMenuAbout.BackColor = Color.Gainsboro
        panelToChange.Visible = True
        btToChange.BackColor = Color.DarkGray
    End Sub

#End Region

    ' Group of functions for colors effect in FormMain
#Region "Effects"
    Private effectStep As Byte = 1
    Private ReadOnly effectRatio As Byte = 3
    ''' <summary>
    ''' Timer for special color effect
    ''' </summary>
    Private Sub TimerEffect_Tick(sender As Object, e As EventArgs) Handles TimerEffect.Tick
        If effectStep = 1 Then
            BackColor = Color.FromArgb(BackColor.R - effectRatio, BackColor.G + effectRatio, BackColor.B)
            If BackColor.G + effectRatio = Byte.MaxValue Then
                effectStep = 2
            End If
        End If
        If effectStep = 2 Then
            BackColor = Color.FromArgb(BackColor.R, BackColor.G - effectRatio, BackColor.B + effectRatio)
            If BackColor.B + effectRatio = Byte.MaxValue Then
                effectStep = 3
            End If
        End If
        If effectStep = 3 Then
            BackColor = Color.FromArgb(BackColor.R + effectRatio, BackColor.G, BackColor.B - effectRatio)
            If BackColor.R + effectRatio = Byte.MaxValue Then
                effectStep = 1
            End If
        End If
    End Sub

#End Region

    ''' <summary>
    ''' Open the github repository in the navigator
    ''' </summary>
    Private Sub Llab_github_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llab_github.LinkClicked
        Process.Start(URL_GITHUB)
    End Sub

End Class
