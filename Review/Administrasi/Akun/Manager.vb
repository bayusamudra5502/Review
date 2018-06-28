Imports Npgsql
Imports System.Threading
Imports System.IO
Imports System.ComponentModel

Public Class Manager
	Dim onErrorState As Boolean = False
	Dim connectionString As String =
			String.Format("Host={0};Database={1};Username={2};Password={3};",
										Varlist.Server, Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS)

	Dim Username As String
	Dim Password As String

	Public Sub New(ByVal Username As String, ByVal Password As String)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		Me.Username = Username
		Me.Password = Password
	End Sub

	Private Async Sub Perbarui()
		Label2.Visible = True
		PictureBox3.Visible = True

		Dim cmdtblLevel As String = String.Format("SELECT * FROM public.{0}Level{0};", Chr(34))
		Dim cmdtblPengguna As String = String.Format("SELECT * FROM public.{0}Pengguna{0};", Chr(34))


		Dim sekering As New CancellationTokenSource(Varlist.BATAL)
		Dim koneksi As New NpgsqlConnection(connectionString)

		Try
			Await koneksi.OpenAsync(sekering.Token)
			Dim cmd2 As New NpgsqlCommand(cmdtblPengguna, koneksi)

			Dim DA1 As New NpgsqlDataAdapter(cmdtblLevel, koneksi)
			Dim DA2 As New NpgsqlDataAdapter(cmdtblPengguna, koneksi)

			Dim DS1 As New DataSet
			Dim DS2 As New DataSet

			Await Task.Run(Sub()
							   DA1.Fill(DS1)
						   End Sub, sekering.Token)

			Await Task.Run(Sub()
							   DA2.Fill(DS2)
						   End Sub, sekering.Token)

			LblJmlPengguna.Text = String.Format("{0} Pengguna", DS2.Tables(0).Rows.Count)
			LblLevel.Text = String.Format("{0} Level", DS1.Tables(0).Rows.Count)

			Dim source As New BindingSource
			source.DataSource = DS1
			source.DataMember = DS1.Tables(0).ToString
			DGVLevel.DataSource = source

			Dim source2 As New BindingSource
			source2.DataSource = DS2
			source2.DataMember = DS2.Tables(0).ToString
			DGVPengguna.DataSource = source2

		Catch e As TaskCanceledException
			MsgBox(String.Format("Proses update dibatalkan karena telah melebihi {0} detik.", Varlist.BATAL / 1000), vbCritical + vbOKOnly, "Operasi Dibatalkan")

		Catch ex As Exception
			OnError()
		Finally
			Label2.Visible = False
			PictureBox3.Visible = False

			koneksi.Close()
		End Try
	End Sub

	Private Sub OnError()
		Updater.Enabled = False
		Label2.Visible = False
		PictureBox3.Visible = False

		Label21.Visible = True
		PictureBox4.Visible = True

		onErrorState = True
	End Sub

	Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click
		If onErrorState Then
			onErrorState = False
			Label21.Visible = False
			PictureBox4.Visible = False

			Perbarui()
		End If
	End Sub

	Private Async Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
		Dim addUser As New AddUser(connectionString, Username, Password)
		addUser.Show()

		'Tunggu Nepi ka selesai
		Await Task.Run(Sub()
						   While Not addUser.IsDone
						   End While
					   End Sub)

		If addUser.IsSuccess = True Then
			MsgBox("Pengguna berhasil dibuat.", vbInformation + vbOKOnly, "Informasi")
		Else
			Dim ex As String = addUser.ErrorMessage
			Try
				Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
				Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
				Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

				MsgBox("Pengguna gagal dibuat. Lihat file log untuk detail kesalan : " & Alamat,
					   vbCritical + vbOKOnly, "Kesalahan Server")
				File.WriteAllText(Alamat, ex.ToString())

			Catch fileerror As IOException
				MsgBox("Terjadi masalah dengan sambungan server serta penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan Server")

			End Try
		End If

		Perbarui()
	End Sub

	Private Async Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
		Dim addLevel As New addLevel(connectionString, Username, Password)
		addLevel.Show()

		Await Task.Run(Sub()
						   While Not addLevel.IsDone
						   End While
					   End Sub)

		Perbarui()
	End Sub

	Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Perbarui()
	End Sub

	Private Sub Manager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		SettingVerify.Close()
	End Sub
End Class