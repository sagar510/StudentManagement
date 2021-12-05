<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="teachermanagement.aspx.cs" Inherits="StudentManagement.loginmanagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="container">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Teacher Management</h4>
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" height="100px" class="rounded-circle" src="images/usermanagement.jpg" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <label>User ID</label>
                                <div class="mb-3">
                                    <div class="input-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>
                                    <asp:Button class="btn btn-primary" ID="Button1" runat="server" Text="Go" />
                                    </div>
                                </div>
                            </div>
                            <div class="col-md-8">
                                <label>User Name</label>
                                <div class="mb-3">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="User Name"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-4">
                                <div  class="mb-3 d-grid gap-2">
                                <asp:Button ID="Button2" class="btn btn-success btn-lg" runat="server" Text="Add" />
                                </div>
                            </div>
                            <div class="col-4">
                                <div  class="mb-3 d-grid gap-2">
                                <asp:Button ID="Button3" class="btn btn-warning btn-lg" runat="server" Text="Update" />
                                </div>
                            </div>
                            <div class="col-4">
                                <div  class="mb-3 d-grid gap-2">
                                <asp:Button ID="Button4" class="btn btn-danger btn-lg" runat="server" Text="Delete" />
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <a style="text-decoration:none" href="homepage.aspx"><< Back to Home</a><br /><br />
            </div>

            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Teacher List</h4>
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
                                <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server"></asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
