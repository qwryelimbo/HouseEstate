using MainClient;
using MainAgent;
using MainAdmin;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SavedUserID;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        private string connectionString = "Data Source=QWRYESAZE;Initial Catalog=HouseEstate;Integrated Security=True;";
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //

            string username = Login.Text;
            string password = Password.Text;

            if (AuthenticateUser(username, password, out string role, out int UserId))
            {
                Session.UserID = UserId;
                Session.Username = username;
                Session.Role = role;

                if (role == "Client")
                {
                    ClientForm clientForm = new ClientForm();
                    this.Hide();
                    clientForm.Show();
                }
                else if (role == "Agent")
                {
                    AgentForm agentForm = new AgentForm();
                    this.Hide();
                    agentForm.Show();
                }
                else if (role == "Administrator")
                {
                    AdminForm adminForm = new AdminForm();
                    
                    adminForm.Show();
                }
                else
                {
                    MessageBox.Show("Invalid user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Method to authenticate the user
        private bool AuthenticateUser(string username, string password, out string role, out int UserId)
        {
            role = string.Empty;
            UserId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT UserID, Role FROM Users WHERE Username = @Username AND Password = @Password";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            role = reader["Role"].ToString();
                            UserId = Convert.ToInt32(reader["UserID"]);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        // Sign Up button event can be implemented similarly.
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // Logic for signing up users.
        }
    }
}
