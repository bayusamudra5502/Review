Imports System.Configuration
Imports Npgsql

Public Class SettingVerify2
	Dim loads As Boolean = False

	Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Button1.Visible = False
		PictureBox3.Visible = True

		loads = True

		Dim masuk As New Login(Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS, Varlist.Server)

		Dim hasil As Boolean = Await masuk.login(Username.Text, Password.Text, 32) AndAlso Await _
			masuk.login(Username.Text, Password.Text, 33) AndAlso Await masuk.login(Username.Text, Password.Text, 34) _
			AndAlso Await masuk.login(Username.Text, Password.Text, 38)

		If hasil Then
			MsgBox(String.Format("Anda diberi akses. Halo {0}!", ConfigurationManager.AppSettings("UserID")), vbInformation + vbOKOnly, "Informasi Sistem")
			Me.Hide()

			Dim Koneksi = New NpgsqlConnection(String.Format("Host={0};Database={1};Username={2};Password={3};", Varlist.Server, Varlist.DB_NAME, Varlist.DB_USER, Varlist.DB_PASS))
			Await Koneksi.OpenAsync

			Dim saya As New NpgsqlCommand(String.Format("SELECT {0}ID_Level{0} FROM public.{0}Level{0} WHERE {0}Nama{0} = 'Administrator';", Chr(34)), koneksi)
			Dim id As Long = Await saya.ExecuteScalarAsync

			Dim data As New Setting(Username.Text, Password.Text, id)
			data.Show()

			Await Task.Run(Sub()
							   While Not data.IsDone
							   End While
						   End Sub)

			If Not data.IsChanged Then
				Admin.Show()
				Close()
			Else
				If MsgBox("Apakah anda ingin memulai ulang aplikasi 'Review' untuk melihat perubahan?", vbQuestion + vbYesNo, "Sistem") = vbYes Then
					Application.Restart()
				Else
					Admin.Show()
					Close()
				End If
			End If

		Else
			Button1.Visible = True
			PictureBox3.Visible = False
		End If

		loads = False
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

	Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
		End
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

	Private Sub Verify_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class