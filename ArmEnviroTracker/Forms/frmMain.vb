Imports JCS.Components
Imports System.Threading
Imports System.Drawing

Public Class frmMain
    Private MinutesToAdd As Integer = 0
    Private ReferenceTime As DateTime = CDate(#3/8/2004 6:10:00 PM#) ' Somewhere around this date (UTC), the time code was locked in, so it is a good reference point
    Private CurrentHour As Integer = 0
    Private UnexpectedOffsetFromUtc As Integer = 0 ' This shouldn't really occur, but may be affected by end user's hardware
    Private NewHour As Boolean = True
    Private CustomSizeX, CustomSizeY As Integer
    Private LabelColorIndex As Integer = 0
    Public TimeType As Integer = 0 ' 0 = Hanging Logo (transparency), 1 = Hanging Moon (transparency)
    Public BarType As Integer = 0 ' 0 = Standard (blank, for now)
    Public LogoOverlay As Boolean = True
    Public BackgroundSet As Integer = 0
    Public IconSet As Integer = 0
    Private WithEvents tmrHour As New System.Timers.Timer
    Private mHourTimerInterval As Integer = 5000 ' 5 sec in ms
    Public Event tmrHourTick()
    Private formIsClosing As Boolean = False
    Public transparencyColor As System.Drawing.Color = System.Drawing.Color.FromArgb(64, 64, 66)

    'Drag Variables
    Private IsFormBeingDragged As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    'Vote Variables
    Private showVoteReminders As Boolean = False
    Private autoOpenVotePages As Boolean = False
    Private pagesToVote As Integer = 2 ' 0=TMS, 1=TMC, 2=Both
    Private tmsLastVote As DateTime = New DateTime
    Private tmcLastVote As DateTime = New DateTime

    'Other Options Variables
    Private showClanPayTimer As Boolean = False
    Private nextTimePayAvailable As DateTime
    Public enableDamageSystem As Boolean = False
    Private damageTracker As classDamageTracker = Nothing

    Private imgEnvironment As System.Drawing.Bitmap
    Private imgBar As System.Drawing.Bitmap

    Public HourData() As String = {"Dawn", "Early Morning", "Late Morning", "High Sun", "Early Afternoon", "Late Afternoon", "Dusk", "Late At Night", "Before Dawn"}
    Public iconSetNames() As String = {defaultSetName} ' Populated by CSV
    Public backgroundSetNames() As String = {defaultSetName} ' Populated by CSV
    Private statIcons(3) As IconSlot

    ' Y locations are consts, since they stay the same.  X locations are calculated to allow for later resizing.
    ' Initial values are approximate, or used for relative positioning.
    Private col1pbxXLoc As Integer = 3 ' Previously 11
    Private col2pbxXLoc As Integer = 42 ' Previously 34
    'Private col3pbxXLoc As Integer = 234 ' These two widths aren't needed, since they mimic 1 & 2 on the right side
    'Private col4pbxXLoc As Integer = 267 ' These two widths aren't needed, since they mimic 1 & 2 on the right side
    Private clockPbxXLoc As Integer = 78
    Private logoPbxXLoc As Integer = 0

#Region "Consts"
    Public Const gRegistryName As String = "VisualStatusBar"
    Public Const gRegProgInitsName As String = "Init"

    ' Y locations are consts, since they stay the same.  X locations are calculated to allow for later resizing.
    Private Const row1pbxYLoc As Integer = 146
    Private Const row2pbxYLoc As Integer = 197
    Private Const clockPbxYLoc As Integer = 0
    Private Const logoPbxYLoc As Integer = 0
    Private Const defaultSetName As String = "Default"
#End Region 'Consts

#Region "Enums"
    Private Enum StateNames
        none
        armed
        unarmed
        sleeping
        resting
        sitting
        standing
        walking
        running
        sneaking
        normal
        fighting
        mounted
        problem ' no problem
        light ' various values of light
        manageable ' various values of manageable
        heavy ' various values of heavy
    End Enum

    Private Enum AllStats
        Health = 0
        Stamina = 1
        Stun = 2
        Mana = 3
    End Enum

#End Region ' Enums

#Region "Structures"

    ' This structure represents one complete heartbeat worth of data
    Private Structure StatusPacket
        Dim currentHealth As Integer
        Dim totalHealth As Integer
        Dim currentStam As Integer
        Dim totalStam As Integer
        Dim currentStun As Integer
        Dim totalStun As Integer
        Dim currentMana As Integer
        Dim totalMana As Integer
        Dim currentTime As String
        Dim manaShown As Boolean
        Dim armed As StateNames
        Dim position As StateNames
        Dim speed As StateNames
        Dim fighting As StateNames
        Dim mounted As StateNames
        Dim encumbrance As StateNames
        Dim weather As String
        Dim otherInfo As String
    End Structure

    Private Structure DamageSlot
        Dim bodyPart As String ' We store this as a string instead of as an enum so that it isn't specific to one game
        Dim currentDamagePercentage As Double
        Dim injuryType As Integer
        Dim timeLeftToHeal As DateTime
        Dim numberOfMinorWounds As Integer
        Dim numberOfMajorWounds As Integer
    End Structure

    ' This structure just holds the data for adding an icon to the form (only stat icons currently use this structure, may wish to update state icons to use it as well)
    Private Structure IconSlot
        Dim iconImg As Image
        Dim xLoc As Integer
        Dim yLoc As Integer
        Dim xSize As Integer
        Dim ySize As Integer
        Dim Show As Boolean
    End Structure

#End Region ' Structures

#Region "Initialization"

    Private Sub frmMain_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '' Add the event handler for handling UI thread exceptions to the event. 
        'AddHandler Application.ThreadException, AddressOf UIThreadException

        '' Set the unhandled exception mode to force all Windows Forms errors to go through 
        '' our handler.
        'Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException)

        '' Add the event handler for handling non-UI thread exceptions to the event.  
        'AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf CurrentDomain_UnhandledException

        ' Add the event handler for handling listener received messages
        AddHandler classUDPListener.DataReceived, AddressOf DataReceived

        Me.Icon = My.Resources.NewArmLogo
        pbxEnviroment.SizeMode = PictureBoxSizeMode.StretchImage

        Me.BackColor = transparencyColor
        'pbxTime.BackColor = transparencyColor
        pbxEnviroment.BackColor = transparencyColor
        ' We need to set the parents of the labels to the progress bars behind them, otherwise their transparency shows through the whole form.
        Me.lblHealth.Location = Me.nerStat1.PointToClient(Me.lblHealth.Parent.PointToScreen(Me.lblHealth.Location))
        Me.lblStam.Location = Me.nerStat2.PointToClient(Me.lblHealth.Parent.PointToScreen(Me.lblStam.Location))
        Me.lblStun.Location = Me.nerStat3.PointToClient(Me.lblHealth.Parent.PointToScreen(Me.lblStun.Location))
        Me.lblMana.Location = Me.nerStat4.PointToClient(Me.lblHealth.Parent.PointToScreen(Me.lblMana.Location))
        Me.lblHealth.Parent = Me.nerStat1
        Me.lblStam.Parent = Me.nerStat2
        Me.lblStun.Parent = Me.nerStat3
        Me.lblMana.Parent = Me.nerStat4

        GetSettings()
        GetInitSettings()
        StyleForm()
        LoadGraphicSetSettings()
        UpdateEnviroImages(True, False)
        tmrHour.Interval = mHourTimerInterval
        tmrHour.Start()

        InitThread()

        statIcons(AllStats.Health).iconImg = My.Resources.ResourceManager.GetObject("health")
        statIcons(AllStats.Stamina).iconImg = My.Resources.ResourceManager.GetObject("stamina")
        statIcons(AllStats.Stun).iconImg = My.Resources.ResourceManager.GetObject("stun")
        statIcons(AllStats.Mana).iconImg = My.Resources.ResourceManager.GetObject("mana")

        Dim yLocStart As Integer = 244
        For i = 0 To statIcons.Length - 1
            statIcons(i).xLoc = 58
            statIcons(i).yLoc = yLocStart
            statIcons(i).xSize = 20
            statIcons(i).ySize = 20
            yLocStart += 29
        Next i
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        formIsClosing = True

        StopListener()

        UnInitThread()
        tmrHour.Stop()
        'System.Threading.Thread.Sleep(mHourTimerInterval)
        ' Wait to make sure the timer doesn't sequence again

        SaveSettings()

        If pbxEnviroment.Image IsNot Nothing Then
            pbxEnviroment.Image.Dispose()
            pbxEnviroment.Image = Nothing
        End If

    End Sub

#End Region 'Initialization

#Region "Controls"

    Private Sub frmMain_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown, pbxEnviroment.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub frmMain_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp, pbxEnviroment.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Right Then
            'Dim item1 = cmsRightClick.Items.Add("foo")
            'item1.Tag = 1
            'AddHandler item1.Click, AddressOf menuChoice
            'Dim item2 = cmsRightClick.Items.Add("bar")
            'item2.Tag = 2
            'AddHandler item2.Click, AddressOf menuChoice
            ''-- etc
            ''..
            cmsRightClick.Show(pbxEnviroment, e.Location)
        ElseIf e.Button = Windows.Forms.MouseButtons.Left Then
            IsFormBeingDragged = False
        End If
    End Sub

    Private Sub frmMain_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseMove, pbxEnviroment.MouseMove
        If IsFormBeingDragged And Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Dim temp As Point = New Point()

            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    'Private Sub menuChoice(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim item = CType(sender, ToolStripMenuItem)
    '    Dim selection = CInt(item.Tag)
    '    '-- etc
    'End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles OptionsToolStripMenuItem.Click
        SaveSettings()

        Dim newOptions As New frmOptions
        newOptions.ShowDialog()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub lblVoteTms_Click(sender As System.Object, e As System.EventArgs) Handles lblVoteTms.Click
        Dim webAddress As String = "http://www.topmudsites.com/cgi-bin/topmuds/rankem.cgi?id=sanvean"
        Process.Start(webAddress)
        lblVoteTms.Visible = False
        lblVoteTms.Enabled = False
        tmsLastVote = DateTime.Now
    End Sub

    Private Sub lblVoteTmc_Click(sender As System.Object, e As System.EventArgs) Handles lblVoteTmc.Click
        Dim webAddress As String = "http://www.mudconnect.com/cgi-bin/vote_rank.cgi?mud=Armageddon"
        Process.Start(webAddress)
        lblVoteTmc.Visible = False
        lblVoteTmc.Enabled = False
        tmcLastVote = DateTime.Now
    End Sub

    Private Sub lnklblPayUpdate_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnklblPayUpdate.LinkClicked
        UpdateControl(lnklblPayUpdate, False)
        SaveSetting(gRegistryName, gRegProgInitsName, "NextPayTime", nextTimePayAvailable)
        UpdatePayLabel(True)
    End Sub

#End Region 'Controls

#Region "Functions"

    Private Sub TimerHour_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrHour.Elapsed
        If formIsClosing = False Then
            RaiseEvent tmrHourTick()
        End If
    End Sub

    Public Sub DataReceived(ByVal strData As String)
        If InStr(strData, "*hp") > 0 Then 'Change to "hbeat" when prompt is changed
            ' Status Heartbeat
            HeartbeatReceived(strData)
        ElseIf InStr(strData, "damrep") > 0 Then
            ' Damage report
        ElseIf InStr(strData, "clanpay") > 0 Then
            ' Clan pay timer update
            Dim payDays() As String = strData.Split(" ")
            PayTimerUpdate(Val(payDays(1)))
        End If

        'For debug
        Console.WriteLine("Alive: " & mthUDPListener.IsAlive.ToString)
        Console.WriteLine("Context: " & mthUDPListener.CurrentContext.ToString)
        Console.WriteLine("State: " & mthUDPListener.ThreadState.ToString)
    End Sub

    Delegate Sub UpdateEnviroImagesDelegate(ByVal Updated As Boolean, ByVal UpdateEviroType As Boolean)
    Public Sub UpdateEnviroImages(Optional ByVal Updated As Boolean = False, Optional ByVal UpdateEviroType As Boolean = False) Handles Me.tmrHourTick
        ' See if we're on the worker thread and thus
        ' need to invoke the main UI thread.
        If Me.InvokeRequired Then
            ' Make arguments for the delegate.
            Dim args As Object() = {Updated, UpdateEviroType}

            ' Make the delegate.
            Dim UpdateEnviroImage_delegate As UpdateEnviroImagesDelegate = AddressOf UpdateEnviroImages

            ' Invoke the delegate on the main UI thread.
            Me.Invoke(UpdateEnviroImage_delegate, args)
            Exit Sub
        End If

        Dim OffsetTime As Integer = (DateTime.UtcNow.Minute + MinutesToAdd) Mod 10

        If (OffsetTime = 0 And NewHour = True) Or Updated = True Then
            If OffsetTime = 0 And NewHour = True Then
                NewHour = False
            End If

            GetSettings()

            If ReferenceTime > DateTime.UtcNow Then
                MsgBox("There appears to be a problem with your system time that will interfere with the function of this program.  Please check your system time before use.", MsgBoxStyle.Exclamation, "System Time Error")
                Me.Close()
                Exit Sub
            End If

            Dim GameHoursPassed As Integer = (DateTime.UtcNow.AddMinutes(MinutesToAdd) - ReferenceTime).TotalMinutes \ 10
            ' The partial hour change check below should no longer be necessary if MinutesToAdd is 0, since we are using a hard reference time with :00 minutes
            ' If ((DateTime.UtcNow.Minute + MinutesToAdd) Mod 10) < (ReferenceTime.Minute Mod 10) Then GameHoursPassed += 1
            ' We need to add an hour for rollover (:59 -> :00) even though it is less than an hour of time passage
            CurrentHour = (GameHoursPassed + UnexpectedOffsetFromUtc) Mod 9
            ' Yes, it seems weird that the UnexpectedOffsetFromUtc is before the Mod operator, but Mod doesn't actually divide, so the hours are added in full,
            ' and it must be here so we don't try to set the current hour to 10+

            Console.WriteLine("RefTime: " & ReferenceTime & " - Offset: " & UnexpectedOffsetFromUtc & " - CurTime: " & CurrentHour)

            'Set the Hour Properties
            Dim TimeTypeLabel As String() = {"T", "T2"}
            Dim BarTypeLabel As String() = {"_normal"}
            Dim TimeImage As Image = My.Resources.ResourceManager.GetObject("_" & (CurrentHour + 1) & TimeTypeLabel(TimeType))
            Dim BarImage As Image = My.Resources.ResourceManager.GetObject(BarTypeLabel(BarType))
            lblTimeLabel.Text = "It is currently " & HourData(CurrentHour).ToLower & "."

            'Create a new Bitmap Object
            'imgEnvironment = New System.Drawing.Bitmap(EnviroImage, TmpSize) ' Reference when using concrete sizes
            If TimeImage IsNot Nothing Then
                imgEnvironment = New System.Drawing.Bitmap(TimeImage)

                'pbxTime.Image = CType(imgEnvironment, Image)
            End If

            ' The bar image update should probably move to its own routine, so it can be called separately, when a UDP packet is received
            If BarImage IsNot Nothing Then
                imgBar = New System.Drawing.Bitmap(BarImage)

                'Resize form if necessary
                If UpdateEviroType = True Then
                    StyleForm(BarImage.Width, BarImage.Height)
                End If

                pbxEnviroment.Image = CType(imgBar, Image)
            End If

        ElseIf showVoteReminders = True Then
            If pagesToVote = 0 Or pagesToVote = 2 Then
                If DateTime.Now > tmsLastVote.AddHours(12) Then
                    If autoOpenVotePages = True Then
                        lblVoteTms_Click(lblVoteTms, System.EventArgs.Empty)
                    Else
                        lblVoteTms.Visible = True
                        lblVoteTms.Enabled = True
                    End If
                End If
            End If
            If pagesToVote = 1 Or pagesToVote = 2 Then
                If DateTime.Now > tmcLastVote.Date.AddDays(1) Then
                    If autoOpenVotePages = True Then
                        lblVoteTmc_Click(lblVoteTmc, System.EventArgs.Empty)
                    Else
                        lblVoteTmc.Visible = True
                        lblVoteTmc.Enabled = True
                    End If
                End If
            End If
        End If
        If showClanPayTimer = True Then
            lblClanPayTimer.Visible = True
            UpdatePayLabel(False)
        End If

        If OffsetTime >= 1 And NewHour = False Then
            ' Reset and wait for the next change of game hour
            NewHour = True
        End If

    End Sub

    Private Sub StyleForm(Optional ByVal TempX As Integer = 0, Optional ByVal TempY As Integer = 0)
        ' May need to re-get EnviroType if this routine is ever decoupled from GetSettings

        Dim MySize As System.Drawing.Size

        'If EnviroType = 0 Then
        MySize.Width = My.Resources._1T.Width
        MySize.Height = My.Resources._1T.Height + 238
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        Me.TransparencyKey = Me.BackColor
        'ElseIf EnviroType = 1 Then
        '    MySize.Width = My.Resources._1T2.Width
        '    MySize.Height = My.Resources._1T2.Height + 238
        '    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        '    Me.SetStyle(ControlStyles.SupportsTransparentBackColor, True)
        '    Me.TransparencyKey = Me.BackColor
        'Else
        '    If TempX > 0 And TempY > 0 Then
        '        CustomSizeX = TempX
        '        CustomSizeY = TempY
        '    End If

        '    ' We don't want to set the form bigger than the screen
        '    Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        '    Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height
        '    If CustomSizeX > screenWidth Then
        '        CustomSizeX = screenWidth - 50
        '    End If
        '    If CustomSizeY > screenHeight Then
        '        CustomSizeY = screenHeight - 50
        '    End If

        '    MySize.Width = CustomSizeX
        '    MySize.Height = CustomSizeY
        '    Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        '    Me.SetStyle(ControlStyles.SupportsTransparentBackColor, False)
        '    Me.TransparencyKey = Nothing
        'End If
        Me.Size = MySize

        Dim LabelSize As System.Drawing.Size = Me.lblTimeLabel.Size
        Dim LabelLoc As System.Drawing.Point = Me.lblTimeLabel.Location
        If TimeType = 1 And LabelSize.Height <> 41 Then
            LabelSize.Height += 18
            LabelLoc.Y -= 18
        ElseIf TimeType <> 1 And LabelSize.Height <> 23 Then
            LabelSize.Height -= 18
            LabelLoc.Y += 18
        End If
        'LabelSize.Height = 23
        'LabelLoc.Y = pbxEnviroment.Size.Height - 41
        Me.lblTimeLabel.Size = LabelSize
        Me.lblTimeLabel.Location = LabelLoc

    End Sub

    Private Sub GetSettings()

        UnexpectedOffsetFromUtc = GetSetting(gRegistryName, gRegProgInitsName, "HourOffset", 0)
        MinutesToAdd = GetSetting(gRegistryName, gRegProgInitsName, "MinOffset", 0)
        MinutesToAdd *= GetSetting(gRegistryName, gRegProgInitsName, "MinOffsetSign", 1)
        Me.TopMost = GetSetting(gRegistryName, gRegProgInitsName, "AlwaysOnTop", False)
        lblTimeLabel.Visible = GetSetting(gRegistryName, gRegProgInitsName, "OverlayLabel", False)
        TimeType = GetSetting(gRegistryName, gRegProgInitsName, "EnviroType", 0)
        LogoOverlay = GetSetting(gRegistryName, gRegProgInitsName, "OverlayLogo", True)
        LabelColorIndex = GetSetting(gRegistryName, gRegProgInitsName, "LabelStyle", 0)
        BackgroundSet = GetSetting(gRegistryName, gRegProgInitsName, "BackgroundSet", 0)
        IconSet = GetSetting(gRegistryName, gRegProgInitsName, "IconSet", 0)

        Dim LabelColorMatrix(,) As System.Drawing.Color = {{Color.Black, transparencyColor}, {Color.Black, Color.White}, {Color.White, transparencyColor}, {Color.White, Color.Black}, {Color.Gold, Color.Maroon}, {Color.LightGreen, Color.Black}}
        lblTimeLabel.ForeColor = LabelColorMatrix(LabelColorIndex, 0)
        lblTimeLabel.BackColor = LabelColorMatrix(LabelColorIndex, 1)
        'Black on Clear
        'Black on White
        'White on Clear
        'White on Black
        'Gold on Red
        'Green on Black

        showVoteReminders = GetSetting(gRegistryName, gRegProgInitsName, "VotingReminders", False)
        autoOpenVotePages = GetSetting(gRegistryName, gRegProgInitsName, "AutoOpenVotePage", False)
        pagesToVote = GetSetting(gRegistryName, gRegProgInitsName, "VotingSites", 2)
        Dim tmsLastRecordedVote As DateTime = CDate(GetSetting(gRegistryName, gRegProgInitsName, "TmsLastVote", New DateTime))
        If tmsLastRecordedVote > tmsLastVote Then tmsLastVote = tmsLastRecordedVote
        Dim tmcLastRecordedVote As DateTime = CDate(GetSetting(gRegistryName, gRegProgInitsName, "TmcLastVote", New DateTime))
        If tmcLastRecordedVote > tmsLastVote Then tmcLastVote = tmcLastRecordedVote

        If showVoteReminders = False Then
            lblVoteTms.Visible = False
            lblVoteTms.Enabled = False
            lblVoteTmc.Visible = False
            lblVoteTmc.Enabled = False
        ElseIf pagesToVote = 1 Then
            lblVoteTms.Visible = False
            lblVoteTms.Enabled = False
        ElseIf pagesToVote = 0 Then
            lblVoteTmc.Visible = False
            lblVoteTmc.Enabled = False
        End If

        showClanPayTimer = GetSetting(gRegistryName, gRegProgInitsName, "ClanPayTimer", False)
        enableDamageSystem = GetSetting(gRegistryName, gRegProgInitsName, "DamageSystemShown", False)

        If showClanPayTimer = False Then
            lblClanPayTimer.Visible = False
        Else
            UpdatePayLabel(True)
        End If

        If enableDamageSystem = True Then
            If damageTracker Is Nothing Then
                damageTracker = New classDamageTracker
            End If
        End If

    End Sub

    Private Sub GetInitSettings()

        Dim MyLoc As System.Drawing.Point
        CustomSizeX = GetSetting(gRegistryName, gRegProgInitsName, "SizeX", My.Resources._1T.Width)
        CustomSizeY = GetSetting(gRegistryName, gRegProgInitsName, "SizeY", My.Resources._1T.Height)
        MyLoc.X = GetSetting(gRegistryName, gRegProgInitsName, "LocX", 20)
        MyLoc.Y = GetSetting(gRegistryName, gRegProgInitsName, "LocY", 20)

        Me.Location = MyLoc

    End Sub

    Private Sub LoadGraphicSetSettings()
        Dim setRows(), newSetNames() As String
        Dim thisRow As Integer = 1 'First line of labels is discarded, second row is set to default in dim statement

        Try
            setRows = My.Resources.GraphicSets.Split(vbCrLf)
            Do While thisRow < setRows.Length - 1
                Dim currentCol As Integer = 1
                newSetNames = setRows(thisRow).Split(",")
                If newSetNames.Length >= currentCol And newSetNames(currentCol - 1).Trim <> "" And newSetNames(currentCol - 1).Trim.ToLower <> defaultSetName.ToLower Then
                    ReDim Preserve backgroundSetNames(backgroundSetNames.Length)
                    backgroundSetNames(backgroundSetNames.Length - 1) = newSetNames(currentCol - 1).Trim
                End If
                currentCol += 1
                If newSetNames.Length >= currentCol And newSetNames(currentCol - 1).Trim <> "" And newSetNames(currentCol - 1).Trim.ToLower <> defaultSetName.ToLower Then
                    ReDim Preserve iconSetNames(iconSetNames.Length)
                    iconSetNames(iconSetNames.Length - 1) = newSetNames(currentCol - 1).Trim
                End If
                thisRow += 1
            Loop
        Catch ex As Exception
            iconSetNames = {defaultSetName}
            backgroundSetNames = {defaultSetName}
            Console.WriteLine("Error processing set names.  Reverted to default")
        End Try

    End Sub

    Private Sub SaveSettings()

        SaveSetting(gRegistryName, gRegProgInitsName, "HourOffset", UnexpectedOffsetFromUtc)
        SaveSetting(gRegistryName, gRegProgInitsName, "MinOffset", IIf(MinutesToAdd < 0, MinutesToAdd * -1, MinutesToAdd))
        SaveSetting(gRegistryName, gRegProgInitsName, "MinOffsetSign", IIf(MinutesToAdd < 0, -1, 1))
        SaveSetting(gRegistryName, gRegProgInitsName, "AlwaysOnTop", Me.TopMost)
        SaveSetting(gRegistryName, gRegProgInitsName, "OverlayLogo", LogoOverlay)
        SaveSetting(gRegistryName, gRegProgInitsName, "OverlayLabel", lblTimeLabel.Visible)
        SaveSetting(gRegistryName, gRegProgInitsName, "SizeX", IIf(TimeType > 1, CustomSizeX, Me.Size.Width))
        SaveSetting(gRegistryName, gRegProgInitsName, "SizeY", IIf(TimeType > 1, CustomSizeX, Me.Size.Height))
        SaveSetting(gRegistryName, gRegProgInitsName, "LocX", Me.Location.X)
        SaveSetting(gRegistryName, gRegProgInitsName, "LocY", Me.Location.Y)
        SaveSetting(gRegistryName, gRegProgInitsName, "EnviroType", TimeType)
        SaveSetting(gRegistryName, gRegProgInitsName, "LabelStyle", LabelColorIndex)
        SaveSetting(gRegistryName, gRegProgInitsName, "VotingReminders", showVoteReminders)
        SaveSetting(gRegistryName, gRegProgInitsName, "AutoOpenVotePage", autoOpenVotePages)
        SaveSetting(gRegistryName, gRegProgInitsName, "VotingSites", pagesToVote)
        SaveSetting(gRegistryName, gRegProgInitsName, "TmsLastVote", tmsLastVote)
        SaveSetting(gRegistryName, gRegProgInitsName, "TmcLastVote", tmcLastVote)
        SaveSetting(gRegistryName, gRegProgInitsName, "BackgroundSet", BackgroundSet)
        SaveSetting(gRegistryName, gRegProgInitsName, "IconSet", IconSet)

    End Sub

    Public Sub HeartbeatReceived(ByVal strData As String)
        Dim dataArray() As String = strData.Split("_")

        Dim newStatusPacket As New StatusPacket
        newStatusPacket.currentHealth = -1
        newStatusPacket.totalHealth = -1
        newStatusPacket.currentStam = -1
        newStatusPacket.totalStam = -1
        newStatusPacket.currentStun = -1
        newStatusPacket.totalStun = -1
        newStatusPacket.currentMana = -1
        newStatusPacket.totalMana = -1
        newStatusPacket.currentTime = ""
        newStatusPacket.manaShown = True
        newStatusPacket.armed = StateNames.none
        newStatusPacket.position = StateNames.none ' status icon takes into account riding also
        newStatusPacket.speed = StateNames.none
        newStatusPacket.fighting = StateNames.normal ' fighting actually looks at the brief position variable, which updates when the user is fighting
        newStatusPacket.mounted = StateNames.none
        newStatusPacket.encumbrance = StateNames.none
        newStatusPacket.weather = ""
        newStatusPacket.otherInfo = ""

        ' Parse heartbeat data into structure here (may need to define custom prompt tags to separate terms)
        ' This is a fairly rudimentary data parsing mechanism.  A more robust mechanism could be used later, based on XML or something for configurability.
        ValueParse(dataArray, "*hp", newStatusPacket.currentHealth, newStatusPacket.totalHealth)
        ValueParse(dataArray, "*mv", newStatusPacket.currentStam, newStatusPacket.totalStam)
        ValueParse(dataArray, "*st", newStatusPacket.currentStun, newStatusPacket.totalStun)
        ValueParse(dataArray, "*mn", newStatusPacket.currentMana, newStatusPacket.totalMana)
        BooleanParse(dataArray, "*disman", "manaon", newStatusPacket.manaShown)
        StateParse(dataArray, "*arm", newStatusPacket.armed, False)
        StateParse(dataArray, "*pos", newStatusPacket.position, False)
        CheckForMimickingState(newStatusPacket.position, StateNames.fighting, StateNames.standing) ' If we are fighting AND standing, the prompt will show fighting, so mimic standing for position
        CheckForMimickingState(newStatusPacket.position, StateNames.sleeping, StateNames.resting) ' Sleeping may not be an actual position.  Needs testing.
        StateParse(dataArray, "*spd", newStatusPacket.speed, False)
        StateParse(dataArray, "*enc", newStatusPacket.encumbrance, False)
        CheckForMimickingState(newStatusPacket.encumbrance, StateNames.problem, StateNames.light) ' Make both green
        StateParse(dataArray, "*rid", newStatusPacket.mounted, True, StateNames.none, StateNames.mounted)
        StateParse(dataArray, "*pos", newStatusPacket.fighting, True, StateNames.fighting, StateNames.normal)
        ' None for fighting status was renamed to normal to make the image names more readable by the casual modder (and so it doesn't get confused with a 'none' image status)
        ' Fighting status is also taken from brief position info, so it is repeated here

        For i = 0 To HourData.Length - 1
            If strData.Contains(HourData(i)) Then
                newStatusPacket.currentTime = HourData(i)
                Exit For
            End If
        Next i

        UpdateStatusValues(newStatusPacket)
    End Sub

    Private Sub ValueParse(ByVal dataArray() As String, ByVal strToFind As String, ByRef statCurrent As Integer, ByRef statTotal As Integer)
        If dataArray.Contains(strToFind) Then
            If dataArray(Array.IndexOf(dataArray, strToFind) - 1).Contains("/") Then
                Dim statArray() As String = dataArray(Array.IndexOf(dataArray, strToFind) - 1).Split("/")
                statCurrent = Val(statArray(0))
                statTotal = Val(statArray(1))
            Else
                statCurrent = Val(dataArray(Array.IndexOf(dataArray, strToFind) - 1))
            End If
        End If
    End Sub

    ''' <summary>
    ''' This routine parses the values to find out if they are valid, and assign the corresponding graphical representations
    ''' </summary>
    ''' <param name="dataArray">The data from the heartbeat</param>
    ''' <param name="strLabel">The label in the array that we are looking for</param>
    ''' <param name="currentState">The state we are setting to a recognized parameter</param>
    ''' <param name="forceDichotomy">If true, the state must be one thing or another</param>
    ''' <param name="stateOptionPossible">If a dichotomy is forced, state must be this or it will be changed to stateOptionForcedOrAlt.</param>
    ''' <param name="stateOptionForced">If a dichotomy is forced, state must be this or it will be changed to stateOptionForcedOrAlt.  If not, they are treated as the same.</param>
    ''' <remarks></remarks>
    Private Sub StateParse(ByVal dataArray() As String, ByVal strLabel As String, ByRef currentState As StateNames, ByVal forceDichotomy As Boolean, Optional ByVal stateOptionPossible As StateNames = StateNames.none, Optional ByVal stateOptionForced As StateNames = StateNames.none)

        If dataArray.Contains(strLabel) Then
            Try
                ' Try to cast the variable before this label directly as a state
                currentState = [Enum].Parse(GetType(StateNames), dataArray(Array.IndexOf(dataArray, strLabel) - 1))
                If forceDichotomy = True Then
                    ' If this state must be one thing or the other, then set the forced option if we can't find the state that is possible in the variable anywhere
                    If currentState <> stateOptionPossible Then
                        currentState = stateOptionForced
                    End If
                End If
            Catch ex As Exception
                ' If that doesn't work...
                If Array.IndexOf(dataArray, strLabel) > 0 Then
                    Dim taggedVariable() As String = dataArray(Array.IndexOf(dataArray, strLabel) - 1).Split(" ")

                    If forceDichotomy = True Then
                        ' ...set the forced option if we can't find the state that is possible in the variable anywhere
                        currentState = stateOptionForced
                        For i = 0 To taggedVariable.Length - 1
                            If taggedVariable(i).Contains(stateOptionPossible.ToString) Then
                                currentState = stateOptionPossible
                                Exit For
                            End If
                        Next i
                    Else
                        ' ...set it to none if we can't cast a known state from the variable anywhere (currently used mostly for encumbrance, riding, fighting)
                        ' There is definitely the posibility here of picking up keywords of mounts or opponents.  Hopefully the ordering will prevent it.
                        currentState = StateNames.none
                        For i = 0 To taggedVariable.Length - 1
                            Try
                                Dim charsToTrim() As Char = {":"c, ","c, "."c, "-"c}
                                currentState = [Enum].Parse(GetType(StateNames), taggedVariable(i).Trim(charsToTrim))
                                Exit For
                            Catch ex2 As Exception
                                ' Do nothing, keep trying to cast, we already have a default value
                            End Try
                        Next i
                    End If
                Else
                    ' Original catch (We couldn't cast whatever single value was passed)
                    currentState = StateNames.none
                End If
            End Try
            'currentState = dataArray(Array.IndexOf(dataArray, strToFind) - labelOffset)
        Else
            currentState = StateNames.none
        End If
    End Sub

    Private Sub BooleanParse(ByVal dataArray() As String, ByVal strToFind As String, ByVal strToMatch As String, ByRef currentState As Boolean)
        If dataArray.Contains(strToFind) Then
            currentState = dataArray(Array.IndexOf(dataArray, strToFind) - 1).Contains(strToMatch)
        End If
    End Sub

    Private Sub CheckForMimickingState(ByRef currentState As StateNames, ByVal stateTriggeringMimic As StateNames, ByVal stateToMimic As StateNames)
        ' We want to set one state equal to another if they share a graphical representation.
        If currentState = stateTriggeringMimic Then
            currentState = stateToMimic
        End If
    End Sub

    Private Sub UpdateStatusValues(ByVal statusPacket As StatusPacket)
        statIcons(AllStats.Health).Show = ShowStat(statusPacket.totalHealth, nerStat1, lblHealth)
        If statIcons(AllStats.Health).Show Then
            UpdateControl(nerStat1, PrgTruncate((statusPacket.currentHealth / statusPacket.totalHealth) * 100))
            UpdateControl(lblHealth, statusPacket.currentHealth & " / " & statusPacket.totalHealth)
        End If
        statIcons(AllStats.Stamina).Show = ShowStat(statusPacket.totalStam, nerStat2, lblStam)
        If statIcons(AllStats.Stamina).Show Then
            UpdateControl(nerStat2, PrgTruncate((statusPacket.currentStam / statusPacket.totalStam) * 100))
            UpdateControl(lblStam, statusPacket.currentStam & " / " & statusPacket.totalStam)
        End If
        statIcons(AllStats.Stun).Show = ShowStat(statusPacket.totalStun, nerStat3, lblStun)
        If statIcons(AllStats.Stun).Show Then
            UpdateControl(nerStat3, PrgTruncate((statusPacket.currentStun / statusPacket.totalStun) * 100))
            UpdateControl(lblStun, statusPacket.currentStun & " / " & statusPacket.totalStun)
        End If
        If ShowStat(statusPacket.totalMana, nerStat4, lblMana) Then
            statIcons(AllStats.Mana).Show = ShowStat(statusPacket.manaShown, nerStat4, lblMana)
            If statIcons(AllStats.Mana).Show Then
                ' This call is nested to ensure that A) we have something to show and that B) the user wants it shown
                UpdateControl(nerStat4, PrgTruncate((statusPacket.currentMana / statusPacket.totalMana) * 100))
                UpdateControl(lblMana, statusPacket.currentMana & " / " & statusPacket.totalMana)
            End If
        End If
        'If ShowStat(statusPacket.currentTime, pbxTime, lblTimeLabel) Then
        '    ' We don't actually need to do anything here.  Time is better handled by the system time than by the prompt.
        '    ' We may, however, want to check that what time the prompt says it is matches what we think it is.
        'End If
        Dim otherImages(3) As String
        Dim otherStatuses() As StateNames = {statusPacket.armed, statusPacket.encumbrance, statusPacket.speed, IIf(statusPacket.mounted = StateNames.none, statusPacket.position, statusPacket.mounted)}
        For i = 0 To 3
            otherImages(i) = [Enum].GetName(GetType(StateNames), CType(otherStatuses(i), StateNames))
        Next i
        UpdateImages(statusPacket.fighting, otherImages)
        'UpdateEnviroImages() ' This may still be necessary, but isn't helping with the current problem of the sun clock disappearing when a UDP packet is received.
    End Sub

    Private Function PrgTruncate(ByVal value As Double) As Double
        ' Truncate the value to ensure we don't try to stick a bad value into the progress bar percentage

        If value < 0 Then
            value = 0
        ElseIf value > 100 Then
            value = 100
        End If

        Return value
    End Function

    Private Sub PayTimerUpdate(ByVal numDays As Integer)
        nextTimePayAvailable = DateTime.Now.AddMinutes(numDays * 90)
        Dim lastReportPayAvailable As Date = CDate(GetSetting(gRegistryName, gRegProgInitsName, "NextPayTime", DateTime.Now))
        If nextTimePayAvailable < lastReportPayAvailable Or nextTimePayAvailable > lastReportPayAvailable.AddMinutes(90) Then
            ' If it thinks our pay will be available sooner, or if pay was collected when the listener was not on (ie there is more than one game day difference), then show the update link (we can't just update, because it might not be a message for this character)
            UpdateControl(lnklblPayUpdate, True)
        End If
    End Sub

    Private Sub UpdatePayLabel(ByVal newVal As Boolean)
        ' No point in updating if the timer isn't shown
        If showClanPayTimer = True Then
            If newVal = True Then
                nextTimePayAvailable = CDate(GetSetting(gRegistryName, gRegProgInitsName, "NextPayTime", DateTime.Now))
            End If
            Dim timeTillPay As TimeSpan = nextTimePayAvailable - DateTime.Now

            If nextTimePayAvailable < DateTime.Now Then
                UpdateControl(lblClanPayTimer, "Pay Ready!")
            Else
                ' We can't use a formatting string unless we bump up to .NET 4+
                Dim payString As String = IIf(timeTillPay.Days > 0, timeTillPay.Days & ".", "")
                payString &= IIf(timeTillPay.Hours > 0 Or timeTillPay.Days > 0, timeTillPay.Hours.ToString.PadLeft(2, "0") & ":", ":")
                payString &= timeTillPay.Minutes.ToString.PadLeft(2, "0")
                UpdateControl(lblClanPayTimer, "P: " & payString)
            End If
        End If
    End Sub

    Private Sub StartListener()
        If udpListener Is Nothing Then
            udpListener = New classUDPListener
        End If
        Dim started As Boolean = udpListener.StartListener
    End Sub

    'Private Sub SendUDP(ByVal strData() As String)
    '    If udpSender Is Nothing Then
    '        udpSender = New classUDPSender
    '    End If
    '    udpSender.Main(strData)
    'End Sub

