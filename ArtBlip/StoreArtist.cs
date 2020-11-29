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
    public partial class StoreArtist : Form
    {
        SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
        public StoreArtist()
        {
            InitializeComponent();
            populateData();
        }

        private void StoreArtist_Load(object sender, EventArgs e)
        {

        }

        private void CMDBack_Click(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            StoreArtist form = this;
            form.Hide();
        }

        private void CMDStore_Click(object sender, EventArgs e)
        {

           
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Artist(ArtistName, ArtistID,  DOB, TypeofArt) values(@name,  @id, @DOB, @typeofart)", con);
            cmd.Parameters.AddWithValue("@name", textArtistName.Text);
            cmd.Parameters.AddWithValue("@id", textArtistID.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@typeofart", comboTypeOfArt.Text);
            cmd.ExecuteNonQuery();

            //cmd.ExecuteNonQuery();
            MessageBox.Show("Artist has been successfully stored");
            con.Close();
            populateData();


        }


        private void populateData()
        {
            //throw new NotImplementedException();

            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Artist", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string DOB = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string type = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView2);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = DOB;
                row1.Cells[3].Value = type;
                dataGridView2.Rows.Add(row1);
            }

            con.Close();


        }


        private void search()
        {
            con.Open();

            string search = txtSearch.Text;
            if (txtSearch.Text == "")
                MessageBox.Show("INVALID SEARCH CREDENTTIALS");
            else
            {

                string query = "Select * from Artist where ArtistName=@search OR  ArtistID=@search ";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    string name = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string ID = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string DOB = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string Type = ds.Tables[0].Rows[i].ItemArray[3].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView2);
                    row1.Cells[0].Value = name;
                    row1.Cells[1].Value = ID;
                    row1.Cells[2].Value = DOB;
                    row1.Cells[3].Value = Type;

                    dataGridView2.Rows.Add(row1);
                }
            }
            con.Close();

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void delete()
        {

            con.Open();
            string name = txtSearch.Text;
            SqlCommand cmd = new SqlCommand("delete from Artist where ArtistID=@a", con);
            cmd.Parameters.AddWithValue("@a", name);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is Deleted");
            con.Close();
            populateData();


        }

        private void CMDDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void update()
        {
            string USER = textArtistName.Text;
            string EMAIL = textArtistID.Text;
            string PASS = dateTimePicker1.Text; 
            string TYPE = comboTypeOfArt.Text;
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("update Artist set  ArtistName=@name, TypeOfArt=@typeofart where ArtistID=@id", con);
        
          
            cmd.Parameters.AddWithValue("@name", textArtistName.Text);
            cmd.Parameters.AddWithValue("@id", textArtistID.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Text);
            cmd.Parameters.AddWithValue("@typeofart", comboTypeOfArt.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is Updated Successfully");

            populateData();
            con.Close();

        }

        private void CMDUpdate_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateData();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            textArtistName.Text = row.Cells[0].Value.ToString();
            textArtistID.Text = row.Cells[1].Value.ToString();
            dateTimePicker1.Text = row.Cells[2].Value.ToString();
            comboTypeOfArt.Text = row.Cells[3].Value.ToString();
        }


    }
}
