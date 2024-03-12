<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="EmployeeDetails.aspx.vb" Inherits="OjoREGEDWebApp.EmployeeDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="d-sm-flex align-items-center justify-content-between mb-4">
            <h1 class="h3 mb-0 text-gray-800">Admin View</h1>
        </div>

        <div class="col-lg-12">
            <!-- Basic Card Example -->
            <div class="card shadow mb-4">
                <asp:Literal ID="ltMessage" runat="server" />
  
                <div class="card-header py-3">
                    <h6 class="m-0 font-weight-bold text-primary">List Employee :</h6>
                </div>
                <div class="card-body">
                    <div class="col-lg-6">
                        <div class="mb-3 mt-3 ">
                            <label for="txtEmployeeFirstname" class="form-label">First Name :</label>
                            <asp:TextBox ID="txtEmployeeFirstname" runat="server" CssClass="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="txtEmployeeMiddleName" class="form-label">Middle Name :</label>
                            <asp:TextBox ID="txtEmployeeMiddleName" runat="server" CssClass="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="txtEmployeeLastName" class="form-label">Last Name :</label>
                            <asp:TextBox ID="txtEmployeeLastName" runat="server" CssClass="form-control" />
                        </div>
                        <div class="mb-3">
                            <label for="txtEmployeeTelp" class="form-label">Telephone :</label>
                            <asp:TextBox ID="txtEmployeeTelp" runat="server" CssClass="form-control" />
                        </div>
                        <asp:Button ID="btnUpdate" Text="Edit" CssClass="btn btn-primary" runat="server" OnClick="btnUpdate_Click" />&nbsp;
                            <asp:Button ID="btnDelete" Text="Delete" CssClass="btn btn-danger" runat="server" OnClick="btnDelete_Click" />
                        <%--<asp:Button ID="btnSave" Text="Save" CssClass="btn btn-success" Enabled="false" runat="server" OnClick="btnSave_Click" />--%>&nbsp;
                   
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
