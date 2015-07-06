Public Enum Eregistro
    REG_SZ
    REG_DWORD
End Enum
Public Class registro
    Dim reg As Object
    Public Sub New()
        Try
            reg = CreateObject("WSCript.shell")
        Catch ex As Exception
            MsgBox("No se pudo acceder al registro de windows", MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub escribir(ByVal ruta As String, ByVal valor As String, ByVal tipo As Eregistro)
        reg.regwrite(ruta, valor, tipo.ToString)
    End Sub
    Public Function leer(ByVal ruta)
        Return reg.regread(ruta)
    End Function
End Class
