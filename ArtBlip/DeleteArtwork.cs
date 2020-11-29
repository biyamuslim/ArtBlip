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
    public partial class DeleteArtwork : Form
    {
        
        public DeleteArtwork()
        {
            InitializeComponent();
            populateData();
        }

        private void DeleteArtwork_Load(object sender, EventArgs e)
        {

        }

        private void CMDBack_Click(object sender, EventArgs e)
        {
            new AdminPanel().Show();
            DeleteArtwork form = this;
            form.Hide();
        }

        private void ArtworkID_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArtBlip_Click(object sender, EventArgs e)
        {

        }

        private void CMDSave_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
            string empID=textEmployeeID.Text;
            string firstName= textFirstName.Text;
            string lastName=textSecondName.Text;
            string empAddress= textAddress.Text;
            string CNIC= textCNIC.Text;
           string email= textEmail.Text;
            string phoneNumber=  textContactNo.Text;
           string salary= textSalary.Text;
            string joinDate=  dateTimePicker1.Text;
           string endDate   = dateTimePicker2.Text;
            //cmd.ExecuteNonQuery();

            con.Open();
           
            SqlCommand cmd = new SqlCommand("insert into Employees(empID, firstName,lastName, empAddress,CNIC,email,phoneNumber,salary, joinDate, endDate) values(@ID,  @fname, @sname, @address, @cnic, @email, @number,@salary, @jdate, @edate)", con);
            cmd.Parameters.AddWithValue("@ID", empID);
            cmd.Parameters.AddWithValue("@fname", firstName);
            cmd.Parameters.AddWithValue("@sname", lastName);
            cmd.Parameters.AddWithValue("@address", empAddress);
            cmd.Parameters.AddWithValue("@cnic", CNIC);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@number", phoneNumber);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@jdate", joinDate);
            cmd.Parameters.AddWithValue("@edate", endDate);
            //cmd.ExecuteNonQuery();
      
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Employees has been successfully stored");
            con.Close();

            textEmployeeID.Text = "";
            textFirstName.Text="";
            textSecondName.Text = "";
            textAddress.Text = "";
            textCNIC.Text = "";
            textEmail.Text = "";
            textContactNo.Text = "";
            textSalary.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            populateData();
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }


        private void populateData()
        {
            //throw new NotImplementedException();
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Employees", con);
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
                string a = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                string b = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                string c = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                string d = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                string e = ds.Tables[0].Rows[i].ItemArray[9].ToString();

                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(dataGridView2);
                row1.Cells[0].Value = id;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = salary;
                row1.Cells[3].Value = year;
                row1.Cells[4].Value = price;
                row1.Cells[5].Value = a;
                row1.Cells[6].Value = b;
                row1.Cells[7].Value = c;
                row1.Cells[8].Value = d;
                row1.Cells[9].Value = e;

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

                string query = "Select * from Employees where empID=@search ";
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
                    string a = ds.Tables[0].Rows[i].ItemArray[5].ToString();
                    string b = ds.Tables[0].Rows[i].ItemArray[6].ToString();
                    string c = ds.Tables[0].Rows[i].ItemArray[7].ToString();
                    string d = ds.Tables[0].Rows[i].ItemArray[8].ToString();
                    string e = ds.Tables[0].Rows[i].ItemArray[9].ToString();


                    DataGridViewRow row1 = new DataGridViewRow();
                    row1.CreateCells(dataGridView2);
                    row1.Cells[0].Value = id;
                    row1.Cells[1].Value = name;
                    row1.Cells[2].Value = salary;
                    row1.Cells[3].Value = year;
                    row1.Cells[4].Value = price;
                    row1.Cells[5].Value = a;
                    row1.Cells[6].Value = b;
                    row1.Cells[7].Value = c;
                    row1.Cells[8].Value = d;
                    row1.Cells[9].Value = e;



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
            SqlCommand cmd = new SqlCommand("delete from Employees where empID =@a ", con);
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
            string empID = textEmployeeID.Text;
            string firstName = textFirstName.Text;
            string lastName = textSecondName.Text;
            string empAddress = textAddress.Text;
            string CNIC = textCNIC.Text;
            string email = textEmail.Text;
            string phoneNumber = textContactNo.Text;
            string salary = textSalary.Text;
            string joinDate = dateTimePicker1.Text;
            string endDate = dateTimePicker2.Text;
            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

            con.Open();
            SqlCommand cmd = new SqlCommand("update Employees set  firstName=@fname,lastName=@sname, empAddress=@address,CNIC=@cnic,email=@email,phoneNumber=@number,salary=@salary, joinDate=@jdate, endDate=@edate where empID=@ID", con);
            cmd.Parameters.AddWithValue("@ID", empID);
            cmd.Parameters.AddWithValue("@fname", firstName);
            cmd.Parameters.AddWithValue("@sname", lastName);
            cmd.Parameters.AddWithValue("@address", empAddress);
            cmd.Parameters.AddWithValue("@cnic", CNIC);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@number", phoneNumber);
            cmd.Parameters.AddWithValue("@salary", salary);
            cmd.Parameters.AddWithValue("@jdate", joinDate);
            cmd.Parameters.AddWithValue("@edate", endDate);
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
            textEmployeeID.Text = row.Cells[0].Value.ToString();
            textFirstName.Text = row.Cells[1].Value.ToString();
            textSecondName.Text = row.Cells[2].Value.ToString();
            textAddress.Text = row.Cells[3].Value.ToString();
            textCNIC.Text = row.Cells[4].Value.ToString();
            textEmail.Text = row.Cells[5].Value.ToString();
            textContactNo.Text = row.Cells[6].Value.ToString();
            textSalary.Text = row.Cells[7].Value.ToString();
            dateTimePicker1.Text = row.Cells[8].Value.ToString();
            dateTimePicker1.Text = row.Cells[9].Value.ToString();
        }




        private void dataGridView2_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CMDUpdate_Click(object sender, EventArgs e)
        {
            update();
        }
    }
}
