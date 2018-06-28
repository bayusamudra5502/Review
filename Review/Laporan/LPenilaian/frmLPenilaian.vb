Imports Microsoft.Reporting.WinForms

Public Class frmLPenilaian
	Private Sub frmLPenilaian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

	Private Sub ReportViewer1_PrintingBegin(sender As Object, e As ReportPrintEventArgs) Handles ReportViewer1.PrintingBegin

	End Sub
End Class