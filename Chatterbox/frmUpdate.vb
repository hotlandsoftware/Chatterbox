Imports System.IO
Imports System.Net

Public Class frmUpdate
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim address As String = "http://thecptrackers.com/version.txt"
        Dim client As WebClient = New WebClient()
        Dim reader As StreamReader = New StreamReader(client.OpenRead(address))
        Label4.Text = reader.ReadToEnd
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim webAddress As String = "http://thecptrackers.com/chatterbox/chatterbox.exe"

        Process.Start(webAddress)
    End Sub
End Class