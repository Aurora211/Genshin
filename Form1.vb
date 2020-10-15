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
End Class
