using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TouristGuide
{
    public partial class UserHome : Form
    {
        public UserHome()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewPlace obj = new ViewPlace();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            feedback obj = new feedback();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}
