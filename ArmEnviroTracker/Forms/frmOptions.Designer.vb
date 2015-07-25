<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOptions
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
        Me.cbxAlwaysTop = New System.Windows.Forms.CheckBox()
        Me.nudMinOffset = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbMinOffsetDirection = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cbxOverlayLabel = New System.Windows.Forms.CheckBox()
        Me.cmbStyle = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbColorStyle = New System.Windows.Forms.ComboBox()
        Me.nudGameHourOffset = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbxVoteRemind = New System.Windows.Forms.CheckBox()
        Me.cbxAutoOpenVote = New System.Windows.Forms.CheckBox()
        Me.gbxVoteSites = New System.Windows.Forms.GroupBox()
        Me.rbBothVote = New System.Windows.Forms.RadioButton()
        Me.rbTmc = New System.Windows.Forms.RadioButton()
        Me.rbTms = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbIcon = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbBackground = New System.Windows.Forms.ComboBox()
        Me.cbxOverlayLogo = New System.Windows.Forms.CheckBox()
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbxPayTimerOn = New System.Windows.Forms.CheckBox()
        Me.cbxDamageSystemOn = New System.Windows.Forms.CheckBox()
        CType(Me.nudMinOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudGameHourOffset, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxVoteSites.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbxAlwaysTop
        '
        Me.cbxAlwaysTop.AutoSize = True
        Me.cbxAlwaysTop.Checked = True
        Me.cbxAlwaysTop.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxAlwaysTop.Location = New System.Drawing.Point(12, 183)
        Me.cbxAlwaysTop.Name = "cbxAlwaysTop"
        Me.cbxAlwaysTop.Size = New System.Drawing.Size(98, 17)
        Me.cbxAlwaysTop.TabIndex = 0
        Me.cbxAlwaysTop.Text = "Always On Top"
        Me.cbxAlwaysTop.UseVisualStyleBackColor = True
        '
        'nudMinOffset
        '
        Me.nudMinOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudMinOffset.Location = New System.Drawing.Point(103, 48)
        Me.nudMinOffset.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMinOffset.Name = "nudMinOffset"
        Me.nudMinOffset.Size = New System.Drawing.Size(37, 22)
        Me.nudMinOffset.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Server time is"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(146, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "minutes"
        '
        'cmbMinOffsetDirection
        '
        Me.cmbMinOffsetDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMinOffsetDirection.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMinOffsetDirection.FormattingEnabled = True
        Me.cmbMinOffsetDirection.Items.AddRange(New Object() {"ahead of", "behind"})
        Me.cmbMinOffsetDirection.Location = New System.Drawing.Point(206, 47)
        Me.cmbMinOffsetDirection.Name = "cmbMinOffsetDirection"
        Me.cmbMinOffsetDirection.Size = New System.Drawing.Size(84, 24)
        Me.cmbMinOffsetDirection.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(296, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "my computer."
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Location = New System.Drawing.Point(116, 436)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.Location = New System.Drawing.Point(206, 436)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cbxOverlayLabel
        '
        Me.cbxOverlayLabel.AutoSize = True
        Me.cbxOverlayLabel.Location = New System.Drawing.Point(12, 249)
        Me.cbxOverlayLabel.Name = "cbxOverlayLabel"
        Me.cbxOverlayLabel.Size = New System.Drawing.Size(91, 17)
        Me.cbxOverlayLabel.TabIndex = 13
        Me.cbxOverlayLabel.Text = "Overlay Label"
        Me.cbxOverlayLabel.UseVisualStyleBackColor = True
        '
        'cmbStyle
        '
        Me.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStyle.FormattingEnabled = True
        Me.cmbStyle.Items.AddRange(New Object() {"Krath/Black Moon Clock", "Logo Clock"})
        Me.cmbStyle.Location = New System.Drawing.Point(94, 81)
        Me.cmbStyle.Name = "cmbStyle"
        Me.cmbStyle.Size = New System.Drawing.Size(219, 24)
        Me.cmbStyle.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 84)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Clock Style: "
        '
        'cmbColorStyle
        '
        Me.cmbColorStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbColorStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbColorStyle.FormattingEnabled = True
        Me.cmbColorStyle.Items.AddRange(New Object() {"Black on Clear/Grey", "Black on White", "White on Clear/Grey", "White on Black", "Gold on Red", "Green on Black"})
        Me.cmbColorStyle.Location = New System.Drawing.Point(109, 245)
        Me.cmbColorStyle.Name = "cmbColorStyle"
        Me.cmbColorStyle.Size = New System.Drawing.Size(204, 24)
        Me.cmbColorStyle.TabIndex = 16
        '
        'nudGameHourOffset
        '
        Me.nudGameHourOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudGameHourOffset.Location = New System.Drawing.Point(103, 16)
        Me.nudGameHourOffset.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.nudGameHourOffset.Name = "nudGameHourOffset"
        Me.nudGameHourOffset.Size = New System.Drawing.Size(37, 22)
        Me.nudGameHourOffset.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(146, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(205, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "game hours off from my computer"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Server time is"
        '
        'cbxVoteRemind
        '
        Me.cbxVoteRemind.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxVoteRemind.AutoSize = True
        Me.cbxVoteRemind.Location = New System.Drawing.Point(13, 24)
        Me.cbxVoteRemind.Name = "cbxVoteRemind"
        Me.cbxVoteRemind.Size = New System.Drawing.Size(128, 17)
        Me.cbxVoteRemind.TabIndex = 22
        Me.cbxVoteRemind.Text = "Voting Reminders ON"
        Me.cbxVoteRemind.UseVisualStyleBackColor = True
        '
        'cbxAutoOpenVote
        '
        Me.cbxAutoOpenVote.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxAutoOpenVote.AutoSize = True
        Me.cbxAutoOpenVote.Location = New System.Drawing.Point(13, 57)
        Me.cbxAutoOpenVote.Name = "cbxAutoOpenVote"
        Me.cbxAutoOpenVote.Size = New System.Drawing.Size(105, 17)
        Me.cbxAutoOpenVote.TabIndex = 21
        Me.cbxAutoOpenVote.Text = "Auto Open Page"
        Me.cbxAutoOpenVote.UseVisualStyleBackColor = True
        '
        'gbxVoteSites
        '
        Me.gbxVoteSites.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbxVoteSites.Controls.Add(Me.rbBothVote)
        Me.gbxVoteSites.Controls.Add(Me.rbTmc)
        Me.gbxVoteSites.Controls.Add(Me.rbTms)
        Me.gbxVoteSites.Location = New System.Drawing.Point(147, 28)
        Me.gbxVoteSites.Name = "gbxVoteSites"
        Me.gbxVoteSites.Size = New System.Drawing.Size(167, 46)
        Me.gbxVoteSites.TabIndex = 23
        Me.gbxVoteSites.TabStop = False
        Me.gbxVoteSites.Text = "Vote Sites"
        '
        'rbBothVote
        '
        Me.rbBothVote.AutoSize = True
        Me.rbBothVote.Checked = True
        Me.rbBothVote.Location = New System.Drawing.Point(116, 19)
        Me.rbBothVote.Name = "rbBothVote"
        Me.rbBothVote.Size = New System.Drawing.Size(47, 17)
        Me.rbBothVote.TabIndex = 26
        Me.rbBothVote.TabStop = True
        Me.rbBothVote.Text = "Both"
        Me.rbBothVote.UseVisualStyleBackColor = True
        '
        'rbTmc
        '
        Me.rbTmc.AutoSize = True
        Me.rbTmc.Location = New System.Drawing.Point(62, 19)
        Me.rbTmc.Name = "rbTmc"
        Me.rbTmc.Size = New System.Drawing.Size(48, 17)
        Me.rbTmc.TabIndex = 25
        Me.rbTmc.TabStop = True
        Me.rbTmc.Text = "TMC"
        Me.rbTmc.UseVisualStyleBackColor = True
        '
        'rbTms
        '
        Me.rbTms.AutoSize = True
        Me.rbTms.Location = New System.Drawing.Point(8, 19)
        Me.rbTms.Name = "rbTms"
        Me.rbTms.Size = New System.Drawing.Size(48, 17)
        Me.rbTms.TabIndex = 24
        Me.rbTms.TabStop = True
        Me.rbTms.Text = "TMS"
        Me.rbTms.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Icon Style: "
        '
        'cmbIcon
        '
        Me.cmbIcon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIcon.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIcon.FormattingEnabled = True
        Me.cmbIcon.Items.AddRange(New Object() {"Krath/Black Moon Clock"})
        Me.cmbIcon.Location = New System.Drawing.Point(90, 141)
        Me.cmbIcon.Name = "cmbIcon"
        Me.cmbIcon.Size = New System.Drawing.Size(223, 24)
        Me.cmbIcon.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Background Style: "
        '
        'cmbBackground
        '
        Me.cmbBackground.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBackground.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBackground.FormattingEnabled = True
        Me.cmbBackground.Items.AddRange(New Object() {"Krath/Black Moon Clock"})
        Me.cmbBackground.Location = New System.Drawing.Point(138, 111)
        Me.cmbBackground.Name = "cmbBackground"
        Me.cmbBackground.Size = New System.Drawing.Size(175, 24)
        Me.cmbBackground.TabIndex = 26
        '
        'cbxOverlayLogo
        '
        Me.cbxOverlayLogo.AutoSize = True
        Me.cbxOverlayLogo.Checked = True
        Me.cbxOverlayLogo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbxOverlayLogo.Location = New System.Drawing.Point(12, 216)
        Me.cbxOverlayLogo.Name = "cbxOverlayLogo"
        Me.cbxOverlayLogo.Size = New System.Drawing.Size(89, 17)
        Me.cbxOverlayLogo.TabIndex = 29
        Me.cbxOverlayLogo.Text = "Overlay Logo"
        Me.cbxOverlayLogo.UseVisualStyleBackColor = True
        '
        'btnRestart
        '
        Me.btnRestart.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRestart.Location = New System.Drawing.Point(291, 106)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(75, 34)
        Me.btnRestart.TabIndex = 30
        Me.btnRestart.Text = "Restart Listener"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRestart)
        Me.GroupBox1.Controls.Add(Me.cbxPayTimerOn)
        Me.GroupBox1.Controls.Add(Me.cbxDamageSystemOn)
        Me.GroupBox1.Controls.Add(Me.cbxVoteRemind)
        Me.GroupBox1.Controls.Add(Me.cbxAutoOpenVote)
        Me.GroupBox1.Controls.Add(Me.gbxVoteSites)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(372, 150)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional Options"
        '
        'cbxPayTimerOn
        '
        Me.cbxPayTimerOn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxPayTimerOn.AutoSize = True
        Me.cbxPayTimerOn.Location = New System.Drawing.Point(13, 90)
        Me.cbxPayTimerOn.Name = "cbxPayTimerOn"
        Me.cbxPayTimerOn.Size = New System.Drawing.Size(116, 17)
        Me.cbxPayTimerOn.TabIndex = 27
        Me.cbxPayTimerOn.Text = "Clan Pay Timer ON"
        Me.cbxPayTimerOn.UseVisualStyleBackColor = True
        '
        'cbxDamageSystemOn
        '
        Me.cbxDamageSystemOn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbxDamageSystemOn.AutoSize = True
        Me.cbxDamageSystemOn.Location = New System.Drawing.Point(13, 123)
        Me.cbxDamageSystemOn.Name = "cbxDamageSystemOn"
        Me.cbxDamageSystemOn.Size = New System.Drawing.Size(122, 17)
        Me.cbxDamageSystemOn.TabIndex = 26
        Me.cbxDamageSystemOn.Text = "Damage System ON"
        Me.cbxDamageSystemOn.UseVisualStyleBackColor = True
        '
        'frmOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(397, 482)
        Me.Controls.Add(Me.cbxOverlayLogo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbBackground)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbIcon)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudGameHourOffset)
        Me.Controls.Add(Me.cmbColorStyle)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbStyle)
        Me.Controls.Add(Me.cbxOverlayLabel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbMinOffsetDirection)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudMinOffset)
        Me.Controls.Add(Me.cbxAlwaysTop)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmOptions"
        Me.Text = "Arm Environment Options"
        CType(Me.nudMinOffset, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudGameHourOffset, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxVoteSites.ResumeLayout(False)
        Me.gbxVoteSites.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbxAlwaysTop As System.Windows.Forms.CheckBox
    Friend WithEvents nudMinOffset As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMinOffsetDirection As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cbxOverlayLabel As System.Windows.Forms.CheckBox
    Friend WithEvents cmbStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbColorStyle As System.Windows.Forms.ComboBox
    Friend WithEvents nudGameHourOffset As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbxVoteRemind As System.Windows.Forms.CheckBox
    Friend WithEvents cbxAutoOpenVote As System.Windows.Forms.CheckBox
    Friend WithEvents gbxVoteSites As System.Windows.Forms.GroupBox
    Friend WithEvents rbTmc As System.Windows.Forms.RadioButton
    Friend WithEvents rbTms As System.Windows.Forms.RadioButton
    Friend WithEvents rbBothVote As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbIcon As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbBackground As System.Windows.Forms.ComboBox
    Friend WithEvents cbxOverlayLogo As System.Windows.Forms.CheckBox
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbxPayTimerOn As System.Windows.Forms.CheckBox
    Friend WithEvents cbxDamageSystemOn As System.Windows.Forms.CheckBox
End Class
