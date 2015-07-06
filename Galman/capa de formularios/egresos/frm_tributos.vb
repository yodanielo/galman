Public Class frm_tributos
    Private db As New BaseDato(general.server, general.usuario, general.password)
    Public Sub New()
        InitializeComponent()
        dgv1.DataSource = db.procedimiento("list_pagotributo")
        If (dgv1.Rows.Count = 0) Then
            btnnuevo_Click(btnnuevo, Nothing)
        End If
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        txtidtributo.Text = -1
        txtorden.Text = ""
        txtaño.Text = Year(Today)
        txtmes.SelectedIndex = Month(Today) - 1
        txtmonto.Text = 0
        dtpfecha.Value = Today
        cbopagador.Text = ""
    End Sub
    Private Sub dgv1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEnter
        Dim i As Integer = dgv1.CurrentRow.Index
        txtidtributo.Text = dgv1.Item(0, i).Value
        txtorden.Text = dgv1.Item(1, i).Value
        txtaño.Text = dgv1.Item(2, i).Value
        txtmes.Text = dgv1.Item(3, i).Value
        txtmonto.Text = dgv1.Item(4, i).Value
        dtpfecha.Value = dgv1.Item(5, i).Value
        cbopagador.Text = dgv1.Item(6, i).Value
    End Sub
    Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
        If (validar() = True) Then
            db.procedimiento("update_pagotributo", txtidtributo.Text, txtorden.Text, txtmes.Text, txtaño.Text, txtmonto.Text, dtpfecha.Value, cbopagador.Text)
            If (txtidtributo.Text = -1) Then
                print_report(db.ultimo_procedimiento.Rows(0)(0), "Pago por tributo", txtmonto.Text, 0)
            ElseIf (MsgBox("¿Desea imprimir el report ahora?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                print_report(db.ultimo_procedimiento.Rows(0)(0), "Pago por tributo", txtmonto.Text, 0)
            End If
            MsgBox("Se ha registrado con exito", MsgBoxStyle.Information)
            btnnuevo_Click(sender, e)
            dgv1.DataSource = db.procedimiento("list_pagotributo")
        End If
    End Sub
    Private Function validar() As Boolean
        Dim valido As Boolean = True
        Dim c As Control
        For Each c In Me.SplitContainer1.Panel2.Controls
            If (c.GetType Is GetType(TextBox)) Then
                c.Text = Trim(c.Text)
            End If
        Next
        If (txtorden.Text = "" Or Not IsNumeric(txtorden.Text)) Then
            MsgBox("La orden de pago no es válida o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtaño.Text = "" Or Not IsNumeric(txtaño.Text)) Then
            MsgBox("El año no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtmes.Text = "") Then
            MsgBox("El mes no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtmonto.Text = "" Or Not IsNumeric(txtmonto.Text)) Then
            MsgBox("El monto no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (cbopagador.Text = "") Then
            MsgBox("El pagador no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
End Class