<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pengolahan
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pengolahan))
		Me.Label16 = New System.Windows.Forms.Label()
		Me.ComboBox1 = New System.Windows.Forms.ComboBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.BackColor = System.Drawing.Color.White
		Me.Label16.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Location = New System.Drawing.Point(129, 60)
		Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(278, 46)
		Me.Label16.TabIndex = 20
		Me.Label16.Text = "Data mana yang ingin anda pratinjau " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "terlebih dahulu?"
		'
		'ComboBox1
		'
		Me.ComboBox1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ComboBox1.FormattingEnabled = True
		Me.ComboBox1.Items.AddRange(New Object() {"Biodata", "Pendaftaran", "Penilaian", "Pendaftaran Lengkap"})
		Me.ComboBox1.Location = New System.Drawing.Point(193, 116)
		Me.ComboBox1.Name = "ComboBox1"
		Me.ComboBox1.Size = New System.Drawing.Size(201, 31)
		Me.ComboBox1.TabIndex = 23
		Me.ComboBox1.Text = "Pilih Data"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.White
		Me.Label1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(136, 119)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(51, 23)
		Me.Label1.TabIndex = 24
		Me.Label1.Text = "Data :"
		'
		'Button3
		'
		Me.Button3.BackColor = System.Drawing.Color.White
		Me.Button3.FlatAppearance.BorderSize = 0
		Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button3.Font = New System.Drawing.Font("Quicksand", 9.75!, System.Drawing.FontStyle.Bold)
		Me.Button3.Image = Global.Review.My.Resources.Resources.Search_32px
		Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.Button3.Location = New System.Drawing.Point(286, 155)
		Me.Button3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(108, 40)
		Me.Button3.TabIndex = 22
		Me.Button3.Text = "Pratinjau"
		Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.Button3.UseVisualStyleBackColor = False
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Review.My.Resources.Resources.Print_96px
		Me.PictureBox1.Location = New System.Drawing.Point(23, 63)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
		Me.PictureBox1.TabIndex = 21
		Me.PictureBox1.TabStop = False
		'
		'Pengolahan
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(418, 213)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.ComboBox1)
		Me.Controls.Add(Me.Button3)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label16)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "Pengolahan"
		Me.Resizable = False
		Me.Text = "Cetak Data"
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label16 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button3 As Button
	Friend WithEvents ComboBox1 As ComboBox
	Friend WithEvents Label1 As Label
End Class
