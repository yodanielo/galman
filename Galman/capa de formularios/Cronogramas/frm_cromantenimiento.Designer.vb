<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cromantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cromantenimiento))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.DataGridView1 = New System.Windows.Forms.DataGrid
        Me.chkcobrar = New System.Windows.Forms.CheckBox
        Me.txtacuenta = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtdebe = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtpagado = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtdeudatotal = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtmora = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtsemana = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtrango = New System.Windows.Forms.TextBox
        Me.txtcontrato = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.tsbguardar = New System.Windows.Forms.ToolStripButton
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(751, 420)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(751, 451)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.chkcobrar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtacuenta)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtdebe)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtpagado)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtdeudatotal)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmora)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmonto)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtsemana)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtrango)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtcontrato)
        Me.SplitContainer1.Size = New System.Drawing.Size(751, 420)
        Me.SplitContainer1.SplitterDistance = 538
        Me.SplitContainer1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 420)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AlternatingBackColor = System.Drawing.Color.GhostWhite
        Me.DataGridView1.BackColor = System.Drawing.Color.GhostWhite
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Lavender
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.DataGridView1.CaptionForeColor = System.Drawing.Color.White
        Me.DataGridView1.DataMember = ""
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.FlatMode = True
        Me.DataGridView1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.DataGridView1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridView1.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.DataGridView1.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.DataGridView1.HeaderFont = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.DataGridView1.HeaderForeColor = System.Drawing.Color.Lavender
        Me.DataGridView1.LinkColor = System.Drawing.Color.Teal
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.DataGridView1.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.DataGridView1.SelectionBackColor = System.Drawing.Color.Teal
        Me.DataGridView1.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.DataGridView1.Size = New System.Drawing.Size(538, 420)
        Me.DataGridView1.TabIndex = 0
        '
        'chkcobrar
        '
        Me.chkcobrar.AutoSize = True
        Me.chkcobrar.Checked = True
        Me.chkcobrar.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkcobrar.Location = New System.Drawing.Point(6, 237)
        Me.chkcobrar.Name = "chkcobrar"
        Me.chkcobrar.Size = New System.Drawing.Size(101, 17)
        Me.chkcobrar.TabIndex = 16
        Me.chkcobrar.Text = "Perdon de mora"
        Me.chkcobrar.UseVisualStyleBackColor = True
        '
        'txtacuenta
        '
        Me.txtacuenta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtacuenta.Location = New System.Drawing.Point(77, 211)
        Me.txtacuenta.Name = "txtacuenta"
        Me.txtacuenta.Size = New System.Drawing.Size(120, 20)
        Me.txtacuenta.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(3)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "A cuenta:"
        '
        'txtdebe
        '
        Me.txtdebe.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdebe.Location = New System.Drawing.Point(77, 185)
        Me.txtdebe.Name = "txtdebe"
        Me.txtdebe.ReadOnly = True
        Me.txtdebe.Size = New System.Drawing.Size(120, 20)
        Me.txtdebe.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(3)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Debe:"
        '
        'txtpagado
        '
        Me.txtpagado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtpagado.Location = New System.Drawing.Point(77, 159)
        Me.txtpagado.Name = "txtpagado"
        Me.txtpagado.ReadOnly = True
        Me.txtpagado.Size = New System.Drawing.Size(120, 20)
        Me.txtpagado.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 166)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Pagado:"
        '
        'txtdeudatotal
        '
        Me.txtdeudatotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtdeudatotal.Location = New System.Drawing.Point(77, 133)
        Me.txtdeudatotal.Name = "txtdeudatotal"
        Me.txtdeudatotal.ReadOnly = True
        Me.txtdeudatotal.Size = New System.Drawing.Size(120, 20)
        Me.txtdeudatotal.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 140)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Deuda total:"
        '
        'txtmora
        '
        Me.txtmora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmora.Location = New System.Drawing.Point(77, 107)
        Me.txtmora.Name = "txtmora"
        Me.txtmora.ReadOnly = True
        Me.txtmora.Size = New System.Drawing.Size(120, 20)
        Me.txtmora.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Mora:"
        '
        'txtmonto
        '
        Me.txtmonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmonto.Location = New System.Drawing.Point(77, 81)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.ReadOnly = True
        Me.txtmonto.Size = New System.Drawing.Size(120, 20)
        Me.txtmonto.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Monto:"
        '
        'txtsemana
        '
        Me.txtsemana.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsemana.Location = New System.Drawing.Point(77, 55)
        Me.txtsemana.Name = "txtsemana"
        Me.txtsemana.ReadOnly = True
        Me.txtsemana.Size = New System.Drawing.Size(120, 20)
        Me.txtsemana.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 62)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Semana:"
        '
        'txtrango
        '
        Me.txtrango.Location = New System.Drawing.Point(2, 29)
        Me.txtrango.Name = "txtrango"
        Me.txtrango.ReadOnly = True
        Me.txtrango.Size = New System.Drawing.Size(203, 20)
        Me.txtrango.TabIndex = 1
        '
        'txtcontrato
        '
        Me.txtcontrato.Location = New System.Drawing.Point(3, 3)
        Me.txtcontrato.Name = "txtcontrato"
        Me.txtcontrato.ReadOnly = True
        Me.txtcontrato.Size = New System.Drawing.Size(203, 20)
        Me.txtcontrato.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbguardar})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(40, 31)
        Me.ToolStrip1.TabIndex = 0
        '
        'tsbguardar
        '
        Me.tsbguardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbguardar.Image = CType(resources.GetObject("tsbguardar.Image"), System.Drawing.Image)
        Me.tsbguardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbguardar.Name = "tsbguardar"
        Me.tsbguardar.Size = New System.Drawing.Size(28, 28)
        Me.tsbguardar.Text = "Pagar e imprimir"
        '
        'frm_cromantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 451)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = Global.galman.My.Resources.Resources.logo_galman
        Me.Name = "frm_cromantenimiento"
        Me.Text = "Cobro de mantenimiento"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsbguardar As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtsemana As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtrango As System.Windows.Forms.TextBox
    Friend WithEvents txtcontrato As System.Windows.Forms.TextBox
    Friend WithEvents chkcobrar As System.Windows.Forms.CheckBox
    Friend WithEvents txtacuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdebe As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpagado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdeudatotal As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtmora As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
