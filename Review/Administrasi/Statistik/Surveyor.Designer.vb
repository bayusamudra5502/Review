﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Surveyor
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
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.PictureBox3 = New System.Windows.Forms.PictureBox()
		Me.PictureBox4 = New System.Windows.Forms.PictureBox()
		Me.Tips = New System.Windows.Forms.ToolTip(Me.components)
		Me.Updater = New System.Windows.Forms.Timer(Me.components)
		Me.Err = New System.Windows.Forms.ToolTip(Me.components)
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'DataGridView1
		'
		Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
		Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
		Me.DataGridView1.Location = New System.Drawing.Point(20, 60)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.Size = New System.Drawing.Size(613, 372)
		Me.DataGridView1.TabIndex = 0
		'
		'PictureBox3
		'
		Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox3.Image = Global.Review.My.Resources.Resources._32
		Me.PictureBox3.Location = New System.Drawing.Point(575, 22)
		Me.PictureBox3.Name = "PictureBox3"
		Me.PictureBox3.Size = New System.Drawing.Size(55, 32)
		Me.PictureBox3.TabIndex = 25
		Me.PictureBox3.TabStop = False
		Me.Tips.SetToolTip(Me.PictureBox3, "Sedang memperbaharui data..")
		Me.PictureBox3.Visible = False
		'
		'PictureBox4
		'
		Me.PictureBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.PictureBox4.Image = Global.Review.My.Resources.Resources.Close_Window_32px
		Me.PictureBox4.Location = New System.Drawing.Point(598, 22)
		Me.PictureBox4.Name = "PictureBox4"
		Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
		Me.PictureBox4.TabIndex = 27
		Me.PictureBox4.TabStop = False
		Me.Err.SetToolTip(Me.PictureBox4, "Terjadi kesalahan saat memperbaharui data. Klik untuk memperbaharui ulang.")
		Me.PictureBox4.Visible = False
		'
		'Tips
		'
		Me.Tips.BackColor = System.Drawing.Color.White
		Me.Tips.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
		Me.Tips.ToolTipTitle = "Pemberitahuan"
		'
		'Updater
		'
		Me.Updater.Enabled = True
		Me.Updater.Interval = 30000
		'
		'Err
		'
		Me.Err.BackColor = System.Drawing.Color.White
		Me.Err.ToolTipIcon = System.Windows.Forms.ToolTipIcon.[Error]
		Me.Err.ToolTipTitle = "Kesalahan"
		'
		'Surveyor
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(653, 452)
		Me.Controls.Add(Me.PictureBox4)
		Me.Controls.Add(Me.PictureBox3)
		Me.Controls.Add(Me.DataGridView1)
		Me.Name = "Surveyor"
		Me.Text = "Data Surveyor"
		Me.TopMost = True
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents DataGridView1 As DataGridView
	Friend WithEvents PictureBox3 As PictureBox
	Friend WithEvents PictureBox4 As PictureBox
	Friend WithEvents Tips As ToolTip
	Friend WithEvents Updater As Timer
	Friend WithEvents Err As ToolTip
End Class
