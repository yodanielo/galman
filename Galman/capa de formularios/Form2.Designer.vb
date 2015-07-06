<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.flp_contenido = New System.Windows.Forms.FlowLayoutPanel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.btn_administrar = New apariencia.btn_menu
        Me.btn_egresos = New apariencia.btn_menu
        Me.btn_reportes = New apariencia.btn_menu
        Me.btn_ayuda = New apariencia.btn_menu
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'flp_contenido
        '
        Me.flp_contenido.AutoScroll = True
        Me.flp_contenido.BackColor = System.Drawing.Color.Transparent
        Me.flp_contenido.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.flp_contenido.Location = New System.Drawing.Point(224, 129)
        Me.flp_contenido.Name = "flp_contenido"
        Me.flp_contenido.Size = New System.Drawing.Size(381, 309)
        Me.flp_contenido.TabIndex = 1
        Me.flp_contenido.WrapContents = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_administrar)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_egresos)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_reportes)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_ayuda)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 129)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(206, 196)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btn_administrar
        '
        Me.btn_administrar.BackColor = System.Drawing.Color.Transparent
        Me.btn_administrar.BackgroundImage = CType(resources.GetObject("btn_administrar.BackgroundImage"), System.Drawing.Image)
        Me.btn_administrar.Location = New System.Drawing.Point(9, 9)
        Me.btn_administrar.Margin = New System.Windows.Forms.Padding(9)
        Me.btn_administrar.Name = "btn_administrar"
        Me.btn_administrar.Size = New System.Drawing.Size(188, 31)
        Me.btn_administrar.TabIndex = 0
        Me.btn_administrar.titulo = "Administrar"
        '
        'btn_egresos
        '
        Me.btn_egresos.BackColor = System.Drawing.Color.Transparent
        Me.btn_egresos.BackgroundImage = CType(resources.GetObject("btn_egresos.BackgroundImage"), System.Drawing.Image)
        Me.btn_egresos.Location = New System.Drawing.Point(9, 58)
        Me.btn_egresos.Margin = New System.Windows.Forms.Padding(9)
        Me.btn_egresos.Name = "btn_egresos"
        Me.btn_egresos.Size = New System.Drawing.Size(188, 31)
        Me.btn_egresos.TabIndex = 1
        Me.btn_egresos.titulo = "Egresos"
        '
        'btn_reportes
        '
        Me.btn_reportes.BackColor = System.Drawing.Color.Transparent
        Me.btn_reportes.BackgroundImage = CType(resources.GetObject("btn_reportes.BackgroundImage"), System.Drawing.Image)
        Me.btn_reportes.Location = New System.Drawing.Point(9, 107)
        Me.btn_reportes.Margin = New System.Windows.Forms.Padding(9)
        Me.btn_reportes.Name = "btn_reportes"
        Me.btn_reportes.Size = New System.Drawing.Size(188, 31)
        Me.btn_reportes.TabIndex = 2
        Me.btn_reportes.titulo = "Reportes"
        '
        'btn_ayuda
        '
        Me.btn_ayuda.BackColor = System.Drawing.Color.Transparent
        Me.btn_ayuda.BackgroundImage = CType(resources.GetObject("btn_ayuda.BackgroundImage"), System.Drawing.Image)
        Me.btn_ayuda.Location = New System.Drawing.Point(9, 156)
        Me.btn_ayuda.Margin = New System.Windows.Forms.Padding(9)
        Me.btn_ayuda.Name = "btn_ayuda"
        Me.btn_ayuda.Size = New System.Drawing.Size(188, 31)
        Me.btn_ayuda.TabIndex = 3
        Me.btn_ayuda.titulo = "Ayuda"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.galman.My.Resources.Resources.presionado
        Me.ClientSize = New System.Drawing.Size(617, 455)
        Me.Controls.Add(Me.flp_contenido)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Galman"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.Icon = My.Resources.logo_galman
    End Sub
    Friend WithEvents btn_egresos As apariencia.btn_menu
    Friend WithEvents btn_reportes As apariencia.btn_menu
    Friend WithEvents btn_ayuda As apariencia.btn_menu
    Friend WithEvents btn_administrar As apariencia.btn_menu
    Friend WithEvents flp_contenido As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
