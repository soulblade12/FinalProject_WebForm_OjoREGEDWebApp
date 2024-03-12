Imports OjoREGED.BLL

Public Class LoginEmployee
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnLoginEmp_Click(sender As Object, e As EventArgs)
        Try
            Dim _EmpBLL As New EmployeeBLL()
            Dim _empDTO = _EmpBLL.EmployeeLogin(txtUsername.Text, txtPassword.Text)
            If _empDTO IsNot Nothing Then
                Session("Employee") = _empDTO
                Response.Redirect("/HomePage.aspx")
                'Dim returnUrl = Request.QueryString("ReturnUrl")

                'If Not String.IsNullOrEmpty(returnUrl) Then
                '    'Response.Redirect("~/" & returnUrl)
                '    'Else
                '    Response.Redirect("~/Default.aspx")
                'End If
            Else
                ltMessage.Text = "<br/><span class='alert alert-danger'>Error: Invalid Username / Password </span><br/><br/>"
            End If
        Catch ex As Exception
            ltMessage.Text = "<br/><span class='alert alert-danger'>Error: " & ex.Message & "</span><br/><br/>"
        End Try
    End Sub
End Class