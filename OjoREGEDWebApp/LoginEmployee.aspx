<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="LoginEmployee.aspx.vb" Inherits="OjoREGEDWebApp.LoginEmployee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- Required meta tags -->
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <title>OjoREGED</title>
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



        <div class="container-scroller">
            <div class="container-fluid page-body-wrapper full-page-wrapper">
                <div class="content-wrapper d-flex align-items-center auth px-0">
                    <div class="row w-100 mx-0">
                        <div class="col-lg-4 mx-auto">
                            <div class="auth-form-light text-left py-5 px-4 px-sm-5">
                                <div class="brand-logo">
                                    <img src="assets/img/OjoregedLogo.png" alt="logo">
                                </div>
                                <h4>New here?</h4>
                                <h6 class="font-weight-light">Signing up is easy. It only takes a few steps</h6>
                                <form class="pt-3">
                                    <div class="form-group">
                                        <asp:TextBox ID="txtUsername" placeholder="Enter Username..." CssClass="form-control form-control-user" runat="server" />
                                    </div>
                                    <div class="form-group">
                                        <asp:TextBox ID="txtPassword" TextMode="Password"
                                            CssClass="form-control form-control-user" placeholder="Password" runat="server" />
                                    </div>
                                    <div class="form-group">
                                        <div class="custom-control custom-checkbox small">
                                            <input type="checkbox" class="custom-control-input" id="customCheck" />
                                            <label class="custom-control-label" for="customCheck">
                                                Remember
                                                          Me</label>
                                        </div>
                                    </div>
                                    <asp:Button ID="btnLoginEmp" OnClick="btnLoginEmp_Click"
                                        Text="Login" CssClass="btn btn-primary btn-user btn-block" runat="server" />
                                    <asp:Literal ID="ltMessage" runat="server" />
                                    <hr />
                                    <a href="#" class="btn btn-google btn-user btn-block">
                                        <i class="fab fa-google fa-fw"></i>Login with Google
                                    </a>
                                    <a href="#" class="btn btn-facebook btn-user btn-block">
                                        <i class="fab fa-facebook-f fa-fw"></i>Login with Facebook
                                    </a>

                                    <hr />
                                    <div class="text-center">
                                        <a class="small" href="forgot-password.html">Forgot Password?</a>
                                    </div>
                                    <div class="text-center">
                                        <a class="small" href="register.html">Create an Account!</a>
                                    </div>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- content-wrapper ends -->
            </div>
            <!-- page-body-wrapper ends -->
        </div>
        <!-- container-scroller -->
        <!-- plugins:js -->
        <script src="assets/skydash/vendors/js/vendor.bundle.base.js"></script>
        <!-- endinject -->
        <!-- Plugin js for this page -->
        <!-- End plugin js for this page -->
        <!-- inject:js -->
        <script src="assets/skydash/js/off-canvas.js"></script>
        <script src="assets/skydash/js/hoverable-collapse.js"></script>
        <script src="assets/skydash/js/template.js"></script>
        <script src="assets/skydash/js/settings.js"></script>
        <script src="assets/skydash/js/todolist.js"></script>
    </form>
</body>
</html>
