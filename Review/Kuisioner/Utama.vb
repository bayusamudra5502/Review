Imports System.ComponentModel

Public Class Utama
	Private Sub Utama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		FormAwal.Show()
		FormAwal.Focus()
	End Sub

	Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
		End
	End Sub

	Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
		Verify.Show()
		Penutup.Hide()
		Pentup2.Hide()
		FormAwal.Hide()
	End Sub

	Private Sub Utama_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		e.Cancel = True
		FormAwal.Hide()
		MsgBox("Anda tidak memiliki akses untuk menutup program ini.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Akses Ditolak")
		FormAwal.Show()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Label1.Text = "Pukul " & Now.ToString("hh.mm.ss")
	End Sub
End Class