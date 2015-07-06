Imports CrystalDecisions.Shared
Public Class frm_reporte
    Private _rpt As Object
    Public Sub New(ByVal reporte As Ereporte)
        InitializeComponent()
        Dim rpt As New Object
        Select Case reporte
            Case Ereporte.rptfacturacion
                'rpt = New rptfacturacion
                Me.RadioButton2.Enabled = True
            Case Ereporte.rptincobrables
                'rpt=rptincobrables
                Me.RadioButton2.Enabled = True
            Case Ereporte.rptingresos
                'rpt = New rptingresos
                Me.RadioButton2.Enabled = True
            Case Ereporte.rptreport_codigo
                'rpt=new rptreport_codigo
                Me.RadioButton2.Checked = True
                Me.RadioButton1.Enabled = False
            Case Ereporte.rptreport_fecha
                'rpt=new rptreport_fecha
                Me.RadioButton2.Enabled = False
        End Select
        _rpt = rpt
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        Panel1.Enabled = True
        Panel2.Enabled = False
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        Panel1.Enabled = False
        Panel2.Enabled = True
    End Sub

    Private Sub TextBox1_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles v1.Validating, v2.Validating
        If (IsNumeric(sender.text) = False) Then
            sender.text = 1
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim vista As frm_vistaprevia
        Dim paraminicio As New ParameterDiscreteValue
        Dim paramfinal As New ParameterDiscreteValue
        Dim paramlist As New ParameterFields
        Dim paramtemp As ParameterField
        If (Me.RadioButton1.Checked) Then
            paraminicio.Value = dtp1.Value
            paramfinal.Value = dtp2.Value
            ''''''''''''''''''primer parametro
            paramtemp = New ParameterField
            paramtemp.Name = "@fecha1"
            paramtemp.CurrentValues.Add(paramfinal)
            paramlist.Add(paramtemp)
            ''''''''''''''''''segundo parametro
            paramtemp = New ParameterField
            paramtemp.Name = "@fecha2"
            paramtemp.CurrentValues.Add(paramfinal)
            paramlist.Add(paramtemp)
        Else
            paraminicio.Value = v1.Text
            paramfinal.Value = v2.Text
            ''''''''''''''''''primer parametro
            paramtemp = New ParameterField
            paramtemp.Name = "@codinicio"
            paramtemp.CurrentValues.Add(paramfinal)
            paramlist.Add(paramtemp)
            ''''''''''''''''''segundo parametro
            paramtemp = New ParameterField
            paramtemp.Name = "@codfin"
            paramtemp.CurrentValues.Add(paramfinal)
            paramlist.Add(paramtemp)
        End If
        vista = New frm_vistaprevia(_rpt)
        vista.CrystalReportViewer1.ParameterFieldInfo = paramlist
    End Sub
End Class