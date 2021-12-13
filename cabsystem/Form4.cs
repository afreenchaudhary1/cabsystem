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

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            //checkRadioButtons();
            if (fname.Text == string.Empty || lname.Text == string.Empty || email.Text == string.Empty || add.Text == string.Empty || pincode.Text == string.Empty || age.Text == string.Empty || q.Text == string.Empty || ln.Text == string.Empty || acn.Text == string.Empty)
            {
                MessageBox.Show("Please fill empty fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers  (First-name=@Fname,Last-name=@Lname,Email=@Email,Address=@Address,pincode=@Pincode,age=@Age,License-no=@License,Qualification=@Qualif,Aadhar-no=@Aadhar)");
                cmd.Parameters.AddWithValue("@Fname", fname.Text);
                cmd.Parameters.AddWithValue("@Lname", lname.Text);
                cmd.Parameters.AddWithValue("@Email", email.Text);
                cmd.Parameters.AddWithValue("@Address", add.Text);
                cmd.Parameters.AddWithValue("@Pincode", pincode.Text);
                cmd.Parameters.AddWithValue("@Age", age.Text);
                cmd.Parameters.AddWithValue("@License", ln.Text);
                cmd.Parameters.AddWithValue("@Qualification", q.Text);
                cmd.Parameters.AddWithValue("@Aadhar", acn.Text);
                //cmd.Parameters.AddWithValue("@Mobile", textBox6.Text);
                cmd.ExecuteNonQuery();
                
            }



            if(g1.Checked == true)
            {
                
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (Gender=female)");
                cmd.ExecuteNonQuery();
                
            }
            else if(g2.Checked == true)
            {
                
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (Gender=male)");
                cmd.ExecuteNonQuery();
                
            }
            else if(g3.Checked == true)
            {
                
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (Gender=others)");
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
                cmd.CommandText = (@"insert into drivers (status=married)");
                cmd.ExecuteNonQuery();
                
            }
            else if (m2.Checked == true)
            {
                
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into drivers (status=single)");
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
                cmd.CommandText = (@"insert into drivers (yesno=yes)");
                cmd.ExecuteNonQuery();
                
            }
            else if (n.Checked == true)
            {
                cn.Open();
                SqlCommand cmd = cn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = (@"insert into driver (yesno=no)");
                cmd.ExecuteNonQuery();
                
            }
            else
            {
                MessageBox.Show("Please select if you have license or not", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
