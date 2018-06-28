'=======================================================================================
' Nama File : Varlist.vb
' Deskripsi : Library Login
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 19 Juni 2018
' Tanggal Edit : 20 Juni 2018
' Copyright PATCH (c) 2018
'========================================================================================

Imports CryptSharp
Imports System.Text
Imports System.Threading
Imports Npgsql
Imports System.IO
Imports System.Configuration


Public Class Login
	Dim TIMEOUT As Integer = 5000
	Dim Username As String
	Dim Password As String
	Dim DB_Server As String
	Dim DB_Name As String
	Dim DB_Password As String
	Dim DB_User As String
	Public nama As String
	Dim connectstr As String

	Public Sub New()
		DB_Server = "127.0.0.1"
		DB_Name = "PATCH"
		DB_User = "root"
	End Sub

	Public Sub setTimeout(ByVal TIMEOUT As Integer)
		Me.TIMEOUT = TIMEOUT
	End Sub

	Public Sub New(ByVal NamaDatabase As String, ByVal UserDatabase As String,
				   ByVal UserPassword As String, ByVal ServerDatabase As String)
		DB_Name = NamaDatabase
		DB_Server = ServerDatabase
		DB_User = UserDatabase
		DB_Password = UserPassword
	End Sub

	Public Sub New(ByVal connectionString As String)
		connectstr = connectionString
	End Sub

	Public Async Function login(ByVal username As String, ByVal password As String) As Task(Of Boolean)
		'Membuat Pembatal, Batalkan koneksi jika lebih dari 10 detik
		Dim sumber As New CancellationTokenSource(TIMEOUT)

		'Hasil dari fungsi login
		Dim hasil As Boolean = False

		Dim Koneksi As NpgsqlConnection
		If String.IsNullOrEmpty(connectstr) Then
			Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};", DB_Server, DB_Name, DB_User, DB_Password))
		Else
			Koneksi = New NpgsqlConnection(connectstr)
		End If
		'DB Tampung
		Dim Level As Integer
		Dim PassServer As String = ""

		'Mulai Proses
		Try
			Await Koneksi.OpenAsync(sumber.Token)

			Dim perintah As New NpgsqlCommand(String.Format("SELECT {0}Nama{0},{0}Password{0},{0}Level{0} FROM public.{0}Pengguna{0} WHERE {0}Username{0}='{1}';", Chr(34), username), Koneksi)
			Dim baca As NpgsqlDataReader = Await perintah.ExecuteReaderAsync(sumber.Token)

			If baca.HasRows Then
				While Await baca.ReadAsync(sumber.Token)
					PassServer = baca.GetString(1)
					Level = baca.GetInt32(2)
					nama = baca.GetString(0)
				End While

				If Crypter.CheckPassword(Encoding.ASCII.GetBytes(password), PassServer) Then
					hasil = True
					setID(username)
				Else
					MsgBox("Pasangan Username dan Password tidak ditemukan di server kami.", vbCritical + vbOKOnly, "Kesalahan")
				End If

			Else
				MsgBox("Pasangan Username dan Password tidak ditemukan di server kami.", vbCritical + vbOKOnly, "Kesalahan")
			End If

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

	Public Async Function login(ByVal Username As String, ByVal Password As String, ByVal Akses As Integer) As Task(Of Boolean)
		'Membuat Pembatal, Batalkan koneksi jika lebih dari 10 detik
		Dim sumber As New CancellationTokenSource(TIMEOUT)

		'Hasil dari fungsi login
		Dim hasil As Boolean = False
		Dim Koneksi As NpgsqlConnection
		If String.IsNullOrEmpty(connectstr) Then
			Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};", DB_Server, DB_Name, DB_User, DB_Password))
		Else
			Koneksi = New NpgsqlConnection(connectstr)
		End If

		'DB Tampung
		Dim Level As Integer
		Dim PassServer As String = ""

		'Mulai Proses
		Try
			Await Koneksi.OpenAsync(sumber.Token)

			Dim perintah As New NpgsqlCommand(String.Format("SELECT {0}Nama{0},{0}Password{0},{0}Level{0} FROM public.{0}Pengguna{0} WHERE {0}Username{0}='{1}';", Chr(34), Username), Koneksi)
			Dim baca As NpgsqlDataReader = Await perintah.ExecuteReaderAsync(sumber.Token)

			If baca.HasRows Then
				While Await baca.ReadAsync(sumber.Token)
					PassServer = baca.GetString(1)
					Level = baca.GetInt32(2)
					nama = baca.GetString(0)
				End While

				If Crypter.CheckPassword(Encoding.ASCII.GetBytes(Password), PassServer) Then
					If Await AdminCheck(Akses, Level) Then
						hasil = True
						setID(Username)
					End If
				Else
					MsgBox("Pasangan Username dan Password tidak ditemukan di server kami.", vbCritical + vbOKOnly, "Kesalahan")
				End If

			Else
				MsgBox("Pasangan Username dan Password tidak ditemukan di server kami.", vbCritical + vbOKOnly, "Kesalahan")
			End If

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

	Public Async Function AdminCheck(ByVal Akses As Integer, ByVal UserLevel As Integer) As Task(Of Boolean)
		Dim sumber As New CancellationTokenSource(TIMEOUT)
		Dim hasil As Boolean = False

		'Membaca database sebagai koneksi
		Dim Koneksi As NpgsqlConnection
		If String.IsNullOrEmpty(connectstr) Then
			Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};", DB_Server, DB_Name, DB_User, DB_Password))
		Else
			Koneksi = New NpgsqlConnection(connectstr)
		End If

		Try
			'Menghubungi database
			Await Koneksi.OpenAsync(sumber.Token)

			'Memerintah tabel Level pada koneksi 
			Dim perintah As New NpgsqlCommand(String.Format("SELECT {0}Akses{0} FROM public.{0}Level{0} WHERE {0}ID_Level{0} = '{1}'", Chr(34), UserLevel), Koneksi)
			Dim cmd As NpgsqlDataReader = Await perintah.ExecuteReaderAsync(sumber.Token)

			If cmd.HasRows Then
				While Await cmd.ReadAsync(sumber.Token)
					Dim AksesLevel As Long = cmd.GetInt64(0)
					hasil = Convert.ToBoolean((AksesLevel >> (Akses - 1)) And 1)
				End While
			End If

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

	Private Sub setID(ByVal user As String)
		Try
			Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
			config.AppSettings.Settings("UserID").Value = user

			config.Save(ConfigurationSaveMode.Modified)
			ConfigurationManager.RefreshSection("appsettings")
		Catch ex As Exception
			Try
				Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
				Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
				Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

				MsgBox("Terjadi masalah pada pengaturan sistem. Lihat file " & Alamat, vbCritical + vbOKOnly, "Kesalahan Server")
				File.WriteAllText(Alamat, ex.ToString())

			Catch fileerror As IOException
				MsgBox("Terjadi masalah dengan pengaturan sistem serta penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan Server")
			End Try
		End Try
	End Sub
End Class