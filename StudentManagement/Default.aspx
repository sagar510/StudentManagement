<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentManagement.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <img src="images/HomeBannerJPEG.jpg" class="img-fluid"/>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                    <h2>Our Features</h2>
                    </center>
                </div>
            </div>
            <div class="row">
                <div class="col-md-4">
                    <center>
                    <a href="timetable.aspx"><img width="150px" height="150px" src="images/TimeTable.jpg" /></a>
                    <h4>Time Table</h4>
                    <p class="text-monospace">Check subjects and time slots assigned to each day of week. Just click on the image.</p>
                    </center>
                </div>
                <div class="col-md-4">
                    <center>
                    <a href="attendance.aspx"><img width="150px" src="images/Attendance.jpg" /></a>
                    <h4>Attendence</h4>
                    <p class="text-monospace">Check your attendence and know the consistency. Just click on the image.</p>
                    </center>
                </div><div class="col-md-4">
                    <center>
                    <a href="results.aspx"><img width="150px" src="images/Results.png" /></a>
                    <h4>Results</h4>
                    <p class="text-monospace">Check your results and know your performance efficiency. Just click on the image.</p>
                    </center>
                </div>
            </div>
        </div>
    </section>
     <section>
         <img src="images/HomeBannerJPEG1.jpg" class="img-fluid"/>
    </section>
    <section>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <center>
                    <h2>Our Process</h2>
                    </center>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <center>
                    <a href="usersignup.aspx"><img width="175px" height="150px" src="images/SignUp.png" /></a>
                    <h4>Sign Up</h4>
                    <p class="text-monospace">Sign Up for better experience and additional facility. Just click on the image.</p>
                    </center>
                </div>
                <div class="col-md-6">
                    <center>
                    <a href="userprofile.aspx"><img width="150px" src="images/UpdateProfile.png" /></a>
                    <h4>Update Profile</h4>
                    <p class="text-monospace">Add more information to your profile to be recognized easily. Just click on the image.</p>
                    </center>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
