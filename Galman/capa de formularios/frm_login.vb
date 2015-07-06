
Public Class frm_login
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Static i As Integer
        Dim r As New registro
        Dim s As String = ""
        Try
            s = r.leer("HKLM\software\galman\servername")
        Catch
            Do While (Trim(s) = "")
                s = InputBox("El servidor de base de datos, ha fallado, por favor ingrese un nombre de servidor válido (si el servidor es local dejelo tal como está)", "Sistema Galman", "(local")
            Loop
            r.escribir("HKLM\software\galman\servername", s, Eregistro.REG_SZ)
        End Try
        Dim db As New BaseDato(s, username.Text, passwd.Text)
        If (db.probar_conexion = True) Then
            Me.Close()
            general.usuario = username.Text
            general.password = passwd.Text
            general.server = s
        Else
            If (i < 2) Then
                i += 1
                MsgBox("Usuario o contraseña incorrectos", MsgBoxStyle.Exclamation)
            Else
                MsgBox("Ha excedido el limite de intentos permitidos", MsgBoxStyle.Information)
                End
            End If
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub frm_login_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.username.Focus()
    End Sub
End Class
