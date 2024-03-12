Imports OjoREGED.BLL.DTOs

Public Class CustomerProfile
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim _CustomerBLL As New OjoREGED.BLL.CustomerBLL
            If Session("User") IsNot Nothing Then
                Dim _userDto As IEnumerable(Of CustomerLoginDTO) = Session("User")
                Dim _userDtos As CustomerLoginDTO = _userDto.FirstOrDefault()
                Dim customerData As IEnumerable(Of CustomerDTO) = _CustomerBLL.CustomerGetByID(_userDtos.Customer_ID)
                Dim customerDatas As CustomerDTO = customerData.FirstOrDefault()
                'ltUsername.Text = customerDatas.First_Name & " " & customerDatas.Last_Name
                txtCustomerFirstname.Text = customerDatas.First_Name
                txtCustomerMiddlename.Text = customerDatas.Middle_Name
                txtCustomerLastName.Text = customerDatas.Last_Name
                txtCustomerTelp.Text = customerDatas.Telephone
                CustomerProvince.Text = customerDatas.AddressesDTO.Province
                CustomerStreetAddress.Text = customerDatas.AddressesDTO.Street_Address
                CustomerPostalCode.Text = customerDatas.AddressesDTO.Postal_Code
                CustomerCity.Text = customerDatas.AddressesDTO.City


            End If
        End If
    End Sub

    Protected Sub btnUpdate_Click(sender As Object, e As EventArgs)
        Dim _userDto As IEnumerable(Of CustomerLoginDTO) = Session("User")
        Dim _userDtos As CustomerLoginDTO = _userDto.FirstOrDefault()
        Dim _custAdr As New AddressesDTO With {
        .Customer_ID = CInt(_userDtos.Customer_ID),
        .Postal_Code = CustomerPostalCode.Text.ToString,
        .City = CustomerCity.Text.ToString,
        .Street_Address = CustomerStreetAddress.Text.ToString,
        .Province = CustomerProvince.Text.ToString
    }

        ' Update employee details
        Dim _CustBLL As New OjoREGED.BLL.CustomerBLL()
        _CustBLL.AddAddress(_custAdr)
        Response.Redirect("CustomerHomePage.aspx")
    End Sub
End Class