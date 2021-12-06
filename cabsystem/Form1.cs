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
using System.Text.RegularExpressions;

namespace cabsystem
{
    public partial class signuppage : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-ECN3NRD8;Initial Catalog=cab;Integrated Security=True");

        public static object Current { get; internal set; }

        public signuppage()
        {
            InitializeComponent();
        }

        private void register_Click(object sender, EventArgs e)
        {

            if (ftxt.Text == string.Empty || ltxt.Text == string.Empty || etxt.Text == string.Empty || pass1txt.Text == string.Empty || pass2txt.Text == string.Empty)
            {

                MessageBox.Show("Please fill empty fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (pass1txt.Text != pass2txt.Text)
            {

                MessageBox.Show("password does not match ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into signup (Firstname,Lastname,Email,Username,Password  )
                values ('" + ftxt.Text + "','" + ltxt.Text + "','" + etxt.Text + "','" + utxt.Text + "','" + pass1txt.Text + "')");
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("data inserted successfully", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void etxt_val(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex email = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (etxt.Text.Length > 0)
            {
                if (email.IsMatch(etxt.Text))
                {
                    MessageBox.Show("valid email", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("invalid email", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {

            this.Hide();
            loginpage login = new loginpage();
            login.ShowDialog();
        }
    }
}
