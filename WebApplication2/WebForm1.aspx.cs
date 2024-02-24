using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Get the connection string from web.config file
            string connectionString = ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;

            // Create connection
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Define the SQL query to insert data
                string query = "INSERT INTO YourTableName (Name, Email, Message) VALUES (@Name, @Email, @Message)";

                // Create command and parameters
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", txtName.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("@Message", txtMessage.Text);

                    // Open connection
                    con.Open();

                    // Execute the command
                    cmd.ExecuteNonQuery();
                }
            }

            // Optionally, you can clear the form fields after submission
            txtName.Text = "";
            txtEmail.Text = "";
            txtMessage.Text = "";

            // You can also redirect the user to another page after submission if needed
            // Response.Redirect("ThankYouPage.aspx");
        }

        protected void txtMessage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
