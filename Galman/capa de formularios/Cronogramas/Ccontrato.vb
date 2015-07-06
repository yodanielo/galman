'falta probar con los contratos
Imports System.ComponentModel
Imports System.Drawing.Design
Public Class Ccontrato
    Inherits BaseDato
    Private R(15) As Object
    Private _Locales As New List(Of CLocal)
    Private _Personas_Juridicas As New List(Of CPJuridica)
    Private _Personas_Naturales As New List(Of CPNatural)
    Sub New(ByVal idcontrato As String)
        MyBase.New(general.server, general.usuario, general.password)
        Dim dr As DataRow
        Dim dr2_1, dr2_2, dr2_3 As DataRowCollection
        dr = MyBase.procedimiento("get_contrato", idcontrato).Rows(0)
        R(0) = dr(0)
        R(1) = dr(1)
        R(2) = dr(2)
        R(3) = dr(3)
        R(4) = dr(4)
        R(5) = dr(5)
        R(6) = dr(6)
        R(7) = dr(7)
        R(8) = dr(8)
        R(9) = dr(9)
        R(10) = dr(10)
        R(12) = dr(11)
        R(13) = dr(12)
        R(14) = dr(13)
        R(15) = dr(14)
        dr2_1 = MyBase.procedimiento("get_loccontrato", idcontrato).Rows
        For Each dr In dr2_1
            _Locales.Add(New CLocal(dr(0)))
        Next
        dr2_2 = MyBase.procedimiento("get_perjurcontrato", idcontrato).Rows
        For Each dr In dr2_2
            _Personas_Juridicas.Add(New CPJuridica(dr(0)))
        Next
        dr2_3 = MyBase.procedimiento("get_pernatcontrato", idcontrato).Rows
        For Each dr In dr2_3
            _Personas_Naturales.Add(New CPNatural(dr(0)))
        Next
    End Sub
    Sub New()
        MyBase.New(general.server, general.usuario, general.password)
        R(0) = -1
        Garantia = 20
        Me.Tipo_de_comprobante = Etipo_comprobante.Boleta_de_ventas
        R(6) = (New registro).leer("HKLM\software\galman\directorio_defecto_contrato")
        Me.Estado = Eestado_contrato.Activo
        Me.Fecha_de_registro = Date.Today
        Me.Fecha_de_inicio = Date.Today
        Me.meses = 12
        Me.dias = 0
    End Sub
#Region "Identificacion"
    <Category("Identificación"), Description("Número que identifica el Contrato de arrendamiento")> _
    Public Property Codigo() As Integer
        Get
            Return R(0)
        End Get
        Private Set(ByVal value As Integer)
            R(0) = value
        End Set
    End Property
#End Region
#Region "Datos de contrato"
    <Category("Datos de contrato"), Description("Monto dado por garantía")> _
    Public Property Garantia() As Double
        Get
            Return R(1)
        End Get
        Set(ByVal value As Double)
            If (value <= 0) Then
                MsgBox("La garantía no es válida", MsgBoxStyle.Exclamation)
            Else
                R(1) = value
            End If
        End Set
    End Property
    <Category("Datos de contrato"), Description("Fecha de registro del contrato")> _
    Public Property Fecha_de_registro() As Date
        Get
            Return R(2)
        End Get
        Private Set(ByVal value As Date)
            Try
                R(2) = value
            Catch
                R(2) = Date.Today
            End Try
        End Set
    End Property
    <Category("Datos de contrato"), Description("Lista de Arrendatarios Jurídicas"), DefaultValue(GetType(Integer), "0")> _
    Public Property Tipo_de_comprobante() As Etipo_comprobante
        Get
            Return R(5)
        End Get
        Set(ByVal value As Etipo_comprobante)
            R(5) = value
        End Set
    End Property
    <Category("Datos de contrato"), Description("La ruta donde el contrato se guardará"), Editor(GetType(editor_selcarpeta), GetType(UITypeEditor))> _
    Public Property Ruta_del_contrato() As String
        Get
            Return R(6)
        End Get
        Set(ByVal value As String)
            If (String.IsNullOrEmpty(value) = True) Then
                R(6) = (New registro).leer("HKLM\software\galman\directorio_defecto_contrato")
            Else
                R(6) = value
            End If
        End Set
    End Property
    <Category("Datos de contrato"), Description("especifica si un contrato está activo o no"), DefaultValue(GetType(Integer), "0")> _
    Public Property Estado() As Eestado_contrato
        Get
            Return R(7)
        End Get
        Private Set(ByVal value As Eestado_contrato)
            R(7) = value
        End Set
    End Property
