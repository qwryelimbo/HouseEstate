using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MainAdmin;
using SavedUserID;
using Profile;


namespace MainClient
{
    public partial class ClientForm : Form
    {
        private string connectionString = "Data Source=QWRYESAZE;Initial Catalog=HouseEstate;Integrated Security=True;";

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            LoadProperties(); // Load properties when form loads
        }

        // Method to load properties from the database and create property cards
        private void LoadProperties()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT PropertyID, PropertyType, Address, Cost FROM Properties"; // Add PropertyID to the query
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int propertyId = (int)reader["PropertyID"];  // Read PropertyID
                        string propertyType = reader["PropertyType"].ToString();
                        string address = reader["Address"].ToString();
                        int cost = (int)reader["Cost"];

                        // Call method to create a card (panel) for each property
                        CreatePropertyCard(propertyType, address, cost, propertyId);  // Pass PropertyID to the card
                    }
                }
            }
        }

        // Method to create a card (panel) for each property
        private void CreatePropertyCard(string propertyType, string address, int cost, int propertyId)
        {
            Panel propertyPanel = new Panel
            {
                Size = new Size(300, 150),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(10),
                BackColor = Color.LightGray
            };

            Label lblPropertyType = new Label
            {
                Text = "Тип: " + propertyType,
                Font = new Font("Arial", 10, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Label lblAddress = new Label
            {
                Text = "Адрес: " + address,
                Font = new Font("Arial", 10),
                Location = new Point(10, 40),
                AutoSize = true
            };

            Label lblCost = new Label
            {
                Text = "Цена: " + cost.ToString() + " Руб.",
                Font = new Font("Arial", 10),
                Location = new Point(10, 70),
                AutoSize = true
            };

            // Add labels to the panel
            propertyPanel.Controls.Add(lblPropertyType);
            propertyPanel.Controls.Add(lblAddress);
            propertyPanel.Controls.Add(lblCost);

            // Add click event handler
            propertyPanel.Click += (s, e) =>
            {
                int userId = Session.UserID;  // Get user ID from session or login
                RequestForm requestForm = new RequestForm(propertyId, userId);  // Open RequestForm with propertyId and userId
                requestForm.ShowDialog();  // Show the form as a dialog
            };

            // Add the panel (card) to the FlowLayoutPanel
            flowLayoutPanelProperties.Controls.Add(propertyPanel);
        }

        private void Catalog_Click(object sender, EventArgs e)
        {
        }

        private void profile_Click(object sender, EventArgs e)
        {
            
            ProfileForm profileForm = new ProfileForm();
            this.Close();
            profileForm.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
