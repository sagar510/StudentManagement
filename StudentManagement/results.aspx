<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="results.aspx.cs" Inherits="StudentManagement.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="100px" height="100px" src="images/Results.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                <h4>Results</h4>
                                </center>
                            </div> 
                        </div>
                        <div class="row">
                            <div class="col">
                                <hr />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-4">
                                <div class="mb-3 d-grid gap-2">
                                <asp:Button class="btn btn-primary btn-lg" ID="Button1" runat="server" Text="1st Semester" />
                                </div>
                            </div>
                            <div class="col-4">
                                <div class="mb-3 d-grid gap-2">
                                <asp:Button class="btn btn-info btn-lg" ID="Button2" runat="server" Text="2nd Semester" />
                                </div>
                            </div>
                            <div class="col-4">
                                <div class="mb-3 d-grid gap-2">
                                <asp:Button class="btn btn-primary btn-lg" ID="Button3" runat="server" Text="3rd Semester" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-4">
                                <div class="mb-3 d-grid gap-2">
                                <asp:Button class="btn btn-info btn-lg" ID="Button4" runat="server" Text="4th Semester" />
                                </div>
                            </div>
                            <div class="col-4">
                                <div class="mb-3 d-grid gap-2">
                                <asp:Button class="btn btn-primary btn-lg" ID="Button5" runat="server" Text="5th Semester" />
                                </div>
                            </div>
                            <div class="col-4">
                                <div class="mb-3 d-grid gap-2">
                                <asp:Button class="btn btn-info btn-lg" ID="Button6" runat="server" Text="6th Semester" />
                                </div>
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
                <a style="text-decoration:none" href="homepage.aspx"><< Back to Home</a><br /><br />
            </div>
        </div>
    </div>

</asp:Content>
