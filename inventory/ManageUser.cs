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

namespace inventory
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WIZ;Initial Catalog=C:\USERS\ADMINISTRATOR\DOCUMENTS\INVENTORYDB.MDF;Integrated Security=True;");
        private void label3_Click(object sender, EventArgs e)
        {
        }
        void popularate()
        {
            try
            {
                Con.Open();
                string Myqurey = "select * from UserTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder= new SqlCommandBuilder(da);
                var ds= new DataSet();
                da.Fill(ds);
                UsersGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch 
            {

            }
        }

        private void sButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into UserTbl values('" + unameTb.Text + "','" + FnameTb.Text + "','" + UpassTb.Text + "','" + UphoneTb.Text + "','" + UserLevel.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Added");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void UsersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            UphoneTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
            UserLevel.Text = UsersGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            popularate();
        }

        private void sButton3_Click(object sender, EventArgs e)
        {

        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update UserTbl set Uname='"+unameTb.Text+"',Ufullname='"+FnameTb.Text+"',Upassword='"+UpassTb.Text+ "', UserLevel='"+UserLevel.Text+"', where Uphone='" + UphoneTb.Text+"'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Updated");
                Con.Close();
                popularate();
            }
            catch
            {


            }

        }

     

        private void UsersGV_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            unameTb.Text = UsersGV.SelectedRows[0].Cells[0].Value.ToString();
            FnameTb.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
            UpassTb.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
            UphoneTb.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
            UserLevel.Text = UsersGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void unameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void FnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpassTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UphoneTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void sButton4_Click_1(object sender, EventArgs e)
        {
            if (UphoneTb.Text == "")
            {
                MessageBox.Show("Enter the Users Phone Number");
            }
            else
            {
                Con.Open();
                string Myquary = "delete from UserTbl where Uphone='" + UphoneTb.Text + "'";
                SqlCommand cmd = new SqlCommand(Myquary, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                Con.Close();
                popularate();
            }
        }

        private void UserLevel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
