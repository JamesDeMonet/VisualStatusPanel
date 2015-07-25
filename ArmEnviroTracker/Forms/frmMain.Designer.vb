<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.pbxEnviroment = New System.Windows.Forms.PictureBox()
        Me.cmsRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblVoteTms = New System.Windows.Forms.Label()
        Me.lblVoteTmc = New System.Windows.Forms.Label()
        Me.lblTimeLabel = New System.Windows.Forms.Label()
        Me.nerStat1 = New JCS.Components.NeroBar()
        Me.nerStat2 = New JCS.Components.NeroBar()
        Me.nerStat3 = New JCS.Components.NeroBar()
        Me.nerStat4 = New JCS.Components.NeroBar()
        Me.lblHealth = New System.Windows.Forms.Label()
        Me.lblStam = New System.Windows.Forms.Label()
        Me.lblStun = New System.Windows.Forms.Label()
        Me.lblMana = New System.Windows.Forms.Label()
        Me.lblClanPayTimer = New System.Windows.Forms.Label()
        Me.lnklblPayUpdate = New System.Windows.Forms.LinkLabel()
        CType(Me.pbxEnviroment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsRightClick.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbxEnviroment
        '
        Me.pbxEnviroment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbxEnviroment.BackColor = System.Drawing.SystemColors.Control
        Me.pbxEnviroment.Enabled = False
        Me.pbxEnviroment.Location = New System.Drawing.Point(0, 1)
        Me.pbxEnviroment.Name = "pbxEnviroment"
        Me.pbxEnviroment.Size = New System.Drawing.Size(348, 442)
        Me.pbxEnviroment.TabIndex = 0
        Me.pbxEnviroment.TabStop = False
        Me.pbxEnviroment.Visible = False
        '
        'cmsRightClick
        '
        Me.cmsRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.cmsRightClick.Name = "cmsRightClick"
        Me.cmsRightClick.Size = New System.Drawing.Size(117, 54)
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(113, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'lblVoteTms
        '
        Me.lblVoteTms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVoteTms.AutoSize = True
        Me.lblVoteTms.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblVoteTms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblVoteTms.Enabled = False
        Me.lblVoteTms.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoteTms.ForeColor = System.Drawing.Color.White
        Me.lblVoteTms.Location = New System.Drawing.Point(229, 9)
        Me.lblVoteTms.Name = "lblVoteTms"
        Me.lblVoteTms.Size = New System.Drawing.Size(107, 25)
        Me.lblVoteTms.TabIndex = 2
        Me.lblVoteTms.Text = "Vote TMS"
        Me.lblVoteTms.Visible = False
        '
        'lblVoteTmc
        '
        Me.lblVoteTmc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVoteTmc.AutoSize = True
        Me.lblVoteTmc.BackColor = System.Drawing.Color.Black
        Me.lblVoteTmc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblVoteTmc.Enabled = False
        Me.lblVoteTmc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoteTmc.ForeColor = System.Drawing.Color.Red
        Me.lblVoteTmc.Location = New System.Drawing.Point(229, 40)
        Me.lblVoteTmc.Name = "lblVoteTmc"
        Me.lblVoteTmc.Size = New System.Drawing.Size(108, 25)
        Me.lblVoteTmc.TabIndex = 3
        Me.lblVoteTmc.Text = "Vote TMC"
        Me.lblVoteTmc.Visible = False
        '
        'lblTimeLabel
        '
        Me.lblTimeLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTimeLabel.BackColor = System.Drawing.SystemColors.Control
        Me.lblTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeLabel.Location = New System.Drawing.Point(12, 131)
        Me.lblTimeLabel.Name = "lblTimeLabel"
        Me.lblTimeLabel.Size = New System.Drawing.Size(324, 23)
        Me.lblTimeLabel.TabIndex = 5
        Me.lblTimeLabel.Text = "Time"
        Me.lblTimeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nerStat1
        '
        Me.nerStat1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.nerStat1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.nerStat1.BackColor = System.Drawing.Color.Transparent
        Me.nerStat1.ColorChangeMode = JCS.Components.NeroBar.NeroBarColorChangeModes.WholeBar
        Me.nerStat1.Location = New System.Drawing.Point(78, 244)
        Me.nerStat1.Name = "nerStat1"
        Me.nerStat1.PercentageBasedOn = JCS.Components.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.nerStat1.Segment1Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nerStat1.Segment2StartThreshold = 30.0R
        Me.nerStat1.Segment3Color = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.nerStat1.Segment3StartThreshold = 60.0R
        Me.nerStat1.Size = New System.Drawing.Size(192, 23)
        Me.nerStat1.TabIndex = 0
        Me.nerStat1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nerStat1.Value = 50.0R
        '
        'nerStat2
        '
        Me.nerStat2.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.nerStat2.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.nerStat2.BackColor = System.Drawing.Color.Transparent
        Me.nerStat2.ColorChangeMode = JCS.Components.NeroBar.NeroBarColorChangeModes.WholeBar
        Me.nerStat2.Location = New System.Drawing.Point(78, 273)
        Me.nerStat2.Name = "nerStat2"
        Me.nerStat2.PercentageBasedOn = JCS.Components.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.nerStat2.Segment1Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nerStat2.Segment2StartThreshold = 30.0R
        Me.nerStat2.Segment3Color = System.Drawing.Color.Aqua
        Me.nerStat2.Segment3StartThreshold = 60.0R
        Me.nerStat2.Size = New System.Drawing.Size(192, 23)
        Me.nerStat2.TabIndex = 0
        Me.nerStat2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nerStat2.Value = 50.0R
        '
        'nerStat3
        '
        Me.nerStat3.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.nerStat3.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.nerStat3.BackColor = System.Drawing.Color.Transparent
        Me.nerStat3.ColorChangeMode = JCS.Components.NeroBar.NeroBarColorChangeModes.WholeBar
        Me.nerStat3.Location = New System.Drawing.Point(78, 302)
        Me.nerStat3.Name = "nerStat3"
        Me.nerStat3.PercentageBasedOn = JCS.Components.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.nerStat3.Segment1Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nerStat3.Segment2StartThreshold = 30.0R
        Me.nerStat3.Segment3Color = System.Drawing.Color.Blue
        Me.nerStat3.Segment3StartThreshold = 60.0R
        Me.nerStat3.Size = New System.Drawing.Size(192, 23)
        Me.nerStat3.TabIndex = 0
        Me.nerStat3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nerStat3.Value = 50.0R
        '
        'nerStat4
        '
        Me.nerStat4.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.nerStat4.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.nerStat4.BackColor = System.Drawing.Color.Transparent
        Me.nerStat4.ColorChangeMode = JCS.Components.NeroBar.NeroBarColorChangeModes.WholeBar
        Me.nerStat4.Location = New System.Drawing.Point(78, 331)
        Me.nerStat4.Name = "nerStat4"
        Me.nerStat4.PercentageBasedOn = JCS.Components.NeroBar.NeroBarPercentageCalculationModes.WholeControl
        Me.nerStat4.Segment1Color = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.nerStat4.Segment2StartThreshold = 30.0R
        Me.nerStat4.Segment3Color = System.Drawing.Color.DarkViolet
        Me.nerStat4.Segment3StartThreshold = 60.0R
        Me.nerStat4.Size = New System.Drawing.Size(192, 23)
        Me.nerStat4.TabIndex = 0
        Me.nerStat4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nerStat4.Value = 50.0R
        '
        'lblHealth
        '
        Me.lblHealth.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHealth.BackColor = System.Drawing.Color.Transparent
        Me.lblHealth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHealth.Location = New System.Drawing.Point(90, 244)
        Me.lblHealth.Name = "lblHealth"
        Me.lblHealth.Size = New System.Drawing.Size(168, 23)
        Me.lblHealth.TabIndex = 10
        Me.lblHealth.Text = "/"
        Me.lblHealth.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStam
        '
        Me.lblStam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStam.BackColor = System.Drawing.Color.Transparent
        Me.lblStam.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStam.Location = New System.Drawing.Point(90, 273)
        Me.lblStam.Name = "lblStam"
        Me.lblStam.Size = New System.Drawing.Size(168, 23)
        Me.lblStam.TabIndex = 11
        Me.lblStam.Text = "/"
        Me.lblStam.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblStun
        '
        Me.lblStun.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblStun.BackColor = System.Drawing.Color.Transparent
        Me.lblStun.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStun.Location = New System.Drawing.Point(90, 302)
        Me.lblStun.Name = "lblStun"
        Me.lblStun.Size = New System.Drawing.Size(168, 23)
        Me.lblStun.TabIndex = 12
        Me.lblStun.Text = "/"
        Me.lblStun.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblMana
        '
        Me.lblMana.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMana.BackColor = System.Drawing.Color.Transparent
        Me.lblMana.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMana.Location = New System.Drawing.Point(90, 331)
        Me.lblMana.Name = "lblMana"
        Me.lblMana.Size = New System.Drawing.Size(168, 23)
        Me.lblMana.TabIndex = 13
        Me.lblMana.Text = "/"
        Me.lblMana.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblClanPayTimer
        '
        Me.lblClanPayTimer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblClanPayTimer.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.lblClanPayTimer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblClanPayTimer.Enabled = False
        Me.lblClanPayTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClanPayTimer.ForeColor = System.Drawing.Color.Black
        Me.lblClanPayTimer.Location = New System.Drawing.Point(11, 9)
        Me.lblClanPayTimer.Name = "lblClanPayTimer"
        Me.lblClanPayTimer.Size = New System.Drawing.Size(118, 25)
        Me.lblClanPayTimer.TabIndex = 14
        Me.lblClanPayTimer.Text = "Pay: Days"
        Me.lblClanPayTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblClanPayTimer.Visible = False
        '
        'lnklblPayUpdate
        '
        Me.lnklblPayUpdate.AutoSize = True
        Me.lnklblPayUpdate.Location = New System.Drawing.Point(76, 32)
        Me.lnklblPayUpdate.Name = "lnklblPayUpdate"
        Me.lnklblPayUpdate.Size = New System.Drawing.Size(42, 13)
        Me.lnklblPayUpdate.TabIndex = 15
        Me.lnklblPayUpdate.TabStop = True
        Me.lnklblPayUpdate.Text = "Update"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(348, 441)
        Me.Controls.Add(Me.lnklblPayUpdate)
        Me.Controls.Add(Me.lblClanPayTimer)
        Me.Controls.Add(Me.lblMana)
        Me.Controls.Add(Me.lblStun)
        Me.Controls.Add(Me.lblStam)
        Me.Controls.Add(Me.lblHealth)
        Me.Controls.Add(Me.nerStat1)
        Me.Controls.Add(Me.nerStat2)
        Me.Controls.Add(Me.nerStat3)
        Me.Controls.Add(Me.nerStat4)
        Me.Controls.Add(Me.lblTimeLabel)
        Me.Controls.Add(Me.lblVoteTmc)
        Me.Controls.Add(Me.lblVoteTms)
        Me.Controls.Add(Me.pbxEnviroment)
        Me.Name = "frmMain"
        Me.Text = "Visual Status Bar"
        CType(Me.pbxEnviroment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsRightClick.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbxEnviroment As System.Windows.Forms.PictureBox
    Friend WithEvents cmsRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVoteTms As System.Windows.Forms.Label
    Friend WithEvents lblVoteTmc As System.Windows.Forms.Label
    Friend WithEvents lblTimeLabel As System.Windows.Forms.Label
    Friend WithEvents lblHealth As System.Windows.Forms.Label
    Friend WithEvents lblStam As System.Windows.Forms.Label
    Friend WithEvents lblStun As System.Windows.Forms.Label
    Friend WithEvents lblMana As System.Windows.Forms.Label
    Friend WithEvents nerStat1 As JCS.Components.NeroBar
    Friend WithEvents nerStat2 As JCS.Components.NeroBar
    Friend WithEvents nerStat3 As JCS.Components.NeroBar
    Friend WithEvents nerStat4 As JCS.Components.NeroBar
    Friend WithEvents lblClanPayTimer As System.Windows.Forms.Label
    Friend WithEvents lnklblPayUpdate As System.Windows.Forms.LinkLabel

End Class
