'=======================================================================================
' Nama File : Admin.vb
' Deskripsi : Kode Form Administrasi
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 21 Juni 2018
' Tanggal Edit : 21 Juni 2018
' Copyright PATCH (c) 2018
'========================================================================================

Imports Npgsql
Imports System.IO
Imports System.Threading
Imports LiveCharts
Imports LiveCharts.Wpf

Public Class Admin
	Dim [Error] As Boolean = False
	Const TIMEOUT As Integer = 5000

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		If MsgBox("Apakah anda yakin ingin mengakhiri sesi ini?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Pengumuman") = MsgBoxResult.Yes Then
			End
		End If
	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Close()
		FormAwal.Show()
	End Sub

	Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
		Label15.Text = String.Format("Waktu : {0}", Now.ToString("hh.mm.ss"))
	End Sub

	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		Export2Excel.Show()
	End Sub

	Private Async Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
		PictureBox4.Visible = False
		Label21.Visible = True
		Label21.Location = New Point(719, 593)
		Label21.Text = "Sedang memperbaharui data..."
		PictureBox3.Visible = True

		If Await Updates() Then
			PictureBox3.Visible = False
			Label21.Visible = False
		Else
			PictureBox3.Visible = False
			onError()
		End If
	End Sub

	Private Async Function Updates() As Task(Of Boolean)
		Dim hasil As Boolean = False
		Dim sumber As New CancellationTokenSource(TIMEOUT)

		Dim Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};", Varlist.Server, Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS))

		'Mulai Proses
		Try
			Await Koneksi.OpenAsync(sumber.Token)

			'Ringkasan
			Dim cmdjmlsurvey As New NpgsqlCommand(
				String.Format("SELECT COUNT({0}ID_Kesan{0}) FROM public.{0}Kesan{0};", Chr(34)), Koneksi)

			Dim cmdjmldaftar As New NpgsqlCommand(
				String.Format("SELECT COUNT({0}ID_Pendaftaran{0}) FROM public.{0}Daftar{0};", Chr(34)),
																								Koneksi)

			Dim cmdratasurvey As New NpgsqlCommand(
				String.Format("SELECT AVG({0}Penilaian{0}) FROM public.{0}Kesan{0};", Chr(34)), Koneksi)

			LblIkutSurvey.Text = String.Format(": {0} Orang",
											Convert.ToInt32(Await _
											cmdjmlsurvey.ExecuteScalarAsync(sumber.Token)))

			LblIkutPatch.Text = String.Format(": {0} Orang",
											Convert.ToInt32(Await _
															cmdjmldaftar.ExecuteScalarAsync(sumber.Token)))

			Dim x As Object = Await cmdratasurvey.ExecuteScalarAsync(sumber.Token)
			If Not IsDBNull(x) Then
				Dim nilai As Single = Convert.ToSingle(x)
				LblRating.Text = String.Format(": {0} dari 10", Format(nilai, "0.00"))
				SolidGauge1.Value = Math.Round(nilai, 2)
				SolidGauge1.Update()

				'Biar nyantai
				cmdjmlsurvey.Dispose()
				cmdjmldaftar.Dispose()
				cmdratasurvey.Dispose()

				'Graph Pie
				Dim data As New SeriesCollection
				Dim label As Func(Of ChartPoint, String) = Function(chtpoint) String.
					Format(": {0} Orang", chtpoint.Y)

				Dim conf As Boolean() = New Boolean(10) {}

				For i As Integer = 0 To 10
					Dim cmdnilaisurvey As New NpgsqlCommand(String.Format("SELECT COUNT({0}Penilaian{0}) FROM public.{0}Kesan{0} WHERE {0}Penilaian{0} = {1};", Chr(34), i), Koneksi)
					Dim jml As Integer = Convert.ToInt32(Await cmdnilaisurvey.ExecuteScalarAsync(sumber.Token))

					If jml > 0 Then
						data.Add(New PieSeries With {
										.Title = i.ToString,
										.Values = New ChartValues(Of Integer) From {jml},
										.DataLabels = False,
										.LabelPoint = label
									})
					End If
				Next

				'Graph Batang
				Dim isi As String() = New String() {
					"Desain",
					"Media",
					"Programming",
					"Belum ada jawaban"}

				Dim tampung As New SeriesCollection
				For Each i As String In isi
					Dim cmdnilaisurvey As New NpgsqlCommand(String.Format("SELECT COUNT({0}Divisi{0}) FROM public.{0}Daftar{0} WHERE {0}Divisi{0} = '{1}';", Chr(34), i), Koneksi)
					Dim jml As Integer = Convert.ToInt32(Await cmdnilaisurvey.ExecuteScalarAsync(sumber.Token))

					If jml > 0 Then
						tampung.Add(New ColumnSeries With {
									.Title = i,
									.Values = New ChartValues(Of Integer) From {jml}
								})
					End If
				Next

				CartesianChart2.Series = tampung
				PieChart1.Series = data
			Else 'KLO BLOM ADA YG NGISI KUISIONER
				LblRating.Text = String.Format(": {0} dari 10", Format(0, "0.00"))
				Dim data As New SeriesCollection
				Dim label As Func(Of ChartPoint, String) = Function(chtpoint) String.
					Format("{0} ({1:P})", chtpoint.Y, chtpoint.Participation)
				PieChart1.Series = data

				'Graph Batang
				Dim isi As String() = New String() {
					"Desain",
					"Media",
					"Programming",
					"Belum ada jawaban"}

				Dim tampung As New SeriesCollection
				For Each i As String In isi
					tampung.Add(New ColumnSeries With {
						.Title = i,
						.Values = New ChartValues(Of Integer) From {0}
						})
				Next
				CartesianChart2.Series = tampung
			End If

			hasil = True
		Catch t As TaskCanceledException
			PictureBox3.Visible = False
			MsgBox(String.Format("Proses pembaharuan dibatalkan karena waktu eksekusi telah melebihi {0} detik.", TIMEOUT / 1000), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Kesalahan")

		Catch ex As Exception
			PictureBox3.Visible = False
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

	Private Sub onError()
		PictureBox4.Visible = True
		Label21.Text = "Terjadi kesalahan saat sinkronisasi. Lihat log. Klik untuk mengupdate."
		Label21.Location = New Point(459, 593)
		Updater.Enabled = False
		[Error] = True
	End Sub

	Private Async Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		PictureBox3.Image = My.Resources._32
		With SolidGauge1
			.To = 10
			.From = 0
			.ToColor = System.Windows.Media.Color.FromRgb(&H48, &HC9, &HB0)
			.FromColor = System.Windows.Media.Color.FromRgb(&HEC, &H70, &H63) '#EC7063
		End With
		Label21.Visible = True
		Label21.Location = New Point(719, 593)
		PictureBox4.Visible = False
		Label21.Text = "Sedang memperbaharui data..."
		PictureBox3.Visible = True

		If Await Updates() Then
			PictureBox3.Visible = False
			Label21.Visible = False
		Else
			PictureBox3.Visible = False
			onError()
		End If

		CartesianChart2.AxisX.Add(New Axis With {
					.Title = "Divisi",
					.Labels = {"Divisi"},
					.ShowLabels = False
				})

		CartesianChart2.AxisY.Add(New Axis With {
							.Title = "Jumlah Pendaftar"
						})
	End Sub

	Private Async Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
		If [Error] Then
			Label21.Location = New Point(719, 593)

			PictureBox4.Visible = False
			Label21.Text = "Sedang memperbaharui data..."
			PictureBox3.Visible = True

			If Await Updates() Then
				PictureBox3.Visible = False
				Label21.Visible = False
			Else
				PictureBox3.Visible = False
				onError()
			End If
			Updater.Enabled = True
		End If
	End Sub

	Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
		Surveyor.Show()
	End Sub

	Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
		Penilaian.Show()
	End Sub

	Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
		Pengikut.Show()
	End Sub

	Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		Hapus.Show()
	End Sub

	Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
		Pengolahan.Show()
	End Sub

	Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
		SettingVerify2.Show()
		Me.Hide()
	End Sub

	Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

	End Sub
End Class