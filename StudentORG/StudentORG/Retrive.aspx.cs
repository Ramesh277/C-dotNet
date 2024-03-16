using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace StudentORG
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = "server=127.0.0.1; database=studentorg; user id=root; Password=Cham123@;";
            MySqlConnection db = new MySqlConnection(con);
            try
            {
                db.Open();
                string sql = "select *from studentdata";

     


                MySqlCommand cmd = new MySqlCommand(sql, db);

                MySqlDataReader reader = cmd.ExecuteReader();


                // Inside your try block
                string tableHtml = "<table border='1'><tr><th>Student ID</th><th>First Name</th><th>Last Name</th><th>Contact</th><th>Email</th><th colspan='3'>Action</th></tr>";

                while (reader.Read())
                {
                    // Build table rows
                    tableHtml += "<tr>";
                    tableHtml += $"<td>{reader["stdid"]}</td>";
                    tableHtml += $"<td>{reader["fname"]}</td>";
                    tableHtml += $"<td>{reader["lname"]}</td>";
                    tableHtml += $"<td>{reader["contact"]}</td>";
                    tableHtml += $"<td>{reader["email"]}</td>";
                    tableHtml += $"<td><a href='Update.aspx?id={reader["stdid"]}'>Edit</a></td>";
                    tableHtml += $"<td><a href='Delete.aspx?id={reader["stdid"]}'>Delete</a></td>";
                    tableHtml += $"<td><a href='Add.aspx'>Add</a></td>";
                    tableHtml += "</tr>";
                }

                tableHtml += "</table>";

                // Set the table HTML to the label's Text property
                lblData.Text = tableHtml;



                reader.Close();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Error:" + ex.Message + "')</script>");
            }
            finally
            {
                db.Close();
            }

        }
    }
}