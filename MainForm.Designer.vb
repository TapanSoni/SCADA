<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
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
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.PilotLight1 = New AdvancedHMIControls.PilotLight()
        Me.ModbusTCPCom1 = New AdvancedHMIDrivers.ModbusTCPCom(Me.components)
        Me.PilotLight3Color1 = New AdvancedHMIControls.PilotLight3Color()
        Me.PilotLight3Color3 = New AdvancedHMIControls.PilotLight3Color()
        Me.PilotLight3Color2 = New AdvancedHMIControls.PilotLight3Color()
        Me.PilotLight3Color4 = New AdvancedHMIControls.PilotLight3Color()
        Me.PilotLight3Color5 = New AdvancedHMIControls.PilotLight3Color()
        Me.PilotLight3Color6 = New AdvancedHMIControls.PilotLight3Color()
        Me.BasicTrendChart2 = New AdvancedHMIControls.BasicTrendChart()
        Me.TempController1 = New AdvancedHMIControls.TempController()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.SelectorSwitch2 = New AdvancedHMIControls.SelectorSwitch()
        Me.SelectorSwitch3Pos1 = New AdvancedHMIControls.SelectorSwitch3Pos()
        Me.SelectorSwitch1 = New AdvancedHMIControls.SelectorSwitch()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.OrientedTextLabel1 = New AdvancedHMIControls.OrientedTextLabel()
        Me.OrientedTextLabel2 = New AdvancedHMIControls.OrientedTextLabel()
        Me.SelectorSwitch3 = New AdvancedHMIControls.SelectorSwitch()
        Me.SelectorSwitch4 = New AdvancedHMIControls.SelectorSwitch()
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 465)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PilotLight1
        '
        Me.PilotLight1.Blink = False
        Me.PilotLight1.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight.LegendPlates.Large
        Me.PilotLight1.LightColor = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Green
        Me.PilotLight1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight.LightColors.Red
        Me.PilotLight1.Location = New System.Drawing.Point(2, 115)
        Me.PilotLight1.Name = "PilotLight1"
        Me.PilotLight1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight1.PLCAddressClick = "00001"
        Me.PilotLight1.PLCAddressText = ""
        Me.PilotLight1.PLCAddressValue = "00001"
        Me.PilotLight1.PLCAddressVisible = ""
        Me.PilotLight1.Size = New System.Drawing.Size(89, 130)
        Me.PilotLight1.TabIndex = 55
        Me.PilotLight1.Text = "Main Power"
        Me.PilotLight1.Value = False
        Me.PilotLight1.ValueToWrite = 0
        '
        'ModbusTCPCom1
        '
        Me.ModbusTCPCom1.DisableSubscriptions = False
        Me.ModbusTCPCom1.IniFileName = ""
        Me.ModbusTCPCom1.IniFileSection = Nothing
        Me.ModbusTCPCom1.IPAddress = "192.168.0.2"
        Me.ModbusTCPCom1.MaxReadGroupSize = 20
        Me.ModbusTCPCom1.PollRateOverride = 100
        Me.ModbusTCPCom1.SwapBytes = True
        Me.ModbusTCPCom1.SwapWords = False
        Me.ModbusTCPCom1.TcpipPort = CType(502US, UShort)
        Me.ModbusTCPCom1.TimeOut = 3000
        Me.ModbusTCPCom1.UnitId = CType(1, Byte)
        '
        'PilotLight3Color1
        '
        Me.PilotLight3Color1.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight3Color1.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LegendPlates.Large
        Me.PilotLight3Color1.LightColor2 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color1.LightColor3 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Red
        Me.PilotLight3Color1.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.White
        Me.PilotLight3Color1.Location = New System.Drawing.Point(269, 115)
        Me.PilotLight3Color1.Name = "PilotLight3Color1"
        Me.PilotLight3Color1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetFalse
        Me.PilotLight3Color1.PLCaddressClick = ""
        Me.PilotLight3Color1.PLCaddressSelectColor2 = "00004"
        Me.PilotLight3Color1.PLCaddressSelectColor3 = "00003"
        Me.PilotLight3Color1.PLCaddressText = ""
        Me.PilotLight3Color1.PLCaddressVisible = ""
        Me.PilotLight3Color1.SelectColor2 = False
        Me.PilotLight3Color1.SelectColor3 = False
        Me.PilotLight3Color1.Size = New System.Drawing.Size(89, 130)
        Me.PilotLight3Color1.TabIndex = 60
        Me.PilotLight3Color1.Text = "Train en Route"
        '
        'PilotLight3Color3
        '
        Me.PilotLight3Color3.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight3Color3.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LegendPlates.Large
        Me.PilotLight3Color3.LightColor2 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Red
        Me.PilotLight3Color3.LightColor3 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color3.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.White
        Me.PilotLight3Color3.Location = New System.Drawing.Point(358, 115)
        Me.PilotLight3Color3.Name = "PilotLight3Color3"
        Me.PilotLight3Color3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.SetFalse
        Me.PilotLight3Color3.PLCaddressClick = ""
        Me.PilotLight3Color3.PLCaddressSelectColor2 = "00004"
        Me.PilotLight3Color3.PLCaddressSelectColor3 = "00003"
        Me.PilotLight3Color3.PLCaddressText = ""
        Me.PilotLight3Color3.PLCaddressVisible = ""
        Me.PilotLight3Color3.SelectColor2 = False
        Me.PilotLight3Color3.SelectColor3 = False
        Me.PilotLight3Color3.Size = New System.Drawing.Size(89, 130)
        Me.PilotLight3Color3.TabIndex = 62
        Me.PilotLight3Color3.Text = "Train at Station"
        '
        'PilotLight3Color2
        '
        Me.PilotLight3Color2.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight3Color2.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LegendPlates.Large
        Me.PilotLight3Color2.LightColor2 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color2.LightColor3 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Red
        Me.PilotLight3Color2.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Red
        Me.PilotLight3Color2.Location = New System.Drawing.Point(91, 264)
        Me.PilotLight3Color2.Name = "PilotLight3Color2"
        Me.PilotLight3Color2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight3Color2.PLCaddressClick = "00005"
        Me.PilotLight3Color2.PLCaddressSelectColor2 = "00005"
        Me.PilotLight3Color2.PLCaddressSelectColor3 = ""
        Me.PilotLight3Color2.PLCaddressText = ""
        Me.PilotLight3Color2.PLCaddressVisible = ""
        Me.PilotLight3Color2.SelectColor2 = False
        Me.PilotLight3Color2.SelectColor3 = False
        Me.PilotLight3Color2.Size = New System.Drawing.Size(89, 130)
        Me.PilotLight3Color2.TabIndex = 63
        Me.PilotLight3Color2.Text = "Tower Fan"
        '
        'PilotLight3Color4
        '
        Me.PilotLight3Color4.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight3Color4.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LegendPlates.Large
        Me.PilotLight3Color4.LightColor2 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color4.LightColor3 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color4.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Red
        Me.PilotLight3Color4.Location = New System.Drawing.Point(180, 264)
        Me.PilotLight3Color4.Name = "PilotLight3Color4"
        Me.PilotLight3Color4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight3Color4.PLCaddressClick = "00006"
        Me.PilotLight3Color4.PLCaddressSelectColor2 = "00006"
        Me.PilotLight3Color4.PLCaddressSelectColor3 = ""
        Me.PilotLight3Color4.PLCaddressText = ""
        Me.PilotLight3Color4.PLCaddressVisible = ""
        Me.PilotLight3Color4.SelectColor2 = False
        Me.PilotLight3Color4.SelectColor3 = False
        Me.PilotLight3Color4.Size = New System.Drawing.Size(89, 130)
        Me.PilotLight3Color4.TabIndex = 64
        Me.PilotLight3Color4.Text = "Cooling Fan"
        '
        'PilotLight3Color5
        '
        Me.PilotLight3Color5.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight3Color5.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LegendPlates.Large
        Me.PilotLight3Color5.LightColor2 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color5.LightColor3 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color5.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Red
        Me.PilotLight3Color5.Location = New System.Drawing.Point(269, 264)
        Me.PilotLight3Color5.Name = "PilotLight3Color5"
        Me.PilotLight3Color5.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight3Color5.PLCaddressClick = "00007"
        Me.PilotLight3Color5.PLCaddressSelectColor2 = "00007"
        Me.PilotLight3Color5.PLCaddressSelectColor3 = ""
        Me.PilotLight3Color5.PLCaddressText = ""
        Me.PilotLight3Color5.PLCaddressVisible = ""
        Me.PilotLight3Color5.SelectColor2 = False
        Me.PilotLight3Color5.SelectColor3 = False
        Me.PilotLight3Color5.Size = New System.Drawing.Size(89, 130)
        Me.PilotLight3Color5.TabIndex = 66
        Me.PilotLight3Color5.Text = "Heater"
        '
        'PilotLight3Color6
        '
        Me.PilotLight3Color6.ComComponent = Me.ModbusTCPCom1
        Me.PilotLight3Color6.LegendPlate = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LegendPlates.Large
        Me.PilotLight3Color6.LightColor2 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color6.LightColor3 = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Green
        Me.PilotLight3Color6.LightColorOff = MfgControl.AdvancedHMI.Controls.PilotLight3Color.LightColors.Red
        Me.PilotLight3Color6.Location = New System.Drawing.Point(358, 264)
        Me.PilotLight3Color6.Name = "PilotLight3Color6"
        Me.PilotLight3Color6.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.PilotLight3Color6.PLCaddressClick = "00014"
        Me.PilotLight3Color6.PLCaddressSelectColor2 = "00014"
        Me.PilotLight3Color6.PLCaddressSelectColor3 = ""
        Me.PilotLight3Color6.PLCaddressText = ""
        Me.PilotLight3Color6.PLCaddressVisible = ""
        Me.PilotLight3Color6.SelectColor2 = False
        Me.PilotLight3Color6.SelectColor3 = False
        Me.PilotLight3Color6.Size = New System.Drawing.Size(89, 130)
        Me.PilotLight3Color6.TabIndex = 70
        Me.PilotLight3Color6.Text = "Lights"
        '
        'BasicTrendChart2
        '
        Me.BasicTrendChart2.AccessibleName = "Temperature Over TIme"
        Me.BasicTrendChart2.BackColor = System.Drawing.Color.Black
        Me.BasicTrendChart2.ComComponent = Me.ModbusTCPCom1
        Me.BasicTrendChart2.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BasicTrendChart2.ForeColor = System.Drawing.Color.Transparent
        Me.BasicTrendChart2.Location = New System.Drawing.Point(535, 264)
        Me.BasicTrendChart2.MaxPoints = 85
        Me.BasicTrendChart2.Name = "BasicTrendChart2"
        Me.BasicTrendChart2.PLCAddressValue = "40005"
        Me.BasicTrendChart2.PLCAddressVisible = ""
        Me.BasicTrendChart2.Size = New System.Drawing.Size(221, 130)
        Me.BasicTrendChart2.SuppressErrorDisplay = True
        Me.BasicTrendChart2.TabIndex = 73
        Me.BasicTrendChart2.Text = "Temperature Over Time"
        Me.BasicTrendChart2.Value = ""
        Me.BasicTrendChart2.YMaximum = 85
        Me.BasicTrendChart2.YMinimum = 75
        '
        'TempController1
        '
        Me.TempController1.AllowDrop = True
        Me.TempController1.Button1Text = Nothing
        Me.TempController1.Button2Text = ""
        Me.TempController1.ComComponent = Me.ModbusTCPCom1
        Me.TempController1.DecimalPosition = 0
        Me.TempController1.ForeColor = System.Drawing.Color.White
        Me.TempController1.Location = New System.Drawing.Point(536, 62)
        Me.TempController1.Name = "TempController1"
        Me.TempController1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentarySet
        Me.TempController1.PLCAddressClick1 = ""
        Me.TempController1.PLCAddressClick2 = "000012"
        Me.TempController1.PLCAddressClick3 = "000017"
        Me.TempController1.PLCAddressClick4 = "000016"
        Me.TempController1.PLCAddressText = ""
        Me.TempController1.PLCAddressValuePV = "40005"
        Me.TempController1.PLCAddressValueSP = "40002"
        Me.TempController1.PLCAddressVisible = ""
        Me.TempController1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TempController1.ScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TempController1.Size = New System.Drawing.Size(220, 221)
        Me.TempController1.TabIndex = 74
        Me.TempController1.Text = "Temperature"
        Me.TempController1.Value_ValueScaleFactor = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TempController1.Value_ValueScaleFactorSP = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TempController1.Value2Text = "Target"
        Me.TempController1.ValuePV = 0!
        Me.TempController1.ValueSP = 0!
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.MfgControl.AdvancedHMI.My.Resources.Resources.cd846812_43c1_4c6b_8a16_4bb577adad62
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(314, -49)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(198, 144)
        Me.PictureBox2.TabIndex = 76
        Me.PictureBox2.TabStop = False
        '
        'SelectorSwitch2
        '
        Me.SelectorSwitch2.BackColor = System.Drawing.Color.Transparent
        Me.SelectorSwitch2.BackgroundImage = CType(resources.GetObject("SelectorSwitch2.BackgroundImage"), System.Drawing.Image)
        Me.SelectorSwitch2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SelectorSwitch2.ComComponent = Me.ModbusTCPCom1
        Me.SelectorSwitch2.LegendPlate = MfgControl.AdvancedHMI.Controls.SelectorSwitch.LegendPlates.Large
        Me.SelectorSwitch2.Location = New System.Drawing.Point(2, 264)
        Me.SelectorSwitch2.Name = "SelectorSwitch2"
        Me.SelectorSwitch2.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SelectorSwitch2.PLCAddressClick = "00009"
        Me.SelectorSwitch2.PLCAddressText = ""
        Me.SelectorSwitch2.PLCAddressValue = "00009"
        Me.SelectorSwitch2.PLCAddressVisible = ""
        Me.SelectorSwitch2.Size = New System.Drawing.Size(89, 130)
        Me.SelectorSwitch2.TabIndex = 65
        Me.SelectorSwitch2.Text = "Plant Power"
        Me.SelectorSwitch2.Value = False
        '
        'SelectorSwitch3Pos1
        '
        Me.SelectorSwitch3Pos1.BackgroundImage = CType(resources.GetObject("SelectorSwitch3Pos1.BackgroundImage"), System.Drawing.Image)
        Me.SelectorSwitch3Pos1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SelectorSwitch3Pos1.ComComponent = Me.ModbusTCPCom1
        Me.SelectorSwitch3Pos1.LegendPlate = MfgControl.AdvancedHMI.Controls.SelectorSwitch3Pos.LegendPlates.Large
        Me.SelectorSwitch3Pos1.Location = New System.Drawing.Point(180, 115)
        Me.SelectorSwitch3Pos1.Name = "SelectorSwitch3Pos1"
        Me.SelectorSwitch3Pos1.PLCAddressClickLeft = "00002"
        Me.SelectorSwitch3Pos1.PLCAddressClickRight = "00004"
        Me.SelectorSwitch3Pos1.PLCAddressText = ""
        Me.SelectorSwitch3Pos1.PLCAddressValueLeft = "00002"
        Me.SelectorSwitch3Pos1.PLCAddressValueRight = "00004"
        Me.SelectorSwitch3Pos1.PLCAddressVisible = ""
        Me.SelectorSwitch3Pos1.Size = New System.Drawing.Size(89, 130)
        Me.SelectorSwitch3Pos1.TabIndex = 57
        Me.SelectorSwitch3Pos1.Text = "Train Direction"
        Me.SelectorSwitch3Pos1.Value = 1
        Me.SelectorSwitch3Pos1.ValueLeft = False
        Me.SelectorSwitch3Pos1.ValueOfCenterPosition = 0
        Me.SelectorSwitch3Pos1.ValueOfLeftPosition = -1
        Me.SelectorSwitch3Pos1.ValueOfRightPosition = 1
        Me.SelectorSwitch3Pos1.ValueRight = True
        '
        'SelectorSwitch1
        '
        Me.SelectorSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.SelectorSwitch1.BackgroundImage = CType(resources.GetObject("SelectorSwitch1.BackgroundImage"), System.Drawing.Image)
        Me.SelectorSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SelectorSwitch1.ComComponent = Me.ModbusTCPCom1
        Me.SelectorSwitch1.LegendPlate = MfgControl.AdvancedHMI.Controls.SelectorSwitch.LegendPlates.Large
        Me.SelectorSwitch1.Location = New System.Drawing.Point(91, 115)
        Me.SelectorSwitch1.Name = "SelectorSwitch1"
        Me.SelectorSwitch1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SelectorSwitch1.PLCAddressClick = "00008"
        Me.SelectorSwitch1.PLCAddressText = ""
        Me.SelectorSwitch1.PLCAddressValue = "00008"
        Me.SelectorSwitch1.PLCAddressVisible = ""
        Me.SelectorSwitch1.Size = New System.Drawing.Size(89, 130)
        Me.SelectorSwitch1.TabIndex = 56
        Me.SelectorSwitch1.Text = "Train Power"
        Me.SelectorSwitch1.Value = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(-59, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(384, 84)
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'OrientedTextLabel1
        '
        Me.OrientedTextLabel1.BackColor = System.Drawing.Color.Black
        Me.OrientedTextLabel1.ForeColor = System.Drawing.Color.White
        Me.OrientedTextLabel1.Location = New System.Drawing.Point(590, 380)
        Me.OrientedTextLabel1.Name = "OrientedTextLabel1"
        Me.OrientedTextLabel1.RotationAngle = 0R
        Me.OrientedTextLabel1.Size = New System.Drawing.Size(100, 13)
        Me.OrientedTextLabel1.TabIndex = 77
        Me.OrientedTextLabel1.Text = "Time"
        Me.OrientedTextLabel1.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel1.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'OrientedTextLabel2
        '
        Me.OrientedTextLabel2.BackColor = System.Drawing.Color.Black
        Me.OrientedTextLabel2.ForeColor = System.Drawing.Color.White
        Me.OrientedTextLabel2.Location = New System.Drawing.Point(536, 286)
        Me.OrientedTextLabel2.Name = "OrientedTextLabel2"
        Me.OrientedTextLabel2.RotationAngle = -90.0R
        Me.OrientedTextLabel2.Size = New System.Drawing.Size(18, 87)
        Me.OrientedTextLabel2.TabIndex = 78
        Me.OrientedTextLabel2.Text = "Temp"
        Me.OrientedTextLabel2.TextDirection = AdvancedHMIControls.OrientedTextLabel.Direction.Clockwise
        Me.OrientedTextLabel2.TextOrientation = AdvancedHMIControls.OrientedTextLabel.Orientation.Rotate
        '
        'SelectorSwitch3
        '
        Me.SelectorSwitch3.BackColor = System.Drawing.Color.Transparent
        Me.SelectorSwitch3.BackgroundImage = CType(resources.GetObject("SelectorSwitch3.BackgroundImage"), System.Drawing.Image)
        Me.SelectorSwitch3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SelectorSwitch3.ComComponent = Me.ModbusTCPCom1
        Me.SelectorSwitch3.LegendPlate = MfgControl.AdvancedHMI.Controls.SelectorSwitch.LegendPlates.Large
        Me.SelectorSwitch3.Location = New System.Drawing.Point(447, 115)
        Me.SelectorSwitch3.Name = "SelectorSwitch3"
        Me.SelectorSwitch3.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SelectorSwitch3.PLCAddressClick = "000015"
        Me.SelectorSwitch3.PLCAddressText = ""
        Me.SelectorSwitch3.PLCAddressValue = "000015"
        Me.SelectorSwitch3.PLCAddressVisible = ""
        Me.SelectorSwitch3.Size = New System.Drawing.Size(89, 130)
        Me.SelectorSwitch3.TabIndex = 79
        Me.SelectorSwitch3.Text = "Read Temp"
        Me.SelectorSwitch3.Value = False
        '
        'SelectorSwitch4
        '
        Me.SelectorSwitch4.BackColor = System.Drawing.Color.Transparent
        Me.SelectorSwitch4.BackgroundImage = CType(resources.GetObject("SelectorSwitch4.BackgroundImage"), System.Drawing.Image)
        Me.SelectorSwitch4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.SelectorSwitch4.ComComponent = Me.ModbusTCPCom1
        Me.SelectorSwitch4.LegendPlate = MfgControl.AdvancedHMI.Controls.SelectorSwitch.LegendPlates.Large
        Me.SelectorSwitch4.Location = New System.Drawing.Point(447, 264)
        Me.SelectorSwitch4.Name = "SelectorSwitch4"
        Me.SelectorSwitch4.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.Toggle
        Me.SelectorSwitch4.PLCAddressClick = "000012"
        Me.SelectorSwitch4.PLCAddressText = ""
        Me.SelectorSwitch4.PLCAddressValue = "000012"
        Me.SelectorSwitch4.PLCAddressVisible = ""
        Me.SelectorSwitch4.Size = New System.Drawing.Size(89, 130)
        Me.SelectorSwitch4.TabIndex = 80
        Me.SelectorSwitch4.Text = "Auto Mode"
        Me.SelectorSwitch4.Value = False
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.SelectorSwitch4)
        Me.Controls.Add(Me.SelectorSwitch3)
        Me.Controls.Add(Me.OrientedTextLabel2)
        Me.Controls.Add(Me.OrientedTextLabel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BasicTrendChart2)
        Me.Controls.Add(Me.PilotLight3Color6)
        Me.Controls.Add(Me.PilotLight3Color5)
        Me.Controls.Add(Me.SelectorSwitch2)
        Me.Controls.Add(Me.PilotLight3Color4)
        Me.Controls.Add(Me.PilotLight3Color2)
        Me.Controls.Add(Me.PilotLight3Color3)
        Me.Controls.Add(Me.PilotLight3Color1)
        Me.Controls.Add(Me.SelectorSwitch3Pos1)
        Me.Controls.Add(Me.SelectorSwitch1)
        Me.Controls.Add(Me.PilotLight1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TempController1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rowan Supervisory Control and Data Acquisition Test Bed"
        CType(Me.ModbusTCPCom1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents PilotLight1 As AdvancedHMIControls.PilotLight
    Friend WithEvents ModbusTCPCom1 As AdvancedHMIDrivers.ModbusTCPCom
    Friend WithEvents SelectorSwitch1 As AdvancedHMIControls.SelectorSwitch
    Friend WithEvents SelectorSwitch3Pos1 As AdvancedHMIControls.SelectorSwitch3Pos
    Friend WithEvents PilotLight3Color1 As AdvancedHMIControls.PilotLight3Color
    Friend WithEvents PilotLight3Color3 As AdvancedHMIControls.PilotLight3Color
    Friend WithEvents PilotLight3Color2 As AdvancedHMIControls.PilotLight3Color
    Friend WithEvents PilotLight3Color4 As AdvancedHMIControls.PilotLight3Color
    Friend WithEvents SelectorSwitch2 As AdvancedHMIControls.SelectorSwitch
    Friend WithEvents PilotLight3Color5 As AdvancedHMIControls.PilotLight3Color
    Friend WithEvents PilotLight3Color6 As AdvancedHMIControls.PilotLight3Color
    Friend WithEvents BasicTrendChart2 As AdvancedHMIControls.BasicTrendChart
    Friend WithEvents TempController1 As AdvancedHMIControls.TempController
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents OrientedTextLabel1 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents OrientedTextLabel2 As AdvancedHMIControls.OrientedTextLabel
    Friend WithEvents SelectorSwitch3 As AdvancedHMIControls.SelectorSwitch
    Friend WithEvents SelectorSwitch4 As AdvancedHMIControls.SelectorSwitch
End Class
