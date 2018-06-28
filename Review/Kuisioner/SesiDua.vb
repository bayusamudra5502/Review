'*****************************************************************************
' Nama File : SesiDua.vb
' Deskripsi : Form Penilaian PATCH
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 14 Juni 2018
' Tanggal Edit : 19 Juni 2018
' Copyright PATCH (c) 2018
' ****************************************************************************

Public Class SesiDua
	Private Sub MetroTrackBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles MetroTrackBar1.Scroll
		Label4.Text = "Penilaian Anda: " & MetroTrackBar1.Value & "/10"
		If MetroTrackBar1.Value <= 3 Then
			PictureBox1.Image = My.Resources.Sad_72px
		ElseIf MetroTrackBar1.Value >= 4 And MetroTrackBar1.Value <= 6 Then
			PictureBox1.Image = My.Resources.Boring_72px
		Else
			PictureBox1.Image = My.Resources.Happy_72px
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If MsgBox(String.Format("Apakah anda yakin memberikan nilai {0} dari 10 untuk PATCH?",
								MetroTrackBar1.Value), vbExclamation + vbYesNo, "Perhatian!") = vbYes Then
			Varlist.nilai = MetroTrackBar1.Value
			Me.Hide()
			Kesan.Show()
		End If
	End Sub

	Private Sub SesiDua_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If Varlist.sesi >= 2 Then
			MetroTrackBar1.Value = Varlist.nilai

			Label4.Text = "Penilaian Anda: " & MetroTrackBar1.Value & "/10"
			If MetroTrackBar1.Value <= 3 Then
				PictureBox1.Image = My.Resources.Sad_72px
			ElseIf MetroTrackBar1.Value >= 4 And MetroTrackBar1.Value <= 6 Then
				PictureBox1.Image = My.Resources.Boring_72px
			Else
				PictureBox1.Image = My.Resources.Happy_72px
			End If
		Else
			Varlist.sesi = 2
		End If
	End Sub

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Hide()
		SesiSatu.Show()
	End Sub
End Class