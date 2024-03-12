Imports OjoREGED.BLL
Imports OjoREGED.BLL.DTOs

Public Class EmployeeDetails
    Inherits System.Web.UI.Page
#Region "Data Bind"
    'Sub LoadAllEmployee()
    '    Dim _getDLL As New EmployeeBLL
    '    Dim hasil = _getDLL.GetAllEmployee()
    '    LvEmployee.DataSource = hasil
    '    LvEmployee.DataBind()
    'End Sub
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ' Retrieve the employee ID from the query string
            Dim empID As Integer = Convert.ToInt32(Request.QueryString("empId"))

            ' Fetch the employee details from the database based on the ID
            Dim _getDLL As New EmployeeBLL
            Dim employeeDetails = _getDLL.GetEmployeesByID(empID)
            Dim firstEmployee = employeeDetails(0)
            ' Populate the TextBoxes with the retrieved employee details
            txtEmployeeFirstname.Text = firstEmployee.First_Name
            txtEmployeeMiddleName.Text = firstEmployee.Middle_Name
            txtEmployeeLastName.Text = firstEmployee.Last_Name
            txtEmployeeTelp.Text = firstEmployee.Telephone


        End If
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Try
            ' Retrieve the employee ID from the query string
            Dim empID As Integer = CInt(Request.QueryString("empId"))

            ' Create an EmployeeDTO object with updated details
            Dim _employee As New employeeDTO With {
        .Employee_ID = CInt(empID),
        .First_Name = txtEmployeeFirstname.Text.ToString,
        .Middle_Name = txtEmployeeMiddleName?.Text.ToString,
        .Last_Name = txtEmployeeLastName.Text.ToString,
        .Telephone = txtEmployeeTelp.Text.ToString
    }

            ' Update employee details
            Dim _employeeBLL As New OjoREGED.BLL.EmployeeBLL()
            _employeeBLL.Update(_employee)
            ltMessage.Text = "<span class='alert alert-success'>Artice updated successfully</span><br/><br/>"

            ' Redirect to homepage after successful update
            Response.Redirect("homepage.aspx")
        Catch ex As Exception
            ' Display error message if update fails
            ltMessage.Text = "<span class='alert alert-danger'>Error: " & ex.Message & "</span><br/><br/>"
        End Try

    End Sub

    Protected Sub btnDelete_Click(sender As Object, e As EventArgs)

    End Sub
End Class