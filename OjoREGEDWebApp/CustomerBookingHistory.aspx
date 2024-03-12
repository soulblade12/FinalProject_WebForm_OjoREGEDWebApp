<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CustomerBookingHistory.aspx.vb" Inherits="OjoREGEDWebApp.CustomerBookingHistory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-12 grid-margin stretch-card">
            <div class="card">
                <div class="card-body">
                    <p class="card-title mb-0">History Booking</p>
                    <div class="table-responsive">
                        <table class="table table-striped table-borderless">
                            <asp:ListView runat="server" ID="LvOrder">
                                <LayoutTemplate>
                                    <thead>
                                        <tr>
                                            <th>Time_Placed</th>
                                            <th>Weight</th>
                                            <th>Size</th>
                                            <th>Order_Instruction</th>
                                            <th>Order_Status</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr id="itemPlaceholder" runat="server"></tr>
                                    </tbody>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr>
                                        <td><%# Eval("Time_Placed") %></td>
                                        <td><%# Eval("OrderDetails.Weight") %></td>
                                        <td><%# Eval("OrderDetails.Size") %></td>
                                        <td><%# Eval("OrderDetails.Order_Instruction") %></td>
                                        <td><%# Eval("OrderDetails.Order_Status") %></td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
