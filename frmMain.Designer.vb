<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.txtPathExe = New System.Windows.Forms.TextBox()
        Me.btnPath = New System.Windows.Forms.Button()
        Me.chkBand = New System.Windows.Forms.CheckBox()
        Me.txtBand = New System.Windows.Forms.TextBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkNb = New System.Windows.Forms.CheckBox()
        Me.chkPs = New System.Windows.Forms.CheckBox()
        Me.chkAs = New System.Windows.Forms.CheckBox()
        Me.chkRs = New System.Windows.Forms.CheckBox()
        Me.txtFs = New System.Windows.Forms.TextBox()
        Me.chkFs = New System.Windows.Forms.CheckBox()
        Me.chkIb = New System.Windows.Forms.CheckBox()
        Me.chkEs = New System.Windows.Forms.CheckBox()
        Me.chkUsername = New System.Windows.Forms.CheckBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtDatabasename = New System.Windows.Forms.TextBox()
        Me.chkDs = New System.Windows.Forms.CheckBox()
        Me.cmdSRID = New System.Windows.Forms.ComboBox()
        Me.chkSRID = New System.Windows.Forms.CheckBox()
        Me.chkCb = New System.Windows.Forms.CheckBox()
        Me.txtPathRaster = New System.Windows.Forms.TextBox()
        Me.btnPathRaster = New System.Windows.Forms.Button()
        Me.chkMb = New System.Windows.Forms.CheckBox()
        Me.chkUseraster = New System.Windows.Forms.CheckBox()
        Me.chkFb = New System.Windows.Forms.CheckBox()
        Me.txtTileSize = New System.Windows.Forms.TextBox()
        Me.chkTs = New System.Windows.Forms.CheckBox()
        Me.chkHs = New System.Windows.Forms.CheckBox()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.txtTablename = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnImport = New System.Windows.Forms.Button()
        Me.labTimer = New System.Windows.Forms.Label()
        Me.txtPerview = New System.Windows.Forms.TextBox()
        Me.picDB = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuItem_File = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_GetImage = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItem_Exit = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuItem_SendFeedback = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItem_Contents = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.MenuItem_About = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_Perview = New System.Windows.Forms.Button()
        Me.llabURL = New System.Windows.Forms.LinkLabel()
        Me.gbBasicSetting = New System.Windows.Forms.GroupBox()
        Me.gbMoreSetting = New System.Windows.Forms.GroupBox()
        Me.cmbPresetting = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fbdShow = New System.Windows.Forms.FolderBrowserDialog()
        Me.ofdRaster = New System.Windows.Forms.OpenFileDialog()
        Me.errorOK = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.errorNo = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        CType(Me.picDB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.gbBasicSetting.SuspendLayout()
        Me.gbMoreSetting.SuspendLayout()
        CType(Me.errorOK, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errorNo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPathExe
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtPathExe, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtPathExe, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtPathExe, "The path to [raster2pgsql.exe].")
        Me.txtPathExe.Location = New System.Drawing.Point(164, 69)
        Me.txtPathExe.Name = "txtPathExe"
        Me.txtPathExe.ReadOnly = True
        Me.HelpProvider1.SetShowHelp(Me.txtPathExe, True)
        Me.txtPathExe.Size = New System.Drawing.Size(375, 21)
        Me.txtPathExe.TabIndex = 0
        Me.txtPathExe.Text = "C:\Program Files\PostgreSQL\9.3\bin"
        Me.ToolTip1.SetToolTip(Me.txtPathExe, "Path to raster2pgsql.exe." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'btnPath
        '
        Me.HelpProvider1.SetHelpKeyword(Me.btnPath, "")
        Me.HelpProvider1.SetHelpString(Me.btnPath, "Get the path of [raster2pgsql.exe].")
        Me.btnPath.Location = New System.Drawing.Point(9, 68)
        Me.btnPath.Name = "btnPath"
        Me.HelpProvider1.SetShowHelp(Me.btnPath, True)
        Me.btnPath.Size = New System.Drawing.Size(149, 23)
        Me.btnPath.TabIndex = 2
        Me.btnPath.Text = "Get raster2pgsql path..."
        Me.btnPath.UseVisualStyleBackColor = True
        '
        'chkBand
        '
        Me.chkBand.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkBand, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkBand, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkBand, resources.GetString("chkBand.HelpString"))
        Me.chkBand.Location = New System.Drawing.Point(13, 47)
        Me.chkBand.Name = "chkBand"
        Me.HelpProvider1.SetShowHelp(Me.chkBand, True)
        Me.chkBand.Size = New System.Drawing.Size(39, 21)
        Me.chkBand.TabIndex = 6
        Me.chkBand.Tag = "-b"
        Me.chkBand.Text = "-b"
        Me.ToolTip1.SetToolTip(Me.chkBand, "Index (1-based) of band to extract from raster." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more than one band index, se" & _
                "parate with comma (,)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If unspecified, all bands of raster will be extracted." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & _
                "")
        Me.chkBand.UseVisualStyleBackColor = True
        '
        'txtBand
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtBand, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtBand, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtBand, "<band> Index (1-based) of band to extract from raster.")
        Me.txtBand.Location = New System.Drawing.Point(184, 45)
        Me.txtBand.MaxLength = 40
        Me.txtBand.Name = "txtBand"
        Me.HelpProvider1.SetShowHelp(Me.txtBand, True)
        Me.txtBand.Size = New System.Drawing.Size(78, 24)
        Me.txtBand.TabIndex = 7
        Me.txtBand.Text = "1,2,3"
        Me.ToolTip1.SetToolTip(Me.txtBand, "Index (1-based) of band to extract from raster." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "For more than one band index, se" & _
                "parate with comma (,)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If unspecified, all bands of raster will be extracted.")
        '
        'chkNb
        '
        Me.chkNb.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkNb, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkNb, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkNb, "NODATA value to use on bands without a NODATA value.")
        Me.chkNb.Location = New System.Drawing.Point(13, 20)
        Me.chkNb.Name = "chkNb"
        Me.HelpProvider1.SetShowHelp(Me.chkNb, True)
        Me.chkNb.Size = New System.Drawing.Size(41, 21)
        Me.chkNb.TabIndex = 14
        Me.chkNb.Tag = "-N"
        Me.chkNb.Text = "-N"
        Me.ToolTip1.SetToolTip(Me.chkNb, "NODATA value to use on bands without a NODATA value." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkNb.UseVisualStyleBackColor = True
        '
        'chkPs
        '
        Me.chkPs.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkPs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkPs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkPs, "Port number.")
        Me.chkPs.Location = New System.Drawing.Point(5, 296)
        Me.chkPs.Name = "chkPs"
        Me.HelpProvider1.SetShowHelp(Me.chkPs, True)
        Me.chkPs.Size = New System.Drawing.Size(39, 21)
        Me.chkPs.TabIndex = 17
        Me.chkPs.Tag = "-p"
        Me.chkPs.Text = "-p"
        Me.ToolTip1.SetToolTip(Me.chkPs, "Port number." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkPs.UseVisualStyleBackColor = True
        '
        'chkAs
        '
        Me.chkAs.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkAs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkAs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkAs, "Appends raster into current table, must be  exactly the same table schema.")
        Me.chkAs.Location = New System.Drawing.Point(5, 156)
        Me.chkAs.Name = "chkAs"
        Me.HelpProvider1.SetShowHelp(Me.chkAs, True)
        Me.chkAs.Size = New System.Drawing.Size(39, 21)
        Me.chkAs.TabIndex = 16
        Me.chkAs.Tag = "-a"
        Me.chkAs.Text = "-a"
        Me.ToolTip1.SetToolTip(Me.chkAs, "Append raster(s) to an existing table." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkAs.UseVisualStyleBackColor = True
        '
        'chkRs
        '
        Me.chkRs.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkRs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkRs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkRs, "Set the constraints (spatially unique and coverage tile) for regular blocking. On" & _
                "ly applied if -C flag is also used.")
        Me.chkRs.Location = New System.Drawing.Point(118, 20)
        Me.chkRs.Name = "chkRs"
        Me.HelpProvider1.SetShowHelp(Me.chkRs, True)
        Me.chkRs.Size = New System.Drawing.Size(38, 21)
        Me.chkRs.TabIndex = 18
        Me.chkRs.Tag = "-r"
        Me.chkRs.Text = "-r"
        Me.ToolTip1.SetToolTip(Me.chkRs, "Set the constraints (spatially unique and coverage tile) for " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "regular blocking. " & _
                "Only applied if -C flag is also used." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkRs.UseVisualStyleBackColor = True
        '
        'txtFs
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtFs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtFs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtFs, "Specify the name of the raster column.")
        Me.txtFs.Location = New System.Drawing.Point(234, 322)
        Me.txtFs.MaxLength = 255
        Me.txtFs.Name = "txtFs"
        Me.HelpProvider1.SetShowHelp(Me.txtFs, True)
        Me.txtFs.Size = New System.Drawing.Size(78, 24)
        Me.txtFs.TabIndex = 9
        Me.txtFs.Text = "rast"
        Me.ToolTip1.SetToolTip(Me.txtFs, "Specify name of destination raster column, default is 'rast'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'chkFs
        '
        Me.chkFs.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkFs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkFs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkFs, "Specify the name of the raster column.")
        Me.chkFs.Location = New System.Drawing.Point(5, 324)
        Me.chkFs.Name = "chkFs"
        Me.HelpProvider1.SetShowHelp(Me.chkFs, True)
        Me.chkFs.Size = New System.Drawing.Size(121, 21)
        Me.chkFs.TabIndex = 10
        Me.chkFs.Tag = "-f"
        Me.chkFs.Text = "-f >> COLUMN"
        Me.ToolTip1.SetToolTip(Me.chkFs, "Specify name of destination raster column, default is 'rast'." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkFs.UseVisualStyleBackColor = True
        '
        'chkIb
        '
        Me.chkIb.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkIb, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkIb, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkIb, "Create a GIST spatial index on the raster column.")
        Me.chkIb.Location = New System.Drawing.Point(5, 56)
        Me.chkIb.Name = "chkIb"
        Me.HelpProvider1.SetShowHelp(Me.chkIb, True)
        Me.chkIb.Size = New System.Drawing.Size(38, 21)
        Me.chkIb.TabIndex = 12
        Me.chkIb.Tag = "-I"
        Me.chkIb.Text = "-I"
        Me.ToolTip1.SetToolTip(Me.chkIb, "Create a GiST index on the raster column." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkIb.UseVisualStyleBackColor = True
        '
        'chkEs
        '
        Me.chkEs.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkEs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkEs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkEs, "Execute each statement individually, do not use a transaction.")
        Me.chkEs.Location = New System.Drawing.Point(223, 18)
        Me.chkEs.Name = "chkEs"
        Me.HelpProvider1.SetShowHelp(Me.chkEs, True)
        Me.chkEs.Size = New System.Drawing.Size(39, 21)
        Me.chkEs.TabIndex = 16
        Me.chkEs.Tag = "-e"
        Me.chkEs.Text = "-e"
        Me.ToolTip1.SetToolTip(Me.chkEs, "Execute each statement individually, do not use a transaction." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkEs.UseVisualStyleBackColor = True
        '
        'chkUsername
        '
        Me.chkUsername.AutoSize = True
        Me.chkUsername.Checked = True
        Me.chkUsername.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUsername.Enabled = False
        Me.HelpProvider1.SetHelpKeyword(Me.chkUsername, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkUsername, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkUsername, "User name to connect to database.")
        Me.chkUsername.Location = New System.Drawing.Point(5, 225)
        Me.chkUsername.Name = "chkUsername"
        Me.HelpProvider1.SetShowHelp(Me.chkUsername, True)
        Me.chkUsername.Size = New System.Drawing.Size(41, 21)
        Me.chkUsername.TabIndex = 8
        Me.chkUsername.Tag = "-U"
        Me.chkUsername.Text = "-U"
        Me.ToolTip1.SetToolTip(Me.chkUsername, "User name to connect to database." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkUsername.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtUsername, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtUsername, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtUsername, "User name to connect to database.")
        Me.txtUsername.Location = New System.Drawing.Point(131, 225)
        Me.txtUsername.MaxLength = 255
        Me.txtUsername.Name = "txtUsername"
        Me.HelpProvider1.SetShowHelp(Me.txtUsername, True)
        Me.txtUsername.Size = New System.Drawing.Size(181, 24)
        Me.txtUsername.TabIndex = 9
        Me.txtUsername.Text = "postgres"
        Me.ToolTip1.SetToolTip(Me.txtUsername, "User name to connect to database." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtDatabasename
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtDatabasename, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtDatabasename, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtDatabasename, "Drops the table, then recreates it and populates it with current raster data.")
        Me.txtDatabasename.Location = New System.Drawing.Point(131, 250)
        Me.txtDatabasename.MaxLength = 255
        Me.txtDatabasename.Name = "txtDatabasename"
        Me.HelpProvider1.SetShowHelp(Me.txtDatabasename, True)
        Me.txtDatabasename.Size = New System.Drawing.Size(181, 24)
        Me.txtDatabasename.TabIndex = 20
        Me.txtDatabasename.Text = "database"
        Me.ToolTip1.SetToolTip(Me.txtDatabasename, "Database name.")
        '
        'chkDs
        '
        Me.chkDs.AutoSize = True
        Me.chkDs.Checked = True
        Me.chkDs.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkDs.Enabled = False
        Me.HelpProvider1.SetHelpKeyword(Me.chkDs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkDs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkDs, "Drops the table, then recreates it and populates it with current raster data.")
        Me.chkDs.Location = New System.Drawing.Point(5, 249)
        Me.chkDs.Name = "chkDs"
        Me.HelpProvider1.SetShowHelp(Me.chkDs, True)
        Me.chkDs.Size = New System.Drawing.Size(39, 21)
        Me.chkDs.TabIndex = 19
        Me.chkDs.Tag = "-d"
        Me.chkDs.Text = "-d"
        Me.ToolTip1.SetToolTip(Me.chkDs, "Database name." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkDs.UseVisualStyleBackColor = True
        '
        'cmdSRID
        '
        Me.cmdSRID.FormattingEnabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.cmdSRID, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.cmdSRID, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.cmdSRID, "Assign output raster with specified SRID.")
        Me.cmdSRID.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050", "2051", "2052", "2053", "2054", "2055", "2056", "2057", "2058", "2059", "2060", "2061", "2062", "2063", "2064", "2065", "2066", "2067", "2068", "2069", "2070", "2071", "2072", "2073", "2074", "2075", "2076", "2077", "2078", "2079", "2080", "2081", "2082", "2083", "2084", "2085", "2086", "2087", "2088", "2089", "2090", "2091", "2092", "2093", "2094", "2095", "2096", "2097", "2098", "2099", "2100", "2101", "2102", "2103", "2104", "2105", "2106", "2107", "2108", "2109", "2110", "2111", "2112", "2113", "2114", "2115", "2116", "2117", "2118", "2119", "2120", "2121", "2122", "2123", "2124", "2125", "2126", "2127", "2128", "2129", "2130", "2131", "2132", "2133", "2134", "2135", "2136", "2137", "2138", "2139", "2140", "2141", "2142", "2143", "2144", "2145", "2146", "2147", "2148", "2149", "2150", "2151", "2152", "2153", "2154", "2155", "2156", "2157", "2158", "2159", "2160", "2161", "2162", "2163", "2164", "2165", "2166", "2167", "2168", "2169", "2170", "2171", "2172", "2173", "2174", "2175", "2176", "2177", "2178", "2179", "2180", "2188", "2189", "2190", "2191", "2192", "2193", "2194", "2195", "2196", "2197", "2198", "2199", "2200", "2201", "2202", "2203", "2204", "2205", "2206", "2207", "2208", "2209", "2210", "2211", "2212", "2213", "2214", "2215", "2216", "2217", "2219", "2220", "2222", "2223", "2224", "2225", "2226", "2227", "2228", "2229", "2230", "2231", "2232", "2233", "2234", "2235", "2236", "2237", "2238", "2239", "2240", "2241", "2242", "2243", "2244", "2245", "2246", "2247", "2248", "2249", "2250", "2251", "2252", "2253", "2254", "2255", "2256", "2257", "2258", "2259", "2260", "2261", "2262", "2263", "2264", "2265", "2266", "2267", "2268", "2269", "2270", "2271", "2272", "2273", "2274", "2275", "2276", "2277", "2278", "2279", "2280", "2281", "2282", "2283", "2284", "2285", "2286", "2287", "2288", "2289", "2290", "2291", "2292", "2294", "2295", "2308", "2309", "2310", "2311", "2312", "2313", "2314", "2315", "2316", "2317", "2318", "2319", "2320", "2321", "2322", "2323", "2324", "2325", "2326", "2327", "2328", "2329", "2330", "2331", "2332", "2333", "2334", "2335", "2336", "2337", "2338", "2339", "2340", "2341", "2342", "2343", "2344", "2345", "2346", "2347", "2348", "2349", "2350", "2351", "2352", "2353", "2354", "2355", "2356", "2357", "2358", "2359", "2360", "2361", "2362", "2363", "2364", "2365", "2366", "2367", "2368", "2369", "2370", "2371", "2372", "2373", "2374", "2375", "2376", "2377", "2378", "2379", "2380", "2381", "2382", "2383", "2384", "2385", "2386", "2387", "2388", "2389", "2390", "2391", "2392", "2393", "2394", "2395", "2396", "2397", "2398", "2399", "2400", "2401", "2402", "2403", "2404", "2405", "2406", "2407", "2408", "2409", "2410", "2411", "2412", "2413", "2414", "2415", "2416", "2417", "2418", "2419", "2420", "2421", "2422", "2423", "2424", "2425", "2426", "2427", "2428", "2429", "2430", "2431", "2432", "2433", "2434", "2435", "2436", "2437", "2438", "2439", "2440", "2441", "2442", "2443", "2444", "2445", "2446", "2447", "2448", "2449", "2450", "2451", "2452", "2453", "2454", "2455", "2456", "2457", "2458", "2459", "2460", "2461", "2462", "2463", "2464", "2465", "2466", "2467", "2468", "2469", "2470", "2471", "2472", "2473", "2474", "2475", "2476", "2477", "2478", "2479", "2480", "2481", "2482", "2483", "2484", "2485", "2486", "2487", "2488", "2489", "2490", "2491", "2492", "2493", "2494", "2495", "2496", "2497", "2498", "2499", "2500", "2501", "2502", "2503", "2504", "2505", "2506", "2507", "2508", "2509", "2510", "2511", "2512", "2513", "2514", "2515", "2516", "2517", "2518", "2519", "2520", "2521", "2522", "2523", "2524", "2525", "2526", "2527", "2528", "2529", "2530", "2531", "2532", "2533", "2534", "2535", "2536", "2537", "2538", "2539", "2540", "2541", "2542", "2543", "2544", "2545", "2546", "2547", "2548", "2549", "2550", "2551", "2552", "2553", "2554", "2555", "2556", "2557", "2558", "2559", "2560", "2561", "2562", "2563", "2564", "2565", "2566", "2567", "2568", "2569", "2570", "2571", "2572", "2573", "2574", "2575", "2576", "2577", "2578", "2579", "2580", "2581", "2582", "2583", "2584", "2585", "2586", "2587", "2588", "2589", "2590", "2591", "2592", "2593", "2594", "2595", "2596", "2597", "2598", "2599", "2600", "2601", "2602", "2603", "2604", "2605", "2606", "2607", "2608", "2609", "2610", "2611", "2612", "2613", "2614", "2615", "2616", "2617", "2618", "2619", "2620", "2621", "2622", "2623", "2624", "2625", "2626", "2627", "2628", "2629", "2630", "2631", "2632", "2633", "2634", "2635", "2636", "2637", "2638", "2639", "2640", "2641", "2642", "2643", "2644", "2645", "2646", "2647", "2648", "2649", "2650", "2651", "2652", "2653", "2654", "2655", "2656", "2657", "2658", "2659", "2660", "2661", "2662", "2663", "2664", "2665", "2666", "2667", "2668", "2669", "2670", "2671", "2672", "2673", "2674", "2675", "2676", "2677", "2678", "2679", "2680", "2681", "2682", "2683", "2684", "2685", "2686", "2687", "2688", "2689", "2690", "2691", "2692", "2693", "2694", "2695", "2696", "2697", "2698", "2699", "2700", "2701", "2702", "2703", "2704", "2705", "2706", "2707", "2708", "2709", "2710", "2711", "2712", "2713", "2714", "2715", "2716", "2717", "2718", "2719", "2720", "2721", "2722", "2723", "2724", "2725", "2726", "2727", "2728", "2729", "2730", "2731", "2732", "2733", "2734", "2735", "2736", "2737", "2738", "2739", "2740", "2741", "2742", "2743", "2744", "2745", "2746", "2747", "2748", "2749", "2750", "2751", "2752", "2753", "2754", "2755", "2756", "2757", "2758", "2759", "2760", "2761", "2762", "2763", "2764", "2765", "2766", "2767", "2768", "2769", "2770", "2771", "2772", "2773", "2774", "2775", "2776", "2777", "2778", "2779", "2780", "2781", "2782", "2783", "2784", "2785", "2786", "2787", "2788", "2789", "2790", "2791", "2792", "2793", "2794", "2795", "2796", "2797", "2798", "2799", "2800", "2801", "2802", "2803", "2804", "2805", "2806", "2807", "2808", "2809", "2810", "2811", "2812", "2813", "2814", "2815", "2816", "2817", "2818", "2819", "2820", "2821", "2822", "2823", "2824", "2825", "2826", "2827", "2828", "2829", "2830", "2831", "2832", "2833", "2834", "2835", "2836", "2837", "2838", "2839", "2840", "2841", "2842", "2843", "2844", "2845", "2846", "2847", "2848", "2849", "2850", "2851", "2852", "2853", "2854", "2855", "2856", "2857", "2858", "2859", "2860", "2861", "2862", "2863", "2864", "2865", "2866", "2867", "2868", "2869", "2870", "2871", "2872", "2873", "2874", "2875", "2876", "2877", "2878", "2879", "2880", "2881", "2882", "2883", "2884", "2885", "2886", "2887", "2888", "2889", "2890", "2891", "2892", "2893", "2894", "2895", "2896", "2897", "2898", "2899", "2900", "2901", "2902", "2903", "2904", "2905", "2906", "2907", "2908", "2909", "2910", "2911", "2912", "2913", "2914", "2915", "2916", "2917", "2918", "2919", "2920", "2921", "2922", "2923", "2924", "2925", "2926", "2927", "2928", "2929", "2930", "2931", "2932", "2933", "2934", "2935", "2936", "2937", "2938", "2939", "2940", "2941", "2942", "2943", "2944", "2945", "2946", "2947", "2948", "2949", "2950", "2951", "2952", "2953", "2954", "2955", "2956", "2957", "2958", "2959", "2960", "2961", "2962", "2964", "2965", "2966", "2967", "2968", "2969", "2970", "2971", "2972", "2973", "2975", "2976", "2977", "2978", "2979", "2980", "2981", "2982", "2983", "2984", "2987", "2988", "2989", "2990", "2991", "2992", "2993", "2994", "2995", "2996", "2997", "2998", "2999", "3000", "3001", "3002", "3003", "3004", "3005", "3006", "3007", "3008", "3009", "3010", "3011", "3012", "3013", "3014", "3015", "3016", "3017", "3018", "3019", "3020", "3021", "3022", "3023", "3024", "3025", "3026", "3027", "3028", "3029", "3030", "3033", "3034", "3035", "3036", "3037", "3038", "3039", "3040", "3041", "3042", "3043", "3044", "3045", "3046", "3047", "3048", "3049", "3050", "3051", "3054", "3055", "3056", "3057", "3058", "3059", "3060", "3061", "3062", "3063", "3064", "3065", "3148", "3149", "3176", "3200", "3300", "3301", "3439", "3440", "3561", "3562", "3563", "3564", "3565", "3920", "3991", "3992", "4001", "4002", "4003", "4004", "4005", "4006", "4007", "4008", "4009", "4010", "4011", "4012", "4013", "4014", "4015", "4016", "4018", "4019", "4020", "4021", "4022", "4024", "4025", "4027", "4028", "4029", "4030", "4031", "4032", "4033", "4034", "4035", "4036", "4041", "4042", "4043", "4044", "4045", "4047", "4120", "4121", "4122", "4123", "4124", "4125", "4126", "4127", "4128", "4129", "4130", "4131", "4132", "4133", "4134", "4135", "4136", "4137", "4138", "4139", "4140", "4141", "4142", "4143", "4144", "4145", "4146", "4147", "4148", "4149", "4150", "4151", "4152", "4153", "4154", "4155", "4156", "4157", "4158", "4159", "4160", "4161", "4162", "4163", "4164", "4165", "4166", "4167", "4168", "4169", "4170", "4171", "4172", "4173", "4174", "4175", "4176", "4178", "4179", "4180", "4181", "4182", "4183", "4184", "4185", "4188", "4189", "4190", "4191", "4192", "4193", "4194", "4195", "4196", "4197", "4198", "4199", "4200", "4201", "4202", "4203", "4204", "4205", "4206", "4207", "4208", "4209", "4210", "4211", "4212", "4213", "4214", "4215", "4216", "4218", "4219", "4220", "4221", "4222", "4223", "4224", "4225", "4226", "4227", "4228", "4229", "4230", "4231", "4232", "4233", "4234", "4235", "4236", "4237", "4238", "4239", "4240", "4241", "4242", "4243", "4244", "4245", "4246", "4247", "4248", "4249", "4250", "4251", "4252", "4253", "4254", "4255", "4256", "4257", "4258", "4259", "4260", "4261", "4262", "4263", "4264", "4265", "4266", "4267", "4268", "4269", "4270", "4271", "4272", "4273", "4274", "4275", "4276", "4277", "4278", "4279", "4280", "4281", "4282", "4283", "4284", "4285", "4286", "4287", "4288", "4289", "4291", "4292", "4293", "4294", "4295", "4296", "4297", "4298", "4299", "4300", "4301", "4302", "4303", "4304", "4306", "4307", "4308", "4309", "4310", "4311", "4312", "4313", "4314", "4315", "4316", "4317", "4318", "4319", "4322", "4324", "4326", "4600", "4601", "4602", "4603", "4604", "4605", "4606", "4607", "4608", "4609", "4610", "4611", "4612", "4613", "4614", "4615", "4616", "4617", "4618", "4619", "4620", "4621", "4622", "4623", "4624", "4625", "4626", "4627", "4628", "4629", "4630", "4631", "4632", "4633", "4634", "4635", "4636", "4637", "4638", "4639", "4640", "4641", "4642", "4643", "4644", "4645", "4646", "4657", "4658", "4659", "4660", "4661", "4662", "4663", "4664", "4665", "4666", "4667", "4668", "4669", "4670", "4671", "4801", "4802", "4803", "4804", "4805", "4806", "4807", "4808", "4809", "4810", "4811", "4813", "4814", "4815", "4816", "4817", "4818", "4819", "4820", "4821", "4901", "4902", "4903", "4904", "20004", "20005", "20006", "20007", "20008", "20009", "20010", "20011", "20012", "20013", "20014", "20015", "20016", "20017", "20018", "20019", "20020", "20021", "20022", "20023", "20024", "20025", "20026", "20027", "20028", "20029", "20030", "20031", "20032", "20064", "20065", "20066", "20067", "20068", "20069", "20070", "20071", "20072", "20073", "20074", "20075", "20076", "20077", "20078", "20079", "20080", "20081", "20082", "20083", "20084", "20085", "20086", "20087", "20088", "20089", "20090", "20091", "20092", "20135", "20136", "20137", "20138", "20248", "20249", "20250", "20251", "20252", "20253", "20254", "20255", "20256", "20257", "20258", "20348", "20349", "20350", "20351", "20352", "20353", "20354", "20355", "20356", "20357", "20358", "20437", "20438", "20439", "20499", "20538", "20539", "20790", "20791", "20822", "20823", "20824", "20934", "20935", "20936", "21035", "21036", "21037", "21095", "21096", "21097", "21100", "21148", "21149", "21150", "21291", "21292", "21413", "21414", "21415", "21416", "21417", "21418", "21419", "21420", "21421", "21422", "21423", "21453", "21454", "21455", "21456", "21457", "21458", "21459", "21460", "21461", "21462", "21463", "21473", "21474", "21475", "21476", "21477", "21478", "21479", "21480", "21481", "21482", "21483", "21500", "21780", "21781", "21817", "21818", "21891", "21892", "21893", "21894", "22032", "22033", "22091", "22092", "22191", "22192", "22193", "22194", "22195", "22196", "22197", "22234", "22235", "22236", "22275", "22277", "22279", "22281", "22283", "22285", "22287", "22289", "22291", "22293", "22300", "22332", "22391", "22392", "22523", "22524", "22700", "22770", "22780", "22832", "22991", "22992", "22993", "22994", "23028", "23029", "23030", "23031", "23032", "23033", "23034", "23035", "23036", "23037", "23038", "23090", "23095", "23239", "23240", "23433", "23700", "23846", "23847", "23848", "23849", "23850", "23851", "23852", "23853", "23886", "23887", "23888", "23889", "23890", "23891", "23892", "23893", "23894", "23946", "23947", "23948", "24047", "24048", "24100", "24200", "24305", "24306", "24311", "24312", "24313", "24342", "24343", "24344", "24345", "24346", "24347", "24370", "24371", "24372", "24373", "24374", "24375", "24376", "24377", "24378", "24379", "24380", "24381", "24382", "24383", "24500", "24547", "24548", "24571", "24600", "24718", "24719", "24720", "24818", "24819", "24820", "24821", "24877", "24878", "24879", "24880", "24882", "24891", "24892", "24893", "25000", "25231", "25391", "25392", "25393", "25394", "25395", "25700", "25828", "25829", "25830", "25831", "25832", "25833", "25834", "25835", "25836", "25837", "25838", "25884", "25932", "26191", "26192", "26193", "26194", "26195", "26237", "26331", "26332", "26391", "26392", "26393", "26432", "26591", "26592", "26632", "26692", "26703", "26704", "26705", "26706", "26707", "26708", "26709", "26710", "26711", "26712", "26713", "26714", "26715", "26716", "26717", "26718", "26719", "26720", "26721", "26722", "26729", "26730", "26731", "26732", "26733", "26734", "26735", "26736", "26737", "26738", "26739", "26740", "26741", "26742", "26743", "26744", "26745", "26746", "26747", "26748", "26749", "26750", "26751", "26752", "26753", "26754", "26755", "26756", "26757", "26758", "26759", "26760", "26766", "26767", "26768", "26769", "26770", "26771", "26772", "26773", "26774", "26775", "26776", "26777", "26778", "26779", "26780", "26781", "26782", "26783", "26784", "26785", "26786", "26787", "26791", "26792", "26793", "26794", "26795", "26796", "26797", "26798", "26801", "26802", "26803", "26811", "26812", "26813", "26903", "26904", "26905", "26906", "26907", "26908", "26909", "26910", "26911", "26912", "26913", "26914", "26915", "26916", "26917", "26918", "26919", "26920", "26921", "26922", "26923", "26929", "26930", "26931", "26932", "26933", "26934", "26935", "26936", "26937", "26938", "26939", "26940", "26941", "26942", "26943", "26944", "26945", "26946", "26948", "26949", "26950", "26951", "26952", "26953", "26954", "26955", "26956", "26957", "26958", "26959", "26960", "26961", "26962", "26963", "26964", "26965", "26966", "26967", "26968", "26969", "26970", "26971", "26972", "26973", "26974", "26975", "26976", "26977", "26978", "26979", "26980", "26981", "26982", "26983", "26984", "26985", "26986", "26987", "26988", "26989", "26990", "26991", "26992", "26993", "26994", "26995", "26996", "26997", "26998", "27038", "27039", "27040", "27120", "27200", "27205", "27206", "27207", "27208", "27209", "27210", "27211", "27212", "27213", "27214", "27215", "27216", "27217", "27218", "27219", "27220", "27221", "27222", "27223", "27224", "27225", "27226", "27227", "27228", "27229", "27230", "27231", "27232", "27258", "27259", "27260", "27291", "27292", "27391", "27392", "27393", "27394", "27395", "27396", "27397", "27398", "27429", "27492", "27500", "27561", "27562", "27563", "27564", "27571", "27572", "27573", "27574", "27581", "27582", "27583", "27584", "27591", "27592", "27593", "27594", "27700", "28191", "28192", "28193", "28232", "28348", "28349", "28350", "28351", "28352", "28353", "28354", "28355", "28356", "28357", "28358", "28402", "28403", "28404", "28405", "28406", "28407", "28408", "28409", "28410", "28411", "28412", "28413", "28414", "28415", "28416", "28417", "28418", "28419", "28420", "28421", "28422", "28423", "28424", "28425", "28426", "28427", "28428", "28429", "28430", "28431", "28432", "28462", "28463", "28464", "28465", "28466", "28467", "28468", "28469", "28470", "28471", "28472", "28473", "28474", "28475", "28476", "28477", "28478", "28479", "28480", "28481", "28482", "28483", "28484", "28485", "28486", "28487", "28488", "28489", "28490", "28491", "28492", "28600", "28991", "28992", "29100", "29101", "29118", "29119", "29120", "29121", "29122", "29168", "29169", "29170", "29171", "29172", "29177", "29178", "29179", "29180", "29181", "29182", "29183", "29184", "29185", "29187", "29188", "29189", "29190", "29191", "29192", "29193", "29194", "29195", "29220", "29221", "29333", "29371", "29373", "29375", "29377", "29379", "29381", "29383", "29385", "29635", "29636", "29700", "29738", "29739", "29849", "29850", "29871", "29872", "29873", "29900", "29901", "29902", "29903", "30161", "30162", "30163", "30164", "30165", "30166", "30167", "30168", "30169", "30170", "30171", "30172", "30173", "30174", "30175", "30176", "30177", "30178", "30179", "30200", "30339", "30340", "30491", "30492", "30493", "30494", "30729", "30730", "30731", "30732", "30791", "30792", "30800", "31028", "31121", "31154", "31170", "31171", "31265", "31266", "31267", "31268", "31275", "31276", "31277", "31278", "31279", "31281", "31282", "31283", "31284", "31285", "31286", "31287", "31288", "31289", "31290", "31291", "31292", "31293", "31294", "31295", "31296", "31297", "31300", "31370", "31461", "31462", "31463", "31464", "31465", "31466", "31467", "31468", "31469", "31528", "31529", "31600", "31700", "31838", "31839", "31900", "31986", "31987", "31988", "31989", "31990", "31991", "31992", "31993", "31994", "31995", "31996", "31997", "31998", "31999", "32000", "32001", "32002", "32003", "32005", "32006", "32007", "32008", "32009", "32010", "32011", "32012", "32013", "32014", "32015", "32016", "32017", "32018", "32019", "32020", "32021", "32022", "32023", "32024", "32025", "32026", "32027", "32028", "32029", "32030", "32031", "32033", "32034", "32035", "32036", "32037", "32038", "32039", "32040", "32041", "32042", "32043", "32044", "32045", "32046", "32047", "32048", "32049", "32050", "32051", "32052", "32053", "32054", "32055", "32056", "32057", "32058", "32061", "32062", "32064", "32065", "32066", "32067", "32074", "32075", "32076", "32077", "32081", "32082", "32083", "32084", "32085", "32086", "32098", "32100", "32104", "32107", "32108", "32109", "32110", "32111", "32112", "32113", "32114", "32115", "32116", "32117", "32118", "32119", "32120", "32121", "32122", "32123", "32124", "32125", "32126", "32127", "32128", "32129", "32130", "32133", "32134", "32135", "32136", "32137", "32138", "32139", "32140", "32141", "32142", "32143", "32144", "32145", "32146", "32147", "32148", "32149", "32150", "32151", "32152", "32153", "32154", "32155", "32156", "32157", "32158", "32161", "32180", "32181", "32182", "32183", "32184", "32185", "32186", "32187", "32188", "32189", "32190", "32191", "32192", "32193", "32194", "32195", "32196", "32197", "32198", "32201", "32202", "32203", "32204", "32205", "32206", "32207", "32208", "32209", "32210", "32211", "32212", "32213", "32214", "32215", "32216", "32217", "32218", "32219", "32220", "32221", "32222", "32223", "32224", "32225", "32226", "32227", "32228", "32229", "32230", "32231", "32232", "32233", "32234", "32235", "32236", "32237", "32238", "32239", "32240", "32241", "32242", "32243", "32244", "32245", "32246", "32247", "32248", "32249", "32250", "32251", "32252", "32253", "32254", "32255", "32256", "32257", "32258", "32259", "32260", "32301", "32302", "32303", "32304", "32305", "32306", "32307", "32308", "32309", "32310", "32311", "32312", "32313", "32314", "32315", "32316", "32317", "32318", "32319", "32320", "32321", "32322", "32323", "32324", "32325", "32326", "32327", "32328", "32329", "32330", "32331", "32332", "32333", "32334", "32335", "32336", "32337", "32338", "32339", "32340", "32341", "32342", "32343", "32344", "32345", "32346", "32347", "32348", "32349", "32350", "32351", "32352", "32353", "32354", "32355", "32356", "32357", "32358", "32359", "32360", "32401", "32402", "32403", "32404", "32405", "32406", "32407", "32408", "32409", "32410", "32411", "32412", "32413", "32414", "32415", "32416", "32417", "32418", "32419", "32420", "32421", "32422", "32423", "32424", "32425", "32426", "32427", "32428", "32429", "32430", "32431", "32432", "32433", "32434", "32435", "32436", "32437", "32438", "32439", "32440", "32441", "32442", "32443", "32444", "32445", "32446", "32447", "32448", "32449", "32450", "32451", "32452", "32453", "32454", "32455", "32456", "32457", "32458", "32459", "32460", "32501", "32502", "32503", "32504", "32505", "32506", "32507", "32508", "32509", "32510", "32511", "32512", "32513", "32514", "32515", "32516", "32517", "32518", "32519", "32520", "32521", "32522", "32523", "32524", "32525", "32526", "32527", "32528", "32529", "32530", "32531", "32532", "32533", "32534", "32535", "32536", "32537", "32538", "32539", "32540", "32541", "32542", "32543", "32544", "32545", "32546", "32547", "32548", "32549", "32550", "32551", "32552", "32553", "32554", "32555", "32556", "32557", "32558", "32559", "32560", "32601", "32602", "32603", "32604", "32605", "32606", "32607", "32608", "32609", "32610", "32611", "32612", "32613", "32614", "32615", "32616", "32617", "32618", "32619", "32620", "32621", "32622", "32623", "32624", "32625", "32626", "32627", "32628", "32629", "32630", "32631", "32632", "32633", "32634", "32635", "32636", "32637", "32638", "32639", "32640", "32641", "32642", "32643", "32644", "32645", "32646", "32647", "32648", "32649", "32650", "32651", "32652", "32653", "32654", "32655", "32656", "32657", "32658", "32659", "32660", "32661", "32701", "32702", "32703", "32704", "32705", "32706", "32707", "32708", "32709", "32710", "32711", "32712", "32713", "32714", "32715", "32716", "32717", "32718", "32719", "32720", "32721", "32722", "32723", "32724", "32725", "32726", "32727", "32728", "32729", "32730", "32731", "32732", "32733", "32734", "32735", "32736", "32737", "32738", "32739", "32740", "32741", "32742", "32743", "32744", "32745", "32746", "32747", "32748", "32749", "32750", "32751", "32752", "32753", "32754", "32755", "32756", "32757", "32758", "32759", "32760", "32761", "32766"})
        Me.cmdSRID.Location = New System.Drawing.Point(234, 14)
        Me.cmdSRID.Name = "cmdSRID"
        Me.HelpProvider1.SetShowHelp(Me.cmdSRID, True)
        Me.cmdSRID.Size = New System.Drawing.Size(78, 25)
        Me.cmdSRID.TabIndex = 22
        Me.cmdSRID.Text = "4326"
        Me.ToolTip1.SetToolTip(Me.cmdSRID, "Assign output raster with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "specified SRID." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If not provided or is zero," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "raster's" & _
                " metadata will be checked" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to determine an appropriate SRID.")
        '
        'chkSRID
        '
        Me.chkSRID.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkSRID, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkSRID, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkSRID, "Set the raster's SRID")
        Me.chkSRID.Location = New System.Drawing.Point(5, 17)
        Me.chkSRID.Name = "chkSRID"
        Me.HelpProvider1.SetShowHelp(Me.chkSRID, True)
        Me.chkSRID.Size = New System.Drawing.Size(61, 21)
        Me.chkSRID.TabIndex = 21
        Me.chkSRID.Tag = "-s"
        Me.chkSRID.Text = "SRID"
        Me.ToolTip1.SetToolTip(Me.chkSRID, "Assign output raster with" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "specified SRID." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "If not provided or is zero," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "raster's" & _
                " metadata will be checked" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to determine an appropriate SRID." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkSRID.UseVisualStyleBackColor = True
        '
        'chkCb
        '
        Me.chkCb.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkCb, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkCb, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkCb, "Set the standard set of constraints on the raster column after the rasters are lo" & _
                "aded.")
        Me.chkCb.Location = New System.Drawing.Point(5, 72)
        Me.chkCb.Name = "chkCb"
        Me.HelpProvider1.SetShowHelp(Me.chkCb, True)
        Me.chkCb.Size = New System.Drawing.Size(42, 21)
        Me.chkCb.TabIndex = 25
        Me.chkCb.Tag = "-C"
        Me.chkCb.Text = "-C"
        Me.ToolTip1.SetToolTip(Me.chkCb, "Apply raster constraints -- srid, pixelsize etc. to ensure raster" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is properly re" & _
                "gistered in raster_columns view." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkCb.UseVisualStyleBackColor = True
        '
        'txtPathRaster
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtPathRaster, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtPathRaster, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtPathRaster, "Full path to raster image.")
        Me.txtPathRaster.Location = New System.Drawing.Point(129, 111)
        Me.txtPathRaster.Name = "txtPathRaster"
        Me.HelpProvider1.SetShowHelp(Me.txtPathRaster, True)
        Me.txtPathRaster.Size = New System.Drawing.Size(181, 24)
        Me.txtPathRaster.TabIndex = 27
        Me.txtPathRaster.Text = "c://image//raster.jpg"
        Me.ToolTip1.SetToolTip(Me.txtPathRaster, "Get the path of raster image or image's.")
        '
        'btnPathRaster
        '
        Me.HelpProvider1.SetHelpKeyword(Me.btnPathRaster, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.btnPathRaster, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.btnPathRaster, "Get full path to raster image.")
        Me.btnPathRaster.Location = New System.Drawing.Point(3, 108)
        Me.btnPathRaster.Name = "btnPathRaster"
        Me.HelpProvider1.SetShowHelp(Me.btnPathRaster, True)
        Me.btnPathRaster.Size = New System.Drawing.Size(120, 30)
        Me.btnPathRaster.TabIndex = 29
        Me.btnPathRaster.Text = "Load image's..."
        Me.ToolTip1.SetToolTip(Me.btnPathRaster, "Get the path of raster image or image's")
        Me.btnPathRaster.UseVisualStyleBackColor = True
        '
        'chkMb
        '
        Me.chkMb.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkMb, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkMb, System.Windows.Forms.HelpNavigator.TopicId)
        Me.chkMb.Location = New System.Drawing.Point(5, 90)
        Me.chkMb.Name = "chkMb"
        Me.HelpProvider1.SetShowHelp(Me.chkMb, True)
        Me.chkMb.Size = New System.Drawing.Size(44, 21)
        Me.chkMb.TabIndex = 26
        Me.chkMb.Tag = "-M"
        Me.chkMb.Text = "-M"
        Me.ToolTip1.SetToolTip(Me.chkMb, "Vacuum analyze the raster table." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkMb.UseVisualStyleBackColor = True
        '
        'chkUseraster
        '
        Me.chkUseraster.AutoSize = True
        Me.chkUseraster.Checked = True
        Me.chkUseraster.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkUseraster.Enabled = False
        Me.chkUseraster.Location = New System.Drawing.Point(5, 114)
        Me.chkUseraster.Name = "chkUseraster"
        Me.chkUseraster.Size = New System.Drawing.Size(94, 21)
        Me.chkUseraster.TabIndex = 30
        Me.chkUseraster.Text = "Use Raster"
        Me.ToolTip1.SetToolTip(Me.chkUseraster, "Vacuum analyze the raster table." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkUseraster.UseVisualStyleBackColor = True
        Me.chkUseraster.Visible = False
        '
        'chkFb
        '
        Me.chkFb.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkFb, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkFb, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkFb, "Add a column with the filename of the raster.")
        Me.chkFb.Location = New System.Drawing.Point(5, 135)
        Me.chkFb.Name = "chkFb"
        Me.HelpProvider1.SetShowHelp(Me.chkFb, True)
        Me.chkFb.Size = New System.Drawing.Size(40, 21)
        Me.chkFb.TabIndex = 31
        Me.chkFb.Tag = "-F"
        Me.chkFb.Text = "-F"
        Me.ToolTip1.SetToolTip(Me.chkFb, "Add a column with the name of the file." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkFb.UseVisualStyleBackColor = True
        '
        'txtTileSize
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtTileSize, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtTileSize, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtTileSize, "Cut raster into tiles to be inserted one per table row.")
        Me.txtTileSize.Location = New System.Drawing.Point(234, 174)
        Me.txtTileSize.Name = "txtTileSize"
        Me.HelpProvider1.SetShowHelp(Me.txtTileSize, True)
        Me.txtTileSize.Size = New System.Drawing.Size(78, 24)
        Me.txtTileSize.TabIndex = 33
        Me.txtTileSize.Text = "600x800"
        Me.txtTileSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtTileSize, resources.GetString("txtTileSize.ToolTip"))
        '
        'chkTs
        '
        Me.chkTs.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkTs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkTs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkTs, "Cut raster into tiles to be inserted one per table row.")
        Me.chkTs.Location = New System.Drawing.Point(5, 177)
        Me.chkTs.Name = "chkTs"
        Me.HelpProvider1.SetShowHelp(Me.chkTs, True)
        Me.chkTs.Size = New System.Drawing.Size(37, 21)
        Me.chkTs.TabIndex = 32
        Me.chkTs.Tag = "-t"
        Me.chkTs.Text = "-t"
        Me.ToolTip1.SetToolTip(Me.chkTs, resources.GetString("chkTs.ToolTip"))
        Me.chkTs.UseVisualStyleBackColor = True
        '
        'chkHs
        '
        Me.chkHs.AutoSize = True
        Me.HelpProvider1.SetHelpKeyword(Me.chkHs, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.chkHs, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.chkHs, "Server IP.")
        Me.chkHs.Location = New System.Drawing.Point(5, 273)
        Me.chkHs.Name = "chkHs"
        Me.HelpProvider1.SetShowHelp(Me.chkHs, True)
        Me.chkHs.Size = New System.Drawing.Size(40, 21)
        Me.chkHs.TabIndex = 36
        Me.chkHs.Tag = "-h"
        Me.chkHs.Text = "-h"
        Me.ToolTip1.SetToolTip(Me.chkHs, "Server IP." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        Me.chkHs.UseVisualStyleBackColor = True
        '
        'txtServer
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtServer, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtServer, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtServer, "Server IP.")
        Me.txtServer.Location = New System.Drawing.Point(131, 276)
        Me.txtServer.MaxLength = 15
        Me.txtServer.Name = "txtServer"
        Me.HelpProvider1.SetShowHelp(Me.txtServer, True)
        Me.txtServer.Size = New System.Drawing.Size(181, 24)
        Me.txtServer.TabIndex = 37
        Me.txtServer.Text = "127.0.0.1"
        Me.ToolTip1.SetToolTip(Me.txtServer, "Server IP." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtPort
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtPort, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtPort, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtPort, "Port number.")
        Me.txtPort.Location = New System.Drawing.Point(131, 301)
        Me.txtPort.MaxLength = 6
        Me.txtPort.Name = "txtPort"
        Me.HelpProvider1.SetShowHelp(Me.txtPort, True)
        Me.txtPort.Size = New System.Drawing.Size(48, 24)
        Me.txtPort.TabIndex = 39
        Me.txtPort.Text = "5432"
        Me.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.txtPort, "Port number.")
        '
        'txtTablename
        '
        Me.HelpProvider1.SetHelpKeyword(Me.txtTablename, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtTablename, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtTablename, "Create new table or use exisiting table and populate it.")
        Me.txtTablename.Location = New System.Drawing.Point(131, 200)
        Me.txtTablename.MaxLength = 255
        Me.txtTablename.Name = "txtTablename"
        Me.HelpProvider1.SetShowHelp(Me.txtTablename, True)
        Me.txtTablename.Size = New System.Drawing.Size(181, 24)
        Me.txtTablename.TabIndex = 35
        Me.txtTablename.Text = "public.table"
        Me.ToolTip1.SetToolTip(Me.txtTablename, "Create New table and populate it" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "with raster(s)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 17)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Table name:"
        Me.ToolTip1.SetToolTip(Me.Label2, "Create New table and populate it")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 7.841584!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Label3, "User password.")
        Me.Label3.Location = New System.Drawing.Point(128, 150)
        Me.Label3.Name = "Label3"
        Me.HelpProvider1.SetShowHelp(Me.Label3, True)
        Me.Label3.Size = New System.Drawing.Size(70, 14)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Password:"
        Me.ToolTip1.SetToolTip(Me.Label3, "User password." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'txtPassword
        '
        Me.HelpProvider1.SetHelpString(Me.txtPassword, "User password.")
        Me.txtPassword.Location = New System.Drawing.Point(208, 144)
        Me.txtPassword.MaxLength = 255
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.HelpProvider1.SetShowHelp(Me.txtPassword, True)
        Me.txtPassword.Size = New System.Drawing.Size(104, 24)
        Me.txtPassword.TabIndex = 41
        Me.txtPassword.Text = "password"
        Me.ToolTip1.SetToolTip(Me.txtPassword, "User password." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'btnImport
        '
        Me.HelpProvider1.SetHelpString(Me.btnImport, "Import raster to Database.")
        Me.btnImport.Location = New System.Drawing.Point(555, 421)
        Me.btnImport.Name = "btnImport"
        Me.HelpProvider1.SetShowHelp(Me.btnImport, True)
        Me.btnImport.Size = New System.Drawing.Size(73, 23)
        Me.btnImport.TabIndex = 28
        Me.btnImport.Text = "Import..."
        Me.ToolTip1.SetToolTip(Me.btnImport, "To import raster image to database.")
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'labTimer
        '
        Me.labTimer.AutoSize = True
        Me.labTimer.BackColor = System.Drawing.Color.White
        Me.labTimer.Location = New System.Drawing.Point(350, 403)
        Me.labTimer.Name = "labTimer"
        Me.labTimer.Size = New System.Drawing.Size(57, 14)
        Me.labTimer.TabIndex = 43
        Me.labTimer.Text = "00:00:00"
        Me.ToolTip1.SetToolTip(Me.labTimer, "Elapsed Time to get raster image")
        '
        'txtPerview
        '
        Me.txtPerview.BackColor = System.Drawing.Color.White
        Me.HelpProvider1.SetHelpKeyword(Me.txtPerview, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.txtPerview, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.txtPerview, "Preview the result.")
        Me.txtPerview.Location = New System.Drawing.Point(348, 179)
        Me.txtPerview.Multiline = True
        Me.txtPerview.Name = "txtPerview"
        Me.txtPerview.ReadOnly = True
        Me.txtPerview.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.HelpProvider1.SetShowHelp(Me.txtPerview, True)
        Me.txtPerview.Size = New System.Drawing.Size(206, 57)
        Me.txtPerview.TabIndex = 19
        Me.ToolTip1.SetToolTip(Me.txtPerview, "Preview the result.")
        '
        'picDB
        '
        Me.picDB.BackColor = System.Drawing.Color.Transparent
        Me.picDB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.HelpProvider1.SetHelpKeyword(Me.picDB, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.picDB, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.picDB, "Load raster image from database.")
        Me.picDB.Location = New System.Drawing.Point(348, 242)
        Me.picDB.Name = "picDB"
        Me.HelpProvider1.SetShowHelp(Me.picDB, True)
        Me.picDB.Size = New System.Drawing.Size(280, 179)
        Me.picDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDB.TabIndex = 30
        Me.picDB.TabStop = False
        Me.ToolTip1.SetToolTip(Me.picDB, "Load raster image from database.")
        '
        'MenuStrip1
        '
        Me.HelpProvider1.SetHelpString(Me.MenuStrip1, "Sytem  menu.")
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_File, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.HelpProvider1.SetShowHelp(Me.MenuStrip1, True)
        Me.MenuStrip1.Size = New System.Drawing.Size(634, 25)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuItem_File
        '
        Me.MenuItem_File.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_GetImage, Me.ToolStripSeparator1, Me.MenuItem_Exit})
        Me.MenuItem_File.Name = "MenuItem_File"
        Me.MenuItem_File.Size = New System.Drawing.Size(39, 21)
        Me.MenuItem_File.Text = "&File"
        '
        'MenuItem_GetImage
        '
        Me.MenuItem_GetImage.Name = "MenuItem_GetImage"
        Me.MenuItem_GetImage.Size = New System.Drawing.Size(136, 22)
        Me.MenuItem_GetImage.Text = "Get Image"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(133, 6)
        '
        'MenuItem_Exit
        '
        Me.MenuItem_Exit.Name = "MenuItem_Exit"
        Me.MenuItem_Exit.Size = New System.Drawing.Size(136, 22)
        Me.MenuItem_Exit.Text = "E&xit"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItem_Contents, Me.ToolStripSeparator2, Me.MenuItem_SendFeedback, Me.toolStripSeparator5, Me.MenuItem_About})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(47, 21)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'MenuItem_SendFeedback
        '
        Me.MenuItem_SendFeedback.Name = "MenuItem_SendFeedback"
        Me.MenuItem_SendFeedback.Size = New System.Drawing.Size(162, 22)
        Me.MenuItem_SendFeedback.Text = "Send feedback"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(159, 6)
        '
        'MenuItem_Contents
        '
        Me.MenuItem_Contents.Name = "MenuItem_Contents"
        Me.MenuItem_Contents.Size = New System.Drawing.Size(162, 22)
        Me.MenuItem_Contents.Text = "&Contents"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(159, 6)
        '
        'MenuItem_About
        '
        Me.MenuItem_About.Name = "MenuItem_About"
        Me.MenuItem_About.Size = New System.Drawing.Size(162, 22)
        Me.MenuItem_About.Text = "&About..."
        '
        'btn_Perview
        '
        Me.HelpProvider1.SetHelpString(Me.btn_Perview, "Preview the result.")
        Me.btn_Perview.Location = New System.Drawing.Point(555, 213)
        Me.btn_Perview.Name = "btn_Perview"
        Me.HelpProvider1.SetShowHelp(Me.btn_Perview, True)
        Me.btn_Perview.Size = New System.Drawing.Size(73, 23)
        Me.btn_Perview.TabIndex = 23
        Me.btn_Perview.Text = "Perview..."
        Me.btn_Perview.UseVisualStyleBackColor = True
        '
        'llabURL
        '
        Me.llabURL.AutoSize = True
        Me.llabURL.Location = New System.Drawing.Point(29, 39)
        Me.llabURL.Name = "llabURL"
        Me.llabURL.Size = New System.Drawing.Size(276, 17)
        Me.llabURL.TabIndex = 23
        Me.llabURL.TabStop = True
        Me.llabURL.Text = "http://spatialreference.org/ref/epsg/?page=1"
        '
        'gbBasicSetting
        '
        Me.gbBasicSetting.BackColor = System.Drawing.Color.Transparent
        Me.gbBasicSetting.Controls.Add(Me.chkCb)
        Me.gbBasicSetting.Controls.Add(Me.Label2)
        Me.gbBasicSetting.Controls.Add(Me.txtPassword)
        Me.gbBasicSetting.Controls.Add(Me.txtPort)
        Me.gbBasicSetting.Controls.Add(Me.chkAs)
        Me.gbBasicSetting.Controls.Add(Me.chkHs)
        Me.gbBasicSetting.Controls.Add(Me.chkPs)
        Me.gbBasicSetting.Controls.Add(Me.txtServer)
        Me.gbBasicSetting.Controls.Add(Me.Label3)
        Me.gbBasicSetting.Controls.Add(Me.txtTablename)
        Me.gbBasicSetting.Controls.Add(Me.btnPathRaster)
        Me.gbBasicSetting.Controls.Add(Me.txtUsername)
        Me.gbBasicSetting.Controls.Add(Me.txtTileSize)
        Me.gbBasicSetting.Controls.Add(Me.chkUsername)
        Me.gbBasicSetting.Controls.Add(Me.chkTs)
        Me.gbBasicSetting.Controls.Add(Me.chkDs)
        Me.gbBasicSetting.Controls.Add(Me.chkFb)
        Me.gbBasicSetting.Controls.Add(Me.txtFs)
        Me.gbBasicSetting.Controls.Add(Me.txtDatabasename)
        Me.gbBasicSetting.Controls.Add(Me.llabURL)
        Me.gbBasicSetting.Controls.Add(Me.chkFs)
        Me.gbBasicSetting.Controls.Add(Me.chkUseraster)
        Me.gbBasicSetting.Controls.Add(Me.chkSRID)
        Me.gbBasicSetting.Controls.Add(Me.txtPathRaster)
        Me.gbBasicSetting.Controls.Add(Me.chkIb)
        Me.gbBasicSetting.Controls.Add(Me.cmdSRID)
        Me.gbBasicSetting.Controls.Add(Me.chkMb)
        Me.gbBasicSetting.Font = New System.Drawing.Font("Times New Roman", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpKeyword(Me.gbBasicSetting, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.gbBasicSetting, System.Windows.Forms.HelpNavigator.TopicId)
        Me.gbBasicSetting.Location = New System.Drawing.Point(9, 96)
        Me.gbBasicSetting.Name = "gbBasicSetting"
        Me.HelpProvider1.SetShowHelp(Me.gbBasicSetting, True)
        Me.gbBasicSetting.Size = New System.Drawing.Size(333, 350)
        Me.gbBasicSetting.TabIndex = 24
        Me.gbBasicSetting.TabStop = False
        Me.gbBasicSetting.Text = "Basic Setting:"
        '
        'gbMoreSetting
        '
        Me.gbMoreSetting.BackColor = System.Drawing.Color.Transparent
        Me.gbMoreSetting.Controls.Add(Me.txtBand)
        Me.gbMoreSetting.Controls.Add(Me.chkRs)
        Me.gbMoreSetting.Controls.Add(Me.chkEs)
        Me.gbMoreSetting.Controls.Add(Me.chkBand)
        Me.gbMoreSetting.Controls.Add(Me.chkNb)
        Me.gbMoreSetting.Font = New System.Drawing.Font("Times New Roman", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMoreSetting.ForeColor = System.Drawing.Color.Red
        Me.gbMoreSetting.Location = New System.Drawing.Point(348, 96)
        Me.gbMoreSetting.Name = "gbMoreSetting"
        Me.gbMoreSetting.Size = New System.Drawing.Size(280, 77)
        Me.gbMoreSetting.TabIndex = 25
        Me.gbMoreSetting.TabStop = False
        Me.gbMoreSetting.Text = "More Setting:"
        '
        'cmbPresetting
        '
        Me.cmbPresetting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPresetting.FormattingEnabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.cmbPresetting, "how to...")
        Me.HelpProvider1.SetHelpNavigator(Me.cmbPresetting, System.Windows.Forms.HelpNavigator.TopicId)
        Me.HelpProvider1.SetHelpString(Me.cmbPresetting, "You can choose any setting [Create-Append].")
        Me.cmbPresetting.Location = New System.Drawing.Point(107, 31)
        Me.cmbPresetting.Name = "cmbPresetting"
        Me.HelpProvider1.SetShowHelp(Me.cmbPresetting, True)
        Me.cmbPresetting.Size = New System.Drawing.Size(521, 21)
        Me.cmbPresetting.TabIndex = 26
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.980198!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Label1, "You can choose any setting [Create-Append].")
        Me.Label1.Location = New System.Drawing.Point(3, 33)
        Me.Label1.Name = "Label1"
        Me.HelpProvider1.SetShowHelp(Me.Label1, True)
        Me.Label1.Size = New System.Drawing.Size(106, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Choose Setting:"
        '
        'ofdRaster
        '
        Me.ofdRaster.FileName = "OpenFileDialog1"
        '
        'errorOK
        '
        Me.errorOK.ContainerControl = Me
        Me.errorOK.Icon = CType(resources.GetObject("errorOK.Icon"), System.Drawing.Icon)
        '
        'errorNo
        '
        Me.errorNo.ContainerControl = Me
        Me.errorNo.Icon = CType(resources.GetObject("errorNo.Icon"), System.Drawing.Icon)
        '
        'HelpProvider1
        '
        Me.HelpProvider1.HelpNamespace = "E:\VB.Net2008\FamilyCare\Sub_Projects\ImportRasterIntoPostgres\ImportRasterIntoPo" & _
            "stgres\bin\Debug\ImportRaster.chm"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(634, 447)
        Me.Controls.Add(Me.labTimer)
        Me.Controls.Add(Me.picDB)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btn_Perview)
        Me.Controls.Add(Me.cmbPresetting)
        Me.Controls.Add(Me.gbMoreSetting)
        Me.Controls.Add(Me.gbBasicSetting)
        Me.Controls.Add(Me.txtPerview)
        Me.Controls.Add(Me.btnPath)
        Me.Controls.Add(Me.txtPathExe)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpKeyword(Me, "Main")
        Me.HelpProvider1.SetHelpNavigator(Me, System.Windows.Forms.HelpNavigator.TopicId)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Postgres DB Raster Importer"
        Me.ToolTip1.SetToolTip(Me, "Postgres DB Raster Importer By Azz@Home")
        CType(Me.picDB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbBasicSetting.ResumeLayout(False)
        Me.gbBasicSetting.PerformLayout()
        Me.gbMoreSetting.ResumeLayout(False)
        Me.gbMoreSetting.PerformLayout()
        CType(Me.errorOK, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errorNo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPathExe As System.Windows.Forms.TextBox
    Friend WithEvents btnPath As System.Windows.Forms.Button
    Friend WithEvents chkBand As System.Windows.Forms.CheckBox
    Friend WithEvents txtBand As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents chkNb As System.Windows.Forms.CheckBox
    Friend WithEvents chkPs As System.Windows.Forms.CheckBox
    Friend WithEvents chkAs As System.Windows.Forms.CheckBox
    Friend WithEvents chkRs As System.Windows.Forms.CheckBox
    Friend WithEvents chkEs As System.Windows.Forms.CheckBox
    Friend WithEvents chkIb As System.Windows.Forms.CheckBox
    Friend WithEvents chkFs As System.Windows.Forms.CheckBox
    Friend WithEvents txtFs As System.Windows.Forms.TextBox
    Friend WithEvents txtPerview As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btn_Perview As System.Windows.Forms.Button
    Friend WithEvents MenuItem_File As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_Exit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuItem_Contents As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItem_About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chkUsername As System.Windows.Forms.CheckBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents txtDatabasename As System.Windows.Forms.TextBox
    Friend WithEvents chkDs As System.Windows.Forms.CheckBox
    Friend WithEvents cmdSRID As System.Windows.Forms.ComboBox
    Friend WithEvents chkSRID As System.Windows.Forms.CheckBox
    Friend WithEvents llabURL As System.Windows.Forms.LinkLabel
    Friend WithEvents chkCb As System.Windows.Forms.CheckBox
    Friend WithEvents txtPathRaster As System.Windows.Forms.TextBox
    Friend WithEvents btnPathRaster As System.Windows.Forms.Button
    Friend WithEvents chkUseraster As System.Windows.Forms.CheckBox
    Friend WithEvents chkMb As System.Windows.Forms.CheckBox
    Friend WithEvents txtTileSize As System.Windows.Forms.TextBox
    Friend WithEvents chkTs As System.Windows.Forms.CheckBox
    Friend WithEvents chkFb As System.Windows.Forms.CheckBox
    Friend WithEvents txtTablename As System.Windows.Forms.TextBox
    Friend WithEvents gbBasicSetting As System.Windows.Forms.GroupBox
    Friend WithEvents chkHs As System.Windows.Forms.CheckBox
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents gbMoreSetting As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPresetting As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents fbdShow As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents ofdRaster As System.Windows.Forms.OpenFileDialog
    Friend WithEvents errorOK As System.Windows.Forms.ErrorProvider
    Friend WithEvents errorNo As System.Windows.Forms.ErrorProvider
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents picDB As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents labTimer As System.Windows.Forms.Label
    Friend WithEvents MenuItem_GetImage As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuItem_SendFeedback As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator

End Class
