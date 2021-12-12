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
            try
            {

                String str = "Server=localhost;Database=cab;Trusted_Connection=True";
                SqlConnection cn = new SqlConnection(str);
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from signup where Username='" + usertxt.Text + "' and Password='" + passtxt.Text + "'",cn);
                SqlDataReader sdr = cmd.ExecuteReader();
                //
                if (sdr.Read())
                {
                  

                    //usertxt.Text = (sdr["Username"]).ToString();
                    //passtxt.Text = (sdr["Password"]).ToString();
                    this.Hide();
                    dashboard f3 = new dashboard();
                    f3.ShowDialog();
                }
                else if(usertxt.Text == string.Empty || passtxt.Text == string.Empty)
                {
                    MessageBox.Show("please enter username password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("invalid username or password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                cn.Close();


            }


            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
             signuppage f1 = new signuppage();
            f1.ShowDialog();
        }
    }
}