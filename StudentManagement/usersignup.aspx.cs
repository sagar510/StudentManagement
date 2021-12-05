using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagement
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-ROFH7UU1\SQLEXPRESS;Initial Catalog=smsmini;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[usersignup]
           ([Full Name]
           ,[Date of Birth]
           ,[Contact No]
           ,[Email ID]
           ,[State]
           ,[City]
           ,[Pin Code]
           ,[Full Address]
           ,[User ID]
           ,[Password])
     VALUES
           ('" + TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+ "','" + TextBox4.Text + "','"+DropDownList1.Text+"','"+TextBox6.Text+ "','" + TextBox7.Text + "','" + TextBox5.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "')", con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            

            Response.Write("<script>alert('Signup Sucessfully')</script>");
            Response.Redirect("~/userlogin.aspx");
        }
    }
}