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
    public partial class StoreCustomer : Form
    {
        public StoreCustomer()
        {
            InitializeComponent();
            populateData();
        }

        private void StoreCustomer_Load(object sender, EventArgs e)
        {



        }

        private void CMDBack_Click(object sender, EventArgs e)
        {
            

        }

        private void CMDBack_Click_1(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            StoreCustomer form = this;
            form.Hide();
        }

        private void CustomerID_Click(object sender, EventArgs e)
        {

        }

        private void CMDStore_Click(object sender, EventArgs e)
        {
            string name = textCustomerName.Text;
            string customerID = textCustomerID.Text;
            string artworkID = textArtworkID.Text;
            string Contact = textPhoneNo.Text;
            string cardNO = textCardNo.Text;
            string Bill = textTotalBill.Text;

            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Customer ( customerName,customerID, artworkID, phoneNumber, cardNo, bill) values(@a,  @b, @c, @d, @e, @f)", con);
            cmd.Parameters.AddWithValue("@a", name);
            cmd.Parameters.AddWithValue("@b", customerID);
            cmd.Parameters.AddWithValue("@c", artworkID);
            cmd.Parameters.AddWithValue("@d", Contact);
            cmd.Parameters.AddWithValue("@e", cardNO);
            cmd.Parameters.AddWithValue("@f", Bill);
            cmd.ExecuteNonQuery();


            MessageBox.Show(" successfully stored");
            con.Close();

            textCustomerName.Text = "";
            textArtworkID.Text = "";
            textCustomerID.Text = "";
            textPhoneNo.Text = "";
            textCardNo.Text = "";
            textTotalBill.Text = "";
            populateData();

        }


        private void populateData()
        {
            //throw new NotImplementedException();
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Customer", con);
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
                string p = ds.Tables[0].Rows[i].ItemArray[5].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView2);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = salary;
                row1.Cells[3].Value = year;
                row1.Cells[4].Value = price;
                row1.Cells[5].Value = p;

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

                string query = "Select * from Customer where customerName=@search OR customerID=@search";
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
                    string p = ds.Tables[0].Rows[i].ItemArray[5].ToString();


                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView2);
                    row1.Cells[0].Value = id;
                    row1.Cells[1].Value = name;
                    row1.Cells[2].Value = salary;
                    row1.Cells[3].Value = year;
                    row1.Cells[4].Value = price;
                    row1.Cells[5].Value = p;


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
            SqlCommand cmd = new SqlCommand("delete from Customer where customerName =@a", con);
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
            string name = textCustomerName.Text;
            string customerID = textCustomerID.Text;
            string artworkID = textArtworkID.Text;
            string Contact = textPhoneNo.Text;
            string cardNO = textCardNo.Text;
            string Bill = textTotalBill.Text;
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("update Customer set customerName= @a, phoneNumber= @d, cardNo= @e , bill=@f where customerID= @b and artworkID= @c", con);
            cmd.Parameters.AddWithValue("@a", name);
            cmd.Parameters.AddWithValue("@b", customerID);
            cmd.Parameters.AddWithValue("@c", artworkID);
            cmd.Parameters.AddWithValue("@d", Contact);
            cmd.Parameters.AddWithValue("@e", cardNO);
            cmd.Parameters.AddWithValue("@f", Bill);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is Updated Successfully");

            populateData();
            con.Close();


        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            populateData();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[rowIndex];
            textCustomerName.Text = row.Cells[0].Value.ToString();
            textCustomerID.Text = row.Cells[1].Value.ToString();
            textArtworkID.Text = row.Cells[2].Value.ToString();
            textPhoneNo.Text = row.Cells[3].Value.ToString();
            textCardNo.Text = row.Cells[4].Value.ToString();
            textTotalBill.Text = row.Cells[5].Value.ToString();
        }

        private void CMDUpdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
