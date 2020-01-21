''' <summary>
''' Device structure
''' </summary>
Public Structure StructDevice
    ' Name of the device
    Private name As String
    ' EUI of the device
    Private eui As String
    ' Application Key
    Private appKey As String
    ' Application EUI
    Private appEui As String

    Public Property GetName As String
        Get
            Return name
        End Get
        Set(value As String)
            name = value
        End Set
    End Property

    Public Property GetEui As String
        Get
            Return eui
        End Get
        Set(value As String)
            eui = value
        End Set
    End Property

    Public Property GetAppKey As String
        Get
            Return appKey
        End Get
        Set(value As String)
            appKey = value
        End Set
    End Property

    Public Property GetAppEui As String
        Get
            Return appEui
        End Get
        Set(value As String)
            appEui = value
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        If CType(obj, StructDevice) = Me Then
            Return True
        End If
        Return False
    End Function

    Public Overrides Function GetHashCode() As Integer

    End Function

    Public Shared Operator =(left As StructDevice, right As StructDevice) As Boolean
        Return left.Equals(right)
    End Operator

    Public Shared Operator <>(left As StructDevice, right As StructDevice) As Boolean
        Return Not left = right
    End Operator
End Structure
