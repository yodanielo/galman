Public Class frm_vencidos

    Private Sub frm_vencidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim a As New BaseDato(general.server, general.usuario, general.password)
        Me.DataGridView1.DataSource = a.procedimiento("get_convencidos")
    End Sub
End Class