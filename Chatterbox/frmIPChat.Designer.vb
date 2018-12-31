<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIPChat
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIPChat))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ChatterboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OnlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AwayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DoNotDisturbToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InvisibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OfflineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckForUpdatesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ClearChatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveConversationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadConversationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.LogOffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ProgramFontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramFontColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramButtonsColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopicsofflineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpTopicsonlineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutChatterboxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BabaORileyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtip = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtsend1 = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFD = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFD = New System.Windows.Forms.SaveFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LockProgramToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog2 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog3 = New System.Windows.Forms.ColorDialog()
        Me.ProgramBackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChatterboxToolStripMenuItem, Me.FormatToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.HelpToolStripMenuItem, Me.EasterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(503, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ChatterboxToolStripMenuItem
        '
        Me.ChatterboxToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusToolStripMenuItem, Me.LockProgramToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckForUpdatesToolStripMenuItem, Me.ToolStripSeparator2, Me.ClearChatToolStripMenuItem, Me.SaveConversationToolStripMenuItem, Me.LoadConversationToolStripMenuItem, Me.ToolStripSeparator4, Me.LogOffToolStripMenuItem, Me.ToolStripSeparator3, Me.ExitToolStripMenuItem})
        Me.ChatterboxToolStripMenuItem.Name = "ChatterboxToolStripMenuItem"
        Me.ChatterboxToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.ChatterboxToolStripMenuItem.Text = "Chatterbox"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OnlineToolStripMenuItem, Me.AwayToolStripMenuItem, Me.DoNotDisturbToolStripMenuItem, Me.InvisibleToolStripMenuItem, Me.OfflineToolStripMenuItem})
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.StatusToolStripMenuItem.Text = "Status"
        '
        'OnlineToolStripMenuItem
        '
        Me.OnlineToolStripMenuItem.Checked = True
        Me.OnlineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OnlineToolStripMenuItem.Name = "OnlineToolStripMenuItem"
        Me.OnlineToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.OnlineToolStripMenuItem.Text = "Online"
        '
        'AwayToolStripMenuItem
        '
        Me.AwayToolStripMenuItem.Name = "AwayToolStripMenuItem"
        Me.AwayToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.AwayToolStripMenuItem.Text = "Away"
        '
        'DoNotDisturbToolStripMenuItem
        '
        Me.DoNotDisturbToolStripMenuItem.Name = "DoNotDisturbToolStripMenuItem"
        Me.DoNotDisturbToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DoNotDisturbToolStripMenuItem.Text = "Do Not Disturb"
        '
        'InvisibleToolStripMenuItem
        '
        Me.InvisibleToolStripMenuItem.Name = "InvisibleToolStripMenuItem"
        Me.InvisibleToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.InvisibleToolStripMenuItem.Text = "Invisible"
        '
        'OfflineToolStripMenuItem
        '
        Me.OfflineToolStripMenuItem.Name = "OfflineToolStripMenuItem"
        Me.OfflineToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.OfflineToolStripMenuItem.Text = "Offline"
        '
        'LockProgramToolStripMenuItem
        '
        Me.LockProgramToolStripMenuItem.Name = "LockProgramToolStripMenuItem"
        Me.LockProgramToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LockProgramToolStripMenuItem.Text = "Lock Program..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(170, 6)
        '
        'CheckForUpdatesToolStripMenuItem
        '
        Me.CheckForUpdatesToolStripMenuItem.Name = "CheckForUpdatesToolStripMenuItem"
        Me.CheckForUpdatesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.CheckForUpdatesToolStripMenuItem.Text = "Check For Updates"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(170, 6)
        '
        'ClearChatToolStripMenuItem
        '
        Me.ClearChatToolStripMenuItem.Name = "ClearChatToolStripMenuItem"
        Me.ClearChatToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ClearChatToolStripMenuItem.Text = "Clear Chat"
        '
        'SaveConversationToolStripMenuItem
        '
        Me.SaveConversationToolStripMenuItem.Name = "SaveConversationToolStripMenuItem"
        Me.SaveConversationToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SaveConversationToolStripMenuItem.Text = "Save Conversation"
        Me.SaveConversationToolStripMenuItem.Visible = False
        '
        'LoadConversationToolStripMenuItem
        '
        Me.LoadConversationToolStripMenuItem.Name = "LoadConversationToolStripMenuItem"
        Me.LoadConversationToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LoadConversationToolStripMenuItem.Text = "Load Conversation"
        Me.LoadConversationToolStripMenuItem.Visible = False
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(170, 6)
        '
        'LogOffToolStripMenuItem
        '
        Me.LogOffToolStripMenuItem.Name = "LogOffToolStripMenuItem"
        Me.LogOffToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.LogOffToolStripMenuItem.Text = "Log Off"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(170, 6)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'FormatToolStripMenuItem
        '
        Me.FormatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.FontColorToolStripMenuItem, Me.ToolStripSeparator6, Me.ProgramFontToolStripMenuItem, Me.ProgramFontColorToolStripMenuItem, Me.ProgramButtonsColorToolStripMenuItem, Me.ProgramBackgroundColorToolStripMenuItem})
        Me.FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        Me.FormatToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.FormatToolStripMenuItem.Text = "Format"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.FontToolStripMenuItem.Text = "Chat Font"
        '
        'FontColorToolStripMenuItem
        '
        Me.FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        Me.FontColorToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.FontColorToolStripMenuItem.Text = "Chat Font Color"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(216, 6)
        '
        'ProgramFontToolStripMenuItem
        '
        Me.ProgramFontToolStripMenuItem.Name = "ProgramFontToolStripMenuItem"
        Me.ProgramFontToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ProgramFontToolStripMenuItem.Text = "Program Font"
        '
        'ProgramFontColorToolStripMenuItem
        '
        Me.ProgramFontColorToolStripMenuItem.Name = "ProgramFontColorToolStripMenuItem"
        Me.ProgramFontColorToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ProgramFontColorToolStripMenuItem.Text = "Program Font Color"
        '
        'ProgramButtonsColorToolStripMenuItem
        '
        Me.ProgramButtonsColorToolStripMenuItem.Name = "ProgramButtonsColorToolStripMenuItem"
        Me.ProgramButtonsColorToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ProgramButtonsColorToolStripMenuItem.Text = "Program Buttons Color"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpTopicsofflineToolStripMenuItem, Me.HelpTopicsonlineToolStripMenuItem, Me.ChangelogToolStripMenuItem, Me.ToolStripSeparator5, Me.AboutChatterboxToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'HelpTopicsofflineToolStripMenuItem
        '
        Me.HelpTopicsofflineToolStripMenuItem.Name = "HelpTopicsofflineToolStripMenuItem"
        Me.HelpTopicsofflineToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HelpTopicsofflineToolStripMenuItem.Text = "Help Topics (offline)"
        '
        'HelpTopicsonlineToolStripMenuItem
        '
        Me.HelpTopicsonlineToolStripMenuItem.Name = "HelpTopicsonlineToolStripMenuItem"
        Me.HelpTopicsonlineToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HelpTopicsonlineToolStripMenuItem.Text = "Help Topics (online)"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(178, 6)
        '
        'AboutChatterboxToolStripMenuItem
        '
        Me.AboutChatterboxToolStripMenuItem.Name = "AboutChatterboxToolStripMenuItem"
        Me.AboutChatterboxToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.AboutChatterboxToolStripMenuItem.Text = "About Chatterbox"
        '
        'EasterToolStripMenuItem
        '
        Me.EasterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BabaORileyToolStripMenuItem})
        Me.EasterToolStripMenuItem.Name = "EasterToolStripMenuItem"
        Me.EasterToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.EasterToolStripMenuItem.Text = "Easter!"
        Me.EasterToolStripMenuItem.Visible = False
        '
        'BabaORileyToolStripMenuItem
        '
        Me.BabaORileyToolStripMenuItem.Name = "BabaORileyToolStripMenuItem"
        Me.BabaORileyToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.F9), System.Windows.Forms.Keys)
        Me.BabaORileyToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.BabaORileyToolStripMenuItem.Text = "Baba O'Riley"
        Me.BabaORileyToolStripMenuItem.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nickname*:"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(100, 34)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(386, 20)
        Me.txtusername.TabIndex = 2
        '
        'txtip
        '
        Me.txtip.Location = New System.Drawing.Point(100, 65)
        Me.txtip.Name = "txtip"
        Me.txtip.Size = New System.Drawing.Size(271, 20)
        Me.txtip.TabIndex = 3
        Me.txtip.Text = "127.0.0.1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "IP Address*:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(377, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 20)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Black
        Me.RichTextBox1.Location = New System.Drawing.Point(15, 130)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(471, 156)
        Me.RichTextBox1.TabIndex = 31
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Received Messages:"
        '
        'txtsend1
        '
        Me.txtsend1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtsend1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtsend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsend1.ForeColor = System.Drawing.Color.Black
        Me.txtsend1.Location = New System.Drawing.Point(15, 297)
        Me.txtsend1.Name = "txtsend1"
        Me.txtsend1.Size = New System.Drawing.Size(393, 65)
        Me.txtsend1.TabIndex = 33
        Me.txtsend1.Text = ""
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(414, 297)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(72, 65)
        Me.Button2.TabIndex = 34
        Me.Button2.Text = "Send"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'OpenFD
        '
        Me.OpenFD.FileName = "OpenFileDialog1"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(377, 64)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 20)
        Me.Button3.TabIndex = 35
        Me.Button3.Text = "Disconnect"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 373)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(503, 22)
        Me.StatusStrip1.TabIndex = 36
        Me.StatusStrip1.Text = "Chatterbox v2.00"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(137, 17)
        Me.ToolStripStatusLabel1.Text = "Last message received at"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(38, 17)
        Me.ToolStripStatusLabel2.Text = "Never"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Chatterbox (v2.02.100) Running"
        Me.NotifyIcon1.Visible = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.LockProgramToolStripMenuItem1, Me.ToolStripSeparator7, Me.ExitToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(149, 76)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'LockProgramToolStripMenuItem1
        '
        Me.LockProgramToolStripMenuItem1.Name = "LockProgramToolStripMenuItem1"
        Me.LockProgramToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.LockProgramToolStripMenuItem1.Text = "Lock Program"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(145, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(148, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'FontDialog2
        '
        '
        'ProgramBackgroundColorToolStripMenuItem
        '
        Me.ProgramBackgroundColorToolStripMenuItem.Name = "ProgramBackgroundColorToolStripMenuItem"
        Me.ProgramBackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(219, 22)
        Me.ProgramBackgroundColorToolStripMenuItem.Text = "Program Background Color"
        Me.ProgramBackgroundColorToolStripMenuItem.Visible = False
        '
        'frmIPChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 395)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtsend1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtip)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmIPChat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Chatterbox (v2.0.2) "
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ChatterboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LockProgramToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CheckForUpdatesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ClearChatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents LogOffToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopicsofflineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpTopicsonlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AboutChatterboxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtip As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtsend1 As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents OpenFD As OpenFileDialog
    Friend WithEvents SaveFD As SaveFileDialog
    Friend WithEvents OnlineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AwayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DoNotDisturbToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InvisibleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OfflineToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button3 As Button
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ProgramFontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramFontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramButtonsColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog2 As FontDialog
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents ColorDialog3 As ColorDialog
    Friend WithEvents LockProgramToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents SaveConversationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadConversationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BabaORileyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgramBackgroundColorToolStripMenuItem As ToolStripMenuItem
End Class
