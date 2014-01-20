
Public Class ArchiveFile

    Public Sub New(ByVal filePath As String)

        Dim fi As New IO.FileInfo(filePath)

        Me.Name = fi.Name
        Me.Type = GetFileType(filePath)
        Me.Modified = fi.LastWriteTime

    End Sub


#Region " Properties"

    Private mName As String = String.Empty
    Public Property Name() As String
        Get
            Return mName
        End Get
        Set(ByVal value As String)
            mName = value
        End Set
    End Property


    Private mType As String = String.Empty
    Public Property Type() As String
        Get
            Return mType
        End Get
        Set(ByVal value As String)
            mType = value
        End Set
    End Property


    Private mModified As DateTime
    Public Property Modified() As DateTime
        Get
            Return mModified
        End Get
        Set(ByVal value As DateTime)
            mModified = value
        End Set
    End Property


    Private mUri As String
    Public Property Uri() As String
        Get
            Return mUri
        End Get
        Set(ByVal value As String)
            mUri = value
        End Set
    End Property

#End Region    'Properties


#Region " Methods"

    Private Function GetFileType(ByVal path As String) As String

        'Get the file extension
        Dim ext As String = IO.Path.GetExtension(path)

        Dim registryType As String = String.Empty

        Try
            'Attempt to get the type from the registry
            registryType = _
                StrConv(My.Computer.Registry.ClassesRoot.OpenSubKey(ext, False).GetValue("").ToString(), VbStrConv.ProperCase)
        Catch ex As Exception
            'Create the type using the extension
            registryType = StrConv(System.IO.Path.GetExtension(path).Replace(".", ""), VbStrConv.ProperCase)
        End Try

        With registryType

            'If the last 4 is file, then replace it with " File"
            If Right(.ToLower(), 4) = "file" Then _
               registryType = .Substring(0, .Length - 4)

            'Add file to the end
            registryType &= " File"
        End With


        'Retrieve the application type from the registry
        Return registryType

    End Function

#End Region    'Methods


End Class
