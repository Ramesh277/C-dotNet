using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentORG
{
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) // Check if the page is loaded for the first time
            {
                // Check if the query string parameter 'id' is present
                if (Request.QueryString["id"] != null)
                {
                    string studentId = Request.QueryString["id"];

                    string conString = "server=127.0.0.1; database=studentorg; user id=root; Password=Cham123@;";

                    using (MySqlConnection con = new MySqlConnection(conString))
                    {
                        try
                        {
                            con.Open();

                            // Prepare the SQL command to retrieve the record to update
                            string sql = "SELECT * FROM studentdata WHERE stdid = @studentId";

                            // Create a command with parameters to avoid SQL injection
                            using (MySqlCommand cmd = new MySqlCommand(sql, con))
                            {
                                // Add parameter for studentId
                                cmd.Parameters.AddWithValue("@studentId", studentId);

                                // Execute the command to retrieve the record
                                using (MySqlDataReader reader = cmd.ExecuteReader())
                                {
                                    // Check if a record was found with the given ID
                                    if (reader.Read())
                                    {
                                        // Retrieve the data from the reader
                                        string firstName = reader["fname"].ToString();
                                        string lastName = reader["lname"].ToString();
                                        string contact = reader["contact"].ToString();
                                        string email = reader["email"].ToString();

                                        // Populate your form controls with the retrieved data
                                        txtFname.Text = firstName;
                                        txtLname.Text = lastName;
                                        txtContact.Text = contact;
                                        txtEmail.Text = email;
                                    }
                                    else
                                    {
                                        // No record found with the given ID
                                        Response.Write("<script>alert('No record found with the given ID.')</script>");
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle any exceptions
                            Response.Write("<script>alert('Error:" + ex.Message + "')</script>");
                        }
                    }
                }
                else
                {
                    // Handle case where 'id' query string parameter is missing
                    Response.Write("<script>alert('No ID parameter found.')</script>");
                }
            }
        }

            //update process 
            protected void btnUpdate_Click(object sender, EventArgs e)
            {
                // Retrieve the values from your form controls
                string studentId = Request.QueryString["id"];
                string firstName = txtFname.Text;
                string lastName = txtLname.Text;
                string contact = txtContact.Text;
                string email = txtEmail.Text;

                string conString = "server=127.0.0.1; database=studentorg; user id=root; Password=Cham123@;";

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        // Prepare the SQL command to update the record
                        string sql = "UPDATE studentdata SET fname = @firstName, lname = @lastName, contact = @contact, email = @email WHERE stdid = @studentId";

                        // Create a command with parameters to avoid SQL injection
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            // Add parameters for the values to update
                            cmd.Parameters.AddWithValue("@firstName", firstName);
                            cmd.Parameters.AddWithValue("@lastName", lastName);
                            cmd.Parameters.AddWithValue("@contact", contact);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@studentId", studentId);

                            // Execute the command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Record updated successfully
                                Response.Write("<script>alert('Record updated successfully.')</script>");
                            }
                            else
                            {
                                // No records were updated (record with given ID not found)
                                Response.Write("<script>alert('No record found with the given ID.')</script>");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any exceptions
                        Response.Write("<script>alert('Error:" + ex.Message + "')</script>");
                    }
                } 
            }
    }
}