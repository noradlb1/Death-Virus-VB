Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Media
Imports System.IO

Namespace Death_Virus
	Partial Public Class Form2
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Application.Exit()
		End Sub

		Private Sub Form2_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			button2.Enabled = False
			checkBox1.Checked = False
			Dim sound As String = "C:\Windows\Media\Windows Exclamation.wav"
			If File.Exists(sound) Then
				Dim soundplayer As New SoundPlayer(sound)
				soundplayer.Play()
			End If
		End Sub

		Private Sub checkBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles checkBox1.CheckedChanged
			If checkBox1.Checked Then
				button2.Enabled = True
			Else
				button2.Enabled = False
			End If
		End Sub

		Private Sub button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button2.Click
			run_virus()
		End Sub
		Public Sub run_virus()
			Me.Hide()
			Dim form As New Death_Virus()
			form.ShowDialog()
			Me.Close()
		End Sub
	End Class
End Namespace
