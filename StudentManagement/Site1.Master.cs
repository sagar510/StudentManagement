using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"]!=null)
            {
                LinkButton7.Text = "Hello, "+Session["user"].ToString();
            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminlogin.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentmanagement.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("teachermanagement.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Session["user_cpy"] = Session["user"];
            Response.Redirect("userprofile.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            LinkButton7.Text = "Hello, User";
        }
    }
}