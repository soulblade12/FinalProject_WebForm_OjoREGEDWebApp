Imports OjoREGED.BLL

Public Class HomePage
    Inherits System.Web.UI.Page

#Region "Data Bind"
    Sub LoadAllEmployee()
        Dim _getDLL As New EmployeeBLL
        Dim hasil = _getDLL.GetAllEmployee()
        LvEmployee.DataSource = hasil
        LvEmployee.DataBind()
    End Sub
#End Region

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            LoadAllEmployee()
        End If

    End Sub

    Protected Sub LvEmployee_SelectedIndexChanged(sender As Object, e As EventArgs)


        Dim selectedIndex As Integer = LvEmployee.SelectedIndex
        Dim selectedDataKey As Integer = Convert.ToInt32(LvEmployee.DataKeys(selectedIndex).Value)
        'lblSelectedEmployeeID.Text = "Selected Employee ID: " & selectedDataKey.ToString()
        Response.Redirect("EmployeeDetails.aspx?empId=" & selectedDataKey.ToString())

    End Sub

    Protected Sub LvEmployee_SelectedIndexChanging(sender As Object, e As ListViewSelectEventArgs)

    End Sub

    Protected Sub LvEmployee_ItemDeleting(sender As Object, e As ListViewDeleteEventArgs) Handles LvEmployee.ItemDeleting
        ' Handle the item deleting event here if needed
        ' For example, you can retrieve the ID of the item being deleted and perform any necessary actions
        Dim empID As Integer = Convert.ToInt32(LvEmployee.DataKeys(e.ItemIndex).Value)
        Dim employeeBLL As New EmployeeBLL()
        employeeBLL.Delete(empID)
        LoadAllEmployee()
    End Sub
End Class