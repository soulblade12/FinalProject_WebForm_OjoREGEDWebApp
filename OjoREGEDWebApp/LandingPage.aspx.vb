Public Class LandingPage
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Employee_sign_Click(sender As Object, e As EventArgs)
        Response.Redirect("SignUpEmployee.aspx")
        'Server.TransferRequest("/SignUpEmployee.aspx")
    End Sub

    Protected Sub Customer_Sign_Click(sender As Object, e As EventArgs)
        Response.Redirect("SignUpCustomer.aspx")
    End Sub

    Protected Sub LoginCustomer_Click(sender As Object, e As EventArgs)
        Response.Redirect("LoginPage.aspx")
    End Sub

    Protected Sub LoginEmployee_Click(sender As Object, e As EventArgs)
        Response.Redirect("LoginEmployee.aspx")
    End Sub
End Class