Imports System.IO
Imports System.Web.UI
Imports System.Web
Imports System.Globalization.CultureInfo
Imports System.Globalization

Public Class ApplicationTemplate
    Inherits System.Web.UI.MasterPage
    

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            SetGlobalMessage()
            End If
    End Sub

    ''' <summary>
    ''' English language select
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub EnglishImage_Click(sender As Object, e As EventArgs) Handles butEnglish.Click

        Dim userCultureCookie As New HttpCookie("UserCulture")
        userCultureCookie.Expires = Now.AddYears(1) 'Expire the cookie in 1 year, therefore held for next car tax
        userCultureCookie.Values("UserCulture") = Nothing
        Response.Cookies.Add(userCultureCookie)
        Response.Redirect(Request.Url.PathAndQuery)
    End Sub

    ''' <summary>
    ''' Welsh language select
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Protected Sub WelshImage_Click(sender As Object, e As EventArgs) Handles butWelsh.Click

        Dim userCultureCookie As New HttpCookie("UserCulture")
        userCultureCookie.Expires = Now.AddYears(1) 'Expire the cookie in 1 year, therefore held for next car tax
        userCultureCookie.Values("UserCulture") = "cy-GB"
        Response.Cookies.Add(userCultureCookie)
        Response.Redirect(Request.Url.PathAndQuery)
    End Sub

    ''' <summary>
    ''' Checks to see if a glbal message is in the resx file and loads it if exists
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetGlobalMessage()
        Dim GlobalMessage As String = Resources.EVLText.GlobalMessage.ToString
        If Not String.IsNullOrWhiteSpace(GlobalMessage) Then
            lblGlobalMessage.Text = GlobalMessage.ToString(CurrentCulture)
            globalNotice.Visible = True
        Else
            globalNotice.Visible = False
        End If
    End Sub

End Class