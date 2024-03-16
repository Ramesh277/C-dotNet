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
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string con = "server=127.0.0.1; database=studentorg; user id=root; Password=Cham123@;";
            MySqlConnection db = new MySqlConnection(con);
            try
            {
                db.Open();
                string insert = "insert into studentdata (fname,lname,contact,email) values ('" + txtFname.Text + "','" + txtLname.Text + "','" + txtContact.Text + "','" + txtEmail.Text + "')";
                MySqlCommand cmd = new MySqlCommand(insert, db);
                int m = cmd.ExecuteNonQuery();

                if (m != 0)
                {
                    txtFname.Text = "";
                    txtLname.Text = "";
                    txtContact.Text = "";
                    txtEmail.Text = "";
                    Response.Write("<script> alert('Data Inserted !!') </script>");


                }
                else
                {
                    Response.Write("<script> alert('Data not Inserted !!') </script>");
                }



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