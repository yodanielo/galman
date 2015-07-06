Imports System.Drawing.Design
Public MustInherit Class Ceditor
    Inherits UITypeEditor
    Public Overrides Function GetEditStyle(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.Drawing.Design.UITypeEditorEditStyle
        Return UITypeEditorEditStyle.Modal
    End Function
    Public Overrides Function GetPaintValueSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
        Return True
    End Function
    Public MustOverride Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object
End Class
Public Class Editor_cloccontrato
    Inherits Ceditor
    Public Overloads Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object
        Dim x As New frm_loccontrato(CType(value, List(Of CLocal)), Eproc_contrato.list_loccontrato)
        Dim backup As Object = value
        x.ShowDialog()
        If (x.DialogResult = DialogResult.OK) Then
            Return x._arr3
        Else
            Return backup
        End If
    End Function
End Class
Public Class editor_cpernatural
    Inherits Ceditor
    Public Overloads Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object
        Dim x As New frm_loccontrato(CType(value, List(Of CPNatural)), Eproc_contrato.list_conarrnatural)
        Dim backup As Object = value
        x.ShowDialog()
        If (x.DialogResult = DialogResult.OK) Then
            Return x._arr1
        Else
            Return backup
        End If
    End Function
End Class
Public Class editor_cperjuridica
    Inherits Ceditor
    Public Overloads Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object
        Dim x As New frm_loccontrato(CType(value, List(Of CPJuridica)), Eproc_contrato.list_conarrjuridico)
        Dim backup As Object = value
        x.ShowDialog()
        If (x.DialogResult = DialogResult.OK) Then
            Return x._arr2
        Else
            Return backup
        End If
    End Function
End Class
Public Class editor_selcarpeta
    Inherits Ceditor
    Public Overloads Overrides Function EditValue(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal provider As System.IServiceProvider, ByVal value As Object) As Object
        Dim g As New FolderBrowserDialog
        g.Description = "Seleccione el directorio donde guardar el contrato"
        g.SelectedPath = value
        Dim h As String = value
        If (g.ShowDialog() = DialogResult.OK) Then
            Return g.SelectedPath
        Else
            Return h
        End If
    End Function
End Class