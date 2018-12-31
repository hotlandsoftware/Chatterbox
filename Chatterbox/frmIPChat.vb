'let's get her started up fellas by defining our vb methods 

Imports System.Net.Sockets 'no longer using that winsock bullshit that faifls to run under 10 because 10 is a pile of monkey shit
Imports System.Threading
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Net.Dns 'you'll see why


Public Class frmIPChat
    'now lets declare our variables

    Dim listener As New TcpListener(5757) '1-2-3-4 i declare a thumb war
    Dim client As TcpClient
    Dim mysocket As Socket 'jim actually tried to use another 30 line method to define sockets.. what a faggot
    Dim message As String = ""
    Dim serveriplist As IPHostEntry = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()) 'see jim? it actually had a purpose. you owe me a sandwich
    Dim nameip As String

    Private Sub frmIPChat_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'alright.. time for an ugly ass hack
        If Button3.Visible = True Then
            txtsend1.Text = "is now offline."
            Button2.PerformClick()
            listener.Stop()
            Form1.Close()
        ElseIf Button3.Visible = False Then
            listener.Stop()
            Form1.Close()
        End If
        'fucking bloody hell fuck these shoddy codes fuck vb.net fuck you jim
    End Sub
    Private Sub frmIPChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub listening()
        listener.Start() 'lets start the listener for christs sake
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            client = New TcpClient(txtip.Text, 5757)
            Dim writer As New StreamWriter(client.GetStream())
            'save the message onto the client's listening socket buffer

            writer.Write(txtusername.Text & ":" & " " & txtsend1.Text)
            writer.Flush()

            RichTextBox1.Text += (txtusername.Text & ":" & " " & txtsend1.Text) + vbCrLf
            txtsend1.Clear()
            txtsend1.Focus()

        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If listener.Pending = True Then ' lets set the listener port to continue listening for connections
            message = "" 'blank it out
            client = listener.AcceptTcpClient() 'accept him for christs sake, who cares if he's LGBT?

            Dim reader As New StreamReader(client.GetStream())
            While reader.Peek > -1
                message = message + Convert.ToChar(reader.Read()).ToString
            End While

            RichTextBox1.Text = RichTextBox1.Text + Environment.NewLine + message + vbCrLf 'lets display the text stored in the listening ports buffer

            RichTextBox1.SelectionStart = Len(RichTextBox1.Text)
            RichTextBox1.ScrollToCaret()

        Else : End If
    End Sub

    Private Sub ConnectionError()

        ' what happens if they mess up?
        ' this

        On Error GoTo 50