#End Region 'Functions

    '#Region "AppDomain Error Handling"
    '    ' Handle the UI exceptions by showing a dialog box, and asking the user whether 
    '    ' or not they wish to abort execution. 
    '    Private Shared Sub UIThreadException(ByVal sender As Object, ByVal t As ThreadExceptionEventArgs)
    '        Dim result As System.Windows.Forms.DialogResult = _
    '            System.Windows.Forms.DialogResult.Cancel
    '        Try
    '            result = ShowThreadExceptionDialog("Windows Forms Error", t.Exception)
    '        Catch
    '            Try
    '                MessageBox.Show("Fatal Windows Forms Error", _
    '                    "Fatal Windows Forms Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop)
    '            Finally
    '                Application.Exit()
    '            End Try
    '        End Try

    '        ' Exits the program when the user clicks Abort. 
    '        If result = DialogResult.Abort Then
    '            Application.Exit()
    '        End If
    '    End Sub

    '    ' Handle the UI exceptions by showing a dialog box, and asking the user whether 
    '    ' or not they wish to abort execution. 
    '    ' NOTE: This exception cannot be kept from terminating the application - it can only  
    '    ' log the event, and inform the user about it.  
    '    Private Shared Sub CurrentDomain_UnhandledException(ByVal sender As Object, _
    '    ByVal e As UnhandledExceptionEventArgs)
    '        Try
    '            Dim ex As Exception = CType(e.ExceptionObject, Exception)
    '            Dim errorMsg As String = "An application error occurred. Please contact the adminstrator " & _
    '                "with the following information:" & ControlChars.Lf & ControlChars.Lf

    '            ' Since we can't prevent the app from terminating, log this to the event log. 
    '            If (Not EventLog.SourceExists("ThreadException")) Then
    '                EventLog.CreateEventSource("ThreadException", "Application")
    '            End If

    '            ' Create an EventLog instance and assign its source. 
    '            Dim myLog As New EventLog()
    '            myLog.Source = "ThreadException"
    '            myLog.WriteEntry((errorMsg + ex.Message & ControlChars.Lf & ControlChars.Lf & _
    '                "Stack Trace:" & ControlChars.Lf & ex.StackTrace))
    '        Catch exc As Exception
    '            Try
    '                MessageBox.Show("Fatal Non-UI Error", "Fatal Non-UI Error. Could not write the error to the event log. " & _
    '                    "Reason: " & exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop)
    '            Finally
    '                Application.Exit()
    '            End Try
    '        End Try
    '    End Sub


    '    ' Creates the error message and displays it. 
    '    Private Shared Function ShowThreadExceptionDialog(ByVal title As String, ByVal e As Exception) As DialogResult
    '        Dim errorMsg As String = "An application error occurred. Please contact the adminstrator " & _
    '            "with the following information:" & ControlChars.Lf & ControlChars.Lf
    '        errorMsg = errorMsg & e.Message & ControlChars.Lf & _
    '            ControlChars.Lf & "Stack Trace:" & ControlChars.Lf & e.StackTrace

    '        Return MessageBox.Show(errorMsg, title, MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop)
    '    End Function
    '#End Region 'AppDomain Error Handling

