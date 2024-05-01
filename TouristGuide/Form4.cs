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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\TouristGuideDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void button3_Click(object sender, EventArgs e)
        {
            if (areatb.Text == "" || usernametb.Text == "" || emailtb.Text == "" || phonetb.Text == "" || addresstb.Text == "" || passwordtb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into usertb(area,username,email,phoneno,address,password) values(@UA,@UN,@UE,@UPno,@UAdd,@UPass)", Con);
                    cmd.Parameters.AddWithValue("@UA", areatb.Text);
                    cmd.Parameters.AddWithValue("@UN", usernametb.Text);
                    cmd.Parameters.AddWithValue("@UE", emailtb.Text);
                    cmd.Parameters.AddWithValue("@UPno", phonetb.Text);
                    cmd.Parameters.AddWithValue("@UAdd", addresstb.Text);
                    cmd.Parameters.AddWithValue("@UPass", passwordtb.Text);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Recorded!");
                    Con.Close();
                    UserHome uh = new UserHome();
                    uh.Show();
                    this.Hide();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }
    }
}
