<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CustomerStartBooking.aspx.vb" Inherits="OjoREGEDWebApp.CustomerStartBooking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
 <div class="col-lg-12">
    <!-- Basic Card Example -->
    <div class="card shadow mb-4">
        <asp:Literal ID="ltMessage" runat="server" />

        <div class="card-header py-3">
            <h6 class="m-0 font-weight-bold text-primary">Add Booking :</h6>
        </div>
        <div class="card-body">
            <div class="table-responsive"> <!-- Added table-responsive to make the table horizontally scrollable if needed -->
                <table class="table table-hover">
                    <asp:ListView runat="server" ID="LvEmployee">
                        <LayoutTemplate>
                            <thead>
                                <tr>
                                    <th>First Name</th>
                                    <th>Last Name</th>
                                    <th>Telephone</th>
                                    <th>Status</th>
                                    <th>Date</th>
                                    <th>City</th>
                                    <th>Postal Code</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr id="itemPlaceholder" runat="server"></tr>
                            </tbody>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr>
                                <td><%# Eval("First_Name") %></td>
                                <td><%# Eval("Last_Name") %></td>
                                <td><%# Eval("Telephone") %></td>
                                <td><%# Eval("EmployeeSchedules.Status") %></td>
                                <td><%# Eval("EmployeeSchedules.Date") %></td>
                                <td><%# Eval("EmployeeLocations.City") %></td>
                                <td><%# Eval("EmployeeLocations.Postal_Code") %></td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                </table>
            </div>

            <div class="row mt-3">
                <div class="col-lg-3 mb-3">
                    <label for="txtWeight" class="form-label">Weight :</label>
                    <asp:TextBox ID="txtWeight" runat="server" CssClass="form-control" TextMode="Number" />
                </div>

                <div class="col-lg-12 mb-3">
                    <label for="txtOrderInstruction" class="form-label">Order Instruction :</label>
                    <asp:TextBox ID="txtOrderInstruction" runat="server" CssClass="form-control" />
                </div>
                <div class="col-lg-6 mb-3">
                    <label for="ddSize" class="form-label">Size :</label>
                    <asp:DropDownList ID="ddSize" runat="server" AppendDataBoundItems="true" CssClass="form-control">
                        <asp:ListItem Selected="True">-- Select Size --</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-6 mb-3">
                    <label for="ddemployeeschedule" class="form-label">Employee :</label>
                    <asp:DropDownList ID="ddemployeeschedule" runat="server" AppendDataBoundItems="true" CssClass="form-control">
                        <asp:ListItem Selected="True">-- Select Employee --</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="col-lg-12">
                    <asp:Button Text="Submit" runat="server" CssClass="btn btn-primary" ID="AddBook" OnClick="AddBook_Click"/>
                </div>
            </div>
        </div>
    </div>
</div>

</asp:Content>
