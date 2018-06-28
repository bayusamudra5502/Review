<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Username = New System.Windows.Forms.TextBox()
		Me.Labelan = New System.Windows.Forms.Label()
		Me.Password = New System.Windows.Forms.TextBox()
		Me.pic = New System.Windows.Forms.PictureBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Server = New System.Windows.Forms.TextBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Password.SuspendLayout()
		CType(Me.pic, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(102, 146)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(133, 40)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "PATCHER"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(120, 186)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(95, 19)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Administrator"
		'
		'Button1
		'
		Me.Button1.BackColor = System.Drawing.Color.White
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold)
		Me.Button1.Location = New System.Drawing.Point(140, 329)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 34)
		Me.Button1.TabIndex = 3
		Me.Button1.Text = "Login"
		Me.Button1.UseVisualStyleBackColor = False
		'
		'Username
		'
		Me.Username.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Username.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Username.Location = New System.Drawing.Point(44, 250)
		Me.Username.Name = "Username"
		Me.Username.Size = New System.Drawing.Size(253, 17)
		Me.Username.TabIndex = 4
		Me.Username.Text = "Username"
		'
		'Labelan
		'
		Me.Labelan.BackColor = System.Drawing.Color.Black
		Me.Labelan.Location = New System.Drawing.Point(44, 272)
		Me.Labelan.Name = "Labelan"
		Me.Labelan.Size = New System.Drawing.Size(253, 1)
		Me.Labelan.TabIndex = 0
		'
		'Password
		'
		Me.Password.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Password.Controls.Add(Me.pic)
		Me.Password.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Password.Location = New System.Drawing.Point(44, 280)
		Me.Password.MaxLength = 40
		Me.Password.Name = "Password"
		Me.Password.Size = New System.Drawing.Size(253, 17)
		Me.Password.TabIndex = 5
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
		'Label3
		'
		Me.Label3.BackColor = System.Drawing.Color.Black
		Me.Label3.Location = New System.Drawing.Point(44, 300)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(253, 1)
		Me.Label3.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.BackColor = System.Drawing.Color.Black
		Me.Label4.Location = New System.Drawing.Point(44, 245)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(253, 1)
		Me.Label4.TabIndex = 8
		'
		'Server
		'
		Me.Server.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Server.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Server.Location = New System.Drawing.Point(44, 223)
		Me.Server.Name = "Server"
		Me.Server.Size = New System.Drawing.Size(253, 17)
		Me.Server.TabIndex = 9
		Me.Server.Text = "Server"
		'
		'PictureBox3
		'
		Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox3.Image = Global.Review.My.Resources.Resources.ezgif_4_bbe2b252d5
		Me.PictureBox3.Location = New System.Drawing.Point(154, 322)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(44, 47)
		Me.PictureBox3.TabIndex = 10
		Me.PictureBox3.TabStop = False
		Me.PictureBox3.Visible = False
		'
		'PictureBox2
		'
		Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
		Me.PictureBox2.Image = Global.Review.My.Resources.Resources.Delete_24px
		Me.PictureBox2.Location = New System.Drawing.Point(316, 12)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(25, 26)
		Me.PictureBox2.TabIndex = 6
		Me.PictureBox2.TabStop = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.Administrative_Tools_96px
		Me.PictureBox1.Location = New System.Drawing.Point(117, 35)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(100, 101)
		Me.PictureBox1.TabIndex = 0
		Me.PictureBox1.TabStop = False
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(353, 375)
		Me.ControlBox = False
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Server)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.PictureBox2)
		Me.Controls.Add(Me.Password)
		Me.Controls.Add(Me.Labelan)
		Me.Controls.Add(Me.Username)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.PictureBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "Form1"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		Me.Password.ResumeLayout(False)
		CType(Me.pic, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Button1 As Button
	Friend WithEvents Username As TextBox
	Friend WithEvents Labelan As Label
	Friend WithEvents Password As TextBox
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents pic As PictureBox
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Server As TextBox
	Friend WithEvents PictureBox3 As PictureBox
End Class
