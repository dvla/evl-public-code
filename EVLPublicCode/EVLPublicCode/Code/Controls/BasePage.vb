Imports System.Web.UI
Imports System.Web

Namespace Common
    ''' <summary>
    ''' A base page from which all other pages inherit
    ''' </summary>
    ''' <remarks>This page is required to handle culture changes, as pages within master pages have no InitCulture sub</remarks>
    Public Class BasePage
        Inherits Page

        ''' <summary>
        ''' Set the user culture language
        ''' </summary>
        ''' <param name="myCulture"></param>
        ''' <remarks>This stores a cookie on the client machine for 1 year</remarks>
        Private Overloads Sub SetUserCulture(ByVal myCulture As String)
            Dim userCultureCookie As New HttpCookie("UserCulture")
            userCultureCookie.Expires = Now.AddYears(1) 'Expire the cookie in 1 year, therefore held for next car tax
            userCultureCookie.Values("UserCulture") = IIf(IsNothing(myCulture), Nothing, myCulture)
            Response.Cookies.Add(userCultureCookie)

        End Sub

        ''' <summary>
        ''' SetUserCulture
        ''' </summary>
        ''' <remarks></remarks>
        Private Overloads Sub SetUserCulture()
            SetUserCulture(Nothing)
        End Sub

        ''' <summary>
        ''' InitializeCulture sets the cookie
        ''' </summary>
        ''' <remarks></remarks>
        Protected Overrides Sub InitializeCulture()

            Dim qString As Object = HttpContext.Current.Request.QueryString("l")

            If Not qString Is Nothing AndAlso qString.ToString <> "" Then
                If qString.ToString.ToLower = "cy-gb" Then
                    SetUserCulture("cy-GB")
                End If
            End If

            Dim rCookie As HttpCookie = HttpContext.Current.Request.Cookies("UserCulture")

            If Not rCookie Is Nothing Then
                Select Case rCookie.Values("UserCulture")
                    Case "cy-GB"
                        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo(rCookie("UserCulture").ToString)
                        System.Threading.Thread.CurrentThread.CurrentUICulture = New System.Globalization.CultureInfo(rCookie("UserCulture").ToString)
                    Case Else
                        'If  english then remove the cookie
                        rCookie.Expires = Now.AddDays(-1)
                        Response.Cookies.Add(rCookie)
                End Select

            End If

            MyBase.InitializeCulture()

        End Sub

    End Class
End Namespace