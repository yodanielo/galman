<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_persona
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.spc1 = New System.Windows.Forms.SplitContainer
        Me.DataGrid1 = New System.Windows.Forms.DataGridView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.propiedades = New System.Windows.Forms.PropertyGrid
        Me.tool = New System.Windows.Forms.ToolStrip
        Me.btn_nuevo = New System.Windows.Forms.ToolStripButton
        Me.btn_guardar = New System.Windows.Forms.ToolStripButton
        Me.tsbcancelar = New System.Windows.Forms.ToolStripButton
        Me.tsbpropiedades = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbbuscar = New System.Windows.Forms.ToolStripLabel
        Me.tstbuscar = New System.Windows.Forms.ToolStripTextBox
        Me.toolocal = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSplitButton
        Me.tsbtalleres = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbalmacenes = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbvitrinas = New System.Windows.Forms.ToolStripMenuItem
        Me.tsboficinas = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbotros = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbtiendas = New System.Windows.Forms.ToolStripMenuItem
        Me.toolcontrato = New System.Windows.Forms.ToolStrip
        Me.tsbrescindir = New System.Windows.Forms.ToolStripButton
        Me.tsbmantenimiento = New System.Windows.Forms.ToolStripButton
        Me.tsbmercedconductiva = New System.Windows.Forms.ToolStripButton
        Me.tsbimprimircontrato = New System.Windows.Forms.ToolStripButton
        Me.Toolpersona = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripSplitButton
        Me.charrendatario = New System.Windows.Forms.ToolStripMenuItem
        Me.chcontratista = New System.Windows.Forms.ToolStripMenuItem
        Me.chempleado = New System.Windows.Forms.ToolStripMenuItem
        Me.tsbplanilla = New System.Windows.Forms.ToolStripButton
        Me.tsbcontratista = New System.Windows.Forms.ToolStripButton
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.spc1.Panel1.SuspendLayout()
        Me.spc1.Panel2.SuspendLayout()
        Me.spc1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tool.SuspendLayout()
        Me.toolocal.SuspendLayout()
        Me.toolcontrato.SuspendLayout()
        Me.Toolpersona.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.spc1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(688, 342)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(688, 459)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.tool)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolocal)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.toolcontrato)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.Toolpersona)
        '
        'spc1
        '
        Me.spc1.BackColor = System.Drawing.Color.White
        Me.spc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.spc1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spc1.Location = New System.Drawing.Point(0, 0)
        Me.spc1.Name = "spc1"
        '
        'spc1.Panel1
        '
        Me.spc1.Panel1.Controls.Add(Me.DataGrid1)
        Me.spc1.Panel1.Controls.Add(Me.Splitter1)
        '
        'spc1.Panel2
        '
        Me.spc1.Panel2.Controls.Add(Me.propiedades)
        Me.spc1.Panel2Collapsed = True
        Me.spc1.Size = New System.Drawing.Size(688, 342)
        Me.spc1.SplitterDistance = 447
        Me.spc1.TabIndex = 0
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowUserToAddRows = False
        Me.DataGrid1.AllowUserToDeleteRows = False
        Me.DataGrid1.AllowUserToOrderColumns = True
        Me.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGrid1.Location = New System.Drawing.Point(3, 0)
        Me.DataGrid1.MultiSelect = False
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(683, 340)
        Me.DataGrid1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 340)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'propiedades
        '
        Me.propiedades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.propiedades.Location = New System.Drawing.Point(0, 0)
        Me.propiedades.Name = "propiedades"
        Me.propiedades.Size = New System.Drawing.Size(94, 98)
        Me.propiedades.TabIndex = 0
        '
        'tool
        '
        Me.tool.Dock = System.Windows.Forms.DockStyle.None
        Me.tool.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tool.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btn_nuevo, Me.btn_guardar, Me.tsbcancelar, Me.tsbpropiedades, Me.ToolStripSeparator1, Me.tsbbuscar, Me.tstbuscar})
        Me.tool.Location = New System.Drawing.Point(3, 0)
        Me.tool.Name = "tool"
        Me.tool.Size = New System.Drawing.Size(307, 39)
        Me.tool.TabIndex = 1
        '
        'btn_nuevo
        '
        Me.btn_nuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_nuevo.Image = Global.galman.My.Resources.Resources.nuevo
        Me.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(36, 36)
        Me.btn_nuevo.Text = "&Nuevo"
        '
        'btn_guardar
        '
        Me.btn_guardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = Global.galman.My.Resources.Resources.disks
        Me.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(36, 36)
        Me.btn_guardar.Text = "&Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsbcancelar
        '
        Me.tsbcancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbcancelar.Image = Global.galman.My.Resources.Resources.Crystal_128_reload
        Me.tsbcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbcancelar.Name = "tsbcancelar"
        Me.tsbcancelar.Size = New System.Drawing.Size(36, 36)
        Me.tsbcancelar.Text = "Cancelar"
        '
        'tsbpropiedades
        '
        Me.tsbpropiedades.Checked = True
        Me.tsbpropiedades.CheckOnClick = True
        Me.tsbpropiedades.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbpropiedades.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbpropiedades.Enabled = False
        Me.tsbpropiedades.Image = Global.galman.My.Resources.Resources.propiedades
        Me.tsbpropiedades.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbpropiedades.Name = "tsbpropiedades"
        Me.tsbpropiedades.Size = New System.Drawing.Size(36, 36)
        Me.tsbpropiedades.Text = "Propiedades"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbbuscar
        '
        Me.tsbbuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbbuscar.Image = Global.galman.My.Resources.Resources.gnome_searchtool
        Me.tsbbuscar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbbuscar.Name = "tsbbuscar"
        Me.tsbbuscar.Size = New System.Drawing.Size(43, 36)
        Me.tsbbuscar.Text = "Buscar:"
        '
        'tstbuscar
        '
        Me.tstbuscar.Name = "tstbuscar"
        Me.tstbuscar.Size = New System.Drawing.Size(100, 39)
        '
        'toolocal
        '
        Me.toolocal.Dock = System.Windows.Forms.DockStyle.None
        Me.toolocal.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolocal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.toolocal.Location = New System.Drawing.Point(3, 39)
        Me.toolocal.Name = "toolocal"
        Me.toolocal.Size = New System.Drawing.Size(60, 39)
        Me.toolocal.TabIndex = 3
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtalleres, Me.tsbalmacenes, Me.tsbvitrinas, Me.tsboficinas, Me.tsbotros, Me.tsbtiendas})
        Me.ToolStripButton1.Image = Global.galman.My.Resources.Resources.gnome_home
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(48, 36)
        Me.ToolStripButton1.Text = "Filtrar locales"
        '
        'tsbtalleres
        '
        Me.tsbtalleres.Checked = True
        Me.tsbtalleres.CheckOnClick = True
        Me.tsbtalleres.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbtalleres.Name = "tsbtalleres"
        Me.tsbtalleres.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.tsbtalleres.Size = New System.Drawing.Size(155, 22)
        Me.tsbtalleres.Text = "Talleres"
        '
        'tsbalmacenes
        '
        Me.tsbalmacenes.Checked = True
        Me.tsbalmacenes.CheckOnClick = True
        Me.tsbalmacenes.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbalmacenes.Name = "tsbalmacenes"
        Me.tsbalmacenes.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.tsbalmacenes.Size = New System.Drawing.Size(155, 22)
        Me.tsbalmacenes.Text = "Almecenes"
        '
        'tsbvitrinas
        '
        Me.tsbvitrinas.Checked = True
        Me.tsbvitrinas.CheckOnClick = True
        Me.tsbvitrinas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbvitrinas.Name = "tsbvitrinas"
        Me.tsbvitrinas.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.tsbvitrinas.Size = New System.Drawing.Size(155, 22)
        Me.tsbvitrinas.Text = "Vitrinas"
        '
        'tsboficinas
        '
        Me.tsboficinas.Checked = True
        Me.tsboficinas.CheckOnClick = True
        Me.tsboficinas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsboficinas.Name = "tsboficinas"
        Me.tsboficinas.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.tsboficinas.Size = New System.Drawing.Size(155, 22)
        Me.tsboficinas.Text = "Oficinas"
        '
        'tsbotros
        '
        Me.tsbotros.Checked = True
        Me.tsbotros.CheckOnClick = True
        Me.tsbotros.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbotros.Name = "tsbotros"
        Me.tsbotros.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.tsbotros.Size = New System.Drawing.Size(155, 22)
        Me.tsbotros.Text = "Otros"
        '
        'tsbtiendas
        '
        Me.tsbtiendas.Checked = True
        Me.tsbtiendas.CheckOnClick = True
        Me.tsbtiendas.CheckState = System.Windows.Forms.CheckState.Checked
        Me.tsbtiendas.Name = "tsbtiendas"
        Me.tsbtiendas.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.tsbtiendas.Size = New System.Drawing.Size(155, 22)
        Me.tsbtiendas.Text = "Tiendas"
        '
        'toolcontrato
        '
        Me.toolcontrato.Dock = System.Windows.Forms.DockStyle.None
        Me.toolcontrato.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.toolcontrato.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbrescindir, Me.tsbmantenimiento, Me.tsbmercedconductiva, Me.tsbimprimircontrato})
        Me.toolcontrato.Location = New System.Drawing.Point(63, 39)
        Me.toolcontrato.Name = "toolcontrato"
        Me.toolcontrato.Size = New System.Drawing.Size(156, 39)
        Me.toolcontrato.TabIndex = 0
        '
        'tsbrescindir
        '
        Me.tsbrescindir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbrescindir.Image = Global.galman.My.Resources.Resources.eliminar
        Me.tsbrescindir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbrescindir.Name = "tsbrescindir"
        Me.tsbrescindir.Size = New System.Drawing.Size(36, 36)
        Me.tsbrescindir.Text = "&Rescindir Contrato"
        '
        'tsbmantenimiento
        '
        Me.tsbmantenimiento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbmantenimiento.Image = Global.galman.My.Resources.Resources.paga
        Me.tsbmantenimiento.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbmantenimiento.Name = "tsbmantenimiento"
        Me.tsbmantenimiento.Size = New System.Drawing.Size(36, 36)
        Me.tsbmantenimiento.Text = "Cobro de &mantenimiento"
        '
        'tsbmercedconductiva
        '
        Me.tsbmercedconductiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbmercedconductiva.Image = Global.galman.My.Resources.Resources.dollar
        Me.tsbmercedconductiva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbmercedconductiva.Name = "tsbmercedconductiva"
        Me.tsbmercedconductiva.Size = New System.Drawing.Size(36, 36)
        Me.tsbmercedconductiva.Text = "Cobro de merced &conductiva"
        '
        'tsbimprimircontrato
        '
        Me.tsbimprimircontrato.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbimprimircontrato.Image = Global.galman.My.Resources.Resources.Crystal_postscript
        Me.tsbimprimircontrato.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbimprimircontrato.Name = "tsbimprimircontrato"
        Me.tsbimprimircontrato.Size = New System.Drawing.Size(36, 36)
        Me.tsbimprimircontrato.Text = "Im&primir contrato"
        '
        'Toolpersona
        '
        Me.Toolpersona.Dock = System.Windows.Forms.DockStyle.None
        Me.Toolpersona.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.Toolpersona.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.tsbplanilla, Me.tsbcontratista})
        Me.Toolpersona.Location = New System.Drawing.Point(18, 78)
        Me.Toolpersona.Name = "Toolpersona"
        Me.Toolpersona.Size = New System.Drawing.Size(132, 39)
        Me.Toolpersona.TabIndex = 2
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.charrendatario, Me.chcontratista, Me.chempleado})
        Me.ToolStripButton2.Image = Global.galman.My.Resources.Resources.Nuvola_apps_edu_languages
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(48, 36)
        Me.ToolStripButton2.Text = "Filtrar Personas"
        '
        'charrendatario
        '
        Me.charrendatario.Checked = True
        Me.charrendatario.CheckOnClick = True
        Me.charrendatario.CheckState = System.Windows.Forms.CheckState.Checked
        Me.charrendatario.Name = "charrendatario"
        Me.charrendatario.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.charrendatario.Size = New System.Drawing.Size(170, 22)
        Me.charrendatario.Text = "Arrendatarios"
        '
        'chcontratista
        '
        Me.chcontratista.Checked = True
        Me.chcontratista.CheckOnClick = True
        Me.chcontratista.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chcontratista.Name = "chcontratista"
        Me.chcontratista.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.chcontratista.Size = New System.Drawing.Size(170, 22)
        Me.chcontratista.Text = "Contratistas"
        '
        'chempleado
        '
        Me.chempleado.Checked = True
        Me.chempleado.CheckOnClick = True
        Me.chempleado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chempleado.Name = "chempleado"
        Me.chempleado.ShortcutKeys = System.Windows.Forms.Keys.F8
        Me.chempleado.Size = New System.Drawing.Size(170, 22)
        Me.chempleado.Text = "Empleados"
        '
        'tsbplanilla
        '
        Me.tsbplanilla.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbplanilla.Image = Global.galman.My.Resources.Resources.Contact_new
        Me.tsbplanilla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbplanilla.Name = "tsbplanilla"
        Me.tsbplanilla.Size = New System.Drawing.Size(36, 36)
        Me.tsbplanilla.Text = "Contratos en planilla"
        '
        'tsbcontratista
        '
        Me.tsbcontratista.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbcontratista.Image = Global.galman.My.Resources.Resources.User_icon
        Me.tsbcontratista.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbcontratista.Name = "tsbcontratista"
        Me.tsbcontratista.Size = New System.Drawing.Size(36, 36)
        Me.tsbcontratista.Text = "Contratos de contratista"
        '
        'frm_persona
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(688, 459)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = Global.galman.My.Resources.Resources.logo_galman
        Me.Name = "frm_persona"
        Me.Text = "listado de personas"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.spc1.Panel1.ResumeLayout(False)
        Me.spc1.Panel2.ResumeLayout(False)
        Me.spc1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tool.ResumeLayout(False)
        Me.tool.PerformLayout()
        Me.toolocal.ResumeLayout(False)
        Me.toolocal.PerformLayout()
        Me.toolcontrato.ResumeLayout(False)
        Me.toolcontrato.PerformLayout()
        Me.Toolpersona.ResumeLayout(False)
        Me.Toolpersona.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Protected WithEvents spc1 As System.Windows.Forms.SplitContainer
    Protected WithEvents tool As System.Windows.Forms.ToolStrip
    Protected WithEvents Splitter1 As System.Windows.Forms.Splitter
    Protected WithEvents propiedades As System.Windows.Forms.PropertyGrid
    Protected WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Protected WithEvents Toolpersona As System.Windows.Forms.ToolStrip
    Protected WithEvents btn_guardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGridView
    Protected WithEvents toolcontrato As System.Windows.Forms.ToolStrip
    Protected WithEvents tsbrescindir As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolocal As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbmantenimiento As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbmercedconductiva As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbimprimircontrato As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents tsbtalleres As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbalmacenes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbvitrinas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsboficinas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbotros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents charrendatario As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chcontratista As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents chempleado As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsbplanilla As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbcontratista As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbtiendas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tstbuscar As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents tsbbuscar As System.Windows.Forms.ToolStripLabel
    Friend WithEvents tsbpropiedades As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbcancelar As System.Windows.Forms.ToolStripButton

End Class
