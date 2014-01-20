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

Imports System.Management
Public Class CMemoryInfo
    Inherits CMemory
    Private pIndex As Integer = 0
    Private Mem As New List(Of CMemory)

    Sub New()
        Me.Info()
        SendClass()
    End Sub
    Private pCount As Integer = 0
    Public ReadOnly Property Count As Integer
        Get
            Return pCount
        End Get
        'Set(value As Integer)
        '    pCount = value
        'End Set
    End Property
    Public Property Index As Integer
        Get
            Return pIndex
        End Get
        Set(value As Integer)
            pIndex = value
            SendClass(pIndex)
        End Set
    End Property
    Public Overrides Sub Info()
        Dim Key As String = "Win32_PhysicalMemory"
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
                Dim tmpMem As New CMemory
                For Each PC In share.Properties
                    If PC.Value <> Nothing Then
                        'Debug.Print("PC [PC-Value]:= {0} - {1}", PC.Name.ToString, PC.Value.ToString)
                        If PC.Name = "Capacity" Then
                            tmpMem = New CMemory
                        End If
                        Select Case PC.Name.ToString
                            Case "Capacity"
                                tmpMem.Capacity = PC.Value.ToString
                            Case "Caption"
                                tmpMem.Caption = PC.Value.ToString
                            Case "CreationClassName"
                                tmpMem.CreationClassName = PC.Value.ToString
                            Case "DataWidth"
                                tmpMem.DataWidth = PC.Value.ToString
                            Case "Description"
                                tmpMem.Description = PC.Value.ToString
                            Case "DeviceLocator"
                                tmpMem.DeviceLocator = PC.Value.ToString
                            Case "FormFactor"
                                tmpMem.FormFactor = PC.Value.ToString
                            Case "InterleaveDataDepth"
                                tmpMem.InterleaveDataDepth = PC.Value.ToString
                            Case "InterleavePosition"
                                tmpMem.InterleavePosition = PC.Value.ToString
                            Case "Manufacturer"
                                tmpMem.Manufacturer = PC.Value.ToString
                            Case "Name"
                                tmpMem.Name = PC.Value.ToString
                            Case "PartNumber"
                                tmpMem.PartNumber = PC.Value.ToString
                            Case "PositionInRow"
                                tmpMem.PositionInRow = PC.Value.ToString
                            Case "SerialNumber"
                                tmpMem.SerialNumber = PC.Value.ToString
                            Case "Speed"
                                tmpMem.Speed = PC.Value.ToString
                            Case "Tag"
                                tmpMem.Tag = PC.Value.ToString
                            Case "TotalWidth"
                                tmpMem.TotalWidth = PC.Value.ToString
                            Case "TypeDetail"
                                tmpMem.TypeDetail = PC.Value.ToString
                           End Select
                        If PC.Name = "TypeDetail" Then
                            'Debug.Print("PC [PC-Value]:= {0} - {1}", PC.Name.ToString, PC.Value.ToString)
                            Mem.Add(tmpMem)
                            tmpMem = Nothing
                            'Stop
                        End If
                    End If
                Next
            Next
            'Stop
            pCount = Mem.Count - 1
        Catch ex As Exception
            MessageBox.Show("can't get data because of the followeing error..." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Overrides Function ToString() As String
        Return "CMemoryInfo"
    End Function

    Protected Overrides Sub Finalize()
        Mem.Clear()
        Mem = Nothing
    End Sub

    Private Sub SendClass()
        Me.Capacity = Mem(0).Capacity
        Me.Caption = Mem(0).Caption
        Me.CreationClassName = Mem(0).CreationClassName
        Me.DataWidth = Mem(0).DataWidth
        Me.Description = Mem(0).Description
        Me.DeviceLocator = Mem(0).DeviceLocator
        Me.FormFactor = Mem(0).FormFactor
        Me.InterleaveDataDepth = Mem(0).InterleaveDataDepth
        Me.InterleavePosition = Mem(0).InterleavePosition
        Me.Manufacturer = Mem(0).Manufacturer
        Me.Name = Mem(0).Name
        Me.PartNumber = Mem(0).PartNumber
        Me.PositionInRow = Mem(0).PositionInRow
        Me.SerialNumber = Mem(0).SerialNumber
        Me.Speed = Mem(0).Speed
        Me.Tag = Mem(0).Tag
        Me.TotalWidth = Mem(0).TotalWidth
        Me.TypeDetail = Mem(0).TypeDetail
    End Sub

    Private Sub SendClass(ByVal vIndex As Integer)
        If vIndex > (Mem.Count - 1) Or vIndex < 0 Then
            vIndex = 0
            Exit Sub
        End If
        Me.Capacity = Mem(vIndex).Capacity
        Me.Caption = Mem(vIndex).Caption
        Me.CreationClassName = Mem(vIndex).CreationClassName
        Me.DataWidth = Mem(vIndex).DataWidth
        Me.Description = Mem(vIndex).Description
        Me.DeviceLocator = Mem(vIndex).DeviceLocator
        Me.FormFactor = Mem(vIndex).FormFactor
        Me.InterleaveDataDepth = Mem(vIndex).InterleaveDataDepth
        Me.InterleavePosition = Mem(vIndex).InterleavePosition
        Me.Manufacturer = Mem(vIndex).Manufacturer
        Me.Name = Mem(vIndex).Name
        Me.PartNumber = Mem(vIndex).PartNumber
        Me.PositionInRow = Mem(vIndex).PositionInRow
        Me.SerialNumber = Mem(vIndex).SerialNumber
        Me.Speed = Mem(vIndex).Speed
        Me.Tag = Mem(vIndex).Tag
        Me.TotalWidth = Mem(vIndex).TotalWidth
        Me.TypeDetail = Mem(vIndex).TypeDetail
    End Sub
End Class
