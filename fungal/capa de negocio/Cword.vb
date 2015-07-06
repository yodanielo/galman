Imports Microsoft.Office.Interop.Word
Public Class Cword
    Public app As New Microsoft.Office.Interop.Word.Application
    Public doc As New Microsoft.Office.Interop.Word.Document
    Public Sub New(Optional ByVal plantilla As String = "\conarrendamiento.dot")
        'i.Application.Documents.Open(My.Application.Info.DirectoryPath & "\contrato.dot")
        doc = app.Documents.Open(plantilla)
    End Sub
    Protected Sub reemplazar(ByVal esta As String, ByVal por_esta As String)
        app.ActiveDocument.Activate()
        app.Selection.WholeStory()
        With (app.Selection.Find)
            .Text = esta
            .Forward = True
            .Format = True
            .Replacement.Text = por_esta
            .Execute(.Text, , , , , , , , , .Replacement.Text, WdReplace.wdReplaceAll)
        End With

        '.Text = esta
        '.Replacement.Text = por_esta
        '.Forward = True
        '.Wrap = 1 'wdFindContinue
        '.Format = True
        '.MatchCase = False
        '.MatchWholeWord = False
        '.MatchWildcards = False
        '.MatchSoundsLike = False
        '.MatchAllWordForms = False
        '.Execute(Replace:=2) 'wdreplaceall
        'End With
    End Sub
    Public Property visible() As Boolean
        Set(ByVal value As Boolean)
            doc.Application.Visible = value
        End Set
        Get
            Return doc.Application.Visible
        End Get
    End Property
    Public Sub guardar_como(ByVal ruta As String, ByVal archivo As String)
        Try
            doc.Activate()
            doc.Application.Visible = True
            ruta = Trim(ruta)
            If (ruta = "") Then
                ruta = My.Application.Info.DirectoryPath
            End If
            Dim s As String = IIf(Strings.Right(ruta, 1) <> "\", ruta & "\", ruta)
            s = s & IIf(Left(archivo, 1) = "\", Strings.Right(archivo, Strings.Len(archivo) - 1), archivo)
            MsgBox("Ruta: " & Chr(13) & s)
            doc.SaveAs(s)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Public Sub guardar()
        doc.Activate()
        doc.Save()
    End Sub
End Class
Public Class print_conarrendamiento_natural
    Inherits Cword
    Private _identificacion As String = "_{identificacion}_"
    Private _arrendataria_o As String = "_{arrendataria_o}_"
    Private _ocupacion As String = "_{ocupacion}_"
    Private _numero As String = "_{numero}_"
    Private _duracion As String = "_{duracion}_"
    Private _fecinicio As String = "_{fecinicio}_"
    Private _fecfin As String = "_{fecfin}_"
    Private _merconductiva As String = "_{merconductiva}_"
    Private _garantia As String = "_{garantia}_"
    Private _fechafirma As String = "_{fechafirma}_"
    Private _nombre As String = "_{NOMBRE}_"
    Public Sub New()
        MyBase.New(My.Application.Info.DirectoryPath & "\plantillas\conarrendamiento.dot")
    End Sub
    ''' <summary>
    ''' identificacion del arrendatario:
    ''' el señor tal identificado con dni tal domiciliado en tal,etc
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property identificacion() As String
        Get
            Return _identificacion
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_identificacion, value)
            _identificacion = value
        End Set
    End Property
    ''' <summary>
    ''' especifica si es arrendatario o arrendataria
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property arrendataria_o() As String
        Get
            Return _arrendataria_o
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_arrendataria_o, value)
            _arrendataria_o = value
        End Set
    End Property
    ''' <summary>
    ''' a que se va a dedicar el local
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ocupacion() As String
        Get
            Return _ocupacion
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_ocupacion, value)
            _ocupacion = value
        End Set
    End Property
    ''' <summary>
    ''' numero del local
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property numero()
        Get
            Return _numero
        End Get
        Set(ByVal value)
            MyBase.reemplazar(_numero, value)
            _numero = value
        End Set
    End Property
    ''' <summary>
    ''' duracion del contrato
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property duracion() As String
        Get
            Return _duracion
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_duracion, value)
            _duracion = value
        End Set
    End Property
    Public Property fecha_inicio() As String
        Get
            Return _fecinicio
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_fecinicio, value)
            _fecinicio = value
        End Set
    End Property
    Public Property fecha_fin() As String
        Get
            Return _fecfin
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_fecfin, value)
            _fecfin = value
        End Set
    End Property
    Public Property merced_conductiva() As String
        Get
            Return _merconductiva
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_merconductiva, value)
            _merconductiva = value
        End Set
    End Property
    Public Property garantia() As String
        Get
            Return _garantia
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_garantia, value)
            _garantia = value
        End Set
    End Property
    Public Property fecha_firma() As String
        Get
            Return _fechafirma
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_fechafirma, value)
            _fechafirma = value
        End Set
    End Property
    ''' <summary>
    ''' nombre completo del arrendatario
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            MyBase.reemplazar(_nombre, value)
            _nombre = value
        End Set
    End Property
End Class