#End Region
#Region "Duración"
    <Category("Duración"), Description("Número de meses completos del contrato")> _
    Public Property Fecha_de_inicio() As Date
        Get
            Return R(14)
        End Get
        Set(ByVal value As Date)
            Try
                R(14) = value
            Catch
                R(14) = Date.Today
            End Try
            'Fecha_de_fin = DateAdd(DateInterval.Day, Me.dias, DateAdd(DateInterval.Month, Me.meses, Fecha_de_inicio))
        End Set
    End Property
    <Category("Duración"), Description("Número de meses completos del contrato")> _
    Public ReadOnly Property Fecha_de_fin() As Date
        Get
            Dim d1 As Date
            d1 = DateAdd(DateInterval.Month, Me.meses, Me.Fecha_de_inicio)
            d1 = DateAdd(DateInterval.DayOfYear, Me.dias, d1)
            d1 = d1.AddDays(-1)
            Return d1
        End Get
    End Property
    <Category("Duración"), Description("Número de meses completos del contrato"), DefaultValue(GetType(Integer), "12")> _
    Public Property meses() As Integer
        Get
            Return R(3)
        End Get
        Set(ByVal value As Integer)
            R(3) = value
        End Set
    End Property
    <Category("Duración"), Description("Número de meses completos del contrato"), DefaultValue(GetType(Integer), "0")> _
    Public Property dias() As Integer
        Get
            Return R(4)
        End Get
        Set(ByVal value As Integer)
            R(4) = value
        End Set
    End Property
#End Region
#Region "Cobros"
    <Category("Cobros"), Description("Monto a cobrar por mantenimiento del local"), DefaultValue(GetType(Double), "0")> _
    Public Property Monto_de_mantenimiento() As Double
        Get
            Dim i As CLocal
            Dim suma As Double
            For Each i In _Locales
                suma += i.Mantenimiento
            Next
            R(8) = suma
            Return R(8)
        End Get
        Private Set(ByVal value As Double)
            If (value <= 0) Then
                MsgBox("El monto de mantenimiento no es válido", MsgBoxStyle.Exclamation)
            Else
                R(8) = value
            End If
        End Set
    End Property
    <Category("Cobros"), Description("Monto a cobrar por la mora de mantenimiento de local"), DefaultValue(GetType(Double), "0")> _
    Public Property Monto_de_mora_de_mantenimiento() As Double
        Get
            Dim i As CLocal
            Dim suma As Double
            For Each i In _Locales
                suma += i.Mora_de_Mantenimiento
            Next
            R(9) = suma
            Return R(9)
        End Get
        Private Set(ByVal value As Double)
            If (value <= 0) Then
                MsgBox("El monto de mora mantenimiento no es válido", MsgBoxStyle.Exclamation)
            Else
                R(9) = value
            End If
        End Set
    End Property
    <Category("Cobros"), Description("Monto a cobrar por la mora de la merced conductiva de los locales arredados"), DefaultValue(GetType(Double), "0")> _
    Public Property Monto_de_mora_de_merced_conductiva() As Double
        Get
            Dim i As CLocal
            Dim suma As Double
            For Each i In _Locales
                suma += i.Mora_de_Merced_Conductiva
            Next
            R(10) = suma
            Return R(10)
        End Get
        Private Set(ByVal value As Double)
            If (value <= 0) Then
                MsgBox("El monto de mora de merced conductiva no es válido", MsgBoxStyle.Exclamation)
            Else
                R(10) = value
            End If
        End Set
    End Property
    <Category("Cobros"), Description("Monto a cobrar por la merced conductiva de los locales alquilados"), DefaultValue(GetType(Double), "0")> _
    Public Property Monto_de_merced_conductiva() As Double
        Get
            Dim i As CLocal
            Dim suma As Double
            For Each i In _Locales
                suma += i.Merced_Conductiva
            Next
            R(11) = suma
            Return R(11)
        End Get
        Private Set(ByVal value As Double)
            If (value <= 0) Then
                MsgBox("El monto de mantenimiento no es válido", MsgBoxStyle.Exclamation)
            Else
                R(11) = value
            End If

        End Set
    End Property
