Imports OjoREGED.BLL.DTOs

Public Class SubscriptionControl
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim _CustomerBLL As New OjoREGED.BLL.CustomerBLL
            Dim _SubsBLL As New OjoREGED.BLL.SubscriptionLevelBLL
            Dim _subs = _SubsBLL.GetAllSubs()
            ddSubscription.DataSource = _subs
            ddSubscription.DataTextField = "Name"
            ddSubscription.DataValueField = "Subscription_ID"
            ddSubscription.DataBind()

            If Session("User") IsNot Nothing Then
                Dim _userDto As IEnumerable(Of CustomerLoginDTO) = Session("User")
                Dim _userDtos As CustomerLoginDTO = _userDto.FirstOrDefault()
                Customer_ID.Text = _userDtos.Customer_ID


            End If
        End If
    End Sub

    Protected Sub btnUpdateSubs_Click(sender As Object, e As EventArgs)
        Dim _SubsBLL As New OjoREGED.BLL.SubscriptionLevelBLL
        Dim selectedSubscriptionID As Integer = Convert.ToInt32(ddSubscription.SelectedValue)
        _SubsBLL.UpdateSubscription(selectedSubscriptionID, Customer_ID.Text)
        Response.Redirect("CustomerHomePage.aspx")
    End Sub
End Class