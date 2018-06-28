Public Class Penutup
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Varlist.Refresh = True
		Varlist.clear()
		FormAwal.Close()
		Kesan.Close()
		SesiDua.Close()
		Pentup2.Close()
		SesiSatu.Close()
		FormAwal.Show()
		Varlist.Refresh = False
		Close()
	End Sub

	Private Sub Penutup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Label4.Text = Varlist.LinePATCH
		Label5.Text = Varlist.Instagram
		Label6.Text = Varlist.Web
	End Sub
End Class