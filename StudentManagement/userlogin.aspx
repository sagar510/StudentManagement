<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="StudentManagement.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img class="rounded-circle" src="images/Login.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h3>Student Login</h3>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <label>Student ID</label>
                                <div class="mb-3">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Student ID"></asp:TextBox>
                                </div>
                                <label>Password</label>
                                <div class="mb-3">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                </div>
                                <div class="mb-3 d-grid gap-2">
                                    <asp:button class="btn btn-success btn-lg" id="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                                </div>
                                <a href="usersignup.aspx">
                                <div class="mb-3 d-grid gap-2">
                                    <asp:button class="btn btn-primary btn-lg" id="Button2" runat="server" Text="Sign Up" OnClick="Button2_Click" />
                                </div>
                                </a>
                            </div>
                        </div>
                    </div>
                </div>

                <a style="text-decoration:none" href="homepage.aspx"><< Back to Home</a><br /><br />
            </div>
        </div>
    </div>

</asp:Content>