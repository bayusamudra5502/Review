<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBiodataOverview
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmBiodataOverview))
		Me.KesanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
		Me.PATCHDataSetKesan = New Review.PATCHDataSetKesan()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.DataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
		Me.KesanTableAdapter = New Review.PATCHDataSetKesanTableAdapters.KesanTableAdapter()
		CType(Me.KesanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.PATCHDataSetKesan, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'KesanBindingSource
		'
		Me.KesanBindingSource.DataMember = "Kesan"
		Me.KesanBindingSource.DataSource = Me.PATCHDataSetKesan
		'
		'PATCHDataSetKesan
		'
		Me.PATCHDataSetKesan.DataSetName = "PATCHDataSetKesan"
		Me.PATCHDataSetKesan.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.DataToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(412, 24)
		Me.MenuStrip1.TabIndex = 0
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
		Me.DataToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem})
		Me.DataToolStripMenuItem.Name = "DataToolStripMenuItem"
		Me.DataToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
		Me.DataToolStripMenuItem.Text = "Data"
		'
		'RefreshToolStripMenuItem
		'
		Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
		Me.RefreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
		Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
		Me.RefreshToolStripMenuItem.Text = "Muat Ulang"
		'
		'ReportViewer1
		'
		Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
		ReportDataSource1.Name = "DataSet1"
		ReportDataSource1.Value = Me.KesanBindingSource
		Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
		Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Review.rptBiodata.rdlc"
		Me.ReportViewer1.Location = New System.Drawing.Point(0, 24)
		Me.ReportViewer1.Name = "ReportViewer1"
		Me.ReportViewer1.ServerReport.BearerToken = Nothing
		Me.ReportViewer1.Size = New System.Drawing.Size(412, 300)
		Me.ReportViewer1.TabIndex = 1
		'
		'KesanTableAdapter
		'
		Me.KesanTableAdapter.ClearBeforeFill = True
		'
		'frmBiodataOverview
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(412, 324)
		Me.Controls.Add(Me.ReportViewer1)
		Me.Controls.Add(Me.MenuStrip1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "frmBiodataOverview"
		Me.Text = "Laporan Biodata"
		Me.TopMost = True
		CType(Me.KesanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.PATCHDataSetKesan, System.ComponentModel.ISupportInitialize).EndInit()
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
	Friend WithEvents KesanBindingSource As BindingSource
	Friend WithEvents PATCHDataSetKesan As PATCHDataSetKesan
	Friend WithEvents KesanTableAdapter As PATCHDataSetKesanTableAdapters.KesanTableAdapter
End Class
