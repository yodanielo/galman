Imports System.ComponentModel
Public Class Ctelefono
    Private mtipo As ETelefono
    Private mnumero As Integer
    Sub New(ByVal _Tipo As ETelefono, ByVal _Numero As String)
        Me.Tipo = _Tipo
        Me.Numero = _numero
    End Sub
    Sub New()
    End Sub
    <Category("Telefono"), Description("el tipo de telefono")> _
    Public Property Tipo() As ETelefono
        Get
            Return mtipo
        End Get
        Set(ByVal value As ETelefono)
            mtipo = value
        End Set
    End Property
    <Category("Telefono"), Description("Numero de telefono")> _
    Public Property Numero() As String
        Get
            Return mnumero
        End Get
        Set(ByVal value As String)
            mnumero = value
        End Set
    End Property
End Class
