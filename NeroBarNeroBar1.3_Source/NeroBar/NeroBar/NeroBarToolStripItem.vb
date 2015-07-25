#Region "Imports"
Imports System.ComponentModel
Imports System.Windows.Forms.Design
#End Region

<ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.All)> _
Public Class NeroBarToolStripItem
    Inherits ToolStripControlHost

#Region "Private Members"

    Private _neroBar As NeroBar = Nothing

#End Region

#Region "Constructor"

    Public Sub New()
        MyBase.New(New NeroBar)
        Me.Padding = New System.Windows.Forms.Padding(2, 2, 2, 3)
        _neroBar = Control
    End Sub

#End Region

#Region "Properties"

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(CDbl(0))> _
    <Category("NeroBar")> _
    <Description("The NeroBar's value.")> _
    Public Property Value() As Double
        Get
            Return _neroBar.Value
        End Get
        Set(ByVal value As Double)
            _neroBar.Value = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(CDbl(100))> _
    <Category("NeroBar")> _
    <Description("The NeroBar's maximum value.")> _
    Public Property MaxValue() As Double
        Get
            Return _neroBar.MaxValue
        End Get
        Set(ByVal value As Double)
            _neroBar.MaxValue = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(CDbl(0))> _
    <Category("NeroBar")> _
    <Description("The NeroBar's minimum value.")> _
    Public Property MinValue() As Double
        Get
            Return _neroBar.MinValue
        End Get
        Set(ByVal value As Double)
            _neroBar.MinValue = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(True)> _
    <Category("NeroBar")> _
    <Description("Determines if the thresholds should be shown or not.")> _
    Public Property DrawThresholds() As Boolean
        Get
            Return _neroBar.DrawThresholds
        End Get
        Set(ByVal value As Boolean)
            _neroBar.DrawThresholds = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(False)> _
    <Category("NeroBar")> _
    <Description("Determines if the thresholds should be colored according to the selected segment color or not.")> _
    Public Property ColorThresholds() As Boolean
        Get
            Return _neroBar.ColorThresholds
        End Get
        Set(ByVal value As Boolean)
            _neroBar.ColorThresholds = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(GetType(NeroBar.NeroBarSegments), "Three")> _
    <Category("NeroBar")> _
    <Description("The number of segments - between one and three.")> _
    Public Property SegmentCount() As NeroBar.NeroBarSegments
        Get
            Return _neroBar.SegmentCount
        End Get
        Set(ByVal value As NeroBar.NeroBarSegments)
            _neroBar.SegmentCount = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <Category("NeroBar")> _
    <DefaultValue(GetType(Color), "55, 217, 60")> _
    <Description("The color of the first segment.")> _
    Public Property Segment1Color() As Color
        Get
            Return _neroBar.Segment1Color
        End Get
        Set(ByVal value As Color)
            _neroBar.Segment1Color = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <Category("NeroBar")> _
    <DefaultValue(GetType(Color), "252, 252, 0")> _
    <Description("The color of the second segment.")> _
    Public Property Segment2Color() As Color
        Get
            Return _neroBar.Segment2Color
        End Get
        Set(ByVal value As Color)
            _neroBar.Segment2Color = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <Category("NeroBar")> _
    <DefaultValue(GetType(Color), "252, 0, 0")> _
    <Description("The color of the third segment.")> _
    Public Property Segment3Color() As Color
        Get
            Return _neroBar.Segment3Color
        End Get
        Set(ByVal value As Color)
            _neroBar.Segment3Color = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <Category("NeroBar")> _
    <DefaultValue(GetType(NeroBar.NeroBarColorChangeModes), "Segments")> _
    <Description("Determines if the WHOLE bar should change color when threshold is passed or only the next segment.")> _
    Public Property ColorChangeMode() As NeroBar.NeroBarColorChangeModes
        Get
            Return _neroBar.ColorChangeMode
        End Get
        Set(ByVal value As NeroBar.NeroBarColorChangeModes)
            _neroBar.ColorChangeMode = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(CDbl(80))> _
    <Category("NeroBar")> _
    <Description("The lower threshold (starting position) of the second segment.")> _
    Public Property Segment2StartThreshold() As Double
        Get
            Return _neroBar.Segment2StartThreshold
        End Get
        Set(ByVal value As Double)
            _neroBar.Segment2StartThreshold = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(CDbl(90))> _
    <Category("NeroBar")> _
    <Description("The lower threshold (starting position) of the third segment.")> _
    Public Property Segment3StartThreshold() As Double
        Get
            Return _neroBar.Segment3StartThreshold
        End Get
        Set(ByVal value As Double)
            _neroBar.Segment3StartThreshold = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(GetType(NeroBar.NeroBarGlowModes), "None")> _
    <Category("NeroBar")> _
    <Description("Determines if the NeroBar should have an animated glow or not.")> _
    Public Property GlowMode() As NeroBar.NeroBarGlowModes
        Get
            Return _neroBar.GlowMode
        End Get
        Set(ByVal value As NeroBar.NeroBarGlowModes)
            _neroBar.GlowMode = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(20)> _
    <Category("NeroBar")> _
    <Description("The time between the glow advances in milliseconds. Lower value -> Higher Speed etc.")> _
    Public Property GlowSpeed() As Integer
        Get
            Return _neroBar.GlowSpeed
        End Get
        Set(ByVal value As Integer)
            _neroBar.GlowSpeed = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(5000)> _
    <Category("NeroBar")> _
    <Description("The pause between the glow animations in milliseconds.")> _
    Public Property GlowPause() As Integer
        Get
            Return _neroBar.GlowPause
        End Get
        Set(ByVal value As Integer)
            If value <= 0 Then
                Throw New Exception("The GlowPause value cannot be zero or negative")
            End If
            _neroBar.GlowPause = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <Category("NeroBar")> _
    <DefaultValue(GetType(Color), "150, 255, 255, 255")> _
    <Description("The color of the animated glow.")> _
    Public Property GlowColor() As Color
        Get
            Return _neroBar.GlowColor
        End Get
        Set(ByVal value As Color)
            _neroBar.GlowColor = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(False)> _
    <Category("NeroBar")> _
    <Description("Determines if progress percentage should be shown or not.")> _
    Public Property PercentageShow() As Boolean
        Get
            Return _neroBar.PercentageShow
        End Get
        Set(ByVal value As Boolean)
            _neroBar.PercentageShow = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(GetType(NeroBar.NeroBarPercentageCalculationModes), "Segments_1_2_3")> _
    <Category("NeroBar")> _
    <Description("Determines if progress percentage should be calculated based on the segment first segment(s) or the whole control width.")> _
    Public Property PercentageBasedOn() As NeroBar.NeroBarPercentageCalculationModes
        Get
            Return _neroBar.PercentageBasedOn
        End Get
        Set(ByVal value As NeroBar.NeroBarPercentageCalculationModes)
            _neroBar.PercentageBasedOn = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(GetType(Color), "ControlText")> _
    <Category("Appearance")> _
    <Description("The forecolor of the Percentage text.")> _
    Public Overrides Property ForeColor() As System.Drawing.Color
        Get
            Return _neroBar.ForeColor
        End Get
        Set(ByVal value As System.Drawing.Color)
            _neroBar.ForeColor = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <Category("Appearance")> _
    <Description("The Percentage text font.")> _
    Public Overrides Property Font() As System.Drawing.Font
        Get
            Return _neroBar.Font
        End Get
        Set(ByVal value As System.Drawing.Font)
            _neroBar.Font = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <Category("Appearance")> _
    <Description("The alignment of the Percentage text.")> _
    Public Shadows Property TextAlign() As System.Drawing.ContentAlignment
        Get
            Return _neroBar.TextAlign
        End Get
        Set(ByVal value As System.Drawing.ContentAlignment)
            _neroBar.TextAlign = value
        End Set
    End Property

    <Localizable(False)> _
    <Bindable(False)> _
    <Browsable(True)> _
    <DefaultValue(False)> _
    <Category("Nerobar")> _
    <Description("If true, the bar will be filled from right to left instead of left to right.")> _
    Public Shadows Property RightToLeft() As Boolean
        Get
            Return _neroBar.RightToLeft
        End Get
        Set(ByVal value As Boolean)
            _neroBar.RightToLeft = value
        End Set
    End Property

#End Region

#Region "Overridden Methods"

    Public Overrides Function GetPreferredSize(ByVal constrainingSize As System.Drawing.Size) As System.Drawing.Size
        'Return MyBase.GetPreferredSize(constrainingSize)
        Return Control.GetPreferredSize(constrainingSize)
    End Function

    Protected Overrides Sub OnSubscribeControlEvents(ByVal c As Control)
        MyBase.OnSubscribeControlEvents(Control)

        'Add your code here to subsribe to Control Events
    End Sub

    Protected Overrides Sub OnUnsubscribeControlEvents(ByVal c As Control)
        MyBase.OnUnsubscribeControlEvents(Control)

        'Add your code here to unsubscribe from control events.
    End Sub

#End Region

End Class
