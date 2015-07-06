Public Class frm_servicio
    Dim db As New BaseDato(general.server, general.usuario, general.password)
    Public Sub New()
        InitializeComponent()
        dgv1.DataSource = db.procedimiento("list_servicio")
        btnnuevo_Click(Nothing, Nothing)
    End Sub
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        txtidservicio.Text = -1
        txtorden.Text = 0
        txttipo.SelectedIndex = 0
        txtaño.Text = Year(Today)
        txtmes.SelectedIndex = Month(Today) - 1
        txtmonto.Text = 0
        dtpfecha.Value = Today
        cbopagador.Text = ""
    End Sub
    Private Sub dgv1_CellEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEnter
        Dim i As Integer = e.RowIndex
        txtidservicio.Text = dgv1.Item(0, i).Value
        txtorden.Text = dgv1.Item(1, i).Value
        txttipo.Text = dgv1.Item(2, i).Value
        txtmes.Text = dgv1.Item(3, i).Value
        txtaño.Text = dgv1.Item(4, i).Value
        txtmonto.Text = dgv1.Item(5, i).Value
        dtpfecha.Value = dgv1.Item(6, i).Value
        cbopagador.Text = dgv1.Item(7, i).Value
    End Sub
    Private Sub btnregistrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnregistrar.Click
        If (validar() = True) Then
            db.procedimiento("update_pagoservicio", txtidservicio.Text, txtorden.Text, txttipo.SelectedIndex, txtmes.Text, txtaño.Text, txtmonto.Text, dtpfecha.Value, cbopagador.Text)
            If (txtidservicio.Text = -1) Then
                print_report(db.ultimo_procedimiento.Rows(0)(0), "Pago de servicio de " & txttipo.Text, txtmonto.Text, 0)
            ElseIf (MsgBox("¿Desea imprimir el report ahora?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) = MsgBoxResult.Yes) Then
                print_report(db.ultimo_procedimiento.Rows(0)(0), "Pago de servicio de " & txttipo.Text, txtmonto.Text, 0)
            End If
            btnnuevo_Click(sender, e)
            dgv1.DataSource = db.procedimiento("list_servicio")
            MsgBox("El pago se hizo con exito", MsgBoxStyle.Information)
        End If
    End Sub
    Private Function validar() As Boolean
        Dim valido As Boolean = True
        txtorden.Text = Trim(txtorden.Text)
        txtaño.Text = Trim(txtaño.Text)
        txtmonto.Text = Trim(txtmonto.Text)
        cbopagador.Text = Trim(cbopagador.Text)
        If (txtorden.Text = "" Or Not IsNumeric(txtorden.Text)) Then
            MsgBox("La orden de pago no es válida o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txttipo.Text = "") Then
            MsgBox("Debe seleccionar un servicio", MsgBoxStyle.Exclamation)
            valido = True
        ElseIf (txtaño.Text = "" Or Not IsNumeric(txtaño.Text)) Then
            MsgBox("El año no se válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtmes.Text = "") Then
            MsgBox("Debe seleccionar un mes", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtmonto.Text = "" Or Not IsNumeric(txtmonto.Text)) Then
            MsgBox("El monto no es válido", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (cbopagador.Text = "") Then
            MsgBox("El pagador no es válido o está en blanco", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
End Class