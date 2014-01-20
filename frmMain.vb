'########################################################
'      File name: frmMain.vb.
'     Programmer: Amr Zakaria Zaki.
'        E-Mail : amrzakaria73@gmail.com.
'           Date: 20/12/2013.
'           Time: 09:20:00 PM.
'       Version :
'   Project name: ImportRasterIntoPostgres.vbproj
'    Description:
'     1- I use this software to import GIS raster image to Postgres Database.
' Class Related :
'       1- CCheckTextBox.
'          Math :
'           1- None.
'       Modified:
'         1- None.
'       Example :
'        1-  None.
'########################################################
Imports System.IO
Imports System.Net
Imports Npgsql
Imports ImportRasterIntoPostgres.CheckNetwork

Public Class frmMain
#Region "Form"
    Private UserSetting As New CSetting
    Private UserSettingFilename As String = String.Format("{0}\user_setting.set", Directory.GetCurrentDirectory())
    Private WithEvents CheckTextBox As New CCheckTextBox
    Public Shared strInfo As String = String.Empty

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
        If File.Exists(UserSettingFilename) = True Then
            Try
                UserSetting = Read_Structure(UserSettingFilename)
                If UserSetting Is Nothing Then
                    Debug.Print("frmMain.frmMain_Load.Erro: user setting not loaded")
                End If
                '---------------------------------------------------------------
                cmbPresetting.Text = UserSetting.ChooseSetting
                txtPathExe.Text = UserSetting.Path_raster_pgsql
                cmdSRID.Text = UserSetting.SRIDNO
                chkSRID.Checked = UserSetting.SRID
                chkIb.Checked = UserSetting.I
                chkCb.Checked = UserSetting.C
                chkMb.Checked = UserSetting.M
                txtPathRaster.Text = UserSetting.Path_Image
                chkFb.Checked = UserSetting.f
                chkAs.Checked = UserSetting.a
                chkTs.Checked = UserSetting.t
                txtTileSize.Text = UserSetting.TileSize
                txtTablename.Text = UserSetting.Table
                chkUsername.Checked = UserSetting.U
                txtUsername.Text = UserSetting.Username
                chkDs.Checked = UserSetting.d
                txtDatabasename.Text = UserSetting.Database
                chkHs.Checked = UserSetting.h
                txtServer.Text = UserSetting.IP
                chkPs.Checked = UserSetting.p
                txtPort.Text = UserSetting.Port
                chkFs.Checked = UserSetting.F_COL
                txtFs.Text = UserSetting.Column
                txtPassword.Text = UserSetting.Password
                chkNb.Checked = UserSetting.N
                chkRs.Checked = UserSetting.r
                chkEs.Checked = UserSetting.e
                chkBand.Checked = UserSetting.b
                txtBand.Text = UserSetting.Band
                txtPerview.Text = UserSetting.Perview
            Catch ex As Exception
                Debug.Print("frmMain.frmMain_Load.Erro: user setting not loaded")
            End Try
        End If

        '------------------------------------------------
        ' Default import setting by azz.
        cmbPresetting.Items.Add("Default import Setting")
        ' Default append setting by azz.
        cmbPresetting.Items.Add("Default append Setting")
        '--- (1) Create New Table.
        '--- (1.1) With Default Table[myrasters].
        '--- Server Side.
        cmbPresetting.Items.Add("Create new table(myrasters) and add image[Server+Port Number]")
        cmbPresetting.Items.Add("Create new table(myrasters) and add image[Server]")
        '--- local side.
        cmbPresetting.Items.Add("Create new table(myrasters) and add image[Localhost]")
        cmbPresetting.Items.Add("Create new table(myrasters) and add image[Localhost+Port Number]")
        '---- (1.2)  With New Table[My Table].
        '--- Server Side.
        cmbPresetting.Items.Add("Create new table(New Table) and add image[Server+Port Number]")
        cmbPresetting.Items.Add("Create new table(New Table) and add image[Server]")
        '--- local side.
        cmbPresetting.Items.Add("Create new table(New Table) and add image[Localhost]")
        cmbPresetting.Items.Add("Create new table(New Table) and add image[Localhost+Port Number]")
        '---- (1.3) With Default Table[myrasters] and new column[New Column].
        '--- Server Side.
        cmbPresetting.Items.Add("Create new table(myrasters) with column(New Column) and add image[Server+Port Number]")
        cmbPresetting.Items.Add("Create new table(myrasters) with column(New Column) and add image[Server]")
        '--- local side.
        cmbPresetting.Items.Add("Create new table(myrasters) with column(New Column) and add image[Localhost]")
        cmbPresetting.Items.Add("Create new table(myrasters) with column(New Column) and add image[Localhost+Port Number]")
        '---- (1.4)  With New Table[My Table]  and new column[New Column]..
        '--- Server Side.
        cmbPresetting.Items.Add("Create new table(New Table) with column(New Column) and add image[Server+Port Number]")
        cmbPresetting.Items.Add("Create new table(New Table) with column(New Column) and add image[Server]")
        '--- local side [index :8,9].
        cmbPresetting.Items.Add("Create new table(New Table) with column(New Column) and add image[Localhost]")
        cmbPresetting.Items.Add("Create new table(New Table) with column(New Column) and add image[Localhost+Port Number]")
        '--- (2) Append To Table.
        '--- (2.1) With Default Table[myrasters].
        '--- Server Side.
        cmbPresetting.Items.Add("Append to table(myrasters) Image[Server+Port Number]")
        cmbPresetting.Items.Add("Append to table(myrasters) Image[Server]")
        '--- local side.
        cmbPresetting.Items.Add("Append to table(myrasters) Image[Localhost]")
        cmbPresetting.Items.Add("Append to table(myrasters) Image[Localhost+Port Number]")
        '---- (2.2)  With New Table[My Table].
        '--- Server Side.
        cmbPresetting.Items.Add("Append to table(New Table) Image[Server+Port Number]")
        cmbPresetting.Items.Add("Append to table(New Table) Image[Server]")
        '--- local side.
        cmbPresetting.Items.Add("Append to table(New Table) Image[Localhost]")
        cmbPresetting.Items.Add("Append to table(New Table) Image[Localhost+Port Number]")
        '---- (2.3) With Default Table[myrasters] and new column[New Column].
        '--- Server Side.
        cmbPresetting.Items.Add("Append to table(myrasters) with column(New Column) Image[Server+Port Number]")
        cmbPresetting.Items.Add("Append to table(myrasters) with column(New Column) Image[Server]")
        '--- local side.
        cmbPresetting.Items.Add("Append to table(myrasters) with column(New Column) Image[Localhost]")
        cmbPresetting.Items.Add("Append to table(myrasters) with column(New Column) Image[Localhost+Port Number]")
        '---- (2.4)  With New Table[My Table]  and new column[New Column]..
        '--- Server Side.
        cmbPresetting.Items.Add("Append to table(New Table) with column(New Column) Image[Server+Port Number]")
        cmbPresetting.Items.Add("Append to table(New Table) with column(New Column) Image[Server]")
        '--- local side.
        cmbPresetting.Items.Add("Append to table(New Table) with column(New Column) Image[Localhost]")
        cmbPresetting.Items.Add("Append to table(New Table) with column(New Column) Image[Localhost+Port Number]")
        '--- default setting.
        cmbPresetting.SelectedIndex = 0
        '----------------------------------
        If String.IsNullOrEmpty(strInfo) = False Then
            txtPerview.Text = strInfo
        End If
        '-------------------------------
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
           Case Keys.F10
                cmbPresetting.SelectedIndex = 0
                txtPathExe.Text = "C:\Program Files\PostgreSQL\9.3\bin"
                cmdSRID.Text = "4326"
                chkSRID.Checked = False
                chkIb.Checked = False
                chkCb.Checked = False
                chkMb.Checked = False
                txtPathRaster.Text = "c://image//raster.jpg"
                chkFb.Checked = False
                chkAs.Checked = False
                chkTs.Checked = False
                txtTileSize.Text = "600x800"
                txtTablename.Text = "public.table"
                chkUsername.Checked = False
                txtUsername.Text = "username"
                chkDs.Checked = False
                txtDatabasename.Text = "database"
                chkHs.Checked = False
                txtServer.Text = "127.0.0.1"
                chkPs.Checked = False
                txtPort.Text = "5432"
                chkFs.Checked = False
                txtFs.Text = "rast"
                txtPassword.Text = "password"
                chkNb.Checked = False
                chkRs.Checked = False
                chkEs.Checked = False
                chkBand.Checked = False
                txtBand.Text = "1,2,3"
                txtPerview.Text = String.Empty
        End Select
    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Save_Setting()
    End Sub
