Public Class Pentup2
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Varlist.Refresh = True
		Varlist.clear()
		Join.Close()
		FormAwal.Close()
		Kesan.Close()
		SesiDua.Close()
		Penutup.Close()
		SesiSatu.Close()
		FormAwal.Show()
		Varlist.Refresh = False
		Close()
	End Sub

	Private Sub Pentup2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Label4.Text = Varlist.LinePATCH
		Label5.Text = Varlist.Instagram
		Label6.Text = Varlist.Web
	End Sub
End Class