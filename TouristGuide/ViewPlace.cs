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
    public partial class ViewPlace : Form
    {
        public ViewPlace()
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
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
