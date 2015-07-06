<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_loccontrato
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_loccontrato))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.lv1 = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbaceptar = New System.Windows.Forms.ToolStripButton
        Me.tsbcancelar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbagregar = New System.Windows.Forms.ToolStripButton
        Me.tsbremover = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsbrefrescar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.RightToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(558, 452)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        '
        'ToolStripContainer1.RightToolStripPanel
        '
        Me.ToolStripContainer1.RightToolStripPanel.Controls.Add(Me.ToolStrip1)
        Me.ToolStripContainer1.Size = New System.Drawing.Size(587, 477)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lv1)
        Me.SplitContainer1.Size = New System.Drawing.Size(558, 452)
        Me.SplitContainer1.SplitterDistance = 178
        Me.SplitContainer1.TabIndex = 1
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(0, 0)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv1.Size = New System.Drawing.Size(558, 178)
        Me.dgv1.TabIndex = 0
        '
        'lv1
        '
        Me.lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lv1.LargeImageList = Me.ImageList1
        Me.lv1.Location = New System.Drawing.Point(0, 0)
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(558, 270)
        Me.lv1.SmallImageList = Me.ImageList1
        Me.lv1.TabIndex = 0
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombre"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "arrnatural")
        Me.ImageList1.Images.SetKeyName(1, "local")
        Me.ImageList1.Images.SetKeyName(2, "arrjuridico")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbaceptar, Me.tsbcancelar, Me.ToolStripSeparator1, Me.tsbagregar, Me.tsbremover, Me.ToolStripButton1, Me.tsbrefrescar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(29, 178)
        Me.ToolStrip1.TabIndex = 0
        '
        'tsbaceptar
        '
        Me.tsbaceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbaceptar.Image = Global.galman.My.Resources.Resources.Crystal_Clear_action_apply
        Me.tsbaceptar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbaceptar.Name = "tsbaceptar"
        Me.tsbaceptar.Size = New System.Drawing.Size(27, 28)
        Me.tsbaceptar.Text = "&Aceptar"
        '
        'tsbcancelar
        '
        Me.tsbcancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbcancelar.Image = Global.galman.My.Resources.Resources.Crystal_Clear_action_button_cancel
        Me.tsbcancelar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbcancelar.Name = "tsbcancelar"
        Me.tsbcancelar.Size = New System.Drawing.Size(27, 28)
        Me.tsbcancelar.Text = "&Cancelar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(27, 6)
        '
        'tsbagregar
        '
        Me.tsbagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbagregar.Image = Global.galman.My.Resources.Resources.Crystal_Clear_action_edit_add
        Me.tsbagregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbagregar.Name = "tsbagregar"
        Me.tsbagregar.Size = New System.Drawing.Size(27, 28)
        Me.tsbagregar.Text = "&Agregar"
        '
        'tsbremover
        '
        Me.tsbremover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbremover.Image = Global.galman.My.Resources.Resources.Crystal_Clear_action_edit_remove
        Me.tsbremover.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbremover.Name = "tsbremover"
        Me.tsbremover.Size = New System.Drawing.Size(27, 28)
        Me.tsbremover.Text = "&Remover"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(27, 6)
        '
        'tsbrefrescar
        '
        Me.tsbrefrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbrefrescar.Image = Global.galman.My.Resources.Resources.Crystal_128_reload
        Me.tsbrefrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbrefrescar.Name = "tsbrefrescar"
        Me.tsbrefrescar.Size = New System.Drawing.Size(27, 28)
        Me.tsbrefrescar.Text = "ToolStripButton2"
        '
        'frm_loccontrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 477)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = Global.galman.My.Resources.Resources.logo_galman
        Me.Name = "frm_loccontrato"
        Me.Text = "frm_loccontrato"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.RightToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.RightToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbaceptar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbcancelar As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbagregar As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsbremover As System.Windows.Forms.ToolStripButton
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsbrefrescar As System.Windows.Forms.ToolStripButton
    Friend WithEvents lv1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
End Class
