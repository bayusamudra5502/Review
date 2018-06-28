Imports CryptSharp
Imports System.Text
Imports System.Threading
Imports Npgsql
Imports System.IO
Imports System.Configuration

Public Class Register
	Dim TIMEOUT As Integer = 5000
	Dim Username As String
	Dim Password As String
	Dim DB_Server As String
	Dim DB_Name As String
	Dim DB_Password As String
	Dim DB_User As String
	Dim AdmUser As String
	Dim AdmPass As String
	Public nama As String
	Dim connectionstring As String

	Public Enum Akses
		CRUD_Status_Sendiri = 0
		CRUD_Judge_Sendiri = 1
		Edit_Status_Orang = 2
		Hapus_Status_Orang = 3
		Membuat_Software_Cloud = 4
		Upload_Gambar = 5
		Upload_Dokumen = 6
		Upload_Audio_Video = 7
		Upload_Software = 8
		Upload_Lain = 9
		Edit_Blog = 10
		Hapus_Blog = 11
		Tulis_Blog = 12
		Mengatur_Apperance_Blog = 13
		Melihat_Skoring = 14
		Melihat_kode_sendiri = 15
		Edit_kode_sendiri = 16
		Upload_kode_sendiri = 17
		Memberi_Pesan_Server = 18
		Melihat_skoring_Orang = 19
		Melihat_Kode_Orang = 20
		Mengedit_Kode_Orang = 21
		CRUD_Masalah = 22
		CRUD_Penilaian_Sendiri = 23
		Membatalkan_Pemeriksaan_Kompiler = 24
		CRUD_Jawaban_Orang = 25
		Melihat_Hasil_Sendiri = 26
		Melihat_Hasil_Orang = 27
		Memberi_Masukan = 28
		Manajemen_Resources_Server = 29
		CRUD_Penilaian_Orang = 30
		Administrasi_Level = 31
		Administrasi_Pengguna = 32
		Melihat_Tabel_Kesan = 33
		Melihat_Statistik_Judge = 34
		CRUD_Pesan_Kabel = 35
		CRUD_Pesan_Kabel_Orang = 36
		CRUD_Tabel_Kesan = 37
	End Enum

	Public Sub New(ByVal AdminUser As String, ByVal AdminPass As String)
		DB_Server = "127.0.0.1"
		DB_Name = "PATCH"
		DB_User = "root"
		AdmUser = AdminUser
		AdmPass = AdminPass
	End Sub

	Public Sub New(ByVal AdminUser As String, ByVal AdminPass As String, ByVal connectionString As String)
		Me.connectionstring = connectionString
		AdmUser = AdminUser
		AdmPass = AdminPass
	End Sub

	Public Sub setTimeout(ByVal TIMEOUT As Integer, ByVal AdminUser As String, ByVal AdminPass As String)
		Me.TIMEOUT = TIMEOUT
		AdmUser = AdminUser
		AdmPass = AdminPass
	End Sub

	Public Sub New(ByVal NamaDatabase As String, ByVal UserDatabase As String,
				   ByVal UserPassword As String, ByVal ServerDatabase As String,
				   ByVal AdminUser As String, ByVal AdminPass As String)
		DB_Name = NamaDatabase
		DB_Server = ServerDatabase
		DB_User = UserDatabase
		DB_Password = UserPassword
		AdmUser = AdminUser
		AdmPass = AdminPass
	End Sub

	Public Async Function Register(ByVal username As String, ByVal password As String, ByVal Level As String, Optional ByVal Nama As String = "") As Task(Of Boolean)
		Dim keluaran As Boolean = False

		Dim login As Login
		If String.IsNullOrWhiteSpace(connectionstring) Then
			login = New Login(DB_Name, DB_User, DB_Password, DB_Server)
		Else
			login = New Login(connectionstring)
		End If

		Dim akun As Boolean = Await login.login(AdmUser, AdmPass, 33)
		If akun AndAlso Not Await isExists("Pengguna", "Username", username) Then
			Dim sumber As New CancellationTokenSource(TIMEOUT)

			Dim Koneksi As NpgsqlConnection
			If String.IsNullOrEmpty(connectionstring) Then
				Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};",
						  DB_Server, DB_Name, DB_User, DB_Password))
			Else
				Koneksi = New NpgsqlConnection(connectionstring)
			End If

			Try
				Await Koneksi.OpenAsync(sumber.Token)

				If Await isExists("Level", "Nama", Level) Then
					Dim cmd As New NpgsqlCommand(String.Format("SELECT {0}ID_Level{0} FROM public.{0}Level{0} WHERE {0}Nama{0} = '{1}';", Chr(34), Level), Koneksi)
					Dim idlevel As Integer = Await cmd.ExecuteScalarAsync
					Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Pengguna{0} " &
																"({0}Username{0},{0}Password{0},{0}Level{0},{0}Nama{0})" &
																" VALUES ('{1}','{2}','{3}','{4}');", Chr(34), username,
																Crypter.Blowfish.Crypt(Encoding.ASCII.GetBytes(password),
																Crypter.Blowfish.GenerateSalt()), idlevel, Nama), Koneksi)


					Await baru.ExecuteNonQueryAsync
					keluaran = True
				Else
					MsgBox("Level tidak ditemukan di server kami. Pastikan anda telah membuat level tersebut.", vbCritical + vbOKOnly, "Proses Dibatalkan")
				End If

			Catch ex As Exception
				Try
					Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
					Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
					Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

					File.WriteAllText(Alamat, ex.ToString)
					MsgBox("Terjadi kesalahan saat membuat user. Lihat log : " & Alamat, vbInformation + vbOKOnly, "Kesalahan")

				Catch fileerror As IOException
					MsgBox("Terjadi masalah dengan penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan IO")

				End Try
			End Try
		Else
			If Not akun Then
				MsgBox("Username sudah terdaftar.", vbCritical + vbOKOnly, "Proses Dibatalkan")
			Else
				MsgBox("Anda tidak memiliki akses untuk melakukan operasi ini.", vbCritical + vbOKOnly, "Proses Dibatalkan")
			End If
		End If
		Return keluaran
	End Function

	Public Async Function RegisterKelas(ByVal NamaLevel As String, ByVal kode As Long) As Task(Of Boolean)
		Dim hasil As Boolean = False

		Dim login As Login
		If String.IsNullOrWhiteSpace(connectionstring) Then
			login = New Login(DB_Name, DB_User, DB_Password, DB_Server)
		Else
			login = New Login(connectionstring)
		End If

		Dim akun As Boolean = Await login.login(AdmUser, AdmPass, 32)
		If akun AndAlso Not Await isExists("Level", "Nama", NamaLevel) Then
			Dim sumber As New CancellationTokenSource(TIMEOUT)

			Dim Koneksi As NpgsqlConnection
			If String.IsNullOrEmpty(connectionstring) Then
				Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};",
						  DB_Server, DB_Name, DB_User, DB_Password))
			Else
				Koneksi = New NpgsqlConnection(connectionstring)
			End If

			Try
				Await Koneksi.OpenAsync(sumber.Token)

				Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Level{0} " &
																"({0}Nama{0},{0}Akses{0})" &
																" VALUES ('{1}','{2}');", Chr(34), NamaLevel,
																kode), Koneksi)

				Await baru.ExecuteNonQueryAsync

				hasil = True

			Catch ex As Exception
				Try
					Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
					Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
					Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

					File.WriteAllText(Alamat, ex.ToString)
					MsgBox("Terjadi kesalahan saat membuat level. Lihat log :" & Alamat, vbCritical + vbOKOnly, "Kesalahan")

				Catch fileerror As IOException
					MsgBox("Terjadi masalah dengan penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan IO")

				End Try
			End Try
		Else
			If Not akun Then
				MsgBox("Nama Level sudah terdaftar.", vbCritical + vbOKOnly, "Proses Dibatalkan")
			Else
				MsgBox("Anda tidak memiliki akses untuk melakukan operasi ini.", vbCritical + vbOKOnly, "Akses Ditolak")
			End If
		End If
		Return hasil
	End Function

	Private Async Function isExists(ByVal Tabel As String, ByVal Kolom As String, ByVal Nilai As String) As Task(Of Boolean)
		Dim hasil As Boolean = False
		Dim sumber As New CancellationTokenSource(TIMEOUT)


		Dim Koneksi As NpgsqlConnection
		If String.IsNullOrEmpty(connectionstring) Then
			Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};",
						  DB_Server, DB_Name, DB_User, DB_Password))
		Else
			Koneksi = New NpgsqlConnection(connectionstring)
		End If

		Try
			Await Koneksi.OpenAsync(sumber.Token)
			Dim str As String = String.Format(
				"SELECT CASE WHEN EXISTS((SELECT * FROM public.{0}{1}{0} WHERE {0}{2}{0} = '{3}')) THEN 1 ELSE 0 END;",
			Chr(34), Tabel, Kolom, Nilai)

			Dim cmd As New NpgsqlCommand(str, Koneksi)
			hasil = Convert.ToBoolean(Await cmd.ExecuteScalarAsync)
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
		End Try

		Return hasil
	End Function

	Public Shared Async Function isExistsTable(ByVal Tabel As String, ByVal Skema As String,
											   ByVal DB_server As String, ByVal DB_Name As String,
											   ByVal DB_User As String, ByVal DB_Password As String) As Task(Of Boolean)
		Dim hasil As Boolean = False
		Dim sumber As New CancellationTokenSource(10000)

		Dim Koneksi = New NpgsqlConnection(
			String.Format("Host={0};Database={1};Username={2};Password={3};",
						  DB_server, DB_Name, DB_User, DB_Password))
		Try
			Await Koneksi.OpenAsync(sumber.Token)
			Dim str As String = String.Format(
				"SELECT CASE WHEN EXISTS((SELECT * FROM information_schema.tables WHERE  table_schema = '{0}' AND table_name = '{1}')) THEN 1 ELSE 0 END;",
					Skema, Tabel)

			Dim cmd As New NpgsqlCommand(str, Koneksi)
			hasil = Convert.ToBoolean(Await cmd.ExecuteScalarAsync)
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
		End Try

		Return hasil
	End Function
End Class
