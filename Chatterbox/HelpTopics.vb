Public Class HelpTopics
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TextBox1.Visible = False
        LinkLabel1.Visible = False
        TextBox2.Visible = True
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        TextBox1.Visible = False
        LinkLabel1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = True
        TextBox5.Visible = False
        TextBox6.Visible = False
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        TextBox1.Visible = False
        LinkLabel1.Visible = True
        TextBox2.Visible = False
        TextBox3.Visible = True
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("cmd.exe")
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs)
        TextBox1.Visible = False
        LinkLabel1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = False
    End Sub

    Private Sub HelpTopics_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        TextBox1.Visible = False
        LinkLabel1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = True
        TextBox6.Visible = False
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TextBox1.Visible = False
        LinkLabel1.Visible = False
        TextBox2.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox5.Visible = False
        TextBox6.Visible = True
    End Sub
End Class