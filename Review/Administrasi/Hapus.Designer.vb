<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hapus
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hapus))
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.CheckBox1 = New System.Windows.Forms.CheckBox()
		Me.CheckBox2 = New System.Windows.Forms.CheckBox()
		Me.Password = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.White
		Me.Label2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(133, 148)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(261, 23)
		Me.Label2.TabIndex = 17
		Me.Label2.Text = "Data mana yang ingin anda hapus?"
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Location = New System.Drawing.Point(24, 63)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(386, 69)
		Me.Label1.TabIndex = 18
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label3.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(33, 70)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(89, 23)
		Me.Label3.TabIndex = 19
		Me.Label3.Text = "Perhatian !"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.Label4.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(33, 98)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(367, 23)
		Me.Label4.TabIndex = 20
		Me.Label4.Text = "Segala perubahan terjadi tidak dapat dikembalikan."
		'
		'CheckBox1
		'
		Me.CheckBox1.AutoSize = True
		Me.CheckBox1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CheckBox1.Location = New System.Drawing.Point(137, 177)
		Me.CheckBox1.Name = "CheckBox1"
		Me.CheckBox1.Size = New System.Drawing.Size(157, 27)
		Me.CheckBox1.TabIndex = 21
		Me.CheckBox1.Text = "Tabel Pendaftaran"
		Me.CheckBox1.UseVisualStyleBackColor = True
		'
		'CheckBox2
		'
		Me.CheckBox2.AutoSize = True
		Me.CheckBox2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CheckBox2.Location = New System.Drawing.Point(137, 205)
		Me.CheckBox2.Name = "CheckBox2"
		Me.CheckBox2.Size = New System.Drawing.Size(119, 27)
		Me.CheckBox2.TabIndex = 22
		Me.CheckBox2.Text = "Tabel Survey"
		Me.CheckBox2.UseVisualStyleBackColor = True
		'
		'Password
		'
		Me.Password.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Password.Location = New System.Drawing.Point(174, 270)
		Me.Password.Name = "Password"
		Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
		Me.Password.Size = New System.Drawing.Size(231, 26)
		Me.Password.TabIndex = 26
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.White
		Me.Label5.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Location = New System.Drawing.Point(170, 244)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(144, 23)
		Me.Label5.TabIndex = 27
		Me.Label5.Text = "Masukan Password"
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = Global.Review.My.Resources.Resources.Key_2_36px
		Me.PictureBox3.Location = New System.Drawing.Point(132, 254)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(38, 39)
		Me.PictureBox3.TabIndex = 28
		Me.PictureBox3.TabStop = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Image = Global.Review.My.Resources.Resources._32
		Me.PictureBox2.Location = New System.Drawing.Point(348, 307)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(57, 36)
		Me.PictureBox2.TabIndex = 25
		Me.PictureBox2.TabStop = False
		Me.PictureBox2.Visible = False
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.White
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold)
		Me.Button3.Image = Global.Review.My.Resources.Resources.Trash_Can_32px
		Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button3.Location = New System.Drawing.Point(321, 304)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(89, 40)
		Me.Button3.TabIndex = 24
		Me.Button3.Text = "Hapus"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button3.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.Erase_96px
		Me.PictureBox1.Location = New System.Drawing.Point(28, 148)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(100, 95)
		Me.PictureBox1.TabIndex = 23
		Me.PictureBox1.TabStop = False
		'
		'Hapus
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(434, 358)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Password)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.CheckBox2)
		Me.Controls.Add(Me.CheckBox1)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.Label2)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Hapus"
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Red
		Me.Text = "Hapus Data"
		Me.TopMost = True
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents CheckBox1 As CheckBox
	Friend WithEvents CheckBox2 As CheckBox
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button3 As Button
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents Password As TextBox
	Friend WithEvents Label5 As Label
	Friend WithEvents PictureBox3 As PictureBox
End Class
