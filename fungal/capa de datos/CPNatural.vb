Imports System.ComponentModel
Public Class CPNatural
    Inherits BaseDato
    Private x(10) As Object
    Private ltel As New List(Of Ctelefono)
    Private _edad
    Public Sub New(ByVal idpersona As Integer)
        MyBase.New(general.server, general.usuario, general.password)
        Dim dr1, dr2(), drt As DataRow
        dr1 = MyBase.procedimiento("get_pernatural", idpersona).Select()(0)
        dr2 = MyBase.procedimiento("get_telnatural", idpersona).Select()
        x(0) = dr1("idpersona")
        x(1) = dr1("nombres")
        x(2) = dr1("apellidos")
        x(3) = dr1("tipdocumento")
        x(4) = dr1("numdocumento")
        x(5) = dr1("pasaporte")
        x(6) = dr1("fecnacimiento")
        x(7) = dr1("ruc")
        x(8) = dr1("sexo")
        For Each drt In dr2
            ltel.Add(New Ctelefono(drt("tipo"), drt("numero")))
        Next
    End Sub
    Public Sub New()
        MyBase.new(general.server, general.usuario, general.password)
        x(0) = -1
        Me.fecha_de_nacimiento = Today
        x(3) = 1
        x(4) = "00000000"
        x(8) = 0
    End Sub
#Region "propiedades"
    <Category("Identificación"), Description("El dódigo que identifica a la persona natural")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return x(0)
        End Get
    End Property
    <Category("Datos personales"), Description("Sexo de la persona, si es masculino o femenino")> _
    Public Property sexo() As Esexo
        Get
            Return x(8)
        End Get
        Set(ByVal value As Esexo)
            x(8) = value
        End Set
    End Property
    <Category("Datos personales"), Description("El primer y segundo nombre de la persona natural")> _
    Public Property nombres() As String
        Get
            Return x(1)
        End Get
        Set(ByVal value As String)
            If (Trim(value) = "") Then
                MsgBox("el nombre no es válido")
            Else
                x(1) = value
            End If
        End Set
    End Property
    <Category("Datos personales"), Description("El primer y segundo apellido de la persona natural")> _
    Public Property apellidos() As String
        Get
            Return x(2)
        End Get
        Set(ByVal value As String)
            If (Trim(value) = "") Then
                MsgBox("los apellidos no es válido")
            Else
                x(2) = value
            End If
        End Set
    End Property
    <Category("Identificación"), Description("El tipo de documento que usa la persona natural")> _
    Public Property tipo_de_documento() As ETipoDoc
        Get
            Return x(3)
        End Get
        Set(ByVal value As ETipoDoc)
            x(3) = value
        End Set
    End Property
    <Category("Identificación"), Description("El número del tipo de documento que usa la persona natural")> _
    Public Property Numero_de_documento() As String
        Get
            Return x(4)
        End Get
        Set(ByVal value As String)
            If (value.Length = 0) Then
                MsgBox("Este campo no puede quedar en blanco", MsgBoxStyle.Exclamation)
            ElseIf (IsNumeric(value) = False) Then
                MsgBox("Número de documento no válido", MsgBoxStyle.Exclamation)
            ElseIf (value.Length <> 8) Then
                MsgBox("Número de documento debe tener 8 digitos", MsgBoxStyle.Exclamation)
            Else
                x(4) = value
            End If
        End Set
    End Property
    <Category("Identificación"), Description("El número de pasaporte que usa la persona natural cuando es extranjera")> _
    Public Property pasaporte() As String
        Get
            Try
                Return x(5)
            Catch
                x(5) = ""
                Return x(5)
            End Try
        End Get
        Set(ByVal value As String)
            Try
                x(5) = value
            Catch
                x(5) = ""
            End Try
        End Set
    End Property
    <Category("Datos personales"), Description("Fecha en que nace la persona natural")> _
    Public Property fecha_de_nacimiento() As Date
        Get
            Return x(6)
        End Get
        Set(ByVal value As Date)
            Try
                x(6) = value
            Catch ex As Exception
                x(6) = Date.Today
            End Try
            Me.edad = DateDiff(DateInterval.Year, CDate(x(6)), Date.Today)
        End Set
    End Property
    <Category("Datos personales"), Description("Edad actual de la persona, este campo se autogenera")> _
    Public Property edad() As Integer
        Get
            _edad = DateDiff(DateInterval.Year, CDate(x(6)), Date.Today)
            Return _edad
        End Get
        Private Set(ByVal value As Integer)
            If (value < 0) Then
                MsgBox("La fecha de nacimiento no es válida", MsgBoxStyle.Exclamation)
                Me.fecha_de_nacimiento = Date.Today
            Else
                _edad = value
            End If
        End Set
    End Property
    <Category("Identificación"), Description("numero de identificacion ante la SUNAT")> _
    Public Property ruc() As String
        Get
            Try
                Return x(7)
            Catch
                x(7) = ""
                Return x(7)
            End Try
        End Get
        Set(ByVal value As String)
            Try
                x(7) = value
            Catch
                x(7) = ""
            End Try
        End Set
    End Property
    <Category("Ubigeo"), Description("Telefono de la persona juridica")> _
    Public Property Telefono() As List(Of Ctelefono)
        Get
            Return ltel
        End Get
        Set(ByVal value As List(Of Ctelefono))
            ltel = value
        End Set
    End Property
#End Region
    Public Sub guardar()
        If (validar() = True) Then
            'On Error Resume Next
            Dim esnuevo As Integer = x(0)

            'x(0) = MyBase.procedimiento("update_pernatural", x(0), x(1), x(2), x(3), x(4), x(5), x(6), x(7)).Rows(0)(0)
            x(0) = MyBase.procedimiento("update_pernatural", Me.Codigo, Me.nombres, Me.apellidos, Me.tipo_de_documento, Me.Numero_de_documento, Me.pasaporte, Me.fecha_de_nacimiento, Me.ruc, Me.sexo).Rows(0)(0)
            MyBase.procedimiento("delete_telnatural", x(0))
            If (esnuevo = -1) Then
                'si es nuevo
                MyBase.procedimiento("update_tippersona", -1, x(0), 0, 0, 0, 0)
            End If
            Dim a As Ctelefono
            For Each a In ltel
                MyBase.procedimiento("update_telnatural", -1, x(0), a.Tipo, a.Numero)
            Next
            'MsgBox("Listo", MsgBoxStyle.Information)
        End If
    End Sub
    Private Function validar() As Boolean
        Dim valido As Boolean = True
        If (Trim(nombres) = "" Or Trim(apellidos) = "") Then
            MsgBox("Los nombres y apellidos no pueden quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Trim(Me.Numero_de_documento) = "") Then
            MsgBox("El numero de documento no puede quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        Else
        End If
        Return valido
    End Function
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
End Class
