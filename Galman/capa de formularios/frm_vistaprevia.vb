Public Class frm_vistaprevia
    Public Sub New(ByVal a As Object)
        InitializeComponent()
        Me.CrystalReportViewer1.ReportSource = a
    End Sub
End Class