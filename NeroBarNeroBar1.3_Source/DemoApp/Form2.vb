Public Class Form2

    Private _demoNumber As Integer = 1

    Public Sub New(ByVal DemoNumber As Integer)
        InitializeComponent()

        _demoNumber = DemoNumber

        If _demoNumber = 1 Then
            Label1.Text = "Time Elapsed: 0:00"
            NeroBar1.MinValue = 0
            NeroBar1.MaxValue = 15
            NeroBar1.Value = 0
            NeroBar1.DrawThresholds = False
            NeroBar1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.Two
            NeroBar1.Segment2Color = Color.FromArgb(252, 0, 0) 'Red
            NeroBar1.Segment2StartThreshold = 10
            NeroBar1.ColorChangeMode = JCS.Components.NeroBar.NeroBarColorChangeModes.WholeBar
        Else
            Label1.Text = "Time Left: 0:15"
            NeroBar1.MinValue = 0
            NeroBar1.MaxValue = 15
            NeroBar1.Value = 15
            NeroBar1.DrawThresholds = False
            NeroBar1.RightToLeft = True
            NeroBar1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.Two
            NeroBar1.Segment1Color = Color.FromArgb(252, 0, 0) 'Red
            NeroBar1.Segment2Color = Color.FromArgb(55, 217, 60) 'Green
            NeroBar1.Segment2StartThreshold = 5
            NeroBar1.ColorChangeMode = JCS.Components.NeroBar.NeroBarColorChangeModes.WholeBar
        End If

        'Has nothing to do with the demo, but it looks good!  :-)
        'and then you can see that even the glow animation reverses when RightToLeft = True
        NeroBar1.GlowSpeed = 10
        NeroBar1.GlowPause = 500
        NeroBar1.GlowMode = JCS.Components.NeroBar.NeroBarGlowModes.ProgressOnly
    End Sub

    Private Sub Form2_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        'Smoother animation can of course be obtained by setting the timer interval to a lower value and adding a
        'value less than 1. Don't forget - the Value property is not an integer.
        'Try for instance Timer1.Interval = 100 and NeroBar1.Value += 0.1 / NeroBar1.Value -= 0.1

        If _demoNumber = 1 Then
            If NeroBar1.Value < NeroBar1.MaxValue Then
                NeroBar1.Value += 1
                Label1.Text = "Time Elapsed: 0:" & CInt(NeroBar1.Value).ToString.PadLeft(2, "0")
                Timer1.Enabled = True
            Else
                Label1.Text = "Done!"
            End If
        Else
            If NeroBar1.Value > NeroBar1.MinValue Then
                NeroBar1.Value -= 1
                Label1.Text = "Time Left: 0:" & CInt(NeroBar1.Value).ToString.PadLeft(2, "0")
                Timer1.Enabled = True
            Else
                Label1.Text = "Done!"
            End If
        End If
    End Sub

End Class