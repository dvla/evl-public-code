Imports System.Xml.Xsl
Imports System.Xml.Serialization
Imports System.IO
Imports System.ComponentModel
Imports System.Web.Caching
Imports System.Web


Namespace Controls

    ''' <summary>
    ''' Script generator is a control created to add objects to an xslt to display user friendly messages
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ScriptGenerator
        Inherits System.Web.UI.Control

        Private _xslPath As String
        Private _tranformArgs As XsltArgumentList
        Private _DataObject As New System.Collections.ObjectModel.Collection(Of Object)
        Private _StepId As String
        Private _ForceRecreateSerializer As Boolean

        ''' <summary>
        ''' Used to cache xslt to avoid retrieving from file system every time
        ''' </summary>
        ''' <param name="XslPath"></param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function SetupXslCache(ByVal XslPath As String) As System.Xml.Xsl.XslCompiledTransform
            Dim trans As XslCompiledTransform = Nothing
            If HttpRuntime.Cache(XslPath) Is Nothing Then

                Dim t As New XslCompiledTransform()

                Dim filePath As String = Path.Combine(HttpRuntime.AppDomainAppPath, XslPath)
                t.Load(filePath)
                Dim dep As New CacheDependency(filePath)
                HttpRuntime.Cache.Add(XslPath, t, dep, DateTime.Now.AddMinutes(20), System.Web.Caching.Cache.NoSlidingExpiration, CacheItemPriority.Normal, Nothing)

                trans = t
            Else
                trans = CType(HttpRuntime.Cache(XslPath), XslCompiledTransform)
            End If
            Return trans
        End Function

        ''' <summary>
        ''' used to render the xslt section to the page
        ''' </summary>
        ''' <param name="writer"></param>
        ''' <remarks></remarks>
        Protected Overrides Sub Render(ByVal writer As System.Web.UI.HtmlTextWriter)
            If Me.DesignMode Then Exit Sub 'Required to fix design time rendering problem

            MyBase.Render(writer)

            Dim trans As XslCompiledTransform = Nothing
            Dim stream As New MemoryStream()
            Dim doc As New XDocument()

            trans = SetupXslCache(XslPath)

            'Retrieve XslCompiledTransform from cache or create if necessary
            If DataObject.Count > 0 Then
                Dim tp = DataObject.Where(Function(x) Not x Is Nothing).Select(Function(x) x.GetType()).Distinct
                Dim siblingTypeList As New List(Of Type)
                For Each t As Type In tp
                    siblingTypeList.Add(t)
                    Dim baseType As Type = t.BaseType
                    If Not baseType Is Nothing AndAlso Not baseType Is GetType(System.Object) Then
                        Dim siblings = t.Assembly.GetTypes().Where(Function(x) x.BaseType Is baseType)
                        siblingTypeList.AddRange(siblings.ToList())
                    End If
                Next

                Dim ser As XmlSerializer = Nothing

                'Creating XmlSerializers using this constructor is very expensive since it needs to create
                'a new serialization assembly every time. If it doesn't already exist, cache it
                'to save a whole bunch of time at render time
                Dim cacheKey As String = GetCacheKey()
                If HttpRuntime.Cache(cacheKey) Is Nothing Then
                    Dim newSer As XmlSerializer = New XmlSerializer(DataObject.GetType(), siblingTypeList.Distinct().ToArray())
                    If Not HttpRuntime.Cache(cacheKey) Is Nothing Then HttpRuntime.Cache.Remove(cacheKey)
                    HttpRuntime.Cache.Add(cacheKey, newSer, Nothing, DateTime.Now.AddMinutes(20.0), Cache.NoSlidingExpiration, CacheItemPriority.Normal, Nothing)
                    
                End If

                ser = CType(HttpRuntime.Cache(cacheKey), XmlSerializer)
                ser.Serialize(stream, DataObject)
                stream.Position = 0
                doc = XDocument.Load(New StreamReader(stream))
            End If

            XsltArgs.AddParam("step", "", StepId)
            XsltArgs.AddExtensionObject("urn:utils", XslUtility.Instance)

            trans.Transform(doc.CreateReader(), XsltArgs, writer)
        End Sub

        Public Sub New()
            _tranformArgs = New XsltArgumentList()
        End Sub

        ''' <summary>
        ''' Returns the xslpath and stepid in the format required
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Private Function GetCacheKey() As String
            Return String.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}$${1}", XslPath, StepId)
        End Function

        ''' <summary>
        ''' The physical path of the xslt file
        ''' </summary>
        Public Property XslPath() As String
            Get
                Return _xslPath
            End Get
            Set(ByVal value As String)
                _xslPath = value
            End Set
        End Property

        ''' <summary>
        ''' A list of arguments to pass to the xslt document
        ''' </summary>
        ''' <remarks>The DesignerSerializationVisibility attribute is required to stop a design-time rendering issue</remarks>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)> _
        Private ReadOnly Property XsltArgs() As XsltArgumentList
            Get
                Return _tranformArgs
            End Get
        End Property

        ''' <summary>
        ''' A list of dataobjects to be included in the xslt
        ''' </summary>
        Public ReadOnly Property DataObject() As System.Collections.ObjectModel.Collection(Of Object)
            Get
                If MyBase.ViewState(String.Format("{0}_{1}_DataObjects", XslPath, StepId)) Is Nothing Then Return New System.Collections.ObjectModel.Collection(Of Object) 'Return empty collection
                Return CType(MyBase.ViewState(String.Format("{0}_{1}_DataObjects", XslPath, StepId)), System.Collections.ObjectModel.Collection(Of Object)) 'Return collection from viewstate
            End Get
        End Property

        ''' <summary>
        ''' Add a data object to the xslt sotred in viewstate
        ''' </summary>
        ''' <param name="objectToAdd"></param>
        ''' <remarks></remarks>
        Public Sub AddDataObject(objectToAdd As Object)
            _DataObject.Add(objectToAdd)
            MyBase.ViewState(String.Format("{0}_{1}_DataObjects", XslPath, StepId)) = _DataObject
        End Sub

        ''' <summary>
        ''' The step to display inside the xslt
        ''' </summary>
        Public Property StepId() As String
            Get
                Return _StepId
            End Get
            Set(ByVal value As String)
                _StepId = value
            End Set
        End Property

    End Class

End Namespace
