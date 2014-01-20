'Name=Physical Memory
'share.Properties.Count=30
'PC [PC-Value]:= Capacity - 2147483648
'PC [PC-Value]:= Caption - Physical Memory
'PC [PC-Value]:= CreationClassName - Win32_PhysicalMemory
'PC [PC-Value]:= DataWidth - 64
'PC [PC-Value]:= Description - Physical Memory
'PC [PC-Value]:= DeviceLocator - XMM1
'PC [PC-Value]:= FormFactor - 8
'PC [PC-Value]:= InterleaveDataDepth - 2
'PC [PC-Value]:= InterleavePosition - 1
'PC [PC-Value]:= Manufacturer - JEDEC ID:80 2C
'PC [PC-Value]:= Name - Physical Memory
'PC [PC-Value]:= PartNumber - 8JTF25664AZ-1G4D1
'PC [PC-Value]:= PositionInRow - 1
'PC [PC-Value]:= SerialNumber - 16D23729
'PC [PC-Value]:= Speed - 1333
'PC [PC-Value]:= Tag - Physical Memory 0
'PC [PC-Value]:= TotalWidth - 64
'PC [PC-Value]:= TypeDetail - 128
'Name=Physical Memory
'share.Properties.Count=30
'PC [PC-Value]:= Capacity - 2147483648
'PC [PC-Value]:= Caption - Physical Memory
'PC [PC-Value]:= CreationClassName - Win32_PhysicalMemory
'PC [PC-Value]:= DataWidth - 64
'PC [PC-Value]:= Description - Physical Memory
'PC [PC-Value]:= DeviceLocator - XMM3
'PC [PC-Value]:= FormFactor - 8
'PC [PC-Value]:= InterleaveDataDepth - 2
'PC [PC-Value]:= InterleavePosition - 2
'PC [PC-Value]:= Manufacturer - JEDEC ID:80 2C
'PC [PC-Value]:= Name - Physical Memory
'PC [PC-Value]:= PartNumber - 8JTF25664AZ-1G4D1
'PC [PC-Value]:= PositionInRow - 1
'PC [PC-Value]:= SerialNumber - 17D23729
'PC [PC-Value]:= Speed - 1333
'PC [PC-Value]:= Tag - Physical Memory 2
'PC [PC-Value]:= TotalWidth - 64
'PC [PC-Value]:= TypeDetail - 128
'Name=Physical Memory
'share.Properties.Count=30
'PC [PC-Value]:= Capacity - 4194304
'PC [PC-Value]:= Caption - Physical Memory
'PC [PC-Value]:= CreationClassName - Win32_PhysicalMemory
'PC [PC-Value]:= DataWidth - 2
'PC [PC-Value]:= Description - Physical Memory
'PC [PC-Value]:= DeviceLocator - SYSTEM ROM
'PC [PC-Value]:= MemoryType - 11
'PC [PC-Value]:= Name - Physical Memory
'PC [PC-Value]:= PositionInRow - 1
'PC [PC-Value]:= Tag - Physical Memory 4
'PC [PC-Value]:= TotalWidth - 2
'PC [PC-Value]:= TypeDetail - 4096
Imports System.Management

Public Class CMemory
    Inherits CHardWare
    Private pCapacity As String = String.Empty
    Public Property Capacity As String
        Get
            Return pCapacity
        End Get
        Set(value As String)
            pCapacity = value
        End Set
    End Property
    Private pDataWidth As String = String.Empty
    Public Property DataWidth As String
        Get
            Return pDataWidth
        End Get
        Set(value As String)
            pDataWidth = value
        End Set
    End Property
    Private pDeviceLocator As String = String.Empty
    Public Property DeviceLocator As String
        Get
            Return pDeviceLocator
        End Get
        Set(value As String)
            pDeviceLocator = value
        End Set
    End Property
    Private pFormFactor As String = String.Empty
    Public Property FormFactor As String
        Get
            Return pFormFactor
        End Get
        Set(value As String)
            pFormFactor = value
        End Set
    End Property
    Private pInterleaveDataDepth As String = String.Empty
    Public Property InterleaveDataDepth As String
        Get
            Return pInterleaveDataDepth
        End Get
        Set(value As String)
            pInterleaveDataDepth = value
        End Set
    End Property
    Private pInterleavePosition As String = String.Empty
    Public Property InterleavePosition As String
        Get
            Return pInterleavePosition
        End Get
        Set(value As String)
            pInterleavePosition = value
        End Set
    End Property
    Private pManufacturer As String = String.Empty
    Public Property Manufacturer As String
        Get
            Return pManufacturer
        End Get
        Set(value As String)
            pManufacturer = value
        End Set
    End Property
    Private pPartNumber As String = String.Empty
    Public Property PartNumber As String
        Get
            Return pPartNumber
        End Get
        Set(value As String)
            pPartNumber = value
        End Set
    End Property
    Private pPositionInRow As String = String.Empty
    Public Property PositionInRow As String
        Get
            Return pPositionInRow
        End Get
        Set(value As String)
            pPositionInRow = value
        End Set
    End Property
    Private pSerialNumber As String = String.Empty
    Public Property SerialNumber As String
        Get
            Return pSerialNumber
        End Get
        Set(value As String)
            pSerialNumber = value
        End Set
    End Property
    Private pSpeed As String = String.Empty
    Public Property Speed As String
        Get
            Return pSpeed
        End Get
        Set(value As String)
            pSpeed = value
        End Set
    End Property
    Private pTag As String = String.Empty
    Public Property Tag As String
        Get
            Return pTag
        End Get
        Set(value As String)
            pTag = value
        End Set
    End Property
    Private pTotalWidth As String = String.Empty
    Public Property TotalWidth As String
        Get
            Return pTotalWidth
        End Get
        Set(value As String)
            pTotalWidth = value
        End Set
    End Property
    Private pTypeDetail As String = String.Empty
    Public Property TypeDetail As String
        Get
            Return pTypeDetail
        End Get
        Set(value As String)
            pTypeDetail = value
        End Set
    End Property

    Public Overridable Sub Info()
        Debug.Print("Do nothing.")
    End Sub

    Public Overrides Function ToString() As String
        Return "CMemory"
    End Function
End Class
