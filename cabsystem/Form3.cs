using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace cabsystem
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }

        private void reg2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cabregistration f3 = new Cabregistration();
            f3.ShowDialog();
        }

        private void driver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Drivers f3 = new Drivers();
            f3.ShowDialog();

        }

        private void cab_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cabdetail f3 = new Cabdetail();
            f3.ShowDialog();
        }
    }
}