#Region "Delegates"
    Delegate Sub delStopListener()
    Public Sub StopListener()
        If Me.InvokeRequired Then
            Dim delegateStopListener As delStopListener = AddressOf StopListener
            Me.Invoke(delegateStopListener)
        Else
            If udpListener IsNot Nothing Then
                Dim stopped As Boolean = udpListener.StopListener
                Try
                    udpListener = Nothing
                Catch ex As Exception

                End Try
            End If
        End If
    End Sub

    Delegate Sub UpdateControlDelegate(ByVal thisControl As Object, ByVal newValue As Object)
    Public Sub UpdateControl(ByVal thisControl As Object, ByVal newValue As Object)
        ' See if we're on the worker thread and thus
        ' need to invoke the main UI thread.
        If Me.InvokeRequired Then
            ' Make arguments for the delegate.
            Dim args As Object() = {thisControl, newValue}

            ' Make the delegate.
            Dim UpdateControl_delegate As UpdateControlDelegate = AddressOf UpdateControl

            ' Invoke the delegate on the main UI thread.
            Me.Invoke(UpdateControl_delegate, args)
            Exit Sub
        End If
        If TypeOf (thisControl) Is Windows.Forms.ProgressBar Then
            CType(thisControl, Windows.Forms.ProgressBar).Value = Val(CType(newValue, String))
        ElseIf TypeOf (thisControl) Is JCS.Components.NeroBar Then
            CType(thisControl, JCS.Components.NeroBar).Value = Val(CType(newValue, String))
        ElseIf TypeOf (thisControl) Is Windows.Forms.LinkLabel Then
            CType(thisControl, Windows.Forms.LinkLabel).Visible = CType(newValue, Boolean)
            CType(thisControl, Windows.Forms.LinkLabel).Enabled = CType(newValue, Boolean)
        ElseIf TypeOf (thisControl) Is Windows.Forms.Label Then
            CType(thisControl, Windows.Forms.Label).Text = CType(newValue, String)
        ElseIf TypeOf (thisControl) Is Windows.Forms.PictureBox Then
            ' Somewhat convoluted: parse the enum name into the name of an image in resources, load said image as a bitmap, then apply
            Dim StateImage As Image = My.Resources.ResourceManager.GetObject("_" & [Enum].GetName(GetType(StateNames), CType(newValue, StateNames)))

            'Create a new Bitmap Object
            If StateImage IsNot Nothing Then
                Dim imgState As Bitmap = New Bitmap(StateImage)

                CType(thisControl, Windows.Forms.PictureBox).Image = CType(imgState, Image)
            End If
        End If
    End Sub

    Delegate Sub UpdateImagesDelegate(ByVal mainImage As Object, ByVal otherImages() As String)
    Public Sub UpdateImages(ByVal mainImage As Object, ByVal otherImages() As String)
        ' See if we're on the worker thread and thus
        ' need to invoke the main UI thread.
        If Me.InvokeRequired Then
            ' Make arguments for the delegate.
            Dim args As Object() = {mainImage, otherImages}

            ' Make the delegate.
            Dim UpdateImages_delegate As UpdateImagesDelegate = AddressOf UpdateImages

            ' Invoke the delegate on the main UI thread.
            Me.Invoke(UpdateImages_delegate, args)
            Exit Sub
        End If

        ' Somewhat convoluted: parse the enum name into the name of an image in resources, load said image as a bitmap, then apply
        Dim BackgroundImage As Image
        Dim overlayLocs(,) As Integer = {{col1pbxXLoc, row2pbxYLoc}, {col2pbxXLoc, row1pbxYLoc}, {pbxEnviroment.Width - col2pbxXLoc, row1pbxYLoc}, {pbxEnviroment.Width - col1pbxXLoc, row2pbxYLoc}}

        Try
            If backgroundSetNames(BackgroundSet) = defaultSetName Then
                BackgroundImage = My.Resources.ResourceManager.GetObject([Enum].GetName(GetType(StateNames), CType(mainImage, StateNames)))
            Else
                ' This won't work, must load image by file name, not resource
                'BackgroundImage = My.Resources.ResourceManager.GetObject(backgroundSetNames(BackgroundSet) & [Enum].GetName(GetType(StateNames), CType(mainImage, StateNames)))

                BackgroundImage = Image.FromFile(".\Additional Images\" & backgroundSetNames(BackgroundSet) & [Enum].GetName(GetType(StateNames), CType(mainImage, StateNames)) & ".png")
            End If
        Catch ex As Exception
            ' If chosen background can't be found, load the default
            BackgroundImage = My.Resources.ResourceManager.GetObject([Enum].GetName(GetType(StateNames), CType(mainImage, StateNames)))
        End Try

        'Create a new Bitmap Object
        If BackgroundImage IsNot Nothing Then
            Dim backgroundState As Bitmap = New Bitmap(BackgroundImage)
            Dim allGraphics As Graphics = Graphics.FromImage(backgroundState)

            clockPbxXLoc = (pbxEnviroment.Width - imgEnvironment.Width) \ 2
            allGraphics.DrawImage(imgEnvironment, clockPbxXLoc, clockPbxYLoc)
            For i = 0 To otherImages.Length - 1
                If otherImages(i) <> [Enum].GetName(GetType(StateNames), CType(StateNames.none, StateNames)) Then
                    Dim overlayImage As Image
                    Try
                        If iconSetNames(IconSet) = defaultSetName Then
                            overlayImage = My.Resources.ResourceManager.GetObject(otherImages(i))
                        Else
                            ' This won't work, must load image by file name, not resource
                            'overlayImage = My.Resources.ResourceManager.GetObject(iconSetNames(IconSet) & otherImages(i))
                            overlayImage = Image.FromFile(".\Additional Images\" & iconSetNames(IconSet) & otherImages(i) & ".png")
                        End If
                    Catch ex As Exception
                        ' If chosen icon can't be found for this set, load the default
                        overlayImage = My.Resources.ResourceManager.GetObject(otherImages(i))
                    End Try
                    Dim thisOverlay As Bitmap = New Bitmap(overlayImage)
                    ' If we are on the right half of the images, we need to recalc distance away from the edge based on image size
                    Dim xLocation As Integer = IIf(i >= otherImages.Length / 2, overlayLocs(i, 0) - thisOverlay.Width, overlayLocs(i, 0))
                    allGraphics.DrawImage(thisOverlay, xLocation, overlayLocs(i, 1))
                End If
            Next i

            ' Add the stat bar mini icons
            For i = 0 To statIcons.Length - 1
                If statIcons(i).Show = True Then
                    Dim thisOverlay As Bitmap = New Bitmap(statIcons(i).iconImg)
                    allGraphics.DrawImage(thisOverlay, statIcons(i).xLoc, statIcons(i).yLoc, statIcons(i).xSize, statIcons(i).ySize)
                End If
            Next i

            ' Add the logo overlay on the whole form, if chosen in Options
            If LogoOverlay = True Then
                Try
                    Dim logoOverlayImage As Image
                    logoOverlayImage = My.Resources.ResourceManager.GetObject("logooverlay")
                    Dim thisOverlay As Bitmap = New Bitmap(logoOverlayImage)
                    logoPbxXLoc = (pbxEnviroment.Width - thisOverlay.Width) \ 2
                    allGraphics.DrawImage(thisOverlay, logoPbxXLoc, logoPbxYLoc)
                Catch ex As Exception
                    ' Do nothing
                    LogoOverlay = LogoOverlay
                End Try

            End If
            pbxEnviroment.Image = CType(backgroundState, Image)
        End If
    End Sub

    Delegate Function ShowStatDelegate(ByVal totalStat As Object, ByVal statDisplay As Control, ByVal statLabel As Control) As Boolean
    Private Function ShowStat(ByVal totalStat As Object, ByVal statDisplay As Control, Optional ByVal statLabel As Control = Nothing) As Boolean
        ' See if we're on the worker thread and thus
        ' need to invoke the main UI thread.
        If Me.InvokeRequired Then
            ' Make arguments for the delegate.
            Dim args As Object() = {totalStat, statDisplay, statLabel}

            ' Make the delegate.
            Dim ShowStat_delegate As ShowStatDelegate = AddressOf ShowStat

            ' Invoke the delegate on the main UI thread.
            ShowStat = Me.Invoke(ShowStat_delegate, args)
            Exit Function
        End If

        Dim statInUse As Boolean = True

        ' If the total stat value is less than zero, or empty, then the stat wasn't passed, and shouldn't be displayed
        If TypeOf (totalStat) Is Boolean Then
            statInUse = totalStat
        ElseIf TypeOf (totalStat) Is String Then
            If totalStat = "" OrElse (IsNumeric(totalStat) AndAlso CInt(totalStat) < 0) Then
                statInUse = False
            End If
        ElseIf TypeOf (totalStat) Is Integer Then
            If totalStat < 0 Then
                statInUse = False
            End If
        ElseIf TypeOf (totalStat) Is StateNames Then
            If totalStat = StateNames.none Then
                statInUse = False
            End If
        End If

        statDisplay.Visible = statInUse
        If statLabel IsNot Nothing Then
            statLabel.Visible = statInUse
        End If

        Return statInUse

    End Function

    'Delegate Sub delSetTopMost(ByVal newValue As Object)
    'Public Sub SetTopMost(ByVal newValue As Object)
    '    If Me.InvokeRequired Then
    '        Dim delegateSetTopMost As delSetTopMost = AddressOf SetTopMost
    '        Me.Invoke(delegateSetTopMost, newValue)
    '    Else
    '        Me.TopMost = newValue
    '    End If
    'End Sub

    'Delegate Sub delSetLabelForeColor(ByVal newValue As Object)
    'Public Sub SetLabelForeColor(ByVal newValue As Object)
    '    If Me.InvokeRequired Then
    '        Dim delegateSetLabelForeColor As delSetLabelForeColor = AddressOf SetLabelForeColor
    '        Me.Invoke(delegateSetLabelForeColor, newValue)
    '    Else
    '        lblTimeLabel.ForeColor = newValue
    '    End If
    'End Sub

    'Delegate Sub delSetLabelBackColor(ByVal newValue As Object)
    'Public Sub SetLabelBackColor(ByVal newValue As Object)
    '    If Me.InvokeRequired Then
    '        Dim delegateSetLabelBackColor As delSetLabelBackColor = AddressOf SetLabelBackColor
    '        Me.Invoke(delegateSetLabelBackColor, newValue)
    '    Else
    '        lblTimeLabel.BackColor = newValue
    '    End If
    'End Sub

    'Delegate Sub delSetLabelVisible(ByVal newValue As Object)
    'Public Sub SetLabelVisible(ByVal newValue As Object)
    '    If Me.InvokeRequired Then
    '        Dim delegateSetLabelVisible As delSetLabelVisible = AddressOf SetLabelVisible
    '        Me.Invoke(delegateSetLabelVisible, newValue)
    '    Else
    '        lblTimeLabel.Visible = newValue
    '    End If
    'End Sub

    'Delegate Sub delUpdateText(ByVal changeControl As Windows.Forms.Control, ByVal newValue As Object)
    'Public Sub UpdateText(ByVal changeControl As Windows.Forms.Control, ByVal newValue As Object)
    '    If changeControl.InvokeRequired Then
    '        Dim delegateUpdateText As delUpdateText = AddressOf UpdateText
    '        changeControl.Invoke(delegateUpdateText, changeControl, newValue)
    '    Else
    '        If TypeOf newValue Is String Then
    '            changeControl.Text = newValue
    '        ElseIf TypeOf newValue Is System.Drawing.Color Then
    '            changeControl.BackColor = newValue
    '        ElseIf TypeOf newValue Is Boolean Then
    '            changeControl.Enabled = newValue
    '        End If
    '    End If
    'End Sub

#End Region 'Delegates

#Region "Threading"

    Public Sub InitThread()

        If mthUDPListener Is Nothing Then
            mthUDPListener = New Thread(New ThreadStart(AddressOf StartListener))
        End If
        mthUDPListener.Priority = ThreadPriority.Normal
        mthUDPListener.Name = "UDP Listener Thread"
        mthUDPListener.SetApartmentState(ApartmentState.STA) ' Necessary to get InitializeComponent() to run correctly in the controls' New() subs
        mthUDPListener.Start()

    End Sub

    'Private Sub InitThread2()

    '    If mthUDPSender Is Nothing Then
    '        mthUDPSender = New Thread(New ThreadStart(AddressOf SendUDP))
    '    End If
    '    mthUDPSender.Priority = ThreadPriority.Normal
    '    mthUDPSender.Name = "UDP Sender Thread"
    '    mthUDPSender.SetApartmentState(ApartmentState.STA) ' Necessary to get InitializeComponent() to run correctly in the controls' New() subs
    '    mthUDPSender.Start()

    'End Sub

    Private Sub UnInitThread()

        If mthUDPListener IsNot Nothing Then
            Try
                mthUDPListener.Abort()
                mthUDPListener.Join(500)
                mthUDPListener = Nothing
            Catch ex As Exception
                'ignore the exception
            End Try
        End If
        'If mthUDPSender IsNot Nothing Then
        '    Try
        '        mthUDPSender.Abort()
        '        mthUDPSender.Join(500)
        '        mthUDPSender = Nothing
        '    Catch ex As Exception
        '        'ignore the exception
        '    End Try
        'End If
    End Sub

#End Region 'Threading

#Region "Notes"
#If False Then
    Other possible uses for UDP send / receive

    Track clan pay reset times
    Track and highlight after disarm/bash messages in combat
    Send feel messages to client at certain levels of hp/mv/st/mn
    Track damage to body parts and change status level at 15% / 30% overall health lost at that part (grn -> Yellow -> red)
    Track big hits to body parts and send random chance major/permanent damage emotes to client at big hits that drop char below 60% / 20%
        (IE 'very hard' to the head that drops PC past 60% could cause bloody nose (30%), black eye (20%), fat lip (20%), broken nose (5%), swollen shut eye (5%), lost tooth (5%), nothing (15%))
        (Panel would track healing time to body parts on stick figure, and major injuries with individual flags, send periodic 'feel's to client while injured)
    Send 'weather' command every 5-10 minutes and represent result
    Auto-consent message
    More common disease code (outside, caves, mounts, STDs)
    Auto-disease emotes (mental, itching, burning, twitching, flaking, odors, etc.)

#End If
#End Region 'Notes

End Class
