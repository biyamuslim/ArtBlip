using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ArtBlip_Click(object sender, EventArgs e)
        {

        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void CMDStoreCustomer_Click(object sender, EventArgs e)
        {
            new StoreCustomer().Show();
            AdminPanel adminform = this;
            adminform.Hide();
        }

        private void CMDStoreArtist_Click(object sender, EventArgs e)
        {

            new StoreArtist().Show();
            AdminPanel adminform = this;
            adminform.Hide();
        }

        private void CMDStoreArtwork_Click(object sender, EventArgs e)
        {
            new StoreArtwork().Show();
            AdminPanel form = this;
            form.Hide();
        }

        private void CMDDeleteArtwork_Click(object sender, EventArgs e)
        {
            new DeleteArtwork().Show();
            AdminPanel form = this;
            form.Hide();
        }

        private void CMDManageUsers_Click(object sender, EventArgs e)
        {
            new manageUser().Show();
            AdminPanel form = this;
            form.Hide();
        }
    }
}
