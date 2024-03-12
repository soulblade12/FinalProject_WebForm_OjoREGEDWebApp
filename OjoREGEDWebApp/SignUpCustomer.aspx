<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="SignUpCustomer.aspx.vb" Inherits="OjoREGEDWebApp.CustomerRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>Skydash Admin</title>
    <!-- plugins:css -->
    <link rel="stylesheet" href="assets/skydash/vendors/feather/feather.css">
    <link rel="stylesheet" href="assets/skydash/vendors/ti-icons/css/themify-icons.css">
    <link rel="stylesheet" href="assets/skydash/vendors/css/vendor.bundle.base.css">
    <!-- endinject -->
    <!-- Plugin css for this page -->
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <link rel="stylesheet" href="assets/skydash/css/vertical-layout-light/style.css">
    <!-- endinject -->
    <link rel="shortcut icon" href="assets/skydash/images/favicon.png" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="row justify-content-center">
            <div class="col-xl-10 col-lg-12 col-md-9">
                <div class="card border-0 shadow-lg my-5 rounded-4">
                    <div class="content-wrapper d-flex align-items-center auth px-0">
                        <div class="row w-100 mx-0 auth-form-light rounded-4">
                            <div class="col-lg-6 d-none d-lg-block bg-register-image">
                                 <img src="assets/img/Asset1.svg" alt="Alternate Text" />
                            </div>
                            <div class="col-lg-6 ">
                                <div class="auth-form-light text-left py-2 px-4 px-sm-5">
                                    <div class="brand-logo">
                                       <img src="assets/img/OjoregedLogo.png" alt="logo">
                                    </div>
                                    <asp:Literal ID="ltMessage" runat="server" />
                                    <h4>Hello! let's get started</h4>
                                    <h6 class="font-weight-light">Sign in to continue.</h6>
                                    <form class="user">
                                        <div class="form-group row">
                                            <div class="col-sm-12 mb-3 mb-sm-0">
                                                <asp:TextBox runat="server" ID="Username" CssClass="form-control form-control-user" placeholder="Username" />
                                            </div>
                                            <div class="col-sm-6 mb-3 mb-sm-0 mt-3">
                                                <asp:TextBox runat="server" ID="FirstName" CssClass="form-control form-control-user" placeholder="First Name" />
                                                <%--   <input type="text" class="form-control form-control-user" id="FirstName"
                                   placeholder="First Name">--%>
                                            </div>
                                            <div class="col-sm-6 mb-3 mb-sm-0 mt-3">
                                                <%--  <input type="text" class="form-control form-control-user" id="MiddleName"
                                   placeholder="Middle Name">--%>
                                                <asp:TextBox runat="server" ID="MiddleName" CssClass="form-control form-control-user" placeholder="Middle Name" />
                                            </div>
                                            <div class="col-sm-6 mt-3">
                                                <asp:TextBox runat="server" ID="LastName" CssClass="form-control form-control-user" placeholder="Last Name" />
                                            </div>
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox runat="server" ID="Telp" CssClass="form-control form-control-user" placeholder="Telephone" />
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox runat="server" ID="Emailadr" CssClass="form-control form-control-user" placeholder="Email address" />
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox runat="server" type="password" ID="exampleInputPassword" CssClass="form-control form-control-user" placeholder="Password" />
                                        </div>
                                        <div class="form-group">
                                            <asp:TextBox runat="server" type="password" ID="exampleRepeatPassword" CssClass="form-control form-control-user" placeholder="Re-Password" />
                                        </div>
                                        <asp:Button Text="Register Account" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" CssClass="btn btn-primary" />
                                    </form>
                                </div>
                            </div>

                        </div>
                    </div>
                    <!-- content-wrapper ends -->
                </div>
                <!-- page-body-wrapper ends -->
            </div>
        </div>
    </form>
</body>
</html>