50:     MsgBox("Error: The IP address does not appear to be valid. Please double check the IP and try again.")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'error detections and validation

        Try

            If txtip.Text = "" Then
                MsgBox("There is nothing in the IP address box. Please enter an IP.")
                txtip.Focus()
                txtsend1.Enabled = False

            Else

                Dim listthread As New Thread(New ThreadStart(AddressOf listening))
                listthread.Start()

                Timer1.Enabled = True

                client = New TcpClient(txtip.Text, 5757)
                Dim writer As New StreamWriter(client.GetStream())

                writer.Write("[" & TimeOfDay & "] " & txtusername.Text & " has signed on.")
                writer.Flush()
                txtsend1.Enabled = True
                Button1.Visible = False
                Button2.Enabled = True
                Button3.Visible = True

            End If
        Catch exc As Exception
            MsgBox(exc.Message)
        End Try
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        ToolStripStatusLabel2.Text = TimeOfDay
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub HelpTopicsofflineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpTopicsofflineToolStripMenuItem.Click
        HelpTopics.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Enabled = False
        RichTextBox1.Text += ("[" & TimeOfDay & "] " & txtusername.Text & " has signed off.") + vbCrLf
        txtsend1.Enabled = False
        Button1.Visible = True
        Button3.Visible = False
        Button2.Enabled = False
    End Sub

    Private Sub ClearChatToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearChatToolStripMenuItem.Click
        Dim result As Integer = MessageBox.Show("Are you sure you want to clear the entire conversation?", "Chatterbox", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Cancel Then

        ElseIf result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            RichTextBox1.Clear()
        End If
    End Sub

    Private Sub CheckForUpdatesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CheckForUpdatesToolStripMenuItem.Click
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://thecptrackers.com/version.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream)

        Dim newestversion As String = sr.ReadToEnd
        Dim currentversion As String = Application.ProductVersion

        If newestversion.Contains(currentversion) Then
            MsgBox("You are on the latest version of Chatterbox.")
        Else
            frmUpdate.Show()
        End If
    End Sub

    Private Sub LockProgramToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockProgramToolStripMenuItem.Click
        frmLock.Show()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOffToolStripMenuItem.Click
        Form1.Show()
        Button3.PerformClick()
        Me.Hide()
    End Sub

    Private Sub SaveConversationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Try

            SaveFD.InitialDirectory = "C:\"
            SaveFD.Title = "Save Chat to a text file"
            SaveFD.Filter = "Text Files|*.txt|RTF Files|*.rtf|Microsoft Word Document|*.doc|OpenDocument Text|*.odt"

            SaveFD.ShowDialog()
            SaveFD.OverwritePrompt = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frmSettings.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Button3.PerformClick()
        Form1.Close()
        Me.Close()
    End Sub

    Private Sub AboutChatterboxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutChatterboxToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub AwayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AwayToolStripMenuItem.Click
        txtsend1.Text = "I am now away and may not reply."
        Button2.PerformClick()
        OnlineToolStripMenuItem.Checked = False
        AwayToolStripMenuItem.Checked = True
        DoNotDisturbToolStripMenuItem.Checked = False
        InvisibleToolStripMenuItem.Checked = False
        OfflineToolStripMenuItem.Checked = False
    End Sub

    Private Sub OnlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OnlineToolStripMenuItem.Click
        txtsend1.Text = "I am now online and ready to chat."
        Button2.PerformClick()
        OnlineToolStripMenuItem.Checked = True
        AwayToolStripMenuItem.Checked = False
        DoNotDisturbToolStripMenuItem.Checked = False
        InvisibleToolStripMenuItem.Checked = False
        OfflineToolStripMenuItem.Checked = False
    End Sub

    Private Sub DoNotDisturbToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoNotDisturbToolStripMenuItem.Click
        txtsend1.Text = "I am currently busy and cannot reply."
        Button2.PerformClick()
        OnlineToolStripMenuItem.Checked = False
        AwayToolStripMenuItem.Checked = False
        DoNotDisturbToolStripMenuItem.Checked = True
        InvisibleToolStripMenuItem.Checked = False
        OfflineToolStripMenuItem.Checked = False
    End Sub

    Private Sub InvisibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InvisibleToolStripMenuItem.Click
        txtsend1.Text = "is now offline."
        Button2.PerformClick()
        OnlineToolStripMenuItem.Checked = False
        AwayToolStripMenuItem.Checked = False
        DoNotDisturbToolStripMenuItem.Checked = False
        InvisibleToolStripMenuItem.Checked = True
        OfflineToolStripMenuItem.Checked = False
    End Sub

    Private Sub OfflineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OfflineToolStripMenuItem.Click
        txtsend1.Text = "is now offline."
        Button2.PerformClick()
        OnlineToolStripMenuItem.Checked = False
        AwayToolStripMenuItem.Checked = False
        DoNotDisturbToolStripMenuItem.Checked = False
        InvisibleToolStripMenuItem.Checked = False
        OfflineToolStripMenuItem.Checked = True
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.Font = FontDialog1.Font
        txtsend1.Font = FontDialog1.Font
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.ForeColor = ColorDialog1.Color
        txtsend1.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub ProgramFontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramFontToolStripMenuItem.Click
        FontDialog2.ShowDialog()
        Label1.Font = FontDialog2.Font
        Label2.Font = FontDialog2.Font
        Label3.Font = FontDialog2.Font
        Button1.Font = FontDialog2.Font
        Button2.Font = FontDialog2.Font
        Button3.Font = FontDialog2.Font
        ToolStripStatusLabel1.Font = FontDialog2.Font
        ToolStripStatusLabel2.Font = FontDialog2.Font
    End Sub

    Private Sub ProgramFontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramFontColorToolStripMenuItem.Click
        ColorDialog2.ShowDialog()
        Label1.ForeColor = ColorDialog2.Color
        Label2.ForeColor = ColorDialog2.Color
        Label3.ForeColor = ColorDialog2.Color
        Button1.ForeColor = ColorDialog2.Color
        Button2.ForeColor = ColorDialog2.Color
        Button3.ForeColor = ColorDialog2.Color
        ToolStripStatusLabel1.ForeColor = ColorDialog2.Color
        ToolStripStatusLabel2.ForeColor = ColorDialog2.Color
    End Sub

    Private Sub FontDialog2_Apply(sender As Object, e As EventArgs) Handles FontDialog2.Apply

    End Sub

    Private Sub ProgramButtonsColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgramButtonsColorToolStripMenuItem.Click
        ColorDialog3.ShowDialog()
        Button1.BackColor = ColorDialog3.Color
        Button2.BackColor = ColorDialog3.Color
        Button3.BackColor = ColorDialog3.Color
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Me.Show()
    End Sub

    Private Sub LockProgramToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles LockProgramToolStripMenuItem1.Click
        frmLock.Show()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub HelpTopicsonlineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpTopicsonlineToolStripMenuItem.Click
        Dim webAddress As String = "http://hotlandsoftware.x10host.com/chatterbox-help-documents/"
        Process.Start(webAddress)
    End Sub

    Private Sub SaveConversationToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SaveConversationToolStripMenuItem.Click
        Try

            SaveFD.InitialDirectory = "C:\"
            SaveFD.Title = "Save Chat to a text file"
            SaveFD.Filter = "Text Files|*.txt|RTF Files|*.rtf|Microsoft Word Document|*.doc|OpenDocument Text|*.odt"

            SaveFD.ShowDialog()
            SaveFD.OverwritePrompt = True

        Catch ex As Exception

        End Try
    End Sub

    Private Sub LoadConversationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadConversationToolStripMenuItem.Click

    End Sub

    Private Sub ChangelogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        FrmChangelog.Show()
    End Sub

    Private Sub BabaORileyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BabaORileyToolStripMenuItem.Click
        BabaORiley.Show()
    End Sub
End Class