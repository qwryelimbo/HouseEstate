using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using SavedUserID;
using MainClient;


namespace Profile
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Profile_Click(object sender, EventArgs e)
        {

            ProfileForm profileForm = new ProfileForm();
            this.Close();
            profileForm.Show();

        }

        private void catalog_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            this.Close();
            clientForm.Show();
        }
    }
}

