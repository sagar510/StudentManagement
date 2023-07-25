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
    public partial class WebForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HN3JSUR;Initial Catalog=smsmini;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/usersignup.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand(@"SELECT [Full Name]
      ,[Date of Birth]
      ,[Contact No]
      ,[Email ID]
      ,[State]
      ,[City]
      ,[Pin Code]
      ,[Full Address]
      ,[User ID]
      ,[Password]
  FROM [dbo].[usersignup] where [User ID]='"+TextBox1.Text+"' and [Password]='"+TextBox2.Text+"' ", con);

            try {

                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    Session["user"] = TextBox1.Text;
                    Session["user_cpy"] = TextBox1.Text;

                    if (TextBox1.Text == "Principal")
                    {
                        Response.Redirect("~/studentmanagement.aspx");
                    }
                    else
                    {
                        Response.Redirect("~/Default.aspx");
                    }
                }
                else {
                    Response.Write("<script>alert('Invalid or Mismatch Credentials')</script>");
                }



                con.Close();
            
            
            }
            catch(Exception exception)
            {

                Response.Write("<script>alert('"+exception.Message.ToString()+"')</script>");
            }
        }
    }
}