#End Region
#Region "Rescincion"
    <[ReadOnly](True), Category("Rescincion"), Description("Indica si el contrato está actualmente rescindido o no")> _
    Public Property Es_rescindido() As Edecision
        Get
            Return (R(15))
        End Get
        Private Set(ByVal value As Edecision)
            R(15) = value
        End Set
    End Property
    <Category("Rescinción"), Description("Fecha en el que se rescindió el contrato")> _
    Public Property Fecha_de_rescincion() As Date
        Get
            Try
                Return R(12)
            Catch
                Return Today
            End Try
        End Get
        Private Set(ByVal value As Date)
            MsgBox("para rescindir el contrato debe llenar los compos de Fecha de Rescincion y Motivo, luego pulse en el boton rescindir contrato en la barra de herramientas de la ventana", MsgBoxStyle.Information)
            R(12) = value
        End Set
    End Property
    <Category("Rescinción"), Description("Motivo por el que se rescindió el contrato")> _
    Public Property Motivo_de_rescincion() As String
        Get
            Try
                If (String.IsNullOrEmpty(R(13).ToString) And Me.Es_rescindido = Edecision.Sí) Then
                    Dim resp As String = ""
                    While (resp = "")
                        resp = Trim(InputBox("Debe ingresar un motivo para rescindir el contrato", "GalMan", "Incumplimiento del contrato"))
                    End While
                    R(13) = resp
                End If
                Return R(13)
            Catch
                R(13) = ""
                Return R(13)
            End Try
        End Get
        Set(ByVal value As String)
            MsgBox("para rescindir el contrato debe llenar los compos de Fecha de Rescincion y Motivo, luego pulse en el boton rescindir contrato en la barra de herramientas de la ventana", MsgBoxStyle.Information)
            R(13) = value
        End Set
    End Property
#End Region
#Region "otros"
    <Category("Otros"), Description("Locales alquilados"), Editor(GetType(Editor_cloccontrato), GetType(UITypeEditor))> _
    Public Property Locales() As List(Of CLocal)
        Get
            Return _Locales
        End Get
        Set(ByVal value As List(Of CLocal))
            _Locales = value
        End Set
    End Property
    <Category("Otros"), Description("Personas juridicas que celebraron el contrato"), Editor(GetType(editor_cperjuridica), GetType(UITypeEditor))> _
    Public Property Personas_Juridicas() As List(Of CPJuridica)
        Get
            Return _Personas_Juridicas
        End Get
        Set(ByVal value As List(Of CPJuridica))
            _Personas_Juridicas = value
        End Set
    End Property
    <Category("Otros"), Description("Personas naturales que celebraron el contrato"), Editor(GetType(editor_cpernatural), GetType(UITypeEditor))> _
    Public Property Personas_Naturales() As List(Of CPNatural)
        Get
            Return _Personas_Naturales
        End Get
        Set(ByVal value As List(Of CPNatural))
            _Personas_Naturales = value
        End Set
    End Property
