Imports System.ComponentModel
Imports Microsoft.VisualBasic
Imports System.data
Imports System.Data.SqlClient
Public Class BaseDato
    Inherits Object
    Protected cn As SqlConnection
    Private da As SqlDataAdapter
    Private cm As SqlCommand
    Private dp As New DataTable
    Private nombre As String
    Private cb As SqlCommandBuilder
    Private dt As DataTable
    Private trbool As Boolean
    Public Function ultimo_procedimiento() As DataTable
        Return dt
    End Function
    Private Sub cargar_parametros(ByVal m_tabla As String)
        dp = Nothing
        dp = New DataTable("load_param")
        da = New SqlDataAdapter("load_param '" & m_tabla & "'", cn)
        da.Fill(dp)
    End Sub
    Public Sub New(ByVal sqlconn As String)
        cn = New SqlConnection(sqlconn)
    End Sub
    Public Sub New(ByVal server As String, ByVal usuario As String, ByVal clave As String)
        Dim sa As String = "data source=" & server & ";initial catalog=galman;user id=" & usuario & ";password=" & clave
        cn = New SqlConnection(sa)
    End Sub
    Public Function probar_conexion() As Boolean
        Try
            cn.Open()
            cn.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function procedimiento(ByVal m_nombre As String, ByVal ParamArray parametros() As Object) As DataTable
        Dim i As Integer = 0
        Dim s As String = ""
        cargar_parametros(m_nombre)
        Dim dr_param() As DataRow = dp.Select()
        Dim dr As DataRow
        cm = New SqlCommand
        cm.Connection = cn
        Try
            For Each dr In dr_param
                Dim cambiar As Boolean = False
                If (IsNothing(parametros(i))) Then
                    cambiar = True
                ElseIf (String.IsNullOrEmpty(parametros(i).ToString)) Then
                    cambiar = True
                ElseIf (parametros(i).ToString = "") Then
                    cambiar = True
                End If
                If (cambiar = True) Then parametros(i) = vbNull
                Select Case dr("paramtype")
                    Case "int"
                        cm.Parameters.Add("@a" & i, SqlDbType.Int).Value = CInt(parametros(i))
                    Case "datetime"
                        cm.Parameters.Add("@a" & i, SqlDbType.DateTime).Value = CDate(parametros(i))
                    Case "text"
                        cm.Parameters.Add("@a" & i, SqlDbType.Text).Value = IIf(parametros(i).ToString = "", "a", parametros(i).ToString)
                    Case "varchar"
                        cm.Parameters.Add("@a" & i, SqlDbType.VarChar).Value = IIf(IsNothing(parametros(i)), "", parametros(i))
                    Case "bit"
                        cm.Parameters.Add("@a" & i, SqlDbType.Bit).Value = CType(parametros(i), Boolean)
                    Case "char"
                        cm.Parameters.Add("@a" & i, SqlDbType.Char).Value = IIf(parametros(i).ToString = "", "a", parametros(i).ToString)
                    Case "decimal"
                        cm.Parameters.Add("@a" & i, SqlDbType.Decimal).Value = IIf(parametros(i).ToString = "", "a", Val(parametros(i)))
                    Case "float"
                        cm.Parameters.Add("@a" & i, SqlDbType.Float).Value = IIf(parametros(i).ToString = "", "a", Val(parametros(i)))
                    Case "money"
                        cm.Parameters.Add("@a" & i, SqlDbType.Money).Value = IIf(parametros(i).ToString = "", "a", Val(parametros(i)))
                    Case "tinyint"
                        cm.Parameters.Add("@a" & i, SqlDbType.TinyInt).Value = IIf(parametros(i).ToString = "", "a", Val(parametros(i)))
                    Case "bigint"
                        cm.Parameters.Add("@a" & i, SqlDbType.BigInt).Value = IIf(parametros(i).ToString = "", "a", Val(parametros(i)))
                    Case "smallmoney"
                        cm.Parameters.Add("@a" & i, SqlDbType.SmallMoney).Value = IIf(parametros(i).ToString = "", "a", Val(parametros(i)))
                    Case "ntext"
                        cm.Parameters.Add("@a" & i, SqlDbType.NText).Value = IIf(parametros(i).ToString = "", "a", parametros(i).ToString)
                    Case "nvarchar"
                        cm.Parameters.Add("@a" & i, SqlDbType.NVarChar).Value = IIf(parametros(i).ToString = "", "a", parametros(i).ToString)
                    Case "image"
                        Dim bmp As Bitmap = parametros(i)
                        Dim x As New IO.MemoryStream
                        bmp.Save(x, Imaging.ImageFormat.Jpeg)
                        cm.Parameters.Add("@a" & i, SqlDbType.Image).Value = x.GetBuffer
                    Case "smalldatetime"
                        cm.Parameters.Add("@a" & i, SqlDbType.SmallDateTime).Value = IIf(parametros(i).ToString = "", "a", CDate(parametros(i)))
                End Select
                i += 1
                s = s + ",@a" & i - 1
            Next
            cm.CommandText = "exec " & m_nombre + " " + Mid(s, 2)
            da = New SqlDataAdapter(cm)
            dt = Nothing
            dt = New DataTable(m_nombre)
            da.Fill(dt)
        Catch ex As SqlException
            MsgBox("Ah ocurrido un error: " + ex.ErrorCode.ToString + vbCrLf + ex.Message.ToString)
        End Try
        Return dt
    End Function
End Class