using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace cabsystem
{
    public partial class Driverregistration : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-ECN3NRD8;Initial Catalog=cab;Integrated Security=True");
        
        public Driverregistration()
        {

            InitializeComponent();
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

        private void submit_Click_1(object sender, EventArgs e)
        {
            cn.Open();

            if (fname.Text == string.Empty || lname.Text == string.Empty || email.Text == string.Empty || add.Text == string.Empty || pincode.Text == string.Empty || age.Text == string.Empty || q.Text == string.Empty || ln.Text == string.Empty || acn.Text == string.Empty)
            {
                MessageBox.Show("Please fill empty fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (firstname,lastname,email,address,pincode,age,qualification,licenseno,aadharno  )
                values ('" + fname.Text + "','" + lname.Text + "','" + email.Text + "','" + add.Text + "','" + pincode.Text + "','" + age.Text + "','" + q.Text + "','" + ln.Text + "','" + acn.Text + "')");
                cmd.ExecuteNonQuery();
                MessageBox.Show("Please select marital status", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (g1.Checked == true)
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into driversgender='" + g1.Text + "'");
                cmd.ExecuteNonQuery();

            }
            else if (g2.Checked == true)
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers gender='" + g2.Text + "'");
                cmd.ExecuteNonQuery();

            }
            else if (g3.Checked == true)
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers gender='" + g3.Text + "'");
                cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Please select gender", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (m1.Checked == true)
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (status)
                  values('" + m1.Text + "')");
                cmd.ExecuteNonQuery();

            }
            else if (m2.Checked == true)
            {

                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (status)
                  values('" + m2.Text + "')");
                cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Please select marital status", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            if (y.Checked == true)
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers yesno='" + y.Text + "'");
                cmd.ExecuteNonQuery();

            }
            else if (n.Checked == true)
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (yesno)
                  values('" + n.Text + "')");
                cmd.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("Please select if you have license or not", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




            cn.Close();

        }
    }
}
