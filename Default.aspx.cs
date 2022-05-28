using System;
using System.Web.UI;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using MySql.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Appointment_System_and_Venue_Reservation
{
    public partial class _Default : Page
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_data();
              
            }
        }

        void load_data()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from event", con);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);

            using (DataTable dt = new DataTable())
            {
                d.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("event.aspx");
        }
    }
}