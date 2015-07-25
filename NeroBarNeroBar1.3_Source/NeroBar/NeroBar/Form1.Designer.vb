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
        Me.NeroBar1 = New JCS.Components.NeroBar
        Me.SuspendLayout()
        '
        'NeroBar1
        '
        Me.NeroBar1.BackColor = System.Drawing.Color.Transparent
        Me.NeroBar1.DrawThresholds = True
        Me.NeroBar1.Location = New System.Drawing.Point(25, 75)
        Me.NeroBar1.MaxValue = 100
        Me.NeroBar1.MinValue = 0
        Me.NeroBar1.Name = "NeroBar1"
        Me.NeroBar1.Segment1Color = JCS.Components.NeroBar.NeroBarColors.Green
        Me.NeroBar1.Segment2Color = JCS.Components.NeroBar.NeroBarColors.Yellow
        Me.NeroBar1.Segment2StartThreshold = 80
        Me.NeroBar1.Segment3Color = JCS.Components.NeroBar.NeroBarColors.Red
        Me.NeroBar1.Segment3StartThreshold = 90
        Me.NeroBar1.SegmentCount = JCS.Components.NeroBar.NeroBarSegments.Three
        Me.NeroBar1.Size = New System.Drawing.Size(539, 16)
        Me.NeroBar1.TabIndex = 0
        Me.NeroBar1.Value = 85
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 469)
        Me.Controls.Add(Me.NeroBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents NeroBar1 As JCS.Components.NeroBar

End Class
