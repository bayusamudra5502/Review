Imports System.Threading
Imports System.IO
Imports Npgsql


Public Class Export2Excel
	Dim TIMEOUT As Integer = Varlist.BATAL
	Const TOTALPROSES As Integer = 13

	Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
		CheckedListBox1.Enabled = True
		If ComboBox1.Text = "Tabel Pendaftaran" Then
			CheckedListBox1.Items.Clear()
			CheckedListBox1.Items.Add("ID_Pendaftaran")
			CheckedListBox1.Items.Add("Nama")
			CheckedListBox1.Items.Add("Kelompok")
			CheckedListBox1.Items.Add("Alasan")
			CheckedListBox1.Items.Add("Harapan")
			CheckedListBox1.Items.Add("Divisi")
		Else
			CheckedListBox1.Items.Clear()
			CheckedListBox1.Items.Add("ID_Kesan")
			CheckedListBox1.Items.Add("Nama")
			CheckedListBox1.Items.Add("Panggilan")
			CheckedListBox1.Items.Add("Umur")
			CheckedListBox1.Items.Add("Line")
			CheckedListBox1.Items.Add("NomorHP")
			CheckedListBox1.Items.Add("Email")
			CheckedListBox1.Items.Add("Penilaian")
			CheckedListBox1.Items.Add("Kesan")
			CheckedListBox1.Items.Add("Gabung")
			CheckedListBox1.Items.Add("Kelas")
		End If
	End Sub

	Private Async Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Proses.Value = 0
		Proses.Update()
		LblProses.Text = "0% - Tidak ada pekerjaan"

		If ComboBox1.Text <> "Pilih Tabel" Then
			If CheckedListBox1.CheckedItems.Count = 0 Then
				MsgBox("Anda setidaknya harus memilih satu kolom pada tabel.", vbExclamation + vbOKOnly, "Sistem")
			Else
				Dim dialog As New SaveFileDialog()
				dialog.Filter = "Berkas Excel |*.xlsx"
				dialog.Title = "Ekspor Data"
				dialog.ShowDialog() 'Buka Dialog
				Dim path As String = dialog.FileName


				If Not String.IsNullOrWhiteSpace(path) Then
					Button5.Visible = False
					Proses.Visible = True
					LblProses.Visible = True
					Loading.Visible = True

					'Tahap 1 - Memulai Pembuatan Dataset
					updater("Memperesiapkan pembuatan DataSet..", 1)
					Dim ds As DataSet = Await getDataSet(selectCommandBuilder())
					If ds IsNot Nothing Then
						updater("DataSet berhasil dibuat.. (OK)", 11)

						updater("Mempersiapkan proses ekspor Dataset..", 12)
						Dim judul As New List(Of String)
						Dim data As New ExportDatasetToExcel(ds)
						judul.Add("Laporan " & ComboBox1.Text)

						updater("Memulai proses ekspor..", 12)
						Dim hasil As Boolean = Await Task.Run(Function() As Boolean
																  Return data.Simpan(path, judul)
															  End Function)

						If hasil Then
							updater("Data berhasil diekspor.. (OK)", 13)
							MsgBox("Data berhasil diekspor.", vbInformation + vbOKOnly, "Informasi")
						Else
							MsgBox("Terjadi kesalahan. Proses Ekspor gagal. Periksa File log!", vbCritical + vbOKOnly, "Kesalahan Sistem")
						End If
					Else
						MsgBox("Terjadi kesalahan. Dataset kosong. Periksa File log!", vbCritical + vbOKOnly, "Kesalahan Sistem")
					End If
				Else
					MsgBox("Anda harus memilih lokasi penyimpanan file.", vbExclamation + vbOKOnly, "Sistem")
				End If
			End If
		Else
			MsgBox("Anda harus memilih tabel yang akan diekspor.", vbExclamation + vbOKOnly, "Sistem")
		End If

		Button5.Visible = True
		Proses.Visible = False
		LblProses.Visible = False
		Loading.Visible = False
	End Sub

	Private Function selectCommandBuilder() As String
		'Tahap 2 - Membuat Perintah "Select *" untuk database
		updater("Membuat perintah 'Select *' untuk database..", 2)
		Dim format As String = "SELECT {1} FROM public.{0}{2}{0};"
		Dim tabel As String = ""
		Dim nama As String = ""

		For Each str As String In CheckedListBox1.CheckedItems
			tabel &= Chr(34) & str & Chr(34) & ","
		Next

		tabel = tabel.Remove(tabel.Length - 1)

		If ComboBox1.Text = "Tabel Pendaftaran" Then
			nama = "Daftar"
		Else
			nama = "Kesan"
		End If

		'Tahap 3 - Selesai
		updater("Selesai membuat perintah.", 3)
		Return String.Format(format, Chr(34), tabel, nama)
	End Function

	Private Async Function getDataSet(ByVal SelectCommand As String) As Task(Of DataSet)
		'Tahap 4 - Memulai Pembuatan Dataset
		updater("Memulai pembuatan DataSet..", 4)
		Dim hasil As DataSet = Nothing

		'Tahap 5 - Membuat Timer Penutup
		updater("Memulai pembuatan timer pembatal proses..", 5)
		Dim sumber As New CancellationTokenSource(TIMEOUT)

		'Tahap 6 - Membuat koneksi
		updater("Membuat koneksi", 6)
		Dim Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};", Varlist.Server, Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS))

		'Mulai Proses
		Try
			updater("Menjalin sambungan terhadap Database. Server : " & Varlist.Server, 7)
			Await Koneksi.OpenAsync(sumber.Token)
			updater("Sambungan terjalin.. (OK)", 8)

			updater("Membuat Data Adapter", 9)
			Dim Adapter As New NpgsqlDataAdapter(SelectCommand, Koneksi)
			hasil = New DataSet

			updater("Menyalin data dari server...", 10)
			Await Task.Run(Sub()
							   Adapter.Fill(hasil)
						   End Sub, sumber.Token)

		Catch t As TaskCanceledException
			MsgBox(String.Format("Proses login dibatalkan karena waktu eksekusi telah melebihi {0} detik.", TIMEOUT / 1000), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Kesalahan")

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
			Koneksi.Close()
		End Try

		Return hasil
	End Function

	Private Sub updater(ByVal msg As String, ByVal sesi As Integer)
		LblProses.Text = Format((sesi / TOTALPROSES) * 100, "0.00") & "% - " & msg
		Console.WriteLine(Format((sesi / TOTALPROSES) * 100, "0.00") & "% - " & msg)
		Proses.Value = sesi
		Proses.Update()
	End Sub
End Class