Public Class frm_loccontrato
    Public _arr1, _brr1 As List(Of CPNatural)
    Public _arr2, _brr2 As List(Of CPJuridica)
    Public _arr3, _brr3 As List(Of CLocal)
    Private _proc As Eproc_contrato
    Public Sub New(ByVal arr As List(Of CPNatural), ByVal proc As Eproc_contrato)
        InitializeComponent()
        _arr1 = arr
        asignar(arr, Nothing, Nothing)
        _proc = proc
        Dim bd As New BaseDato(general.server, general.usuario, general.password)
        dgv1.DataSource = bd.procedimiento("list_pernatural")
        Me.Text = "Arrendatarios Naturales"
        Dim listnat As CPNatural
        For Each listnat In arr
            lv1.Items.Add("s" & CStr(listnat.Codigo), listnat.nombres & " " & listnat.apellidos, 0)
        Next
    End Sub
    Public Sub New(ByVal arr As List(Of CPJuridica), ByVal proc As Eproc_contrato)
        InitializeComponent()
        _arr2 = arr
        asignar(Nothing, arr, Nothing)
        _proc = proc
        Dim bd As New BaseDato(general.server, general.usuario, general.password)
        dgv1.DataSource = bd.procedimiento("list_perjuridica2", 0, 0)
        Me.Text = "Arrendatarios Juridicos"
        Dim listjur As CPJuridica
        For Each listjur In arr
            lv1.Items.Add("s" & CStr(listjur.Codigo), listjur.Razon_Social, 2)
        Next
    End Sub
    Public Sub New(ByVal arr As List(Of CLocal), ByVal proc As Eproc_contrato)
        InitializeComponent()
        _arr3 = arr
        asignar(Nothing, Nothing, arr)
        _proc = proc
        Dim bd As New BaseDato(general.server, general.usuario, general.password)
        dgv1.DataSource = bd.procedimiento("list_locnoarrendado")
        Me.Text = "Locales arrendados en el contrato"
        Dim listloc As CLocal
        For Each listloc In arr
            lv1.Items.Add("s" & CStr(listloc.Codigo), listloc.Nombre, 1)
        Next
    End Sub
    Private Sub asignar(ByVal a As Object, ByVal b As Object, ByVal c As Object)
        _brr1 = a
        _brr2 = b
        _brr3 = c
    End Sub
    Private Sub tsbaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbaceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub
    Private Sub tsbcancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbcancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        _arr1 = _brr1
        _arr2 = _brr2
        _arr3 = _brr3
        Me.Close()
    End Sub
    Private Sub dgv1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv1.CellDoubleClick
        tsbagregar_Click(sender, e)
    End Sub
    Private Sub tsbagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbagregar.Click
        Dim id As String = dgv1.SelectedRows(0).Cells(0).Value
        Select Case _proc
            Case Eproc_contrato.list_loccontrato
                Dim nombre As String = dgv1.SelectedRows(0).Cells(1).Value
                If (lv1.Items.IndexOfKey("s" & id) < 0) Then
                    lv1.Items.Add("s" & id, nombre, 1)
                    _arr3.Add(New CLocal(id))
                Else
                    MsgBox("El local ya fue añadido", MsgBoxStyle.Information)
                End If
            Case Eproc_contrato.list_conarrnatural
                Dim nombres As String = dgv1.SelectedRows(0).Cells(1).Value
                Dim apellidos As String = dgv1.SelectedRows(0).Cells(2).Value
                If (lv1.Items.IndexOfKey("s" & id) < 0) Then
                    lv1.Items.Add("s" & id, nombres & " " & apellidos, 0)
                    _arr1.Add(New CPNatural(id))
                Else
                    MsgBox("La persona ya fue añadida", MsgBoxStyle.Information)
                End If
            Case Eproc_contrato.list_conarrjuridico
                Dim razonsocial As String = dgv1.SelectedRows(0).Cells(1).Value
                If (lv1.Items.IndexOfKey("s" & id) < 0) Then
                    lv1.Items.Add("s" & id, razonsocial, 2)
                    _arr2.Add(New CPJuridica(id))
                Else
                    MsgBox("La persona ya fue añadida", MsgBoxStyle.Information)
                End If
        End Select
    End Sub
    Private Sub tsbremover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbremover.Click
        Dim i As ListViewItem
        Select Case _proc
            Case Eproc_contrato.list_conarrnatural
                For Each i In lv1.SelectedItems
                    _arr1.RemoveAt(i.Index)
                    i.Remove()
                Next
            Case Eproc_contrato.list_conarrjuridico
                For Each i In lv1.SelectedItems
                    _arr2.RemoveAt(i.Index)
                    i.Remove()
                Next
            Case Eproc_contrato.list_loccontrato
                For Each i In lv1.SelectedItems
                    _arr3.RemoveAt(i.Index)
                    i.Remove()
                Next
        End Select
    End Sub
    Private Sub lv1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        tsbremover_Click(sender, e)
    End Sub
    Private Sub lv1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyData = Keys.Delete) Then
            tsbremover_Click(sender, Nothing)
        End If
    End Sub
    Private Sub tsbrefrescar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsbrefrescar.Click
        Dim bd As New BaseDato(general.server, general.usuario, general.password)
        Select Case _proc
            Case Eproc_contrato.list_conarrjuridico
                dgv1.DataSource = bd.procedimiento("list_perjuridica")
            Case Eproc_contrato.list_conarrnatural
                dgv1.DataSource = bd.procedimiento("list_pernatural")
            Case Eproc_contrato.list_loccontrato
                dgv1.DataSource = bd.procedimiento("list_local")
        End Select
    End Sub

    Private Sub lv1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub lv1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub lv1_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub
End Class