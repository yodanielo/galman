Public Class frm_entregaokanito
    Dim db As New BaseDato(general.server, general.usuario, general.password)
    Public Sub New()
        InitializeComponent()
        dgv1.DataSource = db.procedimiento("list_entregaokanito")
    End Sub
    Private Sub btnpagar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpagar.Click
        If (validar() = True) Then
            db.procedimiento("update_entregaokanito", txtidpago.Text, cbosocio.SelectedIndex, txtmonto.Text, dtp1.Value, txtdescripcion.Text, txtorden.Text)
            print_report(db.ultimo_procedimiento.Rows(0)(0), "Pago por entrega a OKANITO", txtmonto.Text, 0)
            MsgBox("Se ha pagado con exito", MsgBoxStyle.Exclamation)
            dgv1.DataSource = db.procedimiento("list_entregaokanito")
        End If
    End Sub
    Private Function validar() As Boolean
        Dim valido As Boolean = True
        txtdescripcion.Text = Trim(txtdescripcion.Text)
        txtmonto.Text = Trim(txtmonto.Text)
        txtorden.Text = Trim(txtorden.Text)
        If (cbosocio.Text = "") Then
            MsgBox("Debe seleccionar un socio", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtdescripcion.Text = "") Then
            MsgBox("La descripcion no puede quedar en blanco", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtmonto.Text = "" Or Not IsNumeric(txtmonto.Text)) Then
            MsgBox("El monto no es válido", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Val(txtmonto.Text) <= 0) Then
            MsgBox("El monto no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (txtorden.Text = "" Or Not IsNumeric(txtorden.Text)) Then
            MsgBox("La orden de pago no es válido", MsgBoxStyle.Exclamation)
            valido = False
        ElseIf (Val(txtorden.Text) <= 0) Then
            MsgBox("La orden de pago no puede ser menor o igual a cero", MsgBoxStyle.Exclamation)
            valido = False
        End If
        Return valido
    End Function
    Private Sub btnnuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnuevo.Click
        txtidpago.Text = -1
        cbosocio.Text = ""
        txtdescripcion.Text = ""
        txtmonto.Text = 0
        txtorden.Text = 0
        dtp1.Value = Today
    End Sub
    Private Sub dgv1_Cellenter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellEnter
        Dim i As Integer = e.RowIndex
        txtidpago.Text = dgv1.Item(0, i).Value
        cbosocio.Text = dgv1.Item(1, i).Value
        txtdescripcion.Text = dgv1.Item(4, i).Value
        txtmonto.Text = dgv1.Item(2, i).Value
        txtorden.Text = dgv1.Item(5, i).Value
        dtp1.Value = dgv1.Item(3, i).Value
    End Sub
End Class