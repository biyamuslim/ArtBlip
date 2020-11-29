using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_form
{
    public partial class SignUp : Form
    {
        

        //private const string ConnectionString = "Data Source = BAREERAHMUSLIM\\BAREERAH; Integrated Security = True";
        //private const string ConnectionString1 = "insert into myApp(UserName,CNIC,email,Contact,Address,Password,ConfirmPass) values(@username,@cnic,@email,@Cont,@Addr,@pass,@confirmPass,)";

        public SignUp()
        {
            InitializeComponent();
            populateData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMDBack_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            SignUp signup = this;
           signup.Hide();

        }

        private void CMDSignUp_Click(object sender, EventArgs e)
        {
            string userName = textUserName.Text;
            string eMail = textEmail.Text;
            string Pass= textPassword.Text;
           


            SqlConnection con = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Admins(UserName,  email,  pass) values(@username,  @email, @pass)", con);
                cmd.Parameters.AddWithValue("@username", userName);
                cmd.Parameters.AddWithValue("@email", eMail);
             cmd.Parameters.AddWithValue("@pass", Pass);
                cmd.ExecuteNonQuery();



                


            //cmd.ExecuteNonQuery();
             MessageBox.Show("Your Account has been successfully created");
            con.Close();

            textUserName.Text = "";
            textEmail.Text = "";
            textPassword.Text = "";
            populateData();

           
            
            new AdminPanel().Show();
            SignUp form = this;
            form.Hide();

        }

        private void populateData()
        {
           
        

    }

        private void CNIC_Click(object sender, EventArgs e)
        {
            
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void ArtBlip_Click(object sender, EventArgs e)
        {

        }

        
        private void search()
        {
           

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search();
        }

        private void delete()
        {


        }


       /* private void update()
        {
            string Name = textUserName.Text;
            string Email = textEmail.Text;
            string Pass = textPassword.Text;
           
           
            con.Open();
            SqlCommand cmd = new SqlCommand("update Admins set UserName=@name,email=@email,pass=@pass where Name=@name", con);

            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@pass", Pass);
         
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data is updated");
            populateData();
            con.Close();

        }*/


        private void textUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMDDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void CMDUpdate_Click(object sender, EventArgs e)
        {
           update();
        }


        private void update()
        {


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
