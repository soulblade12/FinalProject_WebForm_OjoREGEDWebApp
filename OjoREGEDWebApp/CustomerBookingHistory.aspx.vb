Imports OjoREGED.BLL.DTOs

Public Class CustomerBookingHistory
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim _CustomerBLL As New OjoREGED.BLL.CustomerBLL
            If Session("User") IsNot Nothing Then
                Dim _userDto As IEnumerable(Of CustomerLoginDTO) = Session("User")
                Dim _userDtos As CustomerLoginDTO = _userDto.FirstOrDefault()
                Dim _CustGetSch = _CustomerBLL.custGetOrderByCustomeromergetbyid(_userDtos.Customer_ID)
                LvOrder.DataSource = _CustGetSch
                LvOrder.DataBind()


            End If


        End If
    End Sub

End Class