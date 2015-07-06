Public Class frm_cromerconductiva
    Dim registro As New BaseDato(general.server, general.usuario, general.password)
    Private mora As Decimal
    Private _idcontrato As Integer
    Public Sub New(ByVal idcontrato As Integer, ByVal _mora As Decimal)
        On Error Resume Next
        InitializeComponent()
        'cojo las mercedconductivas
        mora = _mora
        _idcontrato = idcontrato
        cargar(idcontrato)
    End Sub
    Private Sub cargar(ByVal idcontrato As Integer)
        Dim ds As New DataSet
        ds.Tables.Add(registro.procedimiento("get_merconductiva", idcontrato))
        ds.Tables.Add(registro.procedimiento("get_cuomerconductiva", idcontrato))
        ds.Relations.Add("Cuotas_pagadas", ds.Tables("get_merconductiva").Columns(0), ds.Tables("get_cuomerconductiva").Columns(1))
        DataGrid1.DataSource = ds.Tables(0)
        Me.txtcontrato.Text = "Contrato Nº " & idcontrato
    End Sub
    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        'On Error GoTo bug
        Dim i As Integer = DataGrid1.CurrentRowIndex
        If (DataGrid1.Item(i, 9) = 0) Then
            txtcuota.Text = DataGrid1.Item(i, 1)
            txtmes.Text = DataGrid1.Item(i, 2)
            Me.txtmercedconductiva.Text = Val(DataGrid1.Item(i, 4))
            Me.txtmora.Text = Val(DataGrid1.Item(i, 7)) * mora * IIf(DataGrid1.Item(i, 8) = True, 1, 0)
            Me.txtdeudatotal.Text = Val(Me.txtmora.Text) + Val(Me.txtmercedconductiva.Text)
            Me.txtpagado.Text = Val(DataGrid1.Item(i, 5))
            Me.txtdebe.Text = Val(Me.txtdeudatotal.Text) - Val(Me.txtpagado.Text)
            chkcobrar.Checked = CInt(DataGrid1.Item(i, 8))
            Me.txtacuenta.Text = Me.txtdebe.Text
            If (Val(txtpagado.Text) <= Val(txtmercedconductiva.Text)) Then
                chkcobrar.Enabled = True
            Else
                chkcobrar.Enabled = False
            End If
            tsbguardar.Enabled = True
        Else
bug:        tsbguardar.Enabled = False
        End If
    End Sub
    Private Sub tsbguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbguardar.Click
        Dim i As Integer = DataGrid1.CurrentRowIndex
        If (Val(txtacuenta.Text) <= 0 Or Val(txtacuenta.Text) > Val(txtdebe.Text)) Then
            MsgBox("La cantidad a pagar no es válida", MsgBoxStyle.Exclamation)
        Else
            'guardo
            Dim idreport As Integer = registro.procedimiento("update_report", -1, "tcuomerconductiva", 1, Date.Now).Rows(0)(0)
            Dim idm As Integer = DataGrid1.Item(i, 0)
            registro.procedimiento("update_cuomerconductiva", -1, idm, CDbl(txtacuenta.Text), idreport, Date.Now, txtmora.Text, IIf(chkcobrar.Checked, 1, 0))
            'imprimo
            Dim rpt As New rptreport
            rpt.SetParameterValue("txtreport", idreport)
            rpt.SetParameterValue("txtmotivo", "Merced conductiva")
            If (Val(txtdebe.Text) - Val(txtmora.Text) <= 0) Then
                rpt.SetParameterValue("txtmonto", 0)
                If (Me.chkcobrar.Checked = True) Then
                    rpt.SetParameterValue("txtmora", 0)
                Else
                    rpt.SetParameterValue("txtmora", txtacuenta.Text)
                End If
            ElseIf (Val(txtdebe.Text) - Val(txtmora.Text) >= Val(txtacuenta.Text)) Then
                rpt.SetParameterValue("txtmonto", txtacuenta.Text)
                rpt.SetParameterValue("txtmora", 0)
            Else
                rpt.SetParameterValue("txtmonto", Val(txtdebe.Text) - Val(txtmora.Text))
                rpt.SetParameterValue("txtmora", txtacuenta.Text - (Val(txtdebe.Text) - Val(txtmora.Text)))
            End If
            rpt.SetParameterValue("txtaletras", general.aLetras(Val(txtacuenta.Text)))
            rpt.SetParameterValue("txtuser", general.usuario)
            rpt.SetParameterValue("txtmaquina", (New registro).leer("HKLM\system\currentcontrolset\control\computername\computername\computername"))
            Dim iu As New frm_vistaprevia(rpt)
            iu.ShowDialog()
            MsgBox("Pagado con exito", MsgBoxStyle.Information)
            'cargar(_idcontrato)
            Me.Close()
        End If
    End Sub
    Private Sub txtacuenta_Validating(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtacuenta.TextChanged
        If (Trim(sender.Text) = "" Or Val(Trim(sender.Text)) <= 0) Then
            sender.text = "1"
        End If
        If (Val(Trim(txtacuenta.Text)) > Val(Me.txtdebe.Text)) Then
            txtacuenta.Text = txtdebe.Text
        End If
    End Sub
    Private Sub chkcobrar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If (chkcobrar.Checked = False) Then
            txtmora.Text = 0
            txtdebe.Text = Me.txtmercedconductiva.Text - Me.txtpagado.Text
        Else
            Dim i As Integer = DataGrid1.CurrentRowIndex
            txtmora.Text = mora
            txtdebe.Text = Me.txtmercedconductiva.Text - Me.txtpagado.Text + Me.txtmora.Text
        End If
    End Sub
End Class