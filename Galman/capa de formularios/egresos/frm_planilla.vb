Public Class frm_planilla
    Private db As New BaseDato(general.server, general.usuario, general.password)
    Private _idpersona As Integer
    Public Sub New(ByVal idpersona As Integer, ByVal nombre As String)
        InitializeComponent()
        txtpersona.Text = nombre
        dgv1.DataSource = db.procedimiento("get_empleado", idpersona)
        _idpersona = idpersona
    End Sub
    Private Sub dgv1_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEnter
        Dim i As Integer = e.RowIndex
        dgv2.DataSource = db.procedimiento("get_pagopersonal", dgv1.Item(0, i).Value)
        txtpersona.Text = "W"
    End Sub
    Private Sub btncontratar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontratar.Click
        If (validar_contrato() = True) Then
            Dim idempleado As Integer
            idempleado = db.procedimiento("update_empleado", -1, dtp1.Value, dtp2.Value, txtsueldo.Text, _idpersona).Rows(0)(0)
            MsgBox("Se ha agregado el contrato satisfactoriamente", MsgBoxStyle.Information)
            dgv1.DataSource = db.procedimiento("get_empleado", _idpersona)
            'lleno las semanas
            Dim d1, d2, da As DateTime
            Dim sem As Integer
            Dim dia As Integer
            Dim i As Integer
            d1 = dtp1.Value
            d2 = dtp2.Value.AddDays(1)
            sem = DateDiff(DateInterval.WeekOfYear, d1, d2)
            da = DateAdd(DateInterval.WeekOfYear, sem, d1)
            dia = Math.Abs(DateDiff(DateInterval.DayOfYear, da, d2))
            For i = 1 To sem
                db.procedimiento("update_pagopersonal", -1, idempleado, Year(d1), MonthName(Month(d1)), i, txtsueldo.Text, 0, Today, 0)
                d1 = d1.AddDays(7)
            Next
            If (dia > 0) Then
                Dim nuevosueldo As Double = Val(txtsueldo.Text) * dia / 7
                db.procedimiento("update_pagopersonal", -1, idempleado, Year(d1), MonthName(Month(d1)), i, nuevosueldo, 0, Today, 0)
            End If
        End If
    End Sub
    Private Function validar_contrato() As Boolean
        Dim valido As Boolean = True
        txtsueldo.Text = Trim(txtsueldo.Text)
        txtorden.Text = Trim(txtorden.Text)
        If (dtp2.Value < dtp1.Value) Then
            valido = False
            MsgBox("La fecha de inicio del contrato y fin del contrato, no son válidas", MsgBoxStyle.Exclamation)
        ElseIf (DateDiff(DateInterval.Month, dtp1.Value, dtp2.Value.AddDays(1)) < 1) Then
            valido = False
            MsgBox("Un contrato debe durar por lo menos 1 mes", MsgBoxStyle.Exclamation)
        ElseIf (Not IsNumeric(txtsueldo.Text) Or txtsueldo.Text = "") Then
            valido = False
            MsgBox("El sueldo no es válido", MsgBoxStyle.Exclamation)
        ElseIf (Val(txtsueldo.Text) <= 0) Then
            valido = False
            MsgBox("El sueldo no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
        End If
        Return valido
    End Function
    Private Sub dgv2_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv2.CellEnter
        Dim i As Integer = e.RowIndex
        txtidpago.Text = dgv2.Item(0, i).Value
        txtaño.Text = dgv2.Item(1, i).Value
        txtmes.Text = dgv2.Item(2, i).Value
        txtsemana.Text = dgv2.Item(3, i).Value
        txtmonto.Text = dgv2.Item(4, i).Value
        btnpagar.Enabled = Not dgv2.Item(5, i).Value
    End Sub
    Private Sub btnpagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagar.Click
        Dim i As Integer = dgv2.CurrentRow.Index
        Dim j As Integer = dgv1.CurrentRow.Index
        If (Not IsNumeric(txtorden.Text) Or txtorden.Text = "") Then
            MsgBox("La orden de pago no es válida", MsgBoxStyle.Exclamation)
            Exit Sub
        ElseIf (Val(txtorden.Text) <= 0) Then
            MsgBox("La orden de pago no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
            Exit Sub
        End If
        db.procedimiento("update_pagopersonal", txtidpago.Text, dgv1.Item(0, j).Value, txtaño.Text, txtmes.Text, txtsemana.Text, txtmonto.Text, 1, Date.Now, Me.txtorden.Text)
        print_report(db.ultimo_procedimiento.Rows(0)(0), "Pago de sueldo", txtmonto.Text, 0)
        MsgBox("Se pagó con exito", MsgBoxStyle.Information)
        dgv2.DataSource = db.procedimiento("get_pagopersonal", dgv1.Item(0, j).Value)
    End Sub
End Class