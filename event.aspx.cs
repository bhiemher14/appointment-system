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
using System.Windows.Forms;

namespace Appointment_System_and_Venue_Reservation
{
    public partial class _event : System.Web.UI.Page
    {
        MySqlConnection con = new MySqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ToString());
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load_data();
                dropdown();
                created_by();
            }
        }

        void load_data()
        {
            MySqlCommand cmd = new MySqlCommand("Select * from event", con);
            MySqlDataAdapter d = new MySqlDataAdapter(cmd);

            using (DataTable dt = new DataTable())
            {
                d.Fill(dt);
                eventList.DataSource = dt;
                eventList.DataBind();

            }
        }

        void dropdown()
        {
            MySqlCommand com = new MySqlCommand("select id,title from event WHERE STATUS IN ('Upcoming','Ongoing')", con);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DropDownList1.DataTextField = ds.Tables[0].Columns["title"].ToString(); // text field name of table dispalyed in dropdown       
            DropDownList1.DataValueField = ds.Tables[0].Columns["id"].ToString();


            DropDownList1.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            DropDownList1.DataBind();  //binding dropdownlist  
        }

        void created_by()
        {
            MySqlCommand com = new MySqlCommand("select id,username from user", con);
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            DropDownList2.DataTextField = ds.Tables[0].Columns["username"].ToString(); // text field name of table dispalyed in dropdown       
            DropDownList2.DataValueField = ds.Tables[0].Columns["id"].ToString();


            DropDownList2.DataSource = ds.Tables[0];      //assigning datasource to the dropdownlist  
            DropDownList2.DataBind();  //binding dropdownlist  
        }


        //protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        //{s
        //    if (e.Row.RowType == DataControlRowType.DataRow && e.Row.RowIndex != eventList.EditIndex)
        //    {
        //        (e.Row.Cells[0].Controls[2] as LinkButton).Attributes["onclick"] = "return confirm('Do you want to delete this row?');";
        //    }


        //}




        //protected void OnRowDeleting(object sender, GridViewDeleteEventArgs e)
        //{


        //    int id = Convert.ToInt32(eventList.DataKeys[e.RowIndex].Values[0]);
        //    con.Open();
        //    MySqlCommand cmd = new MySqlCommand("delete FROM event where id=@id", con);
        //    cmd.Parameters.AddWithValue("@id", id);
        //    cmd.ExecuteNonQuery();
        //    con.Close();
        //    load_data();
        //}


        //protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        //{


        //    GridViewRow row = eventList.Rows[e.RowIndex];
        //    int id = Convert.ToInt32(eventList.DataKeys[e.RowIndex].Values[0]);

        //    string title = (row.Cells[2].Controls[0] as TextBox).Text;
        //    string desc = (row.Cells[3].Controls[0] as TextBox).Text;
        //    string date = (row.Cells[4].Controls[0] as TextBox).Text;
        //    string timein = (row.Cells[5].Controls[0] as TextBox).Text;
        //    string timeout = (row.Cells[6].Controls[0] as TextBox).Text;
        //    string status = (row.Cells[7].Controls[0] as TextBox).Text;


        //    con.Open();

        //    MySqlCommand cmd = new MySqlCommand("UPDATE event SET title = @title, description = @description, date = @date, time_start = @time_start , time_end = @time_end , status = @status WHERE id = @id", con);

        //    cmd.Parameters.AddWithValue("@id", id);
        //    cmd.Parameters.AddWithValue("@title", title);
        //    cmd.Parameters.AddWithValue("@description", desc);
        //    cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(date).ToString("MM/dd/yyyy"));
        //    cmd.Parameters.AddWithValue("@time_start", Convert.ToDateTime(timein).ToString("hh:mm ss"));
        //    cmd.Parameters.AddWithValue("@time_end", Convert.ToDateTime(timeout).ToString("hh:mm ss"));
        //    cmd.Parameters.AddWithValue("@status", status);
        //    cmd.ExecuteNonQuery();
        //    con.Close();


        //    eventList.EditIndex = -1;
        //    this.load_data();
        //}
        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            eventList.EditIndex = e.NewEditIndex;
            this.load_data();
        }

        protected void OnRowCancelingEdit(object sender, EventArgs e)
        {
            eventList.EditIndex = -1;
            this.load_data();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("Insert INTO event (title,description,date,time_start,time_end,created_by) VALUES (@title,@description,@date,@time_start,@time_end,@created_by) ", con);


            cmd.Parameters.AddWithValue("@title", TextBox1.Text);
            cmd.Parameters.AddWithValue("@description", TextBox2.Text);
            cmd.Parameters.AddWithValue("@date", TextBox3.Text);
            cmd.Parameters.AddWithValue("@time_start", TextBox3.Text);
            cmd.Parameters.AddWithValue("@time_end", TextBox3.Text);
            cmd.Parameters.AddWithValue("@created_by", DropDownList2.SelectedItem.Value);
            cmd.ExecuteNonQuery();
            con.Close();
            load_data();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            string message = "Do you want to cancel this upcoming appoinment?";
            string title = "";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {

                con.Open();

                MySqlCommand cmd = new MySqlCommand("UPDATE event SET status = @status WHERE id = @id", con);

                cmd.Parameters.AddWithValue("@id", DropDownList1.SelectedItem.Value);
                cmd.Parameters.AddWithValue("@status", "Cancelled");

                cmd.ExecuteNonQuery();
                con.Close();

                load_data();
                dropdown();
                
            }
            else
            {
                // Do something  
            }
        }

        

    }

}