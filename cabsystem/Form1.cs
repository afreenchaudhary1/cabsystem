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

namespace cabsystem
{
    public partial class signup_page : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-ECN3NRD8;Initial Catalog=cab;Integrated Security=True");
        public signup_page()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {
            
            cn.Open();
            if (ftxt.Text == string.Empty)
            {

                MessageBox.Show("firstname field is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (ltxt.Text == string.Empty)
            {

                MessageBox.Show("lastname field is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (etxt.Text == string.Empty)
            {

                MessageBox.Show("email field is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (pass1txt.Text != pass2txt.Text)
            {
                MessageBox.Show("Password does not match", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (pass1txt.Text == string.Empty)
            {

                MessageBox.Show("create password field is required", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (pass2txt.Text == string.Empty)
            {

                MessageBox.Show("please confirm password", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = (@"insert into signup (Firstname,Lastname,Email,Username,Password  )
                values ('" + ftxt.Text + "','" + ltxt.Text + "','" + etxt.Text + "','" + utxt.Text + "','" + pass1txt.Text + "')");
            cmd.ExecuteNonQuery();

            cn.Close();
            MessageBox.Show("data inserted successfully", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
       
    }
}
