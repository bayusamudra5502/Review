Imports System.Threading

Public Class addLevel
	Dim level As Long = 0
	Dim Username As String
	Dim Password As String
	Dim ConnectionString As String

#Region "Properti"
	Public ReadOnly Property IsDone As Boolean
	Public ReadOnly Property IsSuccess As Boolean
#End Region

	Public Sub New(ByVal ConnectionString As String, ByVal Username As String, ByVal Password As String)

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.
		IsDone = False
		Me.ConnectionString = ConnectionString
		Me.Username = Username
		Me.Password = Password
	End Sub

	Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
		level = 0
		For Each i As String In CheckedListBox1.CheckedItems
			level += 2 ^ (CheckedListBox1.Items.IndexOf(i))
		Next

		Label3.Text = String.Format("Kode Level : {0}", level)
	End Sub

	Private Sub addLevel_Resize(sender As Object, e As EventArgs) Handles Me.Resize
		Dim deltax As Integer = Me.Size.Width - 585
		Dim deltay As Integer = Me.Size.Height - 416

		Nama.Size = New Drawing.Size(333 + deltax, 26)
		CheckedListBox1.Size = New Drawing.Size(333 + deltax, 194 + deltay)

		Label3.Location = New Point(221, 318 + deltay)
	End Sub

	Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
		Button.Visible = False
		PictureBox1.Visible = True
	End Sub

	Private Async Sub TambahData()
		Dim sekering As New CancellationTokenSource(Varlist.BATAL)

		level = 0
		For Each i As String In CheckedListBox1.CheckedItems
			level += 2 ^ (CheckedListBox1.Items.IndexOf(i))
		Next

		Dim daftar As New Register(Username, Password, ConnectionString)
		If Await daftar.RegisterKelas(Nama.Text, level) Then
			_IsSuccess = True
			MsgBox(String.Format("Level '{0}' dengan hak akses '{1}' berhasil dibuat.", Nama.Text, level), vbInformation + vbOK, "Informasi")
		Else
			_IsSuccess = False

		End If

		Close()
		_IsDone = True
	End Sub
End Class