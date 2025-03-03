using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            showyes();
            showBoom();
        }
        public void showyes()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();
            string sqlEmployee = "select Country From Suppliers group by Country Order by Country ASC";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmployee, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comBox1.DataSource = dt;
            comBox1.ValueMember = "Country";
            comBox1.DisplayMember = "Country";
            conn.Close();
        }
        public void showBoom()
        {
            SqlConnection conn = DBconnection.connectionNorthwind();
            string sqlEmployee = "select ShipCountry From Orders group by ShipCountry Order by ShipCountry ASC";
            SqlDataAdapter da = new SqlDataAdapter(sqlEmployee, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comBox2.DataSource = dt;
            comBox2.ValueMember = "ShipCountry";
            comBox2.DisplayMember = "ShipCountry";
            conn.Close();
        }

        private void dataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string supplierCountry = comBox1.Text;
            string shipCountry = comBox2.Text;

            SqlConnection conn = DBconnection.connectionNorthwind();
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            SqlCommand cmd = new SqlCommand("GetSupplierProductsByCountry", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SupplierCountry", supplierCountry);
            cmd.Parameters.AddWithValue("@ShipCountry", shipCountry);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dataGrid1.DataSource = dt;
            conn.Close();


        }

        private void dataGrid2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dataGrid1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productId = Convert.ToInt32(dataGrid1.Rows[e.RowIndex].Cells["ProductID"].Value);
                string shipCountry = comBox2.Text;
                string supplierCountry = comBox1.Text;

                SqlConnection conn = DBconnection.connectionNorthwind();
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("GetProductSalesByCountry", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductID", productId);
                cmd.Parameters.AddWithValue("@SupplierCountry ", supplierCountry);
                cmd.Parameters.AddWithValue("@ShipCountry", shipCountry);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGrid2.DataSource = dt;
            }
        }
    }
}
