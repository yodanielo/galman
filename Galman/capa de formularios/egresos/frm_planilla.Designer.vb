<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_planilla
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
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.dgv2 = New System.Windows.Forms.DataGridView
        Me.btnpagar = New System.Windows.Forms.Button
        Me.dtp3 = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtorden = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtsemana = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtidpago = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtaño = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtmes = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.txtsueldo = New System.Windows.Forms.TextBox
        Me.btncontratar = New System.Windows.Forms.Button
        Me.dtp2 = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.txtpersona = New System.Windows.Forms.ToolStripStatusLabel
        Me.TabPage2.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(564, 358)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Efectuar remuneraciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Splitter2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.dgv2)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.btnpagar)
        Me.SplitContainer2.Panel2.Controls.Add(Me.dtp3)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtorden)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label10)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtmonto)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtsemana)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtidpago)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtaño)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txtmes)
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer2.Size = New System.Drawing.Size(558, 352)
        Me.SplitContainer2.SplitterDistance = 349
        Me.SplitContainer2.TabIndex = 0
        '
        'Splitter2
        '
        Me.Splitter2.Location = New System.Drawing.Point(0, 0)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 352)
        Me.Splitter2.TabIndex = 0
        Me.Splitter2.TabStop = False
        '
        'dgv2
        '
        Me.dgv2.AllowUserToAddRows = False
        Me.dgv2.AllowUserToDeleteRows = False
        Me.dgv2.AllowUserToOrderColumns = True
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv2.Location = New System.Drawing.Point(0, 0)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.ReadOnly = True
        Me.dgv2.Size = New System.Drawing.Size(349, 352)
        Me.dgv2.TabIndex = 0
        '
        'btnpagar
        '
        Me.btnpagar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpagar.Location = New System.Drawing.Point(88, 186)
        Me.btnpagar.Name = "btnpagar"
        Me.btnpagar.Size = New System.Drawing.Size(112, 23)
        Me.btnpagar.TabIndex = 14
        Me.btnpagar.Text = "Pagar"
        Me.btnpagar.UseVisualStyleBackColor = True
        '
        'dtp3
        '
        Me.dtp3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp3.Enabled = False
        Me.dtp3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp3.Location = New System.Drawing.Point(88, 160)
        Me.dtp3.Name = "dtp3"
        Me.dtp3.Size = New System.Drawing.Size(114, 20)
        Me.dtp3.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(0, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha de pago:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(2, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 8
        '
        'txtorden
        '
        Me.txtorden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtorden.Location = New System.Drawing.Point(88, 108)
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Size = New System.Drawing.Size(112, 20)
        Me.txtorden.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(0, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Orden de pago:"
        '
        'txtmonto
        '
        Me.txtmonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmonto.Location = New System.Drawing.Point(88, 134)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.ReadOnly = True
        Me.txtmonto.Size = New System.Drawing.Size(112, 20)
        Me.txtmonto.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Monto:"
        '
        'txtsemana
        '
        Me.txtsemana.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsemana.Location = New System.Drawing.Point(88, 82)
        Me.txtsemana.Name = "txtsemana"
        Me.txtsemana.ReadOnly = True
        Me.txtsemana.Size = New System.Drawing.Size(112, 20)
        Me.txtsemana.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Semana:"
        '
        'txtidpago
        '
        Me.txtidpago.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidpago.Location = New System.Drawing.Point(88, 4)
        Me.txtidpago.Name = "txtidpago"
        Me.txtidpago.ReadOnly = True
        Me.txtidpago.Size = New System.Drawing.Size(112, 20)
        Me.txtidpago.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nº de pago"
        '
        'txtaño
        '
        Me.txtaño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaño.Location = New System.Drawing.Point(88, 30)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.ReadOnly = True
        Me.txtaño.Size = New System.Drawing.Size(112, 20)
        Me.txtaño.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(0, 37)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Año:"
        '
        'txtmes
        '
        Me.txtmes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmes.Location = New System.Drawing.Point(88, 56)
        Me.txtmes.Name = "txtmes"
        Me.txtmes.ReadOnly = True
        Me.txtmes.Size = New System.Drawing.Size(112, 20)
        Me.txtmes.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Mes:"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(564, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Contratos en planilla"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtsueldo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btncontratar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtp2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtp1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(558, 352)
        Me.SplitContainer1.SplitterDistance = 373
        Me.SplitContainer1.TabIndex = 1
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 0)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(370, 352)
        Me.dgv1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 352)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'txtsueldo
        '
        Me.txtsueldo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtsueldo.Location = New System.Drawing.Point(92, 64)
        Me.txtsueldo.Name = "txtsueldo"
        Me.txtsueldo.Size = New System.Drawing.Size(81, 20)
        Me.txtsueldo.TabIndex = 5
        '
        'btncontratar
        '
        Me.btncontratar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btncontratar.Location = New System.Drawing.Point(77, 90)
        Me.btncontratar.Name = "btncontratar"
        Me.btncontratar.Size = New System.Drawing.Size(96, 23)
        Me.btncontratar.TabIndex = 6
        Me.btncontratar.Text = "Agregar Contrato"
        Me.btncontratar.UseVisualStyleBackColor = True
        '
        'dtp2
        '
        Me.dtp2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp2.Location = New System.Drawing.Point(92, 38)
        Me.dtp2.Name = "dtp2"
        Me.dtp2.Size = New System.Drawing.Size(81, 20)
        Me.dtp2.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sueldo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de fin:"
        '
        'dtp1
        '
        Me.dtp1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(92, 12)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(81, 20)
        Me.dtp1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha de Inicio:"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(572, 384)
        Me.TabControl1.TabIndex = 0
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtpersona})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 387)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(572, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtpersona
        '
        Me.txtpersona.Name = "txtpersona"
        Me.txtpersona.Size = New System.Drawing.Size(111, 17)
        Me.txtpersona.Text = "ToolStripStatusLabel1"
        '
        'frm_planilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 409)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frm_planilla"
        Me.Text = "Contratos por planilla"
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.Icon = My.Resources.logo_galman
    End Sub
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents txtmes As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents txtsueldo As System.Windows.Forms.TextBox
    Friend WithEvents btncontratar As System.Windows.Forms.Button
    Friend WithEvents dtp2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btnpagar As System.Windows.Forms.Button
    Friend WithEvents dtp3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtsemana As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtpersona As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtorden As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtidpago As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
