using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cabsystem
{
    public partial class loginpage : Form
    {
        private SqlDataReader dr;
        private object cn;

        public loginpage()
        {
            InitializeComponent();
        }


        private void loginpage_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-ECN3NRD8;Initial Catalog=cab;Integrated Security=True");
            cn.Open();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (passtxt.Text != string.Empty || usertxt.Text != string.Empty)
            {

                SqlCommand cmd = new SqlCommand("select * from login where Username=('" + usertxt.Text + "' and Password='" + passtxt.Text + "')");  
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    dashboard f3 = new dashboard();
                    f3.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
