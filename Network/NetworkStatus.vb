Imports System.Runtime.CompilerServices
Imports System.Net.NetworkInformation

'************************************************************************************************
' Copyright © 2010 Steven M. Cohn. All Rights Reserved.
' Copyright & Modified © 2013 Amr Zakaria. All Rights Reserved.
'************************************************************************************************

Namespace CheckNetwork


    ''' <summary>
    ''' Provides notification of status changes related to Internet-specific network
    ''' adapters on this machine.  All other adpaters such as tunneling and loopbacks
    ''' are ignored.  Only connected IP adapters are considered.
    ''' </summary>
    ''' <remarks>
    ''' <i>Implementation Note:</i>
    ''' <para>
    ''' Since we'll likely invoke the IsAvailable property very frequently, that should
    ''' be very efficient.  So we wire up handlers for both NetworkAvailabilityChanged
    ''' and NetworkAddressChanged and capture the state in the local isAvailable variable. 
    ''' </para>
    ''' </remarks>

    Public NotInheritable Class NetworkStatus

        Private Sub New()
        End Sub

        'INSTANT VB NOTE: The variable isAvailable was renamed since Visual Basic does not allow class members with the same name:
        Private Shared isAvailable_Renamed As Boolean
        Private Shared handler As NetworkStatusChangedHandler


        '========================================================================================
        ' Constructor
        '========================================================================================

        ''' <summary>
        ''' Initialize the class by detecting the start condition.
        ''' </summary>

        Shared Sub New()
            isAvailable_Renamed = IsNetworkAvailable()
        End Sub

        '========================================================================================
        ' Properties
        '========================================================================================

        ''' <summary>
        ''' This event is fired when the overall Internet connectivity changes.  All
        ''' non-Internet adpaters are ignored.  If at least one valid Internet connection
        ''' is "up" then we consider the Internet "available".
        ''' </summary>

        Public Shared Custom Event AvailabilityChanged As NetworkStatusChangedHandler
            <MethodImpl(MethodImplOptions.Synchronized)> _
            AddHandler(ByVal value As NetworkStatusChangedHandler)
                If handler Is Nothing Then
                    AddHandler NetworkChange.NetworkAvailabilityChanged, AddressOf DoNetworkAvailabilityChanged

                    AddHandler NetworkChange.NetworkAddressChanged, AddressOf DoNetworkAddressChanged
                End If

                handler = CType(System.Delegate.Combine(handler, value), NetworkStatusChangedHandler)
            End AddHandler

            <MethodImpl(MethodImplOptions.Synchronized)> _
            RemoveHandler(ByVal value As NetworkStatusChangedHandler)
                handler = CType(System.Delegate.Remove(handler, value), NetworkStatusChangedHandler)

                If handler Is Nothing Then
                    RemoveHandler NetworkChange.NetworkAvailabilityChanged, AddressOf DoNetworkAvailabilityChanged

                    RemoveHandler NetworkChange.NetworkAddressChanged, AddressOf DoNetworkAddressChanged
                End If
            End RemoveHandler
            RaiseEvent(ByVal sender As Object, ByVal e As NetworkStatusChangedArgs)
            End RaiseEvent
        End Event

        ''' <summary>
        ''' Gets a Boolean value indicating the current state of Internet connectivity.
        ''' </summary>

        Public Shared ReadOnly Property IsAvailable() As Boolean
            Get
                Return isAvailable_Renamed
            End Get
        End Property

        '========================================================================================
        ' Methods
        '========================================================================================

        ''' <summary>
        ''' Evaluate the online network adapters to determine if at least one of them
        ''' is capable of connecting to the Internet.
        ''' </summary>
        ''' <returns></returns>

        Private Shared Function IsNetworkAvailable() As Boolean
            ' only recognizes changes related to Internet adapters
            If NetworkInterface.GetIsNetworkAvailable() Then
                ' however, this will include all adapters
                Dim interfaces() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces()
                For Each face As NetworkInterface In interfaces
                    ' filter so we see only Internet adapters
                    If face.OperationalStatus = OperationalStatus.Up Then
                        If (face.NetworkInterfaceType <> NetworkInterfaceType.Tunnel) AndAlso (face.NetworkInterfaceType <> NetworkInterfaceType.Loopback) Then
                            Dim statistics As IPv4InterfaceStatistics = face.GetIPv4Statistics()

                            ' all testing seems to prove that once an interface comes online
                            ' it has already accrued statistics for both received and sent...

                            If (statistics.BytesReceived > 0) AndAlso (statistics.BytesSent > 0) Then
                                Return True
                            End If
                        End If
                    End If
                Next face
            End If

            Return False
        End Function

        Private Shared Sub DoNetworkAddressChanged(ByVal sender As Object, ByVal e As EventArgs)
            SignalAvailabilityChange(sender)
        End Sub

        Private Shared Sub DoNetworkAvailabilityChanged(ByVal sender As Object, ByVal e As NetworkAvailabilityEventArgs)
            SignalAvailabilityChange(sender)
        End Sub

        Private Shared Sub SignalAvailabilityChange(ByVal sender As Object)
            Dim change As Boolean = IsNetworkAvailable()

            If change <> isAvailable_Renamed Then
                isAvailable_Renamed = change

                If handler IsNot Nothing Then
                    handler(sender, New NetworkStatusChangedArgs(isAvailable_Renamed))
                End If
            End If
        End Sub
    End Class
End Namespace