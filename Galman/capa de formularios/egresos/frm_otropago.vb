Public Class frm_otropago
    Private db As New BaseDato(general.server, general.usuario, general.password)
    Public Sub New()
        InitializeComponent()
        dgv1.DataSource = db.procedimiento("list_pagotro")
    End Sub
    Private Sub btnpagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagar.Click
        If (validar() = True) Then
            db.procedimiento("update_pagotro", txtidpago.Text, txtdescripcion.Text, txtfecha.Value, txtmonto.Text, txtdestinatario.Text, cbopagador.Text, txtorden.Text)
            If (txtidpago.Text = -1) Then
                print_report(db.ultimo_procedimiento.Rows(0)(0), txtdescripcion.Text, txtmonto.Text, 0)
            ElseIf (MsgBox("¿Desea Imprimir ahora el report?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                print_report(Me.txtidpago.Text, txtdescripcion.Text, txtmonto.Text, 0)
            End If
            MsgBox("El pago fue hecho con exito", MsgBoxStyle.Information)
            btnnuevo_Click(sender, e)
            dgv1.DataSource = db.procedimiento("list_pagotro")
        End If
    End Sub
    Private Function validar() As Boolean
        Dim valido As Boolean = True
        Dim x As Control
        For Each x In Me.SplitContainer1.Panel2.Controls
            If (x.GetType Is GetType(TextBox)) Then
                x.Text = Trim(x.Text)
            End If
        Next
        If (txtdestinatario.Text = "") Then
            MsgBox("El destinatario no no puede quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtdescripcion.Text = "") Then
            MsgBox("El concepto no puede quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Not IsNumeric(txtmonto.Text) Or txtmonto.Text = "") Then
            MsgBox("El monto no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Val(txtmonto.Text) <= 0) Then
            MsgBox("El monto no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Not IsNumeric(txtorden.Text) Or txtorden.Text = "") Then
            MsgBox("La orden de pago no es válida o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Val(txtorden.Text) <= 0) Then
            MsgBox("La orden de pago no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        txtidpago.Text = -1
        txtorden.Text = 1
        txtdescripcion.Text = ""
        txtfecha.Value = Today
        txtmonto.Text = 0
        cbopagador.Text = ""
    End Sub
    Private Sub dgv1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEnter
        Dim i As Integer = e.RowIndex
        On Error Resume Next
        txtidpago.Text = dgv1.Item(0, i).Value
        txtorden.Text = dgv1.Item(1, i).Value
        txtdescripcion.Text = dgv1.Item(2, i).Value
        txtfecha.Value = dgv1.Item(3, i).Value
        txtmonto.Text = dgv1.Item(4, i).Value
        cbopagador.Text = dgv1.Item(5, i).Value
        txtdestinatario.Text = dgv1.Item(6, i).Value
    End Sub
End Class