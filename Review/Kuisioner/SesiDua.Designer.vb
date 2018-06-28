'*****************************************************************************
' Nama File : SesiDua.Designer.vb
' Deskripsi : Desain Form Penilaian PATCH
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 14 Juni 2018
' Tanggal Edit : 19 Juni 2018
' Copyright PATCH (c) 2018
' ****************************************************************************

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SesiDua
	Inherits MetroFramework.Forms.MetroForm

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SesiDua))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.MetroTrackBar1 = New MetroFramework.Controls.MetroTrackBar()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(23, 75)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(320, 23)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Nyatakan nilai anda terhadap pameran tadi."
		'
		'MetroTrackBar1
		'
		Me.MetroTrackBar1.BackColor = System.Drawing.Color.Transparent
		Me.MetroTrackBar1.Location = New System.Drawing.Point(177, 135)
		Me.MetroTrackBar1.Maximum = 10
		Me.MetroTrackBar1.Name = "MetroTrackBar1"
		Me.MetroTrackBar1.Size = New System.Drawing.Size(300, 23)
		Me.MetroTrackBar1.TabIndex = 1
		Me.MetroTrackBar1.Text = "MetroTrackBar1"
		Me.MetroTrackBar1.Value = 5
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(118, 132)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(52, 23)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Buruk"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(496, 133)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(54, 23)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Bagus"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(396, 177)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(154, 23)
		Me.Label4.TabIndex = 5
		Me.Label4.Text = "Penilaian Anda : 5/10"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.Boring_72px
		Me.PictureBox1.Location = New System.Drawing.Point(27, 115)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(76, 73)
		Me.PictureBox1.TabIndex = 4
		Me.PictureBox1.TabStop = False
		'
		'Button1
		'
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(464, 222)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(87, 32)
		Me.Button1.TabIndex = 11
		Me.Button1.Text = "Lanjut"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(371, 222)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(87, 32)
		Me.Button2.TabIndex = 12
		Me.Button2.Text = "Kembali"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'SesiDua
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(584, 271)
		Me.ControlBox = False
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.MetroTrackBar1)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Quicksand", 11.25!)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "SesiDua"
		Me.Padding = New System.Windows.Forms.Padding(30, 106, 30, 36)
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Yellow
		Me.Text = "Bagaimana Penilaian Anda?"
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents MetroTrackBar1 As MetroFramework.Controls.MetroTrackBar
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
