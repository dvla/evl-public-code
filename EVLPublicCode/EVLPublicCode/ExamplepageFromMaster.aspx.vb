Imports EVLPublicCode.Common

Public Class ExamplepageFromMaster
    Inherits BasePage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.Page.IsPostBack Then
            CType(Me.Master, ApplicationTemplate).ServiceName = Resources.EVLText.ServiceNameTax.ToString
        End If
    End Sub

End Class