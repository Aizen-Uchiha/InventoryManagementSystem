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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WIZ;Initial Catalog=C:\USERS\ADMINISTRATOR\DOCUMENTS\INVENTORYDB.MDF;Integrated Security=True");

        private void label3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }
        void popularate()
        {
            try
            {
                Con.Open();
                string Myqurey = "select * from CategoriesTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myqurey, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CatogariesGV.DataSource = ds.Tables[0];
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
                SqlCommand cmd = new SqlCommand("insert into CategoriesTbl values('" + catoIdTb.Text + "','" + catoNameTb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Added");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update CategoriesTbl set CatName='" + catoNameTb.Text + "' where CatId='" + catoIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Updated");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void sButton3_Click(object sender, EventArgs e)
        {
            if (catoIdTb.Text == "")
            {
                MessageBox.Show("Enter the Category ID Number");
            }
            else
            {
                Con.Open();
                string Myquary = "delete from CategoriesTbl where CatId='" + catoIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(Myquary, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                Con.Close();
                popularate();
            }
        }

        private void CatogariesGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            catoIdTb.Text = CatogariesGV.SelectedRows[0].Cells[0].Value.ToString();
            catoNameTb.Text = CatogariesGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void ManageCatogaries_Load(object sender, EventArgs e)
        {
            popularate();
        }

        private void sButton4_Click(object sender, EventArgs e)
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
    }
}
