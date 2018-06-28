<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Export2Excel
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Export2Excel))
		Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Proses = New MetroFramework.Controls.MetroProgressBar()
		Me.LblProses = New System.Windows.Forms.Label()
		Me.Loading = New System.Windows.Forms.PictureBox()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.Loading, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'CheckedListBox1
		'
		Me.CheckedListBox1.Enabled = False
		Me.CheckedListBox1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CheckedListBox1.FormattingEnabled = True
		Me.CheckedListBox1.Location = New System.Drawing.Point(150, 187)
		Me.CheckedListBox1.Margin = New System.Windows.Forms.Padding(4)
		Me.CheckedListBox1.Name = "CheckedListBox1"
		Me.CheckedListBox1.Size = New System.Drawing.Size(407, 172)
		Me.CheckedListBox1.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(131, 82)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(205, 23)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "Isilah pengaturan berikut ini."
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Location = New System.Drawing.Point(131, 118)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(254, 23)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "1. Tabel yang akan diekspor adalah"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Location = New System.Drawing.Point(131, 151)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(311, 23)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "2. Kolom tabel yang akan diekspor adalah :"
		'
		'ComboBox1
		'
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Tabel Pendaftaran", "Tabel Kesan"})
		Me.ComboBox1.Location = New System.Drawing.Point(391, 118)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(166, 27)
		Me.ComboBox1.TabIndex = 5
		Me.ComboBox1.Text = "Pilih Tabel"
		'
		'Proses
		'
		Me.Proses.Location = New System.Drawing.Point(97, 376)
		Me.Proses.MarqueeAnimationSpeed = 13
		Me.Proses.Maximum = 13
		Me.Proses.Name = "Proses"
		Me.Proses.Size = New System.Drawing.Size(459, 32)
		Me.Proses.Step = 1
		Me.Proses.Style = MetroFramework.MetroColorStyle.Blue
		Me.Proses.TabIndex = 26
		Me.Proses.Visible = False
		'
		'LblProses
		'
		Me.LblProses.AutoSize = True
		Me.LblProses.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LblProses.Location = New System.Drawing.Point(93, 411)
		Me.LblProses.Name = "LblProses"
		Me.LblProses.Size = New System.Drawing.Size(194, 23)
		Me.LblProses.TabIndex = 27
		Me.LblProses.Text = "0% - Belum ada pekerjaan"
		Me.LblProses.Visible = False
		'
		'Loading
		'
		Me.Loading.Image = Global.Review.My.Resources.Resources.Load_Perfect
		Me.Loading.Location = New System.Drawing.Point(36, 362)
		Me.Loading.Name = "Loading"
		Me.Loading.Size = New System.Drawing.Size(52, 78)
		Me.Loading.TabIndex = 28
		Me.Loading.TabStop = False
		Me.Loading.Visible = False
		'
		'Button5
		'
		Me.Button5.BackColor = System.Drawing.Color.White
		Me.Button5.FlatAppearance.BorderSize = 0
		Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button5.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold)
		Me.Button5.Image = Global.Review.My.Resources.Resources.Sent_36px
		Me.Button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button5.Location = New System.Drawing.Point(439, 394)
		Me.Button5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(107, 40)
		Me.Button5.TabIndex = 25
		Me.Button5.Text = "Ekspor"
		Me.Button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button5.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.Microsoft_Excel_72px
		Me.PictureBox1.Location = New System.Drawing.Point(30, 82)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(72, 71)
		Me.PictureBox1.TabIndex = 2
		Me.PictureBox1.TabStop = False
		'
		'Export2Excel
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(587, 457)
		Me.Controls.Add(Me.Loading)
		Me.Controls.Add(Me.LblProses)
		Me.Controls.Add(Me.Button5)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.CheckedListBox1)
		Me.Controls.Add(Me.Proses)
		Me.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4)
		Me.MaximizeBox = False
		Me.Name = "Export2Excel"
		Me.Padding = New System.Windows.Forms.Padding(27, 88, 27, 29)
		Me.Resizable = False
		Me.Text = "Ekspor Data ke Excel"
		Me.TopMost = True
		CType(Me.Loading, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents CheckedListBox1 As CheckedListBox
	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Button5 As Button
	Friend WithEvents Proses As MetroFramework.Controls.MetroProgressBar
	Friend WithEvents LblProses As Label
	Friend WithEvents Loading As PictureBox
End Class
