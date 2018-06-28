'=======================================================================================
' Nama File : ExportDatasetToExcel.vb
' Deskripsi : Library Kelas ExportDatasetToExcel
' Pembuat   : Bayu Samudra
' Tanggal Dibuat : 21 Juni 2018
' Tanggal Edit : 21 Juni 2018
' Copyright PATCH (c) 2018
'========================================================================================

Imports System.IO
Imports System.Reflection
Imports Excel = Microsoft.Office.Interop.Excel

Public Structure Pengaturan
	Dim Ukuran As Double
	Dim Nama As String
	Dim WarnaJudul As String
	Dim WarnaSel As String
	Dim SelangSeling As Boolean
End Structure

Public Structure PengaturanTabel
	Dim Nama As String
	Dim NamaHead As String
	Dim PengaturanKolom As List(Of Pengaturan)
End Structure

Public Class ExportDatasetToExcel
	Dim Data As DataSet
	Dim Setting As List(Of PengaturanTabel) = Nothing 'Pertabel per kolom

	Public Sub New(ByVal Data As DataSet)
		Me.Data = Data
	End Sub

	Public Sub New(ByVal Data As DataSet, ByRef Setting As List(Of PengaturanTabel))
		Me.Data = Data
		Me.Setting = Setting
	End Sub

	Public Function Simpan() As Boolean
		Dim hasil = False
		Try
			Dim pengaturan As Missing = Missing.Value

			'Buat Dialog Penyimpanan
			Dim dialog As New SaveFileDialog()
			dialog.Filter = "Berkas Excel |*.xlsx"
			dialog.Title = "Ekspor Data"
			dialog.ShowDialog() 'Buka Dialog
			Dim path As String = dialog.FileName

			If Not String.IsNullOrWhiteSpace(path) Then
				Dim app As New Excel.Application
				Dim workbook As Excel.Workbook = app.Workbooks.Add(1)

				Dim i As Integer = 0

				For Each Data As DataTable In Me.Data.Tables
					Dim ws As Excel.Worksheet =
						workbook.Worksheets.Add(pengaturan, workbook.Sheets(workbook.Sheets.Count),
												1, pengaturan)

					ws.Name = Data.TableName

					'Buat Kepala Dokumen
					If Setting Is Nothing Then
						ws.Cells(2, 2) = Data.TableName 'Isi (1,2)
						ws.Cells(4, 2) = "Tanggal Dibuat : " & Now
						ws.Cells(5, 2) = "Copyright PATCH © 2018 Review"
					Else
						ws.Cells(2, 2) = Setting(i).NamaHead 'Isi (1,2)
						ws.Cells(4, 2) = "Tanggal Dibuat : " & Now
						ws.Cells(5, 2) = "Copyright PATCH © 2018 Review"
					End If

					Dim Range As Excel.Range = ws.Range("B2", karakter(Data.Columns.Count) & "2")
					Range.Merge() 'Buat A5 - Ax MergeCell
					Range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
					Range.Font.Size = 13

					'Isi Data
					If Setting Is Nothing Then
						'Buat Kepala Tabel
						For j As Integer = 0 To Data.Columns.Count - 1
							ws.Cells(7, j + 2) = Data.Columns(j).ColumnName
							ws.Range(karakter(1 + j) & "7").Font.Bold = True
							ws.Range(karakter(1 + j) & "7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							ws.Range(karakter(1 + j) & "7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
						Next

						For j As Integer = 0 To Data.Rows.Count - 1
							For k As Integer = 0 To Data.Columns.Count - 1
								ws.Cells(j + 8, k + 2) = Data.Rows(j).ItemArray(k).ToString
								ws.Range(karakter(1 + k) & (j + 8)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							Next
						Next
					Else
						For j As Integer = 0 To Data.Columns.Count - 1
							ws.Cells(7, j + 2) = Data.Columns(j).ColumnName
							ws.Range(karakter(1 + j) & "7").Interior.Color =
								ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaJudul) 'Warna
							ws.Range(karakter(1 + j) & "7").Font.Bold = True
							ws.Range(karakter(1 + j) & "7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							ws.Range(karakter(1 + j) & "7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
						Next

						For j As Integer = 0 To Data.Rows.Count - 1
							For k As Integer = 0 To Data.Columns.Count - 1
								ws.Cells(j + 8, k + 2) = Data.Rows(j).ItemArray(k).ToString
								ws.Range(karakter(1 + k) & (j + 8)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
								If Not Setting(i).PengaturanKolom(j).SelangSeling Then
									ws.Range(karakter(1 + k) & (j + 8)).Interior.Color =
										ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaSel) 'Warna
								Else
									If j Mod 2 = 0 Then
										ws.Range(karakter(1 + k) & (j + 8)).Interior.Color =
											ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaSel) 'Warna 
									End If
								End If
							Next
						Next
					End If

					ws.Columns.AutoFit()
					i += 1
				Next

				workbook.SaveAs(path, pengaturan, pengaturan, pengaturan, False, pengaturan, Excel.XlSaveAsAccessMode.xlNoChange, pengaturan, pengaturan, pengaturan, pengaturan, pengaturan)
				workbook.Close()
				app.Quit()
				hasil = True
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
		End Try

		Return hasil
	End Function

	Public Function Simpan(Nama As List(Of String)) As Boolean
		Dim hasil As Boolean = False
		Try
			Dim pengaturan As Missing = Missing.Value

			'Buat Dialog Penyimpanan
			Dim dialog As New SaveFileDialog()
			dialog.Filter = "Berkas Excel |*.xlsx"
			dialog.Title = "Ekspor Data"
			dialog.ShowDialog() 'Buka Dialog
			Dim path As String = dialog.FileName

			If Not String.IsNullOrWhiteSpace(path) Then
				Dim app As New Excel.Application
				Dim workbook As Excel.Workbook = app.Workbooks.Add(1)

				Dim i As Integer = 0

				For Each Data As DataTable In Me.Data.Tables
					Dim ws As Excel.Worksheet =
						workbook.Worksheets.Add(pengaturan, workbook.Sheets(workbook.Sheets.Count),
												1, pengaturan)

					ws.Name = Nama(i)

					'Buat Kepala Dokumen
					If Setting Is Nothing Then
						ws.Cells(2, 2) = Nama(i) 'Isi (1,2)
						ws.Cells(4, 2) = "Tanggal Dibuat : " & Now
						ws.Cells(5, 2) = "Copyright PATCH © 2018 Review"
					Else
						ws.Cells(2, 2) = Setting(i).NamaHead 'Isi (1,2)
						ws.Cells(4, 2) = "Tanggal Dibuat : " & Now
						ws.Cells(5, 2) = "Copyright PATCH © 2018 Review"
					End If

					Dim Range As Excel.Range = ws.Range("B2", karakter(Data.Columns.Count) & "2")
					Range.Merge() 'Buat A5 - Ax MergeCell
					Range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
					Range.Font.Size = 13

					'Isi Data
					If Setting Is Nothing Then
						'Buat Kepala Tabel
						For j As Integer = 0 To Data.Columns.Count - 1
							ws.Cells(7, j + 2) = Data.Columns(j).ColumnName
							ws.Range(karakter(1 + j) & "7").Font.Bold = True
							ws.Range(karakter(1 + j) & "7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							ws.Range(karakter(1 + j) & "7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
						Next

						For j As Integer = 0 To Data.Rows.Count - 1
							For k As Integer = 0 To Data.Columns.Count - 1
								ws.Cells(j + 8, k + 2) = Data.Rows(j).ItemArray(k).ToString
								ws.Range(karakter(1 + k) & (j + 8)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							Next
						Next
					Else
						For j As Integer = 0 To Data.Columns.Count - 1
							ws.Cells(7, j + 2) = Data.Columns(j).ColumnName
							ws.Range(karakter(1 + j) & "7").Interior.Color =
								ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaJudul) 'Warna
							ws.Range(karakter(1 + j) & "7").Font.Bold = True
							ws.Range(karakter(1 + j) & "7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							ws.Range(karakter(1 + j) & "7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
						Next

						For j As Integer = 0 To Data.Rows.Count - 1
							For k As Integer = 0 To Data.Columns.Count - 1
								ws.Cells(j + 8, k + 2) = Data.Rows(j).ItemArray(k).ToString
								ws.Range(karakter(1 + k) & (j + 8)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
								If Not Setting(i).PengaturanKolom(j).SelangSeling Then
									ws.Range(karakter(1 + k) & (j + 8)).Interior.Color =
										ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaSel) 'Warna
								Else
									If j Mod 2 = 0 Then
										ws.Range(karakter(1 + k) & (j + 8)).Interior.Color =
											ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaSel) 'Warna 
									End If
								End If
							Next
						Next
					End If

					ws.Columns.AutoFit()
					i += 1
				Next

				workbook.SaveAs(path, pengaturan, pengaturan, pengaturan, False, pengaturan, Excel.XlSaveAsAccessMode.xlNoChange, pengaturan, pengaturan, pengaturan, pengaturan, pengaturan)
				workbook.Close()
				app.Quit()
				hasil = True
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
		End Try
		Return hasil
	End Function

	Public Function Simpan(Path As String) As Boolean
		Dim hasil As Boolean = False
		Try
			Dim pengaturan As Missing = Missing.Value

			'Buat Dialog Penyimpanan

			If Not String.IsNullOrWhiteSpace(Path) Then
				Dim app As New Excel.Application
				Dim workbook As Excel.Workbook = app.Workbooks.Add(1)

				Dim i As Integer = 0

				For Each Data As DataTable In Me.Data.Tables
					Dim ws As Excel.Worksheet =
						workbook.Worksheets.Add(pengaturan, workbook.Sheets(workbook.Sheets.Count),
												1, pengaturan)

					ws.Name = Data.TableName

					'Buat Kepala Dokumen
					If Setting Is Nothing Then
						ws.Cells(2, 2) = Data.TableName 'Isi (1,2)
						ws.Cells(4, 2) = "Tanggal Dibuat : " & Now
						ws.Cells(5, 2) = "Copyright PATCH © 2018 Review"
					Else
						ws.Cells(2, 2) = Setting(i).NamaHead 'Isi (1,2)
						ws.Cells(4, 2) = "Tanggal Dibuat : " & Now
						ws.Cells(5, 2) = "Copyright PATCH © 2018 Review"
					End If

					Dim Range As Excel.Range = ws.Range("B2", karakter(Data.Columns.Count) & "2")
					Range.Merge() 'Buat A5 - Ax MergeCell
					Range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
					Range.Font.Size = 13

					'Isi Data
					If Setting Is Nothing Then
						'Buat Kepala Tabel
						For j As Integer = 0 To Data.Columns.Count - 1
							ws.Cells(7, j + 2) = Data.Columns(j).ColumnName
							ws.Range(karakter(1 + j) & "7").Font.Bold = True
							ws.Range(karakter(1 + j) & "7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							ws.Range(karakter(1 + j) & "7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
						Next

						For j As Integer = 0 To Data.Rows.Count - 1
							For k As Integer = 0 To Data.Columns.Count - 1
								ws.Cells(j + 8, k + 2) = Data.Rows(j).ItemArray(k).ToString
								ws.Range(karakter(1 + k) & (j + 8)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							Next
						Next
					Else
						For j As Integer = 0 To Data.Columns.Count - 1
							ws.Cells(7, j + 2) = Data.Columns(j).ColumnName
							ws.Range(karakter(1 + j) & "7").Interior.Color =
								ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaJudul) 'Warna
							ws.Range(karakter(1 + j) & "7").Font.Bold = True
							ws.Range(karakter(1 + j) & "7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							ws.Range(karakter(1 + j) & "7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
						Next

						For j As Integer = 0 To Data.Rows.Count - 1
							For k As Integer = 0 To Data.Columns.Count - 1
								ws.Cells(j + 8, k + 2) = Data.Rows(j).ItemArray(k).ToString
								ws.Range(karakter(1 + k) & (j + 8)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
								If Not Setting(i).PengaturanKolom(j).SelangSeling Then
									ws.Range(karakter(1 + k) & (j + 8)).Interior.Color =
										ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaSel) 'Warna
								Else
									If j Mod 2 = 0 Then
										ws.Range(karakter(1 + k) & (j + 8)).Interior.Color =
											ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaSel) 'Warna 
									End If
								End If
							Next
						Next
					End If

					ws.Columns.AutoFit()
					i += 1
				Next

				workbook.SaveAs(Path, pengaturan, pengaturan, pengaturan, False, pengaturan, Excel.XlSaveAsAccessMode.xlNoChange, pengaturan, pengaturan, pengaturan, pengaturan, pengaturan)
				workbook.Close()
				app.Quit()
				hasil = True
			End If
		Catch ex As Exception
			Try
				Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
				Directory.CreateDirectory(IO.Path.Combine(APPDATA, "Review"))
				Dim Alamat As String = IO.Path.Combine(APPDATA, "Review", Now() & ".log")

				MsgBox("Terjadi masalah pada pengaturan sistem. Lihat file " & Alamat, vbCritical + vbOKOnly, "Kesalahan Server")
				File.WriteAllText(Alamat, ex.ToString())

			Catch fileerror As IOException
				MsgBox("Terjadi masalah dengan pengaturan sistem serta penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan Server")
			End Try
		End Try
		Return hasil
	End Function

	Public Function Simpan(Path As String, Nama As List(Of String)) As Boolean
		Dim hasil As Boolean = False
		Try
			Dim pengaturan As Missing = Missing.Value

			'Buat Dialog Penyimpanan

			If Not String.IsNullOrWhiteSpace(Path) Then
				Dim app As New Excel.Application
				Dim workbook As Excel.Workbook = app.Workbooks.Add(1)

				Dim i As Integer = 0

				For Each Data As DataTable In Me.Data.Tables
					Dim ws As Excel.Worksheet =
						workbook.Worksheets.Add(pengaturan, workbook.Sheets(workbook.Sheets.Count),
												1, pengaturan)

					ws.Name = Nama(i)

					'Buat Kepala Dokumen
					If Setting Is Nothing Then
						ws.Cells(2, 2) = Nama(i) 'Isi (1,2)
						ws.Cells(4, 2) = "Tanggal Dibuat : " & Now
						ws.Cells(5, 2) = "Copyright PATCH © 2018 Review"
					Else
						ws.Cells(2, 2) = Setting(i).NamaHead 'Isi (1,2)
						ws.Cells(4, 2) = "Tanggal Dibuat : " & Now
						ws.Cells(5, 2) = "Copyright PATCH © 2018 Review"
					End If

					Dim Range As Excel.Range = ws.Range("B2", karakter(Data.Columns.Count) & "2")
					Range.Merge() 'Buat A5 - Ax MergeCell
					Range.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
					Range.Font.Size = 13

					'Isi Data
					If Setting Is Nothing Then
						'Buat Kepala Tabel
						For j As Integer = 0 To Data.Columns.Count - 1
							ws.Cells(7, j + 2) = Data.Columns(j).ColumnName
							ws.Range(karakter(1 + j) & "7").Font.Bold = True
							ws.Range(karakter(1 + j) & "7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							ws.Range(karakter(1 + j) & "7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
						Next

						For j As Integer = 0 To Data.Rows.Count - 1
							For k As Integer = 0 To Data.Columns.Count - 1
								ws.Cells(j + 8, k + 2) = Data.Rows(j).ItemArray(k).ToString
								ws.Range(karakter(1 + k) & (j + 8)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							Next
						Next
					Else
						For j As Integer = 0 To Data.Columns.Count - 1
							ws.Cells(7, j + 2) = Data.Columns(j).ColumnName
							ws.Range(karakter(1 + j) & "7").Interior.Color =
								ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaJudul) 'Warna
							ws.Range(karakter(1 + j) & "7").Font.Bold = True
							ws.Range(karakter(1 + j) & "7").Borders.LineStyle = Excel.XlLineStyle.xlContinuous
							ws.Range(karakter(1 + j) & "7").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
						Next

						For j As Integer = 0 To Data.Rows.Count - 1
							For k As Integer = 0 To Data.Columns.Count - 1
								ws.Cells(j + 8, k + 2) = Data.Rows(j).ItemArray(k).ToString
								ws.Range(karakter(1 + k) & (j + 8)).Borders.LineStyle = Excel.XlLineStyle.xlContinuous
								If Not Setting(i).PengaturanKolom(j).SelangSeling Then
									ws.Range(karakter(1 + k) & (j + 8)).Interior.Color =
										ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaSel) 'Warna
								Else
									If j Mod 2 = 0 Then
										ws.Range(karakter(1 + k) & (j + 8)).Interior.Color =
											ColorTranslator.FromHtml(Setting(i).PengaturanKolom(j).WarnaSel) 'Warna 
									End If
								End If
							Next
						Next
					End If

					ws.Columns.AutoFit()
					i += 1
				Next

				workbook.SaveAs(Path, pengaturan, pengaturan, pengaturan, False, pengaturan, Excel.XlSaveAsAccessMode.xlNoChange, pengaturan, pengaturan, pengaturan, pengaturan, pengaturan)
				workbook.Close()
				app.Quit()
				hasil = True
			End If
		Catch ex As Exception
			Try
				Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
				Directory.CreateDirectory(IO.Path.Combine(APPDATA, "Review"))
				Dim Alamat As String = IO.Path.Combine(APPDATA, "Review", Now() & ".log")

				MsgBox("Terjadi masalah pada pengaturan sistem. Lihat file " & Alamat, vbCritical + vbOKOnly, "Kesalahan Server")
				File.WriteAllText(Alamat, ex.ToString())

			Catch fileerror As IOException
				MsgBox("Terjadi masalah dengan pengaturan sistem serta penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan Server")
			End Try
		End Try
		Return hasil
	End Function

	'Fungsi pengubah angka menjadi karakter dengan O(n) = log n / log 26
	'Asumsi : A = 0
	Private Function karakter(i As Integer) As String 'Fungsi Rekursif
		Dim hasil As String
		If i > 25 Then 'Kondisi
			Dim sisa As Integer = i Mod 26
			hasil = Chr(sisa + 65) & karakter(i \ 26) 'Rekurens
			hasil = Reverse(hasil)
		Else
			hasil = Chr(i + 65) 'Basis
		End If

		Return hasil
	End Function

	Private Function Reverse(str As String) As String
		Dim chr As Char() = str.ToCharArray
		Array.Reverse(chr)
		Return New String(chr)
	End Function
End Class
