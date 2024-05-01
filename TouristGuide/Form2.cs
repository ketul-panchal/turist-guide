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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ShowPlace();
        }
         SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\TouristGuideDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");

         private void ShowPlace()
         {
             Con.Open();
             string Query = "Select * from paceTb";
             SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
             SqlCommandBuilder builder = new SqlCommandBuilder(sda);
             var ds = new DataSet();
             sda.Fill(ds);
             PlaceDGV.DataSource = ds.Tables[0];
             Con.Close();


         }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (placenametb.Text == "" || areatb.Text == "" || ptypetb.Text == "" || sealevel.Text == "" || destinationtb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("update paceTb set PName=@PN,area=@PA,PType=@PT,seaLevel=@SL,destination=@PD,date=@PDate,ByRoad=@BR,ByAir=@BA,ByOcean=@BO,ByTrain=@BT where placeID=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", PID.Text);
                    cmd.Parameters.AddWithValue("@PN", placenametb.Text);
                    cmd.Parameters.AddWithValue("@PA", areatb.Text);
                    cmd.Parameters.AddWithValue("@PT", ptypetb.Text);
                    cmd.Parameters.AddWithValue("@SL", sealevel.Text);
                    cmd.Parameters.AddWithValue("@PD", destinationtb.Text);
                    cmd.Parameters.AddWithValue("@PDate", date.Value.Date);
                    cmd.Parameters.AddWithValue("@BR", byroadtb.Text);
                    cmd.Parameters.AddWithValue("@BA", byairtb.Text);
                    cmd.Parameters.AddWithValue("@BO", byroadtb.Text);
                    cmd.Parameters.AddWithValue("@BT", bytraintb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Place Updated!");
                    Con.Close();
                    ShowPlace();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (PID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from paceTb where placeID=@PKey", Con);
                    cmd.Parameters.AddWithValue("@PKey", PID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Place Recorde Deleted");
                    Con.Close();
                    ShowPlace();
                    
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ManageUser obj = new ManageUser();
            obj.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 obj = new Form3();
            obj.Show();
            this.Hide();
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
           // this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4 obj = new Form4();
            obj.Show();
        }

        
    }
}
