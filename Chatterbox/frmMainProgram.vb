Public Class Form1 'Lets get her started.
    Public Shared username As TextBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.Focus()
        txtname.Focus()
        username = txtname 'Let's make sure that gets set, ay?
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtname.Text = "" Then 'if the user wants to be a jokester and, ya know, not type a name
            MsgBox("Error: No name detected. Please input a name.")
            txtname.Focus()

        Else
            frmIPChat.txtusername.text = username.Text

            'lets go ahead and close that trash
            Me.Hide()
            frmIPChat.Show()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        frmAbout.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close() ' WHYYYYYYYYYY
    End Sub

    Private Sub txtname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtname.KeyPress

    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub

    Private Sub txtname_KeyDown(sender As Object, e As KeyEventArgs) Handles txtname.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
        End If
    End Sub
End Class
