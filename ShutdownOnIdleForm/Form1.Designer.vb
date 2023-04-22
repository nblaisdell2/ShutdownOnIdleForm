<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTimer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnSubDay = New System.Windows.Forms.Button()
        Me.btnSubHour = New System.Windows.Forms.Button()
        Me.btnSubMin = New System.Windows.Forms.Button()
        Me.btnAddDay = New System.Windows.Forms.Button()
        Me.btnAddHour = New System.Windows.Forms.Button()
        Me.btnAddMin = New System.Windows.Forms.Button()
        Me.btnEnableToggle = New System.Windows.Forms.Button()
        Me.btnShutdown = New System.Windows.Forms.Button()
        Me.pnlTimerBackground = New System.Windows.Forms.Panel()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.btnResetTimer = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlTimerBackground.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Gill Sans Ultra Bold", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(180, 16)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(314, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Shutdown On Idle"
        '
        'btnSubDay
        '
        Me.btnSubDay.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSubDay.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubDay.Location = New System.Drawing.Point(18, 41)
        Me.btnSubDay.Name = "btnSubDay"
        Me.btnSubDay.Size = New System.Drawing.Size(130, 42)
        Me.btnSubDay.TabIndex = 1
        Me.btnSubDay.Text = "-1 Day"
        Me.btnSubDay.UseVisualStyleBackColor = False
        '
        'btnSubHour
        '
        Me.btnSubHour.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSubHour.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubHour.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubHour.Location = New System.Drawing.Point(18, 89)
        Me.btnSubHour.Name = "btnSubHour"
        Me.btnSubHour.Size = New System.Drawing.Size(130, 42)
        Me.btnSubHour.TabIndex = 2
        Me.btnSubHour.Text = "-1 Hour"
        Me.btnSubHour.UseVisualStyleBackColor = False
        '
        'btnSubMin
        '
        Me.btnSubMin.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSubMin.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSubMin.Location = New System.Drawing.Point(18, 137)
        Me.btnSubMin.Name = "btnSubMin"
        Me.btnSubMin.Size = New System.Drawing.Size(130, 42)
        Me.btnSubMin.TabIndex = 3
        Me.btnSubMin.Text = "-1 Minute"
        Me.btnSubMin.UseVisualStyleBackColor = False
        '
        'btnAddDay
        '
        Me.btnAddDay.BackColor = System.Drawing.Color.Green
        Me.btnAddDay.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddDay.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddDay.Location = New System.Drawing.Point(523, 41)
        Me.btnAddDay.Name = "btnAddDay"
        Me.btnAddDay.Size = New System.Drawing.Size(130, 42)
        Me.btnAddDay.TabIndex = 4
        Me.btnAddDay.Text = "+1 Day"
        Me.btnAddDay.UseVisualStyleBackColor = False
        '
        'btnAddHour
        '
        Me.btnAddHour.BackColor = System.Drawing.Color.Green
        Me.btnAddHour.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddHour.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddHour.Location = New System.Drawing.Point(523, 89)
        Me.btnAddHour.Name = "btnAddHour"
        Me.btnAddHour.Size = New System.Drawing.Size(130, 42)
        Me.btnAddHour.TabIndex = 5
        Me.btnAddHour.Text = "+1 Hour"
        Me.btnAddHour.UseVisualStyleBackColor = False
        '
        'btnAddMin
        '
        Me.btnAddMin.BackColor = System.Drawing.Color.Green
        Me.btnAddMin.Font = New System.Drawing.Font("Britannic Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddMin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddMin.Location = New System.Drawing.Point(523, 137)
        Me.btnAddMin.Name = "btnAddMin"
        Me.btnAddMin.Size = New System.Drawing.Size(130, 42)
        Me.btnAddMin.TabIndex = 6
        Me.btnAddMin.Text = "+1 Minute"
        Me.btnAddMin.UseVisualStyleBackColor = False
        '
        'btnEnableToggle
        '
        Me.btnEnableToggle.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnEnableToggle.Location = New System.Drawing.Point(115, 195)
        Me.btnEnableToggle.Name = "btnEnableToggle"
        Me.btnEnableToggle.Size = New System.Drawing.Size(134, 68)
        Me.btnEnableToggle.TabIndex = 7
        Me.btnEnableToggle.Text = "Disable Timer"
        Me.btnEnableToggle.UseVisualStyleBackColor = True
        '
        'btnShutdown
        '
        Me.btnShutdown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnShutdown.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShutdown.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnShutdown.Location = New System.Drawing.Point(413, 195)
        Me.btnShutdown.Name = "btnShutdown"
        Me.btnShutdown.Size = New System.Drawing.Size(134, 68)
        Me.btnShutdown.TabIndex = 8
        Me.btnShutdown.Text = "Shutdown Now"
        Me.btnShutdown.UseVisualStyleBackColor = False
        '
        'pnlTimerBackground
        '
        Me.pnlTimerBackground.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnlTimerBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pnlTimerBackground.Controls.Add(Me.Label4)
        Me.pnlTimerBackground.Controls.Add(Me.Label3)
        Me.pnlTimerBackground.Controls.Add(Me.Label2)
        Me.pnlTimerBackground.Controls.Add(Me.Label1)
        Me.pnlTimerBackground.Controls.Add(Me.lblTimer)
        Me.pnlTimerBackground.Location = New System.Drawing.Point(165, 64)
        Me.pnlTimerBackground.Name = "pnlTimerBackground"
        Me.pnlTimerBackground.Size = New System.Drawing.Size(342, 100)
        Me.pnlTimerBackground.TabIndex = 9
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTimer.Location = New System.Drawing.Point(3, 20)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(335, 63)
        Me.lblTimer.TabIndex = 10
        Me.lblTimer.Text = "00:00:00:00"
        '
        'btnResetTimer
        '
        Me.btnResetTimer.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnResetTimer.Location = New System.Drawing.Point(264, 195)
        Me.btnResetTimer.Name = "btnResetTimer"
        Me.btnResetTimer.Size = New System.Drawing.Size(134, 68)
        Me.btnResetTimer.TabIndex = 11
        Me.btnResetTimer.Text = "Reset Timer"
        Me.btnResetTimer.UseVisualStyleBackColor = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(22, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 18)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Days"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(102, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 18)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Hours"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(180, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Minutes"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Cascadia Mono SemiBold", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(263, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 18)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Seconds"
        '
        'frmTimer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(673, 291)
        Me.Controls.Add(Me.btnResetTimer)
        Me.Controls.Add(Me.pnlTimerBackground)
        Me.Controls.Add(Me.btnShutdown)
        Me.Controls.Add(Me.btnEnableToggle)
        Me.Controls.Add(Me.btnAddMin)
        Me.Controls.Add(Me.btnAddHour)
        Me.Controls.Add(Me.btnAddDay)
        Me.Controls.Add(Me.btnSubMin)
        Me.Controls.Add(Me.btnSubHour)
        Me.Controls.Add(Me.btnSubDay)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmTimer"
        Me.Text = "Shutdown On Idle"
        Me.pnlTimerBackground.ResumeLayout(False)
        Me.pnlTimerBackground.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnSubDay As Button
    Friend WithEvents btnSubHour As Button
    Friend WithEvents btnSubMin As Button
    Friend WithEvents btnAddDay As Button
    Friend WithEvents btnAddHour As Button
    Friend WithEvents btnAddMin As Button
    Friend WithEvents btnEnableToggle As Button
    Friend WithEvents btnShutdown As Button
    Friend WithEvents pnlTimerBackground As Panel
    Friend WithEvents lblTimer As Label
    Friend WithEvents btnResetTimer As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
