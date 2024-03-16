using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentORG
{
    public partial class Delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                string studentId = Request.QueryString["id"];

                string conString = "server=127.0.0.1; database=studentorg; user id=root; Password=Cham123@;";

                using (MySqlConnection con = new MySqlConnection(conString))
                {
                    try
                    {
                        con.Open();

                        // Prepare the SQL command to delete the record
                        string sql = "DELETE FROM studentdata WHERE stdid = @studentId";

                        // Create a command with parameters to avoid SQL injection
                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            // Add parameter for studentId
                            cmd.Parameters.AddWithValue("@studentId", studentId);

                            // Execute the command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                // Record deleted successfully
                                Response.Write("<script>alert('Record deleted successfully.')</script>");
                            }
                            else
                            {
                                // No records were deleted (record with given ID not found)
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
            else
            {
                // Handle case where 'id' query string parameter is missing
                Response.Write("<script>alert('No ID parameter found.')</script>");
            }

        }
    }
}