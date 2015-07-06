Module Module1
    Public Sub print_report(ByVal txtreport As Integer, ByVal txtmotivo As String, ByVal txtmonto As Double, ByVal txtmora As Double)
        On Error Resume Next
        Dim r As New rptreport
        r.SetParameterValue("txtreport", txtreport)
        r.SetParameterValue("txtmotivo", txtmotivo)
        r.SetParameterValue("txtmonto", txtmonto)
        r.SetParameterValue("txtmora", txtmora)
        r.SetParameterValue("txtuser", general.usuario)
        r.SetParameterValue("txtmaquina", "s")
        r.SetParameterValue("txtaletras", general.aLetras(txtmonto + txtmora))
        Dim frm As New frm_vistaprevia(r)
        frm.ShowDialog()
    End Sub
End Module
