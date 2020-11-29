using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_form
{
    public partial class manageUser : Form
    {
        public manageUser()
        {
            InitializeComponent();
            populateData();
        }

        private void CMDBack_Click(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            manageUser form = this;
            form.Hide();
        }

        private void populateData()
        {
            //throw new NotImplementedException();
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Admins", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string salary = ds.Tables[0].Rows[i].ItemArray[2].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView1);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = salary;

                dataGridView1.Rows.Add(row1);
            }

            con.Close();


        }


        private void search()
        {
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
            con.Open();

            string search = txtSearch.Text;
            if (txtSearch.Text == "")
                MessageBox.Show("INVALID SEARCH CREDENTTIALS");
            else
            {

                string query = "Select * from Admins where UserName=@search OR  email=@search OR pass=@search";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView1.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string cnic = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string email = ds.Tables[0].Rows[i].ItemArray[2].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView1);
                    row1.Cells[0].Value = name;
                    row1.Cells[1].Value = cnic;
                    row1.Cells[2].Value = email;

                    dataGridView1.Rows.Add(row1);
                }
            }
            con.Close();

        }

        private void CMDUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void CMDDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }


        private void delete()
        {


            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
            con.Open();
            string name = txtSearch.Text;
            SqlCommand cmd = new SqlCommand("delete from ADmins where UserName=@a", con);
            cmd.Parameters.AddWithValue("@a", name);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is Deleted");
            con.Close();
            populateData();


        }

        private void update()
        {
            string USER = textUserName.Text;
            string EMAIL = textEmail.Text;
            string PASS = textPassword.Text;
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("update Admins set  email=@EMAIL, pass= @PASS where UserName=@USER", con);
            cmd.Parameters.AddWithValue("@USER", USER);
            cmd.Parameters.AddWithValue("@EMAIL", EMAIL);
            cmd.Parameters.AddWithValue("@PASS", PASS);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is Updated Successfully");

            populateData();
            con.Close();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateData();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            textUserName.Text = row.Cells[0].Value.ToString();
            textEmail.Text = row.Cells[1].Value.ToString();
            textPassword.Text = row.Cells[2].Value.ToString();
        }
    }
}
