'=======================================================================================
' Nama File : Varlist.vb
' Deskripsi : Library Login
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 14 Juni 2018
' Tanggal Edit : 20 Juni 2018
' Copyright PATCH (c) 2018
'========================================================================================

Imports System.Configuration
Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Win32

Public Class Form1
	Const BATAL As Integer = 5000
	Dim loads As Boolean = False

	Public Sub New()
		InitializeComponent()
		Server.Text = Varlist.Server
	End Sub

	Private Sub Username_GotFocus(sender As Object, e As EventArgs) Handles Username.GotFocus
		If Username.Text = "Username" Then Username.Text = ""
	End Sub

	Private Sub Username_LostFocus(sender As Object, e As EventArgs) Handles Username.LostFocus
		If String.IsNullOrWhiteSpace(Username.Text) Then
			Username.Text = "Username"
		End If
	End Sub

	Private Sub pic_Clickdown(sender As Object, e As EventArgs) Handles pic.MouseDown
		Password.PasswordChar = ""
	End Sub

	Private Sub pic_Clickup(sender As Object, e As EventArgs) Handles pic.MouseUp
		If Not Password.Text = "Password" Then Password.PasswordChar = "•"
	End Sub

	Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
		If loads Then
			MsgBox("Anda tidak bisa keluar saat proses login masih berlangsung.", vbExclamation + vbOKOnly, "Peringatan")
		Else
			End
		End If
	End Sub


	Private Sub Password_GotFocus(sender As Object, e As EventArgs) Handles Password.GotFocus
		If Password.Text = "Password" Then
			Password.Text = ""
			Password.PasswordChar = "•"
		End If
	End Sub

	Private Sub Password_LostFocus(sender As Object, e As EventArgs) Handles Password.LostFocus
		If String.IsNullOrWhiteSpace(Password.Text) Then
			Password.PasswordChar = ""
			Password.Text = "Password"
		End If

	End Sub

	Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
		Button1.BackColor = Color.Gray
	End Sub

	Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
		Button1.BackColor = Color.White
	End Sub

	Private Sub Button1_Leave(sender As Object, e As EventArgs) Handles Button1.Leave
		Button1.BackColor = Color.White
	End Sub

	Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Button1.Visible = False
		PictureBox3.Visible = True

		loads = True
		Varlist.Server = Server.Text

		Dim masuk As New Login(Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS, Varlist.Server)
		Dim tugas As Task(Of Boolean) = masuk.login(Username.Text, Password.Text, 38)
		Dim hasil As Boolean = Await tugas

		If hasil Then
			Await Task.Run(Sub()
							   RefreshConnectionString()
						   End Sub)

			MsgBox(String.Format("Login Sukses. Halo {0}!", ConfigurationManager.AppSettings("UserID")), vbInformation + vbOKOnly, "Informasi Sistem")
			Utama.Show()
			loads = False
			Me.Hide()
		Else
			Button1.Visible = True
			PictureBox3.Visible = False
			loads = False
		End If
	End Sub

	Protected Overrides Sub WndProc(ByRef m As Message)
		Select Case m.Msg
			Case &H84
				MyBase.WndProc(m)
				If (CType(m.Result, Integer) = &H1) Then
					m.Result = CType(&H2, IntPtr)
				End If
				Return
		End Select
		MyBase.WndProc(m)
	End Sub

	Private Sub Server_GotFocus(sender As Object, e As EventArgs) Handles Server.GotFocus
		If Server.Text = "Server" Then Server.Text = ""
	End Sub

	Private Sub Server_LostFocus(sender As Object, e As EventArgs) Handles Server.LostFocus
		If String.IsNullOrWhiteSpace(Server.Text) Then
			Server.Text = "Server"
		End If
	End Sub


	Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
		If loads Then
			MsgBox("Anda tidak bisa keluar saat proses login masih berlangsung.", vbExclamation + vbOKOnly, "Peringatan")
			e.Cancel = True
		End If
	End Sub

	Private Sub RefreshConnectionString()
		Try
			Dim str As String = String.Format("Host={0};Database={1};Username={2};Password={3};Persist Security Info=True;",
										  Varlist.Server, Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS)

			Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
			config.ConnectionStrings.ConnectionStrings(
			"Review.My.MySettings.PATCHConnectionString").ConnectionString = str

			config.Save(ConfigurationSaveMode.Modified, True)
			ConfigurationManager.RefreshSection("connectionStrings")
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
