<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addLevel
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
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Nama = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LblUser1 = New System.Windows.Forms.Label()
		Me.Button = New System.Windows.Forms.Button()
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.Label3 = New System.Windows.Forms.Label()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox2
		'
		Me.PictureBox2.BackColor = System.Drawing.Color.White
		Me.PictureBox2.Image = Global.Review.My.Resources.Resources.Webp1
		Me.PictureBox2.Location = New System.Drawing.Point(24, 65)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(85, 97)
		Me.PictureBox2.TabIndex = 14
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources._32
		Me.PictureBox1.Location = New System.Drawing.Point(483, 362)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(57, 36)
		Me.PictureBox1.TabIndex = 62
		Me.PictureBox1.TabStop = False
		Me.PictureBox1.Visible = False
		'
		'Nama
		'
		Me.Nama.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Nama.Location = New System.Drawing.Point(225, 89)
		Me.Nama.Name = "Nama"
		Me.Nama.Size = New System.Drawing.Size(333, 26)
		Me.Nama.TabIndex = 58
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(119, 89)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(92, 23)
		Me.Label2.TabIndex = 57
		Me.Label2.Text = "Nama Level"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(118, 60)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(246, 23)
		Me.Label1.TabIndex = 56
		Me.Label1.Text = "Isilah data level yang akan dibuat."
		'
		'LblUser1
		'
		Me.LblUser1.AutoSize = True
		Me.LblUser1.BackColor = System.Drawing.Color.White
		Me.LblUser1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblUser1.Location = New System.Drawing.Point(119, 121)
		Me.LblUser1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblUser1.Name = "LblUser1"
		Me.LblUser1.Size = New System.Drawing.Size(82, 23)
		Me.LblUser1.TabIndex = 52
		Me.LblUser1.Text = "Hak Akses"
		'
		'Button
		'
		Me.Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button.BackColor = System.Drawing.Color.White
		Me.Button.FlatAppearance.BorderSize = 0
		Me.Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold)
		Me.Button.Image = Global.Review.My.Resources.Resources.Sent_36px
		Me.Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button.Location = New System.Drawing.Point(463, 361)
		Me.Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button.Name = "Button"
		Me.Button.Size = New System.Drawing.Size(95, 40)
		Me.Button.TabIndex = 64
		Me.Button.Text = "Kirim"
		Me.Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button.UseVisualStyleBackColor = False
		'
		'CheckedListBox1
		'
		Me.CheckedListBox1.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CheckedListBox1.FormattingEnabled = True
		Me.CheckedListBox1.HorizontalScrollbar = True
		Me.CheckedListBox1.Items.AddRange(New Object() {"Membuat, Memperbaharui, Menghapus Status", "Menjawab, Memperbaharui Jawaban, Menghapus Jawaban, Membaca Soal Situs Learn", "Mengedit Status Orang Lain", "Menghapus Status Orang Lain", "Membuat Aplikasi Awan (Server Cloud)", "Menggunggah File Gambar", "Menggunggah File Dokumen", "Menggunggah File Video atau Audio", "Menggunggah Software", "Menggunggah File Lainnya", "Mengedit Artikel Blog", "Menghapus Artikel Blog", "Menulis Blog", "Mengatur Penampilan Blog", "Melihat Penilaian Situs Learn", "Melihat Kode yang Telah Diunggah pada Situs Learn Code", "Mengedit Kode yang Telah Diunggah pada Situs Learn Code", "Menggunggah Kode pada Situs Learn Code", "Memberikan Pesan pada Situs Learn Code", "Melihat Penilaian Semua Pengguna Situs Learn Code", "Melihat Kode Semua Pengguna Situs Learn Code", "Mengedit Kode Semua Pengguna Situs Learn Code", "Membuat, Memperbaharui, Menghapus Soal pada Situs Learn Code", "Membuat Penilaian pada Situs Learn Code", "Membatalkan Pemeriksaan Kompiler", "Membuat, Memperbaharui, Menghapus Jawaban pada Situs Learn", "Melihat Pesan Hasil Penilaian pada Situs Learn Code", "Melihat Pesan Hasil Penilaian yang Dibuat Oleh Penilai Lain pada Situs Learn", "Memberikan Kritik dan Saran", "Manajemen Sumber Daya Server", "Membuat, Memperbaharui, Menghapus Hasil Penilaian yang Dibuat Oleh Penilai Lain p" &
				"ada Situs Learn", "Mengatur Tabel ""Level""", "Mengatur Tabel ""Pengguna""", "Mengatur Sistem", "Melihat Statistik Situs", "Membuat, Memperbaharui, Menghapus, Membaca Pesan pada Aplikasi Kabel", "Membuat, Memperbaharui, Menghapus, Membaca Pesan yang Dibuat Oleh Orang Lain  pad" &
				"a Aplikasi Kabel", "Mengatur Tabel ""Kesan"" dan ""Daftar"""})
		Me.CheckedListBox1.Location = New System.Drawing.Point(225, 121)
		Me.CheckedListBox1.Name = "CheckedListBox1"
		Me.CheckedListBox1.Size = New System.Drawing.Size(333, 194)
		Me.CheckedListBox1.TabIndex = 65
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(221, 318)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(105, 23)
		Me.Label3.TabIndex = 66
		Me.Label3.Text = "Kode Level : 0"
		'
		'addLevel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(585, 420)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.CheckedListBox1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Nama)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.LblUser1)
		Me.Controls.Add(Me.Button)
		Me.Controls.Add(Me.PictureBox2)
		Me.MinimumSize = New System.Drawing.Size(520, 416)
		Me.Name = "addLevel"
		Me.Text = "Tambah Level"
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Nama As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents LblUser1 As Label
	Friend WithEvents Button As Button
	Friend WithEvents CheckedListBox1 As CheckedListBox
	Friend WithEvents Label3 As Label
End Class