#Region "Form Control"
#Region "Button"
    Private Sub btnPath_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPath.Click
        '%ProgramFiles(x86)%
        '%ProgramFiles%
        fbdShow.SelectedPath = Environment.GetEnvironmentVariable("ProgramFiles")
        fbdShow.Description = "To choose  raster2pgsql.exe path"
        fbdShow.ShowDialog()
        If Directory.Exists(fbdShow.SelectedPath) = False Then
            MessageBox.Show("Not found.")
            Exit Sub
        Else
            txtPathExe.Text = fbdShow.SelectedPath
        End If
    End Sub

    Private Sub btnPathRaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPathRaster.Click
        Dim strDir As String = Directory.GetCurrentDirectory.ToString()
        ofdRaster.InitialDirectory = strDir
        ofdRaster.Filter = "All files (*.*)|*.*"
        ofdRaster.FileName = String.Empty
        ofdRaster.ShowDialog()
        '---
        Dim strFilename As String = ofdRaster.FileName.ToString()
        If strFilename = String.Empty Then Exit Sub
        strFilename = strFilename.Replace("\", "//")
        txtPathRaster.Text = strFilename
    End Sub

    Private Sub cmbPresetting_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPresetting.SelectedIndexChanged
        '--- clear Picturebox from image
        labTimer.Text = "00:00:00"
        picDB.Image = Nothing
        picDB.BackColor = Color.Transparent
        picDB.Invalidate()
        '--- clear all CheckBox
        For Each ctr As Control In gbBasicSetting.Controls
            If ctr.GetType() Is GetType(CheckBox) Then
                Dim chk As CheckBox = ctr
                chk.Checked = False
            End If
        Next ctr
        '--- Clear TextBox Perview
        txtPerview.Text = String.Empty
        '---
        chkUseraster.Checked = True
        chkUsername.Checked = True
        chkDs.Checked = True
        For Each ctr As Control In gbMoreSetting.Controls
            If ctr.GetType() Is GetType(CheckBox) Then
                Dim chk As CheckBox = ctr
                chk.Checked = False
            End If
        Next ctr

        '---
        Dim cbx As ComboBox = CType(sender, ComboBox)
        Dim flag As Boolean = True
        Select Case cbx.SelectedIndex
            Case 0
                'Default import Setting
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkUsername.Checked = flag
                chkDs.Checked = flag
            Case 1
                'Default append Setting
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkAs.Checked = flag
            Case 2
                'Create new table(myrasters) and add image[Server+Port Number]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkHs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
            Case 3
                'Create new table(myrasters) and add image[Server]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkHs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
            Case 4
                'Create new table(myrasters) and add image[Localhost]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
            Case 5
                'Create new table(myrasters) and add image[Localhost+Port Number]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
            Case 6
                'Create new table(New Table) and add image[Server+Port Number]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFs.Checked = flag
                chkFb.Checked = flag
                chkDs.Checked = flag
                chkHs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
            Case 7
                'Create new table(New Table) and add image[Server]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFs.Checked = flag
                chkFb.Checked = flag
                chkDs.Checked = flag
                chkHs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
            Case 8
                'Create new table(New Table) and add image[Localhost]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFs.Checked = flag
                chkFb.Checked = flag
                chkDs.Checked = flag
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
            Case 9
                'Create new table(New Table) and add image[Localhost+Port Number]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFs.Checked = flag
                chkFb.Checked = flag
                chkDs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
            Case 10
                'Create new table(myrasters) with column(New Column) and add image[Server+Port Number]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkHs.Checked = flag
                chkPs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 11
                'Create new table(myrasters) with column(New Column) and add image[Server]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkHs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 12
                'Create new table(myrasters) with column(New Column) and add image[Localhost]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 13
                'Create new table(myrasters) with column(New Column) and add image[Localhost+Port Number]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkFs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
            Case 14
                'Create new table(New Table) with column(New Column) and add image[Server+Port Number]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkHs.Checked = flag
                chkPs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 15
                'Create new table(New Table) with column(New Column) and add image[Server].
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkHs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 16
                'Create new table(New Table) with column(New Column) and add image[Localhost]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkFb.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 17
                'Create new table(New Table) with column(New Column) and add image[Localhost+Port Number]
                chkSRID.Checked = flag
                chkIb.Checked = flag
                chkCb.Checked = flag
                chkMb.Checked = flag
                chkPs.Checked = flag
                chkFb.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 18
                'Append to table(myrasters) Image[Server+Port Number]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkHs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
            Case 19
                'Append to table(myrasters) Image[Server]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkHs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
            Case 20
                'Append to table(myrasters) Image[Localhost]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
            Case 21
                'Append to table(myrasters) Image[Localhost+Port Number]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
            Case 22
                'Append to table(New Table) Image[Server+Port Number]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkHs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
            Case 23
                'Append to table(New Table) Image[Server]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkHs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
            Case 24
                'Append to table(New Table) Image[Localhost]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
            Case 25
                'Append to table(New Table) Image[Localhost+Port Number]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
            Case 26
                'Append to table(myrasters) with column(New Column) Image[Server+Port Number]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkHs.Checked = flag
                chkPs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 27
                'Append to table(myrasters) with column(New Column) Image[Server]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkHs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 28
                'Append to table(myrasters) with column(New Column) Image[Localhost]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 29
                'Append to table(myrasters) with column(New Column) Image[Localhost+Port Number]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkFs.Checked = flag
                chkPs.Checked = flag
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 30
                'Append to table(New Table) with column(New Column) Image[Server+Port Number]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkHs.Checked = flag
                chkPs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 31
                'Append to table(New Table) with column(New Column) Image[Server]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkHs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtServer, "You have to add server IP.")
                errorNo.SetError(txtServer, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 32
                'Append to table(New Table) with column(New Column) Image[Localhost]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
            Case 33
                'Append to table(New Table) with column(New Column) Image[Localhost+Port Number]
                chkSRID.Checked = flag
                chkMb.Checked = flag
                chkAs.Checked = flag
                chkPs.Checked = flag
                chkFs.Checked = flag
                '---
                errorOK.SetError(txtPort, "You have to add server port.")
                errorNo.SetError(txtPort, "")
                '---
                errorOK.SetError(txtTablename, "You have to choose table.")
                errorNo.SetError(txtTablename, "")
                '---
                errorOK.SetError(txtFs, "You have to choose raster column.")
                errorNo.SetError(txtFs, "")
        End Select
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        '---
        labTimer.Text = "00:00:00"
        picDB.Image = Nothing
        picDB.BackColor = Color.Transparent
        picDB.Invalidate()
        '---
        'Dim myIp As String = GetExternalIp("www.gooogle.com") 'www.gooogle.com
        'MessageBox.Show(myIp)
        If Directory.Exists(txtPathExe.Text) = False Then
            MessageBox.Show("File does not exist check it [raster2pgsq.exe].", "Error :")
            Exit Sub
        End If
        '---
        If String.IsNullOrEmpty(txtPerview.Text) Then
            MessageBox.Show("You have to preview output.", "Error :")
            Exit Sub
        End If
        '---
        For Each ctr As Control In gbBasicSetting.Controls
            If ctr.GetType() Is GetType(TextBox) Then
                Dim chk As TextBox = ctr
                If String.IsNullOrEmpty(chk.Text) Then
                    MessageBox.Show(String.Format("You have to enter :{1}{0}", ToolTip1.GetToolTip(ctr), vbNewLine), "Error Empty data (Import):")
                    Exit Sub
                End If
            ElseIf ctr.GetType() Is GetType(ComboBox) Then
                Dim chk As ComboBox = ctr
                If String.IsNullOrEmpty(chk.Text) Then
                    MessageBox.Show(String.Format("You have to enter :{1}{0}", ToolTip1.GetToolTip(ctr), vbNewLine), "Error Empty data (Import):")
                    Exit Sub
                End If
            End If
        Next ctr
        If String.IsNullOrEmpty(txtBand.Text) Then
            MessageBox.Show(String.Format("You have to enter :{1}{0}", ToolTip1.GetToolTip(txtBand), vbNewLine), "Error Empty data (Import):")
            Exit Sub
        End If
        '---
        Dim strBat As String = String.Format("{0}\Import_Raster.bat", Application.StartupPath)
        Dim strBatCmd As New System.Text.StringBuilder
        '---
        strBatCmd.Append("echo off" & vbNewLine)
        strBatCmd.Append("cls" & vbNewLine)
        strBatCmd.Append(String.Format("cd {0}{1}", txtPathExe.Text, vbNewLine))
        strBatCmd.Append(txtPerview.Text & vbNewLine)
        'strBatCmd.Append("pause" & vbNewLine)
        strBatCmd.Append("cls" & vbNewLine)
        strBatCmd.Append("exit" & vbNewLine)
        '---
        If AsSaveToBat(strBat, strBatCmd.ToString) = False Then
            MessageBox.Show("Perview agen.", "Error import")
        Else
            Try
                Dim psi As New ProcessStartInfo(strBat)
                psi.RedirectStandardError = True
                psi.RedirectStandardOutput = True
                psi.CreateNoWindow = False
                psi.WindowStyle = ProcessWindowStyle.Normal
                psi.UseShellExecute = False
                Dim process As Process = process.Start(psi)
            Catch ex As Exception
                MessageBox.Show("Preview a gen.", "Error import")
                Exit Sub
            End Try
            MessageBox.Show("Raster is Imported.", "Raster Imported")
        End If

    End Sub

    Private Sub btn_Perview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Perview.Click
        'raster2pgsql -s 32635 -I -C -M c://01//01.jpg -F -t 725x555 public.myrasters | psql -U postgres -d familycare -h  192.168.0.103 -p 5432
        'psql -U postgres -d familycare -h  192.168.0.103 -p 5432
        '---

        For Each ctr As Control In gbBasicSetting.Controls
            If ctr.GetType() Is GetType(TextBox) Then
                Dim chk As TextBox = ctr
                If String.IsNullOrEmpty(chk.Text) Then
                    MessageBox.Show(String.Format("You have to enter :{1}{0}", ToolTip1.GetToolTip(ctr), vbNewLine), "Error Empty data (Preview):")
                    Exit Sub
                End If
            ElseIf ctr.GetType() Is GetType(ComboBox) Then
                Dim chk As ComboBox = ctr
                If String.IsNullOrEmpty(chk.Text) Then
                    MessageBox.Show(String.Format("You have to enter :{1}{0}", ToolTip1.GetToolTip(ctr), vbNewLine), "Error Empty data (Preview):")
                    Exit Sub
                End If
            End If
        Next ctr
        If String.IsNullOrEmpty(txtBand.Text) Then
            MessageBox.Show(String.Format("You have to enter :{1}{0}", ToolTip1.GetToolTip(txtBand), vbNewLine), "Error Empty data (Preview):")
            Exit Sub
        End If
        '---
        Dim strDbServer As String = String.Empty
        strDbServer = String.Format("{0} | psql ", txtTablename.Text)
        For Each ctr As Control In gbBasicSetting.Controls
            If ctr.GetType() Is GetType(CheckBox) Then
                Dim chk As CheckBox = ctr
                If chk.Checked = True Then
                    Select Case chk.Name
                        Case "chkUsername"
                            strDbServer += String.Format(" {0} {1}", ctr.Tag, txtUsername.Text)
                        Case "chkDs"
                            strDbServer += String.Format(" {0} {1}", ctr.Tag, txtDatabasename.Text)
                        Case "chkHs"
                            strDbServer += String.Format(" {0} {1}", ctr.Tag, txtServer.Text)
                        Case "chkPs"
                            strDbServer += String.Format(" {0} {1}", ctr.Tag, txtPort.Text)
                    End Select
                End If
            End If
        Next ctr
        '---
        Dim strFileraster As String = String.Empty
        For Each ctr As Control In gbBasicSetting.Controls
            If ctr.GetType() Is GetType(CheckBox) Then
                Dim chk As CheckBox = ctr
                If chk.Checked = True Then
                    Select Case chk.Name
                        Case "chkSRID"
                            strFileraster += String.Format(" {0} {1}", ctr.Tag, cmdSRID.Text)
                        Case "chkIb"
                            strFileraster += String.Format(" {0}", ctr.Tag)
                        Case "chkCb"
                            strFileraster += String.Format(" {0}", ctr.Tag)
                        Case "chkMb"
                            strFileraster += String.Format(" {0}", ctr.Tag)
                        Case "chkFs"
                            strFileraster += String.Format(" {0} {1}", ctr.Tag, txtFs.Text)
                        Case "chkFs"
                            strFileraster += String.Format(" {0} {1}", ctr.Tag, txtFs.Text)
                    End Select
                End If
            End If
        Next ctr
        '---
        Dim strRasterNewAppend As String = String.Empty
        For Each ctr As Control In gbBasicSetting.Controls
            If ctr.GetType() Is GetType(CheckBox) Then
                Dim chk As CheckBox = ctr
                If chk.Checked = True Then
                    Select Case chk.Name
                        Case "chkFb"
                            strRasterNewAppend += String.Format(" {0}", ctr.Tag)
                        Case "chkAs"
                            strRasterNewAppend += String.Format(" {0}", ctr.Tag)
                        Case "chkTs"
                            strRasterNewAppend += String.Format(" {0} {1}", ctr.Tag, txtTileSize.Text)
                    End Select
                End If
            End If
        Next ctr
        '---
        Dim strOptSetting As String = String.Empty
        For Each ctr As Control In gbMoreSetting.Controls
            If ctr.GetType() Is GetType(CheckBox) Then
                Dim chk As CheckBox = ctr
                If chk.Checked = True Then
                    Select Case chk.Name
                        Case "chkNb"
                            strOptSetting += String.Format(" {0}", ctr.Tag)
                        Case "chkRs"
                            strOptSetting += String.Format(" {0}", ctr.Tag)
                        Case "chkEs"
                            strOptSetting += String.Format(" {0}", ctr.Tag)
                        Case "chkBand"
                            strOptSetting += String.Format(" {0} {1}", ctr.Tag, txtBand.Text)
                    End Select
                End If
            End If
        Next ctr
        '---
        txtPerview.Text = String.Format("raster2pgsql {0} {1} {2} {3} {4}", strFileraster, txtPathRaster.Text, strOptSetting, strRasterNewAppend, strDbServer)
        '---
        '---
        errorOK.SetError(txtServer, "")
        errorNo.SetError(txtServer, "")
        '---
        errorOK.SetError(txtPort, "")
        errorNo.SetError(txtPort, "")
        '---
        errorOK.SetError(txtFs, "")
        errorNo.SetError(txtFs, "")

    End Sub
#End Region

#Region "Label"
    Private Sub llabURL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles llabURL.LinkClicked
        Process.Start(llabURL.Text)
    End Sub
#End Region

#Region "ComboBox"
    Private Sub cmdSRID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSRID.SelectedIndexChanged
        llabURL.Text = String.Format("http://spatialreference.org/ref/epsg/{0}/", cmdSRID.Text)
    End Sub
#End Region

#Region "Validated"

#Region "TextBox"
    Private Sub CheckTextBox_Validated_Check(ByVal sender As Object, ByVal e As System.EventArgs, ByVal vMsg As String) Handles CheckTextBox.Validated_Check
        Dim tbx As TextBox = CType(sender, TextBox)
        errorNo.SetIconPadding(tbx, 2)
        errorOK.SetIconPadding(tbx, 2)

        errorNo.SetIconAlignment(tbx, ErrorIconAlignment.MiddleRight)
        errorOK.SetIconAlignment(tbx, ErrorIconAlignment.MiddleRight)

        If String.IsNullOrEmpty(tbx.Text) Then
            errorNo.SetError(tbx, vMsg)
            errorOK.SetError(tbx, "")
        Else
            errorNo.SetError(tbx, "")
            errorOK.SetError(tbx, "OK")
        End If
    End Sub

    Private Sub txtPathRaster_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPathRaster.Validated
        CheckTextBox.Validated(sender, e, "You have to choose raster file.")
    End Sub

    Private Sub txtTileSize_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTileSize.Validated
        CheckTextBox.Validated(sender, e, "You have to choose raster [Width x Height].")
    End Sub

    Private Sub txtTablename_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTablename.Validated
        CheckTextBox.Validated(sender, e, "You have to choose Table name.")
    End Sub

    Private Sub txtUsername_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.Validated
        CheckTextBox.Validated(sender, e, "You have to choose User name.")
    End Sub

    Private Sub txtDatabasename_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatabasename.Validated
        CheckTextBox.Validated(sender, e, "You have to choose Database name.")
    End Sub

    Private Sub txtServer_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServer.Validated
        CheckTextBox.Validated(sender, e, "You have to choose Server IP.")
    End Sub

    Private Sub txtPort_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPort.Validated
        CheckTextBox.Validated(sender, e, "You have to choose Server port.")
    End Sub

    Private Sub txtFs_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFs.Validated
        CheckTextBox.Validated(sender, e, "You have to choose raster column.")
    End Sub

    Private Sub txtBand_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBand.Validated
        CheckTextBox.Validated(sender, e, "You have to choose Band color [1,2,3].")
    End Sub

    Private Sub txtPathExe_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPathExe.Validated
        CheckTextBox.Validated(sender, e, "You have to choose raster2pgsql.exe path.")
    End Sub

    Private Sub txtPassword_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.Validated
        CheckTextBox.Validated(sender, e, "You have to choose database password.")
    End Sub
#End Region

#Region "CmboBox"
    Private Sub cmdSRID_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSRID.Validated
        Dim tbx As ComboBox = CType(sender, ComboBox)
        errorNo.SetIconPadding(tbx, 2)
        errorOK.SetIconPadding(tbx, 2)

        errorNo.SetIconAlignment(tbx, ErrorIconAlignment.MiddleRight)
        errorOK.SetIconAlignment(tbx, ErrorIconAlignment.MiddleRight)

        If String.IsNullOrEmpty(tbx.Text) Or IsNumeric(tbx.Text) = False Then
            errorNo.SetError(tbx, "You have to choose SRID number.")
            errorOK.SetError(tbx, "")
        Else
            errorNo.SetError(tbx, "")
            errorOK.SetError(tbx, "OK")
        End If
    End Sub

    Private Sub cmdSRID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmdSRID.KeyPress
        TrapKey_Integer(e)
    End Sub

#End Region
#End Region

#Region "TextChanged"
    Private Sub txtServer_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtServer.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub txtTileSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTileSize.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub txtTablename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTablename.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUsername.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub txtDatabasename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDatabasename.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub txtPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPort.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub txtFs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFs.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub txtPathExe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPathExe.TextChanged
        If String.IsNullOrEmpty(txtPathExe.Text) = False Then
            txtPathExe.BackColor = Color.White
        Else
            txtPathExe.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub txtBand_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBand.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        CheckTextBox.TextChanged(sender, e)
    End Sub

    Private Sub CheckTextBox_TextChanged_Check(ByVal sender As Object, ByVal e As System.EventArgs) Handles CheckTextBox.TextChanged_Check
        Dim tbx As TextBox = CType(sender, TextBox)
        If String.IsNullOrEmpty(tbx.Text) = False Then
            tbx.BackColor = Color.White
        Else
            tbx.BackColor = Color.Yellow
        End If
    End Sub

    Private Sub cmdSRID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSRID.TextChanged
        Dim tbx As ComboBox = CType(sender, ComboBox)
        If String.IsNullOrEmpty(tbx.Text) = False Then
            tbx.BackColor = Color.White
        Else
            tbx.BackColor = Color.Yellow
        End If
    End Sub

#End Region

#Region "KeyPress"
    Private Sub txtPort_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPort.KeyPress
        TrapKey_Integer(e)
    End Sub

    Private Sub txtBand_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBand.KeyPress
        TrapKey_Single(e)
    End Sub

    Private Sub txtTileSize_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTileSize.KeyPress
        TrapKey_Width_Height(e)
    End Sub

    Private Sub txtServer_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtServer.KeyPress
        TrapKey_IP(e)
    End Sub

#End Region
#End Region

#Region "MenuItem"
    Private Sub MenuItem_GetImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_GetImage.Click
        ShowImage_DB()
    End Sub

    Private Sub MenuItem_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_Exit.Click
        Save_Setting()
        Application.Exit()
    End Sub

    Private Sub MenuItem_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_About.Click
        frmAboutRasterImporter.Show()
    End Sub

    Private Sub MenuItem_Contents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem_Contents.Click
        'Help.ShowHelp(Me, "Help\index.htm")
        Help.ShowHelp(Me, "ImportRaster.chm", HelpNavigator.TableOfContents)
        'Help.ShowHelp(Me, "http://www.codeproject.com")
    End Sub
#End Region
#End Region

#Region "Function"
    Private Sub Save_Setting()
        UserSetting.ChooseSetting = cmbPresetting.Text
        UserSetting.Path_raster_pgsql = txtPathExe.Text
        UserSetting.SRIDNO = cmdSRID.Text
        UserSetting.SRID = chkSRID.Checked
        UserSetting.I = chkIb.Checked
        UserSetting.C = chkCb.Checked
        UserSetting.M = chkMb.Checked
        UserSetting.Path_Image = txtPathRaster.Text
        UserSetting.f = chkFb.Checked
        UserSetting.a = chkAs.Checked
        UserSetting.t = chkTs.Checked
        UserSetting.TileSize = txtTileSize.Text
        UserSetting.Table = txtTablename.Text
        UserSetting.U = chkUsername.Checked
        UserSetting.Username = txtUsername.Text
        UserSetting.d = chkDs.Checked
        UserSetting.Database = txtDatabasename.Text
        UserSetting.h = chkHs.Checked
        UserSetting.IP = txtServer.Text
        UserSetting.p = chkPs.Checked
        UserSetting.Port = txtPort.Text
        UserSetting.F_COL = chkFs.Checked
        UserSetting.Column = txtFs.Text
        UserSetting.Password = txtPassword.Text
        UserSetting.N = chkNb.Checked
        UserSetting.r = chkRs.Checked
        UserSetting.e = chkEs.Checked
        UserSetting.b = chkBand.Checked
        UserSetting.Band = txtBand.Text
        UserSetting.Perview = txtPerview.Text
        '---------------------------------------------------------------
        If Save_Structure(UserSettingFilename, UserSetting) = False Then
            Debug.Print("frmMain.frmMain_FormClosed.Erro: user setting not saved")
        End If
    End Sub

    Private Sub ShowImage_DB()
        '--- check empty textbox
        '---
        For Each ctr As Control In gbBasicSetting.Controls
            If ctr.GetType() Is GetType(TextBox) Then
                Dim chk As TextBox = ctr
                Select Case chk.Name
                    Case "txtServer", "txtPort", "txtUsername", "txtPassword", "txtDatabasename", "txtFs", "txtTablename"
                        If String.IsNullOrEmpty(chk.Text) Then
                            MessageBox.Show(String.Format("You have to enter :{1}{0}", ToolTip1.GetToolTip(ctr), vbNewLine), "Error Empty Image (Import):")
                            Exit Sub
                        End If
                End Select
            End If
        Next ctr
        '---
        labTimer.Text = "00:00:00"
        picDB.Image = Nothing
        picDB.BackColor = Color.Transparent
        picDB.Invalidate()
        '---
        If PingServer(txtServer.Text, 1000) = True Then
            Dim strConnection As String = String.Empty
            strConnection = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};", _
                                          txtServer.Text, txtPort.Text, txtUsername.Text, txtPassword.Text, txtDatabasename.Text)
            Dim conn As New NpgsqlConnection(strConnection)
            Try
                '---
                conn.Open()
                '---
                Dim sw As New Stopwatch()
                sw.Start()
                '---
                Dim SQL As String = String.Empty
                SQL = String.Format("SELECT st_asjpeg({0}) as jpg FROM {1} ORDER BY rid DESC LIMIT 1;", _
                                    txtFs.Text, txtTablename.Text)
                Dim command As New NpgsqlCommand(SQL, conn) ' SELECT st_asjpeg(rast) as jpg FROM myrasters
                Dim dr As NpgsqlDataReader = command.ExecuteReader()
                dr.Read()
                Dim PictureCol As Integer = 0
                Dim b(dr.GetBytes(PictureCol, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                dr.GetBytes(PictureCol, 0, b, 0, b.Length)
                Dim TempImage As Image = Nothing
                Byte2Image(TempImage, b)
                If TempImage IsNot Nothing Then
                    picDB.Image = TempImage
                End If
                '---
                sw.Stop()
                '---
                dr.Close()
                conn.Close()
                '---
                labTimer.Text = String.Format("Elapsed Time[{0:00}:{1:00}:{2:00}.{3:00}]", sw.Elapsed.Hours, sw.Elapsed.Minutes, sw.Elapsed.Seconds, sw.Elapsed.Milliseconds)
            Catch ex As Exception
                Debug.Print("frmMain.ShowImage_DB.Error", Err.Number, Err.Description)
                conn.Close()
            End Try
        Else
            '---
            labTimer.Text = "00:00:00"
            picDB.Image = Nothing
            picDB.BackColor = Color.Transparent
            picDB.Invalidate()
            '---
            MessageBox.Show("Error was found in Database connection", "Error [Database connection]")
            Exit Sub
        End If
        '---
    End Sub

    Private Function AsSaveToBat(ByVal vFilenameBat As String, ByVal vData As String) As Boolean
        Try
            Dim file As System.IO.StreamWriter
            file = My.Computer.FileSystem.OpenTextFileWriter(vFilenameBat, False)
            file.Write(vData)
            file.Close()
            Return True
        Catch ex As Exception
            Debug.Print("frmMain.SaveToBat.Error:{0} , {1}", Err.Number, Err.Description)
            Return False
        End Try
    End Function

    Public Function TrapKey_Integer(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        e.Handled = TrapKey_Integer(Asc(e.KeyChar))
        Return True
    End Function

    Public Function TrapKey_Integer(ByVal KCode As String) As Boolean
        'MsgBox(KCode)
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function TrapKey_Single(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        e.Handled = TrapKey_Single(Asc(e.KeyChar))
        Return True
    End Function

    Public Function TrapKey_Single(ByVal KCode As String) As Boolean
        'MsgBox(KCode)
        If (KCode >= 48 And KCode <= 57) Or KCode = 8 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function TrapKey_Width_Height(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        e.Handled = TrapKey_Width_Height(Asc(e.KeyChar))
        Return True
    End Function

    Public Function TrapKey_Width_Height(ByVal KCode As String) As Boolean
        'MsgBox(KCode)
        If (KCode >= 48 And KCode <= 57) Or KCode = 120 Or KCode = 8 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function TrapKey_IP(ByVal e As System.Windows.Forms.KeyPressEventArgs) As Boolean
        e.Handled = TrapKey_IP(Asc(e.KeyChar))
        Return True
    End Function

    Public Function TrapKey_IP(ByVal KCode As String) As Boolean
        'MsgBox(KCode)
        If (KCode >= 48 And KCode <= 57) Or KCode = 120 Or KCode = 8 Or KCode = 46 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function IsAddressValid(ByVal addrString As String) As Boolean
        Dim address As IPAddress = Nothing
        Return IPAddress.TryParse(addrString, address)
    End Function

    Public Sub Byte2Image(ByRef NewImage As Image, ByVal ByteArr() As Byte)
        Try
            Dim ImageStream As MemoryStream
            If ByteArr.GetUpperBound(0) > 0 Then
                ImageStream = New MemoryStream(ByteArr)
                NewImage = Image.FromStream(ImageStream)
            Else
                NewImage = Nothing
            End If
        Catch ex As Exception
            NewImage = Nothing
        End Try
    End Sub

    Public Shared Function ImageToByte(ByVal img As Image) As Byte()
        Dim imgStream As MemoryStream = New MemoryStream()
        img.Save(imgStream, System.Drawing.Imaging.ImageFormat.Png)
        imgStream.Close()
        Dim byteArray As Byte() = imgStream.ToArray()
        imgStream.Dispose()
        Return byteArray
    End Function

#Region "Check Network Connection"
    Private Sub DoAvailabilityChanged(ByVal sender As Object, ByVal e As NetworkStatusChangedArgs)
        ' Event handler used to capture availability changes.
        ReportAvailability()
    End Sub

    Private Function ReportAvailability() As Boolean
        ' Report the current network availability.
        Return NetworkStatus.IsAvailable
    End Function

    Public Function PingServer(ByVal vIP As String, ByVal vInterval As Integer) As Boolean
        Try
            Return My.Computer.Network.Ping(vIP, vInterval)
        Catch ex As Exception
            Debug.Print("Error.CFunction.PingServer.{0} {1}", Err.Number, Err.Description)
            Return False
        End Try

    End Function
#End Region

#Region "Save&Read Structure [<Serializable()>]"
    Public Function Read_Structure(ByVal vFilename As String) As Object
        Try
            Dim BF As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            Dim bytes As Byte() = My.Computer.FileSystem.ReadAllBytes(vFilename)
            Return (DirectCast(BF.Deserialize(New System.IO.MemoryStream(bytes)), Object)) ' Software --> Structure
        Catch ex As Exception
            Debug.Print("Error.CFunction.Read_Structure.{0} {1}", Err.Number, Err.Description)
            Return Nothing
        End Try

    End Function

    Public Function Save_Structure(ByVal vFilename As String, ByVal vObject As Object) As Boolean
        '***
        '***  <Serializable()> Structure Software
        '***                      Dim MyName As String
        '***                      Dim SW_No As Integer
        '***                      Dim SW_Name As String
        '***                      Dim Test As CTest
        '***                      Dim List As List(Of String)
        '***                   End Structure
        '***
        Try
            Dim BF As New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
            Dim MS As New System.IO.MemoryStream()
            BF.Serialize(MS, vObject)
            My.Computer.FileSystem.WriteAllBytes(vFilename, MS.GetBuffer(), False) ' "c:\sw.stg"
            Return True
        Catch ex As Exception
            Debug.Print("Error.CFunction.Save_Structure.{0} {1}", Err.Number, Err.Description)
            Return False
        End Try
    End Function
#End Region

#End Region

End Class

Class CCheckTextBox
    Public Event TextChanged_Check(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public Event Validated_Check(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal vMsg As String)

    Protected Friend Sub TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RaiseEvent TextChanged_Check(sender, e)
    End Sub

    Protected Friend Sub Validated(ByVal sender As System.Object, ByVal e As System.EventArgs, ByVal vMsg As String)
        RaiseEvent Validated_Check(sender, e, vMsg)
    End Sub
End Class
