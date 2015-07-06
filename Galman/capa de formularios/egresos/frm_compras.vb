Public Class frm_compras
    Private db As New BaseDato(general.server, general.usuario, general.password)
    Public Sub New()
        InitializeComponent()
        dgv1.DataSource = db.procedimiento("list_pagcompra")
        If (dgv1.Rows.Count <= 0) Then
            btnnuevo_Click(Me, Nothing)
        End If
    End Sub
    Private Sub dgv1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEnter
        Dim i As Integer = e.RowIndex
        txtidcompra.Text = dgv1.Item(0, i).Value
        txtruc.Text = dgv1.Item(1, i).Value
        txtcomprobante.SelectedIndex = dgv1.Item(2, i).Value
        txtserie.Text = dgv1.Item(3, i).Value
        txtnumero.Text = dgv1.Item(4, i).Value
        txtrazsocial.Text = dgv1.Item(5, i).Value
        dtpfecha.Value = dgv1.Item(6, i).Value
        txtmonto.Text = dgv1.Item(7, i).Value
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        txtidcompra.Text = -1
        txtruc.Text = ""
        txtcomprobante.SelectedIndex = 1
        txtserie.Text = 0
        txtnumero.Text = 0
        txtrazsocial.Text = ""
        dtpfecha.Value = Today
        txtmonto.Text = 1
    End Sub
    Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
        If (validar() = True) Then
            Dim idreport As Integer
            idreport = db.procedimiento("update_pagcompra", txtidcompra.Text, Trim(txtruc.Text), txtcomprobante.SelectedIndex, Trim(txtserie.Text), Trim(txtnumero.Text), Trim(txtrazsocial.Text), Trim(dtpfecha.Value), Trim(txtmonto.Text)).Rows(0)(0)
            If (txtidcompra.Text = -1) Then
                print_report(idreport, "Pago por compras", txtmonto.Text, 0)
            ElseIf (MsgBox("¿Desea imprimir ahora el report?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                print_report(idreport, "Pago por compras", txtmonto.Text, 0)
            End If
            dgv1.DataSource = db.procedimiento("list_pagcompra")
            btnnuevo_Click(sender, e)
        End If
        MsgBox("Se ha registrado con exito", MsgBoxStyle.Information)
    End Sub
    Private Function validar() As Boolean
        Dim valido As Boolean = True
        txtruc.Text = Trim(txtruc.Text)
        txtserie.Text = Trim(txtserie.Text)
        txtnumero.Text = Trim(txtnumero.Text)
        txtrazsocial.Text = Trim(txtrazsocial.Text)
        txtmonto.Text = Trim(txtmonto.Text)
        If (txtruc.Text = "" Or Not IsNumeric(txtruc.Text)) Then
            MsgBox("El ruc no no es válido", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtnumero.Text = "" Or Not IsNumeric(txtnumero.Text) Or txtserie.Text = "" Or Not IsNumeric(txtserie.Text)) Then
            MsgBox("El numero de comprobante no es válido", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtrazsocial.Text = "") Then
            MsgBox("La razon social no puede queda en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtmonto.Text = "" Or Not IsNumeric(txtmonto.Text) Or txtserie.Text = "" Or Not IsNumeric(txtserie.Text)) Then
            MsgBox("El monto no es válido", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
End Class