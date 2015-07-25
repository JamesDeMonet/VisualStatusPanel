Public Class frmOptions

    'Private LabelStatus As Boolean
    'Dim SenderIsSubEvent As Boolean = False

    Private Sub frmOptions_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Me.Icon = My.Resources.NewArmLogo

        ' cmbCurrentHour.DataSource = frmMain.HourData

        nudGameHourOffset.Value = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "HourOffset", 0)
        nudMinOffset.Value = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "MinOffset", 0)
        cmbMinOffsetDirection.SelectedIndex = IIf(GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "MinOffsetSign", 1) < 0, 1, 0)
        cbxAlwaysTop.Checked = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "AlwaysOnTop", False)
        cbxOverlayLogo.Checked = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "OverlayLogo", True)
        cbxOverlayLabel.Checked = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "OverlayLabel", True)
        cmbStyle.SelectedIndex = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "EnviroType", 0)
        cmbColorStyle.SelectedIndex = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "LabelStyle", 0)
        cbxVoteRemind.Checked = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "VotingReminders", False)
        cbxAutoOpenVote.Checked = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "AutoOpenVotePage", False)
        cbxPayTimerOn.Checked = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "ClanPayTimer", False)
        cbxDamageSystemOn.Checked = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "DamageSystemShown", False)

        Dim votingSites As Integer = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "VotingSites", 2)
        Select Case votingSites
            Case 0
                rbTms.Checked = True
            Case 1
                rbTmc.Checked = True
            Case 2
                rbBothVote.Checked = True
        End Select

        cmbBackground.DataSource = frmMain.backgroundSetNames
        cmbIcon.DataSource = frmMain.iconSetNames
        Try
            cmbBackground.SelectedIndex = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "BackgroundSet", 0)
            cmbIcon.SelectedIndex = GetSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "IconSet", 0)
        Catch ex As Exception
            cmbBackground.SelectedIndex = 0
            cmbIcon.SelectedIndex = 0
        End Try

        'SenderIsSubEvent = True
        'cbxOverlayLabel.Checked = LabelStatus
        'SenderIsSubEvent = False

    End Sub

    Private Sub cbxAlwaysTop_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxAlwaysTop.CheckedChanged
        frmMain.TopMost = cbxAlwaysTop.Checked
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "HourOffset", nudGameHourOffset.Value)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "MinOffset", nudMinOffset.Value)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "MinOffsetSign", IIf(cmbMinOffsetDirection.SelectedIndex = 0, 1, -1))
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "AlwaysOnTop", cbxAlwaysTop.Checked)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "OverlayLogo", cbxOverlayLogo.Checked)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "OverlayLabel", cbxOverlayLabel.Checked)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "EnviroType", cmbStyle.SelectedIndex)
        ' SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "ReferenceTime", DateTime.UtcNow)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "LabelStyle", cmbColorStyle.SelectedIndex)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "VotingReminders", cbxVoteRemind.Checked)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "AutoOpenVotePage", cbxAutoOpenVote.Checked)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "ClanPayTimer", cbxPayTimerOn.Checked)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "DamageSystemShown", cbxDamageSystemOn.Checked)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "BackgroundSet", cmbBackground.SelectedIndex)
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "IconSet", cmbIcon.SelectedIndex)

        Dim votingSites As Integer = 2
        Select Case True
            Case rbTms.Checked
                votingSites = 0
            Case rbTmc.Checked
                votingSites = 1
            Case rbBothVote.Checked
                votingSites = 2
        End Select
        SaveSetting(frmMain.gRegistryName, frmMain.gRegProgInitsName, "VotingSites", votingSites)

        Dim EnviroTypeUpdate As Boolean = False
        If frmMain.TimeType <> cmbStyle.SelectedIndex Then
            EnviroTypeUpdate = True
        End If

        frmMain.UpdateEnviroImages(True, EnviroTypeUpdate)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    'Private Sub cmbStyle_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbStyle.SelectedIndexChanged
    '    SenderIsSubEvent = True

    '    If cmbStyle.SelectedIndex = 1 Then
    '        LabelStatus = cbxOverlayLabel.Checked
    '        cbxOverlayLabel.Enabled = False
    '        cbxOverlayLabel.Checked = False
    '    Else
    '        cbxOverlayLabel.Enabled = True
    '        cbxOverlayLabel.Checked = LabelStatus
    '    End If

    '    SenderIsSubEvent = False
    'End Sub

    'Private Sub cbxOverlayLabel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxOverlayLabel.CheckedChanged
    '    If SenderIsSubEvent = False Then
    '        LabelStatus = cbxOverlayLabel.Checked
    '    End If
    'End Sub

    Private Sub cbxOverlayLabel_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxOverlayLabel.CheckedChanged
        cmbColorStyle.Visible = cbxOverlayLabel.Checked
    End Sub

    Private Sub cbxVoteRemind_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbxVoteRemind.CheckedChanged
        Dim votingOn As Boolean = cbxVoteRemind.Checked
        cbxAutoOpenVote.Visible = votingOn
        cbxAutoOpenVote.Enabled = votingOn
        gbxVoteSites.Visible = votingOn
        gbxVoteSites.Enabled = votingOn
    End Sub

    Private Sub btnRestart_Click(sender As System.Object, e As System.EventArgs) Handles btnRestart.Click
        ' Restart a new listener thread if the listener stops responding.
        frmMain.InitThread()
    End Sub
End Class