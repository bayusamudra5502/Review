Imports System.IO
Imports Npgsql
Imports System.Threading
Imports System.Configuration

Public Class Hapus
	Private ReadOnly TIMEOUT As Integer = Varlist.BATAL
	Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		If MsgBox("Apakah anda yakin akan menghapus tabel ini? Segala perubahan tidak dapat dikembalikan.", vbYesNo + vbExclamation, "Peringatan") = vbYes Then
			Button3.Visible = False
			PictureBox2.Visible = True

			Dim masuk As New Login(Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS, Varlist.Server)
			Dim tugas As Task(Of Boolean) = masuk.login(ConfigurationManager.AppSettings("UserID"), Password.Text, 38)
			Dim hasil As Boolean = Await tugas

			If hasil Then
				Dim sumber As New CancellationTokenSource(TIMEOUT)

				Dim Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};", Varlist.Server, Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS))

				'Mulai Proses
				Try
					Await Koneksi.OpenAsync(sumber.Token)

					'Ringkasan
					Dim hapusKesan As New NpgsqlCommand(
					String.Format("DELETE FROM public.{0}Kesan{0};", Chr(34)), Koneksi)

					Dim hapusDaftar As New NpgsqlCommand(
					String.Format("DELETE FROM public.{0}Daftar{0};", Chr(34)), Koneksi)

					If CheckBox1.Checked Then
						Await hapusKesan.ExecuteNonQueryAsync
					End If

					If CheckBox2.Checked Then
						Await hapusDaftar.ExecuteNonQueryAsync
					End If

					MsgBox("Penghapusan berhasil.", vbInformation + vbOKOnly, "Informasi")
				Catch t As TaskCanceledException
					MsgBox(String.Format("Proses penghapusan dibatalkan karena waktu eksekusi telah melebihi {0} detik.", TIMEOUT / 1000), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Kesalahan")

				Catch ex As Exception
					Try
						Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
						Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
						Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

						MsgBox("Terjadi masalah dengan server. Lihat file " & Alamat, vbCritical + vbOKOnly, "Kesalahan Server")
						File.WriteAllText(Alamat, ex.ToString())

					Catch fileerror As IOException
						MsgBox("Terjadi masalah dengan server serta penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan Server")

					End Try
				Finally
					Koneksi.Close()
				End Try
			Else
				MsgBox("Anda tidak memiliki akses untuk melakukan tindakan ini.", vbCritical + vbOKOnly, "Akses Ditolak")
			End If
		End If
		Button3.Visible = True
		PictureBox2.Visible = False
	End Sub
End Class