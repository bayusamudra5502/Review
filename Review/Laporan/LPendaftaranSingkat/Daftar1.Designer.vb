<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Daftar1
	Inherits System.Windows.Forms.Form

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
		Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Daftar1))
		Me.DaftarBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.PATCHDataSet = New Review.PATCHDataSet()
		Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MuatUlangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DaftarTableAdapter = New Review.PATCHDataSetTableAdapters.DaftarTableAdapter()
		CType(Me.DaftarBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PATCHDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'DaftarBindingSource
		'
		Me.DaftarBindingSource.DataMember = "Daftar"
		Me.DaftarBindingSource.DataSource = Me.PATCHDataSet
		'
		'PATCHDataSet
		'
		Me.PATCHDataSet.DataSetName = "PATCHDataSet"
		Me.PATCHDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'ReportViewer1
		'
		Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
		ReportDataSource1.Name = "DataSet1"
		ReportDataSource1.Value = Me.DaftarBindingSource
		Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
		Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Review.rptDaftar1.rdlc"
		Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
		Me.ReportViewer1.Name = "ReportViewer1"
		Me.ReportViewer1.ServerReport.BearerToken = Nothing
		Me.ReportViewer1.Size = New System.Drawing.Size(560, 387)
		Me.ReportViewer1.TabIndex = 0
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(560, 24)
		Me.MenuStrip1.TabIndex = 1
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'FileToolStripMenuItem
		'
		Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KeluarToolStripMenuItem})
		Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
		Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
		Me.FileToolStripMenuItem.Text = "Berkas"
		'
		'KeluarToolStripMenuItem
		'
		Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
		Me.KeluarToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
		Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
		Me.KeluarToolStripMenuItem.Text = "Keluar"
		'
		'DataToolStripMenuItem
		'
		Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MuatUlangToolStripMenuItem})
		Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
		Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
		Me.DataToolStripMenuItem.Text = "Data"
		'
		'MuatUlangToolStripMenuItem
		'
		Me.MuatUlangToolStripMenuItem.Name = "MuatUlangToolStripMenuItem"
		Me.MuatUlangToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.MuatUlangToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
		Me.MuatUlangToolStripMenuItem.Text = "Muat Ulang"
		'
		'DaftarTableAdapter
		'
		Me.DaftarTableAdapter.ClearBeforeFill = True
		'
		'Daftar1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(560, 411)
		Me.Controls.Add(Me.ReportViewer1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "Daftar1"
		Me.Text = "Laporan Pendaftaran"
		Me.TopMost = True
		CType(Me.DaftarBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PATCHDataSet, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DaftarBindingSource As BindingSource
	Friend WithEvents PATCHDataSet As PATCHDataSet
	Friend WithEvents DaftarTableAdapter As PATCHDataSetTableAdapters.DaftarTableAdapter
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents MuatUlangToolStripMenuItem As ToolStripMenuItem
End Class
