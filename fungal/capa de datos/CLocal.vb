Imports System.ComponentModel
Public Class CLocal
    Inherits BaseDato
    Private x(16) As Object
    Private ltel As New List(Of Ctelefono)
    Sub New(ByVal idlocal As Integer)
        MyBase.New(general.server, general.usuario, general.password)
        Dim dr1 As DataRow
        dr1 = MyBase.procedimiento("get_local", idlocal).Select()(0)
        x(0) = dr1("idlocal")
        x(1) = dr1("nombre").ToString
        x(2) = dr1("estado")
        x(3) = dr1("area")
        x(4) = dr1("piso")
        x(5) = dr1("descripcion").ToString
        x(6) = dr1("medidor").ToString
        x(7) = dr1("telinterno").ToString
        x(8) = dr1("merconductiva")
        x(9) = dr1("mantenimiento")
        x(10) = dr1("arbitrio")
        x(11) = dr1("tipo")
        x(12) = dr1("imagen")
        x(13) = dr1("mormerconductiva")
        x(14) = dr1("mormantenimiento")
        x(15) = dr1("morarbitrio")
    End Sub
    Sub New()
        MyBase.New(general.server, general.usuario, general.password)
        x(0) = -1
        Me.Piso = 1
        Me.Area = 1
    End Sub
    <Category("Identificación"), Description("Código que idewntifica a un local como único")> _
    Public Property Codigo() As Integer
        Get
            Return x(0)
        End Get
        Private Set(ByVal value As Integer)
            x(0) = value
        End Set
    End Property
    <Category("Descripción"), Description("Nombre asignado al local")> _
    Public Property Nombre() As String
        Get
            Return x(1)
        End Get
        Set(ByVal value As String)
            If (value Is DBNull.Value) Then
                value = ""
            End If
            If (Trim(value.ToString) = "") Then
                MsgBox("Este campo no puede quedar en blanco", MsgBoxStyle.Exclamation)
            Else
                x(1) = value
            End If
        End Set
    End Property
    <Category("Descripción"), Description("Especifica si el local se puede arrendar o nó")> _
    Public Property Estado() As Eestadolocal
        Get
            Return x(2)
        End Get
        Private Set(ByVal value As Eestadolocal)
            x(2) = value
        End Set
    End Property
    <Category("Descripción"), Description("Especifica el area del local en metros cuadrados")> _
    Public Property Area() As Double
        Get
            Return x(3)
        End Get
        Set(ByVal value As Double)
            If (Val(value) <= 0) Then
                MsgBox("El área no es válida", MsgBoxStyle.Exclamation)
            Else
                x(3) = value
            End If
        End Set
    End Property
    <Category("Descripción"), Description("Piso en el que se hubica el local dentro de la galería")> _
    Public Property Piso() As Integer
        Get
            Return x(4)
        End Get
        Set(ByVal value As Integer)
            If (value <= 0) Then
                MsgBox("El piso no es válido", MsgBoxStyle.Exclamation)
            Else
                x(4) = value
            End If
        End Set
    End Property
    <Category("Descripción"), Description("Observaciones y caracteristicas adicionales atribuidas al local")> _
    Public Property Descripcion() As String
        Get
            Return x(5)
        End Get
        Set(ByVal value As String)
            If (value Is DBNull.Value) Then
                value = ""
            End If
            x(5) = value
        End Set
    End Property
    <Category("Descripción"), Description("Numero del medidor de energia electrica del local")> _
    Public Property Medidor() As String
        Get
            Return x(6)
        End Get
        Set(ByVal value As String)
            If (value Is DBNull.Value) Then
                value = ""
            End If
            x(6) = value
        End Set
    End Property
    <Category("Descripción"), Description("Número del telefono interno del local")> _
    Public Property Telefono_Interno() As String
        Get
            Return x(7)
        End Get
        Set(ByVal value As String)
            If (value Is DBNull.Value) Then
                value = ""
            End If
            x(7) = value
        End Set
    End Property
    <Category("Cobros"), Description("Monto de merced conductiva sugerida para el local")> _
    Public Property Merced_Conductiva() As Double
        Get
            Return x(8)
        End Get
        Set(ByVal value As Double)
            If (value <= 0) Then
                MsgBox("La merced conductiva no es válida", MsgBoxStyle.Exclamation)
            Else
                x(8) = value
            End If
        End Set
    End Property
    <Category("Cobros"), Description("Monto de mantenimiento sugerido para el local")> _
    Public Property Mantenimiento() As Double
        Get
            Return x(9)
        End Get
        Set(ByVal value As Double)
            If (value <= 0) Then
                MsgBox("El mantenimiento no es válido", MsgBoxStyle.Exclamation)
            Else
                x(9) = value
            End If
        End Set
    End Property
    <Category("Cobros"), Description("Monto de arbitrio sugerido para el local")> _
    Public Property Arbitrio() As Double
        Get
            Return x(10)
        End Get
        Set(ByVal value As Double)
            If (value <= 0) Then
                MsgBox("El arbitrio no es válido", MsgBoxStyle.Exclamation)
            Else
                x(10) = value
            End If
        End Set
    End Property
    <Category("Descripción"), Description("especifica la clasificacion del local")> _
    Public Property Tipo_de_local() As Etipo_local
        Get
            Return x(11)
        End Get
        Set(ByVal value As Etipo_local)
            x(11) = value
        End Set
    End Property
    <Category("Descripción"), Description("Vista previa del local")> _
    Private Property Imagen() As Bitmap
        Get
            If (x(12) Is DBNull.Value) Then
                x(12) = CType(My.Resources.casa, Bitmap)
            End If
            Return x(12)
        End Get
        Set(ByVal value As Bitmap)
            x(12) = CType(value, Bitmap)
        End Set
    End Property
    Public Property Mora_de_Merced_Conductiva() As Double
        Get
            Return x(13)
        End Get
        Set(ByVal value As Double)
            If (value < 0) Then
                MsgBox("La mora de merced conductiva no es válida")
            Else
                x(13) = value
            End If
        End Set
    End Property
    Public Property Mora_de_Mantenimiento() As Double
        Get
            Return x(14)
        End Get
        Set(ByVal value As Double)
            If (value < 0) Then
                MsgBox("La mora de mantenimiento no es válida")
            Else
                x(14) = value
            End If
        End Set
    End Property
    Public Property Mora_de_Arbitrio() As Double
        Get
            Return x(15)
        End Get
        Set(ByVal value As Double)
            If (value < 0) Then
                MsgBox("La mora de arbitrio no es válida")
            Else
                x(15) = value
            End If
        End Set
    End Property
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Sub guardar(Optional ByVal el As Eestadolocal = Eestadolocal.Disponible)
        'On Error Resume Next
        If (validar() = True) Then
            If (Me.Codigo = -1) Then
                x(2) = el
            End If
            'MyBase.procedimiento("update_local", x(0), x(1), x(2), x(3), x(4), x(5), x(6), x(7), x(8), x(13), x(9), x(14), x(10)) ', x(15), x(11))
            MyBase.procedimiento("update_local", Me.Codigo, Me.Nombre, Me.Estado, Me.Area, Me.Piso, Me.Descripcion, Me.Medidor, Me.Telefono_Interno, Me.Merced_Conductiva, Me.Mora_de_Merced_Conductiva, Me.Mantenimiento, Me.Mora_de_Mantenimiento, Me.Arbitrio, Me.Mora_de_Arbitrio, Me.Tipo_de_local)
            'MsgBox("listo", MsgBoxStyle.Information)
        End If
    End Sub
    Private Function validar() As Boolean
        Dim valido As Boolean = True
        If (Trim(Nombre) = "") Then
            MsgBox("El nombre del local no puede quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Area <= 0) Then
            MsgBox("El area del local no es válida")
            valido = False
        ElseIf (Piso <= 0) Then
            MsgBox("El piso de ubicacion del local no debe ser menor de 1", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Me.Merced_Conductiva <= 0) Then
            MsgBox("La merced conductiva no es válida", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Arbitrio <= 0) Then
            MsgBox("el arbitrio no es válida", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
    Public Sub guardar_loccontrato(ByVal idlc As Integer)
        MyBase.procedimiento("update_loccontrato", -1, idlc, x(0), x(1), x(2), x(3), x(4), x(5), x(6), x(7), x(8), x(13), x(9), x(14), x(10), x(15), x(11), "")
    End Sub
End Class