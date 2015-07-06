Public Class Form2
#Region "botones"
    Private WithEvents x As btn_elegante
#Region "eventos botones"
    Private Sub btn_administrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_administrar.click
        elimina_menu()
        x = New btn_elegante("Persona Natural", "Administra Personas Naturales")
        x.Tag = 1
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Persona Jurídica", "Administra Personas Juridícas")
        x.Tag = 2
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Local", "Administra locales de la galería")
        x.Tag = 3
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Contrato", "Administra Contratos de Arrendamiento")
        x.Tag = 4
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
    End Sub
    Private Sub btn_egresos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_egresos.click
        elimina_menu()
        x = New btn_elegante("Otros Pagos", "Registra Otros Pagos")
        x.Tag = 16
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Tributos", "Registra el pago de Tributos")
        x.Tag = 17
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Servicios basicos", "Registra el pago de Servicios basicos")
        x.Tag = 18
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Compra", "Registra el pago de Compras")
        x.Tag = 19
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Entrega a Okanito", "Registra el desembolso a Okanito")
        x.Tag = 20
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
    End Sub
    Private Sub btn_reportes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_reportes.click
        elimina_menu()
        x = New btn_elegante("Facturación", "Muestra la facturacion obtenida en un perido de tiempo")
        x.Tag = 21
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Ingresos", "Muestra los deudores con la galería Nilo")
        x.Tag = 22
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        x = New btn_elegante("Reports por Fecha", "Muestra los reports en un intervalo de tiempo")
        x.Tag = 23
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        'x = New btn_elegante("Reports por periodo", "Muestra los reports por un periodo de tiempo")
        'x.Tag = 24
        'AddHandler x.click, AddressOf x_click
        'flp_contenido.Controls.Add(x)
    End Sub
    Private Sub btn_ayuda_click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_ayuda.click
        elimina_menu()
        x = New btn_elegante("Acerca de...", "")
        x.Tag = 25
        AddHandler x.click, AddressOf x_click
        flp_contenido.Controls.Add(x)
        'x = New btn_elegante("Contenido", "")
        'x.Tag = 26
        'AddHandler x.click, AddressOf x_click
        'flp_contenido.Controls.Add(x)
    End Sub
#End Region
    Private Sub elimina_menu()
        Dim a, b As Integer
        On Error Resume Next
        Do While flp_contenido.Controls.Count > 0
            flp_contenido.Controls(flp_contenido.Controls.Count - 1).Dispose()
        Loop
    End Sub
#End Region
    Private Sub frm_principal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'estas lineas deben habilitarse antes de crear el proyecto
        Dim a As New frm_login
        Dim b As New frm_inicio
        Dim c As New frm_vencidos
        b.ShowDialog()
        a.ShowDialog()
        c.ShowDialog()
        general.server = "(local)"
        general.usuario = "sa"
    End Sub
    Private Sub x_click(ByVal sender As Object, ByVal e As System.EventArgs) ' Handles x.click
        Dim ejecutas As Boolean = False
        Dim y As New Form
        Select Case sender.tag
            Case 1
                y = New frm_persona(Eprocedimiento.list_pernatural)
            Case 2
                y = New frm_persona(Eprocedimiento.list_perjuridica)
            Case 3
                y = New frm_persona(Eprocedimiento.list_local)
            Case 4
                y = New frm_persona(Eprocedimiento.list_conarrendamientos)
            Case 16
                y = New frm_otropago
            Case 17
                y = New frm_tributos
            Case 18
                y = New frm_servicio
            Case 19
                y = New frm_compras
            Case 20
                y = New frm_entregaokanito
            Case 21
                y = New frm_interfecha(Ereporte.rptfacturacion)
            Case 22
                y = New frm_interfecha(Ereporte.rptingresos)
            Case 23
                y = New frm_interfecha(Ereporte.rptreport_fecha)
            Case 24
                y = New frm_interfecha(Ereporte.rptreport_fecha)
            Case 25
                y = New frm_acercade()
            Case 26
                'y = New frm_contenito()
        End Select
        y.Show()
    End Sub
End Class