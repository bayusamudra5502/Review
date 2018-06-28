Public Class Pengolahan
	Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
		With ComboBox1

			'Pendaftaran Lengkap
			If .Text = "Biodata" Then
				frmBiodataOverview.Show()
				Close()
			ElseIf .Text = "Pendaftaran" Then
				Daftar1.Show()
				Close()
			ElseIf .Text = "Penilaian" Then
				frmLPenilaian.Show()
				Close()
			ElseIf .Text = "Pendaftaran Lengkap" Then
				frmLDaftar2.Show()
				Close()
			Else
				MsgBox("Anda harus memilih setidaknya satu data untuk diprantinjau.", vbExclamation + vbOKOnly, "Peringatan")
			End If
		End With
	End Sub
End Class