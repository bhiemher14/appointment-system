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
    public partial class Users : Page
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
            
            MySqlCommand cmd = new MySqlCommand("Select id AS ID,firstname AS FIRSTNAME,lastname as LASTNAME,username AS USERNAME from user where user_type = 'Admin'", con);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);


            using (DataTable dt = new DataTable())
            {
                d.Fill(dt);
                userList.DataSource = dt;
                userList.DataBind();
            }
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string id = e.Row.Cells[0].Text;
                if (id == "1")
                {
                    TextBox txtusername = (e.Row.FindControl("username") as TextBox);
                    txtusername.Enabled = false;
                }
            }

            if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != userList.EditIndex)
            {
                (e.Row.Cells[0].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
            }
            

            

        }

        protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
           

           
             int id = Convert.ToInt32(userList.DataKeys[e.RowIndex].Values[0]);
           
            if (id == 1)
            {
                Response.Write("<script>alert('Cannot be deleted this default account.');</script>");
               
            }  
                else
                {
                   
                    con.Open();
                    MySqlCommand cmd = new MySqlCommand("delete FROM user where id=@id", con);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    load_data();

                }
        }



        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
           

              GridViewRow row = userList.Rows[e.RowIndex];
            int id = Convert.ToInt32(userList.DataKeys[e.RowIndex].Values[0]);

            string fname = (row.Cells[2].Controls[0] as TextBox).Text;
            string lname = (row.Cells[3].Controls[0] as TextBox).Text;
            string uname = (row.Cells[4].Controls[0] as TextBox).Text;
           
        
           
             con.Open();
             
            MySqlCommand cmd = new MySqlCommand("UPDATE user SET firstname = @firstname, lastname = @lastname, username = @username WHERE id = @id", con);

            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@firstname", fname);
            cmd.Parameters.AddWithValue("@lastname", lname);
            cmd.Parameters.AddWithValue("@username", uname);
           
           
            cmd.ExecuteNonQuery();
            con.Close();
            
            
            userList.EditIndex = -1;
            this.load_data();
        }
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            userList.EditIndex = e.NewEditIndex;
            this.load_data();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            userList.EditIndex = -1;
            this.load_data();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Insert INTO user (firstname,lastname,username,user_type) VALUES (@firstname,@lastname,@username,@user_type) ", con);
            
           
            cmd.Parameters.AddWithValue("@firstname", TextBox1.Text);
            cmd.Parameters.AddWithValue("@lastname", TextBox2.Text);
            cmd.Parameters.AddWithValue("@username", TextBox3.Text);
            cmd.Parameters.AddWithValue("@user_type", "Admin");
            cmd.ExecuteNonQuery();
            con.Close();
            load_data();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }


     
    }
}