﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Utama
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Utama))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
		Me.Label1 = New System.Windows.Forms.Label()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
		Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.settings
		Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(32, 36)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Timer1
		'
		Me.Timer1.Enabled = True
		Me.Timer1.Interval = 500
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 12.0!)
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Location = New System.Drawing.Point(52, 15)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(121, 24)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Pukul 00.00.00"
		'
		'Utama
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Review.My.Resources.Resources.flat_simple_wallpaper_20
		Me.ClientSize = New System.Drawing.Size(616, 479)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "Utama"
		Me.Text = "Utama"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Timer1 As Timer
	Friend WithEvents Label1 As Label
End Class
