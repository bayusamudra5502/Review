'*****************************************************************************
' Nama File : Varlist.vb
' Deskripsi : Kumpulan Variabel Progeam
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 14 Juni 2018
' Tanggal Edit : 19 Juni 2018
' Copyright PATCH (c) 2018
' ****************************************************************************

Public Class Varlist
	Public Shared Refresh As Boolean = False
	Public Shared ReadOnly BATAL As Integer = 5000
	Public Shared DB_NAME = ""
	Public Shared DB_USER = ""
	Public Shared DB_PASS = ""
	Public Shared LinePATCH As String
	Public Shared Instagram As String
	Public Shared Web As String

	'Server
	Public Shared Server As String

	'Penampungan Data
	Public Shared sesi As Integer = 0
	'SESI 1 : Biodata diri
	Public Shared Nama As String = ""
	Public Shared Panggilan As String = ""
	Public Shared Umur As String = ""
	Public Shared Line As String = ""
	Public Shared HP As String = ""
	Public Shared Email As String = ""
	Public Shared Kelas As String = ""

	'SESI 2 : Nilai PATCH
	Public Shared nilai As Integer = 5

	'SESI 3 : Kesan
	Public Shared Kesan As String = ""

	'IKUT PATCH?
	Public Shared Ikut As Integer = 2


	Public Shared Sub clear()
		Nama = ""
		Panggilan = ""
		Umur = ""
		Line = ""
		HP = ""
		Email = ""
		nilai = 5
		Kesan = ""
		Ikut = 2
		sesi = 0
	End Sub
End Class