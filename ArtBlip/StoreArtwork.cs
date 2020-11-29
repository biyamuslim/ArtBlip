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
    public partial class StoreArtwork : Form
    {
        public StoreArtwork()
        {
            InitializeComponent();
            populateData();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textArtworkID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textArtworkName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArtworkPrice_Click(object sender, EventArgs e)
        {

        }

        private void Year_Click(object sender, EventArgs e)
        {

        }

        private void ArtworkID_Click(object sender, EventArgs e)
        {

        }

        private void ArtworkTitle_Click(object sender, EventArgs e)
        {

        }

        private void CMDStore_Click(object sender, EventArgs e)
        {
            string title = textArtworkName.Text;
            string artworkID = textArtworkID.Text;
            string artistID = textArtistID.Text;
            string date = dateTimePicker1.Text;
            string price = textArtworkPrice.Text;

            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Artwork (artworkTitle, artworkID, ArtistID, artworkDate, artworkPrice) values(@username,  @email, @pass, @date, @price)", con);
            cmd.Parameters.AddWithValue("@username", title);
            cmd.Parameters.AddWithValue("@email", artworkID);
            cmd.Parameters.AddWithValue("@pass", artistID);
            cmd.Parameters.AddWithValue("@date", date);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.ExecuteNonQuery();


            MessageBox.Show(" successfully stored");
            con.Close();

            textArtworkName.Text = "";
            textArtworkID.Text = "";
            textArtistID.Text = "";
            dateTimePicker1.Text = "";
            textArtworkPrice.Text = "";
             populateData();

        }

        private void CMDBack_Click(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            StoreArtwork form = this;
            form.Hide();
        }

        private void StoreArtwork_Load(object sender, EventArgs e)
        {

        }
        private void populateData()
        {
            //throw new NotImplementedException();
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Artwork", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView2.Rows.Clear();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string salary = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string year = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string price = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView2);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = salary;
                row1.Cells[3].Value = year;
                row1.Cells[4].Value = price;

                dataGridView2.Rows.Add(row1);
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

                string query = "Select * from Artwork where artworkTitle=@search OR  artworkID=@search";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@search", search);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                dataGridView2.Rows.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                     string id = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                    string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                    string salary = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                    string year = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                    string price = ds.Tables[0].Rows[i].ItemArray[4].ToString();

                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView2);
                    row1.Cells[0].Value = id;
                    row1.Cells[1].Value = name;
                    row1.Cells[2].Value = salary;
                    row1.Cells[3].Value = year;
                    row1.Cells[4].Value = price;


                    dataGridView2.Rows.Add(row1);
                }
            }
            con.Close();

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
            SqlCommand cmd = new SqlCommand("delete from Artwork where artworkTitle =@a", con);
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
            string title = textArtworkName.Text;
            string artworkID = textArtworkID.Text;
            string artistID = textArtistID.Text;
            string date = dateTimePicker1.Text;
            string price = textArtworkPrice.Text;
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("update Artwork set artworkTitle=@a, artworkDate=@d, artworkPrice=@e where artworkID=@b and ArtistID= @c", con);
            cmd.Parameters.AddWithValue("@a", title);
            cmd.Parameters.AddWithValue("@b", artworkID);
            cmd.Parameters.AddWithValue("@c", artistID);
            cmd.Parameters.AddWithValue("@d", date);
            cmd.Parameters.AddWithValue("@e", price);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is Updated Successfully");

            populateData();
            con.Close();


        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            textArtworkName.Text = row.Cells[0].Value.ToString();
            textArtworkID.Text = row.Cells[1].Value.ToString();
            textArtistID.Text = row.Cells[2].Value.ToString();
            dateTimePicker1.Text = row.Cells[3].Value.ToString();
            textArtworkPrice.Text = row.Cells[4].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateData();
        }

        private void CMDUpdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
