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
    public partial class usermanagement : System.Web.UI.Page
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HN3JSUR;Initial Catalog=smsmini;Integrated Security=True");


        protected void Page_Load(object sender, EventArgs e)
        {

            refresh();

        }

        public void refresh()
        {
            SqlCommand cmd2 = new SqlCommand(@"SELECT [Full Name]
      ,[Date of Birth]
      ,[Contact No]
      ,[Email ID]
      ,[User ID]     
  FROM [dbo].[usersignup]
", con);

            con.Open();
            GridView1.DataSource = cmd2.ExecuteReader();
            GridView1.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand(@"SELECT [Full Name]
      ,[Date of Birth]
      ,[Contact No]
      ,[Email ID]
      ,[State]
      ,[City]
      ,[Pin Code]
      ,[Full Address]
      ,[User ID]
      ,[Password]
  FROM [dbo].[usersignup] where [User ID]='" + TextBox1.Text + "'", con);


            con.Open();

            SqlDataReader sdr = cmd1.ExecuteReader();
            if (sdr.HasRows)
            {
                sdr.Read();
                TextBox2.Text = sdr["Full Name"].ToString();
                
                Label1.Text = "Data Found";
               
            }
            else
            {
                TextBox2.Text = "";
                Label1.Text = "No Such Data Found";
            }

            con.Close();


        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            SqlCommand cmd2 = new SqlCommand(@"DELETE FROM [dbo].[usersignup] WHERE [User ID] = '"+TextBox1.Text+"' ", con);

            try
            {
                con.Open();
                

                

                cmd2.ExecuteNonQuery();

                con.Close();

                refresh();

                //Response.Write("<script>alert('Deleted Sucessfully')</script>");

                TextBox1.Text = null;
                TextBox2.Text = null;
                Label1.Text = "Deleted Sucessfully";

            }
            catch(Exception exception)
            {
                Response.Write("<script>alert('"+exception.Message+"');</script>");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Session["user"] = TextBox1.Text;
            Session["user_cpy"] = TextBox1.Text;
            Response.Redirect("~/userprofile.aspx");
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HN3JSUR;Initial Catalog=smsmini;Integrated Security=True");
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
           ('" + TextBox2.Text + "','','','','','','','','" + TextBox1.Text + "','Password')", con);


            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                Label1.Text = "Added Sucessfully";
                refresh();
                TextBox1.Text = "";
                TextBox2.Text = "";
            }
            catch(Exception exception)
            {
                Label1.Text = exception.ToString();
            }

            
        }
    }
}