
Public Class Ccompra
    Inherits BaseDato
    Private r(8) As Object
    Public Sub New(ByVal idcompra As Integer)
        MyBase.New(general.server, general.usuario, general.password)
        Dim x As DataRow
        x = procedimiento("get_compra", idcompra).Rows(0)
        Dim i As Integer
        For i = 0 To 7
            r(i) = x(i)
        Next
    End Sub
    Public Sub New()
        MyBase.New(general.server, general.usuario, general.password)
        Codigo = -1
        Me.Tipo_de_comprobante = Etipo_comprobante.Factura
        Fecha = Today
    End Sub
    Public Property Codigo() As Integer
        Get
            Return r(0)
        End Get
        Private Set(ByVal value As Integer)
            r(0) = value
        End Set
    End Property
    Public Property RUC() As String
        Get
            Return r(1)
        End Get
        Set(ByVal value As String)
            r(1) = value
        End Set
    End Property
    Public Property Tipo_de_comprobante() As Etipo_comprobante
        Get
            Return r(2)
        End Get
        Set(ByVal value As Etipo_comprobante)
            r(2) = value
        End Set
    End Property
    Public Property Serie() As String
        Get
            Return r(3)
        End Get
        Set(ByVal value As String)
            r(3) = value
        End Set
    End Property
    Public Property Numero() As Integer
        Get
            Return r(4)
        End Get
        Set(ByVal value As Integer)
            r(4) = value
        End Set
    End Property
    Public Property Razon_Social() As String
        Get
            Return r(5)
        End Get
        Set(ByVal value As String)
            r(5) = value
        End Set
    End Property
    Public Property Fecha() As DateTime
        Get
            Return r(6)
        End Get
        Set(ByVal value As DateTime)
            r(6) = value
        End Set
    End Property
    Public Property Monto() As Double
        Get
            Return r(7)
        End Get
        Set(ByVal value As Double)
            r(7) = value
        End Set
    End Property
    Public Sub guardar()
        Dim f As Integer
        If (validar() = True) Then
            f = Codigo
            Codigo = procedimiento("update_pagcompra", Codigo, RUC, Me.Tipo_de_comprobante, Serie, Numero, Me.Razon_Social, Fecha, Monto).Rows(0)(0)
            If (f = -1) Then
                If (MsgBox("¿Desea imprimir un report ahora?", MsgBoxStyle.Question) = MsgBoxResult.Yes) Then
                    imprimir()
                End If
            Else
                imprimir()
            End If
        End If
    End Sub
    Public Function validar() As Boolean
        Dim valido As Boolean = True
        If (RUC = "") Then
            MsgBox("El campo RUC no puede quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Serie = "" Or IsNumeric(Serie) = False) Then
            MsgBox("La serie no es válida o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Numero = "" Or Not IsNumeric(Numero)) Then
            MsgBox("El numero de comprobante no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Numero < 0) Then
            MsgBox("El numero de coprobante no puede ser negativo", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Razon_Social = "") Then
            MsgBox("La razon social del proveedor no puede quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Monto = "" Or Not IsNumeric(Monto)) Then
            MsgBox("El monto no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Monto <= 0) Then
            MsgBox("El monto no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
    Public Sub imprimir()

    End Sub
End Class
