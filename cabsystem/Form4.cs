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
    public partial class Form4 : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-ECN3NRD8;Initial Catalog=cab;Integrated Security=True");
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();

            if (fname.Text == string.Empty || lname.Text == string.Empty || email.Text == string.Empty || add.Text == string.Empty || pincode.Text == string.Empty || age.Text == string.Empty || q.Text == string.Empty || ln.Text == string.Empty || acn.Text == string.Empty || gender.Text == string.Empty || yesno.Text == string.Empty)
            {
                MessageBox.Show("Please fill empty fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (firstname,lastname,email,address,pincode,age,qualification,licenseno,aadharno,status,yesno  )
                values ('" + fname.Text + "','" + lname.Text + "','" + email.Text + "','" + add.Text + "','" + pincode.Text + "','" + age.Text + "','" + q.Text + "','" + ln.Text + "','" + acn.Text + "','" + gender.Text + "','" + yesno.Text + "')");
                cmd.ExecuteNonQuery();
                MessageBox.Show("data inserted succesfully", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            

            

            




            cn.Close();
        }

        private void email_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex emai = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (email.Text.Length > 0)
            {
                if (emai.IsMatch(email.Text))
                {
                    MessageBox.Show("valid email", "done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("invalid email", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
