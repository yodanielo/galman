Imports System.Diagnostics
Imports System.Windows.Forms

Public Class frm_persona
#Region "variables"
    ''' <summary>objeto para hacer referencia a la clase Clocal, Ccontrato, Cpjuridica,Cpnatural</summary>
    Private registro As BaseDato
    ''' <summary>objeto para hacer conceccion con la base de datos</summary>
    Private db As New BaseDato(general.server, general.usuario, general.password)
    ''' <summary>
    ''' dt es la tabla principal para cargar los datos en el grid
    ''' dt1 es la tabla auxiliar
    ''' </summary>
    Private dt, dt1 As New DataTable()
    ''' <summary>hace referencia a lo que se va a listar segun el tipo de procedimiento</summary>
    ''' <remarks>
    ''' list_perjurdiica
    ''' list_pernatural
    ''' list_conarrendamientos
    ''' list_local
    ''' </remarks>
    Private _proc As Eprocedimiento
#End Region
#Region "constructores"
    Public Sub New(ByVal procedure As Eprocedimiento)
        InitializeComponent()
        Dim ds As New DataSet
        _proc = procedure
        Select Case procedure
            Case Eprocedimiento.list_perjuridica
                Toolpersona.Visible = True
                toolcontrato.Visible = False
                chempleado.Visible = False
                toolocal.Visible = False
                tsbplanilla.Enabled = False
                Me.Text = "Listado de personas juridicas"
                dt = db.procedimiento(procedure.ToString & "2", 0, 0)
            Case Eprocedimiento.list_pernatural
                Toolpersona.Visible = True
                toolcontrato.Visible = False
                chempleado.Visible = True
                toolocal.Visible = False
                Me.Text = "Listado de personas naturales"
                dt = db.procedimiento(procedure.ToString)
            Case Eprocedimiento.list_conarrendamientos
                Toolpersona.Visible = False
                toolcontrato.Visible = True
                toolocal.Visible = False
                Me.Text = "Listado de contratos de arrendamiento"
                dt = db.procedimiento(procedure.ToString)
            Case Eprocedimiento.list_local
                Toolpersona.Visible = False
                toolcontrato.Visible = False
                chempleado.Visible = False
                toolocal.Visible = True
                Me.Text = "Listado de locales"
                dt = db.procedimiento(procedure.ToString)
            Case Eprocedimiento.list_compras
                Toolpersona.Visible = False
                toolcontrato.Visible = False
                chempleado.Visible = False
                toolocal.Visible = False
                dt = db.procedimiento(procedure.ToString)
        End Select
        DataGrid1.DataSource = dt
        dt1 = dt
    End Sub
    Public Sub New(ByVal idcontrato As Integer, ByVal procedimiento As Eproc_contrato)
        InitializeComponent()
        DataGrid1.DataSource = dt
        Select Case procedimiento
            Case Eproc_contrato.list_conarrjuridico
                Toolpersona.Visible = True
                toolcontrato.Visible = False
                chempleado.Visible = False
                toolocal.Visible = False
                Me.Text = "Listado de arrendatarios jurdiicos [Contrato Nº " & idcontrato & "]"
                dt = db.procedimiento(procedimiento.ToString)
            Case Eproc_contrato.list_conarrnatural
                Toolpersona.Visible = True
                toolcontrato.Visible = False
                chempleado.Visible = False
                toolocal.Visible = False
                Me.Text = "Listado de arrendatarios naturales [Contrato Nº " & idcontrato & "]"
                dt = db.procedimiento(procedimiento.ToString, idcontrato)
            Case Eproc_contrato.list_loccontrato
                Toolpersona.Visible = False
                toolcontrato.Visible = False
                chempleado.Visible = False
                toolocal.Visible = True
                Me.Text = "Listado de locales arrendados [Contrato Nº " & idcontrato & "]"
                dt = db.procedimiento(procedimiento.ToString, idcontrato)
        End Select
    End Sub
#End Region
#Region "general"
    Private Sub btn_nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_nuevo.Click
        '        On Error Resume Next
        Select Case _proc
            Case Eprocedimiento.list_perjuridica
                registro = New CPJuridica()
            Case Eprocedimiento.list_pernatural
                registro = New CPNatural()
            Case Eprocedimiento.list_conarrendamientos
                registro = New Ccontrato()
            Case Eprocedimiento.list_local
                registro = New CLocal()
            Case Eprocedimiento.list_compras
                registro = New Ccompra
        End Select
        propiedades.SelectedObject = registro
        dt = db.procedimiento(_proc.ToString)
        botones(False, False)
    End Sub
    Private Sub btn_guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_guardar.Click
        'On Error Resume Next
        CObj(registro).guardar()
        dt = db.procedimiento(_proc.ToString)
        DataGrid1.DataSource = dt
        botones(True)
        MsgBox("Proceso de guardado completado con exito", MsgBoxStyle.Information)
    End Sub
#End Region
#Region "persona natural"
    Private Sub chpersonas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles charrendatario.Click, chcontratista.Click, chempleado.Click
        Dim a As Integer = IIf(charrendatario.Checked, 1, 0)
        Dim b As Integer = IIf(chcontratista.Checked, 1, 0)
        Dim c As Integer = IIf(chempleado.Checked, 1, 0)
        If (_proc = Eprocedimiento.list_pernatural) Then
            DataGrid1.DataSource = db.procedimiento("list_pernatural2", a, b, c)
        Else
            DataGrid1.DataSource = db.procedimiento("list_perjuridica2", a, b)
        End If
        botones(True)
    End Sub
#End Region
#Region "contrato"
    Private Sub TSmantenimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbmantenimiento.Click
        If (DataGrid1.SelectedCells.Count > 0) Then
            Dim idcontrato As Integer
            idcontrato = DataGrid1.Item(0, DataGrid1.CurrentRow.Index).Value
            Dim a As New frm_cromantenimiento(idcontrato, CType(registro, Ccontrato).Monto_de_mora_de_mantenimiento)
            botones(True)
            a.ShowDialog()
        End If
    End Sub
#End Region
#Region "toolContrato"
#Region "toolArrendatarios"
    Private Sub PersonasNaturalesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (DataGrid1.SelectedCells.Count > 0) Then
            Dim con As Integer = DataGrid1.SelectedCells(0).Value(0)
            Dim x As New frm_persona(con, Eproc_contrato.list_conarrnatural)
            botones(True)
            x.ShowDialog()
        End If
    End Sub
    Private Sub PersonasJuridicasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (DataGrid1.SelectedCells.Count > 0) Then
            Dim con As Integer = DataGrid1.SelectedCells(0).Value(0)
            Dim x As New frm_persona(con, Eproc_contrato.list_conarrjuridico)
            botones(True)
            x.ShowDialog()
        End If
    End Sub
#End Region
    Private Sub tsblocales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (DataGrid1.SelectedCells.Count > 0) Then
            Dim con As Integer = DataGrid1.SelectedCells(0).Value(0)
            Dim x As New frm_persona(con, Eproc_contrato.list_loccontrato)
            botones(True)
        End If
    End Sub
    Private Sub rescindircontrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbrescindir.Click
        If (DataGrid1.SelectedCells.Count > 0) Then
            If (Trim(CType(registro, Ccontrato).Motivo_de_rescincion) <> "") Then
                db.procedimiento("rescindir_contrato", CType(registro, Ccontrato).Codigo, CType(registro, Ccontrato).Fecha_de_rescincion, CType(registro, Ccontrato).Motivo_de_rescincion)
                botones(True)
            Else
                MsgBox("Debe escribir un motivo de rescincion antes de rescindir el contrato", MsgBoxStyle.Exclamation)
            End If
        End If
    End Sub
    Private Sub tsbimprimircontrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbimprimircontrato.Click
        If (DataGrid1.SelectedCells.Count > 0) Then
            CType(registro, Ccontrato).imprimir_contrato_nuevo(True)
            botones(True)
        End If
    End Sub
    Private Sub tsbmercedconductiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbmercedconductiva.Click
        If (DataGrid1.SelectedCells.Count > 0) Then
            Dim i As Integer = DataGrid1.CurrentRow.Index
            Dim a As New frm_cromerconductiva(DataGrid1.Item(0, i).Value, CType(registro, Ccontrato).Monto_de_mora_de_merced_conductiva)
            botones(True)
            a.ShowDialog()
        End If
    End Sub
    Private Sub tsbplanilla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbplanilla.Click
        If (DataGrid1.SelectedCells.Count > 0) Then
            On Error GoTo bug
            ' se supone que solo pnatural debe tener este icono
            Dim i As Integer = DataGrid1.CurrentRow.Index
            'tsbpropiedades_Click(sender, e)
            botones(False)
            Dim frm As New frm_planilla(DataGrid1.Item(0, i).Value, CType(registro, CPNatural).nombres + " " + CType(registro, CPNatural).apellidos)
            frm.ShowDialog()
        End If
bug:
    End Sub
    Private Sub tsbcontratista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbcontratista.Click
        If (DataGrid1.SelectedCells.Count > 0) Then
            botones(False)
            Dim i As Integer = DataGrid1.CurrentRow.Index
            If (_proc = Eprocedimiento.list_perjuridica) Then
                Dim frm As New frm_contratista(DataGrid1.Item(0, i).Value, 0, CType(registro, CPJuridica).Razon_Social)
                frm.ShowDialog()
            Else
                Dim frm As New frm_contratista(DataGrid1.Item(0, i).Value, 1, CType(registro, CPNatural).nombres + " " + CType(registro, CPNatural).apellidos)
                frm.ShowDialog()
            End If
        End If
    End Sub
#End Region
#Region "locales"
    Private Sub chlocal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbtiendas.Click, tsbtalleres.Click, tsbalmacenes.Click, tsbvitrinas.Click, tsboficinas.Click, tsbotros.Click
        Dim a, b, c, d, _e, f As Integer
        a = IIf(tsbtiendas.Checked, 1, 0)
        b = IIf(tsbtalleres.Checked, 1, 0)
        c = IIf(tsbalmacenes.Checked, 1, 0)
        d = IIf(tsbvitrinas.Checked, 1, 0)
        _e = IIf(tsboficinas.Checked, 1, 0)
        f = IIf(tsbotros.Checked, 1, 0)
        DataGrid1.DataSource = db.procedimiento("list_local2", a, b, c, d, _e, f)
        botones(True)
    End Sub
#End Region
    Private Sub tstbuscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tstbuscar.KeyPress
        On Error Resume Next
        Dim fila, columna, buscado, valor As Integer
        fila = DataGrid1.SelectedCells(0).RowIndex
        columna = DataGrid1.SelectedCells(0).ColumnIndex
        If (e.KeyChar <> Chr(13)) Then
            fila = 0
        Else
            fila += 1
        End If
        For buscado = fila To DataGrid1.Rows.Count - 1
            valor = InStr(DataGrid1.Item(columna, buscado).Value, tstbuscar.Text)
            If (valor = 1) Then
                Do While DataGrid1.SelectedCells.Count > 0
                    DataGrid1.SelectedCells(0).Selected = False
                Loop
                DataGrid1.Item(columna, buscado).Selected = True
                Exit For
            End If
        Next
        botones(True)
    End Sub
    Private Sub tsbpropiedades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbpropiedades.Click
        On Error Resume Next
        If (DataGrid1.SelectedCells.Count > 0) Then
            botones(False, False)
            If (spc1.Panel2Collapsed = False) Then
                Dim fila As Integer = DataGrid1.SelectedCells(0).RowIndex
                Select Case _proc
                    Case Eprocedimiento.list_perjuridica
                        registro = New CPJuridica(DataGrid1.Rows(fila).Cells(0).Value)
                    Case Eprocedimiento.list_pernatural
                        registro = New CPNatural(DataGrid1.Rows(fila).Cells(0).Value)
                    Case Eprocedimiento.list_conarrendamientos
                        registro = New Ccontrato(DataGrid1.Rows(fila).Cells(0).Value)
                    Case Eprocedimiento.list_local
                        registro = New CLocal(DataGrid1.Rows(fila).Cells(0).Value)
                    Case Eprocedimiento.list_compras
                        registro = New Ccompra(DataGrid1.Rows(fila).Cells(0).Value)
                End Select
                propiedades.SelectedObject = registro
            End If
        End If
    End Sub
    'Private Sub DataGrid1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid1.CellContentClick
    '    botones(True)
    'End Sub
    Private Sub tsbcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbcancelar.Click
        botones(True)
        If (DataGrid1.Rows.Count > 0) Then
            If (DataGrid1.SelectedCells.Count = 0) Then
                DataGrid1.Item(0, 0).Selected = True
            End If
        End If
    End Sub
    Private Sub botones(ByVal oculto As Boolean, Optional ByVal asignar As Boolean = True)
        spc1.Panel2Collapsed = oculto
        btn_guardar.Enabled = Not spc1.Panel2Collapsed
        tsbpropiedades.Enabled = spc1.Panel2Collapsed
        tsbcancelar.Enabled = Not spc1.Panel2Collapsed
        If (asignar = True AndAlso oculto = False) Then
            tsbpropiedades_Click(Nothing, Nothing)
        End If
    End Sub
    Private Sub DataGrid1_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid1.RowEnter
        botones(True)
    End Sub
End Class
