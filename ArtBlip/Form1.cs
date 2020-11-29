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
    public partial class Form1 : Form
    {
        //private SqlConnection conn = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMDSignUp_Click(object sender, EventArgs e)
        {

            new SignUp().Show();
            Form1 form1 = this;
            form1.Hide();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }

        private void CMDLogin_Click(object sender, EventArgs e)
        {
           // string userName = textUserName.Text;
            //string pass = textPassword.Text;

           // SqlConnection conn = new SqlConnection("Data Source=BAREERAHMUSLIM\\BAREERAHMUSLIM;Initial Catalog=Gallery;Integrated Security=True");
            //conn.Open();

            //SqlCommand cmd = new SqlCommand("select * from  Admins where UserName=@username and  pass=@pass)");

            ///////////
            SqlConnection con = new SqlConnection("Data Source = BAREERAHMUSLIM\\BAREERAHMUSLIM; Initial Catalog = Gallery; Integrated Security = True");
            SqlCommand cmd = new SqlCommand("Select * from Admins where UserName=@username and pass=@password", con);

            cmd.Parameters.AddWithValue("@username", textUserName.Text);
            cmd.Parameters.AddWithValue("@password", textPassword.Text);
            con.Open();
            SqlDataAdapter adapt = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapt.Fill(ds);
            con.Close();
            int count = ds.Tables[0].Rows.Count;
            //If count is equal to 1, than show frmMain form
            if (count == 1)
            {
                MessageBox.Show("Successfully Login.");
                new AdminPanel().Show();
                Form1 form = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password.");
            }

            /*cmd.Parameters.AddWithValue("@username", userName);
            cmd.Parameters.AddWithValue("@pass", pass);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            cmd.Connection = conn;
            adapter.Fill(ds);
            conn.Close();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.Connection = conn;
            adapter.Fill(ds);
            cmd.ExecuteNonQuery();
            

            if (ds.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("You are successfully login");
            }
            else
            {
                MessageBox.Show("Login credentials are not valid");
            }
            
            new AdminPanel().Show();
            Form1 form = this;
            form.Hide();

        
    */
        }
    }

}
