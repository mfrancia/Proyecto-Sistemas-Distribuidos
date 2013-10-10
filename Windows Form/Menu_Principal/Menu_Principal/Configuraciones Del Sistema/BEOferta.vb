Public Class BEOferta
    Private _CoOferta As Integer
    Public Property CoOferta() As Integer
        Get
            Return _CoOferta
        End Get
        Set(ByVal value As Integer)
            _CoOferta = value
        End Set
    End Property

    Private _nombre As String
    Public Property Nombre() As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property
    Private _fechaInicio As DateTime
    Public Property FechaInicio() As DateTime
        Get
            Return _fechaInicio
        End Get
        Set(ByVal value As DateTime)
            _fechaInicio = value
        End Set
    End Property
    Private _fechaCaducidad As DateTime
    Public Property FechaCaducidad() As DateTime
        Get
            Return _fechaCaducidad
        End Get
        Set(ByVal value As DateTime)
            _fechaCaducidad = value
        End Set
    End Property

    Private _descripcion As String
    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

End Class
