using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace cabsystem
{
    public partial class Form6 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-ECN3NRD8;Initial Catalog=cab;Integrated Security=True");
        public Form6()
        {
            InitializeComponent();
        }

        private void DisplayData()
        {
            String str = "Server=localhost;Database=cab;Trusted_Connection=True";
            SqlConnection con = new SqlConnection(str);
            cn.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("select * from drivers",
            con);
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }
        private void home_Click(object sender, EventArgs e)
        {
            this.Hide();
            dashboard f3 = new dashboard();
            f3.ShowDialog();
        }

        private void vieww_Click(object sender, EventArgs e)
        {
            String str ="Server=localhost;Database=cab;Trusted_Connection=True";
            SqlConnection cn = new SqlConnection(str);
            cn.Open();
            SqlCommand cm = new SqlCommand(@"select * from drivers", cn);
            SqlDataReader adapt = cm.ExecuteReader();
            
            cn.Close();
            DisplayData();
            
         }

        private void delete_Click(object sender, EventArgs e)
        {
            if (fname.Text != string.Empty)
            {
             string str ="Server=localhost;Database=cab;Trusted_Connection=True";
            SqlConnection cn = new SqlConnection(str);
            cn.Open();
            string query = "Delete from drivers where id= " +
            fname.Text;
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataReader myreader;
                try
                {

                    myreader = cmd.ExecuteReader();
                    MessageBox.Show("successfully data Deleted", "user information");

                    while (myreader.Read())

                    {
                    }
                    cn.Close();

                }
                catch (Exception ec)
                {
                    MessageBox.Show(ec.Message);
                }
            }
            else
            {
                MessageBox.Show("enter ID which you want to delete");
            }

            DisplayData();
     }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
