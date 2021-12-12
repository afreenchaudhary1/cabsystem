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
            if (fname.Text == string.Empty || lname.Text == string.Empty || email.Text == string.Empty || add.Text == string.Empty || pincode.Text == string.Empty || age.Text == string.Empty || q.Text == string.Empty || ln.Text == string.Empty || acn.Text == string.Empty)
            {
                MessageBox.Show("Please fill empty fields", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
             
            }
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
        //public bool CheckRadioButtons(RadioButton radioButtonA, RadioButton radioButtonB)
        //{
            //none of them are selected
            //if (g1.Checked==true)
            //{
                //return false;
            //}
            //else
            //{
               // MessageBox.Show("You forgot to select a RadioButton!");
                //return true;
            //}
       // }
    }
}
