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
    public partial class Change_Pass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void ChangePassword1_ChangedPassword(object sender, EventArgs e)
        {
            //if CurrentPassword.text = Session["password"]
            //    {

            //}
        }

        protected void CancelPushButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void ChangePasswordPushButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}