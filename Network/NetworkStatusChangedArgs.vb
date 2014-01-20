'************************************************************************************************
' Copyright © 2010 Steven M. Cohn. All Rights Reserved.
' Copyright & Modified © 2013 Amr Zakaria. All Rights Reserved.
'************************************************************************************************

Namespace CheckNetwork
    '********************************************************************************************
    ' class NetworkStatusChangedArgs
    '********************************************************************************************

    ''' <summary>
    ''' Describes the overall network connectivity of the machine.
    ''' </summary>

    Public Class NetworkStatusChangedArgs
        Inherits EventArgs
        'INSTANT VB NOTE: The variable isAvailable was renamed since Visual Basic does not allow class members with the same name:
        Private isAvailable_Renamed As Boolean


        ''' <summary>
        ''' Instantiate a new instance with the given availability.
        ''' </summary>
        ''' <param name="isAvailable"></param>

        Public Sub New(ByVal isAvailable As Boolean)
            Me.isAvailable_Renamed = isAvailable
        End Sub


        ''' <summary>
        ''' Gets a Boolean value indicating the current state of Internet connectivity.
        ''' </summary>

        Public ReadOnly Property IsAvailable() As Boolean
            Get
                Return isAvailable_Renamed
            End Get
        End Property
    End Class


    '********************************************************************************************
    ' delegate NetworkStatusChangedHandler
    '********************************************************************************************

    ''' <summary>
    ''' Define the method signature for network status changes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Public Delegate Sub NetworkStatusChangedHandler(ByVal sender As Object, ByVal e As NetworkStatusChangedArgs)
End Namespace
