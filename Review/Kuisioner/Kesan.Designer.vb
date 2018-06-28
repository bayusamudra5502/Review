'*****************************************************************************
' Nama File : Kesan.vb
' Deskripsi : Kode Form Kesan
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 16 Juni 2018
' Tanggal Edit : 19 Juni 2018
' Copyright PATCH (c) 2018
' ****************************************************************************

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kesan
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kesan))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.RadioButton1 = New System.Windows.Forms.RadioButton()
		Me.RadioButton2 = New System.Windows.Forms.RadioButton()
		Me.RadioButton3 = New System.Windows.Forms.RadioButton()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.Location = New System.Drawing.Point(135, 77)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(470, 57)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Tulis kesan-kesan anda pada kolom ini. Kesan dapat berupa kritik, saran, atau pen" &
	"galaman anda setelah mengunjungi pameran ini."
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(139, 136)
		Me.TextBox1.MaxLength = 600
		Me.TextBox1.Multiline = True
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.TextBox1.Size = New System.Drawing.Size(464, 170)
		Me.TextBox1.TabIndex = 2
		Me.TextBox1.Text = "Tulis disini..."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(401, 310)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(202, 23)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "Sisa karakter : 600 Karakter"
		'
		'Button2
		'
		Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button2.FlatAppearance.BorderSize = 0
		Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button2.Location = New System.Drawing.Point(405, 426)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(87, 32)
		Me.Button2.TabIndex = 14
		Me.Button2.Text = "Kembali"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(135, 358)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(457, 23)
		Me.Label3.TabIndex = 15
		Me.Label3.Text = "Apakah Anda Mau Menjadi Bagian Keluarga Kami (Ikut PATCH)?"
		'
		'RadioButton1
		'
		Me.RadioButton1.AutoSize = True
		Me.RadioButton1.Checked = True
		Me.RadioButton1.Location = New System.Drawing.Point(139, 384)
		Me.RadioButton1.Name = "RadioButton1"
		Me.RadioButton1.Size = New System.Drawing.Size(45, 27)
		Me.RadioButton1.TabIndex = 17
		Me.RadioButton1.TabStop = True
		Me.RadioButton1.Text = "Ya"
		Me.RadioButton1.UseVisualStyleBackColor = True
		'
		'RadioButton2
		'
		Me.RadioButton2.AutoSize = True
		Me.RadioButton2.Location = New System.Drawing.Point(196, 384)
		Me.RadioButton2.Name = "RadioButton2"
		Me.RadioButton2.Size = New System.Drawing.Size(109, 27)
		Me.RadioButton2.TabIndex = 18
		Me.RadioButton2.Text = "Masih Ragu"
		Me.RadioButton2.UseVisualStyleBackColor = True
		'
		'RadioButton3
		'
		Me.RadioButton3.AutoSize = True
		Me.RadioButton3.Location = New System.Drawing.Point(317, 384)
		Me.RadioButton3.Name = "RadioButton3"
		Me.RadioButton3.Size = New System.Drawing.Size(66, 27)
		Me.RadioButton3.TabIndex = 19
		Me.RadioButton3.TabStop = True
		Me.RadioButton3.Text = "Tidak"
		Me.RadioButton3.UseVisualStyleBackColor = True
		'
		'Button1
		'
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Image = Global.Review.My.Resources.Resources.Sent_36px
		Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button1.Location = New System.Drawing.Point(500, 426)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(105, 32)
		Me.Button1.TabIndex = 13
		Me.Button1.Text = "Kirim"
		Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.SMS_72px
		Me.PictureBox1.Location = New System.Drawing.Point(33, 90)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(76, 78)
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.Review.My.Resources.Resources.ezgif_4_bbe2b252d5
		Me.PictureBox2.Location = New System.Drawing.Point(529, 418)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(48, 50)
		Me.PictureBox2.TabIndex = 20
		Me.PictureBox2.TabStop = False
		Me.PictureBox2.Visible = False
		'
		'Kesan
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(636, 486)
		Me.ControlBox = False
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.RadioButton3)
		Me.Controls.Add(Me.RadioButton2)
		Me.Controls.Add(Me.RadioButton1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "Kesan"
		Me.Padding = New System.Windows.Forms.Padding(30, 106, 30, 35)
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Teal
		Me.Text = "Bagaimana Kesan Anda (Bergabung PATCH) ?"
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Button2 As Button
	Friend WithEvents Button1 As Button
	Friend WithEvents Label3 As Label
	Friend WithEvents RadioButton1 As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents RadioButton3 As RadioButton
	Friend WithEvents PictureBox2 As PictureBox
End Class
