Public Class frm_cromantenimiento
#Region "variables"
    ''' <summary>dt1 es el datatable del maestro y dt2 es el datatable del detalle</summary>
    Private dt1, dt2 As DataTable
    ''' <summary>la mora que se cobra</summary>
    ''' 
    Private mora As Double
    ''' <summary>idcontrato</summary>
    ''' 
    Private m_contrato As Integer
#End Region
    Public Sub New(ByVal idcontrato As Integer, ByVal _mora As Double)
        InitializeComponent()
        txtcontrato.Text = "Contrato Nº " & idcontrato
        cargar(idcontrato)
        mora = _mora
        m_contrato = idcontrato
    End Sub
    ''' <summary>carga los datos en el grid</summary>
    Private Sub cargar(ByVal _idcontrato)
        On Error Resume Next
        Dim a As New BaseDato(general.server, general.usuario, general.password)
        Dim b As DataRelation
        Dim c As New DataSet
        dt1 = a.procedimiento("get_mantenimiento", _idcontrato)
        dt2 = a.procedimiento("get_cuomantenimiento", _idcontrato)
        c.Tables.Add(dt1)
        c.Tables.Add(dt2)
        b = New DataRelation("Cuotas_de_pago", dt1.Columns("Nº"), dt2.Columns("Nº de mantenimiento"))
        c.Relations.Add(b)
        Me.DataGridView1.DataSource = dt1
    End Sub
    ''' <summary>evento que se activa cuando se pasa de celda en celda, 
    ''' que sirve para cargar los datos en el propertygrid</summary>
    Private Sub DataGridView1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.CurrentCellChanged
        Dim i As Integer
        On Error GoTo bug
        i = DataGridView1.CurrentRowIndex
        If (DataGridView1.Item(i, 10) = False) Then
            i = DataGridView1.CurrentRowIndex
            txtrango.Text = DataGridView1.Item(i, 3)
            txtsemana.Text = DataGridView1.Item(i, 1)
            txtmonto.Text = DataGridView1.Item(i, 4)
            txtmora.Text = CInt(DataGridView1.Item(i, 7)) * mora
            txtdeudatotal.Text = Val(txtmonto.Text) + Val(txtmora.Text)
            txtpagado.Text = DataGridView1.Item(i, 5)
            txtdebe.Text = DataGridView1.Item(i, 6)
            txtacuenta.Text = txtdebe.Text
            chkcobrar.Checked = DataGridView1.Item(i, 9)
            If (Val(txtdebe.Text) <= Val(txtmonto.Text)) Then
                chkcobrar.Enabled = True
            Else
                chkcobrar.Enabled = False
            End If
            tsbguardar.Enabled = True
        Else
bug:        tsbguardar.Enabled = False
        End If
    End Sub
    ''' <summary>para validar los datos en los txt para cobrar</summary>
    Private Sub txtmonto_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If (Trim(sender.Text) = "" Or Val(Trim(sender.Text)) <= 0) Then
            sender.text = "1"
        End If
        If (Val(Trim(txtacuenta.Text)) > Val(Me.txtdebe.Text)) Then
            txtacuenta.Text = txtdebe.Text
        End If
    End Sub
    ''' <summary>para guardar en la DB</summary>
    Private Sub tsbguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbguardar.Click
        ''validando
        If (Val(txtacuenta.Text) = 0 Or Val(txtacuenta.Text) > Val(txtdebe.Text)) Then
            MsgBox("Monto a pagar no valido", MsgBoxStyle.Exclamation)
            txtmonto.Text = 1
        Else
            Dim i, j, idmantenimiento As Integer
            Dim db As New BaseDato(general.server, general.usuario, general.password)
            Dim idreport As Integer = db.procedimiento("update_report", -1, "tcuomantenimiento", 1, Date.Now).Rows(0)(0)
            i = DataGridView1.CurrentRowIndex
            idmantenimiento = DataGridView1.Item(i, 0)
            db.procedimiento("update_cuomantenimiento", -1, idmantenimiento, Val(txtacuenta.Text), Val(txtmora.Text), chkcobrar.Checked)
            Dim cra As New rptreport()
            Dim frm As frm_vistaprevia
            'para poner en el report
            j = db.procedimiento("update_cuomantenimiento", -1, idmantenimiento, txtmonto.Text, txtmora.Text, IIf(Me.chkcobrar.Checked, 1, 0)).Rows(0)(0)
            cra.SetParameterValue("txtreport", j)
            cra.SetParameterValue("txtmotivo", "Mantenimiento de locales")
            If (Val(txtdebe.Text) - Val(txtmora.Text) <= 0) Then
                cra.SetParameterValue("txtmonto", 0)
                If (Me.chkcobrar.Checked = True) Then
                    cra.SetParameterValue("txtmora", 0)
                Else
                    cra.SetParameterValue("txtmora", txtacuenta.Text)
                End If
            ElseIf (Val(txtdebe.Text) - Val(txtmora.Text) >= Val(txtacuenta.Text)) Then
                cra.SetParameterValue("txtmonto", txtacuenta.Text)
                cra.SetParameterValue("txtmora", 0)
            Else
                cra.SetParameterValue("txtmonto", Val(txtdebe.Text) - Val(txtmora.Text))
                cra.SetParameterValue("txtmora", txtacuenta.Text - (Val(txtdebe.Text) - Val(txtmora.Text)))
            End If
            cra.SetParameterValue("txtaletras", general.aLetras(txtacuenta.Text))
            cra.SetParameterValue("txtuser", general.usuario)
            cra.SetParameterValue("txtmaquina", (New registro).leer("HKLM\system\currentcontrolset\control\computername\computername\computername"))
            frm = New frm_vistaprevia(cra)
            frm.ShowDialog()
            cargar(m_contrato)
            MsgBox("Pagado con exito", MsgBoxStyle.Information)
            Me.Close()
        End If
    End Sub
    Private Sub chkcobrar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        On Error Resume Next
        If (chkcobrar.Checked = False) Then
            txtmora.Text = 0
            txtdebe.Text = Me.txtmonto.Text - Me.txtpagado.Text
        Else
            Dim i As Integer = DataGridView1.CurrentRowIndex
            txtmora.Text = mora
            txtdebe.Text = Me.txtmonto.Text - Me.txtpagado.Text + Me.txtmora.Text
        End If
    End Sub
End Class