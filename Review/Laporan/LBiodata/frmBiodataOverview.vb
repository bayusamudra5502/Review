Public Class frmBiodataOverview
	Private Sub frmBiodataOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		'TODO: This line of code loads data into the 'PATCHDataSetKesan.Kesan' table. You can move, or remove it, as needed.
		Me.KesanTableAdapter.Fill(Me.PATCHDataSetKesan.Kesan)
		Me.ReportViewer1.RefreshReport()
	End Sub

	Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
		Me.KesanTableAdapter.Fill(Me.PATCHDataSetKesan.Kesan)
		Me.ReportViewer1.RefreshReport()
	End Sub

	Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
		Close()
	End Sub
End Class