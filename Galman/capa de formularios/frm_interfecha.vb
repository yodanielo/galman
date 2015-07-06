Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Public Class frm_interfecha
    Private rep As Object
    Public Sub New(ByVal rpt As Ereporte)
        InitializeComponent()
        Select Case rpt
            Case Ereporte.rptfacturacion
                rep = New rptfacturacion
            Case Ereporte.rptincobrables
                'rep=new rptincobrables
            Case Ereporte.rptingresos
                rep = New rptingresos
            Case Ereporte.rptservicios_fecha
                rep = New rptservicios_fecha
            Case Ereporte.rptreport_fecha
                rep = New rptreport_fecha
            Case Ereporte.rptreport_codigo
                rep = New rptreport
                Panel1.Visible = False
                Panel2.Visible = True
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As frm_vistaprevia
        Dim pfd1, pfd2 As ParameterFieldDefinition
        Dim pv1, pv2 As ParameterValues
        Dim pdv1, pdv2 As New ParameterDiscreteValue
        If (Panel1.Visible = True) Then 'fecha
            'rep.SetParameterValue("@fecha1") = dtp1.Value
            pfd1 = rep.DataDefinition.ParameterFields("@fecha1")
            pv1 = pfd1.CurrentValues
            pdv1.Value = dtp1.Value
            pv1.Add(pdv1)
            pfd1.ApplyCurrentValues(pv1)
            ''''
            pfd2 = rep.DataDefinition.ParameterFields("@fecha2")
            pv2 = pfd1.CurrentValues
            pdv2.Value = dtp2.Value
            pv2.Add(pdv2)
            pfd2.ApplyCurrentValues(pv2)
        Else
            text1_Validating(text1, Nothing)
            text1_Validating(text2, Nothing)
            pfd1 = rep.DataDefinition.ParameterFields("@codinicio")
            pv1 = pfd1.CurrentValues
            pdv1.Value = Me.text1.Text
            pv1.Add(pdv1)
            pfd1.ApplyCurrentValues(pv1)
            ''''
            pfd2 = rep.DataDefinition.ParameterFields("@codfin")
            pv2 = pfd1.CurrentValues
            pdv2.Value = Me.text2.Text
            pv2.Add(pdv2)
            pfd2.ApplyCurrentValues(pv2)
        End If
        rep.setparametervalue("txtuser", general.usuario)
        rep.setparametervalue("txtmaquina", general.maquina)
        frm = New frm_vistaprevia(rep)
        frm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub text1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles text1.Validating, text2.Validating
        On Error Resume Next
        sender.text = Val(sender.text)
        If (Not IsNumeric(sender.text)) Then
            MsgBox("En este campo solo se ponen números", MsgBoxStyle.Exclamation)
            sender.Focus()
        End If
    End Sub
End Class