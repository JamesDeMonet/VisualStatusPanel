Public Class Form1

#Region "Form Event Handlers"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbGlowMode.SelectedIndex = 0
        lblColorPercentage.BackColor = NeroBar1.ForeColor
        cmbPercentageBasedOn.Text = "Whole Control"
        cmbChangeMode.Text = "Segments"
    End Sub

#End Region

#Region "Control Event Handlers"

    Private Sub numMinValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numMinValue.ValueChanged
        If numMinValue.Value >= CInt(NeroBar1.MaxValue) Then Exit Sub

        NeroBar1.MinValue = numMinValue.Value
        NeroBarToolStripItem1.MinValue = numMinValue.Value
        trbValue.Minimum = NeroBar1.MinValue
        trbThreshold2.Minimum = NeroBar1.MinValue
        trbThreshold3.Minimum = NeroBar1.MinValue
    End Sub

    Private Sub numMaxValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numMaxValue.ValueChanged
        If numMaxValue.Value <= CInt(NeroBar1.MinValue) Then Exit Sub

        NeroBar1.MaxValue = numMaxValue.Value
        NeroBarToolStripItem1.MaxValue = numMaxValue.Value
        trbValue.Maximum = NeroBar1.MaxValue
        trbThreshold2.Maximum = NeroBar1.MaxValue
        trbThreshold3.Maximum = NeroBar1.MaxValue
    End Sub

    Private Sub trbValue_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbValue.ValueChanged
        lblValue.Text = "Value: " & trbValue.Value.ToString
        NeroBar1.Value = trbValue.Value
        NeroBarToolStripItem1.Value = trbValue.Value
    End Sub

    Private Sub trbThreshold2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbThreshold2.ValueChanged
        lblThreshold2.Text = trbThreshold2.Value.ToString
        NeroBar1.Segment2StartThreshold = trbThreshold2.Value
        NeroBarToolStripItem1.Segment2StartThreshold = trbThreshold2.Value
    End Sub

    Private Sub trbThreshold3_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles trbThreshold3.ValueChanged
        lblThreshold3.Text = trbThreshold3.Value.ToString
        NeroBar1.Segment3StartThreshold = trbThreshold3.Value
        NeroBarToolStripItem1.Segment3StartThreshold = trbThreshold3.Value
    End Sub

    Private Sub optOne_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optOne.CheckedChanged
        If optOne.Checked Then
            NeroBar1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.One
            NeroBarToolStripItem1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.One
            Label7.Enabled = False
            lblThreshold2.Enabled = False
            trbThreshold2.Enabled = False
            Label5.Enabled = False
            Label8.Enabled = False
            lblThreshold3.Enabled = False
            trbThreshold3.Enabled = False
            Label6.Enabled = False
        End If
    End Sub

    Private Sub optTwo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optTwo.CheckedChanged
        If optTwo.Checked Then
            NeroBar1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.Two
            NeroBarToolStripItem1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.Two
            Label7.Enabled = True
            lblThreshold2.Enabled = True
            trbThreshold2.Enabled = True
            Label5.Enabled = True
            Label8.Enabled = False
            lblThreshold3.Enabled = False
            trbThreshold3.Enabled = False
            Label6.Enabled = False
        End If
    End Sub

    Private Sub optThree_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optThree.CheckedChanged
        If optThree.Checked Then
            NeroBar1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.Three
            NeroBarToolStripItem1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.Three
            Label7.Enabled = True
            lblThreshold2.Enabled = True
            trbThreshold2.Enabled = True
            Label5.Enabled = True
            Label8.Enabled = True
            lblThreshold3.Enabled = True
            trbThreshold3.Enabled = True
            Label6.Enabled = True
        End If
    End Sub

    Private Sub chkDrawThresholds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDrawThresholds.CheckedChanged
        NeroBar1.DrawThresholds = chkDrawThresholds.Checked
        NeroBarToolStripItem1.DrawThresholds = chkDrawThresholds.Checked
    End Sub

    Private Sub chkColorThresholds_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkColorThresholds.CheckedChanged
        NeroBar1.ColorThresholds = chkColorThresholds.Checked
        NeroBarToolStripItem1.ColorThresholds = chkColorThresholds.Checked
    End Sub

    Private Sub lblGlowColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGlowColor.Click
        ColorDialog1.Color = lblGlowColor.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblGlowColor.BackColor = ColorDialog1.Color
            NeroBar1.GlowColor = lblGlowColor.BackColor
            NeroBarToolStripItem1.GlowColor = lblGlowColor.BackColor
        End If
    End Sub

    Private Sub lblColorPercentage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblColorPercentage.Click
        ColorDialog1.Color = lblColorPercentage.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblColorPercentage.BackColor = ColorDialog1.Color
            NeroBar1.ForeColor = lblColorPercentage.BackColor
            NeroBarToolStripItem1.ForeColor = lblColorPercentage.BackColor
        End If
    End Sub

    Private Sub numSpeed_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numSpeed.ValueChanged
        NeroBar1.GlowSpeed = numSpeed.Value
        NeroBarToolStripItem1.GlowSpeed = numSpeed.Value
    End Sub

    Private Sub numPause_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles numPause.ValueChanged
        NeroBar1.GlowPause = numPause.Value
        NeroBarToolStripItem1.GlowPause = numPause.Value
    End Sub

    Private Sub cmbGlowMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGlowMode.SelectedIndexChanged
        NeroBar1.GlowMode = DirectCast(cmbGlowMode.SelectedIndex, JCS.Components.NeroBar.NeroBarGlowModes)
        NeroBarToolStripItem1.GlowMode = DirectCast(cmbGlowMode.SelectedIndex, JCS.Components.NeroBar.NeroBarGlowModes)
    End Sub

    Private Sub chkShowPercent_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowPercent.CheckedChanged
        NeroBar1.PercentageShow = chkShowPercent.Checked
        NeroBarToolStripItem1.PercentageShow = chkShowPercent.Checked
        cmbPercentageBasedOn.Enabled = chkShowPercent.Checked
        lnkHigherThanMax.Enabled = chkShowPercent.Checked
    End Sub

    Private Sub lblColorSegment1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblColorSegment1.Click
        ColorDialog1.Color = lblColorSegment1.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblColorSegment1.BackColor = ColorDialog1.Color
            NeroBar1.Segment1Color = lblColorSegment1.BackColor
            NeroBarToolStripItem1.Segment1Color = lblColorSegment1.BackColor
        End If
    End Sub

    Private Sub lblColorSegment2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblColorSegment2.Click
        ColorDialog1.Color = lblColorSegment1.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblColorSegment2.BackColor = ColorDialog1.Color
            NeroBar1.Segment2Color = lblColorSegment2.BackColor
            NeroBarToolStripItem1.Segment1Color = lblColorSegment1.BackColor
        End If
    End Sub

    Private Sub lblColorSegment3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblColorSegment3.Click
        ColorDialog1.Color = lblColorSegment3.BackColor
        If ColorDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            lblColorSegment3.BackColor = ColorDialog1.Color
            NeroBar1.Segment3Color = lblColorSegment3.BackColor
            NeroBarToolStripItem1.Segment1Color = lblColorSegment1.BackColor
        End If
    End Sub

    Private Sub cmbPercentageBasedOn_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPercentageBasedOn.SelectedIndexChanged
        If cmbPercentageBasedOn.Enabled Then
            NeroBar1.PercentageBasedOn = DirectCast(cmbPercentageBasedOn.SelectedIndex + 1, JCS.Components.NeroBar.NeroBarPercentageCalculationModes)
            NeroBarToolStripItem1.PercentageBasedOn = DirectCast(cmbPercentageBasedOn.SelectedIndex + 1, JCS.Components.NeroBar.NeroBarPercentageCalculationModes)
        End If
    End Sub

    Private Sub chkRightToLeft_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRightToLeft.CheckedChanged
        NeroBar1.RightToLeft = chkRightToLeft.Checked
        NeroBarToolStripItem1.RightToLeft = chkRightToLeft.Checked
    End Sub

    Private Sub cmbChangeMode_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChangeMode.SelectedIndexChanged
        NeroBar1.ColorChangeMode = DirectCast(cmbChangeMode.SelectedIndex, JCS.Components.NeroBar.NeroBarColorChangeModes)
        NeroBarToolStripItem1.ColorChangeMode = DirectCast(cmbChangeMode.SelectedIndex, JCS.Components.NeroBar.NeroBarColorChangeModes)
    End Sub

    Private Sub btnDemo1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDemo1.Click
        Dim f As New Form2(1)
        f.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New Form2(2)
        f.ShowDialog()
    End Sub

    Private Sub lnkHigherThanMax_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkHigherThanMax.LinkClicked
        trbValue.Value = trbValue.Maximum
        NeroBar1.Value = NeroBar1.MaxValue + 1
    End Sub

#End Region

End Class
