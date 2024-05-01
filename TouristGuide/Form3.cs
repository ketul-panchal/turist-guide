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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\TouristGuideDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pnametb.Text == "" || areatb.Text == "" || ptypetb.Text == "" || sealeveltb.Text == "" || destinationtb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into paceTb(PName,area,PType,seaLevel,destination,date,ByRoad,ByAir,ByOcean,ByTrain) values(@PN,@PA,@PT,@SL,@PD,@PDate,@BR,@BA,@BO,@BT)", Con);
                    cmd.Parameters.AddWithValue("@PN", Pnametb.Text);
                    cmd.Parameters.AddWithValue("@PA", areatb.Text);
                    cmd.Parameters.AddWithValue("@PT", ptypetb.Text);
                    cmd.Parameters.AddWithValue("@SL", sealeveltb.Text);
                    cmd.Parameters.AddWithValue("@PD", destinationtb.Text);
                    cmd.Parameters.AddWithValue("@PDate", date.Value.Date);
                    cmd.Parameters.AddWithValue("@BR", byroadtb.Text);
                    cmd.Parameters.AddWithValue("@BA", byairtb.Text);
                    cmd.Parameters.AddWithValue("@BO", byroadtb.Text);
                    cmd.Parameters.AddWithValue("@BT", bytraintb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Place Recorded!");
                    Con.Close();
                    
                   
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            adminHome obj = new adminHome();
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageUser obj = new ManageUser();
            obj.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 obj = new Form2();
            obj.Show();
        }
    }
}
