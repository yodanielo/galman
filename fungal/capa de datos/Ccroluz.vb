Imports System.ComponentModel
'ésta clase no coincide con el procedimiento almacenado
Public Class Ccroluz
    Inherits BaseDato
    Private dr1 As DataRow
    Private x(6) As Object
    Private dt As DataTable
    Public Sub New()
        MyBase.New(general.server, general.usuario, general.password)
    End Sub
    Public Sub New(ByVal idcroluz As Integer)
        MyBase.New(general.server, general.usuario, general.password)
        dr1 = MyBase.procedimiento("get_luz", idcroluz).Select()(0)
        x(0) = dr1("idmesluz")
        x(1) = dr1("lecanterior")
        x(2) = dr1("lecactual")
        x(3) = dr1("tarifa")
        x(4) = dr1("fecvencimiento")
        x(5) = dr1("esincobrable")
    End Sub
    Public ReadOnly Property Codigo() As Integer
        Get
            Return x(0)
        End Get
    End Property
    Public Property Lectura_anterior() As String
        Get
            Return x(1)
        End Get
        Set(ByVal value As String)
            x(1) = value
        End Set
    End Property
    Public Property Lectura_Actual() As String
        Get
            Return x(2)
        End Get
        Set(ByVal value As String)
            x(2) = value
        End Set
    End Property
    Public Property Tarifa() As Decimal
        Get
            Return x(3)
        End Get
        Set(ByVal value As Decimal)
            x(3) = value
        End Set
    End Property
    Public ReadOnly Property Consumo() As Decimal
        Get
            Return (CDbl(Lectura_Actual) - CDbl(Lectura_anterior))
        End Get
    End Property
    Public ReadOnly Property Total() As Decimal
        Get
            Return (CDbl(Lectura_Actual) - CDbl(Lectura_anterior)) * Tarifa
        End Get
    End Property
    Public Property Fecha_de_vencimiento() As Date
        Get
            Return x(4)
        End Get
        Set(ByVal value As Date)
            x(4) = value
        End Set
    End Property
    Public Property Es_incobrable() As Edecision
        Get
            Return x(5)
        End Get
        Set(ByVal value As Edecision)
            x(5) = value
        End Set
    End Property
    Public Sub Guardar()
        MyBase.procedimiento("update_luz", x(0), x(1), x(2), x(3), x(4), x(5))
    End Sub
End Class
