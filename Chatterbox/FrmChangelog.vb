Public Class FrmChangelog
    Private Sub ChangeFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeFontToolStripMenuItem.Click
        Dim fontDialod As New FontDialog
        fontDialod.Font = RichTextBox1.Font
        fontDialod.ShowDialog()
        RichTextBox1.Font = fontDialod.Font
        RichTextBox1.BackColor = Color.White
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FrmChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class