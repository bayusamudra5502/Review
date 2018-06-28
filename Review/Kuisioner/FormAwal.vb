Imports System.ComponentModel

Public Class FormAwal
	Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
		Button1.BackColor = Color.Gray
	End Sub

	Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
		Button1.BackColor = Color.White
	End Sub

	Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles Button1.Leave
		Button1.BackColor = Color.White
	End Sub

	Private Sub FormAwal_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If Not Varlist.Refresh Then
			e.Cancel = True
			MsgBox("Anda tidak memiliki akses untuk menutup form ini.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Akses Ditolak")
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Hide()
		SesiSatu.Show()
	End Sub

End Class
