'*****************************************************************************
' Nama File : SesiSatu.vb
' Deskripsi : Biodata Diri
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 16 Juni 2018
' Tanggal Edit : 19 Juni 2018
' Copyright PATCH (c) 2018
' ****************************************************************************

Public Class SesiSatu
	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		Dim lanjut As Boolean = True

		'Desain
		If TextBox1.Text = "Nama Lengkap *" Or TextBox2.Text = "Nama Panggilan *" Or
			TextBox4.Text = "Nomor Handphone Aktif *" Or ComboBox1.Text = "Umur *" Then
			lanjut = False
			If ComboBox1.Text = "Umur *" AndAlso Not ComboBox1.BackColor = Color.MistyRose Then
				lanjut = False
				ComboBox1.BackColor = Color.MistyRose
			End If

			If TextBox1.Text = "Nama Lengkap *" AndAlso Not TextBox1.BackColor = Color.MistyRose Then
				lanjut = False
				TextBox1.BackColor = Color.MistyRose
			End If

			If TextBox2.Text = "Nama Panggilan *" AndAlso Not TextBox2.BackColor = Color.MistyRose Then
				lanjut = False
				TextBox2.BackColor = Color.MistyRose
			End If

			If TextBox4.Text = "Nomor Handphone Aktif *" AndAlso Not TextBox4.BackColor = Color.MistyRose Then
				lanjut = False
				TextBox4.BackColor = Color.MistyRose
			End If

			If TextBox6.Text = "Kelas atau Kelompok MPLS *" AndAlso Not TextBox6.BackColor = Color.MistyRose Then
				lanjut = False
				TextBox6.BackColor = Color.MistyRose
			End If
		End If

		If lanjut Then
			Varlist.Nama = TextBox1.Text
			Varlist.Panggilan = TextBox2.Text
			Varlist.Umur = ComboBox1.Text
			Varlist.HP = TextBox4.Text
			Varlist.kelas = TextBox6.Text

			If TextBox3.Text = "Akun Line" OrElse String.IsNullOrWhiteSpace(TextBox3.Text) Then
				Varlist.Line = ""
			Else
				Varlist.Line = TextBox3.Text
			End If

			If TextBox5.Text = "Email" OrElse String.IsNullOrWhiteSpace(TextBox3.Text) Then
				TextBox5.Text = ""
			Else
				Varlist.Email = TextBox5.Text
			End If

			Me.Hide()
			SesiDua.Show()
		Else
			MsgBox("Isilah kolom yang harus diisi!", vbExclamation + vbOKOnly, "Peringatan")
		End If
	End Sub

	'Textbox1
	Private Sub GotFocus1(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
		If TextBox1.Text = "Nama Lengkap *" Then TextBox1.Text = ""
		If TextBox1.BackColor = Color.MistyRose Then TextBox1.BackColor = Color.White
	End Sub

	Private Sub LostFocus1(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
		If String.IsNullOrWhiteSpace(TextBox1.Text) Then
			TextBox1.Text = "Nama Lengkap *"
			TextBox1.BackColor = Color.MistyRose
		End If
	End Sub

	'Textbox2
	Private Sub GotFocus2(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
		If TextBox2.Text = "Nama Panggilan *" Then TextBox2.Text = ""
		If TextBox2.BackColor = Color.MistyRose Then TextBox2.BackColor = Color.White
	End Sub

	Private Sub LostFocus2(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
		If String.IsNullOrWhiteSpace(TextBox2.Text) Then
			TextBox2.Text = "Nama Panggilan *"
			TextBox2.BackColor = Color.MistyRose
		End If
	End Sub

	'Textbox3
	Private Sub GotFocus3(sender As Object, e As EventArgs) Handles TextBox3.GotFocus
		If TextBox3.Text = "Akun Line" Then TextBox3.Text = ""
	End Sub

	Private Sub LostFocus3(sender As Object, e As EventArgs) Handles TextBox3.LostFocus
		If String.IsNullOrWhiteSpace(TextBox3.Text) Then
			TextBox3.Text = "Akun Line"
		End If
	End Sub

	'Textbox4
	Private Sub GotFocus4(sender As Object, e As EventArgs) Handles TextBox4.GotFocus
		If TextBox4.Text = "Nomor Handphone Aktif *" Then TextBox4.Text = ""
		If TextBox4.BackColor = Color.MistyRose Then TextBox4.BackColor = Color.White
	End Sub

	Private Sub LostFocus4(sender As Object, e As EventArgs) Handles TextBox4.LostFocus
		If String.IsNullOrWhiteSpace(TextBox4.Text) Then
			TextBox4.Text = "Nomor Handphone Aktif *"
			TextBox4.BackColor = Color.MistyRose
		End If
	End Sub

	'Textbox5
	Private Sub GotFocus5(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
		If TextBox5.Text = "Email" Then TextBox5.Text = ""
	End Sub

	Private Sub LostFocus5(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
		If String.IsNullOrWhiteSpace(TextBox5.Text) Then
			TextBox5.Text = "Email"
		End If
	End Sub

	'Textbox 6
	Private Sub GotFocus6(sender As Object, e As EventArgs) Handles TextBox6.GotFocus
		If TextBox6.Text = "Kelas atau Kelompok MPLS *" Then TextBox6.Text = ""
		If TextBox6.BackColor = Color.MistyRose Then TextBox6.BackColor = Color.White
	End Sub

	Private Sub LostFocus6(sender As Object, e As EventArgs) Handles TextBox6.LostFocus
		If String.IsNullOrWhiteSpace(TextBox6.Text) Then
			TextBox6.Text = "Kelas atau Kelompok MPLS *"
			TextBox6.BackColor = Color.MistyRose
		End If
	End Sub

	Private Sub SesiSatu_Load(sender As Object, e As EventArgs)
		If Varlist.sesi >= 1 Then
			If Varlist.Line = "" Then
				TextBox3.Text = "Akun Line"
			Else
				TextBox3.Text = Varlist.Line
			End If

			If Varlist.Email = "" Then
				TextBox5.Text = "Email"
			Else
				TextBox5.Text = Varlist.Email
			End If

			TextBox1.Text = Varlist.Nama
			TextBox2.Text = Varlist.Panggilan
			ComboBox1.Text = Varlist.Umur
			TextBox4.Text = Varlist.HP
			TextBox6.Text = Varlist.Kelas
		Else
			Varlist.sesi = 1
		End If
	End Sub
End Class