using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MainAdmin
{
    public partial class AdminForm : Form
    {
        private string connectionString = "Data Source=QWRYESAZE;Initial Catalog=HouseEstate;Integrated Security=True;";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            LoadProperties();  
            LoadAgents();      
            LoadRequests();    
        }
        private void AdminForm_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "houseEstateDataSet5.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter1.Fill(this.houseEstateDataSet5.Requests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "houseEstateDataSet4.Agents". При необходимости она может быть перемещена или удалена.
            this.agentsTableAdapter1.Fill(this.houseEstateDataSet4.Agents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "houseEstateDataSet3.Properties". При необходимости она может быть перемещена или удалена.
            this.propertiesTableAdapter1.Fill(this.houseEstateDataSet3.Properties);
            /*
            // TODO: данная строка кода позволяет загрузить данные в таблицу "houseEstateDataSet2.Requests". При необходимости она может быть перемещена или удалена.
            this.requestsTableAdapter.Fill(this.houseEstateDataSet2.Requests);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "houseEstateDataSet1.Agents". При необходимости она может быть перемещена или удалена.
            this.agentsTableAdapter.Fill(this.houseEstateDataSet1.Agents);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "houseEstateDataSet.Properties". При необходимости она может быть перемещена или удалена.
            this.propertiesTableAdapter.Fill(this.houseEstateDataSet.Properties);
            */

        }

        // Load Properties into DataGridView
        private void LoadProperties()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PropertyID, PropertyType, Address, Cost, AgentID FROM Properties";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvProperties.DataSource = dt;
            }
        }

        // Load Agents into DataGridView
        private void LoadAgents()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Agents";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvAgents.DataSource = dt;
            }
        }

        // Load Requests into DataGridView
        private void LoadRequests()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Requests";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvRequests.DataSource = dt;
            }
        }


        // Add new Agent
        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Agents (AgentName, AgentPhoneNumber) VALUES (@AgentName, @AgentPhoneNumber)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AgentName", AgentName.Text);
                    command.Parameters.AddWithValue("@AgentPhoneNumber", AgentPhoneNumber.Text);
                    command.ExecuteNonQuery();
                }
            }
            LoadAgents();  // Refresh DataGridView after adding agent
        }


        // Delete selected Agent
        private void btnDeleteAgent_Click(object sender, EventArgs e)
        {
            if (dgvAgents.SelectedRows.Count > 0)
            {
                int agentId = (int)dgvAgents.SelectedRows[0].Cells["AgentID"].Value;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Agents WHERE AgentID = @AgentID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@AgentID", agentId);
                        command.ExecuteNonQuery();
                    }
                }
                LoadAgents();  // Refresh DataGridView after deleting
            }
        }

        // Delete selected Request
        private void btnDeleteRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count > 0)
            {
                int requestId = (int)dgvRequests.SelectedRows[0].Cells["RequestID"].Value;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Requests WHERE RequestID = @RequestID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestID", requestId);
                        command.ExecuteNonQuery();
                    }
                }
                LoadRequests();  // Refresh DataGridView after deleting
            }
        }

        // Edit Property (for updating, you would typically load the values into textboxes, allow editing, and save back)
        private void btnEditProperty_Click(object sender, EventArgs e)
        {
            if (dgvProperties.SelectedRows.Count > 0)
            {
                int propertyId = (int)dgvProperties.SelectedRows[0].Cells["propertyIDDataGridViewTextBoxColumn"].Value;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Properties SET PropertyType = @PropertyType, Address = @Address, Cost = @Cost WHERE PropertyID = @PropertyID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PropertyID", propertyId);
                        command.Parameters.AddWithValue("@PropertyType", PropertyType.Text);
                        command.Parameters.AddWithValue("@Address", Address.Text);
                        command.Parameters.AddWithValue("@Cost", Convert.ToInt32(Cost.Text));
                        command.ExecuteNonQuery();
                    }
                }
                LoadProperties();  // Refresh DataGridView after updating
            }
        }

        // Edit Request (similar to property editing)
        private void btnEditRequest_Click(object sender, EventArgs e)
        {
            if (dgvRequests.SelectedRows.Count > 0)
            {
                int requestId = (int)dgvRequests.SelectedRows[0].Cells["RequestID"].Value;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Requests SET RequestStatus = @RequestStatus WHERE RequestID = @RequestID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@RequestID", requestId);
                        command.Parameters.AddWithValue("@RequestStatus", RequestStatus.Text);
                        command.ExecuteNonQuery();
                    }
                }
                LoadRequests();  // Refresh DataGridView after updating
            }
        }


        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Properties (PropertyType, Address, Cost, AgentID) VALUES (@PropertyType, @Address, @Cost, @AgentID)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PropertyType", PropertyType.Text);
                    command.Parameters.AddWithValue("@Address", Address.Text);
                    command.Parameters.AddWithValue("@Cost", Convert.ToInt32(Cost.Text));
                    command.Parameters.AddWithValue("@AgentID", Convert.ToInt32(AgentID.Text));

                    command.ExecuteNonQuery();
                }
            }
            LoadProperties();  // Refresh DataGridView after adding property
        }
        private void btnDeleteProperty_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dgvProperties.SelectedRows.Count > 0)
            {
                // Get the PropertyID from the selected row (assuming PropertyID is one of the columns)
                int PropertyID = (int)dgvProperties.SelectedRows[0].Cells["propertyIDDataGridViewTextBoxColumn"].Value;

                // Delete from database
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Properties WHERE PropertyID = @PropertyID";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@PropertyID", PropertyID);
                        command.ExecuteNonQuery();
                    }
                }

                dgvProperties.Rows.RemoveAt(dgvProperties.SelectedRows[0].Index);

                LoadProperties(); 
            }
            else
            {
                MessageBox.Show("Выберите строку для удаления");
            }
        }
    }
 }
 

