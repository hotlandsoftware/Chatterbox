Public Class frmLock
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Password = TextBox1.Text
        My.Settings.Save()
        MsgBox("The program has been locked. Don't forget your password!")
        Me.Hide()
        frmAbout.Close()
        frmIPChat.Hide()
        frmUpdate.Close()
        HelpTopics.Close()
        frmSettings.Close()
        frmLocked.Show()
        frmIPChat.NotifyIcon1.Visible = False
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class