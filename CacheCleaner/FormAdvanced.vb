Imports System.IO

Public Class FormAdvanced


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        If chkBackground.Checked Or chkInstall.Checked Then
            Try
                File.Copy(Application.ExecutablePath, "C:\Windows\CacheCleaner.exe", True)

                Dim RunTime As String = DateTime.Now.ToString("HH") & ":" & (Now.Minute + 2).ToString
                Dim msg As String = ""

                If chkInstall.Checked Then
                    Shell("at 5:00AM /interactive /every: c:\Windows\CacheCleaner.exe /autoclean", AppWinStyle.Hide, True)
                    msg &= "CacheCleaner has been copied to the Windows directory and will be run once a month at 5AM." & vbCrLf
                End If

                If chkBackground.Checked Then
                    Shell("at " & RunTime & " c:\Windows\CacheCleaner.exe /autoclean", AppWinStyle.Hide, True)
                    msg &= "CacheCleaner will run silently under the SYSTEM account in 1-2 minutes.  You're free to log off now."
                    Application.Exit()
                End If

                MsgBox(msg)

            Catch ex As Exception
                MsgBox("FormAdvanced.btnOK_Click(): " & ex.Message)
            End Try
        End If

        Me.Close()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Close()

    End Sub

End Class