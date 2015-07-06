Imports System.ComponentModel
Public Class btn_menu
    Public Shadows Event click(ByVal sender As Object, ByVal e As EventArgs)
    Private a As Integer = 0
    '0 es inactivo
    '1 es presionado
    '2 es activo
    <Category("texto")> _
    Public Property titulo() As String
        Get
            Return Label1.Text
        End Get
        Set(ByVal value As String)
            Label1.Text = value
        End Set
    End Property
    Private Sub Label1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseClick
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            a = 2
            RaiseEvent click(Me, Nothing)
            Me.BackgroundImage = My.Resources.menu_activo
            desactivar()
        End If
    End Sub
    Private Sub Label1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            If (a = 0) Then
                Me.BackgroundImage = My.Resources.menu_presionado
                a = 1
            End If
        End If
    End Sub
    Private Sub Label1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label1.MouseEnter
        If (a = 0) Then
            Me.BackgroundImage = My.Resources.menu_sobre
        End If
    End Sub
    Private Sub Label1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.MouseLeave
        If (a = 1 Or a = 0) Then
            a = 0
            Me.BackgroundImage = My.Resources.menu_inactivo
        ElseIf (a = 2) Then
            Me.BackgroundImage = My.Resources.menu_activo
        End If
    End Sub
    Public Sub desactivar()
        Dim a As Control
        For Each a In Me.Parent.Controls
            If (Not a Is Me) Then
                CType(a, btn_menu).estado_inactivo()
            End If
        Next
    End Sub
    Private Sub estado_inactivo()
        a = 0
        Me.BackgroundImage = My.Resources.menu_inactivo
    End Sub

    Private Sub btn_menu_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.BackgroundImage = My.Resources.menu_inactivo
    End Sub
End Class
