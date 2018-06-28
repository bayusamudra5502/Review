<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SettingVerify
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingVerify))
		Me.Password = New System.Windows.Forms.TextBox()
		Me.pic = New System.Windows.Forms.PictureBox()
		Me.Labelan = New System.Windows.Forms.Label()
		Me.Username = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.Keterangan = New System.Windows.Forms.ToolTip(Me.components)
		Me.Password.SuspendLayout()
		CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Password
		'
		Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Password.Controls.Add(Me.pic)
		Me.Password.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Password.Location = New System.Drawing.Point(31, 288)
		Me.Password.MaxLength = 40
		Me.Password.Name = "Password"
		Me.Password.Size = New System.Drawing.Size(253, 17)
		Me.Password.TabIndex = 16
		Me.Password.Text = "Password"
		'
		'pic
		'
		Me.pic.Cursor = System.Windows.Forms.Cursors.Hand
		Me.pic.Dock = System.Windows.Forms.DockStyle.Right
		Me.pic.Image = Global.Review.My.Resources.Resources.Eye_18px
		Me.pic.Location = New System.Drawing.Point(235, 0)
		Me.pic.Name = "pic"
		Me.pic.Size = New System.Drawing.Size(18, 17)
		Me.pic.TabIndex = 0
		Me.pic.TabStop = False
		'
		'Labelan
		'
		Me.Labelan.BackColor = System.Drawing.Color.Black
		Me.Labelan.Location = New System.Drawing.Point(31, 280)
		Me.Labelan.Name = "Labelan"
		Me.Labelan.Size = New System.Drawing.Size(253, 1)
		Me.Labelan.TabIndex = 10
		'
		'Username
		'
		Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Username.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Username.Location = New System.Drawing.Point(31, 258)
		Me.Username.Name = "Username"
		Me.Username.Size = New System.Drawing.Size(253, 17)
		Me.Username.TabIndex = 15
		Me.Username.Text = "Username"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.White
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold)
		Me.Button1.Location = New System.Drawing.Point(115, 335)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 34)
		Me.Button1.TabIndex = 14
		Me.Button1.Text = "Login"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(107, 179)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 19)
		Me.Label2.TabIndex = 13
		Me.Label2.Text = "Administrator"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(89, 139)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(133, 40)
		Me.Label1.TabIndex = 12
		Me.Label1.Text = "PATCHER"
		'
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Black
		Me.Label3.Location = New System.Drawing.Point(31, 308)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(253, 1)
		Me.Label3.TabIndex = 18
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.Administrative_Tools_96px
		Me.PictureBox1.Location = New System.Drawing.Point(104, 28)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(100, 101)
		Me.PictureBox1.TabIndex = 11
		Me.PictureBox1.TabStop = False
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label4.Location = New System.Drawing.Point(31, 211)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(253, 34)
		Me.Label4.TabIndex = 19
		Me.Keterangan.SetToolTip(Me.Label4, "Anda harus memiliki akses berikut." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Administrasi tabel 'Level' (Akses Nomor 32)" &
		"" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Administrasi tabel 'Pengguna' (Akses Nomor 33)")
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label5.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(40, 218)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(120, 19)
		Me.Label5.TabIndex = 20
		Me.Label5.Text = "Akses Dibutuhkan"
		Me.Keterangan.SetToolTip(Me.Label5, "Anda harus memiliki akses berikut." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Administrasi tabel 'Level' (Akses Nomor 32)" &
		"" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "• Administrasi tabel 'Pengguna' (Akses Nomor 33)")
		'
		'PictureBox3
		'
		Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox3.Image = Global.Review.My.Resources.Resources.ezgif_4_bbe2b252d5
		Me.PictureBox3.Location = New System.Drawing.Point(130, 329)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(44, 47)
		Me.PictureBox3.TabIndex = 21
		Me.PictureBox3.TabStop = False
		Me.PictureBox3.Visible = False
		'
		'Keterangan
		'
		Me.Keterangan.BackColor = System.Drawing.Color.White
		Me.Keterangan.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.Keterangan.ToolTipTitle = "Informasi"
		'
		'SettingVerify
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(311, 394)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Password)
		Me.Controls.Add(Me.Labelan)
		Me.Controls.Add(Me.Username)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "SettingVerify"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Verify"
		Me.TopMost = True
		Me.Password.ResumeLayout(False)
		CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Password As TextBox
	Friend WithEvents pic As PictureBox
	Friend WithEvents Labelan As Label
	Friend WithEvents Username As TextBox
	Friend WithEvents Button1 As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents Keterangan As ToolTip
End Class
