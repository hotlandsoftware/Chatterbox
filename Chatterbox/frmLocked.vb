Public Class frmLocked
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = My.Settings.Password Then
            frmIPChat.Show()
            frmIPChat.NotifyIcon1.Visible = True
            Me.Close()
        Else
            MsgBox("Sorry, that code was incorrect. Please try again.")
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class