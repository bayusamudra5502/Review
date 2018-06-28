'*****************************************************************************
' Nama File : Kesan.vb
' Deskripsi : Kode Form Kesan
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 16 Juni 2018
' Tanggal Edit : 19 Juni 2018
' Copyright PATCH (c) 2018
' ****************************************************************************

Imports Npgsql
Imports System.Threading
Imports System.IO

Public Class Kesan
	Dim proses As Boolean = False
	Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
		If TextBox1.Text <> "Tulis disini..." Then
			Label2.Text = "Sisa karakter : " & (600 - TextBox1.Text.Length) & " Karakter"
		Else
			Label2.Text = "Sisa karakter : 600 Karakter"
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

	Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Varlist.Kesan = TextBox1.Text

		If MsgBox("Apakah anda yakin untuk menyimpan data yang telah dimasukan?",
				  vbExclamation + vbYesNo, "Peringatan!") = MsgBoxResult.Yes Then

			Button1.Visible = False
			Button2.Visible = False
			PictureBox2.Visible = True
			proses = True
			If RadioButton1.Checked = True Then
				Varlist.Ikut = 2
				If Await Simpan() Then
					Me.Hide()
					Join.Show()
				Else
					Button1.Visible = True
					Button2.Visible = True
					PictureBox2.Visible = False
				End If
			ElseIf RadioButton2.Checked = True Then
				Varlist.Ikut = 1
				If Await Simpan() Then
					Me.Hide()
					Penutup.Show()
				Else
					Button1.Visible = True
					Button2.Visible = True
					PictureBox2.Visible = False
				End If
			ElseIf RadioButton3.Checked = True Then
				Varlist.Ikut = 0
				If Await Simpan() Then
					Me.Hide()
					Penutup.Show()
				Else
					Button1.Visible = True
					Button2.Visible = True
					PictureBox2.Visible = False
				End If
			End If
			proses = False

		End If
	End Sub

	Private Async Function Simpan() As Task(Of Boolean)
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

			Dim cmd As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Kesan{0}" &
				" ({0}Nama{0},{0}Panggilan{0},{0}Umur{0},{0}Line{0},{0}NomorHP{0}," &
				"{0}Email{0},{0}Penilaian{0},{0}Kesan{0},{0}Gabung{0},{0}Kelas{0})" &
				" VALUES ('{1}','{2}',{3},'{4}','{5}','{6}',{7},'{8}',{9},'{10}')", Chr(34),
						Varlist.Nama, Varlist.Panggilan, Varlist.Umur, Varlist.Line, Varlist.HP, Varlist.Email,
						Varlist.nilai, Varlist.Kesan, Varlist.Ikut, Varlist.Kelas), koneksi)

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

	Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
		Me.Hide()
		SesiDua.Show()
	End Sub

	Private Sub Kesan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		If Varlist.sesi >= 3 Then
			TextBox1.Text = Varlist.Kesan

			If TextBox1.Text <> "" Then
				Label2.Text = "Sisa karakter : " & (600 - TextBox1.Text.Length) & " Karakter"
			Else
				TextBox1.Text = "Tulis disini..."
				Label2.Text = "Sisa karakter : 600 Karakter"
			End If

			If Varlist.Ikut = 2 Then
				RadioButton1.Checked = True
			ElseIf Varlist.Ikut = 1 Then
				RadioButton2.Checked = True
			ElseIf Varlist.Ikut = 0 Then
				RadioButton3.Checked = True
			End If


		Else
			Varlist.sesi = 3
		End If
	End Sub
End Class