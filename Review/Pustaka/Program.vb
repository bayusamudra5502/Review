Imports System.IO

Module Program
	Sub Main(ByVal cmdArgs() As String)
		If cmdArgs.Length = 0 Then
			Try
				Console.WriteLine("Review v.1.8.35.8")
				Console.WriteLine("Copyright PATCH © 2018")
				Console.WriteLine()

				Dim data As Integer = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review\Install", "FirstInstall", -1)
				If data = 0 Then

					Varlist.Server = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "SERVER", "Server").ToString
					Varlist.DB_NAME = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "DB_NAME", "").ToString
					Varlist.DB_PASS = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "DB_PASS", "").ToString
					Varlist.DB_USER = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "DB_USER", "").ToString

					Varlist.LinePATCH = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "LINE", "").ToString
					Varlist.Instagram = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "INSTAGRAM", "").ToString
					Varlist.Web = My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Review", "WEB", "").ToString

					If String.IsNullOrEmpty(Varlist.DB_NAME) OrElse String.IsNullOrEmpty(Varlist.DB_PASS) OrElse String.IsNullOrEmpty(Varlist.DB_USER) OrElse
						String.IsNullOrEmpty(Varlist.LinePATCH) OrElse String.IsNullOrEmpty(Varlist.Instagram) OrElse String.IsNullOrEmpty(Varlist.Web) Then
						If MsgBox("Kami mendeteksi bahwa terdapat pengaturan sistem yang cacat. Apakah anda ingin memperbaiki pengaturan?", vbExclamation + vbYesNo, "Peringatan") = vbYes Then
							Application.EnableVisualStyles()
							Application.SetCompatibleTextRenderingDefault(False)
							Application.Run(New FirstInstall)

							Application.Restart()
						Else
							Throw New Exception("KESALAHAN : PENGATURAN TIDAK BOLEH KOSONG")
						End If
					Else
						Application.EnableVisualStyles()
						Application.SetCompatibleTextRenderingDefault(False)
						Application.Run(New Form1)
					End If
				ElseIf data = 1 Then
					Application.EnableVisualStyles()
					Application.SetCompatibleTextRenderingDefault(False)
					Application.Run(New FirstInstall)

					Application.Restart()
				Else
					MsgBox("Terjadi masalah pada pengaturan sistem. Cobalah untuk menginstall ulang program", vbCritical + vbOKOnly, "Kesalahan Sistem")
					Throw New Exception("KESALAHAN : GAGAL MEMBUKA PENGATURAN PEMASANGAN.")
				End If

			Catch ex As Exception
				Try
					Dim APPDATA As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
					Directory.CreateDirectory(Path.Combine(APPDATA, "Review"))
					Dim Alamat As String = Path.Combine(APPDATA, "Review", Now() & ".log")

					MsgBox("Terjadi masalah pada pengaturan sistem. Lihat file " & Alamat, vbCritical + vbOKOnly, "Kesalahan Server")
					File.WriteAllText(Alamat, ex.ToString())

					End
				Catch fileerror As IOException
					MsgBox("Terjadi masalah dengan pengaturan sistem serta penyimpanan log.", vbCritical + vbOKOnly, "Kesalahan Server")
					End
				End Try
			End Try
		Else
			Console.WriteLine("Review v.1.8.35.8")
			Console.WriteLine("Copyright PATCH © 2018")
			Console.WriteLine("")
			If cmdArgs(0) = "--help" Then
				Process.Start(Path.Combine(Application.StartupPath, "docs", "help.chm"))
			ElseIf cmdArgs(0) = "--first-install" Then
				Application.EnableVisualStyles()
				Application.SetCompatibleTextRenderingDefault(False)
				Application.Run(New FirstInstall)

				MsgBox("Sistem sudah dikonfigurasi ulang.", vbInformation + vbOKOnly, "Pemberitahuan")
			End If
		End If
	End Sub
End Module
