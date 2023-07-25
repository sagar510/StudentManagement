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
    public partial class WebForm6 : System.Web.UI.Page
    {
        
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HN3JSUR;Initial Catalog=smsmini;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (Session["user_cpy"]!=null)
            {

                SqlCommand cmd = new SqlCommand(@"SELECT * FROM [dbo].[usersignup] where [User ID]='"+Session["user"]+"'", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    //Console.WriteLine(sdr["username"] + "   " + sdr["email"]);
                    TextBox1.Text = sdr["Full Name"].ToString();
                    TextBox2.Text = sdr["Date of Birth"].ToString();
                    TextBox3.Text = sdr["Contact No"].ToString();
                    TextBox4.Text = sdr["Email ID"].ToString();
                    DropDownList1.SelectedValue = sdr["State"].ToString();
                    TextBox6.Text = sdr["City"].ToString();
                    TextBox7.Text = sdr["Pin Code"].ToString();
                    TextBox5.Text = sdr["Full Address"].ToString();
                    TextBox8.Text = sdr["User ID"].ToString();
                    TextBox9.Text = sdr["Password"].ToString();
                    //TextBox2.Text = sdr["Date of Birth"].ToString();


                }

                con.Close();
                
                
                Session["user_cpy"] = null;

            }
        }

        

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd2 = new SqlCommand(@"UPDATE [dbo].[usersignup]
   SET [Full Name] = '" + TextBox1.Text + "',[Date of Birth] = '" + TextBox2.Text + "',[Contact No] = '" + TextBox3.Text + "',[Email ID] = '" + TextBox4.Text + "',[State] = '" + DropDownList1.Text + "',[City] = '" + TextBox6.Text + "',[Pin Code] = '" + TextBox7.Text + "',[Full Address] = '" + TextBox5.Text + "',[Password] = '" + TextBox10.Text + "' WHERE [User ID]='" + Session["user"] + "'"
    , con);

                

                


                  TextBox9.Text = TextBox10.Text;

                con.Open();
                cmd2.ExecuteNonQuery();
                con.Close();

                Response.Write("<script>alert('Updated Sucessfully');</script>");
            }catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }


        }
    }
}