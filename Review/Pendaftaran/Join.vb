Imports System.ComponentModel
Imports System.IO
Imports System.Threading
Imports Npgsql

Public Class Join
	Dim loads As Boolean = False
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		If TextBox1.Text <> "Tulis disini..." Then
			Label5.Text = "Sisa karakter : " & (600 - TextBox1.Text.Length) & " Karakter"
		Else
			Label5.Text = "Sisa karakter : 600 Karakter"
		End If
	End Sub
	Private Sub TextBox1_GotFocus(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
		If TextBox1.Text = "Tulis disini..." Then
			TextBox1.Text = ""
		End If
	End Sub

	Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
		If String.IsNullOrWhiteSpace(TextBox1.Text) Then
			TextBox1.Text = "Tulis disini..."
		End If
	End Sub

	Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
		If TextBox2.Text <> "Tulis disini..." Then
			Label6.Text = "Sisa karakter : " & (600 - TextBox2.Text.Length) & " Karakter"
		Else
			Label6.Text = "Sisa karakter : 600 Karakter"
		End If
	End Sub
	Private Sub TextBox2_GotFocus(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
		If TextBox2.Text = "Tulis disini..." Then
			TextBox2.Text = ""
		End If
	End Sub

	Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
		If String.IsNullOrWhiteSpace(TextBox2.Text) Then
			TextBox2.Text = "Tulis disini..."
		End If
	End Sub

	Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		If MsgBox("Apakah anda yakin akan menyimpan data yang telah anda isi?",
				  vbExclamation + vbYesNo, "Peringatan!") = vbYes Then

			Button1.Visible = False
			PictureBox2.Visible = True
			loads = True

			If Not Await simpan() Then
				loads = False
				Button1.Visible = True
				PictureBox2.Visible = False
			Else
				loads = False
				Me.Hide()
				Pentup2.Show()
			End If
		End If
	End Sub

	Private Async Function simpan() As Task(Of Boolean)
		'Indikator sukses 
		Dim sukses As Boolean = False

		'Pembatal
		Dim sumber As New CancellationTokenSource(Varlist.BATAL)
		Dim stringkoneksi As String = String.Format("Host={0};Database={1};Username={2};Password={3};",
													Varlist.Server, Varlist.DB_NAME, Varlist.DB_USER,
													Varlist.DB_PASS)

		Dim koneksi As New NpgsqlConnection(stringkoneksi)
		'Mulai menyimpan
		Try
			Await koneksi.OpenAsync(sumber.Token)

			Dim cmd As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Daftar{0}" &
				" ({0}Nama{0},{0}Kelompok{0},{0}Alasan{0},{0}Harapan{0},{0}Divisi{0})" &
				" VALUES ('{1}','{2}','{3}','{4}','{5}')", Chr(34),
						Varlist.Nama, Varlist.Kelas, TextBox1.Text, TextBox2.Text, ComboBox1.Text), koneksi)

			Await cmd.ExecuteNonQueryAsync()
			sukses = True
		Catch cancel As TaskCanceledException
			MsgBox("Data tidak dapat disimpan karena waktu penyimpanan telah habis.", vbCritical + vbOKOnly, "Kesalahan Penyimpanan")
		Catch ex As Exception
			Try
				Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
				Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
				Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

				MsgBox("Terjadi masalah dengan sambungan server. Lihat file " & Alamat, vbCritical + vbOKOnly, "Kesalahan Server")
				File.WriteAllText(Alamat, ex.ToString())

			Catch fileerror As IOException
				MsgBox("Terjadi masalah dengan sambungan server serta penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan Server")
			End Try
		Finally
			koneksi.Close()
		End Try

		Return sukses
	End Function

	Private Sub Join_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If loads Then
			MsgBox("Anda tidak bisa menutup aplikasi ini saat sedang proses penyimpanan.", vbExclamation + vbOKOnly, "Peringatan")
			e.Cancel = True
		End If
	End Sub
End Class