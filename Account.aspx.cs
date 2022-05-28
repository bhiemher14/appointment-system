using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using MySql.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Appointment_System_and_Venue_Reservation
{
    public partial class Account : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
          
            if (!IsPostBack)
            {
            TextBox1.Text = Session["firstname"].ToString();
            TextBox2.Text = Session["lastname"].ToString();
            TextBox3.Text = Session["username"].ToString();
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "")
            {
                Response.Write("<script>alert('Please complete the input before submitting it.');</script>");
                TextBox1.Text = Session["firstname"].ToString();
                TextBox2.Text = Session["lastname"].ToString();
                TextBox3.Text = Session["username"].ToString();
            }
                else
                {
                    con.Open();

                    MySqlCommand cmd = new MySqlCommand("UPDATE user SET firstname = @firstname, lastname = @lastname, username = @username WHERE id = @id", con);

                    cmd.Parameters.AddWithValue("@id", Session["id"].ToString());
                    cmd.Parameters.AddWithValue("@firstname", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@lastname", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@username", TextBox3.Text);
                    cmd.ExecuteNonQuery();
                    loadSessions();

                }
           
        }
        public void loadSessions()
        {
            TextBox1.Text = Session["firstname"].ToString();
            TextBox2.Text = Session["lastname"].ToString();
            TextBox3.Text = Session["username"].ToString();
        }
    }

}