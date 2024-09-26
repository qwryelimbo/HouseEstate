using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainClient
{
    public partial class RequestForm : Form
    {
        private int propertyId;
        private int userId;
        private string connectionString = "Data Source=QWRYESAZE;Initial Catalog=HouseEstate;Integrated Security=True;";

        public RequestForm(int propertyId, int userId)
        {
            InitializeComponent();
            this.propertyId = propertyId;
            this.userId = userId;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            // Fetch the input data from the textboxes
            string fullName = FullName.Text;
            string phoneNumber = PhoneNumber.Text;

            // Check if FullName or PhoneNumber fields are empty
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(phoneNumber))
            {
                MessageBox.Show("Введите имя И номер телефона");
                return;
            }

            // Insert into the database
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string insertClientQuery = "INSERT INTO Clients (FullName, PhoneNumber, UserID, AgentID) " +
                                               "VALUES (@FullName, @PhoneNumber, @UserID, @AgentID); " +
                                               "SELECT SCOPE_IDENTITY();"; // новая identity

                    int clientId;

                    using (SqlCommand clientCommand = new SqlCommand(insertClientQuery, connection, transaction))
                    {
                        clientCommand.Parameters.AddWithValue("@FullName", fullName);
                        clientCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        clientCommand.Parameters.AddWithValue("@UserID", userId);
                        clientCommand.Parameters.AddWithValue("@AgentID", 1);

                        clientId = Convert.ToInt32(clientCommand.ExecuteScalar()); //получаю client id
                    }

                    // 2. Insert into Requests table
                    string insertRequestQuery = "INSERT INTO Requests (UserID, RequestDate, PropertyID, RequestStatus, AgentID) " +
                                                "VALUES (@UserID, @RequestDate, @PropertyID, @RequestStatus, @AgentID)";

                    using (SqlCommand requestCommand = new SqlCommand(insertRequestQuery, connection, transaction))
                    {
                        requestCommand.Parameters.AddWithValue("@UserID", userId);
                        requestCommand.Parameters.AddWithValue("@RequestDate", DateTime.Now);
                        requestCommand.Parameters.AddWithValue("@PropertyID", propertyId);
                        requestCommand.Parameters.AddWithValue("@RequestStatus", "Новый");
                        requestCommand.Parameters.AddWithValue("@AgentID", 1);  

                        requestCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("Заявка создана");
                    this.Close();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
