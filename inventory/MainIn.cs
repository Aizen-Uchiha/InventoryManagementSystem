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

namespace inventory
{
    public partial class MainIn : Form
    {
        public MainIn()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WIZ;Initial Catalog=C:\USERS\ADMINISTRATOR\DOCUMENTS\INVENTORYDB.MDF;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sToggleButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sButton2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sButton1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void MainIn_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sToggleButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (sToggleButton1.Checked == false)
                Password.PasswordChar = '*'; 
            else
                Password.PasswordChar = '\0'; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                MessageBox.Show("Enter your Username");
            }
            else if (Password.Text == "")
            {
                MessageBox.Show("Enter the Password");
            }

            else
            {
                try
                {
                    Con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("select count(*) from UserTbl where Uname='" + Username.Text + "' and Upassword='" + Password.Text + "'", Con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows[0][0].ToString() == "1")
                    {
                        HomeForm home = new HomeForm();
                        home.Show();
                        this.Hide();
                    }

                    else
                        MessageBox.Show("Username or Password is Invalid! Please try Again!");
                    Con.Close();

                } catch (Exception ex)

                {
                    MessageBox.Show("" + ex);
                }

            }

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void sButton1_Click_1(object sender, EventArgs e)
        {
            Username.Text = "";
            Password.Text = "";
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
