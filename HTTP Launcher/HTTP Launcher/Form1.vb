Imports System.ComponentModel

Public Class frmHTTPLaunch
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Try
            Shell("C:\Apache24\bin\httpd.exe -k start")
            lblStatus.Text = "Running"
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Try
            Shell("C:\Apache24\bin\httpd.exe -k stop")
            lblStatus.Text = "Stopped"
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
        End Try
    End Sub

    Private Sub frmHTTPLaunch_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If lblStatus.Text <> "Stopped" Then
            Try
                Shell("C:\Apache24\bin\httpd.exe -k stop")
                lblStatus.Text = "Stopped"
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString())
            End Try
        End If
    End Sub
End Class
