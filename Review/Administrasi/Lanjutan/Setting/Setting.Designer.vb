<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Setting
	Inherits MetroFramework.Forms.MetroForm

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Setting))
		Me.Server = New System.Windows.Forms.TextBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LblServer = New System.Windows.Forms.Label()
		Me.LblNamaDB = New System.Windows.Forms.Label()
		Me.DB_Name = New System.Windows.Forms.TextBox()
		Me.DB_User = New System.Windows.Forms.TextBox()
		Me.LblUser1 = New System.Windows.Forms.Label()
		Me.LblPass1 = New System.Windows.Forms.Label()
		Me.DB_Pass = New System.Windows.Forms.TextBox()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
		Me.SaveMe = New System.Windows.Forms.CheckBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.LblProses = New System.Windows.Forms.Label()
		Me.Proses = New MetroFramework.Controls.MetroProgressBar()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Blog = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Instagram = New System.Windows.Forms.TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Line = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.DelALL = New System.Windows.Forms.CheckBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.DelData = New System.Windows.Forms.CheckBox()
		Me.DelPengguna = New System.Windows.Forms.CheckBox()
		Me.DelLevel = New System.Windows.Forms.CheckBox()
		Me.DelKesan = New System.Windows.Forms.CheckBox()
		Me.DelDaftar = New System.Windows.Forms.CheckBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Server
		'
		Me.Server.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Server.Location = New System.Drawing.Point(226, 137)
		Me.Server.Name = "Server"
		Me.Server.Size = New System.Drawing.Size(227, 26)
		Me.Server.TabIndex = 28
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.Settings_96px
		Me.PictureBox1.Location = New System.Drawing.Point(23, 81)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
		Me.PictureBox1.TabIndex = 29
		Me.PictureBox1.TabStop = False
		'
		'Button3
		'
		Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Button3.BackColor = System.Drawing.Color.White
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold)
		Me.Button3.Image = Global.Review.My.Resources.Resources.Sent_36px
		Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button3.Location = New System.Drawing.Point(365, 618)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(95, 40)
		Me.Button3.TabIndex = 27
		Me.Button3.Text = "Kirim"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button3.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(130, 76)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(136, 23)
		Me.Label1.TabIndex = 30
		Me.Label1.Text = "Isilah data berikut."
		'
		'LblServer
		'
		Me.LblServer.AutoSize = True
		Me.LblServer.BackColor = System.Drawing.Color.White
		Me.LblServer.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblServer.Location = New System.Drawing.Point(130, 140)
		Me.LblServer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblServer.Name = "LblServer"
		Me.LblServer.Size = New System.Drawing.Size(55, 23)
		Me.LblServer.TabIndex = 32
		Me.LblServer.Text = "Server"
		'
		'LblNamaDB
		'
		Me.LblNamaDB.AutoSize = True
		Me.LblNamaDB.BackColor = System.Drawing.Color.White
		Me.LblNamaDB.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblNamaDB.Location = New System.Drawing.Point(130, 174)
		Me.LblNamaDB.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblNamaDB.Name = "LblNamaDB"
		Me.LblNamaDB.Size = New System.Drawing.Size(78, 23)
		Me.LblNamaDB.TabIndex = 33
		Me.LblNamaDB.Text = "Nama DB"
		'
		'DB_Name
		'
		Me.DB_Name.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DB_Name.Location = New System.Drawing.Point(226, 171)
		Me.DB_Name.Name = "DB_Name"
		Me.DB_Name.Size = New System.Drawing.Size(227, 26)
		Me.DB_Name.TabIndex = 34
		'
		'DB_User
		'
		Me.DB_User.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DB_User.Location = New System.Drawing.Point(226, 203)
		Me.DB_User.Name = "DB_User"
		Me.DB_User.Size = New System.Drawing.Size(227, 26)
		Me.DB_User.TabIndex = 36
		'
		'LblUser1
		'
		Me.LblUser1.AutoSize = True
		Me.LblUser1.BackColor = System.Drawing.Color.White
		Me.LblUser1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblUser1.Location = New System.Drawing.Point(130, 206)
		Me.LblUser1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblUser1.Name = "LblUser1"
		Me.LblUser1.Size = New System.Drawing.Size(82, 23)
		Me.LblUser1.TabIndex = 35
		Me.LblUser1.Text = "Username"
		'
		'LblPass1
		'
		Me.LblPass1.AutoSize = True
		Me.LblPass1.BackColor = System.Drawing.Color.White
		Me.LblPass1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPass1.Location = New System.Drawing.Point(130, 238)
		Me.LblPass1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblPass1.Name = "LblPass1"
		Me.LblPass1.Size = New System.Drawing.Size(77, 23)
		Me.LblPass1.TabIndex = 37
		Me.LblPass1.Text = "Password"
		'
		'DB_Pass
		'
		Me.DB_Pass.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DB_Pass.Location = New System.Drawing.Point(226, 235)
		Me.DB_Pass.Name = "DB_Pass"
		Me.DB_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
		Me.DB_Pass.Size = New System.Drawing.Size(227, 26)
		Me.DB_Pass.TabIndex = 38
		'
		'ToolTip1
		'
		Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.ToolTip1.ToolTipTitle = "Informasi"
		'
		'SaveMe
		'
		Me.SaveMe.AutoSize = True
		Me.SaveMe.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.SaveMe.Location = New System.Drawing.Point(132, 557)
		Me.SaveMe.Name = "SaveMe"
		Me.SaveMe.Size = New System.Drawing.Size(206, 23)
		Me.SaveMe.TabIndex = 59
		Me.SaveMe.Text = "Pertahankan pengguna saya"
		Me.ToolTip1.SetToolTip(Me.SaveMe, "Akun anda akan dipertahankan. Kami tidak akan membuat akun baru.")
		Me.SaveMe.UseVisualStyleBackColor = True
		'
		'PictureBox2
		'
		Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox2.Image = Global.Review.My.Resources.Resources._45
		Me.PictureBox2.Location = New System.Drawing.Point(16, 593)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(73, 46)
		Me.PictureBox2.TabIndex = 45
		Me.PictureBox2.TabStop = False
		Me.PictureBox2.Visible = False
		'
		'LblProses
		'
		Me.LblProses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.LblProses.AutoSize = True
		Me.LblProses.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblProses.Location = New System.Drawing.Point(99, 624)
		Me.LblProses.Name = "LblProses"
		Me.LblProses.Size = New System.Drawing.Size(194, 23)
		Me.LblProses.TabIndex = 47
		Me.LblProses.Text = "0% - Belum ada pekerjaan"
		Me.LblProses.Visible = False
		'
		'Proses
		'
		Me.Proses.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.Proses.Location = New System.Drawing.Point(99, 589)
		Me.Proses.MarqueeAnimationSpeed = 13
		Me.Proses.Maximum = 13
		Me.Proses.Name = "Proses"
		Me.Proses.Size = New System.Drawing.Size(354, 32)
		Me.Proses.Step = 1
		Me.Proses.Style = MetroFramework.MetroColorStyle.Blue
		Me.Proses.TabIndex = 46
		Me.Proses.Visible = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(130, 109)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(99, 23)
		Me.Label2.TabIndex = 48
		Me.Label2.Text = "Data Server"
		'
		'Blog
		'
		Me.Blog.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Blog.Location = New System.Drawing.Point(226, 367)
		Me.Blog.Name = "Blog"
		Me.Blog.Size = New System.Drawing.Size(227, 26)
		Me.Blog.TabIndex = 54
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(130, 370)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(41, 23)
		Me.Label3.TabIndex = 53
		Me.Label3.Text = "Blog"
		'
		'Instagram
		'
		Me.Instagram.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Instagram.Location = New System.Drawing.Point(226, 335)
		Me.Instagram.Name = "Instagram"
		Me.Instagram.Size = New System.Drawing.Size(227, 26)
		Me.Instagram.TabIndex = 52
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.White
		Me.Label4.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(130, 338)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(82, 23)
		Me.Label4.TabIndex = 51
		Me.Label4.Text = "Instagram"
		'
		'Line
		'
		Me.Line.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Line.Location = New System.Drawing.Point(226, 303)
		Me.Line.Name = "Line"
		Me.Line.Size = New System.Drawing.Size(227, 26)
		Me.Line.TabIndex = 50
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.White
		Me.Label5.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(130, 306)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(38, 23)
		Me.Label5.TabIndex = 49
		Me.Label5.Text = "Line"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.White
		Me.Label6.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Location = New System.Drawing.Point(130, 276)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(138, 23)
		Me.Label6.TabIndex = 55
		Me.Label6.Text = "Data Media Sosial"
		'
		'DelALL
		'
		Me.DelALL.AutoSize = True
		Me.DelALL.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelALL.Location = New System.Drawing.Point(132, 436)
		Me.DelALL.Name = "DelALL"
		Me.DelALL.Size = New System.Drawing.Size(222, 23)
		Me.DelALL.TabIndex = 56
		Me.DelALL.Text = "Hapus semua tabel di database."
		Me.DelALL.UseVisualStyleBackColor = True
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.White
		Me.Label7.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label7.Location = New System.Drawing.Point(128, 404)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(41, 23)
		Me.Label7.TabIndex = 57
		Me.Label7.Text = "Opsi"
		'
		'DelData
		'
		Me.DelData.AutoSize = True
		Me.DelData.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelData.Location = New System.Drawing.Point(132, 528)
		Me.DelData.Name = "DelData"
		Me.DelData.Size = New System.Drawing.Size(237, 23)
		Me.DelData.TabIndex = 58
		Me.DelData.Text = "Hapus semua data di semua tabel."
		Me.DelData.UseVisualStyleBackColor = True
		'
		'DelPengguna
		'
		Me.DelPengguna.AutoSize = True
		Me.DelPengguna.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelPengguna.Location = New System.Drawing.Point(326, 465)
		Me.DelPengguna.Name = "DelPengguna"
		Me.DelPengguna.Size = New System.Drawing.Size(127, 23)
		Me.DelPengguna.TabIndex = 60
		Me.DelPengguna.Text = "Tabel Pengguna"
		Me.DelPengguna.UseVisualStyleBackColor = True
		'
		'DelLevel
		'
		Me.DelLevel.AutoSize = True
		Me.DelLevel.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelLevel.Location = New System.Drawing.Point(150, 465)
		Me.DelLevel.Name = "DelLevel"
		Me.DelLevel.Size = New System.Drawing.Size(96, 23)
		Me.DelLevel.TabIndex = 61
		Me.DelLevel.Text = "Tabel Level"
		Me.DelLevel.UseVisualStyleBackColor = True
		'
		'DelKesan
		'
		Me.DelKesan.AutoSize = True
		Me.DelKesan.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelKesan.Location = New System.Drawing.Point(150, 494)
		Me.DelKesan.Name = "DelKesan"
		Me.DelKesan.Size = New System.Drawing.Size(103, 23)
		Me.DelKesan.TabIndex = 63
		Me.DelKesan.Text = "Tabel Kesan"
		Me.DelKesan.UseVisualStyleBackColor = True
		'
		'DelDaftar
		'
		Me.DelDaftar.AutoSize = True
		Me.DelDaftar.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.DelDaftar.Location = New System.Drawing.Point(326, 494)
		Me.DelDaftar.Name = "DelDaftar"
		Me.DelDaftar.Size = New System.Drawing.Size(104, 23)
		Me.DelDaftar.TabIndex = 62
		Me.DelDaftar.Text = "Tabel Daftar"
		Me.DelDaftar.UseVisualStyleBackColor = True
		'
		'Setting
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
		Me.ClientSize = New System.Drawing.Size(477, 677)
		Me.Controls.Add(Me.DelKesan)
		Me.Controls.Add(Me.DelDaftar)
		Me.Controls.Add(Me.DelLevel)
		Me.Controls.Add(Me.DelPengguna)
		Me.Controls.Add(Me.SaveMe)
		Me.Controls.Add(Me.DelData)
		Me.Controls.Add(Me.Label7)
		Me.Controls.Add(Me.DelALL)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Blog)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Instagram)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Line)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.LblProses)
		Me.Controls.Add(Me.Proses)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.DB_Pass)
		Me.Controls.Add(Me.LblPass1)
		Me.Controls.Add(Me.DB_User)
		Me.Controls.Add(Me.LblUser1)
		Me.Controls.Add(Me.DB_Name)
		Me.Controls.Add(Me.LblNamaDB)
		Me.Controls.Add(Me.LblServer)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Server)
		Me.Controls.Add(Me.Button3)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Setting"
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Black
		Me.Text = "Dialog Pengaturan"
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Server As TextBox
	Friend WithEvents Button3 As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents LblServer As Label
	Friend WithEvents LblNamaDB As Label
	Friend WithEvents DB_Name As TextBox
	Friend WithEvents DB_User As TextBox
	Friend WithEvents LblUser1 As Label
	Friend WithEvents LblPass1 As Label
	Friend WithEvents ToolTip1 As ToolTip
	Friend WithEvents DB_Pass As TextBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents LblProses As Label
	Friend WithEvents Proses As MetroFramework.Controls.MetroProgressBar
	Friend WithEvents Label2 As Label
	Friend WithEvents Blog As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Instagram As TextBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Line As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents DelALL As CheckBox
	Friend WithEvents Label7 As Label
	Friend WithEvents DelData As CheckBox
	Friend WithEvents SaveMe As CheckBox
	Friend WithEvents DelPengguna As CheckBox
	Friend WithEvents DelLevel As CheckBox
	Friend WithEvents DelKesan As CheckBox
	Friend WithEvents DelDaftar As CheckBox
End Class
