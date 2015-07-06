Public Class frm_contratista
    Private db As New BaseDato(general.server, general.usuario, general.password)
    Private _idpersona As Integer
    Private _tipo As Integer
    Public Sub New(ByVal idpersona As Integer, ByVal tipo As Integer, ByVal nombre As String)
        InitializeComponent()
        txtnombre.Text = nombre
        dgv1.DataSource = db.procedimiento("get_pagcontratista", idpersona, tipo)
        _idpersona = idpersona
        _tipo = tipo
    End Sub
    Private Sub dgv1_Cellenter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEnter
        Dim i As Integer = e.RowIndex
        txtcontrato.Text = dgv1.Item(0, i).Value
        txtconcepto.Text = dgv1.Item(1, i).Value
        txtmonto.Text = dgv1.Item(2, i).Value
        btnpagar.Enabled = Not dgv1.Item(3, i).Value
    End Sub
    Private Sub btncontratar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncontratar.Click
        If (validar_contratar() = True) Then
            db.procedimiento("update_pagcontratista", -1, _idpersona, _tipo, txtconcepto.Text, txtmonto.Text, 0, 0)
            MsgBox("Se ha contratado con exito", MsgBoxStyle.Information)
            dgv1.DataSource = db.procedimiento("get_pagcontratista", _idpersona, _tipo)
        End If
    End Sub
    Private Sub btnpagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagar.Click
        Dim i As Integer = dgv1.CurrentRow.Index
        db.procedimiento("Update_pagcontratista", dgv1.Item(0, i).Value, 1, 1, "w", 0, 1, txtorden.Text)
        Module1.print_report(db.ultimo_procedimiento.Rows(0)(0), "Pago por servicios prestados", txtmonto.Text, 0)
        MsgBox("Se ha contratado con exito", MsgBoxStyle.Information)
        dgv1.DataSource = db.procedimiento("get_pagcontratista", _idpersona, _tipo)
    End Sub
    Private Function validar_contratar() As Boolean
        Dim valido As Boolean = True
        txtconcepto.Text = Trim(txtconcepto.Text)
        txtmonto.Text = Trim(txtmonto.Text)
        If (txtconcepto.Text = "") Then
            MsgBox("El concepto no es válido", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Not IsNumeric(txtmonto.Text) Or txtmonto.Text = "") Then
            MsgBox("El monto no es válido", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Val(txtmonto.Text) <= 0) Then
            MsgBox("El monto no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Not IsNumeric(txtorden.Text) Or txtorden.Text = "") Then
            MsgBox("La orden de pago no es válido", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Val(txtorden.Text) <= 0) Then
            MsgBox("La orden de pago no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
End Class