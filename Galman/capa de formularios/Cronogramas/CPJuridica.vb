Imports System.Drawing.Design
Imports System.ComponentModel
Public Class CPJuridica
    Inherits BaseDato
    private x(6) as object
    Private ltel As New List(Of Ctelefono)
    Private lsocios As New List(Of CPNatural)
    Public Sub New(ByVal idjuridica As Integer)
        MyBase.New(general.server,general.usuario,general.password)
        Dim i As Integer
        Dim dr1, dr2() As DataRow
        dr1 = MyBase.procedimiento("get_perjuridica", idjuridica).Select()(0)
        dr2 = MyBase.procedimiento("get_teljuridico", idjuridica).Select()
        x(0) = dr1("idperjuridica")
        x(1) = dr1("razsocial")
        x(2) = dr1("ruc")
        x(3) = dr1("giro")
        x(4) = dr1("direccion")
        For i = 0 To dr2.Length - 1
            ltel.Add(New Ctelefono(dr2(i)(0), dr2(i)(3)))
        Next
        dr2 = MyBase.procedimiento("get_pernatjuridica", idjuridica).Select()
        For i = 0 To dr2.Length - 1
            lsocios.Add(New CPNatural(dr2(i)("idpernatural")))
        Next
    End Sub
    Public Sub New()
        MyBase.New(general.server,general.usuario,general.password)
        x(0) = -1
        RUC = "100000001"
    End Sub
#Region "propiedades"
    <Category("Identificación"), Description("Número que identifica a la persona jurídica")> _
    Public ReadOnly Property Codigo() As Integer
        Get
            Return x(0)
        End Get
    End Property
    <Category("Datos"), Description("Nombre de la empresa")> _
    Public Property Razon_Social() As String
        Get
            Return x(1)
        End Get
        Set(ByVal value As String)
            If (String.IsNullOrEmpty(value.ToString)) Then
                MsgBox("Este campo no puede quedar en blanco", MsgBoxStyle.Exclamation)
                If (String.IsNullOrEmpty(x(1).ToString)) Then
                    value = "no definido"
                End If
            End If
            x(1) = value
        End Set
    End Property
    <Category("Identificación"), Description("numero de identificacion ante la SUNAT")> _
    Public Property RUC() As String
        Get
            Try
                Return x(2)
            Catch
                x(2) = "00000000000"
                Return x(2)
            End Try
        End Get
        Set(ByVal value As String)
            If (value = "") Then
                value = "100000001"
            ElseIf (value.Length <> 11) Then
                MsgBox("El RUC no es válido", MsgBoxStyle.Exclamation)
            Else
                x(2) = value
            End If
        End Set
    End Property
    <Category("Datos"), Description("a que se dedica la empresa")> _
    Public Property Giro() As String
        Get
            Return x(3)
        End Get
        Set(ByVal value As String)
            x(3) = value
        End Set
    End Property
    <Category("Ubigeo"), Description("Dirección de la persona jurídica que se establecerá en el contrato")> _
    Public Property Direccion() As String
        Get
            Return x(4)
        End Get
        Set(ByVal value As String)
            x(4) = value
        End Set
    End Property
    <Category("Ubigeo"), Description("Números telefónicos de la persona jurídica")> _
    Public Property Telefono() As List(Of Ctelefono)
        Get
            Return ltel
        End Get
        Set(ByVal value As List(Of Ctelefono))
            ltel = value
        End Set
    End Property
    <Category("Otros"), Description("Represetantes legales de la empresa"), Editor(GetType(editor_cpernatural), GetType(UITypeEditor))> _
    Public Property Representantes_legales() As List(Of CPNatural)
        Get
            Return lsocios
        End Get
        Set(ByVal value As List(Of CPNatural))
            lsocios = value
        End Set
    End Property
#End Region
    Public Sub guardar()
        If (validar() = True) Then
            Dim esnuevo As Integer = x(0)
            x(0) = MyBase.procedimiento("update_perjuridica", x(0), x(1), x(2), x(3), x(4)).Rows(0)(0)
            MyBase.procedimiento("delete_teljuridico", x(0))
            Dim a As Ctelefono
            For Each a In ltel
                MyBase.procedimiento("update_teljuridico", -1, x(0), a.Tipo, a.Numero)
            Next
            Dim b As CPNatural
            MyBase.procedimiento("delete_pernatjuridica", x(0))
            For Each b In lsocios
                MyBase.procedimiento("update_pernatjuridica", -1, b.Codigo, x(0))
            Next
            If (esnuevo = -1) Then
                MyBase.procedimiento("update_tippersona", -1, x(0), 1, 0, 0, 0)
            End If
        End If
    End Sub
    Private Function validar()
        Dim valido As Boolean = True
        If (Trim(Razon_Social) = "") Then
            MsgBox("La razon social no puede quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Trim(RUC) = "" Or Not IsNumeric(RUC)) Then
            MsgBox("El RUC no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Me.Representantes_legales.Count <= 0) Then
            MsgBox("Debe escojer por lo menos un representante legal", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
End Class
