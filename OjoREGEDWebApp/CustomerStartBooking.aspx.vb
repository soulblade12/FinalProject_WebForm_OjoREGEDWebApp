Imports OjoREGED.BLL.DTOs

Public Class CustomerStartBooking
    Inherits System.Web.UI.Page
    Private Sub PopulateSizeDropDown()
        ' Define the array of sizes
        Dim sizes As String() = {"XS", "S", "M", "L", "XL"}

        ' Clear any existing items in the DropDownList
        ddSize.Items.Clear()

        ' Add the default item
        ddSize.Items.Add(New ListItem("-- Select Size --", ""))

        ' Add each size from the array to the DropDownList
        For Each size As String In sizes
            ddSize.Items.Add(New ListItem(size, size))
        Next
    End Sub
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim _CustomerBLL As New OjoREGED.BLL.CustomerBLL
            Dim _EmpBLL As New OjoREGED.BLL.EmployeeBLL
            Dim _empGetSch = _EmpBLL.GetDataEmployee()
            Dim _emp = _EmpBLL.GetAllEmployeeSchedule()
            LvEmployee.DataSource = _empGetSch
            LvEmployee.DataBind()
            ddemployeeschedule.DataSource = _emp
            ddemployeeschedule.DataTextField = "Employee_ID"
            ddemployeeschedule.DataValueField = "Employee_Schedule_ID"
            ddemployeeschedule.DataBind()




            If Session("User") IsNot Nothing Then
                PopulateSizeDropDown()

            End If

        End If
    End Sub

    Protected Sub AddBook_Click(sender As Object, e As EventArgs)
        Dim _custBLL As New OjoREGED.BLL.CustomerBLL

        Dim _userDto As IEnumerable(Of CustomerLoginDTO) = Session("User")
        Dim _userDtos As CustomerLoginDTO = _userDto.FirstOrDefault()
        Dim selectedemployeescheduleID As Integer = Convert.ToInt32(ddemployeeschedule.SelectedValue)
        Dim _custBook As New InsertBookingSP With {
        .Customer_ID = CInt(_userDtos.Customer_ID),
        .Size = ddSize.SelectedValue,
        .Weight = CInt(txtWeight.Text),
        .Order_Instruction = txtOrderInstruction.Text.ToString,
        .Employee_Schedule_ID = selectedemployeescheduleID
    }
        _custBLL.AddBooking(_custBook)
        Response.Redirect("CustomerHomePage.aspx")
    End Sub
End Class