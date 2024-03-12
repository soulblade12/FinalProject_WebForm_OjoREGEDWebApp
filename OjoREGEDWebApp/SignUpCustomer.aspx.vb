Imports OjoREGED.BLL.DTOs

Public Class CustomerRegistration
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs)
        Try
            Dim _customerbll As New OjoREGED.BLL.CustomerBLL
            Dim _Customer As New CustomerCreateDTO
            _Customer.First_Name = FirstName.Text
            _Customer.Middle_Name = MiddleName.Text
            _Customer.Last_Name = LastName.Text
            _Customer.Telephone = Telp.Text
            _Customer.Email_Address = Emailadr.Text
            _Customer.Username = Username.Text
            _Customer.Password = exampleInputPassword.Text
            _Customer.RePassword = exampleRepeatPassword.Text
            _customerbll.InsertCustomer(_Customer)
            Response.Redirect("LoginPage.aspx")
            ltMessage.Text = "<span class='alert alert-success'>User Registration Success</span><br/><br/>"
        Catch ex As Exception
            ltMessage.Text = "<span class='alert alert-danger'>Error: " & ex.Message & "</span><br/><br/>"
        End Try
    End Sub
End Class