Imports Microsoft.Win32
Imports System.ComponentModel
Imports System.IO
Imports System.IO.File

Public Class Form1
    Private Sub GetInstallPath()
        Dim genshin As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE")
        Dim number As Integer = genshin.SubKeyCount - 1
        For index = 0 To number
            If genshin.GetSubKeyNames(index) = "launcher" Then
                genshin = genshin.OpenSubKey("launcher")
                Install_Path.Text = genshin.GetValue("InstPath")
                Install_Path.ForeColor = Color.LimeGreen
                Game_version.Text = genshin.GetValue("Version")
                Game_version.ForeColor = Color.Orange
                If version_check(Game_version.Text) Then
                    Game_version.Text += " Supported"
                    Game_version.ForeColor = Color.LimeGreen
                Else
                    Game_version.Text += " Untested"
                    Game_version.ForeColor = Color.Orange
                    MsgBox("This latest version of game has not been tested. But you can have a try.")
                End If
                flash_server_info()
                If Exists(Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\29342328.blk") = False Then
                    anti_status.Text = "Activated"
                    anti_status.ForeColor = Color.LimeGreen
                    MsgBox("Target file may have already been deleted." & Chr(10) & "Anti Harmony can NOT turn off!!!")
                    Deactivate.Enabled = False
                    Activate.Enabled = False
                End If
                Directory.CreateDirectory(Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\TEMP")
                Exit Sub
            End If
        Next
        Install_Path.Text = "Game Uninstall"
        Install_Path.ForeColor = Color.Red
        program_status.Text = "Error"
        program_status.ForeColor = Color.Red
        anti_status.Text = "Fail"
        anti_status.ForeColor = Color.Red
        Activate.Enabled = False
        Deactivate.Enabled = False
        Start_Game.Enabled = False
        Start_with_launcher.Enabled = False
    End Sub

    Private Function version_check(version As String) As Boolean
        Dim s As String() = "2.3.4.0".Split(".")
        Dim v As String() = version.Split(".")
        If Integer.Parse(s(0)) > Integer.Parse(v(0)) Then
        ElseIf Integer.Parse(s(0)) = Integer.Parse(v(0)) Then
            If Integer.Parse(s(1)) > Integer.Parse(v(1)) Then
            ElseIf Integer.Parse(s(1)) = Integer.Parse(v(1)) Then
                If Integer.Parse(s(2)) > Integer.Parse(v(2)) Then
                ElseIf Integer.Parse(s(2)) = Integer.Parse(v(2)) Then
                    If Integer.Parse(s(3)) > Integer.Parse(v(3)) Then
                    ElseIf Integer.Parse(s(3)) = Integer.Parse(v(3)) Then
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Else
            Return False
        End If
        Return True
    End Function

    Private Sub flash_server_info()
        If Exists(Install_Path.Text & "\Genshin Impact Game\config.ini") = False Then
            Server.Text = "ERROR"
            Channel.Text = "ERROR"
            Server.ForeColor = Color.Red
            Channel.ForeColor = Color.Red
            Bilibili.Enabled = False
            Official.Enabled = False
            Exit Sub
        End If
        Dim info As String() = ReadAllLines(Install_Path.Text & "\Genshin Impact Game\config.ini")
        For index = 0 To (info.Length - 1)
            If info(index).Contains("cps=") Then
                If info(index).Contains("bilibili") Then
                    Server.Text = "Bilibili Server"
                ElseIf info(2).Replace("cps=", "") = "pcad360pz" Or info(index).Contains("mihayo") Then
                    Server.Text = "Offical Server"
                Else
                    Server.Text = "Unsupported Server"
                End If
            End If
            If info(index).Contains("channel=") And info(index).Contains("sub_channel=") = False Then
                Channel.Text = info(index).Replace("channel=", "")
            End If
        Next
        Server.ForeColor = Color.Black
        Channel.ForeColor = Color.Black
        GC.Collect()
    End Sub

    Private Sub start(path As String)
        Dim info As System.Diagnostics.ProcessStartInfo
        info = New System.Diagnostics.ProcessStartInfo()
        info.FileName = path
        info.WorkingDirectory = Install_Path.Text & "\Genshin Impact Game"

        Dim Proc As System.Diagnostics.Process

        Try
            Proc = System.Diagnostics.Process.Start(info)
        Catch ex As System.ComponentModel.Win32Exception
            Return
        End Try

        If Proc.HasExited = False Then
            'Proc.Kill()
        End If
    End Sub

    Private Sub checkanti()
        If Exists(Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\29342328.blk") Then
            anti_status.Text = "Unloaded"
            anti_status.ForeColor = Color.Orange
        Else
            anti_status.Text = "Activated"
            anti_status.ForeColor = Color.LimeGreen
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetInstallPath()
    End Sub

    Private Sub Start_Game_Click(sender As Object, e As EventArgs) Handles Start_Game.Click
        Dim path As String = Install_Path.Text & "\Genshin Impact Game\YuanShen.exe"
        If Exists(path) = True Then
            start(path)
            Exit Sub
        End If
        MsgBox("Error" & Chr(10) & "Game Start EXE File not found!")
    End Sub

    Private Sub Start_with_launcher_Click(sender As Object, e As EventArgs) Handles Start_with_launcher.Click
        Dim path As String = Install_Path.Text & "\launcher.exe"
        If Exists(path) = True Then
            start(path)
            Exit Sub
        End If
        MsgBox("Error" & Chr(10) & "Game Launcher not found!")
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If Exists(Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\TEMP\29342328.blk") Then
            File.Move(Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\TEMP\29342328.blk", Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\29342328.blk")
        End If
        Directory.Delete(Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\TEMP")
    End Sub

    Private Sub Activate_Click(sender As Object, e As EventArgs) Handles Activate.Click
        If anti_status.Text = "Activated" Then
            Exit Sub
        End If
        File.Move(Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\29342328.blk", Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\TEMP\29342328.blk")
        anti_status.Text = "Activated"
        anti_status.ForeColor = Color.LimeGreen
    End Sub

    Private Sub Deactivate_Click(sender As Object, e As EventArgs) Handles Deactivate.Click
        If anti_status.Text = "Loaded" Then
            Exit Sub
        End If
        File.Move(Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\TEMP\29342328.blk", Install_Path.Text & "\Genshin Impact Game\YuanShen_Data\Persistent\AssetBundles\blocks\00\29342328.blk")
        anti_status.Text = "Loaded"
        anti_status.ForeColor = Color.Orange
    End Sub

    Private Sub Bilibili_Click(sender As Object, e As EventArgs) Handles Bilibili.Click
        Dim info As String() = ReadAllLines(Install_Path.Text & "\Genshin Impact Game\config.ini")
        For index = 0 To (info.Length - 1)
            If info(index).Contains("channel=") And info(index).Contains("sub_channel=") = False Then
                info(index) = "channel=14"
            End If
            If info(index).Contains("cps=") Then
                info(index) = "cps=bilibili"
            End If
            If info(index).Contains("sub_channel=") Then
                info(index) = "sub_channel=0"
            End If
        Next
        Dim fin As String = info(0)
        For index = 2 To info.Length
            fin += Chr(10)
            fin += info(index - 1)
        Next
        WriteAllText(Install_Path.Text & "\Genshin Impact Game\config.ini", fin)
        flash_server_info()
    End Sub

    Private Sub Official_Click(sender As Object, e As EventArgs) Handles Official.Click
        Dim info As String() = ReadAllLines(Install_Path.Text & "\Genshin Impact Game\config.ini")
        For index = 0 To (info.Length - 1)
            If info(index).Contains("channel=") And info(index).Contains("sub_channel=") = False Then
                info(index) = "channel=1"
            End If
            If info(index).Contains("cps=") Then
                info(index) = "cps=mihayo"
            End If
            If info(index).Contains("sub_channel=") Then
                info(index) = "sub_channel=1"
            End If
        Next
        Dim fin As String = info(0)
        For index = 2 To info.Length
            fin += Chr(10)
            fin += info(index - 1)
        Next
        WriteAllText(Install_Path.Text & "\Genshin Impact Game\config.ini", fin)
        flash_server_info()
    End Sub
End Class
