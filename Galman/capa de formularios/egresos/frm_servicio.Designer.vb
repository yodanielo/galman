<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_servicio
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
        Me.txtmes = New System.Windows.Forms.ComboBox
        Me.txttipo = New System.Windows.Forms.ComboBox
        Me.cbopagador = New System.Windows.Forms.ComboBox
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker
        Me.btnregistrar = New System.Windows.Forms.Button
        Me.btnnuevo = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtmonto = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtaño = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtorden = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtidservicio = New System.Windows.Forms.TextBox
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
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmes)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txttipo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.cbopagador)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dtpfecha)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnregistrar)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnnuevo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtmonto)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtaño)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtorden)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtidservicio)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label1)
        Me.SplitContainer1.Size = New System.Drawing.Size(624, 383)
        Me.SplitContainer1.SplitterDistance = 382
        Me.SplitContainer1.TabIndex = 0
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
        Me.dgv1.Size = New System.Drawing.Size(382, 383)
        Me.dgv1.TabIndex = 0
        '
        'txtmes
        '
        Me.txtmes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtmes.FormattingEnabled = True
        Me.txtmes.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Setiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.txtmes.Location = New System.Drawing.Point(90, 115)
        Me.txtmes.Name = "txtmes"
        Me.txtmes.Size = New System.Drawing.Size(136, 21)
        Me.txtmes.TabIndex = 9
        '
        'txttipo
        '
        Me.txttipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txttipo.FormattingEnabled = True
        Me.txttipo.Items.AddRange(New Object() {"Luz", "Agua", "Cable", "Telefono", "Internet", "Otros"})
        Me.txttipo.Location = New System.Drawing.Point(90, 63)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(136, 21)
        Me.txttipo.TabIndex = 5
        '
        'cbopagador
        '
        Me.cbopagador.FormattingEnabled = True
        Me.cbopagador.Location = New System.Drawing.Point(90, 193)
        Me.cbopagador.Name = "cbopagador"
        Me.cbopagador.Size = New System.Drawing.Size(136, 21)
        Me.cbopagador.TabIndex = 15
        '
        'dtpfecha
        '
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(90, 168)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(136, 20)
        Me.dtpfecha.TabIndex = 13
        '
        'btnregistrar
        '
        Me.btnregistrar.Location = New System.Drawing.Point(138, 220)
        Me.btnregistrar.Name = "btnregistrar"
        Me.btnregistrar.Size = New System.Drawing.Size(88, 23)
        Me.btnregistrar.TabIndex = 17
        Me.btnregistrar.Text = "&Registrar"
        Me.btnregistrar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(44, 220)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(88, 23)
        Me.btnnuevo.TabIndex = 16
        Me.btnnuevo.Text = "&Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 201)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Pagador:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Fecha de pago:"
        '
        'txtmonto
        '
        Me.txtmonto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmonto.Location = New System.Drawing.Point(90, 142)
        Me.txtmonto.Name = "txtmonto"
        Me.txtmonto.Size = New System.Drawing.Size(136, 20)
        Me.txtmonto.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Monto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Mes:"
        '
        'txtaño
        '
        Me.txtaño.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtaño.Location = New System.Drawing.Point(90, 90)
        Me.txtaño.Name = "txtaño"
        Me.txtaño.Size = New System.Drawing.Size(136, 20)
        Me.txtaño.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Año"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Servicio:"
        '
        'txtorden
        '
        Me.txtorden.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtorden.Location = New System.Drawing.Point(90, 38)
        Me.txtorden.Name = "txtorden"
        Me.txtorden.Size = New System.Drawing.Size(136, 20)
        Me.txtorden.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Orden de pago:"
        '
        'txtidservicio
        '
        Me.txtidservicio.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtidservicio.Location = New System.Drawing.Point(90, 12)
        Me.txtidservicio.Name = "txtidservicio"
        Me.txtidservicio.ReadOnly = True
        Me.txtidservicio.Size = New System.Drawing.Size(136, 20)
        Me.txtidservicio.TabIndex = 1
        Me.txtidservicio.Text = "-1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro de pago:"
        '
        'frm_servicio
        '
        Me.AcceptButton = Me.btnregistrar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 383)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = Global.galman.My.Resources.Resources.logo_galman
        Me.Name = "frm_servicio"
        Me.Text = "Servicios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents dgv1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnregistrar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtmonto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtaño As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtorden As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtidservicio As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbopagador As System.Windows.Forms.ComboBox
    Friend WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents txttipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtmes As System.Windows.Forms.ComboBox
End Class
