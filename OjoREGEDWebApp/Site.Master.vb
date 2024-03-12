Public Class SiteMaster
    Inherits MasterPage
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Session("User") Or Session("Employee") Is Nothing Then
            Response.Redirect("~/LandingPage.aspx")
        End If
    End Sub

    Protected Sub Settings_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/CustomerProfile.aspx")
    End Sub


End Class