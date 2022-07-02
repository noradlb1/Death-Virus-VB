Namespace Death_Virus
	Partial Public Class Form2
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form2))
			Me.label1 = New System.Windows.Forms.Label()
			Me.textBox1 = New System.Windows.Forms.TextBox()
			Me.checkBox1 = New System.Windows.Forms.CheckBox()
			Me.button1 = New System.Windows.Forms.Button()
			Me.button2 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label1.Location = New System.Drawing.Point(162, 30)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(162, 32)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Death Virus"
			' 
			' textBox1
			' 
			Me.textBox1.BackColor = System.Drawing.Color.RoyalBlue
			Me.textBox1.Cursor = System.Windows.Forms.Cursors.Default
			Me.textBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.textBox1.HideSelection = False
			Me.textBox1.Location = New System.Drawing.Point(12, 91)
			Me.textBox1.Multiline = True
			Me.textBox1.Name = "textBox1"
			Me.textBox1.ReadOnly = True
			Me.textBox1.ShortcutsEnabled = False
			Me.textBox1.Size = New System.Drawing.Size(457, 274)
			Me.textBox1.TabIndex = 1
			Me.textBox1.Text = resources.GetString("textBox1.Text")
			' 
			' checkBox1
			' 
			Me.checkBox1.AutoSize = True
			Me.checkBox1.Location = New System.Drawing.Point(150, 381)
			Me.checkBox1.Name = "checkBox1"
			Me.checkBox1.Size = New System.Drawing.Size(191, 20)
			Me.checkBox1.TabIndex = 2
			Me.checkBox1.Text = "I agree and I'm responsible"
			Me.checkBox1.UseVisualStyleBackColor = True
'			Me.checkBox1.CheckedChanged += New System.EventHandler(Me.checkBox1_CheckedChanged)
			' 
			' button1
			' 
			Me.button1.BackColor = System.Drawing.Color.RoyalBlue
			Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button1.Location = New System.Drawing.Point(12, 407)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(221, 76)
			Me.button1.TabIndex = 3
			Me.button1.Text = "CANCEL"
			Me.button1.UseVisualStyleBackColor = False
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' button2
			' 
			Me.button2.BackColor = System.Drawing.Color.RoyalBlue
			Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.button2.Location = New System.Drawing.Point(239, 407)
			Me.button2.Name = "button2"
			Me.button2.Size = New System.Drawing.Size(233, 76)
			Me.button2.TabIndex = 4
			Me.button2.Text = "RUN"
			Me.button2.UseVisualStyleBackColor = False
'			Me.button2.Click += New System.EventHandler(Me.button2_Click)
			' 
			' Form2
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.BackColor = System.Drawing.Color.RoyalBlue
			Me.ClientSize = New System.Drawing.Size(481, 501)
			Me.ControlBox = False
			Me.Controls.Add(Me.button2)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.checkBox1)
			Me.Controls.Add(Me.textBox1)
			Me.Controls.Add(Me.label1)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
			Me.MaximizeBox = False
			Me.MinimizeBox = False
			Me.Name = "Form2"
			Me.ShowIcon = False
			Me.ShowInTaskbar = False
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "WARNING"
'			Me.Load += New System.EventHandler(Me.Form2_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As System.Windows.Forms.Label
		Private textBox1 As System.Windows.Forms.TextBox
		Private WithEvents checkBox1 As System.Windows.Forms.CheckBox
		Private WithEvents button1 As System.Windows.Forms.Button
		Private WithEvents button2 As System.Windows.Forms.Button
	End Class
End Namespace