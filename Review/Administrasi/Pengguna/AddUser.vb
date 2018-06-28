Imports Npgsql
Imports CryptSharp
Imports System.Text
Imports System.Threading
Imports System.IO

Public Class AddUser
	Const BATAL = 5000

	Dim _isDone As Boolean = False
	Dim _isSuccess As Boolean
	Dim _ErrorMSG As String
	Dim _error As Boolean
	Dim _Username As String
	Dim _AdminUser As String
	Dim _AdminPass As String

	Dim Password As String

	Public Sub New(ByVal connectionString As String, Optional ByVal isFirstInstall As Boolean = False)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		Me.isFirstInstall = isFirstInstall
		Me.connectionString = connectionString
	End Sub

	Public Sub New(ByVal connectionString As String, ByVal AdminUser As String, ByVal AdminPass As String, Optional ByVal isFirstInstall As Boolean = False)
		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		_AdminUser = AdminUser
		_AdminPass = AdminPass
		Me.isFirstInstall = isFirstInstall
	End Sub

#Region "Properti"
	Public ReadOnly Property IsSuccess As Boolean
		Get
			Return _isSuccess
		End Get
	End Property

	Public ReadOnly Property ErrorMessage As String
		Get
			Return _ErrorMSG
		End Get
	End Property

	Public WriteOnly Property AdminUser As String
		Set(value As String)
			_AdminUser = value
		End Set
	End Property

	Public WriteOnly Property AdminPass As String
		Set(value As String)
			_AdminPass = value
		End Set
	End Property

	Public Property ConnectionString As String

	Public ReadOnly Property Username As String
		Get
			Return _Username
		End Get
	End Property

	Public ReadOnly Property IsFirstInstall As Boolean
	Public ReadOnly Property ErrorCondition As Boolean
		Get
			Return _error
		End Get
	End Property

	Public ReadOnly Property IsDone As Boolean
		Get
			Return _isDone
		End Get
	End Property
#End Region

	Private Async Sub Button3_Click(sender As Object, e As EventArgs) Handles Button.Click
		_error = True
		_isDone = False
		If MsgBox("Apakah anda yakin data yang dimasukan sudah benar?", vbExclamation + vbYesNo, "Peringatan") = vbNo Then Exit Sub
		_Username = Uid.Text
		Button.Visible = False
		PictureBox2.Visible = True
		Dim sumber As New CancellationTokenSource(BATAL)
		If isFilled() Then
			If isFirstInstall Then
				Dim koneksi As New NpgsqlConnection(connectionString)
				Try
					Await koneksi.OpenAsync(sumber.Token)
					Dim admin As New NpgsqlCommand(String.Format("SELECT {0}ID_Level{0} FROM public.{0}Level{0} WHERE {0}Nama{0} = 'Administrator';", Chr(34)), koneksi)
					Dim id As Long = Await admin.ExecuteScalarAsync

					Dim baru As New NpgsqlCommand(String.Format("INSERT INTO public.{0}Pengguna{0} " &
																"({0}Username{0},{0}Password{0},{0}Level{0},{0}Nama{0})" &
																" VALUES ('{1}','{2}','{3}','{4}');", Chr(34), "root",
																Crypter.Blowfish.Crypt(Encoding.ASCII.GetBytes("root"),
																Crypter.Blowfish.GenerateSalt()), id, "First Install"), koneksi)
					Await baru.ExecuteNonQueryAsync(sumber.Token)

					Dim register As New Register("root", "root", connectionString)

					'Mendapatkan Level Integer

					If Await register.Register(Uid.Text, Passcode.Text, Level.Text, Nama.Text) Then
						_isSuccess = True
						_error = False
					Else
						_isSuccess = False
					End If

					Dim hapus As New NpgsqlCommand(String.Format("DELETE FROM public.{0}Pengguna{0} WHERE {0}Username{0}='root';", Chr(34)), koneksi)
					Await hapus.ExecuteNonQueryAsync(sumber.Token)

				Catch ex As Exception
					_ErrorMSG = ex.ToString()
					Try
						Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
						Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
						Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

						MsgBox("Terjadi masalah pada saat membuat akun. Lihat file " & Alamat, vbCritical + vbOKOnly, "Kesalahan Server")
						File.WriteAllText(Alamat, ex.ToString())

					Catch fileerror As IOException
						MsgBox("Terjadi masalah pada saat membuat akun serta penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan Server")
					End Try
				End Try
			Else
				Dim register As New Register(_AdminUser, _AdminPass)
				If Await register.Register(Uid.Text, Passcode.Text, Level.Text, Nama.Text) Then
					_isSuccess = True
					MsgBox("Akun telah berhasil dibuat", vbInformation + vbOKOnly, "Pemberitahuan")
					_error = False
				Else
					_isSuccess = False
				End If
			End If
		End If

		Button.Visible = True
		PictureBox2.Visible = False
		Hide()
		_isDone = True
	End Sub

	Private Function IsFilled() As Boolean
		If Not (String.IsNullOrWhiteSpace(Nama.Text) AndAlso String.IsNullOrWhiteSpace(Uid.Text) AndAlso
				String.IsNullOrWhiteSpace(Passcode.Text) AndAlso String.IsNullOrWhiteSpace(Verify.Text) AndAlso
				Level.Text = "Pilih Level" AndAlso String.IsNullOrWhiteSpace(Level.Text)) Then
			If Passcode.Text = Verify.Text Then
				Return True
			Else
				MsgBox("Kolom vertifikasi password dan kolom password berbeda.", vbCritical + vbOKOnly, "Sistem")
			End If
		Else
			MsgBox("Anda belum mengisi semua kotak yang diminta.", vbCritical + vbOKOnly, "Sistem")
		End If
		Return False
	End Function

	Private Async Sub AddUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Dim sumber As New CancellationTokenSource(BATAL)
		Dim koneksi As New NpgsqlConnection(connectionString)
		Try
			Await koneksi.OpenAsync(sumber.Token)
			Dim cmd As New NpgsqlCommand(String.Format("SELECT {0}Nama{0} FROM public.{0}Level{0};", Chr(34)), koneksi)
			Dim read As NpgsqlDataReader = Await cmd.ExecuteReaderAsync(sumber.Token)

			'LINQ BRO :D
			Dim list As List(Of String) =
				(From x As IDataRecord In read
				 Select CType(x(0), String)).ToList

			Level.Items.Clear()
			For Each str As String In list
				Level.Items.Add(str)
			Next
			Level.Update()
			Level.Enabled = True

			If isFirstInstall Then
				Level.Enabled = False
				Level.Text = "Administrator"
			End If
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
			_ErrorMSG = ex.ToString
		End Try
	End Sub
End Class