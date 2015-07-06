Imports System.ComponentModel
<DefaultEvent("click")> _
Public Class btn_elegante
    Public Shadows Event click(ByVal sender As Object, ByVal e As EventArgs)
    Private a As Integer = 0
    Private _target As Form
    Private _modo As Integer
    '0=inactivo
    '1=presionado
#Region "apariencia"
    Public Sub New(ByVal _titulo As String, ByVal _subtitulo As String)
        InitializeComponent()
        titulo = _titulo
        subtitulo = _subtitulo
    End Sub
    Public Sub New()
        InitializeComponent()
    End Sub
    <Category("texto")> _
    Public Property titulo() As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property
    <Category("texto")> _
    Public Property subtitulo() As String
        Get
            Return Label2.Text
        End Get
        Set(ByVal value As String)
            Label2.Text = value
        End Set
    End Property
    <Category("texto")> _
    Public Property imagen() As Bitmap
        Get
            Return img1.BackgroundImage
        End Get
        Set(ByVal value As Bitmap)
            img1.BackgroundImage = value
        End Set
    End Property
#End Region
#Region "comportamiento"
    Private Sub img1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles img1.MouseClick ', Label1.MouseClick, Label2.MouseClick, Me.MouseClick
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            RaiseEvent click(Me, Nothing)
            Me.BackgroundImage = My.Resources.btn_elegante_sobre
        End If
    End Sub
    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles img1.MouseDown ', Label1.MouseDown, Label2.MouseDown, Me.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Me.BackgroundImage = My.Resources.btn_elegante_presionado
        End If
    End Sub
    Private Sub img1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles img1.MouseEnter ', Label1.MouseEnter, Label2.MouseEnter, Me.MouseEnter
        Me.BackgroundImage = My.Resources.btn_elegante_sobre
    End Sub
    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles img1.MouseLeave ', Label1.MouseLeave, Label2.MouseLeave, Me.MouseLeave
        Me.BackgroundImage = My.Resources.btn_elegante_inactivo
    End Sub
    <Category("Comportamiento"), Description("Establece el formulario al que se llamará al hacer click")> _
    Public Property target(Optional ByVal i As Integer = 1) As Form
        Set(ByVal value As Form)
            _target = value
            _modo = i
        End Set
        Get
            Return _target
        End Get
    End Property
    <Category("Comportamiento"), Description("el modo de llamar el formulario: 0 para modal, 1 para no modal")> _
    Public Property modo() As Integer
        Get
            Return _modo
        End Get
        Set(ByVal value As Integer)
            _modo = value
        End Set
    End Property
#End Region
End Class
