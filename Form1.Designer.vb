<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Install_Path = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.anti_status = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.program_status = New System.Windows.Forms.Label()
        Me.Activate = New System.Windows.Forms.Button()
        Me.Deactivate = New System.Windows.Forms.Button()
        Me.Start_with_launcher = New System.Windows.Forms.Button()
        Me.Start_Game = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Game_version = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Server = New System.Windows.Forms.Label()
        Me.Channel = New System.Windows.Forms.Label()
        Me.Official = New System.Windows.Forms.Button()
        Me.Bilibili = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Game Path:"
        '
        'Install_Path
        '
        Me.Install_Path.AutoSize = True
        Me.Install_Path.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Install_Path.ForeColor = System.Drawing.Color.Orange
        Me.Install_Path.Location = New System.Drawing.Point(140, 35)
        Me.Install_Path.Name = "Install_Path"
        Me.Install_Path.Size = New System.Drawing.Size(206, 26)
        Me.Install_Path.TabIndex = 1
        Me.Install_Path.Text = "Reading Registry......"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Anti Harmony Status:"
        '
        'anti_status
        '
        Me.anti_status.AutoSize = True
        Me.anti_status.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.anti_status.ForeColor = System.Drawing.Color.Orange
        Me.anti_status.Location = New System.Drawing.Point(235, 139)
        Me.anti_status.Name = "anti_status"
        Me.anti_status.Size = New System.Drawing.Size(82, 26)
        Me.anti_status.TabIndex = 3
        Me.anti_status.Text = "Loaded"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 26)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Program Status:"
        '
        'program_status
        '
        Me.program_status.AutoSize = True
        Me.program_status.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.program_status.ForeColor = System.Drawing.Color.LimeGreen
        Me.program_status.Location = New System.Drawing.Point(183, 9)
        Me.program_status.Name = "program_status"
        Me.program_status.Size = New System.Drawing.Size(104, 26)
        Me.program_status.TabIndex = 5
        Me.program_status.Text = "Activated"
        '
        'Activate
        '
        Me.Activate.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Activate.Location = New System.Drawing.Point(12, 217)
        Me.Activate.Name = "Activate"
        Me.Activate.Size = New System.Drawing.Size(275, 43)
        Me.Activate.TabIndex = 6
        Me.Activate.Text = "Activate Anti-program"
        Me.Activate.UseVisualStyleBackColor = True
        '
        'Deactivate
        '
        Me.Deactivate.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Deactivate.Location = New System.Drawing.Point(297, 217)
        Me.Deactivate.Name = "Deactivate"
        Me.Deactivate.Size = New System.Drawing.Size(275, 43)
        Me.Deactivate.TabIndex = 7
        Me.Deactivate.Text = "Deactivate Anti-program"
        Me.Deactivate.UseVisualStyleBackColor = True
        '
        'Start_with_launcher
        '
        Me.Start_with_launcher.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Start_with_launcher.Location = New System.Drawing.Point(12, 266)
        Me.Start_with_launcher.Name = "Start_with_launcher"
        Me.Start_with_launcher.Size = New System.Drawing.Size(560, 43)
        Me.Start_with_launcher.TabIndex = 8
        Me.Start_with_launcher.Text = "Start The Game Using Default Launcher"
        Me.Start_with_launcher.UseVisualStyleBackColor = True
        '
        'Start_Game
        '
        Me.Start_Game.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Start_Game.Location = New System.Drawing.Point(12, 315)
        Me.Start_Game.Name = "Start_Game"
        Me.Start_Game.Size = New System.Drawing.Size(560, 43)
        Me.Start_Game.TabIndex = 9
        Me.Start_Game.Text = "Start The Game Directly (Recommend)"
        Me.Start_Game.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 26)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Game Version:"
        '
        'Game_version
        '
        Me.Game_version.AutoSize = True
        Me.Game_version.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Game_version.ForeColor = System.Drawing.Color.Orange
        Me.Game_version.Location = New System.Drawing.Point(169, 61)
        Me.Game_version.Name = "Game_version"
        Me.Game_version.Size = New System.Drawing.Size(206, 26)
        Me.Game_version.TabIndex = 11
        Me.Game_version.Text = "Reading Registry......"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Game Server:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 26)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Game Channel:"
        '
        'Server
        '
        Me.Server.AutoSize = True
        Me.Server.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Server.ForeColor = System.Drawing.Color.Orange
        Me.Server.Location = New System.Drawing.Point(157, 87)
        Me.Server.Name = "Server"
        Me.Server.Size = New System.Drawing.Size(161, 26)
        Me.Server.TabIndex = 14
        Me.Server.Text = "Reading File......"
        '
        'Channel
        '
        Me.Channel.AutoSize = True
        Me.Channel.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Channel.ForeColor = System.Drawing.Color.Orange
        Me.Channel.Location = New System.Drawing.Point(174, 113)
        Me.Channel.Name = "Channel"
        Me.Channel.Size = New System.Drawing.Size(161, 26)
        Me.Channel.TabIndex = 15
        Me.Channel.Text = "Reading File......"
        '
        'Official
        '
        Me.Official.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Official.Location = New System.Drawing.Point(297, 168)
        Me.Official.Name = "Official"
        Me.Official.Size = New System.Drawing.Size(275, 43)
        Me.Official.TabIndex = 17
        Me.Official.Text = "Switch to Official Server"
        Me.Official.UseVisualStyleBackColor = True
        '
        'Bilibili
        '
        Me.Bilibili.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Bilibili.Location = New System.Drawing.Point(12, 168)
        Me.Bilibili.Name = "Bilibili"
        Me.Bilibili.Size = New System.Drawing.Size(275, 43)
        Me.Bilibili.TabIndex = 16
        Me.Bilibili.Text = "Switch to Bilibili Server"
        Me.Bilibili.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 372)
        Me.Controls.Add(Me.Official)
        Me.Controls.Add(Me.Bilibili)
        Me.Controls.Add(Me.Channel)
        Me.Controls.Add(Me.Server)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Game_version)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Start_Game)
        Me.Controls.Add(Me.Start_with_launcher)
        Me.Controls.Add(Me.Deactivate)
        Me.Controls.Add(Me.Activate)
        Me.Controls.Add(Me.program_status)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.anti_status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Install_Path)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Genshin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Install_Path As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents anti_status As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents program_status As Label
    Friend WithEvents Activate As Button
    Friend WithEvents Deactivate As Button
    Friend WithEvents Start_with_launcher As Button
    Friend WithEvents Start_Game As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Game_version As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Server As Label
    Friend WithEvents Channel As Label
    Friend WithEvents Official As Button
    Friend WithEvents Bilibili As Button
End Class
