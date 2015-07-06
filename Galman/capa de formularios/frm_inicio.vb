Public NotInheritable Class frm_inicio
    Private Sub frm_inicio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Close()
    End Sub
End Class
