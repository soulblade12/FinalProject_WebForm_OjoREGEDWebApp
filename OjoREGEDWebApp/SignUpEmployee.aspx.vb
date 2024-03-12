Imports OjoREGED.BLL.DTOs

Public Class SignUpEmployee
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnSubmit_Click(sender As Object, e As EventArgs)
        Try
            Dim _employeeBLL As New OjoREGED.BLL.EmployeeBLL
            Dim _employee As New CreateEmployeeDTO
            _employee.First_Name = FirstName.Text
            _employee.Middle_Name = MiddleName.Text
            _employee.Last_Name = LastName.Text
            _employee.Telephone = Telp.Text
            _employee.Username = Username.Text
            _employee.Password = exampleInputPassword.Text
            _employee.RePassword = exampleRepeatPassword.Text
            _employeeBLL.Insertemployee(_employee)
            Response.Redirect("HomePage.aspx")
        Catch ex As Exception
            ltMessage.Text = "<span class='alert alert-danger'>Error: " & ex.Message & "</span><br/><br/>"
        End Try
    End Sub
End Class