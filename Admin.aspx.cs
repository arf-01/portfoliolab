using System;
using System.Configuration;
using System.Data.SqlClient;

namespace project1
{
    public partial class Admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            // Connection string for your database
            string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;

            // Query to check credentials
            string query = "SELECT COUNT(*) FROM AdminUsers WHERE Email = @Email AND Password = @Password";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    Session["LoggedIn"] = true; 

                    Response.Redirect("AddSkill.aspx");
                }
                else
                {
                    // Credentials are incorrect, display error message
                    ErrorMessageLabel.Text = "Invalid email or password";
                    ErrorMessageLabel.Visible = true;
                }
            }
        }
    }
}
