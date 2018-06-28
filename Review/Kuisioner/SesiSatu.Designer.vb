'*****************************************************************************
' Nama File : Varlist.Designer.vb
' Deskripsi : Desain Form Sesi Satu
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 14 Juni 2018
' Tanggal Edit : 19 Juni 2018
' Copyright PATCH (c) 2018
' ****************************************************************************

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SesiSatu
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SesiSatu))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(22, 67)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(284, 19)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Isilah data diri anda pada kolom dibawah ini."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Red
		Me.Label2.Location = New System.Drawing.Point(31, 382)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 19)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "* Wajib Diisi"
		'
		'TextBox1
		'
		Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
		Me.TextBox1.Location = New System.Drawing.Point(129, 108)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(407, 24)
		Me.TextBox1.TabIndex = 4
		Me.TextBox1.Text = "Nama Lengkap *"
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(129, 138)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(407, 24)
		Me.TextBox2.TabIndex = 5
		Me.TextBox2.Text = "Nama Panggilan *"
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(129, 259)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(407, 24)
		Me.TextBox3.TabIndex = 6
		Me.TextBox3.Text = "Akun Line"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"10", "11", "12", "13", "14", "15", "16", "17", "18"})
		Me.ComboBox1.Location = New System.Drawing.Point(129, 211)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(138, 27)
		Me.ComboBox1.TabIndex = 7
		Me.ComboBox1.Text = "Umur *"
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(129, 289)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(407, 24)
		Me.TextBox4.TabIndex = 8
		Me.TextBox4.Text = "Nomor Handphone Aktif *"
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(129, 319)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(407, 24)
		Me.TextBox5.TabIndex = 9
		Me.TextBox5.Text = "Email"
		'
		'Button1
		'
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(449, 374)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(87, 32)
		Me.Button1.TabIndex = 10
		Me.Button1.Text = "Lanjut"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.IdentificationDocuments_72px
		Me.PictureBox1.Location = New System.Drawing.Point(35, 108)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(76, 73)
		Me.PictureBox1.TabIndex = 3
		Me.PictureBox1.TabStop = False
		'
		'TextBox6
		'
		Me.TextBox6.Location = New System.Drawing.Point(129, 168)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(407, 24)
		Me.TextBox6.TabIndex = 11
		Me.TextBox6.Text = "Kelas atau Kelompok MPLS *"
		'
		'SesiSatu
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(566, 429)
		Me.ControlBox = False
		Me.Controls.Add(Me.TextBox6)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.TextBox5)
		Me.Controls.Add(Me.TextBox4)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.TextBox3)
		Me.Controls.Add(Me.TextBox2)
		Me.Controls.Add(Me.TextBox1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.Name = "SesiSatu"
		Me.Padding = New System.Windows.Forms.Padding(27, 88, 27, 29)
		Me.Resizable = False
		Me.Text = "Siapakah Anda?"
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents TextBox1 As TextBox
	Friend WithEvents TextBox2 As TextBox
	Friend WithEvents TextBox3 As TextBox
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents TextBox4 As TextBox
	Friend WithEvents TextBox5 As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents TextBox6 As TextBox
End Class
