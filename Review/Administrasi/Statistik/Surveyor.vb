Imports Npgsql
Imports System.IO
Imports System.Threading

Public Class Surveyor
	Dim TIMEOUT As Integer = Varlist.BATAL
	Private Async Sub Surveyor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If Not Await Refreshs() Then
			onError()
		End If
	End Sub

	Private Async Function Refreshs() As Task(Of Boolean)
		Dim hasil As Boolean = False
		PictureBox3.Visible = True
		PictureBox4.Visible = False

		Dim sumber As New CancellationTokenSource(TIMEOUT)
		Dim Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};", Varlist.Server, Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS))

		'Mulai Proses
		Try
			Await Koneksi.OpenAsync(sumber.Token)

			Dim adapter As New NpgsqlDataAdapter(String.Format("SELECT {0}ID_Kesan{0},{0}Nama{0},{0}Kelas{0},{0}Panggilan{0},{0}Umur{0},{0}Line{0},{0}NomorHP{0},{0}Email{0} FROM public.{0}Kesan{0};", Chr(34)), Koneksi)
			Dim ds As New DataSet

			Await Task.Run(Sub()
							   adapter.Fill(ds)
						   End Sub)

			ds.Tables(0).Columns(0).ColumnName = "ID"
			ds.Tables(0).Columns(6).ColumnName = "Nomor HP"

			Dim bs As New BindingSource
			bs.DataSource = ds
			bs.DataMember = ds.Tables(0).ToString()

			DataGridView1.ReadOnly = True
			DataGridView1.DataSource = bs
			DataGridView1.Update()

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

		PictureBox3.Visible = False
		PictureBox4.Visible = False
		Return hasil
	End Function

	Private Sub onError()
		PictureBox3.Visible = False
		PictureBox4.Visible = True
		Updater.Enabled = False
	End Sub

	Private Async Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
		If Not Await Refreshs() Then
			onError()
		Else
			Updater.Enabled = True
		End If
	End Sub

	Private Async Sub Updater_Tick(sender As Object, e As EventArgs) Handles Updater.Tick
		If Not Await Refreshs() Then
			onError()
		End If
	End Sub
End Class