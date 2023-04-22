Imports Newtonsoft.Json
Imports ShutdownOnIdleForm.Timer

Imports Microsoft.Win32.TaskScheduler

Public Class frmTimer
    Implements ITimer

    Dim mTimer As Timer
    ReadOnly SHUTDOWN_IDLE_SECONDS As ULong = (60 * 120 * 1000)

    Dim thread As Threading.Thread

    Dim menu As New ContextMenuStrip

    Dim pathConfig As String
    Dim jConfig As Config

    Public Sub UpdateTimer(timer As Timer)
        If (InvokeRequired) Then
            Try
                Me.Invoke(New Action(Of Timer)(AddressOf UpdateTimer), New Object() {timer})
            Catch ex As Exception

            End Try

            Return
        End If

        lblTimer.Text = timer.GetTimerString()
    End Sub

    Public Function GetConfig(ByVal filePath As String) As Config
        Dim config As Config

        'If (filePath.ToLower().Equals("c:\windows\system32\config.json")) Then
        '    Return New Config With {
        '        .isEnabled = True,
        '        .totalTime = SHUTDOWN_IDLE_SECONDS
        '    }
        'End If

        If (Not IO.File.Exists(filePath)) Then
            IO.File.Create(filePath).Close()

            config = New Config With {
                .isEnabled = True,
                .totalTime = SHUTDOWN_IDLE_SECONDS
            }
        Else
            Dim configText As String = IO.File.ReadAllText(filePath)

            If (configText.Equals("")) Then
                config = New Config With {
                    .isEnabled = True,
                    .totalTime = SHUTDOWN_IDLE_SECONDS
                }
            Else
                config = JsonConvert.DeserializeObject(Of Config)(configText)
            End If
        End If

        Return config
    End Function

    Private Sub frmTimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using ts As New TaskService()
            Dim task As Task = ts.FindTask("Shutdown on Idle v2")

            If (task Is Nothing) Then
                'Define the task, since this is the first time that the user has used the program
                Dim tDef As TaskDefinition = ts.NewTask()
                tDef.RegistrationInfo.Description = "Shutdown on Idle v2"
                tDef.Triggers.Add(New LogonTrigger() With {.UserId = Environment.UserName})
                tDef.Actions.Add(New ExecAction("C:\Personal\scripts\ShutdownOnIdle_v2.exe"))
                task = ts.RootFolder.RegisterTaskDefinition("Shutdown on Idle v2", tDef)
            End If
        End Using

        pathConfig = Environment.CurrentDirectory + "\config.json"
        jConfig = GetConfig(pathConfig)

        mTimer = New Timer(jConfig)
        mTimer.SetOnTimerChangedListener(Me)

        menu = New ContextMenuStrip
        menu.Items.Add(If(jConfig.isEnabled, "Disable", "Enable"), Nothing, AddressOf ToggleTimerEnabled)
        menu.Items.Add("Quit", Nothing, AddressOf CloseProgram)

        UpdateTimer(mTimer)
        btnEnableToggle.Text = If(jConfig.isEnabled, "Disable Timer", "Enable Timer")

        StartTimer()

        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CloseProgram()
        Application.ExitThread()
        Environment.Exit(0)
    End Sub

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        mTimer.ShutdownPC()
        Me.Close()
    End Sub

    Private Sub btnResetTimer_Click(sender As Object, e As EventArgs) Handles btnResetTimer.Click
        mTimer.ResetTimer()
        UpdateTimer(mTimer)

        StartTimer()
    End Sub

    Public Sub StartTimer()
        If (jConfig.isEnabled) Then
            If (thread Is Nothing OrElse (thread.ThreadState And Not ThreadState.Running)) Then
                thread = New Threading.Thread(New Threading.ThreadStart(AddressOf mTimer.Run))
                thread.Start()
            End If
        End If
    End Sub

    Private Sub btnEnableToggle_Click(sender As Object, e As EventArgs) Handles btnEnableToggle.Click
        ToggleTimerEnabled()
    End Sub

    Public Sub ToggleTimerEnabled()
        If (mTimer.IsEnabled()) Then
            mTimer.SetShouldExit(True)
            mTimer.RestartTimer()
            UpdateTimer(mTimer)

            btnEnableToggle.Text = "Enable Timer"
            menu.Items.Item(0).Text = "Enable"
        Else
            mTimer.SetShouldExit(False)

            btnEnableToggle.Text = "Disable Timer"
            menu.Items.Item(0).Text = "Disable"
        End If

        mTimer.ToggleEnabled()
        jConfig.isEnabled = Not jConfig.isEnabled
        UpdateConfig()
        StartTimer()
    End Sub

    Private Sub btnSubDay_Click(sender As Object, e As EventArgs) Handles btnSubDay.Click
        mTimer.ModifyTimer(TimerAmount.Day, False)
        UpdateTimer(mTimer)
        UpdateConfig()
    End Sub

    Private Sub btnSubHour_Click(sender As Object, e As EventArgs) Handles btnSubHour.Click
        mTimer.ModifyTimer(TimerAmount.Hour, False)
        UpdateTimer(mTimer)
        UpdateConfig()
    End Sub

    Private Sub btnSubMin_Click(sender As Object, e As EventArgs) Handles btnSubMin.Click
        mTimer.ModifyTimer(TimerAmount.Minute, False)
        UpdateTimer(mTimer)
        UpdateConfig()
    End Sub

    Private Sub btnAddDay_Click(sender As Object, e As EventArgs) Handles btnAddDay.Click
        mTimer.ModifyTimer(TimerAmount.Day, True)
        UpdateTimer(mTimer)
        UpdateConfig()
    End Sub

    Private Sub btnAddHour_Click(sender As Object, e As EventArgs) Handles btnAddHour.Click
        mTimer.ModifyTimer(TimerAmount.Hour, True)
        UpdateTimer(mTimer)
        UpdateConfig()
    End Sub

    Private Sub btnAddMin_Click(sender As Object, e As EventArgs) Handles btnAddMin.Click
        mTimer.ModifyTimer(TimerAmount.Minute, True)
        UpdateTimer(mTimer)
        UpdateConfig()
    End Sub

    Public Sub UpdateConfig()
        jConfig.totalTime = mTimer.GetTotalTime()
        IO.File.WriteAllText(pathConfig, JsonConvert.SerializeObject(jConfig))
    End Sub

    Public Sub IdleTimeChanged(idleTime As ULong) Implements Timer.ITimer.IdleTimeChanged
        UpdateTimer(mTimer)
    End Sub

    Private Sub frmTimer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmTimer_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            NotifyIcon1.Visible = True
            NotifyIcon1.Text = "Shutdown On Idle"
            NotifyIcon1.Icon = SystemIcons.Application
            NotifyIcon1.ContextMenuStrip = menu
            'NotifyIcon1.BalloonTipIcon = ToolTipIcon.Info
            'NotifyIcon1.BalloonTipTitle = "Title"
            'NotifyIcon1.BalloonTipText = "This is my text"
            'NotifyIcon1.ShowBalloonTip(50000)
            'Me.Hide()
            ShowInTaskbar = False
        End If
    End Sub

    Private Sub NotifyIcon1_DoubleClick(sender As Object, e As EventArgs) Handles NotifyIcon1.DoubleClick
        'Me.Show()
        ShowInTaskbar = True
        Me.WindowState = FormWindowState.Normal
        NotifyIcon1.Visible = False
    End Sub
End Class
