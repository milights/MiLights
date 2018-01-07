Public Class MiLight

    Private _Zone As Integer
    Public Property Zone() As Integer
        Get
            Return _Zone
        End Get
        Set(ByVal value As Integer)
            _Zone = value
        End Set
    End Property

    Private _Color As Integer
    Public Property Color() As Integer
        Get
            Return _Color
        End Get
        Set(ByVal value As Integer)
            _Color = value
        End Set
    End Property

    Private _Brightness As Integer
    Public Property Brightness() As Integer
        Get
            Return _Brightness
        End Get
        Set(ByVal value As Integer)
            _Brightness = value
        End Set
    End Property

    Private _Saturation As Integer
    Public Property Saturation() As Integer
        Get
            Return _Saturation
        End Get
        Set(ByVal value As Integer)
            _Saturation = value
        End Set
    End Property

    Public Event ColorChanged()


    Public Sub New(Zone As Integer, Color As Integer, Brightness As Integer, Saturation As Integer)
        _Zone = Zone
        _Color = Color
        _Brightness = Brightness
        _Saturation = Saturation

    End Sub

    Public Sub New()
        'new without properties test 123

    End Sub

    Public Sub change()

        RaiseEvent ColorChanged()

    End Sub

End Class
