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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WIZ;Initial Catalog=C:\USERS\ADMINISTRATOR\DOCUMENTS\INVENTORYDB.MDF;Integrated Security=True;");
        void fillcatogary()
        {
            string query = "select * from CategoriesTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                CatCombo.ValueMember = "CatName";
                CatCombo.DataSource= dt;
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource= dt;
                Con.Close();
            }
            catch
            {

            }
        }
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            fillcatogary();
            popularate();
        }
        void popularate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        void FilterByCatogary()
        {
            try
            {
                Con.Open();
                string Myquary = "select * from ProductTbl where ProdCat='"+SearchCombo.SelectedValue.ToString()+"'";
                SqlDataAdapter da = new SqlDataAdapter(Myquary, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        void fillSearchCombo()
        {
            try
            {
                Con.Open();
                string Myqueery = "select * from CategoriesTbl where CatName='" + SearchCombo.SelectedValue.ToString()+"'";
                SqlDataAdapter da = new SqlDataAdapter(Myqueery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductGV.DataSource = ds.Tables[0];
                Con.Close();

            }
            catch
            {

            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
            //Application.Exit();
        }

        private void sButton1_Click(object sender, EventArgs e)
        {

            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values('" + ProdIdTb.Text + "','" + ProNameTb.Text + "','" + ProdBrandName.Text + "','" + ProQtyTb.Text + "','" + ProPriceTb.Text + "','"+ProDiscTb.Text+"','"+CatCombo.SelectedValue.ToString()+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Added");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void sButton3_Click(object sender, EventArgs e)
        {
            if (ProdIdTb.Text == "")
            {
                MessageBox.Show("Enter the Product ID");
            }
            else
            {
                Con.Open();
                string Myqueeery = "delete from ProductTbl where ProdID='" + ProdIdTb.Text + "'";
                SqlCommand cmd = new SqlCommand(Myqueeery, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                Con.Close();
                popularate();
            }
        }

        private void ProductGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ProdIdTb.Text = ProductGV.SelectedRows[0].Cells[0].Value.ToString();
            ProNameTb.Text = ProductGV.SelectedRows[0].Cells[1].Value.ToString();
            ProdBrandName.Text = ProductGV.SelectedRows[0].Cells[2].Value.ToString();
            ProDiscTb.Text = ProductGV.SelectedRows[0].Cells[3].Value.ToString();
            ProQtyTb.Text = ProductGV.SelectedRows[0].Cells[4].Value.ToString();
            ProPriceTb.Text = ProductGV.SelectedRows[0].Cells[5].Value.ToString();
            CatCombo.SelectedValue= ProductGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void sButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ProductTbl set ProdName='" + ProNameTb.Text + "',BrandName='"+ ProdBrandName.Text+"',ProdQty='" + ProQtyTb.Text + "',ProdPrice='" + ProPriceTb.Text + "',ProdDisc='" + ProDiscTb.Text + "',ProdCat='"+CatCombo.SelectedValue.ToString()+"' where ProdID='" + ProdIdTb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Updated");
                Con.Close();
                popularate();
            }
            catch
            {


            }
        }

        private void sButton5_Click(object sender, EventArgs e)
        {
            FilterByCatogary();
        }

        private void sButton6_Click(object sender, EventArgs e)
        {
            popularate();
        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

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