#End Region
    Public Sub Guardar()
        If (validar() = True) Then
            Dim esnuevo As Integer = R(0)
            Me.Codigo = MyBase.procedimiento("update_conarrendamiento", R(0), R(1), R(2), R(3), R(4), R(5), R(6), R(7), R(14)).Rows(0)(0)
            If (esnuevo = -1) Then
                llenar_merconductiva()
                llenar_mantenimiento()
                'sino esto no se toca, el compromiso de pagos no se modifica
            End If
            If (R(15) = 1) Then
                'el contrato está rescindido
                'está rescindido si existe un registro en la tabla conrescindido haciendo referencia al contrato
                'asi que en esta parte solo se tiene que actualizar los campos
                MyBase.procedimiento("update_conrescindido", R(0), R(12), R(13))
            Else
                'el contrato no está rescindido
            End If
            'guardo los locales
            procedimiento("delete_loccontrato", R(0))
            Dim x As CLocal
            For Each x In Me.Locales
                With x
                    x.guardar(Eestadolocal.Arrendado)
                    'procedimiento("update_locccontrato", -1, .Codigo, R(0), .Nombre, .Estado, .Area, .Piso, CObj(.Descripcion), CObj(.Medidor), CObj(.Telefono_Interno), .Merced_Conductiva, .Mora_de_Merced_Conductiva, .Mantenimiento, .Mora_de_Mantenimiento, .Arbitrio, .Mora_de_Arbitrio, "")
                    x.guardar_loccontrato(CInt(Me.Codigo))
                End With
            Next
            'guardo arrendatarios
            procedimiento("delete_conarrendatario", R(0))
            Dim y As CPJuridica, z As CPNatural
            For Each y In Me.Personas_Juridicas
                procedimiento("update_conarrendatario", -1, R(0), y.Codigo, 1)
            Next
            For Each z In Me.Personas_Naturales
                procedimiento("update_conarrendatario", -1, R(0), z.Codigo, 0)
            Next
            imprimir_contrato_nuevo(True)
        End If
    End Sub
    Private Function validar()
        Dim valido As Boolean = True
        If (Locales.Count <= 0) Then
            MsgBox("Debe seleccionar por lo menos un local", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Personas_Juridicas.Count <= 0 And Me.Personas_Naturales.Count <= 0) Then
            MsgBox("Debe seleccionar por lo menos una persona juridica o natural", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Me.dias < 0 Or Me.dias >= 30) Then
            Me.dias = 29
        ElseIf (meses = 0 And dias = 0) Then
            MsgBox("Un contrato no puede durar 0 dias y 0 meses", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
    Public Sub imprimir_contrato_nuevo(ByVal esvisible As Boolean)
        Dim a As New print_conarrendamiento_natural
        Dim nom_archivo As String
        If (Me.Personas_Juridicas.Count > 0) Then
            With Me.Personas_Juridicas(0).Representantes_legales(0)
                nom_archivo = Me.Personas_Juridicas(0).Razon_Social & " (" & Me.Locales(0).Nombre & ") " & Me.Fecha_de_registro.Day & "-" & Me.Fecha_de_registro.Month & "-" & Me.Fecha_de_registro.Year
                a.identificacion = Me.Personas_Juridicas(0).Razon_Social & _
                " debidamente representado por " & .nombres & " " & .apellidos & _
                " identificado con " & IIf(.tipo_de_documento = ETipoDoc.DNI, "DNI", "Carnet de extranjería") & " Nº " & .Numero_de_documento
                a.nombre = Me.Personas_Juridicas(0).Razon_Social & Chr(13) & _
                "Representante Legal: " & .nombres & " " & .apellidos & Chr(13) & _
                IIf(.tipo_de_documento = ETipoDoc.DNI, "DNI:", "Carnet de extranjería:") & .Numero_de_documento
            End With
        ElseIf (Me.Personas_Naturales.Count > 0) Then
            With Me.Personas_Naturales(0)
                nom_archivo = .nombres & " " & .apellidos & " ( " & Me.Locales(0).Nombre & ") " & Me.Fecha_de_registro.Day & "-" & Me.Fecha_de_registro.Month & "-" & Me.Fecha_de_registro.Year & ".doc"
                a.visible = esvisible
                a.identificacion = .nombres & " " & .apellidos & _
                " identificado con " & IIf(.tipo_de_documento = ETipoDoc.DNI, "DNI", "Carnet de extranjería") & " Nº " & .Numero_de_documento
                a.nombre = .nombres & " " & .apellidos & Chr(13) & _
                IIf(.tipo_de_documento = ETipoDoc.DNI, "DNI:", "Carnet de extranjería:") & " " & .Numero_de_documento
            End With
        Else
            MsgBox("Debe asociar por lo menos un arrendatario al contrato")
            Exit Sub
        End If
        a.numero = Me.Locales(0).Nombre
        a.arrendataria_o = "ARRENDATARIO"
        a.duracion = Me.meses & " Meses y " & Me.dias & " Días"
        a.fecha_fin = Me.Fecha_de_fin
        a.fecha_firma = Me.Fecha_de_registro
        a.fecha_inicio = Me.Fecha_de_inicio
        a.garantia = Me.Garantia
        a.merced_conductiva = general.aLetras(Me.Monto_de_merced_conductiva)
        If (Me.Ruta_del_contrato = "") Then
            MsgBox("Debe especificar una ruta válida para el contrato", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        a.guardar_como(Me.Ruta_del_contrato, nom_archivo)
    End Sub
    'Public Sub imprimir_contrato_viejo()
    '    Dim ruta As String = Me.Ruta_del_contrato
    '    Dim icv As Cword
    '    Dim s As String
    '    If (ruta = "") Then
    '        MsgBox("Debe especificar una ruta para el contrato", MsgBoxStyle.Exclamation)
    '        Exit Sub
    '    Else
    '        ruta = Trim(ruta)
    '        If (ruta = "") Then
    '            ruta = My.Application.Info.DirectoryPath
    '        End If
    '        s = IIf(Strings.Right(ruta, 1) <> "\", ruta & "\", ruta)
    '        If (Me.Personas_Juridicas.Count > 0) Then
    '            s = s & Me.Personas_Juridicas(0).Razon_Social & " (" & Me.Locales(0).Nombre & ") " & Me.Fecha_de_registro.Day & "-" & Me.Fecha_de_registro.Month & "-" & Me.Fecha_de_registro.Year
    '        ElseIf (Me.Personas_Naturales.Count > 0) Then
    '            s = s & Me.Personas_Naturales(0).nombres & Me.Personas_Naturales(0).apellidos & " (" & Me.Locales(0).Nombre & ") " & Me.Fecha_de_registro.Day & "-" & Me.Fecha_de_registro.Month & "-" & Me.Fecha_de_registro.Year
    '        Else
    '            MsgBox("Debe asociar por lo menos un arrendatario al contrato")
    '            Exit Sub
    '        End If
    '    End If
    '    Try
    '        icv = New Cword(s)
    '        icv.visible = False
    '    Catch
    '        imprimir_contrato_nuevo(True)
    '    End Try
    'End Sub
    Private Sub llenar_merconductiva()
        Dim i As Integer
        Dim d1 As Date = Me.Fecha_de_inicio
        For i = 1 To Me.meses
            procedimiento("update_merconductiva", -1, R(0), i, MonthName(Month(d1)), d1, Me.Monto_de_merced_conductiva, "", 0, 0)
            d1 = DateAdd(DateInterval.Month, 1, d1)
        Next
        If (Me.dias <> 0) Then
            d1 = DateAdd(DateInterval.DayOfYear, Me.dias, d1)
            Dim m As Double
            m = Me.Monto_de_merced_conductiva * (Me.dias / 30)
            procedimiento("update_merconductiva", -1, R(0), i + 1, MonthName(Month(d1)), d1, m, "")
        End If
    End Sub
    Private Sub llenar_mantenimiento()
        Dim d1 As DateTime = Me.Fecha_de_inicio
        Dim d2 As DateTime = Me.Fecha_de_fin
        Dim d1a As DateTime
        Dim dia As Integer
        Dim pago1 As Double
        Dim semanas As Integer
        Dim i As Integer
        dia = 7 - DateAndTime.Weekday(d1)
        pago1 = Me.Monto_de_mantenimiento * (dia + 1) / 7
        d1a = DateAdd(DateInterval.DayOfYear, dia, d1)
        procedimiento("update_mantenimiento", -1, R(0), pago1, 1, "de " & d1 & " a " & d1a, dia + 1, d1a, 0, 0)
        d1 = DateAdd(DateInterval.DayOfYear, dia + 1, d1)
        If (Weekday(Me.Fecha_de_inicio) = Weekday(Me.Fecha_de_fin.AddDays(-1))) Then
            semanas = DateDiff(DateInterval.WeekOfYear, d1, Me.Fecha_de_fin) + 1
        Else
            semanas = DateDiff(DateInterval.WeekOfYear, d1, Me.Fecha_de_fin)
        End If
        pago1 = Me.Monto_de_mantenimiento
        For i = 2 To semanas + 1
            d1a = DateAdd(DateInterval.DayOfYear, 6, d1)
            procedimiento("update_mantenimiento", -1, R(0), pago1, i, "de " & d1 & " a " & d1a, 7, d1a, 0, 0)
            d1 = DateAdd(DateInterval.DayOfYear, 7, d1)
        Next
        If (d1a <> Me.Fecha_de_fin) Then
            dia = DateDiff(DateInterval.DayOfYear, d1, Me.Fecha_de_fin) + 1
            pago1 = Me.Monto_de_mantenimiento * (dia) / 7
            procedimiento("update_mantenimiento", -1, R(0), pago1, i, "de " & d1 & " a " & Me.Fecha_de_fin, dia, Me.Fecha_de_fin, 0, 0)
        End If
    End Sub
End Class