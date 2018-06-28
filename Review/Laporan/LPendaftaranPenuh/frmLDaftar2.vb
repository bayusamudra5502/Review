Public Class frmLDaftar2
	Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
		Close()
	End Sub

	Private Sub frmLDaftar2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'PATCHDataSet.Daftar' table. You can move, or remove it, as needed.
		Me.DaftarTableAdapter.Fill(Me.PATCHDataSet.Daftar)
		Me.ReportViewer1.RefreshReport()
	End Sub

	Private Sub MuatUlangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MuatUlangToolStripMenuItem.Click
		Me.DaftarTableAdapter.Fill(Me.PATCHDataSet.Daftar)
		Me.ReportViewer1.RefreshReport()
	End Sub
End Class