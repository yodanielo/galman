<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_contratista
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.txtnombre = New System.Windows.Forms.ToolStripStatusLabel
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.txtorden = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnpagar = New System.Windows.Forms.Button
        Me.btncontratar = New System.Windows.Forms.Button
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtconcepto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtcontrato = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.StatusStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.txtnombre})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 369)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(613, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'txtnombre
        '
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(57, 17)
        Me.txtnombre.Text = "txtnombre"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtorden)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnpagar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btncontratar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmonto)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtconcepto)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtcontrato)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(613, 369)
        Me.SplitContainer1.SplitterDistance = 389
        Me.SplitContainer1.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 367)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AllowUserToOrderColumns = True
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(0, 0)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(387, 367)
        Me.dgv1.TabIndex = 0
        '
        'txtorden
        '
        Me.txtorden.Location = New System.Drawing.Point(86, 90)
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Size = New System.Drawing.Size(121, 20)
        Me.txtorden.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(1, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Orden de pago:"
        '
        'btnpagar
        '
        Me.btnpagar.Location = New System.Drawing.Point(112, 116)
        Me.btnpagar.Name = "btnpagar"
        Me.btnpagar.Size = New System.Drawing.Size(95, 23)
        Me.btnpagar.TabIndex = 9
        Me.btnpagar.Text = "Pagar"
        Me.btnpagar.UseVisualStyleBackColor = True
        '
        'btncontratar
        '
        Me.btncontratar.Location = New System.Drawing.Point(5, 116)
        Me.btncontratar.Name = "btncontratar"
        Me.btncontratar.Size = New System.Drawing.Size(95, 23)
        Me.btncontratar.TabIndex = 8
        Me.btncontratar.Text = "Contratar"
        Me.btncontratar.UseVisualStyleBackColor = True
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(87, 64)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(121, 20)
        Me.txtmonto.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(2, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Monto:"
        '
        'txtconcepto
        '
        Me.txtconcepto.Location = New System.Drawing.Point(87, 38)
        Me.txtconcepto.Name = "txtconcepto"
        Me.txtconcepto.Size = New System.Drawing.Size(121, 20)
        Me.txtconcepto.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(2, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Concepto:"
        '
        'txtcontrato
        '
        Me.txtcontrato.Location = New System.Drawing.Point(87, 12)
        Me.txtcontrato.Name = "txtcontrato"
        Me.txtcontrato.ReadOnly = True
        Me.txtcontrato.Size = New System.Drawing.Size(121, 20)
        Me.txtcontrato.TabIndex = 1
        Me.txtcontrato.Text = "-1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(2, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº de contrato:"
        '
        'frm_contratista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 391)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "frm_contratista"
        Me.Text = "Contratos de contratista"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.Icon = My.Resources.logo_galman
    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents txtnombre As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtcontrato As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtconcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnpagar As System.Windows.Forms.Button
    Friend WithEvents btncontratar As System.Windows.Forms.Button
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents txtorden As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
