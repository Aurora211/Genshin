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
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Installation path:"
        '
        'Install_Path
        '
        Me.Install_Path.AutoSize = True
        Me.Install_Path.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Install_Path.ForeColor = System.Drawing.Color.Orange
        Me.Install_Path.Location = New System.Drawing.Point(192, 9)
        Me.Install_Path.Name = "Install_Path"
        Me.Install_Path.Size = New System.Drawing.Size(206, 26)
        Me.Install_Path.TabIndex = 1
        Me.Install_Path.Text = "Reading Registry......"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 35)
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
        Me.anti_status.Location = New System.Drawing.Point(235, 35)
        Me.anti_status.Name = "anti_status"
        Me.anti_status.Size = New System.Drawing.Size(82, 26)
        Me.anti_status.TabIndex = 3
        Me.anti_status.Text = "Loaded"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 61)
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
        Me.program_status.Location = New System.Drawing.Point(183, 61)
        Me.program_status.Name = "program_status"
        Me.program_status.Size = New System.Drawing.Size(104, 26)
        Me.program_status.TabIndex = 5
        Me.program_status.Text = "Activated"
        '
        'Activate
        '
        Me.Activate.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Activate.Location = New System.Drawing.Point(12, 90)
        Me.Activate.Name = "Activate"
        Me.Activate.Size = New System.Drawing.Size(275, 43)
        Me.Activate.TabIndex = 6
        Me.Activate.Text = "Activate Anti-program"
        Me.Activate.UseVisualStyleBackColor = True
        '
        'Deactivate
        '
        Me.Deactivate.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Deactivate.Location = New System.Drawing.Point(297, 90)
        Me.Deactivate.Name = "Deactivate"
        Me.Deactivate.Size = New System.Drawing.Size(275, 43)
        Me.Deactivate.TabIndex = 7
        Me.Deactivate.Text = "Deactivate Anti-program"
        Me.Deactivate.UseVisualStyleBackColor = True
        '
        'Start_with_launcher
        '
        Me.Start_with_launcher.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Start_with_launcher.Location = New System.Drawing.Point(12, 139)
        Me.Start_with_launcher.Name = "Start_with_launcher"
        Me.Start_with_launcher.Size = New System.Drawing.Size(560, 43)
        Me.Start_with_launcher.TabIndex = 8
        Me.Start_with_launcher.Text = "Start The Game Using Default Launcher"
        Me.Start_with_launcher.UseVisualStyleBackColor = True
        '
        'Start_Game
        '
        Me.Start_Game.Font = New System.Drawing.Font("微软雅黑", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Start_Game.Location = New System.Drawing.Point(12, 188)
        Me.Start_Game.Name = "Start_Game"
        Me.Start_Game.Size = New System.Drawing.Size(560, 43)
        Me.Start_Game.TabIndex = 9
        Me.Start_Game.Text = "Start The Game Directly (Recommend)"
        Me.Start_Game.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 243)
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
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "Genshin Anti Harmony Activator"
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
End Class
