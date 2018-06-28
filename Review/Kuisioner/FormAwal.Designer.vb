<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAwal
	'Inherits System.Windows.Forms.Form
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAwal))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(62, 165)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(249, 23)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Bagaimana nih tadi lihat-lihatnya?"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(21, 196)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(334, 23)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Apakah anda ingin berbagi pengalaman anda "
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(34, 219)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(306, 23)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "kepada kami dengan mengisi kuisioner ini?"
		'
		'Button1
		'
		Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
		Me.Button1.FlatAppearance.BorderSize = 0
		Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.Button1.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Button1.Location = New System.Drawing.Point(144, 254)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(75, 43)
		Me.Button1.TabIndex = 4
		Me.Button1.Text = "Ya"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(133, 58)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(99, 97)
		Me.PictureBox1.TabIndex = 3
		Me.PictureBox1.TabStop = False
		'
		'FormAwal
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle
		Me.ClientSize = New System.Drawing.Size(377, 315)
		Me.ControlBox = False
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Font = New System.Drawing.Font("Quicksand", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "FormAwal"
		Me.Padding = New System.Windows.Forms.Padding(30, 106, 30, 35)
		Me.Resizable = False
		Me.Style = MetroFramework.MetroColorStyle.Purple
		Me.Text = "Review"
		Me.TopMost = True
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Button1 As Button
End Class
