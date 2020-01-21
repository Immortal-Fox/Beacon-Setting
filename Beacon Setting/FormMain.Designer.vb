<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.panelHardware = New System.Windows.Forms.Panel()
        Me.btHardwareWrite = New System.Windows.Forms.Button()
        Me.cboxColor = New System.Windows.Forms.ComboBox()
        Me.labNbrBeacons = New System.Windows.Forms.Label()
        Me.numNbrBeacons = New System.Windows.Forms.NumericUpDown()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btBeacon1 = New System.Windows.Forms.Button()
        Me.btBeacon2 = New System.Windows.Forms.Button()
        Me.btBeacon3 = New System.Windows.Forms.Button()
        Me.btBeacon4 = New System.Windows.Forms.Button()
        Me.btBeacon5 = New System.Windows.Forms.Button()
        Me.labHardware = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.panelLoraWAN = New System.Windows.Forms.Panel()
        Me.btSaveDevice = New System.Windows.Forms.Button()
        Me.btWrite = New System.Windows.Forms.Button()
        Me.btReadEUI = New System.Windows.Forms.Button()
        Me.txtbAppEUI = New System.Windows.Forms.TextBox()
        Me.labAppEUI = New System.Windows.Forms.Label()
        Me.txtbAppKey = New System.Windows.Forms.TextBox()
        Me.labAppKey = New System.Windows.Forms.Label()
        Me.txtbEUI = New System.Windows.Forms.TextBox()
        Me.labEUI = New System.Windows.Forms.Label()
        Me.labLoRaWAN = New System.Windows.Forms.Label()
        Me.SerialComm = New System.IO.Ports.SerialPort(Me.components)
        Me.btSerialConf = New System.Windows.Forms.Button()
        Me.cboxSerialPort = New System.Windows.Forms.ComboBox()
        Me.panelSerial = New System.Windows.Forms.Panel()
        Me.btClearMessages = New System.Windows.Forms.Button()
        Me.listMessages = New System.Windows.Forms.ListBox()
        Me.txtbSendMessage = New System.Windows.Forms.TextBox()
        Me.btRefresh = New System.Windows.Forms.Button()
        Me.btConnexion = New System.Windows.Forms.Button()
        Me.labPortCOM = New System.Windows.Forms.Label()
        Me.labSerial = New System.Windows.Forms.Label()
        Me.labIsConnected = New System.Windows.Forms.Label()
        Me.TimerEffect = New System.Windows.Forms.Timer(Me.components)
        Me.panelMenu = New System.Windows.Forms.Panel()
        Me.pboxConnected = New System.Windows.Forms.PictureBox()
        Me.btMenuAbout = New System.Windows.Forms.Button()
        Me.btMenuExit = New System.Windows.Forms.Button()
        Me.btMenuCommunication = New System.Windows.Forms.Button()
        Me.btMenuLora = New System.Windows.Forms.Button()
        Me.btMenuHardware = New System.Windows.Forms.Button()
        Me.panelContent = New System.Windows.Forms.Panel()
        Me.panelAbout = New System.Windows.Forms.Panel()
        Me.labDevWith = New System.Windows.Forms.Label()
        Me.labContact = New System.Windows.Forms.Label()
        Me.labVersion = New System.Windows.Forms.Label()
        Me.labAbout = New System.Windows.Forms.Label()
        Me.labAuthor = New System.Windows.Forms.Label()
        Me.txtbVersionNotes = New System.Windows.Forms.RichTextBox()
        Me.panelEffect = New System.Windows.Forms.Panel()
        Me.panelHardware.SuspendLayout()
        CType(Me.numNbrBeacons, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelLoraWAN.SuspendLayout()
        Me.panelSerial.SuspendLayout()
        Me.panelMenu.SuspendLayout()
        CType(Me.pboxConnected, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panelContent.SuspendLayout()
        Me.panelAbout.SuspendLayout()
        Me.SuspendLayout()
        '
        'panelHardware
        '
        Me.panelHardware.BackColor = System.Drawing.Color.Silver
        Me.panelHardware.Controls.Add(Me.btHardwareWrite)
        Me.panelHardware.Controls.Add(Me.cboxColor)
        Me.panelHardware.Controls.Add(Me.labNbrBeacons)
        Me.panelHardware.Controls.Add(Me.numNbrBeacons)
        Me.panelHardware.Controls.Add(Me.PictureBox2)
        Me.panelHardware.Controls.Add(Me.btBeacon1)
        Me.panelHardware.Controls.Add(Me.btBeacon2)
        Me.panelHardware.Controls.Add(Me.btBeacon3)
        Me.panelHardware.Controls.Add(Me.btBeacon4)
        Me.panelHardware.Controls.Add(Me.btBeacon5)
        Me.panelHardware.Controls.Add(Me.labHardware)
        Me.panelHardware.Controls.Add(Me.PictureBox1)
        Me.panelHardware.Location = New System.Drawing.Point(5, 369)
        Me.panelHardware.Margin = New System.Windows.Forms.Padding(2)
        Me.panelHardware.Name = "panelHardware"
        Me.panelHardware.Size = New System.Drawing.Size(337, 359)
        Me.panelHardware.TabIndex = 0
        Me.panelHardware.Visible = False
        '
        'btHardwareWrite
        '
        Me.btHardwareWrite.BackColor = System.Drawing.Color.Navy
        Me.btHardwareWrite.FlatAppearance.BorderSize = 0
        Me.btHardwareWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btHardwareWrite.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btHardwareWrite.ForeColor = System.Drawing.Color.White
        Me.btHardwareWrite.Location = New System.Drawing.Point(128, 301)
        Me.btHardwareWrite.Margin = New System.Windows.Forms.Padding(2)
        Me.btHardwareWrite.Name = "btHardwareWrite"
        Me.btHardwareWrite.Size = New System.Drawing.Size(150, 31)
        Me.btHardwareWrite.TabIndex = 12
        Me.btHardwareWrite.Text = "Write"
        Me.btHardwareWrite.UseVisualStyleBackColor = False
        '
        'cboxColor
        '
        Me.cboxColor.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboxColor.DropDownHeight = 170
        Me.cboxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboxColor.FormattingEnabled = True
        Me.cboxColor.IntegralHeight = False
        Me.cboxColor.ItemHeight = 13
        Me.cboxColor.Items.AddRange(New Object() {"Green", "Orange", "Red", "Blue", "White"})
        Me.cboxColor.Location = New System.Drawing.Point(128, 192)
        Me.cboxColor.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxColor.Name = "cboxColor"
        Me.cboxColor.Size = New System.Drawing.Size(150, 21)
        Me.cboxColor.TabIndex = 10
        '
        'labNbrBeacons
        '
        Me.labNbrBeacons.AutoSize = True
        Me.labNbrBeacons.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labNbrBeacons.Location = New System.Drawing.Point(138, 234)
        Me.labNbrBeacons.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labNbrBeacons.Name = "labNbrBeacons"
        Me.labNbrBeacons.Size = New System.Drawing.Size(140, 14)
        Me.labNbrBeacons.TabIndex = 9
        Me.labNbrBeacons.Text = "Number of beacon(s)"
        '
        'numNbrBeacons
        '
        Me.numNbrBeacons.BackColor = System.Drawing.SystemColors.Menu
        Me.numNbrBeacons.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.numNbrBeacons.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numNbrBeacons.Location = New System.Drawing.Point(190, 253)
        Me.numNbrBeacons.Margin = New System.Windows.Forms.Padding(2)
        Me.numNbrBeacons.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.numNbrBeacons.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numNbrBeacons.Name = "numNbrBeacons"
        Me.numNbrBeacons.Size = New System.Drawing.Size(88, 20)
        Me.numNbrBeacons.TabIndex = 11
        Me.numNbrBeacons.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(54, 319)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(35, 13)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'btBeacon1
        '
        Me.btBeacon1.BackColor = System.Drawing.Color.DodgerBlue
        Me.btBeacon1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBeacon1.Location = New System.Drawing.Point(54, 192)
        Me.btBeacon1.Margin = New System.Windows.Forms.Padding(2)
        Me.btBeacon1.Name = "btBeacon1"
        Me.btBeacon1.Size = New System.Drawing.Size(35, 36)
        Me.btBeacon1.TabIndex = 9
        Me.btBeacon1.UseVisualStyleBackColor = False
        '
        'btBeacon2
        '
        Me.btBeacon2.BackColor = System.Drawing.Color.DodgerBlue
        Me.btBeacon2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBeacon2.Location = New System.Drawing.Point(54, 156)
        Me.btBeacon2.Margin = New System.Windows.Forms.Padding(2)
        Me.btBeacon2.Name = "btBeacon2"
        Me.btBeacon2.Size = New System.Drawing.Size(35, 36)
        Me.btBeacon2.TabIndex = 8
        Me.btBeacon2.UseVisualStyleBackColor = False
        '
        'btBeacon3
        '
        Me.btBeacon3.BackColor = System.Drawing.Color.DodgerBlue
        Me.btBeacon3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBeacon3.Location = New System.Drawing.Point(54, 120)
        Me.btBeacon3.Margin = New System.Windows.Forms.Padding(2)
        Me.btBeacon3.Name = "btBeacon3"
        Me.btBeacon3.Size = New System.Drawing.Size(35, 36)
        Me.btBeacon3.TabIndex = 7
        Me.btBeacon3.UseVisualStyleBackColor = False
        '
        'btBeacon4
        '
        Me.btBeacon4.BackColor = System.Drawing.Color.DodgerBlue
        Me.btBeacon4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBeacon4.Location = New System.Drawing.Point(54, 84)
        Me.btBeacon4.Margin = New System.Windows.Forms.Padding(2)
        Me.btBeacon4.Name = "btBeacon4"
        Me.btBeacon4.Size = New System.Drawing.Size(35, 36)
        Me.btBeacon4.TabIndex = 6
        Me.btBeacon4.UseVisualStyleBackColor = False
        '
        'btBeacon5
        '
        Me.btBeacon5.BackColor = System.Drawing.Color.DodgerBlue
        Me.btBeacon5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBeacon5.Location = New System.Drawing.Point(54, 48)
        Me.btBeacon5.Margin = New System.Windows.Forms.Padding(2)
        Me.btBeacon5.Name = "btBeacon5"
        Me.btBeacon5.Size = New System.Drawing.Size(35, 36)
        Me.btBeacon5.TabIndex = 5
        Me.btBeacon5.UseVisualStyleBackColor = False
        '
        'labHardware
        '
        Me.labHardware.BackColor = System.Drawing.Color.DimGray
        Me.labHardware.Dock = System.Windows.Forms.DockStyle.Top
        Me.labHardware.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHardware.ForeColor = System.Drawing.Color.White
        Me.labHardware.Location = New System.Drawing.Point(0, 0)
        Me.labHardware.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labHardware.Name = "labHardware"
        Me.labHardware.Size = New System.Drawing.Size(337, 20)
        Me.labHardware.TabIndex = 0
        Me.labHardware.Text = "Hardware"
        Me.labHardware.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(67, 222)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 100)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'panelLoraWAN
        '
        Me.panelLoraWAN.BackColor = System.Drawing.Color.Silver
        Me.panelLoraWAN.Controls.Add(Me.btSaveDevice)
        Me.panelLoraWAN.Controls.Add(Me.btWrite)
        Me.panelLoraWAN.Controls.Add(Me.btReadEUI)
        Me.panelLoraWAN.Controls.Add(Me.txtbAppEUI)
        Me.panelLoraWAN.Controls.Add(Me.labAppEUI)
        Me.panelLoraWAN.Controls.Add(Me.txtbAppKey)
        Me.panelLoraWAN.Controls.Add(Me.labAppKey)
        Me.panelLoraWAN.Controls.Add(Me.txtbEUI)
        Me.panelLoraWAN.Controls.Add(Me.labEUI)
        Me.panelLoraWAN.Controls.Add(Me.labLoRaWAN)
        Me.panelLoraWAN.Location = New System.Drawing.Point(5, 6)
        Me.panelLoraWAN.Margin = New System.Windows.Forms.Padding(2)
        Me.panelLoraWAN.Name = "panelLoraWAN"
        Me.panelLoraWAN.Size = New System.Drawing.Size(335, 359)
        Me.panelLoraWAN.TabIndex = 1
        Me.panelLoraWAN.Visible = False
        '
        'btSaveDevice
        '
        Me.btSaveDevice.BackColor = System.Drawing.Color.Navy
        Me.btSaveDevice.FlatAppearance.BorderSize = 0
        Me.btSaveDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSaveDevice.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSaveDevice.ForeColor = System.Drawing.Color.White
        Me.btSaveDevice.Location = New System.Drawing.Point(153, 281)
        Me.btSaveDevice.Margin = New System.Windows.Forms.Padding(2)
        Me.btSaveDevice.Name = "btSaveDevice"
        Me.btSaveDevice.Size = New System.Drawing.Size(109, 31)
        Me.btSaveDevice.TabIndex = 10
        Me.btSaveDevice.Text = "Save settings"
        Me.btSaveDevice.UseVisualStyleBackColor = False
        '
        'btWrite
        '
        Me.btWrite.BackColor = System.Drawing.Color.Navy
        Me.btWrite.FlatAppearance.BorderSize = 0
        Me.btWrite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btWrite.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btWrite.ForeColor = System.Drawing.Color.White
        Me.btWrite.Location = New System.Drawing.Point(191, 240)
        Me.btWrite.Margin = New System.Windows.Forms.Padding(2)
        Me.btWrite.Name = "btWrite"
        Me.btWrite.Size = New System.Drawing.Size(71, 31)
        Me.btWrite.TabIndex = 9
        Me.btWrite.Text = "Write"
        Me.btWrite.UseVisualStyleBackColor = False
        '
        'btReadEUI
        '
        Me.btReadEUI.BackColor = System.Drawing.Color.Navy
        Me.btReadEUI.FlatAppearance.BorderSize = 0
        Me.btReadEUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btReadEUI.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btReadEUI.ForeColor = System.Drawing.Color.White
        Me.btReadEUI.Location = New System.Drawing.Point(42, 240)
        Me.btReadEUI.Margin = New System.Windows.Forms.Padding(2)
        Me.btReadEUI.Name = "btReadEUI"
        Me.btReadEUI.Size = New System.Drawing.Size(145, 27)
        Me.btReadEUI.TabIndex = 8
        Me.btReadEUI.Text = "Read Device EUI"
        Me.btReadEUI.UseVisualStyleBackColor = False
        '
        'txtbAppEUI
        '
        Me.txtbAppEUI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbAppEUI.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbAppEUI.Location = New System.Drawing.Point(54, 197)
        Me.txtbAppEUI.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbAppEUI.Name = "txtbAppEUI"
        Me.txtbAppEUI.Size = New System.Drawing.Size(208, 16)
        Me.txtbAppEUI.TabIndex = 7
        Me.txtbAppEUI.Text = "0x000000000"
        '
        'labAppEUI
        '
        Me.labAppEUI.AutoSize = True
        Me.labAppEUI.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAppEUI.Location = New System.Drawing.Point(57, 180)
        Me.labAppEUI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labAppEUI.Name = "labAppEUI"
        Me.labAppEUI.Size = New System.Drawing.Size(49, 14)
        Me.labAppEUI.TabIndex = 5
        Me.labAppEUI.Text = "AppEUI"
        '
        'txtbAppKey
        '
        Me.txtbAppKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbAppKey.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbAppKey.Location = New System.Drawing.Point(54, 130)
        Me.txtbAppKey.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbAppKey.Name = "txtbAppKey"
        Me.txtbAppKey.Size = New System.Drawing.Size(208, 16)
        Me.txtbAppKey.TabIndex = 6
        Me.txtbAppKey.Text = "0x000000000"
        '
        'labAppKey
        '
        Me.labAppKey.AutoSize = True
        Me.labAppKey.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAppKey.Location = New System.Drawing.Point(57, 113)
        Me.labAppKey.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labAppKey.Name = "labAppKey"
        Me.labAppKey.Size = New System.Drawing.Size(49, 14)
        Me.labAppKey.TabIndex = 3
        Me.labAppKey.Text = "AppKey"
        '
        'txtbEUI
        '
        Me.txtbEUI.BackColor = System.Drawing.Color.White
        Me.txtbEUI.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbEUI.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbEUI.Location = New System.Drawing.Point(54, 63)
        Me.txtbEUI.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbEUI.Name = "txtbEUI"
        Me.txtbEUI.ReadOnly = True
        Me.txtbEUI.Size = New System.Drawing.Size(208, 16)
        Me.txtbEUI.TabIndex = 5
        Me.txtbEUI.Text = "0x000000000"
        '
        'labEUI
        '
        Me.labEUI.AutoSize = True
        Me.labEUI.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labEUI.Location = New System.Drawing.Point(57, 46)
        Me.labEUI.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labEUI.Name = "labEUI"
        Me.labEUI.Size = New System.Drawing.Size(77, 14)
        Me.labEUI.TabIndex = 1
        Me.labEUI.Text = "Device EUI"
        '
        'labLoRaWAN
        '
        Me.labLoRaWAN.BackColor = System.Drawing.Color.DimGray
        Me.labLoRaWAN.Dock = System.Windows.Forms.DockStyle.Top
        Me.labLoRaWAN.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labLoRaWAN.ForeColor = System.Drawing.Color.White
        Me.labLoRaWAN.Location = New System.Drawing.Point(0, 0)
        Me.labLoRaWAN.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labLoRaWAN.Name = "labLoRaWAN"
        Me.labLoRaWAN.Size = New System.Drawing.Size(335, 20)
        Me.labLoRaWAN.TabIndex = 0
        Me.labLoRaWAN.Text = "LoRaWAN"
        Me.labLoRaWAN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SerialComm
        '
        Me.SerialComm.BaudRate = 115200
        Me.SerialComm.DtrEnable = True
        Me.SerialComm.PortName = "COM6"
        '
        'btSerialConf
        '
        Me.btSerialConf.BackColor = System.Drawing.Color.Navy
        Me.btSerialConf.FlatAppearance.BorderSize = 0
        Me.btSerialConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btSerialConf.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSerialConf.ForeColor = System.Drawing.Color.White
        Me.btSerialConf.Location = New System.Drawing.Point(10, 111)
        Me.btSerialConf.Margin = New System.Windows.Forms.Padding(2)
        Me.btSerialConf.Name = "btSerialConf"
        Me.btSerialConf.Size = New System.Drawing.Size(123, 31)
        Me.btSerialConf.TabIndex = 9
        Me.btSerialConf.Text = "Serial Settings"
        Me.btSerialConf.UseVisualStyleBackColor = False
        '
        'cboxSerialPort
        '
        Me.cboxSerialPort.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cboxSerialPort.DropDownHeight = 170
        Me.cboxSerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSerialPort.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboxSerialPort.FormattingEnabled = True
        Me.cboxSerialPort.IntegralHeight = False
        Me.cboxSerialPort.ItemHeight = 13
        Me.cboxSerialPort.Items.AddRange(New Object() {"COM1", "COM2", "COM4", "etc"})
        Me.cboxSerialPort.Location = New System.Drawing.Point(160, 23)
        Me.cboxSerialPort.Margin = New System.Windows.Forms.Padding(2)
        Me.cboxSerialPort.Name = "cboxSerialPort"
        Me.cboxSerialPort.Size = New System.Drawing.Size(109, 21)
        Me.cboxSerialPort.TabIndex = 10
        '
        'panelSerial
        '
        Me.panelSerial.BackColor = System.Drawing.Color.Silver
        Me.panelSerial.Controls.Add(Me.btClearMessages)
        Me.panelSerial.Controls.Add(Me.listMessages)
        Me.panelSerial.Controls.Add(Me.txtbSendMessage)
        Me.panelSerial.Controls.Add(Me.btRefresh)
        Me.panelSerial.Controls.Add(Me.btConnexion)
        Me.panelSerial.Controls.Add(Me.labPortCOM)
        Me.panelSerial.Controls.Add(Me.labSerial)
        Me.panelSerial.Controls.Add(Me.cboxSerialPort)
        Me.panelSerial.Controls.Add(Me.btSerialConf)
        Me.panelSerial.Location = New System.Drawing.Point(344, 6)
        Me.panelSerial.Margin = New System.Windows.Forms.Padding(2)
        Me.panelSerial.Name = "panelSerial"
        Me.panelSerial.Size = New System.Drawing.Size(335, 359)
        Me.panelSerial.TabIndex = 1
        '
        'btClearMessages
        '
        Me.btClearMessages.BackColor = System.Drawing.Color.Navy
        Me.btClearMessages.FlatAppearance.BorderSize = 0
        Me.btClearMessages.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btClearMessages.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClearMessages.ForeColor = System.Drawing.Color.White
        Me.btClearMessages.Location = New System.Drawing.Point(240, 111)
        Me.btClearMessages.Margin = New System.Windows.Forms.Padding(2)
        Me.btClearMessages.Name = "btClearMessages"
        Me.btClearMessages.Size = New System.Drawing.Size(83, 31)
        Me.btClearMessages.TabIndex = 19
        Me.btClearMessages.Text = "Clear"
        Me.btClearMessages.UseVisualStyleBackColor = False
        '
        'listMessages
        '
        Me.listMessages.BackColor = System.Drawing.SystemColors.WindowText
        Me.listMessages.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.listMessages.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.listMessages.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listMessages.ForeColor = System.Drawing.SystemColors.Window
        Me.listMessages.FormattingEnabled = True
        Me.listMessages.ItemHeight = 14
        Me.listMessages.Location = New System.Drawing.Point(0, 171)
        Me.listMessages.Name = "listMessages"
        Me.listMessages.Size = New System.Drawing.Size(335, 168)
        Me.listMessages.TabIndex = 17
        '
        'txtbSendMessage
        '
        Me.txtbSendMessage.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtbSendMessage.Location = New System.Drawing.Point(0, 339)
        Me.txtbSendMessage.MaxLength = 50
        Me.txtbSendMessage.Name = "txtbSendMessage"
        Me.txtbSendMessage.Size = New System.Drawing.Size(335, 20)
        Me.txtbSendMessage.TabIndex = 18
        '
        'btRefresh
        '
        Me.btRefresh.BackColor = System.Drawing.Color.Navy
        Me.btRefresh.FlatAppearance.BorderSize = 0
        Me.btRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btRefresh.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btRefresh.ForeColor = System.Drawing.Color.White
        Me.btRefresh.Location = New System.Drawing.Point(82, 56)
        Me.btRefresh.Margin = New System.Windows.Forms.Padding(2)
        Me.btRefresh.Name = "btRefresh"
        Me.btRefresh.Size = New System.Drawing.Size(66, 31)
        Me.btRefresh.TabIndex = 14
        Me.btRefresh.Text = "Refresh"
        Me.btRefresh.UseVisualStyleBackColor = False
        '
        'btConnexion
        '
        Me.btConnexion.BackColor = System.Drawing.Color.Navy
        Me.btConnexion.FlatAppearance.BorderSize = 0
        Me.btConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btConnexion.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btConnexion.ForeColor = System.Drawing.Color.White
        Me.btConnexion.Location = New System.Drawing.Point(177, 55)
        Me.btConnexion.Margin = New System.Windows.Forms.Padding(2)
        Me.btConnexion.Name = "btConnexion"
        Me.btConnexion.Size = New System.Drawing.Size(92, 31)
        Me.btConnexion.TabIndex = 12
        Me.btConnexion.Text = "Connect"
        Me.btConnexion.UseVisualStyleBackColor = False
        '
        'labPortCOM
        '
        Me.labPortCOM.AutoSize = True
        Me.labPortCOM.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labPortCOM.Location = New System.Drawing.Point(79, 26)
        Me.labPortCOM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labPortCOM.Name = "labPortCOM"
        Me.labPortCOM.Size = New System.Drawing.Size(77, 14)
        Me.labPortCOM.TabIndex = 11
        Me.labPortCOM.Text = "Port COM :"
        '
        'labSerial
        '
        Me.labSerial.BackColor = System.Drawing.Color.DimGray
        Me.labSerial.Dock = System.Windows.Forms.DockStyle.Top
        Me.labSerial.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSerial.ForeColor = System.Drawing.Color.White
        Me.labSerial.Location = New System.Drawing.Point(0, 0)
        Me.labSerial.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labSerial.Name = "labSerial"
        Me.labSerial.Size = New System.Drawing.Size(335, 20)
        Me.labSerial.TabIndex = 0
        Me.labSerial.Text = "Serial Communication"
        Me.labSerial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labIsConnected
        '
        Me.labIsConnected.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labIsConnected.ForeColor = System.Drawing.Color.Coral
        Me.labIsConnected.Location = New System.Drawing.Point(4, 158)
        Me.labIsConnected.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labIsConnected.Name = "labIsConnected"
        Me.labIsConnected.Size = New System.Drawing.Size(148, 31)
        Me.labIsConnected.TabIndex = 13
        Me.labIsConnected.Text = "Not Connected"
        Me.labIsConnected.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerEffect
        '
        Me.TimerEffect.Interval = 20
        '
        'panelMenu
        '
        Me.panelMenu.BackColor = System.Drawing.Color.DimGray
        Me.panelMenu.Controls.Add(Me.labIsConnected)
        Me.panelMenu.Controls.Add(Me.pboxConnected)
        Me.panelMenu.Controls.Add(Me.btMenuAbout)
        Me.panelMenu.Controls.Add(Me.btMenuExit)
        Me.panelMenu.Controls.Add(Me.btMenuCommunication)
        Me.panelMenu.Controls.Add(Me.btMenuLora)
        Me.panelMenu.Controls.Add(Me.btMenuHardware)
        Me.panelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelMenu.Location = New System.Drawing.Point(0, 0)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(155, 763)
        Me.panelMenu.TabIndex = 2
        '
        'pboxConnected
        '
        Me.pboxConnected.Image = CType(resources.GetObject("pboxConnected.Image"), System.Drawing.Image)
        Me.pboxConnected.InitialImage = Nothing
        Me.pboxConnected.Location = New System.Drawing.Point(1, 122)
        Me.pboxConnected.Name = "pboxConnected"
        Me.pboxConnected.Size = New System.Drawing.Size(154, 47)
        Me.pboxConnected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pboxConnected.TabIndex = 15
        Me.pboxConnected.TabStop = False
        '
        'btMenuAbout
        '
        Me.btMenuAbout.BackColor = System.Drawing.Color.Gainsboro
        Me.btMenuAbout.FlatAppearance.BorderSize = 0
        Me.btMenuAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btMenuAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btMenuAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMenuAbout.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenuAbout.Location = New System.Drawing.Point(5, 282)
        Me.btMenuAbout.Name = "btMenuAbout"
        Me.btMenuAbout.Size = New System.Drawing.Size(144, 34)
        Me.btMenuAbout.TabIndex = 3
        Me.btMenuAbout.Text = "About"
        Me.btMenuAbout.UseVisualStyleBackColor = False
        '
        'btMenuExit
        '
        Me.btMenuExit.BackColor = System.Drawing.Color.Tomato
        Me.btMenuExit.FlatAppearance.BorderSize = 0
        Me.btMenuExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMenuExit.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenuExit.Location = New System.Drawing.Point(5, 322)
        Me.btMenuExit.Name = "btMenuExit"
        Me.btMenuExit.Size = New System.Drawing.Size(144, 34)
        Me.btMenuExit.TabIndex = 4
        Me.btMenuExit.Text = "Exit"
        Me.btMenuExit.UseVisualStyleBackColor = False
        '
        'btMenuCommunication
        '
        Me.btMenuCommunication.BackColor = System.Drawing.Color.Gainsboro
        Me.btMenuCommunication.FlatAppearance.BorderSize = 0
        Me.btMenuCommunication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btMenuCommunication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btMenuCommunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMenuCommunication.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenuCommunication.Location = New System.Drawing.Point(5, 86)
        Me.btMenuCommunication.Name = "btMenuCommunication"
        Me.btMenuCommunication.Size = New System.Drawing.Size(144, 34)
        Me.btMenuCommunication.TabIndex = 2
        Me.btMenuCommunication.Text = "Communication"
        Me.btMenuCommunication.UseVisualStyleBackColor = False
        '
        'btMenuLora
        '
        Me.btMenuLora.BackColor = System.Drawing.Color.Gainsboro
        Me.btMenuLora.FlatAppearance.BorderSize = 0
        Me.btMenuLora.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btMenuLora.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btMenuLora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMenuLora.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenuLora.Location = New System.Drawing.Point(5, 46)
        Me.btMenuLora.Name = "btMenuLora"
        Me.btMenuLora.Size = New System.Drawing.Size(144, 34)
        Me.btMenuLora.TabIndex = 1
        Me.btMenuLora.Text = "LoRaWAN Settings"
        Me.btMenuLora.UseVisualStyleBackColor = False
        '
        'btMenuHardware
        '
        Me.btMenuHardware.BackColor = System.Drawing.Color.Gainsboro
        Me.btMenuHardware.FlatAppearance.BorderSize = 0
        Me.btMenuHardware.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.btMenuHardware.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray
        Me.btMenuHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btMenuHardware.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btMenuHardware.Location = New System.Drawing.Point(5, 6)
        Me.btMenuHardware.Name = "btMenuHardware"
        Me.btMenuHardware.Size = New System.Drawing.Size(144, 34)
        Me.btMenuHardware.TabIndex = 0
        Me.btMenuHardware.Text = "Hardware Settings"
        Me.btMenuHardware.UseVisualStyleBackColor = False
        '
        'panelContent
        '
        Me.panelContent.Controls.Add(Me.panelAbout)
        Me.panelContent.Controls.Add(Me.panelHardware)
        Me.panelContent.Controls.Add(Me.panelLoraWAN)
        Me.panelContent.Controls.Add(Me.panelSerial)
        Me.panelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelContent.Location = New System.Drawing.Point(155, 0)
        Me.panelContent.Name = "panelContent"
        Me.panelContent.Size = New System.Drawing.Size(1044, 749)
        Me.panelContent.TabIndex = 3
        '
        'panelAbout
        '
        Me.panelAbout.BackColor = System.Drawing.Color.Silver
        Me.panelAbout.Controls.Add(Me.labDevWith)
        Me.panelAbout.Controls.Add(Me.labContact)
        Me.panelAbout.Controls.Add(Me.labVersion)
        Me.panelAbout.Controls.Add(Me.labAbout)
        Me.panelAbout.Controls.Add(Me.labAuthor)
        Me.panelAbout.Controls.Add(Me.txtbVersionNotes)
        Me.panelAbout.Location = New System.Drawing.Point(686, 6)
        Me.panelAbout.Name = "panelAbout"
        Me.panelAbout.Size = New System.Drawing.Size(335, 359)
        Me.panelAbout.TabIndex = 2
        Me.panelAbout.Visible = False
        '
        'labDevWith
        '
        Me.labDevWith.AutoSize = True
        Me.labDevWith.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.labDevWith.Location = New System.Drawing.Point(13, 73)
        Me.labDevWith.Name = "labDevWith"
        Me.labDevWith.Size = New System.Drawing.Size(210, 14)
        Me.labDevWith.TabIndex = 5
        Me.labDevWith.Text = "Developped with Framework.NET"
        '
        'labContact
        '
        Me.labContact.AutoSize = True
        Me.labContact.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.labContact.Location = New System.Drawing.Point(13, 100)
        Me.labContact.Name = "labContact"
        Me.labContact.Size = New System.Drawing.Size(245, 14)
        Me.labContact.TabIndex = 4
        Me.labContact.Text = "Contact : ludovic.zyldar@gmail.com"
        '
        'labVersion
        '
        Me.labVersion.AutoSize = True
        Me.labVersion.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.labVersion.Location = New System.Drawing.Point(13, 48)
        Me.labVersion.Name = "labVersion"
        Me.labVersion.Size = New System.Drawing.Size(84, 14)
        Me.labVersion.TabIndex = 3
        Me.labVersion.Text = "Version : 1"
        '
        'labAbout
        '
        Me.labAbout.BackColor = System.Drawing.Color.DimGray
        Me.labAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.labAbout.Font = New System.Drawing.Font("Consolas", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labAbout.ForeColor = System.Drawing.Color.White
        Me.labAbout.Location = New System.Drawing.Point(0, 0)
        Me.labAbout.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labAbout.Name = "labAbout"
        Me.labAbout.Size = New System.Drawing.Size(335, 20)
        Me.labAbout.TabIndex = 2
        Me.labAbout.Text = "About"
        Me.labAbout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'labAuthor
        '
        Me.labAuthor.AutoSize = True
        Me.labAuthor.Font = New System.Drawing.Font("Consolas", 9.0!)
        Me.labAuthor.Location = New System.Drawing.Point(13, 31)
        Me.labAuthor.Name = "labAuthor"
        Me.labAuthor.Size = New System.Drawing.Size(196, 14)
        Me.labAuthor.TabIndex = 1
        Me.labAuthor.Text = "Author : Charmillot Ludovic"
        '
        'txtbVersionNotes
        '
        Me.txtbVersionNotes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtbVersionNotes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.txtbVersionNotes.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbVersionNotes.Location = New System.Drawing.Point(0, 141)
        Me.txtbVersionNotes.Name = "txtbVersionNotes"
        Me.txtbVersionNotes.ReadOnly = True
        Me.txtbVersionNotes.Size = New System.Drawing.Size(335, 218)
        Me.txtbVersionNotes.TabIndex = 0
        Me.txtbVersionNotes.Text = "  " & Global.Microsoft.VisualBasic.ChrW(10) & "  Version 1  -  15.01.2020" & Global.Microsoft.VisualBasic.ChrW(10) & "  Initial Release"
        '
        'panelEffect
        '
        Me.panelEffect.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panelEffect.Location = New System.Drawing.Point(155, 749)
        Me.panelEffect.Name = "panelEffect"
        Me.panelEffect.Size = New System.Drawing.Size(1044, 14)
        Me.panelEffect.TabIndex = 4
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(1199, 763)
        Me.Controls.Add(Me.panelContent)
        Me.Controls.Add(Me.panelEffect)
        Me.Controls.Add(Me.panelMenu)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "FormMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoRaWan Beacon Config"
        Me.panelHardware.ResumeLayout(False)
        Me.panelHardware.PerformLayout()
        CType(Me.numNbrBeacons, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelLoraWAN.ResumeLayout(False)
        Me.panelLoraWAN.PerformLayout()
        Me.panelSerial.ResumeLayout(False)
        Me.panelSerial.PerformLayout()
        Me.panelMenu.ResumeLayout(False)
        CType(Me.pboxConnected, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panelContent.ResumeLayout(False)
        Me.panelAbout.ResumeLayout(False)
        Me.panelAbout.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panelHardware As Panel
    Friend WithEvents labHardware As Label
    Friend WithEvents panelLoraWAN As Panel
    Friend WithEvents btWrite As Button
    Friend WithEvents btReadEUI As Button
    Friend WithEvents txtbAppEUI As TextBox
    Friend WithEvents labAppEUI As Label
    Friend WithEvents txtbAppKey As TextBox
    Friend WithEvents labAppKey As Label
    Friend WithEvents txtbEUI As TextBox
    Friend WithEvents labEUI As Label
    Friend WithEvents labLoRaWAN As Label
    Friend WithEvents SerialComm As IO.Ports.SerialPort
    Friend WithEvents btSerialConf As Button
    Friend WithEvents cboxSerialPort As ComboBox
    Friend WithEvents panelSerial As Panel
    Friend WithEvents labPortCOM As Label
    Friend WithEvents labSerial As Label
    Friend WithEvents btConnexion As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btBeacon1 As Button
    Friend WithEvents btBeacon2 As Button
    Friend WithEvents btBeacon3 As Button
    Friend WithEvents btBeacon4 As Button
    Friend WithEvents btBeacon5 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents labNbrBeacons As Label
    Friend WithEvents numNbrBeacons As NumericUpDown
    Friend WithEvents cboxColor As ComboBox
    Friend WithEvents labIsConnected As Label
    Friend WithEvents TimerEffect As Timer
    Friend WithEvents btRefresh As Button
    Friend WithEvents panelMenu As Panel
    Friend WithEvents btMenuHardware As Button
    Friend WithEvents panelContent As Panel
    Friend WithEvents btMenuExit As Button
    Friend WithEvents btMenuCommunication As Button
    Friend WithEvents btMenuLora As Button
    Friend WithEvents btHardwareWrite As Button
    Friend WithEvents btMenuAbout As Button
    Friend WithEvents panelAbout As Panel
    Friend WithEvents txtbVersionNotes As RichTextBox
    Friend WithEvents labContact As Label
    Friend WithEvents labVersion As Label
    Friend WithEvents labAbout As Label
    Friend WithEvents labAuthor As Label
    Friend WithEvents panelEffect As Panel
    Friend WithEvents btSaveDevice As Button
    Friend WithEvents listMessages As ListBox
    Friend WithEvents txtbSendMessage As TextBox
    Friend WithEvents btClearMessages As Button
    Friend WithEvents pboxConnected As PictureBox
    Friend WithEvents labDevWith As Label
End Class
