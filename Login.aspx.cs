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

    public partial class Login : System.Web.UI.Page
    {
        
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());

        private void myConn()
        {
            con.Close();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            myConn();
        }


        protected void btn_Login_Click1(object sender, EventArgs e)
        {
            try
            {
                if (txtUsername.Text != "" && txtPassword.Text != "")
                {
                    loginUser(txtUsername.Text, txtPassword.Text);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }

        }
        void loginUser(string username, string password)
        {
            string qry = "select * from user where username=@username and password=@password";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

           // MySqlDataReader sdr = cmd.ExecuteReader();
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);


            if (dt.Rows.Count > 0)
            {
                Session["id"] = dt.Rows[0]["id"].ToString();
                Session["firstname"] = dt.Rows[0]["firstname"].ToString();
                Session["lastname"] = dt.Rows[0]["lastname"].ToString();
                Session["username"] = dt.Rows[0]["username"].ToString();
                Session["password"] = dt.Rows[0]["password"].ToString();
                Session["secret_question"] = dt.Rows[0]["secret_question"].ToString();
                Session["secret_pass"] = dt.Rows[0]["secret_pass"].ToString();
                Session["user_type"] = dt.Rows[0]["user_type"].ToString();
                Session["is_deleted"] = dt.Rows[0]["is_deleted"].ToString();
                Session["is_active"] = dt.Rows[0]["is_active"].ToString();

                Response.Write(Session["user"]);
                Response.Redirect("Default.aspx");
                clear();

              
            }
            else
            {
                clear();
                Label1.Visible = true;
                Label1.Text = "UserId & Password Is not correct Try again..!!";
            }
        }

        void clear()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}