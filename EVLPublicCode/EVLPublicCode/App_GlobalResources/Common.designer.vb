'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option or rebuild the Visual Studio project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "10.0.0.0"), _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
    Public Class Common

        Private Shared resourceMan As Global.System.Resources.ResourceManager

        Private Shared resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
        Public Sub New()
            MyBase.New()
        End Sub

        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Resources.Common", Global.System.Reflection.[Assembly].Load("App_GlobalResources"))
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
        Public Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(value As Global.System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property

        '''<summary>
        '''  Looks up a localized string similar to a duty of.
        '''</summary>
        Public Shared ReadOnly Property ADutyOf() As String
            Get
                Return ResourceManager.GetString("ADutyOf", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to .
        '''</summary>
        Public Shared ReadOnly Property AtADutyOf() As String
            Get
                Return ResourceManager.GetString("AtADutyOf", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Band.
        '''</summary>
        Public Shared ReadOnly Property Band() As String
            Get
                Return ResourceManager.GetString("Band", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to {0} days ago.
        '''</summary>
        Public Shared ReadOnly Property DaysAgo() As String
            Get
                Return ResourceManager.GetString("DaysAgo", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Displaying.
        '''</summary>
        Public Shared ReadOnly Property Displaying() As String
            Get
                Return ResourceManager.GetString("Displaying", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Duration.
        '''</summary>
        Public Shared ReadOnly Property Duration() As String
            Get
                Return ResourceManager.GetString("Duration", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to False.
        '''</summary>
        Public Shared ReadOnly Property MaintenanceMode() As String
            Get
                Return ResourceManager.GetString("MaintenanceMode", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to 1 month ago.
        '''</summary>
        Public Shared ReadOnly Property MonthAgo() As String
            Get
                Return ResourceManager.GetString("MonthAgo", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to {0} months ago.
        '''</summary>
        Public Shared ReadOnly Property MonthsAgo() As String
            Get
                Return ResourceManager.GetString("MonthsAgo", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Number of axles.
        '''</summary>
        Public Shared ReadOnly Property NumberOfAxles() As String
            Get
                Return ResourceManager.GetString("NumberOfAxles", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to of.
        '''</summary>
        Public Shared ReadOnly Property OfText() As String
            Get
                Return ResourceManager.GetString("OfText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to or more axles.
        '''</summary>
        Public Shared ReadOnly Property OrMoreAxles() As String
            Get
                Return ResourceManager.GetString("OrMoreAxles", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to This page cannot be found.
        '''</summary>
        Public Shared ReadOnly Property PageNotFoundHeader() As String
            Get
                Return ResourceManager.GetString("PageNotFoundHeader", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Please check that you have entered the correct web address, or explore &lt;a href=&quot;https://www.gov.uk&quot; alt=&quot;GOV.UK&quot;&gt;GOV.UK&lt;/a&gt; to find the information you need.
        '''</summary>
        Public Shared ReadOnly Property PageNotFoundText() As String
            Get
                Return ResourceManager.GetString("PageNotFoundText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Print this page.
        '''</summary>
        Public Shared ReadOnly Property Print() As String
            Get
                Return ResourceManager.GetString("Print", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to 31-Oct-2014.
        '''</summary>
        Public Shared ReadOnly Property ReturnDDRates() As String
            Get
                Return ResourceManager.GetString("ReturnDDRates", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Select.
        '''</summary>
        Public Shared ReadOnly Property SelectText() As String
            Get
                Return ResourceManager.GetString("SelectText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Service Unavailable.
        '''</summary>
        Public Shared ReadOnly Property ServiceUnavailableHeader1() As String
            Get
                Return ResourceManager.GetString("ServiceUnavailableHeader1", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to You can:.
        '''</summary>
        Public Shared ReadOnly Property ServiceUnavailableHeader2() As String
            Get
                Return ResourceManager.GetString("ServiceUnavailableHeader2", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to We’re really sorry that our online licensing service is not currently available. We’ll be back as soon as we can..
        '''</summary>
        Public Shared ReadOnly Property ServiceUnavailableText1() As String
            Get
                Return ResourceManager.GetString("ServiceUnavailableText1", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to &lt;ul&gt;&lt;li&gt;Try again later&lt;br /&gt;OR&lt;/li&gt;&lt;li&gt;Alternatively, you can go to a Post Office® branch that deals with vehicle tax.&lt;/li&gt;&lt;/ul&gt;.
        '''</summary>
        Public Shared ReadOnly Property ServiceUnavailableText2() As String
            Get
                Return ResourceManager.GetString("ServiceUnavailableText2", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to &lt;ul&gt;&lt;li&gt;Try again later&lt;/li&gt;&lt;/ul&gt;.
        '''</summary>
        Public Shared ReadOnly Property ServiceUnavailableText3() As String
            Get
                Return ResourceManager.GetString("ServiceUnavailableText3", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to 6 Months at.
        '''</summary>
        Public Shared ReadOnly Property SixMonths() As String
            Get
                Return ResourceManager.GetString("SixMonths", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to False.
        '''</summary>
        Public Shared ReadOnly Property TargetMaintenanceMode() As String
            Get
                Return ResourceManager.GetString("TargetMaintenanceMode", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to &lt;strong&gt;Direct Debit&lt;/strong&gt; &lt;br&gt;&lt;p&gt;The Direct Debit service is currently unavailable.  Please renew your vehicle tax either by using the card options above or try again later.  &lt;/p&gt;.
        '''</summary>
        Public Shared ReadOnly Property TargetMaintenanceText() As String
            Get
                Return ResourceManager.GetString("TargetMaintenanceText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Tax band.
        '''</summary>
        Public Shared ReadOnly Property TaxBand() As String
            Get
                Return ResourceManager.GetString("TaxBand", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Today.
        '''</summary>
        Public Shared ReadOnly Property Today() As String
            Get
                Return ResourceManager.GetString("Today", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to to.
        '''</summary>
        Public Shared ReadOnly Property ToText() As String
            Get
                Return ResourceManager.GetString("ToText", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to 12 Months at.
        '''</summary>
        Public Shared ReadOnly Property TwelveMonths() As String
            Get
                Return ResourceManager.GetString("TwelveMonths", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to 1 year ago.
        '''</summary>
        Public Shared ReadOnly Property YearAgo() As String
            Get
                Return ResourceManager.GetString("YearAgo", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to {0} years ago.
        '''</summary>
        Public Shared ReadOnly Property YearsAgo() As String
            Get
                Return ResourceManager.GetString("YearsAgo", resourceCulture)
            End Get
        End Property

        '''<summary>
        '''  Looks up a localized string similar to Yesterday.
        '''</summary>
        Public Shared ReadOnly Property Yesterday() As String
            Get
                Return ResourceManager.GetString("Yesterday", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
