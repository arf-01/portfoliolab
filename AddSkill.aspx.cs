using System;
using System.Configuration;
using System.Data.SqlClient;

namespace project1
{
    public partial class AddSkill : System.Web.UI.Page
    {
        protected void AddSkillButton_Click(object sender, EventArgs e)
        {
            string skillName = SkillNameTextBox.Text;

            // Insert the new skill into the database
            string connectionString = ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString;
            string query = "INSERT INTO Skills (SkillName) VALUES (@SkillName)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SkillName", skillName);

                connection.Open();
                command.ExecuteNonQuery();
            }

            // Redirect back to home page after adding the skill
            Response.Redirect("Home.aspx");
        }
    }
}
