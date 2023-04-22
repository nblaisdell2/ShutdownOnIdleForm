Option Explicit On

Imports System.Runtime.InteropServices

Public Class Timer
    Public Interface ITimer
        Sub IdleTimeChanged(ByVal idleTime As ULong)
    End Interface

    <StructLayout(LayoutKind.Sequential)> Structure LASTINPUTINFO
        <MarshalAs(UnmanagedType.U4)> Public cbSize As Integer
        <MarshalAs(UnmanagedType.U4)> Public dwTime As Integer
    End Structure

    <DllImport("user32.dll")>
    Shared Function GetLastInputInfo(ByRef plii As LASTINPUTINFO) As Boolean
    End Function

    Private mIsEnabled As Boolean
    Private mCurrIdleTime As ULong
    Private mInitIdleTime As ULong
    Private mTotalIdleTime As ULong
    Private mShouldExit As Boolean = False

    Private mListener As ITimer

    Public Enum TimerAmount
        Day
        Hour
        Minute
    End Enum

    Public Class Config
        Public isEnabled As Boolean
        Public totalTime As ULong
    End Class

    Public Sub New(ByVal config As Config)
        mIsEnabled = config.isEnabled
        mInitIdleTime = config.totalTime
        mTotalIdleTime = mInitIdleTime
        mCurrIdleTime = 0
    End Sub

    Public Sub SetOnTimerChangedListener(ByRef listener As ITimer)
        mListener = listener
    End Sub

    Public Function GetTotalTime() As ULong
        Return mTotalIdleTime
    End Function

    Public Function ShouldExit() As Boolean
        Return mShouldExit
    End Function

    Public Function IsEnabled() As Boolean
        Return mIsEnabled
    End Function

    Public Sub SetShouldExit(ByVal v As Boolean)
        mShouldExit = v
    End Sub

    Public Sub ToggleEnabled()
        mIsEnabled = Not mIsEnabled
    End Sub

    Public Sub SetEnabled(ByVal v As Boolean)
        mIsEnabled = v
    End Sub

    Public Sub ResetTimer()
        mCurrIdleTime = 0
        mTotalIdleTime = mInitIdleTime
    End Sub

    Public Sub RestartTimer()
        mCurrIdleTime = 0
    End Sub

    Public Sub ModifyTimer(ByVal amt As TimerAmount, ByVal add As Boolean)
        Dim amtToModify As ULong

        Select Case (amt)
            Case TimerAmount.Day
                amtToModify = 24 * 60 * 60 * 1000
                Exit Select
            Case TimerAmount.Hour
                amtToModify = 60 * 60 * 1000
                Exit Select
            Case TimerAmount.Minute
                amtToModify = 60 * 1000
                Exit Select
            Case Else
                amtToModify = 0
                Exit Select
        End Select

        If (add) Then
            mTotalIdleTime += amtToModify
        Else
            Dim n As Int64 = CType(mTotalIdleTime, Int64) - CType(amtToModify, Int64)
            If (n < 0) Then
                mTotalIdleTime = 0
            Else
                mTotalIdleTime -= amtToModify
            End If
        End If
    End Sub

    Public Function GetTimerString() As String
        Dim timerTime As Int64 = CType(mTotalIdleTime, Int64) - CType(mCurrIdleTime, Int64)

        If (timerTime <= 0) Then
            Return "00:00:00:00"
        End If

        Dim day As Integer = Math.Floor((timerTime / 1000.0 / 60.0 / 60.0 / 24.0) Mod 60)
        Dim hour As Integer = Math.Floor((timerTime / 1000.0 / 60.0 / 60.0 Mod 24.0) Mod 60)
        Dim min As Integer = Math.Floor((timerTime / 1000.0 / 60.0 Mod (60.0 * 24.0)) Mod 60)
        Dim sec As Integer = Math.Floor((timerTime / 1000.0 Mod (60.0 * 60.0 * 24.0)) Mod 60)

        Debug.WriteLine("timerTime: {0}", timerTime)
        Debug.WriteLine("  day : {0}", day)
        Debug.WriteLine("  hour: {0}", hour)
        Debug.WriteLine("  min : {0}", min)
        Debug.WriteLine("  sec : {0}", sec)
        Debug.WriteLine("")

        Return String.Format("{0}:{1}:{2}:{3}", day.ToString("D2"), hour.ToString("D2"), min.ToString("D2"), sec.ToString("D2"))
    End Function

    Public Sub Run()
        Dim lii As New LASTINPUTINFO

        lii.cbSize = CUInt(Marshal.SizeOf(lii))
        lii.dwTime = 0

        While (mCurrIdleTime < mTotalIdleTime)
            If (mShouldExit) Then
                Exit While
            End If

            'If (Not mIsResumed) Then
            '    Threading.Thread.Sleep(500)
            '    Continue While
            'End If

            If (Not GetLastInputInfo(lii)) Then
                Exit While
            End If

            'Calculate the idle time
            'Dim lastInput = lii.dwTime
            'Dim tickCount = Environment.TickCount
            'Debug.WriteLine("LastInput: " + lastInput.ToString())
            'Debug.WriteLine("TickCount: " + tickCount.ToString())

            mCurrIdleTime = TimeSpan.FromMilliseconds(Environment.TickCount - lii.dwTime).TotalMilliseconds
            mListener.IdleTimeChanged(mCurrIdleTime)

            'Debug.WriteLine("CurrIdle: " + currIdleTime.ToString())
        End While

        If (Not mShouldExit) Then
            ShutdownPC()
        End If
    End Sub

    Public Sub ShutdownPC()
        ' Wait a short time before shutting down the PC after the last loop
        Threading.Thread.Sleep(500)
        Process.Start("shutdown", "-s -t 3")
    End Sub
End Class
