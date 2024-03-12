<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="HomePage.aspx.vb" Inherits="OjoREGEDWebApp.HomePage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="d-sm-flex align-items-center justify-content-between mb-4">
            <h1 class="h3 mb-0 text-gray-800">Admin View</h1>
        </div>

        <div class="col-lg-12">
            <!-- Basic Card Example -->
            <div class="card shadow mb-4">
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">List Employee :</h6>
                </div>
                <div class="card-body">
                    <table class="table table-hover">
                        <asp:ListView runat="server" ID="LvEmployee" OnSelectedIndexChanged="LvEmployee_SelectedIndexChanged" OnSelectedIndexChanging="LvEmployee_SelectedIndexChanging" DataKeyNames="Employee_ID">
                            <LayoutTemplate>
                                <thead>
                                    <tr>
                                        <th>First Name</th>
                                        <th>Middle Name</th>
                                        <th>Last Name</th>
                                        <th>Telephone</th>
                                        <th></th>
                                        <!-- Column for the Select button -->
                                    </tr>
                                </thead>
                                <tbody>
                                    <tr id="itemPlaceholder" runat="server"></tr>
                                </tbody>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr>
                                    <td><%# Eval("First_Name") %></td>
                                    <td><%# Eval("Middle_Name") %></td>
                                    <td><%# Eval("Last_Name") %></td>
                                    <td><%# Eval("Telephone") %></td>
                                    <td>
                                        <asp:LinkButton ID="lnkSelect" Text="Select" runat="server" CssClass="btn btn-primary btn-sm" CommandName="Select" />
                                    </td>
                                    <td>
                                        <asp:LinkButton ID="lnkDelete" Text="Delete" runat="server" CssClass="btn btn-danger btn-sm" CommandName="Delete"  OnClientClick="return confirm('Are you sure you want to delete this employee?');" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                        </asp:ListView>
                    </table>
                </div>
            </div>

        </div>
    </div>

</asp:Content>
