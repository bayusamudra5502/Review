<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Passcode = New System.Windows.Forms.TextBox()
		Me.LblPass1 = New System.Windows.Forms.Label()
		Me.Uid = New System.Windows.Forms.TextBox()
		Me.LblUser1 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Nama = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Verify = New System.Windows.Forms.TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Level = New System.Windows.Forms.ComboBox()
		Me.Button = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.IdentificationDocuments_72px
		Me.PictureBox1.Location = New System.Drawing.Point(23, 63)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(74, 69)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Passcode
		'
		Me.Passcode.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Passcode.Location = New System.Drawing.Point(269, 153)
		Me.Passcode.Name = "Passcode"
		Me.Passcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
		Me.Passcode.Size = New System.Drawing.Size(227, 26)
		Me.Passcode.TabIndex = 42
		'
		'LblPass1
		'
		Me.LblPass1.AutoSize = True
		Me.LblPass1.BackColor = System.Drawing.Color.White
		Me.LblPass1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblPass1.Location = New System.Drawing.Point(113, 153)
		Me.LblPass1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblPass1.Name = "LblPass1"
		Me.LblPass1.Size = New System.Drawing.Size(77, 23)
		Me.LblPass1.TabIndex = 41
		Me.LblPass1.Text = "Password"
		'
		'Uid
		'
		Me.Uid.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Uid.Location = New System.Drawing.Point(269, 121)
		Me.Uid.Name = "Uid"
		Me.Uid.Size = New System.Drawing.Size(227, 26)
		Me.Uid.TabIndex = 40
		'
		'LblUser1
		'
		Me.LblUser1.AutoSize = True
		Me.LblUser1.BackColor = System.Drawing.Color.White
		Me.LblUser1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblUser1.Location = New System.Drawing.Point(113, 124)
		Me.LblUser1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblUser1.Name = "LblUser1"
		Me.LblUser1.Size = New System.Drawing.Size(82, 23)
		Me.LblUser1.TabIndex = 39
		Me.LblUser1.Text = "Username"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(112, 63)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(313, 23)
		Me.Label1.TabIndex = 43
		Me.Label1.Text = "Isilah identitas pengguna yang akan dibuat." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'Nama
		'
		Me.Nama.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Nama.Location = New System.Drawing.Point(269, 89)
		Me.Nama.Name = "Nama"
		Me.Nama.Size = New System.Drawing.Size(227, 26)
		Me.Nama.TabIndex = 45
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(113, 92)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(53, 23)
		Me.Label2.TabIndex = 44
		Me.Label2.Text = "Nama"
		'
		'Verify
		'
		Me.Verify.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Verify.Location = New System.Drawing.Point(269, 185)
		Me.Verify.Name = "Verify"
		Me.Verify.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
		Me.Verify.Size = New System.Drawing.Size(227, 26)
		Me.Verify.TabIndex = 47
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.White
		Me.Label3.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(113, 185)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(149, 23)
		Me.Label3.TabIndex = 46
		Me.Label3.Text = "Vertifikasi Password"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.White
		Me.Label4.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(113, 224)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(120, 23)
		Me.Label4.TabIndex = 48
		Me.Label4.Text = "Level Pengguna"
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.Review.My.Resources.Resources._32
		Me.PictureBox2.Location = New System.Drawing.Point(417, 267)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(57, 36)
		Me.PictureBox2.TabIndex = 49
		Me.PictureBox2.TabStop = False
		Me.PictureBox2.Visible = False
		'
		'Level
		'
		Me.Level.Enabled = False
		Me.Level.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Level.FormattingEnabled = True
		Me.Level.Location = New System.Drawing.Point(269, 224)
		Me.Level.Name = "Level"
		Me.Level.Size = New System.Drawing.Size(226, 27)
		Me.Level.TabIndex = 50
		Me.Level.Text = "Pilih Level"
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
		Me.Button.Location = New System.Drawing.Point(401, 264)
		Me.Button.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button.Name = "Button"
		Me.Button.Size = New System.Drawing.Size(95, 40)
		Me.Button.TabIndex = 51
		Me.Button.Text = "Kirim"
		Me.Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button.UseVisualStyleBackColor = False
		'
		'AddUser
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(518, 329)
		Me.Controls.Add(Me.Level)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Verify)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Nama)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Passcode)
		Me.Controls.Add(Me.LblPass1)
		Me.Controls.Add(Me.Uid)
		Me.Controls.Add(Me.LblUser1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Button)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "AddUser"
		Me.Style = MetroFramework.MetroColorStyle.Teal
		Me.Text = "Tambah Pengguna"
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Passcode As TextBox
	Friend WithEvents LblPass1 As Label
	Friend WithEvents Uid As TextBox
	Friend WithEvents LblUser1 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Nama As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Verify As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Level As ComboBox
	Friend WithEvents Button As Button
End Class
