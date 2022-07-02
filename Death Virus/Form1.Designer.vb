Namespace Death_Virus
	Partial Public Class Death_Virus
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Death_Virus))
			Me.Player1 = New AxWMPLib.AxWindowsMediaPlayer()
			DirectCast(Me.Player1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' Player1
			' 
			Me.Player1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.Player1.Enabled = True
			Me.Player1.Location = New System.Drawing.Point(0, 0)
			Me.Player1.Name = "Player1"
			Me.Player1.OcxState = (DirectCast(resources.GetObject("Player1.OcxState"), System.Windows.Forms.AxHost.State))
			Me.Player1.Size = New System.Drawing.Size(800, 450)
			Me.Player1.TabIndex = 0
			Me.Player1.TabStop = False
			' 
			' Death_Virus
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.Black
			Me.ClientSize = New System.Drawing.Size(800, 450)
			Me.ControlBox = False
			Me.Controls.Add(Me.Player1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Death_Virus"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Death"
			Me.TopMost = True
			Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
'			Me.FormClosing += New System.Windows.Forms.FormClosingEventHandler(Me.Death_Virus_FormClosing)
'			Me.Load += New System.EventHandler(Me.Death_Virus_Load)
			DirectCast(Me.Player1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private Player1 As AxWMPLib.AxWindowsMediaPlayer
	End Class
End Namespace

