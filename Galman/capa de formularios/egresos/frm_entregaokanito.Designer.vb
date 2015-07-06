<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_entregaokanito
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.dgv1 = New System.Windows.Forms.DataGridView
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.btnpagar = New System.Windows.Forms.Button
        Me.dtp1 = New System.Windows.Forms.DateTimePicker
        Me.cbosocio = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtdescripcion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtorden = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtidpago = New System.Windows.Forms.TextBox
        Me.labeln = New System.Windows.Forms.Label
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgv1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Splitter1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnnuevo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnpagar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtp1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbosocio)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtdescripcion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtorden)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtidpago)
        Me.SplitContainer1.Panel2.Controls.Add(Me.labeln)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmonto)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(581, 394)
        Me.SplitContainer1.SplitterDistance = 361
        Me.SplitContainer1.TabIndex = 0
        '
        'dgv1
        '
        Me.dgv1.AllowUserToAddRows = False
        Me.dgv1.AllowUserToDeleteRows = False
        Me.dgv1.AllowUserToOrderColumns = True
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv1.Location = New System.Drawing.Point(3, 0)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.ReadOnly = True
        Me.dgv1.Size = New System.Drawing.Size(358, 394)
        Me.dgv1.TabIndex = 0
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 394)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(26, 196)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(86, 23)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnpagar
        '
        Me.btnpagar.Location = New System.Drawing.Point(118, 196)
        Me.btnpagar.Name = "btnpagar"
        Me.btnpagar.Size = New System.Drawing.Size(86, 23)
        Me.btnpagar.TabIndex = 13
        Me.btnpagar.Text = "Pagar"
        Me.btnpagar.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp1.Location = New System.Drawing.Point(85, 170)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(119, 20)
        Me.dtp1.TabIndex = 11
        '
        'cbosocio
        '
        Me.cbosocio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosocio.FormattingEnabled = True
        Me.cbosocio.Items.AddRange(New Object() {"daniel pomalaza", "alexis damian fukurama"})
        Me.cbosocio.Location = New System.Drawing.Point(85, 39)
        Me.cbosocio.Name = "cbosocio"
        Me.cbosocio.Size = New System.Drawing.Size(119, 21)
        Me.cbosocio.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha:"
        '
        'txtdescripcion
        '
        Me.txtdescripcion.Location = New System.Drawing.Point(85, 66)
        Me.txtdescripcion.Multiline = True
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(119, 46)
        Me.txtdescripcion.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'txtorden
        '
        Me.txtorden.Location = New System.Drawing.Point(85, 144)
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Size = New System.Drawing.Size(119, 20)
        Me.txtorden.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Orden de pago:"
        '
        'txtidpago
        '
        Me.txtidpago.Location = New System.Drawing.Point(85, 13)
        Me.txtidpago.Name = "txtidpago"
        Me.txtidpago.ReadOnly = True
        Me.txtidpago.Size = New System.Drawing.Size(119, 20)
        Me.txtidpago.TabIndex = 1
        Me.txtidpago.Text = "-1"
        '
        'labeln
        '
        Me.labeln.AutoSize = True
        Me.labeln.Location = New System.Drawing.Point(3, 20)
        Me.labeln.Name = "labeln"
        Me.labeln.Size = New System.Drawing.Size(69, 13)
        Me.labeln.TabIndex = 0
        Me.labeln.Text = "Nro de pago:"
        '
        'txtmonto
        '
        Me.txtmonto.Location = New System.Drawing.Point(85, 118)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(119, 20)
        Me.txtmonto.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Monto:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Socio:"
        '
        'frm_entregaokanito
        '
        Me.AcceptButton = Me.btnpagar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 394)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "frm_entregaokanito"
        Me.Text = "Entrega a OKANITO"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.Icon = My.Resources.logo_galman
    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnpagar As System.Windows.Forms.Button
    Friend WithEvents dtp1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbosocio As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdescripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtorden As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents txtidpago As System.Windows.Forms.TextBox
    Friend WithEvents labeln As System.Windows.Forms.Label
End Class
