<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.numMinValue = New System.Windows.Forms.NumericUpDown
        Me.numMaxValue = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.trbValue = New System.Windows.Forms.TrackBar
        Me.Label3 = New System.Windows.Forms.Label
        Me.optOne = New System.Windows.Forms.RadioButton
        Me.optTwo = New System.Windows.Forms.RadioButton
        Me.optThree = New System.Windows.Forms.RadioButton
        Me.chkDrawThresholds = New System.Windows.Forms.CheckBox
        Me.trbThreshold2 = New System.Windows.Forms.TrackBar
        Me.trbThreshold3 = New System.Windows.Forms.TrackBar
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblValue = New System.Windows.Forms.Label
        Me.lblThreshold2 = New System.Windows.Forms.Label
        Me.lblThreshold3 = New System.Windows.Forms.Label
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.NeroBarToolStripItem1 = New JCS.Components.NeroBarToolStripItem
        Me.chkColorThresholds = New System.Windows.Forms.CheckBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblGlowColor = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.numSpeed = New System.Windows.Forms.NumericUpDown
        Me.numPause = New System.Windows.Forms.NumericUpDown
        Me.cmbGlowMode = New System.Windows.Forms.ComboBox
        Me.chkShowPercent = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblColorPercentage = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.lblColorSegment1 = New System.Windows.Forms.Label
        Me.lblColorSegment2 = New System.Windows.Forms.Label
        Me.lblColorSegment3 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbPercentageBasedOn = New System.Windows.Forms.ComboBox
        Me.chkRightToLeft = New System.Windows.Forms.CheckBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbChangeMode = New System.Windows.Forms.ComboBox
        Me.btnDemo1 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.lnkHigherThanMax = New System.Windows.Forms.LinkLabel
        Me.NeroBar1 = New JCS.Components.NeroBar
        CType(Me.numMinValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMaxValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbValue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbThreshold2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trbThreshold3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.numSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPause, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'numMinValue
        '
        Me.numMinValue.Location = New System.Drawing.Point(14, 93)
        Me.numMinValue.Name = "numMinValue"
        Me.numMinValue.Size = New System.Drawing.Size(53, 20)
        Me.numMinValue.TabIndex = 1
        '
        'numMaxValue
        '
        Me.numMaxValue.Location = New System.Drawing.Point(511, 93)
        Me.numMaxValue.Name = "numMaxValue"
        Me.numMaxValue.Size = New System.Drawing.Size(53, 20)
        Me.numMaxValue.TabIndex = 2
        Me.numMaxValue.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Minimum:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(508, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Maximum:"
        '
        'trbValue
        '
        Me.trbValue.Location = New System.Drawing.Point(73, 68)
        Me.trbValue.Maximum = 100
        Me.trbValue.Name = "trbValue"
        Me.trbValue.Size = New System.Drawing.Size(429, 45)
        Me.trbValue.TabIndex = 5
        Me.trbValue.Value = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Number of Segments:"
        '
        'optOne
        '
        Me.optOne.AutoSize = True
        Me.optOne.Location = New System.Drawing.Point(144, 201)
        Me.optOne.Name = "optOne"
        Me.optOne.Size = New System.Drawing.Size(45, 17)
        Me.optOne.TabIndex = 7
        Me.optOne.Text = "One"
        Me.optOne.UseVisualStyleBackColor = True
        '
        'optTwo
        '
        Me.optTwo.AutoSize = True
        Me.optTwo.Location = New System.Drawing.Point(195, 201)
        Me.optTwo.Name = "optTwo"
        Me.optTwo.Size = New System.Drawing.Size(46, 17)
        Me.optTwo.TabIndex = 8
        Me.optTwo.Text = "Two"
        Me.optTwo.UseVisualStyleBackColor = True
        '
        'optThree
        '
        Me.optThree.AutoSize = True
        Me.optThree.Checked = True
        Me.optThree.Location = New System.Drawing.Point(247, 201)
        Me.optThree.Name = "optThree"
        Me.optThree.Size = New System.Drawing.Size(53, 17)
        Me.optThree.TabIndex = 9
        Me.optThree.TabStop = True
        Me.optThree.Text = "Three"
        Me.optThree.UseVisualStyleBackColor = True
        '
        'chkDrawThresholds
        '
        Me.chkDrawThresholds.AutoSize = True
        Me.chkDrawThresholds.Checked = True
        Me.chkDrawThresholds.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDrawThresholds.Location = New System.Drawing.Point(330, 203)
        Me.chkDrawThresholds.Name = "chkDrawThresholds"
        Me.chkDrawThresholds.Size = New System.Drawing.Size(106, 17)
        Me.chkDrawThresholds.TabIndex = 16
        Me.chkDrawThresholds.Text = "Draw Thresholds"
        Me.chkDrawThresholds.UseVisualStyleBackColor = True
        '
        'trbThreshold2
        '
        Me.trbThreshold2.Location = New System.Drawing.Point(73, 132)
        Me.trbThreshold2.Maximum = 100
        Me.trbThreshold2.Name = "trbThreshold2"
        Me.trbThreshold2.Size = New System.Drawing.Size(429, 45)
        Me.trbThreshold2.TabIndex = 17
        Me.trbThreshold2.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trbThreshold2.Value = 80
        '
        'trbThreshold3
        '
        Me.trbThreshold3.Location = New System.Drawing.Point(73, 175)
        Me.trbThreshold3.Maximum = 100
        Me.trbThreshold3.Name = "trbThreshold3"
        Me.trbThreshold3.Size = New System.Drawing.Size(429, 45)
        Me.trbThreshold3.TabIndex = 18
        Me.trbThreshold3.TickStyle = System.Windows.Forms.TickStyle.None
        Me.trbThreshold3.Value = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(77, 116)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Second segment lower threshold:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(77, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Third segment lower threshold:"
        '
        'lblValue
        '
        Me.lblValue.Location = New System.Drawing.Point(230, 9)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(108, 20)
        Me.lblValue.TabIndex = 21
        Me.lblValue.Text = "Value: 50"
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblThreshold2
        '
        Me.lblThreshold2.AutoSize = True
        Me.lblThreshold2.Location = New System.Drawing.Point(260, 116)
        Me.lblThreshold2.Name = "lblThreshold2"
        Me.lblThreshold2.Size = New System.Drawing.Size(19, 13)
        Me.lblThreshold2.TabIndex = 22
        Me.lblThreshold2.Text = "80"
        '
        'lblThreshold3
        '
        Me.lblThreshold3.AutoSize = True
        Me.lblThreshold3.Location = New System.Drawing.Point(260, 159)
        Me.lblThreshold3.Name = "lblThreshold3"
        Me.lblThreshold3.Size = New System.Drawing.Size(19, 13)
        Me.lblThreshold3.TabIndex = 23
        Me.lblThreshold3.Text = "90"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.NeroBarToolStripItem1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 548)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(575, 22)
        Me.StatusStrip1.TabIndex = 24
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(162, 17)
        Me.ToolStripStatusLabel1.Text = "Check out the NeroBar here:  "
        '
        'NeroBarToolStripItem1
        '
        Me.NeroBarToolStripItem1.BackColor = System.Drawing.Color.Transparent
        Me.NeroBarToolStripItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle))
        Me.NeroBarToolStripItem1.Name = "NeroBarToolStripItem1"
        Me.NeroBarToolStripItem1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
        Me.NeroBarToolStripItem1.PercentageBasedOn = JCS.Components.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.NeroBarToolStripItem1.Size = New System.Drawing.Size(100, 20)
        Me.NeroBarToolStripItem1.Text = "NeroBarToolStripItem1"
        Me.NeroBarToolStripItem1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.NeroBarToolStripItem1.Value = 50
        '
        'chkColorThresholds
        '
        Me.chkColorThresholds.AutoSize = True
        Me.chkColorThresholds.Location = New System.Drawing.Point(442, 203)
        Me.chkColorThresholds.Name = "chkColorThresholds"
        Me.chkColorThresholds.Size = New System.Drawing.Size(105, 17)
        Me.chkColorThresholds.TabIndex = 25
        Me.chkColorThresholds.Text = "Color Thresholds"
        Me.chkColorThresholds.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(30, 320)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Glow Mode:"
        '
        'lblGlowColor
        '
        Me.lblGlowColor.BackColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblGlowColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGlowColor.ForeColor = System.Drawing.Color.Black
        Me.lblGlowColor.Location = New System.Drawing.Point(416, 342)
        Me.lblGlowColor.Name = "lblGlowColor"
        Me.lblGlowColor.Size = New System.Drawing.Size(131, 21)
        Me.lblGlowColor.TabIndex = 31
        Me.lblGlowColor.Text = "Click To Change"
        Me.lblGlowColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(413, 320)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "Glow Color:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(184, 320)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Glow Speed:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(289, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "Glow Pause:"
        '
        'numSpeed
        '
        Me.numSpeed.Location = New System.Drawing.Point(187, 342)
        Me.numSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numSpeed.Name = "numSpeed"
        Me.numSpeed.Size = New System.Drawing.Size(94, 20)
        Me.numSpeed.TabIndex = 35
        Me.numSpeed.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'numPause
        '
        Me.numPause.Location = New System.Drawing.Point(292, 342)
        Me.numPause.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numPause.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numPause.Name = "numPause"
        Me.numPause.Size = New System.Drawing.Size(94, 20)
        Me.numPause.TabIndex = 36
        Me.numPause.Value = New Decimal(New Integer() {5000, 0, 0, 0})
        '
        'cmbGlowMode
        '
        Me.cmbGlowMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGlowMode.FormattingEnabled = True
        Me.cmbGlowMode.Items.AddRange(New Object() {"Off", "Progress Only", "Entire Bar"})
        Me.cmbGlowMode.Location = New System.Drawing.Point(33, 342)
        Me.cmbGlowMode.Name = "cmbGlowMode"
        Me.cmbGlowMode.Size = New System.Drawing.Size(121, 21)
        Me.cmbGlowMode.TabIndex = 37
        '
        'chkShowPercent
        '
        Me.chkShowPercent.AutoSize = True
        Me.chkShowPercent.Location = New System.Drawing.Point(34, 382)
        Me.chkShowPercent.Name = "chkShowPercent"
        Me.chkShowPercent.Size = New System.Drawing.Size(205, 17)
        Me.chkShowPercent.TabIndex = 38
        Me.chkShowPercent.Text = "Show Progress Percentage based on:"
        Me.chkShowPercent.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(416, 383)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Percentage Text Color:"
        '
        'lblColorPercentage
        '
        Me.lblColorPercentage.BackColor = System.Drawing.SystemColors.ControlText
        Me.lblColorPercentage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColorPercentage.ForeColor = System.Drawing.Color.White
        Me.lblColorPercentage.Location = New System.Drawing.Point(417, 411)
        Me.lblColorPercentage.Name = "lblColorPercentage"
        Me.lblColorPercentage.Size = New System.Drawing.Size(131, 21)
        Me.lblColorPercentage.TabIndex = 40
        Me.lblColorPercentage.Text = "Click To Change"
        Me.lblColorPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(416, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Color of Segment 3:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(222, 266)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Color of Segment 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 266)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Color of Segment 1:"
        '
        'lblColorSegment1
        '
        Me.lblColorSegment1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.lblColorSegment1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColorSegment1.ForeColor = System.Drawing.Color.White
        Me.lblColorSegment1.Location = New System.Drawing.Point(32, 288)
        Me.lblColorSegment1.Name = "lblColorSegment1"
        Me.lblColorSegment1.Size = New System.Drawing.Size(131, 21)
        Me.lblColorSegment1.TabIndex = 49
        Me.lblColorSegment1.Text = "Click To Change"
        Me.lblColorSegment1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColorSegment2
        '
        Me.lblColorSegment2.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblColorSegment2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColorSegment2.ForeColor = System.Drawing.Color.White
        Me.lblColorSegment2.Location = New System.Drawing.Point(223, 288)
        Me.lblColorSegment2.Name = "lblColorSegment2"
        Me.lblColorSegment2.Size = New System.Drawing.Size(131, 21)
        Me.lblColorSegment2.TabIndex = 48
        Me.lblColorSegment2.Text = "Click To Change"
        Me.lblColorSegment2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblColorSegment3
        '
        Me.lblColorSegment3.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblColorSegment3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblColorSegment3.ForeColor = System.Drawing.Color.White
        Me.lblColorSegment3.Location = New System.Drawing.Point(416, 288)
        Me.lblColorSegment3.Name = "lblColorSegment3"
        Me.lblColorSegment3.Size = New System.Drawing.Size(131, 21)
        Me.lblColorSegment3.TabIndex = 47
        Me.lblColorSegment3.Text = "Click To Change"
        Me.lblColorSegment3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Label14.Location = New System.Drawing.Point(0, 512)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(575, 36)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = resources.GetString("Label14.Text")
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbPercentageBasedOn
        '
        Me.cmbPercentageBasedOn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPercentageBasedOn.Enabled = False
        Me.cmbPercentageBasedOn.FormattingEnabled = True
        Me.cmbPercentageBasedOn.Items.AddRange(New Object() {"Segment 1", "Segments 1&2", "Whole Control"})
        Me.cmbPercentageBasedOn.Location = New System.Drawing.Point(245, 380)
        Me.cmbPercentageBasedOn.Name = "cmbPercentageBasedOn"
        Me.cmbPercentageBasedOn.Size = New System.Drawing.Size(141, 21)
        Me.cmbPercentageBasedOn.TabIndex = 51
        '
        'chkRightToLeft
        '
        Me.chkRightToLeft.AutoSize = True
        Me.chkRightToLeft.Location = New System.Drawing.Point(32, 233)
        Me.chkRightToLeft.Name = "chkRightToLeft"
        Me.chkRightToLeft.Size = New System.Drawing.Size(88, 17)
        Me.chkRightToLeft.TabIndex = 52
        Me.chkRightToLeft.Text = "Right To Left"
        Me.chkRightToLeft.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(218, 237)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 13)
        Me.Label15.TabIndex = 53
        Me.Label15.Text = "Color Change Mode:"
        '
        'cmbChangeMode
        '
        Me.cmbChangeMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChangeMode.FormattingEnabled = True
        Me.cmbChangeMode.Items.AddRange(New Object() {"Segments", "Whole Bar"})
        Me.cmbChangeMode.Location = New System.Drawing.Point(333, 234)
        Me.cmbChangeMode.Name = "cmbChangeMode"
        Me.cmbChangeMode.Size = New System.Drawing.Size(141, 21)
        Me.cmbChangeMode.TabIndex = 54
        '
        'btnDemo1
        '
        Me.btnDemo1.Location = New System.Drawing.Point(29, 451)
        Me.btnDemo1.Name = "btnDemo1"
        Me.btnDemo1.Size = New System.Drawing.Size(518, 23)
        Me.btnDemo1.TabIndex = 55
        Me.btnDemo1.Text = "Show count up demo using ColorChangeMode=WholeBar"
        Me.btnDemo1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 480)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(515, 23)
        Me.Button1.TabIndex = 56
        Me.Button1.Text = "Show count down demo using ColorChangeMode=WholeBar and RightToLeft=True"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lnkHigherThanMax
        '
        Me.lnkHigherThanMax.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkHigherThanMax.AutoSize = True
        Me.lnkHigherThanMax.Enabled = False
        Me.lnkHigherThanMax.Location = New System.Drawing.Point(31, 415)
        Me.lnkHigherThanMax.Name = "lnkHigherThanMax"
        Me.lnkHigherThanMax.Size = New System.Drawing.Size(286, 13)
        Me.lnkHigherThanMax.TabIndex = 57
        Me.lnkHigherThanMax.TabStop = True
        Me.lnkHigherThanMax.Text = "Try setting NeroBar value to a value higher than MaxValue!"
        Me.lnkHigherThanMax.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'NeroBar1
        '
        Me.NeroBar1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.NeroBar1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.NeroBar1.BackColor = System.Drawing.Color.Transparent
        Me.NeroBar1.ColorChangeMode = JCS.Components.NeroBar.NeroBarColorChangeModes.WholeBar
        Me.NeroBar1.Location = New System.Drawing.Point(80, 32)
        Me.NeroBar1.Name = "NeroBar1"
        Me.NeroBar1.PercentageBasedOn = JCS.Components.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.NeroBar1.Size = New System.Drawing.Size(411, 21)
        Me.NeroBar1.TabIndex = 0
        Me.NeroBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.NeroBar1.Value = 50
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(575, 570)
        Me.Controls.Add(Me.lnkHigherThanMax)
        Me.Controls.Add(Me.chkDrawThresholds)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDemo1)
        Me.Controls.Add(Me.cmbChangeMode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.chkRightToLeft)
        Me.Controls.Add(Me.cmbPercentageBasedOn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.lblColorSegment1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblColorPercentage)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkShowPercent)
        Me.Controls.Add(Me.cmbGlowMode)
        Me.Controls.Add(Me.numPause)
        Me.Controls.Add(Me.numSpeed)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblGlowColor)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.chkColorThresholds)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblThreshold3)
        Me.Controls.Add(Me.lblThreshold2)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.trbThreshold2)
        Me.Controls.Add(Me.optThree)
        Me.Controls.Add(Me.optTwo)
        Me.Controls.Add(Me.optOne)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.trbValue)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numMaxValue)
        Me.Controls.Add(Me.numMinValue)
        Me.Controls.Add(Me.NeroBar1)
        Me.Controls.Add(Me.trbThreshold3)
        Me.Controls.Add(Me.lblColorSegment2)
        Me.Controls.Add(Me.lblColorSegment3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "JCS NeroBar Demo Application"
        CType(Me.numMinValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMaxValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbValue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbThreshold2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trbThreshold3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.numSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPause, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NeroBar1 As JCS.Components.NeroBar
    Friend WithEvents numMinValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents numMaxValue As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trbValue As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents optOne As System.Windows.Forms.RadioButton
    Friend WithEvents optTwo As System.Windows.Forms.RadioButton
    Friend WithEvents optThree As System.Windows.Forms.RadioButton
    Friend WithEvents chkDrawThresholds As System.Windows.Forms.CheckBox
    Friend WithEvents trbThreshold2 As System.Windows.Forms.TrackBar
    Friend WithEvents trbThreshold3 As System.Windows.Forms.TrackBar
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents lblThreshold2 As System.Windows.Forms.Label
    Friend WithEvents lblThreshold3 As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents NeroBarToolStripItem1 As JCS.Components.NeroBarToolStripItem
    Friend WithEvents chkColorThresholds As System.Windows.Forms.CheckBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblGlowColor As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents numSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents numPause As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbGlowMode As System.Windows.Forms.ComboBox
    Friend WithEvents chkShowPercent As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblColorPercentage As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblColorSegment1 As System.Windows.Forms.Label
    Friend WithEvents lblColorSegment2 As System.Windows.Forms.Label
    Friend WithEvents lblColorSegment3 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbPercentageBasedOn As System.Windows.Forms.ComboBox
    Friend WithEvents chkRightToLeft As System.Windows.Forms.CheckBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbChangeMode As System.Windows.Forms.ComboBox
    Friend WithEvents btnDemo1 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lnkHigherThanMax As System.Windows.Forms.LinkLabel

End Class
