Imports System.IO
Imports System.Threading
Imports Npgsql
Imports CryptSharp
Imports System.Text

Public Class Setting
	Dim _username As String
	Dim _password As String
	Dim _isDone As Boolean = False
	Dim idLevel As Integer

#Region "Properti"
	Public ReadOnly Property Username As String
		Get
			Return _username
		End Get
	End Property

	Public ReadOnly Property IsDone As Boolean
		Get
			Return _isDone
		End Get
	End Property

	Public ReadOnly Property IsChanged As Boolean
#End Region

	Public Sub New(ByVal Username As String, ByVal Password As String, ByVal idLevel As Integer)
		IsChanged = False
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		_username = Username
		_password = Password
		Me.idLevel = idLevel
	End Sub

	Const Prosess As Short = 17
	Const proses_repair As Short = 13
	Dim err As String

	Private Async Function CheckAvaibility(ByVal connectionString As String) As Task(Of Boolean)
		Dim token As New CancellationTokenSource(Varlist.BATAL)
		Dim hasil = False

		Dim test As New NpgsqlConnection(connectionString)
		Try
			Await test.OpenAsync()
			hasil = True
		Catch ex As Exception
			err = ex.ToString
		Finally
			test.Close()
		End Try

		Return hasil
	End Function

	Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		_isDone = False
		Proses.Style = MetroFramework.MetroColorStyle.Blue
		If MsgBox("Apakah anda yakin data yang anda masukan sudah benar?", vbExclamation + vbYesNo, "Peringatan") = vbNo Then Exit Sub

		Button3.Visible = False
		PictureBox2.Visible = True
		Proses.Visible = True
		LblProses.Visible = True

		'Tahap 1 : Mempersiapkan pengubahan data
		Updater("Mempersiapkan pengubahan data..", 1)
		Try
			'Tahap 2 : Memeriksa kelengkapan data
			Updater("Memeriksa kelengkapan data..", 2)
			If String.IsNullOrWhiteSpace(Server.Text) OrElse String.IsNullOrWhiteSpace(DB_User.Text) OrElse
				String.IsNullOrWhiteSpace(DB_Pass.Text) OrElse String.IsNullOrWhiteSpace(DB_Name.Text) OrElse
				String.IsNullOrWhiteSpace(Line.Text) OrElse String.IsNullOrWhiteSpace(Blog.Text) OrElse
				String.IsNullOrWhiteSpace(Instagram.Text) Then
				MsgBox("Semua data harus diisi untuk melanjutkan.", vbCritical + vbOKOnly, "Peringatan")
			Else
				'Tahap 3 : Membuat String koneksi
				Updater("Membuat string koneksi...", 3)
				Dim connectionString As String = String.Format(String.Format("Host={0};Database={1};Username={2};Password={3};", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text))

				'Tahap 4 : Memeriksa ketersediaan
				Updater("Memeriksa ketersediaan server...", 4)
				If Await CheckAvaibility(connectionString) Then
					Updater("Server ditemukan. Berusaha menjalin koneksi. (OK)", 5)
					'Tahap 5 : Server ditemukan. Berusaha menjalin koneksi
					Dim Koneksi As New NpgsqlConnection(connectionString)
					Await Koneksi.OpenAsync()

					'Tahap 6 : Koneksi terjalin. (OK)
					Updater("Koneksi terjalin. (OK)", 6)
					Updater("Memulai memeriksa tabel pada server...", 7)
					Dim lengkap As Boolean = True

					'Periksa Pengguna
					If Not Await Register.isExistsTable("Pengguna", "public", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text) Then
						lengkap = False
						Proses.Style = MetroFramework.MetroColorStyle.Yellow
						Updater("Tabel 'Pengguna' tidak ditemukan. (WARN)", 8)
						Await Task.Run(Sub() Thread.Sleep(1000))
						Proses.Style = MetroFramework.MetroColorStyle.Blue
					Else
						Updater("Tabel 'Pengguna' ditemukan. (OK)", 8)
						Await Task.Run(Sub() Thread.Sleep(1000))
					End If

					'Periksa Level
					If Not Await Register.isExistsTable("Level", "public", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text) Then
						lengkap = False
						Proses.Style = MetroFramework.MetroColorStyle.Yellow
						Updater("Tabel 'Level' tidak ditemukan. (WARN)", 9)
						Await Task.Run(Sub() Thread.Sleep(1000))
						Proses.Style = MetroFramework.MetroColorStyle.Blue
					Else
						Updater("Tabel 'Level' ditemukan. (OK)", 9)
						Await Task.Run(Sub() Thread.Sleep(1000))
					End If

					'Periksa Kesan
					If Not Await Register.isExistsTable("Kesan", "public", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text) Then
						lengkap = False
						Proses.Style = MetroFramework.MetroColorStyle.Yellow
						Updater("Tabel 'Kesan' tidak ditemukan. (WARN)", 10)
						Await Task.Run(Sub() Thread.Sleep(1000))
						Proses.Style = MetroFramework.MetroColorStyle.Blue
					Else
						Updater("Tabel 'Kesan' ditemukan. (OK)", 10)
						Await Task.Run(Sub() Thread.Sleep(1000))
					End If

					'Periksa Daftar
					If Not Await Register.isExistsTable("Daftar", "public", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text) Then
						lengkap = False
						Proses.Style = MetroFramework.MetroColorStyle.Yellow
						Updater("Tabel 'Daftar' tidak ditemukan. (WARN)", 11)
						Await Task.Run(Sub() Thread.Sleep(1000))
						Proses.Style = MetroFramework.MetroColorStyle.Blue
					Else
						Updater("Tabel 'Daftar' ditemukan. (OK)", 11)
						Await Task.Run(Sub() Thread.Sleep(1000))
					End If


					Updater("Memulai persiapan terakhir...", 12)
					Await Task.Run(Sub() Thread.Sleep(500))
					Updater("Membuat pengaturan pada Registry...", 13)

					My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review", "DB_NAME", DB_Name.Text, Microsoft.Win32.RegistryValueKind.String)
					My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review", "DB_PASS", DB_Pass.Text, Microsoft.Win32.RegistryValueKind.String)
					My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review", "DB_USER", DB_User.Text, Microsoft.Win32.RegistryValueKind.String)
					My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review", "SERVER", Server.Text, Microsoft.Win32.RegistryValueKind.String)

					My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review", "LINE", Line.Text, Microsoft.Win32.RegistryValueKind.String)
					My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review", "INSTAGRAM", Instagram.Text, Microsoft.Win32.RegistryValueKind.String)
					My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review", "WEB", Blog.Text, Microsoft.Win32.RegistryValueKind.String)

					Varlist.Server = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "SERVER", "Server").ToString
					Varlist.DB_NAME = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "DB_NAME", Nothing).ToString
					Varlist.DB_PASS = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "DB_PASS", Nothing).ToString
					Varlist.DB_USER = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "DB_USER", Nothing).ToString

					Varlist.LinePATCH = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "LINE", Nothing).ToString
					Varlist.Instagram = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "INSTAGRAM", Nothing).ToString
					Varlist.Web = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "WEB", Nothing).ToString

					Updater("Memeriksa keabsahan pengaturan...", 14)
					If String.IsNullOrEmpty(Varlist.DB_NAME) OrElse String.IsNullOrEmpty(Varlist.DB_PASS) OrElse String.IsNullOrEmpty(Varlist.DB_USER) OrElse
						String.IsNullOrEmpty(Varlist.LinePATCH) OrElse String.IsNullOrEmpty(Varlist.Instagram) OrElse String.IsNullOrEmpty(Varlist.Web) OrElse String.IsNullOrEmpty(Varlist.Server) Then
						MsgBox("GAGAL PEMBACAAN REGISTRY : Terjadi kesalahan saat penyimpanan.", vbExclamation + vbOKOnly, "Kesalahan")
					End If
					Updater("Data berhasil disimpan. (OK)", 15)

					If lengkap And Not (DelALL.Checked Or DelData.Checked Or
						DelPengguna.Checked Or DelLevel.Checked Or DelKesan.Checked Or
						DelLevel.Checked) Then

						Updater("Memperbaharui pengaturan.", 16)
						My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review\Install", "FirstInstall", 0, Microsoft.Win32.RegistryValueKind.DWord)

						If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review\Install", "FirstInstall", -1) <> 0 Then
							MsgBox("GAGAL SAAT MEMPERBAHARUI REGISTRY : Terjadi kesalahan saat memperbaharui 'FirstInstall'.", vbExclamation + vbOKOnly, "Kesalahan")
						End If

						Updater("Selesai. (OK)", 17)
						MsgBox("Selamat! Aplikasi 'Review' sudah diatur ulang.", vbInformation + vbOKOnly, "Informasi")

						_isDone = True
						_IsChanged = True
						Close()
					Else
						Proses.Style = MetroFramework.MetroColorStyle.Yellow

						If Not lengkap Then
							Updater("Database Pelu diperbaiki... (WARN)", 17)
							MsgBox("Kami mendeteksi bahwa database anda tidak lengkap. Kami akan membantu anda memperbaikinya.", vbExclamation + vbOKOnly, "Peringatan.")

						Else
							Proses.Style = MetroFramework.MetroColorStyle.Green
							Updater("Sesuai dengan permintaan...", 17)
						End If

						Proses.Style = MetroFramework.MetroColorStyle.Blue
						Proses.Maximum = proses_repair
						Proses.Value = 0

						'BACKUP LEVEL
						Dim admin As New NpgsqlCommand(String.Format("SELECT {0}Nama{0} FROM public.{0}Level{0} WHERE {0}ID_Level{0} = {1} ;", Chr(34), idLevel), Koneksi)
						Dim nama As String = Await admin.ExecuteScalarAsync

						Dim admin2 As New NpgsqlCommand(String.Format("SELECT {0}Akses{0} FROM public.{0}Level{0} WHERE {0}ID_Level{0} = {1} ;", Chr(34), idLevel), Koneksi)
						Dim akses As Long = Await admin2.ExecuteScalarAsync

						If Not lengkap Then
							Updater2("Mempersiapkan perbaikan database...", 1)
						Else
							Updater2("Melakukan pembersihan database...", 0)
							If DelALL.Checked Then
								Dim deleteDaftar As String = String.Format("DROP TABLE public.{0}Daftar{0};", Chr(34))
								Dim deleteKesan As String = String.Format("DROP TABLE public.{0}Kesan{0};", Chr(34))
								Dim deletePengguna As String = String.Format("DROP TABLE public.{0}Pengguna{0};", Chr(34))
								Dim deleteLevel As String = String.Format("DROP TABLE public.{0}Level{0};", Chr(34))

								Dim cmd1 As New NpgsqlCommand(deleteDaftar, Koneksi)
								Dim cmd2 As New NpgsqlCommand(deleteKesan, Koneksi)
								Dim cmd3 As New NpgsqlCommand(deletePengguna, Koneksi)
								Dim cmd4 As New NpgsqlCommand(deleteLevel, Koneksi)

								If DelALL.CheckState = CheckState.Checked Then
									Await cmd1.ExecuteNonQueryAsync
									Await cmd2.ExecuteNonQueryAsync
									Await cmd3.ExecuteNonQueryAsync
									Await cmd4.ExecuteNonQueryAsync
								Else
									If DelDaftar.Checked Then
										Await cmd1.ExecuteNonQueryAsync
									End If

									If DelKesan.Checked Then
										Await cmd2.ExecuteNonQueryAsync
									End If

									If DelPengguna.Checked Then
										Await cmd3.ExecuteNonQueryAsync
									End If

									If DelLevel.Checked Then
										Await cmd4.ExecuteNonQueryAsync
									End If
								End If
							End If
							Updater2("Selesai.. Mempersiapkan perbaikan database (OK)", 1)
						End If

						Dim tblDaftar As String = String.Format("CREATE TABLE public.{0}Daftar{0} (
														{0}ID_Pendaftaran{0}	SERIAL PRIMARY KEY,
														{0}Nama{0}				CHARACTER VARYING(50)	NOT NULL,
														{0}Kelompok{0}			CHARACTER VARYING(50)	NOT NULL,
														{0}Alasan{0}			CHARACTER VARYING(600)	NOT NULL,
														{0}Harapan{0}			CHARACTER VARYING(600)	NOT NULL,
														{0}Divisi{0}			CHARACTER VARYING(20)	NOT NULL
													);", Chr(34))

						Dim tblKesan As String = String.Format("CREATE TABLE public.{0}Kesan{0} (
														{0}ID_Kesan{0}		SERIAL PRIMARY KEY,
														{0}Nama{0}			CHARACTER VARYING(50)	NOT NULL,
														{0}Panggilan{0}		CHARACTER VARYING(50)	NOT NULL,
														{0}Umur{0}			INTEGER					NOT NULL,
														{0}Line{0}			CHARACTER VARYING(50),
														{0}NomorHP{0}		CHARACTER VARYING(50)	NOT NULL,
														{0}Email{0}			CHARACTER VARYING(50),
														{0}Penilaian{0}		INTEGER					NOT NULL,
														{0}Kesan{0}			CHARACTER VARYING(600)	NOT NULL,
														{0}Gabung{0}		INTEGER					NOT NULL,
														{0}Kelas{0}			CHARACTER VARYING(50)	NOT NULL
													);", Chr(34))

						Dim tblLevel As String = String.Format("CREATE TABLE public.{0}Level{0} (
														{0}ID_Level{0}	SERIAL PRIMARY KEY,
														{0}Akses{0}		BIGINT					NOT NULL,
														{0}Nama{0}		CHARACTER VARYING(50)
													);", Chr(34))

						Dim tblPengguna As String = String.Format("CREATE TABLE public.{0}Pengguna{0} (
														{0}Username{0}	CHARACTER VARYING(50)	PRIMARY KEY,
														{0}Password{0}	CHARACTER VARYING(500)	NOT NULL,
														{0}Level{0}		BIGINT					NOT NULL,
														{0}Nama{0}		CHARACTER VARYING(50)
													);", Chr(34))

						Updater2("Memeriksa tabel 'Level'", 2)
						'Periksa Level
						If Not Await Register.isExistsTable("Level", "public", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text) Then
							Updater2("Tabel 'Level' belum ada. Membuat tabel 'Level'", 3)
							Dim perintah As New NpgsqlCommand(tblLevel, Koneksi)
							Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Level{0} " &
																"({0}Nama{0},{0}Akses{0})" &
																" VALUES ('{1}','{2}');", Chr(34), "Administrator", 549755813887), Koneksi)

							Dim baru2 As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Level{0} " &
																"({0}Nama{0},{0}Akses{0})" &
																" VALUES ('{1}','{2}');", Chr(34), nama, akses), Koneksi)

							Await perintah.ExecuteNonQueryAsync
							Await baru.ExecuteNonQueryAsync
							Await baru2.ExecuteNonQueryAsync

							Updater2("Berhasil membuat tabel 'Level'. Siap.. Siap Digunakan :D (OK)", 4)
						Else
							If Not DelData.Checked Then
								If MsgBox("Kami mendeteksi bahwa database anda memiliki tabel 'Level'. Apakah anda ingin menghapus datanya?", vbYesNo + vbExclamation, "Perhatian") = vbYes Then
									Updater2("Menghapus dan mengatur ulang tabel 'Level'", 3)
									Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Level{0};", Chr(34)), Koneksi)
									Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Level{0} " &
																"({0}Nama{0},{0}Akses{0})" &
																" VALUES ('{1}','{2}');", Chr(34), "Administrator", 549755813887), Koneksi)

									Dim baru2 As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Level{0} " &
																"({0}Nama{0},{0}Akses{0})" &
																" VALUES ('{1}','{2}');", Chr(34), nama, akses), Koneksi)

									Await hapus.ExecuteNonQueryAsync
									Await baru.ExecuteNonQueryAsync
									Await baru2.ExecuteNonQueryAsync
								End If
							Else
								Updater2("Menghapus dan mengatur ulang tabel 'Level'", 3)
								Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Level{0};", Chr(34)), Koneksi)
								Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Level{0} " &
															"({0}Nama{0},{0}Akses{0})" &
															" VALUES ('{1}','{2}');", Chr(34), "Administrator", 549755813887), Koneksi)

								Dim baru2 As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Level{0} " &
																"({0}Nama{0},{0}Akses{0})" &
																" VALUES ('{1}','{2}');", Chr(34), nama, akses), Koneksi)

								Await hapus.ExecuteNonQueryAsync
								Await baru.ExecuteNonQueryAsync
								Await baru2.ExecuteNonQueryAsync
							End If

							Updater2("Tabel 'Level' Siap digunakan. (OK)", 4)
						End If

						'FASE 5
						'Periksa Pengguna
						Updater2("Memeriksa tabel pengguna...", 5)
						If Not Await Register.isExistsTable("Pengguna", "public", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text) Then
							Updater2("Tabel 'Pengguna' Belum ada. Membuat tabel 'Pengguna'...", 6)
							Dim perintah As New NpgsqlCommand(tblPengguna, Koneksi)
							Await perintah.ExecuteNonQueryAsync

							If Not SaveMe.Checked Then
								Updater2("Membuat Pengguna Baru...", 6)
								'Buat pengguna
								Dim buat As New AddUser(connectionString, True)
								buat.Show()

								Await Task.Run(Sub()
												   While Not buat.IsDone
												   End While
											   End Sub)

								If buat.ErrorCondition Then
									Throw New Exception("KESALAHAN: USERNAME TIDAK DAPAT DIBUAT")
								Else
									Updater2("Pengguna berhasil dibuat. (OK)", 7)
									MsgBox(String.Format("Akun telah berhasil dibuat. Halo {0}!", buat.Username), vbInformation + vbOKOnly, "Pemberitahuan")
								End If

								buat.Close()
							Else
								Updater2("Memulihkan akun anda...", 6)
								Dim sumber As New CancellationTokenSource(Varlist.BATAL) 'SEKERING

								Dim admine As New NpgsqlCommand(String.Format("SELECT {0}ID_Level{0} FROM public.{0}Level{0} WHERE {0}Nama{0} = '{1}';", Chr(34), nama), Koneksi)
								Dim id As Long = Await admine.ExecuteScalarAsync

								Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Pengguna{0} " &
																"({0}Username{0},{0}Password{0},{0}Level{0},{0}Nama{0})" &
																" VALUES ('{1}','{2}','{3}','{4}');", Chr(34), Username,
																Crypter.Blowfish.Crypt(Encoding.ASCII.GetBytes(_password),
																Crypter.Blowfish.GenerateSalt()), id, Username), Koneksi)

								Await baru.ExecuteNonQueryAsync(sumber.Token)
							End If

						Else
							If Not DelData.Checked Then
								If MsgBox("Kami mendeteksi bahwa database anda memiliki tabel 'Pengguna'. Apakah anda ingin menghapus datanya?", vbYesNo + vbExclamation, "Perhatian") = vbYes Then
									Updater2("Menghapus dan mengatur ulang tabel 'Pengguna'...", 5)
									Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Pengguna{0};", Chr(34)), Koneksi)
									Await hapus.ExecuteNonQueryAsync()

									If Not SaveMe.Checked Then
										Updater2("Membuat Pengguna Baru...", 6)
										'Buat pengguna
										Dim buat As New AddUser(connectionString, True)
										buat.Show()

										Await Task.Run(Sub()
														   While Not buat.IsDone
														   End While
													   End Sub)

										If buat.ErrorCondition Then
											Throw New Exception("KESALAHAN: USERNAME TIDAK DAPAT DIBUAT")
										Else
											Updater2("Pengguna berhasil dibuat. (OK)", 7)
											MsgBox(String.Format("Akun telah berhasil dibuat. Halo {0}!", buat.Username), vbInformation + vbOKOnly, "Pemberitahuan")
										End If

										buat.Close()
									Else
										Updater2("Memulihkan akun anda...", 6)
										Dim sumber As New CancellationTokenSource(Varlist.BATAL) 'SEKERING

										Dim admine As New NpgsqlCommand(String.Format("SELECT {0}ID_Level{0} FROM public.{0}Level{0} WHERE {0}Nama{0} = '{1}';", Chr(34), nama), Koneksi)
										Dim id As Long = Await admin.ExecuteScalarAsync

										Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Pengguna{0} " &
																"({0}Username{0},{0}Password{0},{0}Level{0},{0}Nama{0})" &
																" VALUES ('{1}','{2}','{3}','{4}');", Chr(34), Username,
																Crypter.Blowfish.Crypt(Encoding.ASCII.GetBytes(_password),
																Crypter.Blowfish.GenerateSalt()), id, Username), Koneksi)

										Await baru.ExecuteNonQueryAsync(sumber.Token)
									End If
								End If
							Else
								Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Pengguna{0};", Chr(34)), Koneksi)
								Await hapus.ExecuteNonQueryAsync()

								If Not SaveMe.Checked Then
									Updater2("Membuat Pengguna Baru...", 6)
									'Buat pengguna
									Dim buat As New AddUser(connectionString, True)
									buat.Show()

									Await Task.Run(Sub()
													   While Not buat.IsDone
													   End While
												   End Sub)

									If buat.ErrorCondition Then
										Throw New Exception("KESALAHAN: USERNAME TIDAK DAPAT DIBUAT")
									Else
										Updater2("Pengguna berhasil dibuat. (OK)", 7)
										MsgBox(String.Format("Akun telah berhasil dibuat. Halo {0}!", buat.Username), vbInformation + vbOKOnly, "Pemberitahuan")
									End If

									buat.Close()
								Else
									Updater2("Memulihkan akun anda...", 6)
									Dim sumber As New CancellationTokenSource(Varlist.BATAL) 'SEKERING

									Dim admine As New NpgsqlCommand(String.Format("SELECT {0}ID_Level{0} FROM public.{0}Level{0} WHERE {0}Nama{0} = '{1}';", Chr(34), nama), Koneksi)
									Dim id As Long = Await admin.ExecuteScalarAsync

									Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Pengguna{0} " &
																	"({0}Username{0},{0}Password{0},{0}Level{0},{0}Nama{0})" &
																	" VALUES ('{1}','{2}','{3}','{4}');", Chr(34), Username,
																	Crypter.Blowfish.Crypt(Encoding.ASCII.GetBytes(_password),
																	Crypter.Blowfish.GenerateSalt()), id, Username), Koneksi)

									Await baru.ExecuteNonQueryAsync(sumber.Token)
								End If
							End If
						End If

						'FASE 8 : Periksa Kesan
						Updater2("Memeriksa tabel 'Kesan'.", 8)
						If Not Await Register.isExistsTable("Kesan", "public", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text) Then
							Updater2("Tabel 'Kesan' tidak ada. Membuat tabel 'Kesan'...", 9)
							Dim cmd As New NpgsqlCommand(tblKesan, Koneksi)
							Await cmd.ExecuteNonQueryAsync
							Updater2("Berhasil membuat Tabel. (OK)", 10)
						Else
							If Not DelData.Checked Then
								If MsgBox("Kami mendeteksi bahwa database anda memiliki tabel 'Kesan'. Apakah anda ingin menghapus datanya?", vbYesNo + vbExclamation, "Perhatian") = vbYes Then
									Updater2("Menghapus tabel 'Kesan'.", 9)
									Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Kesan{0};", Chr(34)), Koneksi)
									Await hapus.ExecuteNonQueryAsync()
								End If
							Else
								Updater2("Menghapus tabel 'Kesan'.", 9)
								Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Kesan{0};", Chr(34)), Koneksi)
								Await hapus.ExecuteNonQueryAsync()
							End If

							Updater2("Selesai. Tabel 'Kesan' siap digunakan. (OK)", 10)
						End If

						'Periksa Daftar
						Updater2("Memeriksa tabel 'Daftar'.", 11)
						If Not Await Register.isExistsTable("Daftar", "public", Server.Text, DB_Name.Text, DB_User.Text, DB_Pass.Text) Then
							Updater2("Tabel 'Daftar' tidak ada. Membuat tabel daftar..", 12)
							Dim cmd As New NpgsqlCommand(tblDaftar, Koneksi)
							Await cmd.ExecuteNonQueryAsync()
							Updater2("Berhasil membuat Tabel. Mantapp.. (OK)", 13)
						Else
							If Not DelData.Checked Then
								If MsgBox("Kami mendeteksi bahwa database anda memiliki tabel 'Daftar'. Apakah anda ingin menghapus datanya?", vbYesNo + vbExclamation, "Perhatian") = vbYes Then
									Updater2("Menghapus tabel 'Daftar'...", 12)
									Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Daftar{0};", Chr(34)), Koneksi)
									Await hapus.ExecuteNonQueryAsync()
								End If
							Else
								Updater2("Menghapus tabel 'Daftar'...", 12)
								Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Daftar{0};", Chr(34)), Koneksi)
								Await hapus.ExecuteNonQueryAsync()
							End If

							Updater2("Selesai. Tabel 'Daftar' siap digunakan.", 12)
						End If

						Updater2("Memperbaharui pengaturan sistem...", 13)
						My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Review\Install", "FirstInstall", 0, Microsoft.Win32.RegistryValueKind.DWord)

						Updater2("Memeriksa pengaturan sistem...", 14)
						If My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review\Install", "FirstInstall", -1) <> 0 Then
							Throw New Exception("GAGAL SAAT MEMPERBAHARUI REGISTRY : Terjadi kesalahan saat memperbaharui 'FirstInstall'.")
						End If

						Updater2("Selesai.", 15)
						MsgBox("Selamat! Aplikasi 'Review' sudah diatur ulang.", vbInformation + vbOKOnly, "Informasi")
						'Prosedur Restart
						_isDone = True
						_IsChanged = True
						Close()
					End If
					Koneksi.Close()
				Else
					Proses.Style = MetroFramework.MetroColorStyle.Red
					MsgBox("Server tidak ditemukan oleh sistem kami.", vbCritical + vbOKOnly, "Kesalahan")
				End If

			End If
		Catch ex As Exception
			Proses.Style = MetroFramework.MetroColorStyle.Red
			If MsgBox("Terjadi kesalahan saat mempersiapkan aplikasi. Apakah anda ingin mendapatkan file log kesalahan?", vbCritical + vbYesNo, "Kesalahan Server") = vbYes Then
				Try
					Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
					Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
					Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

					File.WriteAllText(Alamat, err & vbNewLine & vbNewLine & ex.ToString)
					MsgBox("File log telah dibuat. Lihat file " & Alamat, vbInformation + vbOKOnly, "Informasi")

				Catch fileerror As IOException
					MsgBox("Terjadi masalah dengan penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan IO")

				End Try
			End If
		End Try

		Button3.Visible = True
		PictureBox2.Visible = False
		Proses.Visible = False
		LblProses.Visible = False
	End Sub

	Private Sub Updater(ByVal msg As String, ByVal i As Integer)
		Proses.Value = i
		LblProses.Text = String.Format("{0:P} - {1}", i / Prosess, msg)
		Proses.Update()
	End Sub

	Private Sub Updater2(ByVal msg As String, ByVal i As Integer)
		Proses.Value = i
		LblProses.Text = String.Format("{0:P} - {1}", i / proses_repair, msg)
		Proses.Update()
	End Sub

	Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles DelALL.CheckedChanged
		If DelALL.CheckState = CheckState.Checked Then
			DelData.Checked = True
			DelData.Enabled = False
			DelDaftar.Checked = True : DelDaftar.Enabled = False
			DelLevel.Checked = True : DelLevel.Enabled = False
			DelPengguna.Checked = True : DelPengguna.Enabled = False
			DelKesan.Checked = True : DelKesan.Enabled = False

		ElseIf DelALL.CheckState = CheckState.Unchecked Then
			DelData.Enabled = True
			DelDaftar.Checked = False : DelDaftar.Enabled = True
			DelLevel.Checked = False : DelLevel.Enabled = True
			DelPengguna.Checked = False : DelPengguna.Enabled = True
			DelKesan.Checked = False : DelKesan.Enabled = True
		End If
	End Sub

	Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles DelLevel.CheckedChanged
		If DelDaftar.Checked And DelLevel.Checked And DelPengguna.Checked And DelKesan.Checked Then
			DelALL.CheckState = CheckState.Checked
			DelData.Checked = True
			DelData.Enabled = False
			DelDaftar.Enabled = False
			DelLevel.Enabled = False
			DelPengguna.Enabled = False
			DelKesan.Enabled = False
		ElseIf Not (DelDaftar.Checked Or DelLevel.Checked Or DelPengguna.Checked Or DelKesan.Checked) Then
			DelALL.CheckState = CheckState.Unchecked
		Else
			DelALL.CheckState = CheckState.Indeterminate
		End If
	End Sub

	Private Sub DelKesan_CheckedChanged(sender As Object, e As EventArgs) Handles DelKesan.CheckedChanged
		If DelDaftar.Checked And DelLevel.Checked And DelPengguna.Checked And DelKesan.Checked Then
			DelALL.CheckState = CheckState.Checked
			DelData.Checked = True
			DelData.Enabled = False
			DelDaftar.Enabled = False
			DelLevel.Enabled = False
			DelPengguna.Enabled = False
			DelKesan.Enabled = False
		ElseIf Not (DelDaftar.Checked Or DelLevel.Checked Or DelPengguna.Checked Or DelKesan.Checked) Then
			DelALL.CheckState = CheckState.Unchecked
		Else
			DelALL.CheckState = CheckState.Indeterminate
		End If
	End Sub

	Private Sub DelPengguna_CheckedChanged(sender As Object, e As EventArgs) Handles DelPengguna.CheckedChanged
		If DelDaftar.Checked And DelLevel.Checked And DelPengguna.Checked And DelKesan.Checked Then
			DelALL.CheckState = CheckState.Checked
			DelData.Checked = True
			DelData.Enabled = False
			DelDaftar.Enabled = False
			DelLevel.Enabled = False
			DelPengguna.Enabled = False
			DelKesan.Enabled = False
		ElseIf Not (DelDaftar.Checked Or DelLevel.Checked Or DelPengguna.Checked Or DelKesan.Checked) Then
			DelALL.CheckState = CheckState.Unchecked
		Else
			DelALL.CheckState = CheckState.Indeterminate
		End If
	End Sub

	Private Sub DelDaftar_CheckedChanged(sender As Object, e As EventArgs) Handles DelDaftar.CheckedChanged
		If DelDaftar.Checked And DelLevel.Checked And DelPengguna.Checked And DelKesan.Checked Then
			DelALL.CheckState = CheckState.Checked
			DelData.Checked = True
			DelData.Enabled = False
			DelDaftar.Enabled = False
			DelLevel.Enabled = False
			DelPengguna.Enabled = False
			DelKesan.Enabled = False
		ElseIf Not (DelDaftar.Checked Or DelLevel.Checked Or DelPengguna.Checked Or DelKesan.Checked) Then
			DelALL.CheckState = CheckState.Unchecked
		Else
			DelALL.CheckState = CheckState.Indeterminate
		End If
	End Sub

	Private Sub Setting_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
		_isDone = True
	End Sub

End Class