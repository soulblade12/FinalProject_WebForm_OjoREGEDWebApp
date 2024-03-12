<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="SubscriptionControl.aspx.vb" Inherits="OjoREGEDWebApp.SubscriptionControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-lg-12">
        <!-- Basic Card Example -->
        <div class="card shadow mb-4">
            <asp:Literal ID="ltMessage" runat="server" />

            <div class="card-header py-3">
                <h6 class="m-0 font-weight-bold text-primary">List Employee :</h6>
            </div>
            <div class="card-body">
                <div class="col-lg-12">
                    <div class="form-group row">
                        <div class="col-lg-12 mb-3 mt-3">
                            <label for="Customer_ID" class="form-label">Customer ID :</label>
                            <asp:TextBox ID="Customer_ID" runat="server" CssClass="form-control" ReadOnly="true" />
                        </div>
                        <%--                        <div class="col-lg-3 mb-3">
                            <label for="txtCustomerMiddlename" class="form-label">Middle Name :</label>
                            <asp:TextBox ID="txtCustomerMiddlename" runat="server" CssClass="form-control" />
                        </div>--%>
                        <asp:DropDownList ID="ddSubscription" runat="server"
                            AppendDataBoundItems="true"
                            CssClass="form-control">
                            <asp:ListItem Selected="True">-- Select Subscription --</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <hr />
                    <asp:Button ID="btnUpdateSubs" Text="Edit" CssClass="btn btn-primary" runat="server" OnClick="btnUpdateSubs_Click" />&nbsp;
                </div>


            </div>
        </div>
        <div class="card shadow mb-4"></div>
    </div>
</asp:Content>
