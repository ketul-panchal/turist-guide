using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TouristGuide
{
    public partial class feedback : Form
    {
        public feedback()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\TouristGuideDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 || comboBox5.SelectedIndex == -1 || comboBox6.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into feedbacktbl(username,Q1,Q2,Q3,Q4,Q5,Q6) values(@UN,@Q1,@Q2,@Q3,@Q4,@Q5,@Q6)", Con);
                    cmd.Parameters.AddWithValue("@UN", usernametb.Text);
                    cmd.Parameters.AddWithValue("@Q1", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@Q2", comboBox2.Text);
                    cmd.Parameters.AddWithValue("@Q3", comboBox3.Text);
                    cmd.Parameters.AddWithValue("@Q4", comboBox4.Text);
                    cmd.Parameters.AddWithValue("@Q5", comboBox5.Text);
                    cmd.Parameters.AddWithValue("@Q6", comboBox6.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Feedback Recorded!");
                    Con.Close();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
