Imports OjoREGED.BLL.DTOs

Public Class Contact
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim _CustomerBLL As New OjoREGED.BLL.CustomerBLL
            Dim _SubscribeBLL As New OjoREGED.BLL.SubscriptionLevelBLL
            If Session("User") IsNot Nothing Then
                Dim _userDto As IEnumerable(Of CustomerLoginDTO) = Session("User")
                Dim _userDtos As CustomerLoginDTO = _userDto.FirstOrDefault()
                Dim customerData As IEnumerable(Of CustomerDTO) = _CustomerBLL.CustomerGetByID(_userDtos.Customer_ID)
                Dim subscriptionlvl As IEnumerable(Of SubscriptionLevelDTO) = _SubscribeBLL.GetAllSubs()
                'subs populate
                Dim firstSubscription As SubscriptionLevelDTO = subscriptionlvl.FirstOrDefault()
                Dim secondSubscription As SubscriptionLevelDTO = subscriptionlvl.ElementAtOrDefault(1)
                Dim thirdSubscription As SubscriptionLevelDTO = subscriptionlvl.Skip(2).FirstOrDefault()
                Dim fourthSubscription As SubscriptionLevelDTO = subscriptionlvl.Skip(3).FirstOrDefault()
                Dim fifthSubscription As SubscriptionLevelDTO = subscriptionlvl.Skip(4).FirstOrDefault()
                Dim sixthSubscription As SubscriptionLevelDTO = subscriptionlvl.Skip(5).FirstOrDefault()

                ' Check if customerData is not null and contains any items
                If customerData IsNot Nothing AndAlso customerData.Any() Then
                    Dim customerDatas As CustomerDTO = customerData.FirstOrDefault()
                    If customerDatas IsNot Nothing Then
                        ltUsername.Text = customerDatas.First_Name & " " & customerDatas.Last_Name
                        SubscriptionCustomerStatus.Text = customerDatas.SubcriptionsLevel.Name
                        Dim UserCitys = customerDatas.AddressesDTO.City
                        If UserCitys IsNot Nothing Then
                            UserCity.Text = UserCitys
                            profileCompletionDiv.Visible = False
                        Else
                            profileCompletionDiv.Visible = True
                            UserCity.Text = "none"
                        End If
                    End If
                End If

                lblFirstSubscriptionName.Text = firstSubscription.Name
                lblFirstSubscriptionPrice.Text = firstSubscription.Price.ToString()
                lblSecondSubscriptionName.Text = secondSubscription.Name
                lblSecondSubscriptionPrice.Text = secondSubscription.Price.ToString()
                lblThirdSubscriptionName.Text = thirdSubscription.Name
                lblThirdSubscriptionPrice.Text = thirdSubscription.Price.ToString()
                lblFourthSubscriptionName.Text = fourthSubscription.Name
                lblFourthSubscriptionName.Text = fourthSubscription.Price.ToString()
                lblFifthSubscriptionName.Text = fifthSubscription.Name
                lblFifthSubscriptionName.Text = fifthSubscription.Price.ToString()
                lblSixthSubscriptionName.Text = sixthSubscription.Name
                lblSixthSubscriptionPrice.Text = sixthSubscription.Price.ToString()
            End If
            'If Session("User") Is Nothing Then
            '    Response.Redirect("~/LandingPage.aspx")
            'End If
        End If
    End Sub

    Protected Sub Addaddress_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/CustomerProfile.aspx")
    End Sub

    Protected Sub SubsChoose_Click(sender As Object, e As EventArgs)
        Response.Redirect("~/SubscriptionControl.aspx")
    End Sub
End Class