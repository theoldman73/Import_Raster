'The key=Win32_VideoController
'Name=Intel(R) HD Graphics
'share.Properties.Count=59
'PC [PC-Value]:= AdapterCompatibility - Intel Corporation
'PC [PC-Value]:= AdapterDACType - Internal
'PC [PC-Value]:= AdapterRAM - 1606045696
'PC [PC-Value]:= Availability - 3
'PC [PC-Value]:= Caption - Intel(R) HD Graphics
'PC [PC-Value]:= CreationClassName - Win32_VideoController
'PC [PC-Value]:= CurrentBitsPerPixel - 32
'PC [PC-Value]:= CurrentHorizontalResolution - 1440
'PC [PC-Value]:= CurrentNumberOfColors - 4294967296
'PC [PC-Value]:= CurrentRefreshRate - 59
'PC [PC-Value]:= CurrentScanMode - 4
'PC [PC-Value]:= CurrentVerticalResolution - 900
'PC [PC-Value]:= Description - Intel(R) HD Graphics
'PC [PC-Value]:= DeviceID - VideoController1
'PC [PC-Value]:= DriverDate - 20110107000000.000000-000
'PC [PC-Value]:= DriverVersion - 8.15.10.2279
'PC [PC-Value]:= InfFilename - oem1.inf
'PC [PC-Value]:= InfSection - iILKD0
'PC [PC-Value]:= InstalledDisplayDrivers - igdumdx32.dll,igd10umd32.dll
'PC [PC-Value]:= MaxRefreshRate - 75
'PC [PC-Value]:= MinRefreshRate - 59
'PC [PC-Value]:= Name - Intel(R) HD Graphics
'PC [PC-Value]:= PNPDeviceID - PCI\VEN_8086&DEV_0042&SUBSYS_304B103C&REV_02\3&33FD14CA&0&10
'PC [PC-Value]:= Status - OK
'PC [PC-Value]:= SystemCreationClassName - Win32_ComputerSystem
'PC [PC-Value]:= SystemName - ORC-VBNET-PC
'PC [PC-Value]:= VideoArchitecture - 5
'PC [PC-Value]:= VideoMemoryType - 2
'PC [PC-Value]:= VideoModeDescription - 1440 x 900 x 4294967296 colors
'PC [PC-Value]:= VideoProcessor - Intel(R) HD Graphics (Core i5)
Imports System.Management
Public Class CVideoGraphics
    Inherits CHardWare
    Private pInfSection As String = String.Empty
    Public ReadOnly Property InfSection As String
        Get
            Return pInfSection
        End Get
        'Set(value As String)
        '    pInfSection = value
        'End Set
    End Property
    Private pAdapterCompatibility As String = String.Empty
    Public ReadOnly Property AdapterCompatibility As String
        Get
            Return pAdapterCompatibility
        End Get
        'Set(value As String)
        '    pAdapterCompatibility = value
        'End Set
    End Property
    Private pAdapterDACType As String = String.Empty
    Public ReadOnly Property AdapterDACType As String
        Get
            Return pAdapterDACType
        End Get
        'Set(value As String)
        '    pAdapterDACType = value
        'End Set
    End Property
    Private pAdapterRAM As String = String.Empty
    Public ReadOnly Property AdapterRAM As String
        Get
            Return pAdapterRAM
        End Get
        'Set(value As String)
        '    pAdapterRAM = value
        'End Set
    End Property
    Private pCurrentBitsPerPixel As String = String.Empty
    Public ReadOnly Property CurrentBitsPerPixel As String
        Get
            Return pCurrentBitsPerPixel
        End Get
        'Set(value As String)
        '    pCurrentBitsPerPixel = value
        'End Set
    End Property
    Private pCurrentHorizontalResolution As String = String.Empty
    Public ReadOnly Property CurrentHorizontalResolution As String
        Get
            Return pCurrentHorizontalResolution
        End Get
        'Set(value As String)
        '    pCurrentHorizontalResolution = value
        'End Set
    End Property
    Private pCurrentNumberOfColors As String = String.Empty
    Public ReadOnly Property CurrentNumberOfColors As String
        Get
            Return pCurrentNumberOfColors
        End Get
        'Set(value As String)
        '    pCurrentNumberOfColors = value
        'End Set
    End Property
    Private pCurrentRefreshRate As String = String.Empty
    Public ReadOnly Property CurrentRefreshRate As String
        Get
            Return pCurrentRefreshRate
        End Get
        'Set(value As String)
        '    pCurrentRefreshRate = value
        'End Set
    End Property
    Private pCurrentScanMode As String = String.Empty
    Public ReadOnly Property CurrentScanMode As String
        Get
            Return pCurrentScanMode
        End Get
        'Set(value As String)
        '    pCurrentScanMode = value
        'End Set
    End Property
    Private pCurrentVerticalResolution As String = String.Empty
    Public ReadOnly Property CurrentVerticalResolution As String
        Get
            Return pCurrentVerticalResolution
        End Get
        'Set(value As String)
        '    pCurrentVerticalResolution = value
        'End Set
    End Property
    Private pDriverDate As String = String.Empty
    Public ReadOnly Property DriverDate As String
        Get
            Return pDriverDate
        End Get
        'Set(value As String)
        '    pDriverDate = value
        'End Set
    End Property
    Private pDriverVersion As String = String.Empty
    Public ReadOnly Property DriverVersion As String
        Get
            Return pDriverVersion
        End Get
        'Set(value As String)
        '    pDriverVersion = value
        'End Set
    End Property
    Private pInfFilename As String = String.Empty
    Public ReadOnly Property InfFilename As String
        Get
            Return pInfFilename
        End Get
        'Set(value As String)
        '    pInfFilename = value
        'End Set
    End Property
    Private pInstalledDisplayDrivers As String = String.Empty
    Public ReadOnly Property InstalledDisplayDrivers As String
        Get
            Return pInstalledDisplayDrivers
        End Get
        'Set(value As String)
        '    pInstalledDisplayDrivers = value
        'End Set
    End Property
    Private pMaxRefreshRate As String = String.Empty
    Public ReadOnly Property MaxRefreshRate As String
        Get
            Return pMaxRefreshRate
        End Get
        'Set(value As String)
        '    pMaxRefreshRate = value
        'End Set
    End Property
    Private pMinRefreshRate As String = String.Empty
    Public ReadOnly Property MinRefreshRate As String
        Get
            Return pMinRefreshRate
        End Get
        'Set(value As String)
        '    pMinRefreshRate = value
        'End Set
    End Property
    Private pPNPDeviceID As String = String.Empty
    Public ReadOnly Property PNPDeviceID As String
        Get
            Return pPNPDeviceID
        End Get
        'Set(value As String)
        '    pPNPDeviceID = value
        'End Set
    End Property
    Private pVideoArchitecture As String = String.Empty
    Public ReadOnly Property VideoArchitecture As String
        Get
            Return pVideoArchitecture
        End Get
        'Set(value As String)
        '    pVideoArchitecture = value
        'End Set
    End Property
    Private pVideoMemoryType As String = String.Empty
    Public ReadOnly Property VideoMemoryType As String
        Get
            Return pVideoMemoryType
        End Get
        'Set(value As String)
        '    pVideoMemoryType = value
        'End Set
    End Property
    Private pVideoModeDescription As String = String.Empty
    Public ReadOnly Property VideoModeDescription As String
        Get
            Return pVideoModeDescription
        End Get
        'Set(value As String)
        '    pVideoModeDescription = value
        'End Set
    End Property
    Private pVideoProcessor As String = String.Empty
    Public ReadOnly Property VideoProcessor As String
        Get
            Return pVideoProcessor
        End Get
        'Set(value As String)
        '    pVideoProcessor = value
        'End Set
    End Property
    Public Sub Info(ByVal Key As String)
        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("select * from " + Key)
        Try
            Dim share As ManagementObject
            For Each share In searcher.Get()
                'Debug.Print("Name={0}", share("Name").ToString)
                'Debug.Print("share.Properties.Count={0}", share.Properties.Count)
                If (share.Properties.Count <= 0) Then
                    MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim PC As PropertyData
                For Each PC In share.Properties
                    If PC.Value <> Nothing Then
                        'Debug.Print("PC [PC-Value]:= {0} - {1}", PC.Name.ToString, PC.Value.ToString)
                        Select Case PC.Name.ToString
                            Case "AdapterCompatibility"
                                Me.pAdapterCompatibility = PC.Value.ToString
                            Case "AdapterDACType"
                                Me.pAdapterDACType = PC.Value.ToString
                            Case "AdapterRAM"
                                Me.pAdapterRAM = PC.Value.ToString
                            Case "Availability"
                                MyBase.Availability = PC.Value.ToString
                            Case "Caption"
                                MyBase.Caption = PC.Value.ToString
                            Case "CreationClassName"
                                MyBase.CreationClassName = PC.Value.ToString
                            Case "CurrentBitsPerPixel"
                                Me.pCurrentBitsPerPixel = PC.Value.ToString
                            Case "CurrentHorizontalResolution"
                                Me.pCurrentHorizontalResolution = PC.Value.ToString
                            Case "CurrentNumberOfColors"
                                Me.pCurrentNumberOfColors = PC.Value.ToString
                            Case "CurrentRefreshRate"
                                Me.pCurrentRefreshRate = PC.Value.ToString
                            Case "CurrentScanMode"
                                Me.pCurrentScanMode = PC.Value.ToString
                            Case "CurrentVerticalResolution"
                                Me.pCurrentVerticalResolution = PC.Value.ToString
                            Case "Description"
                                MyBase.Description = PC.Value.ToString
                            Case "DeviceID"
                                MyBase.DeviceID = PC.Value.ToString
                            Case "DriverDate"
                                Me.pDriverDate = PC.Value.ToString
                            Case "DriverVersion"
                                Me.pDriverVersion = PC.Value.ToString
                            Case "InfFilename"
                                Me.pInfFilename = PC.Value.ToString
                            Case "InfSection"
                                Me.pInfSection = PC.Value.ToString
                            Case "InstalledDisplayDrivers"
                                Me.pInstalledDisplayDrivers = PC.Value.ToString
                            Case "MaxRefreshRate"
                                Me.pMaxRefreshRate = PC.Value.ToString
                            Case "MinRefreshRate"
                                Me.pMinRefreshRate = PC.Value.ToString
                            Case "Name"
                                MyBase.Name = PC.Value.ToString
                            Case "PNPDeviceID"
                                Me.pPNPDeviceID = PC.Value.ToString
                            Case "Status"
                                MyBase.Status = PC.Value.ToString
                            Case "SystemCreationClassName"
                                MyBase.SystemCreationClassName = PC.Value.ToString
                            Case "SystemName"
                                MyBase.SystemName = PC.Value.ToString
                            Case "VideoArchitecture"
                                Me.pVideoArchitecture = PC.Value.ToString
                            Case "VideoMemoryType"
                                Me.pVideoMemoryType = PC.Value.ToString
                            Case "VideoModeDescription"
                                Me.pVideoModeDescription = PC.Value.ToString
                            Case "VideoProcessor"
                                Me.pVideoProcessor = PC.Value.ToString
                        End Select
                    End If
                Next
            Next
            Stop
        Catch ex As Exception
            MessageBox.Show("can't get data because of the followeing error \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Sub Info()
        Dim Key As String = "Win32_VideoController"
        Dim searcher As ManagementObjectSearcher = New ManagementObjectSearcher("select * from " + Key)
        Try
            Dim share As ManagementObject
            For Each share In searcher.Get()
                'Debug.Print("Name={0}", share("Name").ToString)
                'Debug.Print("share.Properties.Count={0}", share.Properties.Count)
                If (share.Properties.Count <= 0) Then
                    MessageBox.Show("No Information Available", "No Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If

                Dim PC As PropertyData
                For Each PC In share.Properties
                    If PC.Value <> Nothing Then
                        'Debug.Print("PC [PC-Value]:= {0} - {1}", PC.Name.ToString, PC.Value.ToString)
                        Select Case PC.Name.ToString
                            Case "AdapterCompatibility"
                                Me.pAdapterCompatibility = PC.Value.ToString
                            Case "AdapterDACType"
                                Me.pAdapterDACType = PC.Value.ToString
                            Case "AdapterRAM"
                                Me.pAdapterRAM = PC.Value.ToString
                            Case "Availability"
                                MyBase.Availability = PC.Value.ToString
                            Case "Caption"
                                MyBase.Caption = PC.Value.ToString
                            Case "CreationClassName"
                                MyBase.CreationClassName = PC.Value.ToString
                            Case "CurrentBitsPerPixel"
                                Me.pCurrentBitsPerPixel = PC.Value.ToString
                            Case "CurrentHorizontalResolution"
                                Me.pCurrentHorizontalResolution = PC.Value.ToString
                            Case "CurrentNumberOfColors"
                                Me.pCurrentNumberOfColors = PC.Value.ToString
                            Case "CurrentRefreshRate"
                                Me.pCurrentRefreshRate = PC.Value.ToString
                            Case "CurrentScanMode"
                                Me.pCurrentScanMode = PC.Value.ToString
                            Case "CurrentVerticalResolution"
                                Me.pCurrentVerticalResolution = PC.Value.ToString
                            Case "Description"
                                MyBase.Description = PC.Value.ToString
                            Case "DeviceID"
                                MyBase.DeviceID = PC.Value.ToString
                            Case "DriverDate"
                                Me.pDriverDate = PC.Value.ToString
                            Case "DriverVersion"
                                Me.pDriverVersion = PC.Value.ToString
                            Case "InfFilename"
                                Me.pInfFilename = PC.Value.ToString
                            Case "InfSection"
                                Me.pInfSection = PC.Value.ToString
                            Case "InstalledDisplayDrivers"
                                Me.pInstalledDisplayDrivers = PC.Value.ToString
                            Case "MaxRefreshRate"
                                Me.pMaxRefreshRate = PC.Value.ToString
                            Case "MinRefreshRate"
                                Me.pMinRefreshRate = PC.Value.ToString
                            Case "Name"
                                MyBase.Name = PC.Value.ToString
                            Case "PNPDeviceID"
                                Me.pPNPDeviceID = PC.Value.ToString
                            Case "Status"
                                MyBase.Status = PC.Value.ToString
                            Case "SystemCreationClassName"
                                MyBase.SystemCreationClassName = PC.Value.ToString
                            Case "SystemName"
                                MyBase.SystemName = PC.Value.ToString
                            Case "VideoArchitecture"
                                Me.pVideoArchitecture = PC.Value.ToString
                            Case "VideoMemoryType"
                                Me.pVideoMemoryType = PC.Value.ToString
                            Case "VideoModeDescription"
                                Me.pVideoModeDescription = PC.Value.ToString
                            Case "VideoProcessor"
                                Me.pVideoProcessor = PC.Value.ToString
                        End Select
                    End If
                Next
            Next
            'Stop
        Catch ex As Exception
            MessageBox.Show("can't get data because of the followeing error..." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Sub New()
        Me.Info()
    End Sub

    Public Overrides Function ToString() As String
        Return "CVideoGraphics"
    End Function
End Class
