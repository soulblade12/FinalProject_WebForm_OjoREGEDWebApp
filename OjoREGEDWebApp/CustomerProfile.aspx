<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="CustomerProfile.aspx.vb" Inherits="OjoREGEDWebApp.CustomerProfile" %>

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
                            <label for="txtCustomerFirstname" class="form-label">First Name :</label>
                            <asp:TextBox ID="txtCustomerFirstname" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-lg-3 mb-3">
                            <label for="txtCustomerMiddlename" class="form-label">Middle Name :</label>
                            <asp:TextBox ID="txtCustomerMiddlename" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-lg-3 mb-3">
                            <label for="txtCustomerLastName" class="form-label">Last Name :</label>
                            <asp:TextBox ID="txtCustomerLastName" runat="server" CssClass="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="txtCustomerTelp" class="form-label">Telephone :</label>
                            <asp:TextBox ID="txtCustomerTelp" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                    <hr />
                    <div class="form-group row">
                        <div class="col-lg-12 mb-3 mt-3 ">
                            <label for="CustomerProvince" class="form-label">Province :</label>
                            <asp:TextBox ID="CustomerProvince" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-lg-3 mb-3">
                            <label for="CustomerCity" class="form-label">City :</label>
                            <asp:TextBox ID="CustomerCity" runat="server" CssClass="form-control" />
                        </div>

                        <div class="col-lg-3">
                            <label for="CustomerPostalCode" class="form-label">Postal Code :</label>
                            <asp:TextBox ID="CustomerPostalCode" runat="server" CssClass="form-control" />
                        </div>
                        <div class="col-lg-6 mb-3">
                            <label for="CustomerStreetAddress" class="form-label">Street Address :</label>
                            <asp:TextBox ID="CustomerStreetAddress" runat="server" CssClass="form-control" />
                        </div>
                    </div>
                    <asp:Button ID="btnUpdate" Text="Edit" CssClass="btn btn-primary" runat="server" OnClick="btnUpdate_Click" />&nbsp;
                </div>


            </div>
        </div>
        <div class="card shadow mb-4"></div>
    </div>
    
</asp:Content>
