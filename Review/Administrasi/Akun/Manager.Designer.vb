<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Manager
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
		Me.components = New System.ComponentModel.Container()
		Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
		Me.MetroTabPage1 = New MetroFramework.Controls.MetroTabPage()
		Me.LblLevel = New System.Windows.Forms.Label()
		Me.LblJmlPengguna = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.MetroTabPage2 = New MetroFramework.Controls.MetroTabPage()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.DGVPengguna = New System.Windows.Forms.DataGridView()
		Me.MetroTabPage3 = New MetroFramework.Controls.MetroTabPage()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.DGVLevel = New System.Windows.Forms.DataGridView()
		Me.Updater = New System.Windows.Forms.Timer(Me.components)
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox2 = New System.Windows.Forms.PictureBox()
		Me.MetroTabControl1.SuspendLayout()
		Me.MetroTabPage1.SuspendLayout()
		Me.MetroTabPage2.SuspendLayout()
		CType(Me.DGVPengguna, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MetroTabPage3.SuspendLayout()
		CType(Me.DGVLevel, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'MetroTabControl1
		'
		Me.MetroTabControl1.Controls.Add(Me.MetroTabPage1)
		Me.MetroTabControl1.Controls.Add(Me.MetroTabPage2)
		Me.MetroTabControl1.Controls.Add(Me.MetroTabPage3)
		Me.MetroTabControl1.Location = New System.Drawing.Point(34, 65)
		Me.MetroTabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MetroTabControl1.Name = "MetroTabControl1"
		Me.MetroTabControl1.SelectedIndex = 0
		Me.MetroTabControl1.Size = New System.Drawing.Size(692, 428)
		Me.MetroTabControl1.TabIndex = 0
		Me.MetroTabControl1.UseSelectable = True
		'
		'MetroTabPage1
		'
		Me.MetroTabPage1.Controls.Add(Me.LblLevel)
		Me.MetroTabPage1.Controls.Add(Me.LblJmlPengguna)
		Me.MetroTabPage1.Controls.Add(Me.Label8)
		Me.MetroTabPage1.Controls.Add(Me.Label6)
		Me.MetroTabPage1.Controls.Add(Me.Label4)
		Me.MetroTabPage1.Controls.Add(Me.PictureBox2)
		Me.MetroTabPage1.HorizontalScrollbarBarColor = True
		Me.MetroTabPage1.HorizontalScrollbarHighlightOnWheel = False
		Me.MetroTabPage1.HorizontalScrollbarSize = 10
		Me.MetroTabPage1.Location = New System.Drawing.Point(4, 38)
		Me.MetroTabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MetroTabPage1.Name = "MetroTabPage1"
		Me.MetroTabPage1.Size = New System.Drawing.Size(684, 386)
		Me.MetroTabPage1.TabIndex = 0
		Me.MetroTabPage1.Text = "Ringkasan"
		Me.MetroTabPage1.VerticalScrollbarBarColor = True
		Me.MetroTabPage1.VerticalScrollbarHighlightOnWheel = False
		Me.MetroTabPage1.VerticalScrollbarSize = 10
		'
		'LblLevel
		'
		Me.LblLevel.AutoSize = True
		Me.LblLevel.BackColor = System.Drawing.Color.Transparent
		Me.LblLevel.Location = New System.Drawing.Point(351, 284)
		Me.LblLevel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblLevel.Name = "LblLevel"
		Me.LblLevel.Size = New System.Drawing.Size(138, 23)
		Me.LblLevel.TabIndex = 20
		Me.LblLevel.Text = "Jumlah Pengguna"
		'
		'LblJmlPengguna
		'
		Me.LblJmlPengguna.AutoSize = True
		Me.LblJmlPengguna.BackColor = System.Drawing.Color.Transparent
		Me.LblJmlPengguna.Location = New System.Drawing.Point(351, 256)
		Me.LblJmlPengguna.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.LblJmlPengguna.Name = "LblJmlPengguna"
		Me.LblJmlPengguna.Size = New System.Drawing.Size(138, 23)
		Me.LblJmlPengguna.TabIndex = 19
		Me.LblJmlPengguna.Text = "Jumlah Pengguna"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Location = New System.Drawing.Point(191, 284)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(102, 23)
		Me.Label8.TabIndex = 17
		Me.Label8.Text = "Jumlah Level"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Location = New System.Drawing.Point(191, 256)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(138, 23)
		Me.Label6.TabIndex = 15
		Me.Label6.Text = "Jumlah Pengguna"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Font = New System.Drawing.Font("Quicksand", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Location = New System.Drawing.Point(4, 17)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(107, 28)
		Me.Label4.TabIndex = 14
		Me.Label4.Text = "Ringkasan"
		'
		'MetroTabPage2
		'
		Me.MetroTabPage2.Controls.Add(Me.Label9)
		Me.MetroTabPage2.Controls.Add(Me.DGVPengguna)
		Me.MetroTabPage2.HorizontalScrollbarBarColor = True
		Me.MetroTabPage2.HorizontalScrollbarHighlightOnWheel = False
		Me.MetroTabPage2.HorizontalScrollbarSize = 10
		Me.MetroTabPage2.Location = New System.Drawing.Point(4, 38)
		Me.MetroTabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MetroTabPage2.Name = "MetroTabPage2"
		Me.MetroTabPage2.Size = New System.Drawing.Size(684, 386)
		Me.MetroTabPage2.TabIndex = 1
		Me.MetroTabPage2.Text = "Pengguna"
		Me.MetroTabPage2.VerticalScrollbarBarColor = True
		Me.MetroTabPage2.VerticalScrollbarHighlightOnWheel = False
		Me.MetroTabPage2.VerticalScrollbarSize = 10
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Label9.Font = New System.Drawing.Font("Quicksand", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label9.ForeColor = System.Drawing.Color.DarkCyan
		Me.Label9.Location = New System.Drawing.Point(552, 9)
		Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(128, 19)
		Me.Label9.TabIndex = 15
		Me.Label9.Text = "Tambah Pengguna"
		'
		'DGVPengguna
		'
		Me.DGVPengguna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVPengguna.Location = New System.Drawing.Point(3, 34)
		Me.DGVPengguna.Name = "DGVPengguna"
		Me.DGVPengguna.Size = New System.Drawing.Size(677, 349)
		Me.DGVPengguna.TabIndex = 2
		'
		'MetroTabPage3
		'
		Me.MetroTabPage3.Controls.Add(Me.Label1)
		Me.MetroTabPage3.Controls.Add(Me.DGVLevel)
		Me.MetroTabPage3.HorizontalScrollbarBarColor = True
		Me.MetroTabPage3.HorizontalScrollbarHighlightOnWheel = False
		Me.MetroTabPage3.HorizontalScrollbarSize = 10
		Me.MetroTabPage3.Location = New System.Drawing.Point(4, 38)
		Me.MetroTabPage3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MetroTabPage3.Name = "MetroTabPage3"
		Me.MetroTabPage3.Size = New System.Drawing.Size(684, 386)
		Me.MetroTabPage3.TabIndex = 2
		Me.MetroTabPage3.Text = "Level"
		Me.MetroTabPage3.VerticalScrollbarBarColor = True
		Me.MetroTabPage3.VerticalScrollbarHighlightOnWheel = False
		Me.MetroTabPage3.VerticalScrollbarSize = 10
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.DarkCyan
		Me.Label1.Location = New System.Drawing.Point(581, 5)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(98, 19)
		Me.Label1.TabIndex = 17
		Me.Label1.Text = "Tambah Level"
		'
		'DGVLevel
		'
		Me.DGVLevel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVLevel.Location = New System.Drawing.Point(4, 31)
		Me.DGVLevel.Name = "DGVLevel"
		Me.DGVLevel.Size = New System.Drawing.Size(677, 349)
		Me.DGVLevel.TabIndex = 16
		'
		'Updater
		'
		Me.Updater.Interval = 30000
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.BackColor = System.Drawing.Color.Transparent
		Me.Label21.Location = New System.Drawing.Point(208, 505)
		Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(510, 23)
		Me.Label21.TabIndex = 28
		Me.Label21.Text = "Terjadi kesalahan saat sinkronisasi. Lihat log. Klik untuk memperbaharui."
		Me.Label21.Visible = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Location = New System.Drawing.Point(533, 501)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(185, 23)
		Me.Label2.TabIndex = 30
		Me.Label2.Text = "Sedang memperbaharui.."
		Me.Label2.Visible = False
		'
		'PictureBox4
		'
		Me.PictureBox4.Image = Global.Review.My.Resources.Resources.Close_Window_32px
		Me.PictureBox4.Location = New System.Drawing.Point(176, 500)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
		Me.PictureBox4.TabIndex = 29
		Me.PictureBox4.TabStop = False
		Me.PictureBox4.Visible = False
		'
		'PictureBox3
		'
		Me.PictureBox3.Image = Global.Review.My.Resources.Resources._32
		Me.PictureBox3.Location = New System.Drawing.Point(471, 496)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(55, 32)
		Me.PictureBox3.TabIndex = 27
		Me.PictureBox3.TabStop = False
		Me.PictureBox3.Visible = False
		'
		'PictureBox2
		'
		Me.PictureBox2.BackColor = System.Drawing.Color.White
		Me.PictureBox2.Image = Global.Review.My.Resources.Resources.Ein_Buch
		Me.PictureBox2.Location = New System.Drawing.Point(273, 84)
		Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.PictureBox2.Name = "PictureBox2"
		Me.PictureBox2.Size = New System.Drawing.Size(130, 134)
		Me.PictureBox2.TabIndex = 18
		Me.PictureBox2.TabStop = False
		'
		'Manager
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(754, 546)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.PictureBox4)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.MetroTabControl1)
		Me.Controls.Add(Me.Label21)
		Me.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.MaximizeBox = False
		Me.Name = "Manager"
		Me.Padding = New System.Windows.Forms.Padding(30, 106, 30, 35)
		Me.Resizable = False
		Me.Text = "Manager Akun"
		Me.MetroTabControl1.ResumeLayout(False)
		Me.MetroTabPage1.ResumeLayout(False)
		Me.MetroTabPage1.PerformLayout()
		Me.MetroTabPage2.ResumeLayout(False)
		Me.MetroTabPage2.PerformLayout()
		CType(Me.DGVPengguna, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MetroTabPage3.ResumeLayout(False)
		Me.MetroTabPage3.PerformLayout()
		CType(Me.DGVLevel, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
	Friend WithEvents MetroTabPage1 As MetroFramework.Controls.MetroTabPage
	Friend WithEvents MetroTabPage2 As MetroFramework.Controls.MetroTabPage
	Friend WithEvents MetroTabPage3 As MetroFramework.Controls.MetroTabPage
	Friend WithEvents LblLevel As Label
	Friend WithEvents LblJmlPengguna As Label
	Friend WithEvents Label8 As Label
	Friend WithEvents Label6 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents PictureBox2 As PictureBox
	Friend WithEvents DGVPengguna As DataGridView
	Friend WithEvents Label9 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents DGVLevel As DataGridView
	Friend WithEvents Updater As Timer
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents Label21 As Label
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents Label2 As Label
End Class
