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
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
            ShowUsers();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Ketul\OneDrive\Documents\TouristGuideDb.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True");
        private void ShowUsers()
        {
            Con.Open();
            string Query = "Select * from usertb";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];
            Con.Close();


        }
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (UID.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from usertb where userID=@UKey", Con);
                    cmd.Parameters.AddWithValue("@UKey", UID.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Recorde Deleted");
                    Con.Close();
                    ShowUsers();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
