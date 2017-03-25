Imports System.ComponentModel

Public Class frmHTTPLaunch
    Dim status As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            Dim procInfo As New ProcessStartInfo()
            procInfo.UseShellExecute = True
            procInfo.FileName = "httpstart.bat"
            procInfo.WorkingDirectory = ""
            procInfo.Verb = "runas"
            Process.Start(procInfo)
            lblStatus.Text = "Running"
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Try
            Dim procInfo As New ProcessStartInfo()
            procInfo.UseShellExecute = True
            procInfo.FileName = "httpstop.bat"
            procInfo.WorkingDirectory = ""
            procInfo.Verb = "runas"
            Process.Start(procInfo)
            lblStatus.Text = "Stopped"
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub frmHTTPLaunch_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If lblStatus.Text <> "Stopped" Then
            Try
                Dim procInfo As New ProcessStartInfo()
                procInfo.UseShellExecute = True
                procInfo.FileName = "httpstop.bat"
                procInfo.WorkingDirectory = ""
                procInfo.Verb = "runas"
                Process.Start(procInfo)
                lblStatus.Text = "Stopped"
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End If
    End Sub
End Class
