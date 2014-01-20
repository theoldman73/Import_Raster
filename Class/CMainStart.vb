'########################################################
'      Project start date: 20/12/2013.
'        Project end date: 16/01/2014.
'      File name: CMainStart.vb.
'     Programmer: Amr Zakaria Zaki.
'        E-Mail : amrzakaria73@gmail.com.
'           Date: 16/01/2014.
'           Time: 10:20:00 PM.
'       Version :
'   Project name: ImportRasterIntoPostgres.vbproj
'    Description:
'     1- I use this software to import GIS raster image to Postgres Database.
' Class Related :
'       1- frmMain.
'       2- frmSendFeedBack
'       3- frmAboutRasterImporter
'       4- CHardDisk
'       5- CHardDiskInfo
'       6- CHardWare
'       7- CMacaddress
'       8- CProcessor
'          Math :
'           1- None.
'       Modified:
'         1- None.
'       Example :
'        1-  ImportRasterIntoPostgres.exe img c:\image.jpg.
'########################################################
Imports System.IO
Namespace Import_Raster_IntoPostgres

    Friend NotInheritable Class CMainStart
        Private Sub New()
            '--- Nothing to be implement.
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread()> _
        Shared Sub Main()
            Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
            For i As Integer = 0 To CommandLineArgs.Count - 1
                Select Case CommandLineArgs(i)
                    Case "img"
                        If File.Exists(CommandLineArgs(i + 1)) = True Then
                            'MessageBox.Show(frmSendFeedBack.ReadFrom_Image(CommandLineArgs(i + 1)))
                         Else
                            Exit For
                        End If
                End Select
            Next
            '-------------------------------------------------------
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New frmMain)
            '-----------------------------------------------------

        End Sub
    End Class
End Namespace